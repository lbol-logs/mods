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
	public sealed class HighTensionDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "HighTension";
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
			return new CardConfig(13240, "", 10, true, new string[0][], "狼天狗砍", "狼天狗砍", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 2
			}), null, new int?(15), new int?(15), null, null, null, null, new int?(4), new int?(6), new int?(5), new int?(5), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(HighTensionDef))]
		public sealed class HighTension : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				base.DeltaDamage = 0;
				int num;
				for (int i = 0; i < base.Value1; i = num + 1)
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
							base.DeltaDamage += base.Value2;
						}
						yield return new MoveCardAction(card, CardZone.Discard);
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
				yield return base.AttackAction(selector, null);
				base.DeltaDamage = 0;
				yield break;
				yield break;
			}
		}
	}
}
