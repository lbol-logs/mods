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
	[EntityLogic(typeof(cardredbloodDef))]
	public sealed class cardredblood : lvalonexrumiaCard
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
			bool flag = this.IsUpgraded || (!this.IsUpgraded && Singleton<GameMaster>.Instance.CurrentGameRun.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true));
			if (flag)
			{
				yield return new ChangeLifeAction(this.heal, null);
			}
			yield return new GainManaAction(base.Mana);
			bool flag2 = base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).Count<EnemyUnit>() == 0;
			if (flag2)
			{
				yield break;
			}
			DamageInfo damage2 = this.Damage;
			damage2.IsAccuracy = true;
			yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies.Where((EnemyUnit x) => x.HasStatusEffect<sebleed>()).ToArray<EnemyUnit>(), damage2, base.GunName, GunType.Single);
			yield break;
		}
	}
}
