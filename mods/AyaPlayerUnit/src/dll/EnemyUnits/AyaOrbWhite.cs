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
	[EntityLogic(typeof(AyaOrbWhiteDef))]
	public sealed class AyaOrbWhite : EnemyUnit
	{
		private AyaOrbWhite.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbWhite.\u202C\u202A\u202C\u200D\u200D\u206B\u202A\u200F\u202D\u206F\u202C\u200C\u206B\u206B\u202C\u200F\u202C\u200F\u200D\u200D\u206E\u200E\u206B\u200F\u200F\u200E\u200F\u200E\u206B\u200D\u200D\u202E\u200C\u200B\u200C\u200F\u206B\u200F\u200C\u206F\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbWhite.\u200F\u206D\u202E\u202D\u202D\u202D\u202D\u200E\u206B\u202B\u202A\u200E\u206C\u206F\u202D\u206B\u200B\u200D\u202A\u200D\u206D\u206D\u206E\u202E\u202E\u206B\u202C\u206A\u200F\u200E\u200B\u206D\u202E\u202E\u202D\u200E\u202E\u202C\u206B\u206C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			for (;;)
			{
				IL_003C:
				int num = 1733737168;
				for (;;)
				{
					int num2 = num;
					uint num3;
					AyaOrbWhite.MoveType moveType2;
					switch ((num3 = (uint)(-(1594614103 * -1513152481) - -(uint)num2)) % 26U)
					{
					case 0U:
					{
						AyaOrbWhite.MoveType moveType = AyaOrbWhite.MoveType.DoNothing;
						num = (int)((num3 * 2283449590U) ^ 1903752218U);
						continue;
					}
					case 1U:
					{
						AyaOrbWhite.MoveType moveType;
						this.Next = moveType;
						base.ReactBattleEvent<GameEventArgs>(AyaOrbWhite.\u206B\u202B\u202D\u200F\u200B\u202B\u200E\u206A\u206C\u206B\u200B\u202E\u200E\u202A\u202A\u206D\u202D\u202C\u206A\u202C\u206C\u200D\u206F\u200B\u200B\u206B\u202B\u202C\u200C\u206A\u206E\u206D\u200D\u206E\u206F\u206C\u200F\u200E\u200E\u202C\u202E(AyaOrbWhite.\u202C\u202A\u202C\u200D\u200D\u206B\u202A\u200F\u202D\u206F\u202C\u200C\u206B\u206B\u202C\u200F\u202C\u200F\u200D\u200D\u206E\u200E\u206B\u200F\u200F\u200E\u200F\u200E\u206B\u200D\u200D\u202E\u200C\u200B\u200C\u200F\u206B\u200F\u200C\u206F\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = -2129600345;
						continue;
					}
					case 2U:
						num = (int)((num3 * 4047397562U) ^ 2300928587U);
						continue;
					case 3U:
						goto IL_026E;
					case 4U:
						goto IL_003C;
					case 5U:
						goto IL_019E;
					case 6U:
						num = (int)((num3 * 4005385825U) ^ 2684521683U);
						continue;
					case 7U:
						num = (int)((ayaBossZUN.restPool.Contains(AyaOrbWhite.\u202D\u200D\u206D\u202C\u200C\u200B\u206C\u202C\u202E\u206D\u200D\u202B\u200E\u202B\u200B\u202D\u202C\u206B\u206D\u200F\u200D\u206C\u206B\u202E\u202D\u206B\u202B\u202C\u202B\u206C\u200D\u206B\u202C\u200B\u200B\u200F\u200C\u202B\u206A\u200F\u202E(this)) ? 1630437581U : 1654265131U) ^ (num3 * 45566028U));
						continue;
					case 8U:
					{
						AyaOrbWhite.MoveType moveType = moveType2;
						num = 2015705246;
						continue;
					}
					case 9U:
						num = (int)((num3 * 1084172593U) ^ 849184442U);
						continue;
					case 10U:
						goto IL_02B5;
					case 11U:
						goto IL_0192;
					case 13U:
						goto IL_0132;
					case 14U:
						goto IL_0286;
					case 15U:
						num = (int)((num3 * 1432666943U) ^ 88550956U);
						continue;
					case 16U:
						goto IL_027A;
					case 17U:
						num = (int)((num3 * 2144366201U) ^ 3019613141U);
						continue;
					case 18U:
						goto IL_011A;
					case 19U:
						goto IL_0292;
					case 20U:
						num = (int)((num3 * 1656564576U) ^ 1773432899U);
						continue;
					case 21U:
						goto IL_00CB;
					case 22U:
						num = (int)((num3 * 752923490U) ^ 403750295U);
						continue;
					case 23U:
						num = (int)((num3 * 57162638U) ^ 1038026896U);
						continue;
					case 24U:
						switch (AyaOrbWhite.\u200C\u206B\u200E\u200E\u206D\u202B\u206D\u200E\u200F\u206A\u206A\u206F\u200E\u206A\u200C\u200E\u206E\u206C\u202E\u206F\u200B\u206B\u206A\u202B\u206B\u206B\u202E\u202B\u200C\u202D\u200E\u200D\u206E\u202A\u202E\u200F\u202E\u206D\u200E\u206D\u202E(base.EnemyMoveRng, 0, 8))
						{
						case 0:
							goto IL_019E;
						case 1:
							goto IL_027A;
						case 2:
							goto IL_011A;
						case 3:
							goto IL_0286;
						case 4:
							goto IL_02B5;
						case 5:
							goto IL_026E;
						case 6:
							goto IL_0132;
						case 7:
							goto IL_00CB;
						case 8:
							goto IL_0192;
						default:
							num = -1339046888;
							continue;
						}
						break;
					case 25U:
						num = (int)(((ayaBossZUN == null) ? 3827733637U : 3295987528U) ^ (num3 * 454153102U));
						continue;
					}
					goto Block_3;
					IL_00CB:
					moveType2 = AyaOrbWhite.MoveType.NoctilucaesNest;
					num = -977429283;
					continue;
					IL_011A:
					moveType2 = AyaOrbWhite.MoveType.EntrenchBody;
					num = -1208053437;
					continue;
					IL_0132:
					moveType2 = AyaOrbWhite.MoveType.TrumpetSolo;
					num = -1510747438;
					continue;
					IL_0192:
					moveType2 = AyaOrbWhite.MoveType.TheFallingMoonRabbit;
					num = 1678545242;
					continue;
					IL_019E:
					moveType2 = AyaOrbWhite.MoveType.HeartExcerptSlash;
					num = -1208053437;
					continue;
					IL_026E:
					moveType2 = AyaOrbWhite.MoveType.GatherFaith;
					num = -1731660013;
					continue;
					IL_027A:
					moveType2 = AyaOrbWhite.MoveType.SuperspeedFlier;
					num = 1495586081;
					continue;
					IL_0286:
					moveType2 = AyaOrbWhite.MoveType.PurifytheLand;
					num = -1208053437;
					continue;
					IL_02B5:
					moveType2 = AyaOrbWhite.MoveType.Tranquility;
					num = -1816194791;
				}
			}
			Block_3:
			return;
			IL_0292:
			throw AyaOrbWhite.\u200C\u206C\u206D\u200B\u200D\u206C\u206F\u200F\u206E\u202B\u200E\u202E\u206D\u202D\u206D\u200D\u206F\u206D\u200F\u202C\u200B\u200B\u200C\u206A\u202B\u200E\u200D\u200D\u200D\u200F\u206C\u206E\u206D\u202E\u200E\u206E\u200E\u200F\u202C\u202A\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbWhite.<OnBattleStarted>d__6 <OnBattleStarted>d__ = new AyaOrbWhite.<OnBattleStarted>d__6(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> HeartExcerptSlash()
		{
			AyaOrbWhite.<HeartExcerptSlash>d__7 <HeartExcerptSlash>d__ = new AyaOrbWhite.<HeartExcerptSlash>d__7(-2);
			<HeartExcerptSlash>d__.<>4__this = this;
			return <HeartExcerptSlash>d__;
		}

		private IEnumerable<BattleAction> EntrenchBody()
		{
			AyaOrbWhite.<EntrenchBody>d__8 <EntrenchBody>d__ = new AyaOrbWhite.<EntrenchBody>d__8(-2);
			<EntrenchBody>d__.<>4__this = this;
			return <EntrenchBody>d__;
		}

		private IEnumerable<BattleAction> PurifytheLand()
		{
			AyaOrbWhite.<PurifytheLand>d__9 <PurifytheLand>d__ = new AyaOrbWhite.<PurifytheLand>d__9(-2);
			<PurifytheLand>d__.<>4__this = this;
			return <PurifytheLand>d__;
		}

		private IEnumerable<BattleAction> Tranquility()
		{
			AyaOrbWhite.<Tranquility>d__10 <Tranquility>d__ = new AyaOrbWhite.<Tranquility>d__10(-2);
			<Tranquility>d__.<>4__this = this;
			return <Tranquility>d__;
		}

		private IEnumerable<BattleAction> GatherFaith()
		{
			AyaOrbWhite.<GatherFaith>d__11 <GatherFaith>d__ = new AyaOrbWhite.<GatherFaith>d__11(-2);
			<GatherFaith>d__.<>4__this = this;
			return <GatherFaith>d__;
		}

		private IEnumerable<BattleAction> TrumpetSolo()
		{
			AyaOrbWhite.<TrumpetSolo>d__12 <TrumpetSolo>d__ = new AyaOrbWhite.<TrumpetSolo>d__12(-2);
			<TrumpetSolo>d__.<>4__this = this;
			return <TrumpetSolo>d__;
		}

		private IEnumerable<BattleAction> NoctilucaesNest()
		{
			AyaOrbWhite.<NoctilucaesNest>d__13 <NoctilucaesNest>d__ = new AyaOrbWhite.<NoctilucaesNest>d__13(-2);
			<NoctilucaesNest>d__.<>4__this = this;
			return <NoctilucaesNest>d__;
		}

		private IEnumerable<BattleAction> TheFallingMoonRabbit()
		{
			AyaOrbWhite.<TheFallingMoonRabbit>d__14 <TheFallingMoonRabbit>d__ = new AyaOrbWhite.<TheFallingMoonRabbit>d__14(-2);
			<TheFallingMoonRabbit>d__.<>4__this = this;
			return <TheFallingMoonRabbit>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbWhite.<DoNothingActions>d__15 <DoNothingActions>d__ = new AyaOrbWhite.<DoNothingActions>d__15(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbWhite.<GetTurnMoves>d__16 <GetTurnMoves>d__ = new AyaOrbWhite.<GetTurnMoves>d__16(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			for (;;)
			{
				IL_000E:
				int num = 1214189726;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(-(uint)num2))) % 35U)
					{
					case 0U:
						return;
					case 1U:
					{
						BattleController battleController = AyaOrbWhite.\u202C\u202A\u202C\u200D\u200D\u206B\u202A\u200F\u202D\u206F\u202C\u200C\u206B\u206B\u202C\u200F\u202C\u200F\u200D\u200D\u206E\u200E\u206B\u200F\u200F\u200E\u200F\u200E\u206B\u200D\u200D\u202E\u200C\u200B\u200C\u200F\u206B\u200F\u200C\u206F\u202E(this);
						object obj;
						if (battleController == null)
						{
							obj = null;
						}
						else
						{
							obj = AyaOrbWhite.\u200F\u206D\u202E\u202D\u202D\u202D\u202D\u200E\u206B\u202B\u202A\u200E\u206C\u206F\u202D\u206B\u200B\u200D\u202A\u200D\u206D\u206D\u206E\u202E\u202E\u206B\u202C\u206A\u200F\u200E\u200B\u206D\u202E\u202E\u202D\u200E\u202E\u202C\u206B\u206C\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
						}
						AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
						num = 1685134288;
						continue;
					}
					case 2U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)(((!ayaBossZUN.restPool.Contains(AyaOrbWhite.\u202D\u200D\u206D\u202C\u200C\u200B\u206C\u202C\u202E\u206D\u200D\u202B\u200E\u202B\u200B\u202D\u202C\u206B\u206D\u200F\u200D\u206C\u206B\u202E\u202D\u206B\u202B\u202C\u202B\u206C\u200D\u206B\u202C\u200B\u200B\u200F\u200C\u202B\u206A\u200F\u202E(this))) ? 2001415059U : 1102881442U) ^ (num3 * 2840334868U));
						continue;
					}
					case 3U:
						this.Next = AyaOrbWhite.MoveType.PurifytheLand;
						num = (int)((num3 * 433524867U) ^ 28105250U);
						continue;
					case 4U:
						num = (int)(((this.SpellCooldown > 0) ? 2140989217U : 747811479U) ^ (num3 * 229181983U));
						continue;
					case 5U:
						this.Next = AyaOrbWhite.MoveType.HeartExcerptSlash;
						num = (int)((num3 * 1140673591U) ^ 732901288U);
						continue;
					case 6U:
						this.Next = AyaOrbWhite.MoveType.GatherFaith;
						num = (int)((num3 * 2969075925U) ^ 2120229780U);
						continue;
					case 7U:
						return;
					case 8U:
						goto IL_02B8;
					case 9U:
						switch (AyaOrbWhite.\u200C\u206B\u200E\u200E\u206D\u202B\u206D\u200E\u200F\u206A\u206A\u206F\u200E\u206A\u200C\u200E\u206E\u206C\u202E\u206F\u200B\u206B\u206A\u202B\u206B\u206B\u202E\u202B\u200C\u202D\u200E\u200D\u206E\u202A\u202E\u200F\u202E\u206D\u200E\u206D\u202E(base.EnemyMoveRng, 0, 8))
						{
						case 0:
							goto IL_0240;
						case 1:
							goto IL_00CF;
						case 2:
							goto IL_02B8;
						case 3:
							goto IL_01AC;
						case 4:
							goto IL_02D5;
						case 5:
							goto IL_026F;
						case 6:
							goto IL_0325;
						case 7:
							goto IL_0429;
						case 8:
							goto IL_00B2;
						default:
							num = 1546181197;
							continue;
						}
						break;
					case 10U:
						goto IL_02D5;
					case 11U:
						goto IL_000E;
					case 12U:
						return;
					case 13U:
						this.Next = AyaOrbWhite.MoveType.TheFallingMoonRabbit;
						num = (int)((num3 * 1542285331U) ^ 1144291130U);
						continue;
					case 14U:
						return;
					case 15U:
						this.Next = AyaOrbWhite.MoveType.TrumpetSolo;
						num = (int)((num3 * 2176543554U) ^ 3912973567U);
						continue;
					case 16U:
						goto IL_00CF;
					case 17U:
						goto IL_0325;
					case 18U:
						goto IL_01AC;
					case 19U:
						this.Next = AyaOrbWhite.MoveType.DoNothing;
						num = (int)((num3 * 279033595U) ^ 3329906590U);
						continue;
					case 20U:
						goto IL_00B2;
					case 21U:
						this.Next = AyaOrbWhite.MoveType.EntrenchBody;
						num = (int)((num3 * 1681494796U) ^ 1316658452U);
						continue;
					case 22U:
						num = (int)((num3 * 2309952568U) ^ 3653275511U);
						continue;
					case 23U:
						return;
					case 24U:
						goto IL_02F2;
					case 25U:
						goto IL_026F;
					case 26U:
						return;
					case 27U:
						this.Next = AyaOrbWhite.MoveType.NoctilucaesNest;
						num = (int)((num3 * 1903454891U) ^ 2749674650U);
						continue;
					case 28U:
						goto IL_0179;
					case 29U:
						return;
					case 30U:
						return;
					case 31U:
						goto IL_0240;
					case 33U:
					{
						AyaBossZUNDef.AyaBossZUN ayaBossZUN;
						num = (int)(((ayaBossZUN == null) ? 2937740783U : 2520064827U) ^ (num3 * 3448901358U));
						continue;
					}
					case 34U:
						goto IL_0429;
					}
					goto Block_1;
					IL_00B2:
					num = ((this.Next != AyaOrbWhite.MoveType.TheFallingMoonRabbit) ? 467453074 : 1381459599);
					continue;
					IL_00CF:
					num = ((this.Next == AyaOrbWhite.MoveType.SuperspeedFlier) ? 1381459599 : 585086663);
					continue;
					IL_01AC:
					num = ((this.Next != AyaOrbWhite.MoveType.PurifytheLand) ? 1111829078 : 1381459599);
					continue;
					IL_0240:
					num = ((this.Next != AyaOrbWhite.MoveType.HeartExcerptSlash) ? 1229286175 : 1381459599);
					continue;
					IL_026F:
					num = ((this.Next == AyaOrbWhite.MoveType.GatherFaith) ? 1381459599 : 631802576);
					continue;
					IL_02B8:
					num = ((this.Next == AyaOrbWhite.MoveType.EntrenchBody) ? 1381459599 : 2118706891);
					continue;
					IL_02D5:
					num = ((this.Next == AyaOrbWhite.MoveType.Tranquility) ? 1381459599 : 956512854);
					continue;
					IL_0325:
					num = ((this.Next == AyaOrbWhite.MoveType.TrumpetSolo) ? 1381459599 : 1655669625);
					continue;
					IL_0429:
					num = ((this.Next != AyaOrbWhite.MoveType.NoctilucaesNest) ? 1898153487 : 1381459599);
				}
			}
			Block_1:
			goto IL_0458;
			IL_0179:
			this.Next = AyaOrbWhite.MoveType.SuperspeedFlier;
			return;
			IL_02F2:
			this.Next = AyaOrbWhite.MoveType.Tranquility;
			return;
			IL_0458:
			throw AyaOrbWhite.\u200C\u206C\u206D\u200B\u200D\u206C\u206F\u200F\u206E\u202B\u200E\u202E\u206D\u202D\u206D\u200D\u206F\u206D\u200F\u202C\u200B\u200B\u200C\u206A\u202B\u200E\u200D\u200D\u200D\u200F\u206C\u206E\u206D\u202E\u200E\u206E\u200E\u200F\u202C\u202A\u202E();
		}

		static BattleController \u202C\u202A\u202C\u200D\u200D\u206B\u202A\u200F\u202D\u206F\u202C\u200C\u206B\u206B\u202C\u200F\u202C\u200F\u200D\u200D\u206E\u200E\u206B\u200F\u200F\u200E\u200F\u200E\u206B\u200D\u200D\u202E\u200C\u200B\u200C\u200F\u206B\u200F\u200C\u206F\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u200F\u206D\u202E\u202D\u202D\u202D\u202D\u200E\u206B\u202B\u202A\u200E\u206C\u206F\u202D\u206B\u200B\u200D\u202A\u200D\u206D\u206D\u206E\u202E\u202E\u206B\u202C\u206A\u200F\u200E\u200B\u206D\u202E\u202E\u202D\u200E\u202E\u202C\u206B\u206C\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u202D\u200D\u206D\u202C\u200C\u200B\u206C\u202C\u202E\u206D\u200D\u202B\u200E\u202B\u200B\u202D\u202C\u206B\u206D\u200F\u200D\u206C\u206B\u202E\u202D\u206B\u202B\u202C\u202B\u206C\u200D\u206B\u202C\u200B\u200B\u200F\u200C\u202B\u206A\u200F\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u200C\u206B\u200E\u200E\u206D\u202B\u206D\u200E\u200F\u206A\u206A\u206F\u200E\u206A\u200C\u200E\u206E\u206C\u202E\u206F\u200B\u206B\u206A\u202B\u206B\u206B\u202E\u202B\u200C\u202D\u200E\u200D\u206E\u202A\u202E\u200F\u202E\u206D\u200E\u206D\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u200C\u206C\u206D\u200B\u200D\u206C\u206F\u200F\u206E\u202B\u200E\u202E\u206D\u202D\u206D\u200D\u206F\u206D\u200F\u202C\u200B\u200B\u200C\u206A\u202B\u200E\u200D\u200D\u200D\u200F\u206C\u206E\u206D\u202E\u200E\u206E\u200E\u200F\u202C\u202A\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u206B\u202B\u202D\u200F\u200B\u202B\u200E\u206A\u206C\u206B\u200B\u202E\u200E\u202A\u202A\u206D\u202D\u202C\u206A\u202C\u206C\u200D\u206F\u200B\u200B\u206B\u202B\u202C\u200C\u206A\u206E\u206D\u200D\u206E\u206F\u206C\u200F\u200E\u200E\u202C\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SpellCooldown;

		private enum MoveType
		{
			HeartExcerptSlash,
			SuperspeedFlier,
			EntrenchBody,
			PurifytheLand,
			Tranquility,
			GatherFaith,
			TrumpetSolo,
			NoctilucaesNest,
			TheFallingMoonRabbit,
			DoNothing
		}
	}
}
