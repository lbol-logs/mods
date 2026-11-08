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
	public sealed class FlandreBloodyCatastropheDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1647621106);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreBloodyCatastropheDef.\u202B\u202E\u200E\u206C\u200F\u206D\u206A\u206F\u202A\u200F\u200F\u200E\u200F\u202E\u200B\u200D\u206D\u206C\u202D\u206F\u202A\u200D\u202C\u206E\u202A\u206D\u202A\u202E\u206B\u200F\u200D\u206D\u200D\u200C\u202E\u202C\u206C\u200B\u200E\u206F\u202E(BepinexPlugin.embeddedSource);
			FlandreBloodyCatastropheDef.\u202E\u206D\u206A\u206F\u200F\u202D\u202A\u200F\u200C\u206E\u202A\u206D\u200C\u200E\u206A\u200E\u200C\u200D\u200F\u200F\u206C\u200B\u206C\u202C\u206E\u206C\u202D\u206E\u200F\u202C\u206B\u202C\u202B\u206C\u202B\u200C\u200F\u202B\u202B\u206E\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreBloodyCatastropheDef.\u202D\u202E\u206F\u206F\u200E\u206C\u206D\u206A\u206A\u206F\u200D\u206D\u200D\u206F\u206F\u206C\u202C\u200C\u200D\u200C\u202C\u206D\u202C\u206C\u206B\u202D\u202B\u206B\u202C\u200B\u202D\u200E\u200F\u200B\u206C\u206A\u202C\u202E\u200C\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreBloodyCatastropheDef.\u200E\u200D\u206A\u200C\u202A\u206E\u206E\u206D\u206B\u202D\u202D\u206F\u200F\u206C\u202A\u206B\u200F\u206C\u206A\u202E\u200C\u202C\u206F\u200C\u200B\u202D\u206A\u200B\u200E\u206B\u200D\u202B\u206B\u206C\u200C\u202D\u200C\u202D\u202C\u206F\u202E(BepinexPlugin.sequenceTable, FlandreBloodyCatastropheDef.\u200F\u206F\u200F\u200D\u202C\u202D\u202C\u206B\u206F\u202A\u200E\u202E\u202A\u206C\u206F\u202D\u206A\u206C\u202D\u206B\u202A\u200B\u206F\u206D\u200D\u200B\u200F\u200B\u206C\u206B\u206A\u206A\u206A\u200C\u202E\u202C\u202E\u202B\u200C\u200C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2105991427), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000), 0, true, true, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 2,
				Hybrid = 1,
				HybridColor = 7
			}, null, null, null, null, new int?(10), null, null, null, null, null, new int?(3), null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile, Keyword.Accuracy | Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(204080153), new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2101891953) });
		}

		static CardImages \u202B\u202E\u200E\u206C\u200F\u206D\u206A\u206F\u202A\u200F\u200F\u200E\u200F\u202E\u200B\u200D\u206D\u206C\u202D\u206F\u202A\u200D\u202C\u206E\u202A\u206D\u202A\u202E\u206B\u200F\u200D\u206D\u200D\u200C\u202E\u202C\u206C\u200B\u200E\u206F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u206D\u206A\u206F\u200F\u202D\u202A\u200F\u200C\u206E\u202A\u206D\u200C\u200E\u206A\u200E\u200C\u200D\u200F\u200F\u206C\u200B\u206C\u202C\u206E\u206C\u202D\u206E\u200F\u202C\u206B\u202C\u202B\u206C\u202B\u200C\u200F\u202B\u202B\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u202E\u206F\u206F\u200E\u206C\u206D\u206A\u206A\u206F\u200D\u206D\u200D\u206F\u206F\u206C\u202C\u200C\u200D\u200C\u202C\u206D\u202C\u206C\u206B\u202D\u202B\u206B\u202C\u200B\u202D\u200E\u200F\u200B\u206C\u206A\u202C\u202E\u200C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u206F\u200F\u200D\u202C\u202D\u202C\u206B\u206F\u202A\u200E\u202E\u202A\u206C\u206F\u202D\u206A\u206C\u202D\u206B\u202A\u200B\u206F\u206D\u200D\u200B\u200F\u200B\u206C\u206B\u206A\u206A\u206A\u200C\u202E\u202C\u202E\u202B\u200C\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u200D\u206A\u200C\u202A\u206E\u206E\u206D\u206B\u202D\u202D\u206F\u200F\u206C\u202A\u206B\u200F\u206C\u206A\u202E\u200C\u202C\u206F\u200C\u200B\u202D\u206A\u200B\u200E\u206B\u200D\u202B\u206B\u206C\u200C\u202D\u200C\u202D\u202C\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreBloodyCatastropheDef))]
		public sealed class FlandreBloodyCatastrophe : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreBloodyCatastropheDef.FlandreBloodyCatastrophe.\u206E\u202C\u206C\u202E\u206C\u202B\u202A\u200C\u200F\u206B\u202C\u200E\u206E\u206F\u206C\u206F\u206A\u202A\u206C\u206D\u202E\u206A\u202D\u206A\u206A\u202B\u200D\u206F\u206B\u206F\u202E\u206F\u202B\u200F\u202A\u202C\u200B\u202D\u200B\u206A\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreBloodyCatastropheDef.FlandreBloodyCatastrophe.\u206E\u202C\u206C\u202E\u206C\u202B\u202A\u200C\u200F\u206B\u202C\u200E\u206E\u206F\u206C\u206F\u206A\u202A\u206C\u206D\u202E\u206A\u202D\u206A\u206A\u202B\u200D\u206F\u206B\u206F\u202E\u206F\u202B\u200F\u202A\u202C\u200B\u202D\u200B\u206A\u202E(this).GetValueOrDefault();
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreBloodyCatastropheDef.FlandreBloodyCatastrophe.\u206E\u202C\u206C\u202E\u206C\u202B\u202A\u200C\u200F\u206B\u202C\u200E\u206E\u206F\u206C\u206F\u206A\u202A\u206C\u206D\u202E\u206A\u202D\u206A\u206A\u202B\u200D\u206F\u206B\u206F\u202E\u206F\u202B\u200F\u202A\u202C\u200B\u202D\u200B\u206A\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsBloodlust = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreBloodyCatastropheDef.FlandreBloodyCatastrophe.<Actions>d__7 <Actions>d__ = new FlandreBloodyCatastropheDef.FlandreBloodyCatastrophe.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u206E\u202C\u206C\u202E\u206C\u202B\u202A\u200C\u200F\u206B\u202C\u200E\u206E\u206F\u206C\u206F\u206A\u202A\u206C\u206D\u202E\u206A\u202D\u206A\u206A\u202B\u200D\u206F\u206B\u206F\u202E\u206F\u202B\u200F\u202A\u202C\u200B\u202D\u200B\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
