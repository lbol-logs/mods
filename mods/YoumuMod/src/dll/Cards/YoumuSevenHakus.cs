using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSevenHakusDef))]
	public sealed class YoumuSevenHakus : YoumuCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int riposteAmount = base.Battle.CalculateBlockShield(this, (float)base.Block.Block, 0f, BlockShieldType.Normal).Item1;
			yield return base.DefenseAction(true);
			yield return base.BuffAction<YoumuRiposteSe>(riposteAmount, 0, 0, 0, 0.2f);
			yield return base.BuffAction<Reflect>(base.Value1, 0, 0, 0, 0.2f);
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return base.BuffAction<TurnStartDontLoseBlock>(base.Value2, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
