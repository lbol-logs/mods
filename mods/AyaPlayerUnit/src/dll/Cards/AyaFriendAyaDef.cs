using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation.UI;
using LBoL.Presentation.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaFriendAyaDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1449656198);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendAyaDef.\u200B\u206C\u202B\u206A\u200C\u206C\u202B\u200F\u200B\u206C\u200D\u206C\u200C\u200B\u202A\u202A\u202D\u200C\u202E\u200F\u200F\u202D\u202E\u206C\u202B\u202E\u206D\u206B\u202A\u202C\u206F\u200B\u206E\u202C\u200F\u202D\u200D\u200D\u202C\u202E\u202E(BepinexPlugin.embeddedSource);
			AyaFriendAyaDef.\u206F\u202D\u206A\u202E\u206C\u200D\u202B\u200F\u206E\u200B\u200D\u200F\u202A\u206B\u206F\u200C\u200D\u200F\u202A\u200D\u202A\u206D\u200E\u202A\u206E\u200E\u200D\u200F\u200B\u200B\u202D\u202C\u202E\u202C\u202E\u202C\u206C\u206E\u200F\u206A\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), true);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendAyaDef.\u200F\u202A\u206E\u202A\u206D\u206F\u206A\u202A\u202B\u202A\u200F\u202E\u202A\u206F\u200E\u202D\u200F\u206B\u200D\u202A\u206E\u200D\u200D\u200B\u200D\u200D\u202E\u206C\u206A\u200F\u202D\u200E\u200C\u200D\u200D\u202D\u206B\u206B\u206C\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendAyaDef.\u206C\u200B\u202E\u200E\u200B\u202D\u202C\u202D\u202A\u202D\u206E\u206F\u202A\u200D\u200C\u206A\u206A\u200C\u206B\u206E\u200C\u200E\u200B\u206A\u206C\u200D\u202C\u206B\u202A\u200D\u202B\u206E\u206B\u200B\u202A\u200D\u202B\u200D\u200E\u200E\u202E(BepinexPlugin.sequenceTable, AyaFriendAyaDef.\u202D\u200D\u202B\u202B\u202A\u206C\u206E\u202A\u202C\u206A\u202A\u200E\u206A\u200B\u202D\u206F\u206E\u202A\u200D\u206E\u200D\u206C\u202B\u200B\u206B\u200B\u202B\u200C\u202A\u206B\u202B\u206F\u202A\u200E\u206A\u200B\u202B\u206B\u200F\u202B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, false, !BepinexPlugin.Chapter1AyaPlayerUnit, false, false, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red,
				ManaColor.Green,
				ManaColor.Colorless,
				ManaColor.Philosophy
			}, false, new ManaGroup
			{
				White = 1,
				Blue = 1,
				Black = 1,
				Red = 1,
				Green = 1,
				Colorless = 1,
				Philosophy = 1
			}, null, null, null, null, new int?(50), null, null, null, null, null, new int?(40), null, new int?(10), null, null, null, null, null, null, new int?(0), null, new int?(-1), null, new int?(0), null, null, null, new int?(0), null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1317730711), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1317730711), false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(584695384), new List<string>());
		}

		static CardImages \u200B\u206C\u202B\u206A\u200C\u206C\u202B\u200F\u200B\u206C\u200D\u206C\u200C\u200B\u202A\u202A\u202D\u200C\u202E\u200F\u200F\u202D\u202E\u206C\u202B\u202E\u206D\u206B\u202A\u202C\u206F\u200B\u206E\u202C\u200F\u202D\u200D\u200D\u202C\u202E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u202D\u206A\u202E\u206C\u200D\u202B\u200F\u206E\u200B\u200D\u200F\u202A\u206B\u206F\u200C\u200D\u200F\u202A\u200D\u202A\u206D\u200E\u202A\u206E\u200E\u200D\u200F\u200B\u200B\u202D\u202C\u202E\u202C\u202E\u202C\u206C\u206E\u200F\u206A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u202A\u206E\u202A\u206D\u206F\u206A\u202A\u202B\u202A\u200F\u202E\u202A\u206F\u200E\u202D\u200F\u206B\u200D\u202A\u206E\u200D\u200D\u200B\u200D\u200D\u202E\u206C\u206A\u200F\u202D\u200E\u200C\u200D\u200D\u202D\u206B\u206B\u206C\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202D\u200D\u202B\u202B\u202A\u206C\u206E\u202A\u202C\u206A\u202A\u200E\u206A\u200B\u202D\u206F\u206E\u202A\u200D\u206E\u200D\u206C\u202B\u200B\u206B\u200B\u202B\u200C\u202A\u206B\u202B\u206F\u202A\u200E\u206A\u200B\u202B\u206B\u200F\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200B\u202E\u200E\u200B\u202D\u202C\u202D\u202A\u202D\u206E\u206F\u202A\u200D\u200C\u206A\u206A\u200C\u206B\u206E\u200C\u200E\u200B\u206A\u206C\u200D\u202C\u206B\u202A\u200D\u202B\u206E\u206B\u200B\u202A\u200D\u202B\u200D\u200E\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendAyaDef))]
		public sealed class AyaFriendAya : Card
		{
			private string ExtraDescription4
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1072650927), true, false);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u200C\u206E\u206C\u200D\u202A\u200E\u206E\u206E\u202B\u202B\u202D\u200E\u202B\u206C\u200C\u202B\u200C\u206C\u206A\u206C\u200C\u202B\u206A\u200E\u206A\u200F\u206E\u202B\u200F\u200F\u206F\u202E\u206F\u202C\u206F\u206E\u206E\u206E\u200B\u200D\u202E(AyaFriendAyaDef.AyaFriendAya.\u200F\u202A\u202B\u200C\u206D\u206B\u206E\u202D\u200E\u206F\u206C\u200C\u206B\u200B\u202D\u202E\u206F\u206B\u202D\u200C\u200D\u200C\u206D\u206C\u206E\u202B\u206B\u206E\u206B\u200D\u202B\u200E\u202B\u200E\u206E\u200F\u206E\u206A\u200B\u206B\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_023A;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text2;
					string text4;
					string text5;
					switch ((num3 = (uint)(-(uint)(-(uint)(~(uint)(~(uint)num))))) % 33U)
					{
					case 0U:
						num2 = ((base.BaseDetailText == null) ? 1722692294 : 1624208902);
						continue;
					case 1U:
						text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, this.ActiveUsed ? base.ExtraDescription2 : base.ExtraDescription1);
						num2 = 1411392650;
						continue;
					case 2U:
						text2 = base.ExtraDescription2;
						goto IL_0275;
					case 3U:
						goto IL_03E8;
					case 4U:
					{
						string text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 707324936;
						continue;
					}
					case 5U:
						text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, AyaFriendAyaDef.AyaFriendAya.\u200E\u206A\u206B\u206A\u200D\u206B\u206B\u200D\u206E\u206D\u200E\u202B\u202B\u206F\u200F\u200C\u202B\u206D\u206D\u200C\u202D\u202D\u200B\u206F\u202E\u200E\u202D\u206F\u200B\u202E\u200B\u206B\u202E\u200C\u206F\u202C\u206C\u206B\u202C\u200C\u202E(this) ? this.ExtraDescription4 : base.ExtraDescription3);
						num2 = 805998798;
						continue;
					case 6U:
						num2 = (int)((num3 * 3885012915U) ^ 3313740391U);
						continue;
					case 7U:
						switch (AyaFriendAyaDef.AyaFriendAya.\u206C\u200F\u200F\u206E\u200E\u200E\u206D\u200C\u202C\u202E\u200B\u200F\u200F\u206A\u200D\u200D\u202B\u206D\u200C\u202E\u202D\u202D\u202E\u202E\u200D\u206A\u206D\u202A\u200E\u206A\u202C\u202B\u202C\u200C\u202B\u206F\u202D\u202D\u206F\u202D\u202E(this))
						{
						case FriendToken.None:
							goto IL_03F8;
						case FriendToken.Active:
							goto IL_02A3;
						case FriendToken.Active2:
							goto IL_03E8;
						case FriendToken.Ultimate:
							goto IL_0121;
						default:
							num2 = (int)((num3 * 1354841388U) ^ 1959450848U);
							continue;
						}
						break;
					case 8U:
						text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						num2 = (int)((num3 * 1974758102U) ^ 1806794691U);
						continue;
					case 9U:
						goto IL_023A;
					case 10U:
						goto IL_02A3;
					case 11U:
						num2 = (int)((num3 * 2011370730U) ^ 395536158U);
						continue;
					case 12U:
						num2 = (int)((num3 * 405103861U) ^ 4035924858U);
						continue;
					case 13U:
						num2 = (int)((num3 * 2587408680U) ^ 2269608886U);
						continue;
					case 14U:
						goto IL_03AC;
					case 15U:
						num2 = (int)(((AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this) == null) ? 2613052774U : 3888475948U) ^ (num3 * 648578939U));
						continue;
					case 16U:
						text4 = base.ExtraDescription1;
						goto IL_0298;
					case 17U:
						num2 = (int)((num3 * 1954044287U) ^ 1657124966U);
						continue;
					case 18U:
						num2 = (AyaFriendAyaDef.AyaFriendAya.\u206A\u206B\u206D\u206C\u200D\u200E\u202E\u202D\u202A\u206E\u200B\u206C\u206A\u206C\u200B\u206C\u200E\u200E\u200E\u206F\u206E\u206A\u202A\u206A\u200B\u202E\u202B\u202D\u202B\u206B\u206B\u200E\u206B\u202E\u202E\u202A\u206E\u206D\u200B\u206A\u202E(this) ? 1409053457 : 761920160);
						continue;
					case 19U:
						text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1445071170));
						num2 = (int)((num3 * 2466234184U) ^ 2580519286U);
						continue;
					case 20U:
					{
						string text3;
						num2 = (((text3 = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription) != null) ? 707324936 : 210797041);
						continue;
					}
					case 21U:
						num2 = ((AyaFriendAyaDef.AyaFriendAya.\u200D\u202D\u206D\u202C\u206A\u200E\u206D\u206D\u206C\u206C\u202C\u200D\u206C\u206B\u202A\u202B\u200C\u206E\u200B\u202C\u202E\u200B\u200F\u202A\u206A\u202B\u206C\u200F\u206E\u202E\u206D\u206C\u206F\u200E\u202C\u202D\u200F\u200D\u200B\u202C\u202E(this) != 1) ? 446619649 : 691302643);
						continue;
					case 22U:
						text5 = base.BaseDescription;
						goto IL_0116;
					case 23U:
					{
						string text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 1686638591;
						continue;
					}
					case 24U:
						goto IL_0010;
					case 25U:
						num2 = (int)(((AyaFriendAyaDef.AyaFriendAya.\u200D\u202D\u206D\u202C\u206A\u200E\u206D\u206D\u206C\u206C\u202C\u200D\u206C\u206B\u202A\u202B\u200C\u206E\u200B\u202C\u202E\u200B\u200F\u202A\u206A\u202B\u206C\u200F\u206E\u202E\u206D\u206C\u206F\u200E\u202C\u202D\u200F\u200D\u200B\u202C\u202E(this) != 2) ? 3697026621U : 3365833195U) ^ (num3 * 2080546874U));
						continue;
					case 27U:
						goto IL_0121;
					case 28U:
						if (!AyaFriendAyaDef.AyaFriendAya.\u206A\u206B\u206D\u206C\u200D\u200E\u202E\u202D\u202A\u206E\u200B\u206C\u206A\u206C\u200B\u206C\u200E\u200E\u200E\u206F\u206E\u206A\u202A\u206A\u200B\u202E\u202B\u202D\u202B\u206B\u206B\u200E\u206B\u202E\u202E\u202A\u206E\u206D\u200B\u206A\u202E(this))
						{
							num2 = (int)((num3 * 2339249881U) ^ 865471425U);
							continue;
						}
						text5 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_0116;
					case 29U:
						if (!AyaFriendAyaDef.AyaFriendAya.\u206A\u206B\u206D\u206C\u200D\u200E\u202E\u202D\u202A\u206E\u200B\u206C\u206A\u206C\u200B\u206C\u200E\u200E\u200E\u206F\u206E\u206A\u202A\u206A\u200B\u202E\u202B\u202D\u202B\u206B\u206B\u200E\u206B\u202E\u202E\u202A\u206E\u206D\u200B\u206A\u202E(this))
						{
							num2 = 813445448;
							continue;
						}
						text2 = base.UpgradedExtraDescription2 ?? base.ExtraDescription2;
						goto IL_0275;
					case 30U:
						goto IL_03F8;
					case 31U:
						if (!AyaFriendAyaDef.AyaFriendAya.\u206A\u206B\u206D\u206C\u200D\u200E\u202E\u202D\u202A\u206E\u200B\u206C\u206A\u206C\u200B\u206C\u200E\u200E\u200E\u206F\u206E\u206A\u202A\u206A\u200B\u202E\u202B\u202D\u202B\u206B\u206B\u200E\u206B\u202E\u202E\u202A\u206E\u206D\u200B\u206A\u202E(this))
						{
							num2 = 1954559623;
							continue;
						}
						text4 = base.UpgradedExtraDescription1 ?? base.ExtraDescription1;
						goto IL_0298;
					case 32U:
					{
						string text3;
						text = text3;
						num2 = 805998798;
						continue;
					}
					}
					break;
					IL_0116:
					text = text5;
					num2 = 1270347315;
					continue;
					IL_0121:
					text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, AyaFriendAyaDef.AyaFriendAya.\u200E\u206A\u206B\u206A\u200D\u206B\u206B\u200D\u206E\u206D\u200E\u202B\u202B\u206F\u200F\u200C\u202B\u206D\u206D\u200C\u202D\u202D\u200B\u206F\u202E\u200E\u202D\u206F\u200B\u202E\u200B\u206B\u202E\u200C\u206F\u202C\u206C\u206B\u202C\u200C\u202E(this) ? this.ExtraDescription4 : base.ExtraDescription3);
					num2 = 418153572;
					continue;
					IL_0275:
					text = text2;
					num2 = 326440963;
					continue;
					IL_0298:
					text = text4;
					num2 = 805998798;
					continue;
					IL_02A3:
					text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, this.ActiveUsed ? base.ExtraDescription2 : base.ExtraDescription1);
					num2 = 805998798;
					continue;
					IL_03F8:
					text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, base.BaseDescription);
					text = AyaFriendAyaDef.AyaFriendAya.\u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
					num2 = 1775718352;
				}
				return text;
				IL_03AC:
				return string.Empty;
				IL_03E8:
				throw AyaFriendAyaDef.AyaFriendAya.\u202D\u200E\u206C\u202B\u206B\u200D\u206E\u202C\u200E\u206B\u206C\u206E\u206D\u202A\u202B\u200D\u206B\u202C\u200D\u200C\u206C\u202E\u202D\u206A\u200C\u200B\u200B\u206F\u200E\u206B\u202B\u206E\u202B\u202B\u200B\u206E\u202E\u200B\u206A\u202D\u202E();
				IL_0010:
				num2 = 1682713970;
				goto IL_0015;
				IL_023A:
				text = string.Empty;
				num2 = ((AyaFriendAyaDef.AyaFriendAya.\u200F\u202B\u202B\u206D\u200B\u202B\u200C\u200E\u200E\u200E\u200F\u206B\u206C\u200C\u202C\u202A\u200E\u206A\u200F\u200E\u202B\u206C\u202C\u202E\u206A\u206B\u200E\u200B\u202E\u202D\u206B\u206A\u202B\u202C\u206F\u202A\u200B\u202D\u202E\u200F\u202E(this) != CardType.Friend) ? 629907948 : 968000722);
				goto IL_0015;
			}

			public override string Name
			{
				get
				{
					return base.BaseName;
				}
			}

			public override DamageInfo Damage
			{
				get
				{
					return DamageInfo.Attack((float)AyaFriendAyaDef.AyaFriendAya.\u202B\u202B\u200E\u206E\u206A\u202C\u206A\u202B\u202E\u202A\u202D\u206B\u206C\u200F\u206B\u200C\u200D\u206C\u206B\u202D\u202C\u206C\u206A\u206E\u202C\u202D\u200E\u206E\u206F\u202A\u202B\u200C\u202E\u206A\u202C\u206D\u202E\u200E\u202A\u202C\u202E(this), true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u206A\u202D\u202A\u206F\u200B\u206A\u206F\u206A\u206E\u200F\u202E\u206C\u202E\u206F\u200C\u200E\u202C\u202D\u200F\u202A\u206B\u202A\u202A\u206D\u200F\u200B\u202D\u202D\u200C\u200F\u200C\u200E\u200E\u202E\u202C\u202B\u206A\u202B\u202C\u200F\u202E(key, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(998807149)))
				{
					for (;;)
					{
						IL_0017:
						int num = 1555617932;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(num2 - ((-1810409537 ^ 2001687154) + ((541795611 * 89317981) ^ (-1147545131 + 1199908860)))) - 1373594048))) % 5U)
							{
							case 0U:
								AyaFriendAyaDef.AyaFriendAya.\u206E\u206D\u202C\u202C\u202B\u206F\u202E\u206B\u202D\u202C\u200E\u200C\u202A\u202B\u200F\u206C\u200E\u202D\u206B\u200B\u206B\u206A\u200B\u202D\u206E\u202A\u202E\u206B\u202E\u200C\u200C\u202C\u206A\u200B\u202B\u202B\u200D\u206C\u206A\u206E\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1040566716)).RelativeEffects = new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(869176739) };
								num = (int)((num3 * 585889597U) ^ 3339941683U);
								continue;
							case 1U:
								AyaFriendAyaDef.AyaFriendAya.\u206E\u206D\u202C\u202C\u202B\u206F\u202E\u206B\u202D\u202C\u200E\u200C\u202A\u202B\u200F\u206C\u200E\u202D\u206B\u200B\u206B\u206A\u200B\u202D\u206E\u202A\u202E\u206B\u202E\u200C\u200C\u202C\u206A\u200B\u202B\u202B\u200D\u206C\u206A\u206E\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1461379082)).UpgradedRelativeEffects = new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-624132830) };
								num = (int)((num3 * 2968135818U) ^ 1356971481U);
								continue;
							case 2U:
								goto IL_0017;
							case 3U:
								AyaFriendAyaDef.AyaFriendAya.\u206E\u206D\u202C\u202C\u202B\u206F\u202E\u206B\u202D\u202C\u200E\u200C\u202A\u202B\u200F\u206C\u200E\u202D\u206B\u200B\u206B\u206A\u200B\u202D\u206E\u202A\u202E\u206B\u202E\u200C\u200C\u202C\u206A\u200B\u202B\u202B\u200D\u206C\u206A\u206E\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1449656198)).RelativeKeyword = Keyword.Upgrade | Keyword.Exile;
								AyaFriendAyaDef.AyaFriendAya.\u206E\u206D\u202C\u202C\u202B\u206F\u202E\u206B\u202D\u202C\u200E\u200C\u202A\u202B\u200F\u206C\u200E\u202D\u206B\u200B\u206B\u206A\u200B\u202D\u206E\u202A\u202E\u206B\u202E\u200C\u200C\u202C\u206A\u200B\u202B\u202B\u200D\u206C\u206A\u206E\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1040566716)).UpgradedRelativeKeyword = Keyword.Upgrade | Keyword.Exile;
								num = (int)((num3 * 451530048U) ^ 3065675838U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return TypeFactory<Card>.LocalizeProperty(AyaFriendAyaDef.AyaFriendAya.\u200C\u206D\u202A\u206C\u200E\u200E\u202C\u200E\u206E\u206F\u202C\u200C\u200E\u206C\u206A\u202B\u200D\u200E\u200C\u206B\u206D\u202A\u200F\u206A\u200F\u202D\u200C\u206F\u206A\u200F\u206C\u200E\u200F\u202A\u200C\u206A\u200D\u200F\u206A\u202E(this), key, decorated, required);
			}

			public FriendCostInfo FriendP2
			{
				get
				{
					return new FriendCostInfo(0, FriendCostType.Passive);
				}
			}

			public bool ActiveUsed { get; set; }

			public bool UltimateRepeat { get; set; }

			protected override void OnEnterBattle(BattleController battle)
			{
				if (AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence == 0)
				{
					goto IL_000A;
				}
				goto IL_00DB;
				int num2;
				for (;;)
				{
					IL_000F:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-976104365 - (-674717327 - -915397609 + 1130227836 * -614071983 - num * -27771197 + -1486702471))) % 7U)
					{
					case 1U:
						base.ReactBattleEvent<CardTransformEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202A\u202D\u202B\u206E\u206A\u202C\u206C\u202E\u206C\u200C\u206F\u206D\u200F\u206C\u202A\u206F\u202C\u200D\u202A\u200F\u206A\u206E\u200D\u206D\u206C\u200D\u202C\u206F\u206F\u200B\u200C\u206E\u202C\u202D\u206E\u206B\u206E\u200E\u206B\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardTransformEventArgs>(this.OnCardTransforming));
						num2 = (int)((num3 * 3218401476U) ^ 3685525262U);
						continue;
					case 2U:
						goto IL_00C3;
					case 3U:
						base.ReactBattleEvent<CardEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202B\u206D\u200E\u206C\u200C\u200D\u206E\u200C\u200B\u202E\u206F\u202E\u206A\u206F\u200C\u206F\u206F\u200B\u206A\u200F\u202B\u206F\u200D\u202A\u202E\u202A\u200D\u202E\u202D\u202C\u200C\u206E\u206D\u200E\u200F\u200D\u202A\u202A\u200E\u206E\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
						num2 = (int)((num3 * 3384760565U) ^ 974761278U);
						continue;
					case 4U:
						goto IL_00DB;
					case 5U:
						goto IL_000A;
					case 6U:
						base.ReactBattleEvent<UnitEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202E\u200C\u200D\u200F\u206E\u200B\u206E\u200F\u202A\u206E\u206A\u200C\u206E\u202D\u202B\u200B\u202D\u202E\u206B\u200B\u202E\u202C\u206B\u200F\u206B\u206E\u206C\u200F\u200F\u202C\u202A\u206A\u206B\u200C\u202A\u200F\u206D\u202C\u206D\u202E(AyaFriendAyaDef.AyaFriendAya.\u200C\u202A\u200F\u202A\u206E\u200F\u200B\u206C\u206D\u206A\u200C\u202D\u206C\u200E\u206E\u206F\u206F\u200B\u202D\u202B\u202D\u202A\u202B\u206F\u200B\u200F\u206D\u200E\u200C\u200E\u200B\u202B\u200C\u202B\u200E\u200D\u202E\u200E\u206C\u206A\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
						base.ReactBattleEvent<UnitEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202B\u202C\u200E\u200C\u200D\u202E\u202B\u200C\u206A\u206E\u206F\u200D\u206F\u206F\u206C\u202A\u206D\u200D\u206C\u200D\u206E\u200F\u200D\u200D\u206C\u202B\u202C\u206E\u200E\u206D\u200E\u202D\u206F\u206D\u202C\u206A\u206D\u200B\u206B\u206F\u202E(AyaFriendAyaDef.AyaFriendAya.\u200C\u202A\u200F\u202A\u206E\u200F\u200B\u206C\u206D\u206A\u200C\u202D\u206C\u200E\u206E\u206F\u206F\u200B\u202D\u202B\u202D\u202A\u202B\u206F\u200B\u200F\u206D\u200E\u200C\u200E\u200B\u202B\u200C\u202B\u200E\u200D\u202E\u200E\u206C\u206A\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnded));
						num2 = (int)((num3 * 1210129494U) ^ 2227088502U);
						continue;
					}
					break;
				}
				return;
				IL_00C3:
				throw AyaFriendAyaDef.AyaFriendAya.\u200E\u206F\u206D\u206A\u202C\u206B\u206B\u200E\u206F\u202D\u202B\u202C\u200C\u202A\u202B\u200C\u202C\u202D\u200E\u206A\u206C\u200C\u200E\u206C\u206C\u202A\u206C\u202D\u206B\u200C\u200F\u206D\u202A\u202D\u200C\u206F\u202C\u202E\u200C\u202E\u202E();
				IL_000A:
				num2 = -133214716;
				goto IL_000F;
				IL_00DB:
				base.ReactBattleEvent<CardMovingEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202B\u202D\u200D\u202E\u202B\u200E\u200B\u200F\u206A\u200D\u206E\u206B\u200F\u202A\u200C\u200B\u206C\u200C\u206C\u206B\u202C\u200E\u206E\u206C\u206C\u202E\u206A\u200E\u200E\u202E\u206D\u206B\u200C\u202D\u202A\u206D\u202B\u202D\u206C\u202D\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardMovingEventArgs>(this.OnCardMoving));
				base.ReactBattleEvent<CardMovingToDrawZoneEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u202E\u202E\u202D\u206F\u200F\u206F\u206B\u202C\u206A\u206E\u202B\u206E\u206C\u200C\u206C\u206F\u200D\u206C\u202C\u200F\u206C\u202A\u200E\u206B\u202D\u200C\u206F\u202B\u200E\u206D\u202A\u206D\u200F\u206D\u202E\u202C\u206D\u206B\u206D\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone));
				base.ReactBattleEvent<CardEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u200F\u206A\u200C\u202A\u206C\u206F\u202D\u202D\u200D\u202A\u206A\u206F\u206E\u202B\u206F\u200E\u200E\u202C\u206B\u200C\u206D\u202C\u200F\u206F\u206C\u206C\u202A\u200B\u206C\u206E\u202A\u202A\u206F\u206C\u200D\u206A\u200B\u206A\u202C\u202C\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
				base.ReactBattleEvent<CardEventArgs>(AyaFriendAyaDef.AyaFriendAya.\u206C\u200E\u206C\u200F\u206A\u200F\u206A\u202A\u202D\u206C\u200F\u200F\u200E\u200C\u202E\u206B\u206C\u200F\u200C\u206F\u206C\u200F\u202C\u206E\u202C\u206B\u202D\u206D\u200C\u206A\u200B\u200B\u202E\u206B\u200F\u202E\u200C\u202C\u202C\u202C\u202E(AyaFriendAyaDef.AyaFriendAya.\u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
				num2 = -52890588;
				goto IL_000F;
			}

			private IEnumerable<BattleAction> OnCardMoving(CardMovingEventArgs args)
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u200F\u200F\u200F\u202E\u202A\u206F\u200C\u200C\u200C\u200C\u200B\u206C\u202E\u206C\u202C\u202C\u202E\u206B\u206A\u202D\u202A\u202C\u200F\u202B\u200C\u202E\u202C\u202E\u200F\u200D\u202B\u206E\u206D\u202D\u202B\u202C\u202A\u206E\u206C\u202D\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 2039324335;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(-(uint)(~num2 + (395220922 - ~2045468344))))) % 5U)
							{
							case 0U:
								num = (int)(((AyaFriendAyaDef.AyaFriendAya.\u202B\u202B\u202A\u202E\u206D\u206C\u206E\u202D\u200D\u202C\u200B\u200D\u206E\u200C\u200E\u202B\u206F\u200B\u202D\u206E\u200B\u206D\u200D\u202D\u206E\u200D\u202C\u206A\u202E\u200D\u206F\u206E\u202D\u202D\u202D\u200B\u206B\u206E\u200B\u200F\u202E(args) != this) ? 3055339099U : 2943865252U) ^ (num3 * 291279160U));
								continue;
							case 1U:
								num = (int)(((!(AyaFriendAyaDef.AyaFriendAya.\u202B\u202B\u202A\u202E\u206D\u206C\u206E\u202D\u200D\u202C\u200B\u200D\u206E\u200C\u200E\u202B\u206F\u200B\u202D\u206E\u200B\u206D\u200D\u202D\u206E\u200D\u202C\u206A\u202E\u200D\u206F\u206E\u202D\u202D\u202D\u200B\u206B\u206E\u200B\u200F\u202E(args) is AyaPlayerUnitDef.AyaPlayerUnit)) ? 3714299038U : 3137270980U) ^ (num3 * 1004805376U));
								continue;
							case 2U:
								goto IL_000C;
							case 3U:
								AyaFriendAyaDef.AyaFriendAya.\u206A\u200D\u202C\u202A\u200F\u202C\u206E\u202C\u200B\u200C\u202E\u200C\u202D\u206B\u200C\u200B\u202C\u200B\u202E\u206F\u202B\u206F\u202C\u202B\u206F\u206E\u202C\u202A\u202B\u202C\u206A\u206F\u200D\u200E\u206D\u206A\u202E\u202C\u206E\u202B\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 3485747452U) ^ 1889158624U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return null;
			}

			private IEnumerable<BattleAction> OnCardMovingToDrawZone(CardMovingToDrawZoneEventArgs args)
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u202A\u202B\u206A\u200F\u206B\u202B\u206C\u202C\u206A\u200D\u206C\u200F\u200D\u200D\u200E\u200B\u202A\u200E\u202A\u206D\u200D\u202A\u202C\u206D\u202D\u202A\u200F\u200C\u200E\u200C\u202E\u206C\u200C\u202D\u202C\u206A\u200E\u206D\u206E\u206C\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = -2023779157;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(num2 - (--1063253406 + --607312830 + (-1771252435 * 1121495094 - (-236549499 + 1896119689)))))) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 1U:
								AyaFriendAyaDef.AyaFriendAya.\u206A\u200D\u202C\u202A\u200F\u202C\u206E\u202C\u200B\u200C\u202E\u200C\u202D\u206B\u200C\u200B\u202C\u200B\u202E\u206F\u202B\u206F\u202C\u202B\u206F\u206E\u202C\u202A\u202B\u202C\u206A\u206F\u200D\u200E\u206D\u206A\u202E\u202C\u206E\u202B\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 1479862433U) ^ 3007462816U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return null;
			}

			private IEnumerable<BattleAction> OnCardLeaving(CardEventArgs args)
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u206A\u200C\u206A\u202A\u206A\u206B\u206E\u200E\u200E\u200E\u206C\u200E\u202C\u202A\u206A\u206E\u200D\u202E\u200F\u200E\u206D\u206F\u202D\u206A\u202A\u206A\u206C\u206E\u206A\u206C\u206F\u200D\u200F\u200C\u202B\u202B\u206A\u202D\u202A\u206C\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = -800561304;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-num2 + -1355584777 * ~1269241515))) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 2U:
								AyaFriendAyaDef.AyaFriendAya.\u206A\u200D\u202C\u202A\u200F\u202C\u206E\u202C\u200B\u200C\u202E\u200C\u202D\u206B\u200C\u200B\u202C\u200B\u202E\u206F\u202B\u206F\u202C\u202B\u206F\u206E\u202C\u202A\u202B\u202C\u206A\u206F\u200D\u200E\u206D\u206A\u202E\u202C\u206E\u202B\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 3290351630U) ^ 924490529U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return null;
			}

			private IEnumerable<BattleAction> OnCardTransforming(CardTransformEventArgs args)
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u202A\u200F\u206C\u200E\u202C\u200B\u202E\u202C\u206E\u206B\u200F\u206C\u200D\u200E\u200F\u200B\u206E\u200F\u206F\u206A\u206E\u200C\u202E\u200C\u200D\u202C\u202A\u202B\u206B\u206E\u206E\u206C\u200D\u202C\u202A\u206F\u200D\u200E\u206B\u202B\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = -1706433221;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-930322480 - (1879760034 ^ -491171065) - -num2) * 1598892871 - 1034209073)) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 1U:
								AyaFriendAyaDef.AyaFriendAya.\u206A\u200D\u202C\u202A\u200F\u202C\u206E\u202C\u200B\u200C\u202E\u200C\u202D\u206B\u200C\u200B\u202C\u200B\u202E\u206F\u202B\u206F\u202C\u202B\u206F\u206E\u202C\u202A\u202B\u202C\u206A\u206F\u200D\u200E\u206D\u206A\u202E\u202C\u206E\u202B\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 2085906684U) ^ 1190866012U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return null;
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				this.ActiveUsed = false;
				return AyaFriendAyaDef.AyaFriendAya.\u206B\u206C\u206E\u206C\u206A\u206D\u206E\u200E\u200E\u206C\u202B\u202B\u202E\u202D\u200E\u200C\u206C\u206E\u206F\u200D\u200B\u206C\u202E\u206C\u202D\u202B\u202C\u206F\u206E\u206E\u200C\u202A\u202C\u200D\u206A\u202A\u206C\u200F\u206B\u202E\u202E(this);
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnded(UnitEventArgs args)
			{
				AyaFriendAyaDef.AyaFriendAya.<OnPlayerTurnEnded>d__27 <OnPlayerTurnEnded>d__ = new AyaFriendAyaDef.AyaFriendAya.<OnPlayerTurnEnded>d__27(-2);
				<OnPlayerTurnEnded>d__.<>4__this = this;
				return <OnPlayerTurnEnded>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaFriendAyaDef.AyaFriendAya.<GetPassiveActions>d__28 <GetPassiveActions>d__ = new AyaFriendAyaDef.AyaFriendAya.<GetPassiveActions>d__28(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendAyaDef.AyaFriendAya.<SummonActions>d__30 <SummonActions>d__ = new AyaFriendAyaDef.AyaFriendAya.<SummonActions>d__30(-2);
				<SummonActions>d__.<>4__this = this;
				<SummonActions>d__.<>3__selector = selector;
				<SummonActions>d__.<>3__consumingMana = consumingMana;
				<SummonActions>d__.<>3__precondition = precondition;
				return <SummonActions>d__;
			}

			public override Interaction Precondition()
			{
				if (AyaFriendAyaDef.AyaFriendAya.\u200F\u202B\u202B\u206D\u200B\u202B\u200C\u200E\u200E\u200E\u200F\u206B\u206C\u200C\u202C\u202A\u200E\u206A\u200F\u200E\u202B\u206C\u202C\u202E\u206A\u206B\u200E\u200B\u202E\u202D\u206B\u206A\u202B\u202C\u206F\u202A\u200B\u202D\u202E\u200F\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list2;
					List<Card> list;
					for (;;)
					{
						IL_000C:
						int num = -114805013;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(~num2) * -1688074527)) % 19U)
							{
							case 0U:
								list = AyaFriendAyaDef.AyaFriendAya.\u202C\u202A\u202D\u206F\u206E\u200B\u206F\u206B\u206B\u202A\u202C\u206D\u202E\u206B\u206E\u206B\u200F\u200D\u202E\u206F\u202A\u202E\u202A\u200E\u206C\u206F\u200D\u206C\u206B\u202D\u202E\u200B\u200B\u206B\u206B\u200D\u200D\u206E\u202B\u206F\u202E(this, list2.Count, false).ToList<Card>();
								num = 1369201527;
								continue;
							case 1U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 1000604193U : 4175844851U) ^ (num3 * 887523089U));
								continue;
							}
							case 2U:
								num = (int)((this.ActiveUsed ? 235971541U : 2005352946U) ^ (num3 * 1593818750U));
								continue;
							case 3U:
								list2.Add(FriendToken.Active2);
								num = (int)((num3 * 141464894U) ^ 1488988781U);
								continue;
							case 4U:
							{
								int? num4 = AyaFriendAyaDef.AyaFriendAya.\u200F\u206A\u200F\u202E\u200F\u206E\u206D\u200E\u206C\u206D\u200C\u202A\u206D\u200B\u200F\u206E\u202C\u202B\u206B\u202C\u202D\u200C\u206B\u206B\u200F\u200D\u200D\u206E\u202D\u200C\u200D\u206E\u200B\u206D\u200E\u202E\u202B\u206E\u200E\u202A\u202E(AyaFriendAyaDef.AyaFriendAya.\u200F\u202A\u202B\u200C\u206D\u206B\u206E\u202D\u200E\u206F\u206C\u200C\u206B\u200B\u202D\u202E\u206F\u206B\u202D\u200C\u200D\u200C\u206D\u206C\u206E\u202B\u206B\u206E\u206B\u200D\u202B\u200E\u202B\u200E\u206E\u200F\u206E\u206A\u200B\u206B\u202E(this));
								num = (int)((num3 * 476581522U) ^ 4273577572U);
								continue;
							}
							case 5U:
								num = (int)(((AyaFriendAyaDef.AyaFriendAya.\u206B\u200D\u200F\u200C\u202C\u200E\u202C\u202D\u206E\u206A\u200B\u200C\u202A\u202C\u200C\u200E\u206E\u202D\u202D\u200D\u202B\u200D\u200B\u202B\u206F\u206E\u202E\u206A\u200B\u206E\u200F\u200F\u200B\u206F\u202A\u202C\u200B\u202E\u202B\u200E\u202E(this) >= -AyaFriendAyaDef.AyaFriendAya.\u202C\u200D\u202D\u200B\u200B\u202B\u206C\u200C\u200C\u202C\u206A\u202B\u200E\u206C\u206A\u206D\u200E\u202D\u200F\u200E\u202A\u200D\u202C\u200E\u206A\u202A\u200E\u206F\u202E\u200E\u200D\u206C\u200C\u206B\u200C\u206B\u202D\u206C\u206E\u202D\u202E(this)) ? 3565096486U : 588569626U) ^ (num3 * 108361444U));
								continue;
							case 6U:
								if (AyaFriendAyaDef.AyaFriendAya.\u206B\u200D\u200F\u200C\u202C\u200E\u202C\u202D\u206E\u206A\u200B\u200C\u202A\u202C\u200C\u200E\u206E\u202D\u202D\u200D\u202B\u200D\u200B\u202B\u206F\u206E\u202E\u206A\u200B\u206E\u200F\u200F\u200B\u206F\u202A\u202C\u200B\u202E\u202B\u200E\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 3956403407U) ^ 1306736164U);
									continue;
								}
								goto IL_0385;
							case 7U:
								num = ((!AyaFriendAyaDef.AyaFriendAya.\u200E\u206A\u206B\u206A\u200D\u206B\u206B\u200D\u206E\u206D\u200E\u202B\u202B\u206F\u200F\u200C\u202B\u206D\u206D\u200C\u202D\u202D\u200B\u206F\u202E\u200E\u202D\u206F\u200B\u202E\u200B\u206B\u202E\u200C\u206F\u202C\u206C\u206B\u202C\u200C\u202E(this)) ? (-1185967600) : 277068798);
								continue;
							case 8U:
								list2.Add(FriendToken.Ultimate);
								num = (int)((num3 * 2958401571U) ^ 2664830264U);
								continue;
							case 9U:
							{
								int? num4 = AyaFriendAyaDef.AyaFriendAya.\u206D\u202D\u202E\u206E\u202D\u206F\u200D\u206E\u206C\u206D\u200B\u202D\u202D\u200B\u206A\u202C\u206B\u206D\u202D\u202C\u206E\u200D\u206E\u202D\u200C\u200D\u202C\u200D\u206E\u200B\u206A\u206F\u202B\u202D\u206B\u202E\u202E\u206B\u206A\u206A\u202E(AyaFriendAyaDef.AyaFriendAya.\u200F\u202A\u202B\u200C\u206D\u206B\u206E\u202D\u200E\u206F\u206C\u200C\u206B\u200B\u202D\u202E\u206F\u206B\u202D\u200C\u200D\u200C\u206D\u206C\u206E\u202B\u206B\u206E\u206B\u200D\u202B\u200E\u202B\u200E\u206E\u200F\u206E\u206A\u200B\u206B\u202E(this));
								num = ((num4 != null) ? 300045844 : (-1752398627));
								continue;
							}
							case 11U:
								goto IL_000C;
							case 12U:
								list2 = new List<FriendToken>();
								num = (int)((num3 * 1493277743U) ^ 1281401672U);
								continue;
							case 13U:
								list2.Add(FriendToken.Active);
								num = (int)((num3 * 3875913477U) ^ 1675828175U);
								continue;
							case 14U:
								num = (int)(((AyaFriendAyaDef.AyaFriendAya.\u206B\u200D\u200F\u200C\u202C\u200E\u202C\u202D\u206E\u206A\u200B\u200C\u202A\u202C\u200C\u200E\u206E\u202D\u202D\u200D\u202B\u200D\u200B\u202B\u206F\u206E\u202E\u206A\u200B\u206E\u200F\u200F\u200B\u206F\u202A\u202C\u200B\u202E\u202B\u200E\u202E(this) >= -AyaFriendAyaDef.AyaFriendAya.\u206B\u200B\u206E\u202C\u206B\u206C\u200E\u200F\u206A\u200B\u206F\u202E\u206D\u206F\u206B\u206C\u200E\u200E\u200B\u206B\u202E\u202C\u206E\u200B\u202A\u202D\u202D\u202C\u206E\u202D\u202D\u202B\u206C\u206F\u206A\u202B\u200C\u200E\u206E\u200E\u202E(this)) ? 2262443464U : 3337150397U) ^ (num3 * 35036664U));
								continue;
							case 15U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 1346420382U : 1039943169U) ^ (num3 * 1841663007U));
								continue;
							}
							case 16U:
							{
								int? num4 = AyaFriendAyaDef.AyaFriendAya.\u206F\u200E\u206D\u206C\u200B\u200B\u206A\u202A\u202A\u206C\u202D\u202D\u202A\u206B\u202A\u200E\u202C\u206D\u200E\u206A\u200F\u202E\u200B\u202A\u202A\u200C\u206E\u202C\u202D\u206A\u206E\u200F\u202A\u202D\u206A\u206A\u206C\u200F\u206B\u200C\u202E(AyaFriendAyaDef.AyaFriendAya.\u200F\u202A\u202B\u200C\u206D\u206B\u206E\u202D\u200E\u206F\u206C\u200C\u206B\u200B\u202D\u202E\u206F\u206B\u202D\u200C\u200D\u200C\u206D\u206C\u206E\u202B\u206B\u206E\u206B\u200D\u202B\u200E\u202B\u200E\u206E\u200F\u206E\u206A\u200B\u206B\u202E(this));
								num = (int)((num3 * 1431073503U) ^ 2190421840U);
								continue;
							}
							case 17U:
								num = (int)(((AyaFriendAyaDef.AyaFriendAya.\u206B\u200D\u200F\u200C\u202C\u200E\u202C\u202D\u206E\u206A\u200B\u200C\u202A\u202C\u200C\u200E\u206E\u202D\u202D\u200D\u202B\u200D\u200B\u202B\u206F\u206E\u202E\u206A\u200B\u206E\u200F\u200F\u200B\u206F\u202A\u202C\u200B\u202E\u202B\u200E\u202E(this) < -AyaFriendAyaDef.AyaFriendAya.\u202A\u202E\u206A\u206C\u200E\u202E\u206C\u206E\u200B\u206F\u206F\u200B\u206F\u200C\u206F\u206C\u202E\u206E\u206A\u200C\u206C\u200C\u200E\u206E\u200C\u206A\u206B\u206C\u206B\u200E\u202A\u200B\u202D\u200C\u206D\u200F\u206F\u200C\u206E\u200E\u202E(this)) ? 4224228596U : 312743667U) ^ (num3 * 248088327U));
								continue;
							case 18U:
								if (AyaFriendAyaDef.AyaFriendAya.\u206E\u206D\u202D\u200B\u202B\u202C\u206B\u202C\u202D\u206C\u206B\u200B\u206E\u206D\u200B\u206F\u200E\u200C\u206E\u202D\u202B\u200B\u202E\u202D\u202D\u202B\u200E\u202A\u206A\u206F\u200E\u206A\u200E\u200E\u200E\u202E\u206D\u206D\u202C\u206B\u202E(this))
								{
									num = (int)((num3 * 3090491190U) ^ 1893889764U);
									continue;
								}
								goto IL_0385;
							}
							goto Block_1;
						}
					}
					Block_1:
					IEnumerator<ValueTuple<int, FriendToken>> enumerator = list2.WithIndices<FriendToken>().GetEnumerator();
					try
					{
						for (;;)
						{
							IL_031D:
							int num5 = (AyaFriendAyaDef.AyaFriendAya.\u206C\u206B\u202E\u202D\u200B\u200D\u202D\u202A\u206A\u200E\u200E\u202B\u202A\u202E\u202A\u206C\u200D\u200D\u206C\u200F\u206F\u206B\u202A\u206A\u206E\u200E\u200E\u206F\u202A\u206F\u206A\u206D\u206A\u200F\u202E\u200B\u202C\u206B\u206E\u200F\u202E(enumerator) ? 1086411945 : 13041631);
							for (;;)
							{
								int num2 = num5;
								switch (~(~num2) * -1688074527 % 4)
								{
								case 0:
									num5 = 1086411945;
									continue;
								case 1:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									AyaFriendAyaDef.AyaFriendAya.\u206D\u202C\u206F\u206E\u202B\u206E\u206E\u200B\u200D\u202D\u206A\u202E\u206F\u202A\u202D\u200E\u206A\u200F\u200D\u202E\u200B\u200D\u202C\u206E\u200B\u200C\u202B\u202E\u202B\u200E\u202C\u202E\u206C\u206B\u200F\u206B\u202E\u206E\u200D\u202D\u202E(list[item], item2);
									num5 = 1563560162;
									continue;
								}
								case 2:
									goto IL_031D;
								}
								goto Block_14;
							}
						}
						Block_14:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_033B:
								int num6 = 341491242;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(~(~num2) * -1688074527)) % 3U)
									{
									case 1U:
										AyaFriendAyaDef.AyaFriendAya.\u206B\u200D\u206B\u200C\u202C\u206B\u200F\u206B\u202D\u200C\u206C\u200E\u202D\u206D\u206A\u202A\u200C\u202A\u200C\u206E\u206E\u206E\u206D\u200C\u202E\u206D\u206F\u200F\u202D\u206C\u200B\u202B\u206D\u200D\u200B\u200C\u200C\u200C\u206F\u206E\u202E(enumerator);
										num6 = (int)((num3 * 707379212U) ^ 2882138705U);
										continue;
									case 2U:
										goto IL_033B;
									}
									goto Block_17;
								}
							}
							Block_17:;
						}
					}
					return AyaFriendAyaDef.AyaFriendAya.\u200B\u202B\u200E\u202B\u202B\u206C\u206C\u200C\u202E\u200E\u200B\u200C\u200B\u200D\u200B\u202A\u206F\u202A\u206A\u206E\u206A\u202C\u202D\u202D\u200D\u200E\u200B\u200C\u206E\u202A\u202A\u202C\u200D\u202C\u202E\u202B\u200F\u200D\u206F\u206E\u202E(list, false, false, false);
				}
				IL_0385:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendAyaDef.AyaFriendAya.<Actions>d__32 <Actions>d__ = new AyaFriendAyaDef.AyaFriendAya.<Actions>d__32(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				<Actions>d__.<>3__consumingMana = consumingMana;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			private IEnumerable<BattleAction> coroutine(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendAyaDef.AyaFriendAya.<coroutine>d__33 <coroutine>d__ = new AyaFriendAyaDef.AyaFriendAya.<coroutine>d__33(-2);
				<coroutine>d__.<>4__this = this;
				return <coroutine>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				AyaFriendAyaDef.AyaFriendAya.<AfterUseAction>d__34 <AfterUseAction>d__ = new AyaFriendAyaDef.AyaFriendAya.<AfterUseAction>d__34(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			protected override void OnLeaveBattle()
			{
				AyaFriendAyaDef.AyaFriendAya.\u202D\u202A\u206A\u202D\u206F\u206E\u200E\u202D\u206D\u200D\u202B\u202C\u202E\u202B\u206E\u206F\u200E\u200E\u206F\u200E\u202E\u200C\u200B\u206D\u206E\u200D\u206C\u200E\u206A\u202A\u206C\u206C\u200F\u202B\u202E\u202E\u200C\u206C\u200C\u202E\u202E(AyaFriendAyaDef.AyaFriendAya.background, false);
				for (;;)
				{
					IL_000B:
					int num = 1118802273;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-2006953939 - ((num2 - -(-2008730242) * -697580567) * 1639245639 - (-1364356626 - 1987119641)))) % 3U)
						{
						case 1U:
							AyaFriendAyaDef.AyaFriendAya.LastWord = false;
							num = (int)((num3 * 3789732601U) ^ 3563586987U);
							continue;
						case 2U:
							goto IL_000B;
						}
						return;
					}
				}
			}

			[CompilerGenerated]
			private IEnumerator <coroutine>g__coroutine|33_8(UnitView unitView, UnitView unitView1, UnitView unitView2, UnitView unitView3, UnitView unitView4, UnitView unitView5, UnitView unitView6, UnitView unitView7)
			{
				AyaFriendAyaDef.AyaFriendAya.<<coroutine>g__coroutine|33_8>d <<coroutine>g__coroutine|33_8>d = new AyaFriendAyaDef.AyaFriendAya.<<coroutine>g__coroutine|33_8>d(0);
				<<coroutine>g__coroutine|33_8>d.<>4__this = this;
				<<coroutine>g__coroutine|33_8>d.unitView = unitView;
				<<coroutine>g__coroutine|33_8>d.unitView1 = unitView1;
				<<coroutine>g__coroutine|33_8>d.unitView2 = unitView2;
				<<coroutine>g__coroutine|33_8>d.unitView3 = unitView3;
				<<coroutine>g__coroutine|33_8>d.unitView4 = unitView4;
				<<coroutine>g__coroutine|33_8>d.unitView5 = unitView5;
				<<coroutine>g__coroutine|33_8>d.unitView6 = unitView6;
				<<coroutine>g__coroutine|33_8>d.unitView7 = unitView7;
				return <<coroutine>g__coroutine|33_8>d;
			}

			[CompilerGenerated]
			private IEnumerator <coroutine>g__coroutine2|33_9(UnitView unitView)
			{
				AyaFriendAyaDef.AyaFriendAya.<<coroutine>g__coroutine2|33_9>d <<coroutine>g__coroutine2|33_9>d = new AyaFriendAyaDef.AyaFriendAya.<<coroutine>g__coroutine2|33_9>d(0);
				<<coroutine>g__coroutine2|33_9>d.<>4__this = this;
				<<coroutine>g__coroutine2|33_9>d.unitView = unitView;
				return <<coroutine>g__coroutine2|33_9>d;
			}

			static CardConfig \u200F\u202A\u202B\u200C\u206D\u206B\u206E\u202D\u200E\u206F\u206C\u200C\u206B\u200B\u202D\u202E\u206F\u206B\u202D\u200C\u200D\u200C\u206D\u206C\u206E\u202B\u206B\u206E\u206B\u200D\u202B\u200E\u202B\u200E\u206E\u200F\u206E\u206A\u200B\u206B\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u200C\u206E\u206C\u200D\u202A\u200E\u206E\u206E\u202B\u202B\u202D\u200E\u202B\u206C\u200C\u202B\u200C\u206C\u206A\u206C\u200C\u202B\u206A\u200E\u206A\u200F\u206E\u202B\u200F\u200F\u206F\u202E\u206F\u202C\u206F\u206E\u206E\u206E\u200B\u200D\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u200F\u202B\u202B\u206D\u200B\u202B\u200C\u200E\u200E\u200E\u200F\u206B\u206C\u200C\u202C\u202A\u200E\u206A\u200F\u200E\u202B\u206C\u202C\u202E\u206A\u206B\u200E\u200B\u202E\u202D\u206B\u206A\u202B\u202C\u206F\u202A\u200B\u202D\u202E\u200F\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u206C\u200F\u200F\u206E\u200E\u200E\u206D\u200C\u202C\u202E\u200B\u200F\u200F\u206A\u200D\u200D\u202B\u206D\u200C\u202E\u202D\u202D\u202E\u202E\u200D\u206A\u206D\u202A\u200E\u206A\u202C\u202B\u202C\u200C\u202B\u206F\u202D\u202D\u206F\u202D\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static string \u202D\u200C\u202C\u200F\u202B\u200B\u200C\u206C\u206E\u206B\u202C\u202B\u200C\u200E\u202D\u202A\u202D\u202B\u206E\u202D\u206E\u202D\u202D\u202A\u206A\u200D\u202B\u206C\u200B\u206F\u200C\u202C\u206F\u202E\u202C\u200C\u200C\u200E\u206A\u206F\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static bool \u200E\u206A\u206B\u206A\u200D\u206B\u206B\u200D\u206E\u206D\u200E\u202B\u202B\u206F\u200F\u200C\u202B\u206D\u206D\u200C\u202D\u202D\u200B\u206F\u202E\u200E\u202D\u206F\u200B\u202E\u200B\u206B\u202E\u200C\u206F\u202C\u206C\u206B\u202C\u200C\u202E(Card A_0)
			{
				return A_0.UltimateUsed;
			}

			static ArgumentOutOfRangeException \u202D\u200E\u206C\u202B\u206B\u200D\u206E\u202C\u200E\u206B\u206C\u206E\u206D\u202A\u202B\u200D\u206B\u202C\u200D\u200C\u206C\u202E\u202D\u206A\u200C\u200B\u200B\u206F\u200E\u206B\u202B\u206E\u202B\u202B\u200B\u206E\u202E\u200B\u206A\u202D\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200D\u202D\u206D\u202C\u206A\u200E\u206D\u206D\u206C\u206C\u202C\u200D\u206C\u206B\u202A\u202B\u200C\u206E\u200B\u202C\u202E\u200B\u200F\u202A\u206A\u202B\u206C\u200F\u206E\u202E\u206D\u206C\u206F\u200E\u202C\u202D\u200F\u200D\u200B\u202C\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static BattleController \u200E\u206D\u206D\u200F\u206E\u200E\u200E\u200C\u206F\u202A\u206B\u200C\u206E\u206D\u206E\u200C\u202D\u206D\u200B\u206A\u202E\u202B\u202C\u202D\u200B\u206D\u206C\u200C\u200C\u202A\u202B\u202C\u206B\u202B\u200F\u202A\u202E\u206F\u206B\u206F\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u206A\u206B\u206D\u206C\u200D\u200E\u202E\u202D\u202A\u206E\u200B\u206C\u206A\u206C\u200B\u206C\u200E\u200E\u200E\u206F\u206E\u206A\u202A\u206A\u200B\u202E\u202B\u202D\u202B\u206B\u206B\u200E\u206B\u202E\u202E\u202A\u206E\u206D\u200B\u206A\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static int \u202B\u202B\u200E\u206E\u206A\u202C\u206A\u202B\u202E\u202A\u202D\u206B\u206C\u200F\u206B\u200C\u200D\u206C\u206B\u202D\u202C\u206C\u206A\u206E\u202C\u202D\u200E\u206E\u206F\u202A\u202B\u200C\u202E\u206A\u202C\u206D\u202E\u200E\u202A\u202C\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static bool \u206A\u202D\u202A\u206F\u200B\u206A\u206F\u206A\u206E\u200F\u202E\u206C\u202E\u206F\u200C\u200E\u202C\u202D\u200F\u202A\u206B\u202A\u202A\u206D\u200F\u200B\u202D\u202D\u200C\u200F\u200C\u200E\u200E\u202E\u202C\u202B\u206A\u202B\u202C\u200F\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static CardConfig \u206E\u206D\u202C\u202C\u202B\u206F\u202E\u206B\u202D\u202C\u200E\u200C\u202A\u202B\u200F\u206C\u200E\u202D\u206B\u200B\u206B\u206A\u200B\u202D\u206E\u202A\u202E\u206B\u202E\u200C\u200C\u202C\u206A\u200B\u202B\u202B\u200D\u206C\u206A\u206E\u202E(string A_0)
			{
				return CardConfig.FromId(A_0);
			}

			static string \u200C\u206D\u202A\u206C\u200E\u200E\u202C\u200E\u206E\u206F\u202C\u200C\u200E\u206C\u206A\u202B\u200D\u200E\u200C\u206B\u206D\u202A\u200F\u206A\u200F\u202D\u200C\u206F\u206A\u200F\u206C\u200E\u200F\u202A\u200C\u206A\u200D\u200F\u206A\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static NullReferenceException \u200E\u206F\u206D\u206A\u202C\u206B\u206B\u200E\u206F\u202D\u202B\u202C\u200C\u202A\u202B\u200C\u202C\u202D\u200E\u206A\u206C\u200C\u200E\u206C\u206C\u202A\u206C\u202D\u206B\u200C\u200F\u206D\u202A\u202D\u200C\u206F\u202C\u202E\u200C\u202E\u202E()
			{
				return new NullReferenceException();
			}

			static GameEvent<CardMovingEventArgs> \u202B\u202D\u200D\u202E\u202B\u200E\u200B\u200F\u206A\u200D\u206E\u206B\u200F\u202A\u200C\u200B\u206C\u200C\u206C\u206B\u202C\u200E\u206E\u206C\u206C\u202E\u206A\u200E\u200E\u202E\u206D\u206B\u200C\u202D\u202A\u206D\u202B\u202D\u206C\u202D\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u202E\u202E\u202D\u206F\u200F\u206F\u206B\u202C\u206A\u206E\u202B\u206E\u206C\u200C\u206C\u206F\u200D\u206C\u202C\u200F\u206C\u202A\u200E\u206B\u202D\u200C\u206F\u202B\u200E\u206D\u202A\u206D\u200F\u206D\u202E\u202C\u206D\u206B\u206D\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u200F\u206A\u200C\u202A\u206C\u206F\u202D\u202D\u200D\u202A\u206A\u206F\u206E\u202B\u206F\u200E\u200E\u202C\u206B\u200C\u206D\u202C\u200F\u206F\u206C\u206C\u202A\u200B\u206C\u206E\u202A\u202A\u206F\u206C\u200D\u206A\u200B\u206A\u202C\u202C\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u206C\u200E\u206C\u200F\u206A\u200F\u206A\u202A\u202D\u206C\u200F\u200F\u200E\u200C\u202E\u206B\u206C\u200F\u200C\u206F\u206C\u200F\u202C\u206E\u202C\u206B\u202D\u206D\u200C\u206A\u200B\u200B\u202E\u206B\u200F\u202E\u200C\u202C\u202C\u202C\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u202B\u206D\u200E\u206C\u200C\u200D\u206E\u200C\u200B\u202E\u206F\u202E\u206A\u206F\u200C\u206F\u206F\u200B\u206A\u200F\u202B\u206F\u200D\u202A\u202E\u202A\u200D\u202E\u202D\u202C\u200C\u206E\u206D\u200E\u200F\u200D\u202A\u202A\u200E\u206E\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u202A\u202D\u202B\u206E\u206A\u202C\u206C\u202E\u206C\u200C\u206F\u206D\u200F\u206C\u202A\u206F\u202C\u200D\u202A\u200F\u206A\u206E\u200D\u206D\u206C\u200D\u202C\u206F\u206F\u200B\u200C\u206E\u202C\u202D\u206E\u206B\u206E\u200E\u206B\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static PlayerUnit \u200C\u202A\u200F\u202A\u206E\u200F\u200B\u206C\u206D\u206A\u200C\u202D\u206C\u200E\u206E\u206F\u206F\u200B\u202D\u202B\u202D\u202A\u202B\u206F\u200B\u200F\u206D\u200E\u200C\u200E\u200B\u202B\u200C\u202B\u200E\u200D\u202E\u200E\u206C\u206A\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202E\u200C\u200D\u200F\u206E\u200B\u206E\u200F\u202A\u206E\u206A\u200C\u206E\u202D\u202B\u200B\u202D\u202E\u206B\u200B\u202E\u202C\u206B\u200F\u206B\u206E\u206C\u200F\u200F\u202C\u202A\u206A\u206B\u200C\u202A\u200F\u206D\u202C\u206D\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<UnitEventArgs> \u202B\u202C\u200E\u200C\u200D\u202E\u202B\u200C\u206A\u206E\u206F\u200D\u206F\u206F\u206C\u202A\u206D\u200D\u206C\u200D\u206E\u200F\u200D\u200D\u206C\u202B\u202C\u206E\u200E\u206D\u200E\u202D\u206F\u206D\u202C\u206A\u206D\u200B\u206B\u206F\u202E(Unit A_0)
			{
				return A_0.TurnEnded;
			}

			static Card \u200F\u200F\u200F\u202E\u202A\u206F\u200C\u200C\u200C\u200C\u200B\u206C\u202E\u206C\u202C\u202C\u202E\u206B\u206A\u202D\u202A\u202C\u200F\u202B\u200C\u202E\u202C\u202E\u200F\u200D\u202B\u206E\u206D\u202D\u202B\u202C\u202A\u206E\u206C\u202D\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u202B\u202B\u202A\u202E\u206D\u206C\u206E\u202D\u200D\u202C\u200B\u200D\u206E\u200C\u200E\u202B\u206F\u200B\u202D\u206E\u200B\u206D\u200D\u202D\u206E\u200D\u202C\u206A\u202E\u200D\u206F\u206E\u202D\u202D\u202D\u200B\u206B\u206E\u200B\u200F\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u206A\u200D\u202C\u202A\u200F\u202C\u206E\u202C\u200B\u200C\u202E\u200C\u202D\u206B\u200C\u200B\u202C\u200B\u202E\u206F\u202B\u206F\u202C\u202B\u206F\u206E\u202C\u202A\u202B\u202C\u206A\u206F\u200D\u200E\u206D\u206A\u202E\u202C\u206E\u202B\u202E(GameEventArgs A_0, CancelCause A_1)
			{
				A_0.ForceCancelBecause(A_1);
			}

			static Card \u202A\u202B\u206A\u200F\u206B\u202B\u206C\u202C\u206A\u200D\u206C\u200F\u200D\u200D\u200E\u200B\u202A\u200E\u202A\u206D\u200D\u202A\u202C\u206D\u202D\u202A\u200F\u200C\u200E\u200C\u202E\u206C\u200C\u202D\u202C\u206A\u200E\u206D\u206E\u206C\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206A\u200C\u206A\u202A\u206A\u206B\u206E\u200E\u200E\u200E\u206C\u200E\u202C\u202A\u206A\u206E\u200D\u202E\u200F\u200E\u206D\u206F\u202D\u206A\u202A\u206A\u206C\u206E\u206A\u206C\u206F\u200D\u200F\u200C\u202B\u202B\u206A\u202D\u202A\u206C\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202A\u200F\u206C\u200E\u202C\u200B\u202E\u202C\u206E\u206B\u200F\u206C\u200D\u200E\u200F\u200B\u206E\u200F\u206F\u206A\u206E\u200C\u202E\u200C\u200D\u202C\u202A\u202B\u206B\u206E\u206E\u206C\u200D\u202C\u202A\u206F\u200D\u200E\u206B\u202B\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			static IEnumerable<BattleAction> \u206B\u206C\u206E\u206C\u206A\u206D\u206E\u200E\u200E\u206C\u202B\u202B\u202E\u202D\u200E\u200C\u206C\u206E\u206F\u200D\u200B\u206C\u202E\u206C\u202D\u202B\u202C\u206F\u206E\u206E\u200C\u202A\u202C\u200D\u206A\u202A\u206C\u200F\u206B\u202E\u202E(Card A_0)
			{
				return A_0.GetPassiveActions();
			}

			static bool \u206E\u206D\u202D\u200B\u202B\u202C\u206B\u202C\u202D\u206C\u206B\u200B\u206E\u206D\u200B\u206F\u200E\u200C\u206E\u202D\u202B\u200B\u202E\u202D\u202D\u202B\u200E\u202A\u206A\u206F\u200E\u206A\u200E\u200E\u200E\u202E\u206D\u206D\u202C\u206B\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u206B\u200D\u200F\u200C\u202C\u200E\u202C\u202D\u206E\u206A\u200B\u200C\u202A\u202C\u200C\u200E\u206E\u202D\u202D\u200D\u202B\u200D\u200B\u202B\u206F\u206E\u202E\u206A\u200B\u206E\u200F\u200F\u200B\u206F\u202A\u202C\u200B\u202E\u202B\u200E\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u200F\u206A\u200F\u202E\u200F\u206E\u206D\u200E\u206C\u206D\u200C\u202A\u206D\u200B\u200F\u206E\u202C\u202B\u206B\u202C\u202D\u200C\u206B\u206B\u200F\u200D\u200D\u206E\u202D\u200C\u200D\u206E\u200B\u206D\u200E\u202E\u202B\u206E\u200E\u202A\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u202A\u202E\u206A\u206C\u200E\u202E\u206C\u206E\u200B\u206F\u206F\u200B\u206F\u200C\u206F\u206C\u202E\u206E\u206A\u200C\u206C\u200C\u200E\u206E\u200C\u206A\u206B\u206C\u206B\u200E\u202A\u200B\u202D\u200C\u206D\u200F\u206F\u200C\u206E\u200E\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u206D\u202D\u202E\u206E\u202D\u206F\u200D\u206E\u206C\u206D\u200B\u202D\u202D\u200B\u206A\u202C\u206B\u206D\u202D\u202C\u206E\u200D\u206E\u202D\u200C\u200D\u202C\u200D\u206E\u200B\u206A\u206F\u202B\u202D\u206B\u202E\u202E\u206B\u206A\u206A\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u206B\u200B\u206E\u202C\u206B\u206C\u200E\u200F\u206A\u200B\u206F\u202E\u206D\u206F\u206B\u206C\u200E\u200E\u200B\u206B\u202E\u202C\u206E\u200B\u202A\u202D\u202D\u202C\u206E\u202D\u202D\u202B\u206C\u206F\u206A\u202B\u200C\u200E\u206E\u200E\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u206F\u200E\u206D\u206C\u200B\u200B\u206A\u202A\u202A\u206C\u202D\u202D\u202A\u206B\u202A\u200E\u202C\u206D\u200E\u206A\u200F\u202E\u200B\u202A\u202A\u200C\u206E\u202C\u202D\u206A\u206E\u200F\u202A\u202D\u206A\u206A\u206C\u200F\u206B\u200C\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u202C\u200D\u202D\u200B\u200B\u202B\u206C\u200C\u200C\u202C\u206A\u202B\u200E\u206C\u206A\u206D\u200E\u202D\u200F\u200E\u202A\u200D\u202C\u200E\u206A\u202A\u200E\u206F\u202E\u200E\u200D\u206C\u200C\u206B\u200C\u206B\u202D\u206C\u206E\u202D\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u202C\u202A\u202D\u206F\u206E\u200B\u206F\u206B\u206B\u202A\u202C\u206D\u202E\u206B\u206E\u206B\u200F\u200D\u202E\u206F\u202A\u202E\u202A\u200E\u206C\u206F\u200D\u206C\u206B\u202D\u202E\u200B\u200B\u206B\u206B\u200D\u200D\u206E\u202B\u206F\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u206D\u202C\u206F\u206E\u202B\u206E\u206E\u200B\u200D\u202D\u206A\u202E\u206F\u202A\u202D\u200E\u206A\u200F\u200D\u202E\u200B\u200D\u202C\u206E\u200B\u200C\u202B\u202E\u202B\u200E\u202C\u202E\u206C\u206B\u200F\u206B\u202E\u206E\u200D\u202D\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static bool \u206C\u206B\u202E\u202D\u200B\u200D\u202D\u202A\u206A\u200E\u200E\u202B\u202A\u202E\u202A\u206C\u200D\u200D\u206C\u200F\u206F\u206B\u202A\u206A\u206E\u200E\u200E\u206F\u202A\u206F\u206A\u206D\u206A\u200F\u202E\u200B\u202C\u206B\u206E\u200F\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206B\u200D\u206B\u200C\u202C\u206B\u200F\u206B\u202D\u200C\u206C\u200E\u202D\u206D\u206A\u202A\u200C\u202A\u200C\u206E\u206E\u206E\u206D\u200C\u202E\u206D\u206F\u200F\u202D\u206C\u200B\u202B\u206D\u200D\u200B\u200C\u200C\u200C\u206F\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static MiniSelectCardInteraction \u200B\u202B\u200E\u202B\u202B\u206C\u206C\u200C\u202E\u200E\u200B\u200C\u200B\u200D\u200B\u202A\u206F\u202A\u206A\u206E\u206A\u202C\u202D\u202D\u200D\u200E\u200B\u200C\u206E\u202A\u202A\u202C\u200D\u202C\u202E\u202B\u200F\u200D\u206F\u206E\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			static void \u202D\u202A\u206A\u202D\u206F\u206E\u200E\u202D\u206D\u200D\u202B\u202C\u202E\u202B\u206E\u206F\u200E\u200E\u206F\u200E\u202E\u200C\u200B\u206D\u206E\u200D\u206C\u200E\u206A\u202A\u206C\u206C\u200F\u202B\u202E\u202E\u200C\u206C\u200C\u202E\u202E(GameObject A_0, bool A_1)
			{
				A_0.SetActive(A_1);
			}

			static GameObject \u202B\u200E\u206D\u200D\u200D\u200B\u200F\u200F\u206E\u200C\u200D\u206C\u200D\u202D\u200F\u202A\u206E\u206C\u206E\u206A\u200F\u200B\u202E\u206A\u206D\u206A\u206E\u206D\u206F\u206D\u206B\u200D\u200C\u206B\u202A\u206B\u200F\u206F\u206D\u206F\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			public static bool LastWord = false;

			public bool Attacking;

			public static GameObject background = AyaFriendAyaDef.AyaFriendAya.\u202B\u200E\u206D\u200D\u200D\u200B\u200F\u200F\u206E\u200C\u200D\u206C\u200D\u202D\u200F\u202A\u206E\u206C\u206E\u206A\u200F\u200B\u202E\u206A\u206D\u206A\u206E\u206D\u206F\u206D\u206B\u200D\u200C\u206B\u202A\u206B\u200F\u206F\u206D\u206F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1106602609), null);

			[HarmonyPatch(typeof(UiManager), "LeaveGameRun")]
			private class UiManager_LeaveGameRun_Patch
			{
				private static void Postfix(UiManager __instance)
				{
					AyaFriendAyaDef.AyaFriendAya.UiManager_LeaveGameRun_Patch.\u202D\u202C\u206E\u200B\u200C\u206A\u202C\u200F\u206F\u202C\u206C\u202C\u200F\u200E\u202B\u200C\u200F\u202B\u206D\u200E\u202A\u200D\u200C\u206B\u202C\u200C\u202A\u206C\u206D\u200E\u206B\u206D\u200F\u206D\u206B\u206D\u200F\u202D\u202D\u202D\u202E(AyaFriendAyaDef.AyaFriendAya.background, false);
					AyaFriendAyaDef.AyaFriendAya.LastWord = false;
				}

				static void \u202D\u202C\u206E\u200B\u200C\u206A\u202C\u200F\u206F\u202C\u206C\u202C\u200F\u200E\u202B\u200C\u200F\u202B\u206D\u200E\u202A\u200D\u200C\u206B\u202C\u200C\u202A\u206C\u206D\u200E\u206B\u206D\u200F\u206D\u206B\u206D\u200F\u202D\u202D\u202D\u202E(GameObject A_0, bool A_1)
				{
					A_0.SetActive(A_1);
				}
			}
		}
	}
}
