using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod
{
	public sealed class UtsuhoModelDef : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return new UtsuhoPlayerDef().UniqueId;
		}

		public override LocalizationOption LoadLocalization()
		{
			return UsefulFunctions.LocalizationModel(BepinexPlugin.directorySource);
		}

		public override ModelOption LoadModelOptions()
		{
			return new ModelOption(ResourceLoader.LoadSpriteAsync("Utsuho_Sprite.png", BepinexPlugin.directorySource, 56, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"));
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			return ResourceLoader.LoadSpriteAsync("SpellCard.png", BepinexPlugin.directorySource, 336, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
		}

		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName("Reimu"));
			unitModelConfig.Flip = true;
			unitModelConfig.Type = 0;
			unitModelConfig.Offset = new Vector2(0f, 0.04f);
			unitModelConfig.SpellPosition = new Vector2(-1000f, 300f);
			unitModelConfig.SpellScale = 0.7f;
			unitModelConfig.SpellColor = new Color32[]
			{
				new Color32(104, 15, 5, byte.MaxValue),
				new Color32(byte.MaxValue, 46, 72, byte.MaxValue),
				new Color32(74, 0, 1, 150),
				new Color32(byte.MaxValue, 46, 72, byte.MaxValue)
			};
			return unitModelConfig;
		}
	}
}
