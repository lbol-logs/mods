using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace Utsuho_character_mod.CardsR
{
	public sealed class SalvoDef : CardTemplate
	{
		public override IdContainer GetId()
		{
			return "Salvo";
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
			return new CardConfig(13320, "", 10, true, new string[0][], "Huanggua1", "Huanggua1", 0, false, true, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.RandomEnemy), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 1,
				Any = 2
			}, new ManaGroup?(new ManaGroup
			{
				Red = 1,
				Any = 2
			}), null, new int?(5), new int?(7), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), "Utsuho", "", "", false, "Zosit", new List<string>());
		}

		[EntityLogic(typeof(SalvoDef))]
		public sealed class Salvo : Card
		{
			public int SalvoCount
			{
				get
				{
					bool flag = base.Battle != null;
					int num;
					if (flag)
					{
						num = base.Battle._turnCardUsageHistory.Count + 1;
					}
					else
					{
						num = 1;
					}
					return num;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				int num;
				for (int i = 0; i < this.SalvoCount; i = num + 1)
				{
					bool flag = !base.Battle.BattleShouldEnd;
					if (flag)
					{
						EnemyUnit target = base.Battle.EnemyGroup.Alives.Sample(base.GameRun.BattleRng);
						bool flag2 = target != null && target.IsAlive;
						if (flag2)
						{
							yield return base.AttackAction(target);
						}
						target = null;
					}
					num = i;
				}
				yield break;
			}
		}
	}
}
