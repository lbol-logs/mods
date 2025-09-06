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
	[EntityLogic(typeof(cardallureDef))]
	public sealed class cardallure : lvalonexrumiaCard
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
			yield return new ScryAction(base.Scry);
			yield return new DrawManyCardAction(base.Value2);
			foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				yield return new ApplyStatusEffectAction<sebleed>(enemy, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
				enemy = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
