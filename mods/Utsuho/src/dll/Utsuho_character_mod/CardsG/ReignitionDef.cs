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

namespace Utsuho_character_mod.CardsG
{
	public sealed class ReignitionDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Reignition";
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
			return new CardConfig(13640, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Green = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Green = 1,
				Any = 1
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(2), new int?(4), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(ReignitionDef))]
		public sealed class Reignition : Card
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
						int count = base.Battle.ExileZone.Count;
						num = count * base.Value1;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int total = base.Battle.ExileZone.Count;
				yield return base.AttackAction(selector.SelectedEnemy);
				yield break;
			}
		}
	}
}
