using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.ImageLoader;
using Sanae_Kochiya.Source.Config;
using Sanae_Kochiya.Source.Localization;
using UnityEngine;

namespace Sanae_Kochiya.StatusEffects
{
	public class SampleCharacterStatusEffectTemplate : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return SampleCharacterDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.StatusEffectsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return SampleCharacterImageLoader.LoadStatusEffectLoader(this);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return SampleCharacterDefaultConfig.GetDefaultStatusEffectConfig();
		}
	}
}
