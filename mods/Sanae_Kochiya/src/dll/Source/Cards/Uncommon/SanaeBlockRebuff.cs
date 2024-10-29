using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeBlockRebuffDef))]
	public sealed class SanaeBlockRebuff : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool flag = base.Battle.Player.HasStatusEffect<Amulet>();
			if (flag)
			{
				yield return base.DebuffAction<Weak>(base.Battle.Player, 0, base.Value1, 0, 0, true, 0.2f);
				foreach (BattleAction battleAction in base.DebuffAction<Weak>(base.Battle.AllAliveEnemies, 0, base.Value2, 0, 0, true, 0.1f))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
			}
			yield break;
			yield break;
		}
	}
}
