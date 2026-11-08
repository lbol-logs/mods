using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.Cards;
using JetBrains.Annotations;
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
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class FlandreTornTeddyBearDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-446384888);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreTornTeddyBearDef.\u202A\u206A\u206A\u202C\u202D\u206B\u200F\u202C\u206C\u200C\u206C\u200E\u200C\u202B\u202E\u202E\u202D\u202B\u202C\u202D\u202C\u206B\u206E\u202B\u202B\u202A\u200C\u206F\u202D\u202E\u200C\u206B\u206F\u202E\u206A\u202C\u206F\u206F\u202E\u206E\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			FlandreTornTeddyBearDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = -1310397278;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(num2 ^ -((-1237737002 + 2073764131) ^ (166722006 * 1308561869))) + ~-625226427))) % 4U)
					{
					case 0U:
						folder = "";
						num = (int)((num3 * 3724689599U) ^ 311608573U);
						continue;
					case 1U:
						<>4__this = this;
						num = (int)((num3 * 2838545777U) ^ 3307566454U);
						continue;
					case 3U:
						goto IL_0006;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = FlandreTornTeddyBearDef.\u202E\u200C\u206C\u202C\u206B\u200C\u200B\u200C\u202B\u206B\u202A\u200F\u202D\u202C\u200F\u200E\u200F\u202D\u202E\u200C\u200C\u206F\u200E\u200C\u202B\u202C\u206A\u202D\u206B\u206D\u202B\u202C\u200F\u200D\u200F\u206B\u206A\u202D\u206E\u200E\u202E();
			Func<string, Sprite> func = (string s) => FlandreTornTeddyBearDef.<>c__DisplayClass2_0.\u202D\u202A\u206D\u202B\u200C\u206E\u200C\u206B\u202E\u200E\u200B\u200F\u206B\u202B\u200E\u202E\u200F\u206C\u200F\u206C\u206D\u202D\u206F\u200B\u206A\u202E\u202D\u206C\u202B\u202D\u202B\u202E\u206F\u200D\u202B\u206D\u206E\u206C\u200E\u206B\u202E(FlandreTornTeddyBearDef.<>c__DisplayClass2_0.\u206C\u200E\u200F\u206A\u200B\u206D\u202D\u206F\u200E\u202D\u202A\u202A\u200D\u202D\u206C\u202E\u200F\u200B\u200B\u200E\u206F\u206E\u206C\u206A\u202B\u200C\u206D\u200D\u202D\u202A\u200E\u202B\u206F\u202D\u200F\u200B\u200F\u206F\u200B\u202E\u202E(folder, FlandreTornTeddyBearDef.<>c__DisplayClass2_0.\u202E\u202B\u206E\u200F\u200F\u202A\u202E\u202B\u200D\u202C\u200B\u202D\u206D\u206C\u206A\u200B\u206F\u200D\u202D\u206D\u206A\u202B\u202B\u206A\u202A\u202E\u206B\u200D\u202D\u200E\u202A\u202C\u202C\u206D\u202E\u206F\u202C\u200D\u202A\u200F\u202E(<>4__this), s, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreTornTeddyBearDef.\u200F\u202B\u202B\u202C\u202C\u206F\u202A\u202D\u206B\u202C\u202B\u206E\u202D\u202C\u202D\u206C\u200D\u200C\u206E\u202E\u202E\u206C\u206D\u202A\u200C\u206C\u206C\u206F\u206D\u202C\u206B\u202D\u200B\u206E\u200B\u200D\u202E\u200D\u200C\u206C\u202E(BepinexPlugin.sequenceTable, FlandreTornTeddyBearDef.\u202D\u202D\u200E\u200B\u200B\u202E\u200B\u206F\u206C\u202D\u200D\u206E\u200F\u200E\u206F\u202A\u206E\u202A\u202D\u202B\u206A\u200D\u200F\u206D\u202D\u206D\u206A\u200C\u206A\u206A\u202A\u200C\u206D\u200E\u200E\u202D\u202E\u206E\u200F\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, true, AppearanceType.Anywhere, "", ExhibitLosableType.Losable, Rarity.Uncommon, new int?(2), null, null, null, null, null, 0, false, null, Keyword.None, new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(536664057),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1244415753)
			}, new List<string>());
		}

		static BatchLocalization \u202A\u206A\u206A\u202C\u202D\u206B\u200F\u202C\u206C\u200C\u206C\u200E\u200C\u202B\u202E\u202E\u202D\u202B\u202C\u202D\u202C\u206B\u206E\u202B\u202B\u202A\u200C\u206F\u202D\u202E\u200C\u206B\u206F\u202E\u206A\u202C\u206F\u206F\u202E\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u202E\u200C\u206C\u202C\u206B\u200C\u200B\u200C\u202B\u206B\u202A\u200F\u202D\u202C\u200F\u200E\u200F\u202D\u202E\u200C\u200C\u206F\u200E\u200C\u202B\u202C\u206A\u202D\u206B\u206D\u202B\u202C\u200F\u200D\u200F\u206B\u206A\u202D\u206E\u200E\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u202D\u202D\u200E\u200B\u200B\u202E\u200B\u206F\u206C\u202D\u200D\u206E\u200F\u200E\u206F\u202A\u206E\u202A\u202D\u202B\u206A\u200D\u200F\u206D\u202D\u206D\u206A\u200C\u206A\u206A\u202A\u200C\u206D\u200E\u200E\u202D\u202E\u206E\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u202B\u202B\u202C\u202C\u206F\u202A\u202D\u206B\u202C\u202B\u206E\u202D\u202C\u202D\u206C\u200D\u200C\u206E\u202E\u202E\u206C\u206D\u202A\u200C\u206C\u206C\u206F\u206D\u202C\u206B\u202D\u200B\u206E\u200B\u200D\u202E\u200D\u200C\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreTornTeddyBearDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(FlandreTornTeddyBearDef.FlandreTornTeddyBear.FlandreTornTeddyBearWeighter))]
		public sealed class FlandreTornTeddyBear : Exhibit
		{
			public float Value4
			{
				get
				{
					if (!BepinexPlugin.AyaPhantasmMode.Value)
					{
						for (;;)
						{
							int num = -389393694;
							switch (((num ^ ((-1753688941 ^ (148094605 - -238586966)) - (1322217612 + ~-559816988))) * 1632780793 - (593224904 - 673284333)) * 762115577 % 3)
							{
							case 1:
								goto IL_0062;
							case 2:
								continue;
							}
							break;
						}
						goto IL_0077;
						IL_0062:
						return 1f;
					}
					IL_0077:
					return 0.5f;
				}
			}

			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<GameEventArgs>(FlandreTornTeddyBearDef.FlandreTornTeddyBear.\u202C\u206C\u200E\u202B\u206A\u206C\u200D\u202C\u206A\u206A\u202D\u202A\u202C\u206C\u202D\u202A\u202C\u202A\u206E\u202C\u206D\u200E\u206A\u206C\u206F\u206D\u202B\u200C\u206C\u202E\u206F\u206B\u206C\u200B\u202B\u202A\u206C\u202A\u206C\u202B\u202E(FlandreTornTeddyBearDef.FlandreTornTeddyBear.\u200F\u200E\u206B\u202D\u202B\u206B\u200C\u206C\u202B\u206A\u202A\u202B\u202E\u200C\u202C\u206D\u202C\u206D\u202C\u202D\u200D\u206B\u206C\u202B\u200E\u206F\u202B\u202A\u200E\u200B\u202D\u206B\u206D\u202A\u200C\u206A\u206B\u200E\u206F\u206A\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
			{
				FlandreTornTeddyBearDef.FlandreTornTeddyBear.<OnBattleStarted>d__3 <OnBattleStarted>d__ = new FlandreTornTeddyBearDef.FlandreTornTeddyBear.<OnBattleStarted>d__3(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			static BattleController \u200F\u200E\u206B\u202D\u202B\u206B\u200C\u206C\u202B\u206A\u202A\u202B\u202E\u200C\u202C\u206D\u202C\u206D\u202C\u202D\u200D\u206B\u206C\u202B\u200E\u206F\u202B\u202A\u200E\u200B\u202D\u206B\u206D\u202A\u200C\u206A\u206B\u200E\u206F\u206A\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u202C\u206C\u200E\u202B\u206A\u206C\u200D\u202C\u206A\u206A\u202D\u202A\u202C\u206C\u202D\u202A\u202C\u202A\u206E\u202C\u206D\u200E\u206A\u206C\u206F\u206D\u202B\u200C\u206C\u202E\u206F\u206B\u206C\u200B\u202B\u202A\u206C\u202A\u206C\u202B\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			private class FlandreTornTeddyBearWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (FlandreTornTeddyBearDef.FlandreTornTeddyBear.FlandreTornTeddyBearWeighter.\u202A\u202B\u202D\u200D\u200C\u202B\u202C\u206C\u202B\u202E\u206E\u202D\u200D\u200B\u200B\u200E\u206F\u202A\u200C\u200C\u206C\u206A\u206D\u206C\u206D\u200C\u206A\u202E\u202C\u202A\u202C\u202D\u206D\u200E\u202E\u206A\u200C\u200E\u206A\u202E(FlandreTornTeddyBearDef.FlandreTornTeddyBear.FlandreTornTeddyBearWeighter.\u200F\u200D\u206E\u202A\u206E\u206F\u200E\u202D\u200F\u200D\u206F\u200E\u200F\u200F\u202D\u206A\u206F\u202D\u206C\u202C\u202B\u206A\u206C\u206A\u206E\u200B\u206D\u206B\u202C\u206F\u206F\u206B\u202D\u200B\u200B\u200F\u206C\u206D\u206C\u202E(FlandreTornTeddyBearDef.FlandreTornTeddyBear.FlandreTornTeddyBearWeighter.\u202D\u200E\u202D\u202D\u202B\u202B\u206F\u200E\u200E\u206F\u202D\u202A\u206B\u200C\u200F\u206A\u200F\u202C\u200C\u200F\u206F\u202D\u206B\u206A\u206A\u206D\u202A\u200C\u202E\u206D\u202C\u202A\u200E\u206B\u206C\u200D\u200B\u202B\u206E\u200F\u202E(gameRun)), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588)))
					{
						for (;;)
						{
							IL_0021:
							int num = -1600777225;
							for (;;)
							{
								int num2 = num;
								switch (-(~(num2 - (--35755182 - (864030728 ^ 35507785 ^ (-1893764663 * 348149641))) + -1256052975 * (387009925 * 813404911))) % 4)
								{
								case 0:
									goto IL_0021;
								case 1:
									num = ((!FlandreTornTeddyBearDef.FlandreTornTeddyBear.FlandreTornTeddyBearWeighter.\u206D\u202B\u200B\u200E\u206D\u206E\u206C\u200E\u202C\u202B\u202D\u202B\u200B\u206F\u206F\u202E\u202A\u200D\u206D\u202D\u200F\u200D\u202D\u202E\u200D\u206F\u200B\u202E\u200C\u206D\u206F\u202E\u200F\u206C\u200B\u206F\u206C\u202C\u200F\u202E\u202E(gameRun).Any(delegate(Card c)
									{
										FlandreCard flandreCard = c as FlandreCard;
										for (;;)
										{
											IL_0007:
											int num3 = 563466332;
											for (;;)
											{
												int num4 = num3;
												uint num5;
												switch ((num5 = (uint)(~(uint)(809997574 + 346347001 - ~num4 * -651505))) % 4U)
												{
												case 0U:
													goto IL_0059;
												case 1U:
													num3 = (int)(((flandreCard == null) ? 39449233U : 4005700255U) ^ (num5 * 2553967852U));
													continue;
												case 3U:
													goto IL_0007;
												}
												goto Block_1;
											}
										}
										Block_1:
										return false;
										IL_0059:
										return flandreCard.IsBloodlust;
									})) ? (-1293564288) : 1460922609);
									continue;
								case 2:
									goto IL_00B6;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 1.15f;
					}
					IL_00B6:
					return 0f;
				}

				static PlayerUnit \u202D\u200E\u202D\u202D\u202B\u202B\u206F\u200E\u200E\u206F\u202D\u202A\u206B\u200C\u200F\u206A\u200F\u202C\u200C\u200F\u206F\u202D\u206B\u206A\u206A\u206D\u202A\u200C\u202E\u206D\u202C\u202A\u200E\u206B\u206C\u200D\u200B\u202B\u206E\u200F\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u200F\u200D\u206E\u202A\u206E\u206F\u200E\u202D\u200F\u200D\u206F\u200E\u200F\u200F\u202D\u206A\u206F\u202D\u206C\u202C\u202B\u206A\u206C\u206A\u206E\u200B\u206D\u206B\u202C\u206F\u206F\u206B\u202D\u200B\u200B\u200F\u206C\u206D\u206C\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u202A\u202B\u202D\u200D\u200C\u202B\u202C\u206C\u202B\u202E\u206E\u202D\u200D\u200B\u200B\u200E\u206F\u202A\u200C\u200C\u206C\u206A\u206D\u206C\u206D\u200C\u206A\u202E\u202C\u202A\u202C\u202D\u206D\u200E\u202E\u206A\u200C\u200E\u206A\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}

				static IReadOnlyList<Card> \u206D\u202B\u200B\u200E\u206D\u206E\u206C\u200E\u202C\u202B\u202D\u202B\u200B\u206F\u206F\u202E\u202A\u200D\u206D\u202D\u200F\u200D\u202D\u202E\u200D\u206F\u200B\u202E\u200C\u206D\u206F\u202E\u200F\u206C\u200B\u206F\u206C\u202C\u200F\u202E\u202E(GameRunController A_0)
				{
					return A_0.BaseDeck;
				}
			}
		}
	}
}
