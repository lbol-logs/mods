using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreTheCentennialFestivalforMagicalGirlsSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(458103796);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u202C\u206A\u206F\u200B\u206B\u206E\u202C\u206D\u206B\u202B\u206D\u200C\u206A\u202D\u206B\u206C\u200D\u206E\u200E\u200F\u206E\u206E\u206F\u206F\u200E\u202D\u200B\u200F\u206D\u206C\u200B\u200B\u202C\u200B\u206A\u206C\u200C\u206F\u202A\u200E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u202A\u202E\u202E\u206A\u206E\u206F\u200B\u202C\u200D\u202C\u206B\u206E\u202C\u206A\u202A\u200B\u200D\u206F\u206E\u206D\u202E\u200B\u200F\u202A\u202C\u206D\u200F\u202A\u206A\u200D\u206B\u202D\u206C\u200F\u202C\u202A\u206B\u206D\u200E\u200F\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1106771020), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExtraIcons LoadExtraIcons()
		{
			ExtraIcons extraIcons = FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u206C\u200F\u206E\u206D\u202E\u206A\u206D\u206E\u206E\u200D\u206E\u200E\u202D\u206F\u200B\u206B\u206A\u206C\u206F\u200C\u202D\u202D\u200C\u200E\u200D\u200E\u206F\u202E\u206A\u206E\u206E\u206C\u206E\u206E\u202A\u202D\u200C\u200D\u200B\u206B\u202E();
			extraIcons.icons.Add(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(916900891), FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u202A\u202E\u202E\u206A\u206E\u206F\u200B\u202C\u200D\u202C\u206B\u206E\u202C\u206A\u202A\u200B\u200D\u206F\u206E\u206D\u202E\u200B\u200F\u202A\u202C\u206D\u200F\u202A\u206A\u200D\u206B\u202D\u206C\u200F\u202C\u202A\u206B\u206D\u200E\u200F\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1600037746), BepinexPlugin.embeddedSource, null, 1, null));
			return extraIcons;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u206C\u200C\u206C\u206D\u200C\u200D\u206C\u200B\u202C\u202A\u202A\u206F\u202D\u206F\u206D\u200F\u200D\u200E\u206E\u202A\u202E\u202D\u206E\u206A\u202A\u200D\u200B\u202E\u200D\u200E\u206B\u200B\u202A\u200E\u206B\u206F\u206B\u202C\u200D\u202A\u202E(BepinexPlugin.sequenceTable, FlandreTheCentennialFestivalforMagicalGirlsSeDef.\u200D\u202A\u202E\u206C\u206B\u202B\u206F\u202A\u202E\u200E\u200E\u202A\u206D\u200C\u206C\u200C\u202C\u206E\u202D\u200E\u206A\u206D\u206C\u202E\u202A\u200E\u202B\u202B\u202A\u200F\u200E\u206A\u200D\u200C\u200E\u202D\u200F\u206E\u200B\u206B\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Upgrade, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-386928153) }, null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(704259234), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1258576852));
		}

		static BatchLocalization \u202C\u206A\u206F\u200B\u206B\u206E\u202C\u206D\u206B\u202B\u206D\u200C\u206A\u202D\u206B\u206C\u200D\u206E\u200E\u200F\u206E\u206E\u206F\u206F\u200E\u202D\u200B\u200F\u206D\u206C\u200B\u200B\u202C\u200B\u206A\u206C\u200C\u206F\u202A\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202A\u202E\u202E\u206A\u206E\u206F\u200B\u202C\u200D\u202C\u206B\u206E\u202C\u206A\u202A\u200B\u200D\u206F\u206E\u206D\u202E\u200B\u200F\u202A\u202C\u206D\u200F\u202A\u206A\u200D\u206B\u202D\u206C\u200F\u202C\u202A\u206B\u206D\u200E\u200F\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static ExtraIcons \u206C\u200F\u206E\u206D\u202E\u206A\u206D\u206E\u206E\u200D\u206E\u200E\u202D\u206F\u200B\u206B\u206A\u206C\u206F\u200C\u202D\u202D\u200C\u200E\u200D\u200E\u206F\u202E\u206A\u206E\u206E\u206C\u206E\u206E\u202A\u202D\u200C\u200D\u200B\u206B\u202E()
		{
			return new ExtraIcons();
		}

		static Type \u200D\u202A\u202E\u206C\u206B\u202B\u206F\u202A\u202E\u200E\u200E\u202A\u206D\u200C\u206C\u200C\u202C\u206E\u202D\u200E\u206A\u206D\u206C\u202E\u202A\u200E\u202B\u202B\u202A\u200F\u200E\u206A\u200D\u200C\u200E\u202D\u200F\u206E\u200B\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200C\u206C\u206D\u200C\u200D\u206C\u200B\u202C\u202A\u202A\u206F\u202D\u206F\u206D\u200F\u200D\u200E\u206E\u202A\u202E\u202D\u206E\u206A\u202A\u200D\u200B\u202E\u200D\u200E\u206B\u200B\u202A\u200E\u206B\u206F\u206B\u202C\u200D\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreTheCentennialFestivalforMagicalGirlsSeDef))]
		public sealed class FlandreTheCentennialFestivalforMagicalGirlsSe : StatusEffect
		{
			public override string OverrideIconName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					if (!FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206C\u202B\u202B\u206C\u206B\u202A\u200C\u206E\u202A\u202D\u202A\u206A\u202A\u206D\u202D\u202A\u202D\u200B\u206D\u200F\u206E\u200F\u200D\u206D\u200E\u206A\u202B\u206F\u200F\u206A\u206F\u200D\u202C\u200C\u202E\u200E\u202A\u200C\u206C\u206B\u202E(GameMaster.GetPreferredCardIllustrator(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1300935786)), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(916900891)))
					{
						for (;;)
						{
							int num = -1284619168;
							switch (~(-(num + ~((811232272 - -1504286156) ^ (-762697345 * 851096339))) * 1454215161) % 3)
							{
							case 0:
								continue;
							case 1:
								goto IL_0063;
							}
							break;
						}
						goto IL_0079;
						IL_0063:
						return FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206D\u200D\u202E\u200F\u202D\u206D\u202D\u202E\u200F\u206D\u200E\u202E\u200D\u206C\u202C\u206C\u200C\u202A\u206F\u206E\u202B\u202A\u206F\u202A\u206A\u206F\u206E\u202E\u202A\u206D\u206B\u206C\u200C\u200F\u202D\u206C\u206B\u200B\u206C\u206A\u202E(this);
					}
					IL_0079:
					return FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202B\u202B\u200F\u206D\u206D\u202B\u202B\u206D\u202A\u202D\u202D\u200B\u202D\u206E\u202A\u206A\u206E\u200E\u206B\u206F\u206D\u200D\u206B\u206A\u206B\u202A\u202A\u202D\u200C\u206B\u202E\u206D\u200D\u200F\u206B\u206D\u200D\u200E\u206F\u202A\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206D\u200D\u202E\u200F\u202D\u206D\u202D\u202E\u200F\u206D\u200E\u202E\u200D\u206C\u202C\u206C\u200C\u202A\u206F\u206E\u202B\u202A\u206F\u202A\u206A\u206F\u206E\u202E\u202A\u206D\u206B\u206C\u200C\u200F\u202D\u206C\u206B\u200B\u206C\u206A\u202E(this), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1179385805));
				}
			}

			public int Value
			{
				get
				{
					return 1;
				}
			}

			protected override void OnAdded(Unit unit)
			{
				if (FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206D\u206E\u200E\u206E\u200C\u202C\u206E\u202C\u206F\u202E\u200C\u206D\u206F\u200F\u202A\u206F\u200F\u202E\u206E\u206D\u206D\u206B\u202B\u202B\u202D\u200B\u202C\u206F\u206F\u202C\u200B\u206C\u202A\u200F\u200E\u202E\u200E\u202E\u202D\u200C\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this)) is FlandrePlayerUnitDef.FlandrePlayerUnit)
				{
					IEnumerator<Card> enumerator = (from c in FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u202D\u200B\u202A\u200B\u206D\u206F\u206D\u202E\u202C\u202C\u202E\u202D\u202B\u202C\u206B\u206D\u206B\u200B\u202E\u206B\u202D\u202E\u206E\u200C\u202D\u200C\u200F\u206D\u202A\u202E\u206A\u200E\u206F\u206E\u206E\u206D\u202E\u206C\u202D\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this))
						where c is FlandreCard
						select c).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_00AC:
							int num = (FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206F\u202D\u202C\u202D\u202E\u202E\u200E\u206B\u206D\u206C\u202B\u206F\u202D\u206A\u200E\u200E\u202B\u200D\u200F\u206C\u202C\u202C\u200E\u206A\u200D\u206F\u206B\u200F\u200C\u200D\u200D\u200F\u202C\u200F\u200B\u206A\u202A\u206A\u200B\u206A\u202E(enumerator) ? 1862232762 : (-1394635171));
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-(~(num2 ^ -((-1098744433 ^ 10212310) - (1902387705 ^ -1154380914)))) - 980259444)) % 6U)
								{
								case 1U:
								{
									FlandreCard flandreCard;
									num = (int)((flandreCard.IsMagicalGirl ? 2913983090U : 2133001721U) ^ (num3 * 1806133962U));
									continue;
								}
								case 2U:
								{
									FlandreCard flandreCard;
									flandreCard.IsTempMagicalGirl = true;
									num = (int)((num3 * 2807837984U) ^ 2314684992U);
									continue;
								}
								case 3U:
								{
									FlandreCard flandreCard = (FlandreCard)enumerator.Current;
									num = -1484632666;
									continue;
								}
								case 4U:
									num = 1862232762;
									continue;
								case 5U:
									goto IL_00AC;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0107:
								int num4 = -2064594216;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(-(~(num2 ^ -((-1098744433 ^ 10212310) - (1902387705 ^ -1154380914)))) - 980259444)) % 3U)
									{
									case 1U:
										FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u200C\u202A\u202E\u202C\u202D\u206E\u206C\u200D\u202B\u206C\u206B\u202A\u202E\u206A\u200F\u200E\u206D\u206C\u202E\u206D\u200B\u202C\u206F\u202E\u202D\u200F\u200E\u202B\u200B\u200C\u202A\u202D\u202A\u200C\u206A\u206D\u200D\u202B\u200F\u202E(enumerator);
										num4 = (int)((num3 * 3599391591U) ^ 1674082375U);
										continue;
									case 2U:
										goto IL_0107;
									}
									goto Block_10;
								}
							}
							Block_10:;
						}
					}
				}
				base.ReactOwnerEvent<CardsEventArgs>(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206E\u200C\u206E\u202D\u202D\u202A\u202D\u200C\u202E\u206C\u202A\u200C\u206B\u200F\u200B\u200C\u206E\u200D\u202D\u202B\u206F\u202D\u202D\u200B\u206C\u206D\u206C\u202E\u206B\u202D\u200B\u200F\u206D\u206A\u200D\u202D\u200B\u200D\u200E\u202B\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
				for (;;)
				{
					IL_017B:
					int num5 = -1883469406;
					for (;;)
					{
						int num2 = num5;
						uint num3;
						switch ((num3 = (uint)(-(~(num2 ^ -((-1098744433 ^ 10212310) - (1902387705 ^ -1154380914)))) - 980259444)) % 4U)
						{
						case 0U:
							goto IL_017B;
						case 1U:
							base.ReactOwnerEvent<CardsEventArgs>(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u202A\u206B\u202C\u200C\u202C\u202E\u202E\u206E\u200D\u200C\u206D\u200D\u200C\u206C\u206E\u206D\u200B\u200B\u202B\u206A\u206B\u202E\u202C\u200D\u200E\u206E\u206C\u200F\u206E\u206E\u206B\u206A\u206F\u206E\u206A\u206F\u200D\u202E\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
							base.ReactOwnerEvent<CardsEventArgs>(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u200B\u206C\u200E\u202B\u206E\u202B\u200B\u200D\u206E\u206A\u206E\u202A\u206D\u202B\u206D\u202E\u202A\u206C\u200B\u200D\u206E\u206B\u206C\u206B\u206C\u202E\u200C\u206D\u206B\u200F\u206B\u202B\u202E\u206F\u206E\u206F\u202C\u206F\u206F\u206C\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
							base.ReactOwnerEvent<CardsAddingToDrawZoneEventArgs>(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206A\u206A\u200B\u200C\u200F\u202D\u200E\u206F\u206A\u202B\u202B\u200C\u202C\u202A\u206E\u200F\u202D\u202D\u200B\u202D\u200B\u206F\u200D\u202A\u206A\u202C\u206B\u200B\u200F\u206E\u202C\u206E\u200E\u206D\u200D\u206A\u200F\u202E\u202D\u200F\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this)), new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
							num5 = (int)((num3 * 1363209919U) ^ 3298556472U);
							continue;
						case 2U:
						{
							base.ReactOwnerEvent<StatusEffectEventArgs>(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u200C\u202A\u200E\u200D\u206F\u200D\u206A\u200D\u202D\u202C\u200B\u200E\u202A\u206E\u200B\u200E\u206F\u206F\u200F\u202B\u206C\u200F\u200B\u206C\u200D\u202D\u206F\u206B\u202D\u202C\u206B\u206F\u206A\u202C\u202B\u200D\u206E\u200E\u206F\u206E\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u200F\u200F\u206C\u200D\u202D\u200B\u202E\u206B\u202D\u206C\u202D\u202E\u202B\u202C\u206D\u200F\u202B\u206A\u200F\u200C\u202A\u206A\u202C\u206A\u206B\u200C\u206B\u200F\u200E\u202A\u200E\u206A\u200C\u206A\u202C\u206C\u206E\u200E\u202E(this)), new EventSequencedReactor<StatusEffectEventArgs>(this.OnStatusEffectRemoving));
							BattleController battleController = FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this);
							int num6 = FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u206D\u206C\u200B\u202C\u200D\u206E\u202C\u206B\u202B\u206C\u206F\u202B\u206B\u206A\u206D\u200D\u202B\u200C\u200F\u206B\u200F\u200C\u206F\u202C\u200D\u206C\u202E\u206B\u200D\u202E\u206D\u206B\u206D\u206E\u200E\u206D\u200F\u200C\u202E\u202E(battleController);
							FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206F\u200E\u202A\u202B\u202B\u202D\u200C\u206F\u206B\u206B\u206A\u200F\u206B\u206A\u202E\u202C\u200C\u206B\u202E\u202D\u200E\u206D\u206A\u206E\u200E\u202A\u206A\u200F\u200F\u206A\u206E\u202D\u200C\u206C\u202D\u200C\u202A\u202E\u200E\u202E(battleController, num6 + 1);
							num5 = (int)((num3 * 2260240486U) ^ 4100606108U);
							continue;
						}
						}
						return;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = (from c in FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u202D\u200B\u202A\u200B\u206D\u206F\u206D\u202E\u202C\u202C\u202E\u202D\u202B\u202C\u206B\u206D\u206B\u200B\u202E\u206B\u202D\u202E\u206E\u200C\u202D\u200C\u200F\u206D\u202A\u202E\u206A\u200E\u206F\u206E\u206E\u206D\u202E\u206C\u202D\u202E(FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this))
					where c is FlandreCard
					select c).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_00DE:
						int num = ((!FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206F\u202D\u202C\u202D\u202E\u202E\u200E\u206B\u206D\u206C\u202B\u206F\u202D\u206A\u200E\u200E\u202B\u200D\u200F\u206C\u202C\u202C\u200E\u206A\u200D\u206F\u206B\u200F\u200C\u200D\u200D\u200F\u202C\u200F\u200B\u206A\u202A\u206A\u200B\u206A\u202E(enumerator)) ? (-2006822478) : 1962562676);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-(num2 - -964794061 * (-86151975 * (1695617358 + -1883308152))) + (1410876247 - -1906079237)) * 2073412523)) % 6U)
							{
							case 0U:
							{
								FlandreCard flandreCard;
								flandreCard.IsTempMagicalGirl = false;
								num = (int)((num3 * 585154496U) ^ 899699545U);
								continue;
							}
							case 1U:
							{
								FlandreCard flandreCard;
								num = (int)(((!flandreCard.IsTempMagicalGirl) ? 3106199354U : 2396590409U) ^ (num3 * 2839898509U));
								continue;
							}
							case 2U:
							{
								FlandreCard flandreCard = (FlandreCard)enumerator.Current;
								num = 867774881;
								continue;
							}
							case 3U:
								num = 1962562676;
								continue;
							case 5U:
								goto IL_00DE;
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
							IL_00FF:
							int num4 = -714843463;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)((-(num2 - -964794061 * (-86151975 * (1695617358 + -1883308152))) + (1410876247 - -1906079237)) * 2073412523)) % 3U)
								{
								case 1U:
									FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u200C\u202A\u202E\u202C\u202D\u206E\u206C\u200D\u202B\u206C\u206B\u202A\u202E\u206A\u200F\u200E\u206D\u206C\u202E\u206D\u200B\u202C\u206F\u202E\u202D\u200F\u200E\u202B\u200B\u200C\u202A\u202D\u202A\u200C\u206A\u206D\u200D\u202B\u200F\u202E(enumerator);
									num4 = (int)((num3 * 2922145350U) ^ 1576176487U);
									continue;
								case 2U:
									goto IL_00FF;
								}
								goto Block_8;
							}
						}
						Block_8:;
					}
				}
				BattleController battleController = FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(this);
				int num5 = FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u202C\u206D\u206C\u200B\u202C\u200D\u206E\u202C\u206B\u202B\u206C\u206F\u202B\u206B\u206A\u206D\u200D\u202B\u200C\u200F\u206B\u200F\u200C\u206F\u202C\u200D\u206C\u202E\u206B\u200D\u202E\u206D\u206B\u206D\u206E\u200E\u206D\u200F\u200C\u202E\u202E(battleController);
				FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u206F\u200E\u202A\u202B\u202B\u202D\u200C\u206F\u206B\u206B\u206A\u200F\u206B\u206A\u202E\u202C\u200C\u206B\u202E\u202D\u200E\u206D\u206A\u206E\u200E\u202A\u206A\u200F\u200F\u206A\u206E\u202D\u200C\u206C\u202D\u200C\u202A\u202E\u200E\u202E(battleController, num5 - 1);
			}

			private IEnumerable<BattleAction> OnCardsAdded(CardsEventArgs args)
			{
				FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnCardsAdded>d__6 <OnCardsAdded>d__ = new FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnCardsAdded>d__6(-2);
				<OnCardsAdded>d__.<>4__this = this;
				<OnCardsAdded>d__.<>3__args = args;
				return <OnCardsAdded>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnCardsAddedToDrawZone>d__7 <OnCardsAddedToDrawZone>d__ = new FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnCardsAddedToDrawZone>d__7(-2);
				<OnCardsAddedToDrawZone>d__.<>4__this = this;
				<OnCardsAddedToDrawZone>d__.<>3__args = args;
				return <OnCardsAddedToDrawZone>d__;
			}

			private BattleAction TakeEffect(IEnumerable<Card> cards)
			{
				List<Card> list = cards.Where((Card c) => FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<>c.\u206F\u200E\u206A\u206A\u202D\u202D\u206C\u206A\u206B\u202B\u206F\u202D\u206E\u200B\u202B\u206B\u200D\u206F\u200E\u202E\u202A\u206C\u206A\u202A\u202C\u202D\u200D\u202B\u200D\u202E\u206B\u206C\u202C\u206A\u206B\u202D\u206F\u202A\u202B\u206B\u202E(c)).ToList<Card>();
				for (;;)
				{
					IL_002B:
					int num = -1672086609;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(((num2 ^ (~(-304704957 * -862092557) + (-1919270453 + (420805042 - 297957609)))) - -(-501975571 * -1176613292)) * -585690631))) % 5U)
						{
						case 0U:
							goto IL_00B5;
						case 2U:
							goto IL_002B;
						case 3U:
							this.\u202C\u206C\u200D\u202A\u200B\u202D\u206F\u200F\u200B\u200B\u200C\u206B\u200E\u202A\u200E\u206D\u202E\u202C\u206C\u206B\u206F\u200E\u200F\u202A\u200D\u206C\u206A\u206D\u200C\u206C\u206C\u202C\u206E\u200C\u206E\u200B\u202C\u200F\u200D\u202D\u202E();
							num = -579093076;
							continue;
						case 4U:
							num = (int)(((list.Count != 0) ? 1063944644U : 1968715675U) ^ (num3 * 1535124864U));
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:
				goto IL_00C9;
				IL_00B5:
				return null;
				IL_00C9:
				return FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.\u200E\u206D\u206F\u200E\u206A\u202D\u202A\u206E\u202A\u206B\u200F\u202B\u202D\u200C\u200B\u206E\u206C\u206F\u206D\u202B\u206E\u206A\u206C\u206E\u200E\u200C\u206A\u200F\u200F\u202B\u206C\u202D\u200B\u202C\u202D\u202C\u202C\u206C\u200D\u202B\u202E(list);
			}

			private IEnumerable<BattleAction> OnStatusEffectRemoving(StatusEffectEventArgs args)
			{
				FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnStatusEffectRemoving>d__9 <OnStatusEffectRemoving>d__ = new FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe.<OnStatusEffectRemoving>d__9(-2);
				<OnStatusEffectRemoving>d__.<>4__this = this;
				<OnStatusEffectRemoving>d__.<>3__args = args;
				return <OnStatusEffectRemoving>d__;
			}

			static bool \u206C\u202B\u202B\u206C\u206B\u202A\u200C\u206E\u202A\u202D\u202A\u206A\u202A\u206D\u202D\u202A\u202D\u200B\u206D\u200F\u206E\u200F\u200D\u206D\u200E\u206A\u202B\u206F\u200F\u206A\u206F\u200D\u202C\u200C\u202E\u200E\u202A\u200C\u206C\u206B\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u206D\u200D\u202E\u200F\u202D\u206D\u202D\u202E\u200F\u206D\u200E\u202E\u200D\u206C\u202C\u206C\u200C\u202A\u206F\u206E\u202B\u202A\u206F\u202A\u206A\u206F\u206E\u202E\u202A\u206D\u206B\u206C\u200C\u200F\u202D\u206C\u206B\u200B\u206C\u206A\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static string \u202B\u202B\u200F\u206D\u206D\u202B\u202B\u206D\u202A\u202D\u202D\u200B\u202D\u206E\u202A\u206A\u206E\u200E\u206B\u206F\u206D\u200D\u206B\u206A\u206B\u202A\u202A\u202D\u200C\u206B\u202E\u206D\u200D\u200F\u206B\u206D\u200D\u200E\u206F\u202A\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static BattleController \u202E\u200C\u206A\u200F\u202C\u200B\u202D\u200D\u200B\u202B\u202B\u206F\u202A\u200D\u206D\u206D\u202B\u200D\u206C\u206C\u206B\u200B\u206C\u200B\u202C\u206C\u200B\u202D\u206A\u202D\u202D\u206C\u206A\u202B\u202C\u202A\u202C\u206C\u206F\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206D\u206E\u200E\u206E\u200C\u202C\u206E\u202C\u206F\u202E\u200C\u206D\u206F\u200F\u202A\u206F\u200F\u202E\u206E\u206D\u206D\u206B\u202B\u202B\u202D\u200B\u202C\u206F\u206F\u202C\u200B\u206C\u202A\u200F\u200E\u202E\u200E\u202E\u202D\u200C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static IEnumerable<Card> \u202C\u202D\u200B\u202A\u200B\u206D\u206F\u206D\u202E\u202C\u202C\u202E\u202D\u202B\u202C\u206B\u206D\u206B\u200B\u202E\u206B\u202D\u202E\u206E\u200C\u202D\u200C\u200F\u206D\u202A\u202E\u206A\u200E\u206F\u206E\u206E\u206D\u202E\u206C\u202D\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static bool \u206F\u202D\u202C\u202D\u202E\u202E\u200E\u206B\u206D\u206C\u202B\u206F\u202D\u206A\u200E\u200E\u202B\u200D\u200F\u206C\u202C\u202C\u200E\u206A\u200D\u206F\u206B\u200F\u200C\u200D\u200D\u200F\u202C\u200F\u200B\u206A\u202A\u206A\u200B\u206A\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202C\u200C\u202A\u202E\u202C\u202D\u206E\u206C\u200D\u202B\u206C\u206B\u202A\u202E\u206A\u200F\u200E\u206D\u206C\u202E\u206D\u200B\u202C\u206F\u202E\u202D\u200F\u200E\u202B\u200B\u200C\u202A\u202D\u202A\u200C\u206A\u206D\u200D\u202B\u200F\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<CardsEventArgs> \u206E\u200C\u206E\u202D\u202D\u202A\u202D\u200C\u202E\u206C\u202A\u200C\u206B\u200F\u200B\u200C\u206E\u200D\u202D\u202B\u206F\u202D\u202D\u200B\u206C\u206D\u206C\u202E\u206B\u202D\u200B\u200F\u206D\u206A\u200D\u202D\u200B\u200D\u200E\u202B\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u202E\u202A\u206B\u202C\u200C\u202C\u202E\u202E\u206E\u200D\u200C\u206D\u200D\u200C\u206C\u206E\u206D\u200B\u200B\u202B\u206A\u206B\u202E\u202C\u200D\u200E\u206E\u206C\u200F\u206E\u206E\u206B\u206A\u206F\u206E\u206A\u206F\u200D\u202E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u200B\u206C\u200E\u202B\u206E\u202B\u200B\u200D\u206E\u206A\u206E\u202A\u206D\u202B\u206D\u202E\u202A\u206C\u200B\u200D\u206E\u206B\u206C\u206B\u206C\u202E\u200C\u206D\u206B\u200F\u206B\u202B\u202E\u206F\u206E\u206F\u202C\u206F\u206F\u206C\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u206A\u206A\u200B\u200C\u200F\u202D\u200E\u206F\u206A\u202B\u202B\u200C\u202C\u202A\u206E\u200F\u202D\u202D\u200B\u202D\u200B\u206F\u200D\u202A\u206A\u202C\u206B\u200B\u200F\u206E\u202C\u206E\u200E\u206D\u200D\u206A\u200F\u202E\u202D\u200F\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static Unit \u202C\u200F\u200F\u206C\u200D\u202D\u200B\u202E\u206B\u202D\u206C\u202D\u202E\u202B\u202C\u206D\u200F\u202B\u206A\u200F\u200C\u202A\u206A\u202C\u206A\u206B\u200C\u206B\u200F\u200E\u202A\u200E\u206A\u200C\u206A\u202C\u206C\u206E\u200E\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<StatusEffectEventArgs> \u200C\u202A\u200E\u200D\u206F\u200D\u206A\u200D\u202D\u202C\u200B\u200E\u202A\u206E\u200B\u200E\u206F\u206F\u200F\u202B\u206C\u200F\u200B\u206C\u200D\u202D\u206F\u206B\u202D\u202C\u206B\u206F\u206A\u202C\u202B\u200D\u206E\u200E\u206F\u206E\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoving;
			}

			static int \u202C\u206D\u206C\u200B\u202C\u200D\u206E\u202C\u206B\u202B\u206C\u206F\u202B\u206B\u206A\u206D\u200D\u202B\u200C\u200F\u206B\u200F\u200C\u206F\u202C\u200D\u206C\u202E\u206B\u200D\u202E\u206D\u206B\u206D\u206E\u200E\u206D\u200F\u200C\u202E\u202E(BattleController A_0)
			{
				return A_0.UpgradeTempCardsLevel;
			}

			static void \u206F\u200E\u202A\u202B\u202B\u202D\u200C\u206F\u206B\u206B\u206A\u200F\u206B\u206A\u202E\u202C\u200C\u206B\u202E\u202D\u200E\u206D\u206A\u206E\u200E\u202A\u206A\u200F\u200F\u206A\u206E\u202D\u200C\u206C\u202D\u200C\u202A\u202E\u200E\u202E(BattleController A_0, int A_1)
			{
				A_0.UpgradeTempCardsLevel = A_1;
			}

			void \u202C\u206C\u200D\u202A\u200B\u202D\u206F\u200F\u200B\u200B\u200C\u206B\u200E\u202A\u200E\u206D\u202E\u202C\u206C\u206B\u206F\u200E\u200F\u202A\u200D\u206C\u206A\u206D\u200C\u206C\u206C\u202C\u206E\u200C\u206E\u200B\u202C\u200F\u200D\u202D\u202E()
			{
				base.NotifyActivating();
			}

			static UpgradeCardsAction \u200E\u206D\u206F\u200E\u206A\u202D\u202A\u206E\u202A\u206B\u200F\u202B\u202D\u200C\u200B\u206E\u206C\u206F\u206D\u202B\u206E\u206A\u206C\u206E\u200E\u200C\u206A\u200F\u200F\u202B\u206C\u202D\u200B\u202C\u202D\u202C\u202C\u206C\u200D\u202B\u202E(IEnumerable<Card> A_0)
			{
				return new UpgradeCardsAction(A_0);
			}
		}
	}
}
