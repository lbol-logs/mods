using System;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierSubterraneanAdventureSeDef))]
	public sealed class ReimuUnifierSubterraneanAdventureSe : StatusEffect
	{
		public int MaxHand
		{
			get
			{
				return 12;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = base.Battle.MaxHand < 12;
			if (flag)
			{
				base.Battle.MaxHand = this.MaxHand;
			}
		}
	}
}
