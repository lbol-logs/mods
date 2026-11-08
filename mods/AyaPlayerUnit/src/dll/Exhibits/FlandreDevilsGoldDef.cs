using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class FlandreDevilsGoldDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1882676404);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreDevilsGoldDef.\u202D\u206A\u200D\u206A\u206E\u206E\u206F\u202A\u200C\u206F\u202E\u200F\u206C\u200D\u206E\u200F\u206C\u202B\u202B\u206B\u200B\u202E\u202D\u200B\u202B\u206E\u206A\u206B\u202D\u200F\u206F\u206A\u206D\u202D\u202E\u206F\u206B\u200F\u206E\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder = "";
			ExhibitSprites exhibitSprites = FlandreDevilsGoldDef.\u206F\u206A\u200C\u202A\u206F\u202B\u202D\u206D\u200F\u202A\u200B\u202A\u206F\u200B\u200E\u202B\u202C\u202A\u202D\u200F\u202E\u206F\u206D\u200F\u206A\u206E\u206F\u200B\u200B\u200F\u206D\u202B\u200D\u202B\u200E\u200D\u200B\u206E\u206F\u200F\u202E();
			Func<string, Sprite> func = (string s) => FlandreDevilsGoldDef.<>c__DisplayClass2_0.\u206E\u200F\u206C\u200B\u202A\u206E\u200B\u206F\u200F\u202E\u206C\u206F\u206B\u206A\u202C\u202E\u206C\u200D\u200E\u200B\u206B\u202C\u206C\u206A\u206B\u200E\u202C\u206E\u202A\u206A\u206E\u206D\u206C\u200F\u202D\u206E\u206A\u206B\u202D\u206B\u202E(FlandreDevilsGoldDef.<>c__DisplayClass2_0.\u202B\u206B\u206D\u200B\u206F\u202D\u202E\u202D\u206B\u206F\u200F\u202C\u200C\u206C\u200E\u206E\u206A\u202C\u200E\u200F\u202C\u206E\u200B\u206D\u206F\u202B\u200C\u200C\u206F\u206A\u206E\u206E\u200E\u202D\u206C\u200B\u206E\u202A\u202E\u202D\u202E(folder, FlandreDevilsGoldDef.<>c__DisplayClass2_0.\u200C\u202A\u200D\u206A\u202A\u202A\u200B\u206A\u200C\u206B\u200B\u200F\u202C\u206A\u206D\u202B\u202C\u206B\u206D\u200E\u202B\u206B\u206A\u200C\u206C\u202E\u206B\u202D\u200C\u200D\u200F\u202C\u206C\u206F\u206F\u200C\u200D\u206E\u202A\u200E\u202E(this), s, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreDevilsGoldDef.\u202D\u206B\u200C\u200C\u202B\u202C\u200C\u206D\u200F\u206D\u202C\u200D\u202D\u200E\u200E\u206E\u202B\u200E\u206B\u200F\u202A\u200B\u206B\u200C\u206F\u206A\u202A\u202C\u206C\u206E\u200D\u200E\u200B\u202B\u200E\u202E\u200D\u206E\u200E\u206F\u202E(BepinexPlugin.sequenceTable, FlandreDevilsGoldDef.\u206C\u202D\u206F\u200B\u206A\u202C\u200B\u200C\u200E\u202C\u206C\u206A\u200F\u200E\u200C\u202A\u202B\u206C\u200B\u206E\u206A\u206D\u202A\u200F\u200F\u202C\u206C\u206E\u206B\u206F\u202B\u200C\u202E\u206F\u202C\u206F\u206C\u202D\u202E\u202C\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, true, AppearanceType.Anywhere, "", ExhibitLosableType.Losable, Rarity.Rare, new int?(5), new int?(15), null, null, null, null, 0, false, null, Keyword.None, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(274183061) }, new List<string>());
		}

		static BatchLocalization \u202D\u206A\u200D\u206A\u206E\u206E\u206F\u202A\u200C\u206F\u202E\u200F\u206C\u200D\u206E\u200F\u206C\u202B\u202B\u206B\u200B\u202E\u202D\u200B\u202B\u206E\u206A\u206B\u202D\u200F\u206F\u206A\u206D\u202D\u202E\u206F\u206B\u200F\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u206F\u206A\u200C\u202A\u206F\u202B\u202D\u206D\u200F\u202A\u200B\u202A\u206F\u200B\u200E\u202B\u202C\u202A\u202D\u200F\u202E\u206F\u206D\u200F\u206A\u206E\u206F\u200B\u200B\u200F\u206D\u202B\u200D\u202B\u200E\u200D\u200B\u206E\u206F\u200F\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u206C\u202D\u206F\u200B\u206A\u202C\u200B\u200C\u200E\u202C\u206C\u206A\u200F\u200E\u200C\u202A\u202B\u206C\u200B\u206E\u206A\u206D\u202A\u200F\u200F\u202C\u206C\u206E\u206B\u206F\u202B\u200C\u202E\u206F\u202C\u206F\u206C\u202D\u202E\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u206B\u200C\u200C\u202B\u202C\u200C\u206D\u200F\u206D\u202C\u200D\u202D\u200E\u200E\u206E\u202B\u200E\u206B\u200F\u202A\u200B\u206B\u200C\u206F\u206A\u202A\u202C\u206C\u206E\u200D\u200E\u200B\u202B\u200E\u202E\u200D\u206E\u200E\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreDevilsGoldDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter))]
		public sealed class FlandreDevilsGold : Exhibit
		{
			protected override void OnEnterBattle()
			{
				IEnumerator<EnemyUnit> enumerator = FlandreDevilsGoldDef.FlandreDevilsGold.\u200E\u200D\u206E\u202A\u200D\u200F\u202B\u202C\u200D\u206E\u206A\u206C\u206B\u200F\u202B\u206D\u206E\u200B\u202C\u202A\u202B\u202E\u200C\u206C\u202E\u206C\u202C\u206E\u202D\u206D\u202B\u202D\u206F\u202D\u200E\u200F\u200E\u202B\u206E\u200F\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.\u206B\u202D\u202C\u202B\u200C\u202B\u206B\u206A\u200F\u202E\u206E\u200D\u202B\u200E\u200E\u202B\u200D\u206B\u206A\u202B\u200E\u206B\u206D\u206F\u200D\u202A\u206F\u206C\u206C\u200F\u206C\u202A\u206C\u206D\u200C\u200F\u202E\u202A\u200E\u200F\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_007E:
						int num = (FlandreDevilsGoldDef.FlandreDevilsGold.\u202B\u200F\u200B\u202A\u202E\u202D\u206D\u202C\u206A\u200C\u206A\u202C\u206C\u206B\u206A\u202D\u202C\u200E\u202B\u206E\u206F\u202B\u206B\u202D\u206D\u202E\u206B\u202B\u206D\u206C\u206F\u202C\u206A\u200B\u200F\u200E\u200C\u206D\u202B\u206A\u202E(enumerator) ? 1652238605 : (-1257316275));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-719372521 * -1628883796 * -1020118887 - (num2 + (-(-226338657 - 834152788) - (447621230 ^ 1914315062 ^ (1571911595 + -881726728)))))) % 5U)
							{
							case 0U:
								num = 1652238605;
								continue;
							case 1U:
							{
								EnemyUnit enemyUnit;
								base.HandleBattleEvent<StatusEffectApplyEventArgs>(FlandreDevilsGoldDef.FlandreDevilsGold.\u202E\u202E\u200D\u206F\u206E\u206F\u200F\u206C\u206C\u200D\u200D\u206D\u202B\u202C\u202A\u206F\u200B\u202C\u202D\u200E\u202C\u206A\u200D\u202C\u202D\u202A\u206E\u200D\u200E\u202E\u200F\u206C\u200C\u202A\u206C\u200D\u206D\u202B\u206B\u202B\u202E(enemyUnit), new GameEventHandler<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
								num = (int)((num3 * 505341920U) ^ 2941920843U);
								continue;
							}
							case 2U:
								goto IL_007E;
							case 4U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = -1955723508;
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
							IL_00C6:
							int num4 = -1410273319;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-719372521 * -1628883796 * -1020118887 - (num2 + (-(-226338657 - 834152788) - (447621230 ^ 1914315062 ^ (1571911595 + -881726728)))))) % 3U)
								{
								case 0U:
									goto IL_00C6;
								case 1U:
									FlandreDevilsGoldDef.FlandreDevilsGold.\u206E\u206F\u206D\u200C\u200F\u202C\u200C\u202D\u202D\u206D\u200B\u206D\u206F\u200C\u202E\u206F\u202A\u200C\u206A\u206E\u206F\u200E\u200F\u206F\u206A\u206B\u200B\u206C\u200E\u202E\u200F\u206D\u200B\u200B\u202E\u202E\u206A\u200B\u206D\u200E\u202E(enumerator);
									num4 = (int)((num3 * 1639121969U) ^ 3626320100U);
									continue;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreDevilsGoldDef.FlandreDevilsGold.\u206B\u206F\u202A\u200F\u200D\u206E\u202D\u200E\u206A\u200C\u202A\u206F\u206D\u206F\u202B\u206D\u202B\u202A\u200D\u206F\u206C\u206E\u200B\u206E\u202E\u200D\u202B\u206B\u200F\u202C\u200E\u202B\u206D\u202C\u202A\u202E\u202A\u200B\u206B\u206C\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.\u206B\u202D\u202C\u202B\u200C\u202B\u206B\u206A\u200F\u202E\u206E\u200D\u202B\u200E\u200E\u202B\u200D\u206B\u206A\u202B\u200E\u206B\u206D\u206F\u200D\u202A\u206F\u206C\u206C\u200F\u206C\u202A\u206C\u206D\u200C\u200F\u202E\u202A\u200E\u200F\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
				base.ReactBattleEvent<DieEventArgs>(FlandreDevilsGoldDef.FlandreDevilsGold.\u200D\u206C\u200B\u202B\u206F\u202A\u202A\u202A\u200C\u206D\u202D\u200F\u202A\u202B\u206A\u200D\u200F\u202A\u206C\u200D\u200D\u200B\u206B\u202C\u200D\u202E\u200D\u202D\u206F\u200D\u206F\u206E\u202A\u202D\u200C\u206F\u202A\u202E\u200B\u200C\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.\u206B\u202D\u202C\u202B\u200C\u202B\u206B\u206A\u200F\u202E\u206E\u200D\u202B\u200E\u200E\u202B\u200D\u206B\u206A\u202B\u200E\u206B\u206D\u206F\u200D\u202A\u206F\u206C\u206C\u200F\u206C\u202A\u206C\u206D\u200C\u200F\u202E\u202A\u200E\u200F\u202E(this)), new EventSequencedReactor<DieEventArgs>(this.OnEnemyDied));
			}

			private void OnEnemyStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				FlandreRuinSeDef.FlandreRuinSe flandreRuinSe = FlandreDevilsGoldDef.FlandreDevilsGold.\u200E\u202C\u202E\u206A\u200F\u206B\u206F\u206B\u200E\u202D\u206C\u200B\u206A\u206A\u202D\u202C\u200F\u206C\u206D\u206E\u202C\u206B\u206C\u202A\u206A\u206A\u202A\u200F\u200F\u206E\u206B\u202E\u200E\u200B\u202E\u200C\u202C\u202B\u200F\u202C\u202E(args) as FlandreRuinSeDef.FlandreRuinSe;
				if (flandreRuinSe != null)
				{
					for (;;)
					{
						IL_000F:
						int num = -1258644340;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-(~num2) * -1245736729) ^ -885532111)) % 4U)
							{
							case 1U:
							{
								FlandreRuinSeDef.FlandreRuinSe flandreRuinSe2 = flandreRuinSe;
								FlandreDevilsGoldDef.FlandreDevilsGold.\u200C\u200B\u200E\u202C\u200C\u206E\u202B\u200B\u200B\u206B\u200D\u206C\u200D\u202C\u200C\u202A\u202D\u206F\u200F\u200E\u200C\u202B\u202E\u206C\u202D\u202D\u200E\u202A\u202D\u206E\u206B\u200B\u202D\u200E\u206E\u206D\u200E\u200B\u202E\u200F\u202E(flandreRuinSe2, FlandreDevilsGoldDef.FlandreDevilsGold.\u200E\u202B\u200E\u206C\u200E\u202E\u202B\u200F\u206A\u200D\u202C\u206F\u202D\u200C\u202D\u202B\u200B\u202E\u206C\u202B\u206A\u200E\u200B\u200F\u202C\u206F\u206A\u206C\u202B\u206C\u206C\u200B\u202E\u200E\u202A\u200C\u202D\u206F\u200B\u202D\u202E(flandreRuinSe2) + FlandreDevilsGoldDef.FlandreDevilsGold.\u206F\u202B\u206B\u206F\u200D\u200E\u206C\u200E\u202B\u202B\u200F\u202D\u200C\u206A\u202C\u206B\u200C\u206E\u206F\u206D\u200F\u202B\u200D\u206E\u202B\u206E\u206E\u202C\u206E\u200D\u200B\u202D\u200B\u206B\u206D\u206C\u202B\u206B\u202D\u202C\u202E(this));
								num = (int)((num3 * 1920682620U) ^ 140095326U);
								continue;
							}
							case 2U:
								this.\u202B\u200D\u202E\u202B\u202D\u202C\u202D\u200D\u206B\u202C\u202B\u200D\u200F\u200F\u206E\u200C\u200D\u202B\u200D\u200B\u202B\u200F\u200D\u202A\u202E\u202B\u206E\u200E\u200C\u200B\u206A\u206A\u202C\u202D\u206E\u202D\u200F\u202E\u206E\u206F\u202E();
								num = (int)((num3 * 3640405257U) ^ 1826594457U);
								continue;
							case 3U:
								goto IL_000F;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.HandleBattleEvent<StatusEffectApplyEventArgs>(FlandreDevilsGoldDef.FlandreDevilsGold.\u202E\u202E\u200D\u206F\u206E\u206F\u200F\u206C\u206C\u200D\u200D\u206D\u202B\u202C\u202A\u206F\u200B\u202C\u202D\u200E\u202C\u206A\u200D\u202C\u202D\u202A\u206E\u200D\u200E\u202E\u200F\u206C\u200C\u202A\u206C\u200D\u206D\u202B\u206B\u202B\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.\u202C\u202A\u202B\u206F\u206B\u206E\u202B\u206C\u200B\u200F\u202C\u202B\u206D\u202A\u200E\u206F\u200C\u200B\u202B\u202C\u200D\u202D\u206A\u200E\u202D\u202A\u202B\u200C\u202A\u202D\u206C\u202B\u200E\u206B\u202C\u206B\u206E\u206A\u200E\u200F\u202E(args)), new GameEventHandler<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
			}

			private IEnumerable<BattleAction> OnEnemyDied(DieEventArgs args)
			{
				FlandreDevilsGoldDef.FlandreDevilsGold.<OnEnemyDied>d__3 <OnEnemyDied>d__ = new FlandreDevilsGoldDef.FlandreDevilsGold.<OnEnemyDied>d__3(-2);
				<OnEnemyDied>d__.<>4__this = this;
				<OnEnemyDied>d__.<>3__args = args;
				return <OnEnemyDied>d__;
			}

			static BattleController \u206B\u202D\u202C\u202B\u200C\u202B\u206B\u206A\u200F\u202E\u206E\u200D\u202B\u200E\u200E\u202B\u200D\u206B\u206A\u202B\u200E\u206B\u206D\u206F\u200D\u202A\u206F\u206C\u206C\u200F\u206C\u202A\u206C\u206D\u200C\u200F\u202E\u202A\u200E\u200F\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u200E\u200D\u206E\u202A\u200D\u200F\u202B\u202C\u200D\u206E\u206A\u206C\u206B\u200F\u202B\u206D\u206E\u200B\u202C\u202A\u202B\u202E\u200C\u206C\u202E\u206C\u202C\u206E\u202D\u206D\u202B\u202D\u206F\u202D\u200E\u200F\u200E\u202B\u206E\u200F\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u202E\u202E\u200D\u206F\u206E\u206F\u200F\u206C\u206C\u200D\u200D\u206D\u202B\u202C\u202A\u206F\u200B\u202C\u202D\u200E\u202C\u206A\u200D\u202C\u202D\u202A\u206E\u200D\u200E\u202E\u200F\u206C\u200C\u202A\u206C\u200D\u206D\u202B\u206B\u202B\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			static bool \u202B\u200F\u200B\u202A\u202E\u202D\u206D\u202C\u206A\u200C\u206A\u202C\u206C\u206B\u206A\u202D\u202C\u200E\u202B\u206E\u206F\u202B\u206B\u202D\u206D\u202E\u206B\u202B\u206D\u206C\u206F\u202C\u206A\u200B\u200F\u200E\u200C\u206D\u202B\u206A\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u206F\u206D\u200C\u200F\u202C\u200C\u202D\u202D\u206D\u200B\u206D\u206F\u200C\u202E\u206F\u202A\u200C\u206A\u206E\u206F\u200E\u200F\u206F\u206A\u206B\u200B\u206C\u200E\u202E\u200F\u206D\u200B\u200B\u202E\u202E\u206A\u200B\u206D\u200E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u206B\u206F\u202A\u200F\u200D\u206E\u202D\u200E\u206A\u200C\u202A\u206F\u206D\u206F\u202B\u206D\u202B\u202A\u200D\u206F\u206C\u206E\u200B\u206E\u202E\u200D\u202B\u206B\u200F\u202C\u200E\u202B\u206D\u202C\u202A\u202E\u202A\u200B\u206B\u206C\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static GameEvent<DieEventArgs> \u200D\u206C\u200B\u202B\u206F\u202A\u202A\u202A\u200C\u206D\u202D\u200F\u202A\u202B\u206A\u200D\u200F\u202A\u206C\u200D\u200D\u200B\u206B\u202C\u200D\u202E\u200D\u202D\u206F\u200D\u206F\u206E\u202A\u202D\u200C\u206F\u202A\u202E\u200B\u200C\u202E(BattleController A_0)
			{
				return A_0.EnemyDied;
			}

			static StatusEffect \u200E\u202C\u202E\u206A\u200F\u206B\u206F\u206B\u200E\u202D\u206C\u200B\u206A\u206A\u202D\u202C\u200F\u206C\u206D\u206E\u202C\u206B\u206C\u202A\u206A\u206A\u202A\u200F\u200F\u206E\u206B\u202E\u200E\u200B\u202E\u200C\u202C\u202B\u200F\u202C\u202E(StatusEffectApplyEventArgs A_0)
			{
				return A_0.Effect;
			}

			void \u202B\u200D\u202E\u202B\u202D\u202C\u202D\u200D\u206B\u202C\u202B\u200D\u200F\u200F\u206E\u200C\u200D\u202B\u200D\u200B\u202B\u200F\u200D\u202A\u202E\u202B\u206E\u200E\u200C\u200B\u206A\u206A\u202C\u202D\u206E\u202D\u200F\u202E\u206E\u206F\u202E()
			{
				base.NotifyActivating();
			}

			static int \u200E\u202B\u200E\u206C\u200E\u202E\u202B\u200F\u206A\u200D\u202C\u206F\u202D\u200C\u202D\u202B\u200B\u202E\u206C\u202B\u206A\u200E\u200B\u200F\u202C\u206F\u206A\u206C\u202B\u206C\u206C\u200B\u202E\u200E\u202A\u200C\u202D\u206F\u200B\u202D\u202E(StatusEffect A_0)
			{
				return A_0.Level;
			}

			static int \u206F\u202B\u206B\u206F\u200D\u200E\u206C\u200E\u202B\u202B\u200F\u202D\u200C\u206A\u202C\u206B\u200C\u206E\u206F\u206D\u200F\u202B\u200D\u206E\u202B\u206E\u206E\u202C\u206E\u200D\u200B\u202D\u200B\u206B\u206D\u206C\u202B\u206B\u202D\u202C\u202E(Exhibit A_0)
			{
				return A_0.Value1;
			}

			static void \u200C\u200B\u200E\u202C\u200C\u206E\u202B\u200B\u200B\u206B\u200D\u206C\u200D\u202C\u200C\u202A\u202D\u206F\u200F\u200E\u200C\u202B\u202E\u206C\u202D\u202D\u200E\u202A\u202D\u206E\u206B\u200B\u202D\u200E\u206E\u206D\u200E\u200B\u202E\u200F\u202E(StatusEffect A_0, int A_1)
			{
				A_0.Level = A_1;
			}

			static Unit \u202C\u202A\u202B\u206F\u206B\u206E\u202B\u206C\u200B\u200F\u202C\u202B\u206D\u202A\u200E\u206F\u200C\u200B\u202B\u202C\u200D\u202D\u206A\u200E\u202D\u202A\u202B\u200C\u202A\u202D\u206C\u202B\u200E\u206B\u202C\u206B\u206E\u206A\u200E\u200F\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			private class FlandreDevilsGoldWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.\u200D\u200E\u206A\u202B\u206B\u200C\u206F\u202E\u206F\u206B\u202C\u200F\u202A\u202A\u202D\u202E\u206D\u202B\u200F\u200C\u200E\u202B\u206A\u200B\u202B\u206A\u206A\u202A\u202E\u206B\u200B\u206F\u202E\u200C\u206D\u200E\u206C\u206A\u200C\u202C\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.\u202C\u202A\u202D\u200B\u202C\u200F\u206B\u200F\u200F\u200B\u206F\u200B\u206C\u200F\u206E\u206B\u206F\u206B\u206D\u206A\u202D\u200F\u206E\u200F\u200C\u202C\u206B\u206C\u202E\u202B\u206D\u206B\u202D\u200E\u206F\u206C\u202B\u202C\u200E\u202D\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.\u200D\u206D\u206A\u206B\u202A\u200E\u202B\u200E\u206F\u200F\u202D\u200D\u206E\u200F\u206D\u202B\u206E\u200C\u206F\u200C\u206F\u202D\u206D\u200C\u202C\u206F\u202E\u206F\u200C\u200B\u200F\u200D\u202D\u202A\u200F\u200D\u206F\u206D\u206F\u206B\u202E(gameRun)), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810)))
					{
						for (;;)
						{
							IL_001E:
							int num = -2059110963;
							for (;;)
							{
								int num2 = num;
								switch (-(~(~(num2 ^ ~(-(--1047312803))))) % 4)
								{
								case 0:
									goto IL_0089;
								case 1:
									num = ((!FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.\u206B\u200C\u206A\u206C\u202B\u206C\u202E\u206A\u206C\u200D\u200F\u200E\u200F\u202A\u202B\u202A\u206A\u206B\u206E\u202A\u206A\u206C\u206F\u200E\u202B\u202A\u200E\u200C\u206C\u202B\u202E\u206F\u202C\u206A\u202B\u200B\u200F\u202A\u202A\u202E\u202E(gameRun).Any(delegate(Card c)
									{
										if (!FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.<>c.\u200D\u200D\u206D\u200F\u206E\u200F\u206E\u206A\u202A\u200D\u202D\u206C\u200F\u202D\u200C\u200B\u206B\u206E\u202E\u200F\u200C\u200D\u206D\u200F\u200C\u206A\u202C\u202D\u206F\u206F\u206F\u200F\u206D\u200F\u202A\u206B\u206F\u200B\u206D\u200F\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.<>c.\u206F\u202A\u206B\u200E\u200C\u200D\u200B\u202D\u200B\u206F\u202B\u202B\u206D\u206F\u202A\u202B\u202E\u202E\u206E\u202C\u200E\u200F\u200B\u202A\u206F\u200B\u206D\u206F\u200F\u202E\u202A\u200E\u200E\u202C\u202E\u206B\u200D\u200F\u202D\u206C\u202E(c)).Contains(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1596248316)))
										{
											for (;;)
											{
												int num3 = 2047707003;
												switch ((num3 - (-(~1400491598) - (-1201887374 + 172936802) * 774699425) + (269650277 * -1156399950 - (-34034285 ^ -1917049761)) + (415091936 ^ -1811958004) + 811334546) % 3)
												{
												case 0:
													continue;
												case 2:
													goto IL_0083;
												}
												break;
											}
											return true;
											IL_0083:
											return FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.<>c.\u202B\u202B\u206A\u206B\u200B\u206D\u206E\u202C\u206D\u206D\u202A\u200C\u202B\u200B\u202A\u202D\u206F\u202A\u202E\u206E\u202D\u200D\u200B\u202E\u202D\u202C\u206A\u206A\u202D\u200D\u206F\u200E\u206B\u206E\u202B\u206C\u202A\u206C\u200F\u206E\u202E(FlandreDevilsGoldDef.FlandreDevilsGold.FlandreDevilsGoldWeighter.<>c.\u206F\u202A\u206B\u200E\u200C\u200D\u200B\u202D\u200B\u206F\u202B\u202B\u206D\u206F\u202A\u202B\u202E\u202E\u206E\u202C\u200E\u200F\u200B\u202A\u206F\u200B\u206D\u206F\u200F\u202E\u202A\u200E\u200E\u202C\u202E\u206B\u200D\u200F\u202D\u206C\u202E(c)).Contains(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1681599054));
										}
										return true;
									})) ? (-776946350) : (-1510825929));
									continue;
								case 2:
									goto IL_001E;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 1.15f;
					}
					IL_0089:
					return 0f;
				}

				static PlayerUnit \u200D\u206D\u206A\u206B\u202A\u200E\u202B\u200E\u206F\u200F\u202D\u200D\u206E\u200F\u206D\u202B\u206E\u200C\u206F\u200C\u206F\u202D\u206D\u200C\u202C\u206F\u202E\u206F\u200C\u200B\u200F\u200D\u202D\u202A\u200F\u200D\u206F\u206D\u206F\u206B\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u202C\u202A\u202D\u200B\u202C\u200F\u206B\u200F\u200F\u200B\u206F\u200B\u206C\u200F\u206E\u206B\u206F\u206B\u206D\u206A\u202D\u200F\u206E\u200F\u200C\u202C\u206B\u206C\u202E\u202B\u206D\u206B\u202D\u200E\u206F\u206C\u202B\u202C\u200E\u202D\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u200D\u200E\u206A\u202B\u206B\u200C\u206F\u202E\u206F\u206B\u202C\u200F\u202A\u202A\u202D\u202E\u206D\u202B\u200F\u200C\u200E\u202B\u206A\u200B\u202B\u206A\u206A\u202A\u202E\u206B\u200B\u206F\u202E\u200C\u206D\u200E\u206C\u206A\u200C\u202C\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}

				static IReadOnlyList<Card> \u206B\u200C\u206A\u206C\u202B\u206C\u202E\u206A\u206C\u200D\u200F\u200E\u200F\u202A\u202B\u202A\u206A\u206B\u206E\u202A\u206A\u206C\u206F\u200E\u202B\u202A\u200E\u200C\u206C\u202B\u202E\u206F\u202C\u206A\u202B\u200B\u200F\u202A\u202A\u202E\u202E(GameRunController A_0)
				{
					return A_0.BaseDeck;
				}
			}
		}
	}
}
