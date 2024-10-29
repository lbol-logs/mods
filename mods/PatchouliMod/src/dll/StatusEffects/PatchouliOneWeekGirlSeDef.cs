using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace PatchouliCharacterMod.StatusEffects
{
	public sealed class PatchouliOneWeekGirlSeDef : PatchouliStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = PatchouliStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.IsStackable = false;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Keep);
			defaultStatusEffectConfig.HasCount = true;
			return defaultStatusEffectConfig;
		}
	}
}
