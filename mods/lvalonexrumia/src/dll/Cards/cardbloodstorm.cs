using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbloodstormDef))]
	public sealed class cardbloodstorm : lvalonexrumiaCard
	{
		public override bool OnExileVisual
		{
			get
			{
				return false;
			}
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool flag = base.Battle.BattleShouldEnd || srcZone != CardZone.Hand;
			IEnumerable<BattleAction> enumerable;
			if (flag)
			{
				enumerable = null;
			}
			else
			{
				enumerable = this.LeaveHandReactor();
			}
			return enumerable;
		}

		private IEnumerable<BattleAction> LeaveHandReactor()
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new PlayCardAction(this);
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			foreach (Unit enemy in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				bool isAlive = enemy.IsAlive;
				if (isAlive)
				{
					yield return new ApplyStatusEffectAction<sebleed>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					bool flag = this.IsUpgraded && enemy.IsAlive;
					if (flag)
					{
						yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					}
				}
				enemy = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
