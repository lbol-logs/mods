using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Config;
using lvalonexrumia.ImageLoader;
using lvalonexrumia.Localization;

namespace lvalonexrumia.Cards.Template
{
	public abstract class lvalonexrumiaCardTemplate : CardTemplate
	{
		public override IdContainer GetId()
		{
			return lvalonexrumiaDefaultConfig.DefaultID(this);
		}

		public override CardImages LoadCardImages()
		{
			return lvalonexrumiaImageLoader.LoadCardImages(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.CardsBatchLoc.AddEntity(this);
		}

		public CardConfig GetCardDefaultConfig()
		{
			return lvalonexrumiaDefaultConfig.CardDefaultConfig();
		}
	}
}
