using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
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

namespace AyaShameimaru.Cards
{
	public sealed class FlandreScarletCasinoSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-857360466);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreScarletCasinoSeDef.\u202A\u206C\u200E\u200C\u206C\u206C\u206E\u206E\u200D\u200B\u206A\u200E\u206F\u200E\u200C\u200E\u202D\u206D\u206A\u206D\u202A\u202E\u200F\u200B\u200D\u202E\u206A\u206F\u202D\u202E\u206C\u200C\u206F\u202B\u200F\u206A\u202D\u200B\u206A\u202B\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreScarletCasinoSeDef.\u206B\u202C\u200E\u200C\u202E\u206D\u206D\u202C\u206B\u202E\u202E\u202B\u206E\u200D\u206C\u206B\u202B\u202E\u202E\u200B\u206E\u202A\u206A\u200D\u206C\u200E\u206A\u200F\u202D\u202E\u202E\u202A\u202C\u206E\u202C\u206C\u206C\u206E\u206A\u202B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-371270553), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExtraIcons LoadExtraIcons()
		{
			ExtraIcons extraIcons = FlandreScarletCasinoSeDef.\u200B\u200E\u200D\u206A\u202C\u200F\u200C\u202A\u202C\u202A\u206E\u200D\u206C\u200F\u200C\u202E\u202D\u206C\u206C\u206F\u200D\u202B\u206F\u202E\u202B\u206C\u206E\u200E\u202C\u200E\u200F\u206D\u206F\u202C\u202B\u200E\u200C\u200D\u202C\u200C\u202E();
			extraIcons.icons.Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1240639393), FlandreScarletCasinoSeDef.\u206B\u202C\u200E\u200C\u202E\u206D\u206D\u202C\u206B\u202E\u202E\u202B\u206E\u200D\u206C\u206B\u202B\u202E\u202E\u200B\u206E\u202A\u206A\u200D\u206C\u200E\u206A\u200F\u202D\u202E\u202E\u202A\u202C\u206E\u202C\u206C\u206C\u206E\u206A\u202B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-660842979), BepinexPlugin.embeddedSource, null, 1, null));
			return extraIcons;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreScarletCasinoSeDef.\u206B\u202B\u206C\u206C\u202C\u206F\u206C\u202D\u200F\u200C\u206F\u202B\u206A\u200D\u206B\u202B\u202D\u206A\u206C\u206D\u200C\u206D\u206A\u206D\u202E\u206D\u202E\u206E\u200F\u202B\u200E\u200B\u206F\u202A\u202D\u202B\u200F\u200F\u202A\u206E\u202E(BepinexPlugin.sequenceTable, FlandreScarletCasinoSeDef.\u202B\u202D\u206D\u206F\u200C\u200F\u200C\u206D\u206C\u206C\u202A\u206F\u202E\u200C\u206E\u200D\u206D\u200E\u200D\u202A\u206D\u200C\u206A\u200D\u200E\u200C\u202A\u202A\u206B\u202C\u206E\u206B\u200B\u206B\u200D\u206F\u200C\u206A\u202D\u200F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", -2, StatusEffectType.Special, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, true, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Philosophy | Keyword.Upgrade | Keyword.Battlefield, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(859402033));
		}

		static BatchLocalization \u202A\u206C\u200E\u200C\u206C\u206C\u206E\u206E\u200D\u200B\u206A\u200E\u206F\u200E\u200C\u200E\u202D\u206D\u206A\u206D\u202A\u202E\u200F\u200B\u200D\u202E\u206A\u206F\u202D\u202E\u206C\u200C\u206F\u202B\u200F\u206A\u202D\u200B\u206A\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u206B\u202C\u200E\u200C\u202E\u206D\u206D\u202C\u206B\u202E\u202E\u202B\u206E\u200D\u206C\u206B\u202B\u202E\u202E\u200B\u206E\u202A\u206A\u200D\u206C\u200E\u206A\u200F\u202D\u202E\u202E\u202A\u202C\u206E\u202C\u206C\u206C\u206E\u206A\u202B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static ExtraIcons \u200B\u200E\u200D\u206A\u202C\u200F\u200C\u202A\u202C\u202A\u206E\u200D\u206C\u200F\u200C\u202E\u202D\u206C\u206C\u206F\u200D\u202B\u206F\u202E\u202B\u206C\u206E\u200E\u202C\u200E\u200F\u206D\u206F\u202C\u202B\u200E\u200C\u200D\u202C\u200C\u202E()
		{
			return new ExtraIcons();
		}

		static Type \u202B\u202D\u206D\u206F\u200C\u200F\u200C\u206D\u206C\u206C\u202A\u206F\u202E\u200C\u206E\u200D\u206D\u200E\u200D\u202A\u206D\u200C\u206A\u200D\u200E\u200C\u202A\u202A\u206B\u202C\u206E\u206B\u200B\u206B\u200D\u206F\u200C\u206A\u202D\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u202B\u206C\u206C\u202C\u206F\u206C\u202D\u200F\u200C\u206F\u202B\u206A\u200D\u206B\u202B\u202D\u206A\u206C\u206D\u200C\u206D\u206A\u206D\u202E\u206D\u202E\u206E\u200F\u202B\u200E\u200B\u206F\u202A\u202D\u202B\u200F\u200F\u202A\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreScarletCasinoSeDef))]
		public sealed class FlandreScarletCasinoSe : StatusEffect
		{
			public int Value1
			{
				get
				{
					return 1;
				}
			}

			public int Value2
			{
				get
				{
					return 6;
				}
			}

			public int Value3
			{
				get
				{
					return 1;
				}
			}

			public int Value4
			{
				get
				{
					return 4;
				}
			}

			public ManaGroup Amount1
			{
				get
				{
					return ManaGroup.Anys(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this));
				}
			}

			public int Amount2
			{
				get
				{
					return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this) * 2;
				}
			}

			public int Amount3
			{
				get
				{
					return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this) * 3;
				}
			}

			public int Amount4
			{
				get
				{
					return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this) * 4;
				}
			}

			public ManaGroup Amount5
			{
				get
				{
					return ManaGroup.Philosophies(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this) * 5);
				}
			}

			public int Amount6
			{
				get
				{
					return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(this) * 60;
				}
			}

			public override string OverrideIconName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					if (!FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202A\u202D\u200B\u206E\u202B\u206D\u200F\u206A\u202E\u206D\u202E\u200D\u206D\u206C\u202E\u202D\u202B\u206A\u202A\u200D\u206E\u200F\u202E\u200C\u206C\u202D\u200B\u202C\u200F\u200B\u200B\u202E\u202E\u202C\u200B\u202C\u200B\u206B\u206A\u206C\u202E(GameMaster.GetPreferredCardIllustrator(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1389835116)), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(25567232)))
					{
						for (;;)
						{
							int num = -29570292;
							switch (~(num ^ ((--1524413369 + -1023969090) * -765618029) ^ (-1613436835 * 263505363 + --1597330384) ^ --959682313) % 3)
							{
							case 1:
								goto IL_0070;
							case 2:
								continue;
							}
							break;
						}
						goto IL_0086;
						IL_0070:
						return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202E\u200E\u206D\u206C\u200B\u202E\u202B\u202A\u206F\u206D\u206D\u206C\u202C\u202E\u202D\u206F\u206C\u200B\u200C\u200D\u206C\u200E\u206D\u200B\u206E\u206D\u202B\u200F\u200E\u206F\u200D\u200D\u206A\u202B\u206D\u202A\u206D\u202C\u200F\u206F\u202E(this);
					}
					IL_0086:
					return FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200F\u206A\u206E\u206C\u200B\u206D\u206F\u200F\u206E\u200B\u206C\u206D\u200B\u200D\u200F\u202A\u202D\u202D\u202E\u206F\u202A\u202B\u200F\u206A\u206A\u206D\u206A\u202B\u206C\u202E\u206B\u200D\u202C\u206D\u200E\u200B\u200C\u200D\u200C\u202E(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202E\u200E\u206D\u206C\u200B\u202E\u202B\u202A\u206F\u206D\u206D\u206C\u202C\u202E\u202D\u206F\u206C\u200B\u200C\u200D\u206C\u200E\u206D\u200B\u206E\u206D\u202B\u200F\u200E\u206F\u200D\u200D\u206A\u202B\u206D\u202A\u206D\u202C\u200F\u206F\u202E(this), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1885144086));
				}
			}

			protected override void OnAdded(Unit unit)
			{
				FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200B\u200F\u200F\u202E\u206F\u202C\u206A\u202D\u206D\u200D\u202C\u206A\u200B\u206D\u202C\u202D\u202A\u202B\u206F\u206B\u202C\u200D\u206E\u200D\u200F\u202C\u202D\u206E\u202D\u200D\u202D\u206B\u206A\u200B\u200F\u202B\u206E\u202A\u202D\u206E\u202E(this, FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200D\u202A\u202A\u206D\u206B\u202A\u202B\u200B\u206C\u202E\u206B\u202A\u206D\u200F\u202C\u200C\u200B\u206A\u206A\u200C\u200D\u206B\u200F\u200C\u202B\u206A\u202C\u206D\u202C\u202C\u206F\u206C\u200B\u200C\u200B\u206E\u206F\u202E\u202A\u200F\u202E(this));
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202C\u200C\u202C\u206F\u206D\u200E\u200B\u206A\u200F\u206A\u200E\u206B\u206E\u202D\u206C\u202D\u200C\u202D\u206D\u200E\u206C\u206D\u202C\u200D\u206D\u200F\u200B\u206D\u200C\u200E\u200D\u200E\u206C\u200F\u202A\u202E\u200E\u202E\u200C\u206D\u202E(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202B\u206A\u202D\u206F\u200D\u202C\u206D\u206C\u206A\u202B\u200E\u206F\u200F\u206B\u206B\u202E\u200B\u206B\u200B\u206A\u206B\u200E\u200E\u206A\u202A\u206A\u202E\u200F\u200B\u206F\u200E\u202B\u202A\u206D\u206B\u200C\u200E\u206A\u206A\u200C\u202E(this)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_001D:
					int num = 1156170574;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(~(-1730731397) - (num2 ^ (2142682839 ^ (-1564090542 - 1407443683 - (1580122704 - 543380070))))) * -1948601615)) % 6U)
						{
						case 0U:
							base.ReactOwnerEvent<StatusEffectEventArgs>(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u200D\u206C\u202C\u206F\u206C\u206F\u202E\u202E\u200C\u206A\u206E\u202B\u202C\u206F\u206C\u200F\u200C\u200F\u202B\u206B\u200D\u202A\u202D\u200B\u206E\u200D\u200E\u200C\u206B\u202B\u206A\u206E\u202D\u206C\u200E\u200D\u200B\u202E\u200F\u200D\u202E(flandrePlayerUnit), new EventSequencedReactor<StatusEffectEventArgs>(this.OnPlayerStatusEffectRemoving));
							num = (int)((num3 * 3952544894U) ^ 1253233207U);
							continue;
						case 1U:
							num = (int)(((flandrePlayerUnit == null) ? 3523713158U : 703115256U) ^ (num3 * 1356287255U));
							continue;
						case 2U:
							base.ReactOwnerEvent<CardUsingEventArgs>(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202A\u206B\u202D\u206B\u200D\u206E\u200D\u200F\u202E\u200F\u206F\u200B\u206A\u200E\u200D\u206B\u200D\u202B\u206E\u200B\u200F\u206A\u200C\u200D\u202E\u200D\u200B\u200B\u206A\u200F\u206B\u202D\u206B\u202C\u202C\u206C\u202E\u200C\u202E\u206B\u202E(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202B\u206A\u202D\u206F\u200D\u202C\u206D\u206C\u206A\u202B\u200E\u206F\u200F\u206B\u206B\u202E\u200B\u206B\u200B\u206A\u206B\u200E\u200E\u206A\u202A\u206A\u202E\u200F\u200B\u206F\u200E\u202B\u202A\u206D\u206B\u200C\u200E\u206A\u206A\u200C\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 884714192U) ^ 4172336448U);
							continue;
						case 3U:
							goto IL_001D;
						case 5U:
							base.ReactOwnerEvent<CardUsingEventArgs>(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202C\u202D\u202D\u206E\u200E\u206A\u202A\u206E\u206A\u206B\u200D\u206E\u200D\u206E\u206E\u206E\u202D\u206B\u200D\u206F\u206F\u206E\u206B\u206F\u202A\u202E\u202C\u200B\u202E\u200D\u206D\u202A\u200E\u206C\u206F\u202A\u206D\u202E\u200C\u202E(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u202B\u206A\u202D\u206F\u200D\u202C\u206D\u206C\u206A\u202B\u200E\u206F\u200F\u206B\u206B\u202E\u200B\u206B\u200B\u206A\u206B\u200E\u200E\u206A\u202A\u206A\u202E\u200F\u200B\u206F\u200E\u202B\u202A\u206D\u206B\u200C\u200E\u206A\u206A\u200C\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 389713169U) ^ 340089938U);
							continue;
						}
						return;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u206C\u200C\u202E\u206B\u202D\u206D\u202C\u202D\u206B\u202B\u206D\u202B\u202D\u202D\u200C\u206E\u202C\u200F\u206C\u206A\u206E\u200E\u202C\u200F\u206E\u200D\u206A\u202A\u200C\u206A\u200C\u200F\u200C\u200B\u206E\u206F\u206C\u206D\u200E\u200D\u202E(FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.\u206A\u206C\u200E\u202E\u206C\u206B\u200D\u200C\u202B\u202D\u206C\u206E\u206F\u200D\u202B\u200E\u206A\u202B\u200D\u200B\u206C\u202A\u206F\u206C\u206F\u200D\u200D\u206B\u200C\u200D\u202C\u202D\u202A\u202E\u206A\u200C\u200D\u206C\u202D\u206D\u202E(this)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_0011:
					int num = 1179492895;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(659208011 + 1206609041 - ~(uint)(368494057 * ((-1824242596 ^ 1280998797) * 729173165) - num2)))) % 4U)
						{
						case 0U:
							goto IL_0011;
						case 1U:
							num = (int)(((flandrePlayerUnit != null) ? 4265595453U : 3300071144U) ^ (num3 * 620819112U));
							continue;
						case 3U:
							flandrePlayerUnit.BossStationFinished = false;
							num = (int)((num3 * 1365821838U) ^ 2186548970U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<OnCardUsed>d__24 <OnCardUsed>d__ = new FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<OnCardUsed>d__24(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public IEnumerable<BattleAction> TakeEffect()
			{
				FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<TakeEffect>d__25 <TakeEffect>d__ = new FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<TakeEffect>d__25(-2);
				<TakeEffect>d__.<>4__this = this;
				return <TakeEffect>d__;
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectRemoving(StatusEffectEventArgs args)
			{
				FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<OnPlayerStatusEffectRemoving>d__26 <OnPlayerStatusEffectRemoving>d__ = new FlandreScarletCasinoSeDef.FlandreScarletCasinoSe.<OnPlayerStatusEffectRemoving>d__26(-2);
				<OnPlayerStatusEffectRemoving>d__.<>4__this = this;
				<OnPlayerStatusEffectRemoving>d__.<>3__args = args;
				return <OnPlayerStatusEffectRemoving>d__;
			}

			static int \u200E\u202D\u202E\u202A\u202C\u206A\u206F\u206A\u206E\u206F\u200B\u200E\u206E\u202A\u202E\u202E\u200E\u202C\u206B\u200B\u202A\u202C\u202D\u206D\u200E\u202A\u200C\u206F\u206F\u202C\u202E\u206B\u206C\u202A\u200C\u202C\u202C\u206D\u206A\u202D\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static bool \u202A\u202D\u200B\u206E\u202B\u206D\u200F\u206A\u202E\u206D\u202E\u200D\u206D\u206C\u202E\u202D\u202B\u206A\u202A\u200D\u206E\u200F\u202E\u200C\u206C\u202D\u200B\u202C\u200F\u200B\u200B\u202E\u202E\u202C\u200B\u202C\u200B\u206B\u206A\u206C\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u202E\u200E\u206D\u206C\u200B\u202E\u202B\u202A\u206F\u206D\u206D\u206C\u202C\u202E\u202D\u206F\u206C\u200B\u200C\u200D\u206C\u200E\u206D\u200B\u206E\u206D\u202B\u200F\u200E\u206F\u200D\u200D\u206A\u202B\u206D\u202A\u206D\u202C\u200F\u206F\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static string \u200F\u206A\u206E\u206C\u200B\u206D\u206F\u200F\u206E\u200B\u206C\u206D\u200B\u200D\u200F\u202A\u202D\u202D\u202E\u206F\u202A\u202B\u200F\u206A\u206A\u206D\u206A\u202B\u206C\u202E\u206B\u200D\u202C\u206D\u200E\u200B\u200C\u200D\u200C\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static int \u200D\u202A\u202A\u206D\u206B\u202A\u202B\u200B\u206C\u202E\u206B\u202A\u206D\u200F\u202C\u200C\u200B\u206A\u206A\u200C\u200D\u206B\u200F\u200C\u202B\u206A\u202C\u206D\u202C\u202C\u206F\u206C\u200B\u200C\u200B\u206E\u206F\u202E\u202A\u200F\u202E(StatusEffect A_0)
			{
				return A_0.Limit;
			}

			static void \u200B\u200F\u200F\u202E\u206F\u202C\u206A\u202D\u206D\u200D\u202C\u206A\u200B\u206D\u202C\u202D\u202A\u202B\u206F\u206B\u202C\u200D\u206E\u200D\u200F\u202C\u202D\u206E\u202D\u200D\u202D\u206B\u206A\u200B\u200F\u202B\u206E\u202A\u202D\u206E\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Count = A_1;
			}

			static BattleController \u202B\u206A\u202D\u206F\u200D\u202C\u206D\u206C\u206A\u202B\u200E\u206F\u200F\u206B\u206B\u202E\u200B\u206B\u200B\u206A\u206B\u200E\u200E\u206A\u202A\u206A\u202E\u200F\u200B\u206F\u200E\u202B\u202A\u206D\u206B\u200C\u200E\u206A\u206A\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202C\u200C\u202C\u206F\u206D\u200E\u200B\u206A\u200F\u206A\u200E\u206B\u206E\u202D\u206C\u202D\u200C\u202D\u206D\u200E\u206C\u206D\u202C\u200D\u206D\u200F\u200B\u206D\u200C\u200E\u200D\u200E\u206C\u200F\u202A\u202E\u200E\u202E\u200C\u206D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<CardUsingEventArgs> \u202A\u206B\u202D\u206B\u200D\u206E\u200D\u200F\u202E\u200F\u206F\u200B\u206A\u200E\u200D\u206B\u200D\u202B\u206E\u200B\u200F\u206A\u200C\u200D\u202E\u200D\u200B\u200B\u206A\u200F\u206B\u202D\u206B\u202C\u202C\u206C\u202E\u200C\u202E\u206B\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u202C\u202D\u202D\u206E\u200E\u206A\u202A\u206E\u206A\u206B\u200D\u206E\u200D\u206E\u206E\u206E\u202D\u206B\u200D\u206F\u206F\u206E\u206B\u206F\u202A\u202E\u202C\u200B\u202E\u200D\u206D\u202A\u200E\u206C\u206F\u202A\u206D\u202E\u200C\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static GameEvent<StatusEffectEventArgs> \u200D\u206C\u202C\u206F\u206C\u206F\u202E\u202E\u200C\u206A\u206E\u202B\u202C\u206F\u206C\u200F\u200C\u200F\u202B\u206B\u200D\u202A\u202D\u200B\u206E\u200D\u200E\u200C\u206B\u202B\u206A\u206E\u202D\u206C\u200E\u200D\u200B\u202E\u200F\u200D\u202E(Unit A_0)
			{
				return A_0.StatusEffectRemoving;
			}

			static GameRunController \u206A\u206C\u200E\u202E\u206C\u206B\u200D\u200C\u202B\u202D\u206C\u206E\u206F\u200D\u202B\u200E\u206A\u202B\u200D\u200B\u206C\u202A\u206F\u206C\u206F\u200D\u200D\u206B\u200C\u200D\u202C\u202D\u202A\u202E\u206A\u200C\u200D\u206C\u202D\u206D\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static PlayerUnit \u206C\u200C\u202E\u206B\u202D\u206D\u202C\u202D\u206B\u202B\u206D\u202B\u202D\u202D\u200C\u206E\u202C\u200F\u206C\u206A\u206E\u200E\u202C\u200F\u206E\u200D\u206A\u202A\u200C\u206A\u200C\u200F\u200C\u200B\u206E\u206F\u206C\u206D\u200E\u200D\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}
		}
	}
}
