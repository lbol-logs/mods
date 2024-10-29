using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeAttackPowerDef))]
	public sealed class SanaeAttackPower : SampleCharacterCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
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
					yield return new GainPowerAction((int)damageInfo.Damage);
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
