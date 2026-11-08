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
	public sealed class AyaBossZUNUltDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1580105194);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossZUNUltDef.\u202B\u206C\u200F\u206E\u206A\u200B\u200B\u200C\u202D\u206C\u200B\u206D\u202A\u206B\u206D\u200B\u206B\u202C\u202D\u206D\u200C\u200B\u206F\u206A\u202B\u206C\u202D\u200E\u202A\u206A\u200F\u200E\u200C\u202D\u206D\u200E\u200E\u202C\u200E\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u202B\u206C\u200F\u206E\u206A\u200B\u200B\u200C\u202D\u206C\u200B\u206D\u202A\u206B\u206D\u200B\u206B\u202C\u202D\u206D\u200C\u200B\u206F\u206A\u202B\u206C\u202D\u200E\u202A\u206A\u200F\u200E\u200C\u202D\u206D\u200E\u200E\u202C\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossZUNUltDef))]
		public sealed class AyaBossZUNUlt : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossZUNUlt()
			{
				for (;;)
				{
					IL_0006:
					int num = -1864506419;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)((-num2 * 528109267) ^ (1395757481 ^ 1468304060)))) % 4U)
						{
						case 0U:
							base.GunName = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
							num = (int)((num3 * 4213943436U) ^ 1361758415U);
							continue;
						case 2U:
							goto IL_0006;
						case 3U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 2386976466U) ^ 2262806044U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossZUNUltDef.AyaBossZUNUlt.<Actions>d__1(-2);
			}
		}
	}
}
