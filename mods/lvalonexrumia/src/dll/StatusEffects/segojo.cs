using System;
using System.Collections.Generic;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(segojoDef))]
	public sealed class segojo : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.HandleOwnerEvent<DamageEventArgs>(unit.DamageTaking, new GameEventHandler<DamageEventArgs>(this.OnDamageTaking));
			base.ReactOwnerEvent<GameEventArgs>(base.Battle.RoundEnded, new EventSequencedReactor<GameEventArgs>(this.OnTurnEnded));
		}

		private IEnumerable<BattleAction> OnTurnEnded(GameEventArgs args)
		{
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}

		private void OnDamageTaking(DamageEventArgs args)
		{
			int num = args.DamageInfo.Damage.RoundToInt();
			bool flag = num > 0;
			if (flag)
			{
				base.NotifyActivating();
				args.DamageInfo = args.DamageInfo.ReduceActualDamageBy(num);
				args.AddModifier(this);
			}
		}
	}
}
