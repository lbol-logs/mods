using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaChameleonHyperSpeedScratchDef))]
	public sealed class AyaChameleonHyperSpeedScratch : UltimateSkill
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AyaChameleonHyperSpeedScratch()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			return new AyaChameleonHyperSpeedScratch.<Actions>d__1(-2);
		}
	}
}
