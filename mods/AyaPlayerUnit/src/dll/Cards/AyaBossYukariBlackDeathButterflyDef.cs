using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaBossYukariBlackDeathButterflyDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-634977675);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaBossYukariBlackDeathButterflyDef.\u200B\u200F\u206E\u206D\u206E\u202C\u206D\u206F\u202D\u202C\u200B\u206B\u202B\u200B\u206C\u202C\u200E\u200E\u200D\u200D\u202E\u200D\u200E\u202B\u206D\u200D\u202D\u200D\u206B\u206C\u200E\u206F\u202A\u206B\u206D\u200D\u206D\u202B\u206B\u200F\u202E(BepinexPlugin.embeddedSource);
			AyaBossYukariBlackDeathButterflyDef.\u200E\u200E\u206D\u200D\u206C\u200C\u206A\u206A\u206E\u202B\u202D\u206F\u200F\u200B\u206A\u200C\u202D\u200F\u206B\u206F\u200E\u202A\u206E\u206B\u206E\u200E\u202D\u206E\u206E\u206D\u206A\u202C\u202E\u202C\u206F\u206A\u206E\u206D\u202D\u202A\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossYukariBlackDeathButterflyDef.\u200D\u200F\u200C\u200D\u206C\u200D\u202B\u206E\u206B\u200C\u200C\u200E\u200F\u200F\u206D\u200E\u202A\u202D\u206D\u202C\u200B\u200C\u202D\u206A\u206F\u200B\u206D\u202B\u200B\u200D\u206B\u206A\u202A\u200E\u206B\u206F\u202A\u202A\u202E\u206C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaBossYukariBlackDeathButterflyDef.\u202D\u200E\u200D\u206A\u206F\u206C\u202C\u202C\u206B\u200D\u206C\u206D\u200C\u200F\u200D\u206D\u206E\u200F\u200F\u206D\u202E\u206B\u200B\u202A\u202C\u200F\u206C\u202C\u206B\u206A\u200E\u206A\u200B\u206C\u200E\u206A\u206C\u206A\u200E\u206C\u202E(BepinexPlugin.sequenceTable, AyaBossYukariBlackDeathButterflyDef.\u206A\u202A\u206A\u202B\u206D\u206D\u206F\u206A\u206E\u200B\u202A\u200C\u206A\u202D\u200C\u200C\u202C\u202E\u202B\u200C\u202E\u202D\u202E\u206B\u206A\u202B\u206A\u206C\u202E\u200F\u200C\u206B\u206B\u200F\u206A\u200E\u200C\u206A\u200B\u206E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, false, false, true, false, false, Rarity.Rare, CardType.Status, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 3
			}, null, null, null, null, null, null, null, null, null, null, new int?(0), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden, Keyword.Forbidden, false, Keyword.Exile, Keyword.Exile, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1029222033) }, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1691350654) }, new List<string>(), new List<string>(), null, null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1922929686), new List<string>());
		}

		static CardImages \u200B\u200F\u206E\u206D\u206E\u202C\u206D\u206F\u202D\u202C\u200B\u206B\u202B\u200B\u206C\u202C\u200E\u200E\u200D\u200D\u202E\u200D\u200E\u202B\u206D\u200D\u202D\u200D\u206B\u206C\u200E\u206F\u202A\u206B\u206D\u200D\u206D\u202B\u206B\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200E\u200E\u206D\u200D\u206C\u200C\u206A\u206A\u206E\u202B\u202D\u206F\u200F\u200B\u206A\u200C\u202D\u200F\u206B\u206F\u200E\u202A\u206E\u206B\u206E\u200E\u202D\u206E\u206E\u206D\u206A\u202C\u202E\u202C\u206F\u206A\u206E\u206D\u202D\u202A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u200F\u200C\u200D\u206C\u200D\u202B\u206E\u206B\u200C\u200C\u200E\u200F\u200F\u206D\u200E\u202A\u202D\u206D\u202C\u200B\u200C\u202D\u206A\u206F\u200B\u206D\u202B\u200B\u200D\u206B\u206A\u202A\u200E\u206B\u206F\u202A\u202A\u202E\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u202A\u206A\u202B\u206D\u206D\u206F\u206A\u206E\u200B\u202A\u200C\u206A\u202D\u200C\u200C\u202C\u202E\u202B\u200C\u202E\u202D\u202E\u206B\u206A\u202B\u206A\u206C\u202E\u200F\u200C\u206B\u206B\u200F\u206A\u200E\u200C\u206A\u200B\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u200E\u200D\u206A\u206F\u206C\u202C\u202C\u206B\u200D\u206C\u206D\u200C\u200F\u200D\u206D\u206E\u200F\u200F\u206D\u202E\u206B\u200B\u202A\u202C\u200F\u206C\u202C\u206B\u206A\u200E\u206A\u200B\u206C\u200E\u206A\u206C\u206A\u200E\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaBossYukariBlackDeathButterflyDef))]
		public sealed class AyaBossYukariBlackDeathButterfly : Card
		{
			public override int AdditionalValue1
			{
				get
				{
					GameRunController gameRunController = AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u202D\u206F\u206B\u200D\u206A\u202E\u206E\u202E\u202C\u200E\u206A\u200E\u206B\u202B\u206D\u202C\u206C\u206A\u202A\u200F\u202A\u206B\u206D\u200E\u206A\u202E\u206F\u202E\u206E\u200D\u202B\u202E\u202D\u202E\u200E\u202C\u202A\u202D\u202B\u202A\u202E(Singleton<GameMaster>.Instance);
					GameDifficulty? gameDifficulty;
					GameDifficulty? gameDifficulty2;
					if (gameRunController == null)
					{
						gameDifficulty = null;
						gameDifficulty2 = gameDifficulty;
					}
					else
					{
						gameDifficulty2 = new GameDifficulty?(AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u206B\u200C\u200D\u200F\u206F\u200E\u202D\u202B\u202B\u200E\u206C\u202C\u202D\u206A\u206A\u202C\u200C\u200D\u206C\u206E\u202C\u206A\u206A\u206A\u200F\u206B\u206F\u200E\u206F\u202C\u206F\u206C\u206D\u206F\u202B\u206A\u206E\u202C\u200E\u200E\u202E(gameRunController));
					}
					GameDifficulty? gameDifficulty3 = gameDifficulty2;
					int num4;
					for (;;)
					{
						IL_0024:
						int num = -203707328;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((num2 ^ ~(-(-939437642 ^ 1583026435))) - (--1049006509 + 1190958309 * 25643099))) % 11U)
							{
							case 1U:
							{
								GameDifficulty gameDifficulty4;
								num = (int)((((gameDifficulty.GetValueOrDefault() >= gameDifficulty4) & (gameDifficulty != null)) ? 3326203428U : 556396965U) ^ (num3 * 670591206U));
								continue;
							}
							case 2U:
								num = ((gameDifficulty3 == null) ? 1654172006 : (-1885209238));
								continue;
							case 3U:
								num = (int)(((gameDifficulty3.GetValueOrDefault() != GameDifficulty.Hard) ? 532155377U : 442142294U) ^ (num3 * 3736957708U));
								continue;
							case 4U:
								num = (int)((num3 * 3887555656U) ^ 3436158702U);
								continue;
							case 5U:
								num4 = 6;
								num = (int)((num3 * 459286426U) ^ 135467691U);
								continue;
							case 6U:
								num4 = 4;
								num = -1226916837;
								continue;
							case 7U:
								goto IL_0024;
							case 8U:
								num4 = 2;
								num = -1226916837;
								continue;
							case 9U:
								num = (int)((num3 * 4233853086U) ^ 3828741442U);
								continue;
							case 10U:
							{
								gameDifficulty = gameDifficulty3;
								GameDifficulty gameDifficulty4 = GameDifficulty.Lunatic;
								num = -4944742;
								continue;
							}
							}
							return num4;
						}
					}
					return num4;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnterBattle(BattleController battle)
			{
				BattleController battleController = AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u200F\u202E\u206C\u206F\u206F\u200E\u202B\u200F\u202D\u206F\u200E\u202D\u206A\u202E\u200B\u200F\u200D\u202C\u206F\u200E\u200D\u206F\u200B\u206C\u206A\u206E\u200F\u202A\u206B\u206E\u206D\u202D\u202D\u206B\u202E\u200E\u200C\u206B\u202D\u206B\u202E(this);
				if (AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u200E\u202E\u206D\u202D\u202A\u206E\u206D\u206E\u202E\u202C\u202E\u202A\u200D\u202D\u202D\u202C\u206F\u202A\u202C\u202C\u202D\u200D\u206C\u206B\u202E\u200C\u202B\u200F\u202C\u202D\u200B\u202A\u206B\u200C\u200F\u206D\u200E\u206C\u206E\u202A\u202E((battleController != null) ? AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u200D\u206A\u206B\u200B\u202E\u206C\u206F\u206F\u200D\u206F\u206A\u206E\u202C\u200C\u202C\u200F\u202E\u206E\u206F\u202C\u202B\u202D\u206C\u206A\u206E\u202D\u200B\u200D\u206A\u200D\u206F\u200F\u202E\u206D\u202D\u206F\u200E\u206E\u202B\u206D\u202E(AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u206D\u200C\u200D\u206D\u206C\u200D\u200C\u200C\u202C\u202B\u202B\u206D\u202D\u202C\u200F\u206A\u200B\u202C\u202A\u200C\u200E\u206C\u206D\u206B\u200D\u202E\u206B\u206B\u202D\u202D\u202B\u202B\u200F\u202C\u202B\u206C\u206C\u200B\u202E\u202C\u202E(battleController)) : null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-135338671)))
				{
					goto IL_002A;
				}
				goto IL_009B;
				int num2;
				for (;;)
				{
					IL_002F:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((~num ^ ~(-2115619144) ^ -243769126) + 1065563230)) % 5U)
					{
					case 0U:
						goto IL_002A;
					case 1U:
						goto IL_0065;
					case 2U:
						base.React(new LazySequencedReactor(this.EnterHandReactor));
						num2 = (int)((num3 * 1926431382U) ^ 2035692645U);
						continue;
					case 3U:
						goto IL_009B;
					}
					break;
				}
				return;
				IL_0065:
				throw AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u206F\u200B\u202B\u202A\u202E\u202A\u200B\u202C\u202D\u206B\u200D\u200F\u200C\u206F\u200E\u206E\u206B\u206B\u200C\u206D\u206E\u206C\u202E\u200C\u200F\u202B\u202A\u202B\u200C\u202D\u206B\u206E\u202A\u206F\u206B\u206C\u202B\u200E\u202A\u200D\u202E();
				IL_002A:
				num2 = -1104384589;
				goto IL_002F;
				IL_009B:
				num2 = ((AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.\u202A\u202B\u206C\u200E\u206B\u206B\u200F\u206B\u202C\u202D\u202C\u200E\u202B\u202A\u206B\u202B\u206E\u200E\u206B\u206B\u202C\u206A\u202A\u202E\u202B\u200F\u200D\u202E\u200C\u202C\u206A\u206F\u206B\u206B\u200D\u206B\u202B\u200C\u200B\u200C\u202E(this) == CardZone.Hand) ? 1577226887 : 2008131367);
				goto IL_002F;
			}

			public override IEnumerable<BattleAction> OnDraw()
			{
				return this.EnterHandReactor();
			}

			public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
			{
				if (dstZone != CardZone.Hand)
				{
					for (;;)
					{
						int num = 1192778946;
						switch ((~((num - ((364164140 ^ 1589683948 ^ (2023814853 * -1167249825)) + (-370408024 ^ (-1043753056 - 1605954869)))) * -1443456227) + -174896698) % 3)
						{
						case 0:
							continue;
						case 1:
							goto IL_005A;
						}
						break;
					}
					goto IL_006B;
					IL_005A:
					return null;
				}
				IL_006B:
				return this.EnterHandReactor();
			}

			public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
			{
				AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.<OnExile>d__5 <OnExile>d__ = new AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.<OnExile>d__5(-2);
				<OnExile>d__.<>4__this = this;
				return <OnExile>d__;
			}

			private IEnumerable<BattleAction> EnterHandReactor()
			{
				AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.<EnterHandReactor>d__6 <EnterHandReactor>d__ = new AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.<EnterHandReactor>d__6(-2);
				<EnterHandReactor>d__.<>4__this = this;
				return <EnterHandReactor>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				return new AyaBossYukariBlackDeathButterflyDef.AyaBossYukariBlackDeathButterfly.<Actions>d__7(-2);
			}

			static GameRunController \u202D\u206F\u206B\u200D\u206A\u202E\u206E\u202E\u202C\u200E\u206A\u200E\u206B\u202B\u206D\u202C\u206C\u206A\u202A\u200F\u202A\u206B\u206D\u200E\u206A\u202E\u206F\u202E\u206E\u200D\u202B\u202E\u202D\u202E\u200E\u202C\u202A\u202D\u202B\u202A\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static GameDifficulty \u206B\u200C\u200D\u200F\u206F\u200E\u202D\u202B\u202B\u200E\u206C\u202C\u202D\u206A\u206A\u202C\u200C\u200D\u206C\u206E\u202C\u206A\u206A\u206A\u200F\u206B\u206F\u200E\u206F\u202C\u206F\u206C\u206D\u206F\u202B\u206A\u206E\u202C\u200E\u200E\u202E(GameRunController A_0)
			{
				return A_0.Difficulty;
			}

			static BattleController \u200F\u202E\u206C\u206F\u206F\u200E\u202B\u200F\u202D\u206F\u200E\u202D\u206A\u202E\u200B\u200F\u200D\u202C\u206F\u200E\u200D\u206F\u200B\u206C\u206A\u206E\u200F\u202A\u206B\u206E\u206D\u202D\u202D\u206B\u202E\u200E\u200C\u206B\u202D\u206B\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static EnemyGroup \u206D\u200C\u200D\u206D\u206C\u200D\u200C\u200C\u202C\u202B\u202B\u206D\u202D\u202C\u200F\u206A\u200B\u202C\u202A\u200C\u200E\u206C\u206D\u206B\u200D\u202E\u206B\u206B\u202D\u202D\u202B\u202B\u200F\u202C\u202B\u206C\u206C\u200B\u202E\u202C\u202E(BattleController A_0)
			{
				return A_0.EnemyGroup;
			}

			static string \u200D\u206A\u206B\u200B\u202E\u206C\u206F\u206F\u200D\u206F\u206A\u206E\u202C\u200C\u202C\u200F\u202E\u206E\u206F\u202C\u202B\u202D\u206C\u206A\u206E\u202D\u200B\u200D\u206A\u200D\u206F\u200F\u202E\u206D\u202D\u206F\u200E\u206E\u202B\u206D\u202E(EnemyGroup A_0)
			{
				return A_0.Id;
			}

			static bool \u200E\u202E\u206D\u202D\u202A\u206E\u206D\u206E\u202E\u202C\u202E\u202A\u200D\u202D\u202D\u202C\u206F\u202A\u202C\u202C\u202D\u200D\u206C\u206B\u202E\u200C\u202B\u200F\u202C\u202D\u200B\u202A\u206B\u200C\u200F\u206D\u200E\u206C\u206E\u202A\u202E(string A_0, string A_1)
			{
				return A_0 != A_1;
			}

			static NullReferenceException \u206F\u200B\u202B\u202A\u202E\u202A\u200B\u202C\u202D\u206B\u200D\u200F\u200C\u206F\u200E\u206E\u206B\u206B\u200C\u206D\u206E\u206C\u202E\u200C\u200F\u202B\u202A\u202B\u200C\u202D\u206B\u206E\u202A\u206F\u206B\u206C\u202B\u200E\u202A\u200D\u202E()
			{
				return new NullReferenceException();
			}

			static CardZone \u202A\u202B\u206C\u200E\u206B\u206B\u200F\u206B\u202C\u202D\u202C\u200E\u202B\u202A\u206B\u202B\u206E\u200E\u206B\u206B\u202C\u206A\u202A\u202E\u202B\u200F\u200D\u202E\u200C\u202C\u206A\u206F\u206B\u206B\u200D\u206B\u202B\u200C\u200B\u200C\u202E(Card A_0)
			{
				return A_0.Zone;
			}
		}
	}
}
