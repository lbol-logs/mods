using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(carddearswordDef))]
	public sealed class carddearsword : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 5, true);
			}
		}

		public override IEnumerable<BattleAction> OnTurnStartedInHand()
		{
			return this.GetPassiveActions();
		}

		public override IEnumerable<BattleAction> GetPassiveActions()
		{
			bool flag = !base.Summoned || base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield break;
			}
			base.NotifyActivating();
			base.Loyalty += base.PassiveCost;
			int num;
			for (int i = 0; i < base.Battle.FriendPassiveTimes; i = num + 1)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					break;
				}
				yield return PerformAction.Sfx("FairySupport", 0f);
				yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Value1, false), AddCardsType.Normal);
				num = i;
			}
			yield break;
		}

		public override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			foreach (BattleAction item in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return item;
				item = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebloodmark>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
					if (battleShouldEnd2)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
				yield return base.SkillAnime;
			}
			else
			{
				base.Loyalty += base.UltimateCost;
				base.UltimateUsed = true;
				yield return new ApplyStatusEffectAction<sedearsword>(base.Battle.Player, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield return base.SkillAnime;
			}
			yield break;
			yield break;
		}
	}
}
