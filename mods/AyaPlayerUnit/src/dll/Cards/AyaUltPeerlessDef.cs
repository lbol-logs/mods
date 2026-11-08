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
	public sealed class AyaUltPeerlessDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-292426522);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaUltPeerlessDef.\u206D\u202B\u202E\u200F\u202D\u202E\u200E\u206C\u200C\u200D\u200D\u202B\u206D\u206C\u206F\u200F\u202C\u200C\u200E\u206A\u206D\u200F\u206E\u206E\u206F\u200D\u202E\u206F\u200C\u206F\u202D\u200B\u206F\u202C\u200F\u202D\u202D\u200B\u200B\u200C\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u206D\u202B\u202E\u200F\u202D\u202E\u200E\u206C\u200C\u200D\u200D\u202B\u206D\u206C\u206F\u200F\u202C\u200C\u200E\u206A\u206D\u200F\u206E\u206E\u206F\u200D\u202E\u206F\u200C\u206F\u202D\u200B\u206F\u202C\u200F\u202D\u202D\u200B\u200B\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		[EntityLogic(typeof(AyaUltPeerlessDef))]
		public sealed class AyaUltPeerless : UltimateSkill
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaUltPeerless()
			{
				base.TargetType = TargetType.SingleEnemy;
				base.GunName = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector)
			{
				return new AyaUltPeerlessDef.AyaUltPeerless.<Actions>d__1(-2);
			}
		}
	}
}
