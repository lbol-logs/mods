using System;
using System.Collections.Generic;
using System.Linq;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaLongDef))]
	public sealed class AyaLong : EnemyUnit
	{
		private AyaLong.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Next = AyaLong.MoveType.ShootAddCard;
			for (;;)
			{
				IL_0007:
				int num = -645264557;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(uint)((-620056094 - -2083537033) * 158289585 + ((-399119357 ^ -1637295473) + -1193832773 * 1588410799) - num2 - -(-1425720133 ^ -1944392407))))) % 5U)
					{
					case 0U:
						goto IL_0007;
					case 1U:
						base.ReactBattleEvent<CardUsingEventArgs>(AyaLong.\u206E\u206B\u206E\u200D\u200E\u202B\u206A\u202A\u206F\u206E\u202E\u202E\u206C\u206C\u202B\u206E\u202B\u202C\u200B\u200F\u200C\u202C\u202D\u206E\u200F\u200F\u202E\u200C\u202E\u206B\u206E\u206C\u200B\u202A\u206F\u200B\u202D\u200F\u206B\u200C\u202E(AyaLong.\u200E\u200C\u206C\u206F\u200B\u206E\u202E\u200F\u206C\u206E\u206C\u206A\u200E\u202A\u202C\u200B\u206D\u202C\u202A\u202B\u206B\u200B\u206D\u200D\u202B\u206D\u200F\u202D\u200D\u202A\u206E\u206B\u206C\u206E\u206F\u206A\u200C\u206B\u202B\u200C\u202E(this)), new Func<CardUsingEventArgs, IEnumerable<BattleAction>>(this.OnCardUsing));
						num = (int)((num3 * 2734108070U) ^ 1878753117U);
						continue;
					case 2U:
						this.React(AyaLong.\u202D\u200B\u206E\u206E\u206B\u200C\u202A\u200B\u202C\u200E\u206A\u206D\u200E\u202E\u200F\u206D\u202E\u206C\u206D\u206D\u200D\u206C\u202E\u206B\u202A\u202C\u202E\u200D\u200B\u206D\u202A\u202D\u202E\u200E\u202A\u200C\u206F\u202D\u202A\u202B\u202E(new ApplyStatusEffectAction<AyaPlayerUnitAllySeDef.AyaPlayerUnitAllySe>(this, null, null, null, null, 0f, true)));
						num = (int)((num3 * 2724339023U) ^ 1326522742U);
						continue;
					case 4U:
						base.CountDown = 3;
						num = (int)((num3 * 3044278254U) ^ 1262167918U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			base.HandleBattleEvent<DamageDealingEventArgs>(AyaLong.\u200C\u206A\u200B\u200C\u206B\u200F\u200E\u206B\u202C\u202B\u202B\u202B\u200C\u202B\u202A\u200F\u202D\u200D\u202B\u206F\u200F\u202A\u200E\u206D\u200C\u200B\u202C\u206C\u206D\u200F\u206D\u200F\u200D\u206B\u200E\u206C\u206F\u200E\u206C\u202E\u202E(AyaLong.\u202C\u202A\u206B\u200B\u200F\u206B\u202D\u206C\u202C\u202B\u202E\u200B\u200E\u206F\u206E\u200E\u200D\u200C\u200C\u200E\u202D\u206A\u200B\u202A\u202A\u202E\u202D\u200F\u202E\u206D\u206D\u206C\u206F\u200E\u202B\u200D\u206A\u206C\u206C\u206F\u202E(AyaLong.\u200E\u200C\u206C\u206F\u200B\u206E\u202E\u200F\u206C\u206E\u206C\u206A\u200E\u202A\u202C\u200B\u206D\u202C\u202A\u202B\u206B\u200B\u206D\u200D\u202B\u206D\u200F\u202D\u200D\u202A\u206E\u206B\u206C\u206E\u206F\u206A\u200C\u206B\u202B\u200C\u202E(this))), new GameEventHandler<DamageDealingEventArgs>(this.OnPlayerDamageDealing));
			base.ReactBattleEvent<DamageEventArgs>(AyaLong.\u206F\u202B\u202E\u200D\u206C\u206F\u200C\u202D\u202D\u206D\u200E\u206F\u200B\u200F\u206A\u202B\u206E\u202C\u200B\u206C\u200C\u200C\u206C\u202C\u206D\u202B\u206F\u206F\u206C\u206E\u206F\u200E\u202E\u202B\u206F\u202A\u206A\u202A\u202E\u206E\u202E(this), new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageReceiving));
			base.ReactBattleEvent<StatusEffectApplyEventArgs>(AyaLong.\u202B\u202B\u206D\u206A\u206D\u202D\u202B\u206A\u206C\u206F\u202E\u202E\u200F\u202A\u202B\u202E\u206D\u200D\u200F\u206C\u206E\u202A\u206F\u206E\u206D\u200F\u206F\u206C\u202D\u206E\u200F\u206C\u202D\u206F\u200F\u206E\u206F\u200C\u202C\u200D\u202E(this), new Func<StatusEffectApplyEventArgs, IEnumerable<BattleAction>>(this.OnStatusEffectAdding));
		}

		private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs args)
		{
			AyaLong.<OnCardUsing>d__5 <OnCardUsing>d__ = new AyaLong.<OnCardUsing>d__5(-2);
			<OnCardUsing>d__.<>4__this = this;
			<OnCardUsing>d__.<>3__args = args;
			return <OnCardUsing>d__;
		}

		private void OnPlayerDamageDealing(DamageDealingEventArgs args)
		{
			if (AyaLong.\u202E\u206E\u206F\u200D\u202A\u206A\u202B\u200D\u206E\u202A\u202A\u206B\u202E\u202D\u200E\u206E\u202E\u200C\u202D\u200B\u200D\u206F\u202B\u202E\u200C\u200F\u206C\u206F\u200F\u202D\u202C\u206E\u202E\u206E\u200B\u206D\u202E\u200C\u200C\u202B\u202E(args) != null)
			{
				for (;;)
				{
					IL_000B:
					int num = 130943629;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-num2 ^ -1109307311) - (-552220602 + 966359485))) % 4U)
						{
						case 0U:
							goto IL_000B;
						case 2U:
						{
							Unit[] array = new Unit[1];
							array[0] = (from e in AyaLong.\u200F\u206E\u206F\u206A\u206D\u206D\u200E\u206C\u206E\u206E\u202C\u206D\u202C\u202D\u200B\u202A\u206A\u200B\u206E\u206E\u206F\u200C\u206E\u206C\u200D\u202C\u206D\u200F\u206B\u202A\u206F\u200C\u206B\u202D\u206E\u202B\u206E\u206D\u202B\u206F\u202E(AyaLong.\u200E\u200C\u206C\u206F\u200B\u206E\u202E\u200F\u206C\u206E\u206C\u206A\u200E\u202A\u202C\u200B\u206D\u202C\u202A\u202B\u206B\u200B\u206D\u200D\u202B\u206D\u200F\u202D\u200D\u202A\u206E\u206B\u206C\u206E\u206F\u206A\u200C\u206B\u202B\u200C\u202E(this))
								where !e.HasStatusEffect<AyaPlayerUnitAllySeDef.AyaPlayerUnitAllySe>()
								select e).Sample(AyaLong.\u202C\u206F\u200D\u202E\u200E\u200D\u200F\u202B\u206E\u206B\u206A\u202C\u200E\u202E\u206D\u202D\u206A\u202B\u202D\u206A\u200E\u200F\u200B\u206D\u202D\u206E\u206E\u206F\u202E\u202C\u206F\u206E\u202D\u206B\u200E\u206B\u200B\u206A\u202A\u200E\u202E(AyaLong.\u202B\u200F\u206F\u200B\u206E\u200F\u200F\u202A\u206F\u200C\u200C\u202B\u206D\u206A\u202C\u202D\u202A\u200F\u200F\u200F\u202E\u206A\u202A\u206E\u206D\u200C\u200D\u202D\u206B\u202D\u202B\u202D\u206A\u202A\u206E\u206A\u206B\u206B\u200F\u200C\u202E(this)));
							AyaLong.\u206F\u206F\u206D\u206A\u206F\u200D\u206B\u206A\u206F\u202D\u200B\u200C\u206A\u202C\u200D\u202A\u206A\u206F\u202B\u206B\u206C\u206A\u206A\u206A\u206F\u206C\u206D\u206E\u206E\u200F\u206F\u202D\u202B\u200F\u206E\u206A\u202D\u200E\u202D\u200E\u202E(args, array);
							num = -947716309;
							continue;
						}
						case 3U:
							num = (int)(((!AyaLong.\u206E\u206D\u200C\u202C\u200E\u206D\u202C\u206A\u200E\u200B\u202C\u202A\u202E\u200F\u200F\u206D\u202E\u202A\u202E\u202A\u200C\u206B\u206A\u200B\u202B\u206D\u200E\u200D\u202D\u200E\u202A\u206A\u202C\u200D\u202C\u202D\u202A\u202C\u200D\u206D\u202E(AyaLong.\u202E\u206E\u206F\u200D\u202A\u206A\u202B\u200D\u206E\u202A\u202A\u206B\u202E\u202D\u200E\u206E\u202E\u200C\u202D\u200B\u200D\u206F\u202B\u202E\u200C\u200F\u206C\u206F\u200F\u202D\u202C\u206E\u202E\u206E\u200B\u206D\u202E\u200C\u200C\u202B\u202E(args), this)) ? 2675289313U : 1201036366U) ^ (num3 * 1640983798U));
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		private IEnumerable<BattleAction> OnDamageReceiving(DamageEventArgs args)
		{
			AyaLong.<OnDamageReceiving>d__7 <OnDamageReceiving>d__ = new AyaLong.<OnDamageReceiving>d__7(-2);
			<OnDamageReceiving>d__.<>4__this = this;
			<OnDamageReceiving>d__.<>3__args = args;
			return <OnDamageReceiving>d__;
		}

		private IEnumerable<BattleAction> OnStatusEffectAdding(StatusEffectApplyEventArgs args)
		{
			AyaLong.<OnStatusEffectAdding>d__8 <OnStatusEffectAdding>d__ = new AyaLong.<OnStatusEffectAdding>d__8(-2);
			<OnStatusEffectAdding>d__.<>4__this = this;
			<OnStatusEffectAdding>d__.<>3__args = args;
			return <OnStatusEffectAdding>d__;
		}

		private IEnumerable<BattleAction> ShootAddCardActions()
		{
			AyaLong.<ShootAddCardActions>d__9 <ShootAddCardActions>d__ = new AyaLong.<ShootAddCardActions>d__9(-2);
			<ShootAddCardActions>d__.<>4__this = this;
			return <ShootAddCardActions>d__;
		}

		private IEnumerable<BattleAction> ShootGrazeActions()
		{
			AyaLong.<ShootGrazeActions>d__10 <ShootGrazeActions>d__ = new AyaLong.<ShootGrazeActions>d__10(-2);
			<ShootGrazeActions>d__.<>4__this = this;
			return <ShootGrazeActions>d__;
		}

		private IEnumerable<BattleAction> SpellActions()
		{
			AyaLong.<SpellActions>d__11 <SpellActions>d__ = new AyaLong.<SpellActions>d__11(-2);
			<SpellActions>d__.<>4__this = this;
			return <SpellActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaLong.<GetTurnMoves>d__12 <GetTurnMoves>d__ = new AyaLong.<GetTurnMoves>d__12(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			int num = base.CountDown - 1;
			for (;;)
			{
				IL_0009:
				int num2 = 1079178116;
				for (;;)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(~(num3 - ~-317385240) * -478741169 + 745782111)) % 6U)
					{
					case 0U:
						return;
					case 1U:
						base.CountDown = num;
						num2 = (int)((num4 * 4026796257U) ^ 2302243190U);
						continue;
					case 2U:
						this.Next = AyaLong.MoveType.Spell;
						base.CountDown = 4;
						num2 = (int)((num4 * 4101659847U) ^ 127321365U);
						continue;
					case 3U:
						goto IL_0009;
					case 4U:
						num2 = (int)(((base.CountDown <= 0) ? 3574977307U : 1169636230U) ^ (num4 * 3013024200U));
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.Next = ((base.CountDown == 2) ? AyaLong.MoveType.ShootGraze : AyaLong.MoveType.ShootAddCard);
		}

		static Reactor \u202D\u200B\u206E\u206E\u206B\u200C\u202A\u200B\u202C\u200E\u206A\u206D\u200E\u202E\u200F\u206D\u202E\u206C\u206D\u206D\u200D\u206C\u202E\u206B\u202A\u202C\u202E\u200D\u200B\u206D\u202A\u202D\u202E\u200E\u202A\u200C\u206F\u202D\u202A\u202B\u202E(BattleAction A_0)
		{
			return A_0;
		}

		static BattleController \u200E\u200C\u206C\u206F\u200B\u206E\u202E\u200F\u206C\u206E\u206C\u206A\u200E\u202A\u202C\u200B\u206D\u202C\u202A\u202B\u206B\u200B\u206D\u200D\u202B\u206D\u200F\u202D\u200D\u202A\u206E\u206B\u206C\u206E\u206F\u206A\u200C\u206B\u202B\u200C\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<CardUsingEventArgs> \u206E\u206B\u206E\u200D\u200E\u202B\u206A\u202A\u206F\u206E\u202E\u202E\u206C\u206C\u202B\u206E\u202B\u202C\u200B\u200F\u200C\u202C\u202D\u206E\u200F\u200F\u202E\u200C\u202E\u206B\u206E\u206C\u200B\u202A\u206F\u200B\u202D\u200F\u206B\u200C\u202E(BattleController A_0)
		{
			return A_0.CardUsing;
		}

		static PlayerUnit \u202C\u202A\u206B\u200B\u200F\u206B\u202D\u206C\u202C\u202B\u202E\u200B\u200E\u206F\u206E\u200E\u200D\u200C\u200C\u200E\u202D\u206A\u200B\u202A\u202A\u202E\u202D\u200F\u202E\u206D\u206D\u206C\u206F\u200E\u202B\u200D\u206A\u206C\u206C\u206F\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameEvent<DamageDealingEventArgs> \u200C\u206A\u200B\u200C\u206B\u200F\u200E\u206B\u202C\u202B\u202B\u202B\u200C\u202B\u202A\u200F\u202D\u200D\u202B\u206F\u200F\u202A\u200E\u206D\u200C\u200B\u202C\u206C\u206D\u200F\u206D\u200F\u200D\u206B\u200E\u206C\u206F\u200E\u206C\u202E\u202E(Unit A_0)
		{
			return A_0.DamageDealing;
		}

		static GameEvent<DamageEventArgs> \u206F\u202B\u202E\u200D\u206C\u206F\u200C\u202D\u202D\u206D\u200E\u206F\u200B\u200F\u206A\u202B\u206E\u202C\u200B\u206C\u200C\u200C\u206C\u202C\u206D\u202B\u206F\u206F\u206C\u206E\u206F\u200E\u202E\u202B\u206F\u202A\u206A\u202A\u202E\u206E\u202E(Unit A_0)
		{
			return A_0.DamageReceiving;
		}

		static GameEvent<StatusEffectApplyEventArgs> \u202B\u202B\u206D\u206A\u206D\u202D\u202B\u206A\u206C\u206F\u202E\u202E\u200F\u202A\u202B\u202E\u206D\u200D\u200F\u206C\u206E\u202A\u206F\u206E\u206D\u200F\u206F\u206C\u202D\u206E\u200F\u206C\u202D\u206F\u200F\u206E\u206F\u200C\u202C\u200D\u202E(Unit A_0)
		{
			return A_0.StatusEffectAdding;
		}

		static Unit[] \u202E\u206E\u206F\u200D\u202A\u206A\u202B\u200D\u206E\u202A\u202A\u206B\u202E\u202D\u200E\u206E\u202E\u200C\u202D\u200B\u200D\u206F\u202B\u202E\u200C\u200F\u206C\u206F\u200F\u202D\u202C\u206E\u202E\u206E\u200B\u206D\u202E\u200C\u200C\u202B\u202E(DamageDealingEventArgs A_0)
		{
			return A_0.Targets;
		}

		static bool \u206E\u206D\u200C\u202C\u200E\u206D\u202C\u206A\u200E\u200B\u202C\u202A\u202E\u200F\u200F\u206D\u202E\u202A\u202E\u202A\u200C\u206B\u206A\u200B\u202B\u206D\u200E\u200D\u202D\u200E\u202A\u206A\u202C\u200D\u202C\u202D\u202A\u202C\u200D\u206D\u202E(object A_0, object A_1)
		{
			return A_0.Equals(A_1);
		}

		static IEnumerable<EnemyUnit> \u200F\u206E\u206F\u206A\u206D\u206D\u200E\u206C\u206E\u206E\u202C\u206D\u202C\u202D\u200B\u202A\u206A\u200B\u206E\u206E\u206F\u200C\u206E\u206C\u200D\u202C\u206D\u200F\u206B\u202A\u206F\u200C\u206B\u202D\u206E\u202B\u206E\u206D\u202B\u206F\u202E(BattleController A_0)
		{
			return A_0.AllAliveEnemies;
		}

		static GameRunController \u202B\u200F\u206F\u200B\u206E\u200F\u200F\u202A\u206F\u200C\u200C\u202B\u206D\u206A\u202C\u202D\u202A\u200F\u200F\u200F\u202E\u206A\u202A\u206E\u206D\u200C\u200D\u202D\u206B\u202D\u202B\u202D\u206A\u202A\u206E\u206A\u206B\u206B\u200F\u200C\u202E(GameEntity A_0)
		{
			return A_0.GameRun;
		}

		static RandomGen \u202C\u206F\u200D\u202E\u200E\u200D\u200F\u202B\u206E\u206B\u206A\u202C\u200E\u202E\u206D\u202D\u206A\u202B\u202D\u206A\u200E\u200F\u200B\u206D\u202D\u206E\u206E\u206F\u202E\u202C\u206F\u206E\u202D\u206B\u200E\u206B\u200B\u206A\u202A\u200E\u202E(GameRunController A_0)
		{
			return A_0.BattleRng;
		}

		static void \u206F\u206F\u206D\u206A\u206F\u200D\u206B\u206A\u206F\u202D\u200B\u200C\u206A\u202C\u200D\u202A\u206A\u206F\u202B\u206B\u206C\u206A\u206A\u206A\u206F\u206C\u206D\u206E\u206E\u200F\u206F\u202D\u202B\u200F\u206E\u206A\u202D\u200E\u202D\u200E\u202E(DamageDealingEventArgs A_0, Unit[] A_1)
		{
			A_0.Targets = A_1;
		}

		private enum MoveType
		{
			ShootAddCard,
			ShootGraze,
			Spell
		}
	}
}
