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
	public sealed class PlasmaBurnDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "PlasmaBurn";
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
			return new CardConfig(13140, "", 10, true, new string[0][], "火激光", "火激光", 0, false, true, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(25), new int?(35), new int?(50), new int?(50), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(PlasmaBurnDef))]
		public sealed class PlasmaBurn : Card
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
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					this.tempDamage = base.GetSeLevel<HeatStatus>() + base.Value1;
					int level = base.GetSeLevel<HeatStatus>();
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
					bool flag2 = level + base.Value1 >= base.Value2;
					if (flag2)
					{
						yield return base.AttackAction(selector, null);
						yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<HeatStatus>(), true, 0.1f);
					}
					this.tempDamage = 0;
					yield break;
				}
				yield break;
			}

			private int tempDamage = 0;
		}
	}
}
