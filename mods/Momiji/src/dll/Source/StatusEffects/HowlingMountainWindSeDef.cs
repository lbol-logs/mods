using System;
using System.Collections.Generic;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class HowlingMountainWindSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "Vulnerable" };
			defaultStatusEffectConfig.Order = 10;
			return defaultStatusEffectConfig;
		}
	}
}
