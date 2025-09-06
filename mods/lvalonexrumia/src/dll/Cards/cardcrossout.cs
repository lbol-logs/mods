using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardcrossoutDef))]
	public sealed class cardcrossout : lvalonexrumiaCard
	{
		public ManaGroup Mana2
		{
			get
			{
				return new ManaGroup
				{
					Any = 1
				};
			}
		}

		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return pooledMana;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int Black = base.SynergyAmount(consumingMana, ManaColor.Any, 1);
			bool flag = Black > 0;
			if (flag)
			{
				bool cast = true;
				int num;
				for (int i = 0; i < Black; i = num + 1)
				{
					yield return new CastBlockShieldAction(base.Battle.Player, base.Battle.Player, this.Block, cast);
					cast = false;
					yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					num = i;
				}
			}
			yield break;
		}
	}
}
