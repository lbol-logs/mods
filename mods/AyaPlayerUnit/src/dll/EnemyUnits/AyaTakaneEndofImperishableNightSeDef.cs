using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaTakaneEndofImperishableNightSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2080933864);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTakaneEndofImperishableNightSeDef.\u202B\u202E\u206B\u206F\u202B\u200B\u202C\u200C\u202A\u206F\u206D\u206A\u202C\u206C\u202D\u206C\u200C\u202A\u202E\u206A\u202A\u206C\u200B\u206B\u202C\u200D\u202B\u206F\u206D\u200E\u200F\u202E\u200C\u202A\u206B\u206A\u206C\u202C\u206F\u202C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaTakaneEndofImperishableNightSeDef.\u206E\u202D\u200C\u202B\u202E\u202E\u202E\u202C\u202D\u200F\u206A\u202A\u206F\u200C\u200E\u202E\u202C\u202C\u202E\u206A\u200F\u200F\u206C\u206C\u200E\u206A\u200F\u200C\u202E\u200D\u202A\u206E\u202B\u202E\u202C\u206A\u202C\u200E\u202D\u202A\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1609710172)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaTakaneEndofImperishableNightSeDef.\u202C\u202A\u200F\u200E\u200C\u202C\u200F\u202E\u200F\u200C\u200B\u200B\u202A\u206F\u202C\u202C\u206A\u202A\u200C\u206C\u202B\u206E\u200C\u202E\u200E\u200C\u200B\u206E\u202B\u200D\u206C\u202B\u206D\u206D\u202E\u200B\u202B\u202C\u200E\u206D\u202E(BepinexPlugin.sequenceTable, AyaTakaneEndofImperishableNightSeDef.\u206E\u202D\u200C\u202B\u202E\u202E\u202E\u202C\u202D\u200F\u206A\u202A\u206F\u200C\u200E\u202E\u202C\u202C\u202E\u206A\u200F\u200F\u206C\u206C\u200E\u206A\u200F\u200C\u202E\u200D\u202A\u206E\u202B\u202E\u202C\u206A\u202C\u200E\u202D\u202A\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 0, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u202B\u202E\u206B\u206F\u202B\u200B\u202C\u200C\u202A\u206F\u206D\u206A\u202C\u206C\u202D\u206C\u200C\u202A\u202E\u206A\u202A\u206C\u200B\u206B\u202C\u200D\u202B\u206F\u206D\u200E\u200F\u202E\u200C\u202A\u206B\u206A\u206C\u202C\u206F\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u202D\u200C\u202B\u202E\u202E\u202E\u202C\u202D\u200F\u206A\u202A\u206F\u200C\u200E\u202E\u202C\u202C\u202E\u206A\u200F\u200F\u206C\u206C\u200E\u206A\u200F\u200C\u202E\u200D\u202A\u206E\u202B\u202E\u202C\u206A\u202C\u200E\u202D\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u202A\u200F\u200E\u200C\u202C\u200F\u202E\u200F\u200C\u200B\u200B\u202A\u206F\u202C\u202C\u206A\u202A\u200C\u206C\u202B\u206E\u200C\u202E\u200E\u200C\u200B\u206E\u202B\u200D\u206C\u202B\u206D\u206D\u202E\u200B\u202B\u202C\u200E\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTakaneEndofImperishableNightSeDef))]
		public sealed class AyaTakaneEndofImperishableNightSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.\u200B\u206A\u202E\u206A\u206F\u200E\u200E\u206B\u206B\u206B\u202A\u202B\u206B\u200C\u202D\u206E\u206F\u202C\u206C\u202A\u206D\u206D\u200D\u202D\u202D\u200B\u206E\u202B\u200E\u202D\u200D\u206D\u206F\u206B\u206F\u202A\u200E\u206B\u206A\u206C\u202E(AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.\u200D\u206E\u200C\u206C\u202E\u200C\u200F\u202E\u200C\u202B\u206C\u200D\u202A\u200B\u206D\u200B\u206A\u200D\u202E\u206C\u206E\u200B\u202E\u200D\u206C\u200C\u202D\u200F\u206A\u202C\u200D\u202C\u206D\u206E\u200E\u200F\u202C\u202B\u202B\u206C\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarting));
				for (;;)
				{
					IL_001D:
					int num = 354725260;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(num2 ^ ((22103877 + -885904876 + 1421223863 * 287153183) ^ -59236770) ^ -1076044965) * 348869931)) % 3U)
						{
						case 0U:
							goto IL_001D;
						case 2U:
							base.ReactOwnerEvent<UnitEventArgs>(AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.\u202D\u206A\u206C\u202C\u202C\u200B\u202C\u206C\u206F\u206E\u202D\u202A\u200C\u200C\u206E\u202D\u206B\u200E\u200E\u202D\u206D\u206A\u202D\u202B\u206B\u206E\u202E\u202D\u202C\u206E\u206C\u202A\u200F\u206E\u200E\u202E\u202A\u206C\u202D\u200D\u202E(AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.\u200D\u206E\u200C\u206C\u202E\u200C\u200F\u202E\u200C\u202B\u206C\u200D\u202A\u200B\u206D\u200B\u206A\u200D\u202E\u206C\u206E\u200B\u202E\u200D\u206C\u200C\u202D\u200F\u206A\u202C\u200D\u202C\u206D\u206E\u200E\u200F\u202C\u202B\u202B\u206C\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnded));
							num = (int)((num3 * 3106454197U) ^ 2364300882U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnTurnStarting(UnitEventArgs args)
			{
				AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.<OnTurnStarting>d__1 <OnTurnStarting>d__ = new AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.<OnTurnStarting>d__1(-2);
				<OnTurnStarting>d__.<>4__this = this;
				return <OnTurnStarting>d__;
			}

			private IEnumerable<BattleAction> OnTurnEnded(UnitEventArgs args)
			{
				AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.<OnTurnEnded>d__2 <OnTurnEnded>d__ = new AyaTakaneEndofImperishableNightSeDef.AyaTakaneEndofImperishableNightSe.<OnTurnEnded>d__2(-2);
				<OnTurnEnded>d__.<>4__this = this;
				return <OnTurnEnded>d__;
			}

			static Unit \u200D\u206E\u200C\u206C\u202E\u200C\u200F\u202E\u200C\u202B\u206C\u200D\u202A\u200B\u206D\u200B\u206A\u200D\u202E\u206C\u206E\u200B\u202E\u200D\u206C\u200C\u202D\u200F\u206A\u202C\u200D\u202C\u206D\u206E\u200E\u200F\u202C\u202B\u202B\u206C\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u200B\u206A\u202E\u206A\u206F\u200E\u200E\u206B\u206B\u206B\u202A\u202B\u206B\u200C\u202D\u206E\u206F\u202C\u206C\u202A\u206D\u206D\u200D\u202D\u202D\u200B\u206E\u202B\u200E\u202D\u200D\u206D\u206F\u206B\u206F\u202A\u200E\u206B\u206A\u206C\u202E(Unit A_0)
			{
				return A_0.TurnStarting;
			}

			static GameEvent<UnitEventArgs> \u202D\u206A\u206C\u202C\u202C\u200B\u202C\u206C\u206F\u206E\u202D\u202A\u200C\u200C\u206E\u202D\u206B\u200E\u200E\u202D\u206D\u206A\u202D\u202B\u206B\u206E\u202E\u202D\u202C\u206E\u206C\u202A\u200F\u206E\u200E\u202E\u202A\u206C\u202D\u200D\u202E(Unit A_0)
			{
				return A_0.TurnEnded;
			}
		}
	}
}
