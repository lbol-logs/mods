using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class AbyssNovaDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "AbyssNova";
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
			return new CardConfig(13460, "", 10, true, new string[0][], "十王审判9", "十王审判9", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 3,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 3,
				Any = 2
			}), null, new int?(7), new int?(9), null, null, null, null, new int?(7), new int?(9), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.Battlefield, Keyword.Battlefield, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(AbyssNovaDef))]
		public sealed class AbyssNova : Card
		{
			[UsedImplicitly]
			public override int AdditionalDamage
			{
				get
				{
					bool flag = base.Battle == null;
					int num;
					if (flag)
					{
						num = 0;
					}
					else
					{
						List<Card> list = (from card in base.Battle.EnumerateAllCards()
							where card != this
							select card).ToList<Card>();
						int count = list.FindAll(delegate(Card card)
						{
							UtsuhoCard utsuhoCard = card as UtsuhoCard;
							return utsuhoCard != null && utsuhoCard.isMass;
						}).Count;
						num = base.Value1 * count;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return base.AttackAction(selector, null);
				yield break;
			}
		}
	}
}
