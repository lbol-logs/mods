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
	public sealed class AyaOrbColorlessPoweroftheOrdinarySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2007034117);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbColorlessPoweroftheOrdinarySeDef.\u200D\u200B\u202E\u200F\u206D\u202E\u206E\u206D\u202C\u202D\u200F\u202A\u200C\u200C\u206B\u202E\u200D\u202B\u200D\u202E\u200F\u200D\u200F\u200E\u206E\u206C\u206A\u206F\u202C\u200E\u202C\u206B\u202D\u206F\u200F\u200D\u206B\u200E\u200D\u206F\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return ResourcesHelper.Sprites[AyaOrbColorlessPoweroftheOrdinarySeDef.\u200E\u206D\u200D\u202A\u202D\u206F\u200E\u200F\u202C\u202C\u206E\u206A\u206C\u202B\u200D\u200C\u206E\u200D\u200F\u206B\u200C\u200B\u206F\u206F\u200C\u202B\u200F\u200D\u202A\u200B\u202D\u206C\u206E\u200C\u202C\u206A\u202C\u200C\u206A\u200F\u202E(typeof(StatusEffect).TypeHandle)][<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(390582336)];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbColorlessPoweroftheOrdinarySeDef.\u200D\u206D\u202E\u206B\u200B\u200C\u206B\u206C\u206B\u200F\u202C\u206A\u206F\u202B\u200C\u202B\u206D\u202D\u200D\u206D\u206C\u200F\u206E\u206D\u206A\u200F\u200B\u202A\u202E\u200E\u206B\u200C\u200D\u206B\u202E\u202B\u206B\u206B\u200D\u200E\u202E(BepinexPlugin.sequenceTable, AyaOrbColorlessPoweroftheOrdinarySeDef.\u200E\u206D\u200D\u202A\u202D\u206F\u200E\u200F\u202C\u202C\u206E\u206A\u206C\u202B\u200D\u200C\u206E\u200D\u200F\u206B\u200C\u200B\u206F\u206F\u200C\u202B\u200F\u200D\u202A\u200B\u202D\u206C\u206E\u200C\u202C\u206A\u202C\u200C\u206A\u200F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Dream, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-566389668) }, null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794));
		}

		static BatchLocalization \u200D\u200B\u202E\u200F\u206D\u202E\u206E\u206D\u202C\u202D\u200F\u202A\u200C\u200C\u206B\u202E\u200D\u202B\u200D\u202E\u200F\u200D\u200F\u200E\u206E\u206C\u206A\u206F\u202C\u200E\u202C\u206B\u202D\u206F\u200F\u200D\u206B\u200E\u200D\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u206D\u200D\u202A\u202D\u206F\u200E\u200F\u202C\u202C\u206E\u206A\u206C\u202B\u200D\u200C\u206E\u200D\u200F\u206B\u200C\u200B\u206F\u206F\u200C\u202B\u200F\u200D\u202A\u200B\u202D\u206C\u206E\u200C\u202C\u206A\u202C\u200C\u206A\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206D\u202E\u206B\u200B\u200C\u206B\u206C\u206B\u200F\u202C\u206A\u206F\u202B\u200C\u202B\u206D\u202D\u200D\u206D\u206C\u200F\u206E\u206D\u206A\u200F\u200B\u202A\u202E\u200E\u206B\u200C\u200D\u206B\u202E\u202B\u206B\u206B\u200D\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbColorlessPoweroftheOrdinarySeDef))]
		public sealed class AyaOrbColorlessPoweroftheOrdinarySe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<CardUsingEventArgs>(AyaOrbColorlessPoweroftheOrdinarySeDef.AyaOrbColorlessPoweroftheOrdinarySe.\u200E\u200D\u200B\u202A\u206B\u200F\u200B\u206D\u200C\u206D\u200C\u200B\u202B\u206D\u206A\u200F\u200F\u202C\u200B\u202C\u206E\u206B\u206F\u206E\u206A\u200D\u206B\u206F\u202A\u202D\u206E\u202B\u200F\u206B\u202C\u200E\u206D\u206A\u200F\u202B\u202E(AyaOrbColorlessPoweroftheOrdinarySeDef.AyaOrbColorlessPoweroftheOrdinarySe.\u202E\u202C\u206C\u202E\u202E\u206A\u206E\u206D\u206A\u200D\u200D\u206F\u206E\u200D\u202A\u206E\u206B\u200E\u200C\u202A\u206A\u202C\u206A\u202C\u200B\u206A\u200F\u202B\u200E\u200E\u202D\u202C\u200C\u206B\u206A\u200D\u202D\u202D\u202D\u200D\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				AyaOrbColorlessPoweroftheOrdinarySeDef.AyaOrbColorlessPoweroftheOrdinarySe.<OnCardUsed>d__1 <OnCardUsed>d__ = new AyaOrbColorlessPoweroftheOrdinarySeDef.AyaOrbColorlessPoweroftheOrdinarySe.<OnCardUsed>d__1(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			static BattleController \u202E\u202C\u206C\u202E\u202E\u206A\u206E\u206D\u206A\u200D\u200D\u206F\u206E\u200D\u202A\u206E\u206B\u200E\u200C\u202A\u206A\u202C\u206A\u202C\u200B\u206A\u200F\u202B\u200E\u200E\u202D\u202C\u200C\u206B\u206A\u200D\u202D\u202D\u202D\u200D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardUsingEventArgs> \u200E\u200D\u200B\u202A\u206B\u200F\u200B\u206D\u200C\u206D\u200C\u200B\u202B\u206D\u206A\u200F\u200F\u202C\u200B\u202C\u206E\u206B\u206F\u206E\u206A\u200D\u206B\u206F\u202A\u202D\u206E\u202B\u200F\u206B\u202C\u200E\u206D\u206A\u200F\u202B\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}
		}
	}
}
