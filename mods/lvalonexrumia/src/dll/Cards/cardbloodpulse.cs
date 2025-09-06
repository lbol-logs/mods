using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardbloodpulseDef))]
	public sealed class cardbloodpulse : lvalonexrumiaCard
	{
		public override Interaction Precondition()
		{
			bool debutActive = base.DebutActive;
			if (debutActive)
			{
				List<Card> list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				bool flag = !list.Empty<Card>();
				if (flag)
				{
					return new SelectCardInteraction(0, base.Battle.MaxHand, list, SelectedCardHandling.DoNothing);
				}
			}
			return null;
		}

		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override string GetBaseDescription()
		{
			bool flag = !base.DebutActive;
			string text;
			if (flag)
			{
				text = base.GetExtraDescription1;
			}
			else
			{
				text = base.GetBaseDescription();
			}
			return text;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd2)
			{
				yield break;
			}
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool battleShouldEnd3 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd3)
				{
					yield break;
				}
				yield return new ApplyStatusEffectAction<sebleed>(unit, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator = null;
			int num;
			for (int i = 0; i < base.Value2; i = num + 1)
			{
				bool battleShouldEnd4 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd4)
				{
					yield break;
				}
				yield return base.AttackAction(selector, base.GunName);
				num = i;
			}
			bool battleShouldEnd5 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd5)
			{
				yield break;
			}
			bool flag = precondition != null && base.DebutActive;
			if (flag)
			{
				IReadOnlyList<Card> cards = ((SelectCardInteraction)precondition).SelectedCards;
				bool flag2 = cards.Count > 0;
				if (flag2)
				{
					yield return new ExileManyCardAction(cards);
					yield return new AddCardsToHandAction(Library.CreateCards<cardredblood>(cards.Count, false), AddCardsType.Normal);
				}
				cards = null;
			}
			yield break;
			yield break;
		}
	}
}
