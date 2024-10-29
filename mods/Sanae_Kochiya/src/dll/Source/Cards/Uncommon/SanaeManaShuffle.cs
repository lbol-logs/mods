using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeManaShuffleDef))]
	public sealed class SanaeManaShuffle : SampleCharacterCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(base.Battle.Reshuffling, new EventSequencedReactor<GameEventArgs>(this.Reshuffling));
		}

		private IEnumerable<BattleAction> Reshuffling(GameEventArgs args)
		{
			bool flag = base.Zone == CardZone.Exile;
			if (flag)
			{
				yield return new MoveCardAction(this, CardZone.Hand);
			}
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			yield return new GainManaAction(base.Mana);
			yield break;
		}
	}
}
