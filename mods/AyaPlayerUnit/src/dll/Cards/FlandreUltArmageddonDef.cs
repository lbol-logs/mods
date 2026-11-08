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

namespace AyaShameimaru.Cards
{
	public sealed class FlandreUltArmageddonDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(115511124);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreUltArmageddonDef.\u200D\u206F\u202D\u200E\u200D\u200C\u202A\u206A\u200E\u202A\u202A\u206D\u206F\u206E\u206A\u200D\u202B\u206A\u202D\u202D\u200C\u202B\u202E\u206B\u206A\u206D\u200F\u200D\u202D\u202E\u200E\u200B\u202A\u200F\u200F\u202A\u206A\u200E\u206A\u206C\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200D\u206F\u202D\u200E\u200D\u200C\u202A\u206A\u200E\u202A\u202A\u206D\u206F\u206E\u206A\u200D\u202B\u206A\u202D\u202D\u200C\u202B\u202E\u206B\u206A\u206D\u200F\u200D\u202D\u202E\u200E\u200B\u202A\u200F\u200F\u202A\u206A\u200E\u206A\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(FlandreUltArmageddonDef))]
		public sealed class FlandreUltArmageddon : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FlandreUltArmageddon()
			{
				for (;;)
				{
					IL_0006:
					int num = 1057952279;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(uint)(num2 ^ -((-1123943308 - 1510995740) ^ -565808381))))) % 4U)
						{
						case 1U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 15703702U) ^ 3187370431U);
							continue;
						case 2U:
							goto IL_0006;
						case 3U:
							base.GunName = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
							num = (int)((num3 * 2966748194U) ^ 316982130U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new FlandreUltArmageddonDef.FlandreUltArmageddon.<Actions>d__1(-2);
			}
		}
	}
}
