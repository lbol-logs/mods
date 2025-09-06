using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Config;
using lvalonexrumia.ImageLoader;
using lvalonexrumia.Localization;
using UnityEngine;

namespace lvalonexrumia.lvalonexrumiaUlt
{
	public class lvalonexrumiaUltTemplate : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			return lvalonexrumiaDefaultConfig.DefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.UltimateSkillsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return lvalonexrumiaImageLoader.LoadUltLoader(this);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			throw new NotImplementedException();
		}

		public UltimateSkillConfig GetDefaulUltConfig()
		{
			return lvalonexrumiaDefaultConfig.DefaultUltConfig();
		}
	}
}
