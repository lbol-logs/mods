using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards;
using PatchouliCharacterMod.GunName;

namespace PatchouliCharacterMod.PatchouliUlt
{
	[EntityLogic(typeof(PatchouliUltUDef))]
	public sealed class PatchouliUltU : UltimateSkill
	{
		public PatchouliUltU()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = PatchouliGunName.UltimateSkillU;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			yield return PerformAction.Spell(base.Battle.Player, "PatchouliUltU");
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<PatchouliAstronomy>(base.Value1, false), AddCardsType.Normal);
				yield return new BoostAllInHandAction(base.Value2);
			}
			yield break;
		}
	}
}
