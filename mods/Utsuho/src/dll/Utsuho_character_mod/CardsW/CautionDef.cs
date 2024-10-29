using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsW
{
	public sealed class CautionDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Caution";
		}

		public override CardImages LoadCardImages()
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(this, ".png", "", false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override CardConfig MakeConfig()
		{
			return new CardConfig(13580, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				White = 1,
				Any = 4
			}, new ManaGroup?(new ManaGroup
			{
				White = 1,
				Any = 2
			}), null, null, null, null, null, null, null, new int?(1), new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "CautionStatus", "Burst", "TimeIsLimited" }, new List<string> { "CautionStatus", "Burst", "TimeIsLimited" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(CautionDef))]
		public sealed class Caution : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.BuffAction<CautionStatus>(base.Value1, 0, 0, 0, 0.2f);
				yield break;
			}
		}
	}
}
