using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Character.Cirno.Friend;
using LBoL.EntityLib.Cards.Character.Koishi;
using LBoL.EntityLib.Cards.Character.Marisa;
using LBoL.EntityLib.Cards.Character.Sakuya;
using LBoL.EntityLib.Cards.Neutral.MultiColor;
using LBoL.EntityLib.Cards.Neutral.TwoColor;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierYoukaiShrineMaidenDef))]
	public sealed class ReimuUnifierYoukaiShrineMaiden : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Type> PossibleTeamUps = new List<Type>
			{
				typeof(ReimuUnifierYukariYakumoFriend),
				typeof(ReimuUnifierYukariSageOfGensokyoFriend),
				typeof(ReimuUnifierKogasaYoukaiBlacksmithFriend),
				typeof(ReimuUnifierSuikaGourdOniFriend),
				typeof(ReimuUnifierKasenWildhornFriend),
				typeof(ReimuUnifierFourFairiesFriend),
				typeof(ReimuUnifierAunnShrineGuardianFriend),
				typeof(ReimuUnifierAyaReporterOfFantasyFriend),
				typeof(ReimuUnifierNitoriBusinessPartnerFriend),
				typeof(ReimuUnifierShionImpoverishedDeityFriend),
				typeof(ReimuUnifierShinmyoumaruInchlingPrincessFriend),
				typeof(YukariFriend),
				typeof(YinyangQueen),
				typeof(PatchouliFriend),
				typeof(MeilingFriend),
				typeof(MaidFriend),
				typeof(LeidiFriend),
				typeof(LarvaFriend),
				typeof(LilyFriend),
				typeof(LunaFriend),
				typeof(StarFriend),
				typeof(SunnyFriend),
				typeof(ClownpieceFriend),
				typeof(KokoroFriend)
			};
			int TeamUpAmount = base.MultiTeamUpCheck(PossibleTeamUps);
			yield return new GainManaAction(base.Mana);
			yield return new DrawManyCardAction(base.Value1);
			List<Card> randomCurseCards = new List<Card>();
			int MisfortunesToAdd = 3 - TeamUpAmount;
			int num;
			for (int i = 0; i < MisfortunesToAdd; i = num + 1)
			{
				randomCurseCards.Add(base.GameRun.GetRandomCurseCard(base.GameRun.BattleCardRng, true));
				num = i;
			}
			bool flag = randomCurseCards != null;
			if (flag)
			{
				yield return new AddCardsToDiscardAction(randomCurseCards, AddCardsType.Normal);
			}
			bool flag2 = TeamUpAmount > 3;
			if (flag2)
			{
				yield return base.BuffAction<AmuletForCard>(TeamUpAmount - 3, 0, 0, 0, 0.2f);
			}
			bool flag3 = TeamUpAmount != 0;
			if (flag3)
			{
				List<Card> CardsInHand = base.Battle.HandZone.ToList<Card>();
				foreach (Card card in CardsInHand)
				{
					bool flag4 = PossibleTeamUps.Contains(card.GetType()) && card.Summoned;
					if (flag4)
					{
						yield return new TeamUpAction(this, card);
					}
					card = null;
				}
				List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				CardsInHand = null;
			}
			yield break;
			yield break;
		}
	}
}
