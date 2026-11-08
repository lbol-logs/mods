using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaOrbRedSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(393384323);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaOrbRedSeDef.\u200E\u200D\u206C\u200D\u206F\u206E\u206F\u202B\u200E\u206E\u202A\u202E\u200F\u200E\u206F\u206D\u200C\u200B\u206D\u202A\u200F\u200D\u206F\u206C\u206C\u200E\u200D\u202C\u206D\u202C\u202D\u202C\u200B\u206A\u202E\u206F\u206D\u202A\u206D\u200C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaOrbRedSeDef.\u206F\u200D\u202D\u206E\u200D\u200C\u200E\u206A\u206E\u206A\u202C\u200F\u200E\u200B\u202A\u206D\u200C\u206B\u206D\u200B\u206A\u206D\u202B\u202A\u200E\u206F\u200D\u202B\u206D\u206E\u200F\u202D\u206B\u200F\u202E\u206C\u206F\u200F\u200B\u206F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(712374991), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaOrbRedSeDef.\u202C\u200D\u202D\u202D\u202D\u202A\u206C\u200F\u206D\u202B\u200E\u202C\u200F\u200C\u206C\u206D\u200C\u200B\u200E\u206B\u206B\u200F\u202B\u202B\u206C\u206A\u206B\u206B\u206D\u200E\u206D\u200D\u200D\u206A\u200E\u206D\u200D\u202C\u206C\u202A\u202E(BepinexPlugin.sequenceTable, AyaOrbRedSeDef.\u206F\u206A\u206B\u200C\u202E\u206B\u200D\u202D\u200B\u206F\u206F\u206F\u202C\u206C\u200B\u206E\u200E\u202B\u206D\u200B\u202D\u200B\u202A\u202D\u200D\u200B\u200D\u206A\u206A\u200D\u202B\u200B\u200C\u202D\u206C\u200B\u200C\u206E\u206E\u206D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 0, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794));
		}

		static BatchLocalization \u200E\u200D\u206C\u200D\u206F\u206E\u206F\u202B\u200E\u206E\u202A\u202E\u200F\u200E\u206F\u206D\u200C\u200B\u206D\u202A\u200F\u200D\u206F\u206C\u206C\u200E\u200D\u202C\u206D\u202C\u202D\u202C\u200B\u206A\u202E\u206F\u206D\u202A\u206D\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206F\u200D\u202D\u206E\u200D\u200C\u200E\u206A\u206E\u206A\u202C\u200F\u200E\u200B\u202A\u206D\u200C\u206B\u206D\u200B\u206A\u206D\u202B\u202A\u200E\u206F\u200D\u202B\u206D\u206E\u200F\u202D\u206B\u200F\u202E\u206C\u206F\u200F\u200B\u206F\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206F\u206A\u206B\u200C\u202E\u206B\u200D\u202D\u200B\u206F\u206F\u206F\u202C\u206C\u200B\u206E\u200E\u202B\u206D\u200B\u202D\u200B\u202A\u202D\u200D\u200B\u200D\u206A\u206A\u200D\u202B\u200B\u200C\u202D\u206C\u200B\u200C\u206E\u206E\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u200D\u202D\u202D\u202D\u202A\u206C\u200F\u206D\u202B\u200E\u202C\u200F\u200C\u206C\u206D\u200C\u200B\u200E\u206B\u206B\u200F\u202B\u202B\u206C\u206A\u206B\u206B\u206D\u200E\u206D\u200D\u200D\u206A\u200E\u206D\u200D\u202C\u206C\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaOrbRedSeDef))]
		public sealed class AyaOrbRedSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<CardUsingEventArgs>(AyaOrbRedSeDef.AyaOrbRedSe.\u202B\u202B\u206D\u200C\u200B\u202C\u200D\u206B\u202E\u202A\u202E\u206F\u206A\u206F\u200C\u206C\u206E\u200D\u200D\u200E\u202D\u206D\u200B\u202E\u200F\u202C\u202D\u206E\u202D\u202B\u206C\u200D\u200C\u200D\u200E\u200D\u200E\u202D\u200D\u202A\u202E(AyaOrbRedSeDef.AyaOrbRedSe.\u200F\u206D\u202B\u200F\u200D\u200E\u206B\u206F\u202E\u206B\u200B\u200B\u200E\u200F\u206B\u200F\u200D\u206F\u202D\u206E\u202B\u206C\u200E\u202D\u200D\u206F\u206D\u200F\u200B\u202A\u206E\u206D\u200E\u202D\u200C\u206D\u202A\u200F\u202C\u200D\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsing));
			}

			private IEnumerable<BattleAction> OnCardUsing(CardUsingEventArgs arg)
			{
				AyaOrbRedSeDef.AyaOrbRedSe.<OnCardUsing>d__1 <OnCardUsing>d__ = new AyaOrbRedSeDef.AyaOrbRedSe.<OnCardUsing>d__1(-2);
				<OnCardUsing>d__.<>4__this = this;
				<OnCardUsing>d__.<>3__arg = arg;
				return <OnCardUsing>d__;
			}

			static BattleController \u200F\u206D\u202B\u200F\u200D\u200E\u206B\u206F\u202E\u206B\u200B\u200B\u200E\u200F\u206B\u200F\u200D\u206F\u202D\u206E\u202B\u206C\u200E\u202D\u200D\u206F\u206D\u200F\u200B\u202A\u206E\u206D\u200E\u202D\u200C\u206D\u202A\u200F\u202C\u200D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardUsingEventArgs> \u202B\u202B\u206D\u200C\u200B\u202C\u200D\u206B\u202E\u202A\u202E\u206F\u206A\u206F\u200C\u206C\u206E\u200D\u200D\u200E\u202D\u206D\u200B\u202E\u200F\u202C\u202D\u206E\u202D\u202B\u206C\u200D\u200C\u200D\u200E\u200D\u200E\u202D\u200D\u202A\u202E(BattleController A_0)
			{
				return A_0.CardUsing;
			}
		}
	}
}
