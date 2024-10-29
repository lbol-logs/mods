using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.BattleActions
{
	public sealed class TriggerSignPassiveAction : SimpleAction
	{
		internal TriggerSignPassiveAction(int sign)
		{
			this.args = new TriggerSignPassiveEventArgs
			{
				Sign = sign
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				foreach (StatusEffect statusEffect in base.Battle.Player.StatusEffects)
				{
					PatchouliSignSe patchouliSignSe = statusEffect as PatchouliSignSe;
					bool flag = patchouliSignSe != null && patchouliSignSe.Sign == this.args.Sign;
					if (flag)
					{
						base.React(new TriggerSignAction(patchouliSignSe, false, false), null, null);
					}
				}
			}, false);
			yield break;
		}

		private readonly TriggerSignPassiveEventArgs args;
	}
}
