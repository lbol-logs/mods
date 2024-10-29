using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Common
{
	[EntityLogic(typeof(SanaeScryPowerDef))]
	public sealed class SanaeScryPower : SampleCharacterCard
	{
		private string ExtraDescription1
		{
			get
			{
				bool isUpgraded = this.IsUpgraded;
				string text;
				if (isUpgraded)
				{
					text = this.LocalizeProperty("UpgradedExtraDescription1", true, true);
				}
				else
				{
					text = this.LocalizeProperty("ExtraDescription1", true, true);
				}
				return text;
			}
		}

		protected override string GetBaseDescription()
		{
			bool flag = !base.DebutActive;
			string text;
			if (flag)
			{
				text = this.ExtraDescription1;
			}
			else
			{
				text = base.GetBaseDescription();
			}
			return text;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ScryAction(base.Scry);
			bool playInTriggered = base.PlayInTriggered;
			if (playInTriggered)
			{
				yield return new GainPowerAction(base.Value1);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					base.DecreaseBaseCost(base.Mana);
				}
			}
			yield break;
		}
	}
}
