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
	public sealed class AyaArsenalBirdSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-723001062);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaArsenalBirdSeDef.\u200D\u202D\u206F\u200B\u200D\u200C\u202B\u206E\u206A\u200F\u206C\u206F\u206D\u200F\u200D\u206A\u200B\u206A\u200E\u202C\u206E\u200E\u206A\u206D\u202E\u200C\u206C\u202E\u202D\u202E\u206C\u206F\u202B\u206D\u202A\u206D\u202B\u200E\u200C\u202D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaArsenalBirdSeDef.\u202A\u202E\u200C\u206E\u202A\u206A\u202B\u202B\u200B\u206D\u200D\u200B\u200E\u202B\u206E\u202B\u200B\u206B\u200B\u200D\u202A\u200F\u206A\u206A\u200E\u206D\u206B\u206F\u202C\u206C\u200E\u200C\u206D\u200D\u202D\u200F\u200B\u202D\u202A\u206B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-825345965), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaArsenalBirdSeDef.\u202B\u206D\u206E\u202B\u206C\u200D\u200C\u200D\u202E\u202B\u200C\u202D\u200F\u206B\u200E\u206E\u206B\u206B\u200B\u200E\u206B\u202B\u202A\u200E\u200F\u202B\u202D\u206B\u200D\u200D\u206C\u200C\u206B\u206F\u206B\u206B\u200C\u202B\u206E\u202B\u202E(BepinexPlugin.sequenceTable, AyaArsenalBirdSeDef.\u200D\u200E\u200C\u202E\u206E\u200C\u206E\u202C\u206B\u202C\u200E\u200E\u206C\u202B\u200F\u200E\u206B\u200B\u202E\u206C\u200C\u202B\u206D\u200F\u200D\u200E\u202E\u202D\u206B\u200B\u202B\u200D\u206F\u206B\u202A\u202D\u200B\u200E\u200F\u200D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 9, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Keep), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, true, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750));
		}

		static BatchLocalization \u200D\u202D\u206F\u200B\u200D\u200C\u202B\u206E\u206A\u200F\u206C\u206F\u206D\u200F\u200D\u206A\u200B\u206A\u200E\u202C\u206E\u200E\u206A\u206D\u202E\u200C\u206C\u202E\u202D\u202E\u206C\u206F\u202B\u206D\u202A\u206D\u202B\u200E\u200C\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202A\u202E\u200C\u206E\u202A\u206A\u202B\u202B\u200B\u206D\u200D\u200B\u200E\u202B\u206E\u202B\u200B\u206B\u200B\u200D\u202A\u200F\u206A\u206A\u200E\u206D\u206B\u206F\u202C\u206C\u200E\u200C\u206D\u200D\u202D\u200F\u200B\u202D\u202A\u206B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200D\u200E\u200C\u202E\u206E\u200C\u206E\u202C\u206B\u202C\u200E\u200E\u206C\u202B\u200F\u200E\u206B\u200B\u202E\u206C\u200C\u202B\u206D\u200F\u200D\u200E\u202E\u202D\u206B\u200B\u202B\u200D\u206F\u206B\u202A\u202D\u200B\u200E\u200F\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u206D\u206E\u202B\u206C\u200D\u200C\u200D\u202E\u202B\u200C\u202D\u200F\u206B\u200E\u206E\u206B\u206B\u200B\u200E\u206B\u202B\u202A\u200E\u200F\u202B\u202D\u206B\u200D\u200D\u206C\u200C\u206B\u206F\u206B\u206B\u200C\u202B\u206E\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaArsenalBirdSeDef))]
		public sealed class AyaArsenalBirdSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u206C\u202E\u206F\u206B\u200D\u200C\u206F\u200D\u200E\u202B\u202B\u202B\u200E\u206C\u206C\u200B\u202B\u202D\u200C\u206E\u206A\u206C\u200E\u202D\u200B\u200F\u206D\u200D\u202E\u202A\u206B\u206C\u206F\u202B\u200C\u200F\u200F\u202B\u202A\u206F\u202E(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u200E\u206A\u200B\u206F\u202C\u202A\u202D\u202B\u206F\u202B\u206D\u206C\u206E\u200C\u200E\u206D\u206F\u206E\u200C\u202B\u206B\u202E\u200C\u202A\u206B\u202E\u206E\u200B\u202E\u206F\u202B\u206C\u206A\u206C\u206D\u200F\u206D\u200D\u206C\u202A\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
				for (;;)
				{
					IL_001D:
					int num = -57840325;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(1904976559 - ((~num2 + -910228311) ^ (-1959183398 ^ 511252231)))) % 3U)
						{
						case 1U:
							base.ReactOwnerEvent<CardEventArgs>(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u202D\u202C\u206A\u206E\u202A\u200F\u200D\u206D\u206F\u202E\u202E\u206A\u200B\u206E\u202B\u200E\u206E\u202A\u206F\u206E\u202D\u206A\u206A\u206C\u200F\u202C\u200F\u202C\u202E\u202D\u202D\u200D\u200D\u202E\u202A\u202D\u206B\u206E\u202A\u200D\u202E(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u200C\u202A\u200F\u206C\u200E\u202C\u206F\u200D\u200C\u206D\u200C\u206A\u206D\u202A\u200C\u200D\u202B\u202D\u202A\u202E\u202B\u202A\u202C\u200E\u206F\u202E\u200C\u200B\u202C\u200F\u202A\u206F\u206A\u200B\u206F\u206F\u202B\u202D\u202C\u206A\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCard));
							num = (int)((num3 * 59633829U) ^ 3442671654U);
							continue;
						case 2U:
							goto IL_001D;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.ReactOwnerEvent<CardEventArgs>(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u206A\u206F\u202D\u206D\u206A\u206F\u202E\u200E\u206F\u200E\u206F\u200F\u200F\u200D\u206E\u206C\u202C\u202B\u200D\u206F\u200F\u200E\u206D\u202C\u202B\u206C\u202E\u200C\u206B\u202E\u202A\u206E\u202E\u200B\u200F\u202E\u202A\u206C\u202C\u206F\u202E(AyaArsenalBirdSeDef.AyaArsenalBirdSe.\u200C\u202A\u200F\u206C\u200E\u202C\u206F\u200D\u200C\u206D\u200C\u206A\u206D\u202A\u200C\u200D\u202B\u202D\u202A\u202E\u202B\u202A\u202C\u200E\u206F\u202E\u200C\u200B\u202C\u200F\u202A\u206F\u206A\u200B\u206F\u206F\u202B\u202D\u202C\u206A\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCard));
			}

			private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
			{
				AyaArsenalBirdSeDef.AyaArsenalBirdSe.<OnOwnerTurnStarted>d__1 <OnOwnerTurnStarted>d__ = new AyaArsenalBirdSeDef.AyaArsenalBirdSe.<OnOwnerTurnStarted>d__1(-2);
				<OnOwnerTurnStarted>d__.<>4__this = this;
				return <OnOwnerTurnStarted>d__;
			}

			private IEnumerable<BattleAction> OnCard(CardEventArgs args)
			{
				AyaArsenalBirdSeDef.AyaArsenalBirdSe.<OnCard>d__2 <OnCard>d__ = new AyaArsenalBirdSeDef.AyaArsenalBirdSe.<OnCard>d__2(-2);
				<OnCard>d__.<>4__this = this;
				return <OnCard>d__;
			}

			public IEnumerable<BattleAction> TakeEffect()
			{
				AyaArsenalBirdSeDef.AyaArsenalBirdSe.<TakeEffect>d__3 <TakeEffect>d__ = new AyaArsenalBirdSeDef.AyaArsenalBirdSe.<TakeEffect>d__3(-2);
				<TakeEffect>d__.<>4__this = this;
				return <TakeEffect>d__;
			}

			static Unit \u200E\u206A\u200B\u206F\u202C\u202A\u202D\u202B\u206F\u202B\u206D\u206C\u206E\u200C\u200E\u206D\u206F\u206E\u200C\u202B\u206B\u202E\u200C\u202A\u206B\u202E\u206E\u200B\u202E\u206F\u202B\u206C\u206A\u206C\u206D\u200F\u206D\u200D\u206C\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u206C\u202E\u206F\u206B\u200D\u200C\u206F\u200D\u200E\u202B\u202B\u202B\u200E\u206C\u206C\u200B\u202B\u202D\u200C\u206E\u206A\u206C\u200E\u202D\u200B\u200F\u206D\u200D\u202E\u202A\u206B\u206C\u206F\u202B\u200C\u200F\u200F\u202B\u202A\u206F\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static BattleController \u200C\u202A\u200F\u206C\u200E\u202C\u206F\u200D\u200C\u206D\u200C\u206A\u206D\u202A\u200C\u200D\u202B\u202D\u202A\u202E\u202B\u202A\u202C\u200E\u206F\u202E\u200C\u200B\u202C\u200F\u202A\u206F\u206A\u200B\u206F\u206F\u202B\u202D\u202C\u206A\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardEventArgs> \u202D\u202C\u206A\u206E\u202A\u200F\u200D\u206D\u206F\u202E\u202E\u206A\u200B\u206E\u202B\u200E\u206E\u202A\u206F\u206E\u202D\u206A\u206A\u206C\u200F\u202C\u200F\u202C\u202E\u202D\u202D\u200D\u200D\u202E\u202A\u202D\u206B\u206E\u202A\u200D\u202E(BattleController A_0)
			{
				return A_0.CardExiled;
			}

			static GameEvent<CardEventArgs> \u206A\u206F\u202D\u206D\u206A\u206F\u202E\u200E\u206F\u200E\u206F\u200F\u200F\u200D\u206E\u206C\u202C\u202B\u200D\u206F\u200F\u200E\u206D\u202C\u202B\u206C\u202E\u200C\u206B\u202E\u202A\u206E\u202E\u200B\u200F\u202E\u202A\u206C\u202C\u206F\u202E(BattleController A_0)
			{
				return A_0.CardRemoved;
			}
		}
	}
}
