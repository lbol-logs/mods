using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using LBoLEntitySideloader.Utils;
using UnityEngine;
using YoumuCharacterMod.Localization;

namespace YoumuCharacterMod.model
{
	public sealed class YoumuPlayerModel : UnitModelTemplate
	{
		public override IdContainer GetId()
		{
			return new YoumuPlayerDef().UniqueId;
		}

		public override LocalizationOption LoadLocalization()
		{
			return YoumuLocalization.UnitModelBatchLoc.AddEntity(this);
		}

		public override ModelOption LoadModelOptions()
		{
			return new ModelOption(ResourcesHelper.LoadSpineUnitAsync(this.model_name));
		}

		public override UniTask<Sprite> LoadSpellSprite()
		{
			return ResourcesHelper.LoadSpellPortraitAsync(this.model_name);
		}

		public override UnitModelConfig MakeConfig()
		{
			UnitModelConfig unitModelConfig = ObjectExtensions.Copy<UnitModelConfig>(UnitModelConfig.FromName(this.model_name));
			unitModelConfig.Flip = true;
			return unitModelConfig;
		}

		public string model_name = "Youmu";
	}
}
