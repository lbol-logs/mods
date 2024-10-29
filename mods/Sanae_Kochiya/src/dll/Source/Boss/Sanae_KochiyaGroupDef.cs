using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace Sanae_Kochiya.Source.Boss
{
	public sealed class Sanae_KochiyaGroupDef : EnemyGroupTemplate
	{
		public override IdContainer GetId()
		{
			return "Sanae_Kochiya";
		}

		public override EnemyGroupConfig MakeConfig()
		{
			return new EnemyGroupConfig("", "Sanae Act 1 Boss", "Single", new List<string> { "Sanae_Kochiya" }, EnemyType.Boss, 1f, true, new Vector2(-4f, 0.5f), "", "");
		}
	}
}
