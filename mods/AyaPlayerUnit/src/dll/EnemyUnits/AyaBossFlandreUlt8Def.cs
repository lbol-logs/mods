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
	public sealed class AyaBossFlandreUlt8Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1469364396);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt8Def.\u206C\u200F\u206B\u206A\u202E\u200E\u206A\u202B\u206A\u202C\u200C\u200C\u200C\u206C\u206D\u206A\u206B\u202B\u206A\u202B\u206B\u200B\u202E\u202E\u206A\u206E\u206E\u200C\u206F\u202C\u200B\u200B\u202E\u206D\u206B\u206E\u200E\u200F\u202C\u206B\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206C\u200F\u206B\u206A\u202E\u200E\u206A\u202B\u206A\u202C\u200C\u200C\u200C\u206C\u206D\u206A\u206B\u202B\u206A\u202B\u206B\u200B\u202E\u202E\u206A\u206E\u206E\u200C\u206F\u202C\u200B\u200B\u202E\u206D\u206B\u206E\u200E\u200F\u202C\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt8Def))]
		public sealed class AyaBossFlandreUlt8 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt8()
			{
				for (;;)
				{
					IL_0006:
					int num = 414354288;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~num2 - (1425998624 ^ -1100190407 ^ -1592144990)) * 2088471163 + 1695942690)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 1936655415U) ^ 2303710613U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.GunName = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt8Def.AyaBossFlandreUlt8.<Actions>d__1(-2);
			}
		}
	}
}
