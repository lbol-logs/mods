using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.Cards.Starter;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeSpiritTalismanDef))]
	public sealed class SanaeSpiritTalisman : SampleCharacterCard
	{
		public int Value3
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				int num;
				if (isUpgraded)
				{
					num = this._upgradedValue3;
				}
				else
				{
					num = this._value3;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Spirit>(base.Value1, 0, 0, 0, 0.2f);
			List<SanaeSpiritTalisman> list = Library.CreateCards<SanaeSpiritTalisman>(2, this.IsUpgraded).ToList<SanaeSpiritTalisman>();
			SanaeSpiritTalisman first = list[0];
			SanaeSpiritTalisman sanaeSpiritTalisman = list[1];
			first.ShowWhichDescription = 1;
			sanaeSpiritTalisman.ShowWhichDescription = 2;
			first.SetBattle(base.Battle);
			sanaeSpiritTalisman.SetBattle(base.Battle);
			MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
			{
				Source = this
			};
			yield return new InteractionAction(interaction, false);
			bool flag = interaction.SelectedCard == first;
			if (flag)
			{
				yield return base.BuffAction<AmuletForCard>(this.Value3, 0, 0, 0, 0.2f);
			}
			else
			{
				yield return new AddCardsToHandAction(Library.CreateCards<SanaeStatus>(base.Value2, false), AddCardsType.Normal);
			}
			yield break;
		}

		private readonly int _value3 = 3;

		private readonly int _upgradedValue3 = 4;
	}
}
