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
	public sealed class FlandreBlockURDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1338003631);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreBlockURDef.\u206F\u206B\u206A\u200D\u202A\u200B\u202C\u202B\u206E\u202D\u200C\u200B\u200D\u202B\u202E\u202A\u206F\u206A\u206F\u206A\u206D\u200E\u202E\u202E\u206E\u206D\u202B\u202C\u200D\u200F\u200E\u206A\u200F\u206B\u202C\u206B\u206D\u206B\u200C\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreBlockURDef.\u206E\u202D\u202C\u206B\u206B\u206E\u202A\u202E\u206C\u206B\u206C\u200F\u202E\u202A\u206E\u206B\u202B\u202E\u202A\u202B\u206F\u206A\u206C\u202C\u206F\u200B\u206F\u202B\u202E\u202B\u200D\u202D\u202B\u202A\u206D\u200C\u202D\u206E\u206E\u202D\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreBlockURDef.\u206E\u202E\u206F\u200C\u202A\u200C\u202A\u206A\u206B\u206C\u202E\u206D\u200C\u200D\u202B\u200B\u202A\u206C\u200E\u200D\u206E\u202D\u206D\u206E\u202D\u206C\u200C\u200E\u202D\u206F\u202B\u206C\u202C\u206A\u202B\u200E\u206D\u202C\u200F\u206D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreBlockURDef.\u200E\u202B\u206A\u206C\u202C\u206F\u202B\u202E\u200E\u206E\u200C\u202E\u200D\u202A\u206B\u202C\u202D\u206B\u202B\u202A\u200D\u200D\u200C\u202D\u202C\u202B\u206C\u200E\u206E\u206C\u200C\u202C\u200E\u200B\u202C\u200F\u206F\u202C\u200C\u206D\u202E(BepinexPlugin.sequenceTable, FlandreBlockURDef.\u202E\u202E\u200E\u202D\u202A\u206E\u202A\u202C\u202E\u206A\u206F\u202D\u202B\u200C\u206F\u206F\u202D\u202A\u206F\u202B\u206B\u206B\u202D\u206B\u200F\u200F\u200B\u200D\u202C\u200F\u202E\u202E\u206B\u200D\u202A\u202B\u202C\u200F\u200C\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, false, false, false, true, true, Rarity.Common, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 1,
				Hybrid = 1,
				HybridColor = 5
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Basic, Keyword.Basic, false, Keyword.Block, Keyword.Block, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(276555055), new List<string>());
		}

		static CardImages \u206F\u206B\u206A\u200D\u202A\u200B\u202C\u202B\u206E\u202D\u200C\u200B\u200D\u202B\u202E\u202A\u206F\u206A\u206F\u206A\u206D\u200E\u202E\u202E\u206E\u206D\u202B\u202C\u200D\u200F\u200E\u206A\u200F\u206B\u202C\u206B\u206D\u206B\u200C\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206E\u202D\u202C\u206B\u206B\u206E\u202A\u202E\u206C\u206B\u206C\u200F\u202E\u202A\u206E\u206B\u202B\u202E\u202A\u202B\u206F\u206A\u206C\u202C\u206F\u200B\u206F\u202B\u202E\u202B\u200D\u202D\u202B\u202A\u206D\u200C\u202D\u206E\u206E\u202D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u202E\u206F\u200C\u202A\u200C\u202A\u206A\u206B\u206C\u202E\u206D\u200C\u200D\u202B\u200B\u202A\u206C\u200E\u200D\u206E\u202D\u206D\u206E\u202D\u206C\u200C\u200E\u202D\u206F\u202B\u206C\u202C\u206A\u202B\u200E\u206D\u202C\u200F\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202E\u200E\u202D\u202A\u206E\u202A\u202C\u202E\u206A\u206F\u202D\u202B\u200C\u206F\u206F\u202D\u202A\u206F\u202B\u206B\u206B\u202D\u206B\u200F\u200F\u200B\u200D\u202C\u200F\u202E\u202E\u206B\u200D\u202A\u202B\u202C\u200F\u200C\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u202B\u206A\u206C\u202C\u206F\u202B\u202E\u200E\u206E\u200C\u202E\u200D\u202A\u206B\u202C\u202D\u206B\u202B\u202A\u200D\u200D\u200C\u202D\u202C\u202B\u206C\u200E\u206E\u206C\u200C\u202C\u200E\u200B\u202C\u200F\u206F\u202C\u200C\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreBlockURDef))]
		public sealed class FlandreBlockUR : FlandreCard
		{
			public override int AdditionalBlock
			{
				get
				{
					return FlandreBlockURDef.FlandreBlockUR.\u202E\u202B\u206B\u206E\u202C\u200F\u206A\u202D\u200B\u200B\u200C\u200F\u206B\u202B\u206D\u200C\u202D\u200C\u200F\u202C\u206D\u206D\u200F\u206A\u200C\u200F\u200E\u206D\u202C\u206C\u200D\u202C\u200C\u206A\u200F\u200F\u202B\u200D\u202C\u202B\u202E(this).GetValueOrDefault() * 3;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreBlockURDef.FlandreBlockUR.<Actions>d__2 <Actions>d__ = new FlandreBlockURDef.FlandreBlockUR.<Actions>d__2(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202E\u202B\u206B\u206E\u202C\u200F\u206A\u202D\u200B\u200B\u200C\u200F\u206B\u202B\u206D\u200C\u202D\u200C\u200F\u202C\u206D\u206D\u200F\u206A\u200C\u200F\u200E\u206D\u202C\u206C\u200D\u202C\u200C\u206A\u200F\u200F\u202B\u200D\u202C\u202B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
