using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.GunName;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.SampleCharacterUlt
{
	[EntityLogic(typeof(SanaeUltWDef))]
	public sealed class SanaeUltW : UltimateSkill
	{
		public SanaeUltW()
		{
			base.TargetType = TargetType.AllEnemies;
			base.GunName = GunNameID.GetGunFromId(39050);
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
			Unit[] targets = selector.GetUnits(base.Battle);
			yield return new DamageAction(base.Owner, targets, this.Damage, base.GunName, GunType.Single);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new ApplyStatusEffectAction<AmuletForCard>(base.Owner, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<Amulet>(base.Owner, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}
	}
}
