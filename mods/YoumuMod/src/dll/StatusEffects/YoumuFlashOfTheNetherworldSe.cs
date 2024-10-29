using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.StatusEffects
{
	[EntityLogic(typeof(YoumuFlashOfTheNetherworldSeDef))]
	public sealed class YoumuFlashOfTheNetherworldSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
		}

		private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
		{
			bool isExtraTurn = base.Battle.Player.IsExtraTurn;
			if (isExtraTurn)
			{
				string gunName = YoumuGunName.FlashOfTheNetherworldSe;
				int num;
				for (int i = 0; i < base.Count; i = num + 1)
				{
					bool flag = i > 0;
					if (flag)
					{
						gunName = "Instant";
					}
					base.NotifyActivating();
					yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)base.Level, false), gunName, GunType.Single);
					num = i;
				}
				gunName = null;
			}
			base.Count = 0;
			yield break;
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool isExtraTurn = base.Battle.Player.IsExtraTurn;
			if (isExtraTurn)
			{
				base.Count = base.Battle.TurnCardUsageHistory.Count;
			}
			yield break;
		}
	}
}
