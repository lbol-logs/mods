using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaEyeoftheStormDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1736342758);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaEyeoftheStormDef.\u206C\u206A\u202D\u206B\u200B\u202D\u206E\u202E\u200C\u206D\u206F\u202A\u202D\u202E\u206C\u206C\u206E\u200F\u200D\u206D\u202B\u202A\u206E\u206A\u200D\u202B\u202D\u202E\u202C\u200B\u206E\u206C\u200B\u200D\u202B\u202B\u200F\u202C\u200E\u202D\u202E(BepinexPlugin.embeddedSource);
			AyaEyeoftheStormDef.\u200E\u206A\u206F\u202C\u202C\u206A\u206A\u206F\u206F\u200E\u200D\u206D\u200C\u202D\u202D\u206A\u200B\u200B\u206C\u202B\u200D\u202D\u206D\u206C\u200B\u202E\u206A\u200D\u206C\u206F\u206F\u200B\u202A\u206F\u202A\u200B\u200E\u200D\u206A\u206D\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaEyeoftheStormDef.\u200B\u202D\u206B\u202D\u200B\u200C\u206F\u202E\u206B\u200B\u206F\u206E\u206B\u202B\u200D\u202D\u202A\u202A\u202D\u206E\u206E\u206B\u206E\u200B\u200D\u202E\u200B\u206D\u206B\u202D\u200B\u202E\u206E\u206C\u206A\u200C\u200B\u206E\u200C\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaEyeoftheStormDef.\u200D\u206F\u202A\u202E\u200B\u200E\u206C\u202E\u200B\u206C\u200E\u200F\u206A\u202C\u200B\u206A\u206C\u206A\u202B\u206B\u206E\u200F\u200F\u206E\u202B\u206D\u206C\u202A\u200B\u200D\u202E\u206C\u200F\u202B\u200E\u206A\u206D\u206F\u202D\u202B\u202E(BepinexPlugin.sequenceTable, AyaEyeoftheStormDef.\u202A\u200F\u206A\u200B\u200C\u206B\u200F\u202E\u202A\u206A\u206F\u206B\u206A\u206C\u206C\u206D\u206B\u202C\u202C\u200F\u202E\u206A\u206F\u202A\u206D\u206C\u206B\u202A\u202C\u200D\u202D\u200C\u202A\u200F\u200B\u202A\u200D\u206C\u200F\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Any = 2,
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1,
				Red = 1
			}), null, null, null, null, null, new int?(10), null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Block, Keyword.Block, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(906324347),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1440309284)
			}, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(906324347),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1363073021)
			}, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1664671118), new List<string>());
		}

		static CardImages \u206C\u206A\u202D\u206B\u200B\u202D\u206E\u202E\u200C\u206D\u206F\u202A\u202D\u202E\u206C\u206C\u206E\u200F\u200D\u206D\u202B\u202A\u206E\u206A\u200D\u202B\u202D\u202E\u202C\u200B\u206E\u206C\u200B\u200D\u202B\u202B\u200F\u202C\u200E\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200E\u206A\u206F\u202C\u202C\u206A\u206A\u206F\u206F\u200E\u200D\u206D\u200C\u202D\u202D\u206A\u200B\u200B\u206C\u202B\u200D\u202D\u206D\u206C\u200B\u202E\u206A\u200D\u206C\u206F\u206F\u200B\u202A\u206F\u202A\u200B\u200E\u200D\u206A\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200B\u202D\u206B\u202D\u200B\u200C\u206F\u202E\u206B\u200B\u206F\u206E\u206B\u202B\u200D\u202D\u202A\u202A\u202D\u206E\u206E\u206B\u206E\u200B\u200D\u202E\u200B\u206D\u206B\u202D\u200B\u202E\u206E\u206C\u206A\u200C\u200B\u206E\u200C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u200F\u206A\u200B\u200C\u206B\u200F\u202E\u202A\u206A\u206F\u206B\u206A\u206C\u206C\u206D\u206B\u202C\u202C\u200F\u202E\u206A\u206F\u202A\u206D\u206C\u206B\u202A\u202C\u200D\u202D\u200C\u202A\u200F\u200B\u202A\u200D\u206C\u200F\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206F\u202A\u202E\u200B\u200E\u206C\u202E\u200B\u206C\u200E\u200F\u206A\u202C\u200B\u206A\u206C\u206A\u202B\u206B\u206E\u200F\u200F\u206E\u202B\u206D\u206C\u202A\u200B\u200D\u202E\u206C\u200F\u202B\u200E\u206A\u206D\u206F\u202D\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaEyeoftheStormDef))]
		public sealed class AyaEyeoftheStorm : Card
		{
			public override int AdditionalBlock
			{
				get
				{
					if (AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202C\u206B\u202B\u206E\u202E\u202C\u206B\u206F\u206C\u206D\u206C\u202B\u200E\u206B\u202C\u202D\u202C\u200E\u202A\u200F\u206A\u200C\u206B\u200F\u200E\u206E\u200B\u202C\u200C\u206D\u206F\u200C\u202D\u202A\u202E\u206B\u202D\u202C\u202D\u206A\u202E(this) != null)
					{
						AyaAccelerationSeDef.AyaAccelerationSe ayaAccelerationSe;
						for (;;)
						{
							IL_000B:
							int num = 665863333;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(((-1955838797 ^ 406327485) - (-341149327 ^ 1575316424) - (num2 + (-2110559122 + -668950953 + -2007686523 * -1449298107 + ((816465942 + -362686766) ^ (1420905009 - -250847387))))) * -2022024061 - 1662669502)) % 5U)
								{
								case 0U:
									return 0;
								case 2U:
									goto IL_000B;
								case 3U:
									goto IL_0085;
								case 4U:
									num = (int)((AyaEyeoftheStormDef.AyaEyeoftheStorm.\u206F\u202B\u200B\u200F\u202B\u206B\u206F\u206A\u206E\u200B\u200C\u206E\u200B\u200E\u202A\u200E\u200E\u206B\u200E\u200F\u206D\u200F\u202C\u206D\u202E\u206E\u202C\u202D\u200E\u200E\u200D\u202B\u206D\u206A\u202D\u200F\u206F\u200E\u200F\u202A\u202E(AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202C\u206B\u202B\u206E\u202E\u202C\u206B\u206F\u206C\u206D\u206C\u202B\u200E\u206B\u202C\u202D\u202C\u200E\u202A\u200F\u206A\u200C\u206B\u200F\u200E\u206E\u200B\u202C\u200C\u206D\u206F\u200C\u202D\u202A\u202E\u206B\u202D\u202C\u202D\u206A\u202E(this)).TryGetStatusEffect<AyaAccelerationSeDef.AyaAccelerationSe>(out ayaAccelerationSe) ? 2604611767U : 960441613U) ^ (num3 * 4147521237U));
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 0;
						IL_0085:
						return AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202B\u206E\u200F\u202C\u202A\u200F\u202D\u206D\u200E\u200B\u202D\u202C\u202D\u200B\u202A\u202A\u200C\u206A\u200B\u202E\u206C\u200B\u206E\u202E\u200D\u206A\u206C\u202C\u202E\u202A\u200D\u206D\u206C\u202B\u202A\u206F\u206D\u206F\u202C\u202A\u202E(ayaAccelerationSe);
					}
					return 0;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					if (AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202C\u206B\u202B\u206E\u202E\u202C\u206B\u206F\u206C\u206D\u206C\u202B\u200E\u206B\u202C\u202D\u202C\u200E\u202A\u200F\u206A\u200C\u206B\u200F\u200E\u206E\u200B\u202C\u200C\u206D\u206F\u200C\u202D\u202A\u202E\u206B\u202D\u202C\u202D\u206A\u202E(this) != null)
					{
						AyaAccelerationSeDef.AyaAccelerationSe ayaAccelerationSe;
						for (;;)
						{
							IL_000B:
							int num = -665434382;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((num2 + -(-83559607 ^ ~1555345484) + ((1722072139 * 660467191) ^ (2015758841 ^ 1319780323))) * -1442456253 + -37067426)) % 5U)
								{
								case 0U:
									goto IL_000B;
								case 1U:
									goto IL_0090;
								case 3U:
									num = (int)((AyaEyeoftheStormDef.AyaEyeoftheStorm.\u206F\u202B\u200B\u200F\u202B\u206B\u206F\u206A\u206E\u200B\u200C\u206E\u200B\u200E\u202A\u200E\u200E\u206B\u200E\u200F\u206D\u200F\u202C\u206D\u202E\u206E\u202C\u202D\u200E\u200E\u200D\u202B\u206D\u206A\u202D\u200F\u206F\u200E\u200F\u202A\u202E(AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202C\u206B\u202B\u206E\u202E\u202C\u206B\u206F\u206C\u206D\u206C\u202B\u200E\u206B\u202C\u202D\u202C\u200E\u202A\u200F\u206A\u200C\u206B\u200F\u200E\u206E\u200B\u202C\u200C\u206D\u206F\u200C\u202D\u202A\u202E\u206B\u202D\u202C\u202D\u206A\u202E(this)).TryGetStatusEffect<AyaAccelerationSeDef.AyaAccelerationSe>(out ayaAccelerationSe) ? 3189860624U : 110948567U) ^ (num3 * 423826192U));
									continue;
								case 4U:
									return 0;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 0;
						IL_0090:
						return AyaEyeoftheStormDef.AyaEyeoftheStorm.\u202B\u206E\u200F\u202C\u202A\u200F\u202D\u206D\u200E\u200B\u202D\u202C\u202D\u200B\u202A\u202A\u200C\u206A\u200B\u202E\u206C\u200B\u206E\u202E\u200D\u206A\u206C\u202C\u202E\u202A\u200D\u206D\u206C\u202B\u202A\u206F\u206D\u206F\u202C\u202A\u202E(ayaAccelerationSe);
					}
					return 0;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaEyeoftheStormDef.AyaEyeoftheStorm.<Actions>d__4 <Actions>d__ = new AyaEyeoftheStormDef.AyaEyeoftheStorm.<Actions>d__4(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static BattleController \u202C\u206B\u202B\u206E\u202E\u202C\u206B\u206F\u206C\u206D\u206C\u202B\u200E\u206B\u202C\u202D\u202C\u200E\u202A\u200F\u206A\u200C\u206B\u200F\u200E\u206E\u200B\u202C\u200C\u206D\u206F\u200C\u202D\u202A\u202E\u206B\u202D\u202C\u202D\u206A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206F\u202B\u200B\u200F\u202B\u206B\u206F\u206A\u206E\u200B\u200C\u206E\u200B\u200E\u202A\u200E\u200E\u206B\u200E\u200F\u206D\u200F\u202C\u206D\u202E\u206E\u202C\u202D\u200E\u200E\u200D\u202B\u206D\u206A\u202D\u200F\u206F\u200E\u200F\u202A\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static int \u202B\u206E\u200F\u202C\u202A\u200F\u202D\u206D\u200E\u200B\u202D\u202C\u202D\u200B\u202A\u202A\u200C\u206A\u200B\u202E\u206C\u200B\u206E\u202E\u200D\u206A\u206C\u202C\u202E\u202A\u200D\u206D\u206C\u202B\u202A\u206F\u206D\u206F\u202C\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}
		}
	}
}
