using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
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
	public sealed class FlandreForbiddenScarletCuriositySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(733536326);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreForbiddenScarletCuriositySeDef.\u200C\u202C\u202D\u200E\u206A\u206E\u200E\u200D\u202B\u206D\u202E\u206D\u206B\u206C\u206D\u202D\u200F\u202C\u202C\u202E\u206C\u200B\u206F\u202A\u206E\u200D\u206F\u200D\u200F\u206D\u202C\u200F\u206E\u200B\u206C\u202A\u202D\u200F\u202C\u202E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreForbiddenScarletCuriositySeDef.\u202E\u202D\u200B\u200D\u202B\u202C\u202C\u206F\u200F\u200E\u202D\u200D\u202C\u206B\u202B\u200C\u202D\u202D\u202B\u202C\u200D\u206A\u202A\u206A\u206B\u206F\u206B\u200D\u202C\u200B\u206A\u206D\u202E\u206D\u202C\u200B\u200E\u202D\u200D\u202C\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-429795048), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreForbiddenScarletCuriositySeDef.\u202B\u206E\u206A\u200E\u200D\u206C\u202B\u200E\u200C\u202D\u202B\u206E\u206F\u206B\u202A\u202C\u206B\u202B\u206B\u200E\u202E\u202E\u202A\u200C\u206F\u200D\u200C\u202D\u202E\u200F\u202B\u200B\u206C\u202A\u200D\u206D\u200C\u200D\u206D\u200E\u202E(BepinexPlugin.sequenceTable, FlandreForbiddenScarletCuriositySeDef.\u200D\u200F\u200B\u206A\u206B\u200D\u206A\u206D\u202C\u206F\u200F\u202E\u202C\u206A\u206E\u200F\u202B\u202A\u200B\u206F\u206B\u202E\u202A\u200C\u200D\u200F\u206C\u200B\u206F\u200B\u206F\u202D\u202A\u202D\u200F\u202E\u202B\u206F\u200C\u206F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", -2, StatusEffectType.Special, false, true, null, true, new StackType?(StackType.Max), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1493588461));
		}

		static BatchLocalization \u200C\u202C\u202D\u200E\u206A\u206E\u200E\u200D\u202B\u206D\u202E\u206D\u206B\u206C\u206D\u202D\u200F\u202C\u202C\u202E\u206C\u200B\u206F\u202A\u206E\u200D\u206F\u200D\u200F\u206D\u202C\u200F\u206E\u200B\u206C\u202A\u202D\u200F\u202C\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202E\u202D\u200B\u200D\u202B\u202C\u202C\u206F\u200F\u200E\u202D\u200D\u202C\u206B\u202B\u200C\u202D\u202D\u202B\u202C\u200D\u206A\u202A\u206A\u206B\u206F\u206B\u200D\u202C\u200B\u206A\u206D\u202E\u206D\u202C\u200B\u200E\u202D\u200D\u202C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200D\u200F\u200B\u206A\u206B\u200D\u206A\u206D\u202C\u206F\u200F\u202E\u202C\u206A\u206E\u200F\u202B\u202A\u200B\u206F\u206B\u202E\u202A\u200C\u200D\u200F\u206C\u200B\u206F\u200B\u206F\u202D\u202A\u202D\u200F\u202E\u202B\u206F\u200C\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206E\u206A\u200E\u200D\u206C\u202B\u200E\u200C\u202D\u202B\u206E\u206F\u206B\u202A\u202C\u206B\u202B\u206B\u200E\u202E\u202E\u202A\u200C\u206F\u200D\u200C\u202D\u202E\u200F\u202B\u200B\u206C\u202A\u200D\u206D\u200C\u200D\u206D\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreForbiddenScarletCuriositySeDef))]
		public sealed class FlandreForbiddenScarletCuriositySe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<>c__DisplayClass0_0 CS$<>8__locals1 = new FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<>c__DisplayClass0_0();
				for (;;)
				{
					IL_0006:
					int num = 1283411234;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)((num2 - -(-(~1231686413))) * 1031233647))) % 6U)
						{
						case 0U:
						{
							PlayerUnit playerUnit;
							CS$<>8__locals1.flandre = playerUnit as FlandrePlayerUnitDef.FlandrePlayerUnit;
							if (CS$<>8__locals1.flandre != null)
							{
								num = (int)((num3 * 15527207U) ^ 1621754489U);
								continue;
							}
							return;
						}
						case 1U:
						{
							PlayerUnit playerUnit = FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u200F\u206D\u202A\u206F\u206C\u206E\u206F\u206D\u202E\u200C\u202E\u202C\u202E\u202C\u206B\u200E\u206E\u206E\u202A\u200D\u200E\u206E\u200B\u202E\u202B\u202E\u206D\u200F\u200B\u200B\u200C\u200E\u200E\u200B\u202E\u200E\u202D\u200C\u206C\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206E\u200B\u200B\u200B\u202C\u206C\u202E\u206B\u202E\u206A\u200C\u202A\u200C\u200C\u202E\u206D\u202B\u206A\u202E\u202C\u200E\u206F\u200E\u200F\u206F\u206E\u200C\u202B\u202D\u202C\u206D\u206E\u206C\u206F\u206D\u200F\u202A\u200B\u202A\u202E(this));
							num = (int)((num3 * 1277062571U) ^ 2357297736U);
							continue;
						}
						case 2U:
							FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u202E\u206B\u206A\u200B\u200C\u200E\u206D\u206F\u206B\u206A\u200E\u206E\u202A\u202C\u206C\u200D\u206C\u200C\u206B\u206C\u200F\u202D\u200C\u200D\u202D\u202E\u206E\u202C\u200B\u206D\u202A\u206B\u206A\u206A\u200C\u202C\u200F\u206D\u200E\u202C\u202E(Singleton<GameMaster>.Instance, CS$<>8__locals1.<OnAdded>g__coroutine1|0());
							num = (int)((num3 * 750810595U) ^ 4231909074U);
							continue;
						case 4U:
							goto IL_0006;
						case 5U:
							this.React(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206F\u206F\u200F\u206C\u200C\u206A\u202A\u200B\u202E\u206B\u206F\u206D\u200F\u200C\u206D\u202E\u206D\u200D\u200B\u202E\u200D\u206E\u202D\u200C\u206E\u202E\u200E\u206C\u206C\u202B\u200C\u202C\u206F\u206A\u202E\u206E\u206D\u202B\u200D\u200D\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206D\u206A\u200E\u200E\u206A\u206B\u202B\u202A\u202B\u202E\u202D\u206C\u206B\u200F\u206E\u206B\u206F\u200E\u206F\u202A\u206B\u200B\u202E\u202B\u202A\u206C\u206E\u206D\u206E\u202B\u202B\u206B\u200D\u200E\u200E\u206C\u200B\u202B\u206D\u206C\u202E(CS$<>8__locals1.flandre, 0f)));
							num = (int)((num3 * 497265947U) ^ 4262319507U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.ReactOwnerEvent<StatusEffectApplyEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u202A\u202C\u206F\u200D\u202C\u200F\u206C\u202A\u200E\u206C\u200B\u200D\u200F\u206F\u206A\u200F\u202B\u200D\u200C\u200D\u200C\u200D\u202E\u200F\u206E\u202D\u206F\u202C\u206E\u200D\u206E\u202E\u200C\u206C\u202B\u202A\u202E\u206E\u200B\u206C\u202E(CS$<>8__locals1.flandre), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnPlayerStatusEffectAdding));
				base.ReactOwnerEvent<StatusEffectEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u200D\u202D\u200B\u206F\u202D\u202E\u202B\u202A\u200E\u200D\u200E\u206C\u200D\u200D\u206B\u200E\u200B\u206C\u206C\u200D\u206E\u206A\u206D\u206D\u206B\u200C\u200E\u206A\u206E\u200F\u200F\u200F\u206D\u200F\u206A\u202A\u200C\u202A\u202E\u206D\u202E(CS$<>8__locals1.flandre), new EventSequencedReactor<StatusEffectEventArgs>(this.OnPlayerStatusEffectRemoving));
				base.HandleOwnerEvent<DamageDealingEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206C\u206D\u206B\u200C\u202E\u202E\u200E\u206C\u202A\u200C\u200E\u206B\u200B\u200F\u206B\u206E\u206B\u202A\u202D\u200B\u200E\u202A\u202A\u200E\u200D\u202E\u200C\u206B\u200F\u200D\u206A\u202E\u200D\u200F\u200D\u206C\u200D\u202B\u206A\u202E(CS$<>8__locals1.flandre), new GameEventHandler<DamageDealingEventArgs>(this.OnPlayerDamageDealing), GameEventPriority.ConfigDefault);
				IEnumerator<EnemyUnit> enumerator = FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u202A\u206E\u200D\u202B\u202A\u206F\u206C\u206E\u200E\u202C\u202C\u202C\u200E\u206F\u206B\u200D\u206F\u200C\u202E\u200F\u200F\u206E\u206D\u202B\u202E\u202E\u206B\u206F\u200F\u202B\u200D\u200E\u202A\u206B\u202B\u202E\u202E\u200F\u200C\u202D\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206E\u200B\u200B\u200B\u202C\u206C\u202E\u206B\u202E\u206A\u200C\u202A\u200C\u200C\u202E\u206D\u202B\u206A\u202E\u202C\u200E\u206F\u200E\u200F\u206F\u206E\u200C\u202B\u202D\u202C\u206D\u206E\u206C\u206F\u206D\u200F\u202A\u200B\u202A\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0183:
						int num4 = ((!FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u202E\u200B\u206B\u200B\u206A\u200F\u206C\u200D\u200E\u200E\u200D\u202E\u206A\u200E\u202D\u206D\u202A\u206E\u202C\u200F\u206E\u200B\u206C\u202C\u200C\u200C\u200D\u206F\u206A\u200E\u200B\u206A\u206F\u202A\u202D\u206C\u200B\u202E\u202E\u202B\u202E(enumerator)) ? 997500324 : 1960295489);
						for (;;)
						{
							int num2 = num4;
							uint num3;
							switch ((num3 = (uint)(~(uint)((num2 - -(-(~1231686413))) * 1031233647))) % 5U)
							{
							case 0U:
							{
								EnemyUnit enemyUnit;
								base.ReactOwnerEvent<DamageEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u200D\u206F\u206E\u202C\u200B\u206E\u206B\u200D\u206D\u202C\u202C\u200C\u206E\u202E\u206C\u202E\u206E\u200C\u202A\u206F\u202B\u202E\u200F\u200B\u206C\u202C\u200E\u206D\u202E\u202B\u200C\u202B\u206F\u206D\u206D\u202A\u200D\u206B\u206D\u200E\u202E(enemyUnit), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
								num4 = (int)((num3 * 2143062633U) ^ 3232295221U);
								continue;
							}
							case 1U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num4 = -200808393;
								continue;
							}
							case 3U:
								num4 = 1960295489;
								continue;
							case 4U:
								goto IL_0183;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_01DA:
							int num5 = -483534541;
							for (;;)
							{
								int num2 = num5;
								uint num3;
								switch ((num3 = (uint)(~(uint)((num2 - -(-(~1231686413))) * 1031233647))) % 3U)
								{
								case 0U:
									goto IL_01DA;
								case 2U:
									FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206E\u200D\u202C\u206C\u200E\u206E\u202A\u202A\u206C\u206A\u206A\u202D\u206B\u206D\u202B\u200B\u200D\u202B\u200D\u200B\u206B\u200D\u206E\u206A\u202E\u206A\u206F\u200B\u202E\u202C\u206F\u200E\u202B\u206B\u200F\u200C\u202C\u200C\u200D\u206F\u202E(enumerator);
									num5 = (int)((num3 * 2219955821U) ^ 1334078847U);
									continue;
								}
								goto Block_8;
							}
						}
						Block_8:;
					}
				}
				base.HandleOwnerEvent<UnitEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206A\u200E\u202A\u206D\u200F\u202E\u202D\u206F\u206B\u202C\u206E\u206D\u200B\u202B\u200E\u206B\u206D\u202A\u206B\u202A\u206B\u206B\u206D\u202E\u200F\u202B\u206A\u202D\u206D\u200D\u202E\u202E\u206A\u206D\u200E\u206D\u200E\u206E\u206F\u206C\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206E\u200B\u200B\u200B\u202C\u206C\u202E\u206B\u202E\u206A\u200C\u202A\u200C\u200C\u202E\u206D\u202B\u206A\u202E\u202C\u200E\u206F\u200E\u200F\u206F\u206E\u200C\u202B\u202D\u202C\u206D\u206E\u206C\u206F\u206D\u200F\u202A\u200B\u202A\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			}

			protected override void OnRemoved(Unit unit)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206A\u200E\u202A\u206C\u200C\u206D\u206D\u202D\u206E\u206E\u200B\u202B\u200C\u200E\u202C\u206B\u206D\u206B\u200B\u202B\u200E\u202E\u200C\u206E\u206C\u206D\u200B\u202E\u202A\u206E\u206C\u206B\u206E\u202C\u202A\u206F\u200E\u202A\u202D\u200E\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206F\u206B\u206E\u206E\u202A\u206A\u206E\u206C\u200E\u200E\u206A\u202D\u202A\u200F\u202A\u206A\u200C\u200E\u202D\u202A\u200F\u202C\u200E\u200E\u200B\u200F\u200D\u202E\u206D\u206A\u206E\u202B\u200B\u206F\u206B\u206A\u202A\u206A\u206E\u206F\u202E(this)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_0011:
					int num = 1536375194;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)((num2 ^ (-(--1974644949) ^ (-1175153946 - -2091561753 * 1972731707))) + (-519531992 * -659368543 - (1024295188 - -1612849430))))) % 4U)
						{
						case 0U:
							flandrePlayerUnit.FlandreSpellCircle = false;
							flandrePlayerUnit.BossStationFinished = false;
							num = (int)((num3 * 1984873780U) ^ 3395315953U);
							continue;
						case 1U:
							num = (int)(((flandrePlayerUnit == null) ? 633717445U : 1441906231U) ^ (num3 * 3841868308U));
							continue;
						case 3U:
							goto IL_0011;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnPlayerStatusEffectAdding>d__2 <OnPlayerStatusEffectAdding>d__ = new FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnPlayerStatusEffectAdding>d__2(-2);
				<OnPlayerStatusEffectAdding>d__.<>4__this = this;
				<OnPlayerStatusEffectAdding>d__.<>3__args = args;
				return <OnPlayerStatusEffectAdding>d__;
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectRemoving(StatusEffectEventArgs args)
			{
				FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnPlayerStatusEffectRemoving>d__3 <OnPlayerStatusEffectRemoving>d__ = new FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnPlayerStatusEffectRemoving>d__3(-2);
				<OnPlayerStatusEffectRemoving>d__.<>4__this = this;
				<OnPlayerStatusEffectRemoving>d__.<>3__args = args;
				return <OnPlayerStatusEffectRemoving>d__;
			}

			private void OnPlayerDamageDealing(DamageDealingEventArgs args)
			{
				DamageInfo damageInfo = FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206E\u206A\u200D\u200C\u206A\u206B\u202B\u200F\u200C\u206E\u206A\u202B\u206C\u206D\u206F\u206D\u200D\u200E\u202D\u206D\u202D\u200E\u206F\u206F\u206E\u202E\u202B\u200C\u206E\u200C\u206B\u200D\u206F\u202B\u200B\u206F\u200B\u206C\u202E\u202E\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -712317188;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(~(num2 - (~(~-123699778) ^ (--1528903136 * -1859374103)))) ^ -774548621)) % 5U)
						{
						case 0U:
							goto IL_0007;
						case 1U:
							damageInfo.Damage = damageInfo.Amount * (float)(1 + FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u202A\u206B\u200D\u206D\u206F\u202C\u206B\u200E\u202A\u200C\u200F\u206D\u200B\u202B\u206C\u202C\u202B\u200B\u202E\u202B\u200E\u200F\u206B\u202A\u202D\u200E\u206B\u202C\u206A\u202A\u202D\u206B\u206E\u200F\u206D\u206B\u206A\u202D\u206D\u200C\u202E(this));
							FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206D\u206B\u202E\u202C\u206B\u206A\u202E\u202D\u200C\u206D\u202B\u206A\u202E\u200E\u206E\u202A\u200E\u202E\u206D\u206A\u202E\u202A\u200D\u206E\u200C\u202B\u202D\u200E\u200E\u206A\u202D\u200E\u200D\u206B\u202E\u206E\u206B\u200B\u206B\u206E\u202E(args, damageInfo);
							num = (int)((num3 * 2774051182U) ^ 3623950674U);
							continue;
						case 3U:
							num = (int)(((damageInfo.DamageType == DamageType.Attack) ? 3249609489U : 1039812709U) ^ (num3 * 3278033670U));
							continue;
						case 4U:
							FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u200C\u206A\u206F\u206C\u200E\u206D\u200C\u206C\u206B\u202B\u200C\u206C\u200C\u206A\u206F\u202E\u202E\u206E\u206E\u200C\u202A\u202A\u206E\u200C\u202C\u206B\u206D\u200B\u202C\u206F\u206C\u206F\u202A\u206D\u200B\u202B\u206E\u206A\u206D\u200F\u202E(args, this);
							num = (int)((num3 * 1358869333U) ^ 3102751517U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnEnemyDamageReceived(DamageEventArgs args)
			{
				FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnEnemyDamageReceived>d__5 <OnEnemyDamageReceived>d__ = new FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.<OnEnemyDamageReceived>d__5(-2);
				<OnEnemyDamageReceived>d__.<>4__this = this;
				<OnEnemyDamageReceived>d__.<>3__args = args;
				return <OnEnemyDamageReceived>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactOwnerEvent<DamageEventArgs>(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u200D\u206F\u206E\u202C\u200B\u206E\u206B\u200D\u206D\u202C\u202C\u200C\u206E\u202E\u206C\u202E\u206E\u200C\u202A\u206F\u202B\u202E\u200F\u200B\u206C\u202C\u200E\u206D\u202E\u202B\u200C\u202B\u206F\u206D\u206D\u202A\u200D\u206B\u206D\u200E\u202E(FlandreForbiddenScarletCuriositySeDef.FlandreForbiddenScarletCuriositySe.\u206C\u206E\u200B\u202D\u202E\u200F\u202A\u202D\u200F\u200E\u202E\u202D\u202C\u200B\u202B\u202E\u202B\u206E\u200B\u202D\u206B\u200B\u200D\u206F\u202B\u202D\u200C\u202C\u202C\u200C\u206D\u206B\u206A\u200B\u206C\u202D\u206A\u200B\u206A\u202E(args)), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
			}

			static BattleController \u206E\u200B\u200B\u200B\u202C\u206C\u202E\u206B\u202E\u206A\u200C\u202A\u200C\u200C\u202E\u206D\u202B\u206A\u202E\u202C\u200E\u206F\u200E\u200F\u206F\u206E\u200C\u202B\u202D\u202C\u206D\u206E\u206C\u206F\u206D\u200F\u202A\u200B\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200F\u206D\u202A\u206F\u206C\u206E\u206F\u206D\u202E\u200C\u202E\u202C\u202E\u202C\u206B\u200E\u206E\u206E\u202A\u200D\u200E\u206E\u200B\u202E\u202B\u202E\u206D\u200F\u200B\u200B\u200C\u200E\u200E\u200B\u202E\u200E\u202D\u200C\u206C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static Coroutine \u202E\u206B\u206A\u200B\u200C\u200E\u206D\u206F\u206B\u206A\u200E\u206E\u202A\u202C\u206C\u200D\u206C\u200C\u206B\u206C\u200F\u202D\u200C\u200D\u202D\u202E\u206E\u202C\u200B\u206D\u202A\u206B\u206A\u206A\u200C\u202C\u200F\u206D\u200E\u202C\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static RemoveAllNegativeStatusEffectAction \u206D\u206A\u200E\u200E\u206A\u206B\u202B\u202A\u202B\u202E\u202D\u206C\u206B\u200F\u206E\u206B\u206F\u200E\u206F\u202A\u206B\u200B\u202E\u202B\u202A\u206C\u206E\u206D\u206E\u202B\u202B\u206B\u200D\u200E\u200E\u206C\u200B\u202B\u206D\u206C\u202E(Unit A_0, float A_1)
			{
				return new RemoveAllNegativeStatusEffectAction(A_0, A_1);
			}

			static Reactor \u206F\u206F\u200F\u206C\u200C\u206A\u202A\u200B\u202E\u206B\u206F\u206D\u200F\u200C\u206D\u202E\u206D\u200D\u200B\u202E\u200D\u206E\u202D\u200C\u206E\u202E\u200E\u206C\u206C\u202B\u200C\u202C\u206F\u206A\u202E\u206E\u206D\u202B\u200D\u200D\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u202A\u202C\u206F\u200D\u202C\u200F\u206C\u202A\u200E\u206C\u200B\u200D\u200F\u206F\u206A\u200F\u202B\u200D\u200C\u200D\u200C\u200D\u202E\u200F\u206E\u202D\u206F\u202C\u206E\u200D\u206E\u202E\u200C\u206C\u202B\u202A\u202E\u206E\u200B\u206C\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			static GameEvent<StatusEffectEventArgs> \u200D\u202D\u200B\u206F\u202D\u202E\u202B\u202A\u200E\u200D\u200E\u206C\u200D\u200D\u206B\u200E\u200B\u206C\u206C\u200D\u206E\u206A\u206D\u206D\u206B\u200C\u200E\u206A\u206E\u200F\u200F\u200F\u206D\u200F\u206A\u202A\u200C\u202A\u202E\u206D\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoving;
			}

			static GameEvent<DamageDealingEventArgs> \u206C\u206D\u206B\u200C\u202E\u202E\u200E\u206C\u202A\u200C\u200E\u206B\u200B\u200F\u206B\u206E\u206B\u202A\u202D\u200B\u200E\u202A\u202A\u200E\u200D\u202E\u200C\u206B\u200F\u200D\u206A\u202E\u200D\u200F\u200D\u206C\u200D\u202B\u206A\u202E(Unit A_0)
			{
				return A_0.DamageDealing;
			}

			static IEnumerable<EnemyUnit> \u202A\u206E\u200D\u202B\u202A\u206F\u206C\u206E\u200E\u202C\u202C\u202C\u200E\u206F\u206B\u200D\u206F\u200C\u202E\u200F\u200F\u206E\u206D\u202B\u202E\u202E\u206B\u206F\u200F\u202B\u200D\u200E\u202A\u206B\u202B\u202E\u202E\u200F\u200C\u202D\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<DamageEventArgs> \u200D\u206F\u206E\u202C\u200B\u206E\u206B\u200D\u206D\u202C\u202C\u200C\u206E\u202E\u206C\u202E\u206E\u200C\u202A\u206F\u202B\u202E\u200F\u200B\u206C\u202C\u200E\u206D\u202E\u202B\u200C\u202B\u206F\u206D\u206D\u202A\u200D\u206B\u206D\u200E\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static bool \u202E\u200B\u206B\u200B\u206A\u200F\u206C\u200D\u200E\u200E\u200D\u202E\u206A\u200E\u202D\u206D\u202A\u206E\u202C\u200F\u206E\u200B\u206C\u202C\u200C\u200C\u200D\u206F\u206A\u200E\u200B\u206A\u206F\u202A\u202D\u206C\u200B\u202E\u202E\u202B\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u200D\u202C\u206C\u200E\u206E\u202A\u202A\u206C\u206A\u206A\u202D\u206B\u206D\u202B\u200B\u200D\u202B\u200D\u200B\u206B\u200D\u206E\u206A\u202E\u206A\u206F\u200B\u202E\u202C\u206F\u200E\u202B\u206B\u200F\u200C\u202C\u200C\u200D\u206F\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u206A\u200E\u202A\u206D\u200F\u202E\u202D\u206F\u206B\u202C\u206E\u206D\u200B\u202B\u200E\u206B\u206D\u202A\u206B\u202A\u206B\u206B\u206D\u202E\u200F\u202B\u206A\u202D\u206D\u200D\u202E\u202E\u206A\u206D\u200E\u206D\u200E\u206E\u206F\u206C\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static GameRunController \u206F\u206B\u206E\u206E\u202A\u206A\u206E\u206C\u200E\u200E\u206A\u202D\u202A\u200F\u202A\u206A\u200C\u200E\u202D\u202A\u200F\u202C\u200E\u200E\u200B\u200F\u200D\u202E\u206D\u206A\u206E\u202B\u200B\u206F\u206B\u206A\u202A\u206A\u206E\u206F\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static PlayerUnit \u206A\u200E\u202A\u206C\u200C\u206D\u206D\u202D\u206E\u206E\u200B\u202B\u200C\u200E\u202C\u206B\u206D\u206B\u200B\u202B\u200E\u202E\u200C\u206E\u206C\u206D\u200B\u202E\u202A\u206E\u206C\u206B\u206E\u202C\u202A\u206F\u200E\u202A\u202D\u200E\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static DamageInfo \u206E\u206A\u200D\u200C\u206A\u206B\u202B\u200F\u200C\u206E\u206A\u202B\u206C\u206D\u206F\u206D\u200D\u200E\u202D\u206D\u202D\u200E\u206F\u206F\u206E\u202E\u202B\u200C\u206E\u200C\u206B\u200D\u206F\u202B\u200B\u206F\u200B\u206C\u202E\u202E\u202E(DamageDealingEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static int \u202A\u206B\u200D\u206D\u206F\u202C\u206B\u200E\u202A\u200C\u200F\u206D\u200B\u202B\u206C\u202C\u202B\u200B\u202E\u202B\u200E\u200F\u206B\u202A\u202D\u200E\u206B\u202C\u206A\u202A\u202D\u206B\u206E\u200F\u206D\u206B\u206A\u202D\u206D\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static void \u206D\u206B\u202E\u202C\u206B\u206A\u202E\u202D\u200C\u206D\u202B\u206A\u202E\u200E\u206E\u202A\u200E\u202E\u206D\u206A\u202E\u202A\u200D\u206E\u200C\u202B\u202D\u200E\u200E\u206A\u202D\u200E\u200D\u206B\u202E\u206E\u206B\u200B\u206B\u206E\u202E(DamageDealingEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200C\u206A\u206F\u206C\u200E\u206D\u200C\u206C\u206B\u202B\u200C\u206C\u200C\u206A\u206F\u202E\u202E\u206E\u206E\u200C\u202A\u202A\u206E\u200C\u202C\u206B\u206D\u200B\u202C\u206F\u206C\u206F\u202A\u206D\u200B\u202B\u206E\u206A\u206D\u200F\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static Unit \u206C\u206E\u200B\u202D\u202E\u200F\u202A\u202D\u200F\u200E\u202E\u202D\u202C\u200B\u202B\u202E\u202B\u206E\u200B\u202D\u206B\u200B\u200D\u206F\u202B\u202D\u200C\u202C\u202C\u200C\u206D\u206B\u206A\u200B\u206C\u202D\u206A\u200B\u206A\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}
		}
	}
}
