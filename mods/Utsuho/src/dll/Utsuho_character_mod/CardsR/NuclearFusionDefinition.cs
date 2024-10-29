using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsR
{
	public sealed class NuclearFusionDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "NuclearFusion";
		}

		public override CardImages LoadCardImages()
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(this, ".png", "", false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override CardConfig MakeConfig()
		{
			return new CardConfig(13480, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(8), new int?(12), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string> { "NuclearStrike" }, new List<string> { "NuclearStrike" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(NuclearFusionDefinition))]
		public sealed class NuclearFusion : Card
		{
			public override Interaction Precondition()
			{
				List<Card> list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				bool flag = !list.Empty<Card>();
				Interaction interaction;
				if (flag)
				{
					interaction = new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing);
				}
				else
				{
					interaction = null;
				}
				return interaction;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = precondition != null;
				if (flag)
				{
					IReadOnlyList<Card> selectedCards = ((SelectCardInteraction)precondition).SelectedCards;
					bool flag2 = selectedCards.Count > 0;
					if (flag2)
					{
						int cardValue = selectedCards[0].TurnCost.Total;
						yield return new ExileManyCardAction(selectedCards);
						NuclearStrikeDefinition.NuclearStrike nuclearStrike = Library.CreateCard<NuclearStrikeDefinition.NuclearStrike>(false);
						nuclearStrike.DeltaValue1 = cardValue * base.Value1;
						yield return new AddCardsToHandAction(new Card[] { nuclearStrike });
						yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(cardValue * base.Value1), null, null, null, 0f, true);
						nuclearStrike = null;
					}
					selectedCards = null;
				}
				yield break;
			}
		}
	}
}
