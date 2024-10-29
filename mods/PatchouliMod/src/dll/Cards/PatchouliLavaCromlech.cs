using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliLavaCromlechDef))]
	public sealed class PatchouliLavaCromlech : PatchouliCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<TriggerSignEventArgs>(CustomGameEventPatch.Spellcasting, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSpellcasting));
		}

		private IEnumerable<BattleAction> OnSpellcasting(TriggerSignEventArgs args)
		{
			base.DeltaDamage += base.Value1;
			base.NotifyChanged();
			yield break;
		}
	}
}
