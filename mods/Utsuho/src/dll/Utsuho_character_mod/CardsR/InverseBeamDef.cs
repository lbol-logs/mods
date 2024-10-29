﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class InverseBeamDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "InverseBeam";
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
			return new CardConfig(13020, "", 10, true, new string[0][], "惨虐之光", "惨虐之光", 0, false, false, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, new int?(10), new int?(14), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Basic, Keyword.Basic, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(InverseBeamDef))]
		public sealed class InverseBeam : UtsuhoCard
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector.SelectedEnemy);
				yield break;
			}
		}
	}
}