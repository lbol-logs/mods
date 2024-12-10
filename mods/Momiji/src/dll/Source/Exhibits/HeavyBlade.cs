using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Exhibits
{
	[EntityLogic(typeof(HeavyBladeDef))]
	public sealed class HeavyBlade : ShiningExhibit
	{
		protected override void OnEnterBattle()
		{
			this.TriggeredEnemies.Clear();
			base.ReactBattleEvent<StatisticalDamageEventArgs>(base.Battle.Player.StatisticalTotalDamageDealt, new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnStatisticalDamageDealt));
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
				Unit unit2;
				IReadOnlyList<DamageEventArgs> readOnlyList;
				keyValuePair.Deconstruct(out unit2, out readOnlyList);
				Unit unit = unit2;
				IReadOnlyList<DamageEventArgs> dmg = readOnlyList;
				bool isAlive = unit.IsAlive;
				if (isAlive)
				{
					bool flag = dmg.Count(delegate(DamageEventArgs dmgArgs)
					{
						DamageInfo damageInfo = dmgArgs.DamageInfo;
						return damageInfo.DamageType == DamageType.Attack && damageInfo.Amount > 0f;
					}) > 0;
					if (flag)
					{
						bool flag2 = !this.TriggeredEnemies.Contains(unit);
						if (flag2)
						{
							bool flag3 = !activated;
							if (flag3)
							{
								base.NotifyActivating();
								activated = true;
							}
							this.TriggeredEnemies.Add(unit);
							yield return new ApplyStatusEffectAction<TempFirepowerNegative>(unit, new int?(base.Value1), null, null, null, 0f, true);
						}
					}
				}
				unit = null;
				dmg = null;
			}
			IEnumerator<KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>>> enumerator = null;
			yield break;
			yield break;
		}

		private readonly HashSet<Unit> TriggeredEnemies = new HashSet<Unit>();
	}
}
