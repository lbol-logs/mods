using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BepInEx;
using BepInEx.Bootstrap;
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
	public sealed class FlandreMPProblemChildDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-387497176);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreMPProblemChildDef.\u200D\u202E\u200B\u200D\u202E\u206F\u206C\u200F\u200C\u202D\u206C\u206D\u200D\u200C\u200E\u200D\u202A\u206A\u202B\u206D\u202B\u200C\u206E\u206A\u206B\u206B\u200C\u200F\u206E\u200C\u200B\u202B\u202D\u200B\u206B\u206A\u200C\u202B\u202A\u202C\u202E(BepinexPlugin.embeddedSource);
			FlandreMPProblemChildDef.\u202C\u200C\u202D\u200E\u206A\u202C\u206F\u200F\u206F\u206B\u200F\u200C\u200F\u200E\u206F\u202C\u202E\u206F\u202D\u202C\u206B\u202A\u202E\u206A\u200B\u200C\u200B\u202B\u202E\u200E\u200B\u200F\u206A\u200C\u200D\u206C\u206D\u206B\u200E\u206C\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreMPProblemChildDef.\u206F\u202D\u200B\u200C\u202B\u200B\u200F\u202D\u206C\u202B\u206E\u202E\u202E\u206D\u202B\u206F\u206A\u200D\u200C\u200B\u202B\u202D\u202A\u206A\u206B\u200C\u200F\u206E\u200E\u202C\u202A\u206D\u200D\u202A\u206A\u206D\u206A\u200D\u206B\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreMPProblemChildDef.\u202B\u200D\u206E\u200E\u202A\u206D\u202B\u200C\u200C\u202B\u200B\u202D\u202D\u202E\u200B\u200B\u202E\u200E\u200C\u206F\u200E\u200C\u206C\u206F\u206D\u200B\u200E\u202E\u206C\u206A\u206A\u202E\u206E\u200B\u206D\u202E\u202B\u200B\u206D\u202E\u202E(BepinexPlugin.sequenceTable, FlandreMPProblemChildDef.\u202C\u202B\u206F\u202B\u206A\u200C\u206D\u206F\u206F\u206D\u200C\u202D\u202E\u200E\u200E\u200E\u206D\u202C\u206B\u200C\u202A\u200C\u200F\u202B\u200D\u206C\u202D\u200B\u200C\u200B\u202A\u202B\u202D\u202B\u200E\u200E\u200B\u202C\u202C\u202A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), 0, false, FlandreMPProblemChildDef.\u200D\u206A\u206C\u200F\u202C\u206F\u202A\u200B\u202D\u202E\u200E\u202D\u202A\u206F\u206B\u202B\u200D\u206D\u200F\u200E\u206C\u206B\u206A\u200B\u200B\u206D\u206E\u200D\u200B\u200D\u200B\u202A\u200E\u200F\u202B\u200F\u200F\u206F\u200C\u206E\u202E().ContainsKey(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-806222643)), false, FlandreMPProblemChildDef.\u200D\u206A\u206C\u200F\u202C\u206F\u202A\u200B\u202D\u202E\u200E\u202D\u202A\u206F\u206B\u202B\u200D\u206D\u200F\u200E\u206C\u206B\u206A\u200B\u200B\u206D\u206E\u200D\u200B\u200D\u200B\u202A\u200E\u200F\u202B\u200F\u200F\u206F\u200C\u206E\u202E().ContainsKey(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(422596837)), true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			}, false, new ManaGroup
			{
				Any = 1,
				Hybrid = 2,
				HybridColor = 4
			}, null, null, null, null, null, null, null, null, null, null, new int?(2), null, null, null, new ManaGroup?(new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.Initial, false, Keyword.Forbidden, Keyword.Forbidden, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(771216718), new List<string>());
		}

		static CardImages \u200D\u202E\u200B\u200D\u202E\u206F\u206C\u200F\u200C\u202D\u206C\u206D\u200D\u200C\u200E\u200D\u202A\u206A\u202B\u206D\u202B\u200C\u206E\u206A\u206B\u206B\u200C\u200F\u206E\u200C\u200B\u202B\u202D\u200B\u206B\u206A\u200C\u202B\u202A\u202C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202C\u200C\u202D\u200E\u206A\u202C\u206F\u200F\u206F\u206B\u200F\u200C\u200F\u200E\u206F\u202C\u202E\u206F\u202D\u202C\u206B\u202A\u202E\u206A\u200B\u200C\u200B\u202B\u202E\u200E\u200B\u200F\u206A\u200C\u200D\u206C\u206D\u206B\u200E\u206C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206F\u202D\u200B\u200C\u202B\u200B\u200F\u202D\u206C\u202B\u206E\u202E\u202E\u206D\u202B\u206F\u206A\u200D\u200C\u200B\u202B\u202D\u202A\u206A\u206B\u200C\u200F\u206E\u200E\u202C\u202A\u206D\u200D\u202A\u206A\u206D\u206A\u200D\u206B\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u202B\u206F\u202B\u206A\u200C\u206D\u206F\u206F\u206D\u200C\u202D\u202E\u200E\u200E\u200E\u206D\u202C\u206B\u200C\u202A\u200C\u200F\u202B\u200D\u206C\u202D\u200B\u200C\u200B\u202A\u202B\u202D\u202B\u200E\u200E\u200B\u202C\u202C\u202A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202B\u200D\u206E\u200E\u202A\u206D\u202B\u200C\u200C\u202B\u200B\u202D\u202D\u202E\u200B\u200B\u202E\u200E\u200C\u206F\u200E\u200C\u206C\u206F\u206D\u200B\u200E\u202E\u206C\u206A\u206A\u202E\u206E\u200B\u206D\u202E\u202B\u200B\u206D\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		static Dictionary<string, PluginInfo> \u200D\u206A\u206C\u200F\u202C\u206F\u202A\u200B\u202D\u202E\u200E\u202D\u202A\u206F\u206B\u202B\u200D\u206D\u200F\u200E\u206C\u206B\u206A\u200B\u200B\u206D\u206E\u200D\u200B\u200D\u200B\u202A\u200E\u200F\u202B\u200F\u200F\u206F\u200C\u206E\u202E()
		{
			return Chainloader.PluginInfos;
		}

		[EntityLogic(typeof(FlandreMPProblemChildDef))]
		public sealed class FlandreMPProblemChild : FlandreCard
		{
			public override ManaGroup AdditionalMana
			{
				get
				{
					ManaGroup manaGroup = default(ManaGroup);
					for (;;)
					{
						IL_0008:
						int num = -391388256;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-((num2 ^ -((536773612 + -62140112) ^ -2142881257)) * 1988697695) ^ 239045275)) % 3U)
							{
							case 0U:
								goto IL_0008;
							case 1U:
								manaGroup.Any = FlandreMPProblemChildDef.FlandreMPProblemChild.\u202B\u206E\u200C\u206B\u202A\u206E\u200E\u202A\u206B\u206A\u200B\u200B\u206F\u200B\u206F\u202E\u202B\u200F\u200B\u202A\u200D\u200C\u206E\u206F\u202A\u206B\u200C\u202D\u206A\u206C\u202E\u202E\u202B\u202C\u200B\u200F\u200F\u206F\u200B\u206E\u202E((float)FlandreMPProblemChildDef.FlandreMPProblemChild.\u202A\u200E\u206F\u206C\u202C\u202D\u200B\u206F\u206B\u206F\u206F\u202B\u202A\u206F\u200F\u200E\u206A\u206F\u202C\u200B\u206E\u200B\u200B\u206E\u200B\u200D\u202C\u202E\u200E\u200D\u200F\u200B\u200F\u202A\u206E\u206B\u206F\u206D\u202C\u202A\u202E(this).GetValueOrDefault() / 2f);
								num = (int)((num3 * 3962071185U) ^ 1284722746U);
								continue;
							}
							return manaGroup;
						}
					}
					return manaGroup;
				}
			}

			public override ManaGroup FlandreMana
			{
				get
				{
					ManaGroup manaGroup = ManaGroup.Anys(1) + this.AdditionalMana;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_005F:
							int num = (FlandreMPProblemChildDef.FlandreMPProblemChild.\u206C\u202D\u206C\u206B\u200E\u202E\u200C\u200E\u206F\u202C\u200D\u202D\u200F\u202B\u200F\u206B\u206C\u200F\u200E\u202C\u200D\u200B\u200F\u200F\u202A\u202D\u206E\u202A\u206F\u206A\u206D\u206E\u200D\u206E\u202E\u206A\u200D\u206D\u202D\u200C\u202E(enumerator) ? (-479020256) : 1995245813);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~((num2 ^ ~740189913) * -1351988737) ^ 525555163)) % 6U)
								{
								case 0U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 714464364U) ^ 2605143275U);
									continue;
								}
								case 1U:
									goto IL_005F;
								case 2U:
									num = -479020256;
									continue;
								case 3U:
								{
									ManaColor manaColor;
									num = (int)(((manaGroup.GetValue(manaColor) <= 0) ? 3445383266U : 273222285U) ^ (num3 * 969673031U));
									continue;
								}
								case 4U:
								{
									ManaColor manaColor = enumerator.Current;
									num = -932028453;
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
								IL_00DB:
								int num4 = -1358441250;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(~((num2 ^ ~740189913) * -1351988737) ^ 525555163)) % 3U)
									{
									case 0U:
										goto IL_00DB;
									case 1U:
										FlandreMPProblemChildDef.FlandreMPProblemChild.\u206A\u202D\u206A\u206A\u206B\u202C\u202E\u206F\u206F\u202C\u206F\u202C\u206B\u200B\u206B\u200E\u206C\u202C\u206D\u206A\u202D\u202D\u200B\u202C\u206F\u200D\u202E\u206F\u202A\u202B\u206A\u206F\u200C\u202E\u206F\u206B\u202E\u206F\u206E\u202B\u202E(enumerator);
										num4 = (int)((num3 * 3625727790U) ^ 2264440539U);
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

			public override void Initialize()
			{
				base.Initialize();
				base.IsOffering = true;
				for (;;)
				{
					IL_000D:
					int num = -2136223987;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(((num2 + -(-(-526435489 ^ -1917285413)) - -(1281067704 + 1858241593)) ^ (-1691359231 ^ -808319941)) - -1811599076)) % 3U)
						{
						case 1U:
							base.OfferingCount = FlandreMPProblemChildDef.FlandreMPProblemChild.\u200E\u202E\u202C\u200B\u200E\u200C\u200E\u206D\u200E\u202C\u202D\u206C\u206B\u206B\u200D\u202A\u200E\u202C\u200D\u200F\u206C\u202D\u206E\u202C\u200E\u206B\u206D\u200C\u200D\u200E\u200C\u206E\u202D\u206D\u200C\u206C\u202B\u206E\u206E\u206F\u202E(this);
							num = (int)((num3 * 1465143819U) ^ 3247299371U);
							continue;
						case 2U:
							goto IL_000D;
						}
						goto Block_1;
					}
				}
				Block_1:
				base.IsMultiplayer = true;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreMPProblemChildDef.FlandreMPProblemChild.<Actions>d__5 <Actions>d__ = new FlandreMPProblemChildDef.FlandreMPProblemChild.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202A\u200E\u206F\u206C\u202C\u202D\u200B\u206F\u206B\u206F\u206F\u202B\u202A\u206F\u200F\u200E\u206A\u206F\u202C\u200B\u206E\u200B\u200B\u206E\u200B\u200D\u202C\u202E\u200E\u200D\u200F\u200B\u200F\u202A\u206E\u206B\u206F\u206D\u202C\u202A\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202B\u206E\u200C\u206B\u202A\u206E\u200E\u202A\u206B\u206A\u200B\u200B\u206F\u200B\u206F\u202E\u202B\u200F\u200B\u202A\u200D\u200C\u206E\u206F\u202A\u206B\u200C\u202D\u206A\u206C\u202E\u202E\u202B\u202C\u200B\u200F\u200F\u206F\u200B\u206E\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u206C\u202D\u206C\u206B\u200E\u202E\u200C\u200E\u206F\u202C\u200D\u202D\u200F\u202B\u200F\u206B\u206C\u200F\u200E\u202C\u200D\u200B\u200F\u200F\u202A\u202D\u206E\u202A\u206F\u206A\u206D\u206E\u200D\u206E\u202E\u206A\u200D\u206D\u202D\u200C\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u206A\u202D\u206A\u206A\u206B\u202C\u202E\u206F\u206F\u202C\u206F\u202C\u206B\u200B\u206B\u200E\u206C\u202C\u206D\u206A\u202D\u202D\u200B\u202C\u206F\u200D\u202E\u206F\u202A\u202B\u206A\u206F\u200C\u202E\u206F\u206B\u202E\u206F\u206E\u202B\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static int \u200E\u202E\u202C\u200B\u200E\u200C\u200E\u206D\u200E\u202C\u202D\u206C\u206B\u206B\u200D\u202A\u200E\u202C\u200D\u200F\u206C\u202D\u206E\u202C\u200E\u206B\u206D\u200C\u200D\u200E\u200C\u206E\u202D\u206D\u200C\u206C\u202B\u206E\u206E\u206F\u202E(Card A_0)
			{
				return A_0.Value1;
			}
		}
	}
}
