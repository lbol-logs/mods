using System;
using LBoL.Base;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class ImageTrainingSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.HasLevel = true;
			defaultStatusEffectConfig.LevelStackType = new StackType?(StackType.Add);
			defaultStatusEffectConfig.Order = 5;
			return defaultStatusEffectConfig;
		}
	}
}
