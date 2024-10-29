using System;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace YoumuCharacterMod.ImageLoader
{
	public sealed class YoumuImageLoader
	{
		public static PlayerImages LoadPlayerImages(string name)
		{
			PlayerImages playerImages = new PlayerImages();
			playerImages.AutoLoad(name, (string s) => ResourceLoader.LoadSprite(s, YoumuPlayerDef.YoumuDir, 100, 1, FilterMode.Bilinear, true, null, null), (string s) => ResourceLoader.LoadSpriteAsync(s, YoumuPlayerDef.YoumuDir, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"), 2, ".png", "");
			return playerImages;
		}

		public static CardImages LoadCardImages(CardTemplate cardTemplate)
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(cardTemplate, ".png", "", false);
			return cardImages;
		}

		public static ExhibitSprites LoadExhibitSprite(ExhibitTemplate exhibit)
		{
			return new ExhibitSprites
			{
				main = ResourceLoader.LoadSprite(exhibit.GetId() + ".png", BepinexPlugin.embeddedSource, null, 1, null)
			};
		}

		public static Sprite LoadUltLoader(UltimateSkillTemplate ult)
		{
			return YoumuImageLoader.LoadSprite(ult.GetId());
		}

		public static Sprite LoadStatusEffectLoader(StatusEffectTemplate status)
		{
			return YoumuImageLoader.LoadSprite(status.GetId());
		}

		private static Sprite LoadSprite(IdContainer ID)
		{
			return ResourceLoader.LoadSprite(ID + ".png", BepinexPlugin.embeddedSource, null, 1, null);
		}
	}
}
