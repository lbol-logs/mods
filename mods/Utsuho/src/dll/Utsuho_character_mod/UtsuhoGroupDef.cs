using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace Utsuho_character_mod
{
	public sealed class UtsuhoGroupDef : EnemyGroupTemplate
	{
		public override IdContainer GetId()
		{
			return "Utsuho";
		}

		public override EnemyGroupConfig MakeConfig()
		{
			return new EnemyGroupConfig("", "UtsuhoBoss", "Single", new List<string> { "Utsuho" }, EnemyType.Boss, 1f, true, new Vector2(-4f, 0.5f), "", "");
		}
	}
}
