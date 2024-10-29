using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsR
{
	public sealed class FlareUpDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "FlareUp";
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
			return new CardConfig(13130, "", 10, true, new string[0][], "火激光", "火激光", 0, false, true, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(2), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus", "Weak", "Vulnerable" }, new List<string> { "HeatStatus", "Weak", "Vulnerable" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(FlareUpDef))]
		public sealed class FlareUp : Card
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
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					int level = base.GetSeLevel<HeatStatus>();
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						yield return base.DebuffAction<Weak>(selector.SelectedEnemy, 0, base.Value1, 0, 0, true, 0.2f);
						yield return base.DebuffAction<Vulnerable>(selector.SelectedEnemy, 0, base.Value1, 0, 0, true, 0.2f);
					}
					yield return base.AttackAction(selector.SelectedEnemy);
					bool flag2 = level != 0;
					if (flag2)
					{
						yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<HeatStatus>(), true, 0.1f);
					}
					bool flag3 = !this.IsUpgraded;
					if (flag3)
					{
						yield return base.DebuffAction<Weak>(selector.SelectedEnemy, 0, base.Value1, 0, 0, true, 0.2f);
						yield return base.DebuffAction<Vulnerable>(selector.SelectedEnemy, 0, base.Value1, 0, 0, true, 0.2f);
					}
					yield break;
				}
				yield break;
			}
		}
	}
}
