using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSlashDrawDef))]
	public sealed class YoumuSlashDraw : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		public override IEnumerable<BattleAction> OnDraw()
		{
			yield return base.AttackAction(base.Battle.AllAliveEnemies, base.GunName);
			yield return new ExileCardAction(this);
			yield break;
		}
	}
}
