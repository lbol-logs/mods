using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardfurnaceDef))]
	public sealed class cardfurnace : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
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
			yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(20), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(1, false), AddCardsType.Normal);
			bool flag = base.Battle.Player.Hp < toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 50, true);
			if (flag)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Value2, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
