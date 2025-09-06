using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Config;
using lvalonexrumia.ImageLoader;
using lvalonexrumia.Localization;
using UnityEngine;

namespace lvalonexrumia.StatusEffects
{
	public class lvalonexrumiaStatusEffectTemplate : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return lvalonexrumiaDefaultConfig.DefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.StatusEffectsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return lvalonexrumiaImageLoader.LoadStatusEffectLoader(this);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return lvalonexrumiaDefaultConfig.DefaultStatusEffectConfig();
		}
	}
}
