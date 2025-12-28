using System;
using Cysharp.Threading.Tasks;
using LBoL.ConfigData;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.ImageLoader;
using ReimuUnifierMod.Localization;
using UnityEngine;

namespace ReimuUnifierMod
{
	public sealed class ReimuUnifierModDef : PlayerUnitTemplate
	{
		public UniTask<Sprite>? LoadSpellPortraitAsync { get; private set; }

		public override IdContainer GetId()
		{
			return BepinexPlugin.modUniqueID;
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.PlayerUnitBatchLoc.AddEntity(this);
		}

		public override PlayerImages LoadPlayerImages()
		{
			return ReimuUnifierImageLoader.LoadPlayerImages(BepinexPlugin.playerName);
		}

		public override PlayerUnitConfig MakeConfig()
		{
			return ReimuUnifierLoadouts.playerUnitConfig;
		}

		[EntityLogic(typeof(ReimuUnifierModDef))]
		public sealed class ReimuUnifierMod : PlayerUnit
		{
			public string LocShortcut(string key, bool decorated, bool required)
			{
				return this.LocalizeProperty(key, decorated, required);
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.DialogueTriggered = false;
			}

			public bool DialogueTriggered = false;
		}
	}
}
