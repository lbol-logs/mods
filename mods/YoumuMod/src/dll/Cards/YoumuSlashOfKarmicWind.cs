using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSlashOfKarmicWindDef))]
	public sealed class YoumuSlashOfKarmicWind : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.Config.GunName);
			yield return base.AttackAction(selector, base.Config.GunNameBurst);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return base.AttackAction(selector, base.Config.GunNameBurst);
			}
			yield break;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.HandleBattleEvent<DamageDealingEventArgs>(base.Battle.Player.DamageDealing, new GameEventHandler<DamageDealingEventArgs>(this.OnPlayerDamageDealing), (GameEventPriority)0);
		}

		private int PlayerTotalFire
		{
			get
			{
				bool flag = base.Battle == null;
				int num;
				if (flag)
				{
					num = 0;
				}
				else
				{
					num = base.Battle.Player.TotalFirepower;
				}
				return num;
			}
		}

		private void OnPlayerDamageDealing(DamageDealingEventArgs args)
		{
			bool flag = args.ActionSource == this && args.DamageInfo.DamageType == DamageType.Attack;
			if (flag)
			{
				Card card = args.ActionSource as Card;
				Unit pendingTarget = card.PendingTarget;
				bool flag2 = pendingTarget != null && pendingTarget is EnemyUnit;
				if (flag2)
				{
					int num = 0;
					bool flag3 = pendingTarget.HasStatusEffect<LockedOn>();
					if (flag3)
					{
						num = pendingTarget.GetStatusEffect<LockedOn>().Level;
					}
					args.DamageInfo = args.DamageInfo.IncreaseBy(num);
					args.AddModifier(this);
				}
			}
		}
	}
}
