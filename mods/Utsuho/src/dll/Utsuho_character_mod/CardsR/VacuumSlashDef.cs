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
	public sealed class VacuumSlashDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "VacuumSlash";
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
			return new CardConfig(13210, "", 10, true, new string[0][], "YoumuKan", "YoumuKan", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 1
			}), null, new int?(8), null, null, null, null, null, new int?(1), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(VacuumSlashDef))]
		public sealed class VacuumSlash : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = base.Battle.HandZone.Count > 0;
				if (flag)
				{
					Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
					foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					yield return new DiscardAction(card);
					UtsuhoCard uCard = card as UtsuhoCard;
					bool flag2 = uCard != null && uCard.isMass;
					if (flag2)
					{
						yield return base.AttackAction(selector, null);
						bool isUpgraded = this.IsUpgraded;
						if (isUpgraded)
						{
							yield return base.AttackAction(selector, null);
						}
					}
					card = null;
					uCard = null;
				}
				yield return base.AttackAction(selector, null);
				yield break;
				yield break;
			}
		}
	}
}
