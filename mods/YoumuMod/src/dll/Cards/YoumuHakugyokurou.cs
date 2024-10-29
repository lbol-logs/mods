using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuHakugyokurouDef))]
	public sealed class YoumuHakugyokurou : YoumuCard
	{
		public override bool HasDisplayField { get; set; } = true;

		public override int DisplayField
		{
			get
			{
				return base.Value1;
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarting));
			base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand && YoumuCard.IsSlashCard(args.Card) && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				base.NotifyActivating();
				base.DeltaValue1--;
				bool flag2 = base.Value1 <= 0;
				if (flag2)
				{
					base.DeltaValue1 = 0;
					yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction(base.Damage.Amount, false), YoumuGunName.Hakugyokurou, GunType.Single);
					yield return new DiscardAction(this);
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarting(UnitEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new DrawManyCardAction(base.Value2);
			}
			yield break;
		}
	}
}
