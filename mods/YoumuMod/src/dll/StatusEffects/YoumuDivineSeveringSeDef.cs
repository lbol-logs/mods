using System;
using LBoL.ConfigData;

namespace YoumuCharacterMod.StatusEffects
{
	public sealed class YoumuDivineSeveringSeDef : YoumuStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = YoumuStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
