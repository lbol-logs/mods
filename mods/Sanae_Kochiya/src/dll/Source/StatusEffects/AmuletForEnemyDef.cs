using System;
using LBoL.ConfigData;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.StatusEffects;
using UnityEngine;

namespace Sanae_Kochiya.Source.StatusEffects
{
	public sealed class AmuletForEnemyDef : SampleCharacterStatusEffectTemplate
	{
		public override StatusEffectConfig MakeConfig()
		{
			return SampleCharacterStatusEffectTemplate.GetDefaultStatusEffectConfig();
		}

		public override Sprite LoadSprite()
		{
			return ResourceLoader.LoadSprite("Bulwark.png", BepinexPlugin.embeddedSource, null, 1, null);
		}
	}
}
