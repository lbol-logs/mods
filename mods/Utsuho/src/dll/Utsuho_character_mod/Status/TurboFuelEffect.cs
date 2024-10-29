﻿using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace Utsuho_character_mod.Status
{
	public sealed class TurboFuelEffect : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return "TurboFuelStatus";
		}

		[DontOverwrite]
		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		[DontOverwrite]
		public override Sprite LoadSprite()
		{
			return ResourceLoader.LoadSprite("ChargingStatus.png", BepinexPlugin.embeddedSource, null, 1, null);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(0, "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.TurnEnd, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Exile, new List<string>(), "Default", "Default", "Default");
		}
	}
}
