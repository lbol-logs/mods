using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core.Battle;
using LBoL.Core.Cards;

namespace Momiji.Source.BattleActions
{
	public sealed class BuffAttackCardAction : EventBattleAction<BuffAttackEventArgs>
	{
		internal BuffAttackCardAction(Card card = null, int amount = 0)
		{
			base.Args = new BuffAttackEventArgs
			{
				Card = card,
				Amount = amount
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				bool flag = base.Args.Card != null && base.Args.Card.Config.Type == CardType.Attack;
				if (flag)
				{
					base.Args.Card.DeltaDamage += base.Args.Amount;
				}
			}, true);
			yield break;
		}
	}
}
