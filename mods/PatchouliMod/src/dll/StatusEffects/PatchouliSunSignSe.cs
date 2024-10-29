using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.GunName;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliSunSignSeDef))]
	public sealed class PatchouliSunSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 2;

		public override int BaseActive { get; set; } = 4;

		public override int Sign { get; set; } = 5;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					White = this.BaseManaAmount
				};
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, DamageInfo.Reaction((float)base.Amount(isActive), false), PatchouliGunName.SunSign, GunType.Single);
			yield break;
		}
	}
}
