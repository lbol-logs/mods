using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCommunicatorOrbTokenDef))]
	public sealed class ReimuUnifierCommunicatorOrbToken : ReimuUnifierCard
	{
		protected override int AdditionalShield
		{
			get
			{
				return base.Value1 * base.SummonedTeammatesInHand;
			}
		}

		protected override int AdditionalDamage
		{
			get
			{
				return base.Value1 * base.SummonedTeammatesInHand;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, null);
			yield return base.DefenseAction(0, base.Shield.Shield, BlockShieldType.Normal, false);
			yield break;
		}
	}
}
