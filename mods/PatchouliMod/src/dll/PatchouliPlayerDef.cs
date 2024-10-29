using System;
using Cysharp.Threading.Tasks;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.ImageLoader;
using PatchouliCharacterMod.Localization;
using UnityEngine;

namespace PatchouliCharacterMod
{
	public sealed class PatchouliPlayerDef : PlayerUnitTemplate
	{
		public UniTask<Sprite>? LoadSpellPortraitAsync { get; private set; }

		public override IdContainer GetId()
		{
			return PatchouliPlayerDef.modName;
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.PlayerUnitBatchLoc.AddEntity(this);
		}

		public override PlayerImages LoadPlayerImages()
		{
			return PatchouliImageLoader.LoadPlayerImages(PatchouliPlayerDef.playerName);
		}

		public override PlayerUnitConfig MakeConfig()
		{
			return new PlayerUnitConfig("PatchouliMod", 7, 0, new int?(0), "", "#d2c5df", true, 74, new ManaGroup
			{
				Blue = 2,
				Black = 2
			}, 85, 0, PatchouliLoadouts.UltimateSkillA, PatchouliLoadouts.UltimateSkillB, PatchouliLoadouts.ExhibitA, PatchouliLoadouts.ExhibitB, PatchouliLoadouts.DeckA, PatchouliLoadouts.DeckB, 3, 2);
		}

		public static string playerName = "Patchouli";

		public static string modName = "PatchouliMod";

		public static DirectorySource PatchouliDir = new DirectorySource("rmrfmaxx.lbol.PatchouliCharacterMod", "");

		[EntityLogic(typeof(PatchouliPlayerDef))]
		public sealed class PatchouliMod : PlayerUnit
		{
			public GameEvent<BoostEventArgs> Boosted { get; } = new GameEvent<BoostEventArgs>();

			public GameEvent<TriggerSignEventArgs> Spellcasting { get; } = new GameEvent<TriggerSignEventArgs>();

			public GameEvent<TriggerSignEventArgs> Spellcasted { get; } = new GameEvent<TriggerSignEventArgs>();

			public GameEvent<TriggerSignEventArgs> SignPassiveTriggering { get; } = new GameEvent<TriggerSignEventArgs>();

			public GameEvent<TriggerSignEventArgs> SignPassiveTriggered { get; } = new GameEvent<TriggerSignEventArgs>();

			public GameEvent<TriggerSignEventArgs> SignActiveTriggering { get; } = new GameEvent<TriggerSignEventArgs>();

			public GameEvent<TriggerSignEventArgs> SignActiveTriggered { get; } = new GameEvent<TriggerSignEventArgs>();
		}
	}
}
