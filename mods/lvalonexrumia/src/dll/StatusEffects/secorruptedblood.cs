using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(secorruptedbloodDef))]
	public sealed class secorruptedblood : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new EventSequencedReactor<ChangeLifeEventArgs>(this.OnLifeChanged));
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageReceived, new EventSequencedReactor<DamageEventArgs>(this.OnDamageReceived));
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && args.DamageInfo.Damage > 0f;
			if (flag)
			{
				foreach (BattleAction action in this.dosmth())
				{
					yield return action;
					action = null;
				}
				IEnumerator<BattleAction> enumerator = null;
			}
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = !base.Battle.BattleShouldEnd && (args.argsunit == base.Battle.Player || args.argsunit == null) && args.Amount < 0;
			if (flag)
			{
				foreach (BattleAction action in this.dosmth())
				{
					yield return action;
					action = null;
				}
				IEnumerator<BattleAction> enumerator = null;
			}
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> dosmth()
		{
			base.NotifyActivating();
			yield return new ApplyStatusEffectAction<sedarkblood>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
