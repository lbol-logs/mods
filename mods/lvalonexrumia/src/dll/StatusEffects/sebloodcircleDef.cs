using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.StatusEffects
{
	public sealed class sebloodcircleDef : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Positive;
			return defaultStatusEffectConfig;
		}
	}
}
