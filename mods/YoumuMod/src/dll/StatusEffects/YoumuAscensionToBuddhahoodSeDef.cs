using System;
using LBoL.ConfigData;

namespace YoumuCharacterMod.StatusEffects
{
	public sealed class YoumuAscensionToBuddhahoodSeDef : YoumuStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = YoumuStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
