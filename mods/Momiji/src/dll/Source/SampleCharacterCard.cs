using System;
using LBoL.Core.Cards;
using LBoL.Core.Intentions;
using LBoL.Core.Units;

namespace Momiji.Source
{
	public class SampleCharacterCard : Card
	{
		public int IntentionCheck(EnemyUnit enemyUnit)
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			foreach (Intention intention in enemyUnit.Intentions)
			{
				bool flag4 = (intention is AddCardIntention || intention is AttackIntention || intention is ExplodeAllyIntention || intention is ExplodeIntention || intention is NegativeEffectIntention) && !flag;
				if (flag4)
				{
					flag = true;
					num++;
				}
				else
				{
					bool flag5 = (intention is ClearIntention || intention is DefendIntention || intention is EscapeIntention || intention is GrazeIntention || intention is HealIntention || intention is RepairIntention || intention is PositiveEffectIntention) && !flag2;
					if (flag5)
					{
						flag2 = true;
						num += 2;
					}
					else
					{
						bool flag6 = (intention is ChargeIntention || intention is DoNothingIntention || intention is HexIntention || intention is SleepIntention || intention is KokoroDarkIntention || intention is SpawnIntention || intention is StunIntention || intention is UnknownIntention) && !flag3;
						if (flag6)
						{
							flag3 = true;
							num += 4;
						}
						else
						{
							bool flag7 = intention is SpellCardIntention;
							if (flag7)
							{
								SpellCardIntention spellCardIntention = intention as SpellCardIntention;
								bool flag8 = spellCardIntention == null || spellCardIntention.Damage == null;
								if (flag8)
								{
									flag = true;
									num++;
								}
								flag3 = true;
								num += 4;
							}
						}
					}
				}
			}
			return num;
		}
	}
}
