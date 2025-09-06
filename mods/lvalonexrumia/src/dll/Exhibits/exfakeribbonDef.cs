using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.Exhibits
{
	public sealed class exfakeribbonDef : lvalonexrumiaExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Owner = null;
			defaultExhibitConfig.IsPooled = true;
			defaultExhibitConfig.BaseManaColor = null;
			defaultExhibitConfig.Revealable = false;
			defaultExhibitConfig.LosableType = ExhibitLosableType.Losable;
			defaultExhibitConfig.Rarity = Rarity.Rare;
			defaultExhibitConfig.Appearance = AppearanceType.ShopOnly;
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 1
			});
			return defaultExhibitConfig;
		}
	}
}
