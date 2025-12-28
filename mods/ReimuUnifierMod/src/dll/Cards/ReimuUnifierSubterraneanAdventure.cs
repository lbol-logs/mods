using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.MultiColor;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSubterraneanAdventureDef))]
	public sealed class ReimuUnifierSubterraneanAdventure : ReimuUnifierCard
	{
		public int MaxHand
		{
			get
			{
				return 12;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = !base.Battle.Player.HasStatusEffect<ReimuUnifierSubterraneanAdventureSe>();
			if (flag)
			{
				yield return base.BuffAction<ReimuUnifierSubterraneanAdventureSe>(0, 0, 0, 0, 0.2f);
			}
			yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierCommunicatorOrbToken>() });
			List<Type> Yukaris = new List<Type>
			{
				typeof(ReimuUnifierYukariYakumoFriend),
				typeof(YukariFriend),
				typeof(ReimuUnifierYukariSageOfGensokyoFriend)
			};
			bool flag2 = base.MultiTeamUpCheck(Yukaris) > 0;
			if (flag2)
			{
				Card AddedCard = Library.CreateCard<ReimuUnifierPurpleReproach>();
				AddedCard.SetTurnCost(base.Mana);
				AddedCard.SetKeyword(Keyword.Ethereal, true);
				yield return new AddCardsToHandAction(new Card[] { AddedCard });
				yield return new TeamUpAction(this, base.TeamUpCard(Yukaris));
				AddedCard = null;
			}
			bool flag3 = base.TeamUpCheck<ReimuUnifierSuikaGourdOniFriend>();
			if (flag3)
			{
				Card AddedCard2 = Library.CreateCard<ReimuUnifierFierceGodWillOWisp>();
				AddedCard2.SetTurnCost(base.Mana);
				AddedCard2.SetKeyword(Keyword.Ethereal, true);
				yield return new AddCardsToHandAction(new Card[] { AddedCard2 });
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierSuikaGourdOniFriend)));
				AddedCard2 = null;
			}
			bool flag4 = base.TeamUpCheck<ReimuUnifierAyaReporterOfFantasyFriend>();
			if (flag4)
			{
				Card AddedCard3 = Library.CreateCard<ReimuUnifierDeepRain>();
				AddedCard3.SetTurnCost(base.Mana);
				AddedCard3.SetKeyword(Keyword.Ethereal, true);
				yield return new AddCardsToHandAction(new Card[] { AddedCard3 });
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierAyaReporterOfFantasyFriend)));
				AddedCard3 = null;
			}
			yield break;
		}
	}
}
