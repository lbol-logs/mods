using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Randoms;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaTakaneDef))]
	public sealed class AyaTakane : EnemyUnit
	{
		public static string AyaTakaneAttack
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return TypeFactory<EnemyUnit>.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1490064686), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2040633835), true, true);
			}
		}

		public string AyaTakaneIntro1Takane
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(722937450), true, true);
			}
		}

		public string AyaTakaneIntro2Takane
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-72329287), true, true);
			}
		}

		public string AyaTakaneIntro3Takane
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-634727947), true, true);
			}
		}

		public static string AyaTakaneSteal1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return TypeFactory<EnemyUnit>.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(933314526), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(539713131), true, true);
			}
		}

		public static string AyaTakaneSteal2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return TypeFactory<EnemyUnit>.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-287175113), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1853162168), true, true);
			}
		}

		public static string AyaTakaneSteal3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return TypeFactory<EnemyUnit>.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1490064686), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(173264493), true, true);
			}
		}

		private AyaTakane.MoveType Next { get; set; }

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnEnterBattle(BattleController battle)
		{
			AudioManager.PlayInLayer1(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(189608077));
			this.Next = AyaTakane.MoveType.AbilityCardsGalore;
			for (;;)
			{
				IL_0018:
				int num = 2050542419;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)((~num2 * 891171953) ^ (429408291 ^ -353312406)))) % 4U)
					{
					case 0U:
						goto IL_0018;
					case 1U:
						base.ReactBattleEvent<GameEventArgs>(AyaTakane.\u202C\u202D\u206C\u206E\u200C\u200E\u206C\u200B\u206E\u200F\u206E\u202A\u202E\u206F\u200E\u206F\u202E\u200B\u200F\u202E\u206A\u200F\u206D\u206E\u202E\u206B\u202E\u202C\u202B\u200E\u206B\u206B\u200C\u206E\u202C\u200B\u202E\u202B\u202D\u206D\u202E(AyaTakane.\u202B\u206B\u206A\u200C\u200C\u206F\u202E\u200F\u200D\u206A\u200B\u206E\u206E\u202A\u200D\u202B\u200D\u202E\u200D\u200D\u202A\u200E\u200C\u200E\u200E\u206C\u206C\u206C\u206C\u202B\u202D\u202C\u202E\u206F\u200E\u206F\u206C\u206A\u202B\u200F\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
						num = (int)((num3 * 129018438U) ^ 2253820758U);
						continue;
					case 3U:
						base.CountDown = base.Count1;
						num = (int)((num3 * 2282906014U) ^ 1005114991U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			base.HandleBattleEvent<UnitEventArgs>(AyaTakane.\u200F\u202D\u200C\u206C\u206D\u206D\u200E\u206F\u202E\u202D\u206E\u202E\u200D\u200C\u200F\u206B\u206C\u200B\u206D\u206B\u206E\u202B\u206D\u202C\u200B\u202B\u206D\u202B\u200D\u200E\u200D\u200B\u206F\u202E\u202E\u200D\u206E\u202C\u202C\u200F\u202E(this), new GameEventHandler<UnitEventArgs>(this.OnTurnEnding));
			base.HandleBattleEvent<DamageEventArgs>(AyaTakane.\u206C\u206F\u206B\u206D\u200E\u206B\u200C\u206F\u206F\u202A\u206D\u206E\u206B\u202B\u202E\u206E\u200B\u200E\u202C\u206E\u206A\u202D\u206E\u206A\u202D\u206F\u200C\u206B\u206E\u200C\u200C\u206C\u206F\u206D\u206C\u200C\u200F\u202C\u202C\u202E\u202E(this), new GameEventHandler<DamageEventArgs>(this.OnDamageReceived));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
		{
			AyaTakane.<OnBattleStarted>d__23 <OnBattleStarted>d__ = new AyaTakane.<OnBattleStarted>d__23(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		private void OnTurnEnding(UnitEventArgs args)
		{
			this.Doppelganger = false;
		}

		private void OnDamageReceived(DamageEventArgs args)
		{
			if (!this.FirstAidKitUsed)
			{
				for (;;)
				{
					IL_000B:
					int num = 521539855;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~num2 ^ (-1502353127 ^ 60904862))) % 8U)
						{
						case 0U:
							AyaTakane.\u202A\u206A\u200F\u202A\u206C\u206F\u200F\u200B\u202B\u200E\u200C\u206A\u200B\u200E\u200E\u200E\u206B\u202E\u200B\u200B\u206B\u202A\u200C\u206D\u206B\u206A\u200F\u206C\u200C\u206F\u206D\u206F\u202C\u206D\u202E\u200C\u206B\u206E\u206D\u202B\u202E(this);
							num = (int)((num3 * 2338770697U) ^ 3843024217U);
							continue;
						case 2U:
							goto IL_000B;
						case 3U:
							num = (int)((AyaTakane.\u206B\u206C\u206F\u202E\u202A\u200B\u200F\u206F\u200E\u200D\u206E\u200E\u202B\u202A\u200D\u206E\u202A\u200B\u200C\u202C\u206E\u206A\u200C\u202E\u206D\u202D\u206A\u200E\u200E\u202A\u202D\u200E\u200C\u200C\u206A\u200C\u206D\u206A\u202B\u200F\u202E(this) ? 2935823287U : 2426034989U) ^ (num3 * 1386346619U));
							continue;
						case 4U:
							this.Next = AyaTakane.MoveType.FirstAidKit;
							num = 1875690656;
							continue;
						case 5U:
							return;
						case 6U:
							this.FirstAidKitQueue = true;
							num = (int)((num3 * 560904029U) ^ 1917429499U);
							continue;
						case 7U:
							num = (int)((((float)AyaTakane.\u202D\u202C\u202E\u202E\u202C\u206D\u202E\u202E\u206B\u202A\u202E\u200E\u202E\u202B\u202C\u202D\u200B\u206D\u206B\u206D\u202C\u202C\u206C\u200B\u206D\u202A\u202D\u200D\u206E\u200C\u206C\u200D\u202E\u200D\u202E\u202D\u206C\u206C\u206A\u202D\u202E(this) / (float)AyaTakane.\u206D\u206F\u202B\u202C\u200F\u206B\u206B\u206F\u206E\u202B\u206D\u200C\u202D\u206A\u206D\u206F\u206D\u202A\u206D\u206E\u206C\u202D\u206B\u202B\u200F\u200B\u202D\u206F\u200E\u206A\u206C\u202E\u202C\u200F\u206A\u206B\u200D\u206C\u202E\u202C\u202E(this) > 0.5f) ? 2585435372U : 2964856710U) ^ (num3 * 1642219643U));
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				return;
			}
		}

		private IEnumerable<BattleAction> Y60MachineGunActions()
		{
			AyaTakane.<Y60MachineGunActions>d__26 <Y60MachineGunActions>d__ = new AyaTakane.<Y60MachineGunActions>d__26(-2);
			<Y60MachineGunActions>d__.<>4__this = this;
			return <Y60MachineGunActions>d__;
		}

		private IEnumerable<BattleAction> Y202FLASHActions()
		{
			AyaTakane.<Y202FLASHActions>d__27 <Y202FLASHActions>d__ = new AyaTakane.<Y202FLASHActions>d__27(-2);
			<Y202FLASHActions>d__.<>4__this = this;
			return <Y202FLASHActions>d__;
		}

		private IEnumerable<BattleAction> YamawaroBomberActions()
		{
			AyaTakane.<YamawaroBomberActions>d__28 <YamawaroBomberActions>d__ = new AyaTakane.<YamawaroBomberActions>d__28(-2);
			<YamawaroBomberActions>d__.<>4__this = this;
			return <YamawaroBomberActions>d__;
		}

		private IEnumerable<BattleAction> BanditryY82Actions()
		{
			AyaTakane.<BanditryY82Actions>d__29 <BanditryY82Actions>d__ = new AyaTakane.<BanditryY82Actions>d__29(-2);
			<BanditryY82Actions>d__.<>4__this = this;
			return <BanditryY82Actions>d__;
		}

		private IEnumerable<BattleAction> FirstAidKitActions()
		{
			AyaTakane.<FirstAidKitActions>d__30 <FirstAidKitActions>d__ = new AyaTakane.<FirstAidKitActions>d__30(-2);
			<FirstAidKitActions>d__.<>4__this = this;
			return <FirstAidKitActions>d__;
		}

		private IEnumerable<BattleAction> AbilityCardsGaloreActions()
		{
			AyaTakane.<AbilityCardsGaloreActions>d__31 <AbilityCardsGaloreActions>d__ = new AyaTakane.<AbilityCardsGaloreActions>d__31(-2);
			<AbilityCardsGaloreActions>d__.<>4__this = this;
			return <AbilityCardsGaloreActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaTakane.<GetTurnMoves>d__32 <GetTurnMoves>d__ = new AyaTakane.<GetTurnMoves>d__32(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			if (this.FirstAidKitQueue)
			{
				goto IL_0008;
			}
			goto IL_0063;
			int num2;
			for (;;)
			{
				IL_000D:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(-(uint)(((num * 1254015107) ^ (~-270029029 - -1910387158)) * -648934111))) % 7U)
				{
				case 0U:
					goto IL_0008;
				case 1U:
					num2 = (int)(((base.CountDown <= 0) ? 2710950688U : 820067864U) ^ (num3 * 1081077031U));
					continue;
				case 2U:
					goto IL_0063;
				case 3U:
					this.Next = AyaTakane.MoveType.AbilityCardsGalore;
					base.CountDown = base.Count1;
					num2 = (int)((num3 * 2941325683U) ^ 3674820182U);
					continue;
				case 4U:
					return;
				case 5U:
					goto IL_009F;
				}
				break;
			}
			goto IL_00DE;
			IL_009F:
			this.Next = AyaTakane.MoveType.FirstAidKit;
			return;
			IL_00DE:
			this.Next = this.moves.Without(this.Next).Sample(base.EnemyMoveRng);
			return;
			IL_0008:
			num2 = 1740773483;
			goto IL_000D;
			IL_0063:
			int countDown = base.CountDown;
			base.CountDown = countDown - 1;
			num2 = 64688789;
			goto IL_000D;
		}

		static BattleController \u202B\u206B\u206A\u200C\u200C\u206F\u202E\u200F\u200D\u206A\u200B\u206E\u206E\u202A\u200D\u202B\u200D\u202E\u200D\u200D\u202A\u200E\u200C\u200E\u200E\u206C\u206C\u206C\u206C\u202B\u202D\u202C\u202E\u206F\u200E\u206F\u206C\u206A\u202B\u200F\u202E(Unit A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u202C\u202D\u206C\u206E\u200C\u200E\u206C\u200B\u206E\u200F\u206E\u202A\u202E\u206F\u200E\u206F\u202E\u200B\u200F\u202E\u206A\u200F\u206D\u206E\u202E\u206B\u202E\u202C\u202B\u200E\u206B\u206B\u200C\u206E\u202C\u200B\u202E\u202B\u202D\u206D\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}

		static GameEvent<UnitEventArgs> \u200F\u202D\u200C\u206C\u206D\u206D\u200E\u206F\u202E\u202D\u206E\u202E\u200D\u200C\u200F\u206B\u206C\u200B\u206D\u206B\u206E\u202B\u206D\u202C\u200B\u202B\u206D\u202B\u200D\u200E\u200D\u200B\u206F\u202E\u202E\u200D\u206E\u202C\u202C\u200F\u202E(Unit A_0)
		{
			return A_0.TurnEnding;
		}

		static GameEvent<DamageEventArgs> \u206C\u206F\u206B\u206D\u200E\u206B\u200C\u206F\u206F\u202A\u206D\u206E\u206B\u202B\u202E\u206E\u200B\u200E\u202C\u206E\u206A\u202D\u206E\u206A\u202D\u206F\u200C\u206B\u206E\u200C\u200C\u206C\u206F\u206D\u206C\u200C\u200F\u202C\u202C\u202E\u202E(Unit A_0)
		{
			return A_0.DamageReceived;
		}

		static int \u202D\u202C\u202E\u202E\u202C\u206D\u202E\u202E\u206B\u202A\u202E\u200E\u202E\u202B\u202C\u202D\u200B\u206D\u206B\u206D\u202C\u202C\u206C\u200B\u206D\u202A\u202D\u200D\u206E\u200C\u206C\u200D\u202E\u200D\u202E\u202D\u206C\u206C\u206A\u202D\u202E(Unit A_0)
		{
			return A_0.Hp;
		}

		static int \u206D\u206F\u202B\u202C\u200F\u206B\u206B\u206F\u206E\u202B\u206D\u200C\u202D\u206A\u206D\u206F\u206D\u202A\u206D\u206E\u206C\u202D\u206B\u202B\u200F\u200B\u202D\u206F\u200E\u206A\u206C\u202E\u202C\u200F\u206A\u206B\u200D\u206C\u202E\u202C\u202E(Unit A_0)
		{
			return A_0.MaxHp;
		}

		static bool \u206B\u206C\u206F\u202E\u202A\u200B\u200F\u206F\u200E\u200D\u206E\u200E\u202B\u202A\u200D\u206E\u202A\u200B\u200C\u202C\u206E\u206A\u200C\u202E\u206D\u202D\u206A\u200E\u200E\u202A\u202D\u200E\u200C\u200C\u206A\u200C\u206D\u206A\u202B\u200F\u202E(Unit A_0)
		{
			return A_0.IsInTurn;
		}

		static void \u202A\u206A\u200F\u202A\u206C\u206F\u200F\u200B\u202B\u200E\u200C\u206A\u200B\u200E\u200E\u200E\u206B\u202E\u200B\u200B\u206B\u202A\u200C\u206D\u206B\u206A\u200F\u206C\u200C\u206F\u206D\u206F\u202C\u206D\u202E\u200C\u206B\u206E\u206D\u202B\u202E(EnemyUnit A_0)
		{
			A_0.UpdateTurnMoves();
		}

		static bool \u200B\u202A\u200C\u202E\u200B\u206C\u206E\u202C\u202C\u200C\u200C\u202A\u206F\u206D\u200D\u200C\u200E\u202E\u206D\u200B\u200D\u200F\u200D\u206A\u202C\u206C\u200D\u200D\u202D\u206A\u200B\u200C\u206E\u206F\u202B\u200F\u200C\u202C\u202C\u200F\u202E(global::UnityEngine.Object A_0)
		{
			return A_0;
		}

		static bool \u206F\u200E\u206A\u200B\u206F\u206C\u200B\u200E\u200C\u200F\u206E\u200B\u200B\u200D\u206A\u200B\u206B\u206B\u206A\u200B\u202E\u206E\u200E\u206A\u202A\u202A\u206B\u206E\u200C\u202B\u200F\u200D\u206C\u202D\u206D\u202D\u206B\u206A\u202D\u206D\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
		{
			return A_0 != A_1;
		}

		static GameObject \u202C\u202B\u206E\u202A\u202D\u200C\u200B\u206C\u202A\u200D\u206B\u206A\u202E\u200F\u200C\u202C\u202D\u202D\u206A\u206E\u202C\u202C\u202D\u200F\u206C\u200B\u202D\u206B\u202A\u202C\u206C\u200C\u206C\u200D\u206C\u202C\u206C\u206E\u200B\u202B\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		static void \u202C\u206A\u202D\u206B\u202A\u202E\u200C\u206A\u202B\u206F\u206E\u206A\u206C\u200B\u206C\u206E\u200D\u206B\u200E\u206D\u206B\u206F\u206A\u200E\u206C\u206E\u206D\u202E\u206F\u200D\u200C\u202B\u206B\u202D\u200F\u202A\u200E\u206F\u202C\u200C\u202E(global::UnityEngine.Object A_0)
		{
			global::UnityEngine.Object.Destroy(A_0);
		}

		private bool Doppelganger;

		private bool FirstAidKitQueue;

		private bool FirstAidKitUsed;

		private EnemyUnit Enemy;

		private readonly RepeatableRandomPool<AyaTakane.MoveType> moves = new RepeatableRandomPool<AyaTakane.MoveType>
		{
			{
				AyaTakane.MoveType.Y60MachineGun,
				1f
			},
			{
				AyaTakane.MoveType.Y202FLASH,
				1f
			},
			{
				AyaTakane.MoveType.YamawaroBomber,
				1f
			},
			{
				AyaTakane.MoveType.BanditryY82,
				1f
			}
		};

		private enum MoveType
		{
			Y60MachineGun,
			Y202FLASH,
			YamawaroBomber,
			BanditryY82,
			FirstAidKit,
			AbilityCardsGalore
		}
	}
}
