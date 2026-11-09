using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreForbiddenScarletCuriosityDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1742773691);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreForbiddenScarletCuriosityDef.\u202D\u202A\u206D\u200E\u206A\u200D\u200C\u202A\u202B\u202C\u202C\u202A\u202E\u206D\u206B\u206F\u202C\u200E\u202E\u202C\u206A\u202E\u206E\u202B\u200E\u202E\u206C\u206A\u206A\u200F\u202C\u206E\u206B\u200E\u200E\u202D\u202A\u200C\u206C\u206C\u202E(BepinexPlugin.embeddedSource);
			FlandreForbiddenScarletCuriosityDef.\u200D\u206A\u202D\u202D\u206B\u200F\u206B\u202B\u206B\u206A\u200D\u202D\u200E\u202C\u206A\u206B\u200B\u202B\u200E\u206A\u200E\u202A\u200F\u202B\u202D\u206B\u206A\u202A\u206F\u202E\u206C\u206A\u202A\u206F\u200F\u206E\u200F\u200C\u200D\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreForbiddenScarletCuriosityDef.\u206A\u200E\u202D\u200B\u200D\u200C\u206C\u206C\u202B\u202E\u206B\u200D\u202B\u206A\u200B\u200B\u202B\u200C\u206E\u206E\u206E\u200F\u200E\u202C\u202A\u206D\u202C\u200D\u206F\u202B\u206B\u202B\u202E\u202B\u206E\u206E\u206F\u206A\u206B\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreForbiddenScarletCuriosityDef.\u200F\u200D\u202E\u206C\u206E\u200F\u200C\u200F\u200B\u200B\u206A\u200F\u202C\u200B\u202E\u202A\u202A\u206A\u206E\u206B\u206A\u202D\u202D\u206E\u206B\u200E\u200B\u202A\u206B\u206B\u200F\u206D\u202B\u206F\u206C\u206A\u200C\u202D\u200F\u202E\u202E(BepinexPlugin.sequenceTable, FlandreForbiddenScarletCuriosityDef.\u202D\u200D\u206E\u200F\u200D\u200F\u206C\u206A\u200B\u200D\u206F\u200F\u202B\u200D\u202E\u206E\u200C\u200E\u202B\u200E\u206F\u200E\u206F\u200B\u206E\u200E\u202D\u202D\u200F\u200D\u200B\u206E\u200B\u200B\u206F\u200B\u200E\u202D\u202B\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Colorless }, false, new ManaGroup
			{
				Any = 5,
				Colorless = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(400), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish | Keyword.Disposable, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish | Keyword.Disposable, false, Keyword.None, Keyword.None, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1408803216),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1408803216),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-222063899)
			}, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1178188684), new List<string>());
		}

		static CardImages \u202D\u202A\u206D\u200E\u206A\u200D\u200C\u202A\u202B\u202C\u202C\u202A\u202E\u206D\u206B\u206F\u202C\u200E\u202E\u202C\u206A\u202E\u206E\u202B\u200E\u202E\u206C\u206A\u206A\u200F\u202C\u206E\u206B\u200E\u200E\u202D\u202A\u200C\u206C\u206C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u206A\u202D\u202D\u206B\u200F\u206B\u202B\u206B\u206A\u200D\u202D\u200E\u202C\u206A\u206B\u200B\u202B\u200E\u206A\u200E\u202A\u200F\u202B\u202D\u206B\u206A\u202A\u206F\u202E\u206C\u206A\u202A\u206F\u200F\u206E\u200F\u200C\u200D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u200E\u202D\u200B\u200D\u200C\u206C\u206C\u202B\u202E\u206B\u200D\u202B\u206A\u200B\u200B\u202B\u200C\u206E\u206E\u206E\u200F\u200E\u202C\u202A\u206D\u202C\u200D\u206F\u202B\u206B\u202B\u202E\u202B\u206E\u206E\u206F\u206A\u206B\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202D\u200D\u206E\u200F\u200D\u200F\u206C\u206A\u200B\u200D\u206F\u200F\u202B\u200D\u202E\u206E\u200C\u200E\u202B\u200E\u206F\u200E\u206F\u200B\u206E\u200E\u202D\u202D\u200F\u200D\u200B\u206E\u200B\u200B\u206F\u200B\u200E\u202D\u202B\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u200D\u202E\u206C\u206E\u200F\u200C\u200F\u200B\u200B\u206A\u200F\u202C\u200B\u202E\u202A\u202A\u206A\u206E\u206B\u206A\u202D\u202D\u206E\u206B\u200E\u200B\u202A\u206B\u206B\u200F\u206D\u202B\u206F\u206C\u206A\u200C\u202D\u200F\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreForbiddenScarletCuriosityDef))]
		public sealed class FlandreForbiddenScarletCuriosity : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u206A\u200E\u200E\u206A\u206B\u206B\u200B\u206C\u206E\u200D\u200C\u206E\u202D\u206F\u206D\u202B\u200B\u200B\u202C\u202D\u202D\u200D\u206E\u206A\u202E\u202C\u206D\u200C\u200E\u206C\u206A\u200C\u202B\u202B\u202D\u200E\u202D\u200E\u200C\u200C\u202E((float)FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u206F\u202C\u200E\u200F\u202A\u200E\u202C\u202B\u202A\u206E\u200E\u206D\u200F\u206D\u202E\u202A\u206B\u206A\u202D\u206A\u206E\u206D\u202C\u202D\u202C\u202C\u202D\u206A\u202B\u206A\u202B\u206D\u206C\u206E\u200F\u200B\u200E\u200E\u200D\u200E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u206A\u200E\u200E\u206A\u206B\u206B\u200B\u206C\u206E\u200D\u200C\u206E\u202D\u206F\u206D\u202B\u200B\u200B\u202C\u202D\u202D\u200D\u206E\u206A\u202E\u202C\u206D\u200C\u200E\u206C\u206A\u200C\u202B\u202B\u202D\u200E\u202D\u200E\u200C\u200C\u202E((float)FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u206F\u202C\u200E\u200F\u202A\u200E\u202C\u202B\u202A\u206E\u200E\u206D\u200F\u206D\u202E\u202A\u206B\u206A\u202D\u206A\u206E\u206D\u202C\u202D\u202C\u202C\u202D\u206A\u202B\u206A\u202B\u206D\u206C\u206E\u200F\u200B\u200E\u200E\u200D\u200E\u202E(this).GetValueOrDefault() / 2f) * 100;
				}
			}

			public int Value3
			{
				get
				{
					return 120;
				}
			}

			public override int Amount
			{
				get
				{
					BattleController battleController = FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u200D\u200D\u200F\u206B\u202E\u202D\u200F\u200D\u200B\u206E\u202E\u200B\u206D\u200D\u202E\u206E\u206B\u202D\u200B\u200C\u206D\u200C\u206C\u206D\u202D\u206B\u206C\u200C\u200E\u200D\u200F\u200C\u206F\u202D\u206D\u202E\u206B\u202D\u202D\u202A\u202E(this);
					return FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u200C\u206A\u206F\u202D\u206F\u206D\u206A\u206A\u206F\u206B\u206B\u202B\u206D\u206A\u200F\u200B\u200F\u206B\u200D\u206E\u200B\u202E\u206A\u202E\u202A\u206F\u202E\u206A\u206C\u206D\u206F\u200C\u200B\u202E\u200C\u202E\u206A\u200C\u206C\u202A\u202E((float)((battleController != null) ? new int?(FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u206F\u200C\u202B\u206B\u200F\u200C\u206A\u206F\u206E\u202C\u206C\u200D\u206C\u200C\u202D\u206F\u200E\u202E\u202D\u202D\u202B\u206C\u202C\u206B\u206D\u200B\u200C\u202B\u206F\u200B\u202C\u206F\u206A\u200F\u202B\u200B\u206C\u202B\u202D\u206E\u202E(FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.\u200D\u206E\u202D\u202B\u202B\u206D\u200F\u206F\u202B\u200C\u206F\u200F\u206C\u202C\u202D\u202E\u200C\u202E\u202A\u202C\u200F\u200C\u202A\u202C\u202B\u206E\u206B\u206A\u200F\u200E\u200D\u206B\u206F\u200B\u206B\u206F\u200D\u200B\u206D\u200C\u202E(battleController))) : null).GetValueOrDefault() * ((float)this.FlandreValue2 / 100f), MidpointRounding.AwayFromZero);
				}
			}

			public string ForbiddenScarletCuriosity1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1918035642), true, true);
				}
			}

			public string ForbiddenScarletCuriosity2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2111882620), true, true);
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<Actions>d__14 <Actions>d__ = new FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<Actions>d__14(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<AfterUseAction>d__15 <AfterUseAction>d__ = new FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<AfterUseAction>d__15(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<AfterFollowPlayAction>d__16 <AfterFollowPlayAction>d__ = new FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.<AfterFollowPlayAction>d__16(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static int? \u206F\u202C\u200E\u200F\u202A\u200E\u202C\u202B\u202A\u206E\u200E\u206D\u200F\u206D\u202E\u202A\u206B\u206A\u202D\u206A\u206E\u206D\u202C\u202D\u202C\u202C\u202D\u206A\u202B\u206A\u202B\u206D\u206C\u206E\u200F\u200B\u200E\u200E\u200D\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206A\u200E\u200E\u206A\u206B\u206B\u200B\u206C\u206E\u200D\u200C\u206E\u202D\u206F\u206D\u202B\u200B\u200B\u202C\u202D\u202D\u200D\u206E\u206A\u202E\u202C\u206D\u200C\u200E\u206C\u206A\u200C\u202B\u202B\u202D\u200E\u202D\u200E\u200C\u200C\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static BattleController \u200D\u200D\u200F\u206B\u202E\u202D\u200F\u200D\u200B\u206E\u202E\u200B\u206D\u200D\u202E\u206E\u206B\u202D\u200B\u200C\u206D\u200C\u206C\u206D\u202D\u206B\u206C\u200C\u200E\u200D\u200F\u200C\u206F\u202D\u206D\u202E\u206B\u202D\u202D\u202A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200D\u206E\u202D\u202B\u202B\u206D\u200F\u206F\u202B\u200C\u206F\u200F\u206C\u202C\u202D\u202E\u200C\u202E\u202A\u202C\u200F\u200C\u202A\u202C\u202B\u206E\u206B\u206A\u200F\u200E\u200D\u206B\u206F\u200B\u206B\u206F\u200D\u200B\u206D\u200C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static int \u206F\u200C\u202B\u206B\u200F\u200C\u206A\u206F\u206E\u202C\u206C\u200D\u206C\u200C\u202D\u206F\u200E\u202E\u202D\u202D\u202B\u206C\u202C\u206B\u206D\u200B\u200C\u202B\u206F\u200B\u202C\u206F\u206A\u200F\u202B\u200B\u206C\u202B\u202D\u206E\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static int \u200C\u206A\u206F\u202D\u206F\u206D\u206A\u206A\u206F\u206B\u206B\u202B\u206D\u206A\u200F\u200B\u200F\u206B\u200D\u206E\u200B\u202E\u206A\u202E\u202A\u206F\u202E\u206A\u206C\u206D\u206F\u200C\u200B\u202E\u200C\u202E\u206A\u200C\u206C\u202A\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}

			public static bool MusicChanged;

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.GameRunController_BaseCardWeight_Patch.\u202D\u202B\u206B\u206B\u206F\u200D\u206F\u206C\u200C\u202B\u206C\u202D\u206D\u202B\u200E\u202A\u206E\u206B\u200E\u206F\u202A\u200C\u206F\u206F\u202A\u200F\u200B\u200D\u206E\u202B\u200F\u200D\u200C\u200C\u202B\u206F\u202B\u202A\u202A\u202D\u202E(FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity.GameRunController_BaseCardWeight_Patch.\u206E\u202C\u206F\u202A\u202E\u206C\u206A\u206F\u202C\u200F\u206B\u200E\u200E\u200B\u202A\u206B\u206F\u206B\u200F\u206E\u206B\u200E\u200D\u202D\u200F\u206B\u200D\u206C\u202E\u202B\u206E\u202C\u206E\u202B\u200D\u202A\u206E\u202B\u206B\u206B\u202E(config), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1742773691)))
					{
						for (;;)
						{
							IL_001A:
							int num = -709557021;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((-966743255 * (-530596843 - -2090217701) - num2 * -64244691) * -1875578521 + 2117795370)) % 3U)
								{
								case 1U:
									__result *= 0.25f;
									num = (int)((num3 * 1922818327U) ^ 2064194523U);
									continue;
								case 2U:
									goto IL_001A;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u206E\u202C\u206F\u202A\u202E\u206C\u206A\u206F\u202C\u200F\u206B\u200E\u200E\u200B\u202A\u206B\u206F\u206B\u200F\u206E\u206B\u200E\u200D\u202D\u200F\u206B\u200D\u206C\u202E\u202B\u206E\u202C\u206E\u202B\u200D\u202A\u206E\u202B\u206B\u206B\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u202D\u202B\u206B\u206B\u206F\u200D\u206F\u206C\u200C\u202B\u206C\u202D\u206D\u202B\u200E\u202A\u206E\u206B\u200E\u206F\u202A\u200C\u206F\u206F\u202A\u200F\u200B\u200D\u206E\u202B\u200F\u200D\u200C\u200C\u202B\u206F\u202B\u202A\u202A\u202D\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
