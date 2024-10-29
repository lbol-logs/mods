using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod.CardsR
{
	public sealed class EscapeVelocityDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "EscapeVelocity";
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
			return new CardConfig(13220, "", 10, true, new string[0][], "Simple1", "Simple1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 1,
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, new int?(4), new int?(4), new int?(3), new int?(3), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "", new List<string>());
		}

		[EntityLogic(typeof(EscapeVelocityDef))]
		public sealed class EscapeVelocity : Card
		{
			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				bool flag = !this.IsUpgraded;
				if (flag)
				{
					int num;
					for (int i = 0; i < base.Value2; i = num + 1)
					{
						bool flag2 = base.Battle.HandZone.Count != 0;
						if (flag2)
						{
							Card card = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
							foreach (BattleAction action in UsefulFunctions.RandomCheck(card, base.Battle))
							{
								yield return action;
								action = null;
							}
							IEnumerator<BattleAction> enumerator = null;
							yield return new DiscardAction(card);
							card = null;
						}
						num = i;
					}
					for (int j = 0; j < base.Value1; j = num + 1)
					{
						yield return new DrawCardAction();
						num = j;
					}
				}
				else
				{
					List<EscapeVelocityDef.EscapeVelocity> list = Library.CreateCards<EscapeVelocityDef.EscapeVelocity>(2, true).ToList<EscapeVelocityDef.EscapeVelocity>();
					EscapeVelocityDef.EscapeVelocity first = list[0];
					EscapeVelocityDef.EscapeVelocity escapeConsider = list[1];
					first.ShowWhichDescription = 1;
					escapeConsider.ShowWhichDescription = 2;
					first.SetBattle(base.Battle);
					escapeConsider.SetBattle(base.Battle);
					MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					bool flag3 = interaction.SelectedCard == first;
					if (flag3)
					{
						int num;
						for (int k = 0; k < base.Value2; k = num + 1)
						{
							bool flag4 = base.Battle.HandZone.Count != 0;
							if (flag4)
							{
								Card card2 = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
								foreach (BattleAction action2 in UsefulFunctions.RandomCheck(card2, base.Battle))
								{
									yield return action2;
									action2 = null;
								}
								IEnumerator<BattleAction> enumerator2 = null;
								yield return new DiscardAction(card2);
								card2 = null;
							}
							num = k;
						}
						for (int l = 0; l < base.Value1; l = num + 1)
						{
							yield return new DrawCardAction();
							num = l;
						}
					}
					else
					{
						int num;
						for (int m = 0; m < base.Value1; m = num + 1)
						{
							yield return new DrawCardAction();
							num = m;
						}
						for (int n = 0; n < base.Value2; n = num + 1)
						{
							bool flag5 = base.Battle.HandZone.Count != 0;
							if (flag5)
							{
								Card card3 = UsefulFunctions.RandomUtsuho(base.Battle.HandZone);
								foreach (BattleAction action3 in UsefulFunctions.RandomCheck(card3, base.Battle))
								{
									yield return action3;
									action3 = null;
								}
								IEnumerator<BattleAction> enumerator3 = null;
								yield return new DiscardAction(card3);
								card3 = null;
							}
							num = n;
						}
					}
					list = null;
					first = null;
					escapeConsider = null;
					interaction = null;
				}
				yield break;
				yield break;
			}
		}
	}
}
