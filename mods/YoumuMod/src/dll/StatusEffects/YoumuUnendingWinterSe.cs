using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Cirno;
using LBoLEntitySideloader.Attributes;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuUnendingWinterSeDef))]
	public sealed class YoumuUnendingWinterSe : StatusEffect
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
						int i = 0;
						while (i < base.Level && !base.Battle.BattleShouldEnd)
						{
							yield return new ApplyStatusEffectAction<Cold>(unit2, null, null, null, null, 0f, true);
							int num2 = i;
							i = num2 + 1;
						}
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
