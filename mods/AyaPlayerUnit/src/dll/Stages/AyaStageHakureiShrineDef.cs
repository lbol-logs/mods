using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using BepInEx.Configuration;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Adventures;
using LBoL.Core.Battle;
using LBoL.Core.Randoms;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoL.Presentation;
using LBoL.Presentation.UI;
using LBoL.Presentation.UI.Panels;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using UnityEngine;

namespace AyaShameimaru.Stages
{
	public sealed class AyaStageHakureiShrineDef : StageTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1633318712);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StageConfig MakeConfig()
		{
			StageConfig stageConfig = this.\u200C\u206E\u206F\u206B\u202B\u206F\u202E\u206C\u202D\u202D\u206F\u206E\u206C\u202B\u206C\u200F\u206D\u200F\u206E\u206A\u206B\u206D\u202A\u206D\u202A\u206D\u202B\u200F\u206A\u202D\u202B\u200D\u206A\u200C\u202C\u200D\u200F\u206F\u200D\u200F\u202E();
			stageConfig.Obj0 = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1968744804);
			stageConfig.Obj1 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1178759506);
			stageConfig.Level1 = 1;
			stageConfig.Obj2 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(319060233);
			stageConfig.Level2 = 6;
			stageConfig.Obj3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1178759506);
			stageConfig.Level3 = 11;
			stageConfig.Obj4 = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(319060233);
			stageConfig.Level4 = 16;
			return stageConfig;
		}

		StageConfig \u200C\u206E\u206F\u206B\u202B\u206F\u202E\u206C\u202D\u202D\u206F\u206E\u206C\u202B\u206C\u200F\u206D\u200F\u206E\u206A\u206B\u206D\u202A\u206D\u202A\u206D\u202B\u200F\u206A\u202D\u202B\u200D\u206A\u200C\u202C\u200D\u200F\u206F\u200D\u200F\u202E()
		{
			return base.DefaultConfig();
		}

		[EntityLogic(typeof(AyaStageHakureiShrineDef))]
		public sealed class AyaStageHakureiShrine : AyaStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaStageHakureiShrine()
			{
				this.IsNormalStage = true;
				base.Level = 5;
				base.CardUpgradedChance = 1f;
				base.EternalStageMusic = true;
				base.DontAutoOpenMapInEntry = true;
				AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u202C\u200E\u202B\u202B\u200E\u206F\u202E\u200B\u206F\u206E\u200C\u202E\u200E\u200B\u200F\u206F\u200F\u206D\u206F\u206C\u202D\u206A\u202D\u202A\u202A\u200F\u206D\u202B\u202A\u202D\u200D\u202B\u202E\u202A\u202B\u200D\u200E\u200B\u206E\u206A\u202E(this, new RepeatableRandomPool<string> { 
				{
					<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1306769277),
					1f
				} });
				AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u206D\u202B\u202D\u200F\u200E\u206F\u202D\u206D\u200B\u202C\u202D\u202A\u200B\u206E\u206A\u202B\u202B\u200C\u206A\u200E\u202D\u202B\u206D\u200E\u206B\u200E\u200E\u206F\u206B\u200B\u200B\u200C\u202C\u202D\u200D\u200B\u206E\u200D\u202E\u202E(this, new UniqueRandomPool<Type>(true) { 
				{
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200B\u200C\u206D\u202B\u202D\u202A\u206B\u200B\u200B\u206A\u206E\u200E\u202A\u206C\u206F\u202C\u202E\u200D\u202C\u206B\u202B\u206B\u206B\u206D\u206A\u200D\u206E\u206D\u206C\u200B\u202B\u200B\u206B\u206E\u202D\u200F\u206D\u206E\u202A\u202E\u202E(typeof(FakeAdventure).TypeHandle),
					1f
				} });
				base.SentinelExhibitType = AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200B\u200C\u206D\u202B\u202D\u202A\u206B\u200B\u200B\u206A\u206E\u200E\u202A\u206C\u206F\u202C\u202E\u200D\u202C\u206B\u202B\u206B\u206B\u206D\u206A\u200D\u206E\u206D\u206C\u200B\u202B\u200B\u206B\u206E\u202D\u200F\u206D\u206E\u202A\u202E\u202E(typeof(KongZhanpinhe).TypeHandle);
			}

			public override EnemyGroupEntry GetBoss()
			{
				return this.\u202D\u206D\u206E\u202B\u202A\u206F\u206A\u202E\u206F\u206B\u202E\u200B\u202E\u202D\u202D\u200C\u206D\u206B\u202B\u202B\u200D\u202D\u206C\u202D\u200D\u206A\u206D\u200B\u200D\u200B\u206A\u202C\u200C\u202D\u200C\u202D\u200D\u206F\u206C\u206D\u202E();
			}

			public override void SetBoss(string enemyGroupName)
			{
				this.\u206B\u206F\u206C\u202C\u202C\u202D\u206B\u202A\u202D\u206E\u206C\u206D\u200C\u202A\u206D\u200F\u202E\u206B\u200C\u206F\u206E\u206B\u202D\u202C\u202A\u200B\u202E\u200E\u202A\u202A\u202E\u200F\u202A\u200C\u206B\u200C\u200C\u200D\u200D\u206F\u202E(enemyGroupName);
			}

			public override void InitBoss(RandomGen rng)
			{
				base.Boss = AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200D\u200F\u206F\u206D\u200C\u200B\u206C\u200F\u206B\u206E\u202D\u206D\u206C\u200F\u200D\u206B\u206D\u202E\u206C\u202A\u202A\u206C\u200F\u206E\u206E\u206F\u206E\u206E\u206D\u200D\u200C\u206B\u200E\u202A\u200D\u200D\u202B\u206A\u206E\u206A\u202E(AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u206E\u200E\u206D\u206B\u202E\u202B\u206E\u206E\u202A\u202D\u206A\u200D\u202D\u200F\u206B\u206D\u206A\u200F\u206B\u200E\u206F\u206B\u206A\u202A\u202A\u206D\u206D\u206B\u200B\u206A\u200D\u206C\u202D\u202C\u202E\u202E\u206B\u200E\u200C\u202E\u202E(this).SampleOrDefault(rng));
			}

			public override GameMap CreateMap()
			{
				AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u206D\u200F\u206B\u202D\u200E\u202A\u206D\u202B\u200D\u202B\u200D\u206D\u202D\u206F\u202C\u200C\u200B\u200F\u206C\u202A\u206C\u200B\u200C\u200F\u206B\u200D\u206C\u200F\u202E\u206B\u206D\u200F\u202A\u202E\u206A\u200B\u202D\u200D\u202C\u202B\u202E(this, AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u206D\u202B\u206C\u206F\u206B\u202D\u200F\u200D\u200C\u200C\u206F\u202C\u200E\u202D\u200C\u206C\u202D\u206E\u206F\u200C\u200B\u206F\u202A\u202D\u200B\u202B\u202A\u200B\u206E\u200F\u206D\u206A\u200B\u200C\u206D\u200E\u202E\u206B\u206E\u202E\u202E(this)._stageIndex);
				string text = AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200D\u202C\u200B\u202D\u206A\u200C\u206A\u200F\u206A\u202E\u202D\u206A\u202B\u202E\u200C\u206C\u206C\u206F\u202D\u202C\u202A\u202D\u206A\u206A\u206E\u200F\u202C\u202D\u206C\u200B\u206E\u206A\u202B\u202B\u206A\u200B\u206F\u206E\u202A\u202C\u202E(AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u206A\u200E\u202D\u202B\u206E\u200F\u206E\u206F\u206F\u202C\u200E\u206A\u206B\u202E\u206F\u200F\u202B\u200D\u200C\u206B\u202A\u202C\u206B\u206B\u202D\u202D\u200C\u200E\u200C\u200E\u200D\u202C\u206D\u206B\u202C\u200E\u200F\u206C\u206B\u202E(this));
				StationType[] array = new StationType[4];
				AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200B\u206C\u200D\u202A\u202C\u200F\u200F\u206E\u206E\u206D\u202B\u206C\u200D\u202A\u200F\u206C\u206E\u206F\u202C\u202E\u202E\u206D\u200F\u202B\u202D\u202E\u206E\u200C\u206E\u202C\u200B\u206F\u206B\u206C\u200B\u202A\u202E\u202B\u200C\u206C\u202E(array, fieldof(<PrivateImplementationDetails>.6DA65BE79CDF251E59DD8D7AE29F923E7754B189C38364E767E5285C260A1042).FieldHandle);
				return AyaStageHakureiShrineDef.AyaStageHakureiShrine.\u200E\u200E\u200F\u200E\u206C\u202E\u206D\u202E\u206D\u202B\u200E\u202E\u202B\u200E\u200D\u202D\u206F\u200F\u206D\u202B\u200E\u206F\u200B\u206A\u200F\u206E\u206A\u206A\u200C\u206E\u202D\u206F\u202C\u200B\u202C\u202D\u206B\u202B\u200C\u206B\u202E(text, array);
			}

			static void \u202C\u200E\u202B\u202B\u200E\u206F\u202E\u200B\u206F\u206E\u200C\u202E\u200E\u200B\u200F\u206F\u200F\u206D\u206F\u206C\u202D\u206A\u202D\u202A\u202A\u200F\u206D\u202B\u202A\u202D\u200D\u202B\u202E\u202A\u202B\u200D\u200E\u200B\u206E\u206A\u202E(Stage A_0, RepeatableRandomPool<string> A_1)
			{
				A_0.BossPool = A_1;
			}

			static Type \u200B\u200C\u206D\u202B\u202D\u202A\u206B\u200B\u200B\u206A\u206E\u200E\u202A\u206C\u206F\u202C\u202E\u200D\u202C\u206B\u202B\u206B\u206B\u206D\u206A\u200D\u206E\u206D\u206C\u200B\u202B\u200B\u206B\u206E\u202D\u200F\u206D\u206E\u202A\u202E\u202E(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			static void \u206D\u202B\u202D\u200F\u200E\u206F\u202D\u206D\u200B\u202C\u202D\u202A\u200B\u206E\u206A\u202B\u202B\u200C\u206A\u200E\u202D\u202B\u206D\u200E\u206B\u200E\u200E\u206F\u206B\u200B\u200B\u200C\u202C\u202D\u200D\u200B\u206E\u200D\u202E\u202E(Stage A_0, UniqueRandomPool<Type> A_1)
			{
				A_0.AdventurePool = A_1;
			}

			EnemyGroupEntry \u202D\u206D\u206E\u202B\u202A\u206F\u206A\u202E\u206F\u206B\u202E\u200B\u202E\u202D\u202D\u200C\u206D\u206B\u202B\u202B\u200D\u202D\u206C\u202D\u200D\u206A\u206D\u200B\u200D\u200B\u206A\u202C\u200C\u202D\u200C\u202D\u200D\u206F\u206C\u206D\u202E()
			{
				return base.GetBoss();
			}

			void \u206B\u206F\u206C\u202C\u202C\u202D\u206B\u202A\u202D\u206E\u206C\u206D\u200C\u202A\u206D\u200F\u202E\u206B\u200C\u206F\u206E\u206B\u202D\u202C\u202A\u200B\u202E\u200E\u202A\u202A\u202E\u200F\u202A\u200C\u206B\u200C\u200C\u200D\u200D\u206F\u202E(string A_1)
			{
				base.SetBoss(A_1);
			}

			static RepeatableRandomPool<string> \u206E\u200E\u206D\u206B\u202E\u202B\u206E\u206E\u202A\u202D\u206A\u200D\u202D\u200F\u206B\u206D\u206A\u200F\u206B\u200E\u206F\u206B\u206A\u202A\u202A\u206D\u206D\u206B\u200B\u206A\u200D\u206C\u202D\u202C\u202E\u202E\u206B\u200E\u200C\u202E\u202E(Stage A_0)
			{
				return A_0.BossPool;
			}

			static EnemyGroupEntry \u200D\u200F\u206F\u206D\u200C\u200B\u206C\u200F\u206B\u206E\u202D\u206D\u206C\u200F\u200D\u206B\u206D\u202E\u206C\u202A\u202A\u206C\u200F\u206E\u206E\u206F\u206E\u206E\u206D\u200D\u200C\u206B\u200E\u202A\u200D\u200D\u202B\u206A\u206E\u206A\u202E(string A_0)
			{
				return Library.GetEnemyGroupEntry(A_0);
			}

			static GameRunController \u206D\u202B\u206C\u206F\u206B\u202D\u200F\u200D\u200C\u200C\u206F\u202C\u200E\u202D\u200C\u206C\u202D\u206E\u206F\u200C\u200B\u206F\u202A\u202D\u200B\u202B\u202A\u200B\u206E\u200F\u206D\u206A\u200B\u200C\u206D\u200E\u202E\u206B\u206E\u202E\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static void \u206D\u200F\u206B\u202D\u200E\u202A\u206D\u202B\u200D\u202B\u200D\u206D\u202D\u206F\u202C\u200C\u200B\u200F\u206C\u202A\u206C\u200B\u200C\u200F\u206B\u200D\u206C\u200F\u202E\u206B\u206D\u200F\u202A\u202E\u206A\u200B\u202D\u200D\u202C\u202B\u202E(Stage A_0, int A_1)
			{
				A_0.Index = A_1;
			}

			static EnemyGroupEntry \u206A\u200E\u202D\u202B\u206E\u200F\u206E\u206F\u206F\u202C\u200E\u206A\u206B\u202E\u206F\u200F\u202B\u200D\u200C\u206B\u202A\u202C\u206B\u206B\u202D\u202D\u200C\u200E\u200C\u200E\u200D\u202C\u206D\u206B\u202C\u200E\u200F\u206C\u206B\u202E(Stage A_0)
			{
				return A_0.Boss;
			}

			static string \u200D\u202C\u200B\u202D\u206A\u200C\u206A\u200F\u206A\u202E\u202D\u206A\u202B\u202E\u200C\u206C\u206C\u206F\u202D\u202C\u202A\u202D\u206A\u206A\u206E\u200F\u202C\u202D\u206C\u200B\u206E\u206A\u202B\u202B\u206A\u200B\u206F\u206E\u202A\u202C\u202E(EnemyGroupEntry A_0)
			{
				return A_0.Id;
			}

			static void \u200B\u206C\u200D\u202A\u202C\u200F\u200F\u206E\u206E\u206D\u202B\u206C\u200D\u202A\u200F\u206C\u206E\u206F\u202C\u202E\u202E\u206D\u200F\u202B\u202D\u202E\u206E\u200C\u206E\u202C\u200B\u206F\u206B\u206C\u200B\u202A\u202E\u202B\u200C\u206C\u202E(Array A_0, RuntimeFieldHandle A_1)
			{
				RuntimeHelpers.InitializeArray(A_0, A_1);
			}

			static GameMap \u200E\u200E\u200F\u200E\u206C\u202E\u206D\u202E\u206D\u202B\u200E\u202E\u202B\u200E\u200D\u202D\u206F\u200F\u206D\u202B\u200E\u206F\u200B\u206A\u200F\u206E\u206A\u206A\u200C\u206E\u202D\u206F\u202C\u200B\u202C\u202D\u206B\u202B\u200C\u206B\u202E(string A_0, StationType[] A_1)
			{
				return GameMap.CreateSingleRoute(A_0, A_1);
			}

			[HarmonyPatch(typeof(AudioManager), "EnterStage")]
			private class AudioManager_EnterStage_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static bool Prefix(AudioManager __instance, ref int level, ref bool intoLayer0)
				{
					GameRunController gameRunController = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance);
					if (!(((gameRunController != null) ? AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u202A\u200C\u202D\u202E\u202D\u206F\u202A\u200E\u206A\u202E\u200F\u200B\u202C\u202D\u200B\u200D\u200F\u200B\u200D\u202D\u206B\u202C\u200B\u200C\u206B\u200F\u202D\u200C\u206A\u200F\u206D\u206D\u200C\u202C\u202B\u206E\u202E\u200D\u206A\u202E(gameRunController) : null) is AyaStageHakureiShrineDef.AyaStageHakureiShrine))
					{
						goto IL_0020;
					}
					goto IL_0511;
					int num2;
					for (;;)
					{
						IL_0025:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)((~num * -1795542323 + -310427672) ^ -1418104415)) % 33U)
						{
						case 0U:
						{
							Stage stage;
							num2 = (int)(((!(stage is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination)) ? 3236672116U : 169448285U) ^ (num3 * 1300911267U));
							continue;
						}
						case 1U:
						{
							GameRunController gameRunController2 = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance);
							num2 = ((((gameRunController2 != null) ? AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u202A\u200C\u202D\u202E\u202D\u206F\u202A\u200E\u206A\u202E\u200F\u200B\u202C\u202D\u200B\u200D\u200F\u200B\u200D\u202D\u206B\u202C\u200B\u200C\u206B\u200F\u202D\u200C\u206A\u200F\u206D\u206D\u200C\u202C\u202B\u206E\u202E\u200D\u206A\u202E(gameRunController2) : null) is AyaStagePalaceoftheEarthSpiritsDef.AyaStagePalaceoftheEarthSpirits) ? (-603046484) : 1084086241);
							continue;
						}
						case 2U:
						{
							PlayerUnit playerUnit;
							num2 = (int)(((!(playerUnit is AyaPlayerUnitDef.AyaPlayerUnit)) ? 881319306U : 689826724U) ^ (num3 * 4045532290U));
							continue;
						}
						case 3U:
							num2 = ((!Singleton<AudioManager>.Instance.inLayer0) ? (-1358258372) : 1289690432);
							continue;
						case 4U:
							num2 = (int)((num3 * 2846957732U) ^ 1796132379U);
							continue;
						case 5U:
						{
							string text = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1886701354);
							num2 = -1162784331;
							continue;
						}
						case 6U:
						{
							ConfigEntry<string> ayaRecords = BepinexPlugin.AyaRecords;
							ayaRecords.Value = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u206A\u206D\u206C\u200F\u206A\u200E\u202B\u200F\u206B\u200E\u200F\u202B\u206E\u200F\u200E\u202B\u202D\u200F\u206A\u206F\u200C\u200D\u206A\u202D\u206F\u206F\u200C\u206F\u206D\u200D\u200C\u206F\u200D\u200B\u200B\u200C\u202C\u202A\u200D\u202E(ayaRecords.Value, AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u206A\u202E\u206E\u200B\u202A\u200E\u200C\u202D\u206D\u202A\u206D\u206A\u202D\u206E\u202D\u202D\u206B\u202A\u206C\u200B\u202A\u206B\u200E\u200D\u200C\u200B\u202C\u202E\u202A\u206D\u202C\u206C\u206D\u202B\u200C\u200E\u206A\u200E\u202A\u206D\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-360019263) : <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(357356040));
							num2 = -790699185;
							continue;
						}
						case 7U:
						{
							string text = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1630613117);
							num2 = (AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u206F\u206C\u202C\u206D\u200E\u206F\u202B\u206C\u202D\u206C\u206B\u206E\u206A\u206F\u202B\u200E\u202C\u206A\u206B\u200E\u200B\u202E\u200B\u206C\u206F\u200B\u206C\u200C\u202D\u200C\u200C\u200F\u202D\u202E\u202A\u200C\u202A\u206A\u206A\u206E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-360019263)) ? (-790699185) : 179877627);
							continue;
						}
						case 8U:
						{
							string text;
							Singleton<AudioManager>.Instance.layer0Id = text;
							num2 = (int)((num3 * 835906266U) ^ 2470876845U);
							continue;
						}
						case 9U:
						{
							Stage stage = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202A\u200C\u200C\u206F\u202B\u200F\u206E\u202B\u202B\u200F\u206F\u206B\u206A\u202E\u202B\u200C\u206F\u206C\u200B\u206F\u202E\u200F\u206D\u202E\u206D\u200F\u200D\u206A\u206F\u206B\u200F\u202C\u206D\u202B\u202E\u206C\u202C\u206E\u200C\u206A\u202E(AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance));
							num2 = ((!(stage is AyaStageScarletDevilMansionDef.AyaStageScarletDevilMansion)) ? (-1634360906) : (-1809553062));
							continue;
						}
						case 10U:
						{
							string text = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-317846223);
							num2 = 197565445;
							continue;
						}
						case 11U:
							goto IL_0214;
						case 12U:
							AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u200D\u206F\u202A\u206B\u202B\u206C\u200D\u206F\u206F\u206D\u200E\u202D\u206D\u206E\u202B\u202E\u202A\u202D\u206D\u206B\u206F\u202A\u206E\u202E\u206A\u200B\u206B\u200B\u206C\u206A\u206C\u200B\u206C\u206B\u200F\u200B\u206E\u206B\u202C\u202E(Singleton<AudioManager>.Instance.layer0Id, 0f, true);
							num2 = (int)((num3 * 1600356769U) ^ 555673690U);
							continue;
						case 13U:
							goto IL_0020;
						case 15U:
							return false;
						case 16U:
						{
							string text;
							num2 = (int)(((!AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u206C\u200B\u202C\u206F\u200C\u206E\u202D\u202C\u202E\u202A\u200F\u200C\u206D\u202A\u202A\u200C\u202D\u200D\u206C\u206F\u206B\u200F\u202E\u202B\u200C\u202E\u206F\u200F\u202A\u200B\u200F\u200B\u206B\u200B\u202C\u206B\u200B\u202B\u200D\u202C\u202E(text, Singleton<AudioManager>.Instance.layer0Id)) ? 1013604312U : 980937359U) ^ (num3 * 2389682792U));
							continue;
						}
						case 17U:
							return false;
						case 18U:
						{
							GameRunController gameRunController3 = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance);
							num2 = ((!(((gameRunController3 != null) ? AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u202A\u200C\u202D\u202E\u202D\u206F\u202A\u200E\u206A\u202E\u200F\u200B\u202C\u202D\u200B\u200D\u200F\u200B\u200D\u202D\u206B\u202C\u200B\u200C\u206B\u200F\u202D\u200C\u206A\u200F\u206D\u206D\u200C\u202C\u202B\u206E\u202E\u200D\u206A\u202E(gameRunController3) : null) is AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination)) ? (-644677212) : (-603046484));
							continue;
						}
						case 19U:
							Singleton<AudioManager>.Instance.layer0Time = 0f;
							num2 = (int)((num3 * 4003041164U) ^ 1430618162U);
							continue;
						case 20U:
						{
							string text;
							Singleton<AudioManager>.Instance.layer0Id = text;
							num2 = 2124436791;
							continue;
						}
						case 21U:
							goto IL_0511;
						case 22U:
						{
							string text = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1066695244);
							num2 = -222905872;
							continue;
						}
						case 23U:
						{
							ConfigEntry<string> ayaRecords2 = BepinexPlugin.AyaRecords;
							ayaRecords2.Value = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u206A\u206D\u206C\u200F\u206A\u200E\u202B\u200F\u206B\u200E\u200F\u202B\u206E\u200F\u200E\u202B\u202D\u200F\u206A\u206F\u200C\u200D\u206A\u202D\u206F\u206F\u200C\u206F\u206D\u200D\u200C\u206F\u200D\u200B\u200B\u200C\u202C\u202A\u200D\u202E(ayaRecords2.Value, AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u206A\u202E\u206E\u200B\u202A\u200E\u200C\u202D\u206D\u202A\u206D\u206A\u202D\u206E\u202D\u202D\u206B\u202A\u206C\u200B\u202A\u206B\u200E\u200D\u200C\u200B\u202C\u202E\u202A\u206D\u202C\u206C\u206D\u202B\u200C\u200E\u206A\u200E\u202A\u206D\u202E(BepinexPlugin.AyaRecords.Value) ? <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-317846223) : <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1152116097));
							num2 = -790699185;
							continue;
						}
						case 24U:
							num2 = ((!intoLayer0) ? (-2071012445) : (-1799865602));
							continue;
						case 25U:
						{
							string text = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u206A\u206D\u206C\u200F\u206A\u200E\u202B\u200F\u206B\u200E\u200F\u202B\u206E\u200F\u200E\u202B\u202D\u200F\u206A\u206F\u200C\u200D\u206A\u202D\u206F\u206F\u200C\u206F\u206D\u200D\u200C\u206F\u200D\u200B\u200B\u200C\u202C\u202A\u200D\u202E(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(203265906), level.ToString());
							PlayerUnit playerUnit = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206A\u200F\u206D\u206B\u206D\u200B\u202B\u206E\u206A\u202D\u200D\u206B\u200D\u206D\u206C\u202E\u202B\u206D\u202E\u200E\u206E\u202A\u202C\u200F\u202E\u206B\u206A\u206E\u206E\u200D\u200B\u200F\u206C\u202D\u206A\u206A\u206B\u202C\u202E\u202E(AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance));
							num2 = (int)((num3 * 4103703027U) ^ 884470555U);
							continue;
						}
						case 26U:
						{
							PlayerUnit playerUnit;
							num2 = (int)(((playerUnit is FlandrePlayerUnitDef.FlandrePlayerUnit) ? 3498617421U : 1000143195U) ^ (num3 * 591732888U));
							continue;
						}
						case 27U:
						{
							GameRunController gameRunController4 = AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(Singleton<GameMaster>.Instance);
							num2 = ((((gameRunController4 != null) ? AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202D\u202A\u200C\u202D\u202E\u202D\u206F\u202A\u200E\u206A\u202E\u200F\u200B\u202C\u202D\u200B\u200D\u200F\u200B\u200D\u202D\u206B\u202C\u200B\u200C\u206B\u200F\u202D\u200C\u206A\u200F\u206D\u206D\u200C\u202C\u202B\u206E\u202E\u200D\u206A\u202E(gameRunController4) : null) is AyaStageScarletDevilMansionDef.AyaStageScarletDevilMansion) ? (-603046484) : 534733647);
							continue;
						}
						case 28U:
							num2 = (int)((num3 * 3227441069U) ^ 3422309551U);
							continue;
						case 29U:
							Singleton<AudioManager>.Instance.inLayer0 = true;
							num2 = (int)((num3 * 412880709U) ^ 2497838969U);
							continue;
						case 30U:
							num2 = (int)((num3 * 834403094U) ^ 2257153548U);
							continue;
						case 31U:
							num2 = (int)(((!AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u206F\u206C\u202C\u206D\u200E\u206F\u202B\u206C\u202D\u206C\u206B\u206E\u206A\u206F\u202B\u200E\u202C\u206A\u206B\u200E\u200B\u202E\u200B\u206C\u206F\u200B\u206C\u200C\u202D\u200C\u200C\u200F\u202D\u202E\u202A\u200C\u202A\u206A\u206A\u206E\u202E(BepinexPlugin.AyaRecords.Value, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-317846223))) ? 355397010U : 51539885U) ^ (num3 * 1627326694U));
							continue;
						case 32U:
							Singleton<AudioManager>.Instance.layer0Time = 0f;
							num2 = (int)((num3 * 3225975304U) ^ 4187646664U);
							continue;
						}
						break;
					}
					return true;
					IL_0214:
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.AudioManager_EnterStage_Patch.\u202A\u202C\u202B\u206A\u202C\u200C\u200F\u202D\u206D\u206A\u206C\u202B\u200D\u206E\u206D\u200D\u202B\u202E\u200C\u206E\u206F\u200B\u202D\u202E\u202E\u206C\u202D\u206C\u206D\u200F\u206D\u200C\u202C\u206D\u206C\u200E\u200F\u206E\u202D\u202E();
					return false;
					IL_0020:
					num2 = 1958905630;
					goto IL_0025;
					IL_0511:
					AudioManager.GuardedGetInstance().StopUiBgm();
					num2 = -570011314;
					goto IL_0025;
				}

				static GameRunController \u202C\u206D\u206F\u202B\u200E\u206F\u202E\u200E\u206E\u200E\u202E\u202D\u202D\u206F\u202E\u202D\u202A\u206E\u200D\u206F\u206F\u202D\u202E\u200B\u206C\u202D\u200D\u206F\u206F\u202D\u200C\u200F\u206B\u206E\u200B\u202A\u206E\u206C\u202E\u202E(GameMaster A_0)
				{
					return A_0.CurrentGameRun;
				}

				static Stage \u202D\u202A\u200C\u202D\u202E\u202D\u206F\u202A\u200E\u206A\u202E\u200F\u200B\u202C\u202D\u200B\u200D\u200F\u200B\u200D\u202D\u206B\u202C\u200B\u200C\u206B\u200F\u202D\u200C\u206A\u200F\u206D\u206D\u200C\u202C\u202B\u206E\u202E\u200D\u206A\u202E(GameRunController A_0)
				{
					return A_0.CurrentStage;
				}

				static string \u202D\u206A\u206D\u206C\u200F\u206A\u200E\u202B\u200F\u206B\u200E\u200F\u202B\u206E\u200F\u200E\u202B\u202D\u200F\u206A\u206F\u200C\u200D\u206A\u202D\u206F\u206F\u200C\u206F\u206D\u200D\u200C\u206F\u200D\u200B\u200B\u200C\u202C\u202A\u200D\u202E(string A_0, string A_1)
				{
					return A_0 + A_1;
				}

				static PlayerUnit \u202C\u206A\u200F\u206D\u206B\u206D\u200B\u202B\u206E\u206A\u202D\u200D\u206B\u200D\u206D\u206C\u202E\u202B\u206D\u202E\u200E\u206E\u202A\u202C\u200F\u202E\u206B\u206A\u206E\u206E\u200D\u200B\u200F\u206C\u202D\u206A\u206A\u206B\u202C\u202E\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static bool \u206F\u206C\u202C\u206D\u200E\u206F\u202B\u206C\u202D\u206C\u206B\u206E\u206A\u206F\u202B\u200E\u202C\u206A\u206B\u200E\u200B\u202E\u200B\u206C\u206F\u200B\u206C\u200C\u202D\u200C\u200C\u200F\u202D\u202E\u202A\u200C\u202A\u206A\u206A\u206E\u202E(string A_0, string A_1)
				{
					return A_0.Contains(A_1);
				}

				static bool \u206A\u202E\u206E\u200B\u202A\u200E\u200C\u202D\u206D\u202A\u206D\u206A\u202D\u206E\u202D\u202D\u206B\u202A\u206C\u200B\u202A\u206B\u200E\u200D\u200C\u200B\u202C\u202E\u202A\u206D\u202C\u206C\u206D\u202B\u200C\u200E\u206A\u200E\u202A\u206D\u202E(string A_0)
				{
					return A_0.IsNullOrEmpty();
				}

				static Stage \u202A\u200C\u200C\u206F\u202B\u200F\u206E\u202B\u202B\u200F\u206F\u206B\u206A\u202E\u202B\u200C\u206F\u206C\u200B\u206F\u202E\u200F\u206D\u202E\u206D\u200F\u200D\u206A\u206F\u206B\u200F\u202C\u206D\u202B\u202E\u206C\u202C\u206E\u200C\u206A\u202E(GameRunController A_0)
				{
					return A_0.CurrentStage;
				}

				static bool \u206C\u200B\u202C\u206F\u200C\u206E\u202D\u202C\u202E\u202A\u200F\u200C\u206D\u202A\u202A\u200C\u202D\u200D\u206C\u206F\u206B\u200F\u202E\u202B\u200C\u202E\u206F\u200F\u202A\u200B\u200F\u200B\u206B\u200B\u202C\u206B\u200B\u202B\u200D\u202C\u202E(string A_0, string A_1)
				{
					return A_0 != A_1;
				}

				static void \u202D\u200D\u206F\u202A\u206B\u202B\u206C\u200D\u206F\u206F\u206D\u200E\u202D\u206D\u206E\u202B\u202E\u202A\u202D\u206D\u206B\u206F\u202A\u206E\u202E\u206A\u200B\u206B\u200B\u206C\u206A\u206C\u200B\u206C\u206B\u200F\u200B\u206E\u206B\u202C\u202E(string A_0, float A_1, bool A_2)
				{
					AudioManager.PlayBgm(A_0, A_1, A_2);
				}

				static void \u202A\u202C\u202B\u206A\u202C\u200C\u200F\u202D\u206D\u206A\u206C\u202B\u200D\u206E\u206D\u200D\u202B\u202E\u200C\u206E\u206F\u200B\u202D\u202E\u202E\u206C\u202D\u206C\u206D\u200F\u206D\u200C\u202C\u206D\u206C\u200E\u200F\u206E\u202D\u202E()
				{
					AudioManager.EnterLayer0();
				}
			}

			[HarmonyPatch(typeof(BattleController), "LoseAllExhibits")]
			public class BattleController_LoseAllExhibits_Patch
			{
				private static void Prefix(BattleController __instance)
				{
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.types = (from e in AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.\u206D\u202C\u202D\u202D\u200D\u206C\u206D\u200C\u200F\u200C\u206F\u206C\u202B\u202B\u206E\u206F\u206B\u200E\u206D\u200E\u206F\u202A\u206E\u202E\u202C\u202D\u202C\u200C\u200F\u200F\u200B\u200C\u206D\u206C\u202D\u202B\u206D\u206F\u206B\u206C\u202E(AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.\u202A\u206A\u200F\u200F\u200B\u206C\u206D\u206F\u200F\u200E\u200F\u206B\u206A\u206C\u200C\u206A\u200D\u200F\u200E\u206E\u200D\u206C\u202A\u200B\u200B\u202C\u200B\u202A\u206F\u206E\u202D\u206D\u200F\u202C\u200B\u202E\u200E\u206B\u202A\u206F\u202E(__instance))
						where AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.<>c.\u206C\u206B\u202A\u206E\u206C\u206D\u202D\u200D\u200D\u206E\u200C\u206F\u206E\u206F\u206A\u202D\u202B\u200C\u200C\u202A\u200E\u202A\u200F\u206A\u206A\u202E\u206E\u202E\u200F\u202A\u206B\u206F\u202B\u200F\u206E\u200D\u200D\u206B\u200D\u206D\u202E(e) == ExhibitLosableType.Losable
						select AyaStageHakureiShrineDef.AyaStageHakureiShrine.BattleController_LoseAllExhibits_Patch.<>c.\u206D\u202B\u206C\u206C\u206D\u202B\u206E\u202E\u200F\u206E\u206E\u206F\u202A\u206A\u200E\u200D\u202C\u206A\u202A\u206D\u206E\u202A\u200C\u206C\u206F\u200E\u206B\u200F\u202E\u202C\u200C\u202D\u200B\u202A\u200C\u206C\u206E\u200C\u206B\u200D\u202E(e)).ToArray<Type>();
				}

				static PlayerUnit \u202A\u206A\u200F\u200F\u200B\u206C\u206D\u206F\u200F\u200E\u200F\u206B\u206A\u206C\u200C\u206A\u200D\u200F\u200E\u206E\u200D\u206C\u202A\u200B\u200B\u202C\u200B\u202A\u206F\u206E\u202D\u206D\u200F\u202C\u200B\u202E\u200E\u206B\u202A\u206F\u202E(BattleController A_0)
				{
					return A_0.Player;
				}

				static IReadOnlyList<Exhibit> \u206D\u202C\u202D\u202D\u200D\u206C\u206D\u200C\u200F\u200C\u206F\u206C\u202B\u202B\u206E\u206F\u206B\u200E\u206D\u200E\u206F\u202A\u206E\u202E\u202C\u202D\u202C\u200C\u200F\u200F\u200B\u200C\u206D\u206C\u202D\u202B\u206D\u206F\u206B\u206C\u202E(PlayerUnit A_0)
				{
					return A_0.Exhibits;
				}

				public static Type[] types = new Type[0];
			}

			[HarmonyPatch(typeof(GameMaster), "AdventureFlow")]
			private class GameMaster_AdventureFlow_Patch
			{
				private static bool Prefix(GameMaster __instance, ref Station station)
				{
					if (!(AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.\u206E\u206C\u202A\u202A\u206E\u202E\u202A\u200E\u206E\u200F\u206A\u206C\u200C\u206D\u206B\u200D\u206B\u202E\u200E\u202A\u206B\u200D\u202B\u206B\u206D\u200F\u206C\u206C\u200D\u200B\u200E\u200B\u206E\u206C\u200E\u206F\u200D\u206D\u200F\u202C\u202E(station) is AyaStageHakureiShrineDef.AyaStageHakureiShrine))
					{
						goto IL_0011;
					}
					goto IL_00AE;
					int num2;
					for (;;)
					{
						IL_0016:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(-num - ~(581166801 ^ 1042727553))) % 6U)
						{
						case 0U:
							return false;
						case 1U:
							num2 = (int)(((AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.\u206E\u206C\u202A\u202A\u206E\u202E\u202A\u200E\u206E\u200F\u206A\u206C\u200C\u206D\u206B\u200D\u206B\u202E\u200E\u202A\u206B\u200D\u202B\u206B\u206D\u200F\u206C\u206C\u200D\u200B\u200E\u200B\u206E\u206C\u200E\u206F\u200D\u206D\u200F\u202C\u202E(station) is AyaStagePalaceoftheEarthSpiritsDef.AyaStagePalaceoftheEarthSpirits) ? 186391721U : 298344237U) ^ (num3 * 3348559561U));
							continue;
						case 3U:
							num2 = (int)(((!(AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.\u206E\u206C\u202A\u202A\u206E\u202E\u202A\u200E\u206E\u200F\u206A\u206C\u200C\u206D\u206B\u200D\u206B\u202E\u200E\u202A\u206B\u200D\u202B\u206B\u206D\u200F\u206C\u206C\u200D\u200B\u200E\u200B\u206E\u206C\u200E\u206F\u200D\u206D\u200F\u202C\u202E(station) is AyaStageScarletDevilMansionDef.AyaStageScarletDevilMansion)) ? 2264714993U : 2498976366U) ^ (num3 * 1685442956U));
							continue;
						case 4U:
							goto IL_0011;
						case 5U:
							goto IL_00AE;
						}
						break;
					}
					return true;
					IL_0011:
					num2 = -625222010;
					goto IL_0016;
					IL_00AE:
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.\u206B\u202C\u206C\u202C\u206E\u202A\u206C\u202C\u202A\u200E\u202E\u206A\u200D\u200B\u206D\u202E\u206B\u206F\u206B\u202E\u200B\u206D\u200E\u202B\u202C\u206F\u206F\u206D\u200D\u200B\u202B\u206C\u206D\u200F\u206A\u206F\u202E\u206F\u206E\u206C\u202E(UiManager.GetPanel<BackgroundPanel>(), true);
					AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.\u206D\u206A\u202A\u200E\u206C\u200E\u200D\u200C\u206C\u206D\u202A\u200F\u200B\u206A\u206B\u202D\u200B\u200F\u200C\u200B\u202C\u200C\u202D\u200D\u206C\u200E\u206C\u202E\u200D\u202E\u206E\u202A\u200B\u202B\u200E\u206A\u200C\u200E\u202B\u206E\u202E(Singleton<GameMaster>.Instance, AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.coroutine());
					num2 = -837374179;
					goto IL_0016;
				}

				private static IEnumerator coroutine()
				{
					return new AyaStageHakureiShrineDef.AyaStageHakureiShrine.GameMaster_AdventureFlow_Patch.<coroutine>d__1(0);
				}

				static Stage \u206E\u206C\u202A\u202A\u206E\u202E\u202A\u200E\u206E\u200F\u206A\u206C\u200C\u206D\u206B\u200D\u206B\u202E\u200E\u202A\u206B\u200D\u202B\u206B\u206D\u200F\u206C\u206C\u200D\u200B\u200E\u200B\u206E\u206C\u200E\u206F\u200D\u206D\u200F\u202C\u202E(Station A_0)
				{
					return A_0.Stage;
				}

				static void \u206B\u202C\u206C\u202C\u206E\u202A\u206C\u202C\u202A\u200E\u202E\u206A\u200D\u200B\u206D\u202E\u206B\u206F\u206B\u202E\u200B\u206D\u200E\u202B\u202C\u206F\u206F\u206D\u200D\u200B\u202B\u206C\u206D\u200F\u206A\u206F\u202E\u206F\u206E\u206C\u202E(UiPanelBase A_0, bool A_1)
				{
					A_0.Hide(A_1);
				}

				static Coroutine \u206D\u206A\u202A\u200E\u206C\u200E\u200D\u200C\u206C\u206D\u202A\u200F\u200B\u206A\u206B\u202D\u200B\u200F\u200C\u200B\u202C\u200C\u202D\u200D\u206C\u200E\u206C\u202E\u200D\u202E\u206E\u202A\u200B\u202B\u200E\u206A\u200C\u200E\u202B\u206E\u202E(MonoBehaviour A_0, IEnumerator A_1)
				{
					return A_0.StartCoroutine(A_1);
				}
			}
		}
	}
}
