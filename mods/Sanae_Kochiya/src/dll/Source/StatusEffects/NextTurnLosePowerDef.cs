using System;
using LBoL.Base;
using LBoL.ConfigData;
using Sanae_Kochiya.StatusEffects;

namespace Sanae_Kochiya.Source.StatusEffects
{
	public sealed class NextTurnLosePowerDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			StatusEffectConfig defaultStatusEffectConfig = SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
			defaultStatusEffectConfig.Type = StatusEffectType.Special;
			return defaultStatusEffectConfig;
		}
	}
}
