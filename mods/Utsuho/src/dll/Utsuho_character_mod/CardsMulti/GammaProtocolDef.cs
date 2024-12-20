﻿using System;
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
	public sealed class GammaProtocolDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "GammaProtocol";
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
			return new CardConfig(13532, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, false, false, true, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor>
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
			}), null, null, null, null, null, null, null, new int?(50), new int?(70), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "RadiationStatus" }, new List<string> { "RadiationStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(GammaProtocolDef))]
		public sealed class GammaProtocol : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new ApplyStatusEffectAction<RadiationStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
				yield break;
			}
		}
	}
}
