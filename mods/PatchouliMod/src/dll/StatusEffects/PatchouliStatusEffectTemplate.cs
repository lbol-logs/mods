using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using PatchouliCharacterMod.ImageLoader;
using PatchouliCharacterMod.Localization;
using UnityEngine;

namespace PatchouliCharacterMod.StatusEffects
{
	public class PatchouliStatusEffectTemplate : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return PatchouliDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.StatusEffectsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return PatchouliImageLoader.LoadStatusEffectLoader(this);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return PatchouliStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return PatchouliDefaultConfig.GetDefaultStatusEffectConfig();
		}
	}
}
