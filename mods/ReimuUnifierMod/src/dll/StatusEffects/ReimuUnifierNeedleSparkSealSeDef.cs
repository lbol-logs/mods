using System;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierNeedleSparkSealSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = false;
			defaultStatusEffectConfig.HasDuration = false;
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.IsStackable = false;
			return defaultStatusEffectConfig;
		}
	}
}
