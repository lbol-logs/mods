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
	[EntityLogic(typeof(AyaOrbBlueDef))]
	public sealed class AyaOrbBlue : EnemyUnit
	{
		private AyaOrbBlue.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbBlue.\u206E\u200E\u200C\u206C\u200D\u206A\u206A\u206F\u200D\u202C\u206C\u202C\u206D\u206F\u206D\u206F\u206D\u206A\u202B\u202C\u206C\u206E\u206F\u200C\u202D\u206B\u200C\u200F\u202C\u206C\u200C\u200C\u202B\u202D\u202A\u206A\u206D\u200F\u200F\u206A\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbBlue.\u206C\u206C\u202A\u202D\u206B\u200B\u202D\u202B\u200B\u202C\u200B\u206C\u206B\u200B\u206D\u206F\u202A\u202B\u202C\u200F\u206B\u206C\u200F\u200B\u202D\u202E\u200D\u206D\u206D\u202A\u200C\u200E\u202D\u200E\u202C\u206B\u206D\u202E\u206E\u206D\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = -444040234;
				for (;;)
				{
					int num2 = num;
					uint num3;
					AyaOrbBlue.MoveType moveType2;
					switch ((num3 = (uint)(-(num2 ^ (((1426910893 + 954798176) ^ 546987833) - 1039634128)) ^ 277114083 ^ 1720581826)) % 28U)
					{
					case 0U:
					{
						int num4 = AyaOrbBlue.\u200D\u206E\u202A\u206C\u206C\u202A\u200E\u202E\u206F\u202A\u202C\u202A\u206E\u200F\u206B\u206F\u206C\u200C\u202D\u206F\u200F\u202E\u206A\u206A\u206F\u206A\u202D\u206D\u202A\u202C\u202B\u206B\u200D\u206A\u206F\u206E\u200C\u206D\u202E\u202A\u202E(base.EnemyMoveRng, 0, 8);
						num = -1209486028;
						continue;
					}
					case 1U:
						num = (int)((num3 * 3561561985U) ^ 1690494543U);
						continue;
					case 2U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbBlue.\u202E\u206C\u200C\u206B\u206D\u200E\u202E\u200C\u200B\u206E\u202C\u206B\u206A\u200D\u206C\u206C\u200F\u200B\u202D\u200F\u200E\u206D\u206A\u206A\u202E\u200E\u206E\u200F\u206F\u200F\u200C\u202A\u206A\u200C\u206B\u200D\u200B\u206D\u200C\u202B\u202E(this)) ? 2901251251U : 3052199189U) ^ (num3 * 3484646167U));
						continue;
					case 3U:
						num = (int)((num3 * 1309388559U) ^ 3406343471U);
						continue;
					case 4U:
						num = (int)((num3 * 3558061989U) ^ 2234672342U);
						continue;
					case 6U:
						goto IL_0150;
					case 7U:
						num = (int)(((ayaBossZUN == null) ? 2536414932U : 3369065334U) ^ (num3 * 1632743801U));
						continue;
					case 8U:
						goto IL_0180;
					case 9U:
					{
						int num4;
						switch (num4)
						{
						case 0:
							goto IL_01FB;
						case 1:
							goto IL_024C;
						case 2:
							goto IL_0150;
						case 3:
							goto IL_01C9;
						case 4:
							goto IL_0240;
						case 5:
							goto IL_02DD;
						case 6:
							goto IL_0180;
						case 7:
							goto IL_0258;
						case 8:
							goto IL_0174;
						default:
							num = (int)((num3 * 3344467859U) ^ 261870926U);
							continue;
						}
						break;
					}
					case 10U:
					{
						AyaOrbBlue.MoveType moveType = AyaOrbBlue.MoveType.DoNothing;
						num = (int)((num3 * 1087973391U) ^ 1150350085U);
						continue;
					}
					case 11U:
						num = (int)((num3 * 1986463415U) ^ 1159557551U);
						continue;
					case 12U:
						num = (int)((num3 * 356198835U) ^ 1868637981U);
						continue;
					case 13U:
						num = (int)((num3 * 549557887U) ^ 2635166741U);
						continue;
					case 14U:
						num = (int)((num3 * 3906434229U) ^ 2048034679U);
						continue;
					case 15U:
					{
						AyaOrbBlue.MoveType moveType = moveType2;
						num = -1293482231;
						continue;
					}
					case 16U:
						goto IL_003C;
					case 17U:
						goto IL_0240;
					case 18U:
						num = (int)((num3 * 3290767353U) ^ 872202644U);
						continue;
					case 19U:
						goto IL_01C9;
					case 20U:
						goto IL_02DD;
					case 21U:
						goto IL_01FB;
					case 22U:
						goto IL_00FD;
					case 23U:
						goto IL_0174;
					case 24U:
						goto IL_024C;
					case 25U:
						num = (int)((num3 * 1413200125U) ^ 3696841563U);
						continue;
					case 26U:
					{
						AyaOrbBlue.MoveType moveType;
						this.Next = moveType;
						num = -1931235408;
						continue;
					}
					case 27U:
						goto IL_0258;
					}
					goto Block_3;
					IL_0150:
					moveType2 = AyaOrbBlue.MoveType.MelancholyEruption;
					num = -2141534511;
					continue;
					IL_0174:
					moveType2 = AyaOrbBlue.MoveType.TheReclusiveSage;
					num = -179452834;
					continue;
					IL_0180:
					moveType2 = AyaOrbBlue.MoveType.MemoriesoftheDivineAge;
					num = -47491645;
					continue;
					IL_01C9:
					moveType2 = AyaOrbBlue.MoveType.RabbitLanding;
					num = -751638898;
					continue;
					IL_01FB:
					moveType2 = AyaOrbBlue.MoveType.Riptide;
					num = -1167920808;
					continue;
					IL_0240:
					moveType2 = AyaOrbBlue.MoveType.WaterBlanket;
					num = -751638898;
					continue;
					IL_024C:
					moveType2 = AyaOrbBlue.MoveType.PlaywithWater;
					num = -1054726410;
					continue;
					IL_0258:
					moveType2 = AyaOrbBlue.MoveType.Sculpture;
					num = -1917636852;
					continue;
					IL_02DD:
					moveType2 = AyaOrbBlue.MoveType.TaoFetalMovement;
					num = -244187708;
				}
			}
			Block_3:
			goto IL_02E9;
			IL_00FD:
			throw AyaOrbBlue.\u202B\u200F\u200C\u206F\u206A\u200F\u202A\u202B\u200F\u206E\u206E\u206C\u200E\u200E\u206E\u206C\u206F\u202C\u200E\u202D\u206B\u200E\u202B\u202B\u206D\u200E\u202B\u206E\u206C\u200E\u200C\u200B\u202D\u202D\u200D\u202E\u202E\u202C\u200E\u202A\u202E();
			IL_02E9:
			base.ReactBattleEvent<GameEventArgs>(AyaOrbBlue.\u202B\u202E\u202B\u206D\u206D\u206D\u206F\u202B\u200B\u206C\u206E\u202C\u206C\u206C\u202D\u206B\u206A\u200F\u202C\u200E\u206C\u202C\u206B\u200C\u206E\u206B\u202E\u202C\u200F\u206A\u206B\u200C\u206C\u200F\u202D\u206B\u200C\u206E\u202B\u202A\u202E(AyaOrbBlue.\u206E\u200E\u200C\u206C\u200D\u206A\u206A\u206F\u200D\u202C\u206C\u202C\u206D\u206F\u206D\u206F\u206D\u206A\u202B\u202C\u206C\u206E\u206F\u200C\u202D\u206B\u200C\u200F\u202C\u206C\u200C\u200C\u202B\u202D\u202A\u206A\u206D\u200F\u200F\u206A\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbBlue.<OnBattleStarted>d__7 <OnBattleStarted>d__ = new AyaOrbBlue.<OnBattleStarted>d__7(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> PlaywithWater()
		{
			AyaOrbBlue.<PlaywithWater>d__8 <PlaywithWater>d__ = new AyaOrbBlue.<PlaywithWater>d__8(-2);
			<PlaywithWater>d__.<>4__this = this;
			return <PlaywithWater>d__;
		}

		private IEnumerable<BattleAction> MelancholyEruption()
		{
			AyaOrbBlue.<MelancholyEruption>d__9 <MelancholyEruption>d__ = new AyaOrbBlue.<MelancholyEruption>d__9(-2);
			<MelancholyEruption>d__.<>4__this = this;
			return <MelancholyEruption>d__;
		}

		private IEnumerable<BattleAction> RabbitLanding()
		{
			AyaOrbBlue.<RabbitLanding>d__10 <RabbitLanding>d__ = new AyaOrbBlue.<RabbitLanding>d__10(-2);
			<RabbitLanding>d__.<>4__this = this;
			return <RabbitLanding>d__;
		}

		private IEnumerable<BattleAction> WaterBlanket()
		{
			AyaOrbBlue.<WaterBlanket>d__11 <WaterBlanket>d__ = new AyaOrbBlue.<WaterBlanket>d__11(-2);
			<WaterBlanket>d__.<>4__this = this;
			return <WaterBlanket>d__;
		}

		private IEnumerable<BattleAction> TaoFetalMovement()
		{
			AyaOrbBlue.<TaoFetalMovement>d__12 <TaoFetalMovement>d__ = new AyaOrbBlue.<TaoFetalMovement>d__12(-2);
			<TaoFetalMovement>d__.<>4__this = this;
			return <TaoFetalMovement>d__;
		}

		private IEnumerable<BattleAction> MemoriesoftheDivineAge()
		{
			AyaOrbBlue.<MemoriesoftheDivineAge>d__13 <MemoriesoftheDivineAge>d__ = new AyaOrbBlue.<MemoriesoftheDivineAge>d__13(-2);
			<MemoriesoftheDivineAge>d__.<>4__this = this;
			return <MemoriesoftheDivineAge>d__;
		}

		private IEnumerable<BattleAction> SculptureCircle()
		{
			AyaOrbBlue.<SculptureCircle>d__14 <SculptureCircle>d__ = new AyaOrbBlue.<SculptureCircle>d__14(-2);
			<SculptureCircle>d__.<>4__this = this;
			return <SculptureCircle>d__;
		}

		private IEnumerable<BattleAction> SculptureSquare()
		{
			AyaOrbBlue.<SculptureSquare>d__15 <SculptureSquare>d__ = new AyaOrbBlue.<SculptureSquare>d__15(-2);
			<SculptureSquare>d__.<>4__this = this;
			return <SculptureSquare>d__;
		}

		private IEnumerable<BattleAction> SculptureArc()
		{
			AyaOrbBlue.<SculptureArc>d__16 <SculptureArc>d__ = new AyaOrbBlue.<SculptureArc>d__16(-2);
			<SculptureArc>d__.<>4__this = this;
			return <SculptureArc>d__;
		}

		private IEnumerable<BattleAction> TheReclusiveSage()
		{
			AyaOrbBlue.<TheReclusiveSage>d__17 <TheReclusiveSage>d__ = new AyaOrbBlue.<TheReclusiveSage>d__17(-2);
			<TheReclusiveSage>d__.<>4__this = this;
			return <TheReclusiveSage>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbBlue.<DoNothingActions>d__18 <DoNothingActions>d__ = new AyaOrbBlue.<DoNothingActions>d__18(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbBlue.<GetTurnMoves>d__19 <GetTurnMoves>d__ = new AyaOrbBlue.<GetTurnMoves>d__19(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			for (;;)
			{
				IL_000E:
				int num = 1815437791;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-(num2 + (550484460 - 1688921053 - 1784353623 - 1874215941 * 932252334 * -1975871843))) + 896071790)) % 33U)
					{
					case 0U:
						this.Next = AyaOrbBlue.MoveType.MelancholyEruption;
						num = (int)((num3 * 639716493U) ^ 675313832U);
						continue;
					case 1U:
					{
						BattleController battleController = AyaOrbBlue.\u206E\u200E\u200C\u206C\u200D\u206A\u206A\u206F\u200D\u202C\u206C\u202C\u206D\u206F\u206D\u206F\u206D\u206A\u202B\u202C\u206C\u206E\u206F\u200C\u202D\u206B\u200C\u200F\u202C\u206C\u200C\u200C\u202B\u202D\u202A\u206A\u206D\u200F\u200F\u206A\u202E(this);
						object obj;
						if (battleController == null)
						{
							obj = null;
						}
						else
						{
							obj = AyaOrbBlue.\u206C\u206C\u202A\u202D\u206B\u200B\u202D\u202B\u200B\u202C\u200B\u206C\u206B\u200B\u206D\u206F\u202A\u202B\u202C\u200F\u206B\u206C\u200F\u200B\u202D\u202E\u200D\u206D\u206D\u202A\u200C\u200E\u202D\u200E\u202C\u206B\u206D\u202E\u206E\u206D\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
						}
						AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
						num = -1956879153;
						continue;
					}
					case 2U:
						goto IL_00E7;
					case 3U:
						this.Next = AyaOrbBlue.MoveType.Sculpture;
						num = (int)((num3 * 1061111986U) ^ 2833797160U);
						continue;
					case 4U:
					{
						int num4;
						switch (num4)
						{
						case 0:
							goto IL_040B;
						case 1:
							goto IL_0439;
						case 2:
							goto IL_0337;
						case 3:
							goto IL_01A2;
						case 4:
							goto IL_0185;
						case 5:
							goto IL_0205;
						case 6:
							goto IL_03A8;
						case 7:
							goto IL_038B;
						case 8:
							goto IL_036E;
						default:
							num = (int)((num3 * 3820618774U) ^ 253955758U);
							continue;
						}
						break;
					}
					case 5U:
						goto IL_03A8;
					case 6U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbBlue.\u202E\u206C\u200C\u206B\u206D\u200E\u202E\u200C\u200B\u206E\u202C\u206B\u206A\u200D\u206C\u206C\u200F\u200B\u202D\u200F\u200E\u206D\u206A\u206A\u202E\u200E\u206E\u200F\u206F\u200F\u200C\u202A\u206A\u200C\u206B\u200D\u200B\u206D\u200C\u202B\u202E(this)) ? 4250189992U : 2244711480U) ^ (num3 * 3173801788U));
						continue;
					}
					case 7U:
						goto IL_040B;
					case 8U:
						goto IL_01BF;
					case 9U:
						goto IL_0439;
					case 10U:
						this.Next = AyaOrbBlue.MoveType.DoNothing;
						num = (int)((num3 * 3121700596U) ^ 322742610U);
						continue;
					case 11U:
						goto IL_01A2;
					case 12U:
						goto IL_029B;
					case 13U:
						num = (int)((num3 * 2999472597U) ^ 982912404U);
						continue;
					case 14U:
						return;
					case 15U:
						goto IL_038B;
					case 16U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)(((ayaBossZUN != null) ? 1473880846U : 1738884679U) ^ (num3 * 1691179125U));
						continue;
					}
					case 17U:
						return;
					case 18U:
						goto IL_0205;
					case 20U:
						this.Next = AyaOrbBlue.MoveType.Riptide;
						num = (int)((num3 * 4011302532U) ^ 3234282334U);
						continue;
					case 21U:
						return;
					case 22U:
						return;
					case 23U:
						goto IL_036E;
					case 24U:
					{
						int num4 = AyaOrbBlue.\u200D\u206E\u202A\u206C\u206C\u202A\u200E\u202E\u206F\u202A\u202C\u202A\u206E\u200F\u206B\u206F\u206C\u200C\u202D\u206F\u200F\u202E\u206A\u206A\u206F\u206A\u202D\u206D\u202A\u202C\u202B\u206B\u200D\u206A\u206F\u206E\u200C\u206D\u202E\u202A\u202E(base.EnemyMoveRng, 0, 8);
						num = 1659168472;
						continue;
					}
					case 25U:
						goto IL_0337;
					case 26U:
						num = (int)(((this.SpellCooldown <= 0) ? 3961037771U : 827749403U) ^ (num3 * 1461811955U));
						continue;
					case 27U:
						goto IL_000E;
					case 28U:
						return;
					case 29U:
						goto IL_0185;
					case 30U:
						goto IL_0354;
					case 31U:
						this.Next = AyaOrbBlue.MoveType.TheReclusiveSage;
						num = (int)((num3 * 2351766161U) ^ 2378344138U);
						continue;
					case 32U:
						goto IL_03DE;
					}
					goto Block_1;
					IL_0185:
					num = ((this.Next != AyaOrbBlue.MoveType.WaterBlanket) ? 956312399 : 1126821204);
					continue;
					IL_01A2:
					num = ((this.Next == AyaOrbBlue.MoveType.RabbitLanding) ? 1126821204 : (-2046236491));
					continue;
					IL_0205:
					num = ((this.Next == AyaOrbBlue.MoveType.TaoFetalMovement) ? 1126821204 : (-1684727908));
					continue;
					IL_0337:
					num = ((this.Next != AyaOrbBlue.MoveType.MelancholyEruption) ? (-1628994271) : 1126821204);
					continue;
					IL_036E:
					num = ((this.Next == AyaOrbBlue.MoveType.TheReclusiveSage) ? 1126821204 : 899852189);
					continue;
					IL_038B:
					num = ((this.Next != AyaOrbBlue.MoveType.Sculpture) ? (-1548819316) : 1126821204);
					continue;
					IL_03A8:
					num = ((this.Next == AyaOrbBlue.MoveType.MemoriesoftheDivineAge) ? 1126821204 : 2023436360);
					continue;
					IL_040B:
					num = ((this.Next != AyaOrbBlue.MoveType.Riptide) ? 1776751844 : 1126821204);
					continue;
					IL_0439:
					num = ((this.Next != AyaOrbBlue.MoveType.PlaywithWater) ? 880449485 : 1126821204);
				}
			}
			Block_1:
			goto IL_0456;
			IL_00E7:
			this.Next = AyaOrbBlue.MoveType.PlaywithWater;
			return;
			IL_01BF:
			this.Next = AyaOrbBlue.MoveType.WaterBlanket;
			return;
			IL_029B:
			this.Next = AyaOrbBlue.MoveType.RabbitLanding;
			return;
			IL_0354:
			this.Next = AyaOrbBlue.MoveType.TaoFetalMovement;
			return;
			IL_03DE:
			this.Next = AyaOrbBlue.MoveType.MemoriesoftheDivineAge;
			return;
			IL_0456:
			throw AyaOrbBlue.\u202B\u200F\u200C\u206F\u206A\u200F\u202A\u202B\u200F\u206E\u206E\u206C\u200E\u200E\u206E\u206C\u206F\u202C\u200E\u202D\u206B\u200E\u202B\u202B\u206D\u200E\u202B\u206E\u206C\u200E\u200C\u200B\u202D\u202D\u200D\u202E\u202E\u202C\u200E\u202A\u202E();
		}

		static BattleController \u206E\u200E\u200C\u206C\u200D\u206A\u206A\u206F\u200D\u202C\u206C\u202C\u206D\u206F\u206D\u206F\u206D\u206A\u202B\u202C\u206C\u206E\u206F\u200C\u202D\u206B\u200C\u200F\u202C\u206C\u200C\u200C\u202B\u202D\u202A\u206A\u206D\u200F\u200F\u206A\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u206C\u206C\u202A\u202D\u206B\u200B\u202D\u202B\u200B\u202C\u200B\u206C\u206B\u200B\u206D\u206F\u202A\u202B\u202C\u200F\u206B\u206C\u200F\u200B\u202D\u202E\u200D\u206D\u206D\u202A\u200C\u200E\u202D\u200E\u202C\u206B\u206D\u202E\u206E\u206D\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u202E\u206C\u200C\u206B\u206D\u200E\u202E\u200C\u200B\u206E\u202C\u206B\u206A\u200D\u206C\u206C\u200F\u200B\u202D\u200F\u200E\u206D\u206A\u206A\u202E\u200E\u206E\u200F\u206F\u200F\u200C\u202A\u206A\u200C\u206B\u200D\u200B\u206D\u200C\u202B\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u200D\u206E\u202A\u206C\u206C\u202A\u200E\u202E\u206F\u202A\u202C\u202A\u206E\u200F\u206B\u206F\u206C\u200C\u202D\u206F\u200F\u202E\u206A\u206A\u206F\u206A\u202D\u206D\u202A\u202C\u202B\u206B\u200D\u206A\u206F\u206E\u200C\u206D\u202E\u202A\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u202B\u200F\u200C\u206F\u206A\u200F\u202A\u202B\u200F\u206E\u206E\u206C\u200E\u200E\u206E\u206C\u206F\u202C\u200E\u202D\u206B\u200E\u202B\u202B\u206D\u200E\u202B\u206E\u206C\u200E\u200C\u200B\u202D\u202D\u200D\u202E\u202E\u202C\u200E\u202A\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u202B\u202E\u202B\u206D\u206D\u206D\u206F\u202B\u200B\u206C\u206E\u202C\u206C\u206C\u202D\u206B\u206A\u200F\u202C\u200E\u206C\u202C\u206B\u200C\u206E\u206B\u202E\u202C\u200F\u206A\u206B\u200C\u206C\u200F\u202D\u206B\u200C\u206E\u202B\u202A\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SculptureType;

		private int SpellCooldown;

		private enum MoveType
		{
			Riptide,
			PlaywithWater,
			MelancholyEruption,
			RabbitLanding,
			WaterBlanket,
			TaoFetalMovement,
			MemoriesoftheDivineAge,
			Sculpture,
			TheReclusiveSage,
			DoNothing
		}
	}
}
