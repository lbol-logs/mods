using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsB
{
	public sealed class ZeroPointDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "ZeroPoint";
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
			return new CardConfig(13430, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, default(ManaGroup), new ManaGroup?(default(ManaGroup)), null, null, null, null, null, new int?(4), new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden, Keyword.Forbidden | Keyword.Replenish, false, Keyword.Ethereal, Keyword.Ethereal, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(ZeroPointDefinition))]
		public sealed class ZeroPoint : UtsuhoCard
		{
			public ZeroPoint()
			{
				this.isMass = true;
			}

			public override IEnumerable<BattleAction> OnPull()
			{
				Card card = base.CloneBattleCard();
				card.IsEthereal = true;
				yield return base.DefenseAction(true);
				yield return new AddCardsToHandAction(new Card[] { card });
				yield break;
			}
		}
	}
}
