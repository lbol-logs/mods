using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeWardAmuletDef))]
	public sealed class SanaeWardAmulet : SampleCharacterCard
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
			bool flag = base.Battle.Player.HasStatusEffect<Amulet>();
			if (flag)
			{
				yield return base.DebuffAction<Fragil>(base.Battle.Player, 0, 1, 0, 0, true, 0.2f);
				yield return base.BuffAction<AmuletForCard>(base.Value2, 0, 0, 0, 0.2f);
			}
			else
			{
				yield return base.BuffAction<AmuletForCard>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}

		private readonly int _value3 = 1;

		private readonly int _upgradedValue3 = 1;
	}
}
