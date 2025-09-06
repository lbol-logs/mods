using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardblooduseDef))]
	public sealed class cardblooduse : lvalonexrumiaCard
	{
		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = base.Battle.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Value1, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
