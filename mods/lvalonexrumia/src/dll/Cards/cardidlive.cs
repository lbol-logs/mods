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
	[EntityLogic(typeof(cardidliveDef))]
	public sealed class cardidlive : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.Player.HasStatusEffect<sequickrestore>();
			if (flag)
			{
				yield return new ApplyStatusEffectAction<sequickrestore>(base.Battle.Player, new int?(base.Battle.Player.Hp), new int?(0), new int?((int)Math.Round(1.0 * (double)base.Battle.Player.Hp / 2.0)), new int?(0), 0.2f, true);
			}
			yield return new ApplyStatusEffectAction<seidlive>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
