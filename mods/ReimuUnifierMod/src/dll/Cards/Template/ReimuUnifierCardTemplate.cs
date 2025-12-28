using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Config;
using ReimuUnifierMod.ImageLoader;
using ReimuUnifierMod.Localization;

namespace ReimuUnifierMod.Cards.Template
{
	public abstract class ReimuUnifierCardTemplate : CardTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override CardImages LoadCardImages()
		{
			return ReimuUnifierImageLoader.LoadCardImages(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.CardsBatchLoc.AddEntity(this);
		}

		public CardConfig GetCardDefaultConfig()
		{
			return ReimuUnifierDefaultConfig.CardDefaultConfig();
		}
	}
}
