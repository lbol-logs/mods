using System;
using System.Collections.Generic;
using System.Linq;
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
	[EntityLogic(typeof(cardintodarknessDef))]
	public sealed class cardintodarkness : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<sebloodmark>(selector.SelectedEnemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool flag = base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebloodmark>()).Count<EnemyUnit>() == 0;
			if (flag)
			{
				yield break;
			}
			yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebloodmark>()).ToArray<EnemyUnit>(), this.Damage, base.GunName, GunType.Single);
			yield break;
		}
	}
}
