using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace Sanae_Kochiya.Exhibits
{
	public sealed class SanaeExhibitUDef : SampleCharacterExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(10);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Blue = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Blue);
			defaultExhibitConfig.Keywords = Keyword.Block;
			return defaultExhibitConfig;
		}
	}
}
