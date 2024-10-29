using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class UltravioletDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Ultraviolet";
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
			return new CardConfig(13385, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			}, new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			}), null, null, null, null, null, null, null, new int?(1), new int?(2), null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 3
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Retain, Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(UltravioletDef))]
		public sealed class Ultraviolet : UtsuhoCard
		{
			public Ultraviolet()
			{
				this.isMass = true;
			}

			public override IEnumerable<BattleAction> OnPull()
			{
				yield return new DrawManyCardAction(base.Value1);
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new GainManaAction(base.Mana);
				yield break;
			}
		}
	}
}
