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

namespace AyaShameimaru.Cards
{
	public sealed class AyaAnythingisNewsworthySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1467260715);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaAnythingisNewsworthySeDef.\u206A\u206D\u200F\u202A\u200B\u206C\u206C\u202C\u200C\u202E\u206E\u206B\u202E\u200F\u200B\u206C\u206A\u206A\u206C\u206F\u202A\u206F\u206E\u202B\u206F\u206C\u200C\u202E\u206D\u200B\u200F\u206D\u206F\u206E\u200C\u202A\u202B\u206D\u202C\u200E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaAnythingisNewsworthySeDef.\u202D\u206E\u206C\u202B\u206F\u206C\u200C\u206A\u206E\u206F\u206C\u206A\u206C\u206C\u202A\u202A\u206D\u206D\u200C\u200C\u200C\u206C\u200D\u206E\u200E\u206A\u202D\u206B\u200F\u206C\u200E\u206E\u202E\u202C\u206A\u202B\u200D\u206B\u206F\u202D\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(636747713), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaAnythingisNewsworthySeDef.\u200E\u206C\u200F\u206B\u202C\u206D\u200F\u200B\u200F\u202E\u206B\u206D\u202A\u206C\u206A\u202D\u202D\u206A\u206A\u200B\u206C\u200B\u200C\u206D\u206E\u206A\u200F\u200C\u206B\u206B\u202B\u206F\u200F\u200E\u200B\u202E\u200E\u202A\u200D\u202A\u202E(BepinexPlugin.sequenceTable, AyaAnythingisNewsworthySeDef.\u206D\u206B\u200D\u200F\u206C\u206D\u206E\u200B\u202D\u206E\u202B\u206E\u202D\u206F\u202A\u202E\u200C\u200F\u200D\u202C\u200F\u206B\u206C\u206A\u202B\u206D\u206B\u202B\u206E\u206F\u202B\u200B\u206B\u202A\u206C\u206A\u206B\u206F\u200B\u202C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Misfortune, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u206A\u206D\u200F\u202A\u200B\u206C\u206C\u202C\u200C\u202E\u206E\u206B\u202E\u200F\u200B\u206C\u206A\u206A\u206C\u206F\u202A\u206F\u206E\u202B\u206F\u206C\u200C\u202E\u206D\u200B\u200F\u206D\u206F\u206E\u200C\u202A\u202B\u206D\u202C\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202D\u206E\u206C\u202B\u206F\u206C\u200C\u206A\u206E\u206F\u206C\u206A\u206C\u206C\u202A\u202A\u206D\u206D\u200C\u200C\u200C\u206C\u200D\u206E\u200E\u206A\u202D\u206B\u200F\u206C\u200E\u206E\u202E\u202C\u206A\u202B\u200D\u206B\u206F\u202D\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206D\u206B\u200D\u200F\u206C\u206D\u206E\u200B\u202D\u206E\u202B\u206E\u202D\u206F\u202A\u202E\u200C\u200F\u200D\u202C\u200F\u206B\u206C\u206A\u202B\u206D\u206B\u202B\u206E\u206F\u202B\u200B\u206B\u202A\u206C\u206A\u206B\u206F\u200B\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u206C\u200F\u206B\u202C\u206D\u200F\u200B\u200F\u202E\u206B\u206D\u202A\u206C\u206A\u202D\u202D\u206A\u206A\u200B\u206C\u200B\u200C\u206D\u206E\u206A\u200F\u200C\u206B\u206B\u202B\u206F\u200F\u200E\u200B\u202E\u200E\u202A\u200D\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaAnythingisNewsworthySeDef))]
		public sealed class AyaAnythingisNewsworthySe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<CardsEventArgs>(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u200B\u206F\u202A\u202B\u200D\u206A\u200E\u200E\u206C\u202A\u200E\u202E\u200F\u200B\u202C\u200C\u206F\u206D\u206B\u206C\u202E\u200C\u200E\u206B\u206E\u200C\u200B\u202E\u206C\u202D\u202A\u206A\u200C\u206E\u206F\u206D\u200D\u206B\u206A\u206D\u202E(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u202E\u200C\u206A\u206A\u202A\u206F\u202D\u206F\u200B\u202D\u200F\u200E\u206B\u200D\u200D\u206F\u200C\u202B\u200E\u206E\u202E\u206D\u200D\u206A\u206F\u206D\u206C\u202A\u202D\u206F\u206C\u206A\u200C\u202A\u202D\u202C\u206C\u206E\u200E\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToDiscard));
				base.ReactOwnerEvent<CardsEventArgs>(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u206B\u202D\u200C\u202E\u202E\u200B\u206C\u200B\u206D\u200B\u200F\u202B\u202B\u200D\u200E\u206D\u206E\u200B\u200C\u200F\u200C\u200E\u206C\u206B\u202D\u200F\u200C\u202C\u206C\u200D\u200F\u200F\u200B\u200F\u202D\u200C\u200C\u206A\u200E\u200F\u202E(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u202E\u200C\u206A\u206A\u202A\u206F\u202D\u206F\u200B\u202D\u200F\u200E\u206B\u200D\u200D\u206F\u200C\u202B\u200E\u206E\u202E\u206D\u200D\u206A\u206F\u206D\u206C\u202A\u202D\u206F\u206C\u206A\u200C\u202A\u202D\u202C\u206C\u206E\u200E\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToHand));
				for (;;)
				{
					IL_003A:
					int num = 1889521768;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-num2 - (--769556029 - (1832462169 + 784331131))) * -1394987481)) % 4U)
						{
						case 1U:
							base.ReactOwnerEvent<CardsEventArgs>(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u206B\u202A\u202A\u202E\u200F\u202D\u206B\u200B\u200C\u206D\u206B\u200E\u206A\u202C\u206C\u202A\u200C\u206B\u206C\u200B\u202E\u200E\u206E\u200F\u200F\u206F\u200C\u200F\u200F\u200B\u202B\u206E\u202B\u202E\u206B\u206B\u202E\u202E\u200E\u202A\u202E(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u202E\u200C\u206A\u206A\u202A\u206F\u202D\u206F\u200B\u202D\u200F\u200E\u206B\u200D\u200D\u206F\u200C\u202B\u200E\u206E\u202E\u206D\u200D\u206A\u206F\u206D\u206C\u202A\u202D\u206F\u206C\u206A\u200C\u202A\u202D\u202C\u206C\u206E\u200E\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToExile));
							num = (int)((num3 * 2763830995U) ^ 3507834557U);
							continue;
						case 2U:
							goto IL_003A;
						case 3U:
							base.ReactOwnerEvent<CardsAddingToDrawZoneEventArgs>(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u202E\u202B\u206E\u206C\u206A\u200C\u202C\u206F\u200F\u206A\u202C\u200E\u202A\u206D\u202C\u206C\u206D\u202A\u200C\u202D\u202D\u200D\u200C\u206C\u200C\u200B\u202B\u200B\u206E\u206B\u206F\u200C\u202E\u200C\u206C\u206A\u200D\u202A\u202B\u206E\u202E(AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.\u202E\u200C\u206A\u206A\u202A\u206F\u202D\u206F\u200B\u202D\u200F\u200E\u206B\u200D\u200D\u206F\u200C\u202B\u200E\u206E\u202E\u206D\u200D\u206A\u206F\u206D\u206C\u202A\u202D\u206F\u206C\u206A\u200C\u202A\u202D\u202C\u206C\u206E\u200E\u202E\u202E(this)), new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddingToDrawZone));
							num = (int)((num3 * 2424641633U) ^ 1418069464U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardsAddingToDiscard(CardsEventArgs args)
			{
				AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToDiscard>d__1 <OnCardsAddingToDiscard>d__ = new AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToDiscard>d__1(-2);
				<OnCardsAddingToDiscard>d__.<>4__this = this;
				<OnCardsAddingToDiscard>d__.<>3__args = args;
				return <OnCardsAddingToDiscard>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToHand(CardsEventArgs args)
			{
				AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToHand>d__2 <OnCardsAddingToHand>d__ = new AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToHand>d__2(-2);
				<OnCardsAddingToHand>d__.<>4__this = this;
				<OnCardsAddingToHand>d__.<>3__args = args;
				return <OnCardsAddingToHand>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToExile(CardsEventArgs args)
			{
				AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToExile>d__3 <OnCardsAddingToExile>d__ = new AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToExile>d__3(-2);
				<OnCardsAddingToExile>d__.<>4__this = this;
				<OnCardsAddingToExile>d__.<>3__args = args;
				return <OnCardsAddingToExile>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToDrawZone>d__4 <OnCardsAddingToDrawZone>d__ = new AyaAnythingisNewsworthySeDef.AyaAnythingisNewsworthySe.<OnCardsAddingToDrawZone>d__4(-2);
				<OnCardsAddingToDrawZone>d__.<>4__this = this;
				<OnCardsAddingToDrawZone>d__.<>3__args = args;
				return <OnCardsAddingToDrawZone>d__;
			}

			static BattleController \u202E\u200C\u206A\u206A\u202A\u206F\u202D\u206F\u200B\u202D\u200F\u200E\u206B\u200D\u200D\u206F\u200C\u202B\u200E\u206E\u202E\u206D\u200D\u206A\u206F\u206D\u206C\u202A\u202D\u206F\u206C\u206A\u200C\u202A\u202D\u202C\u206C\u206E\u200E\u202E\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardsEventArgs> \u200B\u206F\u202A\u202B\u200D\u206A\u200E\u200E\u206C\u202A\u200E\u202E\u200F\u200B\u202C\u200C\u206F\u206D\u206B\u206C\u202E\u200C\u200E\u206B\u206E\u200C\u200B\u202E\u206C\u202D\u202A\u206A\u200C\u206E\u206F\u206D\u200D\u206B\u206A\u206D\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206B\u202D\u200C\u202E\u202E\u200B\u206C\u200B\u206D\u200B\u200F\u202B\u202B\u200D\u200E\u206D\u206E\u200B\u200C\u200F\u200C\u200E\u206C\u206B\u202D\u200F\u200C\u202C\u206C\u200D\u200F\u200F\u200B\u200F\u202D\u200C\u200C\u206A\u200E\u200F\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToHand;
			}

			static GameEvent<CardsEventArgs> \u206B\u202A\u202A\u202E\u200F\u202D\u206B\u200B\u200C\u206D\u206B\u200E\u206A\u202C\u206C\u202A\u200C\u206B\u206C\u200B\u202E\u200E\u206E\u200F\u200F\u206F\u200C\u200F\u200F\u200B\u202B\u206E\u202B\u202E\u206B\u206B\u202E\u202E\u200E\u202A\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u202E\u202B\u206E\u206C\u206A\u200C\u202C\u206F\u200F\u206A\u202C\u200E\u202A\u206D\u202C\u206C\u206D\u202A\u200C\u202D\u202D\u200D\u200C\u206C\u200C\u200B\u202B\u200B\u206E\u206B\u206F\u200C\u202E\u200C\u206C\u206A\u200D\u202A\u202B\u206E\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDrawZone;
			}
		}
	}
}
