using System;
using System.Linq;
using LBoL.Core.Intentions;
using LBoL.Core.Units;

namespace PatchouliCharacterMod.Cards.Template
{
	public class PatchouliCounterUtils
	{
		public static bool EnemyIntendsToAttack(EnemyUnit enemy)
		{
			return enemy.Intentions.Any(delegate(Intention i)
			{
				bool flag = !(i is AttackIntention);
				if (flag)
				{
					SpellCardIntention spellCardIntention = i as SpellCardIntention;
					bool flag2 = spellCardIntention == null || spellCardIntention.Damage == null;
					if (flag2)
					{
						return false;
					}
				}
				return true;
			});
		}

		public static bool EnemyIntendsToAccurateAttack(EnemyUnit enemy)
		{
			bool flag = enemy.Intentions.Any(delegate(Intention i)
			{
				bool flag2 = i is AttackIntention;
				if (flag2)
				{
					AttackIntention attackIntention = i as AttackIntention;
					bool flag3 = attackIntention == null;
					if (flag3)
					{
						return attackIntention.IsAccuracy;
					}
				}
				else
				{
					bool flag4 = i is SpellCardIntention;
					if (flag4)
					{
						SpellCardIntention spellCardIntention = i as SpellCardIntention;
						bool flag5 = spellCardIntention == null || spellCardIntention.Damage == null;
						if (flag5)
						{
							return spellCardIntention.IsAccuracy;
						}
					}
				}
				return false;
			});
			return false;
		}

		public static bool EnemyHasIntent<T>(EnemyUnit enemy)
		{
			return enemy.Intentions.Any((Intention i) => i is T);
		}
	}
}
