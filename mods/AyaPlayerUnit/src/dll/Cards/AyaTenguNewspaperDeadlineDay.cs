using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaTenguNewspaperDeadlineDayDef))]
	public sealed class AyaTenguNewspaperDeadlineDay : Card
	{
		public int MaxHand
		{
			get
			{
				return 12;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaTenguNewspaperDeadlineDay.<Actions>d__2 <Actions>d__ = new AyaTenguNewspaperDeadlineDay.<Actions>d__2(-2);
			<Actions>d__.<>4__this = this;
			return <Actions>d__;
		}
	}
}
