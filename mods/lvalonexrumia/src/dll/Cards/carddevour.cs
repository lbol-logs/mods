using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(carddevourDef))]
	public sealed class carddevour : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
		}

		private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
		{
			bool flag = args.DieSource == this && !args.Unit.HasStatusEffect<Servant>();
			if (flag)
			{
				base.NotifyActivating();
				base.GameRun.SetHpAndMaxHp(base.GameRun.Player.Hp + this.heal, base.GameRun.Player.MaxHp + this.heal, true);
				Card deckCardByInstanceId = base.GameRun.GetDeckCardByInstanceId(base.InstanceId);
				bool flag2 = deckCardByInstanceId != null;
				if (flag2)
				{
					base.GameRun.RemoveDeckCard(deckCardByInstanceId, false);
				}
				yield return new RemoveCardAction(this);
				deckCardByInstanceId = null;
			}
			yield break;
		}
	}
}
