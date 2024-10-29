using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Sanae_Kochiya.Exhibits
{
	public sealed class SanaeExhibitWDef : SampleCharacterExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(2);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.White);
			defaultExhibitConfig.RelativeEffects = new List<string> { "AmuletForCard" };
			return defaultExhibitConfig;
		}
	}
}
