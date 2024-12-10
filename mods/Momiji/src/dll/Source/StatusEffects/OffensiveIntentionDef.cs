using System;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class OffensiveIntentionDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.Order = 5;
			return defaultStatusEffectConfig;
		}
	}
}
