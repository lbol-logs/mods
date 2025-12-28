using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod.Exhibits
{
	public sealed class ReimuUnifierExhibitADef : ReimuUnifierExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.HasCounter = true;
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
