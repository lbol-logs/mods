using System;
using System.Collections.Generic;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.EntityLib.Cards;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaOrbGreenMorphFrogDef))]
	public sealed class AyaOrbGreenMorphFrog : OptionCard
	{
		public override int AdditionalValue1
		{
			get
			{
				if (AyaOrbGreenMorphFrog.\u202B\u206A\u200F\u202A\u200B\u202C\u202B\u206F\u202A\u206D\u206D\u200E\u200E\u202E\u202C\u200D\u206D\u200E\u200E\u200F\u202B\u206F\u202A\u200C\u202D\u206F\u206D\u202D\u200F\u206D\u206D\u200D\u206D\u206D\u206D\u206B\u200D\u202D\u202A\u206E\u202E(Singleton<GameMaster>.Instance) == null)
				{
					for (;;)
					{
						int num = 1691341582;
						switch ((((num * -1367315523) ^ (-1952302749 * 1488040410 + (-1946311114 - -1855557622)) ^ -501880209) - -66593147) % 3)
						{
						case 0:
							continue;
						case 1:
							return 10;
						}
						break;
					}
				}
				return AyaOrbGreenMorphFrog.\u200D\u202D\u202C\u200B\u200D\u206F\u202B\u206E\u200D\u200E\u206A\u206B\u206D\u200D\u206B\u206E\u200F\u200B\u200C\u206B\u202B\u202E\u200C\u206F\u202E\u206B\u200C\u202B\u206E\u206E\u202B\u202C\u200E\u200F\u206A\u206D\u206D\u202E\u200C\u202E(AyaOrbGreenMorphFrog.\u200F\u200F\u202D\u206B\u206C\u200F\u206E\u206C\u200D\u206C\u200F\u200E\u206E\u206D\u200E\u202C\u206F\u206D\u206F\u202A\u200C\u202B\u202D\u206A\u200D\u206D\u200D\u200F\u206D\u200E\u206B\u206C\u200F\u202B\u202E\u200F\u206E\u206F\u202B\u206D\u202E((int)(AyaOrbGreenMorphFrog.\u200D\u206D\u200F\u200B\u202A\u200E\u206F\u206C\u202E\u206E\u200B\u206D\u200E\u202D\u206C\u200F\u202B\u206D\u200E\u206F\u202E\u206A\u206D\u200C\u206D\u206F\u206E\u202C\u202B\u202D\u202A\u202B\u206E\u202A\u206D\u206B\u202A\u206C\u200F\u206B\u202E(AyaOrbGreenMorphFrog.\u202B\u206A\u200F\u202A\u200B\u202C\u202B\u206F\u202A\u206D\u206D\u200E\u200E\u202E\u202C\u200D\u206D\u200E\u200E\u200F\u202B\u206F\u202A\u200C\u202D\u206F\u206D\u202D\u200F\u206D\u206D\u200D\u206D\u206D\u206D\u206B\u200D\u202D\u202A\u206E\u202E(Singleton<GameMaster>.Instance)) * (GameDifficulty)10), 30), 10);
			}
		}

		public override IEnumerable<BattleAction> TakeEffectActions()
		{
			AyaOrbGreenMorphFrog.<TakeEffectActions>d__2 <TakeEffectActions>d__ = new AyaOrbGreenMorphFrog.<TakeEffectActions>d__2(-2);
			<TakeEffectActions>d__.<>4__this = this;
			return <TakeEffectActions>d__;
		}

		static GameRunController \u202B\u206A\u200F\u202A\u200B\u202C\u202B\u206F\u202A\u206D\u206D\u200E\u200E\u202E\u202C\u200D\u206D\u200E\u200E\u200F\u202B\u206F\u202A\u200C\u202D\u206F\u206D\u202D\u200F\u206D\u206D\u200D\u206D\u206D\u206D\u206B\u200D\u202D\u202A\u206E\u202E(GameMaster A_0)
		{
			return A_0.CurrentGameRun;
		}

		static GameDifficulty \u200D\u206D\u200F\u200B\u202A\u200E\u206F\u206C\u202E\u206E\u200B\u206D\u200E\u202D\u206C\u200F\u202B\u206D\u200E\u206F\u202E\u206A\u206D\u200C\u206D\u206F\u206E\u202C\u202B\u202D\u202A\u202B\u206E\u202A\u206D\u206B\u202A\u206C\u200F\u206B\u202E(GameRunController A_0)
		{
			return A_0.Difficulty;
		}

		static int \u200F\u200F\u202D\u206B\u206C\u200F\u206E\u206C\u200D\u206C\u200F\u200E\u206E\u206D\u200E\u202C\u206F\u206D\u206F\u202A\u200C\u202B\u202D\u206A\u200D\u206D\u200D\u200F\u206D\u200E\u206B\u206C\u200F\u202B\u202E\u200F\u206E\u206F\u202B\u206D\u202E(int A_0, int A_1)
		{
			return Math.Min(A_0, A_1);
		}

		static int \u200D\u202D\u202C\u200B\u200D\u206F\u202B\u206E\u200D\u200E\u206A\u206B\u206D\u200D\u206B\u206E\u200F\u200B\u200C\u206B\u202B\u202E\u200C\u206F\u202E\u206B\u200C\u202B\u206E\u206E\u202B\u202C\u200E\u200F\u206A\u206D\u206D\u202E\u200C\u202E(int A_0, int A_1)
		{
			return Math.Max(A_0, A_1);
		}
	}
}
