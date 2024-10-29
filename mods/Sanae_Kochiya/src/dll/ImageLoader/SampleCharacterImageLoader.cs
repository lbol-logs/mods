using System;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Sanae_Kochiya.ImageLoader
{
	public sealed class SampleCharacterImageLoader
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
			cardImages.AutoLoad(cardTemplate, SampleCharacterImageLoader.file_extension, "", false);
			return cardImages;
		}

		public static ExhibitSprites LoadExhibitSprite(ExhibitTemplate exhibit)
		{
			ExhibitSprites exhibitSprites = new ExhibitSprites();
			Func<string, Sprite> func = (string s) => ResourceLoader.LoadSprite(exhibit.GetId() + s + SampleCharacterImageLoader.file_extension, BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		public static Sprite LoadUltLoader(UltimateSkillTemplate ult)
		{
			return SampleCharacterImageLoader.LoadSprite(ult.GetId());
		}

		public static Sprite LoadStatusEffectLoader(StatusEffectTemplate status)
		{
			return SampleCharacterImageLoader.LoadSprite(status.GetId());
		}

		public static Sprite LoadSprite(IdContainer ID)
		{
			return ResourceLoader.LoadSprite(ID + SampleCharacterImageLoader.file_extension, BepinexPlugin.embeddedSource, null, 1, null);
		}

		public static string file_extension = ".png";
	}
}
