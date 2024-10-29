using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class StarlightDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Starlight";
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
			return new CardConfig(13170, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Common, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, new int?(10), new int?(0), new int?(0), new int?(10), new int?(16), new int?(22), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(StarlightDef))]
		public sealed class Starlight : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return base.DefenseAction(true);
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
					yield return new AddCardsToHandAction(new Card[]
					{
						Library.CreateCard("DarkMatter"),
						Library.CreateCard("DarkMatter")
					});
					yield break;
				}
				yield break;
			}
		}
	}
}
