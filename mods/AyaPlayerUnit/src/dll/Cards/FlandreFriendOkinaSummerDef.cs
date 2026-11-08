using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreFriendOkinaSummerDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(501936272);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFriendOkinaSummerDef.\u206F\u202C\u200E\u202C\u206A\u200C\u202B\u206E\u200D\u202A\u200F\u206D\u202C\u200F\u202E\u202E\u200D\u206D\u206C\u202C\u206A\u200D\u206F\u206B\u202C\u206D\u206A\u202D\u200B\u202A\u202D\u202A\u202A\u206B\u200B\u206F\u200D\u200D\u202B\u202E\u202E(BepinexPlugin.embeddedSource);
			FlandreFriendOkinaSummerDef.\u200D\u200B\u206E\u206B\u200E\u202B\u206B\u200D\u206D\u206E\u200E\u202E\u200F\u200C\u200C\u202C\u200B\u206F\u200D\u202C\u202A\u200F\u200C\u202B\u200E\u202D\u206F\u202A\u202B\u200D\u202B\u202B\u206A\u206D\u202E\u200E\u202E\u200E\u200D\u202B\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaSummerDef.\u202A\u200E\u202C\u206A\u202A\u200C\u200C\u202C\u202D\u206A\u202A\u206E\u202B\u206D\u202E\u202D\u200B\u202D\u206A\u200E\u202C\u206A\u202A\u200F\u206F\u206B\u200D\u202C\u206C\u206C\u206B\u200B\u206A\u200C\u200C\u202E\u206A\u202C\u206E\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFriendOkinaSummerDef.\u200F\u202B\u202A\u202C\u202B\u200E\u206C\u200C\u206B\u206B\u202B\u200E\u206D\u206F\u202C\u202D\u200F\u202B\u206B\u206E\u202E\u200C\u206D\u202C\u200C\u206A\u200F\u202B\u206B\u200F\u206B\u206C\u202C\u200B\u200B\u202E\u202E\u206E\u206B\u202A\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaSummerDef.\u200E\u206A\u202C\u200C\u206A\u206C\u206A\u206F\u200C\u206A\u206F\u206B\u202D\u200C\u206A\u200B\u200F\u206E\u206F\u200E\u206D\u200E\u202A\u202E\u200C\u200B\u202C\u200D\u202C\u200B\u206F\u202E\u206E\u200D\u200F\u202D\u202B\u200B\u202D\u206D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, false, true, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Blue = 1,
				Black = 1,
				Red = 1,
				Green = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(30), null, null, null, null, null, null, new int?(1), null, new int?(2), null, new int?(-1), null, null, null, new int?(-6), null, Keyword.Replenish, Keyword.Replenish, false, Keyword.Accuracy | Keyword.Philosophy, Keyword.Accuracy | Keyword.Philosophy, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1681599054),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1110506755)
			}, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1681599054),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(620326119)
			}, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1228273879),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1042466688),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(976094499),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1287554726)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(99449685),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1842609461),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(976094499),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1763499156)
			}, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1501916052), new List<string>());
		}

		static CardImages \u206F\u202C\u200E\u202C\u206A\u200C\u202B\u206E\u200D\u202A\u200F\u206D\u202C\u200F\u202E\u202E\u200D\u206D\u206C\u202C\u206A\u200D\u206F\u206B\u202C\u206D\u206A\u202D\u200B\u202A\u202D\u202A\u202A\u206B\u200B\u206F\u200D\u200D\u202B\u202E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u200B\u206E\u206B\u200E\u202B\u206B\u200D\u206D\u206E\u200E\u202E\u200F\u200C\u200C\u202C\u200B\u206F\u200D\u202C\u202A\u200F\u200C\u202B\u200E\u202D\u206F\u202A\u202B\u200D\u202B\u202B\u206A\u206D\u202E\u200E\u202E\u200E\u200D\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u200E\u202C\u206A\u202A\u200C\u200C\u202C\u202D\u206A\u202A\u206E\u202B\u206D\u202E\u202D\u200B\u202D\u206A\u200E\u202C\u206A\u202A\u200F\u206F\u206B\u200D\u202C\u206C\u206C\u206B\u200B\u206A\u200C\u200C\u202E\u206A\u202C\u206E\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u206A\u202C\u200C\u206A\u206C\u206A\u206F\u200C\u206A\u206F\u206B\u202D\u200C\u206A\u200B\u200F\u206E\u206F\u200E\u206D\u200E\u202A\u202E\u200C\u200B\u202C\u200D\u202C\u200B\u206F\u202E\u206E\u200D\u200F\u202D\u202B\u200B\u202D\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u202B\u202A\u202C\u202B\u200E\u206C\u200C\u206B\u206B\u202B\u200E\u206D\u206F\u202C\u202D\u200F\u202B\u206B\u206E\u202E\u200C\u206D\u202C\u200C\u206A\u200F\u202B\u206B\u200F\u206B\u206C\u202C\u200B\u200B\u202E\u202E\u206E\u206B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaSummerDef))]
		public sealed class FlandreFriendOkinaSummer : FlandreCard
		{
			public override bool RemoveFromBattleAfterPlay
			{
				get
				{
					return this.ActiveUsed;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202C\u202B\u206E\u200B\u206C\u202C\u202C\u202A\u202C\u206A\u200C\u206E\u200D\u200E\u202D\u200B\u206D\u202B\u202E\u206F\u200F\u206B\u206A\u206C\u206E\u206C\u200E\u206A\u200C\u206D\u200D\u206E\u206F\u206F\u206C\u202E\u202C\u202D\u206F\u200E\u202E(this).GetValueOrDefault() * 10;
				}
			}

			public float Value3
			{
				get
				{
					return 4f;
				}
			}

			public int Value4
			{
				get
				{
					return 7;
				}
			}

			public int Value5
			{
				get
				{
					return base.FlandreModifier(60 + FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202C\u202B\u206E\u200B\u206C\u202C\u202C\u202A\u202C\u206A\u200C\u206E\u200D\u200E\u202D\u200B\u206D\u202B\u202E\u206F\u200F\u206B\u206A\u206C\u206E\u206C\u200E\u206A\u200C\u206D\u200D\u206E\u206F\u206F\u206C\u202E\u202C\u202D\u206F\u200E\u202E(this).GetValueOrDefault() * 20, false);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					ManaGroup manaGroup = default(ManaGroup);
					for (;;)
					{
						IL_0008:
						int num = -1758244380;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)((num2 ^ ((855925423 * 595334163) ^ (-990644594 + --1541193846)) ^ ~(403747289 * -1097055542)) + -1601763148))) % 3U)
							{
							case 0U:
								goto IL_0008;
							case 2U:
								manaGroup.Philosophy = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206D\u202E\u200E\u206D\u202A\u202E\u206F\u206A\u206C\u200E\u200B\u206E\u202B\u206B\u202D\u202C\u206F\u202E\u206A\u202E\u200E\u206C\u206A\u206B\u202D\u202B\u206F\u206B\u202A\u206B\u200D\u202C\u202A\u202E\u202B\u200D\u200E\u202D\u200F\u206B\u202E((float)FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202C\u202B\u206E\u200B\u206C\u202C\u202C\u202A\u202C\u206A\u200C\u206E\u200D\u200E\u202D\u200B\u206D\u202B\u202E\u206F\u200F\u206B\u206A\u206C\u206E\u206C\u200E\u206A\u200C\u206D\u200D\u206E\u206F\u206F\u206C\u202E\u202C\u202D\u206F\u200E\u202E(this).GetValueOrDefault() / 2f);
								num = (int)((num3 * 1021934102U) ^ 1925630640U);
								continue;
							}
							return manaGroup;
						}
					}
					return manaGroup;
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
							IL_008F:
							int num = ((!FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202B\u200F\u200F\u200F\u202E\u202C\u202A\u206B\u206E\u206F\u202E\u200F\u206A\u202A\u202B\u206B\u202A\u202E\u206A\u202D\u206E\u202A\u202E\u202A\u202D\u202B\u206A\u202B\u202B\u206A\u202E\u200B\u206A\u202C\u202C\u202C\u200E\u202E\u200F\u200F\u202E(enumerator)) ? 443402240 : 2014658323);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(255479316 - (-num2 ^ ((-1187780005 ^ -1516389094) * -929222993) ^ (83205545 - -1759650933)))) % 5U)
								{
								case 1U:
								{
									ManaColor manaColor = enumerator.Current;
									num = ((manaGroup.GetValue(manaColor) > 0) ? 982458977 : (-1399323778));
									continue;
								}
								case 2U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 359481432U) ^ 405268078U);
									continue;
								}
								case 3U:
									num = 2014658323;
									continue;
								case 4U:
									goto IL_008F;
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
								IL_00D9:
								int num4 = 1933544999;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(255479316 - (-num2 ^ ((-1187780005 ^ -1516389094) * -929222993) ^ (83205545 - -1759650933)))) % 3U)
									{
									case 1U:
										FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206A\u200D\u206A\u202B\u200B\u202B\u200E\u206B\u206D\u202D\u206E\u202E\u200B\u202B\u202B\u200E\u202B\u200E\u202D\u202D\u206E\u206E\u206F\u200E\u202B\u206B\u200F\u206D\u202E\u202C\u200D\u200D\u200D\u200F\u206E\u200D\u206E\u202C\u202D\u206B\u202E(enumerator);
										num4 = (int)((num3 * 2986771738U) ^ 521296355U);
										continue;
									case 2U:
										goto IL_00D9;
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202B\u200C\u202B\u202B\u206F\u202D\u200F\u200B\u206A\u206C\u200D\u202D\u202C\u200B\u202A\u202A\u206D\u202E\u206B\u200E\u202C\u202E\u200E\u206B\u202B\u206D\u200E\u202E\u206E\u200D\u206F\u206D\u206A\u200E\u200D\u202B\u206B\u200B\u200F\u200C\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_015F;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text4;
					switch ((num3 = (uint)(~(uint)(~num ^ -572067148))) % 42U)
					{
					case 0U:
						num2 = (int)((num3 * 2120553286U) ^ 1534295775U);
						continue;
					case 1U:
						num2 = ((FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u200B\u200F\u206D\u206F\u200C\u206B\u200B\u200D\u200B\u206F\u206C\u200C\u206C\u200D\u202A\u202C\u206D\u206C\u206F\u202C\u200D\u200C\u202A\u200D\u206E\u206A\u200E\u202A\u202B\u202E\u206E\u206F\u206C\u200E\u200E\u202B\u200D\u200C\u206B\u202E(this) != null) ? (-1876623132) : (-928717592));
						continue;
					case 2U:
						text = base.RawExtraDescription2;
						num2 = -727966365;
						continue;
					case 3U:
						num2 = (int)((num3 * 1414640060U) ^ 2206405995U);
						continue;
					case 4U:
						num2 = ((!base.HasExtraDescription2) ? (-1731963847) : (-280173025));
						continue;
					case 5U:
					{
						FriendToken friendToken = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202B\u206B\u200F\u206C\u202B\u202C\u202B\u206F\u206A\u200D\u206C\u200E\u202C\u206A\u200E\u202B\u202C\u206E\u202E\u200E\u200D\u200D\u200F\u206D\u202B\u200B\u202C\u200B\u202A\u200F\u206F\u202D\u202E\u206F\u202B\u202C\u200D\u200F\u200F\u200E\u202E(this);
						num2 = (int)((num3 * 2813762150U) ^ 469140214U);
						continue;
					}
					case 6U:
						num2 = (int)((num3 * 2630794264U) ^ 172659872U);
						continue;
					case 7U:
					{
						int num4 = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200E\u200E\u200D\u206A\u200E\u206E\u202C\u202E\u200F\u200B\u206A\u206C\u202B\u202C\u206A\u202B\u202C\u200C\u206C\u202E\u206D\u202B\u206F\u206B\u202E\u206D\u200D\u200D\u202B\u200B\u206A\u200F\u206A\u200C\u200B\u206E\u202D\u202E\u200B\u202A\u202E(this);
						num2 = -274283942;
						continue;
					}
					case 8U:
					{
						FriendToken friendToken;
						switch (friendToken)
						{
						case FriendToken.None:
							goto IL_0412;
						case FriendToken.Active:
							goto IL_030A;
						case FriendToken.Active2:
							goto IL_0362;
						case FriendToken.Ultimate:
							goto IL_00D9;
						default:
							num2 = (int)((num3 * 351405503U) ^ 1058769448U);
							continue;
						}
						break;
					}
					case 9U:
						goto IL_0412;
					case 10U:
						goto IL_04FB;
					case 11U:
						num2 = ((!base.HasExtraDescription3) ? (-425599601) : (-1612194223));
						continue;
					case 12U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -1381559591;
						continue;
					}
					case 13U:
						goto IL_030A;
					case 14U:
						num2 = (int)((num3 * 2064830348U) ^ 1665759471U);
						continue;
					case 15U:
						num2 = (int)((num3 * 1068749523U) ^ 3192133939U);
						continue;
					case 16U:
					{
						object obj = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription;
						num2 = -38006243;
						continue;
					}
					case 17U:
					{
						object obj;
						num2 = (int)(((obj != null) ? 408665453U : 862477259U) ^ (num3 * 1936628705U));
						continue;
					}
					case 18U:
						num2 = ((!FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u206D\u200E\u206F\u206C\u202C\u200F\u202B\u206E\u206C\u206F\u200B\u200E\u202B\u200C\u200D\u202E\u202C\u200D\u200F\u206E\u200F\u202B\u200F\u200C\u206A\u202C\u206A\u202A\u200D\u206F\u200B\u206E\u202B\u206C\u200C\u206C\u200F\u202B\u202A\u202E(this)) ? (-731767276) : (-1761422310));
						continue;
					case 19U:
					{
						int num4;
						num2 = (int)(((num4 != 2) ? 4157340965U : 3605095092U) ^ (num3 * 2068469634U));
						continue;
					}
					case 20U:
					{
						string text2 = text;
						string text3;
						if (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u200B\u200F\u206D\u206F\u200C\u206B\u200B\u200D\u200B\u206F\u206C\u200C\u206C\u200D\u202A\u202C\u206D\u206C\u206F\u202C\u200D\u200C\u202A\u200D\u206E\u206A\u200E\u202A\u202B\u202E\u206E\u206F\u206C\u200E\u200E\u202B\u200D\u200C\u206B\u202E(this) == null)
						{
							if (!FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u206D\u200E\u206F\u206C\u202C\u200F\u202B\u206E\u206C\u206F\u200B\u200E\u202B\u200C\u200D\u202E\u202C\u200D\u200F\u206E\u200F\u202B\u200F\u200C\u206A\u202C\u206A\u202A\u200D\u206F\u200B\u206E\u202B\u206C\u200C\u206C\u200F\u202B\u202A\u202E(this))
							{
								text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
							else if ((text3 = base.UpgradedNonbattleBaseDescription) == null)
							{
								text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
						}
						else
						{
							text3 = (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u206D\u200E\u206F\u206C\u202C\u200F\u202B\u206E\u206C\u206F\u200B\u200E\u202B\u200C\u200D\u202E\u202C\u200D\u200F\u206E\u200F\u202B\u200F\u200C\u206A\u202C\u206A\u202A\u200D\u206F\u200B\u206E\u202B\u206C\u200C\u206C\u200F\u202B\u202A\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						}
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text2, text3);
						num2 = -281123197;
						continue;
					}
					case 21U:
						goto IL_0362;
					case 22U:
					{
						object obj;
						text = (string)obj;
						num2 = -425599601;
						continue;
					}
					case 23U:
						goto IL_00D9;
					case 24U:
						if (!FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u206D\u200E\u206F\u206C\u202C\u200F\u202B\u206E\u206C\u206F\u200B\u200E\u202B\u200C\u200D\u202E\u202C\u200D\u200F\u206E\u200F\u202B\u200F\u200C\u206A\u202C\u206A\u202A\u200D\u206F\u200B\u206E\u202B\u206C\u200C\u206C\u200F\u202B\u202A\u202E(this))
						{
							num2 = (int)((num3 * 2378243012U) ^ 384981309U);
							continue;
						}
						text4 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_0213;
					case 25U:
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						num2 = (int)((num3 * 1192242996U) ^ 1107177377U);
						continue;
					case 26U:
						text = base.RawExtraDescription1;
						num2 = -195648754;
						continue;
					case 27U:
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription3);
						num2 = (int)((num3 * 3911481489U) ^ 2860834477U);
						continue;
					case 28U:
						num2 = (int)((num3 * 2231211619U) ^ 4249176929U);
						continue;
					case 29U:
						text4 = base.BaseDescription;
						goto IL_0213;
					case 30U:
						goto IL_026E;
					case 31U:
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription1);
						num2 = (int)((num3 * 1906338895U) ^ 3706820577U);
						continue;
					case 32U:
						goto IL_0010;
					case 33U:
						num2 = (int)((num3 * 2077178440U) ^ 3351227355U);
						continue;
					case 34U:
					{
						int num4;
						num2 = (int)(((num4 == 1) ? 1760987484U : 1562229759U) ^ (num3 * 3340016327U));
						continue;
					}
					case 36U:
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
						num2 = (int)((num3 * 1921943354U) ^ 1218509491U);
						continue;
					case 37U:
						num2 = (base.HasExtraDescription1 ? (-20155414) : (-54970940));
						continue;
					case 38U:
						num2 = (int)((num3 * 3799887908U) ^ 2567234791U);
						continue;
					case 39U:
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription2);
						num2 = (int)((num3 * 3766689546U) ^ 1583536023U);
						continue;
					case 40U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -237471004;
						continue;
					}
					case 41U:
						goto IL_015F;
					}
					break;
					IL_00D9:
					text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription3);
					num2 = -750054788;
					continue;
					IL_0213:
					text = text4;
					num2 = -425599601;
					continue;
					IL_030A:
					text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription1);
					num2 = -1568598850;
					continue;
					IL_0362:
					text = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(text, base.RawExtraDescription2);
					num2 = -425599601;
					continue;
					IL_0412:
					num2 = (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202B\u200C\u202B\u202B\u206F\u202D\u200F\u200B\u206A\u206C\u200D\u202D\u202C\u200B\u202A\u202A\u206D\u202E\u206B\u200E\u202C\u202E\u200E\u206B\u202B\u206D\u200E\u202E\u206E\u200D\u206F\u206D\u206A\u200E\u200D\u202B\u206B\u200B\u200F\u200C\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(this)) ? (-281123197) : (-1231952794));
				}
				goto IL_0555;
				IL_026E:
				return string.Empty;
				IL_04FB:
				throw FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200F\u200E\u206D\u200F\u200D\u200C\u202A\u200E\u206E\u206C\u202D\u200E\u202A\u202B\u206C\u202C\u206D\u202A\u202E\u206B\u202C\u206F\u200E\u206C\u206C\u206E\u200C\u206F\u202B\u206D\u206D\u202E\u206C\u206A\u202B\u200F\u206C\u206B\u202D\u206F\u202E();
				IL_0555:
				return base.FollowByDetailIcon(text);
				IL_0010:
				num2 = -1130979822;
				goto IL_0015;
				IL_015F:
				text = string.Empty;
				num2 = ((FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200D\u200E\u200C\u206E\u202C\u206B\u200E\u200E\u202E\u200D\u206D\u206E\u200F\u202B\u202C\u200B\u202E\u200B\u202A\u206D\u206D\u200C\u200B\u202C\u206F\u202C\u200C\u206F\u202A\u202C\u202C\u206F\u200F\u202A\u200B\u202A\u206D\u206C\u200B\u206C\u202E(this) != CardType.Friend) ? (-529775983) : (-945088581));
				goto IL_0015;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<EnumerateRelativeCards>d__15 <EnumerateRelativeCards>d__ = new FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<EnumerateRelativeCards>d__15(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.Amount = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206C\u206D\u200D\u200B\u206E\u206D\u200C\u206F\u202A\u200D\u200F\u202B\u202D\u200F\u200D\u206E\u200D\u206F\u206C\u206E\u206A\u200E\u200B\u200D\u200E\u202B\u202D\u202D\u202C\u206A\u200B\u206A\u200D\u200B\u200E\u202C\u200F\u202A\u202E\u206E\u202E(this);
				for (;;)
				{
					IL_000C:
					int num = 1207433108;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((num2 ^ -(~-1091771438 ^ (-932413785 * -1180418695))) - (210040488 + 1994013617 - (-1282079775 ^ -1061537534))) + -1626147657)) % 3U)
						{
						case 0U:
							goto IL_000C;
						case 1U:
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206B\u206B\u202E\u200C\u202B\u200F\u200E\u206B\u206C\u206A\u200F\u206A\u202D\u200C\u206B\u200C\u200F\u202D\u200F\u206F\u202B\u206C\u206B\u202C\u200D\u202D\u206E\u200D\u200D\u206C\u200F\u206E\u202B\u200E\u202E\u200B\u200B\u202B\u206A\u206F\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u200B\u200F\u206D\u206F\u200C\u206B\u200B\u200D\u200B\u206F\u206C\u200C\u206C\u200D\u202A\u202C\u206D\u206C\u206F\u202C\u200D\u200C\u202A\u200D\u206E\u206A\u200E\u202A\u202B\u202E\u206E\u206F\u206C\u200E\u200E\u202B\u200D\u200C\u206B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200D\u202C\u206E\u202A\u200D\u202B\u202A\u200E\u202D\u200D\u206D\u200E\u206C\u202E\u206B\u202D\u206F\u206C\u202B\u206E\u200B\u200E\u202A\u206D\u206F\u200D\u202C\u202A\u200F\u206A\u206A\u206F\u200B\u202D\u206A\u200C\u200E\u202A\u200D\u202E\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u200B\u200F\u206D\u206F\u200C\u206B\u200B\u200D\u200B\u206F\u206C\u200C\u206C\u200D\u202A\u202C\u206D\u206C\u206F\u202C\u200D\u200C\u202A\u200D\u206E\u206A\u200E\u202A\u202B\u202E\u206E\u206F\u206C\u200E\u200E\u202B\u200D\u200C\u206B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 3268870026U) ^ 3544466305U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<OnCardUsed>d__17 <OnCardUsed>d__ = new FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<OnCardUsed>d__17(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<GetPassiveActions>d__18 <GetPassiveActions>d__ = new FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<GetPassiveActions>d__18(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200D\u200E\u200C\u206E\u202C\u206B\u200E\u200E\u202E\u200D\u206D\u206E\u200F\u202B\u202C\u200B\u202E\u200B\u202A\u206D\u206D\u200C\u200B\u202C\u206F\u202C\u200C\u206F\u202A\u202C\u202C\u206F\u200F\u202A\u200B\u202A\u206D\u206C\u200B\u206C\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list;
					List<Card> list2;
					for (;;)
					{
						IL_000C:
						int num = 1858522568;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(num2 * -1705962323 - --850618808 * -649584359)) % 17U)
							{
							case 0U:
								num = (int)(((FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u200F\u206A\u202E\u200D\u202A\u202E\u202C\u206B\u200C\u202D\u206C\u206D\u200B\u206B\u200B\u206F\u206B\u200D\u200F\u202E\u202C\u206B\u200E\u202D\u200D\u200D\u200D\u200B\u206B\u206C\u202B\u206F\u200C\u202A\u202E\u202B\u206D\u200E\u206C\u202E(this) < -FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200C\u206D\u206C\u202D\u206D\u200D\u200E\u200D\u200E\u202D\u200F\u206C\u206B\u202E\u200F\u202D\u206C\u200C\u202C\u200F\u200E\u206D\u206E\u200C\u200B\u200D\u200D\u202A\u206C\u200D\u206B\u202D\u200E\u200B\u206C\u206D\u200C\u202E\u200F\u206A\u202E(this)) ? 2178472662U : 2430949415U) ^ (num3 * 2685718511U));
								continue;
							case 1U:
							{
								int? num4 = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u206B\u202D\u202C\u206C\u206E\u206C\u200E\u206B\u202C\u200F\u200B\u206B\u202C\u206E\u200C\u206F\u200C\u200F\u200F\u206E\u200E\u206E\u200E\u200F\u200B\u202D\u206B\u200C\u200D\u206C\u206D\u206A\u206C\u206E\u206A\u206C\u206F\u202D\u206F\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(this));
								num = (int)(((num4 == null) ? 1330807173U : 2199981677U) ^ (num3 * 4083969371U));
								continue;
							}
							case 2U:
								if (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200E\u206C\u200E\u202D\u202B\u206B\u202C\u202E\u206A\u202B\u200D\u202A\u206E\u206F\u200B\u202B\u202A\u200F\u200B\u202B\u200D\u200C\u202D\u200F\u206F\u206D\u202E\u200E\u200D\u206D\u200B\u200D\u202C\u206C\u200F\u206F\u202D\u200C\u206E\u206C\u202E(this))
								{
									num = (int)((num3 * 1348285650U) ^ 2281193713U);
									continue;
								}
								goto IL_037D;
							case 3U:
								num = (int)((this.ActiveUsed ? 1549297193U : 3101118328U) ^ (num3 * 2469320558U));
								continue;
							case 4U:
								list.Add(FriendToken.Ultimate);
								num = (int)((num3 * 1384453695U) ^ 3255285484U);
								continue;
							case 5U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 2980403028U : 1858082216U) ^ (num3 * 2749010117U));
								continue;
							}
							case 6U:
								list2 = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202A\u200D\u206F\u202D\u200F\u200E\u206E\u206E\u200E\u200C\u206E\u200C\u202A\u200F\u206A\u206C\u206D\u200B\u202E\u206D\u202C\u200F\u200C\u206F\u206A\u200F\u206D\u200F\u200D\u200B\u200D\u202A\u206A\u206C\u206D\u202C\u206F\u202A\u200B\u200E\u202E(this, list.Count, false).ToList<Card>();
								num = -1262662442;
								continue;
							case 7U:
							{
								int? num4 = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206A\u202E\u200B\u200D\u202A\u206D\u206A\u202C\u200C\u200E\u202E\u200C\u206C\u202A\u206A\u202C\u200C\u206D\u206D\u200C\u206C\u200F\u202B\u200B\u202C\u200F\u206E\u202D\u200D\u202D\u200E\u200B\u202C\u206D\u202E\u206A\u206E\u200F\u206F\u200D\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(this));
								num = ((num4 != null) ? (-351178446) : 203725548);
								continue;
							}
							case 8U:
							{
								int? num4 = FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202C\u206F\u200F\u200E\u200F\u202C\u200E\u206F\u200B\u200F\u206B\u202A\u206C\u200B\u206B\u200C\u206B\u206D\u200F\u206F\u206E\u202E\u202B\u206F\u202C\u202B\u202C\u206A\u206B\u200E\u206D\u202A\u206F\u200B\u200E\u202B\u206C\u206B\u206E\u200E\u202E(FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(this));
								num = -1187721261;
								continue;
							}
							case 9U:
								list.Add(FriendToken.Active);
								num = (int)((num3 * 1534968315U) ^ 450278411U);
								continue;
							case 10U:
								goto IL_000C;
							case 11U:
								if (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u200F\u206A\u202E\u200D\u202A\u202E\u202C\u206B\u200C\u202D\u206C\u206D\u200B\u206B\u200B\u206F\u206B\u200D\u200F\u202E\u202C\u206B\u200E\u202D\u200D\u200D\u200D\u200B\u206B\u206C\u202B\u206F\u200C\u202A\u202E\u202B\u206D\u200E\u206C\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 3867543276U) ^ 272820388U);
									continue;
								}
								goto IL_037D;
							case 12U:
								num = (int)(((FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u200F\u206A\u202E\u200D\u202A\u202E\u202C\u206B\u200C\u202D\u206C\u206D\u200B\u206B\u200B\u206F\u206B\u200D\u200F\u202E\u202C\u206B\u200E\u202D\u200D\u200D\u200D\u200B\u206B\u206C\u202B\u206F\u200C\u202A\u202E\u202B\u206D\u200E\u206C\u202E(this) >= -FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206E\u202E\u206B\u206F\u202E\u206E\u206A\u206D\u206C\u206B\u200F\u206B\u206E\u206A\u206F\u206A\u200C\u200E\u202C\u206A\u206D\u200F\u206D\u206D\u202A\u202B\u206C\u200C\u202E\u206F\u200D\u202A\u202D\u200B\u200D\u206D\u206C\u206F\u206F\u202A\u202E(this)) ? 4138594228U : 3555151903U) ^ (num3 * 145060312U));
								continue;
							case 14U:
								list = new List<FriendToken>();
								num = (int)((num3 * 285685931U) ^ 1823534709U);
								continue;
							case 15U:
								list.Add(FriendToken.Active2);
								num = (int)((num3 * 17418686U) ^ 2397958479U);
								continue;
							case 16U:
								num = (int)(((FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202E\u200F\u206A\u202E\u200D\u202A\u202E\u202C\u206B\u200C\u202D\u206C\u206D\u200B\u206B\u200B\u206F\u206B\u200D\u200F\u202E\u202C\u206B\u200E\u202D\u200D\u200D\u200D\u200B\u206B\u206C\u202B\u206F\u200C\u202A\u202E\u202B\u206D\u200E\u206C\u202E(this) < -FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206F\u200D\u206B\u202D\u202E\u200C\u206E\u200B\u206E\u206E\u202D\u206D\u200B\u206A\u202A\u200C\u200C\u206C\u200D\u200D\u202C\u206C\u200E\u202A\u206F\u202A\u202B\u200E\u206B\u200C\u206B\u202D\u202B\u202C\u206E\u200D\u202C\u200F\u200F\u206A\u202E(this)) ? 2789719312U : 1699997220U) ^ (num3 * 1091731278U));
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					IEnumerator<ValueTuple<int, FriendToken>> enumerator = list.WithIndices<FriendToken>().GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0307:
							int num5 = (FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u202B\u200F\u200F\u200F\u202E\u202C\u202A\u206B\u206E\u206F\u202E\u200F\u206A\u202A\u202B\u206B\u202A\u202E\u206A\u202D\u206E\u202A\u202E\u202A\u202D\u202B\u206A\u202B\u202B\u206A\u202E\u200B\u206A\u202C\u202C\u202C\u200E\u202E\u200F\u200F\u202E(enumerator) ? 1496899739 : 800014329);
							for (;;)
							{
								int num2 = num5;
								uint num3;
								switch ((num3 = (uint)(num2 * -1705962323 - --850618808 * -649584359)) % 5U)
								{
								case 0U:
									goto IL_0307;
								case 1U:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									num5 = 2003582025;
									continue;
								}
								case 2U:
								{
									int item;
									FriendToken item2;
									FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200C\u206C\u200F\u200E\u200C\u206F\u206B\u200C\u200F\u206D\u200F\u206D\u202E\u202C\u206F\u200F\u200C\u202C\u206B\u200B\u206B\u200B\u200C\u202D\u206E\u200D\u202A\u200D\u200B\u206E\u202D\u200D\u206D\u206F\u202C\u206A\u202A\u206F\u206B\u202D\u202E(list2[item], item2);
									num5 = (int)((num3 * 2168046430U) ^ 2175931252U);
									continue;
								}
								case 4U:
									num5 = 1496899739;
									continue;
								}
								goto Block_13;
							}
						}
						Block_13:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0328:
								int num6 = -454873799;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(num2 * -1705962323 - --850618808 * -649584359)) % 3U)
									{
									case 0U:
										goto IL_0328;
									case 1U:
										FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u206A\u200D\u206A\u202B\u200B\u202B\u200E\u206B\u206D\u202D\u206E\u202E\u200B\u202B\u202B\u200E\u202B\u200E\u202D\u202D\u206E\u206E\u206F\u200E\u202B\u206B\u200F\u206D\u202E\u202C\u200D\u200D\u200D\u200F\u206E\u200D\u206E\u202C\u202D\u206B\u202E(enumerator);
										num6 = (int)((num3 * 4102840082U) ^ 4271389898U);
										continue;
									}
									goto Block_16;
								}
							}
							Block_16:;
						}
					}
					return FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.\u200D\u200B\u200F\u202C\u206F\u206D\u206F\u206F\u200C\u200E\u206D\u206A\u202C\u206A\u202B\u200F\u206F\u200D\u206B\u206C\u202C\u206F\u200F\u202C\u200B\u200D\u202B\u202E\u202C\u206B\u200F\u200C\u200B\u206B\u200B\u202C\u202C\u200D\u202A\u200F\u202E(list2, false, false, false);
				}
				IL_037D:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<Actions>d__21 <Actions>d__ = new FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<Actions>d__21(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<AfterUseAction>d__22 <AfterUseAction>d__ = new FlandreFriendOkinaSummerDef.FlandreFriendOkinaSummer.<AfterUseAction>d__22(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static int? \u202C\u202B\u206E\u200B\u206C\u202C\u202C\u202A\u202C\u206A\u200C\u206E\u200D\u200E\u202D\u200B\u206D\u202B\u202E\u206F\u200F\u206B\u206A\u206C\u206E\u206C\u200E\u206A\u200C\u206D\u200D\u206E\u206F\u206F\u206C\u202E\u202C\u202D\u206F\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206D\u202E\u200E\u206D\u202A\u202E\u206F\u206A\u206C\u200E\u200B\u206E\u202B\u206B\u202D\u202C\u206F\u202E\u206A\u202E\u200E\u206C\u206A\u206B\u202D\u202B\u206F\u206B\u202A\u206B\u200D\u202C\u202A\u202E\u202B\u200D\u200E\u202D\u200F\u206B\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u202B\u200F\u200F\u200F\u202E\u202C\u202A\u206B\u206E\u206F\u202E\u200F\u206A\u202A\u202B\u206B\u202A\u202E\u206A\u202D\u206E\u202A\u202E\u202A\u202D\u202B\u206A\u202B\u202B\u206A\u202E\u200B\u206A\u202C\u202C\u202C\u200E\u202E\u200F\u200F\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206A\u200D\u206A\u202B\u200B\u202B\u200E\u206B\u206D\u202D\u206E\u202E\u200B\u202B\u202B\u200E\u202B\u200E\u202D\u202D\u206E\u206E\u206F\u200E\u202B\u206B\u200F\u206D\u202E\u202C\u200D\u200D\u200D\u200F\u206E\u200D\u206E\u202C\u202D\u206B\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static CardConfig \u200B\u206D\u206D\u206E\u206B\u202A\u202A\u202E\u202B\u202C\u200E\u206B\u202B\u200E\u202B\u206B\u202A\u202D\u202A\u202A\u206B\u206F\u206D\u206C\u206A\u206F\u202C\u200F\u206E\u200D\u202C\u206A\u206E\u202A\u202C\u206E\u202B\u202D\u206A\u202C\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u202B\u200C\u202B\u202B\u206F\u202D\u200F\u200B\u206A\u206C\u200D\u202D\u202C\u200B\u202A\u202A\u206D\u202E\u206B\u200E\u202C\u202E\u200E\u206B\u202B\u206D\u200E\u202E\u206E\u200D\u206F\u206D\u206A\u200E\u200D\u202B\u206B\u200B\u200F\u200C\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u200D\u200E\u200C\u206E\u202C\u206B\u200E\u200E\u202E\u200D\u206D\u206E\u200F\u202B\u202C\u200B\u202E\u200B\u202A\u206D\u206D\u200C\u200B\u202C\u206F\u202C\u200C\u206F\u202A\u202C\u202C\u206F\u200F\u202A\u200B\u202A\u206D\u206C\u200B\u206C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u202B\u206B\u200F\u206C\u202B\u202C\u202B\u206F\u206A\u200D\u206C\u200E\u202C\u206A\u200E\u202B\u202C\u206E\u202E\u200E\u200D\u200D\u200F\u206D\u202B\u200B\u202C\u200B\u202A\u200F\u206F\u202D\u202E\u206F\u202B\u202C\u200D\u200F\u200F\u200E\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static BattleController \u200B\u200B\u200F\u206D\u206F\u200C\u206B\u200B\u200D\u200B\u206F\u206C\u200C\u206C\u200D\u202A\u202C\u206D\u206C\u206F\u202C\u200D\u200C\u202A\u200D\u206E\u206A\u200E\u202A\u202B\u202E\u206E\u206F\u206C\u200E\u200E\u202B\u200D\u200C\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202E\u206D\u200E\u206F\u206C\u202C\u200F\u202B\u206E\u206C\u206F\u200B\u200E\u202B\u200C\u200D\u202E\u202C\u200D\u200F\u206E\u200F\u202B\u200F\u200C\u206A\u202C\u206A\u202A\u200D\u206F\u200B\u206E\u202B\u206C\u200C\u206C\u200F\u202B\u202A\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u206B\u206F\u202A\u200B\u206C\u206B\u206F\u206C\u202E\u202C\u206F\u206C\u200E\u202A\u202E\u206C\u206A\u206A\u206F\u200B\u206F\u200C\u200F\u202B\u206A\u206E\u202E\u200C\u202B\u206B\u202C\u200C\u206D\u206B\u200B\u202B\u202D\u202A\u202B\u202B\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u200F\u200E\u206D\u200F\u200D\u200C\u202A\u200E\u206E\u206C\u202D\u200E\u202A\u202B\u206C\u202C\u206D\u202A\u202E\u206B\u202C\u206F\u200E\u206C\u206C\u206E\u200C\u206F\u202B\u206D\u206D\u202E\u206C\u206A\u202B\u200F\u206C\u206B\u202D\u206F\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200E\u200E\u200D\u206A\u200E\u206E\u202C\u202E\u200F\u200B\u206A\u206C\u202B\u202C\u206A\u202B\u202C\u200C\u206C\u202E\u206D\u202B\u206F\u206B\u202E\u206D\u200D\u200D\u202B\u200B\u206A\u200F\u206A\u200C\u200B\u206E\u202D\u202E\u200B\u202A\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static int \u206C\u206D\u200D\u200B\u206E\u206D\u200C\u206F\u202A\u200D\u200F\u202B\u202D\u200F\u200D\u206E\u200D\u206F\u206C\u206E\u206A\u200E\u200B\u200D\u200E\u202B\u202D\u202D\u202C\u206A\u200B\u206A\u200D\u200B\u200E\u202C\u200F\u202A\u202E\u206E\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameEvent<CardUsingEventArgs> \u206B\u206B\u202E\u200C\u202B\u200F\u200E\u206B\u206C\u206A\u200F\u206A\u202D\u200C\u206B\u200C\u200F\u202D\u200F\u206F\u202B\u206C\u206B\u202C\u200D\u202D\u206E\u200D\u200D\u206C\u200F\u206E\u202B\u200E\u202E\u200B\u200B\u202B\u206A\u206F\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u200D\u202C\u206E\u202A\u200D\u202B\u202A\u200E\u202D\u200D\u206D\u200E\u206C\u202E\u206B\u202D\u206F\u206C\u202B\u206E\u200B\u200E\u202A\u206D\u206F\u200D\u202C\u202A\u200F\u206A\u206A\u206F\u200B\u202D\u206A\u200C\u200E\u202A\u200D\u202E\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u200E\u206C\u200E\u202D\u202B\u206B\u202C\u202E\u206A\u202B\u200D\u202A\u206E\u206F\u200B\u202B\u202A\u200F\u200B\u202B\u200D\u200C\u202D\u200F\u206F\u206D\u202E\u200E\u200D\u206D\u200B\u200D\u202C\u206C\u200F\u206F\u202D\u200C\u206E\u206C\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202E\u200F\u206A\u202E\u200D\u202A\u202E\u202C\u206B\u200C\u202D\u206C\u206D\u200B\u206B\u200B\u206F\u206B\u200D\u200F\u202E\u202C\u206B\u200E\u202D\u200D\u200D\u200D\u200B\u206B\u206C\u202B\u206F\u200C\u202A\u202E\u202B\u206D\u200E\u206C\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u202E\u206B\u202D\u202C\u206C\u206E\u206C\u200E\u206B\u202C\u200F\u200B\u206B\u202C\u206E\u200C\u206F\u200C\u200F\u200F\u206E\u200E\u206E\u200E\u200F\u200B\u202D\u206B\u200C\u200D\u206C\u206D\u206A\u206C\u206E\u206A\u206C\u206F\u202D\u206F\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206E\u202E\u206B\u206F\u202E\u206E\u206A\u206D\u206C\u206B\u200F\u206B\u206E\u206A\u206F\u206A\u200C\u200E\u202C\u206A\u206D\u200F\u206D\u206D\u202A\u202B\u206C\u200C\u202E\u206F\u200D\u202A\u202D\u200B\u200D\u206D\u206C\u206F\u206F\u202A\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u202C\u206F\u200F\u200E\u200F\u202C\u200E\u206F\u200B\u200F\u206B\u202A\u206C\u200B\u206B\u200C\u206B\u206D\u200F\u206F\u206E\u202E\u202B\u206F\u202C\u202B\u202C\u206A\u206B\u200E\u206D\u202A\u206F\u200B\u200E\u202B\u206C\u206B\u206E\u200E\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u200C\u206D\u206C\u202D\u206D\u200D\u200E\u200D\u200E\u202D\u200F\u206C\u206B\u202E\u200F\u202D\u206C\u200C\u202C\u200F\u200E\u206D\u206E\u200C\u200B\u200D\u200D\u202A\u206C\u200D\u206B\u202D\u200E\u200B\u206C\u206D\u200C\u202E\u200F\u206A\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u206A\u202E\u200B\u200D\u202A\u206D\u206A\u202C\u200C\u200E\u202E\u200C\u206C\u202A\u206A\u202C\u200C\u206D\u206D\u200C\u206C\u200F\u202B\u200B\u202C\u200F\u206E\u202D\u200D\u202D\u200E\u200B\u202C\u206D\u202E\u206A\u206E\u200F\u206F\u200D\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u206F\u200D\u206B\u202D\u202E\u200C\u206E\u200B\u206E\u206E\u202D\u206D\u200B\u206A\u202A\u200C\u200C\u206C\u200D\u200D\u202C\u206C\u200E\u202A\u206F\u202A\u202B\u200E\u206B\u200C\u206B\u202D\u202B\u202C\u206E\u200D\u202C\u200F\u200F\u206A\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u202A\u200D\u206F\u202D\u200F\u200E\u206E\u206E\u200E\u200C\u206E\u200C\u202A\u200F\u206A\u206C\u206D\u200B\u202E\u206D\u202C\u200F\u200C\u206F\u206A\u200F\u206D\u200F\u200D\u200B\u200D\u202A\u206A\u206C\u206D\u202C\u206F\u202A\u200B\u200E\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u200C\u206C\u200F\u200E\u200C\u206F\u206B\u200C\u200F\u206D\u200F\u206D\u202E\u202C\u206F\u200F\u200C\u202C\u206B\u200B\u206B\u200B\u200C\u202D\u206E\u200D\u202A\u200D\u200B\u206E\u202D\u200D\u206D\u206F\u202C\u206A\u202A\u206F\u206B\u202D\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u200D\u200B\u200F\u202C\u206F\u206D\u206F\u206F\u200C\u200E\u206D\u206A\u202C\u206A\u202B\u200F\u206F\u200D\u206B\u206C\u202C\u206F\u200F\u202C\u200B\u200D\u202B\u202E\u202C\u206B\u200F\u200C\u200B\u206B\u200B\u202C\u202C\u200D\u202A\u200F\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public bool ActiveUsed;
		}
	}
}
