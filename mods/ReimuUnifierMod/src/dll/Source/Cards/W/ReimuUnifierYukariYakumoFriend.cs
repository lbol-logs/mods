using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoLEntitySideloader.Attributes;
using System;
using System.Collections.Generic;
using ReimuUnifierMod.Cards.Template;
using ReimuUnifierMod.Cards;
using System.Linq;
using LBoL.EntityLib.StatusEffects.Basic;
using ReimuUnifierMod.StatusEffects;

namespace ReimuUnifierMod.Cards
{
    public sealed class ReimuUnifierYukariYakumoFriendDef : ReimuUnifierCardTemplate
    {
        public override CardConfig MakeConfig()
        {
            CardConfig config = GetCardDefaultConfig();

            config.Colors = new List<ManaColor>() { ManaColor.White };
            config.Cost = new ManaGroup() { Any = 1, White = 1 };
            config.Rarity = Rarity.Common;
            config.IsPooled = true;

            config.Type = CardType.Friend;
            config.TargetType = TargetType.Nobody;

            config.Loyalty = 2;
            config.UpgradedLoyalty = 2;
            config.PassiveCost = 2;
            config.UpgradedPassiveCost = 3;
            config.ActiveCost = -5;
            config.UpgradedActiveCost = -4;
            config.UltimateCost = -9;
            config.UpgradedUltimateCost = -9;

            config.Value1 = 6;
            config.Value2 = 10;
            config.UpgradedValue2 = 12;


            config.Keywords = Keyword.None;
            config.UpgradedKeywords = Keyword.None;
            config.RelativeKeyword = Keyword.Shield | Keyword.Exile;
            config.UpgradedRelativeKeyword = Keyword.Shield | Keyword.Exile;
            config.RelativeEffects = new List<string>() { "Invincible" };
            config.UpgradedRelativeEffects = new List<string>() { "Invincible" };
            config.RelativeCards = new List<string>() { nameof(ReimuUnifierCommunicatorOrbToken) };
            config.UpgradedRelativeCards = new List<string>() { nameof(ReimuUnifierCommunicatorOrbToken) };

            config.Illustrator = "Saevin";

            config.Index = CardIndexGenerator.GetUniqueIndex(config);
            return config;
        }
    }

    [EntityLogic(typeof(ReimuUnifierYukariYakumoFriendDef))]
    public sealed class ReimuUnifierYukariYakumoFriend : Card
    {
        public string Indent { get; } = "<indent=80>";
        public string PassiveCostIcon
        {
            get
            {
                return string.Format("<indent=0><sprite=\"Passive\" name=\"{0}\">{1}", base.PassiveCost, Indent);
            }
        }
        public string ActiveCostIcon
        {
            get
            {
                return string.Format("<indent=0><sprite=\"Active\" name=\"{0}\">{1}", base.ActiveCost, Indent);
            }
        }
        public string UltimateCostIcon
        {
            get
            {
                return string.Format("<indent=0><sprite=\"Ultimate\" name=\"{0}\">{1}", base.UltimateCost, Indent);
            }
        }

        protected override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
        {
            yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierCommunicatorOrbToken>() });
            foreach (BattleAction battleAction in base.SummonActions(selector, consumingMana, precondition))
            {
                yield return battleAction;
            }

            yield break;
        }

        public override IEnumerable<BattleAction> OnTurnStartedInHand() => this.GetPassiveActions();

        public override IEnumerable<BattleAction> GetPassiveActions()
        {
            ReimuUnifierYukariYakumoFriend YukariYakumoFriend = this;
            if (YukariYakumoFriend.Summoned && !YukariYakumoFriend.Battle.BattleShouldEnd)
            {
                YukariYakumoFriend.NotifyActivating();
                YukariYakumoFriend.Loyalty += YukariYakumoFriend.PassiveCost;
                for (int i = 0; i < YukariYakumoFriend.Battle.FriendPassiveTimes && !YukariYakumoFriend.Battle.BattleShouldEnd; ++i)
                {
                    yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<ReimuUnifierCommunicatorOrbToken>() });
                }
            }
        }
        
        protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
        {
            ReimuUnifierYukariYakumoFriend YukariYakumoFriend = this;

            if (precondition == null || ((MiniSelectCardInteraction)precondition).SelectedCard.FriendToken == FriendToken.Active)
            {
                //Adjust the card's loyalty. 
                //Because the ActiveCost is negative, the Cost has to be added instead of substracted.
                YukariYakumoFriend.Loyalty += YukariYakumoFriend.ActiveCost;

                List<Card> list = base.Battle.HandZone.Where((Card hand) => hand != this).ToList<Card>();
                if (list.Count <= 0)
                {
                    yield break;
                } else
                {
                    MiniSelectCardInteraction interaction = new MiniSelectCardInteraction(list, false, false, false)
                    {
                        Source = this
                    };
                    yield return new InteractionAction(interaction, false);
                    Card ExiledCard = interaction.SelectedCard;
                    int ExiledCardCost = ExiledCard.BaseCost.Amount;
                    yield return new ExileCardAction(ExiledCard);
                    yield return new CastBlockShieldAction(Battle.Player, Battle.Player, 0, ExiledCardCost * Value1, BlockShieldType.Direct, true);
                    interaction = null;

                    yield break;
                }
            }
            else
            {
                YukariYakumoFriend.Loyalty += YukariYakumoFriend.UltimateCost;
                YukariYakumoFriend.UltimateUsed = true;
                yield return YukariYakumoFriend.BuffAction<Invincible>(0,1,0,0);
                yield return BuffAction<ReimuUnifierYukariLifeLossSe>(Value2);
            }
            yield break;
        }
    }
}
