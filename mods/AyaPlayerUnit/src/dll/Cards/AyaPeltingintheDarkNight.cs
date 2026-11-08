using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaPeltingintheDarkNightDef))]
	public sealed class AyaPeltingintheDarkNight : Card
	{
		public override bool DiscardCard
		{
			get
			{
				return true;
			}
		}

		public override bool OnDrawVisual
		{
			get
			{
				return false;
			}
		}

		public override bool OnMoveVisual
		{
			get
			{
				return false;
			}
		}

		public int Count { get; set; }

		protected override string GetBaseDescription()
		{
			if (this.Count >= AyaPeltingintheDarkNight.\u200C\u200E\u206D\u200E\u202B\u206D\u206A\u200C\u206F\u200C\u206D\u206D\u202E\u202E\u206A\u202C\u200D\u202D\u206A\u202C\u202A\u200F\u206B\u200F\u200C\u202A\u202B\u202B\u202E\u202C\u206F\u206A\u200F\u200E\u206E\u200F\u206D\u206A\u200E\u202E\u202E(this))
			{
				for (;;)
				{
					int num = -623831207;
					switch (-(~(num ^ (1215130833 * (-113811060 - -1623934834 - -413551527 * 365796183))) * 1495066865) % 3)
					{
					case 1:
						goto IL_0052;
					case 2:
						continue;
					}
					break;
				}
				goto IL_0068;
				IL_0052:
				return base.ExtraDescription1;
			}
			IL_0068:
			return base.GetBaseDescription();
		}

		public override IEnumerable<BattleAction> OnDraw()
		{
			return this.EnterHandReactor();
		}

		public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
		{
			if (dstZone != CardZone.Hand)
			{
				for (;;)
				{
					int num = 1553435441;
					switch ((-num + -2117407906) % 3)
					{
					case 0:
						continue;
					case 1:
						goto IL_0029;
					}
					break;
				}
				goto IL_003A;
				IL_0029:
				return null;
			}
			IL_003A:
			return this.EnterHandReactor();
		}

		protected override void OnEnterBattle(BattleController battle)
		{
			this.Count = 0;
			for (;;)
			{
				IL_0007:
				int num = -1984302202;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((num2 * -1960682925) ^ (-1079130914 - -2045549619) ^ ~-979865506) - 491805675)) % 5U)
					{
					case 0U:
						base.HandleBattleEvent<UnitEventArgs>(AyaPeltingintheDarkNight.\u202A\u206C\u200E\u202E\u200F\u202C\u206E\u206B\u206A\u202C\u206F\u200F\u202A\u200B\u202D\u200F\u202C\u206C\u200C\u202B\u206A\u206C\u202C\u202E\u202B\u206A\u202D\u200C\u202E\u206D\u206B\u206C\u202C\u206F\u206E\u202E\u202E\u200F\u206E\u200F\u202E(AyaPeltingintheDarkNight.\u206B\u202E\u202C\u200C\u202E\u206B\u206A\u200B\u200E\u202E\u200B\u206D\u206D\u206A\u200F\u200B\u202A\u202B\u206A\u206E\u206E\u206C\u206C\u200D\u200C\u200C\u202C\u202B\u206A\u206E\u200D\u200D\u202D\u206A\u200F\u202C\u206C\u206E\u206E\u202A\u202E(AyaPeltingintheDarkNight.\u200E\u206F\u200B\u200B\u206D\u206E\u200E\u202C\u206C\u202B\u206E\u206B\u206C\u202C\u202C\u206D\u206E\u206E\u206C\u206E\u200D\u202E\u202A\u202D\u200C\u206F\u206D\u202D\u206E\u206B\u200B\u202E\u206B\u202C\u202C\u200F\u202E\u206F\u206D\u202A\u202E(this))), new GameEventHandler<UnitEventArgs>(this.OnPlayerTurnStarting), (GameEventPriority)0);
						num = 1172636092;
						continue;
					case 1U:
						num = (int)(((AyaPeltingintheDarkNight.\u202A\u206B\u206C\u200E\u202D\u206F\u200F\u200E\u200B\u206A\u200D\u200E\u200D\u202C\u206E\u206F\u206B\u206D\u206B\u202D\u206A\u202D\u200B\u200F\u200E\u206F\u206D\u202A\u206D\u200F\u206F\u206E\u200F\u202A\u200E\u206D\u206E\u202C\u202C\u206C\u202E(this) == CardZone.Hand) ? 619961553U : 123531105U) ^ (num3 * 485426192U));
						continue;
					case 2U:
						base.React(new LazySequencedReactor(this.AddToHandReactor));
						num = (int)((num3 * 4103773907U) ^ 1053582425U);
						continue;
					case 4U:
						goto IL_0007;
					}
					return;
				}
			}
		}

		private void OnPlayerTurnStarting(UnitEventArgs args)
		{
			this.Count = 0;
		}

		private IEnumerable<BattleAction> AddToHandReactor()
		{
			AyaPeltingintheDarkNight.<AddToHandReactor>d__15 <AddToHandReactor>d__ = new AyaPeltingintheDarkNight.<AddToHandReactor>d__15(-2);
			<AddToHandReactor>d__.<>4__this = this;
			return <AddToHandReactor>d__;
		}

		private IEnumerable<BattleAction> EnterHandReactor()
		{
			AyaPeltingintheDarkNight.<EnterHandReactor>d__16 <EnterHandReactor>d__ = new AyaPeltingintheDarkNight.<EnterHandReactor>d__16(-2);
			<EnterHandReactor>d__.<>4__this = this;
			return <EnterHandReactor>d__;
		}

		static int \u200C\u200E\u206D\u200E\u202B\u206D\u206A\u200C\u206F\u200C\u206D\u206D\u202E\u202E\u206A\u202C\u200D\u202D\u206A\u202C\u202A\u200F\u206B\u200F\u200C\u202A\u202B\u202B\u202E\u202C\u206F\u206A\u200F\u200E\u206E\u200F\u206D\u206A\u200E\u202E\u202E(Card A_0)
		{
			return A_0.Value1;
		}

		static CardZone \u202A\u206B\u206C\u200E\u202D\u206F\u200F\u200E\u200B\u206A\u200D\u200E\u200D\u202C\u206E\u206F\u206B\u206D\u206B\u202D\u206A\u202D\u200B\u200F\u200E\u206F\u206D\u202A\u206D\u200F\u206F\u206E\u200F\u202A\u200E\u206D\u206E\u202C\u202C\u206C\u202E(Card A_0)
		{
			return A_0.Zone;
		}

		static BattleController \u200E\u206F\u200B\u200B\u206D\u206E\u200E\u202C\u206C\u202B\u206E\u206B\u206C\u202C\u202C\u206D\u206E\u206E\u206C\u206E\u200D\u202E\u202A\u202D\u200C\u206F\u206D\u202D\u206E\u206B\u200B\u202E\u206B\u202C\u202C\u200F\u202E\u206F\u206D\u202A\u202E(Card A_0)
		{
			return A_0.Battle;
		}

		static PlayerUnit \u206B\u202E\u202C\u200C\u202E\u206B\u206A\u200B\u200E\u202E\u200B\u206D\u206D\u206A\u200F\u200B\u202A\u202B\u206A\u206E\u206E\u206C\u206C\u200D\u200C\u200C\u202C\u202B\u206A\u206E\u200D\u200D\u202D\u206A\u200F\u202C\u206C\u206E\u206E\u202A\u202E(BattleController A_0)
		{
			return A_0.Player;
		}

		static GameEvent<UnitEventArgs> \u202A\u206C\u200E\u202E\u200F\u202C\u206E\u206B\u206A\u202C\u206F\u200F\u202A\u200B\u202D\u200F\u202C\u206C\u200C\u202B\u206A\u206C\u202C\u202E\u202B\u206A\u202D\u200C\u202E\u206D\u206B\u206C\u202C\u206F\u206E\u202E\u202E\u200F\u206E\u200F\u202E(Unit A_0)
		{
			return A_0.TurnStarting;
		}
	}
}
