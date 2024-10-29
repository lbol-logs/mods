using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuNextToNoneDef))]
	public sealed class YoumuNextToNone : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			int enemyBlock = selectedEnemy.Block;
			int enemyShield = selectedEnemy.Shield;
			yield return new LoseBlockShieldAction(selectedEnemy, enemyBlock, enemyShield, false);
			bool flag = selectedEnemy.HasStatusEffect<Graze>();
			if (flag)
			{
				yield return new RemoveStatusEffectAction(selectedEnemy.GetStatusEffect<Graze>(), true, 0.1f);
			}
			bool flag2 = selectedEnemy.HasStatusEffect<GuangxueMicai>();
			if (flag2)
			{
				yield return new RemoveStatusEffectAction(selectedEnemy.GetStatusEffect<GuangxueMicai>(), true, 0.1f);
			}
			bool flag3 = selectedEnemy.HasStatusEffect<Invincible>();
			if (flag3)
			{
				yield return new RemoveStatusEffectAction(selectedEnemy.GetStatusEffect<Invincible>(), true, 0.1f);
			}
			bool flag4 = selectedEnemy.HasStatusEffect<InvincibleEternal>();
			if (flag4)
			{
				yield return new RemoveStatusEffectAction(selectedEnemy.GetStatusEffect<InvincibleEternal>(), true, 0.1f);
			}
			yield return new UnsheatheAllInHandAction();
			yield break;
		}
	}
}
