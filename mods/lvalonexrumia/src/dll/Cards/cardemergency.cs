using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Intentions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardemergencyDef))]
	public sealed class cardemergency : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, false);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			yield return base.DefenseAction(true);
			yield return new ApplyStatusEffectAction<sedarkblood>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			int attackCount = 0;
			EnemyUnit[] enemies = base.Battle.AllAliveEnemies.ToArray<EnemyUnit>();
			attackCount = enemies.Count((EnemyUnit enemy) => enemy.Intentions.Any(delegate(Intention i)
			{
				bool flag2;
				if (!(i is AttackIntention))
				{
					SpellCardIntention spellCardIntention = i as SpellCardIntention;
					flag2 = spellCardIntention != null && spellCardIntention.Damage != null;
				}
				else
				{
					flag2 = true;
				}
				return flag2;
			}));
			bool flag = attackCount > 0 && this.IsUpgraded;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
