using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Config;
using ReimuUnifierMod.ImageLoader;
using ReimuUnifierMod.Localization;

namespace ReimuUnifierMod.Exhibits
{
	public class ReimuUnifierExhibitTemplate : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.ExhibitsBatchLoc.AddEntity(this);
		}

		public override ExhibitSprites LoadSprite()
		{
			return ReimuUnifierImageLoader.LoadExhibitSprite(this);
		}

		public override ExhibitConfig MakeConfig()
		{
			return this.GetDefaultExhibitConfig();
		}

		public ExhibitConfig GetDefaultExhibitConfig()
		{
			return ReimuUnifierDefaultConfig.DefaultExhibitConfig();
		}
	}
}
