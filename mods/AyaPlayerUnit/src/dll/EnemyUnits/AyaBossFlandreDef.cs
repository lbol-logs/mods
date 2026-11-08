using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using AyaShameimaru.Cards;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossFlandreDef : EnemyUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1982986125);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossFlandreDef.\u200B\u200C\u202B\u206B\u206C\u206A\u202E\u206A\u206C\u202C\u202D\u202A\u206A\u200B\u206B\u206B\u206B\u200D\u200F\u200D\u202A\u200C\u202D\u200E\u206E\u200C\u206D\u202C\u200C\u200F\u202B\u202A\u202C\u200C\u200B\u206F\u202C\u200F\u206F\u206F\u202E(BepinexPlugin.enemyUnitLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EnemyUnitConfig MakeConfig()
		{
			AyaBossFlandreDef.\u206B\u200C\u200D\u200E\u200C\u206E\u202D\u202D\u206F\u202C\u202C\u206D\u200C\u200F\u200C\u200D\u206F\u202E\u200C\u200F\u206C\u200D\u206A\u200B\u202A\u206F\u206E\u202C\u206E\u206E\u202A\u200B\u200B\u206B\u200C\u206A\u200C\u206C\u206C\u206B\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1746413144), () => BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1572489245)), null);
			string text = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1982986125);
			bool flag = true;
			bool flag2 = false;
			ManaColor[] array = new ManaColor[4];
			AyaBossFlandreDef.\u202E\u200C\u200E\u202A\u202E\u202D\u202C\u206F\u206B\u206F\u202C\u202D\u202A\u200E\u206E\u200C\u200E\u200F\u206D\u202D\u206A\u206E\u200B\u202E\u206F\u202A\u200C\u202C\u206F\u202D\u206E\u206A\u202B\u206F\u206B\u202B\u200D\u200B\u202D\u206F\u202E(array, fieldof(<PrivateImplementationDetails>.25099F91E8BC8DF51847A64ED93CFA9EA5D30712227E6E17C16A599FEABECCAD).FieldHandle);
			return new EnemyUnitConfig(text, flag, flag2, array, 10, null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(260023253), EnemyType.Boss, false, null, null, 405, new int?(6), new int?(12), new int?(24), new int?(48), new int?(5), new int?(45), new int?(1), new int?(15), new int?(450), new int?(7), new int?(14), new int?(28), new int?(56), new int?(8), new int?(90), new int?(2), new int?(30), new int?(495), new int?(8), new int?(16), new int?(32), new int?(64), new int?(9), new int?(135), new int?(3), new int?(45), new MinMax(100, 100), new MinMax(100, 100), new string[] { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206) }, new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262) }, new string[] { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276) }, new string[] { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276) });
		}

		static BatchLocalization \u200B\u200C\u202B\u206B\u206C\u206A\u202E\u206A\u206C\u202C\u202D\u202A\u206A\u200B\u206B\u206B\u206B\u200D\u200F\u200D\u202A\u200C\u202D\u200E\u206E\u200C\u206D\u202C\u200C\u200F\u202B\u202A\u202C\u200C\u200B\u206F\u202C\u200F\u206F\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static void \u206B\u200C\u200D\u200E\u200C\u206E\u202D\u202D\u206F\u202C\u202C\u206D\u200C\u200F\u200C\u200D\u206F\u202E\u200C\u200F\u206C\u200D\u206A\u200B\u202A\u206F\u206E\u202C\u206E\u206E\u202A\u200B\u200B\u206B\u200C\u206A\u200C\u206C\u206C\u206B\u202E(string A_0, Func<Sprite> A_1, Assembly A_2)
		{
			EnemyUnitTemplate.AddBossNodeIcon(A_0, A_1, A_2);
		}

		static void \u202E\u200C\u200E\u202A\u202E\u202D\u202C\u206F\u206B\u206F\u202C\u202D\u202A\u200E\u206E\u200C\u200E\u200F\u206D\u202D\u206A\u206E\u200B\u202E\u206F\u202A\u200C\u202C\u206F\u202D\u206E\u206A\u202B\u206F\u206B\u202B\u200D\u200B\u202D\u206F\u202E(Array A_0, RuntimeFieldHandle A_1)
		{
			RuntimeHelpers.InitializeArray(A_0, A_1);
		}

		[EntityLogic(typeof(AyaBossFlandreDef))]
		public sealed class AyaBossFlandre : EnemyUnit
		{
			private string AyaBossFlandreDemoMove1
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 1);
				}
			}

			private string AyaBossFlandreDemoMove2
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 2);
				}
			}

			private string AyaBossFlandreDemoMove3
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 3);
				}
			}

			private string AyaBossFlandreDemoMove4
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 4);
				}
			}

			private string AyaBossFlandreDemoMove5
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 5);
				}
			}

			private string AyaBossFlandreSpell1
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 1);
				}
			}

			private string AyaBossFlandreSpell2
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 2);
				}
			}

			private string AyaBossFlandreSpell3
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 3);
				}
			}

			private string AyaBossFlandreSpell4
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 4);
				}
			}

			private string AyaBossFlandreSpell5
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 5);
				}
			}

			private string AyaBossFlandreSpell6
			{
				get
				{
					return base.GetSpellCardName(new int?(6), 7);
				}
			}

			private string AyaBossFlandreSpell7
			{
				get
				{
					return base.GetSpellCardName(new int?(6), 8);
				}
			}

			private string AyaBossFlandreSpell8
			{
				get
				{
					return base.GetSpellCardName(new int?(6), 9);
				}
			}

			private string AyaBossFlandreSpell9
			{
				get
				{
					return base.GetSpellCardName(new int?(10), 11);
				}
			}

			private string AyaBossFlandreSpell10
			{
				get
				{
					return base.GetSpellCardName(new int?(12), 13);
				}
			}

			private string AyaBossFlandreMove1
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 14);
				}
			}

			private string AyaBossFlandreMove2
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 15);
				}
			}

			private string AyaBossFlandreMove3
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 16);
				}
			}

			private string AyaBossFlandreMove4
			{
				get
				{
					return base.GetSpellCardName(new int?(0), 17);
				}
			}

			private string AyaBossFlandreMove5
			{
				get
				{
					return base.GetSpellCardName(null, 18);
				}
			}

			private string AyaBossFlandreMove6
			{
				get
				{
					return base.GetSpellCardName(null, 19);
				}
			}

			private string AyaBossFlandreMove7
			{
				get
				{
					return base.GetSpellCardName(null, 20);
				}
			}

			private string AyaBossFlandreMove8
			{
				get
				{
					return base.GetSpellCardName(null, 21);
				}
			}

			private string AyaBossFlandreMove9
			{
				get
				{
					return base.GetSpellCardName(null, 22);
				}
			}

			private string AyaBossFlandreMove10
			{
				get
				{
					return base.GetSpellCardName(null, 23);
				}
			}

			private string AyaBossFlandreMove11
			{
				get
				{
					return base.GetSpellCardName(null, 24);
				}
			}

			public string AyaBossFlandreDemoMove11FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-579576598), true, true);
				}
			}

			public string AyaBossFlandreDemoMove12Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-601472747), true, true);
				}
			}

			public string AyaBossFlandreDemoMove13FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(2085457024), true, true);
				}
			}

			public string AyaBossFlandreDemoMove14FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1488749392), true, true);
				}
			}

			public string AyaBossFlandreDemoMove15Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-666446953), true, true);
				}
			}

			public string AyaBossFlandreDemoMove16FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(711272607), true, true);
				}
			}

			public string AyaBossFlandreDemoMove17Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1395585667), true, true);
				}
			}

			public string AyaBossFlandreDemoMove18FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834672484), true, true);
				}
			}

			public string AyaBossFlandreDemoMove19Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-507098409), true, true);
				}
			}

			public string AyaBossFlandreDemoMove21FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1893152569), true, true);
				}
			}

			public string AyaBossFlandreDemoMove22Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1384345441), true, true);
				}
			}

			public string AyaBossFlandreDemoMove23FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1653595263), true, true);
				}
			}

			public string AyaBossFlandreDemoMove24Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1027630310), true, true);
				}
			}

			public string AyaBossFlandreDemoMove25FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1482958116), true, true);
				}
			}

			public string AyaBossFlandreDemoMove26FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1031176299), true, true);
				}
			}

			public string AyaBossFlandreDemoMove27Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1380164678), true, true);
				}
			}

			public string AyaBossFlandreDemoMove28FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1576794866), true, true);
				}
			}

			public string AyaBossFlandreDemoMove29Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1648766695), true, true);
				}
			}

			public string AyaBossFlandreDemoMove210FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1620674381), true, true);
				}
			}

			public string AyaBossFlandreDemoMove211Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1343988013), true, true);
				}
			}

			public string AyaBossFlandreDemoMove31FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1091224984), true, true);
				}
			}

			public string AyaBossFlandreDemoMove32Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1361531074), true, true);
				}
			}

			public string AyaBossFlandreDemoMove33FlandreAnger
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-828471196), true, true);
				}
			}

			public string AyaBossFlandreDemoMove34FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1224274981), true, true);
				}
			}

			public string AyaBossFlandreDemoMove35FlandreSorrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-959822190), true, true);
				}
			}

			public string AyaBossFlandreDemoMove36Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(163968362), true, true);
				}
			}

			public string AyaBossFlandreDemoMove37FlandreSorrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(508301257), true, true);
				}
			}

			public string AyaBossFlandreDemoMove38Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-370269729), true, true);
				}
			}

			public string AyaBossFlandreDemoMove39FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1450248020), true, true);
				}
			}

			public string AyaBossFlandreDemoMove310FlandreSorrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(102976223), true, true);
				}
			}

			public string AyaBossFlandreDemoMove311FlandreAnger
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1782538653), true, true);
				}
			}

			public string AyaBossFlandreDemoMove312Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(841255277), true, true);
				}
			}

			public string AyaBossFlandreDemoMove313Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(480326065), true, true);
				}
			}

			public string AyaBossFlandreDemoMove314FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-749914694), true, true);
				}
			}

			public string AyaBossFlandreDemoMove315FlandreSorrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1427480954), true, true);
				}
			}

			public string AyaBossFlandreDemoMove316FlandreAnger
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-893858352), true, true);
				}
			}

			public string AyaBossFlandreDemoMove41Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1521459488), true, true);
				}
			}

			public string AyaBossFlandreDemoMove42FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2062080819), true, true);
				}
			}

			public string AyaBossFlandreDemoMove43Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(441415650), true, true);
				}
			}

			public string AyaBossFlandreDemoMove44FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(796683768), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4Normal5Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(724711939), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4Hidden6Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(955368560), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4Hidden7FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1130995430), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4Hidden8FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1851456999), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4HiddenFailure9Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1409993150), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4HiddenSuccess10Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-392716376), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4HiddenSuccess11Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1708671211), true, true);
				}
			}

			public string AyaBossFlandreDemoMove4HiddenSuccess12Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-635221542), true, true);
				}
			}

			public string AyaBossFlandreDemoMove51FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-856189576), true, true);
				}
			}

			public string AyaBossFlandreDemoMove52FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1698177314), true, true);
				}
			}

			public string AyaBossFlandreDemoMove53Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-66978180), true, true);
				}
			}

			public string AyaBossFlandreDemoMove54FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1951116736), true, true);
				}
			}

			public string AyaBossFlandreDemoMove55Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-948382279), true, true);
				}
			}

			public string AyaBossFlandreDemoLastWord1FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-139447654), true, true);
				}
			}

			public string AyaBossFlandreDemoLose1FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-600808608), true, true);
				}
			}

			public string AyaBossFlandreDemoLose2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(945715857), true, true);
				}
			}

			public string AyaBossFlandreDemoLose3FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1461224012), true, true);
				}
			}

			public string AyaBossFlandreDemoWin1FlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(804907349), true, true);
				}
			}

			public string AyaBossFlandreSpell11Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1390941489), true, true);
				}
			}

			public string AyaBossFlandreSpell21Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1362737040), true, true);
				}
			}

			public string AyaBossFlandreSpell31Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1477318707), true, true);
				}
			}

			public string AyaBossFlandreSpell32Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2098904198), true, true);
				}
			}

			public string AyaBossFlandreSpell33Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(173101915), true, true);
				}
			}

			public string AyaBossFlandreSpell3DefeatFlandreJoy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-170952358), true, true);
				}
			}

			public string AyaBossFlandreSpell3DefeatFlandreAnger
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1094605288), true, true);
				}
			}

			public string AyaBossFlandreSpell3DefeatFlandreSorrow
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2065142564), true, true);
				}
			}

			public string AyaBossFlandreSpell3DefeatFlandrePleasure
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1543835898), true, true);
				}
			}

			public string AyaBossFlandreMove11Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1757401236), true, true);
				}
			}

			public string AyaBossFlandreMove12Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-808447191), true, true);
				}
			}

			public string AyaBossFlandreMove21Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1109468318), true, true);
				}
			}

			public string AyaBossFlandreMove22Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-132230343), true, true);
				}
			}

			public string AyaBossFlandreMove31Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1069513410), true, true);
				}
			}

			public string AyaBossFlandreMove32Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(543986505), true, true);
				}
			}

			public string AyaBossFlandreMove41Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-861581374), true, true);
				}
			}

			public string AyaBossFlandreMove42Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1347874010), true, true);
				}
			}

			public string AyaBossFlandreMove51Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-737637902), true, true);
				}
			}

			public string AyaBossFlandreMove52Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1667454453), true, true);
				}
			}

			public string AyaBossFlandreMove61Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-613694430), true, true);
				}
			}

			public string AyaBossFlandreMove62Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1634149179), true, true);
				}
			}

			public string AyaBossFlandreMove71Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(650605950), true, true);
				}
			}

			public string AyaBossFlandreMove72Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2239765), true, true);
				}
			}

			public string AyaBossFlandreMove81Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1415597124), true, true);
				}
			}

			public string AyaBossFlandreMove82Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-369896551), true, true);
				}
			}

			public string AyaBossFlandreMove91Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(139634452), true, true);
				}
			}

			public string AyaBossFlandreMove92Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(306320297), true, true);
				}
			}

			public string AyaBossFlandreMove101Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-117920542), true, true);
				}
			}

			public string AyaBossFlandreMove102Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2091534842), true, true);
				}
			}

			public string AyaBossFlandreJoyName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1320645569), true, true);
				}
			}

			public string AyaBossFlandreAngerName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(151033278), true, true);
				}
			}

			public string AyaBossFlandreSorrowName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1097220924), true, true);
				}
			}

			public string AyaBossFlandrePleasureName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1791901752), true, true);
				}
			}

			public override string Name
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					switch (this.Clone)
					{
					case 0:
						goto IL_01D6;
					case 1:
						break;
					case 2:
						goto IL_00C8;
					case 3:
						goto IL_0122;
					case 4:
						goto IL_017C;
					default:
						for (;;)
						{
							IL_0021:
							int num = -758633258;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-(uint)(-(~num2) * 38555221))) % 8U)
								{
								case 1U:
									goto IL_006E;
								case 2U:
									goto IL_01D6;
								case 3U:
									goto IL_00C8;
								case 4U:
									goto IL_017C;
								case 5U:
									num = (int)((num3 * 1566044285U) ^ 581175902U);
									continue;
								case 6U:
									goto IL_0122;
								case 7U:
									goto IL_0021;
								}
								goto Block_1;
							}
						}
						Block_1:
						throw AyaBossFlandreDef.AyaBossFlandre.\u206B\u202E\u206C\u206C\u200F\u200B\u200D\u206B\u206D\u200D\u202C\u206C\u206E\u206F\u200F\u202C\u206B\u202C\u206C\u206F\u202B\u202D\u202E\u202A\u202C\u200F\u206B\u202E\u206B\u200C\u200C\u202B\u206B\u200D\u206B\u200F\u202B\u202C\u206E\u206A\u202E();
					}
					IL_006E:
					return AyaBossFlandreDef.AyaBossFlandre.\u206E\u206F\u202D\u200D\u202E\u206D\u200C\u200D\u200C\u202B\u202E\u202C\u206E\u200C\u206F\u200F\u202D\u206C\u200F\u200C\u206E\u200C\u206F\u202E\u202C\u206F\u206A\u202D\u200F\u202A\u200F\u200D\u200C\u202D\u206B\u202C\u200C\u206B\u206C\u202C\u202E(new string[]
					{
						<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1211807778),
						AyaBossFlandreDef.AyaBossFlandre.\u206F\u202C\u202E\u206F\u206A\u202A\u202A\u206F\u206B\u200D\u200D\u206F\u202D\u202B\u200B\u206A\u206D\u202E\u202A\u202A\u206A\u206C\u200E\u202E\u202B\u206A\u206D\u200D\u202C\u200D\u206A\u200C\u206F\u206E\u206A\u202D\u206D\u206F\u202C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200B\u206F\u202B\u202B\u206F\u200B\u200D\u202B\u206D\u206B\u200D\u202B\u200B\u200C\u206D\u200F\u206B\u200F\u206A\u200E\u202D\u206C\u200E\u202A\u206B\u200C\u206D\u202D\u202C\u200D\u202B\u200B\u206F\u200C\u202B\u200E\u206D\u206D\u200F\u206E\u202E(this)),
						<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1813797901),
						this.AyaBossFlandreJoyName,
						<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1301113464)
					});
					IL_00C8:
					return AyaBossFlandreDef.AyaBossFlandre.\u206E\u206F\u202D\u200D\u202E\u206D\u200C\u200D\u200C\u202B\u202E\u202C\u206E\u200C\u206F\u200F\u202D\u206C\u200F\u200C\u206E\u200C\u206F\u202E\u202C\u206F\u206A\u202D\u200F\u202A\u200F\u200D\u200C\u202D\u206B\u202C\u200C\u206B\u206C\u202C\u202E(new string[]
					{
						<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1211807778),
						AyaBossFlandreDef.AyaBossFlandre.\u206F\u202C\u202E\u206F\u206A\u202A\u202A\u206F\u206B\u200D\u200D\u206F\u202D\u202B\u200B\u206A\u206D\u202E\u202A\u202A\u206A\u206C\u200E\u202E\u202B\u206A\u206D\u200D\u202C\u200D\u206A\u200C\u206F\u206E\u206A\u202D\u206D\u206F\u202C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200B\u206F\u202B\u202B\u206F\u200B\u200D\u202B\u206D\u206B\u200D\u202B\u200B\u200C\u206D\u200F\u206B\u200F\u206A\u200E\u202D\u206C\u200E\u202A\u206B\u200C\u206D\u202D\u202C\u200D\u202B\u200B\u206F\u200C\u202B\u200E\u206D\u206D\u200F\u206E\u202E(this)),
						<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-209453730),
						this.AyaBossFlandreAngerName,
						<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-864226535)
					});
					IL_0122:
					return AyaBossFlandreDef.AyaBossFlandre.\u206E\u206F\u202D\u200D\u202E\u206D\u200C\u200D\u200C\u202B\u202E\u202C\u206E\u200C\u206F\u200F\u202D\u206C\u200F\u200C\u206E\u200C\u206F\u202E\u202C\u206F\u206A\u202D\u200F\u202A\u200F\u200D\u200C\u202D\u206B\u202C\u200C\u206B\u206C\u202C\u202E(new string[]
					{
						<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1211807778),
						AyaBossFlandreDef.AyaBossFlandre.\u206F\u202C\u202E\u206F\u206A\u202A\u202A\u206F\u206B\u200D\u200D\u206F\u202D\u202B\u200B\u206A\u206D\u202E\u202A\u202A\u206A\u206C\u200E\u202E\u202B\u206A\u206D\u200D\u202C\u200D\u206A\u200C\u206F\u206E\u206A\u202D\u206D\u206F\u202C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200B\u206F\u202B\u202B\u206F\u200B\u200D\u202B\u206D\u206B\u200D\u202B\u200B\u200C\u206D\u200F\u206B\u200F\u206A\u200E\u202D\u206C\u200E\u202A\u206B\u200C\u206D\u202D\u202C\u200D\u202B\u200B\u206F\u200C\u202B\u200E\u206D\u206D\u200F\u206E\u202E(this)),
						<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-209453730),
						this.AyaBossFlandreSorrowName,
						<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1849029676)
					});
					IL_017C:
					return AyaBossFlandreDef.AyaBossFlandre.\u206E\u206F\u202D\u200D\u202E\u206D\u200C\u200D\u200C\u202B\u202E\u202C\u206E\u200C\u206F\u200F\u202D\u206C\u200F\u200C\u206E\u200C\u206F\u202E\u202C\u206F\u206A\u202D\u200F\u202A\u200F\u200D\u200C\u202D\u206B\u202C\u200C\u206B\u206C\u202C\u202E(new string[]
					{
						<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2032253995),
						AyaBossFlandreDef.AyaBossFlandre.\u206F\u202C\u202E\u206F\u206A\u202A\u202A\u206F\u206B\u200D\u200D\u206F\u202D\u202B\u200B\u206A\u206D\u202E\u202A\u202A\u206A\u206C\u200E\u202E\u202B\u206A\u206D\u200D\u202C\u200D\u206A\u200C\u206F\u206E\u206A\u202D\u206D\u206F\u202C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200B\u206F\u202B\u202B\u206F\u200B\u200D\u202B\u206D\u206B\u200D\u202B\u200B\u200C\u206D\u200F\u206B\u200F\u206A\u200E\u202D\u206C\u200E\u202A\u206B\u200C\u206D\u202D\u202C\u200D\u202B\u200B\u206F\u200C\u202B\u200E\u206D\u206D\u200F\u206E\u202E(this)),
						<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-209453730),
						this.AyaBossFlandrePleasureName,
						<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1301113464)
					});
					IL_01D6:
					return this.\u200E\u206E\u206C\u200E\u202E\u206D\u206C\u200E\u206B\u200E\u202E\u206D\u202A\u200B\u206F\u202C\u206A\u202C\u200C\u200E\u202D\u202D\u206A\u206F\u200B\u202A\u206D\u202E\u206E\u200E\u200D\u206E\u202E\u202B\u200E\u206E\u206A\u202B\u206B\u202D\u202E();
				}
			}

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Next { get; set; }

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Next2 { get; set; }

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Next3 { get; set; }

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Next4 { get; set; }

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnterBattle(BattleController battle)
			{
				if (AyaBossFlandreDef.AyaBossFlandre.\u200C\u202B\u202B\u202C\u200C\u200D\u202A\u200B\u206D\u200E\u200C\u206C\u206F\u200E\u206E\u200E\u206F\u206F\u202D\u202B\u206D\u200E\u200D\u200F\u206E\u206C\u200E\u206B\u206B\u200F\u206D\u202E\u202B\u202D\u200C\u202E\u200F\u200E\u202C\u202C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200C\u202C\u202C\u200F\u206C\u206F\u200E\u200D\u202B\u206F\u206A\u202A\u200E\u200C\u206A\u206A\u206B\u206C\u200B\u200D\u206B\u200B\u206E\u206C\u202C\u206B\u202A\u200D\u200E\u200E\u202A\u206B\u206A\u200B\u202E\u206D\u200B\u202E\u206E\u206C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200F\u200E\u200F\u200D\u202D\u206B\u206B\u200C\u202D\u206F\u206C\u206F\u206B\u200F\u202E\u206C\u206B\u206F\u202E\u202A\u202A\u206E\u200B\u202D\u206A\u206C\u202A\u202E\u200C\u202B\u200B\u206B\u206A\u200C\u206E\u206A\u202B\u200D\u206F\u206C\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this))), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1299763164)))
				{
					for (;;)
					{
						IL_0026:
						int num = 1190516887;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(788992695 - -num2 - --1602546215 - -498286565)) % 11U)
							{
							case 0U:
								goto IL_0109;
							case 1U:
								base.CountDown = 4;
								num = (int)((num3 * 326191886U) ^ 1163598391U);
								continue;
							case 3U:
								goto IL_0026;
							case 4U:
								base.ReactBattleEvent<DieEventArgs>(AyaBossFlandreDef.AyaBossFlandre.\u200D\u206E\u202C\u206D\u202E\u202E\u200E\u206B\u200D\u202B\u202A\u206E\u202B\u202E\u200F\u206A\u202B\u200C\u202B\u206E\u206F\u206A\u202B\u202D\u206C\u202E\u202A\u200F\u202C\u206C\u206F\u200F\u206D\u202D\u202A\u200D\u206D\u206E\u200F\u206E\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this))), new Func<DieEventArgs, IEnumerable<BattleAction>>(this.OnDemoPlayerDying), (GameEventPriority)99);
								num = (int)((num3 * 2066645851U) ^ 342465304U);
								continue;
							case 5U:
								goto IL_0154;
							case 6U:
								base.HandleBattleEvent<CardUsingEventArgs>(AyaBossFlandreDef.AyaBossFlandre.\u200D\u206E\u206F\u200F\u206A\u206E\u200E\u206A\u200F\u206C\u200E\u206F\u202A\u206E\u202C\u202A\u202C\u202B\u206E\u200F\u202B\u206D\u202A\u206C\u206E\u200C\u206B\u202D\u202D\u206B\u206F\u200C\u206E\u206F\u206A\u206D\u202E\u200C\u206E\u206D\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this)), new GameEventHandler<CardUsingEventArgs>(this.OnDemoCardUsed));
								num = (int)((num3 * 3921865088U) ^ 2565461077U);
								continue;
							case 7U:
								num = (int)(((!(AyaBossFlandreDef.AyaBossFlandre.\u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this)) is FlandrePlayerUnitDef.FlandrePlayerUnit)) ? 3770283860U : 3555789474U) ^ (num3 * 2423501379U));
								continue;
							case 8U:
								this.Next = this.demoMoves.Without(AyaBossFlandreDef.AyaBossFlandre.MoveType.ToryanseToryanse).Sample(base.EnemyMoveRng);
								this.Next2 = AyaBossFlandreDef.AyaBossFlandre.MoveType.None;
								num = (int)((num3 * 2552165708U) ^ 3912570940U);
								continue;
							case 9U:
								this.Next3 = AyaBossFlandreDef.AyaBossFlandre.MoveType.None;
								this.Next4 = AyaBossFlandreDef.AyaBossFlandre.MoveType.None;
								num = (int)((num3 * 1736288693U) ^ 599129381U);
								continue;
							case 10U:
								base.ReactBattleEvent<DieEventArgs>(AyaBossFlandreDef.AyaBossFlandre.\u200C\u206B\u206C\u200C\u206B\u200C\u200F\u206F\u206D\u202C\u200B\u200C\u200F\u206F\u206B\u202B\u206D\u206C\u200C\u202B\u202A\u200C\u200D\u200B\u200F\u206F\u200C\u202A\u200B\u200D\u202D\u200D\u206C\u200C\u202E\u202B\u200E\u200F\u200E\u206A\u202E(this), new Func<DieEventArgs, IEnumerable<BattleAction>>(this.OnDemoDying), (GameEventPriority)99);
								num = (int)((num3 * 1704172211U) ^ 2855732836U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					goto IL_01EA;
					IL_0109:
					throw AyaBossFlandreDef.AyaBossFlandre.\u202B\u206D\u200D\u202A\u206C\u206F\u202B\u202B\u200D\u200E\u202C\u206A\u202D\u200C\u200B\u202D\u206E\u202C\u206F\u202E\u206D\u202A\u200C\u206C\u200D\u200C\u202B\u202A\u202B\u206D\u200B\u202E\u202D\u202A\u202C\u206E\u206F\u200B\u202D\u202A\u202E();
					IL_0154:
					base.HandleBattleEvent<CardUsingEventArgs>(AyaBossFlandreDef.AyaBossFlandre.\u200D\u200B\u200D\u206C\u200B\u206B\u206D\u202E\u200D\u200F\u206C\u200B\u206F\u202C\u200D\u200E\u206F\u200E\u200C\u206B\u206B\u206B\u206C\u200B\u202C\u200D\u206C\u202E\u200D\u202C\u202B\u202A\u206D\u200E\u202D\u200E\u206E\u200F\u200D\u206D\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this)), new GameEventHandler<CardUsingEventArgs>(this.OnDemoCardUsed));
					return;
				}
				IL_01EA:
				throw AyaBossFlandreDef.AyaBossFlandre.\u202B\u206D\u200D\u202A\u206C\u206F\u202B\u202B\u200D\u200E\u202C\u206A\u202D\u200C\u200B\u202D\u206E\u202C\u206F\u202E\u206D\u202A\u200C\u206C\u200D\u200C\u202B\u202A\u202B\u206D\u200B\u202E\u202D\u202A\u202C\u206E\u206F\u200B\u202D\u202A\u202E();
			}

			private void OnDemoCardUsed(CardUsingEventArgs args)
			{
				if (!this.DemoLastWordUsed)
				{
					goto IL_000B;
				}
				goto IL_00EE;
				int num2;
				for (;;)
				{
					IL_0010:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(uint)((num ^ (~(-992254599 - 1193008216) - (-765841295 * -360876851 + (1076946260 ^ -516851749)))) - (-641018824 - 1684825088 - ~-1800014535) - 2138908483 * 909742717))) % 7U)
					{
					case 1U:
						num2 = (int)(((!(AyaBossFlandreDef.AyaBossFlandre.\u200D\u200B\u206E\u206E\u206C\u206B\u200F\u200E\u202C\u200C\u206D\u206E\u200D\u200B\u206A\u202E\u206D\u206E\u206C\u206B\u206C\u202E\u200C\u206A\u206B\u200F\u202D\u200C\u202B\u202E\u202E\u206B\u206B\u206C\u200B\u206C\u200B\u202E\u206A\u200F\u202E(args) is FlandreForbiddenScarletCuriosityDef.FlandreForbiddenScarletCuriosity)) ? 738188509U : 640489251U) ^ (num3 * 680253182U));
						continue;
					case 2U:
						goto IL_000B;
					case 3U:
						AyaBossFlandreDef.AyaBossFlandre.\u206A\u200D\u202D\u202A\u202C\u200C\u200B\u200F\u202E\u202A\u202C\u202A\u206D\u202B\u206C\u202D\u200D\u200B\u206B\u202E\u206A\u206B\u206A\u206A\u206B\u202A\u200F\u200C\u206B\u206B\u206D\u200F\u202C\u200C\u202C\u202B\u202D\u206D\u200C\u202E(Singleton<GameMaster>.Instance, this.<OnDemoCardUsed>g__coroutine|260_0());
						num2 = -117654630;
						continue;
					case 4U:
						num2 = (int)(((!(AyaBossFlandreDef.AyaBossFlandre.\u200D\u200B\u206E\u206E\u206C\u206B\u200F\u200E\u202C\u200C\u206D\u206E\u200D\u200B\u206A\u202E\u206D\u206E\u206C\u206B\u206C\u202E\u200C\u206A\u206B\u200F\u202D\u200C\u202B\u202E\u202E\u206B\u206B\u206C\u200B\u206C\u200B\u202E\u206A\u200F\u202E(args) is FlandreScarletCasinoDef.FlandreScarletCasino)) ? 3734207498U : 2900064945U) ^ (num3 * 2764608816U));
						continue;
					case 5U:
						goto IL_00EE;
					case 6U:
						num2 = (int)(((!(AyaBossFlandreDef.AyaBossFlandre.\u200D\u200B\u206E\u206E\u206C\u206B\u200F\u200E\u202C\u200C\u206D\u206E\u200D\u200B\u206A\u202E\u206D\u206E\u206C\u206B\u206C\u202E\u200C\u206A\u206B\u200F\u202D\u200C\u202B\u202E\u202E\u206B\u206B\u206C\u200B\u206C\u200B\u202E\u206A\u200F\u202E(args) is FlandreRipplesof495YearsDef.FlandreRipplesof495Years)) ? 466355940U : 1968990129U) ^ (num3 * 2078428988U));
						continue;
					}
					break;
				}
				return;
				IL_000B:
				num2 = -701652360;
				goto IL_0010;
				IL_00EE:
				AyaBossFlandreDef.AyaBossFlandre.\u206C\u206C\u206E\u200B\u202C\u206F\u200B\u206F\u202E\u200B\u206E\u202D\u200B\u202C\u200E\u202D\u206C\u200B\u206F\u206D\u206F\u200B\u200F\u202A\u202A\u202D\u200F\u200B\u202B\u206B\u202C\u200B\u200E\u200C\u206C\u202A\u202C\u200F\u202C\u202E(this);
				num2 = -924167288;
				goto IL_0010;
			}

			private IEnumerable<BattleAction> OnDemoPlayerDying(DieEventArgs args)
			{
				AyaBossFlandreDef.AyaBossFlandre.<OnDemoPlayerDying>d__261 <OnDemoPlayerDying>d__ = new AyaBossFlandreDef.AyaBossFlandre.<OnDemoPlayerDying>d__261(-2);
				<OnDemoPlayerDying>d__.<>4__this = this;
				<OnDemoPlayerDying>d__.<>3__args = args;
				return <OnDemoPlayerDying>d__;
			}

			private IEnumerable<BattleAction> OnDemoDying(DieEventArgs args)
			{
				AyaBossFlandreDef.AyaBossFlandre.<OnDemoDying>d__262 <OnDemoDying>d__ = new AyaBossFlandreDef.AyaBossFlandre.<OnDemoDying>d__262(-2);
				<OnDemoDying>d__.<>4__this = this;
				<OnDemoDying>d__.<>3__args = args;
				return <OnDemoDying>d__;
			}

			public override void OnSpawn(EnemyUnit spawner)
			{
				base.React(new LazySequencedReactor(this.DemoSpawn));
			}

			private IEnumerable<BattleAction> DemoSpawn()
			{
				AyaBossFlandreDef.AyaBossFlandre.<DemoSpawn>d__264 <DemoSpawn>d__ = new AyaBossFlandreDef.AyaBossFlandre.<DemoSpawn>d__264(-2);
				<DemoSpawn>d__.<>4__this = this;
				return <DemoSpawn>d__;
			}

			private IEnumerable<BattleAction> AyaBossFlandreDemoMove1Actions()
			{
				AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove1Actions>d__265 <AyaBossFlandreDemoMove1Actions>d__ = new AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove1Actions>d__265(-2);
				<AyaBossFlandreDemoMove1Actions>d__.<>4__this = this;
				return <AyaBossFlandreDemoMove1Actions>d__;
			}

			private IEnumerable<BattleAction> AyaBossFlandreDemoMove2Actions()
			{
				AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove2Actions>d__266 <AyaBossFlandreDemoMove2Actions>d__ = new AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove2Actions>d__266(-2);
				<AyaBossFlandreDemoMove2Actions>d__.<>4__this = this;
				return <AyaBossFlandreDemoMove2Actions>d__;
			}

			private IEnumerable<BattleAction> AyaBossFlandreDemoMove3Actions()
			{
				AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove3Actions>d__267 <AyaBossFlandreDemoMove3Actions>d__ = new AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove3Actions>d__267(-2);
				<AyaBossFlandreDemoMove3Actions>d__.<>4__this = this;
				return <AyaBossFlandreDemoMove3Actions>d__;
			}

			private IEnumerable<BattleAction> AyaBossFlandreDemoMove4Actions()
			{
				AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove4Actions>d__269 <AyaBossFlandreDemoMove4Actions>d__ = new AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove4Actions>d__269(-2);
				<AyaBossFlandreDemoMove4Actions>d__.<>4__this = this;
				return <AyaBossFlandreDemoMove4Actions>d__;
			}

			private IEnumerable<BattleAction> AyaBossFlandreDemoMove5Actions()
			{
				AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove5Actions>d__270 <AyaBossFlandreDemoMove5Actions>d__ = new AyaBossFlandreDef.AyaBossFlandre.<AyaBossFlandreDemoMove5Actions>d__270(-2);
				<AyaBossFlandreDemoMove5Actions>d__.<>4__this = this;
				return <AyaBossFlandreDemoMove5Actions>d__;
			}

			private int MistilteinnDamage
			{
				get
				{
					return base.Damage3 + AyaBossFlandreDef.AyaBossFlandre.\u206C\u206A\u202C\u200E\u202D\u206D\u200E\u206E\u206C\u206C\u200F\u206A\u206E\u200E\u200D\u200E\u206B\u206E\u206C\u202A\u200E\u202D\u206F\u202A\u206C\u206B\u206C\u202B\u200D\u200E\u206F\u202C\u200B\u202E\u202D\u206B\u206D\u206F\u202C\u206A\u202E(this);
				}
			}

			private int ThreeofaKindDamage
			{
				get
				{
					return AyaBossFlandreDef.AyaBossFlandre.\u200F\u202B\u206C\u206D\u200B\u206D\u200B\u206D\u206C\u200B\u206E\u206B\u202E\u202C\u200E\u206E\u200F\u206D\u202A\u202B\u200D\u202A\u200C\u200E\u200E\u200D\u200E\u200F\u202C\u206D\u206E\u200F\u202B\u206C\u202D\u200E\u206A\u202E\u206B\u202E((float)AyaBossFlandreDef.AyaBossFlandre.\u202B\u206A\u202E\u202D\u200D\u206D\u202C\u206F\u202B\u202D\u200D\u200D\u200D\u206B\u200E\u200F\u202B\u206D\u202B\u200B\u202A\u202E\u206B\u200C\u202C\u202C\u206F\u200E\u206B\u206F\u200C\u200B\u206A\u200C\u206C\u200C\u202B\u200C\u200E\u202B\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this))) * 0.5f, MidpointRounding.AwayFromZero) + AyaBossFlandreDef.AyaBossFlandre.\u200F\u202B\u206C\u206D\u200B\u206D\u200B\u206D\u206C\u200B\u206E\u206B\u202E\u202C\u200E\u206E\u200F\u206D\u202A\u202B\u200D\u202A\u200C\u200E\u200E\u200D\u200E\u200F\u202C\u206D\u206E\u200F\u202B\u206C\u202D\u200E\u206A\u202E\u206B\u202E((float)AyaBossFlandreDef.AyaBossFlandre.\u200F\u206E\u202B\u206F\u206E\u200E\u206B\u200C\u200C\u200D\u200F\u202D\u206A\u200B\u200E\u206A\u200D\u202C\u206B\u200B\u200C\u206B\u206D\u200F\u202A\u202D\u206F\u202E\u200F\u206E\u202C\u202D\u206B\u206D\u206F\u202D\u200B\u202C\u200B\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this))) * 0.666f, MidpointRounding.AwayFromZero) + AyaBossFlandreDef.AyaBossFlandre.\u200F\u202B\u206C\u206D\u200B\u206D\u200B\u206D\u206C\u200B\u206E\u206B\u202E\u202C\u200E\u206E\u200F\u206D\u202A\u202B\u200D\u202A\u200C\u200E\u200E\u200D\u200E\u200F\u202C\u206D\u206E\u200F\u202B\u206C\u202D\u200E\u206A\u202E\u206B\u202E((float)AyaBossFlandreDef.AyaBossFlandre.\u200F\u200E\u202A\u202B\u200F\u200F\u200D\u202E\u206E\u206C\u200C\u202A\u200B\u200B\u202B\u200F\u206D\u200C\u200D\u206B\u206C\u202A\u200D\u202B\u206F\u206A\u206A\u206E\u200D\u206A\u200D\u200F\u200F\u206C\u206D\u202A\u200E\u206A\u200F\u206D\u202E(AyaBossFlandreDef.AyaBossFlandre.\u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(AyaBossFlandreDef.AyaBossFlandre.\u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(this))) * 0.666f, MidpointRounding.AwayFromZero);
				}
			}

			protected override IEnumerable<IEnemyMove> GetTurnMoves()
			{
				AyaBossFlandreDef.AyaBossFlandre.<GetTurnMoves>d__281 <GetTurnMoves>d__ = new AyaBossFlandreDef.AyaBossFlandre.<GetTurnMoves>d__281(-2);
				<GetTurnMoves>d__.<>4__this = this;
				return <GetTurnMoves>d__;
			}

			protected override void UpdateMoveCounters()
			{
				int countDown = base.CountDown;
				base.CountDown = countDown - 1;
				if (this.Next != AyaBossFlandreDef.AyaBossFlandre.MoveType.None)
				{
					for (;;)
					{
						IL_001D:
						int num = -1209150112;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(num2 - (-273787861 - (1440777227 - -470433370) + ((-1503353040 + -1164765459) ^ ~1990834644)) + ((-431089776 ^ -241486151) - (-1588031030 - -471680893)) - -228941411 - -1844231266)) % 6U)
							{
							case 0U:
								goto IL_001D;
							case 1U:
								goto IL_00CE;
							case 3U:
								this.Prev1 = this.Next;
								this.Next = this.demoMoves.Without(this.Prev1).Without(this.Prev2).Sample(base.EnemyMoveRng);
								num = (int)((num3 * 2229553977U) ^ 1038798632U);
								continue;
							case 4U:
								this.Prev2 = this.Prev1;
								num = -601748190;
								continue;
							case 5U:
								num = (int)(((base.CountDown <= 0) ? 4224175228U : 2165759759U) ^ (num3 * 1290764272U));
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					return;
					IL_00CE:
					this.Next = AyaBossFlandreDef.AyaBossFlandre.MoveType.ThreeofaKind;
					return;
				}
			}

			// Note: this type is marked as 'beforefieldinit'.
			[MethodImpl(MethodImplOptions.NoInlining)]
			static AyaBossFlandre()
			{
				for (;;)
				{
					IL_0017:
					int num = 1449833562;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)(-num2 * -199679609)))) % 4U)
						{
						case 1U:
							AyaBossFlandreDef.AyaBossFlandre.scene2 = AyaBossFlandreDef.AyaBossFlandre.\u202E\u200F\u200B\u206B\u202E\u206C\u202B\u202E\u202D\u200C\u206F\u200B\u206F\u206A\u202B\u200B\u200B\u200D\u202C\u206C\u206D\u200E\u202E\u200D\u206B\u200D\u200E\u206F\u202E\u200C\u200E\u206E\u206D\u206F\u202B\u200C\u206C\u202E\u202A\u202D\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(776180452), null);
							num = (int)((num3 * 372005311U) ^ 3627473547U);
							continue;
						case 2U:
							AyaBossFlandreDef.AyaBossFlandre.scene1 = AyaBossFlandreDef.AyaBossFlandre.\u202E\u200F\u200B\u206B\u202E\u206C\u202B\u202E\u202D\u200C\u206F\u200B\u206F\u206A\u202B\u200B\u200B\u200D\u202C\u206C\u206D\u200E\u202E\u200D\u206B\u200D\u200E\u206F\u202E\u200C\u200E\u206E\u206D\u206F\u202B\u200C\u206C\u202E\u202A\u202D\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-789637509), null);
							num = (int)((num3 * 2699451109U) ^ 2184648043U);
							continue;
						case 3U:
							goto IL_0017;
						}
						return;
					}
				}
			}

			[CompilerGenerated]
			private IEnumerator <OnDemoCardUsed>g__coroutine|260_0()
			{
				AyaBossFlandreDef.AyaBossFlandre.<<OnDemoCardUsed>g__coroutine|260_0>d <<OnDemoCardUsed>g__coroutine|260_0>d = new AyaBossFlandreDef.AyaBossFlandre.<<OnDemoCardUsed>g__coroutine|260_0>d(0);
				<<OnDemoCardUsed>g__coroutine|260_0>d.<>4__this = this;
				return <<OnDemoCardUsed>g__coroutine|260_0>d;
			}

			string \u200E\u206E\u206C\u200E\u202E\u206D\u206C\u200E\u206B\u200E\u202E\u206D\u202A\u200B\u206F\u202C\u206A\u202C\u200C\u200E\u202D\u202D\u206A\u206F\u200B\u202A\u206D\u202E\u206E\u200E\u200D\u206E\u202E\u202B\u200E\u206E\u206A\u202B\u206B\u202D\u202E()
			{
				return base.Name;
			}

			static EnemyUnitConfig \u200B\u206F\u202B\u202B\u206F\u200B\u200D\u202B\u206D\u206B\u200D\u202B\u200B\u200C\u206D\u200F\u206B\u200F\u206A\u200E\u202D\u206C\u200E\u202A\u206B\u200C\u206D\u202D\u202C\u200D\u202B\u200B\u206F\u200C\u202B\u200E\u206D\u206D\u200F\u206E\u202E(EnemyUnit A_0)
			{
				return A_0.Config;
			}

			static string \u206F\u202C\u202E\u206F\u206A\u202A\u202A\u206F\u206B\u200D\u200D\u206F\u202D\u202B\u200B\u206A\u206D\u202E\u202A\u202A\u206A\u206C\u200E\u202E\u202B\u206A\u206D\u200D\u202C\u200D\u206A\u200C\u206F\u206E\u206A\u202D\u206D\u206F\u202C\u202E(EnemyUnitConfig A_0)
			{
				return A_0.NarrativeColor;
			}

			static string \u206E\u206F\u202D\u200D\u202E\u206D\u200C\u200D\u200C\u202B\u202E\u202C\u206E\u200C\u206F\u200F\u202D\u206C\u200F\u200C\u206E\u200C\u206F\u202E\u202C\u206F\u206A\u202D\u200F\u202A\u200F\u200D\u200C\u202D\u206B\u202C\u200C\u206B\u206C\u202C\u202E(string[] A_0)
			{
				return string.Concat(A_0);
			}

			static ArgumentOutOfRangeException \u206B\u202E\u206C\u206C\u200F\u200B\u200D\u206B\u206D\u200D\u202C\u206C\u206E\u206F\u200F\u202C\u206B\u202C\u206C\u206F\u202B\u202D\u202E\u202A\u202C\u200F\u206B\u202E\u206B\u200C\u200C\u202B\u206B\u200D\u206B\u200F\u202B\u202C\u206E\u206A\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static BattleController \u202B\u206C\u206D\u200B\u206A\u200C\u206A\u206C\u202E\u206D\u200F\u206E\u206F\u206A\u206E\u202B\u206B\u202E\u200F\u206A\u206E\u202D\u202D\u206D\u202A\u206D\u206C\u206B\u206B\u202D\u202A\u202E\u206D\u206A\u202A\u200C\u202E\u200F\u202B\u202A\u202E(Unit A_0)
			{
				return A_0.Battle;
			}

			static EnemyGroup \u200F\u200E\u200F\u200D\u202D\u206B\u206B\u200C\u202D\u206F\u206C\u206F\u206B\u200F\u202E\u206C\u206B\u206F\u202E\u202A\u202A\u206E\u200B\u202D\u206A\u206C\u202A\u202E\u200C\u202B\u200B\u206B\u206A\u200C\u206E\u206A\u202B\u200D\u206F\u206C\u202E(BattleController A_0)
			{
				return A_0.EnemyGroup;
			}

			static string \u200C\u202C\u202C\u200F\u206C\u206F\u200E\u200D\u202B\u206F\u206A\u202A\u200E\u200C\u206A\u206A\u206B\u206C\u200B\u200D\u206B\u200B\u206E\u206C\u202C\u206B\u202A\u200D\u200E\u200E\u202A\u206B\u206A\u200B\u202E\u206D\u200B\u202E\u206E\u206C\u202E(EnemyGroup A_0)
			{
				return A_0.Id;
			}

			static bool \u200C\u202B\u202B\u202C\u200C\u200D\u202A\u200B\u206D\u200E\u200C\u206C\u206F\u200E\u206E\u200E\u206F\u206F\u202D\u202B\u206D\u200E\u200D\u200F\u206E\u206C\u200E\u206B\u206B\u200F\u206D\u202E\u202B\u202D\u200C\u202E\u200F\u200E\u202C\u202C\u202E(string A_0, string A_1)
			{
				return A_0 != A_1;
			}

			static PlayerUnit \u200E\u202B\u202D\u202B\u200F\u200E\u200B\u206E\u200B\u200F\u202E\u206D\u206C\u206C\u200D\u200F\u200F\u202D\u206A\u202E\u202D\u200C\u206F\u206A\u202D\u206C\u200F\u202E\u200B\u206C\u200F\u200B\u206E\u200D\u206F\u202B\u206F\u206D\u200C\u206F\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<DieEventArgs> \u200D\u206E\u202C\u206D\u202E\u202E\u200E\u206B\u200D\u202B\u202A\u206E\u202B\u202E\u200F\u206A\u202B\u200C\u202B\u206E\u206F\u206A\u202B\u202D\u206C\u202E\u202A\u200F\u202C\u206C\u206F\u200F\u206D\u202D\u202A\u200D\u206D\u206E\u200F\u206E\u202E(Unit A_0)
			{
				return A_0.Dying;
			}

			static GameEvent<DieEventArgs> \u200C\u206B\u206C\u200C\u206B\u200C\u200F\u206F\u206D\u202C\u200B\u200C\u200F\u206F\u206B\u202B\u206D\u206C\u200C\u202B\u202A\u200C\u200D\u200B\u200F\u206F\u200C\u202A\u200B\u200D\u202D\u200D\u206C\u200C\u202E\u202B\u200E\u200F\u200E\u206A\u202E(Unit A_0)
			{
				return A_0.Dying;
			}

			static GameEvent<CardUsingEventArgs> \u200D\u206E\u206F\u200F\u206A\u206E\u200E\u206A\u200F\u206C\u200E\u206F\u202A\u206E\u202C\u202A\u202C\u202B\u206E\u200F\u202B\u206D\u202A\u206C\u206E\u200C\u206B\u202D\u202D\u206B\u206F\u200C\u206E\u206F\u206A\u206D\u202E\u200C\u206E\u206D\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u200D\u200B\u200D\u206C\u200B\u206B\u206D\u202E\u200D\u200F\u206C\u200B\u206F\u202C\u200D\u200E\u206F\u200E\u200C\u206B\u206B\u206B\u206C\u200B\u202C\u200D\u206C\u202E\u200D\u202C\u202B\u202A\u206D\u200E\u202D\u200E\u206E\u200F\u200D\u206D\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static NullReferenceException \u202B\u206D\u200D\u202A\u206C\u206F\u202B\u202B\u200D\u200E\u202C\u206A\u202D\u200C\u200B\u202D\u206E\u202C\u206F\u202E\u206D\u202A\u200C\u206C\u200D\u200C\u202B\u202A\u202B\u206D\u200B\u202E\u202D\u202A\u202C\u206E\u206F\u200B\u202D\u202A\u202E()
			{
				return new NullReferenceException();
			}

			static Card \u200D\u200B\u206E\u206E\u206C\u206B\u200F\u200E\u202C\u200C\u206D\u206E\u200D\u200B\u206A\u202E\u206D\u206E\u206C\u206B\u206C\u202E\u200C\u206A\u206B\u200F\u202D\u200C\u202B\u202E\u202E\u206B\u206B\u206C\u200B\u206C\u200B\u202E\u206A\u200F\u202E(CardUsingEventArgs A_0)
			{
				return A_0.Card;
			}

			static Coroutine \u206A\u200D\u202D\u202A\u202C\u200C\u200B\u200F\u202E\u202A\u202C\u202A\u206D\u202B\u206C\u202D\u200D\u200B\u206B\u202E\u206A\u206B\u206A\u206A\u206B\u202A\u200F\u200C\u206B\u206B\u206D\u200F\u202C\u200C\u202C\u202B\u202D\u206D\u200C\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static void \u206C\u206C\u206E\u200B\u202C\u206F\u200B\u206F\u202E\u200B\u206E\u202D\u200B\u202C\u200E\u202D\u206C\u200B\u206F\u206D\u206F\u200B\u200F\u202A\u202A\u202D\u200F\u200B\u202B\u206B\u202C\u200B\u200E\u200C\u206C\u202A\u202C\u200F\u202C\u202E(EnemyUnit A_0)
			{
				A_0.UpdateTurnMoves();
			}

			static int \u206C\u206A\u202C\u200E\u202D\u206D\u200E\u206E\u206C\u206C\u200F\u206A\u206E\u200E\u200D\u200E\u206B\u206E\u206C\u202A\u200E\u202D\u206F\u202A\u206C\u206B\u206C\u202B\u200D\u200E\u206F\u202C\u200B\u202E\u202D\u206B\u206D\u206F\u202C\u206A\u202E(Unit A_0)
			{
				return A_0.TotalFirepower;
			}

			static int \u202B\u206A\u202E\u202D\u200D\u206D\u202C\u206F\u202B\u202D\u200D\u200D\u200D\u206B\u200E\u200F\u202B\u206D\u202B\u200B\u202A\u202E\u206B\u200C\u202C\u202C\u206F\u200E\u206B\u206F\u200C\u200B\u206A\u200C\u206C\u200C\u202B\u200C\u200E\u202B\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static int \u200F\u202B\u206C\u206D\u200B\u206D\u200B\u206D\u206C\u200B\u206E\u206B\u202E\u202C\u200E\u206E\u200F\u206D\u202A\u202B\u200D\u202A\u200C\u200E\u200E\u200D\u200E\u200F\u202C\u206D\u206E\u200F\u202B\u206C\u202D\u200E\u206A\u202E\u206B\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}

			static int \u200F\u206E\u202B\u206F\u206E\u200E\u206B\u200C\u200C\u200D\u200F\u202D\u206A\u200B\u200E\u206A\u200D\u202C\u206B\u200B\u200C\u206B\u206D\u200F\u202A\u202D\u206F\u202E\u200F\u206E\u202C\u202D\u206B\u206D\u206F\u202D\u200B\u202C\u200B\u206F\u202E(Unit A_0)
			{
				return A_0.Shield;
			}

			static int \u200F\u200E\u202A\u202B\u200F\u200F\u200D\u202E\u206E\u206C\u200C\u202A\u200B\u200B\u202B\u200F\u206D\u200C\u200D\u206B\u206C\u202A\u200D\u202B\u206F\u206A\u206A\u206E\u200D\u206A\u200D\u200F\u200F\u206C\u206D\u202A\u200E\u206A\u200F\u206D\u202E(Unit A_0)
			{
				return A_0.Block;
			}

			static GameObject \u202E\u200F\u200B\u206B\u202E\u206C\u202B\u202E\u202D\u200C\u206F\u200B\u206F\u206A\u202B\u200B\u200B\u200D\u202C\u206C\u206D\u200E\u202E\u200D\u206B\u200D\u200E\u206F\u202E\u200C\u200E\u206E\u206D\u206F\u202B\u200C\u206C\u202E\u202A\u202D\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			private readonly RepeatableRandomPool<AyaBossFlandreDef.AyaBossFlandre.MoveType> demoMoves = new RepeatableRandomPool<AyaBossFlandreDef.AyaBossFlandre.MoveType>
			{
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.BlueberryTrap,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.Mistilteinn,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.ToryanseToryanse,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.LabyrinthofLove,
					1f
				}
			};

			private readonly RepeatableRandomPool<AyaBossFlandreDef.AyaBossFlandre.MoveType> moves = new RepeatableRandomPool<AyaBossFlandreDef.AyaBossFlandre.MoveType>
			{
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.ForbiddenFruit,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.ForbiddenGames,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.RecklessBullet,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.CerberusClipper,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.DestroyerinthePalmofOnesHand,
					1f
				},
				{
					AyaBossFlandreDef.AyaBossFlandre.MoveType.ScarletNihility,
					1f
				}
			};

			private int Clone;

			private static GameObject background = AyaBossFlandreDef.AyaBossFlandre.\u202E\u200F\u200B\u206B\u202E\u206C\u202B\u202E\u202D\u200C\u206F\u200B\u206F\u206A\u202B\u200B\u200B\u200D\u202C\u206C\u206D\u200E\u202E\u200D\u206B\u200D\u200E\u206F\u202E\u200C\u200E\u206E\u206D\u206F\u202B\u200C\u206C\u202E\u202A\u202D\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1410267093), null);

			private static GameObject scene1;

			private static GameObject scene2;

			private bool DemoLastWordUsed;

			private bool ToryanseUsed;

			private bool BlueberryTrapScene;

			private bool MistilteinnScene;

			private bool ThreeofaKindScene;

			private bool ToryanseToryanseScene;

			private bool LabyrinthofLoveScene;

			private bool Skip;

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Prev2 = AyaBossFlandreDef.AyaBossFlandre.MoveType.None;

			private AyaBossFlandreDef.AyaBossFlandre.MoveType Prev1 = AyaBossFlandreDef.AyaBossFlandre.MoveType.None;

			private enum MoveType
			{
				BlueberryTrap,
				Mistilteinn,
				ThreeofaKind,
				ToryanseToryanse,
				LabyrinthofLove,
				CranberryTrap,
				Laevatein,
				FourofaKind,
				KagomeKagome,
				MazeofLove,
				StarbowBreak,
				Catadioptric,
				ClockthatTicksAwaythePast,
				AndThenWillThereBeNone,
				Ripplesof495Years,
				ForbiddenFruit,
				ForbiddenGames,
				RecklessBullet,
				CerberusClipper,
				DestroyerinthePalmofOnesHand,
				ScarletNihility,
				SpellBreak,
				None
			}
		}
	}
}
