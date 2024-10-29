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
	public sealed class NuclearStrikeDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "NuclearStrike";
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
			return new CardConfig(13481, "", 10, true, new string[0][], "火激光", "火激光", 0, false, false, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(0), new int?(0), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy | Keyword.Echo, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(NuclearStrikeDefinition))]
		public sealed class NuclearStrike : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					return base.GetSeLevel<HeatStatus>();
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector.SelectedEnemy);
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					int level = base.GetSeLevel<HeatStatus>();
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1 - level), null, null, null, 0f, true);
					yield break;
				}
				yield break;
			}
		}
	}
}
