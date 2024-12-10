using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using Momiji.Source.Localization;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Momiji.Source.model
{
	public sealed class MomijiModelDef : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return new MomijiDef().UniqueId;
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			bool flag = MomijiModelDef.useInGameModel;
			ModelOption modelOption;
			if (flag)
			{
				modelOption = new ModelOption(ResourcesHelper.LoadSpineUnitAsync(MomijiModelDef.model_name));
			}
			else
			{
				modelOption = new ModelOption(ResourceLoader.LoadSpriteAsync(MomijiModelDef.model_name, BepinexPlugin.directorySource, 265, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
			}
			return modelOption;
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			bool flag = MomijiModelDef.useInGameModel;
			UniTask<Sprite> uniTask;
			if (flag)
			{
				uniTask = ResourcesHelper.LoadSpellPortraitAsync(MomijiModelDef.model_name);
			}
			else
			{
				uniTask = ResourceLoader.LoadSpriteAsync(MomijiModelDef.spellsprite_name, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			}
			return uniTask;
		}

		public override UnitModelConfig MakeConfig()
		{
			bool flag = MomijiModelDef.useInGameModel;
			UnitModelConfig unitModelConfig2;
			if (flag)
			{
				UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName(MomijiModelDef.model_name));
				unitModelConfig.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig2 = unitModelConfig;
			}
			else
			{
				UnitModelConfig unitModelConfig3 = ObjectExtensions.Copy<UnitModelConfig>(base.DefaultConfig());
				unitModelConfig3.Flip = BepinexPlugin.modelIsFlipped;
				unitModelConfig3.Type = 0;
				unitModelConfig3.Offset = new Vector2(-0.2f, -0.7f);
				unitModelConfig3.HasSpellPortrait = true;
				unitModelConfig2 = unitModelConfig3;
			}
			return unitModelConfig2;
		}

		public static bool useInGameModel = BepinexPlugin.useInGameModel;

		public static string model_name = (MomijiModelDef.useInGameModel ? BepinexPlugin.modelName : "MomijiModel.png");

		public static string spellsprite_name = "MomijiSpellCard.png";
	}
}
