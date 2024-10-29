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

namespace Utsuho_character_mod.CardsG
{
	public sealed class TurboFuelDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "TurboFuel";
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
			return new CardConfig(13650, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Green = 1,
				Any = 3
			}, new ManaGroup?(new ManaGroup
			{
				Green = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(2), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "TurboFuelStatus" }, new List<string> { "TurboFuelStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(TurboFuelDef))]
		public sealed class TurboFuel : Card
		{
			public ManaGroup manatype
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = 2
					};
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.BuffAction<TurboFuelStatus>(base.Value1, 0, 0, 0, 0.2f);
				yield break;
			}
		}
	}
}
