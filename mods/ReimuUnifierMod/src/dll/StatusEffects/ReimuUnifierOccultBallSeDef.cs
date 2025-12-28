using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierOccultBallSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = false;
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.CountStackType = new StackType?(StackType.Add);
			return defaultStatusEffectConfig;
		}
	}
}
