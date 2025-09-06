using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using lvalonexrumia.Enemies.Template;
using lvalonexrumia.GunName;

namespace lvalonexrumia.Enemies
{
	public sealed class lvalonexrumiaEnemyUnitDef : lvalonexrumiaEnemyUnitTemplate
	{
		public override IdContainer GetId()
		{
			return "lvalonexrumia";
		}

		public override EnemyUnitConfig MakeConfig()
		{
			EnemyUnitConfig enemyUnitDefaultConfig = base.GetEnemyUnitDefaultConfig();
			enemyUnitDefaultConfig.IsPreludeOpponent = BepinexPlugin.enableAct1Boss.Value;
			enemyUnitDefaultConfig.BaseManaColor = new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			};
			enemyUnitDefaultConfig.Type = EnemyType.Boss;
			enemyUnitDefaultConfig.MaxHp = 280;
			enemyUnitDefaultConfig.MaxHpHard = new int?(290);
			enemyUnitDefaultConfig.MaxHpLunatic = new int?(300);
			enemyUnitDefaultConfig.Damage1 = new int?(6);
			enemyUnitDefaultConfig.Damage1Hard = new int?(7);
			enemyUnitDefaultConfig.Damage1Lunatic = new int?(8);
			enemyUnitDefaultConfig.Damage2 = new int?(9);
			enemyUnitDefaultConfig.Damage2Hard = new int?(10);
			enemyUnitDefaultConfig.Damage2Lunatic = new int?(11);
			enemyUnitDefaultConfig.Damage3 = new int?(1);
			enemyUnitDefaultConfig.Damage3Hard = new int?(1);
			enemyUnitDefaultConfig.Damage3Lunatic = new int?(1);
			enemyUnitDefaultConfig.Damage4 = new int?(2);
			enemyUnitDefaultConfig.Damage4Hard = new int?(2);
			enemyUnitDefaultConfig.Damage4Lunatic = new int?(3);
			enemyUnitDefaultConfig.Defend = new int?(5);
			enemyUnitDefaultConfig.DefendHard = new int?(6);
			enemyUnitDefaultConfig.DefendLunatic = new int?(7);
			enemyUnitDefaultConfig.Count1 = new int?(2);
			enemyUnitDefaultConfig.Count1Hard = new int?(2);
			enemyUnitDefaultConfig.Count1Lunatic = new int?(3);
			enemyUnitDefaultConfig.Count2 = new int?(1);
			enemyUnitDefaultConfig.Count2Hard = new int?(1);
			enemyUnitDefaultConfig.Count2Lunatic = new int?(2);
			enemyUnitDefaultConfig.PowerLoot = new MinMax(100, 100);
			enemyUnitDefaultConfig.BluePointLoot = new MinMax(100, 100);
			enemyUnitDefaultConfig.Gun1 = new List<string> { GunNameID.GetGunFromId(7021) };
			enemyUnitDefaultConfig.Gun2 = new List<string> { GunNameID.GetGunFromId(7071) };
			enemyUnitDefaultConfig.Gun3 = new List<string> { GunNameID.GetGunFromId(520) };
			enemyUnitDefaultConfig.Gun4 = new List<string> { GunNameID.GetGunFromId(7161) };
			return enemyUnitDefaultConfig;
		}
	}
}
