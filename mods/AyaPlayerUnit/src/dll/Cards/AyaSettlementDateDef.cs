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
	public sealed class AyaSettlementDateDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(457432476);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaSettlementDateDef.\u202A\u206B\u200F\u206E\u206B\u202D\u206D\u206E\u200D\u206D\u200C\u206D\u206A\u206E\u206F\u206A\u200F\u200E\u202E\u200C\u202B\u206E\u202A\u200B\u206C\u202B\u202C\u206D\u206C\u202B\u202C\u200E\u206B\u202E\u200D\u202D\u202D\u202C\u206E\u202B\u202E(BepinexPlugin.embeddedSource);
			AyaSettlementDateDef.\u206C\u206C\u202D\u202E\u200B\u202C\u202C\u202C\u200D\u206C\u206A\u202B\u200E\u206C\u202C\u206C\u206B\u206A\u202D\u206A\u206A\u206A\u202D\u206C\u206B\u200E\u206C\u202C\u202D\u200D\u200D\u200F\u200C\u206B\u200F\u206C\u202A\u200B\u200F\u200E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaSettlementDateDef.\u206A\u206E\u202A\u200F\u200C\u202A\u206D\u202B\u200B\u202D\u206C\u206A\u200D\u200B\u200B\u206B\u200D\u206A\u202C\u202D\u202B\u206E\u206B\u200D\u202A\u202C\u206D\u206B\u206D\u206E\u202D\u200E\u206B\u206B\u200D\u200F\u206D\u202C\u200E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaSettlementDateDef.\u200C\u206D\u200B\u202C\u202C\u206A\u200D\u202A\u206D\u200C\u206A\u202E\u202C\u202C\u206A\u200B\u202B\u206B\u206A\u206C\u202A\u206E\u206F\u202E\u200B\u202C\u202B\u206A\u200D\u200D\u200B\u206B\u206A\u202C\u206E\u202C\u206A\u200D\u206C\u206F\u202E(BepinexPlugin.sequenceTable, AyaSettlementDateDef.\u206A\u200C\u200E\u200C\u200E\u202A\u200E\u202C\u202C\u206C\u202C\u206C\u206D\u200C\u202E\u206F\u202B\u202A\u202E\u202B\u202D\u202C\u200E\u206E\u202E\u200F\u206D\u202C\u200C\u202E\u202E\u206D\u202D\u202A\u202C\u206F\u202C\u200E\u200D\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, false, true, false, false, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, new int?(BepinexPlugin.AyaPhantasmMode.Value ? 2 : 3), new int?(BepinexPlugin.AyaPhantasmMode.Value ? 3 : 4), new int?(BepinexPlugin.AyaPhantasmMode.Value ? 20 : 30), new int?(BepinexPlugin.AyaPhantasmMode.Value ? 30 : 40), null, null, null, null, new int?(1), null, null, null, null, null, null, null, null, null, null, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish, Keyword.Ethereal | Keyword.Initial | Keyword.Replenish, false, Keyword.Misfortune | Keyword.Tool | Keyword.Exile, Keyword.Misfortune | Keyword.Tool | Keyword.Exile, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(536664057) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1634172600) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(539068496), new List<string>());
		}

		static CardImages \u202A\u206B\u200F\u206E\u206B\u202D\u206D\u206E\u200D\u206D\u200C\u206D\u206A\u206E\u206F\u206A\u200F\u200E\u202E\u200C\u202B\u206E\u202A\u200B\u206C\u202B\u202C\u206D\u206C\u202B\u202C\u200E\u206B\u202E\u200D\u202D\u202D\u202C\u206E\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u206C\u202D\u202E\u200B\u202C\u202C\u202C\u200D\u206C\u206A\u202B\u200E\u206C\u202C\u206C\u206B\u206A\u202D\u206A\u206A\u206A\u202D\u206C\u206B\u200E\u206C\u202C\u202D\u200D\u200D\u200F\u200C\u206B\u200F\u206C\u202A\u200B\u200F\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u206E\u202A\u200F\u200C\u202A\u206D\u202B\u200B\u202D\u206C\u206A\u200D\u200B\u200B\u206B\u200D\u206A\u202C\u202D\u202B\u206E\u206B\u200D\u202A\u202C\u206D\u206B\u206D\u206E\u202D\u200E\u206B\u206B\u200D\u200F\u206D\u202C\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u200C\u200E\u200C\u200E\u202A\u200E\u202C\u202C\u206C\u202C\u206C\u206D\u200C\u202E\u206F\u202B\u202A\u202E\u202B\u202D\u202C\u200E\u206E\u202E\u200F\u206D\u202C\u200C\u202E\u202E\u206D\u202D\u202A\u202C\u206F\u202C\u200E\u200D\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u206D\u200B\u202C\u202C\u206A\u200D\u202A\u206D\u200C\u206A\u202E\u202C\u202C\u206A\u200B\u202B\u206B\u206A\u206C\u202A\u206E\u206F\u202E\u200B\u202C\u202B\u206A\u200D\u200D\u200B\u206B\u206A\u202C\u206E\u202C\u206A\u200D\u206C\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaSettlementDateDef))]
		public sealed class AyaSettlementDate : Card
		{
			public override void Initialize()
			{
				this.\u200B\u200F\u200E\u202E\u200B\u200C\u200F\u206C\u200C\u200F\u202C\u200C\u202C\u206C\u202B\u206F\u200C\u200B\u206A\u200E\u200F\u200F\u206E\u202D\u200D\u200E\u202E\u200D\u200D\u202C\u200B\u206B\u206D\u200D\u206B\u206A\u206F\u202C\u202A\u206A\u202E();
				for (;;)
				{
					IL_0006:
					int num = -339508236;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(uint)((~(234276718 + -1400453668) - num2) ^ -(-1510735642 * 1574468975)))) % 3U)
						{
						case 0U:
							goto IL_0006;
						case 1U:
							AyaSettlementDateDef.AyaSettlementDate.\u200D\u206D\u202C\u206B\u206B\u200E\u202D\u206A\u206A\u200F\u200B\u202C\u206C\u202A\u202C\u206E\u206B\u206F\u202C\u206B\u200D\u206F\u206B\u200C\u206E\u206C\u202D\u200C\u206D\u202D\u202D\u202E\u206D\u200E\u200C\u202A\u206B\u206A\u202A\u202C\u202E(this, new int?(0));
							num = (int)((num3 * 1217011256U) ^ 1727619592U);
							continue;
						}
						return;
					}
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return AyaSettlementDateDef.AyaSettlementDate.\u206B\u206B\u200D\u202E\u202D\u206D\u206D\u200E\u206A\u206C\u200C\u206A\u202A\u206A\u206F\u202C\u202C\u200E\u200E\u206D\u202D\u206F\u202C\u206F\u206F\u206E\u206E\u200F\u206F\u206D\u200C\u206A\u202E\u200F\u200C\u206D\u206B\u202E\u202D\u202A\u202E(this).Value;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<CardEventArgs>(AyaSettlementDateDef.AyaSettlementDate.\u206D\u200B\u200E\u202B\u206A\u200B\u202D\u206C\u206B\u200F\u200E\u200D\u206B\u200C\u200E\u202D\u200C\u200D\u202E\u206A\u206C\u202A\u206A\u206E\u200B\u206A\u202E\u200C\u202C\u206B\u206E\u206D\u202A\u206C\u206F\u206F\u202D\u206F\u200D\u200D\u202E(AyaSettlementDateDef.AyaSettlementDate.\u206F\u206B\u200D\u200E\u200F\u202B\u200C\u206C\u206A\u200C\u200C\u202B\u202C\u202C\u200F\u202D\u202E\u202D\u206A\u202D\u200D\u206D\u206C\u206A\u206B\u200C\u202B\u206F\u202A\u200F\u206E\u206F\u206B\u200B\u202D\u206E\u206C\u202B\u202E\u202A\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
			}

			private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
			{
				AyaSettlementDateDef.AyaSettlementDate.<OnCardExiled>d__4 <OnCardExiled>d__ = new AyaSettlementDateDef.AyaSettlementDate.<OnCardExiled>d__4(-2);
				<OnCardExiled>d__.<>4__this = this;
				<OnCardExiled>d__.<>3__args = args;
				return <OnCardExiled>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaSettlementDateDef.AyaSettlementDate.<Actions>d__5 <Actions>d__ = new AyaSettlementDateDef.AyaSettlementDate.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				AyaSettlementDateDef.AyaSettlementDate.<AfterUseAction>d__6 <AfterUseAction>d__ = new AyaSettlementDateDef.AyaSettlementDate.<AfterUseAction>d__6(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			void \u200B\u200F\u200E\u202E\u200B\u200C\u200F\u206C\u200C\u200F\u202C\u200C\u202C\u206C\u202B\u206F\u200C\u200B\u206A\u200E\u200F\u200F\u206E\u202D\u200D\u200E\u202E\u200D\u200D\u202C\u200B\u206B\u206D\u200D\u206B\u206A\u206F\u202C\u202A\u206A\u202E()
			{
				base.Initialize();
			}

			static void \u200D\u206D\u202C\u206B\u206B\u200E\u202D\u206A\u206A\u200F\u200B\u202C\u206C\u202A\u202C\u206E\u206B\u206F\u202C\u206B\u200D\u206F\u206B\u200C\u206E\u206C\u202D\u200C\u206D\u202D\u202D\u202E\u206D\u200E\u200C\u202A\u206B\u206A\u202A\u202C\u202E(Card A_0, int? A_1)
			{
				A_0.DeckCounter = A_1;
			}

			static int? \u206B\u206B\u200D\u202E\u202D\u206D\u206D\u200E\u206A\u206C\u200C\u206A\u202A\u206A\u206F\u202C\u202C\u200E\u200E\u206D\u202D\u206F\u202C\u206F\u206F\u206E\u206E\u200F\u206F\u206D\u200C\u206A\u202E\u200F\u200C\u206D\u206B\u202E\u202D\u202A\u202E(Card A_0)
			{
				return A_0.DeckCounter;
			}

			static BattleController \u206F\u206B\u200D\u200E\u200F\u202B\u200C\u206C\u206A\u200C\u200C\u202B\u202C\u202C\u200F\u202D\u202E\u202D\u206A\u202D\u200D\u206D\u206C\u206A\u206B\u200C\u202B\u206F\u202A\u200F\u206E\u206F\u206B\u200B\u202D\u206E\u206C\u202B\u202E\u202A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardEventArgs> \u206D\u200B\u200E\u202B\u206A\u200B\u202D\u206C\u206B\u200F\u200E\u200D\u206B\u200C\u200E\u202D\u200C\u200D\u202E\u206A\u206C\u202A\u206A\u206E\u200B\u206A\u202E\u200C\u202C\u206B\u206E\u206D\u202A\u206C\u206F\u206F\u202D\u206F\u200D\u200D\u202E(BattleController A_0)
			{
				return A_0.CardExiled;
			}
		}
	}
}
