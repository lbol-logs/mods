using System;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.StatusEffects
{
	public sealed class PatchouliSatelliteHimawariSeDef : PatchouliStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = PatchouliStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
