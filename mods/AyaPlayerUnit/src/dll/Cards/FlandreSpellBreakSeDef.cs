using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreSpellBreakSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1883430084);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSpellBreakSeDef.\u200E\u206A\u202B\u200F\u200E\u200D\u200E\u200B\u206A\u200D\u200E\u202C\u200E\u200E\u200D\u206E\u200E\u202E\u206D\u200F\u202B\u206C\u206C\u206D\u206A\u206B\u206D\u200D\u206B\u200D\u200D\u206A\u200E\u202D\u200B\u202C\u202E\u202B\u202A\u206E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreSpellBreakSeDef.\u200F\u200E\u202C\u202D\u200D\u202E\u206C\u200C\u202D\u206E\u206B\u200D\u206E\u202A\u206D\u202B\u200F\u202E\u202C\u206F\u200D\u206F\u202A\u200D\u200D\u202B\u200F\u202D\u200E\u202A\u200D\u200D\u200D\u200F\u202D\u202D\u202D\u206A\u206F\u206C\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-387052730), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreSpellBreakSeDef.\u200F\u202E\u206A\u202D\u202E\u200C\u206B\u206D\u206A\u202A\u202D\u202B\u202E\u202D\u206E\u202E\u202B\u206D\u200C\u202B\u202D\u200D\u200E\u202C\u200E\u206F\u200F\u202A\u202D\u200E\u202C\u202B\u202C\u206F\u206D\u200E\u200F\u206A\u202C\u206C\u202E(BepinexPlugin.sequenceTable, FlandreSpellBreakSeDef.\u202B\u200C\u202B\u200B\u200E\u202E\u206D\u200E\u206A\u206E\u200E\u202D\u206A\u200E\u206F\u202C\u206B\u202B\u202D\u200C\u206F\u202E\u206E\u200B\u200F\u202B\u202E\u202D\u202A\u206D\u206C\u202A\u200C\u206C\u200C\u202B\u200F\u206F\u200B\u200C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257));
		}

		static BatchLocalization \u200E\u206A\u202B\u200F\u200E\u200D\u200E\u200B\u206A\u200D\u200E\u202C\u200E\u200E\u200D\u206E\u200E\u202E\u206D\u200F\u202B\u206C\u206C\u206D\u206A\u206B\u206D\u200D\u206B\u200D\u200D\u206A\u200E\u202D\u200B\u202C\u202E\u202B\u202A\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200F\u200E\u202C\u202D\u200D\u202E\u206C\u200C\u202D\u206E\u206B\u200D\u206E\u202A\u206D\u202B\u200F\u202E\u202C\u206F\u200D\u206F\u202A\u200D\u200D\u202B\u200F\u202D\u200E\u202A\u200D\u200D\u200D\u200F\u202D\u202D\u202D\u206A\u206F\u206C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202B\u200C\u202B\u200B\u200E\u202E\u206D\u200E\u206A\u206E\u200E\u202D\u206A\u200E\u206F\u202C\u206B\u202B\u202D\u200C\u206F\u202E\u206E\u200B\u200F\u202B\u202E\u202D\u202A\u206D\u206C\u202A\u200C\u206C\u200C\u202B\u200F\u206F\u200B\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u202E\u206A\u202D\u202E\u200C\u206B\u206D\u206A\u202A\u202D\u202B\u202E\u202D\u206E\u202E\u202B\u206D\u200C\u202B\u202D\u200D\u200E\u202C\u200E\u206F\u200F\u202A\u202D\u200E\u202C\u202B\u202C\u206F\u206D\u200E\u200F\u206A\u202C\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreSpellBreakSeDef))]
		public sealed class FlandreSpellBreakSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				this.React(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u200D\u202B\u200B\u200F\u206A\u200B\u200B\u206D\u206B\u206F\u200D\u202B\u202C\u206B\u200F\u202E\u202D\u206E\u200C\u202E\u206B\u206A\u202E\u200E\u200F\u200E\u206A\u206F\u200F\u202E\u202D\u206F\u206F\u202B\u202E\u200D\u202B\u202A\u200C\u206C\u202E(new ApplyStatusEffectAction<FlandreSpellBreakCooldownSeDef.FlandreSpellBreakCooldownSe>(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u200D\u200B\u206C\u206C\u202C\u200C\u202D\u206D\u200D\u206C\u202B\u206F\u202C\u202D\u200C\u200D\u206C\u206A\u202A\u206C\u200D\u206F\u200D\u206B\u206D\u200D\u202B\u200C\u206C\u202A\u206D\u206C\u200F\u202B\u202C\u202A\u206E\u206F\u202A\u202A\u202E(this), null, new int?(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u206F\u202D\u206E\u206A\u206C\u200C\u200C\u200E\u206F\u206C\u206E\u200D\u202A\u206F\u206E\u202C\u200D\u202A\u206A\u206B\u200E\u202C\u202D\u200F\u202D\u202D\u206C\u200B\u202B\u202E\u200D\u200D\u206C\u206A\u202D\u206A\u206D\u202E\u206D\u200D\u202E(this)), null, null, 0.1f, true)));
				for (;;)
				{
					IL_0042:
					int num = -1035691911;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(num2 ^ ((~1125686571 - --2139588322) * 1421911311)) * 249595473 * -1186265485)) % 3U)
						{
						case 0U:
							goto IL_0042;
						case 2U:
							base.ReactOwnerEvent<UnitEventArgs>(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u206B\u200C\u200C\u206B\u206A\u202A\u206A\u206D\u202D\u206E\u202D\u200C\u202C\u200D\u202E\u200B\u202D\u202D\u206E\u200C\u206E\u202E\u200C\u206E\u202B\u206D\u206B\u200B\u206F\u206A\u200B\u200D\u206E\u202C\u202E\u206E\u200C\u206E\u200D\u202C\u202E(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u200D\u200B\u206C\u206C\u202C\u200C\u202D\u206D\u200D\u206C\u202B\u206F\u202C\u202D\u200C\u200D\u206C\u206A\u202A\u206C\u200D\u206F\u200D\u206B\u206D\u200D\u202B\u200C\u206C\u202A\u206D\u206C\u200F\u202B\u202C\u202A\u206E\u206F\u202A\u202A\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
							base.ReactOwnerEvent<UnitEventArgs>(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u202C\u202D\u206A\u200C\u200C\u200F\u202B\u200B\u200C\u206D\u200D\u200B\u206B\u202A\u200F\u202D\u202D\u206E\u202A\u200C\u200B\u206C\u202B\u206D\u206F\u202B\u200B\u206D\u200E\u200C\u200D\u200F\u202C\u206E\u200B\u200D\u200E\u200F\u202E\u206D\u202E(FlandreSpellBreakSeDef.FlandreSpellBreakSe.\u200D\u200B\u206C\u206C\u202C\u200C\u202D\u206D\u200D\u206C\u202B\u206F\u202C\u202D\u200C\u200D\u206C\u206A\u202A\u206C\u200D\u206F\u200D\u206B\u206D\u200D\u202B\u200C\u206C\u202A\u206D\u206C\u200F\u202B\u202C\u202A\u206E\u206F\u202A\u202A\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnded));
							num = (int)((num3 * 680639901U) ^ 1221580036U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
			{
				FlandreSpellBreakSeDef.FlandreSpellBreakSe.<OnOwnerTurnStarted>d__1 <OnOwnerTurnStarted>d__ = new FlandreSpellBreakSeDef.FlandreSpellBreakSe.<OnOwnerTurnStarted>d__1(-2);
				<OnOwnerTurnStarted>d__.<>3__args = args;
				return <OnOwnerTurnStarted>d__;
			}

			private IEnumerable<BattleAction> OnOwnerTurnEnded(UnitEventArgs args)
			{
				FlandreSpellBreakSeDef.FlandreSpellBreakSe.<OnOwnerTurnEnded>d__2 <OnOwnerTurnEnded>d__ = new FlandreSpellBreakSeDef.FlandreSpellBreakSe.<OnOwnerTurnEnded>d__2(-2);
				<OnOwnerTurnEnded>d__.<>4__this = this;
				return <OnOwnerTurnEnded>d__;
			}

			static Unit \u200D\u200B\u206C\u206C\u202C\u200C\u202D\u206D\u200D\u206C\u202B\u206F\u202C\u202D\u200C\u200D\u206C\u206A\u202A\u206C\u200D\u206F\u200D\u206B\u206D\u200D\u202B\u200C\u206C\u202A\u206D\u206C\u200F\u202B\u202C\u202A\u206E\u206F\u202A\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static int \u206F\u202D\u206E\u206A\u206C\u200C\u200C\u200E\u206F\u206C\u206E\u200D\u202A\u206F\u206E\u202C\u200D\u202A\u206A\u206B\u200E\u202C\u202D\u200F\u202D\u202D\u206C\u200B\u202B\u202E\u200D\u200D\u206C\u206A\u202D\u206A\u206D\u202E\u206D\u200D\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}

			static Reactor \u200D\u202B\u200B\u200F\u206A\u200B\u200B\u206D\u206B\u206F\u200D\u202B\u202C\u206B\u200F\u202E\u202D\u206E\u200C\u202E\u206B\u206A\u202E\u200E\u200F\u200E\u206A\u206F\u200F\u202E\u202D\u206F\u206F\u202B\u202E\u200D\u202B\u202A\u200C\u206C\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static GameEvent<UnitEventArgs> \u206B\u200C\u200C\u206B\u206A\u202A\u206A\u206D\u202D\u206E\u202D\u200C\u202C\u200D\u202E\u200B\u202D\u202D\u206E\u200C\u206E\u202E\u200C\u206E\u202B\u206D\u206B\u200B\u206F\u206A\u200B\u200D\u206E\u202C\u202E\u206E\u200C\u206E\u200D\u202C\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<UnitEventArgs> \u202C\u202D\u206A\u200C\u200C\u200F\u202B\u200B\u200C\u206D\u200D\u200B\u206B\u202A\u200F\u202D\u202D\u206E\u202A\u200C\u200B\u206C\u202B\u206D\u206F\u202B\u200B\u206D\u200E\u200C\u200D\u200F\u202C\u206E\u200B\u200D\u200E\u200F\u202E\u206D\u202E(Unit A_0)
			{
				return A_0.TurnEnded;
			}
		}
	}
}
