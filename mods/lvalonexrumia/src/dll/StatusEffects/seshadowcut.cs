using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.GunName;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seshadowcutDef))]
	public sealed class seshadowcut : ExtraTurnPartner
	{
		public DamageInfo Damage
		{
			get
			{
				return DamageInfo.Attack((float)base.Level, true);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			bool flag = !(unit is PlayerUnit);
			if (flag)
			{
				BepinexPlugin.log.LogWarning(this.DebugName + " should not apply to non-player unit.");
				this.React(new RemoveStatusEffectAction(this, true, 0.1f));
			}
			else
			{
				base.ThisTurnActivating = false;
				base.ShowCount = false;
				base.HandleOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarting, delegate
				{
					bool flag2 = base.Battle.Player.IsExtraTurn && !base.Battle.Player.IsSuperExtraTurn && base.Battle.Player.GetStatusEffectExtend<ExtraTurnPartner>() == this;
					if (flag2)
					{
						base.ThisTurnActivating = true;
						base.ShowCount = true;
						base.Highlight = true;
					}
				});
				base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
				base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnEnded, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnded));
			}
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			bool thisTurnActivating = base.ThisTurnActivating;
			if (thisTurnActivating)
			{
				int num;
				for (int i = 0; i < base.Level; i = num + 1)
				{
					bool battleShouldEnd = base.Battle.BattleShouldEnd;
					if (battleShouldEnd)
					{
						yield break;
					}
					bool flag = i == 0;
					if (flag)
					{
						yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, this.Damage, GunNameID.GetGunFromId(7161), GunType.Single);
					}
					else
					{
						yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, this.Damage, GunNameID.GetGunFromId(520), GunType.Single);
					}
					num = i;
				}
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnPlayerTurnEnded(UnitEventArgs args)
		{
			bool thisTurnActivating = base.ThisTurnActivating;
			if (thisTurnActivating)
			{
				yield return new RemoveStatusEffectAction(this, true, 0.1f);
			}
			yield break;
		}
	}
}
