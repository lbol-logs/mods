using System;
using LBoL.ConfigData;

namespace ReimuUnifierMod.StatusEffects
{
	public sealed class ReimuUnifierDanmakuCollisionSeDef : ReimuUnifierStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			return ReimuUnifierStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}
	}
}
