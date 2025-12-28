using System;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierAunnProtectionSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			return ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}
	}
}
