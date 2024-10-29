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
	public sealed class BunkerDownDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "BunkerDown";
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
			return new CardConfig(13360, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Red = 2,
				Any = 2
			}), null, null, null, new int?(14), new int?(18), new int?(16), new int?(20), null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Debut, Keyword.Debut, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(BunkerDownDef))]
		public sealed class BunkerDown : Card
		{
			protected override string GetBaseDescription()
			{
				bool debutActive = base.DebutActive;
				string text;
				if (debutActive)
				{
					text = base.GetBaseDescription();
				}
				else
				{
					text = base.ExtraDescription1;
				}
				return text;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.DefenseAction(base.ConfigBlock, 0, BlockShieldType.Normal, true);
				bool playInTriggered = base.PlayInTriggered;
				if (playInTriggered)
				{
					yield return base.DefenseAction(0, base.ConfigShield, BlockShieldType.Normal, true);
					base.DecreaseBaseCost(base.Mana);
				}
				yield break;
			}
		}
	}
}
