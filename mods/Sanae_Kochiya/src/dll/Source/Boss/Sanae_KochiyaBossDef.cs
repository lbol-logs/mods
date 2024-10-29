using System;
using System.Collections.Generic;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Randoms;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using Sanae_Kochiya.GunName;
using Sanae_Kochiya.Source.Localization;
using Sanae_Kochiya.Source.StatusEffects;

namespace Sanae_Kochiya.Source.Boss
{
	public sealed class Sanae_KochiyaBossDef : EnemyUnitTemplate
	{
		public override IdContainer GetId()
		{
			return "Sanae_Kochiya";
		}

		public override LocalizationOption LoadLocalization()
		{
			return SampleCharacterLocalization.EnemyUnitBatchLoc.AddEntity(this);
		}

		public override EnemyUnitConfig MakeConfig()
		{
			return new EnemyUnitConfig("", true, false, new List<ManaColor>
			{
				ManaColor.White,
				ManaColor.Blue
			}, 10, "Sanae", "#28e25a", EnemyType.Boss, true, null, null, 240, new int?(5), new int?(8), new int?(14), new int?(13), new int?(1), new int?(12), new int?(1), new int?(2), new int?(250), new int?(6), new int?(9), new int?(16), new int?(13), new int?(1), new int?(15), new int?(1), new int?(2), new int?(260), new int?(6), new int?(9), new int?(16), new int?(15), new int?(2), new int?(18), new int?(1), new int?(3), new MinMax(100, 100), new MinMax(100, 100), new List<string> { GunNameID.GetGunFromId(25140) }, new List<string> { GunNameID.GetGunFromId(7160) }, new List<string> { GunNameID.GetGunFromId(50000) }, new List<string> { GunNameID.GetGunFromId(25160) });
		}

		[EntityLogic(typeof(Sanae_KochiyaBossDef))]
		public sealed class Sanae_Kochiya : EnemyUnit
		{
			private string SpellCard
			{
				get
				{
					return base.GetSpellCardName(new int?(4), 5);
				}
			}

			private Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType LastAttack { get; set; }

			private Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType Next { get; set; }

			protected override void OnEnterBattle(BattleController battle)
			{
				this.LastAttack = Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAccuracy;
				this.Next = Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAddCard;
				base.CountDown = 5;
				this._defendCount = 2;
				base.ReactBattleEvent<GameEventArgs>(base.Battle.BattleStarted, new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
			{
				yield return new CastBlockShieldAction(this, 0, base.Defend, BlockShieldType.Normal, false);
				yield return new ApplyStatusEffectAction<AmuletForEnemy>(this, new int?(base.Count2), null, null, null, 0f, true);
				yield break;
			}

			public override void OnSpawn(EnemyUnit spawner)
			{
				this.React(new CastBlockShieldAction(this, 0, base.Defend, BlockShieldType.Normal, false));
				this.React(new ApplyStatusEffectAction<AmuletForEnemy>(this, new int?(base.Count2), null, null, null, 0f, true));
				this.React(new ApplyStatusEffectAction<MirrorImage>(this, null, null, null, null, 0f, true));
			}

			private IEnumerable<BattleAction> KochiyaDefend()
			{
				int rng = base.EnemyBattleRng.NextInt(0, 2);
				yield return new EnemyMoveAction(this, base.GetMove(3), true);
				yield return new CastBlockShieldAction(this, base.Defend + rng, base.Defend + rng, BlockShieldType.Normal, true);
				bool flag = !base.HasStatusEffect<AmuletForEnemy>();
				if (flag)
				{
					yield return new ApplyStatusEffectAction<AmuletForEnemy>(this, new int?(base.Count2), null, null, null, 0f, true);
				}
				else
				{
					yield return new ApplyStatusEffectAction<AmuletForEnemy>(this, new int?(1), null, null, null, 0f, true);
				}
				yield break;
			}

			private IEnumerable<BattleAction> SpellActions()
			{
				foreach (BattleAction battleAction in this.AttackActions(this.SpellCard, base.Gun4, base.Damage4, 2, true, "Instant"))
				{
					yield return battleAction;
					battleAction = null;
				}
				IEnumerator<BattleAction> enumerator = null;
				yield return new ApplyStatusEffectAction<SpiritNegative>(base.Battle.Player, new int?(base.Power), null, null, null, 0f, true);
				yield return new ApplyStatusEffectAction<Spirit>(this, new int?(base.Power), null, null, null, 0f, true);
				yield break;
				yield break;
			}

			protected override IEnumerable<IEnemyMove> GetTurnMoves()
			{
				switch (this.Next)
				{
				case Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.MultiShoot:
					yield return base.AttackMove(base.GetMove(0), base.Gun1, base.Damage1, 4, false, "Instant", true);
					break;
				case Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAccuracy:
				{
					yield return base.AttackMove(base.GetMove(1), base.Gun2, base.Damage2, 2, true, "Instant", true);
					string text = null;
					Type typeFromHandle = typeof(Fragil);
					int? num = new int?(base.Count1);
					yield return base.NegativeMove(text, typeFromHandle, null, num, false, false, null);
					break;
				}
				case Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAddCard:
					yield return base.AttackMove(base.GetMove(2), base.Gun3, base.Damage3, 1, false, "Instant", true);
					yield return base.AddCardMove(null, typeof(Yueguang), 1, EnemyUnit.AddCardZone.Discard, null, false);
					break;
				case Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.Defend:
					yield return new SimpleEnemyMove(Intention.Defend().WithMoveName(base.GetMove(3)), this.KochiyaDefend());
					break;
				case Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.SpellShoot:
					yield return new SimpleEnemyMove(Intention.SpellCard(this.SpellCard, new int?(base.Damage4), new int?(2), true), this.SpellActions());
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
				int countDown = base.CountDown;
				bool flag = countDown == 1 || countDown == 2;
				if (flag)
				{
					yield return new SimpleEnemyMove(Intention.CountDown(base.CountDown));
				}
				yield break;
			}

			protected override void UpdateMoveCounters()
			{
				int num = base.CountDown - 1;
				base.CountDown = num;
				bool flag = base.CountDown <= 0;
				if (flag)
				{
					this.Next = Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.SpellShoot;
					base.CountDown = base.EnemyMoveRng.NextInt(5, 6);
				}
				else
				{
					this._defendCount--;
					bool flag2 = this._defendCount <= 0 && base.Shield == 0;
					if (flag2)
					{
						this.Next = Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.Defend;
						this._defendCount = 4;
					}
					else
					{
						this.Next = this._pool.Without(this.LastAttack).Sample(base.EnemyMoveRng);
						this.LastAttack = this.Next;
					}
				}
			}

			private readonly RepeatableRandomPool<Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType> _pool = new RepeatableRandomPool<Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType>
			{
				{
					Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.MultiShoot,
					2f
				},
				{
					Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAccuracy,
					2f
				},
				{
					Sanae_KochiyaBossDef.Sanae_Kochiya.MoveType.ShootAddCard,
					1f
				}
			};

			private int _defendCount;

			private enum MoveType
			{
				MultiShoot,
				ShootAccuracy,
				ShootAddCard,
				Defend,
				SpellShoot
			}
		}
	}
}
