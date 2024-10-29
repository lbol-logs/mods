using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoLEntitySideloader.Attributes;
using Sanae_Kochiya.Cards.Template;
using Sanae_Kochiya.Source.Cards.Starter;

namespace Sanae_Kochiya.Source.Cards.Uncommon
{
	[EntityLogic(typeof(SanaeAmuletTalismanDef))]
	public sealed class SanaeAmuletTalisman : SampleCharacterCard
	{
		protected override ManaGroup AdditionalCost
		{
			get
			{
				bool flag = base.Battle != null;
				ManaGroup manaGroup;
				if (flag)
				{
					manaGroup = base.Mana * -this.AmuletCount;
				}
				else
				{
					manaGroup = base.Mana * 0;
				}
				return manaGroup;
			}
		}

		private int AmuletCount
		{
			get
			{
				bool flag = base.Battle != null && base.Battle.Player.HasStatusEffect<Amulet>();
				int num;
				if (flag)
				{
					num = base.Battle.Player.GetStatusEffect<Amulet>().Level;
				}
				else
				{
					num = 0;
				}
				return num;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new GainPowerAction(base.Value1);
			yield return new AddCardsToDrawZoneAction(Library.CreateCards<SanaeStatus>(base.Value2, false), DrawZoneTarget.Random, AddCardsType.Normal);
			yield break;
		}
	}
}
