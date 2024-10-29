using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.GunName;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.SampleCharacterUlt
{
	[EntityLogic(typeof(SanaeUltUDef))]
	public sealed class SanaeUltU : UltimateSkill
	{
		public SanaeUltU()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = GunNameID.GetGunFromId(13000);
		}

		public int GrowthCount
		{
			get
			{
				return base.GameRun.UltimateUseCount;
			}
		}

		private DamageInfo CalculateDamage()
		{
			bool flag = base.Battle == null || !base.Owner.HasStatusEffect<OmikujiBonusSe>();
			DamageInfo damageInfo;
			if (flag)
			{
				damageInfo = DamageInfo.Attack(base.Damage.Amount, true);
			}
			else
			{
				damageInfo = DamageInfo.Attack(base.Damage.Amount + (float)base.Owner.GetStatusEffect<OmikujiBonusSe>().Level, true);
			}
			return damageInfo;
		}

		public override DamageInfo Damage
		{
			get
			{
				return this.CalculateDamage();
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			Unit enemy = selector.GetEnemy(base.Battle);
			int rng = new List<int>
			{
				0, 0, 0, 0, 0, 1, 1, 1, 1, 2,
				2, 2, 3, 3, 4
			}.Sample(base.GameRun.BattleRng);
			yield return new DamageAction(base.Owner, enemy, this.Damage, GunNameID.GetGunFromId(13180 + rng), GunType.Single);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				ManaGroup manaGroup = ManaGroup.Single(ManaColors.Colors.Sample(base.GameRun.BattleRng));
				yield return new GainManaAction(manaGroup);
				num = i;
			}
			yield break;
		}
	}
}
