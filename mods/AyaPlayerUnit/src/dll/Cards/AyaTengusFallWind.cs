using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaTengusFallWindDef))]
	public sealed class AyaTengusFallWind : Card
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaTengusFallWind.<Actions>d__0 <Actions>d__ = new AyaTengusFallWind.<Actions>d__0(-2);
			<Actions>d__.<>4__this = this;
			return <Actions>d__;
		}
	}
}
