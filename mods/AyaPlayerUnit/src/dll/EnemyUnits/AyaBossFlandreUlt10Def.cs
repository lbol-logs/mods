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
	public sealed class AyaBossFlandreUlt10Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1811132935);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt10Def.\u200B\u200C\u200B\u206D\u202D\u206E\u202C\u202C\u202A\u206A\u200C\u206C\u200D\u200E\u202D\u200E\u202B\u202E\u206D\u200C\u202A\u206D\u200E\u206F\u202C\u206B\u200F\u202E\u200E\u200D\u202D\u206F\u202B\u200B\u206B\u206F\u200F\u202B\u206C\u206E\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200B\u200C\u200B\u206D\u202D\u206E\u202C\u202C\u202A\u206A\u200C\u206C\u200D\u200E\u202D\u200E\u202B\u202E\u206D\u200C\u202A\u206D\u200E\u206F\u202C\u206B\u200F\u202E\u200E\u200D\u202D\u206F\u202B\u200B\u206B\u206F\u200F\u202B\u206C\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt10Def))]
		public sealed class AyaBossFlandreUlt10 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt10()
			{
				for (;;)
				{
					IL_0006:
					int num = -971263818;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(uint)(num2 ^ (((-1207000210 - 1971612329) * -670274427) ^ (737155621 * 632423665 - --649671856)) ^ (1187674994 - (645354096 ^ -779400146)))))) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							base.TargetType = TargetType.SingleEnemy;
							base.GunName = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
							num = (int)((num3 * 4211986710U) ^ 2857890131U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt10Def.AyaBossFlandreUlt10.<Actions>d__1(-2);
			}
		}
	}
}
