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
	public sealed class FlandreUltraViolenceDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1817852306);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreUltraViolenceDef.\u206E\u206E\u200D\u206A\u200E\u200D\u206C\u202E\u200C\u200C\u200D\u202E\u200C\u202C\u206D\u200C\u200F\u202B\u200F\u200C\u202A\u202E\u206A\u200E\u206D\u206C\u206D\u206C\u200D\u206C\u202B\u206F\u206E\u202A\u200E\u200B\u200D\u206A\u206E\u206A\u202E(BepinexPlugin.embeddedSource);
			FlandreUltraViolenceDef.\u200E\u200B\u206D\u200C\u202A\u202E\u206E\u206C\u202C\u206B\u206C\u202E\u206C\u202C\u202D\u202E\u202E\u206C\u200C\u202E\u206E\u206A\u202A\u200B\u202A\u206A\u200E\u202B\u202E\u202E\u202C\u202A\u200F\u200B\u206B\u206D\u206C\u206B\u200E\u202B\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreUltraViolenceDef.\u202D\u206B\u206A\u206D\u200C\u202C\u202B\u202B\u206A\u206C\u206F\u202C\u206E\u202A\u202C\u206B\u200C\u200E\u200C\u202E\u200B\u202E\u202C\u206F\u206F\u206A\u202E\u206E\u200E\u202A\u200F\u202D\u202B\u206D\u200E\u202C\u202C\u200E\u202D\u202C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreUltraViolenceDef.\u200D\u206B\u200F\u206A\u202E\u200C\u202A\u202E\u200B\u206A\u202E\u206F\u202C\u200D\u206F\u206B\u200F\u206A\u200F\u202A\u206A\u202C\u202D\u200F\u200B\u206A\u202B\u202E\u206E\u202A\u200F\u200D\u202E\u200C\u206E\u200E\u206B\u206A\u200C\u206A\u202E(BepinexPlugin.sequenceTable, FlandreUltraViolenceDef.\u206C\u200C\u200E\u202E\u202A\u200D\u202B\u206D\u202C\u200F\u206B\u202B\u206D\u200B\u206C\u206B\u202A\u200D\u206C\u200C\u200F\u200D\u206F\u200F\u200D\u200C\u202A\u200D\u200F\u202A\u202A\u206D\u200E\u202E\u206F\u206D\u200D\u202A\u202B\u202B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(742714273), 0, true, true, false, true, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.AllEnemies), new List<ManaColor> { ManaColor.Colorless }, false, new ManaGroup
			{
				Any = 3,
				Colorless = 1
			}, null, null, null, null, new int?(60), null, null, null, null, null, new int?(1), null, new int?(8), null, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy, Keyword.Accuracy, false, Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, Keyword.Exile | Keyword.Ethereal | Keyword.TempMorph, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1094826970),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1986435062)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2058402613),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(473367871)
			}, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-808117344), new List<string>());
		}

		static CardImages \u206E\u206E\u200D\u206A\u200E\u200D\u206C\u202E\u200C\u200C\u200D\u202E\u200C\u202C\u206D\u200C\u200F\u202B\u200F\u200C\u202A\u202E\u206A\u200E\u206D\u206C\u206D\u206C\u200D\u206C\u202B\u206F\u206E\u202A\u200E\u200B\u200D\u206A\u206E\u206A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200E\u200B\u206D\u200C\u202A\u202E\u206E\u206C\u202C\u206B\u206C\u202E\u206C\u202C\u202D\u202E\u202E\u206C\u200C\u202E\u206E\u206A\u202A\u200B\u202A\u206A\u200E\u202B\u202E\u202E\u202C\u202A\u200F\u200B\u206B\u206D\u206C\u206B\u200E\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202D\u206B\u206A\u206D\u200C\u202C\u202B\u202B\u206A\u206C\u206F\u202C\u206E\u202A\u202C\u206B\u200C\u200E\u200C\u202E\u200B\u202E\u202C\u206F\u206F\u206A\u202E\u206E\u200E\u202A\u200F\u202D\u202B\u206D\u200E\u202C\u202C\u200E\u202D\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u200C\u200E\u202E\u202A\u200D\u202B\u206D\u202C\u200F\u206B\u202B\u206D\u200B\u206C\u206B\u202A\u200D\u206C\u200C\u200F\u200D\u206F\u200F\u200D\u200C\u202A\u200D\u200F\u202A\u202A\u206D\u200E\u202E\u206F\u206D\u200D\u202A\u202B\u202B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206B\u200F\u206A\u202E\u200C\u202A\u202E\u200B\u206A\u202E\u206F\u202C\u200D\u206F\u206B\u200F\u206A\u200F\u202A\u206A\u202C\u202D\u200F\u200B\u206A\u202B\u202E\u206E\u202A\u200F\u200D\u202E\u200C\u206E\u200E\u206B\u206A\u200C\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreUltraViolenceDef))]
		public sealed class FlandreUltraViolence : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreUltraViolenceDef.FlandreUltraViolence.\u202C\u202B\u206F\u202B\u202A\u202B\u206E\u206E\u202B\u206F\u206B\u202C\u206E\u206C\u202B\u200B\u206B\u200F\u206F\u202A\u202E\u200F\u202D\u206F\u206D\u202C\u206C\u200E\u200C\u202A\u200B\u206D\u206F\u200E\u206F\u202D\u206D\u206B\u206B\u202E\u202E(this).GetValueOrDefault() * 20;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreUltraViolenceDef.FlandreUltraViolence.\u200E\u206D\u202A\u202C\u202A\u200F\u206D\u206A\u206C\u206B\u206A\u206D\u200B\u200F\u200C\u202E\u200C\u200F\u206D\u206A\u206C\u202A\u200E\u200E\u200D\u206B\u200E\u206D\u202C\u206B\u206F\u206B\u202A\u206B\u206D\u200C\u200C\u206B\u200E\u202C\u202E((float)FlandreUltraViolenceDef.FlandreUltraViolence.\u202C\u202B\u206F\u202B\u202A\u202B\u206E\u206E\u202B\u206F\u206B\u202C\u206E\u206C\u202B\u200B\u206B\u200F\u206F\u202A\u202E\u200F\u202D\u206F\u206D\u202C\u206C\u200E\u200C\u202A\u200B\u206D\u206F\u200E\u206F\u202D\u206D\u206B\u206B\u202E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			private string UltraViolence
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-598193048), true, true);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -604256450;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)(--1737632334 - ((num2 - -(2140231829 - (-1527996765 ^ 1037500074))) ^ ~(~-1078079363))))) % 3U)
						{
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 2780840954U) ^ 2928920951U);
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
				FlandreUltraViolenceDef.FlandreUltraViolence.<Actions>d__7 <Actions>d__ = new FlandreUltraViolenceDef.FlandreUltraViolence.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202C\u202B\u206F\u202B\u202A\u202B\u206E\u206E\u202B\u206F\u206B\u202C\u206E\u206C\u202B\u200B\u206B\u200F\u206F\u202A\u202E\u200F\u202D\u206F\u206D\u202C\u206C\u200E\u200C\u202A\u200B\u206D\u206F\u200E\u206F\u202D\u206D\u206B\u206B\u202E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200E\u206D\u202A\u202C\u202A\u200F\u206D\u206A\u206C\u206B\u206A\u206D\u200B\u200F\u200C\u202E\u200C\u200F\u206D\u206A\u206C\u202A\u200E\u200E\u200D\u206B\u200E\u206D\u202C\u206B\u206F\u206B\u202A\u206B\u206D\u200C\u200C\u206B\u200E\u202C\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}
		}
	}
}
