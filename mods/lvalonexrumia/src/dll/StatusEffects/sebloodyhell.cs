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
	[EntityLogic(typeof(sebloodyhellDef))]
	public sealed class sebloodyhell : StatusEffect
	{
		public int atkincrease
		{
			get
			{
				bool flag = base.Owner == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = base.Level * 5;
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.Config.Colors.Contains(ManaColor.Red);
			if (flag)
			{
				base.NotifyActivating();
				yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(base.Level * 5), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield break;
		}
	}
}
