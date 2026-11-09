using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreStarbowBreakDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(256335698);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreStarbowBreakDef.\u200D\u206E\u206D\u200B\u206D\u206F\u202A\u202E\u206F\u206F\u200E\u200B\u200E\u200D\u200E\u200E\u200D\u206A\u206C\u202C\u202D\u206A\u206E\u202D\u200D\u200F\u202A\u202C\u202D\u202E\u202C\u200E\u202C\u200C\u200D\u206A\u200E\u206E\u206A\u202C\u202E(BepinexPlugin.embeddedSource);
			FlandreStarbowBreakDef.\u200F\u206C\u206E\u200F\u206B\u200C\u206F\u200C\u200C\u202D\u200C\u202D\u202A\u202A\u202E\u206B\u200B\u200D\u206F\u206E\u200F\u206C\u206A\u206F\u202D\u200F\u200B\u200B\u206F\u200B\u200F\u200F\u200F\u200C\u200E\u202D\u200F\u200F\u200F\u202A\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreStarbowBreakDef.\u200D\u200D\u206A\u202A\u206E\u200E\u206D\u200B\u206D\u200D\u202B\u200D\u206F\u202E\u202A\u206E\u206D\u202A\u202B\u200E\u200F\u202E\u206A\u206C\u202E\u200E\u206F\u202A\u206B\u206E\u200C\u206A\u206F\u206E\u200E\u200B\u206E\u202C\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreStarbowBreakDef.\u202B\u202B\u200C\u206E\u202B\u206B\u206A\u202A\u200C\u200F\u206C\u202D\u202C\u206D\u200C\u200F\u206B\u206B\u200C\u200C\u200D\u206E\u206C\u202C\u200B\u202D\u206C\u200C\u206A\u206B\u202B\u206D\u200B\u200E\u202D\u206D\u206E\u200E\u200D\u206C\u202E(BepinexPlugin.sequenceTable, FlandreStarbowBreakDef.\u200B\u206C\u200C\u200F\u202E\u206D\u206B\u206F\u202C\u206E\u202D\u202D\u206A\u206D\u206E\u200D\u206A\u200F\u202B\u206B\u206A\u206A\u206A\u200C\u206D\u202B\u200F\u200C\u206E\u202A\u206B\u200F\u206B\u200C\u200E\u202D\u202E\u202D\u200C\u202B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1013048470), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1611824999), 0, true, true, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Black }, true, new ManaGroup
			{
				Black = 1
			}, null, null, null, null, new int?(9), null, null, null, null, null, new int?(3), null, new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, (Keyword)(-2147482112), (Keyword)(-2147482112), new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(734434424), new List<string>());
		}

		static CardImages \u200D\u206E\u206D\u200B\u206D\u206F\u202A\u202E\u206F\u206F\u200E\u200B\u200E\u200D\u200E\u200E\u200D\u206A\u206C\u202C\u202D\u206A\u206E\u202D\u200D\u200F\u202A\u202C\u202D\u202E\u202C\u200E\u202C\u200C\u200D\u206A\u200E\u206E\u206A\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200F\u206C\u206E\u200F\u206B\u200C\u206F\u200C\u200C\u202D\u200C\u202D\u202A\u202A\u202E\u206B\u200B\u200D\u206F\u206E\u200F\u206C\u206A\u206F\u202D\u200F\u200B\u200B\u206F\u200B\u200F\u200F\u200F\u200C\u200E\u202D\u200F\u200F\u200F\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u200D\u206A\u202A\u206E\u200E\u206D\u200B\u206D\u200D\u202B\u200D\u206F\u202E\u202A\u206E\u206D\u202A\u202B\u200E\u200F\u202E\u206A\u206C\u202E\u200E\u206F\u202A\u206B\u206E\u200C\u206A\u206F\u206E\u200E\u200B\u206E\u202C\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u206C\u200C\u200F\u202E\u206D\u206B\u206F\u202C\u206E\u202D\u202D\u206A\u206D\u206E\u200D\u206A\u200F\u202B\u206B\u206A\u206A\u206A\u200C\u206D\u202B\u200F\u200C\u206E\u202A\u206B\u200F\u206B\u200C\u200E\u202D\u202E\u202D\u200C\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u202B\u200C\u206E\u202B\u206B\u206A\u202A\u200C\u200F\u206C\u202D\u202C\u206D\u200C\u200F\u206B\u206B\u200C\u200C\u200D\u206E\u206C\u202C\u200B\u202D\u206C\u200C\u206A\u206B\u202B\u206D\u200B\u200E\u202D\u206D\u206E\u200E\u200D\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreStarbowBreakDef))]
		public sealed class FlandreStarbowBreak : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					int num = FlandreStarbowBreakDef.FlandreStarbowBreak.\u200E\u206D\u202A\u202E\u202C\u200F\u206D\u200E\u202E\u200E\u200B\u200E\u202B\u206C\u202C\u200C\u206D\u202B\u200E\u206C\u200B\u200D\u202D\u200C\u206A\u202E\u200F\u200E\u206B\u200D\u206F\u202C\u206F\u206B\u206D\u202A\u200F\u202B\u200D\u206C\u202E(this).GetValueOrDefault() * 3;
					BattleController battleController = FlandreStarbowBreakDef.FlandreStarbowBreak.\u206B\u206F\u202E\u200E\u206D\u202B\u202B\u202B\u202E\u206B\u202E\u200C\u200C\u202E\u206B\u200E\u206B\u200E\u202B\u206E\u200D\u206E\u200D\u206D\u202C\u206C\u206D\u206A\u200C\u206C\u202D\u206F\u200B\u202C\u200E\u206D\u200E\u202E\u200D\u202B\u202E(this);
					int? num2;
					if (battleController == null)
					{
						num2 = null;
					}
					else
					{
						num2 = new int?(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206F\u200C\u206F\u200D\u206A\u206C\u206F\u206D\u202D\u202D\u200B\u202E\u202C\u200E\u206E\u206C\u206F\u202B\u206E\u202C\u206A\u206D\u200B\u206C\u202C\u202D\u206D\u200B\u206F\u200B\u206D\u206E\u200C\u200B\u200B\u200F\u206C\u206D\u202C\u200E\u202E(battleController).Count((Card c) => FlandreStarbowBreakDef.FlandreStarbowBreak.<>c.\u202E\u206B\u206E\u200C\u206B\u202D\u200C\u206C\u202D\u200B\u200D\u206D\u200F\u206D\u200C\u200C\u206A\u202A\u202A\u206A\u200B\u206B\u206A\u200E\u206C\u200C\u200B\u206D\u202B\u202A\u206D\u206A\u200D\u206C\u206D\u202C\u206C\u206D\u206B\u206D\u202E(c) == CardType.Attack));
					}
					return num + ((num2 + ((this.IsHand > false) ? 1 : 0)) * this.FlandreValue1).GetValueOrDefault();
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreStarbowBreakDef.FlandreStarbowBreak.\u200E\u206D\u202A\u202E\u202C\u200F\u206D\u200E\u202E\u200E\u200B\u200E\u202B\u206C\u202C\u200C\u206D\u202B\u200E\u206C\u200B\u200D\u202D\u200C\u206A\u202E\u200F\u200E\u206B\u200D\u206F\u202C\u206F\u206B\u206D\u202A\u200F\u202B\u200D\u206C\u202E(this).GetValueOrDefault();
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreStarbowBreakDef.FlandreStarbowBreak.\u206D\u202A\u206D\u202D\u202A\u206D\u200C\u202B\u202A\u206E\u206F\u202E\u206D\u206C\u206C\u206F\u206F\u206A\u202D\u206F\u202B\u202C\u200C\u200D\u206C\u206E\u200E\u202B\u206A\u206A\u206B\u200B\u206A\u206F\u202A\u202D\u206F\u206E\u202D\u202A\u202E((float)FlandreStarbowBreakDef.FlandreStarbowBreak.\u200E\u206D\u202A\u202E\u202C\u200F\u206D\u200E\u202E\u200E\u200B\u200E\u202B\u206C\u202C\u200C\u206D\u202B\u200E\u206C\u200B\u200D\u202D\u200C\u206A\u202E\u200F\u200E\u206B\u200D\u206F\u202C\u206F\u206B\u206D\u202A\u200F\u202B\u200D\u206C\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				IEnumerator<EnemyUnit> enumerator = FlandreStarbowBreakDef.FlandreStarbowBreak.\u200C\u206D\u200E\u206F\u200E\u200C\u200C\u206B\u202E\u202D\u206C\u202C\u206F\u200E\u202B\u202D\u206B\u206B\u202A\u200D\u200C\u202B\u206A\u202D\u202B\u202A\u206C\u200E\u206C\u202C\u206C\u206C\u200F\u200E\u206B\u206C\u206F\u202D\u202E\u202A\u202E(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206B\u206F\u202E\u200E\u206D\u202B\u202B\u202B\u202E\u206B\u202E\u200C\u200C\u202E\u206B\u200E\u206B\u200E\u202B\u206E\u200D\u206E\u200D\u206D\u202C\u206C\u206D\u206A\u200C\u206C\u202D\u206F\u200B\u202C\u200E\u206D\u200E\u202E\u200D\u202B\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0072:
						int num = (FlandreStarbowBreakDef.FlandreStarbowBreak.\u200B\u202E\u206B\u202E\u200D\u202A\u206B\u200B\u206F\u206C\u200F\u200F\u206B\u206D\u206C\u202C\u200D\u202C\u200B\u206B\u206C\u202D\u206E\u202E\u206A\u202A\u206A\u202C\u200C\u202C\u200D\u202D\u206A\u206A\u202B\u202C\u200D\u200E\u206D\u206D\u202E(enumerator) ? (-1811603916) : (-28942212));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(~(uint)(-(uint)num2)))) % 5U)
							{
							case 0U:
								num = -1811603916;
								continue;
							case 1U:
								goto IL_0072;
							case 2U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = -1831800588;
								continue;
							}
							case 4U:
							{
								EnemyUnit enemyUnit;
								base.HandleBattleEvent<DamageEventArgs>(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206C\u200C\u200C\u206B\u206B\u202E\u206E\u206A\u206C\u206F\u202B\u202A\u206B\u206C\u206A\u206C\u202D\u206B\u202C\u202D\u202D\u202E\u206F\u202A\u206C\u206C\u202E\u200E\u206A\u206E\u200C\u206B\u200F\u206B\u206E\u206F\u200F\u200E\u200B\u202D\u202E(enemyUnit), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageReceiving), (GameEventPriority)0);
								num = (int)((num3 * 3739586210U) ^ 11889834U);
								continue;
							}
							}
							goto Block_3;
						}
					}
					Block_3:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0090:
							int num4 = -1653049227;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-(uint)(~(uint)(-(uint)num2)))) % 3U)
								{
								case 1U:
									FlandreStarbowBreakDef.FlandreStarbowBreak.\u206F\u206D\u200E\u206F\u206B\u200E\u200E\u206E\u202C\u202B\u206D\u200B\u200B\u206E\u202A\u200C\u200C\u202C\u206B\u202E\u206E\u200C\u200D\u206D\u200F\u206B\u200D\u200F\u200E\u202C\u206F\u206F\u200E\u200E\u206A\u206C\u202A\u200D\u206C\u206E\u202E(enumerator);
									num4 = (int)((num3 * 1788881773U) ^ 3129283527U);
									continue;
								case 2U:
									goto IL_0090;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206A\u200D\u206E\u200C\u200B\u202D\u200E\u206C\u206C\u200C\u206C\u200B\u206E\u206E\u200F\u200E\u200B\u202B\u200D\u202A\u202B\u202A\u206E\u202B\u200D\u202C\u202E\u202A\u200E\u206F\u206B\u202E\u202D\u200D\u206A\u206A\u202A\u200B\u206C\u206D\u202E(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206B\u206F\u202E\u200E\u206D\u202B\u202B\u202B\u202E\u206B\u202E\u200C\u200C\u202E\u206B\u200E\u206B\u200E\u202B\u206E\u200D\u206E\u200D\u206D\u202C\u206C\u206D\u206A\u200C\u206C\u202D\u206F\u200B\u202C\u200E\u206D\u200E\u202E\u200D\u202B\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
			}

			private void OnEnemyDamageReceiving(DamageEventArgs args)
			{
				DamageInfo damageInfo = FlandreStarbowBreakDef.FlandreStarbowBreak.\u206E\u206D\u206D\u202E\u200B\u200F\u206D\u206D\u206E\u202C\u206D\u200E\u206C\u206C\u206D\u206B\u206D\u200F\u200F\u202A\u206E\u202B\u206B\u202D\u206B\u200D\u202E\u206C\u200E\u202D\u200B\u202A\u200E\u202A\u202E\u202E\u202D\u202B\u200F\u200F\u202E(args);
				if (FlandreStarbowBreakDef.FlandreStarbowBreak.\u200F\u206C\u206D\u206D\u202C\u206B\u202E\u200D\u200F\u206C\u206A\u200F\u206E\u200F\u200E\u200E\u202D\u202B\u206D\u200B\u202D\u200D\u206B\u206A\u200B\u200C\u202E\u206B\u206D\u200E\u206C\u206B\u200B\u206A\u206F\u202A\u206B\u200C\u202B\u200F\u202E(args) == this)
				{
					for (;;)
					{
						IL_0013:
						int num = 631633595;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(~(uint)(-(uint)(~(uint)num2))))) % 6U)
							{
							case 1U:
								num = (int)(((damageInfo.DamageType != DamageType.Attack) ? 3314382515U : 3652455115U) ^ (num3 * 462887025U));
								continue;
							case 2U:
								num = (int)(((FlandreStarbowBreakDef.FlandreStarbowBreak.\u202E\u202E\u206D\u206D\u206B\u200E\u206D\u206E\u206D\u206A\u202A\u200F\u206A\u206E\u200E\u206F\u206C\u202A\u206E\u206E\u202E\u200D\u206E\u206F\u202B\u200D\u200B\u202C\u206E\u206B\u202A\u202A\u206E\u206B\u206C\u206F\u200E\u202E\u200F\u202E(FlandreStarbowBreakDef.FlandreStarbowBreak.\u200E\u206F\u206E\u206A\u206C\u206B\u202D\u202A\u206E\u206F\u206C\u202A\u206F\u202E\u206E\u202E\u202A\u200E\u206F\u206B\u202D\u206F\u202D\u206A\u206B\u206B\u200D\u200B\u200E\u206D\u200B\u206C\u200B\u202A\u206B\u206D\u200C\u200F\u200B\u206D\u202E(args)) > 0) ? 2299446748U : 2553893993U) ^ (num3 * 2682380657U));
								continue;
							case 3U:
								num = (int)(((FlandreStarbowBreakDef.FlandreStarbowBreak.\u202A\u206C\u202C\u202C\u206A\u200D\u206A\u206F\u206A\u202E\u200B\u202E\u200E\u202D\u206C\u200F\u202D\u206A\u200E\u202C\u202B\u206A\u206A\u200D\u202E\u206E\u206D\u206D\u202A\u200B\u200D\u202D\u206D\u200F\u206F\u206F\u206F\u202D\u202E(FlandreStarbowBreakDef.FlandreStarbowBreak.\u200E\u206F\u206E\u206A\u206C\u206B\u202D\u202A\u206E\u206F\u206C\u202A\u206F\u202E\u206E\u202E\u202A\u200E\u206F\u206B\u202D\u206F\u202D\u206A\u206B\u206B\u200D\u200B\u200E\u206D\u200B\u206C\u200B\u202A\u206B\u206D\u200C\u200F\u200B\u206D\u202E(args)) > 0) ? 3502278675U : 3674339129U) ^ (num3 * 570891661U));
								continue;
							case 4U:
								damageInfo.Damage = damageInfo.Amount * (float)FlandreStarbowBreakDef.FlandreStarbowBreak.\u206C\u202B\u200D\u200C\u206A\u200C\u206E\u202A\u202A\u206C\u206E\u206A\u202A\u200B\u200D\u206F\u206B\u200B\u202A\u200D\u202C\u200D\u206F\u200B\u202B\u200D\u206B\u206A\u202C\u206E\u200F\u202D\u200B\u200C\u202C\u202D\u200D\u200E\u206C\u202A\u202E(this.FlandreValue2, 1);
								FlandreStarbowBreakDef.FlandreStarbowBreak.\u202E\u202E\u200C\u200D\u202B\u202D\u200F\u202E\u206C\u202D\u206C\u200F\u206B\u200D\u206F\u206A\u202C\u200E\u206F\u206E\u202D\u200C\u200F\u202D\u202D\u200C\u206F\u202B\u200E\u202C\u202A\u200C\u200F\u202B\u200B\u206A\u202B\u206A\u200E\u206F\u202E(args, damageInfo);
								FlandreStarbowBreakDef.FlandreStarbowBreak.\u200F\u202D\u202A\u202C\u206E\u202B\u206E\u202A\u206F\u202C\u202B\u206E\u206E\u206A\u202E\u202E\u206B\u200C\u202C\u202D\u202C\u202C\u200F\u206E\u200D\u200B\u206F\u202E\u202B\u200E\u202C\u202B\u206E\u202E\u206C\u200E\u206C\u200E\u200E\u206A\u202E(args, this);
								num = 1616107486;
								continue;
							case 5U:
								goto IL_0013;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.HandleBattleEvent<DamageEventArgs>(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206C\u200C\u200C\u206B\u206B\u202E\u206E\u206A\u206C\u206F\u202B\u202A\u206B\u206C\u206A\u206C\u202D\u206B\u202C\u202D\u202D\u202E\u206F\u202A\u206C\u206C\u202E\u200E\u206A\u206E\u200C\u206B\u200F\u206B\u206E\u206F\u200F\u200E\u200B\u202D\u202E(FlandreStarbowBreakDef.FlandreStarbowBreak.\u206D\u206D\u200C\u206C\u200C\u200E\u202C\u200E\u200C\u202B\u200B\u200F\u206B\u200C\u200B\u200C\u202B\u202C\u206C\u206A\u206E\u202B\u202D\u202B\u206D\u206D\u202E\u206F\u200F\u200D\u206B\u202C\u202E\u206C\u200F\u206A\u202E\u202A\u200B\u202D\u202E(args)), new GameEventHandler<DamageEventArgs>(this.OnEnemyDamageReceiving), (GameEventPriority)0);
			}

			public override ManaGroup GetXCostFromPooled(ManaGroup pooledMana)
			{
				ManaGroup manaGroup = ManaGroup.Empty;
				IEnumerator<ManaColor> enumerator = ManaColors.SingleColors.GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0089:
						int num = (FlandreStarbowBreakDef.FlandreStarbowBreak.\u200B\u202E\u206B\u202E\u200D\u202A\u206B\u200B\u206F\u206C\u200F\u200F\u206B\u206D\u206C\u202C\u200D\u202C\u200B\u206B\u206C\u202D\u206E\u202E\u206A\u202A\u206A\u202C\u200C\u202C\u200D\u202D\u206A\u206A\u202B\u202C\u200D\u200E\u206D\u206D\u202E(enumerator) ? 894955609 : (-787815727));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(-num2 * 2024523963) ^ -1560307608)) % 7U)
							{
							case 0U:
							{
								ManaGroup manaGroup2;
								ManaColor manaColor;
								num = (int)(((manaGroup2.GetValue(manaColor) != 0) ? 2111128886U : 1245550986U) ^ (num3 * 2506602190U));
								continue;
							}
							case 1U:
							{
								ManaColor manaColor = enumerator.Current;
								num = ((pooledMana.GetValue(manaColor) <= 0) ? (-1883451162) : 1787854573);
								continue;
							}
							case 2U:
							{
								ManaGroup manaGroup2 = FlandreStarbowBreakDef.FlandreStarbowBreak.\u200D\u200E\u200C\u200B\u200E\u206F\u202E\u206D\u200B\u202C\u200C\u206A\u200F\u202E\u202D\u206A\u200F\u200D\u206F\u202A\u206C\u200C\u202A\u200C\u206D\u206B\u200E\u200B\u206F\u200F\u206D\u200F\u200E\u202B\u202C\u202D\u200C\u206D\u206D\u206C\u202E(this);
								num = (int)((num3 * 392623847U) ^ 3571585273U);
								continue;
							}
							case 4U:
								goto IL_0089;
							case 5U:
								num = 894955609;
								continue;
							case 6U:
							{
								ManaColor manaColor;
								manaGroup += ManaGroup.Single(manaColor);
								num = (int)((num3 * 1931355536U) ^ 758464566U);
								continue;
							}
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
							IL_00F7:
							int num4 = -86704987;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~(-num2 * 2024523963) ^ -1560307608)) % 3U)
								{
								case 0U:
									goto IL_00F7;
								case 1U:
									FlandreStarbowBreakDef.FlandreStarbowBreak.\u206F\u206D\u200E\u206F\u206B\u200E\u200E\u206E\u202C\u202B\u206D\u200B\u200B\u206E\u202A\u200C\u200C\u202C\u206B\u202E\u206E\u200C\u200D\u206D\u200F\u206B\u200D\u200F\u200E\u202C\u206F\u206F\u200E\u200E\u206A\u206C\u202A\u200D\u206C\u206E\u202E(enumerator);
									num4 = (int)((num3 * 3375013741U) ^ 3782025964U);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
				manaGroup.Philosophy = pooledMana.Philosophy;
				if (manaGroup.Amount > 6)
				{
					for (;;)
					{
						IL_0155:
						int num5 = -1598989233;
						for (;;)
						{
							int num2 = num5;
							uint num3;
							switch ((num3 = (uint)(~(-num2 * 2024523963) ^ -1560307608)) % 3U)
							{
							case 0U:
								goto IL_0155;
							case 2U:
								manaGroup -= ManaGroup.Philosophies(manaGroup.Amount - 6);
								num5 = (int)((num3 * 873889559U) ^ 917294239U);
								continue;
							}
							goto Block_2;
						}
					}
					Block_2:;
				}
				return manaGroup;
			}

			public override Interaction Precondition()
			{
				this.IsHand = FlandreStarbowBreakDef.FlandreStarbowBreak.\u202E\u206F\u206C\u202E\u200E\u200F\u202B\u202B\u200E\u206E\u206D\u206F\u202C\u202B\u202C\u206B\u206B\u206D\u206B\u200E\u206F\u206F\u202B\u206D\u206B\u206E\u206C\u202D\u206A\u202D\u200E\u206C\u202C\u206E\u206E\u202E\u206A\u206B\u202E\u200F\u202E(this) == CardZone.Hand;
				return base.Precondition();
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreStarbowBreakDef.FlandreStarbowBreak.<Actions>d__12 <Actions>d__ = new FlandreStarbowBreakDef.FlandreStarbowBreak.<Actions>d__12(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__consumingMana = consumingMana;
				return <Actions>d__;
			}

			static int? \u200E\u206D\u202A\u202E\u202C\u200F\u206D\u200E\u202E\u200E\u200B\u200E\u202B\u206C\u202C\u200C\u206D\u202B\u200E\u206C\u200B\u200D\u202D\u200C\u206A\u202E\u200F\u200E\u206B\u200D\u206F\u202C\u206F\u206B\u206D\u202A\u200F\u202B\u200D\u206C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u206B\u206F\u202E\u200E\u206D\u202B\u202B\u202B\u202E\u206B\u202E\u200C\u200C\u202E\u206B\u200E\u206B\u200E\u202B\u206E\u200D\u206E\u200D\u206D\u202C\u206C\u206D\u206A\u200C\u206C\u202D\u206F\u200B\u202C\u200E\u206D\u200E\u202E\u200D\u202B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206F\u200C\u206F\u200D\u206A\u206C\u206F\u206D\u202D\u202D\u200B\u202E\u202C\u200E\u206E\u206C\u206F\u202B\u206E\u202C\u206A\u206D\u200B\u206C\u202C\u202D\u206D\u200B\u206F\u200B\u206D\u206E\u200C\u200B\u200B\u200F\u206C\u206D\u202C\u200E\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static int \u206D\u202A\u206D\u202D\u202A\u206D\u200C\u202B\u202A\u206E\u206F\u202E\u206D\u206C\u206C\u206F\u206F\u206A\u202D\u206F\u202B\u202C\u200C\u200D\u206C\u206E\u200E\u202B\u206A\u206A\u206B\u200B\u206A\u206F\u202A\u202D\u206F\u206E\u202D\u202A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static IEnumerable<EnemyUnit> \u200C\u206D\u200E\u206F\u200E\u200C\u200C\u206B\u202E\u202D\u206C\u202C\u206F\u200E\u202B\u202D\u206B\u206B\u202A\u200D\u200C\u202B\u206A\u202D\u202B\u202A\u206C\u200E\u206C\u202C\u206C\u206C\u200F\u200E\u206B\u206C\u206F\u202D\u202E\u202A\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<DamageEventArgs> \u206C\u200C\u200C\u206B\u206B\u202E\u206E\u206A\u206C\u206F\u202B\u202A\u206B\u206C\u206A\u206C\u202D\u206B\u202C\u202D\u202D\u202E\u206F\u202A\u206C\u206C\u202E\u200E\u206A\u206E\u200C\u206B\u200F\u206B\u206E\u206F\u200F\u200E\u200B\u202D\u202E(Unit A_0)
			{
				return A_0.DamageReceiving;
			}

			static bool \u200B\u202E\u206B\u202E\u200D\u202A\u206B\u200B\u206F\u206C\u200F\u200F\u206B\u206D\u206C\u202C\u200D\u202C\u200B\u206B\u206C\u202D\u206E\u202E\u206A\u202A\u206A\u202C\u200C\u202C\u200D\u202D\u206A\u206A\u202B\u202C\u200D\u200E\u206D\u206D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206F\u206D\u200E\u206F\u206B\u200E\u200E\u206E\u202C\u202B\u206D\u200B\u200B\u206E\u202A\u200C\u200C\u202C\u206B\u202E\u206E\u200C\u200D\u206D\u200F\u206B\u200D\u200F\u200E\u202C\u206F\u206F\u200E\u200E\u206A\u206C\u202A\u200D\u206C\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u206A\u200D\u206E\u200C\u200B\u202D\u200E\u206C\u206C\u200C\u206C\u200B\u206E\u206E\u200F\u200E\u200B\u202B\u200D\u202A\u202B\u202A\u206E\u202B\u200D\u202C\u202E\u202A\u200E\u206F\u206B\u202E\u202D\u200D\u206A\u206A\u202A\u200B\u206C\u206D\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static DamageInfo \u206E\u206D\u206D\u202E\u200B\u200F\u206D\u206D\u206E\u202C\u206D\u200E\u206C\u206C\u206D\u206B\u206D\u200F\u200F\u202A\u206E\u202B\u206B\u202D\u206B\u200D\u202E\u206C\u200E\u202D\u200B\u202A\u200E\u202A\u202E\u202E\u202D\u202B\u200F\u200F\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static GameEntity \u200F\u206C\u206D\u206D\u202C\u206B\u202E\u200D\u200F\u206C\u206A\u200F\u206E\u200F\u200E\u200E\u202D\u202B\u206D\u200B\u202D\u200D\u206B\u206A\u200B\u200C\u202E\u206B\u206D\u200E\u206C\u206B\u200B\u206A\u206F\u202A\u206B\u200C\u202B\u200F\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static Unit \u200E\u206F\u206E\u206A\u206C\u206B\u202D\u202A\u206E\u206F\u206C\u202A\u206F\u202E\u206E\u202E\u202A\u200E\u206F\u206B\u202D\u206F\u202D\u206A\u206B\u206B\u200D\u200B\u200E\u206D\u200B\u206C\u200B\u202A\u206B\u206D\u200C\u200F\u200B\u206D\u202E(DamageEventArgs A_0)
			{
				return A_0.Target;
			}

			static int \u202E\u202E\u206D\u206D\u206B\u200E\u206D\u206E\u206D\u206A\u202A\u200F\u206A\u206E\u200E\u206F\u206C\u202A\u206E\u206E\u202E\u200D\u206E\u206F\u202B\u200D\u200B\u202C\u206E\u206B\u202A\u202A\u206E\u206B\u206C\u206F\u200E\u202E\u200F\u202E(Unit A_0)
			{
				return A_0.Shield;
			}

			static int \u202A\u206C\u202C\u202C\u206A\u200D\u206A\u206F\u206A\u202E\u200B\u202E\u200E\u202D\u206C\u200F\u202D\u206A\u200E\u202C\u202B\u206A\u206A\u200D\u202E\u206E\u206D\u206D\u202A\u200B\u200D\u202D\u206D\u200F\u206F\u206F\u206F\u202D\u202E(Unit A_0)
			{
				return A_0.Block;
			}

			static int \u206C\u202B\u200D\u200C\u206A\u200C\u206E\u202A\u202A\u206C\u206E\u206A\u202A\u200B\u200D\u206F\u206B\u200B\u202A\u200D\u202C\u200D\u206F\u200B\u202B\u200D\u206B\u206A\u202C\u206E\u200F\u202D\u200B\u200C\u202C\u202D\u200D\u200E\u206C\u202A\u202E(int A_0, int A_1)
			{
				return Math.Max(A_0, A_1);
			}

			static void \u202E\u202E\u200C\u200D\u202B\u202D\u200F\u202E\u206C\u202D\u206C\u200F\u206B\u200D\u206F\u206A\u202C\u200E\u206F\u206E\u202D\u200C\u200F\u202D\u202D\u200C\u206F\u202B\u200E\u202C\u202A\u200C\u200F\u202B\u200B\u206A\u202B\u206A\u200E\u206F\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200F\u202D\u202A\u202C\u206E\u202B\u206E\u202A\u206F\u202C\u202B\u206E\u206E\u206A\u202E\u202E\u206B\u200C\u202C\u202D\u202C\u202C\u200F\u206E\u200D\u200B\u206F\u202E\u202B\u200E\u202C\u202B\u206E\u202E\u206C\u200E\u206C\u200E\u200E\u206A\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static Unit \u206D\u206D\u200C\u206C\u200C\u200E\u202C\u200E\u200C\u202B\u200B\u200F\u206B\u200C\u200B\u200C\u202B\u202C\u206C\u206A\u206E\u202B\u202D\u202B\u206D\u206D\u202E\u206F\u200F\u200D\u206B\u202C\u202E\u206C\u200F\u206A\u202E\u202A\u200B\u202D\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			static ManaGroup \u200D\u200E\u200C\u200B\u200E\u206F\u202E\u206D\u200B\u202C\u200C\u206A\u200F\u202E\u202D\u206A\u200F\u200D\u206F\u202A\u206C\u200C\u202A\u200C\u206D\u206B\u200E\u200B\u206F\u200F\u206D\u200F\u200E\u202B\u202C\u202D\u200C\u206D\u206D\u206C\u202E(Card A_0)
			{
				return A_0.XCostRequiredMana;
			}

			static CardZone \u202E\u206F\u206C\u202E\u200E\u200F\u202B\u202B\u200E\u206E\u206D\u206F\u202C\u202B\u202C\u206B\u206B\u206D\u206B\u200E\u206F\u206F\u202B\u206D\u206B\u206E\u206C\u202D\u206A\u202D\u200E\u206C\u202C\u206E\u206E\u202E\u206A\u206B\u202E\u200F\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			private bool IsHand;
		}
	}
}
