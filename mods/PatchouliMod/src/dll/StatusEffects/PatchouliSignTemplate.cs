using System;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.StatusEffects
{
	public class PatchouliSignTemplate : PatchouliStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = PatchouliStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
