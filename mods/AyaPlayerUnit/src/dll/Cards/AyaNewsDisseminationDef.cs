using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaNewsDisseminationDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-821332183);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaNewsDisseminationDef.\u200C\u202D\u200C\u200D\u202A\u200D\u200C\u206E\u200B\u206A\u206B\u202B\u200B\u206B\u206B\u206A\u206F\u202C\u200F\u202C\u202D\u202C\u202B\u206A\u202B\u206A\u206C\u202A\u206B\u200F\u200C\u202B\u200C\u206D\u206A\u202A\u202B\u200C\u200E\u202C\u202E(BepinexPlugin.embeddedSource);
			AyaNewsDisseminationDef.\u206C\u200D\u206C\u202D\u206C\u200B\u200F\u206B\u202C\u206C\u206E\u202C\u200F\u202C\u202A\u202B\u202D\u206A\u206F\u202D\u200D\u200D\u206B\u200F\u206A\u206C\u206E\u206D\u200E\u200E\u206C\u200B\u206F\u202E\u202E\u202B\u206A\u206B\u206F\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaNewsDisseminationDef.\u202B\u202C\u206E\u200D\u206E\u202C\u200D\u202C\u206E\u200F\u202D\u202E\u202C\u200E\u202E\u202B\u206D\u202C\u206A\u202B\u206A\u206F\u202B\u206A\u200D\u200E\u206A\u206A\u206F\u206A\u206F\u206C\u202C\u206A\u206B\u200C\u202D\u202E\u200B\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaNewsDisseminationDef.\u200D\u202D\u202A\u206C\u202E\u206C\u202D\u206E\u200B\u206A\u200D\u206B\u200B\u206D\u200B\u200D\u206C\u206C\u202A\u206F\u206E\u206E\u200D\u206B\u202C\u202B\u202B\u202D\u202A\u202B\u200B\u206B\u202A\u202C\u206D\u202E\u200E\u206E\u200B\u200C\u202E(BepinexPlugin.sequenceTable, AyaNewsDisseminationDef.\u202C\u206C\u200E\u202A\u200D\u206E\u200B\u200C\u202B\u202B\u206B\u202E\u206D\u206D\u202A\u202E\u200B\u202E\u206A\u206B\u206B\u206E\u206C\u200C\u202D\u200C\u202B\u202D\u206F\u206D\u202E\u202A\u200E\u200D\u202E\u206F\u206C\u202B\u206C\u202E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Green = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, new int?(3), new int?(2), new int?(3), null, new ManaGroup?(BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Green = 2
			} : new ManaGroup
			{
				Green = 4
			}), new ManaGroup?(BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Green = 1,
				Philosophy = 1
			} : new ManaGroup
			{
				Green = 2,
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.Philosophy, new List<string>(), new List<string>(), new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447) }, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139) }, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1945265785), new List<string>());
		}

		static CardImages \u200C\u202D\u200C\u200D\u202A\u200D\u200C\u206E\u200B\u206A\u206B\u202B\u200B\u206B\u206B\u206A\u206F\u202C\u200F\u202C\u202D\u202C\u202B\u206A\u202B\u206A\u206C\u202A\u206B\u200F\u200C\u202B\u200C\u206D\u206A\u202A\u202B\u200C\u200E\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u200D\u206C\u202D\u206C\u200B\u200F\u206B\u202C\u206C\u206E\u202C\u200F\u202C\u202A\u202B\u202D\u206A\u206F\u202D\u200D\u200D\u206B\u200F\u206A\u206C\u206E\u206D\u200E\u200E\u206C\u200B\u206F\u202E\u202E\u202B\u206A\u206B\u206F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202B\u202C\u206E\u200D\u206E\u202C\u200D\u202C\u206E\u200F\u202D\u202E\u202C\u200E\u202E\u202B\u206D\u202C\u206A\u202B\u206A\u206F\u202B\u206A\u200D\u200E\u206A\u206A\u206F\u206A\u206F\u206C\u202C\u206A\u206B\u200C\u202D\u202E\u200B\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u206C\u200E\u202A\u200D\u206E\u200B\u200C\u202B\u202B\u206B\u202E\u206D\u206D\u202A\u202E\u200B\u202E\u206A\u206B\u206B\u206E\u206C\u200C\u202D\u200C\u202B\u202D\u206F\u206D\u202E\u202A\u200E\u200D\u202E\u206F\u206C\u202B\u206C\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u202D\u202A\u206C\u202E\u206C\u202D\u206E\u200B\u206A\u200D\u206B\u200B\u206D\u200B\u200D\u206C\u206C\u202A\u206F\u206E\u206E\u200D\u206B\u202C\u202B\u202B\u202D\u202A\u202B\u200B\u206B\u202A\u202C\u206D\u202E\u200E\u206E\u200B\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaNewsDisseminationDef))]
		public sealed class AyaNewsDissemination : Card
		{
			public override bool DiscardCard
			{
				get
				{
					return true;
				}
			}

			public override Interaction Precondition()
			{
				List<Card> list = (from hand in AyaNewsDisseminationDef.AyaNewsDissemination.\u206D\u200D\u206B\u200F\u202A\u202D\u206B\u206C\u206B\u200C\u202E\u202D\u200C\u202B\u206F\u206A\u206D\u200D\u202A\u206C\u202D\u200F\u200B\u202E\u202E\u206F\u200C\u200D\u202B\u200B\u202C\u202E\u206A\u202B\u206F\u200C\u202A\u200B\u200E\u206E\u202E(AyaNewsDisseminationDef.AyaNewsDissemination.\u202D\u206E\u200E\u202E\u200F\u200B\u206B\u206A\u202E\u206D\u206E\u200F\u200D\u206E\u206F\u202C\u200B\u200E\u206E\u200C\u202E\u206C\u206B\u206F\u200F\u200D\u206F\u206A\u206D\u202C\u202C\u206E\u206B\u200C\u206C\u202B\u206B\u206E\u206A\u202E\u202E(this))
					where hand != this
					select hand).ToList<Card>();
				for (;;)
				{
					IL_0022:
					int num = 200713384;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-215572315 + -1565034823 - ~(uint)(num2 - -1951703183 * (-489024011 - --1730278599))))) % 6U)
						{
						case 0U:
							goto IL_0022;
						case 1U:
							num = (int)(((list.Count > AyaNewsDisseminationDef.AyaNewsDissemination.\u200D\u206A\u200E\u206C\u202A\u202D\u200F\u202C\u200E\u200F\u200C\u200F\u202E\u200C\u200F\u200C\u202C\u206D\u206A\u206E\u206D\u206B\u206A\u206D\u200B\u206C\u200E\u206A\u206C\u206D\u206B\u206F\u200B\u200E\u206F\u206F\u202B\u206D\u206F\u206D\u202E(this)) ? 3931491669U : 2462725255U) ^ (num3 * 823848346U));
							continue;
						case 2U:
							num = ((list.Count <= AyaNewsDisseminationDef.AyaNewsDissemination.\u200D\u206A\u200E\u206C\u202A\u202D\u200F\u202C\u200E\u200F\u200C\u200F\u202E\u200C\u200F\u200C\u202C\u206D\u206A\u206E\u206D\u206B\u206A\u206D\u200B\u206C\u200E\u206A\u206C\u206D\u206B\u206F\u200B\u200E\u206F\u206F\u202B\u206D\u206F\u206D\u202E(this)) ? 563005812 : 1004437172);
							continue;
						case 3U:
							goto IL_00A6;
						case 4U:
							this.allHand = list;
							num = (int)((num3 * 3837655943U) ^ 1644955857U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				goto IL_00F5;
				IL_00A6:
				return AyaNewsDisseminationDef.AyaNewsDissemination.\u200C\u206F\u200E\u202D\u206B\u206B\u206D\u202C\u206E\u206C\u200D\u206F\u206A\u202D\u200E\u202D\u202B\u206B\u200E\u206A\u206D\u206E\u200E\u200C\u200F\u202C\u200C\u200F\u202D\u200F\u202B\u206A\u200C\u206D\u200C\u206A\u206B\u200D\u206C\u202E\u202E(AyaNewsDisseminationDef.AyaNewsDissemination.\u200D\u206A\u200E\u206C\u202A\u202D\u200F\u202C\u200E\u200F\u200C\u200F\u202E\u200C\u200F\u200C\u202C\u206D\u206A\u206E\u206D\u206B\u206A\u206D\u200B\u206C\u200E\u206A\u206C\u206D\u206B\u206F\u200B\u200E\u206F\u206F\u202B\u206D\u206F\u206D\u202E(this), AyaNewsDisseminationDef.AyaNewsDissemination.\u206D\u202E\u200C\u200D\u202B\u200C\u206E\u206C\u206A\u206C\u202C\u206A\u202E\u206E\u200C\u206C\u200E\u202E\u206C\u200E\u200F\u202E\u206A\u206A\u202A\u200D\u206C\u206C\u200E\u206B\u200D\u202C\u202C\u200D\u202A\u206B\u206E\u200C\u202D\u202E\u202E(this), list);
				IL_00F5:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaNewsDisseminationDef.AyaNewsDissemination.<Actions>d__4 <Actions>d__ = new AyaNewsDisseminationDef.AyaNewsDissemination.<Actions>d__4(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static BattleController \u202D\u206E\u200E\u202E\u200F\u200B\u206B\u206A\u202E\u206D\u206E\u200F\u200D\u206E\u206F\u202C\u200B\u200E\u206E\u200C\u202E\u206C\u206B\u206F\u200F\u200D\u206F\u206A\u206D\u202C\u202C\u206E\u206B\u200C\u206C\u202B\u206B\u206E\u206A\u202E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206D\u200D\u206B\u200F\u202A\u202D\u206B\u206C\u206B\u200C\u202E\u202D\u200C\u202B\u206F\u206A\u206D\u200D\u202A\u206C\u202D\u200F\u200B\u202E\u202E\u206F\u200C\u200D\u202B\u200B\u202C\u202E\u206A\u202B\u206F\u200C\u202A\u200B\u200E\u206E\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static int \u200D\u206A\u200E\u206C\u202A\u202D\u200F\u202C\u200E\u200F\u200C\u200F\u202E\u200C\u200F\u200C\u202C\u206D\u206A\u206E\u206D\u206B\u206A\u206D\u200B\u206C\u200E\u206A\u206C\u206D\u206B\u206F\u200B\u200E\u206F\u206F\u202B\u206D\u206F\u206D\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static int \u206D\u202E\u200C\u200D\u202B\u200C\u206E\u206C\u206A\u206C\u202C\u206A\u202E\u206E\u200C\u206C\u200E\u202E\u206C\u200E\u200F\u202E\u206A\u206A\u202A\u200D\u206C\u206C\u200E\u206B\u200D\u202C\u202C\u200D\u202A\u206B\u206E\u200C\u202D\u202E\u202E(Card A_0)
			{
				return A_0.Value2;
			}

			static SelectHandInteraction \u200C\u206F\u200E\u202D\u206B\u206B\u206D\u202C\u206E\u206C\u200D\u206F\u206A\u202D\u200E\u202D\u202B\u206B\u200E\u206A\u206D\u206E\u200E\u200C\u200F\u202C\u200C\u200F\u202D\u200F\u202B\u206A\u200C\u206D\u200C\u206A\u206B\u200D\u206C\u202E\u202E(int A_0, int A_1, IEnumerable<Card> A_2)
			{
				return new SelectHandInteraction(A_0, A_1, A_2);
			}

			private List<Card> allHand;
		}
	}
}
