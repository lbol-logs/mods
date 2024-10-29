using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Utsuho_character_mod.Status
{
	[EntityLogic(typeof(SunSpotEffect))]
	public sealed class SunSpotStatus : StatusEffect
	{
		private string GunName
		{
			get
			{
				bool flag = base.Level <= 50;
				string text;
				if (flag)
				{
					text = "无差别起火";
				}
				else
				{
					text = "无差别起火B";
				}
				return text;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = args.Card.Id == "DarkMatter";
			if (flag)
			{
				int dyLevel = base.GetSeLevel<SunSpotStatus>();
				int num;
				for (int i = 0; i < dyLevel; i = num + 1)
				{
					int level = base.GetSeLevel<HeatStatus>();
					base.NotifyActivating();
					bool flag2 = level >= 5;
					if (flag2)
					{
						yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)(level / 5), false), this.GunName, GunType.Single);
					}
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					num = i;
				}
			}
			yield break;
		}
	}
}
