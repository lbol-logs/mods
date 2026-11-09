using System;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossOkinaDef : EnemyUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1686556465);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossOkinaDef.\u200F\u200D\u200B\u200D\u200E\u202C\u200D\u206A\u202B\u206F\u202B\u206E\u202B\u202E\u206B\u206F\u200D\u200E\u206E\u206E\u200F\u202E\u206F\u206F\u202D\u206D\u200E\u200D\u202B\u202A\u206B\u202A\u200B\u206B\u206F\u202D\u200F\u202E\u202E\u200E\u202E(BepinexPlugin.enemyUnitLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EnemyUnitConfig MakeConfig()
		{
			string text = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-107296176);
			bool flag = true;
			bool flag2 = false;
			ManaColor[] array = new ManaColor[4];
			AyaBossOkinaDef.\u206E\u206E\u206A\u206B\u200C\u200D\u200D\u206D\u202D\u202E\u202E\u202A\u200B\u200D\u202E\u206F\u206E\u206C\u200C\u200E\u202A\u206E\u206E\u206F\u202D\u206D\u202A\u202A\u202B\u202D\u200F\u200C\u206E\u206F\u202C\u202A\u202C\u202B\u200C\u200E\u202E(array, fieldof(<PrivateImplementationDetails>.5B3F9EC0646608DAE43294162F92F82B97E7011A2BFA51A25FE477D18BDC6B21).FieldHandle);
			return new EnemyUnitConfig(text, flag, flag2, array, 10, null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-290300016), EnemyType.Boss, false, null, null, 1600, new int?(8), new int?(16), new int?(24), new int?(32), new int?(1), new int?(160), null, null, new int?(1800), new int?(9), new int?(18), new int?(27), new int?(36), new int?(1), new int?(180), null, null, new int?(2000), new int?(10), new int?(20), new int?(30), new int?(40), new int?(2), new int?(200), null, null, new MinMax(500, 500), new MinMax(500, 500), new string[] { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431) }, new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262) }, new string[] { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431) }, new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262) });
		}

		static BatchLocalization \u200F\u200D\u200B\u200D\u200E\u202C\u200D\u206A\u202B\u206F\u202B\u206E\u202B\u202E\u206B\u206F\u200D\u200E\u206E\u206E\u200F\u202E\u206F\u206F\u202D\u206D\u200E\u200D\u202B\u202A\u206B\u202A\u200B\u206B\u206F\u202D\u200F\u202E\u202E\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static void \u206E\u206E\u206A\u206B\u200C\u200D\u200D\u206D\u202D\u202E\u202E\u202A\u200B\u200D\u202E\u206F\u206E\u206C\u200C\u200E\u202A\u206E\u206E\u206F\u202D\u206D\u202A\u202A\u202B\u202D\u200F\u200C\u206E\u206F\u202C\u202A\u202C\u202B\u200C\u200E\u202E(Array A_0, RuntimeFieldHandle A_1)
		{
			RuntimeHelpers.InitializeArray(A_0, A_1);
		}
	}
}
