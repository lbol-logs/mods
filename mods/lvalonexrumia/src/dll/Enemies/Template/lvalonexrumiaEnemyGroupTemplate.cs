using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using lvalonexrumia.Config;

namespace lvalonexrumia.Enemies.Template
{
	public abstract class lvalonexrumiaEnemyGroupTemplate : EnemyGroupTemplate
	{
		public override IdContainer GetId()
		{
			return lvalonexrumiaDefaultConfig.DefaultID(this);
		}

		public override EnemyGroupConfig MakeConfig()
		{
			return lvalonexrumiaDefaultConfig.EnemyGroupDefaultConfig();
		}

		public EnemyGroupConfig GetEnemyGroupDefaultConfig()
		{
			return lvalonexrumiaDefaultConfig.EnemyGroupDefaultConfig();
		}
	}
}
