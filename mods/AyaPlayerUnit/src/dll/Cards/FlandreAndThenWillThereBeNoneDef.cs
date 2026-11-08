using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreAndThenWillThereBeNoneDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-123708765);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreAndThenWillThereBeNoneDef.\u202C\u200D\u206B\u206D\u200B\u200D\u202E\u206C\u206E\u202C\u206F\u202A\u202D\u200F\u206A\u202A\u206B\u206F\u200B\u206D\u200C\u200B\u206F\u206A\u206C\u202B\u202E\u202A\u202E\u200D\u202D\u206D\u200E\u200C\u202B\u202B\u202B\u200B\u202C\u202A\u202E(BepinexPlugin.embeddedSource);
			FlandreAndThenWillThereBeNoneDef.\u200C\u206B\u200D\u200F\u200D\u200F\u206E\u200D\u206E\u200C\u202D\u202E\u202C\u206F\u200B\u206A\u206B\u206A\u206D\u200F\u206C\u200D\u206B\u206A\u206A\u202E\u206D\u200F\u200B\u200E\u200C\u206D\u206A\u200E\u206C\u200D\u200F\u200F\u200C\u206B\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreAndThenWillThereBeNoneDef.\u202D\u200E\u206A\u206A\u200F\u206F\u206B\u200E\u200B\u200C\u202C\u206B\u206A\u200F\u202A\u202D\u206B\u206A\u206D\u206E\u206A\u202C\u200F\u206E\u202E\u206E\u202A\u206E\u200E\u206A\u202A\u206D\u202A\u200E\u200C\u200E\u202E\u206D\u202B\u206D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreAndThenWillThereBeNoneDef.\u200D\u206D\u200B\u202E\u202C\u202B\u200E\u206C\u200C\u206C\u202C\u200C\u202D\u200F\u200C\u200C\u202E\u202A\u200C\u202C\u200C\u202E\u202D\u200E\u200D\u200D\u202B\u200B\u202E\u206D\u200D\u206C\u200C\u202D\u200E\u202A\u202D\u206F\u202E\u206E\u202E(BepinexPlugin.sequenceTable, FlandreAndThenWillThereBeNoneDef.\u202B\u200B\u200F\u206D\u200D\u202A\u202B\u200F\u200E\u206F\u206B\u202B\u202B\u200D\u202A\u206A\u200D\u202C\u206A\u206E\u206D\u202B\u200B\u202E\u200B\u200B\u200D\u206E\u202A\u206B\u202C\u200C\u206C\u200D\u200B\u200F\u200E\u206A\u200D\u200F\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2105991427);
			string text3 = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000);
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
			list.Add(ManaColor.Blue);
			list.Add(ManaColor.Black);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 2,
				Hybrid = 2,
				HybridColor = 4
			};
			ManaGroup? manaGroup2 = null;
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = new int?(30);
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(2);
			int? num12 = null;
			int? num13 = new int?(1);
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
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list2 = new List<string>()).Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-200313178));
			}
			else
			{
				List<string> list3 = new List<string>();
				list3.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1958891809));
				list2 = list3;
				list3.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			List<string> list4;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list4 = new List<string>()).Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(98082179));
			}
			else
			{
				List<string> list5 = new List<string>();
				list5.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-200313178));
				list4 = list5;
				list5.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list4, new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(957422351), new List<string>());
		}

		static CardImages \u202C\u200D\u206B\u206D\u200B\u200D\u202E\u206C\u206E\u202C\u206F\u202A\u202D\u200F\u206A\u202A\u206B\u206F\u200B\u206D\u200C\u200B\u206F\u206A\u206C\u202B\u202E\u202A\u202E\u200D\u202D\u206D\u200E\u200C\u202B\u202B\u202B\u200B\u202C\u202A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u206B\u200D\u200F\u200D\u200F\u206E\u200D\u206E\u200C\u202D\u202E\u202C\u206F\u200B\u206A\u206B\u206A\u206D\u200F\u206C\u200D\u206B\u206A\u206A\u202E\u206D\u200F\u200B\u200E\u200C\u206D\u206A\u200E\u206C\u200D\u200F\u200F\u200C\u206B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u200E\u206A\u206A\u200F\u206F\u206B\u200E\u200B\u200C\u202C\u206B\u206A\u200F\u202A\u202D\u206B\u206A\u206D\u206E\u206A\u202C\u200F\u206E\u202E\u206E\u202A\u206E\u200E\u206A\u202A\u206D\u202A\u200E\u200C\u200E\u202E\u206D\u202B\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u200B\u200F\u206D\u200D\u202A\u202B\u200F\u200E\u206F\u206B\u202B\u202B\u200D\u202A\u206A\u200D\u202C\u206A\u206E\u206D\u202B\u200B\u202E\u200B\u200B\u200D\u206E\u202A\u206B\u202C\u200C\u206C\u200D\u200B\u200F\u200E\u206A\u200D\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206D\u200B\u202E\u202C\u202B\u200E\u206C\u200C\u206C\u202C\u200C\u202D\u200F\u200C\u200C\u202E\u202A\u200C\u202C\u200C\u202E\u202D\u200E\u200D\u200D\u202B\u200B\u202E\u206D\u200D\u206C\u200C\u202D\u200E\u202A\u202D\u206F\u202E\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreAndThenWillThereBeNoneDef))]
		public sealed class FlandreAndThenWillThereBeNone : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206E\u200F\u206D\u202B\u206D\u202E\u206D\u200D\u202B\u202E\u206E\u200F\u202C\u202D\u206A\u202D\u206C\u200B\u202E\u202D\u202C\u202B\u202A\u206B\u202E\u200F\u200F\u202B\u202B\u200F\u200E\u202A\u206E\u200F\u206B\u202B\u202C\u202C\u202A\u206A\u202E(this).GetValueOrDefault() * 10;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u202A\u202D\u206A\u206C\u200D\u206B\u200B\u202C\u202E\u206B\u200F\u206A\u200F\u206E\u206D\u202B\u206E\u206C\u206E\u200C\u202D\u202E\u202C\u202D\u206D\u200E\u206A\u200E\u206B\u206D\u200C\u202E\u202C\u202E\u202C\u200D\u200D\u200B\u202A\u200E\u202E((float)FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206E\u200F\u206D\u202B\u206D\u202E\u206D\u200D\u202B\u202E\u206E\u200F\u202C\u202D\u206A\u202D\u206C\u200B\u202E\u202D\u202C\u202B\u202A\u206B\u202E\u200F\u200F\u202B\u202B\u200F\u200E\u202A\u206E\u200F\u206B\u202B\u202C\u202C\u202A\u206A\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(4 + FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206E\u200F\u206D\u202B\u206D\u202E\u206D\u200D\u202B\u202E\u206E\u200F\u202C\u202D\u206A\u202D\u206C\u200B\u202E\u202D\u202C\u202B\u202A\u206B\u202E\u200F\u200F\u202B\u202B\u200F\u200E\u202A\u206E\u200F\u206B\u202B\u202C\u202C\u202A\u206A\u202E(this).GetValueOrDefault() * 2, false);
				}
			}

			public int Value4
			{
				get
				{
					return base.FlandreModifier(2 + FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u200B\u206E\u200D\u200D\u202E\u206D\u206F\u206E\u200D\u206A\u200F\u206D\u206B\u206C\u206F\u200C\u202D\u206A\u200C\u200F\u202A\u206D\u200D\u202C\u202D\u202C\u206D\u206B\u206C\u206B\u200D\u206F\u206C\u206E\u206C\u206B\u200F\u200E\u206E\u206B\u202E((float)FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206E\u200F\u206D\u202B\u206D\u202E\u206D\u200D\u202B\u202E\u206E\u200F\u202C\u202D\u206A\u202D\u206C\u200B\u202E\u202D\u202C\u202B\u202A\u206B\u202E\u200F\u200F\u202B\u202B\u200F\u200E\u202A\u206E\u200F\u206B\u202B\u202C\u202C\u202A\u206A\u202E(this).GetValueOrDefault() / 2f), false);
				}
			}

			public int Value5
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
					if (FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u200C\u206B\u202D\u202D\u200F\u206A\u200E\u200B\u200F\u202C\u206F\u206B\u202E\u200F\u202A\u202B\u202D\u202B\u202A\u202E\u206A\u200F\u206E\u200E\u202D\u200E\u200E\u200B\u206E\u206E\u200B\u200D\u206B\u200F\u206D\u202A\u206A\u200F\u206E\u202B\u202E(this) != null)
					{
						for (;;)
						{
							int num = -916531964;
							switch ((-((num ^ (-(~205653829) + -271692897 * (799862252 + -2055070251))) + -292401452) + -42401625) % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_004D;
							}
							break;
						}
						return true;
						IL_004D:
						return !FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206B\u202B\u206C\u202B\u200B\u200C\u200D\u206E\u202A\u206E\u206A\u200E\u206A\u206B\u200C\u200E\u202B\u202D\u202D\u206E\u206A\u206E\u200C\u206C\u202C\u206A\u200D\u202D\u200D\u206B\u200F\u200C\u206F\u200B\u206F\u202C\u206E\u202D\u200E\u206C\u202E(FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u200C\u206B\u202D\u202D\u200F\u206A\u200E\u200B\u200F\u202C\u206F\u206B\u202E\u200F\u202A\u202B\u202D\u202B\u202A\u202E\u206A\u200F\u206E\u200E\u202D\u200E\u200E\u200B\u206E\u206E\u200B\u200D\u206B\u200F\u206D\u202A\u206A\u200F\u206E\u202B\u202E(this)).Any((Card c) => c is FlandreArmageddonDef.FlandreArmageddon);
					}
					return true;
				}
			}

			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1578089449), true, true);
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
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1021007085), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_000C;
				}
				goto IL_0055;
				int num2;
				for (;;)
				{
					IL_0011:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(-num) ^ --863758162 ^ -77872809)) % 9U)
					{
					case 0U:
						goto IL_006E;
					case 1U:
						goto IL_00CC;
					case 3U:
						num2 = (int)(((!this.IsActive) ? 567287795U : 564917111U) ^ (num3 * 281373552U));
						continue;
					case 4U:
						goto IL_000C;
					case 5U:
						goto IL_00DD;
					case 6U:
						goto IL_0055;
					case 7U:
						num2 = (int)(((!FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u202E\u206F\u202A\u206D\u200F\u202D\u202C\u200D\u202C\u202B\u206F\u206B\u206B\u200F\u206B\u200E\u206E\u202D\u206E\u206A\u200E\u206F\u202B\u206E\u202A\u200C\u206E\u200B\u202A\u206D\u202C\u206A\u200C\u206C\u206D\u200B\u206C\u200E\u206C\u200D\u202E(this)) ? 1074656853U : 941927297U) ^ (num3 * 52735410U));
						continue;
					case 8U:
						goto IL_00EE;
					}
					break;
				}
				goto IL_0107;
				IL_006E:
				return this.PhantasmModeDescription;
				IL_00CC:
				return base.GetExtraDescription1;
				IL_00DD:
				return this.PhantasmModeUpgradedDescription;
				IL_00EE:
				return base.GetBaseDescription();
				IL_0107:
				return this.PhantasmModeExtraDescription1;
				IL_000C:
				num2 = -1559705484;
				goto IL_0011;
				IL_0055:
				num2 = ((!this.IsActive) ? (-13067960) : (-279420510));
				goto IL_0011;
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -746837789;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)((-1929691917 ^ 1958959353 ^ ~1775158433) - (num2 - -1108460522 * -1938912435)))) % 4U)
						{
						case 0U:
							base.OfferingCount = FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u206C\u202A\u206C\u202E\u202A\u200F\u200B\u202A\u202B\u202D\u200E\u206F\u200D\u202D\u202C\u200E\u206C\u206F\u202B\u206B\u206D\u200B\u200E\u206A\u200F\u200D\u200F\u200B\u202A\u206B\u200C\u202E\u206F\u202D\u206A\u200C\u200E\u206D\u202A\u200F\u202E(this);
							num = (int)((num3 * 3657073641U) ^ 774484069U);
							continue;
						case 1U:
							base.IsOffering = true;
							num = (int)((num3 * 2431054680U) ^ 1752668758U);
							continue;
						case 2U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.<Actions>d__21 <Actions>d__ = new FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.<Actions>d__21(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206E\u200F\u206D\u202B\u206D\u202E\u206D\u200D\u202B\u202E\u206E\u200F\u202C\u202D\u206A\u202D\u206C\u200B\u202E\u202D\u202C\u202B\u202A\u206B\u202E\u200F\u200F\u202B\u202B\u200F\u200E\u202A\u206E\u200F\u206B\u202B\u202C\u202C\u202A\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202A\u202D\u206A\u206C\u200D\u206B\u200B\u202C\u202E\u206B\u200F\u206A\u200F\u206E\u206D\u202B\u206E\u206C\u206E\u200C\u202D\u202E\u202C\u202D\u206D\u200E\u206A\u200E\u206B\u206D\u200C\u202E\u202C\u202E\u202C\u200D\u200D\u200B\u202A\u200E\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			static int \u200B\u206E\u200D\u200D\u202E\u206D\u206F\u206E\u200D\u206A\u200F\u206D\u206B\u206C\u206F\u200C\u202D\u206A\u200C\u200F\u202A\u206D\u200D\u202C\u202D\u202C\u206D\u206B\u206C\u206B\u200D\u206F\u206C\u206E\u206C\u206B\u200F\u200E\u206E\u206B\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static BattleController \u200C\u206B\u202D\u202D\u200F\u206A\u200E\u200B\u200F\u202C\u206F\u206B\u202E\u200F\u202A\u202B\u202D\u202B\u202A\u202E\u206A\u200F\u206E\u200E\u202D\u200E\u200E\u200B\u206E\u206E\u200B\u200D\u206B\u200F\u206D\u202A\u206A\u200F\u206E\u202B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206B\u202B\u206C\u202B\u200B\u200C\u200D\u206E\u202A\u206E\u206A\u200E\u206A\u206B\u200C\u200E\u202B\u202D\u202D\u206E\u206A\u206E\u200C\u206C\u202C\u206A\u200D\u202D\u200D\u206B\u200F\u200C\u206F\u200B\u206F\u202C\u206E\u202D\u200E\u206C\u202E(BattleController A_0)
			{
				return A_0.BattleCardUsageHistory;
			}

			static bool \u202E\u206F\u202A\u206D\u200F\u202D\u202C\u200D\u202C\u202B\u206F\u206B\u206B\u200F\u206B\u200E\u206E\u202D\u206E\u206A\u200E\u206F\u202B\u206E\u202A\u200C\u206E\u200B\u202A\u206D\u202C\u206A\u200C\u206C\u206D\u200B\u206C\u200E\u206C\u200D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static int \u206C\u202A\u206C\u202E\u202A\u200F\u200B\u202A\u202B\u202D\u200E\u206F\u200D\u202D\u202C\u200E\u206C\u206F\u202B\u206B\u206D\u200B\u200E\u206A\u200F\u200D\u200F\u200B\u202A\u206B\u200C\u202E\u206F\u202D\u206A\u200C\u200E\u206D\u202A\u200F\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameObject \u202D\u200C\u202D\u206A\u206F\u206C\u206C\u206B\u202D\u202C\u202B\u206B\u202D\u202E\u200D\u202E\u206A\u206E\u206A\u202E\u206B\u202B\u200B\u206C\u206C\u202B\u200C\u206C\u206D\u200D\u206B\u200B\u200D\u202A\u206F\u200B\u200D\u206E\u206E\u206E\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			private static GameObject background = FlandreAndThenWillThereBeNoneDef.FlandreAndThenWillThereBeNone.\u202D\u200C\u202D\u206A\u206F\u206C\u206C\u206B\u202D\u202C\u202B\u206B\u202D\u202E\u200D\u202E\u206A\u206E\u206A\u202E\u206B\u202B\u200B\u206C\u206C\u202B\u200C\u206C\u206D\u200D\u206B\u200B\u200D\u202A\u206F\u200B\u200D\u206E\u206E\u206E\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2014257334), null);
		}
	}
}
