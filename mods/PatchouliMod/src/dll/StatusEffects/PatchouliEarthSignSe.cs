using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliEarthSignSeDef))]
	public sealed class PatchouliEarthSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 1;

		public override int BaseActive { get; set; } = 2;

		public override int Sign { get; set; } = 4;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Philosophy = this.BaseManaAmount
				};
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			yield return ConvertManaAction.PhilosophyRandomMana(base.Battle.BattleMana, base.Amount(isActive), base.Battle.GameRun.BattleRng);
			yield break;
		}
	}
}
