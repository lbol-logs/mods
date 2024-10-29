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
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class SpatialRendDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SpatialRend";
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
			return new CardConfig(13524, "", 10, true, new string[0][], "BlackFairy3", "BlackFairy3", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 2
			}), null, new int?(20), new int?(20), null, null, null, null, new int?(4), new int?(4), new int?(10), new int?(15), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile, Keyword.Accuracy | Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(SpatialRendDef))]
		public sealed class SpatialRend : Card
		{
			public int doubleValue
			{
				get
				{
					return 2 * base.Value2;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					base.DeltaDamage = 0;
					int num;
					for (int i = 0; i < base.Value1; i = num + 1)
					{
						bool flag2 = base.Battle.ExileZone.Count != 0 && base.Battle.HandZone.Count != base.Battle.MaxHand;
						if (flag2)
						{
							Card[] exileZone = base.Battle.ExileZone.Where((Card card) => card.Id != "NightMana1" && card.Id != "NightMana2" && card.Id != "NightMana3" && card.Id != "NightMana4").ToArray<Card>();
							bool flag3 = exileZone.Length != 0;
							if (flag3)
							{
								Card card2 = UsefulFunctions.RandomUtsuho(exileZone);
								foreach (BattleAction action in UsefulFunctions.RandomCheck(card2, base.Battle))
								{
									yield return action;
									action = null;
								}
								IEnumerator<BattleAction> enumerator = null;
								UtsuhoCard uCard = card2 as UtsuhoCard;
								bool flag4 = uCard != null && uCard.isMass;
								if (flag4)
								{
									base.DeltaDamage += base.Value2 * 2;
								}
								else
								{
									base.DeltaDamage += base.Value2;
								}
								yield return new MoveCardAction(card2, CardZone.Hand);
								card2 = null;
								uCard = null;
							}
							exileZone = null;
						}
						num = i;
					}
					yield return base.AttackAction(selector, null);
					base.DeltaDamage = 0;
					yield break;
				}
				yield break;
				yield break;
			}
		}
	}
}
