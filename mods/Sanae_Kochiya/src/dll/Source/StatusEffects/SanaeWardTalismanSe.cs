using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Source.Cards.Starter;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeWardTalismanSeDef))]
	public sealed class SanaeWardTalismanSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(base.Owner.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnStatusEffectAdded));
			base.ReactOwnerEvent<UsUsingEventArgs>(base.Battle.UsUsed, new EventSequencedReactor<UsUsingEventArgs>(this.OnUsUsed));
		}

		private IEnumerable<BattleAction> OnStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is AmuletForCard;
			if (flag)
			{
				yield return new GainPowerAction(args.Effect.Level);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnUsUsed(UsUsingEventArgs args)
		{
			yield return new AddCardsToDiscardAction(Library.CreateCards<SanaeStatus>(base.Level, false), AddCardsType.Normal);
			yield break;
		}
	}
}
