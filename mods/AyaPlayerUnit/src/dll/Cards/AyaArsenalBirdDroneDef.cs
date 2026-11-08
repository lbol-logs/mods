using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
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
	public sealed class AyaArsenalBirdDroneDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1604106198);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaArsenalBirdDroneDef.\u200C\u202C\u202A\u206E\u206D\u200B\u200D\u202E\u200D\u206F\u206C\u206A\u202C\u200E\u200B\u206A\u200E\u206D\u202E\u200F\u206F\u202E\u202C\u200B\u206A\u206D\u200D\u200C\u200C\u200F\u206B\u202A\u200B\u200D\u202D\u200E\u200D\u202B\u206B\u202A\u202E(BepinexPlugin.embeddedSource);
			AyaArsenalBirdDroneDef.\u200B\u200D\u202E\u206B\u202C\u206F\u202B\u206F\u200F\u202B\u206A\u200D\u202E\u202C\u200B\u206A\u206B\u202A\u200B\u202C\u206F\u200F\u206F\u206F\u200C\u206D\u200F\u202B\u200C\u202B\u206C\u206B\u206B\u202D\u200F\u200F\u200F\u200C\u202C\u200C\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaArsenalBirdDroneDef.\u202D\u206B\u206E\u202D\u200D\u206B\u206A\u206A\u202A\u200B\u206E\u202E\u206F\u200E\u202D\u206D\u202B\u200D\u202D\u202D\u206A\u200B\u206F\u200D\u202A\u206B\u206E\u200D\u206C\u206B\u202D\u206B\u200D\u200E\u202D\u206A\u200B\u200C\u206A\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaArsenalBirdDroneDef.\u202A\u206C\u202D\u202C\u200D\u202A\u200B\u200D\u202A\u206E\u206C\u202A\u200F\u206A\u206C\u202D\u200E\u206E\u206B\u206C\u200C\u202A\u202D\u206E\u206D\u200C\u200C\u202E\u206E\u202E\u206B\u206D\u202C\u200D\u200E\u206C\u200C\u206F\u202E\u202A\u202E(BepinexPlugin.sequenceTable, AyaArsenalBirdDroneDef.\u200C\u206F\u206B\u200D\u200D\u200C\u202D\u206E\u200C\u202E\u206A\u200B\u200E\u206F\u202E\u200B\u200C\u206C\u200D\u200E\u206F\u200E\u202B\u206B\u202A\u202B\u202C\u200D\u200E\u206A\u202C\u200C\u206E\u206A\u206B\u206B\u202D\u202C\u206E\u200C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(523486508), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(153643752), 0, false, false, true, true, false, Rarity.Uncommon, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Colorless }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(8), null, new int?(8), null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			}), null, null, null, null, new int?(6), null, new int?(-1), null, new int?(0), null, null, null, new int?(0), null, Keyword.None, Keyword.None, false, Keyword.Accuracy | Keyword.Block | Keyword.Philosophy | Keyword.Exile, Keyword.Accuracy | Keyword.Block | Keyword.Philosophy | Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1412174209), new List<string>());
		}

		static CardImages \u200C\u202C\u202A\u206E\u206D\u200B\u200D\u202E\u200D\u206F\u206C\u206A\u202C\u200E\u200B\u206A\u200E\u206D\u202E\u200F\u206F\u202E\u202C\u200B\u206A\u206D\u200D\u200C\u200C\u200F\u206B\u202A\u200B\u200D\u202D\u200E\u200D\u202B\u206B\u202A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200B\u200D\u202E\u206B\u202C\u206F\u202B\u206F\u200F\u202B\u206A\u200D\u202E\u202C\u200B\u206A\u206B\u202A\u200B\u202C\u206F\u200F\u206F\u206F\u200C\u206D\u200F\u202B\u200C\u202B\u206C\u206B\u206B\u202D\u200F\u200F\u200F\u200C\u202C\u200C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u206B\u206E\u202D\u200D\u206B\u206A\u206A\u202A\u200B\u206E\u202E\u206F\u200E\u202D\u206D\u202B\u200D\u202D\u202D\u206A\u200B\u206F\u200D\u202A\u206B\u206E\u200D\u206C\u206B\u202D\u206B\u200D\u200E\u202D\u206A\u200B\u200C\u206A\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200C\u206F\u206B\u200D\u200D\u200C\u202D\u206E\u200C\u202E\u206A\u200B\u200E\u206F\u202E\u200B\u200C\u206C\u200D\u200E\u206F\u200E\u202B\u206B\u202A\u202B\u202C\u200D\u200E\u206A\u202C\u200C\u206E\u206A\u206B\u206B\u202D\u202C\u206E\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206C\u202D\u202C\u200D\u202A\u200B\u200D\u202A\u206E\u206C\u202A\u200F\u206A\u206C\u202D\u200E\u206E\u206B\u206C\u200C\u202A\u202D\u206E\u206D\u200C\u200C\u202E\u206E\u202E\u206B\u206D\u202C\u200D\u200E\u206C\u200C\u206F\u202E\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaArsenalBirdDroneDef))]
		public sealed class AyaArsenalBirdDrone : Card
		{
			public DamageInfo Damage2
			{
				get
				{
					return DamageInfo.Attack((float)(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200E\u202C\u206C\u206D\u206C\u202C\u200E\u206C\u200E\u202D\u200E\u200E\u200B\u202D\u202C\u206C\u206D\u202A\u202E\u200F\u200E\u206C\u206C\u200D\u200B\u200D\u200B\u202E\u202E\u206B\u200C\u206E\u202C\u200F\u206A\u206A\u200E\u200B\u206D\u206B\u202E(this) + AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206E\u206F\u200C\u206B\u202D\u202A\u206A\u202A\u202E\u200D\u202E\u206F\u200D\u202E\u202B\u200C\u200C\u200E\u200D\u202C\u200B\u202B\u200F\u206C\u202B\u206A\u202C\u202C\u206D\u202A\u200C\u200D\u206C\u202E\u202E\u206A\u202D\u206F\u202B\u206A\u202E(this)), true);
				}
			}

			public int PassiveBlock
			{
				get
				{
					return AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u206E\u202C\u206D\u206C\u202D\u200E\u206D\u206D\u206C\u206C\u206A\u206A\u200C\u206D\u206D\u200D\u200D\u202E\u206C\u200C\u202A\u200C\u202B\u206E\u202D\u202D\u206C\u200C\u202A\u200F\u200D\u206E\u200D\u206B\u206A\u206C\u202C\u206E\u202C\u202E(this).Block;
				}
			}

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
				if (AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206D\u206D\u200B\u202C\u206C\u202B\u202A\u202E\u202A\u206B\u206B\u206A\u206F\u200E\u202D\u202A\u200D\u202B\u200C\u202A\u206A\u200B\u206B\u200E\u200D\u200B\u202D\u206A\u206E\u200D\u200E\u202D\u206C\u202A\u206F\u202D\u206E\u202B\u202A\u200D\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u206C\u206D\u202B\u202E\u206E\u200D\u200E\u206E\u200F\u200C\u206F\u202D\u202A\u206A\u206C\u202C\u200F\u206A\u206E\u202C\u200E\u200E\u206E\u206C\u200B\u206D\u200B\u200C\u206D\u206F\u206D\u200C\u200C\u200F\u202D\u206B\u200C\u206E\u206E\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_02A5;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text2;
					string text3;
					string text4;
					switch ((num3 = (uint)(-((num * 2136316669) ^ ((584300012 ^ 132151221) + -520869553 * -1086882493)) * -1625631047)) % 50U)
					{
					case 0U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, this.ExtraDescription4);
						num2 = (int)((num3 * 1274950087U) ^ 1946629672U);
						continue;
					case 1U:
						num2 = (int)((num3 * 937499801U) ^ 4258410481U);
						continue;
					case 2U:
						num2 = (int)((num3 * 3334790180U) ^ 2207776064U);
						continue;
					case 3U:
						num2 = ((this.Mode != 1) ? (-593845877) : (-15713184));
						continue;
					case 4U:
						num2 = ((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u200B\u200B\u202C\u200D\u206F\u200B\u202A\u206B\u206C\u202D\u202C\u202D\u200B\u206A\u206C\u200F\u200F\u200E\u200E\u202C\u206E\u206C\u206F\u206A\u202E\u202B\u206D\u200E\u202E\u200B\u206F\u206E\u206E\u206D\u202D\u202E\u202E\u200C\u200C\u202E(this) == 1) ? (-1037261960) : (-946732781));
						continue;
					case 5U:
						if (!AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u200D\u206C\u206F\u200F\u202B\u202D\u206D\u206B\u206F\u202D\u206D\u200E\u202A\u200E\u202E\u200C\u202E\u202D\u202C\u206C\u202D\u200C\u206E\u206C\u202D\u202D\u200F\u200F\u200F\u206F\u202E\u200C\u200F\u202D\u202E\u202E\u200E\u206A\u206F\u202E(this))
						{
							num2 = -1222832032;
							continue;
						}
						text2 = base.UpgradedExtraDescription2 ?? base.ExtraDescription2;
						goto IL_0530;
					case 6U:
						num2 = (int)((num3 * 146404048U) ^ 2640411256U);
						continue;
					case 7U:
						text3 = base.BaseDescription;
						goto IL_0243;
					case 8U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
						num2 = (int)((num3 * 2320226207U) ^ 3890332006U);
						continue;
					case 9U:
						goto IL_01CD;
					case 10U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription2);
						num2 = (int)((num3 * 1903582798U) ^ 2482166831U);
						continue;
					case 11U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription3);
						num2 = (int)((num3 * 2205311775U) ^ 2519605579U);
						continue;
					case 12U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.BaseDescription);
						num2 = (int)((num3 * 2378094255U) ^ 2542488637U);
						continue;
					case 13U:
						num2 = (int)(((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(this) != null) ? 971808302U : 871203230U) ^ (num3 * 804606288U));
						continue;
					case 14U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						num2 = (int)((num3 * 2169978648U) ^ 4180271807U);
						continue;
					case 15U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription1);
						num2 = -1908672722;
						continue;
					case 16U:
						goto IL_0010;
					case 17U:
						num2 = (int)((num3 * 295849882U) ^ 1760769182U);
						continue;
					case 18U:
						goto IL_0607;
					case 19U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, this.ExtraDescription4);
						num2 = (int)((num3 * 4274447803U) ^ 961328735U);
						continue;
					case 20U:
						goto IL_02A5;
					case 21U:
						goto IL_0288;
					case 22U:
						if (!AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u200D\u206C\u206F\u200F\u202B\u202D\u206D\u206B\u206F\u202D\u206D\u200E\u202A\u200E\u202E\u200C\u202E\u202D\u202C\u206C\u202D\u200C\u206E\u206C\u202D\u202D\u200F\u200F\u200F\u206F\u202E\u200C\u200F\u202D\u202E\u202E\u200E\u206A\u206F\u202E(this))
						{
							num2 = (int)((num3 * 2189843466U) ^ 3959757825U);
							continue;
						}
						text3 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_0243;
					case 23U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, this.ExtraDescription4);
						num2 = (int)((num3 * 1222871985U) ^ 3120248175U);
						continue;
					case 24U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription3);
						num2 = (int)((num3 * 82196429U) ^ 3125164198U);
						continue;
					case 25U:
						text4 = base.ExtraDescription1;
						goto IL_0345;
					case 26U:
						num2 = ((base.BaseDetailText != null) ? 146832077 : (-1333505273));
						continue;
					case 27U:
						num2 = (int)(((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u200B\u200B\u202C\u200D\u206F\u200B\u202A\u206B\u206C\u202D\u202C\u202D\u200B\u206A\u206C\u200F\u200F\u200E\u200E\u202C\u206E\u206C\u206F\u206A\u202E\u202B\u206D\u200E\u202E\u200B\u206F\u206E\u206E\u206D\u202D\u202E\u202E\u200C\u200C\u202E(this) != 2) ? 1301351725U : 3532484735U) ^ (num3 * 1156034034U));
						continue;
					case 28U:
					{
						string text5;
						text = text5;
						num2 = -1619826376;
						continue;
					}
					case 30U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription2);
						num2 = (int)((num3 * 4217432081U) ^ 2405735013U);
						continue;
					case 31U:
						num2 = (int)((num3 * 1870076743U) ^ 2120797371U);
						continue;
					case 32U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription3);
						num2 = -1736508446;
						continue;
					case 33U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, base.ExtraDescription2);
						num2 = (int)((num3 * 1809787409U) ^ 4226526587U);
						continue;
					case 34U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						num2 = (int)((num3 * 3647355753U) ^ 4140286785U);
						continue;
					case 35U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1101960206));
						num2 = (int)((num3 * 2048019953U) ^ 1698340750U);
						continue;
					case 36U:
						num2 = (AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u200D\u206C\u206F\u200F\u202B\u202D\u206D\u206B\u206F\u202D\u206D\u200E\u202A\u200E\u202E\u200C\u202E\u202D\u202C\u206C\u202D\u200C\u206E\u206C\u202D\u202D\u200F\u200F\u200F\u206F\u202E\u200C\u200F\u202D\u202E\u202E\u200E\u206A\u206F\u202E(this) ? (-263084667) : 1882230000);
						continue;
					case 37U:
					{
						FriendToken friendToken;
						switch (friendToken)
						{
						case FriendToken.None:
							goto IL_01CD;
						case FriendToken.Active:
							goto IL_0288;
						case FriendToken.Active2:
							goto IL_02B5;
						case FriendToken.Ultimate:
							goto IL_0350;
						default:
							num2 = (int)((num3 * 3517132911U) ^ 2892047053U);
							continue;
						}
						break;
					}
					case 38U:
						text2 = base.ExtraDescription2;
						goto IL_0530;
					case 39U:
					{
						string text5;
						num2 = (((text5 = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription) == null) ? (-1007716062) : 84752348);
						continue;
					}
					case 40U:
						num2 = (int)((num3 * 23196056U) ^ 4063007080U);
						continue;
					case 41U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						num2 = (int)((num3 * 2126278770U) ^ 2861636368U);
						continue;
					case 42U:
					{
						string text5 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 84752348;
						continue;
					}
					case 43U:
						goto IL_0350;
					case 44U:
						if (!AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u200D\u206C\u206F\u200F\u202B\u202D\u206D\u206B\u206F\u202D\u206D\u200E\u202A\u200E\u202E\u200C\u202E\u202D\u202C\u206C\u202D\u200C\u206E\u206C\u202D\u202D\u200F\u200F\u200F\u206F\u202E\u200C\u200F\u202D\u202E\u202E\u200E\u206A\u206F\u202E(this))
						{
							num2 = -887009659;
							continue;
						}
						text4 = base.UpgradedExtraDescription1 ?? base.ExtraDescription1;
						goto IL_0345;
					case 45U:
					{
						FriendToken friendToken = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u206C\u206D\u206B\u202A\u200C\u206E\u200F\u200C\u200E\u202E\u202A\u206F\u202B\u202D\u206D\u206E\u202A\u202B\u200E\u206B\u206F\u202C\u202A\u200E\u202B\u202E\u206E\u206A\u206D\u206C\u206B\u206D\u200E\u206D\u206B\u200B\u202B\u206A\u206B\u202E(this);
						num2 = (int)((num3 * 2777719384U) ^ 2373874907U);
						continue;
					}
					case 46U:
					{
						string text5 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 84752348;
						continue;
					}
					case 47U:
						num2 = (int)(((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u202D\u200E\u200B\u200F\u202C\u202C\u200E\u206B\u202E\u202C\u206A\u202E\u200F\u202A\u200B\u206D\u200C\u206E\u200F\u206D\u206C\u200C\u200D\u202A\u200F\u206C\u206A\u200D\u200F\u206B\u200C\u206E\u200F\u202C\u202A\u202E\u206F\u202C\u206C\u202E(this) != CardType.Friend) ? 3340208767U : 853224312U) ^ (num3 * 2856581521U));
						continue;
					case 48U:
						goto IL_02B5;
					case 49U:
						text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
						num2 = (int)((num3 * 1544857159U) ^ 702583954U);
						continue;
					}
					break;
					IL_01CD:
					num2 = ((this.Mode == 0) ? (-608107073) : 1563516389);
					continue;
					IL_0243:
					text = text3;
					num2 = -1619826376;
					continue;
					IL_0288:
					num2 = ((this.Switch != 1) ? 1097602636 : (-944651964));
					continue;
					IL_0345:
					text = text4;
					num2 = -1619826376;
					continue;
					IL_0350:
					text = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(text, this.ExtraDescription4);
					num2 = 65174745;
					continue;
					IL_0530:
					text = text2;
					num2 = 695577493;
				}
				return text;
				IL_02B5:
				throw AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u206E\u202E\u200F\u202A\u200B\u202A\u202D\u200E\u202A\u202E\u202E\u206D\u202C\u206D\u200F\u200C\u200C\u202B\u200D\u206E\u202D\u206B\u206A\u206F\u206F\u206E\u200F\u206F\u202E\u206D\u202E\u200C\u200C\u206D\u206A\u200C\u200B\u206B\u206B\u202E();
				IL_0607:
				return string.Empty;
				IL_0010:
				num2 = 1210650466;
				goto IL_0015;
				IL_02A5:
				text = string.Empty;
				num2 = -1545139679;
				goto IL_0015;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void OnRemove()
			{
				if (!AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206C\u200C\u202C\u202A\u202A\u202D\u206C\u206A\u202D\u206A\u202D\u202E\u206C\u206C\u202B\u206F\u202A\u202C\u202A\u206B\u200D\u202D\u200C\u200F\u200D\u206B\u206F\u200B\u200B\u206E\u206F\u202B\u200C\u202A\u200F\u206D\u200D\u200D\u206C\u206E\u202E(this))
				{
					for (;;)
					{
						IL_000B:
						int num = 1436220958;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(num2 - -(--1342878110 ^ (1528831425 + 1369336149)) - (~1391205711 + -1994886521) + 1956570149 * 1906375013 - 888736375)) % 4U)
							{
							case 0U:
								goto IL_000B;
							case 1U:
								num = (int)(((!AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206E\u206E\u206B\u202E\u202C\u206C\u200E\u202D\u202C\u200B\u200B\u202B\u206C\u206E\u202B\u206D\u206A\u206C\u202E\u206F\u200F\u200B\u202C\u200F\u206B\u206F\u206A\u200C\u200F\u200B\u206C\u206C\u200D\u202D\u202E\u202B\u202B\u206F\u206E\u206C\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(this))) ? 18483959U : 685670188U) ^ (num3 * 2489948976U));
								continue;
							case 2U:
								this.React(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200C\u200B\u206E\u200D\u200E\u202B\u206C\u206C\u206F\u206A\u202E\u202C\u200F\u200F\u200B\u202C\u202B\u202E\u202E\u206D\u206C\u206A\u206B\u200B\u202D\u200E\u206D\u200D\u202B\u202C\u206D\u206B\u200C\u200C\u206B\u206B\u206F\u206A\u200B\u206E\u202E(base.AttackAction(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202D\u206A\u206C\u206C\u206D\u206C\u206C\u206A\u202B\u206C\u206A\u202A\u200F\u206B\u206C\u206B\u202C\u200E\u206D\u200C\u202D\u202D\u206B\u202E\u206C\u202E\u206D\u200B\u206C\u202B\u206F\u202B\u202B\u200B\u206F\u200F\u200B\u202B\u200F\u206C\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(this)), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1591228908), this.Damage2)));
								num = (int)((num3 * 1026178787U) ^ 2543169906U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<UnitEventArgs>(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202E\u200D\u202C\u206D\u200C\u206A\u202C\u202E\u200F\u202A\u200F\u202C\u206A\u200C\u206B\u200D\u202E\u202C\u200E\u206F\u200D\u200D\u202C\u206E\u202D\u200D\u206D\u200C\u200C\u202A\u202C\u206B\u206B\u202A\u202C\u206B\u206C\u200E\u206E\u202B\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200B\u202C\u206D\u200C\u206D\u202D\u206D\u200D\u200C\u202E\u206C\u200F\u200E\u200E\u200D\u202E\u202A\u202E\u206F\u200B\u202B\u206E\u206D\u206A\u206F\u202C\u200B\u206C\u202D\u200B\u202A\u200D\u206F\u206D\u206F\u206A\u200E\u206B\u200D\u206A\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
				for (;;)
				{
					IL_0022:
					int num = -1279892421;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((((-1240465191 - 9939295 + 573336086 * 1868014813) ^ ((-1262558266 ^ -1637347227) + 1550308729)) - num2 + ((-1861069604 + 909155808) ^ 2069185580)) ^ (-1332692870 + -513435254))) % 3U)
						{
						case 0U:
							goto IL_0022;
						case 2U:
							base.ReactBattleEvent<UnitEventArgs>(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u202C\u200B\u200B\u200C\u200D\u202E\u206F\u200C\u200C\u206A\u206C\u206F\u202E\u200D\u206E\u200F\u200E\u202D\u202A\u206B\u206D\u202C\u206C\u202E\u200B\u202C\u206A\u206D\u200D\u206C\u202C\u206E\u200D\u206D\u206F\u206C\u202D\u202E\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200B\u202C\u206D\u200C\u206D\u202D\u206D\u200D\u200C\u202E\u206C\u200F\u200E\u200E\u200D\u202E\u202A\u202E\u206F\u200B\u202B\u206E\u206D\u206A\u206F\u202C\u200B\u206C\u202D\u200B\u202A\u200D\u206F\u206D\u206F\u206A\u200E\u206B\u200D\u206A\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
							num = (int)((num3 * 1092977707U) ^ 463820497U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				if (this.Mode == 1)
				{
					for (;;)
					{
						int num = 862632355;
						switch ((-153388550 - (num + -140321053 * 170564631) - (-1889239311 ^ -99240838)) * -912066375 % 3)
						{
						case 1:
							goto IL_004B;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0061;
					IL_004B:
					return AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u202A\u206C\u200E\u200F\u206A\u200F\u200C\u206C\u200E\u206A\u206A\u200B\u206A\u206D\u200F\u206A\u206A\u202D\u206E\u200B\u206E\u202E\u206B\u202E\u206E\u206E\u202A\u206C\u206F\u202B\u200B\u202A\u202A\u206C\u200E\u200B\u202C\u202D\u202B\u202E(this);
				}
				IL_0061:
				return null;
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
			{
				if (this.Mode == 2)
				{
					for (;;)
					{
						int num = -1272681511;
						switch ((((~((134633309 - 1306576093) ^ -1291728698) - num - -(525566154 - 1257323606)) * 1350092475) ^ 1614730261) % 3)
						{
						case 1:
							goto IL_0053;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0069;
					IL_0053:
					return AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u202A\u206C\u200E\u200F\u206A\u200F\u200C\u206C\u200E\u206A\u206A\u200B\u206A\u206D\u200F\u206A\u206A\u202D\u206E\u200B\u206E\u202E\u206B\u202E\u206E\u206E\u202A\u206C\u206F\u202B\u200B\u202A\u202A\u206C\u200E\u200B\u202C\u202D\u202B\u202E(this);
				}
				IL_0069:
				return null;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.<GetPassiveActions>d__13 <GetPassiveActions>d__ = new AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.<GetPassiveActions>d__13(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u202D\u200E\u200B\u200F\u202C\u202C\u200E\u206B\u202E\u202C\u206A\u202E\u200F\u202A\u200B\u206D\u200C\u206E\u200F\u206D\u206C\u200C\u200D\u202A\u200F\u206C\u206A\u200D\u200F\u206B\u200C\u206E\u200F\u202C\u202A\u202E\u206F\u202C\u206C\u202E(this) == CardType.Friend)
				{
					List<Card> list;
					for (;;)
					{
						IL_000C:
						int num = -2000025646;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((num2 + ((-1514384719 - 1250902713) ^ (-1440861690 - 1264183856) ^ (-863970443 * (-752403983 + 505537429))) - (974241542 + 2094778996 + ~809185496)) ^ (-1868283520 * -925205223)) - 986110660)) % 29U)
							{
							case 0U:
								num = (int)((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u202B\u200E\u206D\u202D\u202E\u202D\u202D\u202A\u202D\u206D\u206C\u206E\u200F\u200E\u206E\u202A\u200E\u206F\u202E\u206F\u206C\u200D\u206C\u206E\u206B\u206A\u206F\u200E\u200B\u200D\u206D\u202A\u200F\u206E\u202E\u202E\u200E\u206C\u200E\u202E(this) ? 1446586612U : 295415338U) ^ (num3 * 1246792262U));
								continue;
							case 1U:
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(list[1], FriendToken.Ultimate);
								num = 2107661037;
								continue;
							case 2U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 2309108926U : 3864878397U) ^ (num3 * 2676466609U));
								continue;
							}
							case 3U:
								num = (int)(((AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u206A\u206D\u206F\u206C\u200F\u200D\u202A\u206B\u202C\u206F\u202B\u200E\u202E\u200E\u206F\u206D\u206B\u202C\u200F\u206C\u200E\u202A\u202A\u200C\u206F\u202C\u206C\u200F\u206B\u202B\u202A\u206F\u200B\u200F\u200F\u202D\u200E\u206E\u206A\u202E(this) >= -AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202B\u202E\u200C\u202E\u206C\u206C\u206F\u200E\u206A\u202B\u200D\u200C\u206C\u200C\u202A\u202C\u200D\u202E\u206D\u200D\u202C\u200F\u206A\u206C\u200F\u202E\u202B\u202C\u202D\u202C\u202E\u206D\u206B\u202D\u200C\u206B\u206F\u202C\u200D\u202D\u202E(this)) ? 2336021820U : 2479930358U) ^ (num3 * 4085009484U));
								continue;
							case 4U:
								num = (int)((num3 * 92752343U) ^ 605226414U);
								continue;
							case 5U:
								num = (int)(((this.Mode != 0) ? 4206365095U : 2837753416U) ^ (num3 * 2656284736U));
								continue;
							case 6U:
								list.AddRange(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u200E\u202A\u202B\u202B\u200F\u206D\u202D\u206F\u200C\u206E\u200C\u202C\u206B\u200B\u206B\u202A\u202E\u202C\u202A\u202C\u202D\u206D\u202D\u206C\u200E\u202A\u206E\u202A\u202E\u200C\u206D\u200F\u202A\u202D\u202C\u200B\u206F\u206C\u202C\u202E(this, 3, false));
								num = (int)((num3 * 2836011883U) ^ 585511563U);
								continue;
							case 7U:
							{
								int? num4 = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202D\u206C\u200F\u206A\u200B\u202D\u202B\u200E\u202B\u202D\u200D\u200D\u202D\u200E\u206C\u206F\u206C\u200D\u202C\u202A\u202B\u200E\u200D\u200B\u202E\u206F\u206E\u200F\u202D\u206D\u202E\u206A\u202C\u206D\u206F\u202D\u202D\u202C\u200F\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u206C\u206D\u202B\u202E\u206E\u200D\u200E\u206E\u200F\u200C\u206F\u202D\u202A\u206A\u206C\u202C\u200F\u206A\u206E\u202C\u200E\u200E\u206E\u206C\u200B\u206D\u200B\u200C\u206D\u206F\u206D\u200C\u200C\u200F\u202D\u206B\u200C\u206E\u206E\u202E(this));
								num = (int)((num3 * 3858311012U) ^ 619028885U);
								continue;
							}
							case 8U:
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(list[0], FriendToken.Active);
								num = (int)((num3 * 937551020U) ^ 978804632U);
								continue;
							case 9U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone = list[1] as AyaArsenalBirdDroneDef.AyaArsenalBirdDrone;
								num = (int)(((ayaArsenalBirdDrone == null) ? 431334343U : 2159381164U) ^ (num3 * 1278765903U));
								continue;
							}
							case 10U:
								list = new List<Card>();
								num = (int)((num3 * 1290247986U) ^ 723487965U);
								continue;
							case 11U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone;
								ayaArsenalBirdDrone.Switch = 2;
								num = (int)((num3 * 3824152844U) ^ 3011495279U);
								continue;
							}
							case 12U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone2;
								num = (int)(((ayaArsenalBirdDrone2 != null) ? 1673148175U : 225119856U) ^ (num3 * 1983961749U));
								continue;
							}
							case 13U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(list[0], FriendToken.Active);
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone2 = list[0] as AyaArsenalBirdDroneDef.AyaArsenalBirdDrone;
								num = (int)((num3 * 3516814017U) ^ 155859334U);
								continue;
							}
							case 14U:
								goto IL_000C;
							case 15U:
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(list[1], FriendToken.Active);
								num = -836421271;
								continue;
							case 16U:
								goto IL_02D8;
							case 17U:
								list.AddRange(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206F\u200E\u202A\u202B\u202B\u200F\u206D\u202D\u206F\u200C\u206E\u200C\u202C\u206B\u200B\u206B\u202A\u202E\u202C\u202A\u202C\u202D\u206D\u202D\u206C\u200E\u202A\u206E\u202A\u202E\u200C\u206D\u200F\u202A\u202D\u202C\u200B\u206F\u206C\u202C\u202E(this, 2, false));
								num = -2068895861;
								continue;
							case 18U:
								num = (int)((num3 * 2819358367U) ^ 237975238U);
								continue;
							case 19U:
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(list[2], FriendToken.Ultimate);
								num = -1497772214;
								continue;
							case 20U:
								num = ((this.Mode != 2) ? (-1018643097) : (-1688955490));
								continue;
							case 21U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone3;
								ayaArsenalBirdDrone3.Switch = 2;
								num = (int)((num3 * 591984263U) ^ 140722369U);
								continue;
							}
							case 22U:
							{
								int? num4 = AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u200F\u206A\u200C\u206D\u206E\u206D\u202A\u202A\u202B\u200C\u202E\u206E\u202B\u202C\u206E\u206F\u202C\u206C\u206F\u206C\u206B\u206A\u202D\u202D\u206E\u202C\u202A\u200B\u206B\u206E\u200D\u206B\u206B\u202D\u202E\u206A\u202C\u206C\u200F\u206D\u202E(AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u202A\u206C\u206D\u202B\u202E\u206E\u200D\u200E\u206E\u200F\u200C\u206F\u202D\u202A\u206A\u206C\u202C\u200F\u206A\u206E\u202C\u200E\u200E\u206E\u206C\u200B\u206D\u200B\u200C\u206D\u206F\u206D\u200C\u200C\u200F\u202D\u206B\u200C\u206E\u206E\u202E(this));
								num = (int)(((num4 == null) ? 799184261U : 2203367249U) ^ (num3 * 3757124019U));
								continue;
							}
							case 23U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone4;
								ayaArsenalBirdDrone4.Switch = 1;
								num = (int)((num3 * 2916530153U) ^ 2540950873U);
								continue;
							}
							case 24U:
								num = (int)(((this.Mode == 1) ? 598529525U : 1357354414U) ^ (num3 * 3027085312U));
								continue;
							case 25U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone4 = list[0] as AyaArsenalBirdDroneDef.AyaArsenalBirdDrone;
								num = (int)(((ayaArsenalBirdDrone4 != null) ? 987917972U : 957275536U) ^ (num3 * 815919295U));
								continue;
							}
							case 26U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone3 = list[0] as AyaArsenalBirdDroneDef.AyaArsenalBirdDrone;
								num = (int)(((ayaArsenalBirdDrone3 == null) ? 3946827886U : 996903640U) ^ (num3 * 236378318U));
								continue;
							}
							case 27U:
							{
								AyaArsenalBirdDroneDef.AyaArsenalBirdDrone ayaArsenalBirdDrone2;
								ayaArsenalBirdDrone2.Switch = 1;
								num = (int)((num3 * 842687546U) ^ 57342334U);
								continue;
							}
							}
							goto Block_1;
						}
					}
					Block_1:
					goto IL_044B;
					IL_02D8:
					return AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.\u206E\u206D\u206C\u202E\u202E\u206C\u206C\u200D\u200D\u202E\u202E\u206F\u202B\u202D\u206D\u206E\u206B\u202E\u200D\u202A\u202C\u202C\u206D\u206E\u202D\u200E\u200E\u202B\u202C\u202B\u202E\u202A\u200C\u202E\u202A\u200F\u206F\u202B\u206A\u202B\u202E(list, false, false, false);
				}
				IL_044B:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.<Actions>d__15 <Actions>d__ = new AyaArsenalBirdDroneDef.AyaArsenalBirdDrone.<Actions>d__15(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int \u200E\u202C\u206C\u206D\u206C\u202C\u200E\u206C\u200E\u202D\u200E\u200E\u200B\u202D\u202C\u206C\u206D\u202A\u202E\u200F\u200E\u206C\u206C\u200D\u200B\u200D\u200B\u202E\u202E\u206B\u200C\u206E\u202C\u200F\u206A\u206A\u200E\u200B\u206D\u206B\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static int \u206E\u206F\u200C\u206B\u202D\u202A\u206A\u202A\u202E\u200D\u202E\u206F\u200D\u202E\u202B\u200C\u200C\u200E\u200D\u202C\u200B\u202B\u200F\u206C\u202B\u206A\u202C\u202C\u206D\u202A\u200C\u200D\u206C\u202E\u202E\u206A\u202D\u206F\u202B\u206A\u202E(Card A_0)
			{
				return A_0.ConfigDamage;
			}

			static BlockInfo \u200D\u206E\u202C\u206D\u206C\u202D\u200E\u206D\u206D\u206C\u206C\u206A\u206A\u200C\u206D\u206D\u200D\u200D\u202E\u206C\u200C\u202A\u200C\u202B\u206E\u202D\u202D\u206C\u200C\u202A\u200F\u200D\u206E\u200D\u206B\u206A\u206C\u202C\u206E\u202C\u202E(Card A_0)
			{
				return A_0.Block;
			}

			static CardConfig \u202A\u206C\u206D\u202B\u202E\u206E\u200D\u200E\u206E\u200F\u200C\u206F\u202D\u202A\u206A\u206C\u202C\u200F\u206A\u206E\u202C\u200E\u200E\u206E\u206C\u200B\u206D\u200B\u200C\u206D\u206F\u206D\u200C\u200C\u200F\u202D\u206B\u200C\u206E\u206E\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u206D\u206D\u200B\u202C\u206C\u202B\u202A\u202E\u202A\u206B\u206B\u206A\u206F\u200E\u202D\u202A\u200D\u202B\u200C\u202A\u206A\u200B\u206B\u200E\u200D\u200B\u202D\u206A\u206E\u200D\u200E\u202D\u206C\u202A\u206F\u202D\u206E\u202B\u202A\u200D\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u202A\u202D\u200E\u200B\u200F\u202C\u202C\u200E\u206B\u202E\u202C\u206A\u202E\u200F\u202A\u200B\u206D\u200C\u206E\u200F\u206D\u206C\u200C\u200D\u202A\u200F\u206C\u206A\u200D\u200F\u206B\u200C\u206E\u200F\u202C\u202A\u202E\u206F\u202C\u206C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u206F\u206C\u206D\u206B\u202A\u200C\u206E\u200F\u200C\u200E\u202E\u202A\u206F\u202B\u202D\u206D\u206E\u202A\u202B\u200E\u206B\u206F\u202C\u202A\u200E\u202B\u202E\u206E\u206A\u206D\u206C\u206B\u206D\u200E\u206D\u206B\u200B\u202B\u206A\u206B\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static string \u206F\u202E\u200E\u202B\u200E\u206A\u206E\u206A\u200B\u202D\u206B\u200D\u202B\u202A\u206B\u200C\u206A\u200B\u202C\u202A\u202C\u202C\u206B\u202E\u202B\u202D\u206D\u206B\u206D\u200D\u200F\u206C\u200C\u206C\u202B\u200F\u200D\u202B\u206A\u200E\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u200F\u206E\u202E\u200F\u202A\u200B\u202A\u202D\u200E\u202A\u202E\u202E\u206D\u202C\u206D\u200F\u200C\u200C\u202B\u200D\u206E\u202D\u206B\u206A\u206F\u206F\u206E\u200F\u206F\u202E\u206D\u202E\u200C\u200C\u206D\u206A\u200C\u200B\u206B\u206B\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u202A\u200B\u200B\u202C\u200D\u206F\u200B\u202A\u206B\u206C\u202D\u202C\u202D\u200B\u206A\u206C\u200F\u200F\u200E\u200E\u202C\u206E\u206C\u206F\u206A\u202E\u202B\u206D\u200E\u202E\u200B\u206F\u206E\u206E\u206D\u202D\u202E\u202E\u200C\u200C\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static BattleController \u200D\u202B\u206E\u206C\u200B\u206D\u202C\u200B\u200B\u206A\u206E\u206C\u200C\u206D\u202A\u200B\u202E\u206D\u200C\u206D\u202A\u206C\u200E\u200F\u202C\u200B\u206B\u206B\u200C\u206E\u200C\u200C\u200F\u206F\u202E\u206D\u202E\u200E\u202B\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202B\u200D\u206C\u206F\u200F\u202B\u202D\u206D\u206B\u206F\u202D\u206D\u200E\u202A\u200E\u202E\u200C\u202E\u202D\u202C\u206C\u202D\u200C\u206E\u206C\u202D\u202D\u200F\u200F\u200F\u206F\u202E\u200C\u200F\u202D\u202E\u202E\u200E\u206A\u206F\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static bool \u206C\u200C\u202C\u202A\u202A\u202D\u206C\u206A\u202D\u206A\u202D\u202E\u206C\u206C\u202B\u206F\u202A\u202C\u202A\u206B\u200D\u202D\u200C\u200F\u200D\u206B\u206F\u200B\u200B\u206E\u206F\u202B\u200C\u202A\u200F\u206D\u200D\u200D\u206C\u206E\u202E(Card A_0)
			{
				return A_0.UltimateUsed;
			}

			static bool \u206E\u206E\u206B\u202E\u202C\u206C\u200E\u202D\u202C\u200B\u200B\u202B\u206C\u206E\u202B\u206D\u206A\u206C\u202E\u206F\u200F\u200B\u202C\u200F\u206B\u206F\u206A\u200C\u200F\u200B\u206C\u206C\u200D\u202D\u202E\u202B\u202B\u206F\u206E\u206C\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static IEnumerable<EnemyUnit> \u202D\u206A\u206C\u206C\u206D\u206C\u206C\u206A\u202B\u206C\u206A\u202A\u200F\u206B\u206C\u206B\u202C\u200E\u206D\u200C\u202D\u202D\u206B\u202E\u206C\u202E\u206D\u200B\u206C\u202B\u206F\u202B\u202B\u200B\u206F\u200F\u200B\u202B\u200F\u206C\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static Reactor \u200C\u200B\u206E\u200D\u200E\u202B\u206C\u206C\u206F\u206A\u202E\u202C\u200F\u200F\u200B\u202C\u202B\u202E\u202E\u206D\u206C\u206A\u206B\u200B\u202D\u200E\u206D\u200D\u202B\u202C\u206D\u206B\u200C\u200C\u206B\u206B\u206F\u206A\u200B\u206E\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static PlayerUnit \u200B\u202C\u206D\u200C\u206D\u202D\u206D\u200D\u200C\u202E\u206C\u200F\u200E\u200E\u200D\u202E\u202A\u202E\u206F\u200B\u202B\u206E\u206D\u206A\u206F\u202C\u200B\u206C\u202D\u200B\u202A\u200D\u206F\u206D\u206F\u206A\u200E\u206B\u200D\u206A\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202E\u200D\u202C\u206D\u200C\u206A\u202C\u202E\u200F\u202A\u200F\u202C\u206A\u200C\u206B\u200D\u202E\u202C\u200E\u206F\u200D\u200D\u202C\u206E\u202D\u200D\u206D\u200C\u200C\u202A\u202C\u206B\u206B\u202A\u202C\u206B\u206C\u200E\u206E\u202B\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<UnitEventArgs> \u206F\u202C\u200B\u200B\u200C\u200D\u202E\u206F\u200C\u200C\u206A\u206C\u206F\u202E\u200D\u206E\u200F\u200E\u202D\u202A\u206B\u206D\u202C\u206C\u202E\u200B\u202C\u206A\u206D\u200D\u206C\u202C\u206E\u200D\u206D\u206F\u206C\u202D\u202E\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}

			static IEnumerable<BattleAction> \u200F\u202A\u206C\u200E\u200F\u206A\u200F\u200C\u206C\u200E\u206A\u206A\u200B\u206A\u206D\u200F\u206A\u206A\u202D\u206E\u200B\u206E\u202E\u206B\u202E\u206E\u206E\u202A\u206C\u206F\u202B\u200B\u202A\u202A\u206C\u200E\u200B\u202C\u202D\u202B\u202E(Card A_0)
			{
				return A_0.GetPassiveActions();
			}

			static int? \u200F\u206A\u200C\u206D\u206E\u206D\u202A\u202A\u202B\u200C\u202E\u206E\u202B\u202C\u206E\u206F\u202C\u206C\u206F\u206C\u206B\u206A\u202D\u202D\u206E\u202C\u202A\u200B\u206B\u206E\u200D\u206B\u206B\u202D\u202E\u206A\u202C\u206C\u200F\u206D\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u202D\u206C\u200F\u206A\u200B\u202D\u202B\u200E\u202B\u202D\u200D\u200D\u202D\u200E\u206C\u206F\u206C\u200D\u202C\u202A\u202B\u200E\u200D\u200B\u202E\u206F\u206E\u200F\u202D\u206D\u202E\u206A\u202C\u206D\u206F\u202D\u202D\u202C\u200F\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static bool \u200F\u202B\u200E\u206D\u202D\u202E\u202D\u202D\u202A\u202D\u206D\u206C\u206E\u200F\u200E\u206E\u202A\u200E\u206F\u202E\u206F\u206C\u200D\u206C\u206E\u206B\u206A\u206F\u200E\u200B\u200D\u206D\u202A\u200F\u206E\u202E\u202E\u200E\u206C\u200E\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202B\u206A\u206D\u206F\u206C\u200F\u200D\u202A\u206B\u202C\u206F\u202B\u200E\u202E\u200E\u206F\u206D\u206B\u202C\u200F\u206C\u200E\u202A\u202A\u200C\u206F\u202C\u206C\u200F\u206B\u202B\u202A\u206F\u200B\u200F\u200F\u202D\u200E\u206E\u206A\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int \u202B\u202E\u200C\u202E\u206C\u206C\u206F\u200E\u206A\u202B\u200D\u200C\u206C\u200C\u202A\u202C\u200D\u202E\u206D\u200D\u202C\u200F\u206A\u206C\u200F\u202E\u202B\u202C\u202D\u202C\u202E\u206D\u206B\u202D\u200C\u206B\u206F\u202C\u200D\u202D\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u206F\u200E\u202A\u202B\u202B\u200F\u206D\u202D\u206F\u200C\u206E\u200C\u202C\u206B\u200B\u206B\u202A\u202E\u202C\u202A\u202C\u202D\u206D\u202D\u206C\u200E\u202A\u206E\u202A\u202E\u200C\u206D\u200F\u202A\u202D\u202C\u200B\u206F\u206C\u202C\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u200F\u200C\u200C\u206C\u202A\u206D\u206B\u206D\u200C\u206A\u200C\u206F\u206F\u206C\u202D\u206B\u202A\u200B\u206F\u206F\u202E\u206D\u202A\u206B\u202D\u200C\u200F\u202E\u202B\u206B\u202D\u200C\u200D\u202A\u206B\u200E\u206D\u202B\u206C\u202C\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u206E\u206D\u206C\u202E\u202E\u206C\u206C\u200D\u200D\u202E\u202E\u206F\u202B\u202D\u206D\u206E\u206B\u202E\u200D\u202A\u202C\u202C\u206D\u206E\u202D\u200E\u200E\u202B\u202C\u202B\u202E\u202A\u200C\u202E\u202A\u200F\u206F\u202B\u206A\u202B\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public int Mode;

			private int Switch;
		}
	}
}
