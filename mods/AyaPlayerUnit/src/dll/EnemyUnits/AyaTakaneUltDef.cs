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
	public sealed class AyaTakaneUltDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-281420392);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneUltDef.\u206C\u202E\u206A\u202D\u206D\u202E\u202B\u200D\u200F\u202B\u206D\u202D\u202A\u200D\u202D\u200D\u202E\u206F\u200D\u200D\u206B\u206F\u206D\u202B\u200D\u202A\u206A\u200F\u202C\u202E\u200B\u200F\u202A\u206D\u200F\u200B\u206B\u200F\u206B\u202E\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206C\u202E\u206A\u202D\u206D\u202E\u202B\u200D\u200F\u202B\u206D\u202D\u202A\u200D\u202D\u200D\u202E\u206F\u200D\u200D\u206B\u206F\u206D\u202B\u200D\u202A\u206A\u200F\u202C\u202E\u200B\u200F\u202A\u206D\u200F\u200B\u206B\u200F\u206B\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaTakaneUltDef))]
		public sealed class AyaTakaneUlt : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaTakaneUlt()
			{
				for (;;)
				{
					IL_0006:
					int num = -1436429645;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((--1271564668 + 202275675 * 1842861834 - -num2) ^ -1818466310)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							base.TargetType = TargetType.SingleEnemy;
							base.GunName = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276);
							num = (int)((num3 * 712276411U) ^ 861197729U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaTakaneUltDef.AyaTakaneUlt.<Actions>d__1(-2);
			}
		}
	}
}
