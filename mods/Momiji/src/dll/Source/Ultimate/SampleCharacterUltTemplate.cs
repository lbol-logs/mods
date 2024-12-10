using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Momiji.Source.ImageLoader;
using Momiji.Source.Localization;
using UnityEngine;

namespace Momiji.Source.Ultimate
{
	public class SampleCharacterUltTemplate : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			return SampleCharacterDefaultConfig.GetDefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.UltimateSkillsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return SampleCharacterImageLoader.LoadUltLoader(this);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			throw new NotImplementedException();
		}

		public UltimateSkillConfig GetDefaulUltConfig()
		{
			return SampleCharacterDefaultConfig.GetDefaultUltConfig();
		}
	}
}
