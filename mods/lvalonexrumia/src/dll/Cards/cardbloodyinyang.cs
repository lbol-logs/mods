using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Character.Reimu;
using LBoL.EntityLib.StatusEffects.Neutral.TwoColor;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbloodyinyangDef))]
	public sealed class cardbloodyinyang : YinyangCardBase
	{
		public int truevalue
		{
			get
			{
				GameRunController currentGameRun = Singleton<GameMaster>.Instance.CurrentGameRun;
				PlayerUnit playerUnit;
				if (currentGameRun == null)
				{
					playerUnit = null;
				}
				else
				{
					BattleController battle = currentGameRun.Battle;
					playerUnit = ((battle != null) ? battle.Player : null);
				}
				PlayerUnit playerUnit2 = playerUnit;
				YinyangQueenSe yinyangQueenSe = ((playerUnit2 != null) ? playerUnit2.GetStatusEffect<YinyangQueenSe>() : null);
				return (yinyangQueenSe != null) ? (base.Value1 * (yinyangQueenSe.Level + 1)) : base.Value1;
			}
		}

		public override Interaction Precondition()
		{
			bool flag = base.Battle.ExileZone.Count <= 0;
			Interaction interaction;
			if (flag)
			{
				interaction = null;
			}
			else
			{
				interaction = new SelectCardInteraction(0, this.truevalue, base.Battle.ExileZone, SelectedCardHandling.DoNothing);
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition != null;
			if (flag)
			{
				SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
				Card[] cards = ((selectCardInteraction != null) ? selectCardInteraction.SelectedCards.ToArray<Card>() : null);
				foreach (Card card in cards)
				{
					bool flag2 = card != null;
					if (flag2)
					{
						yield return new MoveCardAction(card, CardZone.Hand);
					}
					card = null;
				}
				Card[] array = null;
				cards = null;
			}
			yield return base.UpgradeAllHandsAction();
			yield break;
		}
	}
}
