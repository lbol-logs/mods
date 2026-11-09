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
	public sealed class AyaWindGodsLeafVeilingSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(763257585);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaWindGodsLeafVeilingSeDef.\u206D\u200C\u202B\u200B\u206F\u202C\u200E\u206A\u202B\u202B\u206D\u202B\u206F\u206E\u200C\u200E\u200B\u202D\u202C\u206E\u206F\u202E\u202E\u206C\u206F\u200D\u202C\u200B\u202B\u200F\u202C\u202D\u206A\u200D\u200E\u206D\u202B\u202E\u200C\u202C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaWindGodsLeafVeilingSeDef.\u206E\u206C\u206F\u202E\u206F\u206F\u200C\u206F\u202C\u206A\u200F\u206B\u202A\u200C\u200E\u200D\u202D\u200B\u202B\u202C\u202B\u202E\u206C\u206E\u206F\u202D\u206B\u202E\u206F\u202A\u202E\u200E\u206E\u202C\u206E\u202E\u202C\u206A\u200E\u206F\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(57877582), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaWindGodsLeafVeilingSeDef.\u202E\u200F\u206A\u200F\u200E\u202B\u202E\u202D\u206E\u202D\u206A\u206C\u202A\u206B\u202B\u202C\u206F\u202B\u200C\u206B\u200E\u200C\u206D\u206C\u202B\u206F\u202A\u202A\u206A\u206F\u206C\u206E\u200B\u202A\u202E\u206E\u200C\u202B\u202E\u202D\u202E(BepinexPlugin.sequenceTable, AyaWindGodsLeafVeilingSeDef.\u200C\u202A\u200E\u202C\u202E\u202C\u206F\u206C\u200D\u202D\u200B\u200F\u200B\u206E\u206A\u206D\u200C\u206F\u206E\u206B\u202C\u206C\u200B\u200E\u202B\u202E\u200B\u202A\u202A\u200C\u202C\u206A\u202E\u206D\u202E\u200B\u206C\u202B\u200C\u206C\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 99, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Accuracy, new List<string>(), null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-607043847), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u206D\u200C\u202B\u200B\u206F\u202C\u200E\u206A\u202B\u202B\u206D\u202B\u206F\u206E\u200C\u200E\u200B\u202D\u202C\u206E\u206F\u202E\u202E\u206C\u206F\u200D\u202C\u200B\u202B\u200F\u202C\u202D\u206A\u200D\u200E\u206D\u202B\u202E\u200C\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206E\u206C\u206F\u202E\u206F\u206F\u200C\u206F\u202C\u206A\u200F\u206B\u202A\u200C\u200E\u200D\u202D\u200B\u202B\u202C\u202B\u202E\u206C\u206E\u206F\u202D\u206B\u202E\u206F\u202A\u202E\u200E\u206E\u202C\u206E\u202E\u202C\u206A\u200E\u206F\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200C\u202A\u200E\u202C\u202E\u202C\u206F\u206C\u200D\u202D\u200B\u200F\u200B\u206E\u206A\u206D\u200C\u206F\u206E\u206B\u202C\u206C\u200B\u200E\u202B\u202E\u200B\u202A\u202A\u200C\u202C\u206A\u202E\u206D\u202E\u200B\u206C\u202B\u200C\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u200F\u206A\u200F\u200E\u202B\u202E\u202D\u206E\u202D\u206A\u206C\u202A\u206B\u202B\u202C\u206F\u202B\u200C\u206B\u200E\u200C\u206D\u206C\u202B\u206F\u202A\u202A\u206A\u206F\u206C\u206E\u200B\u202A\u202E\u206E\u200C\u202B\u202E\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaWindGodsLeafVeilingSeDef))]
		public sealed class AyaWindGodsLeafVeilingSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				base.HandleOwnerEvent<DamageEventArgs>(AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u200F\u200E\u202E\u200E\u206B\u206A\u206E\u206F\u200F\u206E\u200C\u206A\u202E\u202C\u206F\u202A\u206F\u206D\u202C\u202A\u200C\u202C\u202E\u202E\u200C\u200C\u202B\u202D\u206B\u206E\u200D\u200C\u202D\u206E\u206E\u202A\u206C\u206F\u202C\u206B\u202E(AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u206D\u206E\u206E\u200C\u206C\u206B\u206C\u202C\u200C\u202B\u206E\u206A\u206B\u206D\u206B\u206B\u202C\u202E\u206C\u202E\u200F\u202C\u206C\u202C\u200E\u202C\u202E\u200B\u206E\u202B\u206E\u200E\u202E\u206B\u206A\u206E\u200F\u200B\u206C\u200C\u202E(this)), new GameEventHandler<DamageEventArgs>(this.OnDamageReceiving));
			}

			private void OnDamageReceiving(DamageEventArgs args)
			{
				DamageInfo damageInfo = AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u200B\u202D\u206D\u202D\u206F\u200D\u200E\u202A\u206F\u206D\u200D\u202D\u206F\u202B\u200C\u202D\u200E\u206A\u202D\u206D\u202D\u202D\u202A\u202A\u200E\u200B\u202A\u206F\u200F\u200C\u200C\u200D\u202E\u200D\u206B\u202C\u202E\u202A\u206E\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -2072289031;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(~num2) - (-1346873572 - -294445642)))) % 5U)
						{
						case 0U:
						{
							DamageInfo damageInfo2;
							AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u200B\u206C\u200E\u202C\u206B\u206E\u200D\u202E\u200E\u206E\u202C\u202D\u200E\u200E\u200C\u206D\u206E\u206D\u202A\u206F\u200B\u202C\u200C\u202D\u200F\u200D\u206F\u206E\u200B\u202E\u200B\u200F\u200D\u206E\u206C\u202B\u206B\u206A\u206B\u200C\u202E(args, damageInfo2);
							AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u200D\u200B\u202B\u202C\u202E\u206C\u200F\u200E\u206C\u202E\u206C\u202C\u202A\u202E\u206A\u206E\u206D\u200E\u206B\u206E\u202D\u206C\u200E\u200E\u206B\u206D\u206E\u200D\u206F\u206A\u200B\u200B\u202E\u206F\u206A\u202E\u206B\u206E\u206B\u206D\u202E(args, this);
							num = (int)((num3 * 1862261461U) ^ 3155208933U);
							continue;
						}
						case 2U:
							goto IL_0007;
						case 3U:
						{
							DamageInfo damageInfo2 = AyaWindGodsLeafVeilingSeDef.AyaWindGodsLeafVeilingSe.\u200B\u202D\u206D\u202D\u206F\u200D\u200E\u202A\u206F\u206D\u200D\u202D\u206F\u202B\u200C\u202D\u200E\u206A\u202D\u206D\u202D\u202D\u202A\u202A\u200E\u200B\u202A\u206F\u200F\u200C\u200C\u200D\u202E\u200D\u206B\u202C\u202E\u202A\u206E\u202E(args);
							damageInfo2.IsAccuracy = true;
							num = (int)((num3 * 1432726469U) ^ 889746374U);
							continue;
						}
						case 4U:
							num = (int)(((damageInfo.DamageType != DamageType.Attack) ? 4170416179U : 359004028U) ^ (num3 * 1515453052U));
							continue;
						}
						return;
					}
				}
			}

			static Unit \u206D\u206E\u206E\u200C\u206C\u206B\u206C\u202C\u200C\u202B\u206E\u206A\u206B\u206D\u206B\u206B\u202C\u202E\u206C\u202E\u200F\u202C\u206C\u202C\u200E\u202C\u202E\u200B\u206E\u202B\u206E\u200E\u202E\u206B\u206A\u206E\u200F\u200B\u206C\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<DamageEventArgs> \u200F\u200E\u202E\u200E\u206B\u206A\u206E\u206F\u200F\u206E\u200C\u206A\u202E\u202C\u206F\u202A\u206F\u206D\u202C\u202A\u200C\u202C\u202E\u202E\u200C\u200C\u202B\u202D\u206B\u206E\u200D\u200C\u202D\u206E\u206E\u202A\u206C\u206F\u202C\u206B\u202E(Unit A_0)
			{
				return A_0.DamageReceiving;
			}

			static DamageInfo \u200B\u202D\u206D\u202D\u206F\u200D\u200E\u202A\u206F\u206D\u200D\u202D\u206F\u202B\u200C\u202D\u200E\u206A\u202D\u206D\u202D\u202D\u202A\u202A\u200E\u200B\u202A\u206F\u200F\u200C\u200C\u200D\u202E\u200D\u206B\u202C\u202E\u202A\u206E\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u200B\u206C\u200E\u202C\u206B\u206E\u200D\u202E\u200E\u206E\u202C\u202D\u200E\u200E\u200C\u206D\u206E\u206D\u202A\u206F\u200B\u202C\u200C\u202D\u200F\u200D\u206F\u206E\u200B\u202E\u200B\u200F\u200D\u206E\u206C\u202B\u206B\u206A\u206B\u200C\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200D\u200B\u202B\u202C\u202E\u206C\u200F\u200E\u206C\u202E\u206C\u202C\u202A\u202E\u206A\u206E\u206D\u200E\u206B\u206E\u202D\u206C\u200E\u200E\u206B\u206D\u206E\u200D\u206F\u206A\u200B\u200B\u202E\u206F\u206A\u202E\u206B\u206E\u206B\u206D\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}
		}
	}
}
