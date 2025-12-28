using System;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace ReimuUnifierMod.ImageLoader
{
	public sealed class ReimuUnifierImageLoader
	{
		public static PlayerImages LoadPlayerImages(string name)
		{
			PlayerImages playerImages = new PlayerImages();
			playerImages.AutoLoad(name, (string s) => ResourceLoader.LoadSprite(s, BepinexPlugin.directorySource, 100, 1, FilterMode.Bilinear, true, null, null), (string s) => ResourceLoader.LoadSpriteAsync(s, BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://"), 2, ".png", "");
			return playerImages;
		}

		public static CardImages LoadCardImages(CardTemplate cardTemplate)
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(cardTemplate, ReimuUnifierImageLoader.file_extension, "", false);
			return cardImages;
		}

		public static ExhibitSprites LoadExhibitSprite(ExhibitTemplate exhibit)
		{
			return new ExhibitSprites
			{
				main = ResourceLoader.LoadSprite(exhibit.GetId() + ReimuUnifierImageLoader.file_extension, BepinexPlugin.embeddedSource, null, 1, null)
			};
		}

		public static Sprite LoadUltLoader(UltimateSkillTemplate ult)
		{
			return ReimuUnifierImageLoader.LoadSprite(ult.GetId());
		}

		public static Sprite LoadStatusEffectLoader(StatusEffectTemplate status)
		{
			return ReimuUnifierImageLoader.LoadSprite(status.GetId());
		}

		public static Sprite LoadSprite(IdContainer ID)
		{
			return ResourceLoader.LoadSprite(ID + ReimuUnifierImageLoader.file_extension, BepinexPlugin.embeddedSource, null, 1, null);
		}

		public static string file_extension = ".png";
	}
}
