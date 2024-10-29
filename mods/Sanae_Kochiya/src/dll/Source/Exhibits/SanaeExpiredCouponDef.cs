using System;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.Exhibits;

namespace Sanae_Kochiya.Source.Exhibits
{
	public sealed class SanaeExpiredCouponDef : SampleCharacterExhibitTemplate
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
			defaultExhibitConfig.Value1 = new int?(20);
			defaultExhibitConfig.Keywords = Keyword.Power;
			return defaultExhibitConfig;
		}
	}
}
