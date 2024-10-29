using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliForestBlazeDef))]
	public sealed class PatchouliForestBlaze : PatchouliCard
	{
		public override ManaGroup AdditionalCost
		{
			get
			{
				int num = 0;
				bool flag = base.Battle != null;
				if (flag)
				{
					foreach (StatusEffect statusEffect in base.Battle.Player.StatusEffects)
					{
						bool flag2 = statusEffect is PatchouliSignSe;
						if (flag2)
						{
							num++;
						}
					}
				}
				return base.Mana * -num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return base.BuffAction<PatchouliFireSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
				yield return base.BuffAction<PatchouliWoodSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
			}
			yield break;
		}
	}
}
