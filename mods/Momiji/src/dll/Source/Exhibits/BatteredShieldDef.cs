using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Exhibits
{
	public sealed class BatteredShieldDef : SampleCharacterExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(3);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.White);
			defaultExhibitConfig.RelativeEffects = new List<string> { "Reflect" };
			return defaultExhibitConfig;
		}
	}
}
