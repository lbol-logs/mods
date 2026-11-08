using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
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
	public sealed class FlandreDestructiveImpulseDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1906468502);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreDestructiveImpulseDef.\u206F\u206A\u200F\u200B\u202D\u206A\u200D\u200F\u206A\u206B\u206C\u200B\u206B\u200D\u206F\u200B\u206B\u206C\u200E\u200E\u202B\u200F\u202D\u200F\u200F\u206A\u202C\u206B\u202C\u200B\u206C\u200E\u202E\u202C\u206B\u206C\u206C\u206C\u206B\u200C\u202E(BepinexPlugin.embeddedSource);
			FlandreDestructiveImpulseDef.\u202B\u202D\u206C\u200D\u200E\u200E\u200B\u202A\u202B\u202B\u202C\u202E\u200E\u200B\u206D\u200D\u206A\u202D\u202D\u200E\u200F\u206D\u200B\u202E\u200B\u200B\u202E\u200E\u200B\u200D\u200B\u206E\u200E\u206F\u206D\u206C\u206B\u202A\u200E\u202A\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreDestructiveImpulseDef.\u202A\u206D\u206C\u206B\u200B\u202B\u202B\u200F\u200F\u202E\u202B\u200C\u206F\u206E\u200D\u200D\u206E\u202E\u202C\u206B\u202A\u202A\u200F\u206E\u200D\u200F\u202B\u200C\u202B\u200D\u202E\u200B\u200B\u206E\u202D\u206F\u200C\u206D\u200F\u206A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreDestructiveImpulseDef.\u200E\u200F\u200B\u202A\u202B\u202C\u200F\u202A\u202A\u206F\u202E\u206C\u206F\u206E\u206E\u202E\u206C\u200B\u202E\u202B\u206B\u200C\u200C\u206F\u206E\u202B\u200C\u200C\u202A\u206C\u200F\u206C\u206A\u200E\u200B\u206E\u206F\u206E\u202C\u200E\u202E(BepinexPlugin.sequenceTable, FlandreDestructiveImpulseDef.\u200D\u202D\u206B\u202A\u202B\u206F\u200E\u202D\u206A\u206D\u200D\u202E\u202E\u202A\u200D\u206E\u200D\u200E\u200B\u206A\u202D\u206F\u206D\u206F\u206A\u206A\u202C\u202E\u200D\u202D\u200F\u206C\u202C\u202A\u202D\u206F\u206C\u206C\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, false, false, false, false, Rarity.Rare, CardType.Misfortune, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 3
			}, null, null, null, null, null, null, null, null, null, null, new int?(4), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Unremovable | Keyword.Forbidden | Keyword.Retain, Keyword.Unremovable | Keyword.Forbidden | Keyword.Retain, false, Keyword.Exile, Keyword.Exile, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-222063899) }, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062) }, new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1463208386), new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-601221616) });
		}

		static CardImages \u206F\u206A\u200F\u200B\u202D\u206A\u200D\u200F\u206A\u206B\u206C\u200B\u206B\u200D\u206F\u200B\u206B\u206C\u200E\u200E\u202B\u200F\u202D\u200F\u200F\u206A\u202C\u206B\u202C\u200B\u206C\u200E\u202E\u202C\u206B\u206C\u206C\u206C\u206B\u200C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202B\u202D\u206C\u200D\u200E\u200E\u200B\u202A\u202B\u202B\u202C\u202E\u200E\u200B\u206D\u200D\u206A\u202D\u202D\u200E\u200F\u206D\u200B\u202E\u200B\u200B\u202E\u200E\u200B\u200D\u200B\u206E\u200E\u206F\u206D\u206C\u206B\u202A\u200E\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u206D\u206C\u206B\u200B\u202B\u202B\u200F\u200F\u202E\u202B\u200C\u206F\u206E\u200D\u200D\u206E\u202E\u202C\u206B\u202A\u202A\u200F\u206E\u200D\u200F\u202B\u200C\u202B\u200D\u202E\u200B\u200B\u206E\u202D\u206F\u200C\u206D\u200F\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u202D\u206B\u202A\u202B\u206F\u200E\u202D\u206A\u206D\u200D\u202E\u202E\u202A\u200D\u206E\u200D\u200E\u200B\u206A\u202D\u206F\u206D\u206F\u206A\u206A\u202C\u202E\u200D\u202D\u200F\u206C\u202C\u202A\u202D\u206F\u206C\u206C\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u200F\u200B\u202A\u202B\u202C\u200F\u202A\u202A\u206F\u202E\u206C\u206F\u206E\u206E\u202E\u206C\u200B\u202E\u202B\u206B\u200C\u200C\u206F\u206E\u202B\u200C\u200C\u202A\u206C\u200F\u206C\u206A\u200E\u200B\u206E\u206F\u206E\u202C\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreDestructiveImpulseDef))]
		public sealed class FlandreDestructiveImpulse : FlandreCard
		{
			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<UnitEventArgs>(FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.\u206D\u200C\u202D\u206E\u206C\u202B\u206A\u200E\u202D\u200C\u202A\u200C\u200D\u206C\u202B\u202B\u200E\u206A\u206F\u202A\u206B\u206D\u202D\u206F\u206B\u202D\u200F\u202A\u206D\u206C\u206F\u200D\u200F\u200D\u206A\u200E\u200C\u202E\u202E(FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.\u200C\u206F\u206E\u206B\u202A\u202B\u206D\u206D\u206D\u202D\u200F\u206E\u206E\u206C\u200C\u206B\u200E\u200B\u202B\u200F\u202C\u202C\u202A\u202C\u206B\u206A\u202C\u202E\u200D\u206B\u200D\u200F\u200D\u206C\u206F\u202C\u200F\u206F\u202B\u206B\u202E(FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.\u202C\u202E\u206C\u206C\u200D\u206B\u202C\u202C\u206C\u200C\u206F\u200D\u200E\u206F\u206F\u202E\u200C\u206F\u202B\u200B\u202C\u200C\u206D\u200F\u200B\u202D\u200D\u202C\u200C\u200F\u200B\u202C\u206F\u206E\u202D\u206B\u202E\u206F\u200E\u206F\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
			{
				FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.<OnPlayerTurnEnding>d__1 <OnPlayerTurnEnding>d__ = new FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.<OnPlayerTurnEnding>d__1(-2);
				<OnPlayerTurnEnding>d__.<>4__this = this;
				return <OnPlayerTurnEnding>d__;
			}

			public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
			{
				FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.<OnExile>d__2 <OnExile>d__ = new FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.<OnExile>d__2(-2);
				<OnExile>d__.<>4__this = this;
				return <OnExile>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				return new FlandreDestructiveImpulseDef.FlandreDestructiveImpulse.<Actions>d__3(-2);
			}

			static BattleController \u202C\u202E\u206C\u206C\u200D\u206B\u202C\u202C\u206C\u200C\u206F\u200D\u200E\u206F\u206F\u202E\u200C\u206F\u202B\u200B\u202C\u200C\u206D\u200F\u200B\u202D\u200D\u202C\u200C\u200F\u200B\u202C\u206F\u206E\u202D\u206B\u202E\u206F\u200E\u206F\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200C\u206F\u206E\u206B\u202A\u202B\u206D\u206D\u206D\u202D\u200F\u206E\u206E\u206C\u200C\u206B\u200E\u200B\u202B\u200F\u202C\u202C\u202A\u202C\u206B\u206A\u202C\u202E\u200D\u206B\u200D\u200F\u200D\u206C\u206F\u202C\u200F\u206F\u202B\u206B\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206D\u200C\u202D\u206E\u206C\u202B\u206A\u200E\u202D\u200C\u202A\u200C\u200D\u206C\u202B\u202B\u200E\u206A\u206F\u202A\u206B\u206D\u202D\u206F\u206B\u202D\u200F\u202A\u206D\u206C\u206F\u200D\u200F\u200D\u206A\u200E\u200C\u202E\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}
		}
	}
}
