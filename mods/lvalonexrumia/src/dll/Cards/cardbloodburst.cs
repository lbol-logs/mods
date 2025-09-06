using System;
using System.Collections.Generic;
using System.Linq;
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
	[EntityLogic(typeof(cardbloodburstDef))]
	public sealed class cardbloodburst : lvalonexrumiaCard
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
			yield return new ChangeLifeAction(-this.heal, null);
			int num;
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					num = i;
				}
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			for (int j = 0; j < 3; j = num + 1)
			{
				bool flag = base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).Count<EnemyUnit>() > 0;
				if (flag)
				{
					bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
					if (battleShouldEnd2)
					{
						yield break;
					}
					yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).ToArray<EnemyUnit>(), this.Damage, base.GunName, GunType.Single);
				}
				num = j;
			}
			yield break;
			yield break;
		}
	}
}
