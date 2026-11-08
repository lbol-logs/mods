using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BepInEx;
using BepInEx.Bootstrap;
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
	public sealed class FlandreMPEnfantTerribleDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-324657229);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMPEnfantTerribleDef.\u206C\u206D\u200F\u200E\u202A\u206E\u202C\u200F\u202E\u200C\u202E\u202E\u202A\u202B\u202C\u200F\u200D\u200B\u200C\u202A\u202D\u202A\u206A\u202A\u202B\u206F\u200F\u202B\u200D\u202B\u200D\u202D\u202C\u206A\u206C\u206D\u202B\u206E\u202A\u202D\u202E(BepinexPlugin.embeddedSource);
			FlandreMPEnfantTerribleDef.\u206F\u200C\u202B\u200B\u202C\u202D\u200F\u200B\u202A\u202D\u200D\u200E\u202A\u206B\u206B\u200C\u200F\u206D\u202B\u206D\u202A\u202D\u200E\u202E\u206F\u202C\u206E\u206E\u206D\u200D\u200F\u206E\u200F\u200D\u206F\u200E\u200F\u206B\u206A\u206B\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMPEnfantTerribleDef.\u202C\u206A\u206F\u200E\u200D\u200F\u202E\u200B\u202C\u200C\u202C\u206B\u200E\u200E\u202A\u202D\u202A\u206B\u200D\u206B\u206F\u206A\u200D\u200F\u200B\u200C\u202E\u200C\u202E\u202E\u206F\u200C\u206E\u206C\u202A\u200B\u200E\u200C\u206B\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreMPEnfantTerribleDef.\u200C\u206A\u202D\u206E\u200F\u200B\u200B\u202E\u202B\u202A\u200C\u202A\u206D\u206A\u206B\u200E\u202B\u206A\u206F\u202B\u202E\u202A\u206A\u206C\u200C\u200F\u202A\u200C\u200F\u200B\u206F\u200B\u206B\u200B\u200B\u202E\u200F\u200C\u206E\u202E\u202E(BepinexPlugin.sequenceTable, FlandreMPEnfantTerribleDef.\u200B\u202E\u200C\u206F\u202D\u202E\u200D\u200F\u206A\u202A\u206A\u206D\u200D\u202E\u206D\u206F\u206B\u202D\u202B\u202A\u206B\u200B\u202E\u200E\u200C\u206A\u206F\u206C\u202E\u200F\u206B\u206E\u206B\u200C\u200B\u200F\u206C\u202B\u206C\u200F\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2121621244);
			string text3 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1993380534);
			int num3 = 0;
			bool flag2 = false;
			bool flag3 = FlandreMPEnfantTerribleDef.\u206A\u206A\u206F\u202A\u202A\u200E\u202D\u206A\u200B\u206C\u206A\u200B\u206D\u206A\u202D\u206C\u200F\u206E\u202C\u206B\u206E\u202E\u206E\u200E\u202E\u200C\u206B\u200E\u200C\u206E\u202A\u206D\u206A\u206E\u202C\u206A\u202B\u200B\u206C\u206D\u202E().ContainsKey(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-806222643));
			bool flag4 = false;
			bool flag5 = FlandreMPEnfantTerribleDef.\u206A\u206A\u206F\u202A\u202A\u200E\u202D\u206A\u200B\u206C\u206A\u200B\u206D\u206A\u202D\u206C\u200F\u206E\u202C\u206B\u206E\u202E\u206E\u200E\u202E\u200C\u206B\u200E\u200C\u206E\u202A\u206D\u206A\u206E\u202C\u206A\u202B\u200B\u206C\u206D\u202E().ContainsKey(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1747019761));
			bool flag6 = true;
			Rarity rarity = Rarity.Uncommon;
			CardType cardType = CardType.Attack;
			TargetType? targetType = new TargetType?(TargetType.AllEnemies);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.Colorless);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 2,
				Colorless = 1
			};
			ManaGroup? manaGroup2 = null;
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = new int?(12);
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(2);
			int? num12 = null;
			int? num13 = new int?(40);
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
			if (!FlandreMPEnfantTerribleDef.\u206A\u206A\u206F\u202A\u202A\u200E\u202D\u206A\u200B\u206C\u206A\u200B\u206D\u206A\u202D\u206C\u200F\u206E\u202C\u206B\u206E\u202E\u206E\u200E\u202E\u200C\u206B\u200E\u200C\u206E\u202A\u206D\u206A\u206E\u202C\u206A\u202B\u200B\u206C\u206D\u202E().ContainsKey(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1770291014)))
			{
				(list2 = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871));
			}
			else
			{
				List<string> list3 = new List<string>();
				list3.Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-515953902));
				list2 = list3;
				list3.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			List<string> list4;
			if (!FlandreMPEnfantTerribleDef.\u206A\u206A\u206F\u202A\u202A\u200E\u202D\u206A\u200B\u206C\u206A\u200B\u206D\u206A\u202D\u206C\u200F\u206E\u202C\u206B\u206E\u202E\u206E\u200E\u202E\u200C\u206B\u200E\u200C\u206E\u202A\u206D\u206A\u206E\u202C\u206A\u202B\u200B\u206C\u206D\u202E().ContainsKey(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1770291014)))
			{
				(list4 = new List<string>()).Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			else
			{
				List<string> list5 = new List<string>();
				list5.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(501896159));
				list4 = list5;
				list5.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-222063899));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list4, new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1287122421), new List<string>());
		}

		static CardImages \u206C\u206D\u200F\u200E\u202A\u206E\u202C\u200F\u202E\u200C\u202E\u202E\u202A\u202B\u202C\u200F\u200D\u200B\u200C\u202A\u202D\u202A\u206A\u202A\u202B\u206F\u200F\u202B\u200D\u202B\u200D\u202D\u202C\u206A\u206C\u206D\u202B\u206E\u202A\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u200C\u202B\u200B\u202C\u202D\u200F\u200B\u202A\u202D\u200D\u200E\u202A\u206B\u206B\u200C\u200F\u206D\u202B\u206D\u202A\u202D\u200E\u202E\u206F\u202C\u206E\u206E\u206D\u200D\u200F\u206E\u200F\u200D\u206F\u200E\u200F\u206B\u206A\u206B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u206A\u206F\u200E\u200D\u200F\u202E\u200B\u202C\u200C\u202C\u206B\u200E\u200E\u202A\u202D\u202A\u206B\u200D\u206B\u206F\u206A\u200D\u200F\u200B\u200C\u202E\u200C\u202E\u202E\u206F\u200C\u206E\u206C\u202A\u200B\u200E\u200C\u206B\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202E\u200C\u206F\u202D\u202E\u200D\u200F\u206A\u202A\u206A\u206D\u200D\u202E\u206D\u206F\u206B\u202D\u202B\u202A\u206B\u200B\u202E\u200E\u200C\u206A\u206F\u206C\u202E\u200F\u206B\u206E\u206B\u200C\u200B\u200F\u206C\u202B\u206C\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u206A\u202D\u206E\u200F\u200B\u200B\u202E\u202B\u202A\u200C\u202A\u206D\u206A\u206B\u200E\u202B\u206A\u206F\u202B\u202E\u202A\u206A\u206C\u200C\u200F\u202A\u200C\u200F\u200B\u206F\u200B\u206B\u200B\u200B\u202E\u200F\u200C\u206E\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		static Dictionary<string, PluginInfo> \u206A\u206A\u206F\u202A\u202A\u200E\u202D\u206A\u200B\u206C\u206A\u200B\u206D\u206A\u202D\u206C\u200F\u206E\u202C\u206B\u206E\u202E\u206E\u200E\u202E\u200C\u206B\u200E\u200C\u206E\u202A\u206D\u206A\u206E\u202C\u206A\u202B\u200B\u206C\u206D\u202E()
		{
			return Chainloader.PluginInfos;
		}

		[EntityLogic(typeof(FlandreMPEnfantTerribleDef))]
		public sealed class FlandreMPEnfantTerrible : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.\u202C\u206E\u200C\u202B\u206A\u202C\u202A\u202C\u206B\u202A\u202A\u206E\u200E\u200B\u202C\u206F\u200C\u206A\u206C\u202D\u206A\u206D\u206B\u202B\u202C\u206D\u202D\u200E\u200B\u202C\u200C\u200C\u200D\u202B\u200B\u200E\u202E\u206F\u202C\u206F\u202E(this).GetValueOrDefault() * 4;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.\u202E\u202D\u202A\u202C\u206B\u206D\u206F\u206F\u206D\u200C\u200F\u200C\u202B\u206C\u206C\u202D\u202C\u206C\u202E\u206E\u200D\u200F\u202B\u200F\u200F\u202E\u206C\u206E\u200E\u202D\u200D\u206C\u206A\u202A\u200E\u202D\u200C\u206D\u202E\u200F\u202E((float)FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.\u202C\u206E\u200C\u202B\u206A\u202C\u202A\u202C\u206B\u202A\u202A\u206E\u200E\u200B\u202C\u206F\u200C\u206A\u206C\u202D\u206A\u206D\u206B\u202B\u202C\u206D\u202D\u200E\u200B\u202C\u200C\u200C\u200D\u202B\u200B\u200E\u202E\u206F\u202C\u206F\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(2 + FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.\u202C\u206E\u200C\u202B\u206A\u202C\u202A\u202C\u206B\u202A\u202A\u206E\u200E\u200B\u202C\u206F\u200C\u206A\u206C\u202D\u206A\u206D\u206B\u202B\u202C\u206D\u202D\u200E\u200B\u202C\u200C\u200C\u200D\u202B\u200B\u200E\u202E\u206F\u202C\u206F\u202E(this).GetValueOrDefault(), false);
				}
			}

			public int Value4
			{
				get
				{
					return 20;
				}
			}

			public int Value5
			{
				get
				{
					return 2;
				}
			}

			public int Value6
			{
				get
				{
					return 4;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsMultiplayer = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.<Actions>d__13 <Actions>d__ = new FlandreMPEnfantTerribleDef.FlandreMPEnfantTerrible.<Actions>d__13(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202C\u206E\u200C\u202B\u206A\u202C\u202A\u202C\u206B\u202A\u202A\u206E\u200E\u200B\u202C\u206F\u200C\u206A\u206C\u202D\u206A\u206D\u206B\u202B\u202C\u206D\u202D\u200E\u200B\u202C\u200C\u200C\u200D\u202B\u200B\u200E\u202E\u206F\u202C\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202E\u202D\u202A\u202C\u206B\u206D\u206F\u206F\u206D\u200C\u200F\u200C\u202B\u206C\u206C\u202D\u202C\u206C\u202E\u206E\u200D\u200F\u202B\u200F\u200F\u202E\u206C\u206E\u200E\u202D\u200D\u206C\u206A\u202A\u200E\u202D\u200C\u206D\u202E\u200F\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}
		}
	}
}
