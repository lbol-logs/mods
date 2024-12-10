using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(WardingStrikeDef))]
	public sealed class WardingStrike : SampleCharacterCard
	{
		public int ReflectDamage
		{
			get
			{
				bool flag = base.Battle != null && base.Battle.Player.HasStatusEffect<Reflect>();
				int num;
				if (flag)
				{
					num = base.Battle.Player.GetStatusEffect<Reflect>().Level;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		public override int AdditionalDamage
		{
			get
			{
				return this.ReflectDamage;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}
	}
}
