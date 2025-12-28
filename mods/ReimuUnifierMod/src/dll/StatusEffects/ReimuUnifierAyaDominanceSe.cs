using System;
using System.Collections.Generic;
using System.Linq;
using LBoL.Base.Extensions;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace ReimuUnifierMod.StatusEffects
{
	[EntityLogic(typeof(ReimuUnifierAyaDominanceSeDef))]
	public sealed class ReimuUnifierAyaDominanceSe : StatusEffect
	{
		protected override void OnAdded(Unit unit)
		{
			base.ReactOwnerEvent<CardUsingEventArgs>(base.Battle.CardUsed, new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
		}

		private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
		{
			bool flag = !this.Battle.BattleShouldEnd && base.Battle.AllAliveEnemies.Count<EnemyUnit>() > 0;
			if (flag)
			{
				EnemyUnit target = base.Battle.EnemyGroup.Alives.SampleOrDefault(base.Battle.GameRun.BattleRng);
				yield return new DamageAction(base.Battle.Player, target, DamageInfo.Reaction((float)base.Level, false), "新闻", GunType.Single);
				target = null;
			}
			yield break;
		}
	}
}
