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

namespace Utsuho_character_mod.CardsB
{
	public sealed class GravityWellDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "GravityWell";
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
			return new CardConfig(13260, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 2,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(3), new int?(5), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "GravityWellStatus" }, new List<string> { "GravityWellStatus" }, new List<string> { "DarkMatter" }, new List<string> { "DarkMatter" }, "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(GravityWellDefinition))]
		public sealed class GravityWell : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return new ApplyStatusEffectAction<GravityWellStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
					yield break;
				}
				yield break;
			}
		}
	}
}
