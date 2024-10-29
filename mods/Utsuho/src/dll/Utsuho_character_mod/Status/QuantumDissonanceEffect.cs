using System;
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
	public sealed class QuantumDissonanceEffect : StatusEffectTemplate
	{
		public override IdContainer GetId()
		{
			return "QuantumDissonanceStatus";
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
			return ResourceLoader.LoadSprite("ReactorStartSe.png", BepinexPlugin.embeddedSource, null, 1, null);
		}

		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(0, "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, true, new StackType?(StackType.Add), new StackType?(StackType.Keep), false, Keyword.None, new List<string> { "Reflect" }, "Default", "Default", "Default");
		}
	}
}
