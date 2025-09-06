using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sebleedslashDef))]
	public sealed class sebleedslash : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new GameEventHandler<UnitEventArgs>(this.OnTurnEnded));
		}

		private void OnTurnEnded(UnitEventArgs args)
		{
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Card.Config.Colors.Contains(ManaColor.Black);
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<sebloodsword>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
