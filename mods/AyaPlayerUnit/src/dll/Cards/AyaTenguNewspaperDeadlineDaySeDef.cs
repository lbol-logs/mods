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
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaTenguNewspaperDeadlineDaySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1562889632);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTenguNewspaperDeadlineDaySeDef.\u202D\u200F\u206E\u200E\u202E\u202D\u200B\u202D\u202B\u202D\u200E\u202E\u202C\u202A\u206B\u202D\u206A\u206C\u200E\u206E\u200B\u206C\u206A\u200C\u200B\u202B\u206D\u206F\u206E\u206B\u206F\u200D\u206E\u206A\u200E\u202B\u206A\u202D\u200B\u202D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaTenguNewspaperDeadlineDaySeDef.\u200B\u206B\u206E\u206D\u206B\u200C\u202A\u202C\u200C\u206A\u202A\u202B\u206D\u206A\u200B\u200B\u206A\u202B\u200E\u200E\u206D\u200C\u202C\u206D\u206D\u200F\u202B\u202A\u206D\u202E\u202C\u206F\u200E\u202B\u206D\u206D\u202A\u206B\u202E\u202B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-257787353), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaTenguNewspaperDeadlineDaySeDef.\u206B\u200D\u206C\u200E\u200D\u202D\u200C\u200D\u206F\u202B\u202C\u202A\u206D\u202E\u202A\u200C\u200C\u200F\u206A\u206F\u202E\u200D\u200D\u200E\u202B\u200C\u206A\u206C\u200F\u206F\u202E\u206A\u206C\u202E\u202D\u202D\u202E\u200D\u206C\u202E(BepinexPlugin.sequenceTable, AyaTenguNewspaperDeadlineDaySeDef.\u206D\u200C\u206D\u206F\u200C\u202E\u200C\u200B\u200C\u206E\u202A\u206B\u206F\u202D\u200B\u200E\u200B\u206D\u206E\u202E\u202E\u202B\u200C\u202C\u202D\u202B\u202B\u202A\u200B\u202C\u202B\u206A\u202A\u206B\u206C\u206A\u206E\u202A\u200E\u200E\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Misfortune | Keyword.Replenish, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u202D\u200F\u206E\u200E\u202E\u202D\u200B\u202D\u202B\u202D\u200E\u202E\u202C\u202A\u206B\u202D\u206A\u206C\u200E\u206E\u200B\u206C\u206A\u200C\u200B\u202B\u206D\u206F\u206E\u206B\u206F\u200D\u206E\u206A\u200E\u202B\u206A\u202D\u200B\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200B\u206B\u206E\u206D\u206B\u200C\u202A\u202C\u200C\u206A\u202A\u202B\u206D\u206A\u200B\u200B\u206A\u202B\u200E\u200E\u206D\u200C\u202C\u206D\u206D\u200F\u202B\u202A\u206D\u202E\u202C\u206F\u200E\u202B\u206D\u206D\u202A\u206B\u202E\u202B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206D\u200C\u206D\u206F\u200C\u202E\u200C\u200B\u200C\u206E\u202A\u206B\u206F\u202D\u200B\u200E\u200B\u206D\u206E\u202E\u202E\u202B\u200C\u202C\u202D\u202B\u202B\u202A\u200B\u202C\u202B\u206A\u202A\u206B\u206C\u206A\u206E\u202A\u200E\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u200D\u206C\u200E\u200D\u202D\u200C\u200D\u206F\u202B\u202C\u202A\u206D\u202E\u202A\u200C\u200C\u200F\u206A\u206F\u202E\u200D\u200D\u200E\u202B\u200C\u206A\u206C\u200F\u206F\u202E\u206A\u206C\u202E\u202D\u202D\u202E\u200D\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTenguNewspaperDeadlineDaySeDef))]
		public sealed class AyaTenguNewspaperDeadlineDaySe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				IEnumerator<Card> enumerator = AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206F\u200C\u206A\u200E\u206C\u206B\u206C\u200C\u200B\u200B\u206B\u200E\u206C\u200D\u206F\u206F\u206E\u200D\u202B\u206A\u202D\u200B\u202A\u200E\u206C\u202E\u202A\u206E\u206B\u202E\u200F\u206E\u202C\u200B\u200F\u200F\u202B\u202C\u202E(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0096:
						int num = ((!AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202D\u206C\u206F\u202A\u200D\u206B\u202B\u206D\u200E\u206D\u200B\u200D\u206D\u206C\u202E\u206D\u200F\u202E\u206B\u206A\u206B\u206C\u206E\u202B\u202A\u206E\u200F\u202A\u202E\u200E\u206B\u206B\u206C\u200D\u200C\u206D\u200F\u200D\u202B\u202D\u202E(enumerator)) ? (-2011491871) : (-1177964957));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(num2 * -1820574393 * 1402409763) * 1221172227)) % 6U)
							{
							case 0U:
								num = -1177964957;
								continue;
							case 1U:
							{
								Card card;
								num = (int)(((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) == CardType.Misfortune) ? 1908019916U : 2217293686U) ^ (num3 * 2671130220U));
								continue;
							}
							case 3U:
							{
								Card card;
								AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206D\u206A\u200F\u206C\u200F\u200E\u206E\u206E\u200F\u206D\u200C\u206B\u206E\u200F\u202C\u206E\u200D\u202A\u206D\u206D\u202E\u200F\u206C\u206F\u202A\u200F\u206A\u202D\u200E\u206D\u202B\u200B\u206C\u202A\u206D\u206F\u202E\u200B\u206A\u206E\u202E(card, true);
								num = -1540025446;
								continue;
							}
							case 4U:
							{
								Card card = enumerator.Current;
								num = ((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) != CardType.Status) ? 483760484 : 1369847328);
								continue;
							}
							case 5U:
								goto IL_0096;
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
							IL_00C8:
							int num4 = 1038486918;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~(num2 * -1820574393 * 1402409763) * 1221172227)) % 3U)
								{
								case 0U:
									goto IL_00C8;
								case 1U:
									AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200E\u206E\u206E\u202D\u206C\u206A\u206F\u200E\u206C\u206B\u206D\u206F\u206F\u200E\u206D\u206E\u206F\u200B\u206F\u200D\u206F\u202A\u202C\u200B\u206A\u202B\u200D\u200B\u206D\u202E\u206D\u202C\u200D\u202C\u206A\u200B\u206E\u200B\u202C\u200D\u202E(enumerator);
									num4 = (int)((num3 * 89243085U) ^ 2243137077U);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
				base.HandleOwnerEvent<CardsEventArgs>(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200C\u206C\u202D\u206E\u202A\u200B\u202C\u200F\u200F\u206B\u202C\u200E\u200C\u200B\u202C\u206A\u200D\u200C\u206A\u200D\u200D\u202B\u206C\u202A\u206D\u206E\u200E\u202A\u206A\u206F\u200E\u206B\u200D\u206E\u206A\u206C\u202A\u202E\u206A\u206F\u202E(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
				base.HandleOwnerEvent<CardsEventArgs>(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206A\u202C\u202B\u202A\u200B\u200D\u202E\u200F\u206A\u200D\u200C\u202E\u200D\u206B\u206E\u200E\u206B\u202D\u202C\u202B\u200F\u206E\u202A\u202E\u202B\u202C\u206C\u200D\u206A\u206F\u200D\u206C\u200E\u206D\u202D\u202E\u202E\u202B\u202E\u206A\u202E(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
				for (;;)
				{
					IL_0149:
					int num5 = 244825628;
					for (;;)
					{
						int num2 = num5;
						uint num3;
						switch ((num3 = (uint)(~(num2 * -1820574393 * 1402409763) * 1221172227)) % 3U)
						{
						case 1U:
							base.HandleOwnerEvent<CardsEventArgs>(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200C\u206F\u200F\u206C\u202E\u200C\u206B\u206A\u202E\u200E\u206B\u200E\u200F\u202A\u206C\u200C\u206D\u206C\u206F\u202D\u200F\u202E\u206C\u206A\u202C\u206D\u202B\u200D\u200F\u200B\u206F\u200D\u206E\u200E\u206F\u206C\u200C\u206E\u200E\u200D\u202E(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(this)), new GameEventHandler<CardsEventArgs>(this.OnAddCard));
							base.HandleOwnerEvent<CardsAddingToDrawZoneEventArgs>(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206C\u202B\u202D\u200E\u202D\u200D\u206E\u200B\u206D\u202C\u200C\u206C\u202B\u202D\u206A\u206C\u206C\u200E\u200E\u206A\u206F\u206A\u200D\u202A\u200C\u206E\u206B\u206C\u202C\u200E\u200D\u206B\u206A\u200C\u202E\u206C\u206C\u200E\u200B\u200C\u202E(AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(this)), new GameEventHandler<CardsAddingToDrawZoneEventArgs>(this.OnAddCardToDraw));
							num5 = (int)((num3 * 2720479952U) ^ 4093608217U);
							continue;
						case 2U:
							goto IL_0149;
						}
						return;
					}
				}
			}

			private void OnAddCard(CardsEventArgs args)
			{
				Card[] array = AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206C\u202B\u206E\u200F\u200C\u206D\u206C\u202B\u206F\u202E\u200E\u202C\u200D\u202C\u200F\u206A\u206C\u202C\u206A\u206A\u200B\u206F\u202C\u206A\u200C\u202A\u200D\u200B\u200D\u202E\u206B\u202B\u202E\u202E\u202B\u206E\u202D\u200D\u206C\u206C\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -1496060375;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(num2 - --1271544736) - (1961857997 + 1954254160)))) % 10U)
						{
						case 0U:
						{
							int num4;
							num4++;
							num = -1756340090;
							continue;
						}
						case 1U:
						{
							int num4;
							num = ((num4 < array.Length) ? 1878662379 : 1691831133);
							continue;
						}
						case 2U:
						{
							Card card;
							AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206D\u206A\u200F\u206C\u200F\u200E\u206E\u206E\u200F\u206D\u200C\u206B\u206E\u200F\u202C\u206E\u200D\u202A\u206D\u206D\u202E\u200F\u206C\u206F\u202A\u200F\u206A\u202D\u200E\u206D\u202B\u200B\u206C\u202A\u206D\u206F\u202E\u200B\u206A\u206E\u202E(card, true);
							num = 1861983475;
							continue;
						}
						case 3U:
							goto IL_0007;
						case 4U:
						{
							int num4;
							Card card = array[num4];
							num = -2107478006;
							continue;
						}
						case 5U:
						{
							Card card;
							num = (int)(((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) != CardType.Status) ? 717689584U : 1087478435U) ^ (num3 * 1066776932U));
							continue;
						}
						case 6U:
						{
							int num4 = 0;
							num = (int)((num3 * 3282654122U) ^ 1463678428U);
							continue;
						}
						case 7U:
						{
							Card card;
							num = (int)(((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) != CardType.Misfortune) ? 1047779769U : 4210501717U) ^ (num3 * 312333818U));
							continue;
						}
						case 9U:
							num = (int)((num3 * 308215493U) ^ 1529430551U);
							continue;
						}
						return;
					}
				}
			}

			private void OnAddCardToDraw(CardsAddingToDrawZoneEventArgs args)
			{
				Card[] array = AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206C\u200C\u200D\u200B\u206E\u206A\u202C\u206B\u202E\u200B\u202D\u206C\u202B\u202E\u206E\u206C\u202D\u206D\u202D\u200D\u206E\u200F\u206D\u200C\u200E\u200D\u200C\u202A\u202C\u200E\u202D\u206D\u206D\u202C\u202E\u206D\u206E\u206E\u200C\u202A\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -238251249;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~num2 ^ -(2081917429 - -643454074))) % 10U)
						{
						case 0U:
							num = (int)((num3 * 942549589U) ^ 3500725974U);
							continue;
						case 1U:
						{
							int num4 = 0;
							num = (int)((num3 * 884020447U) ^ 1346389821U);
							continue;
						}
						case 2U:
						{
							int num4;
							num4++;
							num = -1111882166;
							continue;
						}
						case 3U:
						{
							Card card;
							num = (int)(((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) != CardType.Status) ? 533889367U : 976085100U) ^ (num3 * 2401983094U));
							continue;
						}
						case 4U:
							goto IL_0007;
						case 5U:
						{
							int num4;
							Card card = array[num4];
							num = -772338497;
							continue;
						}
						case 6U:
						{
							int num4;
							num = ((num4 < array.Length) ? (-261552877) : (-506805597));
							continue;
						}
						case 8U:
						{
							Card card;
							AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u206D\u206A\u200F\u206C\u200F\u200E\u206E\u206E\u200F\u206D\u200C\u206B\u206E\u200F\u202C\u206E\u200D\u202A\u206D\u206D\u202E\u200F\u206C\u206F\u202A\u200F\u206A\u202D\u200E\u206D\u202B\u200B\u206C\u202A\u206D\u206F\u202E\u200B\u206A\u206E\u202E(card, true);
							num = -740480262;
							continue;
						}
						case 9U:
						{
							Card card;
							num = (int)(((AyaTenguNewspaperDeadlineDaySeDef.AyaTenguNewspaperDeadlineDaySe.\u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(card) != CardType.Misfortune) ? 2647328339U : 3127274131U) ^ (num3 * 821739367U));
							continue;
						}
						}
						return;
					}
				}
			}

			static BattleController \u200D\u200F\u206F\u206A\u202B\u202A\u206C\u206D\u206F\u202B\u206C\u206F\u206D\u206F\u206A\u202C\u202E\u206C\u206D\u206B\u206F\u200C\u206E\u200D\u202C\u206D\u202D\u202E\u200C\u200E\u200D\u206A\u206E\u200B\u202A\u202A\u200C\u200B\u202A\u206D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Card> \u206F\u200C\u206A\u200E\u206C\u206B\u206C\u200C\u200B\u200B\u206B\u200E\u206C\u200D\u206F\u206F\u206E\u200D\u202B\u206A\u202D\u200B\u202A\u200E\u206C\u202E\u202A\u206E\u206B\u202E\u200F\u206E\u202C\u200B\u200F\u200F\u202B\u202C\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static CardType \u202B\u200F\u200B\u202B\u206B\u200C\u206E\u206B\u206B\u202E\u200D\u200E\u200D\u200B\u202E\u202D\u202D\u206B\u200D\u200F\u200B\u202E\u200D\u202A\u206F\u206E\u206D\u202D\u200F\u200D\u200C\u200C\u202C\u202D\u202C\u202A\u202B\u202B\u202A\u202A\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static void \u206D\u206A\u200F\u206C\u200F\u200E\u206E\u206E\u200F\u206D\u200C\u206B\u206E\u200F\u202C\u206E\u200D\u202A\u206D\u206D\u202E\u200F\u206C\u206F\u202A\u200F\u206A\u202D\u200E\u206D\u202B\u200B\u206C\u202A\u206D\u206F\u202E\u200B\u206A\u206E\u202E(Card A_0, bool A_1)
			{
				A_0.IsReplenish = A_1;
			}

			static bool \u202D\u206C\u206F\u202A\u200D\u206B\u202B\u206D\u200E\u206D\u200B\u200D\u206D\u206C\u202E\u206D\u200F\u202E\u206B\u206A\u206B\u206C\u206E\u202B\u202A\u206E\u200F\u202A\u202E\u200E\u206B\u206B\u206C\u200D\u200C\u206D\u200F\u200D\u202B\u202D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200E\u206E\u206E\u202D\u206C\u206A\u206F\u200E\u206C\u206B\u206D\u206F\u206F\u200E\u206D\u206E\u206F\u200B\u206F\u200D\u206F\u202A\u202C\u200B\u206A\u202B\u200D\u200B\u206D\u202E\u206D\u202C\u200D\u202C\u206A\u200B\u206E\u200B\u202C\u200D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<CardsEventArgs> \u200C\u206C\u202D\u206E\u202A\u200B\u202C\u200F\u200F\u206B\u202C\u200E\u200C\u200B\u202C\u206A\u200D\u200C\u206A\u200D\u200D\u202B\u206C\u202A\u206D\u206E\u200E\u202A\u206A\u206F\u200E\u206B\u200D\u206E\u206A\u206C\u202A\u202E\u206A\u206F\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206A\u202C\u202B\u202A\u200B\u200D\u202E\u200F\u206A\u200D\u200C\u202E\u200D\u206B\u206E\u200E\u206B\u202D\u202C\u202B\u200F\u206E\u202A\u202E\u202B\u202C\u206C\u200D\u206A\u206F\u200D\u206C\u200E\u206D\u202D\u202E\u202E\u202B\u202E\u206A\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u200C\u206F\u200F\u206C\u202E\u200C\u206B\u206A\u202E\u200E\u206B\u200E\u200F\u202A\u206C\u200C\u206D\u206C\u206F\u202D\u200F\u202E\u206C\u206A\u202C\u206D\u202B\u200D\u200F\u200B\u206F\u200D\u206E\u200E\u206F\u206C\u200C\u206E\u200E\u200D\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u206C\u202B\u202D\u200E\u202D\u200D\u206E\u200B\u206D\u202C\u200C\u206C\u202B\u202D\u206A\u206C\u206C\u200E\u200E\u206A\u206F\u206A\u200D\u202A\u200C\u206E\u206B\u206C\u202C\u200E\u200D\u206B\u206A\u200C\u202E\u206C\u206C\u200E\u200B\u200C\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static Card[] \u206C\u202B\u206E\u200F\u200C\u206D\u206C\u202B\u206F\u202E\u200E\u202C\u200D\u202C\u200F\u206A\u206C\u202C\u206A\u206A\u200B\u206F\u202C\u206A\u200C\u202A\u200D\u200B\u200D\u202E\u206B\u202B\u202E\u202E\u202B\u206E\u202D\u200D\u206C\u206C\u202E(CardsEventArgs A_0)
			{
				return A_0.Cards;
			}

			static Card[] \u206C\u200C\u200D\u200B\u206E\u206A\u202C\u206B\u202E\u200B\u202D\u206C\u202B\u202E\u206E\u206C\u202D\u206D\u202D\u200D\u206E\u200F\u206D\u200C\u200E\u200D\u200C\u202A\u202C\u200E\u202D\u206D\u206D\u202C\u202E\u206D\u206E\u206E\u200C\u202A\u202E(CardsAddingToDrawZoneEventArgs A_0)
			{
				return A_0.Cards;
			}
		}
	}
}
