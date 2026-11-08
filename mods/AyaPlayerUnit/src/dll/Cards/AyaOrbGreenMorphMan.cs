using System;
using System.Collections.Generic;
using LBoL.Core.Battle;
using LBoL.EntityLib.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaOrbGreenMorphManDef))]
	public sealed class AyaOrbGreenMorphMan : OptionCard
	{
		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			AyaOrbGreenMorphMan.<TakeEffectActions>d__0 <TakeEffectActions>d__ = new AyaOrbGreenMorphMan.<TakeEffectActions>d__0(-2);
			<TakeEffectActions>d__.<>4__this = this;
			return <TakeEffectActions>d__;
		}
	}
}
