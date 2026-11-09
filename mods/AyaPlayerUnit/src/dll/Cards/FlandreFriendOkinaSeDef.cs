using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreFriendOkinaSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-733066742);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaSeDef.\u202B\u202D\u202C\u200E\u206D\u206F\u200C\u206D\u206D\u200D\u202E\u206A\u202E\u206B\u202B\u200B\u202D\u206E\u202A\u206D\u206A\u206F\u202A\u206A\u200C\u206A\u200D\u206C\u200F\u206A\u206F\u202C\u202E\u206C\u206B\u206A\u202E\u200C\u202C\u206A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreFriendOkinaSeDef.\u200D\u206C\u200F\u206A\u206A\u206D\u202C\u200F\u200B\u206A\u206E\u206F\u200B\u200F\u202C\u206F\u200C\u206B\u200B\u206E\u200F\u202E\u200F\u206E\u206B\u200E\u206A\u202B\u202A\u200E\u202D\u202E\u200D\u206B\u206D\u202D\u200E\u202D\u206B\u202D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(762904811), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreFriendOkinaSeDef.\u202E\u200C\u200D\u202C\u202D\u202A\u200F\u202A\u200C\u200C\u202E\u206E\u206A\u206A\u206C\u200B\u206E\u202E\u200C\u206F\u202E\u206C\u206C\u202A\u202D\u200B\u206F\u200F\u202A\u200E\u206C\u202A\u202B\u206E\u206D\u202E\u206F\u202D\u200D\u206A\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaSeDef.\u206D\u200E\u206F\u206F\u202D\u200B\u200B\u202E\u206D\u206C\u206A\u206B\u200B\u202D\u200D\u206C\u200F\u200D\u202D\u206A\u206A\u206E\u200F\u206B\u202C\u202E\u206A\u200C\u202C\u206E\u206D\u206F\u200F\u200F\u200D\u206A\u202A\u202B\u206A\u202D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257));
		}

		static BatchLocalization \u202B\u202D\u202C\u200E\u206D\u206F\u200C\u206D\u206D\u200D\u202E\u206A\u202E\u206B\u202B\u200B\u202D\u206E\u202A\u206D\u206A\u206F\u202A\u206A\u200C\u206A\u200D\u206C\u200F\u206A\u206F\u202C\u202E\u206C\u206B\u206A\u202E\u200C\u202C\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200D\u206C\u200F\u206A\u206A\u206D\u202C\u200F\u200B\u206A\u206E\u206F\u200B\u200F\u202C\u206F\u200C\u206B\u200B\u206E\u200F\u202E\u200F\u206E\u206B\u200E\u206A\u202B\u202A\u200E\u202D\u202E\u200D\u206B\u206D\u202D\u200E\u202D\u206B\u202D\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206D\u200E\u206F\u206F\u202D\u200B\u200B\u202E\u206D\u206C\u206A\u206B\u200B\u202D\u200D\u206C\u200F\u200D\u202D\u206A\u206A\u206E\u200F\u206B\u202C\u202E\u206A\u200C\u202C\u206E\u206D\u206F\u200F\u200F\u200D\u206A\u202A\u202B\u206A\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u200C\u200D\u202C\u202D\u202A\u200F\u202A\u200C\u200C\u202E\u206E\u206A\u206A\u206C\u200B\u206E\u202E\u200C\u206F\u202E\u206C\u206C\u202A\u202D\u200B\u206F\u200F\u202A\u200E\u206C\u202A\u202B\u206E\u206D\u202E\u206F\u202D\u200D\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaSeDef))]
		public sealed class FlandreFriendOkinaSe : StatusEffect
		{
			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(0);
				}
			}

			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(FlandreFriendOkinaSeDef.FlandreFriendOkinaSe.\u202E\u202E\u200C\u206E\u206A\u206C\u200C\u202A\u202A\u200D\u206E\u202E\u206D\u206D\u202C\u206E\u200E\u202B\u206F\u206E\u206E\u202B\u200C\u200E\u200B\u206F\u202E\u200B\u202E\u202E\u206F\u206C\u202D\u200C\u202B\u202E\u206D\u206C\u202B\u202D\u202E(FlandreFriendOkinaSeDef.FlandreFriendOkinaSe.\u206C\u206B\u206D\u202D\u200F\u200F\u206E\u200E\u200F\u202D\u200C\u200C\u202B\u200C\u206B\u206A\u206E\u200B\u202E\u200E\u206E\u200C\u202A\u202C\u206C\u200F\u206C\u206E\u202E\u206C\u200C\u200D\u202D\u200B\u202E\u202E\u202E\u206D\u206C\u206C\u202E(FlandreFriendOkinaSeDef.FlandreFriendOkinaSe.\u202A\u200F\u206B\u202E\u200B\u200B\u202B\u200F\u202B\u206B\u200E\u202C\u202A\u200B\u202C\u206E\u200E\u206C\u200E\u200D\u200B\u202D\u200D\u206D\u200E\u202C\u200E\u200B\u200B\u206C\u200B\u200C\u200E\u206D\u200D\u206C\u206D\u202A\u202A\u206B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				FlandreFriendOkinaSeDef.FlandreFriendOkinaSe.<OnPlayerTurnStarted>d__3 <OnPlayerTurnStarted>d__ = new FlandreFriendOkinaSeDef.FlandreFriendOkinaSe.<OnPlayerTurnStarted>d__3(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			static BattleController \u202A\u200F\u206B\u202E\u200B\u200B\u202B\u200F\u202B\u206B\u200E\u202C\u202A\u200B\u202C\u206E\u200E\u206C\u200E\u200D\u200B\u202D\u200D\u206D\u200E\u202C\u200E\u200B\u200B\u206C\u200B\u200C\u200E\u206D\u200D\u206C\u206D\u202A\u202A\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206C\u206B\u206D\u202D\u200F\u200F\u206E\u200E\u200F\u202D\u200C\u200C\u202B\u200C\u206B\u206A\u206E\u200B\u202E\u200E\u206E\u200C\u202A\u202C\u206C\u200F\u206C\u206E\u202E\u206C\u200C\u200D\u202D\u200B\u202E\u202E\u202E\u206D\u206C\u206C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202E\u202E\u200C\u206E\u206A\u206C\u200C\u202A\u202A\u200D\u206E\u202E\u206D\u206D\u202C\u206E\u200E\u202B\u206F\u206E\u206E\u202B\u200C\u200E\u200B\u206F\u202E\u200B\u202E\u202E\u206F\u206C\u202D\u200C\u202B\u202E\u206D\u206C\u202B\u202D\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}
		}
	}
}
