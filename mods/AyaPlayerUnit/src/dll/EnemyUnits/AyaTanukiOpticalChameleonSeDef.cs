using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core.StatusEffects;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTanukiOpticalChameleonSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-673167696);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTanukiOpticalChameleonSeDef.\u200E\u202E\u200B\u200B\u200E\u206E\u206B\u202C\u202C\u200B\u206A\u206F\u202B\u200C\u202B\u206A\u200B\u206F\u206B\u200B\u206A\u206B\u200D\u202B\u200B\u200B\u206E\u202A\u206E\u200E\u200E\u200C\u206E\u206E\u200D\u200D\u202E\u206E\u206C\u206F\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaTanukiOpticalChameleonSeDef.\u206A\u206B\u206E\u200B\u206E\u200B\u202E\u202B\u206E\u202D\u206C\u200F\u206A\u206A\u206D\u206F\u206E\u200F\u202B\u202A\u200D\u200C\u202D\u200D\u200B\u206D\u202E\u202B\u202A\u202C\u202B\u206E\u206E\u200B\u202E\u202E\u200F\u202A\u200D\u202D\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(625984157), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaTanukiOpticalChameleonSeDef.\u206B\u200F\u200D\u206F\u202A\u202E\u200D\u206C\u206C\u206B\u206F\u206C\u200F\u200C\u202A\u200C\u206C\u202D\u206A\u200F\u202B\u200F\u202C\u202C\u202E\u202B\u202A\u202B\u200D\u202A\u202A\u202B\u202D\u202A\u202A\u206E\u202D\u202C\u206F\u206D\u202E(BepinexPlugin.sequenceTable, AyaTanukiOpticalChameleonSeDef.\u206C\u200D\u202A\u202D\u200E\u200B\u202E\u206C\u202D\u200C\u200F\u206A\u202D\u206A\u202C\u202C\u206E\u200C\u206C\u202B\u202A\u202C\u200D\u206A\u206B\u200D\u206F\u206A\u202D\u202E\u202D\u200D\u206E\u202C\u202B\u200D\u200B\u202C\u202C\u206F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 9, StatusEffectType.Positive, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.TurnStart, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2134438514), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2134438514));
		}

		static BatchLocalization \u200E\u202E\u200B\u200B\u200E\u206E\u206B\u202C\u202C\u200B\u206A\u206F\u202B\u200C\u202B\u206A\u200B\u206F\u206B\u200B\u206A\u206B\u200D\u202B\u200B\u200B\u206E\u202A\u206E\u200E\u200E\u200C\u206E\u206E\u200D\u200D\u202E\u206E\u206C\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206A\u206B\u206E\u200B\u206E\u200B\u202E\u202B\u206E\u202D\u206C\u200F\u206A\u206A\u206D\u206F\u206E\u200F\u202B\u202A\u200D\u200C\u202D\u200D\u200B\u206D\u202E\u202B\u202A\u202C\u202B\u206E\u206E\u200B\u202E\u202E\u200F\u202A\u200D\u202D\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206C\u200D\u202A\u202D\u200E\u200B\u202E\u206C\u202D\u200C\u200F\u206A\u202D\u206A\u202C\u202C\u206E\u200C\u206C\u202B\u202A\u202C\u200D\u206A\u206B\u200D\u206F\u206A\u202D\u202E\u202D\u200D\u206E\u202C\u202B\u200D\u200B\u202C\u202C\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u200F\u200D\u206F\u202A\u202E\u200D\u206C\u206C\u206B\u206F\u206C\u200F\u200C\u202A\u200C\u206C\u202D\u206A\u200F\u202B\u200F\u202C\u202C\u202E\u202B\u202A\u202B\u200D\u202A\u202A\u202B\u202D\u202A\u202A\u206E\u202D\u202C\u206F\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTanukiOpticalChameleonSeDef))]
		public sealed class AyaTanukiOpticalChameleonSe : StatusEffect
		{
		}
	}
}
