using System;
using System.Collections.Generic;
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
	public sealed class FlandreColorofMadnessDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-186302149);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreColorofMadnessDef.\u206B\u202C\u206F\u206C\u200B\u200B\u206F\u200C\u202C\u200C\u206C\u206A\u202A\u202D\u200D\u206F\u206F\u200C\u200C\u206A\u202B\u206A\u206E\u200E\u200C\u206F\u202E\u202D\u202B\u206A\u200C\u200C\u206E\u202E\u202D\u202B\u200F\u200D\u206A\u200D\u202E(BepinexPlugin.embeddedSource);
			FlandreColorofMadnessDef.\u200F\u202D\u200E\u202A\u206E\u202C\u206D\u202E\u206C\u200F\u200F\u200C\u202C\u202A\u202A\u202C\u206C\u202D\u202D\u206B\u206E\u200F\u202D\u206B\u202A\u206B\u202A\u202D\u206A\u202A\u202A\u202A\u206C\u202B\u206B\u206E\u206B\u202A\u202C\u200D\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreColorofMadnessDef.\u206B\u202D\u206C\u200E\u206C\u200D\u206B\u206F\u202A\u206D\u200B\u200F\u206B\u206C\u202B\u202E\u202A\u206E\u206A\u200B\u206D\u206F\u206E\u202E\u202C\u202B\u202A\u202D\u206E\u202C\u202A\u206D\u206B\u200C\u200B\u202B\u206D\u200F\u206A\u206B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreColorofMadnessDef.\u202D\u206A\u202B\u200F\u200E\u200B\u206F\u206D\u206A\u200D\u206E\u206D\u200E\u202A\u202A\u206E\u206C\u200B\u206B\u206B\u200E\u206E\u206C\u200E\u206A\u202A\u200F\u202D\u202C\u202A\u206A\u200B\u202D\u202B\u202B\u202A\u206D\u200D\u202E\u206A\u202E(BepinexPlugin.sequenceTable, FlandreColorofMadnessDef.\u206E\u202A\u206E\u202D\u206C\u200C\u206C\u200D\u200B\u206F\u202A\u200F\u202A\u202B\u202B\u200C\u200F\u200D\u200D\u206E\u200C\u206C\u206B\u202A\u200D\u206C\u202C\u202E\u202D\u206A\u202C\u200B\u202B\u202D\u206E\u206C\u206D\u200F\u202D\u200F\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
			string text3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
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
			list.Add(ManaColor.Blue);
			list.Add(ManaColor.Black);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				Blue = 2,
				Black = 2
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				Blue = 2,
				Black = 2
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
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list2 = new List<string>();
			}
			else
			{
				(list2 = new List<string>()).Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062));
			}
			List<string> list3;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				list3 = new List<string>();
			}
			else
			{
				(list3 = new List<string>()).Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(437004320));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list2, list3, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1633839845),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1225294364),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1938530611),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368637644)
			}, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(479190102),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1225294364),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1938530611),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1859754853)
			}, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1261127831), new List<string>());
		}

		static CardImages \u206B\u202C\u206F\u206C\u200B\u200B\u206F\u200C\u202C\u200C\u206C\u206A\u202A\u202D\u200D\u206F\u206F\u200C\u200C\u206A\u202B\u206A\u206E\u200E\u200C\u206F\u202E\u202D\u202B\u206A\u200C\u200C\u206E\u202E\u202D\u202B\u200F\u200D\u206A\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200F\u202D\u200E\u202A\u206E\u202C\u206D\u202E\u206C\u200F\u200F\u200C\u202C\u202A\u202A\u202C\u206C\u202D\u202D\u206B\u206E\u200F\u202D\u206B\u202A\u206B\u202A\u202D\u206A\u202A\u202A\u202A\u206C\u202B\u206B\u206E\u206B\u202A\u202C\u200D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206B\u202D\u206C\u200E\u206C\u200D\u206B\u206F\u202A\u206D\u200B\u200F\u206B\u206C\u202B\u202E\u202A\u206E\u206A\u200B\u206D\u206F\u206E\u202E\u202C\u202B\u202A\u202D\u206E\u202C\u202A\u206D\u206B\u200C\u200B\u202B\u206D\u200F\u206A\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u202A\u206E\u202D\u206C\u200C\u206C\u200D\u200B\u206F\u202A\u200F\u202A\u202B\u202B\u200C\u200F\u200D\u200D\u206E\u200C\u206C\u206B\u202A\u200D\u206C\u202C\u202E\u202D\u206A\u202C\u200B\u202B\u202D\u206E\u206C\u206D\u200F\u202D\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u206A\u202B\u200F\u200E\u200B\u206F\u206D\u206A\u200D\u206E\u206D\u200E\u202A\u202A\u206E\u206C\u200B\u206B\u206B\u200E\u206E\u206C\u200E\u206A\u202A\u200F\u202D\u202C\u202A\u206A\u200B\u202D\u202B\u202B\u202A\u206D\u200D\u202E\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreColorofMadnessDef))]
		public sealed class FlandreColorofMadness : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreColorofMadnessDef.FlandreColorofMadness.\u206B\u202A\u200E\u206D\u200B\u202D\u206C\u202B\u200F\u200D\u200B\u202D\u200C\u200E\u206F\u200D\u202C\u200B\u200D\u202D\u202E\u200E\u202B\u206D\u206A\u206B\u200D\u206A\u200D\u206D\u200B\u202E\u202A\u202C\u200B\u202C\u206D\u202B\u202E\u206E\u202E((float)FlandreColorofMadnessDef.FlandreColorofMadness.\u202D\u206A\u206E\u202A\u200D\u200B\u200C\u206E\u202E\u200F\u206B\u202D\u200B\u202E\u200B\u200B\u200F\u206A\u202D\u202E\u202E\u200E\u200C\u202D\u200B\u206D\u206B\u202C\u200D\u206D\u202A\u206A\u206D\u206E\u206F\u200C\u206E\u202B\u206F\u200C\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1075896301), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1139567361), true, true);
				}
			}

			public int Value3
			{
				get
				{
					return 12;
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_004C;
				}
				IL_000C:
				int num = 1696099778;
				IL_0011:
				int num2 = num;
				switch (-(~(-(-num2))) % 5)
				{
				case 0:
					return this.PhantasmModeDescription;
				case 2:
					goto IL_000C;
				case 3:
					IL_004C:
					num = (FlandreColorofMadnessDef.FlandreColorofMadness.\u206C\u202B\u200E\u206F\u200B\u200B\u200C\u200F\u202A\u200C\u206E\u206B\u200D\u206F\u206A\u200D\u202D\u206B\u202D\u206B\u200F\u202E\u200D\u200D\u202D\u206F\u202B\u202D\u206E\u202D\u200B\u206C\u206A\u206A\u206A\u202E\u206C\u206B\u200C\u200E\u202E(this) ? 1556206395 : 6015324);
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
				for (;;)
				{
					IL_000D:
					int num = -438783613;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-num2 - -(-1704334245 ^ 1686643097))) % 3U)
						{
						case 0U:
							goto IL_000D;
						case 2U:
							base.OfferingCount = FlandreColorofMadnessDef.FlandreColorofMadness.\u206A\u206A\u202A\u200E\u206C\u200D\u206A\u206A\u206F\u202C\u206A\u202A\u206A\u200F\u200E\u200E\u200C\u200C\u202E\u200B\u200B\u202D\u202B\u200E\u200B\u206E\u200C\u200B\u206E\u200B\u202D\u200E\u206C\u202E\u200F\u206A\u200D\u200C\u206F\u202C\u202E(this);
							num = (int)((num3 * 1367012469U) ^ 1786694360U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreColorofMadnessDef.FlandreColorofMadness.<Actions>d__10 <Actions>d__ = new FlandreColorofMadnessDef.FlandreColorofMadness.<Actions>d__10(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202D\u206A\u206E\u202A\u200D\u200B\u200C\u206E\u202E\u200F\u206B\u202D\u200B\u202E\u200B\u200B\u200F\u206A\u202D\u202E\u202E\u200E\u200C\u202D\u200B\u206D\u206B\u202C\u200D\u206D\u202A\u206A\u206D\u206E\u206F\u200C\u206E\u202B\u206F\u200C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206B\u202A\u200E\u206D\u200B\u202D\u206C\u202B\u200F\u200D\u200B\u202D\u200C\u200E\u206F\u200D\u202C\u200B\u200D\u202D\u202E\u200E\u202B\u206D\u206A\u206B\u200D\u206A\u200D\u206D\u200B\u202E\u202A\u202C\u200B\u202C\u206D\u202B\u202E\u206E\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206C\u202B\u200E\u206F\u200B\u200B\u200C\u200F\u202A\u200C\u206E\u206B\u200D\u206F\u206A\u200D\u202D\u206B\u202D\u206B\u200F\u202E\u200D\u200D\u202D\u206F\u202B\u202D\u206E\u202D\u200B\u206C\u206A\u206A\u206A\u202E\u206C\u206B\u200C\u200E\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static int \u206A\u206A\u202A\u200E\u206C\u200D\u206A\u206A\u206F\u202C\u206A\u202A\u206A\u200F\u200E\u200E\u200C\u200C\u202E\u200B\u200B\u202D\u202B\u200E\u200B\u206E\u200C\u200B\u206E\u200B\u202D\u200E\u206C\u202E\u200F\u206A\u200D\u200C\u206F\u202C\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
