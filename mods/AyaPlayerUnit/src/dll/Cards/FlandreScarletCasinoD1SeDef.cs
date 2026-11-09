using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreScarletCasinoD1SeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(674176292);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreScarletCasinoD1SeDef.\u200B\u200F\u202D\u206F\u200C\u202B\u200D\u200D\u202B\u206C\u200B\u202B\u206C\u206E\u200E\u200F\u206B\u202A\u206E\u206A\u202B\u206D\u200C\u202C\u200C\u202D\u206B\u200E\u200C\u206E\u206F\u200E\u202C\u206C\u202A\u206B\u206B\u206C\u202A\u206A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreScarletCasinoD1SeDef.\u202E\u200E\u202A\u200C\u200E\u200F\u206A\u206A\u202C\u202D\u200B\u202E\u200C\u200F\u200B\u202D\u200C\u200F\u202C\u200C\u206A\u200C\u206E\u200C\u206E\u200B\u206C\u206C\u202E\u206F\u200E\u202C\u200C\u202C\u202C\u200B\u206E\u206A\u206A\u200C\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2086071775), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreScarletCasinoD1SeDef.\u206E\u202A\u206D\u206A\u202C\u202D\u206C\u202A\u202E\u202D\u206C\u202B\u200E\u206F\u206D\u202B\u200D\u206F\u200E\u206C\u200B\u206A\u202A\u206F\u202A\u206E\u200C\u202B\u206B\u200D\u200B\u202E\u202E\u200D\u200F\u200F\u200F\u200F\u200E\u200C\u202E(BepinexPlugin.sequenceTable, FlandreScarletCasinoD1SeDef.\u200F\u200E\u200E\u200B\u202D\u200B\u206D\u206B\u206D\u206E\u200D\u202A\u206A\u200F\u200F\u200D\u206D\u202B\u200F\u206B\u200D\u200F\u200C\u206E\u200E\u200C\u202B\u200B\u200E\u202A\u202D\u202C\u200E\u200C\u200D\u202C\u206A\u206D\u202E\u202D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u200B\u200F\u202D\u206F\u200C\u202B\u200D\u200D\u202B\u206C\u200B\u202B\u206C\u206E\u200E\u200F\u206B\u202A\u206E\u206A\u202B\u206D\u200C\u202C\u200C\u202D\u206B\u200E\u200C\u206E\u206F\u200E\u202C\u206C\u202A\u206B\u206B\u206C\u202A\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202E\u200E\u202A\u200C\u200E\u200F\u206A\u206A\u202C\u202D\u200B\u202E\u200C\u200F\u200B\u202D\u200C\u200F\u202C\u200C\u206A\u200C\u206E\u200C\u206E\u200B\u206C\u206C\u202E\u206F\u200E\u202C\u200C\u202C\u202C\u200B\u206E\u206A\u206A\u200C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200F\u200E\u200E\u200B\u202D\u200B\u206D\u206B\u206D\u206E\u200D\u202A\u206A\u200F\u200F\u200D\u206D\u202B\u200F\u206B\u200D\u200F\u200C\u206E\u200E\u200C\u202B\u200B\u200E\u202A\u202D\u202C\u200E\u200C\u200D\u202C\u206A\u206D\u202E\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206E\u202A\u206D\u206A\u202C\u202D\u206C\u202A\u202E\u202D\u206C\u202B\u200E\u206F\u206D\u202B\u200D\u206F\u200E\u206C\u200B\u206A\u202A\u206F\u202A\u206E\u200C\u202B\u206B\u200D\u200B\u202E\u202E\u200D\u200F\u200F\u200F\u200F\u200E\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreScarletCasinoD1SeDef))]
		public sealed class FlandreScarletCasinoD1Se : StatusEffect
		{
			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206C\u202D\u200B\u206E\u206B\u206A\u202A\u206F\u202E\u200C\u202A\u200F\u206A\u206A\u206D\u206E\u200E\u206E\u206D\u206D\u202A\u206F\u202E\u206C\u206C\u200B\u202E\u206E\u200D\u200F\u206E\u200B\u200D\u202B\u206A\u202C\u202E\u206F\u206B\u200E\u202E(this));
				}
			}

			protected override void OnAdded(Unit unit)
			{
				this.TakeEffect(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206E\u206C\u200F\u202C\u202E\u200D\u206F\u202C\u206B\u202C\u200D\u206A\u202A\u200D\u202A\u202C\u200F\u206F\u200B\u200E\u206A\u200D\u202D\u206B\u202D\u200C\u202D\u206A\u200E\u206F\u206E\u200C\u202E\u206A\u206A\u200E\u206B\u202E\u200D\u206E\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)));
				base.HandleOwnerEvent<CardsEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200E\u202A\u200F\u206D\u202D\u200D\u206E\u206C\u200E\u206A\u206F\u202B\u200C\u206B\u206E\u202C\u202B\u202C\u206A\u202D\u200C\u202A\u206D\u200B\u206A\u200D\u206C\u202E\u202E\u206E\u202A\u200D\u200C\u200E\u200B\u206F\u200C\u200E\u202C\u202B\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
				base.HandleOwnerEvent<CardsEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200B\u200B\u206E\u206B\u202E\u206A\u206B\u202A\u200C\u206B\u200B\u206C\u200F\u206C\u200D\u206C\u200E\u206D\u206B\u206F\u202E\u206B\u202E\u200B\u206E\u200D\u202C\u200B\u202B\u202B\u206C\u206B\u206F\u200C\u202C\u200C\u206F\u206A\u202C\u206B\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
				for (;;)
				{
					IL_004B:
					int num = -21955387;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 ^ (-(274092371 + 1457769887) + (~1332946761 ^ 1007556063)) ^ (-1507521347 ^ (-1080296617 ^ 130281987))) * 919518141 * 1919569787)) % 6U)
						{
						case 0U:
							goto IL_004B;
						case 1U:
							base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202C\u206D\u206B\u206E\u202B\u202E\u200D\u206E\u200D\u206A\u202E\u200E\u200F\u206E\u202B\u200D\u200E\u200F\u206B\u206C\u202E\u202C\u206B\u200E\u200E\u206A\u200D\u200C\u206B\u202A\u206C\u206D\u200B\u202E\u200B\u206C\u202C\u200D\u202B\u202D\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)), new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
							num = (int)((num3 * 2966591979U) ^ 4272716682U);
							continue;
						case 3U:
							base.HandleOwnerEvent<CardTransformEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200C\u202B\u202C\u200E\u206E\u200D\u206B\u200E\u202E\u202A\u202A\u206A\u206F\u200F\u202C\u202C\u206A\u206A\u202E\u206C\u202E\u202D\u202B\u206C\u200F\u200C\u202E\u202B\u206A\u206F\u200B\u202D\u202B\u206F\u200E\u206B\u206C\u200D\u202A\u206E\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransformed));
							num = (int)((num3 * 2047678536U) ^ 2642502716U);
							continue;
						case 4U:
							base.ReactOwnerEvent<UnitEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206F\u200B\u202C\u206A\u202E\u206C\u202D\u206E\u200C\u202C\u202C\u202D\u206A\u206F\u202A\u200E\u202C\u200E\u200F\u200B\u200D\u200F\u202E\u206E\u206B\u206A\u200B\u202D\u206B\u206C\u200C\u200C\u202C\u202B\u202A\u202D\u200D\u202D\u202C\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u202C\u206C\u200F\u200C\u200D\u202D\u206D\u206C\u200E\u202E\u200E\u202E\u200C\u200F\u200B\u206A\u200B\u202A\u206F\u202B\u206D\u202E\u202C\u206C\u202B\u202D\u202A\u206A\u206A\u206C\u202D\u202B\u206C\u200D\u200B\u200E\u200D\u200B\u200D\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnded));
							num = (int)((num3 * 4074907179U) ^ 268152500U);
							continue;
						case 5U:
							base.HandleOwnerEvent<CardsEventArgs>(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202B\u202A\u202C\u206A\u200F\u200B\u200D\u206C\u206D\u202B\u200D\u202B\u206D\u202E\u200D\u206E\u202C\u200C\u200D\u200C\u206B\u206E\u200E\u202B\u200B\u200F\u202D\u206C\u202D\u200E\u200D\u200C\u206C\u200F\u200D\u206A\u200F\u202E\u206D\u206E\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
							num = (int)((num3 * 4208286954U) ^ 2870901059U);
							continue;
						}
						return;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206E\u206C\u200F\u202C\u202E\u200D\u206F\u202C\u206B\u202C\u200D\u206A\u202A\u200D\u202A\u202C\u200F\u206F\u200B\u200E\u206A\u200D\u202D\u206B\u202D\u200C\u202D\u206A\u200E\u206F\u206E\u200C\u202E\u206A\u206A\u200E\u206B\u202E\u200D\u206E\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0066:
						int num = ((!FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u202C\u202D\u206A\u206A\u202E\u200D\u200B\u202E\u200F\u206D\u202E\u200B\u200B\u202B\u202C\u206B\u200B\u206C\u202C\u206F\u206C\u206C\u206D\u200E\u206A\u206D\u200D\u202A\u200B\u206B\u202D\u206C\u206E\u206A\u206B\u206F\u206B\u200B\u202C\u202E(enumerator)) ? 1136996145 : (-250886957));
						for (;;)
						{
							int num2 = num;
							switch ((-(~(num2 * -1602889575)) - -1075515377) % 4)
							{
							case 0:
								num = -250886957;
								continue;
							case 1:
							{
								Card card = enumerator.Current;
								FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206B\u200B\u202B\u202B\u202D\u202A\u200B\u200E\u202A\u202B\u200F\u206F\u206F\u202B\u200D\u206A\u202D\u202D\u202B\u206E\u206D\u206D\u200E\u202C\u206B\u200F\u206A\u206A\u206F\u206E\u202B\u206B\u202B\u200C\u206E\u202C\u200B\u202B\u206C\u202E(card, FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202C\u200D\u202A\u206E\u202D\u200D\u206B\u200C\u202D\u206A\u200C\u202D\u200B\u206F\u202E\u202C\u206B\u202C\u200D\u206A\u202A\u202B\u206F\u202B\u206B\u202A\u200D\u202D\u202C\u200E\u202D\u206A\u206B\u202C\u206B\u206D\u206F\u200C\u206C\u206A\u202E(card) + this.Mana);
								num = -383102428;
								continue;
							}
							case 2:
								goto IL_0066;
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0084:
							int num3 = -2025392241;
							for (;;)
							{
								int num2 = num3;
								uint num4;
								switch ((num4 = (uint)(-(~(num2 * -1602889575)) - -1075515377)) % 3U)
								{
								case 0U:
									goto IL_0084;
								case 1U:
									FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206C\u202D\u206E\u200F\u200D\u200C\u202B\u206D\u202E\u206A\u202D\u202D\u200E\u200D\u202A\u202E\u200E\u200F\u200C\u202D\u200D\u206F\u206F\u206D\u202A\u202E\u200D\u206B\u202E\u206F\u202A\u200D\u206B\u200C\u200F\u206A\u202E\u206C\u200B\u206E\u202E(enumerator);
									num3 = (int)((num4 * 167239487U) ^ 3515365101U);
									continue;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
			}

			private void OnCardsAdded(CardsEventArgs args)
			{
				this.TakeEffect(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200C\u206E\u206A\u202D\u202A\u200E\u200F\u202D\u200C\u202B\u202E\u206A\u202B\u200C\u202A\u202A\u206B\u206F\u202C\u202C\u206B\u200F\u200D\u206D\u200D\u206F\u200C\u200C\u202B\u200B\u206C\u200B\u200C\u202B\u206B\u202C\u206F\u206C\u206B\u206D\u202E(args));
			}

			private void OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				this.TakeEffect(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206C\u200C\u206A\u202B\u202D\u202E\u202B\u202B\u200D\u202C\u206E\u200B\u202D\u206A\u206E\u206C\u206C\u200F\u206B\u200B\u206D\u202C\u200C\u202B\u206A\u202B\u202E\u200D\u202D\u200E\u202B\u202C\u206B\u202D\u202D\u202C\u206F\u202E\u202A\u206E\u202E(args));
			}

			private void OnCardTransformed(CardTransformEventArgs args)
			{
				this.TakeEffect(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206E\u202D\u200C\u206B\u202C\u206B\u200E\u202C\u206A\u202E\u202B\u200F\u200B\u206F\u202B\u202D\u200E\u200C\u206A\u206F\u200D\u200B\u202B\u202D\u202C\u206C\u206C\u206C\u200D\u202D\u206B\u200B\u202B\u206E\u206A\u202A\u202C\u206D\u206B\u202E(args));
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnded(UnitEventArgs args)
			{
				FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.<OnPlayerTurnEnded>d__7 <OnPlayerTurnEnded>d__ = new FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.<OnPlayerTurnEnded>d__7(-2);
				<OnPlayerTurnEnded>d__.<>4__this = this;
				return <OnPlayerTurnEnded>d__;
			}

			private void TakeEffect(Card card)
			{
				this.\u202E\u200F\u200E\u202A\u206E\u206B\u200D\u206B\u202E\u202B\u202B\u206F\u206B\u200E\u200D\u202D\u200B\u200D\u206E\u206C\u200D\u200F\u202E\u202D\u202A\u202A\u200F\u206C\u206D\u200E\u206D\u200B\u206A\u200C\u202A\u206F\u206E\u206A\u200D\u206D\u202E();
				for (;;)
				{
					IL_0006:
					int num = -1446902396;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-802501082 - -(uint)(~num2 ^ ~(-214056365 + 1204944041)))) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206B\u200B\u202B\u202B\u202D\u202A\u200B\u200E\u202A\u202B\u200F\u206F\u206F\u202B\u200D\u206A\u202D\u202D\u202B\u206E\u206D\u206D\u200E\u202C\u206B\u200F\u206A\u206A\u206F\u206E\u202B\u206B\u202B\u200C\u206E\u202C\u200B\u202B\u206C\u202E(card, FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202C\u200D\u202A\u206E\u202D\u200D\u206B\u200C\u202D\u206A\u200C\u202D\u200B\u206F\u202E\u202C\u206B\u202C\u200D\u206A\u202A\u202B\u206F\u202B\u206B\u202A\u200D\u202D\u202C\u200E\u202D\u206A\u206B\u202C\u206B\u206D\u206F\u200C\u206C\u206A\u202E(card) - this.Mana);
							num = (int)((num3 * 78301710U) ^ 450008001U);
							continue;
						}
						return;
					}
				}
			}

			private void TakeEffect(IEnumerable<Card> cards)
			{
				IEnumerator<Card> enumerator = cards.GetEnumerator();
				try
				{
					for (;;)
					{
						IL_006B:
						int num = ((!FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u202C\u202D\u206A\u206A\u202E\u200D\u200B\u202E\u200F\u206D\u202E\u200B\u200B\u202B\u202C\u206B\u200B\u206C\u202C\u206F\u206C\u206C\u206D\u200E\u206A\u206D\u200D\u202A\u200B\u206B\u202D\u206C\u206E\u206A\u206B\u206F\u206B\u200B\u202C\u202E(enumerator)) ? 1141877357 : 295527040);
						for (;;)
						{
							int num2 = num;
							switch ((~num2 + --1664474266 * -728071025) % 4)
							{
							case 1:
							{
								Card card = enumerator.Current;
								if (card == cards.FirstOrDefault<Card>())
								{
									this.\u202E\u200F\u200E\u202A\u206E\u206B\u200D\u206B\u202E\u202B\u202B\u206F\u206B\u200E\u200D\u202D\u200B\u200D\u206E\u206C\u200D\u200F\u202E\u202D\u202A\u202A\u200F\u206C\u206D\u200E\u206D\u200B\u206A\u200C\u202A\u206F\u206E\u206A\u200D\u206D\u202E();
								}
								FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206B\u200B\u202B\u202B\u202D\u202A\u200B\u200E\u202A\u202B\u200F\u206F\u206F\u202B\u200D\u206A\u202D\u202D\u202B\u206E\u206D\u206D\u200E\u202C\u206B\u200F\u206A\u206A\u206F\u206E\u202B\u206B\u202B\u200C\u206E\u202C\u200B\u202B\u206C\u202E(card, FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202C\u200D\u202A\u206E\u202D\u200D\u206B\u200C\u202D\u206A\u200C\u202D\u200B\u206F\u202E\u202C\u206B\u202C\u200D\u206A\u202A\u202B\u206F\u202B\u206B\u202A\u200D\u202D\u202C\u200E\u202D\u206A\u206B\u202C\u206B\u206D\u206F\u200C\u206C\u206A\u202E(card) - this.Mana);
								num = 624073378;
								continue;
							}
							case 2:
								num = 295527040;
								continue;
							case 3:
								goto IL_006B;
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0089:
							int num3 = 848961366;
							for (;;)
							{
								int num2 = num3;
								uint num4;
								switch ((num4 = (uint)(~num2 + --1664474266 * -728071025)) % 3U)
								{
								case 1U:
									FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206C\u202D\u206E\u200F\u200D\u200C\u202B\u206D\u202E\u206A\u202D\u202D\u200E\u200D\u202A\u202E\u200E\u200F\u200C\u202D\u200D\u206F\u206F\u206D\u202A\u202E\u200D\u206B\u202E\u206F\u202A\u200D\u206B\u200C\u200F\u206A\u202E\u206C\u200B\u206E\u202E(enumerator);
									num3 = (int)((num4 * 1574732087U) ^ 1220100330U);
									continue;
								case 2U:
									goto IL_0089;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
			}

			public override bool Stack(StatusEffect other)
			{
				bool flag = this.\u202C\u200F\u200C\u206F\u202C\u206A\u206C\u206E\u206E\u206F\u200B\u200F\u206F\u202A\u202B\u206F\u200E\u202D\u206C\u202A\u206D\u202C\u206D\u202A\u202E\u206A\u202B\u206E\u202D\u206A\u206B\u206F\u202C\u206C\u206C\u206E\u206A\u202B\u200E\u206E\u202E(other);
				if (flag)
				{
					IEnumerable<Card> enumerable;
					for (;;)
					{
						IL_000E:
						int num = -1063769103;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((num2 + (-(-138585124 ^ 2136547951) ^ ((2064976921 + 1169936453) * 371170373)) - -1246709779) ^ (1929589351 + 972245078))) % 3U)
							{
							case 0U:
								goto IL_000E;
							case 2U:
								enumerable = FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206E\u206C\u200F\u202C\u202E\u200D\u206F\u202C\u206B\u202C\u200D\u206A\u202A\u200D\u202A\u202C\u200F\u206F\u200B\u200E\u206A\u200D\u202D\u206B\u202D\u200C\u202D\u206A\u200E\u206F\u206E\u200C\u202E\u206A\u206A\u200E\u206B\u202E\u200D\u206E\u202E(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(this));
								num = (int)((num3 * 1044986555U) ^ 2297016519U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					IEnumerator<Card> enumerator = enumerable.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0115:
							int num4 = (FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206F\u202C\u202D\u206A\u206A\u202E\u200D\u200B\u202E\u200F\u206D\u202E\u200B\u200B\u202B\u202C\u206B\u200B\u206C\u202C\u206F\u206C\u206C\u206D\u200E\u206A\u206D\u200D\u202A\u200B\u206B\u202D\u206C\u206E\u206A\u206B\u206F\u206B\u200B\u202C\u202E(enumerator) ? (-306560735) : (-958147406));
							for (;;)
							{
								int num2 = num4;
								switch (((num2 + (-(-138585124 ^ 2136547951) ^ ((2064976921 + 1169936453) * 371170373)) - -1246709779) ^ (1929589351 + 972245078)) % 4)
								{
								case 0:
									num4 = -306560735;
									continue;
								case 2:
								{
									Card card = enumerator.Current;
									if (card == enumerable.FirstOrDefault<Card>())
									{
										this.\u202E\u200F\u200E\u202A\u206E\u206B\u200D\u206B\u202E\u202B\u202B\u206F\u206B\u200E\u200D\u202D\u200B\u200D\u206E\u206C\u200D\u200F\u202E\u202D\u202A\u202A\u200F\u206C\u206D\u200E\u206D\u200B\u206A\u200C\u202A\u206F\u206E\u206A\u200D\u206D\u202E();
									}
									FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u200D\u206B\u200B\u202B\u202B\u202D\u202A\u200B\u200E\u202A\u202B\u200F\u206F\u206F\u202B\u200D\u206A\u202D\u202D\u202B\u206E\u206D\u206D\u200E\u202C\u206B\u200F\u206A\u206A\u206F\u206E\u202B\u206B\u202B\u200C\u206E\u202C\u200B\u202B\u206C\u202E(card, FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202C\u200D\u202A\u206E\u202D\u200D\u206B\u200C\u202D\u206A\u200C\u202D\u200B\u206F\u202E\u202C\u206B\u202C\u200D\u206A\u202A\u202B\u206F\u202B\u206B\u202A\u200D\u202D\u202C\u200E\u202D\u206A\u206B\u202C\u206B\u206D\u206F\u200C\u206C\u206A\u202E(card) - ManaGroup.Anys(FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u202A\u202D\u206D\u200D\u202D\u200F\u206B\u200B\u202A\u202E\u200C\u206E\u200F\u206F\u202B\u202A\u206D\u206C\u202D\u206D\u206F\u206E\u206C\u202C\u200E\u200D\u202D\u202C\u202A\u202E\u206F\u206E\u206E\u206D\u206F\u206C\u200C\u206D\u206D\u206F\u202E(other)));
									num4 = -17988968;
									continue;
								}
								case 3:
									goto IL_0115;
								}
								goto Block_4;
							}
						}
						Block_4:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0136:
								int num5 = -953232334;
								for (;;)
								{
									int num2 = num5;
									uint num3;
									switch ((num3 = (uint)((num2 + (-(-138585124 ^ 2136547951) ^ ((2064976921 + 1169936453) * 371170373)) - -1246709779) ^ (1929589351 + 972245078))) % 3U)
									{
									case 1U:
										FlandreScarletCasinoD1SeDef.FlandreScarletCasinoD1Se.\u206C\u202D\u206E\u200F\u200D\u200C\u202B\u206D\u202E\u206A\u202D\u202D\u200E\u200D\u202A\u202E\u200E\u200F\u200C\u202D\u200D\u206F\u206F\u206D\u202A\u202E\u200D\u206B\u202E\u206F\u202A\u200D\u206B\u200C\u200F\u206A\u202E\u206C\u200B\u206E\u202E(enumerator);
										num5 = (int)((num3 * 1979428255U) ^ 399016679U);
										continue;
									case 2U:
										goto IL_0136;
									}
									goto Block_8;
								}
							}
							Block_8:;
						}
					}
				}
				return flag;
			}

			static int \u206C\u202D\u200B\u206E\u206B\u206A\u202A\u206F\u202E\u200C\u202A\u200F\u206A\u206A\u206D\u206E\u200E\u206E\u206D\u206D\u202A\u206F\u202E\u206C\u206C\u200B\u202E\u206E\u200D\u200F\u206E\u200B\u200D\u202B\u206A\u202C\u202E\u206F\u206B\u200E\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static BattleController \u206F\u206F\u202B\u206E\u206F\u202B\u200E\u202D\u200E\u206F\u200C\u200F\u200F\u206B\u206A\u206A\u206E\u200E\u206F\u206C\u200B\u206C\u206A\u206E\u202B\u200F\u206B\u206B\u206E\u202D\u200D\u206E\u206A\u202A\u202A\u202A\u202D\u200B\u206F\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Card> \u206E\u206C\u200F\u202C\u202E\u200D\u206F\u202C\u206B\u202C\u200D\u206A\u202A\u200D\u202A\u202C\u200F\u206F\u200B\u200E\u206A\u200D\u202D\u206B\u202D\u200C\u202D\u206A\u200E\u206F\u206E\u200C\u202E\u206A\u206A\u200E\u206B\u202E\u200D\u206E\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static GameEvent<CardsEventArgs> \u200E\u202A\u200F\u206D\u202D\u200D\u206E\u206C\u200E\u206A\u206F\u202B\u200C\u206B\u206E\u202C\u202B\u202C\u206A\u202D\u200C\u202A\u206D\u200B\u206A\u200D\u206C\u202E\u202E\u206E\u202A\u200D\u200C\u200E\u200B\u206F\u200C\u200E\u202C\u202B\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u200B\u200B\u206E\u206B\u202E\u206A\u206B\u202A\u200C\u206B\u200B\u206C\u200F\u206C\u200D\u206C\u200E\u206D\u206B\u206F\u202E\u206B\u202E\u200B\u206E\u200D\u202C\u200B\u202B\u202B\u206C\u206B\u206F\u200C\u202C\u200C\u206F\u206A\u202C\u206B\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u202B\u202A\u202C\u206A\u200F\u200B\u200D\u206C\u206D\u202B\u200D\u202B\u206D\u202E\u200D\u206E\u202C\u200C\u200D\u200C\u206B\u206E\u200E\u202B\u200B\u200F\u202D\u206C\u202D\u200E\u200D\u200C\u206C\u200F\u200D\u206A\u200F\u202E\u206D\u206E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u202C\u206D\u206B\u206E\u202B\u202E\u200D\u206E\u200D\u206A\u202E\u200E\u200F\u206E\u202B\u200D\u200E\u200F\u206B\u206C\u202E\u202C\u206B\u200E\u200E\u206A\u200D\u200C\u206B\u202A\u206C\u206D\u200B\u202E\u200B\u206C\u202C\u200D\u202B\u202D\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static GameEvent<CardTransformEventArgs> \u200C\u202B\u202C\u200E\u206E\u200D\u206B\u200E\u202E\u202A\u202A\u206A\u206F\u200F\u202C\u202C\u206A\u206A\u202E\u206C\u202E\u202D\u202B\u206C\u200F\u200C\u202E\u202B\u206A\u206F\u200B\u202D\u202B\u206F\u200E\u206B\u206C\u200D\u202A\u206E\u202E(BattleController A_0)
			{
				return A_0.CardTransformed;
			}

			static PlayerUnit \u206F\u202C\u206C\u200F\u200C\u200D\u202D\u206D\u206C\u200E\u202E\u200E\u202E\u200C\u200F\u200B\u206A\u200B\u202A\u206F\u202B\u206D\u202E\u202C\u206C\u202B\u202D\u202A\u206A\u206A\u206C\u202D\u202B\u206C\u200D\u200B\u200E\u200D\u200B\u200D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u200D\u206F\u200B\u202C\u206A\u202E\u206C\u202D\u206E\u200C\u202C\u202C\u202D\u206A\u206F\u202A\u200E\u202C\u200E\u200F\u200B\u200D\u200F\u202E\u206E\u206B\u206A\u200B\u202D\u206B\u206C\u200C\u200C\u202C\u202B\u202A\u202D\u200D\u202D\u202C\u202E(Unit A_0)
			{
				return A_0.TurnEnded;
			}

			static ManaGroup \u202C\u200D\u202A\u206E\u202D\u200D\u206B\u200C\u202D\u206A\u200C\u202D\u200B\u206F\u202E\u202C\u206B\u202C\u200D\u206A\u202A\u202B\u206F\u202B\u206B\u202A\u200D\u202D\u202C\u200E\u202D\u206A\u206B\u202C\u206B\u206D\u206F\u200C\u206C\u206A\u202E(Card A_0)
			{
				return A_0.AuraCost;
			}

			static void \u200D\u206B\u200B\u202B\u202B\u202D\u202A\u200B\u200E\u202A\u202B\u200F\u206F\u206F\u202B\u200D\u206A\u202D\u202D\u202B\u206E\u206D\u206D\u200E\u202C\u206B\u200F\u206A\u206A\u206F\u206E\u202B\u206B\u202B\u200C\u206E\u202C\u200B\u202B\u206C\u202E(Card A_0, ManaGroup A_1)
			{
				A_0.AuraCost = A_1;
			}

			static bool \u206F\u202C\u202D\u206A\u206A\u202E\u200D\u200B\u202E\u200F\u206D\u202E\u200B\u200B\u202B\u202C\u206B\u200B\u206C\u202C\u206F\u206C\u206C\u206D\u200E\u206A\u206D\u200D\u202A\u200B\u206B\u202D\u206C\u206E\u206A\u206B\u206F\u206B\u200B\u202C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206C\u202D\u206E\u200F\u200D\u200C\u202B\u206D\u202E\u206A\u202D\u202D\u200E\u200D\u202A\u202E\u200E\u200F\u200C\u202D\u200D\u206F\u206F\u206D\u202A\u202E\u200D\u206B\u202E\u206F\u202A\u200D\u206B\u200C\u200F\u206A\u202E\u206C\u200B\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static Card[] \u200C\u206E\u206A\u202D\u202A\u200E\u200F\u202D\u200C\u202B\u202E\u206A\u202B\u200C\u202A\u202A\u206B\u206F\u202C\u202C\u206B\u200F\u200D\u206D\u200D\u206F\u200C\u200C\u202B\u200B\u206C\u200B\u200C\u202B\u206B\u202C\u206F\u206C\u206B\u206D\u202E(CardsEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card[] \u206C\u200C\u206A\u202B\u202D\u202E\u202B\u202B\u200D\u202C\u206E\u200B\u202D\u206A\u206E\u206C\u206C\u200F\u206B\u200B\u206D\u202C\u200C\u202B\u206A\u202B\u202E\u200D\u202D\u200E\u202B\u202C\u206B\u202D\u202D\u202C\u206F\u202E\u202A\u206E\u202E(CardsAddingToDrawZoneEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card \u200D\u206E\u202D\u200C\u206B\u202C\u206B\u200E\u202C\u206A\u202E\u202B\u200F\u200B\u206F\u202B\u202D\u200E\u200C\u206A\u206F\u200D\u200B\u202B\u202D\u202C\u206C\u206C\u206C\u200D\u202D\u206B\u200B\u202B\u206E\u206A\u202A\u202C\u206D\u206B\u202E(CardTransformEventArgs A_0)
			{
				return A_0.DestinationCard;
			}

			void \u202E\u200F\u200E\u202A\u206E\u206B\u200D\u206B\u202E\u202B\u202B\u206F\u206B\u200E\u200D\u202D\u200B\u200D\u206E\u206C\u200D\u200F\u202E\u202D\u202A\u202A\u200F\u206C\u206D\u200E\u206D\u200B\u206A\u200C\u202A\u206F\u206E\u206A\u200D\u206D\u202E()
			{
				base.NotifyActivating();
			}

			bool \u202C\u200F\u200C\u206F\u202C\u206A\u206C\u206E\u206E\u206F\u200B\u200F\u206F\u202A\u202B\u206F\u200E\u202D\u206C\u202A\u206D\u202C\u206D\u202A\u202E\u206A\u202B\u206E\u202D\u206A\u206B\u206F\u202C\u206C\u206C\u206E\u206A\u202B\u200E\u206E\u202E(StatusEffect A_1)
			{
				return base.Stack(A_1);
			}

			static int \u202A\u202D\u206D\u200D\u202D\u200F\u206B\u200B\u202A\u202E\u200C\u206E\u200F\u206F\u202B\u202A\u206D\u206C\u202D\u206D\u206F\u206E\u206C\u202C\u200E\u200D\u202D\u202C\u202A\u202E\u206F\u206E\u206E\u206D\u206F\u206C\u200C\u206D\u206D\u206F\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}
		}
	}
}
