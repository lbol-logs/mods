using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.Ultimate
{
	public sealed class ExpelleesCananDef : SampleCharacterUltTemplate
	{
		public override UltimateSkillConfig MakeConfig()
		{
			UltimateSkillConfig defaulUltConfig = base.GetDefaulUltConfig();
			defaulUltConfig.Damage = 15;
			defaulUltConfig.Value1 = 2;
			defaulUltConfig.Value2 = 10;
			defaulUltConfig.Keywords = Keyword.Accuracy;
			return defaulUltConfig;
		}
	}
}
