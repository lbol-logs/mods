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

namespace Utsuho_character_mod.CardsR
{
	public sealed class WhiteHoleDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "WhiteHole";
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
			return new CardConfig(13070, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Common, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Any = 0
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, new int?(5), new int?(8), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Retain, Keyword.Exile | Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(WhiteHoleDef))]
		public sealed class WhiteHole : Card
		{
			public override IEnumerable<BattleAction> OnRetain()
			{
				bool flag = base.Zone == CardZone.Hand;
				if (flag)
				{
					yield return base.DefenseAction(true);
					yield return new AddCardsToDiscardAction(new Card[] { Library.CreateCard("DarkMatter") });
				}
				yield break;
			}
		}
	}
}
