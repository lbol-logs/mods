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
	public sealed class FlandreChromaticWingsDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-42819517);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreChromaticWingsDef.\u202E\u206D\u206F\u206C\u202E\u200C\u200E\u202A\u200D\u200D\u200C\u202B\u200B\u206D\u202B\u200D\u202B\u200D\u202D\u200B\u206E\u200E\u200B\u206B\u206A\u200F\u206A\u206F\u206F\u200B\u206F\u206C\u200C\u206C\u202B\u200B\u200F\u202A\u206B\u206A\u202E(BepinexPlugin.embeddedSource);
			FlandreChromaticWingsDef.\u202E\u206C\u200C\u206B\u200B\u200B\u200D\u200C\u200F\u200F\u206E\u206B\u206E\u200F\u206E\u202B\u200D\u206E\u202B\u206A\u202C\u202D\u202A\u200F\u200B\u206D\u202C\u202A\u202C\u202D\u202B\u206A\u206C\u202E\u202A\u206D\u206B\u202A\u202D\u202A\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreChromaticWingsDef.\u206E\u202B\u200C\u202E\u200E\u200E\u206E\u200D\u202B\u200D\u206E\u200C\u206B\u206E\u206B\u200D\u206D\u200B\u206B\u206A\u206F\u200B\u200B\u202E\u206B\u206D\u206B\u206F\u202C\u206E\u200E\u206D\u202E\u202C\u200C\u206C\u202D\u200D\u206D\u202E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreChromaticWingsDef.\u202A\u206E\u206C\u206C\u200B\u206B\u202A\u202C\u206D\u206F\u206F\u200F\u206D\u202D\u202C\u200B\u202A\u202A\u200B\u200F\u202B\u206A\u206B\u200D\u200B\u200D\u202A\u200C\u200E\u206F\u202D\u202B\u200B\u206B\u200F\u202C\u206C\u206A\u206B\u206F\u202E(BepinexPlugin.sequenceTable, FlandreChromaticWingsDef.\u206C\u200D\u200F\u202E\u206E\u202D\u206D\u202D\u200F\u200E\u206A\u202A\u202D\u206D\u206E\u202D\u200E\u202E\u202D\u206C\u200C\u200D\u202D\u202C\u206C\u206E\u200E\u202E\u202D\u200D\u206B\u200F\u202A\u202D\u206E\u202C\u202D\u206C\u206B\u206D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 1,
				Hybrid = 2,
				HybridColor = 7
			}, new ManaGroup?(new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			}), null, null, null, null, null, null, null, null, null, new int?(2), null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Philosophy, Keyword.Philosophy, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1517263752), new List<string>());
		}

		static CardImages \u202E\u206D\u206F\u206C\u202E\u200C\u200E\u202A\u200D\u200D\u200C\u202B\u200B\u206D\u202B\u200D\u202B\u200D\u202D\u200B\u206E\u200E\u200B\u206B\u206A\u200F\u206A\u206F\u206F\u200B\u206F\u206C\u200C\u206C\u202B\u200B\u200F\u202A\u206B\u206A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u206C\u200C\u206B\u200B\u200B\u200D\u200C\u200F\u200F\u206E\u206B\u206E\u200F\u206E\u202B\u200D\u206E\u202B\u206A\u202C\u202D\u202A\u200F\u200B\u206D\u202C\u202A\u202C\u202D\u202B\u206A\u206C\u202E\u202A\u206D\u206B\u202A\u202D\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u202B\u200C\u202E\u200E\u200E\u206E\u200D\u202B\u200D\u206E\u200C\u206B\u206E\u206B\u200D\u206D\u200B\u206B\u206A\u206F\u200B\u200B\u202E\u206B\u206D\u206B\u206F\u202C\u206E\u200E\u206D\u202E\u202C\u200C\u206C\u202D\u200D\u206D\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u200D\u200F\u202E\u206E\u202D\u206D\u202D\u200F\u200E\u206A\u202A\u202D\u206D\u206E\u202D\u200E\u202E\u202D\u206C\u200C\u200D\u202D\u202C\u206C\u206E\u200E\u202E\u202D\u200D\u206B\u200F\u202A\u202D\u206E\u202C\u202D\u206C\u206B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206E\u206C\u206C\u200B\u206B\u202A\u202C\u206D\u206F\u206F\u200F\u206D\u202D\u202C\u200B\u202A\u202A\u200B\u200F\u202B\u206A\u206B\u200D\u200B\u200D\u202A\u200C\u200E\u206F\u202D\u202B\u200B\u206B\u200F\u202C\u206C\u206A\u206B\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreChromaticWingsDef))]
		public sealed class FlandreChromaticWings : FlandreCard
		{
			public override ManaGroup AdditionalMana
			{
				get
				{
					ManaGroup manaGroup = default(ManaGroup);
					for (;;)
					{
						IL_0008:
						int num = 709775400;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-1937968707 * 1408160097 - (num2 - (133647903 - 330851070 + (-363648962 - 354117537) + (-1052552708 * 1085794241 - -1610990687)) - (-1943460418 - -775245952)))) % 3U)
							{
							case 0U:
								goto IL_0008;
							case 1U:
								manaGroup.Philosophy = FlandreChromaticWingsDef.FlandreChromaticWings.\u200C\u206F\u202B\u202D\u200E\u200E\u202E\u200E\u206A\u202C\u206B\u206E\u200E\u200F\u200E\u206C\u200F\u202D\u202E\u200C\u206D\u206E\u202C\u206D\u202A\u200B\u206B\u202D\u206C\u200D\u202C\u206B\u200B\u206D\u206A\u200E\u202B\u202C\u200F\u200C\u202E((float)FlandreChromaticWingsDef.FlandreChromaticWings.\u206B\u202E\u206D\u206D\u206A\u206E\u200E\u202E\u202D\u206D\u206D\u206A\u206A\u206B\u202A\u200D\u200D\u202E\u206D\u206A\u200F\u200C\u202E\u202E\u206A\u202B\u200B\u206E\u200C\u202E\u202D\u200B\u206E\u206B\u206B\u206C\u202E\u202C\u200F\u200E\u202E(this).GetValueOrDefault() / 2f);
								num = (int)((num3 * 3144297533U) ^ 3503208171U);
								continue;
							}
							return manaGroup;
						}
					}
					return manaGroup;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -1846501245;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-num2 - ((-2105398980 ^ -2019785178) + -1845652811) - (979470505 ^ 603358806)) ^ -1989462412)) % 4U)
						{
						case 0U:
							base.OfferingCount = FlandreChromaticWingsDef.FlandreChromaticWings.\u202E\u206D\u206D\u206A\u206B\u202D\u200F\u200F\u200C\u202C\u202D\u202C\u206D\u202A\u200C\u200D\u202C\u202A\u200F\u200D\u200C\u206F\u206F\u202A\u200F\u206A\u200B\u202D\u200E\u206B\u202E\u200C\u202C\u200E\u202C\u202E\u202C\u206B\u206E\u202E\u202E(this);
							num = (int)((num3 * 270673376U) ^ 2636984377U);
							continue;
						case 2U:
							goto IL_0006;
						case 3U:
							base.IsOffering = true;
							num = (int)((num3 * 3310476087U) ^ 2605441979U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreChromaticWingsDef.FlandreChromaticWings.<Actions>d__3 <Actions>d__ = new FlandreChromaticWingsDef.FlandreChromaticWings.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206B\u202E\u206D\u206D\u206A\u206E\u200E\u202E\u202D\u206D\u206D\u206A\u206A\u206B\u202A\u200D\u200D\u202E\u206D\u206A\u200F\u200C\u202E\u202E\u206A\u202B\u200B\u206E\u200C\u202E\u202D\u200B\u206E\u206B\u206B\u206C\u202E\u202C\u200F\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200C\u206F\u202B\u202D\u200E\u200E\u202E\u200E\u206A\u202C\u206B\u206E\u200E\u200F\u200E\u206C\u200F\u202D\u202E\u200C\u206D\u206E\u202C\u206D\u202A\u200B\u206B\u202D\u206C\u200D\u202C\u206B\u200B\u206D\u206A\u200E\u202B\u202C\u200F\u200C\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static int \u202E\u206D\u206D\u206A\u206B\u202D\u200F\u200F\u200C\u202C\u202D\u202C\u206D\u202A\u200C\u200D\u202C\u202A\u200F\u200D\u200C\u206F\u206F\u202A\u200F\u206A\u200B\u202D\u200E\u206B\u202E\u200C\u202C\u200E\u202C\u202E\u202C\u206B\u206E\u202E\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
