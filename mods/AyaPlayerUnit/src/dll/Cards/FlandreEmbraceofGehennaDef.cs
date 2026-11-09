using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
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
	public sealed class FlandreEmbraceofGehennaDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-258334504);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreEmbraceofGehennaDef.\u200C\u202A\u202C\u206A\u202D\u200B\u206D\u206A\u200F\u206F\u200C\u206F\u200C\u206C\u200B\u202E\u200D\u200C\u202B\u202D\u206E\u202E\u206C\u206E\u206C\u200C\u200F\u202C\u206F\u206A\u200B\u202A\u206E\u202C\u206F\u206A\u206C\u202C\u206D\u206D\u202E(BepinexPlugin.embeddedSource);
			FlandreEmbraceofGehennaDef.\u202E\u206B\u202D\u202E\u200F\u206D\u200F\u200E\u206F\u200F\u206D\u206D\u206E\u202C\u206A\u202A\u206E\u206C\u202E\u200D\u202D\u200B\u200E\u206F\u202C\u202E\u200D\u202A\u200E\u200E\u206D\u200C\u200C\u202E\u200E\u200B\u206B\u206E\u202A\u202A\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreEmbraceofGehennaDef.\u202E\u200C\u200B\u202D\u200B\u206A\u200C\u206E\u206C\u202A\u206A\u200C\u206A\u200B\u202A\u200B\u200F\u200B\u206E\u200D\u202A\u202C\u206A\u206F\u200B\u200B\u200C\u202A\u202B\u200B\u206A\u200F\u206B\u200C\u202C\u200B\u200E\u200C\u206B\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreEmbraceofGehennaDef.\u200F\u202B\u206D\u200B\u200D\u206A\u202D\u206D\u206F\u206F\u206D\u206E\u202B\u200B\u202E\u202C\u200E\u206B\u206A\u200D\u200C\u206B\u200C\u206A\u200B\u200E\u206D\u200F\u206F\u202E\u206F\u202B\u206B\u202B\u200D\u206C\u200E\u200B\u206C\u200F\u202E(BepinexPlugin.sequenceTable, FlandreEmbraceofGehennaDef.\u206C\u200E\u206E\u202A\u206C\u200C\u200E\u200B\u206C\u200E\u202C\u206F\u206B\u202D\u206A\u206E\u206D\u206A\u200D\u206C\u202C\u202A\u206A\u206C\u202D\u200F\u202A\u206C\u206B\u200C\u206E\u206A\u200D\u206D\u206C\u206E\u202D\u206A\u200B\u206D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Rare, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Any = 2,
				Blue = 1
			}, null, null, null, null, null, null, null, null, new int?(18), null, new int?(2), null, new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Shield, Keyword.Shield, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(98082179),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-220379302)
			}, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(98082179),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-220379302)
			}, new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1153560979), new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-427899661) });
		}

		static CardImages \u200C\u202A\u202C\u206A\u202D\u200B\u206D\u206A\u200F\u206F\u200C\u206F\u200C\u206C\u200B\u202E\u200D\u200C\u202B\u202D\u206E\u202E\u206C\u206E\u206C\u200C\u200F\u202C\u206F\u206A\u200B\u202A\u206E\u202C\u206F\u206A\u206C\u202C\u206D\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u206B\u202D\u202E\u200F\u206D\u200F\u200E\u206F\u200F\u206D\u206D\u206E\u202C\u206A\u202A\u206E\u206C\u202E\u200D\u202D\u200B\u200E\u206F\u202C\u202E\u200D\u202A\u200E\u200E\u206D\u200C\u200C\u202E\u200E\u200B\u206B\u206E\u202A\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202E\u200C\u200B\u202D\u200B\u206A\u200C\u206E\u206C\u202A\u206A\u200C\u206A\u200B\u202A\u200B\u200F\u200B\u206E\u200D\u202A\u202C\u206A\u206F\u200B\u200B\u200C\u202A\u202B\u200B\u206A\u200F\u206B\u200C\u202C\u200B\u200E\u200C\u206B\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u200E\u206E\u202A\u206C\u200C\u200E\u200B\u206C\u200E\u202C\u206F\u206B\u202D\u206A\u206E\u206D\u206A\u200D\u206C\u202C\u202A\u206A\u206C\u202D\u200F\u202A\u206C\u206B\u200C\u206E\u206A\u200D\u206D\u206C\u206E\u202D\u206A\u200B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u202B\u206D\u200B\u200D\u206A\u202D\u206D\u206F\u206F\u206D\u206E\u202B\u200B\u202E\u202C\u200E\u206B\u206A\u200D\u200C\u206B\u200C\u206A\u200B\u200E\u206D\u200F\u206F\u202E\u206F\u202B\u206B\u202B\u200D\u206C\u200E\u200B\u206C\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreEmbraceofGehennaDef))]
		public sealed class FlandreEmbraceofGehenna : FlandreCard
		{
			public override int AdditionalShield
			{
				get
				{
					return FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u200B\u202E\u206F\u202B\u200F\u200E\u206E\u200D\u200E\u202D\u202C\u202B\u206D\u202E\u206A\u202E\u206E\u200E\u206F\u200F\u206C\u200C\u206D\u200B\u202A\u200E\u202B\u200B\u206B\u200C\u200B\u200B\u202A\u202A\u206C\u206B\u202E\u206F\u200C\u206B\u202E(this).GetValueOrDefault() * 6 + base.GetSeLevel<FlandreCalamitySeDef.FlandreCalamitySe>() * this.FlandreValue1;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u202C\u206A\u206E\u202E\u200F\u206A\u202E\u202C\u202B\u202D\u202A\u206D\u202E\u206E\u202E\u206A\u200F\u206C\u206F\u206C\u202E\u206E\u206F\u200D\u200B\u206C\u206C\u206F\u206A\u206E\u200B\u206F\u206C\u200C\u206F\u206C\u206F\u202C\u206F\u206A\u202E((float)FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u200B\u202E\u206F\u202B\u200F\u200E\u206E\u200D\u200E\u202D\u202C\u202B\u206D\u202E\u206A\u202E\u206E\u200E\u206F\u200F\u206C\u200C\u206D\u200B\u202A\u200E\u202B\u200B\u206B\u200C\u200B\u200B\u202A\u202A\u206C\u206B\u202E\u206F\u200C\u206B\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u200B\u202E\u206F\u202B\u200F\u200E\u206E\u200D\u200E\u202D\u202C\u202B\u206D\u202E\u206A\u202E\u206E\u200E\u206F\u200F\u206C\u200C\u206D\u200B\u202A\u200E\u202B\u200B\u206B\u200C\u200B\u200B\u202A\u202A\u206C\u206B\u202E\u206F\u200C\u206B\u202E(this).GetValueOrDefault() * 3;
				}
			}

			public override int Amount
			{
				get
				{
					return base.GetSeLevel<FlandreCalamitySeDef.FlandreCalamitySe>() * this.FlandreValue2;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				IEnumerator<EnemyUnit> enumerator = FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u202B\u202B\u200F\u206B\u206D\u202D\u202E\u206D\u206E\u202E\u206F\u200C\u206C\u200F\u206D\u200D\u202A\u206A\u200D\u202D\u200E\u202A\u200E\u202E\u200E\u200F\u200E\u202C\u206D\u206B\u202D\u206E\u202B\u206D\u200C\u206F\u206E\u202C\u202B\u202A\u202E(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u200E\u200C\u206C\u202C\u200D\u206B\u206C\u206B\u202D\u206A\u202A\u200C\u200C\u200C\u206D\u206E\u202A\u202B\u206D\u200B\u206B\u200D\u200D\u200F\u202A\u206C\u206A\u200E\u206E\u200D\u200B\u202D\u206E\u206F\u202C\u206B\u200B\u202E\u202D\u206A\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0040:
						int num = (FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u206E\u202E\u202D\u206A\u200D\u202B\u200B\u202C\u206E\u200F\u202C\u206E\u206F\u202A\u202B\u200E\u200F\u202A\u200E\u200B\u206F\u206A\u202B\u200F\u206B\u206D\u202E\u202C\u202C\u202B\u200E\u206E\u206A\u202E\u202E\u200D\u200C\u202C\u206C\u202E(enumerator) ? 1345369724 : 436768510);
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-num2 * 105224243)) % 5U)
							{
							case 0U:
								num = 1345369724;
								continue;
							case 1U:
							{
								EnemyUnit enemyUnit;
								base.ReactBattleEvent<DieEventArgs>(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u206A\u206F\u200B\u202B\u200E\u202E\u202A\u202C\u206D\u202D\u202C\u200D\u206B\u206F\u202C\u202E\u206F\u202A\u200E\u206C\u200B\u202C\u206E\u202B\u206A\u206F\u200E\u206C\u202B\u202C\u200E\u200E\u200F\u202B\u200D\u200C\u206E\u206F\u206E\u202A\u202E(enemyUnit), new EventSequencedReactor<DieEventArgs>(this.OnEnemyDying), (GameEventPriority)99);
								num = (int)((num3 * 4228733745U) ^ 3969985809U);
								continue;
							}
							case 2U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = 1955704487;
								continue;
							}
							case 3U:
								goto IL_0040;
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
							IL_0095:
							int num4 = 1814412168;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-num2 * 105224243)) % 3U)
								{
								case 0U:
									goto IL_0095;
								case 2U:
									FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u202C\u206E\u202D\u200C\u200D\u206C\u206F\u202A\u200E\u206B\u206E\u206B\u200D\u206A\u200F\u206E\u202A\u200F\u202B\u200E\u200C\u206B\u206B\u206A\u202B\u206D\u200B\u202E\u206F\u206C\u202D\u206B\u206B\u206F\u202D\u206D\u200D\u200C\u206F\u206D\u202E(enumerator);
									num4 = (int)((num3 * 2810317465U) ^ 1069067899U);
									continue;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u206F\u202B\u202C\u202C\u206D\u200B\u200E\u206C\u200F\u200C\u202D\u202C\u200B\u200D\u206D\u202A\u200F\u206B\u200C\u200E\u200F\u202D\u206F\u202C\u200D\u202C\u202A\u206A\u206D\u202C\u206D\u202C\u206D\u202E\u202E\u202B\u200D\u200D\u202C\u206F\u202E(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u200E\u200C\u206C\u202C\u200D\u206B\u206C\u206B\u202D\u206A\u202A\u200C\u200C\u200C\u206D\u206E\u202A\u202B\u206D\u200B\u206B\u200D\u200D\u200F\u202A\u206C\u206A\u200E\u206E\u200D\u200B\u202D\u206E\u206F\u202C\u206B\u200B\u202E\u202D\u206A\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
			}

			private IEnumerable<BattleAction> OnEnemyDying(DieEventArgs args)
			{
				FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.<OnEnemyDying>d__9 <OnEnemyDying>d__ = new FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.<OnEnemyDying>d__9(-2);
				<OnEnemyDying>d__.<>4__this = this;
				<OnEnemyDying>d__.<>3__args = args;
				return <OnEnemyDying>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactBattleEvent<DieEventArgs>(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u206A\u206F\u200B\u202B\u200E\u202E\u202A\u202C\u206D\u202D\u202C\u200D\u206B\u206F\u202C\u202E\u206F\u202A\u200E\u206C\u200B\u202C\u206E\u202B\u206A\u206F\u200E\u206C\u202B\u202C\u200E\u200E\u200F\u202B\u200D\u200C\u206E\u206F\u206E\u202A\u202E(FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.\u206E\u206C\u206D\u200B\u200C\u200B\u202C\u206F\u202C\u202B\u200F\u206A\u206D\u200B\u202B\u200F\u202B\u206B\u202B\u206B\u202E\u200F\u200B\u202E\u200E\u200C\u200D\u206C\u202D\u206A\u202A\u202D\u202D\u206D\u200D\u202C\u202B\u206A\u202B\u200E\u202E(args)), new EventSequencedReactor<DieEventArgs>(this.OnEnemyDying), (GameEventPriority)99);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.<Actions>d__13 <Actions>d__ = new FlandreEmbraceofGehennaDef.FlandreEmbraceofGehenna.<Actions>d__13(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u200B\u202E\u206F\u202B\u200F\u200E\u206E\u200D\u200E\u202D\u202C\u202B\u206D\u202E\u206A\u202E\u206E\u200E\u206F\u200F\u206C\u200C\u206D\u200B\u202A\u200E\u202B\u200B\u206B\u200C\u200B\u200B\u202A\u202A\u206C\u206B\u202E\u206F\u200C\u206B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202C\u206A\u206E\u202E\u200F\u206A\u202E\u202C\u202B\u202D\u202A\u206D\u202E\u206E\u202E\u206A\u200F\u206C\u206F\u206C\u202E\u206E\u206F\u200D\u200B\u206C\u206C\u206F\u206A\u206E\u200B\u206F\u206C\u200C\u206F\u206C\u206F\u202C\u206F\u206A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static BattleController \u200E\u200C\u206C\u202C\u200D\u206B\u206C\u206B\u202D\u206A\u202A\u200C\u200C\u200C\u206D\u206E\u202A\u202B\u206D\u200B\u206B\u200D\u200D\u200F\u202A\u206C\u206A\u200E\u206E\u200D\u200B\u202D\u206E\u206F\u202C\u206B\u200B\u202E\u202D\u206A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u202B\u202B\u200F\u206B\u206D\u202D\u202E\u206D\u206E\u202E\u206F\u200C\u206C\u200F\u206D\u200D\u202A\u206A\u200D\u202D\u200E\u202A\u200E\u202E\u200E\u200F\u200E\u202C\u206D\u206B\u202D\u206E\u202B\u206D\u200C\u206F\u206E\u202C\u202B\u202A\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<DieEventArgs> \u206A\u206F\u200B\u202B\u200E\u202E\u202A\u202C\u206D\u202D\u202C\u200D\u206B\u206F\u202C\u202E\u206F\u202A\u200E\u206C\u200B\u202C\u206E\u202B\u206A\u206F\u200E\u206C\u202B\u202C\u200E\u200E\u200F\u202B\u200D\u200C\u206E\u206F\u206E\u202A\u202E(Unit A_0)
			{
				return A_0.Dying;
			}

			static bool \u206E\u202E\u202D\u206A\u200D\u202B\u200B\u202C\u206E\u200F\u202C\u206E\u206F\u202A\u202B\u200E\u200F\u202A\u200E\u200B\u206F\u206A\u202B\u200F\u206B\u206D\u202E\u202C\u202C\u202B\u200E\u206E\u206A\u202E\u202E\u200D\u200C\u202C\u206C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202C\u206E\u202D\u200C\u200D\u206C\u206F\u202A\u200E\u206B\u206E\u206B\u200D\u206A\u200F\u206E\u202A\u200F\u202B\u200E\u200C\u206B\u206B\u206A\u202B\u206D\u200B\u202E\u206F\u206C\u202D\u206B\u206B\u206F\u202D\u206D\u200D\u200C\u206F\u206D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u206F\u202B\u202C\u202C\u206D\u200B\u200E\u206C\u200F\u200C\u202D\u202C\u200B\u200D\u206D\u202A\u200F\u206B\u200C\u200E\u200F\u202D\u206F\u202C\u200D\u202C\u202A\u206A\u206D\u202C\u206D\u202C\u206D\u202E\u202E\u202B\u200D\u200D\u202C\u206F\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static Unit \u206E\u206C\u206D\u200B\u200C\u200B\u202C\u206F\u202C\u202B\u200F\u206A\u206D\u200B\u202B\u200F\u202B\u206B\u202B\u206B\u202E\u200F\u200B\u202E\u200E\u200C\u200D\u206C\u202D\u206A\u202A\u202D\u202D\u206D\u200D\u202C\u202B\u206A\u202B\u200E\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			private bool Attacking;

			private bool EffectPlayed;
		}
	}
}
