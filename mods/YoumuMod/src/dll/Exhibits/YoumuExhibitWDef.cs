using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace YoumuCharacterMod.Exhibits
{
	public sealed class YoumuExhibitWDef : YoumuExhibitTemplate
	{
		public override ExhibitConfig MakeConfig()
		{
			ExhibitConfig defaultExhibitConfig = base.GetDefaultExhibitConfig();
			defaultExhibitConfig.Value1 = new int?(1);
			defaultExhibitConfig.Mana = new ManaGroup?(new ManaGroup
			{
				White = 1
			});
			defaultExhibitConfig.BaseManaColor = new ManaColor?(ManaColor.White);
			defaultExhibitConfig.RelativeCards = new List<string> { "YoumuSlashOfPresent" };
			return defaultExhibitConfig;
		}
	}
}
