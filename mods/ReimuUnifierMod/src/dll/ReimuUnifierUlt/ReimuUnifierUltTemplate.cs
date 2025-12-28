using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Config;
using ReimuUnifierMod.ImageLoader;
using ReimuUnifierMod.Localization;
using UnityEngine;

namespace ReimuUnifierMod.ReimuUnifierUlt
{
	public class ReimuUnifierUltTemplate : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.UltimateSkillsBatchLoc.AddEntity(this);
		}

		public override Sprite LoadSprite()
		{
			return ReimuUnifierImageLoader.LoadUltLoader(this);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			throw new NotImplementedException();
		}

		public UltimateSkillConfig GetDefaulUltConfig()
		{
			return ReimuUnifierDefaultConfig.DefaultUltConfig();
		}
	}
}
