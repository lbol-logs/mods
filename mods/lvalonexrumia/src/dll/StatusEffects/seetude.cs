using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.GunName;
using lvalonexrumia.Patches;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(seetudeDef))]
	public sealed class seetude : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}

		public int heal
		{
			get
			{
				bool flag = base.Owner == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					bool flag2 = base.Level == 0;
					if (flag2)
					{
						num = 0;
					}
					else
					{
						num = toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, 5, false);
					}
				}
				return num;
			}
		}

		public DamageInfo Damage
		{
			get
			{
				return DamageInfo.Attack((float)base.Level, true);
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Owner.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
		}

		private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			base.NotifyActivating();
			yield return new ChangeLifeAction(-this.heal, null);
			yield return new ApplyStatusEffectAction<seatkincrease>(base.Battle.Player, new int?(30), new int?(0), new int?(0), new int?(0), 0.2f, true);
			int num;
			for (int i = 0; i < 3; i = num + 1)
			{
				bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd2)
				{
					yield break;
				}
				yield return new DamageAction(base.Battle.Player, base.Battle.RandomAliveEnemy, this.Damage, GunNameID.GetGunFromId(7041), GunType.Single);
				num = i;
			}
			bool battleShouldEnd3 = base.Battle.BattleShouldEnd;
			if (battleShouldEnd3)
			{
				yield break;
			}
			yield return new RemoveStatusEffectAction(this, true, 0.1f);
			yield break;
		}
	}
}
