using System;
using AyaShameimaru.PlayerUnits;
using AyaShameimaru.Stages;
using LBoL.Core;
using LBoL.Core.Units;
using LBoLEntitySideloader.PersistentValues;

namespace AyaShameimaru
{
	public sealed class AyaSaveData : CustomGameRunSaveData
	{
		public override void Restore(GameRunController gameRun)
		{
			AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.types = this.Types;
			for (;;)
			{
				IL_000B:
				int num = 2109204807;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)(~(num2 ^ (-(--764499929) * 465248125)) * 155376191))) % 11U)
					{
					case 0U:
					{
						AyaPlayerUnitDef.AyaPlayerUnit ayaPlayerUnit;
						ayaPlayerUnit.Story = this.AyaStory;
						num = (int)((num3 * 3486088124U) ^ 950688890U);
						continue;
					}
					case 1U:
						return;
					case 2U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						num = (int)(((flandrePlayerUnit != null) ? 3837731434U : 2930422614U) ^ (num3 * 4063333641U));
						continue;
					}
					case 3U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						flandrePlayerUnit.TakaneTalked = this.TakaneTalked;
						num = (int)((num3 * 4270783080U) ^ 45562213U);
						continue;
					}
					case 4U:
					{
						PlayerUnit playerUnit;
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = playerUnit as FlandrePlayerUnitDef.FlandrePlayerUnit;
						num = -1464035697;
						continue;
					}
					case 5U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						flandrePlayerUnit.TakaneDefeated = this.TakaneDefeated;
						num = (int)((num3 * 4065530289U) ^ 608656448U);
						continue;
					}
					case 6U:
					{
						PlayerUnit playerUnit = AyaSaveData.\u202D\u200D\u202E\u200D\u202D\u200E\u202E\u200C\u202B\u200D\u202B\u200C\u206D\u206B\u200F\u200F\u200E\u200C\u206F\u206A\u200E\u206C\u206A\u202A\u206F\u206A\u200B\u206F\u200C\u200F\u202E\u200F\u206F\u200C\u200B\u200B\u206B\u202D\u206F\u202C\u202E(gameRun);
						AyaPlayerUnitDef.AyaPlayerUnit ayaPlayerUnit = playerUnit as AyaPlayerUnitDef.AyaPlayerUnit;
						num = (int)(((ayaPlayerUnit != null) ? 1331139020U : 1517219012U) ^ (num3 * 3849773368U));
						continue;
					}
					case 7U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						flandrePlayerUnit.Madness = this.FlandreMadness;
						flandrePlayerUnit.MadnessPNR = this.FlandreMadnessPNR;
						num = (int)((num3 * 4015177604U) ^ 2569423668U);
						continue;
					}
					case 8U:
						goto IL_000B;
					case 9U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						flandrePlayerUnit.Story = this.FlandreStory;
						num = (int)((num3 * 1768739402U) ^ 4153325466U);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:;
		}

		public override void Save(GameRunController gameRun)
		{
			this.Types = AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.types;
			PlayerUnit playerUnit = AyaSaveData.\u202D\u200D\u202E\u200D\u202D\u200E\u202E\u200C\u202B\u200D\u202B\u200C\u206D\u206B\u200F\u200F\u200E\u200C\u206F\u206A\u200E\u206C\u206A\u202A\u206F\u206A\u200B\u206F\u200C\u200F\u202E\u200F\u206F\u200C\u200B\u200B\u206B\u202D\u206F\u202C\u202E(gameRun);
			for (;;)
			{
				IL_0012:
				int num = -993743670;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)((num2 - (-(-8467047 + -1365580118) - -(2018411175 * -718870009))) ^ ((-828545828 + 1722667581) * -1316480941) ^ --48554159))) % 12U)
					{
					case 0U:
						return;
					case 1U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						this.TakaneDefeated = flandrePlayerUnit.TakaneDefeated;
						num = (int)((num3 * 433190551U) ^ 3729762180U);
						continue;
					}
					case 2U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						this.TakaneTalked = flandrePlayerUnit.TakaneTalked;
						num = (int)((num3 * 501741733U) ^ 2776059857U);
						continue;
					}
					case 3U:
					{
						AyaPlayerUnitDef.AyaPlayerUnit ayaPlayerUnit;
						num = (int)(((ayaPlayerUnit != null) ? 3405695584U : 120444990U) ^ (num3 * 3741713354U));
						continue;
					}
					case 4U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						num = (int)(((flandrePlayerUnit == null) ? 4000623419U : 351788084U) ^ (num3 * 945245442U));
						continue;
					}
					case 5U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						this.FlandreStory = flandrePlayerUnit.Story;
						num = (int)((num3 * 1036478027U) ^ 4146415256U);
						continue;
					}
					case 7U:
					{
						AyaPlayerUnitDef.AyaPlayerUnit ayaPlayerUnit = playerUnit as AyaPlayerUnitDef.AyaPlayerUnit;
						num = (int)((num3 * 1869053576U) ^ 703263982U);
						continue;
					}
					case 8U:
						goto IL_0012;
					case 9U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = playerUnit as FlandrePlayerUnitDef.FlandrePlayerUnit;
						num = 60386721;
						continue;
					}
					case 10U:
					{
						FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
						this.FlandreMadness = flandrePlayerUnit.Madness;
						this.FlandreMadnessPNR = flandrePlayerUnit.MadnessPNR;
						num = (int)((num3 * 751115206U) ^ 921468160U);
						continue;
					}
					case 11U:
					{
						AyaPlayerUnitDef.AyaPlayerUnit ayaPlayerUnit;
						this.AyaStory = ayaPlayerUnit.Story;
						num = (int)((num3 * 1486426143U) ^ 2287133860U);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:;
		}

		static PlayerUnit \u202D\u200D\u202E\u200D\u202D\u200E\u202E\u200C\u202B\u200D\u202B\u200C\u206D\u206B\u200F\u200F\u200E\u200C\u206F\u206A\u200E\u206C\u206A\u202A\u206F\u206A\u200B\u206F\u200C\u200F\u202E\u200F\u206F\u200C\u200B\u200B\u206B\u202D\u206F\u202C\u202E(GameRunController A_0)
		{
			return A_0.Player;
		}

		public Type[] Types = new Type[0];

		public int? AyaStory;

		public int? FlandreStory;

		public int FlandreMadness;

		public bool FlandreMadnessPNR;

		public bool TakaneDefeated;

		public bool TakaneTalked;
	}
}
