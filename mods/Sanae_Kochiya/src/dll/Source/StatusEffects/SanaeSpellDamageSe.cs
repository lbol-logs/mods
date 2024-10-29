using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.GunName;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeSpellDamageSeDef))]
	public sealed class SanaeSpellDamageSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UsUsingEventArgs>(base.Battle.UsUsed, new EventSequencedReactor<UsUsingEventArgs>(this.OnUsUsed));
		}

		private IEnumerable<BattleAction> OnUsUsed(UsUsingEventArgs args)
		{
			int num;
			for (int i = 0; i < base.Level; i = num + 1)
			{
				yield return new DamageAction(base.Owner, base.Battle.RandomAliveEnemy, DamageInfo.Attack(8f, false), GunNameID.GetGunFromId(14190), GunType.Single);
				num = i;
			}
			yield break;
		}
	}
}
