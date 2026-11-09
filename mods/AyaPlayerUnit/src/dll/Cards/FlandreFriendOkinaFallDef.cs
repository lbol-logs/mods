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
	public sealed class FlandreFriendOkinaFallDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1595517087);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFriendOkinaFallDef.\u202A\u200F\u206F\u200C\u200D\u206B\u202A\u206B\u200B\u206D\u206F\u206C\u202C\u200B\u202D\u202D\u206F\u206A\u206F\u202C\u202D\u200F\u206C\u200F\u200C\u202C\u202C\u202E\u200D\u206A\u206B\u202D\u206B\u206B\u200F\u202E\u206C\u202D\u206C\u206B\u202E(BepinexPlugin.embeddedSource);
			FlandreFriendOkinaFallDef.\u202C\u206D\u200B\u206E\u200E\u206F\u200E\u202E\u202B\u200C\u202B\u206A\u200F\u202C\u202A\u206E\u202A\u206E\u200C\u202B\u200F\u200F\u202D\u200C\u206E\u206D\u206E\u202D\u200D\u206A\u200E\u206C\u200D\u202D\u202A\u206E\u202B\u206C\u202C\u202C\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaFallDef.\u202C\u202C\u206B\u202B\u200C\u206B\u202D\u206D\u206B\u206E\u202D\u206E\u200C\u206D\u202B\u206F\u200B\u202B\u202E\u206F\u206F\u200E\u202E\u206E\u200D\u206F\u200E\u202C\u202E\u206C\u202E\u200F\u200D\u206D\u202B\u200B\u200D\u202C\u202E\u206C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFriendOkinaFallDef.\u202E\u202C\u206A\u206B\u206E\u200B\u200F\u200D\u202A\u200C\u200D\u206F\u202D\u206F\u202B\u206D\u206E\u200E\u206C\u200E\u206A\u202D\u200B\u200B\u206B\u206B\u206F\u206A\u206B\u200F\u206F\u202D\u200D\u202A\u206A\u206B\u206C\u202C\u202B\u200F\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaFallDef.\u206E\u200C\u202E\u206A\u202C\u202E\u200E\u202C\u200F\u202C\u206B\u200D\u200E\u202A\u202A\u206B\u206A\u202A\u202B\u202A\u206E\u200D\u202A\u202E\u206A\u202E\u200C\u206A\u202B\u206D\u206A\u202C\u202C\u200F\u200B\u200D\u206A\u206F\u206E\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, false, true, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
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
			}, null, null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(12), null, null, null, null, null, null, new int?(1), null, new int?(2), null, new int?(-1), null, null, null, new int?(-6), null, Keyword.Replenish, Keyword.Replenish, false, Keyword.Philosophy | Keyword.Exile, Keyword.Philosophy | Keyword.Exile, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(403931841),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1759106977)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(403931841),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1037822697)
			}, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1163222130),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-589528885),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-920538409),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1594215515)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(99449685),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-589528885),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1042466688),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1763499156)
			}, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(936514800), new List<string>());
		}

		static CardImages \u202A\u200F\u206F\u200C\u200D\u206B\u202A\u206B\u200B\u206D\u206F\u206C\u202C\u200B\u202D\u202D\u206F\u206A\u206F\u202C\u202D\u200F\u206C\u200F\u200C\u202C\u202C\u202E\u200D\u206A\u206B\u202D\u206B\u206B\u200F\u202E\u206C\u202D\u206C\u206B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202C\u206D\u200B\u206E\u200E\u206F\u200E\u202E\u202B\u200C\u202B\u206A\u200F\u202C\u202A\u206E\u202A\u206E\u200C\u202B\u200F\u200F\u202D\u200C\u206E\u206D\u206E\u202D\u200D\u206A\u200E\u206C\u200D\u202D\u202A\u206E\u202B\u206C\u202C\u202C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u202C\u206B\u202B\u200C\u206B\u202D\u206D\u206B\u206E\u202D\u206E\u200C\u206D\u202B\u206F\u200B\u202B\u202E\u206F\u206F\u200E\u202E\u206E\u200D\u206F\u200E\u202C\u202E\u206C\u202E\u200F\u200D\u206D\u202B\u200B\u200D\u202C\u202E\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u200C\u202E\u206A\u202C\u202E\u200E\u202C\u200F\u202C\u206B\u200D\u200E\u202A\u202A\u206B\u206A\u202A\u202B\u202A\u206E\u200D\u202A\u202E\u206A\u202E\u200C\u206A\u202B\u206D\u206A\u202C\u202C\u200F\u200B\u200D\u206A\u206F\u206E\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u202C\u206A\u206B\u206E\u200B\u200F\u200D\u202A\u200C\u200D\u206F\u202D\u206F\u202B\u206D\u206E\u200E\u206C\u200E\u206A\u202D\u200B\u200B\u206B\u206B\u206F\u206A\u206B\u200F\u206F\u202D\u200D\u202A\u206A\u206B\u206C\u202C\u202B\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaFallDef))]
		public sealed class FlandreFriendOkinaFall : FlandreCard
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
					return FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206A\u206A\u206E\u206F\u202E\u206C\u200D\u206E\u206A\u202C\u206B\u202C\u200F\u206C\u200D\u200F\u206A\u202B\u206F\u206B\u202C\u206A\u202A\u202B\u202C\u206D\u200D\u200B\u202D\u202E\u200B\u206C\u206E\u206C\u206B\u202D\u200E\u202C\u206B\u200F\u202E(this).GetValueOrDefault() * 4;
				}
			}

			public int Value3
			{
				get
				{
					return 4;
				}
			}

			public int Value4
			{
				get
				{
					return base.FlandreModifier(1 + FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206E\u200B\u200B\u206F\u202B\u202A\u206E\u206E\u202A\u206D\u200F\u206C\u200B\u202E\u202B\u206D\u202E\u200B\u202C\u202D\u206E\u206F\u200D\u202D\u200E\u206E\u202D\u202D\u206C\u202C\u202E\u206D\u202B\u206C\u200F\u202B\u202D\u200C\u206C\u206A\u202E((float)FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206A\u206A\u206E\u206F\u202E\u206C\u200D\u206E\u206A\u202C\u206B\u202C\u200F\u206C\u200D\u200F\u206A\u202B\u206F\u206B\u202C\u206A\u202A\u202B\u202C\u206D\u200D\u200B\u202D\u202E\u200B\u206C\u206E\u206C\u206B\u202D\u200E\u202C\u206B\u200F\u202E(this).GetValueOrDefault() / 2f), false);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206E\u200B\u200B\u206F\u202B\u202A\u206E\u206E\u202A\u206D\u200F\u206C\u200B\u202E\u202B\u206D\u202E\u200B\u202C\u202D\u206E\u206F\u200D\u202D\u200E\u206E\u202D\u202D\u206C\u202C\u202E\u206D\u202B\u206C\u200F\u202B\u202D\u200C\u206C\u206A\u202E((float)FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206A\u206A\u206E\u206F\u202E\u206C\u200D\u206E\u206A\u202C\u206B\u202C\u200F\u206C\u200D\u200F\u206A\u202B\u206F\u206B\u202C\u206A\u202A\u202B\u202C\u206D\u200D\u200B\u202D\u202E\u200B\u206C\u206E\u206C\u206B\u202D\u200E\u202C\u206B\u200F\u202E(this).GetValueOrDefault() / 2f)
					};
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
							IL_004D:
							int num = ((!FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u202B\u200F\u206C\u200F\u206C\u200E\u206D\u202E\u206F\u206B\u202A\u206E\u206F\u206E\u200C\u206A\u202B\u200D\u202D\u200D\u206A\u200B\u200B\u200D\u202E\u200C\u202B\u202A\u200D\u202A\u200B\u202B\u206E\u206F\u200D\u202D\u200E\u200E\u206E\u202E(enumerator)) ? 811702506 : 762157690);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 6U)
								{
								case 1U:
									goto IL_004D;
								case 2U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 430532149U) ^ 3520628091U);
									continue;
								}
								case 3U:
									num = 762157690;
									continue;
								case 4U:
								{
									ManaColor manaColor = enumerator.Current;
									num = 863475491;
									continue;
								}
								case 5U:
								{
									ManaColor manaColor;
									num = (int)(((manaGroup.GetValue(manaColor) <= 0) ? 4194924196U : 4144549607U) ^ (num3 * 415529003U));
									continue;
								}
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
								IL_00C6:
								int num4 = 1367003594;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 3U)
									{
									case 0U:
										goto IL_00C6;
									case 2U:
										FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206F\u202C\u200C\u202A\u206B\u200C\u202B\u202E\u206A\u202E\u202B\u206F\u206B\u202E\u206C\u206A\u202E\u200D\u202D\u202E\u206A\u206F\u200C\u200C\u200E\u200E\u206D\u200E\u206D\u202D\u206D\u200F\u206B\u200C\u200F\u202A\u202E\u206E\u202E\u202D\u202E(enumerator);
										num4 = (int)((num3 * 2784303895U) ^ 1438107295U);
										continue;
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
				if (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200C\u206B\u202E\u202C\u202C\u206A\u206A\u206F\u206D\u200E\u206B\u202C\u202C\u202D\u206B\u206A\u206D\u202C\u206B\u200E\u202C\u202D\u206A\u200E\u202D\u206C\u200B\u206A\u206F\u206F\u202E\u206C\u200E\u200F\u206B\u206B\u202E\u206F\u200F\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_0537;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text2;
					switch ((num3 = (uint)((-473284690 - (-num + ((632639073 ^ -679424724) - (1561811329 ^ 1430404632)))) ^ 1309723406)) % 40U)
					{
					case 0U:
						goto IL_0176;
					case 1U:
						text = base.RawExtraDescription2;
						num2 = 1990535212;
						continue;
					case 2U:
						num2 = (int)((num3 * 135687174U) ^ 2415750822U);
						continue;
					case 3U:
						num2 = (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u206A\u200F\u206F\u206A\u200F\u202D\u202C\u200F\u202A\u206B\u202A\u200B\u200D\u200F\u202E\u200B\u200B\u202D\u200B\u206C\u206D\u200B\u202C\u200D\u206E\u200F\u202D\u202E\u200F\u200B\u202D\u202D\u200C\u206C\u202A\u200D\u202B\u206B\u206E\u202E(this) ? 1999450087 : 763484184);
						continue;
					case 4U:
						goto IL_0010;
					case 5U:
						num2 = (int)((num3 * 3533700814U) ^ 2607667907U);
						continue;
					case 6U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 190793642;
						continue;
					}
					case 7U:
						num2 = ((FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200B\u206D\u200B\u202B\u206D\u206B\u202C\u206B\u200F\u206F\u200D\u206D\u206F\u202E\u206C\u200E\u206B\u206B\u202E\u200F\u202D\u200B\u200F\u206B\u200C\u202E\u200D\u200B\u202E\u202E\u202B\u200C\u200D\u202B\u200F\u206C\u202A\u206D\u200F\u206B\u202E(this) == null) ? 1684095803 : 1016052502);
						continue;
					case 8U:
						goto IL_01CC;
					case 9U:
						goto IL_0537;
					case 10U:
						goto IL_00EE;
					case 11U:
						num2 = ((!base.HasExtraDescription2) ? 1390353902 : (-2049204338));
						continue;
					case 12U:
					{
						int num4;
						num2 = (int)(((num4 == 1) ? 1567811528U : 1292500729U) ^ (num3 * 3386260828U));
						continue;
					}
					case 13U:
						goto IL_01B3;
					case 14U:
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription2);
						num2 = (int)((num3 * 3159408890U) ^ 3499216690U);
						continue;
					case 15U:
						num2 = (int)((num3 * 4220878781U) ^ 2619822527U);
						continue;
					case 16U:
						num2 = (int)((num3 * 825459271U) ^ 2914079132U);
						continue;
					case 17U:
						goto IL_012F;
					case 18U:
						goto IL_0105;
					case 19U:
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						num2 = (int)((num3 * 2556949437U) ^ 3197565172U);
						continue;
					case 20U:
						text = base.RawExtraDescription1;
						num2 = 1819816031;
						continue;
					case 21U:
						num2 = (int)(((FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202C\u200F\u206E\u206D\u200C\u202B\u200F\u206E\u202B\u202B\u202B\u200B\u200E\u202D\u206B\u206C\u200D\u206E\u206F\u200E\u200E\u206D\u206D\u206D\u200D\u206F\u200B\u200E\u206C\u200C\u202A\u206B\u200C\u200B\u200F\u206C\u206C\u202B\u206A\u202C\u202E(this) == CardType.Friend) ? 824818753U : 2099298815U) ^ (num3 * 1999206513U));
						continue;
					case 22U:
						num2 = (base.HasExtraDescription3 ? 1095473379 : 1483316612);
						continue;
					case 23U:
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription1);
						num2 = (int)((num3 * 1916343606U) ^ 16117713U);
						continue;
					case 24U:
						switch (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200F\u202B\u206C\u202A\u206B\u200D\u206C\u206D\u202C\u202B\u202C\u202B\u202B\u200E\u202C\u206C\u202E\u200C\u200C\u202B\u206F\u200D\u202B\u202A\u206A\u202B\u206B\u202E\u202C\u206C\u206A\u200B\u206C\u200C\u206F\u206E\u202D\u202A\u200C\u202A\u202E(this))
						{
						case FriendToken.None:
							goto IL_01CC;
						case FriendToken.Active:
							goto IL_00EE;
						case FriendToken.Active2:
							goto IL_0176;
						case FriendToken.Ultimate:
							goto IL_0105;
						default:
							num2 = (int)((num3 * 3933175113U) ^ 66179833U);
							continue;
						}
						break;
					case 25U:
						num2 = (int)((num3 * 3313973587U) ^ 1410756591U);
						continue;
					case 26U:
					{
						int num4 = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200B\u202C\u202E\u200C\u206E\u202D\u200E\u200B\u206D\u206E\u206E\u200F\u206C\u202A\u206D\u206E\u200C\u202B\u202B\u200D\u200B\u206B\u200B\u200B\u206F\u206C\u200E\u200B\u206E\u206F\u206F\u200B\u206E\u202D\u202A\u206B\u200D\u206C\u206D\u206E\u202E(this);
						num2 = 939360504;
						continue;
					}
					case 27U:
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription3);
						num2 = (int)((num3 * 1757689945U) ^ 469499046U);
						continue;
					case 28U:
						num2 = (int)((num3 * 3370565952U) ^ 4252008068U);
						continue;
					case 29U:
					{
						int num4;
						num2 = (int)(((num4 == 2) ? 1586502382U : 549665104U) ^ (num3 * 1875121255U));
						continue;
					}
					case 30U:
						if (!FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u206A\u200F\u206F\u206A\u200F\u202D\u202C\u200F\u202A\u206B\u202A\u200B\u200D\u200F\u202E\u200B\u200B\u202D\u200B\u206C\u206D\u200B\u202C\u200D\u206E\u200F\u202D\u202E\u200F\u200B\u202D\u202D\u200C\u206C\u202A\u200D\u202B\u206B\u206E\u202E(this))
						{
							num2 = (int)((num3 * 2918049660U) ^ 973300271U);
							continue;
						}
						text2 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_03E6;
					case 31U:
					{
						object obj = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription;
						num2 = ((obj == null) ? 1343922502 : 190793642);
						continue;
					}
					case 33U:
						num2 = (base.HasExtraDescription1 ? 869285871 : 2143059051);
						continue;
					case 34U:
					{
						object obj;
						text = (string)obj;
						num2 = 1483316612;
						continue;
					}
					case 35U:
						num2 = (int)((num3 * 1792103041U) ^ 2038961428U);
						continue;
					case 36U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 314974866;
						continue;
					}
					case 37U:
						num2 = (int)((num3 * 3568891621U) ^ 566805421U);
						continue;
					case 38U:
					{
						string text3 = text;
						string text4;
						if (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200B\u206D\u200B\u202B\u206D\u206B\u202C\u206B\u200F\u206F\u200D\u206D\u206F\u202E\u206C\u200E\u206B\u206B\u202E\u200F\u202D\u200B\u200F\u206B\u200C\u202E\u200D\u200B\u202E\u202E\u202B\u200C\u200D\u202B\u200F\u206C\u202A\u206D\u200F\u206B\u202E(this) == null)
						{
							if (!FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u206A\u200F\u206F\u206A\u200F\u202D\u202C\u200F\u202A\u206B\u202A\u200B\u200D\u200F\u202E\u200B\u200B\u202D\u200B\u206C\u206D\u200B\u202C\u200D\u206E\u200F\u202D\u202E\u200F\u200B\u202D\u202D\u200C\u206C\u202A\u200D\u202B\u206B\u206E\u202E(this))
							{
								text4 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
							else if ((text4 = base.UpgradedNonbattleBaseDescription) == null)
							{
								text4 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
						}
						else
						{
							text4 = (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u206A\u200F\u206F\u206A\u200F\u202D\u202C\u200F\u202A\u206B\u202A\u200B\u200D\u200F\u202E\u200B\u200B\u202D\u200B\u206C\u206D\u200B\u202C\u200D\u206E\u200F\u202D\u202E\u200F\u200B\u202D\u202D\u200C\u206C\u202A\u200D\u202B\u206B\u206E\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						}
						text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text3, text4);
						num2 = 1116792821;
						continue;
					}
					case 39U:
						text2 = base.BaseDescription;
						goto IL_03E6;
					}
					break;
					IL_00EE:
					text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription1);
					num2 = 553686785;
					continue;
					IL_0105:
					text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription3);
					num2 = 1483316612;
					continue;
					IL_0176:
					text = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(text, base.RawExtraDescription2);
					num2 = 207665176;
					continue;
					IL_01CC:
					num2 = (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200C\u206B\u202E\u202C\u202C\u206A\u206A\u206F\u206D\u200E\u206B\u202C\u202C\u202D\u206B\u206A\u206D\u202C\u206B\u200E\u202C\u202D\u206A\u200E\u202D\u206C\u200B\u206A\u206F\u206F\u202E\u206C\u200E\u200F\u206B\u206B\u202E\u206F\u200F\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(this)) ? 1116792821 : 728486030);
					continue;
					IL_03E6:
					text = text2;
					num2 = 1483316612;
				}
				goto IL_0547;
				IL_012F:
				throw FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u206B\u206B\u200E\u206A\u202A\u202D\u206E\u202B\u200E\u206B\u206F\u202B\u202A\u202D\u206A\u202B\u200D\u200C\u206E\u200E\u202C\u200F\u202D\u202D\u206B\u200C\u202C\u200B\u206E\u202C\u202A\u206D\u202E\u200B\u206C\u202E\u202E\u200E\u206E\u202E();
				IL_01B3:
				return string.Empty;
				IL_0547:
				return base.FollowByDetailIcon(text);
				IL_0010:
				num2 = 2037492545;
				goto IL_0015;
				IL_0537:
				text = string.Empty;
				num2 = 1190949353;
				goto IL_0015;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<EnumerateRelativeCards>d__13 <EnumerateRelativeCards>d__ = new FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<EnumerateRelativeCards>d__13(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.Amount = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200E\u202B\u200E\u202C\u202D\u200E\u202D\u202A\u202B\u206F\u200E\u206E\u206B\u206D\u200E\u200C\u200E\u202D\u200D\u200F\u202C\u200B\u206C\u200E\u206D\u206A\u206E\u202B\u202D\u202B\u202E\u206B\u206D\u200C\u206C\u200C\u202A\u200C\u202E\u202E(this);
				for (;;)
				{
					IL_000C:
					int num = -1600438456;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~num2 + 914468923 * (-836010142 - -875587959) - (-1564623962 + -1717631279)) ^ -1364428533)) % 3U)
						{
						case 0U:
							goto IL_000C;
						case 1U:
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206D\u200F\u206B\u200B\u202B\u200E\u200D\u202E\u202B\u200E\u206F\u206F\u200D\u200E\u200F\u206A\u202B\u206A\u202E\u200E\u206C\u200B\u206B\u200D\u200B\u202C\u206F\u202E\u202D\u202E\u202A\u200E\u206D\u200F\u202B\u202A\u200F\u206E\u202E\u202C\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200B\u206D\u200B\u202B\u206D\u206B\u202C\u206B\u200F\u206F\u200D\u206D\u206F\u202E\u206C\u200E\u206B\u206B\u202E\u200F\u202D\u200B\u200F\u206B\u200C\u202E\u200D\u200B\u202E\u202E\u202B\u200C\u200D\u202B\u200F\u206C\u202A\u206D\u200F\u206B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 1572004699U) ^ 1144096819U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200D\u206D\u202C\u206D\u206F\u206F\u202E\u200B\u206F\u200C\u206B\u206E\u200C\u202B\u206E\u202D\u200F\u200F\u206B\u206F\u200C\u200D\u200F\u206F\u200D\u202E\u202B\u202B\u206D\u202C\u200E\u200D\u206A\u206B\u200C\u200E\u206D\u206B\u206C\u202D\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200B\u206D\u200B\u202B\u206D\u206B\u202C\u206B\u200F\u206F\u200D\u206D\u206F\u202E\u206C\u200E\u206B\u206B\u202E\u200F\u202D\u200B\u200F\u206B\u200C\u202E\u200D\u200B\u202E\u202E\u202B\u200C\u200D\u202B\u200F\u206C\u202A\u206D\u200F\u206B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<OnCardUsed>d__15 <OnCardUsed>d__ = new FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<OnCardUsed>d__15(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<GetPassiveActions>d__16 <GetPassiveActions>d__ = new FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<GetPassiveActions>d__16(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202C\u200F\u206E\u206D\u200C\u202B\u200F\u206E\u202B\u202B\u202B\u200B\u200E\u202D\u206B\u206C\u200D\u206E\u206F\u200E\u200E\u206D\u206D\u206D\u200D\u206F\u200B\u200E\u206C\u200C\u202A\u206B\u200C\u200B\u200F\u206C\u206C\u202B\u206A\u202C\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list;
					List<Card> list2;
					for (;;)
					{
						IL_000C:
						int num = 1011691437;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~num2) ^ (-1182874538 ^ -825707778))) % 18U)
							{
							case 0U:
								list.Add(FriendToken.Ultimate);
								num = (int)((num3 * 3035156033U) ^ 1339500777U);
								continue;
							case 1U:
								num = (int)(((FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202C\u202A\u202E\u200F\u202C\u200F\u206F\u202C\u202D\u206D\u206C\u202E\u206A\u200E\u206E\u206A\u202D\u200F\u206E\u206F\u202A\u202D\u202B\u200D\u206E\u202B\u200F\u200F\u200B\u202B\u200C\u202C\u200F\u200E\u202C\u206D\u200E\u206E\u202E(this) < -FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202C\u206D\u202A\u206E\u206E\u206D\u200D\u200E\u202A\u202B\u206F\u202C\u206C\u206C\u202B\u200B\u206A\u206A\u206C\u202B\u202E\u206F\u206E\u206C\u200F\u206F\u200B\u200C\u202E\u200E\u206F\u206E\u206A\u202D\u202B\u202B\u202A\u200F\u202C\u200D\u202E(this)) ? 2329485845U : 2272391755U) ^ (num3 * 2408546604U));
								continue;
							case 2U:
							{
								int? num4 = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202C\u202B\u206C\u202B\u202B\u200E\u202A\u206E\u202C\u200E\u206E\u202C\u206A\u202E\u206B\u206D\u202A\u202A\u200F\u202D\u206E\u206A\u202B\u200B\u200F\u206D\u202E\u200F\u206E\u206A\u206D\u206A\u200E\u202A\u206E\u202C\u200F\u206D\u206E\u202D\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(this));
								num = 530041154;
								continue;
							}
							case 3U:
								list = new List<FriendToken>();
								num = (int)((num3 * 3515576333U) ^ 3640362167U);
								continue;
							case 4U:
								list.Add(FriendToken.Active2);
								num = (int)((num3 * 1551279523U) ^ 2167775761U);
								continue;
							case 5U:
								num = (int)(((FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202C\u202A\u202E\u200F\u202C\u200F\u206F\u202C\u202D\u206D\u206C\u202E\u206A\u200E\u206E\u206A\u202D\u200F\u206E\u206F\u202A\u202D\u202B\u200D\u206E\u202B\u200F\u200F\u200B\u202B\u200C\u202C\u200F\u200E\u202C\u206D\u200E\u206E\u202E(this) >= -FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200C\u200E\u200B\u206C\u200C\u206D\u206B\u202E\u202E\u206D\u206F\u206C\u202C\u202C\u202D\u202B\u200F\u206C\u206C\u202C\u200E\u206F\u206F\u202C\u202A\u206C\u202E\u200C\u202A\u200C\u206A\u206E\u202D\u202D\u206D\u206D\u202D\u200C\u202E\u200F\u202E(this)) ? 1719776714U : 1504795484U) ^ (num3 * 3540603303U));
								continue;
							case 6U:
							{
								int? num4 = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206A\u202A\u206E\u200D\u200E\u200E\u200F\u206F\u206A\u206C\u206E\u200D\u206C\u200F\u202B\u206A\u206F\u206C\u202D\u200B\u206F\u206E\u202A\u202C\u202D\u202B\u202B\u202E\u200D\u200B\u206C\u206F\u202B\u206E\u202B\u206A\u200F\u200D\u202D\u206D\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(this));
								num = ((num4 != null) ? 523586050 : 175946353);
								continue;
							}
							case 8U:
								list2 = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206D\u206B\u202C\u200C\u206B\u200D\u202A\u206C\u202D\u202B\u206B\u206F\u202A\u206A\u202E\u200E\u200F\u206A\u202A\u206A\u200E\u202B\u200D\u200E\u206E\u206D\u206B\u200D\u200C\u206B\u200C\u202A\u206B\u206F\u206E\u206B\u200B\u206E\u206C\u202D\u202E(this, list.Count, false).ToList<Card>();
								num = 117830668;
								continue;
							case 9U:
								num = (int)((this.ActiveUsed ? 833971503U : 592852230U) ^ (num3 * 438942028U));
								continue;
							case 10U:
								num = (int)(((FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202C\u202A\u202E\u200F\u202C\u200F\u206F\u202C\u202D\u206D\u206C\u202E\u206A\u200E\u206E\u206A\u202D\u200F\u206E\u206F\u202A\u202D\u202B\u200D\u206E\u202B\u200F\u200F\u200B\u202B\u200C\u202C\u200F\u200E\u202C\u206D\u200E\u206E\u202E(this) >= -FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206D\u200D\u206D\u200B\u206A\u202A\u200F\u202D\u206D\u206E\u200D\u206B\u200D\u202B\u206C\u206E\u206F\u200F\u206D\u202E\u200B\u200C\u202E\u200D\u202B\u202C\u206C\u202A\u206E\u206A\u206E\u206F\u206B\u200E\u206A\u206F\u202D\u202E\u206D\u200F\u202E(this)) ? 246301213U : 508483209U) ^ (num3 * 3379251863U));
								continue;
							case 11U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 139394590U : 751136029U) ^ (num3 * 732666012U));
								continue;
							}
							case 12U:
								list.Add(FriendToken.Active);
								num = (int)((num3 * 1464463117U) ^ 1543007347U);
								continue;
							case 13U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 254843125U : 520088219U) ^ (num3 * 3254019960U));
								continue;
							}
							case 14U:
								if (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202C\u202A\u202E\u200F\u202C\u200F\u206F\u202C\u202D\u206D\u206C\u202E\u206A\u200E\u206E\u206A\u202D\u200F\u206E\u206F\u202A\u202D\u202B\u200D\u206E\u202B\u200F\u200F\u200B\u202B\u200C\u202C\u200F\u200E\u202C\u206D\u200E\u206E\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 3873569319U) ^ 1115660430U);
									continue;
								}
								goto IL_0385;
							case 15U:
							{
								int? num4 = FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200F\u202C\u202D\u202E\u200E\u200D\u200C\u206B\u206B\u200D\u206B\u200C\u202D\u206C\u206B\u200F\u202B\u206B\u202A\u202D\u202E\u200B\u200B\u200D\u206E\u200F\u206F\u206F\u202D\u200D\u206C\u206D\u206B\u202D\u202A\u200E\u202B\u200F\u206D\u200E\u202E(FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(this));
								num = (int)((num3 * 1252185446U) ^ 1215841786U);
								continue;
							}
							case 16U:
								if (FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u200C\u206F\u200B\u206A\u206C\u206B\u200C\u200E\u206C\u202E\u206B\u200B\u200D\u206F\u202A\u202C\u206C\u206B\u206F\u200D\u206F\u202C\u206F\u206B\u200E\u206C\u200D\u206C\u200B\u202D\u202E\u200B\u200E\u206D\u200E\u206D\u206F\u200E\u206A\u202D\u202E(this))
								{
									num = (int)((num3 * 4099005322U) ^ 2837106071U);
									continue;
								}
								goto IL_0385;
							case 17U:
								goto IL_000C;
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
							IL_02D9:
							int num5 = ((!FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u202E\u202B\u200F\u206C\u200F\u206C\u200E\u206D\u202E\u206F\u206B\u202A\u206E\u206F\u206E\u200C\u206A\u202B\u200D\u202D\u200D\u206A\u200B\u200B\u200D\u202E\u200C\u202B\u202A\u200D\u202A\u200B\u202B\u206E\u206F\u200D\u202D\u200E\u200E\u206E\u202E(enumerator)) ? 232062921 : 1901972398);
							for (;;)
							{
								int num2 = num5;
								uint num3;
								switch ((num3 = (uint)(-(~num2) ^ (-1182874538 ^ -825707778))) % 5U)
								{
								case 1U:
									goto IL_02D9;
								case 2U:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									num5 = 1537402723;
									continue;
								}
								case 3U:
								{
									int item;
									FriendToken item2;
									FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206D\u206D\u200E\u200E\u202E\u206C\u200B\u206C\u206E\u202E\u206D\u206D\u200E\u202D\u202A\u200B\u206F\u206A\u200D\u202C\u206F\u202E\u200D\u206D\u202A\u200B\u200E\u206C\u200E\u206C\u200C\u200B\u200C\u206F\u200E\u206E\u200B\u206D\u202B\u200C\u202E(list2[item], item2);
									num5 = (int)((num3 * 3672774146U) ^ 1710154793U);
									continue;
								}
								case 4U:
									num5 = 1901972398;
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
								IL_0335:
								int num6 = 1144020283;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(-(~num2) ^ (-1182874538 ^ -825707778))) % 3U)
									{
									case 1U:
										FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206F\u202C\u200C\u202A\u206B\u200C\u202B\u202E\u206A\u202E\u202B\u206F\u206B\u202E\u206C\u206A\u202E\u200D\u202D\u202E\u206A\u206F\u200C\u200C\u200E\u200E\u206D\u200E\u206D\u202D\u206D\u200F\u206B\u200C\u200F\u202A\u202E\u206E\u202E\u202D\u202E(enumerator);
										num6 = (int)((num3 * 3143479982U) ^ 129617921U);
										continue;
									case 2U:
										goto IL_0335;
									}
									goto Block_16;
								}
							}
							Block_16:;
						}
					}
					return FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.\u206F\u206B\u202D\u200F\u206F\u200E\u206B\u202C\u200E\u200D\u206C\u206E\u206F\u202D\u202D\u202C\u202A\u202B\u200F\u200B\u202B\u200B\u202C\u200E\u202C\u200D\u200C\u202B\u206C\u200D\u206C\u206B\u206E\u206E\u206B\u206A\u200C\u200C\u202E\u200E\u202E(list2, false, false, false);
				}
				IL_0385:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<Actions>d__19 <Actions>d__ = new FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<Actions>d__19(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<AfterUseAction>d__20 <AfterUseAction>d__ = new FlandreFriendOkinaFallDef.FlandreFriendOkinaFall.<AfterUseAction>d__20(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static int? \u206A\u206A\u206E\u206F\u202E\u206C\u200D\u206E\u206A\u202C\u206B\u202C\u200F\u206C\u200D\u200F\u206A\u202B\u206F\u206B\u202C\u206A\u202A\u202B\u202C\u206D\u200D\u200B\u202D\u202E\u200B\u206C\u206E\u206C\u206B\u202D\u200E\u202C\u206B\u200F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206E\u200B\u200B\u206F\u202B\u202A\u206E\u206E\u202A\u206D\u200F\u206C\u200B\u202E\u202B\u206D\u202E\u200B\u202C\u202D\u206E\u206F\u200D\u202D\u200E\u206E\u202D\u202D\u206C\u202C\u202E\u206D\u202B\u206C\u200F\u202B\u202D\u200C\u206C\u206A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u202E\u202B\u200F\u206C\u200F\u206C\u200E\u206D\u202E\u206F\u206B\u202A\u206E\u206F\u206E\u200C\u206A\u202B\u200D\u202D\u200D\u206A\u200B\u200B\u200D\u202E\u200C\u202B\u202A\u200D\u202A\u200B\u202B\u206E\u206F\u200D\u202D\u200E\u200E\u206E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206F\u202C\u200C\u202A\u206B\u200C\u202B\u202E\u206A\u202E\u202B\u206F\u206B\u202E\u206C\u206A\u202E\u200D\u202D\u202E\u206A\u206F\u200C\u200C\u200E\u200E\u206D\u200E\u206D\u202D\u206D\u200F\u206B\u200C\u200F\u202A\u202E\u206E\u202E\u202D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static CardConfig \u202B\u200F\u202B\u206E\u202C\u206F\u206B\u202D\u202B\u206D\u202A\u206F\u202D\u206D\u202C\u206F\u200D\u206C\u200F\u200B\u200B\u202D\u200D\u200C\u206F\u202B\u206A\u200C\u200B\u202E\u200B\u206E\u202B\u200E\u206F\u206F\u200F\u200B\u202A\u202E\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u200C\u206B\u202E\u202C\u202C\u206A\u206A\u206F\u206D\u200E\u206B\u202C\u202C\u202D\u206B\u206A\u206D\u202C\u206B\u200E\u202C\u202D\u206A\u200E\u202D\u206C\u200B\u206A\u206F\u206F\u202E\u206C\u200E\u200F\u206B\u206B\u202E\u206F\u200F\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u202C\u200F\u206E\u206D\u200C\u202B\u200F\u206E\u202B\u202B\u202B\u200B\u200E\u202D\u206B\u206C\u200D\u206E\u206F\u200E\u200E\u206D\u206D\u206D\u200D\u206F\u200B\u200E\u206C\u200C\u202A\u206B\u200C\u200B\u200F\u206C\u206C\u202B\u206A\u202C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u200F\u202B\u206C\u202A\u206B\u200D\u206C\u206D\u202C\u202B\u202C\u202B\u202B\u200E\u202C\u206C\u202E\u200C\u200C\u202B\u206F\u200D\u202B\u202A\u206A\u202B\u206B\u202E\u202C\u206C\u206A\u200B\u206C\u200C\u206F\u206E\u202D\u202A\u200C\u202A\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static BattleController \u200B\u206D\u200B\u202B\u206D\u206B\u202C\u206B\u200F\u206F\u200D\u206D\u206F\u202E\u206C\u200E\u206B\u206B\u202E\u200F\u202D\u200B\u200F\u206B\u200C\u202E\u200D\u200B\u202E\u202E\u202B\u200C\u200D\u202B\u200F\u206C\u202A\u206D\u200F\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202E\u206A\u200F\u206F\u206A\u200F\u202D\u202C\u200F\u202A\u206B\u202A\u200B\u200D\u200F\u202E\u200B\u200B\u202D\u200B\u206C\u206D\u200B\u202C\u200D\u206E\u200F\u202D\u202E\u200F\u200B\u202D\u202D\u200C\u206C\u202A\u200D\u202B\u206B\u206E\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u202A\u202A\u202D\u206E\u202C\u206D\u206A\u206D\u200D\u202A\u206C\u200E\u200C\u206A\u202B\u200F\u202D\u202D\u200F\u200D\u202D\u202C\u200F\u206E\u202C\u206B\u200C\u200F\u206F\u206C\u206A\u202E\u200D\u206C\u200E\u200F\u202D\u202C\u206E\u206B\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u202E\u206B\u206B\u200E\u206A\u202A\u202D\u206E\u202B\u200E\u206B\u206F\u202B\u202A\u202D\u206A\u202B\u200D\u200C\u206E\u200E\u202C\u200F\u202D\u202D\u206B\u200C\u202C\u200B\u206E\u202C\u202A\u206D\u202E\u200B\u206C\u202E\u202E\u200E\u206E\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200B\u202C\u202E\u200C\u206E\u202D\u200E\u200B\u206D\u206E\u206E\u200F\u206C\u202A\u206D\u206E\u200C\u202B\u202B\u200D\u200B\u206B\u200B\u200B\u206F\u206C\u200E\u200B\u206E\u206F\u206F\u200B\u206E\u202D\u202A\u206B\u200D\u206C\u206D\u206E\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static int \u202B\u200E\u202B\u200E\u202C\u202D\u200E\u202D\u202A\u202B\u206F\u200E\u206E\u206B\u206D\u200E\u200C\u200E\u202D\u200D\u200F\u202C\u200B\u206C\u200E\u206D\u206A\u206E\u202B\u202D\u202B\u202E\u206B\u206D\u200C\u206C\u200C\u202A\u200C\u202E\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameEvent<CardUsingEventArgs> \u206D\u200F\u206B\u200B\u202B\u200E\u200D\u202E\u202B\u200E\u206F\u206F\u200D\u200E\u200F\u206A\u202B\u206A\u202E\u200E\u206C\u200B\u206B\u200D\u200B\u202C\u206F\u202E\u202D\u202E\u202A\u200E\u206D\u200F\u202B\u202A\u200F\u206E\u202E\u202C\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u200D\u206D\u202C\u206D\u206F\u206F\u202E\u200B\u206F\u200C\u206B\u206E\u200C\u202B\u206E\u202D\u200F\u200F\u206B\u206F\u200C\u200D\u200F\u206F\u200D\u202E\u202B\u202B\u206D\u202C\u200E\u200D\u206A\u206B\u200C\u200E\u206D\u206B\u206C\u202D\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u200C\u206F\u200B\u206A\u206C\u206B\u200C\u200E\u206C\u202E\u206B\u200B\u200D\u206F\u202A\u202C\u206C\u206B\u206F\u200D\u206F\u202C\u206F\u206B\u200E\u206C\u200D\u206C\u200B\u202D\u202E\u200B\u200E\u206D\u200E\u206D\u206F\u200E\u206A\u202D\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202B\u200F\u202C\u202A\u202E\u200F\u202C\u200F\u206F\u202C\u202D\u206D\u206C\u202E\u206A\u200E\u206E\u206A\u202D\u200F\u206E\u206F\u202A\u202D\u202B\u200D\u206E\u202B\u200F\u200F\u200B\u202B\u200C\u202C\u200F\u200E\u202C\u206D\u200E\u206E\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u200F\u202C\u202D\u202E\u200E\u200D\u200C\u206B\u206B\u200D\u206B\u200C\u202D\u206C\u206B\u200F\u202B\u206B\u202A\u202D\u202E\u200B\u200B\u200D\u206E\u200F\u206F\u206F\u202D\u200D\u206C\u206D\u206B\u202D\u202A\u200E\u202B\u200F\u206D\u200E\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206D\u200D\u206D\u200B\u206A\u202A\u200F\u202D\u206D\u206E\u200D\u206B\u200D\u202B\u206C\u206E\u206F\u200F\u206D\u202E\u200B\u200C\u202E\u200D\u202B\u202C\u206C\u202A\u206E\u206A\u206E\u206F\u206B\u200E\u206A\u206F\u202D\u202E\u206D\u200F\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u202C\u202B\u206C\u202B\u202B\u200E\u202A\u206E\u202C\u200E\u206E\u202C\u206A\u202E\u206B\u206D\u202A\u202A\u200F\u202D\u206E\u206A\u202B\u200B\u200F\u206D\u202E\u200F\u206E\u206A\u206D\u206A\u200E\u202A\u206E\u202C\u200F\u206D\u206E\u202D\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u200C\u200E\u200B\u206C\u200C\u206D\u206B\u202E\u202E\u206D\u206F\u206C\u202C\u202C\u202D\u202B\u200F\u206C\u206C\u202C\u200E\u206F\u206F\u202C\u202A\u206C\u202E\u200C\u202A\u200C\u206A\u206E\u202D\u202D\u206D\u206D\u202D\u200C\u202E\u200F\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u206A\u202A\u206E\u200D\u200E\u200E\u200F\u206F\u206A\u206C\u206E\u200D\u206C\u200F\u202B\u206A\u206F\u206C\u202D\u200B\u206F\u206E\u202A\u202C\u202D\u202B\u202B\u202E\u200D\u200B\u206C\u206F\u202B\u206E\u202B\u206A\u200F\u200D\u202D\u206D\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u202C\u206D\u202A\u206E\u206E\u206D\u200D\u200E\u202A\u202B\u206F\u202C\u206C\u206C\u202B\u200B\u206A\u206A\u206C\u202B\u202E\u206F\u206E\u206C\u200F\u206F\u200B\u200C\u202E\u200E\u206F\u206E\u206A\u202D\u202B\u202B\u202A\u200F\u202C\u200D\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u206D\u206B\u202C\u200C\u206B\u200D\u202A\u206C\u202D\u202B\u206B\u206F\u202A\u206A\u202E\u200E\u200F\u206A\u202A\u206A\u200E\u202B\u200D\u200E\u206E\u206D\u206B\u200D\u200C\u206B\u200C\u202A\u206B\u206F\u206E\u206B\u200B\u206E\u206C\u202D\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u206D\u206D\u200E\u200E\u202E\u206C\u200B\u206C\u206E\u202E\u206D\u206D\u200E\u202D\u202A\u200B\u206F\u206A\u200D\u202C\u206F\u202E\u200D\u206D\u202A\u200B\u200E\u206C\u200E\u206C\u200C\u200B\u200C\u206F\u200E\u206E\u200B\u206D\u202B\u200C\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u206F\u206B\u202D\u200F\u206F\u200E\u206B\u202C\u200E\u200D\u206C\u206E\u206F\u202D\u202D\u202C\u202A\u202B\u200F\u200B\u202B\u200B\u202C\u200E\u202C\u200D\u200C\u202B\u206C\u200D\u206C\u206B\u206E\u206E\u206B\u206A\u200C\u200C\u202E\u200E\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public bool ActiveUsed;
		}
	}
}
