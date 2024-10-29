using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.ImageLoader;
using Sanae_Kochiya.Source.Config;
using Sanae_Kochiya.Source.Localization;

namespace Sanae_Kochiya.Cards.Template
{
	public abstract class SampleCharacterCardTemplate : CardTemplate
	{
		public override IdContainer GetId()
		{
			return SampleCharacterDefaultConfig.GetDefaultID(this);
		}

		public override CardImages LoadCardImages()
		{
			return SampleCharacterImageLoader.LoadCardImages(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.CardsBatchLoc.AddEntity(this);
		}

		public CardConfig GetCardDefaultConfig()
		{
			return SampleCharacterDefaultConfig.GetCardDefaultConfig();
		}
	}
}
