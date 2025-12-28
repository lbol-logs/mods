using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierWilyBeastStrikeSeDef))]
	public sealed class ReimuUnifierWilyBeastStrikeSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsing, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			bool flag = !this.Battle.BattleShouldEnd;
			if (flag)
			{
				Card card = args.Card;
				bool flag2 = card.CardType == CardType.Friend && card.Summoned;
				if (flag2)
				{
					this.NotifyActivating();
					args.PlayTwice = true;
					args.AddModifier(this);
					int level = base.Level;
					base.Level = level - 1;
					bool flag3 = base.Level <= 0;
					if (flag3)
					{
						yield return new RemoveStatusEffectAction(this, true, 0.1f);
					}
				}
				card = null;
			}
			yield break;
		}
	}
}
