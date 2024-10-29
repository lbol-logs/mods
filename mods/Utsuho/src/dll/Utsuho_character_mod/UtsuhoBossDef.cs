using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Utsuho_character_mod.CardsB;
using Utsuho_character_mod.Status;
using Utsuho_character_mod.Util;

namespace Utsuho_character_mod
{
	public sealed class UtsuhoBossDef : EnemyUnitTemplate
	{
		public override IdContainer GetId()
		{
			return "Utsuho";
		}

		public override LocalizationOption LoadLocalization()
		{
			GlobalLocalization globalLocalization = new GlobalLocalization(BepinexPlugin.directorySource);
			globalLocalization.DiscoverAndLoadLocFiles(this);
			return globalLocalization;
		}

		public override EnemyUnitConfig MakeConfig()
		{
			return new EnemyUnitConfig("", true, false, new List<ManaColor>
			{
				ManaColor.Red,
				ManaColor.Black
			}, 10, "", "#cc0000", EnemyType.Boss, true, null, null, 240, new int?(6), null, new int?(12), new int?(10), new int?(1), new int?(15), new int?(4), new int?(5), new int?(250), new int?(8), null, new int?(14), new int?(10), new int?(1), new int?(18), new int?(5), new int?(6), new int?(260), new int?(10), null, new int?(16), new int?(15), new int?(2), new int?(20), new int?(6), new int?(7), new MinMax(100, 100), new MinMax(100, 100), new List<string> { "Sunny1" }, new List<string> { "火激光" }, new List<string> { "病气A" }, new List<string> { "陨星锤" });
		}

		[EntityLogic(typeof(UtsuhoBossDef))]
		public sealed class Utsuho : EnemyUnit
		{
			private string SpellCardName
			{
				get
				{
					return base.GetSpellCardName(new int?(5), 6);
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<CardEventArgs>(battle.CardDrawn, new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnCardTouched));
				base.ReactBattleEvent<CardUsingEventArgs>(battle.CardUsed, new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnCardTouched));
				base.ReactBattleEvent<CardsEventArgs>(battle.CardsAddedToHand, new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnCardTouched));
				base.ReactBattleEvent<CardEventArgs>(base.Battle.CardExiled, new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnCardTouched));
			}

			private IEnumerable<BattleAction> OnCardTouched(GameEventArgs arg)
			{
				bool flag = this.Next == UtsuhoBossDef.Utsuho.MoveType.Giant;
				if (flag)
				{
					base.UpdateTurnMoves();
				}
				yield break;
			}

			private IEnumerable<BattleAction> OkuuDefend()
			{
				yield return new EnemyMoveAction(this, base.GetMove(2), true);
				yield return new CastBlockShieldAction(this, base.Defend, base.Defend, BlockShieldType.Normal, true);
				yield break;
			}

			protected override IEnumerable<IEnemyMove> GetTurnMoves()
			{
				Type typeFromHandle;
				Type typeFromHandle2;
				Card[] array;
				switch (this.Next)
				{
				case UtsuhoBossDef.Utsuho.MoveType.Reactor:
				{
					GameDifficulty difficulty = base.GameRun.Difficulty;
					bool flag = difficulty == GameDifficulty.Lunatic;
					if (flag)
					{
						this.React(new ApplyStatusEffectAction(typeof(ChargingStatus), this, new int?(base.Count1), null, null, null, 0f, true));
						this.React(new ApplyStatusEffectAction(typeof(HeatStatus), this, new int?(base.Count1), null, null, null, 0f, true));
						this.Next = UtsuhoBossDef.Utsuho.MoveType.Aggregate;
						yield return base.AttackMove(base.GetMove(1), base.Gun1, base.Damage1, 1, false, "Instant", true);
						yield return base.DefendMove(this, null, base.Damage1, 0, 0, false, null);
					}
					else
					{
						yield return base.PositiveMove(base.GetMove(0), typeof(ChargingStatus), new int?(base.Count1), null, true, null);
					}
					break;
				}
				case UtsuhoBossDef.Utsuho.MoveType.Aggregate:
					yield return base.AttackMove(base.GetMove(1), base.Gun1, base.Damage1, 1, false, "Instant", true);
					yield return base.DefendMove(this, null, base.Damage1, 0, 0, false, null);
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Bunker:
					yield return new SimpleEnemyMove(Intention.Defend().WithMoveName(base.GetMove(2)), this.OkuuDefend());
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Flare:
					yield return base.AttackMove(base.GetMove(3), base.Gun2, base.GetStatusEffect<HeatStatus>().Level, 1, false, "Instant", true);
					yield return new SimpleEnemyMove(IntentionTemplate.CreateIntention(typeof(VentIntentionDef.VentIntention)), base.PositiveActions(null, typeof(HeatStatus), new int?(-base.GetStatusEffect<HeatStatus>().Level), new int?(0), 0f, null));
					typeFromHandle = typeof(Weak);
					typeFromHandle2 = typeof(Vulnerable);
					yield return base.NegativeMove(null, typeFromHandle, null, new int?(base.Power), false, false, null);
					yield return base.NegativeMove(null, typeFromHandle2, null, new int?(base.Power), false, false, null);
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Night:
					yield return base.AttackMove(base.GetMove(4), base.Gun3, base.Damage3, 1, false, "Instant", true);
					yield return base.AddCardMove(null, typeof(DarkMatterDef.DarkMatter), base.Count2, EnemyUnit.AddCardZone.Hand, null, false);
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Wait:
					yield return new SimpleEnemyMove(Intention.CountDown(1));
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Giant:
				{
					array = base.Battle.HandZone.SampleManyOrAll(999, base.GameRun.BattleRng);
					int mass = 0;
					foreach (Card card in array)
					{
						UtsuhoCard uCard = card as UtsuhoCard;
						bool flag2 = uCard != null && uCard.isMass;
						if (flag2)
						{
							int num = mass;
							mass = num + 1;
						}
						uCard = null;
						card = null;
					}
					Card[] array2 = null;
					yield return new SimpleEnemyMove(Intention.SpellCard(this.SpellCardName, new int?(base.Damage4 + mass * 5 + this._spellTimes * 4), true), this.AttackActions(this.SpellCardName, base.Gun4, base.Damage4 + mass * 5, 1, true, "Instant"));
					yield return new SimpleEnemyMove(IntentionTemplate.CreateIntention(typeof(PullIntentionDef.PullIntention)));
					break;
				}
				default:
					throw new ArgumentOutOfRangeException();
				}
				typeFromHandle = null;
				typeFromHandle2 = null;
				array = null;
				yield break;
			}

			protected override void UpdateMoveCounters()
			{
				UtsuhoBossDef.Utsuho.MoveType moveType;
				switch (this.Next)
				{
				case UtsuhoBossDef.Utsuho.MoveType.Reactor:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Aggregate;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Aggregate:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Bunker;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Bunker:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Flare;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Flare:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Night;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Night:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Wait;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Wait:
					moveType = UtsuhoBossDef.Utsuho.MoveType.Giant;
					break;
				case UtsuhoBossDef.Utsuho.MoveType.Giant:
					this._spellTimes++;
					moveType = UtsuhoBossDef.Utsuho.MoveType.Aggregate;
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
				this.Next = moveType;
			}

			private int _spellTimes = 0;

			private UtsuhoBossDef.Utsuho.MoveType Next;

			public enum MoveType
			{
				Reactor,
				Aggregate,
				Bunker,
				Flare,
				Night,
				Wait,
				Giant
			}
		}
	}
}
