using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core.StatusEffects;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTakaneCenturysDoppelgangersSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1416473531);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneCenturysDoppelgangersSeDef.\u202C\u202E\u200D\u200B\u200D\u206E\u202E\u206C\u200B\u200D\u202C\u200B\u206D\u202D\u206A\u200D\u202A\u206B\u200F\u202A\u202D\u202A\u206E\u202B\u206D\u202E\u206E\u206D\u206D\u206F\u200B\u202B\u200D\u206B\u202E\u206C\u202D\u202D\u200F\u202A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaTakaneCenturysDoppelgangersSeDef.\u202A\u202C\u206E\u202B\u202B\u206E\u202D\u202A\u202B\u202B\u200C\u202A\u200F\u200F\u200F\u206A\u202C\u200B\u200C\u200F\u202A\u202B\u200C\u202A\u200F\u200B\u206C\u206E\u206F\u206A\u202A\u206C\u202C\u202E\u206C\u200E\u206F\u202B\u206A\u202C\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(208472332)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaTakaneCenturysDoppelgangersSeDef.\u202A\u206D\u206C\u202B\u202B\u206E\u206D\u202E\u202B\u202D\u200B\u202B\u206D\u200B\u200B\u206D\u206A\u200B\u200C\u206C\u206D\u206C\u202B\u200C\u206E\u200D\u200C\u206D\u202B\u200B\u202D\u206B\u200D\u202A\u202D\u206C\u202D\u206D\u206C\u202D\u202E(BepinexPlugin.sequenceTable, AyaTakaneCenturysDoppelgangersSeDef.\u202A\u202C\u206E\u202B\u202B\u206E\u202D\u202A\u202B\u202B\u200C\u202A\u200F\u200F\u200F\u206A\u202C\u200B\u200C\u200F\u202A\u202B\u200C\u202A\u200F\u200B\u206C\u206E\u206F\u206A\u202A\u206C\u202C\u202E\u206C\u200E\u206F\u202B\u206A\u202C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u202C\u202E\u200D\u200B\u200D\u206E\u202E\u206C\u200B\u200D\u202C\u200B\u206D\u202D\u206A\u200D\u202A\u206B\u200F\u202A\u202D\u202A\u206E\u202B\u206D\u202E\u206E\u206D\u206D\u206F\u200B\u202B\u200D\u206B\u202E\u206C\u202D\u202D\u200F\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u202C\u206E\u202B\u202B\u206E\u202D\u202A\u202B\u202B\u200C\u202A\u200F\u200F\u200F\u206A\u202C\u200B\u200C\u200F\u202A\u202B\u200C\u202A\u200F\u200B\u206C\u206E\u206F\u206A\u202A\u206C\u202C\u202E\u206C\u200E\u206F\u202B\u206A\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206D\u206C\u202B\u202B\u206E\u206D\u202E\u202B\u202D\u200B\u202B\u206D\u200B\u200B\u206D\u206A\u200B\u200C\u206C\u206D\u206C\u202B\u200C\u206E\u200D\u200C\u206D\u202B\u200B\u202D\u206B\u200D\u202A\u202D\u206C\u202D\u206D\u206C\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTakaneCenturysDoppelgangersSeDef))]
		public sealed class AyaTakaneCenturysDoppelgangersSe : StatusEffect
		{
		}
	}
}
