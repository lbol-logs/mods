using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaRouteForbiddentoManDef))]
	public sealed class AyaRouteForbiddentoMan : Card
	{
		public override ManaGroup? PlentifulMana
		{
			get
			{
				if (!AyaRouteForbiddentoMan.\u200D\u206E\u202D\u202B\u202E\u206F\u202C\u202B\u206E\u202C\u200D\u200D\u200C\u206A\u206A\u200E\u206E\u206C\u202D\u200E\u206B\u202A\u200E\u206E\u206B\u202C\u202A\u200E\u200E\u206E\u206D\u206B\u200D\u202E\u200F\u200C\u202A\u206E\u200F\u200F\u202E(this))
				{
					goto IL_007D;
				}
				IL_0008:
				int num = 107637115;
				IL_000D:
				int num2 = num;
				ManaGroup? manaGroup;
				switch ((num2 - ~(-1750394741 ^ (-1822486989 + -1364072903)) + ((-1263923229 - 1963331191) ^ -188502248) + (-1392417019 ^ -760618803)) * -652701119 % 4)
				{
				case 0:
					IL_007D:
					manaGroup = null;
					num = 715814421;
					goto IL_000D;
				case 2:
					goto IL_0008;
				case 3:
					return new ManaGroup?(AyaRouteForbiddentoMan.\u202B\u200E\u206A\u202E\u206F\u206A\u202A\u202E\u206D\u200C\u200F\u206B\u202A\u200C\u200E\u200B\u206F\u206D\u202E\u200B\u202D\u202E\u206B\u200D\u206C\u200B\u200B\u200E\u200E\u206E\u202D\u206A\u200E\u202B\u200C\u202B\u206B\u200F\u202C\u206B\u202E(this));
				}
				return manaGroup;
			}
		}

		private string PhantasmModeDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1578089449), true, true);
			}
		}

		private string PhantasmModeUpgradedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-561002541), true, true);
			}
		}

		private string PhantasmModeUpgradedExtraDescription1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1426035101), true, true);
			}
		}

		protected override string GetBaseDescription()
		{
			if (!BepinexPlugin.AyaPhantasmMode.Value)
			{
				goto IL_000F;
			}
			goto IL_00F0;
			int num2;
			for (;;)
			{
				IL_0014:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)(((num ^ (-1448131392 - 1693766019)) - 1089787325 * (-1941332569 ^ 305064001)) * 791556335 + -1301782529)) % 9U)
				{
				case 0U:
					goto IL_000F;
				case 1U:
					num2 = (int)((AyaRouteForbiddentoMan.\u202E\u206B\u200E\u206A\u206C\u206F\u202D\u206F\u200B\u202D\u202D\u202A\u206F\u206E\u206D\u206A\u206C\u202A\u202A\u202C\u202A\u206E\u202A\u200C\u200B\u206C\u206D\u206E\u200E\u202B\u206A\u202A\u200D\u202D\u206A\u202D\u202C\u206D\u200E\u200E\u202E(this) ? 3721830741U : 1458830828U) ^ (num3 * 1538190815U));
					continue;
				case 2U:
					goto IL_00F0;
				case 3U:
					goto IL_0089;
				case 4U:
					goto IL_009A;
				case 5U:
					num2 = ((!AyaRouteForbiddentoMan.\u200D\u206E\u202D\u202B\u202E\u206F\u202C\u202B\u206E\u202C\u200D\u200D\u200C\u206A\u206A\u200E\u206E\u206C\u202D\u200E\u206B\u202A\u200E\u206E\u206B\u202C\u202A\u200E\u200E\u206E\u206D\u206B\u200D\u202E\u200F\u200C\u202A\u206E\u200F\u200F\u202E(this)) ? (-1337193144) : (-896635212));
					continue;
				case 7U:
					goto IL_0073;
				case 8U:
					goto IL_00B3;
				}
				break;
			}
			goto IL_0128;
			IL_0073:
			return this.PhantasmModeUpgradedExtraDescription1;
			IL_0089:
			return base.GetBaseDescription();
			IL_009A:
			return this.PhantasmModeDescription;
			IL_00B3:
			return base.UpgradedExtraDescription1;
			IL_0128:
			return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			IL_000F:
			num2 = 1510293797;
			goto IL_0014;
			IL_00F0:
			num2 = (AyaRouteForbiddentoMan.\u202E\u206B\u200E\u206A\u206C\u206F\u202D\u206F\u200B\u202D\u202D\u202A\u206F\u206E\u206D\u206A\u206C\u202A\u202A\u202C\u202A\u206E\u202A\u200C\u200B\u206C\u206D\u206E\u200E\u202B\u206A\u202A\u200D\u202D\u206A\u202D\u202C\u206D\u200E\u200E\u202E(this) ? 132754598 : (-1094150381));
			goto IL_0014;
		}

		private int Value3 { get; set; }

		protected override void OnEnterBattle(BattleController battle)
		{
			base.HandleBattleEvent<UnitEventArgs>(AyaRouteForbiddentoMan.\u206E\u202B\u202A\u206B\u206F\u206F\u206C\u206E\u202E\u206C\u202D\u202A\u200D\u200B\u200C\u202B\u200D\u206A\u202B\u206B\u206B\u202B\u202A\u200F\u202E\u200C\u202C\u200B\u202D\u206B\u206E\u200B\u202C\u202C\u202E\u206A\u206C\u202D\u206E\u200D\u202E(AyaRouteForbiddentoMan.\u206C\u202D\u206E\u202E\u206D\u206D\u202B\u206A\u206C\u202B\u206B\u202B\u206B\u202A\u202A\u202A\u202B\u202D\u206A\u206D\u206C\u206C\u200D\u200C\u202C\u206E\u202B\u200B\u200E\u202A\u202A\u200E\u200D\u202A\u206A\u202B\u202A\u200D\u200C\u202D\u202E(AyaRouteForbiddentoMan.\u202E\u202B\u206A\u200F\u200F\u206D\u206D\u200D\u202C\u206F\u202C\u200E\u202C\u200E\u206F\u206C\u202C\u206D\u206E\u202D\u206D\u206B\u206E\u206D\u202E\u202D\u206F\u206D\u206B\u206D\u206F\u202A\u206C\u206B\u206B\u202A\u206E\u206B\u206E\u202E\u202E(this))), new GameEventHandler<UnitEventArgs>(this.OnPlayerTurnStarting), (GameEventPriority)0);
			base.HandleBattleEvent<CardEventArgs>(AyaRouteForbiddentoMan.\u202C\u206C\u206B\u202C\u206A\u206F\u206D\u200C\u200D\u202A\u202B\u206D\u202C\u206E\u206A\u202D\u206F\u206F\u206B\u200B\u206B\u200C\u206B\u202E\u202D\u200C\u202E\u206F\u202E\u206D\u206F\u200C\u202D\u206F\u200C\u200C\u202E\u200E\u202E\u206B\u202E(AyaRouteForbiddentoMan.\u202E\u202B\u206A\u200F\u200F\u206D\u206D\u200D\u202C\u206F\u202C\u200E\u202C\u200E\u206F\u206C\u202C\u206D\u206E\u202D\u206D\u206B\u206E\u206D\u202E\u202D\u206F\u206D\u206B\u206D\u206F\u202A\u206C\u206B\u206B\u202A\u206E\u206B\u206E\u202E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardExiled), (GameEventPriority)0);
		}

		private void OnPlayerTurnStarting(UnitEventArgs args)
		{
			this.Value3 = 0;
		}

		private void OnCardExiled(CardEventArgs args)
		{
			int value = this.Value3;
			for (;;)
			{
				IL_0007:
				int num = 770328196;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(860893481 - -((~754492245 ^ (-907580745 ^ -125855857) ^ ((-313203157 ^ -1706914962) - 2013797444)) - num2) * 1548962441)) % 3U)
					{
					case 0U:
						goto IL_0007;
					case 2U:
						this.Value3 = value + 1;
						num = (int)((num3 * 3330534626U) ^ 522800378U);
						continue;
					}
					return;
				}
			}
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaRouteForbiddentoMan.<Actions>d__16 <Actions>d__ = new AyaRouteForbiddentoMan.<Actions>d__16(-2);
			<Actions>d__.<>4__this = this;
			return <Actions>d__;
		}

		static bool \u200D\u206E\u202D\u202B\u202E\u206F\u202C\u202B\u206E\u202C\u200D\u200D\u200C\u206A\u206A\u200E\u206E\u206C\u202D\u200E\u206B\u202A\u200E\u206E\u206B\u202C\u202A\u200E\u200E\u206E\u206D\u206B\u200D\u202E\u200F\u200C\u202A\u206E\u200F\u200F\u202E(Card A_0)
		{
			return A_0.IsUpgraded;
		}

		static ManaGroup \u202B\u200E\u206A\u202E\u206F\u206A\u202A\u202E\u206D\u200C\u200F\u206B\u202A\u200C\u200E\u200B\u206F\u206D\u202E\u200B\u202D\u202E\u206B\u200D\u206C\u200B\u200B\u200E\u200E\u206E\u202D\u206A\u200E\u202B\u200C\u202B\u206B\u200F\u202C\u206B\u202E(Card A_0)
		{
			return A_0.Mana;
		}

		static bool \u202E\u206B\u200E\u206A\u206C\u206F\u202D\u206F\u200B\u202D\u202D\u202A\u206F\u206E\u206D\u206A\u206C\u202A\u202A\u202C\u202A\u206E\u202A\u200C\u200B\u206C\u206D\u206E\u200E\u202B\u206A\u202A\u200D\u202D\u206A\u202D\u202C\u206D\u200E\u200E\u202E(Card A_0)
		{
			return A_0.PlentifulHappenThisTurn;
		}

		static BattleController \u202E\u202B\u206A\u200F\u200F\u206D\u206D\u200D\u202C\u206F\u202C\u200E\u202C\u200E\u206F\u206C\u202C\u206D\u206E\u202D\u206D\u206B\u206E\u206D\u202E\u202D\u206F\u206D\u206B\u206D\u206F\u202A\u206C\u206B\u206B\u202A\u206E\u206B\u206E\u202E\u202E(Card A_0)
		{
			return A_0.Battle;
		}

		static PlayerUnit \u206C\u202D\u206E\u202E\u206D\u206D\u202B\u206A\u206C\u202B\u206B\u202B\u206B\u202A\u202A\u202A\u202B\u202D\u206A\u206D\u206C\u206C\u200D\u200C\u202C\u206E\u202B\u200B\u200E\u202A\u202A\u200E\u200D\u202A\u206A\u202B\u202A\u200D\u200C\u202D\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameEvent<UnitEventArgs> \u206E\u202B\u202A\u206B\u206F\u206F\u206C\u206E\u202E\u206C\u202D\u202A\u200D\u200B\u200C\u202B\u200D\u206A\u202B\u206B\u206B\u202B\u202A\u200F\u202E\u200C\u202C\u200B\u202D\u206B\u206E\u200B\u202C\u202C\u202E\u206A\u206C\u202D\u206E\u200D\u202E(Unit A_0)
		{
			return A_0.TurnStarting;
		}

		static GameEvent<CardEventArgs> \u202C\u206C\u206B\u202C\u206A\u206F\u206D\u200C\u200D\u202A\u202B\u206D\u202C\u206E\u206A\u202D\u206F\u206F\u206B\u200B\u206B\u200C\u206B\u202E\u202D\u200C\u202E\u206F\u202E\u206D\u206F\u200C\u202D\u206F\u200C\u200C\u202E\u200E\u202E\u206B\u202E(BattleController A_0)
		{
			return A_0.CardExiled;
		}
	}
}
