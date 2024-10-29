using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsR
{
	public sealed class MaxPowerDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "MaxPower";
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
			return new CardConfig(13520, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2,
				Any = 3
			}, null, null, null, null, null, null, null, null, new int?(5), new int?(7), new int?(5), new int?(7), new ManaGroup?(new ManaGroup
			{
				Philosophy = 5
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 7
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(MaxPowerDef))]
		public sealed class MaxPower : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				List<Card> list = base.Battle.HandZone.ToList<Card>();
				bool flag = list.Count > 0;
				if (flag)
				{
					foreach (Card card in list)
					{
						yield return new ExileCardAction(card);
						card = null;
					}
					List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
				}
				yield return new DrawManyCardAction(base.Value1);
				yield return new LoseManaAction(base.Battle.BattleMana);
				yield return new GainManaAction(new ManaGroup
				{
					Philosophy = base.Value1
				});
				yield return new ApplyStatusEffectAction<TempFirepower>(base.Battle.Player, new int?(base.Value1), null, null, null, 0.2f, true);
				yield return new ApplyStatusEffectAction<TimeIsLimited>(base.Battle.Player, new int?(1), null, null, null, 0f, true);
				yield break;
				yield break;
			}
		}
	}
}
