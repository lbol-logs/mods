using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Neutral.Black;
using LBoLEntitySideloader.Attributes;
using lvalonexrumia.Patches;
using lvalonexrumia.StatusEffects;
using lvalonmeme.StatusEffects;

namespace lvalonexrumia.Enemies
{
	[EntityLogic(typeof(lvalonexrumiaEnemyUnitDef))]
	public sealed class lvalonexrumia : EnemyUnit
	{
		private lvalonexrumia.MoveType Last { get; set; }

		private lvalonexrumia.MoveType Next { get; set; }

		public string move1
		{
			get
			{
				return base.GetSpellCardName(new int?(6), 7);
			}
		}

		public string move2
		{
			get
			{
				return base.GetSpellCardName(new int?(0), 1);
			}
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			this.go = false;
			this.halftriggered = false;
			this.firstturn = true;
			this.diff = base.GameRun.Difficulty;
			this.halved = base.Hp < toolbox.hpfrompercent(this, 50, true);
			this.Last = lvalonexrumia.MoveType.Magia;
			this.Next = lvalonexrumia.MoveType.CMS;
			base.ReactBattleEvent<DamageEventArgs>(base.DamageReceived, new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageReceived));
			base.ReactBattleEvent<ChangeLifeEventArgs>(CustomGameEventManager.PostChangeLifeEvent, new Func<ChangeLifeEventArgs, IEnumerable<BattleAction>>(this.OnLifeChanged));
			base.ReactBattleEvent<DamageEventArgs>(base.DamageDealt, new Func<DamageEventArgs, IEnumerable<BattleAction>>(this.OnDamageDealt));
		}

		public override void OnSpawn(EnemyUnit spawner)
		{
			this.React(new ApplyStatusEffectAction<MirrorImage>(this, null, null, null, null, 0f, true));
		}

		private IEnumerable<BattleAction> OnDamageDealt(DamageEventArgs args)
		{
			bool flag = this.halved && args.Source == this;
			if (flag)
			{
				yield return new ChangeLifeAction(toolbox.hpfrompercent(this, 1, true), this);
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnLifeChanged(ChangeLifeEventArgs args)
		{
			bool flag = this.halved;
			if (flag)
			{
				yield break;
			}
			this.halved = base.Hp < toolbox.hpfrompercent(this, 50, true);
			bool flag2 = !this.halftriggered && this.halved;
			if (flag2)
			{
				bool flag3 = this.diff == GameDifficulty.Hard || this.diff == GameDifficulty.Lunatic;
				if (flag3)
				{
					yield return new ApplyStatusEffectAction<Firepower>(this, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				}
				yield return new ApplyStatusEffectAction<sebossheal>(this, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				this.halftriggered = true;
			}
			yield break;
		}

		private IEnumerable<BattleAction> OnDamageReceived(DamageEventArgs args)
		{
			this.halved = base.Hp < toolbox.hpfrompercent(this, 50, true);
			bool flag = !this.halftriggered && this.halved;
			if (flag)
			{
				bool flag2 = this.diff == GameDifficulty.Hard || this.diff == GameDifficulty.Lunatic;
				if (flag2)
				{
					yield return new ApplyStatusEffectAction<Firepower>(this, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				}
				yield return new ApplyStatusEffectAction<sebossheal>(this, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
				this.halftriggered = true;
			}
			yield break;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			switch (this.Next)
			{
			case lvalonexrumia.MoveType.EX:
			{
				yield return new SimpleEnemyMove(Intention.NegativeEffect(null), this.EXAction1());
				yield return new SimpleEnemyMove(Intention.SpellCard(this.move1, new int?(base.Damage1), new int?(3), true), this.EXAction2());
				bool flag = this.halved;
				if (flag)
				{
					yield return new SimpleEnemyMove(Intention.Heal());
				}
				this.Last = lvalonexrumia.MoveType.EX;
				yield break;
			}
			case lvalonexrumia.MoveType.CMS:
			{
				yield return new SimpleEnemyMove(Intention.NegativeEffect(null), this.CMSAction1());
				yield return new SimpleEnemyMove(Intention.SpellCard(this.move2, new int?(base.Damage2), new int?(2), true), this.CMSAction2());
				bool flag2 = this.halved;
				if (flag2)
				{
					yield return new SimpleEnemyMove(Intention.Heal());
				}
				bool flag3 = !this.firstturn;
				if (flag3)
				{
					yield return new SimpleEnemyMove(Intention.PositiveEffect(), this.CMSAction3());
				}
				this.Last = lvalonexrumia.MoveType.CMS;
				yield break;
			}
			case lvalonexrumia.MoveType.Ten:
			{
				bool flag4 = this.halved;
				if (flag4)
				{
					yield return new SimpleEnemyMove(Intention.NegativeEffect(null), this.TenAction1());
				}
				yield return new SimpleEnemyMove(Intention.Attack(base.Damage3, 10, false).WithMoveName(base.GetMove(2)), this.TenAction2());
				yield return new SimpleEnemyMove(Intention.AddCard(), this.AddShadow());
				bool flag5 = this.halved;
				if (flag5)
				{
					yield return new SimpleEnemyMove(Intention.Heal());
				}
				yield return new SimpleEnemyMove(Intention.CountDown(2));
				this.Last = lvalonexrumia.MoveType.Ten;
				yield break;
			}
			case lvalonexrumia.MoveType.Shadow:
			{
				yield return new SimpleEnemyMove(Intention.Attack(base.Damage4, 4, false).WithMoveName(base.GetMove(3)), this.ShadowAction());
				yield return new SimpleEnemyMove(Intention.AddCard(), this.AddShadow());
				bool flag6 = this.halved;
				if (flag6)
				{
					yield return new SimpleEnemyMove(Intention.Heal());
				}
				bool flag7 = this.go;
				if (flag7)
				{
					yield return new SimpleEnemyMove(Intention.CountDown(1));
				}
				else
				{
					yield return new SimpleEnemyMove(Intention.CountDown(2));
				}
				this.Last = lvalonexrumia.MoveType.Shadow;
				yield break;
			}
			case lvalonexrumia.MoveType.Nether:
				yield return new SimpleEnemyMove(Intention.Defend().WithMoveName(base.GetMove(4)), this.NetherAction());
				yield return new SimpleEnemyMove(Intention.AddCard(), this.AddShadow());
				this.Last = lvalonexrumia.MoveType.Nether;
				yield break;
			case lvalonexrumia.MoveType.Magia:
			{
				bool flag8 = !this.go;
				if (flag8)
				{
					yield return new SimpleEnemyMove(Intention.NegativeEffect(null), this.MagiaAction1());
				}
				yield return new SimpleEnemyMove(Intention.Graze().WithMoveName(base.GetMove(5)), this.MagiaAction2());
				bool flag9 = this.go;
				if (flag9)
				{
					yield return new SimpleEnemyMove(Intention.CountDown(1));
				}
				else
				{
					yield return new SimpleEnemyMove(Intention.CountDown(2));
				}
				this.Last = lvalonexrumia.MoveType.Magia;
				yield break;
			}
			default:
				yield break;
			}
		}

		private IEnumerable<BattleAction> EXAction1()
		{
			yield return new ApplyStatusEffectAction<sebloodmark>(base.Battle.Player, new int?(this.halved ? 2 : 1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		private IEnumerable<BattleAction> EXAction2()
		{
			yield return PerformAction.Spell(this, "exulta");
			foreach (BattleAction action in this.AttackActions(this.move1, base.Gun1, base.Damage1, 3, true, "Instant"))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> TenAction1()
		{
			yield return new ApplyStatusEffectAction<Vulnerable>(base.Battle.Player, new int?(0), new int?(2), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		private IEnumerable<BattleAction> TenAction2()
		{
			foreach (BattleAction action in this.AttackActions(base.GetMove(2), base.Gun3, base.Damage3, 10, false, base.Gun3))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> AddShadow()
		{
			IEnumerable<Card> cards = Library.CreateCards<Shadow>((this.halved && this.diff == GameDifficulty.Lunatic) ? 2 : 1, false);
			foreach (Card card in cards)
			{
				card.IsPurified = true;
				card = null;
			}
			IEnumerator<Card> enumerator = null;
			yield return new AddCardsToDrawZoneAction(cards, DrawZoneTarget.Random, AddCardsType.Normal);
			yield break;
		}

		private IEnumerable<BattleAction> ShadowAction()
		{
			foreach (BattleAction action in this.AttackActions(base.GetMove(3), base.Gun4, base.Damage4, 4, false, base.Gun3))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> NetherAction()
		{
			yield return new CastBlockShieldAction(this, base.Defend, this.halved ? base.Defend : 0, BlockShieldType.Normal, true);
			yield break;
		}

		private IEnumerable<BattleAction> MagiaAction1()
		{
			yield return new ApplyStatusEffectAction<Vulnerable>(base.Battle.Player, new int?(0), new int?(2), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		private IEnumerable<BattleAction> MagiaAction2()
		{
			yield return new ApplyStatusEffectAction<Graze>(this, new int?(((this.diff == GameDifficulty.Lunatic || this.diff == GameDifficulty.Hard) ? 2 : 1) + (this.halved ? 1 : 0)), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		private IEnumerable<BattleAction> CMSAction1()
		{
			yield return new ApplyStatusEffectAction<sebleed>(base.Battle.Player, new int?(base.Count1 + (this.halved ? 2 : 0)), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		private IEnumerable<BattleAction> CMSAction2()
		{
			yield return PerformAction.Spell(this, "exultb");
			foreach (BattleAction action in this.AttackActions(this.move2, base.Gun2, base.Damage2, 2, true, base.Gun2))
			{
				yield return action;
				action = null;
			}
			IEnumerator<BattleAction> enumerator = null;
			this.firstturn = false;
			yield break;
			yield break;
		}

		private IEnumerable<BattleAction> CMSAction3()
		{
			yield return new ApplyStatusEffectAction<Firepower>(this, new int?(1), new int?(0), new int?(0), new int?(0), 0.2f, true);
			yield break;
		}

		protected override void UpdateMoveCounters()
		{
			switch (this.Last)
			{
			case lvalonexrumia.MoveType.EX:
				this.Next = lvalonexrumia.MoveType.Ten;
				break;
			case lvalonexrumia.MoveType.CMS:
				this.Next = lvalonexrumia.MoveType.Nether;
				break;
			case lvalonexrumia.MoveType.Ten:
				this.Next = lvalonexrumia.MoveType.Magia;
				break;
			case lvalonexrumia.MoveType.Shadow:
			{
				bool flag = this.go;
				if (flag)
				{
					this.Next = lvalonexrumia.MoveType.CMS;
					this.go = false;
				}
				else
				{
					this.Next = lvalonexrumia.MoveType.Magia;
					this.go = true;
				}
				break;
			}
			case lvalonexrumia.MoveType.Nether:
				this.Next = lvalonexrumia.MoveType.Shadow;
				break;
			case lvalonexrumia.MoveType.Magia:
			{
				bool flag2 = this.go;
				if (flag2)
				{
					this.Next = lvalonexrumia.MoveType.EX;
					this.go = false;
				}
				else
				{
					this.Next = lvalonexrumia.MoveType.Shadow;
					this.go = true;
				}
				break;
			}
			}
		}

		private bool halved = false;

		private bool halftriggered = false;

		private bool firstturn = true;

		private bool go = false;

		private GameDifficulty diff;

		private enum MoveType
		{
			EX,
			CMS,
			Ten,
			Shadow,
			Nether,
			Magia
		}
	}
}
