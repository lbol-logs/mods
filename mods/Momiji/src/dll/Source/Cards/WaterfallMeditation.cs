using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(WaterfallMeditationDef))]
	public sealed class WaterfallMeditation : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			EnemyUnit selectedEnemy = selector.SelectedEnemy;
			int intention = base.IntentionCheck(selectedEnemy);
			bool flag = intention == 1 || intention == 3 || intention == 5 || intention == 7;
			if (flag)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, base.Block.Block, 0, BlockShieldType.Normal, true);
				yield return base.UpgradeRandomHandAction(base.Value2, CardType.Attack);
			}
			bool flag2 = intention == 2 || intention == 3 || intention == 6;
			if (flag2)
			{
				yield return new ApplyStatusEffectAction<Vulnerable>(selectedEnemy, new int?(0), new int?(base.Value1), new int?(0), new int?(0), 0.2f, true);
				yield return new ApplyStatusEffectAction<SpiritNegative>(selectedEnemy, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			bool flag3 = intention >= 4;
			if (flag3)
			{
				yield return new ApplyStatusEffectAction<Firepower>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			yield return new DrawManyCardAction(base.Value1);
			yield break;
		}
	}
}
