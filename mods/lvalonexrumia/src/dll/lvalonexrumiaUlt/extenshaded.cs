using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace lvalonexrumia.lvalonexrumiaUlt
{
	[EntityLogic(typeof(extenshadedDef))]
	public sealed class extenshaded : UltimateSkill
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield break;
		}
	}
}
