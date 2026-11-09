using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.Cards;
using AyaShameimaru.Exhibits;
using LBoL.Base;
using LBoL.Base.Extensions;
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

namespace AyaShameimaru.StatusEffects
{
	public sealed class FlandreBloodlustSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-392309931);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreBloodlustSeDef.\u206E\u200C\u206D\u206F\u200D\u206E\u206A\u202A\u202D\u200B\u200E\u206E\u206A\u200E\u206A\u200E\u202B\u200E\u202A\u200E\u202E\u206C\u206E\u206D\u202E\u206D\u206D\u206D\u206A\u206D\u200C\u202A\u206E\u200C\u200C\u202A\u206B\u202A\u202B\u206D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		public override Sprite LoadSprite()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreBloodlustSeDef.\u202E\u202A\u206E\u202E\u206C\u206C\u206E\u200B\u206F\u202B\u200E\u200B\u206C\u200B\u200B\u202C\u202C\u200C\u202B\u206E\u200B\u202E\u200C\u206D\u206F\u200E\u202B\u202B\u200D\u200B\u202E\u206E\u202B\u202D\u206B\u202B\u206D\u206C\u200E\u202A\u202E(BepinexPlugin.sequenceTable, FlandreBloodlustSeDef.\u202E\u202D\u206C\u206F\u202E\u200D\u200F\u202A\u206C\u200F\u200C\u202A\u206C\u200B\u200B\u200B\u200D\u200D\u202C\u200E\u200B\u200F\u206A\u202C\u200F\u200E\u200B\u206D\u206F\u202D\u202B\u200B\u206A\u200C\u206C\u202D\u200F\u200D\u202E\u206E\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794));
		}

		static BatchLocalization \u206E\u200C\u206D\u206F\u200D\u206E\u206A\u202A\u202D\u200B\u200E\u206E\u206A\u200E\u206A\u200E\u202B\u200E\u202A\u200E\u202E\u206C\u206E\u206D\u202E\u206D\u206D\u206D\u206A\u206D\u200C\u202A\u206E\u200C\u200C\u202A\u206B\u202A\u202B\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202D\u206C\u206F\u202E\u200D\u200F\u202A\u206C\u200F\u200C\u202A\u206C\u200B\u200B\u200B\u200D\u200D\u202C\u200E\u200B\u200F\u206A\u202C\u200F\u200E\u200B\u206D\u206F\u202D\u202B\u200B\u206A\u200C\u206C\u202D\u200F\u200D\u202E\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u202A\u206E\u202E\u206C\u206C\u206E\u200B\u206F\u202B\u200E\u200B\u206C\u200B\u200B\u202C\u202C\u200C\u202B\u206E\u200B\u202E\u200C\u206D\u206F\u200E\u202B\u202B\u200D\u200B\u202E\u206E\u202B\u202D\u206B\u202B\u206D\u206C\u200E\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreBloodlustSeDef))]
		public sealed class FlandreBloodlustSe : StatusEffect
		{
			public float Value1
			{
				get
				{
					float num = (BepinexPlugin.AyaPhantasmMode.Value ? 0.5f : 1f);
					GameRunController gameRunController = FlandreBloodlustSeDef.FlandreBloodlustSe.\u200C\u206B\u206B\u202D\u206C\u200B\u200F\u202C\u202B\u206F\u200D\u200D\u206E\u200F\u200D\u200F\u200E\u200C\u206A\u202A\u200F\u206D\u200B\u206D\u206E\u202C\u200E\u206C\u202D\u206A\u206B\u206E\u202D\u206B\u206C\u202D\u200D\u206C\u202C\u202A\u202E(this);
					float? num2;
					if (gameRunController == null)
					{
						num2 = null;
					}
					else
					{
						num2 = new float?((from e in FlandreBloodlustSeDef.FlandreBloodlustSe.\u202B\u206B\u202C\u200C\u200D\u206D\u202A\u206A\u200F\u206D\u206A\u202A\u206A\u206F\u206B\u202A\u206F\u206F\u200C\u206D\u206F\u200D\u206A\u202E\u200E\u200F\u206D\u202A\u202D\u200B\u200F\u206A\u206E\u202C\u200D\u202B\u202A\u202E\u206A\u206C\u202E(FlandreBloodlustSeDef.FlandreBloodlustSe.\u206E\u206F\u206F\u200C\u202A\u202C\u202C\u200E\u206A\u206B\u206A\u206E\u206D\u206C\u206C\u206A\u202D\u200B\u202A\u200F\u206F\u202D\u200F\u202E\u200C\u206D\u200E\u202C\u202A\u202B\u206A\u200E\u206D\u202C\u200C\u200E\u202A\u202B\u206B\u206D\u202E(gameRunController))
							where e is FlandreTornTeddyBearDef.FlandreTornTeddyBear
							select e).Cast<FlandreTornTeddyBearDef.FlandreTornTeddyBear>().Sum((FlandreTornTeddyBearDef.FlandreTornTeddyBear e) => e.Value4));
					}
					float? num3 = num2;
					return num + num3.GetValueOrDefault();
				}
			}

			public int Value2
			{
				get
				{
					int num = (BepinexPlugin.AyaPhantasmMode.Value ? 50 : 100);
					GameRunController gameRunController = FlandreBloodlustSeDef.FlandreBloodlustSe.\u200C\u206B\u206B\u202D\u206C\u200B\u200F\u202C\u202B\u206F\u200D\u200D\u206E\u200F\u200D\u200F\u200E\u200C\u206A\u202A\u200F\u206D\u200B\u206D\u206E\u202C\u200E\u206C\u202D\u206A\u206B\u206E\u202D\u206B\u206C\u202D\u200D\u206C\u202C\u202A\u202E(this);
					float? num2;
					if (gameRunController == null)
					{
						num2 = null;
					}
					else
					{
						num2 = new float?((from e in FlandreBloodlustSeDef.FlandreBloodlustSe.\u202B\u206B\u202C\u200C\u200D\u206D\u202A\u206A\u200F\u206D\u206A\u202A\u206A\u206F\u206B\u202A\u206F\u206F\u200C\u206D\u206F\u200D\u206A\u202E\u200E\u200F\u206D\u202A\u202D\u200B\u200F\u206A\u206E\u202C\u200D\u202B\u202A\u202E\u206A\u206C\u202E(FlandreBloodlustSeDef.FlandreBloodlustSe.\u206E\u206F\u206F\u200C\u202A\u202C\u202C\u200E\u206A\u206B\u206A\u206E\u206D\u206C\u206C\u206A\u202D\u200B\u202A\u200F\u206F\u202D\u200F\u202E\u200C\u206D\u200E\u202C\u202A\u202B\u206A\u200E\u206D\u202C\u200C\u200E\u202A\u202B\u206B\u206D\u202E(gameRunController))
							where e is FlandreTornTeddyBearDef.FlandreTornTeddyBear
							select e).Cast<FlandreTornTeddyBearDef.FlandreTornTeddyBear>().Sum((FlandreTornTeddyBearDef.FlandreTornTeddyBear e) => e.Value4));
					}
					float? num3 = num2;
					return num + FlandreBloodlustSeDef.FlandreBloodlustSe.\u202D\u200B\u202C\u202A\u206A\u202C\u202D\u200D\u206E\u202B\u202D\u206D\u206E\u200E\u206F\u202E\u202B\u200F\u206A\u200B\u206B\u200F\u202A\u206D\u206A\u206A\u200F\u206A\u200F\u202C\u202D\u206A\u202E\u206E\u200E\u202D\u200F\u202A\u202D\u202A\u202E(num3.GetValueOrDefault() * 100f, MidpointRounding.AwayFromZero);
				}
			}

			public float Amount
			{
				get
				{
					GameRunController gameRunController = FlandreBloodlustSeDef.FlandreBloodlustSe.\u206A\u202C\u202A\u200C\u200B\u202A\u206B\u202C\u202A\u206F\u206A\u206F\u200B\u202B\u200E\u206F\u206B\u206E\u206B\u200B\u202B\u206E\u202B\u202B\u206D\u200B\u206E\u202B\u200C\u206E\u202E\u206E\u206E\u202A\u200E\u200D\u200D\u206B\u200C\u202B\u202E(Singleton<GameMaster>.Instance);
					bool flag;
					if (gameRunController == null)
					{
						flag = false;
					}
					else
					{
						BattleController battleController = FlandreBloodlustSeDef.FlandreBloodlustSe.\u202C\u200D\u206A\u200D\u202C\u206E\u200C\u206E\u200E\u202C\u206E\u200E\u200B\u200B\u202A\u200B\u202B\u206C\u202D\u206F\u202E\u202B\u202B\u206C\u206C\u202D\u202A\u200B\u206E\u206A\u202C\u200B\u206A\u202B\u206A\u200C\u200D\u202D\u200B\u206F\u202E(gameRunController);
						flag = ((battleController != null) ? new bool?(FlandreBloodlustSeDef.FlandreBloodlustSe.\u200C\u202D\u206B\u202D\u206F\u200E\u206F\u200C\u206E\u206A\u200E\u200D\u200E\u202B\u200D\u206D\u202C\u200B\u206A\u200B\u202B\u206C\u206C\u202E\u206A\u200E\u206B\u200E\u200E\u200B\u202E\u202A\u202A\u202C\u202B\u206F\u206E\u206E\u206D\u202E(battleController).HasStatusEffect<FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe>()) : null).GetValueOrDefault();
					}
					if (!flag)
					{
						for (;;)
						{
							int num = 1599934353;
							switch (((num - ((1971907072 - -795441913) * 1372285553 - -881554575 * 1655745649) - (-1386072860 - 933077569 + ~1768098289)) * -1252669461 - 101046837) % 3)
							{
							case 1:
								goto IL_009F;
							case 2:
								continue;
							}
							break;
						}
						goto IL_0129;
						IL_009F:
						float num2 = 1f;
						GameRunController gameRunController2 = FlandreBloodlustSeDef.FlandreBloodlustSe.\u206A\u202C\u202A\u200C\u200B\u202A\u206B\u202C\u202A\u206F\u206A\u206F\u200B\u202B\u200E\u206F\u206B\u206E\u206B\u200B\u202B\u206E\u202B\u202B\u206D\u200B\u206E\u202B\u200C\u206E\u202E\u206E\u206E\u202A\u200E\u200D\u200D\u206B\u200C\u202B\u202E(Singleton<GameMaster>.Instance);
						float num3 = (float)((gameRunController2 != null) ? new int?(FlandreBloodlustSeDef.FlandreBloodlustSe.\u202B\u202E\u202E\u206D\u202A\u206B\u202D\u202E\u206C\u206B\u200F\u206F\u200B\u202B\u206A\u200E\u202D\u206A\u200B\u200E\u202A\u202E\u202A\u202C\u200C\u202E\u202D\u202E\u200D\u206E\u200D\u200E\u206B\u206A\u206C\u202E\u206F\u206F\u200C\u202E(FlandreBloodlustSeDef.FlandreBloodlustSe.\u206E\u206F\u206F\u200C\u202A\u202C\u202C\u200E\u206A\u206B\u206A\u206E\u206D\u206C\u206C\u206A\u202D\u200B\u202A\u200F\u206F\u202D\u200F\u202E\u200C\u206D\u200E\u202C\u202A\u202B\u206A\u200E\u206D\u202C\u200C\u200E\u202A\u202B\u206B\u206D\u202E(gameRunController2))) : null).GetValueOrDefault(1);
						GameRunController gameRunController3 = FlandreBloodlustSeDef.FlandreBloodlustSe.\u206A\u202C\u202A\u200C\u200B\u202A\u206B\u202C\u202A\u206F\u206A\u206F\u200B\u202B\u200E\u206F\u206B\u206E\u206B\u200B\u202B\u206E\u202B\u202B\u206D\u200B\u206E\u202B\u200C\u206E\u202E\u206E\u206E\u202A\u200E\u200D\u200D\u206B\u200C\u202B\u202E(Singleton<GameMaster>.Instance);
						return (float)FlandreBloodlustSeDef.FlandreBloodlustSe.\u202D\u200B\u202C\u202A\u206A\u202C\u202D\u200D\u206E\u202B\u202D\u206D\u206E\u200E\u206F\u202E\u202B\u200F\u206A\u200B\u206B\u200F\u202A\u206D\u206A\u206A\u200F\u206A\u200F\u202C\u202D\u206A\u202E\u206E\u200E\u202D\u200F\u202A\u202D\u202A\u202E((num2 - num3 / (float)((gameRunController3 != null) ? new int?(FlandreBloodlustSeDef.FlandreBloodlustSe.\u200D\u200E\u200D\u202E\u200D\u202C\u200F\u206B\u206C\u206E\u200E\u206A\u202B\u206D\u206C\u200B\u200B\u200D\u206F\u206C\u206F\u202E\u206B\u200B\u206D\u200F\u206A\u206F\u200B\u206B\u206F\u202C\u200E\u202D\u202E\u200C\u200D\u206D\u206C\u206F\u202E(FlandreBloodlustSeDef.FlandreBloodlustSe.\u206E\u206F\u206F\u200C\u202A\u202C\u202C\u200E\u206A\u206B\u206A\u206E\u206D\u206C\u206C\u206A\u202D\u200B\u202A\u200F\u206F\u202D\u200F\u202E\u200C\u206D\u200E\u202C\u202A\u202B\u206A\u200E\u206D\u202C\u200C\u200E\u202A\u202B\u206B\u206D\u202E(gameRunController3))) : null).GetValueOrDefault(1)) * 100f, MidpointRounding.AwayFromZero) * this.Value1;
					}
					IL_0129:
					return (float)this.Value2;
				}
			}

			static GameRunController \u200C\u206B\u206B\u202D\u206C\u200B\u200F\u202C\u202B\u206F\u200D\u200D\u206E\u200F\u200D\u200F\u200E\u200C\u206A\u202A\u200F\u206D\u200B\u206D\u206E\u202C\u200E\u206C\u202D\u206A\u206B\u206E\u202D\u206B\u206C\u202D\u200D\u206C\u202C\u202A\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static PlayerUnit \u206E\u206F\u206F\u200C\u202A\u202C\u202C\u200E\u206A\u206B\u206A\u206E\u206D\u206C\u206C\u206A\u202D\u200B\u202A\u200F\u206F\u202D\u200F\u202E\u200C\u206D\u200E\u202C\u202A\u202B\u206A\u200E\u206D\u202C\u200C\u200E\u202A\u202B\u206B\u206D\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static IReadOnlyList<Exhibit> \u202B\u206B\u202C\u200C\u200D\u206D\u202A\u206A\u200F\u206D\u206A\u202A\u206A\u206F\u206B\u202A\u206F\u206F\u200C\u206D\u206F\u200D\u206A\u202E\u200E\u200F\u206D\u202A\u202D\u200B\u200F\u206A\u206E\u202C\u200D\u202B\u202A\u202E\u206A\u206C\u202E(PlayerUnit A_0)
			{
				return A_0.Exhibits;
			}

			static int \u202D\u200B\u202C\u202A\u206A\u202C\u202D\u200D\u206E\u202B\u202D\u206D\u206E\u200E\u206F\u202E\u202B\u200F\u206A\u200B\u206B\u200F\u202A\u206D\u206A\u206A\u200F\u206A\u200F\u202C\u202D\u206A\u202E\u206E\u200E\u202D\u200F\u202A\u202D\u202A\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}

			static GameRunController \u206A\u202C\u202A\u200C\u200B\u202A\u206B\u202C\u202A\u206F\u206A\u206F\u200B\u202B\u200E\u206F\u206B\u206E\u206B\u200B\u202B\u206E\u202B\u202B\u206D\u200B\u206E\u202B\u200C\u206E\u202E\u206E\u206E\u202A\u200E\u200D\u200D\u206B\u200C\u202B\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static BattleController \u202C\u200D\u206A\u200D\u202C\u206E\u200C\u206E\u200E\u202C\u206E\u200E\u200B\u200B\u202A\u200B\u202B\u206C\u202D\u206F\u202E\u202B\u202B\u206C\u206C\u202D\u202A\u200B\u206E\u206A\u202C\u200B\u206A\u202B\u206A\u200C\u200D\u202D\u200B\u206F\u202E(GameRunController A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200C\u202D\u206B\u202D\u206F\u200E\u206F\u200C\u206E\u206A\u200E\u200D\u200E\u202B\u200D\u206D\u202C\u200B\u206A\u200B\u202B\u206C\u206C\u202E\u206A\u200E\u206B\u200E\u200E\u200B\u202E\u202A\u202A\u202C\u202B\u206F\u206E\u206E\u206D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static int \u202B\u202E\u202E\u206D\u202A\u206B\u202D\u202E\u206C\u206B\u200F\u206F\u200B\u202B\u206A\u200E\u202D\u206A\u200B\u200E\u202A\u202E\u202A\u202C\u200C\u202E\u202D\u202E\u200D\u206E\u200D\u200E\u206B\u206A\u206C\u202E\u206F\u206F\u200C\u202E(Unit A_0)
			{
				return A_0.Hp;
			}

			static int \u200D\u200E\u200D\u202E\u200D\u202C\u200F\u206B\u206C\u206E\u200E\u206A\u202B\u206D\u206C\u200B\u200B\u200D\u206F\u206C\u206F\u202E\u206B\u200B\u206D\u200F\u206A\u206F\u200B\u206B\u206F\u202C\u200E\u202D\u202E\u200C\u200D\u206D\u206C\u206F\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}
		}
	}
}
