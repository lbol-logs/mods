using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbefallenDef))]
	public sealed class cardbefallen : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, false);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<sedarkblood>(base.Battle.Player, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ChangeLifeAction(-this.heal, null);
			yield return new AddCardsToHandAction(Library.CreateCards<Shadow>(1, false), AddCardsType.Normal);
			yield break;
		}
	}
}
