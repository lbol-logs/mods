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
	public sealed class FlandreUncontrollableBombDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1490325383);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreUncontrollableBombDef.\u206D\u202E\u202C\u206E\u202D\u202A\u200E\u202D\u200C\u202A\u206F\u202E\u200B\u206D\u206F\u200D\u200D\u200D\u206A\u206F\u206A\u202B\u200E\u200E\u200C\u206B\u206A\u206E\u200E\u200C\u206E\u200D\u202D\u200F\u200D\u206F\u202B\u206F\u202D\u202B\u202E(BepinexPlugin.embeddedSource);
			FlandreUncontrollableBombDef.\u206E\u206A\u202A\u206C\u200E\u206E\u206C\u206F\u200D\u200D\u202A\u200B\u202E\u202E\u206F\u200D\u200B\u200B\u200C\u206B\u206F\u200E\u206A\u200E\u200D\u202E\u202C\u200E\u206A\u200F\u206D\u200B\u202D\u206C\u202C\u206B\u206E\u202D\u202D\u200E\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreUncontrollableBombDef.\u200F\u206F\u200B\u206E\u206E\u200E\u202C\u206C\u206D\u202A\u206A\u200B\u206B\u200C\u202C\u200C\u206A\u206C\u200F\u202D\u202D\u202D\u202D\u206C\u206D\u206E\u202A\u202A\u200E\u206A\u202A\u206B\u206C\u206C\u202E\u202B\u206D\u200C\u202A\u202A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreUncontrollableBombDef.\u200C\u202E\u200E\u206F\u200B\u202D\u200F\u206B\u206F\u206E\u206C\u200E\u200B\u200E\u200C\u202B\u200B\u200C\u200F\u206A\u202A\u206F\u200C\u200F\u200E\u200B\u202A\u202C\u200D\u202C\u200D\u206A\u206C\u200D\u206C\u202A\u200D\u200D\u200F\u206F\u202E(BepinexPlugin.sequenceTable, FlandreUncontrollableBombDef.\u200F\u206F\u206F\u202B\u202A\u202E\u200C\u206C\u206D\u200F\u202B\u202C\u202A\u200D\u200D\u200B\u206A\u202B\u206A\u206D\u200C\u200C\u206C\u200C\u202E\u206E\u202C\u200D\u200E\u200D\u206B\u202B\u206C\u200C\u200D\u206B\u200C\u206E\u206D\u202A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(742714273), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Attack, new TargetType?(TargetType.All), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, new int?(50), null, null, null, null, null, new int?(10), null, new int?(2), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Gadgets | Keyword.Accuracy, Keyword.Gadgets | Keyword.Accuracy, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(536664057) }, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(536664057) }, new List<string>(), new List<string>(), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(33816810), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(527892818), new List<string>());
		}

		static CardImages \u206D\u202E\u202C\u206E\u202D\u202A\u200E\u202D\u200C\u202A\u206F\u202E\u200B\u206D\u206F\u200D\u200D\u200D\u206A\u206F\u206A\u202B\u200E\u200E\u200C\u206B\u206A\u206E\u200E\u200C\u206E\u200D\u202D\u200F\u200D\u206F\u202B\u206F\u202D\u202B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206E\u206A\u202A\u206C\u200E\u206E\u206C\u206F\u200D\u200D\u202A\u200B\u202E\u202E\u206F\u200D\u200B\u200B\u200C\u206B\u206F\u200E\u206A\u200E\u200D\u202E\u202C\u200E\u206A\u200F\u206D\u200B\u202D\u206C\u202C\u206B\u206E\u202D\u202D\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u206F\u200B\u206E\u206E\u200E\u202C\u206C\u206D\u202A\u206A\u200B\u206B\u200C\u202C\u200C\u206A\u206C\u200F\u202D\u202D\u202D\u202D\u206C\u206D\u206E\u202A\u202A\u200E\u206A\u202A\u206B\u206C\u206C\u202E\u202B\u206D\u200C\u202A\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200F\u206F\u206F\u202B\u202A\u202E\u200C\u206C\u206D\u200F\u202B\u202C\u202A\u200D\u200D\u200B\u206A\u202B\u206A\u206D\u200C\u200C\u206C\u200C\u202E\u206E\u202C\u200D\u200E\u200D\u206B\u202B\u206C\u200C\u200D\u206B\u200C\u206E\u206D\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u202E\u200E\u206F\u200B\u202D\u200F\u206B\u206F\u206E\u206C\u200E\u200B\u200E\u200C\u202B\u200B\u200C\u200F\u206A\u202A\u206F\u200C\u200F\u200E\u200B\u202A\u202C\u200D\u202C\u200D\u206A\u206C\u200D\u206C\u202A\u200D\u200D\u200F\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreUncontrollableBombDef))]
		public sealed class FlandreUncontrollableBomb : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreUncontrollableBombDef.FlandreUncontrollableBomb.\u200C\u200C\u202D\u206A\u206F\u206D\u200B\u202E\u206D\u202B\u200F\u206F\u200E\u202A\u206B\u200E\u202B\u206A\u200F\u200E\u202D\u202B\u206E\u206C\u206E\u200E\u200C\u200F\u206D\u206D\u206F\u202C\u200B\u202D\u200D\u202E\u206B\u206C\u202A\u206A\u202E(this).GetValueOrDefault() * 25;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreUncontrollableBombDef.FlandreUncontrollableBomb.\u200C\u200C\u202D\u206A\u206F\u206D\u200B\u202E\u206D\u202B\u200F\u206F\u200E\u202A\u206B\u200E\u202B\u206A\u200F\u200E\u202D\u202B\u206E\u206C\u206E\u200E\u200C\u200F\u206D\u206D\u206F\u202C\u200B\u202D\u200D\u202E\u206B\u206C\u202A\u206A\u202E(this).GetValueOrDefault();
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -2094240371;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((num2 ^ -(~-179963141 + (1909484423 ^ 1981178642))) + (-851618291 - 2078539236 - -1993481278 * -559149027)) * -1739484479)) % 3U)
						{
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 1713878761U) ^ 148973132U);
							continue;
						case 2U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreUncontrollableBombDef.FlandreUncontrollableBomb.<Actions>d__5 <Actions>d__ = new FlandreUncontrollableBombDef.FlandreUncontrollableBomb.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u200C\u200C\u202D\u206A\u206F\u206D\u200B\u202E\u206D\u202B\u200F\u206F\u200E\u202A\u206B\u200E\u202B\u206A\u200F\u200E\u202D\u202B\u206E\u206C\u206E\u200E\u200C\u200F\u206D\u206D\u206F\u202C\u200B\u202D\u200D\u202E\u206B\u206C\u202A\u206A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}
		}
	}
}
