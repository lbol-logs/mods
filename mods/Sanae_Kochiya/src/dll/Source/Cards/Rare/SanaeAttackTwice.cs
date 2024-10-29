using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAttackTwiceDef))]
	public sealed class SanaeAttackTwice : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.Player.HasStatusEffect<Amulet>();
			if (flag)
			{
				yield return base.DebuffAction<Weak>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.2f);
				yield return base.AttackAction(selector, base.GunName);
				yield return base.AttackAction(selector, GunNameID.GetGunFromId(4072));
			}
			else
			{
				yield return base.AttackAction(selector, base.GunName);
				yield return base.BuffAction<Amulet>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
