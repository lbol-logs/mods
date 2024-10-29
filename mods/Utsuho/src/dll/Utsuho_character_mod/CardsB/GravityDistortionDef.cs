using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsB
{
	public sealed class GravityDistortionDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "GravityDistortion";
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
			return new CardConfig(13110, "", 10, true, new string[0][], "冰封噩梦", "冰封噩梦", 0, false, true, true, false, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Black = 1,
				Any = 2
			}), null, new int?(17), new int?(20), null, null, null, null, null, null, new int?(1), new int?(2), new ManaGroup?(new ManaGroup
			{
				Black = 2
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { "Reflect", "Weak" }, new List<string> { "Reflect", "Weak" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(GravityDistortionDef))]
		public sealed class GravityDistortion : UtsuhoCard
		{
			public GravityDistortion()
			{
				this.isMass = true;
			}

			public override IEnumerable<BattleAction> OnPull()
			{
				yield return new GainManaAction(base.Mana);
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					foreach (BattleAction battleAction in base.DebuffAction<Weak>(selector.GetUnits(base.Battle), 0, base.Value2, 0, 0, true, 0.2f))
					{
						yield return battleAction;
						battleAction = null;
					}
					IEnumerator<BattleAction> enumerator = null;
					yield return base.AttackAction(selector, null);
					yield break;
				}
				yield break;
				yield break;
			}
		}
	}
}
