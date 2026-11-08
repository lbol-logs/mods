using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
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
	public sealed class FlandreMagicalTechniqueDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-363750423);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMagicalTechniqueDef.\u206B\u202D\u206A\u206C\u200F\u200B\u206F\u200B\u200C\u206B\u202D\u206B\u200B\u202E\u206C\u202E\u200D\u206D\u206C\u206F\u202D\u202E\u200F\u200E\u200C\u202D\u200D\u206E\u206B\u200B\u206D\u206E\u200F\u202D\u206A\u202D\u200F\u200B\u206A\u206F\u202E(BepinexPlugin.embeddedSource);
			FlandreMagicalTechniqueDef.\u206F\u206F\u206D\u202A\u202D\u200C\u202D\u200C\u200B\u206F\u202B\u206E\u202E\u206B\u202B\u206F\u206D\u200F\u200F\u206B\u202E\u200B\u200D\u200E\u206D\u200D\u206C\u206C\u206F\u200F\u200D\u202B\u206D\u206E\u202B\u200E\u202B\u206F\u206E\u200F\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalTechniqueDef.\u206A\u202E\u206C\u202A\u202E\u202B\u202D\u202B\u206B\u202A\u202E\u206D\u202A\u200C\u200F\u206A\u200F\u200D\u202C\u202B\u206C\u206C\u202B\u202B\u202C\u206D\u202A\u200B\u202C\u200F\u200F\u206E\u200F\u206B\u202E\u202B\u202A\u206A\u202D\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreMagicalTechniqueDef.\u206C\u200D\u200F\u206E\u200D\u206E\u202A\u200F\u200F\u200C\u202A\u200C\u202C\u202A\u206E\u200C\u206E\u200F\u202A\u206B\u206B\u202E\u206C\u206E\u206B\u200F\u200E\u200F\u206C\u200F\u202B\u202B\u200B\u200C\u206F\u202A\u200D\u206D\u202D\u200C\u202E(BepinexPlugin.sequenceTable, FlandreMagicalTechniqueDef.\u206F\u206F\u202D\u206F\u200C\u206A\u206F\u200C\u206A\u200D\u200E\u206A\u206A\u202A\u206C\u206E\u200B\u206F\u200F\u206C\u202C\u206D\u200C\u206B\u202D\u200F\u200B\u200F\u200E\u202B\u200C\u202E\u206E\u206A\u202A\u200B\u202D\u202A\u200D\u200D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), 0, true, false, true, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, new int?(1), null, new int?(4), null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Retain, Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1497649843), new List<string>());
		}

		static CardImages \u206B\u202D\u206A\u206C\u200F\u200B\u206F\u200B\u200C\u206B\u202D\u206B\u200B\u202E\u206C\u202E\u200D\u206D\u206C\u206F\u202D\u202E\u200F\u200E\u200C\u202D\u200D\u206E\u206B\u200B\u206D\u206E\u200F\u202D\u206A\u202D\u200F\u200B\u206A\u206F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206F\u206F\u206D\u202A\u202D\u200C\u202D\u200C\u200B\u206F\u202B\u206E\u202E\u206B\u202B\u206F\u206D\u200F\u200F\u206B\u202E\u200B\u200D\u200E\u206D\u200D\u206C\u206C\u206F\u200F\u200D\u202B\u206D\u206E\u202B\u200E\u202B\u206F\u206E\u200F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u202E\u206C\u202A\u202E\u202B\u202D\u202B\u206B\u202A\u202E\u206D\u202A\u200C\u200F\u206A\u200F\u200D\u202C\u202B\u206C\u206C\u202B\u202B\u202C\u206D\u202A\u200B\u202C\u200F\u200F\u206E\u200F\u206B\u202E\u202B\u202A\u206A\u202D\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206F\u206F\u202D\u206F\u200C\u206A\u206F\u200C\u206A\u200D\u200E\u206A\u206A\u202A\u206C\u206E\u200B\u206F\u200F\u206C\u202C\u206D\u200C\u206B\u202D\u200F\u200B\u200F\u200E\u202B\u200C\u202E\u206E\u206A\u202A\u200B\u202D\u202A\u200D\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u200D\u200F\u206E\u200D\u206E\u202A\u200F\u200F\u200C\u202A\u200C\u202C\u202A\u206E\u200C\u206E\u200F\u202A\u206B\u206B\u202E\u206C\u206E\u206B\u200F\u200E\u200F\u206C\u200F\u202B\u202B\u200B\u200C\u206F\u202A\u200D\u206D\u202D\u200C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalTechniqueDef))]
		public sealed class FlandreMagicalTechnique : FlandreCard
		{
			public int Order
			{
				get
				{
					return 3;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u200F\u200B\u206B\u206C\u200E\u206B\u200F\u202E\u206B\u202C\u200E\u202E\u206A\u206A\u200C\u202E\u200C\u206B\u200D\u206A\u206A\u202D\u206C\u206F\u206A\u206B\u202D\u200B\u200B\u200D\u200C\u206D\u202B\u202D\u200F\u202C\u206C\u202E\u202D\u202E((float)FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200C\u202A\u202D\u200C\u200E\u206C\u206B\u202E\u206C\u202A\u200F\u200D\u206A\u206A\u206C\u200E\u206C\u202E\u206B\u206D\u206A\u202E\u206B\u206D\u202E\u200B\u206D\u200F\u206E\u200F\u206E\u200F\u206D\u202A\u200C\u202E\u206C\u202B\u200E\u206A\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200C\u202A\u202D\u200C\u200E\u206C\u206B\u202E\u206C\u202A\u200F\u200D\u206A\u206A\u206C\u200E\u206C\u202E\u206B\u206D\u206A\u202E\u206B\u206D\u202E\u200B\u206D\u200F\u206E\u200F\u206E\u200F\u206D\u202A\u200C\u202E\u206C\u202B\u200E\u206A\u202E(this).GetValueOrDefault() * 2;
				}
			}

			public override ManaGroup AdditionalCost
			{
				get
				{
					ManaGroup manaGroup = FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200F\u206D\u200B\u206E\u206A\u202B\u202B\u206B\u200D\u202E\u200D\u200D\u200B\u200C\u200B\u200C\u206B\u200E\u202D\u202A\u202D\u202D\u200B\u206C\u202A\u202C\u206D\u200F\u202B\u206C\u202E\u202D\u200C\u202E\u202C\u200B\u200F\u202D\u200D\u202B\u202E(this);
					BattleController battleController = FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this);
					int? num;
					if (battleController == null)
					{
						num = null;
					}
					else
					{
						num = new int?(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200F\u200C\u206F\u206D\u206C\u206C\u200F\u202B\u202C\u202A\u200D\u200F\u206D\u206F\u200C\u202A\u206C\u200D\u206B\u202E\u200F\u200E\u206C\u200E\u200E\u206E\u202E\u202D\u202A\u200B\u200B\u200B\u202D\u200F\u206B\u206D\u202D\u202A\u202D\u200C\u202E(battleController).Count((Card c) => c is FlandreMagicalTechniqueDef.FlandreMagicalTechnique));
					}
					int? num2 = num;
					int valueOrDefault = num2.GetValueOrDefault();
					BattleController battleController2 = FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this);
					int? num3;
					if (battleController2 == null)
					{
						num3 = null;
					}
					else
					{
						num3 = new int?(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u206F\u200D\u202E\u202D\u202B\u200C\u202B\u200F\u206B\u206F\u206E\u200C\u202A\u202B\u202D\u206C\u202D\u200C\u202E\u200F\u200F\u200D\u200C\u202C\u202A\u206D\u202A\u206A\u200C\u206A\u202C\u200E\u200E\u206C\u202D\u206C\u200B\u206E\u200F\u202B\u202E(battleController2).Count((Card c) => c is FlandreMagicalTechniqueDef.FlandreMagicalTechnique));
					}
					num2 = num3;
					return manaGroup * (valueOrDefault + num2.GetValueOrDefault());
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 356039218;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-(-729842285 * -988512220 * -472581623 * -663394797 - num2)) * 1851058237)) % 4U)
						{
						case 1U:
							base.IsMagicalGirl = true;
							num = (int)((num3 * 3658962031U) ^ 3845748154U);
							continue;
						case 2U:
							base.IsRandom = true;
							num = (int)((num3 * 3349146239U) ^ 1804772733U);
							continue;
						case 3U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.HandleBattleEvent<CardMovingEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u206C\u202B\u202A\u200B\u206C\u202E\u200F\u200C\u202A\u206C\u200C\u202B\u200C\u202D\u206B\u200B\u206D\u202A\u202D\u202D\u200E\u206B\u206B\u200D\u202A\u206F\u206B\u202D\u206F\u200F\u200B\u206B\u206B\u206B\u202A\u200F\u206A\u200F\u200E\u202C\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardMovingEventArgs>(this.OnCardMoving), (GameEventPriority)0);
				for (;;)
				{
					IL_001E:
					int num = -1255906653;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(num2 - (-1934225265 + (1874649149 + -910242578)) * -350140249) * -532958193 + 537105648)) % 3U)
						{
						case 1U:
							base.HandleBattleEvent<CardMovingToDrawZoneEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200C\u202C\u202D\u200E\u200E\u202B\u200B\u206D\u206C\u202C\u202A\u202C\u206C\u202C\u206B\u200B\u206A\u206C\u206A\u202B\u202E\u202A\u200F\u200B\u202A\u202B\u202E\u206B\u200E\u206C\u200C\u200E\u200E\u200C\u206D\u206B\u206E\u206B\u200D\u202B\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone), (GameEventPriority)0);
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200B\u206B\u202B\u206E\u200D\u206B\u200B\u202A\u202E\u202A\u200B\u202C\u206C\u202A\u202D\u206D\u200C\u202C\u202D\u202C\u206D\u202E\u206E\u200E\u200B\u206A\u200C\u200B\u206D\u202B\u200E\u206A\u200E\u202D\u200B\u200F\u200B\u206A\u202A\u200E\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200C\u202C\u200D\u202E\u200C\u206D\u206A\u202C\u200E\u200B\u206C\u206B\u206A\u200E\u202D\u202B\u200F\u202A\u200F\u206F\u202A\u202A\u206E\u202B\u206F\u200B\u206E\u202C\u200F\u206A\u206A\u206B\u206A\u206F\u202A\u206F\u206A\u202E\u206F\u206C\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							base.HandleBattleEvent<CardEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200D\u200B\u206A\u206A\u202C\u202D\u206B\u202D\u200D\u202A\u202D\u202B\u200E\u202A\u206A\u206A\u206E\u202E\u200C\u200D\u202E\u206B\u200B\u206A\u200B\u202E\u206A\u200C\u200B\u206B\u202B\u202D\u202B\u206F\u200D\u206E\u202D\u200B\u200E\u200C\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
							base.HandleBattleEvent<CardTransformEventArgs>(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u202A\u202B\u206B\u200E\u202B\u206D\u206D\u206C\u202A\u200D\u202B\u200E\u200C\u202A\u200B\u202D\u206B\u206B\u200B\u202C\u200E\u200D\u200D\u206F\u202C\u200C\u206B\u202A\u206D\u202A\u202E\u200E\u200F\u206B\u206F\u202E\u202D\u202C\u202C\u202E(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransforming), (GameEventPriority)0);
							num = (int)((num3 * 3528866729U) ^ 3996914365U);
							continue;
						case 2U:
							goto IL_001E;
						}
						return;
					}
				}
			}

			private void OnCardMoving(CardMovingEventArgs args)
			{
				if (FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u206B\u206F\u206A\u200C\u206B\u200D\u200C\u202B\u202B\u202B\u206A\u206C\u206D\u202B\u200F\u202D\u206C\u200E\u206A\u200C\u206B\u202A\u206E\u206E\u200D\u206B\u200B\u206F\u202B\u202E\u202B\u206E\u200C\u206B\u202D\u200B\u200F\u200E\u202C\u206C\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 1730534863;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(num2 + ~(-(-626447005 + -1158848925))) * 1817538319 + 1458993329)) % 6U)
							{
							case 0U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200D\u200E\u200C\u202C\u200D\u206E\u200C\u200C\u200C\u200F\u200B\u206A\u200D\u202B\u200F\u206A\u200B\u200F\u206E\u200F\u200B\u202A\u202A\u206A\u200B\u202C\u206A\u200D\u200C\u202E\u206F\u200F\u202A\u200C\u202B\u200E\u200E\u200B\u200E\u200E\u202E(args, this);
								num = (int)((num3 * 1947067335U) ^ 2041965050U);
								continue;
							case 1U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) == this) ? 2690235533U : 984766455U) ^ (num3 * 2019104559U));
								continue;
							case 2U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u202A\u206C\u206A\u202C\u206E\u206A\u202A\u206E\u206E\u206B\u206C\u202B\u202D\u206E\u206E\u206A\u206C\u202D\u200D\u206D\u206A\u206A\u202D\u206B\u202C\u200B\u200B\u202E\u206D\u202B\u200D\u200B\u200D\u200F\u200D\u206F\u202A\u202D\u200E\u202E(args, true);
								num = (int)((num3 * 2408648818U) ^ 3342653628U);
								continue;
							case 3U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 564500570U : 2566204015U) ^ (num3 * 1422152558U));
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

			private void OnCardMovingToDrawZone(CardMovingToDrawZoneEventArgs args)
			{
				if (FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202A\u206E\u202B\u206C\u202E\u206E\u202D\u202E\u202A\u200B\u200F\u202D\u200D\u200C\u206D\u200B\u202C\u202C\u202B\u200C\u202A\u206D\u206A\u206D\u206F\u206D\u206C\u206C\u206A\u206C\u202E\u200B\u202C\u200E\u200E\u200C\u200F\u206C\u206A\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -1296239571;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(-num2 - (-371735093 - (1529112099 ^ 526869126))) ^ 1800852964)) % 6U)
							{
							case 0U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u202A\u206C\u206A\u202C\u206E\u206A\u202A\u206E\u206E\u206B\u206C\u202B\u202D\u206E\u206E\u206A\u206C\u202D\u200D\u206D\u206A\u206A\u202D\u206B\u202C\u200B\u200B\u202E\u206D\u202B\u200D\u200B\u200D\u200F\u200D\u206F\u202A\u202D\u200E\u202E(args, true);
								num = (int)((num3 * 163627366U) ^ 2889191848U);
								continue;
							case 1U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2780760106U : 60626447U) ^ (num3 * 1716425488U));
								continue;
							case 3U:
								goto IL_000C;
							case 4U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200D\u200E\u200C\u202C\u200D\u206E\u200C\u200C\u200C\u200F\u200B\u206A\u200D\u202B\u200F\u206A\u200B\u200F\u206E\u200F\u200B\u202A\u202A\u206A\u200B\u202C\u206A\u200D\u200C\u202E\u206F\u200F\u202A\u200C\u202B\u200E\u200E\u200B\u200E\u200E\u202E(args, this);
								num = (int)((num3 * 2473540886U) ^ 3467222822U);
								continue;
							case 5U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) == this) ? 2496542202U : 2537769750U) ^ (num3 * 3883103648U));
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
				if (FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202C\u202E\u206E\u200C\u200F\u200B\u200C\u200C\u206C\u206D\u202A\u206D\u202E\u206C\u206F\u206E\u200F\u200E\u206F\u202C\u202C\u206C\u202B\u200F\u200B\u202C\u200D\u206E\u206B\u200B\u202A\u200C\u202D\u206D\u202D\u206E\u202A\u200D\u202E\u206D\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = -1131375177;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(uint)(-(uint)(num2 * 981206895))))) % 5U)
							{
							case 0U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) != this) ? 2348942857U : 3563691222U) ^ (num3 * 2394637929U));
								continue;
							case 1U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2701734669U : 3112542080U) ^ (num3 * 4157935029U));
								continue;
							case 3U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u202A\u206C\u206A\u202C\u206E\u206A\u202A\u206E\u206E\u206B\u206C\u202B\u202D\u206E\u206E\u206A\u206C\u202D\u200D\u206D\u206A\u206A\u202D\u206B\u202C\u200B\u200B\u202E\u206D\u202B\u200D\u200B\u200D\u200F\u200D\u206F\u202A\u202D\u200E\u202E(args, true);
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200D\u200E\u200C\u202C\u200D\u206E\u200C\u200C\u200C\u200F\u200B\u206A\u200D\u202B\u200F\u206A\u200B\u200F\u206E\u200F\u200B\u202A\u202A\u206A\u200B\u202C\u206A\u200D\u200C\u202E\u206F\u200F\u202A\u200C\u202B\u200E\u200E\u200B\u200E\u200E\u202E(args, this);
								num = (int)((num3 * 567845230U) ^ 328938857U);
								continue;
							case 4U:
								goto IL_000C;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private void OnCardTransforming(CardTransformEventArgs args)
			{
				if (FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u206F\u202D\u206C\u200F\u206C\u206F\u200C\u206A\u206A\u206A\u202D\u206A\u200D\u200C\u200B\u206C\u202A\u200C\u202B\u200F\u206D\u206D\u206D\u200F\u206A\u200F\u206B\u200E\u206E\u202A\u200C\u206A\u200C\u206F\u200C\u202A\u202A\u202B\u206F\u206D\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 46544100;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~((num2 + --622318528) * 129295199) * -1645011425)) % 6U)
							{
							case 1U:
								num = (int)(((!(FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 1236306566U : 2556491224U) ^ (num3 * 2265441341U));
								continue;
							case 2U:
								num = (int)(((FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(args) != this) ? 3216124386U : 3662801653U) ^ (num3 * 2866515394U));
								continue;
							case 3U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u200D\u200E\u200C\u202C\u200D\u206E\u200C\u200C\u200C\u200F\u200B\u206A\u200D\u202B\u200F\u206A\u200B\u200F\u206E\u200F\u200B\u202A\u202A\u206A\u200B\u202C\u206A\u200D\u200C\u202E\u206F\u200F\u202A\u200C\u202B\u200E\u200E\u200B\u200E\u200E\u202E(args, this);
								num = (int)((num3 * 4110472666U) ^ 2966755479U);
								continue;
							case 4U:
								goto IL_000C;
							case 5U:
								FlandreMagicalTechniqueDef.FlandreMagicalTechnique.\u202D\u202A\u206C\u206A\u202C\u206E\u206A\u202A\u206E\u206E\u206B\u206C\u202B\u202D\u206E\u206E\u206A\u206C\u202D\u200D\u206D\u206A\u206A\u202D\u206B\u202C\u200B\u200B\u202E\u206D\u202B\u200D\u200B\u200D\u200F\u200D\u206F\u202A\u202D\u200E\u202E(args, true);
								num = (int)((num3 * 3813637134U) ^ 594917224U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<Actions>d__14 <Actions>d__ = new FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<Actions>d__14(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<AfterUseAction>d__15 <AfterUseAction>d__ = new FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<AfterUseAction>d__15(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<AfterFollowPlayAction>d__16 <AfterFollowPlayAction>d__ = new FlandreMagicalTechniqueDef.FlandreMagicalTechnique.<AfterFollowPlayAction>d__16(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static int? \u200C\u202A\u202D\u200C\u200E\u206C\u206B\u202E\u206C\u202A\u200F\u200D\u206A\u206A\u206C\u200E\u206C\u202E\u206B\u206D\u206A\u202E\u206B\u206D\u202E\u200B\u206D\u200F\u206E\u200F\u206E\u200F\u206D\u202A\u200C\u202E\u206C\u202B\u200E\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200E\u200F\u200B\u206B\u206C\u200E\u206B\u200F\u202E\u206B\u202C\u200E\u202E\u206A\u206A\u200C\u202E\u200C\u206B\u200D\u206A\u206A\u202D\u206C\u206F\u206A\u206B\u202D\u200B\u200B\u200D\u200C\u206D\u202B\u202D\u200F\u202C\u206C\u202E\u202D\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static ManaGroup \u200F\u206D\u200B\u206E\u206A\u202B\u202B\u206B\u200D\u202E\u200D\u200D\u200B\u200C\u200B\u200C\u206B\u200E\u202D\u202A\u202D\u202D\u200B\u206C\u202A\u202C\u206D\u200F\u202B\u206C\u202E\u202D\u200C\u202E\u202C\u200B\u200F\u202D\u200D\u202B\u202E(Card A_0)
			{
				return A_0.Mana;
			}

			static BattleController \u202D\u206F\u202D\u202B\u202C\u202E\u202A\u206B\u202B\u200C\u206E\u200E\u200F\u202A\u202B\u206F\u200B\u206F\u206E\u206D\u200C\u206A\u200B\u200E\u200B\u206D\u206E\u202C\u200B\u200C\u206A\u206D\u200E\u206D\u202A\u206F\u206B\u202B\u200E\u200E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u200F\u200C\u206F\u206D\u206C\u206C\u200F\u202B\u202C\u202A\u200D\u200F\u206D\u206F\u200C\u202A\u206C\u200D\u206B\u202E\u200F\u200E\u206C\u200E\u200E\u206E\u202E\u202D\u202A\u200B\u200B\u200B\u202D\u200F\u206B\u206D\u202D\u202A\u202D\u200C\u202E(BattleController A_0)
			{
				return A_0.TurnCardUsageHistory;
			}

			static IReadOnlyList<Card> \u206F\u200D\u202E\u202D\u202B\u200C\u202B\u200F\u206B\u206F\u206E\u200C\u202A\u202B\u202D\u206C\u202D\u200C\u202E\u200F\u200F\u200D\u200C\u202C\u202A\u206D\u202A\u206A\u200C\u206A\u202C\u200E\u200E\u206C\u202D\u206C\u200B\u206E\u200F\u202B\u202E(BattleController A_0)
			{
				return A_0.TurnCardPlayHistory;
			}

			static GameEvent<CardMovingEventArgs> \u206C\u202B\u202A\u200B\u206C\u202E\u200F\u200C\u202A\u206C\u200C\u202B\u200C\u202D\u206B\u200B\u206D\u202A\u202D\u202D\u200E\u206B\u206B\u200D\u202A\u206F\u206B\u202D\u206F\u200F\u200B\u206B\u206B\u206B\u202A\u200F\u206A\u200F\u200E\u202C\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u200C\u202C\u202D\u200E\u200E\u202B\u200B\u206D\u206C\u202C\u202A\u202C\u206C\u202C\u206B\u200B\u206A\u206C\u206A\u202B\u202E\u202A\u200F\u200B\u202A\u202B\u202E\u206B\u200E\u206C\u200C\u200E\u200E\u200C\u206D\u206B\u206E\u206B\u200D\u202B\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u200B\u206B\u202B\u206E\u200D\u206B\u200B\u202A\u202E\u202A\u200B\u202C\u206C\u202A\u202D\u206D\u200C\u202C\u202D\u202C\u206D\u202E\u206E\u200E\u200B\u206A\u200C\u200B\u206D\u202B\u200E\u206A\u200E\u202D\u200B\u200F\u200B\u206A\u202A\u200E\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u200C\u202C\u200D\u202E\u200C\u206D\u206A\u202C\u200E\u200B\u206C\u206B\u206A\u200E\u202D\u202B\u200F\u202A\u200F\u206F\u202A\u202A\u206E\u202B\u206F\u200B\u206E\u202C\u200F\u206A\u206A\u206B\u206A\u206F\u202A\u206F\u206A\u202E\u206F\u206C\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u200D\u200B\u206A\u206A\u202C\u202D\u206B\u202D\u200D\u202A\u202D\u202B\u200E\u202A\u206A\u206A\u206E\u202E\u200C\u200D\u202E\u206B\u200B\u206A\u200B\u202E\u206A\u200C\u200B\u206B\u202B\u202D\u202B\u206F\u200D\u206E\u202D\u200B\u200E\u200C\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u202D\u202A\u202B\u206B\u200E\u202B\u206D\u206D\u206C\u202A\u200D\u202B\u200E\u200C\u202A\u200B\u202D\u206B\u206B\u200B\u202C\u200E\u200D\u200D\u206F\u202C\u200C\u206B\u202A\u206D\u202A\u202E\u200E\u200F\u206B\u206F\u202E\u202D\u202C\u202C\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static Card \u206B\u206F\u206A\u200C\u206B\u200D\u200C\u202B\u202B\u202B\u206A\u206C\u206D\u202B\u200F\u202D\u206C\u200E\u206A\u200C\u206B\u202A\u206E\u206E\u200D\u206B\u200B\u206F\u202B\u202E\u202B\u206E\u200C\u206B\u202D\u200B\u200F\u200E\u202C\u206C\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u200E\u206A\u206F\u206B\u206F\u202A\u200D\u202D\u206A\u206F\u202E\u200E\u202D\u206E\u206D\u200D\u200E\u202B\u200D\u202C\u202A\u200C\u200D\u200E\u202D\u206C\u206F\u200B\u206D\u200D\u200B\u200B\u200E\u206D\u206B\u202A\u202D\u202D\u202A\u200C\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u202D\u202A\u206C\u206A\u202C\u206E\u206A\u202A\u206E\u206E\u206B\u206C\u202B\u202D\u206E\u206E\u206A\u206C\u202D\u200D\u206D\u206A\u206A\u202D\u206B\u202C\u200B\u200B\u202E\u206D\u202B\u200D\u200B\u200D\u200F\u200D\u206F\u202A\u202D\u200E\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u200D\u200E\u200C\u202C\u200D\u206E\u200C\u200C\u200C\u200F\u200B\u206A\u200D\u202B\u200F\u206A\u200B\u200F\u206E\u200F\u200B\u202A\u202A\u206A\u200B\u202C\u206A\u200D\u200C\u202E\u206F\u200F\u202A\u200C\u202B\u200E\u200E\u200B\u200E\u200E\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static Card \u202A\u206E\u202B\u206C\u202E\u206E\u202D\u202E\u202A\u200B\u200F\u202D\u200D\u200C\u206D\u200B\u202C\u202C\u202B\u200C\u202A\u206D\u206A\u206D\u206F\u206D\u206C\u206C\u206A\u206C\u202E\u200B\u202C\u200E\u200E\u200C\u200F\u206C\u206A\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202C\u202E\u206E\u200C\u200F\u200B\u200C\u200C\u206C\u206D\u202A\u206D\u202E\u206C\u206F\u206E\u200F\u200E\u206F\u202C\u202C\u206C\u202B\u200F\u200B\u202C\u200D\u206E\u206B\u200B\u202A\u200C\u202D\u206D\u202D\u206E\u202A\u200D\u202E\u206D\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206F\u202D\u206C\u200F\u206C\u206F\u200C\u206A\u206A\u206A\u202D\u206A\u200D\u200C\u200B\u206C\u202A\u200C\u202B\u200F\u206D\u206D\u206D\u200F\u206A\u200F\u206B\u200E\u206E\u202A\u200C\u206A\u200C\u206F\u200C\u202A\u202A\u202B\u206F\u206D\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			IEnumerable<BattleAction> \u202E\u200E\u202A\u200D\u200B\u202D\u202E\u206D\u206E\u202A\u200F\u200D\u206A\u206D\u206B\u202B\u206B\u202D\u202E\u206D\u206A\u202E\u202B\u206A\u200E\u200F\u206E\u206D\u202A\u202A\u206A\u206A\u202E\u206B\u202A\u206B\u202A\u200E\u200E\u202B\u202E()
			{
				return base.AfterUseAction();
			}

			IEnumerable<BattleAction> \u202B\u202D\u202B\u206D\u200C\u206D\u202D\u202A\u200D\u200E\u202E\u202A\u200C\u200D\u200B\u206C\u206D\u206B\u206D\u206D\u200F\u202B\u206A\u206A\u202C\u200F\u206F\u200F\u206D\u202A\u202A\u202B\u200F\u200E\u206C\u206B\u202D\u206A\u200C\u202D\u202E()
			{
				return base.AfterFollowPlayAction();
			}
		}
	}
}
