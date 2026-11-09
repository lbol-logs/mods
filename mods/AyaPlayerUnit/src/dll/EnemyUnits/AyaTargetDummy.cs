using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaTargetDummyDef))]
	public sealed class AyaTargetDummy : EnemyUnit
	{
		private AyaTargetDummy.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Next = AyaTargetDummy.MoveType.None;
		}

		protected override void OnDie()
		{
			this.React(AyaTargetDummy.\u206B\u202A\u200D\u202D\u206F\u202E\u206C\u202A\u200C\u200C\u206E\u206E\u206F\u206F\u202A\u206D\u200F\u202E\u200E\u200E\u206B\u200D\u202C\u200F\u206B\u206D\u202A\u202C\u206A\u200D\u200C\u200C\u200E\u206C\u206C\u206E\u200F\u206C\u206F\u200C\u202E(new SpawnEnemyAction<AyaTargetDummy>(this, AyaTargetDummy.\u200C\u202C\u202A\u200B\u206D\u206B\u206A\u202E\u202A\u200E\u206E\u200C\u202A\u206C\u206D\u202C\u206F\u206F\u202E\u202D\u200D\u206E\u206F\u202E\u200D\u200D\u200B\u206D\u202D\u206D\u200B\u206B\u202B\u206F\u200D\u202E\u202C\u206C\u200F\u200F\u202E(this), 0f, 0.3f, false)));
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaTargetDummy.<GetTurnMoves>d__6 <GetTurnMoves>d__ = new AyaTargetDummy.<GetTurnMoves>d__6(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = AyaTargetDummy.MoveType.None;
		}

		static int \u200C\u202C\u202A\u200B\u206D\u206B\u206A\u202E\u202A\u200E\u206E\u200C\u202A\u206C\u206D\u202C\u206F\u206F\u202E\u202D\u200D\u206E\u206F\u202E\u200D\u200D\u200B\u206D\u202D\u206D\u200B\u206B\u202B\u206F\u200D\u202E\u202C\u206C\u200F\u200F\u202E(EnemyUnit A_0)
		{
			return A_0.RootIndex;
		}

		static Reactor \u206B\u202A\u200D\u202D\u206F\u202E\u206C\u202A\u200C\u200C\u206E\u206E\u206F\u206F\u202A\u206D\u200F\u202E\u200E\u200E\u206B\u200D\u202C\u200F\u206B\u206D\u202A\u202C\u206A\u200D\u200C\u200C\u200E\u206C\u206C\u206E\u200F\u206C\u206F\u200C\u202E(BattleAction A_0)
		{
			return A_0;
		}

		private enum MoveType
		{
			None
		}
	}
}
