using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardslicepastDef))]
	public sealed class cardslicepast : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(this.heal, null);
			List<Card> list = (from card in base.Battle.EnumerateAllCards()
				where card != this && card.Zone == CardZone.Hand && card.CanUpgradeAndPositive
				select card).ToList<Card>();
			bool flag = list.Count == 0;
			if (flag)
			{
				yield break;
			}
			yield return new UpgradeCardsAction(list);
			yield break;
		}
	}
}
