using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierPurifyingStrikeDef))]
	public sealed class ReimuUnifierPurifyingStrike : ReimuUnifierCard
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Cause == ActionCause.Card && args.ActionSource == this;
			if (flag)
			{
				DamageInfo damageInfo = args.DamageInfo;
				int PlayerDebuffs = base.Battle.Player.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Negative).Count<StatusEffect>();
				bool flag2 = damageInfo.Damage > 0f && PlayerDebuffs > 0;
				if (flag2)
				{
					float damage = damageInfo.Damage - damageInfo.DamageBlocked - damageInfo.DamageShielded;
					int DebuffsCleared = (int)Math.Truncate((double)(damage / 10f));
					List<StatusEffect> StatusesToRemove = base.Battle.Player.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Negative).ToList<StatusEffect>();
					StatusesToRemove.Shuffle(new RandomGen());
					int i = 0;
					while (i < DebuffsCleared && i < PlayerDebuffs)
					{
						yield return new RemoveStatusEffectAction(StatusesToRemove[i], true, 0.1f);
						int num = i;
						i = num + 1;
					}
					StatusesToRemove = null;
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
