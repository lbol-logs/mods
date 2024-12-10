using System;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class FeedOnTheWeakSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.HasDuration = false;
			return defaultStatusEffectConfig;
		}
	}
}
