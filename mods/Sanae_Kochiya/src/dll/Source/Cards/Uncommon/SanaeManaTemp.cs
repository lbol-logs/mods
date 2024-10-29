using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeManaTempDef))]
	public sealed class SanaeManaTemp : SampleCharacterCard
	{
		public int Value3
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				int num;
				if (isUpgraded)
				{
					num = this._upgradedValue3;
				}
				else
				{
					num = this._value3;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = base.Battle.HandZone.Count >= this.Value3 - 1;
			if (flag)
			{
				yield return base.BuffAction<TempSpirit>(base.Value2, 0, 0, 0, 0.2f);
				yield return base.BuffAction<Spirit>(base.Value2, 0, 0, 0, 0.2f);
				yield return new DrawManyCardAction(base.Value2);
			}
			else
			{
				yield return base.BuffAction<TempSpirit>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}

		private readonly int _value3 = 9;

		private readonly int _upgradedValue3 = 9;
	}
}
