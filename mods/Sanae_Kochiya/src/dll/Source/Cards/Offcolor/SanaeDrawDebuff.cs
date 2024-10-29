using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeDrawDebuffDef))]
	public sealed class SanaeDrawDebuff : SampleCharacterCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<CardEventArgs>(base.Battle.CardDrawn, new EventSequencedReactor<CardEventArgs>(this.OnCardDrawn), (GameEventPriority)0);
		}

		private IEnumerable<BattleAction> OnCardDrawn(CardEventArgs args)
		{
			bool flag = base.Zone == CardZone.Hand && args.Cause != ActionCause.TurnStart;
			if (flag)
			{
				base.NotifyActivating();
				bool flag2 = !this.IsUpgraded;
				if (flag2)
				{
					yield return new GainManaAction(base.Mana);
				}
				else
				{
					ManaGroup manaGroup = ManaGroup.Single(ManaColors.Colors.Sample(base.GameRun.BattleRng));
					yield return new GainManaAction(manaGroup);
					manaGroup = default(ManaGroup);
				}
				yield break;
			}
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			yield return base.SacrificeAction(base.Value2);
			yield return base.BuffAction<CantDrawThisTurn>(0, 0, 0, 0, 0.2f);
			yield break;
		}
	}
}
