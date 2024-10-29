using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Intentions;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuReflectionSlashDef))]
	public sealed class YoumuReflectionSlash : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		public override bool Triggered
		{
			get
			{
				IEnumerable<EnemyUnit> allAliveEnemies = base.Battle.AllAliveEnemies;
				foreach (EnemyUnit enemyUnit in allAliveEnemies)
				{
					bool flag = enemyUnit.Intentions.Any(delegate(Intention i)
					{
						bool flag3 = !(i is AttackIntention);
						if (flag3)
						{
							SpellCardIntention spellCardIntention = i as SpellCardIntention;
							bool flag4 = spellCardIntention == null || spellCardIntention.Damage == null;
							if (flag4)
							{
								return false;
							}
						}
						return true;
					});
					bool flag2 = flag;
					if (flag2)
					{
						return true;
					}
				}
				return false;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = base.PlayInTriggered && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
				yield return base.BuffAction<YoumuRiposteSe>(riposteAmount, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
