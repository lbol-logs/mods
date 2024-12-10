using System;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class FrigidSkySeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = false;
			return defaultStatusEffectConfig;
		}
	}
}
