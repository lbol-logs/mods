using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Momiji.Source.ImageLoader;
using Momiji.Source.Localization;
using UnityEngine;

namespace Momiji.Source.StatusEffects
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
