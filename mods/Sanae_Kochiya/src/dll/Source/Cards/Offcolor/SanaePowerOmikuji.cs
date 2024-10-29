using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaePowerOmikujiDef))]
	public sealed class SanaePowerOmikuji : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.Player.Power > 0;
			if (flag)
			{
				yield return new LosePowerAction(base.Value1);
				yield return base.BuffAction<OmikujiBonusSe>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
