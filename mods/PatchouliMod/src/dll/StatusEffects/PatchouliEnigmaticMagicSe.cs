using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliEnigmaticMagicSeDef))]
	public sealed class PatchouliEnigmaticMagicSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.Spellcasted, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignGained));
		}

		private IEnumerable<BattleAction> OnSignGained(TriggerSignEventArgs args)
		{
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, base.Level, 0, BlockShieldType.Direct, true);
			yield break;
		}
	}
}
