using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbloodswordDef))]
	public sealed class cardbloodsword : lvalonexrumiaCard
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

		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			EnemyUnit enemy = selector.SelectedEnemy;
			bool flag = enemy.IsAlive && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				sebloodmark bloodmark;
				bool flag2 = enemy.TryGetStatusEffect<sebloodmark>(out bloodmark);
				if (flag2)
				{
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
					}
					else
					{
						bloodmark.Level -= base.Value2;
					}
					bool flag3 = bloodmark.Level <= 0;
					if (flag3)
					{
						yield return new RemoveStatusEffectAction(bloodmark, true, 0.1f);
					}
					bool flag4 = !this.IsUpgraded;
					if (flag4)
					{
						yield return new ChangeLifeAction(this.heal, null);
					}
				}
				else
				{
					yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
				}
				bloodmark = null;
			}
			bool isUpgraded2 = this.IsUpgraded;
			if (isUpgraded2)
			{
				yield return new ChangeLifeAction(this.heal, null);
			}
			yield break;
		}
	}
}
