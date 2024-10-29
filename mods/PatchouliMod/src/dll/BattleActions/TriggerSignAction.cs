using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using PatchouliCharacterMod.Patch;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.BattleActions
{
	public sealed class TriggerSignAction : SimpleAction
	{
		internal TriggerSignAction(PatchouliSignSe sign, bool isActive = false, bool spellcasting = false)
		{
			this.args = new TriggerSignEventArgs
			{
				Sign = sign,
				IsActive = isActive,
				Spellcasting = spellcasting
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			bool spellcasting = this.args.Spellcasting;
			if (spellcasting)
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("Spellcasting", this.args, CustomGameEventPatch.Spellcasting);
			}
			bool isActive = this.args.IsActive;
			if (isActive)
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("SignActiveTriggering", this.args, CustomGameEventPatch.SignActiveTriggering);
			}
			else
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("SignPassiveTriggering", this.args, CustomGameEventPatch.SignPassiveTriggering);
			}
			yield return base.CreatePhase("Main", delegate
			{
				base.React(new Reactor(this.args.Sign.SignAction(this.args.IsActive)), null, null);
				bool isActive3 = this.args.IsActive;
				if (isActive3)
				{
					base.React(new GainManaAction(this.args.Sign.Mana), null, null);
				}
			}, false);
			bool spellcasting2 = this.args.Spellcasting;
			if (spellcasting2)
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("Spellcasted", this.args, CustomGameEventPatch.Spellcasted);
			}
			bool isActive2 = this.args.IsActive;
			if (isActive2)
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("SignActiveTriggered", this.args, CustomGameEventPatch.SignActiveTriggered);
			}
			else
			{
				yield return base.CreateEventPhase<TriggerSignEventArgs>("SignPassiveTriggered", this.args, CustomGameEventPatch.SignPassiveTriggered);
			}
			yield break;
		}

		private readonly TriggerSignEventArgs args;
	}
}
