using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Exhibits
{
	public sealed class HeavyBladeDef : SampleCharacterExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(2);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Red = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Red);
			return defaultExhibitConfig;
		}
	}
}
