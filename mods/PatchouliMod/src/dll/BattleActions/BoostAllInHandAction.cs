using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using PatchouliCharacterMod.Cards.Template;

namespace PatchouliCharacterMod.BattleActions
{
	public sealed class BoostAllInHandAction : SimpleAction
	{
		internal BoostAllInHandAction(int amount = 1)
		{
			this.args = new BoostEventArgs
			{
				Card = null,
				Amount = amount
			};
		}

		public override IEnumerable<Phase> GetPhases()
		{
			yield return base.CreatePhase("Main", delegate
			{
				List<Card> list = base.Battle.HandZone.ToList<Card>();
				foreach (Card card in list)
				{
					PatchouliBoostCard patchouliBoostCard = card as PatchouliBoostCard;
					bool flag = patchouliBoostCard != null;
					if (flag)
					{
						base.React(new BoostAction(patchouliBoostCard, this.args.Amount), null, null);
					}
				}
			}, false);
			yield break;
		}

		private readonly BoostEventArgs args;
	}
}
