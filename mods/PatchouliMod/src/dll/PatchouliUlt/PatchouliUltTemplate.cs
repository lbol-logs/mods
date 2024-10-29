using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using PatchouliCharacterMod.ImageLoader;
using PatchouliCharacterMod.Localization;
using UnityEngine;

namespace PatchouliCharacterMod.PatchouliUlt
{
	public class PatchouliUltTemplate : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			return PatchouliDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return PatchouliLocalization.UltimateSkillsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return PatchouliImageLoader.LoadUltLoader(this);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			throw new NotImplementedException();
		}
	}
}
