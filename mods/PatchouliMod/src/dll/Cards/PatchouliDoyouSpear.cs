using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliDoyouSpearDef))]
	public sealed class PatchouliDoyouSpear : PatchouliCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool flag = args.ActionSource == this && args.Kill;
			if (flag)
			{
				yield return new GainManaAction(base.Mana);
			}
			yield break;
		}
	}
}
