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
	[EntityLogic(typeof(cardworldburnDef))]
	public sealed class cardworldburn : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<seworldburn>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
					if (battleShouldEnd2)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebleed>(enemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					enemy = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
