using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardnightfallsDef))]
	public sealed class cardnightfalls : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ApplyStatusEffectAction<senightfalls>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool flag = base.Battle.DrawZone.Count <= 0 && base.Battle.HandIsFull;
			if (flag)
			{
				yield break;
			}
			List<Card> list = base.Battle.DrawZoneToShow.Where((Card card) => card.Config.Colors.Contains(ManaColor.Black)).SampleManyOrAll(base.Value2, base.BattleRng).ToList<Card>();
			bool flag2 = list.Count <= 0;
			if (flag2)
			{
				yield break;
			}
			foreach (Card item in list)
			{
				bool handIsFull = base.Battle.HandIsFull;
				if (handIsFull)
				{
					break;
				}
				yield return new MoveCardAction(item, CardZone.Hand);
				yield return new GainManaAction(base.Mana);
				item = null;
			}
			List<Card>.Enumerator enumerator = default(List<Card>.Enumerator);
			yield break;
			yield break;
		}
	}
}
