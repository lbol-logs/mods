using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuHesitationSignDef))]
	public sealed class YoumuHesitationSign : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool isAlive = selector.SelectedEnemy.IsAlive;
			if (isAlive)
			{
				yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			}
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			foreach (BattleAction battleAction in base.DebuffAction<LockedOn>(base.Battle.AllAliveEnemies, base.Value2, 0, 0, 0, true, 0.2f))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}
	}
}
