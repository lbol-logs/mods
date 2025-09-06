using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Cards;

namespace lvalonexrumia.StatusEffects
{
	[EntityLogic(typeof(sebloodstormDef))]
	public sealed class sebloodstorm : StatusEffect
	{
		public int lim
		{
			get
			{
				return 4;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<StatusEffectApplyEventArgs>(unit.StatusEffectAdded, new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnStatusEffectAdded));
		}

		private IEnumerable<BattleAction> OnStatusEffectAdded(StatusEffectApplyEventArgs args)
		{
			bool flag = args.Effect is sebloodstorm;
			if (flag)
			{
				bool flag2 = base.Level >= this.lim;
				if (flag2)
				{
					base.NotifyActivating();
					yield return new AddCardsToHandAction(Library.CreateCards<cardbloodstorm>(base.Level / this.lim, false), AddCardsType.Normal);
					base.Level %= this.lim;
					bool flag3 = base.Level == 0;
					if (flag3)
					{
						yield return new RemoveStatusEffectAction(this, true, 0.1f);
					}
				}
			}
			yield break;
		}
	}
}
