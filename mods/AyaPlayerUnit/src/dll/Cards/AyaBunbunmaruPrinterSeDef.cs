using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class AyaBunbunmaruPrinterSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2112516585);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBunbunmaruPrinterSeDef.\u206C\u202D\u206A\u200D\u206D\u200F\u200B\u200F\u200C\u200C\u206D\u202E\u200B\u206E\u200D\u202D\u202A\u200B\u202A\u202A\u202B\u202A\u202A\u206D\u206B\u206B\u200D\u200F\u206D\u206E\u206A\u202A\u200E\u206F\u206D\u200F\u206D\u200E\u200C\u202C\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaBunbunmaruPrinterSeDef.\u202C\u202E\u202B\u200D\u200C\u202C\u200B\u206A\u206B\u202C\u202B\u206D\u206E\u206F\u202D\u206F\u202C\u206D\u200B\u200E\u206B\u200D\u202D\u202A\u206D\u202A\u206C\u206E\u200E\u202C\u202B\u206A\u206A\u202B\u206E\u200C\u206C\u206F\u202E\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-316844771), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaBunbunmaruPrinterSeDef.\u206C\u200E\u202D\u206E\u200D\u206E\u202A\u200B\u202D\u200D\u206B\u206C\u206C\u202C\u202E\u202B\u202B\u202C\u206C\u206D\u202C\u206E\u206F\u200D\u200C\u200E\u202E\u206A\u206A\u206E\u202B\u200F\u202A\u200D\u206E\u202C\u202E\u202C\u200D\u202E\u202E(BepinexPlugin.sequenceTable, AyaBunbunmaruPrinterSeDef.\u202B\u206D\u202C\u200C\u202A\u206E\u206C\u202E\u202E\u206E\u200F\u202C\u200E\u206C\u202E\u202D\u202C\u200F\u200C\u206F\u206A\u200F\u202D\u202B\u206B\u206B\u206C\u206A\u206C\u206E\u200B\u200F\u200B\u202B\u202C\u202E\u206C\u202E\u206E\u206B\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 10, StatusEffectType.Positive, false, true, null, true, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, BepinexPlugin.AyaPhantasmMode.Value ? Keyword.None : Keyword.TempMorph, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(900861280), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(879264257));
		}

		static BatchLocalization \u206C\u202D\u206A\u200D\u206D\u200F\u200B\u200F\u200C\u200C\u206D\u202E\u200B\u206E\u200D\u202D\u202A\u200B\u202A\u202A\u202B\u202A\u202A\u206D\u206B\u206B\u200D\u200F\u206D\u206E\u206A\u202A\u200E\u206F\u206D\u200F\u206D\u200E\u200C\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202C\u202E\u202B\u200D\u200C\u202C\u200B\u206A\u206B\u202C\u202B\u206D\u206E\u206F\u202D\u206F\u202C\u206D\u200B\u200E\u206B\u200D\u202D\u202A\u206D\u202A\u206C\u206E\u200E\u202C\u202B\u206A\u206A\u202B\u206E\u200C\u206C\u206F\u202E\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202B\u206D\u202C\u200C\u202A\u206E\u206C\u202E\u202E\u206E\u200F\u202C\u200E\u206C\u202E\u202D\u202C\u200F\u200C\u206F\u206A\u200F\u202D\u202B\u206B\u206B\u206C\u206A\u206C\u206E\u200B\u200F\u200B\u202B\u202C\u202E\u206C\u202E\u206E\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200E\u202D\u206E\u200D\u206E\u202A\u200B\u202D\u200D\u206B\u206C\u206C\u202C\u202E\u202B\u202B\u202C\u206C\u206D\u202C\u206E\u206F\u200D\u200C\u200E\u202E\u206A\u206A\u206E\u202B\u200F\u202A\u200D\u206E\u202C\u202E\u202C\u200D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaBunbunmaruPrinterSeDef))]
		public sealed class AyaBunbunmaruPrinterSe : StatusEffect
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1803702677), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (!BepinexPlugin.AyaPhantasmMode.Value)
				{
					for (;;)
					{
						int num = 1770883496;
						switch ((((num + ((171719195 * (-1865910919 * -1650053591)) ^ -(2027622654 ^ 1976771160))) * 28832897) ^ (4384174 ^ 318527603)) * 748611841 % 3)
						{
						case 0:
							continue;
						case 2:
							goto IL_0061;
						}
						break;
					}
					goto IL_0077;
					IL_0061:
					return base.GetBaseDescription();
				}
				IL_0077:
				return this.PhantasmModeDescription;
			}

			public ManaGroup Mana
			{
				get
				{
					return ManaGroup.Anys(1);
				}
			}

			protected override void OnAdded(Unit unit)
			{
				base.ReactOwnerEvent<UnitEventArgs>(AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.\u206D\u206C\u206C\u200F\u206A\u206E\u200D\u206B\u206A\u202B\u206B\u202D\u206D\u206B\u202A\u202E\u202E\u202A\u200D\u200B\u202B\u202E\u206C\u202E\u200E\u202C\u202E\u200E\u206F\u200D\u206A\u206F\u202E\u202C\u202B\u206C\u200B\u206A\u202E\u206C\u202E(AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.\u206D\u200D\u202C\u202E\u200C\u202A\u202B\u206D\u200D\u206A\u202C\u200C\u206F\u206A\u206D\u200E\u202E\u202E\u206D\u206D\u200B\u202D\u206A\u202A\u202E\u202D\u202D\u206C\u200D\u200E\u202B\u206A\u200E\u202B\u206C\u202B\u206C\u202C\u206B\u202E(this)), new EventSequencedReactor<UnitEventArgs>(this.OnOwnerTurnStarted));
			}

			private IEnumerable<BattleAction> OnOwnerTurnStarted(UnitEventArgs args)
			{
				AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.<OnOwnerTurnStarted>d__6 <OnOwnerTurnStarted>d__ = new AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.<OnOwnerTurnStarted>d__6(-2);
				<OnOwnerTurnStarted>d__.<>4__this = this;
				return <OnOwnerTurnStarted>d__;
			}

			public BattleAction TakeEffect()
			{
				this.\u202C\u200D\u206D\u200E\u200D\u202C\u200E\u200C\u200E\u206D\u206F\u202B\u206B\u206D\u202B\u206E\u200C\u200B\u206B\u202E\u200E\u200C\u202D\u202C\u200F\u206E\u206F\u202E\u206C\u202C\u206D\u202D\u202B\u202C\u200D\u202C\u206A\u200B\u202D\u202E();
				List<AyaNews> list;
				for (;;)
				{
					IL_0006:
					int num = 1059365548;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(uint)(((~(1566361894 * -684461153) ^ 1944208644) - num2) ^ (854252323 - 70100906 - (268613530 + -1394127209)))))) % 3U)
						{
						case 1U:
							list = Library.CreateCards<AyaNews>(AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.\u202E\u202C\u200E\u206C\u206C\u206A\u200C\u206B\u206B\u206D\u200D\u202B\u202D\u200E\u206E\u206F\u206D\u206A\u200E\u202C\u206A\u200E\u206A\u202B\u202D\u206C\u202B\u200C\u206E\u200C\u206E\u206F\u200F\u206A\u206B\u202A\u202E\u202D\u202D\u202D\u202E(this), false).ToList<AyaNews>();
							if (!BepinexPlugin.AyaPhantasmMode.Value)
							{
								num = (int)((num3 * 3050061485U) ^ 1103478731U);
								continue;
							}
							goto IL_011C;
						case 2U:
							goto IL_0006;
						}
						goto Block_1;
					}
				}
				Block_1:
				using (List<AyaNews>.Enumerator enumerator = list.GetEnumerator())
				{
					for (;;)
					{
						IL_00F2:
						int num4 = ((!enumerator.MoveNext()) ? 26187860 : 61529002);
						for (;;)
						{
							int num2 = num4;
							switch (-(-(((~(1566361894 * -684461153) ^ 1944208644) - num2) ^ (854252323 - 70100906 - (268613530 + -1394127209)))) % 4)
							{
							case 0:
								goto IL_00F2;
							case 2:
								num4 = 61529002;
								continue;
							case 3:
								AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.\u206C\u206C\u202E\u206C\u200C\u206E\u206C\u202D\u206D\u206C\u200C\u206B\u202D\u206B\u202D\u206F\u202E\u200B\u202C\u200E\u200F\u206F\u206D\u206B\u206C\u206E\u202B\u206B\u206D\u200C\u206C\u206E\u200E\u206C\u200C\u206D\u206D\u202B\u200D\u206F\u202E(enumerator.Current, this.Mana);
								num4 = 1431346085;
								continue;
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
				IL_011C:
				return AyaBunbunmaruPrinterSeDef.AyaBunbunmaruPrinterSe.\u202D\u200D\u200D\u200E\u206F\u206B\u200C\u202D\u200D\u206B\u202B\u206F\u206A\u200F\u206E\u206A\u202E\u202C\u200D\u206D\u206D\u202A\u206D\u200C\u202E\u206D\u206B\u206C\u200F\u202C\u206B\u200C\u206B\u200B\u202A\u202D\u202A\u202D\u202A\u206B\u202E(list, AddCardsType.Normal, false);
			}

			static Unit \u206D\u200D\u202C\u202E\u200C\u202A\u202B\u206D\u200D\u206A\u202C\u200C\u206F\u206A\u206D\u200E\u202E\u202E\u206D\u206D\u200B\u202D\u206A\u202A\u202E\u202D\u202D\u206C\u200D\u200E\u202B\u206A\u200E\u202B\u206C\u202B\u206C\u202C\u206B\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static GameEvent<UnitEventArgs> \u206D\u206C\u206C\u200F\u206A\u206E\u200D\u206B\u206A\u202B\u206B\u202D\u206D\u206B\u202A\u202E\u202E\u202A\u200D\u200B\u202B\u202E\u206C\u202E\u200E\u202C\u202E\u200E\u206F\u200D\u206A\u206F\u202E\u202C\u202B\u206C\u200B\u206A\u202E\u206C\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			void \u202C\u200D\u206D\u200E\u200D\u202C\u200E\u200C\u200E\u206D\u206F\u202B\u206B\u206D\u202B\u206E\u200C\u200B\u206B\u202E\u200E\u200C\u202D\u202C\u200F\u206E\u206F\u202E\u206C\u202C\u206D\u202D\u202B\u202C\u200D\u202C\u206A\u200B\u202D\u202E()
			{
				base.NotifyActivating();
			}

			static int \u202E\u202C\u200E\u206C\u206C\u206A\u200C\u206B\u206B\u206D\u200D\u202B\u202D\u200E\u206E\u206F\u206D\u206A\u200E\u202C\u206A\u200E\u206A\u202B\u202D\u206C\u202B\u200C\u206E\u200C\u206E\u206F\u200F\u206A\u206B\u202A\u202E\u202D\u202D\u202D\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static void \u206C\u206C\u202E\u206C\u200C\u206E\u206C\u202D\u206D\u206C\u200C\u206B\u202D\u206B\u202D\u206F\u202E\u200B\u202C\u200E\u200F\u206F\u206D\u206B\u206C\u206E\u202B\u206B\u206D\u200C\u206C\u206E\u200E\u206C\u200C\u206D\u206D\u202B\u200D\u206F\u202E(Card A_0, ManaGroup A_1)
			{
				A_0.SetTurnCost(A_1);
			}

			static AddCardsToHandAction \u202D\u200D\u200D\u200E\u206F\u206B\u200C\u202D\u200D\u206B\u202B\u206F\u206A\u200F\u206E\u206A\u202E\u202C\u200D\u206D\u206D\u202A\u206D\u200C\u202E\u206D\u206B\u206C\u200F\u202C\u206B\u200C\u206B\u200B\u202A\u202D\u202A\u202D\u202A\u206B\u202E(IEnumerable<Card> A_0, AddCardsType A_1, bool A_2)
			{
				return new AddCardsToHandAction(A_0, A_1, A_2);
			}
		}
	}
}
