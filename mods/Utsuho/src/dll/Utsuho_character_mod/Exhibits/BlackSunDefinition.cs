using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace Utsuho_character_mod.Exhibits
{
	public sealed class BlackSunDefinition : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return "BlackSun";
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
				Black = 1
			}), null, new ManaColor?(ManaColor.Black), 1, false, null, Keyword.None, new List<string>(), new List<string> { "DarkMatter" });
		}

		[EntityLogic(typeof(BlackSunDefinition))]
		public sealed class BlackSun : ShiningExhibit
		{
			private string GunName
			{
				get
				{
					return "无差别起火";
				}
			}

			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<GameEventArgs>(base.Battle.Reshuffling, new EventSequencedReactor<GameEventArgs>(this.Reshuffling));
			}

			private IEnumerable<BattleAction> Reshuffling(GameEventArgs args)
			{
				List<Card> cards = base.Battle.DiscardZone.ToList<Card>();
				int total = cards.Count;
				yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)(base.Value1 * total), false), this.GunName, GunType.Single);
				yield break;
			}
		}
	}
}
