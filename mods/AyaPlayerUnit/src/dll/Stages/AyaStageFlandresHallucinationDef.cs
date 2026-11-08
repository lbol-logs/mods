using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Adventures;
using LBoL.Core.Randoms;
using LBoL.Core.Stations;
using LBoL.Core.Units;
using LBoL.EntityLib.Exhibits;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;

namespace AyaShameimaru.Stages
{
	public sealed class AyaStageFlandresHallucinationDef : StageTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1538577698);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StageConfig MakeConfig()
		{
			StageConfig stageConfig = this.\u202B\u202A\u206C\u202C\u206C\u206B\u206F\u206E\u206E\u206A\u202C\u206F\u200B\u200C\u200C\u202C\u200F\u206F\u206D\u200E\u206D\u200C\u206D\u206E\u202B\u206B\u206C\u206B\u200B\u200D\u206F\u200C\u202C\u202C\u206B\u200C\u202E\u206A\u200C\u206C\u202E();
			stageConfig.Obj0 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1680664430);
			stageConfig.Obj1 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1268701156);
			stageConfig.Level1 = 1;
			stageConfig.Obj2 = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1268701156);
			stageConfig.Level2 = 6;
			stageConfig.Obj3 = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1784922083);
			stageConfig.Level3 = 11;
			stageConfig.Obj4 = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1680664430);
			stageConfig.Level4 = 16;
			return stageConfig;
		}

		StageConfig \u202B\u202A\u206C\u202C\u206C\u206B\u206F\u206E\u206E\u206A\u202C\u206F\u200B\u200C\u200C\u202C\u200F\u206F\u206D\u200E\u206D\u200C\u206D\u206E\u202B\u206B\u206C\u206B\u200B\u200D\u206F\u200C\u202C\u202C\u206B\u200C\u202E\u206A\u200C\u206C\u202E()
		{
			return base.DefaultConfig();
		}

		[EntityLogic(typeof(AyaStageFlandresHallucinationDef))]
		public sealed class AyaStageFlandresHallucination : AyaStage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			public AyaStageFlandresHallucination()
			{
				for (;;)
				{
					IL_0006:
					int num = 1803835240;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(num2 - 2124818423 * 906601534 + (~-604884280 ^ (-892883214 + 863141183))) + -362100150)) % 6U)
						{
						case 0U:
							goto IL_0006;
						case 2U:
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u202B\u200B\u200E\u206A\u200E\u200B\u200F\u206D\u202E\u200D\u206B\u206D\u206F\u206B\u206A\u206A\u200D\u200F\u202B\u202D\u206A\u200B\u202A\u200D\u202C\u200E\u206C\u202E\u206E\u200D\u202E\u200F\u206D\u202B\u202E\u200F\u206F\u202D\u200E\u202E(this, new RepeatableRandomPool<string> { 
							{
								<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(249015830),
								1f
							} });
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u200D\u202E\u200D\u200F\u202E\u202E\u206C\u206D\u202B\u200C\u200E\u202B\u206E\u202A\u206D\u200B\u206E\u206A\u206F\u206A\u206D\u200E\u202B\u206F\u200B\u202D\u206C\u202C\u202B\u200C\u200D\u202C\u200F\u202A\u202A\u206B\u206C\u200E\u206C\u202E(this, new UniqueRandomPool<Type>(true) { 
							{
								AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206B\u202E\u206D\u200B\u202B\u200F\u206F\u206F\u200E\u202E\u206A\u206D\u200C\u200C\u202B\u200E\u206F\u200F\u200F\u202B\u200C\u202E\u206E\u200D\u206D\u200C\u206D\u202A\u202E\u206C\u206E\u202C\u206A\u206F\u202C\u206B\u200C\u206A\u202B\u200D\u202E(typeof(FakeAdventure).TypeHandle),
								1f
							} });
							num = (int)((num3 * 2711956951U) ^ 2809692823U);
							continue;
						case 3U:
							base.CardUpgradedChance = 0f;
							base.EternalStageMusic = true;
							num = (int)((num3 * 2745382501U) ^ 1543515154U);
							continue;
						case 4U:
							this.IsNormalStage = true;
							base.Level = -1;
							num = (int)((num3 * 25832579U) ^ 268773247U);
							continue;
						case 5U:
							base.DontAutoOpenMapInEntry = true;
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206B\u202D\u206B\u206A\u200E\u206F\u206D\u200F\u200D\u202A\u202B\u200D\u206D\u200E\u202A\u206E\u202E\u200D\u202C\u206F\u206E\u202E\u202B\u200D\u206E\u200F\u206D\u202C\u200F\u200C\u202C\u200F\u206E\u206A\u206B\u206A\u202E\u202A\u206C\u200C\u202E(this, new UniqueRandomPool<string>(false) { 
							{
								<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-38155019),
								1f
							} });
							num = (int)((num3 * 63277754U) ^ 2448406056U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.SentinelExhibitType = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206B\u202E\u206D\u200B\u202B\u200F\u206F\u206F\u200E\u202E\u206A\u206D\u200C\u200C\u202B\u200E\u206F\u200F\u200F\u202B\u200C\u202E\u206E\u200D\u206D\u200C\u206D\u202A\u202E\u206C\u206E\u202C\u206A\u206F\u202C\u206B\u200C\u206A\u202B\u200D\u202E(typeof(KongZhanpinhe).TypeHandle);
			}

			public override EnemyGroupEntry GetBoss()
			{
				return this.\u202A\u202C\u202E\u200B\u206F\u200C\u202A\u200B\u206E\u200D\u200E\u202D\u206B\u202E\u200C\u200F\u200E\u202A\u200E\u200B\u200E\u202D\u202C\u202C\u202B\u202C\u202C\u200D\u206E\u206B\u206B\u206F\u206E\u202B\u206A\u206C\u200B\u200F\u200C\u206A\u202E();
			}

			public override void SetBoss(string enemyGroupName)
			{
				this.\u202B\u200C\u202A\u206F\u206D\u206B\u202E\u206E\u206B\u206D\u206A\u206C\u202C\u206A\u200E\u202E\u206A\u206D\u200E\u206A\u200E\u206B\u206F\u200F\u202C\u200D\u206F\u200B\u206C\u202B\u202A\u206F\u206F\u202E\u200C\u202C\u206C\u202C\u206C\u206C\u202E(enemyGroupName);
			}

			public override void InitBoss(RandomGen rng)
			{
				base.Boss = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202B\u202E\u200C\u206D\u206C\u200B\u200C\u202A\u202E\u206C\u202D\u200F\u200C\u206C\u202D\u206B\u200D\u200D\u200B\u200E\u206E\u200C\u206C\u206A\u200F\u206A\u202C\u202E\u206A\u202D\u200F\u202D\u202C\u200F\u202C\u202E\u202B\u202C\u200B\u202A\u202E(AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202B\u200D\u200E\u200C\u202E\u202E\u206C\u202E\u206A\u206B\u206F\u202C\u200D\u200C\u202A\u202E\u206D\u206D\u206B\u200E\u200B\u206A\u202A\u200D\u206A\u202B\u200F\u206D\u206B\u200C\u206E\u202B\u202B\u202A\u202D\u206E\u200D\u200C\u200D\u200F\u202E(this).SampleOrDefault(rng));
			}

			public override GameMap CreateMap()
			{
				AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206A\u202B\u206B\u200E\u202A\u202A\u206A\u202D\u200B\u200F\u206B\u202B\u206E\u202C\u202C\u206C\u200F\u200B\u206A\u202D\u206D\u206E\u206C\u202A\u206C\u206A\u202A\u206A\u200C\u202B\u206C\u206E\u206B\u200F\u202E\u200F\u200B\u206E\u200C\u202B\u202E(this, AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202C\u202B\u202A\u200B\u200B\u206B\u202C\u202C\u206B\u206B\u206E\u206B\u206B\u200B\u206B\u200F\u206B\u202B\u202B\u206E\u202A\u200D\u202B\u206C\u200B\u206F\u200D\u206C\u206C\u200C\u200E\u202D\u206E\u200E\u202B\u206A\u202A\u206D\u206B\u202E(this)._stageIndex);
				GameMap gameMap = new GameMap(26, 6, GameMap.UiType.NormalGame, "");
				for (;;)
				{
					IL_0020:
					int num = 2037367224;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)((num2 + ((~755112570 ^ (-1872408156 ^ 1174450766)) - ((-1032158647 ^ -2024160027) - 655107427 * -414414897))) ^ ((87362628 ^ 1719781179) - ~-2005417887))))) % 16U)
						{
						case 0U:
							gameMap.StartNode = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u200C\u202C\u206C\u206A\u206E\u200F\u200B\u202A\u200F\u206C\u200E\u200F\u202A\u200B\u200E\u206A\u202B\u200C\u206D\u206B\u202C\u206E\u202A\u202E\u200E\u206F\u206B\u206B\u206D\u202D\u206B\u202A\u202B\u202E\u206F\u206F\u202C\u206C\u206A\u202E(gameMap)[0, 0];
							num = (int)((num3 * 250241921U) ^ 2696045522U);
							continue;
						case 2U:
						{
							int num4;
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202D\u200B\u206E\u206F\u202E\u200F\u202B\u206E\u202A\u206D\u202B\u200F\u206B\u206D\u200B\u206E\u206D\u206A\u200D\u206F\u202A\u200C\u202E\u206C\u206B\u200B\u206B\u206A\u206D\u200D\u206A\u206A\u200C\u206D\u202D\u202E\u202C\u206B\u206C\u200E\u202E(AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u200C\u202C\u206C\u206A\u206E\u200F\u200B\u202A\u200F\u206C\u200E\u200F\u202A\u200B\u200E\u206A\u202B\u200C\u206D\u206B\u202C\u206E\u202A\u202E\u200E\u206F\u206B\u206B\u206D\u202D\u206B\u202A\u202B\u202E\u206F\u206F\u202C\u206C\u206A\u202E(gameMap)[0, 0]).Add(num4);
							num4++;
							num = -1265314274;
							continue;
						}
						case 3U:
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u200F\u206D\u206F\u202D\u206A\u206F\u202D\u200C\u200C\u206E\u200B\u200E\u206F\u202B\u202B\u206B\u202C\u206E\u200C\u206D\u206C\u200D\u206F\u206C\u206D\u202D\u202A\u200D\u200D\u202C\u200F\u200B\u202E\u206F\u200B\u202E\u200E\u200D\u200F\u202E\u202E(AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202C\u206D\u206B\u200D\u206F\u206A\u206D\u200D\u206B\u206E\u202C\u202C\u206B\u206A\u200D\u200C\u206B\u202B\u206F\u202C\u206C\u200C\u200C\u200B\u202A\u200B\u200E\u200E\u206D\u206C\u206F\u200E\u206F\u200D\u200C\u200E\u200D\u200E\u206E\u200E\u202E(gameMap), MapNodeStatus.Active);
							num = (int)((num3 * 2384633442U) ^ 2715157366U);
							continue;
						case 4U:
						{
							MapNode[,] array = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u200C\u202C\u206C\u206A\u206E\u200F\u200B\u202A\u200F\u206C\u200E\u200F\u202A\u200B\u200E\u206A\u202B\u200C\u206D\u206B\u202C\u206E\u202A\u202E\u200E\u206F\u206B\u206B\u206D\u202D\u206B\u202A\u202B\u202E\u206F\u206F\u202C\u206C\u206A\u202E(gameMap);
							int num6;
							int num5 = num6;
							int num8;
							int num7 = num8;
							MapNode mapNode = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202B\u206D\u202D\u202C\u202A\u206D\u206F\u202E\u202A\u206A\u202A\u200B\u206F\u200E\u200D\u206F\u200E\u200D\u200F\u200B\u200C\u206A\u202A\u200B\u206F\u202B\u202D\u206C\u202E\u206A\u200E\u200F\u202E\u206D\u200F\u202A\u206A\u206A\u202D\u202E\u202E(gameMap, num6, num8, 1);
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206F\u200C\u200B\u202A\u202C\u206B\u200C\u206A\u200F\u200C\u202D\u200F\u200B\u206C\u202E\u206E\u200C\u200D\u206F\u200C\u202E\u206C\u202C\u206B\u200E\u202E\u206C\u206C\u200E\u202E\u200E\u206B\u202A\u200D\u206F\u200E\u206D\u200D\u200E\u206A\u202E(mapNode, StationType.EliteEnemy);
							array[num5, num7] = mapNode;
							num = 1968797465;
							continue;
						}
						case 5U:
						{
							int num8;
							num = ((num8 < 6) ? 1984714133 : (-1973084166));
							continue;
						}
						case 6U:
						{
							int num8 = 1;
							num = -1776245596;
							continue;
						}
						case 7U:
							num = (int)((num3 * 774271040U) ^ 2485151710U);
							continue;
						case 8U:
						{
							int num8;
							num8++;
							num = (int)((num3 * 3067493234U) ^ 1463959860U);
							continue;
						}
						case 9U:
						{
							MapNode[,] array2 = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202E\u200C\u202C\u206C\u206A\u206E\u200F\u200B\u202A\u200F\u206C\u200E\u200F\u202A\u200B\u200E\u206A\u202B\u200C\u206D\u206B\u202C\u206E\u202A\u202E\u200E\u206F\u206B\u206B\u206D\u202D\u206B\u202A\u202B\u202E\u206F\u206F\u202C\u206C\u206A\u202E(gameMap);
							int num9 = 0;
							int num10 = 0;
							MapNode mapNode2 = AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u202B\u206D\u202D\u202C\u202A\u206D\u206F\u202E\u202A\u206A\u202A\u200B\u206F\u200E\u200D\u206F\u200E\u200D\u200F\u200B\u200C\u206A\u202A\u200B\u206F\u202B\u202D\u206C\u202E\u206A\u200E\u200F\u202E\u206D\u200F\u202A\u206A\u206A\u202D\u202E\u202E(gameMap, 0, 0, 1);
							AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206F\u200C\u200B\u202A\u202C\u206B\u200C\u206A\u200F\u200C\u202D\u200F\u200B\u206C\u202E\u206E\u200C\u200D\u206F\u200C\u202E\u206C\u202C\u206B\u200E\u202E\u206C\u206C\u200E\u202E\u200E\u206B\u202A\u200D\u206F\u200E\u206D\u200D\u200E\u206A\u202E(mapNode2, StationType.Entry);
							array2[num9, num10] = mapNode2;
							int num4 = 1;
							num = (int)((num3 * 2383295739U) ^ 2529025381U);
							continue;
						}
						case 10U:
							goto IL_0020;
						case 11U:
						{
							int num6;
							num6++;
							num = (int)((num3 * 3929297711U) ^ 1623428970U);
							continue;
						}
						case 12U:
							GameMap.GetAct1(AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206A\u202A\u202A\u206A\u202B\u206F\u202D\u202D\u206B\u206E\u202D\u200E\u202B\u202B\u206A\u206A\u202A\u200E\u202B\u206E\u206A\u200D\u206A\u200C\u206A\u200B\u200D\u206A\u200F\u206A\u200E\u200C\u206F\u200D\u206E\u200D\u200E\u206F\u206E\u200D\u202E(AyaStageFlandresHallucinationDef.AyaStageFlandresHallucination.\u206D\u202E\u202D\u202E\u206A\u206B\u202C\u200B\u200C\u206D\u200C\u206A\u200F\u206F\u202A\u200D\u200D\u206A\u206C\u202B\u206C\u202D\u200F\u206A\u206E\u200B\u202A\u202C\u200B\u206A\u206D\u202E\u206E\u200F\u202C\u202B\u200E\u202A\u206F\u206C\u202E(this)));
							num = (int)((num3 * 4093896991U) ^ 2720229096U);
							continue;
						case 13U:
						{
							int num6 = 1;
							num = (int)((num3 * 3923651547U) ^ 2208178480U);
							continue;
						}
						case 14U:
						{
							int num6;
							num = ((num6 >= 26) ? (-1255654655) : (-1055870073));
							continue;
						}
						case 15U:
						{
							int num4;
							num = ((num4 >= 6) ? (-1038702211) : 1502828659);
							continue;
						}
						}
						return gameMap;
					}
				}
				return gameMap;
			}

			static void \u206B\u202D\u206B\u206A\u200E\u206F\u206D\u200F\u200D\u202A\u202B\u200D\u206D\u200E\u202A\u206E\u202E\u200D\u202C\u206F\u206E\u202E\u202B\u200D\u206E\u200F\u206D\u202C\u200F\u200C\u202C\u200F\u206E\u206A\u206B\u206A\u202E\u202A\u206C\u200C\u202E(Stage A_0, UniqueRandomPool<string> A_1)
			{
				A_0.EliteEnemyPool = A_1;
			}

			static void \u202E\u202B\u200B\u200E\u206A\u200E\u200B\u200F\u206D\u202E\u200D\u206B\u206D\u206F\u206B\u206A\u206A\u200D\u200F\u202B\u202D\u206A\u200B\u202A\u200D\u202C\u200E\u206C\u202E\u206E\u200D\u202E\u200F\u206D\u202B\u202E\u200F\u206F\u202D\u200E\u202E(Stage A_0, RepeatableRandomPool<string> A_1)
			{
				A_0.BossPool = A_1;
			}

			static Type \u206B\u202E\u206D\u200B\u202B\u200F\u206F\u206F\u200E\u202E\u206A\u206D\u200C\u200C\u202B\u200E\u206F\u200F\u200F\u202B\u200C\u202E\u206E\u200D\u206D\u200C\u206D\u202A\u202E\u206C\u206E\u202C\u206A\u206F\u202C\u206B\u200C\u206A\u202B\u200D\u202E(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			static void \u202E\u200D\u202E\u200D\u200F\u202E\u202E\u206C\u206D\u202B\u200C\u200E\u202B\u206E\u202A\u206D\u200B\u206E\u206A\u206F\u206A\u206D\u200E\u202B\u206F\u200B\u202D\u206C\u202C\u202B\u200C\u200D\u202C\u200F\u202A\u202A\u206B\u206C\u200E\u206C\u202E(Stage A_0, UniqueRandomPool<Type> A_1)
			{
				A_0.AdventurePool = A_1;
			}

			EnemyGroupEntry \u202A\u202C\u202E\u200B\u206F\u200C\u202A\u200B\u206E\u200D\u200E\u202D\u206B\u202E\u200C\u200F\u200E\u202A\u200E\u200B\u200E\u202D\u202C\u202C\u202B\u202C\u202C\u200D\u206E\u206B\u206B\u206F\u206E\u202B\u206A\u206C\u200B\u200F\u200C\u206A\u202E()
			{
				return base.GetBoss();
			}

			void \u202B\u200C\u202A\u206F\u206D\u206B\u202E\u206E\u206B\u206D\u206A\u206C\u202C\u206A\u200E\u202E\u206A\u206D\u200E\u206A\u200E\u206B\u206F\u200F\u202C\u200D\u206F\u200B\u206C\u202B\u202A\u206F\u206F\u202E\u200C\u202C\u206C\u202C\u206C\u206C\u202E(string A_1)
			{
				base.SetBoss(A_1);
			}

			static RepeatableRandomPool<string> \u202B\u200D\u200E\u200C\u202E\u202E\u206C\u202E\u206A\u206B\u206F\u202C\u200D\u200C\u202A\u202E\u206D\u206D\u206B\u200E\u200B\u206A\u202A\u200D\u206A\u202B\u200F\u206D\u206B\u200C\u206E\u202B\u202B\u202A\u202D\u206E\u200D\u200C\u200D\u200F\u202E(Stage A_0)
			{
				return A_0.BossPool;
			}

			static EnemyGroupEntry \u202B\u202E\u200C\u206D\u206C\u200B\u200C\u202A\u202E\u206C\u202D\u200F\u200C\u206C\u202D\u206B\u200D\u200D\u200B\u200E\u206E\u200C\u206C\u206A\u200F\u206A\u202C\u202E\u206A\u202D\u200F\u202D\u202C\u200F\u202C\u202E\u202B\u202C\u200B\u202A\u202E(string A_0)
			{
				return Library.GetEnemyGroupEntry(A_0);
			}

			static GameRunController \u202C\u202B\u202A\u200B\u200B\u206B\u202C\u202C\u206B\u206B\u206E\u206B\u206B\u200B\u206B\u200F\u206B\u202B\u202B\u206E\u202A\u200D\u202B\u206C\u200B\u206F\u200D\u206C\u206C\u200C\u200E\u202D\u206E\u200E\u202B\u206A\u202A\u206D\u206B\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static void \u206A\u202B\u206B\u200E\u202A\u202A\u206A\u202D\u200B\u200F\u206B\u202B\u206E\u202C\u202C\u206C\u200F\u200B\u206A\u202D\u206D\u206E\u206C\u202A\u206C\u206A\u202A\u206A\u200C\u202B\u206C\u206E\u206B\u200F\u202E\u200F\u200B\u206E\u200C\u202B\u202E(Stage A_0, int A_1)
			{
				A_0.Index = A_1;
			}

			static MapNode[,] \u202E\u200C\u202C\u206C\u206A\u206E\u200F\u200B\u202A\u200F\u206C\u200E\u200F\u202A\u200B\u200E\u206A\u202B\u200C\u206D\u206B\u202C\u206E\u202A\u202E\u200E\u206F\u206B\u206B\u206D\u202D\u206B\u202A\u202B\u202E\u206F\u206F\u202C\u206C\u206A\u202E(GameMap A_0)
			{
				return A_0.Nodes;
			}

			static MapNode \u202B\u206D\u202D\u202C\u202A\u206D\u206F\u202E\u202A\u206A\u202A\u200B\u206F\u200E\u200D\u206F\u200E\u200D\u200F\u200B\u200C\u206A\u202A\u200B\u206F\u202B\u202D\u206C\u202E\u206A\u200E\u200F\u202E\u206D\u200F\u202A\u206A\u206A\u202D\u202E\u202E(GameMap A_0, int A_1, int A_2, int A_3)
			{
				return new MapNode(A_0, A_1, A_2, A_3);
			}

			static void \u206F\u200C\u200B\u202A\u202C\u206B\u200C\u206A\u200F\u200C\u202D\u200F\u200B\u206C\u202E\u206E\u200C\u200D\u206F\u200C\u202E\u206C\u202C\u206B\u200E\u202E\u206C\u206C\u200E\u202E\u200E\u206B\u202A\u200D\u206F\u200E\u206D\u200D\u200E\u206A\u202E(MapNode A_0, StationType A_1)
			{
				A_0.StationType = A_1;
			}

			static List<int> \u202D\u200B\u206E\u206F\u202E\u200F\u202B\u206E\u202A\u206D\u202B\u200F\u206B\u206D\u200B\u206E\u206D\u206A\u200D\u206F\u202A\u200C\u202E\u206C\u206B\u200B\u206B\u206A\u206D\u200D\u206A\u206A\u200C\u206D\u202D\u202E\u202C\u206B\u206C\u200E\u202E(MapNode A_0)
			{
				return A_0.FollowerList;
			}

			static ulong \u206D\u202E\u202D\u202E\u206A\u206B\u202C\u200B\u200C\u206D\u200C\u206A\u200F\u206F\u202A\u200D\u200D\u206A\u206C\u202B\u206C\u202D\u200F\u206A\u206E\u200B\u202A\u202C\u200B\u206A\u206D\u202E\u206E\u200F\u202C\u202B\u200E\u202A\u206F\u206C\u202E(Stage A_0)
			{
				return A_0.MapSeed;
			}

			static RandomGen \u206A\u202A\u202A\u206A\u202B\u206F\u202D\u202D\u206B\u206E\u202D\u200E\u202B\u202B\u206A\u206A\u202A\u200E\u202B\u206E\u206A\u200D\u206A\u200C\u206A\u200B\u200D\u206A\u200F\u206A\u200E\u200C\u206F\u200D\u206E\u200D\u200E\u206F\u206E\u200D\u202E(ulong A_0)
			{
				return new RandomGen(A_0);
			}

			static MapNode \u202C\u206D\u206B\u200D\u206F\u206A\u206D\u200D\u206B\u206E\u202C\u202C\u206B\u206A\u200D\u200C\u206B\u202B\u206F\u202C\u206C\u200C\u200C\u200B\u202A\u200B\u200E\u200E\u206D\u206C\u206F\u200E\u206F\u200D\u200C\u200E\u200D\u200E\u206E\u200E\u202E(GameMap A_0)
			{
				return A_0.StartNode;
			}

			static void \u200F\u206D\u206F\u202D\u206A\u206F\u202D\u200C\u200C\u206E\u200B\u200E\u206F\u202B\u202B\u206B\u202C\u206E\u200C\u206D\u206C\u200D\u206F\u206C\u206D\u202D\u202A\u200D\u200D\u202C\u200F\u200B\u202E\u206F\u200B\u202E\u200E\u200D\u200F\u202E\u202E(MapNode A_0, MapNodeStatus A_1)
			{
				A_0.Status = A_1;
			}
		}
	}
}
