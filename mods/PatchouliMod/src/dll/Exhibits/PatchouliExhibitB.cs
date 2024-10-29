using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Exhibits
{
	[EntityLogic(typeof(PatchouliExhibitBDef))]
	public sealed class PatchouliExhibitB : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			foreach (StatusEffect se in base.Battle.Player.StatusEffects)
			{
				bool flag = se is PatchouliFireSignSe;
				if (flag)
				{
					yield break;
				}
				se = null;
			}
			IEnumerator<StatusEffect> enumerator = null;
			base.NotifyActivating();
			yield return new ApplyStatusEffectAction<PatchouliFireSignSe>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(PatchouliSignSe.TurnLimit), null, 0f, true);
			yield break;
		}
	}
}
