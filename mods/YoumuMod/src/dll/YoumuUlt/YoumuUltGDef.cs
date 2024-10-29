using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;

namespace YoumuCharacterMod.YoumuUlt
{
	public sealed class YoumuUltGDef : YoumuUltTemplate
	{
		public override IdContainer GetId()
		{
			return "YoumuUltG";
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 12, 3, 1, Keyword.Accuracy, new List<string> { "LockedOn" }, new List<string>());
		}
	}
}
