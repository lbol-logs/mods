using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards;

namespace ReimuUnifierMod.ReimuUnifierUlt
{
	[EntityLogic(typeof(ReimuUnifierUltADef))]
	public sealed class ReimuUnifierUltA : UltimateSkill
	{
		public ReimuUnifierUltA()
		{
			base.TargetType = TargetType.Nobody;
		}

		public ManaGroup ManaPreview
		{
			get
			{
				return ManaGroup.Empty;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Owner, "ReimuUnifierUltA");
			Card MarisaToTheRescue = Library.CreateCard<ReimuUnifierMarisaKirisameFriend>();
			MarisaToTheRescue.Loyalty = 9;
			MarisaToTheRescue.SetTurnCost(this.ManaPreview);
			yield return new AddCardsToHandAction(new Card[] { MarisaToTheRescue });
			yield break;
		}
	}
}
