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
	public sealed class WarpShieldDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "WarpShield";
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
			return new CardConfig(13250, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 2,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 2
			}), null, null, null, new int?(18), new int?(22), new int?(0), new int?(0), new int?(6), new int?(6), new int?(2), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(WarpShieldDef))]
		public sealed class WarpShield : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				base.DeltaBlock = 0;
				base.DeltaShield = 0;
				int num;
				for (int i = 0; i < base.Value2; i = num + 1)
				{
					bool flag = base.Battle.DrawZone.Count != 0;
					if (flag)
					{
						IReadOnlyList<Card> drawZoneIndexOrder = base.Battle.DrawZoneIndexOrder;
						Card card = UsefulFunctions.RandomUtsuho(drawZoneIndexOrder);
						UtsuhoCard uCard = card as UtsuhoCard;
						bool flag2 = uCard != null && uCard.isMass;
						if (flag2)
						{
							bool flag3 = !this.IsUpgraded;
							if (flag3)
							{
								base.DeltaBlock += base.Value1;
							}
							else
							{
								base.DeltaShield += base.Value1;
							}
						}
						yield return new MoveCardAction(card, CardZone.Hand);
						foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
						{
							yield return action;
							action = null;
						}
						IEnumerator<BattleAction> enumerator = null;
						drawZoneIndexOrder = null;
						card = null;
						uCard = null;
					}
					num = i;
				}
				yield return base.DefenseAction(true);
				base.DeltaBlock = 0;
				base.DeltaShield = 0;
				yield break;
				yield break;
			}
		}
	}
}
