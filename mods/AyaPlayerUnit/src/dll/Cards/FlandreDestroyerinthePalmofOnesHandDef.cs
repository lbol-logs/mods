using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreDestroyerinthePalmofOnesHandDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-900838107);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreDestroyerinthePalmofOnesHandDef.\u206A\u206A\u200B\u202E\u200F\u206E\u206A\u202A\u200B\u202C\u206F\u206A\u206F\u206A\u200E\u206B\u202B\u202C\u200E\u202B\u206B\u202B\u206E\u202A\u206D\u206A\u200E\u202E\u202E\u200D\u202D\u200D\u206A\u200D\u200D\u206C\u206A\u202A\u206E\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreDestroyerinthePalmofOnesHandDef.\u206F\u202A\u206A\u200F\u206D\u200D\u200E\u202E\u202E\u202E\u206E\u202C\u200B\u202A\u206D\u202C\u200E\u202B\u206C\u206D\u206B\u202A\u206E\u202A\u202E\u206B\u202D\u206C\u200C\u206A\u206D\u202D\u206B\u202B\u202E\u206D\u206A\u206C\u200B\u202B\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreDestroyerinthePalmofOnesHandDef.\u200F\u206A\u202E\u200B\u202D\u206F\u200B\u206E\u202B\u202B\u206C\u206E\u200D\u202E\u202A\u200D\u200B\u202D\u202B\u200B\u200F\u202C\u202A\u206D\u200D\u202B\u202B\u206B\u202B\u206D\u206C\u206F\u202B\u200C\u202D\u206B\u202D\u206B\u202B\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreDestroyerinthePalmofOnesHandDef.\u206F\u202A\u200D\u202D\u200C\u200B\u206E\u200B\u206F\u200E\u206F\u202A\u202C\u206D\u202D\u202C\u202B\u206B\u202B\u202A\u200E\u202D\u206A\u206E\u202D\u206D\u202A\u200E\u200E\u206C\u200F\u206F\u206F\u206E\u202D\u206D\u202B\u206D\u200B\u206C\u202E(BepinexPlugin.sequenceTable, FlandreDestroyerinthePalmofOnesHandDef.\u206E\u200C\u200B\u206F\u206D\u202B\u202B\u202B\u202A\u202E\u202B\u206D\u206F\u200E\u200F\u202D\u206A\u202C\u202E\u206A\u200F\u200E\u200D\u202A\u206D\u206B\u202E\u200C\u202B\u202D\u202D\u206C\u206E\u206E\u200C\u206B\u200C\u200E\u200D\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-397494503), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000), 0, true, true, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Any = 3,
				Blue = 1
			}, null, null, null, null, new int?(60), null, null, null, null, null, new int?(6), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1958891809),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-220379302)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1958891809),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-344256836)
			}, new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-801908152), new List<string>());
		}

		static CardImages \u206A\u206A\u200B\u202E\u200F\u206E\u206A\u202A\u200B\u202C\u206F\u206A\u206F\u206A\u200E\u206B\u202B\u202C\u200E\u202B\u206B\u202B\u206E\u202A\u206D\u206A\u200E\u202E\u202E\u200D\u202D\u200D\u206A\u200D\u200D\u206C\u206A\u202A\u206E\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u202A\u206A\u200F\u206D\u200D\u200E\u202E\u202E\u202E\u206E\u202C\u200B\u202A\u206D\u202C\u200E\u202B\u206C\u206D\u206B\u202A\u206E\u202A\u202E\u206B\u202D\u206C\u200C\u206A\u206D\u202D\u206B\u202B\u202E\u206D\u206A\u206C\u200B\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u206A\u202E\u200B\u202D\u206F\u200B\u206E\u202B\u202B\u206C\u206E\u200D\u202E\u202A\u200D\u200B\u202D\u202B\u200B\u200F\u202C\u202A\u206D\u200D\u202B\u202B\u206B\u202B\u206D\u206C\u206F\u202B\u200C\u202D\u206B\u202D\u206B\u202B\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u200C\u200B\u206F\u206D\u202B\u202B\u202B\u202A\u202E\u202B\u206D\u206F\u200E\u200F\u202D\u206A\u202C\u202E\u206A\u200F\u200E\u200D\u202A\u206D\u206B\u202E\u200C\u202B\u202D\u202D\u206C\u206E\u206E\u200C\u206B\u200C\u200E\u200D\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u202A\u200D\u202D\u200C\u200B\u206E\u200B\u206F\u200E\u206F\u202A\u202C\u206D\u202D\u202C\u202B\u206B\u202B\u202A\u200E\u202D\u206A\u206E\u202D\u206D\u202A\u200E\u200E\u206C\u200F\u206F\u206F\u206E\u202D\u206D\u202B\u206D\u200B\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreDestroyerinthePalmofOnesHandDef))]
		public sealed class FlandreDestroyerinthePalmofOnesHand : FlandreCard
		{
			public string DestroyerinthePalmofOnesHand1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(348522606), true, true);
				}
			}

			public string DestroyerinthePalmofOnesHand2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1017452122), true, true);
				}
			}

			public override int AdditionalDamage
			{
				get
				{
					return FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u202B\u200B\u202A\u200E\u206D\u200C\u206F\u202B\u202D\u206D\u202D\u206F\u206B\u200C\u206F\u206F\u202A\u206E\u206A\u206A\u200E\u202D\u206B\u200B\u206A\u202A\u200C\u200E\u200E\u206A\u206C\u200B\u206A\u206D\u206F\u206B\u202A\u202C\u200E\u202A\u202E(this).GetValueOrDefault() * 30 + base.GetSeLevel<FlandreCalamitySeDef.FlandreCalamitySe>() * this.FlandreValue1;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u202B\u200B\u202A\u200E\u206D\u200C\u206F\u202B\u202D\u206D\u202D\u206F\u206B\u200C\u206F\u206F\u202A\u206E\u206A\u206A\u200E\u202D\u206B\u200B\u206A\u202A\u200C\u200E\u200E\u206A\u206C\u200B\u206A\u206D\u206F\u206B\u202A\u202C\u200E\u202A\u202E(this).GetValueOrDefault() * 3;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.HandleBattleEvent<GameEventArgs>(FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u206D\u202D\u206C\u202C\u206F\u206A\u202C\u200C\u200C\u206D\u202C\u206E\u202A\u206C\u206F\u202D\u206F\u202E\u202A\u206F\u206A\u206D\u206B\u202C\u206D\u206F\u200B\u202D\u206C\u206F\u206D\u202B\u200D\u202E\u200F\u200B\u200D\u200C\u200C\u206C\u202E(FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u206D\u200E\u200F\u206E\u200C\u200E\u202C\u206F\u202D\u200E\u202A\u200D\u206C\u206B\u202E\u202D\u206E\u206C\u200D\u200F\u206E\u200E\u200F\u202D\u200F\u202D\u200F\u206E\u200D\u206A\u202A\u202A\u202C\u202D\u206A\u206E\u206E\u200B\u206C\u200D\u202E(this)), new GameEventHandler<GameEventArgs>(this.OnBattleStarted), (GameEventPriority)0);
			}

			private void OnBattleStarted(GameEventArgs args)
			{
				FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.ScenePlayed = false;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.<Actions>d__13 <Actions>d__ = new FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.<Actions>d__13(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[MethodImpl(MethodImplOptions.NoInlining)]
			static FlandreDestroyerinthePalmofOnesHand()
			{
				for (;;)
				{
					IL_0017:
					int num = 684113224;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-(~num2) * -1623885689) ^ 244477581)) % 4U)
						{
						case 1U:
							FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.ScenePlayed = false;
							num = (int)((num3 * 1490836957U) ^ 2305632319U);
							continue;
						case 2U:
							FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.scene2 = FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u206C\u202E\u200D\u206D\u202C\u202D\u202A\u206A\u206E\u202B\u200D\u200D\u200C\u206F\u206E\u200F\u202B\u206D\u202A\u200B\u206B\u202A\u206F\u206C\u206C\u200B\u206B\u202D\u202A\u206A\u202A\u206E\u200C\u206C\u206A\u200E\u202A\u206A\u200F\u206B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-536779606), null);
							num = (int)((num3 * 716481067U) ^ 2947072733U);
							continue;
						case 3U:
							goto IL_0017;
						}
						return;
					}
				}
			}

			static int? \u202B\u200B\u202A\u200E\u206D\u200C\u206F\u202B\u202D\u206D\u202D\u206F\u206B\u200C\u206F\u206F\u202A\u206E\u206A\u206A\u200E\u202D\u206B\u200B\u206A\u202A\u200C\u200E\u200E\u206A\u206C\u200B\u206A\u206D\u206F\u206B\u202A\u202C\u200E\u202A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u206D\u200E\u200F\u206E\u200C\u200E\u202C\u206F\u202D\u200E\u202A\u200D\u206C\u206B\u202E\u202D\u206E\u206C\u200D\u200F\u206E\u200E\u200F\u202D\u200F\u202D\u200F\u206E\u200D\u206A\u202A\u202A\u202C\u202D\u206A\u206E\u206E\u200B\u206C\u200D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u206D\u202D\u206C\u202C\u206F\u206A\u202C\u200C\u200C\u206D\u202C\u206E\u202A\u206C\u206F\u202D\u206F\u202E\u202A\u206F\u206A\u206D\u206B\u202C\u206D\u206F\u200B\u202D\u206C\u206F\u206D\u202B\u200D\u202E\u200F\u200B\u200D\u200C\u200C\u206C\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static GameObject \u206C\u202E\u200D\u206D\u202C\u202D\u202A\u206A\u206E\u202B\u200D\u200D\u200C\u206F\u206E\u200F\u202B\u206D\u202A\u200B\u206B\u202A\u206F\u206C\u206C\u200B\u206B\u202D\u202A\u206A\u202A\u206E\u200C\u206C\u206A\u200E\u202A\u206A\u200F\u206B\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			private static GameObject scene1 = FlandreDestroyerinthePalmofOnesHandDef.FlandreDestroyerinthePalmofOnesHand.\u206C\u202E\u200D\u206D\u202C\u202D\u202A\u206A\u206E\u202B\u200D\u200D\u200C\u206F\u206E\u200F\u202B\u206D\u202A\u200B\u206B\u202A\u206F\u206C\u206C\u200B\u206B\u202D\u202A\u206A\u202A\u206E\u200C\u206C\u206A\u200E\u202A\u206A\u200F\u206B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(22737287), null);

			private static GameObject scene2;

			private static bool ScenePlayed;
		}
	}
}
