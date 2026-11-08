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
	public sealed class AyaEffortlessFlightDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(150176256);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaEffortlessFlightDef.\u206E\u206D\u202D\u202C\u200B\u206A\u202D\u202D\u202D\u202D\u200C\u200B\u202D\u202A\u206E\u200E\u202D\u202B\u206D\u202A\u200C\u202D\u206D\u206A\u200C\u206E\u206C\u202B\u206D\u202D\u206F\u206C\u206A\u200D\u200C\u206F\u206A\u200D\u200D\u202E\u202E(BepinexPlugin.embeddedSource);
			AyaEffortlessFlightDef.\u206C\u202B\u200B\u202D\u206D\u202A\u206D\u200F\u202C\u200C\u206B\u206C\u202C\u200F\u206B\u200E\u202E\u206B\u202C\u200F\u202D\u206F\u206B\u202B\u202B\u206C\u200D\u200C\u200E\u202A\u206E\u206E\u200B\u206C\u202B\u202B\u206A\u206B\u206B\u202E\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaEffortlessFlightDef.\u200F\u202D\u202C\u206E\u202A\u202A\u202E\u200D\u206C\u206C\u200F\u200C\u202A\u206A\u206B\u202C\u200B\u206B\u206E\u206D\u200B\u206E\u202B\u202D\u202B\u200C\u202E\u206C\u200D\u200F\u206C\u202B\u206E\u202C\u200C\u206F\u206A\u200E\u200C\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaEffortlessFlightDef.\u200F\u200D\u200B\u202C\u206F\u206B\u206C\u206B\u202D\u200F\u202C\u206F\u206C\u206A\u202C\u206F\u206C\u202C\u200E\u206B\u202B\u206E\u200E\u200E\u206A\u202A\u202B\u202B\u206B\u200C\u206C\u206B\u206D\u206E\u202C\u206D\u206E\u206D\u202C\u202D\u202E(BepinexPlugin.sequenceTable, AyaEffortlessFlightDef.\u206F\u206B\u200F\u206F\u206C\u200E\u206D\u206B\u206B\u202D\u200F\u206F\u200B\u202E\u206C\u200D\u202C\u202B\u202D\u202B\u202A\u202D\u202C\u206C\u202B\u200C\u202E\u206B\u200C\u202D\u206C\u206D\u206C\u200B\u206A\u200B\u200E\u206C\u202C\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Any = 1,
				Red = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(2), new int?(3), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(670345186) }, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(960223416) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-276090177), new List<string>());
		}

		static CardImages \u206E\u206D\u202D\u202C\u200B\u206A\u202D\u202D\u202D\u202D\u200C\u200B\u202D\u202A\u206E\u200E\u202D\u202B\u206D\u202A\u200C\u202D\u206D\u206A\u200C\u206E\u206C\u202B\u206D\u202D\u206F\u206C\u206A\u200D\u200C\u206F\u206A\u200D\u200D\u202E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206C\u202B\u200B\u202D\u206D\u202A\u206D\u200F\u202C\u200C\u206B\u206C\u202C\u200F\u206B\u200E\u202E\u206B\u202C\u200F\u202D\u206F\u206B\u202B\u202B\u206C\u200D\u200C\u200E\u202A\u206E\u206E\u200B\u206C\u202B\u202B\u206A\u206B\u206B\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u202D\u202C\u206E\u202A\u202A\u202E\u200D\u206C\u206C\u200F\u200C\u202A\u206A\u206B\u202C\u200B\u206B\u206E\u206D\u200B\u206E\u202B\u202D\u202B\u200C\u202E\u206C\u200D\u200F\u206C\u202B\u206E\u202C\u200C\u206F\u206A\u200E\u200C\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206F\u206B\u200F\u206F\u206C\u200E\u206D\u206B\u206B\u202D\u200F\u206F\u200B\u202E\u206C\u200D\u202C\u202B\u202D\u202B\u202A\u202D\u202C\u206C\u202B\u200C\u202E\u206B\u200C\u202D\u206C\u206D\u206C\u200B\u206A\u200B\u200E\u206C\u202C\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u200D\u200B\u202C\u206F\u206B\u206C\u206B\u202D\u200F\u202C\u206F\u206C\u206A\u202C\u206F\u206C\u202C\u200E\u206B\u202B\u206E\u200E\u200E\u206A\u202A\u202B\u202B\u206B\u200C\u206C\u206B\u206D\u206E\u202C\u206D\u206E\u206D\u202C\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaEffortlessFlightDef))]
		public sealed class AyaEffortlessFlight : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1803702677), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-561002541), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_0085;
				}
				IL_000C:
				int num = 236836296;
				IL_0011:
				int num2 = num;
				switch (~((1207927619 * (2132574623 * -713769931) + (1551408889 * 936692671 + (695307514 - -1329451498)) - num2) * -789039871 + -1131738157 * 1077514624) % 5)
				{
				case 0:
					return this.PhantasmModeDescription;
				case 1:
					return base.GetBaseDescription();
				case 3:
					goto IL_000C;
				case 4:
					IL_0085:
					num = (AyaEffortlessFlightDef.AyaEffortlessFlight.\u200C\u206B\u202C\u200D\u200B\u202A\u202D\u206C\u202A\u206B\u200C\u202A\u202A\u202E\u202C\u202C\u200D\u206E\u206C\u202C\u202A\u206A\u200E\u206F\u200C\u200E\u206E\u200B\u206F\u202A\u206F\u206A\u206E\u206C\u200D\u200B\u200F\u206D\u202D\u202E\u202E(this) ? (-1332203238) : (-1862277903));
					goto IL_0011;
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaEffortlessFlightDef.AyaEffortlessFlight.<Actions>d__5 <Actions>d__ = new AyaEffortlessFlightDef.AyaEffortlessFlight.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u200C\u206B\u202C\u200D\u200B\u202A\u202D\u206C\u202A\u206B\u200C\u202A\u202A\u202E\u202C\u202C\u200D\u206E\u206C\u202C\u202A\u206A\u200E\u206F\u200C\u200E\u206E\u200B\u206F\u202A\u206F\u206A\u206E\u206C\u200D\u200B\u200F\u206D\u202D\u202E\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
