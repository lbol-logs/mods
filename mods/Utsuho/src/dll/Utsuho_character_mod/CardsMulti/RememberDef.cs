using System;
using System.Collections.Generic;
using LBoL.Base;
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

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class RememberDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Remember";
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
			return new CardConfig(13630, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Blue
			}, false, new ManaGroup
			{
				Black = 1,
				Blue = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Blue = 1
			}), null, null, null, null, null, null, null, new int?(4), new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Exile, Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(RememberDef))]
		public sealed class Remember : Card
		{
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
					interaction = new SelectCardInteraction(1, 12, base.Battle.ExileZone, SelectedCardHandling.DoNothing);
				}
				return interaction;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				SelectCardInteraction selectCardInteraction = (SelectCardInteraction)precondition;
				foreach (Card card in selectCardInteraction.SelectedCards)
				{
					bool flag = card != null;
					if (flag)
					{
						yield return new MoveCardAction(card, CardZone.Hand);
					}
					card = null;
				}
				IEnumerator<Card> enumerator = null;
				yield break;
				yield break;
			}
		}
	}
}
