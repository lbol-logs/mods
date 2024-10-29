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

namespace Utsuho_character_mod.CardsU
{
	public sealed class ResonanceDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Resonance";
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
			return new CardConfig(13620, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Blue = 1
			}, new ManaGroup?(new ManaGroup
			{
				Blue = 1
			}), null, new int?(8), new int?(12), null, null, null, null, new int?(4), new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Ethereal, Keyword.Exile | Keyword.Ethereal, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(ResonanceDef))]
		public sealed class Resonance : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					bool flag = base.Battle == null;
					int num;
					if (flag)
					{
						num = 0;
					}
					else
					{
						bool flag2 = !this.IsUpgraded;
						if (flag2)
						{
							num = base.GetSeLevel<ResonanceStatus>();
						}
						else
						{
							num = base.GetSeLevel<ResonancePlusStatus>();
						}
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector, null);
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				bool flag = !this.IsUpgraded;
				if (flag)
				{
					yield return base.BuffAction<ResonanceStatus>(base.Value1, 0, 0, 0, 0.2f);
				}
				else
				{
					yield return base.BuffAction<ResonancePlusStatus>(base.Value1, 0, 0, 0, 0.2f);
				}
				yield break;
			}
		}
	}
}
