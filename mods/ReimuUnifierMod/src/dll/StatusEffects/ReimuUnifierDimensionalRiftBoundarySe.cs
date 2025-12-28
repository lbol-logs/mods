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
	[EntityLogic(typeof(ReimuUnifierDimensionalRiftBoundarySeDef))]
	public sealed class ReimuUnifierDimensionalRiftBoundarySe : StatusEffect
	{
		private string GunName
		{
			get
			{
				bool flag = base.Level <= 10;
				string text;
				if (flag)
				{
					text = "闭目射击";
				}
				else
				{
					text = "闭目射击B";
				}
				return text;
			}
		}

		private ManaGroup SePreviewMana
		{
			get
			{
				return ManaGroup.Reds(base.Count);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardEventArgs>(base.Battle.CardDrawn, new EventSequencedReactor<CardEventArgs>(this.OnCardDrawn));
			base.ReactOwnerEvent<CardMovingEventArgs>(base.Battle.CardMoved, new EventSequencedReactor<CardMovingEventArgs>(this.OnCardMoved));
		}

		private IEnumerable<BattleAction> OnCardDrawn(CardEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				CardType cardType = args.Card.CardType;
				bool flag2 = cardType == CardType.Friend;
				if (flag2)
				{
					base.NotifyActivating();
					yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, DamageInfo.Reaction((float)base.Level, false), this.GunName, GunType.Single);
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnCardMoved(CardMovingEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Battle.EnemyGroup.Alives != null;
			if (flag)
			{
				bool flag2 = args.DestinationZone == CardZone.Discard;
				if (flag2)
				{
					CardType cardType = args.Card.CardType;
					bool flag3 = cardType == CardType.Friend && args.Card.Summoned;
					if (flag3)
					{
						base.NotifyActivating();
						yield return new GainManaAction(new ManaGroup
						{
							Red = base.Count
						});
					}
				}
			}
			yield break;
		}
	}
}
