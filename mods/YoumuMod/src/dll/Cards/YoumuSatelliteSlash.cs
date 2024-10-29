using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.Patches;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSatelliteSlashDef))]
	public sealed class YoumuSatelliteSlash : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(CustomGameEventPatch.Unsheathed, new EventSequencedReactor<GameEventArgs>(this.OnUnsheathe));
		}

		private IEnumerable<BattleAction> OnUnsheathe(GameEventArgs args)
		{
			bool flag = args.Cause != ActionCause.OnlyCalculate && base.Zone == CardZone.Discard && !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new MoveCardAction(this, CardZone.Hand);
			}
			yield break;
		}
	}
}
