using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliMoonSignSeDef))]
	public sealed class PatchouliMoonSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 2;

		public override int BaseActive { get; set; } = 4;

		public override int Sign { get; set; } = 6;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Black = this.BaseManaAmount
				};
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, base.Amount(isActive), 0, BlockShieldType.Direct, true);
			yield break;
		}
	}
}
