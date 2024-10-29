using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuClearingTheSixSensesDef))]
	public sealed class YoumuClearingTheSixSenses : YoumuCard
	{
		public override bool Triggered
		{
			get
			{
				List<StatusEffect> list = base.Battle.Player.StatusEffects.Where((StatusEffect se) => se.Type == StatusEffectType.Negative).ToList<StatusEffect>();
				return list.Count > 0;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool playInTriggered = base.PlayInTriggered;
			if (playInTriggered)
			{
				yield return new RemoveAllNegativeStatusEffectAction(base.Battle.Player, 0.2f);
				yield return base.BuffAction<Firepower>(base.Value1, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
