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
	public sealed class AyaUltAdventDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(325341539);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltAdventDef.\u206C\u206A\u202C\u206C\u206C\u206C\u206D\u206F\u206F\u206A\u202A\u206A\u206F\u206A\u202C\u206E\u206C\u200F\u206D\u200E\u202E\u202B\u200B\u200C\u202E\u200C\u202E\u206A\u206E\u206D\u206A\u200E\u206A\u206B\u202A\u200C\u202E\u200F\u206D\u200D\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206C\u206A\u202C\u206C\u206C\u206C\u206D\u206F\u206F\u206A\u202A\u206A\u206F\u206A\u202C\u206E\u206C\u200F\u206D\u200E\u202E\u202B\u200B\u200C\u202E\u200C\u202E\u206A\u206E\u206D\u206A\u200E\u206A\u206B\u202A\u200C\u202E\u200F\u206D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaUltAdventDef))]
		public sealed class AyaUltAdvent : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltAdvent()
			{
				for (;;)
				{
					IL_0006:
					int num = 342320864;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(num2 * 414091163) - (-661025108 + -1966669236)))) % 4U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							base.GunName = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
							num = (int)((num3 * 4226800969U) ^ 1193509200U);
							continue;
						case 3U:
							base.TargetType = TargetType.SingleEnemy;
							num = (int)((num3 * 1327122785U) ^ 1269140242U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaUltAdventDef.AyaUltAdvent.<Actions>d__1(-2);
			}
		}
	}
}
