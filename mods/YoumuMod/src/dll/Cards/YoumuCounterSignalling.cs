using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuCounterSignallingDef))]
	public sealed class YoumuCounterSignalling : YoumuCard
	{
		public override int AdditionalBlock
		{
			get
			{
				return base.GrowCount * base.Value1;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
			yield return base.DefenseAction(true);
			yield return base.BuffAction<YoumuRiposteSe>(riposteAmount, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
