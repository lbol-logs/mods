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
	public sealed class AyaBossFlandreUlt9Def : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1092185731);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreUlt9Def.\u202E\u202B\u200E\u200C\u202B\u206D\u206A\u206A\u206A\u206D\u202C\u200E\u202E\u206F\u202D\u206C\u206D\u206C\u200F\u200C\u200F\u200E\u202C\u200D\u200D\u200E\u200E\u202C\u206B\u206D\u202B\u206F\u206A\u202D\u206B\u202B\u206E\u206E\u200E\u206F\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u202E\u202B\u200E\u200C\u202B\u206D\u206A\u206A\u206A\u206D\u202C\u200E\u202E\u206F\u202D\u206C\u206D\u206C\u200F\u200C\u200F\u200E\u202C\u200D\u200D\u200E\u200E\u202C\u206B\u206D\u202B\u206F\u206A\u202D\u206B\u202B\u206E\u206E\u200E\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreUlt9Def))]
		public sealed class AyaBossFlandreUlt9 : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaBossFlandreUlt9()
			{
				base.TargetType = TargetType.SingleEnemy;
				base.GunName = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaBossFlandreUlt9Def.AyaBossFlandreUlt9.<Actions>d__1(-2);
			}
		}
	}
}
