using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.GunName;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(ForestAmbushSeDef))]
	public sealed class ForestAmbushSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
		}

		public IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = args.Source == base.Battle.Player && args.Target != null && args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				base.NotifyActivating();
				bool isAlive = args.Target.IsAlive;
				if (isAlive)
				{
					yield return new DamageAction(base.Owner, args.Target, DamageInfo.Reaction((float)base.Battle.Player.GetStatusEffect<RetaliationSe>().Level, false), GunNameID.GetGunFromId(400), GunType.Single);
				}
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnTurnEnding(UnitEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}
	}
}
