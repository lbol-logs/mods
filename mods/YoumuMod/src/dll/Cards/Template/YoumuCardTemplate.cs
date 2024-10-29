using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using YoumuCharacterMod.DefaultConfig;
using YoumuCharacterMod.ImageLoader;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod.Cards.Template
{
	public class YoumuCardTemplate : CardTemplate
	{
		public override IdContainer GetId()
		{
			return YoumuDefaultConfig.GetDefaultID(this);
		}

		public override CardImages LoadCardImages()
		{
			return YoumuImageLoader.LoadCardImages(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.CardsBatchLoc.AddEntity(this);
		}

		public override CardConfig MakeConfig()
		{
			throw new NotImplementedException();
		}

		public CardConfig GetCardDefaultConfig()
		{
			return YoumuDefaultConfig.GetCardDefaultConfig();
		}

		protected string OwnerName = YoumuPlayerDef.modName;
	}
}
