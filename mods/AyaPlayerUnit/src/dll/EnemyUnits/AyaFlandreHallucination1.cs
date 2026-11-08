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
	[EntityLogic(typeof(AyaFlandreHallucination1Def))]
	public sealed class AyaFlandreHallucination1 : EnemyUnit
	{
		private AyaFlandreHallucination1.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			if (AyaFlandreHallucination1.\u202A\u202D\u206A\u206A\u206A\u206B\u206F\u200C\u202A\u202B\u202C\u200C\u202C\u200B\u206F\u202B\u200D\u202E\u206C\u202B\u200F\u200E\u202D\u206B\u202A\u200D\u202E\u202E\u200D\u200E\u206D\u206C\u206C\u206B\u202C\u206B\u206F\u200F\u200D\u200E\u202E(battle) is FlandrePlayerUnitDef.FlandrePlayerUnit)
			{
				for (;;)
				{
					IL_0010:
					int num = 745802414;
					for (;;)
					{
						int num2 = num;
						switch ((~num2 + (-1304380506 - -2072178259 + -1316030169 * 2011533449)) % 6)
						{
						case 1:
						{
							GameRunController gameRunController = AyaFlandreHallucination1.\u202E\u200F\u206C\u202B\u206B\u200F\u206C\u202D\u200B\u206B\u206E\u206D\u206E\u200D\u206E\u206D\u200E\u202E\u200B\u206F\u202D\u202B\u202C\u206E\u206E\u200E\u200B\u206A\u202D\u200D\u200E\u202C\u202E\u200F\u202A\u200D\u200E\u202C\u206B\u206C\u202E(battle);
							num = ((!(((gameRunController != null) ? AyaFlandreHallucination1.\u202A\u202B\u202A\u200F\u202D\u200C\u202A\u206E\u202A\u202D\u206E\u202E\u202E\u206B\u200C\u206F\u200E\u206D\u200B\u202C\u202E\u200F\u202B\u202D\u206B\u206D\u202E\u206E\u206B\u206B\u206F\u202D\u206A\u206E\u202B\u202D\u206C\u200D\u200F\u202C\u202E(gameRunController) : null) is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination)) ? 746089390 : 1508477243);
							continue;
						}
						case 2:
							goto IL_0080;
						case 3:
							goto IL_0010;
						case 4:
						{
							GameRunController gameRunController2 = AyaFlandreHallucination1.\u202E\u200F\u206C\u202B\u206B\u200F\u206C\u202D\u200B\u206B\u206E\u206D\u206E\u200D\u206E\u206D\u200E\u202E\u200B\u206F\u202D\u202B\u202C\u206E\u206E\u200E\u200B\u206A\u202D\u200D\u200E\u202C\u202E\u200F\u202A\u200D\u200E\u202C\u206B\u206C\u202E(battle);
							if (gameRunController2 == null || AyaFlandreHallucination1.\u200D\u206A\u206D\u206E\u200C\u202A\u200F\u206F\u200B\u200B\u206D\u202D\u200B\u206E\u206D\u206C\u202E\u206A\u206D\u202B\u200C\u200B\u206E\u202E\u206E\u206E\u206C\u200B\u202C\u202D\u200F\u200F\u206A\u200C\u206A\u200E\u200E\u200F\u206F\u206D\u202E(AyaFlandreHallucination1.\u206E\u206B\u202E\u202A\u202E\u206A\u200F\u206C\u202C\u200E\u206A\u200C\u206B\u206D\u202B\u202B\u200B\u202E\u200B\u202D\u206B\u202B\u200C\u200B\u200E\u202E\u202E\u200F\u206B\u206D\u206F\u200F\u200C\u206B\u200D\u202E\u206B\u200B\u202C\u202A\u202E(gameRunController2)) != StationType.EliteEnemy)
							{
								num = 746089390;
								continue;
							}
							goto IL_0080;
						}
						case 5:
							goto IL_00BE;
						}
						return;
						IL_0080:
						this.Next = this.randoms.Sample(base.EnemyMoveRng);
						base.ReactBattleEvent<GameEventArgs>(AyaFlandreHallucination1.\u200B\u202E\u206D\u206A\u200F\u200D\u206A\u200B\u202A\u202E\u206B\u202B\u206C\u206A\u200C\u202C\u200F\u206A\u200F\u200C\u206C\u200C\u202E\u200C\u206A\u200B\u206C\u202C\u200B\u200E\u202B\u202E\u202E\u206F\u202A\u202D\u200B\u206F\u206B\u206A\u202E(AyaFlandreHallucination1.\u202E\u202D\u206C\u202E\u202C\u200B\u200E\u202D\u206F\u206C\u202D\u200C\u200C\u202E\u206B\u202A\u200C\u202E\u202A\u200F\u202C\u206F\u202B\u206E\u206A\u200B\u200B\u206D\u202A\u200B\u200F\u206A\u202A\u200E\u200E\u206F\u200F\u202E\u206D\u206B\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = 2077885791;
					}
				}
				return;
			}
			IL_00BE:
			throw AyaFlandreHallucination1.\u202E\u200B\u206A\u200F\u202C\u200B\u202D\u200B\u206C\u206D\u206B\u200C\u200F\u206B\u206D\u200D\u202D\u206A\u206C\u202E\u202A\u202D\u202A\u200B\u202E\u206D\u202A\u206F\u202E\u200E\u206B\u206F\u200B\u202A\u206B\u206C\u202A\u200B\u200D\u202A\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaFlandreHallucination1.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> ShoulderActions()
		{
			AyaFlandreHallucination1.<ShoulderActions>d__6 <ShoulderActions>d__ = new AyaFlandreHallucination1.<ShoulderActions>d__6(-2);
			<ShoulderActions>d__.<>4__this = this;
			return <ShoulderActions>d__;
		}

		private IEnumerable<BattleAction> ElbowActions()
		{
			AyaFlandreHallucination1.<ElbowActions>d__7 <ElbowActions>d__ = new AyaFlandreHallucination1.<ElbowActions>d__7(-2);
			<ElbowActions>d__.<>4__this = this;
			return <ElbowActions>d__;
		}

		private IEnumerable<BattleAction> HandActions()
		{
			AyaFlandreHallucination1.<HandActions>d__8 <HandActions>d__ = new AyaFlandreHallucination1.<HandActions>d__8(-2);
			<HandActions>d__.<>4__this = this;
			return <HandActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaFlandreHallucination1.<GetTurnMoves>d__9 <GetTurnMoves>d__ = new AyaFlandreHallucination1.<GetTurnMoves>d__9(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = this.randoms.Without(this.Next).Sample(base.EnemyMoveRng);
		}

		static PlayerUnit \u202A\u202D\u206A\u206A\u206A\u206B\u206F\u200C\u202A\u202B\u202C\u200C\u202C\u200B\u206F\u202B\u200D\u202E\u206C\u202B\u200F\u200E\u202D\u206B\u202A\u200D\u202E\u202E\u200D\u200E\u206D\u206C\u206C\u206B\u202C\u206B\u206F\u200F\u200D\u200E\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameRunController \u202E\u200F\u206C\u202B\u206B\u200F\u206C\u202D\u200B\u206B\u206E\u206D\u206E\u200D\u206E\u206D\u200E\u202E\u200B\u206F\u202D\u202B\u202C\u206E\u206E\u200E\u200B\u206A\u202D\u200D\u200E\u202C\u202E\u200F\u202A\u200D\u200E\u202C\u206B\u206C\u202E(BattleController A_0)
		{
			return A_0.GameRun;
		}

		static Stage \u202A\u202B\u202A\u200F\u202D\u200C\u202A\u206E\u202A\u202D\u206E\u202E\u202E\u206B\u200C\u206F\u200E\u206D\u200B\u202C\u202E\u200F\u202B\u202D\u206B\u206D\u202E\u206E\u206B\u206B\u206F\u202D\u206A\u206E\u202B\u202D\u206C\u200D\u200F\u202C\u202E(GameRunController A_0)
		{
			return A_0.CurrentStage;
		}

		static Station \u206E\u206B\u202E\u202A\u202E\u206A\u200F\u206C\u202C\u200E\u206A\u200C\u206B\u206D\u202B\u202B\u200B\u202E\u200B\u202D\u206B\u202B\u200C\u200B\u200E\u202E\u202E\u200F\u206B\u206D\u206F\u200F\u200C\u206B\u200D\u202E\u206B\u200B\u202C\u202A\u202E(GameRunController A_0)
		{
			return A_0.CurrentStation;
		}

		static StationType \u200D\u206A\u206D\u206E\u200C\u202A\u200F\u206F\u200B\u200B\u206D\u202D\u200B\u206E\u206D\u206C\u202E\u206A\u206D\u202B\u200C\u200B\u206E\u202E\u206E\u206E\u206C\u200B\u202C\u202D\u200F\u200F\u206A\u200C\u206A\u200E\u200E\u200F\u206F\u206D\u202E(Station A_0)
		{
			return A_0.Type;
		}

		static NullReferenceException \u202E\u200B\u206A\u200F\u202C\u200B\u202D\u200B\u206C\u206D\u206B\u200C\u200F\u206B\u206D\u200D\u202D\u206A\u206C\u202E\u202A\u202D\u202A\u200B\u202E\u206D\u202A\u206F\u202E\u200E\u206B\u206F\u200B\u202A\u206B\u206C\u202A\u200B\u200D\u202A\u202E()
		{
			return new NullReferenceException();
		}

		static BattleController \u202E\u202D\u206C\u202E\u202C\u200B\u200E\u202D\u206F\u206C\u202D\u200C\u200C\u202E\u206B\u202A\u200C\u202E\u202A\u200F\u202C\u206F\u202B\u206E\u206A\u200B\u200B\u206D\u202A\u200B\u200F\u206A\u202A\u200E\u200E\u206F\u200F\u202E\u206D\u206B\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u200B\u202E\u206D\u206A\u200F\u200D\u206A\u200B\u202A\u202E\u206B\u202B\u206C\u206A\u200C\u202C\u200F\u206A\u200F\u200C\u206C\u200C\u202E\u200C\u206A\u200B\u206C\u202C\u200B\u200E\u202B\u202E\u202E\u206F\u202A\u202D\u200B\u206F\u206B\u206A\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private readonly RepeatableRandomPool<AyaFlandreHallucination1.MoveType> randoms = new RepeatableRandomPool<AyaFlandreHallucination1.MoveType>
		{
			{
				AyaFlandreHallucination1.MoveType.Shoulder,
				1f
			},
			{
				AyaFlandreHallucination1.MoveType.Elbow,
				1f
			},
			{
				AyaFlandreHallucination1.MoveType.Hand,
				1f
			}
		};

		private enum MoveType
		{
			Shoulder,
			Elbow,
			Hand
		}
	}
}
