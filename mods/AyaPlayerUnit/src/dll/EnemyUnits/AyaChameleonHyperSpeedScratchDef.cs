using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaChameleonHyperSpeedScratchDef : UltimateSkillTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1236289107);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaChameleonHyperSpeedScratchDef.\u202A\u206C\u200F\u206C\u206F\u206B\u206E\u206F\u200F\u206C\u202A\u206E\u200D\u200B\u202A\u206B\u202C\u206D\u200F\u202C\u202B\u206C\u206F\u206D\u206C\u202B\u202A\u202C\u202B\u200E\u206C\u200B\u202D\u202B\u200B\u200D\u206D\u206B\u202B\u200D\u202E(BepinexPlugin.ultimateSkillLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		public override UltimateSkillConfig MakeConfig()
		{
			return new UltimateSkillConfig("", 10, 100, 100, 2, UsRepeatableType.OncePerTurn, 0, 0, 0, Keyword.Accuracy, new List<string>(), new List<string>());
		}

		static BatchLocalization \u202A\u206C\u200F\u206C\u206F\u206B\u206E\u206F\u200F\u206C\u202A\u206E\u200D\u200B\u202A\u206B\u202C\u206D\u200F\u202C\u202B\u206C\u206F\u206D\u206C\u202B\u202A\u202C\u202B\u200E\u206C\u200B\u202D\u202B\u200B\u200D\u206D\u206B\u202B\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}
	}
}
