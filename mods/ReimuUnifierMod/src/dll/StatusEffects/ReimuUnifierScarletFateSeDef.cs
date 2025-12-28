using System;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierScarletFateSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.HasDuration = true;
			return defaultStatusEffectConfig;
		}
	}
}
