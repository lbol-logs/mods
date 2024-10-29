using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuTransmigrationSlashDef))]
	public sealed class YoumuTransmigrationSlash : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			bool isAlive = selector.SelectedEnemy.IsAlive;
			if (isAlive)
			{
				yield return base.DebuffAction<LockedOn>(selector.SelectedEnemy, base.Value1, 0, 0, 0, true, 0.2f);
			}
			yield break;
		}

		public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
		{
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, DamageInfo.HpLose((float)base.Value2, false), YoumuGunName.SpiritMediumBindSe, GunType.Single);
			yield break;
		}
	}
}
