using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeSpellPowerDef))]
	public sealed class SanaeSpellPower : SampleCharacterCard
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
			yield return base.SacrificeAction(base.Value1);
			yield return new GainPowerAction(base.Value2);
			yield return base.DebuffAction(typeof(NextTurnLosePower), base.Battle.Player, 100, 0, 0, 0, false, 0.2f);
			yield break;
		}

		private readonly int _value3 = 100;

		private readonly int _upgradedValue3 = 100;
	}
}
