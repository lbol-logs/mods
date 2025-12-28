using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using ReimuUnifierMod.Localization;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace ReimuUnifierMod.model
{
	public sealed class ReimuUnifierModel : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return BepinexPlugin.modUniqueID;
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			bool flag = ReimuUnifierModel.useInGameModel;
			ModelOption modelOption;
			if (flag)
			{
				modelOption = new ModelOption(ResourcesHelper.LoadSpineUnitAsync(ReimuUnifierModel.model_name));
			}
			else
			{
				modelOption = new ModelOption(ResourceLoader.LoadSpriteAsync(ReimuUnifierModel.model_name, BepinexPlugin.directorySource, 565, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
			}
			return modelOption;
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			bool flag = ReimuUnifierModel.useInGameModel;
			UniTask<Sprite> uniTask;
			if (flag)
			{
				uniTask = ResourcesHelper.LoadSpellPortraitAsync(ReimuUnifierModel.model_name);
			}
			else
			{
				uniTask = ResourceLoader.LoadSpriteAsync(ReimuUnifierModel.spellsprite_name, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			}
			return uniTask;
		}

		public override UnitModelConfig MakeConfig()
		{
			bool flag = ReimuUnifierModel.useInGameModel;
			UnitModelConfig unitModelConfig2;
			if (flag)
			{
				UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName(ReimuUnifierModel.model_name));
				unitModelConfig.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig2 = unitModelConfig;
			}
			else
			{
				UnitModelConfig unitModelConfig3 = ObjectExtensions.Copy<UnitModelConfig>(base.DefaultConfig());
				unitModelConfig3.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig3.Type = 0;
				unitModelConfig3.Offset = new Vector2(0f, -0.1f);
				unitModelConfig3.HasSpellPortrait = true;
				unitModelConfig2 = unitModelConfig3;
			}
			return unitModelConfig2;
		}

		public static bool useInGameModel = BepinexPlugin.useInGameModel;

		public static string model_name = (ReimuUnifierModel.useInGameModel ? BepinexPlugin.modelName : "ReimuUnifierModel.png");

		public static string spellsprite_name = "ReimuUnifierStand.png";
	}
}
