using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.StatusEffects;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(TwinFangDef))]
	public sealed class TwinFang : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = (this.IsUpgraded ? "心抄斩B" : "心抄斩");
			}
			yield return new ApplyStatusEffectAction<TwinFangSe>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
