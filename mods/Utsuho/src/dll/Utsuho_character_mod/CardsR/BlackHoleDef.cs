using System;
using System.Collections;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class BlackHoleDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "BlackHole";
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
			return new CardConfig(13180, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Any = 0
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, new int?(8), new int?(12), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Retain, Keyword.Exile | Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(BlackHoleDef))]
		public sealed class BlackHole : Card
		{
			private IEnumerator ResetTrigger()
			{
				yield return new WaitForSecondsRealtime(1f);
				this.NotifyChanged();
				yield break;
			}

			public override IEnumerable<BattleAction> OnTurnStartedInHand()
			{
				bool flag = base.Zone == CardZone.Hand;
				if (flag)
				{
					Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
					Singleton<GameMaster>.Instance.StartCoroutine(this.ResetTrigger());
					yield return new DiscardAction(card);
					foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					card.NotifyActivating();
					yield return base.DefenseAction(true);
					card = null;
				}
				yield break;
				yield break;
			}
		}
	}
}
