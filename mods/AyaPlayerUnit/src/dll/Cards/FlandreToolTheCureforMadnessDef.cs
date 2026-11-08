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
	public sealed class FlandreToolTheCureforMadnessDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1607344268);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreToolTheCureforMadnessDef.\u206E\u202D\u206B\u202D\u200C\u206A\u202C\u202E\u206B\u200C\u202B\u202A\u200B\u202C\u206A\u200D\u200F\u202D\u200D\u206F\u200C\u202A\u200D\u206C\u206E\u200D\u202D\u200C\u202A\u202E\u202A\u202A\u206C\u200E\u200C\u200C\u202A\u202B\u206B\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreToolTheCureforMadnessDef.\u202E\u200E\u200E\u206F\u206D\u206D\u202C\u202B\u202A\u200D\u200E\u200C\u206E\u200E\u200D\u202D\u206F\u202C\u206B\u200E\u206F\u202D\u202E\u202B\u200B\u200B\u206F\u206D\u206E\u202E\u202D\u206C\u200B\u206D\u202C\u202E\u202C\u202E\u202E\u206B\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreToolTheCureforMadnessDef.\u202D\u200B\u200D\u202E\u202D\u202C\u202C\u202B\u200F\u202D\u202E\u206D\u206C\u206E\u202D\u206B\u206F\u200F\u200C\u202A\u202C\u202A\u202B\u206F\u200B\u202E\u200F\u206F\u202E\u200E\u202C\u206A\u200B\u206A\u202D\u202A\u202A\u200D\u206D\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreToolTheCureforMadnessDef.\u206F\u200F\u206B\u202A\u200E\u206E\u206E\u202A\u202E\u206E\u206B\u206E\u202B\u206A\u202A\u202D\u206A\u206F\u206E\u206B\u202C\u200D\u206E\u206D\u200E\u200F\u200C\u202D\u202A\u200E\u206F\u200C\u200E\u206D\u202B\u202D\u206D\u200E\u206C\u202E\u202E(BepinexPlugin.sequenceTable, FlandreToolTheCureforMadnessDef.\u206F\u202C\u206E\u202D\u200E\u206F\u202E\u206B\u206D\u206E\u200D\u206A\u206F\u200D\u206E\u200C\u200F\u200B\u202D\u202E\u206D\u206B\u200F\u206B\u206E\u206B\u206B\u206D\u206C\u200D\u202E\u202A\u202D\u206D\u202E\u206A\u206B\u200B\u206A\u206F\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
			int num3 = 0;
			bool flag2 = false;
			bool hardFlandrePlayerUnit = BepinexPlugin.HardFlandrePlayerUnit;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			Rarity rarity = Rarity.Uncommon;
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
			int? num11 = new int?(120);
			int? num12 = null;
			int? num13 = null;
			int? num14 = null;
			ManaGroup? manaGroup5 = null;
			ManaGroup? manaGroup6 = null;
			int? num15 = null;
			int? num16 = null;
			int? num17 = new int?(1);
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
			Keyword keyword = (BepinexPlugin.HardFlandrePlayerUnit ? Keyword.Replenish : Keyword.None);
			Keyword keyword2 = (BepinexPlugin.HardFlandrePlayerUnit ? Keyword.Replenish : Keyword.None);
			bool flag7 = false;
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list;
			if (!BepinexPlugin.HardFlandrePlayerUnit)
			{
				list = new List<string>();
			}
			else
			{
				(list = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871));
			}
			List<string> list2;
			if (!BepinexPlugin.HardFlandrePlayerUnit)
			{
				list2 = new List<string>();
			}
			else
			{
				(list2 = new List<string>()).Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, hardFlandrePlayerUnit, flag3, flag4, flag5, rarity, cardType, targetType, readOnlyList, flag6, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag7, keyword3, keyword4, list, list2, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1503864283), new List<string>());
		}

		static CardImages \u206E\u202D\u206B\u202D\u200C\u206A\u202C\u202E\u206B\u200C\u202B\u202A\u200B\u202C\u206A\u200D\u200F\u202D\u200D\u206F\u200C\u202A\u200D\u206C\u206E\u200D\u202D\u200C\u202A\u202E\u202A\u202A\u206C\u200E\u200C\u200C\u202A\u202B\u206B\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u200E\u200E\u206F\u206D\u206D\u202C\u202B\u202A\u200D\u200E\u200C\u206E\u200E\u200D\u202D\u206F\u202C\u206B\u200E\u206F\u202D\u202E\u202B\u200B\u200B\u206F\u206D\u206E\u202E\u202D\u206C\u200B\u206D\u202C\u202E\u202C\u202E\u202E\u206B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u200B\u200D\u202E\u202D\u202C\u202C\u202B\u200F\u202D\u202E\u206D\u206C\u206E\u202D\u206B\u206F\u200F\u200C\u202A\u202C\u202A\u202B\u206F\u200B\u202E\u200F\u206F\u202E\u200E\u202C\u206A\u200B\u206A\u202D\u202A\u202A\u200D\u206D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206F\u202C\u206E\u202D\u200E\u206F\u202E\u206B\u206D\u206E\u200D\u206A\u206F\u200D\u206E\u200C\u200F\u200B\u202D\u202E\u206D\u206B\u200F\u206B\u206E\u206B\u206B\u206D\u206C\u200D\u202E\u202A\u202D\u206D\u202E\u206A\u206B\u200B\u206A\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u200F\u206B\u202A\u200E\u206E\u206E\u202A\u202E\u206E\u206B\u206E\u202B\u206A\u202A\u202D\u206A\u206F\u206E\u206B\u202C\u200D\u206E\u206D\u200E\u200F\u200C\u202D\u202A\u200E\u206F\u200C\u200E\u206D\u202B\u202D\u206D\u200E\u206C\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreToolTheCureforMadnessDef))]
		public sealed class FlandreToolTheCureforMadness : FlandreCard
		{
			private string LockedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(782299586), true, true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (FlandreToolTheCureforMadnessDef.FlandreToolTheCureforMadness.\u200D\u202E\u206B\u200B\u200D\u202C\u202D\u206C\u200B\u206C\u202B\u206E\u200B\u200B\u202E\u206C\u202B\u206D\u206A\u202C\u206F\u206F\u202A\u202E\u206B\u202A\u200B\u206D\u202A\u202E\u206E\u202D\u202D\u200E\u206B\u202C\u200C\u206B\u200B\u200C\u202E(key, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1359557384)))
				{
					for (;;)
					{
						IL_0017:
						int num = -1276569792;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-((-(-1937036381 + 337178192 + -720345171) - num2) * 2097069899) - -1815627540)) % 5U)
							{
							case 1U:
								required = false;
								num = (int)((num3 * 922473875U) ^ 3635300930U);
								continue;
							case 2U:
								key = "";
								num = (int)((num3 * 2235755238U) ^ 961201784U);
								continue;
							case 3U:
								num = (int)((BepinexPlugin.HardFlandrePlayerUnit ? 1149226240U : 3031475133U) ^ (num3 * 787527139U));
								continue;
							case 4U:
								goto IL_0017;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return TypeFactory<Card>.LocalizeProperty(FlandreToolTheCureforMadnessDef.FlandreToolTheCureforMadness.\u200F\u202A\u202E\u206E\u206B\u200F\u206F\u202E\u206A\u206C\u202C\u206F\u200F\u206F\u202D\u206C\u206C\u200E\u200E\u206C\u206F\u206C\u206B\u206B\u202D\u202E\u206E\u206A\u206A\u206D\u200B\u200D\u206C\u200C\u206D\u206F\u206F\u200C\u206C\u202E(this), key, decorated, required);
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.HardFlandrePlayerUnit)
				{
					for (;;)
					{
						int num = -156357777;
						switch ((~(-num) + --829073667) % 3)
						{
						case 0:
							continue;
						case 2:
							goto IL_002E;
						}
						break;
					}
					goto IL_0044;
					IL_002E:
					return base.GetBaseDescription();
				}
				IL_0044:
				return this.LockedDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreToolTheCureforMadnessDef.FlandreToolTheCureforMadness.<Actions>d__4 <Actions>d__ = new FlandreToolTheCureforMadnessDef.FlandreToolTheCureforMadness.<Actions>d__4(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u200D\u202E\u206B\u200B\u200D\u202C\u202D\u206C\u200B\u206C\u202B\u206E\u200B\u200B\u202E\u206C\u202B\u206D\u206A\u202C\u206F\u206F\u202A\u202E\u206B\u202A\u200B\u206D\u202A\u202E\u206E\u202D\u202D\u200E\u206B\u202C\u200C\u206B\u200B\u200C\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u200F\u202A\u202E\u206E\u206B\u200F\u206F\u202E\u206A\u206C\u202C\u206F\u200F\u206F\u202D\u206C\u206C\u200E\u200E\u206C\u206F\u206C\u206B\u206B\u202D\u202E\u206E\u206A\u206A\u206D\u200B\u200D\u206C\u200C\u206D\u206F\u206F\u200C\u206C\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}
		}
	}
}
