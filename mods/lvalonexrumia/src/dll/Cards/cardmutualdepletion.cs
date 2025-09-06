using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardmutualdepletionDef))]
	public sealed class cardmutualdepletion : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.Player.HasStatusEffect<sefuckyou>() && this.IsUpgraded;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<sefuckyou>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(200), new int?(0), 0.2f, true);
			}
			yield return new ApplyStatusEffectAction<semutualdepletion>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
