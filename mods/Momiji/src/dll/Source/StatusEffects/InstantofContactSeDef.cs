using System;
using LBoL.ConfigData;

namespace Momiji.Source.StatusEffects
{
	public sealed class InstantofContactSeDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			return SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}
	}
}
