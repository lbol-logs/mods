using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.Exhibits
{
	public sealed class exexbDef : lvalonexrumiaExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Red);
			defaultExhibitConfig.RelativeEffects = new List<string> { "sebleed" };
			return defaultExhibitConfig;
		}
	}
}
