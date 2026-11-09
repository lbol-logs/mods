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
	[EntityLogic(typeof(AyaFlandreHallucination2Def))]
	public sealed class AyaFlandreHallucination2 : EnemyUnit
	{
		private AyaFlandreHallucination2.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			if (AyaFlandreHallucination2.\u206E\u206B\u206B\u206C\u202D\u200E\u202C\u206D\u206B\u200D\u202B\u202C\u202D\u202B\u206E\u206C\u202C\u200E\u202B\u202D\u206D\u200C\u200E\u200B\u202E\u200C\u200D\u206D\u206B\u206F\u200E\u200D\u202C\u200F\u202E\u200E\u202B\u202C\u200F\u206E\u202E(battle) is FlandrePlayerUnitDef.FlandrePlayerUnit)
			{
				for (;;)
				{
					IL_000D:
					int num = -375569282;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-181748659 - -(uint)(num2 ^ -((-1940783192 + -1916304552) * 1884251257) ^ (-1733405863 * -1875803193 * 949083793)))) % 7U)
						{
						case 0U:
							goto IL_0077;
						case 1U:
						{
							GameRunController gameRunController = AyaFlandreHallucination2.\u200B\u206D\u206B\u202D\u200D\u200F\u200B\u202C\u206D\u200B\u206D\u206F\u200F\u202B\u206A\u202B\u200F\u206C\u206C\u206F\u202A\u200C\u200C\u202D\u206B\u206A\u200C\u200B\u202C\u206C\u200F\u202A\u202E\u202A\u200D\u206A\u200E\u206E\u206B\u200E\u202E(battle);
							num = ((!(((gameRunController != null) ? AyaFlandreHallucination2.\u206F\u200E\u202E\u206A\u206E\u202D\u206C\u200C\u200D\u202C\u202C\u202A\u202E\u206C\u202E\u206E\u202B\u202E\u206A\u206A\u206E\u206D\u202D\u206B\u202E\u200E\u202D\u206A\u200B\u202E\u202E\u202E\u202C\u206F\u200E\u200C\u206E\u202B\u200B\u200F\u202E(gameRunController) : null) is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination)) ? (-2060519143) : (-400455930));
							continue;
						}
						case 2U:
						{
							GameRunController gameRunController2 = AyaFlandreHallucination2.\u200B\u206D\u206B\u202D\u200D\u200F\u200B\u202C\u206D\u200B\u206D\u206F\u200F\u202B\u206A\u202B\u200F\u206C\u206C\u206F\u202A\u200C\u200C\u202D\u206B\u206A\u200C\u200B\u202C\u206C\u200F\u202A\u202E\u202A\u200D\u206A\u200E\u206E\u206B\u200E\u202E(battle);
							if (gameRunController2 == null || AyaFlandreHallucination2.\u202C\u202C\u200B\u202B\u206F\u202A\u206E\u200E\u202C\u200F\u206A\u206B\u200D\u200B\u200B\u206C\u206E\u206A\u202C\u202D\u200B\u206F\u206D\u206B\u202C\u206D\u202C\u206F\u202D\u202A\u206E\u206C\u206C\u202A\u206D\u206B\u206E\u206C\u200B\u202C\u202E(AyaFlandreHallucination2.\u206D\u202D\u206B\u200F\u202C\u202E\u206D\u200F\u206C\u200B\u202B\u206F\u200C\u206B\u200B\u200D\u200B\u206B\u200E\u206B\u200C\u206C\u206B\u200F\u206E\u200F\u200D\u202C\u202A\u200F\u200E\u206C\u206C\u200B\u200C\u202C\u206B\u200C\u200B\u200D\u202E(gameRunController2)) != StationType.EliteEnemy)
							{
								num = -2060519143;
								continue;
							}
							goto IL_0077;
						}
						case 3U:
							goto IL_000D;
						case 4U:
							base.ReactBattleEvent<GameEventArgs>(AyaFlandreHallucination2.\u200E\u206A\u202B\u200C\u206E\u200B\u202B\u202B\u206C\u200B\u200D\u206E\u202C\u200C\u202E\u206C\u206F\u202E\u202B\u206C\u200F\u200E\u206A\u202A\u202B\u202A\u202C\u202C\u206C\u202B\u202D\u202B\u206E\u200D\u206D\u206C\u202E\u206E\u206B\u206A\u202E(AyaFlandreHallucination2.\u202B\u206D\u200B\u206B\u200C\u202B\u202B\u200D\u202C\u206F\u202D\u200E\u200D\u200E\u206B\u206F\u202C\u206C\u206B\u202E\u200E\u202A\u202D\u206B\u202C\u200B\u200F\u206D\u202C\u202B\u202C\u206E\u202C\u202C\u202A\u200E\u206F\u200F\u206D\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
							num = (int)((num3 * 2268000199U) ^ 3651893751U);
							continue;
						case 6U:
							goto IL_006A;
						}
						return;
						IL_0077:
						this.Next = this.randoms.Sample(base.EnemyMoveRng);
						num = -2099956805;
					}
				}
				return;
			}
			IL_006A:
			throw AyaFlandreHallucination2.\u200B\u202C\u206A\u200E\u202A\u206B\u206E\u206A\u206E\u200E\u202A\u202E\u206C\u206D\u200C\u206D\u200D\u206F\u206E\u200D\u206D\u206C\u206B\u200F\u200E\u206F\u200C\u200E\u206C\u200C\u202E\u206D\u206F\u206A\u200D\u200D\u202A\u206D\u200F\u202D\u202E();
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaFlandreHallucination2.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> EyeActions()
		{
			AyaFlandreHallucination2.<EyeActions>d__6 <EyeActions>d__ = new AyaFlandreHallucination2.<EyeActions>d__6(-2);
			<EyeActions>d__.<>4__this = this;
			return <EyeActions>d__;
		}

		private IEnumerable<BattleAction> NoseActions()
		{
			AyaFlandreHallucination2.<NoseActions>d__7 <NoseActions>d__ = new AyaFlandreHallucination2.<NoseActions>d__7(-2);
			<NoseActions>d__.<>4__this = this;
			return <NoseActions>d__;
		}

		private IEnumerable<BattleAction> MouthActions()
		{
			AyaFlandreHallucination2.<MouthActions>d__8 <MouthActions>d__ = new AyaFlandreHallucination2.<MouthActions>d__8(-2);
			<MouthActions>d__.<>4__this = this;
			return <MouthActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaFlandreHallucination2.<GetTurnMoves>d__9 <GetTurnMoves>d__ = new AyaFlandreHallucination2.<GetTurnMoves>d__9(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = this.randoms.Without(this.Next).Sample(base.EnemyMoveRng);
		}

		static PlayerUnit \u206E\u206B\u206B\u206C\u202D\u200E\u202C\u206D\u206B\u200D\u202B\u202C\u202D\u202B\u206E\u206C\u202C\u200E\u202B\u202D\u206D\u200C\u200E\u200B\u202E\u200C\u200D\u206D\u206B\u206F\u200E\u200D\u202C\u200F\u202E\u200E\u202B\u202C\u200F\u206E\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameRunController \u200B\u206D\u206B\u202D\u200D\u200F\u200B\u202C\u206D\u200B\u206D\u206F\u200F\u202B\u206A\u202B\u200F\u206C\u206C\u206F\u202A\u200C\u200C\u202D\u206B\u206A\u200C\u200B\u202C\u206C\u200F\u202A\u202E\u202A\u200D\u206A\u200E\u206E\u206B\u200E\u202E(BattleController A_0)
		{
			return A_0.GameRun;
		}

		static Stage \u206F\u200E\u202E\u206A\u206E\u202D\u206C\u200C\u200D\u202C\u202C\u202A\u202E\u206C\u202E\u206E\u202B\u202E\u206A\u206A\u206E\u206D\u202D\u206B\u202E\u200E\u202D\u206A\u200B\u202E\u202E\u202E\u202C\u206F\u200E\u200C\u206E\u202B\u200B\u200F\u202E(GameRunController A_0)
		{
			return A_0.CurrentStage;
		}

		static Station \u206D\u202D\u206B\u200F\u202C\u202E\u206D\u200F\u206C\u200B\u202B\u206F\u200C\u206B\u200B\u200D\u200B\u206B\u200E\u206B\u200C\u206C\u206B\u200F\u206E\u200F\u200D\u202C\u202A\u200F\u200E\u206C\u206C\u200B\u200C\u202C\u206B\u200C\u200B\u200D\u202E(GameRunController A_0)
		{
			return A_0.CurrentStation;
		}

		static StationType \u202C\u202C\u200B\u202B\u206F\u202A\u206E\u200E\u202C\u200F\u206A\u206B\u200D\u200B\u200B\u206C\u206E\u206A\u202C\u202D\u200B\u206F\u206D\u206B\u202C\u206D\u202C\u206F\u202D\u202A\u206E\u206C\u206C\u202A\u206D\u206B\u206E\u206C\u200B\u202C\u202E(Station A_0)
		{
			return A_0.Type;
		}

		static NullReferenceException \u200B\u202C\u206A\u200E\u202A\u206B\u206E\u206A\u206E\u200E\u202A\u202E\u206C\u206D\u200C\u206D\u200D\u206F\u206E\u200D\u206D\u206C\u206B\u200F\u200E\u206F\u200C\u200E\u206C\u200C\u202E\u206D\u206F\u206A\u200D\u200D\u202A\u206D\u200F\u202D\u202E()
		{
			return new NullReferenceException();
		}

		static BattleController \u202B\u206D\u200B\u206B\u200C\u202B\u202B\u200D\u202C\u206F\u202D\u200E\u200D\u200E\u206B\u206F\u202C\u206C\u206B\u202E\u200E\u202A\u202D\u206B\u202C\u200B\u200F\u206D\u202C\u202B\u202C\u206E\u202C\u202C\u202A\u200E\u206F\u200F\u206D\u206E\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u200E\u206A\u202B\u200C\u206E\u200B\u202B\u202B\u206C\u200B\u200D\u206E\u202C\u200C\u202E\u206C\u206F\u202E\u202B\u206C\u200F\u200E\u206A\u202A\u202B\u202A\u202C\u202C\u206C\u202B\u202D\u202B\u206E\u200D\u206D\u206C\u202E\u206E\u206B\u206A\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		private readonly RepeatableRandomPool<AyaFlandreHallucination2.MoveType> randoms = new RepeatableRandomPool<AyaFlandreHallucination2.MoveType>
		{
			{
				AyaFlandreHallucination2.MoveType.Eye,
				1f
			},
			{
				AyaFlandreHallucination2.MoveType.Nose,
				1f
			},
			{
				AyaFlandreHallucination2.MoveType.Mouth,
				1f
			}
		};

		private enum MoveType
		{
			Eye,
			Nose,
			Mouth
		}
	}
}
