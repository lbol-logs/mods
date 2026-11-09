using System;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTakaneDef : EnemyUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1490064686);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneDef.\u202A\u200C\u202C\u206C\u202D\u202D\u206D\u202A\u200B\u200D\u202B\u200E\u202D\u202A\u206F\u206A\u206B\u206C\u202D\u206E\u200E\u200F\u202D\u206A\u200C\u206C\u202D\u200B\u202B\u202A\u200B\u200B\u200D\u200C\u200B\u206D\u206E\u200C\u200D\u200F\u202E(BepinexPlugin.enemyUnitLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EnemyUnitConfig MakeConfig()
		{
			return new EnemyUnitConfig(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(189608077), true, false, new ManaColor[] { ManaColor.Green }, 10, null, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-987475473), EnemyType.Elite, false, null, null, 80, new int?(2), new int?(6), new int?(12), new int?(24), new int?(2), new int?(80), new int?(5), null, new int?(90), new int?(3), new int?(9), new int?(18), new int?(36), new int?(3), new int?(90), new int?(5), null, new int?(100), new int?(4), new int?(12), new int?(24), new int?(48), new int?(4), new int?(100), new int?(5), null, new MinMax(100, 100), new MinMax(100, 100), new string[] { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1350371269) }, new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1303293615) }, new string[] { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(834848172) }, new string[] { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1498342829) });
		}

		static BatchLocalization \u202A\u200C\u202C\u206C\u202D\u202D\u206D\u202A\u200B\u200D\u202B\u200E\u202D\u202A\u206F\u206A\u206B\u206C\u202D\u206E\u200E\u200F\u202D\u206A\u200C\u206C\u202D\u200B\u202B\u202A\u200B\u200B\u200D\u200C\u200B\u206D\u206E\u200C\u200D\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}
	}
}
