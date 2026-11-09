using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.EnemyUnits;
using AyaShameimaru.PlayerUnits;
using BepInEx;
using BepInEx.Bootstrap;
using HarmonyLib;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Cards;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.Stages.NormalStages;
using LBoL.Presentation;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.Dialogs;
using LBoL.Presentation.UI.ExtraWidgets;
using LBoL.Presentation.UI.Panels;
using LBoL.Presentation.UI.Widgets;
using LBoL.Presentation.Units;
using LBoLEntitySideloader.CustomKeywords;
using LBoLEntitySideloader.Resource;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AyaShameimaru.Stages
{
	public class AyaMisc
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsValidGameRun(GameRunController gameRun = null)
		{
			if (gameRun == null)
			{
				goto IL_0006;
			}
			goto IL_00B7;
			int num2;
			for (;;)
			{
				IL_000B:
				int num = num2;
				uint num3;
				switch ((num3 = (uint)((((-(-(938624593 - 8196388)) - num) * -44691395) ^ (508081353 ^ -2061516303)) * 1091840159)) % 14U)
				{
				case 0U:
					num2 = (AyaMisc.\u206E\u206D\u200B\u206E\u202D\u200C\u202C\u200C\u200C\u206C\u200F\u200D\u206D\u202B\u200D\u206D\u206D\u200D\u200E\u200F\u202C\u206E\u202B\u206A\u200C\u200B\u206E\u206D\u202A\u200F\u206D\u202D\u200C\u200E\u206A\u202E\u202D\u200F\u206F\u206C\u202E().ContainsKey(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1770291014)) ? 2079198038 : 1485860480);
					continue;
				case 1U:
					return false;
				case 2U:
					goto IL_0006;
				case 3U:
					num2 = (int)(((AyaMisc.\u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(gameRun) is WindGodLake) ? 742697882U : 312292141U) ^ (num3 * 1836891875U));
					continue;
				case 4U:
					num2 = (int)(((AyaMisc.\u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(gameRun) is AyaStage) ? 3425093807U : 2491272607U) ^ (num3 * 3864026098U));
					continue;
				case 5U:
					return false;
				case 6U:
					return false;
				case 7U:
					num2 = (int)(((AyaMisc.\u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(gameRun) is FinalStage) ? 196227887U : 1352073325U) ^ (num3 * 3627163088U));
					continue;
				case 8U:
					return false;
				case 9U:
					num2 = (int)(((!AyaLBOLMPHelper.MPIsActive) ? 3769340628U : 2433668096U) ^ (num3 * 496348772U));
					continue;
				case 10U:
					goto IL_00B7;
				case 12U:
					num2 = (int)(((AyaMisc.\u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(gameRun) is XuanwuRavine) ? 1879090783U : 2522515848U) ^ (num3 * 2646113872U));
					continue;
				case 13U:
					num2 = ((!(AyaMisc.\u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(gameRun) is BambooForest)) ? 1784736673 : (-1784420705));
					continue;
				}
				break;
			}
			return true;
			IL_0006:
			num2 = -16583281;
			goto IL_000B;
			IL_00B7:
			num2 = ((!AyaMisc.\u206B\u206D\u200F\u200B\u200C\u206F\u200E\u206A\u200E\u206C\u206E\u200C\u206E\u202D\u200B\u206E\u200F\u200E\u202B\u206D\u200C\u202C\u206C\u202D\u202D\u206E\u206D\u202C\u202D\u202A\u206B\u200F\u206A\u206A\u200C\u202E\u200C\u206B\u202E\u202E(gameRun).Any<JadeBox>()) ? (-1759587150) : (-1935219452));
			goto IL_000B;
		}

		public bool SongLyricsToggle
		{
			get
			{
				return AyaMisc._songLyricsToggle;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				if (value)
				{
					goto IL_0006;
				}
				goto IL_0283;
				int num2;
				for (;;)
				{
					IL_000B:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(uint)(~num * -1711302205))) % 13U)
					{
					case 0U:
						AyaMisc.\u202E\u200D\u200D\u206A\u200F\u200B\u202C\u202E\u202E\u202D\u206F\u202E\u200F\u200F\u206B\u206D\u206C\u200C\u200D\u206E\u206A\u206D\u200F\u206D\u200F\u200D\u200F\u202A\u202C\u206A\u206C\u202D\u200E\u202A\u200E\u202C\u200F\u202B\u200C\u202A\u202E(AyaMisc.\u202C\u202E\u200B\u206D\u202D\u206F\u206D\u206D\u200D\u200F\u202C\u200F\u202C\u200F\u206D\u206F\u206D\u202D\u206B\u202B\u200C\u206E\u202D\u200E\u206C\u206B\u206F\u202D\u206E\u200E\u206F\u206C\u202D\u206B\u206B\u202C\u202C\u206F\u200C\u206C\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>()), new Vector2(3000f, AyaMisc.\u206C\u202D\u200D\u200D\u206A\u200B\u200D\u200B\u202B\u202C\u202C\u206A\u202C\u206E\u206C\u206E\u206E\u206D\u202E\u202A\u200D\u200C\u202B\u206E\u200F\u202C\u200C\u202C\u206C\u202A\u200B\u206E\u200D\u200D\u202B\u202D\u202D\u206E\u206C\u206D\u202E(AyaMisc.\u202C\u202E\u200B\u206D\u202D\u206F\u206D\u206D\u200D\u200F\u202C\u200F\u202C\u200F\u206D\u206F\u206D\u202D\u206B\u202B\u200C\u206E\u202D\u200E\u206C\u206B\u206F\u202D\u206E\u200E\u206F\u206C\u202D\u206B\u206B\u202C\u202C\u206F\u200C\u206C\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>())).y));
						num2 = (int)((num3 * 2997645395U) ^ 3844552639U);
						continue;
					case 1U:
						AyaMisc.\u206D\u202A\u202B\u200B\u202E\u206C\u200C\u200E\u200C\u202E\u206B\u202C\u200B\u200C\u202B\u202A\u202B\u206E\u206E\u206A\u202C\u206A\u200B\u206A\u200F\u200D\u200C\u202E\u206F\u206F\u206B\u206D\u202E\u206C\u206B\u206E\u202D\u200D\u202C\u202E(this.SongLyrics);
						num2 = (int)((num3 * 2868781809U) ^ 1399893589U);
						continue;
					case 2U:
						AyaMisc.\u200B\u200E\u206B\u202B\u202B\u200D\u206F\u206D\u200B\u202E\u202E\u206D\u200F\u200E\u206D\u202C\u202C\u200C\u206B\u200E\u200E\u200F\u202E\u202C\u202D\u206F\u200F\u200D\u202B\u202E\u202C\u200E\u202A\u206E\u206F\u206B\u206A\u206F\u202D\u200F\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), 80f);
						num2 = (int)((num3 * 3284175696U) ^ 884758934U);
						continue;
					case 3U:
						this.SongLyrics = AyaMisc.\u206D\u200E\u202E\u206F\u200E\u202C\u200F\u206A\u200F\u200F\u206F\u206C\u202C\u206C\u202D\u200D\u200D\u206D\u206A\u202B\u200C\u202C\u206D\u202D\u206D\u200C\u202E\u200D\u202A\u206F\u202E\u206B\u206E\u202B\u202B\u202D\u202E\u206D\u206A\u202E();
						this.SongLyrics.AddComponent<TextMeshProUGUI>();
						num2 = (int)((num3 * 2450206006U) ^ 2915889801U);
						continue;
					case 4U:
						AyaMisc.\u200E\u200E\u200D\u202C\u202E\u200D\u206E\u202E\u206F\u202B\u202D\u200F\u200C\u202B\u200E\u202B\u200F\u206D\u202D\u206D\u200E\u200C\u206B\u200E\u200E\u206F\u200C\u200B\u206C\u200D\u206D\u206E\u206A\u206D\u202D\u202A\u202B\u200E\u202C\u202E\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), 1f);
						AyaMisc.\u206D\u202E\u206F\u202B\u200E\u206B\u202D\u202E\u202C\u202E\u202A\u206E\u202A\u206A\u206D\u202A\u200F\u206A\u206E\u202E\u206C\u202E\u206F\u200B\u202D\u206D\u200F\u200C\u200B\u202E\u206D\u206E\u206D\u206D\u206E\u202D\u202C\u202B\u206E\u200F\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), new Color(1f, 0.843f, 0f, 1f));
						num2 = (int)((num3 * 1211780066U) ^ 621797971U);
						continue;
					case 5U:
						AyaMisc.\u202E\u200F\u200C\u206A\u202B\u202C\u206D\u206D\u206E\u200F\u206D\u206F\u202E\u202E\u202A\u200D\u202C\u202D\u206E\u200D\u206A\u200C\u206C\u206B\u200F\u200C\u206E\u206C\u206C\u200B\u200B\u206C\u206B\u202C\u200C\u206A\u200B\u202B\u200E\u206B\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), 4098);
						AyaMisc.\u202E\u200E\u202C\u202E\u202C\u202D\u202D\u202B\u202E\u206B\u202A\u206F\u202B\u206B\u202A\u202B\u200B\u200C\u202E\u206C\u202E\u202E\u206B\u206A\u202E\u202C\u200B\u202B\u200C\u202D\u206C\u206C\u200B\u202A\u206F\u200D\u200B\u206C\u200B\u200C\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), AyaMisc.\u206A\u200F\u206C\u206D\u202C\u200D\u202A\u200B\u200B\u202A\u206A\u202D\u200C\u202B\u202B\u206C\u206D\u206D\u206C\u206E\u206E\u206A\u206B\u200B\u206C\u206D\u206C\u200F\u202C\u206D\u200F\u206E\u200D\u202D\u206E\u202E\u206B\u202B\u206A\u206B\u202E(UiManager.GetPanel<SystemBoard>().doremyLevel));
						num2 = (int)((num3 * 3605411387U) ^ 1369674188U);
						continue;
					case 6U:
						goto IL_02A5;
					case 7U:
						AyaMisc.\u206E\u202B\u206D\u206E\u206F\u202E\u200D\u202D\u202C\u200E\u206A\u202C\u200C\u206B\u202D\u200E\u206D\u200B\u206F\u200C\u200B\u202D\u202D\u206F\u202A\u200E\u200D\u206A\u202E\u200D\u206A\u200E\u200D\u200E\u206A\u202A\u206A\u202B\u200C\u206B\u202E(this.SongLyrics.GetComponent<TextMeshProUGUI>(), 0.1f);
						num2 = (int)((num3 * 3531805651U) ^ 1935074922U);
						continue;
					case 8U:
						AyaMisc.\u206E\u200B\u200E\u206E\u206D\u200D\u206E\u206D\u206E\u206C\u206A\u200F\u206B\u200B\u206F\u202A\u206D\u206C\u206C\u202B\u200F\u200D\u200D\u200B\u206C\u202E\u202A\u206A\u206E\u206F\u200F\u206F\u200D\u200D\u206E\u206C\u202D\u206E\u200C\u206F\u202E(AyaMisc.\u202C\u202B\u206C\u200B\u206A\u206D\u206A\u202D\u206C\u202B\u206A\u200D\u206C\u202D\u200C\u202A\u206F\u200F\u200D\u200E\u206B\u200C\u206E\u202D\u202E\u206D\u200D\u200B\u206E\u202B\u206A\u206C\u206A\u202C\u202D\u202A\u206F\u200D\u202E\u202D\u202E(this.SongLyrics), new Vector3(AyaMisc.\u202A\u202B\u206D\u206B\u206E\u206C\u200D\u206D\u206B\u206F\u206A\u202E\u202C\u202D\u202C\u202D\u202D\u200D\u202B\u202D\u206B\u202E\u202E\u202E\u200F\u202D\u206C\u200C\u206B\u202C\u206B\u202E\u200B\u200D\u200E\u200F\u202C\u206C\u202D\u202E(AyaMisc.\u202A\u200C\u206F\u206C\u206A\u206F\u206D\u200E\u200F\u206A\u202D\u200B\u202A\u202A\u202A\u202B\u206A\u202A\u206D\u202E\u206C\u202D\u202E\u200C\u206F\u202C\u202B\u206B\u206B\u200C\u206A\u206E\u206B\u206A\u206E\u206E\u202A\u206E\u206D\u206E\u202E(AyaMisc.\u200D\u200F\u200E\u206E\u202A\u202E\u206A\u202B\u202D\u202A\u206A\u202C\u202C\u202D\u206E\u206D\u202A\u200D\u206F\u200F\u200B\u206E\u206E\u202A\u202A\u200D\u202D\u200F\u202D\u202B\u206C\u200C\u200D\u202B\u200C\u206E\u202C\u206E\u200E\u200F\u202E())).x, AyaMisc.\u202A\u202B\u206D\u206B\u206E\u206C\u200D\u206D\u206B\u206F\u206A\u202E\u202C\u202D\u202C\u202D\u202D\u200D\u202B\u202D\u206B\u202E\u202E\u202E\u200F\u202D\u206C\u200C\u206B\u202C\u206B\u202E\u200B\u200D\u200E\u200F\u202C\u206C\u202D\u202E(AyaMisc.\u202A\u200C\u206F\u206C\u206A\u206F\u206D\u200E\u200F\u206A\u202D\u200B\u202A\u202A\u202A\u202B\u206A\u202A\u206D\u202E\u206C\u202D\u202E\u200C\u206F\u202C\u202B\u206B\u206B\u200C\u206A\u206E\u206B\u206A\u206E\u206E\u202A\u206E\u206D\u206E\u202E(AyaMisc.\u200D\u200F\u200E\u206E\u202A\u202E\u206A\u202B\u202D\u202A\u206A\u202C\u202C\u202D\u206E\u206D\u202A\u200D\u206F\u200F\u200B\u206E\u206E\u202A\u202A\u200D\u202D\u200F\u202D\u202B\u206C\u200C\u200D\u202B\u200C\u206E\u202C\u206E\u200E\u200F\u202E())).y - 6f, AyaMisc.\u202A\u202B\u206D\u206B\u206E\u206C\u200D\u206D\u206B\u206F\u206A\u202E\u202C\u202D\u202C\u202D\u202D\u200D\u202B\u202D\u206B\u202E\u202E\u202E\u200F\u202D\u206C\u200C\u206B\u202C\u206B\u202E\u200B\u200D\u200E\u200F\u202C\u206C\u202D\u202E(AyaMisc.\u202C\u202B\u206C\u200B\u206A\u206D\u206A\u202D\u206C\u202B\u206A\u200D\u206C\u202D\u200C\u202A\u206F\u200F\u200D\u200E\u206B\u200C\u206E\u202D\u202E\u206D\u200D\u200B\u206E\u202B\u206A\u206C\u206A\u202C\u202D\u202A\u206F\u200D\u202E\u202D\u202E(this.SongLyrics)).z));
						AyaMisc.\u206D\u202B\u206B\u202E\u206F\u206C\u206F\u206A\u206D\u202D\u200C\u202C\u200F\u200D\u202C\u206D\u206C\u206C\u206B\u206B\u200D\u200B\u200F\u202D\u206D\u202D\u206F\u206F\u206C\u206E\u200C\u206D\u200B\u206A\u200E\u206C\u206A\u202D\u202E\u200E\u202E(AyaMisc.\u202C\u200D\u200F\u202E\u202C\u200F\u200C\u200D\u206C\u206F\u206B\u202C\u200B\u200C\u202A\u202C\u202D\u206C\u200E\u200B\u206A\u200F\u202C\u200C\u206E\u200C\u206E\u202D\u200B\u202A\u200E\u206E\u206B\u202C\u206B\u202D\u200F\u200B\u202E\u202B\u202E(this.SongLyrics), true);
						AyaMisc.\u200E\u206F\u202B\u206C\u202C\u202D\u206A\u206D\u202B\u202A\u202E\u206C\u202D\u206D\u200B\u200C\u200B\u206E\u202D\u202B\u200F\u202B\u202D\u206A\u200C\u200B\u200D\u206E\u206A\u202E\u202C\u200B\u200F\u206C\u200D\u200E\u200C\u202D\u200B\u202B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1656725310));
						num2 = (int)((num3 * 1717476780U) ^ 2804246986U);
						continue;
					case 9U:
						goto IL_0283;
					case 11U:
						AyaMisc.\u202D\u200C\u202A\u206B\u202C\u206E\u206B\u206B\u206B\u200C\u200E\u202A\u206E\u206F\u200C\u200E\u202B\u200D\u200C\u206D\u206A\u200E\u202B\u200B\u200B\u202D\u200C\u206B\u202C\u206C\u202E\u200F\u202D\u206D\u206D\u206D\u206D\u200D\u200C\u206F\u202E(AyaMisc.\u202C\u202B\u206C\u200B\u206A\u206D\u206A\u202D\u206C\u202B\u206A\u200D\u206C\u202D\u200C\u202A\u206F\u200F\u200D\u200E\u206B\u200C\u206E\u202D\u202E\u206D\u200D\u200B\u206E\u202B\u206A\u206C\u206A\u202C\u202D\u202A\u206F\u200D\u202E\u202D\u202E(this.SongLyrics), AyaMisc.\u202A\u200C\u206F\u206C\u206A\u206F\u206D\u200E\u200F\u206A\u202D\u200B\u202A\u202A\u202A\u202B\u206A\u202A\u206D\u202E\u206C\u202D\u202E\u200C\u206F\u202C\u202B\u206B\u206B\u200C\u206A\u206E\u206B\u206A\u206E\u206E\u202A\u206E\u206D\u206E\u202E(UiManager.GetPanel<SystemBoard>()), false);
						num2 = (int)((num3 * 2734282958U) ^ 2416452158U);
						continue;
					case 12U:
						goto IL_0006;
					}
					break;
				}
				goto IL_02BE;
				IL_02A5:
				AyaMisc._songLyricsToggle = true;
				return;
				IL_02BE:
				AyaMisc._songLyricsToggle = false;
				return;
				IL_0006:
				num2 = 645485163;
				goto IL_000B;
				IL_0283:
				num2 = ((!AyaMisc.\u200E\u206F\u200C\u202A\u206B\u202E\u200B\u202D\u200E\u206C\u200D\u200B\u206D\u202A\u202E\u206D\u202B\u202C\u202C\u206E\u200D\u200E\u206C\u206C\u200E\u202C\u206B\u200B\u200C\u200B\u202A\u206A\u206C\u202B\u206E\u202A\u202A\u206A\u206C\u202E\u202E(this.SongLyrics, null)) ? (-1480122928) : 844969094);
				goto IL_000B;
			}
		}

		public IEnumerator LyricsRunner(string songName)
		{
			AyaMisc.<LyricsRunner>d__8 <LyricsRunner>d__ = new AyaMisc.<LyricsRunner>d__8(0);
			<LyricsRunner>d__.<>4__this = this;
			<LyricsRunner>d__.songName = songName;
			return <LyricsRunner>d__;
		}

		static IReadOnlyList<JadeBox> \u206B\u206D\u200F\u200B\u200C\u206F\u200E\u206A\u200E\u206C\u206E\u200C\u206E\u202D\u200B\u206E\u200F\u200E\u202B\u206D\u200C\u202C\u206C\u202D\u202D\u206E\u206D\u202C\u202D\u202A\u206B\u200F\u206A\u206A\u200C\u202E\u200C\u206B\u202E\u202E(GameRunController A_0)
		{
			return A_0.JadeBoxes;
		}

		static Stage \u206D\u200D\u206C\u202E\u200E\u202D\u200C\u200B\u200C\u206C\u206A\u206B\u200B\u206D\u206D\u202B\u200C\u202B\u200F\u206E\u200E\u206A\u206E\u202D\u202C\u202C\u202B\u206E\u202C\u206B\u200C\u202E\u200F\u206A\u206D\u202D\u202B\u200C\u200F\u200C\u202E(GameRunController A_0)
		{
			return A_0.CurrentStage;
		}

		static Dictionary<string, PluginInfo> \u206E\u206D\u200B\u206E\u202D\u200C\u202C\u200C\u200C\u206C\u200F\u200D\u206D\u202B\u200D\u206D\u206D\u200D\u200E\u200F\u202C\u206E\u202B\u206A\u200C\u200B\u206E\u206D\u202A\u200F\u206D\u202D\u200C\u200E\u206A\u202E\u202D\u200F\u206F\u206C\u202E()
		{
			return Chainloader.PluginInfos;
		}

		static GameObject \u206D\u200E\u202E\u206F\u200E\u202C\u200F\u206A\u200F\u200F\u206F\u206C\u202C\u206C\u202D\u200D\u200D\u206D\u206A\u202B\u200C\u202C\u206D\u202D\u206D\u200C\u202E\u200D\u202A\u206F\u202E\u206B\u206E\u202B\u202B\u202D\u202E\u206D\u206A\u202E()
		{
			return new GameObject();
		}

		static Transform \u202C\u202B\u206C\u200B\u206A\u206D\u206A\u202D\u206C\u202B\u206A\u200D\u206C\u202D\u200C\u202A\u206F\u200F\u200D\u200E\u206B\u200C\u206E\u202D\u202E\u206D\u200D\u200B\u206E\u202B\u206A\u206C\u206A\u202C\u202D\u202A\u206F\u200D\u202E\u202D\u202E(GameObject A_0)
		{
			return A_0.transform;
		}

		static Transform \u202A\u200C\u206F\u206C\u206A\u206F\u206D\u200E\u200F\u206A\u202D\u200B\u202A\u202A\u202A\u202B\u206A\u202A\u206D\u202E\u206C\u202D\u202E\u200C\u206F\u202C\u202B\u206B\u206B\u200C\u206A\u206E\u206B\u206A\u206E\u206E\u202A\u206E\u206D\u206E\u202E(Component A_0)
		{
			return A_0.transform;
		}

		static void \u202D\u200C\u202A\u206B\u202C\u206E\u206B\u206B\u206B\u200C\u200E\u202A\u206E\u206F\u200C\u200E\u202B\u200D\u200C\u206D\u206A\u200E\u202B\u200B\u200B\u202D\u200C\u206B\u202C\u206C\u202E\u200F\u202D\u206D\u206D\u206D\u206D\u200D\u200C\u206F\u202E(Transform A_0, Transform A_1, bool A_2)
		{
			A_0.SetParent(A_1, A_2);
		}

		static void \u202E\u200F\u200C\u206A\u202B\u202C\u206D\u206D\u206E\u200F\u206D\u206F\u202E\u202E\u202A\u200D\u202C\u202D\u206E\u200D\u206A\u200C\u206C\u206B\u200F\u200C\u206E\u206C\u206C\u200B\u200B\u206C\u206B\u202C\u200C\u206A\u200B\u202B\u200E\u206B\u202E(TMP_Text A_0, TextAlignmentOptions A_1)
		{
			A_0.alignment = A_1;
		}

		static TMP_FontAsset \u206A\u200F\u206C\u206D\u202C\u200D\u202A\u200B\u200B\u202A\u206A\u202D\u200C\u202B\u202B\u206C\u206D\u206D\u206C\u206E\u206E\u206A\u206B\u200B\u206C\u206D\u206C\u200F\u202C\u206D\u200F\u206E\u200D\u202D\u206E\u202E\u206B\u202B\u206A\u206B\u202E(TMP_Text A_0)
		{
			return A_0.font;
		}

		static void \u202E\u200E\u202C\u202E\u202C\u202D\u202D\u202B\u202E\u206B\u202A\u206F\u202B\u206B\u202A\u202B\u200B\u200C\u202E\u206C\u202E\u202E\u206B\u206A\u202E\u202C\u200B\u202B\u200C\u202D\u206C\u206C\u200B\u202A\u206F\u200D\u200B\u206C\u200B\u200C\u202E(TMP_Text A_0, TMP_FontAsset A_1)
		{
			A_0.font = A_1;
		}

		static RectTransform \u202C\u202E\u200B\u206D\u202D\u206F\u206D\u206D\u200D\u200F\u202C\u200F\u202C\u200F\u206D\u206F\u206D\u202D\u206B\u202B\u200C\u206E\u202D\u200E\u206C\u206B\u206F\u202D\u206E\u200E\u206F\u206C\u202D\u206B\u206B\u202C\u202C\u206F\u200C\u206C\u202E(TMP_Text A_0)
		{
			return A_0.rectTransform;
		}

		static Vector2 \u206C\u202D\u200D\u200D\u206A\u200B\u200D\u200B\u202B\u202C\u202C\u206A\u202C\u206E\u206C\u206E\u206E\u206D\u202E\u202A\u200D\u200C\u202B\u206E\u200F\u202C\u200C\u202C\u206C\u202A\u200B\u206E\u200D\u200D\u202B\u202D\u202D\u206E\u206C\u206D\u202E(RectTransform A_0)
		{
			return A_0.sizeDelta;
		}

		static void \u202E\u200D\u200D\u206A\u200F\u200B\u202C\u202E\u202E\u202D\u206F\u202E\u200F\u200F\u206B\u206D\u206C\u200C\u200D\u206E\u206A\u206D\u200F\u206D\u200F\u200D\u200F\u202A\u202C\u206A\u206C\u202D\u200E\u202A\u200E\u202C\u200F\u202B\u200C\u202A\u202E(RectTransform A_0, Vector2 A_1)
		{
			A_0.sizeDelta = A_1;
		}

		static void \u200B\u200E\u206B\u202B\u202B\u200D\u206F\u206D\u200B\u202E\u202E\u206D\u200F\u200E\u206D\u202C\u202C\u200C\u206B\u200E\u200E\u200F\u202E\u202C\u202D\u206F\u200F\u200D\u202B\u202E\u202C\u200E\u202A\u206E\u206F\u206B\u206A\u206F\u202D\u200F\u202E(TMP_Text A_0, float A_1)
		{
			A_0.fontSize = A_1;
		}

		static void \u206E\u202B\u206D\u206E\u206F\u202E\u200D\u202D\u202C\u200E\u206A\u202C\u200C\u206B\u202D\u200E\u206D\u200B\u206F\u200C\u200B\u202D\u202D\u206F\u202A\u200E\u200D\u206A\u202E\u200D\u206A\u200E\u200D\u200E\u206A\u202A\u206A\u202B\u200C\u206B\u202E(TMP_Text A_0, float A_1)
		{
			A_0.outlineWidth = A_1;
		}

		static void \u200E\u200E\u200D\u202C\u202E\u200D\u206E\u202E\u206F\u202B\u202D\u200F\u200C\u202B\u200E\u202B\u200F\u206D\u202D\u206D\u200E\u200C\u206B\u200E\u200E\u206F\u200C\u200B\u206C\u200D\u206D\u206E\u206A\u206D\u202D\u202A\u202B\u200E\u202C\u202E\u202E(TMP_Text A_0, float A_1)
		{
			A_0.alpha = A_1;
		}

		static void \u206D\u202E\u206F\u202B\u200E\u206B\u202D\u202E\u202C\u202E\u202A\u206E\u202A\u206A\u206D\u202A\u200F\u206A\u206E\u202E\u206C\u202E\u206F\u200B\u202D\u206D\u200F\u200C\u200B\u202E\u206D\u206E\u206D\u206D\u206E\u202D\u202C\u202B\u206E\u200F\u202E(Graphic A_0, Color A_1)
		{
			A_0.color = A_1;
		}

		static Camera \u200D\u200F\u200E\u206E\u202A\u202E\u206A\u202B\u202D\u202A\u206A\u202C\u202C\u202D\u206E\u206D\u202A\u200D\u206F\u200F\u200B\u206E\u206E\u202A\u202A\u200D\u202D\u200F\u202D\u202B\u206C\u200C\u200D\u202B\u200C\u206E\u202C\u206E\u200E\u200F\u202E()
		{
			return Camera.main;
		}

		static Vector3 \u202A\u202B\u206D\u206B\u206E\u206C\u200D\u206D\u206B\u206F\u206A\u202E\u202C\u202D\u202C\u202D\u202D\u200D\u202B\u202D\u206B\u202E\u202E\u202E\u200F\u202D\u206C\u200C\u206B\u202C\u206B\u202E\u200B\u200D\u200E\u200F\u202C\u206C\u202D\u202E(Transform A_0)
		{
			return A_0.position;
		}

		static void \u206E\u200B\u200E\u206E\u206D\u200D\u206E\u206D\u206E\u206C\u206A\u200F\u206B\u200B\u206F\u202A\u206D\u206C\u206C\u202B\u200F\u200D\u200D\u200B\u206C\u202E\u202A\u206A\u206E\u206F\u200F\u206F\u200D\u200D\u206E\u206C\u202D\u206E\u200C\u206F\u202E(Transform A_0, Vector3 A_1)
		{
			A_0.position = A_1;
		}

		static GameObject \u202C\u200D\u200F\u202E\u202C\u200F\u200C\u200D\u206C\u206F\u206B\u202C\u200B\u200C\u202A\u202C\u202D\u206C\u200E\u200B\u206A\u200F\u202C\u200C\u206E\u200C\u206E\u202D\u200B\u202A\u200E\u206E\u206B\u202C\u206B\u202D\u200F\u200B\u202E\u202B\u202E(GameObject A_0)
		{
			return A_0.gameObject;
		}

		static void \u206D\u202B\u206B\u202E\u206F\u206C\u206F\u206A\u206D\u202D\u200C\u202C\u200F\u200D\u202C\u206D\u206C\u206C\u206B\u206B\u200D\u200B\u200F\u202D\u206D\u202D\u206F\u206F\u206C\u206E\u200C\u206D\u200B\u206A\u200E\u206C\u206A\u202D\u202E\u200E\u202E(GameObject A_0, bool A_1)
		{
			A_0.SetActive(A_1);
		}

		static void \u200E\u206F\u202B\u206C\u202C\u202D\u206A\u206D\u202B\u202A\u202E\u206C\u202D\u206D\u200B\u200C\u200B\u206E\u202D\u202B\u200F\u202B\u202D\u206A\u200C\u200B\u200D\u206E\u206A\u202E\u202C\u200B\u200F\u206C\u200D\u200E\u200C\u202D\u200B\u202B\u202E(object A_0)
		{
			Debug.Log(A_0);
		}

		static bool \u200E\u206F\u200C\u202A\u206B\u202E\u200B\u202D\u200E\u206C\u200D\u200B\u206D\u202A\u202E\u206D\u202B\u202C\u202C\u206E\u200D\u200E\u206C\u206C\u200E\u202C\u206B\u200B\u200C\u200B\u202A\u206A\u206C\u202B\u206E\u202A\u202A\u206A\u206C\u202E\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
		{
			return A_0 != A_1;
		}

		static void \u206D\u202A\u202B\u200B\u202E\u206C\u200C\u200E\u200C\u202E\u206B\u202C\u200B\u200C\u202B\u202A\u202B\u206E\u206E\u206A\u202C\u206A\u200B\u206A\u200F\u200D\u200C\u202E\u206F\u206F\u206B\u206D\u202E\u206C\u206B\u206E\u202D\u200D\u202C\u202E(global::UnityEngine.Object A_0)
		{
			global::UnityEngine.Object.Destroy(A_0);
		}

		private GameObject SongLyrics;

		private static bool _songLyricsToggle;

		[HarmonyPatch(typeof(CardWidget), "RefreshCardImage")]
		private class CardWidget_RefreshCardImage_Patch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static void Postfix(CardWidget __instance)
			{
				GameRunController gameRunController = AyaMisc.CardWidget_RefreshCardImage_Patch.\u206D\u202D\u200E\u202C\u202E\u206E\u206D\u200F\u206D\u206C\u200D\u206C\u200C\u206B\u206E\u206B\u206D\u202A\u202E\u206D\u202D\u202A\u200F\u206D\u202D\u206F\u202D\u200F\u206F\u202B\u206A\u202E\u206F\u206A\u200D\u206E\u200C\u206D\u206B\u200F\u202E(Singleton<GameMaster>.Instance);
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = ((gameRunController != null) ? AyaMisc.CardWidget_RefreshCardImage_Patch.\u206A\u200C\u200F\u200E\u202A\u200E\u200F\u202E\u206E\u202E\u202C\u200E\u202B\u206F\u206B\u200F\u200B\u202B\u206D\u202E\u206E\u200D\u200E\u200F\u206E\u200D\u206E\u202A\u200E\u206F\u202A\u206F\u202C\u200C\u202A\u202B\u206C\u202B\u206F\u206D\u202E(gameRunController) : null) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_001C:
					int num = -1402204562;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(~num2) - (-2033399887 ^ 178870404) + -418613405)) % 5U)
						{
						case 0U:
							num = (int)((flandrePlayerUnit.MadnessPNR ? 620559832U : 3566549205U) ^ (num3 * 4039240033U));
							continue;
						case 1U:
							num = (int)(((flandrePlayerUnit == null) ? 1150707514U : 1531802161U) ^ (num3 * 620077314U));
							continue;
						case 2U:
							goto IL_001C;
						case 4U:
							AyaMisc.CardWidget_RefreshCardImage_Patch.\u202E\u202B\u206B\u206C\u200E\u206D\u206E\u200C\u206C\u202B\u206B\u202A\u202D\u206A\u206A\u200F\u206F\u200B\u206B\u206F\u202D\u206F\u202A\u202D\u202A\u206E\u206E\u200D\u200C\u202A\u202D\u200D\u206C\u202C\u206C\u206F\u200D\u202D\u200C\u206A\u202E(__instance.cardImage, AyaMisc.CardWidget_RefreshCardImage_Patch.\u200C\u206C\u202E\u200D\u200F\u202D\u206C\u200B\u200D\u206C\u206B\u206A\u206B\u206A\u202E\u206D\u202C\u202E\u206D\u202C\u206F\u206E\u206C\u206A\u200D\u202A\u206F\u200E\u206E\u206E\u206C\u206F\u202E\u202A\u206C\u206A\u202E\u200B\u206A\u200F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1436916774), BepinexPlugin.embeddedSource));
							num = (int)((num3 * 3062872090U) ^ 3490964016U);
							continue;
						}
						return;
					}
				}
			}

			static GameRunController \u206D\u202D\u200E\u202C\u202E\u206E\u206D\u200F\u206D\u206C\u200D\u206C\u200C\u206B\u206E\u206B\u206D\u202A\u202E\u206D\u202D\u202A\u200F\u206D\u202D\u206F\u202D\u200F\u206F\u202B\u206A\u202E\u206F\u206A\u200D\u206E\u200C\u206D\u206B\u200F\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static PlayerUnit \u206A\u200C\u200F\u200E\u202A\u200E\u200F\u202E\u206E\u202E\u202C\u200E\u202B\u206F\u206B\u200F\u200B\u202B\u206D\u202E\u206E\u200D\u200E\u200F\u206E\u200D\u206E\u202A\u200E\u206F\u202A\u206F\u202C\u200C\u202A\u202B\u206C\u202B\u206F\u206D\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static Texture2D \u200C\u206C\u202E\u200D\u200F\u202D\u206C\u200B\u200D\u206C\u206B\u206A\u206B\u206A\u202E\u206D\u202C\u202E\u206D\u202C\u206F\u206E\u206C\u206A\u200D\u202A\u206F\u200E\u206E\u206E\u206C\u206F\u202E\u202A\u206C\u206A\u202E\u200B\u206A\u200F\u202E(string A_0, IResourceSource A_1)
			{
				return ResourceLoader.LoadTexture(A_0, A_1);
			}

			static void \u202E\u202B\u206B\u206C\u200E\u206D\u206E\u200C\u206C\u202B\u206B\u202A\u202D\u206A\u206A\u200F\u206F\u200B\u206B\u206F\u202D\u206F\u202A\u202D\u202A\u206E\u206E\u200D\u200C\u202A\u202D\u200D\u206C\u202C\u206C\u206F\u200D\u202D\u200C\u206A\u202E(RawImage A_0, Texture A_1)
			{
				A_0.texture = A_1;
			}
		}

		[HarmonyPatch(typeof(AudioSource), "PlayScheduled")]
		public static class AudioSource_PlayScheduled_Patch
		{
			private static void Prefix(ref double time)
			{
				if (AyaMisc._songLyricsToggle)
				{
					for (;;)
					{
						IL_000A:
						int num = 1911936824;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-2046740066 - -1442939533) * 641538737 - (num2 ^ (-796230043 ^ (1901725847 + 1394092325 + -1202103873 * 639775749))))) % 4U)
							{
							case 1U:
								num = (int)(((time - AyaMisc.AudioSource_PlayScheduled_Patch.\u202B\u202E\u206F\u202A\u200C\u200D\u206A\u200B\u206C\u202C\u206D\u200F\u200F\u206D\u200D\u206F\u206E\u200C\u202A\u206B\u202D\u206B\u200C\u200B\u200F\u206A\u202A\u202D\u200C\u206E\u206C\u206F\u202B\u200D\u202D\u200D\u206D\u206C\u200E\u202E() < 10.0) ? 2801692277U : 2831310238U) ^ (num3 * 623222544U));
								continue;
							case 2U:
								goto IL_000A;
							case 3U:
								AyaMisc.AudioSource_PlayScheduled_Patch.\u200D\u200F\u206F\u206A\u200F\u202A\u202A\u206B\u206D\u202C\u200E\u206B\u202D\u202D\u206E\u200F\u200B\u206D\u200E\u200D\u202D\u206D\u206D\u202B\u200B\u200F\u202E\u202D\u202C\u206E\u202A\u202C\u206A\u202B\u200B\u200B\u200D\u202D\u206E\u206A\u202E(Singleton<GameMaster>.Instance, AyaMisc.AudioSource_PlayScheduled_Patch.<Prefix>g__coroutine|1_0(time));
								num = (int)((num3 * 888514477U) ^ 3070861718U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			[CompilerGenerated]
			internal static IEnumerator <Prefix>g__coroutine|1_0(double d)
			{
				AyaMisc.AudioSource_PlayScheduled_Patch.<<Prefix>g__coroutine|1_0>d <<Prefix>g__coroutine|1_0>d = new AyaMisc.AudioSource_PlayScheduled_Patch.<<Prefix>g__coroutine|1_0>d(0);
				<<Prefix>g__coroutine|1_0>d.d = d;
				return <<Prefix>g__coroutine|1_0>d;
			}

			static double \u202B\u202E\u206F\u202A\u200C\u200D\u206A\u200B\u206C\u202C\u206D\u200F\u200F\u206D\u200D\u206F\u206E\u200C\u202A\u206B\u202D\u206B\u200C\u200B\u200F\u206A\u202A\u202D\u200C\u206E\u206C\u206F\u202B\u200D\u202D\u200D\u206D\u206C\u200E\u202E()
			{
				return AudioSettings.dspTime;
			}

			static Coroutine \u200D\u200F\u206F\u206A\u200F\u202A\u202A\u206B\u206D\u202C\u200E\u206B\u202D\u202D\u206E\u200F\u200B\u206D\u200E\u200D\u202D\u206D\u206D\u202B\u200B\u200F\u202E\u202D\u202C\u206E\u202A\u202C\u206A\u202B\u200B\u200B\u200D\u202D\u206E\u206A\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			public static bool SongLoop;
		}

		public static class AyaKeyword
		{
			// Note: this type is marked as 'beforefieldinit'.
			[MethodImpl(MethodImplOptions.NoInlining)]
			static AyaKeyword()
			{
				CardKeyword cardKeyword = AyaMisc.AyaKeyword.\u200D\u202E\u200D\u202A\u206C\u202E\u200D\u200C\u206D\u202C\u206F\u202B\u206E\u206A\u206D\u206F\u202C\u202A\u206B\u200F\u206E\u202B\u202B\u200F\u202C\u206A\u200F\u200C\u202A\u202D\u206A\u202A\u206B\u200D\u202B\u202A\u206A\u202E\u202E\u206F\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1244415753), false);
				cardKeyword.descPos = 2;
				AyaMisc.AyaKeyword.FlandreBloodlust = cardKeyword;
				CardKeyword cardKeyword2 = AyaMisc.AyaKeyword.\u200D\u202E\u200D\u202A\u206C\u202E\u200D\u200C\u206D\u202C\u206F\u202B\u206E\u206A\u206D\u206F\u202C\u202A\u206B\u200F\u206E\u202B\u202B\u200F\u202C\u206A\u200F\u200C\u202A\u202D\u206A\u202A\u206B\u200D\u202B\u202A\u206A\u202E\u202E\u206F\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(526124778), false);
				cardKeyword2.descPos = 2;
				AyaMisc.AyaKeyword.FlandreMagicalGirl = cardKeyword2;
				CardKeyword cardKeyword3 = AyaMisc.AyaKeyword.\u200D\u202E\u200D\u202A\u206C\u202E\u200D\u200C\u206D\u202C\u206F\u202B\u206E\u206A\u206D\u206F\u202C\u202A\u206B\u200F\u206E\u202B\u202B\u200F\u202C\u206A\u200F\u200C\u202A\u202D\u206A\u202A\u206B\u200D\u202B\u202A\u206A\u202E\u202E\u206F\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(884878524), false);
				cardKeyword3.descPos = 2;
				AyaMisc.AyaKeyword.AyaMultiplayer = cardKeyword3;
			}

			static CardKeyword \u200D\u202E\u200D\u202A\u206C\u202E\u200D\u200C\u206D\u202C\u206F\u202B\u206E\u206A\u206D\u206F\u202C\u202A\u206B\u200F\u206E\u202B\u202B\u200F\u202C\u206A\u200F\u200C\u202A\u202D\u206A\u202A\u206B\u200D\u202B\u202A\u206A\u202E\u202E\u206F\u202E(string A_0, bool A_1)
			{
				return new CardKeyword(A_0, A_1);
			}

			public static CardKeyword FlandreBloodlust;

			public static CardKeyword FlandreMagicalGirl;

			public static CardKeyword AyaMultiplayer;
		}

		[HarmonyPatch(typeof(StartGamePanel), "ConfirmSelectCharacter")]
		private class StartGamePanel_ConfirmSelectCharacter_Patch
		{
			private static void Postfix(StartGamePanel __instance)
			{
				if (!(__instance._player is AyaPlayerUnitDef.AyaPlayerUnit))
				{
					goto IL_000D;
				}
				goto IL_0079;
				int num2;
				for (;;)
				{
					IL_0012:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(((num ^ -(~1633848801 ^ (1468966798 + -295192353))) + -663942321) * -912985541 + -512342386)) % 5U)
					{
					case 0U:
						goto IL_000D;
					case 1U:
						goto IL_0079;
					case 2U:
						num2 = (int)(((!(__instance._player is FlandrePlayerUnitDef.FlandrePlayerUnit)) ? 3834687682U : 2882545510U) ^ (num3 * 4102712553U));
						continue;
					case 4U:
						AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u200D\u202E\u202C\u202A\u206C\u206B\u200E\u206E\u206A\u206F\u202D\u200C\u200F\u202D\u200B\u200B\u202E\u206E\u206A\u206B\u200F\u206C\u206D\u202D\u200F\u200D\u202A\u202E\u202C\u206F\u200C\u202A\u200C\u200B\u200C\u206E\u206D\u202B\u200E\u202E(Singleton<GameMaster>.Instance, AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<Postfix>g__coroutine|2_0(__instance));
						num2 = (int)((num3 * 3328961946U) ^ 2161829724U);
						continue;
					}
					break;
				}
				return;
				IL_000D:
				num2 = -671698500;
				goto IL_0012;
				IL_0079:
				num2 = (AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u200F\u200B\u200E\u200D\u200C\u206D\u202C\u206A\u206A\u200B\u200B\u202A\u202A\u206B\u206D\u202C\u200E\u200B\u206A\u200E\u202C\u202B\u206B\u206D\u206D\u206E\u202A\u200D\u200B\u202B\u200B\u206B\u206B\u202B\u202A\u202B\u206E\u200E\u206C\u202D\u202E(AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.PhantasmModeSwitch, null) ? 1681331034 : 1674923388);
				goto IL_0012;
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__coroutine|2_0(StartGamePanel __instance)
			{
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<<Postfix>g__coroutine|2_0>d <<Postfix>g__coroutine|2_0>d = new AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<<Postfix>g__coroutine|2_0>d(0);
				<<Postfix>g__coroutine|2_0>d.__instance = __instance;
				return <<Postfix>g__coroutine|2_0>d;
			}

			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void <Postfix>g__SetPhantasmMode|2_1(bool isOn)
			{
				BepinexPlugin.AyaPhantasmMode.Value = isOn;
				UiDialog<MessageContent> dialog = UiManager.GetDialog<MessageDialog>();
				MessageContent messageContent = AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u200F\u200C\u202E\u200D\u200C\u202D\u200F\u200B\u206A\u202D\u202D\u202B\u206B\u200B\u200B\u206D\u202B\u202D\u202B\u200E\u202C\u202E\u206B\u206F\u202B\u206D\u200E\u200F\u202E\u200D\u200B\u202A\u202D\u202A\u206E\u202E\u200B\u202A\u206F\u202C\u202E();
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u206F\u206A\u200E\u200D\u206C\u202A\u200D\u206A\u202A\u200E\u200B\u202C\u202D\u206F\u200D\u206D\u200F\u202C\u206A\u200E\u202E\u200D\u206A\u206D\u200B\u202A\u200E\u200B\u200D\u202E\u202E\u200F\u202B\u200C\u200E\u202B\u206E\u206F\u206B\u206F\u202E(messageContent, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2138777392));
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u206A\u206A\u202C\u202E\u200B\u206F\u206B\u200E\u202B\u200E\u200E\u200B\u202B\u206E\u206E\u202A\u200E\u200C\u206D\u206D\u202B\u206E\u202A\u200E\u202E\u206A\u202B\u206C\u200C\u202A\u202C\u202C\u206F\u206F\u200B\u202E\u200C\u206D\u202D\u206C\u202E(messageContent, DialogButtons.ConfirmCancel);
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u206D\u202C\u206F\u200E\u206A\u206F\u206D\u200B\u202C\u206F\u206C\u206C\u202B\u200F\u202C\u202A\u200E\u202C\u200E\u206F\u200E\u206F\u202B\u200D\u202A\u206A\u206D\u200D\u200D\u206C\u202E\u206F\u206F\u206E\u202A\u200C\u200F\u206B\u206D\u206D\u202E(messageContent, new Action(GameMaster.QuitGame));
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u206D\u206A\u202A\u200D\u206A\u206B\u202A\u206A\u206C\u202B\u206D\u200F\u206B\u200C\u206F\u206C\u200F\u206E\u206A\u206B\u202D\u202A\u200E\u206E\u200B\u202C\u200E\u202D\u200F\u206E\u200F\u200F\u200D\u206F\u202A\u202A\u202E\u206F\u206C\u202A\u202E(messageContent, new Action(AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<Postfix>g__CancelChange|2_3));
				dialog.Show(messageContent);
			}

			[CompilerGenerated]
			internal static void <Postfix>g__CancelChange|2_3()
			{
				BepinexPlugin.AyaPhantasmMode.Value = !BepinexPlugin.AyaPhantasmMode.Value;
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.\u202A\u206A\u200D\u202D\u206F\u202A\u200C\u202A\u200C\u200F\u202C\u202E\u200D\u200F\u202A\u200E\u202D\u200C\u200E\u202E\u202E\u200F\u206A\u202D\u206A\u200C\u206A\u202C\u206F\u202E\u202A\u206F\u206D\u200E\u206B\u206A\u206D\u200D\u206B\u202C\u202E(AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.PhantasmModeSwitch, BepinexPlugin.AyaPhantasmMode.Value, true);
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__Hide|2_2(StartGamePanel startGamePanel)
			{
				AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<<Postfix>g__Hide|2_2>d <<Postfix>g__Hide|2_2>d = new AyaMisc.StartGamePanel_ConfirmSelectCharacter_Patch.<<Postfix>g__Hide|2_2>d(0);
				<<Postfix>g__Hide|2_2>d.startGamePanel = startGamePanel;
				return <<Postfix>g__Hide|2_2>d;
			}

			static bool \u200F\u200B\u200E\u200D\u200C\u206D\u202C\u206A\u206A\u200B\u200B\u202A\u202A\u206B\u206D\u202C\u200E\u200B\u206A\u200E\u202C\u202B\u206B\u206D\u206D\u206E\u202A\u200D\u200B\u202B\u200B\u206B\u206B\u202B\u202A\u202B\u206E\u200E\u206C\u202D\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
			{
				return A_0 == A_1;
			}

			static Coroutine \u200D\u202E\u202C\u202A\u206C\u206B\u200E\u206E\u206A\u206F\u202D\u200C\u200F\u202D\u200B\u200B\u202E\u206E\u206A\u206B\u200F\u206C\u206D\u202D\u200F\u200D\u202A\u202E\u202C\u206F\u200C\u202A\u200C\u200B\u200C\u206E\u206D\u202B\u200E\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static MessageContent \u200F\u200C\u202E\u200D\u200C\u202D\u200F\u200B\u206A\u202D\u202D\u202B\u206B\u200B\u200B\u206D\u202B\u202D\u202B\u200E\u202C\u202E\u206B\u206F\u202B\u206D\u200E\u200F\u202E\u200D\u200B\u202A\u202D\u202A\u206E\u202E\u200B\u202A\u206F\u202C\u202E()
			{
				return new MessageContent();
			}

			static void \u206F\u206A\u200E\u200D\u206C\u202A\u200D\u206A\u202A\u200E\u200B\u202C\u202D\u206F\u200D\u206D\u200F\u202C\u206A\u200E\u202E\u200D\u206A\u206D\u200B\u202A\u200E\u200B\u200D\u202E\u202E\u200F\u202B\u200C\u200E\u202B\u206E\u206F\u206B\u206F\u202E(MessageContent A_0, string A_1)
			{
				A_0.TextKey = A_1;
			}

			static void \u206A\u206A\u202C\u202E\u200B\u206F\u206B\u200E\u202B\u200E\u200E\u200B\u202B\u206E\u206E\u202A\u200E\u200C\u206D\u206D\u202B\u206E\u202A\u200E\u202E\u206A\u202B\u206C\u200C\u202A\u202C\u202C\u206F\u206F\u200B\u202E\u200C\u206D\u202D\u206C\u202E(MessageContent A_0, DialogButtons A_1)
			{
				A_0.Buttons = A_1;
			}

			static void \u206D\u202C\u206F\u200E\u206A\u206F\u206D\u200B\u202C\u206F\u206C\u206C\u202B\u200F\u202C\u202A\u200E\u202C\u200E\u206F\u200E\u206F\u202B\u200D\u202A\u206A\u206D\u200D\u200D\u206C\u202E\u206F\u206F\u206E\u202A\u200C\u200F\u206B\u206D\u206D\u202E(MessageContent A_0, Action A_1)
			{
				A_0.OnConfirm = A_1;
			}

			static void \u206D\u206A\u202A\u200D\u206A\u206B\u202A\u206A\u206C\u202B\u206D\u200F\u206B\u200C\u206F\u206C\u200F\u206E\u206A\u206B\u202D\u202A\u200E\u206E\u200B\u202C\u200E\u202D\u200F\u206E\u200F\u200F\u200D\u206F\u202A\u202A\u202E\u206F\u206C\u202A\u202E(MessageContent A_0, Action A_1)
			{
				A_0.OnCancel = A_1;
			}

			static void \u202A\u206A\u200D\u202D\u206F\u202A\u200C\u202A\u200C\u200F\u202C\u202E\u200D\u200F\u202A\u200E\u202D\u200C\u200E\u202E\u202E\u200F\u206A\u202D\u206A\u200C\u206A\u202C\u206F\u202E\u202A\u206F\u206D\u200E\u206B\u206A\u206D\u200D\u206B\u202C\u202E(SwitchWidget A_0, bool A_1, bool A_2)
			{
				A_0.SetValueWithoutNotifier(A_1, A_2);
			}

			public static SwitchWidget PhantasmModeSwitch;

			public static SimpleTooltipSource PhantasmModeTooltip;
		}

		[HarmonyPatch(typeof(ShopPanel), "CoShowAnimation", 5)]
		private class ShopPanel_CoShowAnimation_Patch
		{
			private static void Postfix(ShopPanel __instance)
			{
				if (AyaMisc.IsValidGameRun(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200B\u206E\u200C\u202C\u206D\u202A\u206D\u206D\u202B\u200D\u202A\u206B\u202C\u202D\u202E\u202E\u202B\u206E\u206A\u206D\u202D\u200D\u202A\u206B\u206B\u200F\u202A\u206A\u200D\u202C\u202B\u206C\u202B\u202B\u200C\u202A\u206D\u206E\u206D\u206B\u202E(Singleton<GameMaster>.Instance)))
				{
					for (;;)
					{
						IL_0014:
						int num = -900018709;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((num2 ^ ((1903958513 * 1771428403 - ~706980702) ^ -383909190)) - (-1652419760 ^ (-1008694116 ^ -523696485))) * -880204305 * -1168015961)) % 7U)
							{
							case 1U:
							{
								FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
								num = (int)(((!flandrePlayerUnit.TakaneDefeated) ? 336646711U : 3775215314U) ^ (num3 * 4136916158U));
								continue;
							}
							case 2U:
								goto IL_0014;
							case 3U:
							{
								FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200D\u200F\u200F\u200E\u206A\u202B\u202D\u206D\u200E\u200C\u200B\u206E\u202A\u202C\u202C\u206E\u200B\u206A\u206C\u206A\u202A\u200C\u202D\u200B\u202C\u200D\u202C\u206E\u200F\u206F\u200F\u206B\u206B\u200B\u202B\u206A\u202B\u206C\u200C\u202C\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200B\u206E\u200C\u202C\u206D\u202A\u206D\u206D\u202B\u200D\u202A\u206B\u202C\u202D\u202E\u202E\u202B\u206E\u206A\u206D\u202D\u200D\u202A\u206B\u206B\u200F\u202A\u206A\u200D\u202C\u202B\u206C\u202B\u202B\u200C\u202A\u206D\u206E\u206D\u206B\u202E(Singleton<GameMaster>.Instance)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
								num = (int)((num3 * 1076794770U) ^ 3808591487U);
								continue;
							}
							case 4U:
								num = (int)((AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202E\u206F\u200C\u200C\u200E\u202D\u200E\u202A\u206B\u202A\u206F\u206A\u202E\u206A\u206F\u200D\u202A\u206E\u206D\u200D\u206E\u206A\u206B\u202C\u202E\u200C\u206C\u200D\u202B\u202B\u202A\u202D\u206E\u200B\u202B\u202B\u206B\u202B\u202E\u200E\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.AttackButton, null) ? 3070897428U : 2226003866U) ^ (num3 * 3397792251U));
								continue;
							case 5U:
								AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206A\u206F\u200E\u202E\u200F\u206B\u202C\u202C\u202C\u202D\u202D\u200E\u202D\u202E\u206C\u200C\u206D\u200B\u206F\u206B\u202A\u206B\u206A\u202E\u202E\u202D\u206D\u206B\u206F\u202A\u206A\u206E\u200E\u202D\u206F\u202C\u202A\u202E\u206D\u200F\u202E(Singleton<GameMaster>.Instance, AyaMisc.ShopPanel_CoShowAnimation_Patch.<Postfix>g__coroutine|2_0());
								num = (int)((num3 * 1445249551U) ^ 3201562761U);
								continue;
							case 6U:
							{
								FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit;
								num = (int)(((flandrePlayerUnit == null) ? 1767556394U : 61734007U) ^ (num3 * 1103573263U));
								continue;
							}
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__coroutine|2_0()
			{
				return new AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__coroutine|2_0>d(0);
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__coroutine1|2_1()
			{
				return new AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__coroutine1|2_1>d(0);
			}

			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void <Postfix>g__OnClicked|2_2()
			{
				UiDialog<MessageContent> dialog = UiManager.GetDialog<MessageDialog>();
				MessageContent messageContent = AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206C\u206A\u202C\u206F\u200B\u206F\u206D\u206D\u206E\u202A\u200B\u202D\u200E\u206C\u200E\u206A\u202C\u200E\u202D\u202D\u200E\u200D\u202B\u200F\u202B\u206D\u200D\u200E\u206A\u206E\u206B\u202B\u202D\u202D\u202D\u200C\u206B\u200D\u206F\u202B\u202E();
				AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202E\u200B\u200C\u202E\u202E\u200C\u200C\u200D\u206C\u206D\u206E\u202B\u200F\u202E\u200D\u202B\u202C\u200E\u206B\u206A\u200E\u202C\u206C\u200C\u200E\u202B\u202D\u206F\u200E\u206B\u202B\u200E\u206D\u206A\u206C\u202C\u200C\u200B\u202A\u206F\u202E(messageContent, AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206F\u200B\u200C\u202D\u202B\u206C\u206B\u206E\u200D\u202C\u206B\u206C\u206E\u200C\u200C\u200F\u202E\u206F\u206C\u200C\u206E\u202E\u202C\u206A\u206C\u206F\u200C\u202A\u206E\u206F\u200F\u200E\u206D\u206C\u206B\u206C\u206D\u200B\u202B\u200F\u202E(AyaTakane.AyaTakaneAttack, new object[] { AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200E\u206F\u200E\u202D\u200C\u206F\u200B\u200B\u200B\u200F\u200E\u200E\u206D\u202B\u202A\u206F\u206E\u202E\u200C\u202E\u202C\u206B\u202C\u202E\u206E\u206C\u200D\u206E\u202B\u200B\u206F\u200D\u202B\u200B\u206E\u200C\u200C\u206F\u202B\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202C\u206D\u202D\u200E\u200B\u202D\u202A\u206D\u200B\u202C\u200C\u206F\u206A\u200F\u202E\u206F\u202A\u202C\u206D\u206F\u200B\u200D\u200C\u202B\u202D\u202E\u206F\u202D\u200D\u200B\u200F\u200C\u202A\u202A\u206D\u206F\u206C\u202E\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200B\u206F\u202A\u200F\u202E\u200F\u200B\u202C\u202B\u206E\u200D\u202C\u206C\u200C\u200C\u200D\u202A\u202D\u206C\u202B\u206F\u206E\u202E\u206A\u206B\u206D\u206A\u202A\u200D\u206E\u202B\u206E\u200C\u206E\u202C\u206A\u202C\u206A\u206C\u200C\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200B\u200B\u206D\u206E\u206A\u200B\u206B\u206D\u206C\u206B\u202D\u200B\u206F\u202E\u200E\u202C\u206F\u202A\u200D\u206C\u200D\u206C\u202D\u206D\u202E\u206D\u200F\u202A\u206B\u200B\u206F\u206B\u202D\u200C\u200F\u200B\u206F\u206D\u206D\u206B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1593990916))), AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200E\u200B\u206C\u202C\u200E\u206B\u200C\u202D\u202B\u206C\u202B\u206D\u206E\u202E\u206F\u202C\u202E\u200B\u202C\u202C\u206B\u200D\u200F\u206A\u200B\u206C\u206A\u202C\u206D\u200D\u202B\u200B\u202A\u206E\u200D\u202A\u202C\u202C\u200C\u200F\u202E(AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200B\u200B\u206D\u206E\u206A\u200B\u206B\u206D\u206C\u206B\u202D\u200B\u206F\u202E\u200E\u202C\u206F\u202A\u200D\u206C\u200D\u206C\u202D\u206D\u202E\u206D\u200F\u202A\u206B\u200B\u206F\u206B\u202D\u200C\u200F\u200B\u206F\u206D\u206D\u206B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1263097182)))), true, NounCase.Nominative, UnitNameStyle.Short) }));
				AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206F\u200B\u206E\u206F\u200B\u200E\u206E\u206F\u206C\u206A\u200C\u202E\u206F\u206B\u202C\u202A\u200C\u202B\u200E\u206B\u206D\u200C\u200D\u200F\u200D\u200E\u206E\u206A\u200B\u206C\u206F\u202D\u206D\u200D\u200F\u200D\u200B\u202E\u206B\u206A\u202E(messageContent, null);
				AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202B\u200C\u200B\u202C\u202A\u202B\u206C\u202B\u202B\u202E\u202D\u200B\u206E\u200D\u206D\u206C\u206D\u206E\u206B\u202E\u200C\u200F\u206D\u206D\u200D\u200C\u206A\u200D\u206D\u206F\u200C\u206D\u200B\u200F\u200E\u202C\u200E\u206F\u206E\u202C\u202E(messageContent, DialogButtons.ConfirmCancel);
				AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206F\u202E\u206E\u200D\u206C\u206B\u202A\u202D\u202A\u206B\u202D\u202E\u202E\u200B\u206A\u202B\u202D\u206B\u200E\u202C\u206A\u200D\u200D\u202B\u202A\u206F\u200C\u202A\u202D\u202D\u206C\u206C\u202D\u206C\u200D\u206A\u206B\u202C\u200D\u200F\u202E(messageContent, new Action(AyaMisc.ShopPanel_CoShowAnimation_Patch.<Postfix>g__OnConfirmed|2_5));
				AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206D\u200C\u206E\u206A\u206C\u206F\u206E\u200D\u202D\u202D\u200B\u200D\u200B\u202E\u200E\u206F\u206D\u202D\u206F\u200E\u200D\u200C\u200F\u202A\u202D\u202C\u206E\u202D\u206E\u200B\u200C\u200E\u206A\u200B\u202C\u202E\u202D\u206D\u206F\u202D\u202E(messageContent, null);
				dialog.Show(messageContent);
			}

			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal static void <Postfix>g__OnConfirmed|2_5()
			{
				ShopPanel panel = UiManager.GetPanel<ShopPanel>();
				for (;;)
				{
					IL_0006:
					int num = 729726645;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)(~num2 - (705586119 + -1854664848) * 398695777)))) % 6U)
						{
						case 0U:
							num = (int)((AyaMisc.ShopPanel_CoShowAnimation_Patch.\u200E\u206C\u206A\u202A\u202E\u200B\u202A\u202D\u206B\u206F\u200C\u200B\u200D\u206E\u206F\u200D\u202D\u200D\u202C\u206D\u202B\u202A\u206C\u202B\u206D\u202A\u202A\u200D\u206B\u202B\u200E\u202D\u206D\u202A\u200B\u202D\u200F\u202A\u206A\u202E\u202E(panel) ? 3535533581U : 2914310056U) ^ (num3 * 1150415312U));
							continue;
						case 1U:
							return;
						case 3U:
							num = (int)(((!panel._interactable) ? 2882160203U : 4229476216U) ^ (num3 * 3811378306U));
							continue;
						case 4U:
						{
							AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202C\u200F\u200B\u200E\u206C\u202B\u206E\u202A\u206F\u202E\u202D\u206B\u200D\u206B\u202D\u206B\u202C\u206E\u206C\u200E\u206D\u206B\u206D\u206D\u200B\u206E\u200D\u206B\u200F\u206D\u206F\u202A\u202C\u206F\u200B\u200D\u200E\u200C\u206F\u206E\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-530247480), false);
							ShopStation shopStation = panel.ShopStation;
							AyaMisc.ShopPanel_CoShowAnimation_Patch.\u202B\u206E\u200D\u200B\u206D\u202E\u202C\u206A\u202C\u202B\u200D\u206D\u206A\u202E\u206F\u200E\u206A\u202C\u206C\u206C\u206B\u206B\u202C\u202C\u202E\u202A\u206B\u202D\u206E\u202A\u200C\u202E\u202C\u202C\u206F\u206E\u206D\u200C\u202E\u202C\u202E(panel);
							AyaMisc.ShopPanel_CoShowAnimation_Patch.\u206A\u206F\u200E\u202E\u200F\u206B\u202C\u202C\u202C\u202D\u202D\u200E\u202D\u202E\u206C\u200C\u206D\u200B\u206F\u206B\u202A\u206B\u206A\u202E\u202E\u202D\u206D\u206B\u206F\u202A\u206A\u206E\u200E\u202D\u206F\u202C\u202A\u202E\u206D\u200F\u202E(Singleton<GameMaster>.Instance, AyaMisc.ShopPanel_CoShowAnimation_Patch.<Postfix>g__startBattle|2_6(panel, shopStation));
							num = 37364752;
							continue;
						}
						case 5U:
							goto IL_0006;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__startBattle|2_6(ShopPanel shopPanel, ShopStation shopStation)
			{
				AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__startBattle|2_6>d <<Postfix>g__startBattle|2_6>d = new AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__startBattle|2_6>d(0);
				<<Postfix>g__startBattle|2_6>d.shopPanel = shopPanel;
				<<Postfix>g__startBattle|2_6>d.shopStation = shopStation;
				return <<Postfix>g__startBattle|2_6>d;
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__hideButton|2_7()
			{
				return new AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__hideButton|2_7>d(0);
			}

			[CompilerGenerated]
			internal static IEnumerator <Postfix>g__Hide|2_3()
			{
				return new AyaMisc.ShopPanel_CoShowAnimation_Patch.<<Postfix>g__Hide|2_3>d(0);
			}

			static GameRunController \u200B\u206E\u200C\u202C\u206D\u202A\u206D\u206D\u202B\u200D\u202A\u206B\u202C\u202D\u202E\u202E\u202B\u206E\u206A\u206D\u202D\u200D\u202A\u206B\u206B\u200F\u202A\u206A\u200D\u202C\u202B\u206C\u202B\u202B\u200C\u202A\u206D\u206E\u206D\u206B\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static PlayerUnit \u200D\u200F\u200F\u200E\u206A\u202B\u202D\u206D\u200E\u200C\u200B\u206E\u202A\u202C\u202C\u206E\u200B\u206A\u206C\u206A\u202A\u200C\u202D\u200B\u202C\u200D\u202C\u206E\u200F\u206F\u200F\u206B\u206B\u200B\u202B\u206A\u202B\u206C\u200C\u202C\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static bool \u202E\u206F\u200C\u200C\u200E\u202D\u200E\u202A\u206B\u202A\u206F\u206A\u202E\u206A\u206F\u200D\u202A\u206E\u206D\u200D\u206E\u206A\u206B\u202C\u202E\u200C\u206C\u200D\u202B\u202B\u202A\u202D\u206E\u200B\u202B\u202B\u206B\u202B\u202E\u200E\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
			{
				return A_0 == A_1;
			}

			static Coroutine \u206A\u206F\u200E\u202E\u200F\u206B\u202C\u202C\u202C\u202D\u202D\u200E\u202D\u202E\u206C\u200C\u206D\u200B\u206F\u206B\u202A\u206B\u206A\u202E\u202E\u202D\u206D\u206B\u206F\u202A\u206A\u206E\u200E\u202D\u206F\u202C\u202A\u202E\u206D\u200F\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static MessageContent \u206C\u206A\u202C\u206F\u200B\u206F\u206D\u206D\u206E\u202A\u200B\u202D\u200E\u206C\u200E\u206A\u202C\u200E\u202D\u202D\u200E\u200D\u202B\u200F\u202B\u206D\u200D\u200E\u206A\u206E\u206B\u202B\u202D\u202D\u202D\u200C\u206B\u200D\u206F\u202B\u202E()
			{
				return new MessageContent();
			}

			static EnemyUnitConfig \u200B\u200B\u206D\u206E\u206A\u200B\u206B\u206D\u206C\u206B\u202D\u200B\u206F\u202E\u200E\u202C\u206F\u202A\u200D\u206C\u200D\u206C\u202D\u206D\u202E\u206D\u200F\u202A\u206B\u200B\u206F\u206B\u202D\u200C\u200F\u200B\u206F\u206D\u206D\u206B\u202E(string A_0)
			{
				return EnemyUnitConfig.FromId(A_0);
			}

			static string \u200B\u206F\u202A\u200F\u202E\u200F\u200B\u202C\u202B\u206E\u200D\u202C\u206C\u200C\u200C\u200D\u202A\u202D\u206C\u202B\u206F\u206E\u202E\u206A\u206B\u206D\u206A\u202A\u200D\u206E\u202B\u206E\u200C\u206E\u202C\u206A\u202C\u206A\u206C\u200C\u202E(EnemyUnitConfig A_0)
			{
				return A_0.Id;
			}

			static string \u200E\u200B\u206C\u202C\u200E\u206B\u200C\u202D\u202B\u206C\u202B\u206D\u206E\u202E\u206F\u202C\u202E\u200B\u202C\u202C\u206B\u200D\u200F\u206A\u200B\u206C\u206A\u202C\u206D\u200D\u202B\u200B\u202A\u206E\u200D\u202A\u202C\u202C\u200C\u200F\u202E(EnemyUnitConfig A_0)
			{
				return A_0.NarrativeColor;
			}

			static UnitName \u202C\u206D\u202D\u200E\u200B\u202D\u202A\u206D\u200B\u202C\u200C\u206F\u206A\u200F\u202E\u206F\u202A\u202C\u206D\u206F\u200B\u200D\u200C\u202B\u202D\u202E\u206F\u202D\u200D\u200B\u200F\u200C\u202A\u202A\u206D\u206F\u206C\u202E\u202E(string A_0, string A_1)
			{
				return UnitNameTable.GetName(A_0, A_1);
			}

			static string \u200E\u206F\u200E\u202D\u200C\u206F\u200B\u200B\u200B\u200F\u200E\u200E\u206D\u202B\u202A\u206F\u206E\u202E\u200C\u202E\u202C\u206B\u202C\u202E\u206E\u206C\u200D\u206E\u202B\u200B\u206F\u200D\u202B\u200B\u206E\u200C\u200C\u206F\u202B\u202E(UnitName A_0, bool A_1, NounCase A_2, UnitNameStyle A_3)
			{
				return A_0.ToString(A_1, A_2, A_3);
			}

			static string \u206F\u200B\u200C\u202D\u202B\u206C\u206B\u206E\u200D\u202C\u206B\u206C\u206E\u200C\u200C\u200F\u202E\u206F\u206C\u200C\u206E\u202E\u202C\u206A\u206C\u206F\u200C\u202A\u206E\u206F\u200F\u200E\u206D\u206C\u206B\u206C\u206D\u200B\u202B\u200F\u202E(string A_0, object[] A_1)
			{
				return A_0.SequenceFormat(A_1);
			}

			static void \u202E\u200B\u200C\u202E\u202E\u200C\u200C\u200D\u206C\u206D\u206E\u202B\u200F\u202E\u200D\u202B\u202C\u200E\u206B\u206A\u200E\u202C\u206C\u200C\u200E\u202B\u202D\u206F\u200E\u206B\u202B\u200E\u206D\u206A\u206C\u202C\u200C\u200B\u202A\u206F\u202E(MessageContent A_0, string A_1)
			{
				A_0.Text = A_1;
			}

			static void \u206F\u200B\u206E\u206F\u200B\u200E\u206E\u206F\u206C\u206A\u200C\u202E\u206F\u206B\u202C\u202A\u200C\u202B\u200E\u206B\u206D\u200C\u200D\u200F\u200D\u200E\u206E\u206A\u200B\u206C\u206F\u202D\u206D\u200D\u200F\u200D\u200B\u202E\u206B\u206A\u202E(MessageContent A_0, string A_1)
			{
				A_0.TextKey = A_1;
			}

			static void \u202B\u200C\u200B\u202C\u202A\u202B\u206C\u202B\u202B\u202E\u202D\u200B\u206E\u200D\u206D\u206C\u206D\u206E\u206B\u202E\u200C\u200F\u206D\u206D\u200D\u200C\u206A\u200D\u206D\u206F\u200C\u206D\u200B\u200F\u200E\u202C\u200E\u206F\u206E\u202C\u202E(MessageContent A_0, DialogButtons A_1)
			{
				A_0.Buttons = A_1;
			}

			static void \u206F\u202E\u206E\u200D\u206C\u206B\u202A\u202D\u202A\u206B\u202D\u202E\u202E\u200B\u206A\u202B\u202D\u206B\u200E\u202C\u206A\u200D\u200D\u202B\u202A\u206F\u200C\u202A\u202D\u202D\u206C\u206C\u202D\u206C\u200D\u206A\u206B\u202C\u200D\u200F\u202E(MessageContent A_0, Action A_1)
			{
				A_0.OnConfirm = A_1;
			}

			static void \u206D\u200C\u206E\u206A\u206C\u206F\u206E\u200D\u202D\u202D\u200B\u200D\u200B\u202E\u200E\u206F\u206D\u202D\u206F\u200E\u200D\u200C\u200F\u202A\u202D\u202C\u206E\u202D\u206E\u200B\u200C\u200E\u206A\u200B\u202C\u202E\u202D\u206D\u206F\u202D\u202E(MessageContent A_0, Action A_1)
			{
				A_0.OnCancel = A_1;
			}

			static bool \u200E\u206C\u206A\u202A\u202E\u200B\u202A\u202D\u206B\u206F\u200C\u200B\u200D\u206E\u206F\u200D\u202D\u200D\u202C\u206D\u202B\u202A\u206C\u202B\u206D\u202A\u202A\u200D\u206B\u202B\u200E\u202D\u206D\u202A\u200B\u202D\u200F\u202A\u206A\u202E\u202E(ShopPanel A_0)
			{
				return A_0.LockedByInteractionMinimized;
			}

			static void \u202C\u200F\u200B\u200E\u206C\u202B\u206E\u202A\u206F\u202E\u202D\u206B\u200D\u206B\u202D\u206B\u202C\u206E\u206C\u200E\u206D\u206B\u206D\u206D\u200B\u206E\u200D\u206B\u200F\u206D\u206F\u202A\u202C\u206F\u200B\u200D\u200E\u200C\u206F\u206E\u202E(string A_0, bool A_1)
			{
				AudioManager.PlayUi(A_0, A_1);
			}

			static void \u202B\u206E\u200D\u200B\u206D\u202E\u202C\u206A\u202C\u202B\u200D\u206D\u206A\u202E\u206F\u200E\u206A\u202C\u206C\u206C\u206B\u206B\u202C\u202C\u202E\u202A\u206B\u202D\u206E\u202A\u200C\u202E\u202C\u202C\u206F\u206E\u206D\u200C\u202E\u202C\u202E(UiPanelBase A_0)
			{
				A_0.Hide();
			}

			public static Button AttackButton;

			public static GameObject AttackImage;
		}

		[HarmonyPatch(typeof(GameMaster), "SwitchToStation", new Type[] { typeof(Station) })]
		private class GameMaster_SwitchToStation_Patch
		{
			private static bool Prefix(GameMaster __instance, ref Station station)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = AyaMisc.GameMaster_SwitchToStation_Patch.\u200B\u200B\u200F\u202B\u206A\u206F\u206A\u202E\u206D\u206E\u206F\u202D\u206A\u200F\u200B\u206E\u202A\u200F\u200D\u200C\u202B\u200B\u200D\u200F\u202E\u200C\u200E\u200E\u206E\u200E\u206E\u206E\u202A\u202D\u202C\u202B\u206E\u206E\u206C\u202E(AyaMisc.GameMaster_SwitchToStation_Patch.\u206E\u202B\u202C\u200E\u206C\u202A\u206B\u206A\u200B\u206F\u206F\u200C\u200D\u206E\u202B\u200B\u202D\u202D\u206E\u202C\u206C\u200F\u200F\u200B\u202C\u200B\u206C\u200F\u202E\u202B\u206F\u202A\u200D\u202B\u200E\u206F\u200D\u202E\u206A\u202E(Singleton<GameMaster>.Instance)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				if (flandrePlayerUnit != null)
				{
					for (;;)
					{
						IL_001B:
						int num = 1524240352;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(-(2009349937 * -2116148722 - num2) * -1792603809))) % 6U)
							{
							case 0U:
								goto IL_00C4;
							case 1U:
								num = (int)((flandrePlayerUnit.TakaneTalked ? 3162830222U : 127750209U) ^ (num3 * 2122448414U));
								continue;
							case 2U:
								num = (int)((flandrePlayerUnit.TakaneDefeated ? 3855565619U : 385610712U) ^ (num3 * 2161046912U));
								continue;
							case 3U:
								goto IL_001B;
							case 5U:
								num = (int)(((AyaMisc.GameMaster_SwitchToStation_Patch.\u200C\u206B\u206B\u206E\u206E\u206D\u206B\u200E\u206F\u206B\u202B\u200F\u206B\u202D\u200F\u202B\u202A\u202C\u202B\u200B\u206C\u206E\u206E\u202E\u206F\u200D\u206C\u200C\u200E\u206C\u206A\u200B\u200F\u206B\u202B\u200F\u200B\u202D\u200D\u202E\u202E(station) == StationType.Shop) ? 2970022701U : 2960653757U) ^ (num3 * 1784685437U));
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					return true;
					IL_00C4:
					AyaMisc.GameMaster_SwitchToStation_Patch.\u202E\u202E\u200C\u202A\u202A\u200D\u200D\u206B\u202E\u206C\u206E\u202D\u206C\u200E\u200D\u202A\u200E\u206F\u200D\u200E\u202A\u206A\u206D\u206F\u202C\u200D\u206A\u202C\u200B\u200B\u200D\u200B\u202B\u200F\u206D\u202C\u202D\u206F\u202B\u206A\u202E(Singleton<GameMaster>.Instance, AyaMisc.GameMaster_SwitchToStation_Patch.<Prefix>g__coroutine|0_0());
					return false;
				}
				return true;
			}

			[CompilerGenerated]
			internal static IEnumerator <Prefix>g__coroutine|0_0()
			{
				return new AyaMisc.GameMaster_SwitchToStation_Patch.<<Prefix>g__coroutine|0_0>d(0);
			}

			static GameRunController \u206E\u202B\u202C\u200E\u206C\u202A\u206B\u206A\u200B\u206F\u206F\u200C\u200D\u206E\u202B\u200B\u202D\u202D\u206E\u202C\u206C\u200F\u200F\u200B\u202C\u200B\u206C\u200F\u202E\u202B\u206F\u202A\u200D\u202B\u200E\u206F\u200D\u202E\u206A\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static PlayerUnit \u200B\u200B\u200F\u202B\u206A\u206F\u206A\u202E\u206D\u206E\u206F\u202D\u206A\u200F\u200B\u206E\u202A\u200F\u200D\u200C\u202B\u200B\u200D\u200F\u202E\u200C\u200E\u200E\u206E\u200E\u206E\u206E\u202A\u202D\u202C\u202B\u206E\u206E\u206C\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static StationType \u200C\u206B\u206B\u206E\u206E\u206D\u206B\u200E\u206F\u206B\u202B\u200F\u206B\u202D\u200F\u202B\u202A\u202C\u202B\u200B\u206C\u206E\u206E\u202E\u206F\u200D\u206C\u200C\u200E\u206C\u206A\u200B\u200F\u206B\u202B\u200F\u200B\u202D\u200D\u202E\u202E(Station A_0)
			{
				return A_0.Type;
			}

			static Coroutine \u202E\u202E\u200C\u202A\u202A\u200D\u200D\u206B\u202E\u206C\u206E\u202D\u206C\u200E\u200D\u202A\u200E\u206F\u200D\u200E\u202A\u206A\u206D\u206F\u202C\u200D\u206A\u202C\u200B\u200B\u200D\u200B\u202B\u200F\u206D\u202C\u202D\u206F\u202B\u206A\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}
		}

		[HarmonyPatch(typeof(GameMap), "SetAdjacentNodesStatus")]
		private class GameMap_SetAdjacentNodesStatus_Patch
		{
			private static bool Prefix(GameMap __instance)
			{
				return !BepinexPlugin.StoryWait;
			}
		}

		[HarmonyPatch(typeof(GameRunController), "Create")]
		private class GameRunController_Create_Patch
		{
			private static void Prefix(GameRunController __instance, ref GameRunStartupParameters parameters)
			{
				IEnumerator<CardConfig> enumerator;
				IEnumerator<ExhibitConfig> enumerator2;
				if (AyaMisc.GameRunController_Create_Patch.\u200B\u202B\u206C\u206C\u202A\u202B\u202B\u200E\u200B\u206D\u200F\u202C\u200E\u202B\u202C\u206D\u202C\u206F\u200C\u200D\u202E\u202A\u206B\u202A\u206C\u206F\u202C\u202D\u206E\u200F\u200F\u200E\u200C\u202C\u206D\u206E\u206D\u206F\u206C\u202C\u202E(parameters) is AyaPlayerUnitDef.AyaPlayerUnit)
				{
					enumerator = AyaMisc.GameRunController_Create_Patch.\u202B\u206C\u202D\u200D\u200D\u200F\u200D\u206B\u206D\u200C\u200F\u206E\u200B\u200C\u202D\u200C\u202C\u200D\u200C\u206A\u202D\u206B\u206D\u202D\u200B\u200F\u206E\u202B\u200C\u202A\u200C\u206B\u206E\u202A\u206D\u202C\u202C\u200F\u200F\u202E().Where(delegate(CardConfig c)
					{
						if (AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u202C\u206A\u202E\u206F\u206A\u200E\u206B\u200F\u206E\u206F\u200F\u202A\u200C\u200D\u200D\u206B\u206A\u206D\u206D\u202C\u202E\u206D\u202D\u202D\u202E\u200F\u206D\u206F\u202B\u200B\u206C\u206C\u206F\u206D\u200C\u200D\u202A\u202E\u206F\u206F\u202E(c), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-714371867)))
						{
							for (;;)
							{
								int num19 = 1533193065;
								switch (-(num19 - ((947421273 * -1047640791) ^ (-577105280 ^ 2094258524) ^ -919865486)) % 3)
								{
								case 0:
									continue;
								case 2:
									goto IL_0057;
								}
								break;
							}
							return false;
							IL_0057:
							return AyaMisc.GameRunController_Create_Patch.<>c.\u200D\u202B\u206D\u206B\u206F\u202B\u206D\u200D\u206B\u206B\u202B\u206E\u202C\u200E\u206C\u206F\u202C\u206E\u206A\u206C\u200C\u202D\u206A\u200F\u200C\u200C\u206D\u206D\u200C\u202E\u206E\u200E\u206F\u206B\u202C\u202C\u202B\u200C\u202E\u200D\u202E(c) <= 2;
						}
						return false;
					}).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0097:
							int num = (AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator) ? 751572119 : 181489345);
							for (;;)
							{
								int num2 = num;
								switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
								{
								case 0:
									num = 751572119;
									continue;
								case 1:
									enumerator.Current.DebugLevel = 0;
									num = -337707266;
									continue;
								case 2:
									goto IL_0097;
								}
								goto Block_20;
							}
						}
						Block_20:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_00B5:
								int num3 = 227855347;
								for (;;)
								{
									int num2 = num3;
									uint num4;
									switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
									{
									case 0U:
										goto IL_00B5;
									case 1U:
										AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator);
										num3 = (int)((num4 * 1621346328U) ^ 2418312157U);
										continue;
									}
									goto Block_23;
								}
							}
							Block_23:;
						}
					}
					enumerator2 = (from e in AyaMisc.GameRunController_Create_Patch.\u206A\u202E\u206A\u206E\u206B\u206A\u202D\u200B\u200F\u202E\u202D\u202B\u200C\u206C\u200E\u202C\u200C\u200D\u200C\u206A\u202B\u202B\u206B\u200E\u202D\u200E\u202D\u202B\u206C\u202C\u200E\u202D\u202A\u206A\u206D\u206F\u200E\u202E\u200C\u202E\u202E()
						where AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u206D\u206B\u200D\u206B\u202E\u200F\u202D\u200D\u202B\u200F\u206C\u206D\u202A\u202A\u206E\u202C\u206D\u206B\u200C\u202A\u202E\u202B\u200B\u202C\u200B\u202D\u206C\u206A\u206D\u206B\u206C\u206E\u202D\u206D\u206D\u200E\u200D\u202C\u202B\u200D\u202E(e), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242))
						select e).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_018F:
							int num5 = ((!AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator2)) ? 473899241 : 1166715495);
							for (;;)
							{
								int num2 = num5;
								switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
								{
								case 0:
									goto IL_018F;
								case 1:
									enumerator2.Current.IsDebug = false;
									num5 = 808639456;
									continue;
								case 2:
									num5 = 1166715495;
									continue;
								}
								goto Block_25;
							}
						}
						Block_25:
						goto IL_03F4;
					}
					finally
					{
						if (enumerator2 != null)
						{
							for (;;)
							{
								IL_01B0:
								int num6 = 338062128;
								for (;;)
								{
									int num2 = num6;
									uint num4;
									switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
									{
									case 1U:
										AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator2);
										num6 = (int)((num4 * 294603608U) ^ 2352853854U);
										continue;
									case 2U:
										goto IL_01B0;
									}
									goto Block_28;
								}
							}
							Block_28:;
						}
					}
				}
				enumerator = AyaMisc.GameRunController_Create_Patch.\u202B\u206C\u202D\u200D\u200D\u200F\u200D\u206B\u206D\u200C\u200F\u206E\u200B\u200C\u202D\u200C\u202C\u200D\u200C\u206A\u202D\u206B\u206D\u202D\u200B\u200F\u206E\u202B\u200C\u202A\u200C\u206B\u206E\u202A\u206D\u202C\u202C\u200F\u200F\u202E().Where(delegate(CardConfig c)
				{
					if (AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u202C\u206A\u202E\u206F\u206A\u200E\u206B\u200F\u206E\u206F\u200F\u202A\u200C\u200D\u200D\u206B\u206A\u206D\u206D\u202C\u202E\u206D\u202D\u202D\u202E\u200F\u206D\u206F\u202B\u200B\u206C\u206C\u206F\u206D\u200C\u200D\u202A\u202E\u206F\u206F\u202E(c), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136)))
					{
						for (;;)
						{
							int num20 = -1569196806;
							switch ((~(-(~num20)) - 955661177) % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_0040;
							}
							break;
						}
						return false;
						IL_0040:
						return AyaMisc.GameRunController_Create_Patch.<>c.\u200D\u202B\u206D\u206B\u206F\u202B\u206D\u200D\u206B\u206B\u202B\u206E\u202C\u200E\u206C\u206F\u202C\u206E\u206A\u206C\u200C\u202D\u206A\u200F\u200C\u200C\u206D\u206D\u200C\u202E\u206E\u200E\u206F\u206B\u202C\u202C\u202B\u200C\u202E\u200D\u202E(c) <= 2;
					}
					return false;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_028A:
						int num7 = (AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator) ? (-285647929) : 1653922704);
						for (;;)
						{
							int num2 = num7;
							switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
							{
							case 1:
								enumerator.Current.DebugLevel = 2;
								num7 = 1589206534;
								continue;
							case 2:
								goto IL_028A;
							case 3:
								num7 = -285647929;
								continue;
							}
							goto Block_30;
						}
					}
					Block_30:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_02A8:
							int num8 = -708044107;
							for (;;)
							{
								int num2 = num8;
								uint num4;
								switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
								{
								case 1U:
									AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator);
									num8 = (int)((num4 * 438320919U) ^ 2582846294U);
									continue;
								case 2U:
									goto IL_02A8;
								}
								goto Block_33;
							}
						}
						Block_33:;
					}
				}
				enumerator2 = (from e in AyaMisc.GameRunController_Create_Patch.\u206A\u202E\u206A\u206E\u206B\u206A\u202D\u200B\u200F\u202E\u202D\u202B\u200C\u206C\u200E\u202C\u200C\u200D\u200C\u206A\u202B\u202B\u206B\u200E\u202D\u200E\u202D\u202B\u206C\u202C\u200E\u202D\u202A\u206A\u206D\u206F\u200E\u202E\u200C\u202E\u202E()
					where AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u206D\u206B\u200D\u206B\u202E\u200F\u202D\u200D\u202B\u200F\u206C\u206D\u202A\u202A\u206E\u202C\u206D\u206B\u200C\u202A\u202E\u202B\u200B\u202C\u200B\u202D\u206C\u206A\u206D\u206B\u206C\u206E\u202D\u206D\u206D\u200E\u200D\u202C\u202B\u200D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358))
					select e).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0382:
						int num9 = (AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator2) ? (-259841849) : 1190804805);
						for (;;)
						{
							int num2 = num9;
							switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
							{
							case 0:
								goto IL_0382;
							case 1:
								enumerator2.Current.IsDebug = true;
								num9 = -1289222416;
								continue;
							case 2:
								num9 = -259841849;
								continue;
							}
							goto Block_35;
						}
					}
					Block_35:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						for (;;)
						{
							IL_03A0:
							int num10 = -472648116;
							for (;;)
							{
								int num2 = num10;
								uint num4;
								switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
								{
								case 0U:
									goto IL_03A0;
								case 2U:
									AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator2);
									num10 = (int)((num4 * 1880634824U) ^ 4181791279U);
									continue;
								}
								goto Block_38;
							}
						}
						Block_38:;
					}
				}
				IL_03F4:
				if (AyaMisc.GameRunController_Create_Patch.\u200B\u202B\u206C\u206C\u202A\u202B\u202B\u200E\u200B\u206D\u200F\u202C\u200E\u202B\u202C\u206D\u202C\u206F\u200C\u200D\u202E\u202A\u206B\u202A\u206C\u206F\u202C\u202D\u206E\u200F\u200F\u200E\u200C\u202C\u206D\u206E\u206D\u206F\u206C\u202C\u202E(parameters) is FlandrePlayerUnitDef.FlandrePlayerUnit)
				{
					enumerator = AyaMisc.GameRunController_Create_Patch.\u202B\u206C\u202D\u200D\u200D\u200F\u200D\u206B\u206D\u200C\u200F\u206E\u200B\u200C\u202D\u200C\u202C\u200D\u200C\u206A\u202D\u206B\u206D\u202D\u200B\u200F\u206E\u202B\u200C\u202A\u200C\u206B\u206E\u202A\u206D\u202C\u202C\u200F\u200F\u202E().Where(delegate(CardConfig c)
					{
						if (AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u202C\u206A\u202E\u206F\u206A\u200E\u206B\u200F\u206E\u206F\u200F\u202A\u200C\u200D\u200D\u206B\u206A\u206D\u206D\u202C\u202E\u206D\u202D\u202D\u202E\u200F\u206D\u206F\u202B\u200B\u206C\u206C\u206F\u206D\u200C\u200D\u202A\u202E\u206F\u206F\u202E(c), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588)))
						{
							for (;;)
							{
								int num21 = 2049994276;
								switch (~num21 * 791129777 % 3)
								{
								case 0:
									continue;
								case 1:
									goto IL_003E;
								}
								break;
							}
							return false;
							IL_003E:
							return AyaMisc.GameRunController_Create_Patch.<>c.\u200D\u202B\u206D\u206B\u206F\u202B\u206D\u200D\u206B\u206B\u202B\u206E\u202C\u200E\u206C\u206F\u202C\u206E\u206A\u206C\u200C\u202D\u206A\u200F\u200C\u200C\u206D\u206D\u200C\u202E\u206E\u200E\u206F\u206B\u202C\u202C\u202B\u200C\u202E\u200D\u202E(c) <= 2;
						}
						return false;
					}).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_048B:
							int num11 = (AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator) ? 667579235 : (-1808207078));
							for (;;)
							{
								int num2 = num11;
								switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
								{
								case 0:
									num11 = 667579235;
									continue;
								case 1:
									enumerator.Current.DebugLevel = 0;
									num11 = -666513603;
									continue;
								case 3:
									goto IL_048B;
								}
								goto Block_40;
							}
						}
						Block_40:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_04A9:
								int num12 = -1223205981;
								for (;;)
								{
									int num2 = num12;
									uint num4;
									switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
									{
									case 0U:
										goto IL_04A9;
									case 2U:
										AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator);
										num12 = (int)((num4 * 2746225965U) ^ 2455157177U);
										continue;
									}
									goto Block_43;
								}
							}
							Block_43:;
						}
					}
					enumerator2 = (from e in AyaMisc.GameRunController_Create_Patch.\u206A\u202E\u206A\u206E\u206B\u206A\u202D\u200B\u200F\u202E\u202D\u202B\u200C\u206C\u200E\u202C\u200C\u200D\u200C\u206A\u202B\u202B\u206B\u200E\u202D\u200E\u202D\u202B\u206C\u202C\u200E\u202D\u202A\u206A\u206D\u206F\u200E\u202E\u200C\u202E\u202E()
						where AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u206D\u206B\u200D\u206B\u202E\u200F\u202D\u200D\u202B\u200F\u206C\u206D\u202A\u202A\u206E\u202C\u206D\u206B\u200C\u202A\u202E\u202B\u200B\u202C\u200B\u202D\u206C\u206A\u206D\u206B\u206C\u206E\u202D\u206D\u206D\u200E\u200D\u202C\u202B\u200D\u202E(e), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810))
						select e).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0583:
							int num13 = ((!AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator2)) ? 1153201295 : (-2020590598));
							for (;;)
							{
								int num2 = num13;
								switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
								{
								case 0:
									num13 = -2020590598;
									continue;
								case 2:
									enumerator2.Current.IsDebug = false;
									num13 = -15183159;
									continue;
								case 3:
									goto IL_0583;
								}
								goto Block_45;
							}
						}
						Block_45:
						return;
					}
					finally
					{
						if (enumerator2 != null)
						{
							for (;;)
							{
								IL_05A4:
								int num14 = 1088852817;
								for (;;)
								{
									int num2 = num14;
									uint num4;
									switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
									{
									case 0U:
										goto IL_05A4;
									case 1U:
										AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator2);
										num14 = (int)((num4 * 1653002604U) ^ 3315316943U);
										continue;
									}
									goto Block_48;
								}
							}
							Block_48:;
						}
					}
				}
				enumerator = AyaMisc.GameRunController_Create_Patch.\u202B\u206C\u202D\u200D\u200D\u200F\u200D\u206B\u206D\u200C\u200F\u206E\u200B\u200C\u202D\u200C\u202C\u200D\u200C\u206A\u202D\u206B\u206D\u202D\u200B\u200F\u206E\u202B\u200C\u202A\u200C\u206B\u206E\u202A\u206D\u202C\u202C\u200F\u200F\u202E().Where(delegate(CardConfig c)
				{
					if (AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u202C\u206A\u202E\u206F\u206A\u200E\u206B\u200F\u206E\u206F\u200F\u202A\u200C\u200D\u200D\u206B\u206A\u206D\u206D\u202C\u202E\u206D\u202D\u202D\u202E\u200F\u206D\u206F\u202B\u200B\u206C\u206C\u206F\u206D\u200C\u200D\u202A\u202E\u206F\u206F\u202E(c), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961)))
					{
						for (;;)
						{
							int num22 = -2005505336;
							switch (-(-num22 ^ -31764797) * 52440137 % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_0045;
							}
							break;
						}
						return false;
						IL_0045:
						return AyaMisc.GameRunController_Create_Patch.<>c.\u200D\u202B\u206D\u206B\u206F\u202B\u206D\u200D\u206B\u206B\u202B\u206E\u202C\u200E\u206C\u206F\u202C\u206E\u206A\u206C\u200C\u202D\u206A\u200F\u200C\u200C\u206D\u206D\u200C\u202E\u206E\u200E\u206F\u206B\u202C\u202C\u202B\u200C\u202E\u200D\u202E(c) <= 2;
					}
					return false;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_067E:
						int num15 = ((!AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator)) ? (-2021738097) : 473363221);
						for (;;)
						{
							int num2 = num15;
							switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
							{
							case 0:
								goto IL_067E;
							case 2:
								num15 = 473363221;
								continue;
							case 3:
								enumerator.Current.DebugLevel = 2;
								num15 = -931184952;
								continue;
							}
							goto Block_50;
						}
					}
					Block_50:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_069C:
							int num16 = -415120937;
							for (;;)
							{
								int num2 = num16;
								uint num4;
								switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
								{
								case 1U:
									AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator);
									num16 = (int)((num4 * 2854009046U) ^ 1397913354U);
									continue;
								case 2U:
									goto IL_069C;
								}
								goto Block_53;
							}
						}
						Block_53:;
					}
				}
				enumerator2 = (from e in AyaMisc.GameRunController_Create_Patch.\u206A\u202E\u206A\u206E\u206B\u206A\u202D\u200B\u200F\u202E\u202D\u202B\u200C\u206C\u200E\u202C\u200C\u200D\u200C\u206A\u202B\u202B\u206B\u200E\u202D\u200E\u202D\u202B\u206C\u202C\u200E\u202D\u202A\u206A\u206D\u206F\u200E\u202E\u200C\u202E\u202E()
					where AyaMisc.GameRunController_Create_Patch.<>c.\u202A\u202C\u200C\u200B\u202E\u206B\u202B\u200F\u206C\u202D\u206A\u202D\u200D\u206E\u206A\u200B\u206A\u200C\u206F\u206C\u206D\u202B\u206C\u202A\u200F\u202C\u206B\u202D\u200D\u200C\u202C\u202D\u206B\u200D\u202B\u202A\u202D\u202B\u202B\u206A\u202E(AyaMisc.GameRunController_Create_Patch.<>c.\u206D\u206B\u200D\u206B\u202E\u200F\u202D\u200D\u202B\u200F\u206C\u206D\u202A\u202A\u206E\u202C\u206D\u206B\u200C\u202A\u202E\u202B\u200B\u202C\u200B\u202D\u206C\u206A\u206D\u206B\u206C\u206E\u202D\u206D\u206D\u200E\u200D\u202C\u202B\u200D\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317))
					select e).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0776:
						int num17 = (AyaMisc.GameRunController_Create_Patch.\u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(enumerator2) ? 1761594902 : (-2079482589));
						for (;;)
						{
							int num2 = num17;
							switch (((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420) % 4)
							{
							case 0:
								num17 = 1761594902;
								continue;
							case 2:
								enumerator2.Current.IsDebug = true;
								num17 = -1985812219;
								continue;
							case 3:
								goto IL_0776;
							}
							goto Block_55;
						}
					}
					Block_55:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						for (;;)
						{
							IL_0794:
							int num18 = -1746567998;
							for (;;)
							{
								int num2 = num18;
								uint num4;
								switch ((num4 = (uint)((num2 ^ -(--759287078)) * 987254799 + (77435332 - 316356338) - -585707420)) % 3U)
								{
								case 1U:
									AyaMisc.GameRunController_Create_Patch.\u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(enumerator2);
									num18 = (int)((num4 * 1315194096U) ^ 1464943235U);
									continue;
								case 2U:
									goto IL_0794;
								}
								goto Block_58;
							}
						}
						Block_58:;
					}
				}
			}

			static PlayerUnit \u200B\u202B\u206C\u206C\u202A\u202B\u202B\u200E\u200B\u206D\u200F\u202C\u200E\u202B\u202C\u206D\u202C\u206F\u200C\u200D\u202E\u202A\u206B\u202A\u206C\u206F\u202C\u202D\u206E\u200F\u200F\u200E\u200C\u202C\u206D\u206E\u206D\u206F\u206C\u202C\u202E(GameRunStartupParameters A_0)
			{
				return A_0.Player;
			}

			static IReadOnlyList<CardConfig> \u202B\u206C\u202D\u200D\u200D\u200F\u200D\u206B\u206D\u200C\u200F\u206E\u200B\u200C\u202D\u200C\u202C\u200D\u200C\u206A\u202D\u206B\u206D\u202D\u200B\u200F\u206E\u202B\u200C\u202A\u200C\u206B\u206E\u202A\u206D\u202C\u202C\u200F\u200F\u202E()
			{
				return CardConfig.AllConfig();
			}

			static bool \u200E\u200B\u202B\u202A\u206E\u200E\u200B\u200E\u206F\u202C\u200B\u206D\u200D\u200B\u200D\u200E\u200F\u200E\u206D\u202B\u200D\u206F\u200C\u206B\u202D\u200F\u200C\u206C\u202E\u206F\u206B\u202D\u200E\u200F\u206F\u200B\u200F\u202D\u206F\u206B\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206B\u206A\u200B\u206D\u206C\u206E\u202C\u206D\u200C\u202E\u206F\u206B\u206C\u200D\u200B\u202B\u202A\u202B\u200C\u202D\u206D\u206B\u206D\u206B\u200D\u206D\u200E\u206F\u206D\u206D\u202C\u200B\u206A\u206C\u200E\u206E\u202A\u200D\u206E\u206D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static IReadOnlyList<ExhibitConfig> \u206A\u202E\u206A\u206E\u206B\u206A\u202D\u200B\u200F\u202E\u202D\u202B\u200C\u206C\u200E\u202C\u200C\u200D\u200C\u206A\u202B\u202B\u206B\u200E\u202D\u200E\u202D\u202B\u206C\u202C\u200E\u202D\u202A\u206A\u206D\u206F\u200E\u202E\u200C\u202E\u202E()
			{
				return ExhibitConfig.AllConfig();
			}
		}

		[HarmonyPatch(typeof(UiManager), "EnterGameRun")]
		private class UiManager_EnterGameRun_Patch
		{
			private static void Postfix(UiManager __instance)
			{
				GameRunController gameRunController = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202C\u202A\u202C\u200B\u206C\u200F\u200C\u206E\u206B\u202D\u202A\u200F\u206B\u200C\u206E\u206D\u202B\u206B\u206B\u206B\u202B\u202D\u206A\u206F\u206B\u206C\u202E\u206B\u200B\u202E\u206B\u206B\u206C\u206F\u202E\u202B\u206F\u206C\u202B\u202E(Singleton<GameMaster>.Instance);
				IEnumerator<CardConfig> enumerator;
				IEnumerator<ExhibitConfig> enumerator2;
				if (((gameRunController != null) ? AyaMisc.UiManager_EnterGameRun_Patch.\u200B\u202E\u200D\u202A\u206D\u202C\u206D\u206F\u206A\u200E\u206C\u200D\u200F\u200C\u202B\u200E\u202A\u200B\u202C\u206F\u200C\u200B\u202A\u200B\u202D\u206E\u202D\u202C\u200C\u202B\u206B\u206F\u202C\u202B\u200B\u200C\u202C\u202A\u206C\u206B\u202E(gameRunController) : null) is AyaPlayerUnitDef.AyaPlayerUnit)
				{
					enumerator = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202E\u200F\u202B\u200C\u202A\u206B\u200B\u200C\u206C\u202E\u202C\u202B\u202B\u202A\u202A\u202C\u202E\u202B\u200D\u206E\u200F\u206E\u200B\u200F\u206E\u206A\u206E\u206F\u200F\u206F\u206A\u202B\u202A\u206C\u202A\u202B\u200D\u206C\u206C\u202E().Where(delegate(CardConfig c)
					{
						if (AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202D\u200E\u202D\u200C\u206A\u206D\u200D\u202B\u206B\u202E\u206C\u202B\u200C\u206E\u202B\u206A\u206D\u206D\u206B\u206E\u200C\u200B\u206C\u200F\u200F\u206D\u206F\u206E\u202E\u202B\u206A\u200B\u202D\u206A\u200F\u200E\u200B\u206E\u206D\u206D\u202E(c), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242)))
						{
							for (;;)
							{
								int num19 = 1409869160;
								switch (-(~(num19 ^ (-1261275645 * 556905680)) * -760527875) % 3)
								{
								case 0:
									continue;
								case 2:
									goto IL_004B;
								}
								break;
							}
							return false;
							IL_004B:
							return AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u200C\u206C\u200C\u200C\u200D\u202B\u200E\u202D\u206A\u206E\u206D\u202D\u200C\u200B\u200F\u200F\u206F\u200B\u206A\u202E\u206B\u206D\u206D\u200E\u206E\u206F\u200B\u202E\u206C\u202C\u206E\u200F\u206E\u202E\u206C\u206E\u206B\u206D\u200B\u206A\u202E(c) <= 2;
						}
						return false;
					}).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_00A2:
							int num = ((!AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator)) ? (-130962025) : (-777945431));
							for (;;)
							{
								int num2 = num;
								switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
								{
								case 1:
									goto IL_00A2;
								case 2:
									enumerator.Current.DebugLevel = 0;
									num = -977610534;
									continue;
								case 3:
									num = -777945431;
									continue;
								}
								goto Block_22;
							}
						}
						Block_22:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_00C0:
								int num3 = 601497732;
								for (;;)
								{
									int num2 = num3;
									uint num4;
									switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
									{
									case 0U:
										goto IL_00C0;
									case 2U:
										AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator);
										num3 = (int)((num4 * 3347419133U) ^ 1255570331U);
										continue;
									}
									goto Block_25;
								}
							}
							Block_25:;
						}
					}
					enumerator2 = (from e in AyaMisc.UiManager_EnterGameRun_Patch.\u206D\u200E\u202D\u200F\u202A\u206E\u206F\u200B\u202E\u206F\u202D\u206A\u202C\u200E\u200C\u206F\u202E\u200F\u206D\u200D\u200E\u206F\u206F\u202C\u206B\u202B\u206C\u202B\u206E\u206A\u200F\u206B\u202B\u200E\u202C\u200E\u200B\u200D\u200E\u202B\u202E()
						where AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u200C\u200F\u206B\u202B\u202E\u206C\u202D\u202C\u202E\u200B\u206D\u200E\u202C\u202B\u202D\u200C\u200E\u200B\u200F\u200E\u202D\u206C\u200E\u206F\u206D\u200C\u202A\u200F\u200B\u202B\u200F\u206C\u206A\u200E\u206D\u202C\u202D\u206F\u206F\u202E(e), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103))
						select e).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0192:
							int num5 = ((!AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator2)) ? (-1315702811) : (-1923770822));
							for (;;)
							{
								int num2 = num5;
								switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
								{
								case 0:
									num5 = -1923770822;
									continue;
								case 1:
									enumerator2.Current.IsDebug = false;
									num5 = -1498191056;
									continue;
								case 3:
									goto IL_0192;
								}
								goto Block_27;
							}
						}
						Block_27:
						goto IL_03E3;
					}
					finally
					{
						if (enumerator2 != null)
						{
							for (;;)
							{
								IL_01B3:
								int num6 = -886830334;
								for (;;)
								{
									int num2 = num6;
									uint num4;
									switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
									{
									case 0U:
										goto IL_01B3;
									case 2U:
										AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator2);
										num6 = (int)((num4 * 4137138631U) ^ 1384642258U);
										continue;
									}
									goto Block_30;
								}
							}
							Block_30:;
						}
					}
				}
				enumerator = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202E\u200F\u202B\u200C\u202A\u206B\u200B\u200C\u206C\u202E\u202C\u202B\u202B\u202A\u202A\u202C\u202E\u202B\u200D\u206E\u200F\u206E\u200B\u200F\u206E\u206A\u206E\u206F\u200F\u206F\u206A\u202B\u202A\u206C\u202A\u202B\u200D\u206C\u206C\u202E().Where(delegate(CardConfig c)
				{
					if (AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202D\u200E\u202D\u200C\u206A\u206D\u200D\u202B\u206B\u202E\u206C\u202B\u200C\u206E\u202B\u206A\u206D\u206D\u206B\u206E\u200C\u200B\u206C\u200F\u200F\u206D\u206F\u206E\u202E\u202B\u206A\u200B\u202D\u206A\u200F\u200E\u200B\u206E\u206D\u206D\u202E(c), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103)))
					{
						for (;;)
						{
							int num20 = -1590494289;
							switch (-(-num20 * 2060791839 * 1939764729) % 3)
							{
							case 1:
								goto IL_0045;
							case 2:
								continue;
							}
							break;
						}
						return false;
						IL_0045:
						return AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u200C\u206C\u200C\u200C\u200D\u202B\u200E\u202D\u206A\u206E\u206D\u202D\u200C\u200B\u200F\u200F\u206F\u200B\u206A\u202E\u206B\u206D\u206D\u200E\u206E\u206F\u200B\u202E\u206C\u202C\u206E\u200F\u206E\u202E\u206C\u206E\u206B\u206D\u200B\u206A\u202E(c) <= 2;
					}
					return false;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0285:
						int num7 = (AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator) ? 1042342349 : (-1555547773));
						for (;;)
						{
							int num2 = num7;
							switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
							{
							case 1:
								goto IL_0285;
							case 2:
								enumerator.Current.DebugLevel = 2;
								num7 = -818622302;
								continue;
							case 3:
								num7 = 1042342349;
								continue;
							}
							goto Block_32;
						}
					}
					Block_32:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_02A3:
							int num8 = 1967241206;
							for (;;)
							{
								int num2 = num8;
								uint num4;
								switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
								{
								case 0U:
									goto IL_02A3;
								case 1U:
									AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator);
									num8 = (int)((num4 * 3539429396U) ^ 2970901521U);
									continue;
								}
								goto Block_35;
							}
						}
						Block_35:;
					}
				}
				enumerator2 = (from e in AyaMisc.UiManager_EnterGameRun_Patch.\u206D\u200E\u202D\u200F\u202A\u206E\u206F\u200B\u202E\u206F\u202D\u206A\u202C\u200E\u200C\u206F\u202E\u200F\u206D\u200D\u200E\u206F\u206F\u202C\u206B\u202B\u206C\u202B\u206E\u206A\u200F\u206B\u202B\u200E\u202C\u200E\u200B\u200D\u200E\u202B\u202E()
					where AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u200C\u200F\u206B\u202B\u202E\u206C\u202D\u202C\u202E\u200B\u206D\u200E\u202C\u202B\u202D\u200C\u200E\u200B\u200F\u200E\u202D\u206C\u200E\u206F\u206D\u200C\u202A\u200F\u200B\u202B\u200F\u206C\u206A\u200E\u206D\u202C\u202D\u206F\u206F\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136))
					select e).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0375:
						int num9 = (AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator2) ? 175752688 : 790556122);
						for (;;)
						{
							int num2 = num9;
							switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
							{
							case 0:
								goto IL_0375;
							case 2:
								num9 = 175752688;
								continue;
							case 3:
								enumerator2.Current.IsDebug = true;
								num9 = -922249145;
								continue;
							}
							goto Block_37;
						}
					}
					Block_37:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						for (;;)
						{
							IL_0393:
							int num10 = -1506116297;
							for (;;)
							{
								int num2 = num10;
								uint num4;
								switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
								{
								case 0U:
									goto IL_0393;
								case 2U:
									AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator2);
									num10 = (int)((num4 * 4021585541U) ^ 2662931279U);
									continue;
								}
								goto Block_40;
							}
						}
						Block_40:;
					}
				}
				IL_03E3:
				GameRunController gameRunController2 = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202C\u202A\u202C\u200B\u206C\u200F\u200C\u206E\u206B\u202D\u202A\u200F\u206B\u200C\u206E\u206D\u202B\u206B\u206B\u206B\u202B\u202D\u206A\u206F\u206B\u206C\u202E\u206B\u200B\u202E\u206B\u206B\u206C\u206F\u202E\u202B\u206F\u206C\u202B\u202E(Singleton<GameMaster>.Instance);
				if (((gameRunController2 != null) ? AyaMisc.UiManager_EnterGameRun_Patch.\u200B\u202E\u200D\u202A\u206D\u202C\u206D\u206F\u206A\u200E\u206C\u200D\u200F\u200C\u202B\u200E\u202A\u200B\u202C\u206F\u200C\u200B\u202A\u200B\u202D\u206E\u202D\u202C\u200C\u202B\u206B\u206F\u202C\u202B\u200B\u200C\u202C\u202A\u206C\u206B\u202E(gameRunController2) : null) is FlandrePlayerUnitDef.FlandrePlayerUnit)
				{
					enumerator = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202E\u200F\u202B\u200C\u202A\u206B\u200B\u200C\u206C\u202E\u202C\u202B\u202B\u202A\u202A\u202C\u202E\u202B\u200D\u206E\u200F\u206E\u200B\u200F\u206E\u206A\u206E\u206F\u200F\u206F\u206A\u202B\u202A\u206C\u202A\u202B\u200D\u206C\u206C\u202E().Where(delegate(CardConfig c)
					{
						if (AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202D\u200E\u202D\u200C\u206A\u206D\u200D\u202B\u206B\u202E\u206C\u202B\u200C\u206E\u202B\u206A\u206D\u206D\u206B\u206E\u200C\u200B\u206C\u200F\u200F\u206D\u206F\u206E\u202E\u202B\u206A\u200B\u202D\u206A\u200F\u200E\u200B\u206E\u206D\u206D\u202E(c), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588)))
						{
							for (;;)
							{
								int num21 = 545949176;
								switch (~(num21 * 139193461 + (-308591562 - ~2030064840)) * 1282664369 % 3)
								{
								case 1:
									goto IL_0052;
								case 2:
									continue;
								}
								break;
							}
							return false;
							IL_0052:
							return AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u200C\u206C\u200C\u200C\u200D\u202B\u200E\u202D\u206A\u206E\u206D\u202D\u200C\u200B\u200F\u200F\u206F\u200B\u206A\u202E\u206B\u206D\u206D\u200E\u206E\u206F\u200B\u202E\u206C\u202C\u206E\u200F\u206E\u202E\u206C\u206E\u206B\u206D\u200B\u206A\u202E(c) <= 2;
						}
						return false;
					}).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0485:
							int num11 = ((!AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator)) ? (-1713776539) : (-1411093750));
							for (;;)
							{
								int num2 = num11;
								switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
								{
								case 0:
									num11 = -1411093750;
									continue;
								case 1:
									enumerator.Current.DebugLevel = 0;
									num11 = 745654868;
									continue;
								case 3:
									goto IL_0485;
								}
								goto Block_42;
							}
						}
						Block_42:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_04A3:
								int num12 = 2120907856;
								for (;;)
								{
									int num2 = num12;
									uint num4;
									switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
									{
									case 0U:
										goto IL_04A3;
									case 1U:
										AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator);
										num12 = (int)((num4 * 1062854949U) ^ 2396021536U);
										continue;
									}
									goto Block_45;
								}
							}
							Block_45:;
						}
					}
					enumerator2 = (from e in AyaMisc.UiManager_EnterGameRun_Patch.\u206D\u200E\u202D\u200F\u202A\u206E\u206F\u200B\u202E\u206F\u202D\u206A\u202C\u200E\u200C\u206F\u202E\u200F\u206D\u200D\u200E\u206F\u206F\u202C\u206B\u202B\u206C\u202B\u206E\u206A\u200F\u206B\u202B\u200E\u202C\u200E\u200B\u200D\u200E\u202B\u202E()
						where AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u200C\u200F\u206B\u202B\u202E\u206C\u202D\u202C\u202E\u200B\u206D\u200E\u202C\u202B\u202D\u200C\u200E\u200B\u200F\u200E\u202D\u206C\u200E\u206F\u206D\u200C\u202A\u200F\u200B\u202B\u200F\u206C\u206A\u200E\u206D\u202C\u202D\u206F\u206F\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317))
						select e).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0575:
							int num13 = (AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator2) ? 552059218 : 1061556747);
							for (;;)
							{
								int num2 = num13;
								switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
								{
								case 1:
									enumerator2.Current.IsDebug = false;
									num13 = 1470930756;
									continue;
								case 2:
									num13 = 552059218;
									continue;
								case 3:
									goto IL_0575;
								}
								goto Block_47;
							}
						}
						Block_47:
						return;
					}
					finally
					{
						if (enumerator2 != null)
						{
							for (;;)
							{
								IL_0596:
								int num14 = 237354983;
								for (;;)
								{
									int num2 = num14;
									uint num4;
									switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
									{
									case 0U:
										goto IL_0596;
									case 1U:
										AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator2);
										num14 = (int)((num4 * 3149095874U) ^ 3136697379U);
										continue;
									}
									goto Block_50;
								}
							}
							Block_50:;
						}
					}
				}
				enumerator = AyaMisc.UiManager_EnterGameRun_Patch.\u206A\u202E\u200F\u202B\u200C\u202A\u206B\u200B\u200C\u206C\u202E\u202C\u202B\u202B\u202A\u202A\u202C\u202E\u202B\u200D\u206E\u200F\u206E\u200B\u200F\u206E\u206A\u206E\u206F\u200F\u206F\u206A\u202B\u202A\u206C\u202A\u202B\u200D\u206C\u206C\u202E().Where(delegate(CardConfig c)
				{
					if (AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202D\u200E\u202D\u200C\u206A\u206D\u200D\u202B\u206B\u202E\u206C\u202B\u200C\u206E\u202B\u206A\u206D\u206D\u206B\u206E\u200C\u200B\u206C\u200F\u200F\u206D\u206F\u206E\u202E\u202B\u206A\u200B\u202D\u206A\u200F\u200E\u200B\u206E\u206D\u206D\u202E(c), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317)))
					{
						for (;;)
						{
							int num22 = 1972449791;
							switch ((~(num22 ^ (~(~-1618955196) ^ ~(~-1883784242)) ^ (~-1087502120 * 222459695)) - 1159544036) % 3)
							{
							case 0:
								continue;
							case 1:
								goto IL_005B;
							}
							break;
						}
						return false;
						IL_005B:
						return AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u200C\u206C\u200C\u200C\u200D\u202B\u200E\u202D\u206A\u206E\u206D\u202D\u200C\u200B\u200F\u200F\u206F\u200B\u206A\u202E\u206B\u206D\u206D\u200E\u206E\u206F\u200B\u202E\u206C\u202C\u206E\u200F\u206E\u202E\u206C\u206E\u206B\u206D\u200B\u206A\u202E(c) <= 2;
					}
					return false;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0668:
						int num15 = ((!AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator)) ? 1746916710 : 121059461);
						for (;;)
						{
							int num2 = num15;
							switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
							{
							case 0:
								num15 = 121059461;
								continue;
							case 2:
								enumerator.Current.DebugLevel = 2;
								num15 = -1641002192;
								continue;
							case 3:
								goto IL_0668;
							}
							goto Block_52;
						}
					}
					Block_52:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_0686:
							int num16 = -463260130;
							for (;;)
							{
								int num2 = num16;
								uint num4;
								switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
								{
								case 0U:
									goto IL_0686;
								case 1U:
									AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator);
									num16 = (int)((num4 * 1387175982U) ^ 1402075528U);
									continue;
								}
								goto Block_55;
							}
						}
						Block_55:;
					}
				}
				enumerator2 = (from e in AyaMisc.UiManager_EnterGameRun_Patch.\u206D\u200E\u202D\u200F\u202A\u206E\u206F\u200B\u202E\u206F\u202D\u206A\u202C\u200E\u200C\u206F\u202E\u200F\u206D\u200D\u200E\u206F\u206F\u202C\u206B\u202B\u206C\u202B\u206E\u206A\u200F\u206B\u202B\u200E\u202C\u200E\u200B\u200D\u200E\u202B\u202E()
					where AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u202A\u206B\u202A\u202B\u202A\u206A\u202D\u206C\u206C\u206C\u202B\u206B\u200C\u206C\u202C\u202A\u206C\u206C\u206C\u202B\u200D\u202D\u206A\u202E\u202B\u200F\u200C\u206B\u202B\u200C\u206E\u206F\u202A\u200D\u206A\u202A\u206C\u206E\u200D\u202E(AyaMisc.UiManager_EnterGameRun_Patch.<>c.\u202E\u200C\u200F\u206B\u202B\u202E\u206C\u202D\u202C\u202E\u200B\u206D\u200E\u202C\u202B\u202D\u200C\u200E\u200B\u200F\u200E\u202D\u206C\u200E\u206F\u206D\u200C\u202A\u200F\u200B\u202B\u200F\u206C\u206A\u200E\u206D\u202C\u202D\u206F\u206F\u202E(e), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588))
					select e).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0758:
						int num17 = (AyaMisc.UiManager_EnterGameRun_Patch.\u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(enumerator2) ? 222462544 : (-1003041470));
						for (;;)
						{
							int num2 = num17;
							switch (~(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309) % 4)
							{
							case 0:
								num17 = 222462544;
								continue;
							case 2:
								goto IL_0758;
							case 3:
								enumerator2.Current.IsDebug = true;
								num17 = -1285165003;
								continue;
							}
							goto Block_57;
						}
					}
					Block_57:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						for (;;)
						{
							IL_0776:
							int num18 = 698299725;
							for (;;)
							{
								int num2 = num18;
								uint num4;
								switch ((num4 = (uint)(~(uint)(-(num2 + ~((-415390617 * 521614161) ^ --1777663152)) * -29935309))) % 3U)
								{
								case 1U:
									AyaMisc.UiManager_EnterGameRun_Patch.\u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(enumerator2);
									num18 = (int)((num4 * 1735343666U) ^ 832342977U);
									continue;
								case 2U:
									goto IL_0776;
								}
								goto Block_60;
							}
						}
						Block_60:;
					}
				}
			}

			static GameRunController \u206A\u202C\u202A\u202C\u200B\u206C\u200F\u200C\u206E\u206B\u202D\u202A\u200F\u206B\u200C\u206E\u206D\u202B\u206B\u206B\u206B\u202B\u202D\u206A\u206F\u206B\u206C\u202E\u206B\u200B\u202E\u206B\u206B\u206C\u206F\u202E\u202B\u206F\u206C\u202B\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}

			static PlayerUnit \u200B\u202E\u200D\u202A\u206D\u202C\u206D\u206F\u206A\u200E\u206C\u200D\u200F\u200C\u202B\u200E\u202A\u200B\u202C\u206F\u200C\u200B\u202A\u200B\u202D\u206E\u202D\u202C\u200C\u202B\u206B\u206F\u202C\u202B\u200B\u200C\u202C\u202A\u206C\u206B\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static IReadOnlyList<CardConfig> \u206A\u202E\u200F\u202B\u200C\u202A\u206B\u200B\u200C\u206C\u202E\u202C\u202B\u202B\u202A\u202A\u202C\u202E\u202B\u200D\u206E\u200F\u206E\u200B\u200F\u206E\u206A\u206E\u206F\u200F\u206F\u206A\u202B\u202A\u206C\u202A\u202B\u200D\u206C\u206C\u202E()
			{
				return CardConfig.AllConfig();
			}

			static bool \u206C\u206A\u202E\u206F\u202C\u202A\u206B\u202E\u200F\u206E\u206E\u206E\u202C\u200D\u206B\u202B\u200E\u202C\u206F\u200B\u202C\u206D\u202A\u200D\u200B\u202D\u206F\u200D\u206D\u202B\u206F\u202D\u202E\u202C\u200B\u206B\u202E\u200B\u206C\u200C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200E\u200F\u202A\u202C\u206D\u202B\u200B\u200E\u200D\u206B\u202E\u206F\u206D\u206C\u206F\u200F\u202C\u200D\u200D\u206A\u202B\u206D\u202E\u202D\u200F\u206A\u202D\u202B\u202C\u200E\u200D\u202B\u200F\u202C\u200B\u206F\u200E\u206B\u202A\u202D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static IReadOnlyList<ExhibitConfig> \u206D\u200E\u202D\u200F\u202A\u206E\u206F\u200B\u202E\u206F\u202D\u206A\u202C\u200E\u200C\u206F\u202E\u200F\u206D\u200D\u200E\u206F\u206F\u202C\u206B\u202B\u206C\u202B\u206E\u206A\u200F\u206B\u202B\u200E\u202C\u200E\u200B\u200D\u200E\u202B\u202E()
			{
				return ExhibitConfig.AllConfig();
			}
		}

		[HarmonyPatch(typeof(GameDirector), "ClearAll")]
		private class GameDirector_ClearAll_Patch
		{
			private static void Postfix(UiManager __instance)
			{
				IEnumerator<CardConfig> enumerator = AyaMisc.GameDirector_ClearAll_Patch.\u200B\u202C\u202A\u202D\u202C\u202A\u200C\u206B\u202C\u206B\u206E\u200F\u202C\u206C\u202B\u200F\u202A\u200C\u206B\u206A\u200C\u202A\u200E\u206A\u200D\u200B\u200F\u206F\u200C\u206F\u202D\u200C\u206F\u202A\u202A\u200E\u200F\u202B\u206C\u206A\u202E().Where(delegate(CardConfig c)
				{
					if (!AyaMisc.GameDirector_ClearAll_Patch.<>c.\u200D\u200F\u206D\u202B\u200F\u200F\u202C\u202B\u206C\u200B\u200F\u202D\u202C\u200E\u206A\u202D\u200D\u200E\u206A\u206C\u206E\u200E\u206E\u206F\u200F\u202C\u200E\u202D\u202C\u202B\u206A\u206E\u200F\u206B\u206C\u202E\u202E\u206F\u200B\u200F\u202E(AyaMisc.GameDirector_ClearAll_Patch.<>c.\u206B\u202D\u200C\u206B\u206B\u202C\u200D\u200D\u202B\u200C\u200D\u206E\u206C\u202A\u202B\u200C\u206B\u202B\u200C\u206B\u200C\u202E\u206B\u206B\u202A\u200E\u200D\u200E\u206A\u206D\u202B\u206D\u206D\u202A\u200E\u206F\u200F\u202B\u206C\u206F\u202E(c), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103)))
					{
						for (;;)
						{
							IL_0019:
							int num7 = -1266362395;
							for (;;)
							{
								int num8 = num7;
								uint num9;
								switch ((num9 = (uint)(-num8 ^ -(301059418 + -1831885494))) % 4U)
								{
								case 0U:
									goto IL_0019;
								case 1U:
									goto IL_007B;
								case 3U:
									num7 = (int)((AyaMisc.GameDirector_ClearAll_Patch.<>c.\u200D\u200F\u206D\u202B\u200F\u200F\u202C\u202B\u206C\u200B\u200F\u202D\u202C\u200E\u206A\u202D\u200D\u200E\u206A\u206C\u206E\u200E\u206E\u206F\u200F\u202C\u200E\u202D\u202C\u202B\u206A\u206E\u200F\u206B\u206C\u202E\u202E\u206F\u200B\u200F\u202E(AyaMisc.GameDirector_ClearAll_Patch.<>c.\u206B\u202D\u200C\u206B\u206B\u202C\u200D\u200D\u202B\u200C\u200D\u206E\u206C\u202A\u202B\u200C\u206B\u202B\u200C\u206B\u200C\u202E\u206B\u206B\u202A\u200E\u200D\u200E\u206A\u206D\u202B\u206D\u206D\u202A\u200E\u206F\u200F\u202B\u206C\u206F\u202E(c), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733)) ? 2568708979U : 3360675666U) ^ (num9 * 1424640872U));
									continue;
								}
								return false;
							}
						}
						return false;
					}
					IL_007B:
					return AyaMisc.GameDirector_ClearAll_Patch.<>c.\u200B\u206A\u202E\u206D\u206C\u202B\u202A\u206B\u206A\u200B\u206D\u202C\u200C\u202C\u202E\u206F\u200E\u206E\u206F\u202A\u206C\u200D\u206E\u206F\u200B\u206A\u206C\u200D\u200E\u202C\u206F\u202E\u202A\u200B\u202A\u200C\u202B\u202C\u202A\u206D\u202E(c) <= 2;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0099:
						int num = ((!AyaMisc.GameDirector_ClearAll_Patch.\u200B\u202B\u200F\u206A\u202A\u206E\u202D\u200F\u202A\u202E\u206B\u202C\u202C\u200C\u202C\u202E\u202E\u202D\u206A\u202C\u200D\u200F\u202D\u200E\u200B\u202E\u202A\u206D\u206C\u200E\u206C\u200E\u206D\u202E\u200E\u202A\u206F\u202C\u200B\u202C\u202E(enumerator)) ? (-494903503) : (-1780857290));
						for (;;)
						{
							int num2 = num;
							switch (~((num2 ^ ((45553599 - 1129513100) * -715104755 - ~1068914867)) - -(-477263744 + 492725572) - 1705297963 * 1401057217) % 4)
							{
							case 1:
								enumerator.Current.DebugLevel = 0;
								num = 1467150947;
								continue;
							case 2:
								goto IL_0099;
							case 3:
								num = -1780857290;
								continue;
							}
							goto Block_6;
						}
					}
					Block_6:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_00B7:
							int num3 = 1214839222;
							for (;;)
							{
								int num2 = num3;
								uint num4;
								switch ((num4 = (uint)(~(uint)((num2 ^ ((45553599 - 1129513100) * -715104755 - ~1068914867)) - -(-477263744 + 492725572) - 1705297963 * 1401057217))) % 3U)
								{
								case 0U:
									goto IL_00B7;
								case 2U:
									AyaMisc.GameDirector_ClearAll_Patch.\u206E\u206B\u206B\u202D\u202C\u202A\u206B\u202D\u206A\u200C\u206F\u200F\u206F\u206A\u202A\u206B\u200D\u206A\u206E\u200B\u206A\u200D\u206B\u206D\u206F\u202D\u206D\u202B\u200E\u202E\u206B\u206C\u202E\u200D\u206A\u200D\u206B\u206F\u200E\u206E\u202E(enumerator);
									num3 = (int)((num4 * 2673002390U) ^ 2138146599U);
									continue;
								}
								goto Block_9;
							}
						}
						Block_9:;
					}
				}
				IEnumerator<ExhibitConfig> enumerator2 = AyaMisc.GameDirector_ClearAll_Patch.\u206E\u202A\u206E\u200E\u200C\u200C\u206F\u202E\u202A\u206E\u202A\u206C\u200F\u206E\u202C\u206F\u206A\u202E\u202B\u202C\u202B\u200B\u200E\u200F\u206C\u206B\u200E\u206D\u200F\u206B\u206D\u202C\u200F\u206A\u200B\u202C\u206C\u206D\u202B\u202A\u202E().Where(delegate(ExhibitConfig e)
				{
					if (!AyaMisc.GameDirector_ClearAll_Patch.<>c.\u200D\u200F\u206D\u202B\u200F\u200F\u202C\u202B\u206C\u200B\u200F\u202D\u202C\u200E\u206A\u202D\u200D\u200E\u206A\u206C\u206E\u200E\u206E\u206F\u200F\u202C\u200E\u202D\u202C\u202B\u206A\u206E\u200F\u206B\u206C\u202E\u202E\u206F\u200B\u200F\u202E(AyaMisc.GameDirector_ClearAll_Patch.<>c.\u202E\u202D\u206B\u202D\u202E\u202A\u200B\u206C\u202E\u206B\u206D\u202C\u202E\u202A\u202E\u206B\u206F\u200F\u202E\u206F\u200C\u200B\u206E\u200B\u206A\u202C\u206C\u202E\u200D\u202E\u200C\u200B\u200C\u202B\u206C\u200B\u202A\u200B\u200F\u200D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358)))
					{
						for (;;)
						{
							int num10 = 448847270;
							switch ((~((num10 - (883132500 + 95143371 + 1015707719 * -1253207059 - (~169542254 + --1449255341))) * -565301093) ^ -574181072) % 3)
							{
							case 1:
								goto IL_006A;
							case 2:
								continue;
							}
							break;
						}
						return true;
						IL_006A:
						return AyaMisc.GameDirector_ClearAll_Patch.<>c.\u200D\u200F\u206D\u202B\u200F\u200F\u202C\u202B\u206C\u200B\u200F\u202D\u202C\u200E\u206A\u202D\u200D\u200E\u206A\u206C\u206E\u200E\u206E\u206F\u200F\u202C\u200E\u202D\u202C\u202B\u206A\u206E\u200F\u206B\u206C\u202E\u202E\u206F\u200B\u200F\u202E(AyaMisc.GameDirector_ClearAll_Patch.<>c.\u202E\u202D\u206B\u202D\u202E\u202A\u200B\u206C\u202E\u206B\u206D\u202C\u202E\u202A\u202E\u206B\u206F\u200F\u202E\u206F\u200C\u200B\u206E\u200B\u206A\u202C\u206C\u202E\u200D\u202E\u200C\u200B\u200C\u202B\u206C\u200B\u202A\u200B\u200F\u200D\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317));
					}
					return true;
				}).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_01B7:
						int num5 = (AyaMisc.GameDirector_ClearAll_Patch.\u200B\u202B\u200F\u206A\u202A\u206E\u202D\u200F\u202A\u202E\u206B\u202C\u202C\u200C\u202C\u202E\u202E\u202D\u206A\u202C\u200D\u200F\u202D\u200E\u200B\u202E\u202A\u206D\u206C\u200E\u206C\u200E\u206D\u202E\u200E\u202A\u206F\u202C\u200B\u202C\u202E(enumerator2) ? (-1546256242) : (-1346493429));
						for (;;)
						{
							int num2 = num5;
							switch (~((num2 ^ ((45553599 - 1129513100) * -715104755 - ~1068914867)) - -(-477263744 + 492725572) - 1705297963 * 1401057217) % 4)
							{
							case 0:
								num5 = -1546256242;
								continue;
							case 1:
								enumerator2.Current.IsDebug = false;
								num5 = 1579926224;
								continue;
							case 3:
								goto IL_01B7;
							}
							goto Block_11;
						}
					}
					Block_11:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						for (;;)
						{
							IL_01D5:
							int num6 = -1607063346;
							for (;;)
							{
								int num2 = num6;
								uint num4;
								switch ((num4 = (uint)(~(uint)((num2 ^ ((45553599 - 1129513100) * -715104755 - ~1068914867)) - -(-477263744 + 492725572) - 1705297963 * 1401057217))) % 3U)
								{
								case 0U:
									goto IL_01D5;
								case 1U:
									AyaMisc.GameDirector_ClearAll_Patch.\u206E\u206B\u206B\u202D\u202C\u202A\u206B\u202D\u206A\u200C\u206F\u200F\u206F\u206A\u202A\u206B\u200D\u206A\u206E\u200B\u206A\u200D\u206B\u206D\u206F\u202D\u206D\u202B\u200E\u202E\u206B\u206C\u202E\u200D\u206A\u200D\u206B\u206F\u200E\u206E\u202E(enumerator2);
									num6 = (int)((num4 * 2852004579U) ^ 1848294044U);
									continue;
								}
								goto Block_14;
							}
						}
						Block_14:;
					}
				}
			}

			static IReadOnlyList<CardConfig> \u200B\u202C\u202A\u202D\u202C\u202A\u200C\u206B\u202C\u206B\u206E\u200F\u202C\u206C\u202B\u200F\u202A\u200C\u206B\u206A\u200C\u202A\u200E\u206A\u200D\u200B\u200F\u206F\u200C\u206F\u202D\u200C\u206F\u202A\u202A\u200E\u200F\u202B\u206C\u206A\u202E()
			{
				return CardConfig.AllConfig();
			}

			static bool \u200B\u202B\u200F\u206A\u202A\u206E\u202D\u200F\u202A\u202E\u206B\u202C\u202C\u200C\u202C\u202E\u202E\u202D\u206A\u202C\u200D\u200F\u202D\u200E\u200B\u202E\u202A\u206D\u206C\u200E\u206C\u200E\u206D\u202E\u200E\u202A\u206F\u202C\u200B\u202C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206E\u206B\u206B\u202D\u202C\u202A\u206B\u202D\u206A\u200C\u206F\u200F\u206F\u206A\u202A\u206B\u200D\u206A\u206E\u200B\u206A\u200D\u206B\u206D\u206F\u202D\u206D\u202B\u200E\u202E\u206B\u206C\u202E\u200D\u206A\u200D\u206B\u206F\u200E\u206E\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static IReadOnlyList<ExhibitConfig> \u206E\u202A\u206E\u200E\u200C\u200C\u206F\u202E\u202A\u206E\u202A\u206C\u200F\u206E\u202C\u206F\u206A\u202E\u202B\u202C\u202B\u200B\u200E\u200F\u206C\u206B\u200E\u206D\u200F\u206B\u206D\u202C\u200F\u206A\u200B\u202C\u206C\u206D\u202B\u202A\u202E()
			{
				return ExhibitConfig.AllConfig();
			}
		}

		[HarmonyPatch(typeof(TargetSelector), "DisableSelector")]
		private class TargetSelector_DisableSelector_Patch
		{
			private static bool Prefix(TargetSelector __instance)
			{
				AyaMisc.TargetSelector_DisableSelector_Patch.\u200D\u200E\u202E\u206D\u202E\u200B\u202C\u206E\u200D\u200B\u200B\u206D\u206A\u206D\u206D\u206C\u206F\u200D\u200C\u206F\u202E\u202D\u200B\u200C\u206D\u200F\u206A\u206C\u200C\u206E\u206B\u200B\u202D\u200D\u200C\u202B\u200B\u206E\u206E\u200F\u202E(AyaMisc.TargetSelector_DisableSelector_Patch.\u206E\u206E\u200E\u200D\u206E\u200B\u200C\u200F\u200C\u206C\u200C\u202C\u206E\u202C\u206D\u206E\u200E\u206E\u206E\u206C\u202A\u200F\u206A\u206A\u200C\u202B\u202E\u202C\u206A\u200B\u200B\u200B\u206C\u200B\u202A\u206D\u200E\u202A\u206B\u202D\u202E(__instance.root), false);
				for (;;)
				{
					IL_0011:
					int num = 2143168024;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~num2 ^ -1531392515)) % 15U)
						{
						case 0U:
							num = ((__instance._status == TargetSelectorStatus.Us) ? 951015097 : 807415485);
							continue;
						case 1U:
							AyaMisc.TargetSelector_DisableSelector_Patch.\u200D\u200E\u202E\u206D\u202E\u200B\u202C\u206E\u200D\u200B\u200B\u206D\u206A\u206D\u206D\u206C\u206F\u200D\u200C\u206F\u202E\u202D\u200B\u200C\u206D\u200F\u206A\u206C\u200C\u206E\u206B\u200B\u202D\u200D\u200C\u202B\u200B\u206E\u206E\u200F\u202E(AyaMisc.TargetSelector_DisableSelector_Patch.\u206E\u206E\u200E\u200D\u206E\u200B\u200C\u200F\u200C\u206C\u200C\u202C\u206E\u202C\u206D\u206E\u200E\u206E\u206E\u206C\u202A\u200F\u206A\u206A\u200C\u202B\u202E\u202C\u206A\u200B\u200B\u200B\u206C\u200B\u202A\u206D\u200E\u202A\u206B\u202D\u202E(__instance.curveLine), false);
							num = (int)((num3 * 71266709U) ^ 3137812077U);
							continue;
						case 2U:
							goto IL_0011;
						case 3U:
							num = (int)(((__instance._activeUs == null) ? 3922038145U : 3066119106U) ^ (num3 * 2045203444U));
							continue;
						case 4U:
							__instance._activeHand = null;
							num = (int)((num3 * 335764751U) ^ 2738435427U);
							continue;
						case 5U:
							num = (int)(((!AyaMisc.TargetSelector_DisableSelector_Patch.\u206C\u200F\u206E\u206E\u200F\u206A\u200B\u202C\u200C\u202C\u206B\u202C\u202A\u200C\u206B\u206A\u200F\u206A\u206B\u200D\u202E\u202A\u206F\u206A\u206B\u202E\u202A\u200C\u206B\u206D\u202E\u206C\u206F\u206C\u206B\u202D\u206F\u200E\u202B\u206C\u202E(__instance._activeHand, null)) ? 1855375116U : 1717002468U) ^ (num3 * 1379817664U));
							continue;
						case 7U:
							__instance._targetSelecting = false;
							num = (int)(((__instance._status == TargetSelectorStatus.Card) ? 2897567380U : 3593689008U) ^ (num3 * 3223395087U));
							continue;
						case 8U:
							__instance._hidingCursor = false;
							num = (int)((num3 * 280933588U) ^ 75637530U);
							continue;
						case 9U:
							__instance.ClearPotentialTargets();
							__instance._status = TargetSelectorStatus.None;
							num = 187237421;
							continue;
						case 10U:
							AyaMisc.TargetSelector_DisableSelector_Patch.\u200D\u200D\u202B\u206F\u206F\u200D\u202B\u200C\u206C\u200F\u200D\u206A\u200F\u202B\u206F\u206A\u200B\u200F\u206E\u206F\u206D\u200E\u202C\u202E\u202C\u202D\u202B\u206B\u206E\u200F\u206D\u202C\u200F\u206C\u200D\u202C\u206E\u200B\u206D\u200F\u202E(true);
							num = (int)((num3 * 2084429596U) ^ 1025780502U);
							continue;
						case 11U:
							__instance._activeUs = null;
							num = (int)((num3 * 1767392960U) ^ 1938452093U);
							continue;
						case 12U:
							num = (int)((num3 * 1992462231U) ^ 3582918246U);
							continue;
						case 13U:
							AyaMisc.TargetSelector_DisableSelector_Patch.\u206E\u202B\u200D\u206D\u206B\u206F\u206B\u206F\u206F\u200D\u202E\u206F\u200B\u200F\u202D\u206F\u200C\u206C\u202D\u202D\u200C\u200E\u206F\u206A\u206A\u202C\u206C\u206D\u200B\u206F\u200E\u200B\u202B\u202E\u202C\u202B\u200F\u200C\u206B\u202E\u202E(__instance._activeUs, null);
							num = (int)((num3 * 4067334107U) ^ 2289675695U);
							continue;
						case 14U:
							AyaMisc.TargetSelector_DisableSelector_Patch.\u206D\u206E\u202A\u206B\u206B\u206C\u200B\u200D\u202B\u206A\u202A\u200B\u206A\u202E\u202C\u202C\u200B\u206D\u206C\u202C\u200C\u206A\u206B\u202A\u206C\u200D\u200E\u202C\u202C\u206E\u200D\u200D\u200D\u206D\u200E\u202B\u206C\u206E\u200F\u206F\u202E(AyaMisc.TargetSelector_DisableSelector_Patch.\u202C\u200C\u202B\u206E\u206F\u206A\u202C\u202C\u200F\u202D\u206A\u202A\u202C\u200F\u206D\u206F\u200D\u202A\u200D\u206C\u200E\u206F\u200D\u202A\u206E\u202E\u206E\u200E\u200F\u200B\u202C\u202C\u200F\u200C\u202D\u200E\u200C\u206C\u202E\u200E\u202E(__instance._activeHand), null);
							AyaMisc.TargetSelector_DisableSelector_Patch.\u206A\u206D\u200F\u200E\u200F\u202C\u202A\u206E\u200F\u202B\u206D\u202E\u200B\u206C\u200B\u202D\u200B\u206D\u202E\u202E\u206D\u202D\u206F\u206D\u202E\u206C\u200E\u202E\u206D\u202B\u206B\u206F\u206E\u206B\u202D\u206B\u206D\u206C\u206A\u202C\u202E(AyaMisc.TargetSelector_DisableSelector_Patch.\u202C\u200C\u202B\u206E\u206F\u206A\u202C\u202C\u200F\u202D\u206A\u202A\u202C\u200F\u206D\u206F\u200D\u202A\u200D\u206C\u200E\u206F\u200D\u202A\u206E\u202E\u206E\u200E\u200F\u200B\u202C\u202C\u200F\u200C\u202D\u200E\u200C\u206C\u202E\u200E\u202E(__instance._activeHand), null);
							num = (int)((num3 * 2173756298U) ^ 54126330U);
							continue;
						}
						return false;
					}
				}
				return false;
			}

			static GameObject \u206E\u206E\u200E\u200D\u206E\u200B\u200C\u200F\u200C\u206C\u200C\u202C\u206E\u202C\u206D\u206E\u200E\u206E\u206E\u206C\u202A\u200F\u206A\u206A\u200C\u202B\u202E\u202C\u206A\u200B\u200B\u200B\u206C\u200B\u202A\u206D\u200E\u202A\u206B\u202D\u202E(Component A_0)
			{
				return A_0.gameObject;
			}

			static void \u200D\u200E\u202E\u206D\u202E\u200B\u202C\u206E\u200D\u200B\u200B\u206D\u206A\u206D\u206D\u206C\u206F\u200D\u200C\u206F\u202E\u202D\u200B\u200C\u206D\u200F\u206A\u206C\u200C\u206E\u206B\u200B\u202D\u200D\u200C\u202B\u200B\u206E\u206E\u200F\u202E(GameObject A_0, bool A_1)
			{
				A_0.SetActive(A_1);
			}

			static void \u200D\u200D\u202B\u206F\u206F\u200D\u202B\u200C\u206C\u200F\u200D\u206A\u200F\u202B\u206F\u206A\u200B\u200F\u206E\u206F\u206D\u200E\u202C\u202E\u202C\u202D\u202B\u206B\u206E\u200F\u206D\u202C\u200F\u206C\u200D\u202C\u206E\u200B\u206D\u200F\u202E(bool A_0)
			{
				Cursor.visible = A_0;
			}

			static bool \u206C\u200F\u206E\u206E\u200F\u206A\u200B\u202C\u200C\u202C\u206B\u202C\u202A\u200C\u206B\u206A\u200F\u206A\u206B\u200D\u202E\u202A\u206F\u206A\u206B\u202E\u202A\u200C\u206B\u206D\u202E\u206C\u206F\u206C\u206B\u202D\u206F\u200E\u202B\u206C\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
			{
				return A_0 != A_1;
			}

			static Card \u202C\u200C\u202B\u206E\u206F\u206A\u202C\u202C\u200F\u202D\u206A\u202A\u202C\u200F\u206D\u206F\u200D\u202A\u200D\u206C\u200E\u206F\u200D\u202A\u206E\u202E\u206E\u200E\u200F\u200B\u202C\u202C\u200F\u200C\u202D\u200E\u200C\u206C\u202E\u200E\u202E(HandCard A_0)
			{
				return A_0.Card;
			}

			static void \u206D\u206E\u202A\u206B\u206B\u206C\u200B\u200D\u202B\u206A\u202A\u200B\u206A\u202E\u202C\u202C\u200B\u206D\u206C\u202C\u200C\u206A\u206B\u202A\u206C\u200D\u200E\u202C\u202C\u206E\u200D\u200D\u200D\u206D\u200E\u202B\u206C\u206E\u200F\u206F\u202E(Card A_0, Unit A_1)
			{
				A_0.PendingTarget = A_1;
			}

			static void \u206A\u206D\u200F\u200E\u200F\u202C\u202A\u206E\u200F\u202B\u206D\u202E\u200B\u206C\u200B\u202D\u200B\u206D\u202E\u202E\u206D\u202D\u206F\u206D\u202E\u206C\u200E\u202E\u206D\u202B\u206B\u206F\u206E\u206B\u202D\u206B\u206D\u206C\u206A\u202C\u202E(Card A_0, ManaGroup? A_1)
			{
				A_0.PendingManaUsage = A_1;
			}

			static void \u206E\u202B\u200D\u206D\u206B\u206F\u206B\u206F\u206F\u200D\u202E\u206F\u200B\u200F\u202D\u206F\u200C\u206C\u202D\u202D\u200C\u200E\u206F\u206A\u206A\u202C\u206C\u206D\u200B\u206F\u200E\u200B\u202B\u202E\u202C\u202B\u200F\u200C\u206B\u202E\u202E(UltimateSkill A_0, Unit A_1)
			{
				A_0.PendingTarget = A_1;
			}
		}

		[HarmonyPatch(typeof(EnemyGroupConfig), "AllConfig")]
		private class EnemyGroupConfig_AllConfig_Patch
		{
			private static void Postfix(EnemyGroupConfig __instance, ref IReadOnlyList<EnemyGroupConfig> __result)
			{
				List<EnemyGroupConfig> list = __result.ToList<EnemyGroupConfig>();
				for (;;)
				{
					IL_0008:
					int num = -1735174676;
					for (;;)
					{
						int num2 = num;
						switch ((-(num2 * 1904309961 - (2082027704 - 1462860731 - ~287898334)) ^ 11895978) % 5)
						{
						case 0:
							list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(556183621)));
							list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1672944078)));
							num = 1174039819;
							continue;
						case 2:
							list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(249015830)));
							num = 532352502;
							continue;
						case 3:
							goto IL_0008;
						case 4:
							list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1606930955)));
							list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-135338671)));
							num = 1115224071;
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-634034904)));
				list.RemoveAll((EnemyGroupConfig e) => AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u202B\u206D\u206F\u206A\u206E\u206C\u202A\u206F\u206E\u206B\u206C\u200D\u206B\u206E\u206C\u200E\u202A\u202B\u200C\u202E\u200C\u206C\u206C\u206C\u206F\u200F\u206E\u200D\u206B\u200F\u202C\u200D\u200B\u206A\u202E\u202B\u202A\u202B\u202C\u206F\u202E(AyaMisc.EnemyGroupConfig_AllConfig_Patch.<>c.\u200C\u206F\u206C\u202A\u200F\u206D\u200E\u206B\u202A\u200C\u206F\u202B\u206E\u206B\u206E\u200C\u206C\u206D\u206B\u206B\u202C\u206A\u200C\u200F\u206E\u200D\u202C\u200B\u206F\u202B\u202A\u206F\u206A\u206B\u200F\u206B\u206E\u200E\u206D\u202E(e), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1660911313)));
				__result = list;
			}
		}

		[HarmonyPatch(typeof(BgmConfig), "AllConfig")]
		private class BgmConfig_AllConfig_Patch
		{
			private static void Postfix(BgmConfig __instance, ref IReadOnlyList<BgmConfig> __result)
			{
				List<BgmConfig> list = __result.ToList<BgmConfig>();
				if (!BepinexPlugin.Chapter1AyaPlayerUnit)
				{
					goto IL_0012;
				}
				goto IL_03C5;
				int num2;
				for (;;)
				{
					IL_0017:
					int num = num2;
					switch (((~num - -734429027 * (-1035306669 ^ 847772879)) * 905079329 - -1807389379) % 39)
					{
					case 0:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1066695244)));
						num2 = 1842486416;
						continue;
					case 1:
						goto IL_03C5;
					case 2:
						num2 = ((!BepinexPlugin.FlandreSongBrokenDollMarch) ? 254655110 : 1912615721);
						continue;
					case 3:
						num2 = ((!BepinexPlugin.FlandreRipplesof495YearsBgm) ? (-878700760) : (-454458375));
						continue;
					case 4:
						num2 = ((!BepinexPlugin.AyaUltAdventBgm) ? 1769095345 : (-968523073));
						continue;
					case 5:
						num2 = ((!BepinexPlugin.AyaBossFlandreDemo) ? 2124811820 : (-597411741));
						continue;
					case 6:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1998051817)));
						num2 = -956065480;
						continue;
					case 7:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1894391518)));
						num2 = 187048169;
						continue;
					case 9:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(509123210)));
						num2 = -31591581;
						continue;
					case 10:
						goto IL_0012;
					case 11:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-317846223)));
						num2 = -1792531163;
						continue;
					case 12:
						num2 = (BepinexPlugin.FlandreSongFlandol ? (-250566121) : 1049221150);
						continue;
					case 13:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1490064686)));
						num2 = 1143366103;
						continue;
					case 14:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-574000533)));
						num2 = 1912615721;
						continue;
					case 15:
						num2 = ((!BepinexPlugin.AyaBossZUNPhantasm) ? 1353899037 : (-956065480));
						continue;
					case 16:
						num2 = (BepinexPlugin.AyaBossFlandre ? (-741853467) : (-719985992));
						continue;
					case 17:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1428962214)));
						num2 = -1451274550;
						continue;
					case 18:
						num2 = (BepinexPlugin.AyaTakane ? 1143366103 : 928488598);
						continue;
					case 19:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1672944078)));
						num2 = 309278755;
						continue;
					case 20:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(868733190)));
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(685508871)));
						num2 = 1513599505;
						continue;
					case 21:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(108923543)));
						num2 = 1379153376;
						continue;
					case 22:
						num2 = (BepinexPlugin.FlandreScarletCasinoBgm ? (-1451274550) : (-425450349));
						continue;
					case 23:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1846551867)));
						num2 = -1779095367;
						continue;
					case 24:
						num2 = (BepinexPlugin.FlandreStage5Bgm ? (-1792531163) : 985717577);
						continue;
					case 25:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-602443140)));
						__result = list;
						num2 = -844758321;
						continue;
					case 26:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1746413144)));
						num2 = -741853467;
						continue;
					case 27:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1154633936)));
						num2 = -968523073;
						continue;
					case 28:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-829863971)));
						num2 = -597411741;
						continue;
					case 29:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(63980803)));
						num2 = -1776359058;
						continue;
					case 30:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(940116595)));
						num2 = -147816487;
						continue;
					case 31:
						num2 = ((!BepinexPlugin.FlandreSongRadicalVampire) ? (-673838327) : (-1776359058));
						continue;
					case 32:
						num2 = ((!BepinexPlugin.AyaBossZUN) ? 46564605 : 309278755);
						continue;
					case 33:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1113071059)));
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-930287354)));
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(346446523)));
						num2 = -911886396;
						continue;
					case 34:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(572596929)));
						num2 = -250566121;
						continue;
					case 35:
						num2 = ((!BepinexPlugin.FlandreForbiddenScarletCuriosityBgm) ? 290834986 : (-147816487));
						continue;
					case 36:
						list.RemoveAll((BgmConfig b) => AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u202B\u206C\u202A\u206D\u202A\u206F\u200D\u202C\u200C\u206E\u206D\u206F\u200D\u200C\u206E\u206E\u202B\u202A\u206C\u206C\u206B\u202E\u200B\u206E\u202E\u206D\u202D\u200B\u206C\u206B\u200F\u202D\u202D\u202B\u206A\u206B\u206D\u202C\u200F\u202E(AyaMisc.BgmConfig_AllConfig_Patch.<>c.\u200F\u200D\u200B\u200F\u200E\u200F\u202E\u200E\u206E\u202D\u200C\u206E\u200B\u206C\u200D\u202C\u206E\u200C\u206F\u200C\u206E\u206F\u200B\u200F\u206A\u206D\u200C\u202E\u202B\u202D\u202D\u202A\u206B\u202E\u202C\u200F\u200D\u206C\u200D\u202B\u202E(b), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-909692220)));
						num2 = -454458375;
						continue;
					case 37:
						num2 = (BepinexPlugin.FlandreSongLOVEBREAKOUT ? 187048169 : 502639154);
						continue;
					case 38:
						num2 = ((!BepinexPlugin.AyaBossKoishi) ? 274703531 : 1379153376);
						continue;
					}
					break;
				}
				return;
				IL_0012:
				num2 = -1318453912;
				goto IL_0017;
				IL_03C5:
				num2 = ((!BepinexPlugin.AyaStage5Bgm) ? 1174011834 : (-31591581));
				goto IL_0017;
			}
		}

		[HarmonyPatch(typeof(CardConfig), "AllConfig")]
		private class CardConfig_AllConfig_Patch
		{
			private static void Postfix(CardConfig __instance, ref IReadOnlyList<CardConfig> __result)
			{
				List<CardConfig> list = __result.ToList<CardConfig>();
				if (AyaMisc.CardConfig_AllConfig_Patch.\u200F\u202C\u206D\u202E\u200E\u202C\u202D\u200D\u202A\u200E\u206F\u202C\u200D\u202A\u202D\u206A\u200C\u200F\u200F\u206C\u206E\u202E\u202A\u200F\u206D\u206E\u206A\u200B\u202E\u202D\u202B\u200D\u200F\u206E\u202D\u206C\u206E\u200B\u200F\u202E(Singleton<GameMaster>.Instance) != null)
				{
					for (;;)
					{
						IL_0014:
						int num = 1641873720;
						for (;;)
						{
							int num2 = num;
							switch (~(~(-num2 - (~224163795 - --1419907920))) % 3)
							{
							case 0:
								goto IL_0014;
							case 1:
								list.RemoveAll(delegate(CardConfig b)
								{
									if (!AyaMisc.CardConfig_AllConfig_Patch.<>c.\u206B\u202C\u206B\u202E\u206B\u202C\u206C\u202B\u202D\u206A\u206C\u200B\u200D\u206B\u200F\u200C\u202D\u200D\u202B\u202C\u206C\u202E\u200F\u200C\u206C\u202B\u200D\u206C\u202E\u200B\u206E\u200D\u202C\u200B\u206C\u206A\u206C\u206B\u200F\u206B\u202E(AyaMisc.CardConfig_AllConfig_Patch.<>c.\u200F\u202D\u200B\u200C\u200F\u206F\u202C\u202B\u200E\u206B\u202A\u200D\u206B\u206D\u206F\u200F\u202D\u200E\u200B\u206C\u206D\u206A\u202B\u206D\u206D\u202E\u200B\u202B\u200D\u206E\u206A\u206F\u202D\u200F\u206D\u206F\u206B\u202C\u206F\u202D\u202E(b), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103)))
									{
										for (;;)
										{
											IL_0019:
											int num3 = 439712524;
											for (;;)
											{
												int num4 = num3;
												uint num5;
												switch ((num5 = (uint)(869584556 * -1768605513 - ~(num4 * 729918915) + -1921719560)) % 4U)
												{
												case 1U:
													num3 = (int)((AyaMisc.CardConfig_AllConfig_Patch.<>c.\u206B\u202C\u206B\u202E\u206B\u202C\u206C\u202B\u202D\u206A\u206C\u200B\u200D\u206B\u200F\u200C\u202D\u200D\u202B\u202C\u206C\u202E\u200F\u200C\u206C\u202B\u200D\u206C\u202E\u200B\u206E\u200D\u202C\u200B\u206C\u206A\u206C\u206B\u200F\u206B\u202E(AyaMisc.CardConfig_AllConfig_Patch.<>c.\u200F\u202D\u200B\u200C\u200F\u206F\u202C\u202B\u200E\u206B\u202A\u200D\u206B\u206D\u206F\u200F\u202D\u200E\u200B\u206C\u206D\u206A\u202B\u206D\u206D\u202E\u200B\u202B\u200D\u206E\u206A\u206F\u202D\u200F\u206D\u206F\u206B\u202C\u206F\u202D\u202E(b), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733)) ? 1218997200U : 3011087071U) ^ (num5 * 1231425230U));
													continue;
												case 2U:
													goto IL_0019;
												case 3U:
													goto IL_0086;
												}
												return false;
											}
										}
										return false;
									}
									IL_0086:
									return AyaMisc.CardConfig_AllConfig_Patch.<>c.\u200B\u200C\u206F\u202D\u200E\u206D\u200F\u200C\u206F\u206A\u206A\u202A\u206B\u200E\u200F\u200F\u206A\u202D\u200D\u202A\u200C\u206A\u202B\u200C\u200C\u200D\u200E\u206B\u202B\u200D\u200B\u206D\u202B\u200C\u206C\u202E\u206F\u206D\u200F\u200F\u202E(b) >= 2;
								});
								num = -394406485;
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				__result = list;
			}

			static GameRunController \u200F\u202C\u206D\u202E\u200E\u202C\u202D\u200D\u202A\u200E\u206F\u202C\u200D\u202A\u202D\u206A\u200C\u200F\u200F\u206C\u206E\u202E\u202A\u200F\u206D\u206E\u206A\u200B\u202E\u202D\u202B\u200D\u200F\u206E\u202D\u206C\u206E\u200B\u200F\u202E(GameMaster A_0)
			{
				return A_0.CurrentGameRun;
			}
		}
	}
}
