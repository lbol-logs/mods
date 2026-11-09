using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation.Units;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaIllusionaryDominanceDef))]
	public sealed class AyaIllusionaryDominance : Card
	{
		public int Times
		{
			get
			{
				return AyaIllusionaryDominance.\u200E\u206B\u200E\u206C\u202C\u200F\u200D\u206B\u202B\u202D\u200B\u202E\u200C\u200D\u202E\u206D\u200F\u202D\u200B\u206E\u206D\u206B\u200B\u200B\u206F\u200E\u206B\u202D\u202B\u206E\u202D\u206C\u200C\u202D\u202E\u206B\u200F\u202D\u200E\u200F\u202E(AyaIllusionaryDominance.\u200F\u202E\u206F\u200C\u206E\u206B\u200C\u202D\u202B\u202E\u200F\u206D\u202E\u202D\u200C\u206D\u200E\u202B\u206A\u202C\u202A\u206F\u206B\u200B\u206E\u200F\u200C\u200E\u200E\u206F\u200F\u202E\u206A\u200B\u200D\u202D\u202C\u200F\u206A\u202E(this) + AyaIllusionaryDominance.\u206E\u200F\u200B\u200D\u206E\u202B\u202C\u206E\u206A\u200D\u206E\u202B\u202A\u200E\u206B\u206B\u200F\u206F\u206A\u200B\u200B\u206A\u202D\u202B\u202D\u200B\u206A\u200F\u202B\u206F\u200C\u200E\u206C\u202C\u202D\u206D\u206C\u206F\u200F\u202B\u202E((float)base.GetSeLevel<AyaAccelerationSeDef.AyaAccelerationSe>() / this.Value3), AyaIllusionaryDominance.\u206A\u202C\u206C\u202B\u202D\u206F\u202D\u202C\u202A\u200E\u200D\u206B\u200E\u200E\u200B\u206E\u200F\u206A\u200D\u206B\u202D\u200B\u206D\u206D\u202E\u202D\u202D\u202A\u202B\u206B\u206A\u206A\u206E\u206C\u200F\u202B\u206F\u202A\u206A\u202E\u202E(this));
			}
		}

		public float Value3
		{
			get
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					for (;;)
					{
						int num = 2147415221;
						switch (~(-num) % 3)
						{
						case 1:
							goto IL_002C;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0041;
					IL_002C:
					return 4f;
				}
				IL_0041:
				return 5f;
			}
		}

		public override int AdditionalDamage
		{
			get
			{
				return base.GetSeLevel<AyaAccelerationSeDef.AyaAccelerationSe>();
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			IEnumerator<EnemyUnit> enumerator = AyaIllusionaryDominance.\u202C\u200F\u206C\u200D\u200D\u200B\u200C\u206B\u206B\u202B\u206E\u202D\u206C\u206C\u206B\u200C\u202A\u206B\u200C\u206C\u202C\u206F\u200C\u202A\u202A\u200F\u206E\u202A\u200B\u200D\u200F\u206E\u206D\u202B\u206E\u206E\u206E\u206F\u202B\u202E\u202E(AyaIllusionaryDominance.\u206C\u200E\u202D\u202D\u200E\u200B\u206E\u200F\u200C\u202D\u202C\u206B\u200F\u206F\u206A\u206E\u202A\u202D\u202C\u202E\u200C\u206E\u206F\u206D\u202D\u206E\u206E\u202B\u206F\u200D\u202D\u202A\u206F\u206D\u206A\u202E\u202A\u200C\u202E\u200D\u202E(this)).GetEnumerator();
			try
			{
				for (;;)
				{
					IL_0083:
					int num = (AyaIllusionaryDominance.\u206D\u206C\u202D\u206D\u200D\u200D\u206A\u206C\u200C\u202D\u202B\u206F\u202D\u202B\u200E\u200B\u206A\u200B\u200E\u200F\u206D\u206B\u200E\u202B\u206A\u202C\u200F\u206C\u202B\u206A\u206B\u200C\u206A\u206D\u206E\u200B\u206B\u206F\u200E\u206C\u202E(enumerator) ? 461089964 : (-958630614));
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-num2 * 906899 - ~-1087267394) * -1082522979)) % 5U)
						{
						case 0U:
							num = 461089964;
							continue;
						case 1U:
						{
							EnemyUnit enemyUnit;
							base.HandleBattleEvent<DieEventArgs>(AyaIllusionaryDominance.\u200D\u206D\u202D\u200F\u202A\u202B\u200D\u206C\u206F\u202B\u202C\u206F\u200E\u206C\u206B\u200C\u200C\u202C\u200C\u202B\u200D\u200C\u202D\u206C\u202C\u200F\u206F\u202E\u200E\u206C\u202E\u206A\u206C\u200F\u206C\u200C\u200E\u202E\u200C\u200E\u202E(enemyUnit), new GameEventHandler<DieEventArgs>(this.OnEnemyDying), (GameEventPriority)0);
							num = (int)((num3 * 1212041919U) ^ 430265486U);
							continue;
						}
						case 2U:
							goto IL_0083;
						case 4U:
						{
							EnemyUnit enemyUnit = enumerator.Current;
							num = -791885084;
							continue;
						}
						}
						goto Block_3;
					}
				}
				Block_3:;
			}
			finally
			{
				if (enumerator != null)
				{
					for (;;)
					{
						IL_00A4:
						int num4 = 1797002794;
						for (;;)
						{
							int num2 = num4;
							uint num3;
							switch ((num3 = (uint)((-num2 * 906899 - ~-1087267394) * -1082522979)) % 3U)
							{
							case 0U:
								goto IL_00A4;
							case 1U:
								AyaIllusionaryDominance.\u206B\u206E\u206B\u202E\u206A\u206D\u202D\u200D\u206F\u202E\u206B\u202C\u206D\u202D\u202E\u200F\u206F\u202E\u206D\u200B\u202E\u200E\u206A\u200C\u206D\u206A\u202C\u200D\u206D\u202A\u200F\u200D\u202A\u200E\u202D\u200F\u206A\u200C\u202D\u200F\u202E(enumerator);
								num4 = (int)((num3 * 965237767U) ^ 706407077U);
								continue;
							}
							goto Block_6;
						}
					}
					Block_6:;
				}
			}
			base.HandleBattleEvent<UnitEventArgs>(AyaIllusionaryDominance.\u206E\u206E\u202B\u200B\u200C\u200D\u206E\u206A\u206A\u202E\u206C\u200B\u206B\u206D\u202E\u200D\u206F\u200E\u200F\u202E\u206A\u206F\u206A\u202B\u200F\u200F\u206B\u206D\u202B\u202E\u206B\u206D\u206C\u206F\u200E\u200B\u200D\u202D\u206D\u202D\u202E(AyaIllusionaryDominance.\u206C\u200E\u202D\u202D\u200E\u200B\u206E\u200F\u200C\u202D\u202C\u206B\u200F\u206F\u206A\u206E\u202A\u202D\u202C\u202E\u200C\u206E\u206F\u206D\u202D\u206E\u206E\u202B\u206F\u200D\u202D\u202A\u206F\u206D\u206A\u202E\u202A\u200C\u202E\u200D\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
		}

		private void OnEnemyDying(DieEventArgs args)
		{
			if (this.Attacking)
			{
				for (;;)
				{
					IL_000B:
					int num = -7149975;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((345711027 ^ -1301574430) + 316147190) - num2 - -1009353919 - 2081572583)) % 5U)
						{
						case 0U:
							goto IL_000B;
						case 1U:
							num = (int)(((AyaIllusionaryDominance.\u206F\u206A\u206B\u206B\u200C\u200B\u202B\u206C\u202D\u206E\u200C\u206D\u206D\u206B\u200D\u202B\u202B\u202A\u200F\u200B\u206E\u200F\u206D\u200D\u206B\u206D\u200D\u202E\u202E\u206C\u206E\u206E\u206F\u200C\u206F\u206F\u206D\u206E\u202A\u202E(args) != this) ? 4208183531U : 3921194938U) ^ (num3 * 1826103789U));
							continue;
						case 2U:
							AyaIllusionaryDominance.\u202C\u200E\u202B\u200F\u206B\u202E\u200C\u200B\u202C\u202B\u202E\u202A\u202E\u202C\u200D\u206C\u200B\u206F\u206D\u200B\u206F\u202C\u206E\u200F\u206F\u200C\u206B\u206F\u202E\u206B\u206D\u202C\u202D\u206E\u200C\u202A\u206B\u200C\u206B\u206B\u202E(args, true);
							AyaIllusionaryDominance.\u202B\u206B\u202A\u200D\u200D\u206E\u202B\u206B\u206A\u206E\u202A\u206A\u202E\u202B\u206B\u202A\u200E\u200B\u206B\u202D\u200F\u200D\u202B\u206A\u200D\u202A\u206F\u202B\u206E\u206E\u202B\u200D\u206C\u200C\u202D\u200C\u200D\u206B\u202A\u206C\u202E(args, this);
							num = (int)((num3 * 3099658372U) ^ 3847606198U);
							continue;
						case 4U:
							AyaIllusionaryDominance.\u206F\u206D\u202C\u202C\u202D\u206D\u202C\u202A\u206F\u206B\u202B\u200F\u202A\u200C\u206E\u202E\u200D\u202E\u206D\u200E\u202E\u206D\u200D\u202D\u206E\u200F\u202E\u202A\u202B\u206B\u200E\u202A\u206E\u206D\u206E\u200D\u206F\u206E\u202A\u206E\u202E(AyaIllusionaryDominance.\u202C\u202E\u202E\u200F\u202D\u202B\u202E\u200C\u202D\u206B\u200F\u206A\u206B\u200D\u202B\u202D\u202A\u202E\u200C\u206A\u206F\u202A\u206B\u206B\u200D\u200B\u202A\u200D\u202D\u202B\u206F\u200D\u206C\u200F\u206C\u202B\u206A\u202A\u200B\u206D\u202E(args), UnitStatus.Alive);
							num = (int)((num3 * 785984829U) ^ 311332510U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		private void OnEnemySpawned(UnitEventArgs args)
		{
			base.HandleBattleEvent<DieEventArgs>(AyaIllusionaryDominance.\u200D\u206D\u202D\u200F\u202A\u202B\u200D\u206C\u206F\u202B\u202C\u206F\u200E\u206C\u206B\u200C\u200C\u202C\u200C\u202B\u200D\u200C\u202D\u206C\u202C\u200F\u206F\u202E\u200E\u206C\u202E\u206A\u206C\u200F\u206C\u200C\u200E\u202E\u200C\u200E\u202E(AyaIllusionaryDominance.\u202D\u200C\u206D\u206E\u206C\u206E\u200E\u206C\u200E\u206B\u202E\u206D\u202D\u200B\u206F\u200E\u202E\u206B\u202C\u206B\u206C\u200D\u200E\u202A\u202B\u206E\u202A\u200D\u202C\u206A\u200B\u200E\u202A\u206B\u206B\u200B\u202B\u206D\u200D\u200F\u202E(args)), new GameEventHandler<DieEventArgs>(this.OnEnemyDying), (GameEventPriority)0);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaIllusionaryDominance.<Actions>d__12 <Actions>d__ = new AyaIllusionaryDominance.<Actions>d__12(-2);
			<Actions>d__.<>4__this = this;
			<Actions>d__.<>3__selector = selector;
			return <Actions>d__;
		}

		[CompilerGenerated]
		private IEnumerator <Actions>g__coroutine|12_4(UnitView unitView, UnitView unitView1, UnitView unitView2, UnitView unitView3, UnitView unitView4)
		{
			AyaIllusionaryDominance.<<Actions>g__coroutine|12_4>d <<Actions>g__coroutine|12_4>d = new AyaIllusionaryDominance.<<Actions>g__coroutine|12_4>d(0);
			<<Actions>g__coroutine|12_4>d.<>4__this = this;
			<<Actions>g__coroutine|12_4>d.unitView = unitView;
			<<Actions>g__coroutine|12_4>d.unitView1 = unitView1;
			<<Actions>g__coroutine|12_4>d.unitView2 = unitView2;
			<<Actions>g__coroutine|12_4>d.unitView3 = unitView3;
			<<Actions>g__coroutine|12_4>d.unitView4 = unitView4;
			return <<Actions>g__coroutine|12_4>d;
		}

		[CompilerGenerated]
		private IEnumerator <Actions>g__coroutine2|12_5(UnitView unitView)
		{
			AyaIllusionaryDominance.<<Actions>g__coroutine2|12_5>d <<Actions>g__coroutine2|12_5>d = new AyaIllusionaryDominance.<<Actions>g__coroutine2|12_5>d(0);
			<<Actions>g__coroutine2|12_5>d.<>4__this = this;
			<<Actions>g__coroutine2|12_5>d.unitView = unitView;
			return <<Actions>g__coroutine2|12_5>d;
		}

		[CompilerGenerated]
		internal static IEnumerator <Actions>g__coroutine3|12_6(UnitView unitView, UnitView unitView1, Vector3 origin)
		{
			AyaIllusionaryDominance.<<Actions>g__coroutine3|12_6>d <<Actions>g__coroutine3|12_6>d = new AyaIllusionaryDominance.<<Actions>g__coroutine3|12_6>d(0);
			<<Actions>g__coroutine3|12_6>d.unitView = unitView;
			<<Actions>g__coroutine3|12_6>d.unitView1 = unitView1;
			<<Actions>g__coroutine3|12_6>d.origin = origin;
			return <<Actions>g__coroutine3|12_6>d;
		}

		static int \u200F\u202E\u206F\u200C\u206E\u206B\u200C\u202D\u202B\u202E\u200F\u206D\u202E\u202D\u200C\u206D\u200E\u202B\u206A\u202C\u202A\u206F\u206B\u200B\u206E\u200F\u200C\u200E\u200E\u206F\u200F\u202E\u206A\u200B\u200D\u202D\u202C\u200F\u206A\u202E(Card A_0)
		{
			return A_0.Value1;
		}

		static int \u206E\u200F\u200B\u200D\u206E\u202B\u202C\u206E\u206A\u200D\u206E\u202B\u202A\u200E\u206B\u206B\u200F\u206F\u206A\u200B\u200B\u206A\u202D\u202B\u202D\u200B\u206A\u200F\u202B\u206F\u200C\u200E\u206C\u202C\u202D\u206D\u206C\u206F\u200F\u202B\u202E(float A_0)
		{
			return A_0.TruncateToInt();
		}

		static int \u206A\u202C\u206C\u202B\u202D\u206F\u202D\u202C\u202A\u200E\u200D\u206B\u200E\u200E\u200B\u206E\u200F\u206A\u200D\u206B\u202D\u200B\u206D\u206D\u202E\u202D\u202D\u202A\u202B\u206B\u206A\u206A\u206E\u206C\u200F\u202B\u206F\u202A\u206A\u202E\u202E(Card A_0)
		{
			return A_0.Value2;
		}

		static int \u200E\u206B\u200E\u206C\u202C\u200F\u200D\u206B\u202B\u202D\u200B\u202E\u200C\u200D\u202E\u206D\u200F\u202D\u200B\u206E\u206D\u206B\u200B\u200B\u206F\u200E\u206B\u202D\u202B\u206E\u202D\u206C\u200C\u202D\u202E\u206B\u200F\u202D\u200E\u200F\u202E(int A_0, int A_1)
		{
			return Math.Min(A_0, A_1);
		}

		static BattleController \u206C\u200E\u202D\u202D\u200E\u200B\u206E\u200F\u200C\u202D\u202C\u206B\u200F\u206F\u206A\u206E\u202A\u202D\u202C\u202E\u200C\u206E\u206F\u206D\u202D\u206E\u206E\u202B\u206F\u200D\u202D\u202A\u206F\u206D\u206A\u202E\u202A\u200C\u202E\u200D\u202E(Card A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u202C\u200F\u206C\u200D\u200D\u200B\u200C\u206B\u206B\u202B\u206E\u202D\u206C\u206C\u206B\u200C\u202A\u206B\u200C\u206C\u202C\u206F\u200C\u202A\u202A\u200F\u206E\u202A\u200B\u200D\u200F\u206E\u206D\u202B\u206E\u206E\u206E\u206F\u202B\u202E\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static GameEvent<DieEventArgs> \u200D\u206D\u202D\u200F\u202A\u202B\u200D\u206C\u206F\u202B\u202C\u206F\u200E\u206C\u206B\u200C\u200C\u202C\u200C\u202B\u200D\u200C\u202D\u206C\u202C\u200F\u206F\u202E\u200E\u206C\u202E\u206A\u206C\u200F\u206C\u200C\u200E\u202E\u200C\u200E\u202E(Unit A_0)
		{
			return A_0.Dying;
		}

		static bool \u206D\u206C\u202D\u206D\u200D\u200D\u206A\u206C\u200C\u202D\u202B\u206F\u202D\u202B\u200E\u200B\u206A\u200B\u200E\u200F\u206D\u206B\u200E\u202B\u206A\u202C\u200F\u206C\u202B\u206A\u206B\u200C\u206A\u206D\u206E\u200B\u206B\u206F\u200E\u206C\u202E(IEnumerator A_0)
		{
			return A_0.MoveNext();
		}

		static void \u206B\u206E\u206B\u202E\u206A\u206D\u202D\u200D\u206F\u202E\u206B\u202C\u206D\u202D\u202E\u200F\u206F\u202E\u206D\u200B\u202E\u200E\u206A\u200C\u206D\u206A\u202C\u200D\u206D\u202A\u200F\u200D\u202A\u200E\u202D\u200F\u206A\u200C\u202D\u200F\u202E(IDisposable A_0)
		{
			A_0.Dispose();
		}

		static GameEvent<UnitEventArgs> \u206E\u206E\u202B\u200B\u200C\u200D\u206E\u206A\u206A\u202E\u206C\u200B\u206B\u206D\u202E\u200D\u206F\u200E\u200F\u202E\u206A\u206F\u206A\u202B\u200F\u200F\u206B\u206D\u202B\u202E\u206B\u206D\u206C\u206F\u200E\u200B\u200D\u202D\u206D\u202D\u202E(BattleController A_0)
		{
			return A_0.EnemySpawned;
		}

		static GameEntity \u206F\u206A\u206B\u206B\u200C\u200B\u202B\u206C\u202D\u206E\u200C\u206D\u206D\u206B\u200D\u202B\u202B\u202A\u200F\u200B\u206E\u200F\u206D\u200D\u206B\u206D\u200D\u202E\u202E\u206C\u206E\u206E\u206F\u200C\u206F\u206F\u206D\u206E\u202A\u202E(GameEventArgs A_0)
		{
			return A_0.ActionSource;
		}

		static void \u202C\u200E\u202B\u200F\u206B\u202E\u200C\u200B\u202C\u202B\u202E\u202A\u202E\u202C\u200D\u206C\u200B\u206F\u206D\u200B\u206F\u202C\u206E\u200F\u206F\u200C\u206B\u206F\u202E\u206B\u206D\u202C\u202D\u206E\u200C\u202A\u206B\u200C\u206B\u206B\u202E(GameEventArgs A_0, bool A_1)
		{
			A_0.CanCancel = A_1;
		}

		static void \u202B\u206B\u202A\u200D\u200D\u206E\u202B\u206B\u206A\u206E\u202A\u206A\u202E\u202B\u206B\u202A\u200E\u200B\u206B\u202D\u200F\u200D\u202B\u206A\u200D\u202A\u206F\u202B\u206E\u206E\u202B\u200D\u206C\u200C\u202D\u200C\u200D\u206B\u202A\u206C\u202E(GameEventArgs A_0, GameEntity A_1)
		{
			A_0.CancelBy(A_1);
		}

		static Unit \u202C\u202E\u202E\u200F\u202D\u202B\u202E\u200C\u202D\u206B\u200F\u206A\u206B\u200D\u202B\u202D\u202A\u202E\u200C\u206A\u206F\u202A\u206B\u206B\u200D\u200B\u202A\u200D\u202D\u202B\u206F\u200D\u206C\u200F\u206C\u202B\u206A\u202A\u200B\u206D\u202E(DieEventArgs A_0)
		{
			return A_0.Unit;
		}

		static void \u206F\u206D\u202C\u202C\u202D\u206D\u202C\u202A\u206F\u206B\u202B\u200F\u202A\u200C\u206E\u202E\u200D\u202E\u206D\u200E\u202E\u206D\u200D\u202D\u206E\u200F\u202E\u202A\u202B\u206B\u200E\u202A\u206E\u206D\u206E\u200D\u206F\u206E\u202A\u206E\u202E(Unit A_0, UnitStatus A_1)
		{
			A_0.Status = A_1;
		}

		static Unit \u202D\u200C\u206D\u206E\u206C\u206E\u200E\u206C\u200E\u206B\u202E\u206D\u202D\u200B\u206F\u200E\u202E\u206B\u202C\u206B\u206C\u200D\u200E\u202A\u202B\u206E\u202A\u200D\u202C\u206A\u200B\u200E\u202A\u206B\u206B\u200B\u202B\u206D\u200D\u200F\u202E(UnitEventArgs A_0)
		{
			return A_0.Unit;
		}

		static GameObject \u202D\u206D\u206B\u200D\u202B\u200E\u202C\u200B\u202A\u206B\u206A\u206C\u200C\u202C\u200E\u206F\u206D\u206B\u200F\u200C\u200E\u202D\u206E\u200B\u200E\u202D\u206B\u202E\u206C\u200F\u200C\u206B\u202E\u200D\u206A\u206A\u206B\u206D\u200D\u206F\u202E(string A_0, Assembly A_1)
		{
			return StageTemplate.TryGetEnvObject(A_0, A_1);
		}

		private bool Attacking;

		private static GameObject background = AyaIllusionaryDominance.\u202D\u206D\u206B\u200D\u202B\u200E\u202C\u200B\u202A\u206B\u206A\u206C\u200C\u202C\u200E\u206F\u206D\u206B\u200F\u200C\u200E\u202D\u206E\u200B\u200E\u202D\u206B\u202E\u206C\u200F\u200C\u206B\u202E\u200D\u206A\u206A\u206B\u206D\u200D\u206F\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-207627476), null);

		private static GameObject scene = AyaIllusionaryDominance.\u202D\u206D\u206B\u200D\u202B\u200E\u202C\u200B\u202A\u206B\u206A\u206C\u200C\u202C\u200E\u206F\u206D\u206B\u200F\u200C\u200E\u202D\u206E\u200B\u200E\u202D\u206B\u202E\u206C\u200F\u200C\u206B\u202E\u200D\u206A\u206A\u206B\u206D\u200D\u206F\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1470871933), null);
	}
}
