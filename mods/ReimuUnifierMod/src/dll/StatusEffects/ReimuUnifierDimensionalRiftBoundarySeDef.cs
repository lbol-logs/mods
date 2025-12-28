using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierDimensionalRiftBoundarySeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasCount = true;
			defaultStatusEffectConfig.CountStackType = new StackType?(StackType.Add);
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			return defaultStatusEffectConfig;
		}
	}
}
