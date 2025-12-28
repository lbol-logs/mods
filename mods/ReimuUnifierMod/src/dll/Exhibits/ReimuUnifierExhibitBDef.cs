using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod.Exhibits
{
	public sealed class ReimuUnifierExhibitBDef : ReimuUnifierExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.White);
			defaultExhibitConfig.RelativeEffects = new List<string>();
			return defaultExhibitConfig;
		}
	}
}
