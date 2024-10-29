using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellCreationDrawDef))]
	public sealed class PatchouliSpellCreationDraw : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			yield return new DrawManyCardAction(base.Value1);
			yield break;
		}
	}
}
