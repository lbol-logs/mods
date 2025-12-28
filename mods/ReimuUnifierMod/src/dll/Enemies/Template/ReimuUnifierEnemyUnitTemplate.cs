using System;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using ReimuUnifierMod.Config;
using ReimuUnifierMod.Localization;

namespace ReimuUnifierMod.Enemies.Template
{
	public class ReimuUnifierEnemyUnitTemplate : EnemyUnitTemplate
	{
		public override IdContainer GetId()
		{
			return ReimuUnifierDefaultConfig.DefaultID(this);
		}

		public override EnemyUnitConfig MakeConfig()
		{
			return ReimuUnifierDefaultConfig.EnemyUnitDefaultConfig();
		}

		public override LocalizationOption LoadLocalization()
		{
			return ReimuUnifierLocalization.EnemiesUnitBatchLoc.AddEntity(this);
		}

		public override Type TemplateType()
		{
			return typeof(EnemyUnitTemplate);
		}

		public EnemyUnitConfig GetEnemyUnitDefaultConfig()
		{
			return ReimuUnifierDefaultConfig.EnemyUnitDefaultConfig();
		}
	}
}
