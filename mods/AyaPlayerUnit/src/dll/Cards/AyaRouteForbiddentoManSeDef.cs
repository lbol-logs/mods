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
	public sealed class AyaRouteForbiddentoManSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1035450703);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaRouteForbiddentoManSeDef.\u206F\u206E\u206C\u202C\u200E\u206B\u206D\u200B\u206F\u206E\u200B\u202C\u202B\u202D\u202C\u202B\u200E\u202C\u206C\u206F\u200F\u200D\u202A\u200E\u206E\u206E\u202C\u202D\u202C\u200C\u200C\u200B\u200B\u206B\u202B\u202E\u200F\u202D\u200B\u200E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaRouteForbiddentoManSeDef.\u202A\u200C\u206E\u202C\u200C\u202A\u202B\u206E\u206C\u206B\u202C\u206B\u206B\u202B\u200B\u202D\u202B\u206A\u202B\u200E\u206C\u206E\u206A\u202E\u206B\u202A\u200B\u206C\u206D\u206C\u202C\u206D\u200F\u206D\u202C\u200C\u206B\u206F\u206B\u202B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1034446417), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			int num = AyaRouteForbiddentoManSeDef.\u200C\u200D\u202A\u202B\u200E\u206B\u200C\u202B\u202D\u206D\u206A\u200E\u206E\u206F\u200B\u206C\u200B\u202B\u206C\u202A\u206D\u200D\u206A\u206E\u206A\u202E\u202B\u200C\u202D\u202D\u200F\u206C\u206F\u202D\u202B\u202A\u202D\u206E\u200F\u206B\u202E(BepinexPlugin.sequenceTable, AyaRouteForbiddentoManSeDef.\u200F\u200B\u200E\u200D\u206A\u206E\u202A\u206A\u202A\u206C\u206E\u206C\u202B\u206D\u200D\u206B\u200E\u200E\u206B\u202A\u202E\u200B\u200B\u206B\u206B\u200B\u202C\u200C\u202B\u200D\u206C\u206B\u202D\u202C\u202D\u200E\u202C\u200B\u200B\u202B\u202E(typeof(StatusEffectConfig).TypeHandle));
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
			StackType? stackType3 = new StackType?(StackType.Keep);
			StackType? stackType4 = new StackType?(StackType.Add);
			bool flag6 = false;
			Keyword keyword = Keyword.None;
			List<string> list;
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				(list = new List<string>()).Add(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1912691474));
			}
			else
			{
				list = new List<string>();
			}
			return new StatusEffectConfig(num, text, num2, statusEffectType, flag, flag2, num3, flag3, stackType, flag4, stackType2, durationDecreaseTiming, flag5, stackType3, stackType4, flag6, keyword, list, null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387));
		}

		static BatchLocalization \u206F\u206E\u206C\u202C\u200E\u206B\u206D\u200B\u206F\u206E\u200B\u202C\u202B\u202D\u202C\u202B\u200E\u202C\u206C\u206F\u200F\u200D\u202A\u200E\u206E\u206E\u202C\u202D\u202C\u200C\u200C\u200B\u200B\u206B\u202B\u202E\u200F\u202D\u200B\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202A\u200C\u206E\u202C\u200C\u202A\u202B\u206E\u206C\u206B\u202C\u206B\u206B\u202B\u200B\u202D\u202B\u206A\u202B\u200E\u206C\u206E\u206A\u202E\u206B\u202A\u200B\u206C\u206D\u206C\u202C\u206D\u200F\u206D\u202C\u200C\u206B\u206F\u206B\u202B\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u200F\u200B\u200E\u200D\u206A\u206E\u202A\u206A\u202A\u206C\u206E\u206C\u202B\u206D\u200D\u206B\u200E\u200E\u206B\u202A\u202E\u200B\u200B\u206B\u206B\u200B\u202C\u200C\u202B\u200D\u206C\u206B\u202D\u202C\u202D\u200E\u202C\u200B\u200B\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u200D\u202A\u202B\u200E\u206B\u200C\u202B\u202D\u206D\u206A\u200E\u206E\u206F\u200B\u206C\u200B\u202B\u206C\u202A\u206D\u200D\u206A\u206E\u206A\u202E\u202B\u200C\u202D\u202D\u200F\u206C\u206F\u202D\u202B\u202A\u202D\u206E\u200F\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaRouteForbiddentoManSeDef))]
		public sealed class AyaRouteForbiddentoManSe : StatusEffect
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1578089449), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					for (;;)
					{
						int num = -1384118507;
						switch ((-(num * -254145661 * 433004535) + 139288410) % 3)
						{
						case 1:
							goto IL_003D;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0053;
					IL_003D:
					return base.GetBaseDescription();
				}
				IL_0053:
				return this.PhantasmModeDescription;
			}

			public DamageInfo Damage
			{
				get
				{
					return DamageInfo.Attack((float)AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u200C\u206A\u202E\u200C\u206D\u202A\u200D\u206A\u200B\u202D\u206E\u200E\u200D\u206C\u206A\u206B\u202D\u202B\u200E\u206B\u206B\u206C\u200E\u206D\u200F\u206B\u202C\u202A\u206B\u200C\u206C\u202C\u206D\u206C\u206D\u206B\u206F\u202C\u200D\u206D\u202E(this), true);
				}
			}

			public int Value
			{
				get
				{
					return 10;
				}
			}

			protected override void OnAdded(Unit unit)
			{
				base.HandleOwnerEvent<CardEventArgs>(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u202A\u206D\u200E\u206E\u202C\u206E\u206F\u200D\u206D\u206B\u206E\u202E\u202A\u202A\u202E\u202E\u202C\u202B\u202D\u206A\u206B\u200F\u206B\u202A\u206F\u206F\u200D\u200C\u206A\u206D\u202E\u206D\u206A\u200C\u206F\u206E\u202D\u206E\u200E\u206D\u202E(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u202E\u202E\u202A\u206D\u200B\u200C\u202A\u206E\u206F\u202D\u202A\u200D\u202D\u206E\u200E\u200C\u206F\u202A\u200B\u206F\u206F\u202B\u202E\u202C\u206F\u202C\u202D\u200C\u202B\u202B\u206B\u200E\u202A\u206B\u206D\u202C\u206B\u206D\u202C\u206E\u202E(this)), delegate(CardEventArgs _)
				{
					this.SetCount();
				});
				base.ReactOwnerEvent<UnitEventArgs>(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u206E\u206B\u200F\u202D\u206A\u206E\u206F\u202A\u206C\u206D\u202C\u200E\u200E\u202C\u202E\u206E\u200E\u206B\u206B\u206F\u206B\u202A\u200C\u202C\u206B\u200D\u202C\u206D\u202B\u206A\u202C\u202D\u202A\u202C\u200D\u206E\u202D\u200D\u200F\u200D\u202E(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u206C\u206E\u200B\u206E\u202B\u202A\u206B\u200B\u200F\u206B\u206E\u202A\u202E\u206C\u206B\u202E\u200B\u206A\u206D\u202B\u206B\u206A\u206E\u206F\u202C\u206A\u202A\u206B\u202A\u206E\u206F\u206A\u206D\u206A\u206A\u202D\u202C\u206D\u206E\u206C\u202E(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u202E\u202E\u202A\u206D\u200B\u200C\u202A\u206E\u206F\u202D\u202A\u200D\u202D\u206E\u200E\u200C\u206F\u202A\u200B\u206F\u206F\u202B\u202E\u202C\u206F\u202C\u202D\u200C\u202B\u202B\u206B\u200E\u202A\u206B\u206D\u202C\u206B\u206D\u202C\u206E\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnEnding));
			}

			private void SetCount()
			{
				AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u206B\u202E\u200C\u200F\u206C\u206A\u200B\u202C\u206E\u206F\u206A\u206F\u206E\u200E\u200E\u202A\u202E\u200C\u206E\u206F\u202D\u202E\u202A\u202D\u200E\u200F\u206A\u206E\u202C\u200F\u202C\u200D\u202B\u206A\u202E\u202D\u202B\u206E\u202B\u200E\u202E(this, AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u202C\u206A\u200B\u206D\u206B\u202A\u206B\u202A\u206C\u202B\u206E\u200E\u206C\u206F\u206D\u200C\u200B\u202B\u202C\u206D\u206C\u206B\u200B\u202A\u202D\u206E\u200D\u200C\u202A\u200B\u202B\u200D\u202B\u206F\u206D\u200C\u206C\u200E\u206F\u202A\u202E(AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.\u206B\u200D\u206C\u200B\u202A\u200D\u202A\u202B\u202E\u200B\u200C\u202D\u200F\u206A\u206D\u202C\u202B\u206C\u206A\u202D\u200E\u202A\u206F\u202A\u200B\u202A\u206C\u206C\u206F\u200F\u206F\u202C\u200E\u206A\u202E\u206E\u206D\u202B\u200D\u202A\u202E(this) + 1, this.Value));
			}

			private IEnumerable<BattleAction> OnPlayerTurnEnding(UnitEventArgs args)
			{
				AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.<OnPlayerTurnEnding>d__9 <OnPlayerTurnEnding>d__ = new AyaRouteForbiddentoManSeDef.AyaRouteForbiddentoManSe.<OnPlayerTurnEnding>d__9(-2);
				<OnPlayerTurnEnding>d__.<>4__this = this;
				return <OnPlayerTurnEnding>d__;
			}

			static int \u200C\u206A\u202E\u200C\u206D\u202A\u200D\u206A\u200B\u202D\u206E\u200E\u200D\u206C\u206A\u206B\u202D\u202B\u200E\u206B\u206B\u206C\u200E\u206D\u200F\u206B\u202C\u202A\u206B\u200C\u206C\u202C\u206D\u206C\u206D\u206B\u206F\u202C\u200D\u206D\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static BattleController \u202E\u202E\u202A\u206D\u200B\u200C\u202A\u206E\u206F\u202D\u202A\u200D\u202D\u206E\u200E\u200C\u206F\u202A\u200B\u206F\u206F\u202B\u202E\u202C\u206F\u202C\u202D\u200C\u202B\u202B\u206B\u200E\u202A\u206B\u206D\u202C\u206B\u206D\u202C\u206E\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardEventArgs> \u202A\u206D\u200E\u206E\u202C\u206E\u206F\u200D\u206D\u206B\u206E\u202E\u202A\u202A\u202E\u202E\u202C\u202B\u202D\u206A\u206B\u200F\u206B\u202A\u206F\u206F\u200D\u200C\u206A\u206D\u202E\u206D\u206A\u200C\u206F\u206E\u202D\u206E\u200E\u206D\u202E(BattleController A_0)
			{
				return A_0.CardExiled;
			}

			static PlayerUnit \u206C\u206E\u200B\u206E\u202B\u202A\u206B\u200B\u200F\u206B\u206E\u202A\u202E\u206C\u206B\u202E\u200B\u206A\u206D\u202B\u206B\u206A\u206E\u206F\u202C\u206A\u202A\u206B\u202A\u206E\u206F\u206A\u206D\u206A\u206A\u202D\u202C\u206D\u206E\u206C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206E\u206B\u200F\u202D\u206A\u206E\u206F\u202A\u206C\u206D\u202C\u200E\u200E\u202C\u202E\u206E\u200E\u206B\u206B\u206F\u206B\u202A\u200C\u202C\u206B\u200D\u202C\u206D\u202B\u206A\u202C\u202D\u202A\u202C\u200D\u206E\u202D\u200D\u200F\u200D\u202E(Unit A_0)
			{
				return A_0.TurnEnding;
			}

			static int \u206B\u200D\u206C\u200B\u202A\u200D\u202A\u202B\u202E\u200B\u200C\u202D\u200F\u206A\u206D\u202C\u202B\u206C\u206A\u202D\u200E\u202A\u206F\u202A\u200B\u202A\u206C\u206C\u206F\u200F\u206F\u202C\u200E\u206A\u202E\u206E\u206D\u202B\u200D\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Count;
			}

			static int \u202C\u206A\u200B\u206D\u206B\u202A\u206B\u202A\u206C\u202B\u206E\u200E\u206C\u206F\u206D\u200C\u200B\u202B\u202C\u206D\u206C\u206B\u200B\u202A\u202D\u206E\u200D\u200C\u202A\u200B\u202B\u200D\u202B\u206F\u206D\u200C\u206C\u200E\u206F\u202A\u202E(int A_0, int A_1)
			{
				return Math.Min(A_0, A_1);
			}

			static void \u206B\u202E\u200C\u200F\u206C\u206A\u200B\u202C\u206E\u206F\u206A\u206F\u206E\u200E\u200E\u202A\u202E\u200C\u206E\u206F\u202D\u202E\u202A\u202D\u200E\u200F\u206A\u206E\u202C\u200F\u202C\u200D\u202B\u206A\u202E\u202D\u202B\u206E\u202B\u200E\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Count = A_1;
			}
		}
	}
}
