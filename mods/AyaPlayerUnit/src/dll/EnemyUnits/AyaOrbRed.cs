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
	[EntityLogic(typeof(AyaOrbRedDef))]
	public sealed class AyaOrbRed : EnemyUnit
	{
		private AyaOrbRed.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			BattleController battleController = AyaOrbRed.\u206F\u200E\u206A\u202E\u202C\u206A\u202C\u202B\u200E\u200F\u202E\u206A\u202E\u202A\u202D\u206E\u200C\u206D\u202B\u200C\u202D\u206C\u200B\u206C\u200F\u206D\u200C\u202E\u206D\u206E\u206C\u200F\u206B\u206D\u202E\u200E\u206F\u202D\u202C\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbRed.\u200B\u200E\u200F\u202B\u206A\u206A\u206B\u200E\u200F\u202E\u206D\u206D\u202D\u202C\u200C\u202B\u200F\u200E\u206A\u206B\u202D\u206B\u202D\u200E\u202A\u206D\u202A\u200F\u200C\u206E\u200D\u202D\u200B\u200D\u206A\u200B\u206F\u206A\u206D\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			if (ayaBossZUN != null)
			{
				goto IL_0042;
			}
			goto IL_017C;
			int num2;
			AyaOrbRed.MoveType moveType2;
			for (;;)
			{
				IL_0047:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(-(uint)((num ^ (-1624336501 * (-2030308593 ^ (660333637 ^ 1458775526)))) - (~1750113857 - 727094079) - (-1567842868 - -1679481853)))) % 31U)
				{
				case 0U:
					num2 = (int)((num3 * 2990232191U) ^ 3174695518U);
					continue;
				case 1U:
					goto IL_02BE;
				case 2U:
					num2 = (int)((num3 * 192186463U) ^ 3395718506U);
					continue;
				case 3U:
					goto IL_013B;
				case 4U:
					num2 = (int)((num3 * 4014996962U) ^ 3836420827U);
					continue;
				case 5U:
					goto IL_02D7;
				case 6U:
					goto IL_0320;
				case 7U:
				{
					AyaOrbRed.MoveType moveType = AyaOrbRed.MoveType.DoNothing;
					num2 = (int)((num3 * 3156697780U) ^ 364385711U);
					continue;
				}
				case 8U:
					goto IL_01CF;
				case 9U:
					num2 = (int)((num3 * 3117324631U) ^ 3665285247U);
					continue;
				case 10U:
					goto IL_0260;
				case 11U:
					goto IL_0308;
				case 12U:
					num2 = (int)((num3 * 3433095637U) ^ 2580593271U);
					continue;
				case 13U:
				{
					AyaOrbRed.MoveType moveType = moveType2;
					num2 = 439072997;
					continue;
				}
				case 14U:
					num2 = (int)((ayaBossZUN.restPool.Contains(AyaOrbRed.\u200E\u202E\u200B\u202E\u202A\u200C\u206F\u202E\u200D\u200B\u202B\u206F\u200B\u200B\u206D\u200C\u200E\u200E\u206E\u206D\u206E\u206C\u200C\u206C\u202B\u202B\u200E\u202C\u206D\u206E\u202C\u200D\u206A\u202E\u202A\u206F\u200B\u202B\u206A\u202E(this)) ? 895282209U : 1419040789U) ^ (num3 * 3767969240U));
					continue;
				case 15U:
					goto IL_0042;
				case 17U:
					goto IL_02CB;
				case 18U:
					num2 = (int)((num3 * 3952489931U) ^ 2554599272U);
					continue;
				case 19U:
					goto IL_028B;
				case 20U:
					num2 = (int)((num3 * 3038927323U) ^ 2777048585U);
					continue;
				case 21U:
					goto IL_017C;
				case 22U:
				{
					AyaOrbRed.MoveType moveType;
					this.Next = moveType;
					num2 = 1367381557;
					continue;
				}
				case 23U:
					goto IL_022A;
				case 24U:
					num2 = (int)((num3 * 4216062321U) ^ 2462671673U);
					continue;
				case 25U:
					goto IL_011C;
				case 26U:
					num2 = (int)((num3 * 4149429346U) ^ 827609186U);
					continue;
				case 27U:
					goto IL_01DB;
				case 28U:
					num2 = (int)((num3 * 2855127802U) ^ 880750200U);
					continue;
				case 29U:
					goto IL_026C;
				case 30U:
					goto IL_0314;
				}
				break;
			}
			goto IL_032D;
			IL_022A:
			throw AyaOrbRed.\u206F\u202A\u200D\u200E\u206B\u206C\u200C\u202C\u200B\u200E\u206D\u200C\u206E\u206E\u200F\u200E\u200D\u202D\u206B\u206C\u206F\u200B\u202A\u202A\u200D\u206D\u200C\u202C\u206A\u200F\u202D\u206F\u202E\u206F\u206D\u200B\u200E\u202C\u200F\u200D\u202E();
			IL_032D:
			base.ReactBattleEvent<GameEventArgs>(AyaOrbRed.\u200C\u202A\u206C\u206C\u206C\u200B\u202A\u200B\u202C\u200C\u202A\u200D\u200B\u206E\u200D\u206F\u206E\u206C\u202C\u200C\u200D\u200D\u200B\u206C\u206C\u206B\u200F\u206F\u200B\u202B\u202B\u202B\u206F\u202D\u206E\u200B\u200F\u206B\u206E\u200C\u202E(AyaOrbRed.\u206F\u200E\u206A\u202E\u202C\u206A\u202C\u202B\u200E\u200F\u202E\u206A\u202E\u202A\u202D\u206E\u200C\u206D\u202B\u200C\u202D\u206C\u200B\u206C\u200F\u206D\u200C\u202E\u206D\u206E\u206C\u200F\u206B\u206D\u202E\u200E\u206F\u202D\u202C\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			return;
			IL_0042:
			num2 = 302810831;
			goto IL_0047;
			IL_011C:
			moveType2 = AyaOrbRed.MoveType.Impatience;
			num2 = 1901529534;
			goto IL_0047;
			IL_013B:
			moveType2 = AyaOrbRed.MoveType.BattleStance;
			num2 = 169499661;
			goto IL_0047;
			IL_017C:
			switch (AyaOrbRed.\u202B\u202E\u200C\u202E\u202E\u206C\u202E\u202B\u202C\u202D\u202E\u206D\u202A\u200C\u206A\u202E\u206F\u202A\u200B\u202E\u200D\u206F\u202C\u202D\u206C\u200D\u202E\u202B\u202E\u200C\u206F\u202B\u200C\u200F\u206E\u202A\u200F\u202A\u206F\u202D\u202E(base.EnemyMoveRng, 0, 12))
			{
			case 0:
				IL_0260:
				moveType2 = AyaOrbRed.MoveType.FullMoonHowl;
				num2 = 451296965;
				goto IL_0047;
			case 1:
				goto IL_011C;
			case 2:
				IL_0314:
				moveType2 = AyaOrbRed.MoveType.PhoenixWingsRise;
				num2 = 1901529534;
				goto IL_0047;
			case 3:
				IL_02CB:
				moveType2 = AyaOrbRed.MoveType.BassofTaiko;
				num2 = 2023461534;
				goto IL_0047;
			case 4:
				goto IL_013B;
			case 5:
				IL_01CF:
				moveType2 = AyaOrbRed.MoveType.StrengthenBody;
				num2 = 1638444695;
				goto IL_0047;
			case 6:
				IL_026C:
				moveType2 = AyaOrbRed.MoveType.OniSpiritBomb;
				num2 = 1901529534;
				goto IL_0047;
			case 7:
				IL_0308:
				moveType2 = AyaOrbRed.MoveType.IndiscriminateIgnition;
				num2 = -1316003358;
				goto IL_0047;
			case 8:
				IL_01DB:
				moveType2 = AyaOrbRed.MoveType.CrimsonEnergyRelease;
				num2 = 1332671308;
				goto IL_0047;
			case 9:
				IL_028B:
				moveType2 = AyaOrbRed.MoveType.KeyboardSolo;
				num2 = 1835921333;
				goto IL_0047;
			case 10:
				IL_02D7:
				moveType2 = AyaOrbRed.MoveType.DreadfulRagingWaves;
				num2 = 1521127239;
				goto IL_0047;
			case 11:
				IL_0320:
				moveType2 = AyaOrbRed.MoveType.BatIncarnation;
				num2 = 1901529534;
				goto IL_0047;
			case 12:
				IL_02BE:
				moveType2 = AyaOrbRed.MoveType.TheImmortalFlame;
				num2 = 1901529534;
				goto IL_0047;
			default:
				num2 = 2084665612;
				goto IL_0047;
			}
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			AyaOrbRed.<OnBattleStarted>d__6 <OnBattleStarted>d__ = new AyaOrbRed.<OnBattleStarted>d__6(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private IEnumerable<BattleAction> FullMoonHowl()
		{
			AyaOrbRed.<FullMoonHowl>d__7 <FullMoonHowl>d__ = new AyaOrbRed.<FullMoonHowl>d__7(-2);
			<FullMoonHowl>d__.<>4__this = this;
			return <FullMoonHowl>d__;
		}

		private IEnumerable<BattleAction> Impatience()
		{
			AyaOrbRed.<Impatience>d__8 <Impatience>d__ = new AyaOrbRed.<Impatience>d__8(-2);
			<Impatience>d__.<>4__this = this;
			return <Impatience>d__;
		}

		private IEnumerable<BattleAction> BassofTaiko()
		{
			AyaOrbRed.<BassofTaiko>d__9 <BassofTaiko>d__ = new AyaOrbRed.<BassofTaiko>d__9(-2);
			<BassofTaiko>d__.<>4__this = this;
			return <BassofTaiko>d__;
		}

		private IEnumerable<BattleAction> BattleStance()
		{
			AyaOrbRed.<BattleStance>d__10 <BattleStance>d__ = new AyaOrbRed.<BattleStance>d__10(-2);
			<BattleStance>d__.<>4__this = this;
			return <BattleStance>d__;
		}

		private IEnumerable<BattleAction> StrengthenBody()
		{
			AyaOrbRed.<StrengthenBody>d__11 <StrengthenBody>d__ = new AyaOrbRed.<StrengthenBody>d__11(-2);
			<StrengthenBody>d__.<>4__this = this;
			return <StrengthenBody>d__;
		}

		private IEnumerable<BattleAction> CrimsonEnergyRelease()
		{
			AyaOrbRed.<CrimsonEnergyRelease>d__12 <CrimsonEnergyRelease>d__ = new AyaOrbRed.<CrimsonEnergyRelease>d__12(-2);
			<CrimsonEnergyRelease>d__.<>4__this = this;
			return <CrimsonEnergyRelease>d__;
		}

		private IEnumerable<BattleAction> KeyboardSolo()
		{
			AyaOrbRed.<KeyboardSolo>d__13 <KeyboardSolo>d__ = new AyaOrbRed.<KeyboardSolo>d__13(-2);
			<KeyboardSolo>d__.<>4__this = this;
			return <KeyboardSolo>d__;
		}

		private IEnumerable<BattleAction> BatIncarnation()
		{
			AyaOrbRed.<BatIncarnation>d__14 <BatIncarnation>d__ = new AyaOrbRed.<BatIncarnation>d__14(-2);
			<BatIncarnation>d__.<>4__this = this;
			return <BatIncarnation>d__;
		}

		private IEnumerable<BattleAction> TheImmortalFlame()
		{
			AyaOrbRed.<TheImmortalFlame>d__15 <TheImmortalFlame>d__ = new AyaOrbRed.<TheImmortalFlame>d__15(-2);
			<TheImmortalFlame>d__.<>4__this = this;
			return <TheImmortalFlame>d__;
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaOrbRed.<DoNothingActions>d__16 <DoNothingActions>d__ = new AyaOrbRed.<DoNothingActions>d__16(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaOrbRed.<GetTurnMoves>d__17 <GetTurnMoves>d__ = new AyaOrbRed.<GetTurnMoves>d__17(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.SpellCooldown--;
			BattleController battleController = AyaOrbRed.\u206F\u200E\u206A\u202E\u202C\u206A\u202C\u202B\u200E\u200F\u202E\u206A\u202E\u202A\u202D\u206E\u200C\u206D\u202B\u200C\u202D\u206C\u200B\u206C\u200F\u206D\u200C\u202E\u206D\u206E\u206C\u200F\u206B\u206D\u202E\u200E\u206F\u202D\u202C\u202E(this);
			object obj;
			if (battleController == null)
			{
				obj = null;
			}
			else
			{
				obj = AyaOrbRed.\u200B\u200E\u200F\u202B\u206A\u206A\u206B\u200E\u200F\u202E\u206D\u206D\u202D\u202C\u200C\u202B\u200F\u200E\u206A\u206B\u202D\u206B\u202D\u200E\u202A\u206D\u202A\u200F\u200C\u206E\u200D\u202D\u200B\u200D\u206A\u200B\u206F\u206A\u206D\u202E(battleController).FirstOrDefault((EnemyUnit e) => e is AyaBossZUNDef.AyaBossZUN);
			}
			AyaBossZUNDef.AyaBossZUN ayaBossZUN = obj as AyaBossZUNDef.AyaBossZUN;
			if (ayaBossZUN != null)
			{
				goto IL_0050;
			}
			goto IL_02E8;
			int num2;
			int num4;
			for (;;)
			{
				IL_0055:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(((-773022206 ^ 1480948665) - (-num + ~(~487500903))) ^ -1108403352)) % 44U)
				{
				case 0U:
					goto IL_04C9;
				case 1U:
					this.Next = AyaOrbRed.MoveType.CrimsonEnergyRelease;
					num2 = (int)((num3 * 1665143207U) ^ 1836337953U);
					continue;
				case 2U:
					goto IL_03EC;
				case 3U:
					goto IL_0500;
				case 4U:
					this.Next = AyaOrbRed.MoveType.OniSpiritBomb;
					num2 = (int)((num3 * 4220075659U) ^ 1923580628U);
					continue;
				case 5U:
					return;
				case 6U:
					return;
				case 7U:
					this.Next = AyaOrbRed.MoveType.StrengthenBody;
					num2 = (int)((num3 * 3758026277U) ^ 3249154826U);
					continue;
				case 8U:
					return;
				case 9U:
					goto IL_022E;
				case 10U:
					switch (num4)
					{
					case 0:
						goto IL_017B;
					case 1:
						goto IL_02CB;
					case 2:
						goto IL_0440;
					case 3:
						goto IL_022E;
					case 4:
						goto IL_0301;
					case 5:
						goto IL_03EC;
					case 6:
						goto IL_033C;
					case 7:
						goto IL_0211;
					case 8:
						goto IL_055A;
					case 9:
						goto IL_0144;
					case 10:
						goto IL_031E;
					case 11:
						goto IL_0422;
					case 12:
						goto IL_04C9;
					default:
						num2 = (int)((num3 * 1451926244U) ^ 2071010355U);
						continue;
					}
					break;
				case 11U:
					num2 = (int)((num3 * 645833454U) ^ 2894867730U);
					continue;
				case 12U:
					this.Next = AyaOrbRed.MoveType.TheImmortalFlame;
					num2 = (int)((num3 * 1543317555U) ^ 1470634371U);
					continue;
				case 13U:
					return;
				case 14U:
					this.Next = AyaOrbRed.MoveType.BassofTaiko;
					num2 = (int)((num3 * 2009625523U) ^ 2643486941U);
					continue;
				case 15U:
					this.Next = AyaOrbRed.MoveType.FullMoonHowl;
					num2 = (int)((num3 * 3233849411U) ^ 4248017176U);
					continue;
				case 16U:
					goto IL_0301;
				case 17U:
					goto IL_02E8;
				case 18U:
					this.Next = AyaOrbRed.MoveType.DoNothing;
					num2 = (int)((num3 * 1933071498U) ^ 1572964662U);
					continue;
				case 19U:
					goto IL_033C;
				case 20U:
					goto IL_0211;
				case 21U:
					goto IL_0144;
				case 22U:
					goto IL_0197;
				case 23U:
					num2 = (int)((ayaBossZUN.restPool.Contains(AyaOrbRed.\u200E\u202E\u200B\u202E\u202A\u200C\u206F\u202E\u200D\u200B\u202B\u206F\u200B\u200B\u206D\u200C\u200E\u200E\u206E\u206D\u206E\u206C\u200C\u206C\u202B\u202B\u200E\u202C\u206D\u206E\u202C\u200D\u206A\u202E\u202A\u206F\u200B\u202B\u206A\u202E(this)) ? 2042662004U : 720469415U) ^ (num3 * 441802374U));
					continue;
				case 24U:
					return;
				case 25U:
					goto IL_017B;
				case 26U:
					goto IL_02CB;
				case 27U:
					goto IL_031E;
				case 28U:
					goto IL_049C;
				case 29U:
					return;
				case 30U:
					goto IL_0440;
				case 31U:
					return;
				case 33U:
					this.Next = AyaOrbRed.MoveType.KeyboardSolo;
					num2 = (int)((num3 * 2105933786U) ^ 3578776382U);
					continue;
				case 34U:
					num2 = (int)(((this.SpellCooldown > 0) ? 1478447965U : 1458208252U) ^ (num3 * 3133624196U));
					continue;
				case 35U:
					return;
				case 36U:
					this.Next = AyaOrbRed.MoveType.IndiscriminateIgnition;
					num2 = (int)((num3 * 1200448060U) ^ 1207476161U);
					continue;
				case 37U:
					goto IL_01F7;
				case 38U:
					goto IL_0050;
				case 39U:
					this.Next = AyaOrbRed.MoveType.DreadfulRagingWaves;
					num2 = (int)((num3 * 3200033469U) ^ 2612932478U);
					continue;
				case 40U:
					goto IL_0422;
				case 41U:
					return;
				case 42U:
					return;
				case 43U:
					goto IL_055A;
				}
				break;
				IL_0144:
				num2 = ((this.Next != AyaOrbRed.MoveType.KeyboardSolo) ? 2007320453 : 1825692245);
				continue;
				IL_017B:
				num2 = ((this.Next != AyaOrbRed.MoveType.FullMoonHowl) ? 1753899787 : 1825692245);
				continue;
				IL_0211:
				num2 = ((this.Next == AyaOrbRed.MoveType.IndiscriminateIgnition) ? 1825692245 : (-2002120776));
				continue;
				IL_022E:
				num2 = ((this.Next != AyaOrbRed.MoveType.BassofTaiko) ? 1817160510 : 1825692245);
				continue;
				IL_02CB:
				num2 = ((this.Next != AyaOrbRed.MoveType.Impatience) ? 470705157 : 1825692245);
				continue;
				IL_0301:
				num2 = ((this.Next != AyaOrbRed.MoveType.BattleStance) ? 658198346 : 1825692245);
				continue;
				IL_031E:
				num2 = ((this.Next == AyaOrbRed.MoveType.DreadfulRagingWaves) ? 1825692245 : 1355167271);
				continue;
				IL_033C:
				num2 = ((this.Next == AyaOrbRed.MoveType.OniSpiritBomb) ? 1825692245 : 830858116);
				continue;
				IL_03EC:
				num2 = ((this.Next != AyaOrbRed.MoveType.StrengthenBody) ? (-1841838501) : 1825692245);
				continue;
				IL_0422:
				num2 = ((this.Next != AyaOrbRed.MoveType.BatIncarnation) ? 1254655819 : 1825692245);
				continue;
				IL_0440:
				num2 = ((this.Next == AyaOrbRed.MoveType.PhoenixWingsRise) ? 1825692245 : 1423867340);
				continue;
				IL_04C9:
				num2 = ((this.Next == AyaOrbRed.MoveType.TheImmortalFlame) ? 1825692245 : 483203222);
				continue;
				IL_055A:
				num2 = ((this.Next == AyaOrbRed.MoveType.CrimsonEnergyRelease) ? 1825692245 : 1669446713);
			}
			goto IL_059D;
			IL_0197:
			this.Next = AyaOrbRed.MoveType.BattleStance;
			return;
			IL_01F7:
			this.Next = AyaOrbRed.MoveType.Impatience;
			return;
			IL_049C:
			this.Next = AyaOrbRed.MoveType.PhoenixWingsRise;
			return;
			IL_0500:
			this.Next = AyaOrbRed.MoveType.BatIncarnation;
			return;
			IL_059D:
			throw AyaOrbRed.\u206F\u202A\u200D\u200E\u206B\u206C\u200C\u202C\u200B\u200E\u206D\u200C\u206E\u206E\u200F\u200E\u200D\u202D\u206B\u206C\u206F\u200B\u202A\u202A\u200D\u206D\u200C\u202C\u206A\u200F\u202D\u206F\u202E\u206F\u206D\u200B\u200E\u202C\u200F\u200D\u202E();
			IL_0050:
			num2 = 1751196711;
			goto IL_0055;
			IL_02E8:
			num4 = AyaOrbRed.\u202B\u202E\u200C\u202E\u202E\u206C\u202E\u202B\u202C\u202D\u202E\u206D\u202A\u200C\u206A\u202E\u206F\u202A\u200B\u202E\u200D\u206F\u202C\u202D\u206C\u200D\u202E\u202B\u202E\u200C\u206F\u202B\u200C\u200F\u206E\u202A\u200F\u202A\u206F\u202D\u202E(base.EnemyMoveRng, 0, 12);
			num2 = 1778264354;
			goto IL_0055;
		}

		static BattleController \u206F\u200E\u206A\u202E\u202C\u206A\u202C\u202B\u200E\u200F\u202E\u206A\u202E\u202A\u202D\u206E\u200C\u206D\u202B\u200C\u202D\u206C\u200B\u206C\u200F\u206D\u200C\u202E\u206D\u206E\u206C\u200F\u206B\u206D\u202E\u200E\u206F\u202D\u202C\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static IEnumerable<EnemyUnit> \u200B\u200E\u200F\u202B\u206A\u206A\u206B\u200E\u200F\u202E\u206D\u206D\u202D\u202C\u200C\u202B\u200F\u200E\u206A\u206B\u202D\u206B\u202D\u200E\u202A\u206D\u202A\u200F\u200C\u206E\u200D\u202D\u200B\u200D\u206A\u200B\u206F\u206A\u206D\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static Type \u200E\u202E\u200B\u202E\u202A\u200C\u206F\u202E\u200D\u200B\u202B\u206F\u200B\u200B\u206D\u200C\u200E\u200E\u206E\u206D\u206E\u206C\u200C\u206C\u202B\u202B\u200E\u202C\u206D\u206E\u202C\u200D\u206A\u202E\u202A\u206F\u200B\u202B\u206A\u202E(object A_0)
		{
			return A_0.GetType();
		}

		static int \u202B\u202E\u200C\u202E\u202E\u206C\u202E\u202B\u202C\u202D\u202E\u206D\u202A\u200C\u206A\u202E\u206F\u202A\u200B\u202E\u200D\u206F\u202C\u202D\u206C\u200D\u202E\u202B\u202E\u200C\u206F\u202B\u200C\u200F\u206E\u202A\u200F\u202A\u206F\u202D\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		static ArgumentOutOfRangeException \u206F\u202A\u200D\u200E\u206B\u206C\u200C\u202C\u200B\u200E\u206D\u200C\u206E\u206E\u200F\u200E\u200D\u202D\u206B\u206C\u206F\u200B\u202A\u202A\u200D\u206D\u200C\u202C\u206A\u200F\u202D\u206F\u202E\u206F\u206D\u200B\u200E\u202C\u200F\u200D\u202E()
		{
			return new ArgumentOutOfRangeException();
		}

		static GameEvent<GameEventArgs> \u200C\u202A\u206C\u206C\u206C\u200B\u202A\u200B\u202C\u200C\u202A\u200D\u200B\u206E\u200D\u206F\u206E\u206C\u202C\u200C\u200D\u200D\u200B\u206C\u206C\u206B\u200F\u206F\u200B\u202B\u202B\u202B\u206F\u202D\u206E\u200B\u200F\u206B\u206E\u200C\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private int SpellCooldown;

		private enum MoveType
		{
			FullMoonHowl,
			Impatience,
			PhoenixWingsRise,
			BassofTaiko,
			BattleStance,
			StrengthenBody,
			OniSpiritBomb,
			IndiscriminateIgnition,
			CrimsonEnergyRelease,
			KeyboardSolo,
			DreadfulRagingWaves,
			BatIncarnation,
			TheImmortalFlame,
			DoNothing
		}
	}
}
