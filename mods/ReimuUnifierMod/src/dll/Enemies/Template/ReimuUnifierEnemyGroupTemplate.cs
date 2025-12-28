using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using ReimuUnifierMod.Config;

namespace ReimuUnifierMod.Enemies.Template
{
	public abstract class ReimuUnifierEnemyGroupTemplate : EnemyGroupTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override EnemyGroupConfig MakeConfig()
		{
			return ReimuUnifierDefaultConfig.EnemyGroupDefaultConfig();
		}

		public EnemyGroupConfig GetEnemyGroupDefaultConfig()
		{
			return ReimuUnifierDefaultConfig.EnemyGroupDefaultConfig();
		}
	}
}
