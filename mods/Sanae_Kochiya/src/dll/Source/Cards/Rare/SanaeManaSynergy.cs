using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;

namespace Sanae_Kochiya.Source.Cards.Rare
{
	[EntityLogic(typeof(SanaeManaSynergyDef))]
	public sealed class SanaeManaSynergy : SampleCharacterCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return new ManaGroup
			{
				White = pooledMana.White,
				Blue = pooledMana.Blue,
				Green = pooledMana.Green
			};
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new GainManaAction(new ManaGroup
			{
				Blue = base.SynergyAmount(consumingMana, ManaColor.White, 1),
				Green = base.SynergyAmount(consumingMana, ManaColor.White, 1)
			});
			yield return new GainManaAction(new ManaGroup
			{
				White = base.SynergyAmount(consumingMana, ManaColor.Blue, 1),
				Green = base.SynergyAmount(consumingMana, ManaColor.Blue, 1)
			});
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new GainManaAction(new ManaGroup
				{
					White = base.SynergyAmount(consumingMana, ManaColor.Green, 1),
					Blue = base.SynergyAmount(consumingMana, ManaColor.Green, 1)
				});
			}
			yield return new LockRandomTurnManaAction(base.Value1);
			yield break;
		}
	}
}
