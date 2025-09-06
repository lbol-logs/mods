using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardletsdanceDef))]
	public sealed class cardletsdance : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (Unit enemy in base.Battle.AllAliveEnemies)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				}
				enemy = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			int num;
			for (int i = 0; i < base.Value2; i = num + 1)
			{
				bool flag2 = !base.Battle.BattleShouldEnd;
				if (flag2)
				{
					yield return base.AttackAction(selector, base.GunName);
				}
				num = i;
			}
			bool flag3 = !base.Battle.BattleShouldEnd;
			if (flag3)
			{
				yield return new ApplyStatusEffectAction<Graze>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
			yield break;
		}
	}
}
