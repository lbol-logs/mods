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
	public sealed class FlandreLittleJewelerDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1389889797);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreLittleJewelerDef.\u206A\u202C\u200B\u206B\u200D\u202B\u200D\u206D\u202B\u206A\u200D\u202C\u200B\u206C\u200B\u202B\u202E\u202D\u206B\u200D\u206A\u202E\u200F\u206B\u202A\u200E\u202C\u200D\u202D\u206E\u206D\u206A\u200D\u200D\u206C\u206D\u206B\u206B\u206E\u202B\u202E(BepinexPlugin.embeddedSource);
			FlandreLittleJewelerDef.\u206A\u206A\u202C\u200E\u206C\u200E\u202D\u206A\u206F\u200E\u202D\u206B\u200F\u202B\u206A\u200C\u200E\u206A\u202E\u200C\u202E\u206F\u206E\u200C\u202D\u206E\u200E\u206D\u206E\u202D\u200B\u202B\u200B\u200D\u206A\u206D\u206B\u202C\u206D\u202A\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreLittleJewelerDef.\u206C\u206A\u200B\u202E\u206B\u206F\u200E\u206A\u202E\u200D\u202C\u202A\u202A\u200B\u200D\u200E\u206F\u200B\u202C\u202A\u202E\u200C\u202D\u202E\u202B\u206F\u206C\u202E\u206D\u202E\u206F\u202B\u200F\u206B\u206D\u202B\u206B\u202E\u206C\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreLittleJewelerDef.\u202B\u200C\u202C\u206A\u206C\u200C\u206A\u206B\u206D\u200F\u206F\u202C\u206B\u202D\u206D\u202D\u206E\u200E\u206A\u200F\u206D\u206E\u206D\u206F\u202E\u200C\u200E\u206A\u202C\u200B\u202A\u202C\u202B\u206F\u206D\u200E\u200C\u206B\u206B\u202A\u202E(BepinexPlugin.sequenceTable, FlandreLittleJewelerDef.\u202A\u206D\u202E\u206B\u200C\u200B\u200C\u200C\u206A\u206D\u200B\u202A\u202B\u200F\u206A\u206C\u200C\u206B\u202D\u202E\u200C\u206B\u206E\u206B\u202D\u200E\u202D\u200B\u206A\u206F\u200F\u200B\u206C\u200C\u202B\u200F\u200E\u206E\u200E\u200C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Common, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Black = 2
			}, null, null, null, null, null, null, null, null, null, null, new int?(3), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(479190102),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1441848779),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1938530611),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1249231968)
			}, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(479190102),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1969546793),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(836279944),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1249231968)
			}, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(216083197), new List<string>());
		}

		static CardImages \u206A\u202C\u200B\u206B\u200D\u202B\u200D\u206D\u202B\u206A\u200D\u202C\u200B\u206C\u200B\u202B\u202E\u202D\u206B\u200D\u206A\u202E\u200F\u206B\u202A\u200E\u202C\u200D\u202D\u206E\u206D\u206A\u200D\u200D\u206C\u206D\u206B\u206B\u206E\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206A\u206A\u202C\u200E\u206C\u200E\u202D\u206A\u206F\u200E\u202D\u206B\u200F\u202B\u206A\u200C\u200E\u206A\u202E\u200C\u202E\u206F\u206E\u200C\u202D\u206E\u200E\u206D\u206E\u202D\u200B\u202B\u200B\u200D\u206A\u206D\u206B\u202C\u206D\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u206A\u200B\u202E\u206B\u206F\u200E\u206A\u202E\u200D\u202C\u202A\u202A\u200B\u200D\u200E\u206F\u200B\u202C\u202A\u202E\u200C\u202D\u202E\u202B\u206F\u206C\u202E\u206D\u202E\u206F\u202B\u200F\u206B\u206D\u202B\u206B\u202E\u206C\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u206D\u202E\u206B\u200C\u200B\u200C\u200C\u206A\u206D\u200B\u202A\u202B\u200F\u206A\u206C\u200C\u206B\u202D\u202E\u200C\u206B\u206E\u206B\u202D\u200E\u202D\u200B\u206A\u206F\u200F\u200B\u206C\u200C\u202B\u200F\u200E\u206E\u200E\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u200C\u202C\u206A\u206C\u200C\u206A\u206B\u206D\u200F\u206F\u202C\u206B\u202D\u206D\u202D\u206E\u200E\u206A\u200F\u206D\u206E\u206D\u206F\u202E\u200C\u200E\u206A\u202C\u200B\u202A\u202C\u202B\u206F\u206D\u200E\u200C\u206B\u206B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreLittleJewelerDef))]
		public sealed class FlandreLittleJeweler : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreLittleJewelerDef.FlandreLittleJeweler.\u200D\u200B\u200C\u206D\u200F\u200D\u206A\u206E\u200D\u200D\u202E\u200C\u202D\u202E\u200E\u206E\u206D\u202E\u200D\u200B\u206F\u200C\u202A\u202B\u206E\u202D\u202E\u202D\u202A\u206E\u202D\u206E\u206A\u206D\u200D\u202A\u206D\u202A\u200E\u202B\u202E(this).GetValueOrDefault();
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreLittleJewelerDef.FlandreLittleJeweler.\u206B\u202A\u200D\u202A\u200E\u202D\u206F\u200B\u202D\u202B\u202A\u206F\u206C\u206C\u202D\u200B\u202D\u206E\u200B\u200D\u202B\u202B\u202B\u202D\u202E\u206A\u200E\u202C\u202E\u200E\u200C\u206A\u200E\u202A\u200B\u200C\u206E\u200C\u200D\u206F\u202E((float)FlandreLittleJewelerDef.FlandreLittleJeweler.\u200D\u200B\u200C\u206D\u200F\u200D\u206A\u206E\u200D\u200D\u202E\u200C\u202D\u202E\u200E\u206E\u206D\u202E\u200D\u200B\u206F\u200C\u202A\u202B\u206E\u202D\u202E\u202D\u202A\u206E\u202D\u206E\u206A\u206D\u200D\u202A\u206D\u202A\u200E\u202B\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public float Value3
			{
				get
				{
					return (float)FlandreLittleJewelerDef.FlandreLittleJeweler.\u206B\u202A\u200D\u202A\u200E\u202D\u206F\u200B\u202D\u202B\u202A\u206F\u206C\u206C\u202D\u200B\u202D\u206E\u200B\u200D\u202B\u202B\u202B\u202D\u202E\u206A\u200E\u202C\u202E\u200E\u200C\u206A\u200E\u202A\u200B\u200C\u206E\u200C\u200D\u206F\u202E((float)FlandreLittleJewelerDef.FlandreLittleJeweler.\u200D\u200B\u200C\u206D\u200F\u200D\u206A\u206E\u200D\u200D\u202E\u200C\u202D\u202E\u200E\u206E\u206D\u202E\u200D\u200B\u206F\u200C\u202A\u202B\u206E\u202D\u202E\u202D\u202A\u206E\u202D\u206E\u206A\u206D\u200D\u202A\u206D\u202A\u200E\u202B\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			protected override string GetBaseDescription()
			{
				if (this.Value3 <= 0f)
				{
					for (;;)
					{
						int num = -1633473748;
						switch (-(--1224832082 - (num - ~(-137172036 - (1208516050 + -1205812476)))) % 3)
						{
						case 1:
							goto IL_0047;
						case 2:
							continue;
						}
						break;
					}
					goto IL_005D;
					IL_0047:
					return base.GetBaseDescription();
				}
				IL_005D:
				return base.ExtraDescription1;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreLittleJewelerDef.FlandreLittleJeweler.<EnumerateRelativeCards>d__7 <EnumerateRelativeCards>d__ = new FlandreLittleJewelerDef.FlandreLittleJeweler.<EnumerateRelativeCards>d__7(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -1265478256;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(num2 * 300705235 + 1168251860) + -2119019205)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 3948809479U) ^ 2217914836U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreLittleJewelerDef.FlandreLittleJeweler.<Actions>d__9 <Actions>d__ = new FlandreLittleJewelerDef.FlandreLittleJeweler.<Actions>d__9(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u200D\u200B\u200C\u206D\u200F\u200D\u206A\u206E\u200D\u200D\u202E\u200C\u202D\u202E\u200E\u206E\u206D\u202E\u200D\u200B\u206F\u200C\u202A\u202B\u206E\u202D\u202E\u202D\u202A\u206E\u202D\u206E\u206A\u206D\u200D\u202A\u206D\u202A\u200E\u202B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206B\u202A\u200D\u202A\u200E\u202D\u206F\u200B\u202D\u202B\u202A\u206F\u206C\u206C\u202D\u200B\u202D\u206E\u200B\u200D\u202B\u202B\u202B\u202D\u202E\u206A\u200E\u202C\u202E\u200E\u200C\u206A\u200E\u202A\u200B\u200C\u206E\u200C\u200D\u206F\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}
		}
	}
}
