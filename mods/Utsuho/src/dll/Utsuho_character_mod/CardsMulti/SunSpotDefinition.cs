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
	public sealed class SunSpotDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SunSpot";
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
			return new CardConfig(13540, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 2
			}), null, null, null, null, null, null, null, new int?(40), new int?(40), new int?(4), new int?(4), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus", "SunSpotStatus" }, new List<string> { "HeatStatus", "SunSpotStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(SunSpotDefinition))]
		public sealed class SunSpot : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
					yield return new AddCardsToHandAction(new Card[]
					{
						Library.CreateCard("DarkMatter"),
						Library.CreateCard("DarkMatter"),
						Library.CreateCard("DarkMatter"),
						Library.CreateCard("DarkMatter")
					});
					bool flag2 = !this.IsUpgraded;
					if (flag2)
					{
						yield return new ApplyStatusEffectAction<SunSpotStatus>(base.Battle.Player, new int?(1), null, null, null, 0f, true);
					}
					else
					{
						yield return new ApplyStatusEffectAction<SunSpotStatus>(base.Battle.Player, new int?(2), null, null, null, 0f, true);
					}
					yield break;
				}
				yield break;
			}
		}
	}
}
