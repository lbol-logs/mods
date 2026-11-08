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
	public sealed class AyaTengusDrumbeatsSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-473702840);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTengusDrumbeatsSeDef.\u202E\u206A\u202A\u202B\u202D\u206E\u206D\u206F\u202A\u206E\u206A\u200D\u200F\u206D\u200F\u202B\u200D\u202B\u202D\u202A\u206E\u206C\u206D\u202C\u200B\u202E\u202D\u206D\u200D\u200D\u202B\u206F\u206A\u200B\u206B\u200C\u202C\u206A\u202C\u206E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaTengusDrumbeatsSeDef.\u200F\u206A\u206A\u200F\u206F\u206D\u206C\u200B\u202B\u200E\u202E\u200C\u202B\u202E\u202E\u206A\u202E\u206B\u200C\u206C\u206E\u202A\u206D\u206B\u202C\u202D\u206B\u200B\u206F\u200C\u200F\u200D\u200F\u200E\u202A\u200D\u200C\u200C\u202E\u206A\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1208286375), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			int num = AyaTengusDrumbeatsSeDef.\u200C\u206B\u200E\u206B\u206F\u200D\u200C\u206C\u206C\u200D\u206A\u200C\u206A\u206A\u206B\u202C\u206D\u202C\u206D\u206B\u206C\u206D\u202D\u200D\u206E\u200C\u202D\u202B\u206A\u206D\u206F\u200D\u206C\u202B\u206A\u206F\u200D\u206A\u200D\u202C\u202E(BepinexPlugin.sequenceTable, AyaTengusDrumbeatsSeDef.\u202C\u202C\u206E\u206B\u200F\u206B\u200C\u200C\u202B\u202A\u202E\u202D\u202D\u206C\u200C\u206E\u206F\u202A\u202D\u206C\u200C\u202C\u206E\u206D\u206F\u200E\u200B\u202D\u206E\u202C\u202C\u206B\u200E\u206E\u202B\u206F\u200D\u206A\u202B\u206C\u202E(typeof(StatusEffectConfig).TypeHandle));
			string text = "";
			int num2 = 10;
			StatusEffectType statusEffectType = StatusEffectType.Positive;
			bool flag = false;
			bool flag2 = true;
			int? num3 = null;
			bool flag3 = true;
			StackType? stackType = new StackType?(StackType.Add);
			bool flag4 = false;
			StackType? stackType2 = new StackType?(StackType.Add);
			DurationDecreaseTiming durationDecreaseTiming = DurationDecreaseTiming.Custom;
			bool flag5 = true;
			StackType? stackType3 = new StackType?(StackType.Add);
			StackType? stackType4 = new StackType?(StackType.Keep);
			bool flag6 = false;
			Keyword keyword = Keyword.Accuracy;
			List<string> list;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list = new List<string>()).Add(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1385709034));
			}
			else
			{
				list = new List<string>();
			}
			return new StatusEffectConfig(num, text, num2, statusEffectType, flag, flag2, num3, flag3, stackType, flag4, stackType2, durationDecreaseTiming, flag5, stackType3, stackType4, flag6, keyword, list, null, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1222837215), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908));
		}

		static BatchLocalization \u202E\u206A\u202A\u202B\u202D\u206E\u206D\u206F\u202A\u206E\u206A\u200D\u200F\u206D\u200F\u202B\u200D\u202B\u202D\u202A\u206E\u206C\u206D\u202C\u200B\u202E\u202D\u206D\u200D\u200D\u202B\u206F\u206A\u200B\u206B\u200C\u202C\u206A\u202C\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200F\u206A\u206A\u200F\u206F\u206D\u206C\u200B\u202B\u200E\u202E\u200C\u202B\u202E\u202E\u206A\u202E\u206B\u200C\u206C\u206E\u202A\u206D\u206B\u202C\u202D\u206B\u200B\u206F\u200C\u200F\u200D\u200F\u200E\u202A\u200D\u200C\u200C\u202E\u206A\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202C\u202C\u206E\u206B\u200F\u206B\u200C\u200C\u202B\u202A\u202E\u202D\u202D\u206C\u200C\u206E\u206F\u202A\u202D\u206C\u200C\u202C\u206E\u206D\u206F\u200E\u200B\u202D\u206E\u202C\u202C\u206B\u200E\u206E\u202B\u206F\u200D\u206A\u202B\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u206B\u200E\u206B\u206F\u200D\u200C\u206C\u206C\u200D\u206A\u200C\u206A\u206A\u206B\u202C\u206D\u202C\u206D\u206B\u206C\u206D\u202D\u200D\u206E\u200C\u202D\u202B\u206A\u206D\u206F\u200D\u206C\u202B\u206A\u206F\u200D\u206A\u200D\u202C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTengusDrumbeatsSeDef))]
		public sealed class AyaTengusDrumbeatsSe : StatusEffect
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1075896301), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					for (;;)
					{
						int num = 102997018;
						switch (-(-(~num - (--880743940 + 1953597057))) % 3)
						{
						case 1:
							goto IL_003A;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0050;
					IL_003A:
					return base.GetBaseDescription();
				}
				IL_0050:
				return this.PhantasmModeDescription;
			}

			public DamageInfo Damage
			{
				get
				{
					return DamageInfo.Attack((float)AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.\u206B\u200C\u200B\u206A\u200E\u206E\u200E\u200D\u200F\u206C\u202D\u200B\u206A\u202B\u200E\u200F\u202C\u202A\u202D\u206B\u206E\u200E\u202D\u200B\u200C\u202C\u200C\u206E\u206B\u206A\u206D\u206C\u202D\u206F\u202C\u206C\u206D\u202A\u200D\u206D\u202E(this), true);
				}
			}

			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.\u206F\u200E\u206C\u202E\u200B\u200F\u202E\u206B\u200E\u200E\u206C\u202C\u202D\u206C\u200F\u200F\u202D\u202B\u202D\u200D\u206B\u202B\u200B\u202E\u200F\u200C\u202A\u206D\u200B\u202B\u202D\u202C\u206B\u202A\u206D\u202B\u206D\u202E\u206F\u202A\u202E(AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.\u202C\u202C\u202C\u202A\u202E\u200C\u202D\u202D\u200E\u206A\u200D\u206B\u206A\u200D\u206F\u200C\u206C\u202C\u200B\u200D\u206A\u202A\u202B\u202E\u202C\u200B\u206C\u202E\u206D\u202B\u206E\u202E\u206F\u206D\u206D\u202B\u200B\u202B\u202D\u200D\u202E(AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.\u202E\u200F\u200D\u200F\u202E\u200C\u206B\u206F\u202E\u206F\u202A\u206A\u200E\u200F\u200F\u202E\u202B\u202A\u206F\u200C\u202B\u202C\u206C\u200B\u200C\u206F\u206D\u206A\u206E\u200B\u206A\u206A\u202D\u202C\u200F\u200E\u202C\u200D\u206B\u202E\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs args)
			{
				AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.<OnPlayerTurnStarted>d__6 <OnPlayerTurnStarted>d__ = new AyaTengusDrumbeatsSeDef.AyaTengusDrumbeatsSe.<OnPlayerTurnStarted>d__6(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			static int \u206B\u200C\u200B\u206A\u200E\u206E\u200E\u200D\u200F\u206C\u202D\u200B\u206A\u202B\u200E\u200F\u202C\u202A\u202D\u206B\u206E\u200E\u202D\u200B\u200C\u202C\u200C\u206E\u206B\u206A\u206D\u206C\u202D\u206F\u202C\u206C\u206D\u202A\u200D\u206D\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static BattleController \u202E\u200F\u200D\u200F\u202E\u200C\u206B\u206F\u202E\u206F\u202A\u206A\u200E\u200F\u200F\u202E\u202B\u202A\u206F\u200C\u202B\u202C\u206C\u200B\u200C\u206F\u206D\u206A\u206E\u200B\u206A\u206A\u202D\u202C\u200F\u200E\u202C\u200D\u206B\u202E\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202C\u202C\u202C\u202A\u202E\u200C\u202D\u202D\u200E\u206A\u200D\u206B\u206A\u200D\u206F\u200C\u206C\u202C\u200B\u200D\u206A\u202A\u202B\u202E\u202C\u200B\u206C\u202E\u206D\u202B\u206E\u202E\u206F\u206D\u206D\u202B\u200B\u202B\u202D\u200D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206F\u200E\u206C\u202E\u200B\u200F\u202E\u206B\u200E\u200E\u206C\u202C\u202D\u206C\u200F\u200F\u202D\u202B\u202D\u200D\u206B\u202B\u200B\u202E\u200F\u200C\u202A\u206D\u200B\u202B\u202D\u202C\u206B\u202A\u206D\u202B\u206D\u202E\u206F\u202A\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}
		}
	}
}
