using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardtearssubsideDef))]
	public sealed class cardtearssubside : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 5, true);
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
			DrawManyCardAction drawAction = new DrawManyCardAction(base.Value2);
			yield return drawAction;
			IReadOnlyList<Card> drawnCards = drawAction.DrawnCards;
			int num = drawnCards.Count((Card card) => card.Config.Colors.Contains(ManaColor.Red));
			bool flag = num > 0;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<sebloodclot>(base.Battle.Player, new int?(base.Value1 * num), new int?(0), new int?(0), new int?(0), 0f, true);
			}
			yield break;
		}
	}
}
