using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeHisouHeadDef))]
	public sealed class SanaeHisouHead : SampleCharacterCard
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
				bool isUpgraded = this.IsUpgraded;
				string text;
				if (isUpgraded)
				{
					text = this.LocalizeProperty("UpgradedExtraDescription1", true, true);
				}
				else
				{
					text = this.LocalizeProperty("ExtraDescription1", true, true);
				}
				return text;
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
			Card[] _types = new Card[]
			{
				Library.CreateCard(typeof(SanaeHisouLeftArm)),
				Library.CreateCard(typeof(SanaeHisouRightArm)),
				Library.CreateCard(typeof(SanaeHisouLeftLeg)),
				Library.CreateCard(typeof(SanaeHisouRightLeg))
			};
			Card[] _typesPlus = new Card[]
			{
				Library.CreateCard(typeof(SanaeHisouLeftArm), true),
				Library.CreateCard(typeof(SanaeHisouRightArm), true),
				Library.CreateCard(typeof(SanaeHisouLeftLeg), true),
				Library.CreateCard(typeof(SanaeHisouRightLeg), true)
			};
			bool flag = this.Count >= 4;
			if (flag)
			{
				List<Card> exile = (from hand in base.Battle.HandZone.Concat(base.Battle.DrawZone).Concat(base.Battle.DiscardZone)
					where hand == Library.CreateCard(typeof(SanaeHisouLeftArm)) || hand == Library.CreateCard(typeof(SanaeHisouRightArm)) || hand == Library.CreateCard(typeof(SanaeHisouLeftLeg)) || hand == Library.CreateCard(typeof(SanaeHisouRightLeg))
					select hand).ToList<Card>();
				yield return new ExileManyCardAction(exile);
				this.Count = 0;
				foreach (EnemyUnit enemy in base.Battle.AllAliveEnemies)
				{
					yield return new ForceKillAction(base.Battle.Player, enemy);
					enemy = null;
				}
				IEnumerator<EnemyUnit> enumerator = null;
				exile = null;
			}
			else
			{
				bool isUpgraded = this.IsUpgraded;
				Card card;
				if (isUpgraded)
				{
					MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(_typesPlus, false, false, false)
					{
						Source = this
					};
					yield return new InteractionAction(interaction, false);
					card = interaction.SelectedCard;
					yield return new AddCardsToHandAction(new Card[] { card });
					interaction = null;
				}
				else
				{
					MiniSelectCardInteraction interaction2 = new MiniSelectCardInteraction(_types, false, false, false)
					{
						Source = this
					};
					yield return new InteractionAction(interaction2, false);
					card = interaction2.SelectedCard;
					yield return new AddCardsToHandAction(new Card[] { card });
					interaction2 = null;
				}
				bool flag2 = card.GetType() == typeof(SanaeHisouLeftArm) && !this.LeftArm;
				if (flag2)
				{
					this.LeftArm = true;
					this.Count++;
				}
				else
				{
					bool flag3 = card.GetType() == typeof(SanaeHisouRightArm) && !this.RightArm;
					if (flag3)
					{
						this.RightArm = true;
						this.Count++;
					}
					else
					{
						bool flag4 = card.GetType() == typeof(SanaeHisouLeftLeg) && !this.LeftLeg;
						if (flag4)
						{
							this.LeftLeg = true;
							this.Count++;
						}
						else
						{
							bool flag5 = card.GetType() == typeof(SanaeHisouRightLeg) && !this.RightLeg;
							if (flag5)
							{
								this.RightLeg = true;
								this.Count++;
							}
						}
					}
				}
				yield return new RequestEndPlayerTurnAction();
				card = null;
			}
			yield break;
			yield break;
		}

		public int Count = 0;

		public bool LeftArm = false;

		public bool RightArm = false;

		public bool LeftLeg = false;

		public bool RightLeg = false;
	}
}
