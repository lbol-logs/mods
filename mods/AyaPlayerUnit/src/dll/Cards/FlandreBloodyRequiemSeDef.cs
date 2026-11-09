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
	public sealed class FlandreBloodyRequiemSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1837308972);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreBloodyRequiemSeDef.\u200D\u200E\u206B\u200E\u206B\u206D\u200D\u200B\u200B\u206D\u200D\u200F\u206D\u206F\u202D\u202B\u206E\u206B\u200E\u200B\u200C\u206D\u202C\u206E\u206A\u202C\u206E\u200C\u206F\u202C\u200D\u202A\u206C\u206E\u200F\u202D\u202A\u206C\u200C\u202C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreBloodyRequiemSeDef.\u200F\u200E\u202C\u206C\u200E\u200C\u200C\u206F\u200B\u202C\u202D\u200F\u206B\u206B\u200D\u206E\u200F\u206C\u206B\u202A\u202A\u200D\u202E\u206E\u202D\u200D\u200F\u200D\u206F\u202B\u202A\u200E\u200F\u206D\u202E\u200D\u206F\u206E\u206C\u200E\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-425413489), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreBloodyRequiemSeDef.\u200E\u200E\u200D\u206D\u202D\u206B\u206C\u200C\u200D\u202E\u200F\u200D\u202C\u200E\u200C\u200D\u200C\u206E\u206C\u206E\u202D\u206D\u200F\u202C\u200D\u206A\u202B\u200E\u202D\u206A\u200D\u202E\u206C\u200D\u206F\u200D\u202E\u202E\u206E\u206F\u202E(BepinexPlugin.sequenceTable, FlandreBloodyRequiemSeDef.\u206C\u200E\u202B\u206A\u202A\u200F\u206A\u202B\u202E\u200D\u202A\u200C\u206B\u200F\u206F\u206E\u200B\u206D\u200B\u200F\u206A\u202C\u200D\u200B\u206D\u206D\u202C\u202A\u200D\u206F\u202B\u200F\u206C\u206F\u202D\u206A\u206A\u200D\u200E\u206C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1222837215), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u200D\u200E\u206B\u200E\u206B\u206D\u200D\u200B\u200B\u206D\u200D\u200F\u206D\u206F\u202D\u202B\u206E\u206B\u200E\u200B\u200C\u206D\u202C\u206E\u206A\u202C\u206E\u200C\u206F\u202C\u200D\u202A\u206C\u206E\u200F\u202D\u202A\u206C\u200C\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200F\u200E\u202C\u206C\u200E\u200C\u200C\u206F\u200B\u202C\u202D\u200F\u206B\u206B\u200D\u206E\u200F\u206C\u206B\u202A\u202A\u200D\u202E\u206E\u202D\u200D\u200F\u200D\u206F\u202B\u202A\u200E\u200F\u206D\u202E\u200D\u206F\u206E\u206C\u200E\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206C\u200E\u202B\u206A\u202A\u200F\u206A\u202B\u202E\u200D\u202A\u200C\u206B\u200F\u206F\u206E\u200B\u206D\u200B\u200F\u206A\u202C\u200D\u200B\u206D\u206D\u202C\u202A\u200D\u206F\u202B\u200F\u206C\u206F\u202D\u206A\u206A\u200D\u200E\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u200E\u200D\u206D\u202D\u206B\u206C\u200C\u200D\u202E\u200F\u200D\u202C\u200E\u200C\u200D\u200C\u206E\u206C\u206E\u202D\u206D\u200F\u202C\u200D\u206A\u202B\u200E\u202D\u206A\u200D\u202E\u206C\u200D\u206F\u200D\u202E\u202E\u206E\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreBloodyRequiemSeDef))]
		public sealed class FlandreBloodyRequiemSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				if (FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u200E\u202D\u202D\u202C\u206E\u206B\u202D\u202B\u206A\u200C\u200C\u206C\u206A\u200D\u206C\u202D\u200F\u202D\u206D\u206C\u206D\u200E\u206F\u202A\u200B\u202B\u206B\u202E\u202C\u200E\u206D\u206B\u206B\u200F\u206E\u200C\u202B\u202D\u202A\u206D\u202E(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206B\u200C\u200C\u206C\u200E\u206B\u206B\u206E\u206E\u206E\u200C\u200C\u206F\u206F\u206C\u202C\u200D\u202C\u202A\u200C\u206E\u202C\u206D\u206F\u206D\u202E\u202E\u206E\u206A\u206F\u206A\u206C\u200D\u202A\u202D\u202B\u200D\u200D\u206D\u206D\u202E(this)) is FlandrePlayerUnitDef.FlandrePlayerUnit)
				{
					IEnumerator<Card> enumerator = (from c in FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u202B\u202E\u200D\u206B\u206A\u202B\u206A\u206D\u200F\u202D\u200E\u202C\u200C\u200C\u202D\u202C\u206B\u200F\u200B\u200C\u200D\u206A\u206B\u206A\u200B\u200B\u202B\u206F\u200E\u206E\u200E\u202E\u200F\u202C\u206D\u200C\u200F\u202B\u202E\u200E\u202E(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206B\u200C\u200C\u206C\u200E\u206B\u206B\u206E\u206E\u206E\u200C\u200C\u206F\u206F\u206C\u202C\u200D\u202C\u202A\u200C\u206E\u202C\u206D\u206F\u206D\u202E\u202E\u206E\u206A\u206F\u206A\u206C\u200D\u202A\u202D\u202B\u200D\u200D\u206D\u206D\u202E(this))
						where c is FlandreCard
						select c).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0078:
							int num = ((!FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206E\u206E\u206A\u200D\u206D\u202B\u206D\u200D\u200E\u200D\u202E\u206F\u200B\u202C\u202D\u206B\u206F\u202A\u200F\u200D\u200C\u206B\u206B\u206C\u206D\u202C\u200E\u206E\u200C\u200F\u206A\u202C\u202C\u202E\u206B\u206E\u200D\u206F\u202A\u206C\u202E(enumerator)) ? 1400809797 : 295276780);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 6U)
								{
								case 0U:
									num = 295276780;
									continue;
								case 1U:
								{
									FlandreCard flandreCard;
									num = (int)(((!flandreCard.IsBloodlust) ? 1118118830U : 619184439U) ^ (num3 * 977825644U));
									continue;
								}
								case 2U:
								{
									FlandreCard flandreCard;
									flandreCard.IsTempBloodlust = true;
									num = (int)((num3 * 2795028670U) ^ 2583895U);
									continue;
								}
								case 4U:
								{
									FlandreCard flandreCard = (FlandreCard)enumerator.Current;
									num = 1252268893;
									continue;
								}
								case 5U:
									goto IL_0078;
								}
								goto Block_5;
							}
						}
						Block_5:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_00E3:
								int num4 = 1196476981;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 3U)
									{
									case 1U:
										FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206E\u206A\u206F\u200B\u200E\u206F\u202D\u200B\u206F\u200B\u202C\u206A\u206B\u202E\u202A\u202B\u206B\u206B\u200C\u200D\u200E\u202D\u202B\u206A\u206B\u202E\u200F\u200C\u200C\u200E\u200F\u206B\u202C\u202A\u206F\u206B\u206A\u202D\u200E\u200D\u202E(enumerator);
										num4 = (int)((num3 * 2281327365U) ^ 1695351323U);
										continue;
									case 2U:
										goto IL_00E3;
									}
									goto Block_9;
								}
							}
							Block_9:;
						}
					}
				}
				base.ReactOwnerEvent<UnitEventArgs>(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206B\u206B\u200C\u202B\u206C\u202A\u200E\u202E\u206E\u202D\u200D\u202B\u202B\u206B\u206A\u206C\u206B\u206E\u206E\u202B\u202C\u206E\u200B\u206F\u202B\u206C\u202E\u206D\u202E\u200D\u206B\u202C\u200E\u206B\u202B\u206B\u202D\u206B\u206F\u206B\u202E(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u200E\u202D\u202D\u202C\u206E\u206B\u202D\u202B\u206A\u200C\u200C\u206C\u206A\u200D\u206C\u202D\u200F\u202D\u206D\u206C\u206D\u200E\u206F\u202A\u200B\u202B\u206B\u202E\u202C\u200E\u206D\u206B\u206B\u200F\u206E\u200C\u202B\u202D\u202A\u206D\u202E(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206B\u200C\u200C\u206C\u200E\u206B\u206B\u206E\u206E\u206E\u200C\u200C\u206F\u206F\u206C\u202C\u200D\u202C\u202A\u200C\u206E\u202C\u206D\u206F\u206D\u202E\u202E\u206E\u206A\u206F\u206A\u206C\u200D\u202A\u202D\u202B\u200D\u200D\u206D\u206D\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			}

			protected override void OnRemoved(Unit unit)
			{
				IEnumerator<Card> enumerator = (from c in FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u202B\u202E\u200D\u206B\u206A\u202B\u206A\u206D\u200F\u202D\u200E\u202C\u200C\u200C\u202D\u202C\u206B\u200F\u200B\u200C\u200D\u206A\u206B\u206A\u200B\u200B\u202B\u206F\u200E\u206E\u200E\u202E\u200F\u202C\u206D\u200C\u200F\u202B\u202E\u200E\u202E(FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206B\u200C\u200C\u206C\u200E\u206B\u206B\u206E\u206E\u206E\u200C\u200C\u206F\u206F\u206C\u202C\u200D\u202C\u202A\u200C\u206E\u202C\u206D\u206F\u206D\u202E\u202E\u206E\u206A\u206F\u206A\u206C\u200D\u202A\u202D\u202B\u200D\u200D\u206D\u206D\u202E(this))
					where c is FlandreCard
					select c).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0096:
						int num = ((!FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206E\u206E\u206A\u200D\u206D\u202B\u206D\u200D\u200E\u200D\u202E\u206F\u200B\u202C\u202D\u206B\u206F\u202A\u200F\u200D\u200C\u206B\u206B\u206C\u206D\u202C\u200E\u206E\u200C\u200F\u206A\u202C\u202C\u202E\u206B\u206E\u200D\u206F\u202A\u206C\u202E(enumerator)) ? (-1816935778) : (-1783145328));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-1706144328 - (--1922761147 - ~num2 * 765628781))) % 5U)
							{
							case 1U:
								goto IL_0096;
							case 2U:
							{
								FlandreCard flandreCard;
								flandreCard.IsTempBloodlust = false;
								num = (int)((num3 * 1447014497U) ^ 4146245475U);
								continue;
							}
							case 3U:
							{
								FlandreCard flandreCard = (FlandreCard)enumerator.Current;
								num = (flandreCard.IsTempBloodlust ? 1779651479 : 1377175878);
								continue;
							}
							case 4U:
								num = -1783145328;
								continue;
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
							IL_00CD:
							int num4 = 1401113990;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-1706144328 - (--1922761147 - ~num2 * 765628781))) % 3U)
								{
								case 0U:
									goto IL_00CD;
								case 2U:
									FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.\u206E\u206A\u206F\u200B\u200E\u206F\u202D\u200B\u206F\u200B\u202C\u206A\u206B\u202E\u202A\u202B\u206B\u206B\u200C\u200D\u200E\u202D\u202B\u206A\u206B\u202E\u200F\u200C\u200C\u200E\u200F\u206B\u202C\u202A\u206F\u206B\u206A\u202D\u200E\u200D\u202E(enumerator);
									num4 = (int)((num3 * 818754622U) ^ 1294566409U);
									continue;
								}
								goto Block_8;
							}
						}
						Block_8:;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.<OnPlayerTurnStarted>d__2 <OnPlayerTurnStarted>d__ = new FlandreBloodyRequiemSeDef.FlandreBloodyRequiemSe.<OnPlayerTurnStarted>d__2(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			static BattleController \u206B\u200C\u200C\u206C\u200E\u206B\u206B\u206E\u206E\u206E\u200C\u200C\u206F\u206F\u206C\u202C\u200D\u202C\u202A\u200C\u206E\u202C\u206D\u206F\u206D\u202E\u202E\u206E\u206A\u206F\u206A\u206C\u200D\u202A\u202D\u202B\u200D\u200D\u206D\u206D\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200E\u202D\u202D\u202C\u206E\u206B\u202D\u202B\u206A\u200C\u200C\u206C\u206A\u200D\u206C\u202D\u200F\u202D\u206D\u206C\u206D\u200E\u206F\u202A\u200B\u202B\u206B\u202E\u202C\u200E\u206D\u206B\u206B\u200F\u206E\u200C\u202B\u202D\u202A\u206D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static IEnumerable<Card> \u202B\u202E\u200D\u206B\u206A\u202B\u206A\u206D\u200F\u202D\u200E\u202C\u200C\u200C\u202D\u202C\u206B\u200F\u200B\u200C\u200D\u206A\u206B\u206A\u200B\u200B\u202B\u206F\u200E\u206E\u200E\u202E\u200F\u202C\u206D\u200C\u200F\u202B\u202E\u200E\u202E(BattleController A_0)
			{
				return A_0.EnumerateAllCards();
			}

			static bool \u206E\u206E\u206A\u200D\u206D\u202B\u206D\u200D\u200E\u200D\u202E\u206F\u200B\u202C\u202D\u206B\u206F\u202A\u200F\u200D\u200C\u206B\u206B\u206C\u206D\u202C\u200E\u206E\u200C\u200F\u206A\u202C\u202C\u202E\u206B\u206E\u200D\u206F\u202A\u206C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u206A\u206F\u200B\u200E\u206F\u202D\u200B\u206F\u200B\u202C\u206A\u206B\u202E\u202A\u202B\u206B\u206B\u200C\u200D\u200E\u202D\u202B\u206A\u206B\u202E\u200F\u200C\u200C\u200E\u200F\u206B\u202C\u202A\u206F\u206B\u206A\u202D\u200E\u200D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u206B\u206B\u200C\u202B\u206C\u202A\u200E\u202E\u206E\u202D\u200D\u202B\u202B\u206B\u206A\u206C\u206B\u206E\u206E\u202B\u202C\u206E\u200B\u206F\u202B\u206C\u202E\u206D\u202E\u200D\u206B\u202C\u200E\u206B\u202B\u206B\u202D\u206B\u206F\u206B\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}
		}
	}
}
