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
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class ShootingStarDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "ShootingStar";
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
			return new CardConfig(13050, "", 10, true, new string[0][], "导航之星", "导航之星", 0, false, true, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 2
			}), null, new int?(8), new int?(10), new int?(8), new int?(12), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(ShootingStarDef))]
		public sealed class ShootingStar : UtsuhoCard
		{
			public ShootingStar()
			{
				this.isMass = true;
			}

			public override IEnumerable<BattleAction> OnPull()
			{
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard("DarkMatter") });
				yield return base.DefenseAction(true);
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector.SelectedEnemy);
				yield return base.AttackAction(selector.SelectedEnemy);
				yield break;
			}
		}
	}
}
