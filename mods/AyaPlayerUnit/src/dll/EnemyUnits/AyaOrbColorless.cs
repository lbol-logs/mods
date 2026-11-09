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
	[EntityLogic(typeof(AyaOrbColorlessDef))]
	public sealed class AyaOrbColorless : EnemyUnit
	{
		private AyaOrbColorless.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbColorless.\u200D\u202C\u200C\u200C\u206D\u206F\u200B\u200B\u206E\u200C\u202E\u206A\u200F\u200D\u200D\u202B\u202C\u200C\u206F\u202C\u200F\u200C\u200C\u206A\u206B\u200D\u200D\u200F\u206B\u206E\u202C\u200C\u202B\u206A\u206D\u202D\u206A\u206A\u202D\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbColorless.\u206E\u202A\u206C\u206D\u202A\u200B\u200C\u206C\u206F\u200D\u202E\u206F\u206E\u206D\u200F\u200B\u202D\u206B\u202A\u202A\u202B\u200F\u202B\u206F\u202C\u206F\u206A\u200E\u200E\u206B\u206E\u206F\u206B\u200C\u206C\u200F\u200E\u200C\u206D\u200F\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = -1850549338;
				for (;;)
				{
					int num2 = num;
					uint num3;
					AyaOrbColorless.MoveType moveType2;
					switch ((num3 = (uint)(-(~(num2 * 451799193)) * 1914602783)) % 28U)
					{
					case 0U:
						goto IL_02C6;
					case 1U:
						goto IL_0269;
					case 2U:
					{
						AyaOrbColorless.MoveType moveType;
						this.Next = moveType;
						num = -754199968;
						continue;
					}
					case 3U:
						num = (int)((num3 * 2660952400U) ^ 3839342337U);
						continue;
					case 4U:
						goto IL_025D;
					case 5U:
						num = (int)((num3 * 679719805U) ^ 2543673786U);
						continue;
					case 6U:
						num = (int)((num3 * 4091694146U) ^ 1485329683U);
						continue;
					case 7U:
					{
						int num4 = AyaOrbColorless.\u200D\u202E\u206F\u200B\u206A\u206A\u206D\u200C\u202D\u202E\u202C\u202C\u206B\u200F\u206F\u200B\u206B\u206B\u200D\u206E\u206B\u202A\u206C\u202A\u202E\u202B\u206A\u202A\u202D\u202E\u200F\u202D\u200E\u206C\u200C\u202D\u206A\u200D\u202C\u206A\u202E(base.EnemyMoveRng, 0, 8);
						num = -266102392;
						continue;
					}
					case 8U:
						goto IL_0164;
					case 9U:
					{
						AyaOrbColorless.MoveType moveType = AyaOrbColorless.MoveType.DoNothing;
						num = (int)((num3 * 611297427U) ^ 3559645451U);
						continue;
					}
					case 10U:
						goto IL_0145;
					case 12U:
						goto IL_003C;
					case 13U:
						num = (int)(((ayaBossZUN != null) ? 1784635366U : 71223997U) ^ (num3 * 2222311545U));
						continue;
					case 14U:
						num = (int)((num3 * 1030601510U) ^ 847590323U);
						continue;
					case 15U:
						goto IL_01C8;
					case 16U:
						num = (int)((num3 * 1389583016U) ^ 231146591U);
						continue;
					case 17U:
						num = (int)((num3 * 475154692U) ^ 1196958507U);
						continue;
					case 18U:
						goto IL_02A7;
					case 19U:
						goto IL_029B;
					case 20U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbColorless.\u206A\u206E\u200E\u200B\u200C\u200D\u200D\u206D\u202C\u202D\u202E\u200B\u200E\u206A\u202A\u202D\u202D\u202A\u200B\u206A\u206F\u202A\u200C\u202B\u206E\u206C\u202E\u206C\u206E\u206E\u202B\u202B\u206E\u200D\u202B\u200F\u206D\u202D\u200F\u202A\u202E(this)) ? 2163164282U : 4293643980U) ^ (num3 * 536856717U));
						continue;
					case 21U:
						num = (int)((num3 * 698025478U) ^ 3551185795U);
						continue;
					case 22U:
						goto IL_0139;
					case 23U:
					{
						int num4;
						switch (num4)
						{
						case 0:
							goto IL_02A7;
						case 1:
							goto IL_0164;
						case 2:
							goto IL_029B;
						case 3:
							goto IL_01C8;
						case 4:
							goto IL_0269;
						case 5:
							goto IL_0145;
						case 6:
							goto IL_0139;
						case 7:
							goto IL_02C6;
						case 8:
							goto IL_025D;
						default:
							num = (int)((num3 * 2301732538U) ^ 263583160U);
							continue;
						}
						break;
					}
					case 24U:
					{
						AyaOrbColorless.MoveType moveType = moveType2;
						num = -1286704271;
						continue;
					}
					case 25U:
						num = (int)((num3 * 1870888278U) ^ 2653077553U);
						continue;
					case 26U:
						goto IL_01B8;
					case 27U:
						num = (int)((num3 * 1966574299U) ^ 1646390138U);
						continue;
					}
					goto Block_3;
					IL_0139:
					moveType2 = AyaOrbColorless.MoveType.PoweroftheOrdinary;
					num = -473076699;
					continue;
					IL_0145:
					moveType2 = AyaOrbColorless.MoveType.SeaofTranquility;
					num = -819591270;
					continue;
					IL_0164:
					moveType2 = AyaOrbColorless.MoveType.Shoot;
					num = -1641770614;
					continue;
					IL_01C8:
					moveType2 = AyaOrbColorless.MoveType.CucumberMissile;
					num = -1102025690;
					continue;
					IL_025D:
					moveType2 = AyaOrbColorless.MoveType.ShiveringNightmare;
					num = 442501867;
					continue;
					IL_0269:
					moveType2 = AyaOrbColorless.MoveType.CleanEnergy;
					num = -798073921;
					continue;
					IL_029B:
					moveType2 = AyaOrbColorless.MoveType.Boundary;
					num = -2002550208;
					continue;
					IL_02A7:
					moveType2 = AyaOrbColorless.MoveType.Tipsy;
					num = -798073921;
					continue;
					IL_02C6:
					moveType2 = AyaOrbColorless.MoveType.DisintegratingWinds;
					num = 556300433;
				}
			}
			Block_3:
			goto IL_02D2;
			IL_01B8:
			throw AyaOrbColorless.\u206E\u200E\u206B\u200E\u200C\u200D\u206A\u202C\u206A\u206E\u202C\u200D\u200B\u200D\u200D\u202D\u206D\u200E\u200D\u200C\u202B\u202D\u200C\u206A\u202A\u202A\u200E\u206F\u202C\u206C\u206C\u206B\u206D\u200B\u200D\u202A\u206E\u206B\u202E\u200D\u202E();
			IL_02D2:
			base.ReactBattleEvent<GameEventArgs>(AyaOrbColorless.\u202B\u206A\u206B\u202D\u202B\u200B\u206D\u202B\u202E\u206F\u200D\u202C\u200F\u200C\u206B\u206D\u206D\u202A\u200E\u206B\u206F\u200C\u202D\u202E\u202E\u200D\u202E\u202E\u202D\u200E\u206B\u206F\u202E\u200E\u206A\u206A\u202B\u200B\u206D\u202D\u202E(AyaOrbColorless.\u200D\u202C\u200C\u200C\u206D\u206F\u200B\u200B\u206E\u200C\u202E\u206A\u200F\u200D\u200D\u202B\u202C\u200C\u206F\u202C\u200F\u200C\u200C\u206A\u206B\u200D\u200D\u200F\u206B\u206E\u202C\u200C\u202B\u206A\u206D\u202D\u206A\u206A\u202D\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbColorless.<OnBattleStarted>d__6 <OnBattleStarted>d__ = new AyaOrbColorless.<OnBattleStarted>d__6(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> Tipsy()
		{
			AyaOrbColorless.<Tipsy>d__7 <Tipsy>d__ = new AyaOrbColorless.<Tipsy>d__7(-2);
			<Tipsy>d__.<>4__this = this;
			return <Tipsy>d__;
		}

		private IEnumerable<BattleAction> Boundary()
		{
			AyaOrbColorless.<Boundary>d__8 <Boundary>d__ = new AyaOrbColorless.<Boundary>d__8(-2);
			<Boundary>d__.<>4__this = this;
			return <Boundary>d__;
		}

		private IEnumerable<BattleAction> CucumberMissile()
		{
			AyaOrbColorless.<CucumberMissile>d__9 <CucumberMissile>d__ = new AyaOrbColorless.<CucumberMissile>d__9(-2);
			<CucumberMissile>d__.<>4__this = this;
			return <CucumberMissile>d__;
		}

		private IEnumerable<BattleAction> CleanEnergy()
		{
			AyaOrbColorless.<CleanEnergy>d__10 <CleanEnergy>d__ = new AyaOrbColorless.<CleanEnergy>d__10(-2);
			<CleanEnergy>d__.<>4__this = this;
			return <CleanEnergy>d__;
		}

		private IEnumerable<BattleAction> SeaofTranquility()
		{
			AyaOrbColorless.<SeaofTranquility>d__11 <SeaofTranquility>d__ = new AyaOrbColorless.<SeaofTranquility>d__11(-2);
			<SeaofTranquility>d__.<>4__this = this;
			return <SeaofTranquility>d__;
		}

		private IEnumerable<BattleAction> PoweroftheOrdinary()
		{
			AyaOrbColorless.<PoweroftheOrdinary>d__12 <PoweroftheOrdinary>d__ = new AyaOrbColorless.<PoweroftheOrdinary>d__12(-2);
			<PoweroftheOrdinary>d__.<>4__this = this;
			return <PoweroftheOrdinary>d__;
		}

		private IEnumerable<BattleAction> ShiveringNightmare()
		{
			AyaOrbColorless.<ShiveringNightmare>d__13 <ShiveringNightmare>d__ = new AyaOrbColorless.<ShiveringNightmare>d__13(-2);
			<ShiveringNightmare>d__.<>4__this = this;
			return <ShiveringNightmare>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbColorless.<DoNothingActions>d__14 <DoNothingActions>d__ = new AyaOrbColorless.<DoNothingActions>d__14(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbColorless.<GetTurnMoves>d__15 <GetTurnMoves>d__ = new AyaOrbColorless.<GetTurnMoves>d__15(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			BattleController battleController = AyaOrbColorless.\u200D\u202C\u200C\u200C\u206D\u206F\u200B\u200B\u206E\u200C\u202E\u206A\u200F\u200D\u200D\u202B\u202C\u200C\u206F\u202C\u200F\u200C\u200C\u206A\u206B\u200D\u200D\u200F\u206B\u206E\u202C\u200C\u202B\u206A\u206D\u202D\u206A\u206A\u202D\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbColorless.\u206E\u202A\u206C\u206D\u202A\u200B\u200C\u206C\u206F\u200D\u202E\u206F\u206E\u206D\u200F\u200B\u202D\u206B\u202A\u202A\u202B\u200F\u202B\u206F\u202C\u206F\u206A\u200E\u200E\u206B\u206E\u206F\u206B\u200C\u206C\u200F\u200E\u200C\u206D\u200F\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_004A:
				int num = 1103026647;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-num2) * -1575184307 - -1606118384)) % 34U)
					{
					case 0U:
						goto IL_0128;
					case 1U:
						goto IL_020E;
					case 2U:
						this.Next = AyaOrbColorless.MoveType.Shoot;
						num = (int)((num3 * 3300768201U) ^ 1247167527U);
						continue;
					case 3U:
						return;
					case 4U:
						num = (int)(((this.SpellCooldown <= 0) ? 1862604347U : 2963215788U) ^ (num3 * 354565280U));
						continue;
					case 5U:
						return;
					case 6U:
						this.Next = AyaOrbColorless.MoveType.DoNothing;
						num = (int)((num3 * 3637141133U) ^ 559452392U);
						continue;
					case 7U:
						goto IL_018A;
					case 8U:
						goto IL_0439;
					case 9U:
						goto IL_01BA;
					case 10U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbColorless.\u206A\u206E\u200E\u200B\u200C\u200D\u200D\u206D\u202C\u202D\u202E\u200B\u200E\u206A\u202A\u202D\u202D\u202A\u200B\u206A\u206F\u202A\u200C\u202B\u206E\u206C\u202E\u206C\u206E\u206E\u202B\u202B\u206E\u200D\u202B\u200F\u206D\u202D\u200F\u202A\u202E(this)) ? 2645309768U : 593297370U) ^ (num3 * 549936279U));
						continue;
					case 11U:
						num = (int)((num3 * 4288594022U) ^ 2646099695U);
						continue;
					case 12U:
						goto IL_004A;
					case 13U:
						return;
					case 14U:
						this.Next = AyaOrbColorless.MoveType.SeaofTranquility;
						num = (int)((num3 * 221829189U) ^ 3161745176U);
						continue;
					case 15U:
						goto IL_02F8;
					case 16U:
						return;
					case 17U:
					{
						int num4;
						switch (num4)
						{
						case 0:
							goto IL_02F8;
						case 1:
							goto IL_029C;
						case 2:
							goto IL_041C;
						case 3:
							goto IL_01F1;
						case 4:
							goto IL_018A;
						case 5:
							goto IL_01BA;
						case 6:
							goto IL_0128;
						case 7:
							goto IL_0385;
						case 8:
							goto IL_0439;
						default:
							num = (int)((num3 * 1396945927U) ^ 70573148U);
							continue;
						}
						break;
					}
					case 18U:
						return;
					case 20U:
						goto IL_01D7;
					case 21U:
						num = (int)(((ayaBossZUN != null) ? 4134947722U : 910914836U) ^ (num3 * 882149800U));
						continue;
					case 22U:
						return;
					case 23U:
						goto IL_0385;
					case 24U:
						goto IL_041C;
					case 25U:
						this.Next = AyaOrbColorless.MoveType.CucumberMissile;
						num = (int)((num3 * 1160592427U) ^ 979500156U);
						continue;
					case 26U:
					{
						int num4 = AyaOrbColorless.\u200D\u202E\u206F\u200B\u206A\u206A\u206D\u200C\u202D\u202E\u202C\u202C\u206B\u200F\u206F\u200B\u206B\u206B\u200D\u206E\u206B\u202A\u206C\u202A\u202E\u202B\u206A\u202A\u202D\u202E\u200F\u202D\u200E\u206C\u200C\u202D\u206A\u200D\u202C\u206A\u202E(base.EnemyMoveRng, 0, 8);
						num = -1914481699;
						continue;
					}
					case 27U:
						this.Next = AyaOrbColorless.MoveType.DisintegratingWinds;
						num = (int)((num3 * 743267418U) ^ 2711493392U);
						continue;
					case 28U:
						goto IL_03EA;
					case 29U:
						goto IL_01F1;
					case 30U:
						this.Next = AyaOrbColorless.MoveType.CleanEnergy;
						num = (int)((num3 * 1216561510U) ^ 213094689U);
						continue;
					case 31U:
						return;
					case 32U:
						goto IL_029C;
					case 33U:
						this.Next = AyaOrbColorless.MoveType.PoweroftheOrdinary;
						num = (int)((num3 * 4163978131U) ^ 545726790U);
						continue;
					}
					goto Block_3;
					IL_0128:
					num = ((this.Next == AyaOrbColorless.MoveType.PoweroftheOrdinary) ? (-961563220) : (-1068771569));
					continue;
					IL_018A:
					num = ((this.Next == AyaOrbColorless.MoveType.CleanEnergy) ? (-961563220) : 174718780);
					continue;
					IL_01BA:
					num = ((this.Next != AyaOrbColorless.MoveType.SeaofTranquility) ? (-1417925282) : (-961563220));
					continue;
					IL_01F1:
					num = ((this.Next == AyaOrbColorless.MoveType.CucumberMissile) ? (-961563220) : 26597955);
					continue;
					IL_029C:
					num = ((this.Next == AyaOrbColorless.MoveType.Shoot) ? (-961563220) : (-1708547862));
					continue;
					IL_02F8:
					num = ((this.Next != AyaOrbColorless.MoveType.Tipsy) ? 1614811158 : (-961563220));
					continue;
					IL_0385:
					num = ((this.Next != AyaOrbColorless.MoveType.DisintegratingWinds) ? (-1857439137) : (-961563220));
					continue;
					IL_041C:
					num = ((this.Next != AyaOrbColorless.MoveType.Boundary) ? 663234296 : (-961563220));
					continue;
					IL_0439:
					num = ((this.Next == AyaOrbColorless.MoveType.ShiveringNightmare) ? (-961563220) : 1692078416);
				}
			}
			Block_3:
			goto IL_0456;
			IL_01D7:
			this.Next = AyaOrbColorless.MoveType.Tipsy;
			return;
			IL_020E:
			this.Next = AyaOrbColorless.MoveType.ShiveringNightmare;
			return;
			IL_03EA:
			this.Next = AyaOrbColorless.MoveType.Boundary;
			return;
			IL_0456:
			throw AyaOrbColorless.\u206E\u200E\u206B\u200E\u200C\u200D\u206A\u202C\u206A\u206E\u202C\u200D\u200B\u200D\u200D\u202D\u206D\u200E\u200D\u200C\u202B\u202D\u200C\u206A\u202A\u202A\u200E\u206F\u202C\u206C\u206C\u206B\u206D\u200B\u200D\u202A\u206E\u206B\u202E\u200D\u202E();
		}

		static BattleController \u200D\u202C\u200C\u200C\u206D\u206F\u200B\u200B\u206E\u200C\u202E\u206A\u200F\u200D\u200D\u202B\u202C\u200C\u206F\u202C\u200F\u200C\u200C\u206A\u206B\u200D\u200D\u200F\u206B\u206E\u202C\u200C\u202B\u206A\u206D\u202D\u206A\u206A\u202D\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u206E\u202A\u206C\u206D\u202A\u200B\u200C\u206C\u206F\u200D\u202E\u206F\u206E\u206D\u200F\u200B\u202D\u206B\u202A\u202A\u202B\u200F\u202B\u206F\u202C\u206F\u206A\u200E\u200E\u206B\u206E\u206F\u206B\u200C\u206C\u200F\u200E\u200C\u206D\u200F\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u206A\u206E\u200E\u200B\u200C\u200D\u200D\u206D\u202C\u202D\u202E\u200B\u200E\u206A\u202A\u202D\u202D\u202A\u200B\u206A\u206F\u202A\u200C\u202B\u206E\u206C\u202E\u206C\u206E\u206E\u202B\u202B\u206E\u200D\u202B\u200F\u206D\u202D\u200F\u202A\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u200D\u202E\u206F\u200B\u206A\u206A\u206D\u200C\u202D\u202E\u202C\u202C\u206B\u200F\u206F\u200B\u206B\u206B\u200D\u206E\u206B\u202A\u206C\u202A\u202E\u202B\u206A\u202A\u202D\u202E\u200F\u202D\u200E\u206C\u200C\u202D\u206A\u200D\u202C\u206A\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u206E\u200E\u206B\u200E\u200C\u200D\u206A\u202C\u206A\u206E\u202C\u200D\u200B\u200D\u200D\u202D\u206D\u200E\u200D\u200C\u202B\u202D\u200C\u206A\u202A\u202A\u200E\u206F\u202C\u206C\u206C\u206B\u206D\u200B\u200D\u202A\u206E\u206B\u202E\u200D\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u202B\u206A\u206B\u202D\u202B\u200B\u206D\u202B\u202E\u206F\u200D\u202C\u200F\u200C\u206B\u206D\u206D\u202A\u200E\u206B\u206F\u200C\u202D\u202E\u202E\u200D\u202E\u202E\u202D\u200E\u206B\u206F\u202E\u200E\u206A\u206A\u202B\u200B\u206D\u202D\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SpellCooldown;

		private enum MoveType
		{
			Tipsy,
			Shoot,
			Boundary,
			CucumberMissile,
			CleanEnergy,
			SeaofTranquility,
			PoweroftheOrdinary,
			DisintegratingWinds,
			ShiveringNightmare,
			DoNothing
		}
	}
}
