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
	[EntityLogic(typeof(PatchouliFireSignSeDef))]
	public sealed class PatchouliFireSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 3;

		public override int BaseActive { get; set; } = 5;

		public override int Sign { get; set; } = 0;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Red = this.BaseManaAmount
				};
			}
		}

		public override int Multiplier
		{
			get
			{
				int num = 1;
				bool flag = base.Battle.Player.HasStatusEffect<PatchouliKoakumaFriendSe>();
				if (flag)
				{
					num += base.Battle.Player.GetStatusEffect<PatchouliKoakumaFriendSe>().Level;
				}
				return num;
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			EnemyUnit enemyUnitWithMinHP = base.Battle.EnemyGroup.Alives.MinBy((EnemyUnit unit) => unit.Hp);
			int fireDamageMultiplier = 1;
			bool flag = base.Battle.Player.HasStatusEffect<PatchouliKoakumaFriendSe>();
			if (flag)
			{
				fireDamageMultiplier += base.Battle.Player.GetStatusEffect<PatchouliKoakumaFriendSe>().Level;
			}
			yield return new DamageAction(base.Battle.Player, enemyUnitWithMinHP, DamageInfo.Reaction((float)(base.Amount(isActive) * fireDamageMultiplier), false), PatchouliGunName.FireSign, GunType.Single);
			yield break;
		}
	}
}
