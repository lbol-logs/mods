using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardcrimsondomainDef))]
	public sealed class cardcrimsondomain : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool flag = unit.IsAlive && !base.Battle.BattleShouldEnd;
				if (flag)
				{
					bool flag2 = !unit.HasStatusEffect<sebleed>();
					if (flag2)
					{
						yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					}
					else
					{
						yield return new ApplyStatusEffectAction<sedeepbleed>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					}
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebloodmark>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				}
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield return new AddCardsToHandAction(Library.CreateCards<cardbloodstorm>(base.Value1, false), AddCardsType.Normal);
			yield break;
			yield break;
		}
	}
}
