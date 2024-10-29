using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.BattleActions
{
	public sealed class TriggerAllSignsPassiveAction : SimpleAction
	{
		internal TriggerAllSignsPassiveAction()
		{
			this.args = new TriggerAllSignsPassiveEventArgs();
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				foreach (StatusEffect statusEffect in base.Battle.Player.StatusEffects)
				{
					PatchouliSignSe patchouliSignSe = statusEffect as PatchouliSignSe;
					bool flag = patchouliSignSe != null;
					if (flag)
					{
						base.React(new TriggerSignAction(patchouliSignSe, false, false), null, null);
					}
				}
			}, false);
			yield break;
		}

		private readonly TriggerAllSignsPassiveEventArgs args;
	}
}
