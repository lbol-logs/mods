using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.Exhibits
{
	public sealed class exexaDef : lvalonexrumiaExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Value2 = new int?(5);
			defaultExhibitConfig.Order = 4;
			defaultExhibitConfig.HasCounter = true;
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Black = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Black);
			defaultExhibitConfig.RelativeEffects = new List<string> { "sebloodmark" };
			return defaultExhibitConfig;
		}
	}
}
