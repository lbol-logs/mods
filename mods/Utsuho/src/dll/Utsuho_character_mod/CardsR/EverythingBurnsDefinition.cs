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

namespace Utsuho_character_mod.CardsR
{
	public sealed class EverythingBurnsDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "EverythingBurns";
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
			return new CardConfig(13370, "", 10, true, new string[0][], "小面红", "小面红", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, true, new ManaGroup
			{
				Red = 2
			}, null, null, new int?(6), new int?(9), null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(EverythingBurnsDefinition))]
		public sealed class EverythingBurns : Card
		{
			public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
			{
				return pooledMana;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				IReadOnlyList<Card> selectedCards = null;
				List<Card> list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				int number = base.SynergyAmount(consumingMana, ManaColor.Any, 1);
				bool flag = !list.Empty<Card>();
				if (flag)
				{
					SelectHandInteraction interaction = new SelectHandInteraction(0, number, list)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					selectedCards = interaction.SelectedCards.ToList<Card>();
					interaction = null;
				}
				bool flag2 = selectedCards != null;
				if (flag2)
				{
					bool flag3 = selectedCards.Count > 0;
					if (flag3)
					{
						yield return new ExileManyCardAction(selectedCards);
					}
				}
				int num;
				for (int i = 0; i < number; i = num + 1)
				{
					bool flag4 = selector.SelectedEnemy != null && selector.SelectedEnemy.IsAlive;
					if (flag4)
					{
						yield return base.AttackAction(selector.SelectedEnemy);
					}
					num = i;
				}
				yield break;
			}
		}
	}
}
