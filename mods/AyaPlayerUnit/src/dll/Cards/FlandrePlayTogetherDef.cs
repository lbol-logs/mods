using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
using LBoL.Base.Extensions;
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
	public sealed class FlandrePlayTogetherDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1318459387);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandrePlayTogetherDef.\u200E\u200B\u206B\u200C\u202A\u206A\u200C\u200F\u202C\u200C\u206D\u206D\u200F\u206D\u200B\u202C\u206E\u200F\u206E\u206E\u200B\u200F\u200F\u200D\u202C\u200C\u200E\u200E\u202D\u200C\u206C\u206A\u200C\u202B\u202D\u206A\u200C\u202E\u202B\u202D\u202E(BepinexPlugin.embeddedSource);
			FlandrePlayTogetherDef.\u200D\u206B\u206F\u200C\u206C\u202E\u202C\u200B\u206E\u206A\u202D\u206E\u200D\u206D\u206D\u206D\u200F\u200C\u200C\u202B\u202D\u200F\u202C\u206C\u202C\u200D\u206A\u206D\u206A\u206E\u200C\u206D\u206A\u206E\u206E\u202E\u200C\u200B\u206E\u202B\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandrePlayTogetherDef.\u206D\u206B\u200D\u206C\u206D\u206A\u206A\u206E\u206C\u200E\u200F\u202A\u206B\u206F\u206F\u200E\u202A\u200B\u200C\u206F\u206D\u206D\u206D\u200C\u206D\u206C\u206C\u202E\u200D\u200B\u206D\u202C\u206E\u200F\u206F\u200F\u206F\u206E\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandrePlayTogetherDef.\u200E\u202B\u202B\u202A\u202E\u200D\u206A\u200F\u202A\u202A\u200C\u202C\u200F\u202A\u202E\u202C\u206E\u206B\u202D\u202C\u200E\u206A\u200D\u202A\u206E\u202C\u206C\u206B\u200D\u200C\u202C\u202A\u200D\u200F\u200F\u200C\u202A\u202D\u200B\u202A\u202E(BepinexPlugin.sequenceTable, FlandrePlayTogetherDef.\u206F\u200B\u202B\u202C\u206C\u206F\u206D\u206B\u206D\u200F\u206B\u200B\u206A\u200F\u206C\u202E\u206A\u200F\u202C\u206A\u206B\u206B\u200C\u200B\u200E\u200B\u202C\u206C\u206C\u202C\u200C\u206C\u202A\u202B\u202B\u206C\u202A\u206F\u202E\u202D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Hybrid = 1,
				HybridColor = 7
			}, new ManaGroup?(new ManaGroup
			{
				Any = 0
			}), null, null, null, null, null, null, null, null, null, new int?(1), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Debut, Keyword.Debut, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1941088925) }, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(536664057) }, new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(945221968), new List<string>());
		}

		static CardImages \u200E\u200B\u206B\u200C\u202A\u206A\u200C\u200F\u202C\u200C\u206D\u206D\u200F\u206D\u200B\u202C\u206E\u200F\u206E\u206E\u200B\u200F\u200F\u200D\u202C\u200C\u200E\u200E\u202D\u200C\u206C\u206A\u200C\u202B\u202D\u206A\u200C\u202E\u202B\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u206B\u206F\u200C\u206C\u202E\u202C\u200B\u206E\u206A\u202D\u206E\u200D\u206D\u206D\u206D\u200F\u200C\u200C\u202B\u202D\u200F\u202C\u206C\u202C\u200D\u206A\u206D\u206A\u206E\u200C\u206D\u206A\u206E\u206E\u202E\u200C\u200B\u206E\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206D\u206B\u200D\u206C\u206D\u206A\u206A\u206E\u206C\u200E\u200F\u202A\u206B\u206F\u206F\u200E\u202A\u200B\u200C\u206F\u206D\u206D\u206D\u200C\u206D\u206C\u206C\u202E\u200D\u200B\u206D\u202C\u206E\u200F\u206F\u200F\u206F\u206E\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206F\u200B\u202B\u202C\u206C\u206F\u206D\u206B\u206D\u200F\u206B\u200B\u206A\u200F\u206C\u202E\u206A\u200F\u202C\u206A\u206B\u206B\u200C\u200B\u200E\u200B\u202C\u206C\u206C\u202C\u200C\u206C\u202A\u202B\u202B\u206C\u202A\u206F\u202E\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u202B\u202B\u202A\u202E\u200D\u206A\u200F\u202A\u202A\u200C\u202C\u200F\u202A\u202E\u202C\u206E\u206B\u202D\u202C\u200E\u206A\u200D\u202A\u206E\u202C\u206C\u206B\u200D\u200C\u202C\u202A\u200D\u200F\u200F\u200C\u202A\u202D\u200B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandrePlayTogetherDef))]
		public sealed class FlandrePlayTogether : FlandreCard
		{
			public override int AdditionalValue1
			{
				get
				{
					return FlandrePlayTogetherDef.FlandrePlayTogether.\u200B\u206C\u206C\u202A\u202C\u202E\u206E\u200D\u206B\u202D\u202D\u200E\u200F\u206F\u200C\u206F\u200D\u200E\u202B\u200E\u200F\u202D\u202A\u200B\u206C\u206F\u200B\u202C\u202E\u206F\u206B\u200F\u200C\u202D\u206A\u206D\u206A\u200F\u202E\u200E\u202E((float)FlandrePlayTogetherDef.FlandrePlayTogether.\u202A\u202D\u202A\u202E\u202C\u200D\u200E\u206F\u200C\u200F\u200F\u206D\u206C\u200C\u200F\u202B\u202B\u202C\u202A\u202C\u206C\u202B\u202A\u202A\u206E\u202E\u206C\u206C\u200C\u206F\u206B\u200D\u206C\u202E\u202B\u200D\u200C\u200B\u206D\u202D\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandrePlayTogetherDef.FlandrePlayTogether.\u206A\u202A\u200F\u202A\u202B\u202A\u206B\u202E\u202C\u202E\u200D\u202B\u206A\u200E\u200D\u202C\u200C\u200C\u200F\u202B\u200C\u200C\u200E\u202A\u202D\u200C\u206E\u200E\u206B\u200F\u202C\u200E\u202D\u202A\u200D\u206B\u200D\u200C\u200C\u200E\u202E((float)FlandrePlayTogetherDef.FlandrePlayTogether.\u202A\u202D\u202A\u202E\u202C\u200D\u200E\u206F\u200C\u200F\u200F\u206D\u206C\u200C\u200F\u202B\u202B\u202C\u202A\u202C\u206C\u202B\u202A\u202A\u206E\u202E\u206C\u206C\u200C\u206F\u206B\u200D\u206C\u202E\u202B\u200D\u200C\u200B\u206D\u202D\u202E(this).GetValueOrDefault() / 2f);
				}
			}

			protected override string GetBaseDescription()
			{
				if (FlandrePlayTogetherDef.FlandrePlayTogether.\u202E\u200B\u200E\u200B\u206F\u206A\u206C\u206B\u202D\u206D\u200E\u206E\u200E\u206A\u202A\u200F\u206A\u206E\u206A\u206B\u200D\u200B\u200B\u206C\u206F\u202E\u200C\u202C\u202D\u200B\u206B\u206F\u202B\u200D\u200C\u202B\u202C\u206F\u202B\u200E\u202E(this))
				{
					for (;;)
					{
						int num = 651468230;
						switch (~(-num) % 3)
						{
						case 1:
							goto IL_0028;
						case 2:
							continue;
						}
						break;
					}
					goto IL_003E;
					IL_0028:
					return base.GetBaseDescription();
				}
				IL_003E:
				return base.ExtraDescription1;
			}

			public override void Initialize()
			{
				base.Initialize();
				base.IsBloodlust = true;
			}

			public override Interaction Precondition()
			{
				BattleController battleController = FlandrePlayTogetherDef.FlandrePlayTogether.\u200F\u202E\u206A\u206C\u200C\u206E\u200F\u200C\u206B\u206E\u200B\u200F\u200E\u200C\u202A\u202D\u206B\u202D\u202B\u202E\u200E\u200B\u206F\u200C\u200F\u206F\u202B\u206D\u202E\u202E\u200C\u206C\u200D\u206F\u202D\u202C\u206A\u202A\u206F\u202D\u202E(this);
				List<Card> list;
				if (battleController == null)
				{
					list = null;
				}
				else
				{
					list = (from c in FlandrePlayTogetherDef.FlandrePlayTogether.\u202C\u206C\u200E\u200D\u206D\u206F\u202D\u200C\u202A\u206F\u202E\u206A\u206D\u206E\u200F\u200E\u200C\u206E\u200E\u202E\u202A\u200F\u202C\u200C\u202C\u206C\u206A\u200C\u200E\u206B\u202B\u200C\u206C\u206E\u206C\u206F\u200C\u206D\u206D\u200C\u202E(battleController)
						where !(c is FlandrePlayTogetherDef.FlandrePlayTogether)
						select c).ToList<Card>();
				}
				List<Card> list2 = list;
				for (;;)
				{
					IL_003C:
					int num = -697945578;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((num2 ^ ((~-842899598 - -173574989 * -414782675) * 115583027)) * -1219079387 - ~-1030572240)) % 5U)
						{
						case 0U:
							goto IL_00C9;
						case 2U:
							num = (int)(((list2.Count > 0) ? 2596385940U : 2333344926U) ^ (num3 * 2132831477U));
							continue;
						case 3U:
							goto IL_003C;
						case 4U:
							num = (int)(((list2 == null) ? 662083082U : 3364501835U) ^ (num3 * 3120097569U));
							continue;
						}
						goto Block_3;
					}
				}
				Block_3:
				goto IL_00D5;
				IL_00C9:
				return null;
				IL_00D5:
				return FlandrePlayTogetherDef.FlandrePlayTogether.\u202D\u202E\u200E\u206C\u206D\u202E\u206F\u202B\u206A\u200C\u206E\u200C\u200D\u202C\u200D\u202A\u202E\u202C\u202D\u200F\u200C\u206E\u206E\u200B\u206D\u206D\u200E\u206C\u202B\u206E\u202D\u200F\u202B\u200E\u206C\u200D\u202B\u206E\u202B\u202E\u202E(0, this.FlandreValue2, list2, SelectedCardHandling.DoNothing);
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandrePlayTogetherDef.FlandrePlayTogether.<Actions>d__7 <Actions>d__ = new FlandrePlayTogetherDef.FlandrePlayTogether.<Actions>d__7(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u202A\u202D\u202A\u202E\u202C\u200D\u200E\u206F\u200C\u200F\u200F\u206D\u206C\u200C\u200F\u202B\u202B\u202C\u202A\u202C\u206C\u202B\u202A\u202A\u206E\u202E\u206C\u206C\u200C\u206F\u206B\u200D\u206C\u202E\u202B\u200D\u200C\u200B\u206D\u202D\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u200B\u206C\u206C\u202A\u202C\u202E\u206E\u200D\u206B\u202D\u202D\u200E\u200F\u206F\u200C\u206F\u200D\u200E\u202B\u200E\u200F\u202D\u202A\u200B\u206C\u206F\u200B\u202C\u202E\u206F\u206B\u200F\u200C\u202D\u206A\u206D\u206A\u200F\u202E\u200E\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			static int \u206A\u202A\u200F\u202A\u202B\u202A\u206B\u202E\u202C\u202E\u200D\u202B\u206A\u200E\u200D\u202C\u200C\u200C\u200F\u202B\u200C\u200C\u200E\u202A\u202D\u200C\u206E\u200E\u206B\u200F\u202C\u200E\u202D\u202A\u200D\u206B\u200D\u200C\u200C\u200E\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u202E\u200B\u200E\u200B\u206F\u206A\u206C\u206B\u202D\u206D\u200E\u206E\u200E\u206A\u202A\u200F\u206A\u206E\u206A\u206B\u200D\u200B\u200B\u206C\u206F\u202E\u200C\u202C\u202D\u200B\u206B\u206F\u202B\u200D\u200C\u202B\u202C\u206F\u202B\u200E\u202E(Card A_0)
			{
				return A_0.DebutActive;
			}

			static BattleController \u200F\u202E\u206A\u206C\u200C\u206E\u200F\u200C\u206B\u206E\u200B\u200F\u200E\u200C\u202A\u202D\u206B\u202D\u202B\u202E\u200E\u200B\u206F\u200C\u200F\u206F\u202B\u206D\u202E\u202E\u200C\u206C\u200D\u206F\u202D\u202C\u206A\u202A\u206F\u202D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u202C\u206C\u200E\u200D\u206D\u206F\u202D\u200C\u202A\u206F\u202E\u206A\u206D\u206E\u200F\u200E\u200C\u206E\u200E\u202E\u202A\u200F\u202C\u200C\u202C\u206C\u206A\u200C\u200E\u206B\u202B\u200C\u206C\u206E\u206C\u206F\u200C\u206D\u206D\u200C\u202E(BattleController A_0)
			{
				return A_0.DiscardZone;
			}

			static SelectCardInteraction \u202D\u202E\u200E\u206C\u206D\u202E\u206F\u202B\u206A\u200C\u206E\u200C\u200D\u202C\u200D\u202A\u202E\u202C\u202D\u200F\u200C\u206E\u206E\u200B\u206D\u206D\u200E\u206C\u202B\u206E\u202D\u200F\u202B\u200E\u206C\u200D\u202B\u206E\u202B\u202E\u202E(int A_0, int A_1, IEnumerable<Card> A_2, SelectedCardHandling A_3)
			{
				return new SelectCardInteraction(A_0, A_1, A_2, A_3);
			}
		}
	}
}
