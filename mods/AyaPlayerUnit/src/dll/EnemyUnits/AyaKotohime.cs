using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaKotohimeDef))]
	public sealed class AyaKotohime : EnemyUnit
	{
		private AyaKotohime.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(AyaKotohime.\u202D\u202D\u200F\u202D\u200C\u206D\u206C\u206F\u202D\u202C\u202A\u202C\u200C\u202A\u202B\u206D\u200D\u200B\u202E\u200B\u202C\u200B\u200E\u206F\u206A\u200D\u200C\u200E\u200D\u206A\u206E\u202B\u200C\u202C\u206A\u200E\u202D\u200C\u206A\u206B\u202E(this), new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageTaking));
		}

		private IEnumerable<BattleAction> OnDamageTaking(DamageEventArgs arg)
		{
			AyaKotohime.<OnDamageTaking>d__5 <OnDamageTaking>d__ = new AyaKotohime.<OnDamageTaking>d__5(-2);
			<OnDamageTaking>d__.<>3__arg = arg;
			return <OnDamageTaking>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaKotohime.<GetTurnMoves>d__6 <GetTurnMoves>d__ = new AyaKotohime.<GetTurnMoves>d__6(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = AyaKotohime.MoveType.None;
		}

		static GameEvent<DamageEventArgs> \u202D\u202D\u200F\u202D\u200C\u206D\u206C\u206F\u202D\u202C\u202A\u202C\u200C\u202A\u202B\u206D\u200D\u200B\u202E\u200B\u202C\u200B\u200E\u206F\u206A\u200D\u200C\u200E\u200D\u206A\u206E\u202B\u200C\u202C\u206A\u200E\u202D\u200C\u206A\u206B\u202E(Unit A_0)
		{
			return A_0.DamageTaking;
		}

		private enum MoveType
		{
			None
		}
	}
}
