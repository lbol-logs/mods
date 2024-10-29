using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards;
using YoumuCharacterMod.GunName;

namespace YoumuCharacterMod.YoumuUlt
{
	[EntityLogic(typeof(YoumuUltWDef))]
	public sealed class YoumuUltW : UltimateSkill
	{
		public YoumuUltW()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = YoumuGunName.UltimateSkillW;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			EnemyUnit enemy = selector.GetEnemy(base.Battle);
			yield return new DamageAction(base.Owner, enemy, this.Damage, base.GunName, GunType.Single);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			int num;
			for (int i = 0; i < base.Value1; i = num + 1)
			{
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard<YoumuSlashOfPresent>() });
				num = i;
			}
			yield break;
		}
	}
}
