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
	public sealed class FlandreCrystallizedLunacyDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1631438369);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreCrystallizedLunacyDef.\u200F\u206B\u200B\u206C\u202A\u206D\u206E\u202B\u202E\u200E\u200C\u200D\u206E\u200C\u200C\u202B\u200F\u200B\u202B\u200F\u206A\u206A\u202C\u206C\u200D\u206A\u200C\u206E\u206F\u200D\u206E\u202A\u206E\u206D\u200B\u202D\u206E\u206A\u206E\u202E(BepinexPlugin.embeddedSource);
			FlandreCrystallizedLunacyDef.\u200B\u202E\u202B\u206A\u206C\u206D\u206E\u200B\u206D\u206C\u200B\u200F\u206C\u206D\u202A\u206A\u202C\u206C\u206A\u206E\u200F\u200F\u200B\u206D\u202A\u200E\u200C\u206A\u206B\u200D\u200B\u202C\u206B\u202E\u202B\u206D\u202D\u206B\u200B\u202E\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreCrystallizedLunacyDef.\u206C\u200B\u206B\u206A\u206A\u200C\u202B\u200E\u206C\u206D\u206E\u206C\u200B\u206C\u200B\u200D\u200E\u206D\u200E\u206C\u200E\u206D\u200D\u202D\u200B\u206A\u202C\u206B\u200D\u206E\u200E\u202A\u206A\u200B\u200D\u206F\u206E\u200C\u200E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreCrystallizedLunacyDef.\u206B\u206F\u202D\u200C\u200F\u202D\u206A\u206E\u200B\u202E\u202A\u200B\u200C\u200C\u202B\u206E\u206E\u206F\u206D\u206A\u206D\u206C\u202A\u200F\u202A\u206E\u200D\u206D\u200F\u206D\u202C\u202E\u200E\u202E\u200E\u202A\u200D\u200C\u206E\u202D\u202E(BepinexPlugin.sequenceTable, FlandreCrystallizedLunacyDef.\u206B\u206B\u206D\u200F\u206F\u206C\u200B\u206B\u200F\u202C\u202C\u202C\u200C\u202D\u200D\u200D\u200D\u206E\u202D\u202C\u206B\u202B\u206C\u200E\u200E\u206F\u206C\u206D\u206A\u202D\u202D\u200E\u200E\u200B\u202D\u206D\u202D\u202C\u206F\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1272381861), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-279708976), 0, false, false, false, true, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Black }, false, BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Any = 1
			} : new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(10), null, null, null, null, null, new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, "", new List<string>());
		}

		static CardImages \u200F\u206B\u200B\u206C\u202A\u206D\u206E\u202B\u202E\u200E\u200C\u200D\u206E\u200C\u200C\u202B\u200F\u200B\u202B\u200F\u206A\u206A\u202C\u206C\u200D\u206A\u200C\u206E\u206F\u200D\u206E\u202A\u206E\u206D\u200B\u202D\u206E\u206A\u206E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200B\u202E\u202B\u206A\u206C\u206D\u206E\u200B\u206D\u206C\u200B\u200F\u206C\u206D\u202A\u206A\u202C\u206C\u206A\u206E\u200F\u200F\u200B\u206D\u202A\u200E\u200C\u206A\u206B\u200D\u200B\u202C\u206B\u202E\u202B\u206D\u202D\u206B\u200B\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u200B\u206B\u206A\u206A\u200C\u202B\u200E\u206C\u206D\u206E\u206C\u200B\u206C\u200B\u200D\u200E\u206D\u200E\u206C\u200E\u206D\u200D\u202D\u200B\u206A\u202C\u206B\u200D\u206E\u200E\u202A\u206A\u200B\u200D\u206F\u206E\u200C\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u206B\u206D\u200F\u206F\u206C\u200B\u206B\u200F\u202C\u202C\u202C\u200C\u202D\u200D\u200D\u200D\u206E\u202D\u202C\u206B\u202B\u206C\u200E\u200E\u206F\u206C\u206D\u206A\u202D\u202D\u200E\u200E\u200B\u202D\u206D\u202D\u202C\u206F\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u206F\u202D\u200C\u200F\u202D\u206A\u206E\u200B\u202E\u202A\u200B\u200C\u200C\u202B\u206E\u206E\u206F\u206D\u206A\u206D\u206C\u202A\u200F\u202A\u206E\u200D\u206D\u200F\u206D\u202C\u202E\u200E\u202E\u200E\u202A\u200D\u200C\u206E\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreCrystallizedLunacyDef))]
		public sealed class FlandreCrystallizedLunacy : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreCrystallizedLunacyDef.FlandreCrystallizedLunacy.\u200D\u206A\u202D\u200E\u200D\u202C\u202A\u200B\u202A\u206F\u206F\u206C\u206B\u200B\u200F\u202C\u206E\u202C\u202B\u202B\u202C\u206F\u202D\u200C\u200F\u202C\u200C\u206F\u206B\u200F\u206F\u206B\u206F\u206D\u206F\u200C\u202A\u202D\u200B\u206B\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreCrystallizedLunacyDef.FlandreCrystallizedLunacy.\u200D\u206A\u202D\u200E\u200D\u202C\u202A\u200B\u202A\u206F\u206F\u206C\u206B\u200B\u200F\u202C\u206E\u202C\u202B\u202B\u202C\u206F\u202D\u200C\u200F\u202C\u200C\u206F\u206B\u200F\u206F\u206B\u206F\u206D\u206F\u200C\u202A\u202D\u200B\u206B\u202E(this).GetValueOrDefault();
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -1651850762;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(uint)(-(uint)(num2 * 1360619485))))) % 5U)
						{
						case 0U:
							base.IsRandom = true;
							num = (int)((num3 * 3085984804U) ^ 3231269473U);
							continue;
						case 1U:
							base.IsMagicalGirl = true;
							num = (int)((num3 * 832326433U) ^ 684450340U);
							continue;
						case 2U:
							base.IsCrystal = true;
							num = (int)((num3 * 122338029U) ^ 1265724743U);
							continue;
						case 4U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreCrystallizedLunacyDef.FlandreCrystallizedLunacy.<Actions>d__5 <Actions>d__ = new FlandreCrystallizedLunacyDef.FlandreCrystallizedLunacy.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static int? \u200D\u206A\u202D\u200E\u200D\u202C\u202A\u200B\u202A\u206F\u206F\u206C\u206B\u200B\u200F\u202C\u206E\u202C\u202B\u202B\u202C\u206F\u202D\u200C\u200F\u202C\u200C\u206F\u206B\u200F\u206F\u206B\u206F\u206D\u206F\u200C\u202A\u202D\u200B\u206B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
