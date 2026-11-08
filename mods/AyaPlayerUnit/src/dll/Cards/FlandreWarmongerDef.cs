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
using LBoL.Core.Units;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreWarmongerDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(107545111);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreWarmongerDef.\u202D\u200E\u202A\u206D\u200D\u200C\u202A\u200F\u200D\u202A\u200D\u202E\u200F\u206E\u202B\u200C\u206D\u206C\u200B\u200F\u206E\u206C\u200E\u200F\u200D\u200E\u202A\u202A\u206C\u202A\u202B\u206F\u200F\u202C\u200D\u206C\u200B\u206C\u206D\u200D\u202E(BepinexPlugin.embeddedSource);
			FlandreWarmongerDef.\u202B\u200E\u202B\u206C\u200B\u202D\u206F\u200F\u206F\u202A\u206B\u200F\u202D\u206B\u206F\u206F\u206D\u200E\u200B\u206D\u202A\u206B\u206B\u206B\u202C\u206F\u206C\u200C\u200C\u200F\u202A\u206F\u202B\u206B\u206F\u200D\u206D\u206F\u202C\u202D\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreWarmongerDef.\u206A\u206D\u206C\u206C\u200F\u200B\u200B\u200C\u206C\u200E\u200F\u206C\u200D\u200B\u206E\u202D\u206A\u200D\u206F\u202D\u202C\u206F\u206C\u200C\u206A\u206F\u200C\u202E\u202A\u200B\u200E\u200F\u200C\u206F\u206F\u202A\u202C\u202C\u202D\u206B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreWarmongerDef.\u206B\u206B\u202A\u200E\u200B\u200F\u202D\u206B\u202B\u202C\u206B\u200E\u206C\u206A\u202E\u200F\u200F\u202E\u202D\u200D\u202C\u202B\u206A\u200E\u200F\u206D\u206D\u206E\u200C\u206C\u206A\u200C\u206E\u206F\u202D\u200C\u206F\u206E\u200F\u206F\u202E(BepinexPlugin.sequenceTable, FlandreWarmongerDef.\u202B\u200E\u202C\u200D\u206C\u202B\u202E\u200D\u200B\u206B\u202D\u206D\u200F\u200C\u202C\u200C\u202A\u206A\u202D\u202A\u206C\u202E\u200B\u206D\u202C\u200C\u206B\u200B\u206E\u200E\u206A\u200D\u200D\u202A\u202A\u200E\u202A\u206D\u206E\u202E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, true, true, false, true, true, Rarity.Common, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Forbidden | Keyword.Replenish, Keyword.Forbidden | Keyword.Replenish, false, Keyword.None, Keyword.None, new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-208449429),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-538512116)
			}, new List<string>
			{
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1385709034),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-538512116)
			}, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-199622680), new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1120819459) });
		}

		static CardImages \u202D\u200E\u202A\u206D\u200D\u200C\u202A\u200F\u200D\u202A\u200D\u202E\u200F\u206E\u202B\u200C\u206D\u206C\u200B\u200F\u206E\u206C\u200E\u200F\u200D\u200E\u202A\u202A\u206C\u202A\u202B\u206F\u200F\u202C\u200D\u206C\u200B\u206C\u206D\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202B\u200E\u202B\u206C\u200B\u202D\u206F\u200F\u206F\u202A\u206B\u200F\u202D\u206B\u206F\u206F\u206D\u200E\u200B\u206D\u202A\u206B\u206B\u206B\u202C\u206F\u206C\u200C\u200C\u200F\u202A\u206F\u202B\u206B\u206F\u200D\u206D\u206F\u202C\u202D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u206D\u206C\u206C\u200F\u200B\u200B\u200C\u206C\u200E\u200F\u206C\u200D\u200B\u206E\u202D\u206A\u200D\u206F\u202D\u202C\u206F\u206C\u200C\u206A\u206F\u200C\u202E\u202A\u200B\u200E\u200F\u200C\u206F\u206F\u202A\u202C\u202C\u202D\u206B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202B\u200E\u202C\u200D\u206C\u202B\u202E\u200D\u200B\u206B\u202D\u206D\u200F\u200C\u202C\u200C\u202A\u206A\u202D\u202A\u206C\u202E\u200B\u206D\u202C\u200C\u206B\u200B\u206E\u200E\u206A\u200D\u200D\u202A\u202A\u200E\u202A\u206D\u206E\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u206B\u202A\u200E\u200B\u200F\u202D\u206B\u202B\u202C\u206B\u200E\u206C\u206A\u202E\u200F\u200F\u202E\u202D\u200D\u202C\u202B\u206A\u200E\u200F\u206D\u206D\u206E\u200C\u206C\u206A\u200C\u206E\u206F\u202D\u200C\u206F\u206E\u200F\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreWarmongerDef))]
		public sealed class FlandreWarmonger : FlandreCard
		{
			public override bool OnDrawVisual
			{
				get
				{
					return false;
				}
			}

			public override bool OnMoveVisual
			{
				get
				{
					return false;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreWarmongerDef.FlandreWarmonger.\u202A\u202C\u202B\u200F\u202D\u206C\u202C\u200D\u206C\u200B\u206D\u202E\u200B\u206B\u206C\u200C\u200B\u202C\u200F\u206E\u200C\u200F\u206A\u206C\u200D\u202A\u200E\u200D\u200F\u200B\u206B\u206C\u202D\u206A\u200E\u200F\u206D\u206D\u202E\u202C\u202E((float)FlandreWarmongerDef.FlandreWarmonger.\u206D\u206F\u200D\u206F\u200E\u202C\u206F\u206F\u200D\u202A\u200F\u202A\u202E\u206A\u206E\u206F\u206B\u206A\u206C\u206D\u202E\u202D\u200D\u202A\u200C\u202E\u200F\u200D\u206A\u200E\u202E\u202E\u200C\u200D\u206C\u202A\u202D\u200D\u202D\u206C\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int Amount
			{
				get
				{
					BattleController battleController = FlandreWarmongerDef.FlandreWarmonger.\u206A\u200B\u200C\u206C\u206F\u206B\u202B\u202E\u200F\u202E\u202C\u206C\u202C\u202C\u206D\u200B\u206A\u200E\u202C\u206A\u202C\u202D\u202D\u200D\u200B\u202B\u202C\u200E\u206B\u200E\u206A\u202A\u202C\u202C\u200E\u200B\u200F\u200E\u206F\u202E\u202E(this);
					return ((battleController != null) ? new int?(FlandreWarmongerDef.FlandreWarmonger.\u206A\u202C\u200D\u206F\u206E\u202E\u206D\u206F\u200F\u206B\u200F\u200D\u200B\u202C\u200E\u202A\u200E\u206E\u202E\u206C\u200F\u202D\u206B\u206E\u206F\u202A\u202A\u200B\u206B\u206C\u206B\u206F\u206C\u200D\u206E\u206D\u206B\u206C\u202E\u202E\u202E(battleController).Count<EnemyUnit>()) : null).GetValueOrDefault() * this.FlandreValue1;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				if (FlandreWarmongerDef.FlandreWarmonger.\u206C\u206F\u202A\u200B\u206F\u206C\u206C\u202B\u206B\u200F\u202A\u200F\u202A\u200E\u200F\u206D\u200C\u206B\u200D\u206B\u200D\u200C\u206D\u206F\u206E\u206E\u202D\u202B\u202A\u200F\u206E\u202E\u200E\u200E\u206E\u202E\u206D\u200C\u206F\u200C\u202E(this) == CardZone.Hand)
				{
					for (;;)
					{
						IL_0009:
						int num = -789695432;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(--1145408027 - num2 * -2033938031 * -379408611))) % 3U)
							{
							case 1U:
								base.React(this.OnEnterHand());
								num = (int)((num3 * 2970526719U) ^ 3176908573U);
								continue;
							case 2U:
								goto IL_0009;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			public override IEnumerable<BattleAction> OnDraw()
			{
				return this.OnEnterHand();
			}

			public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
			{
				if (dstZone != CardZone.Hand)
				{
					for (;;)
					{
						int num = -1480697930;
						switch (-((num + ~(2094849565 * -581205937 + (-1654836511 + -210053081)) + --184657830) ^ (-1539845174 + 701865942)) % 3)
						{
						case 1:
							goto IL_004F;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0060;
					IL_004F:
					return null;
				}
				IL_0060:
				return this.OnEnterHand();
			}

			private IEnumerable<BattleAction> OnEnterHand()
			{
				FlandreWarmongerDef.FlandreWarmonger.<OnEnterHand>d__11 <OnEnterHand>d__ = new FlandreWarmongerDef.FlandreWarmonger.<OnEnterHand>d__11(-2);
				<OnEnterHand>d__.<>4__this = this;
				return <OnEnterHand>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreWarmongerDef.FlandreWarmonger.<Actions>d__12 <Actions>d__ = new FlandreWarmongerDef.FlandreWarmonger.<Actions>d__12(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u206D\u206F\u200D\u206F\u200E\u202C\u206F\u206F\u200D\u202A\u200F\u202A\u202E\u206A\u206E\u206F\u206B\u206A\u206C\u206D\u202E\u202D\u200D\u202A\u200C\u202E\u200F\u200D\u206A\u200E\u202E\u202E\u200C\u200D\u206C\u202A\u202D\u200D\u202D\u206C\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202A\u202C\u202B\u200F\u202D\u206C\u202C\u200D\u206C\u200B\u206D\u202E\u200B\u206B\u206C\u200C\u200B\u202C\u200F\u206E\u200C\u200F\u206A\u206C\u200D\u202A\u200E\u200D\u200F\u200B\u206B\u206C\u202D\u206A\u200E\u200F\u206D\u206D\u202E\u202C\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			static BattleController \u206A\u200B\u200C\u206C\u206F\u206B\u202B\u202E\u200F\u202E\u202C\u206C\u202C\u202C\u206D\u200B\u206A\u200E\u202C\u206A\u202C\u202D\u202D\u200D\u200B\u202B\u202C\u200E\u206B\u200E\u206A\u202A\u202C\u202C\u200E\u200B\u200F\u200E\u206F\u202E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<EnemyUnit> \u206A\u202C\u200D\u206F\u206E\u202E\u206D\u206F\u200F\u206B\u200F\u200D\u200B\u202C\u200E\u202A\u200E\u206E\u202E\u206C\u200F\u202D\u206B\u206E\u206F\u202A\u202A\u200B\u206B\u206C\u206B\u206F\u206C\u200D\u206E\u206D\u206B\u206C\u202E\u202E\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static CardZone \u206C\u206F\u202A\u200B\u206F\u206C\u206C\u202B\u206B\u200F\u202A\u200F\u202A\u200E\u200F\u206D\u200C\u206B\u200D\u206B\u200D\u200C\u206D\u206F\u206E\u206E\u202D\u202B\u202A\u200F\u206E\u202E\u200E\u200E\u206E\u202E\u206D\u200C\u206F\u200C\u202E(Card A_0)
			{
				return A_0.Zone;
			}
		}
	}
}
