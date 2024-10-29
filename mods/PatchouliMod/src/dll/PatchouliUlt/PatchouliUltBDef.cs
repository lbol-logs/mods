using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.PatchouliUlt
{
	public sealed class PatchouliUltBDef : PatchouliUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 40, 1, 0, Keyword.Accuracy, new List<string> { "PatchouliSignKeywordSe", "PatchouliMoonSignSe" }, new List<string>());
		}
	}
}
