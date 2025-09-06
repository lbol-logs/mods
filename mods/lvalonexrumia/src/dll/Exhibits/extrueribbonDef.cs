using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.Exhibits
{
	public sealed class extrueribbonDef : lvalonexrumiaExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Order = 1;
			defaultExhibitConfig.Value1 = new int?(2);
			defaultExhibitConfig.Value2 = new int?(10);
			defaultExhibitConfig.Owner = null;
			defaultExhibitConfig.Revealable = true;
			defaultExhibitConfig.LosableType = ExhibitLosableType.CantLose;
			defaultExhibitConfig.Rarity = Rarity.Mythic;
			defaultExhibitConfig.Appearance = AppearanceType.Nowhere;
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Philosophy);
			defaultExhibitConfig.RelativeEffects = new List<string> { "sebloodmark", "sedeepbleed" };
			return defaultExhibitConfig;
		}
	}
}
