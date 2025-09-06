using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using lvalonexrumia.Config;
using lvalonexrumia.Localization;

namespace lvalonexrumia.Enemies.Template
{
	public class lvalonexrumiaEnemyUnitTemplate : EnemyUnitTemplate
	{
		public override IdContainer GetId()
		{
			return lvalonexrumiaDefaultConfig.DefaultID(this);
		}

		public override EnemyUnitConfig MakeConfig()
		{
			return lvalonexrumiaDefaultConfig.EnemyUnitDefaultConfig();
		}

		public override LocalizationOption LoadLocalization()
		{
			return lvalonexrumiaLocalization.EnemiesUnitBatchLoc.AddEntity(this);
		}

		public override Type TemplateType()
		{
			return typeof(EnemyUnitTemplate);
		}

		public EnemyUnitConfig GetEnemyUnitDefaultConfig()
		{
			return lvalonexrumiaDefaultConfig.EnemyUnitDefaultConfig();
		}
	}
}
