﻿using System;
using LBoL.ConfigData;
using Sanae_Kochiya.StatusEffects;

namespace Sanae_Kochiya.Source.StatusEffects
{
	public sealed class SanaePowerPotatoSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			return SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}
	}
}
