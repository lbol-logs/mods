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
	public sealed class AyaBossFlandreUlt2Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2016755081);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt2Def.\u206A\u206E\u200F\u206C\u206C\u200B\u200F\u206B\u202B\u206C\u202B\u206B\u206D\u200B\u206B\u202C\u206B\u202E\u206A\u200D\u202C\u200D\u206D\u202D\u202D\u206B\u200C\u202B\u200E\u200C\u202C\u200B\u202D\u200E\u206C\u202A\u206E\u206F\u202E\u206C\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206A\u206E\u200F\u206C\u206C\u200B\u200F\u206B\u202B\u206C\u202B\u206B\u206D\u200B\u206B\u202C\u206B\u202E\u206A\u200D\u202C\u200D\u206D\u202D\u202D\u206B\u200C\u202B\u200E\u200C\u202C\u200B\u202D\u200E\u206C\u202A\u206E\u206F\u202E\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt2Def))]
		public sealed class AyaBossFlandreUlt2 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt2()
			{
				for (;;)
				{
					IL_0006:
					int num = -590166918;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~num2 * 221109437 * -1825635675) ^ -157029248)) % 4U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 405872708U) ^ 881997592U);
							continue;
						case 3U:
							base.GunName = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283);
							num = (int)((num3 * 2898354591U) ^ 149681500U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt2Def.AyaBossFlandreUlt2.<Actions>d__1(-2);
			}
		}
	}
}
