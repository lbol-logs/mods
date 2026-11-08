using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
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
	public sealed class FlandreCatadioptricDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2124024383);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreCatadioptricDef.\u202B\u202B\u206E\u200E\u206E\u200B\u200B\u202D\u206A\u200C\u200F\u202D\u206C\u200C\u200B\u200F\u200D\u202B\u206F\u200F\u206B\u206B\u200C\u206E\u200F\u202D\u200B\u202B\u202E\u202E\u200B\u206E\u206D\u202D\u202B\u202C\u206D\u200B\u200B\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreCatadioptricDef.\u200E\u206F\u202E\u200B\u202B\u202D\u206F\u200D\u202C\u200F\u202B\u206A\u200B\u202B\u200F\u206C\u200B\u200E\u206C\u202C\u200B\u206C\u206B\u200E\u200C\u200F\u202B\u206B\u202E\u206F\u202A\u206F\u202E\u202D\u202E\u200C\u200B\u202C\u202D\u206A\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreCatadioptricDef.\u202C\u206B\u206B\u206D\u202A\u200B\u202C\u206C\u202A\u202D\u206D\u202C\u200F\u200B\u206E\u202D\u200F\u206A\u206A\u200F\u206E\u206D\u200D\u206A\u206F\u206F\u202A\u200B\u202D\u200F\u206A\u206F\u202D\u202C\u206C\u206E\u200D\u200B\u202A\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreCatadioptricDef.\u202C\u200B\u202E\u206F\u202D\u206C\u206C\u202D\u200B\u202C\u202D\u200C\u200B\u206C\u202D\u200E\u206C\u202C\u206C\u202D\u202C\u200D\u202E\u200B\u200D\u202B\u202B\u202D\u206C\u206F\u202B\u206E\u200E\u206D\u200C\u200B\u200E\u202B\u206C\u200F\u202E(BepinexPlugin.sequenceTable, FlandreCatadioptricDef.\u206D\u206A\u206A\u202C\u202A\u200C\u200F\u206B\u206E\u206A\u202A\u202D\u202D\u206E\u200D\u206E\u202D\u202E\u202C\u206C\u202B\u206E\u206F\u206D\u202A\u200F\u206E\u206D\u200D\u202A\u202C\u206B\u200E\u206D\u202B\u202A\u200C\u200E\u202E\u206F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1837287882), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2106816213), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden, Keyword.Forbidden, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1982893731), new List<string>());
		}

		static CardImages \u202B\u202B\u206E\u200E\u206E\u200B\u200B\u202D\u206A\u200C\u200F\u202D\u206C\u200C\u200B\u200F\u200D\u202B\u206F\u200F\u206B\u206B\u200C\u206E\u200F\u202D\u200B\u202B\u202E\u202E\u200B\u206E\u206D\u202D\u202B\u202C\u206D\u200B\u200B\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200E\u206F\u202E\u200B\u202B\u202D\u206F\u200D\u202C\u200F\u202B\u206A\u200B\u202B\u200F\u206C\u200B\u200E\u206C\u202C\u200B\u206C\u206B\u200E\u200C\u200F\u202B\u206B\u202E\u206F\u202A\u206F\u202E\u202D\u202E\u200C\u200B\u202C\u202D\u206A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u206B\u206B\u206D\u202A\u200B\u202C\u206C\u202A\u202D\u206D\u202C\u200F\u200B\u206E\u202D\u200F\u206A\u206A\u200F\u206E\u206D\u200D\u206A\u206F\u206F\u202A\u200B\u202D\u200F\u206A\u206F\u202D\u202C\u206C\u206E\u200D\u200B\u202A\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206D\u206A\u206A\u202C\u202A\u200C\u200F\u206B\u206E\u206A\u202A\u202D\u202D\u206E\u200D\u206E\u202D\u202E\u202C\u206C\u202B\u206E\u206F\u206D\u202A\u200F\u206E\u206D\u200D\u202A\u202C\u206B\u200E\u206D\u202B\u202A\u200C\u200E\u202E\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u200B\u202E\u206F\u202D\u206C\u206C\u202D\u200B\u202C\u202D\u200C\u200B\u206C\u202D\u200E\u206C\u202C\u206C\u202D\u202C\u200D\u202E\u200B\u200D\u202B\u202B\u202D\u206C\u206F\u202B\u206E\u200E\u206D\u200C\u200B\u200E\u202B\u206C\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreCatadioptricDef))]
		public sealed class FlandreCatadioptric : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreCatadioptricDef.FlandreCatadioptric.\u202D\u200E\u202E\u200D\u202C\u200D\u206E\u202B\u206F\u202D\u206D\u200B\u206F\u202C\u202B\u206A\u200C\u200D\u206A\u206A\u200B\u200C\u202B\u200F\u200C\u206E\u202C\u202A\u206A\u202A\u206B\u206E\u202E\u202D\u202C\u200C\u200F\u200E\u206E\u206E\u202E(this).GetValueOrDefault() * 3;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				IEnumerator<EnemyUnit> enumerator = FlandreCatadioptricDef.FlandreCatadioptric.\u206D\u206C\u200C\u206D\u206D\u206B\u206F\u202D\u200C\u206F\u206B\u206C\u200E\u200C\u202B\u206F\u200D\u206D\u206D\u202D\u202B\u206E\u206E\u200F\u206F\u202A\u206B\u206E\u206C\u206C\u200D\u206F\u202C\u200C\u200C\u200F\u200E\u206B\u206B\u200E\u202E(FlandreCatadioptricDef.FlandreCatadioptric.\u206E\u202A\u200E\u200B\u206B\u206B\u202B\u206E\u206D\u206D\u202C\u202D\u206D\u206D\u206C\u206E\u206E\u206C\u200E\u206D\u200B\u202B\u200B\u200F\u206B\u206C\u202B\u206C\u206D\u206E\u202D\u206A\u202D\u200C\u200E\u202E\u206D\u200D\u206A\u206A\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_003D:
						int num = (FlandreCatadioptricDef.FlandreCatadioptric.\u200F\u202B\u200E\u200B\u206B\u202D\u200D\u202D\u200F\u200D\u202B\u202E\u200E\u206C\u200F\u206B\u202B\u202A\u202D\u200B\u202C\u202A\u202B\u202E\u200C\u206A\u206B\u202E\u202E\u200E\u206C\u206C\u202B\u200D\u206E\u206D\u202E\u202B\u202E\u206D\u202E(enumerator) ? 1813799429 : 332075638);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(uint)(~(uint)(~(uint)num2))))) % 5U)
							{
							case 0U:
								num = 1813799429;
								continue;
							case 1U:
							{
								EnemyUnit enemyUnit;
								base.ReactBattleEvent<DamageEventArgs>(FlandreCatadioptricDef.FlandreCatadioptric.\u200F\u206D\u202E\u206A\u202E\u206F\u200E\u200F\u202E\u200B\u200D\u206A\u202E\u200F\u206B\u202E\u200D\u202A\u202C\u200B\u202A\u200E\u206E\u202B\u200C\u202A\u202C\u200B\u200E\u202A\u202C\u200E\u206F\u206B\u206D\u202E\u206F\u206B\u200C\u202B\u202E(enemyUnit), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
								num = (int)((num3 * 717978796U) ^ 1451396239U);
								continue;
							}
							case 3U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = 691902902;
								continue;
							}
							case 4U:
								goto IL_003D;
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
							int num4 = 1464242733;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(~(uint)(-(uint)(~(uint)(~(uint)num2))))) % 3U)
								{
								case 0U:
									goto IL_0090;
								case 2U:
									FlandreCatadioptricDef.FlandreCatadioptric.\u202D\u206E\u202B\u202E\u200D\u206E\u206E\u206B\u200B\u206A\u206F\u206D\u202C\u206C\u200D\u206D\u206A\u206B\u206E\u206D\u202A\u206E\u200E\u202E\u202C\u206E\u200D\u202A\u200F\u206F\u200F\u206E\u206E\u206B\u200F\u202C\u200F\u200F\u200C\u202B\u202E(enumerator);
									num4 = (int)((num3 * 1389977587U) ^ 1977385017U);
									continue;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreCatadioptricDef.FlandreCatadioptric.\u200C\u202D\u206B\u206B\u200B\u202A\u200D\u200D\u202E\u206A\u200E\u202E\u200E\u202B\u202B\u202E\u206D\u200B\u206B\u202D\u202A\u206F\u202D\u206D\u202C\u206A\u202A\u206E\u202E\u206A\u200B\u200C\u202C\u200D\u200D\u206A\u206A\u206A\u200C\u200D\u202E(FlandreCatadioptricDef.FlandreCatadioptric.\u206E\u202A\u200E\u200B\u206B\u206B\u202B\u206E\u206D\u206D\u202C\u202D\u206D\u206D\u206C\u206E\u206E\u206C\u200E\u206D\u200B\u202B\u200B\u200F\u206B\u206C\u202B\u206C\u206D\u206E\u202D\u206A\u202D\u200C\u200E\u202E\u206D\u200D\u206A\u206A\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
			}

			private IEnumerable<BattleAction> OnEnemyDamageReceived(DamageEventArgs args)
			{
				FlandreCatadioptricDef.FlandreCatadioptric.<OnEnemyDamageReceived>d__3 <OnEnemyDamageReceived>d__ = new FlandreCatadioptricDef.FlandreCatadioptric.<OnEnemyDamageReceived>d__3(-2);
				<OnEnemyDamageReceived>d__.<>4__this = this;
				<OnEnemyDamageReceived>d__.<>3__args = args;
				return <OnEnemyDamageReceived>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactBattleEvent<DamageEventArgs>(FlandreCatadioptricDef.FlandreCatadioptric.\u200F\u206D\u202E\u206A\u202E\u206F\u200E\u200F\u202E\u200B\u200D\u206A\u202E\u200F\u206B\u202E\u200D\u202A\u202C\u200B\u202A\u200E\u206E\u202B\u200C\u202A\u202C\u200B\u200E\u202A\u202C\u200E\u206F\u206B\u206D\u202E\u206F\u206B\u200C\u202B\u202E(FlandreCatadioptricDef.FlandreCatadioptric.\u206D\u202C\u206D\u206F\u206E\u202B\u206C\u206B\u206A\u200D\u206E\u206B\u202E\u202D\u206C\u206F\u206C\u200E\u202E\u206E\u206D\u206C\u200C\u206B\u202D\u200F\u200B\u200B\u200F\u206F\u202B\u202C\u206F\u200E\u206C\u206F\u202E\u206A\u202D\u202B\u202E(args)), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreCatadioptricDef.FlandreCatadioptric.<Actions>d__5 <Actions>d__ = new FlandreCatadioptricDef.FlandreCatadioptric.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static int? \u202D\u200E\u202E\u200D\u202C\u200D\u206E\u202B\u206F\u202D\u206D\u200B\u206F\u202C\u202B\u206A\u200C\u200D\u206A\u206A\u200B\u200C\u202B\u200F\u200C\u206E\u202C\u202A\u206A\u202A\u206B\u206E\u202E\u202D\u202C\u200C\u200F\u200E\u206E\u206E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u206E\u202A\u200E\u200B\u206B\u206B\u202B\u206E\u206D\u206D\u202C\u202D\u206D\u206D\u206C\u206E\u206E\u206C\u200E\u206D\u200B\u202B\u200B\u200F\u206B\u206C\u202B\u206C\u206D\u206E\u202D\u206A\u202D\u200C\u200E\u202E\u206D\u200D\u206A\u206A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u206D\u206C\u200C\u206D\u206D\u206B\u206F\u202D\u200C\u206F\u206B\u206C\u200E\u200C\u202B\u206F\u200D\u206D\u206D\u202D\u202B\u206E\u206E\u200F\u206F\u202A\u206B\u206E\u206C\u206C\u200D\u206F\u202C\u200C\u200C\u200F\u200E\u206B\u206B\u200E\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<DamageEventArgs> \u200F\u206D\u202E\u206A\u202E\u206F\u200E\u200F\u202E\u200B\u200D\u206A\u202E\u200F\u206B\u202E\u200D\u202A\u202C\u200B\u202A\u200E\u206E\u202B\u200C\u202A\u202C\u200B\u200E\u202A\u202C\u200E\u206F\u206B\u206D\u202E\u206F\u206B\u200C\u202B\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static bool \u200F\u202B\u200E\u200B\u206B\u202D\u200D\u202D\u200F\u200D\u202B\u202E\u200E\u206C\u200F\u206B\u202B\u202A\u202D\u200B\u202C\u202A\u202B\u202E\u200C\u206A\u206B\u202E\u202E\u200E\u206C\u206C\u202B\u200D\u206E\u206D\u202E\u202B\u202E\u206D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202D\u206E\u202B\u202E\u200D\u206E\u206E\u206B\u200B\u206A\u206F\u206D\u202C\u206C\u200D\u206D\u206A\u206B\u206E\u206D\u202A\u206E\u200E\u202E\u202C\u206E\u200D\u202A\u200F\u206F\u200F\u206E\u206E\u206B\u200F\u202C\u200F\u200F\u200C\u202B\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u200C\u202D\u206B\u206B\u200B\u202A\u200D\u200D\u202E\u206A\u200E\u202E\u200E\u202B\u202B\u202E\u206D\u200B\u206B\u202D\u202A\u206F\u202D\u206D\u202C\u206A\u202A\u206E\u202E\u206A\u200B\u200C\u202C\u200D\u200D\u206A\u206A\u206A\u200C\u200D\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static Unit \u206D\u202C\u206D\u206F\u206E\u202B\u206C\u206B\u206A\u200D\u206E\u206B\u202E\u202D\u206C\u206F\u206C\u200E\u202E\u206E\u206D\u206C\u200C\u206B\u202D\u200F\u200B\u200B\u200F\u206F\u202B\u202C\u206F\u200E\u206C\u206F\u202E\u206A\u202D\u202B\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}
		}
	}
}
