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
	public sealed class FlandreThePsychoticandCuteGuestDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(540985635);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreThePsychoticandCuteGuestDef.\u202A\u202C\u202D\u202B\u206E\u202D\u200D\u206A\u200E\u202D\u206A\u202A\u202D\u200E\u200C\u206C\u206A\u206A\u206F\u206A\u200B\u206B\u200D\u206F\u200E\u200E\u200C\u200D\u202E\u206D\u202B\u200E\u200C\u202C\u200D\u202C\u200C\u202C\u200B\u202E\u202E(BepinexPlugin.embeddedSource);
			FlandreThePsychoticandCuteGuestDef.\u206D\u206D\u202E\u206F\u202A\u200D\u202B\u206B\u200C\u202E\u206B\u202A\u206C\u200B\u202B\u206E\u202E\u202A\u206B\u200E\u202A\u200B\u206F\u200F\u206E\u206F\u206D\u202A\u200F\u206F\u200E\u202D\u200E\u206F\u200D\u206A\u206E\u202C\u202E\u202A\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreThePsychoticandCuteGuestDef.\u200F\u206A\u202A\u206D\u202B\u206A\u202A\u206C\u200F\u200B\u202C\u206B\u202A\u200C\u206A\u202B\u202E\u200F\u206C\u206E\u206C\u200B\u206A\u206B\u206B\u202E\u202B\u206C\u206B\u206F\u200F\u200D\u206D\u202A\u200E\u206D\u202D\u202B\u200D\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			int num = FlandreThePsychoticandCuteGuestDef.\u202E\u200C\u206C\u200F\u206D\u202C\u206A\u200D\u206C\u202B\u200F\u206B\u206A\u206F\u206C\u206A\u200D\u200F\u202A\u202E\u200F\u200F\u206B\u206B\u206A\u206D\u206F\u202C\u200C\u200C\u200D\u202B\u200C\u202A\u206B\u206A\u206C\u200F\u200B\u200C\u202E(BepinexPlugin.sequenceTable, FlandreThePsychoticandCuteGuestDef.\u202A\u202B\u206E\u200D\u202D\u200D\u202D\u206C\u200E\u202A\u200D\u202A\u206C\u200F\u206E\u206D\u202C\u202B\u200B\u202C\u206D\u202E\u202C\u200D\u206E\u200C\u202A\u202A\u206F\u206B\u200C\u200B\u202A\u202E\u202E\u206F\u206B\u200B\u206E\u200E\u202E(typeof(CardConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			bool flag = true;
			string[][] array = new string[0][];
			string text2 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
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
			list.Add(ManaColor.Red);
			bool flag7 = false;
			ManaGroup manaGroup = new ManaGroup
			{
				Any = 1,
				Blue = 2,
				Red = 2
			};
			ManaGroup? manaGroup2 = new ManaGroup?(new ManaGroup
			{
				Blue = 2,
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
			int? num11 = new int?(1);
			int? num12 = null;
			int? num13 = new int?(12);
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
			IReadOnlyList<string> readOnlyList;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				List<string> list2 = new List<string>();
				list2.Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(462619751));
				readOnlyList = list2;
				list2.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2119522034));
			}
			else
			{
				List<string> list3 = new List<string>();
				list3.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2075729736));
				list3.Add(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1029400833));
				readOnlyList = list3;
				list3.Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-203703834));
			}
			IReadOnlyList<string> readOnlyList2;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				List<string> list4 = new List<string>();
				list4.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2075729736));
				readOnlyList2 = list4;
				list4.Add(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1634172600));
			}
			else
			{
				List<string> list5 = new List<string>();
				list5.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2075729736));
				list5.Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1941088925));
				readOnlyList2 = list5;
				list5.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871));
			}
			return new CardConfig(num, text, num2, flag, array, text2, text3, num3, flag2, flag3, flag4, flag5, flag6, rarity, cardType, targetType, list, flag7, manaGroup, manaGroup2, manaGroup3, manaGroup4, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14, manaGroup5, manaGroup6, num15, num16, num17, num18, num19, num20, num21, num22, num23, num24, num25, num26, num27, keyword, keyword2, flag8, keyword3, keyword4, readOnlyList, readOnlyList2, new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-188159725), new List<string>());
		}

		static CardImages \u202A\u202C\u202D\u202B\u206E\u202D\u200D\u206A\u200E\u202D\u206A\u202A\u202D\u200E\u200C\u206C\u206A\u206A\u206F\u206A\u200B\u206B\u200D\u206F\u200E\u200E\u200C\u200D\u202E\u206D\u202B\u200E\u200C\u202C\u200D\u202C\u200C\u202C\u200B\u202E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206D\u206D\u202E\u206F\u202A\u200D\u202B\u206B\u200C\u202E\u206B\u202A\u206C\u200B\u202B\u206E\u202E\u202A\u206B\u200E\u202A\u200B\u206F\u200F\u206E\u206F\u206D\u202A\u200F\u206F\u200E\u202D\u200E\u206F\u200D\u206A\u206E\u202C\u202E\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u206A\u202A\u206D\u202B\u206A\u202A\u206C\u200F\u200B\u202C\u206B\u202A\u200C\u206A\u202B\u202E\u200F\u206C\u206E\u206C\u200B\u206A\u206B\u206B\u202E\u202B\u206C\u206B\u206F\u200F\u200D\u206D\u202A\u200E\u206D\u202D\u202B\u200D\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u202B\u206E\u200D\u202D\u200D\u202D\u206C\u200E\u202A\u200D\u202A\u206C\u200F\u206E\u206D\u202C\u202B\u200B\u202C\u206D\u202E\u202C\u200D\u206E\u200C\u202A\u202A\u206F\u206B\u200C\u200B\u202A\u202E\u202E\u206F\u206B\u200B\u206E\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u200C\u206C\u200F\u206D\u202C\u206A\u200D\u206C\u202B\u200F\u206B\u206A\u206F\u206C\u206A\u200D\u200F\u202A\u202E\u200F\u200F\u206B\u206B\u206A\u206D\u206F\u202C\u200C\u200C\u200D\u202B\u200C\u202A\u206B\u206A\u206C\u200F\u200B\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreThePsychoticandCuteGuestDef))]
		public sealed class FlandreThePsychoticandCuteGuest : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreThePsychoticandCuteGuestDef.FlandreThePsychoticandCuteGuest.\u202A\u200C\u200D\u206A\u202A\u206A\u200B\u202C\u206F\u202B\u200B\u202D\u202B\u202B\u202B\u200F\u206E\u206D\u202A\u202C\u200F\u202B\u202C\u202D\u202D\u206D\u200D\u200E\u202A\u206B\u206E\u200E\u200F\u200C\u202B\u202D\u202C\u200B\u206C\u202D\u202E((float)FlandreThePsychoticandCuteGuestDef.FlandreThePsychoticandCuteGuest.\u202A\u202C\u202A\u202C\u206F\u206A\u202D\u200E\u202D\u200F\u202B\u202A\u200B\u206A\u202C\u200C\u206B\u202D\u200C\u200C\u200F\u206F\u200C\u200D\u202D\u206B\u206C\u206B\u206B\u206C\u206D\u202B\u200B\u200E\u202C\u200E\u200B\u202C\u206E\u200C\u202E(this).GetValueOrDefault() / 2f);
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
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-166193966), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0083;
				}
				IL_000C:
				int num = -1910679943;
				IL_0011:
				int num2 = num;
				switch ((2134943643 - (-num2 ^ ((-132290746 ^ -2090221135) - (1357517820 - -311946924))) * 1479382515) % 5)
				{
				case 0:
					IL_0083:
					num = ((!FlandreThePsychoticandCuteGuestDef.FlandreThePsychoticandCuteGuest.\u202C\u202D\u206D\u202D\u202C\u200C\u202E\u202C\u206C\u200F\u202D\u202B\u200F\u206D\u206C\u202E\u200E\u202C\u200C\u202E\u200D\u200F\u202A\u202C\u200D\u206B\u206C\u202C\u200E\u200F\u206E\u200C\u202E\u200F\u202C\u200C\u200E\u202E\u200B\u200E\u202E(this)) ? 65682079 : 350136389);
					goto IL_0011;
				case 1:
					return base.GetBaseDescription();
				case 2:
					goto IL_000C;
				case 3:
					return this.PhantasmModeDescription;
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreThePsychoticandCuteGuestDef.FlandreThePsychoticandCuteGuest.<Actions>d__7 <Actions>d__ = new FlandreThePsychoticandCuteGuestDef.FlandreThePsychoticandCuteGuest.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202A\u202C\u202A\u202C\u206F\u206A\u202D\u200E\u202D\u200F\u202B\u202A\u200B\u206A\u202C\u200C\u206B\u202D\u200C\u200C\u200F\u206F\u200C\u200D\u202D\u206B\u206C\u206B\u206B\u206C\u206D\u202B\u200B\u200E\u202C\u200E\u200B\u202C\u206E\u200C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202A\u200C\u200D\u206A\u202A\u206A\u200B\u202C\u206F\u202B\u200B\u202D\u202B\u202B\u202B\u200F\u206E\u206D\u202A\u202C\u200F\u202B\u202C\u202D\u202D\u206D\u200D\u200E\u202A\u206B\u206E\u200E\u200F\u200C\u202B\u202D\u202C\u200B\u206C\u202D\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u202C\u202D\u206D\u202D\u202C\u200C\u202E\u202C\u206C\u200F\u202D\u202B\u200F\u206D\u206C\u202E\u200E\u202C\u200C\u202E\u200D\u200F\u202A\u202C\u200D\u206B\u206C\u202C\u200E\u200F\u206E\u200C\u202E\u200F\u202C\u200C\u200E\u202E\u200B\u200E\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
