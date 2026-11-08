using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaOrbGreenDef))]
	public sealed class AyaOrbGreen : EnemyUnit
	{
		private AyaOrbGreen.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbGreen.\u206E\u202B\u202B\u200B\u202B\u200B\u202D\u200C\u202A\u202B\u200C\u202E\u200E\u200B\u200D\u200B\u202D\u206B\u202A\u202D\u200D\u206A\u202B\u202A\u206E\u206F\u202D\u206D\u202E\u200B\u200B\u206D\u200C\u206A\u202A\u206F\u200C\u202A\u206C\u200C\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbGreen.\u202D\u200E\u206C\u200D\u206A\u202A\u200C\u200E\u202C\u206B\u200E\u206E\u206D\u202A\u200F\u200B\u202A\u200B\u200B\u200D\u202A\u206A\u206E\u200C\u202B\u202E\u206F\u202D\u206B\u200B\u206B\u206E\u202B\u202E\u206E\u202B\u200F\u200B\u206D\u206A\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = 1810876847;
				for (;;)
				{
					int num2 = num;
					uint num3;
					AyaOrbGreen.MoveType moveType2;
					switch ((num3 = (uint)(-(uint)(~(uint)num2))) % 27U)
					{
					case 0U:
						goto IL_016F;
					case 1U:
						goto IL_00C3;
					case 2U:
						num = (int)((num3 * 2480691575U) ^ 3862009130U);
						continue;
					case 3U:
						goto IL_00CF;
					case 4U:
						num = (int)((num3 * 1814562242U) ^ 913098644U);
						continue;
					case 5U:
						goto IL_02C0;
					case 6U:
						goto IL_00DB;
					case 7U:
						goto IL_0163;
					case 8U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbGreen.\u200C\u202B\u206B\u206D\u202C\u200B\u200B\u202C\u206E\u206A\u200E\u200E\u202D\u206B\u200D\u206E\u206B\u206D\u202E\u202D\u206C\u206F\u202A\u206C\u206F\u206B\u202A\u200E\u202C\u206F\u200E\u202A\u202C\u202E\u200E\u206F\u206A\u206F\u206B\u206B\u202E(this)) ? 1033327944U : 1901089941U) ^ (num3 * 1505232347U));
						continue;
					case 9U:
						num = (int)((num3 * 563555211U) ^ 3764557906U);
						continue;
					case 10U:
						switch (AyaOrbGreen.\u202E\u206D\u200B\u202A\u206C\u200E\u200C\u202A\u206F\u206F\u200D\u200E\u206B\u206E\u202A\u206D\u202A\u206D\u200B\u202A\u202B\u200B\u206A\u200E\u200E\u206D\u200B\u200F\u206A\u202C\u200B\u202B\u206F\u202A\u200C\u202C\u206E\u206B\u206B\u206A\u202E(base.EnemyMoveRng, 0, 8))
						{
						case 0:
							goto IL_0112;
						case 1:
							goto IL_00E7;
						case 2:
							goto IL_0131;
						case 3:
							goto IL_02C0;
						case 4:
							goto IL_0163;
						case 5:
							goto IL_027B;
						case 6:
							goto IL_00DB;
						case 7:
							goto IL_00C3;
						case 8:
							goto IL_00CF;
						default:
							num = 852886230;
							continue;
						}
						break;
					case 11U:
						goto IL_00E7;
					case 12U:
						goto IL_0112;
					case 13U:
						goto IL_003C;
					case 14U:
						num = (int)((num3 * 3671543429U) ^ 847543791U);
						continue;
					case 15U:
					{
						AyaOrbGreen.MoveType moveType = moveType2;
						num = 1710140622;
						continue;
					}
					case 16U:
					{
						AyaOrbGreen.MoveType moveType;
						this.Next = moveType;
						base.ReactBattleEvent<GameEventArgs>(AyaOrbGreen.\u202C\u200D\u200D\u200C\u202B\u202E\u206D\u202D\u206B\u206E\u206D\u202D\u200F\u206F\u206B\u200F\u200F\u206E\u202B\u202C\u202E\u200C\u200F\u206D\u200C\u202C\u200C\u200C\u200E\u202C\u202B\u200D\u206E\u200D\u202E\u206F\u200C\u202B\u202B\u200E\u202E(AyaOrbGreen.\u206E\u202B\u202B\u200B\u202B\u200B\u202D\u200C\u202A\u202B\u200C\u202E\u200E\u200B\u200D\u200B\u202D\u206B\u202A\u202D\u200D\u206A\u202B\u202A\u206E\u206F\u202D\u206D\u202E\u200B\u200B\u206D\u200C\u206A\u202A\u206F\u200C\u202A\u206C\u200C\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = 1488864454;
						continue;
					}
					case 17U:
						num = (int)((num3 * 1627658450U) ^ 2459648658U);
						continue;
					case 18U:
						num = (int)((num3 * 4158355615U) ^ 1031053075U);
						continue;
					case 19U:
						goto IL_027B;
					case 20U:
						num = (int)((num3 * 302149403U) ^ 2598201265U);
						continue;
					case 21U:
					{
						AyaOrbGreen.MoveType moveType = AyaOrbGreen.MoveType.DoNothing;
						num = (int)((num3 * 1023841933U) ^ 2839703023U);
						continue;
					}
					case 22U:
						num = (int)((num3 * 319851928U) ^ 1816984600U);
						continue;
					case 23U:
						goto IL_0131;
					case 24U:
						num = (int)(((ayaBossZUN != null) ? 2721336721U : 3376359155U) ^ (num3 * 833575274U));
						continue;
					case 25U:
						num = (int)((num3 * 1675207339U) ^ 3889871773U);
						continue;
					}
					goto Block_3;
					IL_00C3:
					moveType2 = AyaOrbGreen.MoveType.ShapeshiftAcademy;
					num = 1450081272;
					continue;
					IL_00CF:
					moveType2 = AyaOrbGreen.MoveType.HouraisSeaofTrees;
					num = 1201423552;
					continue;
					IL_00DB:
					moveType2 = AyaOrbGreen.MoveType.ForestDepths;
					num = 1325784297;
					continue;
					IL_00E7:
					moveType2 = AyaOrbGreen.MoveType.FlashofSpring;
					num = 439381090;
					continue;
					IL_0112:
					moveType2 = AyaOrbGreen.MoveType.MidsummerFlowers;
					num = 2054176741;
					continue;
					IL_0131:
					moveType2 = AyaOrbGreen.MoveType.InstantBodhi;
					num = 740362229;
					continue;
					IL_0163:
					moveType2 = AyaOrbGreen.MoveType.RainbowDanmakuDupion;
					num = 171785408;
					continue;
					IL_027B:
					moveType2 = AyaOrbGreen.MoveType.GensokyosBlossoming;
					num = 548414540;
					continue;
					IL_02C0:
					moveType2 = AyaOrbGreen.MoveType.ButterflysWingbeats;
					num = 171785408;
				}
			}
			Block_3:
			return;
			IL_016F:
			throw AyaOrbGreen.\u202C\u202D\u206F\u200C\u200B\u200E\u202B\u206D\u206B\u202A\u200B\u206B\u206A\u202B\u202E\u206A\u200D\u206A\u202C\u200C\u206F\u206E\u206A\u206F\u206E\u202A\u202D\u200E\u206D\u202C\u200C\u202B\u200E\u202A\u200F\u206D\u202C\u200E\u206C\u200E\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbGreen.<OnBattleStarted>d__6 <OnBattleStarted>d__ = new AyaOrbGreen.<OnBattleStarted>d__6(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> MidsummerFlowers()
		{
			AyaOrbGreen.<MidsummerFlowers>d__7 <MidsummerFlowers>d__ = new AyaOrbGreen.<MidsummerFlowers>d__7(-2);
			<MidsummerFlowers>d__.<>4__this = this;
			return <MidsummerFlowers>d__;
		}

		private IEnumerable<BattleAction> InstantBodhi()
		{
			AyaOrbGreen.<InstantBodhi>d__8 <InstantBodhi>d__ = new AyaOrbGreen.<InstantBodhi>d__8(-2);
			<InstantBodhi>d__.<>4__this = this;
			return <InstantBodhi>d__;
		}

		private IEnumerable<BattleAction> RainbowDanmakuDupion()
		{
			AyaOrbGreen.<RainbowDanmakuDupion>d__9 <RainbowDanmakuDupion>d__ = new AyaOrbGreen.<RainbowDanmakuDupion>d__9(-2);
			<RainbowDanmakuDupion>d__.<>4__this = this;
			return <RainbowDanmakuDupion>d__;
		}

		private IEnumerable<BattleAction> ForestDepths()
		{
			AyaOrbGreen.<ForestDepths>d__10 <ForestDepths>d__ = new AyaOrbGreen.<ForestDepths>d__10(-2);
			<ForestDepths>d__.<>4__this = this;
			return <ForestDepths>d__;
		}

		private IEnumerable<BattleAction> ShapeshiftAcademy()
		{
			AyaOrbGreen.<ShapeshiftAcademy>d__11 <ShapeshiftAcademy>d__ = new AyaOrbGreen.<ShapeshiftAcademy>d__11(-2);
			<ShapeshiftAcademy>d__.<>4__this = this;
			return <ShapeshiftAcademy>d__;
		}

		private IEnumerable<BattleAction> HouraisSeaofTrees()
		{
			AyaOrbGreen.<HouraisSeaofTrees>d__12 <HouraisSeaofTrees>d__ = new AyaOrbGreen.<HouraisSeaofTrees>d__12(-2);
			<HouraisSeaofTrees>d__.<>4__this = this;
			return <HouraisSeaofTrees>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbGreen.<DoNothingActions>d__13 <DoNothingActions>d__ = new AyaOrbGreen.<DoNothingActions>d__13(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbGreen.<GetTurnMoves>d__14 <GetTurnMoves>d__ = new AyaOrbGreen.<GetTurnMoves>d__14(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			BattleController battleController = AyaOrbGreen.\u206E\u202B\u202B\u200B\u202B\u200B\u202D\u200C\u202A\u202B\u200C\u202E\u200E\u200B\u200D\u200B\u202D\u206B\u202A\u202D\u200D\u206A\u202B\u202A\u206E\u206F\u202D\u206D\u202E\u200B\u200B\u206D\u200C\u206A\u202A\u206F\u200C\u202A\u206C\u200C\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbGreen.\u202D\u200E\u206C\u200D\u206A\u202A\u200C\u200E\u202C\u206B\u200E\u206E\u206D\u202A\u200F\u200B\u202A\u200B\u200B\u200D\u202A\u206A\u206E\u200C\u202B\u202E\u206F\u202D\u206B\u200B\u206B\u206E\u202B\u202E\u206E\u202B\u200F\u200B\u206D\u206A\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			if (ayaBossZUN != null)
			{
				goto IL_0050;
			}
			goto IL_037D;
			int num2;
			int num4;
			for (;;)
			{
				IL_0055:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(-(uint)(~num ^ (--613199604 + ~-2013934219) ^ (-950123003 + 759699084)))) % 30U)
				{
				case 0U:
					goto IL_0050;
				case 1U:
					goto IL_0158;
				case 2U:
					goto IL_03CF;
				case 4U:
					return;
				case 5U:
					goto IL_0271;
				case 6U:
					return;
				case 7U:
					goto IL_029E;
				case 8U:
					this.Next = AyaOrbGreen.MoveType.FlashofSpring;
					num2 = (int)((num3 * 195506859U) ^ 3302019436U);
					continue;
				case 9U:
					goto IL_01BF;
				case 10U:
					goto IL_01D9;
				case 11U:
					goto IL_0395;
				case 12U:
					this.Next = AyaOrbGreen.MoveType.MidsummerFlowers;
					num2 = (int)((num3 * 2895847164U) ^ 973944304U);
					continue;
				case 13U:
					goto IL_01A4;
				case 14U:
					return;
				case 15U:
					goto IL_020F;
				case 16U:
					switch (num4)
					{
					case 0:
						goto IL_029E;
					case 1:
						goto IL_0254;
					case 2:
						goto IL_03CF;
					case 3:
						goto IL_03B2;
					case 4:
						goto IL_01D9;
					case 5:
						goto IL_02BA;
					case 6:
						goto IL_0158;
					case 7:
						goto IL_0395;
					case 8:
						goto IL_0347;
					default:
						num2 = (int)((num3 * 978496328U) ^ 861398432U);
						continue;
					}
					break;
				case 17U:
					this.Next = AyaOrbGreen.MoveType.ShapeshiftAcademy;
					num2 = (int)((num3 * 4084765825U) ^ 1453958701U);
					continue;
				case 18U:
					num2 = (int)((num3 * 2859985488U) ^ 2640189661U);
					continue;
				case 19U:
					goto IL_02BA;
				case 20U:
					goto IL_0347;
				case 21U:
					this.Next = AyaOrbGreen.MoveType.InstantBodhi;
					num2 = (int)((num3 * 2993291835U) ^ 4076701547U);
					continue;
				case 22U:
					num2 = (int)(((this.SpellCooldown > 0) ? 261155848U : 2144817075U) ^ (num3 * 3849947451U));
					continue;
				case 23U:
					num2 = (int)((ayaBossZUN.restPool.Contains(AyaOrbGreen.\u200C\u202B\u206B\u206D\u202C\u200B\u200B\u202C\u206E\u206A\u200E\u200E\u202D\u206B\u200D\u206E\u206B\u206D\u202E\u202D\u206C\u206F\u202A\u206C\u206F\u206B\u202A\u200E\u202C\u206F\u200E\u202A\u202C\u202E\u200E\u206F\u206A\u206F\u206B\u206B\u202E(this)) ? 3565197586U : 4263166069U) ^ (num3 * 3567906359U));
					continue;
				case 24U:
					return;
				case 25U:
					goto IL_0313;
				case 26U:
					goto IL_037D;
				case 27U:
					goto IL_032D;
				case 28U:
					goto IL_0254;
				case 29U:
					goto IL_03B2;
				}
				break;
				IL_0158:
				num2 = ((this.Next != AyaOrbGreen.MoveType.ForestDepths) ? 443578463 : 333368470);
				continue;
				IL_01D9:
				num2 = ((this.Next == AyaOrbGreen.MoveType.RainbowDanmakuDupion) ? 333368470 : 194191487);
				continue;
				IL_0254:
				num2 = ((this.Next != AyaOrbGreen.MoveType.FlashofSpring) ? 21445962 : 333368470);
				continue;
				IL_029E:
				num2 = ((this.Next != AyaOrbGreen.MoveType.MidsummerFlowers) ? 191203390 : 333368470);
				continue;
				IL_02BA:
				num2 = ((this.Next == AyaOrbGreen.MoveType.GensokyosBlossoming) ? 333368470 : 846753811);
				continue;
				IL_0347:
				num2 = ((this.Next == AyaOrbGreen.MoveType.HouraisSeaofTrees) ? 333368470 : 1760573974);
				continue;
				IL_0395:
				num2 = ((this.Next == AyaOrbGreen.MoveType.ShapeshiftAcademy) ? 333368470 : 257951555);
				continue;
				IL_03B2:
				num2 = ((this.Next != AyaOrbGreen.MoveType.ButterflysWingbeats) ? 1035247087 : 333368470);
				continue;
				IL_03CF:
				num2 = ((this.Next == AyaOrbGreen.MoveType.InstantBodhi) ? 333368470 : 1185322037);
			}
			goto IL_0405;
			IL_01A4:
			this.Next = AyaOrbGreen.MoveType.DoNothing;
			return;
			IL_01BF:
			this.Next = AyaOrbGreen.MoveType.RainbowDanmakuDupion;
			return;
			IL_020F:
			this.Next = AyaOrbGreen.MoveType.HouraisSeaofTrees;
			return;
			IL_0271:
			this.Next = AyaOrbGreen.MoveType.GensokyosBlossoming;
			return;
			IL_0313:
			this.Next = AyaOrbGreen.MoveType.ButterflysWingbeats;
			return;
			IL_032D:
			this.Next = AyaOrbGreen.MoveType.ForestDepths;
			return;
			IL_0405:
			throw AyaOrbGreen.\u202C\u202D\u206F\u200C\u200B\u200E\u202B\u206D\u206B\u202A\u200B\u206B\u206A\u202B\u202E\u206A\u200D\u206A\u202C\u200C\u206F\u206E\u206A\u206F\u206E\u202A\u202D\u200E\u206D\u202C\u200C\u202B\u200E\u202A\u200F\u206D\u202C\u200E\u206C\u200E\u202E();
			IL_0050:
			num2 = 1027005787;
			goto IL_0055;
			IL_037D:
			num4 = AyaOrbGreen.\u202E\u206D\u200B\u202A\u206C\u200E\u200C\u202A\u206F\u206F\u200D\u200E\u206B\u206E\u202A\u206D\u202A\u206D\u200B\u202A\u202B\u200B\u206A\u200E\u200E\u206D\u200B\u200F\u206A\u202C\u200B\u202B\u206F\u202A\u200C\u202C\u206E\u206B\u206B\u206A\u202E(base.EnemyMoveRng, 0, 8);
			num2 = 995334364;
			goto IL_0055;
		}

		static BattleController \u206E\u202B\u202B\u200B\u202B\u200B\u202D\u200C\u202A\u202B\u200C\u202E\u200E\u200B\u200D\u200B\u202D\u206B\u202A\u202D\u200D\u206A\u202B\u202A\u206E\u206F\u202D\u206D\u202E\u200B\u200B\u206D\u200C\u206A\u202A\u206F\u200C\u202A\u206C\u200C\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u202D\u200E\u206C\u200D\u206A\u202A\u200C\u200E\u202C\u206B\u200E\u206E\u206D\u202A\u200F\u200B\u202A\u200B\u200B\u200D\u202A\u206A\u206E\u200C\u202B\u202E\u206F\u202D\u206B\u200B\u206B\u206E\u202B\u202E\u206E\u202B\u200F\u200B\u206D\u206A\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u200C\u202B\u206B\u206D\u202C\u200B\u200B\u202C\u206E\u206A\u200E\u200E\u202D\u206B\u200D\u206E\u206B\u206D\u202E\u202D\u206C\u206F\u202A\u206C\u206F\u206B\u202A\u200E\u202C\u206F\u200E\u202A\u202C\u202E\u200E\u206F\u206A\u206F\u206B\u206B\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u202E\u206D\u200B\u202A\u206C\u200E\u200C\u202A\u206F\u206F\u200D\u200E\u206B\u206E\u202A\u206D\u202A\u206D\u200B\u202A\u202B\u200B\u206A\u200E\u200E\u206D\u200B\u200F\u206A\u202C\u200B\u202B\u206F\u202A\u200C\u202C\u206E\u206B\u206B\u206A\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u202C\u202D\u206F\u200C\u200B\u200E\u202B\u206D\u206B\u202A\u200B\u206B\u206A\u202B\u202E\u206A\u200D\u206A\u202C\u200C\u206F\u206E\u206A\u206F\u206E\u202A\u202D\u200E\u206D\u202C\u200C\u202B\u200E\u202A\u200F\u206D\u202C\u200E\u206C\u200E\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u202C\u200D\u200D\u200C\u202B\u202E\u206D\u202D\u206B\u206E\u206D\u202D\u200F\u206F\u206B\u200F\u200F\u206E\u202B\u202C\u202E\u200C\u200F\u206D\u200C\u202C\u200C\u200C\u200E\u202C\u202B\u200D\u206E\u200D\u202E\u206F\u200C\u202B\u202B\u200E\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SpellCooldown;

		private enum MoveType
		{
			MidsummerFlowers,
			FlashofSpring,
			InstantBodhi,
			ButterflysWingbeats,
			RainbowDanmakuDupion,
			GensokyosBlossoming,
			ForestDepths,
			ShapeshiftAcademy,
			HouraisSeaofTrees,
			DoNothing
		}
	}
}
