using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreArmageddonDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-870191185);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreArmageddonDef.\u206F\u202C\u202E\u202C\u200F\u200B\u200B\u202B\u202B\u202D\u202A\u200F\u200C\u200C\u200B\u206F\u202B\u202D\u200F\u206D\u202E\u200C\u202D\u206F\u200D\u200E\u206C\u206C\u206B\u206C\u202A\u206D\u206F\u206F\u206A\u206C\u206F\u200C\u206D\u202E(BepinexPlugin.embeddedSource);
			FlandreArmageddonDef.\u206F\u206D\u202D\u200F\u206A\u206C\u206F\u202C\u206F\u202A\u206D\u206B\u202C\u206F\u202D\u206D\u206C\u200E\u200F\u206A\u206C\u206D\u200E\u206B\u202B\u206E\u200B\u202C\u202D\u202E\u206F\u200E\u206F\u202A\u206B\u206C\u200D\u202D\u202C\u202A\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreArmageddonDef.\u202E\u206F\u200C\u202A\u200E\u202B\u202A\u200D\u200E\u206E\u206C\u206F\u200C\u200D\u202E\u202A\u206C\u200F\u200B\u206C\u206E\u202A\u200F\u202D\u200F\u202E\u206F\u206B\u206C\u200B\u202B\u200F\u206A\u206F\u200D\u200F\u206F\u206D\u200B\u206B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreArmageddonDef.\u206C\u202B\u206B\u206C\u202B\u206E\u206C\u202C\u206E\u200F\u200D\u206C\u202B\u200F\u200C\u200D\u200C\u202C\u202D\u200B\u202A\u200C\u202E\u206A\u202B\u206F\u206F\u200C\u202C\u206C\u206D\u202A\u202E\u202E\u206E\u200F\u200C\u206F\u200B\u202A\u202E(BepinexPlugin.sequenceTable, FlandreArmageddonDef.\u202B\u206E\u206E\u200C\u206E\u200F\u206C\u202A\u206E\u206A\u202E\u206E\u200D\u200B\u200B\u202E\u206B\u202B\u200C\u206C\u202C\u206F\u206C\u200E\u202D\u200E\u206F\u206F\u200B\u202A\u206C\u200C\u200B\u206C\u206D\u200C\u200B\u206D\u202E\u202A\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-397494503);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346);
			int num3 = 0;
			bool flag2 = true;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = true;
			Rarity rarity = Rarity.Rare;
			CardType cardType = CardType.Attack;
			TargetType? targetType = new TargetType?(TargetType.AllEnemies);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.White);
			list.Add(ManaColor.Black);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 4,
				Hybrid = 1,
				HybridColor = 1
			};
			ManaGroup? manaGroup2 = null;
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = new int?(60);
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(6);
			int? num12 = null;
			int? num13 = new int?(6);
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
			Keyword keyword = Keyword.Accuracy | Keyword.Exile;
			Keyword keyword2 = Keyword.Accuracy | Keyword.Exile;
			bool flag8 = false;
			Keyword keyword3 = Keyword.Battlefield;
			Keyword keyword4 = Keyword.Battlefield;
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
				(list3 = new List<string>()).Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-203703834));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list3, new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1219971131), new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1039830360) });
		}

		static CardImages \u206F\u202C\u202E\u202C\u200F\u200B\u200B\u202B\u202B\u202D\u202A\u200F\u200C\u200C\u200B\u206F\u202B\u202D\u200F\u206D\u202E\u200C\u202D\u206F\u200D\u200E\u206C\u206C\u206B\u206C\u202A\u206D\u206F\u206F\u206A\u206C\u206F\u200C\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u206D\u202D\u200F\u206A\u206C\u206F\u202C\u206F\u202A\u206D\u206B\u202C\u206F\u202D\u206D\u206C\u200E\u200F\u206A\u206C\u206D\u200E\u206B\u202B\u206E\u200B\u202C\u202D\u202E\u206F\u200E\u206F\u202A\u206B\u206C\u200D\u202D\u202C\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202E\u206F\u200C\u202A\u200E\u202B\u202A\u200D\u200E\u206E\u206C\u206F\u200C\u200D\u202E\u202A\u206C\u200F\u200B\u206C\u206E\u202A\u200F\u202D\u200F\u202E\u206F\u206B\u206C\u200B\u202B\u200F\u206A\u206F\u200D\u200F\u206F\u206D\u200B\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u206E\u206E\u200C\u206E\u200F\u206C\u202A\u206E\u206A\u202E\u206E\u200D\u200B\u200B\u202E\u206B\u202B\u200C\u206C\u202C\u206F\u206C\u200E\u202D\u200E\u206F\u206F\u200B\u202A\u206C\u200C\u200B\u206C\u206D\u200C\u200B\u206D\u202E\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u202B\u206B\u206C\u202B\u206E\u206C\u202C\u206E\u200F\u200D\u206C\u202B\u200F\u200C\u200D\u200C\u202C\u202D\u200B\u202A\u200C\u202E\u206A\u202B\u206F\u206F\u200C\u202C\u206C\u206D\u202A\u202E\u202E\u206E\u200F\u200C\u206F\u200B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreArmageddonDef))]
		public sealed class FlandreArmageddon : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					int num = FlandreArmageddonDef.FlandreArmageddon.\u206C\u206D\u206E\u206A\u202A\u206A\u206A\u206D\u202C\u202E\u202C\u206F\u200E\u206F\u206C\u202B\u206F\u202B\u200F\u200C\u206C\u202A\u206D\u206A\u202E\u206E\u200B\u206E\u202B\u202B\u206A\u200E\u206B\u200E\u202D\u206A\u206E\u202D\u200F\u202C\u202E(this).GetValueOrDefault() * 20;
					BattleController battleController = FlandreArmageddonDef.FlandreArmageddon.\u200F\u206A\u202C\u206B\u200F\u200B\u206B\u202B\u206E\u200D\u206C\u202B\u202C\u200E\u206D\u200D\u202D\u200D\u200F\u206B\u202A\u202D\u200E\u202E\u206F\u206A\u206D\u206A\u202A\u202A\u206E\u200F\u202B\u200B\u200F\u206E\u206F\u202C\u206C\u206B\u202E(this);
					int? num2;
					if (battleController == null)
					{
						num2 = null;
					}
					else
					{
						num2 = new int?(FlandreArmageddonDef.FlandreArmageddon.\u202E\u200D\u202A\u200F\u202B\u206B\u200F\u206F\u206D\u200D\u202C\u206F\u200D\u202B\u200F\u202C\u200B\u206A\u200F\u206A\u200B\u206D\u206C\u202C\u206F\u200D\u206D\u206B\u206F\u206C\u206E\u202C\u200E\u200B\u206F\u206A\u200F\u200C\u202D\u202E\u202E(battleController).Count((Card c) => FlandreArmageddonDef.FlandreArmageddon.<>c.\u202A\u200F\u200D\u202B\u206E\u202C\u206C\u202E\u200B\u202D\u200D\u206D\u202E\u202A\u200E\u206C\u200E\u206E\u200D\u200B\u202D\u206B\u200E\u200C\u200E\u200D\u200E\u200F\u202B\u200D\u206F\u202C\u200F\u202A\u202C\u202D\u200C\u206E\u206E\u206E\u202E(c) == CardType.Attack));
					}
					return num + (num2 * this.FlandreValue2).GetValueOrDefault();
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreArmageddonDef.FlandreArmageddon.\u206C\u206D\u206E\u206A\u202A\u206A\u206A\u206D\u202C\u202E\u202C\u206F\u200E\u206F\u206C\u202B\u206F\u202B\u200F\u200C\u206C\u202A\u206D\u206A\u202E\u206E\u200B\u206E\u202B\u202B\u206A\u200E\u206B\u200E\u202D\u206A\u206E\u202D\u200F\u202C\u202E(this).GetValueOrDefault() * 2;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreArmageddonDef.FlandreArmageddon.\u206C\u206D\u206E\u206A\u202A\u206A\u206A\u206D\u202C\u202E\u202C\u206F\u200E\u206F\u206C\u202B\u206F\u202B\u200F\u200C\u206C\u202A\u206D\u206A\u202E\u206E\u200B\u206E\u202B\u202B\u206A\u200E\u206B\u200E\u202D\u206A\u206E\u202D\u200F\u202C\u202E(this).GetValueOrDefault() * 2;
				}
			}

			public int Value3
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
					if (FlandreArmageddonDef.FlandreArmageddon.\u200F\u206A\u202C\u206B\u200F\u200B\u206B\u202B\u206E\u200D\u206C\u202B\u202C\u200E\u206D\u200D\u202D\u200D\u200F\u206B\u202A\u202D\u200E\u202E\u206F\u206A\u206D\u206A\u202A\u202A\u206E\u200F\u202B\u200B\u200F\u206E\u206F\u202C\u206C\u206B\u202E(this) != null)
					{
						for (;;)
						{
							int num = 1367469301;
							switch (~(((num - (-1612339945 - -94655656 + -46075610 - -2028176117)) ^ -104620979) + (1726179552 - 1375828398)) % 3)
							{
							case 1:
								goto IL_0054;
							case 2:
								continue;
							}
							break;
						}
						return true;
						IL_0054:
						return !FlandreArmageddonDef.FlandreArmageddon.\u200E\u200F\u202A\u206D\u202C\u202E\u206F\u206F\u200F\u200D\u206C\u206F\u206F\u206A\u206C\u202B\u206E\u200F\u200B\u202D\u206D\u200F\u202B\u202A\u200D\u202A\u200F\u206E\u202A\u206E\u206C\u200E\u202E\u202C\u200F\u202D\u206B\u206C\u202E\u200E\u202E(FlandreArmageddonDef.FlandreArmageddon.\u200F\u206A\u202C\u206B\u200F\u200B\u206B\u202B\u206E\u200D\u206C\u202B\u202C\u200E\u206D\u200D\u202D\u200D\u200F\u206B\u202A\u202D\u200E\u202E\u206F\u206A\u206D\u206A\u202A\u202A\u206E\u200F\u202B\u200B\u200F\u206E\u206F\u202C\u206C\u206B\u202E(this)).Any((Card c) => c is FlandreArmageddonDef.FlandreArmageddon);
					}
					return true;
				}
			}

			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1803702677), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(128824052), true, true);
				}
			}

			private string PhantasmModeExtraDescription1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1600407511), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_000F;
				}
				goto IL_00E8;
				int num2;
				for (;;)
				{
					IL_0014:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((num ^ ((71229927 ^ (148843945 * -420843485)) + -846790168)) - ((-82983063 ^ -1285480199) - 209633710))) % 9U)
					{
					case 0U:
						goto IL_000F;
					case 1U:
						goto IL_0089;
					case 2U:
						num2 = (int)(((!this.IsActive) ? 2450871498U : 1306045759U) ^ (num3 * 3356863061U));
						continue;
					case 3U:
						goto IL_00E8;
					case 4U:
						goto IL_00A2;
					case 5U:
						goto IL_0073;
					case 7U:
						num2 = (int)((FlandreArmageddonDef.FlandreArmageddon.\u206A\u202E\u200F\u206C\u200D\u206C\u202D\u200E\u200F\u206F\u206A\u202A\u206B\u200C\u200C\u202D\u202A\u206C\u206D\u200E\u202B\u206C\u206D\u202C\u206A\u200B\u202A\u200E\u206F\u202B\u200D\u206F\u202B\u202A\u200D\u200D\u206D\u200E\u202D\u206D\u202E(this) ? 11094378U : 595066841U) ^ (num3 * 1534424615U));
						continue;
					case 8U:
						goto IL_00B3;
					}
					break;
				}
				goto IL_0128;
				IL_0073:
				return this.PhantasmModeDescription;
				IL_0089:
				return base.GetBaseDescription();
				IL_00A2:
				return this.PhantasmModeUpgradedDescription;
				IL_00B3:
				return base.GetExtraDescription1;
				IL_0128:
				return this.PhantasmModeExtraDescription1;
				IL_000F:
				num2 = -1805952555;
				goto IL_0014;
				IL_00E8:
				num2 = (this.IsActive ? 1209086548 : (-1412666951));
				goto IL_0014;
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsMagicalGirl = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreArmageddonDef.FlandreArmageddon.<Actions>d__19 <Actions>d__ = new FlandreArmageddonDef.FlandreArmageddon.<Actions>d__19(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u206C\u206D\u206E\u206A\u202A\u206A\u206A\u206D\u202C\u202E\u202C\u206F\u200E\u206F\u206C\u202B\u206F\u202B\u200F\u200C\u206C\u202A\u206D\u206A\u202E\u206E\u200B\u206E\u202B\u202B\u206A\u200E\u206B\u200E\u202D\u206A\u206E\u202D\u200F\u202C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u200F\u206A\u202C\u206B\u200F\u200B\u206B\u202B\u206E\u200D\u206C\u202B\u202C\u200E\u206D\u200D\u202D\u200D\u200F\u206B\u202A\u202D\u200E\u202E\u206F\u206A\u206D\u206A\u202A\u202A\u206E\u200F\u202B\u200B\u200F\u206E\u206F\u202C\u206C\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Card> \u202E\u200D\u202A\u200F\u202B\u206B\u200F\u206F\u206D\u200D\u202C\u206F\u200D\u202B\u200F\u202C\u200B\u206A\u200F\u206A\u200B\u206D\u206C\u202C\u206F\u200D\u206D\u206B\u206F\u206C\u206E\u202C\u200E\u200B\u206F\u206A\u200F\u200C\u202D\u202E\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static IReadOnlyList<Card> \u200E\u200F\u202A\u206D\u202C\u202E\u206F\u206F\u200F\u200D\u206C\u206F\u206F\u206A\u206C\u202B\u206E\u200F\u200B\u202D\u206D\u200F\u202B\u202A\u200D\u202A\u200F\u206E\u202A\u206E\u206C\u200E\u202E\u202C\u200F\u202D\u206B\u206C\u202E\u200E\u202E(BattleController A_0)
			{
				return A_0.BattleCardUsageHistory;
			}

			static bool \u206A\u202E\u200F\u206C\u200D\u206C\u202D\u200E\u200F\u206F\u206A\u202A\u206B\u200C\u200C\u202D\u202A\u206C\u206D\u200E\u202B\u206C\u206D\u202C\u206A\u200B\u202A\u200E\u206F\u202B\u200D\u206F\u202B\u202A\u200D\u200D\u206D\u200E\u202D\u206D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static GameObject \u202D\u206E\u202E\u202B\u202A\u202B\u200B\u202D\u200F\u202D\u202A\u202A\u206E\u200C\u200D\u202B\u206D\u206A\u202A\u202D\u206C\u200E\u200D\u206D\u202D\u200F\u200E\u202A\u202A\u200B\u200F\u206F\u202E\u200C\u200E\u200B\u206A\u202B\u200D\u200D\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			private static GameObject Background = FlandreArmageddonDef.FlandreArmageddon.\u202D\u206E\u202E\u202B\u202A\u202B\u200B\u202D\u200F\u202D\u202A\u202A\u206E\u200C\u200D\u202B\u206D\u206A\u202A\u202D\u206C\u200E\u200D\u206D\u202D\u200F\u200E\u202A\u202A\u200B\u200F\u206F\u202E\u200C\u200E\u200B\u206A\u202B\u200D\u200D\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-684868218), null);
		}
	}
}
