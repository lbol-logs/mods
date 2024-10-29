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
using Utsuho_character_mod.Status;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class CrossfeedDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Crossfeed";
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
			return new CardConfig(13390, "", 10, true, new string[0][], "火激光", "火激光", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(12), new int?(14), new int?(10), new int?(8), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(CrossfeedDefinition))]
		public sealed class Crossfeed : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					return base.GetSeLevel<HeatStatus>();
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int level = base.GetSeLevel<HeatStatus>();
				int total = 0;
				Card[] array = base.Battle.HandZone.SampleManyOrAll(999, base.GameRun.BattleRng);
				bool flag = array.Length != 0;
				if (flag)
				{
					foreach (Card card in array)
					{
						UtsuhoCard uCard = card as UtsuhoCard;
						bool flag2 = uCard != null && uCard.isMass;
						if (flag2)
						{
							int num = total;
							total = num + 1;
						}
						uCard = null;
						card = null;
					}
					Card[] array2 = null;
				}
				yield return base.AttackAction(selector, null);
				bool flag3 = total == 0 && level != 0;
				if (flag3)
				{
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<HeatStatus>(), true, 0.1f);
				}
				else
				{
					bool flag4 = total != 0;
					if (flag4)
					{
						yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(total * base.Value1 - level), null, null, null, 0f, true);
					}
				}
				bool flag5 = level / base.Value2 != 0;
				if (flag5)
				{
					yield return new AddCardsToHandAction(Library.CreateCards<DarkMatterDef.DarkMatter>(level / base.Value2, false), AddCardsType.Normal);
				}
				yield break;
			}
		}
	}
}
