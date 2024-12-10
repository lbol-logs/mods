using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;

namespace Momiji.Source.Cards
{
	[EntityLogic(typeof(HuntingHurricanesDef))]
	public sealed class HuntingHurricanes : SampleCharacterCard
	{
		private int AirCutterCount
		{
			get
			{
				bool flag = base.Battle != null;
				int num;
				if (flag)
				{
					num = base.Battle.ExileZone.OfType<AirCutter>().Count<AirCutter>();
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			int num;
			for (int i = 0; i < this.AirCutterCount; i = num + 1)
			{
				yield return base.AttackAction(selector, base.GunName);
				num = i;
			}
			yield break;
		}
	}
}
