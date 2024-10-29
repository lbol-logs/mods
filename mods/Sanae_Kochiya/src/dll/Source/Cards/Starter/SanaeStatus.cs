using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Starter
{
	[EntityLogic(typeof(SanaeStatusDef))]
	public sealed class SanaeStatus : SampleCharacterCard
	{
		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			yield return new CastBlockShieldAction(base.Battle.Player, base.Block, base.Shield, true);
			yield break;
		}
	}
}
