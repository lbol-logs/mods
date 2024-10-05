using LBoLEntitySideloader.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static ExportModImgs.Exporters.TexExporter;
using UnityEngine;
using LBoLEntitySideloader.ReflectionHelpers;
using System.IO.Pipes;
using System.Text.RegularExpressions;
using HarmonyLib;
using System.Reflection;
using System.Linq;

namespace ExportModImgs.Exporters
{
    public class ConfigExporter : Exporter<object>
    {
        public ConfigExporter() : base()
        {
            subFolder = "configs";

            var configProvider = new ConfigProvider();
            definitionConsumers = new Dictionary<Type, IExportProvider<object>>()
            {
                [typeof(CardTemplate)] = configProvider,
                [typeof(ExhibitTemplate)] = configProvider,
                [typeof(StatusEffectTemplate)] = configProvider,
                [typeof(UltimateSkillTemplate)] = configProvider,
                [typeof(PlayerUnitTemplate)] = configProvider,
                [typeof(EnemyUnitTemplate)] = configProvider,
            };
            postProcess = new ConfigExport();
        }

        public class ConfigProvider : IExportProvider<object>
        {

            static Dictionary<Type, MethodInfo> miCache = new Dictionary<Type, MethodInfo>();

            public object Provide(EntityDefinition ed)
            {
                var it = ed.GetType().GetInterfaces().FirstOrDefault(i => i.Name.StartsWith("IConfigProvider"));
                if (it != null)
                {
                    if (!miCache.TryGetValue(it, out var mi))
                    { 
                        mi = it.GetMethod("MakeConfig", AccessTools.allDeclared);
                        miCache[it] = mi;
                    }
                    return mi.Invoke(ed, new object[] { });
                }
                return null;
            }
        }



        public class ConfigExport : IPostConsume<object>
        {
            public void Process(object conf, string path, string prefix)
            {
                using (FileStream fileStream = File.Open($"{path}/{prefix}.txt", FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8) { AutoFlush = true })
                    {
                        var configType = conf.GetType();
                        string text = "";
                        try
                        {
                            text = conf.ToString();

                        }
                        catch (Exception ex)
                        {
                        Log.LogError($"{ConfigReflection.GetIdField(configType).GetValue(conf)}: \n{ex}");
                    }

                    streamWriter.WriteLine(text);
                    //streamWriter.WriteLine("------------------------");
                }
            }
            }
        }
    }

}
