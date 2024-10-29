using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliGreenStormDef))]
	public sealed class PatchouliGreenStorm : PatchouliBoostCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Boost > 1;
			if (flag)
			{
				base.CardGuns = new Guns(base.GunName, base.Boost + 1, false);
				foreach (GunPair gunPair in base.CardGuns.GunPairs)
				{
					yield return base.AttackAction(selector, gunPair);
					gunPair = null;
				}
				List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			}
			else
			{
				yield return base.AttackAction(selector, base.GunName);
			}
			base.ResetBoost();
			yield break;
			yield break;
		}
	}
}
