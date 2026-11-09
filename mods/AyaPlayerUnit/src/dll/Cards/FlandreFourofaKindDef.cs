using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
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
	public sealed class FlandreFourofaKindDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-457338301);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFourofaKindDef.\u206F\u206F\u202C\u200D\u206E\u202E\u200F\u200D\u202D\u206D\u202C\u202D\u206A\u202B\u202C\u200B\u202E\u202A\u200C\u202C\u202C\u200D\u200F\u206D\u206B\u202C\u202D\u206A\u206A\u202B\u200E\u206F\u206C\u200E\u200F\u202C\u206C\u206B\u206D\u206E\u202E(BepinexPlugin.embeddedSource);
			FlandreFourofaKindDef.\u202E\u200C\u200D\u200F\u206E\u206D\u206C\u206E\u206D\u206A\u202D\u200F\u200B\u200F\u202D\u206B\u202C\u206D\u200C\u206A\u202E\u200D\u202C\u200F\u200B\u206C\u206D\u202C\u206D\u206A\u200C\u206E\u202A\u202A\u202E\u206C\u206F\u202E\u206B\u206A\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFourofaKindDef.\u206E\u206D\u202B\u202C\u200C\u206A\u200C\u200D\u206B\u200D\u200C\u206B\u202C\u202A\u206D\u200E\u200F\u202A\u202E\u200E\u200B\u200C\u202B\u206E\u206F\u206B\u206F\u206C\u206E\u202D\u206E\u200D\u206C\u200C\u202D\u206C\u200D\u200D\u200C\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFourofaKindDef.\u202B\u202C\u206F\u202E\u206F\u202D\u200E\u202D\u202B\u206A\u206C\u202D\u206B\u200B\u200F\u202A\u200B\u206B\u202A\u200C\u202B\u206A\u206A\u206B\u200C\u206D\u206F\u200E\u200B\u202B\u206B\u206D\u200C\u202D\u206D\u206C\u206C\u206F\u200C\u206D\u202E(BepinexPlugin.sequenceTable, FlandreFourofaKindDef.\u206C\u202C\u202C\u200F\u200E\u202C\u200B\u202E\u206D\u202E\u202C\u202E\u206B\u202A\u206B\u202B\u202B\u200B\u202A\u206F\u200D\u206B\u200D\u206F\u206C\u206C\u206B\u200B\u202B\u200C\u206F\u206F\u200E\u206F\u202D\u200D\u206F\u206D\u206B\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, true, true, false, true, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 4
			}, null, null, null, null, null, null, null, null, null, null, new int?(3), null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Replenish, Keyword.Exile | Keyword.Replenish, false, Keyword.TempMorph | Keyword.CopyHint, Keyword.TempMorph | Keyword.CopyHint, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(562649793), new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-170228231) });
		}

		static CardImages \u206F\u206F\u202C\u200D\u206E\u202E\u200F\u200D\u202D\u206D\u202C\u202D\u206A\u202B\u202C\u200B\u202E\u202A\u200C\u202C\u202C\u200D\u200F\u206D\u206B\u202C\u202D\u206A\u206A\u202B\u200E\u206F\u206C\u200E\u200F\u202C\u206C\u206B\u206D\u206E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u200C\u200D\u200F\u206E\u206D\u206C\u206E\u206D\u206A\u202D\u200F\u200B\u200F\u202D\u206B\u202C\u206D\u200C\u206A\u202E\u200D\u202C\u200F\u200B\u206C\u206D\u202C\u206D\u206A\u200C\u206E\u202A\u202A\u202E\u206C\u206F\u202E\u206B\u206A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u206D\u202B\u202C\u200C\u206A\u200C\u200D\u206B\u200D\u200C\u206B\u202C\u202A\u206D\u200E\u200F\u202A\u202E\u200E\u200B\u200C\u202B\u206E\u206F\u206B\u206F\u206C\u206E\u202D\u206E\u200D\u206C\u200C\u202D\u206C\u200D\u200D\u200C\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u202C\u202C\u200F\u200E\u202C\u200B\u202E\u206D\u202E\u202C\u202E\u206B\u202A\u206B\u202B\u202B\u200B\u202A\u206F\u200D\u206B\u200D\u206F\u206C\u206C\u206B\u200B\u202B\u200C\u206F\u206F\u200E\u206F\u202D\u200D\u206F\u206D\u206B\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u202C\u206F\u202E\u206F\u202D\u200E\u202D\u202B\u206A\u206C\u202D\u206B\u200B\u200F\u202A\u200B\u206B\u202A\u200C\u202B\u206A\u206A\u206B\u200C\u206D\u206F\u200E\u200B\u202B\u206B\u206D\u200C\u202D\u206D\u206C\u206C\u206F\u200C\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFourofaKindDef))]
		public sealed class FlandreFourofaKind : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreFourofaKindDef.FlandreFourofaKind.\u200C\u202C\u200D\u206F\u202C\u200B\u202C\u202A\u206D\u202E\u206B\u202A\u200C\u202E\u206C\u202D\u206A\u202A\u200E\u206D\u200E\u206A\u200F\u200C\u200F\u202A\u202A\u202E\u206F\u200C\u202A\u200B\u206C\u200E\u206A\u206D\u206B\u206D\u202C\u202E((float)FlandreFourofaKindDef.FlandreFourofaKind.\u202A\u202A\u206C\u206A\u200F\u206C\u206E\u200D\u200D\u200C\u206C\u206F\u206C\u206E\u206D\u202C\u206A\u202C\u206D\u206D\u206D\u206F\u206F\u202C\u200F\u200B\u206A\u200D\u206E\u200E\u206A\u206F\u202B\u206B\u206D\u206C\u202D\u206D\u202A\u202C\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int FlandreValue1
			{
				get
				{
					return base.FlandreModifier(base.BasicCardModify(FlandreFourofaKindDef.FlandreFourofaKind.\u202B\u200D\u200B\u206D\u202A\u206E\u206A\u206C\u200F\u200C\u200B\u200C\u206E\u202E\u206B\u206C\u200B\u200B\u206D\u200C\u206D\u200E\u202E\u200E\u206B\u202B\u200C\u202A\u202B\u206D\u202E\u202E\u206D\u200F\u206D\u206D\u200B\u200F\u206A\u202E\u202E(this) + this.AdditionalValue1 + FlandreFourofaKindDef.FlandreFourofaKind.\u200F\u206E\u202C\u200E\u200F\u200F\u202D\u202D\u202B\u200D\u206B\u206A\u206D\u206F\u202B\u206D\u206C\u206B\u200E\u202C\u200F\u202D\u206C\u202E\u202B\u200B\u200E\u206A\u206C\u206E\u202C\u206B\u200C\u206B\u200F\u200C\u206A\u206C\u206F\u206F\u202E(this), false), true);
				}
			}

			public override Interaction Precondition()
			{
				List<Card> list = FlandreFourofaKindDef.FlandreFourofaKind.\u202E\u202E\u200D\u200E\u200C\u202D\u200C\u200C\u202A\u202B\u200D\u202B\u206F\u200D\u200C\u206F\u200B\u206F\u206D\u200C\u200D\u200F\u206F\u206D\u206E\u206D\u206B\u206F\u206F\u202B\u206C\u200F\u206E\u206A\u206D\u200C\u200B\u206E\u202D\u200C\u202E(FlandreFourofaKindDef.FlandreFourofaKind.\u202D\u202A\u200C\u200E\u200C\u206C\u206F\u206A\u200D\u206C\u202E\u202C\u200C\u200B\u202A\u200C\u202E\u202A\u206F\u202D\u206D\u206F\u206C\u200E\u200F\u200D\u200D\u200F\u200E\u200E\u202C\u206A\u206A\u200B\u202B\u206A\u202B\u206B\u202B\u200D\u202E(this)).Where(delegate(Card c)
				{
					if (c != this)
					{
						for (;;)
						{
							int num4 = 777391278;
							switch (-(~(((-203879441 * -1105029801) ^ ~-80113618) - -(~-417408800) - num4) * 123583539) % 3)
							{
							case 1:
								goto IL_0045;
							case 2:
								continue;
							}
							break;
						}
						return false;
						IL_0045:
						return FlandreFourofaKindDef.FlandreFourofaKind.\u202C\u200C\u200B\u200C\u200E\u206A\u202A\u202B\u202C\u206E\u200F\u200D\u200D\u200C\u200D\u206A\u202B\u206A\u202D\u200B\u200F\u202C\u200E\u206C\u200B\u202A\u206B\u202E\u200F\u202C\u200F\u200F\u200B\u202D\u206D\u200D\u202D\u202A\u206E\u200F\u202E(c);
					}
					return false;
				}).ToList<Card>();
				for (;;)
				{
					IL_0022:
					int num = 1466887943;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num2 - -(-1658722407 - -1885763494 + (666639905 ^ 1336100725))))) % 4U)
						{
						case 0U:
							goto IL_0022;
						case 2U:
							num = (int)(((list.Count > 0) ? 2964978554U : 3872974300U) ^ (num3 * 1944595661U));
							continue;
						case 3U:
							goto IL_0080;
						}
						goto Block_1;
					}
				}
				Block_1:
				goto IL_0091;
				IL_0080:
				return null;
				IL_0091:
				return FlandreFourofaKindDef.FlandreFourofaKind.\u200D\u200F\u200D\u200C\u206C\u200B\u200D\u202A\u200F\u206A\u206C\u202C\u202E\u206A\u200F\u202B\u206A\u200B\u202A\u206A\u202E\u206F\u206D\u202C\u200E\u206F\u206D\u206C\u206D\u206C\u200C\u206B\u206D\u202A\u200E\u206A\u200F\u202E\u200F\u202D\u202E(1, 1, list);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFourofaKindDef.FlandreFourofaKind.<Actions>d__5 <Actions>d__ = new FlandreFourofaKindDef.FlandreFourofaKind.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202A\u202A\u206C\u206A\u200F\u206C\u206E\u200D\u200D\u200C\u206C\u206F\u206C\u206E\u206D\u202C\u206A\u202C\u206D\u206D\u206D\u206F\u206F\u202C\u200F\u200B\u206A\u200D\u206E\u200E\u206A\u206F\u202B\u206B\u206D\u206C\u202D\u206D\u202A\u202C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200C\u202C\u200D\u206F\u202C\u200B\u202C\u202A\u206D\u202E\u206B\u202A\u200C\u202E\u206C\u202D\u206A\u202A\u200E\u206D\u200E\u206A\u200F\u200C\u200F\u202A\u202A\u202E\u206F\u200C\u202A\u200B\u206C\u200E\u206A\u206D\u206B\u206D\u202C\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static int \u202B\u200D\u200B\u206D\u202A\u206E\u206A\u206C\u200F\u200C\u200B\u200C\u206E\u202E\u206B\u206C\u200B\u200B\u206D\u200C\u206D\u200E\u202E\u200E\u206B\u202B\u200C\u202A\u202B\u206D\u202E\u202E\u206D\u200F\u206D\u206D\u200B\u200F\u206A\u202E\u202E(Card A_0)
			{
				return A_0.ConfigValue1;
			}

			static int \u200F\u206E\u202C\u200E\u200F\u200F\u202D\u202D\u202B\u200D\u206B\u206A\u206D\u206F\u202B\u206D\u206C\u206B\u200E\u202C\u200F\u202D\u206C\u202E\u202B\u200B\u200E\u206A\u206C\u206E\u202C\u206B\u200C\u206B\u200F\u200C\u206A\u206C\u206F\u206F\u202E(Card A_0)
			{
				return A_0.DeltaValue1;
			}

			static BattleController \u202D\u202A\u200C\u200E\u200C\u206C\u206F\u206A\u200D\u206C\u202E\u202C\u200C\u200B\u202A\u200C\u202E\u202A\u206F\u202D\u206D\u206F\u206C\u200E\u200F\u200D\u200D\u200F\u200E\u200E\u202C\u206A\u206A\u200B\u202B\u206A\u202B\u206B\u202B\u200D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u202E\u202E\u200D\u200E\u200C\u202D\u200C\u200C\u202A\u202B\u200D\u202B\u206F\u200D\u200C\u206F\u200B\u206F\u206D\u200C\u200D\u200F\u206F\u206D\u206E\u206D\u206B\u206F\u206F\u202B\u206C\u200F\u206E\u206A\u206D\u200C\u200B\u206E\u202D\u200C\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static SelectHandInteraction \u200D\u200F\u200D\u200C\u206C\u200B\u200D\u202A\u200F\u206A\u206C\u202C\u202E\u206A\u200F\u202B\u206A\u200B\u202A\u206A\u202E\u206F\u206D\u202C\u200E\u206F\u206D\u206C\u206D\u206C\u200C\u206B\u206D\u202A\u200E\u206A\u200F\u202E\u200F\u202D\u202E(int A_0, int A_1, IEnumerable<Card> A_2)
			{
				return new SelectHandInteraction(A_0, A_1, A_2);
			}

			static bool \u202C\u200C\u200B\u200C\u200E\u206A\u202A\u202B\u202C\u206E\u200F\u200D\u200D\u200C\u200D\u206A\u202B\u206A\u202D\u200B\u200F\u202C\u200E\u206C\u200B\u202A\u206B\u202E\u200F\u202C\u200F\u200F\u200B\u202D\u206D\u200D\u202D\u202A\u206E\u200F\u202E(Card A_0)
			{
				return A_0.CanBeDuplicated;
			}
		}
	}
}
