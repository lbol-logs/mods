using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
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
	public sealed class FlandreKindLiesandGoodbyesSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(606482269);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreKindLiesandGoodbyesSeDef.\u206F\u200E\u200F\u202A\u202E\u200E\u202D\u206E\u206C\u206C\u202E\u200E\u202A\u206E\u202E\u202B\u206F\u202E\u202C\u206A\u206D\u206F\u202E\u200F\u206A\u200F\u206C\u206F\u202B\u202D\u206F\u200F\u202B\u202E\u200D\u206A\u200D\u206F\u202C\u202E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreKindLiesandGoodbyesSeDef.\u200E\u206D\u202C\u200B\u206E\u200F\u200F\u202C\u202E\u202C\u202D\u206B\u206F\u206D\u206D\u206A\u202E\u202D\u206B\u200B\u202E\u200B\u206B\u206F\u200E\u206A\u202B\u206C\u206C\u206F\u202D\u206A\u200F\u200F\u206B\u202E\u200C\u200F\u202E\u200C\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1286866612), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreKindLiesandGoodbyesSeDef.\u206C\u202C\u200F\u200E\u206F\u202B\u200D\u200C\u202B\u202D\u206E\u200E\u202B\u202A\u202B\u202B\u206A\u202A\u202E\u206F\u200B\u202E\u202C\u206E\u200D\u200F\u200F\u206E\u202A\u200C\u206B\u200F\u200B\u202E\u202A\u202A\u200E\u202B\u200E\u202E\u202E(BepinexPlugin.sequenceTable, FlandreKindLiesandGoodbyesSeDef.\u202E\u206C\u200C\u200C\u200E\u206B\u206C\u206C\u206F\u202B\u202A\u202C\u202B\u202C\u206E\u202D\u200F\u206F\u206A\u202D\u202A\u200B\u202B\u202C\u200E\u200B\u202D\u206B\u200C\u202E\u206C\u200F\u202A\u206E\u206C\u202C\u206D\u202E\u206B\u200D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 30, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2135997179), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2135997179));
		}

		static BatchLocalization \u206F\u200E\u200F\u202A\u202E\u200E\u202D\u206E\u206C\u206C\u202E\u200E\u202A\u206E\u202E\u202B\u206F\u202E\u202C\u206A\u206D\u206F\u202E\u200F\u206A\u200F\u206C\u206F\u202B\u202D\u206F\u200F\u202B\u202E\u200D\u206A\u200D\u206F\u202C\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200E\u206D\u202C\u200B\u206E\u200F\u200F\u202C\u202E\u202C\u202D\u206B\u206F\u206D\u206D\u206A\u202E\u202D\u206B\u200B\u202E\u200B\u206B\u206F\u200E\u206A\u202B\u206C\u206C\u206F\u202D\u206A\u200F\u200F\u206B\u202E\u200C\u200F\u202E\u200C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202E\u206C\u200C\u200C\u200E\u206B\u206C\u206C\u206F\u202B\u202A\u202C\u202B\u202C\u206E\u202D\u200F\u206F\u206A\u202D\u202A\u200B\u202B\u202C\u200E\u200B\u202D\u206B\u200C\u202E\u206C\u200F\u202A\u206E\u206C\u202C\u206D\u202E\u206B\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u202C\u200F\u200E\u206F\u202B\u200D\u200C\u202B\u202D\u206E\u200E\u202B\u202A\u202B\u202B\u206A\u202A\u202E\u206F\u200B\u202E\u202C\u206E\u200D\u200F\u200F\u206E\u202A\u200C\u206B\u200F\u200B\u202E\u202A\u202A\u200E\u202B\u200E\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreKindLiesandGoodbyesSeDef))]
		public sealed class FlandreKindLiesandGoodbyesSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u206E\u206E\u206E\u200F\u206E\u202C\u206B\u202B\u200C\u200B\u200D\u206D\u200C\u206E\u202E\u200E\u200D\u200C\u200C\u206B\u206C\u202B\u206E\u200F\u206C\u200D\u202A\u202D\u206F\u206C\u200D\u202A\u200E\u200B\u202E\u202D\u202E\u200E\u206F\u200E\u202E(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200F\u200B\u206B\u200C\u200F\u202C\u202E\u200E\u200D\u206F\u202A\u206C\u206B\u200D\u202C\u206C\u200B\u206C\u206F\u200E\u202C\u200E\u206C\u206A\u206A\u200D\u200C\u200E\u202A\u206B\u202D\u206A\u206A\u200D\u200D\u202C\u200D\u202E\u200F\u200E\u202E(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u202D\u202E\u200C\u206A\u202B\u206C\u200D\u202E\u206E\u202A\u206B\u200C\u200B\u202A\u202B\u200D\u206D\u200E\u206F\u202C\u202E\u206A\u206D\u206E\u200B\u200F\u202A\u200F\u206A\u206F\u206D\u200F\u206B\u200B\u202B\u206C\u202E\u202E\u206E\u202B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
				for (;;)
				{
					IL_0022:
					int num = -910041443;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(num2 - -(~(1058981559 * 920471132)) + -(-1641021690 + -1552859638))) % 3U)
						{
						case 0U:
							goto IL_0022;
						case 2U:
							base.HandleOwnerEvent<DamageEventArgs>(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200B\u206B\u202A\u200F\u206A\u200D\u200D\u200D\u206C\u206A\u200C\u206E\u200C\u202B\u206D\u200E\u200D\u202C\u206C\u202A\u202B\u200F\u206C\u202E\u206C\u206E\u206C\u200D\u202C\u200C\u202B\u200F\u206C\u206B\u206E\u200B\u200C\u202D\u200E\u200F\u202E(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200F\u200B\u206B\u200C\u200F\u202C\u202E\u200E\u200D\u206F\u202A\u206C\u206B\u200D\u202C\u206C\u200B\u206C\u206F\u200E\u202C\u200E\u206C\u206A\u206A\u200D\u200C\u200E\u202A\u206B\u202D\u206A\u206A\u200D\u200D\u202C\u200D\u202E\u200F\u200E\u202E(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u202D\u202E\u200C\u206A\u202B\u206C\u200D\u202E\u206E\u202A\u206B\u200C\u200B\u202A\u202B\u200D\u206D\u200E\u206F\u202C\u202E\u206A\u206D\u206E\u200B\u200F\u202A\u200F\u206A\u206F\u206D\u200F\u206B\u200B\u202B\u206C\u202E\u202E\u206E\u202B\u202E(this))), new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
							num = (int)((num3 * 3296975372U) ^ 818316480U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.<OnPlayerTurnStarted>d__1 <OnPlayerTurnStarted>d__ = new FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.<OnPlayerTurnStarted>d__1(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			private void OnPlayerDamageTaking(DamageEventArgs args)
			{
				int num = FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u206C\u206A\u206D\u206F\u200B\u202B\u200C\u200E\u206C\u202B\u200F\u200C\u202E\u202C\u202D\u206D\u206B\u202B\u202D\u202B\u200F\u200E\u202B\u202A\u202B\u202A\u202D\u200B\u206A\u202C\u206C\u200E\u200D\u206C\u206B\u202D\u206D\u206A\u202A\u202C\u202E(FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200B\u206E\u206D\u206B\u200B\u200E\u202A\u200D\u206D\u202C\u206B\u202C\u202D\u202E\u206A\u206A\u202E\u206A\u202E\u202E\u200D\u206D\u206E\u202B\u206E\u200B\u200E\u200F\u202E\u200C\u206E\u200E\u206A\u202B\u206D\u206D\u200B\u202D\u202B\u200F\u202E(args).Damage);
				for (;;)
				{
					IL_0014:
					int num2 = 1405494694;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-((num3 + (1263333565 ^ 1079297889 ^ --1591343929) * 1640333129) ^ -(-417797517 * -820787415)) ^ -1412536353)) % 6U)
						{
						case 0U:
							goto IL_0014;
						case 2U:
							FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u202A\u202B\u206D\u206D\u202E\u206F\u202E\u202C\u202B\u200D\u202A\u200E\u200D\u202D\u200E\u206E\u206B\u202A\u200D\u206D\u200B\u200D\u206B\u200F\u206F\u206F\u202B\u200D\u200B\u202E\u206A\u200E\u202B\u200F\u206D\u206C\u200D\u200E\u200F\u206B\u202E(args, FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200B\u206E\u206D\u206B\u200B\u200E\u202A\u200D\u206D\u202C\u206B\u202C\u202D\u202E\u206A\u206A\u202E\u206A\u202E\u202E\u200D\u206D\u206E\u202B\u206E\u200B\u200E\u200F\u202E\u200C\u206E\u200E\u206A\u202B\u206D\u206D\u200B\u202D\u202B\u200F\u202E(args).ReduceActualDamageBy(num));
							num2 = (int)((num4 * 2269205458U) ^ 1267693777U);
							continue;
						case 3U:
							this.\u206A\u200E\u202A\u202E\u200C\u206D\u206C\u202E\u206E\u206E\u200B\u202D\u202C\u206A\u206F\u206F\u202C\u202C\u202A\u206D\u202B\u200D\u202D\u206D\u202A\u202A\u206D\u200B\u200B\u200B\u200D\u206A\u202A\u200F\u206D\u202B\u202C\u206D\u200B\u202D\u202E();
							num2 = (int)((num4 * 4004478172U) ^ 640042163U);
							continue;
						case 4U:
							FlandreKindLiesandGoodbyesSeDef.FlandreKindLiesandGoodbyesSe.\u200C\u206B\u206A\u202C\u202E\u206C\u200D\u206A\u206D\u202E\u200B\u200F\u200E\u206C\u202A\u206A\u206D\u206E\u202E\u206D\u202B\u206B\u206C\u202C\u206A\u202B\u202D\u202E\u206A\u202E\u202C\u200D\u202C\u202B\u206E\u202C\u202A\u200F\u202A\u202D\u202E(args, this);
							num2 = (int)((num4 * 1884347676U) ^ 3548181220U);
							continue;
						case 5U:
							num2 = (int)(((num <= 0) ? 1610579521U : 1030147185U) ^ (num4 * 4025340313U));
							continue;
						}
						return;
					}
				}
			}

			static BattleController \u202D\u202E\u200C\u206A\u202B\u206C\u200D\u202E\u206E\u202A\u206B\u200C\u200B\u202A\u202B\u200D\u206D\u200E\u206F\u202C\u202E\u206A\u206D\u206E\u200B\u200F\u202A\u200F\u206A\u206F\u206D\u200F\u206B\u200B\u202B\u206C\u202E\u202E\u206E\u202B\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200F\u200B\u206B\u200C\u200F\u202C\u202E\u200E\u200D\u206F\u202A\u206C\u206B\u200D\u202C\u206C\u200B\u206C\u206F\u200E\u202C\u200E\u206C\u206A\u206A\u200D\u200C\u200E\u202A\u206B\u202D\u206A\u206A\u200D\u200D\u202C\u200D\u202E\u200F\u200E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206E\u206E\u206E\u200F\u206E\u202C\u206B\u202B\u200C\u200B\u200D\u206D\u200C\u206E\u202E\u200E\u200D\u200C\u200C\u206B\u206C\u202B\u206E\u200F\u206C\u200D\u202A\u202D\u206F\u206C\u200D\u202A\u200E\u200B\u202E\u202D\u202E\u200E\u206F\u200E\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<DamageEventArgs> \u200B\u206B\u202A\u200F\u206A\u200D\u200D\u200D\u206C\u206A\u200C\u206E\u200C\u202B\u206D\u200E\u200D\u202C\u206C\u202A\u202B\u200F\u206C\u202E\u206C\u206E\u206C\u200D\u202C\u200C\u202B\u200F\u206C\u206B\u206E\u200B\u200C\u202D\u200E\u200F\u202E(Unit A_0)
			{
				return A_0.DamageTaking;
			}

			static DamageInfo \u200B\u206E\u206D\u206B\u200B\u200E\u202A\u200D\u206D\u202C\u206B\u202C\u202D\u202E\u206A\u206A\u202E\u206A\u202E\u202E\u200D\u206D\u206E\u202B\u206E\u200B\u200E\u200F\u202E\u200C\u206E\u200E\u206A\u202B\u206D\u206D\u200B\u202D\u202B\u200F\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static int \u206C\u206A\u206D\u206F\u200B\u202B\u200C\u200E\u206C\u202B\u200F\u200C\u202E\u202C\u202D\u206D\u206B\u202B\u202D\u202B\u200F\u200E\u202B\u202A\u202B\u202A\u202D\u200B\u206A\u202C\u206C\u200E\u200D\u206C\u206B\u202D\u206D\u206A\u202A\u202C\u202E(float A_0)
			{
				return A_0.RoundToInt();
			}

			void \u206A\u200E\u202A\u202E\u200C\u206D\u206C\u202E\u206E\u206E\u200B\u202D\u202C\u206A\u206F\u206F\u202C\u202C\u202A\u206D\u202B\u200D\u202D\u206D\u202A\u202A\u206D\u200B\u200B\u200B\u200D\u206A\u202A\u200F\u206D\u202B\u202C\u206D\u200B\u202D\u202E()
			{
				base.NotifyActivating();
			}

			static void \u202A\u202B\u206D\u206D\u202E\u206F\u202E\u202C\u202B\u200D\u202A\u200E\u200D\u202D\u200E\u206E\u206B\u202A\u200D\u206D\u200B\u200D\u206B\u200F\u206F\u206F\u202B\u200D\u200B\u202E\u206A\u200E\u202B\u200F\u206D\u206C\u200D\u200E\u200F\u206B\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200C\u206B\u206A\u202C\u202E\u206C\u200D\u206A\u206D\u202E\u200B\u200F\u200E\u206C\u202A\u206A\u206D\u206E\u202E\u206D\u202B\u206B\u206C\u202C\u206A\u202B\u202D\u202E\u206A\u202E\u202C\u200D\u202C\u202B\u206E\u202C\u202A\u200F\u202A\u202D\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}
		}
	}
}
