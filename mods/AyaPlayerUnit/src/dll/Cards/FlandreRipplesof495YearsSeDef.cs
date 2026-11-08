using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AyaShameimaru.PlayerUnits;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.Presentation;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreRipplesof495YearsSeDef : StatusEffectTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2116448229);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreRipplesof495YearsSeDef.\u206F\u202E\u206F\u206D\u202A\u206F\u202C\u206B\u202B\u200C\u200E\u206E\u206A\u200C\u200F\u206D\u206D\u206E\u206D\u200D\u206B\u206E\u202B\u202A\u206F\u200D\u202B\u200D\u202D\u206B\u202D\u200E\u206A\u206C\u202B\u200C\u206B\u206E\u206B\u206E\u202E(BepinexPlugin.statusEffectLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Sprite LoadSprite()
		{
			return FlandreRipplesof495YearsSeDef.\u200E\u202D\u202D\u206B\u206A\u202E\u206A\u206F\u206A\u200E\u200D\u200F\u200D\u202A\u200C\u200F\u200F\u200D\u200F\u200E\u202E\u202E\u200F\u200E\u200D\u200D\u202C\u206B\u206E\u202D\u206C\u200E\u202E\u202E\u200E\u202D\u200B\u206C\u200E\u202C\u202E(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-606758436), BepinexPlugin.embeddedSource, null, 1, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override StatusEffectConfig MakeConfig()
		{
			return new StatusEffectConfig(FlandreRipplesof495YearsSeDef.\u200B\u206E\u202A\u206A\u200D\u202D\u206B\u206B\u200F\u206A\u200B\u206E\u202B\u200D\u206B\u206A\u200E\u200F\u200F\u206D\u200F\u206D\u200E\u202C\u206D\u200F\u200F\u200B\u200D\u200F\u206A\u200D\u202E\u206D\u202D\u202B\u202E\u206A\u202E\u200F\u202E(BepinexPlugin.sequenceTable, FlandreRipplesof495YearsSeDef.\u206D\u202E\u200F\u202C\u202D\u200D\u206B\u200F\u200F\u200D\u202B\u202C\u202A\u206B\u206F\u202A\u200F\u200C\u206C\u206D\u202A\u200F\u202C\u206E\u202A\u202E\u206F\u200D\u200F\u206E\u202A\u206E\u202D\u200D\u200C\u202C\u200D\u202B\u206D\u202E\u202E(typeof(StatusEffectConfig).TypeHandle)), "", -2, StatusEffectType.Special, false, true, null, true, new StackType?(StackType.Max), false, new StackType?(StackType.Add), DurationDecreaseTiming.Custom, false, new StackType?(StackType.Keep), new StackType?(StackType.Keep), false, Keyword.Philosophy, new List<string>(), null, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-816144908), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-161473794), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(103491368));
		}

		static BatchLocalization \u206F\u202E\u206F\u206D\u202A\u206F\u202C\u206B\u202B\u200C\u200E\u206E\u206A\u200C\u200F\u206D\u206D\u206E\u206D\u200D\u206B\u206E\u202B\u202A\u206F\u200D\u202B\u200D\u202D\u206B\u202D\u200E\u206A\u206C\u202B\u200C\u206B\u206E\u206B\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Sprite \u200E\u202D\u202D\u206B\u206A\u202E\u206A\u206F\u206A\u200E\u200D\u200F\u200D\u202A\u200C\u200F\u200F\u200D\u200F\u200E\u202E\u202E\u200F\u200E\u200D\u200D\u202C\u206B\u206E\u202D\u206C\u200E\u202E\u202E\u200E\u202D\u200B\u206C\u200E\u202C\u202E(string A_0, IResourceSource A_1, Rect? A_2, int A_3, Vector2? A_4)
		{
			return ResourceLoader.LoadSprite(A_0, A_1, A_2, A_3, A_4);
		}

		static Type \u206D\u202E\u200F\u202C\u202D\u200D\u206B\u200F\u200F\u200D\u202B\u202C\u202A\u206B\u206F\u202A\u200F\u200C\u206C\u206D\u202A\u200F\u202C\u206E\u202A\u202E\u206F\u200D\u200F\u206E\u202A\u206E\u202D\u200D\u200C\u202C\u200D\u202B\u206D\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200B\u206E\u202A\u206A\u200D\u202D\u206B\u206B\u200F\u206A\u200B\u206E\u202B\u200D\u206B\u206A\u200E\u200F\u200F\u206D\u200F\u206D\u200E\u202C\u206D\u200F\u200F\u200B\u200D\u200F\u206A\u200D\u202E\u206D\u202D\u202B\u202E\u206A\u202E\u200F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreRipplesof495YearsSeDef))]
		public sealed class FlandreRipplesof495YearsSe : StatusEffect
		{
			protected override void OnAdded(Unit unit)
			{
				FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<>c__DisplayClass1_0 CS$<>8__locals1 = new FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<>c__DisplayClass1_0();
				for (;;)
				{
					IL_0006:
					int num = 157323315;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(num2 * 1951574177))) % 9U)
						{
						case 0U:
							this.React(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202B\u202D\u200C\u202C\u200D\u200D\u202E\u206C\u202D\u202B\u206D\u200B\u206E\u206D\u202C\u200F\u206D\u206A\u206F\u206A\u206E\u206F\u206D\u202B\u206A\u206C\u202E\u202B\u206A\u200D\u206C\u202A\u200F\u200F\u206E\u200F\u200F\u206C\u206A\u200E\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u200B\u202B\u206A\u202E\u206A\u202E\u206E\u200B\u206D\u206F\u206E\u200D\u202D\u200B\u206A\u200F\u200B\u202E\u202E\u202B\u202E\u206D\u206B\u200C\u202E\u206E\u202A\u206A\u200E\u202A\u206A\u202B\u206F\u206C\u206D\u202A\u200D\u206F\u206F\u200D\u202E(CS$<>8__locals1.flandre, 0f)));
							FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202B\u200E\u206E\u200E\u200D\u206B\u206C\u206C\u206A\u206C\u200B\u206B\u200C\u200C\u200B\u200E\u206E\u202E\u206F\u202A\u200B\u206C\u200B\u200C\u206E\u206B\u202E\u200D\u206E\u200F\u200B\u200E\u202A\u206B\u206C\u202C\u202D\u200C\u200D\u202A\u202E(Singleton<GameMaster>.Instance, CS$<>8__locals1.<OnAdded>g__coroutine|0());
							num = (int)((num3 * 3322199348U) ^ 3760212278U);
							continue;
						case 1U:
							CS$<>8__locals1.<>4__this = this;
							num = (int)((num3 * 3984792508U) ^ 2084526250U);
							continue;
						case 2U:
							base.HandleOwnerEvent<ManaEventArgs>(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202B\u206E\u206D\u202C\u200D\u206F\u200B\u206D\u202D\u202A\u200F\u200C\u206E\u200B\u206A\u200C\u206E\u202C\u202E\u200F\u206C\u202E\u202D\u206F\u200E\u206D\u202C\u206B\u200D\u202D\u206A\u206A\u206A\u206B\u206D\u206B\u206A\u202A\u206B\u206F\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206C\u202B\u200B\u206E\u206A\u206C\u200E\u206D\u202C\u200D\u202B\u200B\u202C\u200F\u202E\u206A\u206E\u202A\u206F\u202E\u202D\u206D\u206A\u202C\u206C\u200E\u206D\u206A\u206A\u200C\u200F\u202D\u206A\u206A\u202C\u202C\u200B\u200D\u202A\u202E(this)), new GameEventHandler<ManaEventArgs>(this.OnManaLosing));
							base.ReactOwnerEvent<StatusEffectApplyEventArgs>(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206A\u202A\u206B\u202A\u202D\u202A\u202B\u206A\u202A\u200C\u200D\u202C\u202A\u202D\u200D\u202D\u206D\u206B\u202D\u206E\u206F\u206E\u200B\u202A\u206F\u200E\u206D\u200F\u202D\u206F\u202D\u202A\u202D\u202E\u200C\u202C\u200B\u202C\u206F\u206C\u202E(CS$<>8__locals1.flandre), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnPlayerStatusEffectAdding));
							num = (int)((num3 * 331024158U) ^ 491979666U);
							continue;
						case 3U:
						{
							PlayerUnit playerUnit;
							CS$<>8__locals1.flandre = playerUnit as FlandrePlayerUnitDef.FlandrePlayerUnit;
							num = (int)(((CS$<>8__locals1.flandre == null) ? 2130972254U : 2105284282U) ^ (num3 * 376778308U));
							continue;
						}
						case 4U:
							FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202B\u200E\u206E\u200E\u200D\u206B\u206C\u206C\u206A\u206C\u200B\u206B\u200C\u200C\u200B\u200E\u206E\u202E\u206F\u202A\u200B\u206C\u200B\u200C\u206E\u206B\u202E\u200D\u206E\u200F\u200B\u200E\u202A\u206B\u206C\u202C\u202D\u200C\u200D\u202A\u202E(Singleton<GameMaster>.Instance, CS$<>8__locals1.<OnAdded>g__coroutine3|1());
							base.ReactOwnerEvent<CardUsingEventArgs>(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u200C\u200C\u202D\u200F\u200F\u206F\u202D\u206A\u206D\u206F\u200C\u200B\u202A\u206C\u200E\u206E\u206C\u202C\u200B\u200B\u200B\u200C\u206F\u202D\u200D\u202A\u206A\u202D\u206F\u202B\u200C\u200B\u202D\u200B\u206A\u200F\u202B\u202B\u206B\u206F\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206C\u202B\u200B\u206E\u206A\u206C\u200E\u206D\u202C\u200D\u202B\u200B\u202C\u200F\u202E\u206A\u206E\u202A\u206F\u202E\u202D\u206D\u206A\u202C\u206C\u200E\u206D\u206A\u206A\u200C\u200F\u202D\u206A\u206A\u202C\u202C\u200B\u200D\u202A\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
							num = (int)((num3 * 2611452269U) ^ 2142945197U);
							continue;
						case 5U:
						{
							PlayerUnit playerUnit = FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206E\u200B\u200C\u202A\u200F\u202A\u202A\u200C\u200D\u202D\u200B\u202A\u202A\u200F\u206E\u206A\u206D\u202C\u202E\u202E\u202D\u200B\u206A\u202A\u202A\u202C\u202B\u206F\u200F\u206A\u206B\u200B\u202B\u202C\u206A\u206D\u202B\u206C\u200E\u200D\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206C\u202B\u200B\u206E\u206A\u206C\u200E\u206D\u202C\u200D\u202B\u200B\u202C\u200F\u202E\u206A\u206E\u202A\u206F\u202E\u202D\u206D\u206A\u202C\u206C\u200E\u206D\u206A\u206A\u200C\u200F\u202D\u206A\u206A\u202C\u202C\u200B\u200D\u202A\u202E(this));
							num = (int)((num3 * 3243471389U) ^ 2286517366U);
							continue;
						}
						case 6U:
							goto IL_0006;
						case 8U:
							base.HandleOwnerEvent<ManaEventArgs>(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u200F\u200B\u202C\u206F\u202D\u202C\u200B\u200C\u206D\u206F\u202D\u206D\u202A\u200F\u202A\u202A\u202D\u206C\u202C\u202D\u202D\u202E\u206A\u200F\u206B\u200C\u200B\u206F\u202D\u206C\u202C\u206C\u206B\u200E\u206D\u206C\u200B\u202E\u206D\u206F\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206C\u202B\u200B\u206E\u206A\u206C\u200E\u206D\u202C\u200D\u202B\u200B\u202C\u200F\u202E\u206A\u206E\u202A\u206F\u202E\u202D\u206D\u206A\u202C\u206C\u200E\u206D\u206A\u206A\u200C\u200F\u202D\u206A\u206A\u202C\u202C\u200B\u200D\u202A\u202E(this)), new GameEventHandler<ManaEventArgs>(this.OnManaGaining));
							num = (int)((num3 * 3509708574U) ^ 3477876112U);
							continue;
						}
						return;
					}
				}
			}

			protected override void OnRemoved(Unit unit)
			{
				FlandrePlayerUnitDef.FlandrePlayerUnit flandrePlayerUnit = FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206D\u206A\u206B\u200F\u206B\u202C\u206D\u202E\u206D\u202E\u200B\u200C\u206F\u202D\u206B\u206A\u202E\u206C\u202C\u202B\u200B\u206B\u200E\u200D\u202B\u200B\u206A\u202A\u206D\u206A\u200B\u200C\u200E\u206E\u202C\u206C\u202E\u206C\u202B\u202D\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206F\u200E\u206D\u206F\u206E\u200D\u200F\u206B\u206E\u200C\u200C\u202B\u200F\u206A\u206D\u206F\u206E\u206B\u206A\u206A\u202A\u202E\u200D\u206F\u200E\u200F\u202C\u200E\u200B\u206A\u206A\u200E\u202A\u206B\u202E\u200F\u202B\u200D\u202C\u206E\u202E(this)) as FlandrePlayerUnitDef.FlandrePlayerUnit;
				for (;;)
				{
					IL_0011:
					int num = -272716453;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(~(num2 - ~((1749354121 * 68097202) ^ -1457773495))) ^ -1678388778)) % 4U)
						{
						case 0U:
							goto IL_0011;
						case 1U:
							num = (int)(((flandrePlayerUnit == null) ? 1717200368U : 1899113745U) ^ (num3 * 1518851061U));
							continue;
						case 2U:
							flandrePlayerUnit.FlandreSpellCircle = false;
							flandrePlayerUnit.BossStationFinished = false;
							num = (int)((num3 * 656792395U) ^ 2005944743U);
							continue;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<OnCardUsed>d__3 <OnCardUsed>d__ = new FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<OnCardUsed>d__3(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			private void OnManaGaining(ManaEventArgs args)
			{
				if (FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u200D\u202A\u202B\u200B\u206B\u206F\u202D\u206F\u206B\u202C\u200C\u202E\u200C\u206E\u206B\u202B\u200F\u202D\u202A\u202D\u200C\u206F\u200D\u202D\u200D\u206D\u206F\u200C\u202A\u200C\u200C\u200E\u202D\u206B\u206E\u200F\u206A\u200D\u200E\u206D\u202E(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202A\u202B\u200C\u200B\u200C\u202A\u202A\u200F\u206D\u206F\u202C\u206F\u200C\u202E\u200D\u206D\u206A\u206A\u200F\u200C\u206A\u200C\u206D\u202A\u206B\u206A\u206F\u206F\u206F\u200B\u200F\u206A\u206A\u206F\u206B\u206E\u202E\u202A\u200B\u202A\u202E(args), 0) != ManaGroup.Empty)
				{
					for (;;)
					{
						IL_001B:
						int num = -549698036;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((~(num2 - 12295245 * ((2108869165 ^ -1328870727) - (-1701932390 ^ 1904900605))) - (-2006092421 + 651350819)) ^ 2067788440)) % 3U)
							{
							case 0U:
								goto IL_001B;
							case 2U:
								this.\u202E\u206E\u202E\u202A\u200E\u200D\u202D\u206A\u206F\u206E\u200F\u202C\u200E\u206E\u200B\u202B\u202A\u202C\u202B\u200E\u200B\u200E\u206F\u200C\u200F\u202D\u202D\u206E\u206E\u202E\u200E\u200C\u200C\u202A\u202A\u200E\u206E\u202E\u206B\u200C\u202E();
								FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206A\u206F\u206F\u206E\u200E\u206E\u206C\u206F\u200D\u202B\u206A\u202B\u200C\u202D\u202C\u206F\u202C\u202B\u200D\u206A\u206B\u206A\u200E\u206E\u206B\u202A\u200B\u200C\u200B\u200C\u200F\u206A\u202D\u206F\u206E\u200D\u202B\u200F\u200D\u202A\u202E(args, ManaGroup.Philosophies(FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202A\u202B\u200C\u200B\u200C\u202A\u202A\u200F\u206D\u206F\u202C\u206F\u200C\u202E\u200D\u206D\u206A\u206A\u200F\u200C\u206A\u200C\u206D\u202A\u206B\u206A\u206F\u206F\u206F\u200B\u200F\u206A\u206A\u206F\u206B\u206E\u202E\u202A\u200B\u202A\u202E(args).Amount));
								FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206A\u200D\u202C\u202C\u202E\u206A\u200E\u206B\u202C\u202E\u202B\u206C\u206D\u202A\u206A\u206B\u200B\u202C\u206F\u202A\u202B\u206F\u206D\u206A\u206A\u202B\u200D\u202E\u206E\u202A\u206B\u206C\u206E\u202A\u206A\u202C\u202B\u200E\u206D\u200C\u202E(args, this);
								num = (int)((num3 * 2230950815U) ^ 3388607380U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnManaLosing(ManaEventArgs args)
			{
				if (!FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u200B\u206A\u202B\u206F\u206E\u200F\u202B\u206F\u206C\u202D\u200F\u202A\u202E\u202A\u206D\u200C\u206F\u200E\u200B\u206D\u202B\u206E\u200E\u200C\u202A\u206D\u202E\u200B\u202B\u202C\u202D\u202C\u202B\u202E\u206B\u206B\u206F\u202C\u202C\u206B\u202E(args))
				{
					for (;;)
					{
						IL_000B:
						int num = 303887194;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-((-(-435160547 * 1356463461) ^ (1719084502 + -401959734 - -72476839 * 1478459355)) - num2) * -853646863) ^ -1016150618)) % 7U)
							{
							case 0U:
								this.\u202E\u206E\u202E\u202A\u200E\u200D\u202D\u206A\u206F\u206E\u200F\u202C\u200E\u206E\u200B\u202B\u202A\u202C\u202B\u200E\u200B\u200E\u206F\u200C\u200F\u202D\u202D\u206E\u206E\u202E\u200E\u200C\u200C\u202A\u202A\u200E\u206E\u202E\u206B\u200C\u202E();
								num = (int)((num3 * 1105399953U) ^ 3586027733U);
								continue;
							case 1U:
								num = (int)(((FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u206F\u202C\u202C\u202E\u202D\u206B\u206C\u202C\u202B\u200D\u200B\u202A\u206A\u206D\u206D\u202A\u200F\u200E\u200E\u202B\u200E\u200D\u206D\u202B\u206E\u200C\u202D\u206F\u200E\u202D\u200E\u200F\u200E\u206F\u202E\u202B\u202A\u206B\u202C\u200E\u202E(args) != ActionCause.TurnEnd) ? 3686348682U : 284825815U) ^ (num3 * 2833859188U));
								continue;
							case 2U:
							{
								ManaGroup manaGroup = FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202A\u202B\u200C\u200B\u200C\u202A\u202A\u200F\u206D\u206F\u202C\u206F\u200C\u202E\u200D\u206D\u206A\u206A\u200F\u200C\u206A\u200C\u206D\u202A\u206B\u206A\u206F\u206F\u206F\u200B\u200F\u206A\u206A\u206F\u206B\u206E\u202E\u202A\u200B\u202A\u202E(args);
								num = (int)((num3 * 2758308617U) ^ 1678687861U);
								continue;
							}
							case 3U:
								goto IL_000B;
							case 4U:
							{
								ManaGroup manaGroup;
								num = (int)((manaGroup.IsEmpty ? 4048952656U : 2081322353U) ^ (num3 * 1738970929U));
								continue;
							}
							case 5U:
								FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.\u202C\u202B\u206D\u206D\u200D\u202E\u206F\u206A\u202E\u200F\u206E\u202E\u202C\u200C\u200D\u202C\u202E\u202A\u206F\u206D\u200C\u202B\u202D\u200D\u202A\u206E\u202D\u202B\u206B\u200C\u206A\u206B\u200B\u206F\u206E\u200C\u200D\u206C\u206A\u200D\u202E(args, this);
								num = (int)((num3 * 416224432U) ^ 1809586418U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> OnPlayerStatusEffectAdding(StatusEffectApplyEventArgs args)
			{
				FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<OnPlayerStatusEffectAdding>d__6 <OnPlayerStatusEffectAdding>d__ = new FlandreRipplesof495YearsSeDef.FlandreRipplesof495YearsSe.<OnPlayerStatusEffectAdding>d__6(-2);
				<OnPlayerStatusEffectAdding>d__.<>4__this = this;
				<OnPlayerStatusEffectAdding>d__.<>3__args = args;
				return <OnPlayerStatusEffectAdding>d__;
			}

			public override string UnitEffectName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(103491368);
				}
			}

			static BattleController \u206C\u202B\u200B\u206E\u206A\u206C\u200E\u206D\u202C\u200D\u202B\u200B\u202C\u200F\u202E\u206A\u206E\u202A\u206F\u202E\u202D\u206D\u206A\u202C\u206C\u200E\u206D\u206A\u206A\u200C\u200F\u202D\u206A\u206A\u202C\u202C\u200B\u200D\u202A\u202E(StatusEffect A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u206E\u200B\u200C\u202A\u200F\u202A\u202A\u200C\u200D\u202D\u200B\u202A\u202A\u200F\u206E\u206A\u206D\u202C\u202E\u202E\u202D\u200B\u206A\u202A\u202A\u202C\u202B\u206F\u200F\u206A\u206B\u200B\u202B\u202C\u206A\u206D\u202B\u206C\u200E\u200D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static RemoveAllNegativeStatusEffectAction \u200B\u202B\u206A\u202E\u206A\u202E\u206E\u200B\u206D\u206F\u206E\u200D\u202D\u200B\u206A\u200F\u200B\u202E\u202E\u202B\u202E\u206D\u206B\u200C\u202E\u206E\u202A\u206A\u200E\u202A\u206A\u202B\u206F\u206C\u206D\u202A\u200D\u206F\u206F\u200D\u202E(Unit A_0, float A_1)
			{
				return new RemoveAllNegativeStatusEffectAction(A_0, A_1);
			}

			static Reactor \u202B\u202D\u200C\u202C\u200D\u200D\u202E\u206C\u202D\u202B\u206D\u200B\u206E\u206D\u202C\u200F\u206D\u206A\u206F\u206A\u206E\u206F\u206D\u202B\u206A\u206C\u202E\u202B\u206A\u200D\u206C\u202A\u200F\u200F\u206E\u200F\u200F\u206C\u206A\u200E\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static Coroutine \u202B\u200E\u206E\u200E\u200D\u206B\u206C\u206C\u206A\u206C\u200B\u206B\u200C\u200C\u200B\u200E\u206E\u202E\u206F\u202A\u200B\u206C\u200B\u200C\u206E\u206B\u202E\u200D\u206E\u200F\u200B\u200E\u202A\u206B\u206C\u202C\u202D\u200C\u200D\u202A\u202E(MonoBehaviour A_0, IEnumerator A_1)
			{
				return A_0.StartCoroutine(A_1);
			}

			static GameEvent<CardUsingEventArgs> \u200C\u200C\u202D\u200F\u200F\u206F\u202D\u206A\u206D\u206F\u200C\u200B\u202A\u206C\u200E\u206E\u206C\u202C\u200B\u200B\u200B\u200C\u206F\u202D\u200D\u202A\u206A\u202D\u206F\u202B\u200C\u200B\u202D\u200B\u206A\u200F\u202B\u202B\u206B\u206F\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<ManaEventArgs> \u200F\u200B\u202C\u206F\u202D\u202C\u200B\u200C\u206D\u206F\u202D\u206D\u202A\u200F\u202A\u202A\u202D\u206C\u202C\u202D\u202D\u202E\u206A\u200F\u206B\u200C\u200B\u206F\u202D\u206C\u202C\u206C\u206B\u200E\u206D\u206C\u200B\u202E\u206D\u206F\u202E(BattleController A_0)
			{
				return A_0.ManaGaining;
			}

			static GameEvent<ManaEventArgs> \u202B\u206E\u206D\u202C\u200D\u206F\u200B\u206D\u202D\u202A\u200F\u200C\u206E\u200B\u206A\u200C\u206E\u202C\u202E\u200F\u206C\u202E\u202D\u206F\u200E\u206D\u202C\u206B\u200D\u202D\u206A\u206A\u206A\u206B\u206D\u206B\u206A\u202A\u206B\u206F\u202E(BattleController A_0)
			{
				return A_0.ManaLosing;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u206A\u202A\u206B\u202A\u202D\u202A\u202B\u206A\u202A\u200C\u200D\u202C\u202A\u202D\u200D\u202D\u206D\u206B\u202D\u206E\u206F\u206E\u200B\u202A\u206F\u200E\u206D\u200F\u202D\u206F\u202D\u202A\u202D\u202E\u200C\u202C\u200B\u202C\u206F\u206C\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdding;
			}

			static GameRunController \u206F\u200E\u206D\u206F\u206E\u200D\u200F\u206B\u206E\u200C\u200C\u202B\u200F\u206A\u206D\u206F\u206E\u206B\u206A\u206A\u202A\u202E\u200D\u206F\u200E\u200F\u202C\u200E\u200B\u206A\u206A\u200E\u202A\u206B\u202E\u200F\u202B\u200D\u202C\u206E\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static PlayerUnit \u206D\u206A\u206B\u200F\u206B\u202C\u206D\u202E\u206D\u202E\u200B\u200C\u206F\u202D\u206B\u206A\u202E\u206C\u202C\u202B\u200B\u206B\u200E\u200D\u202B\u200B\u206A\u202A\u206D\u206A\u200B\u200C\u200E\u206E\u202C\u206C\u202E\u206C\u202B\u202D\u202E(GameRunController A_0)
			{
				return A_0.Player;
			}

			static ManaGroup \u202A\u202B\u200C\u200B\u200C\u202A\u202A\u200F\u206D\u206F\u202C\u206F\u200C\u202E\u200D\u206D\u206A\u206A\u200F\u200C\u206A\u200C\u206D\u202A\u206B\u206A\u206F\u206F\u206F\u200B\u200F\u206A\u206A\u206F\u206B\u206E\u202E\u202A\u200B\u202A\u202E(ManaEventArgs A_0)
			{
				return A_0.Value;
			}

			static ManaGroup \u200D\u202A\u202B\u200B\u206B\u206F\u202D\u206F\u206B\u202C\u200C\u202E\u200C\u206E\u206B\u202B\u200F\u202D\u202A\u202D\u200C\u206F\u200D\u202D\u200D\u206D\u206F\u200C\u202A\u200C\u200C\u200E\u202D\u206B\u206E\u200F\u206A\u200D\u200E\u206D\u202E(ManaGroup A_0, int A_1)
			{
				return A_0.WithPhilosophy(A_1);
			}

			void \u202E\u206E\u202E\u202A\u200E\u200D\u202D\u206A\u206F\u206E\u200F\u202C\u200E\u206E\u200B\u202B\u202A\u202C\u202B\u200E\u200B\u200E\u206F\u200C\u200F\u202D\u202D\u206E\u206E\u202E\u200E\u200C\u200C\u202A\u202A\u200E\u206E\u202E\u206B\u200C\u202E()
			{
				base.NotifyActivating();
			}

			static void \u206A\u206F\u206F\u206E\u200E\u206E\u206C\u206F\u200D\u202B\u206A\u202B\u200C\u202D\u202C\u206F\u202C\u202B\u200D\u206A\u206B\u206A\u200E\u206E\u206B\u202A\u200B\u200C\u200B\u200C\u200F\u206A\u202D\u206F\u206E\u200D\u202B\u200F\u200D\u202A\u202E(ManaEventArgs A_0, ManaGroup A_1)
			{
				A_0.Value = A_1;
			}

			static void \u206A\u200D\u202C\u202C\u202E\u206A\u200E\u206B\u202C\u202E\u202B\u206C\u206D\u202A\u206A\u206B\u200B\u202C\u206F\u202A\u202B\u206F\u206D\u206A\u206A\u202B\u200D\u202E\u206E\u202A\u206B\u206C\u206E\u202A\u206A\u202C\u202B\u200E\u206D\u200C\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static bool \u200B\u206A\u202B\u206F\u206E\u200F\u202B\u206F\u206C\u202D\u200F\u202A\u202E\u202A\u206D\u200C\u206F\u200E\u200B\u206D\u202B\u206E\u200E\u200C\u202A\u206D\u202E\u200B\u202B\u202C\u202D\u202C\u202B\u202E\u206B\u206B\u206F\u202C\u202C\u206B\u202E(GameEventArgs A_0)
			{
				return A_0.IsCanceled;
			}

			static ActionCause \u206F\u202C\u202C\u202E\u202D\u206B\u206C\u202C\u202B\u200D\u200B\u202A\u206A\u206D\u206D\u202A\u200F\u200E\u200E\u202B\u200E\u200D\u206D\u202B\u206E\u200C\u202D\u206F\u200E\u202D\u200E\u200F\u200E\u206F\u202E\u202B\u202A\u206B\u202C\u200E\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			static void \u202C\u202B\u206D\u206D\u200D\u202E\u206F\u206A\u202E\u200F\u206E\u202E\u202C\u200C\u200D\u202C\u202E\u202A\u206F\u206D\u200C\u202B\u202D\u200D\u202A\u206E\u202D\u202B\u206B\u200C\u206A\u206B\u200B\u206F\u206E\u200C\u200D\u206C\u206A\u200D\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			private bool Activated;
		}
	}
}
