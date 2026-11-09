using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using AyaShameimaru.Cards;
using AyaShameimaru.EnemyUnits;
using AyaShameimaru.Stages;
using BepInEx.Configuration;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.Adventures.Stage2;
using LBoL.EntityLib.Stages.NormalStages;
using LBoL.EntityLib.StatusEffects.Others;
using LBoL.Presentation;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.ExtraWidgets;
using LBoL.Presentation.UI.Panels;
using LBoL.Presentation.UI.Widgets;
using LBoL.Presentation.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace AyaShameimaru.PlayerUnits
{
	public sealed class FlandrePlayerUnitDef : PlayerUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandrePlayerUnitDef.\u202B\u202B\u202C\u206B\u202B\u206F\u202E\u206F\u200E\u200F\u200E\u206B\u206A\u200C\u202C\u200F\u206B\u206B\u206C\u202B\u206E\u206E\u202D\u206A\u202A\u200F\u206D\u200B\u200B\u200C\u200C\u206A\u206E\u200F\u206E\u200D\u202B\u200C\u206B\u200E\u202E(BepinexPlugin.playerUnitLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			FlandrePlayerUnitDef.<LoadAsSprite>d__3 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1625892126;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~num2 * -1826744997)) % 5U)
					{
					case 0U:
						goto IL_000C;
					case 1U:
						<LoadAsSprite>d__.path = path;
						num = (int)((num3 * 413659868U) ^ 2977833879U);
						continue;
					case 2U:
						<LoadAsSprite>d__.<>t__builder.Start<FlandrePlayerUnitDef.<LoadAsSprite>d__3>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 928454207U) ^ 1203160549U);
						continue;
					case 3U:
						<LoadAsSprite>d__.<>1__state = -1;
						num = (int)((num3 * 218763856U) ^ 1123416044U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return <LoadAsSprite>d__.<>t__builder.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PlayerImages LoadPlayerImages()
		{
			PlayerImages playerImages = FlandrePlayerUnitDef.\u206F\u202B\u200D\u206A\u200D\u206C\u206A\u202D\u200C\u202E\u202E\u202B\u202D\u202B\u206A\u206F\u200D\u202B\u202D\u202D\u200D\u200B\u202D\u200E\u202E\u206A\u200F\u202E\u202E\u202C\u200B\u200B\u206C\u206B\u200F\u200C\u206C\u200F\u206A\u202D\u202E();
			for (;;)
			{
				IL_0006:
				int num = 202984525;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(-num2)) - -796709064)) % 5U)
					{
					case 0U:
						goto IL_0006;
					case 1U:
						num = (int)(((!BepinexPlugin.AprilFools) ? 3228969794U : 691433180U) ^ (num3 * 2582446034U));
						continue;
					case 2U:
						FlandrePlayerUnitDef.\u202E\u206A\u206B\u202D\u200C\u202B\u202B\u202E\u202B\u202C\u206C\u202A\u206F\u200C\u202D\u206A\u202A\u206B\u206C\u200F\u206D\u206A\u200B\u206B\u206A\u200F\u206E\u206B\u206E\u206D\u206C\u206D\u200B\u202C\u200F\u206F\u206F\u206D\u206C\u200C\u202E(playerImages, new UniTask<Sprite>?(this.LoadAsSprite(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-439524308))), () => BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-84471050)));
						num = 47862396;
						continue;
					case 4U:
						FlandrePlayerUnitDef.\u200B\u200B\u206D\u206F\u200C\u202A\u206A\u200B\u202C\u202C\u206F\u206B\u206A\u202B\u200E\u200D\u202B\u200B\u206F\u200F\u202A\u202D\u206C\u200D\u200C\u200C\u200F\u202A\u200D\u206A\u200C\u202A\u206A\u200B\u200D\u200D\u200C\u200E\u206D\u200E\u202E(playerImages, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1351946519), (string s) => BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(s), (string s) => this.LoadAsSprite(s), 2, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), "");
						num = -30866047;
						continue;
					}
					return playerImages;
				}
			}
			return playerImages;
		}

		public override PlayerUnitTemplate.EikiSummonInfo AssociateEikiSummon()
		{
			if (AyaMisc.IsValidGameRun(FlandrePlayerUnitDef.\u202D\u206C\u200F\u202C\u202A\u206D\u206B\u206A\u200C\u200E\u202E\u206C\u206D\u206E\u200C\u202D\u200C\u202C\u206D\u206C\u202E\u202B\u200C\u202E\u202B\u206A\u200C\u206B\u206E\u200B\u206F\u206B\u200D\u200C\u202E\u202B\u206D\u200F\u200D\u202C\u202E(Singleton<GameMaster>.Instance)))
			{
				for (;;)
				{
					IL_0011:
					int num = -34486652;
					for (;;)
					{
						int num2 = num;
						switch (-(~(-2055979085 + (2026618642 * -1056567025 - 784468075 * 1659155317) - num2) ^ (898282412 * 1479736291)) % 4)
						{
						case 0:
							goto IL_0011;
						case 1:
							goto IL_0086;
						case 3:
						{
							GameRunController gameRunController = FlandrePlayerUnitDef.\u202D\u206C\u200F\u202C\u202A\u206D\u206B\u206A\u200C\u200E\u202E\u206C\u206D\u206E\u200C\u202D\u200C\u202C\u206D\u206C\u202E\u202B\u200C\u202E\u202B\u206A\u200C\u206B\u206E\u200B\u206F\u206B\u200D\u200C\u202E\u202B\u206D\u200F\u200D\u202C\u202E(Singleton<GameMaster>.Instance);
							if (gameRunController == null || FlandrePlayerUnitDef.\u202A\u202D\u206F\u202D\u202D\u202D\u202D\u202C\u206D\u202B\u202A\u202A\u206D\u206F\u206B\u206A\u206B\u200F\u206E\u200D\u202E\u200C\u206E\u206B\u200E\u206D\u202C\u200F\u206D\u200F\u206C\u202D\u206C\u202D\u200D\u202B\u202A\u200D\u206C\u202B\u202E(FlandrePlayerUnitDef.\u202D\u202A\u206B\u206C\u202E\u206F\u200F\u200C\u206D\u206D\u202D\u202C\u202A\u206B\u200B\u202D\u200C\u200F\u206E\u206E\u206A\u200F\u202B\u206A\u202D\u200F\u202B\u202B\u200C\u202E\u202A\u202C\u200E\u202D\u202A\u206E\u200E\u206B\u206B\u202E\u202E(gameRunController)) != StationType.EliteEnemy)
							{
								num = -69909286;
								continue;
							}
							break;
						}
						}
						goto Block_1;
					}
				}
				Block_1:
				return FlandrePlayerUnitDef.\u206F\u206D\u202A\u202D\u202E\u202B\u202E\u200B\u202A\u200E\u202B\u202E\u202B\u202C\u206A\u206A\u200D\u202E\u206F\u206F\u202C\u202A\u206C\u200F\u202A\u202E\u206D\u200D\u206E\u206E\u206E\u202B\u206B\u200B\u206A\u206B\u206E\u202C\u206B\u202A\u202E(FlandrePlayerUnitDef.\u206E\u206B\u206D\u200C\u206E\u202C\u202D\u206B\u206D\u206E\u202C\u202D\u202E\u206B\u202D\u202A\u200D\u202A\u200B\u202B\u202C\u200F\u206E\u200C\u200B\u206F\u202E\u206E\u206B\u202C\u206B\u206D\u200F\u206C\u200D\u206E\u202E\u202D\u202E\u206F\u202E(typeof(AyaBossFlandreDef.AyaBossFlandre).TypeHandle), null);
			}
			IL_0086:
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PlayerUnitConfig MakeConfig()
		{
			string text = "";
			bool flag = true;
			string text2 = "";
			int num = 0;
			int num2 = 6;
			int? num3 = new int?(0);
			bool flag2 = true;
			int? num4 = null;
			ManaColor manaColor = ManaColor.Black;
			ManaColor manaColor2 = ManaColor.Red;
			ManaGroup manaGroup = new ManaGroup
			{
				Blue = 1,
				Black = 1,
				Red = 1,
				Philosophy = 1
			};
			string text3 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2063972161);
			int num5 = 95;
			int num6 = 49;
			int num7 = 0;
			string text4 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1642264340);
			string text5 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1562638501);
			string text6 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(272501334);
			string text7 = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2125690834);
			IReadOnlyList<string> readOnlyList;
			if (!BepinexPlugin.AprilFools)
			{
				string[] array = new string[10];
				array[0] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1490949623);
				array[1] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1490949623);
				array[2] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1650528182);
				array[3] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(92634320);
				array[4] = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2015528035);
				array[5] = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2015528035);
				array[6] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1787582410);
				array[7] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(874358835);
				array[8] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1003461338);
				readOnlyList = array;
				array[9] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1859554239);
			}
			else
			{
				string[] array2 = new string[10];
				array2[0] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(46903368);
				array2[1] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(31328977);
				array2[2] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(46903368);
				array2[3] = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(357242942);
				array2[4] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
				array2[5] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
				array2[6] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(46903368);
				array2[7] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(31328977);
				array2[8] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
				readOnlyList = array2;
				array2[9] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
			}
			IReadOnlyList<string> readOnlyList2;
			if (!BepinexPlugin.AprilFools)
			{
				string[] array3 = new string[10];
				array3[0] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1076608627);
				array3[1] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1490949623);
				array3[2] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1650528182);
				array3[3] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-17996021);
				array3[4] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-773257138);
				array3[5] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1087209605);
				array3[6] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1270433924);
				array3[7] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1677832264);
				array3[8] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1453658243);
				readOnlyList2 = array3;
				array3[9] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1522848575);
			}
			else
			{
				string[] array4 = new string[10];
				array4[0] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(31328977);
				array4[1] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1577601715);
				array4[2] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
				array4[3] = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(31328977);
				array4[4] = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(46903368);
				array4[5] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
				array4[6] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1577601715);
				array4[7] = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1577601715);
				array4[8] = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(357242942);
				readOnlyList2 = array4;
				array4[9] = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(491832265);
			}
			return new PlayerUnitConfig(text, flag, text2, num, num2, num3, flag2, num4, manaColor, manaColor2, manaGroup, text3, num5, num6, num7, text4, text5, text6, text7, readOnlyList, readOnlyList2, 1, 1);
		}

		static BatchLocalization \u202B\u202B\u202C\u206B\u202B\u206F\u202E\u206F\u200E\u200F\u200E\u206B\u206A\u200C\u202C\u200F\u206B\u206B\u206C\u202B\u206E\u206E\u202D\u206A\u202A\u200F\u206D\u200B\u200B\u200C\u200C\u206A\u206E\u200F\u206E\u200D\u202B\u200C\u206B\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static PlayerImages \u206F\u202B\u200D\u206A\u200D\u206C\u206A\u202D\u200C\u202E\u202E\u202B\u202D\u202B\u206A\u206F\u200D\u202B\u202D\u202D\u200D\u200B\u202D\u200E\u202E\u206A\u200F\u202E\u202E\u202C\u200B\u200B\u206C\u206B\u200F\u200C\u206C\u200F\u206A\u202D\u202E()
		{
			return new PlayerImages();
		}

		static void \u200B\u200B\u206D\u206F\u200C\u202A\u206A\u200B\u202C\u202C\u206F\u206B\u206A\u202B\u200E\u200D\u202B\u200B\u206F\u200F\u202A\u202D\u206C\u200D\u200C\u200C\u200F\u202A\u200D\u206A\u200C\u202A\u206A\u200B\u200D\u200D\u200C\u200E\u206D\u200E\u202E(PlayerImages A_0, string A_1, Func<string, Sprite> A_2, Func<string, UniTask<Sprite>> A_3, PlayerImages.UseSame A_4, string A_5, string A_6)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4, A_5, A_6);
		}

		static void \u202E\u206A\u206B\u202D\u200C\u202B\u202B\u202E\u202B\u202C\u206C\u202A\u206F\u200C\u202D\u206A\u202A\u206B\u206C\u200F\u206D\u206A\u200B\u206B\u206A\u200F\u206E\u206B\u206E\u206D\u206C\u206D\u200B\u202C\u200F\u206F\u206F\u206D\u206C\u200C\u202E(PlayerImages A_0, UniTask<Sprite>? A_1, Func<Sprite> A_2)
		{
			A_0.SetStartPanelStand(A_1, A_2);
		}

		static GameRunController \u202D\u206C\u200F\u202C\u202A\u206D\u206B\u206A\u200C\u200E\u202E\u206C\u206D\u206E\u200C\u202D\u200C\u202C\u206D\u206C\u202E\u202B\u200C\u202E\u202B\u206A\u200C\u206B\u206E\u200B\u206F\u206B\u200D\u200C\u202E\u202B\u206D\u200F\u200D\u202C\u202E(GameMaster A_0)
		{
			return A_0.CurrentGameRun;
		}

		static Station \u202D\u202A\u206B\u206C\u202E\u206F\u200F\u200C\u206D\u206D\u202D\u202C\u202A\u206B\u200B\u202D\u200C\u200F\u206E\u206E\u206A\u200F\u202B\u206A\u202D\u200F\u202B\u202B\u200C\u202E\u202A\u202C\u200E\u202D\u202A\u206E\u200E\u206B\u206B\u202E\u202E(GameRunController A_0)
		{
			return A_0.CurrentStation;
		}

		static StationType \u202A\u202D\u206F\u202D\u202D\u202D\u202D\u202C\u206D\u202B\u202A\u202A\u206D\u206F\u206B\u206A\u206B\u200F\u206E\u200D\u202E\u200C\u206E\u206B\u200E\u206D\u202C\u200F\u206D\u200F\u206C\u202D\u206C\u202D\u200D\u202B\u202A\u200D\u206C\u202B\u202E(Station A_0)
		{
			return A_0.Type;
		}

		static Type \u206E\u206B\u206D\u200C\u206E\u202C\u202D\u206B\u206D\u206E\u202C\u202D\u202E\u206B\u202D\u202A\u200D\u202A\u200B\u202B\u202C\u200F\u206E\u200C\u200B\u206F\u202E\u206E\u206B\u202C\u206B\u206D\u200F\u206C\u200D\u206E\u202E\u202D\u202E\u206F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static PlayerUnitTemplate.EikiSummonInfo \u206F\u206D\u202A\u202D\u202E\u202B\u202E\u200B\u202A\u200E\u202B\u202E\u202B\u202C\u206A\u206A\u200D\u202E\u206F\u206F\u202C\u202A\u206C\u200F\u202A\u202E\u206D\u200D\u206E\u206E\u206E\u202B\u206B\u200B\u206A\u206B\u206E\u202C\u206B\u202A\u202E(Type A_0, string A_1)
		{
			return new PlayerUnitTemplate.EikiSummonInfo(A_0, A_1);
		}

		public static string name = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733);

		[EntityLogic(typeof(FlandrePlayerUnitDef))]
		public sealed class FlandrePlayerUnit : PlayerUnit
		{
			public float MadnessValue1
			{
				get
				{
					return 1f;
				}
			}

			public float MadnessValue2
			{
				get
				{
					return 0.25f;
				}
			}

			public int MadnessValue3
			{
				get
				{
					return 100;
				}
			}

			public int MadnessValue4
			{
				get
				{
					return 200;
				}
			}

			public float MadnessAmount1
			{
				get
				{
					return this.MadnessValue1 * (float)this.Madness;
				}
			}

			public float MadnessAmount2
			{
				get
				{
					return this.MadnessValue2 * (float)this.Madness;
				}
			}

			public int MadnessDecay
			{
				get
				{
					return 4;
				}
			}

			public static string FlandreSkipOfferingOff
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return TypeFactory<PlayerUnit>.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-917200796), true, true);
				}
			}

			public static string FlandreSkipOfferingOn
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return TypeFactory<PlayerUnit>.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(989256811), true, true);
				}
			}

			public string FlandreMadnessDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-710086101), true, true);
				}
			}

			public string FlandreMadnessName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1490360597), true, true);
				}
			}

			public string FlandreSelect
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1003684085), true, true);
				}
			}

			public string FlandreSkipDialogue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(696516294), true, true);
				}
			}

			public string FlandreExtraBoss1SukusukuAya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1310851876), true, true);
				}
			}

			public static string FlandreTakaneAttack
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return TypeFactory<PlayerUnit>.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1615168365), true, true);
				}
			}

			public string FlandreEiki1Eiki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1432419045), true, true);
				}
			}

			public string FlandreEiki2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1891080736), true, true);
				}
			}

			public string FlandreEiki3Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(444827538), true, true);
				}
			}

			public string FlandreEiki4Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1796212355), true, true);
				}
			}

			public string FlandreEiki5Eiki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-829757295), true, true);
				}
			}

			public string FlandreEiki6Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1264387558), true, true);
				}
			}

			public string FlandreEiki7Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(75373755), true, true);
				}
			}

			public string FlandreEikiYesDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(703916990), true, true);
				}
			}

			public string FlandreEikiYesName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(632245350), true, true);
				}
			}

			public string FlandreEikiNoDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1960433342), true, true);
				}
			}

			public string FlandreEikiNoName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(543063127), true, true);
				}
			}

			public string FlandreEikiYes1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1076915891), true, true);
				}
			}

			public string FlandreEikiYes2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1765915875), true, true);
				}
			}

			public string FlandreEikiNo1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-622593814), true, true);
				}
			}

			public string FlandreEikiNo2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1626119006), true, true);
				}
			}

			public string FlandreTakane1Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-658855239), true, true);
				}
			}

			public string FlandreTakane2Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1924806402), true, true);
				}
			}

			public string FlandreTakane3Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1788529586), true, true);
				}
			}

			public string FlandreTakane4Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1514517179), true, true);
				}
			}

			public string FlandreTakane5Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1658669807), true, true);
				}
			}

			public string FlandreTakane6Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-730097558), true, true);
				}
			}

			public string FlandreTakane7Takane
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-176301593), true, true);
				}
			}

			public string FlandreAnnoyingSunlight1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1622554791), true, true);
				}
			}

			public string FlandreAnnoyingSunlight2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-947120799), true, true);
				}
			}

			public string FlandreAnnoyingSunlight31Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2059894486), true, true);
				}
			}

			public string FlandreAnnoyingSunlight32Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-738671872), true, true);
				}
			}

			public string FlandreAnnoyingSunlight33Yukari
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1644661996), true, true);
				}
			}

			public string FlandreAnnoyingSunlight34Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1680018075), true, true);
				}
			}

			public string FlandreSongFirstTime1Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1326997210), true, true);
				}
			}

			public string FlandreSongFirstTime2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1722414433), true, true);
				}
			}

			public string FlandreSongFirstTime3Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1200287366), true, true);
				}
			}

			public string FlandreSongFirstTime4Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-485151196), true, true);
				}
			}

			public string FlandreSongFirstTime5Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1574884154), true, true);
				}
			}

			public string FlandreSongFirstTime6Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1220119167), true, true);
				}
			}

			public string FlandreSongFirstTime7Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-882010743), true, true);
				}
			}

			public string FlandreSongFirstTime8Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-543902319), true, true);
				}
			}

			public string FlandreSongFirstTime9Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-997857364), true, true);
				}
			}

			public string FlandreSongFirstTime10Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-262740814), true, true);
				}
			}

			public string FlandreSongFirstTime11Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1374560570), true, true);
				}
			}

			public string FlandreSongFirstTimeSelect
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(658762559), true, true);
				}
			}

			public string FlandreSongFirstTimeYes1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1579683411), true, true);
				}
			}

			public string FlandreSongFirstTimeYes2Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1580265932), true, true);
				}
			}

			public string FlandreSongFirstTimeYes3Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(292313921), true, true);
				}
			}

			public string FlandreSongFirstTimeNo1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(182535637), true, true);
				}
			}

			public string FlandreSongFirstTimeNo2Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(964515519), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding1Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-74134717), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(842042338), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding3Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1554067980), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding4Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1936032303), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding5Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-569324911), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding6Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-639871719), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding7Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1845036215), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding8Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-889394118), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding9Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-177368476), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding10Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(693058106), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding11Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1030201330), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding12Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(679943791), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding13Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1124882051), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding14Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1615274161), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding15Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2074987747), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding16Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1785004407), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding17Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1190454042), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding18Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2065697053), true, true);
				}
			}

			public string FlandreSongFirstTimeEnding19Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(351676057), true, true);
				}
			}

			public bool FlandreSpellCircle
			{
				get
				{
					return FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202E\u202B\u200F\u202A\u206C\u200B\u202B\u202A\u202D\u202C\u202D\u202C\u206D\u206A\u202B\u200C\u206C\u206A\u200F\u200D\u206E\u200F\u206E\u200F\u202C\u202B\u202C\u206B\u206C\u206F\u206B\u200B\u206B\u202A\u206C\u206F\u200D\u206E\u202A\u202E(this._flandreSpellCircle, null);
				}
				set
				{
					if (value)
					{
						goto IL_0003;
					}
					goto IL_0045;
					int num2;
					for (;;)
					{
						IL_0008:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(~(uint)(1698811279 - -1771388244 - num))) % 8U)
						{
						case 0U:
							num2 = (int)((FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202E\u202B\u200F\u202A\u206C\u200B\u202B\u202A\u202D\u202C\u202D\u202C\u206D\u206A\u202B\u200C\u206C\u206A\u200F\u200D\u206E\u200F\u206E\u200F\u202C\u202B\u202C\u206B\u206C\u206F\u206B\u200B\u206B\u202A\u206C\u206F\u200D\u206E\u202A\u202E(this._flandreSpellCircle, null) ? 348523506U : 732254902U) ^ (num3 * 979425709U));
							continue;
						case 1U:
							num2 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u200B\u206A\u200D\u206E\u206A\u202A\u202E\u200D\u200C\u200C\u202D\u206E\u202D\u202C\u202E\u200C\u206D\u200D\u202D\u200E\u206F\u200F\u202B\u200C\u200C\u200D\u206B\u206E\u206D\u202A\u206C\u202A\u202D\u206F\u202E\u200B\u202E\u202A\u200D\u200E\u202E(this._flandreSpellCircle, null)) ? 1597672135U : 1424190212U) ^ (num3 * 3113055236U));
							continue;
						case 3U:
							return;
						case 4U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<set_FlandreSpellCircle>g__coroutine|164_0());
							num2 = (int)((num3 * 336373830U) ^ 2030601135U);
							continue;
						case 5U:
							goto IL_0003;
						case 6U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<set_FlandreSpellCircle>g__coroutine1|164_1());
							num2 = (int)((num3 * 1642575618U) ^ 1651382666U);
							continue;
						case 7U:
							goto IL_0045;
						}
						break;
					}
					return;
					IL_0003:
					num2 = 1285994493;
					goto IL_0008;
					IL_0045:
					num2 = ((!value) ? 398799044 : 816786134);
					goto IL_0008;
				}
			}

			public int Madness
			{
				get
				{
					return this._madness;
				}
				set
				{
					this._madness = FlandrePlayerUnitDef.FlandrePlayerUnit.\u206C\u202A\u200D\u200D\u200C\u206B\u206F\u206E\u200D\u206B\u200C\u202D\u206F\u206C\u206C\u202C\u200C\u200E\u206D\u206A\u200D\u200D\u202A\u206E\u200D\u202A\u200E\u202B\u206F\u202E\u202A\u202E\u202A\u206C\u202E\u200B\u202D\u200E\u206F\u206A\u202E(value, 0, this.FlandreSong ? 198 : 200);
					FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<set_Madness>g__coroutine|173_0());
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnterGameRun(GameRunController gameRun)
			{
				if (BepinexPlugin.FlandreSeedofCorruption)
				{
					goto IL_000A;
				}
				goto IL_00BC;
				int num2;
				for (;;)
				{
					IL_000F:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((num ^ -(-1971820421 + 260062166 - (29831370 - 682095504))) - -215624635 * (-498663651 * -1990871374))) % 9U)
					{
					case 0U:
						goto IL_000A;
					case 1U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__coroutine|182_0());
						num2 = (int)((num3 * 2036706205U) ^ 3428244848U);
						continue;
					case 2U:
						base.HandleGameRunEvent<DieEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u202A\u206E\u206B\u202E\u206A\u202A\u202B\u202B\u202E\u206B\u202B\u206A\u200E\u202E\u202D\u200F\u202A\u206C\u200D\u202E\u200C\u202B\u200C\u202B\u206E\u206E\u202B\u200C\u206C\u206B\u206C\u206E\u202C\u206E\u206D\u200F\u200C\u206B\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u206D\u200C\u202A\u202A\u200D\u202A\u200B\u206A\u202A\u202B\u202B\u200D\u206F\u206E\u202E\u202E\u206E\u202D\u200B\u200C\u206C\u200F\u206A\u202C\u202D\u206A\u206F\u200C\u200D\u200C\u202D\u202D\u202D\u202E\u206A\u206B\u200B\u202E\u202A\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this))), delegate(DieEventArgs args)
						{
							if (!FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u206B\u202C\u200B\u200C\u202B\u202D\u202D\u202D\u206B\u200F\u200C\u206A\u206F\u206F\u206A\u200B\u202B\u200B\u202B\u206F\u206C\u206A\u200C\u202E\u202C\u200B\u200D\u202A\u206F\u202C\u206A\u202C\u202A\u200E\u202D\u200C\u202A\u200B\u206A\u202E(args))
							{
								for (;;)
								{
									IL_0008:
									int num4 = -759962815;
									for (;;)
									{
										int num5 = num4;
										uint num6;
										switch ((num6 = (uint)(-(uint)(-(uint)(-(uint)num5)))) % 4U)
										{
										case 0U:
											FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, FlandrePlayerUnitDef.FlandrePlayerUnit.<OnEnterGameRun>g__coroutine|182_15());
											num4 = (int)((num6 * 1445196370U) ^ 2014868491U);
											continue;
										case 2U:
											goto IL_0008;
										case 3U:
											num4 = (int)(((!this.MadnessPNR) ? 3763131373U : 3747564410U) ^ (num6 * 31723362U));
											continue;
										}
										goto Block_1;
									}
								}
								Block_1:;
							}
						}, GameEventPriority.Lowest);
						num2 = (int)((num3 * 2562472920U) ^ 1608010468U);
						continue;
					case 4U:
						goto IL_00E8;
					case 5U:
						base.HandleGameRunEvent<StationEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u200E\u200E\u200E\u200F\u202C\u200D\u200D\u202D\u200B\u200C\u200E\u200F\u206C\u200E\u202B\u206C\u202D\u206A\u200F\u200B\u206D\u200D\u206C\u200E\u206E\u200D\u200E\u200C\u206E\u200F\u206F\u200E\u206E\u206F\u200F\u200F\u206B\u206E\u206E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)), delegate(StationEventArgs _)
						{
							this.BossStationFinished = false;
							for (;;)
							{
								IL_0007:
								int num7 = -1884354748;
								for (;;)
								{
									int num8 = num7;
									uint num9;
									switch ((num9 = (uint)((~1676872089 + (-417556080 + 1411893783) - (num8 + (-448511073 ^ 191427153 ^ (-1920874848 ^ -616377667)) * 1358641509)) ^ (1488624711 * -1815020577))) % 12U)
									{
									case 0U:
										FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__coroutine|182_13());
										num7 = (int)((num9 * 1219674239U) ^ 3707993689U);
										continue;
									case 1U:
										num7 = (int)((num9 * 1753317701U) ^ 2222930189U);
										continue;
									case 2U:
										FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Return|182_14());
										num7 = (int)((num9 * 2900658494U) ^ 1761832289U);
										continue;
									case 3U:
										num7 = (int)(((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u200C\u202A\u206C\u206D\u206C\u202D\u200D\u200E\u202D\u202E\u200E\u200E\u202A\u200F\u200E\u202C\u200E\u206B\u206E\u200F\u202B\u202A\u206B\u200E\u200F\u206A\u202C\u206C\u202D\u202A\u206F\u200C\u200E\u202C\u202E\u200F\u202B\u206B\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)) is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination) ? 881058269U : 546491401U) ^ (num9 * 914363492U));
										continue;
									case 4U:
										num7 = ((!this.MadnessPNR) ? (-1614201273) : (-1696339356));
										continue;
									case 5U:
										UiManager.GetPanel<ShowCardsPanel>().characterPortraits[FlandrePlayerUnitDef.FlandrePlayerUnit.\u202B\u202B\u206F\u202D\u202E\u200C\u202C\u206E\u202A\u206B\u202E\u200C\u200D\u200D\u206C\u200E\u200E\u200C\u206C\u206F\u200D\u206E\u202E\u200C\u202C\u206D\u202D\u206D\u206C\u200D\u206D\u202E\u206C\u206C\u200F\u200C\u200E\u200C\u206F\u200C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u206C\u202E\u206B\u206D\u200C\u206B\u202B\u200F\u206A\u200B\u202C\u200B\u202E\u206D\u206B\u200F\u206C\u206F\u202E\u200F\u202A\u206F\u206B\u202E\u202D\u206B\u206A\u206A\u202E\u206A\u202C\u202C\u200E\u206D\u200F\u200B\u200B\u200D\u200C\u202E(this))] = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1119500273));
										num7 = (int)((num9 * 2919311463U) ^ 3245193235U);
										continue;
									case 6U:
										this.Madness -= this.MadnessDecay;
										num7 = (int)((num9 * 3164566324U) ^ 1818430639U);
										continue;
									case 7U:
									{
										UnitView view = this.GetView<UnitView>();
										if (view == null || FlandrePlayerUnitDef.FlandrePlayerUnit.\u202A\u200C\u202A\u200D\u202C\u200B\u200F\u200B\u200D\u206F\u206B\u202C\u202E\u200C\u202C\u206E\u202D\u202B\u206E\u206E\u200E\u200F\u200C\u206A\u206C\u202A\u206F\u202E\u202C\u206F\u202D\u200D\u202B\u206D\u200C\u202B\u200D\u206F\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206E\u202A\u206A\u200D\u202E\u206E\u200E\u206E\u206C\u200F\u206F\u200C\u202D\u202A\u200B\u206F\u200E\u202A\u202E\u202E\u202C\u206E\u200B\u202A\u202C\u206F\u206A\u200D\u202C\u206B\u200E\u200E\u202B\u202D\u206A\u202E\u202E\u206E\u202C\u200F\u202E(view)).x != 0f)
										{
											num7 = -416779865;
											continue;
										}
										break;
									}
									case 9U:
										goto IL_0007;
									case 10U:
										this.UpdatePortrait();
										num7 = (int)((num9 * 780820758U) ^ 3264683786U);
										continue;
									case 11U:
										this.UpdateSprite();
										this.GetView<UnitView>()._spellPortrait = BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2067357292));
										FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(793500322)));
										num7 = -66030014;
										continue;
									}
									return;
								}
							}
						});
						base.HandleGameRunEvent<StationEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u200E\u202B\u202B\u202A\u202B\u200C\u200E\u202A\u200E\u202D\u202D\u206C\u202D\u206D\u202E\u202E\u202B\u206A\u206D\u202B\u202C\u206D\u200D\u202C\u206B\u200B\u206C\u206D\u206B\u200D\u206D\u200F\u202D\u200F\u200E\u206A\u202E\u206C\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)), delegate(StationEventArgs args)
						{
							BossStation bossStation = FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u206C\u200B\u206B\u202E\u206F\u200F\u202E\u206C\u206B\u202D\u200F\u200B\u200F\u200C\u202E\u200D\u202B\u200E\u200E\u200F\u202E\u200E\u206B\u206E\u202E\u202D\u200F\u202A\u202E\u206B\u206F\u202B\u202B\u202A\u200C\u206D\u206E\u206B\u202A\u202E(args) as BossStation;
							if (bossStation != null)
							{
								for (;;)
								{
									IL_0012:
									int num10 = -1686987288;
									for (;;)
									{
										int num11 = num10;
										uint num12;
										switch ((num12 = (uint)(~(uint)((num11 ^ (1259277879 * ((-1379994543 ^ -1620401763) + --1024329177))) + ~(~-1743680684) + ~1457665560))) % 49U)
										{
										case 0U:
										{
											ConfigEntry<string> ayaRecords = BepinexPlugin.AyaRecords;
											ayaRecords.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1098298317) : <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1398421241));
											num10 = -1464203061;
											continue;
										}
										case 1U:
										{
											ConfigEntry<string> ayaRecords2 = BepinexPlugin.AyaRecords;
											ayaRecords2.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords2.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(318978944) : <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1270310484));
											num10 = -1754861644;
											continue;
										}
										case 2U:
										{
											string text;
											num10 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1521396416))) ? 4171371849U : 708100295U) ^ (num12 * 2527005006U));
											continue;
										}
										case 3U:
											goto IL_0450;
										case 4U:
											num10 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-802966474))) ? (-1875272322) : 1514212773);
											continue;
										case 5U:
											num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1746413144)) ? 1307402236 : (-1693384880));
											continue;
										case 6U:
											num10 = (int)((BepinexPlugin.AyaPhantasmMode.Value ? 3098914627U : 2173151493U) ^ (num12 * 4182156194U));
											continue;
										case 7U:
											num10 = (int)((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1784914516)) ? 1407468114U : 3150876529U) ^ (num12 * 3509198151U));
											continue;
										case 8U:
										{
											ConfigEntry<string> ayaRecords3 = BepinexPlugin.AyaRecords;
											ayaRecords3.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords3.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2054957954) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-173787288));
											num10 = 1287391442;
											continue;
										}
										case 9U:
											num10 = ((!BepinexPlugin.AyaPhantasmMode.Value) ? (-1754861644) : (-1134334337));
											continue;
										case 10U:
											num10 = (int)((num12 * 2244264559U) ^ 1525984807U);
											continue;
										case 11U:
											num10 = (int)(((!this.FlandreSong) ? 224037299U : 156864484U) ^ (num12 * 3495927189U));
											continue;
										case 12U:
											num10 = ((!BepinexPlugin.AyaPhantasmMode.Value) ? (-1754861644) : 1701173929);
											continue;
										case 13U:
											goto IL_0403;
										case 14U:
											num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1277107117)) ? 1862917907 : 2123335386);
											continue;
										case 15U:
											this.FlandreSong = false;
											num10 = (int)((num12 * 1807829108U) ^ 3000461388U);
											continue;
										case 16U:
										{
											ConfigEntry<string> ayaRecords4 = BepinexPlugin.AyaRecords;
											ayaRecords4.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords4.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-681305795) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2091312484));
											num10 = 1862917907;
											continue;
										}
										case 17U:
											return;
										case 18U:
											goto IL_0012;
										case 19U:
											this.UpdateSprite();
											num10 = (int)((num12 * 3504639319U) ^ 537660086U);
											continue;
										case 20U:
											num10 = (int)(((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u200B\u200B\u206A\u202C\u202A\u202D\u202A\u206F\u200C\u200D\u200E\u206F\u200D\u200C\u206D\u200C\u200C\u202E\u202C\u206E\u206D\u202B\u202C\u206F\u200F\u202B\u200B\u200C\u202B\u202E\u206D\u202A\u200F\u200E\u206D\u202A\u206F\u200C\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u206A\u200E\u202B\u202A\u206C\u206D\u202D\u206E\u200E\u206C\u202E\u202A\u202D\u200E\u202D\u206E\u200D\u202B\u200D\u202C\u202A\u202E\u200E\u206D\u200F\u202C\u202B\u202B\u200C\u206D\u200F\u202B\u206B\u200E\u202E\u206D\u200D\u200E\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this))) == 7) ? 3067546966U : 1787485279U) ^ (num12 * 520889210U));
											continue;
										case 21U:
											num10 = (int)((num12 * 1463451668U) ^ 3870610491U);
											continue;
										case 22U:
										{
											string text;
											num10 = (int)((FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1423706636)) ? 1104546239U : 2395691672U) ^ (num12 * 958312575U));
											continue;
										}
										case 23U:
										{
											ConfigEntry<string> ayaRecords5 = BepinexPlugin.AyaRecords;
											ayaRecords5.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords5.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-681305795) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-242575671));
											num10 = -1462621379;
											continue;
										}
										case 24U:
											num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(753968303)) ? 1862917907 : 1788835620);
											continue;
										case 25U:
											FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2070739331)));
											num10 = (int)((num12 * 634378010U) ^ 3728933724U);
											continue;
										case 26U:
										{
											string text = FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202D\u200E\u202A\u206F\u206A\u206C\u202A\u202E\u206C\u200F\u206C\u200F\u206C\u200D\u202A\u202B\u200E\u202E\u202B\u202D\u202D\u206B\u202A\u200B\u206D\u202E\u200D\u200E\u200C\u200E\u200D\u200E\u200B\u200E\u200E\u206F\u200F\u200B\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u200C\u206C\u206A\u202A\u200F\u206C\u202A\u206B\u202D\u200D\u206A\u200E\u202E\u206E\u206F\u200E\u200F\u206E\u206F\u202D\u206C\u200D\u202B\u200F\u206F\u206D\u202E\u200E\u206D\u202C\u202B\u200E\u202D\u206A\u202A\u202E\u200D\u206C\u202C\u202E(bossStation));
											num10 = -1866938966;
											continue;
										}
										case 27U:
										{
											ConfigEntry<string> ayaRecords6 = BepinexPlugin.AyaRecords;
											ayaRecords6.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords6.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1784773496) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-242575671));
											num10 = 1855338118;
											continue;
										}
										case 28U:
											return;
										case 29U:
										{
											ConfigEntry<string> ayaRecords7 = BepinexPlugin.AyaRecords;
											ayaRecords7.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords7.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1982986125) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-439923883));
											num10 = 1307402236;
											continue;
										}
										case 30U:
											num10 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(308264794))) ? 2678423165U : 1313876834U) ^ (num12 * 3616302394U));
											continue;
										case 31U:
											num10 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u200C\u202E\u206B\u206A\u206D\u202B\u200B\u202A\u206F\u206E\u202C\u202B\u206D\u202B\u202D\u206D\u202D\u206E\u206F\u200D\u206F\u200F\u206B\u200D\u200B\u202E\u202D\u206F\u206D\u206F\u200E\u202D\u200F\u206A\u202D\u206E\u206F\u200F\u200C\u202E(bossStation)) ? 1862917907 : 532580595);
											continue;
										case 33U:
											goto IL_017A;
										case 34U:
										{
											ConfigEntry<string> ayaRecords8 = BepinexPlugin.AyaRecords;
											ayaRecords8.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords8.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1702284757) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1060296174));
											num10 = 1862917907;
											continue;
										}
										case 35U:
										{
											ConfigEntry<string> ayaRecords9 = BepinexPlugin.AyaRecords;
											ayaRecords9.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords9.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1450811160) : <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1054837648));
											num10 = -1704481097;
											continue;
										}
										case 36U:
											goto IL_0233;
										case 37U:
											num10 = (BepinexPlugin.AyaPhantasmMode.Value ? 1324057198 : (-1754861644));
											continue;
										case 38U:
										{
											ConfigEntry<string> ayaRecords10 = BepinexPlugin.AyaRecords;
											ayaRecords10.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords10.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-703201944) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(412183985));
											num10 = 1514212773;
											continue;
										}
										case 39U:
										{
											ConfigEntry<string> ayaRecords11 = BepinexPlugin.AyaRecords;
											ayaRecords11.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords11.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1673853771) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2080244895));
											num10 = -1592535827;
											continue;
										}
										case 40U:
										{
											ConfigEntry<string> ayaRecords12 = BepinexPlugin.AyaRecords;
											ayaRecords12.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords12.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-740064647) : <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(841337344));
											num10 = 1635476534;
											continue;
										}
										case 41U:
											this.BossStationFinished = true;
											num10 = (int)((num12 * 1508719042U) ^ 3354022059U);
											continue;
										case 42U:
											num10 = ((!this.MadnessPNR) ? 1159189221 : (-1608859152));
											continue;
										case 43U:
											switch (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u202A\u202A\u200D\u206D\u206D\u202B\u202A\u202E\u206F\u202D\u200B\u202A\u200B\u206B\u200B\u200F\u206E\u202D\u200D\u202E\u206E\u200E\u202C\u202B\u206C\u206C\u202D\u206A\u206A\u200B\u200D\u200D\u206A\u202A\u200C\u206A\u200E\u206E\u202A\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)))
											{
											case GameDifficulty.Normal:
												goto IL_0450;
											case GameDifficulty.Hard:
												goto IL_0403;
											case GameDifficulty.Lunatic:
												goto IL_0233;
											default:
												num10 = (int)((num12 * 3368190747U) ^ 1868297821U);
												continue;
											}
											break;
										case 44U:
										{
											string text;
											num10 = (int)((FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1746413144)) ? 1909013585U : 2027452450U) ^ (num12 * 2832543751U));
											continue;
										}
										case 45U:
											num10 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1606930955))) ? (-2126772239) : 1287391442);
											continue;
										case 46U:
											num10 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1672944078))) ? 1312509145 : 1635476534);
											continue;
										case 47U:
											num10 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(574401389))) ? 3555880206U : 3638983012U) ^ (num12 * 1295650742U));
											continue;
										case 48U:
											num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1103491133)) ? (-1704481097) : (-1732940168));
											continue;
										}
										goto Block_1;
										IL_0233:
										num10 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1585543215))) ? (-1380231263) : (-1462621379));
										continue;
										IL_0403:
										num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-681305795)) ? 1855338118 : (-1137167984));
										continue;
										IL_0450:
										num10 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-681305795)) ? 1862917907 : (-1119004716));
									}
								}
								Block_1:
								return;
								IL_017A:
								ConfigEntry<string> ayaRecords13 = BepinexPlugin.AyaRecords;
								ayaRecords13.Value = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(ayaRecords13.Value, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-35307470) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1814108300));
								return;
							}
						});
						base.HandleGameRunEvent<DamageEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206C\u206D\u206E\u206A\u200B\u200E\u202D\u206A\u206A\u200D\u206C\u202A\u202E\u206B\u202D\u200E\u200B\u200F\u206C\u202C\u200D\u206B\u200E\u200D\u202E\u200E\u206C\u206F\u206C\u206F\u200B\u200B\u200E\u206E\u200B\u206D\u200B\u202C\u206A\u200D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u206D\u200C\u202A\u202A\u200D\u202A\u200B\u206A\u202A\u202B\u202B\u200D\u206F\u206E\u202E\u202E\u206E\u202D\u200B\u200C\u206C\u200F\u206A\u202C\u202D\u206A\u206F\u200C\u200D\u200C\u202D\u202D\u202D\u202E\u206A\u206B\u200B\u202E\u202A\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this))), delegate(DamageEventArgs _)
						{
							this.UpdatePortrait();
							if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u200B\u200C\u202B\u206C\u202C\u206C\u200E\u206C\u200D\u206F\u202B\u202A\u200E\u202E\u200F\u200E\u206C\u202C\u202C\u202C\u200F\u206D\u206D\u200C\u202D\u200D\u206B\u200F\u206C\u206A\u202E\u202A\u200D\u206D\u200E\u206D\u202B\u200E\u206B\u202C\u202E(this))
							{
								for (;;)
								{
									IL_0011:
									int num13 = 633645541;
									for (;;)
									{
										int num14 = num13;
										uint num15;
										switch ((num15 = (uint)((num14 - ~(-1953114473 * 1190184289) - -(-1019675795) - -860824248) ^ -1459538798)) % 5U)
										{
										case 0U:
											if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer)) == (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSprite) || FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpMid) || FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpLow)))
											{
												num13 = 1566846826;
												continue;
											}
											break;
										case 1U:
											this.UpdateSprite();
											num13 = (int)((num15 * 1562561746U) ^ 3494579521U);
											continue;
										case 2U:
											goto IL_0011;
										case 3U:
										{
											UnitView view2 = this.GetView<UnitView>();
											if (view2 != null && view2._status == UnitView.ShootStatus.Idle)
											{
												num13 = -458919598;
												continue;
											}
											break;
										}
										}
										goto Block_1;
									}
								}
								Block_1:;
							}
						});
						base.HandleGameRunEvent<HealEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206B\u200B\u200E\u200B\u206B\u200D\u200C\u202E\u206F\u206E\u200C\u206F\u206A\u200B\u206A\u206F\u206B\u202D\u206C\u200B\u206A\u206C\u206B\u202E\u206E\u202E\u200F\u200F\u202D\u206A\u202D\u202B\u200D\u202E\u202B\u206F\u202B\u200C\u200B\u206F\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u206D\u200C\u202A\u202A\u200D\u202A\u200B\u206A\u202A\u202B\u202B\u200D\u206F\u206E\u202E\u202E\u206E\u202D\u200B\u200C\u206C\u200F\u206A\u202C\u202D\u206A\u206F\u200C\u200D\u200C\u202D\u202D\u202D\u202E\u206A\u206B\u200B\u202E\u202A\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this))), delegate(HealEventArgs _)
						{
							this.UpdatePortrait();
							if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u200B\u200C\u202B\u206C\u202C\u206C\u200E\u206C\u200D\u206F\u202B\u202A\u200E\u202E\u200F\u200E\u206C\u202C\u202C\u202C\u200F\u206D\u206D\u200C\u202D\u200D\u206B\u200F\u206C\u206A\u202E\u202A\u200D\u206D\u200E\u206D\u202B\u200E\u206B\u202C\u202E(this))
							{
								for (;;)
								{
									IL_0011:
									int num16 = 1786762112;
									for (;;)
									{
										int num17 = num16;
										uint num18;
										switch ((num18 = (uint)(-(uint)(-(uint)(-(uint)(~(uint)num17))))) % 5U)
										{
										case 1U:
											if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer)) == (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSprite) || FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpMid) || FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpLow)))
											{
												num16 = 1778750961;
												continue;
											}
											break;
										case 2U:
											this.UpdateSprite();
											num16 = (int)((num18 * 3807109256U) ^ 1204683506U);
											continue;
										case 3U:
										{
											UnitView view3 = this.GetView<UnitView>();
											if (view3 != null && view3._status == UnitView.ShootStatus.Idle)
											{
												num16 = 422184580;
												continue;
											}
											break;
										}
										case 4U:
											goto IL_0011;
										}
										goto Block_1;
									}
								}
								Block_1:;
							}
						});
						num2 = (int)((num3 * 4189524899U) ^ 4108263178U);
						continue;
					case 6U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200F\u202D\u200F\u202B\u202E\u202D\u200F\u206B\u206D\u206E\u206F\u200D\u206C\u202B\u200B\u200E\u200F\u206B\u202C\u206C\u202D\u206A\u206D\u200C\u206B\u200E\u202D\u206B\u202D\u206B\u206D\u206F\u206E\u200F\u202E\u202B\u200B\u200F\u202E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)._stages.TryGetValue(1)).Remove(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u202A\u200B\u206E\u202B\u206C\u200E\u206F\u202D\u202C\u200F\u206E\u206D\u206A\u200B\u202B\u200E\u206F\u206E\u206D\u206B\u200F\u206A\u200B\u206F\u200F\u200B\u200D\u200E\u206F\u200E\u202E\u206A\u202B\u202C\u200B\u200C\u206A\u202E\u200D\u202E(typeof(RemiliaMeet).TypeHandle), true);
						num2 = (int)((num3 * 3022890412U) ^ 4121731332U);
						continue;
					case 7U:
					{
						Stage stage = FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)._stages.TryGetValue(1);
						bool flag;
						if (stage == null)
						{
							flag = false;
						}
						else
						{
							flag = FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u200D\u206C\u206D\u206A\u206F\u200D\u206F\u200C\u206E\u200B\u200C\u206F\u200F\u200C\u206E\u206C\u202D\u202D\u202A\u202D\u206B\u206D\u206B\u206D\u206C\u200F\u202E\u202C\u200F\u206C\u200C\u200D\u206E\u202A\u206D\u206A\u206A\u200E\u202B\u202E(stage).Any((RandomPoolEntry<Type> t) => FlandrePlayerUnitDef.FlandrePlayerUnit.<>c.\u200C\u202D\u202C\u202C\u200E\u200E\u206A\u200D\u206D\u206C\u202A\u206B\u202E\u202A\u206E\u200D\u202A\u200F\u202E\u200F\u206E\u206C\u200E\u200C\u202E\u206D\u206C\u202E\u200D\u202E\u200C\u206E\u202A\u202D\u200E\u200C\u206A\u206B\u202C\u206A\u202E(t.Elem, FlandrePlayerUnitDef.FlandrePlayerUnit.<>c.\u206B\u206D\u202E\u200E\u202D\u206B\u200F\u206C\u206E\u206E\u202A\u206E\u202C\u202C\u202E\u206F\u206A\u206C\u206C\u202C\u206A\u200C\u202E\u200C\u206E\u206E\u202B\u206C\u206C\u200E\u206D\u202D\u202E\u206B\u202C\u206D\u206B\u206A\u206D\u202A\u202E(typeof(RemiliaMeet).TypeHandle)));
						}
						if (flag)
						{
							num2 = -1547579104;
							continue;
						}
						goto IL_00E8;
					}
					case 8U:
						goto IL_00BC;
					}
					break;
					IL_00E8:
					GameRunController gameRunController = FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this);
					FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u206D\u202E\u200F\u206D\u206B\u202E\u206F\u206C\u200D\u202E\u206D\u202A\u200B\u206A\u200B\u202A\u202A\u200E\u206E\u206A\u206F\u206F\u202A\u202B\u202A\u202D\u206D\u206B\u200E\u202A\u202D\u206B\u206C\u200F\u206A\u202A\u206F\u206C\u202C\u202E(gameRunController, FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u200E\u200C\u200C\u202C\u200D\u202D\u202D\u206C\u200E\u202B\u200E\u200C\u202D\u200C\u202D\u200F\u200C\u202A\u206C\u206A\u206C\u202E\u200B\u200C\u202A\u206E\u200B\u200B\u202D\u200B\u202E\u202D\u206E\u200B\u200F\u200B\u200E\u202A\u202D\u202E(gameRunController) + 1);
					FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u206F\u206E\u206F\u200E\u200B\u202E\u202D\u200B\u200C\u200E\u202C\u206A\u200E\u202E\u202D\u206F\u200C\u200E\u202E\u200B\u200C\u202D\u202E\u200C\u202B\u202E\u202E\u206C\u200E\u206A\u206C\u206F\u200D\u206C\u200E\u200D\u202E\u200F\u206F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1272298239)).Value2 = new int?(0);
					num2 = 1199646670;
				}
				return;
				IL_000A:
				num2 = 1463871210;
				goto IL_000F;
				IL_00BC:
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Init|182_1());
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Timer|182_2());
				num2 = 1546766123;
				goto IL_000F;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdatePortrait()
			{
				if (this.MadnessPNR)
				{
					goto IL_000B;
				}
				goto IL_016F;
				int num2;
				for (;;)
				{
					IL_0010:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(~(uint)(-(uint)(~(uint)(-(uint)num))))) % 14U)
					{
					case 0U:
						return;
					case 1U:
						goto IL_01D1;
					case 2U:
						num2 = (((float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200D\u206F\u200C\u200E\u206D\u202D\u206E\u202A\u202B\u200B\u200F\u202D\u206B\u202D\u206C\u202B\u202A\u202E\u206D\u206E\u202E\u200C\u202A\u202D\u200B\u200B\u200E\u200F\u206B\u200F\u206F\u206B\u200E\u206D\u202E\u206F\u200F\u200D\u202E\u202E(this) / (float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this) <= 0.33f) ? 458476452 : 1290757167);
						continue;
					case 3U:
						goto IL_000B;
					case 4U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-995556801)));
						num2 = (int)((num3 * 1840542008U) ^ 1850630156U);
						continue;
					case 5U:
						goto IL_021C;
					case 6U:
						return;
					case 7U:
						num2 = ((!this.FlandreSpellCircle) ? 1235721534 : 1895635437);
						continue;
					case 8U:
						goto IL_005D;
					case 10U:
						num2 = (((float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200D\u206F\u200C\u200E\u206D\u202D\u206E\u202A\u202B\u200B\u200F\u202D\u206B\u202D\u206C\u202B\u202A\u202E\u206D\u206E\u202E\u200C\u202A\u202D\u200B\u200B\u200E\u200F\u206B\u200F\u206F\u206B\u200E\u206D\u202E\u206F\u200F\u200D\u202E\u202E(this) / (float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this) <= 0.66f) ? 1624745504 : 1991703846);
						continue;
					case 11U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2070739331)));
						num2 = (int)((num3 * 2286490826U) ^ 2670413370U);
						continue;
					case 12U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-170603842)));
						num2 = 337736025;
						continue;
					case 13U:
						goto IL_016F;
					}
					break;
				}
				return;
				IL_005D:
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(2067357292)));
				return;
				IL_01D1:
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2005089620)));
				return;
				IL_021C:
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-381221219)));
				return;
				IL_000B:
				num2 = 1922679272;
				goto IL_0010;
				IL_016F:
				num2 = (this.FlandreSong ? 1541239013 : 144598211);
				goto IL_0010;
			}

			public void UpdateSprite()
			{
				if (this.MadnessPNR)
				{
					goto IL_000B;
				}
				goto IL_0191;
				int num2;
				for (;;)
				{
					IL_0010:
					int num = num2;
					switch ((((num ^ -(978992464 - --30795049)) - ~(1407185757 * 1483167379)) ^ (262640603 * 1136012671) ^ 1348007219) % 13)
					{
					case 0:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(this.GetView<UnitView>().spriteRenderer, FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpMid ?? FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer));
						num2 = 1838681480;
						continue;
					case 1:
						goto IL_0191;
					case 2:
						num2 = (((float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200D\u206F\u200C\u200E\u206D\u202D\u206E\u202A\u202B\u200B\u200F\u202D\u206B\u202D\u206C\u202B\u202A\u202E\u206D\u206E\u202E\u200C\u202A\u202D\u200B\u200B\u200E\u200F\u206B\u200F\u206F\u206B\u200E\u206D\u202E\u206F\u200F\u200D\u202E\u202E(this) / (float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this) <= 0.33f) ? (-1116348572) : (-1558236091));
						continue;
					case 3:
						num2 = (((float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200D\u206F\u200C\u200E\u206D\u202D\u206E\u202A\u202B\u200B\u200F\u202D\u206B\u202D\u206C\u202B\u202A\u202E\u206D\u206E\u202E\u200C\u202A\u202D\u200B\u200B\u200E\u200F\u206B\u200F\u206F\u206B\u200E\u206D\u202E\u206F\u200F\u200D\u202E\u202E(this) / (float)FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this) > 0.66f) ? (-1155883236) : 1297886429);
						continue;
					case 4:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(this.GetView<UnitView>().spriteRenderer, FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSprite ?? FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer));
						num2 = 1182577824;
						continue;
					case 5:
						goto IL_000B;
					case 6:
						return;
					case 7:
						return;
					case 9:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(this.GetView<UnitView>().spriteRenderer, FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteSing ?? FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer));
						num2 = 1114653451;
						continue;
					case 10:
						return;
					case 11:
						return;
					case 12:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(this.GetView<UnitView>().spriteRenderer, FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteMadness ?? FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer));
						num2 = -2097143387;
						continue;
					}
					break;
				}
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(this.GetView<UnitView>().spriteRenderer, FlandrePlayerUnitUnitModelDef.flandrePlayerUnitSpriteHpLow ?? FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(this.GetView<UnitView>().spriteRenderer));
				return;
				IL_000B:
				num2 = 1518012156;
				goto IL_0010;
				IL_0191:
				num2 = ((!this.FlandreSong) ? 1826906456 : 1800199394);
				goto IL_0010;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnterBattle(BattleController battle)
			{
				if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202D\u200E\u202A\u206F\u206A\u206C\u202A\u202E\u206C\u200F\u206C\u200F\u206C\u200D\u202A\u202B\u200E\u202E\u202B\u202D\u202D\u206B\u202A\u200B\u206D\u202E\u200D\u200E\u200C\u200E\u200D\u200E\u200B\u200E\u200E\u206F\u200F\u200B\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u200F\u206A\u206E\u202A\u206F\u202E\u206C\u202A\u200E\u202D\u202D\u200D\u200E\u206F\u202B\u206A\u206D\u206D\u202D\u206A\u202C\u206C\u200E\u200D\u200B\u200B\u200C\u202A\u206D\u200D\u200E\u202B\u200C\u206B\u202E\u202C\u200C\u206A\u202B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this))), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(249015830)))
				{
					goto IL_0026;
				}
				goto IL_0162;
				int num2;
				for (;;)
				{
					IL_002B:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((num ^ (~(1754923228 - 733534182) ^ (-1144060507 * (-637440788 * -1580297653)))) + -(-1686058480 * 980200171))) % 16U)
					{
					case 0U:
						num2 = (int)(((!BepinexPlugin.FlandreSongFirstTime) ? 116435851U : 1615225390U) ^ (num3 * 3909456283U));
						continue;
					case 1U:
						base.HandleBattleEvent<DamageDealingEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200B\u202D\u200F\u206D\u202B\u202A\u206A\u200B\u202C\u206C\u202C\u206F\u206A\u202E\u200D\u206A\u200B\u200D\u200F\u206C\u206B\u200D\u202C\u200B\u200F\u200E\u206C\u202E\u206D\u206F\u200F\u206C\u200E\u206F\u206F\u200B\u206F\u200B\u202B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u202C\u202E\u206C\u206A\u206F\u202D\u202C\u202D\u200B\u206B\u206E\u202A\u202A\u206B\u206C\u202A\u200B\u206B\u206A\u200B\u206C\u206C\u200F\u202D\u202E\u200B\u200E\u202E\u206D\u202A\u206D\u206B\u206D\u200C\u206B\u206B\u200D\u200B\u202E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this))), new GameEventHandler<DamageDealingEventArgs>(this.OnDamageDealing));
						num2 = (int)((num3 * 3842039485U) ^ 4005794245U);
						continue;
					case 2U:
						num2 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u202D\u200E\u202A\u206F\u206A\u206C\u202A\u202E\u206C\u200F\u206C\u200F\u206C\u200D\u202A\u202B\u200E\u202E\u202B\u202D\u202D\u206B\u202A\u200B\u206D\u202E\u200D\u200E\u200C\u200E\u200D\u200E\u200B\u200E\u200E\u206F\u200F\u200B\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u200F\u206A\u206E\u202A\u206F\u202E\u206C\u202A\u200E\u202D\u202D\u200D\u200E\u206F\u202B\u206A\u206D\u206D\u202D\u206A\u202C\u206C\u200E\u200D\u200B\u200B\u200C\u202A\u206D\u200D\u200E\u202B\u200C\u206B\u202E\u202C\u200C\u206A\u202B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this))), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(899931800))) ? 866971474U : 1212074993U) ^ (num3 * 2304276622U));
						continue;
					case 3U:
						base.ReactBattleEvent<UnitEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200F\u202A\u202E\u200E\u206E\u206B\u202A\u206D\u206E\u200F\u202E\u202A\u206F\u206D\u202B\u200D\u200E\u200D\u206A\u200C\u206E\u206C\u206F\u200B\u202E\u202C\u200C\u202D\u206D\u206A\u206B\u200D\u202C\u206D\u202B\u202D\u206C\u202E\u206E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u202C\u202E\u206C\u206A\u206F\u202D\u202C\u202D\u200B\u206B\u206E\u202A\u202A\u206B\u206C\u202A\u200B\u206B\u206A\u200B\u206C\u206C\u200F\u202D\u202E\u200B\u200E\u202E\u206D\u202A\u206D\u206B\u206D\u200C\u206B\u206B\u200D\u200B\u202E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this))), new Func<UnitEventArgs, IEnumerable<BattleAction>>(this.OnPlayerTurnStarted));
						num2 = -1319189102;
						continue;
					case 4U:
						goto IL_0162;
					case 5U:
						base.ReactBattleEvent<CardUsingEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206E\u202B\u206A\u200B\u200B\u200F\u200E\u200D\u202E\u206E\u200F\u200C\u200D\u206F\u202E\u200F\u202A\u202B\u206D\u202A\u202E\u202B\u202B\u200E\u206B\u200D\u206C\u206E\u202E\u200B\u202A\u202E\u200E\u202D\u206E\u206E\u200E\u206F\u206A\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), new Func<CardUsingEventArgs, IEnumerable<BattleAction>>(this.OnCardUsed));
						num2 = (int)((num3 * 1094243012U) ^ 1776937921U);
						continue;
					case 6U:
						num2 = (int)((AyaMisc.IsValidGameRun(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)) ? 4031875948U : 4060711730U) ^ (num3 * 3601294794U));
						continue;
					case 7U:
						goto IL_0026;
					case 8U:
						base.ReactBattleEvent<CardUsingEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202B\u200E\u202B\u206B\u206B\u206D\u202D\u206A\u206F\u206F\u200E\u200B\u206D\u202A\u206E\u202C\u206D\u202D\u206D\u202E\u206A\u200C\u206A\u206F\u200E\u202C\u206A\u206C\u206E\u202E\u202C\u206F\u200D\u202A\u202A\u200E\u200F\u206C\u200D\u206F\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), new Func<CardUsingEventArgs, IEnumerable<BattleAction>>(this.OnCardUsed));
						num2 = (int)((num3 * 2318949244U) ^ 4037803585U);
						continue;
					case 9U:
						AudioManager.PlayInLayer1(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-226926597));
						num2 = (int)((num3 * 1204390574U) ^ 126250679U);
						continue;
					case 10U:
						num2 = (int)(((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u200C\u202A\u206C\u206D\u206C\u202D\u200D\u200E\u202D\u202E\u200E\u200E\u202A\u200F\u200E\u202C\u200E\u206B\u206E\u200F\u202B\u202A\u206B\u200E\u200F\u206A\u202C\u206C\u202D\u202A\u206F\u200C\u200E\u202C\u202E\u200F\u202B\u206B\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)) is FinalStage) ? 2695798408U : 2002594160U) ^ (num3 * 2390302571U));
						continue;
					case 11U:
						num2 = (int)(((!(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u206F\u202A\u202E\u200D\u206A\u202B\u206B\u206F\u206B\u202E\u200C\u202A\u202D\u202D\u200C\u202E\u206B\u206F\u200F\u200E\u206A\u200F\u202C\u200B\u202D\u200D\u206B\u200F\u200E\u202D\u200B\u202C\u202A\u206C\u206D\u200B\u202B\u206A\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(this)) is BossStation)) ? 2449559152U : 2314481265U) ^ (num3 * 2234608026U));
						continue;
					case 12U:
						base.ReactBattleEvent<GameEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u206C\u206C\u206A\u206B\u206D\u200B\u206C\u200D\u206A\u206F\u200E\u206C\u202B\u206C\u200B\u206A\u200C\u202D\u202D\u206F\u206C\u206E\u200E\u206B\u200F\u202E\u206E\u206A\u206E\u206C\u202B\u200B\u206C\u206F\u202E\u200F\u200F\u202A\u200D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleEnding));
						num2 = (int)((num3 * 3859043034U) ^ 1729981499U);
						continue;
					case 13U:
						base.ReactBattleEvent<GameEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202A\u206A\u202E\u200E\u202D\u202A\u202C\u206B\u202C\u200C\u202D\u202A\u206D\u206E\u202D\u202D\u206E\u206B\u200B\u200C\u206A\u202D\u206A\u200E\u206A\u206A\u202C\u200F\u200D\u202E\u200D\u202A\u206B\u206E\u202D\u200E\u200F\u206B\u200D\u202D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.FlandreSongIntro), (GameEventPriority)99);
						num2 = (int)((num3 * 2954618914U) ^ 1579220052U);
						continue;
					case 15U:
						base.HandleBattleEvent<BlockShieldEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202C\u200C\u202B\u200B\u206A\u206A\u200C\u206D\u202E\u202D\u200B\u206B\u206F\u200D\u202B\u200C\u206D\u202A\u206D\u200F\u200E\u206B\u206B\u202A\u200B\u200C\u200B\u200E\u206C\u202C\u202D\u200B\u206F\u200E\u206A\u206E\u202E\u202B\u202D\u202D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u202C\u202E\u206C\u206A\u206F\u202D\u202C\u202D\u200B\u206B\u206E\u202A\u202A\u206B\u206C\u202A\u200B\u206B\u206A\u200B\u206C\u206C\u200F\u202D\u202E\u200B\u200E\u202E\u206D\u202A\u206D\u206B\u206D\u200C\u206B\u206B\u200D\u200B\u202E\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this))), new GameEventHandler<BlockShieldEventArgs>(this.OnBlockShieldGaining));
						num2 = (int)((num3 * 994262671U) ^ 1687752397U);
						continue;
					}
					break;
				}
				return;
				IL_0026:
				num2 = -1315918636;
				goto IL_002B;
				IL_0162:
				base.ReactBattleEvent<GameEventArgs>(FlandrePlayerUnitDef.FlandrePlayerUnit.\u202A\u206A\u202E\u200E\u202D\u202A\u202C\u206B\u202C\u200C\u202D\u202A\u206D\u206E\u202D\u202D\u206E\u206B\u200B\u200C\u206A\u202D\u206A\u200E\u206A\u206A\u202C\u200F\u200D\u202E\u200D\u202A\u206B\u206E\u202D\u200E\u200F\u206B\u200D\u202D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
				num2 = 1824079191;
				goto IL_002B;
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<OnBattleStarted>d__187 <OnBattleStarted>d__ = new FlandrePlayerUnitDef.FlandrePlayerUnit.<OnBattleStarted>d__187(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			private IEnumerable<BattleAction> FlandreSongIntro(GameEventArgs args)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<FlandreSongIntro>d__188 <FlandreSongIntro>d__ = new FlandrePlayerUnitDef.FlandrePlayerUnit.<FlandreSongIntro>d__188(-2);
				<FlandreSongIntro>d__.<>4__this = this;
				return <FlandreSongIntro>d__;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void FlandreSongDying(DieEventArgs args)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200E\u202D\u200B\u206D\u206B\u206D\u206A\u206B\u206A\u202A\u202C\u200C\u202C\u200D\u206F\u206B\u200D\u206E\u206A\u206D\u206B\u202A\u206E\u200D\u200C\u200D\u200C\u200F\u206D\u206F\u206F\u202B\u200B\u202E\u206D\u200C\u202B\u202B\u202D\u202E(this, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this), FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(this));
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u206C\u202B\u200F\u206A\u200C\u202B\u200F\u206D\u202D\u206B\u200B\u206C\u206A\u206F\u202E\u202D\u200C\u206A\u202B\u206D\u206D\u202C\u206B\u202B\u200E\u200D\u206B\u200D\u200E\u202B\u206B\u206D\u206F\u206D\u200E\u202E\u200D\u200E\u206E\u202E(this.GetView<UnitView>());
				for (;;)
				{
					IL_001D:
					int num = -759848685;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num2 - ((~1702621539 ^ (-164130142 + 763275158)) - -1800636141)))) % 5U)
						{
						case 0U:
							goto IL_001D;
						case 1U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200B\u202D\u200D\u206E\u202D\u206C\u200D\u202A\u202B\u202D\u202D\u202D\u206E\u202E\u206F\u202A\u206B\u206E\u200D\u200C\u202E\u200F\u200E\u202C\u200E\u200E\u200E\u200F\u206E\u200E\u200C\u206C\u202A\u202E\u200F\u200E\u202E\u200F\u202E\u206F\u202E(args, true);
							num = (int)((num3 * 3485380029U) ^ 2029120044U);
							continue;
						case 3U:
							this.React(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206C\u200B\u200C\u206E\u206C\u206B\u206B\u200F\u206A\u200B\u200D\u206B\u202D\u206E\u202D\u200F\u206A\u202B\u200E\u202E\u206D\u206C\u200E\u202A\u202E\u206E\u200B\u206E\u206F\u200E\u200D\u200B\u200C\u200D\u200D\u202C\u200D\u206B\u202B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202C\u200F\u200C\u202C\u202A\u206B\u206E\u200D\u206E\u202E\u200F\u202D\u202A\u202E\u206E\u202B\u202C\u200D\u200F\u206D\u202E\u202C\u202A\u206A\u202E\u200F\u202E\u206D\u206E\u202E\u202E\u200F\u200B\u202B\u206E\u202D\u202D\u206B\u206E\u202E(this, FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206E\u200D\u202E\u200F\u200B\u206A\u200B\u206A\u200C\u206C\u206E\u206D\u200F\u202A\u202D\u200F\u206E\u200E\u200F\u206D\u206C\u206B\u206E\u200F\u206E\u206E\u200E\u200C\u200E\u202E\u200F\u206A\u202A\u206D\u200E\u206D\u202C\u202D\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)), DamageInfo.HpLose(999f, false), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(723506473), GunType.Single)));
							if (!FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u202B\u206F\u206C\u206D\u200B\u206A\u202B\u202D\u202D\u200F\u200F\u206E\u206C\u206A\u206F\u200C\u206E\u202E\u206C\u206A\u202D\u200D\u206D\u206B\u206B\u202A\u206F\u202C\u200E\u206D\u200C\u206F\u206D\u200C\u202C\u206A\u206A\u206F\u200F\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)))
							{
								num = (int)((num3 * 2488479045U) ^ 4027308360U);
								continue;
							}
							return;
						case 4U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206D\u200F\u206D\u200C\u200D\u206E\u200F\u206F\u202C\u206A\u202B\u202C\u200F\u206E\u202C\u206C\u206F\u200C\u200C\u200B\u200B\u206A\u206D\u200C\u200C\u206E\u206A\u200C\u206E\u202B\u206F\u202A\u200C\u202B\u206E\u200C\u200F\u206B\u206D\u202E(args, this);
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u202B\u202C\u206A\u200E\u206E\u200D\u200D\u202D\u200F\u206C\u202C\u200C\u206D\u202D\u206F\u202C\u206A\u202E\u206B\u206F\u206D\u206C\u206E\u200F\u206A\u206A\u206D\u200D\u202A\u206E\u202A\u202E\u200F\u202A\u202B\u206D\u206B\u202D\u200C\u200D\u202E(this, UnitStatus.Alive);
							num = (int)((num3 * 420009862U) ^ 1764610004U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				using (List<EnemyUnit>.Enumerator enumerator = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206E\u200D\u202E\u200F\u200B\u206A\u200B\u206A\u200C\u206C\u206E\u206D\u200F\u202A\u202D\u200F\u206E\u200E\u200F\u206D\u206C\u206B\u206E\u200F\u206E\u206E\u200E\u200C\u200E\u202E\u200F\u206A\u202A\u206D\u200E\u206D\u202C\u202D\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(this)).ToList<EnemyUnit>().GetEnumerator())
				{
					for (;;)
					{
						IL_014A:
						int num4 = (enumerator.MoveNext() ? (-1335102437) : 105422154);
						for (;;)
						{
							int num2 = num4;
							uint num3;
							switch ((num3 = (uint)(-(uint)(num2 - ((~1702621539 ^ (-164130142 + 763275158)) - -1800636141)))) % 5U)
							{
							case 0U:
								num4 = -1335102437;
								continue;
							case 1U:
								goto IL_014A;
							case 3U:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								num4 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206B\u206D\u200D\u206A\u200D\u200D\u202E\u202C\u202A\u206C\u206B\u206F\u202C\u206D\u202D\u200D\u200C\u200F\u202B\u206F\u206A\u206E\u202B\u206B\u202D\u200F\u200B\u206C\u202C\u200B\u202D\u206F\u202E\u200B\u206D\u200D\u202C\u206F\u200C\u202D\u202E(enemyUnit) ? (-664865898) : (-644960810));
								continue;
							}
							case 4U:
							{
								EnemyUnit enemyUnit;
								this.React(FlandrePlayerUnitDef.FlandrePlayerUnit.\u206C\u200B\u200C\u206E\u206C\u206B\u206B\u200F\u206A\u200B\u200D\u206B\u202D\u206E\u202D\u200F\u206A\u202B\u200E\u202E\u206D\u206C\u200E\u202A\u202E\u206E\u200B\u206E\u206F\u200E\u200D\u200B\u200C\u200D\u200D\u202C\u200D\u206B\u202B\u202E(new ApplyStatusEffectAction<Poison>(enemyUnit, new int?(999), null, null, null, 0.1f, true)));
								num4 = (int)((num3 * 2008935389U) ^ 1909694841U);
								continue;
							}
							}
							goto Block_5;
						}
					}
					Block_5:;
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs arg)
			{
				return new FlandrePlayerUnitDef.FlandrePlayerUnit.<OnPlayerTurnStarted>d__190(-2);
			}

			private void OnBlockShieldGaining(BlockShieldEventArgs args)
			{
				if (FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u200D\u202C\u206D\u202D\u200D\u206A\u200E\u200F\u200F\u202B\u206A\u202C\u206A\u206D\u202E\u206E\u202B\u200F\u202B\u206A\u202D\u200B\u200C\u200E\u200F\u202C\u202B\u206C\u202E\u200B\u202B\u200F\u202D\u202A\u206C\u206F\u200E\u206F\u202B\u202E(args) != ActionCause.Card)
				{
					goto IL_000C;
				}
				goto IL_0117;
				int num2;
				for (;;)
				{
					IL_0011:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(uint)((-716658945 - (-373363657 + 105460533) - (-1336945478 - 45087103) * -585293333 - num) ^ (274898273 * (-1088836882 - 955984410))))) % 9U)
					{
					case 0U:
						num2 = ((!FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u200E\u206D\u206B\u206F\u200F\u200E\u206F\u206C\u206E\u202D\u202B\u202B\u202A\u206F\u206E\u202E\u202B\u206E\u202B\u200E\u200F\u200D\u206A\u202B\u206E\u206D\u202B\u200B\u206E\u200C\u202B\u206B\u202B\u200D\u206E\u206B\u202A\u206D\u206C\u202E(args)) ? 1365082713 : 1904265497);
						continue;
					case 1U:
						return;
					case 2U:
						num2 = (FlandrePlayerUnitDef.FlandrePlayerUnit.\u202B\u200B\u206D\u206F\u202B\u202C\u202E\u202D\u200F\u200E\u200B\u200D\u200F\u202A\u206F\u206C\u206D\u206A\u200E\u200B\u206B\u200E\u202A\u202E\u206A\u200B\u206E\u206B\u206E\u202D\u202A\u206E\u200B\u200F\u206A\u200F\u200C\u202A\u206D\u206B\u202E(args) ? 1860188336 : 1406600623);
						continue;
					case 3U:
						goto IL_0117;
					case 5U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u206E\u206A\u202B\u206D\u200F\u206A\u200F\u200F\u202B\u202E\u202A\u206B\u200E\u206F\u206B\u206A\u206E\u206A\u206D\u206A\u202B\u206D\u202A\u206B\u200C\u206E\u202C\u202D\u202D\u202E\u202D\u202B\u202B\u200F\u200C\u206C\u206D\u206B\u202A\u202E(args, FlandrePlayerUnitDef.FlandrePlayerUnit.\u206F\u202A\u202B\u206E\u206F\u200E\u202A\u206C\u206D\u206E\u202A\u200F\u206D\u206C\u200E\u206A\u200E\u202B\u202D\u200F\u206C\u206C\u200E\u202B\u206C\u206C\u206B\u200D\u206A\u200C\u206D\u206A\u202E\u202B\u206A\u202E\u200F\u206D\u202D\u206F\u202E(args) * (1f - this.MadnessAmount2 / 100f));
						num2 = (int)((num3 * 1976224621U) ^ 2822620421U);
						continue;
					case 6U:
						goto IL_000C;
					case 7U:
						num2 = (int)(((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u200D\u202C\u206D\u202D\u200D\u206A\u200E\u200F\u200F\u202B\u206A\u202C\u206A\u206D\u202E\u206E\u202B\u200F\u202B\u206A\u202D\u200B\u200C\u200E\u200F\u202C\u202B\u206C\u202E\u200B\u202B\u200F\u202D\u202A\u206C\u206F\u200E\u206F\u202B\u202E(args) != ActionCause.OnlyCalculate) ? 2531721869U : 2014756169U) ^ (num3 * 2830556811U));
						continue;
					case 8U:
						FlandrePlayerUnitDef.FlandrePlayerUnit.\u202E\u200C\u206C\u206A\u202A\u206E\u202A\u206D\u202B\u202E\u206C\u202C\u206B\u202C\u200B\u206D\u202C\u202C\u206B\u202E\u202E\u200C\u206A\u206A\u200F\u202E\u206B\u206B\u206A\u200D\u206F\u200D\u200F\u202D\u206C\u200B\u202B\u200F\u206D\u206F\u202E(args, FlandrePlayerUnitDef.FlandrePlayerUnit.\u202D\u200C\u206E\u200F\u206D\u202B\u206A\u200C\u200C\u206B\u206C\u202B\u200C\u202C\u202B\u206A\u202D\u200D\u202E\u202A\u200B\u206A\u202B\u206C\u202E\u206F\u206E\u202D\u200D\u200E\u206E\u206E\u206F\u202D\u200E\u206C\u206A\u200E\u202C\u206F\u202E(args) * (1f - this.MadnessAmount2 / 100f));
						num2 = (int)((num3 * 860485909U) ^ 3632967886U);
						continue;
					}
					break;
				}
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u206C\u200C\u202B\u206D\u200D\u200D\u202C\u206F\u206C\u202A\u202A\u206E\u206D\u206D\u200D\u202D\u200B\u202B\u200E\u200C\u202E\u206C\u202D\u200B\u206D\u202C\u206E\u200F\u202C\u200B\u200F\u200E\u200F\u206A\u206D\u200D\u206D\u200B\u206E\u202E(args, this);
				return;
				IL_000C:
				num2 = 1809191557;
				goto IL_0011;
				IL_0117:
				num2 = ((FlandrePlayerUnitDef.FlandrePlayerUnit.\u206D\u200D\u202D\u206E\u200B\u206C\u200B\u202D\u206A\u206C\u202A\u202A\u200D\u200D\u200D\u200E\u200D\u202B\u206F\u206E\u200E\u202A\u200C\u206D\u200D\u200E\u206B\u202C\u206C\u202D\u206D\u202B\u206A\u206C\u206F\u206D\u200E\u206F\u202D\u202B\u202E(args) == BlockShieldType.Direct) ? (-1840462488) : (-1583211997));
				goto IL_0011;
			}

			private void OnDamageDealing(DamageDealingEventArgs args)
			{
				DamageInfo damageInfo = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200B\u202D\u200D\u206C\u206E\u200B\u206D\u206D\u206F\u200B\u202B\u202E\u206B\u200C\u206B\u206E\u206D\u202E\u200F\u206C\u206D\u206A\u202E\u206E\u200C\u206E\u202E\u202E\u206B\u206B\u206F\u200F\u202B\u206E\u206F\u200B\u200E\u202C\u206E\u200C\u202E(args);
				for (;;)
				{
					IL_0007:
					int num = -1484209825;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(num2 - (-(-529308371 + -63416730) + -283128371)) + (626896589 + 1184156568)))) % 5U)
						{
						case 0U:
							goto IL_0007;
						case 1U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200C\u206C\u200C\u202B\u206D\u200D\u200D\u202C\u206F\u206C\u202A\u202A\u206E\u206D\u206D\u200D\u202D\u200B\u202B\u200E\u200C\u202E\u206C\u202D\u200B\u206D\u202C\u206E\u200F\u202C\u200B\u200F\u200E\u200F\u206A\u206D\u200D\u206D\u200B\u206E\u202E(args, this);
							num = (int)((num3 * 4218446840U) ^ 4047369615U);
							continue;
						case 2U:
							damageInfo.Damage = damageInfo.Amount * (1f + this.MadnessAmount1 / 100f);
							FlandrePlayerUnitDef.FlandrePlayerUnit.\u200F\u202C\u202B\u206C\u206C\u206F\u200E\u202C\u200D\u202C\u200F\u202A\u206A\u206D\u202C\u202E\u202C\u206D\u206F\u200B\u206C\u202B\u206C\u206F\u206E\u206A\u206E\u206C\u202B\u202A\u202B\u202B\u206F\u200B\u200D\u206D\u200C\u200D\u206B\u202A\u202E(args, damageInfo);
							num = (int)((num3 * 2564557145U) ^ 1331181324U);
							continue;
						case 4U:
							num = (int)(((damageInfo.DamageType != DamageType.Attack) ? 2388912191U : 3761035052U) ^ (num3 * 2547013932U));
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs arg)
			{
				return new FlandrePlayerUnitDef.FlandrePlayerUnit.<OnCardUsed>d__193(-2);
			}

			private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<OnBattleEnding>d__194 <OnBattleEnding>d__ = new FlandrePlayerUnitDef.FlandrePlayerUnit.<OnBattleEnding>d__194(-2);
				<OnBattleEnding>d__.<>4__this = this;
				return <OnBattleEnding>d__;
			}

			protected override void OnLeaveBattle()
			{
				GameObject gameObject = FlandrePlayerUnitDef.FlandrePlayerUnit.background;
				if (gameObject == null)
				{
					return;
				}
				FlandrePlayerUnitDef.FlandrePlayerUnit.\u206A\u200B\u206C\u200D\u206D\u206E\u202B\u202D\u200B\u202A\u206C\u202D\u202E\u200E\u200E\u202B\u206B\u206B\u206C\u206B\u202C\u206F\u200E\u202D\u206E\u206C\u202C\u200C\u200B\u206F\u202C\u202D\u202E\u200F\u206C\u206E\u206C\u202E\u206F\u206F\u202E(gameObject, false);
			}

			public UniTask<UnitView> LoadDummyAsync(EnemyUnit child, Unit parent, Action clickAction)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<LoadDummyAsync>d__196 <LoadDummyAsync>d__;
				<LoadDummyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UnitView>.Create();
				for (;;)
				{
					IL_000C:
					int num = -2065089230;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(1486794856 - -(uint)(~num2 - (731022301 * -2069788519 + -1367348447)))) % 7U)
						{
						case 0U:
							<LoadDummyAsync>d__.<>1__state = -1;
							num = (int)((num3 * 1811461806U) ^ 2286019937U);
							continue;
						case 1U:
							<LoadDummyAsync>d__.child = child;
							num = (int)((num3 * 1034942591U) ^ 966214159U);
							continue;
						case 2U:
							<LoadDummyAsync>d__.parent = parent;
							num = (int)((num3 * 631629077U) ^ 1200309312U);
							continue;
						case 3U:
							<LoadDummyAsync>d__.<>t__builder.Start<FlandrePlayerUnitDef.FlandrePlayerUnit.<LoadDummyAsync>d__196>(ref <LoadDummyAsync>d__);
							num = (int)((num3 * 3068160830U) ^ 1122827232U);
							continue;
						case 5U:
							<LoadDummyAsync>d__.clickAction = clickAction;
							num = (int)((num3 * 188694841U) ^ 3366597496U);
							continue;
						case 6U:
							goto IL_000C;
						}
						goto Block_1;
					}
				}
				Block_1:
				return <LoadDummyAsync>d__.<>t__builder.Task;
			}

			[CompilerGenerated]
			private IEnumerator <set_FlandreSpellCircle>g__coroutine|164_0()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_FlandreSpellCircle>g__coroutine|164_0>d <<set_FlandreSpellCircle>g__coroutine|164_0>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_FlandreSpellCircle>g__coroutine|164_0>d(0);
				<<set_FlandreSpellCircle>g__coroutine|164_0>d.<>4__this = this;
				return <<set_FlandreSpellCircle>g__coroutine|164_0>d;
			}

			[CompilerGenerated]
			private IEnumerator <set_FlandreSpellCircle>g__coroutine1|164_1()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_FlandreSpellCircle>g__coroutine1|164_1>d <<set_FlandreSpellCircle>g__coroutine1|164_1>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_FlandreSpellCircle>g__coroutine1|164_1>d(0);
				<<set_FlandreSpellCircle>g__coroutine1|164_1>d.<>4__this = this;
				return <<set_FlandreSpellCircle>g__coroutine1|164_1>d;
			}

			[CompilerGenerated]
			private IEnumerator <set_Madness>g__coroutine|173_0()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_Madness>g__coroutine|173_0>d <<set_Madness>g__coroutine|173_0>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<set_Madness>g__coroutine|173_0>d(0);
				<<set_Madness>g__coroutine|173_0>d.<>4__this = this;
				return <<set_Madness>g__coroutine|173_0>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__coroutine|182_0()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__coroutine|182_0>d <<OnEnterGameRun>g__coroutine|182_0>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__coroutine|182_0>d(0);
				<<OnEnterGameRun>g__coroutine|182_0>d.<>4__this = this;
				return <<OnEnterGameRun>g__coroutine|182_0>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Init|182_1()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Init|182_1>d <<OnEnterGameRun>g__Init|182_1>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Init|182_1>d(0);
				<<OnEnterGameRun>g__Init|182_1>d.<>4__this = this;
				return <<OnEnterGameRun>g__Init|182_1>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Timer|182_2()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Timer|182_2>d <<OnEnterGameRun>g__Timer|182_2>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Timer|182_2>d(0);
				<<OnEnterGameRun>g__Timer|182_2>d.<>4__this = this;
				return <<OnEnterGameRun>g__Timer|182_2>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__coroutine|182_13()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__coroutine|182_13>d <<OnEnterGameRun>g__coroutine|182_13>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__coroutine|182_13>d(0);
				<<OnEnterGameRun>g__coroutine|182_13>d.<>4__this = this;
				return <<OnEnterGameRun>g__coroutine|182_13>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Return|182_14()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Return|182_14>d <<OnEnterGameRun>g__Return|182_14>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__Return|182_14>d(0);
				<<OnEnterGameRun>g__Return|182_14>d.<>4__this = this;
				return <<OnEnterGameRun>g__Return|182_14>d;
			}

			[CompilerGenerated]
			internal static IEnumerator <OnEnterGameRun>g__coroutine|182_15()
			{
				return new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnEnterGameRun>g__coroutine|182_15>d(0);
			}

			[CompilerGenerated]
			internal static IEnumerator <OnBattleEnding>g__coroutine|194_0()
			{
				return new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnBattleEnding>g__coroutine|194_0>d(0);
			}

			[CompilerGenerated]
			private IEnumerator <OnBattleEnding>g__coroutine|194_1()
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnBattleEnding>g__coroutine|194_1>d <<OnBattleEnding>g__coroutine|194_1>d = new FlandrePlayerUnitDef.FlandrePlayerUnit.<<OnBattleEnding>g__coroutine|194_1>d(0);
				<<OnBattleEnding>g__coroutine|194_1>d.<>4__this = this;
				return <<OnBattleEnding>g__coroutine|194_1>d;
			}

			[CompilerGenerated]
			internal static UniTask<UnitView> <LoadDummyAsync>g__LoadDummyAsync|196_0(EnemyUnit child, Unit parent)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit.<<LoadDummyAsync>g__LoadDummyAsync|196_0>d <<LoadDummyAsync>g__LoadDummyAsync|196_0>d;
				<<LoadDummyAsync>g__LoadDummyAsync|196_0>d.<>t__builder = AsyncUniTaskMethodBuilder<UnitView>.Create();
				<<LoadDummyAsync>g__LoadDummyAsync|196_0>d.child = child;
				for (;;)
				{
					IL_0014:
					int num = -1848977036;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-(num2 + ~(~-1623534505))) - -181372864)) % 3U)
						{
						case 0U:
							goto IL_0014;
						case 1U:
							<<LoadDummyAsync>g__LoadDummyAsync|196_0>d.parent = parent;
							<<LoadDummyAsync>g__LoadDummyAsync|196_0>d.<>1__state = -1;
							<<LoadDummyAsync>g__LoadDummyAsync|196_0>d.<>t__builder.Start<FlandrePlayerUnitDef.FlandrePlayerUnit.<<LoadDummyAsync>g__LoadDummyAsync|196_0>d>(ref <<LoadDummyAsync>g__LoadDummyAsync|196_0>d);
							num = (int)((num3 * 3055220444U) ^ 285643336U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				return <<LoadDummyAsync>g__LoadDummyAsync|196_0>d.<>t__builder.Task;
			}

			static bool \u200D\u202E\u202B\u200F\u202A\u206C\u200B\u202B\u202A\u202D\u202C\u202D\u202C\u206D\u206A\u202B\u200C\u206C\u206A\u200F\u200D\u206E\u200F\u206E\u200F\u202C\u202B\u202C\u206B\u206C\u206F\u206B\u200B\u206B\u202A\u206C\u206F\u200D\u206E\u202A\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
			{
				return A_0 != A_1;
			}

			static bool \u200B\u206A\u200D\u206E\u206A\u202A\u202E\u200D\u200C\u200C\u202D\u206E\u202D\u202C\u202E\u200C\u206D\u200D\u202D\u200E\u206F\u200F\u202B\u200C\u200C\u200D\u206B\u206E\u206D\u202A\u206C\u202A\u202D\u206F\u202E\u200B\u202E\u202A\u200D\u200E\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
			{
				return A_0 == A_1;
			}

			static Coroutine \u200C\u202E\u200C\u206A\u206D\u206E\u200D\u206B\u202B\u202D\u206C\u200B\u200F\u200D\u200D\u200C\u206F\u202D\u202D\u202A\u202C\u200F\u206C\u202B\u206A\u200B\u200F\u200D\u202A\u200B\u206C\u200F\u202D\u206F\u206D\u206C\u200D\u206B\u206D\u202D\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static int \u206C\u202A\u200D\u200D\u200C\u206B\u206F\u206E\u200D\u206B\u200C\u202D\u206F\u206C\u206C\u202C\u200C\u200E\u206D\u206A\u200D\u200D\u202A\u206E\u200D\u202A\u200E\u202B\u206F\u202E\u202A\u202E\u202A\u206C\u202E\u200B\u202D\u200E\u206F\u206A\u202E(int A_0, int A_1, int A_2)
			{
				return Math.Clamp(A_0, A_1, A_2);
			}

			static GameRunController \u206A\u202E\u200E\u200B\u200E\u202D\u202B\u202D\u200F\u200C\u206C\u202E\u206D\u200C\u206D\u206A\u206D\u202D\u202E\u206E\u206B\u206A\u202C\u206D\u202E\u206D\u200E\u202E\u202A\u202B\u200C\u206D\u206A\u206F\u202E\u206C\u206F\u200B\u206E\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static GameEvent<StationEventArgs> \u200D\u200E\u200E\u200E\u200F\u202C\u200D\u200D\u202D\u200B\u200C\u200E\u200F\u206C\u200E\u202B\u206C\u202D\u206A\u200F\u200B\u206D\u200D\u206C\u200E\u206E\u200D\u200E\u200C\u206E\u200F\u206F\u200E\u206E\u206F\u200F\u200F\u206B\u206E\u206E\u202E(GameRunController A_0)
			{
				return A_0.StationEntered;
			}

			static GameEvent<StationEventArgs> \u206A\u200E\u202B\u202B\u202A\u202B\u200C\u200E\u202A\u200E\u202D\u202D\u206C\u202D\u206D\u202E\u202E\u202B\u206A\u206D\u202B\u202C\u206D\u200D\u202C\u206B\u200B\u206C\u206D\u206B\u200D\u206D\u200F\u202D\u200F\u200E\u206A\u202E\u206C\u206C\u202E(GameRunController A_0)
			{
				return A_0.StationFinished;
			}

			static PlayerUnit \u206F\u206D\u200C\u202A\u202A\u200D\u202A\u200B\u206A\u202A\u202B\u202B\u200D\u206F\u206E\u202E\u202E\u206E\u202D\u200B\u200C\u206C\u200F\u206A\u202C\u202D\u206A\u206F\u200C\u200D\u200C\u202D\u202D\u202D\u202E\u206A\u206B\u200B\u202E\u202A\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<DamageEventArgs> \u206C\u206D\u206E\u206A\u200B\u200E\u202D\u206A\u206A\u200D\u206C\u202A\u202E\u206B\u202D\u200E\u200B\u200F\u206C\u202C\u200D\u206B\u200E\u200D\u202E\u200E\u206C\u206F\u206C\u206F\u200B\u200B\u200E\u206E\u200B\u206D\u200B\u202C\u206A\u200D\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static GameEvent<HealEventArgs> \u206B\u200B\u200E\u200B\u206B\u200D\u200C\u202E\u206F\u206E\u200C\u206F\u206A\u200B\u206A\u206F\u206B\u202D\u206C\u200B\u206A\u206C\u206B\u202E\u206E\u202E\u200F\u200F\u202D\u206A\u202D\u202B\u200D\u202E\u202B\u206F\u202B\u200C\u200B\u206F\u202E(Unit A_0)
			{
				return A_0.HealingReceived;
			}

			static GameEvent<DieEventArgs> \u200F\u202A\u206E\u206B\u202E\u206A\u202A\u202B\u202B\u202E\u206B\u202B\u206A\u200E\u202E\u202D\u200F\u202A\u206C\u200D\u202E\u200C\u202B\u200C\u202B\u206E\u206E\u202B\u200C\u206C\u206B\u206C\u206E\u202C\u206E\u206D\u200F\u200C\u206B\u206D\u202E(Unit A_0)
			{
				return A_0.Dying;
			}

			static UniqueRandomPool<Type> \u206D\u200D\u206C\u206D\u206A\u206F\u200D\u206F\u200C\u206E\u200B\u200C\u206F\u200F\u200C\u206E\u206C\u202D\u202D\u202A\u202D\u206B\u206D\u206B\u206D\u206C\u200F\u202E\u202C\u200F\u206C\u200C\u200D\u206E\u202A\u206D\u206A\u206A\u200E\u202B\u202E(Stage A_0)
			{
				return A_0.AdventurePool;
			}

			static UniqueRandomPool<Type> \u200F\u200F\u202D\u200F\u202B\u202E\u202D\u200F\u206B\u206D\u206E\u206F\u200D\u206C\u202B\u200B\u200E\u200F\u206B\u202C\u206C\u202D\u206A\u206D\u200C\u206B\u200E\u202D\u206B\u202D\u206B\u206D\u206F\u206E\u200F\u202E\u202B\u200B\u200F\u202E\u202E(Stage A_0)
			{
				return A_0.AdventurePool;
			}

			static Type \u202D\u202A\u200B\u206E\u202B\u206C\u200E\u206F\u202D\u202C\u200F\u206E\u206D\u206A\u200B\u202B\u200E\u206F\u206E\u206D\u206B\u200F\u206A\u200B\u206F\u200F\u200B\u200D\u200E\u206F\u200E\u202E\u206A\u202B\u202C\u200B\u200C\u206A\u202E\u200D\u202E(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			static int \u206A\u200E\u200C\u200C\u202C\u200D\u202D\u202D\u206C\u200E\u202B\u200E\u200C\u202D\u200C\u202D\u200F\u200C\u202A\u206C\u206A\u206C\u202E\u200B\u200C\u202A\u206E\u200B\u200B\u202D\u200B\u202E\u202D\u206E\u200B\u200F\u200B\u200E\u202A\u202D\u202E(GameRunController A_0)
			{
				return A_0.AdditionalRewardCardCount;
			}

			static void \u200F\u206D\u202E\u200F\u206D\u206B\u202E\u206F\u206C\u200D\u202E\u206D\u202A\u200B\u206A\u200B\u202A\u202A\u200E\u206E\u206A\u206F\u206F\u202A\u202B\u202A\u202D\u206D\u206B\u200E\u202A\u202D\u206B\u206C\u200F\u206A\u202A\u206F\u206C\u202C\u202E(GameRunController A_0, int A_1)
			{
				A_0.AdditionalRewardCardCount = A_1;
			}

			static ExhibitConfig \u200C\u206F\u206E\u206F\u200E\u200B\u202E\u202D\u200B\u200C\u200E\u202C\u206A\u200E\u202E\u202D\u206F\u200C\u200E\u202E\u200B\u200C\u202D\u202E\u200C\u202B\u202E\u202E\u206C\u200E\u206A\u206C\u206F\u200D\u206C\u200E\u200D\u202E\u200F\u206F\u202E(string A_0)
			{
				return ExhibitConfig.FromId(A_0);
			}

			static void \u202C\u200F\u200C\u206C\u200E\u206B\u202E\u200D\u200E\u206C\u202A\u200F\u206C\u200E\u200D\u206A\u200C\u206A\u206C\u202A\u206C\u206D\u206A\u206C\u202B\u200F\u206D\u206C\u200F\u202C\u206F\u200E\u202B\u206C\u200E\u206E\u200C\u202C\u202D\u206F\u202E(Image A_0, Sprite A_1)
			{
				A_0.sprite = A_1;
			}

			static int \u200F\u200D\u206F\u200C\u200E\u206D\u202D\u206E\u202A\u202B\u200B\u200F\u202D\u206B\u202D\u206C\u202B\u202A\u202E\u206D\u206E\u202E\u200C\u202A\u202D\u200B\u200B\u200E\u200F\u206B\u200F\u206F\u206B\u200E\u206D\u202E\u206F\u200F\u200D\u202E\u202E(Unit A_0)
			{
				return A_0.Hp;
			}

			static int \u200D\u206B\u206A\u202B\u206B\u202D\u202A\u206F\u206B\u202C\u206F\u206C\u202C\u200B\u200B\u206B\u206C\u200B\u206F\u206F\u202A\u206F\u200B\u202B\u206F\u200B\u200C\u206E\u202D\u200E\u202C\u200F\u200B\u200D\u206A\u202A\u200C\u202E\u200F\u206E\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static Sprite \u200F\u200C\u200E\u200D\u200D\u202A\u200B\u200D\u206E\u200D\u206C\u202D\u200D\u200C\u202B\u200D\u200F\u206A\u206B\u200B\u202B\u202B\u200B\u200D\u202A\u200D\u202C\u202A\u206D\u200B\u202A\u206B\u206B\u206C\u200F\u200C\u202A\u200C\u206E\u206C\u202E(SpriteRenderer A_0)
			{
				return A_0.sprite;
			}

			static void \u200E\u206F\u206E\u200E\u200F\u206C\u206C\u200C\u206D\u206E\u206A\u206F\u206C\u206F\u200B\u206C\u202E\u206F\u202B\u206E\u202A\u202C\u206B\u200D\u206B\u206B\u202C\u202A\u206B\u206F\u206D\u206D\u200B\u200C\u206E\u206E\u206E\u206C\u200D\u202E(SpriteRenderer A_0, Sprite A_1)
			{
				A_0.sprite = A_1;
			}

			static BattleController \u200D\u206C\u200D\u206E\u206E\u200B\u202A\u206F\u206D\u206D\u206F\u200D\u200C\u202E\u200B\u200D\u202B\u206B\u206A\u200B\u206D\u202D\u200B\u200F\u200B\u206D\u206C\u202B\u202D\u206F\u206C\u206E\u202D\u202D\u202B\u200E\u200D\u200C\u202C\u206E\u202E(Unit A_0)
			{
				return A_0.Battle;
			}

			static EnemyGroup \u200D\u200F\u206A\u206E\u202A\u206F\u202E\u206C\u202A\u200E\u202D\u202D\u200D\u200E\u206F\u202B\u206A\u206D\u206D\u202D\u206A\u202C\u206C\u200E\u200D\u200B\u200B\u200C\u202A\u206D\u200D\u200E\u202B\u200C\u206B\u202E\u202C\u200C\u206A\u202B\u202E(BattleController A_0)
			{
				return A_0.EnemyGroup;
			}

			static string \u202E\u202D\u200E\u202A\u206F\u206A\u206C\u202A\u202E\u206C\u200F\u206C\u200F\u206C\u200D\u202A\u202B\u200E\u202E\u202B\u202D\u202D\u206B\u202A\u200B\u206D\u202E\u200D\u200E\u200C\u200E\u200D\u200E\u200B\u200E\u200E\u206F\u200F\u200B\u206B\u202E(EnemyGroup A_0)
			{
				return A_0.Id;
			}

			static bool \u202E\u202E\u200D\u206C\u202B\u200B\u206E\u200F\u206D\u206F\u206E\u206F\u202A\u200F\u202A\u200C\u202D\u200F\u200D\u206F\u202B\u200E\u202B\u206E\u200E\u202D\u206E\u202E\u200F\u200E\u202D\u202B\u202D\u206A\u200C\u206D\u206E\u200F\u200C\u206D\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static GameEvent<GameEventArgs> \u202A\u206A\u202E\u200E\u202D\u202A\u202C\u206B\u202C\u200C\u202D\u202A\u206D\u206E\u202D\u202D\u206E\u206B\u200B\u200C\u206A\u202D\u206A\u200E\u206A\u206A\u202C\u200F\u200D\u202E\u200D\u202A\u206B\u206E\u202D\u200E\u200F\u206B\u200D\u202D\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static Stage \u206F\u200C\u202A\u206C\u206D\u206C\u202D\u200D\u200E\u202D\u202E\u200E\u200E\u202A\u200F\u200E\u202C\u200E\u206B\u206E\u200F\u202B\u202A\u206B\u200E\u200F\u206A\u202C\u206C\u202D\u202A\u206F\u200C\u200E\u202C\u202E\u200F\u202B\u206B\u206D\u202E(GameRunController A_0)
			{
				return A_0.CurrentStage;
			}

			static Station \u206D\u206F\u202A\u202E\u200D\u206A\u202B\u206B\u206F\u206B\u202E\u200C\u202A\u202D\u202D\u200C\u202E\u206B\u206F\u200F\u200E\u206A\u200F\u202C\u200B\u202D\u200D\u206B\u200F\u200E\u202D\u200B\u202C\u202A\u206C\u206D\u200B\u202B\u206A\u206B\u202E(GameRunController A_0)
			{
				return A_0.CurrentStation;
			}

			static PlayerUnit \u200F\u202C\u202E\u206C\u206A\u206F\u202D\u202C\u202D\u200B\u206B\u206E\u202A\u202A\u206B\u206C\u202A\u200B\u206B\u206A\u200B\u206C\u206C\u200F\u202D\u202E\u200B\u200E\u202E\u206D\u202A\u206D\u206B\u206D\u200C\u206B\u206B\u200D\u200B\u202E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u200F\u200F\u202A\u202E\u200E\u206E\u206B\u202A\u206D\u206E\u200F\u202E\u202A\u206F\u206D\u202B\u200D\u200E\u200D\u206A\u200C\u206E\u206C\u206F\u200B\u202E\u202C\u200C\u202D\u206D\u206A\u206B\u200D\u202C\u206D\u202B\u202D\u206C\u202E\u206E\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static GameEvent<BlockShieldEventArgs> \u202C\u200C\u202B\u200B\u206A\u206A\u200C\u206D\u202E\u202D\u200B\u206B\u206F\u200D\u202B\u200C\u206D\u202A\u206D\u200F\u200E\u206B\u206B\u202A\u200B\u200C\u200B\u200E\u206C\u202C\u202D\u200B\u206F\u200E\u206A\u206E\u202E\u202B\u202D\u202D\u202E(Unit A_0)
			{
				return A_0.BlockShieldGaining;
			}

			static GameEvent<DamageDealingEventArgs> \u202C\u200B\u202D\u200F\u206D\u202B\u202A\u206A\u200B\u202C\u206C\u202C\u206F\u206A\u202E\u200D\u206A\u200B\u200D\u200F\u206C\u206B\u200D\u202C\u200B\u200F\u200E\u206C\u202E\u206D\u206F\u200F\u206C\u200E\u206F\u206F\u200B\u206F\u200B\u202B\u202E(Unit A_0)
			{
				return A_0.DamageDealing;
			}

			static GameEvent<CardUsingEventArgs> \u206E\u202B\u206A\u200B\u200B\u200F\u200E\u200D\u202E\u206E\u200F\u200C\u200D\u206F\u202E\u200F\u202A\u202B\u206D\u202A\u202E\u202B\u202B\u200E\u206B\u200D\u206C\u206E\u202E\u200B\u202A\u202E\u200E\u202D\u206E\u206E\u200E\u206F\u206A\u206D\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u202B\u200E\u202B\u206B\u206B\u206D\u202D\u206A\u206F\u206F\u200E\u200B\u206D\u202A\u206E\u202C\u206D\u202D\u206D\u202E\u206A\u200C\u206A\u206F\u200E\u202C\u206A\u206C\u206E\u202E\u202C\u206F\u200D\u202A\u202A\u200E\u200F\u206C\u200D\u206F\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static GameEvent<GameEventArgs> \u206D\u206C\u206C\u206A\u206B\u206D\u200B\u206C\u200D\u206A\u206F\u200E\u206C\u202B\u206C\u200B\u206A\u200C\u202D\u202D\u206F\u206C\u206E\u200E\u206B\u200F\u202E\u206E\u206A\u206E\u206C\u202B\u200B\u206C\u206F\u202E\u200F\u200F\u202A\u200D\u202E(BattleController A_0)
			{
				return A_0.BattleEnding;
			}

			static void \u200F\u200E\u202D\u200B\u206D\u206B\u206D\u206A\u206B\u206A\u202A\u202C\u200C\u202C\u200D\u206F\u206B\u200D\u206E\u206A\u206D\u206B\u202A\u206E\u200D\u200C\u200D\u200C\u200F\u206D\u206F\u206F\u202B\u200B\u202E\u206D\u200C\u202B\u202B\u202D\u202E(Unit A_0, int A_1, int A_2)
			{
				A_0.SetMaxHp(A_1, A_2);
			}

			static void \u202D\u206C\u202B\u200F\u206A\u200C\u202B\u200F\u206D\u202D\u206B\u200B\u206C\u206A\u206F\u202E\u202D\u200C\u206A\u202B\u206D\u206D\u202C\u206B\u202B\u200E\u200D\u206B\u200D\u200E\u202B\u206B\u206D\u206F\u206D\u200E\u202E\u200D\u200E\u206E\u202E(UnitView A_0)
			{
				A_0.OnMaxHpChanged();
			}

			static void \u200B\u202D\u200D\u206E\u202D\u206C\u200D\u202A\u202B\u202D\u202D\u202D\u206E\u202E\u206F\u202A\u206B\u206E\u200D\u200C\u202E\u200F\u200E\u202C\u200E\u200E\u200E\u200F\u206E\u200E\u200C\u206C\u202A\u202E\u200F\u200E\u202E\u200F\u202E\u206F\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u200D\u206D\u200F\u206D\u200C\u200D\u206E\u200F\u206F\u202C\u206A\u202B\u202C\u200F\u206E\u202C\u206C\u206F\u200C\u200C\u200B\u200B\u206A\u206D\u200C\u200C\u206E\u206A\u200C\u206E\u202B\u206F\u202A\u200C\u202B\u206E\u200C\u200F\u206B\u206D\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static void \u202B\u202C\u206A\u200E\u206E\u200D\u200D\u202D\u200F\u206C\u202C\u200C\u206D\u202D\u206F\u202C\u206A\u202E\u206B\u206F\u206D\u206C\u206E\u200F\u206A\u206A\u206D\u200D\u202A\u206E\u202A\u202E\u200F\u202A\u202B\u206D\u206B\u202D\u200C\u200D\u202E(Unit A_0, UnitStatus A_1)
			{
				A_0.Status = A_1;
			}

			static IEnumerable<EnemyUnit> \u200D\u206E\u200D\u202E\u200F\u200B\u206A\u200B\u206A\u200C\u206C\u206E\u206D\u200F\u202A\u202D\u200F\u206E\u200E\u200F\u206D\u206C\u206B\u206E\u200F\u206E\u206E\u200E\u200C\u200E\u202E\u200F\u206A\u202A\u206D\u200E\u206D\u202C\u202D\u206B\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static DamageAction \u200D\u202C\u200F\u200C\u202C\u202A\u206B\u206E\u200D\u206E\u202E\u200F\u202D\u202A\u202E\u206E\u202B\u202C\u200D\u200F\u206D\u202E\u202C\u202A\u206A\u202E\u200F\u202E\u206D\u206E\u202E\u202E\u200F\u200B\u202B\u206E\u202D\u202D\u206B\u206E\u202E(Unit A_0, IEnumerable<Unit> A_1, DamageInfo A_2, string A_3, GunType A_4)
			{
				return new DamageAction(A_0, A_1, A_2, A_3, A_4);
			}

			static Reactor \u206C\u200B\u200C\u206E\u206C\u206B\u206B\u200F\u206A\u200B\u200D\u206B\u202D\u206E\u202D\u200F\u206A\u202B\u200E\u202E\u206D\u206C\u200E\u202A\u202E\u206E\u200B\u206E\u206F\u200E\u200D\u200B\u200C\u200D\u200D\u202C\u200D\u206B\u202B\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static bool \u206F\u202B\u206F\u206C\u206D\u200B\u206A\u202B\u202D\u202D\u200F\u200F\u206E\u206C\u206A\u206F\u200C\u206E\u202E\u206C\u206A\u202D\u200D\u206D\u206B\u206B\u202A\u206F\u202C\u200E\u206D\u200C\u206F\u206D\u200C\u202C\u206A\u206A\u206F\u200F\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static bool \u206B\u206D\u200D\u206A\u200D\u200D\u202E\u202C\u202A\u206C\u206B\u206F\u202C\u206D\u202D\u200D\u200C\u200F\u202B\u206F\u206A\u206E\u202B\u206B\u202D\u200F\u200B\u206C\u202C\u200B\u202D\u206F\u202E\u200B\u206D\u200D\u202C\u206F\u200C\u202D\u202E(Unit A_0)
			{
				return A_0.IsAlive;
			}

			static ActionCause \u206D\u200D\u202C\u206D\u202D\u200D\u206A\u200E\u200F\u200F\u202B\u206A\u202C\u206A\u206D\u202E\u206E\u202B\u200F\u202B\u206A\u202D\u200B\u200C\u200E\u200F\u202C\u202B\u206C\u202E\u200B\u202B\u200F\u202D\u202A\u206C\u206F\u200E\u206F\u202B\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			static BlockShieldType \u206D\u200D\u202D\u206E\u200B\u206C\u200B\u202D\u206A\u206C\u202A\u202A\u200D\u200D\u200D\u200E\u200D\u202B\u206F\u206E\u200E\u202A\u200C\u206D\u200D\u200E\u206B\u202C\u206C\u202D\u206D\u202B\u206A\u206C\u206F\u206D\u200E\u206F\u202D\u202B\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Type;
			}

			static bool \u202B\u200B\u206D\u206F\u202B\u202C\u202E\u202D\u200F\u200E\u200B\u200D\u200F\u202A\u206F\u206C\u206D\u206A\u200E\u200B\u206B\u200E\u202A\u202E\u206A\u200B\u206E\u206B\u206E\u202D\u202A\u206E\u200B\u200F\u206A\u200F\u200C\u202A\u206D\u206B\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.HasBlock;
			}

			static float \u206F\u202A\u202B\u206E\u206F\u200E\u202A\u206C\u206D\u206E\u202A\u200F\u206D\u206C\u200E\u206A\u200E\u202B\u202D\u200F\u206C\u206C\u200E\u202B\u206C\u206C\u206B\u200D\u206A\u200C\u206D\u206A\u202E\u202B\u206A\u202E\u200F\u206D\u202D\u206F\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Block;
			}

			static void \u202D\u206E\u206A\u202B\u206D\u200F\u206A\u200F\u200F\u202B\u202E\u202A\u206B\u200E\u206F\u206B\u206A\u206E\u206A\u206D\u206A\u202B\u206D\u202A\u206B\u200C\u206E\u202C\u202D\u202D\u202E\u202D\u202B\u202B\u200F\u200C\u206C\u206D\u206B\u202A\u202E(BlockShieldEventArgs A_0, float A_1)
			{
				A_0.Block = A_1;
			}

			static bool \u200F\u200E\u206D\u206B\u206F\u200F\u200E\u206F\u206C\u206E\u202D\u202B\u202B\u202A\u206F\u206E\u202E\u202B\u206E\u202B\u200E\u200F\u200D\u206A\u202B\u206E\u206D\u202B\u200B\u206E\u200C\u202B\u206B\u202B\u200D\u206E\u206B\u202A\u206D\u206C\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.HasShield;
			}

			static float \u202D\u200C\u206E\u200F\u206D\u202B\u206A\u200C\u200C\u206B\u206C\u202B\u200C\u202C\u202B\u206A\u202D\u200D\u202E\u202A\u200B\u206A\u202B\u206C\u202E\u206F\u206E\u202D\u200D\u200E\u206E\u206E\u206F\u202D\u200E\u206C\u206A\u200E\u202C\u206F\u202E(BlockShieldEventArgs A_0)
			{
				return A_0.Shield;
			}

			static void \u202E\u200C\u206C\u206A\u202A\u206E\u202A\u206D\u202B\u202E\u206C\u202C\u206B\u202C\u200B\u206D\u202C\u202C\u206B\u202E\u202E\u200C\u206A\u206A\u200F\u202E\u206B\u206B\u206A\u200D\u206F\u200D\u200F\u202D\u206C\u200B\u202B\u200F\u206D\u206F\u202E(BlockShieldEventArgs A_0, float A_1)
			{
				A_0.Shield = A_1;
			}

			static void \u200C\u206C\u200C\u202B\u206D\u200D\u200D\u202C\u206F\u206C\u202A\u202A\u206E\u206D\u206D\u200D\u202D\u200B\u202B\u200E\u200C\u202E\u206C\u202D\u200B\u206D\u202C\u206E\u200F\u202C\u200B\u200F\u200E\u200F\u206A\u206D\u200D\u206D\u200B\u206E\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static DamageInfo \u200B\u202D\u200D\u206C\u206E\u200B\u206D\u206D\u206F\u200B\u202B\u202E\u206B\u200C\u206B\u206E\u206D\u202E\u200F\u206C\u206D\u206A\u202E\u206E\u200C\u206E\u202E\u202E\u206B\u206B\u206F\u200F\u202B\u206E\u206F\u200B\u200E\u202C\u206E\u200C\u202E(DamageDealingEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u200F\u202C\u202B\u206C\u206C\u206F\u200E\u202C\u200D\u202C\u200F\u202A\u206A\u206D\u202C\u202E\u202C\u206D\u206F\u200B\u206C\u202B\u206C\u206F\u206E\u206A\u206E\u206C\u202B\u202A\u202B\u202B\u206F\u200B\u200D\u206D\u200C\u200D\u206B\u202A\u202E(DamageDealingEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u206A\u200B\u206C\u200D\u206D\u206E\u202B\u202D\u200B\u202A\u206C\u202D\u202E\u200E\u200E\u202B\u206B\u206B\u206C\u206B\u202C\u206F\u200E\u202D\u206E\u206C\u202C\u200C\u200B\u206F\u202C\u202D\u202E\u200F\u206C\u206E\u206C\u202E\u206F\u206F\u202E(GameObject A_0, bool A_1)
			{
				A_0.SetActive(A_1);
			}

			static GameObject \u200D\u202C\u206D\u200D\u200E\u202E\u206B\u200B\u202B\u206B\u206D\u206B\u200C\u200F\u202C\u200E\u202E\u200F\u206E\u206C\u200C\u202E\u200B\u200F\u206B\u206F\u202A\u200F\u206C\u200E\u206C\u206C\u206B\u202E\u206E\u202A\u202A\u202C\u206F\u202D\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			static PlayerUnitConfig \u200C\u206C\u202E\u206B\u206D\u200C\u206B\u202B\u200F\u206A\u200B\u202C\u200B\u202E\u206D\u206B\u200F\u206C\u206F\u202E\u200F\u202A\u206F\u206B\u202E\u202D\u206B\u206A\u206A\u202E\u206A\u202C\u202C\u200E\u206D\u200F\u200B\u200B\u200D\u200C\u202E(PlayerUnit A_0)
			{
				return A_0.Config;
			}

			static string \u202B\u202B\u206F\u202D\u202E\u200C\u202C\u206E\u202A\u206B\u202E\u200C\u200D\u200D\u206C\u200E\u200E\u200C\u206C\u206F\u200D\u206E\u202E\u200C\u202C\u206D\u202D\u206D\u206C\u200D\u206D\u202E\u206C\u206C\u200F\u200C\u200E\u200C\u206F\u200C\u202E(PlayerUnitConfig A_0)
			{
				return A_0.Id;
			}

			static Transform \u206E\u202A\u206A\u200D\u202E\u206E\u200E\u206E\u206C\u200F\u206F\u200C\u202D\u202A\u200B\u206F\u200E\u202A\u202E\u202E\u202C\u206E\u200B\u202A\u202C\u206F\u206A\u200D\u202C\u206B\u200E\u200E\u202B\u202D\u206A\u202E\u202E\u206E\u202C\u200F\u202E(Component A_0)
			{
				return A_0.transform;
			}

			static Vector3 \u202A\u200C\u202A\u200D\u202C\u200B\u200F\u200B\u200D\u206F\u206B\u202C\u202E\u200C\u202C\u206E\u202D\u202B\u206E\u206E\u200E\u200F\u200C\u206A\u206C\u202A\u206F\u202E\u202C\u206F\u202D\u200D\u202B\u206D\u200C\u202B\u200D\u206F\u206D\u202E(Transform A_0)
			{
				return A_0.localPosition;
			}

			static Station \u202E\u206C\u200B\u206B\u202E\u206F\u200F\u202E\u206C\u206B\u202D\u200F\u200B\u200F\u200C\u202E\u200D\u202B\u200E\u200E\u200F\u202E\u200E\u206B\u206E\u202E\u202D\u200F\u202A\u202E\u206B\u206F\u202B\u202B\u202A\u200C\u206D\u206E\u206B\u202A\u202E(StationEventArgs A_0)
			{
				return A_0.Station;
			}

			static bool \u200E\u200C\u202E\u206B\u206A\u206D\u202B\u200B\u202A\u206F\u206E\u202C\u202B\u206D\u202B\u202D\u206D\u202D\u206E\u206F\u200D\u206F\u200F\u206B\u200D\u200B\u202E\u202D\u206F\u206D\u206F\u200E\u202D\u200F\u206A\u202D\u206E\u206F\u200F\u200C\u202E(Station A_0)
			{
				return A_0.IsNormalEnd;
			}

			static GameDifficulty \u206F\u202A\u202A\u200D\u206D\u206D\u202B\u202A\u202E\u206F\u202D\u200B\u202A\u200B\u206B\u200B\u200F\u206E\u202D\u200D\u202E\u206E\u200E\u202C\u202B\u206C\u206C\u202D\u206A\u206A\u200B\u200D\u200D\u206A\u202A\u200C\u206A\u200E\u206E\u202A\u202E(GameRunController A_0)
			{
				return A_0.Difficulty;
			}

			static bool \u206D\u202D\u206E\u200E\u200D\u202E\u200F\u206A\u200E\u206E\u202D\u200C\u206E\u202D\u200B\u206A\u200E\u206A\u200D\u200C\u206B\u206B\u202C\u200C\u202C\u202A\u202B\u200F\u206F\u206A\u200C\u202B\u200D\u200D\u206B\u202A\u206B\u202E\u200E\u202E\u202E(string A_0, string A_1)
			{
				return A_0.Contains(A_1);
			}

			static bool \u200E\u206A\u206F\u202B\u200C\u200B\u200E\u200B\u202D\u202D\u206C\u200F\u206A\u202B\u202B\u200D\u200B\u202A\u206E\u200C\u206B\u206A\u206D\u200E\u200F\u200D\u200D\u200F\u200D\u206B\u202D\u206E\u200C\u202A\u200E\u206B\u202D\u202D\u202D\u200E\u202E(string A_0)
			{
				return A_0.IsNullOrEmpty();
			}

			static string \u200D\u202B\u202D\u200D\u202A\u200C\u206A\u202B\u200D\u202E\u202B\u206A\u206C\u200E\u206F\u206D\u206A\u200E\u200F\u200B\u206A\u206F\u202C\u202E\u206C\u200C\u200F\u200D\u206C\u202B\u206E\u202E\u202B\u202B\u206D\u206D\u200D\u202D\u202D\u200E\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static PuzzleFlag \u202C\u206A\u200E\u202B\u202A\u206C\u206D\u202D\u206E\u200E\u206C\u202E\u202A\u202D\u200E\u202D\u206E\u200D\u202B\u200D\u202C\u202A\u202E\u200E\u206D\u200F\u202C\u202B\u202B\u200C\u206D\u200F\u202B\u206B\u200E\u202E\u206D\u200D\u200E\u206C\u202E(GameRunController A_0)
			{
				return A_0.Puzzles;
			}

			static int \u206D\u200B\u200B\u206A\u202C\u202A\u202D\u202A\u206F\u200C\u200D\u200E\u206F\u200D\u200C\u206D\u200C\u200C\u202E\u202C\u206E\u206D\u202B\u202C\u206F\u200F\u202B\u200B\u200C\u202B\u202E\u206D\u202A\u200F\u200E\u206D\u202A\u206F\u200C\u206C\u202E(PuzzleFlag A_0)
			{
				return PuzzleFlags.GetPuzzleLevel(A_0);
			}

			static EnemyGroup \u202E\u200C\u206C\u206A\u202A\u200F\u206C\u202A\u206B\u202D\u200D\u206A\u200E\u202E\u206E\u206F\u200E\u200F\u206E\u206F\u202D\u206C\u200D\u202B\u200F\u206F\u206D\u202E\u200E\u206D\u202C\u202B\u200E\u202D\u206A\u202A\u202E\u200D\u206C\u202C\u202E(BattleStation A_0)
			{
				return A_0.EnemyGroup;
			}

			static bool \u200B\u200C\u202B\u206C\u202C\u206C\u200E\u206C\u200D\u206F\u202B\u202A\u200E\u202E\u200F\u200E\u206C\u202C\u202C\u202C\u200F\u206D\u206D\u200C\u202D\u200D\u206B\u200F\u206C\u206A\u202E\u202A\u200D\u206D\u200E\u206D\u202B\u200E\u206B\u202C\u202E(Unit A_0)
			{
				return A_0.IsAlive;
			}

			static bool \u202D\u202C\u202B\u200E\u202A\u206E\u206D\u202B\u206F\u206E\u200B\u200D\u206A\u202B\u206F\u206E\u200D\u206F\u202E\u206C\u200B\u206E\u200B\u202D\u202D\u200C\u202C\u202D\u202E\u200B\u206A\u206B\u206E\u206E\u206B\u206A\u202A\u202E\u202B\u200D\u202E(global::UnityEngine.Object A_0)
			{
				return A_0;
			}

			static bool \u202E\u206B\u202C\u200B\u200C\u202B\u202D\u202D\u202D\u206B\u200F\u200C\u206A\u206F\u206F\u206A\u200B\u202B\u200B\u202B\u206F\u206C\u206A\u200C\u202E\u202C\u200B\u200D\u202A\u206F\u202C\u206A\u202C\u202A\u200E\u202D\u200C\u202A\u200B\u206A\u202E(GameEventArgs A_0)
			{
				return A_0.IsCanceled;
			}

			static StationStatus \u200E\u200C\u206D\u202D\u206A\u200F\u200D\u206A\u206C\u206A\u206B\u200C\u200C\u206F\u206A\u202A\u200E\u206C\u202E\u206E\u200E\u206E\u200C\u206B\u200E\u206A\u206A\u206E\u206F\u202D\u200B\u206D\u202D\u200B\u200E\u202E\u206D\u206F\u206C\u200F\u202E(Station A_0)
			{
				return A_0.Status;
			}

			public GameObject _flandreSpellCircle;

			public bool FlandreSong;

			public bool FlandreSongFirstTime;

			public bool TakaneDefeated;

			public bool TakaneTalked;

			public bool YukariDefeated;

			public int _madness;

			public bool MadnessPNRQueue;

			public bool MadnessPNR;

			public int? Story;

			public bool BossStationFinished;

			public static bool LastInputTriggered = false;

			private static GameObject background = FlandrePlayerUnitDef.FlandrePlayerUnit.\u200D\u202C\u206D\u200D\u200E\u202E\u206B\u200B\u202B\u206B\u206D\u206B\u200C\u200F\u202C\u200E\u202E\u200F\u206E\u206C\u200C\u202E\u200B\u200F\u206B\u206F\u202A\u200F\u206C\u200E\u206C\u206C\u206B\u202E\u206E\u202A\u202A\u202C\u206F\u202D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2053366231), null);

			private static GameObject MadnessObj;

			private SimpleTooltipSource MadnessTooltip;

			private static bool AnnoyingSunlightChat = false;

			[HarmonyPatch(typeof(UnitView), "Chat")]
			private class UnitView_Chat_Patch
			{
				private static bool Prefix(UnitView __instance, ref string content, ref float time, ref ChatWidget.CloudType type, ref float delay)
				{
					FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandrePlayerUnitDef.FlandrePlayerUnit.UnitView_Chat_Patch.\u202D\u200D\u206C\u206D\u202A\u202B\u206F\u206C\u206D\u202E\u206B\u206D\u202D\u200B\u202C\u202C\u202A\u200C\u200E\u200D\u200B\u206D\u206A\u200F\u206C\u202E\u206D\u200C\u206C\u206F\u202A\u206D\u200D\u200E\u202C\u200F\u206A\u206E\u200D\u202E(__instance) as FlandrePlayerUnitDef.FlandrePlayerUnit;
					if (flandrePlayerUnit != null)
					{
						for (;;)
						{
							int num = -1457426470;
							switch (~(-((num * -1029984005) ^ ((-1673850320 - -1480030328) * -936615327))) % 3)
							{
							case 0:
								continue;
							case 2:
								goto IL_0047;
							}
							break;
						}
						return true;
						IL_0047:
						return !flandrePlayerUnit.MadnessPNR;
					}
					return true;
				}

				static Unit \u202D\u200D\u206C\u206D\u202A\u202B\u206F\u206C\u206D\u202E\u206B\u206D\u202D\u200B\u202C\u202C\u202A\u200C\u200E\u200D\u200B\u206D\u206A\u200F\u206C\u202E\u206D\u200C\u206C\u206F\u202A\u206D\u200D\u200E\u202C\u200F\u206A\u206E\u200D\u202E(UnitView A_0)
				{
					return A_0.Unit;
				}
			}

			[HarmonyPatch(typeof(CardDetailPanel), "SetData")]
			private class CardDetailPanel_SetData_Patch
			{
				private static void Postfix(CardDetailPanel __instance, ref Card card, ref bool bySwitch)
				{
					FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.<>c__DisplayClass1_0 CS$<>8__locals1 = new FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.<>c__DisplayClass1_0();
					for (;;)
					{
						IL_0006:
						int num = -1156419334;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(num2 * -433531935 + (--1196785699 + ~-830197450) - -711551019))) % 15U)
							{
							case 0U:
							{
								FlandreCard flandreCard = card as FlandreCard;
								num = (int)((num3 * 3395056393U) ^ 890953143U);
								continue;
							}
							case 1U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206A\u202C\u206A\u206C\u206D\u200B\u200D\u200C\u202C\u202B\u202D\u200C\u202B\u202C\u202A\u200C\u202E\u202A\u202D\u202A\u206C\u202E\u206F\u200D\u202B\u206C\u202A\u200D\u200F\u200D\u202A\u206F\u202D\u200E\u200C\u202E\u200F\u200C\u206F\u206D\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch), new Vector3(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200B\u206B\u206E\u200D\u202B\u206D\u206F\u206E\u202E\u200E\u200B\u206D\u200B\u200B\u202D\u206A\u202A\u200E\u206D\u202A\u202C\u202E\u206A\u206E\u206A\u200D\u206C\u206B\u206E\u206D\u202D\u202A\u200D\u206E\u202C\u200F\u200D\u200E\u206C\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(CS$<>8__locals1.__instance.upgradeSwitch)).x + 3f, FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200B\u206B\u206E\u200D\u202B\u206D\u206F\u206E\u202E\u200E\u200B\u206D\u200B\u200B\u202D\u206A\u202A\u200E\u206D\u202A\u202C\u202E\u206A\u206E\u206A\u200D\u206C\u206B\u206E\u206D\u202D\u202A\u200D\u206E\u202C\u200F\u200D\u200E\u206C\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(CS$<>8__locals1.__instance.upgradeSwitch)).y, FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200B\u206B\u206E\u200D\u202B\u206D\u206F\u206E\u202E\u200E\u200B\u206D\u200B\u200B\u202D\u206A\u202A\u200E\u206D\u202A\u202C\u202E\u206A\u206E\u206A\u200D\u206C\u206B\u206E\u206D\u202D\u202A\u200D\u206E\u202C\u200F\u200D\u200E\u206C\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(CS$<>8__locals1.__instance.upgradeSwitch)).z));
								num = (int)((num3 * 1310073957U) ^ 1937211252U);
								continue;
							case 3U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200F\u202D\u200D\u202A\u202D\u200E\u206C\u202B\u206A\u202C\u206D\u206C\u206C\u206F\u202A\u206B\u202B\u200C\u202B\u206B\u200C\u200B\u202B\u200D\u202A\u202B\u202A\u206F\u202B\u202E\u200C\u206E\u206E\u200F\u206D\u206B\u206E\u200C\u206B\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch, FlandreCard.SkipOffering, true);
								num = (int)((num3 * 3560248623U) ^ 1068963089U);
								continue;
							case 4U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u202B\u200D\u202A\u200D\u206B\u200D\u200C\u202E\u200B\u202E\u202C\u202A\u202B\u206F\u202A\u200F\u206D\u206F\u200F\u200B\u206E\u206E\u200C\u206B\u200C\u200B\u200B\u206D\u206E\u202D\u200E\u200E\u206A\u202D\u202E\u206B\u202B\u202C\u206A\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206A\u200E\u200F\u200E\u200F\u200E\u206C\u206A\u206E\u202B\u202D\u200D\u202E\u206D\u202B\u200B\u206A\u206C\u206A\u200B\u200E\u206C\u206A\u206C\u202A\u206E\u200D\u206E\u206E\u200E\u206F\u206C\u202C\u202B\u206B\u202C\u206D\u202B\u200B\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch), true);
								num = -67474407;
								continue;
							case 5U:
							{
								FlandreCard flandreCard;
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u202C\u202E\u200B\u202B\u202A\u206D\u206F\u206E\u206E\u200E\u206B\u202E\u206C\u206B\u206E\u200F\u200F\u202B\u202C\u202E\u202E\u202E\u206C\u200C\u200B\u202A\u202A\u202B\u200D\u200F\u206E\u202E\u206A\u200B\u206B\u200E\u202C\u206C\u202B\u200D\u202E(Singleton<GameMaster>.Instance, CS$<>8__locals1.<Postfix>g__coroutine|1(flandreCard));
								num = 946192657;
								continue;
							}
							case 6U:
								goto IL_0006;
							case 7U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u202B\u200D\u202A\u200D\u206B\u200D\u200C\u202E\u200B\u202E\u202C\u202A\u202B\u206F\u202A\u200F\u206D\u206F\u200F\u200B\u206E\u206E\u200C\u206B\u200C\u200B\u200B\u206D\u206E\u202D\u200E\u200E\u206A\u202D\u202E\u206B\u202B\u202C\u206A\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206A\u200E\u200F\u200E\u200F\u200E\u206C\u206A\u206E\u202B\u202D\u200D\u202E\u206D\u202B\u200B\u206A\u206C\u206A\u200B\u200E\u206C\u206A\u206C\u202A\u206E\u200D\u206E\u206E\u200E\u206F\u206C\u202C\u202B\u206B\u202C\u206D\u202B\u200B\u206C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch), true);
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200F\u202D\u200D\u202A\u202D\u200E\u206C\u202B\u206A\u202C\u206D\u206C\u206C\u206F\u202A\u206B\u202B\u200C\u202B\u206B\u200C\u200B\u202B\u200D\u202A\u202B\u202A\u206F\u202B\u202E\u200C\u206E\u206E\u200F\u206D\u206B\u206E\u200C\u206B\u206B\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch, FlandreCard.SkipOffering, true);
								num = (int)((num3 * 2027757079U) ^ 3471841265U);
								continue;
							case 8U:
							{
								FlandreCard flandreCard;
								num = (int)(((flandreCard == null) ? 2752267523U : 408916485U) ^ (num3 * 3996993005U));
								continue;
							}
							case 9U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200E\u206B\u200C\u206F\u206E\u206E\u202C\u200D\u202C\u206E\u200F\u200F\u200E\u206A\u200F\u202A\u206F\u206A\u200D\u200B\u202C\u206C\u206C\u200F\u202E\u206C\u206F\u206B\u202C\u202A\u202D\u202A\u202D\u206A\u200B\u200B\u202C\u202E\u206B\u200C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch, delegate(bool b)
								{
									FlandreCard.SkipOffering = b;
								});
								num = 844182817;
								continue;
							case 10U:
							{
								FlandreCard flandreCard;
								num = (int)((flandreCard.IsOffering ? 2837911426U : 1500035583U) ^ (num3 * 1273801167U));
								continue;
							}
							case 11U:
								CS$<>8__locals1.__instance = __instance;
								num = (int)((num3 * 1978014986U) ^ 1391411815U);
								continue;
							case 12U:
								num = (int)((num3 * 2454922625U) ^ 2415547502U);
								continue;
							case 13U:
								num = (int)((FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u200E\u202E\u206D\u200D\u202E\u202E\u206B\u206D\u206B\u202A\u206B\u206C\u200B\u200F\u206C\u200D\u206B\u202A\u206B\u202B\u200D\u200B\u206C\u202D\u200C\u200D\u206A\u202B\u202A\u200C\u206A\u206C\u202C\u202D\u206F\u200E\u200F\u202B\u202D\u200F\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch, null) ? 334499863U : 2860232125U) ^ (num3 * 2150834102U));
								continue;
							case 14U:
								FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.offeringSwitch = global::UnityEngine.Object.Instantiate<SwitchWidget>(CS$<>8__locals1.__instance.upgradeSwitch, FlandrePlayerUnitDef.FlandrePlayerUnit.CardDetailPanel_SetData_Patch.\u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(CS$<>8__locals1.__instance.subWidgetGroup));
								num = (int)((num3 * 1596380420U) ^ 145574199U);
								continue;
							}
							return;
						}
					}
				}

				static bool \u200E\u202E\u206D\u200D\u202E\u202E\u206B\u206D\u206B\u202A\u206B\u206C\u200B\u200F\u206C\u200D\u206B\u202A\u206B\u202B\u200D\u200B\u206C\u202D\u200C\u200D\u206A\u202B\u202A\u200C\u206A\u206C\u202C\u202D\u206F\u200E\u200F\u202B\u202D\u200F\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
				{
					return A_0 == A_1;
				}

				static Transform \u206E\u202B\u202B\u200F\u202A\u206F\u202C\u206F\u206D\u206B\u206C\u200B\u206B\u200C\u200E\u206F\u200C\u202D\u206A\u202C\u202A\u206F\u200B\u202D\u202D\u202C\u206D\u202E\u206A\u200B\u206D\u206A\u202D\u202C\u206C\u206E\u206F\u200F\u202D\u206B\u202E(Component A_0)
				{
					return A_0.transform;
				}

				static void \u200E\u206B\u200C\u206F\u206E\u206E\u202C\u200D\u202C\u206E\u200F\u200F\u200E\u206A\u200F\u202A\u206F\u206A\u200D\u200B\u202C\u206C\u206C\u200F\u202E\u206C\u206F\u206B\u202C\u202A\u202D\u202A\u202D\u206A\u200B\u200B\u202C\u202E\u206B\u200C\u202E(SwitchWidget A_0, UnityAction<bool> A_1)
				{
					A_0.AddListener(A_1);
				}

				static Vector3 \u200B\u206B\u206E\u200D\u202B\u206D\u206F\u206E\u202E\u200E\u200B\u206D\u200B\u200B\u202D\u206A\u202A\u200E\u206D\u202A\u202C\u202E\u206A\u206E\u206A\u200D\u206C\u206B\u206E\u206D\u202D\u202A\u200D\u206E\u202C\u200F\u200D\u200E\u206C\u206C\u202E(Transform A_0)
				{
					return A_0.position;
				}

				static void \u206A\u202C\u206A\u206C\u206D\u200B\u200D\u200C\u202C\u202B\u202D\u200C\u202B\u202C\u202A\u200C\u202E\u202A\u202D\u202A\u206C\u202E\u206F\u200D\u202B\u206C\u202A\u200D\u200F\u200D\u202A\u206F\u202D\u200E\u200C\u202E\u200F\u200C\u206F\u206D\u202E(Transform A_0, Vector3 A_1)
				{
					A_0.position = A_1;
				}

				static GameObject \u206A\u200E\u200F\u200E\u200F\u200E\u206C\u206A\u206E\u202B\u202D\u200D\u202E\u206D\u202B\u200B\u206A\u206C\u206A\u200B\u200E\u206C\u206A\u206C\u202A\u206E\u200D\u206E\u206E\u200E\u206F\u206C\u202C\u202B\u206B\u202C\u206D\u202B\u200B\u206C\u202E(Component A_0)
				{
					return A_0.gameObject;
				}

				static void \u202B\u200D\u202A\u200D\u206B\u200D\u200C\u202E\u200B\u202E\u202C\u202A\u202B\u206F\u202A\u200F\u206D\u206F\u200F\u200B\u206E\u206E\u200C\u206B\u200C\u200B\u200B\u206D\u206E\u202D\u200E\u200E\u206A\u202D\u202E\u206B\u202B\u202C\u206A\u206C\u202E(GameObject A_0, bool A_1)
				{
					A_0.SetActive(A_1);
				}

				static void \u200F\u202D\u200D\u202A\u202D\u200E\u206C\u202B\u206A\u202C\u206D\u206C\u206C\u206F\u202A\u206B\u202B\u200C\u202B\u206B\u200C\u200B\u202B\u200D\u202A\u202B\u202A\u206F\u202B\u202E\u200C\u206E\u206E\u200F\u206D\u206B\u206E\u200C\u206B\u206B\u202E(SwitchWidget A_0, bool A_1, bool A_2)
				{
					A_0.SetValueWithoutNotifier(A_1, A_2);
				}

				static Coroutine \u202C\u202E\u200B\u202B\u202A\u206D\u206F\u206E\u206E\u200E\u206B\u202E\u206C\u206B\u206E\u200F\u200F\u202B\u202C\u202E\u202E\u202E\u206C\u200C\u200B\u202A\u202A\u202B\u200D\u200F\u206E\u202E\u206A\u200B\u206B\u200E\u202C\u206C\u202B\u200D\u202E(MonoBehaviour A_0, IEnumerator A_1)
				{
					return A_0.StartCoroutine(A_1);
				}

				public static SwitchWidget offeringSwitch;
			}

			[HarmonyPatch(typeof(GameMaster), "LeaveGameRun")]
			private class GameMaster_LeaveGameRun_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameMaster __instance)
				{
					GameObject background = FlandrePlayerUnitDef.FlandrePlayerUnit.background;
					if (background == null)
					{
						goto IL_0051;
					}
					FlandrePlayerUnitDef.FlandrePlayerUnit.GameMaster_LeaveGameRun_Patch.\u206E\u206E\u202C\u202A\u206F\u202A\u202B\u202A\u200D\u200E\u206D\u202B\u200C\u206D\u200F\u202C\u202B\u206F\u206E\u206B\u206A\u202C\u202A\u202C\u206D\u202C\u202A\u202D\u202A\u206F\u200E\u206C\u202D\u200B\u202A\u200C\u206A\u200B\u206D\u200C\u202E(background, false);
					goto IL_0011;
					int num2;
					for (;;)
					{
						IL_0016:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)((num * 1719411349) ^ (1194572570 - 333935543 - 236059737))))) % 5U)
						{
						case 0U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.GameMaster_LeaveGameRun_Patch.\u200E\u202D\u206A\u202B\u206D\u206D\u206D\u202C\u200B\u202D\u202B\u206D\u206D\u206C\u206D\u206C\u202E\u202D\u206A\u206D\u202E\u202A\u202E\u200B\u202D\u202B\u202D\u200E\u202A\u206E\u202B\u202C\u200C\u200C\u202D\u200B\u206D\u206E\u202A\u200F\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.MadnessObj);
							num2 = (int)((num3 * 1860243578U) ^ 2432146527U);
							continue;
						case 1U:
							goto IL_0051;
						case 2U:
							FlandrePlayerUnitDef.FlandrePlayerUnit.GameMaster_LeaveGameRun_Patch.\u206D\u202E\u200E\u200F\u206E\u202E\u206E\u202A\u206B\u202D\u206C\u202C\u200C\u206C\u200B\u206A\u206A\u206E\u206B\u206A\u206D\u202B\u200C\u206F\u202B\u206A\u206E\u200F\u202E\u206E\u200E\u206C\u200B\u200D\u206B\u206D\u202E\u206E\u206F\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1272298239)).Value2 = new int?(25);
							num2 = (int)(((!FlandrePlayerUnitDef.FlandrePlayerUnit.GameMaster_LeaveGameRun_Patch.\u202D\u200E\u200B\u202A\u206F\u206B\u206F\u202E\u200F\u200C\u206D\u206E\u200E\u202E\u200D\u206B\u202C\u206A\u202E\u200D\u202E\u202D\u202B\u200D\u206F\u202E\u202A\u202C\u202B\u206D\u200F\u200F\u200E\u200F\u200F\u206F\u200C\u200C\u206E\u202C\u202E(FlandrePlayerUnitDef.FlandrePlayerUnit.MadnessObj, null)) ? 4013687657U : 3201750244U) ^ (num3 * 3193259090U));
							continue;
						case 3U:
							goto IL_0011;
						}
						break;
					}
					return;
					IL_0011:
					num2 = 686066706;
					goto IL_0016;
					IL_0051:
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.types = new Type[0];
					num2 = 2099578229;
					goto IL_0016;
				}

				static void \u206E\u206E\u202C\u202A\u206F\u202A\u202B\u202A\u200D\u200E\u206D\u202B\u200C\u206D\u200F\u202C\u202B\u206F\u206E\u206B\u206A\u202C\u202A\u202C\u206D\u202C\u202A\u202D\u202A\u206F\u200E\u206C\u202D\u200B\u202A\u200C\u206A\u200B\u206D\u200C\u202E(GameObject A_0, bool A_1)
				{
					A_0.SetActive(A_1);
				}

				static ExhibitConfig \u206D\u202E\u200E\u200F\u206E\u202E\u206E\u202A\u206B\u202D\u206C\u202C\u200C\u206C\u200B\u206A\u206A\u206E\u206B\u206A\u206D\u202B\u200C\u206F\u202B\u206A\u206E\u200F\u202E\u206E\u200E\u206C\u200B\u200D\u206B\u206D\u202E\u206E\u206F\u202E(string A_0)
				{
					return ExhibitConfig.FromId(A_0);
				}

				static bool \u202D\u200E\u200B\u202A\u206F\u206B\u206F\u202E\u200F\u200C\u206D\u206E\u200E\u202E\u200D\u206B\u202C\u206A\u202E\u200D\u202E\u202D\u202B\u200D\u206F\u202E\u202A\u202C\u202B\u206D\u200F\u200F\u200E\u200F\u200F\u206F\u200C\u200C\u206E\u202C\u202E(global::UnityEngine.Object A_0, global::UnityEngine.Object A_1)
				{
					return A_0 != A_1;
				}

				static void \u200E\u202D\u206A\u202B\u206D\u206D\u206D\u202C\u200B\u202D\u202B\u206D\u206D\u206C\u206D\u206C\u202E\u202D\u206A\u206D\u202E\u202A\u202E\u200B\u202D\u202B\u202D\u200E\u202A\u206E\u202B\u202C\u200C\u200C\u202D\u200B\u206D\u206E\u202A\u200F\u202E(global::UnityEngine.Object A_0)
				{
					global::UnityEngine.Object.Destroy(A_0);
				}
			}
		}
	}
}
