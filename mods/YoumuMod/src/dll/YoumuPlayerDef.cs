using System;
using Cysharp.Threading.Tasks;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using YoumuCharacterMod.ImageLoader;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod
{
	public sealed class YoumuPlayerDef : PlayerUnitTemplate
	{
		public UniTask<Sprite>? LoadSpellPortraitAsync { get; private set; }

		public override IdContainer GetId()
		{
			return YoumuPlayerDef.modName;
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.PlayerUnitBatchLoc.AddEntity(this);
		}

		public override PlayerImages LoadPlayerImages()
		{
			return YoumuImageLoader.LoadPlayerImages(YoumuPlayerDef.playerName);
		}

		public override PlayerUnitConfig MakeConfig()
		{
			return new PlayerUnitConfig("Youmu", 6, 0, new int?(0), "", "#00b789", true, 77, new ManaGroup
			{
				Green = 2,
				White = 2
			}, 50, 0, YoumuLoadouts.UltimateSkillA, YoumuLoadouts.UltimateSkillB, YoumuLoadouts.ExhibitA, YoumuLoadouts.ExhibitB, YoumuLoadouts.DeckA, YoumuLoadouts.DeckB, 2, 2);
		}

		public static string playerName = "Youmu";

		public static string modName = "YoumuMod";

		public static DirectorySource YoumuDir = new DirectorySource("rmrfmaxx.lbol.YoumuCharacterMod", "");

		[EntityLogic(typeof(YoumuPlayerDef))]
		public sealed class YoumuMod : PlayerUnit
		{
		}
	}
}
