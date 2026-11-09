using System;
using System.Collections;
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
	public sealed class FlandreForbiddenGamesSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1211167622);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreForbiddenGamesSeDef.\u202A\u202B\u200F\u200E\u202A\u200C\u200C\u202B\u206C\u202A\u206D\u202B\u202A\u200E\u206F\u206A\u206D\u206B\u202D\u202C\u206E\u200E\u206B\u200D\u206A\u202E\u200D\u202B\u206B\u202C\u202D\u202C\u200B\u202C\u206F\u206B\u206C\u200D\u200D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreForbiddenGamesSeDef.\u200B\u200D\u200B\u206C\u200F\u202C\u200D\u200B\u200E\u202C\u206B\u202B\u202B\u202D\u200C\u200D\u202D\u206E\u206F\u206A\u206A\u206B\u202D\u202C\u200B\u200F\u200C\u206F\u202A\u200F\u206E\u200F\u202C\u202B\u206C\u202A\u202B\u200B\u200C\u200E\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1220299794), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreForbiddenGamesSeDef.\u202D\u200E\u206C\u202A\u200E\u202A\u206D\u206D\u200B\u202C\u200E\u200D\u206B\u200C\u200C\u200E\u206F\u202E\u200D\u200B\u206F\u206E\u200F\u202E\u206D\u206C\u206D\u202C\u206E\u202C\u202A\u200F\u206A\u206B\u202C\u202A\u206C\u202D\u206D\u200D\u202E(BepinexPlugin.sequenceTable, FlandreForbiddenGamesSeDef.\u202D\u206F\u202C\u202A\u206F\u206E\u202B\u200B\u200E\u202D\u206C\u202A\u206C\u202E\u202A\u202A\u200C\u200E\u206E\u206A\u206D\u200E\u200F\u200F\u202D\u202A\u200B\u206F\u206C\u206B\u206B\u202D\u202A\u206C\u206C\u200E\u202C\u202E\u200E\u206C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u202A\u202B\u200F\u200E\u202A\u200C\u200C\u202B\u206C\u202A\u206D\u202B\u202A\u200E\u206F\u206A\u206D\u206B\u202D\u202C\u206E\u200E\u206B\u200D\u206A\u202E\u200D\u202B\u206B\u202C\u202D\u202C\u200B\u202C\u206F\u206B\u206C\u200D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200B\u200D\u200B\u206C\u200F\u202C\u200D\u200B\u200E\u202C\u206B\u202B\u202B\u202D\u200C\u200D\u202D\u206E\u206F\u206A\u206A\u206B\u202D\u202C\u200B\u200F\u200C\u206F\u202A\u200F\u206E\u200F\u202C\u202B\u206C\u202A\u202B\u200B\u200C\u200E\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202D\u206F\u202C\u202A\u206F\u206E\u202B\u200B\u200E\u202D\u206C\u202A\u206C\u202E\u202A\u202A\u200C\u200E\u206E\u206A\u206D\u200E\u200F\u200F\u202D\u202A\u200B\u206F\u206C\u206B\u206B\u202D\u202A\u206C\u206C\u200E\u202C\u202E\u200E\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u200E\u206C\u202A\u200E\u202A\u206D\u206D\u200B\u202C\u200E\u200D\u206B\u200C\u200C\u200E\u206F\u202E\u200D\u200B\u206F\u206E\u200F\u202E\u206D\u206C\u206D\u202C\u206E\u202C\u202A\u200F\u206A\u206B\u202C\u202A\u206C\u202D\u206D\u200D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreForbiddenGamesSeDef))]
		public sealed class FlandreForbiddenGamesSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				IEnumerator<EnemyUnit> enumerator = FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200F\u206F\u202E\u202A\u202E\u206D\u200C\u200F\u202A\u202E\u200F\u206E\u202C\u200B\u206E\u202A\u206E\u202D\u206C\u200D\u200E\u200F\u202D\u200D\u206D\u202C\u206E\u202A\u200F\u202D\u202C\u206D\u202B\u200B\u202D\u200B\u202D\u206B\u206E\u200C\u202E(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200D\u202C\u206C\u206C\u202D\u206C\u200E\u200E\u200D\u202B\u202A\u206E\u206E\u200B\u200C\u206C\u200B\u206A\u206E\u202A\u200E\u206C\u206B\u202A\u206E\u202A\u202B\u206C\u206E\u206D\u200E\u202B\u202A\u202C\u202D\u206C\u200E\u202E\u200C\u200E\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_004E:
						int num = (FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200F\u206F\u202B\u200B\u202D\u200F\u200F\u206E\u202D\u206F\u202E\u202C\u206B\u200D\u206F\u200F\u202C\u206D\u202C\u206C\u202E\u202C\u200D\u206C\u200C\u202B\u202C\u206C\u206C\u200F\u200B\u206F\u202D\u202D\u202E\u200E\u206B\u206D\u200F\u200F\u202E(enumerator) ? 483302057 : 1144622693);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~num2 * -973569187)) % 5U)
							{
							case 0U:
								num = 483302057;
								continue;
							case 1U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = -410005226;
								continue;
							}
							case 3U:
							{
								EnemyUnit enemyUnit;
								base.ReactOwnerEvent<UnitEventArgs>(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200E\u206B\u200E\u206C\u200F\u202B\u200B\u206F\u206B\u202A\u206C\u200C\u200E\u200C\u206A\u200D\u200E\u200C\u200F\u202B\u202A\u206C\u206B\u206A\u206B\u206A\u206B\u206E\u200F\u200C\u202B\u206E\u206E\u202B\u200E\u200D\u200E\u206C\u206F\u202C\u202E(enemyUnit), new EventSequencedReactor<UnitEventArgs>(this.OnEnemyTurnStarted));
								num = (int)((num3 * 628315253U) ^ 546251466U);
								continue;
							}
							case 4U:
								goto IL_004E;
							}
							goto Block_4;
						}
					}
					Block_4:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0093:
							int num4 = 323931382;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~num2 * -973569187)) % 3U)
								{
								case 0U:
									goto IL_0093;
								case 1U:
									FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200F\u206C\u200C\u206A\u206D\u202E\u200E\u202B\u206E\u202A\u202D\u202B\u202D\u202B\u206E\u206A\u206B\u206C\u202A\u206A\u200C\u200B\u202E\u202D\u200D\u200F\u206E\u202D\u206C\u206E\u206F\u206C\u202A\u200D\u200B\u206A\u200D\u200B\u200E\u200D\u202E(enumerator);
									num4 = (int)((num3 * 341404151U) ^ 1267223015U);
									continue;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
				base.HandleOwnerEvent<UnitEventArgs>(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u202B\u202D\u202C\u206E\u206E\u200E\u202E\u200B\u206E\u206A\u206B\u202E\u200D\u202E\u202D\u200F\u202B\u200B\u200B\u206C\u206F\u200C\u202D\u200F\u202C\u202A\u200C\u206B\u202B\u202E\u200B\u200C\u200C\u202D\u206D\u200F\u206D\u202C\u206C\u202C\u202E(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200D\u202C\u206C\u206C\u202D\u206C\u200E\u200E\u200D\u202B\u202A\u206E\u206E\u200B\u200C\u206C\u200B\u206A\u206E\u202A\u200E\u206C\u206B\u202A\u206E\u202A\u202B\u206C\u206E\u206D\u200E\u202B\u202A\u202C\u202D\u206C\u200E\u202E\u200C\u200E\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
				for (;;)
				{
					IL_00EB:
					int num5 = 1141474752;
					for (;;)
					{
						int num2 = num5;
						uint num3;
						switch ((num3 = (uint)(~num2 * -973569187)) % 3U)
						{
						case 0U:
							goto IL_00EB;
						case 1U:
							base.HandleOwnerEvent<GameEventArgs>(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200B\u202C\u202E\u202D\u206D\u202C\u200B\u200C\u200C\u202E\u206C\u206C\u202A\u206C\u202C\u202C\u206D\u200E\u202C\u200F\u202E\u200C\u206A\u200B\u206E\u206F\u206F\u206B\u202E\u206D\u202E\u200B\u206A\u200B\u206E\u206A\u200B\u206D\u206F\u202B\u202E(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200D\u202C\u206C\u206C\u202D\u206C\u200E\u200E\u200D\u202B\u202A\u206E\u206E\u200B\u200C\u206C\u200B\u206A\u206E\u202A\u200E\u206C\u206B\u202A\u206E\u202A\u202B\u206C\u206E\u206D\u200E\u202B\u202A\u202C\u202D\u206C\u200E\u202E\u200C\u200E\u202E(this)), delegate(GameEventArgs _)
							{
								int num6 = FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u206E\u202C\u200D\u206D\u206E\u206E\u202C\u202A\u200D\u206A\u200F\u202E\u200C\u206C\u206E\u206F\u202E\u200F\u200F\u202A\u202E\u200F\u206F\u206D\u202C\u206A\u206A\u200E\u200B\u206D\u202C\u202D\u202D\u200E\u202C\u202D\u206F\u200D\u206D\u202B\u202E(this);
								for (;;)
								{
									IL_0007:
									int num7 = -379474013;
									for (;;)
									{
										int num8 = num7;
										uint num9;
										switch ((num9 = (uint)((-1881090975 ^ 117541353) - ((num8 ^ (~-250244110 + (550873425 + 887199919) - 556184611)) + (959638083 ^ -2088686451 ^ (-687902393 * -755220423))))) % 5U)
										{
										case 0U:
											goto IL_0007;
										case 2U:
											this.React(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u202C\u206E\u206A\u202D\u202A\u202C\u206F\u200D\u200D\u206E\u200E\u200C\u206D\u202C\u202E\u206B\u202C\u200E\u200B\u202A\u206B\u206F\u202E\u202E\u206B\u206C\u206A\u206F\u200C\u202B\u200E\u202B\u206D\u206D\u206F\u202D\u206B\u200E\u206E\u202E\u202E(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u206D\u202D\u206C\u200C\u202A\u200F\u200C\u202A\u202C\u202A\u202D\u200D\u206C\u206F\u200C\u206F\u206A\u206C\u206D\u200E\u206C\u202E\u200D\u202C\u202E\u206C\u200C\u200D\u206A\u200E\u202E\u206B\u206E\u202E\u200D\u206D\u206A\u202A\u200E\u206C\u202E(this, true, 0f)));
											num7 = (int)((num9 * 3016450642U) ^ 815946473U);
											continue;
										case 3U:
											FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u206F\u202E\u206D\u200D\u202B\u206B\u206C\u202B\u200F\u206E\u206B\u200E\u206D\u200E\u202A\u206A\u200F\u200C\u206A\u200E\u202B\u200B\u202C\u200C\u202D\u202E\u202B\u206E\u200B\u200C\u202D\u200B\u200F\u206A\u202E\u206A\u202C\u200E\u206F\u202A\u202E(this, num6 - 1);
											num7 = (int)((num9 * 2088795069U) ^ 2011834453U);
											continue;
										case 4U:
											num7 = (int)(((FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u206E\u202C\u200D\u206D\u206E\u206E\u202C\u202A\u200D\u206A\u200F\u202E\u200C\u206C\u206E\u206F\u202E\u200F\u200F\u202A\u202E\u200F\u206F\u206D\u202C\u206A\u206A\u200E\u200B\u206D\u202C\u202D\u202D\u200E\u202C\u202D\u206F\u200D\u206D\u202B\u202E(this) > 0) ? 2874315115U : 2012312764U) ^ (num9 * 1433449176U));
											continue;
										}
										return;
									}
								}
							});
							num5 = (int)((num3 * 383997508U) ^ 2710524131U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnEnemyTurnStarted(UnitEventArgs args)
			{
				FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.<OnEnemyTurnStarted>d__1 <OnEnemyTurnStarted>d__ = new FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.<OnEnemyTurnStarted>d__1(-2);
				<OnEnemyTurnStarted>d__.<>3__args = args;
				return <OnEnemyTurnStarted>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactOwnerEvent<UnitEventArgs>(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u200E\u206B\u200E\u206C\u200F\u202B\u200B\u206F\u206B\u202A\u206C\u200C\u200E\u200C\u206A\u200D\u200E\u200C\u200F\u202B\u202A\u206C\u206B\u206A\u206B\u206A\u206B\u206E\u200F\u200C\u202B\u206E\u206E\u202B\u200E\u200D\u200E\u206C\u206F\u202C\u202E(FlandreForbiddenGamesSeDef.FlandreForbiddenGamesSe.\u206F\u206A\u202B\u206B\u206B\u202D\u202C\u202D\u202D\u202B\u202D\u202D\u202E\u200F\u202E\u202B\u200B\u206F\u202C\u206E\u206F\u202E\u200D\u206D\u200B\u206A\u202D\u202A\u200B\u206D\u206D\u206C\u200E\u200B\u202A\u206D\u200D\u202C\u206C\u202A\u202E(args)), new EventSequencedReactor<UnitEventArgs>(this.OnEnemyTurnStarted));
			}

			static BattleController \u200D\u202C\u206C\u206C\u202D\u206C\u200E\u200E\u200D\u202B\u202A\u206E\u206E\u200B\u200C\u206C\u200B\u206A\u206E\u202A\u200E\u206C\u206B\u202A\u206E\u202A\u202B\u206C\u206E\u206D\u200E\u202B\u202A\u202C\u202D\u206C\u200E\u202E\u200C\u200E\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u200F\u206F\u202E\u202A\u202E\u206D\u200C\u200F\u202A\u202E\u200F\u206E\u202C\u200B\u206E\u202A\u206E\u202D\u206C\u200D\u200E\u200F\u202D\u200D\u206D\u202C\u206E\u202A\u200F\u202D\u202C\u206D\u202B\u200B\u202D\u200B\u202D\u206B\u206E\u200C\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<UnitEventArgs> \u200E\u206B\u200E\u206C\u200F\u202B\u200B\u206F\u206B\u202A\u206C\u200C\u200E\u200C\u206A\u200D\u200E\u200C\u200F\u202B\u202A\u206C\u206B\u206A\u206B\u206A\u206B\u206E\u200F\u200C\u202B\u206E\u206E\u202B\u200E\u200D\u200E\u206C\u206F\u202C\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static bool \u200F\u206F\u202B\u200B\u202D\u200F\u200F\u206E\u202D\u206F\u202E\u202C\u206B\u200D\u206F\u200F\u202C\u206D\u202C\u206C\u202E\u202C\u200D\u206C\u200C\u202B\u202C\u206C\u206C\u200F\u200B\u206F\u202D\u202D\u202E\u200E\u206B\u206D\u200F\u200F\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200F\u206C\u200C\u206A\u206D\u202E\u200E\u202B\u206E\u202A\u202D\u202B\u202D\u202B\u206E\u206A\u206B\u206C\u202A\u206A\u200C\u200B\u202E\u202D\u200D\u200F\u206E\u202D\u206C\u206E\u206F\u206C\u202A\u200D\u200B\u206A\u200D\u200B\u200E\u200D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u202B\u202D\u202C\u206E\u206E\u200E\u202E\u200B\u206E\u206A\u206B\u202E\u200D\u202E\u202D\u200F\u202B\u200B\u200B\u206C\u206F\u200C\u202D\u200F\u202C\u202A\u200C\u206B\u202B\u202E\u200B\u200C\u200C\u202D\u206D\u200F\u206D\u202C\u206C\u202C\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static GameEvent<GameEventArgs> \u200B\u202C\u202E\u202D\u206D\u202C\u200B\u200C\u200C\u202E\u206C\u206C\u202A\u206C\u202C\u202C\u206D\u200E\u202C\u200F\u202E\u200C\u206A\u200B\u206E\u206F\u206F\u206B\u202E\u206D\u202E\u200B\u206A\u200B\u206E\u206A\u200B\u206D\u206F\u202B\u202E(BattleController A_0)
			{
				return A_0.RoundEnded;
			}

			static Unit \u206F\u206A\u202B\u206B\u206B\u202D\u202C\u202D\u202D\u202B\u202D\u202D\u202E\u200F\u202E\u202B\u200B\u206F\u202C\u206E\u206F\u202E\u200D\u206D\u200B\u206A\u202D\u202A\u200B\u206D\u206D\u206C\u200E\u200B\u202A\u206D\u200D\u202C\u206C\u202A\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			static int \u206E\u202C\u200D\u206D\u206E\u206E\u202C\u202A\u200D\u206A\u200F\u202E\u200C\u206C\u206E\u206F\u202E\u200F\u200F\u202A\u202E\u200F\u206F\u206D\u202C\u206A\u206A\u200E\u200B\u206D\u202C\u202D\u202D\u200E\u202C\u202D\u206F\u200D\u206D\u202B\u202E(StatusEffect A_0)
			{
				return A_0.Duration;
			}

			static void \u206F\u202E\u206D\u200D\u202B\u206B\u206C\u202B\u200F\u206E\u206B\u200E\u206D\u200E\u202A\u206A\u200F\u200C\u206A\u200E\u202B\u200B\u202C\u200C\u202D\u202E\u202B\u206E\u200B\u200C\u202D\u200B\u200F\u206A\u202E\u206A\u202C\u200E\u206F\u202A\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Duration = A_1;
			}

			static RemoveStatusEffectAction \u206D\u202D\u206C\u200C\u202A\u200F\u200C\u202A\u202C\u202A\u202D\u200D\u206C\u206F\u200C\u206F\u206A\u206C\u206D\u200E\u206C\u202E\u200D\u202C\u202E\u206C\u200C\u200D\u206A\u200E\u202E\u206B\u206E\u202E\u200D\u206D\u206A\u202A\u200E\u206C\u202E(StatusEffect A_0, bool A_1, float A_2)
			{
				return new RemoveStatusEffectAction(A_0, A_1, A_2);
			}

			static Reactor \u202C\u206E\u206A\u202D\u202A\u202C\u206F\u200D\u200D\u206E\u200E\u200C\u206D\u202C\u202E\u206B\u202C\u200E\u200B\u202A\u206B\u206F\u202E\u202E\u206B\u206C\u206A\u206F\u200C\u202B\u200E\u202B\u206D\u206D\u206F\u202D\u206B\u200E\u206E\u202E\u202E(BattleAction A_0)
			{
				return A_0;
			}
		}
	}
}
