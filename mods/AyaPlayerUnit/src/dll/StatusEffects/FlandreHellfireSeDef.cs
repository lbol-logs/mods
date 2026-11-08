using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
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

namespace AyaShameimaru.StatusEffects
{
	public sealed class FlandreHellfireSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(653136914);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreHellfireSeDef.\u206F\u200B\u200E\u202D\u206C\u206E\u200F\u202E\u206B\u206F\u200E\u206B\u200C\u206C\u206F\u200C\u206B\u202C\u200D\u200F\u202C\u206D\u202A\u202B\u202A\u206C\u206D\u202E\u202C\u202E\u200B\u200E\u200C\u202D\u202A\u202A\u206A\u206F\u206C\u200C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreHellfireSeDef.\u206E\u200F\u202B\u206A\u206C\u200E\u200E\u202E\u202E\u202A\u200E\u206F\u200F\u200C\u206A\u200B\u202B\u200D\u200B\u206D\u202B\u200C\u206A\u202C\u200D\u202E\u202A\u206B\u200C\u206E\u200D\u206B\u200F\u202E\u202A\u200D\u202A\u200D\u202D\u202A\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1503559060), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreHellfireSeDef.\u206E\u200B\u206E\u202B\u206D\u202E\u206B\u200B\u202B\u206F\u206C\u202A\u200D\u202C\u202B\u202E\u206C\u200F\u200E\u200D\u206B\u200C\u206F\u202C\u206A\u200E\u202E\u200F\u206C\u202A\u206F\u200C\u200D\u206F\u206B\u202E\u200C\u202E\u200B\u200C\u202E(BepinexPlugin.sequenceTable, FlandreHellfireSeDef.\u206D\u206C\u202A\u206F\u206D\u206F\u206B\u202E\u206E\u206B\u200F\u206D\u200B\u202D\u206E\u202D\u206E\u206F\u200F\u206F\u202D\u202D\u202B\u206E\u206F\u200E\u200D\u206C\u206A\u200E\u200E\u200F\u206B\u200F\u206F\u202B\u202E\u200D\u200C\u206A\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 8, StatusEffectType.Special, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1082366072), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1006645513));
		}

		static BatchLocalization \u206F\u200B\u200E\u202D\u206C\u206E\u200F\u202E\u206B\u206F\u200E\u206B\u200C\u206C\u206F\u200C\u206B\u202C\u200D\u200F\u202C\u206D\u202A\u202B\u202A\u206C\u206D\u202E\u202C\u202E\u200B\u200E\u200C\u202D\u202A\u202A\u206A\u206F\u206C\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206E\u200F\u202B\u206A\u206C\u200E\u200E\u202E\u202E\u202A\u200E\u206F\u200F\u200C\u206A\u200B\u202B\u200D\u200B\u206D\u202B\u200C\u206A\u202C\u200D\u202E\u202A\u206B\u200C\u206E\u200D\u206B\u200F\u202E\u202A\u200D\u202A\u200D\u202D\u202A\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206D\u206C\u202A\u206F\u206D\u206F\u206B\u202E\u206E\u206B\u200F\u206D\u200B\u202D\u206E\u202D\u206E\u206F\u200F\u206F\u202D\u202D\u202B\u206E\u206F\u200E\u200D\u206C\u206A\u200E\u200E\u200F\u206B\u200F\u206F\u202B\u202E\u200D\u200C\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206E\u200B\u206E\u202B\u206D\u202E\u206B\u200B\u202B\u206F\u206C\u202A\u200D\u202C\u202B\u202E\u206C\u200F\u200E\u200D\u206B\u200C\u206F\u202C\u206A\u200E\u202E\u200F\u206C\u202A\u206F\u200C\u200D\u206F\u206B\u202E\u200C\u202E\u200B\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreHellfireSeDef))]
		public sealed class FlandreHellfireSe : StatusEffect
		{
			public int Amount
			{
				get
				{
					if (!BepinexPlugin.AyaPhantasmMode.Value)
					{
						for (;;)
						{
							int num = 443548586;
							switch (((~num + -840890477) ^ (-596597055 ^ 198564215)) % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_003E;
							}
							break;
						}
						goto IL_0054;
						IL_003E:
						return FlandreHellfireSeDef.FlandreHellfireSe.\u206A\u200F\u200D\u202A\u202C\u206E\u200B\u206B\u206F\u206F\u200D\u206C\u202A\u202A\u200B\u202A\u206C\u202B\u206C\u200B\u202D\u206E\u206D\u200F\u202B\u206A\u202C\u202D\u206A\u200E\u200D\u206B\u200F\u200F\u200B\u200C\u206D\u206E\u202C\u206F\u202E(this);
					}
					IL_0054:
					return FlandreHellfireSeDef.FlandreHellfireSe.\u200D\u200D\u200D\u200D\u206E\u206C\u202E\u200E\u202E\u202E\u202D\u206B\u200F\u200E\u206C\u200F\u200C\u200F\u206E\u202C\u206D\u202D\u206C\u200C\u200D\u200B\u202C\u206E\u206A\u202A\u200F\u202C\u200D\u200B\u206E\u206D\u202B\u202A\u206B\u202A\u202E((float)FlandreHellfireSeDef.FlandreHellfireSe.\u206A\u200F\u200D\u202A\u202C\u206E\u200B\u206B\u206F\u206F\u200D\u206C\u202A\u202A\u200B\u202A\u206C\u202B\u206C\u200B\u202D\u206E\u206D\u200F\u202B\u206A\u202C\u202D\u206A\u200E\u200D\u206B\u200F\u200F\u200B\u200C\u206D\u206E\u202C\u206F\u202E(this) * 0.75f, MidpointRounding.AwayFromZero);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnAdded(Unit unit)
			{
				if (FlandreHellfireSeDef.FlandreHellfireSe.\u200B\u202D\u206B\u202D\u202A\u200B\u200B\u206C\u202E\u200B\u202E\u202D\u202D\u206F\u202E\u200F\u200F\u206D\u202B\u200D\u200E\u200D\u202E\u206A\u200F\u206A\u206D\u206F\u202A\u206A\u206B\u200B\u206C\u200B\u202D\u200C\u202B\u202B\u206A\u200C\u202E(this) is EnemyUnit)
				{
					goto IL_000D;
				}
				goto IL_0053;
				int num2;
				for (;;)
				{
					IL_0012:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(~num - 1591129572 + (455525771 - -1321813968) - 489075560)) % 6U)
					{
					case 0U:
						base.ReactOwnerEvent<DieEventArgs>(FlandreHellfireSeDef.FlandreHellfireSe.\u200E\u200F\u206C\u202B\u200E\u206E\u206D\u202B\u200F\u200C\u206D\u200B\u200B\u200E\u206A\u202C\u200C\u200B\u202C\u200F\u200C\u202E\u206C\u200F\u202B\u206B\u200F\u202E\u200B\u206B\u202C\u200F\u206C\u200D\u206F\u200D\u206D\u200D\u200F\u202E(FlandreHellfireSeDef.FlandreHellfireSe.\u200B\u202D\u206B\u202D\u202A\u200B\u200B\u206C\u202E\u200B\u202E\u202D\u202D\u206F\u202E\u200F\u200F\u206D\u202B\u200D\u200E\u200D\u202E\u206A\u200F\u206A\u206D\u206F\u202A\u206A\u206B\u200B\u206C\u200B\u202D\u200C\u202B\u202B\u206A\u200C\u202E(this)), new EventSequencedReactor<DieEventArgs>(this.OnOwnerDying));
						num2 = (int)((num3 * 1776806188U) ^ 2773890845U);
						continue;
					case 1U:
						base.ReactOwnerEvent<GameEventArgs>(FlandreHellfireSeDef.FlandreHellfireSe.\u206D\u200D\u202C\u200B\u202A\u206F\u200F\u200E\u206A\u202B\u206F\u206F\u206F\u202E\u206E\u202D\u202D\u202C\u202E\u202E\u200C\u200F\u202A\u206C\u206D\u202E\u202D\u200C\u202A\u200D\u202D\u202E\u206F\u202C\u206D\u206C\u200C\u206A\u200C\u202E\u202E(FlandreHellfireSeDef.FlandreHellfireSe.\u200D\u200D\u206E\u202E\u202A\u200C\u206C\u202E\u206C\u206D\u202E\u206D\u202B\u200E\u206B\u206A\u202A\u206D\u200E\u206E\u206E\u202B\u206B\u200D\u202C\u200F\u206F\u200F\u200B\u200B\u206E\u200F\u202A\u206E\u206F\u202E\u200E\u200D\u206B\u202D\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnAllEnemyTurnStarted));
						num2 = (int)((num3 * 3262109893U) ^ 3828683293U);
						continue;
					case 3U:
						this.React(FlandreHellfireSeDef.FlandreHellfireSe.\u200E\u202C\u202E\u200E\u200B\u202E\u202B\u206E\u200B\u202B\u206C\u206B\u206F\u206A\u206B\u206C\u202C\u202B\u200D\u206A\u202D\u206D\u200F\u206E\u206B\u206E\u206D\u202B\u200B\u200B\u206F\u206A\u202D\u200F\u200D\u202A\u202C\u200E\u200B\u202C\u202E(FlandreHellfireSeDef.FlandreHellfireSe.\u200E\u206C\u200E\u200C\u200D\u200F\u200E\u206B\u206C\u206E\u200E\u202D\u200F\u202E\u200E\u202C\u202E\u202E\u206D\u200C\u206C\u206B\u200D\u200C\u200C\u206F\u200E\u202A\u200C\u202D\u206C\u206E\u206A\u202A\u206F\u200E\u206A\u200C\u202A\u202C\u202E(FlandreHellfireSeDef.FlandreHellfireSe.\u200B\u202D\u206B\u202D\u202A\u200B\u200B\u206C\u202E\u200B\u202E\u202D\u202D\u206F\u202E\u200F\u200F\u206D\u202B\u200D\u200E\u200D\u202E\u206A\u200F\u206A\u206D\u206F\u202A\u206A\u206B\u200B\u206C\u200B\u202D\u200C\u202B\u202B\u206A\u200C\u202E(this), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(814385913), 0.1f, null, 0f, -1)));
						num2 = (int)((num3 * 2070841204U) ^ 1406889964U);
						continue;
					case 4U:
						goto IL_000D;
					case 5U:
						goto IL_0053;
					}
					break;
				}
				return;
				IL_000D:
				num2 = -1235434049;
				goto IL_0012;
				IL_0053:
				base.ReactOwnerEvent<UnitEventArgs>(FlandreHellfireSeDef.FlandreHellfireSe.\u200F\u206C\u202E\u206C\u200F\u206C\u206A\u200B\u202E\u206D\u200F\u202A\u200C\u202B\u202A\u202B\u206A\u200F\u206E\u206F\u202B\u202C\u202A\u202C\u200F\u202C\u202B\u200E\u206F\u202E\u200C\u202D\u202E\u200F\u200F\u200B\u202D\u206D\u206B\u200D\u202E(FlandreHellfireSeDef.FlandreHellfireSe.\u200B\u202D\u206B\u202D\u202A\u200B\u200B\u206C\u202E\u200B\u202E\u202D\u202D\u206F\u202E\u200F\u200F\u206D\u202B\u200D\u200E\u200D\u202E\u206A\u200F\u206A\u206D\u206F\u202A\u206A\u206B\u200B\u206C\u200B\u202D\u200C\u202B\u202B\u206A\u200C\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
				num2 = -1685582821;
				goto IL_0012;
			}

			private IEnumerable<BattleAction> OnAllEnemyTurnStarted(GameEventArgs args)
			{
				this.Triggered = true;
				return this.TakeEffect(true, false);
			}

			private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
			{
				FlandreHellfireSeDef.FlandreHellfireSe.<OnOwnerTurnStarted>d__5 <OnOwnerTurnStarted>d__ = new FlandreHellfireSeDef.FlandreHellfireSe.<OnOwnerTurnStarted>d__5(-2);
				<OnOwnerTurnStarted>d__.<>4__this = this;
				return <OnOwnerTurnStarted>d__;
			}

			private IEnumerable<BattleAction> OnOwnerDying(DieEventArgs args)
			{
				if (FlandreHellfireSeDef.FlandreHellfireSe.\u200D\u202B\u202D\u200C\u200E\u202A\u202B\u200E\u200F\u200C\u200F\u202B\u206D\u202D\u200B\u200E\u202B\u200C\u202D\u202B\u200B\u202A\u202E\u200B\u202E\u200C\u206F\u200D\u202D\u206A\u202C\u206E\u206B\u206F\u206C\u206A\u202E\u206D\u202B\u206F\u202E(args))
				{
					for (;;)
					{
						int num = -322841680;
						switch (-(~(~(num ^ ((216892525 + ~-973288035) * 1471305653)))) % 3)
						{
						case 0:
							continue;
						case 2:
							goto IL_003C;
						}
						break;
					}
					goto IL_004D;
					IL_003C:
					return null;
				}
				IL_004D:
				return this.TakeEffect(false, true);
			}

			public IEnumerable<BattleAction> TakeEffect(bool isHellfire, bool isBrimstone)
			{
				FlandreHellfireSeDef.FlandreHellfireSe.<TakeEffect>d__7 <TakeEffect>d__ = new FlandreHellfireSeDef.FlandreHellfireSe.<TakeEffect>d__7(-2);
				<TakeEffect>d__.<>4__this = this;
				<TakeEffect>d__.<>3__isHellfire = isHellfire;
				<TakeEffect>d__.<>3__isBrimstone = isBrimstone;
				return <TakeEffect>d__;
			}

			static int \u206A\u200F\u200D\u202A\u202C\u206E\u200B\u206B\u206F\u206F\u200D\u206C\u202A\u202A\u200B\u202A\u206C\u202B\u206C\u200B\u202D\u206E\u206D\u200F\u202B\u206A\u202C\u202D\u206A\u200E\u200D\u206B\u200F\u200F\u200B\u200C\u206D\u206E\u202C\u206F\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static int \u200D\u200D\u200D\u200D\u206E\u206C\u202E\u200E\u202E\u202E\u202D\u206B\u200F\u200E\u206C\u200F\u200C\u200F\u206E\u202C\u206D\u202D\u206C\u200C\u200D\u200B\u202C\u206E\u206A\u202A\u200F\u202C\u200D\u200B\u206E\u206D\u202B\u202A\u206B\u202A\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}

			static Unit \u200B\u202D\u206B\u202D\u202A\u200B\u200B\u206C\u202E\u200B\u202E\u202D\u202D\u206F\u202E\u200F\u200F\u206D\u202B\u200D\u200E\u200D\u202E\u206A\u200F\u206A\u206D\u206F\u202A\u206A\u206B\u200B\u206C\u200B\u202D\u200C\u202B\u202B\u206A\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static BattleController \u200D\u200D\u206E\u202E\u202A\u200C\u206C\u202E\u206C\u206D\u202E\u206D\u202B\u200E\u206B\u206A\u202A\u206D\u200E\u206E\u206E\u202B\u206B\u200D\u202C\u200F\u206F\u200F\u200B\u200B\u206E\u200F\u202A\u206E\u206F\u202E\u200E\u200D\u206B\u202D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u206D\u200D\u202C\u200B\u202A\u206F\u200F\u200E\u206A\u202B\u206F\u206F\u206F\u202E\u206E\u202D\u202D\u202C\u202E\u202E\u200C\u200F\u202A\u206C\u206D\u202E\u202D\u200C\u202A\u200D\u202D\u202E\u206F\u202C\u206D\u206C\u200C\u206A\u200C\u202E\u202E(BattleController A_0)
			{
				return A_0.AllEnemyTurnStarted;
			}

			static GameEvent<DieEventArgs> \u200E\u200F\u206C\u202B\u200E\u206E\u206D\u202B\u200F\u200C\u206D\u200B\u200B\u200E\u206A\u202C\u200C\u200B\u202C\u200F\u200C\u202E\u206C\u200F\u202B\u206B\u200F\u202E\u200B\u206B\u202C\u200F\u206C\u200D\u206F\u200D\u206D\u200D\u200F\u202E(Unit A_0)
			{
				return A_0.Dying;
			}

			static GameEvent<UnitEventArgs> \u200F\u206C\u202E\u206C\u200F\u206C\u206A\u200B\u202E\u206D\u200F\u202A\u200C\u202B\u202A\u202B\u206A\u200F\u206E\u206F\u202B\u202C\u202A\u202C\u200F\u202C\u202B\u200E\u206F\u202E\u200C\u202D\u202E\u200F\u200F\u200B\u202D\u206D\u206B\u200D\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static PerformAction \u200E\u206C\u200E\u200C\u200D\u200F\u200E\u206B\u206C\u206E\u200E\u202D\u200F\u202E\u200E\u202C\u202E\u202E\u206D\u200C\u206C\u206B\u200D\u200C\u200C\u206F\u200E\u202A\u200C\u202D\u206C\u206E\u206A\u202A\u206F\u200E\u206A\u200C\u202A\u202C\u202E(Unit A_0, string A_1, float A_2, string A_3, float A_4, int A_5)
			{
				return PerformAction.Animation(A_0, A_1, A_2, A_3, A_4, A_5);
			}

			static Reactor \u200E\u202C\u202E\u200E\u200B\u202E\u202B\u206E\u200B\u202B\u206C\u206B\u206F\u206A\u206B\u206C\u202C\u202B\u200D\u206A\u202D\u206D\u200F\u206E\u206B\u206E\u206D\u202B\u200B\u200B\u206F\u206A\u202D\u200F\u200D\u202A\u202C\u200E\u200B\u202C\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static bool \u200D\u202B\u202D\u200C\u200E\u202A\u202B\u200E\u200F\u200C\u200F\u202B\u206D\u202D\u200B\u200E\u202B\u200C\u202D\u202B\u200B\u202A\u202E\u200B\u202E\u200C\u206F\u200D\u202D\u206A\u202C\u206E\u206B\u206F\u206C\u206A\u202E\u206D\u202B\u206F\u202E(GameEventArgs A_0)
			{
				return A_0.IsCanceled;
			}

			private bool Triggered;
		}
	}
}
