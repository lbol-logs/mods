using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellCreationBlockDef))]
	public sealed class PatchouliSpellCreationBlock : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			yield return base.DefenseAction(true);
			yield break;
		}
	}
}
