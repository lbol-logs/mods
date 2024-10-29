using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeBlockManaDef))]
	public sealed class SanaeBlockMana : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			yield return new ApplyStatusEffectAction(typeof(TurnStartDontLoseMana), base.Battle.Player, new int?(0), new int?(base.Value2), new int?(0), new int?(0), 0.2f, true);
			bool flag = !this.IsUpgraded;
			if (flag)
			{
				yield return new LockRandomTurnManaAction(base.Value1);
			}
			yield break;
		}
	}
}
