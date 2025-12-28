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
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.EnemyUnits.Character;
using LBoL.EntityLib.EnemyUnits.Opponent;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierSanaeHumanGodFriendDef))]
	public sealed class ReimuUnifierSanaeHumanGodFriend : Card
	{
		public string Indent { get; } = "<indent=80>";

		public string PassiveCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Passive\" name=\"{0}\">{1}", base.PassiveCost, this.Indent);
			}
		}

		public string ActiveCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Active\" name=\"{0}\">{1}", base.ActiveCost, this.Indent);
			}
		}

		public string UltimateCostIcon
		{
			get
			{
				return string.Format("<indent=0><sprite=\"Ultimate\" name=\"{0}\">{1}", base.UltimateCost, this.Indent);
			}
		}

		protected override int AdditionalShield
		{
			get
			{
				int num;
				try
				{
					bool flag = !this.IsUpgraded;
					if (flag)
					{
						num = 0;
					}
					else
					{
						num = 2 * base.Battle.Player.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Positive).Count<StatusEffect>();
					}
				}
				catch
				{
					num = 0;
				}
				return num;
			}
		}

		protected override int AdditionalBlock
		{
			get
			{
				int num;
				try
				{
					bool isUpgraded = this.IsUpgraded;
					if (isUpgraded)
					{
						num = 0;
					}
					else
					{
						num = 2 * base.Battle.Player.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Positive).Count<StatusEffect>();
					}
				}
				catch
				{
					num = 0;
				}
				return num;
			}
		}

		public override FriendCostInfo FriendU
		{
			get
			{
				return new FriendCostInfo(base.UltimateCost, FriendCostType.Active);
			}
		}

		protected override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.BuffAction<Amulet>(base.Value1, 0, 0, 0, 0.2f);
			foreach (BattleAction battleAction in base.SummonActions(selector, consumingMana, precondition))
			{
				yield return battleAction;
				battleAction = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			foreach (EnemyUnit unit in base.Battle.AllAliveEnemies)
			{
				PlayerUnit player = base.Battle.Player;
				ReimuUnifierModDef.ReimuUnifierMod PC = player as ReimuUnifierModDef.ReimuUnifierMod;
				bool flag = PC != null;
				if (flag)
				{
					bool flag2 = !PC.DialogueTriggered;
					if (flag2)
					{
						bool flag3 = unit is Sanae;
						if (flag3)
						{
							yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueSanae1", true, true), 2.5f, 0f, 2.5f, true);
							PC.DialogueTriggered = true;
						}
						else
						{
							bool flag4 = unit is SuwakoLimao || unit is KanakoLimao;
							if (flag4)
							{
								yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueSanae2", true, true), 2.5f, 0f, 2.5f, true);
								PC.DialogueTriggered = true;
							}
							else
							{
								bool flag5 = unit is Reimu;
								if (flag5)
								{
									yield return PerformAction.Chat(base.Battle.Player, PC.LocShortcut("DialogueSanae3", true, true), 2.5f, 0f, 2.5f, true);
									PC.DialogueTriggered = true;
								}
							}
						}
					}
				}
				PC = null;
				unit = null;
			}
			IEnumerator<EnemyUnit> enumerator2 = null;
			yield break;
			yield break;
		}

		public override IEnumerable<BattleAction> OnTurnEndingInHand()
		{
			return this.GetPassiveActions();
		}

		public override IEnumerable<BattleAction> GetPassiveActions()
		{
			bool flag = this.Summoned && !this.Battle.BattleShouldEnd;
			if (flag)
			{
				this.NotifyActivating();
				this.Loyalty += this.PassiveCost;
				int i = 0;
				while (i < this.Battle.FriendPassiveTimes && !this.Battle.BattleShouldEnd)
				{
					yield return PerformAction.Sfx("FairySupport", 0f);
					yield return new CastBlockShieldAction(base.Battle.Player, this.Block.Block, base.Shield.Shield, BlockShieldType.Direct, false);
					int num = i + 1;
					i = num;
				}
			}
			yield break;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			bool flag = precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active;
			if (flag)
			{
				base.Loyalty += base.ActiveCost;
				yield return base.SkillAnime;
				List<Card> list = new List<Card>();
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					list = (from card in base.Battle.HandZone.Concat(base.Battle.DiscardZone).Concat(base.Battle.DrawZone)
						where card != this
						select card).ToList<Card>();
				}
				else
				{
					list = base.Battle.HandZone.Where((Card card) => card != this).ToList<Card>();
				}
				bool flag2 = !list.Empty<Card>();
				if (flag2)
				{
					SelectCardInteraction CardPick = new SelectCardInteraction(0, 2, list, SelectedCardHandling.DoNothing)
					{
						Source = this
					};
					yield return new InteractionAction(CardPick, false);
					List<Card> selectedCards = CardPick.SelectedCards.ToList<Card>();
					yield return new ExileManyCardAction(selectedCards);
					yield return base.BuffAction<AmuletForCard>(selectedCards.Count, 0, 0, 0, 0.2f);
					CardPick = null;
					CardPick = null;
					selectedCards = null;
				}
				list = null;
			}
			else
			{
				bool flag3 = ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active2;
				if (flag3)
				{
					base.Loyalty += base.ActiveCost2;
					yield return base.SkillAnime;
					yield return base.BuffAction<Spirit>(base.Value2, 0, 0, 0, 0.2f);
					foreach (EnemyUnit target in base.Battle.AllAliveEnemies)
					{
						yield return base.DebuffAction<SpiritNegative>(target, base.Value2, 0, 0, 0, true, 0.2f);
						yield return base.DebuffAction<Weak>(target, 0, 1, 0, 0, true, 0.2f);
						target = null;
					}
					IEnumerator<EnemyUnit> enumerator = null;
				}
				else
				{
					base.Loyalty += base.UltimateCost;
					yield return base.SkillAnime;
					yield return base.BuffAction<Curiosity>(1, 0, 0, 0, 0.2f);
				}
			}
			yield break;
			yield break;
		}
	}
}
