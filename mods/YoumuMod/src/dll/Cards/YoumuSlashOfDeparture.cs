using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoLEntitySideloader.Attributes;
using YoumuCharacterMod.Cards.Template;

namespace YoumuCharacterMod.Cards
{
	[EntityLogic(typeof(YoumuSlashOfDepartureDef))]
	public sealed class YoumuSlashOfDeparture : YoumuCard
	{
		public override bool IsSlash { get; set; } = true;

		public override int AdditionalDamage
		{
			get
			{
				bool flag = base.Battle != null;
				int num2;
				if (flag)
				{
					int num = base.Battle.ExileZone.Count * base.Value1;
					num2 = num;
				}
				else
				{
					num2 = 0;
				}
				return num2;
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			yield return base.AttackAction(selector, base.GunName);
			yield break;
		}
	}
}
