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
	[EntityLogic(typeof(PatchouliCircadianRhythmSeDef))]
	public sealed class PatchouliCircadianRhythmSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignActiveTriggered, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignActiveTriggered));
		}

		private IEnumerable<BattleAction> OnSignActiveTriggered(TriggerSignEventArgs args)
		{
			bool flag = args.Sign is PatchouliSunSignSe;
			if (flag)
			{
				base.NotifyActivating();
				int sunAmount = base.Battle.Player.GetStatusEffect<PatchouliSunSignSe>().Level;
				yield return new ApplyStatusEffectAction<PatchouliMoonSignSe>(base.Battle.Player, new int?(sunAmount * base.Level), null, new int?(PatchouliSignSe.TurnLimit), null, 0.2f, true);
			}
			else
			{
				bool flag2 = args.Sign is PatchouliMoonSignSe;
				if (flag2)
				{
					base.NotifyActivating();
					int moonAmount = base.Battle.Player.GetStatusEffect<PatchouliMoonSignSe>().Level;
					yield return new ApplyStatusEffectAction<PatchouliSunSignSe>(base.Battle.Player, new int?(moonAmount * base.Level), null, new int?(PatchouliSignSe.TurnLimit), null, 0.2f, true);
				}
			}
			yield break;
		}
	}
}
