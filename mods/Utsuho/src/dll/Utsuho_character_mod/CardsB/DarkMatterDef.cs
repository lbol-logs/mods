using System;
using System.Collections.Generic;
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

namespace Utsuho_character_mod.CardsB
{
	public sealed class DarkMatterDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "DarkMatter";
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
			return new CardConfig(13060, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, false, false, false, false, Rarity.Common, CardType.Status, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Any = 1
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Replenish, Keyword.None, false, Keyword.Retain, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Flippin'Loser", new List<string>());
		}

		[EntityLogic(typeof(DarkMatterDef))]
		public sealed class DarkMatter : UtsuhoCard
		{
			public DarkMatter()
			{
				this.isMass = true;
			}

			public override bool Triggered
			{
				get
				{
					return base.IsTempRetain;
				}
			}

			public override IEnumerable<BattleAction> OnDraw()
			{
				return this.EnterHandReactor();
			}

			public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
			{
				bool flag = dstZone != CardZone.Hand;
				IEnumerable<BattleAction> enumerable;
				if (flag)
				{
					enumerable = null;
				}
				else
				{
					enumerable = this.EnterHandReactor();
				}
				return enumerable;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				base.IsTempRetain = false;
				yield break;
			}

			private IEnumerable<BattleAction> EnterHandReactor()
			{
				base.IsTempRetain = true;
				yield break;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				bool flag = base.Zone == CardZone.Hand;
				if (flag)
				{
					base.IsTempRetain = true;
				}
			}
		}
	}
}
