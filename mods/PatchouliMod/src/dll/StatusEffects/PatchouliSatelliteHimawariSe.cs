using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliSatelliteHimawariSeDef))]
	public sealed class PatchouliSatelliteHimawariSe : StatusEffect
	{
		public int BonusDamage
		{
			get
			{
				return base.Level * base.Count;
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<TriggerSignEventArgs>(CustomGameEventPatch.SignActiveTriggering, new EventSequencedReactor<TriggerSignEventArgs>(this.OnSignActiveTriggering));
		}

		private IEnumerable<BattleAction> OnSignActiveTriggering(TriggerSignEventArgs args)
		{
			bool flag = args.Sign is PatchouliWoodSignSe;
			if (flag)
			{
				bool flag2 = base.Battle.Player.HasStatusEffect<PatchouliWoodSignSe>();
				if (flag2)
				{
					base.NotifyActivating();
					base.Count += base.Battle.Player.GetStatusEffect<PatchouliWoodSignSe>().ActiveAmount;
				}
			}
			yield break;
		}
	}
}
