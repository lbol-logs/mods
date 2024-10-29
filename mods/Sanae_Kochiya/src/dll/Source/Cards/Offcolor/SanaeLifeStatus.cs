using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Offcolor
{
	[EntityLogic(typeof(SanaeLifeStatusDef))]
	public sealed class SanaeLifeStatus : SampleCharacterCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.GameRun.GainMaxHp(base.Value1, true, true);
			List<Card> cards = (from card in base.Battle.HandZone.Concat(base.Battle.DrawZone).Concat(base.Battle.DiscardZone)
				where !(card is Frog)
				select card).ToList<Card>();
			bool flag = cards.Count > 0;
			if (flag)
			{
				yield return PerformAction.Wait(0.2f, true);
				yield return PerformAction.UiSound("Frog");
				Card[] array = cards.SampleManyOrAll(base.Value2, base.GameRun.BattleRng);
				foreach (Card card2 in array)
				{
					Frog frog = Library.CreateCard<Frog>();
					frog.OriginalCard = card2;
					yield return new TransformCardAction(card2, frog);
					frog = null;
					card2 = null;
				}
				Card[] array2 = null;
				array = null;
			}
			yield break;
		}
	}
}
