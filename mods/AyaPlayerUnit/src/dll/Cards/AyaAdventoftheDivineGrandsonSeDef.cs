using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaAdventoftheDivineGrandsonSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-563072648);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaAdventoftheDivineGrandsonSeDef.\u206C\u206A\u206B\u206A\u202A\u206D\u206B\u206F\u206B\u200E\u202D\u202E\u206C\u206B\u206D\u200B\u206B\u202E\u206D\u206C\u200F\u202C\u206D\u200B\u206A\u202A\u200E\u206E\u206F\u206F\u202C\u202B\u206C\u200D\u202C\u202C\u200E\u206F\u200D\u206B\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaAdventoftheDivineGrandsonSeDef.\u202E\u202D\u206F\u206C\u202B\u206E\u200E\u202C\u200F\u202B\u202D\u202B\u206B\u206A\u202B\u202B\u200F\u200F\u202E\u206D\u202A\u206D\u200F\u202E\u206B\u200D\u200F\u202C\u200E\u200C\u206D\u206E\u200F\u202E\u202A\u206A\u200F\u206F\u202A\u200C\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1675348517), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaAdventoftheDivineGrandsonSeDef.\u200C\u200C\u200D\u200F\u206F\u202E\u200E\u202C\u206A\u206B\u206D\u200C\u206B\u206E\u200E\u200D\u202A\u202D\u206E\u202C\u200B\u202D\u206C\u206D\u202D\u206C\u200F\u200E\u206F\u206F\u206B\u200F\u206D\u206C\u206A\u206F\u206F\u206B\u202A\u202E(BepinexPlugin.sequenceTable, AyaAdventoftheDivineGrandsonSeDef.\u200C\u200B\u206A\u202A\u202A\u202D\u202B\u200F\u200E\u200D\u206B\u202D\u200B\u206F\u202E\u202B\u202A\u202B\u200C\u206D\u200C\u206F\u206F\u206F\u200B\u200C\u206F\u206B\u202C\u200D\u202C\u200E\u202A\u206D\u200D\u206A\u206C\u202D\u200C\u200F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", -2, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(859402033));
		}

		static BatchLocalization \u206C\u206A\u206B\u206A\u202A\u206D\u206B\u206F\u206B\u200E\u202D\u202E\u206C\u206B\u206D\u200B\u206B\u202E\u206D\u206C\u200F\u202C\u206D\u200B\u206A\u202A\u200E\u206E\u206F\u206F\u202C\u202B\u206C\u200D\u202C\u202C\u200E\u206F\u200D\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202E\u202D\u206F\u206C\u202B\u206E\u200E\u202C\u200F\u202B\u202D\u202B\u206B\u206A\u202B\u202B\u200F\u200F\u202E\u206D\u202A\u206D\u200F\u202E\u206B\u200D\u200F\u202C\u200E\u200C\u206D\u206E\u200F\u202E\u202A\u206A\u200F\u206F\u202A\u200C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200C\u200B\u206A\u202A\u202A\u202D\u202B\u200F\u200E\u200D\u206B\u202D\u200B\u206F\u202E\u202B\u202A\u202B\u200C\u206D\u200C\u206F\u206F\u206F\u200B\u200C\u206F\u206B\u202C\u200D\u202C\u200E\u202A\u206D\u200D\u206A\u206C\u202D\u200C\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u200C\u200D\u200F\u206F\u202E\u200E\u202C\u206A\u206B\u206D\u200C\u206B\u206E\u200E\u200D\u202A\u202D\u206E\u202C\u200B\u202D\u206C\u206D\u202D\u206C\u200F\u200E\u206F\u206F\u206B\u200F\u206D\u206C\u206A\u206F\u206F\u206B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaAdventoftheDivineGrandsonSeDef))]
		public sealed class AyaAdventoftheDivineGrandsonSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				if (AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u200E\u200E\u206A\u202D\u202E\u200F\u202A\u206B\u200E\u206D\u200C\u202E\u200E\u206F\u200C\u200C\u200D\u202C\u200F\u206D\u206C\u200C\u206E\u206B\u200C\u206B\u206D\u206C\u200E\u206E\u206B\u202B\u200E\u202A\u200B\u200E\u206D\u200C\u206F\u206D\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u206D\u200C\u202C\u206A\u202E\u200D\u206D\u200D\u200F\u200F\u206F\u200D\u206A\u200C\u202E\u206C\u200F\u206B\u202D\u202C\u202D\u206F\u202D\u202D\u206A\u200B\u202C\u202D\u206E\u202C\u200D\u200D\u200F\u206E\u200D\u200E\u202A\u202C\u200C\u202A\u202E(this)) is AyaPlayerUnitDef.AyaPlayerUnit)
				{
					for (;;)
					{
						IL_0015:
						int num = 808565179;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((-249066848 * 17236969 - -num2) ^ (-483931926 * -1743470245)) - -2090416650)) % 4U)
							{
							case 0U:
								base.ReactOwnerEvent<StatusEffectApplyEventArgs>(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u202D\u202B\u206D\u206C\u206E\u200E\u202B\u206C\u206C\u200F\u206B\u200D\u202D\u206E\u200F\u206E\u202A\u206D\u200B\u202E\u200B\u206C\u206B\u206C\u200D\u202B\u200C\u206F\u200E\u200D\u202E\u202C\u206E\u202A\u202C\u202A\u202D\u206F\u202E\u206C\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u200E\u200E\u206A\u202D\u202E\u200F\u202A\u206B\u200E\u206D\u200C\u202E\u200E\u206F\u200C\u200C\u200D\u202C\u200F\u206D\u206C\u200C\u206E\u206B\u200C\u206B\u206D\u206C\u200E\u206E\u206B\u202B\u200E\u202A\u200B\u200E\u206D\u200C\u206F\u206D\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u206D\u200C\u202C\u206A\u202E\u200D\u206D\u200D\u200F\u200F\u206F\u200D\u206A\u200C\u202E\u206C\u200F\u206B\u202D\u202C\u202D\u206F\u202D\u202D\u206A\u200B\u202C\u202D\u206E\u202C\u200D\u200D\u200F\u206E\u200D\u200E\u202A\u202C\u200C\u202A\u202E(this))), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnPlayerStatusEffectAdding));
								num = (int)((num3 * 4255221516U) ^ 2535727865U);
								continue;
							case 2U:
								goto IL_0015;
							case 3U:
								this.React(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u206A\u206D\u202E\u206A\u206D\u202C\u200E\u206D\u200E\u202E\u200B\u202B\u202D\u200F\u202A\u200B\u202C\u202A\u200F\u206D\u200E\u202C\u202C\u202A\u206C\u206D\u206A\u206F\u200C\u200C\u200F\u202D\u206E\u206B\u206E\u206F\u206F\u206E\u202B\u200C\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u202C\u200C\u206B\u202D\u206F\u206F\u206E\u200C\u200E\u200B\u202C\u200E\u206F\u200B\u206B\u202B\u202A\u200D\u200E\u206E\u202A\u206D\u200D\u200C\u202B\u202C\u206A\u202A\u206E\u200C\u200B\u206E\u200F\u206E\u200C\u200C\u200F\u206A\u206F\u206C\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u200E\u200E\u206A\u202D\u202E\u200F\u202A\u206B\u200E\u206D\u200C\u202E\u200E\u206F\u200C\u200C\u200D\u202C\u200F\u206D\u206C\u200C\u206E\u206B\u200C\u206B\u206D\u206C\u200E\u206E\u206B\u202B\u200E\u202A\u200B\u200E\u206D\u200C\u206F\u206D\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u206D\u200C\u202C\u206A\u202E\u200D\u206D\u200D\u200F\u200F\u206F\u200D\u206A\u200C\u202E\u206C\u200F\u206B\u202D\u202C\u202D\u206F\u202D\u202D\u206A\u200B\u202C\u202D\u206E\u202C\u200D\u200D\u200F\u206E\u200D\u200E\u202A\u202C\u200C\u202A\u202E(this)), 0f)));
								base.ReactOwnerEvent<CardUsingEventArgs>(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u200C\u202A\u206C\u200F\u200E\u202C\u206A\u206D\u200F\u200D\u200D\u200B\u202A\u200F\u202D\u200C\u202C\u206A\u200B\u202E\u202C\u206F\u200D\u202D\u206C\u206B\u200B\u206A\u200D\u200F\u206A\u202D\u206A\u202C\u206C\u200F\u206A\u202A\u202E\u206D\u202E(AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.\u206D\u200C\u202C\u206A\u202E\u200D\u206D\u200D\u200F\u200F\u206F\u200D\u206A\u200C\u202E\u206C\u200F\u206B\u202D\u202C\u202D\u206F\u202D\u202D\u206A\u200B\u202C\u202D\u206E\u202C\u200D\u200D\u200F\u206E\u200D\u200E\u202A\u202C\u200C\u202A\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
								num = (int)((num3 * 3743888206U) ^ 2353440278U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.<OnCardUsed>d__2 <OnCardUsed>d__ = new AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.<OnCardUsed>d__2(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.<OnPlayerStatusEffectAdding>d__3 <OnPlayerStatusEffectAdding>d__ = new AyaAdventoftheDivineGrandsonSeDef.AyaAdventoftheDivineGrandsonSe.<OnPlayerStatusEffectAdding>d__3(-2);
				<OnPlayerStatusEffectAdding>d__.<>4__this = this;
				<OnPlayerStatusEffectAdding>d__.<>3__args = args;
				return <OnPlayerStatusEffectAdding>d__;
			}

			protected override void OnRemoved(Unit unit)
			{
				AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.MusicChanged = false;
			}

			public override string UnitEffectName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(80395177);
				}
			}

			static BattleController \u206D\u200C\u202C\u206A\u202E\u200D\u206D\u200D\u200F\u200F\u206F\u200D\u206A\u200C\u202E\u206C\u200F\u206B\u202D\u202C\u202D\u206F\u202D\u202D\u206A\u200B\u202C\u202D\u206E\u202C\u200D\u200D\u200F\u206E\u200D\u200E\u202A\u202C\u200C\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200E\u200E\u206A\u202D\u202E\u200F\u202A\u206B\u200E\u206D\u200C\u202E\u200E\u206F\u200C\u200C\u200D\u202C\u200F\u206D\u206C\u200C\u206E\u206B\u200C\u206B\u206D\u206C\u200E\u206E\u206B\u202B\u200E\u202A\u200B\u200E\u206D\u200C\u206F\u206D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static RemoveAllNegativeStatusEffectAction \u202C\u200C\u206B\u202D\u206F\u206F\u206E\u200C\u200E\u200B\u202C\u200E\u206F\u200B\u206B\u202B\u202A\u200D\u200E\u206E\u202A\u206D\u200D\u200C\u202B\u202C\u206A\u202A\u206E\u200C\u200B\u206E\u200F\u206E\u200C\u200C\u200F\u206A\u206F\u206C\u202E(Unit A_0, float A_1)
			{
				return new RemoveAllNegativeStatusEffectAction(A_0, A_1);
			}

			static Reactor \u206A\u206D\u202E\u206A\u206D\u202C\u200E\u206D\u200E\u202E\u200B\u202B\u202D\u200F\u202A\u200B\u202C\u202A\u200F\u206D\u200E\u202C\u202C\u202A\u206C\u206D\u206A\u206F\u200C\u200C\u200F\u202D\u206E\u206B\u206E\u206F\u206F\u206E\u202B\u200C\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static GameEvent<CardUsingEventArgs> \u200C\u202A\u206C\u200F\u200E\u202C\u206A\u206D\u200F\u200D\u200D\u200B\u202A\u200F\u202D\u200C\u202C\u206A\u200B\u202E\u202C\u206F\u200D\u202D\u206C\u206B\u200B\u206A\u200D\u200F\u206A\u202D\u206A\u202C\u206C\u200F\u206A\u202A\u202E\u206D\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u202D\u202B\u206D\u206C\u206E\u200E\u202B\u206C\u206C\u200F\u206B\u200D\u202D\u206E\u200F\u206E\u202A\u206D\u200B\u202E\u200B\u206C\u206B\u206C\u200D\u202B\u200C\u206F\u200E\u200D\u202E\u202C\u206E\u202A\u202C\u202A\u202D\u206F\u202E\u206C\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			private bool Activated;
		}
	}
}
