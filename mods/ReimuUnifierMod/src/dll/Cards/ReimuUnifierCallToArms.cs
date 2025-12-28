using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCallToArmsDef))]
	public sealed class ReimuUnifierCallToArms : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int CardAmount = base.Battle.HandZone.Where((Card card) => card.CardType == CardType.Friend && card.Summoned).Count<Card>();
			bool isUpgraded = this.IsUpgraded;
			int num;
			if (isUpgraded)
			{
				num = CardAmount;
				CardAmount = num + 1;
			}
			bool TeamUp = base.SummonedTeammatesOfColorInHand(ManaColor.Red) > 0;
			List<string> PossibleTokens = new List<string>();
			PossibleTokens.Add("ReimuUnifierCommunicatorOrbToken");
			PossibleTokens.Add("ReimuUnifierYoukaiForgedNeedle");
			for (int i = 0; i < CardAmount; i = num + 1)
			{
				Card CardToCreate = Library.CreateCard(PossibleTokens.Sample(base.GameRun.BattleRng));
				bool flag = TeamUp;
				if (flag)
				{
					CardToCreate.DecreaseTurnCost(base.Mana);
				}
				yield return new AddCardsToHandAction(new Card[] { CardToCreate });
				CardToCreate = null;
				num = i;
			}
			bool flag2 = TeamUp;
			if (flag2)
			{
				yield return new TeamUpAction(this, base.TeamUpColorCard(ManaColor.Red));
			}
			yield break;
		}
	}
}
