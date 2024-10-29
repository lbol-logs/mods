using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeUpgradeWardDef))]
	public sealed class SanaeUpgradeWard : SampleCharacterCard
	{
		public override ManaGroup? PlentifulMana
		{
			get
			{
				return new ManaGroup?(base.Mana);
			}
		}

		private string ExtraDescription1
		{
			get
			{
				return this.LocalizeProperty("ExtraDescription1", true, true);
			}
		}

		protected override string GetBaseDescription()
		{
			bool flag = !base.PlentifulHappenThisTurn;
			string text;
			if (flag)
			{
				text = base.GetBaseDescription();
			}
			else
			{
				text = this.ExtraDescription1;
			}
			return text;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool Upgrade = false;
			foreach (Card card in base.Battle.HandZone)
			{
				bool flag = card != this && !card.IsUpgraded && card.CardType != CardType.Tool && card.CardType != CardType.Status && card.CardType != CardType.Misfortune;
				if (flag)
				{
					Upgrade = true;
				}
				card = null;
			}
			IEnumerator<Card> enumerator = null;
			bool flag2 = Upgrade;
			if (flag2)
			{
				yield return base.UpgradeRandomHandAction(base.Value1, CardType.Unknown);
			}
			else
			{
				yield return base.BuffAction<AmuletForCard>(base.Value2, 0, 0, 0, 0.2f);
			}
			yield break;
		}
	}
}
