using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class FlandreRDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1540742352);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreRDef.\u206E\u206A\u202B\u206B\u202A\u200C\u202D\u206A\u202C\u200B\u200F\u206C\u200D\u202E\u206A\u206A\u200D\u202D\u200E\u200F\u202D\u200E\u206B\u202A\u202C\u200E\u206C\u202D\u206C\u206B\u200E\u206D\u206B\u206E\u202B\u200D\u202B\u206A\u202C\u200F\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			FlandreRDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = -710119641;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(num2 * 1265689839) * -1842817627)) % 4U)
					{
					case 0U:
						goto IL_0006;
					case 2U:
						folder = "";
						num = (int)((num3 * 4206610149U) ^ 1778928491U);
						continue;
					case 3U:
						<>4__this = this;
						num = (int)((num3 * 2341095520U) ^ 2041622934U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = FlandreRDef.\u206A\u202B\u200D\u202B\u202B\u202B\u206F\u206B\u206D\u206F\u206E\u202A\u200E\u206D\u206A\u206E\u202E\u206D\u206E\u206A\u200C\u200D\u200F\u200B\u202A\u206C\u206C\u202E\u206C\u206B\u202A\u200E\u202B\u200F\u202A\u206D\u202A\u202D\u206E\u206B\u202E();
			Func<string, Sprite> func = (string s) => FlandreRDef.<>c__DisplayClass2_0.\u206F\u206C\u206E\u206D\u200E\u202A\u202B\u200E\u200C\u206A\u206D\u206F\u206B\u202B\u200D\u206A\u206C\u206A\u202E\u202A\u200B\u202D\u200B\u200F\u202C\u202C\u206E\u206C\u200C\u202A\u202C\u206E\u206D\u206D\u206B\u200F\u206D\u202A\u200D\u200C\u202E(FlandreRDef.<>c__DisplayClass2_0.\u200E\u200B\u206C\u206D\u200F\u200F\u202D\u200E\u202A\u200B\u202C\u206E\u202D\u206E\u206C\u206B\u202C\u206D\u202C\u202B\u202D\u200C\u200F\u206E\u202A\u206E\u200D\u202A\u200F\u200F\u200F\u206A\u200E\u200C\u206E\u200E\u202C\u200E\u202B\u206F\u202E(folder, FlandreRDef.<>c__DisplayClass2_0.\u206B\u206B\u200B\u206D\u200C\u200C\u202A\u206E\u200D\u206B\u202C\u206C\u206D\u200C\u206B\u200F\u202C\u200E\u200C\u202D\u200F\u206D\u202D\u206E\u206E\u202A\u202D\u206E\u206B\u206C\u200B\u206F\u200D\u202A\u206F\u200B\u202D\u200F\u202E(<>4__this), s, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreRDef.\u200E\u206E\u200B\u206D\u206C\u202B\u200C\u202D\u202D\u200D\u200B\u206C\u200B\u200C\u200B\u202D\u200F\u200C\u206C\u200C\u202C\u202D\u200B\u202C\u200B\u200D\u206C\u200F\u200C\u206D\u200D\u206D\u206E\u206F\u200B\u206D\u206C\u206E\u206D\u206A\u202E(BepinexPlugin.sequenceTable, FlandreRDef.\u206C\u200F\u200E\u202B\u200E\u206B\u206D\u200E\u200F\u202B\u202A\u202A\u206C\u200C\u206B\u200F\u200D\u202E\u202A\u200D\u202C\u202B\u200D\u200D\u206E\u202E\u206E\u200E\u206C\u206C\u200C\u200F\u200D\u200E\u200B\u200E\u202C\u202C\u206C\u200C\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, false, false, false, AppearanceType.Anywhere, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), ExhibitLosableType.DebutLosable, Rarity.Shining, null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			}), null, new ManaColor?(ManaColor.Red), 1, false, null, Keyword.Philosophy, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1625028300) }, new List<string>());
		}

		static BatchLocalization \u206E\u206A\u202B\u206B\u202A\u200C\u202D\u206A\u202C\u200B\u200F\u206C\u200D\u202E\u206A\u206A\u200D\u202D\u200E\u200F\u202D\u200E\u206B\u202A\u202C\u200E\u206C\u202D\u206C\u206B\u200E\u206D\u206B\u206E\u202B\u200D\u202B\u206A\u202C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u206A\u202B\u200D\u202B\u202B\u202B\u206F\u206B\u206D\u206F\u206E\u202A\u200E\u206D\u206A\u206E\u202E\u206D\u206E\u206A\u200C\u200D\u200F\u200B\u202A\u206C\u206C\u202E\u206C\u206B\u202A\u200E\u202B\u200F\u202A\u206D\u202A\u202D\u206E\u206B\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u206C\u200F\u200E\u202B\u200E\u206B\u206D\u200E\u200F\u202B\u202A\u202A\u206C\u200C\u206B\u200F\u200D\u202E\u202A\u200D\u202C\u202B\u200D\u200D\u206E\u202E\u206E\u200E\u206C\u206C\u200C\u200F\u200D\u200E\u200B\u200E\u202C\u202C\u206C\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u206E\u200B\u206D\u206C\u202B\u200C\u202D\u202D\u200D\u200B\u206C\u200B\u200C\u200B\u202D\u200F\u200C\u206C\u200C\u202C\u202D\u200B\u202C\u200B\u200D\u206C\u200F\u200C\u206D\u200D\u206D\u206E\u206F\u200B\u206D\u206C\u206E\u206D\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreRDef))]
		[UsedImplicitly]
		public sealed class FlandreR : ShiningExhibit
		{
			protected override void OnEnterBattle()
			{
				base.HandleBattleEvent<UnitEventArgs>(FlandreRDef.FlandreR.\u206E\u206F\u200F\u200C\u202E\u206E\u202E\u200E\u200E\u200B\u200B\u200D\u202A\u200E\u206B\u206A\u202A\u200D\u206B\u202C\u200D\u206B\u206D\u206C\u206C\u202C\u200D\u202C\u200F\u200B\u206A\u200E\u202B\u206C\u200D\u200F\u200D\u206F\u206C\u200D\u202E(FlandreRDef.FlandreR.\u206B\u200B\u200C\u202C\u202B\u206E\u206D\u206C\u200E\u206B\u202D\u200C\u202E\u202A\u206F\u202C\u206F\u206C\u202C\u202A\u200D\u202D\u206F\u202D\u206D\u206C\u200F\u200F\u200E\u200E\u206C\u202E\u200D\u206B\u206B\u206C\u200F\u200D\u206B\u202E(FlandreRDef.FlandreR.\u202D\u200E\u202A\u206B\u206F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u202C\u200F\u202D\u200B\u206F\u202C\u200E\u202C\u206B\u202A\u200E\u202B\u206B\u206B\u202A\u202D\u202A\u202D\u202C\u200E\u206E\u202D\u206F\u202B\u206A\u200D\u206E\u200D\u202E(this))), delegate(UnitEventArgs _)
				{
					FlandreRDef.FlandreR.\u200B\u200D\u206B\u200D\u200F\u200D\u202E\u206D\u200B\u200B\u206B\u206F\u200E\u200B\u206D\u202E\u206E\u200B\u206B\u200E\u200C\u206C\u202D\u206E\u206C\u206D\u200C\u206A\u206F\u200C\u200F\u200B\u206C\u200D\u206D\u202A\u202D\u200E\u206D\u206B\u202E(this, true);
				});
				IEnumerator<EnemyUnit> enumerator = FlandreRDef.FlandreR.\u202C\u206B\u200B\u200C\u200D\u206D\u206A\u206C\u200B\u206B\u200D\u202C\u202B\u206F\u202D\u202B\u202A\u202D\u200F\u202C\u206D\u200F\u202D\u206C\u206B\u200C\u202E\u206C\u202A\u202E\u206D\u202D\u206C\u202D\u200F\u200C\u206B\u200D\u206F\u202B\u202E(FlandreRDef.FlandreR.\u202D\u200E\u202A\u206B\u206F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u202C\u200F\u202D\u200B\u206F\u202C\u200E\u202C\u206B\u202A\u200E\u202B\u206B\u206B\u202A\u202D\u202A\u202D\u202C\u200E\u206E\u202D\u206F\u202B\u206A\u200D\u206E\u200D\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0094:
						int num = ((!FlandreRDef.FlandreR.\u206F\u202D\u202C\u206D\u200C\u206F\u202B\u206B\u200B\u200E\u202B\u200D\u206D\u206C\u200B\u202B\u200E\u202B\u202E\u200E\u200B\u206C\u206C\u206E\u200D\u200D\u206E\u206A\u206D\u202B\u206C\u206D\u206F\u202C\u202A\u200D\u202C\u202A\u202D\u206E\u202E(enumerator)) ? 619204468 : (-833059215));
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(-192106935 - ~(uint)(num2 + (329772617 * 1303820512 - (-744043122 - 1168063440) - ((1203300105 + -2076472191) ^ (-1175070988 - -2140128357))))))) % 5U)
							{
							case 0U:
								goto IL_0094;
							case 1U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num = 729598107;
								continue;
							}
							case 2U:
								num = -833059215;
								continue;
							case 4U:
							{
								EnemyUnit enemyUnit;
								base.ReactBattleEvent<StatusEffectApplyEventArgs>(FlandreRDef.FlandreR.\u200C\u202B\u202E\u200C\u206B\u200C\u200B\u202A\u202D\u206F\u202C\u202E\u206E\u206D\u202C\u202A\u206A\u200D\u202C\u200B\u206E\u200D\u202C\u202B\u206D\u200B\u206B\u200F\u206C\u200C\u206B\u206A\u200D\u200D\u206F\u200E\u200D\u202D\u206B\u202D\u202E(enemyUnit), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
								num = (int)((num3 * 3319024980U) ^ 3079393787U);
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
							IL_00ED:
							int num4 = 551161878;
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)(-(uint)(-192106935 - ~(uint)(num2 + (329772617 * 1303820512 - (-744043122 - 1168063440) - ((1203300105 + -2076472191) ^ (-1175070988 - -2140128357))))))) % 3U)
								{
								case 0U:
									goto IL_00ED;
								case 2U:
									FlandreRDef.FlandreR.\u206B\u202D\u206B\u202A\u202B\u200E\u206B\u206B\u200C\u202D\u202A\u200B\u206D\u202E\u206F\u202A\u200D\u200B\u206C\u206C\u206A\u202D\u202D\u200C\u200D\u202B\u202D\u202B\u200E\u206D\u202B\u202D\u206C\u206F\u206C\u206E\u206E\u206E\u200C\u206C\u202E(enumerator);
									num4 = (int)((num3 * 2772980060U) ^ 579658000U);
									continue;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(FlandreRDef.FlandreR.\u200C\u206D\u206E\u206E\u202C\u200F\u202B\u200F\u202B\u206F\u200F\u206B\u206A\u202D\u206C\u200D\u206F\u200D\u200B\u200E\u202C\u206E\u202E\u206A\u202B\u206A\u200F\u200E\u206A\u202E\u206A\u202A\u206A\u206E\u202B\u200D\u200D\u202B\u200C\u206A\u202E(FlandreRDef.FlandreR.\u202D\u200E\u202A\u206B\u206F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u202C\u200F\u202D\u200B\u206F\u202C\u200E\u202C\u206B\u202A\u200E\u202B\u206B\u206B\u202A\u202D\u202A\u202D\u202C\u200E\u206E\u202D\u206F\u202B\u206A\u200D\u206E\u200D\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned));
			}

			private IEnumerable<BattleAction> OnEnemyStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				FlandreRDef.FlandreR.<OnEnemyStatusEffectAdding>d__1 <OnEnemyStatusEffectAdding>d__ = new FlandreRDef.FlandreR.<OnEnemyStatusEffectAdding>d__1(-2);
				<OnEnemyStatusEffectAdding>d__.<>4__this = this;
				<OnEnemyStatusEffectAdding>d__.<>3__args = args;
				return <OnEnemyStatusEffectAdding>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactBattleEvent<StatusEffectApplyEventArgs>(FlandreRDef.FlandreR.\u200C\u202B\u202E\u200C\u206B\u200C\u200B\u202A\u202D\u206F\u202C\u202E\u206E\u206D\u202C\u202A\u206A\u200D\u202C\u200B\u206E\u200D\u202C\u202B\u206D\u200B\u206B\u200F\u206C\u200C\u206B\u206A\u200D\u200D\u206F\u200E\u200D\u202D\u206B\u202D\u202E(FlandreRDef.FlandreR.\u202A\u202A\u200B\u202B\u206C\u202C\u200B\u202C\u206D\u206E\u200E\u206A\u206F\u206F\u202B\u206A\u206E\u202A\u200C\u200B\u200E\u200E\u200F\u206D\u206E\u206D\u202E\u202D\u206D\u200E\u206D\u202E\u202A\u202B\u206E\u200D\u206B\u206B\u202D\u200C\u202E(args)), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdding));
			}

			protected override void OnLeaveBattle()
			{
				FlandreRDef.FlandreR.\u200B\u200D\u206B\u200D\u200F\u200D\u202E\u206D\u200B\u200B\u206B\u206F\u200E\u200B\u206D\u202E\u206E\u200B\u206B\u200E\u200C\u206C\u202D\u206E\u206C\u206D\u200C\u206A\u206F\u200C\u200F\u200B\u206C\u200D\u206D\u202A\u202D\u200E\u206D\u206B\u202E(this, false);
			}

			static BattleController \u202D\u200E\u202A\u206B\u206F\u200D\u206A\u202E\u206F\u200D\u206D\u202B\u202C\u200F\u202D\u200B\u206F\u202C\u200E\u202C\u206B\u202A\u200E\u202B\u206B\u206B\u202A\u202D\u202A\u202D\u202C\u200E\u206E\u202D\u206F\u202B\u206A\u200D\u206E\u200D\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206B\u200B\u200C\u202C\u202B\u206E\u206D\u206C\u200E\u206B\u202D\u200C\u202E\u202A\u206F\u202C\u206F\u206C\u202C\u202A\u200D\u202D\u206F\u202D\u206D\u206C\u200F\u200F\u200E\u200E\u206C\u202E\u200D\u206B\u206B\u206C\u200F\u200D\u206B\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u206E\u206F\u200F\u200C\u202E\u206E\u202E\u200E\u200E\u200B\u200B\u200D\u202A\u200E\u206B\u206A\u202A\u200D\u206B\u202C\u200D\u206B\u206D\u206C\u206C\u202C\u200D\u202C\u200F\u200B\u206A\u200E\u202B\u206C\u200D\u200F\u200D\u206F\u206C\u200D\u202E(Unit A_0)
			{
				return A_0.TurnStarting;
			}

			static IEnumerable<EnemyUnit> \u202C\u206B\u200B\u200C\u200D\u206D\u206A\u206C\u200B\u206B\u200D\u202C\u202B\u206F\u202D\u202B\u202A\u202D\u200F\u202C\u206D\u200F\u202D\u206C\u206B\u200C\u202E\u206C\u202A\u202E\u206D\u202D\u206C\u202D\u200F\u200C\u206B\u200D\u206F\u202B\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u200C\u202B\u202E\u200C\u206B\u200C\u200B\u202A\u202D\u206F\u202C\u202E\u206E\u206D\u202C\u202A\u206A\u200D\u202C\u200B\u206E\u200D\u202C\u202B\u206D\u200B\u206B\u200F\u206C\u200C\u206B\u206A\u200D\u200D\u206F\u200E\u200D\u202D\u206B\u202D\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			static bool \u206F\u202D\u202C\u206D\u200C\u206F\u202B\u206B\u200B\u200E\u202B\u200D\u206D\u206C\u200B\u202B\u200E\u202B\u202E\u200E\u200B\u206C\u206C\u206E\u200D\u200D\u206E\u206A\u206D\u202B\u206C\u206D\u206F\u202C\u202A\u200D\u202C\u202A\u202D\u206E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206B\u202D\u206B\u202A\u202B\u200E\u206B\u206B\u200C\u202D\u202A\u200B\u206D\u202E\u206F\u202A\u200D\u200B\u206C\u206C\u206A\u202D\u202D\u200C\u200D\u202B\u202D\u202B\u200E\u206D\u202B\u202D\u206C\u206F\u206C\u206E\u206E\u206E\u200C\u206C\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u200C\u206D\u206E\u206E\u202C\u200F\u202B\u200F\u202B\u206F\u200F\u206B\u206A\u202D\u206C\u200D\u206F\u200D\u200B\u200E\u202C\u206E\u202E\u206A\u202B\u206A\u200F\u200E\u206A\u202E\u206A\u202A\u206A\u206E\u202B\u200D\u200D\u202B\u200C\u206A\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static Unit \u202A\u202A\u200B\u202B\u206C\u202C\u200B\u202C\u206D\u206E\u200E\u206A\u206F\u206F\u202B\u206A\u206E\u202A\u200C\u200B\u200E\u200E\u200F\u206D\u206E\u206D\u202E\u202D\u206D\u200E\u206D\u202E\u202A\u202B\u206E\u200D\u206B\u206B\u202D\u200C\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			static void \u200B\u200D\u206B\u200D\u200F\u200D\u202E\u206D\u200B\u200B\u206B\u206F\u200E\u200B\u206D\u202E\u206E\u200B\u206B\u200E\u200C\u206C\u202D\u206E\u206C\u206D\u200C\u206A\u206F\u200C\u200F\u200B\u206C\u200D\u206D\u202A\u202D\u200E\u206D\u206B\u202E(Exhibit A_0, bool A_1)
			{
				A_0.Active = A_1;
			}
		}
	}
}
