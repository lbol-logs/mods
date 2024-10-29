using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod
{
	public sealed class UtsuhoUltRDef : UltimateSkillTemplate
	{
		public override IdContainer GetId()
		{
			return "UtsuhoUltR";
		}

		public override LocalizationOption LoadLocalization()
		{
			return UsefulFunctions.LocalizationUlt(BepinexPlugin.directorySource);
		}

		public override Sprite LoadSprite()
		{
			return ResourceLoader.LoadSprite("Nuclear.png", BepinexPlugin.embeddedSource, null, 1, null);
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 30, 30, 0, Keyword.Accuracy, new List<string> { "HeatStatus" }, new List<string>());
		}
	}
}
