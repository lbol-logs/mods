using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.GunName;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.PatchouliUlt
{
	[EntityLogic(typeof(PatchouliUltBDef))]
	public sealed class PatchouliUltB : UltimateSkill
	{
		public PatchouliUltB()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = PatchouliGunName.UltimateSkillB;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			yield return PerformAction.Spell(base.Battle.Player, "PatchouliUltB");
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<PatchouliMoonSignSe>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				yield break;
			}
			yield break;
		}
	}
}
