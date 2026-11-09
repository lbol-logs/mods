using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossFlandreUlt3Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(28766767);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt3Def.\u200D\u200D\u206E\u206F\u200D\u206E\u200C\u206C\u202E\u206C\u206F\u206D\u202D\u206E\u202C\u206C\u206A\u202E\u202E\u202C\u200B\u206B\u202B\u202A\u206F\u202C\u200D\u206A\u202A\u206E\u206D\u206B\u206C\u200B\u202B\u200E\u200E\u206F\u200B\u202E\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200D\u200D\u206E\u206F\u200D\u206E\u200C\u206C\u202E\u206C\u206F\u206D\u202D\u206E\u202C\u206C\u206A\u202E\u202E\u202C\u200B\u206B\u202B\u202A\u206F\u202C\u200D\u206A\u202A\u206E\u206D\u206B\u206C\u200B\u202B\u200E\u200E\u206F\u200B\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt3Def))]
		public sealed class AyaBossFlandreUlt3 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt3()
			{
				for (;;)
				{
					IL_0006:
					int num = 869434330;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(uint)(-(uint)(num2 ^ ~(~-1304193437)))))) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.TargetType = TargetType.SingleEnemy;
							base.GunName = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
							num = (int)((num3 * 1386868148U) ^ 2716400871U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt3Def.AyaBossFlandreUlt3.<Actions>d__1(-2);
			}
		}
	}
}
