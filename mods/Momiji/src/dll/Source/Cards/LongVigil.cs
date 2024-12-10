using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(LongVigilDef))]
	public sealed class LongVigil : SampleCharacterCard
	{
		public override Interaction Precondition()
		{
			bool isUpgraded = this.IsUpgraded;
			Interaction interaction;
			if (isUpgraded)
			{
				List<Card> list = (from card in base.Battle.HandZone.Concat(base.Battle.DrawZoneToShow).Concat(base.Battle.DiscardZone)
					where card != this
					select card).ToList<Card>();
				bool flag = !list.Empty<Card>();
				if (flag)
				{
					interaction = new SelectCardInteraction(0, base.Value1, list, SelectedCardHandling.DoNothing);
				}
				else
				{
					interaction = null;
				}
			}
			else
			{
				List<Card> list2 = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				bool flag2 = !list2.Empty<Card>();
				if (flag2)
				{
					interaction = new SelectHandInteraction(0, base.Value1, list2);
				}
				else
				{
					interaction = null;
				}
			}
			return interaction;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition != null;
			if (flag)
			{
				IReadOnlyList<Card> readOnlyList = (this.IsUpgraded ? ((SelectCardInteraction)precondition).SelectedCards : ((SelectHandInteraction)precondition).SelectedCards);
				bool flag2 = readOnlyList.Count > 0;
				if (flag2)
				{
					yield return new ExileManyCardAction(readOnlyList);
					this.count = readOnlyList.Count;
				}
				readOnlyList = null;
			}
			int num;
			for (int i = 0; i < this.count; i = num + 1)
			{
				yield return new CastBlockShieldAction(base.Battle.Player, base.Block.Block, 0, BlockShieldType.Normal, true);
				num = i;
			}
			yield break;
		}

		private int count = 0;
	}
}
