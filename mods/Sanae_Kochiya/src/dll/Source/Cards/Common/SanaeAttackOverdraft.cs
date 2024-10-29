using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeAttackOverdraftDef))]
	public sealed class SanaeAttackOverdraft : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<SanaeAttackOverdraft> list = Library.CreateCards<SanaeAttackOverdraft>(2, this.IsUpgraded).ToList<SanaeAttackOverdraft>();
			SanaeAttackOverdraft first = list[0];
			SanaeAttackOverdraft sanaeAttackOverdraft = list[1];
			first.ShowWhichDescription = 1;
			sanaeAttackOverdraft.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeAttackOverdraft.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			yield return base.AttackAction(selector, null);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				yield return base.DefenseAction(true);
				yield return new LockRandomTurnManaAction(base.Value1);
			}
			yield break;
		}
	}
}
