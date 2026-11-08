using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreForbiddenGamesDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(118877690);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreForbiddenGamesDef.\u202D\u200E\u202B\u202B\u200D\u200D\u206A\u202B\u202D\u202B\u202E\u206A\u202C\u202E\u206A\u206C\u206A\u206C\u206C\u200F\u206E\u202C\u202C\u202C\u206C\u206A\u202E\u200B\u206C\u206F\u200E\u202D\u202E\u206D\u200F\u206F\u202E\u202D\u202C\u202E\u202E(BepinexPlugin.embeddedSource);
			FlandreForbiddenGamesDef.\u202C\u202E\u200B\u206E\u206A\u200E\u206B\u202A\u206C\u202C\u206E\u200E\u200F\u206F\u202C\u202B\u200B\u200D\u206B\u202C\u206F\u202B\u206D\u206A\u206E\u200C\u206A\u206E\u202D\u200E\u200B\u202A\u202D\u202B\u202C\u206D\u206F\u206B\u202A\u202C\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreForbiddenGamesDef.\u200F\u202C\u206E\u200F\u200B\u206B\u206A\u202D\u206D\u206C\u202B\u206F\u200F\u200E\u206F\u206E\u200C\u202D\u202C\u206D\u202D\u200B\u200B\u200C\u200F\u206C\u200B\u206C\u202B\u202B\u200C\u206B\u202D\u202D\u206F\u206E\u200C\u200F\u206C\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreForbiddenGamesDef.\u200B\u202D\u202B\u206E\u202E\u200B\u206C\u200F\u202E\u200F\u206C\u206B\u202A\u206E\u206C\u206C\u202A\u206E\u200B\u202B\u206B\u206F\u202A\u200C\u206F\u200E\u200C\u202D\u200D\u206D\u200F\u206C\u202B\u202C\u206B\u200B\u202E\u206C\u202E\u202B\u202E(BepinexPlugin.sequenceTable, FlandreForbiddenGamesDef.\u200F\u206A\u202D\u202A\u206F\u206E\u206B\u206A\u206C\u202C\u200F\u206B\u206A\u200B\u202C\u200B\u202B\u200B\u200C\u206A\u202B\u200E\u206E\u202D\u206D\u202B\u202A\u200C\u202C\u202E\u202E\u200C\u200C\u200B\u200C\u200E\u202A\u202E\u200B\u202D\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
			int num3 = 0;
			bool flag2 = true;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = true;
			Rarity rarity = Rarity.Rare;
			CardType cardType = CardType.Skill;
			TargetType? targetType = new TargetType?(TargetType.Self);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.Black);
			list.Add(ManaColor.Red);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 7
			};
			ManaGroup? manaGroup2 = null;
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = null;
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(2);
			int? num12 = null;
			int? num13 = new int?(80);
			int? num14 = null;
			ManaGroup? manaGroup5 = null;
			ManaGroup? manaGroup6 = null;
			int? num15 = null;
			int? num16 = null;
			int? num17 = null;
			int? num18 = null;
			int? num19 = null;
			int? num20 = null;
			int? num21 = null;
			int? num22 = null;
			int? num23 = null;
			int? num24 = null;
			int? num25 = null;
			int? num26 = null;
			int? num27 = null;
			Keyword keyword = Keyword.Exile;
			Keyword keyword2 = Keyword.Exile;
			bool flag8 = false;
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list2 = new List<string>();
			}
			else
			{
				(list2 = new List<string>()).Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(437004320));
			}
			List<string> list3;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list3 = new List<string>();
			}
			else
			{
				(list3 = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list3, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1399364902), new List<string>());
		}

		static CardImages \u202D\u200E\u202B\u202B\u200D\u200D\u206A\u202B\u202D\u202B\u202E\u206A\u202C\u202E\u206A\u206C\u206A\u206C\u206C\u200F\u206E\u202C\u202C\u202C\u206C\u206A\u202E\u200B\u206C\u206F\u200E\u202D\u202E\u206D\u200F\u206F\u202E\u202D\u202C\u202E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202C\u202E\u200B\u206E\u206A\u200E\u206B\u202A\u206C\u202C\u206E\u200E\u200F\u206F\u202C\u202B\u200B\u200D\u206B\u202C\u206F\u202B\u206D\u206A\u206E\u200C\u206A\u206E\u202D\u200E\u200B\u202A\u202D\u202B\u202C\u206D\u206F\u206B\u202A\u202C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u202C\u206E\u200F\u200B\u206B\u206A\u202D\u206D\u206C\u202B\u206F\u200F\u200E\u206F\u206E\u200C\u202D\u202C\u206D\u202D\u200B\u200B\u200C\u200F\u206C\u200B\u206C\u202B\u202B\u200C\u206B\u202D\u202D\u206F\u206E\u200C\u200F\u206C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u206A\u202D\u202A\u206F\u206E\u206B\u206A\u206C\u202C\u200F\u206B\u206A\u200B\u202C\u200B\u202B\u200B\u200C\u206A\u202B\u200E\u206E\u202D\u206D\u202B\u202A\u200C\u202C\u202E\u202E\u200C\u200C\u200B\u200C\u200E\u202A\u202E\u200B\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200B\u202D\u202B\u206E\u202E\u200B\u206C\u200F\u202E\u200F\u206C\u206B\u202A\u206E\u206C\u206C\u202A\u206E\u200B\u202B\u206B\u206F\u202A\u200C\u206F\u200E\u200C\u202D\u200D\u206D\u200F\u206C\u202B\u202C\u206B\u200B\u202E\u206C\u202E\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreForbiddenGamesDef))]
		public sealed class FlandreForbiddenGames : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreForbiddenGamesDef.FlandreForbiddenGames.\u202C\u202C\u202C\u200D\u202D\u206D\u202C\u202B\u202E\u206A\u206F\u200C\u200B\u200F\u206A\u200B\u206E\u200F\u200C\u206C\u202E\u202E\u200E\u206F\u202D\u206D\u202D\u200C\u206A\u206A\u200F\u206C\u200F\u200C\u202B\u202C\u206D\u206A\u202A\u200C\u202E(this).GetValueOrDefault() * 40;
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(1 + FlandreForbiddenGamesDef.FlandreForbiddenGames.\u202A\u200C\u206C\u200E\u206C\u206D\u200B\u200C\u202D\u200F\u202D\u200C\u200F\u206B\u206C\u200E\u206C\u206D\u200D\u200F\u202B\u206C\u202B\u206C\u206A\u202D\u206B\u200B\u206B\u206F\u206F\u202E\u202C\u202D\u200B\u200F\u206C\u200C\u200C\u202E((float)FlandreForbiddenGamesDef.FlandreForbiddenGames.\u202C\u202C\u202C\u200D\u202D\u206D\u202C\u202B\u202E\u206A\u206F\u200C\u200B\u200F\u206A\u200B\u206E\u200F\u200C\u206C\u202E\u202E\u200E\u206F\u202D\u206D\u202D\u200C\u206A\u206A\u200F\u206C\u200F\u200C\u202B\u202C\u206D\u206A\u202A\u200C\u202E(this).GetValueOrDefault() / 2f), false);
				}
			}

			public int Value4
			{
				get
				{
					return 8;
				}
			}

			public override bool IsActive
			{
				get
				{
					if (FlandreForbiddenGamesDef.FlandreForbiddenGames.\u206A\u206F\u200C\u206F\u202E\u206C\u206A\u206D\u200F\u206B\u206D\u206A\u206C\u202C\u200F\u206B\u200C\u200F\u200B\u200C\u206A\u200B\u206B\u202C\u202D\u200C\u202A\u200C\u206E\u206F\u206D\u202C\u200F\u206F\u206B\u202E\u206F\u202E\u206E\u202B\u202E(this) != null)
					{
						for (;;)
						{
							int num = -1733316756;
							switch (((num - -464670181 * (642515585 - -1436762181 * 1717306194)) ^ (-1081701763 + ~902560595)) % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_004C;
							}
							break;
						}
						return true;
						IL_004C:
						return !FlandreForbiddenGamesDef.FlandreForbiddenGames.\u202D\u200B\u206B\u206B\u200B\u202B\u200C\u206E\u206B\u202A\u200E\u206B\u202E\u206D\u202B\u200D\u202B\u206E\u202D\u200F\u200B\u202E\u202B\u206B\u202C\u200C\u202E\u200F\u206C\u200E\u202A\u206F\u202C\u202A\u206D\u200D\u206B\u202B\u200C\u202C\u202E(FlandreForbiddenGamesDef.FlandreForbiddenGames.\u206A\u206F\u200C\u206F\u202E\u206C\u206A\u206D\u200F\u206B\u206D\u206A\u206C\u202C\u200F\u206B\u200C\u200F\u200B\u200C\u206A\u200B\u206B\u202C\u202D\u200C\u202A\u200C\u206E\u206F\u206D\u202C\u200F\u206F\u206B\u202E\u206F\u202E\u206E\u202B\u202E(this)).Any((Card c) => c is FlandreForbiddenGamesDef.FlandreForbiddenGames);
					}
					return true;
				}
			}

			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2003061620), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-166193966), true, true);
				}
			}

			private string PhantasmModeExtraDescription1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(497455390), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_000F;
				}
				goto IL_00C2;
				int num2;
				for (;;)
				{
					IL_0014:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(1056544736 - ((num - ~(2000721953 - 1230127810 + 768990274) - -509513145) ^ (2102165676 + 348372292)))) % 9U)
					{
					case 0U:
						goto IL_00DE;
					case 2U:
						goto IL_00B1;
					case 3U:
						num2 = (int)(((!this.IsActive) ? 4093645815U : 513933068U) ^ (num3 * 597462168U));
						continue;
					case 4U:
						goto IL_00C2;
					case 5U:
						goto IL_0098;
					case 6U:
						goto IL_011B;
					case 7U:
						goto IL_000F;
					case 8U:
						num2 = (int)(((!FlandreForbiddenGamesDef.FlandreForbiddenGames.\u206A\u202B\u206F\u206C\u202E\u200E\u202E\u206D\u202D\u206A\u202D\u206C\u200C\u206F\u200C\u202E\u202E\u206A\u200F\u206F\u206D\u202B\u206B\u206B\u202E\u206C\u200C\u206B\u200B\u202E\u202A\u200F\u200F\u206E\u206F\u202A\u200D\u200F\u206A\u200D\u202E(this)) ? 4273267511U : 737947153U) ^ (num3 * 874459313U));
						continue;
					}
					break;
				}
				goto IL_012C;
				IL_0098:
				return this.PhantasmModeDescription;
				IL_00B1:
				return this.PhantasmModeUpgradedDescription;
				IL_00DE:
				return base.GetBaseDescription();
				IL_011B:
				return base.GetExtraDescription1;
				IL_012C:
				return this.PhantasmModeExtraDescription1;
				IL_000F:
				num2 = -864821850;
				goto IL_0014;
				IL_00C2:
				num2 = ((!this.IsActive) ? 377710245 : (-934258097));
				goto IL_0014;
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -1441877940;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-649108395 * -1411243675 - -558056801 * 80974902 - (num2 ^ ~(~(1845580617 + -1299117288))))) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.IsOffering = true;
							num = (int)((num3 * 755898377U) ^ 515762416U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.OfferingCount = FlandreForbiddenGamesDef.FlandreForbiddenGames.\u206B\u202A\u206D\u206B\u202B\u200F\u206B\u200C\u202D\u206A\u202B\u202A\u206D\u206A\u202C\u202D\u202C\u206F\u206F\u202A\u200C\u202D\u206B\u202D\u200F\u202D\u202C\u202A\u202C\u200C\u202E\u202C\u200D\u202C\u206E\u202C\u206A\u206C\u202E\u202B\u202E(this);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreForbiddenGamesDef.FlandreForbiddenGames.<Actions>d__16 <Actions>d__ = new FlandreForbiddenGamesDef.FlandreForbiddenGames.<Actions>d__16(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202C\u202C\u202C\u200D\u202D\u206D\u202C\u202B\u202E\u206A\u206F\u200C\u200B\u200F\u206A\u200B\u206E\u200F\u200C\u206C\u202E\u202E\u200E\u206F\u202D\u206D\u202D\u200C\u206A\u206A\u200F\u206C\u200F\u200C\u202B\u202C\u206D\u206A\u202A\u200C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202A\u200C\u206C\u200E\u206C\u206D\u200B\u200C\u202D\u200F\u202D\u200C\u200F\u206B\u206C\u200E\u206C\u206D\u200D\u200F\u202B\u206C\u202B\u206C\u206A\u202D\u206B\u200B\u206B\u206F\u206F\u202E\u202C\u202D\u200B\u200F\u206C\u200C\u200C\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			static BattleController \u206A\u206F\u200C\u206F\u202E\u206C\u206A\u206D\u200F\u206B\u206D\u206A\u206C\u202C\u200F\u206B\u200C\u200F\u200B\u200C\u206A\u200B\u206B\u202C\u202D\u200C\u202A\u200C\u206E\u206F\u206D\u202C\u200F\u206F\u206B\u202E\u206F\u202E\u206E\u202B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u202D\u200B\u206B\u206B\u200B\u202B\u200C\u206E\u206B\u202A\u200E\u206B\u202E\u206D\u202B\u200D\u202B\u206E\u202D\u200F\u200B\u202E\u202B\u206B\u202C\u200C\u202E\u200F\u206C\u200E\u202A\u206F\u202C\u202A\u206D\u200D\u206B\u202B\u200C\u202C\u202E(BattleController A_0)
			{
				return A_0.BattleCardUsageHistory;
			}

			static bool \u206A\u202B\u206F\u206C\u202E\u200E\u202E\u206D\u202D\u206A\u202D\u206C\u200C\u206F\u200C\u202E\u202E\u206A\u200F\u206F\u206D\u202B\u206B\u206B\u202E\u206C\u200C\u206B\u200B\u202E\u202A\u200F\u200F\u206E\u206F\u202A\u200D\u200F\u206A\u200D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static int \u206B\u202A\u206D\u206B\u202B\u200F\u206B\u200C\u202D\u206A\u202B\u202A\u206D\u206A\u202C\u202D\u202C\u206F\u206F\u202A\u200C\u202D\u206B\u202D\u200F\u202D\u202C\u202A\u202C\u200C\u202E\u202C\u200D\u202C\u206E\u202C\u206A\u206C\u202E\u202B\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
