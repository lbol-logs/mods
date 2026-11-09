using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaMaiDef))]
	public sealed class AyaMai : EnemyUnit
	{
		private AyaMai.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(AyaMai.\u200F\u200F\u200F\u206D\u206C\u200B\u200B\u202E\u202C\u200F\u200D\u202A\u206D\u202A\u200D\u206D\u206D\u206B\u202A\u200B\u202D\u200E\u206A\u202E\u206E\u206C\u206B\u200F\u200B\u200E\u202D\u206F\u202E\u200B\u202B\u200C\u200F\u206C\u202C\u202E\u202E(AyaMai.\u206F\u206D\u200D\u200B\u202B\u202E\u200E\u206F\u200C\u200B\u202E\u206E\u202D\u202E\u206F\u200D\u206D\u202A\u206A\u202E\u200C\u202C\u206C\u202D\u200F\u202C\u200D\u202C\u200B\u202E\u206F\u206E\u202B\u200E\u206E\u202E\u206A\u206F\u206C\u202D\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			base.ReactBattleEvent<DamageEventArgs>(AyaMai.\u202D\u200B\u200F\u206C\u206C\u202A\u206B\u202D\u206F\u200B\u200C\u202D\u206F\u200D\u200D\u202D\u206E\u202E\u206C\u206A\u206C\u200E\u202C\u200C\u202B\u202B\u206D\u200F\u200C\u200E\u202E\u202A\u200D\u200D\u206D\u200E\u206B\u206A\u202D\u206B\u202E(this), new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageTaking));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaMai.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> OnDamageTaking(DamageEventArgs arg)
		{
			AyaMai.<OnDamageTaking>d__6 <OnDamageTaking>d__ = new AyaMai.<OnDamageTaking>d__6(-2);
			<OnDamageTaking>d__.<>3__arg = arg;
			return <OnDamageTaking>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaMai.<GetTurnMoves>d__7 <GetTurnMoves>d__ = new AyaMai.<GetTurnMoves>d__7(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = AyaMai.MoveType.None;
		}

		static BattleController \u206F\u206D\u200D\u200B\u202B\u202E\u200E\u206F\u200C\u200B\u202E\u206E\u202D\u202E\u206F\u200D\u206D\u202A\u206A\u202E\u200C\u202C\u206C\u202D\u200F\u202C\u200D\u202C\u200B\u202E\u206F\u206E\u202B\u200E\u206E\u202E\u206A\u206F\u206C\u202D\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u200F\u200F\u200F\u206D\u206C\u200B\u200B\u202E\u202C\u200F\u200D\u202A\u206D\u202A\u200D\u206D\u206D\u206B\u202A\u200B\u202D\u200E\u206A\u202E\u206E\u206C\u206B\u200F\u200B\u200E\u202D\u206F\u202E\u200B\u202B\u200C\u200F\u206C\u202C\u202E\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		static GameEvent<DamageEventArgs> \u202D\u200B\u200F\u206C\u206C\u202A\u206B\u202D\u206F\u200B\u200C\u202D\u206F\u200D\u200D\u202D\u206E\u202E\u206C\u206A\u206C\u200E\u202C\u200C\u202B\u202B\u206D\u200F\u200C\u200E\u202E\u202A\u200D\u200D\u206D\u200E\u206B\u206A\u202D\u206B\u202E(Unit A_0)
		{
			return A_0.DamageTaking;
		}

		private enum MoveType
		{
			None
		}
	}
}
