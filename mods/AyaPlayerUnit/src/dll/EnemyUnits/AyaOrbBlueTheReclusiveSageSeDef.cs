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
	public sealed class AyaOrbBlueTheReclusiveSageSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1195576766);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbBlueTheReclusiveSageSeDef.\u206E\u206D\u200E\u206A\u202C\u200C\u200C\u206B\u206C\u206F\u200D\u200C\u200B\u200E\u200D\u206F\u206F\u202B\u206F\u202A\u200C\u206D\u202A\u206A\u206E\u206F\u200D\u200F\u200D\u206A\u206E\u206A\u206A\u206A\u206E\u202C\u206C\u202D\u206E\u202D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaOrbBlueTheReclusiveSageSeDef.\u202B\u206E\u200E\u200C\u202D\u202C\u200E\u200F\u200D\u206C\u200F\u202C\u206B\u206C\u200F\u206F\u206A\u206C\u200E\u200E\u206C\u200E\u202C\u200F\u206D\u202C\u206B\u206B\u206A\u200D\u206D\u202E\u206D\u200B\u202B\u200F\u202E\u202E\u206E\u202D\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-880300453)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbBlueTheReclusiveSageSeDef.\u206D\u206A\u200E\u202E\u202B\u202D\u200C\u206C\u202A\u200F\u200C\u200C\u200D\u200C\u202E\u206B\u200E\u206D\u200B\u200F\u202A\u202C\u206E\u206D\u200C\u206C\u202B\u206B\u206B\u206D\u206C\u200C\u200B\u206C\u200C\u200D\u206A\u202B\u202D\u202E\u202E(BepinexPlugin.sequenceTable, AyaOrbBlueTheReclusiveSageSeDef.\u202B\u206E\u200E\u200C\u202D\u202C\u200E\u200F\u200D\u206C\u200F\u202C\u206B\u206C\u200F\u206F\u206A\u206C\u200E\u200E\u206C\u200E\u202C\u200F\u206D\u202C\u206B\u206B\u206A\u200D\u206D\u202E\u206D\u200B\u202B\u200F\u202E\u202E\u206E\u202D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Dream, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(2044252853), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257));
		}

		static BatchLocalization \u206E\u206D\u200E\u206A\u202C\u200C\u200C\u206B\u206C\u206F\u200D\u200C\u200B\u200E\u200D\u206F\u206F\u202B\u206F\u202A\u200C\u206D\u202A\u206A\u206E\u206F\u200D\u200F\u200D\u206A\u206E\u206A\u206A\u206A\u206E\u202C\u206C\u202D\u206E\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u206E\u200E\u200C\u202D\u202C\u200E\u200F\u200D\u206C\u200F\u202C\u206B\u206C\u200F\u206F\u206A\u206C\u200E\u200E\u206C\u200E\u202C\u200F\u206D\u202C\u206B\u206B\u206A\u200D\u206D\u202E\u206D\u200B\u202B\u200F\u202E\u202E\u206E\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u206A\u200E\u202E\u202B\u202D\u200C\u206C\u202A\u200F\u200C\u200C\u200D\u200C\u202E\u206B\u200E\u206D\u200B\u200F\u202A\u202C\u206E\u206D\u200C\u206C\u202B\u206B\u206B\u206D\u206C\u200C\u200B\u206C\u200C\u200D\u206A\u202B\u202D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbBlueTheReclusiveSageSeDef))]
		public sealed class AyaOrbBlueTheReclusiveSageSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<GameEventArgs>(AyaOrbBlueTheReclusiveSageSeDef.AyaOrbBlueTheReclusiveSageSe.\u200B\u200B\u200E\u202C\u202B\u206C\u202C\u206F\u200F\u206A\u200F\u206F\u200B\u206B\u206D\u206B\u200C\u206D\u200E\u200D\u202A\u200B\u200E\u206A\u202C\u206F\u202C\u200E\u206B\u200F\u206E\u200F\u200F\u202D\u202E\u202C\u200C\u200E\u202D\u202D\u202E(AyaOrbBlueTheReclusiveSageSeDef.AyaOrbBlueTheReclusiveSageSe.\u202A\u200E\u206E\u206E\u200E\u206F\u206C\u200F\u206E\u202A\u206A\u206D\u202A\u200E\u206B\u202E\u206E\u200E\u202B\u206A\u202D\u200C\u202C\u200D\u206C\u206A\u202C\u202A\u200E\u206D\u200B\u202C\u200C\u202E\u200B\u206A\u202C\u202A\u200F\u206D\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnRoundEnding));
			}

			private IEnumerable<BattleAction> OnRoundEnding(GameEventArgs args)
			{
				AyaOrbBlueTheReclusiveSageSeDef.AyaOrbBlueTheReclusiveSageSe.<OnRoundEnding>d__1 <OnRoundEnding>d__ = new AyaOrbBlueTheReclusiveSageSeDef.AyaOrbBlueTheReclusiveSageSe.<OnRoundEnding>d__1(-2);
				<OnRoundEnding>d__.<>4__this = this;
				return <OnRoundEnding>d__;
			}

			static BattleController \u202A\u200E\u206E\u206E\u200E\u206F\u206C\u200F\u206E\u202A\u206A\u206D\u202A\u200E\u206B\u202E\u206E\u200E\u202B\u206A\u202D\u200C\u202C\u200D\u206C\u206A\u202C\u202A\u200E\u206D\u200B\u202C\u200C\u202E\u200B\u206A\u202C\u202A\u200F\u206D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u200B\u200B\u200E\u202C\u202B\u206C\u202C\u206F\u200F\u206A\u200F\u206F\u200B\u206B\u206D\u206B\u200C\u206D\u200E\u200D\u202A\u200B\u200E\u206A\u202C\u206F\u202C\u200E\u206B\u200F\u206E\u200F\u200F\u202D\u202E\u202C\u200C\u200E\u202D\u202D\u202E(BattleController A_0)
			{
				return A_0.RoundEnding;
			}
		}
	}
}
