using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using lvalonexrumia.Enemies.Template;

namespace lvalonexrumia.Enemies
{
	public sealed class lvalonexrumiaEnemyGroupDef : lvalonexrumiaEnemyGroupTemplate
	{
		public override IdContainer GetId()
		{
			return "lvalonexrumia";
		}

		public override EnemyGroupConfig MakeConfig()
		{
			EnemyGroupConfig enemyGroupDefaultConfig = base.GetEnemyGroupDefaultConfig();
			enemyGroupDefaultConfig.Name = "lvalonexrumia";
			enemyGroupDefaultConfig.FormationName = "Single";
			enemyGroupDefaultConfig.Enemies = new List<string> { "lvalonexrumia" };
			enemyGroupDefaultConfig.EnemyType = EnemyType.Boss;
			enemyGroupDefaultConfig.RollBossExhibit = true;
			return enemyGroupDefaultConfig;
		}
	}
}
