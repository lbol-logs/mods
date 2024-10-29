using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.BattleActions
{
	public sealed class BoostAction : SimpleAction
	{
		internal BoostAction(Card card, int amount = 1)
		{
			this.args = new BoostEventArgs
			{
				Card = card,
				Amount = amount
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				PatchouliBoostCard patchouliBoostCard = this.args.Card as PatchouliBoostCard;
				bool flag = patchouliBoostCard != null;
				if (flag)
				{
					patchouliBoostCard.Boost += this.args.Amount;
				}
			}, false);
			yield return base.CreateEventPhase<BoostEventArgs>("Boosted", this.args, CustomGameEventPatch.Boosted);
			yield break;
		}

		private readonly BoostEventArgs args;
	}
}
