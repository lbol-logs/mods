using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Momiji.Source.GunName;

namespace Momiji.Source.Ultimate
{
	[EntityLogic(typeof(ExpelleesCananDef))]
	public sealed class ExpelleesCanan : UltimateSkill
	{
		public ExpelleesCanan()
		{
			base.TargetType = TargetType.AllEnemies;
			base.GunName = GunNameID.GetGunFromId(4158);
		}

		public BlockInfo Block
		{
			get
			{
				return new BlockInfo(base.Value2, BlockShieldType.Normal);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			Unit[] targets = selector.GetUnits(base.Battle);
			yield return PerformAction.Spell(base.Owner, "ExpelleesCanan");
			yield return new CastBlockShieldAction(base.Owner, base.Owner, this.Block, false);
			yield return new DamageAction(base.Owner, targets, this.Damage, base.GunName, GunType.Single);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			foreach (Unit unit in targets)
			{
				bool isAlive = unit.IsAlive;
				if (isAlive)
				{
					yield return new ApplyStatusEffectAction<FirepowerNegative>(unit, new int?(base.Value1), null, null, null, 0f, true);
				}
				unit = null;
			}
			Unit[] array = null;
			yield break;
		}
	}
}
