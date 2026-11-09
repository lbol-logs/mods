using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
	public sealed class FlandreBrokenHornDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1036343142);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreBrokenHornDef.\u206D\u200C\u206E\u206C\u206D\u200C\u200E\u200F\u200C\u200D\u200E\u202B\u200C\u200F\u206A\u200D\u206D\u206B\u200E\u206F\u200E\u200B\u202A\u200D\u202C\u200F\u200E\u202D\u200D\u200D\u202E\u202D\u202A\u200F\u200E\u202E\u206F\u200E\u200F\u206E\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			for (;;)
			{
				IL_000D:
				int num = 1122808003;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((num2 - (((1206730455 * 660446325) ^ (1783757640 - 1065486509)) - -(~1475013959))) * 854455371 - -889830234) * -1493258085)) % 3U)
					{
					case 1U:
						folder = "";
						num = (int)((num3 * 1483633483U) ^ 1284356813U);
						continue;
					case 2U:
						goto IL_000D;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = FlandreBrokenHornDef.\u206F\u202B\u202C\u206E\u202D\u202A\u206C\u202A\u206C\u200E\u200D\u200C\u202E\u200E\u200E\u200F\u200B\u202B\u200B\u206E\u200D\u206D\u206F\u200F\u200F\u206D\u200C\u202A\u206F\u202E\u200B\u202A\u206D\u202A\u202B\u202D\u202B\u202A\u202A\u200D\u202E();
			Func<string, Sprite> func = (string s) => FlandreBrokenHornDef.<>c__DisplayClass2_0.\u200D\u200B\u202B\u200C\u206E\u206A\u206D\u202D\u202E\u206C\u206D\u206E\u200C\u202C\u202A\u202D\u202D\u202E\u202D\u206D\u202E\u200B\u206A\u200B\u206D\u200B\u206E\u202D\u206B\u202B\u206D\u202B\u200E\u200E\u206E\u200D\u206D\u202C\u200D\u200E\u202E(FlandreBrokenHornDef.<>c__DisplayClass2_0.\u200F\u206F\u200C\u202D\u202D\u200B\u206F\u202D\u200B\u202A\u202C\u200F\u206D\u200E\u200D\u200B\u200B\u206D\u206B\u202D\u200C\u202C\u206A\u206B\u206E\u200D\u200C\u200C\u200F\u200C\u206D\u200F\u202A\u202C\u206A\u202A\u202B\u206D\u202A\u202E(folder, FlandreBrokenHornDef.<>c__DisplayClass2_0.\u202E\u200B\u206C\u202A\u202D\u206C\u202C\u206A\u206E\u200B\u202A\u206F\u200C\u202A\u202E\u206F\u200F\u202B\u200D\u200C\u200C\u202C\u206A\u202B\u206E\u200C\u200F\u206D\u202C\u202B\u200E\u202A\u206E\u206F\u202C\u200E\u202A\u200D\u202C\u206F\u202E(this), s, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreBrokenHornDef.\u202E\u202A\u202A\u206C\u206B\u200D\u206A\u206C\u206F\u206E\u202E\u200B\u200E\u206D\u206F\u202C\u202D\u202D\u200E\u202B\u206D\u200F\u206F\u200B\u206D\u200E\u206A\u206E\u202D\u200B\u202B\u202D\u200B\u202D\u202E\u202A\u206F\u202E\u200D\u202D\u202E(BepinexPlugin.sequenceTable, FlandreBrokenHornDef.\u202B\u200D\u206F\u200D\u206D\u200C\u200F\u200B\u200F\u202A\u206C\u200C\u200D\u206C\u202A\u200B\u200C\u200E\u206D\u202C\u206F\u206C\u202C\u200C\u200F\u206B\u200C\u200F\u200D\u206C\u206F\u206A\u200C\u206D\u200C\u200C\u200F\u200D\u206A\u206D\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, true, AppearanceType.Anywhere, "", ExhibitLosableType.Losable, Rarity.Common, new int?(1), null, null, null, null, null, 0, false, null, Keyword.None, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1958891809) }, new List<string>());
		}

		static BatchLocalization \u206D\u200C\u206E\u206C\u206D\u200C\u200E\u200F\u200C\u200D\u200E\u202B\u200C\u200F\u206A\u200D\u206D\u206B\u200E\u206F\u200E\u200B\u202A\u200D\u202C\u200F\u200E\u202D\u200D\u200D\u202E\u202D\u202A\u200F\u200E\u202E\u206F\u200E\u200F\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u206F\u202B\u202C\u206E\u202D\u202A\u206C\u202A\u206C\u200E\u200D\u200C\u202E\u200E\u200E\u200F\u200B\u202B\u200B\u206E\u200D\u206D\u206F\u200F\u200F\u206D\u200C\u202A\u206F\u202E\u200B\u202A\u206D\u202A\u202B\u202D\u202B\u202A\u202A\u200D\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u202B\u200D\u206F\u200D\u206D\u200C\u200F\u200B\u200F\u202A\u206C\u200C\u200D\u206C\u202A\u200B\u200C\u200E\u206D\u202C\u206F\u206C\u202C\u200C\u200F\u206B\u200C\u200F\u200D\u206C\u206F\u206A\u200C\u206D\u200C\u200C\u200F\u200D\u206A\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u202A\u202A\u206C\u206B\u200D\u206A\u206C\u206F\u206E\u202E\u200B\u200E\u206D\u206F\u202C\u202D\u202D\u200E\u202B\u206D\u200F\u206F\u200B\u206D\u200E\u206A\u206E\u202D\u200B\u202B\u202D\u200B\u202D\u202E\u202A\u206F\u202E\u200D\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreBrokenHornDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter))]
		public sealed class FlandreBrokenHorn : Exhibit
		{
			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<GameEventArgs>(FlandreBrokenHornDef.FlandreBrokenHorn.\u200D\u202C\u202E\u200D\u206F\u206F\u206A\u206F\u202E\u202A\u202C\u206E\u200C\u202E\u200C\u202B\u200B\u206C\u202A\u206E\u206B\u206D\u206C\u206D\u202B\u206E\u200E\u200E\u202D\u202C\u200E\u202D\u200E\u206E\u200F\u200D\u202A\u206F\u200F\u202E\u202E(FlandreBrokenHornDef.FlandreBrokenHorn.\u200F\u200F\u200B\u206B\u206E\u206A\u206C\u206F\u202A\u200D\u206F\u206B\u202B\u206F\u206A\u206F\u206B\u202C\u206B\u206C\u202C\u200B\u202A\u200F\u206F\u200B\u206B\u206D\u206E\u200C\u202D\u206C\u202C\u202B\u200D\u206A\u200E\u206A\u202B\u206D\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
			}

			protected override void OnLeaveBattle()
			{
				FlandreBrokenHornDef.FlandreBrokenHorn.\u200E\u200F\u206A\u202B\u206F\u200B\u200B\u206E\u202A\u202A\u202B\u206A\u200D\u206B\u200E\u200B\u200C\u200E\u206F\u202D\u202A\u202A\u202A\u206E\u206C\u206C\u202D\u200C\u200D\u206A\u200D\u202D\u202D\u206B\u206F\u200F\u206D\u200F\u202A\u202A\u202E(this, false);
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
			{
				FlandreBrokenHornDef.FlandreBrokenHorn.<OnBattleStarted>d__2 <OnBattleStarted>d__ = new FlandreBrokenHornDef.FlandreBrokenHorn.<OnBattleStarted>d__2(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			static BattleController \u200F\u200F\u200B\u206B\u206E\u206A\u206C\u206F\u202A\u200D\u206F\u206B\u202B\u206F\u206A\u206F\u206B\u202C\u206B\u206C\u202C\u200B\u202A\u200F\u206F\u200B\u206B\u206D\u206E\u200C\u202D\u206C\u202C\u202B\u200D\u206A\u200E\u206A\u202B\u206D\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u200D\u202C\u202E\u200D\u206F\u206F\u206A\u206F\u202E\u202A\u202C\u206E\u200C\u202E\u200C\u202B\u200B\u206C\u202A\u206E\u206B\u206D\u206C\u206D\u202B\u206E\u200E\u200E\u202D\u202C\u200E\u202D\u200E\u206E\u200F\u200D\u202A\u206F\u200F\u202E\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static void \u200E\u200F\u206A\u202B\u206F\u200B\u200B\u206E\u202A\u202A\u202B\u206A\u200D\u206B\u200E\u200B\u200C\u200E\u206F\u202D\u202A\u202A\u202A\u206E\u206C\u206C\u202D\u200C\u200D\u206A\u200D\u202D\u202D\u206B\u206F\u200F\u206D\u200F\u202A\u202A\u202E(Exhibit A_0, bool A_1)
			{
				A_0.Blackout = A_1;
			}

			private class FlandreBrokenHornWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.\u200D\u200D\u202D\u206F\u200B\u200B\u200F\u202C\u202D\u200E\u206A\u206F\u202A\u206F\u206D\u206C\u206E\u202A\u202C\u202E\u200C\u202B\u206D\u202B\u202E\u200D\u202A\u206E\u202D\u200E\u206C\u200E\u206B\u202E\u206F\u206C\u202A\u206F\u202C\u202E(FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.\u202B\u206E\u206D\u202A\u200E\u200C\u202C\u202C\u200E\u202C\u200D\u206D\u206E\u202E\u202D\u206B\u200E\u202C\u202D\u202E\u206C\u200E\u206D\u206F\u206F\u202B\u202C\u206E\u200D\u202E\u200E\u206D\u206B\u202E\u200D\u202D\u206C\u206A\u200C\u202E(FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.\u206A\u202D\u206B\u200B\u206E\u202A\u202A\u200D\u200D\u200D\u206C\u200C\u202B\u202B\u200B\u206D\u206C\u206B\u202E\u206A\u206D\u200B\u202A\u202C\u200E\u206B\u206F\u206A\u202A\u200E\u206B\u206B\u202A\u206A\u202C\u200C\u200B\u202B\u202A\u200D\u202E(gameRun)), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317)))
					{
						for (;;)
						{
							IL_001E:
							int num = 116703786;
							for (;;)
							{
								int num2 = num;
								switch ((1739536741 - (-1402287055 + -379126348 - num2 * -779787459 * -47537497)) % 4)
								{
								case 0:
									goto IL_001E;
								case 2:
									num = ((!FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.\u200D\u202D\u202E\u202B\u206C\u206D\u206F\u206F\u206F\u206F\u206B\u202C\u202C\u206B\u200C\u206E\u202E\u206F\u206A\u202C\u206A\u202B\u200D\u206B\u200D\u202C\u202A\u206C\u206B\u206F\u202E\u202E\u202A\u200F\u200E\u206A\u206B\u202C\u200B\u206D\u202E(gameRun).Any(delegate(Card c)
									{
										if (!FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.<>c.\u206E\u200C\u206A\u200D\u200D\u202B\u200B\u200E\u202D\u202B\u206F\u206F\u202B\u206F\u206E\u202D\u202A\u202D\u200E\u206D\u202A\u202D\u206A\u200E\u202C\u202A\u202B\u206F\u206F\u206F\u202E\u202D\u200C\u200E\u202D\u206E\u202D\u202A\u206C\u200E\u202E(FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.<>c.\u200B\u200E\u202B\u206A\u206A\u206A\u200C\u206B\u200F\u206D\u200E\u200E\u206F\u202D\u206F\u202B\u206B\u200C\u200D\u206C\u200F\u200D\u206D\u202D\u200C\u202C\u202C\u206B\u202A\u202D\u200F\u202E\u206A\u206C\u200E\u200F\u206B\u200D\u206A\u200F\u202E(c)).Contains(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-200313178)))
										{
											for (;;)
											{
												int num3 = -73380157;
												switch ((~(num3 ^ ((-1287858805 * (682416107 ^ 1204127947)) ^ -(~1648526704))) * 145794675 - -1657563154) % 3)
												{
												case 1:
													goto IL_0063;
												case 2:
													continue;
												}
												break;
											}
											return true;
											IL_0063:
											return FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.<>c.\u206B\u202B\u206B\u200D\u200D\u200E\u200E\u200F\u206E\u206D\u206D\u200C\u200B\u202E\u202C\u206B\u200D\u200B\u206B\u200D\u206D\u200D\u206D\u206F\u206D\u202C\u202D\u200B\u200B\u202E\u206E\u202D\u206D\u206D\u200D\u200F\u200D\u206B\u206A\u200E\u202E(FlandreBrokenHornDef.FlandreBrokenHorn.FlandreBrokenHornWeighter.<>c.\u200B\u200E\u202B\u206A\u206A\u206A\u200C\u206B\u200F\u206D\u200E\u200E\u206F\u202D\u206F\u202B\u206B\u200C\u200D\u206C\u200F\u200D\u206D\u202D\u200C\u202C\u202C\u206B\u202A\u202D\u200F\u202E\u206A\u206C\u200E\u200F\u206B\u200D\u206A\u200F\u202E(c)).Contains(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(98082179));
										}
										return true;
									})) ? (-1993077975) : 58311843);
									continue;
								case 3:
									goto IL_009B;
								}
								goto Block_1;
							}
						}
						Block_1:
						return 1.15f;
					}
					IL_009B:
					return 0f;
				}

				static PlayerUnit \u206A\u202D\u206B\u200B\u206E\u202A\u202A\u200D\u200D\u200D\u206C\u200C\u202B\u202B\u200B\u206D\u206C\u206B\u202E\u206A\u206D\u200B\u202A\u202C\u200E\u206B\u206F\u206A\u202A\u200E\u206B\u206B\u202A\u206A\u202C\u200C\u200B\u202B\u202A\u200D\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u202B\u206E\u206D\u202A\u200E\u200C\u202C\u202C\u200E\u202C\u200D\u206D\u206E\u202E\u202D\u206B\u200E\u202C\u202D\u202E\u206C\u200E\u206D\u206F\u206F\u202B\u202C\u206E\u200D\u202E\u200E\u206D\u206B\u202E\u200D\u202D\u206C\u206A\u200C\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u200D\u200D\u202D\u206F\u200B\u200B\u200F\u202C\u202D\u200E\u206A\u206F\u202A\u206F\u206D\u206C\u206E\u202A\u202C\u202E\u200C\u202B\u206D\u202B\u202E\u200D\u202A\u206E\u202D\u200E\u206C\u200E\u206B\u202E\u206F\u206C\u202A\u206F\u202C\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}

				static IReadOnlyList<Card> \u200D\u202D\u202E\u202B\u206C\u206D\u206F\u206F\u206F\u206F\u206B\u202C\u202C\u206B\u200C\u206E\u202E\u206F\u206A\u202C\u206A\u202B\u200D\u206B\u200D\u202C\u202A\u206C\u206B\u206F\u202E\u202E\u202A\u200F\u200E\u206A\u206B\u202C\u200B\u206D\u202E(GameRunController A_0)
				{
					return A_0.BaseDeck;
				}
			}
		}
	}
}
