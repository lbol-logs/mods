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
	public sealed class RecklessGambleDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "RecklessGamble";
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
			return new CardConfig(13280, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), null, null, null, null, null, null, null, new int?(4), new int?(5), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Exile, Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(RecklessGambleDef))]
		public sealed class RecklessGamble : Card
		{
			private IEnumerator ResetTrigger()
			{
				yield return new WaitForSecondsRealtime(1f);
				this.NotifyChanged();
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new DrawManyCardAction(base.Value1);
				Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
				foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
				{
					yield return action;
					action = null;
				}
				IEnumerator<BattleAction> enumerator = null;
				card.NotifyActivating();
				Singleton<GameMaster>.Instance.StartCoroutine(this.ResetTrigger());
				yield return new ExileCardAction(card);
				yield break;
				yield break;
			}
		}
	}
}
