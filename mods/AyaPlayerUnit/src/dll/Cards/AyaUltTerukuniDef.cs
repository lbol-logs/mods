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
	public sealed class AyaUltTerukuniDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1752592358);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltTerukuniDef.\u206D\u200B\u202A\u206A\u202D\u202D\u206E\u206F\u200B\u202B\u200D\u200B\u206D\u202C\u206D\u200F\u200F\u202C\u200B\u206F\u206B\u206B\u200D\u200B\u206B\u202B\u202B\u206F\u200F\u206F\u206E\u206D\u202C\u206C\u200D\u206A\u206B\u202E\u202B\u202E\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206D\u200B\u202A\u206A\u202D\u202D\u206E\u206F\u200B\u202B\u200D\u200B\u206D\u202C\u206D\u200F\u200F\u202C\u200B\u206F\u206B\u206B\u200D\u200B\u206B\u202B\u202B\u206F\u200F\u206F\u206E\u206D\u202C\u206C\u200D\u206A\u206B\u202E\u202B\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaUltTerukuniDef))]
		public sealed class AyaUltTerukuni : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltTerukuni()
			{
				base.TargetType = TargetType.SingleEnemy;
				base.GunName = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaUltTerukuniDef.AyaUltTerukuni.<Actions>d__1(-2);
			}
		}
	}
}
