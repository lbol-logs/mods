using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreAndThenWillThereBeNoneSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(65290016);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreAndThenWillThereBeNoneSeDef.\u202B\u206E\u202A\u206E\u206B\u206E\u206C\u202D\u202C\u200C\u200C\u202D\u206A\u206C\u206D\u202C\u202E\u206B\u202C\u202D\u202C\u206D\u202D\u200C\u200D\u202A\u200C\u202A\u206E\u206B\u202B\u202A\u202B\u206C\u206D\u200D\u206A\u200D\u206E\u202D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreAndThenWillThereBeNoneSeDef.\u206F\u202E\u200E\u200E\u200D\u202B\u202C\u202B\u200D\u206D\u202A\u206D\u206C\u200C\u202C\u200B\u206D\u206D\u200C\u206A\u206E\u206D\u206E\u206F\u200E\u202B\u200D\u202D\u200C\u202C\u206C\u202B\u206C\u206F\u200E\u202D\u206F\u202A\u206B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1164950743), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreAndThenWillThereBeNoneSeDef.\u200C\u202C\u200C\u206D\u200E\u200D\u200E\u202D\u206B\u200D\u200C\u206D\u206C\u200B\u202B\u206B\u200D\u200D\u200E\u200F\u200D\u200F\u206F\u200C\u202B\u202D\u202C\u200D\u202B\u200C\u206F\u202E\u200B\u206B\u200F\u202D\u206E\u206E\u202A\u206F\u202E(BepinexPlugin.sequenceTable, FlandreAndThenWillThereBeNoneSeDef.\u202D\u200B\u202B\u206D\u200E\u206E\u202E\u202E\u200C\u200F\u200E\u206A\u206F\u206C\u202D\u206B\u202B\u200E\u206B\u202B\u206D\u200D\u206C\u200C\u200C\u200D\u206F\u200F\u200F\u206F\u202E\u200D\u206B\u200F\u200F\u206A\u202C\u200C\u200B\u202A\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 30, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Max), false, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750));
		}

		static BatchLocalization \u202B\u206E\u202A\u206E\u206B\u206E\u206C\u202D\u202C\u200C\u200C\u202D\u206A\u206C\u206D\u202C\u202E\u206B\u202C\u202D\u202C\u206D\u202D\u200C\u200D\u202A\u200C\u202A\u206E\u206B\u202B\u202A\u202B\u206C\u206D\u200D\u206A\u200D\u206E\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206F\u202E\u200E\u200E\u200D\u202B\u202C\u202B\u200D\u206D\u202A\u206D\u206C\u200C\u202C\u200B\u206D\u206D\u200C\u206A\u206E\u206D\u206E\u206F\u200E\u202B\u200D\u202D\u200C\u202C\u206C\u202B\u206C\u206F\u200E\u202D\u206F\u202A\u206B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202D\u200B\u202B\u206D\u200E\u206E\u202E\u202E\u200C\u200F\u200E\u206A\u206F\u206C\u202D\u206B\u202B\u200E\u206B\u202B\u206D\u200D\u206C\u200C\u200C\u200D\u206F\u200F\u200F\u206F\u202E\u200D\u206B\u200F\u200F\u206A\u202C\u200C\u200B\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u202C\u200C\u206D\u200E\u200D\u200E\u202D\u206B\u200D\u200C\u206D\u206C\u200B\u202B\u206B\u200D\u200D\u200E\u200F\u200D\u200F\u206F\u200C\u202B\u202D\u202C\u200D\u202B\u200C\u206F\u202E\u200B\u206B\u200F\u202D\u206E\u206E\u202A\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreAndThenWillThereBeNoneSeDef))]
		public sealed class FlandreAndThenWillThereBeNoneSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u200D\u206F\u206B\u206C\u202C\u200C\u202A\u202C\u206F\u202D\u206A\u200F\u206D\u206D\u206E\u200F\u202C\u202D\u202D\u200F\u206B\u200E\u206A\u200C\u200E\u206B\u206D\u206E\u200C\u200D\u206B\u206D\u206B\u206F\u200F\u202C\u200E\u202E\u200D\u206F\u202E(Singleton<GameMaster>.Instance, this.<OnAdded>g__coroutine|0_0());
				base.ReactOwnerEvent<UnitEventArgs>(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u202B\u202E\u206D\u200F\u206D\u200F\u206C\u202E\u200C\u202B\u200B\u206C\u202B\u202B\u206F\u202C\u200B\u202A\u200B\u202D\u202E\u200D\u206C\u202E\u202A\u206B\u200B\u202B\u206E\u200E\u200C\u206B\u202B\u202A\u202D\u206D\u200D\u206F\u206F\u200C\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u202B\u206A\u206B\u202E\u200C\u200F\u206C\u202D\u202E\u200F\u202A\u200C\u202A\u206F\u200E\u200B\u202E\u200F\u202B\u200D\u200B\u200C\u202A\u206C\u206E\u200B\u202A\u200B\u206F\u200F\u202C\u206B\u206E\u206A\u200C\u202E\u202B\u202B\u200F\u206B\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u200E\u206B\u200F\u202E\u200D\u206F\u206F\u200E\u206D\u206E\u202A\u206C\u202C\u202E\u202D\u200C\u200E\u200B\u200C\u200D\u206E\u202A\u206E\u206E\u202E\u202E\u206A\u202A\u202D\u202C\u200C\u200C\u206E\u200B\u200F\u200E\u202B\u206E\u206E\u202C\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
				for (;;)
				{
					IL_0033:
					int num = 367459325;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 + ((~-1533688716 + 743382218) ^ (7443651 * (-1552418447 ^ 134494006))) - (-1246645506 - 195176708 * 254408369) - -2091104111 * 508585133) * -80799137)) % 4U)
						{
						case 0U:
							goto IL_0033;
						case 1U:
							base.ReactOwnerEvent<StatusEffectApplyEventArgs>(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206D\u202A\u200E\u200C\u200D\u206B\u200F\u200C\u206A\u206D\u202E\u200F\u202B\u206F\u202A\u200E\u200D\u200F\u200E\u200D\u200F\u206D\u200F\u202C\u206D\u202D\u202B\u206E\u200E\u200D\u206C\u202B\u206C\u200E\u200B\u206C\u202E\u200C\u200B\u200F\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u202B\u206A\u206B\u202E\u200C\u200F\u206C\u202D\u202E\u200F\u202A\u200C\u202A\u206F\u200E\u200B\u202E\u200F\u202B\u200D\u200B\u200C\u202A\u206C\u206E\u200B\u202A\u200B\u206F\u200F\u202C\u206B\u206E\u206A\u200C\u202E\u202B\u202B\u200F\u206B\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u200E\u206B\u200F\u202E\u200D\u206F\u206F\u200E\u206D\u206E\u202A\u206C\u202C\u202E\u202D\u200C\u200E\u200B\u200C\u200D\u206E\u202A\u206E\u206E\u202E\u202E\u206A\u202A\u202D\u202C\u200C\u200C\u206E\u200B\u200F\u200E\u202B\u206E\u206E\u202C\u202E(this))), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnPlayerStatusEffectAdding));
							num = (int)((num3 * 1033235930U) ^ 2072974370U);
							continue;
						case 2U:
							base.HandleOwnerEvent<DamageEventArgs>(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206E\u200D\u200C\u200C\u200D\u206C\u200B\u202C\u200C\u200F\u202C\u200D\u206D\u206C\u206D\u206D\u200D\u200E\u200C\u202C\u202B\u206F\u202D\u200F\u206B\u200E\u206A\u206E\u202C\u206C\u206F\u206B\u202D\u206B\u200B\u202C\u206D\u202D\u202A\u200C\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u202B\u206A\u206B\u202E\u200C\u200F\u206C\u202D\u202E\u200F\u202A\u200C\u202A\u206F\u200E\u200B\u202E\u200F\u202B\u200D\u200B\u200C\u202A\u206C\u206E\u200B\u202A\u200B\u206F\u200F\u202C\u206B\u206E\u206A\u200C\u202E\u202B\u202B\u200F\u206B\u202E(FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u200E\u206B\u200F\u202E\u200D\u206F\u206F\u200E\u206D\u206E\u202A\u206C\u202C\u202E\u202D\u200C\u200E\u200B\u200C\u200D\u206E\u202A\u206E\u206E\u202E\u202E\u206A\u202A\u202D\u202C\u200C\u200C\u206E\u200B\u200F\u200E\u202B\u206E\u206E\u202C\u202E(this))), new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
							num = (int)((num3 * 1684341672U) ^ 1799429794U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<OnPlayerTurnStarted>d__1 <OnPlayerTurnStarted>d__ = new FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<OnPlayerTurnStarted>d__1(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			private void OnPlayerDamageTaking(DamageEventArgs args)
			{
				if (FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206E\u200D\u206B\u200D\u200F\u202B\u200E\u202B\u202D\u206B\u202C\u206D\u202A\u200F\u202B\u206C\u206D\u206F\u202C\u206C\u202B\u202D\u206A\u202A\u206A\u202D\u200F\u206A\u200E\u206B\u206F\u200B\u206F\u200F\u202C\u202A\u202D\u200E\u202A\u200D\u202E(args).Amount > 0f)
				{
					for (;;)
					{
						IL_0018:
						int num = -1272755446;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~num2 - ~303998652) - 629137496)) % 4U)
							{
							case 0U:
								goto IL_0018;
							case 1U:
								FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206A\u202C\u202B\u206B\u202C\u202B\u206F\u200F\u200D\u206A\u206A\u200F\u206B\u206B\u202C\u200C\u206F\u206E\u206F\u202B\u200B\u206B\u200B\u206A\u202B\u202C\u200E\u206E\u200C\u202E\u202C\u202B\u200D\u206A\u202C\u200F\u200F\u200C\u200C\u206E\u202E(args, new DamageInfo(0f, 0f, 0f, FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206E\u200D\u206B\u200D\u200F\u202B\u200E\u202B\u202D\u206B\u202C\u206D\u202A\u200F\u202B\u206C\u206D\u206F\u202C\u206C\u202B\u202D\u206A\u202A\u206A\u202D\u200F\u206A\u200E\u206B\u206F\u200B\u206F\u200F\u202C\u202A\u202D\u200E\u202A\u200D\u202E(args).DamageType, FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206E\u200D\u206B\u200D\u200F\u202B\u200E\u202B\u202D\u206B\u202C\u206D\u202A\u200F\u202B\u206C\u206D\u206F\u202C\u206C\u202B\u202D\u206A\u202A\u206A\u202D\u200F\u206A\u200E\u206B\u206F\u200B\u206F\u200F\u202C\u202A\u202D\u200E\u202A\u200D\u202E(args).IsGrazed, FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206E\u200D\u206B\u200D\u200F\u202B\u200E\u202B\u202D\u206B\u202C\u206D\u202A\u200F\u202B\u206C\u206D\u206F\u202C\u206C\u202B\u202D\u206A\u202A\u206A\u202D\u200F\u206A\u200E\u206B\u206F\u200B\u206F\u200F\u202C\u202A\u202D\u200E\u202A\u200D\u202E(args).IsAccuracy, true));
								FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.\u206A\u202D\u206A\u202C\u200C\u206A\u202C\u200D\u200B\u206E\u206D\u200E\u206A\u206F\u206A\u202C\u200C\u206D\u202E\u206A\u200D\u206A\u202B\u200E\u206F\u206C\u200F\u202D\u202E\u202A\u200D\u202D\u200C\u202D\u206B\u200D\u206C\u200B\u202B\u200C\u202E(args, this);
								num = (int)((num3 * 2511047436U) ^ 1117762063U);
								continue;
							case 2U:
								this.\u206E\u202C\u206A\u202B\u206C\u202C\u200E\u200B\u206C\u200C\u206D\u200F\u202E\u200C\u202C\u202C\u206F\u200E\u206B\u200F\u206F\u206A\u200E\u200D\u202E\u200C\u202E\u206E\u206B\u202E\u206B\u200E\u200B\u202D\u206D\u202C\u206A\u206E\u200F\u206A\u202E();
								num = (int)((num3 * 2670534520U) ^ 543176265U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<OnPlayerStatusEffectAdding>d__3 <OnPlayerStatusEffectAdding>d__ = new FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<OnPlayerStatusEffectAdding>d__3(-2);
				<OnPlayerStatusEffectAdding>d__.<>4__this = this;
				<OnPlayerStatusEffectAdding>d__.<>3__args = args;
				return <OnPlayerStatusEffectAdding>d__;
			}

			[CompilerGenerated]
			private IEnumerator <OnAdded>g__coroutine|0_0()
			{
				FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<<OnAdded>g__coroutine|0_0>d <<OnAdded>g__coroutine|0_0>d = new FlandreAndThenWillThereBeNoneSeDef.FlandreAndThenWillThereBeNoneSe.<<OnAdded>g__coroutine|0_0>d(0);
				<<OnAdded>g__coroutine|0_0>d.<>4__this = this;
				return <<OnAdded>g__coroutine|0_0>d;
			}

			static Coroutine \u200D\u206F\u206B\u206C\u202C\u200C\u202A\u202C\u206F\u202D\u206A\u200F\u206D\u206D\u206E\u200F\u202C\u202D\u202D\u200F\u206B\u200E\u206A\u200C\u200E\u206B\u206D\u206E\u200C\u200D\u206B\u206D\u206B\u206F\u200F\u202C\u200E\u202E\u200D\u206F\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static BattleController \u200E\u206B\u200F\u202E\u200D\u206F\u206F\u200E\u206D\u206E\u202A\u206C\u202C\u202E\u202D\u200C\u200E\u200B\u200C\u200D\u206E\u202A\u206E\u206E\u202E\u202E\u206A\u202A\u202D\u202C\u200C\u200C\u206E\u200B\u200F\u200E\u202B\u206E\u206E\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202B\u206A\u206B\u202E\u200C\u200F\u206C\u202D\u202E\u200F\u202A\u200C\u202A\u206F\u200E\u200B\u202E\u200F\u202B\u200D\u200B\u200C\u202A\u206C\u206E\u200B\u202A\u200B\u206F\u200F\u202C\u206B\u206E\u206A\u200C\u202E\u202B\u202B\u200F\u206B\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202B\u202E\u206D\u200F\u206D\u200F\u206C\u202E\u200C\u202B\u200B\u206C\u202B\u202B\u206F\u202C\u200B\u202A\u200B\u202D\u202E\u200D\u206C\u202E\u202A\u206B\u200B\u202B\u206E\u200E\u200C\u206B\u202B\u202A\u202D\u206D\u200D\u206F\u206F\u200C\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<DamageEventArgs> \u206E\u200D\u200C\u200C\u200D\u206C\u200B\u202C\u200C\u200F\u202C\u200D\u206D\u206C\u206D\u206D\u200D\u200E\u200C\u202C\u202B\u206F\u202D\u200F\u206B\u200E\u206A\u206E\u202C\u206C\u206F\u206B\u202D\u206B\u200B\u202C\u206D\u202D\u202A\u200C\u202E(Unit A_0)
			{
				return A_0.DamageTaking;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u206D\u202A\u200E\u200C\u200D\u206B\u200F\u200C\u206A\u206D\u202E\u200F\u202B\u206F\u202A\u200E\u200D\u200F\u200E\u200D\u200F\u206D\u200F\u202C\u206D\u202D\u202B\u206E\u200E\u200D\u206C\u202B\u206C\u200E\u200B\u206C\u202E\u200C\u200B\u200F\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			static DamageInfo \u206E\u200D\u206B\u200D\u200F\u202B\u200E\u202B\u202D\u206B\u202C\u206D\u202A\u200F\u202B\u206C\u206D\u206F\u202C\u206C\u202B\u202D\u206A\u202A\u206A\u202D\u200F\u206A\u200E\u206B\u206F\u200B\u206F\u200F\u202C\u202A\u202D\u200E\u202A\u200D\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			void \u206E\u202C\u206A\u202B\u206C\u202C\u200E\u200B\u206C\u200C\u206D\u200F\u202E\u200C\u202C\u202C\u206F\u200E\u206B\u200F\u206F\u206A\u200E\u200D\u202E\u200C\u202E\u206E\u206B\u202E\u206B\u200E\u200B\u202D\u206D\u202C\u206A\u206E\u200F\u206A\u202E()
			{
				base.NotifyActivating();
			}

			static void \u206A\u202C\u202B\u206B\u202C\u202B\u206F\u200F\u200D\u206A\u206A\u200F\u206B\u206B\u202C\u200C\u206F\u206E\u206F\u202B\u200B\u206B\u200B\u206A\u202B\u202C\u200E\u206E\u200C\u202E\u202C\u202B\u200D\u206A\u202C\u200F\u200F\u200C\u200C\u206E\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u206A\u202D\u206A\u202C\u200C\u206A\u202C\u200D\u200B\u206E\u206D\u200E\u206A\u206F\u206A\u202C\u200C\u206D\u202E\u206A\u200D\u206A\u202B\u200E\u206F\u206C\u200F\u202D\u202E\u202A\u200D\u202D\u200C\u202D\u206B\u200D\u206C\u200B\u202B\u200C\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static Unit \u206E\u202E\u206D\u202D\u200E\u206A\u200C\u202A\u206D\u200C\u202A\u206F\u206B\u202B\u200C\u202B\u202A\u200E\u200F\u200C\u206E\u202B\u206E\u206A\u200F\u206C\u200F\u206C\u206A\u200C\u200D\u206E\u202C\u206B\u202D\u202A\u200F\u206E\u200C\u202B\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}
		}
	}
}
