using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.Core.Cards;

namespace Utsuho_character_mod.Util
{
	public abstract class UtsuhoCard : Card
	{
		public virtual bool isMass { get; set; }

		public UtsuhoCard()
		{
			this.isMass = false;
		}

		public virtual IEnumerable<BattleAction> OnPull()
		{
			yield break;
		}
	}
}
