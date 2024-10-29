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
using Utsuho_character_mod.Status;

namespace Utsuho_character_mod
{
	[EntityLogic(typeof(UtsuhoUltRDef))]
	public sealed class UtsuhoUltR : UltimateSkill
	{
		public UtsuhoUltR()
		{
			base.TargetType = TargetType.SingleEnemy;
			base.GunName = "Simple1";
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
		{
			yield return PerformAction.Spell(base.Battle.Player, "UtsuhoUltR");
			yield return new DamageAction(base.Owner, selector.GetEnemy(base.Battle), this.Damage, base.GunName, GunType.Single);
			bool flag = !base.Battle.BattleShouldEnd;
			if (flag)
			{
				yield return new ApplyStatusEffectAction<HeatStatus>(base.Battle.Player, new int?(base.Value1), null, null, null, 0f, true);
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
