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
	public sealed class FlandrePathofDestructionDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1195675028);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandrePathofDestructionDef.\u206B\u206C\u202B\u206E\u202C\u206C\u202C\u200F\u206A\u202C\u206B\u206F\u200B\u200C\u200F\u200B\u200E\u200D\u206A\u202D\u200C\u206C\u206A\u202D\u200B\u200D\u202D\u200F\u206D\u202C\u206F\u202C\u200B\u206E\u200C\u206F\u206B\u200F\u200E\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandrePathofDestructionDef.\u206C\u202A\u206F\u202D\u200F\u200E\u200E\u200E\u206E\u202D\u206C\u202D\u206A\u206B\u206C\u206A\u202C\u206B\u202A\u200F\u206F\u202C\u200E\u202B\u202B\u206F\u200C\u202D\u206D\u200F\u200F\u200C\u200F\u202B\u202D\u206D\u206A\u206C\u200D\u202E\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandrePathofDestructionDef.\u206E\u206A\u200B\u206B\u202B\u206F\u200E\u206C\u200F\u202E\u202E\u206C\u202D\u200E\u206E\u202D\u206B\u206D\u206B\u202D\u202A\u202C\u206A\u200D\u202B\u206B\u206E\u206B\u206D\u206C\u200C\u202A\u202E\u200F\u200D\u200C\u206D\u200F\u200F\u206B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandrePathofDestructionDef.\u200F\u200C\u206F\u200D\u202E\u206D\u200F\u202E\u206D\u202A\u200D\u200E\u200B\u200F\u202C\u206B\u200C\u202D\u202B\u200C\u202D\u200D\u206B\u206C\u200F\u202B\u202C\u206A\u202D\u200E\u206F\u202D\u206E\u202C\u202C\u202A\u200C\u200C\u206F\u206F\u202E(BepinexPlugin.sequenceTable, FlandrePathofDestructionDef.\u202A\u206B\u202E\u200C\u200E\u202C\u206F\u200B\u200E\u206F\u200E\u206D\u202E\u206B\u202D\u202C\u200B\u202A\u202E\u200D\u206D\u206B\u202B\u202D\u200B\u202D\u200E\u202C\u206D\u202D\u206E\u206A\u200B\u202B\u202E\u200D\u206A\u202C\u206A\u202B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 7
			}, null, null, null, null, null, null, new int?(16), null, null, null, new int?(1), null, new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Block, Keyword.Block, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-551155386), new List<string>());
		}

		static CardImages \u206B\u206C\u202B\u206E\u202C\u206C\u202C\u200F\u206A\u202C\u206B\u206F\u200B\u200C\u200F\u200B\u200E\u200D\u206A\u202D\u200C\u206C\u206A\u202D\u200B\u200D\u202D\u200F\u206D\u202C\u206F\u202C\u200B\u206E\u200C\u206F\u206B\u200F\u200E\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u202A\u206F\u202D\u200F\u200E\u200E\u200E\u206E\u202D\u206C\u202D\u206A\u206B\u206C\u206A\u202C\u206B\u202A\u200F\u206F\u202C\u200E\u202B\u202B\u206F\u200C\u202D\u206D\u200F\u200F\u200C\u200F\u202B\u202D\u206D\u206A\u206C\u200D\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u206A\u200B\u206B\u202B\u206F\u200E\u206C\u200F\u202E\u202E\u206C\u202D\u200E\u206E\u202D\u206B\u206D\u206B\u202D\u202A\u202C\u206A\u200D\u202B\u206B\u206E\u206B\u206D\u206C\u200C\u202A\u202E\u200F\u200D\u200C\u206D\u200F\u200F\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u206B\u202E\u200C\u200E\u202C\u206F\u200B\u200E\u206F\u200E\u206D\u202E\u206B\u202D\u202C\u200B\u202A\u202E\u200D\u206D\u206B\u202B\u202D\u200B\u202D\u200E\u202C\u206D\u202D\u206E\u206A\u200B\u202B\u202E\u200D\u206A\u202C\u206A\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u200C\u206F\u200D\u202E\u206D\u200F\u202E\u206D\u202A\u200D\u200E\u200B\u200F\u202C\u206B\u200C\u202D\u202B\u200C\u202D\u200D\u206B\u206C\u200F\u202B\u202C\u206A\u202D\u200E\u206F\u202D\u206E\u202C\u202C\u202A\u200C\u200C\u206F\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandrePathofDestructionDef))]
		public sealed class FlandrePathofDestruction : FlandreCard
		{
			public override int AdditionalBlock
			{
				get
				{
					return FlandrePathofDestructionDef.FlandrePathofDestruction.\u200F\u202C\u202C\u200B\u200B\u202D\u200B\u202E\u200C\u202A\u206B\u202C\u200B\u200B\u200C\u202B\u200F\u200F\u206A\u206D\u206B\u200E\u200E\u200D\u206E\u206E\u200C\u206A\u200B\u206B\u202A\u206D\u200F\u202E\u202D\u206E\u200B\u200D\u200E\u200E\u202E(this).GetValueOrDefault() * 6;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandrePathofDestructionDef.FlandrePathofDestruction.\u206A\u206A\u200C\u206F\u202A\u202C\u202E\u206E\u202A\u200E\u202B\u202B\u206E\u206E\u200C\u200B\u200B\u202A\u202B\u202A\u200F\u206E\u200D\u200C\u200D\u200C\u202B\u200D\u206D\u206C\u202B\u202E\u206F\u202A\u200F\u200C\u206B\u206A\u202A\u200C\u202E((float)FlandrePathofDestructionDef.FlandrePathofDestruction.\u200F\u202C\u202C\u200B\u200B\u202D\u200B\u202E\u200C\u202A\u206B\u202C\u200B\u200B\u200C\u202B\u200F\u200F\u206A\u206D\u206B\u200E\u200E\u200D\u206E\u206E\u200C\u206A\u200B\u206B\u202A\u206D\u200F\u202E\u202D\u206E\u200B\u200D\u200E\u200E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 160911896;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)((num2 - 1938457355 * ((-1500201089 - 103326060) ^ (755102586 ^ -612905063))) ^ ((9042882 ^ -1738039688) * 319087693)))) % 4U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.OfferingCount = FlandrePathofDestructionDef.FlandrePathofDestruction.\u202C\u206F\u206C\u206A\u202B\u206B\u202B\u202D\u202C\u200F\u200F\u202B\u202E\u202E\u206E\u206C\u206A\u206B\u200E\u200B\u200E\u206D\u206E\u202C\u206A\u206B\u202E\u202B\u206A\u200B\u206B\u206F\u206D\u206A\u200E\u200C\u200F\u206A\u206A\u206E\u202E(this);
							num = (int)((num3 * 2653556221U) ^ 1854331794U);
							continue;
						case 2U:
							base.IsOffering = true;
							num = (int)((num3 * 4275005511U) ^ 2484247683U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandrePathofDestructionDef.FlandrePathofDestruction.<Actions>d__5 <Actions>d__ = new FlandrePathofDestructionDef.FlandrePathofDestruction.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u200F\u202C\u202C\u200B\u200B\u202D\u200B\u202E\u200C\u202A\u206B\u202C\u200B\u200B\u200C\u202B\u200F\u200F\u206A\u206D\u206B\u200E\u200E\u200D\u206E\u206E\u200C\u206A\u200B\u206B\u202A\u206D\u200F\u202E\u202D\u206E\u200B\u200D\u200E\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206A\u206A\u200C\u206F\u202A\u202C\u202E\u206E\u202A\u200E\u202B\u202B\u206E\u206E\u200C\u200B\u200B\u202A\u202B\u202A\u200F\u206E\u200D\u200C\u200D\u200C\u202B\u200D\u206D\u206C\u202B\u202E\u206F\u202A\u200F\u200C\u206B\u206A\u202A\u200C\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			static int \u202C\u206F\u206C\u206A\u202B\u206B\u202B\u202D\u202C\u200F\u200F\u202B\u202E\u202E\u206E\u206C\u206A\u206B\u200E\u200B\u200E\u206D\u206E\u202C\u206A\u206B\u202E\u202B\u206A\u200B\u206B\u206F\u206D\u206A\u200E\u200C\u200F\u206A\u206A\u206E\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
