using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
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
	public sealed class PlanetaryOrbitDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "PlanetaryOrbit";
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
			return new CardConfig(13450, "", 10, true, new string[0][], "狐狸", "狐狸", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 2
			}), null, new int?(0), new int?(0), null, null, null, null, new int?(1), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(PlanetaryOrbitDef))]
		public sealed class PlanetaryOrbit : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					bool flag = base.Battle != null;
					int num;
					if (flag)
					{
						Card[] array = base.Battle.DrawZone.SampleManyOrAll(999, base.GameRun.BattleRng);
						Card[] array2 = base.Battle.DiscardZone.ToArray<Card>();
						num = base.Value1 * (array.Length + array2.Length);
					}
					else
					{
						num = 0;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				Card[] array = base.Battle.DrawZone.SampleManyOrAll(999, base.GameRun.BattleRng);
				Card[] array2 = base.Battle.DiscardZone.ToArray<Card>();
				bool flag = array.Length != 0;
				if (flag)
				{
					foreach (Card card in array)
					{
						yield return new DiscardAction(card);
						card = null;
					}
					Card[] array3 = null;
				}
				bool flag2 = array2.Length != 0;
				if (flag2)
				{
					foreach (Card card2 in array2)
					{
						yield return new MoveCardToDrawZoneAction(card2, DrawZoneTarget.Top);
						card2 = null;
					}
					Card[] array4 = null;
				}
				yield return base.AttackAction(selector, null);
				array = base.Battle.DrawZone.SampleManyOrAll(999, base.GameRun.BattleRng);
				array2 = base.Battle.DiscardZone.ToArray<Card>();
				bool flag3 = array.Length != 0;
				if (flag3)
				{
					foreach (Card card3 in array)
					{
						foreach (BattleAction action in UsefulFunctions.RandomCheck(card3, base.Battle))
						{
							yield return action;
							action = null;
						}
						IEnumerator<BattleAction> enumerator = null;
						card3 = null;
					}
					Card[] array5 = null;
				}
				bool flag4 = array2.Length != 0;
				if (flag4)
				{
					foreach (Card card4 in array2)
					{
						foreach (BattleAction action2 in UsefulFunctions.RandomCheck(card4, base.Battle))
						{
							yield return action2;
							action2 = null;
						}
						IEnumerator<BattleAction> enumerator2 = null;
						card4 = null;
					}
					Card[] array6 = null;
				}
				base.DeltaDamage = 0;
				yield break;
				yield break;
			}
		}
	}
}
