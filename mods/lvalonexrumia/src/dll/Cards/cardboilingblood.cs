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
	[EntityLogic(typeof(cardboilingbloodDef))]
	public sealed class cardboilingblood : lvalonexrumiaCard
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
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = !this.IsUpgraded;
			if (flag)
			{
				bool flag2 = base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).Count<EnemyUnit>() > 0;
				if (flag2)
				{
					yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).ToArray<EnemyUnit>(), this.Damage, base.GunName, GunType.Single);
				}
			}
			else
			{
				yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, this.Damage, base.GunName, GunType.Single);
			}
			bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd2)
			{
				yield break;
			}
			yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
