using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliSpellCreationWeakDef))]
	public sealed class PatchouliSpellCreationWeak : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				yield return base.DebuffAction<Weak>(unit, 0, base.Value2, 0, 0, true, 0.2f);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			yield break;
			yield break;
		}
	}
}
