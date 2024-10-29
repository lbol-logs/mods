using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliWaterSignSeDef))]
	public sealed class PatchouliWaterSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 1;

		public override int BaseActive { get; set; } = 3;

		public override int Sign { get; set; } = 1;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Blue = this.BaseManaAmount
				};
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, 0, base.Amount(isActive), BlockShieldType.Direct, true);
			yield break;
		}
	}
}
