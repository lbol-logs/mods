using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliFatesHandDef))]
	public sealed class PatchouliFatesHand : PatchouliBoostCard
	{
		public override ManaGroup AdditionalCost
		{
			get
			{
				return base.Mana * -base.Boost;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new DrawManyCardAction(base.Value1);
			base.ResetBoost();
			yield break;
		}
	}
}
