using System;
using System.Collections.Generic;
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
	[EntityLogic(typeof(ReimuUnifierCoordinatedStrikeDef))]
	public sealed class ReimuUnifierCoordinatedStrike : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.SummonedTeammatesOfColorInHand(ManaColor.Red) > 0;
			if (flag)
			{
				base.CardGuns = new Guns(base.GunName, base.Value1, false);
				foreach (GunPair gunPair in base.CardGuns.GunPairs)
				{
					yield return base.AttackAction(selector, gunPair);
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return new GainManaAction(base.Mana);
				}
				yield return new TeamUpAction(this, base.TeamUpColorCard(ManaColor.Red));
				yield break;
			}
			yield return base.AttackAction(selector, base.GunName);
			yield break;
			yield break;
		}
	}
}
