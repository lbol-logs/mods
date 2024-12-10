using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(AutumnViewDef))]
	public sealed class AutumnView : SampleCharacterCard
	{
		public override IEnumerable<BattleAction> OnDraw()
		{
			return this.EnterHandReactor();
		}

		public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
		{
			bool flag = dstZone != CardZone.Hand;
			IEnumerable<BattleAction> enumerable;
			if (flag)
			{
				enumerable = null;
			}
			else
			{
				enumerable = this.EnterHandReactor();
			}
			return enumerable;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			bool flag = base.Zone == CardZone.Hand;
			if (flag)
			{
				base.React(this.EnterHandReactor());
			}
		}

		private IEnumerable<BattleAction> EnterHandReactor()
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new CastBlockShieldAction(base.Battle.Player, 0, base.Value1, BlockShieldType.Normal, true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				foreach (BattleAction battleAction in base.DebuffAction<FirepowerNegative>(base.Battle.AllAliveEnemies, base.Value2, 0, 0, 0, true, 0.2f))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
			}
			yield return new ExileCardAction(this);
			yield break;
			yield break;
		}
	}
}
