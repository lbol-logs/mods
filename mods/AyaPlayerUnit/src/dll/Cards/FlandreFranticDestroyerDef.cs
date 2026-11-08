using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
	public sealed class FlandreFranticDestroyerDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(469474957);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFranticDestroyerDef.\u200C\u202A\u200B\u200E\u200F\u202C\u200F\u200C\u200C\u200E\u202B\u206E\u200D\u202E\u200C\u206E\u202B\u202A\u200D\u202B\u202B\u200E\u206D\u200B\u200E\u202A\u202C\u206C\u200E\u202B\u200B\u202B\u200D\u206F\u206A\u200F\u206C\u206C\u206C\u202D\u202E(BepinexPlugin.embeddedSource);
			FlandreFranticDestroyerDef.\u200D\u202A\u202A\u206D\u200E\u206A\u200B\u202C\u202A\u206E\u200F\u200C\u206D\u206D\u206A\u202E\u202B\u200D\u202B\u202C\u206D\u206C\u202C\u200E\u202E\u206F\u200D\u206D\u206C\u200B\u200B\u206F\u206E\u200E\u202B\u200B\u202B\u202D\u200D\u206A\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFranticDestroyerDef.\u200C\u202C\u200C\u206B\u200C\u202B\u202A\u206E\u206C\u206C\u200C\u202B\u206A\u202D\u202C\u200D\u206A\u202A\u206E\u200B\u206B\u200B\u206B\u200C\u206E\u202A\u202C\u200C\u206D\u202A\u202C\u206A\u202E\u202C\u200D\u206C\u200C\u202A\u200B\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreFranticDestroyerDef.\u202E\u202C\u200E\u206D\u206C\u200F\u200F\u200C\u200C\u200E\u200F\u200E\u200E\u202A\u200D\u200F\u202C\u206E\u206D\u200C\u200D\u202D\u206C\u202E\u202A\u206A\u206F\u202E\u206C\u206C\u202A\u206F\u206D\u200E\u202D\u206C\u206A\u200D\u202B\u206B\u202E(BepinexPlugin.sequenceTable, FlandreFranticDestroyerDef.\u200B\u202E\u200C\u202A\u202E\u206B\u206A\u206E\u202A\u200E\u202C\u200E\u200C\u206D\u202A\u202A\u206A\u206D\u206B\u202B\u200E\u202E\u202D\u206D\u206A\u206C\u200D\u202B\u202D\u202B\u202B\u206C\u206B\u202C\u200E\u202C\u202C\u206F\u206D\u206F\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			string text3 = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
			int num3 = 0;
			bool flag2 = true;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = true;
			bool flag6 = true;
			Rarity rarity = Rarity.Rare;
			CardType cardType = CardType.Ability;
			TargetType? targetType = new TargetType?(TargetType.Self);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.Black);
			list.Add(ManaColor.Red);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				Black = 2,
				Red = 2
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				Black = 2,
				Red = 2
			});
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = null;
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(3);
			int? num12 = null;
			int? num13 = new int?(1);
			int? num14 = null;
			ManaGroup? manaGroup5 = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
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
			Keyword keyword = Keyword.None;
			Keyword keyword2 = Keyword.None;
			bool flag8 = false;
			Keyword keyword3 = Keyword.Philosophy;
			Keyword keyword4 = Keyword.Philosophy;
			List<string> list2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list2 = new List<string>();
			}
			else
			{
				(list2 = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871));
			}
			List<string> list3;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list3 = new List<string>();
			}
			else
			{
				(list3 = new List<string>()).Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list3, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2056874393), new List<string>());
		}

		static CardImages \u200C\u202A\u200B\u200E\u200F\u202C\u200F\u200C\u200C\u200E\u202B\u206E\u200D\u202E\u200C\u206E\u202B\u202A\u200D\u202B\u202B\u200E\u206D\u200B\u200E\u202A\u202C\u206C\u200E\u202B\u200B\u202B\u200D\u206F\u206A\u200F\u206C\u206C\u206C\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u202A\u202A\u206D\u200E\u206A\u200B\u202C\u202A\u206E\u200F\u200C\u206D\u206D\u206A\u202E\u202B\u200D\u202B\u202C\u206D\u206C\u202C\u200E\u202E\u206F\u200D\u206D\u206C\u200B\u200B\u206F\u206E\u200E\u202B\u200B\u202B\u202D\u200D\u206A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200C\u202C\u200C\u206B\u200C\u202B\u202A\u206E\u206C\u206C\u200C\u202B\u206A\u202D\u202C\u200D\u206A\u202A\u206E\u200B\u206B\u200B\u206B\u200C\u206E\u202A\u202C\u200C\u206D\u202A\u202C\u206A\u202E\u202C\u200D\u206C\u200C\u202A\u200B\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202E\u200C\u202A\u202E\u206B\u206A\u206E\u202A\u200E\u202C\u200E\u200C\u206D\u202A\u202A\u206A\u206D\u206B\u202B\u200E\u202E\u202D\u206D\u206A\u206C\u200D\u202B\u202D\u202B\u202B\u206C\u206B\u202C\u200E\u202C\u202C\u206F\u206D\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u202C\u200E\u206D\u206C\u200F\u200F\u200C\u200C\u200E\u200F\u200E\u200E\u202A\u200D\u200F\u202C\u206E\u206D\u200C\u200D\u202D\u206C\u202E\u202A\u206A\u206F\u202E\u206C\u206C\u202A\u206F\u206D\u200E\u202D\u206C\u206A\u200D\u202B\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFranticDestroyerDef))]
		public sealed class FlandreFranticDestroyer : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202C\u202B\u206B\u200C\u206D\u206B\u202E\u200C\u206E\u200E\u206B\u200C\u202B\u206F\u202B\u206F\u200F\u206B\u200D\u200F\u200F\u200F\u206F\u202D\u206C\u202D\u202A\u206E\u206B\u202D\u206B\u200E\u200B\u200F\u200C\u206F\u202A\u200F\u206F\u202C\u202E((float)FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206B\u200D\u202D\u200F\u200C\u200E\u206B\u206F\u206A\u206D\u202E\u206A\u200F\u206D\u206B\u200C\u202B\u200C\u202C\u202B\u202D\u202A\u206D\u202C\u200E\u200F\u200F\u202E\u200F\u206E\u200D\u206E\u202E\u202D\u202C\u202E\u202E\u200B\u200F\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202C\u202B\u206B\u200C\u206D\u206B\u202E\u200C\u206E\u200E\u206B\u200C\u202B\u206F\u202B\u206F\u200F\u206B\u200D\u200F\u200F\u200F\u206F\u202D\u206C\u202D\u202A\u206E\u206B\u202D\u206B\u200E\u200B\u200F\u200C\u206F\u202A\u200F\u206F\u202C\u202E((float)FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206B\u200D\u202D\u200F\u200C\u200E\u206B\u206F\u206A\u206D\u202E\u206A\u200F\u206D\u206B\u200C\u202B\u200C\u202C\u202B\u202D\u202A\u206D\u202C\u200E\u200F\u200F\u202E\u200F\u206E\u200D\u206E\u202E\u202D\u202C\u202E\u202E\u200B\u200F\u202E(this).GetValueOrDefault() / 2f)
					};
				}
			}

			public override ManaGroup FlandreMana
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					if (FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206E\u202A\u206F\u200B\u206D\u206F\u200C\u202C\u200F\u200C\u206A\u206A\u206D\u200F\u202E\u206E\u200B\u200F\u202E\u202D\u202C\u200D\u200B\u202E\u206A\u206A\u200D\u206B\u200B\u206C\u200D\u200B\u200E\u200F\u200C\u206B\u200B\u202D\u202D\u202C\u202E(this))
					{
						goto IL_0008;
					}
					ManaGroup? manaGroup = FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u200C\u200F\u206B\u200E\u202D\u200B\u206E\u206D\u202A\u206F\u206E\u206F\u202B\u206E\u202B\u202C\u200E\u200C\u206C\u206F\u202D\u206D\u200E\u206D\u202E\u202C\u206A\u202C\u206D\u206D\u206B\u202D\u200D\u200E\u202C\u202B\u200F\u206E\u206F\u202C\u202E(FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202E\u206B\u206D\u200D\u206C\u206F\u202C\u206D\u202B\u206F\u200F\u200F\u206A\u206F\u202C\u202D\u200E\u202B\u202E\u202C\u202D\u202B\u200C\u202D\u200E\u200F\u202C\u200F\u206B\u200E\u200B\u200D\u202E\u202A\u206B\u206B\u202B\u206C\u206E\u206F\u202E(this));
					goto IL_0091;
					int num2;
					ManaGroup? manaGroup2;
					ManaGroup? manaGroup3;
					for (;;)
					{
						IL_000D:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num ^ (~(--1230572043) ^ (-1813287363 - 915119525 + 471243600))))) % 6U)
						{
						case 1U:
							goto IL_0076;
						case 2U:
							num2 = (int)(((manaGroup2 != null) ? 372686066U : 1845226560U) ^ (num3 * 2401388509U));
							continue;
						case 3U:
							manaGroup3 = FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206D\u200E\u202B\u206A\u200F\u206D\u200D\u206E\u200C\u206F\u202C\u206D\u200D\u200E\u202D\u200D\u206F\u206C\u206B\u200E\u200E\u206F\u202A\u206D\u206C\u202D\u200B\u206F\u200C\u206B\u200B\u202B\u200C\u206D\u200F\u206E\u202D\u202C\u202A\u206B\u202E(FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202E\u206B\u206D\u200D\u206C\u206F\u202C\u206D\u202B\u206F\u200F\u200F\u206A\u206F\u202C\u202D\u200E\u202B\u202E\u202C\u202D\u202B\u200C\u202D\u200E\u200F\u202C\u200F\u206B\u200E\u200B\u200D\u202E\u202A\u206B\u206B\u202B\u206C\u206E\u206F\u202E(this));
							if (manaGroup3 == null)
							{
								num2 = (int)((num3 * 180928750U) ^ 3298627609U);
								continue;
							}
							goto IL_0083;
						case 4U:
							goto IL_00C4;
						case 5U:
							goto IL_0008;
						}
						break;
					}
					goto IL_0100;
					IL_0076:
					manaGroup = FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u200C\u200F\u206B\u200E\u202D\u200B\u206E\u206D\u202A\u206F\u206E\u206F\u202B\u206E\u202B\u202C\u200E\u200C\u206C\u206F\u202D\u206D\u200E\u206D\u202E\u202C\u206A\u202C\u206D\u206D\u206B\u202D\u200D\u200E\u202C\u202B\u200F\u206E\u206F\u202C\u202E(FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202E\u206B\u206D\u200D\u206C\u206F\u202C\u206D\u202B\u206F\u200F\u200F\u206A\u206F\u202C\u202D\u200E\u202B\u202E\u202C\u202D\u202B\u200C\u202D\u200E\u200F\u202C\u200F\u206B\u200E\u200B\u200D\u202E\u202A\u206B\u206B\u202B\u206C\u206E\u206F\u202E(this));
					goto IL_0091;
					IL_0083:
					manaGroup = manaGroup3;
					goto IL_0091;
					IL_00C4:
					throw FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202B\u202A\u202E\u202A\u206F\u206E\u200F\u200F\u202B\u200E\u202A\u206A\u202C\u200F\u200D\u200D\u202B\u200E\u206F\u200E\u206E\u202E\u202B\u200C\u202C\u202A\u200E\u202A\u200C\u200B\u202A\u200F\u200F\u202D\u202B\u202A\u200D\u206E\u202B\u200D\u202E(FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u200C\u202C\u200C\u202A\u200C\u200D\u202D\u202B\u200E\u206A\u200D\u202B\u202A\u200C\u206A\u206E\u202A\u200D\u202B\u202C\u202E\u206F\u202A\u206C\u202B\u200C\u200E\u200E\u202C\u206B\u202C\u206D\u200B\u200C\u202C\u200D\u206D\u200F\u200F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-836156365), FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u200E\u206C\u200F\u206D\u206E\u202B\u200D\u200C\u206B\u206F\u206E\u200F\u200F\u206E\u206B\u206E\u200B\u200E\u206E\u202B\u202A\u200C\u206B\u202B\u200D\u206A\u206C\u206F\u206E\u206D\u202B\u200C\u202A\u206C\u206C\u206A\u206E\u206D\u206C\u202A\u202E(this), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-325437937)));
					IL_0100:
					ManaGroup manaGroup4 = manaGroup2.GetValueOrDefault() + this.AdditionalMana;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0195:
							int num4 = ((!FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206A\u206E\u206C\u206B\u206B\u200E\u200E\u202B\u200B\u202E\u202E\u200B\u206F\u202A\u206E\u206F\u206F\u206E\u202E\u202C\u202D\u200C\u202D\u202B\u206A\u200F\u200E\u200B\u206B\u206B\u206D\u200B\u206C\u200F\u206B\u202D\u206A\u200B\u202A\u206D\u202E(enumerator)) ? 1192531481 : 1446760565);
							for (;;)
							{
								int num = num4;
								uint num3;
								switch ((num3 = (uint)(-(uint)(num ^ (~(--1230572043) ^ (-1813287363 - 915119525 + 471243600))))) % 6U)
								{
								case 0U:
								{
									ManaColor manaColor;
									num4 = (int)(((manaGroup4.GetValue(manaColor) > 0) ? 338939807U : 1834436010U) ^ (num3 * 4149190360U));
									continue;
								}
								case 2U:
									goto IL_0195;
								case 3U:
								{
									ManaColor manaColor = enumerator.Current;
									num4 = 1471957400;
									continue;
								}
								case 4U:
									num4 = 1446760565;
									continue;
								case 5U:
								{
									ManaColor manaColor;
									manaGroup4.SetValue(manaColor, base.FlandreModifier(manaGroup4.GetValue(manaColor), false));
									num4 = (int)((num3 * 284894790U) ^ 3719154532U);
									continue;
								}
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_01F4:
								int num5 = 1614541047;
								for (;;)
								{
									int num = num5;
									uint num3;
									switch ((num3 = (uint)(-(uint)(num ^ (~(--1230572043) ^ (-1813287363 - 915119525 + 471243600))))) % 3U)
									{
									case 0U:
										goto IL_01F4;
									case 2U:
										FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u202D\u206F\u200F\u206A\u206E\u202B\u200C\u202B\u200E\u206D\u206D\u206F\u200E\u202D\u202D\u200D\u200C\u202A\u206C\u202D\u200F\u206A\u200F\u206A\u202B\u206D\u200D\u206F\u200D\u206C\u206B\u206B\u206D\u200B\u206B\u206F\u206E\u206B\u206B\u202B\u202E(enumerator);
										num5 = (int)((num3 * 779463714U) ^ 3814250239U);
										continue;
									}
									goto Block_10;
								}
							}
							Block_10:;
						}
					}
					return manaGroup4;
					IL_0008:
					num2 = 487876927;
					goto IL_000D;
					IL_0091:
					manaGroup2 = manaGroup;
					num2 = 908654596;
					goto IL_000D;
				}
			}

			public int Value3
			{
				get
				{
					return 12;
				}
			}

			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-766890246), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(671930366), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0067;
				}
				IL_000C:
				int num = 1077365398;
				IL_0011:
				int num2 = num;
				switch ((((num2 * 1005588347 - ~(1750371730 * -1298316449)) * -1109056663) ^ -1213930226) % 5)
				{
				case 0:
					goto IL_000C;
				case 1:
					return this.PhantasmModeDescription;
				case 2:
					IL_0067:
					num = ((!FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206E\u202A\u206F\u200B\u206D\u206F\u200C\u202C\u200F\u200C\u206A\u206A\u206D\u200F\u202E\u206E\u200B\u200F\u202E\u202D\u202C\u200D\u200B\u202E\u206A\u206A\u200D\u206B\u200B\u206C\u200D\u200B\u200E\u200F\u200C\u206B\u200B\u202D\u202D\u202C\u202E(this)) ? (-1793079535) : 1588837783);
					goto IL_0011;
				case 4:
					return base.GetBaseDescription();
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsOffering = true;
				base.OfferingCount = FlandreFranticDestroyerDef.FlandreFranticDestroyer.\u206F\u202D\u206F\u202E\u202D\u206A\u202C\u206B\u202D\u206D\u206A\u200D\u206A\u200D\u200E\u206F\u202C\u200C\u202E\u206D\u206E\u200D\u200F\u202A\u206A\u202D\u200C\u200B\u202E\u200F\u206F\u206D\u206C\u200F\u206E\u200C\u206D\u206A\u206B\u202B\u202E(this);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFranticDestroyerDef.FlandreFranticDestroyer.<Actions>d__14 <Actions>d__ = new FlandreFranticDestroyerDef.FlandreFranticDestroyer.<Actions>d__14(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206B\u200D\u202D\u200F\u200C\u200E\u206B\u206F\u206A\u206D\u202E\u206A\u200F\u206D\u206B\u200C\u202B\u200C\u202C\u202B\u202D\u202A\u206D\u202C\u200E\u200F\u200F\u202E\u200F\u206E\u200D\u206E\u202E\u202D\u202C\u202E\u202E\u200B\u200F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202C\u202B\u206B\u200C\u206D\u206B\u202E\u200C\u206E\u200E\u206B\u200C\u202B\u206F\u202B\u206F\u200F\u206B\u200D\u200F\u200F\u200F\u206F\u202D\u206C\u202D\u202A\u206E\u206B\u202D\u206B\u200E\u200B\u200F\u200C\u206F\u202A\u200F\u206F\u202C\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206E\u202A\u206F\u200B\u206D\u206F\u200C\u202C\u200F\u200C\u206A\u206A\u206D\u200F\u202E\u206E\u200B\u200F\u202E\u202D\u202C\u200D\u200B\u202E\u206A\u206A\u200D\u206B\u200B\u206C\u200D\u200B\u200E\u200F\u200C\u206B\u200B\u202D\u202D\u202C\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static CardConfig \u202E\u206B\u206D\u200D\u206C\u206F\u202C\u206D\u202B\u206F\u200F\u200F\u206A\u206F\u202C\u202D\u200E\u202B\u202E\u202C\u202D\u202B\u200C\u202D\u200E\u200F\u202C\u200F\u206B\u200E\u200B\u200D\u202E\u202A\u206B\u206B\u202B\u206C\u206E\u206F\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static ManaGroup? \u206D\u200E\u202B\u206A\u200F\u206D\u200D\u206E\u200C\u206F\u202C\u206D\u200D\u200E\u202D\u200D\u206F\u206C\u206B\u200E\u200E\u206F\u202A\u206D\u206C\u202D\u200B\u206F\u200C\u206B\u200B\u202B\u200C\u206D\u200F\u206E\u202D\u202C\u202A\u206B\u202E(CardConfig A_0)
			{
				return A_0.UpgradedMana;
			}

			static ManaGroup? \u200C\u200F\u206B\u200E\u202D\u200B\u206E\u206D\u202A\u206F\u206E\u206F\u202B\u206E\u202B\u202C\u200E\u200C\u206C\u206F\u202D\u206D\u200E\u206D\u202E\u202C\u206A\u202C\u206D\u206D\u206B\u202D\u200D\u200E\u202C\u202B\u200F\u206E\u206F\u202C\u202E(CardConfig A_0)
			{
				return A_0.Mana;
			}

			static string \u200E\u206C\u200F\u206D\u206E\u202B\u200D\u200C\u206B\u206F\u206E\u200F\u200F\u206E\u206B\u206E\u200B\u200E\u206E\u202B\u202A\u200C\u206B\u202B\u200D\u206A\u206C\u206F\u206E\u206D\u202B\u200C\u202A\u206C\u206C\u206A\u206E\u206D\u206C\u202A\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static string \u200C\u202C\u200C\u202A\u200C\u200D\u202D\u202B\u200E\u206A\u200D\u202B\u202A\u200C\u206A\u206E\u202A\u200D\u202B\u202C\u202E\u206F\u202A\u206C\u202B\u200C\u200E\u200E\u202C\u206B\u202C\u206D\u200B\u200C\u202C\u200D\u206D\u200F\u200F\u202E(string A_0, string A_1, string A_2)
			{
				return A_0 + A_1 + A_2;
			}

			static InvalidDataException \u202B\u202A\u202E\u202A\u206F\u206E\u200F\u200F\u202B\u200E\u202A\u206A\u202C\u200F\u200D\u200D\u202B\u200E\u206F\u200E\u206E\u202E\u202B\u200C\u202C\u202A\u200E\u202A\u200C\u200B\u202A\u200F\u200F\u202D\u202B\u202A\u200D\u206E\u202B\u200D\u202E(string A_0)
			{
				return new InvalidDataException(A_0);
			}

			static bool \u206A\u206E\u206C\u206B\u206B\u200E\u200E\u202B\u200B\u202E\u202E\u200B\u206F\u202A\u206E\u206F\u206F\u206E\u202E\u202C\u202D\u200C\u202D\u202B\u206A\u200F\u200E\u200B\u206B\u206B\u206D\u200B\u206C\u200F\u206B\u202D\u206A\u200B\u202A\u206D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202D\u206F\u200F\u206A\u206E\u202B\u200C\u202B\u200E\u206D\u206D\u206F\u200E\u202D\u202D\u200D\u200C\u202A\u206C\u202D\u200F\u206A\u200F\u206A\u202B\u206D\u200D\u206F\u200D\u206C\u206B\u206B\u206D\u200B\u206B\u206F\u206E\u206B\u206B\u202B\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static int \u206F\u202D\u206F\u202E\u202D\u206A\u202C\u206B\u202D\u206D\u206A\u200D\u206A\u200D\u200E\u206F\u202C\u200C\u202E\u206D\u206E\u200D\u200F\u202A\u206A\u202D\u200C\u200B\u202E\u200F\u206F\u206D\u206C\u200F\u206E\u200C\u206D\u206A\u206B\u202B\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
