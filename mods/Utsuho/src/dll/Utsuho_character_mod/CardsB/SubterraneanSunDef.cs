using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsB
{
	public sealed class SubterraneanSunDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SubterraneanSun";
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
			return new CardConfig(13470, "", 10, true, new string[0][], "元鬼玉", "元鬼玉", 0, false, true, true, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.RandomEnemy), new List<ManaColor> { ManaColor.Black }, false, default(ManaGroup), new ManaGroup?(default(ManaGroup)), null, new int?(10), new int?(14), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden | Keyword.Retain, Keyword.Forbidden | Keyword.Retain, false, Keyword.Battlefield, Keyword.Battlefield, new List<string>(), new List<string>(), new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(SubterraneanSunDef))]
		public sealed class SubterraneanSun : Card
		{
			public int RemoveCount
			{
				get
				{
					bool flag = base.Battle != null;
					int num;
					if (flag)
					{
						num = this.count + 1;
					}
					else
					{
						num = 1;
					}
					return num;
				}
			}

			public override IEnumerable<BattleAction> OnTurnStartedInHand()
			{
				this.count++;
				int num;
				for (int i = 0; i < this.count; i = num + 1)
				{
					List<Card> cards = (from card in base.Battle.EnumerateAllCards()
						where card.Zone != CardZone.Exile
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
						bool flag2 = base.Battle.EnemyGroup.Alives.Count<EnemyUnit>() != 0;
						if (flag2)
						{
							EnemyUnit target = base.Battle.EnemyGroup.Alives.Sample(base.GameRun.BattleRng);
							bool flag3 = target != null && target.IsAlive;
							if (flag3)
							{
								yield return base.AttackAction(target);
							}
							target = null;
						}
						yield return new RemoveCardAction(card2);
						bool flag4 = card2 == this;
						if (flag4)
						{
							break;
						}
						card2 = null;
					}
					cards = null;
					num = i;
				}
				yield break;
				yield break;
			}

			public int count = 0;
		}
	}
}
