using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using LBoL.Base;
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
	public sealed class FlandreSisteroftheDevilDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1763101608);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreSisteroftheDevilDef.\u200B\u200D\u202E\u206E\u206D\u202B\u200D\u200B\u202D\u200F\u206D\u206C\u206A\u200E\u200D\u200B\u206E\u206E\u200C\u206E\u200F\u202E\u202D\u206A\u206F\u202A\u202E\u200B\u206D\u202C\u202D\u206F\u200E\u200F\u206C\u200B\u202C\u206B\u206E\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreSisteroftheDevilDef.\u206B\u206F\u200C\u200D\u206A\u200B\u202C\u200F\u202A\u206F\u200F\u200D\u200F\u206C\u200F\u206E\u206F\u202A\u206D\u202B\u202A\u200B\u200F\u206E\u206D\u206B\u202A\u206D\u206B\u206A\u200B\u200B\u202B\u202C\u200C\u206B\u200F\u206C\u202B\u200F\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSisteroftheDevilDef.\u200B\u202D\u200E\u206D\u202B\u202C\u206D\u200B\u206C\u206B\u206C\u202A\u200C\u202B\u200B\u206B\u200B\u200E\u206B\u200C\u202A\u202C\u200D\u200B\u202C\u202C\u206A\u206B\u200B\u200F\u206E\u200C\u206D\u202D\u202E\u206E\u206A\u206F\u206A\u202D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreSisteroftheDevilDef.\u202E\u202A\u206C\u202C\u206B\u206F\u202E\u200C\u206C\u202C\u206D\u200E\u202A\u206A\u200D\u202C\u202B\u206E\u202A\u200B\u202B\u206D\u206F\u206C\u206E\u200C\u200F\u206B\u206D\u202D\u206F\u206A\u202E\u202B\u202C\u202A\u206F\u206D\u200D\u206B\u202E(BepinexPlugin.sequenceTable, FlandreSisteroftheDevilDef.\u202B\u200D\u202C\u200C\u202E\u206E\u200D\u206E\u206A\u206B\u206D\u206C\u206F\u202A\u202A\u200E\u202A\u202D\u206F\u200E\u202E\u200E\u200D\u200D\u206B\u202E\u200C\u206F\u206B\u202A\u206E\u200D\u200D\u206A\u206C\u202C\u200C\u206C\u200B\u206F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, true, false, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden | Keyword.Ethereal | Keyword.Replenish, Keyword.Forbidden | Keyword.Ethereal | Keyword.Replenish, false, Keyword.Philosophy | Keyword.Upgrade | Keyword.Exile, Keyword.Philosophy | Keyword.Upgrade | Keyword.Exile, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1730391630) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(44778244) }, new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1163862077), new List<string>());
		}

		static CardImages \u200B\u200D\u202E\u206E\u206D\u202B\u200D\u200B\u202D\u200F\u206D\u206C\u206A\u200E\u200D\u200B\u206E\u206E\u200C\u206E\u200F\u202E\u202D\u206A\u206F\u202A\u202E\u200B\u206D\u202C\u202D\u206F\u200E\u200F\u206C\u200B\u202C\u206B\u206E\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u206F\u200C\u200D\u206A\u200B\u202C\u200F\u202A\u206F\u200F\u200D\u200F\u206C\u200F\u206E\u206F\u202A\u206D\u202B\u202A\u200B\u200F\u206E\u206D\u206B\u202A\u206D\u206B\u206A\u200B\u200B\u202B\u202C\u200C\u206B\u200F\u206C\u202B\u200F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200B\u202D\u200E\u206D\u202B\u202C\u206D\u200B\u206C\u206B\u206C\u202A\u200C\u202B\u200B\u206B\u200B\u200E\u206B\u200C\u202A\u202C\u200D\u200B\u202C\u202C\u206A\u206B\u200B\u200F\u206E\u200C\u206D\u202D\u202E\u206E\u206A\u206F\u206A\u202D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u200D\u202C\u200C\u202E\u206E\u200D\u206E\u206A\u206B\u206D\u206C\u206F\u202A\u202A\u200E\u202A\u202D\u206F\u200E\u202E\u200E\u200D\u200D\u206B\u202E\u200C\u206F\u206B\u202A\u206E\u200D\u200D\u206A\u206C\u202C\u200C\u206C\u200B\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u202A\u206C\u202C\u206B\u206F\u202E\u200C\u206C\u202C\u206D\u200E\u202A\u206A\u200D\u202C\u202B\u206E\u202A\u200B\u202B\u206D\u206F\u206C\u206E\u200C\u200F\u206B\u206D\u202D\u206F\u206A\u202E\u202B\u202C\u202A\u206F\u206D\u200D\u206B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreSisteroftheDevilDef))]
		public sealed class FlandreSisteroftheDevil : FlandreCard
		{
			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.\u202C\u206B\u200C\u202A\u202B\u206E\u206D\u206F\u202E\u202E\u200E\u202D\u200B\u202B\u206F\u206F\u200B\u202E\u206E\u200C\u200D\u206C\u202A\u206C\u206A\u200C\u200C\u206F\u200F\u200B\u206D\u200B\u206E\u202D\u200F\u206B\u202E\u202E\u200E\u206D\u202E(this).GetValueOrDefault() * 2
					};
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<GameEventArgs>(FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.\u206E\u200F\u202C\u206C\u206F\u206A\u202D\u202C\u206F\u200D\u200C\u200C\u200B\u200B\u206C\u206A\u202E\u202D\u206D\u200C\u200E\u206D\u202E\u200B\u206E\u200F\u200B\u200D\u200B\u202D\u200E\u200F\u200D\u202B\u200B\u202B\u202B\u202D\u200D\u202E\u202E(FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.\u206F\u200B\u200F\u202B\u202C\u200D\u206D\u200E\u200F\u206C\u206E\u206B\u202D\u200D\u206F\u206E\u206A\u206F\u206F\u202D\u206A\u206C\u202A\u202B\u200F\u202A\u206A\u200E\u206B\u202D\u206D\u202D\u206E\u206B\u206A\u202B\u206C\u202A\u202C\u202C\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
			{
				FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.<OnBattleStarted>d__4 <OnBattleStarted>d__ = new FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.<OnBattleStarted>d__4(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.<Actions>d__5 <Actions>d__ = new FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202C\u206B\u200C\u202A\u202B\u206E\u206D\u206F\u202E\u202E\u200E\u202D\u200B\u202B\u206F\u206F\u200B\u202E\u206E\u200C\u200D\u206C\u202A\u206C\u206A\u200C\u200C\u206F\u200F\u200B\u206D\u200B\u206E\u202D\u200F\u206B\u202E\u202E\u200E\u206D\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u206F\u200B\u200F\u202B\u202C\u200D\u206D\u200E\u200F\u206C\u206E\u206B\u202D\u200D\u206F\u206E\u206A\u206F\u206F\u202D\u206A\u206C\u202A\u202B\u200F\u202A\u206A\u200E\u206B\u202D\u206D\u202D\u206E\u206B\u206A\u202B\u206C\u202A\u202C\u202C\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u206E\u200F\u202C\u206C\u206F\u206A\u202D\u202C\u206F\u200D\u200C\u200C\u200B\u200B\u206C\u206A\u202E\u202D\u206D\u200C\u200E\u206D\u202E\u200B\u206E\u200F\u200B\u200D\u200B\u202D\u200E\u200F\u200D\u202B\u200B\u202B\u202B\u202D\u200D\u202E\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.GameRunController_BaseCardWeight_Patch.\u200C\u206B\u202A\u206A\u206A\u206E\u206D\u200B\u200B\u200E\u202B\u206C\u202D\u200D\u200D\u200B\u202C\u202D\u202E\u200D\u202A\u202A\u202B\u202B\u206F\u206C\u200E\u200F\u200E\u202B\u200C\u202A\u206B\u200F\u200C\u200B\u202C\u202E\u200F\u202A\u202E(FlandreSisteroftheDevilDef.FlandreSisteroftheDevil.GameRunController_BaseCardWeight_Patch.\u202A\u206D\u200B\u202C\u206B\u202D\u200D\u206C\u206D\u202D\u206E\u206F\u202A\u202B\u202B\u206B\u202B\u206C\u206B\u200F\u202C\u200C\u202B\u200B\u206A\u200F\u206B\u200B\u202C\u206C\u200E\u202B\u202A\u200E\u200C\u206E\u206F\u206B\u200C\u202C\u202E(config), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1158066898)))
					{
						for (;;)
						{
							IL_001A:
							int num = 1053045801;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-(~num2) + ~-997813102)) % 3U)
								{
								case 0U:
									goto IL_001A;
								case 1U:
									__result *= 0.25f;
									num = (int)((num3 * 1270214398U) ^ 2228259417U);
									continue;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u202A\u206D\u200B\u202C\u206B\u202D\u200D\u206C\u206D\u202D\u206E\u206F\u202A\u202B\u202B\u206B\u202B\u206C\u206B\u200F\u202C\u200C\u202B\u200B\u206A\u200F\u206B\u200B\u202C\u206C\u200E\u202B\u202A\u200E\u200C\u206E\u206F\u206B\u200C\u202C\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u200C\u206B\u202A\u206A\u206A\u206E\u206D\u200B\u200B\u200E\u202B\u206C\u202D\u200D\u200D\u200B\u202C\u202D\u202E\u200D\u202A\u202A\u202B\u202B\u206F\u206C\u200E\u200F\u200E\u202B\u200C\u202A\u206B\u200F\u200C\u200B\u202C\u202E\u200F\u202A\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
