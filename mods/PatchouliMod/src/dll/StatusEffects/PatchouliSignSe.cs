using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using PatchouliCharacterMod.BattleActions;

namespace PatchouliCharacterMod.StatusEffects
{
	public class PatchouliSignSe : StatusEffect
	{
		public virtual int BasePassive { get; set; } = 0;

		public virtual int BaseActive { get; set; } = 0;

		public virtual int BaseManaAmount { get; set; } = 1;

		public virtual bool AffectedByInt { get; set; } = true;

		public virtual bool AffectedByLevel { get; set; } = true;

		public virtual int Sign { get; set; } = 0;

		public static int TurnLimit { get; set; } = 3;

		public virtual int Multiplier { get; set; } = 1;

		public int PassiveAmount
		{
			get
			{
				return this.AmountFormula(this.BasePassive, false);
			}
		}

		public virtual int ActiveAmount
		{
			get
			{
				return this.AmountFormula(this.BaseActive, true);
			}
		}

		public int AmountFormula(int amount, bool isActive)
		{
			int num = (isActive ? this.ActiveDeltaAmount : this.PassiveDeltaAmount);
			return ((amount + (this.AffectedByInt ? this.IntelligenceBonusAmount : 0)) * (this.AffectedByLevel ? base.Level : 1) + num) * this.Multiplier;
		}

		public int Amount(bool isActive)
		{
			return isActive ? this.ActiveAmount : this.PassiveAmount;
		}

		public virtual ManaGroup Mana
		{
			get
			{
				return default(ManaGroup);
			}
		}

		public int IntelligenceBonusAmount
		{
			get
			{
				int num = 0;
				bool flag = base.Owner.HasStatusEffect<PatchouliIntelligenceSe>();
				if (flag)
				{
					num += base.Owner.GetStatusEffect<PatchouliIntelligenceSe>().Level;
				}
				bool flag2 = base.Owner.HasStatusEffect<PatchouliTemporaryIntelligenceSe>();
				if (flag2)
				{
					num += base.Owner.GetStatusEffect<PatchouliTemporaryIntelligenceSe>().Level;
				}
				return num;
			}
		}

		public int PassiveDeltaAmount { get; set; } = 0;

		public int ActiveDeltaAmount { get; set; } = 0;

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(base.Battle.Player.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnOwnerStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnOwnerStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			StatusEffect effect = args.Effect;
			PatchouliSignSe signSe = effect as PatchouliSignSe;
			bool flag = signSe != null && signSe.Sign == this.Sign;
			if (flag)
			{
				yield return new TriggerSignAction(this, false, true);
				base.NotifyChanged();
			}
			bool flag2 = args.Effect is PatchouliIntelligenceSe || args.Effect is PatchouliTemporaryIntelligenceSe;
			if (flag2)
			{
				base.NotifyChanged();
			}
			yield break;
		}

		public virtual IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			yield break;
		}

		public virtual IEnumerable<BattleAction> GainManaAction()
		{
			yield break;
		}

		protected IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.Count--;
			base.NotifyActivating();
			bool flag = base.Count > 0;
			if (flag)
			{
				yield return new TriggerSignAction(this, false, false);
			}
			else
			{
				yield return new TriggerSignAction(this, true, false);
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
