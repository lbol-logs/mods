using System;
using System.Collections.Generic;
using AyaShameimaru.PlayerUnits;
using AyaShameimaru.Stages;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Randoms;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaFlandreHallucination3Def))]
	public sealed class AyaFlandreHallucination3 : EnemyUnit
	{
		private AyaFlandreHallucination3.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			if (AyaFlandreHallucination3.\u206B\u200F\u206F\u202C\u206B\u202B\u202B\u200E\u200D\u206A\u206C\u200C\u206B\u202D\u202C\u202A\u202A\u200C\u206F\u202D\u202A\u200C\u206C\u200F\u202D\u200F\u200B\u206E\u202E\u206C\u200C\u202C\u200E\u206C\u200C\u202E\u206D\u206B\u200C\u206D\u202E(battle) is FlandrePlayerUnitDef.FlandrePlayerUnit)
			{
				for (;;)
				{
					IL_0010:
					int num = -1699533766;
					for (;;)
					{
						int num2 = num;
						switch ((~((num2 - (-986953071 ^ ~1454113802)) * -101756609) + -1038651682) % 6)
						{
						case 1:
						{
							GameRunController gameRunController = AyaFlandreHallucination3.\u202A\u200B\u202B\u200E\u200B\u200C\u206C\u200E\u206D\u206E\u206B\u206F\u200D\u202E\u202B\u206C\u202A\u202B\u200E\u202B\u200F\u206B\u202E\u200E\u206F\u206C\u206A\u206F\u206C\u202B\u202A\u200E\u200B\u200C\u206D\u202D\u206E\u202B\u206A\u206A\u202E(battle);
							num = ((!(((gameRunController != null) ? AyaFlandreHallucination3.\u206E\u202D\u202C\u200F\u200F\u200F\u206D\u202E\u202E\u202B\u206E\u200E\u200E\u200B\u202E\u202B\u200F\u202D\u202D\u206E\u206D\u200D\u202B\u200C\u206E\u200E\u200B\u202A\u206E\u206D\u200C\u200F\u206F\u200F\u202E\u202E\u202B\u202E\u202E\u202D\u202E(gameRunController) : null) is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination)) ? (-1331074157) : (-1958322433));
							continue;
						}
						case 2:
						{
							GameRunController gameRunController2 = AyaFlandreHallucination3.\u202A\u200B\u202B\u200E\u200B\u200C\u206C\u200E\u206D\u206E\u206B\u206F\u200D\u202E\u202B\u206C\u202A\u202B\u200E\u202B\u200F\u206B\u202E\u200E\u206F\u206C\u206A\u206F\u206C\u202B\u202A\u200E\u200B\u200C\u206D\u202D\u206E\u202B\u206A\u206A\u202E(battle);
							if (gameRunController2 == null || AyaFlandreHallucination3.\u200E\u200F\u206F\u200F\u202A\u206B\u200C\u200D\u202B\u202A\u200C\u206A\u206B\u200C\u202E\u202E\u200E\u206F\u206B\u202D\u206B\u200D\u200B\u206E\u200D\u200D\u202E\u206A\u200D\u200E\u200E\u206F\u206E\u200F\u200D\u206F\u200C\u206F\u206A\u202D\u202E(AyaFlandreHallucination3.\u206B\u206A\u200E\u202E\u200F\u200D\u200B\u200C\u206D\u202B\u202A\u206A\u206A\u206C\u202A\u206C\u206F\u206A\u200E\u200F\u206A\u206C\u206F\u200C\u206F\u206D\u206A\u200E\u202D\u200C\u206C\u200D\u206B\u200D\u206B\u202E\u202B\u202C\u200D\u206B\u202E(gameRunController2)) != StationType.EliteEnemy)
							{
								num = -1331074157;
								continue;
							}
							goto IL_0057;
						}
						case 3:
							goto IL_0057;
						case 4:
							goto IL_00BB;
						case 5:
							goto IL_0010;
						}
						return;
						IL_0057:
						this.Next = this.randoms.Sample(base.EnemyMoveRng);
						base.ReactBattleEvent<GameEventArgs>(AyaFlandreHallucination3.\u200E\u200C\u206D\u206C\u200F\u206A\u202B\u202D\u206A\u200B\u202C\u206D\u202E\u200D\u200F\u200E\u202E\u202E\u200C\u200F\u202D\u202A\u206E\u202E\u206F\u200B\u206E\u206C\u200E\u206B\u200E\u206C\u206E\u200D\u206E\u200C\u202D\u200E\u200D\u200F\u202E(AyaFlandreHallucination3.\u202A\u200E\u202B\u206E\u202B\u202C\u202A\u206F\u200C\u206E\u202D\u200F\u200F\u200B\u202E\u200F\u206F\u202B\u206A\u206F\u202A\u202D\u202A\u206B\u202C\u200E\u202C\u200D\u200D\u206C\u200F\u200E\u202C\u206A\u202B\u206B\u200E\u206F\u206E\u200C\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = 266813783;
					}
				}
				return;
			}
			IL_00BB:
			throw AyaFlandreHallucination3.\u206A\u200E\u200D\u200C\u200E\u200C\u206A\u200D\u206B\u202D\u200E\u206D\u206A\u206A\u200F\u206D\u202A\u206F\u206E\u206A\u206C\u206E\u202C\u206C\u200E\u206D\u206D\u202D\u206B\u202E\u200E\u200E\u206E\u202D\u206C\u202C\u200D\u200F\u206C\u206D\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaFlandreHallucination3.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> ThighActions()
		{
			AyaFlandreHallucination3.<ThighActions>d__6 <ThighActions>d__ = new AyaFlandreHallucination3.<ThighActions>d__6(-2);
			<ThighActions>d__.<>4__this = this;
			return <ThighActions>d__;
		}

		private IEnumerable<BattleAction> CalfActions()
		{
			AyaFlandreHallucination3.<CalfActions>d__7 <CalfActions>d__ = new AyaFlandreHallucination3.<CalfActions>d__7(-2);
			<CalfActions>d__.<>4__this = this;
			return <CalfActions>d__;
		}

		private IEnumerable<BattleAction> FeetActions()
		{
			AyaFlandreHallucination3.<FeetActions>d__8 <FeetActions>d__ = new AyaFlandreHallucination3.<FeetActions>d__8(-2);
			<FeetActions>d__.<>4__this = this;
			return <FeetActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaFlandreHallucination3.<GetTurnMoves>d__9 <GetTurnMoves>d__ = new AyaFlandreHallucination3.<GetTurnMoves>d__9(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = this.randoms.Without(this.Next).Sample(base.EnemyMoveRng);
		}

		static PlayerUnit \u206B\u200F\u206F\u202C\u206B\u202B\u202B\u200E\u200D\u206A\u206C\u200C\u206B\u202D\u202C\u202A\u202A\u200C\u206F\u202D\u202A\u200C\u206C\u200F\u202D\u200F\u200B\u206E\u202E\u206C\u200C\u202C\u200E\u206C\u200C\u202E\u206D\u206B\u200C\u206D\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameRunController \u202A\u200B\u202B\u200E\u200B\u200C\u206C\u200E\u206D\u206E\u206B\u206F\u200D\u202E\u202B\u206C\u202A\u202B\u200E\u202B\u200F\u206B\u202E\u200E\u206F\u206C\u206A\u206F\u206C\u202B\u202A\u200E\u200B\u200C\u206D\u202D\u206E\u202B\u206A\u206A\u202E(BattleController A_0)
		{
			return A_0.GameRun;
		}

		static Stage \u206E\u202D\u202C\u200F\u200F\u200F\u206D\u202E\u202E\u202B\u206E\u200E\u200E\u200B\u202E\u202B\u200F\u202D\u202D\u206E\u206D\u200D\u202B\u200C\u206E\u200E\u200B\u202A\u206E\u206D\u200C\u200F\u206F\u200F\u202E\u202E\u202B\u202E\u202E\u202D\u202E(GameRunController A_0)
		{
			return A_0.CurrentStage;
		}

		static Station \u206B\u206A\u200E\u202E\u200F\u200D\u200B\u200C\u206D\u202B\u202A\u206A\u206A\u206C\u202A\u206C\u206F\u206A\u200E\u200F\u206A\u206C\u206F\u200C\u206F\u206D\u206A\u200E\u202D\u200C\u206C\u200D\u206B\u200D\u206B\u202E\u202B\u202C\u200D\u206B\u202E(GameRunController A_0)
		{
			return A_0.CurrentStation;
		}

		static StationType \u200E\u200F\u206F\u200F\u202A\u206B\u200C\u200D\u202B\u202A\u200C\u206A\u206B\u200C\u202E\u202E\u200E\u206F\u206B\u202D\u206B\u200D\u200B\u206E\u200D\u200D\u202E\u206A\u200D\u200E\u200E\u206F\u206E\u200F\u200D\u206F\u200C\u206F\u206A\u202D\u202E(Station A_0)
		{
			return A_0.Type;
		}

		static NullReferenceException \u206A\u200E\u200D\u200C\u200E\u200C\u206A\u200D\u206B\u202D\u200E\u206D\u206A\u206A\u200F\u206D\u202A\u206F\u206E\u206A\u206C\u206E\u202C\u206C\u200E\u206D\u206D\u202D\u206B\u202E\u200E\u200E\u206E\u202D\u206C\u202C\u200D\u200F\u206C\u206D\u202E()
		{
			return new NullReferenceException();
		}

		static BattleController \u202A\u200E\u202B\u206E\u202B\u202C\u202A\u206F\u200C\u206E\u202D\u200F\u200F\u200B\u202E\u200F\u206F\u202B\u206A\u206F\u202A\u202D\u202A\u206B\u202C\u200E\u202C\u200D\u200D\u206C\u200F\u200E\u202C\u206A\u202B\u206B\u200E\u206F\u206E\u200C\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u200E\u200C\u206D\u206C\u200F\u206A\u202B\u202D\u206A\u200B\u202C\u206D\u202E\u200D\u200F\u200E\u202E\u202E\u200C\u200F\u202D\u202A\u206E\u202E\u206F\u200B\u206E\u206C\u200E\u206B\u200E\u206C\u206E\u200D\u206E\u200C\u202D\u200E\u200D\u200F\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private readonly RepeatableRandomPool<AyaFlandreHallucination3.MoveType> randoms = new RepeatableRandomPool<AyaFlandreHallucination3.MoveType>
		{
			{
				AyaFlandreHallucination3.MoveType.Thigh,
				1f
			},
			{
				AyaFlandreHallucination3.MoveType.Calf,
				1f
			},
			{
				AyaFlandreHallucination3.MoveType.Feet,
				1f
			}
		};

		private enum MoveType
		{
			Thigh,
			Calf,
			Feet
		}
	}
}
