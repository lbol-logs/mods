using System;
using System.Collections.Generic;
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
	public sealed class FlandreInternetSurvivorDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-721655146);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreInternetSurvivorDef.\u206E\u202E\u202D\u202E\u200F\u200E\u206D\u200C\u202E\u202D\u200B\u200B\u206D\u206E\u202A\u206C\u200D\u206E\u202D\u202B\u202C\u202B\u206E\u206E\u202B\u206B\u200E\u200C\u200E\u206E\u206B\u202C\u202D\u206F\u200E\u200F\u206E\u202D\u202D\u202C\u202E(BepinexPlugin.embeddedSource);
			FlandreInternetSurvivorDef.\u202B\u200C\u200B\u200E\u200E\u206D\u200B\u202E\u200F\u206E\u206E\u202A\u200B\u200E\u200C\u200C\u202E\u206F\u202B\u206D\u202E\u200B\u206E\u202A\u200F\u200C\u202D\u206B\u200D\u206F\u202A\u200D\u202C\u202C\u202C\u200E\u202B\u200C\u202A\u206F\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreInternetSurvivorDef.\u206A\u200D\u206F\u202C\u202E\u206F\u202C\u206D\u206B\u206B\u206C\u200B\u202B\u202D\u202C\u202D\u206C\u206C\u202D\u206A\u202B\u200B\u202E\u206D\u206A\u200D\u202D\u206B\u206D\u200F\u202A\u206C\u202C\u206E\u200F\u202A\u206A\u206E\u206E\u202A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreInternetSurvivorDef.\u200D\u206F\u206A\u200D\u202B\u206D\u202A\u200D\u202A\u206B\u200B\u206C\u206C\u200C\u200E\u206E\u202A\u206D\u206B\u200C\u206A\u202E\u206A\u206A\u200C\u206A\u202D\u202A\u202B\u202D\u206D\u206B\u200E\u206F\u200D\u206A\u202C\u206A\u206E\u200D\u202E(BepinexPlugin.sequenceTable, FlandreInternetSurvivorDef.\u202E\u200D\u200C\u200B\u200F\u202C\u202D\u200D\u202A\u206A\u202C\u206C\u202B\u200C\u200B\u202D\u206F\u200D\u200C\u200C\u202C\u202B\u200F\u206F\u202C\u206B\u206E\u202B\u206B\u206F\u200C\u200F\u202A\u200C\u200E\u200E\u206C\u200C\u206A\u206C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 1,
				White = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile, Keyword.Exile, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1356056699), new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1212047256) });
		}

		static CardImages \u206E\u202E\u202D\u202E\u200F\u200E\u206D\u200C\u202E\u202D\u200B\u200B\u206D\u206E\u202A\u206C\u200D\u206E\u202D\u202B\u202C\u202B\u206E\u206E\u202B\u206B\u200E\u200C\u200E\u206E\u206B\u202C\u202D\u206F\u200E\u200F\u206E\u202D\u202D\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202B\u200C\u200B\u200E\u200E\u206D\u200B\u202E\u200F\u206E\u206E\u202A\u200B\u200E\u200C\u200C\u202E\u206F\u202B\u206D\u202E\u200B\u206E\u202A\u200F\u200C\u202D\u206B\u200D\u206F\u202A\u200D\u202C\u202C\u202C\u200E\u202B\u200C\u202A\u206F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u200D\u206F\u202C\u202E\u206F\u202C\u206D\u206B\u206B\u206C\u200B\u202B\u202D\u202C\u202D\u206C\u206C\u202D\u206A\u202B\u200B\u202E\u206D\u206A\u200D\u202D\u206B\u206D\u200F\u202A\u206C\u202C\u206E\u200F\u202A\u206A\u206E\u206E\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u200D\u200C\u200B\u200F\u202C\u202D\u200D\u202A\u206A\u202C\u206C\u202B\u200C\u200B\u202D\u206F\u200D\u200C\u200C\u202C\u202B\u200F\u206F\u202C\u206B\u206E\u202B\u206B\u206F\u200C\u200F\u202A\u200C\u200E\u200E\u206C\u200C\u206A\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u206F\u206A\u200D\u202B\u206D\u202A\u200D\u202A\u206B\u200B\u206C\u206C\u200C\u200E\u206E\u202A\u206D\u206B\u200C\u206A\u202E\u206A\u206A\u200C\u206A\u202D\u202A\u202B\u202D\u206D\u206B\u200E\u206F\u200D\u206A\u202C\u206A\u206E\u200D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreInternetSurvivorDef))]
		public sealed class FlandreInternetSurvivor : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandreInternetSurvivorDef.FlandreInternetSurvivor.\u206C\u200D\u206A\u202B\u202D\u200C\u206F\u202C\u200B\u200C\u206E\u200D\u202D\u200D\u206C\u206D\u202D\u200C\u200F\u206D\u202C\u200C\u202E\u202C\u206F\u202E\u200C\u200D\u202C\u200F\u206A\u200D\u206C\u200D\u206F\u206B\u206B\u206E\u200E\u206F\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override int Amount
			{
				get
				{
					BattleController battleController = FlandreInternetSurvivorDef.FlandreInternetSurvivor.\u200F\u202A\u206D\u202D\u206A\u202C\u202E\u200C\u202D\u200F\u200E\u206D\u202B\u206B\u202B\u200B\u200D\u206B\u200D\u206F\u206A\u202D\u206A\u206D\u206A\u206B\u202B\u206A\u206E\u206B\u202A\u206A\u202B\u200D\u206A\u200E\u202B\u206A\u202B\u206E\u202E(this);
					int? num = ((battleController != null) ? new int?(FlandreInternetSurvivorDef.FlandreInternetSurvivor.\u202A\u206A\u206E\u200D\u202E\u200D\u202A\u200C\u206D\u206F\u206F\u206E\u206B\u202E\u206C\u202C\u200B\u202C\u200B\u206E\u206E\u206B\u200E\u202B\u206B\u202C\u206B\u200B\u206B\u206F\u202C\u202B\u202E\u202D\u202D\u200B\u200B\u206F\u202D\u202D\u202E(FlandreInternetSurvivorDef.FlandreInternetSurvivor.\u202E\u200F\u202D\u206F\u200B\u206B\u202D\u200F\u206D\u206D\u200B\u200C\u206D\u206D\u202A\u202C\u202C\u200D\u202D\u206C\u206D\u200F\u206D\u206D\u206F\u206B\u202B\u202B\u200C\u200D\u200C\u206A\u200D\u206E\u202E\u200C\u206B\u206B\u202B\u206D\u202E(battleController))) : null);
					float? num5;
					for (;;)
					{
						IL_0025:
						int num2 = -2027457985;
						for (;;)
						{
							int num3 = num2;
							uint num4;
							float? num6;
							float? num7;
							float? num9;
							switch ((num4 = (uint)(num3 - ((-2083865402 ^ -369928085) - --57813635 + ~(2077953886 ^ 1168611699)) + -(1747958785 ^ 2049701178))) % 7U)
							{
							case 0U:
								num5 = null;
								num6 = num5;
								goto IL_00B9;
							case 1U:
							{
								if (num7 == null)
								{
									num2 = (int)((num4 * 3459576795U) ^ 270292325U);
									continue;
								}
								float num8;
								num6 = new float?(num7.GetValueOrDefault() * num8);
								goto IL_00B9;
							}
							case 3U:
							{
								float num8 = (float)this.FlandreValue1 * 0.01f;
								num2 = (int)((num4 * 264162086U) ^ 2200209230U);
								continue;
							}
							case 4U:
								if (num == null)
								{
									num2 = (int)((num4 * 2799947196U) ^ 1742531952U);
									continue;
								}
								num9 = new float?((float)num.GetValueOrDefault());
								goto IL_00DE;
							case 5U:
								goto IL_0025;
							case 6U:
								num5 = null;
								num9 = num5;
								goto IL_00DE;
							}
							goto Block_2;
							IL_00B9:
							num5 = num6;
							num2 = -1877820919;
							continue;
							IL_00DE:
							num7 = num9;
							num2 = -1239054629;
						}
					}
					Block_2:
					return FlandreInternetSurvivorDef.FlandreInternetSurvivor.\u200D\u206C\u200E\u206E\u202D\u206C\u202C\u200F\u200D\u202E\u206F\u200C\u206E\u206E\u206F\u206B\u206B\u202E\u202D\u206C\u202B\u200F\u200D\u206C\u200C\u206F\u202C\u200F\u200F\u202D\u202E\u202D\u202A\u202A\u202B\u200B\u202A\u200E\u206C\u200F\u202E(num5.GetValueOrDefault(), MidpointRounding.AwayFromZero);
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = -2084122788;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-((-1467668005 * --1097170198 - num2) ^ (-1880454128 + 630711358 + (-1459809962 + 36597083))) - 1178419368)) % 3U)
						{
						case 1U:
							base.IsMagicalGirl = true;
							num = (int)((num3 * 2468254152U) ^ 2689106601U);
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
				FlandreInternetSurvivorDef.FlandreInternetSurvivor.<Actions>d__5 <Actions>d__ = new FlandreInternetSurvivorDef.FlandreInternetSurvivor.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u206C\u200D\u206A\u202B\u202D\u200C\u206F\u202C\u200B\u200C\u206E\u200D\u202D\u200D\u206C\u206D\u202D\u200C\u200F\u206D\u202C\u200C\u202E\u202C\u206F\u202E\u200C\u200D\u202C\u200F\u206A\u200D\u206C\u200D\u206F\u206B\u206B\u206E\u200E\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u200F\u202A\u206D\u202D\u206A\u202C\u202E\u200C\u202D\u200F\u200E\u206D\u202B\u206B\u202B\u200B\u200D\u206B\u200D\u206F\u206A\u202D\u206A\u206D\u206A\u206B\u202B\u206A\u206E\u206B\u202A\u206A\u202B\u200D\u206A\u200E\u202B\u206A\u202B\u206E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202E\u200F\u202D\u206F\u200B\u206B\u202D\u200F\u206D\u206D\u200B\u200C\u206D\u206D\u202A\u202C\u202C\u200D\u202D\u206C\u206D\u200F\u206D\u206D\u206F\u206B\u202B\u202B\u200C\u200D\u200C\u206A\u200D\u206E\u202E\u200C\u206B\u206B\u202B\u206D\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static int \u202A\u206A\u206E\u200D\u202E\u200D\u202A\u200C\u206D\u206F\u206F\u206E\u206B\u202E\u206C\u202C\u200B\u202C\u200B\u206E\u206E\u206B\u200E\u202B\u206B\u202C\u206B\u200B\u206B\u206F\u202C\u202B\u202E\u202D\u202D\u200B\u200B\u206F\u202D\u202D\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static int \u200D\u206C\u200E\u206E\u202D\u206C\u202C\u200F\u200D\u202E\u206F\u200C\u206E\u206E\u206F\u206B\u206B\u202E\u202D\u206C\u202B\u200F\u200D\u206C\u200C\u206F\u202C\u200F\u200F\u202D\u202E\u202D\u202A\u202A\u202B\u200B\u202A\u200E\u206C\u200F\u202E(float A_0, MidpointRounding A_1)
			{
				return A_0.RoundToInt(A_1);
			}
		}
	}
}
