using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliCurrentConductorSeDef))]
	public sealed class PatchouliCurrentConductorSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignPassiveTriggered, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignTriggered));
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignActiveTriggered, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignTriggered));
		}

		private IEnumerable<BattleAction> OnSignTriggered(TriggerSignEventArgs args)
		{
			bool flag = args.Sign is PatchouliWaterSignSe;
			if (flag)
			{
				base.NotifyActivating();
				foreach (Unit unit in base.Battle.AllAliveEnemies)
				{
					int newDrowning = (unit.HasStatusEffect<Drowning>() ? unit.GetStatusEffect<Drowning>().Level : 0);
					newDrowning += base.Level;
					yield return new ApplyStatusEffectAction<Drowning>(unit, new int?(newDrowning), new int?(0), null, null, 0f, true);
					bool flag2 = unit.HasStatusEffect<Drowning>();
					if (flag2)
					{
						int damage = Math.Max(unit.GetStatusEffect<Drowning>().Level, newDrowning);
						yield return DamageAction.Reaction(unit, damage, (damage >= 15) ? "溺水BuffB" : "溺水BuffA");
					}
					unit = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
