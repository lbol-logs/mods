using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreOnePairDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1972356633);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreOnePairDef.\u200B\u200D\u202B\u200C\u206F\u206C\u200F\u206F\u206D\u200D\u206E\u206F\u200C\u200B\u206E\u200E\u206E\u200C\u206A\u206B\u202D\u206A\u202B\u206A\u202D\u206F\u206E\u206F\u200B\u202C\u206E\u202B\u206F\u206C\u206F\u206A\u202B\u206B\u200F\u206D\u202E(BepinexPlugin.embeddedSource);
			FlandreOnePairDef.\u206B\u200F\u206A\u206A\u202E\u206F\u202D\u200F\u200D\u202B\u206F\u206E\u200E\u206D\u200F\u206D\u206E\u206D\u200B\u206A\u200B\u200C\u200F\u200E\u206D\u206E\u206E\u202E\u200B\u202A\u202E\u200D\u206C\u206D\u202D\u206E\u202B\u202A\u200E\u200F\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreOnePairDef.\u200F\u200E\u200E\u200F\u206F\u206D\u206B\u206F\u202A\u206F\u206C\u200D\u202B\u202A\u200E\u200D\u206A\u206C\u200D\u200E\u206B\u202B\u202C\u202C\u200F\u202D\u202A\u200E\u206E\u206B\u200F\u200C\u202B\u206F\u202B\u202E\u206E\u200F\u206E\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreOnePairDef.\u200F\u206F\u206C\u206C\u206F\u202C\u200D\u200E\u206C\u206A\u202B\u202E\u202C\u206C\u206E\u200C\u206E\u202E\u202D\u200B\u206D\u202A\u206B\u206A\u200C\u200D\u202C\u206E\u202A\u206C\u202D\u200F\u206C\u206B\u206F\u202E\u202A\u206A\u206A\u202E(BepinexPlugin.sequenceTable, FlandreOnePairDef.\u200D\u200C\u202B\u202C\u202D\u200D\u206E\u206B\u206F\u200E\u206D\u202C\u202B\u200D\u206B\u200B\u202D\u202A\u202D\u206F\u202A\u202B\u200E\u206C\u200F\u206F\u200F\u206B\u200E\u202C\u202C\u202A\u200B\u200F\u206B\u206A\u206D\u202B\u206C\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Any = 1,
				Green = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(1), null, new int?(4), null, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Misfortune | Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, Keyword.Misfortune | Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1676817587), new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(970499238) });
		}

		static CardImages \u200B\u200D\u202B\u200C\u206F\u206C\u200F\u206F\u206D\u200D\u206E\u206F\u200C\u200B\u206E\u200E\u206E\u200C\u206A\u206B\u202D\u206A\u202B\u206A\u202D\u206F\u206E\u206F\u200B\u202C\u206E\u202B\u206F\u206C\u206F\u206A\u202B\u206B\u200F\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u200F\u206A\u206A\u202E\u206F\u202D\u200F\u200D\u202B\u206F\u206E\u200E\u206D\u200F\u206D\u206E\u206D\u200B\u206A\u200B\u200C\u200F\u200E\u206D\u206E\u206E\u202E\u200B\u202A\u202E\u200D\u206C\u206D\u202D\u206E\u202B\u202A\u200E\u200F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u200E\u200E\u200F\u206F\u206D\u206B\u206F\u202A\u206F\u206C\u200D\u202B\u202A\u200E\u200D\u206A\u206C\u200D\u200E\u206B\u202B\u202C\u202C\u200F\u202D\u202A\u200E\u206E\u206B\u200F\u200C\u202B\u206F\u202B\u202E\u206E\u200F\u206E\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u200C\u202B\u202C\u202D\u200D\u206E\u206B\u206F\u200E\u206D\u202C\u202B\u200D\u206B\u200B\u202D\u202A\u202D\u206F\u202A\u202B\u200E\u206C\u200F\u206F\u200F\u206B\u200E\u202C\u202C\u202A\u200B\u200F\u206B\u206A\u206D\u202B\u206C\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u206F\u206C\u206C\u206F\u202C\u200D\u200E\u206C\u206A\u202B\u202E\u202C\u206C\u206E\u200C\u206E\u202E\u202D\u200B\u206D\u202A\u206B\u206A\u200C\u200D\u202C\u206E\u202A\u206C\u202D\u200F\u206C\u206B\u206F\u202E\u202A\u206A\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreOnePairDef))]
		public sealed class FlandreOnePair : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreOnePairDef.FlandreOnePair.\u200E\u200C\u202B\u206A\u200C\u206A\u202B\u206D\u206C\u202D\u200C\u200F\u200C\u200D\u202C\u202E\u206A\u202B\u200D\u206B\u206A\u200C\u200D\u202D\u206F\u200F\u206A\u206E\u202E\u206D\u200F\u202B\u206B\u200E\u206B\u200F\u200B\u202A\u206C\u206D\u202E((float)FlandreOnePairDef.FlandreOnePair.\u206E\u206F\u202E\u202C\u206E\u206B\u202A\u206D\u202C\u206A\u202E\u206C\u202E\u206D\u202A\u200F\u200E\u200C\u200E\u206B\u200E\u202D\u206E\u202A\u206D\u200D\u206D\u206E\u206D\u200F\u200D\u202A\u200B\u200F\u206D\u206C\u200F\u206E\u202E\u202E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreOnePairDef.FlandreOnePair.\u206E\u206F\u202E\u202C\u206E\u206B\u202A\u206D\u202C\u206A\u202E\u206C\u202E\u206D\u202A\u200F\u200E\u200C\u200E\u206B\u200E\u202D\u206E\u202A\u206D\u200D\u206D\u206E\u206D\u200F\u200D\u202A\u200B\u200F\u206D\u206C\u200F\u206E\u202E\u202E\u202E(this).GetValueOrDefault() * 2;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 2053321341;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-num2 + -258720339)) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 843794199U) ^ 1921937153U);
							continue;
						}
						return;
					}
				}
			}

			public override Interaction Precondition()
			{
				List<Card> list = FlandreOnePairDef.FlandreOnePair.\u206B\u206D\u206C\u202A\u200D\u206A\u202A\u200D\u206B\u202D\u206F\u200E\u206D\u206D\u200F\u206A\u202C\u202E\u202C\u200E\u200D\u200C\u200F\u202B\u200E\u206A\u202E\u200E\u202D\u202A\u200B\u206A\u206C\u202D\u202A\u200D\u202A\u206D\u206B\u202E(FlandreOnePairDef.FlandreOnePair.\u206B\u206F\u206C\u206D\u200C\u200B\u202B\u206C\u202E\u206A\u202C\u206D\u206D\u206E\u202E\u202A\u200C\u206D\u200F\u206E\u206F\u202D\u206A\u206D\u206E\u200B\u202B\u206D\u202A\u202D\u202D\u200E\u200C\u200D\u202B\u202E\u206F\u206D\u200E\u202C\u202E(this)).Where(delegate(Card c)
				{
					if (c != this)
					{
						for (;;)
						{
							IL_0004:
							int num4 = 1808800110;
							for (;;)
							{
								int num5 = num4;
								uint num6;
								switch ((num6 = (uint)(-(uint)(~(num5 + -605284799 * -(-1488997639 ^ -539816729)) * -909167545))) % 4U)
								{
								case 0U:
									goto IL_0004;
								case 2U:
									goto IL_0063;
								case 3U:
									num4 = (int)(((FlandreOnePairDef.FlandreOnePair.\u206D\u206E\u202A\u202D\u200F\u200F\u206B\u206B\u200E\u202B\u206B\u202D\u202D\u202E\u200E\u202B\u202C\u200C\u202E\u200E\u206B\u206C\u202A\u200E\u206E\u200E\u206B\u206F\u202C\u202C\u200E\u206A\u202A\u202E\u202B\u206F\u200D\u200B\u200D\u206E\u202E(c) == CardType.Status) ? 3100354138U : 2855519161U) ^ (num6 * 1198510354U));
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:
						return false;
						IL_0063:
						return FlandreOnePairDef.FlandreOnePair.\u206D\u206E\u202A\u202D\u200F\u200F\u206B\u206B\u200E\u202B\u206B\u202D\u202D\u202E\u200E\u202B\u202C\u200C\u202E\u200E\u206B\u206C\u202A\u200E\u206E\u200E\u206B\u206F\u202C\u202C\u200E\u206A\u202A\u202E\u202B\u206F\u200D\u200B\u200D\u206E\u202E(c) != CardType.Misfortune;
					}
					return false;
				}).ToList<Card>();
				for (;;)
				{
					IL_0022:
					int num = -681080722;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-((num2 - ((504333199 + 2127647253 * -1977224348) ^ ((-2033092313 ^ 2117528548) - -1970208487))) * 1683792461) * -1705940909)) % 4U)
						{
						case 0U:
							goto IL_0022;
						case 1U:
							num = (int)(((list.Count <= 0) ? 2955119097U : 900226218U) ^ (num3 * 694154870U));
							continue;
						case 2U:
							goto IL_0098;
						}
						goto Block_1;
					}
				}
				Block_1:
				goto IL_00AC;
				IL_0098:
				return null;
				IL_00AC:
				return FlandreOnePairDef.FlandreOnePair.\u206E\u206F\u200F\u200B\u202A\u206A\u206D\u202C\u206A\u200E\u200D\u202C\u206F\u206B\u200C\u200C\u200D\u200E\u200D\u202C\u206B\u202A\u200D\u206B\u202D\u202D\u206C\u200F\u200F\u202C\u202B\u200F\u206D\u200C\u206C\u200D\u202E\u200E\u206B\u202D\u202E(1, 1, list);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreOnePairDef.FlandreOnePair.<Actions>d__6 <Actions>d__ = new FlandreOnePairDef.FlandreOnePair.<Actions>d__6(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206E\u206F\u202E\u202C\u206E\u206B\u202A\u206D\u202C\u206A\u202E\u206C\u202E\u206D\u202A\u200F\u200E\u200C\u200E\u206B\u200E\u202D\u206E\u202A\u206D\u200D\u206D\u206E\u206D\u200F\u200D\u202A\u200B\u200F\u206D\u206C\u200F\u206E\u202E\u202E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200E\u200C\u202B\u206A\u200C\u206A\u202B\u206D\u206C\u202D\u200C\u200F\u200C\u200D\u202C\u202E\u206A\u202B\u200D\u206B\u206A\u200C\u200D\u202D\u206F\u200F\u206A\u206E\u202E\u206D\u200F\u202B\u206B\u200E\u206B\u200F\u200B\u202A\u206C\u206D\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static BattleController \u206B\u206F\u206C\u206D\u200C\u200B\u202B\u206C\u202E\u206A\u202C\u206D\u206D\u206E\u202E\u202A\u200C\u206D\u200F\u206E\u206F\u202D\u206A\u206D\u206E\u200B\u202B\u206D\u202A\u202D\u202D\u200E\u200C\u200D\u202B\u202E\u206F\u206D\u200E\u202C\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206B\u206D\u206C\u202A\u200D\u206A\u202A\u200D\u206B\u202D\u206F\u200E\u206D\u206D\u200F\u206A\u202C\u202E\u202C\u200E\u200D\u200C\u200F\u202B\u200E\u206A\u202E\u200E\u202D\u202A\u200B\u206A\u206C\u202D\u202A\u200D\u202A\u206D\u206B\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static SelectHandInteraction \u206E\u206F\u200F\u200B\u202A\u206A\u206D\u202C\u206A\u200E\u200D\u202C\u206F\u206B\u200C\u200C\u200D\u200E\u200D\u202C\u206B\u202A\u200D\u206B\u202D\u202D\u206C\u200F\u200F\u202C\u202B\u200F\u206D\u200C\u206C\u200D\u202E\u200E\u206B\u202D\u202E(int A_0, int A_1, IEnumerable<Card> A_2)
			{
				return new SelectHandInteraction(A_0, A_1, A_2);
			}

			static CardType \u206D\u206E\u202A\u202D\u200F\u200F\u206B\u206B\u200E\u202B\u206B\u202D\u202D\u202E\u200E\u202B\u202C\u200C\u202E\u200E\u206B\u206C\u202A\u200E\u206E\u200E\u206B\u206F\u202C\u202C\u200E\u206A\u202A\u202E\u202B\u206F\u200D\u200B\u200D\u206E\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static CardType \u206D\u206B\u206D\u202D\u202B\u206F\u200D\u206E\u200B\u206A\u200B\u206F\u200E\u206B\u206D\u200E\u202C\u202D\u206E\u200D\u206B\u202C\u202A\u200C\u206F\u202B\u202B\u200D\u200D\u206C\u206C\u202D\u200F\u200C\u202A\u202E\u202E\u200E\u200F\u200C\u202E(CardConfig A_0)
			{
				return A_0.Type;
			}

			static CardType \u200D\u202E\u202A\u206D\u200E\u202E\u206B\u202B\u202D\u202B\u200B\u202B\u206A\u200F\u202E\u200E\u200D\u206F\u200C\u202B\u206C\u202A\u206D\u206A\u200C\u206E\u200F\u206B\u202A\u202A\u206C\u200C\u206A\u200B\u202D\u206A\u200E\u206F\u200D\u206D\u202E(Card A_0)
			{
				return A_0.CardType;
			}
		}
	}
}
