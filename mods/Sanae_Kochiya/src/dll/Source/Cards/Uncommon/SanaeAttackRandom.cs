using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeAttackRandomDef))]
	public sealed class SanaeAttackRandom : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			List<SanaeAttackRandom> list = Library.CreateCards<SanaeAttackRandom>(2, this.IsUpgraded).ToList<SanaeAttackRandom>();
			SanaeAttackRandom first = list[0];
			SanaeAttackRandom sanaeAttackRandom = list[1];
			first.ShowWhichDescription = 1;
			sanaeAttackRandom.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeAttackRandom.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			base.CardGuns = new Guns(base.GunName, base.Value1, true);
			foreach (GunPair gunPair in base.CardGuns.GunPairs)
			{
				yield return base.AttackAction(selector, gunPair);
				gunPair = null;
			}
			List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				yield return new AddCardsToDrawZoneAction(Library.CreateCards<Chunguang>(base.Value2, false), DrawZoneTarget.Top, AddCardsType.Normal);
				yield return new GainManaAction(base.Mana);
			}
			yield break;
			yield break;
		}
	}
}
