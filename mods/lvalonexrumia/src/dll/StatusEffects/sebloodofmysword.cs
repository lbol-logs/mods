using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sebloodofmyswordDef))]
	public sealed class sebloodofmysword : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnDamageDealt));
		}

		private IEnumerable<BattleAction> OnDamageDealt(DamageEventArgs args)
		{
			bool flag = args.Target.IsNotAlive || args.Target.Hp == 0 || args.DamageInfo.DamageType != DamageType.Attack;
			if (flag)
			{
				yield break;
			}
			yield return new ChangeLifeAction(base.Level, args.Target);
			yield return new ApplyStatusEffectAction<TempFirepower>(base.Owner, new int?(base.Level), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
