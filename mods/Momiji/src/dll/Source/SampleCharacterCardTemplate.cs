using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Momiji.Source.ImageLoader;
using Momiji.Source.Localization;

namespace Momiji.Source
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
