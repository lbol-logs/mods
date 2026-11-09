using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreRipplesof495YearsDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-182745745);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreRipplesof495YearsDef.\u206F\u202C\u206E\u206A\u200B\u200B\u202C\u206E\u202E\u200E\u206F\u206C\u202A\u206E\u200F\u200D\u202B\u202C\u206D\u202B\u202D\u200E\u206E\u202D\u200C\u200B\u202B\u202E\u206E\u206B\u206E\u202B\u206E\u206D\u206D\u200E\u202E\u206A\u202D\u206F\u202E(BepinexPlugin.embeddedSource);
			FlandreRipplesof495YearsDef.\u200C\u200D\u206D\u206F\u202B\u206E\u200B\u206A\u202E\u200E\u200D\u200C\u200C\u202D\u206A\u206A\u202C\u200E\u206E\u200C\u206E\u200B\u202D\u202C\u202D\u202D\u200B\u202E\u206A\u202C\u206C\u200E\u200C\u200F\u202A\u202D\u202C\u200B\u202A\u202E\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreRipplesof495YearsDef.\u206B\u202A\u206A\u200B\u202C\u206D\u202D\u202C\u206B\u206E\u206F\u202A\u202E\u206A\u200B\u200F\u200E\u206B\u206A\u200F\u202A\u200F\u200C\u206F\u200B\u206F\u202D\u200B\u200D\u202A\u206B\u206D\u200B\u206D\u200C\u202C\u206C\u202B\u200B\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreRipplesof495YearsDef.\u206F\u206E\u206C\u200B\u200B\u206D\u202C\u202D\u202C\u202A\u202B\u206F\u202D\u206E\u206A\u200E\u202C\u202C\u206C\u206B\u200F\u202B\u206E\u202E\u200E\u200B\u206D\u206E\u202D\u202B\u206B\u200F\u202E\u206F\u202B\u200F\u202B\u202A\u200E\u200E\u202E(BepinexPlugin.sequenceTable, FlandreRipplesof495YearsDef.\u202E\u202E\u206F\u202B\u200F\u202D\u200D\u206B\u206A\u202A\u206E\u202B\u202C\u202C\u206C\u206A\u200B\u206C\u200E\u200B\u202B\u200D\u200D\u206E\u200C\u200E\u206B\u200F\u206F\u200B\u200B\u202A\u206D\u200B\u200C\u200E\u206C\u206B\u206F\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, true, true, false, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Blue = 2,
				Black = 2,
				Red = 2
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish | Keyword.Disposable, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish | Keyword.Disposable, false, Keyword.Philosophy, Keyword.Philosophy, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(629129628), new List<string>());
		}

		static CardImages \u206F\u202C\u206E\u206A\u200B\u200B\u202C\u206E\u202E\u200E\u206F\u206C\u202A\u206E\u200F\u200D\u202B\u202C\u206D\u202B\u202D\u200E\u206E\u202D\u200C\u200B\u202B\u202E\u206E\u206B\u206E\u202B\u206E\u206D\u206D\u200E\u202E\u206A\u202D\u206F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u200D\u206D\u206F\u202B\u206E\u200B\u206A\u202E\u200E\u200D\u200C\u200C\u202D\u206A\u206A\u202C\u200E\u206E\u200C\u206E\u200B\u202D\u202C\u202D\u202D\u200B\u202E\u206A\u202C\u206C\u200E\u200C\u200F\u202A\u202D\u202C\u200B\u202A\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206B\u202A\u206A\u200B\u202C\u206D\u202D\u202C\u206B\u206E\u206F\u202A\u202E\u206A\u200B\u200F\u200E\u206B\u206A\u200F\u202A\u200F\u200C\u206F\u200B\u206F\u202D\u200B\u200D\u202A\u206B\u206D\u200B\u206D\u200C\u202C\u206C\u202B\u200B\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202E\u206F\u202B\u200F\u202D\u200D\u206B\u206A\u202A\u206E\u202B\u202C\u202C\u206C\u206A\u200B\u206C\u200E\u200B\u202B\u200D\u200D\u206E\u200C\u200E\u206B\u200F\u206F\u200B\u200B\u202A\u206D\u200B\u200C\u200E\u206C\u206B\u206F\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u206E\u206C\u200B\u200B\u206D\u202C\u202D\u202C\u202A\u202B\u206F\u202D\u206E\u206A\u200E\u202C\u202C\u206C\u206B\u200F\u202B\u206E\u202E\u200E\u200B\u206D\u206E\u202D\u202B\u206B\u200F\u202E\u206F\u202B\u200F\u202B\u202A\u200E\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreRipplesof495YearsDef))]
		public sealed class FlandreRipplesof495Years : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreRipplesof495YearsDef.FlandreRipplesof495Years.\u206C\u202D\u202E\u202B\u206B\u200D\u200D\u200C\u206B\u206D\u202E\u200B\u200E\u206D\u200E\u200E\u200F\u206B\u206F\u206B\u200C\u206F\u202E\u202C\u200E\u206E\u206F\u200F\u202B\u200E\u206C\u202B\u206F\u206F\u200F\u206B\u206A\u202A\u202E\u202A\u202E((float)FlandreRipplesof495YearsDef.FlandreRipplesof495Years.\u200B\u202A\u202A\u200E\u200C\u206C\u200B\u202A\u202E\u206F\u202D\u206E\u206B\u202C\u202D\u206B\u202D\u202C\u206A\u200B\u200D\u200F\u200F\u202E\u206F\u206A\u202D\u206E\u200B\u200D\u202E\u206A\u202C\u206D\u206E\u200B\u202B\u202E\u200D\u206F\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public string Ripplesof495Years1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-205369195), true, true);
				}
			}

			public string Ripplesof495Years2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1965427038), true, true);
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<Actions>d__8 <Actions>d__ = new FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<Actions>d__8(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<AfterUseAction>d__9 <AfterUseAction>d__ = new FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<AfterUseAction>d__9(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<AfterFollowPlayAction>d__10 <AfterFollowPlayAction>d__ = new FlandreRipplesof495YearsDef.FlandreRipplesof495Years.<AfterFollowPlayAction>d__10(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static int? \u200B\u202A\u202A\u200E\u200C\u206C\u200B\u202A\u202E\u206F\u202D\u206E\u206B\u202C\u202D\u206B\u202D\u202C\u206A\u200B\u200D\u200F\u200F\u202E\u206F\u206A\u202D\u206E\u200B\u200D\u202E\u206A\u202C\u206D\u206E\u200B\u202B\u202E\u200D\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206C\u202D\u202E\u202B\u206B\u200D\u200D\u200C\u206B\u206D\u202E\u200B\u200E\u206D\u200E\u200E\u200F\u206B\u206F\u206B\u200C\u206F\u202E\u202C\u200E\u206E\u206F\u200F\u202B\u200E\u206C\u202B\u206F\u206F\u200F\u206B\u206A\u202A\u202E\u202A\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			public static bool MusicChanged;

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (FlandreRipplesof495YearsDef.FlandreRipplesof495Years.GameRunController_BaseCardWeight_Patch.\u202C\u206F\u200F\u206A\u200D\u202D\u206F\u206B\u200F\u206D\u206F\u202B\u206C\u200F\u202B\u206F\u200F\u202C\u200F\u206A\u202B\u206E\u206D\u200D\u206C\u202B\u202B\u202A\u200F\u202E\u206A\u200B\u202D\u202E\u200F\u202A\u200B\u206B\u200B\u202B\u202E(FlandreRipplesof495YearsDef.FlandreRipplesof495Years.GameRunController_BaseCardWeight_Patch.\u206F\u200E\u206D\u206C\u206A\u206D\u206B\u202C\u206E\u202E\u206A\u200B\u206E\u206E\u200F\u200F\u206F\u200C\u206F\u206E\u200F\u206C\u206D\u206C\u206C\u206E\u202B\u206B\u200E\u206D\u202B\u206C\u206B\u200E\u202E\u202D\u202C\u202B\u206E\u202C\u202E(config), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1758090029)))
					{
						for (;;)
						{
							IL_001A:
							int num = -1893521910;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((~(num2 - -(1077406800 - 1702437457 - -1894744301 * -1881384597)) * -1455047369) ^ -117618492)) % 3U)
								{
								case 0U:
									goto IL_001A;
								case 2U:
									__result *= 0.25f;
									num = (int)((num3 * 2429552266U) ^ 443544524U);
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u206F\u200E\u206D\u206C\u206A\u206D\u206B\u202C\u206E\u202E\u206A\u200B\u206E\u206E\u200F\u200F\u206F\u200C\u206F\u206E\u200F\u206C\u206D\u206C\u206C\u206E\u202B\u206B\u200E\u206D\u202B\u206C\u206B\u200E\u202E\u202D\u202C\u202B\u206E\u202C\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u202C\u206F\u200F\u206A\u200D\u202D\u206F\u206B\u200F\u206D\u206F\u202B\u206C\u200F\u202B\u206F\u200F\u202C\u200F\u206A\u202B\u206E\u206D\u200D\u206C\u202B\u202B\u202A\u200F\u202E\u206A\u200B\u202D\u202E\u200F\u202A\u200B\u206B\u200B\u202B\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
