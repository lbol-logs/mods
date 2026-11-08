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
	public sealed class FlandreScarletCasinoDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-228078017);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreScarletCasinoDef.\u206A\u200B\u202E\u202A\u206A\u206E\u200F\u200F\u202B\u206F\u206B\u202D\u200E\u206A\u206F\u206A\u200B\u200F\u200F\u206A\u206D\u202C\u202E\u206B\u206A\u206D\u200E\u202E\u200B\u206C\u200C\u206A\u200E\u202D\u206B\u202E\u202C\u202E\u206F\u202A\u202E(BepinexPlugin.embeddedSource);
			FlandreScarletCasinoDef.\u202E\u200D\u202C\u202A\u200D\u206E\u206F\u206F\u200F\u202B\u206E\u206A\u206D\u206F\u206B\u200F\u200D\u206E\u200C\u206A\u200F\u200D\u200C\u202E\u206D\u202B\u202D\u200E\u200D\u200E\u200B\u200B\u206D\u206B\u206D\u200F\u206C\u206E\u202D\u200E\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreScarletCasinoDef.\u202C\u200C\u200E\u206D\u206C\u202B\u206C\u200C\u206E\u202C\u206E\u206C\u202D\u202D\u206D\u200F\u202D\u200E\u202B\u206F\u206E\u206D\u200C\u206E\u202C\u206A\u200D\u202D\u206D\u202B\u202C\u200D\u206A\u202E\u200F\u200D\u202B\u206A\u202D\u206A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreScarletCasinoDef.\u206D\u200B\u206C\u206B\u202A\u206E\u206A\u202E\u202C\u202B\u206C\u206A\u202C\u200C\u206F\u202E\u202D\u206B\u200B\u202E\u206D\u206A\u206A\u206A\u206F\u200B\u200F\u202B\u202A\u200D\u206B\u206E\u206F\u206B\u200F\u200F\u200F\u200F\u200F\u200E\u202E(BepinexPlugin.sequenceTable, FlandreScarletCasinoDef.\u200B\u202C\u202A\u200B\u206E\u206B\u200B\u206D\u206F\u200E\u202A\u206A\u206F\u206B\u202E\u206B\u200F\u202C\u200F\u202C\u200E\u202B\u200C\u200F\u206F\u206C\u206C\u206B\u200F\u200F\u206F\u206E\u200F\u200D\u206E\u206F\u200F\u200F\u206E\u206C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, true, true, false, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, new int?(6), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Gadgets, Keyword.Gadgets, false, Keyword.Philosophy | Keyword.Upgrade | Keyword.Battlefield, Keyword.Philosophy | Keyword.Upgrade | Keyword.Battlefield, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(291257164), new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1240639393) });
		}

		static CardImages \u206A\u200B\u202E\u202A\u206A\u206E\u200F\u200F\u202B\u206F\u206B\u202D\u200E\u206A\u206F\u206A\u200B\u200F\u200F\u206A\u206D\u202C\u202E\u206B\u206A\u206D\u200E\u202E\u200B\u206C\u200C\u206A\u200E\u202D\u206B\u202E\u202C\u202E\u206F\u202A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u200D\u202C\u202A\u200D\u206E\u206F\u206F\u200F\u202B\u206E\u206A\u206D\u206F\u206B\u200F\u200D\u206E\u200C\u206A\u200F\u200D\u200C\u202E\u206D\u202B\u202D\u200E\u200D\u200E\u200B\u200B\u206D\u206B\u206D\u200F\u206C\u206E\u202D\u200E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202C\u200C\u200E\u206D\u206C\u202B\u206C\u200C\u206E\u202C\u206E\u206C\u202D\u202D\u206D\u200F\u202D\u200E\u202B\u206F\u206E\u206D\u200C\u206E\u202C\u206A\u200D\u202D\u206D\u202B\u202C\u200D\u206A\u202E\u200F\u200D\u202B\u206A\u202D\u206A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u202C\u202A\u200B\u206E\u206B\u200B\u206D\u206F\u200E\u202A\u206A\u206F\u206B\u202E\u206B\u200F\u202C\u200F\u202C\u200E\u202B\u200C\u200F\u206F\u206C\u206C\u206B\u200F\u200F\u206F\u206E\u200F\u200D\u206E\u206F\u200F\u200F\u206E\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u200B\u206C\u206B\u202A\u206E\u206A\u202E\u202C\u202B\u206C\u206A\u202C\u200C\u206F\u202E\u202D\u206B\u200B\u202E\u206D\u206A\u206A\u206A\u206F\u200B\u200F\u202B\u202A\u200D\u206B\u206E\u206F\u206B\u200F\u200F\u200F\u200F\u200F\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreScarletCasinoDef))]
		public sealed class FlandreScarletCasino : FlandreCard
		{
			public int Value4
			{
				get
				{
					return 4;
				}
			}

			public int Value5
			{
				get
				{
					return 1 + FlandreScarletCasinoDef.FlandreScarletCasino.\u206D\u202A\u206B\u200E\u200D\u202B\u206A\u206E\u200C\u206A\u202A\u200D\u202E\u206F\u206D\u200E\u200F\u202E\u200B\u206A\u206B\u206C\u200B\u202D\u200D\u206A\u200F\u206B\u200D\u200D\u202A\u206B\u200F\u202A\u206C\u202B\u206A\u200B\u202A\u206D\u202E((float)FlandreScarletCasinoDef.FlandreScarletCasino.\u200E\u206D\u200B\u206D\u202D\u206C\u202A\u202C\u200D\u200F\u206F\u206D\u200B\u200E\u200C\u200F\u202D\u200E\u206A\u206D\u206A\u200B\u202A\u202D\u202E\u202D\u200F\u200E\u200C\u202E\u206C\u200B\u206D\u202E\u206B\u206C\u206D\u202A\u200E\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public ManaGroup Amount1
			{
				get
				{
					return ManaGroup.Anys(base.FlandreModifier(this.Value5, true));
				}
			}

			public int Amount2
			{
				get
				{
					return base.FlandreModifier(this.Value5, true) * 2;
				}
			}

			public int Amount3
			{
				get
				{
					return base.FlandreModifier(this.Value5, true) * 3;
				}
			}

			public int Amount4
			{
				get
				{
					return base.FlandreModifier(this.Value5, true) * 4;
				}
			}

			public ManaGroup Amount5
			{
				get
				{
					return ManaGroup.Philosophies(base.FlandreModifier(this.Value5, true) * 5);
				}
			}

			public int Amount6
			{
				get
				{
					return base.FlandreModifier(this.Value5, true) * 60;
				}
			}

			public string ScarletCasino1Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(658503339), true, true);
				}
			}

			public string ScarletCasino2Flandre
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-4821915), true, true);
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreScarletCasinoDef.FlandreScarletCasino.<Actions>d__21 <Actions>d__ = new FlandreScarletCasinoDef.FlandreScarletCasino.<Actions>d__21(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u200E\u206D\u200B\u206D\u202D\u206C\u202A\u202C\u200D\u200F\u206F\u206D\u200B\u200E\u200C\u200F\u202D\u200E\u206A\u206D\u206A\u200B\u202A\u202D\u202E\u202D\u200F\u200E\u200C\u202E\u206C\u200B\u206D\u202E\u206B\u206C\u206D\u202A\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u206D\u202A\u206B\u200E\u200D\u202B\u206A\u206E\u200C\u206A\u202A\u200D\u202E\u206F\u206D\u200E\u200F\u202E\u200B\u206A\u206B\u206C\u200B\u202D\u200D\u206A\u200F\u206B\u200D\u200D\u202A\u206B\u200F\u202A\u206C\u202B\u206A\u200B\u202A\u206D\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			public static bool MusicChanged;
		}
	}
}
