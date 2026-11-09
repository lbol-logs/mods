using System;
using System.Collections.Generic;
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
	public sealed class FlandreSuperhumanCatastrophePilgrimageDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-656911232);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreSuperhumanCatastrophePilgrimageDef.\u200E\u206C\u200D\u206F\u202A\u200C\u202D\u206C\u206A\u202B\u202C\u200F\u200E\u200D\u202A\u200B\u202B\u202B\u200E\u200E\u202B\u200D\u206C\u206B\u200D\u200B\u202B\u200C\u200D\u200E\u202D\u202B\u202E\u200E\u200F\u202B\u206C\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreSuperhumanCatastrophePilgrimageDef.\u206B\u202C\u206E\u202C\u202D\u200D\u200F\u200C\u206C\u202E\u206E\u206D\u202B\u206B\u206B\u202E\u206E\u206D\u200E\u202A\u200C\u202D\u200D\u202C\u206A\u200E\u206B\u202E\u202A\u200B\u202D\u206C\u206B\u202D\u200C\u202B\u206F\u206D\u200D\u206A\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreSuperhumanCatastrophePilgrimageDef.\u200C\u206B\u202D\u202E\u200D\u206A\u202E\u206B\u206F\u200E\u206D\u200D\u200D\u202B\u200C\u206F\u202B\u206E\u206D\u200C\u200F\u206A\u200E\u200D\u202C\u200F\u202E\u202D\u206C\u206B\u206B\u202B\u206F\u202B\u202D\u202C\u202D\u206D\u202D\u200D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreSuperhumanCatastrophePilgrimageDef.\u206F\u200B\u206B\u202B\u202E\u206E\u206A\u202C\u202B\u202C\u206F\u200F\u206D\u200D\u200B\u202B\u206D\u202B\u206B\u206C\u200F\u200E\u202C\u202B\u206E\u206F\u200F\u202A\u202C\u206F\u200D\u202A\u206D\u200E\u202A\u202B\u206D\u206F\u200F\u200D\u202E(BepinexPlugin.sequenceTable, FlandreSuperhumanCatastrophePilgrimageDef.\u206A\u202D\u200E\u202E\u200B\u202A\u202D\u202B\u200C\u202E\u200F\u200C\u202C\u202E\u200F\u206B\u200C\u206E\u202D\u200B\u206C\u206E\u206A\u200C\u202B\u200C\u200E\u200B\u200D\u206C\u206A\u206A\u206E\u200C\u202E\u200B\u200B\u202E\u206F\u202C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, true, true, false, true, true, Rarity.Rare, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Any = 1,
				Black = 2
			}, null, null, null, null, null, null, null, null, null, null, new int?(2), null, new int?(1), null, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.None, false, Keyword.Ability | Keyword.Ethereal | Keyword.TempMorph, Keyword.Ability | Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1804336317), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-225799969), new List<string>());
		}

		static CardImages \u200E\u206C\u200D\u206F\u202A\u200C\u202D\u206C\u206A\u202B\u202C\u200F\u200E\u200D\u202A\u200B\u202B\u202B\u200E\u200E\u202B\u200D\u206C\u206B\u200D\u200B\u202B\u200C\u200D\u200E\u202D\u202B\u202E\u200E\u200F\u202B\u206C\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u202C\u206E\u202C\u202D\u200D\u200F\u200C\u206C\u202E\u206E\u206D\u202B\u206B\u206B\u202E\u206E\u206D\u200E\u202A\u200C\u202D\u200D\u202C\u206A\u200E\u206B\u202E\u202A\u200B\u202D\u206C\u206B\u202D\u200C\u202B\u206F\u206D\u200D\u206A\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200C\u206B\u202D\u202E\u200D\u206A\u202E\u206B\u206F\u200E\u206D\u200D\u200D\u202B\u200C\u206F\u202B\u206E\u206D\u200C\u200F\u206A\u200E\u200D\u202C\u200F\u202E\u202D\u206C\u206B\u206B\u202B\u206F\u202B\u202D\u202C\u202D\u206D\u202D\u200D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u202D\u200E\u202E\u200B\u202A\u202D\u202B\u200C\u202E\u200F\u200C\u202C\u202E\u200F\u206B\u200C\u206E\u202D\u200B\u206C\u206E\u206A\u200C\u202B\u200C\u200E\u200B\u200D\u206C\u206A\u206A\u206E\u200C\u202E\u200B\u200B\u202E\u206F\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u200B\u206B\u202B\u202E\u206E\u206A\u202C\u202B\u202C\u206F\u200F\u206D\u200D\u200B\u202B\u206D\u202B\u206B\u206C\u200F\u200E\u202C\u202B\u206E\u206F\u200F\u202A\u202C\u206F\u200D\u202A\u206D\u200E\u202A\u202B\u206D\u206F\u200F\u200D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreSuperhumanCatastrophePilgrimageDef))]
		public sealed class FlandreSuperhumanCatastrophePilgrimage : FlandreCard
		{
			public override int AdditionalValue2
			{
				get
				{
					return FlandreSuperhumanCatastrophePilgrimageDef.FlandreSuperhumanCatastrophePilgrimage.\u206B\u200C\u206D\u202D\u206C\u202C\u206F\u200C\u206D\u206C\u206C\u200D\u200C\u200C\u200F\u200C\u200F\u200D\u202E\u206A\u202C\u200B\u206D\u202B\u200C\u202E\u200C\u202D\u206B\u200C\u202D\u206F\u206C\u202A\u206D\u200D\u200F\u206B\u200C\u202C\u202E((float)FlandreSuperhumanCatastrophePilgrimageDef.FlandreSuperhumanCatastrophePilgrimage.\u202D\u206D\u206F\u206F\u206A\u206E\u200C\u200E\u200D\u202C\u200F\u206D\u200C\u206A\u206D\u200D\u200C\u202A\u206B\u206E\u206B\u206B\u206F\u200B\u206A\u202C\u200F\u206E\u202B\u200E\u202C\u206E\u200C\u200D\u206B\u202A\u202C\u202C\u206E\u206F\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 1798231948;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(num2 ^ ((1348512169 ^ -317400498) * -1971455277 + ~(~1810054530)) ^ ~(1983918409 + -2122711426)) * 311214939)) % 5U)
						{
						case 0U:
							base.OfferingCount = FlandreSuperhumanCatastrophePilgrimageDef.FlandreSuperhumanCatastrophePilgrimage.\u202B\u200B\u202A\u206F\u202B\u200C\u200F\u202E\u200E\u206A\u202B\u200D\u206C\u200F\u206A\u200E\u200B\u200F\u200C\u206A\u202B\u202A\u202C\u206F\u206C\u206C\u206A\u202D\u206D\u202E\u202A\u200F\u206D\u200F\u202C\u200F\u200B\u202E\u202C\u200D\u202E(this);
							num = (int)((num3 * 4230284770U) ^ 2472928917U);
							continue;
						case 2U:
							base.IsRandom = true;
							num = (int)((num3 * 3628941457U) ^ 4134694304U);
							continue;
						case 3U:
							goto IL_0006;
						case 4U:
							base.IsOffering = true;
							num = (int)((num3 * 615859671U) ^ 2683684873U);
							continue;
						}
						return;
					}
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreSuperhumanCatastrophePilgrimageDef.FlandreSuperhumanCatastrophePilgrimage.<Actions>d__3 <Actions>d__ = new FlandreSuperhumanCatastrophePilgrimageDef.FlandreSuperhumanCatastrophePilgrimage.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202D\u206D\u206F\u206F\u206A\u206E\u200C\u200E\u200D\u202C\u200F\u206D\u200C\u206A\u206D\u200D\u200C\u202A\u206B\u206E\u206B\u206B\u206F\u200B\u206A\u202C\u200F\u206E\u202B\u200E\u202C\u206E\u200C\u200D\u206B\u202A\u202C\u202C\u206E\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206B\u200C\u206D\u202D\u206C\u202C\u206F\u200C\u206D\u206C\u206C\u200D\u200C\u200C\u200F\u200C\u200F\u200D\u202E\u206A\u202C\u200B\u206D\u202B\u200C\u202E\u200C\u202D\u206B\u200C\u202D\u206F\u206C\u202A\u206D\u200D\u200F\u206B\u200C\u202C\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static int \u202B\u200B\u202A\u206F\u202B\u200C\u200F\u202E\u200E\u206A\u202B\u200D\u206C\u200F\u206A\u200E\u200B\u200F\u200C\u206A\u202B\u202A\u202C\u206F\u206C\u206C\u206A\u202D\u206D\u202E\u202A\u200F\u206D\u200F\u202C\u200F\u200B\u202E\u202C\u200D\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static string \u202D\u202A\u202A\u202A\u206A\u200D\u202D\u206E\u202D\u200D\u202D\u206D\u206A\u206B\u206C\u202C\u206F\u206D\u206A\u200F\u200C\u202B\u206C\u202A\u206B\u202B\u206B\u206A\u202A\u206B\u202E\u206A\u200B\u206C\u200D\u206B\u206F\u202C\u206C\u206D\u202E(CardConfig A_0)
			{
				return A_0.Id;
			}

			static string \u202B\u206C\u200F\u202E\u202D\u202E\u200C\u206D\u206B\u206F\u200E\u206B\u206E\u200F\u202D\u202D\u202C\u200E\u206E\u200E\u206D\u206C\u206B\u206D\u200D\u206B\u202A\u206A\u202B\u200D\u206F\u202A\u202D\u200E\u202B\u202E\u206B\u206F\u206C\u200E\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static bool \u206C\u202E\u200D\u200B\u202B\u206F\u200F\u202E\u206A\u206B\u206A\u206F\u206C\u206A\u202D\u206B\u206D\u206C\u202A\u206D\u202A\u200E\u202C\u202A\u200F\u206D\u206B\u202A\u202D\u200B\u202D\u206E\u206E\u200E\u206F\u202D\u200E\u206F\u202B\u202E(string A_0, string A_1)
			{
				return A_0 != A_1;
			}
		}
	}
}
