using System;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class ShieldCounterSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = true;
			return defaultStatusEffectConfig;
		}
	}
}
