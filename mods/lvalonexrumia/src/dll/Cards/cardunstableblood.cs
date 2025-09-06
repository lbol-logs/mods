using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardunstablebloodDef))]
	public sealed class cardunstableblood : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			this.hascount = 0;
			yield return new ChangeLifeAction(-this.heal, null);
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				bool flag = unit.HasStatusEffect<sebleed>();
				if (flag)
				{
					this.hascount += base.Value2;
				}
				yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			bool flag2 = this.hascount > 0;
			if (flag2)
			{
				yield return new ApplyStatusEffectAction<sebloodstorm>(base.Battle.Player, new int?(this.hascount), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield return base.AttackAction(selector, base.GunName);
			yield break;
			yield break;
		}

		public int hascount = 0;
	}
}
