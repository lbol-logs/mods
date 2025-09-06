using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using lvalonexrumia.Localization;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace lvalonexrumia.model
{
	public sealed class lvalonexrumiamodel : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return BepinexPlugin.modUniqueID;
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			bool flag = lvalonexrumiamodel.useInGameModel;
			ModelOption modelOption;
			if (flag)
			{
				modelOption = new ModelOption(ResourcesHelper.LoadSpineUnitAsync(lvalonexrumiamodel.model_name));
			}
			else
			{
				modelOption = new ModelOption(ResourceLoader.LoadSpriteAsync(lvalonexrumiamodel.model_name, BepinexPlugin.directorySource, 800, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
			}
			return modelOption;
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			bool flag = lvalonexrumiamodel.useInGameModel;
			UniTask<Sprite> uniTask;
			if (flag)
			{
				uniTask = ResourcesHelper.LoadSpellPortraitAsync(lvalonexrumiamodel.model_name);
			}
			else
			{
				uniTask = ResourceLoader.LoadSpriteAsync(lvalonexrumiamodel.spellsprite_name, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			}
			return uniTask;
		}

		public override UnitModelConfig MakeConfig()
		{
			bool flag = lvalonexrumiamodel.useInGameModel;
			UnitModelConfig unitModelConfig2;
			if (flag)
			{
				UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName(lvalonexrumiamodel.model_name));
				unitModelConfig.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig2 = unitModelConfig;
			}
			else
			{
				UnitModelConfig unitModelConfig3 = ObjectExtensions.Copy<UnitModelConfig>(base.DefaultConfig());
				unitModelConfig3.SpellColor = new List<Color32>
				{
					new Color32(230, 72, 230, byte.MaxValue),
					new Color32(213, 118, 223, byte.MaxValue),
					new Color32(213, 118, 223, 150),
					new Color32(208, 127, 220, byte.MaxValue)
				};
				unitModelConfig3.SpellScale = 2f;
				unitModelConfig3.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig3.Type = 0;
				unitModelConfig3.Offset = new Vector2(-0.1f, -0.1f);
				unitModelConfig3.HasSpellPortrait = true;
				unitModelConfig2 = unitModelConfig3;
			}
			return unitModelConfig2;
		}

		public static bool useInGameModel = BepinexPlugin.useInGameModel;

		public static string model_name = (lvalonexrumiamodel.useInGameModel ? BepinexPlugin.modelName : "lvalonexrumiamodel.png");

		public static string spellsprite_name = "lvalonexrumiaStand.png";
	}
}
