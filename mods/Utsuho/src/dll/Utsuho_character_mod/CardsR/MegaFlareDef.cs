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

namespace Utsuho_character_mod.CardsR
{
	public sealed class MegaFlareDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "MegaFlare";
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
			return new CardConfig(13510, "", 10, true, new string[0][], "月下鼓", "月下鼓", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2,
				Any = 2
			}, null, null, new int?(12), new int?(18), null, null, null, null, new int?(2), new int?(3), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Retain, Keyword.Exile | Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(MegaFlareDef))]
		public sealed class MegaFlare : Card
		{
			public override IEnumerable<BattleAction> OnRetain()
			{
				bool flag = base.Zone == CardZone.Hand;
				if (flag)
				{
					base.DeltaDamage -= base.Value1;
				}
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector, null);
				yield return base.AttackAction(selector, null);
				yield return base.AttackAction(selector, null);
				yield return base.AttackAction(selector, null);
				yield break;
			}
		}
	}
}
