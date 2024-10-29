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
	public sealed class HellGeyserDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "HellGeyser";
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
			return new CardConfig(13055, "", 10, true, new string[0][], "火激光", "火激光", 0, false, true, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2
			}, null, null, new int?(0), new int?(0), null, null, null, null, new int?(10), new int?(10), new int?(9), new int?(15), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(HellGeyserDefinition))]
		public sealed class HellGeyser : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					bool flag = this.tempDamage != 0;
					int num;
					if (flag)
					{
						num = this.tempDamage;
					}
					else
					{
						num = base.GetSeLevel<HeatStatus>() + base.Value1;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				this.tempDamage = base.GetSeLevel<HeatStatus>() + base.Value1;
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
				yield return base.AttackAction(selector.SelectedEnemy);
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					int level = base.GetSeLevel<HeatStatus>();
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value2 - level), null, null, null, 0f, true);
					this.tempDamage = 0;
					yield break;
				}
				yield break;
			}

			private int tempDamage = 0;
		}
	}
}
