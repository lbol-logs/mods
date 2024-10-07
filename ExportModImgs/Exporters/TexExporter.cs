using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoLEntitySideloader.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace ExportModImgs.Exporters
{

    public class TexContainer
    {
        public List<TexContainerItem> dic = new List<TexContainerItem>();
    }

    public class TexContainerItem
    {
        public string Name { get; set; } = "";
        public string SubFolder { get; set; } = "";
        public Texture2D Texture2D { get; set; }
    }

    public class TexExporter : Exporter<TexContainer>
    {



        public TexExporter() : base()
        {
            subFolder = "images";

            definitionConsumers = new Dictionary<Type, IExportProvider<TexContainer>>()
            {
                [typeof(CardTemplate)] = new CardTex(),
                [typeof(ExhibitTemplate)] = new ExTex(),
                [typeof(StatusEffectTemplate)] = new SeTex(),
                [typeof(UltimateSkillTemplate)] = new DefinitionConsumer<TexContainer>(ed => {
                    var tex = (ed as UltimateSkillTemplate)?.LoadSprite()?.texture;
                    var texContainer = new TexContainer();
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = tex });
                    return texContainer;
                }),
                [typeof(PlayerUnitTemplate)] = new PUTex()
            };
            postProcess = new TexExport();
        }

        public class TexExport : IPostConsume<TexContainer>
        {
            public void Process(TexContainer input, string path, string prefix)
            {

                foreach (var item in input.dic)
                {
                    if (item.Texture2D == null)
                        continue;
                    var texBytes = ImageConversion.EncodeToPNG(item.Texture2D);
                    if (texBytes != null && texBytes.Length > 0)
                    {
                        string name;

                        string _path = path;
                        if (item.Name == "")
                        {
                            name = prefix;
                        }
                        else
                        {
                            name = item.Name;
                        }
                        if (item.SubFolder != "")
                        {
                            _path = Path.Join(_path, item.SubFolder);
                            Directory.CreateDirectory(_path);
                        }
                        File.WriteAllBytes($"{_path}/{name}.png", texBytes);
                    }

                }
            }
        }

        static void TypeWarning(EntityDefinition ed, string correctType) => Log.LogWarning($"{ed.GetType()} is not {correctType}");

        public class CardTex : IExportProvider<TexContainer>
        {
            public TexContainer Provide(EntityDefinition entityDefinition)
            {
                if (entityDefinition is CardTemplate ct)
                {
                    var texContainer = new TexContainer();
                    var imgs = ct.LoadCardImages();
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs?.main });

                    CardConfig config = ct.MakeConfig();
                    string upgradeImageId = config.UpgradeImageId;
                    if (!upgradeImageId.IsNullOrEmpty())
                    {
                        string imageId = config.ImageId;
                        if (imageId != upgradeImageId)
                        {
                            texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.upgrade, Name = upgradeImageId });
                        }
                    }

                    return texContainer;
                }
                TypeWarning(entityDefinition, nameof(CardTemplate));
                return null;
            }
        }

        public class ExTex : IExportProvider<TexContainer>
        {
            public TexContainer Provide(EntityDefinition entityDefinition)
            {
                if (entityDefinition is ExhibitTemplate ext)
                {
                    var texContainer = new TexContainer();
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = ext.LoadSprite()?.main?.texture });
                    return texContainer;
                }
                TypeWarning(entityDefinition, nameof(ExhibitTemplate));
                return null;
            }
        }


        public class SeTex : IExportProvider<TexContainer>
        {
            public TexContainer Provide(EntityDefinition entityDefinition)
            {
                if (entityDefinition is StatusEffectTemplate set)
                {
                    var texContainer = new TexContainer();
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = set.LoadSprite()?.texture });
                    return texContainer;
                }
                TypeWarning(entityDefinition, nameof(StatusEffectTemplate));
                return null;
            }
        }

        private class PUTex : IExportProvider<TexContainer>
        {
            public TexContainer Provide(EntityDefinition ed)
            {
                if (ed is PlayerUnitTemplate pu)
                {
                    var texContainer = new TexContainer();
                    var imgs = pu.LoadPlayerImages();
                    string id = pu.GetId();

                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.LoadCardBack()?.texture, SubFolder = "watermarks", Name = id });
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.LoadSelectionCircleIcon()?.texture, SubFolder = "avatars", Name = id });
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.LoadDefeatedIcon()?.texture, SubFolder = "results", Name = id + "Failure" });
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.LoadWinIcon()?.texture, SubFolder = "results", Name = id + "Normal" });
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.LoadPerfectWinIcon()?.texture, SubFolder = "results", Name = id + "TrueEnd" });


                    return texContainer;
                }
                TypeWarning(ed, nameof(PlayerUnitTemplate));
                return null;
            }
        }
    }
}