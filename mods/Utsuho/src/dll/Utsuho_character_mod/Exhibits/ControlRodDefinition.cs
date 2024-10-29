using System;
using System.Collections;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Exhibits;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.Exhibits
{
	public sealed class ControlRodDefinition : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return "ControlRod";
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder = "Resources.";
			ExhibitSprites exhibitSprites = new ExhibitSprites();
			Func<string, Sprite> func = (string s) => ResourceLoader.LoadSprite(folder + this.GetId() + s + ".png", BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(0, "", 10, false, false, false, false, AppearanceType.Nowhere, "Utsuho", ExhibitLosableType.DebutLosable, Rarity.Shining, new int?(1), null, null, new ManaGroup?(new ManaGroup
			{
				Red = 1
			}), null, new ManaColor?(ManaColor.Red), 1, false, null, Keyword.None, new List<string> { "HeatStatus" }, new List<string>());
		}

		[EntityLogic(typeof(ControlRodDefinition))]
		public sealed class ControlRod : ShiningExhibit
		{
			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				base.NotifyActivating();
				this.triggered = true;
				Singleton<GameMaster>.Instance.StartCoroutine(this.ResetTrigger());
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
				yield break;
			}

			private IEnumerator ResetTrigger()
			{
				yield return new WaitForSeconds(1.5f);
				this.triggered = false;
				this.NotifyChanged();
				yield break;
			}

			private bool triggered;
		}
	}
}
