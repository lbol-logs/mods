using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierMaidensDivineChannelingDef))]
	public sealed class ReimuUnifierMaidensDivineChanneling : ReimuUnifierCard
	{
		protected override int AdditionalShield
		{
			get
			{
				return 2 * base.Battle.Player.StatusEffects.Where((StatusEffect status) => status.Type == StatusEffectType.Positive).Count<StatusEffect>();
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.TeamUpCheck<ReimuUnifierSanaeHumanGodFriend>();
			if (flag)
			{
				yield return base.BuffAction<Amulet>(1, 0, 0, 0, 0.2f);
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierSanaeHumanGodFriend)));
			}
			yield return new CastBlockShieldAction(base.Battle.Player, this.Block, base.Shield, true);
			yield break;
		}
	}
}
