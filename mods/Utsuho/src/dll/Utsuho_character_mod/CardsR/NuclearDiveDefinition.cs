using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod.CardsR
{
	public sealed class NuclearDiveDefinition : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "NuclearDive";
		}

		public override CardImages LoadCardImages()
		{
			CardImages cardImages = new CardImages(BepinexPlugin.embeddedSource);
			cardImages.AutoLoad(this, ".png", "", false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override CardConfig MakeConfig()
		{
			return new CardConfig(13490, "", 10, true, new string[0][], "博丽一拳", "博丽一拳", 0, false, true, true, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 3
			}, new ManaGroup?(new ManaGroup
			{
				Red = 3
			}), null, new int?(0), new int?(0), null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Red = 4
			}), new ManaGroup?(new ManaGroup
			{
				Red = 4
			}), null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Exile, Keyword.Accuracy | Keyword.Exile, false, Keyword.Expel, Keyword.Expel, new List<string> { "HeatStatus" }, new List<string> { "HeatStatus" }, new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(NuclearDiveDefinition))]
		public sealed class NuclearDive : Card
		{
			public override int AdditionalDamage
			{
				get
				{
					bool flag = this.tempDamage != 0;
					int num;
					if (flag)
					{
						num = this.tempDamage;
					}
					else
					{
						int seLevel = base.GetSeLevel<HeatStatus>();
						bool flag2 = !this.IsUpgraded;
						if (flag2)
						{
							num = seLevel * 2;
						}
						else
						{
							num = seLevel * 3;
						}
					}
					return num;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<DieEventArgs>(base.Battle.EnemyDied, new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
			}

			private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
			{
				bool flag = args.DieSource == this && !args.Unit.HasStatusEffect<Servant>();
				if (flag)
				{
					yield return new GainManaAction(base.Mana);
				}
				yield break;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int level = base.GetSeLevel<HeatStatus>();
				bool flag = !this.IsUpgraded && level != 0;
				if (flag)
				{
					this.tempDamage = level * 2;
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(level), null, null, null, 0f, true);
				}
				else
				{
					this.tempDamage = level * 3;
					yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(level * 2), null, null, null, 0f, true);
				}
				int level2 = base.GetSeLevel<HeatStatus>();
				yield return base.DamageSelfAction(level2 / 10, "");
				bool flag2 = !base.Battle.BattleShouldEnd;
				if (flag2)
				{
					yield return base.AttackAction(selector.SelectedEnemy);
				}
				bool flag3 = !base.Battle.BattleShouldEnd;
				if (flag3)
				{
					yield return new RemoveStatusEffectAction(base.Battle.Player.GetStatusEffect<HeatStatus>(), true, 0.1f);
				}
				yield break;
			}

			private int tempDamage = 0;
		}
	}
}
