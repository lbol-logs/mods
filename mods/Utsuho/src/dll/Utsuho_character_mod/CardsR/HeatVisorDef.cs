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

namespace Utsuho_character_mod.CardsR
{
	public sealed class HeatVisorDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "HeatVisor";
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
			return new CardConfig(13330, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 2
			}), null, null, null, new int?(18), new int?(24), null, null, new int?(40), new int?(30), new int?(1), new int?(1), new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(HeatVisorDef))]
		public sealed class HeatVisor : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.DefenseAction(true);
				int level = base.GetSeLevel<HeatStatus>();
				bool flag = level >= base.Value1;
				if (flag)
				{
					yield return new ApplyStatusEffectAction<HeatVisorStatus>(base.Battle.Player, new int?(base.Value2), null, null, null, 0f, true);
				}
				yield break;
			}
		}
	}
}
