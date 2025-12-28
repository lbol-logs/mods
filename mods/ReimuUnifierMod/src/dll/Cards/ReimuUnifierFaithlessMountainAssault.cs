using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierFaithlessMountainAssaultDef))]
	public sealed class ReimuUnifierFaithlessMountainAssault : ReimuUnifierCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
		}

		private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
		{
			bool flag = args.DieSource == this && !args.Unit.HasStatusEffect<Servant>();
			if (flag)
			{
				yield return new AddCardsToDeckAction(Library.CreateCards<ReimuUnifierConsumedByVengeanceMisfortuneToken>(1, false));
			}
			yield break;
		}
	}
}
