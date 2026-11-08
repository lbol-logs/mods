using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.Cards;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.StatusEffects
{
	public sealed class FlandreMagicalGirlSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(314531139);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalGirlSeDef.\u206B\u202D\u206A\u200B\u206B\u200B\u200C\u206F\u202B\u202E\u200B\u202E\u200D\u200E\u206D\u200D\u202C\u202A\u202A\u200F\u200B\u206D\u202C\u202B\u200C\u206A\u206B\u200F\u206D\u200F\u202E\u202A\u202C\u202E\u206D\u200E\u202D\u206A\u202E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreMagicalGirlSeDef.\u202A\u206C\u200E\u200E\u200F\u200D\u206A\u200C\u206D\u206C\u200D\u200C\u206F\u202A\u202D\u202A\u200D\u202B\u200B\u202D\u206F\u202E\u206B\u200C\u202D\u206E\u202D\u200E\u200E\u202C\u200B\u200B\u202D\u202B\u200F\u200F\u202D\u202E\u202D\u200F\u202E(BepinexPlugin.sequenceTable, FlandreMagicalGirlSeDef.\u206D\u206C\u202E\u200C\u206A\u206C\u202C\u202E\u200E\u202D\u202D\u206B\u200E\u206D\u202E\u200F\u202D\u200C\u202C\u202E\u202A\u200E\u202E\u202D\u206E\u206F\u200D\u200D\u202C\u200F\u206B\u202B\u206B\u206D\u200E\u206F\u202B\u200B\u206B\u200D\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Shield | Keyword.Upgrade, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u206B\u202D\u206A\u200B\u206B\u200B\u200C\u206F\u202B\u202E\u200B\u202E\u200D\u200E\u206D\u200D\u202C\u202A\u202A\u200F\u200B\u206D\u202C\u202B\u200C\u206A\u206B\u200F\u206D\u200F\u202E\u202A\u202C\u202E\u206D\u200E\u202D\u206A\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206D\u206C\u202E\u200C\u206A\u206C\u202C\u202E\u200E\u202D\u202D\u206B\u200E\u206D\u202E\u200F\u202D\u200C\u202C\u202E\u202A\u200E\u202E\u202D\u206E\u206F\u200D\u200D\u202C\u200F\u206B\u202B\u206B\u206D\u200E\u206F\u202B\u200B\u206B\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202A\u206C\u200E\u200E\u200F\u200D\u206A\u200C\u206D\u206C\u200D\u200C\u206F\u202A\u202D\u202A\u200D\u202B\u200B\u202D\u206F\u202E\u206B\u200C\u202D\u206E\u202D\u200E\u200E\u202C\u200B\u200B\u202D\u202B\u200F\u200F\u202D\u202E\u202D\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalGirlSeDef))]
		public sealed class FlandreMagicalGirlSe : StatusEffect
		{
			public int Value1
			{
				get
				{
					int num = 2;
					GameRunController gameRunController = FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206F\u200C\u200E\u200F\u200F\u202A\u206C\u202A\u206F\u202B\u200E\u202B\u200D\u200D\u206C\u202D\u202C\u200B\u200F\u200B\u206C\u202A\u200D\u200E\u200B\u202D\u200C\u206B\u200C\u202B\u200C\u200D\u200C\u202C\u206F\u202E\u202C\u200F\u200B\u202D\u202E(Singleton<GameMaster>.Instance);
					bool flag;
					if (gameRunController == null)
					{
						flag = false;
					}
					else
					{
						BattleController battleController = FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206A\u206D\u200C\u206B\u206A\u206E\u206C\u206A\u200C\u206C\u202D\u202B\u206A\u202C\u202D\u206B\u200C\u200D\u200D\u202B\u202A\u206F\u206B\u202D\u206F\u202C\u206C\u200E\u202B\u202D\u200F\u206C\u206C\u200D\u200F\u200B\u200B\u202B\u202D\u200F\u202E(gameRunController);
						flag = ((battleController != null) ? new bool?(FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u202A\u206D\u200B\u206F\u202B\u200D\u200F\u202A\u206F\u206D\u206C\u202C\u206E\u206B\u200E\u206F\u200B\u206E\u206B\u202D\u200E\u206C\u200D\u200B\u202C\u202D\u202E\u206E\u202A\u200D\u206F\u202C\u200C\u206F\u206D\u202D\u206E\u206D\u200E\u200E\u202E(battleController).HasStatusEffect<FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe>()) : null).GetValueOrDefault();
					}
					if (flag)
					{
						goto IL_0040;
					}
					goto IL_0088;
					int num3;
					for (;;)
					{
						IL_0045:
						int num2 = num3;
						uint num4;
						switch ((num4 = (uint)(~(uint)(~(1501930613 - 1754988791) - ~(uint)num2))) % 5U)
						{
						case 0U:
							num++;
							num3 = (int)((num4 * 3764101923U) ^ 2800528154U);
							continue;
						case 1U:
							num++;
							num3 = (int)((num4 * 1128867401U) ^ 4280712746U);
							continue;
						case 2U:
							goto IL_0088;
						case 3U:
							goto IL_0040;
						}
						break;
					}
					return num;
					IL_0040:
					num3 = -1088189525;
					goto IL_0045;
					IL_0088:
					GameRunController gameRunController2 = FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206F\u200C\u200E\u200F\u200F\u202A\u206C\u202A\u206F\u202B\u200E\u202B\u200D\u200D\u206C\u202D\u202C\u200B\u200F\u200B\u206C\u202A\u200D\u200E\u200B\u202D\u200C\u206B\u200C\u202B\u200C\u200D\u200C\u202C\u206F\u202E\u202C\u200F\u200B\u202D\u202E(Singleton<GameMaster>.Instance);
					bool flag2;
					if (gameRunController2 == null)
					{
						flag2 = false;
					}
					else
					{
						BattleController battleController2 = FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206A\u206D\u200C\u206B\u206A\u206E\u206C\u206A\u200C\u206C\u202D\u202B\u206A\u202C\u202D\u206B\u200C\u200D\u200D\u202B\u202A\u206F\u206B\u202D\u206F\u202C\u206C\u200E\u202B\u202D\u200F\u206C\u206C\u200D\u200F\u200B\u200B\u202B\u202D\u200F\u202E(gameRunController2);
						flag2 = ((battleController2 != null) ? new bool?(FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u202A\u206D\u200B\u206F\u202B\u200D\u200F\u202A\u206F\u206D\u206C\u202C\u206E\u206B\u200E\u206F\u200B\u206E\u206B\u202D\u200E\u206C\u200D\u200B\u202C\u202D\u202E\u206E\u202A\u200D\u206F\u202C\u200C\u206F\u206D\u202D\u206E\u206D\u200E\u200E\u202E(battleController2).HasStatusEffect<FlandreTheCentennialFestivalforMagicalGirlsSeDef.FlandreTheCentennialFestivalforMagicalGirlsSe>()) : null).GetValueOrDefault();
					}
					if (flag2)
					{
						num3 = -965912519;
						goto IL_0045;
					}
					return num;
				}
			}

			public int Value2
			{
				get
				{
					return 10;
				}
			}

			public int Amount
			{
				get
				{
					int value = this.Value2;
					GameRunController gameRunController = FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206F\u200C\u200E\u200F\u200F\u202A\u206C\u202A\u206F\u202B\u200E\u202B\u200D\u200D\u206C\u202D\u202C\u200B\u200F\u200B\u206C\u202A\u200D\u200E\u200B\u202D\u200C\u206B\u200C\u202B\u200C\u200D\u200C\u202C\u206F\u202E\u202C\u200F\u200B\u202D\u202E(Singleton<GameMaster>.Instance);
					int? num;
					if (gameRunController == null)
					{
						num = null;
					}
					else
					{
						num = new int?(FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.\u206F\u206F\u202E\u206D\u202E\u206B\u200F\u202D\u200C\u200B\u206C\u200D\u200D\u206C\u200D\u200E\u206F\u206C\u206B\u202C\u202C\u202B\u202D\u200B\u206A\u206A\u202D\u200C\u206E\u206B\u202B\u206D\u202E\u200C\u202B\u206E\u206C\u206F\u202E\u202A\u202E(gameRunController).Where(delegate(Card c)
						{
							FlandreCard flandreCard = c as FlandreCard;
							if (flandreCard != null)
							{
								for (;;)
								{
									int num3 = -1626936409;
									switch (~((num3 - 1356473249 * (-1204964871 * (228593495 + 1340741094)) - (1840431092 + -1024276024)) ^ ~-972126318) % 3)
									{
									case 0:
										continue;
									case 1:
										goto IL_0054;
									}
									break;
								}
								return false;
								IL_0054:
								return flandreCard.IsMagicalGirl;
							}
							return false;
						}).Sum((Card c) => FlandreMagicalGirlSeDef.FlandreMagicalGirlSe.<>c.\u202A\u206A\u202C\u202B\u200F\u206F\u206E\u206B\u206C\u202D\u200D\u206A\u206B\u200F\u206D\u206B\u206E\u200E\u206B\u200E\u202E\u200F\u202A\u202D\u206F\u200E\u206B\u200B\u206C\u202A\u202D\u200D\u202C\u206D\u200D\u202E\u202B\u206F\u206B\u202B\u202E(c).GetValueOrDefault()));
					}
					int? num2 = num;
					return value * num2.GetValueOrDefault();
				}
			}

			static GameRunController \u206F\u200C\u200E\u200F\u200F\u202A\u206C\u202A\u206F\u202B\u200E\u202B\u200D\u200D\u206C\u202D\u202C\u200B\u200F\u200B\u206C\u202A\u200D\u200E\u200B\u202D\u200C\u206B\u200C\u202B\u200C\u200D\u200C\u202C\u206F\u202E\u202C\u200F\u200B\u202D\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static BattleController \u206A\u206D\u200C\u206B\u206A\u206E\u206C\u206A\u200C\u206C\u202D\u202B\u206A\u202C\u202D\u206B\u200C\u200D\u200D\u202B\u202A\u206F\u206B\u202D\u206F\u202C\u206C\u200E\u202B\u202D\u200F\u206C\u206C\u200D\u200F\u200B\u200B\u202B\u202D\u200F\u202E(GameRunController A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202A\u206D\u200B\u206F\u202B\u200D\u200F\u202A\u206F\u206D\u206C\u202C\u206E\u206B\u200E\u206F\u200B\u206E\u206B\u202D\u200E\u206C\u200D\u200B\u202C\u202D\u202E\u206E\u202A\u200D\u206F\u202C\u200C\u206F\u206D\u202D\u206E\u206D\u200E\u200E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static IReadOnlyList<Card> \u206F\u206F\u202E\u206D\u202E\u206B\u200F\u202D\u200C\u200B\u206C\u200D\u200D\u206C\u200D\u200E\u206F\u206C\u206B\u202C\u202C\u202B\u202D\u200B\u206A\u206A\u202D\u200C\u206E\u206B\u202B\u206D\u202E\u200C\u202B\u206E\u206C\u206F\u202E\u202A\u202E(GameRunController A_0)
			{
				return A_0.BaseDeck;
			}
		}
	}
}
