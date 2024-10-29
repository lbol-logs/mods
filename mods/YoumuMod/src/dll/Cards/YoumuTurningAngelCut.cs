using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuTurningAngelCutDef))]
	public sealed class YoumuTurningAngelCut : YoumuCard
	{
		public ManaGroup ManaEmpty { get; } = new ManaGroup
		{
			Any = 0
		};

		public ManaGroup ManaGreen { get; } = new ManaGroup
		{
			Green = 1
		};

		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return new ManaGroup
			{
				White = pooledMana.White,
				Green = pooledMana.Green,
				Philosophy = pooledMana.Philosophy
			};
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int num;
			for (int i = 0; i < base.SynergyAmount(consumingMana, ManaColor.White, 2); i = num + 1)
			{
				Card slashOfPresent = Library.CreateCard<YoumuSlashOfPresent>();
				slashOfPresent.SetTurnCost(new ManaGroup
				{
					Any = 0
				});
				yield return new AddCardsToHandAction(new Card[] { slashOfPresent });
				num = i;
			}
			int lockOn = base.SynergyAmount(consumingMana, ManaColor.Green, 1) * base.Value2;
			yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, lockOn, 0, 0, 0, true, 0.2f);
			yield break;
		}
	}
}
