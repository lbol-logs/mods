using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards.Template;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;

namespace lvalonexrumia.Cards
{
	[EntityLogic(typeof(cardtakeoverDef))]
	public sealed class cardtakeover : lvalonexrumiaCard
	{
		protected override int heal
		{
			get
			{
				return toolbox.hpfrompercent(Singleton<GameMaster>.Instance.CurrentGameRun.Player, base.Value1, false);
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return new ChangeLifeAction(-this.heal, null);
			yield return new ChangeLifeAction(-this.heal, null);
			yield return new ApplyStatusEffectAction<sebloodmark>(selector.SelectedEnemy, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<sebleed>(selector.SelectedEnemy, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<Weak>(selector.SelectedEnemy, new int?(1), new int?(1), new int?(0), new int?(0), 0.2f, true);
			yield return new ApplyStatusEffectAction<Vulnerable>(selector.SelectedEnemy, new int?(1), new int?(1), new int?(0), new int?(0), 0.2f, true);
			bool isUpgraded = this.IsUpgraded;
			if (isUpgraded)
			{
				yield return new ApplyStatusEffectAction<FirepowerNegative>(selector.SelectedEnemy, new int?(base.Value2), new int?(0), new int?(0), new int?(0), 0.2f, true);
			}
			int num;
			for (int i = 0; i < base.Value2; i = num + 1)
			{
				bool battleShouldEnd = base.Battle.BattleShouldEnd;
				if (battleShouldEnd)
				{
					yield break;
				}
				yield return base.AttackAction(selector, base.GunName);
				num = i;
			}
			yield break;
		}
	}
}
