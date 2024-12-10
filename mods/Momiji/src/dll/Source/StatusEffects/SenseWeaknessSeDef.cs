using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class SenseWeaknessSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = true;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "Vulnerable" };
			defaultStatusEffectConfig.Order = 5;
			return defaultStatusEffectConfig;
		}
	}
}
