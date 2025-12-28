using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierWilyBeastStrikeSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.IsStackable = true;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			return defaultStatusEffectConfig;
		}
	}
}
