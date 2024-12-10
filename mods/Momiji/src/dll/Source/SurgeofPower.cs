using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source
{
	[EntityLogic(typeof(SurgeofPowerDef))]
	public sealed class SurgeofPower : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.Player.HasStatusEffect<SurgeofPowerSe>();
			if (flag)
			{
				yield return new ApplyStatusEffectAction<SurgeofPowerSe>(base.Battle.Player, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield return new ApplyStatusEffectAction<SurgeofPowerSe>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
