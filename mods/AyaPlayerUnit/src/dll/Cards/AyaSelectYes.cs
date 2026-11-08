using System;
using AyaShameimaru.PlayerUnits;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaSelectYesDef))]
	public sealed class AyaSelectYes : Card
	{
		public override string Description
		{
			get
			{
				int? num = AyaSelectYes.\u206E\u202B\u206C\u200B\u200D\u200F\u206B\u206F\u202B\u202E\u206C\u200E\u202E\u200B\u202C\u202E\u206A\u200E\u202E\u202A\u202B\u202D\u202A\u206F\u206C\u202B\u200B\u200B\u202B\u200E\u202E\u202B\u206E\u202B\u202A\u206F\u206C\u200D\u206A\u202E(this);
				string text2;
				for (;;)
				{
					IL_0007:
					int num2 = 1377999703;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						string text;
						switch ((num4 = (uint)(-(-1476210235 - (num3 + (-69493715 ^ ((824119581 ^ -1221625447) - --1252347528)))) * 737439477)) % 11U)
						{
						case 0U:
							num2 = (int)((num4 * 1127162532U) ^ 1151339342U);
							continue;
						case 1U:
							num2 = (int)((num4 * 2029571380U) ^ 2673040949U);
							continue;
						case 2U:
						{
							GameRunController gameRunController = AyaSelectYes.\u200B\u200D\u206B\u202D\u202D\u206F\u202D\u200C\u202D\u206B\u202B\u202B\u206A\u200E\u202E\u206E\u200E\u202A\u206D\u202B\u202C\u206C\u206F\u206E\u206C\u206B\u200E\u200B\u202B\u206D\u206C\u200C\u202A\u206E\u206F\u206F\u206A\u202A\u200F\u202C\u202E(Singleton<GameMaster>.Instance);
							FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? AyaSelectYes.\u202B\u200B\u202E\u200F\u206B\u206F\u206B\u200D\u202B\u202A\u202A\u200D\u206A\u200B\u206C\u200B\u202A\u200F\u202B\u200D\u202C\u202E\u200B\u200F\u206E\u202D\u206C\u206A\u206D\u200C\u206E\u202A\u202E\u206A\u206D\u206E\u202E\u200E\u200E\u200C\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
							if (flandrePlayerUnit == null)
							{
								num2 = 992841858;
								continue;
							}
							text = flandrePlayerUnit.FlandreEikiYesDescription;
							goto IL_00E6;
						}
						case 3U:
						{
							int valueOrDefault = num.GetValueOrDefault();
							num2 = (int)(((valueOrDefault == 0) ? 2547276156U : 1444381785U) ^ (num4 * 502530158U));
							continue;
						}
						case 4U:
							text = AyaSelectYes.\u206E\u206F\u206E\u206B\u206D\u202E\u206B\u202E\u200F\u206C\u202B\u206D\u202E\u206F\u206C\u206F\u206E\u202E\u200B\u200F\u206C\u200C\u206D\u200C\u206A\u202A\u202D\u206B\u206B\u206B\u206D\u202D\u200C\u206C\u202E\u200F\u206E\u200C\u206D\u200C\u202E(base.BaseDescription, AyaSelectYes.\u202E\u200C\u202A\u202B\u202C\u200E\u206E\u200F\u202B\u202A\u202E\u206A\u200E\u200D\u206C\u200D\u206F\u200B\u206C\u200E\u206E\u206F\u206D\u202D\u202A\u202B\u202B\u206A\u200C\u202B\u206D\u202B\u200F\u206E\u206C\u206C\u202A\u202D\u202D\u206A\u202E(this));
							goto IL_00E6;
						case 5U:
							goto IL_0007;
						case 6U:
							text2 = AyaSelectYes.\u206E\u206F\u206E\u206B\u206D\u202E\u206B\u202E\u200F\u206C\u202B\u206D\u202E\u206F\u206C\u206F\u206E\u202E\u200B\u200F\u206C\u200C\u206D\u200C\u206A\u202A\u202D\u206B\u206B\u206B\u206D\u202D\u200C\u206C\u202E\u200F\u206E\u200C\u206D\u200C\u202E(base.BaseDescription, AyaSelectYes.\u202E\u200C\u202A\u202B\u202C\u200E\u206E\u200F\u202B\u202A\u202E\u206A\u200E\u200D\u206C\u200D\u206F\u200B\u206C\u200E\u206E\u206F\u206D\u202D\u202A\u202B\u202B\u206A\u200C\u202B\u206D\u202B\u200F\u206E\u206C\u206C\u202A\u202D\u202D\u206A\u202E(this));
							num2 = -1040625223;
							continue;
						case 8U:
							text2 = AyaSelectYes.\u206E\u206F\u206E\u206B\u206D\u202E\u206B\u202E\u200F\u206C\u202B\u206D\u202E\u206F\u206C\u206F\u206E\u202E\u200B\u200F\u206C\u200C\u206D\u200C\u206A\u202A\u202D\u206B\u206B\u206B\u206D\u202D\u200C\u206C\u202E\u200F\u206E\u200C\u206D\u200C\u202E(base.BaseDescription, AyaSelectYes.\u202E\u200C\u202A\u202B\u202C\u200E\u206E\u200F\u202B\u202A\u202E\u206A\u200E\u200D\u206C\u200D\u206F\u200B\u206C\u200E\u206E\u206F\u206D\u202D\u202A\u202B\u202B\u206A\u200C\u202B\u206D\u202B\u200F\u206E\u206C\u206C\u202A\u202D\u202D\u206A\u202E(this));
							num2 = -219753273;
							continue;
						case 9U:
						{
							int valueOrDefault;
							num2 = (int)(((valueOrDefault != 2) ? 778036504U : 2145046033U) ^ (num4 * 4124635638U));
							continue;
						}
						case 10U:
							num2 = (int)(((num != null) ? 3514636911U : 2856049417U) ^ (num4 * 39778737U));
							continue;
						}
						return text2;
						IL_00E6:
						text2 = text;
						num2 = -1040625223;
					}
				}
				return text2;
			}
		}

		public override string Name
		{
			get
			{
				int? num = AyaSelectYes.\u206E\u202B\u206C\u200B\u200D\u200F\u206B\u206F\u202B\u202E\u206C\u200E\u202E\u200B\u202C\u202E\u206A\u200E\u202E\u202A\u202B\u202D\u202A\u206F\u206C\u202B\u200B\u200B\u202B\u200E\u202E\u202B\u206E\u202B\u202A\u206F\u206C\u200D\u206A\u202E(this);
				string text2;
				for (;;)
				{
					IL_0007:
					int num2 = 2044365026;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						string text;
						switch ((num4 = (uint)(~(uint)(~(uint)num3))) % 12U)
						{
						case 0U:
						{
							int valueOrDefault;
							num2 = (int)(((valueOrDefault == 0) ? 1322704099U : 1945662895U) ^ (num4 * 3556116842U));
							continue;
						}
						case 1U:
							text = base.BaseName;
							goto IL_009E;
						case 2U:
							num2 = (int)(((num == null) ? 2863556348U : 3298547395U) ^ (num4 * 1269209033U));
							continue;
						case 3U:
							text2 = base.BaseName;
							num2 = 1962208950;
							continue;
						case 4U:
						{
							GameRunController gameRunController = AyaSelectYes.\u200B\u200D\u206B\u202D\u202D\u206F\u202D\u200C\u202D\u206B\u202B\u202B\u206A\u200E\u202E\u206E\u200E\u202A\u206D\u202B\u202C\u206C\u206F\u206E\u206C\u206B\u200E\u200B\u202B\u206D\u206C\u200C\u202A\u206E\u206F\u206F\u206A\u202A\u200F\u202C\u202E(Singleton<GameMaster>.Instance);
							FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? AyaSelectYes.\u202B\u200B\u202E\u200F\u206B\u206F\u206B\u200D\u202B\u202A\u202A\u200D\u206A\u200B\u206C\u200B\u202A\u200F\u202B\u200D\u202C\u202E\u200B\u200F\u206E\u202D\u206C\u206A\u206D\u200C\u206E\u202A\u202E\u206A\u206D\u206E\u202E\u200E\u200E\u200C\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
							if (flandrePlayerUnit == null)
							{
								num2 = 323082685;
								continue;
							}
							text = flandrePlayerUnit.FlandreEikiYesName;
							goto IL_009E;
						}
						case 5U:
							num2 = (int)((num4 * 2363320290U) ^ 386349972U);
							continue;
						case 6U:
							num2 = (int)((num4 * 1580772799U) ^ 2284522741U);
							continue;
						case 7U:
						{
							int valueOrDefault;
							num2 = (int)(((valueOrDefault != 2) ? 308923546U : 1171235091U) ^ (num4 * 1491388753U));
							continue;
						}
						case 8U:
							goto IL_0007;
						case 9U:
						{
							int valueOrDefault = num.GetValueOrDefault();
							num2 = (int)((num4 * 1203665288U) ^ 3797562852U);
							continue;
						}
						case 10U:
							text2 = base.BaseName;
							num2 = 1542724415;
							continue;
						}
						return text2;
						IL_009E:
						text2 = text;
						num2 = 1542724415;
					}
				}
				return text2;
			}
		}

		static int? \u206E\u202B\u206C\u200B\u200D\u200F\u206B\u206F\u202B\u202E\u206C\u200E\u202E\u200B\u202C\u202E\u206A\u200E\u202E\u202A\u202B\u202D\u202A\u206F\u206C\u202B\u200B\u200B\u202B\u200E\u202E\u202B\u206E\u202B\u202A\u206F\u206C\u200D\u206A\u202E(Card A_0)
		{
			return A_0.DeckCounter;
		}

		static GameEntityFormatWrapper \u202E\u200C\u202A\u202B\u202C\u200E\u206E\u200F\u202B\u202A\u202E\u206A\u200E\u200D\u206C\u200D\u206F\u200B\u206C\u200E\u206E\u206F\u206D\u202D\u202A\u202B\u202B\u206A\u200C\u202B\u206D\u202B\u200F\u206E\u206C\u206C\u202A\u202D\u202D\u206A\u202E(GameEntity A_0)
		{
			return A_0.FormatWrapper;
		}

		static string \u206E\u206F\u206E\u206B\u206D\u202E\u206B\u202E\u200F\u206C\u202B\u206D\u202E\u206F\u206C\u206F\u206E\u202E\u200B\u200F\u206C\u200C\u206D\u200C\u206A\u202A\u202D\u206B\u206B\u206B\u206D\u202D\u200C\u206C\u202E\u200F\u206E\u200C\u206D\u200C\u202E(string A_0, GameEntityFormatWrapper A_1)
		{
			return A_0.RuntimeFormat(A_1);
		}

		static GameRunController \u200B\u200D\u206B\u202D\u202D\u206F\u202D\u200C\u202D\u206B\u202B\u202B\u206A\u200E\u202E\u206E\u200E\u202A\u206D\u202B\u202C\u206C\u206F\u206E\u206C\u206B\u200E\u200B\u202B\u206D\u206C\u200C\u202A\u206E\u206F\u206F\u206A\u202A\u200F\u202C\u202E(GameMaster A_0)
		{
			return A_0.CurrentGameRun;
		}

		static PlayerUnit \u202B\u200B\u202E\u200F\u206B\u206F\u206B\u200D\u202B\u202A\u202A\u200D\u206A\u200B\u206C\u200B\u202A\u200F\u202B\u200D\u202C\u202E\u200B\u200F\u206E\u202D\u206C\u206A\u206D\u200C\u206E\u202A\u202E\u206A\u206D\u206E\u202E\u200E\u200E\u200C\u202E(GameRunController A_0)
		{
			return A_0.Player;
		}
	}
}
