using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Patches;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuWaterfowlDanceDef))]
	public sealed class YoumuWaterfowlDance : YoumuCard
	{
		public int UnsheathedThisTurn { get; set; } = 0;

		public int UnsheathedThreshold1 { get; set; } = 1;

		public int UnsheathedThreshold2 { get; set; } = 2;

		public int UnsheathedThreshold3 { get; set; } = 3;

		public override bool HasDisplayField { get; set; } = true;

		public override int DisplayField
		{
			get
			{
				return this.UnsheathedThisTurn;
			}
		}

		public override bool Triggered
		{
			get
			{
				return this.UnsheathedThisTurn >= this.UnsheathedThreshold1;
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(CustomGameEventPatch.Unsheathed, new EventSequencedReactor<GameEventArgs>(this.OnUnsheathe));
			base.ReactBattleEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
		}

		private IEnumerable<BattleAction> OnUnsheathe(GameEventArgs args)
		{
			int unsheathedThisTurn = this.UnsheathedThisTurn;
			this.UnsheathedThisTurn = unsheathedThisTurn + 1;
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
		{
			this.UnsheathedThisTurn = 0;
			yield break;
		}

		public override int AdditionalValue1
		{
			get
			{
				bool flag = this.UnsheathedThisTurn >= this.UnsheathedThreshold2;
				int num;
				if (flag)
				{
					num = 1;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			base.CardGuns = new Guns(base.GunName, base.Value1, false);
			foreach (GunPair gunPair in base.CardGuns.GunPairs)
			{
				yield return base.AttackAction(selector, gunPair);
				gunPair = null;
			}
			List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			bool flag = this.UnsheathedThisTurn >= this.UnsheathedThreshold1;
			if (flag)
			{
				yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, base.Value2, 0, 0, 0, true, 0.2f);
			}
			bool flag2 = this.UnsheathedThisTurn >= this.UnsheathedThreshold3;
			if (flag2)
			{
				yield return new GainManaAction(base.Mana);
			}
			yield break;
			yield break;
		}
	}
}
