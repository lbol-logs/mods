using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.EntityLib.Cards.Adventure;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Utils;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeToolNewsDef))]
	public sealed class SanaeToolNews : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<SanaeToolNews> list = Library.CreateCards<SanaeToolNews>(2, this.IsUpgraded).ToList<SanaeToolNews>();
			SanaeToolNews first = list[0];
			SanaeToolNews sanaeToolNews = list[1];
			first.ShowWhichDescription = 1;
			sanaeToolNews.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeToolNews.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			List<Card> tools = new List<Card>();
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				int num;
				for (int i = 0; i < base.Value1; i = num + 1)
				{
					tools.Add(base.Battle.RollCard(new CardWeightTable(RarityWeightTable.NoneRare, OwnerWeightTable.Valid, CardTypeWeightTable.OnlyTool, false), null));
					num = i;
				}
			}
			else
			{
				List<Type> tengu = ObjectExtensions.Copy<List<Type>>(SanaeToolNews.TenguTool);
				int num;
				for (int j = 0; j < base.Value2; j = num + 1)
				{
					tengu.Shuffle(base.GameRun.BattleRng);
					tools.Add(Library.CreateCard(tengu.First<Type>()));
					num = j;
				}
				tengu = null;
			}
			foreach (Card card in tools)
			{
				card.DeckCounter = new int?(1);
				card.IsAutoExile = true;
				card.IsCopy = true;
				card = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			yield return new AddCardsToHandAction(tools, AddCardsType.Normal);
			yield break;
		}

		private static readonly List<Type> TenguTool = new List<Type>
		{
			typeof(NewsPositive),
			typeof(NewsNegative),
			typeof(NewsEntertainment),
			typeof(NewsTidbit)
		};
	}
}
