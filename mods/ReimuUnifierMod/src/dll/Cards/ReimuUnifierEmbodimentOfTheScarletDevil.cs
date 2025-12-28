using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Character.Marisa;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierEmbodimentOfTheScarletDevilDef))]
	public sealed class ReimuUnifierEmbodimentOfTheScarletDevil : ReimuUnifierCard
	{
		protected override string GetBaseDescription()
		{
			return (!this.Active) ? base.ExtraDescription1 : base.GetBaseDescription();
		}

		private bool Active
		{
			get
			{
				bool flag;
				if (base.Battle != null)
				{
					flag = !base.Battle.BattleCardUsageHistory.Any((Card card) => card is ReimuUnifierEmbodimentOfTheScarletDevil);
				}
				else
				{
					flag = true;
				}
				return flag;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool active = this.Active;
			if (active)
			{
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<Potion>() });
				yield return base.HealAction(5);
				yield return base.BuffAction<Firepower>(1, 0, 0, 0, 0.2f);
				yield return base.BuffAction<ExtraTurn>(1, 0, 0, 0, 0.2f);
				yield return base.BuffAction<TurnStartDontLoseBlock>(1, 0, 0, 0, 0.2f);
				yield return new RequestEndPlayerTurnAction();
				yield return new ApplyStatusEffectAction<ReimuUnifierScarletFateSe>(base.Battle.Player, new int?(0), new int?(1), new int?(5), new int?(5), 0f, true);
				yield break;
			}
			yield break;
		}
	}
}
