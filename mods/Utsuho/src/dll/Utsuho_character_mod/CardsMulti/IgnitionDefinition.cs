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
using Utsuho_character_mod.CardsB;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class IgnitionDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Ignition";
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
			return new CardConfig(13420, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, true, new ManaGroup
			{
				Black = 1,
				Red = 1
			}, null, null, null, null, null, null, null, null, new int?(8), new int?(12), new int?(1), new int?(1), new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Ethereal | Keyword.Initial, Keyword.Exile | Keyword.Ethereal | Keyword.Initial, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(IgnitionDefinition))]
		public sealed class Ignition : Card
		{
			public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
			{
				return pooledMana;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.SynergyAmount(consumingMana, ManaColor.Any, 1) * base.Value1), null, null, null, 0f, true);
				yield return new AddCardsToHandAction(Library.CreateCards<DarkMatterDef.DarkMatter>(base.SynergyAmount(consumingMana, ManaColor.Any, 1), false), AddCardsType.Normal);
				yield break;
			}
		}
	}
}
