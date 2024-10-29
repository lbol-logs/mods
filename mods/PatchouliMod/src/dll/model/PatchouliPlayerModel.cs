using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using PatchouliCharacterMod.Localization;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace PatchouliCharacterMod.model
{
	public sealed class PatchouliPlayerModel : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return new PatchouliPlayerDef().UniqueId;
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			return new ModelOption(ResourceLoader.LoadSpriteAsync(this.model_name, BepinexPlugin.directorySource, 565, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			return ResourceLoader.LoadSpriteAsync(this.spellsprite_name, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
		}

		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(base.DefaultConfig());
			unitModelConfig.Flip = true;
			unitModelConfig.Type = 0;
			unitModelConfig.Offset = new Vector2(0f, -0.1f);
			unitModelConfig.HasSpellPortrait = true;
			return unitModelConfig;
		}

		public string model_name = "PatchouliModel.png";

		public string spellsprite_name = "PatchouliStand.png";
	}
}
