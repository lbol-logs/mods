using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Cards.Enemy;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardsunnydryDef))]
	public sealed class cardsunnydry : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new GainManaAction(base.Mana);
			yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0f, true);
			yield return new AddCardsToHandAction(Library.CreateCards<Riguang>(1, false), AddCardsType.Normal);
			yield break;
		}
	}
}
