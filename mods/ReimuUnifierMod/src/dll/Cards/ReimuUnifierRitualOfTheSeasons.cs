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
	[EntityLogic(typeof(ReimuUnifierRitualOfTheSeasonsDef))]
	public sealed class ReimuUnifierRitualOfTheSeasons : ReimuUnifierCard
	{
		public List<Card> TeammatesOfColor(ManaColor manaColor)
		{
			return base.Battle.DrawZone.Where((Card Teammates) => Teammates.CardType == CardType.Friend && Teammates.Config.Colors.Contains(manaColor)).ToList<Card>();
		}

		public ManaColor ColorOfList(int Index)
		{
			ManaColor manaColor;
			switch (Index)
			{
			case 0:
				manaColor = ManaColor.Colorless;
				break;
			case 1:
				manaColor = ManaColor.White;
				break;
			case 2:
				manaColor = ManaColor.Blue;
				break;
			case 3:
				manaColor = ManaColor.Black;
				break;
			case 4:
				manaColor = ManaColor.Red;
				break;
			case 5:
				manaColor = ManaColor.Green;
				break;
			default:
				manaColor = ManaColor.Any;
				break;
			}
			return manaColor;
		}

		private void RecursiveCardCombinations(int colorIndex, List<List<Card>> ListList, List<Card> currentCombination, HashSet<Card> usedCards, List<ManaColor> usedColors, ref List<ManaColor> bestColors, ref List<Card> bestCombination)
		{
			bool flag = currentCombination.Count<Card>() > bestCombination.Count<Card>();
			if (flag)
			{
				bestCombination = new List<Card>(currentCombination);
				bestColors = new List<ManaColor>(usedColors);
			}
			bool flag2 = colorIndex >= ListList.Count;
			if (!flag2)
			{
				List<Card> list = ListList[colorIndex];
				bool flag3 = list.Empty<Card>();
				if (flag3)
				{
					this.RecursiveCardCombinations(colorIndex + 1, ListList, currentCombination, usedCards, usedColors, ref bestColors, ref bestCombination);
				}
				else
				{
					foreach (Card card in list)
					{
						bool flag4 = usedCards.Contains(card);
						if (flag4)
						{
							this.RecursiveCardCombinations(colorIndex + 1, ListList, currentCombination, usedCards, usedColors, ref bestColors, ref bestCombination);
						}
						else
						{
							usedCards.Add(card);
							currentCombination.Add(card);
							usedColors.Add(this.ColorOfList(colorIndex));
							this.RecursiveCardCombinations(colorIndex + 1, ListList, currentCombination, usedCards, usedColors, ref bestColors, ref bestCombination);
							currentCombination.RemoveAt(currentCombination.Count - 1);
							usedCards.Remove(card);
							usedColors.Remove(this.ColorOfList(colorIndex));
						}
					}
				}
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<Card> ColorlessTeammates = this.TeammatesOfColor(ManaColor.Colorless);
			List<Card> WhiteTeammates = this.TeammatesOfColor(ManaColor.White);
			List<Card> BlueTeammates = this.TeammatesOfColor(ManaColor.Blue);
			List<Card> BlackTeammates = this.TeammatesOfColor(ManaColor.Black);
			List<Card> RedTeammates = this.TeammatesOfColor(ManaColor.Red);
			List<Card> GreenTeammates = this.TeammatesOfColor(ManaColor.Green);
			ColorlessTeammates.Shuffle(new RandomGen());
			WhiteTeammates.Shuffle(new RandomGen());
			BlueTeammates.Shuffle(new RandomGen());
			BlackTeammates.Shuffle(new RandomGen());
			RedTeammates.Shuffle(new RandomGen());
			GreenTeammates.Shuffle(new RandomGen());
			List<List<Card>> ListList = new List<List<Card>>();
			HashSet<Card> usedCards = new HashSet<Card>();
			List<Card> auxCombination = new List<Card>();
			List<Card> bestResult = new List<Card>();
			List<ManaColor> usedColors = new List<ManaColor>();
			List<ManaColor> bestColors = new List<ManaColor>();
			ListList.Add(ColorlessTeammates);
			ListList.Add(WhiteTeammates);
			ListList.Add(BlueTeammates);
			ListList.Add(BlackTeammates);
			ListList.Add(RedTeammates);
			ListList.Add(GreenTeammates);
			this.RecursiveCardCombinations(0, ListList, auxCombination, usedCards, usedColors, ref bestColors, ref bestResult);
			foreach (Card card in bestResult)
			{
				yield return new MoveCardAction(card, CardZone.Hand);
				card = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			bool flag = base.TeamUpCheck<ReimuUnifierAunnShrineGuardianFriend>();
			if (flag)
			{
				foreach (ManaColor color in bestColors)
				{
					bool flag2 = color > ManaColor.Any;
					if (flag2)
					{
						yield return new GainManaAction(ManaGroup.Single(color));
					}
				}
				List<ManaColor>.Enumerator enumerator2 = default(List<ManaColor>.Enumerator);
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierAunnShrineGuardianFriend)));
			}
			yield break;
			yield break;
		}
	}
}
