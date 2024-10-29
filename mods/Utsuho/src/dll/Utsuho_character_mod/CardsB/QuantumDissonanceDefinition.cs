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

namespace Utsuho_character_mod.CardsB
{
	public sealed class QuantumDissonanceDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "QuantumDissonance";
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
			return new CardConfig(13265, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 2,
				Any = 0
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, new int?(2), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Scry, Keyword.Scry, new List<string> { "QuantumDissonanceStatus" }, new List<string> { "QuantumDissonanceStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(QuantumDissonanceDefinition))]
		public sealed class QuantumDissonance : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new ApplyStatusEffectAction<QuantumDissonanceStatus>(base.Battle.Player, new int?(base.Value1), null, new int?(base.Value1), null, 0f, true);
				yield break;
			}
		}
	}
}
