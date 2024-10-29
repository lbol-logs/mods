using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.Exhibits
{
	public sealed class PatchouliExhibitBDef : PatchouliExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Value2 = new int?(1);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				Black = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.Black);
			defaultExhibitConfig.RelativeEffects = new List<string> { "PatchouliSignKeywordSe", "PatchouliFireSignSe" };
			return defaultExhibitConfig;
		}
	}
}
