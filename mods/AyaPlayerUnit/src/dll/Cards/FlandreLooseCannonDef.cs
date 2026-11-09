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
	public sealed class FlandreLooseCannonDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-740888807);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreLooseCannonDef.\u206D\u200D\u206D\u206C\u206C\u202E\u206B\u200F\u202A\u202B\u200F\u200D\u206C\u206A\u200D\u206F\u206A\u200C\u200C\u206B\u202E\u200C\u202B\u202E\u206E\u200D\u200B\u200C\u200F\u206C\u206B\u206C\u202A\u200B\u206A\u202C\u206B\u206B\u200E\u206D\u202E(BepinexPlugin.embeddedSource);
			FlandreLooseCannonDef.\u206C\u202E\u202D\u206A\u200C\u200D\u200B\u200B\u206E\u206B\u206F\u206F\u206E\u206D\u202D\u206F\u206A\u200F\u202A\u206B\u206A\u200C\u206C\u200E\u202E\u206A\u202A\u200C\u206F\u202A\u206D\u200C\u200C\u202A\u206C\u200E\u200B\u206A\u202E\u200E\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreLooseCannonDef.\u206D\u206F\u202A\u206D\u206D\u206D\u200F\u206D\u200C\u200F\u200D\u206F\u200B\u202E\u202B\u206D\u200D\u200E\u202D\u200D\u202B\u202A\u200B\u206F\u200E\u206E\u200D\u206A\u206C\u202E\u206C\u206A\u206C\u200F\u200C\u206C\u206F\u202D\u202D\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreLooseCannonDef.\u206F\u200B\u202C\u202B\u200B\u206D\u206D\u206D\u202C\u200E\u202D\u206D\u202D\u200F\u206A\u206C\u206B\u202A\u206C\u206E\u202D\u202A\u206C\u206A\u206C\u202B\u202E\u200D\u200F\u202C\u200D\u200F\u200E\u206B\u202E\u200E\u206E\u200C\u206A\u202E(BepinexPlugin.sequenceTable, FlandreLooseCannonDef.\u206E\u200D\u202A\u200F\u202D\u202B\u206C\u202C\u206D\u200E\u202E\u202D\u206A\u206C\u202C\u202A\u200F\u200E\u200C\u206D\u200B\u200C\u202A\u206D\u202D\u200F\u202C\u206C\u206C\u202B\u200D\u206D\u202B\u206E\u206B\u200E\u206F\u202D\u206E\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000), 0, true, true, false, true, true, Rarity.Common, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 9
			}, null, null, null, null, new int?(27), null, null, null, null, null, new int?(9), null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Retain, Keyword.Accuracy | Keyword.Retain, false, Keyword.TempMorph, Keyword.TempMorph, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(560952467) }, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1625028300) }, new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1265946325), new List<string>());
		}

		static CardImages \u206D\u200D\u206D\u206C\u206C\u202E\u206B\u200F\u202A\u202B\u200F\u200D\u206C\u206A\u200D\u206F\u206A\u200C\u200C\u206B\u202E\u200C\u202B\u202E\u206E\u200D\u200B\u200C\u200F\u206C\u206B\u206C\u202A\u200B\u206A\u202C\u206B\u206B\u200E\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u202E\u202D\u206A\u200C\u200D\u200B\u200B\u206E\u206B\u206F\u206F\u206E\u206D\u202D\u206F\u206A\u200F\u202A\u206B\u206A\u200C\u206C\u200E\u202E\u206A\u202A\u200C\u206F\u202A\u206D\u200C\u200C\u202A\u206C\u200E\u200B\u206A\u202E\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u206F\u202A\u206D\u206D\u206D\u200F\u206D\u200C\u200F\u200D\u206F\u200B\u202E\u202B\u206D\u200D\u200E\u202D\u200D\u202B\u202A\u200B\u206F\u200E\u206E\u200D\u206A\u206C\u202E\u206C\u206A\u206C\u200F\u200C\u206C\u206F\u202D\u202D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u200D\u202A\u200F\u202D\u202B\u206C\u202C\u206D\u200E\u202E\u202D\u206A\u206C\u202C\u202A\u200F\u200E\u200C\u206D\u200B\u200C\u202A\u206D\u202D\u200F\u202C\u206C\u206C\u202B\u200D\u206D\u202B\u206E\u206B\u200E\u206F\u202D\u206E\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u200B\u202C\u202B\u200B\u206D\u206D\u206D\u202C\u200E\u202D\u206D\u202D\u200F\u206A\u206C\u206B\u202A\u206C\u206E\u202D\u202A\u206C\u206A\u206C\u202B\u202E\u200D\u200F\u202C\u200D\u200F\u200E\u206B\u202E\u200E\u206E\u200C\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreLooseCannonDef))]
		public sealed class FlandreLooseCannon : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreLooseCannonDef.FlandreLooseCannon.\u202A\u200F\u202C\u200C\u200C\u200E\u206D\u206C\u200B\u202C\u202C\u200D\u206D\u202E\u202C\u206A\u200F\u206D\u200C\u206A\u202C\u202D\u202B\u206D\u202C\u206E\u200F\u202D\u202B\u206A\u202D\u200D\u200F\u206D\u206D\u202A\u200E\u200C\u206C\u202E(this).GetValueOrDefault() * 9;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreLooseCannonDef.FlandreLooseCannon.\u202A\u200F\u202C\u200C\u200C\u200E\u206D\u206C\u200B\u202C\u202C\u200D\u206D\u202E\u202C\u206A\u200F\u206D\u200C\u206A\u202C\u202D\u202B\u206D\u202C\u206E\u200F\u202D\u202B\u206A\u202D\u200D\u200F\u206D\u206D\u202A\u200E\u200C\u206C\u202E(this).GetValueOrDefault() * 3;
				}
			}

			public ManaGroup Mana2
			{
				get
				{
					return ManaGroup.Anys(0);
				}
			}

			public override bool OnDrawVisual
			{
				get
				{
					return false;
				}
			}

			public override bool OnMoveVisual
			{
				get
				{
					return false;
				}
			}

			public override IEnumerable<BattleAction> OnDraw()
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<OnDraw>d__10 <OnDraw>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<OnDraw>d__10(-2);
				<OnDraw>d__.<>4__this = this;
				return <OnDraw>d__;
			}

			public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<OnMove>d__11 <OnMove>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<OnMove>d__11(-2);
				<OnMove>d__.<>4__this = this;
				<OnMove>d__.<>3__srcZone = srcZone;
				<OnMove>d__.<>3__dstZone = dstZone;
				return <OnMove>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				IEnumerator<EnemyUnit> enumerator = FlandreLooseCannonDef.FlandreLooseCannon.\u202C\u202C\u200C\u200D\u202B\u206D\u202C\u200F\u202D\u206D\u202A\u206E\u200C\u206F\u200B\u206C\u202D\u202B\u206E\u206D\u200E\u200B\u202D\u206A\u206C\u200D\u200D\u206D\u206C\u200D\u202E\u200B\u206F\u200E\u206A\u206C\u202D\u200B\u200D\u202A\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0085:
						int num = (FlandreLooseCannonDef.FlandreLooseCannon.\u206C\u202D\u206E\u202A\u202E\u202C\u200F\u200D\u206C\u202E\u202C\u206E\u200D\u206D\u202A\u200B\u200E\u206E\u200B\u206E\u206F\u206F\u206B\u202D\u206A\u200D\u200B\u200C\u202E\u206E\u206A\u206A\u206F\u200B\u200E\u202A\u206C\u200E\u206B\u202D\u202E(enumerator) ? 477257820 : 259103425);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(-num2 - -1336411611 * --1380738431) ^ 755591404)) % 5U)
							{
							case 1U:
								goto IL_0085;
							case 2U:
								num = 477257820;
								continue;
							case 3U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = -717050354;
								continue;
							}
							case 4U:
							{
								EnemyUnit enemyUnit;
								base.ReactBattleEvent<DamageEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u200C\u202E\u200C\u206C\u206F\u206E\u200C\u206C\u202E\u206D\u200D\u206B\u200E\u202C\u206B\u200F\u206A\u200F\u206A\u202A\u206A\u200C\u206F\u200C\u200C\u200B\u202A\u206D\u202D\u202C\u202B\u200D\u206F\u200D\u206C\u206C\u206F\u206E\u200C\u200E\u202E(enemyUnit), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
								num = (int)((num3 * 1404198237U) ^ 3838499143U);
								continue;
							}
							}
							goto Block_7;
						}
					}
					Block_7:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_00A6:
							int num4 = -1217235815;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-(-num2 - -1336411611 * --1380738431) ^ 755591404)) % 3U)
								{
								case 1U:
									FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u202A\u206A\u206D\u202B\u206F\u200C\u202E\u202C\u200B\u202E\u202D\u202D\u206E\u206D\u206A\u202E\u200F\u206D\u206A\u202A\u202B\u202D\u202C\u200C\u206B\u206B\u202B\u200F\u206F\u206F\u202D\u200D\u202E\u206B\u206F\u206E\u200F\u202A\u200F\u202E(enumerator);
									num4 = (int)((num3 * 3721958423U) ^ 3255001047U);
									continue;
								case 2U:
									goto IL_00A6;
								}
								goto Block_10;
							}
						}
						Block_10:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u202B\u200B\u206B\u206E\u206C\u206D\u202C\u200F\u206A\u206F\u200F\u200D\u200D\u206B\u202B\u206C\u206F\u206B\u206A\u206A\u202D\u202D\u200D\u202B\u200E\u202B\u206B\u200B\u200D\u202E\u200F\u202E\u206E\u200D\u200B\u200F\u206C\u202C\u202A\u202D\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
				for (;;)
				{
					IL_010F:
					int num5 = 111238419;
					for (;;)
					{
						int num2 = num5;
						uint num3;
						switch ((num3 = (uint)(-(-num2 - -1336411611 * --1380738431) ^ 755591404)) % 8U)
						{
						case 0U:
							goto IL_010F;
						case 2U:
							base.ReactBattleEvent<DamageEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u200C\u202E\u200C\u206C\u206F\u206E\u200C\u206C\u202E\u206D\u200D\u206B\u200E\u202C\u206B\u200F\u206A\u200F\u206A\u202A\u206A\u200C\u206F\u200C\u200C\u200B\u202A\u206D\u202D\u202C\u202B\u200D\u206F\u200D\u206C\u206C\u206F\u206E\u200C\u200E\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u206D\u200E\u202A\u200E\u202E\u202B\u206E\u206E\u206F\u202A\u206D\u200D\u200B\u206B\u206E\u200C\u206E\u202B\u206E\u202C\u202E\u202E\u206C\u206E\u206D\u202B\u202B\u200D\u202A\u202C\u206B\u202C\u200B\u206E\u206E\u200D\u202C\u200F\u206C\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this))), new EventSequencedReactor<DamageEventArgs>(this.OnPlayerDamageReceived));
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u200F\u202E\u202B\u200C\u206C\u200B\u202E\u202C\u202C\u202D\u202D\u206B\u202B\u200E\u202C\u206C\u202D\u202A\u202B\u202A\u200D\u206D\u206E\u200B\u206A\u206C\u202D\u202A\u206D\u202A\u200E\u200F\u200D\u202A\u206F\u202C\u202B\u202C\u200E\u200E\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num5 = (int)((num3 * 91311748U) ^ 4150837736U);
							continue;
						case 3U:
						{
							ManaGroup manaGroup;
							int amount = manaGroup.Amount;
							manaGroup = this.Mana2;
							num5 = (int)(((amount > manaGroup.Amount) ? 2590025921U : 2594609924U) ^ (num3 * 2074854753U));
							continue;
						}
						case 4U:
						{
							ManaGroup manaGroup = FlandreLooseCannonDef.FlandreLooseCannon.\u200C\u202B\u200F\u202B\u202B\u200F\u206F\u206B\u202C\u200D\u206F\u206E\u202D\u202D\u206C\u206D\u200D\u200D\u200B\u202E\u202C\u202E\u202D\u200B\u202E\u206A\u202B\u206A\u202C\u202D\u202D\u206C\u202E\u202B\u200E\u206E\u200F\u206E\u206D\u200F\u202E(this);
							num5 = (int)((num3 * 917869293U) ^ 2948652432U);
							continue;
						}
						case 5U:
							num5 = (int)(((FlandreLooseCannonDef.FlandreLooseCannon.\u202B\u200E\u202D\u200C\u200E\u202C\u200E\u202A\u202D\u206F\u206E\u200E\u206E\u202B\u200B\u200C\u202A\u206E\u202B\u206B\u202B\u202A\u200E\u206F\u206B\u206C\u206B\u206C\u200D\u206F\u200B\u206A\u206F\u202D\u202D\u206F\u206B\u206B\u200E\u200D\u202E(this) == CardZone.Hand) ? 539718628U : 1452563691U) ^ (num3 * 2076451181U));
							continue;
						case 6U:
							base.React(new LazySequencedReactor(this.EnterHandReactor));
							num5 = (int)((num3 * 3292777549U) ^ 1988258116U);
							continue;
						case 7U:
							base.ReactBattleEvent<CardUsingEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u206E\u202D\u202B\u200D\u202A\u206E\u200E\u206E\u202E\u200F\u206F\u202A\u202D\u202E\u200C\u202C\u200E\u206E\u206F\u202C\u200B\u206E\u202B\u206D\u200E\u200B\u200F\u200D\u202C\u202A\u200B\u206B\u206A\u200F\u202B\u206B\u200D\u206E\u202C\u206A\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num5 = (int)(((!FlandreLooseCannonDef.FlandreLooseCannon.\u206F\u206B\u200D\u206F\u200E\u200B\u206B\u202B\u206F\u200E\u206F\u206D\u206E\u206E\u202D\u206E\u202C\u200B\u202D\u206C\u206B\u202A\u200B\u200E\u206E\u200D\u206D\u202A\u202B\u206E\u206C\u206E\u200D\u202D\u206A\u206A\u200E\u200B\u206F\u202B\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(this))) ? 1855895673U : 1203514109U) ^ (num3 * 295157105U));
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> EnterHandReactor()
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<EnterHandReactor>d__13 <EnterHandReactor>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<EnterHandReactor>d__13(-2);
				<EnterHandReactor>d__.<>4__this = this;
				return <EnterHandReactor>d__;
			}

			private IEnumerable<BattleAction> OnEnemyDamageReceived(DamageEventArgs args)
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<OnEnemyDamageReceived>d__14 <OnEnemyDamageReceived>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<OnEnemyDamageReceived>d__14(-2);
				<OnEnemyDamageReceived>d__.<>4__this = this;
				<OnEnemyDamageReceived>d__.<>3__args = args;
				return <OnEnemyDamageReceived>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactBattleEvent<DamageEventArgs>(FlandreLooseCannonDef.FlandreLooseCannon.\u200C\u202E\u200C\u206C\u206F\u206E\u200C\u206C\u202E\u206D\u200D\u206B\u200E\u202C\u206B\u200F\u206A\u200F\u206A\u202A\u206A\u200C\u206F\u200C\u200C\u200B\u202A\u206D\u202D\u202C\u202B\u200D\u206F\u200D\u206C\u206C\u206F\u206E\u200C\u200E\u202E(FlandreLooseCannonDef.FlandreLooseCannon.\u200B\u202D\u206E\u200E\u206E\u206F\u206E\u202B\u206A\u200B\u206A\u202C\u206C\u202A\u206C\u200E\u206B\u206A\u206B\u206B\u200E\u202D\u206C\u206F\u206B\u202A\u200F\u206E\u200B\u206A\u206E\u200F\u202B\u206A\u202C\u206F\u206D\u200F\u202A\u206D\u202E(args)), new EventSequencedReactor<DamageEventArgs>(this.OnEnemyDamageReceived));
			}

			private IEnumerable<BattleAction> OnPlayerDamageReceived(DamageEventArgs args)
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<OnPlayerDamageReceived>d__16 <OnPlayerDamageReceived>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<OnPlayerDamageReceived>d__16(-2);
				<OnPlayerDamageReceived>d__.<>4__this = this;
				<OnPlayerDamageReceived>d__.<>3__args = args;
				return <OnPlayerDamageReceived>d__;
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<OnCardUsed>d__17 <OnCardUsed>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<OnCardUsed>d__17(-2);
				<OnCardUsed>d__.<>4__this = this;
				return <OnCardUsed>d__;
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsBloodlust = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreLooseCannonDef.FlandreLooseCannon.<Actions>d__19 <Actions>d__ = new FlandreLooseCannonDef.FlandreLooseCannon.<Actions>d__19(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202A\u200F\u202C\u200C\u200C\u200E\u206D\u206C\u200B\u202C\u202C\u200D\u206D\u202E\u202C\u206A\u200F\u206D\u200C\u206A\u202C\u202D\u202B\u206D\u202C\u206E\u200F\u202D\u202B\u206A\u202D\u200D\u200F\u206D\u206D\u202A\u200E\u200C\u206C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u200B\u200E\u202E\u202B\u202B\u206C\u200F\u202E\u200C\u200F\u202D\u200D\u200D\u200E\u206D\u202E\u206F\u202E\u206A\u206F\u206D\u206E\u202A\u206B\u206E\u206C\u200F\u200E\u206A\u200F\u202D\u206A\u206D\u202A\u206F\u202B\u206E\u202B\u202C\u200F\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u202C\u202C\u200C\u200D\u202B\u206D\u202C\u200F\u202D\u206D\u202A\u206E\u200C\u206F\u200B\u206C\u202D\u202B\u206E\u206D\u200E\u200B\u202D\u206A\u206C\u200D\u200D\u206D\u206C\u200D\u202E\u200B\u206F\u200E\u206A\u206C\u202D\u200B\u200D\u202A\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<DamageEventArgs> \u200C\u202E\u200C\u206C\u206F\u206E\u200C\u206C\u202E\u206D\u200D\u206B\u200E\u202C\u206B\u200F\u206A\u200F\u206A\u202A\u206A\u200C\u206F\u200C\u200C\u200B\u202A\u206D\u202D\u202C\u202B\u200D\u206F\u200D\u206C\u206C\u206F\u206E\u200C\u200E\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static bool \u206C\u202D\u206E\u202A\u202E\u202C\u200F\u200D\u206C\u202E\u202C\u206E\u200D\u206D\u202A\u200B\u200E\u206E\u200B\u206E\u206F\u206F\u206B\u202D\u206A\u200D\u200B\u200C\u202E\u206E\u206A\u206A\u206F\u200B\u200E\u202A\u206C\u200E\u206B\u202D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200B\u202A\u206A\u206D\u202B\u206F\u200C\u202E\u202C\u200B\u202E\u202D\u202D\u206E\u206D\u206A\u202E\u200F\u206D\u206A\u202A\u202B\u202D\u202C\u200C\u206B\u206B\u202B\u200F\u206F\u206F\u202D\u200D\u202E\u206B\u206F\u206E\u200F\u202A\u200F\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u202B\u200B\u206B\u206E\u206C\u206D\u202C\u200F\u206A\u206F\u200F\u200D\u200D\u206B\u202B\u206C\u206F\u206B\u206A\u206A\u202D\u202D\u200D\u202B\u200E\u202B\u206B\u200B\u200D\u202E\u200F\u202E\u206E\u200D\u200B\u200F\u206C\u202C\u202A\u202D\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static PlayerUnit \u200B\u206D\u200E\u202A\u200E\u202E\u202B\u206E\u206E\u206F\u202A\u206D\u200D\u200B\u206B\u206E\u200C\u206E\u202B\u206E\u202C\u202E\u202E\u206C\u206E\u206D\u202B\u202B\u200D\u202A\u202C\u206B\u202C\u200B\u206E\u206E\u200D\u202C\u200F\u206C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<CardUsingEventArgs> \u200F\u202E\u202B\u200C\u206C\u200B\u202E\u202C\u202C\u202D\u202D\u206B\u202B\u200E\u202C\u206C\u202D\u202A\u202B\u202A\u200D\u206D\u206E\u200B\u206A\u206C\u202D\u202A\u206D\u202A\u200E\u200F\u200D\u202A\u206F\u202C\u202B\u202C\u200E\u200E\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u206E\u202D\u202B\u200D\u202A\u206E\u200E\u206E\u202E\u200F\u206F\u202A\u202D\u202E\u200C\u202C\u200E\u206E\u206F\u202C\u200B\u206E\u202B\u206D\u200E\u200B\u200F\u200D\u202C\u202A\u200B\u206B\u206A\u200F\u202B\u206B\u200D\u206E\u202C\u206A\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u206F\u206B\u200D\u206F\u200E\u200B\u206B\u202B\u206F\u200E\u206F\u206D\u206E\u206E\u202D\u206E\u202C\u200B\u202D\u206C\u206B\u202A\u200B\u200E\u206E\u200D\u206D\u202A\u202B\u206E\u206C\u206E\u200D\u202D\u206A\u206A\u200E\u200B\u206F\u202B\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static CardZone \u202B\u200E\u202D\u200C\u200E\u202C\u200E\u202A\u202D\u206F\u206E\u200E\u206E\u202B\u200B\u200C\u202A\u206E\u202B\u206B\u202B\u202A\u200E\u206F\u206B\u206C\u206B\u206C\u200D\u206F\u200B\u206A\u206F\u202D\u202D\u206F\u206B\u206B\u200E\u200D\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			static ManaGroup \u200C\u202B\u200F\u202B\u202B\u200F\u206F\u206B\u202C\u200D\u206F\u206E\u202D\u202D\u206C\u206D\u200D\u200D\u200B\u202E\u202C\u202E\u202D\u200B\u202E\u206A\u202B\u206A\u202C\u202D\u202D\u206C\u202E\u202B\u200E\u206E\u200F\u206E\u206D\u200F\u202E(Card A_0)
			{
				return A_0.Cost;
			}

			static Unit \u200B\u202D\u206E\u200E\u206E\u206F\u206E\u202B\u206A\u200B\u206A\u202C\u206C\u202A\u206C\u200E\u206B\u206A\u206B\u206B\u200E\u202D\u206C\u206F\u206B\u202A\u200F\u206E\u200B\u206A\u206E\u200F\u202B\u206A\u202C\u206F\u206D\u200F\u202A\u206D\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}
		}
	}
}
