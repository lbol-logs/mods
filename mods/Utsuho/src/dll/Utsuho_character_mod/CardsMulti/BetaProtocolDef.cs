﻿using System;
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
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class BetaProtocolDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "BetaProtocol";
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
			return new CardConfig(13531, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, false, false, true, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(3), new int?(3), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Exile, Keyword.Exile, new List<string> { "RadiationStatus" }, new List<string> { "RadiationStatus" }, new List<string> { "GammaProtocol" }, new List<string> { "GammaProtocol+" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(BetaProtocolDef))]
		public sealed class BetaProtocol : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !this.IsUpgraded;
				if (flag)
				{
					Card[] cards = new Card[] { Library.CreateCard("GammaProtocol") };
					yield return new AddCardsToDrawZoneAction(cards, DrawZoneTarget.Random, AddCardsType.Normal);
					cards = null;
				}
				else
				{
					Card[] cards2 = new Card[] { Library.CreateCard("GammaProtocol+") };
					yield return new AddCardsToDrawZoneAction(cards2, DrawZoneTarget.Random, AddCardsType.Normal);
					cards2 = null;
				}
				int num;
				for (int i = 0; i < base.Value1; i = num + 1)
				{
					bool flag2 = base.Battle.HandZone.Count != 0;
					if (flag2)
					{
						Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
						foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
						{
							yield return action;
							action = null;
						}
						IEnumerator<BattleAction> enumerator = null;
						yield return new ExileCardAction(card);
						card = null;
					}
					num = i;
				}
				yield break;
				yield break;
			}
		}
	}
}