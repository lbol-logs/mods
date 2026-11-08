using System;
using AyaShameimaru.PlayerUnits;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader.Attributes;

namespace AyaShameimaru.Cards
{
	[EntityLogic(typeof(AyaSelectNoDef))]
	public sealed class AyaSelectNo : Card
	{
		public override string Description
		{
			get
			{
				int? num = AyaSelectNo.\u200F\u200C\u202E\u206B\u206C\u200B\u206A\u200C\u200F\u206A\u202B\u206F\u206D\u206B\u200B\u200B\u206C\u202E\u202C\u206D\u206A\u206A\u200D\u202E\u202B\u206D\u206D\u200F\u200F\u202D\u200F\u206D\u202D\u200E\u200D\u206F\u200F\u206F\u202B\u200C\u202E(this);
				if (num != null)
				{
					goto IL_0013;
				}
				goto IL_0110;
				int num3;
				string text2;
				for (;;)
				{
					IL_0018:
					int num2 = num3;
					uint num4;
					string text;
					switch ((num4 = (uint)(~(-(-282283956 - -2074139124 + (-623118980 ^ 2087609707) + (-1035930732 - 229129695 - ~-1673148234) - num2)) - 1274957947)) % 12U)
					{
					case 0U:
						num3 = (int)((num4 * 3388892432U) ^ 490060578U);
						continue;
					case 1U:
					{
						int valueOrDefault = num.GetValueOrDefault();
						num3 = (int)(((valueOrDefault != 0) ? 1469802432U : 474811456U) ^ (num4 * 1019907491U));
						continue;
					}
					case 2U:
						num3 = (int)((num4 * 1844122655U) ^ 3695497182U);
						continue;
					case 3U:
						text = AyaSelectNo.\u206E\u206B\u206C\u206F\u202C\u202A\u206D\u200D\u200E\u202B\u200B\u206E\u202C\u200D\u202A\u202B\u200D\u202D\u206D\u202E\u200D\u202C\u202E\u206D\u206E\u206C\u200E\u206D\u200D\u206F\u206F\u206F\u202A\u202C\u206C\u200B\u202D\u206D\u200D\u202C\u202E(base.BaseDescription, AyaSelectNo.\u200F\u202C\u202A\u200F\u202C\u206E\u200E\u206F\u200C\u202D\u200C\u202C\u206A\u206C\u206C\u206D\u202A\u206B\u206A\u202C\u202B\u202C\u206F\u202C\u202B\u200E\u200D\u206C\u200D\u206D\u206A\u202A\u200D\u206D\u202A\u202E\u200F\u202B\u202D\u206C\u202E(this));
						goto IL_0105;
					case 4U:
					{
						int valueOrDefault;
						num3 = (int)(((valueOrDefault == 2) ? 2728937317U : 2105882519U) ^ (num4 * 2881493740U));
						continue;
					}
					case 5U:
						goto IL_0013;
					case 6U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						if (flandrePlayerUnit == null)
						{
							num3 = (int)((num4 * 250990715U) ^ 541102102U);
							continue;
						}
						text = flandrePlayerUnit.FlandreEikiNoDescription;
						goto IL_0105;
					}
					case 8U:
						text2 = AyaSelectNo.\u206E\u206B\u206C\u206F\u202C\u202A\u206D\u200D\u200E\u202B\u200B\u206E\u202C\u200D\u202A\u202B\u200D\u202D\u206D\u202E\u200D\u202C\u202E\u206D\u206E\u206C\u200E\u206D\u200D\u206F\u206F\u206F\u202A\u202C\u206C\u200B\u202D\u206D\u200D\u202C\u202E(base.BaseDescription, AyaSelectNo.\u200F\u202C\u202A\u200F\u202C\u206E\u200E\u206F\u200C\u202D\u200C\u202C\u206A\u206C\u206C\u206D\u202A\u206B\u206A\u202C\u202B\u202C\u206F\u202C\u202B\u200E\u200D\u206C\u200D\u206D\u206A\u202A\u200D\u206D\u202A\u202E\u200F\u202B\u202D\u206C\u202E(this));
						num3 = -1224748556;
						continue;
					case 9U:
						goto IL_0110;
					case 10U:
					{
						GameRunController gameRunController = AyaSelectNo.\u202C\u200C\u200B\u206E\u206A\u206A\u200D\u200B\u206F\u200F\u202E\u206E\u202B\u206B\u206B\u206B\u200D\u206A\u202E\u200F\u200C\u202B\u206B\u206A\u202D\u206F\u200D\u206D\u202D\u202B\u206F\u200F\u200E\u206C\u202B\u202D\u206B\u202C\u206E\u202B\u202E(Singleton<GameMaster>.Instance);
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? AyaSelectNo.\u202C\u202A\u206C\u206F\u200F\u200B\u206D\u206B\u202E\u200B\u206A\u206D\u202B\u202B\u200C\u200D\u206A\u206C\u200B\u206E\u200F\u206E\u200F\u202A\u206F\u200D\u206D\u202A\u206B\u200F\u206E\u206F\u202B\u200B\u200F\u200B\u206B\u200C\u206D\u202A\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
						num3 = -548904327;
						continue;
					}
					case 11U:
						num3 = (int)((num4 * 1712068305U) ^ 3536552207U);
						continue;
					}
					break;
					IL_0105:
					text2 = text;
					num3 = 15896473;
				}
				return text2;
				IL_0013:
				num3 = -1437279358;
				goto IL_0018;
				IL_0110:
				text2 = AyaSelectNo.\u206E\u206B\u206C\u206F\u202C\u202A\u206D\u200D\u200E\u202B\u200B\u206E\u202C\u200D\u202A\u202B\u200D\u202D\u206D\u202E\u200D\u202C\u202E\u206D\u206E\u206C\u200E\u206D\u200D\u206F\u206F\u206F\u202A\u202C\u206C\u200B\u202D\u206D\u200D\u202C\u202E(base.BaseDescription, AyaSelectNo.\u200F\u202C\u202A\u200F\u202C\u206E\u200E\u206F\u200C\u202D\u200C\u202C\u206A\u206C\u206C\u206D\u202A\u206B\u206A\u202C\u202B\u202C\u206F\u202C\u202B\u200E\u200D\u206C\u200D\u206D\u206A\u202A\u200D\u206D\u202A\u202E\u200F\u202B\u202D\u206C\u202E(this));
				num3 = -662095156;
				goto IL_0018;
			}
		}

		public override string Name
		{
			get
			{
				int? num = AyaSelectNo.\u200F\u200C\u202E\u206B\u206C\u200B\u206A\u200C\u200F\u206A\u202B\u206F\u206D\u206B\u200B\u200B\u206C\u202E\u202C\u206D\u206A\u206A\u200D\u202E\u202B\u206D\u206D\u200F\u200F\u202D\u200F\u206D\u202D\u200E\u200D\u206F\u200F\u206F\u202B\u200C\u202E(this);
				string text2;
				for (;;)
				{
					IL_0007:
					int num2 = 1718293925;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						string text;
						switch ((num4 = (uint)(num3 + -(~-1683556110) + (-532827660 - 1053923813 * 1200823812))) % 11U)
						{
						case 0U:
						{
							GameRunController gameRunController = AyaSelectNo.\u202C\u200C\u200B\u206E\u206A\u206A\u200D\u200B\u206F\u200F\u202E\u206E\u202B\u206B\u206B\u206B\u200D\u206A\u202E\u200F\u200C\u202B\u206B\u206A\u202D\u206F\u200D\u206D\u202D\u202B\u206F\u200F\u200E\u206C\u202B\u202D\u206B\u202C\u206E\u202B\u202E(Singleton<GameMaster>.Instance);
							FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? AyaSelectNo.\u202C\u202A\u206C\u206F\u200F\u200B\u206D\u206B\u202E\u200B\u206A\u206D\u202B\u202B\u200C\u200D\u206A\u206C\u200B\u206E\u200F\u206E\u200F\u202A\u206F\u200D\u206D\u202A\u206B\u200F\u206E\u206F\u202B\u200B\u200F\u200B\u206B\u200C\u206D\u202A\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
							if (flandrePlayerUnit == null)
							{
								num2 = -250799285;
								continue;
							}
							text = flandrePlayerUnit.FlandreEikiNoName;
							goto IL_00AB;
						}
						case 1U:
							text = base.BaseName;
							goto IL_00AB;
						case 3U:
							text2 = base.BaseName;
							num2 = 1320763643;
							continue;
						case 4U:
							num2 = (int)((num4 * 2817676380U) ^ 3855957388U);
							continue;
						case 5U:
							goto IL_0007;
						case 6U:
							num2 = (int)((num4 * 478899114U) ^ 2399273791U);
							continue;
						case 7U:
						{
							int valueOrDefault = num.GetValueOrDefault();
							num2 = (int)(((valueOrDefault != 0) ? 1457063601U : 307827382U) ^ (num4 * 3813015791U));
							continue;
						}
						case 8U:
							num2 = (int)(((num == null) ? 2810278720U : 3543546339U) ^ (num4 * 3895598170U));
							continue;
						case 9U:
							text2 = base.BaseName;
							num2 = 1183314951;
							continue;
						case 10U:
						{
							int valueOrDefault;
							num2 = (int)(((valueOrDefault != 2) ? 1045471484U : 3238223389U) ^ (num4 * 2320652915U));
							continue;
						}
						}
						return text2;
						IL_00AB:
						text2 = text;
						num2 = 1320763643;
					}
				}
				return text2;
			}
		}

		static int? \u200F\u200C\u202E\u206B\u206C\u200B\u206A\u200C\u200F\u206A\u202B\u206F\u206D\u206B\u200B\u200B\u206C\u202E\u202C\u206D\u206A\u206A\u200D\u202E\u202B\u206D\u206D\u200F\u200F\u202D\u200F\u206D\u202D\u200E\u200D\u206F\u200F\u206F\u202B\u200C\u202E(Card A_0)
		{
			return A_0.DeckCounter;
		}

		static GameEntityFormatWrapper \u200F\u202C\u202A\u200F\u202C\u206E\u200E\u206F\u200C\u202D\u200C\u202C\u206A\u206C\u206C\u206D\u202A\u206B\u206A\u202C\u202B\u202C\u206F\u202C\u202B\u200E\u200D\u206C\u200D\u206D\u206A\u202A\u200D\u206D\u202A\u202E\u200F\u202B\u202D\u206C\u202E(GameEntity A_0)
		{
			return A_0.FormatWrapper;
		}

		static string \u206E\u206B\u206C\u206F\u202C\u202A\u206D\u200D\u200E\u202B\u200B\u206E\u202C\u200D\u202A\u202B\u200D\u202D\u206D\u202E\u200D\u202C\u202E\u206D\u206E\u206C\u200E\u206D\u200D\u206F\u206F\u206F\u202A\u202C\u206C\u200B\u202D\u206D\u200D\u202C\u202E(string A_0, GameEntityFormatWrapper A_1)
		{
			return A_0.RuntimeFormat(A_1);
		}

		static GameRunController \u202C\u200C\u200B\u206E\u206A\u206A\u200D\u200B\u206F\u200F\u202E\u206E\u202B\u206B\u206B\u206B\u200D\u206A\u202E\u200F\u200C\u202B\u206B\u206A\u202D\u206F\u200D\u206D\u202D\u202B\u206F\u200F\u200E\u206C\u202B\u202D\u206B\u202C\u206E\u202B\u202E(GameMaster A_0)
		{
			return A_0.CurrentGameRun;
		}

		static PlayerUnit \u202C\u202A\u206C\u206F\u200F\u200B\u206D\u206B\u202E\u200B\u206A\u206D\u202B\u202B\u200C\u200D\u206A\u206C\u200B\u206E\u200F\u206E\u200F\u202A\u206F\u200D\u206D\u202A\u206B\u200F\u206E\u206F\u202B\u200B\u200F\u200B\u206B\u200C\u206D\u202A\u202E(GameRunController A_0)
		{
			return A_0.Player;
		}
	}
}
