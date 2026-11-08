using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Randoms;
using LBoL.Core.Units;
using LBoL.Presentation.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.EnemyUnits
{
	public sealed class AyaBossKoishiDef : EnemyUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1606930955);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaBossKoishiDef.\u200D\u200F\u200D\u202A\u202D\u200B\u206A\u200D\u200D\u200D\u202D\u206F\u206B\u202B\u206B\u200B\u206D\u202A\u202C\u200F\u200F\u206C\u206B\u202B\u200D\u200E\u200C\u206B\u206F\u202A\u200F\u206D\u200D\u206D\u206B\u200C\u202B\u202C\u206E\u200F\u202E(BepinexPlugin.enemyUnitLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override EnemyUnitConfig MakeConfig()
		{
			AyaBossKoishiDef.\u206E\u202D\u200F\u202B\u206D\u206A\u200C\u206C\u206A\u206A\u202D\u202E\u206B\u206C\u202C\u202A\u206E\u206C\u202C\u202E\u206F\u206E\u200D\u206F\u206F\u200B\u206F\u206F\u206A\u206D\u206F\u202A\u206B\u202A\u206C\u202C\u200E\u206D\u202C\u206F\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(108923543), () => AyaBossKoishiDef.<>c.\u200B\u202A\u206D\u200F\u206B\u206F\u202E\u200F\u200E\u206A\u200D\u200F\u202B\u200D\u206C\u206E\u200C\u200C\u206A\u200E\u206E\u202C\u206D\u206A\u202B\u206C\u206C\u202B\u206A\u202C\u202B\u200F\u206B\u200C\u202C\u200C\u202D\u206F\u206B\u200C\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1497834783)), null);
			return new EnemyUnitConfig(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2054957954), true, false, new ManaColor[]
			{
				ManaColor.Black,
				ManaColor.Green
			}, 10, null, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(433288403), EnemyType.Boss, false, null, null, 2400, new int?(7), new int?(21), new int?(35), null, new int?(1), new int?(50), new int?(7), new int?(7), new int?(2700), new int?(8), new int?(24), new int?(40), null, new int?(2), new int?(100), new int?(7), new int?(7), new int?(3000), new int?(9), new int?(27), new int?(45), null, new int?(3), new int?(150), new int?(7), new int?(7), new MinMax(500, 500), new MinMax(1500, 1500), new string[] { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1831520749) }, new string[] { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(842565723) }, new string[] { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-286160563) }, new string[] { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1923650164) });
		}

		static BatchLocalization \u200D\u200F\u200D\u202A\u202D\u200B\u206A\u200D\u200D\u200D\u202D\u206F\u206B\u202B\u206B\u200B\u206D\u202A\u202C\u200F\u200F\u206C\u206B\u202B\u200D\u200E\u200C\u206B\u206F\u202A\u200F\u206D\u200D\u206D\u206B\u200C\u202B\u202C\u206E\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static void \u206E\u202D\u200F\u202B\u206D\u206A\u200C\u206C\u206A\u206A\u202D\u202E\u206B\u206C\u202C\u202A\u206E\u206C\u202C\u202E\u206F\u206E\u200D\u206F\u206F\u200B\u206F\u206F\u206A\u206D\u206F\u202A\u206B\u202A\u206C\u202C\u200E\u206D\u202C\u206F\u202E(string A_0, Func<Sprite> A_1, Assembly A_2)
		{
			EnemyUnitTemplate.AddBossNodeIcon(A_0, A_1, A_2);
		}

		[EntityLogic(typeof(AyaBossKoishiDef))]
		public sealed class AyaBossKoishi : EnemyUnit
		{
			private AyaBossKoishiDef.AyaBossKoishi.MoveType Next { get; set; }

			private AyaBossKoishiDef.AyaBossKoishi.MoveType Last { get; set; }

			private AyaBossKoishiDef.AyaBossKoishi.InspirationType PreviousInspiration { get; set; }

			private AyaBossKoishiDef.AyaBossKoishi.InspirationType NextInspiration { get; set; }

			private RandomGen InspirationRng { get; set; }

			private string SpellCardName
			{
				get
				{
					return base.GetSpellCardName(new int?(9), 10);
				}
			}

			private string SpellCard2Name
			{
				get
				{
					return base.GetSpellCardName(null, 11);
				}
			}

			public string AyaBossKoishiSpell1Koishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(992270217), true, true);
				}
			}

			public string AyaBossKoishiSpell2Koishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2071836822), true, true);
				}
			}

			public string AyaBossKoishiSpell3Koishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(217372916), true, true);
				}
			}

			public string AyaBossKoishiSpell4Koishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1229766810), true, true);
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.CountDown = base.Count2;
				for (;;)
				{
					IL_000C:
					int num = 439298463;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(num2 - (-1942720869 * ~278119492 + 228877066)) - 675442134 + 2089633754)) % 8U)
						{
						case 0U:
							this.NextInspiration = this._insPool.Sample(this.InspirationRng);
							AyaBossKoishiDef.AyaBossKoishi.\u200D\u202A\u200F\u206B\u200E\u206F\u200B\u206D\u202B\u200B\u200D\u206F\u202B\u206D\u202D\u200B\u206C\u202B\u200E\u202D\u206F\u200E\u200B\u206D\u200F\u206D\u202C\u206C\u200D\u200D\u202E\u202D\u202B\u202C\u206C\u206D\u200B\u200D\u202C\u200C\u202E(AyaBossKoishiDef.AyaBossKoishi.\u202E\u206D\u202C\u206D\u200B\u206F\u200E\u206E\u202A\u202C\u200C\u200E\u206E\u202C\u206E\u206A\u200B\u202E\u202C\u202E\u200B\u206D\u206F\u202E\u200B\u206A\u200E\u200C\u200D\u200D\u200D\u202A\u206F\u206B\u200E\u206E\u206D\u202B\u206D\u206C\u202E(this.GetView<UnitView>()._statusWidget.hpBar), false);
							num = (int)((num3 * 3547730430U) ^ 2968611506U);
							continue;
						case 1U:
							this.InspirationRng = base.EnemyMoveRng;
							num = (int)((num3 * 3519082030U) ^ 3592014816U);
							continue;
						case 2U:
							this.Threshold = AyaBossKoishiDef.AyaBossKoishi.\u202E\u202C\u200C\u200F\u200F\u200D\u206F\u202B\u202D\u200D\u206F\u202D\u206D\u206A\u206F\u202A\u202B\u206B\u206B\u206A\u200C\u200B\u206B\u202A\u206F\u200B\u202D\u206C\u200E\u200E\u206B\u200E\u200C\u200F\u202B\u206F\u200D\u202C\u206F\u202D\u202E((float)AyaBossKoishiDef.AyaBossKoishi.\u200C\u200E\u200E\u206D\u206D\u200D\u202E\u200F\u206A\u200E\u200E\u202E\u202E\u200E\u206B\u206D\u202C\u206B\u200D\u206D\u206A\u200E\u200D\u202A\u206F\u206F\u200E\u202C\u202C\u200C\u200F\u206D\u200E\u206E\u206D\u200F\u206E\u200F\u202D\u202A\u202E(this) / 2f, MidpointRounding.AwayFromZero);
							num = (int)((num3 * 2374683308U) ^ 3579311472U);
							continue;
						case 3U:
							goto IL_000C;
						case 5U:
							base.HandleBattleEvent<GameEventArgs>(AyaBossKoishiDef.AyaBossKoishi.\u202E\u206A\u206A\u200E\u206B\u206E\u200B\u200F\u206D\u202E\u200C\u202C\u202A\u202E\u202B\u206C\u206C\u202D\u200E\u206C\u206A\u200B\u200B\u206A\u206D\u200C\u202E\u206A\u206C\u200E\u206D\u206B\u206C\u206D\u206C\u206C\u200B\u202C\u200F\u202A\u202E(AyaBossKoishiDef.AyaBossKoishi.\u200C\u202E\u206A\u202B\u206B\u206A\u200B\u202E\u202C\u206B\u202B\u202A\u202B\u206A\u202E\u206A\u202D\u200B\u202C\u200B\u202E\u202A\u200C\u202D\u200C\u206F\u200F\u200D\u206E\u202C\u200F\u206D\u200D\u200C\u200F\u202E\u200C\u200F\u200B\u200D\u202E(this)), new GameEventHandler<GameEventArgs>(this.OnRoundEnded));
							base.HandleBattleEvent<DamageEventArgs>(AyaBossKoishiDef.AyaBossKoishi.\u206A\u206B\u200E\u202C\u202C\u202C\u200B\u200B\u206B\u202C\u202C\u206F\u206D\u200B\u206B\u202C\u206B\u206F\u206A\u200D\u202A\u202E\u200D\u200C\u206F\u202E\u206C\u200B\u202B\u202E\u202D\u202B\u202D\u200D\u202C\u200D\u206E\u202A\u200E\u202B\u202E(this), new GameEventHandler<DamageEventArgs>(this.OnDamageReceived));
							base.HandleBattleEvent<UnitEventArgs>(AyaBossKoishiDef.AyaBossKoishi.\u202A\u202D\u202C\u200C\u200E\u202A\u200B\u202A\u206B\u206F\u206B\u200D\u202C\u206B\u206D\u202A\u206A\u202D\u202D\u200E\u206C\u206E\u206B\u200B\u202B\u206B\u200D\u202C\u200B\u206C\u202A\u202D\u200D\u200C\u202B\u200C\u202A\u202C\u200C\u206A\u202E(this), new GameEventHandler<UnitEventArgs>(this.OnEscaping));
							num = (int)((num3 * 3239541306U) ^ 2698919967U);
							continue;
						case 6U:
							base.ReactBattleEvent<GameEventArgs>(AyaBossKoishiDef.AyaBossKoishi.\u206C\u202C\u200C\u200D\u206F\u206F\u202A\u206E\u206D\u200D\u202E\u202D\u206E\u206D\u200F\u202C\u206A\u206F\u202E\u200E\u202E\u200E\u202D\u200D\u202E\u200F\u202E\u206F\u206D\u202A\u206C\u206E\u202C\u202E\u206F\u200B\u202B\u206D\u206A\u200D\u202E(AyaBossKoishiDef.AyaBossKoishi.\u200C\u202E\u206A\u202B\u206B\u206A\u200B\u202E\u202C\u206B\u202B\u202A\u202B\u206A\u202E\u206A\u202D\u200B\u202C\u200B\u202E\u202A\u200C\u202D\u200C\u206F\u200F\u200D\u206E\u202C\u200F\u206D\u200D\u200C\u200F\u202E\u200C\u200F\u200B\u200D\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
							num = (int)((num3 * 715156393U) ^ 118957607U);
							continue;
						case 7U:
							this.CountDown2 = base.Count2 * 4;
							num = (int)((num3 * 202784744U) ^ 3354247244U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
			{
				AyaBossKoishiDef.AyaBossKoishi.<OnBattleStarted>d__36 <OnBattleStarted>d__ = new AyaBossKoishiDef.AyaBossKoishi.<OnBattleStarted>d__36(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			private void OnRoundEnded(GameEventArgs arg)
			{
				this.Threshold = AyaBossKoishiDef.AyaBossKoishi.\u202E\u202C\u200C\u200F\u200F\u200D\u206F\u202B\u202D\u200D\u206F\u202D\u206D\u206A\u206F\u202A\u202B\u206B\u206B\u206A\u200C\u200B\u206B\u202A\u206F\u200B\u202D\u206C\u200E\u200E\u206B\u200E\u200C\u200F\u202B\u206F\u200D\u202C\u206F\u202D\u202E(AyaBossKoishiDef.AyaBossKoishi.\u200D\u200F\u200C\u202B\u200E\u206D\u200B\u200B\u200C\u206F\u200F\u202A\u202C\u200F\u206B\u202B\u206D\u202B\u200D\u206F\u200E\u202B\u206D\u206F\u202C\u206F\u206B\u202A\u202D\u202C\u200B\u206E\u202A\u202A\u202B\u200D\u206B\u200E\u202A\u202E((float)this.Threshold, (float)AyaBossKoishiDef.AyaBossKoishi.\u200C\u200E\u200E\u206D\u206D\u200D\u202E\u200F\u206A\u200E\u200E\u202E\u202E\u200E\u206B\u206D\u202C\u206B\u200D\u206D\u206A\u200E\u200D\u202A\u206F\u206F\u200E\u202C\u202C\u200C\u200F\u206D\u200E\u206E\u206D\u200F\u206E\u200F\u202D\u202A\u202E(this) / 2f), MidpointRounding.AwayFromZero);
			}

			private void OnDamageReceived(DamageEventArgs arg)
			{
				if (AyaBossKoishiDef.AyaBossKoishi.\u206A\u206A\u206E\u206D\u206F\u206A\u200F\u200C\u206F\u200E\u202C\u200F\u206E\u202C\u202C\u206C\u202B\u200D\u202C\u200C\u200E\u200F\u206E\u206E\u200F\u202E\u206F\u200E\u202A\u202C\u200C\u206D\u200B\u202A\u200F\u202C\u202D\u206A\u206B\u200E\u202E(this) == UnitStatus.Alive)
				{
					for (;;)
					{
						IL_0008:
						int num = 1724074900;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(~(uint)(~(uint)(-(uint)num2))))) % 3U)
							{
							case 0U:
								goto IL_0008;
							case 1U:
								AyaBossKoishiDef.AyaBossKoishi.\u206C\u206C\u202B\u206A\u202D\u202C\u206A\u200B\u202C\u206F\u200C\u206D\u200D\u202C\u202E\u200F\u206F\u202C\u200D\u200E\u200C\u202D\u206A\u202C\u200D\u200E\u206D\u200D\u206B\u202E\u202B\u202E\u200E\u200E\u200E\u202B\u200F\u202A\u202C\u200F\u202E(this, AyaBossKoishiDef.AyaBossKoishi.\u206E\u206E\u200F\u200D\u200F\u206A\u202A\u200B\u206D\u200F\u200D\u206D\u202D\u200F\u206E\u206B\u206F\u202D\u202A\u206C\u200C\u206E\u206C\u200B\u200B\u200B\u206F\u200B\u202B\u200F\u200C\u202A\u200F\u200B\u206C\u206F\u206E\u202A\u202D\u202B\u202E(AyaBossKoishiDef.AyaBossKoishi.\u200C\u200E\u200E\u206D\u206D\u200D\u202E\u200F\u206A\u200E\u200E\u202E\u202E\u200E\u206B\u206D\u202C\u206B\u200D\u206D\u206A\u200E\u200D\u202A\u206F\u206F\u200E\u202C\u202C\u200C\u200F\u206D\u200E\u206E\u206D\u200F\u206E\u200F\u202D\u202A\u202E(this), this.Threshold));
								num = (int)((num3 * 2870719769U) ^ 2818822784U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnEscaping(UnitEventArgs arg)
			{
				if (AyaBossKoishiDef.AyaBossKoishi.\u202D\u200E\u202D\u202A\u202A\u200E\u202E\u206F\u200C\u206E\u200B\u206E\u200E\u200E\u200E\u206B\u202B\u206C\u206C\u200B\u202A\u206A\u202A\u202A\u206A\u200F\u206E\u202B\u206A\u202C\u206A\u200B\u200F\u206F\u202B\u206D\u202C\u206A\u206E\u200D\u202E(arg) != this)
				{
					for (;;)
					{
						IL_0009:
						int num = 1515037786;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-num2 * 80824831)) % 4U)
							{
							case 1U:
								AyaBossKoishiDef.AyaBossKoishi.\u206A\u202E\u206B\u206A\u200B\u200F\u206F\u206C\u202C\u200F\u202B\u206B\u202A\u206D\u202B\u200E\u206D\u206A\u202A\u206A\u200F\u200D\u202B\u200D\u202C\u206A\u200C\u206D\u202D\u206F\u202C\u206A\u206F\u206A\u206C\u206A\u202E\u202D\u200C\u200C\u202E(arg, this);
								num = (int)((num3 * 2535225338U) ^ 3743259310U);
								continue;
							case 2U:
								AyaBossKoishiDef.AyaBossKoishi.\u206C\u200B\u200E\u206E\u200F\u206C\u202D\u202D\u202A\u206B\u200F\u202B\u202A\u200D\u206D\u202C\u200B\u206D\u200D\u202C\u206F\u202D\u200B\u200B\u202A\u202D\u202A\u206D\u202B\u206C\u200C\u206B\u200D\u206A\u206E\u200C\u200C\u206F\u202E(arg, true);
								num = (int)((num3 * 1778986689U) ^ 3494462535U);
								continue;
							case 3U:
								goto IL_0009;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			protected override IEnumerable<IEnemyMove> GetTurnMoves()
			{
				AyaBossKoishiDef.AyaBossKoishi.<GetTurnMoves>d__40 <GetTurnMoves>d__ = new AyaBossKoishiDef.AyaBossKoishi.<GetTurnMoves>d__40(-2);
				<GetTurnMoves>d__.<>4__this = this;
				return <GetTurnMoves>d__;
			}

			private IEnumerable<BattleAction> DoubleShootActions()
			{
				AyaBossKoishiDef.AyaBossKoishi.<DoubleShootActions>d__41 <DoubleShootActions>d__ = new AyaBossKoishiDef.AyaBossKoishi.<DoubleShootActions>d__41(-2);
				<DoubleShootActions>d__.<>4__this = this;
				return <DoubleShootActions>d__;
			}

			private IEnumerable<BattleAction> SpellActions()
			{
				AyaBossKoishiDef.AyaBossKoishi.<SpellActions>d__42 <SpellActions>d__ = new AyaBossKoishiDef.AyaBossKoishi.<SpellActions>d__42(-2);
				<SpellActions>d__.<>4__this = this;
				return <SpellActions>d__;
			}

			private IEnumerable<BattleAction> Spell2Actions()
			{
				AyaBossKoishiDef.AyaBossKoishi.<Spell2Actions>d__45 <Spell2Actions>d__ = new AyaBossKoishiDef.AyaBossKoishi.<Spell2Actions>d__45(-2);
				<Spell2Actions>d__.<>4__this = this;
				return <Spell2Actions>d__;
			}

			private IEnumerable<BattleAction> BlackActions()
			{
				AyaBossKoishiDef.AyaBossKoishi.<BlackActions>d__46 <BlackActions>d__ = new AyaBossKoishiDef.AyaBossKoishi.<BlackActions>d__46(-2);
				<BlackActions>d__.<>4__this = this;
				return <BlackActions>d__;
			}

			private int SpellLevel { get; set; }

			private bool HiddenIntention
			{
				get
				{
					return AyaBossKoishiDef.AyaBossKoishi.\u206F\u206C\u202E\u206A\u202E\u206F\u202B\u202A\u206B\u206F\u202B\u206F\u206C\u206A\u206B\u206D\u200E\u200D\u206D\u200D\u202E\u200F\u202D\u202D\u200E\u202C\u200C\u206C\u200E\u202D\u200F\u200B\u206C\u206A\u202D\u202A\u200F\u206F\u202E\u206A\u202E(base.EnemyMoveRng, 1, 10) <= this.SpellLevel;
				}
			}

			private float DamageMultiplier
			{
				get
				{
					return 1f + (float)this.SpellLevel * 0.1f;
				}
			}

			private int InspirationDamage
			{
				get
				{
					return base.Damage1 + this.SpellLevel * 3;
				}
			}

			private int BlockCount
			{
				get
				{
					return base.Defend + this.SpellLevel * 50;
				}
			}

			private int ShieldCount
			{
				get
				{
					return (base.Defend + this.SpellLevel * 50) / 2;
				}
			}

			protected override void UpdateMoveCounters()
			{
				int countDown = base.CountDown;
				for (;;)
				{
					IL_0007:
					int num = -1461525323;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num2 * -1850857141))) % 12U)
						{
						case 0U:
							base.CountDown = base.Count2;
							num = (int)((num3 * 3897544316U) ^ 767182032U);
							continue;
						case 1U:
							this.Next = AyaBossKoishiDef.AyaBossKoishi.MoveType.Spell;
							base.CountDown = base.Count2;
							num = (int)((num3 * 3549165207U) ^ 3222568880U);
							continue;
						case 2U:
							num = (int)(((this.CountDown2 <= 0) ? 844170405U : 1688996702U) ^ (num3 * 2704331826U));
							continue;
						case 3U:
							this.PreviousInspiration = this.NextInspiration;
							this.NextInspiration = this._insPool.Without(this.PreviousInspiration).Sample(this.InspirationRng);
							num = -1286660898;
							continue;
						case 4U:
							goto IL_0007;
						case 5U:
							this.Next = AyaBossKoishiDef.AyaBossKoishi.MoveType.Spell2;
							num = (int)((num3 * 2565824394U) ^ 3942127806U);
							continue;
						case 7U:
							this.CountDown2--;
							num = (int)((num3 * 636506516U) ^ 1055805770U);
							continue;
						case 8U:
							num = (int)((num3 * 1443030682U) ^ 1424315495U);
							continue;
						case 9U:
							base.CountDown = countDown - 1;
							num = (int)((num3 * 3444175130U) ^ 628493385U);
							continue;
						case 10U:
							num = ((base.CountDown <= 0) ? (-235290019) : (-807765501));
							continue;
						case 11U:
							this.Last = this.Next;
							this.Next = this._pool.Without(this.Last).Sample(base.EnemyMoveRng);
							num = -2085983897;
							continue;
						}
						return;
					}
				}
			}

			[CompilerGenerated]
			private IEnumerator <Spell2Actions>g__coroutine|45_0()
			{
				AyaBossKoishiDef.AyaBossKoishi.<<Spell2Actions>g__coroutine|45_0>d <<Spell2Actions>g__coroutine|45_0>d = new AyaBossKoishiDef.AyaBossKoishi.<<Spell2Actions>g__coroutine|45_0>d(0);
				<<Spell2Actions>g__coroutine|45_0>d.<>4__this = this;
				return <<Spell2Actions>g__coroutine|45_0>d;
			}

			[CompilerGenerated]
			private IEnumerator <Spell2Actions>g__coroutine2|45_1(UnitView unitView)
			{
				AyaBossKoishiDef.AyaBossKoishi.<<Spell2Actions>g__coroutine2|45_1>d <<Spell2Actions>g__coroutine2|45_1>d = new AyaBossKoishiDef.AyaBossKoishi.<<Spell2Actions>g__coroutine2|45_1>d(0);
				<<Spell2Actions>g__coroutine2|45_1>d.<>4__this = this;
				<<Spell2Actions>g__coroutine2|45_1>d.unitView = unitView;
				return <<Spell2Actions>g__coroutine2|45_1>d;
			}

			static int \u200C\u200E\u200E\u206D\u206D\u200D\u202E\u200F\u206A\u200E\u200E\u202E\u202E\u200E\u206B\u206D\u202C\u206B\u200D\u206D\u206A\u200E\u200D\u202A\u206F\u206F\u200E\u202C\u202C\u200C\u200F\u206D\u200E\u206E\u206D\u200F\u206E\u200F\u202D\u202A\u202E(Unit A_0)
			{
				return A_0.Hp;
			}

			static int \u202E\u202C\u200C\u200F\u200F\u200D\u206F\u202B\u202D\u200D\u206F\u202D\u206D\u206A\u206F\u202A\u202B\u206B\u206B\u206A\u200C\u200B\u206B\u202A\u206F\u200B\u202D\u206C\u200E\u200E\u206B\u200E\u200C\u200F\u202B\u206F\u200D\u202C\u206F\u202D\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}

			static BattleController \u200C\u202E\u206A\u202B\u206B\u206A\u200B\u202E\u202C\u206B\u202B\u202A\u202B\u206A\u202E\u206A\u202D\u200B\u202C\u200B\u202E\u202A\u200C\u202D\u200C\u206F\u200F\u200D\u206E\u202C\u200F\u206D\u200D\u200C\u200F\u202E\u200C\u200F\u200B\u200D\u202E(Unit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u206C\u202C\u200C\u200D\u206F\u206F\u202A\u206E\u206D\u200D\u202E\u202D\u206E\u206D\u200F\u202C\u206A\u206F\u202E\u200E\u202E\u200E\u202D\u200D\u202E\u200F\u202E\u206F\u206D\u202A\u206C\u206E\u202C\u202E\u206F\u200B\u202B\u206D\u206A\u200D\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static GameEvent<GameEventArgs> \u202E\u206A\u206A\u200E\u206B\u206E\u200B\u200F\u206D\u202E\u200C\u202C\u202A\u202E\u202B\u206C\u206C\u202D\u200E\u206C\u206A\u200B\u200B\u206A\u206D\u200C\u202E\u206A\u206C\u200E\u206D\u206B\u206C\u206D\u206C\u206C\u200B\u202C\u200F\u202A\u202E(BattleController A_0)
			{
				return A_0.RoundEnded;
			}

			static GameEvent<DamageEventArgs> \u206A\u206B\u200E\u202C\u202C\u202C\u200B\u200B\u206B\u202C\u202C\u206F\u206D\u200B\u206B\u202C\u206B\u206F\u206A\u200D\u202A\u202E\u200D\u200C\u206F\u202E\u206C\u200B\u202B\u202E\u202D\u202B\u202D\u200D\u202C\u200D\u206E\u202A\u200E\u202B\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static GameEvent<UnitEventArgs> \u202A\u202D\u202C\u200C\u200E\u202A\u200B\u202A\u206B\u206F\u206B\u200D\u202C\u206B\u206D\u202A\u206A\u202D\u202D\u200E\u206C\u206E\u206B\u200B\u202B\u206B\u200D\u202C\u200B\u206C\u202A\u202D\u200D\u200C\u202B\u200C\u202A\u202C\u200C\u206A\u202E(Unit A_0)
			{
				return A_0.Escaping;
			}

			static GameObject \u202E\u206D\u202C\u206D\u200B\u206F\u200E\u206E\u202A\u202C\u200C\u200E\u206E\u202C\u206E\u206A\u200B\u202E\u202C\u202E\u200B\u206D\u206F\u202E\u200B\u206A\u200E\u200C\u200D\u200D\u200D\u202A\u206F\u206B\u200E\u206E\u206D\u202B\u206D\u206C\u202E(Component A_0)
			{
				return A_0.gameObject;
			}

			static void \u200D\u202A\u200F\u206B\u200E\u206F\u200B\u206D\u202B\u200B\u200D\u206F\u202B\u206D\u202D\u200B\u206C\u202B\u200E\u202D\u206F\u200E\u200B\u206D\u200F\u206D\u202C\u206C\u200D\u200D\u202E\u202D\u202B\u202C\u206C\u206D\u200B\u200D\u202C\u200C\u202E(GameObject A_0, bool A_1)
			{
				A_0.SetActive(A_1);
			}

			static float \u200D\u200F\u200C\u202B\u200E\u206D\u200B\u200B\u200C\u206F\u200F\u202A\u202C\u200F\u206B\u202B\u206D\u202B\u200D\u206F\u200E\u202B\u206D\u206F\u202C\u206F\u206B\u202A\u202D\u202C\u200B\u206E\u202A\u202A\u202B\u200D\u206B\u200E\u202A\u202E(float A_0, float A_1)
			{
				return Math.Min(A_0, A_1);
			}

			static UnitStatus \u206A\u206A\u206E\u206D\u206F\u206A\u200F\u200C\u206F\u200E\u202C\u200F\u206E\u202C\u202C\u206C\u202B\u200D\u202C\u200C\u200E\u200F\u206E\u206E\u200F\u202E\u206F\u200E\u202A\u202C\u200C\u206D\u200B\u202A\u200F\u202C\u202D\u206A\u206B\u200E\u202E(Unit A_0)
			{
				return A_0.Status;
			}

			static int \u206E\u206E\u200F\u200D\u200F\u206A\u202A\u200B\u206D\u200F\u200D\u206D\u202D\u200F\u206E\u206B\u206F\u202D\u202A\u206C\u200C\u206E\u206C\u200B\u200B\u200B\u206F\u200B\u202B\u200F\u200C\u202A\u200F\u200B\u206C\u206F\u206E\u202A\u202D\u202B\u202E(int A_0, int A_1)
			{
				return Math.Max(A_0, A_1);
			}

			static void \u206C\u206C\u202B\u206A\u202D\u202C\u206A\u200B\u202C\u206F\u200C\u206D\u200D\u202C\u202E\u200F\u206F\u202C\u200D\u200E\u200C\u202D\u206A\u202C\u200D\u200E\u206D\u200D\u206B\u202E\u202B\u202E\u200E\u200E\u200E\u202B\u200F\u202A\u202C\u200F\u202E(Unit A_0, int A_1)
			{
				A_0.Hp = A_1;
			}

			static GameEntity \u202D\u200E\u202D\u202A\u202A\u200E\u202E\u206F\u200C\u206E\u200B\u206E\u200E\u200E\u200E\u206B\u202B\u206C\u206C\u200B\u202A\u206A\u202A\u202A\u206A\u200F\u206E\u202B\u206A\u202C\u206A\u200B\u200F\u206F\u202B\u206D\u202C\u206A\u206E\u200D\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u206C\u200B\u200E\u206E\u200F\u206C\u202D\u202D\u202A\u206B\u200F\u202B\u202A\u200D\u206D\u202C\u200B\u206D\u200D\u202C\u206F\u202D\u200B\u200B\u202A\u202D\u202A\u206D\u202B\u206C\u200C\u206B\u200D\u206A\u206E\u200C\u200C\u206F\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u206A\u202E\u206B\u206A\u200B\u200F\u206F\u206C\u202C\u200F\u202B\u206B\u202A\u206D\u202B\u200E\u206D\u206A\u202A\u206A\u200F\u200D\u202B\u200D\u202C\u206A\u200C\u206D\u202D\u206F\u202C\u206A\u206F\u206A\u206C\u206A\u202E\u202D\u200C\u200C\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static int \u206F\u206C\u202E\u206A\u202E\u206F\u202B\u202A\u206B\u206F\u202B\u206F\u206C\u206A\u206B\u206D\u200E\u200D\u206D\u200D\u202E\u200F\u202D\u202D\u200E\u202C\u200C\u206C\u200E\u202D\u200F\u200B\u206C\u206A\u202D\u202A\u200F\u206F\u202E\u206A\u202E(RandomGen A_0, int A_1, int A_2)
			{
				return A_0.NextInt(A_1, A_2);
			}

			static GameObject \u206B\u200C\u206C\u206B\u202B\u202B\u206E\u200F\u202A\u206E\u202C\u202A\u200E\u200C\u200E\u200B\u206F\u206B\u202A\u206C\u202C\u202A\u202D\u200C\u202B\u202A\u200C\u200E\u200E\u206B\u200B\u202A\u206B\u200B\u206F\u206E\u202A\u206D\u206E\u200E\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			public int CountDown2;

			private int Threshold;

			private static GameObject scene = AyaBossKoishiDef.AyaBossKoishi.\u206B\u200C\u206C\u206B\u202B\u202B\u206E\u200F\u202A\u206E\u202C\u202A\u200E\u200C\u200E\u200B\u206F\u206B\u202A\u206C\u202C\u202A\u202D\u200C\u202B\u202A\u200C\u200E\u200E\u206B\u200B\u202A\u206B\u200B\u206F\u206E\u202A\u206D\u206E\u200E\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-659252787), null);

			private bool Blackout;

			private bool Attacking;

			private readonly RepeatableRandomPool<AyaBossKoishiDef.AyaBossKoishi.MoveType> _pool = new RepeatableRandomPool<AyaBossKoishiDef.AyaBossKoishi.MoveType>
			{
				{
					AyaBossKoishiDef.AyaBossKoishi.MoveType.DoubleShoot,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.MoveType.Shoot,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.MoveType.Defend,
					1f
				}
			};

			private readonly RepeatableRandomPool<AyaBossKoishiDef.AyaBossKoishi.InspirationType> _insPool = new RepeatableRandomPool<AyaBossKoishiDef.AyaBossKoishi.InspirationType>
			{
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.Colorless,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.White,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.Blue,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.Black,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.Red,
					1f
				},
				{
					AyaBossKoishiDef.AyaBossKoishi.InspirationType.Green,
					1f
				}
			};

			private enum MoveType
			{
				DoubleShoot,
				Shoot,
				Defend,
				Spell,
				Spell2
			}

			private enum InspirationType
			{
				Colorless,
				White,
				Blue,
				Black,
				Red,
				Green
			}
		}
	}
}
