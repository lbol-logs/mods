using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaMountainGodsProcessionDef))]
	public sealed class AyaMountainGodsProcession : Card
	{
		private string PhantasmModeDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-766890246), true, true);
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

		protected override string GetBaseDescription()
		{
			if (BepinexPlugin.AyaPhantasmMode.Value)
			{
				goto IL_0094;
			}
			IL_000F:
			int num = 1907286808;
			IL_0014:
			int num2 = num;
			switch (((-1781652961 * -351858928 - (num2 + -(~1379376203 + 1897914493 * -106993203)) - (-1366318127 - 771489931)) ^ 1996979557) % 5)
			{
			case 0:
				goto IL_000F;
			case 1:
				return this.PhantasmModeDescription;
			case 3:
				IL_0094:
				num = ((!AyaMountainGodsProcession.\u202D\u200F\u202C\u200B\u202C\u206E\u206D\u200F\u202E\u202A\u200F\u200D\u202B\u206F\u202E\u200F\u200D\u200B\u200B\u202C\u200C\u206B\u206B\u202C\u202E\u206A\u206F\u206E\u206E\u202C\u206E\u206D\u202B\u202A\u206B\u200D\u206E\u206B\u202D\u206F\u202E(this)) ? (-1584135952) : 1684610692);
				goto IL_0014;
			case 4:
				return base.GetBaseDescription();
			}
			return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
		}

		protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
		{
			AyaMountainGodsProcession.<Actions>d__5 <Actions>d__ = new AyaMountainGodsProcession.<Actions>d__5(-2);
			<Actions>d__.<>4__this = this;
			return <Actions>d__;
		}

		static bool \u202D\u200F\u202C\u200B\u202C\u206E\u206D\u200F\u202E\u202A\u200F\u200D\u202B\u206F\u202E\u200F\u200D\u200B\u200B\u202C\u200C\u206B\u206B\u202C\u202E\u206A\u206F\u206E\u206E\u202C\u206E\u206D\u202B\u202A\u206B\u200D\u206E\u206B\u202D\u206F\u202E(Card A_0)
		{
			return A_0.IsUpgraded;
		}
	}
}
