using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliRingOfAgniDef))]
	public sealed class PatchouliRingOfAgni : PatchouliBoostCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return pooledMana;
		}

		private DamageInfo CalculateDamage(ManaGroup? manaGroup)
		{
			int num = base.Boost * base.Value1;
			bool flag = manaGroup != null;
			DamageInfo damageInfo;
			if (flag)
			{
				ManaGroup valueOrDefault = manaGroup.GetValueOrDefault();
				int num2 = base.SynergyAmount(valueOrDefault, ManaColor.Any, 1) * base.Value1;
				damageInfo = DamageInfo.Attack((float)(base.RawDamage + num2 + num), base.IsAccuracy);
			}
			else
			{
				damageInfo = DamageInfo.Attack((float)(base.RawDamage + num), base.IsAccuracy);
			}
			return damageInfo;
		}

		[UsedImplicitly]
		public override DamageInfo Damage
		{
			get
			{
				return this.CalculateDamage(base.PendingManaUsage);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, this.CalculateDamage(new ManaGroup?(consumingMana)), null);
			base.ResetBoost();
			yield break;
		}
	}
}
