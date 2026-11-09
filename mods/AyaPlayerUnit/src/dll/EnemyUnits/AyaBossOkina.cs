using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaBossOkinaDef))]
	public sealed class AyaBossOkina : EnemyUnit
	{
		private AyaBossOkina.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(AyaBossOkina.\u206A\u206E\u206C\u202E\u206C\u200C\u202B\u200E\u202B\u200B\u206A\u206A\u206D\u200F\u200D\u206C\u206F\u202B\u206A\u202A\u200B\u200C\u206A\u200F\u202A\u206D\u202A\u206A\u200D\u206B\u200F\u202E\u200E\u206D\u200E\u202B\u206D\u206F\u200C\u206D\u202E(AyaBossOkina.\u206D\u206B\u206B\u206D\u202B\u202A\u206C\u206C\u200D\u200F\u202D\u200B\u206D\u206A\u200B\u206A\u200C\u202B\u202A\u206D\u206D\u206E\u202D\u202C\u202C\u200F\u200B\u200C\u200E\u206A\u206E\u202A\u206F\u206F\u206A\u200C\u202A\u202A\u202A\u206B\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			base.ReactBattleEvent<DamageEventArgs>(AyaBossOkina.\u206C\u202D\u200D\u200E\u202A\u200D\u206A\u206E\u200C\u200E\u200E\u206F\u200C\u202E\u200D\u202C\u206B\u206C\u206F\u202B\u202A\u206E\u206D\u206B\u202E\u202D\u202D\u202E\u206D\u200C\u202B\u200B\u202C\u206C\u200F\u206D\u206B\u200D\u206C\u202E(this), new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageTaking));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaBossOkina.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> OnDamageTaking(DamageEventArgs arg)
		{
			AyaBossOkina.<OnDamageTaking>d__6 <OnDamageTaking>d__ = new AyaBossOkina.<OnDamageTaking>d__6(-2);
			<OnDamageTaking>d__.<>3__arg = arg;
			return <OnDamageTaking>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaBossOkina.<GetTurnMoves>d__7 <GetTurnMoves>d__ = new AyaBossOkina.<GetTurnMoves>d__7(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = AyaBossOkina.MoveType.None;
		}

		static BattleController \u206D\u206B\u206B\u206D\u202B\u202A\u206C\u206C\u200D\u200F\u202D\u200B\u206D\u206A\u200B\u206A\u200C\u202B\u202A\u206D\u206D\u206E\u202D\u202C\u202C\u200F\u200B\u200C\u200E\u206A\u206E\u202A\u206F\u206F\u206A\u200C\u202A\u202A\u202A\u206B\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u206A\u206E\u206C\u202E\u206C\u200C\u202B\u200E\u202B\u200B\u206A\u206A\u206D\u200F\u200D\u206C\u206F\u202B\u206A\u202A\u200B\u200C\u206A\u200F\u202A\u206D\u202A\u206A\u200D\u206B\u200F\u202E\u200E\u206D\u200E\u202B\u206D\u206F\u200C\u206D\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		static GameEvent<DamageEventArgs> \u206C\u202D\u200D\u200E\u202A\u200D\u206A\u206E\u200C\u200E\u200E\u206F\u200C\u202E\u200D\u202C\u206B\u206C\u206F\u202B\u202A\u206E\u206D\u206B\u202E\u202D\u202D\u202E\u206D\u200C\u202B\u200B\u202C\u206C\u200F\u206D\u206B\u200D\u206C\u202E(Unit A_0)
		{
			return A_0.DamageTaking;
		}

		private enum MoveType
		{
			None
		}
	}
}
