using System;
using LBoL.Core;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using UnityEngine;

namespace Momiji.Source.StatusEffects
{
	[EntityLogic(typeof(FragilForEnemiesDef))]
	public sealed class FragilForEnemies : StatusEffect
	{
		public int Value
		{
			get
			{
				GameRunController gameRun = base.GameRun;
				bool flag = gameRun == null || !(base.Owner is EnemyUnit);
				int num;
				if (flag)
				{
					num = 30;
				}
				else
				{
					num = Math.Min(30 + gameRun.FragilExtraPercentage, 100);
				}
				return num;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = unit is PlayerUnit;
			if (flag)
			{
				base.HandleOwnerEvent<BlockShieldEventArgs>(unit.BlockShieldGaining, new GameEventHandler<BlockShieldEventArgs>(this.OnBlockGaining));
			}
			else
			{
				Debug.LogError(this.Name + " added to enemy " + unit.Name + ", which has no effect.");
			}
		}

		private void OnBlockGaining(BlockShieldEventArgs args)
		{
			float num = 1f - (float)this.Value / 100f;
			bool flag = args.Type == BlockShieldType.Direct;
			if (!flag)
			{
				args.Block *= num;
				args.Shield *= num;
			}
		}
	}
}
