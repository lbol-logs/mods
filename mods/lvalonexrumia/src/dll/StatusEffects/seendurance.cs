using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seenduranceDef))]
	public sealed class seendurance : sereact
	{
		protected override void dosmth()
		{
			base.Highlight = base.Owner.Hp < base.lifeneed;
		}

		protected override void OnHealingReceived(HealEventArgs args)
		{
			this.dosmth();
		}

		protected override IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = base.Count > 0;
			if (flag)
			{
				base.NotifyActivating();
				yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Count, false), AddCardsType.Normal);
			}
			base.Count = 0;
			yield break;
		}

		protected override IEnumerable<BattleAction> HandleLifeChanged(Unit receive, int amount, Unit source, ActionCause cause, GameEntity actionSource)
		{
			base.Highlight = base.Owner.Hp < base.lifeneed;
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = actionSource != this && amount < 0 && (receive == null || receive == base.Battle.Player) && !base.Battle.BattleShouldEnd && base.Battle.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
			if (flag)
			{
				base.NotifyActivating();
				base.Count += base.Level;
			}
			yield break;
		}
	}
}
