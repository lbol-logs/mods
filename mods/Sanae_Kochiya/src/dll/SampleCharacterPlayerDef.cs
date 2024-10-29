using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.ImageLoader;
using Sanae_Kochiya.Source.Localization;
using UnityEngine;

namespace Sanae_Kochiya
{
	public sealed class SampleCharacterPlayerDef : PlayerUnitTemplate
	{
		public UniTask<Sprite>? LoadSpellPortraitAsync { get; private set; }

		public override IdContainer GetId()
		{
			return BepinexPlugin.modUniqueID;
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.PlayerUnitBatchLoc.AddEntity(this);
		}

		public override PlayerImages LoadPlayerImages()
		{
			return SampleCharacterImageLoader.LoadPlayerImages(BepinexPlugin.playerName);
		}

		public override PlayerUnitConfig MakeConfig()
		{
			return SampleCharacterLoadouts.playerUnitConfig;
		}

		[EntityLogic(typeof(SampleCharacterPlayerDef))]
		public sealed class Sanae_Kochiya : PlayerUnit
		{
		}
	}
}
