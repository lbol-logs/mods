using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.ExtraTurn;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreClockthatTicksAwaythePastSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1415429230);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreClockthatTicksAwaythePastSeDef.\u202E\u200B\u206E\u206C\u206D\u200F\u200F\u202D\u206D\u202E\u202B\u206A\u206C\u206B\u200C\u200E\u200D\u200D\u202C\u206A\u206B\u200F\u206F\u206A\u202D\u200C\u206F\u206E\u200C\u206E\u206A\u200E\u200B\u202C\u206C\u200F\u200E\u200F\u202C\u206C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreClockthatTicksAwaythePastSeDef.\u200B\u202A\u200D\u202E\u200C\u202B\u202A\u206F\u202E\u202D\u200F\u202D\u206F\u206C\u202D\u200B\u202E\u206F\u206B\u206F\u202C\u200E\u200F\u206A\u200C\u200D\u200C\u206C\u206A\u202E\u200B\u202C\u206F\u206A\u202C\u206F\u206A\u200D\u200F\u202A\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-493538006), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreClockthatTicksAwaythePastSeDef.\u200F\u206E\u206F\u206E\u206A\u202C\u206F\u200F\u206B\u200C\u202E\u202A\u200F\u206F\u200C\u206E\u200C\u206F\u206B\u206F\u202D\u202B\u200B\u206C\u200D\u202A\u206A\u202B\u206C\u202C\u206F\u202D\u200C\u200E\u200C\u206F\u200B\u200F\u202A\u202E(BepinexPlugin.sequenceTable, FlandreClockthatTicksAwaythePastSeDef.\u202D\u202C\u206A\u206C\u202D\u200D\u202A\u200F\u206B\u206B\u206A\u206F\u206E\u202D\u202D\u202A\u200E\u206F\u206C\u202C\u200B\u202B\u202E\u200F\u206D\u206E\u200B\u202E\u200D\u206D\u202C\u200D\u200B\u200F\u206E\u202B\u206D\u202D\u202B\u200C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, false, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u202E\u200B\u206E\u206C\u206D\u200F\u200F\u202D\u206D\u202E\u202B\u206A\u206C\u206B\u200C\u200E\u200D\u200D\u202C\u206A\u206B\u200F\u206F\u206A\u202D\u200C\u206F\u206E\u200C\u206E\u206A\u200E\u200B\u202C\u206C\u200F\u200E\u200F\u202C\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200B\u202A\u200D\u202E\u200C\u202B\u202A\u206F\u202E\u202D\u200F\u202D\u206F\u206C\u202D\u200B\u202E\u206F\u206B\u206F\u202C\u200E\u200F\u206A\u200C\u200D\u200C\u206C\u206A\u202E\u200B\u202C\u206F\u206A\u202C\u206F\u206A\u200D\u200F\u202A\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202D\u202C\u206A\u206C\u202D\u200D\u202A\u200F\u206B\u206B\u206A\u206F\u206E\u202D\u202D\u202A\u200E\u206F\u206C\u202C\u200B\u202B\u202E\u200F\u206D\u206E\u200B\u202E\u200D\u206D\u202C\u200D\u200B\u200F\u206E\u202B\u206D\u202D\u202B\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u206E\u206F\u206E\u206A\u202C\u206F\u200F\u206B\u200C\u202E\u202A\u200F\u206F\u200C\u206E\u200C\u206F\u206B\u206F\u202D\u202B\u200B\u206C\u200D\u202A\u206A\u202B\u206C\u202C\u206F\u202D\u200C\u200E\u200C\u206F\u200B\u200F\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreClockthatTicksAwaythePastSeDef))]
		public sealed class FlandreClockthatTicksAwaythePastSe : ExtraTurnPartner
		{
			protected override void OnAdded(Unit unit)
			{
				base.ThisTurnActivating = false;
				for (;;)
				{
					IL_0007:
					int num = 1000789551;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 ^ (-1617241393 ^ -2007507831) ^ (--1556775050 ^ ~1620154509)) * 1565471765 * -233607915)) % 4U)
						{
						case 0U:
							base.HandleOwnerEvent<CardEventArgs>(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u200B\u202B\u206D\u200C\u202C\u202E\u202D\u200C\u200C\u200F\u206C\u200B\u206C\u202C\u206B\u206A\u200F\u202D\u202A\u200D\u206A\u206C\u200C\u202A\u202D\u200B\u202B\u202E\u206B\u200F\u200F\u202E\u202C\u200F\u202C\u200E\u200C\u200F\u202D\u206E\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnPredraw));
							base.ReactOwnerEvent<UnitEventArgs>(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u202D\u200D\u202D\u200B\u200C\u206E\u206D\u202D\u202A\u206E\u202B\u200F\u202C\u206E\u202C\u202D\u200E\u200C\u200D\u200E\u206A\u200F\u202A\u202E\u200C\u206C\u206D\u202E\u202D\u202B\u200D\u206F\u202E\u206E\u202D\u200C\u200C\u200D\u200F\u200D\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206B\u206E\u206B\u206A\u200E\u200D\u206C\u202E\u202D\u200F\u200B\u202D\u206A\u206B\u200E\u202B\u206D\u202B\u202A\u200F\u206E\u200B\u206C\u206D\u206B\u200B\u200B\u202D\u200C\u202B\u200C\u206F\u202B\u206B\u206E\u206A\u200F\u202B\u200D\u206A\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
							num = (int)((num3 * 822035461U) ^ 717988488U);
							continue;
						case 1U:
							base.HandleOwnerEvent<UnitEventArgs>(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206B\u202E\u202C\u202D\u202D\u206F\u202C\u206F\u202D\u202D\u202D\u206C\u206A\u206D\u200E\u206D\u200B\u202D\u206D\u202C\u202A\u206A\u202C\u206C\u202B\u200D\u202D\u200B\u202B\u200B\u200F\u202E\u206C\u206C\u202E\u206E\u200B\u202E\u202B\u206B\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206C\u202C\u200B\u206E\u202C\u200C\u206E\u206B\u200F\u202A\u200B\u202D\u206C\u200D\u202E\u206B\u206A\u202D\u202C\u200D\u206B\u206B\u200E\u202D\u202A\u206F\u200F\u202D\u206D\u206F\u202A\u202C\u202D\u202C\u200C\u206C\u202E\u202C\u206A\u202C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(this))), delegate(UnitEventArgs _)
							{
								if (FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206C\u200E\u202B\u206F\u200D\u206C\u206D\u206C\u206A\u206F\u206C\u206A\u206F\u206A\u206C\u206A\u202A\u202A\u200C\u202E\u200E\u206D\u206B\u202C\u202C\u202B\u206A\u202D\u206A\u202B\u200F\u206E\u200B\u202C\u200F\u200B\u206C\u206B\u202C\u200C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206C\u202C\u200B\u206E\u202C\u200C\u206E\u206B\u200F\u202A\u200B\u202D\u206C\u200D\u202E\u206B\u206A\u202D\u202C\u200D\u206B\u206B\u200E\u202D\u202A\u206F\u200F\u202D\u206D\u206F\u202A\u202C\u202D\u202C\u200C\u206C\u202E\u202C\u206A\u202C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(this))))
								{
									for (;;)
									{
										IL_0015:
										int num4 = 1783874145;
										for (;;)
										{
											int num5 = num4;
											uint num6;
											switch ((num6 = (uint)(-(uint)(~(uint)(num5 * 659303601 - (729018687 + 655307703) * -593952543)))) % 5U)
											{
											case 1U:
												num4 = (int)(((!FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u202B\u206A\u202E\u206F\u200D\u200E\u202B\u206A\u200B\u200E\u202D\u200D\u202A\u206D\u200F\u206E\u206D\u206B\u206C\u206E\u202A\u206E\u200D\u202D\u202C\u200C\u206F\u202A\u202A\u200D\u200C\u200C\u202A\u202D\u206D\u202B\u200E\u206B\u200E\u206C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206C\u202C\u200B\u206E\u202C\u200C\u206E\u206B\u200F\u202A\u200B\u202D\u206C\u200D\u202E\u206B\u206A\u202D\u202C\u200D\u206B\u206B\u200E\u202D\u202A\u206F\u200F\u202D\u206D\u206F\u202A\u202C\u202D\u202C\u200C\u206C\u202E\u202C\u206A\u202C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(this)))) ? 2308396120U : 1056553429U) ^ (num6 * 2374817154U));
												continue;
											case 2U:
												goto IL_0015;
											case 3U:
												num4 = (int)(((FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206C\u202C\u200B\u206E\u202C\u200C\u206E\u206B\u200F\u202A\u200B\u202D\u206C\u200D\u202E\u206B\u206A\u202D\u202C\u200D\u206B\u206B\u200E\u202D\u202A\u206F\u200F\u202D\u206D\u206F\u202A\u202C\u202D\u202C\u200C\u206C\u202E\u202C\u206A\u202C\u202E(FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(this)).GetStatusEffectExtend<ExtraTurnPartner>() == this) ? 2686414054U : 2393577135U) ^ (num6 * 1482080326U));
												continue;
											case 4U:
												base.ThisTurnActivating = true;
												num4 = (int)((num6 * 1802375253U) ^ 1969413238U);
												continue;
											}
											goto Block_1;
										}
									}
									Block_1:;
								}
							});
							num = (int)((num3 * 1834198343U) ^ 2617046005U);
							continue;
						case 3U:
							goto IL_0007;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
			{
				FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.<OnOwnerTurnStarted>d__1 <OnOwnerTurnStarted>d__ = new FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.<OnOwnerTurnStarted>d__1(-2);
				<OnOwnerTurnStarted>d__.<>4__this = this;
				return <OnOwnerTurnStarted>d__;
			}

			private void OnPredraw(CardEventArgs args)
			{
				if (base.ThisTurnActivating)
				{
					for (;;)
					{
						IL_0008:
						int num = -1170502276;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(-num2) * -1136231219 * 872896915)) % 4U)
							{
							case 1U:
								num = (int)(((FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u206E\u200D\u200D\u206F\u206C\u206A\u202A\u202B\u202E\u206B\u206F\u200F\u200D\u202D\u200F\u206B\u200E\u206D\u206C\u206D\u202D\u202B\u206C\u202C\u200D\u202B\u206A\u206E\u202E\u206A\u200E\u206E\u200E\u206C\u206D\u206A\u206A\u206E\u200F\u206C\u202E(args) == ActionCause.TurnStart) ? 3946574819U : 2475827689U) ^ (num3 * 3113947588U));
								continue;
							case 2U:
								FlandreClockthatTicksAwaythePastSeDef.FlandreClockthatTicksAwaythePastSe.\u200B\u202B\u206F\u200C\u206F\u200D\u202D\u206F\u200B\u206A\u200E\u206B\u202B\u200E\u206B\u206B\u206D\u200D\u206B\u206C\u206F\u202A\u200D\u206A\u206D\u206B\u202D\u206A\u206D\u202C\u200B\u202B\u206A\u200D\u200D\u200E\u206D\u202D\u202D\u202B\u202E(args, this);
								num = (int)((num3 * 2134252298U) ^ 424746969U);
								continue;
							case 3U:
								goto IL_0008;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			static BattleController \u206A\u200D\u200F\u202B\u200F\u206D\u206F\u206C\u206F\u206B\u200F\u202C\u206D\u202B\u200C\u202D\u202D\u200F\u200F\u200B\u206F\u206E\u200D\u206B\u202D\u206C\u202B\u200E\u206A\u206B\u206A\u202B\u206E\u200D\u200B\u200E\u200E\u202D\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206C\u202C\u200B\u206E\u202C\u200C\u206E\u206B\u200F\u202A\u200B\u202D\u206C\u200D\u202E\u206B\u206A\u202D\u202C\u200D\u206B\u206B\u200E\u202D\u202A\u206F\u200F\u202D\u206D\u206F\u202A\u202C\u202D\u202C\u200C\u206C\u202E\u202C\u206A\u202C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206B\u202E\u202C\u202D\u202D\u206F\u202C\u206F\u202D\u202D\u202D\u206C\u206A\u206D\u200E\u206D\u200B\u202D\u206D\u202C\u202A\u206A\u202C\u206C\u202B\u200D\u202D\u200B\u202B\u200B\u200F\u202E\u206C\u206C\u202E\u206E\u200B\u202E\u202B\u206B\u202E(Unit A_0)
			{
				return A_0.TurnStarting;
			}

			static GameEvent<CardEventArgs> \u200B\u202B\u206D\u200C\u202C\u202E\u202D\u200C\u200C\u200F\u206C\u200B\u206C\u202C\u206B\u206A\u200F\u202D\u202A\u200D\u206A\u206C\u200C\u202A\u202D\u200B\u202B\u202E\u206B\u200F\u200F\u202E\u202C\u200F\u202C\u200E\u200C\u200F\u202D\u206E\u202E(BattleController A_0)
			{
				return A_0.Predraw;
			}

			static Unit \u206B\u206E\u206B\u206A\u200E\u200D\u206C\u202E\u202D\u200F\u200B\u202D\u206A\u206B\u200E\u202B\u206D\u202B\u202A\u200F\u206E\u200B\u206C\u206D\u206B\u200B\u200B\u202D\u200C\u202B\u200C\u206F\u202B\u206B\u206E\u206A\u200F\u202B\u200D\u206A\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u202D\u200D\u202D\u200B\u200C\u206E\u206D\u202D\u202A\u206E\u202B\u200F\u202C\u206E\u202C\u202D\u200E\u200C\u200D\u200E\u206A\u200F\u202A\u202E\u200C\u206C\u206D\u202E\u202D\u202B\u200D\u206F\u202E\u206E\u202D\u200C\u200C\u200D\u200F\u200D\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static ActionCause \u206E\u200D\u200D\u206F\u206C\u206A\u202A\u202B\u202E\u206B\u206F\u200F\u200D\u202D\u200F\u206B\u200E\u206D\u206C\u206D\u202D\u202B\u206C\u202C\u200D\u202B\u206A\u206E\u202E\u206A\u200E\u206E\u200E\u206C\u206D\u206A\u206A\u206E\u200F\u206C\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			static void \u200B\u202B\u206F\u200C\u206F\u200D\u202D\u206F\u200B\u206A\u200E\u206B\u202B\u200E\u206B\u206B\u206D\u200D\u206B\u206C\u206F\u202A\u200D\u206A\u206D\u206B\u202D\u206A\u206D\u202C\u200B\u202B\u206A\u200D\u200D\u200E\u206D\u202D\u202D\u202B\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static bool \u206C\u200E\u202B\u206F\u200D\u206C\u206D\u206C\u206A\u206F\u206C\u206A\u206F\u206A\u206C\u206A\u202A\u202A\u200C\u202E\u200E\u206D\u206B\u202C\u202C\u202B\u206A\u202D\u206A\u202B\u200F\u206E\u200B\u202C\u200F\u200B\u206C\u206B\u202C\u200C\u202E(Unit A_0)
			{
				return A_0.IsExtraTurn;
			}

			static bool \u202B\u206A\u202E\u206F\u200D\u200E\u202B\u206A\u200B\u200E\u202D\u200D\u202A\u206D\u200F\u206E\u206D\u206B\u206C\u206E\u202A\u206E\u200D\u202D\u202C\u200C\u206F\u202A\u202A\u200D\u200C\u200C\u202A\u202D\u206D\u202B\u200E\u206B\u200E\u206C\u202E(PlayerUnit A_0)
			{
				return A_0.IsSuperExtraTurn;
			}
		}
	}
}
