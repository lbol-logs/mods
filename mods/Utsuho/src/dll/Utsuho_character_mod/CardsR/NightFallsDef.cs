using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.CardsB;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class NightFallsDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "NightFalls";
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
			return new CardConfig(13200, "", 10, true, new string[0][], "病气A", "病气A", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(4), new int?(7), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(NightFallsDef))]
		public sealed class NightFalls : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					int num = 0;
					bool flag = base.Battle != null;
					int num2;
					if (flag)
					{
						Card[] array = base.Battle.HandZone.SampleManyOrAll(999, base.GameRun.BattleRng);
						bool flag2 = array.Length != 0;
						if (flag2)
						{
							foreach (Card card in array)
							{
								UtsuhoCard utsuhoCard = card as UtsuhoCard;
								bool flag3 = utsuhoCard != null && utsuhoCard.isMass;
								if (flag3)
								{
									num++;
								}
								bool flag4 = card == this;
								if (flag4)
								{
									num++;
								}
							}
						}
						num2 = base.Value1 * (this.AddCount + num);
					}
					else
					{
						num2 = 0;
					}
					return num2;
				}
			}

			public int AddCount
			{
				get
				{
					bool flag = base.Battle != null;
					int num;
					if (flag)
					{
						num = base.Battle.MaxHand - base.Battle.HandZone.Count;
					}
					else
					{
						num = 0;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int num = this.AddCount;
				yield return new AddCardsToHandAction(Library.CreateCards<DarkMatterDef.DarkMatter>(num, false), AddCardsType.Normal);
				yield return base.AttackAction(selector, null);
				yield break;
			}
		}
	}
}
