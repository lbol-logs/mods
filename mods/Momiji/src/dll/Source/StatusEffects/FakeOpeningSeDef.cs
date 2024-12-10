using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class FakeOpeningSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = true;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			defaultStatusEffectConfig.RelativeEffects = new List<string> { "RetaliationSe" };
			defaultStatusEffectConfig.Order = 5;
			return defaultStatusEffectConfig;
		}
	}
}
