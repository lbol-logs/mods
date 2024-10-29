using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace PatchouliCharacterMod.StatusEffects
{
	[EntityLogic(typeof(PatchouliOneWeekGirlSeDef))]
	public sealed class PatchouliOneWeekGirlSe : StatusEffect
	{
		public string NextSign
		{
			get
			{
				string[] array = base.Brief.Split(" ", StringSplitOptions.None);
				return array[(base.Count + 1) % 7];
			}
		}

		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<UnitEventArgs>(base.Battle.Player.TurnStarted, new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
		}

		private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
		{
			base.NotifyActivating();
			base.Count = (base.Count + 1) % 7;
			switch (base.Count)
			{
			case 0:
				yield return new ApplyStatusEffectAction<PatchouliFireSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 1:
				yield return new ApplyStatusEffectAction<PatchouliWaterSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 2:
				yield return new ApplyStatusEffectAction<PatchouliWoodSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 3:
				yield return new ApplyStatusEffectAction<PatchouliMetalSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 4:
				yield return new ApplyStatusEffectAction<PatchouliEarthSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 5:
				yield return new ApplyStatusEffectAction<PatchouliSunSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			case 6:
				yield return new ApplyStatusEffectAction<PatchouliMoonSignSe>(base.Battle.Player, new int?(base.Level), new int?(0), new int?(PatchouliSignSe.TurnLimit), new int?(0), 0.2f, true);
				break;
			}
			yield break;
		}
	}
}
