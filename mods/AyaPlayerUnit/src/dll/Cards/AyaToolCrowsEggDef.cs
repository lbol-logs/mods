using System;
using System.Collections.Generic;
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

namespace AyaShameimaru.Cards
{
	public sealed class AyaToolCrowsEggDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1664236967);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaToolCrowsEggDef.\u200D\u206B\u206B\u200C\u202D\u202D\u206E\u200B\u202E\u202A\u200B\u200F\u206A\u200D\u202C\u200E\u202B\u202D\u202D\u202D\u200C\u206C\u206E\u200E\u206A\u202C\u202E\u202A\u206D\u206C\u202D\u202E\u200D\u206C\u200B\u206A\u200D\u206F\u200C\u206C\u202E(BepinexPlugin.embeddedSource);
			AyaToolCrowsEggDef.\u206A\u206D\u200E\u200D\u200D\u206F\u200F\u202C\u202B\u200C\u200D\u202A\u206B\u200C\u206C\u206F\u200C\u202A\u202B\u202D\u200C\u200C\u200B\u202A\u206D\u206F\u206C\u202E\u202C\u200E\u200F\u202C\u200F\u202E\u200B\u206F\u202E\u206E\u206D\u206F\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaToolCrowsEggDef.\u200E\u206D\u202D\u202B\u206C\u200D\u206B\u202D\u206A\u206B\u202E\u202C\u202B\u202E\u202D\u200D\u202A\u206A\u206B\u200E\u206F\u206D\u202D\u206D\u202D\u206F\u202D\u200B\u202B\u200D\u200B\u206A\u202A\u200C\u206A\u200F\u202C\u206E\u200C\u206A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = AyaToolCrowsEggDef.\u200D\u206B\u206A\u206D\u200B\u206D\u200D\u202C\u206E\u200D\u200C\u206D\u206F\u206F\u206A\u206A\u206D\u202C\u206E\u200D\u200F\u200C\u202A\u206C\u206F\u206C\u202D\u206E\u206B\u200D\u206E\u200E\u200F\u200B\u206C\u200F\u200F\u202C\u206A\u202C\u202E(BepinexPlugin.sequenceTable, AyaToolCrowsEggDef.\u200D\u206F\u206A\u200B\u206A\u206E\u200B\u202D\u202D\u202E\u200D\u206F\u202B\u206C\u206A\u206D\u206E\u200F\u206E\u202B\u202C\u202C\u200D\u202E\u206D\u200E\u206A\u200B\u200E\u200B\u202C\u206C\u200E\u200F\u202A\u200C\u206F\u202A\u202C\u206C\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
			int num3 = 0;
			bool flag2 = false;
			bool normalAyaPlayerUnit = BepinexPlugin.NormalAyaPlayerUnit;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			Rarity rarity = Rarity.Common;
			CardType cardType = CardType.Tool;
			TargetType? targetType = new TargetType?(TargetType.Self);
			IReadOnlyList<ManaColor> readOnlyList = new List<ManaColor>();
			bool flag6 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 0
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
			int? num11 = new int?(5);
			int? num12 = null;
			int? num13 = null;
			int? num14 = null;
			ManaGroup? manaGroup5 = null;
			ManaGroup? manaGroup6 = null;
			int? num15 = null;
			int? num16 = null;
			int? num17 = new int?(2);
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
			Keyword keyword = (BepinexPlugin.HardAyaPlayerUnit ? (Keyword.Exile | Keyword.Replenish) : Keyword.None);
			Keyword keyword2 = (BepinexPlugin.HardAyaPlayerUnit ? (Keyword.Exile | Keyword.Replenish) : Keyword.None);
			bool flag7 = false;
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list;
			if (!BepinexPlugin.NormalAyaPlayerUnit)
			{
				list = new List<string>();
			}
			else
			{
				(list = new List<string>()).Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1805881097));
			}
			List<string> list2;
			if (!BepinexPlugin.NormalAyaPlayerUnit)
			{
				list2 = new List<string>();
			}
			else
			{
				(list2 = new List<string>()).Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1151847258));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, normalAyaPlayerUnit, flag3, flag4, flag5, rarity, cardType, targetType, readOnlyList, flag6, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag7, keyword3, keyword4, list, list2, new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(420582414), new List<string>());
		}

		static CardImages \u200D\u206B\u206B\u200C\u202D\u202D\u206E\u200B\u202E\u202A\u200B\u200F\u206A\u200D\u202C\u200E\u202B\u202D\u202D\u202D\u200C\u206C\u206E\u200E\u206A\u202C\u202E\u202A\u206D\u206C\u202D\u202E\u200D\u206C\u200B\u206A\u200D\u206F\u200C\u206C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206A\u206D\u200E\u200D\u200D\u206F\u200F\u202C\u202B\u200C\u200D\u202A\u206B\u200C\u206C\u206F\u200C\u202A\u202B\u202D\u200C\u200C\u200B\u202A\u206D\u206F\u206C\u202E\u202C\u200E\u200F\u202C\u200F\u202E\u200B\u206F\u202E\u206E\u206D\u206F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200E\u206D\u202D\u202B\u206C\u200D\u206B\u202D\u206A\u206B\u202E\u202C\u202B\u202E\u202D\u200D\u202A\u206A\u206B\u200E\u206F\u206D\u202D\u206D\u202D\u206F\u202D\u200B\u202B\u200D\u200B\u206A\u202A\u200C\u206A\u200F\u202C\u206E\u200C\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u206F\u206A\u200B\u206A\u206E\u200B\u202D\u202D\u202E\u200D\u206F\u202B\u206C\u206A\u206D\u206E\u200F\u206E\u202B\u202C\u202C\u200D\u202E\u206D\u200E\u206A\u200B\u200E\u200B\u202C\u206C\u200E\u200F\u202A\u200C\u206F\u202A\u202C\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206B\u206A\u206D\u200B\u206D\u200D\u202C\u206E\u200D\u200C\u206D\u206F\u206F\u206A\u206A\u206D\u202C\u206E\u200D\u200F\u200C\u202A\u206C\u206F\u206C\u202D\u206E\u206B\u200D\u206E\u200E\u200F\u200B\u206C\u200F\u200F\u202C\u206A\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaToolCrowsEggDef))]
		public sealed class AyaToolCrowsEgg : Card
		{
			private string LockedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-266623663), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.NormalAyaPlayerUnit)
				{
					for (;;)
					{
						int num = 1072748395;
						switch (~(--51395309 + (-1559492700 - 1610039888) - (-((-1878743153 + 1962667278) ^ -931197191) - num) - (1074420699 + 1257321973)) % 3)
						{
						case 0:
							continue;
						case 1:
							goto IL_0059;
						}
						break;
					}
					goto IL_006F;
					IL_0059:
					return base.GetBaseDescription();
				}
				IL_006F:
				return this.LockedDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaToolCrowsEggDef.AyaToolCrowsEgg.<Actions>d__3 <Actions>d__ = new AyaToolCrowsEggDef.AyaToolCrowsEgg.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}
		}
	}
}
