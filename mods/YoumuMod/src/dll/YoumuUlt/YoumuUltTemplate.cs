using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using YoumuCharacterMod.ImageLoader;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod.YoumuUlt
{
	public class YoumuUltTemplate : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			throw new NotImplementedException();
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.UltimateSkillsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return YoumuImageLoader.LoadUltLoader(this);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			throw new NotImplementedException();
		}
	}
}
