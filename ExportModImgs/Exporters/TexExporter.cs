using LBoL.EntityLib.Cards.Character.Sakuya;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

                    var upId = ct.MakeConfig().UpgradeImageId;
                    texContainer.dic.Add(new TexContainerItem() { Texture2D = imgs.upgrade, Name = upId });

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



    public class UpgradedImgExporter : Exporter<Texture2D>
    {

        public UpgradedImgExporter() : base()
        {
            subFolder = "images";

            definitionConsumers = new Dictionary<Type, IExportProvider<Texture2D>>()
            {
                [typeof(CardTemplate)] = new DefinitionConsumer<Texture2D>(ed => {
                    if (ed is CardTemplate ct)
                    {
                        return ct.LoadCardImages()?.upgrade;
                    }
                    return null;
                })
            };

            exPathProvider = new ExportPathForUpgrade();

            postProcess = new TexExport();
        }


        public class TexExport : IPostConsume<Texture2D>
        {
            public void Process(Texture2D input, string path, string prefix)
            {
                var texBytes = ImageConversion.EncodeToPNG(input);
                File.WriteAllBytes(path + ".png", texBytes);
            }
        }

        public class ExportPathForUpgrade : ExportPath
        {
            public override string ExportFilePrefix(EntityDefinition ed)
            {
                if (ed is CardTemplate ct)
                {
                    var upId = ct.MakeConfig().UpgradeImageId;
                    if (!string.IsNullOrEmpty(upId))
                        return upId;
                }

                return base.ExportFilePrefix(ed);
            }
        }

    }


}