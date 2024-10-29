using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.PatchouliUlt
{
	public sealed class PatchouliUltUDef : PatchouliUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 38, 1, 1, Keyword.Accuracy, new List<string> { "PatchouliBoostSe" }, new List<string>());
		}
	}
}
