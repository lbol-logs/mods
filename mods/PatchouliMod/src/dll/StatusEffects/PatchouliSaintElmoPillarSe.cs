using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.GunName;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliSaintElmoPillarSeDef))]
	public sealed class PatchouliSaintElmoPillarSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectEventArgs>(base.Battle.Player.StatusEffectRemoved, new EventSequencedReactor<StatusEffectEventArgs>(this.OnStatusEffectRemoved));
		}

		private IEnumerable<BattleAction> OnStatusEffectRemoved(StatusEffectEventArgs args)
		{
			bool flag = args.Effect is Reflect;
			if (flag)
			{
				int damage = args.Effect.Level * base.Level;
				yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)damage, false), PatchouliGunName.PatchouliSaintElmoPillar, GunType.Single);
			}
			yield break;
		}
	}
}
