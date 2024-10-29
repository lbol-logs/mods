using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.ImageLoader;
using Sanae_Kochiya.Source.Config;
using Sanae_Kochiya.Source.Localization;
using UnityEngine;

namespace Sanae_Kochiya.SampleCharacterUlt
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
