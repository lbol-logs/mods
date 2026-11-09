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
	[EntityLogic(typeof(AyaOrbPhilosophyDef))]
	public sealed class AyaOrbPhilosophy : EnemyUnit
	{
		private AyaOrbPhilosophy.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbPhilosophy.\u206F\u200F\u200F\u202A\u200F\u206C\u200B\u200B\u202C\u206B\u202E\u206E\u206D\u206C\u200F\u200B\u200E\u206B\u206E\u200F\u200C\u200E\u202D\u202E\u200C\u206E\u202C\u200B\u200E\u206C\u200F\u200C\u202B\u202E\u206F\u202E\u200B\u206D\u200E\u206E\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbPhilosophy.\u206E\u202A\u206C\u202D\u206C\u200E\u200E\u200E\u206C\u202D\u202A\u206A\u206F\u200E\u202B\u200B\u202E\u200B\u200F\u202C\u206B\u200C\u202B\u202D\u202A\u200F\u206B\u200F\u200D\u202D\u200E\u206B\u206D\u206A\u206C\u206E\u206D\u206C\u202E\u206C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = -149844742;
				for (;;)
				{
					int num2 = num;
					uint num3;
					AyaOrbPhilosophy.MoveType moveType2;
					switch ((num3 = (uint)(~(uint)(~(uint)(num2 + ((1685716896 ^ -1262406465) + -1586576023 - (-861071688 + (545669511 + -921140134))) - -(2145020849 * 430520243))))) % 32U)
					{
					case 0U:
						goto IL_02A4;
					case 2U:
						switch (AyaOrbPhilosophy.\u202D\u206F\u206D\u206C\u200D\u202E\u206A\u200F\u200C\u200F\u200C\u202E\u200B\u206B\u206D\u206C\u202A\u200C\u202B\u206C\u206B\u206D\u206E\u206A\u202D\u206B\u206C\u200E\u202C\u200F\u206F\u206A\u200B\u206F\u202A\u202A\u206F\u200F\u206B\u200E\u202E(base.EnemyMoveRng, 0, 12))
						{
						case 0:
							goto IL_01BD;
						case 1:
							goto IL_01A5;
						case 2:
							goto IL_0203;
						case 3:
							goto IL_0199;
						case 4:
							goto IL_010A;
						case 5:
							goto IL_01B1;
						case 6:
							goto IL_0252;
						case 7:
							goto IL_0303;
						case 8:
							goto IL_01F7;
						case 9:
							goto IL_02A4;
						case 10:
							goto IL_01DA;
						case 11:
							goto IL_02F6;
						case 12:
							goto IL_0297;
						default:
							num = -1088202659;
							continue;
						}
						break;
					case 3U:
						goto IL_0303;
					case 4U:
						num = (int)((num3 * 1663690128U) ^ 1508239779U);
						continue;
					case 5U:
						num = (int)((num3 * 4018383726U) ^ 2617384517U);
						continue;
					case 6U:
						num = (int)((num3 * 283842171U) ^ 1985864801U);
						continue;
					case 7U:
						num = (int)((num3 * 3602981872U) ^ 1811831923U);
						continue;
					case 8U:
						num = (int)((num3 * 3421754447U) ^ 2375143867U);
						continue;
					case 9U:
						goto IL_01E7;
					case 10U:
						goto IL_010A;
					case 11U:
						goto IL_01BD;
					case 12U:
						num = (int)(((ayaBossZUN != null) ? 3926779868U : 2971543488U) ^ (num3 * 1661547484U));
						continue;
					case 13U:
					{
						AyaOrbPhilosophy.MoveType moveType = AyaOrbPhilosophy.MoveType.DoNothing;
						num = (int)((num3 * 554752235U) ^ 1962914413U);
						continue;
					}
					case 14U:
						goto IL_0252;
					case 15U:
						num = (int)((num3 * 2975570965U) ^ 2640402700U);
						continue;
					case 16U:
						goto IL_0203;
					case 17U:
						num = (int)((num3 * 1074168794U) ^ 3342318297U);
						continue;
					case 18U:
						goto IL_01F7;
					case 19U:
						goto IL_01DA;
					case 20U:
						num = (int)((num3 * 716874647U) ^ 2617128779U);
						continue;
					case 21U:
					{
						AyaOrbPhilosophy.MoveType moveType = moveType2;
						num = -1409280697;
						continue;
					}
					case 22U:
						goto IL_02F6;
					case 23U:
						goto IL_01A5;
					case 24U:
						num = (int)((num3 * 4216740012U) ^ 1552616643U);
						continue;
					case 25U:
					{
						AyaOrbPhilosophy.MoveType moveType;
						this.Next = moveType;
						num = -1364857909;
						continue;
					}
					case 26U:
						goto IL_0199;
					case 27U:
						goto IL_003C;
					case 28U:
						goto IL_0297;
					case 29U:
						base.ReactBattleEvent<GameEventArgs>(AyaOrbPhilosophy.\u200B\u200B\u206E\u206B\u206D\u202C\u206F\u206C\u202B\u200F\u206F\u200F\u202D\u200F\u206F\u206B\u202C\u206E\u206F\u200F\u202A\u206D\u202B\u202A\u206F\u202E\u206A\u206F\u206A\u206B\u202C\u200C\u200B\u200D\u200D\u200D\u200F\u200D\u202B\u206A\u202E(AyaOrbPhilosophy.\u206F\u200F\u200F\u202A\u200F\u206C\u200B\u200B\u202C\u206B\u202E\u206E\u206D\u206C\u200F\u200B\u200E\u206B\u206E\u200F\u200C\u200E\u202D\u202E\u200C\u206E\u202C\u200B\u200E\u206C\u200F\u200C\u202B\u202E\u206F\u202E\u200B\u206D\u200E\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = (int)((num3 * 3270874831U) ^ 3338828252U);
						continue;
					case 30U:
						num = (int)(((!ayaBossZUN.restPool.Contains(AyaOrbPhilosophy.\u200E\u200F\u202D\u206A\u202E\u206B\u202E\u200E\u202E\u200F\u200D\u206B\u202A\u200F\u202B\u202E\u200D\u202C\u202E\u206F\u200C\u206B\u206C\u202B\u200D\u206E\u206F\u206B\u206A\u202D\u206A\u202B\u206D\u202E\u200D\u200E\u206B\u206A\u200B\u200F\u202E(this))) ? 2506824172U : 2695514759U) ^ (num3 * 1370878658U));
						continue;
					case 31U:
						goto IL_01B1;
					}
					goto Block_3;
					IL_010A:
					moveType2 = AyaOrbPhilosophy.MoveType.FourofaKind;
					num = -445039627;
					continue;
					IL_0199:
					moveType2 = AyaOrbPhilosophy.MoveType.CounterDanmaku;
					num = -801628701;
					continue;
					IL_01A5:
					moveType2 = AyaOrbPhilosophy.MoveType.RitualofExorcism;
					num = -801628701;
					continue;
					IL_01B1:
					moveType2 = AyaOrbPhilosophy.MoveType.DevourDesires;
					num = -801628701;
					continue;
					IL_01BD:
					moveType2 = AyaOrbPhilosophy.MoveType.BabyoftheStone;
					num = -1219077441;
					continue;
					IL_01DA:
					moveType2 = AyaOrbPhilosophy.MoveType.GrudgeReturning;
					num = -1651746698;
					continue;
					IL_01F7:
					moveType2 = AyaOrbPhilosophy.MoveType.SuwaClearWater;
					num = -1606476236;
					continue;
					IL_0203:
					moveType2 = AyaOrbPhilosophy.MoveType.TianxiansRumbling;
					num = -801628701;
					continue;
					IL_0252:
					moveType2 = AyaOrbPhilosophy.MoveType.CloseEyeShot;
					num = -1076287194;
					continue;
					IL_0297:
					moveType2 = AyaOrbPhilosophy.MoveType.PoisonRaze;
					num = -1623732973;
					continue;
					IL_02A4:
					moveType2 = AyaOrbPhilosophy.MoveType.WavesofReversedScale;
					num = -1449946830;
					continue;
					IL_02F6:
					moveType2 = AyaOrbPhilosophy.MoveType.FranticFallingLeaves;
					num = -801628701;
					continue;
					IL_0303:
					moveType2 = AyaOrbPhilosophy.MoveType.PanoramicShot;
					num = -801628701;
				}
			}
			Block_3:
			return;
			IL_01E7:
			throw AyaOrbPhilosophy.\u202C\u206D\u202E\u202C\u206D\u200F\u206E\u202E\u206D\u202A\u202B\u206B\u206A\u202B\u206E\u202B\u206E\u202C\u206F\u206D\u202C\u202A\u202E\u206D\u200D\u200B\u206D\u206D\u200F\u206F\u206D\u200E\u206F\u200B\u200F\u200D\u202D\u202C\u200C\u200C\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbPhilosophy.<OnBattleStarted>d__5 <OnBattleStarted>d__ = new AyaOrbPhilosophy.<OnBattleStarted>d__5(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> BabyoftheStone()
		{
			AyaOrbPhilosophy.<BabyoftheStone>d__6 <BabyoftheStone>d__ = new AyaOrbPhilosophy.<BabyoftheStone>d__6(-2);
			<BabyoftheStone>d__.<>4__this = this;
			return <BabyoftheStone>d__;
		}

		private IEnumerable<BattleAction> RitualofExorcism()
		{
			AyaOrbPhilosophy.<RitualofExorcism>d__7 <RitualofExorcism>d__ = new AyaOrbPhilosophy.<RitualofExorcism>d__7(-2);
			<RitualofExorcism>d__.<>4__this = this;
			return <RitualofExorcism>d__;
		}

		private IEnumerable<BattleAction> TianxiansRumbling()
		{
			AyaOrbPhilosophy.<TianxiansRumbling>d__8 <TianxiansRumbling>d__ = new AyaOrbPhilosophy.<TianxiansRumbling>d__8(-2);
			<TianxiansRumbling>d__.<>4__this = this;
			return <TianxiansRumbling>d__;
		}

		private IEnumerable<BattleAction> CounterDanmaku()
		{
			AyaOrbPhilosophy.<CounterDanmaku>d__9 <CounterDanmaku>d__ = new AyaOrbPhilosophy.<CounterDanmaku>d__9(-2);
			<CounterDanmaku>d__.<>4__this = this;
			return <CounterDanmaku>d__;
		}

		private IEnumerable<BattleAction> FourofaKind()
		{
			AyaOrbPhilosophy.<FourofaKind>d__10 <FourofaKind>d__ = new AyaOrbPhilosophy.<FourofaKind>d__10(-2);
			<FourofaKind>d__.<>4__this = this;
			return <FourofaKind>d__;
		}

		private IEnumerable<BattleAction> DevourDesires()
		{
			AyaOrbPhilosophy.<DevourDesires>d__11 <DevourDesires>d__ = new AyaOrbPhilosophy.<DevourDesires>d__11(-2);
			<DevourDesires>d__.<>4__this = this;
			return <DevourDesires>d__;
		}

		private IEnumerable<BattleAction> PanoramicShot()
		{
			AyaOrbPhilosophy.<PanoramicShot>d__12 <PanoramicShot>d__ = new AyaOrbPhilosophy.<PanoramicShot>d__12(-2);
			<PanoramicShot>d__.<>4__this = this;
			return <PanoramicShot>d__;
		}

		private IEnumerable<BattleAction> GrudgeReturning()
		{
			AyaOrbPhilosophy.<GrudgeReturning>d__13 <GrudgeReturning>d__ = new AyaOrbPhilosophy.<GrudgeReturning>d__13(-2);
			<GrudgeReturning>d__.<>4__this = this;
			return <GrudgeReturning>d__;
		}

		private IEnumerable<BattleAction> FranticFallingLeaves()
		{
			AyaOrbPhilosophy.<FranticFallingLeaves>d__14 <FranticFallingLeaves>d__ = new AyaOrbPhilosophy.<FranticFallingLeaves>d__14(-2);
			<FranticFallingLeaves>d__.<>4__this = this;
			return <FranticFallingLeaves>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbPhilosophy.<DoNothingActions>d__15 <DoNothingActions>d__ = new AyaOrbPhilosophy.<DoNothingActions>d__15(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbPhilosophy.<GetTurnMoves>d__16 <GetTurnMoves>d__ = new AyaOrbPhilosophy.<GetTurnMoves>d__16(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			BattleController battleController = AyaOrbPhilosophy.\u206F\u200F\u200F\u202A\u200F\u206C\u200B\u200B\u202C\u206B\u202E\u206E\u206D\u206C\u200F\u200B\u200E\u206B\u206E\u200F\u200C\u200E\u202D\u202E\u200C\u206E\u202C\u200B\u200E\u206C\u200F\u200C\u202B\u202E\u206F\u202E\u200B\u206D\u200E\u206E\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbPhilosophy.\u206E\u202A\u206C\u202D\u206C\u200E\u200E\u200E\u206C\u202D\u202A\u206A\u206F\u200E\u202B\u200B\u202E\u200B\u200F\u202C\u206B\u200C\u202B\u202D\u202A\u200F\u206B\u200F\u200D\u202D\u200E\u206B\u206D\u206A\u206C\u206E\u206D\u206C\u202E\u206C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = 597314653;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((~(160301813 * 1690781289 - num2) - --1735276793) ^ -386537369)) % 43U)
					{
					case 0U:
						return;
					case 1U:
						goto IL_020C;
					case 2U:
						goto IL_04BF;
					case 3U:
						num = (int)((num3 * 1281765382U) ^ 3230323722U);
						continue;
					case 4U:
						goto IL_0380;
					case 5U:
						goto IL_04DD;
					case 6U:
						switch (AyaOrbPhilosophy.\u202D\u206F\u206D\u206C\u200D\u202E\u206A\u200F\u200C\u200F\u200C\u202E\u200B\u206B\u206D\u206C\u202A\u200C\u202B\u206C\u206B\u206D\u206E\u206A\u202D\u206B\u206C\u200E\u202C\u200F\u206F\u206A\u200B\u206F\u202A\u202A\u206F\u200F\u206B\u200E\u202E(base.EnemyMoveRng, 0, 12))
						{
						case 0:
							goto IL_0380;
						case 1:
							goto IL_054F;
						case 2:
							goto IL_04DD;
						case 3:
							goto IL_03E1;
						case 4:
							goto IL_032A;
						case 5:
							goto IL_0532;
						case 6:
							goto IL_044F;
						case 7:
							goto IL_020C;
						case 8:
							goto IL_0418;
						case 9:
							goto IL_0487;
						case 10:
							goto IL_02D5;
						case 11:
							goto IL_04BF;
						case 12:
							goto IL_02F3;
						default:
							num = -1118329481;
							continue;
						}
						break;
					case 7U:
						return;
					case 8U:
						goto IL_019F;
					case 9U:
						goto IL_03FE;
					case 10U:
						this.Next = AyaOrbPhilosophy.MoveType.PanoramicShot;
						num = (int)((num3 * 1397790078U) ^ 1989299455U);
						continue;
					case 11U:
						goto IL_032A;
					case 12U:
						goto IL_0418;
					case 13U:
						return;
					case 14U:
						goto IL_0532;
					case 15U:
						this.Next = AyaOrbPhilosophy.MoveType.CounterDanmaku;
						num = (int)((num3 * 2468543474U) ^ 4216480595U);
						continue;
					case 16U:
						return;
					case 17U:
						goto IL_02D5;
					case 18U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbPhilosophy.\u200E\u200F\u202D\u206A\u202E\u206B\u202E\u200E\u202E\u200F\u200D\u206B\u202A\u200F\u202B\u202E\u200D\u202C\u202E\u206F\u200C\u206B\u206C\u202B\u200D\u206E\u206F\u206B\u206A\u202D\u206A\u202B\u206D\u202E\u200D\u200E\u206B\u206A\u200B\u200F\u202E(this)) ? 976073359U : 1067677304U) ^ (num3 * 1876332473U));
						continue;
					case 19U:
						this.Next = AyaOrbPhilosophy.MoveType.BabyoftheStone;
						num = (int)((num3 * 4203282225U) ^ 275324851U);
						continue;
					case 20U:
						goto IL_02F3;
					case 22U:
						this.Next = AyaOrbPhilosophy.MoveType.RitualofExorcism;
						num = (int)((num3 * 2095403283U) ^ 961286547U);
						continue;
					case 23U:
						return;
					case 24U:
						return;
					case 25U:
						goto IL_054F;
					case 26U:
						goto IL_046C;
					case 27U:
						this.Next = AyaOrbPhilosophy.MoveType.SuwaClearWater;
						num = (int)((num3 * 2528002897U) ^ 3650231963U);
						continue;
					case 28U:
						goto IL_0289;
					case 29U:
						return;
					case 30U:
						return;
					case 31U:
						goto IL_044F;
					case 32U:
						return;
					case 33U:
						this.Next = AyaOrbPhilosophy.MoveType.GrudgeReturning;
						num = (int)((num3 * 2706321618U) ^ 2539793787U);
						continue;
					case 34U:
						num = (int)(((ayaBossZUN != null) ? 2209988853U : 1747962821U) ^ (num3 * 3229960954U));
						continue;
					case 35U:
						goto IL_0487;
					case 36U:
						goto IL_003C;
					case 37U:
						this.Next = AyaOrbPhilosophy.MoveType.DoNothing;
						num = (int)((num3 * 1911919792U) ^ 213203804U);
						continue;
					case 38U:
						this.Next = AyaOrbPhilosophy.MoveType.TianxiansRumbling;
						num = (int)((num3 * 3971183658U) ^ 1486330405U);
						continue;
					case 39U:
						return;
					case 40U:
						this.Next = AyaOrbPhilosophy.MoveType.WavesofReversedScale;
						num = (int)((num3 * 3002420511U) ^ 668709270U);
						continue;
					case 41U:
						this.Next = AyaOrbPhilosophy.MoveType.PoisonRaze;
						num = (int)((num3 * 94869951U) ^ 660809369U);
						continue;
					case 42U:
						goto IL_03E1;
					}
					goto Block_3;
					IL_020C:
					num = ((this.Next == AyaOrbPhilosophy.MoveType.PanoramicShot) ? (-370259905) : (-453494695));
					continue;
					IL_02D5:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.GrudgeReturning) ? (-14945021) : (-370259905));
					continue;
					IL_02F3:
					num = ((this.Next == AyaOrbPhilosophy.MoveType.PoisonRaze) ? (-370259905) : (-289787764));
					continue;
					IL_032A:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.FourofaKind) ? (-470149454) : (-370259905));
					continue;
					IL_0380:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.BabyoftheStone) ? 215900115 : (-370259905));
					continue;
					IL_03E1:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.CounterDanmaku) ? (-238983911) : (-370259905));
					continue;
					IL_0418:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.SuwaClearWater) ? (-878529985) : (-370259905));
					continue;
					IL_044F:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.CloseEyeShot) ? (-547802733) : (-370259905));
					continue;
					IL_0487:
					num = ((this.Next == AyaOrbPhilosophy.MoveType.WavesofReversedScale) ? (-370259905) : (-886255607));
					continue;
					IL_04BF:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.FranticFallingLeaves) ? (-924368360) : (-370259905));
					continue;
					IL_04DD:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.TianxiansRumbling) ? (-1271299326) : (-370259905));
					continue;
					IL_0532:
					num = ((this.Next == AyaOrbPhilosophy.MoveType.DevourDesires) ? (-370259905) : 461163896);
					continue;
					IL_054F:
					num = ((this.Next != AyaOrbPhilosophy.MoveType.RitualofExorcism) ? 368976628 : (-370259905));
				}
			}
			Block_3:
			goto IL_056C;
			IL_019F:
			this.Next = AyaOrbPhilosophy.MoveType.DevourDesires;
			return;
			IL_0289:
			this.Next = AyaOrbPhilosophy.MoveType.CloseEyeShot;
			return;
			IL_03FE:
			this.Next = AyaOrbPhilosophy.MoveType.FourofaKind;
			return;
			IL_046C:
			this.Next = AyaOrbPhilosophy.MoveType.FranticFallingLeaves;
			return;
			IL_056C:
			throw AyaOrbPhilosophy.\u202C\u206D\u202E\u202C\u206D\u200F\u206E\u202E\u206D\u202A\u202B\u206B\u206A\u202B\u206E\u202B\u206E\u202C\u206F\u206D\u202C\u202A\u202E\u206D\u200D\u200B\u206D\u206D\u200F\u206F\u206D\u200E\u206F\u200B\u200F\u200D\u202D\u202C\u200C\u200C\u202E();
		}

		static BattleController \u206F\u200F\u200F\u202A\u200F\u206C\u200B\u200B\u202C\u206B\u202E\u206E\u206D\u206C\u200F\u200B\u200E\u206B\u206E\u200F\u200C\u200E\u202D\u202E\u200C\u206E\u202C\u200B\u200E\u206C\u200F\u200C\u202B\u202E\u206F\u202E\u200B\u206D\u200E\u206E\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u206E\u202A\u206C\u202D\u206C\u200E\u200E\u200E\u206C\u202D\u202A\u206A\u206F\u200E\u202B\u200B\u202E\u200B\u200F\u202C\u206B\u200C\u202B\u202D\u202A\u200F\u206B\u200F\u200D\u202D\u200E\u206B\u206D\u206A\u206C\u206E\u206D\u206C\u202E\u206C\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u200E\u200F\u202D\u206A\u202E\u206B\u202E\u200E\u202E\u200F\u200D\u206B\u202A\u200F\u202B\u202E\u200D\u202C\u202E\u206F\u200C\u206B\u206C\u202B\u200D\u206E\u206F\u206B\u206A\u202D\u206A\u202B\u206D\u202E\u200D\u200E\u206B\u206A\u200B\u200F\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u202D\u206F\u206D\u206C\u200D\u202E\u206A\u200F\u200C\u200F\u200C\u202E\u200B\u206B\u206D\u206C\u202A\u200C\u202B\u206C\u206B\u206D\u206E\u206A\u202D\u206B\u206C\u200E\u202C\u200F\u206F\u206A\u200B\u206F\u202A\u202A\u206F\u200F\u206B\u200E\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u202C\u206D\u202E\u202C\u206D\u200F\u206E\u202E\u206D\u202A\u202B\u206B\u206A\u202B\u206E\u202B\u206E\u202C\u206F\u206D\u202C\u202A\u202E\u206D\u200D\u200B\u206D\u206D\u200F\u206F\u206D\u200E\u206F\u200B\u200F\u200D\u202D\u202C\u200C\u200C\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u200B\u200B\u206E\u206B\u206D\u202C\u206F\u206C\u202B\u200F\u206F\u200F\u202D\u200F\u206F\u206B\u202C\u206E\u206F\u200F\u202A\u206D\u202B\u202A\u206F\u202E\u206A\u206F\u206A\u206B\u202C\u200C\u200B\u200D\u200D\u200D\u200F\u200D\u202B\u206A\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private enum MoveType
		{
			BabyoftheStone,
			RitualofExorcism,
			TianxiansRumbling,
			CounterDanmaku,
			FourofaKind,
			DevourDesires,
			CloseEyeShot,
			PanoramicShot,
			SuwaClearWater,
			WavesofReversedScale,
			GrudgeReturning,
			FranticFallingLeaves,
			PoisonRaze,
			DoNothing
		}
	}
}
