using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.Exhibits
{
	public sealed class exrumiafumoDef : lvalonexrumiaExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Owner = null;
			defaultExhibitConfig.IsPooled = true;
			defaultExhibitConfig.BaseManaColor = null;
			defaultExhibitConfig.Revealable = false;
			defaultExhibitConfig.LosableType = ExhibitLosableType.Losable;
			defaultExhibitConfig.Rarity = Rarity.Uncommon;
			defaultExhibitConfig.Appearance = AppearanceType.Anywhere;
			defaultExhibitConfig.RelativeCards = new List<string> { "cardredblood", "carddarkblood" };
			defaultExhibitConfig.Value1 = new int?(1);
			return defaultExhibitConfig;
		}
	}
}
