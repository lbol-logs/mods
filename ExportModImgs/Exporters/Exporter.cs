using BepInEx;
using Cysharp.Threading.Tasks;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

namespace ExportModImgs.Exporters
{
    public class Exporter<T> where T : class
    {
        // add guid here
        public Dictionary<string, string> targetGUIDs = new Dictionary<string, string>() {
            { "AyaPlayerUnit", "intoxicatedkid.ayashameimaru" },
            { "PKaguya", "aqing0601.PKaguya" },
            { "Utsuho", "zosit.lbol.test.utsuho" },
            { "YoumuMod", "rmrfmaxx.lbol.YoumuCharacterMod" },

            //"rmrfmaxx.lbol.PatchouliCharacterMod",
            //"rmrfmaxxc.lbol.YuyukoCharacterMod",
            //"llbol.ea.mima",
            //"xeno.lbol.character.Sanae_Kochiya",
        };

        /// <summary>
        /// template type => IDefinitionConsumer
        /// </summary>
        public Dictionary<Type, IExportProvider<T>> definitionConsumers = null;
        public bool addTimeStamp = false;

        private string rootPath = "";

        private string rootFolder = "Exporter";

        protected string subFolder;

        public IExPathProvider exPathProvider;

        public IPostConsume<T> postProcess = new EmptyPostConsume<T>();

        public string RootFolder { get => rootFolder; }
        public string RootPath { get => rootPath; }

        public Exporter(string rootPath = "", string rootFolder = "Exporter")
        {
            var exPathImpl = new ExportPath();
            exPathProvider = exPathImpl;
            this.rootPath = rootPath;
            if (string.IsNullOrEmpty(this.rootPath))
                this.rootPath = Path.Join(Application.dataPath, "..");
            if (rootFolder != null)
                this.rootFolder = rootFolder;
        }


        public void HookSelf()
        {
            EntityManager.AddPostLoadAction(() => ExportAll());
        }


        public void ExportAll()
        {

            string suffix = addTimeStamp ? $"_{DateTime.Now:yyyy-MM-dd_HH.mm.ss}" : "";
            foreach (KeyValuePair<string, string> kvp in targetGUIDs)
            {
                string id = kvp.Key;
                string guid = kvp.Value;

                Log.LogInfo($"Exporting {guid}...");
                try
                {
                    Export(id, guid, suffix);
                }
                catch (Exception ex)
                {
                    Log.LogError(ex);
                }
                Log.LogDebug($"Done exporting {guid}!");
            }
        }

        public void Export(string id, string guid, string suffix = "")
        {
            if (!BepInEx.Bootstrap.Chainloader.PluginInfos.TryGetValue(guid, out var pluginInfo))
            {
                Log.LogWarning($"Mod with {guid} was not loaded.");
                return;
            }

            var modAss = pluginInfo.Instance.GetType().Assembly;

            if (!EntityManager.Instance.sideloaderUsers.userInfos.TryGetValue(modAss, out var userInfo))
            {
                Log.LogWarning($"Mod with {guid} was not registered with Sideloader.");
                return;
            }

            if (userInfo?.definitionInstances == null)
            {
                Log.LogWarning($"Mod with {guid} was probably hot loaded. Aborting.");
                return;
            }


            var exportRoot = Path.Join(rootPath, rootFolder);
            exportRoot = $"{exportRoot}{suffix}";
            exportRoot = Path.Join(exportRoot, id);
            exportRoot = Path.Join(exportRoot, subFolder);

            foreach (var ed in userInfo.definitionInstances.Values)
            {
                //potential sideloader jank?
                if (ed == null)
                    continue;

                var templateType = ed.TemplateType();

                if (!definitionConsumers.TryGetValue(templateType, out var definitionConsumer))
                    continue;

                var exportPath = Path.Join(exportRoot, exPathProvider.ExSubDirs(ed));

                Directory.CreateDirectory(exportPath);


                T exTarget = definitionConsumer.Provide(ed);


                if (exTarget == null)
                    continue;

                string prefix = Source.LegalizeFileName(exPathProvider.ExportFilePrefix(ed));

                postProcess.Process(exTarget, exportPath, prefix);
            }
        }
    }


    public class ExportPath : IExPathProvider
    {
        public virtual string ExSubDirs(EntityDefinition entityDefinition)
        {
            var rez = entityDefinition.TemplateType().Name;
            // suboptmal sideloader api, not all definition have entity types
            try
            {
                rez = entityDefinition.EntityType().Name;
            }
            catch (InvalidDataException)
            { }
            return rez;

        }

        public virtual string ExportFilePrefix(EntityDefinition entityDefinition)
        {
            return entityDefinition.GetId().ToString();
        }
    }

}
