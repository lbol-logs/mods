using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Ultimate
{
	public sealed class RabiesBiteDef : SampleCharacterUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.Damage = 15;
			defaulUltConfig.Value1 = 3;
			defaulUltConfig.Value2 = 4;
			defaulUltConfig.Keywords = Keyword.Accuracy;
			defaulUltConfig.RelativeEffects = new List<string> { "Vulnerable" };
			return defaulUltConfig;
		}
	}
}
