using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaFriendCirnoDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1519131614);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendCirnoDef.\u202E\u202A\u206B\u202A\u200C\u206E\u200B\u200B\u202A\u206A\u202D\u202A\u206F\u202E\u200F\u200C\u200E\u202C\u200F\u206E\u202E\u202E\u202E\u206B\u206C\u202B\u202B\u200D\u202B\u206F\u202D\u202E\u202C\u206B\u200D\u200E\u200E\u200C\u202D\u202C\u202E(BepinexPlugin.embeddedSource);
			AyaFriendCirnoDef.\u206C\u206F\u200C\u200B\u200B\u202E\u206A\u206A\u202B\u202D\u202E\u206E\u202A\u202C\u200F\u200E\u202E\u206C\u206F\u202A\u200F\u206D\u200D\u200F\u202D\u200D\u206F\u206F\u202E\u202C\u206F\u202E\u206D\u200B\u206B\u206C\u202A\u202E\u202A\u206D\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), true);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendCirnoDef.\u202A\u200C\u202D\u206B\u200E\u206F\u206D\u200F\u200F\u206F\u206A\u202D\u206B\u206D\u202C\u202E\u206D\u200E\u202C\u206D\u202B\u200C\u200D\u202C\u202C\u200F\u206D\u200C\u200B\u206E\u206B\u202D\u202E\u200E\u200D\u202D\u202C\u206D\u200F\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendCirnoDef.\u206C\u200B\u206C\u206C\u202B\u200F\u200E\u200B\u206F\u206A\u202C\u200C\u202B\u202B\u200B\u206D\u206D\u200B\u200F\u206E\u206D\u206F\u202D\u206B\u200F\u206C\u202D\u206C\u200B\u202D\u206A\u200D\u206D\u206C\u202E\u206E\u206E\u200C\u202B\u200F\u202E(BepinexPlugin.sequenceTable, AyaFriendCirnoDef.\u206E\u200B\u200B\u206F\u206A\u206A\u202A\u206E\u206C\u206D\u206B\u206E\u206D\u200C\u200B\u202A\u206C\u206B\u202C\u202E\u206E\u200E\u206A\u202C\u202A\u200C\u206F\u202C\u202A\u200E\u200C\u202D\u202A\u202A\u206C\u206C\u200C\u200D\u206B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, false, !BepinexPlugin.Chapter1AyaPlayerUnit, false, false, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Blue = 1,
				Red = 1,
				Green = 2
			}, null, null, null, null, new int?(99), null, null, null, null, null, new int?(9), null, new int?(2), null, null, null, null, null, null, new int?(0), null, new int?(9), null, new int?(0), null, null, null, new int?(0), null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-714371867), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1339481432), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1755394345), false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1058127730), new List<string>());
		}

		static CardImages \u202E\u202A\u206B\u202A\u200C\u206E\u200B\u200B\u202A\u206A\u202D\u202A\u206F\u202E\u200F\u200C\u200E\u202C\u200F\u206E\u202E\u202E\u202E\u206B\u206C\u202B\u202B\u200D\u202B\u206F\u202D\u202E\u202C\u206B\u200D\u200E\u200E\u200C\u202D\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u206F\u200C\u200B\u200B\u202E\u206A\u206A\u202B\u202D\u202E\u206E\u202A\u202C\u200F\u200E\u202E\u206C\u206F\u202A\u200F\u206D\u200D\u200F\u202D\u200D\u206F\u206F\u202E\u202C\u206F\u202E\u206D\u200B\u206B\u206C\u202A\u202E\u202A\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u200C\u202D\u206B\u200E\u206F\u206D\u200F\u200F\u206F\u206A\u202D\u206B\u206D\u202C\u202E\u206D\u200E\u202C\u206D\u202B\u200C\u200D\u202C\u202C\u200F\u206D\u200C\u200B\u206E\u206B\u202D\u202E\u200E\u200D\u202D\u202C\u206D\u200F\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u200B\u200B\u206F\u206A\u206A\u202A\u206E\u206C\u206D\u206B\u206E\u206D\u200C\u200B\u202A\u206C\u206B\u202C\u202E\u206E\u200E\u206A\u202C\u202A\u200C\u206F\u202C\u202A\u200E\u200C\u202D\u202A\u202A\u206C\u206C\u200C\u200D\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200B\u206C\u206C\u202B\u200F\u200E\u200B\u206F\u206A\u202C\u200C\u202B\u202B\u200B\u206D\u206D\u200B\u200F\u206E\u206D\u206F\u202D\u206B\u200F\u206C\u202D\u206C\u200B\u202D\u206A\u200D\u206D\u206C\u202E\u206E\u206E\u200C\u202B\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendCirnoDef))]
		public sealed class AyaFriendCirno : Card
		{
			private string ExtraDescription4
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(830735588), true, false);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206B\u206C\u206A\u202E\u206F\u206A\u200C\u200C\u202E\u206E\u202A\u206A\u206A\u200B\u206D\u206A\u202B\u200E\u202E\u206D\u200B\u206F\u206C\u206C\u202B\u200B\u202B\u206E\u202E\u202A\u202C\u206C\u202A\u202E\u200C\u200B\u202C\u200C\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206D\u200B\u206A\u206B\u202A\u202D\u200B\u206D\u200C\u200D\u202A\u200E\u206A\u200F\u202D\u202D\u206B\u206D\u202C\u206A\u206D\u206E\u206D\u206C\u200C\u206B\u200E\u202B\u206F\u200B\u200C\u200F\u202E\u200F\u200B\u200E\u202C\u206E\u206C\u202E\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_0470;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text3;
					string text4;
					string text5;
					switch ((num3 = (uint)(num - (--1378865505 * -273997603 + ((-1047820117 - 439285818) ^ 778233404)) + 1667826729 * ~-1934958122)) % 34U)
					{
					case 0U:
					{
						string text2;
						text = text2;
						num2 = -155208567;
						continue;
					}
					case 1U:
						num2 = (int)((num3 * 3624513730U) ^ 1363050029U);
						continue;
					case 2U:
						num2 = (int)((num3 * 2175565990U) ^ 2377644397U);
						continue;
					case 3U:
						switch (AyaFriendCirnoDef.AyaFriendCirno.\u206F\u206E\u202D\u200F\u202D\u206F\u206E\u200D\u202C\u206A\u206E\u206A\u200B\u200F\u206D\u202E\u206D\u206E\u200F\u206C\u200E\u202E\u206D\u202D\u200C\u202E\u206F\u202C\u206A\u206A\u200B\u202E\u206B\u202D\u206E\u202B\u206D\u200C\u206E\u206C\u202E(this))
						{
						case FriendToken.None:
							goto IL_03D3;
						case FriendToken.Active:
							goto IL_01F7;
						case FriendToken.Active2:
							goto IL_03EA;
						case FriendToken.Ultimate:
							goto IL_0313;
						default:
							num2 = (int)((num3 * 3818889826U) ^ 3078414797U);
							continue;
						}
						break;
					case 4U:
						num2 = (int)((num3 * 2720214824U) ^ 1195646441U);
						continue;
					case 5U:
						goto IL_01F7;
					case 6U:
						goto IL_01A8;
					case 7U:
						num2 = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u200D\u206F\u200C\u200C\u202D\u200F\u206E\u200F\u202C\u200E\u200F\u202A\u200C\u206C\u202A\u202E\u206D\u202D\u200B\u206D\u202B\u206C\u200C\u200C\u200F\u206F\u206B\u202C\u206E\u202E\u200B\u200B\u200B\u206A\u206B\u200B\u202D\u200E\u200C\u202E\u202E(this) != 2) ? 334873793U : 172160147U) ^ (num3 * 1634943716U));
						continue;
					case 8U:
					{
						string text2 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 668246192;
						continue;
					}
					case 9U:
						num2 = (int)((num3 * 717388141U) ^ 3663502424U);
						continue;
					case 10U:
						goto IL_0010;
					case 11U:
						text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, this.ActiveUsed ? base.ExtraDescription2 : base.ExtraDescription1);
						text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, AyaFriendCirnoDef.AyaFriendCirno.\u206A\u200B\u206B\u200C\u202B\u202B\u206B\u200F\u206C\u206E\u200D\u202A\u206F\u202D\u202A\u202A\u200C\u202C\u206A\u202E\u202D\u202E\u200E\u200B\u200C\u206E\u200E\u200E\u202D\u206F\u200C\u200B\u206D\u206B\u200D\u206A\u202E\u206F\u202D\u202B\u202E(this) ? this.ExtraDescription4 : base.ExtraDescription3);
						num2 = -219549458;
						continue;
					case 12U:
						num2 = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this) == null) ? 1070253836U : 1427338098U) ^ (num3 * 2618709301U));
						continue;
					case 14U:
						num2 = ((base.BaseDetailText == null) ? 442410384 : 1386593259);
						continue;
					case 15U:
						text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
						num2 = (int)((num3 * 560180802U) ^ 258588892U);
						continue;
					case 16U:
					{
						string text2 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -13270141;
						continue;
					}
					case 17U:
						goto IL_03D3;
					case 18U:
						if (!AyaFriendCirnoDef.AyaFriendCirno.\u202D\u206F\u206D\u202D\u206B\u206A\u202D\u200F\u206F\u206B\u206C\u206F\u202B\u202C\u206E\u200D\u206F\u206D\u206D\u202D\u206E\u206C\u200D\u202A\u200D\u202B\u200E\u200F\u202C\u206B\u206E\u200E\u202E\u202A\u202A\u202E\u202A\u206E\u206B\u202D\u202E(this))
						{
							num2 = 202257589;
							continue;
						}
						text3 = base.UpgradedExtraDescription1 ?? base.ExtraDescription1;
						goto IL_0178;
					case 19U:
						if (!AyaFriendCirnoDef.AyaFriendCirno.\u202D\u206F\u206D\u202D\u206B\u206A\u202D\u200F\u206F\u206B\u206C\u206F\u202B\u202C\u206E\u200D\u206F\u206D\u206D\u202D\u206E\u206C\u200D\u202A\u200D\u202B\u200E\u200F\u202C\u206B\u206E\u200E\u202E\u202A\u202A\u202E\u202A\u206E\u206B\u202D\u202E(this))
						{
							num2 = (int)((num3 * 317645611U) ^ 2244276134U);
							continue;
						}
						text4 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_0436;
					case 20U:
						if (!AyaFriendCirnoDef.AyaFriendCirno.\u202D\u206F\u206D\u202D\u206B\u206A\u202D\u200F\u206F\u206B\u206C\u206F\u202B\u202C\u206E\u200D\u206F\u206D\u206D\u202D\u206E\u206C\u200D\u202A\u200D\u202B\u200E\u200F\u202C\u206B\u206E\u200E\u202E\u202A\u202A\u202E\u202A\u206E\u206B\u202D\u202E(this))
						{
							num2 = -598991954;
							continue;
						}
						text5 = base.UpgradedExtraDescription2 ?? base.ExtraDescription2;
						goto IL_0308;
					case 21U:
						goto IL_0470;
					case 22U:
						goto IL_0313;
					case 23U:
						num2 = (int)((num3 * 2289442224U) ^ 2597870041U);
						continue;
					case 24U:
					{
						string text2;
						num2 = (((text2 = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription) == null) ? (-270913047) : (-13270141));
						continue;
					}
					case 25U:
						num2 = (AyaFriendCirnoDef.AyaFriendCirno.\u202D\u206F\u206D\u202D\u206B\u206A\u202D\u200F\u206F\u206B\u206C\u206F\u202B\u202C\u206E\u200D\u206F\u206D\u206D\u202D\u206E\u206C\u200D\u202A\u200D\u202B\u200E\u200F\u202C\u206B\u206E\u200E\u202E\u202A\u202A\u202E\u202A\u206E\u206B\u202D\u202E(this) ? 760908931 : 406202147);
						continue;
					case 26U:
						goto IL_03EA;
					case 27U:
						num2 = (int)((num3 * 151495662U) ^ 2598666611U);
						continue;
					case 28U:
						text4 = base.BaseDescription;
						goto IL_0436;
					case 29U:
						text5 = base.ExtraDescription2;
						goto IL_0308;
					case 30U:
						text3 = base.ExtraDescription1;
						goto IL_0178;
					case 31U:
						num2 = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206C\u206E\u200F\u200F\u202D\u200D\u202E\u206B\u200C\u200D\u206B\u202B\u206C\u200F\u200B\u202B\u200F\u206C\u206F\u206A\u206B\u202B\u206F\u200E\u206E\u202E\u202B\u200D\u206F\u206C\u200C\u200C\u206F\u206B\u206F\u206C\u200B\u206F\u202C\u202E(this) != CardType.Friend) ? 2323892525U : 2126335801U) ^ (num3 * 1434683309U));
						continue;
					case 32U:
						text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1776063171));
						num2 = (int)((num3 * 1554538156U) ^ 1495662856U);
						continue;
					case 33U:
						num2 = ((AyaFriendCirnoDef.AyaFriendCirno.\u200D\u206F\u200C\u200C\u202D\u200F\u206E\u200F\u202C\u200E\u200F\u202A\u200C\u206C\u202A\u202E\u206D\u202D\u200B\u206D\u202B\u206C\u200C\u200C\u200F\u206F\u206B\u202C\u206E\u202E\u200B\u200B\u200B\u206A\u206B\u200B\u202D\u200E\u200C\u202E\u202E(this) != 1) ? 1224267816 : 429557879);
						continue;
					}
					break;
					IL_0178:
					text = text3;
					num2 = -155208567;
					continue;
					IL_01F7:
					text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, this.ActiveUsed ? base.ExtraDescription2 : base.ExtraDescription1);
					num2 = 1092360072;
					continue;
					IL_0308:
					text = text5;
					num2 = 874355748;
					continue;
					IL_0313:
					text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, AyaFriendCirnoDef.AyaFriendCirno.\u206A\u200B\u206B\u200C\u202B\u202B\u206B\u200F\u206C\u206E\u200D\u202A\u206F\u202D\u202A\u202A\u200C\u202C\u206A\u202E\u202D\u202E\u200E\u200B\u200C\u206E\u200E\u200E\u202D\u206F\u200C\u200B\u206D\u206B\u200D\u206A\u202E\u206F\u202D\u202B\u202E(this) ? this.ExtraDescription4 : base.ExtraDescription3);
					num2 = 618136959;
					continue;
					IL_03D3:
					text = AyaFriendCirnoDef.AyaFriendCirno.\u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(text, base.BaseDescription);
					num2 = 4896142;
					continue;
					IL_0436:
					text = text4;
					num2 = -155208567;
				}
				return text;
				IL_01A8:
				return string.Empty;
				IL_03EA:
				throw AyaFriendCirnoDef.AyaFriendCirno.\u200E\u206A\u206E\u202C\u206D\u202E\u206A\u200D\u206C\u206F\u206D\u206F\u206C\u202E\u202E\u202A\u206A\u200F\u206C\u202C\u206D\u202A\u200C\u200F\u206F\u200E\u202D\u206D\u200F\u202A\u200F\u202B\u200B\u200F\u202B\u200F\u200C\u206E\u206C\u206F\u202E();
				IL_0010:
				num2 = 1313233439;
				goto IL_0015;
				IL_0470:
				text = string.Empty;
				num2 = 972654274;
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
					return DamageInfo.Attack((float)AyaFriendCirnoDef.AyaFriendCirno.\u202D\u206B\u200B\u206C\u206B\u202A\u200C\u202C\u200E\u206F\u200F\u206A\u200D\u206D\u206F\u200E\u200F\u206F\u206E\u206B\u206A\u200F\u200C\u206F\u200E\u200E\u202D\u206A\u200C\u200E\u200F\u206F\u206A\u202A\u206F\u200B\u202A\u202A\u206B\u206C\u202E(this), true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (AyaFriendCirnoDef.AyaFriendCirno.\u206D\u206E\u206E\u200E\u206E\u200F\u206A\u202A\u206D\u206B\u206D\u206C\u202B\u200E\u206D\u206D\u200E\u200D\u200F\u202A\u206E\u206E\u206E\u200F\u202C\u206B\u202E\u206C\u200F\u206F\u200B\u200E\u206A\u206C\u200B\u206D\u200E\u206B\u202B\u202C\u202E(key, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-661991630)))
				{
					for (;;)
					{
						IL_0017:
						int num = 1751565153;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(~(num2 - (-1233786229 ^ 297835091)) * 23685715))) % 4U)
							{
							case 0U:
								goto IL_0017;
							case 1U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u200D\u200E\u206E\u200E\u206C\u202D\u202A\u200D\u206B\u200B\u202E\u200F\u206E\u200F\u206B\u200C\u206F\u206C\u200D\u206F\u200B\u206F\u206D\u202B\u200C\u202C\u200B\u202D\u206C\u206B\u202C\u200D\u202B\u206F\u202E\u202A\u206A\u200D\u200E\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1519131614)).RelativeKeyword = Keyword.Upgrade;
								num = (int)((num3 * 3772794269U) ^ 1406995438U);
								continue;
							case 3U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u200D\u200E\u206E\u200E\u206C\u202D\u202A\u200D\u206B\u200B\u202E\u200F\u206E\u200F\u206B\u200C\u206F\u206C\u200D\u206F\u200B\u206F\u206D\u202B\u200C\u202C\u200B\u202D\u206C\u206B\u202C\u200D\u202B\u206F\u202E\u202A\u206A\u200D\u200E\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1519131614)).UpgradedRelativeKeyword = Keyword.Upgrade;
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u200D\u200E\u206E\u200E\u206C\u202D\u202A\u200D\u206B\u200B\u202E\u200F\u206E\u200F\u206B\u200C\u206F\u206C\u200D\u206F\u200B\u206F\u206D\u202B\u200C\u202C\u200B\u202D\u206C\u206B\u202C\u200D\u202B\u206F\u202E\u202A\u206A\u200D\u200E\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1339481432)).RelativeEffects = new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1411453261) };
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u200D\u200E\u206E\u200E\u206C\u202D\u202A\u200D\u206B\u200B\u202E\u200F\u206E\u200F\u206B\u200C\u206F\u206C\u200D\u206F\u200B\u206F\u206D\u202B\u200C\u202C\u200B\u202D\u206C\u206B\u202C\u200D\u202B\u206F\u202E\u202A\u206A\u200D\u200E\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1519131614)).UpgradedRelativeEffects = new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1497235465) };
								num = (int)((num3 * 3128699276U) ^ 4195568568U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return TypeFactory<Card>.LocalizeProperty(AyaFriendCirnoDef.AyaFriendCirno.\u206F\u206C\u206C\u200F\u206F\u202C\u200F\u202C\u202E\u206A\u206B\u202B\u202C\u200D\u200E\u206E\u200F\u200D\u200E\u206C\u206B\u206E\u200E\u206E\u200C\u206B\u202A\u202D\u206F\u200F\u202D\u202E\u202C\u200C\u200B\u206F\u206C\u200D\u200F\u200F\u202E(this), key, decorated, required);
			}

			public bool ActiveUsed { get; set; }

			protected override void OnEnterBattle(BattleController battle)
			{
				if (AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence == 0)
				{
					goto IL_000A;
				}
				goto IL_011C;
				int num2;
				for (;;)
				{
					IL_000F:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(~num) ^ (-355732246 ^ 1140158527)))) % 5U)
					{
					case 0U:
						goto IL_000A;
					case 1U:
						base.ReactBattleEvent<CardMovingToDrawZoneEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u206E\u206B\u202E\u200E\u206A\u206F\u202B\u206A\u200E\u200C\u200F\u200F\u200B\u200E\u202E\u200E\u206A\u202C\u202B\u200E\u200E\u200C\u206F\u202A\u206F\u200B\u200C\u202B\u206E\u202E\u200C\u202A\u206B\u206E\u206B\u206F\u200C\u206A\u202D\u206D\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone));
						base.ReactBattleEvent<CardEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u206D\u206F\u200D\u202D\u200B\u202E\u200B\u202A\u202E\u206D\u206A\u202E\u200E\u202E\u206E\u202E\u206F\u202D\u206A\u206C\u206C\u200C\u200F\u206B\u206C\u206D\u206F\u202C\u200C\u202E\u200B\u202D\u206C\u206F\u206F\u202B\u206B\u206C\u202A\u206D\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
						base.ReactBattleEvent<CardEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u202E\u202B\u200F\u200F\u202D\u200F\u202D\u200E\u200E\u202E\u206C\u202D\u200B\u206E\u202E\u202E\u206A\u206B\u200D\u206B\u200D\u206D\u206B\u200E\u200F\u200B\u206B\u200B\u200D\u200B\u206F\u200E\u202B\u200F\u206C\u200B\u206C\u200E\u200D\u202E\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
						base.ReactBattleEvent<CardEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u200B\u202E\u202B\u206F\u200D\u206A\u206D\u200F\u200E\u200D\u200B\u206B\u200B\u202D\u200E\u206F\u200E\u200B\u200F\u206C\u206E\u206E\u202D\u202D\u200E\u202E\u206D\u200E\u202C\u206F\u202A\u202A\u202D\u202D\u206A\u206F\u206F\u200D\u206E\u202D\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardLeaving));
						base.ReactBattleEvent<CardTransformEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206A\u200D\u202C\u202B\u206A\u206B\u206C\u206B\u206F\u202E\u200D\u200D\u206F\u200F\u200B\u200E\u200D\u202D\u200C\u200F\u206B\u202E\u202B\u202D\u206E\u202C\u200B\u206E\u202E\u202C\u202A\u206F\u202A\u202E\u202B\u206F\u206A\u206D\u200F\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardTransformEventArgs>(this.OnCardTransforming));
						base.ReactBattleEvent<UnitEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u206F\u202D\u206D\u200E\u200D\u200C\u200D\u202A\u206A\u200C\u206D\u206C\u202B\u202A\u200C\u202A\u206B\u200D\u200D\u200F\u206E\u206E\u200C\u206F\u206F\u206C\u202D\u206D\u206D\u200F\u206F\u200D\u206A\u206F\u206E\u202E\u200B\u206B\u200F\u202E\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206C\u206C\u200C\u200B\u202C\u200C\u202E\u200F\u206A\u200F\u200C\u200B\u200E\u200B\u206C\u206A\u202C\u202B\u200E\u206B\u206F\u202A\u202E\u206F\u202D\u206E\u200F\u200B\u206F\u202A\u202A\u206E\u206D\u206D\u206D\u200E\u202A\u200C\u200E\u202E\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
						num2 = (int)((num3 * 3461979825U) ^ 4274691857U);
						continue;
					case 3U:
						goto IL_0042;
					case 4U:
						goto IL_011C;
					}
					break;
				}
				return;
				IL_0042:
				throw AyaFriendCirnoDef.AyaFriendCirno.\u200B\u202C\u202B\u206B\u206F\u206F\u202C\u200B\u202B\u200F\u200C\u206E\u202D\u202C\u206E\u206B\u200E\u202C\u202D\u206B\u202E\u200D\u206A\u202E\u200E\u202D\u200D\u206C\u202B\u202C\u202C\u206C\u206C\u202D\u200B\u206A\u206E\u200C\u206C\u206D\u202E();
				IL_000A:
				num2 = 289858243;
				goto IL_000F;
				IL_011C:
				AyaFriendCirnoDef.AyaFriendCirno.\u206F\u202D\u206D\u206C\u200F\u200E\u202A\u200D\u206C\u206D\u202C\u202D\u206D\u206C\u200F\u202B\u206D\u202C\u200C\u200B\u206F\u206E\u206B\u200F\u206D\u200D\u202B\u202D\u202C\u200C\u206B\u202C\u206F\u202C\u206B\u202E\u206C\u206A\u206A\u202E\u202E(this, AyaFriendCirnoDef.AyaFriendCirno.\u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(this) + AyaFriendCirnoDef.AyaFriendCirno.\u202D\u202D\u200D\u206E\u206F\u202D\u200D\u200B\u202B\u206B\u202C\u202C\u200D\u206F\u200F\u206C\u206F\u202D\u200E\u202B\u202B\u202E\u206E\u200F\u202A\u202D\u200E\u206E\u206A\u202B\u206B\u200B\u206D\u200D\u200F\u206B\u206B\u206F\u200B\u206D\u202E(this));
				base.ReactBattleEvent<CardMovingEventArgs>(AyaFriendCirnoDef.AyaFriendCirno.\u200E\u206B\u206F\u202C\u206B\u206F\u206E\u200B\u206C\u202B\u200C\u202C\u200E\u202C\u200B\u200D\u206D\u206E\u202A\u200F\u202D\u206B\u206B\u206C\u206D\u206B\u206C\u200F\u206D\u206F\u200E\u206E\u206D\u206D\u206D\u206D\u206E\u206E\u200C\u200F\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(this)), new EventSequencedReactor<CardMovingEventArgs>(this.OnCardMoving));
				num2 = 884493500;
				goto IL_000F;
			}

			private IEnumerable<BattleAction> OnCardMoving(CardMovingEventArgs args)
			{
				if (AyaFriendCirnoDef.AyaFriendCirno.\u200C\u206E\u202B\u200B\u200C\u206D\u200C\u202C\u200E\u206F\u202B\u202C\u206C\u200D\u202A\u202B\u200C\u200E\u206C\u206C\u202E\u202D\u206C\u206F\u202E\u206C\u200D\u206B\u206D\u202E\u206C\u206B\u200D\u200D\u200D\u202D\u202E\u206F\u206B\u206E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -1211596859;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((num2 * 1017492191) ^ ((1766726089 * 817502619) ^ ~-1630096667) ^ --1135254677) - -1946018908)) % 5U)
							{
							case 0U:
								goto IL_000C;
							case 2U:
								num = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202E\u206A\u200E\u206E\u206F\u200C\u202E\u200B\u200E\u200F\u206F\u206B\u206A\u202D\u206F\u202C\u206A\u202C\u200E\u206D\u206D\u206F\u206E\u200E\u200D\u202E\u206C\u202B\u202C\u200F\u202D\u200B\u202A\u206A\u200C\u200F\u200B\u206E\u206B\u200F\u202E(args) is AyaPlayerUnitDef.AyaPlayerUnit) ? 501449008U : 3011433743U) ^ (num3 * 1896775351U));
								continue;
							case 3U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u202A\u200E\u202E\u206A\u200D\u206A\u202C\u206F\u200B\u200E\u202D\u202A\u206B\u202A\u206E\u200E\u206A\u202B\u200E\u206E\u206C\u200F\u200D\u200E\u206E\u200D\u206F\u206A\u202A\u202B\u200E\u200C\u200F\u200D\u206C\u206B\u200C\u206E\u200C\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 1380190550U) ^ 1017469191U);
								continue;
							case 4U:
								num = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202E\u206A\u200E\u206E\u206F\u200C\u202E\u200B\u200E\u200F\u206F\u206B\u206A\u202D\u206F\u202C\u206A\u202C\u200E\u206D\u206D\u206F\u206E\u200E\u200D\u202E\u206C\u202B\u202C\u200F\u202D\u200B\u202A\u206A\u200C\u200F\u200B\u206E\u206B\u200F\u202E(args) != this) ? 46036055U : 3205943839U) ^ (num3 * 3999419351U));
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
				if (AyaFriendCirnoDef.AyaFriendCirno.\u202D\u200D\u206E\u202B\u202C\u200D\u200C\u202E\u206C\u202A\u206C\u202E\u206A\u200C\u206A\u206D\u206A\u206C\u200D\u200F\u202B\u206B\u202A\u200B\u200D\u206E\u206C\u206D\u200E\u202B\u206C\u200E\u202A\u200C\u202C\u206A\u206D\u200E\u200E\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = -208627442;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(1310842873 + 1029457100 - 169443203 * 794549248 - (num2 + -(-536345349 - (1159031367 - 1026345310))))) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 2U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u202A\u200E\u202E\u206A\u200D\u206A\u202C\u206F\u200B\u200E\u202D\u202A\u206B\u202A\u206E\u200E\u206A\u202B\u200E\u206E\u206C\u200F\u200D\u200E\u206E\u200D\u206F\u206A\u202A\u202B\u200E\u200C\u200F\u200D\u206C\u206B\u200C\u206E\u200C\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 1947584943U) ^ 3461460774U);
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
				if (AyaFriendCirnoDef.AyaFriendCirno.\u202B\u206B\u206E\u206F\u200C\u206F\u202D\u202D\u200E\u206B\u200B\u202E\u206C\u202C\u206C\u200E\u202A\u206E\u200E\u206C\u200F\u206E\u200F\u200F\u202C\u202D\u202C\u200D\u200E\u206E\u202A\u206D\u202E\u200F\u202E\u202E\u206E\u202D\u200B\u202A\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = 15150959;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(num2 + (~(-1867435870 + -319067487) - (1599048065 ^ -1922359909 ^ (869427260 ^ -2130109098)))) + (973315707 ^ -1097944489) - 722228834)) % 3U)
							{
							case 1U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u202A\u200E\u202E\u206A\u200D\u206A\u202C\u206F\u200B\u200E\u202D\u202A\u206B\u202A\u206E\u200E\u206A\u202B\u200E\u206E\u206C\u200F\u200D\u200E\u206E\u200D\u206F\u206A\u202A\u202B\u200E\u200C\u200F\u200D\u206C\u206B\u200C\u206E\u200C\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 2493308286U) ^ 4278086649U);
								continue;
							case 2U:
								goto IL_0009;
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
				if (AyaFriendCirnoDef.AyaFriendCirno.\u202A\u200D\u200F\u206E\u202C\u202A\u200D\u202D\u206D\u206D\u206F\u206C\u202C\u202D\u202C\u200D\u206C\u202B\u200F\u200E\u206B\u202C\u200F\u202D\u206F\u206E\u202A\u200B\u202C\u202B\u206E\u200B\u202D\u200F\u206A\u200C\u200C\u202B\u206B\u200F\u202E(args) == this)
				{
					for (;;)
					{
						IL_0009:
						int num = 521035802;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((~num2 * 2067402245) ^ -1641447755) + -1027442652)) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 2U:
								AyaFriendCirnoDef.AyaFriendCirno.\u200D\u202A\u200E\u202E\u206A\u200D\u206A\u202C\u206F\u200B\u200E\u202D\u202A\u206B\u202A\u206E\u200E\u206A\u202B\u200E\u206E\u206C\u200F\u200D\u200E\u206E\u200D\u206F\u206A\u202A\u202B\u200E\u200C\u200F\u200D\u206C\u206B\u200C\u206E\u200C\u202E(args, CancelCause.Failure);
								num = (int)((num3 * 3648793118U) ^ 3469258412U);
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
				return AyaFriendCirnoDef.AyaFriendCirno.\u200F\u200F\u202C\u200E\u202A\u200B\u202C\u200F\u206F\u200E\u206C\u206F\u200E\u202C\u206C\u202C\u206D\u202C\u200C\u206C\u202B\u200B\u202D\u200F\u202A\u202A\u206F\u202B\u206A\u206E\u202C\u200F\u206D\u206E\u202E\u200D\u200F\u200E\u200F\u202C\u202E(this);
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaFriendCirnoDef.AyaFriendCirno.<GetPassiveActions>d__18 <GetPassiveActions>d__ = new AyaFriendCirnoDef.AyaFriendCirno.<GetPassiveActions>d__18(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206C\u206E\u200F\u200F\u202D\u200D\u202E\u206B\u200C\u200D\u206B\u202B\u206C\u200F\u200B\u202B\u200F\u206C\u206F\u206A\u206B\u202B\u206F\u200E\u206E\u202E\u202B\u200D\u206F\u206C\u200C\u200C\u206F\u206B\u206F\u206C\u200B\u206F\u202C\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list2;
					List<Card> list;
					for (;;)
					{
						IL_000C:
						int num = 990827107;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((num2 ^ (~(-1668828588 - -251262613) - ((1720065516 - 2145095889) ^ (1942535254 ^ -768786051)))) - -772213210)) % 19U)
							{
							case 0U:
								goto IL_000C;
							case 1U:
								list = AyaFriendCirnoDef.AyaFriendCirno.\u206F\u200D\u202A\u202B\u200F\u200E\u202B\u206E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u202B\u202E\u200E\u200B\u206C\u200B\u202A\u202D\u200E\u202A\u202D\u202B\u200D\u206D\u206E\u202A\u206E\u202D\u202A\u200D\u200F\u206A\u200C\u206A\u202C\u202E(this, list2.Count, false).ToList<Card>();
								num = 11469012;
								continue;
							case 2U:
							{
								int? num4 = AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206D\u200C\u206C\u200D\u200F\u202E\u200F\u206A\u206B\u200D\u200D\u202D\u200F\u200B\u200D\u202D\u200C\u202B\u206A\u200D\u200E\u200F\u202E\u206E\u202D\u200B\u206F\u202A\u206C\u200B\u202B\u200B\u200C\u206A\u206C\u200E\u202A\u200E\u206C\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206D\u200B\u206A\u206B\u202A\u202D\u200B\u206D\u200C\u200D\u202A\u200E\u206A\u200F\u202D\u202D\u206B\u206D\u202C\u206A\u206D\u206E\u206D\u206C\u200C\u206B\u200E\u202B\u206F\u200B\u200C\u200F\u202E\u200F\u200B\u200E\u202C\u206E\u206C\u202E\u202E(this));
								num = ((num4 == null) ? (-783372488) : 1146131582);
								continue;
							}
							case 3U:
								list2 = new List<FriendToken>();
								num = (int)((num3 * 3630487707U) ^ 2149508730U);
								continue;
							case 4U:
								num = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(this) >= -AyaFriendCirnoDef.AyaFriendCirno.\u202B\u206E\u206B\u206C\u206E\u200C\u200C\u202B\u206B\u200B\u200C\u202D\u202C\u202A\u200C\u200E\u206C\u206C\u202D\u202B\u200F\u202B\u206B\u202C\u202D\u200F\u202C\u206C\u200D\u200C\u200B\u200D\u202A\u200B\u200C\u200D\u206C\u200F\u206D\u206B\u202E(this)) ? 156290850U : 420371012U) ^ (num3 * 2410245627U));
								continue;
							case 5U:
								list2.Add(FriendToken.Active2);
								num = (int)((num3 * 1574070272U) ^ 2879903544U);
								continue;
							case 6U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 50035236U : 2408987348U) ^ (num3 * 987510317U));
								continue;
							}
							case 7U:
							{
								int? num4 = AyaFriendCirnoDef.AyaFriendCirno.\u200B\u206A\u206E\u206D\u200D\u202E\u200C\u206F\u206C\u206D\u206C\u200C\u202C\u200F\u202C\u206C\u202E\u206A\u206D\u202C\u206A\u200E\u202C\u206F\u202A\u202A\u200D\u200D\u206C\u206A\u206A\u200E\u200B\u200C\u206E\u206B\u202D\u200B\u202C\u202D\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206D\u200B\u206A\u206B\u202A\u202D\u200B\u206D\u200C\u200D\u202A\u200E\u206A\u200F\u202D\u202D\u206B\u206D\u202C\u206A\u206D\u206E\u206D\u206C\u200C\u206B\u200E\u202B\u206F\u200B\u200C\u200F\u202E\u200F\u200B\u200E\u202C\u206E\u206C\u202E\u202E(this));
								num = (int)((num3 * 1099204612U) ^ 4211172197U);
								continue;
							}
							case 8U:
								if (AyaFriendCirnoDef.AyaFriendCirno.\u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 2997843275U) ^ 1303805072U);
									continue;
								}
								goto IL_0408;
							case 9U:
								if (AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206D\u200E\u200C\u202D\u200B\u202E\u202B\u206B\u200F\u206E\u206F\u206B\u202E\u206F\u200D\u200F\u206B\u206F\u206D\u202E\u206E\u202A\u200B\u206B\u200F\u206B\u206F\u206F\u202D\u202E\u202E\u200C\u206F\u200C\u200F\u200C\u206A\u206D\u200D\u202E(this))
								{
									num = (int)((num3 * 918779907U) ^ 4146008983U);
									continue;
								}
								goto IL_0408;
							case 10U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 861604254U : 449644178U) ^ (num3 * 3127487572U));
								continue;
							}
							case 11U:
								num = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(this) < -AyaFriendCirnoDef.AyaFriendCirno.\u202E\u206F\u202B\u206E\u202A\u206A\u202C\u206E\u202E\u202E\u200D\u202E\u206E\u206E\u200C\u200F\u202D\u202B\u202D\u202B\u202B\u200F\u200C\u206A\u202A\u202B\u206C\u206F\u206C\u206C\u202D\u206C\u206D\u206D\u206D\u206A\u200B\u206B\u206A\u200F\u202E(this)) ? 3586154598U : 1003804713U) ^ (num3 * 2316293415U));
								continue;
							case 12U:
							{
								int? num4 = AyaFriendCirnoDef.AyaFriendCirno.\u200F\u202D\u206B\u200D\u200D\u202A\u202D\u200C\u206C\u200D\u202B\u200C\u202C\u200F\u206B\u202A\u206D\u206B\u200D\u206C\u206B\u202B\u200E\u206D\u202C\u206C\u202A\u206F\u200B\u200F\u200C\u202D\u202D\u200B\u202B\u206D\u200D\u206B\u206A\u202B\u202E(AyaFriendCirnoDef.AyaFriendCirno.\u206D\u200B\u206A\u206B\u202A\u202D\u200B\u206D\u200C\u200D\u202A\u200E\u206A\u200F\u202D\u202D\u206B\u206D\u202C\u206A\u206D\u206E\u206D\u206C\u200C\u206B\u200E\u202B\u206F\u200B\u200C\u200F\u202E\u200F\u200B\u200E\u202C\u206E\u206C\u202E\u202E(this));
								num = (int)((num3 * 2237106802U) ^ 2142624781U);
								continue;
							}
							case 13U:
								num = (int)(((!this.ActiveUsed) ? 4185138390U : 724555153U) ^ (num3 * 3486688488U));
								continue;
							case 14U:
								list2.Add(FriendToken.Ultimate);
								num = (int)((num3 * 167814487U) ^ 1677736582U);
								continue;
							case 15U:
								num = ((!AyaFriendCirnoDef.AyaFriendCirno.\u206A\u200B\u206B\u200C\u202B\u202B\u206B\u200F\u206C\u206E\u200D\u202A\u206F\u202D\u202A\u202A\u200C\u202C\u206A\u202E\u202D\u202E\u200E\u200B\u200C\u206E\u200E\u200E\u202D\u206F\u200C\u200B\u206D\u206B\u200D\u206A\u202E\u206F\u202D\u202B\u202E(this)) ? 677246108 : 940853846);
								continue;
							case 17U:
								num = (int)(((AyaFriendCirnoDef.AyaFriendCirno.\u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(this) >= -AyaFriendCirnoDef.AyaFriendCirno.\u206D\u206A\u202E\u200B\u200C\u200D\u202D\u206D\u200E\u206F\u206A\u200B\u206F\u200B\u206B\u200B\u206F\u200E\u206D\u200D\u200B\u200E\u206F\u206E\u202D\u200E\u200D\u206D\u202E\u206D\u206F\u206B\u200B\u206B\u206D\u206C\u202C\u202D\u202E\u200D\u202E(this)) ? 493420672U : 4254976068U) ^ (num3 * 744710389U));
								continue;
							case 18U:
								list2.Add(FriendToken.Active);
								num = (int)((num3 * 1306659262U) ^ 165766711U);
								continue;
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
							IL_0358:
							int num5 = (AyaFriendCirnoDef.AyaFriendCirno.\u202E\u206E\u200E\u202B\u202B\u206A\u200F\u202E\u206A\u206E\u200F\u200B\u200C\u202E\u200F\u206E\u200B\u206A\u202B\u202A\u202C\u202A\u206B\u206F\u206C\u206B\u202D\u206F\u206C\u206A\u206A\u206D\u202D\u200C\u202D\u200B\u206D\u200F\u206D\u200D\u202E(enumerator) ? 781231311 : (-179484560));
							for (;;)
							{
								int num2 = num5;
								uint num3;
								switch ((num3 = (uint)((num2 ^ (~(-1668828588 - -251262613) - ((1720065516 - 2145095889) ^ (1942535254 ^ -768786051)))) - -772213210)) % 5U)
								{
								case 1U:
								{
									int item;
									FriendToken item2;
									AyaFriendCirnoDef.AyaFriendCirno.\u206A\u206C\u200C\u202A\u200C\u200D\u202D\u206F\u200E\u202C\u206E\u202A\u202E\u202D\u202A\u206E\u206C\u202C\u200F\u206D\u200C\u206E\u202E\u202B\u206F\u202E\u206F\u206B\u206A\u206A\u202A\u206A\u202B\u206B\u202B\u200D\u206B\u202A\u206F\u202C\u202E(list[item], item2);
									num5 = (int)((num3 * 1954251179U) ^ 2368747871U);
									continue;
								}
								case 2U:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									num5 = 201473520;
									continue;
								}
								case 3U:
									num5 = 781231311;
									continue;
								case 4U:
									goto IL_0358;
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
								IL_039B:
								int num6 = 1332996167;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)((num2 ^ (~(-1668828588 - -251262613) - ((1720065516 - 2145095889) ^ (1942535254 ^ -768786051)))) - -772213210)) % 3U)
									{
									case 0U:
										goto IL_039B;
									case 2U:
										AyaFriendCirnoDef.AyaFriendCirno.\u200D\u206D\u206F\u202E\u202E\u202A\u200F\u206D\u206C\u206E\u206A\u200F\u206A\u202B\u200D\u202E\u202C\u200E\u206C\u202E\u202A\u200F\u206B\u206C\u200B\u206F\u206C\u206F\u202A\u206B\u206A\u206E\u202D\u202A\u200F\u202A\u202E\u206C\u200D\u202E\u202E(enumerator);
										num6 = (int)((num3 * 1065435022U) ^ 1995323494U);
										continue;
									}
									goto Block_17;
								}
							}
							Block_17:;
						}
					}
					return AyaFriendCirnoDef.AyaFriendCirno.\u202C\u206E\u206A\u202B\u206E\u202C\u206B\u200D\u206E\u206E\u206A\u200F\u202D\u202A\u200D\u202E\u206D\u202B\u202A\u200E\u206F\u200F\u206F\u206E\u200E\u206A\u206D\u206A\u200C\u200C\u206C\u202E\u202B\u206A\u202B\u206C\u200C\u202E\u200E\u206F\u202E(list, false, false, false);
				}
				IL_0408:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendCirnoDef.AyaFriendCirno.<Actions>d__20 <Actions>d__ = new AyaFriendCirnoDef.AyaFriendCirno.<Actions>d__20(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				AyaFriendCirnoDef.AyaFriendCirno.<AfterUseAction>d__21 <AfterUseAction>d__ = new AyaFriendCirnoDef.AyaFriendCirno.<AfterUseAction>d__21(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static CardConfig \u206D\u200B\u206A\u206B\u202A\u202D\u200B\u206D\u200C\u200D\u202A\u200E\u206A\u200F\u202D\u202D\u206B\u206D\u202C\u206A\u206D\u206E\u206D\u206C\u200C\u206B\u200E\u202B\u206F\u200B\u200C\u200F\u202E\u200F\u200B\u200E\u202C\u206E\u206C\u202E\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u202C\u206B\u206C\u206A\u202E\u206F\u206A\u200C\u200C\u202E\u206E\u202A\u206A\u206A\u200B\u206D\u206A\u202B\u200E\u202E\u206D\u200B\u206F\u206C\u206C\u202B\u200B\u202B\u206E\u202E\u202A\u202C\u206C\u202A\u202E\u200C\u200B\u202C\u200C\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u202C\u206C\u206E\u200F\u200F\u202D\u200D\u202E\u206B\u200C\u200D\u206B\u202B\u206C\u200F\u200B\u202B\u200F\u206C\u206F\u206A\u206B\u202B\u206F\u200E\u206E\u202E\u202B\u200D\u206F\u206C\u200C\u200C\u206F\u206B\u206F\u206C\u200B\u206F\u202C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u206F\u206E\u202D\u200F\u202D\u206F\u206E\u200D\u202C\u206A\u206E\u206A\u200B\u200F\u206D\u202E\u206D\u206E\u200F\u206C\u200E\u202E\u206D\u202D\u200C\u202E\u206F\u202C\u206A\u206A\u200B\u202E\u206B\u202D\u206E\u202B\u206D\u200C\u206E\u206C\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static string \u206C\u202E\u200F\u206E\u200D\u206B\u202B\u200F\u202C\u200C\u202D\u202C\u200B\u202C\u206C\u200D\u200E\u200C\u202A\u200F\u206A\u200D\u202B\u200B\u200F\u206E\u202C\u206D\u202E\u206A\u206E\u202C\u200D\u202A\u200B\u206B\u202A\u206A\u206C\u202E\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static bool \u206A\u200B\u206B\u200C\u202B\u202B\u206B\u200F\u206C\u206E\u200D\u202A\u206F\u202D\u202A\u202A\u200C\u202C\u206A\u202E\u202D\u202E\u200E\u200B\u200C\u206E\u200E\u200E\u202D\u206F\u200C\u200B\u206D\u206B\u200D\u206A\u202E\u206F\u202D\u202B\u202E(Card A_0)
			{
				return A_0.UltimateUsed;
			}

			static ArgumentOutOfRangeException \u200E\u206A\u206E\u202C\u206D\u202E\u206A\u200D\u206C\u206F\u206D\u206F\u206C\u202E\u202E\u202A\u206A\u200F\u206C\u202C\u206D\u202A\u200C\u200F\u206F\u200E\u202D\u206D\u200F\u202A\u200F\u202B\u200B\u200F\u202B\u200F\u200C\u206E\u206C\u206F\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200D\u206F\u200C\u200C\u202D\u200F\u206E\u200F\u202C\u200E\u200F\u202A\u200C\u206C\u202A\u202E\u206D\u202D\u200B\u206D\u202B\u206C\u200C\u200C\u200F\u206F\u206B\u202C\u206E\u202E\u200B\u200B\u200B\u206A\u206B\u200B\u202D\u200E\u200C\u202E\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static BattleController \u206A\u206D\u200E\u206A\u200D\u200F\u202A\u202C\u206C\u202E\u200D\u200C\u206E\u200B\u200D\u206D\u200B\u202D\u206C\u202E\u200C\u200E\u200E\u206F\u202A\u206C\u206E\u206B\u206C\u202A\u206C\u202C\u200B\u200B\u202B\u206F\u200E\u200E\u202A\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202D\u206F\u206D\u202D\u206B\u206A\u202D\u200F\u206F\u206B\u206C\u206F\u202B\u202C\u206E\u200D\u206F\u206D\u206D\u202D\u206E\u206C\u200D\u202A\u200D\u202B\u200E\u200F\u202C\u206B\u206E\u200E\u202E\u202A\u202A\u202E\u202A\u206E\u206B\u202D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static int \u202D\u206B\u200B\u206C\u206B\u202A\u200C\u202C\u200E\u206F\u200F\u206A\u200D\u206D\u206F\u200E\u200F\u206F\u206E\u206B\u206A\u200F\u200C\u206F\u200E\u200E\u202D\u206A\u200C\u200E\u200F\u206F\u206A\u202A\u206F\u200B\u202A\u202A\u206B\u206C\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static bool \u206D\u206E\u206E\u200E\u206E\u200F\u206A\u202A\u206D\u206B\u206D\u206C\u202B\u200E\u206D\u206D\u200E\u200D\u200F\u202A\u206E\u206E\u206E\u200F\u202C\u206B\u202E\u206C\u200F\u206F\u200B\u200E\u206A\u206C\u200B\u206D\u200E\u206B\u202B\u202C\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static CardConfig \u200D\u200D\u200E\u206E\u200E\u206C\u202D\u202A\u200D\u206B\u200B\u202E\u200F\u206E\u200F\u206B\u200C\u206F\u206C\u200D\u206F\u200B\u206F\u206D\u202B\u200C\u202C\u200B\u202D\u206C\u206B\u202C\u200D\u202B\u206F\u202E\u202A\u206A\u200D\u200E\u202E(string A_0)
			{
				return CardConfig.FromId(A_0);
			}

			static string \u206F\u206C\u206C\u200F\u206F\u202C\u200F\u202C\u202E\u206A\u206B\u202B\u202C\u200D\u200E\u206E\u200F\u200D\u200E\u206C\u206B\u206E\u200E\u206E\u200C\u206B\u202A\u202D\u206F\u200F\u202D\u202E\u202C\u200C\u200B\u206F\u206C\u200D\u200F\u200F\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static NullReferenceException \u200B\u202C\u202B\u206B\u206F\u206F\u202C\u200B\u202B\u200F\u200C\u206E\u202D\u202C\u206E\u206B\u200E\u202C\u202D\u206B\u202E\u200D\u206A\u202E\u200E\u202D\u200D\u206C\u202B\u202C\u202C\u206C\u206C\u202D\u200B\u206A\u206E\u200C\u206C\u206D\u202E()
			{
				return new NullReferenceException();
			}

			static int \u202B\u200C\u200C\u200C\u206F\u202A\u206D\u206B\u200E\u206C\u202A\u202B\u200E\u206D\u206D\u206C\u206F\u206B\u202B\u202A\u200D\u202C\u206B\u206F\u202B\u200C\u206A\u206A\u202D\u202E\u206A\u206D\u202A\u202D\u206A\u202D\u200D\u202B\u202D\u202A\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int \u202D\u202D\u200D\u206E\u206F\u202D\u200D\u200B\u202B\u206B\u202C\u202C\u200D\u206F\u200F\u206C\u206F\u202D\u200E\u202B\u202B\u202E\u206E\u200F\u202A\u202D\u200E\u206E\u206A\u202B\u206B\u200B\u206D\u200D\u200F\u206B\u206B\u206F\u200B\u206D\u202E(Card A_0)
			{
				return A_0.PassiveCost;
			}

			static void \u206F\u202D\u206D\u206C\u200F\u200E\u202A\u200D\u206C\u206D\u202C\u202D\u206D\u206C\u200F\u202B\u206D\u202C\u200C\u200B\u206F\u206E\u206B\u200F\u206D\u200D\u202B\u202D\u202C\u200C\u206B\u202C\u206F\u202C\u206B\u202E\u206C\u206A\u206A\u202E\u202E(Card A_0, int A_1)
			{
				A_0.Loyalty = A_1;
			}

			static GameEvent<CardMovingEventArgs> \u200E\u206B\u206F\u202C\u206B\u206F\u206E\u200B\u206C\u202B\u200C\u202C\u200E\u202C\u200B\u200D\u206D\u206E\u202A\u200F\u202D\u206B\u206B\u206C\u206D\u206B\u206C\u200F\u206D\u206F\u200E\u206E\u206D\u206D\u206D\u206D\u206E\u206E\u200C\u200F\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u206E\u206B\u202E\u200E\u206A\u206F\u202B\u206A\u200E\u200C\u200F\u200F\u200B\u200E\u202E\u200E\u206A\u202C\u202B\u200E\u200E\u200C\u206F\u202A\u206F\u200B\u200C\u202B\u206E\u202E\u200C\u202A\u206B\u206E\u206B\u206F\u200C\u206A\u202D\u206D\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u206D\u206F\u200D\u202D\u200B\u202E\u200B\u202A\u202E\u206D\u206A\u202E\u200E\u202E\u206E\u202E\u206F\u202D\u206A\u206C\u206C\u200C\u200F\u206B\u206C\u206D\u206F\u202C\u200C\u202E\u200B\u202D\u206C\u206F\u206F\u202B\u206B\u206C\u202A\u206D\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u202E\u202B\u200F\u200F\u202D\u200F\u202D\u200E\u200E\u202E\u206C\u202D\u200B\u206E\u202E\u202E\u206A\u206B\u200D\u206B\u200D\u206D\u206B\u200E\u200F\u200B\u206B\u200B\u200D\u200B\u206F\u200E\u202B\u200F\u206C\u200B\u206C\u200E\u200D\u202E\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u200B\u202E\u202B\u206F\u200D\u206A\u206D\u200F\u200E\u200D\u200B\u206B\u200B\u202D\u200E\u206F\u200E\u200B\u200F\u206C\u206E\u206E\u202D\u202D\u200E\u202E\u206D\u200E\u202C\u206F\u202A\u202A\u202D\u202D\u206A\u206F\u206F\u200D\u206E\u202D\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u202C\u206A\u200D\u202C\u202B\u206A\u206B\u206C\u206B\u206F\u202E\u200D\u200D\u206F\u200F\u200B\u200E\u200D\u202D\u200C\u200F\u206B\u202E\u202B\u202D\u206E\u202C\u200B\u206E\u202E\u202C\u202A\u206F\u202A\u202E\u202B\u206F\u206A\u206D\u200F\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static PlayerUnit \u206C\u206C\u200C\u200B\u202C\u200C\u202E\u200F\u206A\u200F\u200C\u200B\u200E\u200B\u206C\u206A\u202C\u202B\u200E\u206B\u206F\u202A\u202E\u206F\u202D\u206E\u200F\u200B\u206F\u202A\u202A\u206E\u206D\u206D\u206D\u200E\u202A\u200C\u200E\u202E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206F\u202D\u206D\u200E\u200D\u200C\u200D\u202A\u206A\u200C\u206D\u206C\u202B\u202A\u200C\u202A\u206B\u200D\u200D\u200F\u206E\u206E\u200C\u206F\u206F\u206C\u202D\u206D\u206D\u200F\u206F\u200D\u206A\u206F\u206E\u202E\u200B\u206B\u200F\u202E\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static Card \u200C\u206E\u202B\u200B\u200C\u206D\u200C\u202C\u200E\u206F\u202B\u202C\u206C\u200D\u202A\u202B\u200C\u200E\u206C\u206C\u202E\u202D\u206C\u206F\u202E\u206C\u200D\u206B\u206D\u202E\u206C\u206B\u200D\u200D\u200D\u202D\u202E\u206F\u206B\u206E\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u202E\u206A\u200E\u206E\u206F\u200C\u202E\u200B\u200E\u200F\u206F\u206B\u206A\u202D\u206F\u202C\u206A\u202C\u200E\u206D\u206D\u206F\u206E\u200E\u200D\u202E\u206C\u202B\u202C\u200F\u202D\u200B\u202A\u206A\u200C\u200F\u200B\u206E\u206B\u200F\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u200D\u202A\u200E\u202E\u206A\u200D\u206A\u202C\u206F\u200B\u200E\u202D\u202A\u206B\u202A\u206E\u200E\u206A\u202B\u200E\u206E\u206C\u200F\u200D\u200E\u206E\u200D\u206F\u206A\u202A\u202B\u200E\u200C\u200F\u200D\u206C\u206B\u200C\u206E\u200C\u202E(GameEventArgs A_0, CancelCause A_1)
			{
				A_0.ForceCancelBecause(A_1);
			}

			static Card \u202D\u200D\u206E\u202B\u202C\u200D\u200C\u202E\u206C\u202A\u206C\u202E\u206A\u200C\u206A\u206D\u206A\u206C\u200D\u200F\u202B\u206B\u202A\u200B\u200D\u206E\u206C\u206D\u200E\u202B\u206C\u200E\u202A\u200C\u202C\u206A\u206D\u200E\u200E\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202B\u206B\u206E\u206F\u200C\u206F\u202D\u202D\u200E\u206B\u200B\u202E\u206C\u202C\u206C\u200E\u202A\u206E\u200E\u206C\u200F\u206E\u200F\u200F\u202C\u202D\u202C\u200D\u200E\u206E\u202A\u206D\u202E\u200F\u202E\u202E\u206E\u202D\u200B\u202A\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202A\u200D\u200F\u206E\u202C\u202A\u200D\u202D\u206D\u206D\u206F\u206C\u202C\u202D\u202C\u200D\u206C\u202B\u200F\u200E\u206B\u202C\u200F\u202D\u206F\u206E\u202A\u200B\u202C\u202B\u206E\u200B\u202D\u200F\u206A\u200C\u200C\u202B\u206B\u200F\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			static IEnumerable<BattleAction> \u200F\u200F\u202C\u200E\u202A\u200B\u202C\u200F\u206F\u200E\u206C\u206F\u200E\u202C\u206C\u202C\u206D\u202C\u200C\u206C\u202B\u200B\u202D\u200F\u202A\u202A\u206F\u202B\u206A\u206E\u202C\u200F\u206D\u206E\u202E\u200D\u200F\u200E\u200F\u202C\u202E(Card A_0)
			{
				return A_0.GetPassiveActions();
			}

			static bool \u206A\u206D\u200E\u200C\u202D\u200B\u202E\u202B\u206B\u200F\u206E\u206F\u206B\u202E\u206F\u200D\u200F\u206B\u206F\u206D\u202E\u206E\u202A\u200B\u206B\u200F\u206B\u206F\u206F\u202D\u202E\u202E\u200C\u206F\u200C\u200F\u200C\u206A\u206D\u200D\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int? \u200F\u202D\u206B\u200D\u200D\u202A\u202D\u200C\u206C\u200D\u202B\u200C\u202C\u200F\u206B\u202A\u206D\u206B\u200D\u206C\u206B\u202B\u200E\u206D\u202C\u206C\u202A\u206F\u200B\u200F\u200C\u202D\u202D\u200B\u202B\u206D\u200D\u206B\u206A\u202B\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206D\u206A\u202E\u200B\u200C\u200D\u202D\u206D\u200E\u206F\u206A\u200B\u206F\u200B\u206B\u200B\u206F\u200E\u206D\u200D\u200B\u200E\u206F\u206E\u202D\u200E\u200D\u206D\u202E\u206D\u206F\u206B\u200B\u206B\u206D\u206C\u202C\u202D\u202E\u200D\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u202C\u206D\u200C\u206C\u200D\u200F\u202E\u200F\u206A\u206B\u200D\u200D\u202D\u200F\u200B\u200D\u202D\u200C\u202B\u206A\u200D\u200E\u200F\u202E\u206E\u202D\u200B\u206F\u202A\u206C\u200B\u202B\u200B\u200C\u206A\u206C\u200E\u202A\u200E\u206C\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u202E\u206F\u202B\u206E\u202A\u206A\u202C\u206E\u202E\u202E\u200D\u202E\u206E\u206E\u200C\u200F\u202D\u202B\u202D\u202B\u202B\u200F\u200C\u206A\u202A\u202B\u206C\u206F\u206C\u206C\u202D\u206C\u206D\u206D\u206D\u206A\u200B\u206B\u206A\u200F\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u200B\u206A\u206E\u206D\u200D\u202E\u200C\u206F\u206C\u206D\u206C\u200C\u202C\u200F\u202C\u206C\u202E\u206A\u206D\u202C\u206A\u200E\u202C\u206F\u202A\u202A\u200D\u200D\u206C\u206A\u206A\u200E\u200B\u200C\u206E\u206B\u202D\u200B\u202C\u202D\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u202B\u206E\u206B\u206C\u206E\u200C\u200C\u202B\u206B\u200B\u200C\u202D\u202C\u202A\u200C\u200E\u206C\u206C\u202D\u202B\u200F\u202B\u206B\u202C\u202D\u200F\u202C\u206C\u200D\u200C\u200B\u200D\u202A\u200B\u200C\u200D\u206C\u200F\u206D\u206B\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u206F\u200D\u202A\u202B\u200F\u200E\u202B\u206E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u202B\u202E\u200E\u200B\u206C\u200B\u202A\u202D\u200E\u202A\u202D\u202B\u200D\u206D\u206E\u202A\u206E\u202D\u202A\u200D\u200F\u206A\u200C\u206A\u202C\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u206A\u206C\u200C\u202A\u200C\u200D\u202D\u206F\u200E\u202C\u206E\u202A\u202E\u202D\u202A\u206E\u206C\u202C\u200F\u206D\u200C\u206E\u202E\u202B\u206F\u202E\u206F\u206B\u206A\u206A\u202A\u206A\u202B\u206B\u202B\u200D\u206B\u202A\u206F\u202C\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static bool \u202E\u206E\u200E\u202B\u202B\u206A\u200F\u202E\u206A\u206E\u200F\u200B\u200C\u202E\u200F\u206E\u200B\u206A\u202B\u202A\u202C\u202A\u206B\u206F\u206C\u206B\u202D\u206F\u206C\u206A\u206A\u206D\u202D\u200C\u202D\u200B\u206D\u200F\u206D\u200D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200D\u206D\u206F\u202E\u202E\u202A\u200F\u206D\u206C\u206E\u206A\u200F\u206A\u202B\u200D\u202E\u202C\u200E\u206C\u202E\u202A\u200F\u206B\u206C\u200B\u206F\u206C\u206F\u202A\u206B\u206A\u206E\u202D\u202A\u200F\u202A\u202E\u206C\u200D\u202E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static MiniSelectCardInteraction \u202C\u206E\u206A\u202B\u206E\u202C\u206B\u200D\u206E\u206E\u206A\u200F\u202D\u202A\u200D\u202E\u206D\u202B\u202A\u200E\u206F\u200F\u206F\u206E\u200E\u206A\u206D\u206A\u200C\u200C\u206C\u202E\u202B\u206A\u202B\u206C\u200C\u202E\u200E\u206F\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}
		}
	}
}
