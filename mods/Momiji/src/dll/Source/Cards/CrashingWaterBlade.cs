using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(CrashingWaterBladeDef))]
	public sealed class CrashingWaterBlade : SampleCharacterCard
	{
		public int ReflectDamage
		{
			get
			{
				bool flag = base.Battle != null && base.Battle.Player.HasStatusEffect<Reflect>();
				int num;
				if (flag)
				{
					num = base.Battle.Player.GetStatusEffect<Reflect>().Level / base.Value1;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			int num;
			for (int i = 0; i < this.ReflectDamage; i = num + 1)
			{
				yield return base.AttackAction(selector, base.GunName);
				num = i;
			}
			yield break;
		}
	}
}
