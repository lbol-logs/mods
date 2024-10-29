using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.BattleActions;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuCircularVicissitudeDef))]
	public sealed class YoumuCircularVicissitude : YoumuCard
	{
		public override bool Triggered
		{
			get
			{
				List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
				int num = 0;
				foreach (Card card in list)
				{
					bool flag = YoumuCard.IsSlashCard(card);
					if (flag)
					{
						num++;
					}
				}
				return num >= base.Value1;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.DefenseAction(true);
			bool playInTriggered = base.PlayInTriggered;
			if (playInTriggered)
			{
				yield return new UnsheatheAllInHandAction();
			}
			yield break;
		}
	}
}
