using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace YoumuCharacterMod.Exhibits
{
	public sealed class YoumuExhibitGDef : YoumuExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Green = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Green);
			defaultExhibitConfig.RelativeEffects = new List<string> { "LockedOn" };
			return defaultExhibitConfig;
		}
	}
}
