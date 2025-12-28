using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSynchronizedRitualArrayDef))]
	public sealed class ReimuUnifierSynchronizedRitualArray : ReimuUnifierCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnded));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			Card card = args.Card;
			bool flag = card.CardType == CardType.Friend && card.Summoning && base.Zone == CardZone.Hand;
			if (flag)
			{
				base.DeltaValue2++;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnded(UnitEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				base.NotifyActivating();
				int num;
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					bool flag2 = !base.Battle.BattleShouldEnd && base.Battle.AllAliveEnemies.Count<EnemyUnit>() > 0;
					if (!flag2)
					{
						yield break;
					}
					EnemyUnit target = base.Battle.EnemyGroup.Alives.SampleOrDefault(base.Battle.GameRun.BattleRng);
					yield return PerformAction.Effect(target, "Changzhi", 0f, "ReimuBoundaryHit", 0f, PerformAction.EffectBehavior.PlayOneShot, 0.3f);
					yield return new DamageAction(base.Battle.Player, target, DamageInfo.Reaction((float)base.Value1, false), "Instant", GunType.Single);
					target = null;
					num = i;
				}
			}
			yield break;
		}
	}
}
