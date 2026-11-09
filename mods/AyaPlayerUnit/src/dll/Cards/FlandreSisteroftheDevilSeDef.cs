using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreSisteroftheDevilSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(253828585);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSisteroftheDevilSeDef.\u206C\u206F\u202C\u206E\u206D\u200E\u200D\u202D\u202C\u200C\u200B\u206A\u206A\u202E\u206F\u206A\u206B\u200F\u200F\u200F\u200F\u206E\u206A\u206F\u200F\u206D\u206F\u200B\u200D\u202D\u202C\u202A\u202C\u202E\u206A\u202C\u206D\u202E\u200F\u202D\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreSisteroftheDevilSeDef.\u200F\u202B\u202E\u206E\u202E\u206A\u200C\u200F\u202B\u206E\u200B\u200D\u202A\u202E\u202E\u202E\u200E\u206B\u202A\u200E\u200C\u202E\u206D\u200B\u206E\u200F\u206D\u200F\u202E\u200F\u200F\u200B\u202D\u206F\u200E\u206D\u202E\u206C\u202A\u206B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1482499749), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreSisteroftheDevilSeDef.\u202D\u202A\u200B\u206E\u206A\u206D\u200D\u206C\u206C\u206A\u206D\u202C\u200D\u206D\u200F\u200C\u206C\u200C\u202D\u200B\u202C\u206E\u206F\u202D\u202D\u202C\u202D\u200D\u206A\u206F\u202B\u202A\u206F\u206A\u200D\u206C\u206E\u206E\u200D\u206A\u202E(BepinexPlugin.sequenceTable, FlandreSisteroftheDevilSeDef.\u206C\u202D\u202E\u206B\u200C\u202A\u206C\u200D\u202E\u202A\u202B\u200F\u202B\u200C\u202E\u200F\u200C\u200B\u200F\u202E\u200F\u202C\u206D\u206B\u206B\u202B\u200E\u206D\u206F\u206E\u206F\u206E\u202C\u200F\u202D\u202C\u206B\u206E\u202A\u202A\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 7, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Block | Keyword.Shield, new List<string>(), null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794));
		}

		static BatchLocalization \u206C\u206F\u202C\u206E\u206D\u200E\u200D\u202D\u202C\u200C\u200B\u206A\u206A\u202E\u206F\u206A\u206B\u200F\u200F\u200F\u200F\u206E\u206A\u206F\u200F\u206D\u206F\u200B\u200D\u202D\u202C\u202A\u202C\u202E\u206A\u202C\u206D\u202E\u200F\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200F\u202B\u202E\u206E\u202E\u206A\u200C\u200F\u202B\u206E\u200B\u200D\u202A\u202E\u202E\u202E\u200E\u206B\u202A\u200E\u200C\u202E\u206D\u200B\u206E\u200F\u206D\u200F\u202E\u200F\u200F\u200B\u202D\u206F\u200E\u206D\u202E\u206C\u202A\u206B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206C\u202D\u202E\u206B\u200C\u202A\u206C\u200D\u202E\u202A\u202B\u200F\u202B\u200C\u202E\u200F\u200C\u200B\u200F\u202E\u200F\u202C\u206D\u206B\u206B\u202B\u200E\u206D\u206F\u206E\u206F\u206E\u202C\u200F\u202D\u202C\u206B\u206E\u202A\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u202A\u200B\u206E\u206A\u206D\u200D\u206C\u206C\u206A\u206D\u202C\u200D\u206D\u200F\u200C\u206C\u200C\u202D\u200B\u202C\u206E\u206F\u202D\u202D\u202C\u202D\u200D\u206A\u206F\u202B\u202A\u206F\u206A\u200D\u206C\u206E\u206E\u200D\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreSisteroftheDevilSeDef))]
		public sealed class FlandreSisteroftheDevilSe : StatusEffect
		{
			public int Value1
			{
				get
				{
					return 15;
				}
			}

			public int Value2
			{
				get
				{
					return 25;
				}
			}

			protected override void OnAdded(Unit unit)
			{
				base.HandleOwnerEvent<BlockShieldEventArgs>(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200B\u200D\u202D\u206E\u202E\u206F\u202E\u206E\u200E\u200E\u202E\u206B\u206D\u202B\u206A\u202B\u200E\u206C\u200D\u202C\u206D\u206C\u206F\u206B\u206C\u206F\u202B\u200F\u200F\u200C\u202C\u202A\u200F\u200D\u200D\u200B\u206F\u206C\u202C\u202A\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200B\u202E\u200B\u200F\u200F\u200B\u206F\u206D\u200E\u202E\u200F\u202C\u206D\u200B\u200B\u200D\u202E\u202E\u200D\u200F\u202B\u202B\u206A\u206F\u200C\u200B\u202D\u206F\u206F\u200C\u202D\u206D\u206C\u202A\u200B\u202B\u206D\u202A\u206B\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200E\u202B\u202D\u206F\u200E\u206D\u206A\u202D\u206A\u202A\u206A\u206E\u206E\u206B\u206D\u206E\u202B\u200F\u202C\u200F\u206E\u200B\u206B\u202A\u206D\u206E\u200C\u206A\u202A\u202C\u200F\u206D\u206A\u206A\u206B\u200D\u206D\u202E\u202A\u200F\u202E(this))), new GameEventHandler<BlockShieldEventArgs>(this.OnPlayerBlockShieldGaining));
				for (;;)
				{
					IL_0022:
					int num = 795854890;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 3U)
						{
						case 1U:
							base.HandleOwnerEvent<DamageDealingEventArgs>(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202B\u202B\u206E\u206C\u200D\u206D\u200E\u206D\u206A\u200F\u202D\u206C\u206A\u200F\u206B\u202E\u206A\u202D\u202E\u206E\u206C\u206B\u206B\u202B\u202E\u202C\u202A\u202E\u200F\u206D\u200D\u200B\u202A\u206E\u206B\u200C\u202D\u206A\u206E\u206B\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200B\u202E\u200B\u200F\u200F\u200B\u206F\u206D\u200E\u202E\u200F\u202C\u206D\u200B\u200B\u200D\u202E\u202E\u200D\u200F\u202B\u202B\u206A\u206F\u200C\u200B\u202D\u206F\u206F\u200C\u202D\u206D\u206C\u202A\u200B\u202B\u206D\u202A\u206B\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200E\u202B\u202D\u206F\u200E\u206D\u206A\u202D\u206A\u202A\u206A\u206E\u206E\u206B\u206D\u206E\u202B\u200F\u202C\u200F\u206E\u200B\u206B\u202A\u206D\u206E\u200C\u206A\u202A\u202C\u200F\u206D\u206A\u206A\u206B\u200D\u206D\u202E\u202A\u200F\u202E(this))), new GameEventHandler<DamageDealingEventArgs>(this.OnPlayerDamageDealing));
							num = (int)((num3 * 2602479945U) ^ 2588879875U);
							continue;
						case 2U:
							goto IL_0022;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.HandleOwnerEvent<DamageEventArgs>(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200F\u206D\u206F\u206A\u206C\u202D\u206C\u202A\u206B\u200C\u206D\u202A\u202C\u202E\u202B\u200E\u202A\u206F\u200B\u206C\u202D\u200D\u202D\u200E\u202D\u200B\u202B\u206D\u206D\u200D\u206D\u200D\u200B\u202B\u200E\u202C\u206D\u206F\u200F\u200D\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200B\u202E\u200B\u200F\u200F\u200B\u206F\u206D\u200E\u202E\u200F\u202C\u206D\u200B\u200B\u200D\u202E\u202E\u200D\u200F\u202B\u202B\u206A\u206F\u200C\u200B\u202D\u206F\u206F\u200C\u202D\u206D\u206C\u202A\u200B\u202B\u206D\u202A\u206B\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200E\u202B\u202D\u206F\u200E\u206D\u206A\u202D\u206A\u202A\u206A\u206E\u206E\u206B\u206D\u206E\u202B\u200F\u202C\u200F\u206E\u200B\u206B\u202A\u206D\u206E\u200C\u206A\u202A\u202C\u200F\u206D\u206A\u206A\u206B\u200D\u206D\u202E\u202A\u200F\u202E(this))), new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageReceiving));
				base.ReactOwnerEvent<StatusEffectEventArgs>(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206E\u200D\u202A\u200C\u202B\u200F\u206B\u206C\u206A\u202A\u200E\u206D\u206E\u200B\u200E\u202C\u200C\u200C\u202E\u206C\u200E\u206F\u206E\u200D\u206C\u200F\u200E\u200B\u200F\u200D\u202C\u202E\u202A\u202E\u200F\u202D\u200C\u206D\u200E\u202C\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200B\u202E\u200B\u200F\u200F\u200B\u206F\u206D\u200E\u202E\u200F\u202C\u206D\u200B\u200B\u200D\u202E\u202E\u200D\u200F\u202B\u202B\u206A\u206F\u200C\u200B\u202D\u206F\u206F\u200C\u202D\u206D\u206C\u202A\u200B\u202B\u206D\u202A\u206B\u202E(FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200E\u202B\u202D\u206F\u200E\u206D\u206A\u202D\u206A\u202A\u206A\u206E\u206E\u206B\u206D\u206E\u202B\u200F\u202C\u200F\u206E\u200B\u206B\u202A\u206D\u206E\u200C\u206A\u202A\u202C\u200F\u206D\u206A\u206A\u206B\u200D\u206D\u202E\u202A\u200F\u202E(this))), new EventSequencedReactor<StatusEffectEventArgs>(this.OnPlayerStatusEffectRemoving));
			}

			private void OnPlayerBlockShieldGaining(BlockShieldEventArgs args)
			{
				if (FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206A\u202C\u206D\u206D\u206E\u206C\u206B\u202E\u206E\u200B\u206B\u206D\u200B\u206F\u202E\u206A\u200D\u200B\u200D\u206D\u206C\u202D\u202E\u206E\u206C\u202D\u200C\u202D\u202D\u206B\u200B\u202B\u200D\u206E\u202C\u202B\u200B\u206F\u202E\u200C\u202E(args) != ActionCause.Card)
				{
					goto IL_0009;
				}
				goto IL_007D;
				int num2;
				for (;;)
				{
					IL_000E:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((-1918866033 - num * 997493729) * -1862221481)) % 10U)
					{
					case 0U:
						FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206B\u206B\u206E\u206F\u200B\u202E\u202E\u200D\u206A\u206F\u206A\u206E\u200F\u206C\u206E\u200B\u200E\u202C\u206A\u206C\u200F\u200C\u202A\u200E\u206F\u206E\u200D\u200B\u206F\u202C\u202B\u202B\u202A\u206B\u202B\u200F\u200B\u200B\u206C\u202C\u202E(args, this);
						num2 = -1415567033;
						continue;
					case 1U:
						num2 = (int)(((FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206A\u202C\u206D\u206D\u206E\u206C\u206B\u202E\u206E\u200B\u206B\u206D\u200B\u206F\u202E\u206A\u200D\u200B\u200D\u206D\u206C\u202D\u202E\u206E\u206C\u202D\u200C\u202D\u202D\u206B\u200B\u202B\u200D\u206E\u202C\u202B\u200B\u206F\u202E\u200C\u202E(args) == ActionCause.OnlyCalculate) ? 491715768U : 2234526037U) ^ (num3 * 1428019499U));
						continue;
					case 2U:
						goto IL_007D;
					case 3U:
						FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202A\u206A\u202A\u202D\u206B\u200B\u200C\u202E\u200B\u206B\u202C\u206C\u206D\u202B\u206A\u202E\u206C\u206E\u202D\u200F\u202C\u206D\u206D\u202B\u200D\u200E\u202E\u206F\u200C\u200F\u206B\u202A\u206F\u202A\u200C\u200B\u206C\u202A\u200F\u200F\u202E(args, FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200E\u200D\u202B\u202A\u206C\u200D\u202D\u200C\u202C\u202C\u200D\u206A\u200E\u206F\u202E\u206A\u200F\u206E\u200C\u206D\u206B\u202D\u200D\u200B\u200D\u200C\u206B\u200C\u200E\u206B\u206E\u202B\u200E\u200E\u200B\u200C\u206C\u206B\u206F\u200F\u202E(args) * (1f + (float)this.Value1 / 100f));
						num2 = (int)((num3 * 806437354U) ^ 2343799698U);
						continue;
					case 4U:
						FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202E\u200D\u206D\u206F\u206E\u200C\u202E\u200D\u202C\u202D\u200C\u206C\u206E\u206E\u202B\u206F\u200B\u200C\u206C\u200C\u200F\u202A\u200E\u206B\u202D\u206F\u202A\u202C\u202E\u202D\u202B\u206B\u206B\u206B\u202C\u202A\u200C\u202D\u200E\u202A\u202E(args, FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206B\u206E\u206E\u202C\u200C\u206A\u206C\u202E\u202E\u202C\u206C\u202B\u200D\u200C\u202A\u202C\u200F\u200B\u202B\u206A\u200E\u202B\u200F\u200F\u206B\u200B\u206F\u200F\u200E\u202C\u200F\u202B\u200E\u200F\u202D\u202A\u206F\u202C\u202D\u206C\u202E(args) * (1f + (float)this.Value1 / 100f));
						num2 = (int)((num3 * 735999236U) ^ 1794696707U);
						continue;
					case 5U:
						return;
					case 6U:
						num2 = (FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202D\u202B\u200F\u202C\u202A\u202B\u206A\u200B\u200B\u206F\u206C\u200E\u206E\u206A\u202A\u202B\u200C\u200B\u206F\u202E\u202C\u202C\u206C\u206A\u206B\u200E\u206F\u200B\u202B\u200B\u202A\u202B\u206C\u202B\u200F\u202A\u206E\u200E\u200D\u206E\u202E(args) ? (-1349018416) : 2052129896);
						continue;
					case 7U:
						num2 = ((!FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202A\u200C\u206C\u206F\u202C\u206F\u206B\u200D\u206A\u202C\u206C\u202E\u206C\u202A\u202E\u202C\u200E\u202A\u206A\u206B\u200F\u202C\u200D\u202B\u200D\u206F\u200E\u206C\u206F\u206F\u200F\u202A\u202D\u200F\u202D\u206F\u200E\u206D\u200E\u206B\u202E(args)) ? 943574811 : 755216517);
						continue;
					case 9U:
						goto IL_0009;
					}
					break;
				}
				return;
				IL_0009:
				num2 = -1428260256;
				goto IL_000E;
				IL_007D:
				num2 = ((FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206B\u202B\u202E\u206C\u206D\u200D\u202B\u200D\u200F\u200D\u206C\u206D\u206E\u206D\u206E\u202E\u202E\u206C\u200C\u200F\u200B\u200B\u206C\u206E\u206F\u206D\u202D\u200B\u200F\u202A\u206D\u206C\u202E\u206C\u200B\u202E\u202E\u202B\u200F\u206F\u202E(args) != BlockShieldType.Direct) ? (-1224532577) : 640528006);
				goto IL_000E;
			}

			private void OnPlayerDamageDealing(DamageDealingEventArgs args)
			{
				DamageInfo damageInfo = FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202D\u200B\u206E\u206C\u202E\u200C\u200D\u200C\u206C\u206D\u200B\u200D\u206A\u202B\u202C\u202A\u202E\u206C\u206B\u202C\u206C\u202B\u200F\u200F\u206F\u206C\u202C\u200E\u202E\u206B\u200E\u200C\u200C\u202C\u202D\u206B\u202C\u202C\u206D\u202C\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -1669522052;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(~(-num2)) * 103093503)) % 6U)
						{
						case 0U:
							FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u202B\u206C\u206A\u202E\u206F\u206C\u206D\u200F\u200C\u206A\u206C\u202A\u202C\u202B\u200F\u202A\u202E\u206F\u200C\u202E\u200E\u206F\u200F\u202C\u202E\u200D\u206E\u200E\u202C\u206C\u202A\u202D\u206A\u206F\u202A\u206F\u206E\u206A\u200C\u202E(args, damageInfo);
							num = (int)((num3 * 9669457U) ^ 3062769257U);
							continue;
						case 1U:
							num = (int)(((damageInfo.DamageType == DamageType.Attack) ? 2587660270U : 2177195847U) ^ (num3 * 3246188316U));
							continue;
						case 2U:
							FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206B\u206B\u206E\u206F\u200B\u202E\u202E\u200D\u206A\u206F\u206A\u206E\u200F\u206C\u206E\u200B\u200E\u202C\u206A\u206C\u200F\u200C\u202A\u200E\u206F\u206E\u200D\u200B\u206F\u202C\u202B\u202B\u202A\u206B\u202B\u200F\u200B\u200B\u206C\u202C\u202E(args, this);
							num = (int)((num3 * 2411194160U) ^ 1965036307U);
							continue;
						case 3U:
							damageInfo.Damage = damageInfo.Amount * (1f + (float)this.Value1 / 100f);
							num = (int)((num3 * 1004933642U) ^ 2506752741U);
							continue;
						case 5U:
							goto IL_0007;
						}
						return;
					}
				}
			}

			private void OnPlayerDamageReceiving(DamageEventArgs args)
			{
				DamageInfo damageInfo = FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u200D\u206D\u200D\u206A\u202E\u206D\u206F\u202C\u202A\u200F\u200D\u200C\u202B\u206D\u200E\u206E\u202B\u202A\u202B\u202A\u206F\u200C\u206C\u206F\u200D\u202C\u206C\u202A\u206A\u200E\u200B\u206B\u206B\u206A\u206A\u206E\u202C\u206E\u202A\u206A\u202E(args);
				if (damageInfo.DamageType == DamageType.Attack)
				{
					for (;;)
					{
						IL_0014:
						int num = -1320117637;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(-532064991 - (1740665192 + -1453374205) - ((-21226703 ^ -1744879770) - (-836186358 ^ 1117233403) + -256271872 - num2)) * 2046106485)) % 4U)
							{
							case 1U:
								damageInfo.Damage = damageInfo.Amount * (1f - (float)this.Value2 / 100f);
								FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206A\u206E\u206C\u202A\u202B\u206C\u200E\u206C\u202C\u206A\u202D\u206D\u206B\u200F\u206B\u202A\u206D\u202E\u200C\u202C\u206C\u206D\u206F\u206C\u202A\u206F\u200F\u206D\u200E\u202C\u206A\u202D\u200C\u206D\u206E\u206C\u202D\u202A\u202C\u202A\u202E(args, damageInfo);
								num = (int)((num3 * 2206773542U) ^ 2522549520U);
								continue;
							case 2U:
								FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.\u206B\u206B\u206E\u206F\u200B\u202E\u202E\u200D\u206A\u206F\u206A\u206E\u200F\u206C\u206E\u200B\u200E\u202C\u206A\u206C\u200F\u200C\u202A\u200E\u206F\u206E\u200D\u200B\u206F\u202C\u202B\u202B\u202A\u206B\u202B\u200F\u200B\u200B\u206C\u202C\u202E(args, this);
								num = (int)((num3 * 2322068328U) ^ 2533771684U);
								continue;
							case 3U:
								goto IL_0014;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectRemoving(StatusEffectEventArgs args)
			{
				FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.<OnPlayerStatusEffectRemoving>d__8 <OnPlayerStatusEffectRemoving>d__ = new FlandreSisteroftheDevilSeDef.FlandreSisteroftheDevilSe.<OnPlayerStatusEffectRemoving>d__8(-2);
				<OnPlayerStatusEffectRemoving>d__.<>4__this = this;
				<OnPlayerStatusEffectRemoving>d__.<>3__args = args;
				return <OnPlayerStatusEffectRemoving>d__;
			}

			static BattleController \u200E\u202B\u202D\u206F\u200E\u206D\u206A\u202D\u206A\u202A\u206A\u206E\u206E\u206B\u206D\u206E\u202B\u200F\u202C\u200F\u206E\u200B\u206B\u202A\u206D\u206E\u200C\u206A\u202A\u202C\u200F\u206D\u206A\u206A\u206B\u200D\u206D\u202E\u202A\u200F\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u200B\u202E\u200B\u200F\u200F\u200B\u206F\u206D\u200E\u202E\u200F\u202C\u206D\u200B\u200B\u200D\u202E\u202E\u200D\u200F\u202B\u202B\u206A\u206F\u200C\u200B\u202D\u206F\u206F\u200C\u202D\u206D\u206C\u202A\u200B\u202B\u206D\u202A\u206B\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<BlockShieldEventArgs> \u200B\u200D\u202D\u206E\u202E\u206F\u202E\u206E\u200E\u200E\u202E\u206B\u206D\u202B\u206A\u202B\u200E\u206C\u200D\u202C\u206D\u206C\u206F\u206B\u206C\u206F\u202B\u200F\u200F\u200C\u202C\u202A\u200F\u200D\u200D\u200B\u206F\u206C\u202C\u202A\u202E(Unit A_0)
			{
				return A_0.BlockShieldGaining;
			}

			static GameEvent<DamageDealingEventArgs> \u202B\u202B\u206E\u206C\u200D\u206D\u200E\u206D\u206A\u200F\u202D\u206C\u206A\u200F\u206B\u202E\u206A\u202D\u202E\u206E\u206C\u206B\u206B\u202B\u202E\u202C\u202A\u202E\u200F\u206D\u200D\u200B\u202A\u206E\u206B\u200C\u202D\u206A\u206E\u206B\u202E(Unit A_0)
			{
				return A_0.DamageDealing;
			}

			static GameEvent<DamageEventArgs> \u200F\u206D\u206F\u206A\u206C\u202D\u206C\u202A\u206B\u200C\u206D\u202A\u202C\u202E\u202B\u200E\u202A\u206F\u200B\u206C\u202D\u200D\u202D\u200E\u202D\u200B\u202B\u206D\u206D\u200D\u206D\u200D\u200B\u202B\u200E\u202C\u206D\u206F\u200F\u200D\u202E(Unit A_0)
			{
				return A_0.DamageReceiving;
			}

			static GameEvent<StatusEffectEventArgs> \u206E\u200D\u202A\u200C\u202B\u200F\u206B\u206C\u206A\u202A\u200E\u206D\u206E\u200B\u200E\u202C\u200C\u200C\u202E\u206C\u200E\u206F\u206E\u200D\u206C\u200F\u200E\u200B\u200F\u200D\u202C\u202E\u202A\u202E\u200F\u202D\u200C\u206D\u200E\u202C\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoving;
			}

			static ActionCause \u206A\u202C\u206D\u206D\u206E\u206C\u206B\u202E\u206E\u200B\u206B\u206D\u200B\u206F\u202E\u206A\u200D\u200B\u200D\u206D\u206C\u202D\u202E\u206E\u206C\u202D\u200C\u202D\u202D\u206B\u200B\u202B\u200D\u206E\u202C\u202B\u200B\u206F\u202E\u200C\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			static BlockShieldType \u206B\u202B\u202E\u206C\u206D\u200D\u202B\u200D\u200F\u200D\u206C\u206D\u206E\u206D\u206E\u202E\u202E\u206C\u200C\u200F\u200B\u200B\u206C\u206E\u206F\u206D\u202D\u200B\u200F\u202A\u206D\u206C\u202E\u206C\u200B\u202E\u202E\u202B\u200F\u206F\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Type;
			}

			static bool \u202D\u202B\u200F\u202C\u202A\u202B\u206A\u200B\u200B\u206F\u206C\u200E\u206E\u206A\u202A\u202B\u200C\u200B\u206F\u202E\u202C\u202C\u206C\u206A\u206B\u200E\u206F\u200B\u202B\u200B\u202A\u202B\u206C\u202B\u200F\u202A\u206E\u200E\u200D\u206E\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.HasBlock;
			}

			static float \u200E\u200D\u202B\u202A\u206C\u200D\u202D\u200C\u202C\u202C\u200D\u206A\u200E\u206F\u202E\u206A\u200F\u206E\u200C\u206D\u206B\u202D\u200D\u200B\u200D\u200C\u206B\u200C\u200E\u206B\u206E\u202B\u200E\u200E\u200B\u200C\u206C\u206B\u206F\u200F\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Block;
			}

			static void \u202A\u206A\u202A\u202D\u206B\u200B\u200C\u202E\u200B\u206B\u202C\u206C\u206D\u202B\u206A\u202E\u206C\u206E\u202D\u200F\u202C\u206D\u206D\u202B\u200D\u200E\u202E\u206F\u200C\u200F\u206B\u202A\u206F\u202A\u200C\u200B\u206C\u202A\u200F\u200F\u202E(BlockShieldEventArgs A_0, float A_1)
			{
				A_0.Block = A_1;
			}

			static bool \u202A\u200C\u206C\u206F\u202C\u206F\u206B\u200D\u206A\u202C\u206C\u202E\u206C\u202A\u202E\u202C\u200E\u202A\u206A\u206B\u200F\u202C\u200D\u202B\u200D\u206F\u200E\u206C\u206F\u206F\u200F\u202A\u202D\u200F\u202D\u206F\u200E\u206D\u200E\u206B\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.HasShield;
			}

			static float \u206B\u206E\u206E\u202C\u200C\u206A\u206C\u202E\u202E\u202C\u206C\u202B\u200D\u200C\u202A\u202C\u200F\u200B\u202B\u206A\u200E\u202B\u200F\u200F\u206B\u200B\u206F\u200F\u200E\u202C\u200F\u202B\u200E\u200F\u202D\u202A\u206F\u202C\u202D\u206C\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Shield;
			}

			static void \u202E\u200D\u206D\u206F\u206E\u200C\u202E\u200D\u202C\u202D\u200C\u206C\u206E\u206E\u202B\u206F\u200B\u200C\u206C\u200C\u200F\u202A\u200E\u206B\u202D\u206F\u202A\u202C\u202E\u202D\u202B\u206B\u206B\u206B\u202C\u202A\u200C\u202D\u200E\u202A\u202E(BlockShieldEventArgs A_0, float A_1)
			{
				A_0.Shield = A_1;
			}

			static void \u206B\u206B\u206E\u206F\u200B\u202E\u202E\u200D\u206A\u206F\u206A\u206E\u200F\u206C\u206E\u200B\u200E\u202C\u206A\u206C\u200F\u200C\u202A\u200E\u206F\u206E\u200D\u200B\u206F\u202C\u202B\u202B\u202A\u206B\u202B\u200F\u200B\u200B\u206C\u202C\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static DamageInfo \u202D\u200B\u206E\u206C\u202E\u200C\u200D\u200C\u206C\u206D\u200B\u200D\u206A\u202B\u202C\u202A\u202E\u206C\u206B\u202C\u206C\u202B\u200F\u200F\u206F\u206C\u202C\u200E\u202E\u206B\u200E\u200C\u200C\u202C\u202D\u206B\u202C\u202C\u206D\u202C\u202E(DamageDealingEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u202B\u206C\u206A\u202E\u206F\u206C\u206D\u200F\u200C\u206A\u206C\u202A\u202C\u202B\u200F\u202A\u202E\u206F\u200C\u202E\u200E\u206F\u200F\u202C\u202E\u200D\u206E\u200E\u202C\u206C\u202A\u202D\u206A\u206F\u202A\u206F\u206E\u206A\u200C\u202E(DamageDealingEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static DamageInfo \u200D\u206D\u200D\u206A\u202E\u206D\u206F\u202C\u202A\u200F\u200D\u200C\u202B\u206D\u200E\u206E\u202B\u202A\u202B\u202A\u206F\u200C\u206C\u206F\u200D\u202C\u206C\u202A\u206A\u200E\u200B\u206B\u206B\u206A\u206A\u206E\u202C\u206E\u202A\u206A\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u206A\u206E\u206C\u202A\u202B\u206C\u200E\u206C\u202C\u206A\u202D\u206D\u206B\u200F\u206B\u202A\u206D\u202E\u200C\u202C\u206C\u206D\u206F\u206C\u202A\u206F\u200F\u206D\u200E\u202C\u206A\u202D\u200C\u206D\u206E\u206C\u202D\u202A\u202C\u202A\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}
		}
	}
}
