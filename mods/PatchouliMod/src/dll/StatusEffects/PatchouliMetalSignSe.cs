using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliMetalSignSeDef))]
	public sealed class PatchouliMetalSignSe : PatchouliSignSe
	{
		public override int BasePassive { get; set; } = 3;

		public override int BaseActive { get; set; } = 5;

		public override int Sign { get; set; } = 3;

		public override ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Colorless = this.BaseManaAmount
				};
			}
		}

		public override IEnumerable<BattleAction> SignAction(bool isActive = false)
		{
			base.NotifyActivating();
			yield return new ApplyStatusEffectAction<Reflect>(base.Battle.Player, new int?(base.Amount(isActive)), new int?(0), null, null, 0f, true);
			bool flag = base.Battle.Player.HasStatusEffect<Reflect>();
			if (flag)
			{
				base.Battle.Player.GetStatusEffect<Reflect>().Gun = ((base.Battle.Player.GetStatusEffect<Reflect>().Gun == "弹幕对决") ? "弹幕对决B" : "弹幕对决");
			}
			yield break;
		}
	}
}
