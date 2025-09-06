using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardchewDef))]
	public sealed class cardchew : lvalonexrumiaCard
	{
		public int battleatk
		{
			get
			{
				return 2 + base.GrowCount * base.Value2;
			}
		}

		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, true);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			bool battleShouldEnd = base.Battle.BattleShouldEnd;
			if (battleShouldEnd)
			{
				yield break;
			}
			int num;
			for (int i = 0; i < this.battleatk; i = num + 1)
			{
				bool battleShouldEnd2 = base.Battle.BattleShouldEnd;
				if (battleShouldEnd2)
				{
					yield break;
				}
				yield return new DamageAction(base.Battle.Player, base.Battle.AllAliveEnemies, this.Damage, base.GunName, GunType.Single);
				num = i;
			}
			yield break;
		}
	}
}
