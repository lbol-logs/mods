using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Exhibits
{
	[EntityLogic(typeof(extrueribbonDef))]
	public sealed class extrueribbon : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<GameEventArgs>(base.Battle.BattleStarting, new EventSequencedReactor<GameEventArgs>(this.OnBattleStarting));
		}

		private IEnumerable<BattleAction> OnBattleStarting(GameEventArgs args)
		{
			base.NotifyActivating();
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				int num;
				for (int i = 0; i < base.Value1; i = num + 1)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					int loss = Math.Max((int)(1f * (float)unit.MaxHp * (float)base.Value2 / 100f), base.Value2);
					yield return new ChangeLifeAction(-loss, unit);
					num = i;
				}
				bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd2)
				{
					yield break;
				}
				yield return new ApplyStatusEffectAction<sebloodmark>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				yield return new ApplyStatusEffectAction<sedeepbleed>(unit, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
