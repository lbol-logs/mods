using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.StatusEffects
{
	public sealed class FlandreMadnessSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-222063899);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMadnessSeDef.\u200E\u200C\u202A\u202D\u202B\u202C\u200E\u202E\u202C\u206F\u200B\u200D\u200E\u202D\u202E\u206A\u202B\u206D\u206D\u202E\u200C\u206B\u206A\u200D\u206E\u206C\u206D\u206F\u206B\u200B\u202B\u206F\u200C\u206B\u200E\u206A\u202C\u206D\u200E\u200C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreMadnessSeDef.\u202B\u200E\u200D\u206D\u202A\u202A\u200B\u200F\u206F\u200E\u206F\u206A\u206B\u206B\u200C\u206C\u206F\u200C\u202C\u206B\u202D\u200D\u200C\u202B\u200F\u200B\u206E\u200E\u202D\u200C\u206D\u200E\u202A\u200B\u202C\u200B\u202C\u206A\u202E\u206C\u202E(BepinexPlugin.sequenceTable, FlandreMadnessSeDef.\u200B\u202D\u202C\u200C\u206B\u202D\u200B\u206B\u206E\u206E\u206A\u206F\u200C\u200D\u202D\u202A\u202C\u200F\u200C\u202D\u206E\u202C\u200E\u206D\u200E\u206E\u202A\u206F\u206C\u200E\u206E\u200E\u206A\u202A\u202C\u206B\u206F\u200C\u200C\u206C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u200E\u200C\u202A\u202D\u202B\u202C\u200E\u202E\u202C\u206F\u200B\u200D\u200E\u202D\u202E\u206A\u202B\u206D\u206D\u202E\u200C\u206B\u206A\u200D\u206E\u206C\u206D\u206F\u206B\u200B\u202B\u206F\u200C\u206B\u200E\u206A\u202C\u206D\u200E\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202D\u202C\u200C\u206B\u202D\u200B\u206B\u206E\u206E\u206A\u206F\u200C\u200D\u202D\u202A\u202C\u200F\u200C\u202D\u206E\u202C\u200E\u206D\u200E\u206E\u202A\u206F\u206C\u200E\u206E\u200E\u206A\u202A\u202C\u206B\u206F\u200C\u200C\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u200E\u200D\u206D\u202A\u202A\u200B\u200F\u206F\u200E\u206F\u206A\u206B\u206B\u200C\u206C\u206F\u200C\u202C\u206B\u202D\u200D\u200C\u202B\u200F\u200B\u206E\u200E\u202D\u200C\u206D\u200E\u202A\u200B\u202C\u200B\u202C\u206A\u202E\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMadnessSeDef))]
		public sealed class FlandreMadnessSe : StatusEffect
		{
			public float MadnessValue1
			{
				get
				{
					return 1f;
				}
			}

			public float MadnessValue2
			{
				get
				{
					return 0.25f;
				}
			}

			public int MadnessValue3
			{
				get
				{
					return 100;
				}
			}

			public int MadnessValue4
			{
				get
				{
					return 200;
				}
			}

			public float MadnessAmount1
			{
				get
				{
					float madnessValue = this.MadnessValue1;
					GameRunController gameRunController = FlandreMadnessSeDef.FlandreMadnessSe.\u200B\u202B\u200E\u206E\u200E\u202C\u200E\u206A\u202E\u200B\u202C\u206B\u200D\u202D\u200C\u206B\u202D\u206B\u200C\u206F\u202A\u202C\u206B\u206F\u206B\u200E\u200E\u206D\u206C\u206A\u206B\u206D\u206F\u202D\u202A\u206F\u200C\u206E\u202B\u206E\u202E(Singleton<GameMaster>.Instance);
					FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? FlandreMadnessSeDef.FlandreMadnessSe.\u202C\u200B\u202A\u206E\u206C\u206E\u206C\u206C\u202D\u200E\u206D\u202A\u206F\u206B\u206C\u202A\u202A\u206B\u200F\u202D\u206E\u206D\u200F\u206E\u200F\u200B\u202B\u200F\u200B\u202C\u206F\u206D\u200F\u200C\u206D\u200C\u206B\u206F\u206B\u202A\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
					return madnessValue * (float)((flandrePlayerUnit != null) ? flandrePlayerUnit.Madness : 0);
				}
			}

			public float MadnessAmount2
			{
				get
				{
					float madnessValue = this.MadnessValue2;
					GameRunController gameRunController = FlandreMadnessSeDef.FlandreMadnessSe.\u200B\u202B\u200E\u206E\u200E\u202C\u200E\u206A\u202E\u200B\u202C\u206B\u200D\u202D\u200C\u206B\u202D\u206B\u200C\u206F\u202A\u202C\u206B\u206F\u206B\u200E\u200E\u206D\u206C\u206A\u206B\u206D\u206F\u202D\u202A\u206F\u200C\u206E\u202B\u206E\u202E(Singleton<GameMaster>.Instance);
					FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? FlandreMadnessSeDef.FlandreMadnessSe.\u202C\u200B\u202A\u206E\u206C\u206E\u206C\u206C\u202D\u200E\u206D\u202A\u206F\u206B\u206C\u202A\u202A\u206B\u200F\u202D\u206E\u206D\u200F\u206E\u200F\u200B\u202B\u200F\u200B\u202C\u206F\u206D\u200F\u200C\u206D\u200C\u206B\u206F\u206B\u202A\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
					return madnessValue * (float)((flandrePlayerUnit != null) ? flandrePlayerUnit.Madness : 0);
				}
			}

			public int MadnessDecay
			{
				get
				{
					return 4;
				}
			}

			static GameRunController \u200B\u202B\u200E\u206E\u200E\u202C\u200E\u206A\u202E\u200B\u202C\u206B\u200D\u202D\u200C\u206B\u202D\u206B\u200C\u206F\u202A\u202C\u206B\u206F\u206B\u200E\u200E\u206D\u206C\u206A\u206B\u206D\u206F\u202D\u202A\u206F\u200C\u206E\u202B\u206E\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static PlayerUnit \u202C\u200B\u202A\u206E\u206C\u206E\u206C\u206C\u202D\u200E\u206D\u202A\u206F\u206B\u206C\u202A\u202A\u206B\u200F\u202D\u206E\u206D\u200F\u206E\u200F\u200B\u202B\u200F\u200B\u202C\u206F\u206D\u200F\u200C\u206D\u200C\u206B\u206F\u206B\u202A\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}
		}
	}
}
