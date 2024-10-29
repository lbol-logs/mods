using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using PatchouliCharacterMod.ImageLoader;
using PatchouliCharacterMod.Localization;

namespace PatchouliCharacterMod.Cards.Template
{
	public class PatchouliCardTemplate : CardTemplate
	{
		public override IdContainer GetId()
		{
			return PatchouliDefaultConfig.GetDefaultID(this);
		}

		public override CardImages LoadCardImages()
		{
			return PatchouliImageLoader.LoadCardImages(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.CardsBatchLoc.AddEntity(this);
		}

		public override CardConfig MakeConfig()
		{
			throw new NotImplementedException();
		}

		public CardConfig GetCardDefaultConfig()
		{
			return PatchouliDefaultConfig.GetCardDefaultConfig();
		}

		protected string OwnerName = PatchouliPlayerDef.modName;
	}
}
