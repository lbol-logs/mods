using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.StatusEffects.Enemy;
using LBoL.EntityLib.StatusEffects.Enemy.Seija;
using LBoL.Presentation;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.Panels;
using LBoL.Presentation.UI.Widgets;
using LBoL.Presentation.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;
using UnityEngine.UI;

namespace AyaShameimaru.PlayerUnits
{
	public sealed class AyaPlayerUnitDef : PlayerUnitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103);
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaPlayerUnitDef.\u206D\u206D\u202B\u202C\u200F\u200C\u202A\u200F\u206C\u202B\u200B\u202B\u202D\u202D\u200B\u206B\u202D\u206F\u206C\u206D\u200C\u202B\u206F\u202B\u202D\u206E\u200B\u202C\u200F\u206E\u200E\u206D\u206F\u206D\u202D\u206A\u200C\u202C\u202B\u200F\u202E(BepinexPlugin.playerUnitLoc, this);
		}

		private UniTask<Sprite> LoadAsSprite(string path)
		{
			AyaPlayerUnitDef.<LoadAsSprite>d__3 <LoadAsSprite>d__;
			<LoadAsSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder<Sprite>.Create();
			for (;;)
			{
				IL_000C:
				int num = 1311949935;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(uint)((num2 - (~-613640067 + 1683194039 - 1016362611)) * 1081527629 * -1408131735))) % 4U)
					{
					case 0U:
						goto IL_000C;
					case 2U:
						<LoadAsSprite>d__.path = path;
						num = (int)((num3 * 446617840U) ^ 4192782262U);
						continue;
					case 3U:
						<LoadAsSprite>d__.<>1__state = -1;
						<LoadAsSprite>d__.<>t__builder.Start<AyaPlayerUnitDef.<LoadAsSprite>d__3>(ref <LoadAsSprite>d__);
						num = (int)((num3 * 2399356820U) ^ 2012953144U);
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
			PlayerImages playerImages = AyaPlayerUnitDef.\u202D\u206B\u202A\u200D\u200E\u202C\u206B\u202C\u200F\u200F\u200B\u206E\u206A\u202C\u202E\u200F\u200C\u200C\u202B\u200D\u206F\u200F\u206A\u202C\u202C\u202A\u202E\u202C\u200E\u200C\u206C\u206D\u200D\u200C\u202E\u202B\u200B\u200D\u200F\u206F\u202E();
			AyaPlayerUnitDef.\u206E\u202E\u206C\u200E\u206C\u206A\u200F\u206D\u202C\u200C\u206D\u206C\u206A\u200B\u202D\u202A\u202B\u202E\u206B\u202A\u200F\u202B\u206A\u202A\u200B\u202D\u206E\u206D\u206B\u206E\u206F\u202D\u200D\u202C\u200C\u202C\u206E\u200F\u202E(playerImages, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1206262346), (string s) => BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(s), (string s) => this.LoadAsSprite(s), 2, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), "");
			return playerImages;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override PlayerUnitConfig MakeConfig()
		{
			return new PlayerUnitConfig("", false, "", 0, 6, new int?(0), true, null, ManaColor.Red, ManaColor.Green, new ManaGroup
			{
				Red = 2,
				Green = 2
			}, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1479483361), 70, 50, 0, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-710159989), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(300521204), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1764133298), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-766184698), new string[]
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-631691266),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1730123921),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1650528182),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-156905583),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(816029359),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-586216517),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-140942645),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-178801732),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-89967850)
			}, new string[]
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-631691266),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-631691266),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1650528182),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-17996021),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2057392847),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-910128356),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-2121736762),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1515109001),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1209064333),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1061091270)
			}, 1, 1);
		}

		static BatchLocalization \u206D\u206D\u202B\u202C\u200F\u200C\u202A\u200F\u206C\u202B\u200B\u202B\u202D\u202D\u200B\u206B\u202D\u206F\u206C\u206D\u200C\u202B\u206F\u202B\u202D\u206E\u200B\u202C\u200F\u206E\u200E\u206D\u206F\u206D\u202D\u206A\u200C\u202C\u202B\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static PlayerImages \u202D\u206B\u202A\u200D\u200E\u202C\u206B\u202C\u200F\u200F\u200B\u206E\u206A\u202C\u202E\u200F\u200C\u200C\u202B\u200D\u206F\u200F\u206A\u202C\u202C\u202A\u202E\u202C\u200E\u200C\u206C\u206D\u200D\u200C\u202E\u202B\u200B\u200D\u200F\u206F\u202E()
		{
			return new PlayerImages();
		}

		static void \u206E\u202E\u206C\u200E\u206C\u206A\u200F\u206D\u202C\u200C\u206D\u206C\u206A\u200B\u202D\u202A\u202B\u202E\u206B\u202A\u200F\u202B\u206A\u202A\u200B\u202D\u206E\u206D\u206B\u206E\u206F\u202D\u200D\u202C\u200C\u202C\u206E\u200F\u202E(PlayerImages A_0, string A_1, Func<string, Sprite> A_2, Func<string, UniTask<Sprite>> A_3, PlayerImages.UseSame A_4, string A_5, string A_6)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4, A_5, A_6);
		}

		public static string name = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136);

		[EntityLogic(typeof(AyaPlayerUnitDef))]
		public sealed class AyaPlayerUnit : PlayerUnit
		{
			public string AyaSelect
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1443437361), true, true);
				}
			}

			public static string AyaChallengeYukariName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return TypeFactory<PlayerUnit>.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(571082997), true, true);
				}
			}

			public static string AyaChallengeYukariDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return TypeFactory<PlayerUnit>.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-265723880), true, true);
				}
			}

			public string AyaBribery1Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-704879675), true, true);
				}
			}

			public string AyaBribery2Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(136762707), true, true);
				}
			}

			public string AyaBribery3Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1917406341), true, true);
				}
			}

			public string AyaBribery4Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(790413928), true, true);
				}
			}

			public string AyaBribery5Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-273666948), true, true);
				}
			}

			public string AyaBribery6Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-521798824), true, true);
				}
			}

			public string AyaBribery7Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(348950079), true, true);
				}
			}

			public string AyaBribery8Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2017947725), true, true);
				}
			}

			public string AyaBribery9Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1413931159), true, true);
				}
			}

			public string AyaBribery10Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-665742482), true, true);
				}
			}

			public string AyaFastAttack1Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(741985053), true, true);
				}
			}

			public string AyaFastAttack2Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1773001363), true, true);
				}
			}

			public string AyaFastAttack3Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1346425495), true, true);
				}
			}

			public string AyaExtraBoss1SukusukuAya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-254765761), true, true);
				}
			}

			public string AyaChapterSelect
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(219392466), true, true);
				}
			}

			public string AyaChapter1Act1AyaTanukiIntro1AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1291738222), true, true);
				}
			}

			public string AyaChapter1Act1AyaTanukiIntro2Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1363710051), true, true);
				}
			}

			public string AyaChapter1Act1AyaTanukiIntro3Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(132667303), true, true);
				}
			}

			public string AyaChapter1Act1AyaTanukiIntro4AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1125125918), true, true);
				}
			}

			public string AyaChapter1Act21AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1557072828), true, true);
				}
			}

			public string AyaChapter1Act22Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1895181252), true, true);
				}
			}

			public string AyaChapter1Act23Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-646657820), true, true);
				}
			}

			public string AyaChapter1Act24Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1674798875), true, true);
				}
			}

			public string AyaChapter1Act25AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1184406765), true, true);
				}
			}

			public string AyaChapter1Act26AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1025048619), true, true);
				}
			}

			public string AyaChapter1Act27Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-237560584), true, true);
				}
			}

			public string AyaChapter1Act28Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-446127711), true, true);
				}
			}

			public string AyaChapter1Act29Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(793215915), true, true);
				}
			}

			public string AyaChapter1Act210Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(782543453), true, true);
				}
			}

			public string AyaChapter1Act211Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1329840361), true, true);
				}
			}

			public string AyaChapter1Act212AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1750143767), true, true);
				}
			}

			public string AyaChapter1Act213Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-55292843), true, true);
				}
			}

			public string AyaChapter1Act214AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-833381358), true, true);
				}
			}

			public string AyaChapter1Act215Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-46265589), true, true);
				}
			}

			public string AyaChapter1Act216AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2006739777), true, true);
				}
			}

			public string AyaChapter1Act217Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1368758441), true, true);
				}
			}

			public string AyaChapter1Act218Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1904990000), true, true);
				}
			}

			public string AyaChapter1Act219AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1049767773), true, true);
				}
			}

			public string AyaChapter1Act220Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1352940243), true, true);
				}
			}

			public string AyaChapter1Act221Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-404623789), true, true);
				}
			}

			public string AyaChapter1Act31Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(2059813197), true, true);
				}
			}

			public string AyaChapter1Act32AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1553388433), true, true);
				}
			}

			public string AyaChapter1Act33Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2103597527), true, true);
				}
			}

			public string AyaChapter1Act34Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1079028977), true, true);
				}
			}

			public string AyaChapter1Act35AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-691310349), true, true);
				}
			}

			public string AyaChapter1Act36AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-129337149), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase11Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1817308031), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase12Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-251810330), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase13Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(295507477), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase14Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1985645001), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase15Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1697043306), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase16Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-327484728), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase2Hidden1Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(137442472), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase2Hidden2Koishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1633819826), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase21Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-52490856), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase22Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-386118760), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase23Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1987026884), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase24Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2128874280), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase25Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1943621420), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase26Reimu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(383764251), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase27Marisa
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-233737256), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase28Sakuya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(756392536), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase29Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1669335808), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase210Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-254741866), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase211Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(971230839), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase212Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-773319847), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase213Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-394294968), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase214Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2095065293), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase215Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1833453365), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase216Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1036294473), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase217Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-193946286), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3Normal1Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-935418554), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True1Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1887068583), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True2Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1731985462), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True3Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-345866093), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True4Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(24355437), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True5Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1133650919), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True6Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2086388057), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True7Cirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1264683469), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True8Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-488669910), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase31Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(775292719), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase32Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1007247891), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase33Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1197383637), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase34Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(249097119), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase35Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1741781958), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase36Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-565197024), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase37Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1611632145), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase38Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-115254791), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase39Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(132818683), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase310Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(648326838), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase311Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(732799567), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase312Seija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-990256312), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3Normal2Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1356704950), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3Normal3Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1069099683), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3Normal4Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1596555116), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True9Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(303720739), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True10Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1625508437), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True11Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(427020949), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True12Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-63371161), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True13Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(243796630), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True14Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-246595480), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True15Aya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(184515783), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True16Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-305876327), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True17Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1926411950), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True18Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-379887485), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True19Megumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1533376976), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True20Okina
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1630914273), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True21AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(416638608), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True22AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-396422441), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True23AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(201623688), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True24AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-772212483), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True25AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-13391232), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True26AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-195235884), true, true);
				}
			}

			public string AyaChapter1Act4SeijaPhase3True27AyaTanuki
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1069779230), true, true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void OnEnterGameRun(GameRunController gameRun)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Init|244_0());
				AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Timer|244_1());
				base.HandleGameRunEvent<StationEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u206B\u202D\u202D\u206D\u206B\u200D\u202E\u200C\u206F\u206B\u200B\u206E\u202A\u206B\u200E\u202E\u200D\u202C\u200B\u202D\u206C\u202E\u206B\u200B\u206B\u206A\u202B\u202E\u206D\u206D\u202C\u202E\u206D\u202E\u200E\u202A\u200F\u206B\u206F\u200C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this)), delegate(StationEventArgs _)
				{
					AyaPlayerUnitDef.AyaPlayerUnit.BossStationFinished = false;
					AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u202A\u206C\u206E\u206D\u202C\u206B\u200C\u200C\u202C\u200F\u206C\u202A\u200F\u200E\u202A\u200B\u200D\u206D\u206D\u206B\u200E\u200F\u200D\u200D\u206F\u202E\u202E\u200C\u202D\u200F\u200B\u206C\u206F\u202B\u202E\u206A\u206F\u202B\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, ((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.66f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-144153757)) : (((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.33f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1568510806)) : BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1310305497))));
					UnitView view = this.GetView<UnitView>();
					if (view == null || AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u206B\u202B\u202D\u202E\u200F\u206F\u202C\u200C\u200D\u200B\u206C\u202E\u200C\u202A\u200C\u206B\u202E\u200E\u202A\u200E\u202C\u206A\u200E\u206E\u206A\u200D\u202B\u202A\u200B\u200E\u200F\u200C\u202A\u200D\u206A\u200D\u202A\u206E\u200C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200D\u202A\u206C\u206D\u200F\u200C\u202E\u200F\u202A\u202A\u200E\u200C\u200C\u206D\u206B\u200F\u202C\u202E\u200E\u200B\u202B\u200E\u202B\u200B\u206D\u200F\u200C\u200B\u202C\u200E\u200B\u200F\u206F\u200B\u202D\u206C\u202D\u206A\u202E\u202E(view)).x != 0f)
					{
						goto IL_00B2;
					}
					goto IL_01DA;
					int num6;
					for (;;)
					{
						IL_00B7:
						int num5 = num6;
						uint num7;
						switch ((num7 = (uint)(~(uint)(-(uint)(num5 * 1793367901 - 1245264378)))) % 14U)
						{
						case 1U:
							num6 = ((this.Story.GetValueOrDefault() == 1) ? 1567580548 : 1067744632);
							continue;
						case 2U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__ChapterSelect|244_9());
							num6 = (int)((num7 * 1109889153U) ^ 3691950086U);
							continue;
						case 3U:
							num6 = ((this.Story.GetValueOrDefault() != 1) ? (-1960224751) : 109526918);
							continue;
						case 4U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10());
							num6 = (int)((num7 * 2133248368U) ^ 4172983960U);
							continue;
						case 5U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Return|244_8());
							num6 = (int)((num7 * 1487101418U) ^ 3639037929U);
							continue;
						case 6U:
							num6 = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u200E\u202A\u206B\u202E\u206E\u202C\u206C\u206F\u202A\u202B\u206C\u202E\u200F\u202C\u200E\u206E\u202C\u200D\u206D\u202C\u200D\u202A\u200E\u202E\u206E\u206F\u200B\u206B\u200E\u202C\u206C\u202D\u206C\u200C\u202B\u206A\u202B\u202D\u206C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this)) is EntryStation) ? 49510514U : 4161996749U) ^ (num7 * 378247138U));
							continue;
						case 7U:
							num6 = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u200D\u200B\u202A\u202C\u206B\u202C\u202C\u206C\u202D\u200C\u202A\u202C\u202D\u202C\u200C\u200C\u202C\u206D\u202B\u206C\u206D\u202B\u206E\u200B\u202E\u202A\u206F\u202A\u206B\u206C\u202E\u206A\u202B\u206D\u206C\u202E\u202D\u206A\u206A\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200F\u206C\u200F\u200E\u206A\u202A\u206E\u206F\u200B\u206B\u200E\u202B\u206A\u206F\u206E\u200C\u202A\u206A\u200F\u200C\u206A\u206F\u202A\u206C\u202B\u202C\u202D\u202B\u202C\u200B\u200D\u200B\u200C\u202A\u206D\u200D\u206E\u202C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this))) != 2) ? 2311546207U : 1570951125U) ^ (num7 * 2238228511U));
							continue;
						case 8U:
							num6 = (int)((AyaMisc.IsValidGameRun(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this)) ? 2090550687U : 850155182U) ^ (num7 * 2023899758U));
							continue;
						case 9U:
							num6 = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u200D\u200B\u202A\u202C\u206B\u202C\u202C\u206C\u202D\u200C\u202A\u202C\u202D\u202C\u200C\u200C\u202C\u206D\u202B\u206C\u206D\u202B\u206E\u200B\u202E\u202A\u206F\u202A\u206B\u206C\u202E\u206A\u202B\u206D\u206C\u202E\u202D\u206A\u206A\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200F\u206C\u200F\u200E\u206A\u202A\u206E\u206F\u200B\u206B\u200E\u202B\u206A\u206F\u206E\u200C\u202A\u206A\u200F\u200C\u206A\u206F\u202A\u206C\u202B\u202C\u202D\u202B\u202C\u200B\u200D\u200B\u200C\u202A\u206D\u200D\u206E\u202C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this))) != 3) ? 2663336816U : 3795820860U) ^ (num7 * 1545945755U));
							continue;
						case 10U:
							goto IL_00B2;
						case 11U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(Singleton<GameMaster>.Instance, this.<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11());
							num6 = (int)((num7 * 2041653295U) ^ 589314244U);
							continue;
						case 12U:
							goto IL_01DA;
						case 13U:
							num6 = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u200E\u202A\u206B\u202E\u206E\u202C\u206C\u206F\u202A\u202B\u206C\u202E\u200F\u202C\u200E\u206E\u202C\u200D\u206D\u202C\u200D\u202A\u200E\u202E\u206E\u206F\u200B\u206B\u200E\u202C\u206C\u202D\u206C\u200C\u202B\u206A\u202B\u202D\u206C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this)) is EntryStation) ? 2889066265U : 2477434416U) ^ (num7 * 2389973304U));
							continue;
						}
						break;
					}
					return;
					IL_00B2:
					num6 = 1229588480;
					goto IL_00B7;
					IL_01DA:
					num6 = ((this.Story == null) ? 761041759 : 28441822);
					goto IL_00B7;
				});
				for (;;)
				{
					IL_003F:
					int num = -2010467550;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((num2 ^ ((-390071683 * (611513872 - 373474781)) ^ (-1670128443 ^ (1710685958 ^ -2009348265)))) + (-190747466 * 1188524753 - -187338660)) - 1442579738)) % 11U)
						{
						case 0U:
						{
							CardConfig cardConfig = AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1648413921));
							cardConfig.Keywords = AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202D\u206C\u200E\u200C\u206E\u200D\u200C\u202A\u200B\u202A\u206D\u206F\u200F\u206C\u206B\u206A\u202A\u200D\u206B\u202D\u206C\u206F\u200E\u200B\u200B\u202C\u202D\u202D\u200F\u206E\u200B\u202B\u202A\u206D\u206E\u200D\u202D\u202C\u206B\u202E(cardConfig) + 8388608UL;
							num = (int)((num3 * 538853735U) ^ 96263365U);
							continue;
						}
						case 1U:
							num = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u206E\u206E\u202A\u206C\u200D\u206A\u202C\u206F\u206E\u206C\u202B\u206B\u206F\u206D\u200B\u202A\u206D\u206E\u202C\u206A\u200E\u206F\u200F\u206D\u200B\u202C\u202C\u200D\u202E\u206B\u200F\u200E\u206E\u202A\u206C\u200C\u206B\u200E\u202E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202D\u206C\u200E\u200C\u206E\u200D\u200C\u202A\u200B\u202A\u206D\u206F\u200F\u206C\u206B\u206A\u202A\u200D\u206B\u202D\u206C\u206F\u200E\u200B\u200B\u202C\u202D\u202D\u200F\u206E\u200B\u202B\u202A\u206D\u206E\u200D\u202D\u202C\u206B\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1061091270))), Keyword.Replenish)) ? 1024583691U : 17459215U) ^ (num3 * 3679836993U));
							continue;
						case 2U:
							goto IL_003F;
						case 3U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(12055020)).Value1 = new int?(2);
							num = -746325070;
							continue;
						case 4U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(643499380)).Damage = new int?(12);
							AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139)).Value1 = new int?(1);
							num = (int)((num3 * 730490036U) ^ 1222379506U);
							continue;
						case 5U:
							AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(643499380)).TargetType = new TargetType?(TargetType.SingleEnemy);
							num = (int)((num3 * 117058283U) ^ 3096942329U);
							continue;
						case 6U:
							base.HandleGameRunEvent<StationEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u202A\u200F\u206C\u202C\u206D\u200B\u202C\u202A\u206A\u206D\u202D\u200C\u202E\u202B\u202B\u206D\u202B\u200B\u202B\u206A\u202B\u200F\u200C\u202B\u202B\u202E\u200E\u200F\u206A\u206B\u200E\u206D\u206D\u200B\u202E\u202C\u202E\u200C\u202D\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this)), delegate(StationEventArgs args)
							{
								BossStation bossStation = AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202D\u202B\u202B\u200F\u200C\u206D\u200F\u200E\u202D\u202E\u200C\u206F\u202D\u200F\u200F\u200E\u206F\u200B\u200B\u206F\u202B\u206A\u200B\u202E\u202B\u200C\u202B\u206D\u202A\u202B\u200F\u200E\u206A\u202C\u200F\u200C\u206F\u206E\u206B\u202E(args) as BossStation;
								if (bossStation != null)
								{
									for (;;)
									{
										IL_0012:
										int num8 = 1107361100;
										for (;;)
										{
											int num9 = num8;
											uint num10;
											switch ((num10 = (uint)(num9 - (2007714875 + (-282803406 + -558606604)) + -2103281573)) % 45U)
											{
											case 0U:
												num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-587050987))) ? 676858323 : 1106874235);
												continue;
											case 1U:
											{
												ConfigEntry<string> ayaRecords = BepinexPlugin.AyaRecords;
												ayaRecords.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1159078085) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992253390));
												num8 = -522037499;
												continue;
											}
											case 2U:
											{
												string text;
												num8 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200F\u200B\u200B\u202B\u206D\u206C\u200F\u202B\u206C\u206D\u202B\u200B\u200B\u206C\u206C\u206F\u200C\u200C\u206E\u206A\u200D\u206D\u202A\u206B\u202B\u206D\u202A\u200C\u206C\u206B\u200D\u200E\u202B\u200D\u202D\u202B\u206B\u206D\u202C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-740064647)) ? 3741014808U : 146539645U) ^ (num10 * 2546237912U));
												continue;
											}
											case 3U:
											{
												GameDifficulty gameDifficulty;
												switch (gameDifficulty)
												{
												case GameDifficulty.Normal:
													goto IL_096A;
												case GameDifficulty.Hard:
													goto IL_0189;
												case GameDifficulty.Lunatic:
													goto IL_0127;
												default:
													num8 = (int)((num10 * 1400987368U) ^ 1665607483U);
													continue;
												}
												break;
											}
											case 4U:
											{
												string text = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200C\u200B\u206B\u202D\u206A\u206E\u200C\u206B\u202A\u206B\u200C\u206A\u200E\u200B\u206A\u206F\u206A\u202A\u200D\u200E\u202A\u202D\u202E\u206C\u200C\u202C\u200F\u206A\u206C\u206D\u206B\u206F\u206C\u202E\u206B\u202A\u200D\u206D\u206C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202A\u202D\u200C\u206F\u202C\u206D\u202D\u202A\u200F\u206E\u206B\u200F\u200C\u202E\u202B\u206A\u202C\u200C\u206F\u206F\u200E\u206D\u202A\u202D\u206D\u202D\u202C\u202B\u202D\u200D\u206C\u206D\u200C\u200D\u206C\u202A\u206D\u200F\u202E(bossStation));
												num8 = 782856060;
												continue;
											}
											case 5U:
												num8 = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1846231148))) ? 4062559649U : 497521426U) ^ (num10 * 4044460613U));
												continue;
											case 6U:
												num8 = (AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(108923543)) ? 799834010 : 434470075);
												continue;
											case 7U:
											{
												ConfigEntry<string> ayaRecords2 = BepinexPlugin.AyaRecords;
												ayaRecords2.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords2.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1846231148) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2080244895));
												num8 = 142211009;
												continue;
											}
											case 8U:
												num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1306769277))) ? 557855642 : (-905939798));
												continue;
											case 9U:
												return;
											case 10U:
											{
												ConfigEntry<string> ayaRecords3 = BepinexPlugin.AyaRecords;
												ayaRecords3.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords3.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(233109519) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1682449211));
												num8 = 787957727;
												continue;
											}
											case 11U:
												num8 = (AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(896324297)) ? 654375645 : 418842964);
												continue;
											case 12U:
												num8 = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.\u206C\u200C\u206B\u206B\u206A\u206F\u202A\u202E\u200D\u200D\u202C\u206C\u200C\u200F\u206B\u206C\u200C\u202B\u200E\u200F\u200E\u202E\u202C\u202B\u206F\u206E\u202A\u206E\u200B\u202E\u200B\u200D\u206F\u200C\u206B\u202B\u202B\u200C\u200E\u206F\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u206C\u202D\u206C\u200B\u206C\u200B\u200C\u202C\u206D\u202A\u206E\u200E\u206A\u202E\u206A\u206F\u202B\u202D\u200B\u200C\u202E\u200C\u202C\u200E\u200D\u206B\u200F\u206E\u202A\u202D\u206A\u202E\u206A\u202E\u202D\u206C\u206F\u206E\u200E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this))) != 7) ? 675813119U : 3798797695U) ^ (num10 * 281266429U));
												continue;
											case 13U:
												num8 = ((!BepinexPlugin.AyaPhantasmMode.Value) ? (-522037499) : 929021617);
												continue;
											case 14U:
											{
												string text;
												num8 = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200F\u200B\u200B\u202B\u206D\u206C\u200F\u202B\u206C\u206D\u202B\u200B\u200B\u206C\u206C\u206F\u200C\u200C\u206E\u206A\u200D\u206D\u202A\u206B\u202B\u206D\u202A\u200C\u206C\u206B\u200D\u200E\u202B\u200D\u202D\u202B\u206B\u206D\u202C\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1521396416))) ? 2735646947U : 2184381666U) ^ (num10 * 2491671472U));
												continue;
											}
											case 15U:
											{
												ConfigEntry<string> ayaRecords4 = BepinexPlugin.AyaRecords;
												ayaRecords4.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords4.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1423706636) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(92349307));
												num8 = -905939798;
												continue;
											}
											case 16U:
											{
												ConfigEntry<string> ayaRecords5 = BepinexPlugin.AyaRecords;
												ayaRecords5.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords5.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(345750544) : <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1860268738));
												num8 = 1106874235;
												continue;
											}
											case 17U:
												num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-2143745162))) ? 798670501 : (-965824389));
												continue;
											case 18U:
												num8 = ((!BepinexPlugin.AyaPhantasmMode.Value) ? (-522037499) : 15801176);
												continue;
											case 19U:
											{
												ConfigEntry<string> ayaRecords6 = BepinexPlugin.AyaRecords;
												ayaRecords6.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords6.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1529409580) : <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1068171397));
												num8 = -437977292;
												continue;
											}
											case 20U:
											{
												GameDifficulty gameDifficulty = AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u206C\u202C\u202C\u202B\u206A\u200E\u206C\u200F\u200B\u202C\u200F\u202B\u202D\u202A\u200E\u202B\u202C\u206E\u202B\u206E\u206A\u202D\u202C\u202D\u206F\u200D\u206B\u202D\u202E\u202A\u206D\u202E\u200B\u206F\u200F\u200F\u200F\u206C\u202D\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this));
												num8 = (int)((num10 * 1750119737U) ^ 952507184U);
												continue;
											}
											case 21U:
												return;
											case 22U:
												goto IL_0189;
											case 23U:
												num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1760166112))) ? (-50719809) : (-437977292));
												continue;
											case 24U:
												num8 = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(574401389))) ? 2150078277U : 2550364107U) ^ (num10 * 956377231U));
												continue;
											case 25U:
												num8 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1784914516)) ? 2431738435U : 2305720240U) ^ (num10 * 2658238245U));
												continue;
											case 26U:
												num8 = (AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1249202796)) ? (-965824389) : 1083659336);
												continue;
											case 27U:
											{
												ConfigEntry<string> ayaRecords7 = BepinexPlugin.AyaRecords;
												ayaRecords7.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords7.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1261629235) : <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(567109755));
												num8 = -965824389;
												continue;
											}
											case 28U:
											{
												string text;
												num8 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200F\u200B\u200B\u202B\u206D\u206C\u200F\u202B\u206C\u206D\u202B\u200B\u200B\u206C\u206C\u206F\u200C\u200C\u206E\u206A\u200D\u206D\u202A\u206B\u202B\u206D\u202A\u200C\u206C\u206B\u200D\u200E\u202B\u200D\u202D\u202B\u206B\u206D\u202C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(271706238)) ? 1259245258U : 2534231595U) ^ (num10 * 276424336U));
												continue;
											}
											case 29U:
											{
												ConfigEntry<string> ayaRecords8 = BepinexPlugin.AyaRecords;
												ayaRecords8.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords8.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1586484730) : <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1780542701));
												num8 = -965824389;
												continue;
											}
											case 30U:
											{
												ConfigEntry<string> ayaRecords9 = BepinexPlugin.AyaRecords;
												ayaRecords9.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords9.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-35307470) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(799217437));
												num8 = -814538917;
												continue;
											}
											case 31U:
												goto IL_096A;
											case 32U:
											{
												ConfigEntry<string> ayaRecords10 = BepinexPlugin.AyaRecords;
												ayaRecords10.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords10.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(896324297) : <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(179707450));
												num8 = 654375645;
												continue;
											}
											case 33U:
												AyaPlayerUnitDef.AyaPlayerUnit.BossStationFinished = true;
												AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u202A\u206C\u206E\u206D\u202C\u206B\u200C\u200C\u202C\u200F\u206C\u202A\u200F\u200E\u202A\u200B\u200D\u206D\u206D\u206B\u200E\u200F\u200D\u200D\u206F\u202E\u202E\u200C\u202D\u200F\u200B\u206C\u206F\u202B\u202E\u206A\u206F\u202B\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1766289101)));
												num8 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.\u206B\u206E\u202E\u206D\u202E\u206E\u202B\u202B\u206A\u200E\u206B\u202B\u202D\u206A\u206E\u200E\u206E\u200F\u206E\u206B\u202C\u206D\u202B\u202A\u206A\u202B\u200B\u200B\u202E\u206A\u200C\u206F\u200C\u200E\u200D\u206A\u206A\u202B\u202D\u200D\u202E(bossStation) ? 3718938986U : 55877071U) ^ (num10 * 3758760798U));
												continue;
											case 34U:
												goto IL_0127;
											case 35U:
												num8 = (BepinexPlugin.AyaPhantasmMode.Value ? (-751237548) : (-522037499));
												continue;
											case 36U:
												goto IL_0012;
											case 37U:
												num8 = (int)((num10 * 3187143449U) ^ 2512925971U);
												continue;
											case 38U:
											{
												ConfigEntry<string> ayaRecords11 = BepinexPlugin.AyaRecords;
												ayaRecords11.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords11.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1200773921) : <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-173787288));
												num8 = 799834010;
												continue;
											}
											case 39U:
												num8 = (int)((BepinexPlugin.AyaPhantasmMode.Value ? 687730598U : 4101560327U) ^ (num10 * 355453566U));
												continue;
											case 40U:
												num8 = (int)((num10 * 3368776795U) ^ 3183264284U);
												continue;
											case 41U:
											{
												ConfigEntry<string> ayaRecords12 = BepinexPlugin.AyaRecords;
												ayaRecords12.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords12.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1305421533) : <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1949513420));
												num8 = 385708974;
												continue;
											}
											case 42U:
												return;
											case 43U:
											{
												ConfigEntry<string> ayaRecords13 = BepinexPlugin.AyaRecords;
												ayaRecords13.Value = AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(ayaRecords13.Value, AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1323247102) : <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(308735777));
												num8 = 889489579;
												continue;
											}
											}
											goto Block_1;
											IL_0127:
											num8 = (AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1536886552)) ? 787957727 : 1102409412);
											continue;
											IL_0189:
											num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1305421533))) ? 68009565 : 889489579);
											continue;
											IL_096A:
											num8 = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(233109519))) ? 958436533 : (-965824389));
										}
									}
									Block_1:
									return;
								}
							});
							base.HandleGameRunEvent<DamageEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u202D\u200D\u206D\u200D\u206C\u200E\u202E\u202C\u200F\u202A\u200B\u200C\u206C\u206D\u200B\u200C\u200F\u200C\u202C\u202E\u206E\u206A\u200F\u202B\u206F\u206D\u206D\u202D\u202E\u206B\u200B\u200E\u200E\u200C\u200B\u202E\u206B\u200F\u200E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202A\u202E\u206D\u200B\u202D\u202D\u200B\u202A\u206D\u200E\u206C\u206B\u206A\u200B\u202A\u202B\u202E\u206F\u200E\u202A\u202C\u202A\u200C\u202B\u200B\u206F\u202C\u202B\u206E\u202B\u200D\u206D\u200F\u202E\u206A\u200E\u206F\u200F\u206B\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this))), delegate(DamageEventArgs _)
							{
								if (AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence < 3)
								{
									for (;;)
									{
										IL_000B:
										int num11 = 366946428;
										for (;;)
										{
											int num12 = num11;
											uint num13;
											switch ((num13 = (uint)(-(uint)(num12 - (707359538 - -(1944409802 ^ 1960463532))))) % 6U)
											{
											case 0U:
												AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u202A\u206C\u206E\u206D\u202C\u206B\u200C\u200C\u202C\u200F\u206C\u202A\u200F\u200E\u202A\u200B\u200D\u206D\u206D\u206B\u200E\u200F\u200D\u200D\u206F\u202E\u202E\u200C\u202D\u200F\u200B\u206C\u206F\u202B\u202E\u206A\u206F\u202B\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, ((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.66f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(186071857)) : (((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.33f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1083895517)) : BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-597043291))));
												num11 = 141797757;
												continue;
											case 1U:
												num11 = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.BossStationFinished) ? 363741057U : 3387247173U) ^ (num13 * 3055111369U));
												continue;
											case 2U:
												num11 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.FinalBossTransition ? 206077141U : 3268954459U) ^ (num13 * 650581062U));
												continue;
											case 3U:
												goto IL_000B;
											case 4U:
												return;
											}
											goto Block_1;
										}
									}
									Block_1:
									return;
								}
							});
							base.HandleGameRunEvent<HealEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u200E\u206C\u206D\u206B\u200E\u200D\u200E\u206C\u202A\u202B\u206A\u206F\u202B\u202B\u206F\u200C\u206C\u202B\u202C\u202A\u206C\u202C\u200B\u206A\u206A\u200F\u202D\u206F\u202C\u200D\u202B\u206D\u206D\u206D\u206B\u206A\u202B\u206B\u202C\u202A\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202A\u202E\u206D\u200B\u202D\u202D\u200B\u202A\u206D\u200E\u206C\u206B\u206A\u200B\u202A\u202B\u202E\u206F\u200E\u202A\u202C\u202A\u200C\u202B\u200B\u206F\u202C\u202B\u206E\u202B\u200D\u206D\u200F\u202E\u206A\u200E\u206F\u200F\u206B\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this))), delegate(HealEventArgs _)
							{
								if (AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence < 3)
								{
									for (;;)
									{
										IL_000B:
										int num14 = 303408082;
										for (;;)
										{
											int num15 = num14;
											uint num16;
											switch ((num16 = (uint)(~(uint)(~(uint)num15))) % 6U)
											{
											case 0U:
												goto IL_000B;
											case 2U:
												AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u202A\u206C\u206E\u206D\u202C\u206B\u200C\u200C\u202C\u200F\u206C\u202A\u200F\u200E\u202A\u200B\u200D\u206D\u206D\u206B\u200E\u200F\u200D\u200D\u206F\u202E\u202E\u200C\u202D\u200F\u200B\u206C\u206F\u202B\u202E\u206A\u206F\u202B\u206F\u202E(UiManager.GetPanel<SystemBoard>().characterImage, ((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.66f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(186071857)) : (((float)AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(this) / (float)AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(this) > 0.33f) ? BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(628315381)) : BepinexPlugin.ayaShameimaru.LoadAsset<Sprite>(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1310305497))));
												num14 = 1605051601;
												continue;
											case 3U:
												num14 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.BossStationFinished ? 4255494419U : 2315525934U) ^ (num16 * 1006674708U));
												continue;
											case 4U:
												num14 = (int)((AyaPlayerUnitDef.AyaPlayerUnit.FinalBossTransition ? 44260969U : 234838141U) ^ (num16 * 4218633468U));
												continue;
											case 5U:
												return;
											}
											goto Block_1;
										}
									}
									Block_1:
									return;
								}
							});
							num = (int)((num3 * 2192644776U) ^ 3111169734U);
							continue;
						case 7U:
						{
							GameRunController gameRunController = AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(this);
							int num4 = AyaPlayerUnitDef.AyaPlayerUnit.\u202E\u200F\u206D\u206D\u202B\u200E\u206A\u206E\u202E\u206F\u200B\u202E\u206B\u200E\u206D\u202D\u200E\u200C\u206C\u200C\u206A\u202A\u202E\u206D\u206A\u202C\u202E\u202A\u200E\u202B\u206F\u206F\u202E\u200B\u200F\u206B\u200E\u206A\u202A\u200F\u202E(gameRunController);
							AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u202D\u202E\u206B\u206C\u206E\u206B\u202A\u206B\u200C\u206A\u200D\u200B\u200F\u202D\u200B\u202D\u200C\u200C\u200D\u206F\u202D\u202B\u200F\u206E\u206C\u200E\u200E\u202C\u202C\u202A\u206F\u206E\u202C\u202E\u200F\u202D\u202C\u200E\u200C\u202E(gameRunController, num4 + 1);
							num = (int)((num3 * 1148001734U) ^ 3214599817U);
							continue;
						}
						case 8U:
							num = ((!AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u206E\u206E\u202A\u206C\u200D\u206A\u202C\u206F\u206E\u206C\u202B\u206B\u206F\u206D\u200B\u202A\u206D\u206E\u202C\u206A\u200E\u206F\u200F\u206D\u200B\u202C\u202C\u200D\u202E\u206B\u200F\u200E\u206E\u202A\u206C\u200C\u206B\u200E\u202E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202D\u206C\u200E\u200C\u206E\u200D\u200C\u202A\u200B\u202A\u206D\u206F\u200F\u206C\u206B\u206A\u202A\u200D\u206B\u202D\u206C\u206F\u200E\u200B\u200B\u202C\u202D\u202D\u200F\u206E\u200B\u202B\u202A\u206D\u206E\u200D\u202D\u202C\u206B\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(750788562))), Keyword.Replenish)) ? (-525656499) : (-169743842));
							continue;
						case 9U:
						{
							CardConfig cardConfig2 = AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1061091270));
							cardConfig2.Keywords = AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u202D\u206C\u200E\u200C\u206E\u200D\u200C\u202A\u200B\u202A\u206D\u206F\u200F\u206C\u206B\u206A\u202A\u200D\u206B\u202D\u206C\u206F\u200E\u200B\u200B\u202C\u202D\u202D\u200F\u206E\u200B\u202B\u202A\u206D\u206E\u200D\u202D\u202C\u206B\u202E(cardConfig2) + 8388608UL;
							num = (int)((num3 * 4070526341U) ^ 4175801020U);
							continue;
						}
						}
						return;
					}
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence = 0;
				this.fastAttack = false;
				for (;;)
				{
					IL_000D:
					int num = 530978504;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(num2 + ~249545154) * -82242935))) % 6U)
						{
						case 0U:
							base.ReactBattleEvent<GameEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u206C\u206B\u202A\u200F\u202C\u206E\u206A\u202D\u206C\u200F\u202B\u206D\u200E\u200D\u202E\u200C\u202A\u206B\u206C\u202E\u200B\u200F\u202C\u200C\u202A\u202B\u200B\u202E\u202C\u206D\u202E\u206F\u200D\u206F\u206C\u202E\u206A\u202E\u200E\u202E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleEnding));
							num = (int)((num3 * 3632465056U) ^ 3045639961U);
							continue;
						case 2U:
							base.ReactBattleEvent<GameEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u202D\u202C\u200C\u202C\u206D\u200B\u202E\u200D\u200E\u200C\u200C\u202C\u206A\u202B\u206B\u202B\u200E\u202D\u200F\u206D\u206C\u200B\u200E\u206C\u206B\u206B\u202E\u206F\u206C\u202E\u200E\u206C\u206A\u200D\u206D\u206B\u206C\u200E\u202A\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<GameEventArgs, IEnumerable<BattleAction>>(this.OnBattleStarted));
							num = (int)((num3 * 3089843336U) ^ 3160768261U);
							continue;
						case 3U:
							base.ReactBattleEvent<CardsEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u200B\u206D\u202D\u200C\u202D\u206E\u206E\u206D\u206C\u202B\u200B\u206C\u206C\u206C\u200F\u202D\u200D\u202C\u202B\u200F\u206E\u200C\u206C\u206C\u206C\u202A\u200B\u200E\u206D\u200D\u202C\u206B\u206F\u206B\u200E\u206B\u202D\u206C\u200E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<CardsEventArgs, IEnumerable<BattleAction>>(this.OnCardsAddingToDiscard));
							base.ReactBattleEvent<CardsAddingToDrawZoneEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206E\u202B\u206E\u206B\u200E\u206E\u202C\u206F\u206B\u202E\u206E\u206C\u200F\u202A\u200B\u206B\u200B\u200B\u206D\u206A\u200F\u206C\u200C\u206B\u200B\u202C\u202B\u202C\u200D\u202C\u202A\u200B\u200C\u206A\u206C\u202E\u202D\u206D\u206E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<CardsAddingToDrawZoneEventArgs, IEnumerable<BattleAction>>(this.OnCardsAddingToDrawZone));
							base.ReactBattleEvent<CardsEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u200D\u200E\u206D\u206F\u206A\u200E\u202D\u200F\u206F\u200B\u200D\u206B\u206A\u206A\u206D\u200D\u200F\u202B\u206B\u202B\u202C\u202D\u200C\u200C\u202D\u206A\u200D\u202E\u206E\u206D\u202E\u206D\u202B\u206C\u206D\u200D\u206E\u206E\u200B\u202D\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<CardsEventArgs, IEnumerable<BattleAction>>(this.OnCardsAddingToExile));
							base.ReactBattleEvent<CardsEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u202D\u206E\u206F\u202D\u200C\u200D\u202D\u202C\u202C\u202B\u200F\u202C\u200F\u200B\u202A\u200D\u202E\u200D\u200F\u206A\u200B\u206C\u202C\u206C\u206D\u206D\u206F\u206D\u202C\u202C\u202D\u200E\u206E\u206B\u200B\u200D\u200D\u206E\u200C\u206E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this)), new Func<CardsEventArgs, IEnumerable<BattleAction>>(this.OnCardsAddingToHand));
							base.ReactBattleEvent<StatisticalDamageEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u206A\u206C\u202B\u200B\u202C\u200E\u200E\u202E\u206A\u206D\u200F\u202A\u200F\u206B\u202B\u206C\u202B\u200E\u206C\u202D\u206A\u202B\u200E\u200C\u206C\u206A\u202C\u200B\u206E\u206A\u206D\u206D\u200B\u206F\u206A\u200F\u202C\u200B\u200C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u200D\u200F\u202B\u202A\u206C\u200F\u202D\u206B\u206C\u200E\u202C\u200E\u200E\u202A\u202A\u202C\u200C\u206A\u206E\u200B\u200B\u206A\u200D\u200C\u200D\u202A\u206A\u206F\u206E\u200E\u202C\u206A\u202D\u202B\u200C\u202E\u200B\u206A\u202E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this))), new Func<StatisticalDamageEventArgs, IEnumerable<BattleAction>>(this.OnPlayerStatisticalTotalDamageDealt));
							num = (int)((num3 * 3135298430U) ^ 1891343531U);
							continue;
						case 4U:
							goto IL_000D;
						case 5U:
							base.HandleBattleEvent<DamageEventArgs>(AyaPlayerUnitDef.AyaPlayerUnit.\u206C\u206B\u200D\u202B\u200E\u200E\u200C\u200C\u200C\u200C\u206F\u202E\u206F\u202B\u206A\u200C\u200F\u206D\u206D\u206E\u200B\u206B\u206F\u202C\u206A\u202C\u200C\u206A\u206C\u200F\u202A\u200C\u200B\u206D\u206C\u206C\u206C\u202E\u206B\u202A\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u202C\u200D\u200F\u202B\u202A\u206C\u200F\u202D\u206B\u206C\u200E\u202C\u200E\u200E\u202A\u202A\u202C\u200C\u206A\u206E\u200B\u200B\u206A\u200D\u200C\u200D\u202A\u206A\u206F\u206E\u200E\u202C\u206A\u202D\u202B\u200C\u202E\u200B\u206A\u202E\u202E(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(this))), new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking));
							num = (int)((num3 * 2416786826U) ^ 408790162U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnBattleStarted>d__246 <OnBattleStarted>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnBattleStarted>d__246(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			private IEnumerable<BattleAction> LongCardUsed(CardUsingEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<LongCardUsed>d__247 <LongCardUsed>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<LongCardUsed>d__247(-2);
				<LongCardUsed>d__.<>4__this = this;
				<LongCardUsed>d__.<>3__arg = arg;
				return <LongCardUsed>d__;
			}

			private IEnumerable<BattleAction> AyaRoundStarting(GameEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<AyaRoundStarting>d__248 <AyaRoundStarting>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<AyaRoundStarting>d__248(-2);
				<AyaRoundStarting>d__.<>4__this = this;
				return <AyaRoundStarting>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToDiscard(CardsEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToDiscard>d__249 <OnCardsAddingToDiscard>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToDiscard>d__249(-2);
				<OnCardsAddingToDiscard>d__.<>4__this = this;
				<OnCardsAddingToDiscard>d__.<>3__arg = arg;
				return <OnCardsAddingToDiscard>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToDrawZone(CardsAddingToDrawZoneEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToDrawZone>d__250 <OnCardsAddingToDrawZone>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToDrawZone>d__250(-2);
				<OnCardsAddingToDrawZone>d__.<>4__this = this;
				<OnCardsAddingToDrawZone>d__.<>3__arg = arg;
				return <OnCardsAddingToDrawZone>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToExile(CardsEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToExile>d__251 <OnCardsAddingToExile>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToExile>d__251(-2);
				<OnCardsAddingToExile>d__.<>4__this = this;
				<OnCardsAddingToExile>d__.<>3__arg = arg;
				return <OnCardsAddingToExile>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToHand(CardsEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToHand>d__252 <OnCardsAddingToHand>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnCardsAddingToHand>d__252(-2);
				<OnCardsAddingToHand>d__.<>4__this = this;
				<OnCardsAddingToHand>d__.<>3__arg = arg;
				return <OnCardsAddingToHand>d__;
			}

			private IEnumerable<BattleAction> OnPlayerStatisticalTotalDamageDealt(StatisticalDamageEventArgs args)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnPlayerStatisticalTotalDamageDealt>d__253 <OnPlayerStatisticalTotalDamageDealt>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnPlayerStatisticalTotalDamageDealt>d__253(-2);
				<OnPlayerStatisticalTotalDamageDealt>d__.<>4__this = this;
				<OnPlayerStatisticalTotalDamageDealt>d__.<>3__args = args;
				return <OnPlayerStatisticalTotalDamageDealt>d__;
			}

			private void OnPlayerDamageTaking(DamageEventArgs args)
			{
				if (AyaPlayerUnitDef.AyaPlayerUnit.\u200F\u200B\u206C\u200E\u202B\u202E\u200C\u202E\u202E\u206A\u206A\u200E\u206C\u206B\u200D\u202E\u202A\u202E\u206E\u202D\u202E\u202E\u202D\u200B\u200F\u200C\u206C\u206A\u200E\u200E\u206B\u202C\u202B\u206C\u202A\u206C\u202D\u202C\u202E\u206F\u202E(args) is FastAttack)
				{
					for (;;)
					{
						IL_0010:
						int num = 720509125;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((num2 ^ ((1018845812 ^ -1103442864 ^ -623814350) + ~(~1434133574))) - (-2042136183 ^ 315344486) * 148444167)) % 11U)
							{
							case 0U:
								num = (int)(((AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence == 0) ? 500204368U : 2414159735U) ^ (num3 * 3752857246U));
								continue;
							case 1U:
								num = (int)(((!this.fastAttack) ? 3014547884U : 3430229239U) ^ (num3 * 1837299890U));
								continue;
							case 2U:
								this.fastAttacks.Shuffle(RandomGen.InitGen);
								this.fastAttacks.Remove(this.fastAttacks.First<string>());
								num = (int)((num3 * 669038525U) ^ 2509404037U);
								continue;
							case 3U:
								goto IL_0010;
							case 5U:
								AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u200C\u202D\u206F\u206D\u202C\u200C\u206E\u206E\u200E\u206A\u202C\u202A\u202D\u200E\u206E\u206C\u200C\u206C\u200D\u202D\u200F\u200E\u206A\u206C\u202E\u206E\u200E\u200F\u206C\u206A\u206C\u202D\u206E\u202C\u200E\u206D\u206A\u200E\u206C\u202E(this.GetView<UnitView>(), this.fastAttacks.First<string>(), 2f, ChatWidget.CloudType.RightTalk, 0.5f);
								num = (int)((num3 * 1280792841U) ^ 1046923044U);
								continue;
							case 6U:
								AyaPlayerUnitDef.AyaPlayerUnit.\u200C\u206F\u200F\u206A\u200B\u202D\u206C\u202B\u202D\u206A\u206A\u202C\u200D\u206B\u202E\u202A\u206C\u206D\u202B\u202D\u200E\u202E\u202E\u206D\u200F\u206B\u200F\u206F\u202E\u202C\u206E\u200F\u206D\u202D\u202E\u206F\u206B\u200E\u206D\u200C\u202E(args, new DamageInfo(0f, AyaPlayerUnitDef.AyaPlayerUnit.\u206F\u206E\u206B\u200C\u202D\u200C\u200E\u206D\u202C\u206A\u200F\u200F\u206D\u202B\u202A\u200C\u200D\u202C\u206F\u206A\u202C\u206E\u206F\u202B\u206E\u206A\u206D\u206C\u200C\u200B\u202D\u200E\u200E\u206B\u200E\u202A\u206C\u202E\u206A\u206E\u202E(args).DamageType, true, false, false).BlockBy(AyaPlayerUnitDef.AyaPlayerUnit.\u206B\u200E\u202A\u200C\u200D\u206D\u206B\u206D\u206C\u200F\u200C\u206D\u202E\u200D\u202B\u202B\u206D\u200B\u202E\u206D\u200D\u200D\u200B\u200F\u206D\u200D\u202C\u200B\u202A\u206F\u202E\u206B\u206D\u206C\u206B\u206C\u202D\u200B\u202D\u202A\u202E(this)).ShieldBy(AyaPlayerUnitDef.AyaPlayerUnit.\u206A\u202A\u202B\u202A\u202D\u200B\u202B\u202E\u206E\u206B\u200F\u202C\u200B\u202C\u200D\u206F\u206B\u206E\u206A\u206B\u202C\u202A\u206C\u202B\u202A\u200F\u200F\u206F\u202B\u200B\u200F\u200E\u200F\u202D\u202C\u206F\u206F\u202C\u200E\u202A\u202E(this)));
								AyaPlayerUnitDef.AyaPlayerUnit.\u206E\u200D\u206C\u200B\u200D\u202C\u206B\u200B\u202A\u202D\u206C\u206E\u206C\u206E\u200D\u200B\u200D\u202E\u202E\u202C\u202D\u200C\u202C\u200B\u200B\u200E\u200E\u200E\u202C\u206A\u206C\u206C\u200B\u206D\u200F\u202A\u202E\u200C\u202A\u202E\u202E(args, this);
								num = -885144699;
								continue;
							case 7U:
								num = (this.fastAttacks.NotEmpty<string>() ? (-450459636) : (-1878345307));
								continue;
							case 8U:
								this.fastAttacks.Remove(this.fastAttacks.First<string>());
								num = (int)((num3 * 456519031U) ^ 805160577U);
								continue;
							case 9U:
								this.fastAttack = true;
								num = (int)((num3 * 4248236706U) ^ 761045661U);
								continue;
							case 10U:
								this.fastAttacks = new List<string> { this.AyaFastAttack1Aya, this.AyaFastAttack2Aya, this.AyaFastAttack3Aya };
								num = (int)((num3 * 663696618U) ^ 2329311139U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> OnBattleEnding(GameEventArgs args)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<OnBattleEnding>d__257 <OnBattleEnding>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<OnBattleEnding>d__257(-2);
				<OnBattleEnding>d__.<>4__this = this;
				return <OnBattleEnding>d__;
			}

			private IEnumerable<BattleAction> FinalBossPlayerTurnEnded(UnitEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossPlayerTurnEnded>d__258 <FinalBossPlayerTurnEnded>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossPlayerTurnEnded>d__258(-2);
				<FinalBossPlayerTurnEnded>d__.<>4__this = this;
				return <FinalBossPlayerTurnEnded>d__;
			}

			private IEnumerable<BattleAction> FinalBossPlayerDying(DieEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossPlayerDying>d__259 <FinalBossPlayerDying>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossPlayerDying>d__259(-2);
				<FinalBossPlayerDying>d__.<>4__this = this;
				<FinalBossPlayerDying>d__.<>3__arg = arg;
				return <FinalBossPlayerDying>d__;
			}

			private IEnumerable<BattleAction> FinalBossAllEnemyTurnStarting(GameEventArgs arg)
			{
				return new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossAllEnemyTurnStarting>d__260(-2);
			}

			private IEnumerable<BattleAction> FinalBossAllEnemyTurnEnded(GameEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossAllEnemyTurnEnded>d__261 <FinalBossAllEnemyTurnEnded>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossAllEnemyTurnEnded>d__261(-2);
				<FinalBossAllEnemyTurnEnded>d__.<>4__this = this;
				return <FinalBossAllEnemyTurnEnded>d__;
			}

			private IEnumerable<BattleAction> FinalBossCardUsed(CardUsingEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCardUsed>d__263 <FinalBossCardUsed>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCardUsed>d__263(-2);
				<FinalBossCardUsed>d__.<>4__this = this;
				return <FinalBossCardUsed>d__;
			}

			private IEnumerable<BattleAction> FinalBossEnemySpawned(UnitEventArgs args)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossEnemySpawned>d__264 <FinalBossEnemySpawned>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossEnemySpawned>d__264(-2);
				<FinalBossEnemySpawned>d__.<>4__this = this;
				<FinalBossEnemySpawned>d__.<>3__args = args;
				return <FinalBossEnemySpawned>d__;
			}

			private IEnumerable<BattleAction> FinalBossCirnoDying(DieEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCirnoDying>d__265 <FinalBossCirnoDying>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCirnoDying>d__265(-2);
				<FinalBossCirnoDying>d__.<>4__this = this;
				<FinalBossCirnoDying>d__.<>3__arg = arg;
				return <FinalBossCirnoDying>d__;
			}

			private IEnumerable<BattleAction> FinalBossCirnoLived(DieEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCirnoLived>d__267 <FinalBossCirnoLived>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossCirnoLived>d__267(-2);
				<FinalBossCirnoLived>d__.<>4__this = this;
				return <FinalBossCirnoLived>d__;
			}

			private IEnumerable<BattleAction> FinalBossEnemyDied(DieEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossEnemyDied>d__269 <FinalBossEnemyDied>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossEnemyDied>d__269(-2);
				<FinalBossEnemyDied>d__.<>4__this = this;
				return <FinalBossEnemyDied>d__;
			}

			private IEnumerable<BattleAction> FinalBossDying(DieEventArgs arg)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossDying>d__270 <FinalBossDying>d__ = new AyaPlayerUnitDef.AyaPlayerUnit.<FinalBossDying>d__270(-2);
				<FinalBossDying>d__.<>4__this = this;
				<FinalBossDying>d__.<>3__arg = arg;
				return <FinalBossDying>d__;
			}

			protected override void OnLeaveBattle()
			{
				GameObject gameObject = AyaPlayerUnitDef.AyaPlayerUnit.background;
				if (gameObject == null)
				{
					return;
				}
				AyaPlayerUnitDef.AyaPlayerUnit.\u206D\u202B\u202C\u200E\u202D\u206B\u206F\u202E\u200D\u202D\u200E\u200D\u206C\u202B\u206F\u200D\u206E\u206D\u202B\u202C\u206D\u206F\u206E\u200F\u206B\u200D\u206F\u206D\u202B\u200F\u200F\u202E\u206A\u206F\u202E\u200D\u200E\u202A\u206A\u206E\u202E(gameObject, false);
			}

			public UniTask<UnitView> LoadDummyAsync(EnemyUnit child, EnemyUnit parent, Action clickAction)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<LoadDummyAsync>d__272 <LoadDummyAsync>d__;
				<LoadDummyAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UnitView>.Create();
				<LoadDummyAsync>d__.child = child;
				for (;;)
				{
					IL_0014:
					int num = 977172023;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(((num2 - ((~-823020272 - ~1280225788) ^ (-598317019 * (-1053261370 - -1327146659)))) ^ (~1033815341 + ~1126026532)) - ~-321334610))) % 5U)
						{
						case 0U:
							goto IL_0014;
						case 2U:
							<LoadDummyAsync>d__.parent = parent;
							num = (int)((num3 * 1420004453U) ^ 633293120U);
							continue;
						case 3U:
							<LoadDummyAsync>d__.<>1__state = -1;
							num = (int)((num3 * 1165081269U) ^ 1165480478U);
							continue;
						case 4U:
							<LoadDummyAsync>d__.clickAction = clickAction;
							num = (int)((num3 * 2905560715U) ^ 2592132309U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				<LoadDummyAsync>d__.<>t__builder.Start<AyaPlayerUnitDef.AyaPlayerUnit.<LoadDummyAsync>d__272>(ref <LoadDummyAsync>d__);
				return <LoadDummyAsync>d__.<>t__builder.Task;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[MethodImpl(MethodImplOptions.NoInlining)]
			static AyaPlayerUnit()
			{
				for (;;)
				{
					IL_000C:
					int num = 1277229134;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(-(num2 + 953927375 * -1314368082) + --1857114026))) % 4U)
						{
						case 1U:
							AyaPlayerUnitDef.AyaPlayerUnit.FinalBoss = null;
							num = (int)((num3 * 3256578489U) ^ 4027422629U);
							continue;
						case 2U:
							AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence = 0;
							num = (int)((num3 * 1927072373U) ^ 2078654107U);
							continue;
						case 3U:
							goto IL_000C;
						}
						goto Block_1;
					}
				}
				Block_1:
				AyaPlayerUnitDef.AyaPlayerUnit.FinalBossTransition = false;
				AyaPlayerUnitDef.AyaPlayerUnit.background = AyaPlayerUnitDef.AyaPlayerUnit.\u202E\u200E\u202B\u206C\u206F\u206E\u206F\u202A\u202A\u202A\u202B\u200B\u200E\u200B\u200F\u200E\u206B\u202B\u206B\u202A\u206A\u200B\u206F\u206A\u200D\u206A\u206E\u206E\u206E\u200B\u206F\u206A\u202E\u202D\u206D\u202D\u206D\u200C\u202A\u206A\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(346148092), null);
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Init|244_0()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Init|244_0>d <<OnEnterGameRun>g__Init|244_0>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Init|244_0>d(0);
				<<OnEnterGameRun>g__Init|244_0>d.<>4__this = this;
				return <<OnEnterGameRun>g__Init|244_0>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Timer|244_1()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Timer|244_1>d <<OnEnterGameRun>g__Timer|244_1>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Timer|244_1>d(0);
				<<OnEnterGameRun>g__Timer|244_1>d.<>4__this = this;
				return <<OnEnterGameRun>g__Timer|244_1>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Return|244_8()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Return|244_8>d <<OnEnterGameRun>g__Return|244_8>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Return|244_8>d(0);
				<<OnEnterGameRun>g__Return|244_8>d.<>4__this = this;
				return <<OnEnterGameRun>g__Return|244_8>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__ChapterSelect|244_9()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__ChapterSelect|244_9>d <<OnEnterGameRun>g__ChapterSelect|244_9>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__ChapterSelect|244_9>d(0);
				<<OnEnterGameRun>g__ChapterSelect|244_9>d.<>4__this = this;
				return <<OnEnterGameRun>g__ChapterSelect|244_9>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Chapter1Act2Dialogue|244_10()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10>d <<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10>d(0);
				<<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10>d.<>4__this = this;
				return <<OnEnterGameRun>g__Chapter1Act2Dialogue|244_10>d;
			}

			[CompilerGenerated]
			private IEnumerator <OnEnterGameRun>g__Chapter1Act3Dialogue|244_11()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11>d <<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11>d(0);
				<<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11>d.<>4__this = this;
				return <<OnEnterGameRun>g__Chapter1Act3Dialogue|244_11>d;
			}

			[CompilerGenerated]
			private IEnumerator <FinalBossPlayerTurnEnded>g__Cinematic|258_2()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossPlayerTurnEnded>g__Cinematic|258_2>d <<FinalBossPlayerTurnEnded>g__Cinematic|258_2>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossPlayerTurnEnded>g__Cinematic|258_2>d(0);
				<<FinalBossPlayerTurnEnded>g__Cinematic|258_2>d.<>4__this = this;
				return <<FinalBossPlayerTurnEnded>g__Cinematic|258_2>d;
			}

			[CompilerGenerated]
			internal static IEnumerator <FinalBossPlayerTurnEnded>g__coroutine|258_12(EnemyUnit ayaDummy)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossPlayerTurnEnded>g__coroutine|258_12>d <<FinalBossPlayerTurnEnded>g__coroutine|258_12>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossPlayerTurnEnded>g__coroutine|258_12>d(0);
				<<FinalBossPlayerTurnEnded>g__coroutine|258_12>d.ayaDummy = ayaDummy;
				return <<FinalBossPlayerTurnEnded>g__coroutine|258_12>d;
			}

			[CompilerGenerated]
			private IEnumerator <FinalBossAllEnemyTurnEnded>g__Cinematic|261_0()
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossAllEnemyTurnEnded>g__Cinematic|261_0>d <<FinalBossAllEnemyTurnEnded>g__Cinematic|261_0>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossAllEnemyTurnEnded>g__Cinematic|261_0>d(0);
				<<FinalBossAllEnemyTurnEnded>g__Cinematic|261_0>d.<>4__this = this;
				return <<FinalBossAllEnemyTurnEnded>g__Cinematic|261_0>d;
			}

			[CompilerGenerated]
			internal static IEnumerator <FinalBossAllEnemyTurnEnded>g__coroutine|261_24(EnemyUnit ayaDummy)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossAllEnemyTurnEnded>g__coroutine|261_24>d <<FinalBossAllEnemyTurnEnded>g__coroutine|261_24>d = new AyaPlayerUnitDef.AyaPlayerUnit.<<FinalBossAllEnemyTurnEnded>g__coroutine|261_24>d(0);
				<<FinalBossAllEnemyTurnEnded>g__coroutine|261_24>d.ayaDummy = ayaDummy;
				return <<FinalBossAllEnemyTurnEnded>g__coroutine|261_24>d;
			}

			[CompilerGenerated]
			internal static UniTask<UnitView> <LoadDummyAsync>g__LoadDummyAsync|272_0(EnemyUnit child, EnemyUnit parent)
			{
				AyaPlayerUnitDef.AyaPlayerUnit.<<LoadDummyAsync>g__LoadDummyAsync|272_0>d <<LoadDummyAsync>g__LoadDummyAsync|272_0>d;
				<<LoadDummyAsync>g__LoadDummyAsync|272_0>d.<>t__builder = AsyncUniTaskMethodBuilder<UnitView>.Create();
				for (;;)
				{
					IL_000C:
					int num = -1949846967;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(((num2 ^ (-(-1092408170) ^ ~-848377362)) * 1222022619 - 279815673) * -352872575)) % 4U)
						{
						case 0U:
							goto IL_000C;
						case 1U:
							<<LoadDummyAsync>g__LoadDummyAsync|272_0>d.child = child;
							num = (int)((num3 * 2119154073U) ^ 2307534919U);
							continue;
						case 2U:
							<<LoadDummyAsync>g__LoadDummyAsync|272_0>d.parent = parent;
							<<LoadDummyAsync>g__LoadDummyAsync|272_0>d.<>1__state = -1;
							<<LoadDummyAsync>g__LoadDummyAsync|272_0>d.<>t__builder.Start<AyaPlayerUnitDef.AyaPlayerUnit.<<LoadDummyAsync>g__LoadDummyAsync|272_0>d>(ref <<LoadDummyAsync>g__LoadDummyAsync|272_0>d);
							num = (int)((num3 * 1522291916U) ^ 2236601831U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				return <<LoadDummyAsync>g__LoadDummyAsync|272_0>d.<>t__builder.Task;
			}

			static Coroutine \u206F\u202C\u200F\u202E\u200F\u200B\u202B\u202D\u206F\u206F\u202A\u200C\u206F\u206D\u206A\u202C\u200C\u206F\u202E\u202B\u200B\u202B\u206B\u206A\u202C\u206E\u206F\u206D\u202E\u206D\u202A\u200B\u202E\u200F\u206A\u206A\u202B\u206E\u202D\u200E\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static GameRunController \u206E\u200B\u206B\u206E\u206A\u206A\u200C\u206D\u200E\u206B\u200B\u202D\u200F\u200E\u200D\u206A\u200C\u206F\u206B\u206A\u200B\u206C\u202B\u200B\u200F\u200C\u200D\u200E\u200D\u206D\u200B\u200E\u200D\u206A\u202C\u200B\u206A\u200C\u202E\u200C\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static GameEvent<StationEventArgs> \u206B\u202D\u202D\u206D\u206B\u200D\u202E\u200C\u206F\u206B\u200B\u206E\u202A\u206B\u200E\u202E\u200D\u202C\u200B\u202D\u206C\u202E\u206B\u200B\u206B\u206A\u202B\u202E\u206D\u206D\u202C\u202E\u206D\u202E\u200E\u202A\u200F\u206B\u206F\u200C\u202E(GameRunController A_0)
			{
				return A_0.StationEntered;
			}

			static GameEvent<StationEventArgs> \u200D\u202A\u200F\u206C\u202C\u206D\u200B\u202C\u202A\u206A\u206D\u202D\u200C\u202E\u202B\u202B\u206D\u202B\u200B\u202B\u206A\u202B\u200F\u200C\u202B\u202B\u202E\u200E\u200F\u206A\u206B\u200E\u206D\u206D\u200B\u202E\u202C\u202E\u200C\u202D\u202E(GameRunController A_0)
			{
				return A_0.StationFinished;
			}

			static PlayerUnit \u200C\u202A\u202E\u206D\u200B\u202D\u202D\u200B\u202A\u206D\u200E\u206C\u206B\u206A\u200B\u202A\u202B\u202E\u206F\u200E\u202A\u202C\u202A\u200C\u202B\u200B\u206F\u202C\u202B\u206E\u202B\u200D\u206D\u200F\u202E\u206A\u200E\u206F\u200F\u206B\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<DamageEventArgs> \u202D\u200D\u206D\u200D\u206C\u200E\u202E\u202C\u200F\u202A\u200B\u200C\u206C\u206D\u200B\u200C\u200F\u200C\u202C\u202E\u206E\u206A\u200F\u202B\u206F\u206D\u206D\u202D\u202E\u206B\u200B\u200E\u200E\u200C\u200B\u202E\u206B\u200F\u200E\u202E(Unit A_0)
			{
				return A_0.DamageReceived;
			}

			static GameEvent<HealEventArgs> \u200E\u206C\u206D\u206B\u200E\u200D\u200E\u206C\u202A\u202B\u206A\u206F\u202B\u202B\u206F\u200C\u206C\u202B\u202C\u202A\u206C\u202C\u200B\u206A\u206A\u200F\u202D\u206F\u202C\u200D\u202B\u206D\u206D\u206D\u206B\u206A\u202B\u206B\u202C\u202A\u202E(Unit A_0)
			{
				return A_0.HealingReceived;
			}

			static int \u202E\u200F\u206D\u206D\u202B\u200E\u206A\u206E\u202E\u206F\u200B\u202E\u206B\u200E\u206D\u202D\u200E\u200C\u206C\u200C\u206A\u202A\u202E\u206D\u206A\u202C\u202E\u202A\u200E\u202B\u206F\u206F\u202E\u200B\u200F\u206B\u200E\u206A\u202A\u200F\u202E(GameRunController A_0)
			{
				return A_0.RemoveBadCardForbidden;
			}

			static void \u200F\u202D\u202E\u206B\u206C\u206E\u206B\u202A\u206B\u200C\u206A\u200D\u200B\u200F\u202D\u200B\u202D\u200C\u200C\u200D\u206F\u202D\u202B\u200F\u206E\u206C\u200E\u200E\u202C\u202C\u202A\u206F\u206E\u202C\u202E\u200F\u202D\u202C\u200E\u200C\u202E(GameRunController A_0, int A_1)
			{
				A_0.RemoveBadCardForbidden = A_1;
			}

			static CardConfig \u202C\u206C\u202D\u206A\u206F\u206E\u200C\u200C\u206B\u206A\u202E\u206D\u202C\u200D\u202A\u206B\u202B\u200D\u202B\u202B\u200B\u206F\u200D\u200E\u206F\u202B\u200B\u200F\u200E\u206B\u206E\u206C\u206D\u200E\u202B\u202B\u202A\u202A\u206B\u202B\u202E(string A_0)
			{
				return CardConfig.FromId(A_0);
			}

			static Keyword \u200C\u202D\u206C\u200E\u200C\u206E\u200D\u200C\u202A\u200B\u202A\u206D\u206F\u200F\u206C\u206B\u206A\u202A\u200D\u206B\u202D\u206C\u206F\u200E\u200B\u200B\u202C\u202D\u202D\u200F\u206E\u200B\u202B\u202A\u206D\u206E\u200D\u202D\u202C\u206B\u202E(CardConfig A_0)
			{
				return A_0.Keywords;
			}

			static bool \u206A\u206E\u206E\u202A\u206C\u200D\u206A\u202C\u206F\u206E\u206C\u202B\u206B\u206F\u206D\u200B\u202A\u206D\u206E\u202C\u206A\u200E\u206F\u200F\u206D\u200B\u202C\u202C\u200D\u202E\u206B\u200F\u200E\u206E\u202A\u206C\u200C\u206B\u200E\u202E\u202E(Enum A_0, Enum A_1)
			{
				return A_0.HasFlag(A_1);
			}

			static BattleController \u206A\u202D\u206D\u206B\u206A\u200B\u206F\u200F\u206F\u206C\u206B\u202E\u206A\u200C\u200F\u202A\u200B\u206A\u206F\u206B\u202D\u206D\u200E\u206F\u200D\u206D\u206B\u206B\u200E\u206C\u206F\u200E\u202A\u200C\u202D\u206B\u206B\u202A\u200C\u206E\u202E(Unit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<GameEventArgs> \u200D\u202D\u202C\u200C\u202C\u206D\u200B\u202E\u200D\u200E\u200C\u200C\u202C\u206A\u202B\u206B\u202B\u200E\u202D\u200F\u206D\u206C\u200B\u200E\u206C\u206B\u206B\u202E\u206F\u206C\u202E\u200E\u206C\u206A\u200D\u206D\u206B\u206C\u200E\u202A\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static GameEvent<CardsEventArgs> \u200B\u206D\u202D\u200C\u202D\u206E\u206E\u206D\u206C\u202B\u200B\u206C\u206C\u206C\u200F\u202D\u200D\u202C\u202B\u200F\u206E\u200C\u206C\u206C\u206C\u202A\u200B\u200E\u206D\u200D\u202C\u206B\u206F\u206B\u200E\u206B\u202D\u206C\u200E\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDiscard;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u206D\u206E\u202B\u206E\u206B\u200E\u206E\u202C\u206F\u206B\u202E\u206E\u206C\u200F\u202A\u200B\u206B\u200B\u200B\u206D\u206A\u200F\u206C\u200C\u206B\u200B\u202C\u202B\u202C\u200D\u202C\u202A\u200B\u200C\u206A\u206C\u202E\u202D\u206D\u206E\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDrawZone;
			}

			static GameEvent<CardsEventArgs> \u200D\u200E\u206D\u206F\u206A\u200E\u202D\u200F\u206F\u200B\u200D\u206B\u206A\u206A\u206D\u200D\u200F\u202B\u206B\u202B\u202C\u202D\u200C\u200C\u202D\u206A\u200D\u202E\u206E\u206D\u202E\u206D\u202B\u206C\u206D\u200D\u206E\u206E\u200B\u202D\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToExile;
			}

			static GameEvent<CardsEventArgs> \u202D\u206E\u206F\u202D\u200C\u200D\u202D\u202C\u202C\u202B\u200F\u202C\u200F\u200B\u202A\u200D\u202E\u200D\u200F\u206A\u200B\u206C\u202C\u206C\u206D\u206D\u206F\u206D\u202C\u202C\u202D\u200E\u206E\u206B\u200B\u200D\u200D\u206E\u200C\u206E\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToHand;
			}

			static PlayerUnit \u202C\u200D\u200F\u202B\u202A\u206C\u200F\u202D\u206B\u206C\u200E\u202C\u200E\u200E\u202A\u202A\u202C\u200C\u206A\u206E\u200B\u200B\u206A\u200D\u200C\u200D\u202A\u206A\u206F\u206E\u200E\u202C\u206A\u202D\u202B\u200C\u202E\u200B\u206A\u202E\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<StatisticalDamageEventArgs> \u206D\u206A\u206C\u202B\u200B\u202C\u200E\u200E\u202E\u206A\u206D\u200F\u202A\u200F\u206B\u202B\u206C\u202B\u200E\u206C\u202D\u206A\u202B\u200E\u200C\u206C\u206A\u202C\u200B\u206E\u206A\u206D\u206D\u200B\u206F\u206A\u200F\u202C\u200B\u200C\u202E(Unit A_0)
			{
				return A_0.StatisticalTotalDamageDealt;
			}

			static GameEvent<DamageEventArgs> \u206C\u206B\u200D\u202B\u200E\u200E\u200C\u200C\u200C\u200C\u206F\u202E\u206F\u202B\u206A\u200C\u200F\u206D\u206D\u206E\u200B\u206B\u206F\u202C\u206A\u202C\u200C\u206A\u206C\u200F\u202A\u200C\u200B\u206D\u206C\u206C\u206C\u202E\u206B\u202A\u202E(Unit A_0)
			{
				return A_0.DamageTaking;
			}

			static GameEvent<GameEventArgs> \u206C\u206B\u202A\u200F\u202C\u206E\u206A\u202D\u206C\u200F\u202B\u206D\u200E\u200D\u202E\u200C\u202A\u206B\u206C\u202E\u200B\u200F\u202C\u200C\u202A\u202B\u200B\u202E\u202C\u206D\u202E\u206F\u200D\u206F\u206C\u202E\u206A\u202E\u200E\u202E\u202E(BattleController A_0)
			{
				return A_0.BattleEnding;
			}

			static GameEntity \u200F\u200B\u206C\u200E\u202B\u202E\u200C\u202E\u202E\u206A\u206A\u200E\u206C\u206B\u200D\u202E\u202A\u202E\u206E\u202D\u202E\u202E\u202D\u200B\u200F\u200C\u206C\u206A\u200E\u200E\u206B\u202C\u202B\u206C\u202A\u206C\u202D\u202C\u202E\u206F\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u200C\u200C\u202D\u206F\u206D\u202C\u200C\u206E\u206E\u200E\u206A\u202C\u202A\u202D\u200E\u206E\u206C\u200C\u206C\u200D\u202D\u200F\u200E\u206A\u206C\u202E\u206E\u200E\u200F\u206C\u206A\u206C\u202D\u206E\u202C\u200E\u206D\u206A\u200E\u206C\u202E(UnitView A_0, string A_1, float A_2, ChatWidget.CloudType A_3, float A_4)
			{
				A_0.Chat(A_1, A_2, A_3, A_4);
			}

			static DamageInfo \u206F\u206E\u206B\u200C\u202D\u200C\u200E\u206D\u202C\u206A\u200F\u200F\u206D\u202B\u202A\u200C\u200D\u202C\u206F\u206A\u202C\u206E\u206F\u202B\u206E\u206A\u206D\u206C\u200C\u200B\u202D\u200E\u200E\u206B\u200E\u202A\u206C\u202E\u206A\u206E\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static int \u206B\u200E\u202A\u200C\u200D\u206D\u206B\u206D\u206C\u200F\u200C\u206D\u202E\u200D\u202B\u202B\u206D\u200B\u202E\u206D\u200D\u200D\u200B\u200F\u206D\u200D\u202C\u200B\u202A\u206F\u202E\u206B\u206D\u206C\u206B\u206C\u202D\u200B\u202D\u202A\u202E(Unit A_0)
			{
				return A_0.Block;
			}

			static int \u206A\u202A\u202B\u202A\u202D\u200B\u202B\u202E\u206E\u206B\u200F\u202C\u200B\u202C\u200D\u206F\u206B\u206E\u206A\u206B\u202C\u202A\u206C\u202B\u202A\u200F\u200F\u206F\u202B\u200B\u200F\u200E\u200F\u202D\u202C\u206F\u206F\u202C\u200E\u202A\u202E(Unit A_0)
			{
				return A_0.Shield;
			}

			static void \u200C\u206F\u200F\u206A\u200B\u202D\u206C\u202B\u202D\u206A\u206A\u202C\u200D\u206B\u202E\u202A\u206C\u206D\u202B\u202D\u200E\u202E\u202E\u206D\u200F\u206B\u200F\u206F\u202E\u202C\u206E\u200F\u206D\u202D\u202E\u206F\u206B\u200E\u206D\u200C\u202E(DamageEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u206E\u200D\u206C\u200B\u200D\u202C\u206B\u200B\u202A\u202D\u206C\u206E\u206C\u206E\u200D\u200B\u200D\u202E\u202E\u202C\u202D\u200C\u202C\u200B\u200B\u200E\u200E\u200E\u202C\u206A\u206C\u206C\u200B\u206D\u200F\u202A\u202E\u200C\u202A\u202E\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static void \u206D\u202B\u202C\u200E\u202D\u206B\u206F\u202E\u200D\u202D\u200E\u200D\u206C\u202B\u206F\u200D\u206E\u206D\u202B\u202C\u206D\u206F\u206E\u200F\u206B\u200D\u206F\u206D\u202B\u200F\u200F\u202E\u206A\u206F\u202E\u200D\u200E\u202A\u206A\u206E\u202E(GameObject A_0, bool A_1)
			{
				A_0.SetActive(A_1);
			}

			static GameObject \u202E\u200E\u202B\u206C\u206F\u206E\u206F\u202A\u202A\u202A\u202B\u200B\u200E\u200B\u200F\u200E\u206B\u202B\u206B\u202A\u206A\u200B\u206F\u206A\u200D\u206A\u206E\u206E\u206E\u200B\u206F\u206A\u202E\u202D\u206D\u202D\u206D\u200C\u202A\u206A\u202E(string A_0, Assembly A_1)
			{
				return StageTemplate.TryGetEnvObject(A_0, A_1);
			}

			static Station \u206A\u200E\u202A\u206B\u202E\u206E\u202C\u206C\u206F\u202A\u202B\u206C\u202E\u200F\u202C\u200E\u206E\u202C\u200D\u206D\u202C\u200D\u202A\u200E\u202E\u206E\u206F\u200B\u206B\u200E\u202C\u206C\u202D\u206C\u200C\u202B\u206A\u202B\u202D\u206C\u202E(GameRunController A_0)
			{
				return A_0.CurrentStation;
			}

			static int \u200D\u206C\u200E\u200E\u202D\u200C\u206E\u206D\u200D\u200C\u206D\u206D\u206D\u206D\u200E\u206A\u206E\u206B\u202C\u200C\u206E\u206D\u206D\u202E\u200C\u200B\u200C\u202C\u206B\u200F\u202A\u200F\u206D\u202D\u200D\u200B\u202D\u206E\u202E\u200D\u202E(Unit A_0)
			{
				return A_0.Hp;
			}

			static int \u206D\u206D\u206F\u206D\u200D\u200F\u200F\u202D\u202A\u202D\u206D\u200E\u202C\u200D\u202E\u202A\u200F\u202C\u200F\u200F\u202E\u200E\u202E\u200D\u206A\u200C\u206A\u200E\u202A\u202B\u200D\u200B\u202E\u200B\u202E\u202B\u200B\u206A\u202D\u202E\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static void \u206E\u202A\u206C\u206E\u206D\u202C\u206B\u200C\u200C\u202C\u200F\u206C\u202A\u200F\u200E\u202A\u200B\u200D\u206D\u206D\u206B\u200E\u200F\u200D\u200D\u206F\u202E\u202E\u200C\u202D\u200F\u200B\u206C\u206F\u202B\u202E\u206A\u206F\u202B\u206F\u202E(Image A_0, Sprite A_1)
			{
				A_0.sprite = A_1;
			}

			static Transform \u200E\u200D\u202A\u206C\u206D\u200F\u200C\u202E\u200F\u202A\u202A\u200E\u200C\u200C\u206D\u206B\u200F\u202C\u202E\u200E\u200B\u202B\u200E\u202B\u200B\u206D\u200F\u200C\u200B\u202C\u200E\u200B\u200F\u206F\u200B\u202D\u206C\u202D\u206A\u202E\u202E(Component A_0)
			{
				return A_0.transform;
			}

			static Vector3 \u200C\u206B\u202B\u202D\u202E\u200F\u206F\u202C\u200C\u200D\u200B\u206C\u202E\u200C\u202A\u200C\u206B\u202E\u200E\u202A\u200E\u202C\u206A\u200E\u206E\u206A\u200D\u202B\u202A\u200B\u200E\u200F\u200C\u202A\u200D\u206A\u200D\u202A\u206E\u200C\u202E(Transform A_0)
			{
				return A_0.localPosition;
			}

			static Stage \u200C\u200F\u206C\u200F\u200E\u206A\u202A\u206E\u206F\u200B\u206B\u200E\u202B\u206A\u206F\u206E\u200C\u202A\u206A\u200F\u200C\u206A\u206F\u202A\u206C\u202B\u202C\u202D\u202B\u202C\u200B\u200D\u200B\u200C\u202A\u206D\u200D\u206E\u202C\u202E(GameRunController A_0)
			{
				return A_0.CurrentStage;
			}

			static int \u200D\u200D\u200B\u202A\u202C\u206B\u202C\u202C\u206C\u202D\u200C\u202A\u202C\u202D\u202C\u200C\u200C\u202C\u206D\u202B\u206C\u206D\u202B\u206E\u200B\u202E\u202A\u206F\u202A\u206B\u206C\u202E\u206A\u202B\u206D\u206C\u202E\u202D\u206A\u206A\u202E(Stage A_0)
			{
				return A_0.Level;
			}

			static Transform \u206D\u206C\u206F\u202E\u200E\u200D\u206C\u202A\u206E\u202A\u200B\u206D\u206B\u202E\u200F\u202D\u200E\u206C\u200D\u202B\u206F\u202E\u200B\u206F\u202E\u206A\u206A\u200E\u206A\u202A\u200E\u206F\u202D\u206E\u200C\u202A\u202C\u200C\u206D\u206A\u202E(Component A_0)
			{
				return A_0.transform;
			}

			static Station \u200C\u202D\u202B\u202B\u200F\u200C\u206D\u200F\u200E\u202D\u202E\u200C\u206F\u202D\u200F\u200F\u200E\u206F\u200B\u200B\u206F\u202B\u206A\u200B\u202E\u202B\u200C\u202B\u206D\u202A\u202B\u200F\u200E\u206A\u202C\u200F\u200C\u206F\u206E\u206B\u202E(StationEventArgs A_0)
			{
				return A_0.Station;
			}

			static bool \u206B\u206E\u202E\u206D\u202E\u206E\u202B\u202B\u206A\u200E\u206B\u202B\u202D\u206A\u206E\u200E\u206E\u200F\u206E\u206B\u202C\u206D\u202B\u202A\u206A\u202B\u200B\u200B\u202E\u206A\u200C\u206F\u200C\u200E\u200D\u206A\u206A\u202B\u202D\u200D\u202E(Station A_0)
			{
				return A_0.IsNormalEnd;
			}

			static GameDifficulty \u206F\u206C\u202C\u202C\u202B\u206A\u200E\u206C\u200F\u200B\u202C\u200F\u202B\u202D\u202A\u200E\u202B\u202C\u206E\u202B\u206E\u206A\u202D\u202C\u202D\u206F\u200D\u206B\u202D\u202E\u202A\u206D\u202E\u200B\u206F\u200F\u200F\u200F\u206C\u202D\u202E(GameRunController A_0)
			{
				return A_0.Difficulty;
			}

			static bool \u200F\u206A\u206F\u206B\u202C\u206E\u206F\u202E\u200D\u200B\u206C\u202E\u202A\u206B\u206F\u206E\u206F\u202E\u206D\u202E\u202C\u200F\u206C\u206B\u206C\u206C\u202D\u206C\u206F\u206B\u206F\u202C\u206E\u200C\u202D\u206F\u206F\u206B\u206E\u200F\u202E(string A_0, string A_1)
			{
				return A_0.Contains(A_1);
			}

			static bool \u206D\u200B\u200F\u202C\u202C\u202B\u202D\u206C\u206A\u206C\u206D\u200D\u200D\u200E\u202C\u200D\u202B\u202B\u200C\u200E\u202D\u206E\u200E\u206A\u202C\u202C\u206F\u202E\u206A\u200E\u202A\u206C\u202C\u202D\u206B\u202A\u200D\u200D\u202C\u202A\u202E(string A_0)
			{
				return A_0.IsNullOrEmpty();
			}

			static string \u200E\u200E\u206F\u200D\u206C\u206B\u206B\u206A\u206E\u206B\u200D\u206D\u200B\u200C\u206A\u206D\u206C\u202D\u202D\u202B\u206A\u200C\u202A\u206D\u200B\u202E\u206B\u206F\u206D\u202C\u206F\u202D\u206E\u202E\u206C\u200E\u202C\u206F\u206B\u202B\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static PuzzleFlag \u206A\u206C\u202D\u206C\u200B\u206C\u200B\u200C\u202C\u206D\u202A\u206E\u200E\u206A\u202E\u206A\u206F\u202B\u202D\u200B\u200C\u202E\u200C\u202C\u200E\u200D\u206B\u200F\u206E\u202A\u202D\u206A\u202E\u206A\u202E\u202D\u206C\u206F\u206E\u200E\u202E(GameRunController A_0)
			{
				return A_0.Puzzles;
			}

			static int \u206C\u200C\u206B\u206B\u206A\u206F\u202A\u202E\u200D\u200D\u202C\u206C\u200C\u200F\u206B\u206C\u200C\u202B\u200E\u200F\u200E\u202E\u202C\u202B\u206F\u206E\u202A\u206E\u200B\u202E\u200B\u200D\u206F\u200C\u206B\u202B\u202B\u200C\u200E\u206F\u202E(PuzzleFlag A_0)
			{
				return PuzzleFlags.GetPuzzleLevel(A_0);
			}

			static EnemyGroup \u202C\u206C\u202A\u202D\u200C\u206F\u202C\u206D\u202D\u202A\u200F\u206E\u206B\u200F\u200C\u202E\u202B\u206A\u202C\u200C\u206F\u206F\u200E\u206D\u202A\u202D\u206D\u202D\u202C\u202B\u202D\u200D\u206C\u206D\u200C\u200D\u206C\u202A\u206D\u200F\u202E(BattleStation A_0)
			{
				return A_0.EnemyGroup;
			}

			static string \u200E\u200C\u200B\u206B\u202D\u206A\u206E\u200C\u206B\u202A\u206B\u200C\u206A\u200E\u200B\u206A\u206F\u206A\u202A\u200D\u200E\u202A\u202D\u202E\u206C\u200C\u202C\u200F\u206A\u206C\u206D\u206B\u206F\u206C\u202E\u206B\u202A\u200D\u206D\u206C\u202E(EnemyGroup A_0)
			{
				return A_0.Id;
			}

			static bool \u200C\u200F\u200B\u200B\u202B\u206D\u206C\u200F\u202B\u206C\u206D\u202B\u200B\u200B\u206C\u206C\u206F\u200C\u200C\u206E\u206A\u200D\u206D\u202A\u206B\u202B\u206D\u202A\u200C\u206C\u206B\u200D\u200E\u202B\u200D\u202D\u202B\u206B\u206D\u202C\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u200F\u200B\u200D\u200F\u206B\u206B\u200C\u206A\u200E\u206F\u200F\u202A\u200C\u202C\u206A\u200C\u206D\u202A\u206C\u206F\u206E\u206C\u206F\u202E\u202A\u202D\u206E\u206C\u202E\u206F\u200D\u206B\u206B\u202C\u206C\u206C\u200E\u206D\u206E\u200F\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static bool \u200D\u206B\u202A\u206C\u202B\u202D\u202E\u202C\u206A\u202B\u206A\u200B\u200E\u202E\u206C\u206F\u206B\u206D\u206C\u200F\u200E\u206D\u202B\u202D\u206E\u202A\u206E\u202C\u206F\u206C\u202A\u202C\u202A\u200F\u206F\u206C\u200F\u206F\u202D\u202D\u202E(PlayerUnit A_0, string A_1)
			{
				return A_0.HasExhibit(A_1);
			}

			private int BriberyCount;

			public int? Story;

			public static bool BossStationFinished = false;

			public static bool LastInputTriggered = false;

			public static int FinalBossSequence;

			public static EnemyUnit FinalBoss;

			public static bool FinalBossTransition;

			private static GameObject background;

			private List<string> fastAttacks = new List<string>();

			private bool fastAttack;

			private bool LastEnemyCommented;

			private bool CirnoLeaved;

			private bool LastEnemy;

			[HarmonyPatch(typeof(SihunYuSe), "OnOwnerTurnEnded")]
			private class SihunYuSe_OnOwnerTurnEnded_Patch
			{
				private static bool Prefix(SihunYuSe __instance)
				{
					return AyaPlayerUnitDef.AyaPlayerUnit.FinalBossSequence < 3;
				}
			}

			[HarmonyPatch(typeof(UiManager), "LeaveGameRun")]
			private class UiManager_LeaveGameRun_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Prefix(UiManager __instance)
				{
					GameObject background = AyaPlayerUnitDef.AyaPlayerUnit.background;
					if (background == null)
					{
						goto IL_014A;
					}
					AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u200F\u202E\u206E\u206E\u206B\u206D\u206E\u200E\u202B\u206F\u202B\u200B\u202D\u202E\u200C\u200C\u200D\u206C\u206C\u206A\u206D\u202C\u202A\u206E\u200C\u206E\u206C\u200C\u200B\u202A\u206C\u200C\u200D\u206A\u202E\u200B\u200B\u202B\u202D\u202E(background, false);
					goto IL_0014;
					int num2;
					for (;;)
					{
						IL_0019:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(((~num ^ (-1547656117 + 740864815 + (-211396796 ^ 1867214522))) + -261096291) * -946098819)) % 8U)
						{
						case 0U:
						{
							CardConfig cardConfig = AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(643499380));
							cardConfig.Keywords = AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u206C\u200D\u202E\u200B\u200F\u202C\u202D\u200C\u200D\u202D\u206F\u200F\u202A\u202D\u206C\u206A\u200B\u202A\u200E\u200D\u200B\u206B\u206A\u206C\u202E\u206D\u206F\u206E\u206A\u206D\u206F\u202C\u202B\u202E\u206D\u202A\u202B\u200B\u202D\u200C\u202E(cardConfig) - 8388608UL;
							num2 = (int)((num3 * 183593763U) ^ 1762146078U);
							continue;
						}
						case 1U:
							goto IL_014A;
						case 3U:
							goto IL_0014;
						case 4U:
						{
							CardConfig cardConfig2 = AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-100361459));
							cardConfig2.Keywords = AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u206C\u200D\u202E\u200B\u200F\u202C\u202D\u200C\u200D\u202D\u206F\u200F\u202A\u202D\u206C\u206A\u200B\u202A\u200E\u200D\u200B\u206B\u206A\u206C\u202E\u206D\u206F\u206E\u206A\u206D\u206F\u202C\u202B\u202E\u206D\u202A\u202B\u200B\u202D\u200C\u202E(cardConfig2) - 8388608UL;
							num2 = (int)((num3 * 4122997141U) ^ 3953588349U);
							continue;
						}
						case 5U:
							AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447)).TargetType = new TargetType?(TargetType.RandomEnemy);
							num2 = (int)(((!AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200F\u200B\u202C\u200E\u200C\u206A\u206E\u200C\u200B\u206D\u202E\u202B\u200E\u206E\u206A\u202D\u200F\u200E\u206D\u206F\u206C\u200F\u200B\u202B\u200C\u202A\u206C\u202B\u202C\u200E\u202E\u206E\u200F\u206E\u206A\u200C\u206D\u200E\u202D\u200D\u202E(AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u206C\u200D\u202E\u200B\u200F\u202C\u202D\u200C\u200D\u202D\u206F\u200F\u202A\u202D\u206C\u206A\u200B\u202A\u200E\u200D\u200B\u206B\u206A\u206C\u202E\u206D\u206F\u206E\u206A\u206D\u206F\u202C\u202B\u202E\u206D\u202A\u202B\u200B\u202D\u200C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139))), Keyword.Replenish)) ? 533196080U : 761899946U) ^ (num3 * 2196367446U));
							continue;
						case 6U:
							num2 = (AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200F\u200B\u202C\u200E\u200C\u206A\u206E\u200C\u200B\u206D\u202E\u202B\u200E\u206E\u206A\u202D\u200F\u200E\u206D\u206F\u206C\u200F\u200B\u202B\u200C\u202A\u206C\u202B\u202C\u200E\u202E\u206E\u200F\u206E\u206A\u200C\u206D\u200E\u202D\u200D\u202E(AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u206C\u200D\u202E\u200B\u200F\u202C\u202D\u200C\u200D\u202D\u206F\u200F\u202A\u202D\u206C\u206A\u200B\u202A\u200E\u200D\u200B\u206B\u206A\u206C\u202E\u206D\u206F\u206E\u206A\u206D\u206F\u202C\u202B\u202E\u206D\u202A\u202B\u200B\u202D\u200C\u202E(AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-100361459))), Keyword.Replenish) ? (-1243141872) : 1828313929);
							continue;
						case 7U:
							AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(668123939)).Value1 = new int?(1);
							num2 = -1837344974;
							continue;
						}
						break;
					}
					return;
					IL_0014:
					num2 = 712150559;
					goto IL_0019;
					IL_014A:
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.types = new Type[0];
					AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1061091270)).Damage = new int?(1);
					AyaPlayerUnitDef.AyaPlayerUnit.UiManager_LeaveGameRun_Patch.\u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447)).Value1 = null;
					num2 = 593924979;
					goto IL_0019;
				}

				static void \u200D\u200F\u202E\u206E\u206E\u206B\u206D\u206E\u200E\u202B\u206F\u202B\u200B\u202D\u202E\u200C\u200C\u200D\u206C\u206C\u206A\u206D\u202C\u202A\u206E\u200C\u206E\u206C\u200C\u200B\u202A\u206C\u200C\u200D\u206A\u202E\u200B\u200B\u202B\u202D\u202E(GameObject A_0, bool A_1)
				{
					A_0.SetActive(A_1);
				}

				static CardConfig \u200D\u202C\u206F\u202C\u202C\u206A\u206C\u200D\u202D\u202B\u202D\u202E\u206E\u206F\u202B\u200E\u206D\u202A\u206C\u206F\u200D\u206E\u206B\u202D\u206D\u200D\u206D\u206E\u200C\u206A\u206C\u202C\u200C\u202E\u206B\u202A\u206A\u202E\u202D\u206D\u202E(string A_0)
				{
					return CardConfig.FromId(A_0);
				}

				static Keyword \u206C\u200D\u202E\u200B\u200F\u202C\u202D\u200C\u200D\u202D\u206F\u200F\u202A\u202D\u206C\u206A\u200B\u202A\u200E\u200D\u200B\u206B\u206A\u206C\u202E\u206D\u206F\u206E\u206A\u206D\u206F\u202C\u202B\u202E\u206D\u202A\u202B\u200B\u202D\u200C\u202E(CardConfig A_0)
				{
					return A_0.Keywords;
				}

				static bool \u200F\u200B\u202C\u200E\u200C\u206A\u206E\u200C\u200B\u206D\u202E\u202B\u200E\u206E\u206A\u202D\u200F\u200E\u206D\u206F\u206C\u200F\u200B\u202B\u200C\u202A\u206C\u202B\u202C\u200E\u202E\u206E\u200F\u206E\u206A\u200C\u206D\u200E\u202D\u200D\u202E(Enum A_0, Enum A_1)
				{
					return A_0.HasFlag(A_1);
				}
			}
		}
	}
}
