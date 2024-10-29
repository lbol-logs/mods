using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using Sanae_Kochiya.Source.Localization;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Sanae_Kochiya.model
{
	public sealed class SampleCharacterModel : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return new SampleCharacterPlayerDef().UniqueId;
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			bool flag = SampleCharacterModel.useInGameModel;
			ModelOption modelOption;
			if (flag)
			{
				modelOption = new ModelOption(ResourcesHelper.LoadSpineUnitAsync(SampleCharacterModel.model_name));
			}
			else
			{
				modelOption = new ModelOption(ResourceLoader.LoadSpriteAsync(SampleCharacterModel.model_name, BepinexPlugin.directorySource, 565, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
			}
			return modelOption;
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			bool flag = SampleCharacterModel.useInGameModel;
			UniTask<Sprite> uniTask;
			if (flag)
			{
				uniTask = ResourcesHelper.LoadSpellPortraitAsync(SampleCharacterModel.model_name);
			}
			else
			{
				uniTask = ResourceLoader.LoadSpriteAsync(SampleCharacterModel.spellsprite_name, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			}
			return uniTask;
		}

		public override UnitModelConfig MakeConfig()
		{
			bool flag = SampleCharacterModel.useInGameModel;
			UnitModelConfig unitModelConfig2;
			if (flag)
			{
				UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName(SampleCharacterModel.model_name));
				unitModelConfig.Flip = BepinexPlugin.model_is_flipped;
				unitModelConfig2 = unitModelConfig;
			}
			else
			{
				UnitModelConfig unitModelConfig3 = ObjectExtensions.Copy<UnitModelConfig>(base.DefaultConfig());
				unitModelConfig3.Flip = BepinexPlugin.model_is_flipped;
				unitModelConfig3.Type = 0;
				unitModelConfig3.Offset = new Vector2(0f, -0.1f);
				unitModelConfig3.HasSpellPortrait = true;
				unitModelConfig2 = unitModelConfig3;
			}
			return unitModelConfig2;
		}

		public static bool useInGameModel = BepinexPlugin.useInGameModel;

		public static string model_name = (SampleCharacterModel.useInGameModel ? BepinexPlugin.model_name : "SampleCharacterModel.png");

		public static string spellsprite_name = "SampleCharacterStand.png";
	}
}
