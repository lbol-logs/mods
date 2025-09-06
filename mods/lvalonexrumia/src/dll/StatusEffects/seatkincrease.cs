using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seatkincreaseDef))]
	public sealed class seatkincrease : StatusEffect
	{
		public int truecounter
		{
			get
			{
				return this.truecount;
			}
		}

		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = this.truecount == 0;
			if (flag)
			{
				this.truecount = base.Level;
				base.Count = this.truecount;
			}
			base.Level = 0;
			base.HandleOwnerEvent<DamageDealingEventArgs>(base.Owner.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
			base.HandleOwnerEvent<StatusEffectApplyEventArgs>(base.Owner.StatusEffectAdded, new GameEventHandler<StatusEffectApplyEventArgs>(this.OnStatusEffectAdded));
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
		}

		private void OnStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is seatkincrease;
			if (flag)
			{
				this.truecount += args.Effect.Level;
				base.Count = this.truecount;
				base.Level = 0;
			}
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			this.truecount = (int)((double)this.truecount / 10.0) * 5;
			base.Count = this.truecount;
			bool flag = base.Count <= 0;
			if (flag)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			base.NotifyActivating();
			yield break;
		}

		private void OnDamageDealing(DamageDealingEventArgs args)
		{
			bool flag = args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				args.DamageInfo = args.DamageInfo.MultiplyBy((float)this.truecount * 1f / 100f + 1f);
				args.AddModifier(this);
				bool flag2 = args.Cause != ActionCause.OnlyCalculate;
				if (flag2)
				{
					base.NotifyActivating();
				}
			}
		}

		private int truecount = 0;
	}
}
