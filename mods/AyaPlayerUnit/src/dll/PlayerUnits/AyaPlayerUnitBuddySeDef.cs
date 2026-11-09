using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.PlayerUnits
{
	public sealed class AyaPlayerUnitBuddySeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-821533749);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaPlayerUnitBuddySeDef.\u200C\u206B\u200F\u202E\u202D\u200C\u200E\u200F\u206D\u206A\u200D\u202A\u200D\u206F\u200F\u206F\u200E\u200D\u202A\u206A\u206A\u206F\u206A\u202C\u200E\u206F\u202A\u202E\u206C\u206C\u206E\u206F\u200B\u202D\u202A\u202E\u202E\u200F\u206C\u206A\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return AyaPlayerUnitBuddySeDef.\u202C\u206E\u200E\u200C\u202D\u206F\u206E\u200E\u202C\u200B\u206A\u202C\u202D\u200C\u200E\u206D\u206C\u206B\u202E\u202E\u202A\u206D\u206C\u200F\u206C\u206E\u202C\u202A\u206B\u202B\u200F\u200F\u200E\u202B\u206E\u202B\u206D\u206D\u206C\u202C\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(878035651), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(AyaPlayerUnitBuddySeDef.\u200C\u200D\u206D\u200E\u200B\u206C\u200B\u200D\u200D\u206C\u206F\u206D\u206C\u200C\u206C\u202A\u200D\u206E\u200F\u206D\u202B\u202E\u200C\u206B\u202A\u202A\u202D\u200B\u200F\u200B\u200B\u202C\u206B\u206E\u200B\u206E\u202A\u206A\u206C\u200E\u202E(BepinexPlugin.sequenceTable, AyaPlayerUnitBuddySeDef.\u202D\u202D\u206B\u206D\u206F\u206A\u206B\u200F\u202D\u206E\u202A\u202B\u200D\u202B\u200F\u200D\u202A\u200B\u206E\u202D\u206F\u200B\u206A\u206D\u200C\u200B\u200F\u200C\u200E\u202C\u206D\u202A\u202E\u200C\u206A\u206E\u206E\u202D\u206B\u200F\u202E(typeof(StatusEffectConfig).TypeHandle)), "", 0, StatusEffectType.Special, false, true, null, false, new StackType?(StackType.Add), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.None, new List<string>(), null, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1525490387), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-834184750));
		}

		static BatchLocalization \u200C\u206B\u200F\u202E\u202D\u200C\u200E\u200F\u206D\u206A\u200D\u202A\u200D\u206F\u200F\u206F\u200E\u200D\u202A\u206A\u206A\u206F\u206A\u202C\u200E\u206F\u202A\u202E\u206C\u206C\u206E\u206F\u200B\u202D\u202A\u202E\u202E\u200F\u206C\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u202C\u206E\u200E\u200C\u202D\u206F\u206E\u200E\u202C\u200B\u206A\u202C\u202D\u200C\u200E\u206D\u206C\u206B\u202E\u202E\u202A\u206D\u206C\u200F\u206C\u206E\u202C\u202A\u206B\u202B\u200F\u200F\u200E\u202B\u206E\u202B\u206D\u206D\u206C\u202C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u202D\u202D\u206B\u206D\u206F\u206A\u206B\u200F\u202D\u206E\u202A\u202B\u200D\u202B\u200F\u200D\u202A\u200B\u206E\u202D\u206F\u200B\u206A\u206D\u200C\u200B\u200F\u200C\u200E\u202C\u206D\u202A\u202E\u200C\u206A\u206E\u206E\u202D\u206B\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u200D\u206D\u200E\u200B\u206C\u200B\u200D\u200D\u206C\u206F\u206D\u206C\u200C\u206C\u202A\u200D\u206E\u200F\u206D\u202B\u202E\u200C\u206B\u202A\u202A\u202D\u200B\u200F\u200B\u200B\u202C\u206B\u206E\u200B\u206E\u202A\u206A\u206C\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaPlayerUnitBuddySeDef))]
		public sealed class AyaPlayerUnitBuddySe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				EnemyUnit enemyUnit = AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u206F\u206A\u200D\u202B\u202B\u206A\u202D\u200E\u200E\u202B\u202E\u200C\u202E\u206D\u202E\u200B\u200D\u200E\u200E\u206D\u200D\u202D\u206B\u202A\u200D\u202E\u200C\u202C\u202C\u200B\u200E\u206B\u202E\u206D\u202B\u200F\u206E\u206C\u202A\u206C\u202E(this) as EnemyUnit;
				enemyUnit._turnMoves.Clear();
				for (;;)
				{
					IL_0017:
					int num = 706414349;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 ^ ~(-1630053089 * -1822235908)) * -1662138103)) % 8U)
						{
						case 0U:
							goto IL_0017;
						case 1U:
							AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u200F\u206B\u202C\u202B\u200F\u200F\u200B\u202B\u200E\u206B\u200F\u200F\u200F\u200C\u206E\u206B\u200E\u206B\u202B\u206E\u206E\u206D\u206A\u202D\u202C\u206A\u202E\u206F\u206A\u202C\u206E\u200D\u200C\u202A\u200F\u206D\u200F\u206B\u206C\u206A\u202E(enemyUnit);
							num = (int)((num3 * 266506010U) ^ 3776756612U);
							continue;
						case 2U:
						{
							Intention intention;
							intention.Source = enemyUnit;
							num = (int)((num3 * 3960477627U) ^ 1196424674U);
							continue;
						}
						case 3U:
						{
							Intention intention = AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u206B\u200D\u202E\u206C\u200E\u206C\u206A\u200F\u206B\u202C\u200F\u206D\u202B\u206E\u202A\u202B\u206D\u200B\u206B\u202E\u202B\u202C\u206C\u206F\u200C\u206A\u200E\u202D\u206D\u202B\u202C\u202E\u202E\u202C\u206B\u200E\u202A\u200B\u206D\u206D\u202E();
							num = (int)((num3 * 182291193U) ^ 3941742786U);
							continue;
						}
						case 5U:
							base.ReactOwnerEvent<GameEventArgs>(AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u202E\u206A\u202B\u206C\u202B\u206F\u202A\u202A\u206C\u206D\u200E\u206A\u200E\u200F\u200F\u202E\u202E\u200E\u206E\u200F\u202D\u206F\u202B\u200B\u206F\u206C\u202E\u206A\u200E\u200D\u200F\u200C\u202B\u206C\u200C\u206F\u200E\u202C\u206E\u202E\u202E(AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u202B\u202C\u200D\u202B\u206B\u200E\u202C\u202B\u202C\u202C\u202B\u206B\u200C\u206A\u206D\u206C\u206C\u202E\u206D\u200C\u200F\u200D\u200B\u200F\u202D\u202A\u206C\u200F\u202A\u202E\u206A\u202B\u202B\u202D\u206E\u202E\u202D\u200F\u202A\u200C\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnRoundStarted));
							num = (int)((num3 * 2628137181U) ^ 3295205118U);
							continue;
						case 6U:
							AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u202B\u200E\u200B\u200E\u202B\u200E\u202D\u206F\u200D\u200F\u202E\u206E\u206A\u200F\u206A\u206F\u202D\u200E\u206A\u202B\u202C\u200F\u200B\u200C\u206E\u202E\u206C\u206A\u202D\u200C\u206D\u202E\u200B\u206E\u200B\u200C\u200C\u202B\u200D\u200C\u202E(enemyUnit);
							num = (int)((num3 * 4158794024U) ^ 3374964000U);
							continue;
						case 7U:
						{
							Intention intention;
							enemyUnit._turnMoves.Add(AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u206E\u206E\u206B\u202A\u200F\u200F\u200B\u202A\u202E\u202C\u206B\u200D\u206E\u206A\u206C\u200F\u202D\u200D\u202A\u206D\u202A\u206C\u202C\u200B\u206E\u200E\u202B\u206E\u202A\u202B\u206B\u206B\u200B\u202E\u202E\u206F\u202A\u206B\u202E\u202C\u202E(intention, new EnemyMoveAction[] { AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u202D\u202A\u202E\u202B\u202C\u202A\u200D\u202E\u206B\u200E\u206E\u202B\u206C\u202C\u200D\u202B\u206D\u200C\u206C\u202C\u206C\u206D\u206A\u200C\u202C\u206C\u202B\u206A\u206D\u206B\u202A\u202D\u202C\u200F\u200D\u206D\u206C\u206B\u202A\u206C\u202E(enemyUnit, null, true) }));
							AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.\u200B\u202E\u206E\u206F\u206C\u202D\u202D\u202A\u200B\u202D\u202B\u202C\u202E\u200D\u202A\u200B\u202A\u206D\u206E\u200F\u206D\u202E\u206D\u200D\u202D\u202D\u200D\u202A\u206A\u202B\u202A\u200F\u200C\u202B\u200F\u206F\u202C\u206D\u200C\u202E(enemyUnit).Add(intention);
							num = (int)((num3 * 2522073072U) ^ 2767856730U);
							continue;
						}
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnRoundStarted(GameEventArgs arg)
			{
				AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.<OnRoundStarted>d__1 <OnRoundStarted>d__ = new AyaPlayerUnitBuddySeDef.AyaPlayerUnitBuddySe.<OnRoundStarted>d__1(-2);
				<OnRoundStarted>d__.<>4__this = this;
				return <OnRoundStarted>d__;
			}

			static Unit \u206F\u206A\u200D\u202B\u202B\u206A\u202D\u200E\u200E\u202B\u202E\u200C\u202E\u206D\u202E\u200B\u200D\u200E\u200E\u206D\u200D\u202D\u206B\u202A\u200D\u202E\u200C\u202C\u202C\u200B\u200E\u206B\u202E\u206D\u202B\u200F\u206E\u206C\u202A\u206C\u202E(StatusEffect A_0)
			{
				return A_0.Owner;
			}

			static void \u202B\u200E\u200B\u200E\u202B\u200E\u202D\u206F\u200D\u200F\u202E\u206E\u206A\u200F\u206A\u206F\u202D\u200E\u206A\u202B\u202C\u200F\u200B\u200C\u206E\u202E\u206C\u206A\u202D\u200C\u206D\u202E\u200B\u206E\u200B\u200C\u200C\u202B\u200D\u200C\u202E(EnemyUnit A_0)
			{
				A_0.ClearIntentions();
			}

			static Intention \u206B\u200D\u202E\u206C\u200E\u206C\u206A\u200F\u206B\u202C\u200F\u206D\u202B\u206E\u202A\u202B\u206D\u200B\u206B\u202E\u202B\u202C\u206C\u206F\u200C\u206A\u200E\u202D\u206D\u202B\u202C\u202E\u202E\u202C\u206B\u200E\u202A\u200B\u206D\u206D\u202E()
			{
				return Intention.DoNothing();
			}

			static EnemyMoveAction \u202D\u202A\u202E\u202B\u202C\u202A\u200D\u202E\u206B\u200E\u206E\u202B\u206C\u202C\u200D\u202B\u206D\u200C\u206C\u202C\u206C\u206D\u206A\u200C\u202C\u206C\u202B\u206A\u206D\u206B\u202A\u202D\u202C\u200F\u200D\u206D\u206C\u206B\u202A\u206C\u202E(EnemyUnit A_0, string A_1, bool A_2)
			{
				return new EnemyMoveAction(A_0, A_1, A_2);
			}

			static SimpleEnemyMove \u206E\u206E\u206B\u202A\u200F\u200F\u200B\u202A\u202E\u202C\u206B\u200D\u206E\u206A\u206C\u200F\u202D\u200D\u202A\u206D\u202A\u206C\u202C\u200B\u206E\u200E\u202B\u206E\u202A\u202B\u206B\u206B\u200B\u202E\u202E\u206F\u202A\u206B\u202E\u202C\u202E(Intention A_0, IEnumerable<BattleAction> A_1)
			{
				return new SimpleEnemyMove(A_0, A_1);
			}

			static List<Intention> \u200B\u202E\u206E\u206F\u206C\u202D\u202D\u202A\u200B\u202D\u202B\u202C\u202E\u200D\u202A\u200B\u202A\u206D\u206E\u200F\u206D\u202E\u206D\u200D\u202D\u202D\u200D\u202A\u206A\u202B\u202A\u200F\u200C\u202B\u200F\u206F\u202C\u206D\u200C\u202E(EnemyUnit A_0)
			{
				return A_0.Intentions;
			}

			static void \u200F\u206B\u202C\u202B\u200F\u200F\u200B\u202B\u200E\u206B\u200F\u200F\u200F\u200C\u206E\u206B\u200E\u206B\u202B\u206E\u206E\u206D\u206A\u202D\u202C\u206A\u202E\u206F\u206A\u202C\u206E\u200D\u200C\u202A\u200F\u206D\u200F\u206B\u206C\u206A\u202E(EnemyUnit A_0)
			{
				A_0.NotifyIntentionsChanged();
			}

			static BattleController \u202B\u202C\u200D\u202B\u206B\u200E\u202C\u202B\u202C\u202C\u202B\u206B\u200C\u206A\u206D\u206C\u206C\u202E\u206D\u200C\u200F\u200D\u200B\u200F\u202D\u202A\u206C\u200F\u202A\u202E\u206A\u202B\u202B\u202D\u206E\u202E\u202D\u200F\u202A\u200C\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u202E\u206A\u202B\u206C\u202B\u206F\u202A\u202A\u206C\u206D\u200E\u206A\u200E\u200F\u200F\u202E\u202E\u200E\u206E\u200F\u202D\u206F\u202B\u200B\u206F\u206C\u202E\u206A\u200E\u200D\u200F\u200C\u202B\u206C\u200C\u206F\u200E\u202C\u206E\u202E\u202E(BattleController A_0)
			{
				return A_0.RoundStarted;
			}
		}
	}
}
