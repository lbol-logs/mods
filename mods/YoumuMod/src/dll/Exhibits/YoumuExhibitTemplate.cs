using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using YoumuCharacterMod.DefaultConfig;
using YoumuCharacterMod.ImageLoader;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod.Exhibits
{
	public class YoumuExhibitTemplate : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return YoumuDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.ExhibitsBatchLoc.AddEntity(this);
		}

		public override ExhibitSprites LoadSprite()
		{
			return YoumuImageLoader.LoadExhibitSprite(this);
		}

		public override ExhibitConfig MakeConfig()
		{
			return this.GetDefaultExhibitConfig();
		}

		public ExhibitConfig GetDefaultExhibitConfig()
		{
			return YoumuDefaultConfig.GetDefaultExhibitConfig();
		}

		protected string OwnerName = YoumuPlayerDef.playerName;
	}
}
