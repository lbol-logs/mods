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
	[EntityLogic(typeof(SanaeAttackBlockSeDef))]
	public sealed class SanaeAttackBlockSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		private IEnumerable<BattleAction> OnTurnEnding(GameEventArgs args)
		{
			base.NotifyActivating();
			int block = base.Owner.Block;
			yield return new LoseBlockShieldAction(base.Owner, block, 0, false);
			yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)block, false), GunNameID.GetGunFromId(4900), GunType.Single);
			yield return new CastBlockShieldAction(base.Owner, base.Owner, new BlockInfo(base.Level, BlockShieldType.Normal), false);
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}
	}
}
