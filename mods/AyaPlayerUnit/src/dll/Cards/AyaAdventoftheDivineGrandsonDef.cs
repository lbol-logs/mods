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
	public sealed class AyaAdventoftheDivineGrandsonDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1181038892);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaAdventoftheDivineGrandsonDef.\u202D\u202A\u200B\u200B\u200C\u200B\u200D\u200B\u200E\u206A\u206C\u202D\u202A\u200D\u202D\u206F\u202E\u200B\u200B\u206B\u206A\u202D\u202E\u202C\u206E\u200F\u206D\u200B\u200D\u200E\u200E\u206F\u202C\u206E\u200C\u202C\u206C\u206F\u200D\u202D\u202E(BepinexPlugin.embeddedSource);
			AyaAdventoftheDivineGrandsonDef.\u200C\u202D\u200C\u200F\u206B\u202E\u202D\u202D\u206C\u200F\u200C\u200B\u200C\u206F\u206A\u206D\u200F\u200B\u202E\u200F\u202E\u202B\u202B\u206E\u206C\u200E\u202B\u206B\u200C\u200B\u206F\u200B\u206E\u202B\u200B\u206A\u206B\u200C\u206B\u200E\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaAdventoftheDivineGrandsonDef.\u200E\u206B\u206C\u206F\u202A\u202E\u202B\u206B\u206F\u206E\u200D\u202D\u200F\u200D\u206C\u206D\u206A\u202B\u206D\u200D\u200B\u202E\u200B\u206F\u202D\u202E\u200B\u202A\u202D\u206A\u202A\u206C\u206A\u206F\u206A\u206F\u202C\u202C\u202B\u206C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaAdventoftheDivineGrandsonDef.\u206B\u202C\u206D\u206D\u202C\u200B\u202A\u202D\u206E\u200F\u200F\u206E\u202B\u200D\u200D\u202E\u206B\u200D\u206D\u200D\u206F\u206D\u202B\u206C\u202C\u206F\u200B\u206F\u200C\u200B\u206B\u206F\u206D\u206F\u200B\u200F\u202D\u200D\u200C\u202E(BepinexPlugin.sequenceTable, AyaAdventoftheDivineGrandsonDef.\u202E\u202C\u200E\u206C\u202B\u200F\u202C\u206A\u200E\u200C\u206B\u206E\u202A\u202E\u200C\u202C\u202B\u200F\u202E\u206E\u200E\u206A\u202A\u206F\u202B\u200B\u206E\u206C\u200E\u206A\u206E\u200B\u206E\u200B\u200E\u206B\u200D\u202B\u200D\u202A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, false, true, false, false, false, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Red = 3,
				Green = 3
			}, new ManaGroup?(new ManaGroup
			{
				Red = 3,
				Green = 3
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 9
			}), new ManaGroup?(new ManaGroup
			{
				Philosophy = 9
			}), null, null, new int?(1), null, null, null, null, null, null, null, null, null, null, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish, false, Keyword.Tool, Keyword.Tool, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-694918417), "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-118924297), new List<string>());
		}

		static CardImages \u202D\u202A\u200B\u200B\u200C\u200B\u200D\u200B\u200E\u206A\u206C\u202D\u202A\u200D\u202D\u206F\u202E\u200B\u200B\u206B\u206A\u202D\u202E\u202C\u206E\u200F\u206D\u200B\u200D\u200E\u200E\u206F\u202C\u206E\u200C\u202C\u206C\u206F\u200D\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u202D\u200C\u200F\u206B\u202E\u202D\u202D\u206C\u200F\u200C\u200B\u200C\u206F\u206A\u206D\u200F\u200B\u202E\u200F\u202E\u202B\u202B\u206E\u206C\u200E\u202B\u206B\u200C\u200B\u206F\u200B\u206E\u202B\u200B\u206A\u206B\u200C\u206B\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200E\u206B\u206C\u206F\u202A\u202E\u202B\u206B\u206F\u206E\u200D\u202D\u200F\u200D\u206C\u206D\u206A\u202B\u206D\u200D\u200B\u202E\u200B\u206F\u202D\u202E\u200B\u202A\u202D\u206A\u202A\u206C\u206A\u206F\u206A\u206F\u202C\u202C\u202B\u206C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202C\u200E\u206C\u202B\u200F\u202C\u206A\u200E\u200C\u206B\u206E\u202A\u202E\u200C\u202C\u202B\u200F\u202E\u206E\u200E\u206A\u202A\u206F\u202B\u200B\u206E\u206C\u200E\u206A\u206E\u200B\u206E\u200B\u200E\u206B\u200D\u202B\u200D\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u202C\u206D\u206D\u202C\u200B\u202A\u202D\u206E\u200F\u200F\u206E\u202B\u200D\u200D\u202E\u206B\u200D\u206D\u200D\u206F\u206D\u202B\u206C\u202C\u206F\u200B\u206F\u200C\u200B\u206B\u206F\u206D\u206F\u200B\u200F\u202D\u200D\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaAdventoftheDivineGrandsonDef))]
		public sealed class AyaAdventoftheDivineGrandson : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1075896301), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(671930366), true, true);
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.<Actions>d__6 <Actions>d__ = new AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.<Actions>d__6(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.<AfterUseAction>d__7 <AfterUseAction>d__ = new AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.<AfterUseAction>d__7(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public static bool MusicChanged;

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.GameRunController_BaseCardWeight_Patch.\u200D\u202C\u206F\u206E\u202A\u200D\u202A\u202A\u206C\u206A\u202A\u202D\u206B\u206D\u202E\u200F\u200F\u206D\u200C\u206B\u202A\u206C\u200E\u200E\u202A\u202E\u200B\u200E\u206D\u206B\u200F\u206F\u202D\u206B\u206C\u200B\u206B\u202E\u202C\u202C\u202E(AyaAdventoftheDivineGrandsonDef.AyaAdventoftheDivineGrandson.GameRunController_BaseCardWeight_Patch.\u202A\u206C\u206F\u202E\u202D\u202C\u200F\u206A\u200B\u202D\u200B\u200B\u206A\u206A\u200F\u202B\u206C\u206B\u200C\u200D\u200D\u206E\u206D\u200C\u206B\u202D\u206C\u206B\u200D\u206F\u206F\u206E\u206A\u206F\u200F\u202A\u202C\u200B\u200D\u202A\u202E(config), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1991537198)))
					{
						for (;;)
						{
							IL_001A:
							int num = -1375283935;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(-num2 - -430565419 - ~-247444800 - 1524635648)) % 3U)
								{
								case 1U:
									__result *= 0.25f;
									num = (int)((num3 * 1224728626U) ^ 1363426937U);
									continue;
								case 2U:
									goto IL_001A;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u202A\u206C\u206F\u202E\u202D\u202C\u200F\u206A\u200B\u202D\u200B\u200B\u206A\u206A\u200F\u202B\u206C\u206B\u200C\u200D\u200D\u206E\u206D\u200C\u206B\u202D\u206C\u206B\u200D\u206F\u206F\u206E\u206A\u206F\u200F\u202A\u202C\u200B\u200D\u202A\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u200D\u202C\u206F\u206E\u202A\u200D\u202A\u202A\u206C\u206A\u202A\u202D\u206B\u206D\u202E\u200F\u200F\u206D\u200C\u206B\u202A\u206C\u200E\u200E\u202A\u202E\u200B\u200E\u206D\u206B\u200F\u206F\u202D\u206B\u206C\u200B\u206B\u202E\u202C\u202C\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
