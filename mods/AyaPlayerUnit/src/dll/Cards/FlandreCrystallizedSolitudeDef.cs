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
	public sealed class FlandreCrystallizedSolitudeDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1249231968);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreCrystallizedSolitudeDef.\u206F\u202A\u200B\u206F\u206D\u206E\u202C\u206B\u206A\u202E\u200B\u206C\u202D\u200E\u206C\u206E\u200B\u202A\u206D\u200F\u202E\u200E\u202A\u202D\u202C\u206C\u202C\u202E\u206F\u202E\u200C\u206F\u206A\u200D\u206C\u202B\u202B\u200E\u206B\u202A\u202E(BepinexPlugin.embeddedSource);
			FlandreCrystallizedSolitudeDef.\u200D\u200B\u206E\u202D\u200D\u202B\u202D\u202D\u200C\u206E\u206B\u200F\u200F\u206D\u206D\u206F\u202E\u206F\u200C\u200E\u206F\u200D\u202A\u206F\u206C\u202E\u206A\u200B\u206A\u202B\u206F\u202E\u202B\u206A\u202D\u202E\u206E\u206B\u200C\u200C\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreCrystallizedSolitudeDef.\u206B\u206E\u200B\u202B\u202E\u206A\u200E\u206C\u202D\u200F\u202A\u206C\u206C\u206D\u200C\u206F\u206C\u206F\u200F\u202A\u206E\u206B\u200E\u202D\u206C\u200E\u206D\u206B\u206D\u206C\u200D\u206D\u202A\u200E\u200E\u202A\u200E\u200B\u202C\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreCrystallizedSolitudeDef.\u206B\u206B\u202D\u202D\u200B\u202B\u206E\u200C\u206A\u206E\u200B\u206E\u206C\u206F\u200C\u200B\u202C\u200D\u202B\u206B\u202B\u206D\u202C\u206E\u202E\u202B\u200D\u206A\u206E\u200B\u206A\u206D\u206A\u206B\u202B\u202E\u206B\u202E\u206E\u206A\u202E(BepinexPlugin.sequenceTable, FlandreCrystallizedSolitudeDef.\u206B\u206B\u200C\u206A\u206E\u200C\u200D\u202B\u206E\u202C\u206D\u206B\u206E\u206C\u202E\u202C\u200D\u202D\u206F\u202B\u206C\u206B\u200E\u202A\u202C\u202E\u200B\u206A\u206B\u202E\u202E\u206E\u202D\u200F\u202A\u202C\u200E\u200F\u206D\u202E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2112818087), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1041778511), 0, false, false, false, true, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Blue }, false, BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Any = 1
			} : new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(10), null, null, null, new int?(8), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, Keyword.Accuracy | Keyword.Exile | Keyword.Replenish, false, Keyword.Shield, Keyword.Shield, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1037822697) }, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(844495040) }, new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, "", new List<string>());
		}

		static CardImages \u206F\u202A\u200B\u206F\u206D\u206E\u202C\u206B\u206A\u202E\u200B\u206C\u202D\u200E\u206C\u206E\u200B\u202A\u206D\u200F\u202E\u200E\u202A\u202D\u202C\u206C\u202C\u202E\u206F\u202E\u200C\u206F\u206A\u200D\u206C\u202B\u202B\u200E\u206B\u202A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u200B\u206E\u202D\u200D\u202B\u202D\u202D\u200C\u206E\u206B\u200F\u200F\u206D\u206D\u206F\u202E\u206F\u200C\u200E\u206F\u200D\u202A\u206F\u206C\u202E\u206A\u200B\u206A\u202B\u206F\u202E\u202B\u206A\u202D\u202E\u206E\u206B\u200C\u200C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206B\u206E\u200B\u202B\u202E\u206A\u200E\u206C\u202D\u200F\u202A\u206C\u206C\u206D\u200C\u206F\u206C\u206F\u200F\u202A\u206E\u206B\u200E\u202D\u206C\u200E\u206D\u206B\u206D\u206C\u200D\u206D\u202A\u200E\u200E\u202A\u200E\u200B\u202C\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u206B\u200C\u206A\u206E\u200C\u200D\u202B\u206E\u202C\u206D\u206B\u206E\u206C\u202E\u202C\u200D\u202D\u206F\u202B\u206C\u206B\u200E\u202A\u202C\u202E\u200B\u206A\u206B\u202E\u202E\u206E\u202D\u200F\u202A\u202C\u200E\u200F\u206D\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u206B\u202D\u202D\u200B\u202B\u206E\u200C\u206A\u206E\u200B\u206E\u206C\u206F\u200C\u200B\u202C\u200D\u202B\u206B\u202B\u206D\u202C\u206E\u202E\u202B\u200D\u206A\u206E\u200B\u206A\u206D\u206A\u206B\u202B\u202E\u206B\u202E\u206E\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreCrystallizedSolitudeDef))]
		public sealed class FlandreCrystallizedSolitude : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.\u202E\u202D\u206A\u206F\u202A\u200B\u206F\u206F\u200F\u206D\u206C\u200C\u202B\u206C\u200E\u200D\u200D\u202A\u202A\u206D\u206B\u200B\u200C\u206B\u202B\u206E\u206D\u202A\u202B\u200C\u206F\u200D\u200E\u200D\u202A\u200E\u200D\u202D\u200E\u202B\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override int AdditionalShield
			{
				get
				{
					return FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.\u202E\u202D\u206A\u206F\u202A\u200B\u206F\u206F\u200F\u206D\u206C\u200C\u202B\u206C\u200E\u200D\u200D\u202A\u202A\u206D\u206B\u200B\u200C\u206B\u202B\u206E\u206D\u202A\u202B\u200C\u206F\u200D\u200E\u200D\u202A\u200E\u200D\u202D\u200E\u202B\u202E(this).GetValueOrDefault() * 4;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.\u202A\u206D\u202D\u200F\u200B\u202E\u206D\u206E\u200E\u206C\u202D\u200C\u200B\u200C\u206C\u206A\u200C\u206F\u206F\u202E\u202A\u200E\u206E\u200B\u206B\u200E\u200B\u206A\u206F\u200F\u206E\u200F\u200B\u202A\u206E\u200D\u206C\u206E\u202A\u206A\u202E((float)FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.\u202E\u202D\u206A\u206F\u202A\u200B\u206F\u206F\u200F\u206D\u206C\u200C\u202B\u206C\u200E\u200D\u200D\u202A\u202A\u206D\u206B\u200B\u200C\u206B\u202B\u206E\u206D\u202A\u202B\u200C\u206F\u200D\u200E\u200D\u202A\u200E\u200D\u202D\u200E\u202B\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -152837082;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-num2 ^ ~(--658738418)))) % 4U)
						{
						case 1U:
							base.IsCrystal = true;
							base.IsMagicalGirl = true;
							num = (int)((num3 * 2177563846U) ^ 941338126U);
							continue;
						case 2U:
							goto IL_0006;
						case 3U:
							base.IsRandom = true;
							num = (int)((num3 * 1060164266U) ^ 904881533U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.<Actions>d__7 <Actions>d__ = new FlandreCrystallizedSolitudeDef.FlandreCrystallizedSolitude.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static int? \u202E\u202D\u206A\u206F\u202A\u200B\u206F\u206F\u200F\u206D\u206C\u200C\u202B\u206C\u200E\u200D\u200D\u202A\u202A\u206D\u206B\u200B\u200C\u206B\u202B\u206E\u206D\u202A\u202B\u200C\u206F\u200D\u200E\u200D\u202A\u200E\u200D\u202D\u200E\u202B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202A\u206D\u202D\u200F\u200B\u202E\u206D\u206E\u200E\u206C\u202D\u200C\u200B\u200C\u206C\u206A\u200C\u206F\u206F\u202E\u202A\u200E\u206E\u200B\u206B\u200E\u200B\u206A\u206F\u200F\u206E\u200F\u200B\u202A\u206E\u200D\u206C\u206E\u202A\u206A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}
		}
	}
}
