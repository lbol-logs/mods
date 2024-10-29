using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class HotSpringDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "HotSpring";
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
			return new CardConfig(13660, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Red = 1,
				Green = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Green = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(6), new int?(9), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HotSpringStatus" }, new List<string> { "HotSpringStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(HotSpringDef))]
		public sealed class HotSpring : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.BuffAction<HotSpringStatus>(base.Value1, 0, 0, 0, 0.2f);
				yield break;
			}
		}
	}
}
