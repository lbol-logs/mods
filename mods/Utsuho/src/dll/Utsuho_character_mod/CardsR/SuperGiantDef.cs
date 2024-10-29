using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class SuperGiantDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SuperGiant";
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
			return new CardConfig(13270, "", 10, true, new string[0][], "陨星锤", "陨星锤", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 6
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 6
			}), null, new int?(50), new int?(70), null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(SuperGiantDef))]
		public sealed class SuperGiant : Card
		{
			public override ManaGroup AdditionalCost
			{
				get
				{
					bool flag = base.Battle != null;
					ManaGroup manaGroup;
					if (flag)
					{
						List<Card> list = base.Battle.HandZone.Where(delegate(Card card)
						{
							if (card != this)
							{
								UtsuhoCard utsuhoCard = card as UtsuhoCard;
								if (utsuhoCard != null)
								{
									return utsuhoCard.isMass;
								}
							}
							return false;
						}).ToList<Card>();
						int count = list.Count;
						manaGroup = base.Mana * -count;
					}
					else
					{
						manaGroup = ManaGroup.Empty;
					}
					return manaGroup;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector, null);
				yield break;
			}
		}
	}
}
