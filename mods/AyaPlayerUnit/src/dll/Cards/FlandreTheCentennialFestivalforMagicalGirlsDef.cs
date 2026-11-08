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
	public sealed class FlandreTheCentennialFestivalforMagicalGirlsDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1300935786);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreTheCentennialFestivalforMagicalGirlsDef.\u206E\u202C\u200B\u200C\u200D\u206D\u200E\u206D\u206B\u202E\u206A\u206C\u200B\u202E\u202E\u202A\u206F\u200F\u200B\u200F\u200E\u206C\u202A\u200E\u206E\u206D\u200B\u206A\u202B\u202B\u206C\u206F\u206B\u200B\u206A\u200C\u202C\u202A\u200D\u206A\u202E(BepinexPlugin.embeddedSource);
			FlandreTheCentennialFestivalforMagicalGirlsDef.\u202A\u206F\u206F\u200D\u202E\u206B\u200B\u200E\u202A\u200D\u206E\u202B\u206A\u202E\u206D\u202A\u202A\u206B\u206A\u202E\u200F\u202A\u206C\u202D\u200D\u202B\u202E\u202E\u202B\u200B\u200B\u202A\u202A\u200C\u206F\u200E\u206C\u206D\u200B\u206D\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreTheCentennialFestivalforMagicalGirlsDef.\u206F\u200C\u206C\u200B\u206B\u202D\u202E\u200E\u202B\u206C\u206E\u200F\u206C\u200C\u206F\u202B\u206A\u202E\u202E\u200C\u200D\u200C\u202D\u202D\u202C\u206C\u200E\u200C\u200C\u202D\u200C\u202E\u206F\u200B\u206F\u206B\u202E\u206C\u200E\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreTheCentennialFestivalforMagicalGirlsDef.\u202B\u206E\u200B\u206A\u202C\u206F\u200D\u206D\u200C\u206E\u206F\u200D\u200F\u200E\u206A\u206D\u206E\u200F\u200F\u202C\u206C\u202B\u206D\u200D\u206E\u206B\u206C\u200B\u206E\u200D\u202C\u200E\u206D\u202B\u206E\u200D\u206F\u206A\u202C\u202B\u202E(BepinexPlugin.sequenceTable, FlandreTheCentennialFestivalforMagicalGirlsDef.\u200F\u206F\u200C\u200D\u206C\u200E\u206F\u202B\u200D\u202A\u200B\u202A\u200B\u202C\u206E\u206D\u200F\u202D\u206D\u200C\u202C\u202E\u202D\u202D\u200F\u206F\u202E\u202D\u206A\u206A\u200E\u206F\u200E\u200C\u200C\u200F\u206A\u202C\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, true, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 4,
				White = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(1), null, new int?(0), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Upgrade, Keyword.Upgrade, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(25567232), new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(916900891) });
		}

		static CardImages \u206E\u202C\u200B\u200C\u200D\u206D\u200E\u206D\u206B\u202E\u206A\u206C\u200B\u202E\u202E\u202A\u206F\u200F\u200B\u200F\u200E\u206C\u202A\u200E\u206E\u206D\u200B\u206A\u202B\u202B\u206C\u206F\u206B\u200B\u206A\u200C\u202C\u202A\u200D\u206A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202A\u206F\u206F\u200D\u202E\u206B\u200B\u200E\u202A\u200D\u206E\u202B\u206A\u202E\u206D\u202A\u202A\u206B\u206A\u202E\u200F\u202A\u206C\u202D\u200D\u202B\u202E\u202E\u202B\u200B\u200B\u202A\u202A\u200C\u206F\u200E\u206C\u206D\u200B\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206F\u200C\u206C\u200B\u206B\u202D\u202E\u200E\u202B\u206C\u206E\u200F\u206C\u200C\u206F\u202B\u206A\u202E\u202E\u200C\u200D\u200C\u202D\u202D\u202C\u206C\u200E\u200C\u200C\u202D\u200C\u202E\u206F\u200B\u206F\u206B\u202E\u206C\u200E\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u206F\u200C\u200D\u206C\u200E\u206F\u202B\u200D\u202A\u200B\u202A\u200B\u202C\u206E\u206D\u200F\u202D\u206D\u200C\u202C\u202E\u202D\u202D\u200F\u206F\u202E\u202D\u206A\u206A\u200E\u206F\u200E\u200C\u200C\u200F\u206A\u202C\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206E\u200B\u206A\u202C\u206F\u200D\u206D\u200C\u206E\u206F\u200D\u200F\u200E\u206A\u206D\u206E\u200F\u200F\u202C\u206C\u202B\u206D\u200D\u206E\u206B\u206C\u200B\u206E\u200D\u202C\u200E\u206D\u202B\u206E\u200D\u206F\u206A\u202C\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreTheCentennialFestivalforMagicalGirlsDef))]
		public sealed class FlandreTheCentennialFestivalforMagicalGirls : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreTheCentennialFestivalforMagicalGirlsDef.FlandreTheCentennialFestivalforMagicalGirls.\u200D\u202C\u206A\u202B\u206A\u202D\u202A\u206B\u200B\u202A\u200C\u206B\u200D\u206E\u202E\u200C\u206D\u206A\u202B\u200F\u206C\u200E\u206B\u206E\u206F\u200D\u202C\u202D\u200F\u202D\u200E\u202D\u200C\u200C\u200F\u206B\u206A\u202C\u206D\u206C\u202E(this).GetValueOrDefault();
				}
			}

			public override int FlandreValue2
			{
				get
				{
					return base.FlandreModifier(base.BasicCardModify(FlandreTheCentennialFestivalforMagicalGirlsDef.FlandreTheCentennialFestivalforMagicalGirls.\u200C\u202A\u206A\u206F\u200B\u200C\u206F\u200C\u202B\u202C\u202E\u202C\u206F\u206A\u206A\u206B\u200B\u202E\u206C\u206C\u206A\u206C\u206A\u206A\u206E\u202C\u202A\u206E\u206F\u206A\u206E\u206F\u206E\u206F\u206A\u200C\u206F\u206C\u200F\u200E\u202E(this) + this.AdditionalValue2 + FlandreTheCentennialFestivalforMagicalGirlsDef.FlandreTheCentennialFestivalforMagicalGirls.\u206B\u202E\u202C\u200B\u202D\u206C\u202D\u206F\u200B\u202D\u202A\u200D\u200C\u206C\u200C\u200D\u202B\u202A\u206D\u206F\u202C\u206E\u200B\u200F\u206A\u206A\u200E\u200C\u200B\u202D\u206F\u206B\u200D\u202B\u202C\u202E\u202D\u202D\u206B\u206F\u202E(this), false), true);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsMagicalGirl = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreTheCentennialFestivalforMagicalGirlsDef.FlandreTheCentennialFestivalforMagicalGirls.<Actions>d__5 <Actions>d__ = new FlandreTheCentennialFestivalforMagicalGirlsDef.FlandreTheCentennialFestivalforMagicalGirls.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u200D\u202C\u206A\u202B\u206A\u202D\u202A\u206B\u200B\u202A\u200C\u206B\u200D\u206E\u202E\u200C\u206D\u206A\u202B\u200F\u206C\u200E\u206B\u206E\u206F\u200D\u202C\u202D\u200F\u202D\u200E\u202D\u200C\u200C\u200F\u206B\u206A\u202C\u206D\u206C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200C\u202A\u206A\u206F\u200B\u200C\u206F\u200C\u202B\u202C\u202E\u202C\u206F\u206A\u206A\u206B\u200B\u202E\u206C\u206C\u206A\u206C\u206A\u206A\u206E\u202C\u202A\u206E\u206F\u206A\u206E\u206F\u206E\u206F\u206A\u200C\u206F\u206C\u200F\u200E\u202E(Card A_0)
			{
				return A_0.ConfigValue2;
			}

			static int \u206B\u202E\u202C\u200B\u202D\u206C\u202D\u206F\u200B\u202D\u202A\u200D\u200C\u206C\u200C\u200D\u202B\u202A\u206D\u206F\u202C\u206E\u200B\u200F\u206A\u206A\u200E\u200C\u200B\u202D\u206F\u206B\u200D\u202B\u202C\u202E\u202D\u202D\u206B\u206F\u202E(Card A_0)
			{
				return A_0.DeltaValue2;
			}

			static bool \u206E\u202D\u200F\u202B\u202D\u202E\u200B\u206A\u200F\u206E\u200B\u200F\u200B\u200C\u200B\u202A\u206C\u202A\u202E\u200C\u206B\u202C\u206F\u206E\u202B\u200D\u200F\u200B\u202B\u200B\u202A\u200B\u206F\u202D\u206F\u200D\u200E\u202E\u206B\u206F\u202E(Card A_0)
			{
				return A_0.CanUpgradeAndPositive;
			}
		}
	}
}
