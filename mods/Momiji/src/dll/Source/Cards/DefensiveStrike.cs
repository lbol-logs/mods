using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(DefensiveStrikeDef))]
	public sealed class DefensiveStrike : SampleCharacterCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Cause == ActionCause.Card && args.ActionSource == this;
			if (flag)
			{
				DamageInfo damageInfo = args.DamageInfo;
				bool flag2 = damageInfo.Damage > 0f;
				if (flag2)
				{
					yield return new CastBlockShieldAction(base.Battle.Player, (int)damageInfo.Damage, 0, BlockShieldType.Normal, false);
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
