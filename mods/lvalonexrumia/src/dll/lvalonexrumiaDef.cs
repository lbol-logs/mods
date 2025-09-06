using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Enemies;
using lvalonexrumia.ImageLoader;
using lvalonexrumia.Localization;
using UnityEngine;

namespace lvalonexrumia
{
	public sealed class lvalonexrumiaDef : PlayerUnitTemplate
	{
		public UniTask<Sprite>? LoadSpellPortraitAsync { get; private set; }

		public override IdContainer GetId()
		{
			return BepinexPlugin.modUniqueID;
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.PlayerUnitBatchLoc.AddEntity(this);
		}

		public override PlayerImages LoadPlayerImages()
		{
			return lvalonexrumiaImageLoader.LoadPlayerImages(BepinexPlugin.playerName);
		}

		public override PlayerUnitTemplate.EikiSummonInfo AssociateEikiSummon()
		{
			return new PlayerUnitTemplate.EikiSummonInfo(typeof(global::lvalonexrumia.Enemies.lvalonexrumia), null);
		}

		public override PlayerUnitConfig MakeConfig()
		{
			return lvalonexrumiaLoadouts.playerUnitConfig;
		}

		[EntityLogic(typeof(lvalonexrumiaDef))]
		public sealed class lvalonexrumia : PlayerUnit
		{
		}
	}
}
