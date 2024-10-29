using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeSpiritManaSeDef))]
	public sealed class SanaeSpiritManaSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			int num = base.Count - 1;
			base.Count = num;
			bool flag = base.Count <= 0;
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<Spirit>(base.Battle.Player, new int?(base.Level), null, null, null, 0f, true);
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<WManaCard>() });
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
