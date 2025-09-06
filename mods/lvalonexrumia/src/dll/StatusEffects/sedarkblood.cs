using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sedarkbloodDef))]
	public sealed class sedarkblood : StatusEffect
	{
		public ManaGroup mana
		{
			get
			{
				return ManaGroup.Blacks(1);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.Highlight = true;
			this.go = false;
			this.turnending = false;
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnding, new GameEventHandler<UnitEventArgs>(this.OnTurnEnding));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
			base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, new GameEventHandler<UnitEventArgs>(this.OnOwnerTurnStarting));
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			bool flag = this.go;
			if (flag)
			{
				foreach (BattleAction action in this.dosmth())
				{
					yield return action;
					action = null;
				}
				IEnumerator<BattleAction> enumerator = null;
				this.go = false;
			}
			this.turnending = false;
			yield break;
			yield break;
		}

		private void OnTurnEnding(UnitEventArgs args)
		{
			this.turnending = true;
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Highlight && args.DamageInfo.Damage > 0f;
			if (flag)
			{
				bool flag2 = this.turnending;
				if (flag2)
				{
					this.go = true;
				}
				else
				{
					foreach (BattleAction action in this.dosmth())
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
				}
			}
			yield break;
			yield break;
		}

		private void OnOwnerTurnStarting(UnitEventArgs args)
		{
			base.Highlight = true;
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && base.Highlight && (args.argsunit == base.Battle.Player || args.argsunit == null) && args.Amount < 0;
			if (flag)
			{
				bool flag2 = this.turnending;
				if (flag2)
				{
					this.go = true;
				}
				else
				{
					foreach (BattleAction action in this.dosmth())
					{
						yield return action;
						action = null;
					}
					IEnumerator<BattleAction> enumerator = null;
				}
			}
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> dosmth()
		{
			base.NotifyActivating();
			bool flag = base.Level <= 0;
			if (flag)
			{
				base.Level = 0;
				yield break;
			}
			int level = base.Level;
			base.Level = level - 1;
			base.Highlight = false;
			bool flag2 = base.Battle.HandZone.Count < base.Battle.MaxHand;
			if (flag2)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<carddarkblood>(1, false), AddCardsType.Normal);
				bool flag3 = base.Level <= 0;
				if (flag3)
				{
					base.Level = 0;
					yield break;
				}
			}
			yield return new GainManaAction(ManaGroup.Blacks(base.Level));
			base.Level = 0;
			yield break;
		}

		private bool go = false;

		private bool turnending = false;
	}
}
