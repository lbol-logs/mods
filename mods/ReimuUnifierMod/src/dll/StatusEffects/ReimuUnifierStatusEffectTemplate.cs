using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Config;
using ReimuUnifierMod.ImageLoader;
using ReimuUnifierMod.Localization;
using UnityEngine;

namespace ReimuUnifierMod.StatusEffects
{
	public class ReimuUnifierStatusEffectTemplate : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.StatusEffectsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return ReimuUnifierImageLoader.LoadStatusEffectLoader(this);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public static StatusEffectConfig GetDefaultStatusEffectConfig()
		{
			return ReimuUnifierDefaultConfig.DefaultStatusEffectConfig();
		}
	}
}
