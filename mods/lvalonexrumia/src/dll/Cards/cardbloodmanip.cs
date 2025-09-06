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
	[EntityLogic(typeof(cardbloodmanipDef))]
	public sealed class cardbloodmanip : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 5, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd2)
				{
					yield break;
				}
				yield return new ApplyStatusEffectAction<sebloodmark>(enemy, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
				bool battleShouldEnd3 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd3)
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
