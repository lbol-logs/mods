using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using HarmonyLib;
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
	public sealed class AyaHraesvelgrofTerminusSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(397982097);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaHraesvelgrofTerminusSeDef.\u202D\u202D\u200F\u200E\u206F\u206C\u206A\u206C\u202A\u200D\u206C\u202B\u200C\u202E\u200B\u206D\u206A\u202C\u206A\u200E\u206D\u206A\u200F\u202A\u206C\u202C\u206B\u200E\u202A\u206A\u206D\u202C\u200E\u206E\u202B\u206C\u206F\u200C\u202E\u202B\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaHraesvelgrofTerminusSeDef.\u202C\u202A\u206D\u202C\u206B\u200E\u200E\u200C\u200C\u206D\u206B\u202D\u202B\u200C\u202A\u206B\u202D\u200E\u202D\u200F\u200B\u200F\u206B\u202C\u202E\u200C\u206F\u206F\u206B\u206D\u206C\u202A\u200F\u200F\u200D\u202A\u206F\u206C\u202D\u206A\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(933723542), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaHraesvelgrofTerminusSeDef.\u202B\u202B\u202E\u206D\u206B\u200E\u206C\u206B\u206C\u200E\u202C\u200F\u206B\u202A\u206E\u200F\u206E\u202B\u200B\u206D\u206C\u206E\u202E\u200B\u206F\u202A\u200E\u202E\u206B\u200F\u206F\u200E\u206A\u206B\u200E\u202C\u200F\u202C\u200B\u202C\u202E(BepinexPlugin.sequenceTable, AyaHraesvelgrofTerminusSeDef.\u200C\u200E\u206D\u206C\u200B\u200B\u202A\u202D\u202E\u206B\u202D\u200D\u202E\u206F\u202B\u202C\u202E\u206B\u200B\u202B\u202A\u206C\u202E\u206F\u206D\u200D\u202E\u206D\u202C\u202D\u206D\u200D\u206A\u206A\u200F\u200E\u202A\u202E\u202D\u200F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Block | Keyword.Shield, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u202D\u202D\u200F\u200E\u206F\u206C\u206A\u206C\u202A\u200D\u206C\u202B\u200C\u202E\u200B\u206D\u206A\u202C\u206A\u200E\u206D\u206A\u200F\u202A\u206C\u202C\u206B\u200E\u202A\u206A\u206D\u202C\u200E\u206E\u202B\u206C\u206F\u200C\u202E\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202C\u202A\u206D\u202C\u206B\u200E\u200E\u200C\u200C\u206D\u206B\u202D\u202B\u200C\u202A\u206B\u202D\u200E\u202D\u200F\u200B\u200F\u206B\u202C\u202E\u200C\u206F\u206F\u206B\u206D\u206C\u202A\u200F\u200F\u200D\u202A\u206F\u206C\u202D\u206A\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200C\u200E\u206D\u206C\u200B\u200B\u202A\u202D\u202E\u206B\u202D\u200D\u202E\u206F\u202B\u202C\u202E\u206B\u200B\u202B\u202A\u206C\u202E\u206F\u206D\u200D\u202E\u206D\u202C\u202D\u206D\u200D\u206A\u206A\u200F\u200E\u202A\u202E\u202D\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u202B\u202E\u206D\u206B\u200E\u206C\u206B\u206C\u200E\u202C\u200F\u206B\u202A\u206E\u200F\u206E\u202B\u200B\u206D\u206C\u206E\u202E\u200B\u206F\u202A\u200E\u202E\u206B\u200F\u206F\u200E\u206A\u206B\u200E\u202C\u200F\u202C\u200B\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaHraesvelgrofTerminusSeDef))]
		public sealed class AyaHraesvelgrofTerminusSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				IEnumerator<EnemyUnit> enumerator = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202B\u202B\u206A\u206A\u202D\u206D\u206A\u202C\u200C\u202E\u206B\u200E\u200C\u206A\u202E\u206A\u202B\u200E\u206C\u200B\u200E\u200D\u202D\u206E\u200D\u202C\u200C\u202B\u200B\u202A\u202D\u202B\u202B\u206C\u206B\u202A\u206C\u200D\u200B\u200E\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this)).GetEnumerator();
				try
				{
					while (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(enumerator))
					{
						IEnumerator<StatusEffect> enumerator2 = enumerator.Current._statusEffects.Where((StatusEffect s) => AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<>c.\u200C\u202E\u206A\u206C\u202E\u206B\u206A\u206F\u202C\u200E\u202B\u200F\u200C\u200F\u206A\u200D\u206B\u202D\u202B\u202A\u206B\u206C\u202D\u206B\u200D\u206A\u206D\u206F\u206C\u206C\u200C\u206E\u200D\u206D\u202E\u200E\u202C\u206B\u200F\u202D\u202E(s) == StatusEffectType.Positive).GetEnumerator();
						try
						{
							for (;;)
							{
								IL_0091:
								int num = ((!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(enumerator2)) ? 435268350 : (-91622005));
								for (;;)
								{
									int num2 = num;
									switch ((~(~num2) - ~1003950533) % 4)
									{
									case 1:
										AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u200F\u200E\u202D\u206B\u206D\u200D\u206A\u202D\u200C\u200D\u206E\u202E\u200F\u202B\u206E\u206A\u202A\u200D\u206A\u206D\u200F\u206A\u200F\u200E\u206E\u206D\u206A\u200D\u206A\u200B\u206D\u202E\u206A\u200E\u200C\u202E\u202B\u206E\u206B\u202E(enumerator2.Current._ownerHandlerHolder);
										num = -793962139;
										continue;
									case 2:
										num = -91622005;
										continue;
									case 3:
										goto IL_0091;
									}
									goto Block_9;
								}
							}
							Block_9:;
						}
						finally
						{
							if (enumerator2 != null)
							{
								for (;;)
								{
									IL_00AF:
									int num3 = 50903086;
									for (;;)
									{
										int num2 = num3;
										uint num4;
										switch ((num4 = (uint)(~(~num2) - ~1003950533)) % 3U)
										{
										case 1U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(enumerator2);
											num3 = (int)((num4 * 593848117U) ^ 401498450U);
											continue;
										case 2U:
											goto IL_00AF;
										}
										goto Block_12;
									}
								}
								Block_12:;
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_00FE:
							int num5 = -237083015;
							for (;;)
							{
								int num2 = num5;
								uint num4;
								switch ((num4 = (uint)(~(~num2) - ~1003950533)) % 3U)
								{
								case 1U:
									AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(enumerator);
									num5 = (int)((num4 * 745481764U) ^ 1528395720U);
									continue;
								case 2U:
									goto IL_00FE;
								}
								goto Block_14;
							}
						}
						Block_14:;
					}
				}
				enumerator = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202B\u202B\u206A\u206A\u202D\u206D\u206A\u202C\u200C\u202E\u206B\u200E\u200C\u206A\u202E\u206A\u202B\u200E\u206C\u200B\u200E\u200D\u202D\u206E\u200D\u202C\u200C\u202B\u200B\u202A\u202D\u202B\u202B\u206C\u206B\u202A\u206C\u200D\u200B\u200E\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_01EF:
						int num6 = (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(enumerator) ? 414922509 : 983004997);
						for (;;)
						{
							int num2 = num6;
							uint num4;
							switch ((num4 = (uint)(~(~num2) - ~1003950533)) % 5U)
							{
							case 0U:
								num6 = 414922509;
								continue;
							case 2U:
								goto IL_01EF;
							case 3U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								base.HandleOwnerEvent<DamageEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u206B\u200B\u206A\u200E\u206C\u200F\u206B\u202E\u202C\u200E\u206B\u202E\u206E\u200B\u206E\u200B\u202C\u202D\u200E\u200D\u200D\u200D\u202C\u202E\u206E\u200F\u206B\u206C\u206B\u200C\u202E\u200E\u206A\u206F\u206F\u200F\u200C\u206C\u206E\u202E(enemyUnit), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageReceiving));
								base.HandleOwnerEvent<DamageEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200C\u200D\u200D\u206F\u206E\u202D\u202A\u202C\u200F\u206C\u206E\u206D\u202B\u202C\u202A\u206C\u202B\u202C\u206D\u206C\u206A\u206F\u200D\u202A\u206A\u202D\u206C\u202D\u206A\u202C\u200E\u206B\u206B\u206B\u200C\u206B\u200F\u202E\u200C\u200D\u202E(enemyUnit), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageTaking));
								num6 = 627463785;
								continue;
							}
							case 4U:
							{
								EnemyUnit enemyUnit;
								base.ReactOwnerEvent<StatusEffectApplyEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200B\u200B\u200B\u200F\u202C\u206F\u200D\u206E\u206C\u206A\u206B\u206E\u206F\u206F\u206E\u206C\u200B\u206B\u206E\u206C\u200C\u206F\u206B\u200E\u206D\u200B\u206E\u200F\u206E\u202C\u206D\u206F\u202B\u202B\u206F\u202C\u206C\u202B\u200C\u202C\u202E(enemyUnit), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
								num6 = (int)((num4 * 3499143957U) ^ 1407834119U);
								continue;
							}
							}
							goto Block_16;
						}
					}
					Block_16:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0210:
							int num7 = 799158943;
							for (;;)
							{
								int num2 = num7;
								uint num4;
								switch ((num4 = (uint)(~(~num2) - ~1003950533)) % 3U)
								{
								case 1U:
									AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(enumerator);
									num7 = (int)((num4 * 1499648210U) ^ 4208738147U);
									continue;
								case 2U:
									goto IL_0210;
								}
								goto Block_19;
							}
						}
						Block_19:;
					}
				}
				base.ReactOwnerEvent<UnitEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200D\u206B\u206B\u200E\u200C\u206C\u202E\u202B\u202C\u206E\u200D\u200B\u206F\u206C\u206E\u206E\u200C\u206F\u202E\u200C\u206C\u206A\u202C\u206A\u202A\u202C\u206C\u202B\u200F\u202D\u202B\u202E\u200D\u200B\u206D\u206B\u206F\u202C\u200D\u202E\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u200C\u206E\u200E\u206A\u202A\u202D\u200F\u202A\u200C\u200B\u202B\u202B\u206E\u200C\u206F\u202C\u200C\u202D\u206F\u202A\u206A\u202E\u206D\u202C\u202D\u200C\u202C\u200C\u206C\u202E\u206B\u202A\u202A\u202A\u202B\u206C\u200D\u206E\u202C\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
				for (;;)
				{
					IL_0271:
					int num8 = -527851469;
					for (;;)
					{
						int num2 = num8;
						uint num4;
						switch ((num4 = (uint)(~(~num2) - ~1003950533)) % 3U)
						{
						case 1U:
							base.HandleOwnerEvent<UnitEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200C\u202A\u200B\u202A\u202A\u202B\u206E\u206B\u206E\u206C\u200C\u206A\u200D\u200F\u200F\u202A\u200E\u200B\u200B\u202C\u202B\u202E\u206F\u202B\u206D\u206B\u200E\u206C\u202C\u206F\u200D\u200B\u200C\u202A\u206A\u200C\u200E\u200E\u206F\u206A\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
							num8 = (int)((num4 * 2825413167U) ^ 3938034296U);
							continue;
						case 2U:
							goto IL_0271;
						}
						return;
					}
				}
			}

			private void OnEnemyDamageReceiving(DamageEventArgs args)
			{
				DamageInfo damageInfo = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = 1824182372;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~-208787073 * 262273083 - (num2 ^ ((1560445594 * 421093991 + ~-349130170) * 184052919)) - (307529072 ^ 1718026356) - -806523200)) % 4U)
						{
						case 0U:
						{
							DamageInfo damageInfo2 = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args);
							damageInfo2.IsAccuracy = true;
							AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u206C\u206F\u206C\u200D\u202D\u206F\u206B\u202A\u202C\u202D\u202D\u206D\u202C\u206B\u202B\u200C\u206B\u202C\u202D\u202A\u202B\u200B\u202C\u200C\u206E\u206F\u202B\u200E\u206B\u200B\u200B\u200F\u206A\u206D\u202E\u202C\u200D\u200F\u202D\u202E(args, damageInfo2);
							AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206A\u200E\u206E\u202B\u202D\u202C\u202D\u202E\u206B\u200C\u200F\u206E\u202A\u206A\u200F\u206A\u202C\u202E\u200C\u202D\u200C\u202B\u200F\u206D\u200B\u202D\u200E\u206C\u200C\u200C\u202B\u202C\u200D\u202D\u200E\u202D\u200F\u202E\u200E\u202E(args, this);
							num = (int)((num3 * 3413748140U) ^ 2431741318U);
							continue;
						}
						case 2U:
							goto IL_0007;
						case 3U:
							num = (int)(((damageInfo.DamageType != DamageType.Attack) ? 3233944005U : 714387646U) ^ (num3 * 3915532637U));
							continue;
						}
						return;
					}
				}
			}

			private void OnEnemyDamageTaking(DamageEventArgs args)
			{
				AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u206C\u206F\u206C\u200D\u202D\u206F\u206B\u202A\u202C\u202D\u202D\u206D\u202C\u206B\u202B\u200C\u206B\u202C\u202D\u202A\u202B\u200B\u202C\u200C\u206E\u206F\u202B\u200E\u206B\u200B\u200B\u200F\u206A\u206D\u202E\u202C\u200D\u200F\u202D\u202E(args, new DamageInfo(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args).Amount, AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args).DamageType, AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args).IsGrazed, AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args).IsAccuracy, AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(args).DontBreakPerfect));
				for (;;)
				{
					IL_0051:
					int num = -1430736176;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-(num2 ^ (-1098727944 ^ ((708559137 * 1317724038) ^ (-746392985 - 160355002)))) + ~-194274965) ^ 1708156278)) % 3U)
						{
						case 0U:
							goto IL_0051;
						case 2U:
							AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206A\u200E\u206E\u202B\u202D\u202C\u202D\u202E\u206B\u200C\u200F\u206E\u202A\u206A\u200F\u206A\u202C\u202E\u200C\u202D\u200C\u202B\u200F\u206D\u200B\u202D\u200E\u206C\u200C\u200C\u202B\u202C\u200D\u202D\u200E\u202D\u200F\u202E\u200E\u202E(args, this);
							num = (int)((num3 * 861197813U) ^ 218889232U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
			{
				AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<OnEnemyStatusEffectAdded>d__6 <OnEnemyStatusEffectAdded>d__ = new AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<OnEnemyStatusEffectAdded>d__6(-2);
				<OnEnemyStatusEffectAdded>d__.<>3__args = args;
				return <OnEnemyStatusEffectAdded>d__;
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<OnPlayerTurnStarted>d__7 <OnPlayerTurnStarted>d__ = new AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<OnPlayerTurnStarted>d__7(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.HandleOwnerEvent<DamageEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u206B\u200B\u206A\u200E\u206C\u200F\u206B\u202E\u202C\u200E\u206B\u202E\u206E\u200B\u206E\u200B\u202C\u202D\u200E\u200D\u200D\u200D\u202C\u202E\u206E\u200F\u206B\u206C\u206B\u200C\u202E\u200E\u206A\u206F\u206F\u200F\u200C\u206C\u206E\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u202E\u202A\u200F\u200C\u202A\u200B\u206C\u202B\u202C\u202D\u202C\u200B\u206E\u206D\u206A\u206C\u200C\u200F\u206B\u206F\u202D\u206C\u206E\u200E\u200E\u202E\u206D\u200E\u200E\u200C\u206F\u206D\u206E\u200C\u200E\u206B\u200C\u202A\u200E\u202E(args)), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageReceiving));
				for (;;)
				{
					IL_001D:
					int num = -344425258;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num2 ^ (--1798416302 ^ ((1410537499 * -591206370) ^ -967160579))))) % 3U)
						{
						case 1U:
							base.HandleOwnerEvent<DamageEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200C\u200D\u200D\u206F\u206E\u202D\u202A\u202C\u200F\u206C\u206E\u206D\u202B\u202C\u202A\u206C\u202B\u202C\u206D\u206C\u206A\u206F\u200D\u202A\u206A\u202D\u206C\u202D\u206A\u202C\u200E\u206B\u206B\u206B\u200C\u206B\u200F\u202E\u200C\u200D\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u202E\u202A\u200F\u200C\u202A\u200B\u206C\u202B\u202C\u202D\u202C\u200B\u206E\u206D\u206A\u206C\u200C\u200F\u206B\u206F\u202D\u206C\u206E\u200E\u200E\u202E\u206D\u200E\u200E\u200C\u206F\u206D\u206E\u200C\u200E\u206B\u200C\u202A\u200E\u202E(args)), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageTaking));
							base.ReactOwnerEvent<StatusEffectApplyEventArgs>(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200B\u200B\u200B\u200F\u202C\u206F\u200D\u206E\u206C\u206A\u206B\u206E\u206F\u206F\u206E\u206C\u200B\u206B\u206E\u206C\u200C\u206F\u206B\u200E\u206D\u200B\u206E\u200F\u206E\u202C\u206D\u206F\u202B\u202B\u206F\u202C\u206C\u202B\u200C\u202C\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u202E\u202A\u200F\u200C\u202A\u200B\u206C\u202B\u202C\u202D\u202C\u200B\u206E\u206D\u206A\u206C\u200C\u200F\u206B\u206F\u202D\u206C\u206E\u200E\u200E\u202E\u206D\u200E\u200E\u200C\u206F\u206D\u206E\u200C\u200E\u206B\u200C\u202A\u200E\u202E(args)), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
							num = (int)((num3 * 1679525057U) ^ 1267186091U);
							continue;
						case 2U:
							goto IL_001D;
						}
						return;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				if (!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u206E\u206F\u200F\u206E\u200D\u202E\u206F\u206D\u200C\u206C\u202B\u206C\u200F\u206C\u206E\u202D\u200E\u206B\u206E\u200E\u202E\u206D\u202D\u200F\u206D\u200C\u202C\u202A\u206C\u200D\u206A\u200C\u200B\u202B\u202C\u200F\u200D\u200F\u200F\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this)))
				{
					IEnumerator<EnemyUnit> enumerator = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202B\u202B\u206A\u206A\u202D\u206D\u206A\u202C\u200C\u202E\u206B\u200E\u200C\u206A\u202E\u206A\u202B\u200E\u206C\u200B\u200E\u200D\u202D\u206E\u200D\u202C\u200C\u202B\u200B\u202A\u202D\u202B\u202B\u206C\u206B\u202A\u206C\u200D\u200B\u200E\u202E(AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(this)).GetEnumerator();
					try
					{
						while (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(enumerator))
						{
							IEnumerator<StatusEffect> enumerator2 = enumerator.Current._statusEffects.Where((StatusEffect s) => AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.<>c.\u200C\u202E\u206A\u206C\u202E\u206B\u206A\u206F\u202C\u200E\u202B\u200F\u200C\u200F\u206A\u200D\u206B\u202D\u202B\u202A\u206B\u206C\u202D\u206B\u200D\u206A\u206D\u206F\u206C\u206C\u200C\u206E\u200D\u206D\u202E\u200E\u202C\u206B\u200F\u202D\u202E(s) == StatusEffectType.Positive).GetEnumerator();
							try
							{
								for (;;)
								{
									IL_0120:
									int num = (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(enumerator2) ? 1566190617 : (-1075963025));
									for (;;)
									{
										int num2 = num;
										uint num3;
										StatusEffect statusEffect;
										int num4;
										int num6;
										int num7;
										int num8;
										int num9;
										int num10;
										switch ((num3 = (uint)((-num2 + (-301615314 ^ (274783399 ^ -845010158))) * -1335353107 * 358828587)) % 18U)
										{
										case 0U:
											num = (int)((AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200B\u200E\u206E\u206B\u200C\u202B\u200F\u206C\u200B\u206A\u206F\u206E\u206C\u206C\u206E\u206F\u206B\u202D\u206E\u200F\u200C\u200D\u200C\u202D\u200B\u202E\u206A\u206C\u200F\u200C\u200E\u202B\u202C\u202C\u200F\u200C\u206F\u206E\u202E\u200F\u202E(statusEffect) ? 592017091U : 4021526833U) ^ (num3 * 1316926959U));
											continue;
										case 1U:
											num = ((!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206F\u200D\u206E\u202A\u206E\u200F\u200C\u206D\u200D\u206B\u202B\u200F\u202A\u202B\u202A\u206C\u200C\u200E\u200B\u206F\u202B\u200E\u200E\u202A\u202C\u202C\u206B\u206E\u202B\u202A\u206A\u200E\u200C\u206C\u200D\u202C\u206A\u200D\u206C\u206A\u202E(statusEffect)) ? (-1174816646) : (-313269771));
											continue;
										case 2U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u206F\u202B\u206C\u200F\u200F\u206B\u202D\u206B\u206E\u206C\u206C\u206A\u202D\u200E\u206D\u206D\u202E\u206E\u206A\u206E\u206E\u200E\u206B\u200D\u206C\u202A\u206B\u206A\u200E\u202E\u200D\u202E\u200B\u200D\u200D\u206F\u206C\u206D\u206A\u202E(statusEffect, num4);
											num = (int)((num3 * 2542631275U) ^ 1745515588U);
											continue;
										case 3U:
										{
											int num5 = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200E\u202B\u206B\u206A\u202E\u202A\u200C\u206D\u202B\u206A\u200C\u200E\u202A\u206D\u206E\u206E\u202E\u202E\u202E\u200C\u202C\u206D\u206A\u206C\u202D\u200D\u200C\u202C\u206A\u206A\u202C\u202D\u200F\u202D\u202D\u200D\u202E\u206F\u206C\u202C\u202E(statusEffect);
											num = (int)((num3 * 1224727786U) ^ 543529631U);
											continue;
										}
										case 4U:
											num = 1566190617;
											continue;
										case 5U:
											num6 = 0;
											goto IL_01E5;
										case 6U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206B\u202D\u206C\u206D\u202A\u202A\u200B\u206E\u200B\u200B\u202D\u206D\u206F\u206E\u202E\u200C\u202C\u200C\u202D\u202D\u202B\u206F\u202E\u206E\u200C\u202E\u200E\u206D\u206B\u202E\u202A\u200D\u202E\u206C\u202B\u200E\u206A\u202C\u200E\u206A\u202E(statusEffect, num7);
											num = (int)((num3 * 3433768811U) ^ 2097016377U);
											continue;
										case 7U:
											goto IL_0120;
										case 9U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u206F\u206F\u206F\u202A\u202C\u200F\u206D\u202E\u202B\u206D\u202B\u200F\u202E\u206F\u206B\u200F\u202D\u206F\u206B\u206B\u200B\u202E\u206C\u200E\u200E\u200C\u200D\u206B\u206D\u206A\u202E\u202B\u206F\u202C\u200B\u202A\u206C\u202D\u206E\u202E(statusEffect, num8);
											num = (int)((num3 * 21908709U) ^ 2779303947U);
											continue;
										case 10U:
											statusEffect = enumerator2.Current;
											num = 762489018;
											continue;
										case 11U:
											if (!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200B\u200E\u206E\u206B\u200C\u202B\u200F\u206C\u200B\u206A\u206F\u206E\u206C\u206C\u206E\u206F\u206B\u202D\u206E\u200F\u200C\u200D\u200C\u202D\u200B\u202E\u206A\u206C\u200F\u200C\u200E\u202B\u202C\u202C\u200F\u200C\u206F\u206E\u202E\u200F\u202E(statusEffect))
											{
												num = (int)((num3 * 1791040375U) ^ 1701191601U);
												continue;
											}
											num6 = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u202C\u206C\u200D\u202E\u200F\u206C\u200D\u206C\u206B\u200E\u206E\u206B\u202B\u202B\u202C\u206C\u202C\u206C\u206F\u202C\u206C\u202A\u206C\u206F\u200C\u200D\u200C\u206F\u202D\u202A\u200D\u200E\u200D\u206F\u206C\u202E\u200F\u202A\u202A\u202E(statusEffect);
											goto IL_01E5;
										case 12U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200D\u206F\u200D\u202B\u202E\u202E\u206D\u200C\u200F\u206C\u206D\u206F\u200C\u200C\u200F\u202D\u202A\u206E\u200E\u202D\u206F\u202A\u206A\u200C\u206A\u206F\u206E\u202E\u206E\u200B\u202A\u206E\u206B\u206C\u200E\u206B\u206F\u202B\u206A\u200F\u202E(statusEffect, AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200F\u202E\u200F\u200D\u202A\u202E\u202A\u200B\u202D\u202D\u202E\u206C\u200B\u206C\u206D\u206F\u206B\u200B\u200E\u202B\u200F\u202D\u200D\u200D\u206E\u200B\u202A\u202A\u202E\u206C\u206C\u202A\u206D\u206C\u202B\u200B\u202A\u206F\u202D\u206B\u202E(statusEffect));
											num = (int)((num3 * 2589318155U) ^ 1435861671U);
											continue;
										case 13U:
										{
											int num5;
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200E\u202C\u200F\u202D\u206F\u206B\u202A\u202B\u202B\u206F\u206E\u202B\u206B\u202E\u202E\u202C\u200B\u200F\u206A\u206F\u200C\u206C\u206D\u202D\u202E\u202B\u200E\u206A\u202B\u202A\u202A\u206E\u206B\u202B\u206C\u206A\u200D\u200D\u202D\u202E\u202E(statusEffect, num5);
											num = ((!(statusEffect is LimitedDamage)) ? 612509176 : (-766440714));
											continue;
										}
										case 14U:
											num = ((!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202C\u202D\u206B\u200D\u200B\u202B\u206F\u200B\u202A\u202A\u202A\u206C\u200B\u200F\u200B\u200C\u206E\u200B\u200E\u202C\u206D\u202C\u200F\u206A\u202B\u202C\u206B\u200D\u202D\u202D\u202A\u200C\u202B\u206D\u206C\u206D\u206F\u200E\u202D\u200E\u202E(statusEffect)) ? (-706546270) : 1013458720);
											continue;
										case 15U:
											num9 = 0;
											goto IL_0271;
										case 16U:
											num10 = 0;
											goto IL_0156;
										case 17U:
											AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202D\u206F\u206F\u206F\u202A\u202C\u200F\u206D\u202E\u202B\u206D\u202B\u200F\u202E\u206F\u206B\u200F\u202D\u206F\u206B\u206B\u200B\u202E\u206C\u200E\u200E\u200C\u200D\u206B\u206D\u206A\u202E\u202B\u206F\u202C\u200B\u202A\u206C\u202D\u206E\u202E(statusEffect, 300);
											num = (int)((num3 * 764755515U) ^ 1662665809U);
											continue;
										}
										goto Block_8;
										IL_0156:
										num4 = num10;
										num = -339797762;
										continue;
										IL_0271:
										num8 = num9;
										if (!AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206F\u200D\u206E\u202A\u206E\u200F\u200C\u206D\u200D\u206B\u202B\u200F\u202A\u202B\u202A\u206C\u200C\u200E\u200B\u206F\u202B\u200E\u200E\u202A\u202C\u202C\u206B\u206E\u202B\u202A\u206A\u200E\u200C\u206C\u200D\u202C\u206A\u200D\u206C\u206A\u202E(statusEffect))
										{
											num = 1803300439;
											continue;
										}
										num10 = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202E\u206E\u202A\u200B\u202D\u206A\u202D\u200D\u202D\u206E\u200B\u202C\u206D\u200B\u202D\u202A\u206C\u200B\u202B\u200F\u206B\u200D\u206C\u200E\u206B\u202E\u206F\u206A\u200B\u200C\u202E\u200F\u206E\u206F\u200D\u202A\u206B\u200B\u202E\u206A\u202E(statusEffect);
										goto IL_0156;
										IL_01E5:
										num7 = num6;
										if (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u202C\u202D\u206B\u200D\u200B\u202B\u206F\u200B\u202A\u202A\u202A\u206C\u200B\u200F\u200B\u200C\u206E\u200B\u200E\u202C\u206D\u202C\u200F\u206A\u202B\u202C\u206B\u200D\u202D\u202D\u202A\u200C\u202B\u206D\u206C\u206D\u206F\u200E\u202D\u200E\u202E(statusEffect))
										{
											num9 = AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u200B\u200E\u202D\u206E\u202D\u200C\u206B\u200B\u200E\u200F\u202B\u200F\u200C\u206F\u206B\u206B\u200E\u206D\u202C\u200F\u200C\u206F\u200D\u202C\u202E\u202B\u200F\u206A\u206F\u202E\u206F\u202D\u200D\u206C\u202D\u206A\u202A\u206C\u200F\u202E\u202E(statusEffect);
											goto IL_0271;
										}
										num = 1318715546;
									}
								}
								Block_8:;
							}
							finally
							{
								if (enumerator2 != null)
								{
									for (;;)
									{
										IL_02A8:
										int num11 = -1403334648;
										for (;;)
										{
											int num2 = num11;
											uint num3;
											switch ((num3 = (uint)((-num2 + (-301615314 ^ (274783399 ^ -845010158))) * -1335353107 * 358828587)) % 3U)
											{
											case 0U:
												goto IL_02A8;
											case 2U:
												AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(enumerator2);
												num11 = (int)((num3 * 4282210302U) ^ 4158910325U);
												continue;
											}
											goto Block_18;
										}
									}
									Block_18:;
								}
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0310:
								int num12 = 291879972;
								for (;;)
								{
									int num2 = num12;
									uint num3;
									switch ((num3 = (uint)((-num2 + (-301615314 ^ (274783399 ^ -845010158))) * -1335353107 * 358828587)) % 3U)
									{
									case 0U:
										goto IL_0310;
									case 1U:
										AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.\u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(enumerator);
										num12 = (int)((num3 * 1921700803U) ^ 2626535334U);
										continue;
									}
									goto Block_20;
								}
							}
							Block_20:;
						}
					}
				}
			}

			public override string UnitEffectName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1218431003);
				}
			}

			static BattleController \u202E\u202C\u206E\u200C\u206B\u200F\u202E\u206A\u200B\u202D\u200B\u206E\u200D\u202D\u206C\u202A\u202E\u206F\u206F\u200D\u206D\u202A\u202B\u206A\u202B\u202A\u202D\u200E\u202B\u206B\u200C\u206D\u200B\u206D\u206B\u206C\u206C\u206E\u202D\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u202B\u202B\u206A\u206A\u202D\u206D\u206A\u202C\u200C\u202E\u206B\u200E\u200C\u206A\u202E\u206A\u202B\u200E\u206C\u200B\u200E\u200D\u202D\u206E\u200D\u202C\u200C\u202B\u200B\u202A\u202D\u202B\u202B\u206C\u206B\u202A\u206C\u200D\u200B\u200E\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static void \u202D\u200F\u200E\u202D\u206B\u206D\u200D\u206A\u202D\u200C\u200D\u206E\u202E\u200F\u202B\u206E\u206A\u202A\u200D\u206A\u206D\u200F\u206A\u200F\u200E\u206E\u206D\u206A\u200D\u206A\u200B\u206D\u202E\u206A\u200E\u200C\u202E\u202B\u206E\u206B\u202E(GameEventHandlerHolder A_0)
			{
				A_0.ClearEventHandlers();
			}

			static bool \u206B\u206C\u206B\u200D\u202D\u200F\u206B\u200F\u200D\u202B\u200E\u200C\u206B\u202D\u206D\u202A\u206F\u202D\u206B\u200C\u206D\u200C\u206C\u206F\u206B\u206A\u200B\u200D\u206D\u202C\u206D\u200D\u200F\u206B\u206B\u202C\u200D\u206F\u202B\u202B\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u200D\u200C\u206A\u202C\u200D\u200D\u200F\u206E\u202E\u202B\u200E\u202B\u200B\u200B\u202D\u202C\u200F\u206B\u206B\u202C\u206C\u206D\u206F\u206D\u206B\u200E\u202C\u200B\u206B\u206B\u206F\u202C\u206E\u202C\u206D\u206C\u202D\u206B\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<DamageEventArgs> \u202D\u206B\u200B\u206A\u200E\u206C\u200F\u206B\u202E\u202C\u200E\u206B\u202E\u206E\u200B\u206E\u200B\u202C\u202D\u200E\u200D\u200D\u200D\u202C\u202E\u206E\u200F\u206B\u206C\u206B\u200C\u202E\u200E\u206A\u206F\u206F\u200F\u200C\u206C\u206E\u202E(Unit A_0)
			{
				return A_0.DamageReceiving;
			}

			static GameEvent<DamageEventArgs> \u200C\u200D\u200D\u206F\u206E\u202D\u202A\u202C\u200F\u206C\u206E\u206D\u202B\u202C\u202A\u206C\u202B\u202C\u206D\u206C\u206A\u206F\u200D\u202A\u206A\u202D\u206C\u202D\u206A\u202C\u200E\u206B\u206B\u206B\u200C\u206B\u200F\u202E\u200C\u200D\u202E(Unit A_0)
			{
				return A_0.DamageTaking;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u200B\u200B\u200B\u200F\u202C\u206F\u200D\u206E\u206C\u206A\u206B\u206E\u206F\u206F\u206E\u206C\u200B\u206B\u206E\u206C\u200C\u206F\u206B\u200E\u206D\u200B\u206E\u200F\u206E\u202C\u206D\u206F\u202B\u202B\u206F\u202C\u206C\u202B\u200C\u202C\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdded;
			}

			static PlayerUnit \u200F\u200C\u206E\u200E\u206A\u202A\u202D\u200F\u202A\u200C\u200B\u202B\u202B\u206E\u200C\u206F\u202C\u200C\u202D\u206F\u202A\u206A\u202E\u206D\u202C\u202D\u200C\u202C\u200C\u206C\u202E\u206B\u202A\u202A\u202A\u202B\u206C\u200D\u206E\u202C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u200D\u206B\u206B\u200E\u200C\u206C\u202E\u202B\u202C\u206E\u200D\u200B\u206F\u206C\u206E\u206E\u200C\u206F\u202E\u200C\u206C\u206A\u202C\u206A\u202A\u202C\u206C\u202B\u200F\u202D\u202B\u202E\u200D\u200B\u206D\u206B\u206F\u202C\u200D\u202E\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<UnitEventArgs> \u200C\u202A\u200B\u202A\u202A\u202B\u206E\u206B\u206E\u206C\u200C\u206A\u200D\u200F\u200F\u202A\u200E\u200B\u200B\u202C\u202B\u202E\u206F\u202B\u206D\u206B\u200E\u206C\u202C\u206F\u200D\u200B\u200C\u202A\u206A\u200C\u200E\u200E\u206F\u206A\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static DamageInfo \u206D\u206F\u206A\u206B\u200C\u200D\u202E\u202B\u206C\u202D\u202B\u200C\u202E\u200C\u200B\u202B\u206D\u202D\u206F\u200E\u202C\u202E\u202D\u202C\u206E\u200E\u200F\u202B\u202C\u202A\u200E\u202D\u202D\u202A\u200B\u206C\u206D\u202A\u206A\u206A\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u202E\u206C\u206F\u206C\u200D\u202D\u206F\u206B\u202A\u202C\u202D\u202D\u206D\u202C\u206B\u202B\u200C\u206B\u202C\u202D\u202A\u202B\u200B\u202C\u200C\u206E\u206F\u202B\u200E\u206B\u200B\u200B\u200F\u206A\u206D\u202E\u202C\u200D\u200F\u202D\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u206B\u206A\u200E\u206E\u202B\u202D\u202C\u202D\u202E\u206B\u200C\u200F\u206E\u202A\u206A\u200F\u206A\u202C\u202E\u200C\u202D\u200C\u202B\u200F\u206D\u200B\u202D\u200E\u206C\u200C\u200C\u202B\u202C\u200D\u202D\u200E\u202D\u200F\u202E\u200E\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static Unit \u200F\u202E\u202A\u200F\u200C\u202A\u200B\u206C\u202B\u202C\u202D\u202C\u200B\u206E\u206D\u206A\u206C\u200C\u200F\u206B\u206F\u202D\u206C\u206E\u200E\u200E\u202E\u206D\u200E\u200E\u200C\u206F\u206D\u206E\u200C\u200E\u206B\u200C\u202A\u200E\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			static bool \u202D\u206E\u206F\u200F\u206E\u200D\u202E\u206F\u206D\u200C\u206C\u202B\u206C\u200F\u206C\u206E\u202D\u200E\u206B\u206E\u200E\u202E\u206D\u202D\u200F\u206D\u200C\u202C\u202A\u206C\u200D\u206A\u200C\u200B\u202B\u202C\u200F\u200D\u200F\u200F\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static bool \u200B\u200E\u206E\u206B\u200C\u202B\u200F\u206C\u200B\u206A\u206F\u206E\u206C\u206C\u206E\u206F\u206B\u202D\u206E\u200F\u200C\u200D\u200C\u202D\u200B\u202E\u206A\u206C\u200F\u200C\u200E\u202B\u202C\u202C\u200F\u200C\u206F\u206E\u202E\u200F\u202E(StatusEffect A_0)
			{
				return A_0.HasLevel;
			}

			static int \u200F\u202C\u206C\u200D\u202E\u200F\u206C\u200D\u206C\u206B\u200E\u206E\u206B\u202B\u202B\u202C\u206C\u202C\u206C\u206F\u202C\u206C\u202A\u206C\u206F\u200C\u200D\u200C\u206F\u202D\u202A\u200D\u200E\u200D\u206F\u206C\u202E\u200F\u202A\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static bool \u202C\u202D\u206B\u200D\u200B\u202B\u206F\u200B\u202A\u202A\u202A\u206C\u200B\u200F\u200B\u200C\u206E\u200B\u200E\u202C\u206D\u202C\u200F\u206A\u202B\u202C\u206B\u200D\u202D\u202D\u202A\u200C\u202B\u206D\u206C\u206D\u206F\u200E\u202D\u200E\u202E(StatusEffect A_0)
			{
				return A_0.HasCount;
			}

			static int \u200B\u200E\u202D\u206E\u202D\u200C\u206B\u200B\u200E\u200F\u202B\u200F\u200C\u206F\u206B\u206B\u200E\u206D\u202C\u200F\u200C\u206F\u200D\u202C\u202E\u202B\u200F\u206A\u206F\u202E\u206F\u202D\u200D\u206C\u202D\u206A\u202A\u206C\u200F\u202E\u202E(StatusEffect A_0)
			{
				return A_0.Count;
			}

			static bool \u206F\u200D\u206E\u202A\u206E\u200F\u200C\u206D\u200D\u206B\u202B\u200F\u202A\u202B\u202A\u206C\u200C\u200E\u200B\u206F\u202B\u200E\u200E\u202A\u202C\u202C\u206B\u206E\u202B\u202A\u206A\u200E\u200C\u206C\u200D\u202C\u206A\u200D\u206C\u206A\u202E(StatusEffect A_0)
			{
				return A_0.HasDuration;
			}

			static int \u202E\u206E\u202A\u200B\u202D\u206A\u202D\u200D\u202D\u206E\u200B\u202C\u206D\u200B\u202D\u202A\u206C\u200B\u202B\u200F\u206B\u200D\u206C\u200E\u206B\u202E\u206F\u206A\u200B\u200C\u202E\u200F\u206E\u206F\u200D\u202A\u206B\u200B\u202E\u206A\u202E(StatusEffect A_0)
			{
				return A_0.Duration;
			}

			static int \u200E\u202B\u206B\u206A\u202E\u202A\u200C\u206D\u202B\u206A\u200C\u200E\u202A\u206D\u206E\u206E\u202E\u202E\u202E\u200C\u202C\u206D\u206A\u206C\u202D\u200D\u200C\u202C\u206A\u206A\u202C\u202D\u200F\u202D\u202D\u200D\u202E\u206F\u206C\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}

			static Unit \u200F\u202E\u200F\u200D\u202A\u202E\u202A\u200B\u202D\u202D\u202E\u206C\u200B\u206C\u206D\u206F\u206B\u200B\u200E\u202B\u200F\u202D\u200D\u200D\u206E\u200B\u202A\u202A\u202E\u206C\u206C\u202A\u206D\u206C\u202B\u200B\u202A\u206F\u202D\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static void \u200D\u206F\u200D\u202B\u202E\u202E\u206D\u200C\u200F\u206C\u206D\u206F\u200C\u200C\u200F\u202D\u202A\u206E\u200E\u202D\u206F\u202A\u206A\u200C\u206A\u206F\u206E\u202E\u206E\u200B\u202A\u206E\u206B\u206C\u200E\u206B\u206F\u202B\u206A\u200F\u202E(StatusEffect A_0, Unit A_1)
			{
				A_0.TriggerAdded(A_1);
			}

			static void \u206B\u202D\u206C\u206D\u202A\u202A\u200B\u206E\u200B\u200B\u202D\u206D\u206F\u206E\u202E\u200C\u202C\u200C\u202D\u202D\u202B\u206F\u202E\u206E\u200C\u202E\u200E\u206D\u206B\u202E\u202A\u200D\u202E\u206C\u202B\u200E\u206A\u202C\u200E\u206A\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Level = A_1;
			}

			static void \u202D\u206F\u206F\u206F\u202A\u202C\u200F\u206D\u202E\u202B\u206D\u202B\u200F\u202E\u206F\u206B\u200F\u202D\u206F\u206B\u206B\u200B\u202E\u206C\u200E\u200E\u200C\u200D\u206B\u206D\u206A\u202E\u202B\u206F\u202C\u200B\u202A\u206C\u202D\u206E\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Count = A_1;
			}

			static void \u206E\u206F\u202B\u206C\u200F\u200F\u206B\u202D\u206B\u206E\u206C\u206C\u206A\u202D\u200E\u206D\u206D\u202E\u206E\u206A\u206E\u206E\u200E\u206B\u200D\u206C\u202A\u206B\u206A\u200E\u202E\u200D\u202E\u200B\u200D\u200D\u206F\u206C\u206D\u206A\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Duration = A_1;
			}

			static void \u200E\u202C\u200F\u202D\u206F\u206B\u202A\u202B\u202B\u206F\u206E\u202B\u206B\u202E\u202E\u202C\u200B\u200F\u206A\u206F\u200C\u206C\u206D\u202D\u202E\u202B\u200E\u206A\u202B\u202A\u202A\u206E\u206B\u202B\u206C\u206A\u200D\u200D\u202D\u202E\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Limit = A_1;
			}

			private static List<object> list = new List<object>();

			[HarmonyPatch(typeof(BattleController), "StartBattle")]
			private class BattleController_StartBattle_Patch
			{
				private static void Postfix(BattleController __instance)
				{
					AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.list.Clear();
				}
			}

			[HarmonyPatch(typeof(PerformAction), "EffectMessage")]
			private class PerformAction_EffectMessage_Patch
			{
				private static bool Prefix(ref Unit source, ref string effectName, ref string message, ref object args)
				{
					if (AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.list.Contains(args))
					{
						for (;;)
						{
							int num = -2081521874;
							switch (~(~((num ^ (-837935488 + -(1975386813 - 1467929013))) - (698907743 ^ -1998200484 ^ (888986641 - -734578081)))) % 3)
							{
							case 0:
								continue;
							case 1:
								return false;
							}
							break;
						}
					}
					AyaHraesvelgrofTerminusSeDef.AyaHraesvelgrofTerminusSe.list.Add(args);
					return true;
				}
			}
		}
	}
}
