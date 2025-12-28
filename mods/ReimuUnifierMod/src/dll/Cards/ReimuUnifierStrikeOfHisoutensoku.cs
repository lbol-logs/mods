using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using ReimuUnifierMod.BattleActions;
using ReimuUnifierMod.Cards.Template;

namespace ReimuUnifierMod.Cards
{
	[EntityLogic(typeof(ReimuUnifierStrikeOfHisoutensokuDef))]
	public sealed class ReimuUnifierStrikeOfHisoutensoku : ReimuUnifierCard
	{
		protected override int AdditionalDamage
		{
			get
			{
				bool flag = base.PendingTarget != null;
				int num;
				if (flag)
				{
					num = base.PendingTarget.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Negative).Count<StatusEffect>() * base.Value1;
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
			int EnemyDebuffs = selector.SelectedEnemy.StatusEffects.Where((StatusEffect Status) => Status.Type == StatusEffectType.Negative).Count<StatusEffect>();
			bool flag = base.TeamUpCheck<ReimuUnifierSanaeHumanGodFriend>();
			if (flag)
			{
				base.CardGuns = new Guns(base.GunName, 1, false);
				bool isUpgraded = this.IsUpgraded;
				if (isUpgraded)
				{
					yield return base.DebuffAction<TempFirepowerNegative>(selector.SelectedEnemy, base.Value2 * EnemyDebuffs, 0, 0, 0, true, 0.2f);
					yield return base.AttackAction(selector.SelectedEnemy, this.Damage, base.GunName);
				}
				else
				{
					yield return base.AttackAction(selector.SelectedEnemy, this.Damage, base.GunName);
					yield return base.DebuffAction<TempFirepowerNegative>(selector.SelectedEnemy, base.Value2 * selector.SelectedEnemy.StatusEffects.Count, 0, 0, 0, true, 0.2f);
				}
				yield return new TeamUpAction(this, base.TeamUpCard(typeof(ReimuUnifierSanaeHumanGodFriend)));
				yield break;
			}
			yield return base.AttackAction(selector.SelectedEnemy, this.Damage, base.GunName);
			yield break;
		}
	}
}
