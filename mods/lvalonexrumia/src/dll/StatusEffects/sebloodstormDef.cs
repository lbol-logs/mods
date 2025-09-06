using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace lvalonexrumia.StatusEffects
{
	public sealed class sebloodstormDef : lvalonexrumiaStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = lvalonexrumiaStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Special;
			return defaultStatusEffectConfig;
		}
	}
}
