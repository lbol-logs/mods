using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsW
{
	public sealed class DisintegrateDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Disintegrate";
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
			return new CardConfig(13570, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				White = 1,
				Any = 2
			}, null, null, new int?(18), new int?(24), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Accuracy | Keyword.Exile, false, Keyword.Expel, Keyword.Expel, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(DisintegrateDefinition))]
		public sealed class Disintegrate : Card
		{
			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
			}

			private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
			{
				bool flag = args.DieSource == this && !args.Unit.HasStatusEffect<Servant>();
				if (flag)
				{
					List<Card> list = base.GameRun.BaseDeckWithOutUnremovable.ToList<Card>();
					bool flag2 = list.Count > 0;
					if (flag2)
					{
						SelectCardInteraction interaction = new SelectCardInteraction(1, 1, list, SelectedCardHandling.DoNothing)
						{
							CanCancel = false,
							Description = "Select a card to remove."
						};
						yield return new InteractionAction(interaction, false);
						bool flag3 = !interaction.IsCanceled;
						if (flag3)
						{
							base.GameRun.RemoveDeckCards(new Card[] { interaction.SelectedCards[0] }, true);
						}
						interaction = null;
						interaction = null;
					}
					list = null;
				}
				yield break;
			}
		}
	}
}
