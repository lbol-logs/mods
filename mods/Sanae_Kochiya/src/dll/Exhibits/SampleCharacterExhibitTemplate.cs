using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.ImageLoader;
using Sanae_Kochiya.Source.Config;
using Sanae_Kochiya.Source.Localization;

namespace Sanae_Kochiya.Exhibits
{
	public class SampleCharacterExhibitTemplate : ExhibitTemplate
	{
		public override IdContainer GetId()
		{
			return SampleCharacterDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.ExhibitsBatchLoc.AddEntity(this);
		}

		public override ExhibitSprites LoadSprite()
		{
			return SampleCharacterImageLoader.LoadExhibitSprite(this);
		}

		public override ExhibitConfig MakeConfig()
		{
			return this.GetDefaultExhibitConfig();
		}

		public ExhibitConfig GetDefaultExhibitConfig()
		{
			return SampleCharacterDefaultConfig.GetDefaultExhibitConfig();
		}
	}
}
