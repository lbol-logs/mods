using System;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTanukiDef : EnemyUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1967068895);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTanukiDef.\u200D\u206F\u206A\u206E\u200F\u202B\u206F\u206C\u206A\u200D\u206E\u200C\u202C\u200D\u206A\u200D\u206A\u200B\u206D\u202E\u206A\u202D\u202A\u206B\u202B\u206C\u206B\u202E\u206B\u206F\u202B\u206E\u206D\u202B\u200C\u202B\u200D\u206E\u200C\u206A\u202E(BepinexPlugin.enemyUnitLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EnemyUnitConfig MakeConfig()
		{
			return new EnemyUnitConfig(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(93226142), false, false, new ManaColor[0], 10, null, null, EnemyType.Elite, false, null, null, 80, new int?(7), new int?(14), new int?(9999), null, new int?(2), new int?(14), new int?(1), null, new int?(85), new int?(8), new int?(16), new int?(9999), null, new int?(4), new int?(16), new int?(1), null, new int?(90), new int?(9), new int?(18), new int?(9999), null, new int?(6), new int?(18), new int?(2), null, new MinMax(30, 36), new MinMax(30, 30), new string[] { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(349468965) }, new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1164812269) }, new string[] { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1045773142) }, new string[] { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-880771794) });
		}

		static BatchLocalization \u200D\u206F\u206A\u206E\u200F\u202B\u206F\u206C\u206A\u200D\u206E\u200C\u202C\u200D\u206A\u200D\u206A\u200B\u206D\u202E\u206A\u202D\u202A\u206B\u202B\u206C\u206B\u202E\u206B\u206F\u202B\u206E\u206D\u202B\u200C\u202B\u200D\u206E\u200C\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}
	}
}
