using System;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierFantasySealDreamfiniteSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.IsStackable = false;
			return defaultStatusEffectConfig;
		}
	}
}
