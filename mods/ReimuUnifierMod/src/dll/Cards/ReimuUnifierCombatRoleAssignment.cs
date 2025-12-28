using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierCombatRoleAssignmentDef))]
	public sealed class ReimuUnifierCombatRoleAssignment : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int AttackTimes = base.SummonedTeammatesOfColorInHand(ManaColor.Red) + 1;
			int DefenseTimes = base.SummonedTeammatesOfColorInHand(ManaColor.White) + 1;
			int AttackCounter = 0;
			int DefendCounter = 0;
			while (AttackCounter < AttackTimes || DefendCounter < DefenseTimes)
			{
				bool safetyCheck = false;
				bool flag = AttackCounter < AttackTimes;
				if (flag)
				{
					yield return base.AttackAction(base.Battle.RandomAliveEnemy, new DamageInfo(this.Damage.Damage, DamageType.Reaction, true, false, false), base.GunName);
					int num = AttackCounter;
					AttackCounter = num + 1;
					safetyCheck = true;
				}
				bool flag2 = DefendCounter < DefenseTimes;
				if (flag2)
				{
					yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, this.Block.Block, 0, BlockShieldType.Direct, DefendCounter == 0);
					int num = DefendCounter;
					DefendCounter = num + 1;
					safetyCheck = true;
				}
				bool flag3 = !safetyCheck;
				if (flag3)
				{
					AttackCounter = AttackTimes;
					DefendCounter = DefenseTimes;
					break;
				}
			}
			foreach (Card card in base.Battle.HandZone)
			{
				bool flag4 = card.Config.Colors.Contains(ManaColor.Red) && card.CardType == CardType.Friend && card.Summoned;
				if (flag4)
				{
					yield return new TeamUpAction(this, card);
				}
				else
				{
					bool flag5 = card.Config.Colors.Contains(ManaColor.White) && card.CardType == CardType.Friend && card.Summoned;
					if (flag5)
					{
						yield return new TeamUpAction(this, card);
					}
				}
				card = null;
			}
			IEnumerator<Card> enumerator = null;
			yield break;
			yield break;
		}
	}
}
