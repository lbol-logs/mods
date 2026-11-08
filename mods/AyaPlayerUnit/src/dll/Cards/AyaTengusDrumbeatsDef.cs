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
	public sealed class AyaTengusDrumbeatsDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1305848040);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaTengusDrumbeatsDef.\u206A\u200F\u200F\u200C\u206E\u202A\u206B\u202E\u206B\u202B\u202B\u200E\u200D\u206D\u206D\u200C\u200E\u206C\u200C\u202D\u206F\u206A\u202C\u202A\u202D\u206F\u206E\u206F\u206E\u202D\u206A\u206E\u202A\u202A\u202E\u206E\u202A\u202B\u200C\u202B\u202E(BepinexPlugin.embeddedSource);
			AyaTengusDrumbeatsDef.\u200C\u202B\u200D\u202D\u200E\u206F\u200D\u200F\u202E\u202A\u200F\u200C\u202E\u200B\u200D\u202E\u206F\u202C\u206C\u202C\u202A\u206E\u206F\u206D\u202C\u206F\u206B\u206E\u202B\u206F\u202D\u206F\u200F\u206E\u202D\u206A\u202A\u200F\u200B\u202D\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTengusDrumbeatsDef.\u200B\u202C\u202C\u206A\u202E\u202C\u202E\u202C\u206E\u200C\u202E\u202D\u200E\u200E\u200E\u202A\u202B\u202C\u200B\u206A\u206E\u200D\u200B\u202B\u206D\u202A\u206F\u202A\u202E\u206D\u206C\u206B\u206A\u202C\u202B\u200B\u202C\u200D\u200C\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = AyaTengusDrumbeatsDef.\u202B\u206B\u206A\u206E\u202B\u200D\u200F\u202E\u206E\u206F\u202B\u200B\u200B\u202A\u206E\u200D\u202C\u206D\u206B\u202A\u200F\u200B\u206A\u202E\u202C\u200E\u200D\u206A\u200E\u206D\u202D\u202D\u206E\u202E\u206F\u202E\u200C\u202E\u202D\u202E\u202E(BepinexPlugin.sequenceTable, AyaTengusDrumbeatsDef.\u200E\u206F\u202A\u200D\u206F\u200E\u206B\u200B\u206E\u200E\u202B\u206C\u202D\u206F\u200B\u200F\u206E\u200F\u206A\u200B\u200D\u202D\u200F\u202A\u200D\u202D\u202B\u206B\u202B\u206C\u206F\u202B\u206A\u206D\u200E\u206F\u206C\u206C\u202C\u202D\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(781649274);
			string text3 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-291416545);
			int num3 = 0;
			bool flag2 = false;
			bool flag3 = true;
			bool flag4 = false;
			bool flag5 = true;
			bool flag6 = true;
			Rarity rarity = Rarity.Uncommon;
			CardType cardType = CardType.Attack;
			TargetType? targetType = new TargetType?(TargetType.AllEnemies);
			List<ManaColor> list = new List<ManaColor>();
			list.Add(ManaColor.Red);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				Red = 1
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				Any = 2
			});
			ManaGroup? manaGroup3 = null;
			ManaGroup? manaGroup4 = null;
			int? num4 = null;
			int? num5 = new int?(13);
			int? num6 = new int?(17);
			int? num7 = null;
			int? num8 = null;
			int? num9 = null;
			int? num10 = null;
			int? num11 = new int?(2);
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
			Keyword keyword = Keyword.Accuracy;
			Keyword keyword2 = Keyword.Accuracy;
			bool flag8 = false;
			Keyword keyword3 = Keyword.None;
			Keyword keyword4 = Keyword.None;
			List<string> list3;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				List<string> list2 = new List<string>();
				list2.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1805881097));
				list3 = list2;
				list2.Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1650643731));
			}
			else
			{
				(list3 = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-395548494));
			}
			List<string> list5;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				List<string> list4 = new List<string>();
				list4.Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1385709034));
				list5 = list4;
				list4.Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1650643731));
			}
			else
			{
				(list5 = new List<string>()).Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1650643731));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, list3, list5, new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-714371867), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1449191320), new List<string>());
		}

		static CardImages \u206A\u200F\u200F\u200C\u206E\u202A\u206B\u202E\u206B\u202B\u202B\u200E\u200D\u206D\u206D\u200C\u200E\u206C\u200C\u202D\u206F\u206A\u202C\u202A\u202D\u206F\u206E\u206F\u206E\u202D\u206A\u206E\u202A\u202A\u202E\u206E\u202A\u202B\u200C\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u202B\u200D\u202D\u200E\u206F\u200D\u200F\u202E\u202A\u200F\u200C\u202E\u200B\u200D\u202E\u206F\u202C\u206C\u202C\u202A\u206E\u206F\u206D\u202C\u206F\u206B\u206E\u202B\u206F\u202D\u206F\u200F\u206E\u202D\u206A\u202A\u200F\u200B\u202D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200B\u202C\u202C\u206A\u202E\u202C\u202E\u202C\u206E\u200C\u202E\u202D\u200E\u200E\u200E\u202A\u202B\u202C\u200B\u206A\u206E\u200D\u200B\u202B\u206D\u202A\u206F\u202A\u202E\u206D\u206C\u206B\u206A\u202C\u202B\u200B\u202C\u200D\u200C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u206F\u202A\u200D\u206F\u200E\u206B\u200B\u206E\u200E\u202B\u206C\u202D\u206F\u200B\u200F\u206E\u200F\u206A\u200B\u200D\u202D\u200F\u202A\u200D\u202D\u202B\u206B\u202B\u206C\u206F\u202B\u206A\u206D\u200E\u206F\u206C\u206C\u202C\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206B\u206A\u206E\u202B\u200D\u200F\u202E\u206E\u206F\u202B\u200B\u200B\u202A\u206E\u200D\u202C\u206D\u206B\u202A\u200F\u200B\u206A\u202E\u202C\u200E\u200D\u206A\u200E\u206D\u202D\u202D\u206E\u202E\u206F\u202E\u200C\u202E\u202D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTengusDrumbeatsDef))]
		public sealed class AyaTengusDrumbeats : Card
		{
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
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(128824052), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0071;
				}
				IL_000C:
				int num = -784374500;
				IL_0011:
				int num2 = num;
				switch ((-836583093 - ((num2 ^ (-(--1050401638) - -1013398488)) - ~(-1979860606 + -2135626525)) - 1138267802) % 5)
				{
				case 0:
					return this.PhantasmModeDescription;
				case 1:
					IL_0071:
					num = ((!AyaTengusDrumbeatsDef.AyaTengusDrumbeats.\u200B\u202B\u200C\u206B\u202D\u200E\u206E\u202E\u206B\u200F\u200E\u206F\u206E\u200B\u200F\u202B\u206A\u200C\u202D\u200F\u200C\u202C\u200F\u200D\u202B\u200E\u200C\u202C\u206E\u202B\u206B\u206C\u200F\u202D\u206A\u200C\u202A\u202B\u200F\u202A\u202E(this)) ? (-1145934936) : (-945011224));
					goto IL_0011;
				case 2:
					return base.GetBaseDescription();
				case 4:
					goto IL_000C;
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaTengusDrumbeatsDef.AyaTengusDrumbeats.<Actions>d__5 <Actions>d__ = new AyaTengusDrumbeatsDef.AyaTengusDrumbeats.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static bool \u200B\u202B\u200C\u206B\u202D\u200E\u206E\u202E\u206B\u200F\u200E\u206F\u206E\u200B\u200F\u202B\u206A\u200C\u202D\u200F\u200C\u202C\u200F\u200D\u202B\u200E\u200C\u202C\u206E\u202B\u206B\u206C\u200F\u202D\u206A\u200C\u202A\u202B\u200F\u202A\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
