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
	public sealed class FlandreFriendOkinaWinterDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1287554726);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFriendOkinaWinterDef.\u202E\u202B\u200E\u202B\u206D\u202C\u206D\u202B\u206E\u202B\u206E\u206B\u206D\u202D\u202E\u206F\u200E\u206C\u202D\u202D\u202C\u202E\u202B\u202A\u202B\u202A\u206D\u200F\u200D\u202C\u206D\u206E\u202B\u202E\u206A\u206F\u200E\u200B\u202C\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreFriendOkinaWinterDef.\u206C\u206F\u202E\u206E\u206B\u206A\u200B\u206A\u202B\u206E\u200B\u206A\u206E\u202E\u202D\u206B\u202A\u202E\u206A\u206F\u206F\u200B\u200C\u200F\u202C\u206C\u202A\u202B\u200F\u202C\u206C\u206F\u202A\u206A\u202E\u206A\u206F\u200D\u200B\u202D\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaWinterDef.\u200D\u200C\u200D\u200C\u200F\u202B\u206D\u202D\u202A\u206C\u202E\u206C\u202A\u202A\u202B\u202D\u200E\u200E\u200E\u202E\u202D\u202A\u202D\u200F\u202A\u206B\u206E\u202C\u206B\u200C\u200C\u200E\u206F\u206C\u202E\u200E\u200C\u206B\u202D\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFriendOkinaWinterDef.\u200F\u202C\u200E\u202B\u206C\u200E\u200B\u200E\u206E\u200F\u206F\u200F\u206A\u202A\u206E\u206B\u206B\u206A\u206B\u200D\u202B\u206E\u202C\u200D\u200F\u202C\u206C\u200D\u200C\u202C\u202C\u200C\u206F\u200F\u206F\u202C\u206B\u200E\u202A\u206F\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaWinterDef.\u206B\u202D\u200F\u200D\u202A\u206F\u200E\u202B\u200E\u200C\u200B\u200E\u206C\u202A\u206F\u200C\u202A\u206F\u202B\u200B\u202C\u202D\u202B\u200D\u206F\u200D\u202D\u202D\u200C\u206B\u206E\u206D\u202B\u202B\u206B\u206C\u202B\u206E\u202E\u206F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, false, true, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
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
			}, null, null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(3), null, null, null, null, null, null, new int?(1), null, new int?(2), null, new int?(-1), null, null, null, new int?(-6), null, Keyword.Replenish, Keyword.Replenish, false, Keyword.Philosophy, Keyword.Philosophy, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1958891809),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(868977057)
			}, new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(462619751),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1073233309)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1798980804),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-757816751),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-779712900),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-920538409)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1798980804),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-589528885),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1316928722),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1842609461)
			}, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1229141207), new List<string>());
		}

		static CardImages \u202E\u202B\u200E\u202B\u206D\u202C\u206D\u202B\u206E\u202B\u206E\u206B\u206D\u202D\u202E\u206F\u200E\u206C\u202D\u202D\u202C\u202E\u202B\u202A\u202B\u202A\u206D\u200F\u200D\u202C\u206D\u206E\u202B\u202E\u206A\u206F\u200E\u200B\u202C\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u206F\u202E\u206E\u206B\u206A\u200B\u206A\u202B\u206E\u200B\u206A\u206E\u202E\u202D\u206B\u202A\u202E\u206A\u206F\u206F\u200B\u200C\u200F\u202C\u206C\u202A\u202B\u200F\u202C\u206C\u206F\u202A\u206A\u202E\u206A\u206F\u200D\u200B\u202D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u200C\u200D\u200C\u200F\u202B\u206D\u202D\u202A\u206C\u202E\u206C\u202A\u202A\u202B\u202D\u200E\u200E\u200E\u202E\u202D\u202A\u202D\u200F\u202A\u206B\u206E\u202C\u206B\u200C\u200C\u200E\u206F\u206C\u202E\u200E\u200C\u206B\u202D\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u202D\u200F\u200D\u202A\u206F\u200E\u202B\u200E\u200C\u200B\u200E\u206C\u202A\u206F\u200C\u202A\u206F\u202B\u200B\u202C\u202D\u202B\u200D\u206F\u200D\u202D\u202D\u200C\u206B\u206E\u206D\u202B\u202B\u206B\u206C\u202B\u206E\u202E\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u202C\u200E\u202B\u206C\u200E\u200B\u200E\u206E\u200F\u206F\u200F\u206A\u202A\u206E\u206B\u206B\u206A\u206B\u200D\u202B\u206E\u202C\u200D\u200F\u202C\u206C\u200D\u200C\u202C\u202C\u200C\u206F\u200F\u206F\u202C\u206B\u200E\u202A\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaWinterDef))]
		public sealed class FlandreFriendOkinaWinter : FlandreCard
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
					return FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200B\u206A\u200E\u200E\u206F\u206A\u206E\u206C\u202E\u200B\u202D\u200F\u206F\u200C\u206A\u202B\u202D\u202A\u202A\u200B\u206D\u206F\u202E\u202E\u206C\u200C\u206A\u200C\u206F\u200E\u200C\u202B\u202C\u202E\u200D\u200F\u206D\u206B\u202D\u200D\u202E(this).GetValueOrDefault();
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
					return base.FlandreModifier(1 + FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206F\u200E\u206A\u206C\u202A\u200C\u206F\u200B\u206B\u206C\u206F\u206E\u202E\u206D\u200F\u206E\u206C\u206E\u202C\u206D\u200B\u200F\u202E\u200F\u200E\u206D\u200E\u206B\u206C\u202A\u206E\u202E\u202B\u202C\u206B\u200C\u202E\u200B\u206A\u200F\u202E((float)FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200B\u206A\u200E\u200E\u206F\u206A\u206E\u206C\u202E\u200B\u202D\u200F\u206F\u200C\u206A\u202B\u202D\u202A\u202A\u200B\u206D\u206F\u202E\u202E\u206C\u200C\u206A\u200C\u206F\u200E\u200C\u202B\u202C\u202E\u200D\u200F\u206D\u206B\u202D\u200D\u202E(this).GetValueOrDefault() / 2f), false);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206F\u200E\u206A\u206C\u202A\u200C\u206F\u200B\u206B\u206C\u206F\u206E\u202E\u206D\u200F\u206E\u206C\u206E\u202C\u206D\u200B\u200F\u202E\u200F\u200E\u206D\u200E\u206B\u206C\u202A\u206E\u202E\u202B\u202C\u206B\u200C\u202E\u200B\u206A\u200F\u202E((float)FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200B\u206A\u200E\u200E\u206F\u206A\u206E\u206C\u202E\u200B\u202D\u200F\u206F\u200C\u206A\u202B\u202D\u202A\u202A\u200B\u206D\u206F\u202E\u202E\u206C\u200C\u206A\u200C\u206F\u200E\u200C\u202B\u202C\u202E\u200D\u200F\u206D\u206B\u202D\u200D\u202E(this).GetValueOrDefault() / 2f)
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
							IL_008F:
							int num = ((!FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206C\u202B\u200C\u200B\u202C\u206F\u200C\u206F\u206A\u202D\u200B\u200D\u200B\u202D\u206B\u206D\u206C\u206D\u206F\u206C\u206F\u202B\u200E\u202A\u202E\u206C\u200F\u206A\u200D\u206E\u202D\u202D\u206C\u202E\u206F\u206D\u206F\u206B\u206C\u206F\u202E(enumerator)) ? 570468835 : (-45780281));
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(1827568218 - (num2 * 352977465 - (1298035792 + -531271999) * 72572635 - ~-1953173890))) % 5U)
								{
								case 1U:
								{
									ManaColor manaColor = enumerator.Current;
									num = ((manaGroup.GetValue(manaColor) > 0) ? 318624517 : (-1735515319));
									continue;
								}
								case 2U:
									goto IL_008F;
								case 3U:
									num = -45780281;
									continue;
								case 4U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 1295821438U) ^ 3024762023U);
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
								IL_00D9:
								int num4 = -147142773;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(1827568218 - (num2 * 352977465 - (1298035792 + -531271999) * 72572635 - ~-1953173890))) % 3U)
									{
									case 0U:
										goto IL_00D9;
									case 2U:
										FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200D\u200F\u200E\u202E\u200D\u200F\u200F\u206E\u202A\u202C\u202E\u200F\u206F\u200E\u206B\u200E\u200B\u202B\u200E\u202E\u200C\u202C\u206C\u200E\u202C\u202A\u206C\u206D\u206D\u206C\u206E\u200E\u200C\u206E\u200F\u200B\u200F\u202B\u200E\u202E(enumerator);
										num4 = (int)((num3 * 232998926U) ^ 1329892092U);
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
				if (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202D\u200E\u200C\u202E\u206E\u200C\u202A\u202A\u202D\u206B\u202B\u206A\u206B\u202C\u206C\u206F\u206C\u206B\u202C\u202C\u206F\u200C\u206E\u200D\u206F\u206A\u202D\u206F\u202D\u200F\u206F\u200E\u202A\u206E\u202D\u206A\u206A\u202A\u206B\u200D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_034A;
				int num2;
				string text2;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text;
					switch ((num3 = (uint)(-(uint)(((num + -850215321 * (482010690 * -627139863 * 1398219475)) ^ 1670679640) * -864204505))) % 40U)
					{
					case 0U:
					{
						object obj = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription;
						num2 = 108530067;
						continue;
					}
					case 2U:
						num2 = (int)((num3 * 1956660714U) ^ 3231415754U);
						continue;
					case 3U:
						num2 = (int)(((FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202E\u200C\u206B\u202C\u206A\u202A\u200F\u206C\u202C\u206E\u200D\u202E\u206F\u200E\u206B\u206C\u206F\u202D\u200D\u202B\u206A\u206C\u202C\u200B\u206D\u202B\u206E\u206C\u200B\u206A\u202E\u202E\u206A\u202A\u206F\u202A\u200D\u206B\u200C\u206C\u202E(this) == CardType.Friend) ? 2394496366U : 3147393289U) ^ (num3 * 1337893624U));
						continue;
					case 4U:
						text = base.BaseDescription;
						goto IL_012C;
					case 5U:
						goto IL_03FB;
					case 6U:
						num2 = (int)((num3 * 1934612777U) ^ 4180238721U);
						continue;
					case 7U:
						text2 = base.RawExtraDescription1;
						num2 = -1762872142;
						continue;
					case 8U:
						goto IL_0010;
					case 9U:
						goto IL_0435;
					case 10U:
						num2 = (int)((num3 * 1779090476U) ^ 136420279U);
						continue;
					case 11U:
					{
						string text3 = text2;
						string text4;
						if (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200B\u200D\u206A\u206F\u200C\u206F\u200D\u200D\u202A\u202A\u200E\u200D\u200C\u200C\u202E\u206B\u206E\u200F\u200F\u206A\u200F\u200E\u202C\u200E\u206A\u202B\u202D\u206F\u200B\u202B\u202E\u206B\u206B\u206A\u206A\u202B\u206F\u202C\u200F\u202E(this) == null)
						{
							if (!FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202C\u206F\u202C\u206D\u206D\u202E\u202E\u206D\u200F\u206A\u206E\u202E\u200F\u202D\u202E\u206D\u202D\u200E\u202E\u200D\u206D\u200B\u200D\u206E\u206B\u206E\u200F\u206C\u206B\u200D\u200B\u202A\u200D\u200D\u206A\u206B\u206A\u206C\u202D\u206E\u202E(this))
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
							text4 = (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202C\u206F\u202C\u206D\u206D\u202E\u202E\u206D\u200F\u206A\u206E\u202E\u200F\u202D\u202E\u206D\u202D\u200E\u202E\u200D\u206D\u200B\u200D\u206E\u206B\u206E\u200F\u206C\u206B\u200D\u200B\u202A\u200D\u200D\u206A\u206B\u206A\u206C\u202D\u206E\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						}
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text3, text4);
						num2 = 200378357;
						continue;
					}
					case 12U:
						goto IL_044C;
					case 13U:
					{
						FriendToken friendToken;
						switch (friendToken)
						{
						case FriendToken.None:
							goto IL_0463;
						case FriendToken.Active:
							goto IL_029C;
						case FriendToken.Active2:
							goto IL_044C;
						case FriendToken.Ultimate:
							goto IL_0435;
						default:
							num2 = (int)((num3 * 3494510645U) ^ 943216145U);
							continue;
						}
						break;
					}
					case 14U:
					{
						int num4;
						num2 = (int)(((num4 == 1) ? 1840458229U : 3645011736U) ^ (num3 * 1217784832U));
						continue;
					}
					case 15U:
						num2 = ((!base.HasExtraDescription1) ? 1511743231 : 21446553);
						continue;
					case 16U:
						if (!FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202C\u206F\u202C\u206D\u206D\u202E\u202E\u206D\u200F\u206A\u206E\u202E\u200F\u202D\u202E\u206D\u202D\u200E\u202E\u200D\u206D\u200B\u200D\u206E\u206B\u206E\u200F\u206C\u206B\u200D\u200B\u202A\u200D\u200D\u206A\u206B\u206A\u206C\u202D\u206E\u202E(this))
						{
							num2 = (int)((num3 * 3140739359U) ^ 172906362U);
							continue;
						}
						text = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_012C;
					case 17U:
						num2 = (int)((num3 * 1751027491U) ^ 648967172U);
						continue;
					case 18U:
						num2 = (int)((num3 * 3579019869U) ^ 4152152238U);
						continue;
					case 19U:
						num2 = ((!FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202C\u206F\u202C\u206D\u206D\u202E\u202E\u206D\u200F\u206A\u206E\u202E\u200F\u202D\u202E\u206D\u202D\u200E\u202E\u200D\u206D\u200B\u200D\u206E\u206B\u206E\u200F\u206C\u206B\u200D\u200B\u202A\u200D\u200D\u206A\u206B\u206A\u206C\u202D\u206E\u202E(this)) ? (-1476063457) : (-1906786722));
						continue;
					case 20U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 456023424;
						continue;
					}
					case 21U:
						num2 = (base.HasExtraDescription3 ? (-1769153619) : 1720307055);
						continue;
					case 22U:
						num2 = ((FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200B\u200D\u206A\u206F\u200C\u206F\u200D\u200D\u202A\u202A\u200E\u200D\u200C\u200C\u202E\u206B\u206E\u200F\u200F\u206A\u200F\u200E\u202C\u200E\u206A\u202B\u202D\u206F\u200B\u202B\u202E\u206B\u206B\u206A\u206A\u202B\u206F\u202C\u200F\u202E(this) == null) ? (-1903643887) : 19715198);
						continue;
					case 23U:
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription3);
						num2 = (int)((num3 * 1810894809U) ^ 1758409907U);
						continue;
					case 24U:
					{
						FriendToken friendToken = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200B\u200E\u202E\u200B\u206B\u206A\u206F\u200B\u200D\u206B\u200F\u202B\u202B\u200E\u202C\u202D\u206E\u206E\u202A\u202D\u206B\u200D\u200C\u200D\u206A\u206D\u206C\u202B\u202D\u202E\u206D\u202B\u206E\u206D\u202B\u206D\u206F\u202D\u202E\u200C\u202E(this);
						num2 = (int)((num3 * 377516972U) ^ 499884635U);
						continue;
					}
					case 25U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 456023424;
						continue;
					}
					case 26U:
					{
						int num4;
						num2 = (int)(((num4 != 2) ? 4162757306U : 3934435800U) ^ (num3 * 1532567001U));
						continue;
					}
					case 27U:
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription1);
						num2 = (int)((num3 * 2128125817U) ^ 2873528804U);
						continue;
					case 28U:
						text2 = base.RawExtraDescription2;
						num2 = -2064727035;
						continue;
					case 29U:
					{
						object obj;
						num2 = (int)(((obj != null) ? 1040611821U : 2292134375U) ^ (num3 * 2994479809U));
						continue;
					}
					case 30U:
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
						text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription2);
						num2 = (int)((num3 * 2920636199U) ^ 631733353U);
						continue;
					case 31U:
						goto IL_034A;
					case 32U:
						goto IL_0425;
					case 33U:
						num2 = ((!base.HasExtraDescription2) ? (-1435133445) : (-1946517252));
						continue;
					case 34U:
					{
						object obj;
						text2 = (string)obj;
						num2 = 1720307055;
						continue;
					}
					case 35U:
					{
						int num4 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u200C\u200D\u206A\u200D\u202A\u206F\u206E\u202C\u202D\u202C\u202E\u206F\u202A\u206B\u206B\u200D\u206A\u202E\u202C\u202E\u206C\u206F\u206E\u206A\u202B\u202B\u206F\u206D\u200D\u202C\u202E\u206E\u200C\u200F\u206E\u206B\u200F\u206E\u206F\u202E(this);
						num2 = -1924006876;
						continue;
					}
					case 36U:
						num2 = (int)((num3 * 803138367U) ^ 3775787235U);
						continue;
					case 37U:
						goto IL_0463;
					case 38U:
						goto IL_029C;
					case 39U:
						num2 = (int)((num3 * 2698309154U) ^ 3667352913U);
						continue;
					}
					break;
					IL_012C:
					text2 = text;
					num2 = 1720307055;
					continue;
					IL_029C:
					text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription1);
					num2 = 1720307055;
					continue;
					IL_0435:
					text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription3);
					num2 = 1552657104;
					continue;
					IL_044C:
					text2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(text2, base.RawExtraDescription2);
					num2 = 1583767039;
					continue;
					IL_0463:
					num2 = (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202D\u200E\u200C\u202E\u206E\u200C\u202A\u202A\u202D\u206B\u202B\u206A\u206B\u202C\u206C\u206F\u206C\u206B\u202C\u202C\u206F\u200C\u206E\u200D\u206F\u206A\u202D\u206F\u202D\u200F\u206F\u200E\u202A\u206E\u202D\u206A\u206A\u202A\u206B\u200D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(this)) ? 200378357 : 1226800777);
				}
				goto IL_0547;
				IL_03FB:
				return string.Empty;
				IL_0425:
				throw FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202C\u202B\u202E\u200E\u206F\u200C\u202D\u202C\u200F\u206F\u206D\u202E\u200F\u202D\u202D\u206D\u200F\u206D\u206B\u206B\u206D\u200B\u202E\u202D\u200E\u200E\u200B\u206D\u206C\u202C\u202E\u206B\u200F\u202C\u200F\u200B\u206D\u206C\u202C\u206C\u202E();
				IL_0547:
				return base.FollowByDetailIcon(text2);
				IL_0010:
				num2 = -1127089621;
				goto IL_0015;
				IL_034A:
				text2 = string.Empty;
				num2 = -1867348991;
				goto IL_0015;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<EnumerateRelativeCards>d__13 <EnumerateRelativeCards>d__ = new FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<EnumerateRelativeCards>d__13(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.Amount = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200F\u206B\u200F\u206B\u206C\u206B\u206A\u200F\u200F\u202E\u206A\u202D\u202C\u200F\u206E\u202B\u200E\u206A\u202C\u200D\u202A\u202A\u206A\u206B\u206D\u200C\u206B\u202A\u200F\u200D\u206F\u206B\u200B\u206E\u202D\u200F\u200C\u202A\u202E\u202E(this);
				base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206B\u200E\u200B\u206A\u202A\u206A\u202C\u206D\u206F\u200B\u200E\u202A\u200B\u202A\u200F\u206C\u200B\u206C\u202E\u200C\u206C\u200F\u200F\u206D\u206C\u200B\u200C\u200B\u206A\u206C\u206C\u200F\u206C\u202B\u202C\u202D\u202D\u200F\u206E\u202D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200B\u200D\u206A\u206F\u200C\u206F\u200D\u200D\u202A\u202A\u200E\u200D\u200C\u200C\u202E\u206B\u206E\u200F\u200F\u206A\u200F\u200E\u202C\u200E\u206A\u202B\u202D\u206F\u200B\u202B\u202E\u206B\u206B\u206A\u206A\u202B\u206F\u202C\u200F\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
				base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200F\u202D\u206B\u202E\u206D\u200E\u202A\u200B\u200B\u200E\u202E\u206C\u200B\u206F\u200E\u206F\u202D\u200F\u202C\u202C\u200C\u200E\u206D\u200F\u206E\u206C\u202E\u200B\u202A\u202C\u202C\u202A\u206B\u202B\u206B\u206A\u202C\u200B\u202A\u200F\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200B\u200D\u206A\u206F\u200C\u206F\u200D\u200D\u202A\u202A\u200E\u200D\u200C\u200C\u202E\u206B\u206E\u200F\u200F\u206A\u200F\u200E\u202C\u200E\u206A\u202B\u202D\u206F\u200B\u202B\u202E\u206B\u206B\u206A\u206A\u202B\u206F\u202C\u200F\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<OnCardUsed>d__15 <OnCardUsed>d__ = new FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<OnCardUsed>d__15(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<GetPassiveActions>d__16 <GetPassiveActions>d__ = new FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<GetPassiveActions>d__16(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202E\u200C\u206B\u202C\u206A\u202A\u200F\u206C\u202C\u206E\u200D\u202E\u206F\u200E\u206B\u206C\u206F\u202D\u200D\u202B\u206A\u206C\u202C\u200B\u206D\u202B\u206E\u206C\u200B\u206A\u202E\u202E\u206A\u202A\u206F\u202A\u200D\u206B\u200C\u206C\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list;
					List<Card> list2;
					for (;;)
					{
						IL_000C:
						int num = -1992106337;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-num2 * 1954542399)) % 16U)
							{
							case 0U:
								goto IL_000C;
							case 1U:
								list.Add(FriendToken.Ultimate);
								num = (int)((num3 * 3525097408U) ^ 2254539381U);
								continue;
							case 3U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 3802053719U : 815770053U) ^ (num3 * 665153744U));
								continue;
							}
							case 4U:
							{
								int? num4 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u206C\u200B\u202A\u200E\u200E\u202A\u202D\u202A\u206A\u206F\u200B\u200E\u202C\u206F\u206F\u200C\u206D\u200D\u200E\u206E\u206F\u206C\u202C\u206B\u200D\u206B\u202C\u206F\u206B\u200D\u206A\u200F\u200B\u200E\u206D\u202C\u206D\u206F\u202D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(this));
								num = (int)(((num4 != null) ? 523832708U : 1322493873U) ^ (num3 * 1855092082U));
								continue;
							}
							case 5U:
								list2 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202D\u202A\u206D\u202E\u202A\u200D\u202C\u202C\u202B\u200C\u202B\u200F\u206A\u206B\u206D\u202D\u202A\u200C\u202C\u206A\u206E\u206A\u206E\u206B\u200B\u200C\u202A\u200E\u202C\u206D\u202B\u200E\u206C\u200F\u206F\u202C\u206B\u202A\u206B\u202B\u202E(this, list.Count, false).ToList<Card>();
								num = 1996046114;
								continue;
							case 6U:
								list = new List<FriendToken>();
								num = (int)(((!this.ActiveUsed) ? 1434093170U : 1851122703U) ^ (num3 * 2946375785U));
								continue;
							case 7U:
								num = (int)(((FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206C\u206A\u206B\u206A\u200E\u202B\u202D\u206E\u206E\u200B\u202B\u200F\u202E\u206C\u202B\u206C\u206A\u200B\u206B\u206F\u206C\u202D\u206E\u206B\u206C\u206C\u206C\u206A\u202E\u202C\u202A\u202A\u202E\u200E\u200B\u206D\u206E\u206C\u206A\u202E(this) >= -FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u206A\u202A\u206E\u200D\u200F\u206D\u202B\u202A\u200E\u202E\u206C\u202D\u200F\u206C\u206F\u200D\u200C\u206C\u202B\u206E\u206C\u202E\u200E\u202E\u206D\u206F\u200D\u202A\u200C\u206C\u206D\u206F\u206E\u200E\u202A\u206B\u200F\u202D\u200F\u202E(this)) ? 4094943555U : 1219030887U) ^ (num3 * 2545266014U));
								continue;
							case 8U:
								num = (int)(((FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206C\u206A\u206B\u206A\u200E\u202B\u202D\u206E\u206E\u200B\u202B\u200F\u202E\u206C\u202B\u206C\u206A\u200B\u206B\u206F\u206C\u202D\u206E\u206B\u206C\u206C\u206C\u206A\u202E\u202C\u202A\u202A\u202E\u200E\u200B\u206D\u206E\u206C\u206A\u202E(this) >= -FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u206D\u206B\u202B\u206A\u206F\u200D\u200B\u206D\u202D\u202C\u202E\u206F\u202C\u202D\u202A\u200C\u206E\u206A\u206E\u202B\u202D\u202A\u206A\u206A\u206D\u200E\u200B\u202A\u206C\u206B\u206A\u206F\u202E\u200C\u206B\u206B\u206A\u206F\u202D\u202E(this)) ? 2006618099U : 2210874518U) ^ (num3 * 2023182933U));
								continue;
							case 9U:
							{
								int? num4 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u202A\u206E\u200D\u200D\u200B\u206C\u202D\u202A\u202A\u200F\u200C\u206C\u200E\u200C\u202B\u206C\u200E\u206E\u206D\u200E\u200B\u200B\u200F\u200F\u202D\u202D\u206D\u200C\u200F\u202E\u206B\u206D\u202E\u206D\u202B\u202D\u202E\u200E\u206A\u206D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(this));
								num = ((num4 == null) ? 1588730606 : 1642298008);
								continue;
							}
							case 10U:
								if (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206C\u206A\u206B\u206A\u200E\u202B\u202D\u206E\u206E\u200B\u202B\u200F\u202E\u206C\u202B\u206C\u206A\u200B\u206B\u206F\u206C\u202D\u206E\u206B\u206C\u206C\u206C\u206A\u202E\u202C\u202A\u202A\u202E\u200E\u200B\u206D\u206E\u206C\u206A\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 2297791532U) ^ 2164817598U);
									continue;
								}
								goto IL_0328;
							case 11U:
								list.Add(FriendToken.Active2);
								num = (int)((num3 * 3929632985U) ^ 3395251197U);
								continue;
							case 12U:
								num = (int)(((FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206C\u206A\u206B\u206A\u200E\u202B\u202D\u206E\u206E\u200B\u202B\u200F\u202E\u206C\u202B\u206C\u206A\u200B\u206B\u206F\u206C\u202D\u206E\u206B\u206C\u206C\u206C\u206A\u202E\u202C\u202A\u202A\u202E\u200E\u200B\u206D\u206E\u206C\u206A\u202E(this) < -FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206E\u200C\u206B\u200E\u202A\u200D\u206B\u202C\u200B\u202C\u200F\u206B\u206C\u206E\u200B\u200F\u200C\u206C\u206D\u206E\u202B\u200B\u202B\u200C\u206D\u202B\u206F\u202C\u206D\u200B\u200B\u206C\u206D\u206A\u200E\u202B\u206C\u202A\u206B\u206B\u202E(this)) ? 2174815109U : 1002118529U) ^ (num3 * 4188671397U));
								continue;
							case 13U:
								list.Add(FriendToken.Active);
								num = (int)((num3 * 3257585035U) ^ 1975044710U);
								continue;
							case 14U:
							{
								int? num4 = FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206F\u202A\u200D\u206B\u202C\u206D\u202C\u206C\u202D\u200D\u200F\u206B\u200F\u206B\u206C\u202D\u200D\u202C\u202E\u200C\u206F\u202A\u206D\u200D\u200F\u206A\u206E\u200E\u206C\u206D\u200F\u206E\u202D\u206E\u206D\u200D\u206A\u202E\u202D\u202E(FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(this));
								num = 1396011043;
								continue;
							}
							case 15U:
								if (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u200D\u200D\u206F\u202D\u200E\u200B\u206F\u200E\u200E\u202E\u206F\u206E\u202E\u202D\u202B\u200F\u202E\u206F\u200B\u206B\u206F\u206F\u202A\u200B\u202C\u206D\u200D\u200F\u200C\u202E\u200D\u206F\u200D\u202C\u200B\u202B\u206C\u206D\u200E\u202E(this))
								{
									num = (int)((num3 * 2834965364U) ^ 1917843878U);
									continue;
								}
								goto IL_0328;
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
							IL_02C1:
							int num5 = (FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206C\u202B\u200C\u200B\u202C\u206F\u200C\u206F\u206A\u202D\u200B\u200D\u200B\u202D\u206B\u206D\u206C\u206D\u206F\u206C\u206F\u202B\u200E\u202A\u202E\u206C\u200F\u206A\u200D\u206E\u202D\u202D\u206C\u202E\u206F\u206D\u206F\u206B\u206C\u206F\u202E(enumerator) ? (-171763323) : 1856893230);
							for (;;)
							{
								int num2 = num5;
								switch (-num2 * 1954542399 % 4)
								{
								case 0:
									goto IL_02C1;
								case 1:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u200C\u202A\u206E\u206A\u206E\u206B\u202B\u200B\u206C\u202A\u206A\u202D\u202C\u206C\u202B\u202A\u206E\u202C\u206B\u206C\u202E\u200C\u206F\u202E\u200D\u202B\u202B\u200E\u206D\u200B\u200F\u202E\u206A\u206A\u206A\u202C\u202C\u202B\u202A\u202E(list2[item], item2);
									num5 = -454573768;
									continue;
								}
								case 3:
									num5 = -171763323;
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
								IL_02DF:
								int num6 = 918200726;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(-num2 * 1954542399)) % 3U)
									{
									case 1U:
										FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206A\u200D\u200F\u200E\u202E\u200D\u200F\u200F\u206E\u202A\u202C\u202E\u200F\u206F\u200E\u206B\u200E\u200B\u202B\u200E\u202E\u200C\u202C\u206C\u200E\u202C\u202A\u206C\u206D\u206D\u206C\u206E\u200E\u200C\u206E\u200F\u200B\u200F\u202B\u200E\u202E(enumerator);
										num6 = (int)((num3 * 1825554784U) ^ 1750003380U);
										continue;
									case 2U:
										goto IL_02DF;
									}
									goto Block_16;
								}
							}
							Block_16:;
						}
					}
					return FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.\u206D\u206F\u202D\u200E\u206E\u200F\u206C\u200B\u206C\u206C\u206D\u200E\u200E\u206E\u200F\u200C\u206D\u202E\u202B\u206F\u200D\u202D\u202D\u206F\u206F\u200D\u206B\u202C\u200C\u200F\u206A\u206C\u202E\u206A\u206C\u200C\u200B\u206C\u202B\u200C\u202E(list2, false, false, false);
				}
				IL_0328:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<Actions>d__19 <Actions>d__ = new FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<Actions>d__19(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<AfterUseAction>d__20 <AfterUseAction>d__ = new FlandreFriendOkinaWinterDef.FlandreFriendOkinaWinter.<AfterUseAction>d__20(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static int? \u200B\u206A\u200E\u200E\u206F\u206A\u206E\u206C\u202E\u200B\u202D\u200F\u206F\u200C\u206A\u202B\u202D\u202A\u202A\u200B\u206D\u206F\u202E\u202E\u206C\u200C\u206A\u200C\u206F\u200E\u200C\u202B\u202C\u202E\u200D\u200F\u206D\u206B\u202D\u200D\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206F\u200E\u206A\u206C\u202A\u200C\u206F\u200B\u206B\u206C\u206F\u206E\u202E\u206D\u200F\u206E\u206C\u206E\u202C\u206D\u200B\u200F\u202E\u200F\u200E\u206D\u200E\u206B\u206C\u202A\u206E\u202E\u202B\u202C\u206B\u200C\u202E\u200B\u206A\u200F\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206C\u202B\u200C\u200B\u202C\u206F\u200C\u206F\u206A\u202D\u200B\u200D\u200B\u202D\u206B\u206D\u206C\u206D\u206F\u206C\u206F\u202B\u200E\u202A\u202E\u206C\u200F\u206A\u200D\u206E\u202D\u202D\u206C\u202E\u206F\u206D\u206F\u206B\u206C\u206F\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206A\u200D\u200F\u200E\u202E\u200D\u200F\u200F\u206E\u202A\u202C\u202E\u200F\u206F\u200E\u206B\u200E\u200B\u202B\u200E\u202E\u200C\u202C\u206C\u200E\u202C\u202A\u206C\u206D\u206D\u206C\u206E\u200E\u200C\u206E\u200F\u200B\u200F\u202B\u200E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static CardConfig \u200D\u202A\u206E\u202B\u206F\u200C\u200C\u200C\u206A\u206B\u206F\u200D\u200B\u202E\u200D\u202A\u202E\u202A\u202B\u202E\u206A\u202D\u206B\u200D\u200B\u206E\u200B\u206B\u200C\u200C\u202B\u202E\u200D\u200F\u206F\u200C\u200D\u206D\u206F\u200D\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u202D\u200E\u200C\u202E\u206E\u200C\u202A\u202A\u202D\u206B\u202B\u206A\u206B\u202C\u206C\u206F\u206C\u206B\u202C\u202C\u206F\u200C\u206E\u200D\u206F\u206A\u202D\u206F\u202D\u200F\u206F\u200E\u202A\u206E\u202D\u206A\u206A\u202A\u206B\u200D\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u202E\u200C\u206B\u202C\u206A\u202A\u200F\u206C\u202C\u206E\u200D\u202E\u206F\u200E\u206B\u206C\u206F\u202D\u200D\u202B\u206A\u206C\u202C\u200B\u206D\u202B\u206E\u206C\u200B\u206A\u202E\u202E\u206A\u202A\u206F\u202A\u200D\u206B\u200C\u206C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u200B\u200E\u202E\u200B\u206B\u206A\u206F\u200B\u200D\u206B\u200F\u202B\u202B\u200E\u202C\u202D\u206E\u206E\u202A\u202D\u206B\u200D\u200C\u200D\u206A\u206D\u206C\u202B\u202D\u202E\u206D\u202B\u206E\u206D\u202B\u206D\u206F\u202D\u202E\u200C\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static BattleController \u206A\u200B\u200D\u206A\u206F\u200C\u206F\u200D\u200D\u202A\u202A\u200E\u200D\u200C\u200C\u202E\u206B\u206E\u200F\u200F\u206A\u200F\u200E\u202C\u200E\u206A\u202B\u202D\u206F\u200B\u202B\u202E\u206B\u206B\u206A\u206A\u202B\u206F\u202C\u200F\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202C\u206F\u202C\u206D\u206D\u202E\u202E\u206D\u200F\u206A\u206E\u202E\u200F\u202D\u202E\u206D\u202D\u200E\u202E\u200D\u206D\u200B\u200D\u206E\u206B\u206E\u200F\u206C\u206B\u200D\u200B\u202A\u200D\u200D\u206A\u206B\u206A\u206C\u202D\u206E\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u200C\u202A\u202C\u200C\u206D\u202E\u206B\u202B\u202E\u200C\u200D\u206F\u206D\u200D\u202B\u202A\u206A\u202E\u200E\u200E\u202B\u206F\u202A\u206E\u200D\u206D\u202A\u202A\u206B\u202B\u202D\u202D\u200C\u202A\u206B\u200E\u206E\u206A\u206C\u206C\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u202C\u202B\u202E\u200E\u206F\u200C\u202D\u202C\u200F\u206F\u206D\u202E\u200F\u202D\u202D\u206D\u200F\u206D\u206B\u206B\u206D\u200B\u202E\u202D\u200E\u200E\u200B\u206D\u206C\u202C\u202E\u206B\u200F\u202C\u200F\u200B\u206D\u206C\u202C\u206C\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200C\u200C\u200D\u206A\u200D\u202A\u206F\u206E\u202C\u202D\u202C\u202E\u206F\u202A\u206B\u206B\u200D\u206A\u202E\u202C\u202E\u206C\u206F\u206E\u206A\u202B\u202B\u206F\u206D\u200D\u202C\u202E\u206E\u200C\u200F\u206E\u206B\u200F\u206E\u206F\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static int \u200F\u206B\u200F\u206B\u206C\u206B\u206A\u200F\u200F\u202E\u206A\u202D\u202C\u200F\u206E\u202B\u200E\u206A\u202C\u200D\u202A\u202A\u206A\u206B\u206D\u200C\u206B\u202A\u200F\u200D\u206F\u206B\u200B\u206E\u202D\u200F\u200C\u202A\u202E\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameEvent<CardUsingEventArgs> \u206B\u200E\u200B\u206A\u202A\u206A\u202C\u206D\u206F\u200B\u200E\u202A\u200B\u202A\u200F\u206C\u200B\u206C\u202E\u200C\u206C\u200F\u200F\u206D\u206C\u200B\u200C\u200B\u206A\u206C\u206C\u200F\u206C\u202B\u202C\u202D\u202D\u200F\u206E\u202D\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u200F\u202D\u206B\u202E\u206D\u200E\u202A\u200B\u200B\u200E\u202E\u206C\u200B\u206F\u200E\u206F\u202D\u200F\u202C\u202C\u200C\u200E\u206D\u200F\u206E\u206C\u202E\u200B\u202A\u202C\u202C\u202A\u206B\u202B\u206B\u206A\u202C\u200B\u202A\u200F\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u200D\u200D\u206F\u202D\u200E\u200B\u206F\u200E\u200E\u202E\u206F\u206E\u202E\u202D\u202B\u200F\u202E\u206F\u200B\u206B\u206F\u206F\u202A\u200B\u202C\u206D\u200D\u200F\u200C\u202E\u200D\u206F\u200D\u202C\u200B\u202B\u206C\u206D\u200E\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u206D\u206C\u206A\u206B\u206A\u200E\u202B\u202D\u206E\u206E\u200B\u202B\u200F\u202E\u206C\u202B\u206C\u206A\u200B\u206B\u206F\u206C\u202D\u206E\u206B\u206C\u206C\u206C\u206A\u202E\u202C\u202A\u202A\u202E\u200E\u200B\u206D\u206E\u206C\u206A\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u200D\u206C\u200B\u202A\u200E\u200E\u202A\u202D\u202A\u206A\u206F\u200B\u200E\u202C\u206F\u206F\u200C\u206D\u200D\u200E\u206E\u206F\u206C\u202C\u206B\u200D\u206B\u202C\u206F\u206B\u200D\u206A\u200F\u200B\u200E\u206D\u202C\u206D\u206F\u202D\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206E\u200C\u206B\u200E\u202A\u200D\u206B\u202C\u200B\u202C\u200F\u206B\u206C\u206E\u200B\u200F\u200C\u206C\u206D\u206E\u202B\u200B\u202B\u200C\u206D\u202B\u206F\u202C\u206D\u200B\u200B\u206C\u206D\u206A\u200E\u202B\u206C\u202A\u206B\u206B\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u202A\u206E\u200D\u200D\u200B\u206C\u202D\u202A\u202A\u200F\u200C\u206C\u200E\u200C\u202B\u206C\u200E\u206E\u206D\u200E\u200B\u200B\u200F\u200F\u202D\u202D\u206D\u200C\u200F\u202E\u206B\u206D\u202E\u206D\u202B\u202D\u202E\u200E\u206A\u206D\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u206A\u206D\u206B\u202B\u206A\u206F\u200D\u200B\u206D\u202D\u202C\u202E\u206F\u202C\u202D\u202A\u200C\u206E\u206A\u206E\u202B\u202D\u202A\u206A\u206A\u206D\u200E\u200B\u202A\u206C\u206B\u206A\u206F\u202E\u200C\u206B\u206B\u206A\u206F\u202D\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u206D\u206F\u202A\u200D\u206B\u202C\u206D\u202C\u206C\u202D\u200D\u200F\u206B\u200F\u206B\u206C\u202D\u200D\u202C\u202E\u200C\u206F\u202A\u206D\u200D\u200F\u206A\u206E\u200E\u206C\u206D\u200F\u206E\u202D\u206E\u206D\u200D\u206A\u202E\u202D\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u200D\u206A\u202A\u206E\u200D\u200F\u206D\u202B\u202A\u200E\u202E\u206C\u202D\u200F\u206C\u206F\u200D\u200C\u206C\u202B\u206E\u206C\u202E\u200E\u202E\u206D\u206F\u200D\u202A\u200C\u206C\u206D\u206F\u206E\u200E\u202A\u206B\u200F\u202D\u200F\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u202D\u202A\u206D\u202E\u202A\u200D\u202C\u202C\u202B\u200C\u202B\u200F\u206A\u206B\u206D\u202D\u202A\u200C\u202C\u206A\u206E\u206A\u206E\u206B\u200B\u200C\u202A\u200E\u202C\u206D\u202B\u200E\u206C\u200F\u206F\u202C\u206B\u202A\u206B\u202B\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u206D\u200C\u202A\u206E\u206A\u206E\u206B\u202B\u200B\u206C\u202A\u206A\u202D\u202C\u206C\u202B\u202A\u206E\u202C\u206B\u206C\u202E\u200C\u206F\u202E\u200D\u202B\u202B\u200E\u206D\u200B\u200F\u202E\u206A\u206A\u206A\u202C\u202C\u202B\u202A\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u206D\u206F\u202D\u200E\u206E\u200F\u206C\u200B\u206C\u206C\u206D\u200E\u200E\u206E\u200F\u200C\u206D\u202E\u202B\u206F\u200D\u202D\u202D\u206F\u206F\u200D\u206B\u202C\u200C\u200F\u206A\u206C\u202E\u206A\u206C\u200C\u200B\u206C\u202B\u200C\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public bool ActiveUsed;
		}
	}
}
