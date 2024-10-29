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

namespace Utsuho_character_mod.CardsMulti
{
	public sealed class AblativeArmorDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "AblativeArmor";
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
			return new CardConfig(13527, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Black = 1,
				Red = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Any = 4
			}), null, null, null, new int?(20), new int?(25), new int?(0), new int?(0), new int?(10), new int?(14), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Retain, Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(AblativeArmorDef))]
		public sealed class AblativeArmor : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					base.DeltaShield = 0;
					bool flag2 = base.Battle.HandZone.Count != 0;
					if (flag2)
					{
						Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
						for (;;)
						{
							UtsuhoCard uCard = card as UtsuhoCard;
							bool flag3 = uCard != null && uCard.isMass;
							if (!flag3)
							{
								break;
							}
							yield return new ExileCardAction(card);
							base.DeltaShield += base.Value1;
							bool flag4 = base.Battle.HandZone.Count != 0;
							if (!flag4)
							{
								break;
							}
							card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
						}
						card = null;
					}
					yield return base.DefenseAction(true);
					base.DeltaShield = 0;
					yield break;
				}
				yield break;
			}
		}
	}
}
