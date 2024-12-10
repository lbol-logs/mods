using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class RetaliationSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "Reflect" };
			defaultStatusEffectConfig.HasLevel = true;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			return defaultStatusEffectConfig;
		}
	}
}
