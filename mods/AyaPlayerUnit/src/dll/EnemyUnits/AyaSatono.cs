using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaSatonoDef))]
	public sealed class AyaSatono : EnemyUnit
	{
		private AyaSatono.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(AyaSatono.\u206D\u200C\u200D\u202C\u200B\u206E\u206C\u206B\u200B\u202E\u200C\u206B\u206F\u200F\u206B\u202B\u202D\u206F\u202D\u200F\u206F\u206A\u206A\u200B\u202A\u202B\u200E\u206E\u200B\u200D\u206E\u206C\u206F\u202C\u200F\u202E\u202E\u206B\u200B\u200E\u202E(AyaSatono.\u200D\u200C\u202A\u206B\u202C\u206B\u200F\u200F\u202E\u206F\u206E\u200F\u206E\u206E\u200F\u206C\u206C\u200C\u206B\u200C\u202D\u206A\u206E\u202A\u202B\u200E\u206F\u200D\u206C\u200E\u206B\u202A\u206A\u206F\u206D\u206B\u202C\u206E\u200E\u206A\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			base.ReactBattleEvent<DamageEventArgs>(AyaSatono.\u202A\u202E\u202E\u206D\u202D\u202E\u206C\u200F\u206B\u206F\u206E\u200C\u206C\u206A\u202B\u202A\u206C\u202E\u206D\u202A\u206D\u200D\u200C\u202D\u200B\u200F\u202C\u206F\u200F\u206E\u202A\u206B\u206B\u200E\u200E\u206B\u202E\u206D\u202A\u202E(this), new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageTaking));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
		{
			return new AyaSatono.<OnBattleStarted>d__5(-2);
		}

		private IEnumerable<BattleAction> OnDamageTaking(DamageEventArgs arg)
		{
			AyaSatono.<OnDamageTaking>d__6 <OnDamageTaking>d__ = new AyaSatono.<OnDamageTaking>d__6(-2);
			<OnDamageTaking>d__.<>3__arg = arg;
			return <OnDamageTaking>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaSatono.<GetTurnMoves>d__7 <GetTurnMoves>d__ = new AyaSatono.<GetTurnMoves>d__7(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = AyaSatono.MoveType.None;
		}

		static BattleController \u200D\u200C\u202A\u206B\u202C\u206B\u200F\u200F\u202E\u206F\u206E\u200F\u206E\u206E\u200F\u206C\u206C\u200C\u206B\u200C\u202D\u206A\u206E\u202A\u202B\u200E\u206F\u200D\u206C\u200E\u206B\u202A\u206A\u206F\u206D\u206B\u202C\u206E\u200E\u206A\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u206D\u200C\u200D\u202C\u200B\u206E\u206C\u206B\u200B\u202E\u200C\u206B\u206F\u200F\u206B\u202B\u202D\u206F\u202D\u200F\u206F\u206A\u206A\u200B\u202A\u202B\u200E\u206E\u200B\u200D\u206E\u206C\u206F\u202C\u200F\u202E\u202E\u206B\u200B\u200E\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		static GameEvent<DamageEventArgs> \u202A\u202E\u202E\u206D\u202D\u202E\u206C\u200F\u206B\u206F\u206E\u200C\u206C\u206A\u202B\u202A\u206C\u202E\u206D\u202A\u206D\u200D\u200C\u202D\u200B\u200F\u202C\u206F\u200F\u206E\u202A\u206B\u206B\u200E\u200E\u206B\u202E\u206D\u202A\u202E(Unit A_0)
		{
			return A_0.DamageTaking;
		}

		private enum MoveType
		{
			None
		}
	}
}
