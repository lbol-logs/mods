using System;
using System.Collections;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using UnityEngine;

namespace Utsuho_character_mod
{
	[EntityLogic(typeof(UtsuhoUltBDef))]
	public sealed class UtsuhoUltB : UltimateSkill
	{
		public UtsuhoUltB()
		{
			base.TargetType = TargetType.AllEnemies;
			base.GunName = "Simple1";
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Battle.Player, "UtsuhoUltB");
			yield return new DamageAction(base.Owner, base.Battle.EnemyGroup.Alives, this.Damage, base.GunName, GunType.Single);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				Card[] cards = new Card[] { Library.CreateCard("DarkMatter") };
				yield return new AddCardsToDrawZoneAction(cards, DrawZoneTarget.Random, AddCardsType.Normal);
				yield return new AddCardsToHandAction(new Card[] { Library.CreateCard("DarkMatter") });
				yield return new AddCardsToDiscardAction(new Card[] { Library.CreateCard("DarkMatter") });
				cards = null;
			}
			yield break;
		}

		private IEnumerator DeactivateDeez(GameObject go)
		{
			yield return new WaitForSeconds(5f);
			go.SetActive(false);
			yield break;
		}
	}
}
