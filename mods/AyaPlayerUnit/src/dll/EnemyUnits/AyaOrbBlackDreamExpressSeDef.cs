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
	public sealed class AyaOrbBlackDreamExpressSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1604089247);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbBlackDreamExpressSeDef.\u202A\u206D\u200D\u202A\u206A\u200C\u202A\u202D\u206A\u202A\u206F\u206E\u202A\u206D\u206C\u200B\u206E\u200F\u206D\u206A\u206A\u200C\u206D\u202D\u202B\u200D\u200D\u206F\u206B\u206C\u200E\u206D\u206B\u200C\u206B\u200F\u206E\u200E\u200C\u202A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaOrbBlackDreamExpressSeDef.\u202E\u200D\u200F\u202E\u200D\u200F\u206F\u202A\u202A\u200B\u202E\u202B\u202B\u200C\u206D\u206F\u202E\u200E\u200C\u206C\u202C\u202D\u206F\u206F\u200C\u200E\u202D\u206E\u202E\u202C\u206D\u202E\u200E\u202B\u202C\u202E\u200D\u200C\u206B\u206D\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1675760887)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbBlackDreamExpressSeDef.\u202A\u206D\u202E\u206F\u202A\u202E\u206D\u206C\u206A\u206A\u200F\u206D\u202B\u200F\u202A\u200C\u206A\u206B\u202E\u200C\u202C\u200B\u206F\u202A\u206E\u202E\u206C\u200B\u206B\u202E\u200C\u206D\u206F\u200B\u202E\u206E\u206F\u202A\u206D\u200E\u202E(BepinexPlugin.sequenceTable, AyaOrbBlackDreamExpressSeDef.\u202E\u200D\u200F\u202E\u200D\u200F\u206F\u202A\u202A\u200B\u202E\u202B\u202B\u200C\u206D\u206F\u202E\u200E\u200C\u206C\u202C\u202D\u206F\u206F\u200C\u200E\u202D\u206E\u202E\u202C\u206D\u202E\u200E\u202B\u202C\u202E\u200D\u200C\u206B\u206D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Dream, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(701329049), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750));
		}

		static BatchLocalization \u202A\u206D\u200D\u202A\u206A\u200C\u202A\u202D\u206A\u202A\u206F\u206E\u202A\u206D\u206C\u200B\u206E\u200F\u206D\u206A\u206A\u200C\u206D\u202D\u202B\u200D\u200D\u206F\u206B\u206C\u200E\u206D\u206B\u200C\u206B\u200F\u206E\u200E\u200C\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u200D\u200F\u202E\u200D\u200F\u206F\u202A\u202A\u200B\u202E\u202B\u202B\u200C\u206D\u206F\u202E\u200E\u200C\u206C\u202C\u202D\u206F\u206F\u200C\u200E\u202D\u206E\u202E\u202C\u206D\u202E\u200E\u202B\u202C\u202E\u200D\u200C\u206B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206D\u202E\u206F\u202A\u202E\u206D\u206C\u206A\u206A\u200F\u206D\u202B\u200F\u202A\u200C\u206A\u206B\u202E\u200C\u202C\u200B\u206F\u202A\u206E\u202E\u206C\u200B\u206B\u202E\u200C\u206D\u206F\u200B\u202E\u206E\u206F\u202A\u206D\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbBlackDreamExpressSeDef))]
		public sealed class AyaOrbBlackDreamExpressSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaOrbBlackDreamExpressSeDef.AyaOrbBlackDreamExpressSe.\u206D\u202B\u206F\u206A\u200F\u202E\u206F\u200C\u202E\u200E\u206B\u206B\u202E\u200D\u202B\u200C\u206D\u202A\u206F\u200C\u202C\u202E\u200F\u206A\u206F\u206D\u202D\u206E\u200D\u202C\u200D\u202B\u202B\u200F\u206B\u202C\u206B\u202D\u200C\u206E\u202E(AyaOrbBlackDreamExpressSeDef.AyaOrbBlackDreamExpressSe.\u206E\u200D\u200C\u206E\u206C\u202B\u206B\u200C\u200B\u206C\u206D\u202A\u206D\u200D\u206C\u202C\u202A\u206B\u200F\u202D\u200B\u200C\u206B\u202A\u202A\u206F\u200B\u206B\u202D\u202D\u206B\u206F\u200B\u202E\u206B\u200E\u200B\u200C\u200B\u202B\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnTurnEnding));
			}

			private IEnumerable<BattleAction> OnTurnEnding(UnitEventArgs args)
			{
				AyaOrbBlackDreamExpressSeDef.AyaOrbBlackDreamExpressSe.<OnTurnEnding>d__1 <OnTurnEnding>d__ = new AyaOrbBlackDreamExpressSeDef.AyaOrbBlackDreamExpressSe.<OnTurnEnding>d__1(-2);
				<OnTurnEnding>d__.<>4__this = this;
				return <OnTurnEnding>d__;
			}

			static Unit \u206E\u200D\u200C\u206E\u206C\u202B\u206B\u200C\u200B\u206C\u206D\u202A\u206D\u200D\u206C\u202C\u202A\u206B\u200F\u202D\u200B\u200C\u206B\u202A\u202A\u206F\u200B\u206B\u202D\u202D\u206B\u206F\u200B\u202E\u206B\u200E\u200B\u200C\u200B\u202B\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u206D\u202B\u206F\u206A\u200F\u202E\u206F\u200C\u202E\u200E\u206B\u206B\u202E\u200D\u202B\u200C\u206D\u202A\u206F\u200C\u202C\u202E\u200F\u206A\u206F\u206D\u202D\u206E\u200D\u202C\u200D\u202B\u202B\u200F\u206B\u202C\u206B\u202D\u200C\u206E\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}
		}
	}
}
