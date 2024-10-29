using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(MaintainReactionEffect))]
	public sealed class MaintainReactionStatus : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardRetaining, new EventSequencedReactor<CardEventArgs>(this.OnCardRetaining));
		}

		private IEnumerable<BattleAction> OnCardRetaining(CardEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			int level = base.GetSeLevel<MaintainReactionStatus>();
			yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(level), null, null, null, 0f, true);
			yield break;
		}
	}
}
