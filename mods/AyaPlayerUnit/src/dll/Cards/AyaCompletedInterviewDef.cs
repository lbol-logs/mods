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
	public sealed class AyaCompletedInterviewDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1230727827);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaCompletedInterviewDef.\u206F\u202E\u200F\u202D\u206F\u202E\u206F\u200C\u206D\u206F\u202A\u206F\u202D\u202B\u202B\u206D\u200B\u206F\u206B\u202C\u206E\u202A\u206B\u206B\u206E\u200F\u206C\u206C\u206D\u200E\u206C\u206F\u206C\u200E\u200C\u202B\u202E\u206E\u200D\u200E\u202E(BepinexPlugin.embeddedSource);
			AyaCompletedInterviewDef.\u202E\u200C\u200D\u202A\u202B\u200E\u200F\u200F\u206D\u206E\u206E\u202A\u202C\u202A\u200E\u206A\u206E\u202A\u202A\u200F\u202B\u202D\u206E\u202E\u206E\u202D\u200D\u202C\u200E\u200E\u200B\u200D\u206F\u200C\u206D\u206D\u206E\u202B\u200C\u206F\u202E(cardImages, this, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-673837482), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaCompletedInterviewDef.\u200F\u206C\u202B\u200C\u206E\u206F\u200B\u206F\u206B\u200D\u206C\u200C\u202E\u202D\u206C\u200D\u206D\u202B\u206A\u200F\u206F\u206C\u206E\u202D\u206D\u202E\u200B\u206E\u206F\u202B\u202D\u200B\u206F\u202C\u200C\u202A\u202E\u206A\u200F\u200C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaCompletedInterviewDef.\u200E\u206B\u206B\u206C\u206A\u206B\u202E\u206D\u206C\u206E\u200D\u206D\u206C\u206F\u200B\u200C\u202B\u200F\u202D\u202A\u200E\u206B\u202E\u200D\u206E\u206E\u206A\u202D\u206D\u202E\u202C\u202C\u202E\u202A\u206F\u200F\u202E\u206F\u206A\u206A\u202E(BepinexPlugin.sequenceTable, AyaCompletedInterviewDef.\u206E\u202E\u202D\u200E\u206B\u202A\u202B\u206A\u206E\u202A\u200C\u206F\u206C\u200F\u200D\u200F\u206F\u200F\u202C\u202D\u202C\u206C\u206C\u206E\u200C\u202C\u206A\u202C\u200D\u206B\u202A\u202C\u206B\u200D\u206C\u200C\u206A\u200F\u206A\u202D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Green }, false, new ManaGroup
			{
				Any = 1,
				Green = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 2
			}), null, null, null, null, null, null, null, null, null, new int?(2), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Debut, Keyword.Debut, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>
			{
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1907490139),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-872101063)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1411537447),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-615046526)
			}, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1758881889), new List<string>());
		}

		static CardImages \u206F\u202E\u200F\u202D\u206F\u202E\u206F\u200C\u206D\u206F\u202A\u206F\u202D\u202B\u202B\u206D\u200B\u206F\u206B\u202C\u206E\u202A\u206B\u206B\u206E\u200F\u206C\u206C\u206D\u200E\u206C\u206F\u206C\u200E\u200C\u202B\u202E\u206E\u200D\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u200C\u200D\u202A\u202B\u200E\u200F\u200F\u206D\u206E\u206E\u202A\u202C\u202A\u200E\u206A\u206E\u202A\u202A\u200F\u202B\u202D\u206E\u202E\u206E\u202D\u200D\u202C\u200E\u200E\u200B\u200D\u206F\u200C\u206D\u206D\u206E\u202B\u200C\u206F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200F\u206C\u202B\u200C\u206E\u206F\u200B\u206F\u206B\u200D\u206C\u200C\u202E\u202D\u206C\u200D\u206D\u202B\u206A\u200F\u206F\u206C\u206E\u202D\u206D\u202E\u200B\u206E\u206F\u202B\u202D\u200B\u206F\u202C\u200C\u202A\u202E\u206A\u200F\u200C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u202E\u202D\u200E\u206B\u202A\u202B\u206A\u206E\u202A\u200C\u206F\u206C\u200F\u200D\u200F\u206F\u200F\u202C\u202D\u202C\u206C\u206C\u206E\u200C\u202C\u206A\u202C\u200D\u206B\u202A\u202C\u206B\u200D\u206C\u200C\u206A\u200F\u206A\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u206B\u206B\u206C\u206A\u206B\u202E\u206D\u206C\u206E\u200D\u206D\u206C\u206F\u200B\u200C\u202B\u200F\u202D\u202A\u200E\u206B\u202E\u200D\u206E\u206E\u206A\u202D\u206D\u202E\u202C\u202C\u202E\u202A\u206F\u200F\u202E\u206F\u206A\u206A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaCompletedInterviewDef))]
		public sealed class AyaCompletedInterview : Card
		{
			public int Value3
			{
				get
				{
					if (!AyaCompletedInterviewDef.AyaCompletedInterview.\u200D\u200F\u202D\u202C\u202E\u202B\u202A\u202D\u200E\u202A\u202D\u202A\u202E\u202C\u200B\u200E\u206B\u206D\u200E\u202C\u202C\u200B\u202D\u200E\u206B\u206F\u206C\u206D\u202E\u200C\u206E\u206D\u206E\u206C\u206C\u200B\u206F\u200B\u202A\u206C\u202E(this))
					{
						for (;;)
						{
							int num = -1758594761;
							switch (-(-(-num)) % 3)
							{
							case 0:
								continue;
							case 2:
								return 3;
							}
							break;
						}
						return 4;
					}
					return 4;
				}
			}

			protected override string GetBaseDescription()
			{
				if (AyaCompletedInterviewDef.AyaCompletedInterview.\u206A\u206F\u202B\u206A\u206E\u202A\u206D\u200D\u202D\u200D\u202C\u200B\u200B\u206D\u202A\u206B\u202D\u200E\u206C\u206B\u200E\u206D\u202B\u206C\u202D\u200F\u206F\u200F\u206A\u202B\u202D\u202A\u202C\u206D\u206B\u200B\u200B\u202E\u200D\u200C\u202E(this))
				{
					for (;;)
					{
						int num = 125999169;
						switch (-(num * 904616935 + ((-175406559 - -182161987) ^ (1398701734 - 852146395))) * -1120700403 % 3)
						{
						case 0:
							continue;
						case 2:
							goto IL_004B;
						}
						break;
					}
					goto IL_0061;
					IL_004B:
					return base.GetBaseDescription();
				}
				IL_0061:
				return base.ExtraDescription1;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaCompletedInterviewDef.AyaCompletedInterview.<Actions>d__3 <Actions>d__ = new AyaCompletedInterviewDef.AyaCompletedInterview.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u200D\u200F\u202D\u202C\u202E\u202B\u202A\u202D\u200E\u202A\u202D\u202A\u202E\u202C\u200B\u200E\u206B\u206D\u200E\u202C\u202C\u200B\u202D\u200E\u206B\u206F\u206C\u206D\u202E\u200C\u206E\u206D\u206E\u206C\u206C\u200B\u206F\u200B\u202A\u206C\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static bool \u206A\u206F\u202B\u206A\u206E\u202A\u206D\u200D\u202D\u200D\u202C\u200B\u200B\u206D\u202A\u206B\u202D\u200E\u206C\u206B\u200E\u206D\u202B\u206C\u202D\u200F\u206F\u200F\u206A\u202B\u202D\u202A\u202C\u206D\u206B\u200B\u200B\u202E\u200D\u200C\u202E(Card A_0)
			{
				return A_0.DebutActive;
			}
		}
	}
}
