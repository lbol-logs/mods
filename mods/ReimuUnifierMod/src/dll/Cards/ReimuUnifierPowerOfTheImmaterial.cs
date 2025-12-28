using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierPowerOfTheImmaterialDef))]
	public sealed class ReimuUnifierPowerOfTheImmaterial : ReimuUnifierCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int HitNumber = base.Value2;
			bool flag = base.TeamUpCheck<ReimuUnifierSuikaGourdOniFriend>();
			if (flag)
			{
				yield return base.BuffAction<TempFirepower>(base.Value1, 0, 0, 0, 0.2f);
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierSuikaGourdOniFriend)));
			}
			bool flag2 = base.Battle.Player.HasStatusEffect<TempFirepower>();
			if (flag2)
			{
				int num = HitNumber;
				HitNumber = num + 1;
			}
			base.CardGuns = new Guns(base.GunName, HitNumber, true);
			foreach (GunPair gunPair in base.CardGuns.GunPairs)
			{
				yield return base.AttackAction(selector, gunPair.GunName);
				gunPair = null;
			}
			List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			yield break;
			yield break;
		}
	}
}
