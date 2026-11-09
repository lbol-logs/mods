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
	public sealed class FlandreMagicalSlashDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1959125149);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMagicalSlashDef.\u200C\u206B\u200D\u206B\u206C\u202C\u206F\u200B\u206C\u202B\u206F\u200B\u206B\u206D\u202A\u200B\u200E\u200D\u200F\u202E\u202A\u200B\u202A\u200F\u206A\u200D\u202C\u206D\u200E\u202A\u206A\u200B\u206F\u206B\u206C\u206C\u200D\u206B\u200E\u200C\u202E(BepinexPlugin.embeddedSource);
			FlandreMagicalSlashDef.\u206D\u206B\u202C\u206F\u200E\u206F\u206B\u200B\u202D\u202E\u206F\u202A\u202E\u206C\u206D\u200F\u200C\u200F\u206B\u206F\u206A\u206D\u200D\u206A\u200D\u206E\u202D\u202B\u202C\u200D\u200E\u202A\u202A\u206A\u200B\u202A\u206E\u206C\u202B\u202E\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMagicalSlashDef.\u202A\u200E\u206A\u200C\u200C\u206E\u202D\u202C\u202E\u200F\u206D\u200D\u200D\u206E\u202B\u200F\u200B\u200D\u202D\u200F\u206B\u206C\u206D\u202C\u206E\u202E\u202E\u206A\u206D\u206E\u202C\u202E\u200F\u206A\u202A\u206F\u206F\u200D\u206D\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreMagicalSlashDef.\u206A\u202D\u200D\u200D\u200E\u200F\u200F\u202B\u206E\u202E\u200C\u200D\u200B\u200C\u202C\u206F\u206F\u206A\u202E\u200B\u202D\u200B\u206B\u206C\u206C\u202D\u202E\u202D\u200F\u200B\u200D\u206C\u206F\u206A\u206D\u200B\u202C\u202B\u206B\u206D\u202E(BepinexPlugin.sequenceTable, FlandreMagicalSlashDef.\u200D\u202E\u200F\u206C\u202E\u202D\u200F\u206A\u200C\u206D\u202A\u200E\u200D\u200B\u206D\u206D\u206B\u202D\u200E\u202C\u202E\u200F\u200B\u206D\u202B\u206F\u206E\u202A\u202E\u200E\u206F\u206D\u206C\u202B\u206D\u206A\u200C\u200B\u206B\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1211559522), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1522051310), 0, true, false, true, false, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Retain, Keyword.Accuracy | Keyword.Retain, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-523678837), new List<string>());
		}

		static CardImages \u200C\u206B\u200D\u206B\u206C\u202C\u206F\u200B\u206C\u202B\u206F\u200B\u206B\u206D\u202A\u200B\u200E\u200D\u200F\u202E\u202A\u200B\u202A\u200F\u206A\u200D\u202C\u206D\u200E\u202A\u206A\u200B\u206F\u206B\u206C\u206C\u200D\u206B\u200E\u200C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206D\u206B\u202C\u206F\u200E\u206F\u206B\u200B\u202D\u202E\u206F\u202A\u202E\u206C\u206D\u200F\u200C\u200F\u206B\u206F\u206A\u206D\u200D\u206A\u200D\u206E\u202D\u202B\u202C\u200D\u200E\u202A\u202A\u206A\u200B\u202A\u206E\u206C\u202B\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u200E\u206A\u200C\u200C\u206E\u202D\u202C\u202E\u200F\u206D\u200D\u200D\u206E\u202B\u200F\u200B\u200D\u202D\u200F\u206B\u206C\u206D\u202C\u206E\u202E\u202E\u206A\u206D\u206E\u202C\u202E\u200F\u206A\u202A\u206F\u206F\u200D\u206D\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u202E\u200F\u206C\u202E\u202D\u200F\u206A\u200C\u206D\u202A\u200E\u200D\u200B\u206D\u206D\u206B\u202D\u200E\u202C\u202E\u200F\u200B\u206D\u202B\u206F\u206E\u202A\u202E\u200E\u206F\u206D\u206C\u202B\u206D\u206A\u200C\u200B\u206B\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206A\u202D\u200D\u200D\u200E\u200F\u200F\u202B\u206E\u202E\u200C\u200D\u200B\u200C\u202C\u206F\u206F\u206A\u202E\u200B\u202D\u200B\u206B\u206C\u206C\u202D\u202E\u202D\u200F\u200B\u200D\u206C\u206F\u206A\u206D\u200B\u202C\u202B\u206B\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreMagicalSlashDef))]
		public sealed class FlandreMagicalSlash : FlandreCard
		{
			public int Order
			{
				get
				{
					return 1;
				}
			}

			public override int AdditionalDamage
			{
				get
				{
					return FlandreMagicalSlashDef.FlandreMagicalSlash.\u200B\u202E\u202D\u200D\u200C\u206C\u202B\u200B\u202E\u206C\u202B\u200B\u206A\u202E\u200D\u206B\u200F\u206C\u200E\u202D\u200E\u206C\u202D\u200D\u202E\u206B\u202D\u206C\u202D\u206C\u200B\u202E\u200B\u200D\u202B\u206F\u202D\u206E\u200F\u206F\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override ManaGroup AdditionalCost
			{
				get
				{
					ManaGroup manaGroup = FlandreMagicalSlashDef.FlandreMagicalSlash.\u200B\u202C\u200D\u202D\u202C\u202A\u206D\u202C\u206B\u206E\u206C\u206A\u206B\u202C\u206D\u202A\u206F\u200D\u202B\u206E\u202B\u206D\u206C\u200E\u206A\u206F\u206E\u206A\u206F\u206C\u202C\u206E\u206F\u206E\u200B\u206B\u200D\u206F\u202B\u200C\u202E(this);
					BattleController battleController = FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this);
					int? num;
					if (battleController == null)
					{
						num = null;
					}
					else
					{
						num = new int?(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206A\u206E\u206C\u206E\u206B\u202B\u200D\u202E\u202C\u200B\u206A\u202C\u202B\u202E\u206C\u206D\u200B\u200C\u202C\u202A\u202D\u206F\u200C\u202D\u206E\u202E\u202E\u206B\u202E\u200F\u200F\u206D\u202A\u202E\u200D\u202D\u206D\u206A\u206B\u202C\u202E(battleController).Count((Card c) => c is FlandreMagicalSlashDef.FlandreMagicalSlash));
					}
					int? num2 = num;
					int valueOrDefault = num2.GetValueOrDefault();
					BattleController battleController2 = FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this);
					int? num3;
					if (battleController2 == null)
					{
						num3 = null;
					}
					else
					{
						num3 = new int?(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206E\u202C\u200B\u206E\u202A\u206B\u206D\u206C\u206E\u206A\u200E\u206E\u200D\u206E\u206F\u206E\u202A\u206F\u200C\u200C\u202A\u200B\u202E\u206B\u200E\u200D\u202E\u202A\u202E\u202D\u202E\u202D\u200E\u200E\u200D\u200E\u202D\u202C\u200E\u206A\u202E(battleController2).Count((Card c) => c is FlandreMagicalSlashDef.FlandreMagicalSlash));
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
				base.HandleBattleEvent<CardMovingEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u200C\u202A\u202D\u206A\u206F\u200E\u206D\u202A\u202C\u202E\u206C\u200E\u206F\u206F\u206C\u202C\u202A\u202D\u202D\u206C\u200D\u206A\u200B\u200D\u206F\u200C\u202A\u206F\u206D\u206F\u202A\u200F\u206B\u206F\u206B\u206C\u206B\u202A\u200F\u206A\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardMovingEventArgs>(this.OnCardMoving), (GameEventPriority)0);
				base.HandleBattleEvent<CardMovingToDrawZoneEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206B\u206E\u206E\u206D\u206E\u202C\u206D\u200D\u206A\u206F\u200B\u202A\u202D\u200F\u200D\u200E\u206D\u206D\u206F\u200E\u200F\u200E\u206E\u206F\u200C\u206A\u206B\u206D\u200D\u200C\u206C\u206F\u206C\u206F\u202D\u206D\u206C\u202B\u206B\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardMovingToDrawZoneEventArgs>(this.OnCardMovingToDrawZone), (GameEventPriority)0);
				base.HandleBattleEvent<CardEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206B\u202D\u206F\u206C\u206F\u202C\u206C\u202E\u202E\u206C\u202D\u200C\u200C\u206B\u200F\u202A\u206B\u200E\u206C\u200F\u206E\u202D\u202E\u200B\u206B\u206B\u200B\u206E\u206C\u200B\u200B\u206F\u202D\u202C\u206C\u206D\u206F\u206C\u200B\u200D\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
				base.HandleBattleEvent<CardEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u200D\u202C\u200E\u202C\u202B\u206B\u200D\u206E\u200B\u206D\u206D\u206F\u206B\u200E\u200E\u200E\u200D\u206B\u202E\u206A\u206D\u202B\u206A\u206C\u200C\u202A\u200F\u206F\u206B\u202E\u206C\u206E\u202C\u202D\u200D\u206E\u200C\u202B\u200C\u200F\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
				base.HandleBattleEvent<CardEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u202D\u206A\u202D\u206F\u206F\u200C\u206D\u200F\u202B\u202A\u202C\u206C\u206A\u202C\u202A\u202A\u206E\u200B\u200B\u202A\u200F\u200F\u206C\u206B\u200D\u206A\u200F\u200C\u202B\u206E\u202C\u200B\u202A\u200C\u202E\u206E\u200D\u200B\u202C\u206D\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardEventArgs>(this.OnCardLeaving), (GameEventPriority)0);
				base.HandleBattleEvent<CardTransformEventArgs>(FlandreMagicalSlashDef.FlandreMagicalSlash.\u200E\u202A\u200E\u206A\u206C\u202A\u200C\u200E\u206F\u202B\u206F\u206F\u206F\u206B\u206E\u202C\u206B\u200B\u202B\u200D\u200D\u200C\u200D\u200B\u206E\u206A\u202E\u202D\u200D\u206D\u206D\u206D\u202D\u206C\u200D\u200C\u200C\u202C\u202A\u202E\u202E(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(this)), new GameEventHandler<CardTransformEventArgs>(this.OnCardTransforming), (GameEventPriority)0);
			}

			private void OnCardMoving(CardMovingEventArgs args)
			{
				if (FlandreMagicalSlashDef.FlandreMagicalSlash.\u202E\u202B\u206B\u200E\u200D\u206B\u202E\u200F\u200B\u206B\u200C\u206B\u200B\u200B\u200D\u200B\u206E\u202B\u206C\u206B\u206E\u202C\u202B\u200B\u206C\u206E\u206E\u206B\u202E\u206D\u202D\u200F\u202E\u206B\u200D\u202B\u206B\u206B\u202D\u206A\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 306583345;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)((num2 - -(628893660 - -293516508 - 515182628 * -442004991)) ^ (~998811375 * 610101107) ^ ~1840431589))) % 5U)
							{
							case 0U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u202B\u206E\u206B\u202A\u206B\u202D\u206B\u206B\u200C\u200B\u200E\u206F\u206D\u200E\u206E\u202B\u202D\u202A\u202A\u202D\u202D\u200D\u200C\u202E\u202D\u200C\u200E\u206F\u200E\u202A\u200F\u200F\u206E\u202C\u202B\u206A\u206C\u200C\u202E\u206D\u202E(args, true);
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u200D\u202C\u200D\u200B\u206D\u206F\u202B\u200F\u200E\u202B\u202B\u200E\u200E\u206F\u206B\u206F\u202E\u200C\u202C\u200B\u200F\u200C\u202D\u200E\u202D\u206A\u202A\u206F\u206B\u202D\u202C\u202C\u200E\u202A\u200F\u206D\u202A\u202A\u202B\u202A\u202E(args, this);
								num = (int)((num3 * 2355351440U) ^ 2268528532U);
								continue;
							case 1U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 1908826852U : 1251496939U) ^ (num3 * 1082222732U));
								continue;
							case 2U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) == this) ? 3771997232U : 3648684422U) ^ (num3 * 3198220322U));
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

			private void OnCardMovingToDrawZone(CardMovingToDrawZoneEventArgs args)
			{
				if (FlandreMagicalSlashDef.FlandreMagicalSlash.\u200F\u200B\u206A\u200E\u206F\u202B\u200E\u202B\u206A\u202B\u206F\u202C\u200F\u200F\u206F\u200E\u202C\u206B\u206E\u206F\u206A\u202B\u200F\u200E\u202A\u206A\u202A\u206A\u200C\u206E\u200D\u200B\u206B\u200B\u200F\u202A\u206B\u206D\u200F\u202E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 977374282;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-501685908 - ~(uint)(num2 + (-845857403 + 1103535523 + -1599611265 * -319264469 - (-142752424 + -2138172222)) - (522794157 ^ 503773783 ^ 434500533)))) % 6U)
							{
							case 0U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u200D\u202C\u200D\u200B\u206D\u206F\u202B\u200F\u200E\u202B\u202B\u200E\u200E\u206F\u206B\u206F\u202E\u200C\u202C\u200B\u200F\u200C\u202D\u200E\u202D\u206A\u202A\u206F\u206B\u202D\u202C\u202C\u200E\u202A\u200F\u206D\u202A\u202A\u202B\u202A\u202E(args, this);
								num = (int)((num3 * 2254900697U) ^ 1485042135U);
								continue;
							case 1U:
								num = (int)(((!(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 1786667463U : 2823379350U) ^ (num3 * 2067160339U));
								continue;
							case 2U:
								goto IL_000C;
							case 3U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u202B\u206E\u206B\u202A\u206B\u202D\u206B\u206B\u200C\u200B\u200E\u206F\u206D\u200E\u206E\u202B\u202D\u202A\u202A\u202D\u202D\u200D\u200C\u202E\u202D\u200C\u200E\u206F\u200E\u202A\u200F\u200F\u206E\u202C\u202B\u206A\u206C\u200C\u202E\u206D\u202E(args, true);
								num = (int)((num3 * 2494614849U) ^ 3900384398U);
								continue;
							case 5U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) == this) ? 692396452U : 2924323U) ^ (num3 * 556855829U));
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
				if (FlandreMagicalSlashDef.FlandreMagicalSlash.\u202C\u206B\u202B\u206B\u206C\u202E\u206C\u202D\u202B\u202C\u206F\u202D\u200E\u200B\u200D\u202B\u206E\u200F\u202A\u202A\u202C\u206F\u206D\u206C\u200F\u206A\u206D\u200B\u206B\u206D\u200B\u200F\u206F\u200D\u206D\u200B\u202A\u200B\u202A\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 2010322261;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~num2 ^ (860701560 + -956094091 + (1441675804 - 1639337062))) ^ -1052416146)) % 6U)
							{
							case 0U:
								goto IL_000C;
							case 1U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) == this) ? 2660189867U : 3909326969U) ^ (num3 * 2767129749U));
								continue;
							case 2U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u202B\u206E\u206B\u202A\u206B\u202D\u206B\u206B\u200C\u200B\u200E\u206F\u206D\u200E\u206E\u202B\u202D\u202A\u202A\u202D\u202D\u200D\u200C\u202E\u202D\u200C\u200E\u206F\u200E\u202A\u200F\u200F\u206E\u202C\u202B\u206A\u206C\u200C\u202E\u206D\u202E(args, true);
								num = (int)((num3 * 392422406U) ^ 36422433U);
								continue;
							case 3U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u200D\u202C\u200D\u200B\u206D\u206F\u202B\u200F\u200E\u202B\u202B\u200E\u200E\u206F\u206B\u206F\u202E\u200C\u202C\u200B\u200F\u200C\u202D\u200E\u202D\u206A\u202A\u206F\u206B\u202D\u202C\u202C\u200E\u202A\u200F\u206D\u202A\u202A\u202B\u202A\u202E(args, this);
								num = (int)((num3 * 110159849U) ^ 3756246243U);
								continue;
							case 5U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe) ? 2467038081U : 2324856474U) ^ (num3 * 1226918467U));
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
				if (FlandreMagicalSlashDef.FlandreMagicalSlash.\u206A\u206B\u202E\u200E\u206E\u200E\u202D\u206A\u206C\u202A\u206C\u202D\u206C\u206F\u202A\u202A\u200B\u202C\u206C\u202B\u206C\u202E\u200F\u202C\u206E\u206D\u206B\u200E\u200C\u206F\u200D\u202B\u202A\u206C\u200B\u206A\u202A\u202A\u202E\u206E\u202E(args) == this)
				{
					for (;;)
					{
						IL_000C:
						int num = 1685565497;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(~(num2 - 1133962563 * (-383692789 * (-1436640929 ^ -1135592789))) - 768918343 * 1434775853))) % 6U)
							{
							case 0U:
								num = (int)(((FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) != this) ? 1991437518U : 3101331975U) ^ (num3 * 3372892935U));
								continue;
							case 2U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u202B\u206E\u206B\u202A\u206B\u202D\u206B\u206B\u200C\u200B\u200E\u206F\u206D\u200E\u206E\u202B\u202D\u202A\u202A\u202D\u202D\u200D\u200C\u202E\u202D\u200C\u200E\u206F\u200E\u202A\u200F\u200F\u206E\u202C\u202B\u206A\u206C\u200C\u202E\u206D\u202E(args, true);
								num = (int)((num3 * 2600930517U) ^ 2453552308U);
								continue;
							case 3U:
								goto IL_000C;
							case 4U:
								FlandreMagicalSlashDef.FlandreMagicalSlash.\u200D\u202C\u200D\u200B\u206D\u206F\u202B\u200F\u200E\u202B\u202B\u200E\u200E\u206F\u206B\u206F\u202E\u200C\u202C\u200B\u200F\u200C\u202D\u200E\u202D\u206A\u202A\u206F\u206B\u202D\u202C\u202C\u200E\u202A\u200F\u206D\u202A\u202A\u202B\u202A\u202E(args, this);
								num = (int)((num3 * 471485620U) ^ 3261018951U);
								continue;
							case 5U:
								num = (int)(((!(FlandreMagicalSlashDef.FlandreMagicalSlash.\u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(args) is FlandreMagicalGirlFlandreEngageSeDef.FlandreMagicalGirlFlandreEngageSe)) ? 415683632U : 386496143U) ^ (num3 * 888836224U));
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
				FlandreMagicalSlashDef.FlandreMagicalSlash.<Actions>d__12 <Actions>d__ = new FlandreMagicalSlashDef.FlandreMagicalSlash.<Actions>d__12(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreMagicalSlashDef.FlandreMagicalSlash.<AfterUseAction>d__13 <AfterUseAction>d__ = new FlandreMagicalSlashDef.FlandreMagicalSlash.<AfterUseAction>d__13(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			public override IEnumerable<BattleAction> AfterFollowPlayAction()
			{
				FlandreMagicalSlashDef.FlandreMagicalSlash.<AfterFollowPlayAction>d__14 <AfterFollowPlayAction>d__ = new FlandreMagicalSlashDef.FlandreMagicalSlash.<AfterFollowPlayAction>d__14(-2);
				<AfterFollowPlayAction>d__.<>4__this = this;
				return <AfterFollowPlayAction>d__;
			}

			static int? \u200B\u202E\u202D\u200D\u200C\u206C\u202B\u200B\u202E\u206C\u202B\u200B\u206A\u202E\u200D\u206B\u200F\u206C\u200E\u202D\u200E\u206C\u202D\u200D\u202E\u206B\u202D\u206C\u202D\u206C\u200B\u202E\u200B\u200D\u202B\u206F\u202D\u206E\u200F\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static ManaGroup \u200B\u202C\u200D\u202D\u202C\u202A\u206D\u202C\u206B\u206E\u206C\u206A\u206B\u202C\u206D\u202A\u206F\u200D\u202B\u206E\u202B\u206D\u206C\u200E\u206A\u206F\u206E\u206A\u206F\u206C\u202C\u206E\u206F\u206E\u200B\u206B\u200D\u206F\u202B\u200C\u202E(Card A_0)
			{
				return A_0.Mana;
			}

			static BattleController \u206D\u202C\u202D\u202B\u206A\u200F\u202A\u206E\u200F\u202A\u206E\u202A\u206A\u202A\u200D\u206A\u206B\u206E\u200C\u200B\u202E\u206A\u202B\u202B\u200E\u202E\u200F\u206D\u200D\u200C\u202B\u202D\u200D\u206E\u206E\u202B\u206A\u206B\u206B\u202C\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206A\u206E\u206C\u206E\u206B\u202B\u200D\u202E\u202C\u200B\u206A\u202C\u202B\u202E\u206C\u206D\u200B\u200C\u202C\u202A\u202D\u206F\u200C\u202D\u206E\u202E\u202E\u206B\u202E\u200F\u200F\u206D\u202A\u202E\u200D\u202D\u206D\u206A\u206B\u202C\u202E(BattleController A_0)
			{
				return A_0.TurnCardUsageHistory;
			}

			static IReadOnlyList<Card> \u206E\u202C\u200B\u206E\u202A\u206B\u206D\u206C\u206E\u206A\u200E\u206E\u200D\u206E\u206F\u206E\u202A\u206F\u200C\u200C\u202A\u200B\u202E\u206B\u200E\u200D\u202E\u202A\u202E\u202D\u202E\u202D\u200E\u200E\u200D\u200E\u202D\u202C\u200E\u206A\u202E(BattleController A_0)
			{
				return A_0.TurnCardPlayHistory;
			}

			static GameEvent<CardMovingEventArgs> \u200C\u202A\u202D\u206A\u206F\u200E\u206D\u202A\u202C\u202E\u206C\u200E\u206F\u206F\u206C\u202C\u202A\u202D\u202D\u206C\u200D\u206A\u200B\u200D\u206F\u200C\u202A\u206F\u206D\u206F\u202A\u200F\u206B\u206F\u206B\u206C\u206B\u202A\u200F\u206A\u202E(BattleController A_0)
			{
				return A_0.CardMoving;
			}

			static GameEvent<CardMovingToDrawZoneEventArgs> \u206B\u206E\u206E\u206D\u206E\u202C\u206D\u200D\u206A\u206F\u200B\u202A\u202D\u200F\u200D\u200E\u206D\u206D\u206F\u200E\u200F\u200E\u206E\u206F\u200C\u206A\u206B\u206D\u200D\u200C\u206C\u206F\u206C\u206F\u202D\u206D\u206C\u202B\u206B\u202E(BattleController A_0)
			{
				return A_0.CardMovingToDrawZone;
			}

			static GameEvent<CardEventArgs> \u206B\u202D\u206F\u206C\u206F\u202C\u206C\u202E\u202E\u206C\u202D\u200C\u200C\u206B\u200F\u202A\u206B\u200E\u206C\u200F\u206E\u202D\u202E\u200B\u206B\u206B\u200B\u206E\u206C\u200B\u200B\u206F\u202D\u202C\u206C\u206D\u206F\u206C\u200B\u200D\u202E(BattleController A_0)
			{
				return A_0.CardDiscarding;
			}

			static GameEvent<CardEventArgs> \u200D\u202C\u200E\u202C\u202B\u206B\u200D\u206E\u200B\u206D\u206D\u206F\u206B\u200E\u200E\u200E\u200D\u206B\u202E\u206A\u206D\u202B\u206A\u206C\u200C\u202A\u200F\u206F\u206B\u202E\u206C\u206E\u202C\u202D\u200D\u206E\u200C\u202B\u200C\u200F\u202E(BattleController A_0)
			{
				return A_0.CardExiling;
			}

			static GameEvent<CardEventArgs> \u202D\u206A\u202D\u206F\u206F\u200C\u206D\u200F\u202B\u202A\u202C\u206C\u206A\u202C\u202A\u202A\u206E\u200B\u200B\u202A\u200F\u200F\u206C\u206B\u200D\u206A\u200F\u200C\u202B\u206E\u202C\u200B\u202A\u200C\u202E\u206E\u200D\u200B\u202C\u206D\u202E(BattleController A_0)
			{
				return A_0.CardRemoving;
			}

			static GameEvent<CardTransformEventArgs> \u200E\u202A\u200E\u206A\u206C\u202A\u200C\u200E\u206F\u202B\u206F\u206F\u206F\u206B\u206E\u202C\u206B\u200B\u202B\u200D\u200D\u200C\u200D\u200B\u206E\u206A\u202E\u202D\u200D\u206D\u206D\u206D\u202D\u206C\u200D\u200C\u200C\u202C\u202A\u202E\u202E(BattleController A_0)
			{
				return A_0.CardTransforming;
			}

			static Card \u202E\u202B\u206B\u200E\u200D\u206B\u202E\u200F\u200B\u206B\u200C\u206B\u200B\u200B\u200D\u200B\u206E\u202B\u206C\u206B\u206E\u202C\u202B\u200B\u206C\u206E\u206E\u206B\u202E\u206D\u202D\u200F\u202E\u206B\u200D\u202B\u206B\u206B\u202D\u206A\u202E(CardMovingEventArgs A_0)
			{
				return A_0.Card;
			}

			static GameEntity \u206F\u202C\u206F\u206F\u206A\u202B\u200E\u202A\u200E\u206C\u202D\u202D\u202C\u202E\u200C\u200E\u202D\u202E\u200C\u206B\u206D\u202C\u206B\u200B\u206D\u206E\u202B\u200D\u202C\u200B\u202A\u206E\u200F\u202D\u200C\u202B\u200F\u206D\u202A\u202D\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static void \u202B\u206E\u206B\u202A\u206B\u202D\u206B\u206B\u200C\u200B\u200E\u206F\u206D\u200E\u206E\u202B\u202D\u202A\u202A\u202D\u202D\u200D\u200C\u202E\u202D\u200C\u200E\u206F\u200E\u202A\u200F\u200F\u206E\u202C\u202B\u206A\u206C\u200C\u202E\u206D\u202E(GameEventArgs A_0, bool A_1)
			{
				A_0.CanCancel = A_1;
			}

			static void \u200D\u202C\u200D\u200B\u206D\u206F\u202B\u200F\u200E\u202B\u202B\u200E\u200E\u206F\u206B\u206F\u202E\u200C\u202C\u200B\u200F\u200C\u202D\u200E\u202D\u206A\u202A\u206F\u206B\u202D\u202C\u202C\u200E\u202A\u200F\u206D\u202A\u202A\u202B\u202A\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.CancelBy(A_1);
			}

			static Card \u200F\u200B\u206A\u200E\u206F\u202B\u200E\u202B\u206A\u202B\u206F\u202C\u200F\u200F\u206F\u200E\u202C\u206B\u206E\u206F\u206A\u202B\u200F\u200E\u202A\u206A\u202A\u206A\u200C\u206E\u200D\u200B\u206B\u200B\u200F\u202A\u206B\u206D\u200F\u202E\u202E(CardMovingToDrawZoneEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u202C\u206B\u202B\u206B\u206C\u202E\u206C\u202D\u202B\u202C\u206F\u202D\u200E\u200B\u200D\u202B\u206E\u200F\u202A\u202A\u202C\u206F\u206D\u206C\u200F\u206A\u206D\u200B\u206B\u206D\u200B\u200F\u206F\u200D\u206D\u200B\u202A\u200B\u202A\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static Card \u206A\u206B\u202E\u200E\u206E\u200E\u202D\u206A\u206C\u202A\u206C\u202D\u206C\u206F\u202A\u202A\u200B\u202C\u206C\u202B\u206C\u202E\u200F\u202C\u206E\u206D\u206B\u200E\u200C\u206F\u200D\u202B\u202A\u206C\u200B\u206A\u202A\u202A\u202E\u206E\u202E(CardTransformEventArgs A_0)
			{
				return A_0.SourceCard;
			}

			IEnumerable<BattleAction> \u206F\u206D\u206F\u206E\u206A\u202D\u206A\u202B\u200F\u206D\u202E\u202B\u200B\u200D\u206B\u200F\u200E\u206A\u206F\u202A\u202B\u200B\u202C\u206E\u200F\u206D\u200C\u206F\u206B\u206F\u202A\u202E\u200D\u202D\u202D\u206C\u202A\u202C\u206D\u202E\u202E()
			{
				return base.AfterUseAction();
			}

			IEnumerable<BattleAction> \u200E\u202A\u200B\u202C\u202D\u206C\u206E\u206E\u200E\u206E\u200C\u206F\u200D\u206E\u202C\u202E\u200F\u206A\u200D\u202D\u206D\u202E\u206A\u200F\u200D\u206F\u206D\u202C\u202C\u200C\u200D\u202D\u200E\u200B\u202C\u202A\u206E\u206E\u200D\u206C\u202E()
			{
				return base.AfterFollowPlayAction();
			}
		}
	}
}
