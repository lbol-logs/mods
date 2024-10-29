using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using YoumuCharacterMod.DefaultConfig;
using YoumuCharacterMod.ImageLoader;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod.StatusEffects
{
	public class YoumuStatusEffectTemplate : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return YoumuDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.StatusEffectsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return YoumuImageLoader.LoadStatusEffectLoader(this);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return YoumuStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return YoumuDefaultConfig.GetDefaultStatusEffectConfig();
		}
	}
}
