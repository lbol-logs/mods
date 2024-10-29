using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliEmeraldMegalithDef))]
	public sealed class PatchouliEmeraldMegalith : PatchouliCard
	{
		public override bool Triggered
		{
			get
			{
				bool flag = base.Battle != null;
				bool flag3;
				if (flag)
				{
					int num = 0;
					foreach (StatusEffect statusEffect in base.Battle.Player.StatusEffects)
					{
						bool flag2 = statusEffect is PatchouliSignSe;
						if (flag2)
						{
							num++;
						}
					}
					flag3 = num >= base.Value1;
				}
				else
				{
					flag3 = false;
				}
				return flag3;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool playInTriggered = base.PlayInTriggered;
			if (playInTriggered)
			{
				yield return new TriggerAllSignsPassiveAction();
			}
			yield break;
		}
	}
}
