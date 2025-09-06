using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardtenshadedDef))]
	public sealed class cardtenshaded : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, false);
			}
		}

		protected override int BaseValue3
		{
			get
			{
				return 3;
			}
		}

		protected override int BaseUpgradedValue3
		{
			get
			{
				return 3;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return PerformAction.Spell(base.Battle.Player, "extenshaded");
			yield return new ChangeLifeAction(-this.heal, null);
			foreach (Unit unit in base.Battle.AllAliveEnemies)
			{
				bool flag = base.Battle.BattleShouldEnd || !this.IsUpgraded;
				if (!flag)
				{
					yield return new ApplyStatusEffectAction<sebloodmark>(unit, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
					unit = null;
				}
			}
			IEnumerator<EnemyUnit> enumerator = null;
			int num;
			for (int i = 0; i < base.Value2; i = num + 1)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				yield return new DamageAction(base.Battle.Player, base.Battle.RandomAliveEnemy, this.Damage, base.GunName, GunType.Single);
				num = i;
			}
			yield return new AddCardsToHandAction(Library.CreateCards<Shadow>(base.Value3, false), AddCardsType.Normal);
			yield break;
			yield break;
		}
	}
}
