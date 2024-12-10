using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(PlungePoolDef))]
	public sealed class PlungePool : SampleCharacterCard
	{
		public int ReflectShield
		{
			get
			{
				bool flag = base.Battle != null && base.Battle.Player.HasStatusEffect<RetaliationSe>();
				int num;
				if (flag)
				{
					num = base.Battle.Player.GetStatusEffect<RetaliationSe>().Level;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		public override int AdditionalBlock
		{
			get
			{
				bool flag = base.Battle != null && !this.IsUpgraded;
				int num;
				if (flag)
				{
					num = this.ReflectShield;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		public override int AdditionalShield
		{
			get
			{
				bool flag = base.Battle != null && this.IsUpgraded;
				int num;
				if (flag)
				{
					num = this.ReflectShield;
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
			yield return new CastBlockShieldAction(base.Battle.Player, base.Block.Block, base.Shield.Shield, BlockShieldType.Normal, true);
			yield break;
		}
	}
}
