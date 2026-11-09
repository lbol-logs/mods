using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaOpeningWindoftheTenguRealmDef))]
	public sealed class AyaOpeningWindoftheTenguRealm : Card
	{
		protected override void OnEnterBattle(BattleController battle)
		{
			base.ReactBattleEvent<GameEventArgs>(AyaOpeningWindoftheTenguRealm.\u206F\u206D\u200E\u200D\u200F\u202B\u206D\u202B\u202E\u206F\u206D\u206B\u206C\u206A\u206E\u200B\u200B\u206A\u200B\u200C\u200B\u202B\u206C\u206C\u202C\u200E\u200B\u206B\u206E\u202E\u202B\u206A\u200C\u202E\u202C\u200F\u200B\u206B\u200B\u200C\u202E(AyaOpeningWindoftheTenguRealm.\u200B\u200B\u202C\u202B\u200C\u200D\u206F\u200E\u206A\u206C\u206C\u200D\u202E\u206D\u202C\u200B\u202D\u206A\u206E\u206A\u202B\u206A\u200B\u200D\u200B\u200C\u206A\u206F\u200F\u200C\u202C\u202C\u206C\u202E\u202A\u202D\u206C\u202D\u200C\u202D\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
		}

		private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
		{
			AyaOpeningWindoftheTenguRealm.<OnBattleStarted>d__1 <OnBattleStarted>d__ = new AyaOpeningWindoftheTenguRealm.<OnBattleStarted>d__1(-2);
			<OnBattleStarted>d__.<>4__this = this;
			return <OnBattleStarted>d__;
		}

		static BattleController \u200B\u200B\u202C\u202B\u200C\u200D\u206F\u200E\u206A\u206C\u206C\u200D\u202E\u206D\u202C\u200B\u202D\u206A\u206E\u206A\u202B\u206A\u200B\u200D\u200B\u200C\u206A\u206F\u200F\u200C\u202C\u202C\u206C\u202E\u202A\u202D\u206C\u202D\u200C\u202D\u202E(Card A_0)
		{
			return A_0.Battle;
		}

		static GameEvent<GameEventArgs> \u206F\u206D\u200E\u200D\u200F\u202B\u206D\u202B\u202E\u206F\u206D\u206B\u206C\u206A\u206E\u200B\u200B\u206A\u200B\u200C\u200B\u202B\u206C\u206C\u202C\u200E\u200B\u206B\u206E\u202E\u202B\u206A\u200C\u202E\u202C\u200F\u200B\u206B\u200B\u200C\u202E(BattleController A_0)
		{
			return A_0.BattleStarted;
		}
	}
}
