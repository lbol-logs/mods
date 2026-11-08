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
	public sealed class FlandreFaustianBargainDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(113495912);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFaustianBargainDef.\u200D\u200E\u202D\u200D\u202B\u202B\u206F\u206F\u200F\u200D\u206A\u200C\u206C\u206F\u206F\u206C\u206F\u200C\u200F\u206B\u206E\u206A\u206D\u202D\u206D\u202E\u206D\u206F\u202A\u202C\u206A\u202E\u200E\u200F\u206A\u200B\u200C\u200E\u206D\u202A\u202E(BepinexPlugin.embeddedSource);
			FlandreFaustianBargainDef.\u206B\u200B\u206A\u206F\u200C\u206E\u206C\u206E\u206F\u206C\u202B\u202D\u202E\u206D\u206F\u202E\u206E\u206B\u206C\u200F\u200E\u200B\u200E\u200D\u200C\u206B\u206A\u206B\u200D\u202B\u200E\u206D\u202B\u200D\u206D\u202E\u200C\u206F\u202E\u202C\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFaustianBargainDef.\u206D\u206B\u200C\u200F\u202B\u202B\u200D\u206F\u206A\u202E\u200F\u200C\u200E\u206E\u206C\u206D\u206E\u200E\u202E\u206B\u200C\u206C\u200F\u202B\u206A\u202B\u206E\u206C\u206E\u200F\u206F\u202A\u206B\u206A\u206E\u202C\u200E\u200D\u206B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFaustianBargainDef.\u206E\u200F\u200B\u200F\u200D\u202C\u200F\u202A\u206B\u202B\u202D\u206F\u200C\u202D\u200F\u200F\u202D\u202C\u200C\u206E\u206D\u202D\u206A\u200B\u206F\u202A\u200C\u202E\u206A\u206F\u202B\u200E\u200C\u202D\u206A\u202E\u202B\u200C\u206F\u206E\u202E(BepinexPlugin.sequenceTable, FlandreFaustianBargainDef.\u206A\u202A\u206A\u202E\u202B\u206D\u200B\u200F\u202C\u200D\u206D\u200E\u206A\u202E\u202C\u206F\u200B\u202D\u206E\u202A\u200F\u202E\u200F\u206F\u202B\u206C\u202E\u200F\u202A\u202A\u202C\u202A\u206D\u206E\u200B\u202A\u200B\u206C\u206E\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, true, true, false, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			}, false, new ManaGroup
			{
				Any = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, new int?(2), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Exile, Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1320742010), new List<string>());
		}

		static CardImages \u200D\u200E\u202D\u200D\u202B\u202B\u206F\u206F\u200F\u200D\u206A\u200C\u206C\u206F\u206F\u206C\u206F\u200C\u200F\u206B\u206E\u206A\u206D\u202D\u206D\u202E\u206D\u206F\u202A\u202C\u206A\u202E\u200E\u200F\u206A\u200B\u200C\u200E\u206D\u202A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u200B\u206A\u206F\u200C\u206E\u206C\u206E\u206F\u206C\u202B\u202D\u202E\u206D\u206F\u202E\u206E\u206B\u206C\u200F\u200E\u200B\u200E\u200D\u200C\u206B\u206A\u206B\u200D\u202B\u200E\u206D\u202B\u200D\u206D\u202E\u200C\u206F\u202E\u202C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u206B\u200C\u200F\u202B\u202B\u200D\u206F\u206A\u202E\u200F\u200C\u200E\u206E\u206C\u206D\u206E\u200E\u202E\u206B\u200C\u206C\u200F\u202B\u206A\u202B\u206E\u206C\u206E\u200F\u206F\u202A\u206B\u206A\u206E\u202C\u200E\u200D\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u202A\u206A\u202E\u202B\u206D\u200B\u200F\u202C\u200D\u206D\u200E\u206A\u202E\u202C\u206F\u200B\u202D\u206E\u202A\u200F\u202E\u200F\u206F\u202B\u206C\u202E\u200F\u202A\u202A\u202C\u202A\u206D\u206E\u200B\u202A\u200B\u206C\u206E\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206E\u200F\u200B\u200F\u200D\u202C\u200F\u202A\u206B\u202B\u202D\u206F\u200C\u202D\u200F\u200F\u202D\u202C\u200C\u206E\u206D\u202D\u206A\u200B\u206F\u202A\u200C\u202E\u206A\u206F\u202B\u200E\u200C\u202D\u206A\u202E\u202B\u200C\u206F\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFaustianBargainDef))]
		public sealed class FlandreFaustianBargain : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreFaustianBargainDef.FlandreFaustianBargain.\u200B\u200E\u206B\u202B\u202D\u200E\u202B\u202E\u202C\u206A\u200B\u206A\u200D\u202B\u206F\u206B\u200D\u202C\u200D\u200B\u200F\u206C\u202E\u200D\u200C\u200B\u202C\u206C\u202E\u206E\u206D\u206C\u202B\u200D\u202A\u200B\u202A\u200E\u202A\u202E((float)FlandreFaustianBargainDef.FlandreFaustianBargain.\u206C\u200E\u202A\u202A\u206C\u206E\u200B\u202A\u206C\u206D\u202D\u202D\u202D\u200F\u200C\u202A\u200E\u206F\u200B\u200E\u202A\u200F\u200B\u206A\u200D\u206F\u200F\u206C\u206E\u202E\u206E\u206D\u206D\u206D\u200E\u200E\u202C\u202E\u202B\u200E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public int Value3
			{
				get
				{
					return base.FlandreModifier(1 + FlandreFaustianBargainDef.FlandreFaustianBargain.\u200B\u200E\u206B\u202B\u202D\u200E\u202B\u202E\u202C\u206A\u200B\u206A\u200D\u202B\u206F\u206B\u200D\u202C\u200D\u200B\u200F\u206C\u202E\u200D\u200C\u200B\u202C\u206C\u202E\u206E\u206D\u206C\u202B\u200D\u202A\u200B\u202A\u200E\u202A\u202E((float)FlandreFaustianBargainDef.FlandreFaustianBargain.\u206C\u200E\u202A\u202A\u206C\u206E\u200B\u202A\u206C\u206D\u202D\u202D\u202D\u200F\u200C\u202A\u200E\u206F\u200B\u200E\u202A\u200F\u200B\u206A\u200D\u206F\u200F\u206C\u206E\u202E\u206E\u206D\u206D\u206D\u200E\u200E\u202C\u202E\u202B\u200E\u202E(this).GetValueOrDefault() / 2f), false);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsOffering = true;
				base.OfferingCount = FlandreFaustianBargainDef.FlandreFaustianBargain.\u200F\u206C\u206E\u200C\u202C\u202A\u200B\u200F\u206E\u206F\u202A\u200B\u206B\u202E\u202D\u206D\u206F\u200B\u200F\u206E\u206A\u202A\u206E\u206C\u202D\u202B\u206F\u202D\u202B\u206E\u200C\u202D\u200F\u202B\u206E\u202E\u200B\u200D\u202C\u200F\u202E(this);
			}

			public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
			{
				FlandreFaustianBargainDef.FlandreFaustianBargain.<OnExile>d__5 <OnExile>d__ = new FlandreFaustianBargainDef.FlandreFaustianBargain.<OnExile>d__5(-2);
				<OnExile>d__.<>4__this = this;
				return <OnExile>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFaustianBargainDef.FlandreFaustianBargain.<Actions>d__6 <Actions>d__ = new FlandreFaustianBargainDef.FlandreFaustianBargain.<Actions>d__6(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206C\u200E\u202A\u202A\u206C\u206E\u200B\u202A\u206C\u206D\u202D\u202D\u202D\u200F\u200C\u202A\u200E\u206F\u200B\u200E\u202A\u200F\u200B\u206A\u200D\u206F\u200F\u206C\u206E\u202E\u206E\u206D\u206D\u206D\u200E\u200E\u202C\u202E\u202B\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200B\u200E\u206B\u202B\u202D\u200E\u202B\u202E\u202C\u206A\u200B\u206A\u200D\u202B\u206F\u206B\u200D\u202C\u200D\u200B\u200F\u206C\u202E\u200D\u200C\u200B\u202C\u206C\u202E\u206E\u206D\u206C\u202B\u200D\u202A\u200B\u202A\u200E\u202A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static int \u200F\u206C\u206E\u200C\u202C\u202A\u200B\u200F\u206E\u206F\u202A\u200B\u206B\u202E\u202D\u206D\u206F\u200B\u200F\u206E\u206A\u202A\u206E\u206C\u202D\u202B\u206F\u202D\u202B\u206E\u200C\u202D\u200F\u202B\u206E\u202E\u200B\u200D\u202C\u200F\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
