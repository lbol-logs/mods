using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

namespace Utsuho_character_mod
{
	public sealed class UtsuhoPlayerDef : PlayerUnitTemplate
	{
		public override IdContainer GetId()
		{
			return "Utsuho";
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override PlayerImages LoadPlayerImages()
		{
			PlayerImages playerImages = new PlayerImages();
			Sprite imprint = ResourceLoader.LoadSprite("CardImprint.png", BepinexPlugin.directorySource, null, 1, null);
			Sprite collectionIconLoading = ResourceLoader.LoadSprite("CollectionIcon.png", BepinexPlugin.directorySource, null, 1, null);
			Sprite selectionCircleIconLoading = ResourceLoader.LoadSprite("SelectionCircleIcon.png", BepinexPlugin.directorySource, null, 1, null);
			Sprite avatarLoading = ResourceLoader.LoadSprite("Avatar.png", BepinexPlugin.directorySource, null, 1, null);
			UniTask<Sprite> uniTask = ResourceLoader.LoadSpriteAsync("Stand.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			UniTask<Sprite> uniTask2 = ResourceLoader.LoadSpriteAsync("WinStand.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			UniTask<Sprite> uniTask3 = ResourceLoader.LoadSpriteAsync("DefeatedStand.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			UniTask<Sprite> uniTask4 = ResourceLoader.LoadSpriteAsync("PerfectWinIcon.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			UniTask<Sprite> uniTask5 = ResourceLoader.LoadSpriteAsync("WinIcon.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			UniTask<Sprite> uniTask6 = ResourceLoader.LoadSpriteAsync("DefeatedIcon.png", BepinexPlugin.directorySource, 100, GraphicsFormat.R8G8B8A8_SRGB, 1, FilterMode.Bilinear, SpriteMeshType.Tight, null, null, "file://");
			playerImages.SetStartPanelStand(new UniTask<Sprite>?(uniTask), null);
			playerImages.SetDeckStand(new UniTask<Sprite>?(uniTask), null);
			playerImages.SetWinStand(new UniTask<Sprite>?(uniTask2), null);
			playerImages.SetDefeatedStand(new UniTask<Sprite>?(uniTask3), null);
			playerImages.SetPerfectWinIcon(new UniTask<Sprite>?(uniTask4), null);
			playerImages.SetWinIcon(new UniTask<Sprite>?(uniTask5), null);
			playerImages.SetDefeatedIcon(new UniTask<Sprite>?(uniTask6), null);
			playerImages.SetCollectionIcon(() => collectionIconLoading);
			playerImages.SetSelectionCircleIcon(() => selectionCircleIconLoading);
			playerImages.SetInRunAvatarPic(() => avatarLoading);
			playerImages.SetCardImprint(() => imprint);
			return playerImages;
		}

		public override PlayerUnitConfig MakeConfig()
		{
			PlayerUnitConfig playerUnitConfig = ObjectExtensions.Copy<PlayerUnitConfig>(PlayerUnitConfig.FromId("Reimu"));
			return new PlayerUnitConfig("", 6, 0, new int?(0), "", "#e58c27", true, 80, new ManaGroup
			{
				Red = 2,
				Black = 2
			}, 10, 0, "UtsuhoUltR", "UtsuhoUltB", "ControlRod", "BlackSun", new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "FireBurst", "FireBurst", "Gridlock", "Gridlock", "Gridlock", "HellGeyser" }, new List<string> { "Shoot", "Shoot", "Boundary", "Boundary", "InverseBeam", "InverseBeam", "BlowAway", "BlowAway", "BlowAway", "ShootingStar" }, 2, 3);
		}

		public override PlayerUnitTemplate.EikiSummonInfo AssociateEikiSummon()
		{
			return new PlayerUnitTemplate.EikiSummonInfo(typeof(UtsuhoBossDef.Utsuho), null);
		}

		public static string name = "Utsuho";

		[EntityLogic(typeof(UtsuhoPlayerDef))]
		public sealed class Utsuho : PlayerUnit
		{
		}
	}
}
