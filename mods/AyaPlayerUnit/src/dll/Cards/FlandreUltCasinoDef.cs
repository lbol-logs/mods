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
	public sealed class FlandreUltCasinoDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1283130096);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreUltCasinoDef.\u200D\u206E\u200D\u200D\u202D\u200B\u200F\u206B\u202C\u206E\u200C\u206D\u202E\u200C\u200F\u200D\u200F\u206E\u206F\u200C\u206D\u200D\u202B\u200E\u206A\u200C\u206E\u202A\u202A\u202C\u202C\u202C\u202D\u206C\u200B\u206B\u206A\u202B\u206C\u206D\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200D\u206E\u200D\u200D\u202D\u200B\u200F\u206B\u202C\u206E\u200C\u206D\u202E\u200C\u200F\u200D\u200F\u206E\u206F\u200C\u206D\u200D\u202B\u200E\u206A\u200C\u206E\u202A\u202A\u202C\u202C\u202C\u202D\u206C\u200B\u206B\u206A\u202B\u206C\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(FlandreUltCasinoDef))]
		public sealed class FlandreUltCasino : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public FlandreUltCasino()
			{
				for (;;)
				{
					IL_0006:
					int num = -732986283;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(num2 * 1163495977 * -928931873)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							base.TargetType = TargetType.SingleEnemy;
							base.GunName = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
							num = (int)((num3 * 3519198773U) ^ 2912120593U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new FlandreUltCasinoDef.FlandreUltCasino.<Actions>d__1(-2);
			}
		}
	}
}
