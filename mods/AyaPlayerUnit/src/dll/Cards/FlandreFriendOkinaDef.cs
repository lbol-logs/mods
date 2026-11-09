using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using HarmonyLib;
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
	public sealed class FlandreFriendOkinaDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1842609461);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFriendOkinaDef.\u200C\u202C\u200D\u200D\u206F\u206A\u206A\u200E\u202C\u202B\u206C\u200C\u206E\u202A\u206D\u202E\u206C\u206B\u206F\u202B\u202D\u202C\u206E\u200F\u206D\u206E\u202A\u206F\u202C\u202D\u206C\u202B\u202B\u200D\u202B\u206C\u200F\u202D\u200D\u202E(BepinexPlugin.embeddedSource);
			FlandreFriendOkinaDef.\u206C\u206E\u200B\u202A\u200B\u200F\u206F\u200E\u202C\u200B\u202C\u206A\u206A\u206A\u202D\u206B\u206D\u202B\u202A\u200F\u200B\u206C\u200B\u206E\u200E\u206E\u202D\u202C\u200B\u202D\u206E\u202A\u202C\u202A\u200B\u202A\u206B\u206A\u206F\u206E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaDef.\u200C\u200F\u200D\u200E\u202A\u200D\u200D\u206B\u206E\u202D\u202C\u206F\u200D\u200D\u202C\u202E\u202C\u200F\u206B\u202E\u202C\u206D\u200B\u200E\u206E\u202D\u202B\u200B\u206C\u206C\u206E\u206E\u202A\u200C\u202B\u200B\u200D\u200D\u202A\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFriendOkinaDef.\u202D\u200B\u206B\u200E\u206B\u202E\u200C\u202E\u200E\u202C\u206B\u206B\u206A\u202C\u202A\u206E\u206F\u202C\u200B\u200C\u202A\u206F\u206E\u206F\u206C\u206A\u206E\u200C\u200E\u200B\u206E\u200F\u202B\u206A\u200F\u206D\u206D\u206E\u206B\u202E\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaDef.\u202D\u206A\u202C\u206A\u206D\u202A\u206E\u206C\u202A\u206D\u202A\u202D\u202C\u202D\u206F\u200D\u206C\u206F\u202E\u206B\u206F\u202D\u206F\u206D\u200E\u202B\u202C\u200F\u202D\u206C\u202D\u206D\u202C\u200D\u206C\u206B\u202D\u206C\u200B\u206B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
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
			}, null, null, null, null, null, null, null, null, new int?(18), null, new int?(4), null, new int?(4), null, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, new int?(1), null, new int?(2), null, new int?(-1), null, null, null, new int?(-6), null, Keyword.Replenish, Keyword.Replenish, false, Keyword.Shield | Keyword.Philosophy | Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, Keyword.Shield | Keyword.Philosophy | Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, new List<string>(), new List<string>(), new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-684053971),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(501936272),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(976094499),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1287554726)
			}, new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-684053971),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1500451830),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-291018997),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1287554726)
			}, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1572319366), new List<string>());
		}

		static CardImages \u200C\u202C\u200D\u200D\u206F\u206A\u206A\u200E\u202C\u202B\u206C\u200C\u206E\u202A\u206D\u202E\u206C\u206B\u206F\u202B\u202D\u202C\u206E\u200F\u206D\u206E\u202A\u206F\u202C\u202D\u206C\u202B\u202B\u200D\u202B\u206C\u200F\u202D\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u206E\u200B\u202A\u200B\u200F\u206F\u200E\u202C\u200B\u202C\u206A\u206A\u206A\u202D\u206B\u206D\u202B\u202A\u200F\u200B\u206C\u200B\u206E\u200E\u206E\u202D\u202C\u200B\u202D\u206E\u202A\u202C\u202A\u200B\u202A\u206B\u206A\u206F\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200C\u200F\u200D\u200E\u202A\u200D\u200D\u206B\u206E\u202D\u202C\u206F\u200D\u200D\u202C\u202E\u202C\u200F\u206B\u202E\u202C\u206D\u200B\u200E\u206E\u202D\u202B\u200B\u206C\u206C\u206E\u206E\u202A\u200C\u202B\u200B\u200D\u200D\u202A\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202D\u206A\u202C\u206A\u206D\u202A\u206E\u206C\u202A\u206D\u202A\u202D\u202C\u202D\u206F\u200D\u206C\u206F\u202E\u206B\u206F\u202D\u206F\u206D\u200E\u202B\u202C\u200F\u202D\u206C\u202D\u206D\u202C\u200D\u206C\u206B\u202D\u206C\u200B\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u200B\u206B\u200E\u206B\u202E\u200C\u202E\u200E\u202C\u206B\u206B\u206A\u202C\u202A\u206E\u206F\u202C\u200B\u200C\u202A\u206F\u206E\u206F\u206C\u206A\u206E\u200C\u200E\u200B\u206E\u200F\u202B\u206A\u200F\u206D\u206D\u206E\u206B\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaDef))]
		public sealed class FlandreFriendOkina : FlandreCard
		{
			public override bool RemoveFromBattleAfterPlay
			{
				get
				{
					return this.ActiveUsed;
				}
			}

			public override int AdditionalShield
			{
				get
				{
					return FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u206C\u202B\u202A\u202D\u202D\u200F\u206E\u200E\u200B\u206A\u200E\u200C\u200E\u200C\u202E\u202E\u206A\u206E\u202B\u206E\u200C\u206F\u206F\u200C\u200B\u206D\u206D\u200F\u202D\u202E\u206F\u200C\u202E\u206A\u202D\u202A\u202A\u206D\u206C\u202E(this).GetValueOrDefault() * 6;
				}
			}

			public int FlandrePassiveBarrier
			{
				get
				{
					return this.FlandreShield.Shield;
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(5 + FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u206C\u202B\u202A\u202D\u202D\u200F\u206E\u200E\u200B\u206A\u200E\u200C\u200E\u200C\u202E\u202E\u206A\u206E\u202B\u206E\u200C\u206F\u206F\u200C\u200B\u206D\u206D\u200F\u202D\u202E\u206F\u200C\u202E\u206A\u202D\u202A\u202A\u206D\u206C\u202E(this).GetValueOrDefault() * 5, true);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreFriendOkinaDef.FlandreFriendOkina.\u200E\u206D\u206C\u200B\u206C\u206E\u200E\u206C\u202C\u206C\u202C\u202A\u202C\u200E\u200E\u202C\u200C\u200B\u206A\u200B\u202D\u200B\u200D\u202A\u202D\u202B\u202E\u206A\u200D\u206D\u202A\u202C\u206B\u200F\u202E\u202B\u206A\u206E\u206D\u206B\u202E((float)FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u206C\u202B\u202A\u202D\u202D\u200F\u206E\u200E\u200B\u206A\u200E\u200C\u200E\u200C\u202E\u202E\u206A\u206E\u202B\u206E\u200C\u206F\u206F\u200C\u200B\u206D\u206D\u200F\u202D\u202E\u206F\u200C\u202E\u206A\u202D\u202A\u202A\u206D\u206C\u202E(this).GetValueOrDefault() / 2f)
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
							IL_007F:
							int num = (FlandreFriendOkinaDef.FlandreFriendOkina.\u206D\u206C\u206A\u200F\u206D\u206F\u206E\u200E\u206A\u202C\u202D\u202C\u200C\u206C\u206B\u206D\u200F\u200D\u200B\u206E\u202B\u202A\u206C\u202A\u202E\u200F\u206D\u206F\u200B\u200C\u202C\u206D\u202D\u202A\u200D\u202E\u206F\u206D\u202A\u200F\u202E(enumerator) ? (-528459501) : (-489010942));
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-(uint)(num2 - ~(--934606473 ^ (-874665651 * 1167269196))))) % 5U)
								{
								case 0U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 3831250266U) ^ 3677673319U);
									continue;
								}
								case 1U:
								{
									ManaColor manaColor = enumerator.Current;
									num = ((manaGroup.GetValue(manaColor) <= 0) ? 1081665011 : 91257080);
									continue;
								}
								case 3U:
									num = -528459501;
									continue;
								case 4U:
									goto IL_007F;
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
								int num4 = 943998659;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(-(uint)(num2 - ~(--934606473 ^ (-874665651 * 1167269196))))) % 3U)
									{
									case 0U:
										goto IL_00C6;
									case 1U:
										FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202C\u206E\u206B\u202D\u206D\u202C\u206D\u206B\u200E\u206F\u206C\u202D\u202E\u202A\u206A\u202C\u202E\u202B\u202B\u206E\u206A\u200C\u200B\u200C\u200C\u206C\u202B\u206E\u200F\u200C\u200D\u206D\u200B\u202B\u206C\u206E\u206B\u206C\u206D\u202E(enumerator);
										num4 = (int)((num3 * 2324520584U) ^ 3593695192U);
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
				if (FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200B\u200D\u202A\u206D\u200D\u200D\u206E\u200F\u202D\u206A\u200C\u206C\u200F\u202E\u202A\u202A\u200E\u202A\u202C\u206B\u200B\u202A\u202D\u202C\u202B\u202A\u206C\u206F\u200B\u206E\u202D\u206A\u200D\u200F\u206F\u202B\u206C\u202D\u200E\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_0309;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text4;
					switch ((num3 = (uint)(-(num - (67304129 - 571434131 - 460194946) * -684083261 - -1505919229 * -875172837 * -371099979) * -1528102295)) % 39U)
					{
					case 0U:
					{
						object obj;
						text = (string)obj;
						num2 = -1297545434;
						continue;
					}
					case 1U:
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription2);
						num2 = (int)((num3 * 1836133783U) ^ 3327291855U);
						continue;
					case 2U:
						goto IL_035E;
					case 3U:
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription1);
						num2 = (int)((num3 * 2807623270U) ^ 482174977U);
						continue;
					case 4U:
						switch (FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u206D\u200E\u206F\u206F\u200C\u202A\u202E\u206B\u202C\u200D\u202E\u200F\u200F\u206F\u202C\u200F\u200C\u202B\u206D\u200E\u202B\u202B\u200B\u202B\u206A\u206E\u200E\u202C\u202C\u200F\u200D\u202E\u206C\u206B\u206E\u206F\u206A\u206A\u202A\u202E(this))
						{
						case FriendToken.None:
							goto IL_032C;
						case FriendToken.Active:
							goto IL_019D;
						case FriendToken.Active2:
							goto IL_00F6;
						case FriendToken.Ultimate:
							goto IL_04EE;
						default:
							num2 = (int)((num3 * 999944561U) ^ 689803868U);
							continue;
						}
						break;
					case 5U:
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						num2 = (int)((num3 * 2933298728U) ^ 66481022U);
						continue;
					case 6U:
						goto IL_04EE;
					case 7U:
						text = base.RawExtraDescription1;
						num2 = -1297545434;
						continue;
					case 8U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -1105951809;
						continue;
					}
					case 9U:
						num2 = (int)((num3 * 580888786U) ^ 4076734888U);
						continue;
					case 10U:
						num2 = (base.HasExtraDescription3 ? 860927635 : (-1297545434));
						continue;
					case 11U:
					{
						object obj = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription;
						num2 = ((obj != null) ? (-1105951809) : (-1255757508));
						continue;
					}
					case 12U:
						goto IL_04D5;
					case 13U:
						num2 = (int)((num3 * 4271208565U) ^ 1899309485U);
						continue;
					case 14U:
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription3);
						num2 = (int)((num3 * 4163466458U) ^ 4022139527U);
						continue;
					case 15U:
						goto IL_00F6;
					case 16U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -626744412;
						continue;
					}
					case 17U:
						text = base.RawExtraDescription2;
						num2 = -545785010;
						continue;
					case 18U:
						goto IL_019D;
					case 19U:
						num2 = (base.HasExtraDescription1 ? 1561335131 : 1114560757);
						continue;
					case 20U:
						num2 = (int)((num3 * 3802135984U) ^ 2432956201U);
						continue;
					case 21U:
						num2 = ((FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202A\u206E\u202A\u200B\u202D\u206C\u200C\u206D\u206A\u200E\u202B\u200B\u206B\u202D\u202C\u206D\u206C\u206A\u200D\u206E\u200B\u202D\u206C\u206E\u206B\u202E\u202D\u206A\u200E\u206A\u206A\u202C\u206E\u206B\u200F\u200E\u206C\u202A\u202B\u202E(this) == null) ? (-2072020455) : (-1415781903));
						continue;
					case 22U:
						num2 = (int)((num3 * 3718392199U) ^ 1059707524U);
						continue;
					case 24U:
					{
						int num4 = FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202D\u200B\u200D\u202E\u202A\u206B\u200D\u206B\u200F\u202A\u200F\u206B\u202B\u202C\u206D\u202A\u206E\u206C\u202B\u200E\u206C\u206D\u206D\u202D\u202A\u200B\u206B\u206D\u202B\u202B\u206B\u202E\u200D\u202C\u202A\u200B\u200F\u206C\u200E\u202E(this);
						num2 = 1411509338;
						continue;
					}
					case 25U:
						num2 = ((!FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u200E\u200D\u200B\u200D\u206E\u206F\u200B\u206F\u202D\u200D\u206E\u206F\u206E\u200B\u200C\u206A\u202D\u206B\u206C\u206C\u206C\u202B\u206A\u202A\u200B\u202B\u206E\u202A\u202E\u200E\u206C\u200E\u206A\u200B\u200B\u202D\u206E\u200C\u206B\u202E(this)) ? 669584308 : 1416635049);
						continue;
					case 26U:
						num2 = (int)(((FlandreFriendOkinaDef.FlandreFriendOkina.\u206C\u200D\u206B\u200D\u202A\u200E\u200B\u206B\u202A\u206F\u202D\u206F\u206B\u200D\u200C\u202C\u206E\u206C\u206D\u202D\u200E\u200D\u200E\u206B\u202A\u202E\u200B\u206D\u200B\u202B\u202D\u206B\u202B\u206F\u206B\u200D\u206C\u206B\u202C\u206D\u202E(this) == CardType.Friend) ? 614314357U : 172856358U) ^ (num3 * 215025300U));
						continue;
					case 27U:
					{
						string text2 = text;
						string text3;
						if (FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202A\u206E\u202A\u200B\u202D\u206C\u200C\u206D\u206A\u200E\u202B\u200B\u206B\u202D\u202C\u206D\u206C\u206A\u200D\u206E\u200B\u202D\u206C\u206E\u206B\u202E\u202D\u206A\u200E\u206A\u206A\u202C\u206E\u206B\u200F\u200E\u206C\u202A\u202B\u202E(this) == null)
						{
							if (!FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u200E\u200D\u200B\u200D\u206E\u206F\u200B\u206F\u202D\u200D\u206E\u206F\u206E\u200B\u200C\u206A\u202D\u206B\u206C\u206C\u206C\u202B\u206A\u202A\u200B\u202B\u206E\u202A\u202E\u200E\u206C\u200E\u206A\u200B\u200B\u202D\u206E\u200C\u206B\u202E(this))
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
							text3 = (FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u200E\u200D\u200B\u200D\u206E\u206F\u200B\u206F\u202D\u200D\u206E\u206F\u206E\u200B\u200C\u206A\u202D\u206B\u206C\u206C\u206C\u202B\u206A\u202A\u200B\u202B\u206E\u202A\u202E\u200E\u206C\u200E\u206A\u200B\u200B\u202D\u206E\u200C\u206B\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						}
						text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text2, text3);
						num2 = 962195364;
						continue;
					}
					case 28U:
						goto IL_032C;
					case 29U:
						num2 = (int)((num3 * 628771529U) ^ 164040601U);
						continue;
					case 30U:
						num2 = ((!base.HasExtraDescription2) ? (-625466470) : (-1792446357));
						continue;
					case 31U:
						num2 = (int)((num3 * 3850890262U) ^ 3547932594U);
						continue;
					case 32U:
						num2 = (int)((num3 * 1416167195U) ^ 3438800775U);
						continue;
					case 33U:
						goto IL_0010;
					case 34U:
						if (!FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u200E\u200D\u200B\u200D\u206E\u206F\u200B\u206F\u202D\u200D\u206E\u206F\u206E\u200B\u200C\u206A\u202D\u206B\u206C\u206C\u206C\u202B\u206A\u202A\u200B\u202B\u206E\u202A\u202E\u200E\u206C\u200E\u206A\u200B\u200B\u202D\u206E\u200C\u206B\u202E(this))
						{
							num2 = (int)((num3 * 3562482014U) ^ 1822631009U);
							continue;
						}
						text4 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_01F0;
					case 35U:
					{
						int num4;
						num2 = (int)(((num4 != 1) ? 3237311593U : 2997992464U) ^ (num3 * 3986437322U));
						continue;
					}
					case 36U:
						goto IL_0309;
					case 37U:
						text4 = base.BaseDescription;
						goto IL_01F0;
					case 38U:
					{
						int num4;
						num2 = (int)(((num4 != 2) ? 1536509513U : 2941070947U) ^ (num3 * 3935761388U));
						continue;
					}
					}
					break;
					IL_00F6:
					text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription2);
					num2 = -1297545434;
					continue;
					IL_019D:
					text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription1);
					num2 = -1297545434;
					continue;
					IL_01F0:
					text = text4;
					num2 = -1406811110;
					continue;
					IL_032C:
					num2 = ((!FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200B\u200D\u202A\u206D\u200D\u200D\u206E\u200F\u202D\u206A\u200C\u206C\u200F\u202E\u202A\u202A\u200E\u202A\u202C\u206B\u200B\u202A\u202D\u202C\u202B\u202A\u206C\u206F\u200B\u206E\u202D\u206A\u200D\u200F\u206F\u202B\u206C\u202D\u200E\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(this))) ? 1361019967 : 962195364);
					continue;
					IL_04EE:
					text = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(text, base.RawExtraDescription3);
					num2 = -1879527134;
				}
				goto IL_053C;
				IL_035E:
				throw FlandreFriendOkinaDef.FlandreFriendOkina.\u200E\u202E\u202B\u200B\u202E\u200C\u202D\u200E\u206F\u202A\u200D\u206D\u202A\u200C\u206B\u200F\u202E\u206A\u200C\u202E\u202A\u202E\u200C\u200C\u202D\u200F\u202D\u206D\u206D\u202B\u202E\u200F\u202B\u200D\u202A\u206A\u200C\u200F\u202A\u202C\u202E();
				IL_04D5:
				return string.Empty;
				IL_053C:
				return base.FollowByDetailIcon(text);
				IL_0010:
				num2 = 705152995;
				goto IL_0015;
				IL_0309:
				text = string.Empty;
				num2 = -261650306;
				goto IL_0015;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreFriendOkinaDef.FlandreFriendOkina.<EnumerateRelativeCards>d__14 <EnumerateRelativeCards>d__ = new FlandreFriendOkinaDef.FlandreFriendOkina.<EnumerateRelativeCards>d__14(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.Amount = FlandreFriendOkinaDef.FlandreFriendOkina.\u202D\u206A\u206B\u206F\u200D\u206D\u206D\u206C\u200C\u200E\u200B\u200D\u200E\u206F\u206E\u202C\u206B\u206F\u206E\u202D\u206C\u202E\u202C\u206E\u202C\u202E\u200D\u206C\u206D\u200C\u206F\u202A\u202E\u206C\u200C\u200D\u202B\u200C\u206D\u206F\u202E(this);
				for (;;)
				{
					IL_000C:
					int num = 1543111648;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(1300211076 - (~1334101208 - (num2 - (1449739822 ^ ((-1853116794 + -2082016025) ^ 1145690017))) * 904619923))) % 3U)
						{
						case 0U:
							goto IL_000C;
						case 2U:
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaDef.FlandreFriendOkina.\u206D\u200B\u202A\u206A\u202E\u206B\u202E\u200F\u200F\u206C\u200D\u200B\u202E\u202E\u202A\u206B\u202E\u202B\u206C\u206C\u202D\u202B\u206B\u200B\u200C\u202A\u206E\u206F\u200D\u202C\u206A\u200E\u206D\u202C\u202E\u206F\u202A\u206C\u206A\u202E\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202A\u206E\u202A\u200B\u202D\u206C\u200C\u206D\u206A\u200E\u202B\u200B\u206B\u202D\u202C\u206D\u206C\u206A\u200D\u206E\u200B\u202D\u206C\u206E\u206B\u202E\u202D\u206A\u200E\u206A\u206A\u202C\u206E\u206B\u200F\u200E\u206C\u202A\u202B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u200C\u206D\u202D\u200D\u202E\u206F\u202D\u206B\u200C\u200C\u202C\u202D\u206E\u200F\u200D\u200B\u206E\u206F\u206C\u206C\u206B\u200C\u200C\u202C\u202D\u206E\u202D\u200C\u200B\u200E\u200D\u206E\u200E\u202A\u202E\u200C\u206B\u200D\u200C\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202A\u206E\u202A\u200B\u202D\u206C\u200C\u206D\u206A\u200E\u202B\u200B\u206B\u202D\u202C\u206D\u206C\u206A\u200D\u206E\u200B\u202D\u206C\u206E\u206B\u202E\u202D\u206A\u200E\u206A\u206A\u202C\u206E\u206B\u200F\u200E\u206C\u202A\u202B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 1791618389U) ^ 2024172383U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreFriendOkinaDef.FlandreFriendOkina.<OnCardUsed>d__16 <OnCardUsed>d__ = new FlandreFriendOkinaDef.FlandreFriendOkina.<OnCardUsed>d__16(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				FlandreFriendOkinaDef.FlandreFriendOkina.<GetPassiveActions>d__17 <GetPassiveActions>d__ = new FlandreFriendOkinaDef.FlandreFriendOkina.<GetPassiveActions>d__17(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (FlandreFriendOkinaDef.FlandreFriendOkina.\u206C\u200D\u206B\u200D\u202A\u200E\u200B\u206B\u202A\u206F\u202D\u206F\u206B\u200D\u200C\u202C\u206E\u206C\u206D\u202D\u200E\u200D\u200E\u206B\u202A\u202E\u200B\u206D\u200B\u202B\u202D\u206B\u202B\u206F\u206B\u200D\u206C\u206B\u202C\u206D\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list;
					for (;;)
					{
						IL_000C:
						int num = -1886995033;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~num2 ^ ~(~1251633222)) - 1476120674)) % 18U)
							{
							case 1U:
								num = (int)((this.ActiveUsed ? 2255442296U : 4076848434U) ^ (num3 * 820931548U));
								continue;
							case 2U:
								if (FlandreFriendOkinaDef.FlandreFriendOkina.\u202C\u200F\u206A\u202B\u206A\u200E\u206C\u206C\u206A\u200D\u206C\u206C\u200C\u200B\u206B\u200D\u200D\u202B\u206E\u206B\u202A\u206A\u202C\u206D\u206A\u200B\u206B\u206F\u202C\u202E\u202B\u200D\u202E\u202A\u200D\u200B\u200C\u206E\u206D\u206C\u202E(this))
								{
									num = (int)((num3 * 1194339119U) ^ 3222031271U);
									continue;
								}
								goto IL_037D;
							case 3U:
							{
								int? num4 = FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u206D\u202C\u206E\u200C\u202E\u206C\u200C\u202B\u200D\u202C\u206E\u202B\u200D\u206D\u206D\u206F\u206F\u206F\u202D\u200F\u206E\u202D\u200C\u202A\u206D\u200B\u200D\u200E\u206C\u206D\u206E\u206B\u202C\u206F\u200D\u206C\u206A\u200C\u206E\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(this));
								num = -1040410707;
								continue;
							}
							case 4U:
								list = new List<FriendToken>();
								num = (int)((num3 * 2804349344U) ^ 3286632262U);
								continue;
							case 5U:
								num = (int)(((FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u200E\u202B\u206B\u202B\u206E\u202B\u206E\u206C\u206B\u200B\u200F\u202E\u200C\u202E\u200F\u202A\u206A\u200D\u200C\u206F\u202B\u202D\u206A\u200F\u206C\u200B\u200D\u200E\u200C\u200B\u202D\u200C\u206D\u206A\u202C\u206D\u200F\u206E\u200F\u202E(this) >= -FlandreFriendOkinaDef.FlandreFriendOkina.\u200F\u206F\u202B\u206C\u206E\u200B\u202E\u202B\u202A\u200B\u200B\u202E\u206B\u200F\u200F\u200C\u202A\u202D\u200F\u206B\u202C\u206D\u200B\u202B\u200D\u202A\u206B\u202D\u206A\u206F\u202E\u206D\u200D\u206F\u206D\u202A\u206F\u206D\u206B\u202D\u202E(this)) ? 2858569412U : 1449606187U) ^ (num3 * 1178543190U));
								continue;
							case 6U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 3076857529U : 3148915612U) ^ (num3 * 4223624544U));
								continue;
							}
							case 7U:
							{
								int? num4 = FlandreFriendOkinaDef.FlandreFriendOkina.\u206D\u206A\u206D\u206A\u202E\u206F\u202B\u200F\u206A\u200D\u202B\u200C\u202D\u200D\u206A\u200C\u202C\u206C\u202E\u202A\u200B\u200E\u206B\u200D\u206D\u206D\u200E\u200B\u202A\u200D\u200F\u206C\u200B\u202A\u206B\u202E\u206D\u200B\u206A\u200C\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(this));
								num = 909295475;
								continue;
							}
							case 8U:
								num = (int)(((FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u200E\u202B\u206B\u202B\u206E\u202B\u206E\u206C\u206B\u200B\u200F\u202E\u200C\u202E\u200F\u202A\u206A\u200D\u200C\u206F\u202B\u202D\u206A\u200F\u206C\u200B\u200D\u200E\u200C\u200B\u202D\u200C\u206D\u206A\u202C\u206D\u200F\u206E\u200F\u202E(this) >= -FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u202B\u206A\u206D\u206B\u200F\u206F\u200E\u200E\u206E\u202D\u206A\u202C\u206C\u202E\u206B\u200B\u202D\u206D\u206D\u200B\u202E\u200C\u206E\u202A\u200D\u202D\u200F\u206C\u206A\u206C\u200F\u202C\u206E\u200E\u200E\u200F\u200F\u200D\u206B\u202E(this)) ? 1465367532U : 2295838866U) ^ (num3 * 3053058825U));
								continue;
							case 9U:
								list.Add(FriendToken.Ultimate);
								num = (int)((num3 * 3954616184U) ^ 2942175721U);
								continue;
							case 10U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 3418954380U : 3366979291U) ^ (num3 * 2223544857U));
								continue;
							}
							case 11U:
								list.Add(FriendToken.Active2);
								num = (int)((num3 * 1339692416U) ^ 3887558778U);
								continue;
							case 12U:
								if (FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u200E\u202B\u206B\u202B\u206E\u202B\u206E\u206C\u206B\u200B\u200F\u202E\u200C\u202E\u200F\u202A\u206A\u200D\u200C\u206F\u202B\u202D\u206A\u200F\u206C\u200B\u200D\u200E\u200C\u200B\u202D\u200C\u206D\u206A\u202C\u206D\u200F\u206E\u200F\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 3951776300U) ^ 703017133U);
									continue;
								}
								goto IL_037D;
							case 13U:
							{
								int? num4 = FlandreFriendOkinaDef.FlandreFriendOkina.\u200E\u202A\u202E\u206D\u200B\u200E\u200C\u202E\u202D\u200E\u206D\u202C\u200E\u200C\u200D\u206A\u202E\u202D\u202B\u200F\u200E\u206F\u206D\u200F\u206D\u202A\u206E\u202C\u200D\u206E\u200D\u202B\u200F\u202A\u200B\u202E\u202D\u200D\u202D\u206B\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(this));
								num = (int)((num3 * 1412757330U) ^ 4106975871U);
								continue;
							}
							case 14U:
								goto IL_000C;
							case 15U:
								num = (int)(((FlandreFriendOkinaDef.FlandreFriendOkina.\u202B\u200E\u202B\u206B\u202B\u206E\u202B\u206E\u206C\u206B\u200B\u200F\u202E\u200C\u202E\u200F\u202A\u206A\u200D\u200C\u206F\u202B\u202D\u206A\u200F\u206C\u200B\u200D\u200E\u200C\u200B\u202D\u200C\u206D\u206A\u202C\u206D\u200F\u206E\u200F\u202E(this) >= -FlandreFriendOkinaDef.FlandreFriendOkina.\u206A\u200D\u200F\u200C\u206C\u206E\u206B\u202C\u202B\u206A\u202C\u200F\u206A\u206A\u206A\u200B\u200B\u200F\u206D\u200E\u206F\u202E\u200C\u206D\u200B\u202C\u202C\u200F\u200D\u202A\u202C\u206A\u206D\u202E\u202A\u202C\u206E\u202D\u206F\u206D\u202E(this)) ? 4041579546U : 4155505202U) ^ (num3 * 3582659240U));
								continue;
							case 16U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 3776277942U : 772073052U) ^ (num3 * 3904028647U));
								continue;
							}
							case 17U:
								list.Add(FriendToken.Active);
								num = (int)((num3 * 908620448U) ^ 2450278972U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					List<Card> list2 = FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u206F\u202A\u202C\u200B\u206E\u202B\u200F\u206A\u200D\u202B\u202B\u206D\u202C\u206A\u200D\u200D\u200F\u200B\u202B\u200D\u206C\u202D\u200B\u206B\u202C\u206A\u200E\u202D\u206D\u206F\u202A\u200D\u200F\u206A\u206A\u202A\u202C\u206D\u202A\u202E(this, list.Count, false).ToList<Card>();
					IEnumerator<ValueTuple<int, FriendToken>> enumerator = list.WithIndices<FriendToken>().GetEnumerator();
					try
					{
						for (;;)
						{
							IL_030D:
							int num5 = ((!FlandreFriendOkinaDef.FlandreFriendOkina.\u206D\u206C\u206A\u200F\u206D\u206F\u206E\u200E\u206A\u202C\u202D\u202C\u200C\u206C\u206B\u206D\u200F\u200D\u200B\u206E\u202B\u202A\u206C\u202A\u202E\u200F\u206D\u206F\u200B\u200C\u202C\u206D\u202D\u202A\u200D\u202E\u206F\u206D\u202A\u200F\u202E(enumerator)) ? 682100405 : (-824586852));
							for (;;)
							{
								int num2 = num5;
								switch ((-(~num2 ^ ~(~1251633222)) - 1476120674) % 4)
								{
								case 0:
									num5 = -824586852;
									continue;
								case 1:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									FlandreFriendOkinaDef.FlandreFriendOkina.\u202E\u202E\u200C\u200D\u200C\u206D\u206C\u202C\u202D\u206E\u200C\u206C\u206A\u202C\u206A\u206B\u206F\u202E\u200C\u202E\u202E\u200F\u202C\u206C\u200F\u206A\u206C\u206B\u206E\u202B\u200F\u200B\u202E\u206D\u206C\u200E\u200D\u206B\u200B\u206B\u202E(list2[item], item2);
									num5 = -2059794014;
									continue;
								}
								case 3:
									goto IL_030D;
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
								IL_032B:
								int num6 = -735798163;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(-(~num2 ^ ~(~1251633222)) - 1476120674)) % 3U)
									{
									case 0U:
										goto IL_032B;
									case 1U:
										FlandreFriendOkinaDef.FlandreFriendOkina.\u206E\u202C\u206E\u206B\u202D\u206D\u202C\u206D\u206B\u200E\u206F\u206C\u202D\u202E\u202A\u206A\u202C\u202E\u202B\u202B\u206E\u206A\u200C\u200B\u200C\u200C\u206C\u202B\u206E\u200F\u200C\u200D\u206D\u200B\u202B\u206C\u206E\u206B\u206C\u206D\u202E(enumerator);
										num6 = (int)((num3 * 17328352U) ^ 3306050046U);
										continue;
									}
									goto Block_16;
								}
							}
							Block_16:;
						}
					}
					return FlandreFriendOkinaDef.FlandreFriendOkina.\u200B\u206C\u200F\u202C\u200C\u206B\u206C\u202C\u200B\u206F\u206F\u202C\u202B\u202B\u200D\u202B\u202B\u200B\u200B\u206A\u202A\u206B\u206B\u200B\u202A\u200F\u202E\u202C\u202D\u206B\u200B\u202D\u206C\u206B\u200C\u206D\u200D\u206B\u206F\u206D\u202E(list2, false, false, false);
				}
				IL_037D:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFriendOkinaDef.FlandreFriendOkina.<Actions>d__20 <Actions>d__ = new FlandreFriendOkinaDef.FlandreFriendOkina.<Actions>d__20(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreFriendOkinaDef.FlandreFriendOkina.<AfterUseAction>d__21 <AfterUseAction>d__ = new FlandreFriendOkinaDef.FlandreFriendOkina.<AfterUseAction>d__21(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static int? \u202D\u206C\u202B\u202A\u202D\u202D\u200F\u206E\u200E\u200B\u206A\u200E\u200C\u200E\u200C\u202E\u202E\u206A\u206E\u202B\u206E\u200C\u206F\u206F\u200C\u200B\u206D\u206D\u200F\u202D\u202E\u206F\u200C\u202E\u206A\u202D\u202A\u202A\u206D\u206C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200E\u206D\u206C\u200B\u206C\u206E\u200E\u206C\u202C\u206C\u202C\u202A\u202C\u200E\u200E\u202C\u200C\u200B\u206A\u200B\u202D\u200B\u200D\u202A\u202D\u202B\u202E\u206A\u200D\u206D\u202A\u202C\u206B\u200F\u202E\u202B\u206A\u206E\u206D\u206B\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206D\u206C\u206A\u200F\u206D\u206F\u206E\u200E\u206A\u202C\u202D\u202C\u200C\u206C\u206B\u206D\u200F\u200D\u200B\u206E\u202B\u202A\u206C\u202A\u202E\u200F\u206D\u206F\u200B\u200C\u202C\u206D\u202D\u202A\u200D\u202E\u206F\u206D\u202A\u200F\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u202C\u206E\u206B\u202D\u206D\u202C\u206D\u206B\u200E\u206F\u206C\u202D\u202E\u202A\u206A\u202C\u202E\u202B\u202B\u206E\u206A\u200C\u200B\u200C\u200C\u206C\u202B\u206E\u200F\u200C\u200D\u206D\u200B\u202B\u206C\u206E\u206B\u206C\u206D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static CardConfig \u206A\u200C\u200F\u202C\u200C\u202B\u206D\u202E\u206A\u200F\u206A\u206F\u200C\u200B\u202C\u202A\u206F\u200D\u202C\u200D\u202A\u202C\u200B\u202D\u206D\u200B\u200B\u202D\u200D\u202B\u206D\u200D\u200C\u200B\u202C\u206C\u202D\u200E\u206F\u200F\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u206A\u200B\u200D\u202A\u206D\u200D\u200D\u206E\u200F\u202D\u206A\u200C\u206C\u200F\u202E\u202A\u202A\u200E\u202A\u202C\u206B\u200B\u202A\u202D\u202C\u202B\u202A\u206C\u206F\u200B\u206E\u202D\u206A\u200D\u200F\u206F\u202B\u206C\u202D\u200E\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u206C\u200D\u206B\u200D\u202A\u200E\u200B\u206B\u202A\u206F\u202D\u206F\u206B\u200D\u200C\u202C\u206E\u206C\u206D\u202D\u200E\u200D\u200E\u206B\u202A\u202E\u200B\u206D\u200B\u202B\u202D\u206B\u202B\u206F\u206B\u200D\u206C\u206B\u202C\u206D\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u202B\u206D\u200E\u206F\u206F\u200C\u202A\u202E\u206B\u202C\u200D\u202E\u200F\u200F\u206F\u202C\u200F\u200C\u202B\u206D\u200E\u202B\u202B\u200B\u202B\u206A\u206E\u200E\u202C\u202C\u200F\u200D\u202E\u206C\u206B\u206E\u206F\u206A\u206A\u202A\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static BattleController \u206E\u202A\u206E\u202A\u200B\u202D\u206C\u200C\u206D\u206A\u200E\u202B\u200B\u206B\u202D\u202C\u206D\u206C\u206A\u200D\u206E\u200B\u202D\u206C\u206E\u206B\u202E\u202D\u206A\u200E\u206A\u206A\u202C\u206E\u206B\u200F\u200E\u206C\u202A\u202B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202D\u200E\u200D\u200B\u200D\u206E\u206F\u200B\u206F\u202D\u200D\u206E\u206F\u206E\u200B\u200C\u206A\u202D\u206B\u206C\u206C\u206C\u202B\u206A\u202A\u200B\u202B\u206E\u202A\u202E\u200E\u206C\u200E\u206A\u200B\u200B\u202D\u206E\u200C\u206B\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u202E\u206A\u200C\u206A\u206D\u206B\u206E\u200C\u206B\u206C\u200C\u200B\u206E\u200D\u202B\u206C\u202A\u202A\u200D\u206D\u200F\u206A\u200B\u200E\u206C\u206E\u206C\u200E\u202E\u206D\u200E\u202A\u202C\u206B\u202E\u202D\u202C\u200E\u206A\u200C\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u200E\u202E\u202B\u200B\u202E\u200C\u202D\u200E\u206F\u202A\u200D\u206D\u202A\u200C\u206B\u200F\u202E\u206A\u200C\u202E\u202A\u202E\u200C\u200C\u202D\u200F\u202D\u206D\u206D\u202B\u202E\u200F\u202B\u200D\u202A\u206A\u200C\u200F\u202A\u202C\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u206E\u202D\u200B\u200D\u202E\u202A\u206B\u200D\u206B\u200F\u202A\u200F\u206B\u202B\u202C\u206D\u202A\u206E\u206C\u202B\u200E\u206C\u206D\u206D\u202D\u202A\u200B\u206B\u206D\u202B\u202B\u206B\u202E\u200D\u202C\u202A\u200B\u200F\u206C\u200E\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static int \u202D\u206A\u206B\u206F\u200D\u206D\u206D\u206C\u200C\u200E\u200B\u200D\u200E\u206F\u206E\u202C\u206B\u206F\u206E\u202D\u206C\u202E\u202C\u206E\u202C\u202E\u200D\u206C\u206D\u200C\u206F\u202A\u202E\u206C\u200C\u200D\u202B\u200C\u206D\u206F\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameEvent<CardUsingEventArgs> \u206D\u200B\u202A\u206A\u202E\u206B\u202E\u200F\u200F\u206C\u200D\u200B\u202E\u202E\u202A\u206B\u202E\u202B\u206C\u206C\u202D\u202B\u206B\u200B\u200C\u202A\u206E\u206F\u200D\u202C\u206A\u200E\u206D\u202C\u202E\u206F\u202A\u206C\u206A\u202E\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u206E\u200C\u206D\u202D\u200D\u202E\u206F\u202D\u206B\u200C\u200C\u202C\u202D\u206E\u200F\u200D\u200B\u206E\u206F\u206C\u206C\u206B\u200C\u200C\u202C\u202D\u206E\u202D\u200C\u200B\u200E\u200D\u206E\u200E\u202A\u202E\u200C\u206B\u200D\u200C\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u202C\u200F\u206A\u202B\u206A\u200E\u206C\u206C\u206A\u200D\u206C\u206C\u200C\u200B\u206B\u200D\u200D\u202B\u206E\u206B\u202A\u206A\u202C\u206D\u206A\u200B\u206B\u206F\u202C\u202E\u202B\u200D\u202E\u202A\u200D\u200B\u200C\u206E\u206D\u206C\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202B\u200E\u202B\u206B\u202B\u206E\u202B\u206E\u206C\u206B\u200B\u200F\u202E\u200C\u202E\u200F\u202A\u206A\u200D\u200C\u206F\u202B\u202D\u206A\u200F\u206C\u200B\u200D\u200E\u200C\u200B\u202D\u200C\u206D\u206A\u202C\u206D\u200F\u206E\u200F\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u200E\u202A\u202E\u206D\u200B\u200E\u200C\u202E\u202D\u200E\u206D\u202C\u200E\u200C\u200D\u206A\u202E\u202D\u202B\u200F\u200E\u206F\u206D\u200F\u206D\u202A\u206E\u202C\u200D\u206E\u200D\u202B\u200F\u202A\u200B\u202E\u202D\u200D\u202D\u206B\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206A\u202B\u206A\u206D\u206B\u200F\u206F\u200E\u200E\u206E\u202D\u206A\u202C\u206C\u202E\u206B\u200B\u202D\u206D\u206D\u200B\u202E\u200C\u206E\u202A\u200D\u202D\u200F\u206C\u206A\u206C\u200F\u202C\u206E\u200E\u200E\u200F\u200F\u200D\u206B\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u206D\u206A\u206D\u206A\u202E\u206F\u202B\u200F\u206A\u200D\u202B\u200C\u202D\u200D\u206A\u200C\u202C\u206C\u202E\u202A\u200B\u200E\u206B\u200D\u206D\u206D\u200E\u200B\u202A\u200D\u200F\u206C\u200B\u202A\u206B\u202E\u206D\u200B\u206A\u200C\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u206A\u200D\u200F\u200C\u206C\u206E\u206B\u202C\u202B\u206A\u202C\u200F\u206A\u206A\u206A\u200B\u200B\u200F\u206D\u200E\u206F\u202E\u200C\u206D\u200B\u202C\u202C\u200F\u200D\u202A\u202C\u206A\u206D\u202E\u202A\u202C\u206E\u202D\u206F\u206D\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u202B\u206D\u202C\u206E\u200C\u202E\u206C\u200C\u202B\u200D\u202C\u206E\u202B\u200D\u206D\u206D\u206F\u206F\u206F\u202D\u200F\u206E\u202D\u200C\u202A\u206D\u200B\u200D\u200E\u206C\u206D\u206E\u206B\u202C\u206F\u200D\u206C\u206A\u200C\u206E\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u200F\u206F\u202B\u206C\u206E\u200B\u202E\u202B\u202A\u200B\u200B\u202E\u206B\u200F\u200F\u200C\u202A\u202D\u200F\u206B\u202C\u206D\u200B\u202B\u200D\u202A\u206B\u202D\u206A\u206F\u202E\u206D\u200D\u206F\u206D\u202A\u206F\u206D\u206B\u202D\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u202E\u206F\u202A\u202C\u200B\u206E\u202B\u200F\u206A\u200D\u202B\u202B\u206D\u202C\u206A\u200D\u200D\u200F\u200B\u202B\u200D\u206C\u202D\u200B\u206B\u202C\u206A\u200E\u202D\u206D\u206F\u202A\u200D\u200F\u206A\u206A\u202A\u202C\u206D\u202A\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u202E\u202E\u200C\u200D\u200C\u206D\u206C\u202C\u202D\u206E\u200C\u206C\u206A\u202C\u206A\u206B\u206F\u202E\u200C\u202E\u202E\u200F\u202C\u206C\u200F\u206A\u206C\u206B\u206E\u202B\u200F\u200B\u202E\u206D\u206C\u200E\u200D\u206B\u200B\u206B\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u200B\u206C\u200F\u202C\u200C\u206B\u206C\u202C\u200B\u206F\u206F\u202C\u202B\u202B\u200D\u202B\u202B\u200B\u200B\u206A\u202A\u206B\u206B\u200B\u202A\u200F\u202E\u202C\u202D\u206B\u200B\u202D\u206C\u206B\u200C\u206D\u200D\u206B\u206F\u206D\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public bool ActiveUsed;

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (FlandreFriendOkinaDef.FlandreFriendOkina.GameRunController_BaseCardWeight_Patch.\u202D\u202D\u200D\u206D\u206A\u206B\u206B\u202A\u200F\u200E\u206A\u202E\u206E\u200E\u202A\u206E\u200F\u200C\u202D\u206A\u202A\u206E\u202A\u202D\u200E\u202C\u202E\u202A\u206E\u202E\u200B\u206A\u200B\u206F\u202C\u206F\u202D\u202D\u202A\u200D\u202E(FlandreFriendOkinaDef.FlandreFriendOkina.GameRunController_BaseCardWeight_Patch.\u206E\u200C\u202D\u202B\u206C\u200E\u200E\u206D\u200F\u202E\u202A\u206B\u202C\u202B\u202B\u206B\u206C\u202E\u200C\u206F\u202C\u200B\u202C\u200E\u206D\u202B\u206C\u202E\u200C\u200B\u202D\u206B\u200F\u202C\u206C\u206E\u200E\u206A\u200B\u206C\u202E(config), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-920538409)))
					{
						for (;;)
						{
							IL_001A:
							int num = 996003181;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((-(-num2) ^ (366316468 - -318944780)) - -1303726438)) % 3U)
								{
								case 1U:
									__result *= 0.25f;
									num = (int)((num3 * 3654007231U) ^ 636881445U);
									continue;
								case 2U:
									goto IL_001A;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u206E\u200C\u202D\u202B\u206C\u200E\u200E\u206D\u200F\u202E\u202A\u206B\u202C\u202B\u202B\u206B\u206C\u202E\u200C\u206F\u202C\u200B\u202C\u200E\u206D\u202B\u206C\u202E\u200C\u200B\u202D\u206B\u200F\u202C\u206C\u206E\u200E\u206A\u200B\u206C\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u202D\u202D\u200D\u206D\u206A\u206B\u206B\u202A\u200F\u200E\u206A\u202E\u206E\u200E\u202A\u206E\u200F\u200C\u202D\u206A\u202A\u206E\u202A\u202D\u200E\u202C\u202E\u202A\u206E\u202E\u200B\u206A\u200B\u206F\u202C\u206F\u202D\u202D\u202A\u200D\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
