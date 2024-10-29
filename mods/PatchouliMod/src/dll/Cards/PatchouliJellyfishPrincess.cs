using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.StatusEffects;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliJellyfishPrincessDef))]
	public sealed class PatchouliJellyfishPrincess : PatchouliCard
	{
		public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
		{
			return new ManaGroup
			{
				Blue = pooledMana.Blue,
				Black = pooledMana.Black,
				Philosophy = pooledMana.Philosophy
			};
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			int blue = base.SynergyAmount(consumingMana, ManaColor.Blue, 1);
			int black = base.SynergyAmount(consumingMana, ManaColor.Black, 1);
			base.CardGuns = new Guns(base.GunName, blue, false);
			foreach (GunPair gunPair in base.CardGuns.GunPairs)
			{
				yield return base.AttackAction(selector, gunPair);
				gunPair = null;
			}
			List<GunPair>.Enumerator enumerator = default(List<GunPair>.Enumerator);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				int num;
				for (int i = 0; i < black; i = num + 1)
				{
					yield return base.BuffAction<PatchouliMoonSignSe>(base.Value1, 0, 0, PatchouliSignSe.TurnLimit, 0.2f);
					num = i;
				}
			}
			yield break;
			yield break;
		}
	}
}
