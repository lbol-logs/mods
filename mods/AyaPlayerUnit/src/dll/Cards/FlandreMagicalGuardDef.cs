using System;
using System.Collections.Generic;
using System.Linq;
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
	public sealed class FlandreMagicalGuardDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-691020940);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMagicalGuardDef.\u200C\u206C\u202D\u202E\u202D\u200F\u202C\u200F\u200D\u206B\u206B\u200B\u202C\u202A\u200D\u200B\u202A\u202E\u206E\u200F\u206C\u200E\u206A\u206C\u200C\u200D\u202C\u202B\u206C\u200E\u202B\u202B\u200F\u200B\u206A\u202A\u202B\u202D\u202E\u202D\u202E(BepinexPlugin.embeddedSource);
			FlandreMagicalGuardDef.\u206A\u206A\u206B\u200F\u200D\u206D\u200D\u206A\u200B\u200E\u206B\u202E\u200B\u202A\u202B\u200D\u202C\u202C\u202C\u202B\u206B\u202A\u202E\u202D\u206A\u202B\u206B\u200B\u206B\u206D\u206E\u200E\u202C\u200E\u206D\u206E\u206E\u200C\u200B\u200E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalGuardDef.\u206D\u206E\u200E\u200B\u206A\u200E\u202A\u206E\u206A\u202A\u202A\u206B\u200C\u202A\u206C\u206C\u202B\u200F\u206A\u206C\u206B\u202D\u200C\u206C\u202D\u202B\u202A\u206F\u202C\u200E\u206F\u200B\u202D\u206C\u202E\u200D\u206A\u200C\u206B\u202A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreMagicalGuardDef.\u206D\u200E\u200D\u200F\u200E\u206D\u202B\u200E\u202B\u200D\u200F\u200B\u202C\u202D\u200C\u202E\u206B\u202A\u202B\u200F\u200C\u206F\u200F\u200E\u202B\u206B\u206E\u206A\u202C\u206B\u200D\u206C\u200F\u200E\u200C\u206D\u202E\u202D\u206E\u202D\u202E(BepinexPlugin.sequenceTable, FlandreMagicalGuardDef.\u202E\u206E\u206B\u200E\u200C\u202A\u206E\u206A\u206A\u206D\u206E\u202E\u202E\u206D\u200E\u202B\u200C\u200F\u202B\u202B\u206B\u200C\u202E\u200D\u206F\u206E\u202C\u202E\u200F\u200B\u202A\u200D\u200E\u206E\u206B\u202A\u202D\u200E\u200F\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, false, true, false, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, new int?(10), null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Retain, Keyword.Retain, false, Keyword.Block, Keyword.Block, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-523678837), new List<string>());
		}

		static CardImages \u200C\u206C\u202D\u202E\u202D\u200F\u202C\u200F\u200D\u206B\u206B\u200B\u202C\u202A\u200D\u200B\u202A\u202E\u206E\u200F\u206C\u200E\u206A\u206C\u200C\u200D\u202C\u202B\u206C\u200E\u202B\u202B\u200F\u200B\u206A\u202A\u202B\u202D\u202E\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206A\u206A\u206B\u200F\u200D\u206D\u200D\u206A\u200B\u200E\u206B\u202E\u200B\u202A\u202B\u200D\u202C\u202C\u202C\u202B\u206B\u202A\u202E\u202D\u206A\u202B\u206B\u200B\u206B\u206D\u206E\u200E\u202C\u200E\u206D\u206E\u206E\u200C\u200B\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u206E\u200E\u200B\u206A\u200E\u202A\u206E\u206A\u202A\u202A\u206B\u200C\u202A\u206C\u206C\u202B\u200F\u206A\u206C\u206B\u202D\u200C\u206C\u202D\u202B\u202A\u206F\u202C\u200E\u206F\u200B\u202D\u206C\u202E\u200D\u206A\u200C\u206B\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u206E\u206B\u200E\u200C\u202A\u206E\u206A\u206A\u206D\u206E\u202E\u202E\u206D\u200E\u202B\u200C\u200F\u202B\u202B\u206B\u200C\u202E\u200D\u206F\u206E\u202C\u202E\u200F\u200B\u202A\u200D\u200E\u206E\u206B\u202A\u202D\u200E\u200F\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u200E\u200D\u200F\u200E\u206D\u202B\u200E\u202B\u200D\u200F\u200B\u202C\u202D\u200C\u202E\u206B\u202A\u202B\u200F\u200C\u206F\u200F\u200E\u202B\u206B\u206E\u206A\u202C\u206B\u200D\u206C\u200F\u200E\u200C\u206D\u202E\u202D\u206E\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalGuardDef))]
		public sealed class FlandreMagicalGuard : FlandreCard
		{
			public int Order
			{
				get
				{
					return 2;
				}
			}

			public override int AdditionalBlock
			{
				get
				{
					return FlandreMagicalGuardDef.FlandreMagicalGuard.\u202C\u200D\u206A\u200C\u202E\u206B\u206F\u206B\u202C\u200B\u200F\u206D\u200E\u202E\u200B\u202E\u202A\u206C\u200D\u206D\u206C\u206B\u202A\u202C\u200E\u206F\u200F\u206C\u202A\u206C\u202A\u202B\u200F\u206A\u206C\u206A\u202D\u202A\u206A\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override ManaGroup AdditionalCost
			{
				get
				{
					ManaGroup manaGroup = FlandreMagicalGuardDef.FlandreMagicalGuard.\u200E\u206D\u202A\u206B\u206A\u200C\u200F\u206C\u206E\u200F\u206A\u200F\u200D\u200E\u202E\u202D\u202A\u200B\u202C\u200B\u202E\u206E\u202C\u206E\u200F\u200D\u206B\u200B\u206D\u206B\u200D\u200F\u200B\u200D\u200B\u200B\u202E\u200C\u206D\u206A\u202E(this);
					BattleController battleController = FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this);
					int? num;
					if (battleController == null)
					{
						num = null;
					}
					else
					{
						num = new int?(FlandreMagicalGuardDef.FlandreMagicalGuard.\u202C\u206B\u202C\u202D\u200B\u200B\u200E\u202A\u202C\u206D\u202D\u206B\u200E\u202D\u202A\u206D\u206A\u202E\u202A\u202A\u202E\u202D\u206F\u206B\u202A\u206B\u206F\u202C\u206C\u200B\u200E\u202C\u206A\u206F\u206A\u200B\u206C\u200F\u202A\u200C\u202E(battleController).Count((Card c) => c is FlandreMagicalGuardDef.FlandreMagicalGuard));
					}
					int? num2 = num;
					int valueOrDefault = num2.GetValueOrDefault();
					BattleController battleController2 = FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this);
					int? num3;
					if (battleController2 == null)
					{
						num3 = null;
					}
					else
					{
						num3 = new int?(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200E\u202A\u202E\u206D\u202A\u202E\u202A\u202B\u202A\u206B\u206F\u206B\u206D\u200B\u200B\u200C\u202B\u202D\u200F\u200B\u200E\u202B\u200C\u200B\u200F\u202D\u202C\u202A\u206B\u202A\u206C\u206B\u206F\u200C\u202A\u202D\u200D\u202D\u200F\u206F\u202E(battleController2).Count((Card c) => c is FlandreMagicalGuardDef.FlandreMagicalGuard));
					}
					num2 = num3;
					return manaGroup * (valueOrDefault + num2.GetValueOrDefault());
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsMagicalGirl = true;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.HandleBattleEvent<CardMovingEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u200C\u206C\u202E\u200C\u206A\u206E\u206C\u202B\u200C\u202B\u202D\u206C\u200C\u202B\u206C\u206A\u206E\u206E\u200C\u200F\u206D\u202B\u206B\u200D\u202D\u202A\u206F\u206A\u202C\u206A\u200B\u206A\u206F\u206B\u200E\u202A\u202C\u206F\u200D\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardMovingEventArgs>(this.OnCardMoving), (GameEventPriority)0);
				for (;;)
				{
					IL_001E:
					int num = 1374989176;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)(~(uint)(-(uint)(num2 ^ (((498221761 ^ -738201155) + -70644030) ^ 924945689)))))) % 6U)
						{
						case 0U:
							goto IL_001E;
						case 2U:
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200E\u200E\u202E\u200F\u200C\u206E\u206B\u202E\u206B\u206B\u200C\u206B\u200F\u206E\u200B\u206C\u206D\u206E\u206B\u202A\u202D\u200B\u202B\u206D\u202C\u200F\u202B\u206B\u200F\u206A\u200D\u200F\u202C\u206C\u202A\u206D\u206D\u200F\u206C\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							num = (int)((num3 * 595398532U) ^ 4008775371U);
							continue;
						case 3U:
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u206F\u202A\u200E\u206B\u206F\u200D\u200F\u200C\u202C\u206E\u200F\u200F\u200D\u206A\u200F\u206E\u200B\u206D\u206F\u206B\u202C\u202E\u202B\u202C\u206E\u202A\u206D\u206A\u200D\u200E\u200D\u202E\u206B\u206F\u206D\u206F\u202A\u202D\u202D\u206C\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							num = (int)((num3 * 1476267106U) ^ 2238780053U);
							continue;
						case 4U:
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u202E\u202A\u202A\u206D\u202B\u202A\u206C\u206B\u206C\u202A\u206B\u202C\u206B\u206D\u206D\u206C\u206E\u200E\u206C\u202A\u200E\u206D\u202D\u200D\u200C\u202D\u202C\u206D\u200C\u200D\u202B\u200F\u206F\u202D\u200D\u200B\u200B\u206A\u202E\u202D\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							base.HandleBattleEvent<CardTransformEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200C\u200E\u200D\u200D\u206C\u200F\u206E\u200E\u202B\u206A\u202D\u206B\u206A\u200C\u206E\u200D\u200E\u200F\u200C\u200C\u206D\u202D\u200C\u200F\u202E\u206F\u200B\u206A\u200F\u202E\u200D\u200C\u202C\u202D\u202E\u202A\u200E\u202B\u202B\u200F\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransforming), (GameEventPriority)0);
							num = (int)((num3 * 4040898290U) ^ 2865868090U);
							continue;
						case 5U:
							base.HandleBattleEvent<CardMovingToDrawZoneEventArgs>(FlandreMagicalGuardDef.FlandreMagicalGuard.\u202B\u200B\u202B\u202C\u202E\u202D\u202B\u206C\u206F\u200B\u206E\u202C\u202D\u200C\u202A\u202E\u206D\u200E\u206E\u200F\u202D\u200D\u202C\u202E\u206A\u200B\u202C\u206E\u202A\u206C\u202D\u202D\u202E\u206A\u206E\u206C\u200D\u206F\u202E\u206E\u202E(FlandreMagicalGuardDef.FlandreMagicalGuard.\u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(this)), new GameEventHandler<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone), (GameEventPriority)0);
							num = (int)((num3 * 3455800440U) ^ 1293009474U);
							continue;
						}
						return;
					}
				}
			}

			private void OnCardMoving(CardMovingEventArgs args)
			{
				if (FlandreMagicalGuardDef.FlandreMagicalGuard.\u206C\u206A\u206A\u200D\u206D\u200F\u200B\u206E\u202C\u206F\u202B\u202E\u202A\u202D\u200D\u200B\u202C\u202C\u202B\u206C\u206A\u206D\u200F\u206B\u206F\u202B\u200E\u202B\u206C\u200B\u206B\u206E\u200E\u200F\u200F\u206C\u206C\u206B\u200C\u206E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 1260016885;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~((num2 * 1462824003) ^ -(--2103513023)) ^ 1816199238)) % 6U)
							{
							case 0U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u206B\u206C\u206E\u200C\u202D\u206C\u202A\u202B\u206E\u202E\u206B\u202E\u206B\u202D\u202A\u202D\u200D\u206C\u200D\u206B\u206D\u206C\u202A\u200D\u202C\u202A\u200E\u202D\u200C\u200F\u206D\u200D\u200F\u200D\u206D\u202E\u202D\u206B\u200C\u202E(args, true);
								num = (int)((num3 * 2711402849U) ^ 2027234667U);
								continue;
							case 1U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 4287228033U : 4125886522U) ^ (num3 * 2818568250U));
								continue;
							case 2U:
								goto IL_000C;
							case 4U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) != this) ? 4266954482U : 3601745679U) ^ (num3 * 1571843818U));
								continue;
							case 5U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u202D\u202A\u200F\u206B\u206C\u202B\u206C\u202B\u206D\u206C\u206E\u200B\u206E\u206E\u202C\u206D\u202E\u200C\u206D\u202A\u200E\u202B\u202B\u200D\u202D\u200B\u200E\u200F\u206C\u202C\u202D\u202A\u200E\u202E\u206E\u200E\u206B\u202D\u206E\u202E(args, this);
								num = (int)((num3 * 3220656669U) ^ 57025780U);
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
				if (FlandreMagicalGuardDef.FlandreMagicalGuard.\u206F\u200E\u202B\u200E\u202D\u206F\u206E\u200E\u202D\u206F\u206C\u200C\u202D\u206F\u200E\u206D\u202D\u206D\u202A\u206F\u200B\u202B\u206E\u206B\u206B\u202C\u200F\u200F\u202D\u200C\u206E\u200D\u200F\u200B\u206B\u206B\u200E\u206D\u200F\u202E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -2140216414;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-1338659989 - ((num2 ^ (-(~1873812044) * -531941259)) * -1090557843 - 230231242))) % 5U)
							{
							case 1U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u206B\u206C\u206E\u200C\u202D\u206C\u202A\u202B\u206E\u202E\u206B\u202E\u206B\u202D\u202A\u202D\u200D\u206C\u200D\u206B\u206D\u206C\u202A\u200D\u202C\u202A\u200E\u202D\u200C\u200F\u206D\u200D\u200F\u200D\u206D\u202E\u202D\u206B\u200C\u202E(args, true);
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u202D\u202A\u200F\u206B\u206C\u202B\u206C\u202B\u206D\u206C\u206E\u200B\u206E\u206E\u202C\u206D\u202E\u200C\u206D\u202A\u200E\u202B\u202B\u200D\u202D\u200B\u200E\u200F\u206C\u202C\u202D\u202A\u200E\u202E\u206E\u200E\u206B\u202D\u206E\u202E(args, this);
								num = (int)((num3 * 139603093U) ^ 2360056472U);
								continue;
							case 2U:
								goto IL_000C;
							case 3U:
								num = (int)(((!(FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 3631039320U : 2110704414U) ^ (num3 * 842101447U));
								continue;
							case 4U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) != this) ? 3764703728U : 1315240024U) ^ (num3 * 482536350U));
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
				if (FlandreMagicalGuardDef.FlandreMagicalGuard.\u206C\u200F\u200C\u206E\u202E\u206A\u202B\u200B\u206E\u200F\u202E\u202D\u200E\u202B\u206F\u200C\u206B\u200E\u200B\u202C\u206E\u200C\u200B\u200B\u206C\u200C\u200E\u200D\u200D\u200C\u200B\u206A\u202B\u200F\u200C\u206E\u200C\u206B\u206B\u206B\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 2054616772;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(~(uint)num2))) % 6U)
							{
							case 0U:
								goto IL_000C;
							case 2U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u206B\u206C\u206E\u200C\u202D\u206C\u202A\u202B\u206E\u202E\u206B\u202E\u206B\u202D\u202A\u202D\u200D\u206C\u200D\u206B\u206D\u206C\u202A\u200D\u202C\u202A\u200E\u202D\u200C\u200F\u206D\u200D\u200F\u200D\u206D\u202E\u202D\u206B\u200C\u202E(args, true);
								num = (int)((num3 * 2695763975U) ^ 2092423327U);
								continue;
							case 3U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) != this) ? 4266662944U : 4160978465U) ^ (num3 * 2992600684U));
								continue;
							case 4U:
								num = (int)(((!(FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 1346103937U : 528621117U) ^ (num3 * 35310700U));
								continue;
							case 5U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u202D\u202A\u200F\u206B\u206C\u202B\u206C\u202B\u206D\u206C\u206E\u200B\u206E\u206E\u202C\u206D\u202E\u200C\u206D\u202A\u200E\u202B\u202B\u200D\u202D\u200B\u200E\u200F\u206C\u202C\u202D\u202A\u200E\u202E\u206E\u200E\u206B\u202D\u206E\u202E(args, this);
								num = (int)((num3 * 3511068698U) ^ 2730497299U);
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
				if (FlandreMagicalGuardDef.FlandreMagicalGuard.\u206D\u202D\u202B\u200C\u202B\u206F\u206E\u206C\u206C\u202E\u206E\u206B\u206C\u200D\u202B\u206A\u206B\u200B\u206A\u206D\u202E\u206C\u200E\u200C\u200E\u200F\u200D\u200E\u206E\u200C\u206D\u200F\u206B\u206A\u206D\u206D\u200E\u206B\u202C\u206B\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -1633988016;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(num2 ^ ~(154264543 * 968090366 - 2083072301) ^ -1349608043)) % 6U)
							{
							case 1U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u206B\u206C\u206E\u200C\u202D\u206C\u202A\u202B\u206E\u202E\u206B\u202E\u206B\u202D\u202A\u202D\u200D\u206C\u200D\u206B\u206D\u206C\u202A\u200D\u202C\u202A\u200E\u202D\u200C\u200F\u206D\u200D\u200F\u200D\u206D\u202E\u202D\u206B\u200C\u202E(args, true);
								num = (int)((num3 * 2576371473U) ^ 2444307810U);
								continue;
							case 2U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) != this) ? 1781872316U : 1863741127U) ^ (num3 * 3571989511U));
								continue;
							case 3U:
								num = (int)(((FlandreMagicalGuardDef.FlandreMagicalGuard.\u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2539328734U : 3461198550U) ^ (num3 * 3030181407U));
								continue;
							case 4U:
								FlandreMagicalGuardDef.FlandreMagicalGuard.\u200D\u202D\u202A\u200F\u206B\u206C\u202B\u206C\u202B\u206D\u206C\u206E\u200B\u206E\u206E\u202C\u206D\u202E\u200C\u206D\u202A\u200E\u202B\u202B\u200D\u202D\u200B\u200E\u200F\u206C\u202C\u202D\u202A\u200E\u202E\u206E\u200E\u206B\u202D\u206E\u202E(args, this);
								num = (int)((num3 * 4226413589U) ^ 2008914193U);
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
				FlandreMagicalGuardDef.FlandreMagicalGuard.<Actions>d__12 <Actions>d__ = new FlandreMagicalGuardDef.FlandreMagicalGuard.<Actions>d__12(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreMagicalGuardDef.FlandreMagicalGuard.<AfterUseAction>d__13 <AfterUseAction>d__ = new FlandreMagicalGuardDef.FlandreMagicalGuard.<AfterUseAction>d__13(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreMagicalGuardDef.FlandreMagicalGuard.<AfterFollowPlayAction>d__14 <AfterFollowPlayAction>d__ = new FlandreMagicalGuardDef.FlandreMagicalGuard.<AfterFollowPlayAction>d__14(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static int? \u202C\u200D\u206A\u200C\u202E\u206B\u206F\u206B\u202C\u200B\u200F\u206D\u200E\u202E\u200B\u202E\u202A\u206C\u200D\u206D\u206C\u206B\u202A\u202C\u200E\u206F\u200F\u206C\u202A\u206C\u202A\u202B\u200F\u206A\u206C\u206A\u202D\u202A\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static ManaGroup \u200E\u206D\u202A\u206B\u206A\u200C\u200F\u206C\u206E\u200F\u206A\u200F\u200D\u200E\u202E\u202D\u202A\u200B\u202C\u200B\u202E\u206E\u202C\u206E\u200F\u200D\u206B\u200B\u206D\u206B\u200D\u200F\u200B\u200D\u200B\u200B\u202E\u200C\u206D\u206A\u202E(Card A_0)
			{
				return A_0.Mana;
			}

			static BattleController \u200B\u206A\u202A\u206D\u202D\u206D\u200C\u206F\u202C\u200F\u206C\u202D\u200B\u200D\u202B\u200F\u202C\u202C\u206A\u200E\u206A\u202E\u206A\u200B\u206B\u206E\u200B\u206F\u206F\u206E\u206E\u200E\u206C\u206F\u200C\u202E\u200C\u202D\u200C\u206D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u202C\u206B\u202C\u202D\u200B\u200B\u200E\u202A\u202C\u206D\u202D\u206B\u200E\u202D\u202A\u206D\u206A\u202E\u202A\u202A\u202E\u202D\u206F\u206B\u202A\u206B\u206F\u202C\u206C\u200B\u200E\u202C\u206A\u206F\u206A\u200B\u206C\u200F\u202A\u200C\u202E(BattleController A_0)
			{
				return A_0.TurnCardUsageHistory;
			}

			static IReadOnlyList<Card> \u200E\u202A\u202E\u206D\u202A\u202E\u202A\u202B\u202A\u206B\u206F\u206B\u206D\u200B\u200B\u200C\u202B\u202D\u200F\u200B\u200E\u202B\u200C\u200B\u200F\u202D\u202C\u202A\u206B\u202A\u206C\u206B\u206F\u200C\u202A\u202D\u200D\u202D\u200F\u206F\u202E(BattleController A_0)
			{
				return A_0.TurnCardPlayHistory;
			}

			static GameEvent<CardMovingEventArgs> \u200B\u200C\u206C\u202E\u200C\u206A\u206E\u206C\u202B\u200C\u202B\u202D\u206C\u200C\u202B\u206C\u206A\u206E\u206E\u200C\u200F\u206D\u202B\u206B\u200D\u202D\u202A\u206F\u206A\u202C\u206A\u200B\u206A\u206F\u206B\u200E\u202A\u202C\u206F\u200D\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u202B\u200B\u202B\u202C\u202E\u202D\u202B\u206C\u206F\u200B\u206E\u202C\u202D\u200C\u202A\u202E\u206D\u200E\u206E\u200F\u202D\u200D\u202C\u202E\u206A\u200B\u202C\u206E\u202A\u206C\u202D\u202D\u202E\u206A\u206E\u206C\u200D\u206F\u202E\u206E\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u206F\u202A\u200E\u206B\u206F\u200D\u200F\u200C\u202C\u206E\u200F\u200F\u200D\u206A\u200F\u206E\u200B\u206D\u206F\u206B\u202C\u202E\u202B\u202C\u206E\u202A\u206D\u206A\u200D\u200E\u200D\u202E\u206B\u206F\u206D\u206F\u202A\u202D\u202D\u206C\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u200E\u200E\u202E\u200F\u200C\u206E\u206B\u202E\u206B\u206B\u200C\u206B\u200F\u206E\u200B\u206C\u206D\u206E\u206B\u202A\u202D\u200B\u202B\u206D\u202C\u200F\u202B\u206B\u200F\u206A\u200D\u200F\u202C\u206C\u202A\u206D\u206D\u200F\u206C\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u202E\u202A\u202A\u206D\u202B\u202A\u206C\u206B\u206C\u202A\u206B\u202C\u206B\u206D\u206D\u206C\u206E\u200E\u206C\u202A\u200E\u206D\u202D\u200D\u200C\u202D\u202C\u206D\u200C\u200D\u202B\u200F\u206F\u202D\u200D\u200B\u200B\u206A\u202E\u202D\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u200C\u200E\u200D\u200D\u206C\u200F\u206E\u200E\u202B\u206A\u202D\u206B\u206A\u200C\u206E\u200D\u200E\u200F\u200C\u200C\u206D\u202D\u200C\u200F\u202E\u206F\u200B\u206A\u200F\u202E\u200D\u200C\u202C\u202D\u202E\u202A\u200E\u202B\u202B\u200F\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static Card \u206C\u206A\u206A\u200D\u206D\u200F\u200B\u206E\u202C\u206F\u202B\u202E\u202A\u202D\u200D\u200B\u202C\u202C\u202B\u206C\u206A\u206D\u200F\u206B\u206F\u202B\u200E\u202B\u206C\u200B\u206B\u206E\u200E\u200F\u200F\u206C\u206C\u206B\u200C\u206E\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u206A\u202D\u206B\u206B\u202B\u206F\u206C\u206A\u206E\u206E\u200D\u202B\u206D\u200E\u200F\u200C\u206A\u202B\u202C\u206B\u202D\u200E\u202A\u206F\u202A\u202B\u202B\u200E\u202A\u206D\u202A\u200D\u206F\u200E\u202C\u200D\u202C\u206F\u206C\u206D\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u200D\u206B\u206C\u206E\u200C\u202D\u206C\u202A\u202B\u206E\u202E\u206B\u202E\u206B\u202D\u202A\u202D\u200D\u206C\u200D\u206B\u206D\u206C\u202A\u200D\u202C\u202A\u200E\u202D\u200C\u200F\u206D\u200D\u200F\u200D\u206D\u202E\u202D\u206B\u200C\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u200D\u202D\u202A\u200F\u206B\u206C\u202B\u206C\u202B\u206D\u206C\u206E\u200B\u206E\u206E\u202C\u206D\u202E\u200C\u206D\u202A\u200E\u202B\u202B\u200D\u202D\u200B\u200E\u200F\u206C\u202C\u202D\u202A\u200E\u202E\u206E\u200E\u206B\u202D\u206E\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static Card \u206F\u200E\u202B\u200E\u202D\u206F\u206E\u200E\u202D\u206F\u206C\u200C\u202D\u206F\u200E\u206D\u202D\u206D\u202A\u206F\u200B\u202B\u206E\u206B\u206B\u202C\u200F\u200F\u202D\u200C\u206E\u200D\u200F\u200B\u206B\u206B\u200E\u206D\u200F\u202E\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206C\u200F\u200C\u206E\u202E\u206A\u202B\u200B\u206E\u200F\u202E\u202D\u200E\u202B\u206F\u200C\u206B\u200E\u200B\u202C\u206E\u200C\u200B\u200B\u206C\u200C\u200E\u200D\u200D\u200C\u200B\u206A\u202B\u200F\u200C\u206E\u200C\u206B\u206B\u206B\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206D\u202D\u202B\u200C\u202B\u206F\u206E\u206C\u206C\u202E\u206E\u206B\u206C\u200D\u202B\u206A\u206B\u200B\u206A\u206D\u202E\u206C\u200E\u200C\u200E\u200F\u200D\u200E\u206E\u200C\u206D\u200F\u206B\u206A\u206D\u206D\u200E\u206B\u202C\u206B\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			IEnumerable<BattleAction> \u206F\u200F\u200E\u202C\u200B\u206E\u206F\u206F\u200E\u206E\u206B\u206E\u206A\u202D\u202A\u202A\u200C\u206B\u206C\u206C\u200C\u202A\u202A\u200E\u200C\u200F\u206F\u200B\u206D\u202B\u200F\u202A\u206E\u206E\u202A\u202C\u206A\u200C\u202E\u206B\u202E()
			{
				return base.AfterUseAction();
			}

			IEnumerable<BattleAction> \u206E\u200C\u206E\u202E\u200E\u206B\u200B\u200E\u200D\u200F\u206A\u206A\u202A\u200D\u206A\u202E\u206E\u206F\u202D\u202B\u206D\u202A\u202E\u206E\u200B\u206B\u206B\u206D\u202D\u202D\u202C\u200F\u200E\u202B\u202B\u206E\u200D\u202D\u200C\u206F\u202E()
			{
				return base.AfterFollowPlayAction();
			}
		}
	}
}
