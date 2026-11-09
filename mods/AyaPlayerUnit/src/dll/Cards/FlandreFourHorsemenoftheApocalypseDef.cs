using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreFourHorsemenoftheApocalypseDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1971934711);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFourHorsemenoftheApocalypseDef.\u200B\u200D\u200C\u206D\u202E\u202B\u202E\u200E\u206F\u206B\u200E\u200C\u202C\u202E\u206E\u202E\u202D\u202C\u206F\u206F\u202B\u200B\u206F\u200D\u206F\u202E\u206C\u202E\u200C\u202E\u206D\u206E\u200E\u206B\u202E\u202E\u202A\u200D\u202E\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreFourHorsemenoftheApocalypseDef.\u206D\u200F\u206B\u202C\u200C\u206F\u200F\u202A\u202E\u202D\u202C\u200E\u202A\u206F\u206A\u202A\u200E\u202A\u206E\u202B\u206E\u206F\u200D\u202B\u206B\u200E\u200E\u200B\u206E\u200D\u206B\u206A\u202C\u200C\u202A\u206B\u202D\u200E\u200D\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFourHorsemenoftheApocalypseDef.\u206B\u200B\u202D\u202C\u200B\u202E\u200B\u200C\u200F\u200B\u200D\u202E\u206E\u206B\u206C\u202A\u206B\u206F\u206D\u206C\u202A\u202B\u202B\u206C\u202B\u200B\u206A\u206B\u200E\u206C\u202E\u202A\u202C\u206B\u206D\u200B\u200C\u202E\u200C\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFourHorsemenoftheApocalypseDef.\u206F\u202B\u200D\u206C\u206A\u202E\u206E\u206B\u202C\u206F\u206E\u206B\u206C\u202B\u202A\u200F\u200E\u202A\u202B\u206D\u200E\u202B\u206B\u200D\u206B\u206D\u206C\u206C\u202C\u206F\u202E\u206D\u200F\u200E\u206B\u206D\u206D\u206F\u206A\u206C\u202E(BepinexPlugin.sequenceTable, FlandreFourHorsemenoftheApocalypseDef.\u200C\u206C\u200B\u206C\u200E\u200B\u200B\u206D\u206F\u202C\u206C\u202B\u206E\u206E\u202E\u206B\u206B\u202E\u206C\u200B\u206D\u206D\u202D\u202D\u200E\u206A\u202C\u200B\u202A\u206C\u200E\u202D\u200C\u202B\u202E\u206F\u202A\u200C\u202C\u200C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, true, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Blue = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(3), null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Plentiful, Keyword.Plentiful, false, Keyword.Ability | Keyword.Philosophy, Keyword.Ability | Keyword.Philosophy, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(462619751) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-200313178) }, new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-761942930), new List<string>());
		}

		static CardImages \u200B\u200D\u200C\u206D\u202E\u202B\u202E\u200E\u206F\u206B\u200E\u200C\u202C\u202E\u206E\u202E\u202D\u202C\u206F\u206F\u202B\u200B\u206F\u200D\u206F\u202E\u206C\u202E\u200C\u202E\u206D\u206E\u200E\u206B\u202E\u202E\u202A\u200D\u202E\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206D\u200F\u206B\u202C\u200C\u206F\u200F\u202A\u202E\u202D\u202C\u200E\u202A\u206F\u206A\u202A\u200E\u202A\u206E\u202B\u206E\u206F\u200D\u202B\u206B\u200E\u200E\u200B\u206E\u200D\u206B\u206A\u202C\u200C\u202A\u206B\u202D\u200E\u200D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206B\u200B\u202D\u202C\u200B\u202E\u200B\u200C\u200F\u200B\u200D\u202E\u206E\u206B\u206C\u202A\u206B\u206F\u206D\u206C\u202A\u202B\u202B\u206C\u202B\u200B\u206A\u206B\u200E\u206C\u202E\u202A\u202C\u206B\u206D\u200B\u200C\u202E\u200C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200C\u206C\u200B\u206C\u200E\u200B\u200B\u206D\u206F\u202C\u206C\u202B\u206E\u206E\u202E\u206B\u206B\u202E\u206C\u200B\u206D\u206D\u202D\u202D\u200E\u206A\u202C\u200B\u202A\u206C\u200E\u202D\u200C\u202B\u202E\u206F\u202A\u200C\u202C\u200C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u202B\u200D\u206C\u206A\u202E\u206E\u206B\u202C\u206F\u206E\u206B\u206C\u202B\u202A\u200F\u200E\u202A\u202B\u206D\u200E\u202B\u206B\u200D\u206B\u206D\u206C\u206C\u202C\u206F\u202E\u206D\u200F\u200E\u206B\u206D\u206D\u206F\u206A\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFourHorsemenoftheApocalypseDef))]
		public sealed class FlandreFourHorsemenoftheApocalypse : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u200F\u206D\u206D\u200C\u200C\u206B\u202E\u206A\u200D\u200F\u200E\u202A\u200F\u206F\u202E\u202C\u202E\u206E\u206C\u206D\u206B\u200D\u200B\u200D\u206B\u200D\u206D\u200E\u200D\u202A\u206B\u206D\u202C\u200C\u200E\u202A\u206C\u206E\u200E\u200D\u202E(this).GetValueOrDefault();
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u200F\u206D\u206D\u200C\u200C\u206B\u202E\u206A\u200D\u200F\u200E\u202A\u200F\u206F\u202E\u202C\u202E\u206E\u206C\u206D\u206B\u200D\u200B\u200D\u206B\u200D\u206D\u200E\u200D\u202A\u206B\u206D\u202C\u200C\u200E\u202A\u206C\u206E\u200E\u200D\u202E(this).GetValueOrDefault()
					};
				}
			}

			public override ManaGroup? PlentifulMana
			{
				get
				{
					return new ManaGroup?(this.FlandreMana);
				}
			}

			public override bool DiscardCard
			{
				get
				{
					return true;
				}
			}

			protected override string GetBaseDescription()
			{
				if (FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u202C\u202C\u202E\u206F\u206E\u202A\u200F\u200D\u200C\u202C\u206E\u200B\u200D\u206B\u206D\u202C\u206C\u202B\u206C\u200E\u202E\u206E\u200B\u202A\u206C\u202B\u200F\u206E\u200E\u200E\u206D\u206A\u202A\u206F\u206D\u200C\u202B\u206F\u200C\u202E\u202E(this))
				{
					for (;;)
					{
						int num = 1259253544;
						switch (-(~-169253789 - -(~num)) % 3)
						{
						case 1:
							goto IL_0030;
						case 2:
							continue;
						}
						break;
					}
					goto IL_0046;
					IL_0030:
					return base.ExtraDescription1;
				}
				IL_0046:
				return base.GetBaseDescription();
			}

			public override Interaction Precondition()
			{
				List<Card> list = (from c in FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u206C\u206A\u206E\u202D\u202C\u202D\u206E\u202C\u202D\u200F\u202E\u202B\u206E\u206F\u206E\u200F\u206B\u200E\u202E\u202E\u206C\u206C\u206E\u202A\u206D\u206E\u202B\u200D\u202D\u202B\u202D\u206E\u202D\u206E\u202A\u202C\u202E\u206D\u200C\u206B\u202E(FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u206E\u200F\u202E\u202A\u202C\u200D\u202A\u200B\u202B\u202A\u200F\u206B\u202B\u206C\u206D\u202A\u202E\u206D\u206F\u206D\u200F\u202A\u202E\u202E\u206B\u202E\u200C\u202D\u202C\u200F\u206C\u202D\u200C\u202B\u202C\u202E\u206F\u200C\u202D\u200E\u202E(this))
					where c != this
					select c).ToList<Card>();
				for (;;)
				{
					IL_0022:
					int num = -846856474;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-num2 * -753338707) * -870391359)) % 4U)
						{
						case 1U:
							num = (int)(((list.Count <= 0) ? 845994446U : 525551339U) ^ (num3 * 2932862174U));
							continue;
						case 2U:
							goto IL_0022;
						case 3U:
							goto IL_0074;
						}
						goto Block_1;
					}
				}
				Block_1:
				goto IL_0085;
				IL_0074:
				return null;
				IL_0085:
				return FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.\u206C\u206A\u200F\u200C\u206B\u206B\u206C\u200F\u206D\u206F\u200F\u200C\u200C\u202C\u202E\u206F\u206E\u206C\u200D\u206A\u206B\u206A\u206D\u200B\u206C\u206D\u206F\u200B\u206F\u206C\u206A\u202E\u200F\u206D\u206B\u206E\u206A\u202D\u200F\u200C\u202E(0, list.Count, list);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.<Actions>d__10 <Actions>d__ = new FlandreFourHorsemenoftheApocalypseDef.FlandreFourHorsemenoftheApocalypse.<Actions>d__10(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u200F\u206D\u206D\u200C\u200C\u206B\u202E\u206A\u200D\u200F\u200E\u202A\u200F\u206F\u202E\u202C\u202E\u206E\u206C\u206D\u206B\u200D\u200B\u200D\u206B\u200D\u206D\u200E\u200D\u202A\u206B\u206D\u202C\u200C\u200E\u202A\u206C\u206E\u200E\u200D\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static bool \u202C\u202C\u202E\u206F\u206E\u202A\u200F\u200D\u200C\u202C\u206E\u200B\u200D\u206B\u206D\u202C\u206C\u202B\u206C\u200E\u202E\u206E\u200B\u202A\u206C\u202B\u200F\u206E\u200E\u200E\u206D\u206A\u202A\u206F\u206D\u200C\u202B\u206F\u200C\u202E\u202E(Card A_0)
			{
				return A_0.PlentifulHappenThisTurn;
			}

			static BattleController \u206E\u200F\u202E\u202A\u202C\u200D\u202A\u200B\u202B\u202A\u200F\u206B\u202B\u206C\u206D\u202A\u202E\u206D\u206F\u206D\u200F\u202A\u202E\u202E\u206B\u202E\u200C\u202D\u202C\u200F\u206C\u202D\u200C\u202B\u202C\u202E\u206F\u200C\u202D\u200E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206C\u206A\u206E\u202D\u202C\u202D\u206E\u202C\u202D\u200F\u202E\u202B\u206E\u206F\u206E\u200F\u206B\u200E\u202E\u202E\u206C\u206C\u206E\u202A\u206D\u206E\u202B\u200D\u202D\u202B\u202D\u206E\u202D\u206E\u202A\u202C\u202E\u206D\u200C\u206B\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static SelectHandInteraction \u206C\u206A\u200F\u200C\u206B\u206B\u206C\u200F\u206D\u206F\u200F\u200C\u200C\u202C\u202E\u206F\u206E\u206C\u200D\u206A\u206B\u206A\u206D\u200B\u206C\u206D\u206F\u200B\u206F\u206C\u206A\u202E\u200F\u206D\u206B\u206E\u206A\u202D\u200F\u200C\u202E(int A_0, int A_1, IEnumerable<Card> A_2)
			{
				return new SelectHandInteraction(A_0, A_1, A_2);
			}
		}
	}
}
