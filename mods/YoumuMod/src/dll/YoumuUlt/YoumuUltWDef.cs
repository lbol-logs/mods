using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;

namespace YoumuCharacterMod.YoumuUlt
{
	public sealed class YoumuUltWDef : YoumuUltTemplate
	{
		public override IdContainer GetId()
		{
			return "YoumuUltW";
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 30, 2, 0, Keyword.Accuracy, new List<string>(), new List<string> { "YoumuSlashOfPresent" });
		}
	}
}
