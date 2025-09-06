using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardmixedbloodDef))]
	public sealed class cardmixedblood : lvalonexrumiaCard
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
			yield return new ApplyStatusEffectAction<semixedblood>(base.Battle.Player, new int?(base.Value1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new AddCardsToHandAction(Library.CreateCards<carddarkblood>(base.Value1, false), AddCardsType.Normal);
				yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(base.Value1, false), AddCardsType.Normal);
			}
			yield break;
		}
	}
}
