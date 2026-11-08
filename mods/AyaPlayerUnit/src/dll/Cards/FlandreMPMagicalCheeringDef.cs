using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.Stages;
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
	public sealed class FlandreMPMagicalCheeringDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1838336919);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMPMagicalCheeringDef.\u206B\u206B\u200C\u206B\u206C\u200D\u206D\u200C\u200C\u202D\u200C\u200D\u200E\u200B\u200D\u202C\u200E\u206F\u200E\u206D\u200C\u206E\u200F\u200B\u206C\u202E\u200D\u206A\u206E\u200E\u206B\u200E\u206E\u202B\u202B\u202E\u200C\u206B\u206F\u206D\u202E(BepinexPlugin.embeddedSource);
			FlandreMPMagicalCheeringDef.\u202B\u200D\u200C\u206D\u206B\u202A\u206B\u206B\u200F\u206B\u200F\u206A\u206E\u200E\u200C\u202E\u202E\u202E\u200F\u202A\u200B\u200D\u202D\u202A\u202C\u202A\u206F\u202D\u206C\u200B\u200D\u200E\u202E\u200C\u206C\u206A\u206A\u202A\u206A\u206C\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMPMagicalCheeringDef.\u200C\u206B\u206E\u200B\u206C\u206B\u206C\u200B\u202A\u200C\u200C\u200E\u200E\u200F\u202A\u206E\u200B\u202E\u202A\u200C\u200E\u202B\u202E\u206F\u202C\u202E\u202C\u200F\u200E\u206D\u206C\u200F\u202D\u200F\u202B\u206A\u206E\u202C\u200F\u202C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreMPMagicalCheeringDef.\u202D\u206A\u200F\u206C\u206A\u206F\u202A\u202D\u200E\u206A\u206E\u202E\u206B\u206F\u200B\u200B\u202D\u206C\u202B\u206C\u202E\u200B\u202D\u202D\u202B\u200B\u200B\u206D\u202D\u202E\u206C\u202D\u206D\u202E\u206C\u206D\u206B\u200C\u206E\u206A\u202E(BepinexPlugin.sequenceTable, FlandreMPMagicalCheeringDef.\u206C\u202A\u202E\u200E\u202E\u206C\u206C\u200D\u200F\u202B\u200B\u206F\u206F\u206E\u206B\u206E\u202D\u200E\u206B\u206E\u202C\u200C\u200C\u206B\u200F\u200F\u202A\u206A\u200E\u206B\u200F\u206D\u200D\u202B\u206A\u206D\u206B\u206D\u202C\u202B\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
			int num3 = 0;
			bool flag2 = false;
			bool flag3 = FlandreMPMagicalCheeringDef.\u206E\u202E\u200D\u200B\u202C\u206B\u206F\u206D\u200E\u200D\u200F\u206B\u202A\u206D\u200F\u206D\u206F\u200E\u202D\u202B\u202B\u200B\u202C\u200B\u202D\u206E\u202C\u202E\u202E\u206B\u206F\u202C\u202D\u200E\u200F\u200B\u200F\u206E\u206E\u200C\u202E().ContainsKey(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1770291014));
			bool flag4 = false;
			bool flag5 = FlandreMPMagicalCheeringDef.\u206E\u202E\u200D\u200B\u202C\u206B\u206F\u206D\u200E\u200D\u200F\u206B\u202A\u206D\u200F\u206D\u206F\u200E\u202D\u202B\u202B\u200B\u202C\u200B\u202D\u206E\u202C\u202E\u202E\u206B\u206F\u202C\u202D\u200E\u200F\u200B\u200F\u206E\u206E\u200C\u202E().ContainsKey(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1747019761));
			bool flag6 = true;
			Rarity rarity = Rarity.Uncommon;
			CardType cardType = CardType.Skill;
			TargetType? targetType = new TargetType?(TargetType.Nobody);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.White);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				White = 1
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				White = 1
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
			int? num11 = new int?(1);
			int? num12 = null;
			int? num13 = null;
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
			Keyword keyword = Keyword.None;
			Keyword keyword2 = Keyword.None;
			bool flag8 = false;
			Keyword keyword3 = Keyword.Philosophy | Keyword.Upgrade;
			Keyword keyword4 = Keyword.Philosophy | Keyword.Upgrade;
			IReadOnlyList<string> readOnlyList;
			if (!FlandreMPMagicalCheeringDef.\u206E\u202E\u200D\u200B\u202C\u206B\u206F\u206D\u200E\u200D\u200F\u206B\u202A\u206D\u200F\u206D\u206F\u200E\u202D\u202B\u202B\u200B\u202C\u200B\u202D\u206E\u202C\u202E\u202E\u206B\u206F\u202C\u202D\u200E\u200F\u200B\u200F\u206E\u206E\u200C\u202E().ContainsKey(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1958841692)))
			{
				readOnlyList = new List<string>();
			}
			else
			{
				List<string> list2 = new List<string>();
				list2.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2117040051));
				readOnlyList = list2;
				list2.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1434012877));
			}
			IReadOnlyList<string> readOnlyList2;
			if (!FlandreMPMagicalCheeringDef.\u206E\u202E\u200D\u200B\u202C\u206B\u206F\u206D\u200E\u200D\u200F\u206B\u202A\u206D\u200F\u206D\u206F\u200E\u202D\u202B\u202B\u200B\u202C\u200B\u202D\u206E\u202C\u202E\u202E\u206B\u206F\u202C\u202D\u200E\u200F\u200B\u200F\u206E\u206E\u200C\u202E().ContainsKey(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1747019761)))
			{
				readOnlyList2 = new List<string>();
			}
			else
			{
				List<string> list3 = new List<string>();
				list3.Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-877970575));
				readOnlyList2 = list3;
				list3.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(501896159));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, readOnlyList, readOnlyList2, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(68120688), new List<string>());
		}

		static CardImages \u206B\u206B\u200C\u206B\u206C\u200D\u206D\u200C\u200C\u202D\u200C\u200D\u200E\u200B\u200D\u202C\u200E\u206F\u200E\u206D\u200C\u206E\u200F\u200B\u206C\u202E\u200D\u206A\u206E\u200E\u206B\u200E\u206E\u202B\u202B\u202E\u200C\u206B\u206F\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202B\u200D\u200C\u206D\u206B\u202A\u206B\u206B\u200F\u206B\u200F\u206A\u206E\u200E\u200C\u202E\u202E\u202E\u200F\u202A\u200B\u200D\u202D\u202A\u202C\u202A\u206F\u202D\u206C\u200B\u200D\u200E\u202E\u200C\u206C\u206A\u206A\u202A\u206A\u206C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200C\u206B\u206E\u200B\u206C\u206B\u206C\u200B\u202A\u200C\u200C\u200E\u200E\u200F\u202A\u206E\u200B\u202E\u202A\u200C\u200E\u202B\u202E\u206F\u202C\u202E\u202C\u200F\u200E\u206D\u206C\u200F\u202D\u200F\u202B\u206A\u206E\u202C\u200F\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u202A\u202E\u200E\u202E\u206C\u206C\u200D\u200F\u202B\u200B\u206F\u206F\u206E\u206B\u206E\u202D\u200E\u206B\u206E\u202C\u200C\u200C\u206B\u200F\u200F\u202A\u206A\u200E\u206B\u200F\u206D\u200D\u202B\u206A\u206D\u206B\u206D\u202C\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u206A\u200F\u206C\u206A\u206F\u202A\u202D\u200E\u206A\u206E\u202E\u206B\u206F\u200B\u200B\u202D\u206C\u202B\u206C\u202E\u200B\u202D\u202D\u202B\u200B\u200B\u206D\u202D\u202E\u206C\u202D\u206D\u202E\u206C\u206D\u206B\u200C\u206E\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		static Dictionary<string, PluginInfo> \u206E\u202E\u200D\u200B\u202C\u206B\u206F\u206D\u200E\u200D\u200F\u206B\u202A\u206D\u200F\u206D\u206F\u200E\u202D\u202B\u202B\u200B\u202C\u200B\u202D\u206E\u202C\u202E\u202E\u206B\u206F\u202C\u202D\u200E\u200F\u200B\u200F\u206E\u206E\u200C\u202E()
		{
			return Chainloader.PluginInfos;
		}

		[EntityLogic(typeof(FlandreMPMagicalCheeringDef))]
		public sealed class FlandreMPMagicalCheering : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u206C\u206E\u202C\u206C\u206C\u206C\u206D\u206A\u200B\u202B\u200C\u202B\u200F\u200D\u206E\u200D\u202D\u202B\u202E\u206F\u202C\u206A\u206A\u202D\u202A\u206A\u206A\u206D\u200C\u206E\u200B\u202C\u202E\u206C\u202D\u202B\u202D\u202D\u206E\u206E\u202E((float)FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u202A\u206F\u202B\u206F\u202A\u206B\u206D\u206A\u206C\u202C\u206A\u202B\u200B\u202C\u200E\u200D\u200C\u206D\u200B\u202C\u206C\u206E\u200E\u206D\u200F\u200B\u202B\u200E\u206F\u206A\u202C\u200E\u202A\u206A\u202A\u206B\u202C\u206A\u202D\u200C\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u206C\u206E\u202C\u206C\u206C\u206C\u206D\u206A\u200B\u202B\u200C\u202B\u200F\u200D\u206E\u200D\u202D\u202B\u202E\u206F\u202C\u206A\u206A\u202D\u202A\u206A\u206A\u206D\u200C\u206E\u200B\u202C\u202E\u206C\u202D\u202B\u202D\u202D\u206E\u206E\u202E((float)FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u202A\u206F\u202B\u206F\u202A\u206B\u206D\u206A\u206C\u202C\u206A\u202B\u200B\u202C\u200E\u200D\u200C\u206D\u200B\u202C\u206C\u206E\u200E\u206D\u200F\u200B\u202B\u200E\u206F\u206A\u202C\u200E\u202A\u206A\u202A\u206B\u202C\u206A\u202D\u200C\u202E(this).GetValueOrDefault() / 2f)
					};
				}
			}

			public override ManaGroup FlandreMana
			{
				get
				{
					ManaGroup manaGroup = ManaGroup.Philosophies(1) + this.AdditionalMana;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0068:
							int num = (FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u206A\u200C\u206F\u206D\u200C\u202C\u202B\u206C\u202B\u200E\u202E\u206C\u202B\u200E\u200C\u200C\u200C\u200D\u200C\u206B\u202D\u200E\u206A\u200C\u206C\u200B\u206E\u206E\u206E\u202A\u202D\u206F\u202D\u202E\u202B\u200B\u202A\u200C\u206A\u206E\u202E(enumerator) ? 308888486 : (-2057947155));
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((-(~num2) ^ -2106408916) * -468264667)) % 6U)
								{
								case 1U:
								{
									ManaColor manaColor = enumerator.Current;
									num = -240432745;
									continue;
								}
								case 2U:
								{
									ManaColor manaColor;
									num = (int)(((manaGroup.GetValue(manaColor) > 0) ? 3302215324U : 711808102U) ^ (num3 * 2202932377U));
									continue;
								}
								case 3U:
									goto IL_0068;
								case 4U:
									num = 308888486;
									continue;
								case 5U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 1417189594U) ^ 92362280U);
									continue;
								}
								}
								goto Block_3;
							}
						}
						Block_3:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_00D6:
								int num4 = 221002214;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)((-(~num2) ^ -2106408916) * -468264667)) % 3U)
									{
									case 0U:
										goto IL_00D6;
									case 1U:
										FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u202B\u202C\u202A\u202A\u206E\u206A\u200F\u206C\u202C\u200E\u206C\u200F\u206F\u200F\u200D\u202C\u200E\u202A\u206F\u206E\u200B\u206B\u206D\u206B\u202C\u206D\u202B\u200E\u202C\u202E\u200F\u206C\u206C\u200D\u206A\u200E\u206C\u202C\u206D\u202A\u202E(enumerator);
										num4 = (int)((num3 * 2486814187U) ^ 938112129U);
										continue;
									}
									goto Block_7;
								}
							}
							Block_7:;
						}
					}
					return manaGroup;
				}
			}

			public ManaGroup Mana2
			{
				get
				{
					return ManaGroup.Anys(1);
				}
			}

			public override ManaGroup AdditionalCost
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.Mana2 * FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u202E\u206A\u200F\u202A\u202D\u200F\u206E\u206A\u202C\u202C\u200D\u200E\u200E\u202C\u200E\u206A\u206A\u200C\u206E\u202C\u206C\u200C\u206C\u200C\u202E\u202D\u206B\u202B\u206A\u206D\u202D\u206C\u202D\u206E\u202C\u206A\u200E\u202D\u202E\u206E\u202E((FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.\u202B\u200E\u202D\u200E\u206E\u206B\u200D\u200F\u202D\u206F\u206E\u200B\u202A\u202D\u206D\u200C\u200C\u206F\u200C\u206C\u202D\u206E\u200F\u200D\u206C\u200C\u206F\u200C\u200E\u200E\u206E\u200F\u202E\u202C\u206C\u206E\u200B\u206D\u206F\u200D\u202E().ContainsKey(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1747019761)) && AyaLBOLMPHelper.MPIsActive) ? (AyaLBOLMPHelper.MPConnectedCount - 1) : 0, 0, 3);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsMagicalGirl = true;
				base.IsMultiplayer = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.<Actions>d__11 <Actions>d__ = new FlandreMPMagicalCheeringDef.FlandreMPMagicalCheering.<Actions>d__11(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202A\u206F\u202B\u206F\u202A\u206B\u206D\u206A\u206C\u202C\u206A\u202B\u200B\u202C\u200E\u200D\u200C\u206D\u200B\u202C\u206C\u206E\u200E\u206D\u200F\u200B\u202B\u200E\u206F\u206A\u202C\u200E\u202A\u206A\u202A\u206B\u202C\u206A\u202D\u200C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206C\u206E\u202C\u206C\u206C\u206C\u206D\u206A\u200B\u202B\u200C\u202B\u200F\u200D\u206E\u200D\u202D\u202B\u202E\u206F\u202C\u206A\u206A\u202D\u202A\u206A\u206A\u206D\u200C\u206E\u200B\u202C\u202E\u206C\u202D\u202B\u202D\u202D\u206E\u206E\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206A\u200C\u206F\u206D\u200C\u202C\u202B\u206C\u202B\u200E\u202E\u206C\u202B\u200E\u200C\u200C\u200C\u200D\u200C\u206B\u202D\u200E\u206A\u200C\u206C\u200B\u206E\u206E\u206E\u202A\u202D\u206F\u202D\u202E\u202B\u200B\u202A\u200C\u206A\u206E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202B\u202C\u202A\u202A\u206E\u206A\u200F\u206C\u202C\u200E\u206C\u200F\u206F\u200F\u200D\u202C\u200E\u202A\u206F\u206E\u200B\u206B\u206D\u206B\u202C\u206D\u202B\u200E\u202C\u202E\u200F\u206C\u206C\u200D\u206A\u200E\u206C\u202C\u206D\u202A\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static Dictionary<string, PluginInfo> \u202B\u200E\u202D\u200E\u206E\u206B\u200D\u200F\u202D\u206F\u206E\u200B\u202A\u202D\u206D\u200C\u200C\u206F\u200C\u206C\u202D\u206E\u200F\u200D\u206C\u200C\u206F\u200C\u200E\u200E\u206E\u200F\u202E\u202C\u206C\u206E\u200B\u206D\u206F\u200D\u202E()
			{
				return Chainloader.PluginInfos;
			}

			static int \u202E\u206A\u200F\u202A\u202D\u200F\u206E\u206A\u202C\u202C\u200D\u200E\u200E\u202C\u200E\u206A\u206A\u200C\u206E\u202C\u206C\u200C\u206C\u200C\u202E\u202D\u206B\u202B\u206A\u206D\u202D\u206C\u202D\u206E\u202C\u206A\u200E\u202D\u202E\u206E\u202E(int A_0, int A_1, int A_2)
			{
				return Math.Clamp(A_0, A_1, A_2);
			}
		}
	}
}
