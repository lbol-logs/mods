using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuCrescentMoonSlashDef))]
	public sealed class YoumuCrescentMoonSlash : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			bool isAlive = selectedEnemy.IsAlive;
			if (isAlive)
			{
				yield return base.DebuffAction<LockedOn>(selectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			}
			yield return new UnsheatheAllInHandAction();
			yield break;
		}
	}
}
