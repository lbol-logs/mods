using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierFierceGodWillOWispDef))]
	public sealed class ReimuUnifierFierceGodWillOWisp : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool accuracy = base.Battle.HandZone.Count((Card card) => card.CardType == CardType.Friend && card.Summoned && card.BaseCost.HasColor(ManaColor.Red)) > 0;
			base.IsAccuracy = accuracy;
			bool flag = base.SummonedTeammatesOfColorInHand(ManaColor.White) > 0;
			if (flag)
			{
				base.CardGuns = new Guns(base.GunName, base.Value1 + 1, false);
				foreach (GunPair gunPair in base.CardGuns.GunPairs)
				{
					bool flag2 = !base.Battle.BattleShouldEnd;
					if (flag2)
					{
						yield return base.AttackAction(selector, gunPair);
					}
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
				base.IsAccuracy = false;
				yield return new TeamUpAction(this, base.TeamUpColorCard(ManaColor.White));
			}
			else
			{
				base.CardGuns = new Guns(base.GunName, base.Value1, false);
				foreach (GunPair gunPair2 in base.CardGuns.GunPairs)
				{
					bool flag3 = !base.Battle.BattleShouldEnd;
					if (flag3)
					{
						yield return base.AttackAction(selector, gunPair2);
					}
					gunPair2 = null;
				}
				List<GunPair>.Enumerator enumerator2 = default(List<GunPair>.Enumerator);
				base.IsAccuracy = false;
			}
			bool flag4 = accuracy;
			if (flag4)
			{
				yield return new TeamUpAction(this, base.TeamUpColorCard(ManaColor.Red));
			}
			yield break;
			yield break;
		}
	}
}
