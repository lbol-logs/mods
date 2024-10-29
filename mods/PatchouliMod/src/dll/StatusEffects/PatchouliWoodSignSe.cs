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
using PatchouliCharacterMod.GunName;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliWoodSignSeDef))]
	public sealed class PatchouliWoodSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 4;

		public override int BaseActive { get; set; } = 4;

		public override int Sign { get; set; } = 2;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Green = this.BaseManaAmount
				};
			}
		}

		public override int ActiveAmount
		{
			get
			{
				int num = 0;
				bool flag = base.Battle.Player.HasStatusEffect<PatchouliSatelliteHimawariSe>();
				if (flag)
				{
					PatchouliSatelliteHimawariSe statusEffect = base.Battle.Player.GetStatusEffect<PatchouliSatelliteHimawariSe>();
					num += statusEffect.BonusDamage;
				}
				return base.ActiveAmount + num;
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			EnemyUnit enemyUnitWithMaxHP = base.Battle.EnemyGroup.Alives.MaxBy((EnemyUnit unit) => unit.Hp);
			bool flag = base.Battle.Player.HasStatusEffect<PatchouliWoodSignSe>();
			if (flag)
			{
				bool flag2 = !isActive;
				if (flag2)
				{
					base.Battle.Player.GetStatusEffect<PatchouliWoodSignSe>().ActiveDeltaAmount += base.Amount(isActive);
					base.NotifyChanged();
				}
				else
				{
					yield return new DamageAction(base.Battle.Player, enemyUnitWithMaxHP, DamageInfo.Reaction((float)base.Amount(isActive), false), PatchouliGunName.WoodSign, GunType.Single);
				}
			}
			yield break;
		}
	}
}
