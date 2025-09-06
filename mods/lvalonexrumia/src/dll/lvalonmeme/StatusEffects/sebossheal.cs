using System;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader.Attributes;

namespace lvalonmeme.StatusEffects
{
	[EntityLogic(typeof(sebosshealDef))]
	public sealed class sebossheal : StatusEffect
	{
		public override bool ForceNotShowDownText
		{
			get
			{
				return true;
			}
		}
	}
}
