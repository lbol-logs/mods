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

namespace AyaShameimaru.StatusEffects
{
	public sealed class FlandreOfferingSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-294035728);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreOfferingSeDef.\u202B\u200D\u206F\u200F\u200E\u200B\u206A\u202A\u200D\u206F\u206B\u200E\u206F\u200F\u200F\u202E\u200E\u202B\u200E\u202A\u200C\u202C\u206D\u200F\u202A\u200E\u200D\u200C\u200C\u206F\u206D\u202D\u200C\u206A\u200B\u202C\u206B\u202A\u200F\u202A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreOfferingSeDef.\u200B\u206E\u202B\u206A\u200D\u202B\u202D\u202D\u202A\u202D\u206F\u200E\u200E\u206D\u206D\u200E\u202C\u206A\u200E\u200B\u206F\u200E\u206D\u200C\u200F\u206C\u206B\u200D\u200C\u202D\u202C\u200C\u202E\u200F\u206A\u206A\u200D\u200E\u206F\u206D\u202E(BepinexPlugin.sequenceTable, FlandreOfferingSeDef.\u200F\u202A\u202C\u200F\u200F\u206F\u206E\u202C\u206B\u206B\u202E\u206A\u200E\u206B\u206E\u206A\u206E\u206A\u202D\u202A\u202C\u202B\u206E\u200E\u206A\u206A\u200F\u206F\u202E\u206F\u206C\u202E\u206F\u202E\u206D\u202C\u202E\u202C\u202B\u200C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, false, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Exile, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u202B\u200D\u206F\u200F\u200E\u200B\u206A\u202A\u200D\u206F\u206B\u200E\u206F\u200F\u200F\u202E\u200E\u202B\u200E\u202A\u200C\u202C\u206D\u200F\u202A\u200E\u200D\u200C\u200C\u206F\u206D\u202D\u200C\u206A\u200B\u202C\u206B\u202A\u200F\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u202A\u202C\u200F\u200F\u206F\u206E\u202C\u206B\u206B\u202E\u206A\u200E\u206B\u206E\u206A\u206E\u206A\u202D\u202A\u202C\u202B\u206E\u200E\u206A\u206A\u200F\u206F\u202E\u206F\u206C\u202E\u206F\u202E\u206D\u202C\u202E\u202C\u202B\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200B\u206E\u202B\u206A\u200D\u202B\u202D\u202D\u202A\u202D\u206F\u200E\u200E\u206D\u206D\u200E\u202C\u206A\u200E\u200B\u206F\u200E\u206D\u200C\u200F\u206C\u206B\u200D\u200C\u202D\u202C\u200C\u202E\u200F\u206A\u206A\u200D\u200E\u206F\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreOfferingSeDef))]
		public sealed class FlandreOfferingSe : StatusEffect
		{
			public int Value
			{
				get
				{
					if (!BepinexPlugin.AyaPhantasmMode.Value)
					{
						for (;;)
						{
							int num = 776845864;
							switch (-(~(-(num - -(--674006365 ^ -1092270876)))) % 3)
							{
							case 0:
								continue;
							case 1:
								return 2;
							}
							break;
						}
						return 3;
					}
					return 3;
				}
			}
		}
	}
}
