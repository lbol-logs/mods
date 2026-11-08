using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreMPEnfantTerribleSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-581485051);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMPEnfantTerribleSeDef.\u206B\u202B\u202A\u206D\u206B\u206D\u202E\u200C\u202E\u202A\u206A\u200B\u200C\u200D\u206C\u202C\u200C\u200C\u202A\u202B\u202D\u206F\u200B\u200F\u202D\u200F\u206F\u202D\u206E\u200D\u206E\u202A\u202C\u200C\u202A\u200D\u206E\u202E\u206B\u206A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreMPEnfantTerribleSeDef.\u206D\u206D\u206B\u202A\u200C\u206C\u206C\u200C\u202A\u200D\u200F\u200F\u200E\u206E\u202A\u202E\u200F\u206F\u202A\u202D\u200E\u202D\u200F\u202D\u206F\u202D\u206B\u202E\u200C\u206E\u200F\u202A\u200B\u206F\u202D\u202E\u202B\u200E\u206A\u202B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-307830919), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreMPEnfantTerribleSeDef.\u202C\u206A\u202E\u206E\u200F\u200E\u202E\u202D\u206D\u206E\u200F\u202E\u200F\u206A\u200E\u200E\u206E\u206D\u202D\u202B\u200D\u202B\u200F\u200D\u206A\u202A\u206E\u200E\u202E\u200F\u206D\u200C\u206E\u206D\u206D\u206D\u200D\u206A\u202D\u200C\u202E(BepinexPlugin.sequenceTable, FlandreMPEnfantTerribleSeDef.\u200F\u202C\u206C\u202E\u202C\u202A\u202C\u206A\u200D\u206A\u206D\u200E\u206F\u200F\u206C\u202E\u206A\u200E\u200C\u202B\u202C\u202C\u206D\u206A\u202C\u202A\u206C\u206C\u200D\u202D\u206F\u200D\u202C\u206B\u202D\u206C\u202E\u200E\u200D\u202E\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 8, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), true, new StackType?(StackType.Add), DurationDecreaseTiming.EndTurnForExtra | DurationDecreaseTiming.RoundEnd, false, new StackType?(StackType.Keep), new StackType?(StackType.Max), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1234937961), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u206B\u202B\u202A\u206D\u206B\u206D\u202E\u200C\u202E\u202A\u206A\u200B\u200C\u200D\u206C\u202C\u200C\u200C\u202A\u202B\u202D\u206F\u200B\u200F\u202D\u200F\u206F\u202D\u206E\u200D\u206E\u202A\u202C\u200C\u202A\u200D\u206E\u202E\u206B\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206D\u206D\u206B\u202A\u200C\u206C\u206C\u200C\u202A\u200D\u200F\u200F\u200E\u206E\u202A\u202E\u200F\u206F\u202A\u202D\u200E\u202D\u200F\u202D\u206F\u202D\u206B\u202E\u200C\u206E\u200F\u202A\u200B\u206F\u202D\u202E\u202B\u200E\u206A\u202B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200F\u202C\u206C\u202E\u202C\u202A\u202C\u206A\u200D\u206A\u206D\u200E\u206F\u200F\u206C\u202E\u206A\u200E\u200C\u202B\u202C\u202C\u206D\u206A\u202C\u202A\u206C\u206C\u200D\u202D\u206F\u200D\u202C\u206B\u202D\u206C\u202E\u200E\u200D\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u206A\u202E\u206E\u200F\u200E\u202E\u202D\u206D\u206E\u200F\u202E\u200F\u206A\u200E\u200E\u206E\u206D\u202D\u202B\u200D\u202B\u200F\u200D\u206A\u202A\u206E\u200E\u202E\u200F\u206D\u200C\u206E\u206D\u206D\u206D\u200D\u206A\u202D\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMPEnfantTerribleSeDef))]
		public sealed class FlandreMPEnfantTerribleSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.HandleOwnerEvent<DamageDealingEventArgs>(FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u202B\u206C\u200B\u200C\u202C\u200E\u206B\u206F\u202D\u202B\u202A\u206F\u200C\u202A\u200D\u202B\u206E\u200D\u200C\u200C\u202C\u202D\u202A\u202C\u200C\u206C\u200F\u206B\u202C\u206C\u206E\u206D\u200E\u206D\u206A\u202C\u206E\u200D\u206D\u206B\u202E(unit), new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
			}

			private void OnDamageDealing(DamageDealingEventArgs args)
			{
				DamageInfo damageInfo = FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u200F\u206C\u206A\u202B\u200D\u200D\u202D\u200F\u206A\u200E\u206D\u206F\u206A\u202A\u202B\u202A\u200C\u200D\u200E\u206C\u200B\u202A\u206B\u206D\u206A\u202E\u202A\u202B\u202D\u200C\u200E\u202B\u206A\u202C\u206D\u200E\u206B\u200C\u206B\u200F\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = 1790516774;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~num2 - ~(-837247057 * -100561210))) % 6U)
						{
						case 1U:
							FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u200F\u206A\u202D\u202D\u200B\u206E\u206F\u202B\u202D\u200C\u200C\u202A\u202A\u202E\u202A\u206A\u200B\u206E\u206E\u202E\u206A\u200B\u202E\u200F\u206B\u200E\u202C\u206C\u200C\u206F\u206D\u202E\u200E\u206B\u202D\u200B\u200B\u206B\u202D\u200C\u202E(args, this);
							num = (int)((num3 * 1441302425U) ^ 1599303425U);
							continue;
						case 2U:
							num = (int)(((damageInfo.DamageType != DamageType.Attack) ? 2319435256U : 3775424224U) ^ (num3 * 1062653422U));
							continue;
						case 3U:
							goto IL_0007;
						case 4U:
							damageInfo.Damage = damageInfo.Amount * (1f - (float)FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u202A\u200D\u206F\u202B\u200B\u200B\u200B\u202E\u202C\u206B\u206E\u200F\u200D\u202C\u200B\u202A\u200C\u200D\u206D\u200D\u200C\u206C\u200F\u202C\u202C\u206E\u202A\u200F\u202A\u202D\u200F\u206F\u206E\u206C\u202A\u200B\u206D\u202A\u206B\u202C\u202E(FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u202B\u200B\u202A\u200D\u202C\u200B\u206F\u200F\u200E\u202E\u200B\u206B\u200C\u200D\u200C\u202A\u200E\u206A\u202A\u202B\u202D\u206A\u206E\u200F\u202C\u200B\u202E\u206E\u200E\u206B\u206B\u200C\u200B\u206A\u206D\u206D\u206C\u200D\u206B\u202C\u202E(this), 100) / 100f);
							num = (int)((num3 * 4067607631U) ^ 3793037573U);
							continue;
						case 5U:
							FlandreMPEnfantTerribleSeDef.FlandreMPEnfantTerribleSe.\u206D\u202B\u206D\u202A\u206B\u202C\u206B\u206E\u202A\u206B\u202C\u206D\u202E\u206E\u206A\u200B\u202A\u202C\u206E\u200C\u200E\u206B\u206B\u206A\u200E\u206D\u206F\u206F\u200C\u200B\u200B\u206C\u200F\u200F\u206E\u202C\u206A\u200C\u206B\u202B\u202E(args, damageInfo);
							num = (int)((num3 * 3304051366U) ^ 1652852363U);
							continue;
						}
						return;
					}
				}
			}

			static GameEvent<DamageDealingEventArgs> \u202B\u206C\u200B\u200C\u202C\u200E\u206B\u206F\u202D\u202B\u202A\u206F\u200C\u202A\u200D\u202B\u206E\u200D\u200C\u200C\u202C\u202D\u202A\u202C\u200C\u206C\u200F\u206B\u202C\u206C\u206E\u206D\u200E\u206D\u206A\u202C\u206E\u200D\u206D\u206B\u202E(Unit A_0)
			{
				return A_0.DamageDealing;
			}

			static DamageInfo \u200F\u206C\u206A\u202B\u200D\u200D\u202D\u200F\u206A\u200E\u206D\u206F\u206A\u202A\u202B\u202A\u200C\u200D\u200E\u206C\u200B\u202A\u206B\u206D\u206A\u202E\u202A\u202B\u202D\u200C\u200E\u202B\u206A\u202C\u206D\u200E\u206B\u200C\u206B\u200F\u202E(DamageDealingEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static int \u202B\u200B\u202A\u200D\u202C\u200B\u206F\u200F\u200E\u202E\u200B\u206B\u200C\u200D\u200C\u202A\u200E\u206A\u202A\u202B\u202D\u206A\u206E\u200F\u202C\u200B\u202E\u206E\u200E\u206B\u206B\u200C\u200B\u206A\u206D\u206D\u206C\u200D\u206B\u202C\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}

			static int \u202A\u200D\u206F\u202B\u200B\u200B\u200B\u202E\u202C\u206B\u206E\u200F\u200D\u202C\u200B\u202A\u200C\u200D\u206D\u200D\u200C\u206C\u200F\u202C\u202C\u206E\u202A\u200F\u202A\u202D\u200F\u206F\u206E\u206C\u202A\u200B\u206D\u202A\u206B\u202C\u202E(int A_0, int A_1)
			{
				return Math.Min(A_0, A_1);
			}

			static void \u206D\u202B\u206D\u202A\u206B\u202C\u206B\u206E\u202A\u206B\u202C\u206D\u202E\u206E\u206A\u200B\u202A\u202C\u206E\u200C\u200E\u206B\u206B\u206A\u200E\u206D\u206F\u206F\u200C\u200B\u200B\u206C\u200F\u200F\u206E\u202C\u206A\u200C\u206B\u202B\u202E(DamageDealingEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200F\u206A\u202D\u202D\u200B\u206E\u206F\u202B\u202D\u200C\u200C\u202A\u202A\u202E\u202A\u206A\u200B\u206E\u206E\u202E\u206A\u200B\u202E\u200F\u206B\u200E\u202C\u206C\u200C\u206F\u206D\u202E\u200E\u206B\u202D\u200B\u200B\u206B\u202D\u200C\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}
		}
	}
}
