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
	public sealed class FlandreCrystallizedCatastropheDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1914787303);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreCrystallizedCatastropheDef.\u206D\u200B\u200C\u200F\u206F\u200F\u200F\u206C\u202B\u206E\u206F\u206D\u206D\u202E\u206C\u200E\u206F\u202C\u206B\u206D\u206A\u202D\u206E\u206D\u200D\u206E\u200B\u206D\u202D\u206F\u202A\u200E\u202D\u202C\u206B\u200F\u206B\u202E\u202C\u206E\u202E(BepinexPlugin.embeddedSource);
			FlandreCrystallizedCatastropheDef.\u202C\u200C\u200C\u200E\u202D\u202C\u200E\u206F\u206E\u206B\u200C\u206B\u206A\u206B\u200C\u206E\u202E\u206F\u202E\u202A\u202A\u206B\u200E\u200E\u200B\u206D\u202A\u200C\u200B\u206D\u206B\u206D\u200D\u202E\u202C\u202C\u206F\u206A\u202E\u200E\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreCrystallizedCatastropheDef.\u206C\u206C\u202D\u206D\u200B\u202C\u206F\u200F\u200B\u206B\u202B\u200B\u200C\u206B\u202A\u200F\u202D\u200B\u202B\u202D\u200E\u206A\u200F\u202D\u200B\u202B\u200D\u200F\u206A\u206B\u200D\u200C\u206C\u200C\u202C\u206D\u202B\u202B\u200D\u206C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreCrystallizedCatastropheDef.\u202D\u206C\u200F\u206D\u202B\u202E\u202D\u202D\u202E\u206D\u206B\u200C\u200B\u202B\u206B\u200C\u200C\u206A\u202D\u202D\u202B\u202B\u206E\u202A\u200B\u206A\u202C\u206E\u200B\u206C\u200D\u206A\u200F\u202E\u202A\u202C\u202C\u202D\u202A\u202D\u202E(BepinexPlugin.sequenceTable, FlandreCrystallizedCatastropheDef.\u200E\u206B\u206D\u200D\u200C\u206C\u202D\u206A\u202D\u206B\u200B\u206B\u206A\u202B\u202D\u200F\u202A\u206C\u200D\u206C\u206E\u206C\u202D\u202D\u206A\u200F\u202A\u202B\u206D\u202A\u202E\u202B\u202C\u200E\u206A\u200E\u206D\u200E\u202C\u206C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, true, false, true, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red,
				ManaColor.Green,
				ManaColor.Colorless
			}, false, BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Any = 1
			} : new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(40), null, null, null, new int?(16), null, new int?(8), null, new int?(16), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, false, Keyword.Shield, Keyword.Shield, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(560952467),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-591210003),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(844495040)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(411899326),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(274183061),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1289344510)
			}, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-370077178), new List<string>());
		}

		static CardImages \u206D\u200B\u200C\u200F\u206F\u200F\u200F\u206C\u202B\u206E\u206F\u206D\u206D\u202E\u206C\u200E\u206F\u202C\u206B\u206D\u206A\u202D\u206E\u206D\u200D\u206E\u200B\u206D\u202D\u206F\u202A\u200E\u202D\u202C\u206B\u200F\u206B\u202E\u202C\u206E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202C\u200C\u200C\u200E\u202D\u202C\u200E\u206F\u206E\u206B\u200C\u206B\u206A\u206B\u200C\u206E\u202E\u206F\u202E\u202A\u202A\u206B\u200E\u200E\u200B\u206D\u202A\u200C\u200B\u206D\u206B\u206D\u200D\u202E\u202C\u202C\u206F\u206A\u202E\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u206C\u202D\u206D\u200B\u202C\u206F\u200F\u200B\u206B\u202B\u200B\u200C\u206B\u202A\u200F\u202D\u200B\u202B\u202D\u200E\u206A\u200F\u202D\u200B\u202B\u200D\u200F\u206A\u206B\u200D\u200C\u206C\u200C\u202C\u206D\u202B\u202B\u200D\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u206B\u206D\u200D\u200C\u206C\u202D\u206A\u202D\u206B\u200B\u206B\u206A\u202B\u202D\u200F\u202A\u206C\u200D\u206C\u206E\u206C\u202D\u202D\u206A\u200F\u202A\u202B\u206D\u202A\u202E\u202B\u202C\u200E\u206A\u200E\u206D\u200E\u202C\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u206C\u200F\u206D\u202B\u202E\u202D\u202D\u202E\u206D\u206B\u200C\u200B\u202B\u206B\u200C\u200C\u206A\u202D\u202D\u202B\u202B\u206E\u202A\u200B\u206A\u202C\u206E\u200B\u206C\u200D\u206A\u200F\u202E\u202A\u202C\u202C\u202D\u202A\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreCrystallizedCatastropheDef))]
		public sealed class FlandreCrystallizedCatastrophe : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault() * 20;
				}
			}

			public override int AdditionalShield
			{
				get
				{
					return FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault() * 8;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault() * 4;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault() * 8;
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(4 + FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault() * 2, false);
				}
			}

			public int Value4
			{
				get
				{
					return base.FlandreModifier(2 + FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.\u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(this).GetValueOrDefault(), false);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 279726734;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-1235686267 - 2111367214 - (num2 * -266513 - ~(617929416 - -1845854358)))) % 4U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 710497055U) ^ 486298316U);
							continue;
						case 2U:
							base.IsCrystal = true;
							base.IsMagicalGirl = true;
							num = (int)((num3 * 619281281U) ^ 1234741555U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.<Actions>d__13 <Actions>d__ = new FlandreCrystallizedCatastropheDef.FlandreCrystallizedCatastrophe.<Actions>d__13(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202D\u200C\u202B\u200C\u200D\u202E\u202B\u202B\u206C\u200B\u206B\u200C\u200F\u202B\u200B\u206C\u206B\u202B\u206B\u202B\u200D\u200D\u200B\u206B\u206A\u202C\u206C\u200C\u200D\u202A\u200C\u206D\u206C\u206E\u206D\u200D\u200E\u206A\u202A\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
