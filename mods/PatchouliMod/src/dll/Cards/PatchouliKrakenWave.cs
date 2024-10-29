using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;
using PatchouliCharacterMod.BattleActions;
using PatchouliCharacterMod.Cards.Template;
using PatchouliCharacterMod.Patch;

namespace PatchouliCharacterMod.Cards
{
	[EntityLogic(typeof(PatchouliKrakenWaveDef))]
	public sealed class PatchouliKrakenWave : PatchouliBoostCard
	{
		protected override bool HasTreshold { get; set; } = true;

		protected override int BoostThreshold1 { get; set; } = 9;

		protected override void OnEnterBattle(BattleController battle)
		{
			base.OnEnterBattle(battle);
			base.ReactBattleEvent<BoostEventArgs>(CustomGameEventPatch.Boosted, new EventSequencedReactor<BoostEventArgs>(this.OnBoosted));
		}

		public IEnumerable<BattleAction> OnBoosted(BoostEventArgs args)
		{
			bool meetBoostThreshold = base.MeetBoostThreshold1;
			if (meetBoostThreshold)
			{
				yield return new DamageAction(base.Battle.Player, base.Battle.EnemyGroup.Alives, DamageInfo.Reaction((float)base.Value1, false), base.GunName, GunType.Single);
				bool flag = !base.Battle.BattleShouldEnd;
				if (flag)
				{
					yield return new CastBlockShieldAction(base.Battle.Player, new BlockInfo(base.Value1, BlockShieldType.Direct), false);
					base.ResetBoost();
					yield return new DiscardAction(this);
				}
			}
			yield break;
		}
	}
}
