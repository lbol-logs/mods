using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaDaymareintheDarkNightDef))]
	public sealed class AyaDaymareintheDarkNight : Card
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaDaymareintheDarkNight.<Actions>d__0 <Actions>d__ = new AyaDaymareintheDarkNight.<Actions>d__0(-2);
			<Actions>d__.<>4__this = this;
			<Actions>d__.<>3__selector = selector;
			return <Actions>d__;
		}
	}
}
