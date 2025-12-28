using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.EntityLib.Cards.Character.Cirno.Friend;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierShrineDefenseDef))]
	public sealed class ReimuUnifierShrineDefense : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int AvailableSpace = base.Battle.MaxHand - base.Battle.HandZone.Count;
			Card[] array = base.Battle.RollCardsWithoutManaLimit(new CardWeightTable(RarityWeightTable.BattleCard, OwnerWeightTable.AllOnes, CardTypeWeightTable.OnlyFriend, false), AvailableSpace, null);
			List<Type> PossibleTeamUps = new List<Type>
			{
				typeof(ReimuUnifierMarisaIncidentSolverFriend),
				typeof(ReimuUnifierMarisaKirisameFriend),
				typeof(ReimuUnifierSuikaGourdOniFriend),
				typeof(ReimuUnifierKasenWildhornFriend),
				typeof(ReimuUnifierFourFairiesFriend),
				typeof(ReimuUnifierAunnShrineGuardianFriend),
				typeof(ReimuUnifierNitoriBusinessPartnerFriend),
				typeof(ReimuUnifierSumirekoDreamVisitorFriend),
				typeof(LunaFriend),
				typeof(StarFriend),
				typeof(SunnyFriend),
				typeof(ClownpieceFriend)
			};
			int TeamUpAmount = base.MultiTeamUpCheck(PossibleTeamUps);
			yield return new GainManaAction(ManaGroup.Philosophies(TeamUpAmount));
			List<Card> CardsInHand = base.Battle.HandZone.ToList<Card>();
			foreach (Card card in CardsInHand)
			{
				bool flag = PossibleTeamUps.Contains(card.GetType()) && card.Summoned;
				if (flag)
				{
					yield return new TeamUpAction(this, card);
				}
				card = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			foreach (Card card2 in array)
			{
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					ManaColor[] components = card2.Cost.EnumerateComponents().SampleManyOrAll(1, base.GameRun.BattleRng);
					card2.DecreaseBaseCost(ManaGroup.FromComponents(components));
					components = null;
				}
				card2 = null;
			}
			Card[] array2 = null;
			yield return new AddCardsToHandAction(array);
			yield break;
			yield break;
		}
	}
}
