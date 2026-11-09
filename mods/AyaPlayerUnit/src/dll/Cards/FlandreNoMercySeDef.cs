using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Reimu;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreNoMercySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-29421603);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreNoMercySeDef.\u202E\u206A\u202C\u206C\u202E\u200B\u200B\u200B\u200B\u202C\u200D\u206B\u200E\u206D\u200F\u206F\u200F\u200D\u200E\u202E\u202C\u206D\u206A\u200B\u202C\u202C\u202E\u206F\u206E\u200E\u206D\u206C\u206D\u202D\u202B\u200E\u200F\u202A\u206F\u202A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreNoMercySeDef.\u202E\u200C\u200C\u200B\u206E\u206F\u202D\u206C\u200D\u202E\u200B\u200F\u202E\u200E\u200F\u206F\u202D\u206F\u200E\u200E\u206C\u202C\u206D\u200F\u200F\u202C\u200F\u200D\u206E\u206A\u202B\u206D\u206E\u200E\u200B\u200D\u200F\u206D\u200B\u200E\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(800172773), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreNoMercySeDef.\u206E\u206E\u202B\u206F\u200B\u206B\u206D\u206E\u202E\u202A\u202D\u200D\u200F\u206E\u202D\u200F\u206A\u202E\u202B\u206E\u200D\u202B\u202E\u200D\u202D\u206A\u202A\u202D\u202A\u202D\u206B\u200E\u202E\u206F\u202C\u202A\u200C\u206B\u202D\u202E(BepinexPlugin.sequenceTable, FlandreNoMercySeDef.\u206C\u206C\u202B\u202E\u206E\u206F\u202C\u206C\u202D\u206B\u206B\u200B\u200B\u202B\u200F\u200C\u200C\u202D\u206B\u202A\u202B\u206D\u202C\u206D\u200B\u200F\u200F\u202C\u206D\u206B\u200E\u200B\u200D\u206D\u206A\u202A\u202D\u202E\u202E\u200C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u202E\u206A\u202C\u206C\u202E\u200B\u200B\u200B\u200B\u202C\u200D\u206B\u200E\u206D\u200F\u206F\u200F\u200D\u200E\u202E\u202C\u206D\u206A\u200B\u202C\u202C\u202E\u206F\u206E\u200E\u206D\u206C\u206D\u202D\u202B\u200E\u200F\u202A\u206F\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202E\u200C\u200C\u200B\u206E\u206F\u202D\u206C\u200D\u202E\u200B\u200F\u202E\u200E\u200F\u206F\u202D\u206F\u200E\u200E\u206C\u202C\u206D\u200F\u200F\u202C\u200F\u200D\u206E\u206A\u202B\u206D\u206E\u200E\u200B\u200D\u200F\u206D\u200B\u200E\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206C\u206C\u202B\u202E\u206E\u206F\u202C\u206C\u202D\u206B\u206B\u200B\u200B\u202B\u200F\u200C\u200C\u202D\u206B\u202A\u202B\u206D\u202C\u206D\u200B\u200F\u200F\u202C\u206D\u206B\u200E\u200B\u200D\u206D\u206A\u202A\u202D\u202E\u202E\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206E\u206E\u202B\u206F\u200B\u206B\u206D\u206E\u202E\u202A\u202D\u200D\u200F\u206E\u202D\u200F\u206A\u202E\u202B\u206E\u200D\u202B\u202E\u200D\u202D\u206A\u202A\u202D\u202A\u202D\u206B\u200E\u202E\u206F\u202C\u202A\u200C\u206B\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreNoMercySeDef))]
		public sealed class FlandreNoMercySe : StatusEffect
		{
			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(0);
				}
			}

			protected override void OnAdded(Unit unit)
			{
				this.SetCost(FlandreNoMercySeDef.FlandreNoMercySe.\u200B\u202C\u200D\u200D\u202B\u206D\u200E\u206B\u206F\u200B\u200F\u202D\u200D\u206B\u206A\u200B\u206C\u200B\u200B\u202C\u206E\u202B\u206C\u200E\u206F\u200B\u202C\u206F\u200E\u200C\u206C\u206E\u202E\u202B\u200B\u206A\u202E\u200C\u200E\u206F\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)));
				base.HandleOwnerEvent<CardsEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u206E\u202B\u202E\u200D\u202B\u200C\u200E\u200B\u200F\u206C\u202E\u206B\u200C\u206C\u206E\u202A\u206E\u200E\u200F\u202C\u206D\u202A\u200E\u206C\u206C\u206E\u206F\u200F\u206C\u206F\u206D\u200B\u200B\u206F\u206A\u206A\u202B\u202B\u206A\u202B\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
				base.HandleOwnerEvent<CardsEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u206E\u206F\u206C\u206B\u200D\u206D\u200C\u200D\u206A\u206A\u200B\u200D\u206C\u206B\u200B\u206B\u202E\u206A\u206F\u206C\u202C\u206A\u202C\u206C\u202D\u206B\u202D\u206D\u202E\u206A\u200E\u202A\u202B\u206A\u206D\u206B\u202D\u206F\u206C\u206B\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
				base.HandleOwnerEvent<CardsEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u202C\u206B\u202A\u200E\u202C\u200F\u200F\u202B\u202C\u202C\u200D\u206C\u206E\u206D\u200E\u200C\u206E\u206A\u202D\u200C\u206E\u200D\u202A\u206E\u206E\u200E\u202D\u206B\u206D\u202A\u206A\u202D\u206E\u206F\u206A\u202B\u202C\u202B\u202D\u206A\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnCardsAdded));
				for (;;)
				{
					IL_0068:
					int num = 575002043;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)((num2 ^ (-1326464903 * 538492234 + ~(-1309688278 * 245502293))) - (-1778344041 * 1522519111 - --275688643) - (1325324286 ^ -1023026455)))) % 4U)
						{
						case 1U:
							base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u206B\u200C\u206D\u206B\u206F\u206B\u206A\u206C\u202A\u206B\u206C\u206F\u206D\u202E\u202C\u206D\u202D\u200E\u200D\u206C\u202C\u206E\u202B\u206D\u200C\u200D\u200B\u200B\u202C\u200F\u202E\u206F\u206A\u202C\u206B\u206E\u206C\u202D\u200C\u200F\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)), new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
							num = (int)((num3 * 1345707176U) ^ 815587049U);
							continue;
						case 2U:
							goto IL_0068;
						case 3U:
							base.HandleOwnerEvent<StatusEffectEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u202B\u202E\u202A\u206B\u202E\u206C\u206B\u200D\u202C\u206D\u202B\u200F\u206D\u206C\u200D\u206D\u206A\u202E\u202E\u202E\u206E\u206F\u202C\u200F\u206F\u206F\u206F\u200D\u200F\u202B\u206D\u202A\u202A\u200D\u206F\u202B\u206E\u202C\u202A\u202E\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u202C\u200B\u206B\u200C\u202A\u200E\u200D\u202B\u206B\u206E\u200B\u206A\u202D\u200E\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200E\u206F\u202B\u202E\u202E\u206C\u202B\u200B\u206C\u206C\u206F\u206A\u200E\u200F\u200E\u200D\u206F\u206A\u206B\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this))), new GameEventHandler<StatusEffectEventArgs>(this.OnPlayerStatusEffectRemoved));
							num = (int)((num3 * 2252494599U) ^ 1439993811U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.ReactOwnerEvent<CardUsingEventArgs>(FlandreNoMercySeDef.FlandreNoMercySe.\u206B\u202C\u200F\u206F\u202E\u202D\u206D\u206D\u206E\u200D\u206F\u202B\u200B\u200E\u200D\u206F\u206B\u206C\u202A\u206E\u200C\u200C\u200F\u206D\u206D\u202E\u200F\u200C\u202E\u206B\u200B\u206F\u202A\u206C\u200B\u200B\u206F\u206B\u206C\u202C\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = FlandreNoMercySeDef.FlandreNoMercySe.\u200B\u202C\u200D\u200D\u202B\u206D\u200E\u206B\u206F\u200B\u200F\u202D\u200D\u206B\u206A\u200B\u206C\u200B\u200B\u202C\u206E\u202B\u206C\u200E\u206F\u200B\u202C\u206F\u200E\u200C\u206C\u206E\u202E\u202B\u200B\u206A\u202E\u200C\u200E\u206F\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_008B:
						int num = ((!FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u206E\u200E\u202B\u200F\u202E\u200E\u206F\u202C\u206C\u202C\u200C\u206F\u206F\u202E\u202B\u202D\u200F\u200C\u200E\u202A\u206D\u202C\u206B\u202E\u206B\u200F\u200D\u200C\u202C\u206E\u200F\u200E\u202D\u206E\u206C\u206D\u202E\u206D\u200E\u202E(enumerator)) ? 100420283 : 1080167201);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-1250341893 - ~-618496686 - ~num2 - -263651042) ^ -998940451)) % 5U)
							{
							case 0U:
							{
								Card card;
								FlandreNoMercySeDef.FlandreNoMercySe.\u202C\u206C\u202E\u206A\u200C\u206C\u202D\u206E\u200E\u200B\u200D\u202A\u202A\u200C\u202C\u206A\u200E\u200B\u200B\u200F\u206F\u200E\u200D\u202D\u200F\u200F\u206D\u202E\u200B\u202E\u200E\u200B\u200C\u202A\u206B\u206D\u200E\u202A\u202C\u206A\u202E(card, false);
								num = (int)((num3 * 638976428U) ^ 3064752704U);
								continue;
							}
							case 1U:
							{
								Card card = enumerator.Current;
								num = ((FlandreNoMercySeDef.FlandreNoMercySe.\u200D\u202B\u206C\u202E\u202E\u202B\u200F\u202A\u200E\u200E\u202D\u202E\u200F\u206B\u206B\u200D\u200D\u200D\u206C\u202B\u202B\u206F\u200D\u202A\u202E\u200C\u200F\u202E\u202B\u206F\u206B\u202E\u202A\u200F\u202A\u206D\u206A\u206C\u206F\u200D\u202E(card) == CardType.Attack) ? 939722893 : 1468305348);
								continue;
							}
							case 2U:
								num = 1080167201;
								continue;
							case 3U:
								goto IL_008B;
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
							IL_00AC:
							int num4 = 770753241;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)((-1250341893 - ~-618496686 - ~num2 - -263651042) ^ -998940451)) % 3U)
								{
								case 1U:
									FlandreNoMercySeDef.FlandreNoMercySe.\u200B\u200D\u200E\u200F\u206F\u202B\u200C\u202C\u200D\u206D\u202B\u202E\u200B\u206F\u200E\u200F\u200D\u206B\u202A\u200E\u202E\u200D\u202B\u200E\u206C\u200D\u200E\u206E\u202D\u202A\u200E\u206F\u206C\u202D\u200F\u206C\u202E\u200E\u202A\u206D\u202E(enumerator);
									num4 = (int)((num3 * 236073633U) ^ 1063429458U);
									continue;
								case 2U:
									goto IL_00AC;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
			}

			private void OnCardsAdded(CardsEventArgs args)
			{
				this.SetCost(FlandreNoMercySeDef.FlandreNoMercySe.\u202D\u200E\u206D\u202A\u206E\u206C\u202B\u200B\u202E\u202E\u206A\u206D\u202C\u200E\u202A\u202B\u202E\u206E\u200E\u206A\u202C\u206B\u206A\u202B\u200B\u206A\u202C\u202D\u206E\u202C\u206E\u206C\u206D\u200D\u202B\u200E\u200D\u202E\u206A\u200D\u202E(args));
			}

			private void OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				this.SetCost(FlandreNoMercySeDef.FlandreNoMercySe.\u202C\u200E\u206A\u202C\u200C\u206A\u202B\u206E\u200D\u206B\u206D\u200F\u202D\u200D\u202D\u200B\u206F\u200E\u206B\u200C\u202E\u206F\u202B\u206C\u202A\u206B\u206D\u200F\u206F\u202B\u206F\u202B\u206A\u202B\u200C\u200E\u202D\u206F\u200C\u206F\u202E(args));
			}

			private void OnPlayerStatusEffectRemoved(StatusEffectEventArgs args)
			{
				if (FlandreNoMercySeDef.FlandreNoMercySe.\u206B\u206C\u206A\u206A\u200E\u200C\u202C\u202B\u200E\u200C\u202D\u200D\u202E\u206B\u200F\u200E\u202D\u206A\u202C\u202C\u202A\u206E\u200F\u202E\u202C\u202A\u206B\u202D\u206F\u206E\u206B\u206D\u206B\u202B\u206C\u200E\u202B\u200E\u202C\u202C\u202E(args) is ReimuFreeAttackSe)
				{
					for (;;)
					{
						IL_000D:
						int num = -495445082;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((((num2 - ((-2106237484 ^ --867570154) - (-1051053670 ^ ~-1810649165))) * 1355319111) ^ --2020146637) - 185381493)) % 3U)
							{
							case 0U:
								goto IL_000D;
							case 1U:
								this.SetCost(FlandreNoMercySeDef.FlandreNoMercySe.\u200B\u202C\u200D\u200D\u202B\u206D\u200E\u206B\u206F\u200B\u200F\u202D\u200D\u206B\u206A\u200B\u206C\u200B\u200B\u202C\u206E\u202B\u206C\u200E\u206F\u200B\u202C\u206F\u200E\u200C\u206C\u206E\u202E\u202B\u200B\u206A\u202E\u200C\u200E\u206F\u202E(FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(this)));
								num = (int)((num3 * 1241366663U) ^ 3986635350U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void SetCost(IEnumerable<Card> cards)
			{
				IEnumerator<Card> enumerator = cards.GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0090:
						int num = ((!FlandreNoMercySeDef.FlandreNoMercySe.\u206D\u206E\u200E\u202B\u200F\u202E\u200E\u206F\u202C\u206C\u202C\u200C\u206F\u206F\u202E\u202B\u202D\u200F\u200C\u200E\u202A\u206D\u202C\u206B\u202E\u206B\u200F\u200D\u200C\u202C\u206E\u200F\u200E\u202D\u206E\u206C\u206D\u202E\u206D\u200E\u202E(enumerator)) ? 2063016517 : (-775328832));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)((num2 * -1316457205 * -1123883449) ^ ~260772483))) % 6U)
							{
							case 1U:
							{
								Card card;
								num = (int)(((FlandreNoMercySeDef.FlandreNoMercySe.\u200D\u202B\u206C\u202E\u202E\u202B\u200F\u202A\u200E\u200E\u202D\u202E\u200F\u206B\u206B\u200D\u200D\u200D\u206C\u202B\u202B\u206F\u200D\u202A\u202E\u200C\u200F\u202E\u202B\u206F\u206B\u202E\u202A\u200F\u202A\u206D\u206A\u206C\u206F\u200D\u202E(card) != CardType.Attack) ? 3737957061U : 713444755U) ^ (num3 * 2179090238U));
								continue;
							}
							case 2U:
							{
								Card card;
								FlandreNoMercySeDef.FlandreNoMercySe.\u202C\u206C\u202E\u206A\u200C\u206C\u202D\u206E\u200E\u200B\u200D\u202A\u202A\u200C\u202C\u206A\u200E\u200B\u200B\u200F\u206F\u200E\u200D\u202D\u200F\u200F\u206D\u202E\u200B\u202E\u200E\u200B\u200C\u202A\u206B\u206D\u200E\u202A\u202C\u206A\u202E(card, true);
								num = (int)((num3 * 4285298007U) ^ 1041964853U);
								continue;
							}
							case 3U:
							{
								Card card = enumerator.Current;
								num = -758227460;
								continue;
							}
							case 4U:
								goto IL_0090;
							case 5U:
								num = -775328832;
								continue;
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
							IL_00B1:
							int num4 = -179977201;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~(uint)((num2 * -1316457205 * -1123883449) ^ ~260772483))) % 3U)
								{
								case 0U:
									goto IL_00B1;
								case 1U:
									FlandreNoMercySeDef.FlandreNoMercySe.\u200B\u200D\u200E\u200F\u206F\u202B\u200C\u202C\u200D\u206D\u202B\u202E\u200B\u206F\u200E\u200F\u200D\u206B\u202A\u200E\u202E\u200D\u202B\u200E\u206C\u200D\u200E\u206E\u202D\u202A\u200E\u206F\u206C\u202D\u200F\u206C\u202E\u200E\u202A\u206D\u202E(enumerator);
									num4 = (int)((num3 * 613509069U) ^ 3219977288U);
									continue;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreNoMercySeDef.FlandreNoMercySe.<OnCardUsed>d__8 <OnCardUsed>d__ = new FlandreNoMercySeDef.FlandreNoMercySe.<OnCardUsed>d__8(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			static BattleController \u206D\u200E\u206E\u202B\u200D\u206D\u202C\u200B\u206E\u206F\u202B\u206F\u202B\u206B\u202B\u206A\u200D\u200E\u200F\u202A\u200B\u200D\u206D\u202A\u206C\u202D\u206D\u206D\u206B\u202E\u202E\u200E\u200F\u200C\u202C\u206C\u200E\u200B\u202B\u202B\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Card> \u200B\u202C\u200D\u200D\u202B\u206D\u200E\u206B\u206F\u200B\u200F\u202D\u200D\u206B\u206A\u200B\u206C\u200B\u200B\u202C\u206E\u202B\u206C\u200E\u206F\u200B\u202C\u206F\u200E\u200C\u206C\u206E\u202E\u202B\u200B\u206A\u202E\u200C\u200E\u206F\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static GameEvent<CardsEventArgs> \u206E\u202B\u202E\u200D\u202B\u200C\u200E\u200B\u200F\u206C\u202E\u206B\u200C\u206C\u206E\u202A\u206E\u200E\u200F\u202C\u206D\u202A\u200E\u206C\u206C\u206E\u206F\u200F\u206C\u206F\u206D\u200B\u200B\u206F\u206A\u206A\u202B\u202B\u206A\u202B\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206E\u206F\u206C\u206B\u200D\u206D\u200C\u200D\u206A\u206A\u200B\u200D\u206C\u206B\u200B\u206B\u202E\u206A\u206F\u206C\u202C\u206A\u202C\u206C\u202D\u206B\u202D\u206D\u202E\u206A\u200E\u202A\u202B\u206A\u206D\u206B\u202D\u206F\u206C\u206B\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u202C\u206B\u202A\u200E\u202C\u200F\u200F\u202B\u202C\u202C\u200D\u206C\u206E\u206D\u200E\u200C\u206E\u206A\u202D\u200C\u206E\u200D\u202A\u206E\u206E\u200E\u202D\u206B\u206D\u202A\u206A\u202D\u206E\u206F\u206A\u202B\u202C\u202B\u202D\u206A\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u206B\u200C\u206D\u206B\u206F\u206B\u206A\u206C\u202A\u206B\u206C\u206F\u206D\u202E\u202C\u206D\u202D\u200E\u200D\u206C\u202C\u206E\u202B\u206D\u200C\u200D\u200B\u200B\u202C\u200F\u202E\u206F\u206A\u202C\u206B\u206E\u206C\u202D\u200C\u200F\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static PlayerUnit \u202C\u200B\u206B\u200C\u202A\u200E\u200D\u202B\u206B\u206E\u200B\u206A\u202D\u200E\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200E\u206F\u202B\u202E\u202E\u206C\u202B\u200B\u206C\u206C\u206F\u206A\u200E\u200F\u200E\u200D\u206F\u206A\u206B\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<StatusEffectEventArgs> \u202B\u202E\u202A\u206B\u202E\u206C\u206B\u200D\u202C\u206D\u202B\u200F\u206D\u206C\u200D\u206D\u206A\u202E\u202E\u202E\u206E\u206F\u202C\u200F\u206F\u206F\u206F\u200D\u200F\u202B\u206D\u202A\u202A\u200D\u206F\u202B\u206E\u202C\u202A\u202E\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoved;
			}

			static GameEvent<CardUsingEventArgs> \u206B\u202C\u200F\u206F\u202E\u202D\u206D\u206D\u206E\u200D\u206F\u202B\u200B\u200E\u200D\u206F\u206B\u206C\u202A\u206E\u200C\u200C\u200F\u206D\u206D\u202E\u200F\u200C\u202E\u206B\u200B\u206F\u202A\u206C\u200B\u200B\u206F\u206B\u206C\u202C\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static CardType \u200D\u202B\u206C\u202E\u202E\u202B\u200F\u202A\u200E\u200E\u202D\u202E\u200F\u206B\u206B\u200D\u200D\u200D\u206C\u202B\u202B\u206F\u200D\u202A\u202E\u200C\u200F\u202E\u202B\u206F\u206B\u202E\u202A\u200F\u202A\u206D\u206A\u206C\u206F\u200D\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static void \u202C\u206C\u202E\u206A\u200C\u206C\u202D\u206E\u200E\u200B\u200D\u202A\u202A\u200C\u202C\u206A\u200E\u200B\u200B\u200F\u206F\u200E\u200D\u202D\u200F\u200F\u206D\u202E\u200B\u202E\u200E\u200B\u200C\u202A\u206B\u206D\u200E\u202A\u202C\u206A\u202E(Card A_0, bool A_1)
			{
				A_0.FreeCost = A_1;
			}

			static bool \u206D\u206E\u200E\u202B\u200F\u202E\u200E\u206F\u202C\u206C\u202C\u200C\u206F\u206F\u202E\u202B\u202D\u200F\u200C\u200E\u202A\u206D\u202C\u206B\u202E\u206B\u200F\u200D\u200C\u202C\u206E\u200F\u200E\u202D\u206E\u206C\u206D\u202E\u206D\u200E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200B\u200D\u200E\u200F\u206F\u202B\u200C\u202C\u200D\u206D\u202B\u202E\u200B\u206F\u200E\u200F\u200D\u206B\u202A\u200E\u202E\u200D\u202B\u200E\u206C\u200D\u200E\u206E\u202D\u202A\u200E\u206F\u206C\u202D\u200F\u206C\u202E\u200E\u202A\u206D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static Card[] \u202D\u200E\u206D\u202A\u206E\u206C\u202B\u200B\u202E\u202E\u206A\u206D\u202C\u200E\u202A\u202B\u202E\u206E\u200E\u206A\u202C\u206B\u206A\u202B\u200B\u206A\u202C\u202D\u206E\u202C\u206E\u206C\u206D\u200D\u202B\u200E\u200D\u202E\u206A\u200D\u202E(CardsEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card[] \u202C\u200E\u206A\u202C\u200C\u206A\u202B\u206E\u200D\u206B\u206D\u200F\u202D\u200D\u202D\u200B\u206F\u200E\u206B\u200C\u202E\u206F\u202B\u206C\u202A\u206B\u206D\u200F\u206F\u202B\u206F\u202B\u206A\u202B\u200C\u200E\u202D\u206F\u200C\u206F\u202E(CardsAddingToDrawZoneEventArgs A_0)
			{
				return A_0.Cards;
			}

			static StatusEffect \u206B\u206C\u206A\u206A\u200E\u200C\u202C\u202B\u200E\u200C\u202D\u200D\u202E\u206B\u200F\u200E\u202D\u206A\u202C\u202C\u202A\u206E\u200F\u202E\u202C\u202A\u206B\u202D\u206F\u206E\u206B\u206D\u206B\u202B\u206C\u200E\u202B\u200E\u202C\u202C\u202E(StatusEffectEventArgs A_0)
			{
				return A_0.Effect;
			}
		}
	}
}
