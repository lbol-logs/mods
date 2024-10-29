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

namespace Utsuho_character_mod.CardsR
{
	public sealed class GridlockDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Gridlock";
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
			return new CardConfig(13020, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, false, true, false, true, Rarity.Common, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, new int?(10), new int?(13), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Basic, Keyword.Basic, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(GridlockDef))]
		public sealed class Gridlock : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.DefenseAction(true);
				yield break;
			}
		}
	}
}
