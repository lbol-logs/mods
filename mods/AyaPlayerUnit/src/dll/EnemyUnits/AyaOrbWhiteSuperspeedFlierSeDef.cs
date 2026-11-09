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
	public sealed class AyaOrbWhiteSuperspeedFlierSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1218630049);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbWhiteSuperspeedFlierSeDef.\u206D\u202B\u206C\u200B\u206D\u206D\u200D\u206C\u206A\u206A\u200B\u206D\u206F\u200D\u206C\u206E\u206B\u200D\u206D\u202B\u202A\u200D\u206A\u202A\u206F\u206A\u200C\u202D\u206A\u202A\u200B\u206A\u206A\u200F\u200B\u206A\u206B\u200E\u206F\u206C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaOrbWhiteSuperspeedFlierSeDef.\u202C\u200D\u202B\u202B\u202A\u206E\u202A\u202C\u202C\u206D\u200F\u206B\u206B\u200E\u206B\u206E\u206C\u206C\u200F\u202E\u200D\u200F\u200F\u200C\u200C\u200E\u202C\u202E\u200B\u202E\u202A\u202C\u202B\u200E\u206A\u200D\u206D\u200C\u202B\u206D\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-866881863)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbWhiteSuperspeedFlierSeDef.\u206D\u202A\u202B\u206F\u206A\u202D\u206E\u202B\u200E\u202B\u206C\u200B\u202E\u206E\u206F\u202B\u200C\u206E\u200F\u202D\u200F\u200B\u206B\u202E\u202A\u200F\u206E\u200E\u206E\u200D\u206F\u200F\u200F\u206D\u200D\u202A\u206F\u202A\u200D\u206B\u202E(BepinexPlugin.sequenceTable, AyaOrbWhiteSuperspeedFlierSeDef.\u202C\u200D\u202B\u202B\u202A\u206E\u202A\u202C\u202C\u206D\u200F\u206B\u206B\u200E\u206B\u206E\u206C\u206C\u200F\u202E\u200D\u200F\u200F\u200C\u200C\u200E\u202C\u202E\u200B\u202E\u202A\u202C\u202B\u200E\u206A\u200D\u206D\u200C\u202B\u206D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1566246004), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u206D\u202B\u206C\u200B\u206D\u206D\u200D\u206C\u206A\u206A\u200B\u206D\u206F\u200D\u206C\u206E\u206B\u200D\u206D\u202B\u202A\u200D\u206A\u202A\u206F\u206A\u200C\u202D\u206A\u202A\u200B\u206A\u206A\u200F\u200B\u206A\u206B\u200E\u206F\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u200D\u202B\u202B\u202A\u206E\u202A\u202C\u202C\u206D\u200F\u206B\u206B\u200E\u206B\u206E\u206C\u206C\u200F\u202E\u200D\u200F\u200F\u200C\u200C\u200E\u202C\u202E\u200B\u202E\u202A\u202C\u202B\u200E\u206A\u200D\u206D\u200C\u202B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u202A\u202B\u206F\u206A\u202D\u206E\u202B\u200E\u202B\u206C\u200B\u202E\u206E\u206F\u202B\u200C\u206E\u200F\u202D\u200F\u200B\u206B\u202E\u202A\u200F\u206E\u200E\u206E\u200D\u206F\u200F\u200F\u206D\u200D\u202A\u206F\u202A\u200D\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbWhiteSuperspeedFlierSeDef))]
		public sealed class AyaOrbWhiteSuperspeedFlierSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaOrbWhiteSuperspeedFlierSeDef.AyaOrbWhiteSuperspeedFlierSe.\u202C\u200B\u200C\u206D\u202C\u206C\u200C\u200E\u206D\u202C\u202D\u202C\u200B\u200E\u206C\u200F\u206F\u202D\u206E\u206B\u202D\u206B\u206C\u202A\u202D\u206B\u200E\u202D\u206F\u206B\u202E\u206D\u200E\u200C\u200F\u202C\u200D\u200E\u206E\u200F\u202E(AyaOrbWhiteSuperspeedFlierSeDef.AyaOrbWhiteSuperspeedFlierSe.\u202E\u202D\u200F\u206C\u202C\u206F\u202A\u202B\u202E\u200F\u200E\u202E\u206B\u200B\u206A\u202A\u202A\u206C\u206D\u202E\u202B\u200F\u206E\u206F\u200C\u202C\u206C\u206E\u200C\u200B\u202D\u200E\u200C\u202C\u200D\u200D\u202D\u202B\u202A\u200F\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnTurnStarted));
			}

			private IEnumerable<BattleAction> OnTurnStarted(UnitEventArgs args)
			{
				AyaOrbWhiteSuperspeedFlierSeDef.AyaOrbWhiteSuperspeedFlierSe.<OnTurnStarted>d__1 <OnTurnStarted>d__ = new AyaOrbWhiteSuperspeedFlierSeDef.AyaOrbWhiteSuperspeedFlierSe.<OnTurnStarted>d__1(-2);
				<OnTurnStarted>d__.<>4__this = this;
				return <OnTurnStarted>d__;
			}

			static Unit \u202E\u202D\u200F\u206C\u202C\u206F\u202A\u202B\u202E\u200F\u200E\u202E\u206B\u200B\u206A\u202A\u202A\u206C\u206D\u202E\u202B\u200F\u206E\u206F\u200C\u202C\u206C\u206E\u200C\u200B\u202D\u200E\u200C\u202C\u200D\u200D\u202D\u202B\u202A\u200F\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u202C\u200B\u200C\u206D\u202C\u206C\u200C\u200E\u206D\u202C\u202D\u202C\u200B\u200E\u206C\u200F\u206F\u202D\u206E\u206B\u202D\u206B\u206C\u202A\u202D\u206B\u200E\u202D\u206F\u206B\u202E\u206D\u200E\u200C\u200F\u202C\u200D\u200E\u206E\u200F\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}
		}
	}
}
