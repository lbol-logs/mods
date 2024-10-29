using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.StatusEffects;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuClosedEyeSlashDef))]
	public sealed class YoumuClosedEyeSlash : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			DamageInfo damageInfo = DamageInfo.Attack(base.Damage.Damage, base.IsAccuracy);
			int block = base.Battle.CalculateDamage(this, base.Battle.Player, selector.SelectedEnemy, damageInfo);
			yield break;
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<DamageEventArgs>(base.Battle.Player.DamageDealt, new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageDealt));
		}

		private IEnumerable<BattleAction> OnPlayerDamageDealt(DamageEventArgs args)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			bool flag = args.Cause == ActionCause.Card && args.ActionSource == this;
			if (flag)
			{
				DamageInfo damageInfo = args.DamageInfo;
				bool flag2 = damageInfo.Damage > 0f;
				if (flag2)
				{
					yield return base.BuffAction<YoumuRiposteSe>((int)damageInfo.Damage, 0, 0, 0, 0.2f);
				}
				damageInfo = default(DamageInfo);
			}
			yield break;
		}
	}
}
