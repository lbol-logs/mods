using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Neutral.NoColor;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class SunlightReverieDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "SunlightReverie";
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
			return new CardConfig(13290, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 1
			}), null, null, null, null, null, null, null, new int?(2), new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Exile, Keyword.Exile, new List<string>(), new List<string>(), new List<string> { "RManaCard" }, new List<string> { "RManaCard" }, "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(SunlightReverieDef))]
		public sealed class SunlightReverie : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<RManaCard>(base.Value1, false), AddCardsType.Normal);
				bool flag = !this.IsUpgraded;
				if (flag)
				{
					bool flag2 = base.Battle.DrawZone.NotEmpty<Card>();
					if (flag2)
					{
						Card card = UsefulFunctions.RandomUtsuho(base.Battle.DrawZone);
						foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
						{
							yield return action;
							action = null;
						}
						IEnumerator<BattleAction> enumerator = null;
						bool flag3 = card != null;
						if (flag3)
						{
							yield return new ExileCardAction(card);
						}
						card = null;
					}
				}
				else
				{
					List<SunlightReverieDef.SunlightReverie> list = Library.CreateCards<SunlightReverieDef.SunlightReverie>(2, true).ToList<SunlightReverieDef.SunlightReverie>();
					SunlightReverieDef.SunlightReverie first = list[0];
					SunlightReverieDef.SunlightReverie discardConsider = list[1];
					first.ShowWhichDescription = 1;
					discardConsider.ShowWhichDescription = 2;
					first.SetBattle(base.Battle);
					discardConsider.SetBattle(base.Battle);
					MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					bool flag4 = interaction.SelectedCard == first;
					if (flag4)
					{
						bool flag5 = base.Battle.DrawZone.NotEmpty<Card>();
						if (flag5)
						{
							Card card2 = UsefulFunctions.RandomUtsuho(base.Battle.DrawZone);
							bool flag6 = card2 != null;
							if (flag6)
							{
								yield return new ExileCardAction(card2);
							}
							foreach (BattleAction action2 in UsefulFunctions.RandomCheck(card2, base.Battle))
							{
								yield return action2;
								action2 = null;
							}
							IEnumerator<BattleAction> enumerator2 = null;
							card2 = null;
						}
					}
					else
					{
						bool flag7 = base.Battle.DiscardZone.NotEmpty<Card>();
						if (flag7)
						{
							Card card3 = UsefulFunctions.RandomUtsuho(base.Battle.DiscardZone);
							bool flag8 = card3 != null;
							if (flag8)
							{
								yield return new ExileCardAction(card3);
							}
							foreach (BattleAction action3 in UsefulFunctions.RandomCheck(card3, base.Battle))
							{
								yield return action3;
								action3 = null;
							}
							IEnumerator<BattleAction> enumerator3 = null;
							card3 = null;
						}
					}
					list = null;
					first = null;
					discardConsider = null;
					interaction = null;
				}
				yield break;
				yield break;
			}
		}
	}
}
