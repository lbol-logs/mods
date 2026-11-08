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
	public sealed class FlandreChaosIncarnationDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(292700338);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreChaosIncarnationDef.\u200E\u202B\u200E\u202C\u202C\u202D\u200F\u200F\u200B\u202E\u202A\u206F\u202C\u206E\u202D\u206A\u206A\u202C\u200C\u202A\u202D\u200B\u206A\u200B\u202B\u202D\u206A\u200B\u202C\u200D\u200B\u202C\u200C\u200C\u202A\u200F\u202C\u206F\u200F\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreChaosIncarnationDef.\u200B\u206D\u200B\u202C\u202B\u202E\u206E\u206A\u200F\u206C\u200D\u202A\u202B\u206D\u206F\u206D\u206B\u206A\u202B\u200E\u206C\u206B\u200F\u206E\u200E\u202C\u202E\u206F\u200E\u206A\u206E\u202D\u202B\u206E\u206D\u202D\u206E\u202E\u206B\u200E\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), true);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreChaosIncarnationDef.\u200B\u206A\u200E\u206B\u206A\u202D\u206A\u200D\u202E\u200D\u206E\u202C\u200F\u202E\u206E\u202E\u200F\u206B\u206D\u200E\u202D\u200E\u206C\u206F\u202A\u206D\u200D\u206B\u202B\u200B\u206D\u200C\u200F\u206B\u206F\u206B\u200F\u200B\u200F\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreChaosIncarnationDef.\u206D\u206E\u200F\u202D\u200F\u202A\u202C\u202A\u206F\u202C\u202D\u206F\u200C\u206D\u200F\u200C\u200F\u202A\u202D\u200B\u206A\u200B\u202B\u206B\u206A\u202E\u206E\u206D\u206E\u200D\u206C\u200E\u202E\u206A\u200C\u206A\u202B\u206E\u200B\u200F\u202E(BepinexPlugin.sequenceTable, FlandreChaosIncarnationDef.\u200C\u202D\u200B\u206D\u206C\u200B\u206F\u200B\u206F\u206B\u202B\u206B\u200F\u206C\u206A\u202E\u202C\u202E\u206F\u202C\u206E\u206D\u206F\u202E\u202E\u200B\u206A\u206B\u202E\u202D\u202A\u202D\u200C\u206E\u206B\u202B\u200D\u206E\u200E\u206E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, true, true, Rarity.Rare, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 3,
				Hybrid = 1,
				HybridColor = 7
			}, null, null, null, null, null, null, new int?(24), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Block, Keyword.Block, new List<string>(), new List<string>(), new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(479190102),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1710678102),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1631438369),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1293329945)
			}, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(479190102),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1710678102),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1946307858),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1293329945)
			}, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1595692644), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(778235771), false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-632668205), new List<string>());
		}

		static CardImages \u200E\u202B\u200E\u202C\u202C\u202D\u200F\u200F\u200B\u202E\u202A\u206F\u202C\u206E\u202D\u206A\u206A\u202C\u200C\u202A\u202D\u200B\u206A\u200B\u202B\u202D\u206A\u200B\u202C\u200D\u200B\u202C\u200C\u200C\u202A\u200F\u202C\u206F\u200F\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200B\u206D\u200B\u202C\u202B\u202E\u206E\u206A\u200F\u206C\u200D\u202A\u202B\u206D\u206F\u206D\u206B\u206A\u202B\u200E\u206C\u206B\u200F\u206E\u200E\u202C\u202E\u206F\u200E\u206A\u206E\u202D\u202B\u206E\u206D\u202D\u206E\u202E\u206B\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200B\u206A\u200E\u206B\u206A\u202D\u206A\u200D\u202E\u200D\u206E\u202C\u200F\u202E\u206E\u202E\u200F\u206B\u206D\u200E\u202D\u200E\u206C\u206F\u202A\u206D\u200D\u206B\u202B\u200B\u206D\u200C\u200F\u206B\u206F\u206B\u200F\u200B\u200F\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200C\u202D\u200B\u206D\u206C\u200B\u206F\u200B\u206F\u206B\u202B\u206B\u200F\u206C\u206A\u202E\u202C\u202E\u206F\u202C\u206E\u206D\u206F\u202E\u202E\u200B\u206A\u206B\u202E\u202D\u202A\u202D\u200C\u206E\u206B\u202B\u200D\u206E\u200E\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u206E\u200F\u202D\u200F\u202A\u202C\u202A\u206F\u202C\u202D\u206F\u200C\u206D\u200F\u200C\u200F\u202A\u202D\u200B\u206A\u200B\u202B\u206B\u206A\u202E\u206E\u206D\u206E\u200D\u206C\u200E\u202E\u206A\u200C\u206A\u202B\u206E\u200B\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreChaosIncarnationDef))]
		public sealed class FlandreChaosIncarnation : FlandreCard
		{
			public override int AdditionalBlock
			{
				get
				{
					return FlandreChaosIncarnationDef.FlandreChaosIncarnation.\u202B\u206F\u200B\u200F\u200C\u206F\u202D\u200C\u200D\u200B\u200E\u206D\u206F\u206C\u200B\u206F\u202E\u206B\u202E\u202E\u200C\u200C\u206C\u206B\u200F\u202D\u200F\u202A\u202D\u202D\u200C\u206C\u200F\u202D\u202E\u206B\u200B\u200F\u202A\u206A\u202E(this).GetValueOrDefault() * 8;
				}
			}

			public float Value3
			{
				get
				{
					return (float)FlandreChaosIncarnationDef.FlandreChaosIncarnation.\u202D\u202C\u200C\u202B\u202D\u200D\u206A\u206E\u202A\u206F\u202E\u200F\u200F\u202B\u202B\u206E\u202C\u206F\u202E\u202A\u200D\u200F\u202E\u202E\u202C\u200E\u200F\u200D\u206F\u200B\u202E\u202E\u200B\u200D\u202E\u206D\u206F\u200D\u200B\u206B\u202E((float)FlandreChaosIncarnationDef.FlandreChaosIncarnation.\u202B\u206F\u200B\u200F\u200C\u206F\u202D\u200C\u200D\u200B\u200E\u206D\u206F\u206C\u200B\u206F\u202E\u206B\u202E\u202E\u200C\u200C\u206C\u206B\u200F\u202D\u200F\u202A\u202D\u202D\u200C\u206C\u200F\u202D\u202E\u206B\u200B\u200F\u202A\u206A\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			protected override string GetBaseDescription()
			{
				if (this.Value3 <= 0f)
				{
					for (;;)
					{
						int num = -1144581637;
						switch (~(-(num * -1246726629 + -178567035)) % 3)
						{
						case 1:
							goto IL_0039;
						case 2:
							continue;
						}
						break;
					}
					goto IL_004F;
					IL_0039:
					return base.GetBaseDescription();
				}
				IL_004F:
				return base.ExtraDescription1;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreChaosIncarnationDef.FlandreChaosIncarnation.<EnumerateRelativeCards>d__5 <EnumerateRelativeCards>d__ = new FlandreChaosIncarnationDef.FlandreChaosIncarnation.<EnumerateRelativeCards>d__5(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -823959861;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(num2 * -968903397) ^ (-1496505125 - -1248578989)))) % 4U)
						{
						case 0U:
							base.IsRandom = true;
							num = (int)((num3 * 1950395754U) ^ 2051454742U);
							continue;
						case 1U:
							base.IsBloodlust = true;
							num = (int)((num3 * 625116933U) ^ 3770636909U);
							continue;
						case 3U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreChaosIncarnationDef.FlandreChaosIncarnation.<Actions>d__7 <Actions>d__ = new FlandreChaosIncarnationDef.FlandreChaosIncarnation.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202B\u206F\u200B\u200F\u200C\u206F\u202D\u200C\u200D\u200B\u200E\u206D\u206F\u206C\u200B\u206F\u202E\u206B\u202E\u202E\u200C\u200C\u206C\u206B\u200F\u202D\u200F\u202A\u202D\u202D\u200C\u206C\u200F\u202D\u202E\u206B\u200B\u200F\u202A\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202D\u202C\u200C\u202B\u202D\u200D\u206A\u206E\u202A\u206F\u202E\u200F\u200F\u202B\u202B\u206E\u202C\u206F\u202E\u202A\u200D\u200F\u202E\u202E\u202C\u200E\u200F\u200D\u206F\u200B\u202E\u202E\u200B\u200D\u202E\u206D\u206F\u200D\u200B\u206B\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}
		}
	}
}
