using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreMagicalPotentialDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-406371003);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMagicalPotentialDef.\u206B\u202C\u206E\u206E\u200F\u206F\u206B\u206D\u206C\u206E\u206E\u202A\u202E\u200D\u206F\u206B\u202B\u200E\u206A\u202A\u200C\u206A\u200B\u206A\u206B\u200B\u200F\u206F\u200B\u202B\u200B\u206C\u206A\u202B\u202E\u202A\u200C\u206C\u202C\u202C\u202E(BepinexPlugin.embeddedSource);
			FlandreMagicalPotentialDef.\u206E\u206B\u206E\u206B\u202C\u200C\u202E\u202A\u206B\u200B\u202B\u200E\u200D\u200B\u206F\u200D\u202C\u206D\u206F\u202D\u206A\u206A\u202A\u200D\u206D\u206A\u200C\u206C\u200B\u200C\u202A\u202B\u206E\u206A\u200C\u202B\u202E\u206D\u202C\u206D\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalPotentialDef.\u202A\u200F\u206E\u202B\u200B\u200F\u200C\u202B\u206C\u202D\u202C\u202E\u206F\u202D\u200E\u200F\u202B\u206F\u206B\u200D\u200E\u206F\u202C\u202C\u200C\u202B\u202A\u206E\u202E\u200C\u200B\u200E\u206E\u202D\u200D\u202C\u200B\u206F\u202C\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreMagicalPotentialDef.\u202E\u200E\u200D\u206E\u206D\u202D\u206E\u200F\u200E\u202E\u202A\u202B\u200D\u202B\u206D\u202C\u206F\u202E\u202E\u206E\u200E\u200B\u200C\u202C\u202A\u202B\u206E\u202E\u206D\u200C\u206A\u206E\u202D\u202B\u200B\u202D\u200E\u202A\u200B\u206C\u202E(BepinexPlugin.sequenceTable, FlandreMagicalPotentialDef.\u202D\u202B\u202E\u202E\u206C\u200B\u206F\u200E\u206B\u206F\u206D\u200F\u200B\u200B\u200C\u200D\u206C\u200D\u206F\u206C\u202C\u200D\u202C\u206E\u200D\u200B\u202B\u206A\u200D\u206A\u202D\u206D\u200E\u206A\u206A\u202D\u202D\u206E\u202E\u200D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, false, true, false, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden | Keyword.Retain, Keyword.Forbidden | Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(331168468), new List<string>());
		}

		static CardImages \u206B\u202C\u206E\u206E\u200F\u206F\u206B\u206D\u206C\u206E\u206E\u202A\u202E\u200D\u206F\u206B\u202B\u200E\u206A\u202A\u200C\u206A\u200B\u206A\u206B\u200B\u200F\u206F\u200B\u202B\u200B\u206C\u206A\u202B\u202E\u202A\u200C\u206C\u202C\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206E\u206B\u206E\u206B\u202C\u200C\u202E\u202A\u206B\u200B\u202B\u200E\u200D\u200B\u206F\u200D\u202C\u206D\u206F\u202D\u206A\u206A\u202A\u200D\u206D\u206A\u200C\u206C\u200B\u200C\u202A\u202B\u206E\u206A\u200C\u202B\u202E\u206D\u202C\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u200F\u206E\u202B\u200B\u200F\u200C\u202B\u206C\u202D\u202C\u202E\u206F\u202D\u200E\u200F\u202B\u206F\u206B\u200D\u200E\u206F\u202C\u202C\u200C\u202B\u202A\u206E\u202E\u200C\u200B\u200E\u206E\u202D\u200D\u202C\u200B\u206F\u202C\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202D\u202B\u202E\u202E\u206C\u200B\u206F\u200E\u206B\u206F\u206D\u200F\u200B\u200B\u200C\u200D\u206C\u200D\u206F\u206C\u202C\u200D\u202C\u206E\u200D\u200B\u202B\u206A\u200D\u206A\u202D\u206D\u200E\u206A\u206A\u202D\u202D\u206E\u202E\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202E\u200E\u200D\u206E\u206D\u202D\u206E\u200F\u200E\u202E\u202A\u202B\u200D\u202B\u206D\u202C\u206F\u202E\u202E\u206E\u200E\u200B\u200C\u202C\u202A\u202B\u206E\u202E\u206D\u200C\u206A\u206E\u202D\u202B\u200B\u202D\u200E\u202A\u200B\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalPotentialDef))]
		public sealed class FlandreMagicalPotential : FlandreCard
		{
			public int Order
			{
				get
				{
					return 4;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -1408162452;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-num2 - ~(-785228629 * -1635271901))) % 3U)
						{
						case 1U:
							base.IsMagicalGirl = true;
							num = (int)((num3 * 729695740U) ^ 4237471658U);
							continue;
						case 2U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.HandleBattleEvent<CardMovingEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u200D\u200B\u200E\u202C\u206B\u206D\u206E\u202B\u200D\u206C\u202E\u202B\u202E\u206F\u206A\u206E\u200D\u202B\u200F\u206F\u200D\u202D\u200E\u206D\u206A\u206F\u202E\u206E\u200C\u202C\u206A\u206B\u200D\u202B\u206F\u200E\u200D\u206F\u202C\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardMovingEventArgs>(this.OnCardMoving), (GameEventPriority)0);
				for (;;)
				{
					IL_001E:
					int num = 1252721218;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-(num2 ^ ~((1366051515 ^ -1271266943) + (1899545197 - -121120456)))) - 2011594188)) % 5U)
						{
						case 0U:
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u200D\u202B\u202D\u206C\u206A\u206A\u200B\u202D\u200C\u206F\u200F\u200E\u206F\u200E\u200D\u202C\u206F\u202B\u200D\u202C\u202B\u206E\u202B\u200C\u200F\u200E\u202D\u202C\u200D\u206E\u202D\u206D\u206B\u200D\u206B\u202C\u200C\u200C\u200D\u200E\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u200D\u202D\u202C\u206B\u202C\u200B\u202D\u202D\u206B\u200F\u202B\u202D\u200D\u206E\u200F\u202C\u200D\u206C\u206D\u206B\u202B\u200B\u202C\u202A\u202E\u202C\u202B\u206A\u202C\u202A\u200F\u200E\u206C\u200D\u206C\u206D\u200C\u206B\u202E\u200C\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							num = (int)((num3 * 123575731U) ^ 1651819088U);
							continue;
						case 1U:
							base.HandleBattleEvent<CardMovingToDrawZoneEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u202A\u202A\u200F\u206E\u200C\u200D\u206E\u202D\u202B\u206F\u200D\u206E\u200C\u202C\u200B\u206A\u206A\u206D\u202A\u202C\u200E\u206C\u206D\u202D\u202A\u206E\u202B\u202C\u202A\u202C\u200E\u200B\u202C\u206F\u206B\u206C\u202B\u200C\u206D\u206F\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone), (GameEventPriority)0);
							num = (int)((num3 * 1542724835U) ^ 785596678U);
							continue;
						case 2U:
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206B\u202D\u206D\u200B\u202C\u200C\u200C\u206B\u206A\u200E\u200E\u200F\u202E\u206C\u206E\u202A\u200B\u200D\u202B\u200C\u202D\u200F\u206B\u202D\u202C\u206B\u206F\u200D\u206C\u206F\u206C\u202C\u202A\u206E\u206E\u200C\u206A\u202B\u202B\u200E\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							num = (int)((num3 * 559679403U) ^ 354504470U);
							continue;
						case 4U:
							goto IL_001E;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.HandleBattleEvent<CardTransformEventArgs>(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u200C\u202C\u200B\u200F\u206E\u206F\u200D\u200C\u202B\u202D\u200F\u206C\u200C\u206C\u200B\u206C\u202E\u200B\u200F\u202A\u202C\u200B\u202A\u200F\u200C\u202B\u202B\u202C\u200D\u200B\u200D\u202A\u202B\u206B\u200D\u206E\u206A\u202B\u200C\u202A\u202E(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransforming), (GameEventPriority)0);
			}

			private void OnCardMoving(CardMovingEventArgs args)
			{
				if (FlandreMagicalPotentialDef.FlandreMagicalPotential.\u202A\u200B\u200C\u202E\u202B\u206B\u202E\u200E\u200C\u206F\u200C\u200D\u206B\u206C\u206C\u202C\u206B\u200B\u206A\u206B\u202D\u200F\u202D\u200B\u200D\u202E\u200B\u202C\u206A\u200B\u206C\u202B\u206A\u202A\u200F\u206D\u206B\u206C\u200C\u206E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -710598353;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(~num2) ^ ~-585541421))) % 6U)
							{
							case 1U:
								num = (int)(((!(FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 4002707596U : 3755566331U) ^ (num3 * 793530435U));
								continue;
							case 2U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206E\u200E\u206C\u200F\u202B\u200E\u206E\u200D\u206D\u206A\u202C\u206D\u206C\u200C\u206A\u200F\u206E\u206C\u200D\u206F\u202A\u206C\u202C\u202D\u202B\u202B\u202B\u202C\u206C\u206D\u202C\u202C\u200F\u206A\u206A\u200F\u200D\u206E\u206A\u202A\u202E(args, true);
								num = (int)((num3 * 3138765837U) ^ 3742462891U);
								continue;
							case 3U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u202B\u202E\u206D\u206E\u206F\u200C\u200E\u200E\u202A\u206B\u200C\u202B\u206E\u206A\u202E\u206B\u200B\u206D\u200F\u206C\u202C\u200D\u202D\u202E\u200F\u206B\u202C\u206B\u206B\u202B\u202B\u206D\u202D\u200C\u206B\u202B\u202C\u206C\u200F\u202E(args, this);
								num = (int)((num3 * 3713424924U) ^ 1418561454U);
								continue;
							case 4U:
								goto IL_000C;
							case 5U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) == this) ? 1316104491U : 1933272417U) ^ (num3 * 3463606261U));
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnCardMovingToDrawZone(CardMovingToDrawZoneEventArgs args)
			{
				if (FlandreMagicalPotentialDef.FlandreMagicalPotential.\u202D\u202A\u202C\u200D\u206F\u206E\u200F\u200D\u202D\u202D\u202A\u200B\u202D\u200F\u200F\u202B\u202E\u206A\u202B\u202A\u202D\u200D\u200E\u200C\u206B\u200F\u206E\u202A\u206B\u206D\u206C\u202C\u202D\u202B\u200E\u200B\u200C\u202A\u202E\u206A\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 396819419;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(-(num2 * 1184467353)) * -52390835)) % 5U)
							{
							case 0U:
								goto IL_000C;
							case 1U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2168083955U : 10558330U) ^ (num3 * 279905249U));
								continue;
							case 2U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206E\u200E\u206C\u200F\u202B\u200E\u206E\u200D\u206D\u206A\u202C\u206D\u206C\u200C\u206A\u200F\u206E\u206C\u200D\u206F\u202A\u206C\u202C\u202D\u202B\u202B\u202B\u202C\u206C\u206D\u202C\u202C\u200F\u206A\u206A\u200F\u200D\u206E\u206A\u202A\u202E(args, true);
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u202B\u202E\u206D\u206E\u206F\u200C\u200E\u200E\u202A\u206B\u200C\u202B\u206E\u206A\u202E\u206B\u200B\u206D\u200F\u206C\u202C\u200D\u202D\u202E\u200F\u206B\u202C\u206B\u206B\u202B\u202B\u206D\u202D\u200C\u206B\u202B\u202C\u206C\u200F\u202E(args, this);
								num = (int)((num3 * 2761170738U) ^ 1274629311U);
								continue;
							case 4U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) != this) ? 1469473955U : 3444219370U) ^ (num3 * 1932548369U));
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnCardLeaving(CardEventArgs args)
			{
				if (FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206E\u206F\u200E\u206C\u202E\u206A\u206F\u200B\u202D\u206F\u200E\u206B\u206C\u202B\u206B\u206D\u202B\u206A\u200E\u206C\u206F\u206D\u206C\u206C\u202D\u206B\u202E\u206C\u202A\u202B\u200B\u206A\u200D\u202C\u200F\u202E\u202C\u202B\u200F\u200F\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -2007528220;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(num2 ^ (442171809 * 1620404302)))) % 6U)
							{
							case 0U:
								goto IL_000C;
							case 1U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) != this) ? 569575011U : 1792377035U) ^ (num3 * 2171614312U));
								continue;
							case 2U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206E\u200E\u206C\u200F\u202B\u200E\u206E\u200D\u206D\u206A\u202C\u206D\u206C\u200C\u206A\u200F\u206E\u206C\u200D\u206F\u202A\u206C\u202C\u202D\u202B\u202B\u202B\u202C\u206C\u206D\u202C\u202C\u200F\u206A\u206A\u200F\u200D\u206E\u206A\u202A\u202E(args, true);
								num = (int)((num3 * 27425976U) ^ 428473660U);
								continue;
							case 3U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2849443516U : 2281705965U) ^ (num3 * 4118919507U));
								continue;
							case 5U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u202B\u202E\u206D\u206E\u206F\u200C\u200E\u200E\u202A\u206B\u200C\u202B\u206E\u206A\u202E\u206B\u200B\u206D\u200F\u206C\u202C\u200D\u202D\u202E\u200F\u206B\u202C\u206B\u206B\u202B\u202B\u206D\u202D\u200C\u206B\u202B\u202C\u206C\u200F\u202E(args, this);
								num = (int)((num3 * 1291728191U) ^ 2167547184U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnCardTransforming(CardTransformEventArgs args)
			{
				if (FlandreMagicalPotentialDef.FlandreMagicalPotential.\u202B\u202B\u202E\u200C\u202B\u200D\u202D\u202D\u202B\u206C\u206B\u200B\u206D\u206E\u200C\u206A\u200C\u200F\u202E\u202A\u200E\u202A\u200E\u202C\u200C\u206B\u202B\u206B\u202E\u206B\u206D\u206C\u200C\u206A\u200C\u202D\u200F\u206E\u200E\u206A\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 1564203152;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(num2 ^ ((1315964445 + 173836498) * 1822345653 + (~-1990438615 + ~-1621859854)) ^ ~(1228804321 ^ -41184771)) * -113732463)) % 6U)
							{
							case 1U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) == this) ? 359080383U : 2474621732U) ^ (num3 * 463032557U));
								continue;
							case 2U:
								num = (int)(((FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 3934595030U : 4190222015U) ^ (num3 * 1875157283U));
								continue;
							case 3U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206E\u200E\u206C\u200F\u202B\u200E\u206E\u200D\u206D\u206A\u202C\u206D\u206C\u200C\u206A\u200F\u206E\u206C\u200D\u206F\u202A\u206C\u202C\u202D\u202B\u202B\u202B\u202C\u206C\u206D\u202C\u202C\u200F\u206A\u206A\u200F\u200D\u206E\u206A\u202A\u202E(args, true);
								num = (int)((num3 * 1168317709U) ^ 312078337U);
								continue;
							case 4U:
								FlandreMagicalPotentialDef.FlandreMagicalPotential.\u206D\u202B\u202E\u206D\u206E\u206F\u200C\u200E\u200E\u202A\u206B\u200C\u202B\u206E\u206A\u202E\u206B\u200B\u206D\u200F\u206C\u202C\u200D\u202D\u202E\u200F\u206B\u202C\u206B\u206B\u202B\u202B\u206D\u202D\u200C\u206B\u202B\u202C\u206C\u200F\u202E(args, this);
								num = (int)((num3 * 4157573171U) ^ 62422658U);
								continue;
							case 5U:
								goto IL_000C;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				return new FlandreMagicalPotentialDef.FlandreMagicalPotential.<Actions>d__8(-2);
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreMagicalPotentialDef.FlandreMagicalPotential.<AfterUseAction>d__9 <AfterUseAction>d__ = new FlandreMagicalPotentialDef.FlandreMagicalPotential.<AfterUseAction>d__9(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreMagicalPotentialDef.FlandreMagicalPotential.<AfterFollowPlayAction>d__10 <AfterFollowPlayAction>d__ = new FlandreMagicalPotentialDef.FlandreMagicalPotential.<AfterFollowPlayAction>d__10(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static BattleController \u206A\u202B\u200F\u202C\u200D\u206E\u202C\u200D\u202D\u200D\u202E\u200C\u206D\u202D\u202B\u202B\u200E\u200E\u206F\u200B\u202E\u200E\u202A\u206D\u200F\u206D\u202A\u202B\u206F\u206F\u200B\u206C\u200D\u200E\u200C\u206A\u200D\u200F\u202D\u200E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardMovingEventArgs> \u200D\u200B\u200E\u202C\u206B\u206D\u206E\u202B\u200D\u206C\u202E\u202B\u202E\u206F\u206A\u206E\u200D\u202B\u200F\u206F\u200D\u202D\u200E\u206D\u206A\u206F\u202E\u206E\u200C\u202C\u206A\u206B\u200D\u202B\u206F\u200E\u200D\u206F\u202C\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u202A\u202A\u200F\u206E\u200C\u200D\u206E\u202D\u202B\u206F\u200D\u206E\u200C\u202C\u200B\u206A\u206A\u206D\u202A\u202C\u200E\u206C\u206D\u202D\u202A\u206E\u202B\u202C\u202A\u202C\u200E\u200B\u202C\u206F\u206B\u206C\u202B\u200C\u206D\u206F\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u200D\u202B\u202D\u206C\u206A\u206A\u200B\u202D\u200C\u206F\u200F\u200E\u206F\u200E\u200D\u202C\u206F\u202B\u200D\u202C\u202B\u206E\u202B\u200C\u200F\u200E\u202D\u202C\u200D\u206E\u202D\u206D\u206B\u200D\u206B\u202C\u200C\u200C\u200D\u200E\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u200D\u202D\u202C\u206B\u202C\u200B\u202D\u202D\u206B\u200F\u202B\u202D\u200D\u206E\u200F\u202C\u200D\u206C\u206D\u206B\u202B\u200B\u202C\u202A\u202E\u202C\u202B\u206A\u202C\u202A\u200F\u200E\u206C\u200D\u206C\u206D\u200C\u206B\u202E\u200C\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u206B\u202D\u206D\u200B\u202C\u200C\u200C\u206B\u206A\u200E\u200E\u200F\u202E\u206C\u206E\u202A\u200B\u200D\u202B\u200C\u202D\u200F\u206B\u202D\u202C\u206B\u206F\u200D\u206C\u206F\u206C\u202C\u202A\u206E\u206E\u200C\u206A\u202B\u202B\u200E\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u200C\u202C\u200B\u200F\u206E\u206F\u200D\u200C\u202B\u202D\u200F\u206C\u200C\u206C\u200B\u206C\u202E\u200B\u200F\u202A\u202C\u200B\u202A\u200F\u200C\u202B\u202B\u202C\u200D\u200B\u200D\u202A\u202B\u206B\u200D\u206E\u206A\u202B\u200C\u202A\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static Card \u202A\u200B\u200C\u202E\u202B\u206B\u202E\u200E\u200C\u206F\u200C\u200D\u206B\u206C\u206C\u202C\u206B\u200B\u206A\u206B\u202D\u200F\u202D\u200B\u200D\u202E\u200B\u202C\u206A\u200B\u206C\u202B\u206A\u202A\u200F\u206D\u206B\u206C\u200C\u206E\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u206D\u200F\u202B\u206F\u200F\u200B\u200B\u200F\u206B\u202A\u200E\u200F\u202A\u206D\u200C\u200F\u202C\u202A\u200E\u206E\u200E\u206D\u200E\u206C\u200F\u202A\u206F\u206E\u200F\u200F\u200B\u202C\u200E\u200C\u202C\u200F\u200D\u200C\u200B\u200C\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u206E\u200E\u206C\u200F\u202B\u200E\u206E\u200D\u206D\u206A\u202C\u206D\u206C\u200C\u206A\u200F\u206E\u206C\u200D\u206F\u202A\u206C\u202C\u202D\u202B\u202B\u202B\u202C\u206C\u206D\u202C\u202C\u200F\u206A\u206A\u200F\u200D\u206E\u206A\u202A\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u206D\u202B\u202E\u206D\u206E\u206F\u200C\u200E\u200E\u202A\u206B\u200C\u202B\u206E\u206A\u202E\u206B\u200B\u206D\u200F\u206C\u202C\u200D\u202D\u202E\u200F\u206B\u202C\u206B\u206B\u202B\u202B\u206D\u202D\u200C\u206B\u202B\u202C\u206C\u200F\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static Card \u202D\u202A\u202C\u200D\u206F\u206E\u200F\u200D\u202D\u202D\u202A\u200B\u202D\u200F\u200F\u202B\u202E\u206A\u202B\u202A\u202D\u200D\u200E\u200C\u206B\u200F\u206E\u202A\u206B\u206D\u206C\u202C\u202D\u202B\u200E\u200B\u200C\u202A\u202E\u206A\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206E\u206F\u200E\u206C\u202E\u206A\u206F\u200B\u202D\u206F\u200E\u206B\u206C\u202B\u206B\u206D\u202B\u206A\u200E\u206C\u206F\u206D\u206C\u206C\u202D\u206B\u202E\u206C\u202A\u202B\u200B\u206A\u200D\u202C\u200F\u202E\u202C\u202B\u200F\u200F\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202B\u202B\u202E\u200C\u202B\u200D\u202D\u202D\u202B\u206C\u206B\u200B\u206D\u206E\u200C\u206A\u200C\u200F\u202E\u202A\u200E\u202A\u200E\u202C\u200C\u206B\u202B\u206B\u202E\u206B\u206D\u206C\u200C\u206A\u200C\u202D\u200F\u206E\u200E\u206A\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			IEnumerable<BattleAction> \u200F\u206F\u202A\u200F\u202C\u200C\u206E\u202B\u200B\u200E\u202E\u206D\u206B\u206C\u206F\u202A\u200D\u206D\u202D\u206B\u202A\u200E\u200D\u206E\u206B\u202B\u200C\u202D\u206A\u202B\u202D\u200B\u206A\u202D\u206E\u202A\u206F\u206B\u206F\u200D\u202E()
			{
				return base.AfterUseAction();
			}

			IEnumerable<BattleAction> \u202B\u200C\u202C\u200C\u200B\u206D\u202A\u200E\u206E\u206A\u206B\u206F\u202E\u202E\u202E\u200D\u202B\u206F\u200B\u200C\u200B\u200D\u206E\u206F\u202B\u206E\u206E\u206A\u200C\u200F\u202E\u202B\u202C\u206C\u200E\u200D\u200E\u206F\u200C\u206B\u202E()
			{
				return base.AfterFollowPlayAction();
			}
		}
	}
}
