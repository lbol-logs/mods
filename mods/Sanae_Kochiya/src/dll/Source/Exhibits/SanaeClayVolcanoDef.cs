using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Exhibits;

namespace Sanae_Kochiya.Source.Exhibits
{
	public sealed class SanaeClayVolcanoDef : SampleCharacterExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.IsPooled = true;
			defaultExhibitConfig.Appearance = AppearanceType.Anywhere;
			defaultExhibitConfig.Owner = "";
			defaultExhibitConfig.LosableType = ExhibitLosableType.Losable;
			defaultExhibitConfig.Rarity = Rarity.Common;
			defaultExhibitConfig.BaseManaColor = null;
			defaultExhibitConfig.BaseManaAmount = 0;
			defaultExhibitConfig.Value1 = new int?(2);
			defaultExhibitConfig.RelativeEffects = new List<string> { "TempSpirit" };
			return defaultExhibitConfig;
		}
	}
}
