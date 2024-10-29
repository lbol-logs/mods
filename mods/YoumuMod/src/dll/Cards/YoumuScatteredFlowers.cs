using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuScatteredFlowersDef))]
	public sealed class YoumuScatteredFlowers : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool flag = unit.HasStatusEffect<LockedOn>();
				if (flag)
				{
					yield return new DamageAction(base.Battle.Player, unit, DamageInfo.Reaction((float)unit.GetStatusEffect<LockedOn>().Level * (float)base.Value1, false), YoumuGunName.SpiritMediumBindSe, GunType.Single);
				}
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
