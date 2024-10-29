using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuWatchtowerSwordSeDef))]
	public sealed class YoumuWatchtowerSwordSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatisticalDamageEventArgs>(base.Battle.Player.StatisticalTotalDamageDealt, new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnStatisticalDamageDealt));
		}

		private IEnumerable<BattleAction> OnStatisticalDamageDealt(StatisticalDamageEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool activated = false;
			foreach (KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>> keyValuePair in args.ArgsTable)
			{
				Unit unit;
				IReadOnlyList<DamageEventArgs> readOnlyList;
				keyValuePair.Deconstruct(out unit, out readOnlyList);
				Unit unit2 = unit;
				IReadOnlyList<DamageEventArgs> readOnlyList2 = readOnlyList;
				bool isAlive = unit2.IsAlive;
				if (isAlive)
				{
					int num = readOnlyList2.Count(delegate(DamageEventArgs damageAgs)
					{
						DamageInfo damageInfo = damageAgs.DamageInfo;
						return damageInfo.DamageType == DamageType.Attack && damageInfo.Amount > 0f;
					});
					bool flag = num > 0;
					if (flag)
					{
						bool flag2 = !activated;
						if (flag2)
						{
							base.NotifyActivating();
							activated = true;
						}
						yield return new ApplyStatusEffectAction<LockedOn>(unit2, new int?(base.Level * num), null, null, null, 0f, true);
					}
				}
				unit = null;
				readOnlyList = null;
				unit2 = null;
				readOnlyList2 = null;
				keyValuePair = default(KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>>);
			}
			IEnumerator<KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>>> enumerator = null;
			yield break;
			yield break;
		}
	}
}
