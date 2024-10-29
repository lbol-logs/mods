using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using PatchouliCharacterMod.ImageLoader;
using PatchouliCharacterMod.Localization;

namespace PatchouliCharacterMod.Exhibits
{
	public class PatchouliExhibitTemplate : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return PatchouliDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.ExhibitsBatchLoc.AddEntity(this);
		}

		public override ExhibitSprites LoadSprite()
		{
			return PatchouliImageLoader.LoadExhibitSprite(this);
		}

		public override ExhibitConfig MakeConfig()
		{
			return this.GetDefaultExhibitConfig();
		}

		public ExhibitConfig GetDefaultExhibitConfig()
		{
			return PatchouliDefaultConfig.GetDefaultExhibitConfig();
		}

		protected string OwnerName = PatchouliPlayerDef.playerName;
	}
}
