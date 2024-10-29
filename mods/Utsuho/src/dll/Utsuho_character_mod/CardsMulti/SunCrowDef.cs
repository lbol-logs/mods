using System;
using System.Collections.Generic;
using System.Linq;
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
using Utsuho_character_mod.Status;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class SunCrowDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SunCrow";
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
			return new CardConfig(13550, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 2,
				Red = 2,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 2,
				Red = 2,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(7), new int?(10), new int?(20), new int?(20), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Battlefield, Keyword.Battlefield, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(SunCrowDef))]
		public sealed class SunCrow : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int count = 0;
				int num;
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					List<Card> cards = (from card in base.Battle.EnumerateAllCards()
						where card != this
						select card).ToList<Card>();
					bool flag = cards.Count != 0;
					if (flag)
					{
						Card card2 = UsefulFunctions.RandomUtsuho(cards);
						foreach (BattleAction action in UsefulFunctions.RandomCheck(card2, base.Battle))
						{
							yield return action;
							action = null;
						}
						IEnumerator<BattleAction> enumerator = null;
						yield return new RemoveCardAction(card2);
						bool flag2 = card2 is UtsuhoCard;
						if (flag2)
						{
							num = count;
							count = num + 1;
						}
						num = count;
						count = num + 1;
						card2 = null;
					}
					cards = null;
					num = i;
				}
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1 * count), null, null, null, 0f, true);
				yield break;
				yield break;
			}
		}
	}
}
