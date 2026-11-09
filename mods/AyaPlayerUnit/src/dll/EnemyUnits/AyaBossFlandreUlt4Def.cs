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
	public sealed class AyaBossFlandreUlt4Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1697764413);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt4Def.\u206C\u202E\u202A\u200C\u200F\u202A\u206B\u202E\u206A\u206E\u200E\u202E\u206E\u200E\u200C\u202A\u200C\u206C\u202A\u206A\u200D\u200E\u206A\u206C\u202B\u206D\u206E\u200E\u200F\u202D\u200C\u206C\u200F\u206C\u206C\u206E\u200D\u206C\u202D\u202C\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206C\u202E\u202A\u200C\u200F\u202A\u206B\u202E\u206A\u206E\u200E\u202E\u206E\u200E\u200C\u202A\u200C\u206C\u202A\u206A\u200D\u200E\u206A\u206C\u202B\u206D\u206E\u200E\u200F\u202D\u200C\u206C\u200F\u206C\u206C\u206E\u200D\u206C\u202D\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt4Def))]
		public sealed class AyaBossFlandreUlt4 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt4()
			{
				for (;;)
				{
					IL_0006:
					int num = 1450225148;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(((num2 - (-1483989925 - ~(16767143 * 336781410))) ^ (-928909162 - 1990027136)) - 1280074548 - 207241722)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 4205118209U) ^ 1363899388U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.GunName = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt4Def.AyaBossFlandreUlt4.<Actions>d__1(-2);
			}
		}
	}
}
