using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.Exhibits
{
	public sealed class PatchouliExhibitUDef : PatchouliExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Value2 = new int?(2);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Blue = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Blue);
			defaultExhibitConfig.RelativeCards = new List<string> { "PatchouliAstronomy" };
			return defaultExhibitConfig;
		}
	}
}
