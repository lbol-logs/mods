using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Cards;
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;
using UnityEngine;

namespace AyaShameimaru.Exhibits
{
	public sealed class FlandreMagicalGirlContractDef : ExhibitTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1062283914);
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalGirlContractDef.\u202B\u200B\u200E\u200F\u202B\u200B\u200C\u202C\u202A\u202E\u202C\u200D\u202E\u200D\u206E\u202C\u200D\u200C\u206A\u200D\u200C\u206B\u202B\u200D\u200C\u202C\u200F\u200D\u200B\u206E\u206B\u206B\u206B\u206F\u200C\u206E\u200B\u206F\u206A\u206E\u202E(BepinexPlugin.exhibitLoc, this);
		}

		public override ExhibitSprites LoadSprite()
		{
			string folder;
			FlandreMagicalGirlContractDef <>4__this;
			for (;;)
			{
				IL_0006:
				int num = -1604368673;
				for (;;)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(uint)((num2 * -180113671 * 203596803) ^ --324017987))) % 3U)
					{
					case 0U:
						goto IL_0006;
					case 2U:
						<>4__this = this;
						folder = "";
						num = (int)((num3 * 1399215628U) ^ 2145096858U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ExhibitSprites exhibitSprites = FlandreMagicalGirlContractDef.\u202C\u200C\u202A\u202C\u202C\u206E\u206B\u202B\u206A\u202C\u206D\u206D\u200D\u206F\u200D\u202C\u206A\u206F\u200F\u202A\u202A\u202D\u206B\u202A\u202D\u202D\u202A\u206B\u206B\u200D\u206B\u202E\u202B\u202E\u206E\u206B\u206F\u206A\u206D\u202E\u202E();
			Func<string, Sprite> func = (string s) => FlandreMagicalGirlContractDef.<>c__DisplayClass2_0.\u206D\u202B\u206B\u206A\u202B\u206E\u206F\u206A\u206C\u206E\u200E\u200B\u200E\u202E\u206D\u200E\u200B\u200E\u202E\u202B\u202C\u202A\u206F\u206F\u200D\u202D\u206D\u202D\u206C\u200E\u200E\u202D\u202B\u200F\u206F\u202E\u202E\u206F\u200E\u200C\u202E(FlandreMagicalGirlContractDef.<>c__DisplayClass2_0.\u206B\u206B\u200C\u202B\u200B\u200F\u206A\u200D\u202C\u206D\u200F\u202A\u206E\u200C\u206B\u202E\u206B\u200E\u200B\u202D\u200E\u200B\u202C\u200B\u202A\u202B\u202C\u200D\u202E\u206B\u206E\u200F\u202B\u206E\u200F\u206B\u206D\u202D\u200D\u200C\u202E(folder, FlandreMagicalGirlContractDef.<>c__DisplayClass2_0.\u202B\u200F\u202A\u206E\u206C\u200E\u200F\u202A\u200D\u206F\u200F\u206C\u202B\u202E\u206C\u206E\u206B\u202E\u206D\u202D\u206C\u202B\u206C\u202D\u202B\u206E\u202B\u202A\u200B\u206F\u202C\u202D\u202B\u202E\u200B\u206E\u200B\u206B\u202C\u202E(<>4__this), s, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799)), BepinexPlugin.embeddedSource, null, 1, null);
			exhibitSprites.main = func("");
			return exhibitSprites;
		}

		public override ExhibitConfig MakeConfig()
		{
			return new ExhibitConfig(FlandreMagicalGirlContractDef.\u202D\u202D\u206D\u200F\u206C\u200E\u206C\u206A\u202A\u200D\u202B\u200B\u206B\u200B\u206D\u202A\u206F\u206F\u202B\u202E\u200E\u206E\u200C\u202C\u202D\u206F\u200F\u206C\u200D\u202A\u202C\u200D\u202B\u200D\u202D\u200B\u206E\u206D\u202C\u200C\u202E(BepinexPlugin.sequenceTable, FlandreMagicalGirlContractDef.\u200D\u202B\u202B\u200F\u206F\u200E\u202D\u200C\u206C\u206C\u202C\u206E\u202D\u206B\u206E\u200B\u202A\u206C\u200B\u200E\u202C\u200E\u206A\u202A\u206B\u202B\u206A\u202A\u206F\u200F\u200F\u206B\u202C\u206D\u200F\u206C\u206C\u202B\u200D\u202D\u202E(typeof(ExhibitConfig).TypeHandle)), "", 10, false, true, false, true, AppearanceType.Anywhere, "", ExhibitLosableType.CantLose, Rarity.Rare, null, null, null, null, null, null, 0, false, null, Keyword.Upgrade, new List<string>(), new List<string>());
		}

		static BatchLocalization \u202B\u200B\u200E\u200F\u202B\u200B\u200C\u202C\u202A\u202E\u202C\u200D\u202E\u200D\u206E\u202C\u200D\u200C\u206A\u200D\u200C\u206B\u202B\u200D\u200C\u202C\u200F\u200D\u200B\u206E\u206B\u206B\u206B\u206F\u200C\u206E\u200B\u206F\u206A\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static ExhibitSprites \u202C\u200C\u202A\u202C\u202C\u206E\u206B\u202B\u206A\u202C\u206D\u206D\u200D\u206F\u200D\u202C\u206A\u206F\u200F\u202A\u202A\u202D\u206B\u202A\u202D\u202D\u202A\u206B\u206B\u200D\u206B\u202E\u202B\u202E\u206E\u206B\u206F\u206A\u206D\u202E\u202E()
		{
			return new ExhibitSprites();
		}

		static Type \u200D\u202B\u202B\u200F\u206F\u200E\u202D\u200C\u206C\u206C\u202C\u206E\u202D\u206B\u206E\u200B\u202A\u206C\u200B\u200E\u202C\u200E\u206A\u202A\u206B\u202B\u206A\u202A\u206F\u200F\u200F\u206B\u202C\u206D\u200F\u206C\u206C\u202B\u200D\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202D\u202D\u206D\u200F\u206C\u200E\u206C\u206A\u202A\u200D\u202B\u200B\u206B\u200B\u206D\u202A\u206F\u206F\u202B\u202E\u200E\u206E\u200C\u202C\u202D\u206F\u200F\u206C\u200D\u202A\u202C\u200D\u202B\u200D\u202D\u200B\u206E\u206D\u202C\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalGirlContractDef))]
		[UsedImplicitly]
		[ExhibitInfo(WeighterType = typeof(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.FlandreMagicalGirlContractWeighter))]
		public sealed class FlandreMagicalGirlContract : Exhibit
		{
			protected override void OnEnterBattle()
			{
				base.ReactBattleEvent<CardsEventArgs>(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u206D\u206A\u202D\u206E\u200B\u206A\u200B\u200B\u206E\u206A\u200B\u202B\u206A\u200F\u202A\u200C\u206E\u202C\u200E\u202B\u206D\u206D\u200F\u200D\u206D\u202C\u206C\u200C\u206F\u200F\u202C\u202E\u206C\u202D\u200E\u202C\u206D\u200E\u200C\u200E\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
				for (;;)
				{
					IL_001D:
					int num = -954804387;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((((--1533640875 ^ (963707369 - -903772538)) + (910863669 + --665369141) - num2) ^ ~(1470923161 * -1521751790)) + (-907857233 ^ -40878374) - -100032207)) % 6U)
						{
						case 0U:
							goto IL_001D;
						case 1U:
							base.ReactBattleEvent<CardsAddingToDrawZoneEventArgs>(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200D\u202B\u206E\u200D\u202E\u206A\u200F\u206A\u202C\u206F\u206C\u202B\u200B\u202B\u200D\u202D\u202D\u200D\u206A\u202B\u202D\u206E\u200E\u206B\u206E\u200D\u206C\u202D\u206D\u206B\u206D\u200C\u202D\u200F\u202E\u206A\u202E\u206F\u200C\u206E\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this)), new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddedToDrawZone));
							num = (int)((num3 * 2171432108U) ^ 1376199752U);
							continue;
						case 2U:
							base.ReactBattleEvent<CardsEventArgs>(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u206C\u202D\u206A\u206C\u206E\u202D\u200B\u206F\u202E\u202A\u206D\u202E\u202D\u206E\u200E\u202C\u200E\u206D\u200B\u202C\u206F\u206E\u202A\u206C\u202C\u206C\u200D\u200D\u202D\u200C\u206F\u202D\u202D\u202D\u202E\u200C\u206B\u206A\u206A\u206F\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
							num = (int)((num3 * 2057227329U) ^ 3346430438U);
							continue;
						case 3U:
						{
							BattleController battleController = FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this);
							int num4 = FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u202B\u202E\u200F\u206B\u202E\u200D\u206E\u200D\u200D\u206E\u206D\u206E\u200B\u202B\u200B\u202A\u206A\u200C\u200D\u206C\u202D\u200E\u206A\u200C\u202D\u202B\u200F\u200D\u200B\u200F\u206A\u206D\u200D\u200E\u200E\u206C\u200D\u202B\u202E\u202B\u202E(battleController);
							FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200B\u200B\u200E\u206A\u202E\u200E\u200E\u206A\u200E\u202C\u200B\u202B\u202E\u200B\u200E\u202C\u200C\u206D\u200F\u202D\u206C\u200B\u206D\u200E\u202A\u206A\u206B\u202B\u202D\u206C\u206A\u206C\u206A\u200F\u206B\u206F\u202B\u202E\u206F\u200F\u202E(battleController, num4 + 1);
							num = (int)((num3 * 1956007033U) ^ 897322581U);
							continue;
						}
						case 4U:
							base.ReactBattleEvent<CardsEventArgs>(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u206B\u202B\u206A\u202B\u200E\u202E\u200E\u200C\u200E\u202A\u200C\u202D\u206B\u206F\u206C\u200B\u206B\u206D\u202E\u202D\u200C\u206A\u200B\u200B\u206E\u202E\u206A\u200F\u200C\u200E\u200D\u202B\u206F\u200E\u200B\u200D\u206F\u202C\u200C\u200C\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAdded));
							num = (int)((num3 * 2805028414U) ^ 3467037887U);
							continue;
						}
						return;
					}
				}
			}

			protected override void OnLeaveBattle()
			{
				BattleController battleController = FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(this);
				int num = FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u202B\u202E\u200F\u206B\u202E\u200D\u206E\u200D\u200D\u206E\u206D\u206E\u200B\u202B\u200B\u202A\u206A\u200C\u200D\u206C\u202D\u200E\u206A\u200C\u202D\u202B\u200F\u200D\u200B\u200F\u206A\u206D\u200D\u200E\u200E\u206C\u200D\u202B\u202E\u202B\u202E(battleController);
				FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u200B\u200B\u200E\u206A\u202E\u200E\u200E\u206A\u200E\u202C\u200B\u202B\u202E\u200B\u200E\u202C\u200C\u206D\u200F\u202D\u206C\u200B\u206D\u200E\u202A\u206A\u206B\u202B\u202D\u206C\u206A\u206C\u206A\u200F\u206B\u206F\u202B\u202E\u206F\u200F\u202E(battleController, num - 1);
			}

			private IEnumerable<BattleAction> OnCardsAdded(CardsEventArgs args)
			{
				FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.<OnCardsAdded>d__2 <OnCardsAdded>d__ = new FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.<OnCardsAdded>d__2(-2);
				<OnCardsAdded>d__.<>4__this = this;
				<OnCardsAdded>d__.<>3__args = args;
				return <OnCardsAdded>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddedToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.<OnCardsAddedToDrawZone>d__3 <OnCardsAddedToDrawZone>d__ = new FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.<OnCardsAddedToDrawZone>d__3(-2);
				<OnCardsAddedToDrawZone>d__.<>4__this = this;
				<OnCardsAddedToDrawZone>d__.<>3__args = args;
				return <OnCardsAddedToDrawZone>d__;
			}

			private BattleAction TakeEffect(IEnumerable<Card> cards)
			{
				List<Card> list = cards.Where((Card c) => FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.<>c.\u206F\u206B\u202E\u200D\u202B\u206C\u206B\u206F\u200F\u206F\u200F\u202B\u202E\u206B\u200D\u200E\u206B\u200C\u200E\u202E\u202A\u206F\u202C\u200B\u206C\u202E\u200D\u206B\u200C\u202D\u202E\u206C\u200F\u206E\u200B\u206D\u202D\u200B\u200E\u202B\u202E(c)).ToList<Card>();
				for (;;)
				{
					IL_002B:
					int num = -1340922909;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(-(uint)(~(uint)(num2 * -547330653))))) % 4U)
						{
						case 1U:
							num = (int)(((list.Count != 0) ? 1119194272U : 3426867199U) ^ (num3 * 2770027422U));
							continue;
						case 2U:
							goto IL_002B;
						case 3U:
							goto IL_0077;
						}
						goto Block_2;
					}
				}
				Block_2:
				goto IL_0088;
				IL_0077:
				return null;
				IL_0088:
				this.\u206C\u206D\u206C\u202E\u206C\u202B\u206A\u202E\u202D\u202E\u202B\u206D\u206F\u206C\u202D\u206D\u206E\u206C\u200B\u200D\u202C\u206C\u200C\u200E\u202D\u202A\u200B\u200E\u202C\u206B\u200E\u200D\u200D\u200C\u206D\u202C\u202D\u206C\u200E\u206C\u202E();
				return FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.\u202E\u206F\u200D\u206A\u200B\u202B\u206D\u206A\u202E\u200F\u200D\u206C\u206F\u200D\u200B\u206A\u202B\u206C\u200F\u200B\u206E\u202A\u202E\u200C\u202E\u200F\u200C\u202D\u206A\u200F\u206F\u206E\u206A\u202C\u200E\u206F\u202C\u202B\u206F\u206B\u202E(list);
			}

			static BattleController \u200F\u206A\u202E\u200F\u206E\u200B\u202D\u202D\u200F\u200C\u200D\u206C\u206B\u202C\u200D\u206A\u200B\u202A\u202C\u206B\u200B\u202C\u206E\u202C\u206A\u200E\u206C\u200D\u200F\u202E\u200B\u206A\u202E\u206F\u202B\u200B\u206D\u202A\u202A\u202A\u202E(Exhibit A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardsEventArgs> \u206D\u206A\u202D\u206E\u200B\u206A\u200B\u200B\u206E\u206A\u200B\u202B\u206A\u200F\u202A\u200C\u206E\u202C\u200E\u202B\u206D\u206D\u200F\u200D\u206D\u202C\u206C\u200C\u206F\u200F\u202C\u202E\u206C\u202D\u200E\u202C\u206D\u200E\u200C\u200E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206B\u202B\u206A\u202B\u200E\u202E\u200E\u200C\u200E\u202A\u200C\u202D\u206B\u206F\u206C\u200B\u206B\u206D\u202E\u202D\u200C\u206A\u200B\u200B\u206E\u202E\u206A\u200F\u200C\u200E\u200D\u202B\u206F\u200E\u200B\u200D\u206F\u202C\u200C\u200C\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToHand;
			}

			static GameEvent<CardsEventArgs> \u206C\u202D\u206A\u206C\u206E\u202D\u200B\u206F\u202E\u202A\u206D\u202E\u202D\u206E\u200E\u202C\u200E\u206D\u200B\u202C\u206F\u206E\u202A\u206C\u202C\u206C\u200D\u200D\u202D\u200C\u206F\u202D\u202D\u202D\u202E\u200C\u206B\u206A\u206A\u206F\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u200D\u202B\u206E\u200D\u202E\u206A\u200F\u206A\u202C\u206F\u206C\u202B\u200B\u202B\u200D\u202D\u202D\u200D\u206A\u202B\u202D\u206E\u200E\u206B\u206E\u200D\u206C\u202D\u206D\u206B\u206D\u200C\u202D\u200F\u202E\u206A\u202E\u206F\u200C\u206E\u202E(BattleController A_0)
			{
				return A_0.CardsAddedToDrawZone;
			}

			static int \u202B\u202E\u200F\u206B\u202E\u200D\u206E\u200D\u200D\u206E\u206D\u206E\u200B\u202B\u200B\u202A\u206A\u200C\u200D\u206C\u202D\u200E\u206A\u200C\u202D\u202B\u200F\u200D\u200B\u200F\u206A\u206D\u200D\u200E\u200E\u206C\u200D\u202B\u202E\u202B\u202E(BattleController A_0)
			{
				return A_0.UpgradeTempCardsLevel;
			}

			static void \u200B\u200B\u200E\u206A\u202E\u200E\u200E\u206A\u200E\u202C\u200B\u202B\u202E\u200B\u200E\u202C\u200C\u206D\u200F\u202D\u206C\u200B\u206D\u200E\u202A\u206A\u206B\u202B\u202D\u206C\u206A\u206C\u206A\u200F\u206B\u206F\u202B\u202E\u206F\u200F\u202E(BattleController A_0, int A_1)
			{
				A_0.UpgradeTempCardsLevel = A_1;
			}

			void \u206C\u206D\u206C\u202E\u206C\u202B\u206A\u202E\u202D\u202E\u202B\u206D\u206F\u206C\u202D\u206D\u206E\u206C\u200B\u200D\u202C\u206C\u200C\u200E\u202D\u202A\u200B\u200E\u202C\u206B\u200E\u200D\u200D\u200C\u206D\u202C\u202D\u206C\u200E\u206C\u202E()
			{
				base.NotifyActivating();
			}

			static UpgradeCardsAction \u202E\u206F\u200D\u206A\u200B\u202B\u206D\u206A\u202E\u200F\u200D\u206C\u206F\u200D\u200B\u206A\u202B\u206C\u200F\u200B\u206E\u202A\u202E\u200C\u202E\u200F\u200C\u202D\u206A\u200F\u206F\u206E\u206A\u202C\u200E\u206F\u202C\u202B\u206F\u206B\u202E(IEnumerable<Card> A_0)
			{
				return new UpgradeCardsAction(A_0);
			}

			private class FlandreMagicalGirlContractWeighter : IExhibitWeighter
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				public float WeightFor(Type type, GameRunController gameRun)
				{
					if (!FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.FlandreMagicalGirlContractWeighter.\u206A\u200C\u206E\u206B\u206E\u202C\u206C\u206B\u206D\u206F\u206B\u202D\u206B\u200E\u206D\u202C\u206D\u206F\u202C\u200E\u200F\u202A\u200E\u200C\u206F\u206D\u202C\u200F\u200E\u206D\u200C\u202D\u202C\u202D\u200F\u200D\u200E\u200D\u202D\u206A\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.FlandreMagicalGirlContractWeighter.\u200C\u202D\u200D\u206D\u200F\u206D\u206D\u206C\u200D\u206B\u206B\u206C\u200C\u200B\u202A\u200B\u202C\u200F\u202A\u202C\u200F\u200C\u206C\u206D\u206D\u202E\u200B\u202D\u206E\u206F\u200F\u206B\u202B\u202E\u202D\u200E\u200B\u200C\u206E\u202E\u202E(FlandreMagicalGirlContractDef.FlandreMagicalGirlContract.FlandreMagicalGirlContractWeighter.\u200E\u202A\u202A\u200D\u200D\u206F\u200E\u202D\u206F\u200E\u200C\u206B\u206F\u202D\u206A\u200C\u200C\u202A\u200E\u200B\u200C\u206E\u202E\u202C\u202A\u200C\u200B\u206D\u202A\u200D\u202E\u206B\u202B\u206E\u202D\u202C\u200B\u200F\u202A\u206F\u202E(gameRun)), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733)))
					{
						for (;;)
						{
							int num = 563939103;
							switch (-(~num * 1108921537) % 3)
							{
							case 0:
								continue;
							case 1:
								goto IL_0044;
							}
							break;
						}
						goto IL_0059;
						IL_0044:
						return 0f;
					}
					IL_0059:
					return 1.15f;
				}

				static PlayerUnit \u200E\u202A\u202A\u200D\u200D\u206F\u200E\u202D\u206F\u200E\u200C\u206B\u206F\u202D\u206A\u200C\u200C\u202A\u200E\u200B\u200C\u206E\u202E\u202C\u202A\u200C\u200B\u206D\u202A\u200D\u202E\u206B\u202B\u206E\u202D\u202C\u200B\u200F\u202A\u206F\u202E(GameRunController A_0)
				{
					return A_0.Player;
				}

				static string \u200C\u202D\u200D\u206D\u200F\u206D\u206D\u206C\u200D\u206B\u206B\u206C\u200C\u200B\u202A\u200B\u202C\u200F\u202A\u202C\u200F\u200C\u206C\u206D\u206D\u202E\u200B\u202D\u206E\u206F\u200F\u206B\u202B\u202E\u202D\u200E\u200B\u200C\u206E\u202E\u202E(GameEntity A_0)
				{
					return A_0.Id;
				}

				static bool \u206A\u200C\u206E\u206B\u206E\u202C\u206C\u206B\u206D\u206F\u206B\u202D\u206B\u200E\u206D\u202C\u206D\u206F\u202C\u200E\u200F\u202A\u200E\u200C\u206F\u206D\u202C\u200F\u200E\u206D\u200C\u202D\u202C\u202D\u200F\u200D\u200E\u200D\u202D\u206A\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
