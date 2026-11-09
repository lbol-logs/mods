using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.Stages;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.EnemyUnits
{
	[EntityLogic(typeof(AyaSukusukuAyaDef))]
	public sealed class AyaSukusukuAya : EnemyUnit
	{
		public string StageName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				Stage stage = AyaSukusukuAya.\u206F\u200C\u202C\u206A\u200C\u206B\u200C\u206C\u206B\u206C\u202E\u202C\u200D\u206E\u206D\u206D\u202D\u200B\u202C\u200F\u200B\u200C\u206B\u206A\u200B\u206B\u202C\u200B\u202A\u206E\u206C\u200C\u202C\u202E\u202B\u200D\u202E\u202C\u202C\u206B\u202E(AyaSukusukuAya.\u206C\u206F\u206F\u206B\u200F\u200B\u206B\u202A\u202B\u202C\u200F\u206F\u202E\u202A\u202A\u202C\u200C\u206B\u206D\u200D\u202D\u202D\u200B\u200C\u202B\u202B\u200F\u200C\u200E\u202A\u200C\u206A\u206C\u206A\u202B\u202A\u206B\u206E\u206E\u202E\u202E(Singleton<GameMaster>.Instance));
				if (!(stage is AyaStageHakureiShrineDef.AyaStageHakureiShrine))
				{
					goto IL_001B;
				}
				goto IL_00EE;
				int num2;
				string text;
				for (;;)
				{
					IL_0020:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(~(~(num * -1826913715)) + -63904686)) % 11U)
					{
					case 1U:
						num2 = (int)(((stage is AyaStagePalaceoftheEarthSpiritsDef.AyaStagePalaceoftheEarthSpirits) ? 167211114U : 520183192U) ^ (num3 * 2849137468U));
						continue;
					case 2U:
						goto IL_001B;
					case 3U:
						text = this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1560185051), true, true);
						num2 = -1956649339;
						continue;
					case 4U:
						text = "";
						num2 = -1956649339;
						continue;
					case 5U:
						num2 = (int)((num3 * 3374709463U) ^ 1879426334U);
						continue;
					case 6U:
						goto IL_00EE;
					case 7U:
						text = this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1738684437), true, true);
						num2 = 362346898;
						continue;
					case 8U:
						num2 = (int)((num3 * 2794567789U) ^ 995479967U);
						continue;
					case 9U:
						num2 = (int)(((!(stage is AyaStageScarletDevilMansionDef.AyaStageScarletDevilMansion)) ? 1139842163U : 3542921544U) ^ (num3 * 1560174805U));
						continue;
					case 10U:
						num2 = (int)((num3 * 2107028201U) ^ 1750026521U);
						continue;
					}
					break;
				}
				return text;
				IL_001B:
				num2 = -2043304413;
				goto IL_0020;
				IL_00EE:
				text = this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1219075527), true, true);
				num2 = 1967060656;
				goto IL_0020;
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare1AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1469985758), true, true);
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare2AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-888260580), true, true);
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare3AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(702608444), true, true);
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare4AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2028360422), true, true);
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare5AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1419764650), true, true);
			}
		}

		public string AyaSukusukuAyaExtraBossPrepare6AyaSukusukuAya
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1433204142), true, true);
			}
		}

		private AyaSukusukuAya.MoveType Next { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Next = ((AyaSukusukuAya.\u206A\u206B\u200B\u200D\u200C\u200C\u200C\u206F\u206F\u206B\u202A\u202A\u200B\u200D\u200B\u200B\u200C\u200F\u202D\u202A\u200F\u206B\u206C\u206B\u202B\u206F\u200C\u200C\u202E\u200B\u200D\u202C\u206B\u202B\u202D\u206C\u200D\u202C\u202A\u202E\u202E(base.EnemyMoveRng, 0, 1) == 0) ? AyaSukusukuAya.MoveType.Suku1 : AyaSukusukuAya.MoveType.Suku2);
		}

		private IEnumerable<BattleAction> DoNothingActions()
		{
			AyaSukusukuAya.<DoNothingActions>d__19 <DoNothingActions>d__ = new AyaSukusukuAya.<DoNothingActions>d__19(-2);
			<DoNothingActions>d__.<>4__this = this;
			return <DoNothingActions>d__;
		}

		protected override IEnumerable<IEnemyMove> GetTurnMoves()
		{
			AyaSukusukuAya.<GetTurnMoves>d__20 <GetTurnMoves>d__ = new AyaSukusukuAya.<GetTurnMoves>d__20(-2);
			<GetTurnMoves>d__.<>4__this = this;
			return <GetTurnMoves>d__;
		}

		protected override void UpdateMoveCounters()
		{
			this.Next = ((AyaSukusukuAya.\u206A\u206B\u200B\u200D\u200C\u200C\u200C\u206F\u206F\u206B\u202A\u202A\u200B\u200D\u200B\u200B\u200C\u200F\u202D\u202A\u200F\u206B\u206C\u206B\u202B\u206F\u200C\u200C\u202E\u200B\u200D\u202C\u206B\u202B\u202D\u206C\u200D\u202C\u202A\u202E\u202E(base.EnemyMoveRng, 0, 1) == 0) ? AyaSukusukuAya.MoveType.Suku1 : AyaSukusukuAya.MoveType.Suku2);
		}

		static GameRunController \u206C\u206F\u206F\u206B\u200F\u200B\u206B\u202A\u202B\u202C\u200F\u206F\u202E\u202A\u202A\u202C\u200C\u206B\u206D\u200D\u202D\u202D\u200B\u200C\u202B\u202B\u200F\u200C\u200E\u202A\u200C\u206A\u206C\u206A\u202B\u202A\u206B\u206E\u206E\u202E\u202E(GameMaster A_0)
		{
			return A_0.CurrentGameRun;
		}

		static Stage \u206F\u200C\u202C\u206A\u200C\u206B\u200C\u206C\u206B\u206C\u202E\u202C\u200D\u206E\u206D\u206D\u202D\u200B\u202C\u200F\u200B\u200C\u206B\u206A\u200B\u206B\u202C\u200B\u202A\u206E\u206C\u200C\u202C\u202E\u202B\u200D\u202E\u202C\u202C\u206B\u202E(GameRunController A_0)
		{
			return A_0.CurrentStage;
		}

		static int \u206A\u206B\u200B\u200D\u200C\u200C\u200C\u206F\u206F\u206B\u202A\u202A\u200B\u200D\u200B\u200B\u200C\u200F\u202D\u202A\u200F\u206B\u206C\u206B\u202B\u206F\u200C\u200C\u202E\u200B\u200D\u202C\u206B\u202B\u202D\u206C\u200D\u202C\u202A\u202E\u202E(RandomGen A_0, int A_1, int A_2)
		{
			return A_0.NextInt(A_1, A_2);
		}

		private enum MoveType
		{
			Suku1,
			Suku2
		}
	}
}
