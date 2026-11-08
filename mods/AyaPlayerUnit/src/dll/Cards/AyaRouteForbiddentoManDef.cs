using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaRouteForbiddentoManDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(271223951);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaRouteForbiddentoManDef.\u206F\u202C\u200D\u206F\u200C\u206F\u206D\u202A\u206B\u200E\u206B\u202D\u206B\u200C\u200F\u200E\u200E\u200E\u200D\u200E\u200B\u200C\u206A\u200E\u206C\u202E\u206B\u200E\u206C\u200D\u200F\u202A\u200D\u206E\u200F\u202C\u200E\u206E\u200F\u202B\u202E(BepinexPlugin.embeddedSource);
			AyaRouteForbiddentoManDef.\u206D\u202E\u202D\u206F\u206B\u206D\u202B\u206E\u206D\u206E\u206D\u206E\u206D\u206B\u200E\u206B\u206F\u206D\u202A\u206F\u206F\u202A\u200D\u202A\u200D\u202E\u206F\u200B\u206B\u206F\u200C\u200F\u206E\u202D\u202A\u206C\u206F\u200B\u200E\u202E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaRouteForbiddentoManDef.\u202C\u202A\u202E\u202E\u202D\u206E\u206B\u200F\u202E\u206D\u206C\u200F\u202A\u200B\u200E\u200B\u200B\u202C\u206B\u206D\u206F\u200C\u202E\u206D\u200D\u202C\u206F\u206F\u202B\u200B\u202A\u206A\u202E\u202E\u202E\u202D\u206F\u202B\u206B\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = AyaRouteForbiddentoManDef.\u200D\u200F\u202A\u200C\u202C\u202A\u202C\u200F\u200B\u200E\u202B\u200F\u206F\u200E\u202C\u202D\u200F\u200C\u206A\u200F\u206D\u202A\u206D\u206C\u206D\u206A\u202E\u206D\u206A\u206B\u206E\u200F\u202E\u202D\u206B\u206F\u200F\u202D\u202B\u202C\u202E(BepinexPlugin.sequenceTable, AyaRouteForbiddentoManDef.\u200C\u200D\u200F\u200E\u200E\u200E\u206E\u200E\u202B\u202E\u206D\u206E\u202E\u202B\u206E\u206F\u200F\u206A\u206D\u202B\u200B\u200C\u202A\u206A\u202A\u202C\u202A\u200E\u200E\u206E\u202A\u206C\u200F\u200B\u206A\u206B\u200D\u206F\u200B\u202B\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			string text3 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
			int num3 = 0;
			bool flag2 = false;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = true;
			bool flag6 = true;
			Rarity rarity = Rarity.Rare;
			CardType cardType = CardType.Attack;
			TargetType? targetType = new TargetType?(TargetType.Self);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.Green);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Green = 1
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				Any = 0
			});
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = new int?(12);
			int? num6 = null;
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(1);
			int? num12 = null;
			int? num13 = new int?(10);
			int? num14 = null;
			ManaGroup? manaGroup5 = new ManaGroup?(new ManaGroup
			{
				Green = 1
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
			Keyword keyword = Keyword.Accuracy | Keyword.Exile | Keyword.Replenish;
			Keyword keyword2 = Keyword.Accuracy | Keyword.Exile | Keyword.Replenish | Keyword.Plentiful;
			bool flag8 = false;
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list2 = new List<string>()).Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1806381897));
			}
			else
			{
				list2 = new List<string>();
			}
			List<string> list3;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list3 = new List<string>()).Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1821617700));
			}
			else
			{
				list3 = new List<string>();
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list3, new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(281062631), new List<string>());
		}

		static CardImages \u206F\u202C\u200D\u206F\u200C\u206F\u206D\u202A\u206B\u200E\u206B\u202D\u206B\u200C\u200F\u200E\u200E\u200E\u200D\u200E\u200B\u200C\u206A\u200E\u206C\u202E\u206B\u200E\u206C\u200D\u200F\u202A\u200D\u206E\u200F\u202C\u200E\u206E\u200F\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206D\u202E\u202D\u206F\u206B\u206D\u202B\u206E\u206D\u206E\u206D\u206E\u206D\u206B\u200E\u206B\u206F\u206D\u202A\u206F\u206F\u202A\u200D\u202A\u200D\u202E\u206F\u200B\u206B\u206F\u200C\u200F\u206E\u202D\u202A\u206C\u206F\u200B\u200E\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u202A\u202E\u202E\u202D\u206E\u206B\u200F\u202E\u206D\u206C\u200F\u202A\u200B\u200E\u200B\u200B\u202C\u206B\u206D\u206F\u200C\u202E\u206D\u200D\u202C\u206F\u206F\u202B\u200B\u202A\u206A\u202E\u202E\u202E\u202D\u206F\u202B\u206B\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200C\u200D\u200F\u200E\u200E\u200E\u206E\u200E\u202B\u202E\u206D\u206E\u202E\u202B\u206E\u206F\u200F\u206A\u206D\u202B\u200B\u200C\u202A\u206A\u202A\u202C\u202A\u200E\u200E\u206E\u202A\u206C\u200F\u200B\u206A\u206B\u200D\u206F\u200B\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u200F\u202A\u200C\u202C\u202A\u202C\u200F\u200B\u200E\u202B\u200F\u206F\u200E\u202C\u202D\u200F\u200C\u206A\u200F\u206D\u202A\u206D\u206C\u206D\u206A\u202E\u206D\u206A\u206B\u206E\u200F\u202E\u202D\u206B\u206F\u200F\u202D\u202B\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}
	}
}
