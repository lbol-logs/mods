using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsR
{
	public sealed class SpaceScannerDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SpaceScanner";
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
			return new CardConfig(13090, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Common, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, new int?(5), new int?(5), null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Scry, Keyword.Scry, new List<string>(), new List<string>(), new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(SpaceScannerDef))]
		public sealed class SpaceScanner : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				Card[] cards = new Card[]
				{
					Library.CreateCard("DarkMatter"),
					Library.CreateCard("DarkMatter")
				};
				yield return new AddCardsToDrawZoneAction(cards, DrawZoneTarget.Random, AddCardsType.Normal);
				yield return new ScryAction(base.Scry);
				yield return new DrawCardAction();
				yield break;
			}
		}
	}
}
