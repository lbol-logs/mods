using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliTheUnmovingGreatLibrarySeDef))]
	public sealed class PatchouliTheUnmovingGreatLibrarySe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignActiveTriggered, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignActiveTriggered));
		}

		private IEnumerable<BattleAction> OnSignActiveTriggered(TriggerSignEventArgs args)
		{
			base.NotifyActivating();
			yield return new ApplyStatusEffectAction<PatchouliIntelligenceSe>(base.Battle.Player, new int?(base.Level), null, null, null, 0f, true);
			yield break;
		}
	}
}
