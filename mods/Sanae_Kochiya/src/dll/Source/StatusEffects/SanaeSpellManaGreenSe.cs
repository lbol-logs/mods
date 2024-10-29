﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace Sanae_Kochiya.Source.StatusEffects
{
	[EntityLogic(typeof(SanaeSpellManaGreenSeDef))]
	public sealed class SanaeSpellManaGreenSe : StatusEffect
	{
		public ManaGroup Mana
		{
			get
			{
				return new ManaGroup
				{
					Green = 1,
					Colorless = 1
				};
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UsUsingEventArgs>(base.Battle.UsUsed, new EventSequencedReactor<UsUsingEventArgs>(this.OnUsUsed));
		}

		private IEnumerable<BattleAction> OnUsUsed(UsUsingEventArgs args)
		{
			yield return new GainManaAction(new ManaGroup
			{
				Green = base.Level,
				Colorless = base.Level
			});
			yield break;
		}
	}
}
