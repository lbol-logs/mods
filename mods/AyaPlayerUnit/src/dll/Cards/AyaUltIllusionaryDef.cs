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
	public sealed class AyaUltIllusionaryDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1484567598);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltIllusionaryDef.\u206D\u202A\u202E\u202B\u202D\u200D\u202A\u200B\u206F\u202D\u200F\u202E\u200D\u200D\u202B\u200C\u206D\u206E\u202D\u202A\u200C\u206A\u206F\u200C\u202C\u206E\u200B\u206E\u200E\u206A\u206F\u202A\u200E\u200D\u206D\u202C\u206C\u206A\u206F\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206D\u202A\u202E\u202B\u202D\u200D\u202A\u200B\u206F\u202D\u200F\u202E\u200D\u200D\u202B\u200C\u206D\u206E\u202D\u202A\u200C\u206A\u206F\u200C\u202C\u206E\u200B\u206E\u200E\u206A\u206F\u202A\u200E\u200D\u206D\u202C\u206C\u206A\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaUltIllusionaryDef))]
		public sealed class AyaUltIllusionary : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltIllusionary()
			{
				base.TargetType = TargetType.SingleEnemy;
				base.GunName = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaUltIllusionaryDef.AyaUltIllusionary.<Actions>d__1(-2);
			}
		}
	}
}
