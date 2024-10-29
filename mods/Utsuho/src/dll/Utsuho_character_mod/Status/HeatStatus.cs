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
	[EntityLogic(typeof(EnergyEffect))]
	public sealed class HeatStatus : StatusEffect
	{
		private string GunName
		{
			get
			{
				return "GuihuoExplodeR2";
			}
		}

		public int HeatDamage
		{
			get
			{
				return base.Level / 5;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnEnding, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnEnding));
		}

		private IEnumerable<BattleAction> OnOwnerTurnEnding(UnitEventArgs args)
		{
			int level = base.Level;
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				bool flag2 = level >= 5;
				if (flag2)
				{
					bool flag3 = base.Owner == base.Battle.Player;
					if (flag3)
					{
						yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)(level / 5), false), this.GunName, GunType.Single);
					}
					else
					{
						yield return new DamageAction(base.Owner, base.Battle.Player, DamageInfo.Reaction((float)(level / 5), false), this.GunName, GunType.Single);
					}
				}
			}
			bool flag4 = !base.Battle.BattleShouldEnd;
			if (flag4)
			{
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Owner, new int?(-(level / 5)), null, null, null, 0f, true);
			}
			yield break;
		}
	}
}
