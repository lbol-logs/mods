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
	[EntityLogic(typeof(AyaOrbBlackDef))]
	public sealed class AyaOrbBlack : EnemyUnit
	{
		private AyaOrbBlack.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbBlack.\u206E\u206F\u200C\u200D\u206D\u202D\u206A\u200F\u200E\u202D\u206F\u202B\u206C\u202E\u200F\u202B\u200D\u206E\u200C\u206E\u200F\u200B\u200D\u200B\u202E\u206B\u206D\u200E\u206D\u202C\u206C\u206F\u202A\u202D\u206D\u200F\u200F\u206A\u206F\u206C\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbBlack.\u202A\u206F\u206B\u206D\u206C\u202C\u200B\u200F\u206E\u200B\u200F\u200B\u200E\u200D\u206F\u202D\u206A\u200E\u202E\u200C\u200B\u206D\u200D\u200B\u206A\u206B\u202D\u202D\u200E\u202E\u202D\u206E\u206D\u200D\u202E\u200F\u202C\u202D\u206D\u200C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			if (ayaBossZUN != null)
			{
				goto IL_0042;
			}
			goto IL_0192;
			int num2;
			int num4;
			for (;;)
			{
				IL_0047:
				int num = num2;
				uint num3;
				AyaOrbBlack.MoveType moveType2;
				switch ((num3 = (uint)(((num ^ ((~1566924514 * -1249262755) ^ -1393994119) ^ 1808815719) + (-1265462760 - 248545838)) ^ 1145844914)) % 31U)
				{
				case 0U:
					num2 = (int)((num3 * 9083575U) ^ 3930407530U);
					continue;
				case 1U:
					goto IL_0172;
				case 2U:
					num2 = (int)((num3 * 3346219220U) ^ 2837233138U);
					continue;
				case 3U:
					goto IL_02D9;
				case 4U:
					goto IL_0192;
				case 5U:
					num2 = (int)((num3 * 1212831972U) ^ 1635223030U);
					continue;
				case 6U:
					goto IL_0147;
				case 7U:
					goto IL_0236;
				case 8U:
					goto IL_022A;
				case 9U:
					goto IL_0316;
				case 10U:
					num2 = (int)((num3 * 2887574583U) ^ 3068235489U);
					continue;
				case 11U:
					goto IL_0153;
				case 12U:
					goto IL_0255;
				case 13U:
					num2 = (int)((num3 * 2861390717U) ^ 929888625U);
					continue;
				case 14U:
					goto IL_0128;
				case 15U:
					goto IL_02AE;
				case 16U:
					switch (num4)
					{
					case 0:
						goto IL_0153;
					case 1:
						goto IL_0128;
					case 2:
						goto IL_0236;
					case 3:
						goto IL_0255;
					case 4:
						goto IL_0147;
					case 5:
						goto IL_01C1;
					case 6:
						goto IL_022A;
					case 7:
						goto IL_021E;
					case 8:
						goto IL_02AE;
					case 9:
						goto IL_0172;
					case 10:
						goto IL_01CD;
					case 11:
						goto IL_01DA;
					case 12:
						goto IL_02D9;
					default:
						num2 = (int)((num3 * 2491430765U) ^ 3414418846U);
						continue;
					}
					break;
				case 17U:
					goto IL_01CD;
				case 18U:
					num2 = (int)((num3 * 2123598814U) ^ 3827870120U);
					continue;
				case 19U:
				{
					AyaOrbBlack.MoveType moveType = moveType2;
					num2 = -1872892986;
					continue;
				}
				case 20U:
					goto IL_0042;
				case 21U:
					num2 = (int)((num3 * 166296434U) ^ 4070681362U);
					continue;
				case 22U:
				{
					AyaOrbBlack.MoveType moveType = AyaOrbBlack.MoveType.DoNothing;
					num2 = (int)((num3 * 833536937U) ^ 3718008421U);
					continue;
				}
				case 23U:
					goto IL_021E;
				case 24U:
					num2 = (int)((num3 * 2567096895U) ^ 4068221486U);
					continue;
				case 25U:
					num2 = (int)((ayaBossZUN.restPool.Contains(AyaOrbBlack.\u202C\u206D\u206B\u206C\u202C\u200F\u200E\u206F\u206B\u206E\u200D\u200E\u206A\u200C\u200F\u202E\u200B\u206A\u200E\u200B\u202D\u202D\u200F\u206E\u202A\u206E\u202E\u202C\u206D\u200B\u206F\u206D\u206A\u200B\u206F\u206B\u202B\u200D\u206C\u202B\u202E(this)) ? 1419884024U : 4127197782U) ^ (num3 * 1511112240U));
					continue;
				case 26U:
					num2 = (int)((num3 * 2683222554U) ^ 2712781128U);
					continue;
				case 27U:
				{
					AyaOrbBlack.MoveType moveType;
					this.Next = moveType;
					num2 = -65698485;
					continue;
				}
				case 29U:
					goto IL_01DA;
				case 30U:
					goto IL_01C1;
				}
				break;
				IL_0128:
				moveType2 = AyaOrbBlack.MoveType.AgelessDream;
				num2 = -963702612;
				continue;
				IL_0147:
				moveType2 = AyaOrbBlack.MoveType.SongoftheNightSparrow;
				num2 = -855062498;
				continue;
				IL_0153:
				moveType2 = AyaOrbBlack.MoveType.Shade;
				num2 = -855062498;
				continue;
				IL_0172:
				moveType2 = AyaOrbBlack.MoveType.WheelofMisfortune;
				num2 = -1865542673;
				continue;
				IL_01C1:
				moveType2 = AyaOrbBlack.MoveType.UnexplainedFever;
				num2 = -855062498;
				continue;
				IL_01CD:
				moveType2 = AyaOrbBlack.MoveType.ManipulationofFate;
				num2 = 824886646;
				continue;
				IL_01DA:
				moveType2 = AyaOrbBlack.MoveType.DreamExpress;
				num2 = -37583256;
				continue;
				IL_021E:
				moveType2 = AyaOrbBlack.MoveType.ViolinSolo;
				num2 = -855062498;
				continue;
				IL_022A:
				moveType2 = AyaOrbBlack.MoveType.DevilsCodex;
				num2 = -855062498;
				continue;
				IL_0236:
				moveType2 = AyaOrbBlack.MoveType.SeepingMiasma;
				num2 = -1073471709;
				continue;
				IL_0255:
				moveType2 = AyaOrbBlack.MoveType.HeartBlossoms;
				num2 = -204078439;
				continue;
				IL_02AE:
				moveType2 = AyaOrbBlack.MoveType.SinoftheBlackHorse;
				num2 = -980563315;
				continue;
				IL_02D9:
				moveType2 = AyaOrbBlack.MoveType.TrueFullMoon;
				num2 = 203372010;
			}
			goto IL_0326;
			IL_0316:
			throw AyaOrbBlack.\u206C\u200B\u200E\u206E\u202D\u200C\u202E\u202A\u200E\u202E\u202E\u200E\u206B\u200C\u206E\u202A\u200F\u206B\u206F\u206E\u202D\u200B\u206C\u206F\u202A\u202E\u206E\u200B\u206F\u200E\u206B\u200C\u202D\u202D\u202A\u206C\u206D\u206B\u206E\u206B\u202E();
			IL_0326:
			base.ReactBattleEvent<GameEventArgs>(AyaOrbBlack.\u200D\u206F\u202B\u202C\u202C\u200F\u202B\u206A\u206F\u202C\u206A\u200D\u202A\u200E\u202C\u200E\u206C\u200F\u202A\u206E\u206D\u200C\u200F\u200D\u202A\u206E\u202B\u202E\u206A\u202B\u206F\u202B\u200E\u200F\u202E\u202D\u206F\u202D\u206F\u202C\u202E(AyaOrbBlack.\u206E\u206F\u200C\u200D\u206D\u202D\u206A\u200F\u200E\u202D\u206F\u202B\u206C\u202E\u200F\u202B\u200D\u206E\u200C\u206E\u200F\u200B\u200D\u200B\u202E\u206B\u206D\u200E\u206D\u202C\u206C\u206F\u202A\u202D\u206D\u200F\u200F\u206A\u206F\u206C\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			return;
			IL_0042:
			num2 = -2038697145;
			goto IL_0047;
			IL_0192:
			num4 = AyaOrbBlack.\u206F\u206D\u202D\u202D\u202E\u202C\u200D\u200B\u200C\u206F\u202A\u202C\u202B\u206E\u202A\u202E\u206F\u200B\u206F\u206E\u206E\u206B\u200B\u206B\u200B\u206E\u206A\u206F\u202A\u206F\u202B\u200E\u206E\u206C\u206A\u200F\u206F\u202C\u200D\u202C\u202E(base.EnemyMoveRng, 0, 12);
			num2 = -226027029;
			goto IL_0047;
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbBlack.<OnBattleStarted>d__6 <OnBattleStarted>d__ = new AyaOrbBlack.<OnBattleStarted>d__6(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> Shade()
		{
			AyaOrbBlack.<Shade>d__7 <Shade>d__ = new AyaOrbBlack.<Shade>d__7(-2);
			<Shade>d__.<>4__this = this;
			return <Shade>d__;
		}

		private IEnumerable<BattleAction> AgelessDream()
		{
			AyaOrbBlack.<AgelessDream>d__8 <AgelessDream>d__ = new AyaOrbBlack.<AgelessDream>d__8(-2);
			<AgelessDream>d__.<>4__this = this;
			return <AgelessDream>d__;
		}

		private IEnumerable<BattleAction> HeartBlossoms()
		{
			AyaOrbBlack.<HeartBlossoms>d__9 <HeartBlossoms>d__ = new AyaOrbBlack.<HeartBlossoms>d__9(-2);
			<HeartBlossoms>d__.<>4__this = this;
			return <HeartBlossoms>d__;
		}

		private IEnumerable<BattleAction> DevilsCodex()
		{
			AyaOrbBlack.<DevilsCodex>d__10 <DevilsCodex>d__ = new AyaOrbBlack.<DevilsCodex>d__10(-2);
			<DevilsCodex>d__.<>4__this = this;
			return <DevilsCodex>d__;
		}

		private IEnumerable<BattleAction> ViolinSolo()
		{
			AyaOrbBlack.<ViolinSolo>d__11 <ViolinSolo>d__ = new AyaOrbBlack.<ViolinSolo>d__11(-2);
			<ViolinSolo>d__.<>4__this = this;
			return <ViolinSolo>d__;
		}

		private IEnumerable<BattleAction> ManipulationofFate()
		{
			AyaOrbBlack.<ManipulationofFate>d__12 <ManipulationofFate>d__ = new AyaOrbBlack.<ManipulationofFate>d__12(-2);
			<ManipulationofFate>d__.<>4__this = this;
			return <ManipulationofFate>d__;
		}

		private IEnumerable<BattleAction> TrueFullMoon()
		{
			AyaOrbBlack.<TrueFullMoon>d__13 <TrueFullMoon>d__ = new AyaOrbBlack.<TrueFullMoon>d__13(-2);
			<TrueFullMoon>d__.<>4__this = this;
			return <TrueFullMoon>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbBlack.<DoNothingActions>d__14 <DoNothingActions>d__ = new AyaOrbBlack.<DoNothingActions>d__14(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbBlack.<GetTurnMoves>d__15 <GetTurnMoves>d__ = new AyaOrbBlack.<GetTurnMoves>d__15(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			for (;;)
			{
				IL_000E:
				int num = 1706642862;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-24937331 - -(uint)(~(--1162905434) - (num2 ^ ((-623339299 ^ 1784207040) * -2020487429))))) % 43U)
					{
					case 0U:
						this.Next = AyaOrbBlack.MoveType.TrueFullMoon;
						num = (int)((num3 * 1155510859U) ^ 3320561278U);
						continue;
					case 1U:
						goto IL_0319;
					case 2U:
						num = (int)((num3 * 1379719433U) ^ 2603478231U);
						continue;
					case 4U:
						goto IL_0387;
					case 5U:
						return;
					case 6U:
						goto IL_020B;
					case 7U:
					{
						int num4;
						switch (num4)
						{
						case 0:
							goto IL_0346;
						case 1:
							goto IL_02FC;
						case 2:
							goto IL_0141;
						case 3:
							goto IL_04D0;
						case 4:
							goto IL_0387;
						case 5:
							goto IL_00F2;
						case 6:
							goto IL_020B;
						case 7:
							goto IL_02C2;
						case 8:
							goto IL_02DF;
						case 9:
							goto IL_01D4;
						case 10:
							goto IL_02A4;
						case 11:
							goto IL_03DB;
						case 12:
							goto IL_03BD;
						default:
							num = (int)((num3 * 2757721875U) ^ 2662949872U);
							continue;
						}
						break;
					}
					case 8U:
						this.Next = AyaOrbBlack.MoveType.ViolinSolo;
						num = (int)((num3 * 3222420645U) ^ 1291127038U);
						continue;
					case 9U:
					{
						BattleController battleController = AyaOrbBlack.\u206E\u206F\u200C\u200D\u206D\u202D\u206A\u200F\u200E\u202D\u206F\u202B\u206C\u202E\u200F\u202B\u200D\u206E\u200C\u206E\u200F\u200B\u200D\u200B\u202E\u206B\u206D\u200E\u206D\u202C\u206C\u206F\u202A\u202D\u206D\u200F\u200F\u206A\u206F\u206C\u202E(this);
						object obj;
						if (battleController == null)
						{
							obj = null;
						}
						else
						{
							obj = AyaOrbBlack.\u202A\u206F\u206B\u206D\u206C\u202C\u200B\u200F\u206E\u200B\u200F\u200B\u200E\u200D\u206F\u202D\u206A\u200E\u202E\u200C\u200B\u206D\u200D\u200B\u206A\u206B\u202D\u202D\u200E\u202E\u202D\u206E\u206D\u200D\u202E\u200F\u202C\u202D\u206D\u200C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
						}
						AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
						num = 1103833384;
						continue;
					}
					case 10U:
					{
						int num4 = AyaOrbBlack.\u206F\u206D\u202D\u202D\u202E\u202C\u200D\u200B\u200C\u206F\u202A\u202C\u202B\u206E\u202A\u202E\u206F\u200B\u206F\u206E\u206E\u206B\u200B\u206B\u200B\u206E\u206A\u206F\u202A\u206F\u202B\u200E\u206E\u206C\u206A\u200F\u206F\u202C\u200D\u202C\u202E(base.EnemyMoveRng, 0, 12);
						num = -381515379;
						continue;
					}
					case 11U:
						return;
					case 12U:
						goto IL_00F2;
					case 13U:
						goto IL_02DF;
					case 14U:
						goto IL_01A6;
					case 15U:
						goto IL_0141;
					case 16U:
						goto IL_04D0;
					case 17U:
						goto IL_01D4;
					case 18U:
						goto IL_02A4;
					case 19U:
						this.Next = AyaOrbBlack.MoveType.SeepingMiasma;
						num = (int)((num3 * 1196761802U) ^ 2857728077U);
						continue;
					case 20U:
						this.Next = AyaOrbBlack.MoveType.AgelessDream;
						num = (int)((num3 * 1807027869U) ^ 1886401154U);
						continue;
					case 21U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)(((!ayaBossZUN.restPool.Contains(AyaOrbBlack.\u202C\u206D\u206B\u206C\u202C\u200F\u200E\u206F\u206B\u206E\u200D\u200E\u206A\u200C\u200F\u202E\u200B\u206A\u200E\u200B\u202D\u202D\u200F\u206E\u202A\u206E\u202E\u202C\u206D\u200B\u206F\u206D\u206A\u200B\u206F\u206B\u202B\u200D\u206C\u202B\u202E(this))) ? 3661916487U : 3619856415U) ^ (num3 * 2464712130U));
						continue;
					}
					case 22U:
						goto IL_0346;
					case 23U:
						return;
					case 24U:
						goto IL_03BD;
					case 25U:
						return;
					case 26U:
						return;
					case 27U:
						goto IL_0289;
					case 28U:
						goto IL_0506;
					case 29U:
						return;
					case 30U:
						this.Next = AyaOrbBlack.MoveType.HeartBlossoms;
						num = (int)((num3 * 694618474U) ^ 3907370984U);
						continue;
					case 31U:
						goto IL_03F9;
					case 32U:
						goto IL_000E;
					case 33U:
						goto IL_02C2;
					case 34U:
						goto IL_0254;
					case 35U:
						this.Next = AyaOrbBlack.MoveType.UnexplainedFever;
						num = (int)((num3 * 2619328249U) ^ 1166253675U);
						continue;
					case 36U:
						num = (int)(((this.SpellCooldown <= 0) ? 594733959U : 4010715593U) ^ (num3 * 2879302462U));
						continue;
					case 37U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)(((ayaBossZUN != null) ? 2729766344U : 1695995984U) ^ (num3 * 1208256881U));
						continue;
					}
					case 38U:
						return;
					case 39U:
						goto IL_02FC;
					case 40U:
						goto IL_026F;
					case 41U:
						goto IL_03DB;
					case 42U:
						this.Next = AyaOrbBlack.MoveType.SinoftheBlackHorse;
						num = (int)((num3 * 126147707U) ^ 3487408748U);
						continue;
					}
					goto Block_1;
					IL_00F2:
					num = ((this.Next != AyaOrbBlack.MoveType.UnexplainedFever) ? (-354001810) : 1998467563);
					continue;
					IL_0141:
					num = ((this.Next == AyaOrbBlack.MoveType.SeepingMiasma) ? 1998467563 : 1525667695);
					continue;
					IL_01D4:
					num = ((this.Next != AyaOrbBlack.MoveType.WheelofMisfortune) ? (-1586498511) : 1998467563);
					continue;
					IL_020B:
					num = ((this.Next != AyaOrbBlack.MoveType.DevilsCodex) ? (-1084764368) : 1998467563);
					continue;
					IL_02A4:
					num = ((this.Next != AyaOrbBlack.MoveType.ManipulationofFate) ? (-1805637238) : 1998467563);
					continue;
					IL_02C2:
					num = ((this.Next != AyaOrbBlack.MoveType.ViolinSolo) ? 1651812853 : 1998467563);
					continue;
					IL_02DF:
					num = ((this.Next != AyaOrbBlack.MoveType.SinoftheBlackHorse) ? (-1097189012) : 1998467563);
					continue;
					IL_02FC:
					num = ((this.Next != AyaOrbBlack.MoveType.AgelessDream) ? (-1251649984) : 1998467563);
					continue;
					IL_0346:
					num = ((this.Next == AyaOrbBlack.MoveType.Shade) ? 1998467563 : 1714290775);
					continue;
					IL_0387:
					num = ((this.Next != AyaOrbBlack.MoveType.SongoftheNightSparrow) ? 1998245601 : 1998467563);
					continue;
					IL_03BD:
					num = ((this.Next == AyaOrbBlack.MoveType.TrueFullMoon) ? 1998467563 : 2118072460);
					continue;
					IL_03DB:
					num = ((this.Next != AyaOrbBlack.MoveType.DreamExpress) ? (-1160726222) : 1998467563);
					continue;
					IL_04D0:
					num = ((this.Next != AyaOrbBlack.MoveType.HeartBlossoms) ? (-1471216278) : 1998467563);
				}
			}
			Block_1:
			goto IL_058D;
			IL_01A6:
			this.Next = AyaOrbBlack.MoveType.ManipulationofFate;
			return;
			IL_0254:
			this.Next = AyaOrbBlack.MoveType.DoNothing;
			return;
			IL_026F:
			this.Next = AyaOrbBlack.MoveType.SongoftheNightSparrow;
			return;
			IL_0289:
			this.Next = AyaOrbBlack.MoveType.WheelofMisfortune;
			return;
			IL_0319:
			this.Next = AyaOrbBlack.MoveType.Shade;
			return;
			IL_03F9:
			this.Next = AyaOrbBlack.MoveType.DevilsCodex;
			return;
			IL_0506:
			this.Next = AyaOrbBlack.MoveType.DreamExpress;
			return;
			IL_058D:
			throw AyaOrbBlack.\u206C\u200B\u200E\u206E\u202D\u200C\u202E\u202A\u200E\u202E\u202E\u200E\u206B\u200C\u206E\u202A\u200F\u206B\u206F\u206E\u202D\u200B\u206C\u206F\u202A\u202E\u206E\u200B\u206F\u200E\u206B\u200C\u202D\u202D\u202A\u206C\u206D\u206B\u206E\u206B\u202E();
		}

		static BattleController \u206E\u206F\u200C\u200D\u206D\u202D\u206A\u200F\u200E\u202D\u206F\u202B\u206C\u202E\u200F\u202B\u200D\u206E\u200C\u206E\u200F\u200B\u200D\u200B\u202E\u206B\u206D\u200E\u206D\u202C\u206C\u206F\u202A\u202D\u206D\u200F\u200F\u206A\u206F\u206C\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u202A\u206F\u206B\u206D\u206C\u202C\u200B\u200F\u206E\u200B\u200F\u200B\u200E\u200D\u206F\u202D\u206A\u200E\u202E\u200C\u200B\u206D\u200D\u200B\u206A\u206B\u202D\u202D\u200E\u202E\u202D\u206E\u206D\u200D\u202E\u200F\u202C\u202D\u206D\u200C\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u202C\u206D\u206B\u206C\u202C\u200F\u200E\u206F\u206B\u206E\u200D\u200E\u206A\u200C\u200F\u202E\u200B\u206A\u200E\u200B\u202D\u202D\u200F\u206E\u202A\u206E\u202E\u202C\u206D\u200B\u206F\u206D\u206A\u200B\u206F\u206B\u202B\u200D\u206C\u202B\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u206F\u206D\u202D\u202D\u202E\u202C\u200D\u200B\u200C\u206F\u202A\u202C\u202B\u206E\u202A\u202E\u206F\u200B\u206F\u206E\u206E\u206B\u200B\u206B\u200B\u206E\u206A\u206F\u202A\u206F\u202B\u200E\u206E\u206C\u206A\u200F\u206F\u202C\u200D\u202C\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u206C\u200B\u200E\u206E\u202D\u200C\u202E\u202A\u200E\u202E\u202E\u200E\u206B\u200C\u206E\u202A\u200F\u206B\u206F\u206E\u202D\u200B\u206C\u206F\u202A\u202E\u206E\u200B\u206F\u200E\u206B\u200C\u202D\u202D\u202A\u206C\u206D\u206B\u206E\u206B\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u200D\u206F\u202B\u202C\u202C\u200F\u202B\u206A\u206F\u202C\u206A\u200D\u202A\u200E\u202C\u200E\u206C\u200F\u202A\u206E\u206D\u200C\u200F\u200D\u202A\u206E\u202B\u202E\u206A\u202B\u206F\u202B\u200E\u200F\u202E\u202D\u206F\u202D\u206F\u202C\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SpellCooldown;

		private enum MoveType
		{
			Shade,
			AgelessDream,
			SeepingMiasma,
			HeartBlossoms,
			SongoftheNightSparrow,
			UnexplainedFever,
			DevilsCodex,
			ViolinSolo,
			SinoftheBlackHorse,
			WheelofMisfortune,
			ManipulationofFate,
			DreamExpress,
			TrueFullMoon,
			DoNothing
		}
	}
}
