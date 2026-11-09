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
	public sealed class AyaOrbRedIndiscriminateIgnitionSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(232464051);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbRedIndiscriminateIgnitionSeDef.\u200B\u202D\u206C\u206F\u206C\u202B\u200B\u206D\u206E\u206D\u206E\u202B\u202A\u206B\u206A\u206B\u200F\u200B\u202D\u202B\u206C\u206B\u206E\u206F\u206A\u200B\u202D\u206E\u206E\u202A\u206F\u202D\u202D\u202B\u200B\u200D\u200B\u206B\u206D\u202B\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaOrbRedIndiscriminateIgnitionSeDef.\u206A\u200D\u202D\u200B\u206A\u202B\u200D\u200D\u206E\u200C\u202D\u202B\u202C\u200B\u200D\u202C\u202C\u206C\u200C\u206D\u200E\u206C\u206F\u202E\u206D\u202C\u206B\u206D\u202C\u200D\u202E\u202A\u206D\u200E\u202A\u206D\u200C\u202A\u206F\u200D\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-201519834)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbRedIndiscriminateIgnitionSeDef.\u202A\u200E\u206D\u206B\u202B\u206C\u202E\u200B\u206B\u200D\u206D\u206A\u202C\u206A\u206F\u200C\u202C\u206D\u206C\u202B\u202D\u206D\u200E\u200C\u200B\u206B\u200F\u200B\u200C\u206D\u202A\u200D\u206A\u206B\u206C\u206B\u200F\u202C\u200E\u206B\u202E(BepinexPlugin.sequenceTable, AyaOrbRedIndiscriminateIgnitionSeDef.\u206A\u200D\u202D\u200B\u206A\u202B\u200D\u200D\u206E\u200C\u202D\u202B\u202C\u200B\u200D\u202C\u202C\u206C\u200C\u206D\u200E\u206C\u206F\u202E\u206D\u202C\u206B\u206D\u202C\u200D\u202E\u202A\u206D\u200E\u202A\u206D\u200C\u202A\u206F\u200D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Misfortune, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-418301056), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257));
		}

		static BatchLocalization \u200B\u202D\u206C\u206F\u206C\u202B\u200B\u206D\u206E\u206D\u206E\u202B\u202A\u206B\u206A\u206B\u200F\u200B\u202D\u202B\u206C\u206B\u206E\u206F\u206A\u200B\u202D\u206E\u206E\u202A\u206F\u202D\u202D\u202B\u200B\u200D\u200B\u206B\u206D\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u200D\u202D\u200B\u206A\u202B\u200D\u200D\u206E\u200C\u202D\u202B\u202C\u200B\u200D\u202C\u202C\u206C\u200C\u206D\u200E\u206C\u206F\u202E\u206D\u202C\u206B\u206D\u202C\u200D\u202E\u202A\u206D\u200E\u202A\u206D\u200C\u202A\u206F\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u200E\u206D\u206B\u202B\u206C\u202E\u200B\u206B\u200D\u206D\u206A\u202C\u206A\u206F\u200C\u202C\u206D\u206C\u202B\u202D\u206D\u200E\u200C\u200B\u206B\u200F\u200B\u200C\u206D\u202A\u200D\u206A\u206B\u206C\u206B\u200F\u202C\u200E\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbRedIndiscriminateIgnitionSeDef))]
		public sealed class AyaOrbRedIndiscriminateIgnitionSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.\u206E\u202B\u200D\u202A\u200D\u200F\u202A\u202A\u202D\u200F\u206C\u200C\u200B\u202C\u202A\u202E\u202C\u206A\u200F\u200E\u206A\u202A\u202E\u202C\u206A\u200D\u202C\u200D\u206C\u200E\u202D\u200F\u200F\u202B\u202A\u206A\u206D\u200D\u202C\u202C\u202E(AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.\u206A\u202E\u202B\u206E\u202B\u202A\u200B\u206F\u200B\u200E\u206B\u200E\u200F\u202D\u206A\u206F\u202E\u202B\u200D\u202D\u200D\u202C\u206E\u206B\u202B\u200D\u206A\u200E\u202C\u202A\u200C\u200D\u202E\u200F\u206E\u200C\u206D\u202E\u206B\u206A\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
				for (;;)
				{
					IL_001D:
					int num = 414076029;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)((num2 * 1631362125) ^ ((-654343665 - -402130903) * 1925590851) ^ -1044720032))) % 3U)
						{
						case 1U:
							base.ReactOwnerEvent<CardEventArgs>(AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.\u202B\u202C\u206D\u206B\u202D\u202D\u202E\u202D\u200F\u206A\u202D\u200E\u200F\u200C\u202B\u200D\u202E\u200B\u206B\u206C\u206B\u200D\u206E\u202D\u206D\u206A\u200C\u200F\u200B\u206B\u200B\u200F\u206C\u200C\u206C\u200B\u202E\u200E\u202A\u206E\u202E(AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.\u202B\u200E\u206E\u202A\u202B\u200B\u202E\u206D\u206A\u200C\u200F\u200E\u200C\u200E\u202D\u206B\u202A\u202B\u206E\u206B\u206B\u202D\u200C\u200D\u202B\u206C\u200D\u200E\u202A\u206E\u200F\u200E\u206A\u202C\u202B\u200E\u206D\u202C\u200C\u202D\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardDrawn));
							num = (int)((num3 * 2914808906U) ^ 2639748543U);
							continue;
						case 2U:
							goto IL_001D;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnTurnEnding(GameEventArgs args)
			{
				AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.<OnTurnEnding>d__1 <OnTurnEnding>d__ = new AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.<OnTurnEnding>d__1(-2);
				<OnTurnEnding>d__.<>4__this = this;
				return <OnTurnEnding>d__;
			}

			private IEnumerable<BattleAction> OnCardDrawn(CardEventArgs args)
			{
				AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.<OnCardDrawn>d__2 <OnCardDrawn>d__ = new AyaOrbRedIndiscriminateIgnitionSeDef.AyaOrbRedIndiscriminateIgnitionSe.<OnCardDrawn>d__2(-2);
				<OnCardDrawn>d__.<>4__this = this;
				<OnCardDrawn>d__.<>3__args = args;
				return <OnCardDrawn>d__;
			}

			static Unit \u206A\u202E\u202B\u206E\u202B\u202A\u200B\u206F\u200B\u200E\u206B\u200E\u200F\u202D\u206A\u206F\u202E\u202B\u200D\u202D\u200D\u202C\u206E\u206B\u202B\u200D\u206A\u200E\u202C\u202A\u200C\u200D\u202E\u200F\u206E\u200C\u206D\u202E\u206B\u206A\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u206E\u202B\u200D\u202A\u200D\u200F\u202A\u202A\u202D\u200F\u206C\u200C\u200B\u202C\u202A\u202E\u202C\u206A\u200F\u200E\u206A\u202A\u202E\u202C\u206A\u200D\u202C\u200D\u206C\u200E\u202D\u200F\u200F\u202B\u202A\u206A\u206D\u200D\u202C\u202C\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}

			static BattleController \u202B\u200E\u206E\u202A\u202B\u200B\u202E\u206D\u206A\u200C\u200F\u200E\u200C\u200E\u202D\u206B\u202A\u202B\u206E\u206B\u206B\u202D\u200C\u200D\u202B\u206C\u200D\u200E\u202A\u206E\u200F\u200E\u206A\u202C\u202B\u200E\u206D\u202C\u200C\u202D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardEventArgs> \u202B\u202C\u206D\u206B\u202D\u202D\u202E\u202D\u200F\u206A\u202D\u200E\u200F\u200C\u202B\u200D\u202E\u200B\u206B\u206C\u206B\u200D\u206E\u202D\u206D\u206A\u200C\u200F\u200B\u206B\u200B\u200F\u206C\u200C\u206C\u200B\u202E\u200E\u202A\u206E\u202E(BattleController A_0)
			{
				return A_0.CardDrawn;
			}
		}
	}
}
