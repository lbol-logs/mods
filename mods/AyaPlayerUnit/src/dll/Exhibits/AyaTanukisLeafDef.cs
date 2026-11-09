using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class AyaTanukisLeafDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2116113668);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaTanukisLeafDef.\u200C\u200E\u206F\u200B\u202B\u200F\u200D\u202E\u202C\u206F\u200D\u206A\u206D\u206F\u202C\u202D\u202D\u200E\u202A\u202B\u200C\u206D\u202C\u202A\u206A\u200D\u206E\u202C\u202C\u206A\u206C\u200D\u200B\u200B\u206A\u200E\u202A\u200C\u202B\u206B\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			AyaTanukisLeafDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = 536111534;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((num2 * 1290249721) ^ (~-1000016730 ^ (-1610645076 ^ -1790437344))) * 1040119345 * 1735916905)) % 3U)
					{
					case 0U:
						goto IL_0006;
					case 1U:
						<>4__this = this;
						folder = "";
						num = (int)((num3 * 2305697888U) ^ 342807806U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = AyaTanukisLeafDef.\u206F\u206A\u200D\u200F\u206A\u206B\u200E\u206E\u206E\u202C\u202D\u206C\u200E\u206B\u202A\u206B\u206C\u200F\u202E\u202B\u202A\u206A\u206A\u202B\u200C\u200F\u202D\u200C\u202C\u200F\u206F\u206D\u200C\u202A\u206A\u202D\u206B\u206A\u206C\u202B\u202E();
			Func<string, Sprite> func = (string s) => AyaTanukisLeafDef.<>c__DisplayClass2_0.\u202D\u200D\u202D\u200C\u200B\u202B\u200F\u202C\u206A\u206B\u202E\u202E\u202B\u200B\u206B\u206E\u206C\u206F\u200F\u200B\u202A\u206A\u200B\u200B\u200F\u202B\u200C\u202E\u200E\u202B\u202B\u200E\u206A\u206C\u200C\u200F\u206B\u202E\u206F\u200E\u202E(AyaTanukisLeafDef.<>c__DisplayClass2_0.\u200C\u200F\u206A\u206E\u202A\u206D\u206C\u202B\u206F\u200B\u200E\u206B\u206E\u200E\u202C\u200C\u206B\u206F\u200C\u200D\u202A\u206F\u200E\u202E\u206B\u202E\u206E\u200B\u200C\u206C\u206A\u202C\u200B\u206C\u200D\u206D\u206E\u206B\u202E\u200C\u202E(folder, AyaTanukisLeafDef.<>c__DisplayClass2_0.\u200D\u206E\u200F\u200E\u202C\u206D\u202E\u206B\u206B\u200E\u206F\u206F\u206F\u206D\u206A\u202D\u206D\u206A\u206E\u200F\u206B\u200B\u206E\u206B\u200C\u200F\u206D\u206B\u202E\u202E\u202D\u202A\u200E\u206E\u200F\u206A\u200B\u200D\u200B\u206C\u202E(<>4__this), s, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(AyaTanukisLeafDef.\u202C\u206F\u202C\u200C\u200B\u200E\u200C\u200B\u206D\u202D\u206A\u202A\u206E\u200D\u200D\u206A\u202C\u200F\u206E\u202D\u200E\u200F\u202A\u206B\u206C\u202B\u200C\u200E\u200D\u200D\u202B\u202D\u202E\u202A\u202E\u200D\u202D\u200C\u202E\u206A\u202E(BepinexPlugin.sequenceTable, AyaTanukisLeafDef.\u200C\u202E\u200F\u202B\u206D\u206F\u206D\u200F\u206B\u202E\u200D\u200F\u200C\u206E\u206B\u200F\u200E\u202D\u200D\u200E\u202D\u200D\u200B\u200F\u206E\u200C\u200D\u200D\u206B\u206F\u202B\u206D\u202A\u200C\u200D\u200B\u206D\u202E\u202C\u206A\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, !BepinexPlugin.Chapter1AyaPlayerUnit, false, false, false, AppearanceType.Nowhere, "", ExhibitLosableType.CantLose, Rarity.Mythic, null, null, null, null, null, null, 0, false, null, Keyword.None, new List<string>(), new List<string>());
		}

		static BatchLocalization \u200C\u200E\u206F\u200B\u202B\u200F\u200D\u202E\u202C\u206F\u200D\u206A\u206D\u206F\u202C\u202D\u202D\u200E\u202A\u202B\u200C\u206D\u202C\u202A\u206A\u200D\u206E\u202C\u202C\u206A\u206C\u200D\u200B\u200B\u206A\u200E\u202A\u200C\u202B\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u206F\u206A\u200D\u200F\u206A\u206B\u200E\u206E\u206E\u202C\u202D\u206C\u200E\u206B\u202A\u206B\u206C\u200F\u202E\u202B\u202A\u206A\u206A\u202B\u200C\u200F\u202D\u200C\u202C\u200F\u206F\u206D\u200C\u202A\u206A\u202D\u206B\u206A\u206C\u202B\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u200C\u202E\u200F\u202B\u206D\u206F\u206D\u200F\u206B\u202E\u200D\u200F\u200C\u206E\u206B\u200F\u200E\u202D\u200D\u200E\u202D\u200D\u200B\u200F\u206E\u200C\u200D\u200D\u206B\u206F\u202B\u206D\u202A\u200C\u200D\u200B\u206D\u202E\u202C\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u206F\u202C\u200C\u200B\u200E\u200C\u200B\u206D\u202D\u206A\u202A\u206E\u200D\u200D\u206A\u202C\u200F\u206E\u202D\u200E\u200F\u202A\u206B\u206C\u202B\u200C\u200E\u200D\u200D\u202B\u202D\u202E\u202A\u202E\u200D\u202D\u200C\u202E\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaTanukisLeafDef))]
		[UsedImplicitly]
		public sealed class AyaTanukisLeaf : Exhibit
		{
			protected override void OnEnterBattle()
			{
				AyaTanukisLeafDef.AyaTanukisLeaf.\u200C\u206B\u202E\u206C\u202D\u200F\u206B\u200B\u206D\u206A\u200B\u200C\u206A\u202C\u200B\u206F\u206A\u200D\u200F\u202B\u206F\u206A\u200C\u206E\u202D\u200B\u200F\u202E\u206D\u206C\u200C\u206D\u202E\u206C\u206A\u200F\u200C\u200B\u206B\u202D\u202E(this, true);
			}

			protected override void OnLeaveBattle()
			{
				AyaTanukisLeafDef.AyaTanukisLeaf.\u200C\u206B\u202E\u206C\u202D\u200F\u206B\u200B\u206D\u206A\u200B\u200C\u206A\u202C\u200B\u206F\u206A\u200D\u200F\u202B\u206F\u206A\u200C\u206E\u202D\u200B\u200F\u202E\u206D\u206C\u200C\u206D\u202E\u206C\u206A\u200F\u200C\u200B\u206B\u202D\u202E(this, false);
			}

			static void \u200C\u206B\u202E\u206C\u202D\u200F\u206B\u200B\u206D\u206A\u200B\u200C\u206A\u202C\u200B\u206F\u206A\u200D\u200F\u202B\u206F\u206A\u200C\u206E\u202D\u200B\u200F\u202E\u206D\u206C\u200C\u206D\u202E\u206C\u206A\u200F\u200C\u200B\u206B\u202D\u202E(Exhibit A_0, bool A_1)
			{
				A_0.Blackout = A_1;
			}

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				private static void Prefix(GameRunController __instance)
				{
					if (AyaTanukisLeafDef.AyaTanukisLeaf.GameRunController_BaseCardWeight_Patch.\u200B\u200D\u200E\u200E\u206C\u200F\u202A\u202C\u202D\u206B\u206E\u206E\u202C\u206B\u202A\u202A\u202B\u206A\u202A\u202B\u200B\u206F\u200C\u202C\u202E\u202C\u200E\u206A\u202A\u200C\u200F\u206E\u202C\u202E\u200D\u202A\u200B\u200C\u202D\u206F\u202E(Singleton<GameMaster>.Instance) != null)
					{
						for (;;)
						{
							IL_000F:
							int num = -1639200748;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~((num2 ^ ~(-(~-1711352957))) * 1872607251) - 1261909761)) % 4U)
								{
								case 0U:
									AyaTanukisLeafDef.AyaTanukisLeaf.GameRunController_BaseCardWeight_Patch.\u200B\u200D\u200E\u200E\u206C\u200F\u202A\u202C\u202D\u206B\u206E\u206E\u202C\u206B\u202A\u202A\u202B\u206A\u202A\u202B\u200B\u206F\u200C\u202C\u202E\u202C\u200E\u206A\u202A\u200C\u200F\u206E\u202C\u202E\u200D\u202A\u200B\u200C\u202D\u206F\u202E(Singleton<GameMaster>.Instance)._cardRareWeightFactor += 0.01f;
									num = (int)((num3 * 928989795U) ^ 1274629303U);
									continue;
								case 1U:
									num = (int)((AyaTanukisLeafDef.AyaTanukisLeaf.GameRunController_BaseCardWeight_Patch.\u202D\u206F\u206F\u200F\u202C\u202C\u200B\u206E\u200F\u200B\u202E\u206F\u202B\u202C\u202C\u202C\u206F\u206B\u200C\u206B\u206D\u200D\u206B\u206E\u206A\u200C\u206A\u206C\u202D\u206B\u202B\u206C\u206A\u206E\u202E\u206E\u206A\u202D\u206A\u206A\u202E(AyaTanukisLeafDef.AyaTanukisLeaf.GameRunController_BaseCardWeight_Patch.\u200B\u200D\u200E\u200E\u206C\u200F\u202A\u202C\u202D\u206B\u206E\u206E\u202C\u206B\u202A\u202A\u202B\u206A\u202A\u202B\u200B\u206F\u200C\u202C\u202E\u202C\u200E\u206A\u202A\u200C\u200F\u206E\u202C\u202E\u200D\u202A\u200B\u200C\u202D\u206F\u202E(Singleton<GameMaster>.Instance)).HasExhibit<AyaTanukisLeafDef.AyaTanukisLeaf>() ? 977064876U : 471854794U) ^ (num3 * 1344099053U));
									continue;
								case 3U:
									goto IL_000F;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static GameRunController \u200B\u200D\u200E\u200E\u206C\u200F\u202A\u202C\u202D\u206B\u206E\u206E\u202C\u206B\u202A\u202A\u202B\u206A\u202A\u202B\u200B\u206F\u200C\u202C\u202E\u202C\u200E\u206A\u202A\u200C\u200F\u206E\u202C\u202E\u200D\u202A\u200B\u200C\u202D\u206F\u202E(GameMaster A_0)
				{
					return A_0.CurrentGameRun;
				}

				static PlayerUnit \u202D\u206F\u206F\u200F\u202C\u202C\u200B\u206E\u200F\u200B\u202E\u206F\u202B\u202C\u202C\u202C\u206F\u206B\u200C\u206B\u206D\u200D\u206B\u206E\u206A\u200C\u206A\u206C\u202D\u206B\u202B\u206C\u206A\u206E\u202E\u206E\u206A\u202D\u206A\u206A\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}
			}
		}
	}
}
