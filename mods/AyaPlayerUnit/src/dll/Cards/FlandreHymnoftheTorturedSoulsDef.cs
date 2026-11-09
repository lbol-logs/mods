using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AyaShameimaru.StatusEffects;
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
	public sealed class FlandreHymnoftheTorturedSoulsDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1927893407);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreHymnoftheTorturedSoulsDef.\u200F\u206B\u202E\u200F\u206C\u206D\u200C\u206F\u200B\u202D\u200C\u202A\u206E\u202C\u206C\u200E\u200E\u206A\u202B\u200F\u206A\u206C\u202C\u206E\u206E\u206B\u202D\u200F\u206C\u206E\u206C\u206F\u206F\u200F\u200B\u202E\u202E\u202D\u200C\u200F\u202E(BepinexPlugin.embeddedSource);
			FlandreHymnoftheTorturedSoulsDef.\u202D\u200B\u206C\u202B\u200C\u206D\u202C\u206F\u206D\u200B\u206C\u202E\u206B\u202C\u202A\u206A\u206C\u200F\u206F\u206E\u200C\u206E\u202C\u202D\u206D\u200F\u206C\u202C\u202E\u206C\u206E\u200B\u200F\u200B\u206D\u206C\u206B\u202A\u202D\u202B\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreHymnoftheTorturedSoulsDef.\u202A\u200D\u200F\u200E\u202E\u206F\u202E\u200B\u200D\u202D\u200C\u206D\u200E\u200C\u206B\u200C\u202E\u200C\u200F\u202C\u200C\u206C\u206A\u202C\u202D\u200C\u200B\u206C\u200B\u206C\u200B\u200C\u200C\u200F\u206B\u202D\u206D\u206D\u206E\u200E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreHymnoftheTorturedSoulsDef.\u206B\u202E\u202A\u202C\u206F\u200F\u200D\u206E\u200F\u202D\u206B\u202B\u200F\u200B\u206A\u200D\u202B\u202C\u200C\u206B\u202D\u200E\u200D\u206D\u206F\u202D\u200D\u206E\u200B\u202B\u206C\u206B\u202A\u206B\u202B\u206E\u202A\u202D\u206E\u202B\u202E(BepinexPlugin.sequenceTable, FlandreHymnoftheTorturedSoulsDef.\u202E\u202E\u202C\u206E\u206C\u206C\u206D\u206C\u206F\u202C\u200B\u206C\u200B\u206D\u206F\u206B\u206C\u206A\u206E\u200B\u202D\u206E\u200F\u200C\u206B\u202A\u202C\u206E\u206C\u202C\u206C\u206B\u206F\u202A\u206C\u200D\u202C\u206D\u200E\u206E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Red = 2
			}, null, null, null, null, null, null, new int?(15), null, null, null, new int?(1), null, null, null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Block | Keyword.Philosophy, Keyword.Block | Keyword.Philosophy, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(403931841) }, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1625028300) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(132619953), new List<string>());
		}

		static CardImages \u200F\u206B\u202E\u200F\u206C\u206D\u200C\u206F\u200B\u202D\u200C\u202A\u206E\u202C\u206C\u200E\u200E\u206A\u202B\u200F\u206A\u206C\u202C\u206E\u206E\u206B\u202D\u200F\u206C\u206E\u206C\u206F\u206F\u200F\u200B\u202E\u202E\u202D\u200C\u200F\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202D\u200B\u206C\u202B\u200C\u206D\u202C\u206F\u206D\u200B\u206C\u202E\u206B\u202C\u202A\u206A\u206C\u200F\u206F\u206E\u200C\u206E\u202C\u202D\u206D\u200F\u206C\u202C\u202E\u206C\u206E\u200B\u200F\u200B\u206D\u206C\u206B\u202A\u202D\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202A\u200D\u200F\u200E\u202E\u206F\u202E\u200B\u200D\u202D\u200C\u206D\u200E\u200C\u206B\u200C\u202E\u200C\u200F\u202C\u200C\u206C\u206A\u202C\u202D\u200C\u200B\u206C\u200B\u206C\u200B\u200C\u200C\u200F\u206B\u202D\u206D\u206D\u206E\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u202E\u202C\u206E\u206C\u206C\u206D\u206C\u206F\u202C\u200B\u206C\u200B\u206D\u206F\u206B\u206C\u206A\u206E\u200B\u202D\u206E\u200F\u200C\u206B\u202A\u202C\u206E\u206C\u202C\u206C\u206B\u206F\u202A\u206C\u200D\u202C\u206D\u200E\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206B\u202E\u202A\u202C\u206F\u200F\u200D\u206E\u200F\u202D\u206B\u202B\u200F\u200B\u206A\u200D\u202B\u202C\u200C\u206B\u202D\u200E\u200D\u206D\u206F\u202D\u200D\u206E\u200B\u202B\u206C\u206B\u202A\u206B\u202B\u206E\u202A\u202D\u206E\u202B\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreHymnoftheTorturedSoulsDef))]
		public sealed class FlandreHymnoftheTorturedSouls : FlandreCard
		{
			public override int AdditionalBlock
			{
				get
				{
					return FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u206A\u206F\u200D\u202E\u206C\u206E\u200F\u202C\u200D\u202C\u202B\u202E\u206D\u206B\u206E\u206D\u206D\u200D\u202C\u202D\u206D\u206D\u202E\u202A\u206A\u206D\u202A\u202E\u206E\u206A\u200B\u200E\u206E\u200B\u206A\u206F\u202A\u200E\u206D\u202B\u202E(this).GetValueOrDefault() * 5;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u202E\u202E\u202C\u202A\u202E\u206F\u202A\u200D\u200C\u202D\u200F\u200E\u200B\u206A\u206E\u202E\u200B\u202C\u200C\u206E\u206D\u202A\u200B\u200D\u202E\u206E\u206E\u202A\u200D\u202B\u200F\u206C\u206F\u206B\u200C\u206A\u202E\u200B\u202A\u200F\u202E((float)FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u206A\u206F\u200D\u202E\u206C\u206E\u200F\u202C\u200D\u202C\u202B\u202E\u206D\u206B\u206E\u206D\u206D\u200D\u202C\u202D\u206D\u206D\u202E\u202A\u206A\u206D\u202A\u202E\u206E\u206A\u200B\u200E\u206E\u200B\u206A\u206F\u202A\u200E\u206D\u202B\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u202E\u202E\u202C\u202A\u202E\u206F\u202A\u200D\u200C\u202D\u200F\u200E\u200B\u206A\u206E\u202E\u200B\u202C\u200C\u206E\u206D\u202A\u200B\u200D\u202E\u206E\u206E\u202A\u200D\u202B\u200F\u206C\u206F\u206B\u200C\u206A\u202E\u200B\u202A\u200F\u202E((float)FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u206A\u206F\u200D\u202E\u206C\u206E\u200F\u202C\u200D\u202C\u202B\u202E\u206D\u206B\u206E\u206D\u206D\u200D\u202C\u202D\u206D\u206D\u202E\u202A\u206A\u206D\u202A\u202E\u206E\u206A\u200B\u200E\u206E\u200B\u206A\u206F\u202A\u200E\u206D\u202B\u202E(this).GetValueOrDefault() / 2f)
					};
				}
			}

			public override ManaGroup FlandreMana
			{
				get
				{
					ManaGroup manaGroup = FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u200D\u206F\u200E\u200F\u202A\u200B\u202E\u206F\u206E\u202C\u202D\u200F\u206B\u202B\u206F\u202B\u202C\u200D\u200D\u200F\u202A\u202D\u200E\u200F\u206A\u202C\u202E\u200C\u206C\u200D\u202E\u200D\u206F\u200F\u200B\u202D\u206B\u206E\u206D\u200F\u202E(this) + this.AdditionalMana;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0079:
							int num = (FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u206E\u200D\u202B\u200E\u206B\u206C\u200F\u202D\u206B\u200C\u206E\u206A\u200B\u202A\u202D\u206A\u200C\u202E\u206F\u202D\u202A\u202A\u200F\u206F\u206D\u202D\u200C\u200E\u206C\u200F\u206D\u202B\u200D\u200E\u200E\u202E\u200D\u200D\u200B\u200D\u202E(enumerator) ? (-950755907) : 373285567);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(941055374 - ((~num2 - 551344869 * -116984628) ^ (-66052583 + 1547784160)))) % 6U)
								{
								case 0U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 196868134U) ^ 290989465U);
									continue;
								}
								case 2U:
									num = -950755907;
									continue;
								case 3U:
									goto IL_0079;
								case 4U:
								{
									ManaColor manaColor;
									num = (int)(((manaGroup.GetValue(manaColor) > 0) ? 3297019566U : 269091477U) ^ (num3 * 4076047251U));
									continue;
								}
								case 5U:
								{
									ManaColor manaColor = enumerator.Current;
									num = 548336012;
									continue;
								}
								}
								goto Block_3;
							}
						}
						Block_3:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_00E7:
								int num4 = 414669286;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(941055374 - ((~num2 - 551344869 * -116984628) ^ (-66052583 + 1547784160)))) % 3U)
									{
									case 0U:
										goto IL_00E7;
									case 2U:
										FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u202A\u202E\u200B\u202E\u206B\u202C\u206D\u200F\u200B\u202E\u202B\u206B\u200B\u206D\u200D\u202C\u200D\u200B\u202D\u202E\u206B\u202E\u202A\u202B\u202B\u202B\u206C\u200D\u202D\u206E\u202B\u202B\u206E\u206E\u206A\u202C\u206F\u202C\u200B\u200D\u202E(enumerator);
										num4 = (int)((num3 * 1343836826U) ^ 3460444173U);
										continue;
									}
									goto Block_7;
								}
							}
							Block_7:;
						}
					}
					return manaGroup;
				}
			}

			public override int Amount
			{
				get
				{
					BattleController battleController = FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u202E\u206C\u202B\u206C\u200D\u200C\u202A\u200C\u200D\u200D\u206A\u202C\u206B\u206C\u200F\u206E\u200B\u202C\u206E\u206E\u206F\u200D\u200B\u200E\u206C\u202C\u200E\u200C\u202E\u200E\u206B\u206F\u206C\u202E\u202C\u206D\u206E\u206C\u206D\u206A\u202E(this);
					int? num;
					if (battleController == null)
					{
						num = null;
					}
					else
					{
						num = new int?(FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.\u202A\u202C\u202E\u206F\u206D\u206A\u202D\u202D\u200B\u206E\u202A\u202E\u202B\u206C\u206F\u202C\u202E\u200D\u200B\u200B\u200F\u206E\u200E\u200D\u202D\u202E\u206E\u206D\u200E\u202E\u200D\u200B\u206C\u202C\u202C\u202A\u206A\u200D\u206A\u206C\u202E(battleController).Count((Unit u) => u.HasStatusEffect<FlandreHellfireSeDef.FlandreHellfireSe>()));
					}
					int? num2 = num;
					return num2.GetValueOrDefault() * this.FlandreValue1;
				}
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsBloodlust = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.<Actions>d__11 <Actions>d__ = new FlandreHymnoftheTorturedSoulsDef.FlandreHymnoftheTorturedSouls.<Actions>d__11(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u206A\u206F\u200D\u202E\u206C\u206E\u200F\u202C\u200D\u202C\u202B\u202E\u206D\u206B\u206E\u206D\u206D\u200D\u202C\u202D\u206D\u206D\u202E\u202A\u206A\u206D\u202A\u202E\u206E\u206A\u200B\u200E\u206E\u200B\u206A\u206F\u202A\u200E\u206D\u202B\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202E\u202E\u202C\u202A\u202E\u206F\u202A\u200D\u200C\u202D\u200F\u200E\u200B\u206A\u206E\u202E\u200B\u202C\u200C\u206E\u206D\u202A\u200B\u200D\u202E\u206E\u206E\u202A\u200D\u202B\u200F\u206C\u206F\u206B\u200C\u206A\u202E\u200B\u202A\u200F\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static ManaGroup \u200D\u206F\u200E\u200F\u202A\u200B\u202E\u206F\u206E\u202C\u202D\u200F\u206B\u202B\u206F\u202B\u202C\u200D\u200D\u200F\u202A\u202D\u200E\u200F\u206A\u202C\u202E\u200C\u206C\u200D\u202E\u200D\u206F\u200F\u200B\u202D\u206B\u206E\u206D\u200F\u202E(Card A_0)
			{
				return A_0.Mana;
			}

			static bool \u206E\u200D\u202B\u200E\u206B\u206C\u200F\u202D\u206B\u200C\u206E\u206A\u200B\u202A\u202D\u206A\u200C\u202E\u206F\u202D\u202A\u202A\u200F\u206F\u206D\u202D\u200C\u200E\u206C\u200F\u206D\u202B\u200D\u200E\u200E\u202E\u200D\u200D\u200B\u200D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202A\u202E\u200B\u202E\u206B\u202C\u206D\u200F\u200B\u202E\u202B\u206B\u200B\u206D\u200D\u202C\u200D\u200B\u202D\u202E\u206B\u202E\u202A\u202B\u202B\u202B\u206C\u200D\u202D\u206E\u202B\u202B\u206E\u206E\u206A\u202C\u206F\u202C\u200B\u200D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static BattleController \u202E\u206C\u202B\u206C\u200D\u200C\u202A\u200C\u200D\u200D\u206A\u202C\u206B\u206C\u200F\u206E\u200B\u202C\u206E\u206E\u206F\u200D\u200B\u200E\u206C\u202C\u200E\u200C\u202E\u200E\u206B\u206F\u206C\u202E\u202C\u206D\u206E\u206C\u206D\u206A\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IEnumerable<Unit> \u202A\u202C\u202E\u206F\u206D\u206A\u202D\u202D\u200B\u206E\u202A\u202E\u202B\u206C\u206F\u202C\u202E\u200D\u200B\u200B\u200F\u206E\u200E\u200D\u202D\u202E\u206E\u206D\u200E\u202E\u200D\u200B\u206C\u202C\u202C\u202A\u206A\u200D\u206A\u206C\u202E(BattleController A_0)
			{
				return A_0.AllAliveUnits;
			}
		}
	}
}
