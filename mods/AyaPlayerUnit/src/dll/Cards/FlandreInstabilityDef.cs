using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using LBoL.Base;
using LBoL.Base.Extensions;
using LBoL.ConfigData;
using LBoL.Core;
using LBoL.Core.Battle;
using LBoL.Core.Cards;
using LBoL.Core.Randoms;
using LBoL.Core.StatusEffects;
using LBoL.EntityLib.Cards.Neutral.Green;
using LBoL.EntityLib.StatusEffects.Basic;
using LBoL.EntityLib.StatusEffects.Cirno;
using LBoL.EntityLib.StatusEffects.Koishi;
using LBoL.EntityLib.StatusEffects.Marisa;
using LBoL.EntityLib.StatusEffects.Neutral.Black;
using LBoL.EntityLib.StatusEffects.Neutral.Blue;
using LBoL.EntityLib.StatusEffects.Neutral.Green;
using LBoL.EntityLib.StatusEffects.Neutral.MultiColor;
using LBoL.EntityLib.StatusEffects.Neutral.Red;
using LBoL.EntityLib.StatusEffects.Neutral.TwoColor;
using LBoL.EntityLib.StatusEffects.Neutral.White;
using LBoL.EntityLib.StatusEffects.Others;
using LBoL.EntityLib.StatusEffects.Reimu;
using LBoL.EntityLib.StatusEffects.Sakuya;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class FlandreInstabilityDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(357242942);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreInstabilityDef.\u206B\u200B\u206E\u200C\u202B\u202D\u206B\u200E\u200E\u202D\u206A\u202A\u200D\u206B\u202C\u206B\u206A\u200E\u202D\u200E\u200B\u206B\u206B\u200B\u202B\u202B\u206D\u206E\u202C\u200B\u206D\u206E\u206A\u206E\u202C\u202E\u200B\u200D\u206C\u206A\u202E(BepinexPlugin.embeddedSource);
			FlandreInstabilityDef.\u200C\u206E\u202E\u206B\u206A\u200E\u206F\u200D\u200C\u206E\u206C\u206B\u202E\u200E\u206C\u202C\u200D\u202E\u200F\u202B\u200F\u202A\u206C\u202A\u206F\u200F\u200F\u206F\u206A\u200C\u200F\u202E\u206B\u200D\u206B\u202A\u200C\u206F\u202A\u206E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreInstabilityDef.\u206C\u200B\u202B\u206B\u202B\u206E\u206F\u206B\u200C\u206F\u200E\u206F\u200B\u202E\u200F\u202A\u200F\u200F\u200C\u200E\u200C\u202D\u202D\u202E\u202D\u202D\u206D\u206A\u206D\u202A\u200D\u200E\u206E\u200B\u200E\u206B\u200E\u206A\u206C\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreInstabilityDef.\u200C\u200D\u206C\u206A\u202E\u200F\u200F\u200B\u202D\u202D\u206C\u206F\u206C\u206B\u202B\u200F\u200D\u200F\u202A\u206A\u206C\u200B\u200B\u200D\u206B\u200E\u206E\u206C\u200F\u202B\u206D\u200B\u202E\u202C\u206B\u200F\u206F\u206E\u202E(BepinexPlugin.sequenceTable, FlandreInstabilityDef.\u202A\u206A\u202A\u200D\u202B\u200D\u202A\u200F\u200F\u200B\u200D\u200F\u200F\u206D\u206E\u206B\u200B\u206B\u202B\u206E\u206B\u200B\u200D\u202A\u202D\u202A\u202C\u200E\u202C\u202E\u206D\u206B\u206F\u206C\u200D\u202B\u206A\u206C\u200C\u206E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, true, true, false, false, true, Rarity.Uncommon, CardType.Skill, new TargetType?(TargetType.SingleEnemy), new List<ManaColor> { ManaColor.Colorless }, false, new ManaGroup
			{
				Any = 2
			}, null, null, null, null, null, null, null, null, null, null, new int?(0), null, new int?(0), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(190666399), new List<string>());
		}

		static CardImages \u206B\u200B\u206E\u200C\u202B\u202D\u206B\u200E\u200E\u202D\u206A\u202A\u200D\u206B\u202C\u206B\u206A\u200E\u202D\u200E\u200B\u206B\u206B\u200B\u202B\u202B\u206D\u206E\u202C\u200B\u206D\u206E\u206A\u206E\u202C\u202E\u200B\u200D\u206C\u206A\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u206E\u202E\u206B\u206A\u200E\u206F\u200D\u200C\u206E\u206C\u206B\u202E\u200E\u206C\u202C\u200D\u202E\u200F\u202B\u200F\u202A\u206C\u202A\u206F\u200F\u200F\u206F\u206A\u200C\u200F\u202E\u206B\u200D\u206B\u202A\u200C\u206F\u202A\u206E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u200B\u202B\u206B\u202B\u206E\u206F\u206B\u200C\u206F\u200E\u206F\u200B\u202E\u200F\u202A\u200F\u200F\u200C\u200E\u200C\u202D\u202D\u202E\u202D\u202D\u206D\u206A\u206D\u202A\u200D\u200E\u206E\u200B\u200E\u206B\u200E\u206A\u206C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u206A\u202A\u200D\u202B\u200D\u202A\u200F\u200F\u200B\u200D\u200F\u200F\u206D\u206E\u206B\u200B\u206B\u202B\u206E\u206B\u200B\u200D\u202A\u202D\u202A\u202C\u200E\u202C\u202E\u206D\u206B\u206F\u206C\u200D\u202B\u206A\u206C\u200C\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u200D\u206C\u206A\u202E\u200F\u200F\u200B\u202D\u202D\u206C\u206F\u206C\u206B\u202B\u200F\u200D\u200F\u202A\u206A\u206C\u200B\u200B\u200D\u206B\u200E\u206E\u206C\u200F\u202B\u206D\u200B\u202E\u202C\u206B\u200F\u206F\u206E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreInstabilityDef))]
		public sealed class FlandreInstability : FlandreCard
		{
			public string InstabilityBlock
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(571597354), true, true);
				}
			}

			public string InstabilityBarrier
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1229925838), true, true);
				}
			}

			public string InstabilityMana
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1116192094), true, true);
				}
			}

			public string InstabilityScry
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-843239754), true, true);
				}
			}

			public string InstabilityDream
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(794249847), true, true);
				}
			}

			public string InstabilityCleanse
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(205148716), true, true);
				}
			}

			public string InstabilityHeal
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-986583034), true, true);
				}
			}

			public string InstabilityGold
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(512316507), true, true);
				}
			}

			public string InstabilityPower
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-964419085), true, true);
				}
			}

			public string InstabilityUpgrade
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(145867869), true, true);
				}
			}

			public string InstabilityDamage1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2102501281), true, true);
				}
			}

			public string InstabilityDamage2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(404893874), true, true);
				}
			}

			public string InstabilityDamage3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1618255370), true, true);
				}
			}

			public string InstabilityAdd1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(705975921), true, true);
				}
			}

			public string InstabilityAdd2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1465315978), true, true);
				}
			}

			public string InstabilityAdd3
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2055982899), true, true);
				}
			}

			public string InstabilityDraw1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1252306401), true, true);
				}
			}

			public string InstabilityDraw2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-468592331), true, true);
				}
			}

			public string InstabilityDiscard1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-157476405), true, true);
				}
			}

			public string InstabilityDiscard2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1831764616), true, true);
				}
			}

			public string InstabilityExile1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1157765478), true, true);
				}
			}

			public string InstabilityExile2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-209449024), true, true);
				}
			}

			public string InstabilityMove1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1258396225), true, true);
				}
			}

			public string InstabilityMove2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1846938625), true, true);
				}
			}

			public string InstabilityRetain1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-352792304), true, true);
				}
			}

			public string InstabilityRetain2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1011056451), true, true);
				}
			}

			public string InstabilityBuff1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-435196747), true, true);
				}
			}

			public string InstabilityBuff2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(442353393), true, true);
				}
			}

			public string InstabilityDebuff1
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1392386132), true, true);
				}
			}

			public string InstabilityDebuff2
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-595602182), true, true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (FlandreInstabilityDef.FlandreInstability.\u206C\u206C\u206D\u200E\u202A\u202B\u200E\u200D\u202B\u206A\u200B\u206B\u200D\u200D\u200F\u206B\u200C\u202B\u206C\u200B\u202B\u202C\u206A\u200C\u206A\u202E\u202E\u206D\u206A\u202B\u200F\u206C\u202B\u202A\u200F\u206E\u200E\u202C\u206C\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_011C;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)((974903933 - -1331712338 - ((num ^ (1333499525 - (2143888902 + 347556315) + (-914459296 + -1247887233 - (-1081391993 ^ -849960336)))) + ~(-1318027686 + 1298251254))) ^ 541481322)) % 25U)
					{
					case 0U:
						goto IL_018E;
					case 1U:
						goto IL_02D2;
					case 2U:
						goto IL_0231;
					case 3U:
					{
						int num4 = FlandreInstabilityDef.FlandreInstability.\u200D\u206A\u206D\u200B\u202A\u200F\u206A\u206C\u200C\u206B\u200C\u206B\u200F\u206B\u202B\u206E\u200E\u202E\u200B\u206F\u200B\u202C\u200D\u200F\u202D\u202B\u206A\u206F\u200E\u200F\u200E\u200C\u202C\u206B\u200B\u206D\u202A\u206C\u206A\u202B\u202E(this);
						num2 = -1489047132;
						continue;
					}
					case 4U:
						goto IL_0343;
					case 5U:
					{
						int num4;
						if (num4 != 1)
						{
							num2 = (int)((num3 * 3266063853U) ^ 3228479086U);
							continue;
						}
						goto IL_13A3;
					}
					case 6U:
						num2 = ((!base.HasExtraDescription1) ? (-1081608544) : (-1999342459));
						continue;
					case 7U:
						goto IL_0269;
					case 8U:
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						num2 = (int)((num3 * 1592168773U) ^ 2889329450U);
						continue;
					case 9U:
						goto IL_0010;
					case 10U:
						goto IL_0200;
					case 11U:
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription2);
						num2 = (int)((num3 * 3076355368U) ^ 3685075475U);
						continue;
					case 12U:
					{
						int num4;
						if (num4 != 2)
						{
							num2 = (int)((num3 * 807720230U) ^ 4118330343U);
							continue;
						}
						goto IL_136C;
					}
					case 13U:
						if (FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u200F\u200F\u200E\u200B\u202C\u206E\u200B\u202C\u206D\u200F\u200D\u206A\u206C\u202D\u202C\u200E\u206C\u200D\u200B\u200C\u202E\u206D\u206A\u206B\u200E\u202E\u206B\u206A\u206B\u200C\u200B\u206F\u200F\u206E\u200B\u200B\u200E\u202D\u202E(this) != null)
						{
							num2 = (int)((num3 * 3886957358U) ^ 1562461093U);
							continue;
						}
						goto IL_12C4;
					case 14U:
						goto IL_0252;
					case 16U:
						goto IL_0218;
					case 17U:
						switch (FlandreInstabilityDef.FlandreInstability.\u202C\u200F\u200B\u200B\u200E\u202E\u202E\u200B\u206E\u200E\u200D\u202A\u200C\u200F\u202A\u200E\u200C\u206F\u206B\u206F\u206C\u200F\u202D\u202A\u202D\u202D\u200B\u200B\u206D\u200D\u202E\u202E\u206B\u200C\u202A\u202B\u202E\u202C\u206A\u200E\u202E(this))
						{
						case FriendToken.None:
							goto IL_0231;
						case FriendToken.Active:
							goto IL_02D2;
						case FriendToken.Active2:
							goto IL_0252;
						case FriendToken.Ultimate:
							goto IL_018E;
						default:
							num2 = (int)((num3 * 78207059U) ^ 2451888725U);
							continue;
						}
						break;
					case 18U:
						if (base.HasExtraDescription3)
						{
							num2 = -595432954;
							continue;
						}
						goto IL_13B4;
					case 19U:
						goto IL_036D;
					case 20U:
						num2 = (int)((num3 * 3093910246U) ^ 2718104616U);
						continue;
					case 21U:
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, FlandreInstabilityDef.FlandreInstability.\u202A\u206B\u206A\u200B\u202C\u206E\u206E\u202A\u202C\u206E\u202E\u200E\u206D\u206E\u200C\u200C\u200F\u206C\u206D\u206D\u200E\u202E\u206A\u200F\u202E\u202A\u200D\u200B\u200D\u206F\u202A\u206F\u206F\u202D\u206A\u206A\u206D\u206F\u206F\u206B\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						num2 = -1822375818;
						continue;
					case 22U:
						goto IL_011C;
					case 23U:
						num2 = ((!base.HasExtraDescription2) ? (-380215493) : (-1832759495));
						continue;
					case 24U:
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
						text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription1);
						num2 = (int)((num3 * 4169872729U) ^ 3919408341U);
						continue;
					}
					goto Block_1;
					IL_0231:
					num2 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206C\u206D\u200E\u202A\u202B\u200E\u200D\u202B\u206A\u200B\u206B\u200D\u200D\u200F\u206B\u200C\u202B\u206C\u200B\u202B\u202C\u206A\u200C\u206A\u202E\u202E\u206D\u206A\u202B\u200F\u206C\u202B\u202A\u200F\u206E\u200E\u202C\u206C\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this))) ? (-308452716) : (-1822375818));
					continue;
					IL_0252:
					text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription2);
					num2 = -235907451;
					continue;
					IL_02D2:
					text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription1);
					num2 = -1307197910;
				}
				int num5;
				for (;;)
				{
					IL_12D4:
					int num = num5;
					uint num3;
					switch ((num3 = (uint)((974903933 - -1331712338 - ((num ^ (1333499525 - (2143888902 + 347556315) + (-914459296 + -1247887233 - (-1081391993 ^ -849960336)))) + ~(-1318027686 + 1298251254))) ^ 541481322)) % 7U)
					{
					case 0U:
						goto IL_13A3;
					case 1U:
						goto IL_136C;
					case 2U:
						num5 = (int)((num3 * 1265252780U) ^ 892450530U);
						continue;
					case 4U:
						goto IL_12CF;
					case 5U:
						num5 = (int)((num3 * 154292612U) ^ 2603652278U);
						continue;
					case 6U:
						goto IL_1349;
					}
					break;
				}
				goto IL_13B4;
				IL_1349:
				string text2 = base.BaseDescription;
				goto IL_1361;
				Block_1:
				goto IL_0392;
				IL_018E:
				text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription3);
				IL_0200:
				goto IL_13B4;
				IL_0218:
				return string.Empty;
				IL_0269:
				goto IL_13B4;
				IL_0343:
				throw FlandreInstabilityDef.FlandreInstability.\u200D\u202C\u206D\u202B\u206C\u206E\u206F\u202B\u200D\u202D\u206D\u202B\u206D\u206E\u202E\u200B\u202A\u200F\u206B\u200C\u200B\u202B\u200F\u202A\u206D\u200C\u200C\u200D\u206F\u206F\u206B\u202A\u206C\u202A\u202D\u202C\u202E\u200F\u206C\u202E();
				IL_036D:
				text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, base.GetExtraDescription3);
				goto IL_13B4;
				IL_0392:
				using (List<FlandreInstabilityDef.FlandreInstability.EffectType>.Enumerator enumerator = this.SelectedEffects.GetEnumerator())
				{
					for (;;)
					{
						IL_126E:
						int num6 = ((!enumerator.MoveNext()) ? (-801487479) : (-320110628));
						for (;;)
						{
							int num = num6;
							uint num3;
							switch ((num3 = (uint)((974903933 - -1331712338 - ((num ^ (1333499525 - (2143888902 + 347556315) + (-914459296 + -1247887233 - (-1081391993 ^ -849960336)))) + ~(-1318027686 + 1298251254))) ^ 541481322)) % 122U)
							{
							case 0U:
							{
								int num7;
								num6 = (int)(((num7 != 2) ? 4060676433U : 4232628308U) ^ (num3 * 755864707U));
								continue;
							}
							case 1U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 293965456U) ^ 4048786244U);
								continue;
							case 2U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 1526550401U) ^ 2902522678U);
								continue;
							case 3U:
								num6 = (int)((num3 * 1766744605U) ^ 4265464306U);
								continue;
							case 4U:
							{
								int num7;
								num6 = (int)(((num7 == 1) ? 1856434255U : 418578627U) ^ (num3 * 205910884U));
								continue;
							}
							case 5U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDraw2);
								num6 = -109887523;
								continue;
							case 6U:
							{
								int num7;
								num6 = (int)(((num7 == 1) ? 74042442U : 290634053U) ^ (num3 * 2157649693U));
								continue;
							}
							case 7U:
								num6 = (int)((num3 * 3468071936U) ^ 449268701U);
								continue;
							case 8U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityBuff1);
								num6 = -1806644665;
								continue;
							case 9U:
								goto IL_10A2;
							case 10U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDebuff1);
								num6 = -109887523;
								continue;
							case 11U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 3748935890U) ^ 4079598354U);
								continue;
							case 12U:
								goto IL_0A99;
							case 13U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityBuff2);
								num6 = -405162229;
								continue;
							case 14U:
								num6 = (int)((num3 * 3451605602U) ^ 390315569U);
								continue;
							case 15U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityCleanse);
								num6 = 1088037063;
								continue;
							case 16U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDiscard2);
								num6 = -1614063288;
								continue;
							case 17U:
								goto IL_11AA;
							case 18U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 1276504747U) ^ 890440022U);
								continue;
							case 19U:
								goto IL_081E;
							case 20U:
								goto IL_0B4D;
							case 21U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 4003348011U) ^ 648637857U);
								continue;
							case 22U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDream);
								num6 = -1709642158;
								continue;
							case 24U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityExile2);
								num6 = -1672061111;
								continue;
							case 25U:
								goto IL_0BDA;
							case 26U:
								num6 = (int)((num3 * 2704989149U) ^ 186702099U);
								continue;
							case 27U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 3235775865U) ^ 1620289239U);
								continue;
							case 28U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityGold);
								num6 = -1228395354;
								continue;
							case 29U:
							{
								int num7;
								num6 = (int)(((num7 != 2) ? 3122373458U : 3510121305U) ^ (num3 * 4080555123U));
								continue;
							}
							case 30U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
								num6 = (int)((num3 * 3546949814U) ^ 253426259U);
								continue;
							case 31U:
								num6 = (int)((num3 * 2977402726U) ^ 1717202887U);
								continue;
							case 32U:
							{
								int num7 = this.DrawEffectType;
								num6 = -1970487946;
								continue;
							}
							case 33U:
								num6 = (int)((num3 * 485788526U) ^ 3250387227U);
								continue;
							case 34U:
							{
								int num7 = this.RetainEffectType;
								num6 = ((num7 != 1) ? (-1650614916) : (-771312970));
								continue;
							}
							case 35U:
							{
								int num7;
								num6 = (int)(((num7 == 2) ? 2031130634U : 405625821U) ^ (num3 * 2087783788U));
								continue;
							}
							case 36U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityMove2);
								num6 = -1140150634;
								continue;
							case 37U:
								num6 = (int)((num3 * 2717702583U) ^ 3434028274U);
								continue;
							case 38U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 2682395616U) ^ 2250262960U);
								continue;
							case 39U:
							{
								int num7 = this.DamageEffectType;
								switch (num7)
								{
								case 1:
									goto IL_0851;
								case 2:
									goto IL_0B4D;
								case 3:
									goto IL_081E;
								default:
									num6 = -1364112920;
									continue;
								}
								break;
							}
							case 40U:
							{
								int num7 = this.ExileEffectType;
								num6 = ((num7 == 1) ? (-414300636) : (-150331643));
								continue;
							}
							case 41U:
								num6 = (int)((num3 * 3930932672U) ^ 1516109469U);
								continue;
							case 42U:
								num6 = -320110628;
								continue;
							case 43U:
								num6 = (int)((num3 * 2949111037U) ^ 1204350970U);
								continue;
							case 44U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityBarrier);
								num6 = -109887523;
								continue;
							case 45U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDebuff2);
								num6 = -109887523;
								continue;
							case 46U:
								num6 = (int)((num3 * 907066256U) ^ 4158850077U);
								continue;
							case 47U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityScry);
								num6 = -653661326;
								continue;
							case 48U:
							{
								int num7;
								switch (num7)
								{
								case 1:
									goto IL_11AA;
								case 2:
									goto IL_095B;
								case 3:
									goto IL_0BDA;
								default:
									num6 = (int)((num3 * 3627293848U) ^ 652141980U);
									continue;
								}
								break;
							}
							case 49U:
								num6 = (int)((num3 * 2465750982U) ^ 3678226791U);
								continue;
							case 50U:
								num6 = (int)((num3 * 3909947964U) ^ 1667493749U);
								continue;
							case 51U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityPower);
								num6 = -109887523;
								continue;
							case 52U:
							{
								int num7;
								num6 = (int)(((num7 == 2) ? 4056190126U : 3937494492U) ^ (num3 * 2149771506U));
								continue;
							}
							case 53U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
								num6 = (int)((num3 * 3922439897U) ^ 1436710845U);
								continue;
							case 54U:
								num6 = (int)((num3 * 881442079U) ^ 3266881541U);
								continue;
							case 55U:
								num6 = (int)((num3 * 998922144U) ^ 1611024189U);
								continue;
							case 56U:
								num6 = (int)((num3 * 585051273U) ^ 137629427U);
								continue;
							case 57U:
								num6 = (int)((num3 * 4198556558U) ^ 3246486931U);
								continue;
							case 58U:
								num6 = (int)((num3 * 900744441U) ^ 4205332949U);
								continue;
							case 59U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 2318614956U) ^ 2205489349U);
								continue;
							case 60U:
								num6 = (int)((num3 * 2670352236U) ^ 2499868125U);
								continue;
							case 61U:
								goto IL_126E;
							case 62U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
								num6 = (int)((num3 * 1448087081U) ^ 1981349117U);
								continue;
							case 63U:
								num6 = (int)((num3 * 1721171607U) ^ 2047493582U);
								continue;
							case 64U:
								num6 = (int)((num3 * 1299779206U) ^ 1606952789U);
								continue;
							case 65U:
								goto IL_0E48;
							case 66U:
							{
								int num7;
								num6 = (int)(((num7 == 2) ? 1261814535U : 2571719985U) ^ (num3 * 3756442717U));
								continue;
							}
							case 67U:
							{
								int num7;
								num6 = (int)(((num7 != 1) ? 3058521504U : 3005707104U) ^ (num3 * 2009119522U));
								continue;
							}
							case 68U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 347002107U) ^ 4256841017U);
								continue;
							case 69U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityBlock);
								num6 = 1192992797;
								continue;
							case 70U:
								goto IL_072F;
							case 71U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
								num6 = (int)((num3 * 3938130378U) ^ 4265653957U);
								continue;
							case 72U:
								goto IL_0835;
							case 73U:
								num6 = (int)((num3 * 1436325980U) ^ 2638970689U);
								continue;
							case 74U:
								goto IL_0E8B;
							case 75U:
								goto IL_121A;
							case 76U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityMana);
								num6 = -201731717;
								continue;
							case 77U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDiscard1);
								num6 = -1395292979;
								continue;
							case 78U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityExile1);
								num6 = -46164797;
								continue;
							case 79U:
								goto IL_0D7D;
							case 80U:
								num6 = (int)((num3 * 366200800U) ^ 306874141U);
								continue;
							case 81U:
								num6 = (int)((num3 * 1847071520U) ^ 4041292285U);
								continue;
							case 82U:
								goto IL_095B;
							case 83U:
								num6 = (int)((num3 * 1155519903U) ^ 2291701940U);
								continue;
							case 84U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityUpgrade);
								num6 = -109887523;
								continue;
							case 85U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityMove1);
								num6 = -297996785;
								continue;
							case 86U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 2444365875U) ^ 1028396043U);
								continue;
							case 87U:
								goto IL_0851;
							case 88U:
								goto IL_0EC8;
							case 89U:
							{
								int num7;
								num6 = (int)(((num7 != 2) ? 3980964010U : 3326479790U) ^ (num3 * 4294413731U));
								continue;
							}
							case 90U:
								goto IL_0A7D;
							case 91U:
								num6 = (int)((num3 * 2072964547U) ^ 4077130088U);
								continue;
							case 92U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
								num6 = (int)((num3 * 2119492147U) ^ 499529982U);
								continue;
							case 93U:
							{
								int num7 = this.AddEffectType;
								num6 = -372190046;
								continue;
							}
							case 94U:
								goto IL_074B;
							case 95U:
								num6 = (int)((num3 * 3981087735U) ^ 306049434U);
								continue;
							case 96U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityRetain2);
								num6 = -109887523;
								continue;
							case 97U:
							{
								int num7 = this.DiscardEffectType;
								num6 = ((num7 == 1) ? (-278688601) : (-932204488));
								continue;
							}
							case 98U:
								goto IL_07EF;
							case 99U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
								num6 = (int)((num3 * 3623707929U) ^ 2083583312U);
								continue;
							case 100U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityHeal);
								num6 = 1132640905;
								continue;
							case 101U:
								goto IL_0FBD;
							case 102U:
							{
								int num7 = this.BuffEffectType;
								num6 = ((num7 == 1) ? (-1365453316) : (-1195126007));
								continue;
							}
							case 103U:
							{
								int num7 = this.DebuffEffectType;
								num6 = -1266277951;
								continue;
							}
							case 104U:
							{
								int num7 = this.MoveEffectType;
								num6 = -1784608216;
								continue;
							}
							case 105U:
								num6 = (int)((num3 * 2317812315U) ^ 114800400U);
								continue;
							case 106U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(251084289));
								num6 = (int)((num3 * 3373698903U) ^ 1409528872U);
								continue;
							case 107U:
								goto IL_0616;
							case 108U:
								switch (enumerator.Current)
								{
								case FlandreInstabilityDef.FlandreInstability.EffectType.Block:
									goto IL_09E4;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Barrier:
									goto IL_0E8B;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Mana:
									goto IL_074B;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Scry:
									goto IL_0D7D;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Dream:
									goto IL_0A99;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Cleanse:
									goto IL_08DE;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Heal:
									goto IL_0E48;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Gold:
									goto IL_0FBD;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Power:
									goto IL_121A;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Upgrade:
									goto IL_10A2;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Damage:
									goto IL_0616;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Add:
									goto IL_072F;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Draw:
									goto IL_1155;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Discard:
									goto IL_0A7D;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Exile:
									goto IL_07EF;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Move:
									goto IL_0835;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Retain:
									goto IL_0D61;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Buff:
									goto IL_11D8;
								case FlandreInstabilityDef.FlandreInstability.EffectType.Debuff:
									goto IL_0EC8;
								default:
									num6 = -913024655;
									continue;
								}
								break;
							case 109U:
								num6 = (int)((num3 * 940889898U) ^ 361152867U);
								continue;
							case 110U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDraw1);
								num6 = -109887523;
								continue;
							case 111U:
								goto IL_08DE;
							case 112U:
								num6 = (int)((num3 * 3110960437U) ^ 2856694011U);
								continue;
							case 113U:
								goto IL_11D8;
							case 114U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityRetain1);
								num6 = -1157180639;
								continue;
							case 115U:
								goto IL_1155;
							case 116U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
								num6 = (int)((num3 * 862367250U) ^ 2310243538U);
								continue;
							case 117U:
							{
								int num7;
								num6 = (int)(((num7 != 2) ? 854406143U : 352862326U) ^ (num3 * 4025600071U));
								continue;
							}
							case 118U:
								goto IL_0D61;
							case 119U:
								goto IL_09E4;
							case 120U:
								text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
								num6 = (int)((num3 * 1967815368U) ^ 1128792113U);
								continue;
							case 121U:
								num6 = (int)((num3 * 2841782448U) ^ 545601901U);
								continue;
							}
							goto Block_17;
							IL_0616:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? 1149066067 : (-1423728085));
							continue;
							IL_072F:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1335734540) : 1076593069);
							continue;
							IL_074B:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-888249367) : (-1438681926));
							continue;
							IL_07EF:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1474564078) : (-1618999354));
							continue;
							IL_081E:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDamage3);
							num6 = -1893895665;
							continue;
							IL_0835:
							num6 = (FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text) ? (-33249880) : (-539334675));
							continue;
							IL_0851:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDamage1);
							num6 = -109887523;
							continue;
							IL_08DE:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1402616319) : (-873331575));
							continue;
							IL_095B:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityAdd2);
							num6 = -1366785216;
							continue;
							IL_09E4:
							num6 = (FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text) ? (-1676363427) : (-67515370));
							continue;
							IL_0A7D:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1455936195) : (-1999394259));
							continue;
							IL_0A99:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-135057224) : (-319725406));
							continue;
							IL_0B4D:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityDamage2);
							num6 = 1167643834;
							continue;
							IL_0BDA:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityAdd3);
							num6 = -163374757;
							continue;
							IL_0D61:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1080150876) : (-1909346154));
							continue;
							IL_0D7D:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-212394060) : (-10323551));
							continue;
							IL_0E48:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1450679563) : (-1164573646));
							continue;
							IL_0E8B:
							num6 = (FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text) ? (-375051408) : (-612515092));
							continue;
							IL_0EC8:
							num6 = (FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text) ? (-1458318911) : (-869103130));
							continue;
							IL_0FBD:
							num6 = (FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text) ? 1099993534 : (-58351166));
							continue;
							IL_10A2:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1316839414) : (-824694586));
							continue;
							IL_1155:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? 1101150389 : (-1379897544));
							continue;
							IL_11AA:
							text = FlandreInstabilityDef.FlandreInstability.\u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(text, this.InstabilityAdd1);
							num6 = -109887523;
							continue;
							IL_11D8:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-1330984699) : (-1449027820));
							continue;
							IL_121A:
							num6 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(text)) ? (-277368378) : (-2141103109));
						}
					}
					Block_17:
					goto IL_13B4;
				}
				IL_12C4:
				if (FlandreInstabilityDef.FlandreInstability.\u202A\u206B\u206A\u200B\u202C\u206E\u206E\u202A\u202C\u206E\u202E\u200E\u206D\u206E\u200C\u200C\u200F\u206C\u206D\u206D\u200E\u202E\u206A\u200F\u202E\u202A\u200D\u200B\u200D\u206F\u202A\u206F\u206F\u202D\u206A\u206A\u206D\u206F\u206F\u206B\u202E(this))
				{
					text2 = base.UpgradedBaseDescription ?? base.BaseDescription;
					goto IL_1361;
				}
				IL_12CF:
				num5 = -1619853901;
				goto IL_12D4;
				IL_1361:
				text = text2;
				num5 = 1159480218;
				goto IL_12D4;
				IL_136C:
				text = base.GetExtraDescription2;
				num5 = -1841500121;
				goto IL_12D4;
				IL_13A3:
				text = base.GetExtraDescription1;
				num5 = -2103957194;
				goto IL_12D4;
				IL_13B4:
				return base.FollowByDetailIcon(text);
				IL_0010:
				num2 = -730910588;
				goto IL_0015;
				IL_011C:
				text = string.Empty;
				num2 = ((FlandreInstabilityDef.FlandreInstability.\u202E\u200E\u206D\u206E\u206E\u202D\u206C\u206A\u202D\u206F\u206B\u202E\u202B\u200E\u206D\u206E\u206D\u200C\u202B\u200F\u202E\u206E\u206F\u200C\u200C\u202E\u206A\u206A\u202B\u206B\u202B\u206F\u206E\u200F\u202A\u200F\u206F\u200E\u206E\u206B\u202E(this) == CardType.Friend) ? (-1977328356) : 1097673866);
				goto IL_0015;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (FlandreInstabilityDef.FlandreInstability.\u200E\u206F\u206D\u202E\u202E\u200F\u202D\u206F\u200F\u206C\u202E\u200D\u202D\u206A\u200D\u202B\u206B\u202E\u202E\u200D\u200D\u200B\u206B\u206D\u200C\u200F\u200F\u200B\u202A\u206C\u200F\u206A\u206C\u200C\u202A\u206E\u200D\u200D\u202A\u206D\u202E(key, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1029965993)))
				{
					for (;;)
					{
						IL_0017:
						int num = 815683379;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((-(-853299675 * -1250060737) * -1164386709 - num2) * 1563496641)) % 7U)
							{
							case 1U:
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).RelativeCards = new List<string>();
								num = (int)((num3 * 2213331558U) ^ 1159436369U);
								continue;
							case 2U:
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).RelativeEffects = new List<string>();
								num = (int)((num3 * 2748497141U) ^ 3254840257U);
								continue;
							case 3U:
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).UpgradedRelativeCards = new List<string>();
								num = (int)((num3 * 3735110646U) ^ 2615218289U);
								continue;
							case 4U:
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).RelativeKeyword = Keyword.None;
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).UpgradedRelativeKeyword = Keyword.None;
								num = (int)((num3 * 2728756931U) ^ 2846726868U);
								continue;
							case 5U:
								goto IL_0017;
							case 6U:
								FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this).UpgradedRelativeEffects = new List<string>();
								num = (int)((num3 * 3814742383U) ^ 1160885968U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:
					using (List<FlandreInstabilityDef.FlandreInstability.EffectType>.Enumerator enumerator = this.SelectedEffects.GetEnumerator())
					{
						for (;;)
						{
							IL_046A:
							int num4 = ((!enumerator.MoveNext()) ? 652315004 : 881394212);
							for (;;)
							{
								int num2 = num4;
								uint num3;
								ManaGroup manaValue;
								int buffEffectType;
								switch ((num3 = (uint)((-(-853299675 * -1250060737) * -1164386709 - num2) * 1563496641)) % 70U)
								{
								case 0U:
									num4 = 881394212;
									continue;
								case 1U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Ethereal)) ? 1832697773 : 456417040);
									continue;
								case 2U:
									num4 = (int)(((!manaValue.HasColor(ManaColor.Philosophy)) ? 268573789U : 2916396682U) ^ (num3 * 744664934U));
									continue;
								case 3U:
								{
									CardConfig cardConfig = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig) ^ Keyword.Philosophy;
									num4 = (int)((num3 * 4114995494U) ^ 3608704985U);
									continue;
								}
								case 4U:
									num4 = ((this.AddEffectType != 1) ? 1408139761 : 1217855089);
									continue;
								case 5U:
									num4 = (int)((num3 * 1676213667U) ^ 3993418264U);
									continue;
								case 6U:
								{
									CardConfig cardConfig2 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig2.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig2) ^ Keyword.Power;
									num4 = (int)((num3 * 1747954861U) ^ 2681618181U);
									continue;
								}
								case 7U:
								{
									CardConfig cardConfig3 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig3.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig3) ^ Keyword.Block;
									num4 = (int)((num3 * 4184930036U) ^ 3140860568U);
									continue;
								}
								case 8U:
									goto IL_0BAC;
								case 9U:
								{
									CardConfig cardConfig4 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig4.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig4) ^ Keyword.Shield;
									num4 = (int)((num3 * 2150400279U) ^ 2704931865U);
									continue;
								}
								case 10U:
									goto IL_0CFE;
								case 11U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u202C\u200F\u200B\u200B\u200E\u200B\u206F\u206D\u206C\u206D\u202C\u202B\u202C\u206E\u200B\u202A\u206F\u206D\u202D\u200F\u206D\u202A\u200C\u202A\u206D\u206D\u200E\u202A\u206B\u200C\u206B\u206A\u202C\u206C\u206D\u200B\u200F\u200E\u202B\u202A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Add);
									num4 = (int)((num3 * 948514043U) ^ 707352960U);
									continue;
								case 12U:
									goto IL_036A;
								case 13U:
									goto IL_0982;
								case 14U:
								{
									CardConfig cardConfig5 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig5.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig5) ^ Keyword.Ethereal;
									num4 = (int)((num3 * 1058887959U) ^ 434790518U);
									continue;
								}
								case 15U:
								{
									CardConfig cardConfig6 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig6.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig6) ^ Keyword.Block;
									num4 = (int)((num3 * 3266131277U) ^ 3937481608U);
									continue;
								}
								case 16U:
								{
									CardConfig cardConfig7 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig7.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig7) ^ Keyword.TempMorph;
									num4 = (int)((num3 * 1259699524U) ^ 1078321748U);
									continue;
								}
								case 17U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Scry)) ? (-936120947) : 1408139761);
									continue;
								case 18U:
									goto IL_046A;
								case 19U:
									num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.TempMorph) ? 785545214 : (-1712154543));
									continue;
								case 20U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u202B\u206E\u202C\u206D\u206D\u200D\u202B\u200B\u206D\u206B\u206C\u206A\u206A\u200B\u206B\u202E\u202D\u200E\u206D\u200E\u206D\u206A\u202E\u202C\u200B\u206B\u200B\u202E\u206A\u202E\u206D\u206D\u202E\u206B\u206C\u206E\u206C\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff2);
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u202E\u200B\u200C\u202B\u200E\u206A\u200B\u200E\u202C\u206D\u200E\u202A\u206D\u200E\u206D\u200D\u200D\u200E\u206C\u206D\u206C\u206E\u206F\u202D\u200E\u202D\u200D\u206D\u202D\u202D\u200B\u200D\u206A\u200B\u200C\u200E\u200F\u206E\u200B\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff1);
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u202E\u200B\u200C\u202B\u200E\u206A\u200B\u200E\u202C\u206D\u200E\u202A\u206D\u200E\u206D\u200D\u200D\u200E\u206C\u206D\u206C\u206E\u206F\u202D\u200E\u202D\u200D\u206D\u202D\u202D\u200B\u200D\u206A\u200B\u200C\u200E\u200F\u206E\u200B\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff2);
									num4 = (int)((num3 * 2153379716U) ^ 3640712137U);
									continue;
								case 21U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Shield)) ? (-1473218296) : 1408139761);
									continue;
								case 22U:
								{
									CardConfig cardConfig8 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig8.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig8) ^ Keyword.Exile;
									num4 = (int)((num3 * 966607372U) ^ 2945954844U);
									continue;
								}
								case 23U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Exile)) ? 960317509 : 2111269700);
									continue;
								case 24U:
									num4 = (int)(((buffEffectType != 2) ? 2783857368U : 1066364623U) ^ (num3 * 331266358U));
									continue;
								case 25U:
								{
									CardConfig cardConfig9 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig9.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig9) ^ Keyword.Exile;
									num4 = (int)((num3 * 1819421356U) ^ 2437180791U);
									continue;
								}
								case 26U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u202E\u200B\u200C\u202B\u200E\u206A\u200B\u200E\u202C\u206D\u200E\u202A\u206D\u200E\u206D\u200D\u200D\u200E\u206C\u206D\u206C\u206E\u206F\u202D\u200E\u202D\u200D\u206D\u202D\u202D\u200B\u200D\u206A\u200B\u200C\u200E\u200F\u206E\u200B\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff1);
									num4 = (int)((num3 * 3531209115U) ^ 1102366279U);
									continue;
								case 27U:
								{
									CardConfig cardConfig10 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig10.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig10) ^ Keyword.Ethereal;
									num4 = (int)((num3 * 2064151242U) ^ 3106844957U);
									continue;
								}
								case 28U:
								{
									CardConfig cardConfig11 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig11.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig11) ^ Keyword.Scry;
									num4 = (int)((num3 * 345208637U) ^ 3176746812U);
									continue;
								}
								case 29U:
									goto IL_0434;
								case 30U:
									num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Philosophy) ? 1408139761 : 1346090501);
									continue;
								case 31U:
									num4 = (int)((num3 * 3106376509U) ^ 1094867258U);
									continue;
								case 32U:
								{
									CardConfig cardConfig12 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig12.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig12) ^ Keyword.TempMorph;
									num4 = (int)((num3 * 1046667063U) ^ 2128129940U);
									continue;
								}
								case 33U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Block)) ? 1017037210 : 1408139761);
									continue;
								case 34U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Ethereal)) ? 1701952480 : (-2107112645));
									continue;
								case 35U:
								{
									CardConfig cardConfig13 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig13.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig13) ^ Keyword.Dream;
									num4 = (int)((num3 * 3089710637U) ^ 1591896830U);
									continue;
								}
								case 36U:
									goto IL_06D8;
								case 37U:
									num4 = (int)((num3 * 1185298666U) ^ 202310331U);
									continue;
								case 38U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u202E\u200B\u200C\u202B\u200E\u206A\u200B\u200E\u202C\u206D\u200E\u202A\u206D\u200E\u206D\u200D\u200D\u200E\u206C\u206D\u206C\u206E\u206F\u202D\u200E\u202D\u200D\u206D\u202D\u202D\u200B\u200D\u206A\u200B\u200C\u200E\u200F\u206E\u200B\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Debuff);
									num4 = (int)((num3 * 3985394510U) ^ 830332825U);
									continue;
								case 39U:
									goto IL_0309;
								case 40U:
									goto IL_0735;
								case 41U:
									num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Exile) ? (-1912125725) : (-2079503800));
									continue;
								case 42U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.TempRetain)) ? 959429596 : 1408139761);
									continue;
								case 43U:
								{
									CardConfig cardConfig14 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig14.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig14) ^ Keyword.Power;
									num4 = (int)((num3 * 232828255U) ^ 2846845620U);
									continue;
								}
								case 44U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u206F\u200E\u202E\u202B\u206F\u200F\u206C\u206A\u202A\u200B\u200F\u206A\u200F\u202C\u200B\u200E\u206A\u202B\u206B\u200E\u206A\u202C\u200E\u200E\u206D\u202C\u200F\u200C\u206A\u200E\u206C\u202C\u202A\u202B\u206F\u202E\u206A\u206F\u202E\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Add);
									num4 = (int)((num3 * 3114585965U) ^ 3842746938U);
									continue;
								case 45U:
								{
									CardConfig cardConfig15 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig15.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig15) ^ Keyword.TempRetain;
									num4 = (int)((num3 * 2427218376U) ^ 2214044007U);
									continue;
								}
								case 46U:
								{
									CardConfig cardConfig16 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig16.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig16) ^ Keyword.Scry;
									num4 = (int)((num3 * 1296615198U) ^ 1911969258U);
									continue;
								}
								case 47U:
									switch (enumerator.Current)
									{
									case FlandreInstabilityDef.FlandreInstability.EffectType.Block:
										goto IL_0CFE;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Barrier:
										goto IL_0487;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Mana:
										goto IL_0AE1;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Scry:
										goto IL_076B;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Dream:
										goto IL_0982;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Cleanse:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Heal:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Gold:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Damage:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Draw:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Discard:
									case FlandreInstabilityDef.FlandreInstability.EffectType.Move:
										goto IL_046A;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Power:
										goto IL_0434;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Upgrade:
										goto IL_06D8;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Add:
										goto IL_0BAC;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Exile:
										goto IL_0735;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Retain:
										goto IL_0309;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Buff:
										goto IL_036A;
									case FlandreInstabilityDef.FlandreInstability.EffectType.Debuff:
										goto IL_056F;
									default:
										num4 = -1788219072;
										continue;
									}
									break;
								case 48U:
								{
									CardConfig cardConfig17 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig17.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig17) ^ Keyword.Exile;
									num4 = (int)((num3 * 137068526U) ^ 4149607121U);
									continue;
								}
								case 49U:
									num4 = (int)((FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Philosophy) ? 1256835759U : 3991473970U) ^ (num3 * 3276536728U));
									continue;
								case 50U:
								{
									CardConfig cardConfig18 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig18.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig18) ^ Keyword.Philosophy;
									num4 = (int)((num3 * 2483118220U) ^ 1327066793U);
									continue;
								}
								case 51U:
								{
									CardConfig cardConfig19 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig19.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig19) ^ Keyword.Dream;
									num4 = (int)((num3 * 284615175U) ^ 2976979065U);
									continue;
								}
								case 52U:
									num4 = (int)((num3 * 1882585992U) ^ 4139158033U);
									continue;
								case 53U:
									goto IL_0AE1;
								case 54U:
									num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Exile) ? 1408139761 : (-79070963));
									continue;
								case 55U:
									goto IL_076B;
								case 56U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u202B\u206E\u202C\u206D\u206D\u200D\u202B\u200B\u206D\u206B\u206C\u206A\u206A\u200B\u206B\u202E\u202D\u200E\u206D\u200E\u206D\u206A\u202E\u202C\u200B\u206B\u200B\u202E\u206A\u202E\u206D\u206D\u202E\u206B\u206C\u206E\u206C\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff1);
									num4 = -677649483;
									continue;
								case 57U:
									goto IL_056F;
								case 58U:
									CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u202B\u206E\u202C\u206D\u206D\u200D\u202B\u200B\u206D\u206B\u206C\u206A\u206A\u200B\u206B\u202E\u202D\u200E\u206D\u200E\u206D\u206A\u202E\u202C\u200B\u206B\u200B\u202E\u206A\u202E\u206D\u206D\u202E\u206B\u206C\u206E\u206C\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Buff1);
									num4 = -1059142167;
									continue;
								case 59U:
								{
									CardConfig cardConfig20 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig20.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig20) ^ Keyword.Upgrade;
									num4 = (int)((num3 * 2572135205U) ^ 3044220330U);
									continue;
								}
								case 60U:
									goto IL_0487;
								case 61U:
									num4 = (int)((num3 * 2733700142U) ^ 687447827U);
									continue;
								case 62U:
								{
									CardConfig cardConfig21 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig21.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig21) ^ Keyword.Exile;
									num4 = (int)((num3 * 1307226073U) ^ 3809736417U);
									continue;
								}
								case 63U:
								{
									CardConfig cardConfig22 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig22.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig22) ^ Keyword.TempRetain;
									num4 = (int)((num3 * 2742743530U) ^ 2502443615U);
									continue;
								}
								case 64U:
								{
									CardConfig cardConfig23 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig23.RelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(cardConfig23) ^ Keyword.Upgrade;
									num4 = (int)((num3 * 236633592U) ^ 2880548167U);
									continue;
								}
								case 65U:
								{
									CardConfig cardConfig24 = FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this);
									cardConfig24.UpgradedRelativeKeyword = FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(cardConfig24) ^ Keyword.Shield;
									num4 = (int)((num3 * 1160416886U) ^ 2205572830U);
									continue;
								}
								case 66U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Power)) ? 1037809011 : 1408139761);
									continue;
								case 68U:
									num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Upgrade)) ? 1597937016 : 1408139761);
									continue;
								case 69U:
									num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Dream) ? 1408139761 : 2090711116);
									continue;
								}
								goto Block_4;
								IL_0309:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.TempRetain)) ? (-779355266) : (-1356713233));
								continue;
								IL_036A:
								buffEffectType = this.BuffEffectType;
								num4 = ((buffEffectType != 1) ? 1708809899 : 1990458975);
								continue;
								IL_0434:
								num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Power) ? 351056057 : 1099780580);
								continue;
								IL_0487:
								num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Shield) ? 1261763544 : 747839504);
								continue;
								IL_056F:
								CollectionExtensions.AddItem<string>(FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u202B\u206E\u202C\u206D\u206D\u200D\u202B\u200B\u206D\u206B\u206C\u206A\u206A\u200B\u206B\u202E\u202D\u200E\u206D\u200E\u206D\u206A\u202E\u202C\u200B\u206B\u200B\u202E\u206A\u202E\u206D\u206D\u202E\u206B\u206C\u206E\u206C\u206A\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), this.Debuff);
								num4 = -1340169461;
								continue;
								IL_06D8:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Upgrade)) ? 1009307327 : 1521472775);
								continue;
								IL_0735:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Exile)) ? 19022913 : 1825485413);
								continue;
								IL_076B:
								num4 = (FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Scry) ? 140298598 : (-1650140203));
								continue;
								IL_0982:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Dream)) ? (-576319196) : (-210399300));
								continue;
								IL_0AE1:
								manaValue = this.ManaValue;
								num4 = -9356699;
								continue;
								IL_0BAC:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.TempMorph)) ? 436903839 : (-463420364));
								continue;
								IL_0CFE:
								num4 = ((!FlandreInstabilityDef.FlandreInstability.\u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(FlandreInstabilityDef.FlandreInstability.\u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(FlandreInstabilityDef.FlandreInstability.\u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(this)), Keyword.Block)) ? 589048568 : 88212372);
							}
						}
						Block_4:;
					}
				}
				return TypeFactory<Card>.LocalizeProperty(FlandreInstabilityDef.FlandreInstability.\u200B\u206E\u200B\u206E\u202E\u200B\u206D\u200E\u202A\u200F\u206B\u200F\u202D\u200C\u206C\u200F\u202B\u206B\u200B\u206B\u206A\u202E\u206C\u206F\u206D\u202D\u202E\u202D\u200D\u206A\u200B\u200E\u200C\u202B\u206D\u202E\u202C\u206B\u200D\u200F\u202E(this), key, decorated, required);
			}

			public override int AdditionalValue1
			{
				get
				{
					return this.Value1Mod;
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return this.Value2Mod;
				}
			}

			private int Value1Mod { get; set; }

			private int Value2Mod { get; set; }

			private int Value3 { get; set; }

			private int Value4 { get; set; }

			private int Value5 { get; set; }

			private int Value6 { get; set; }

			public BlockInfo BlockValue
			{
				get
				{
					return new BlockInfo(base.FlandreModifier(this._blockValue.Block, false), BlockShieldType.Direct);
				}
				set
				{
					this._blockValue = value;
				}
			}

			public ShieldInfo ShieldValue
			{
				get
				{
					return new ShieldInfo(base.FlandreModifier(this._shieldValue.Shield, false), BlockShieldType.Direct);
				}
				set
				{
					this._shieldValue = value;
				}
			}

			public ManaGroup ManaValue
			{
				get
				{
					ManaGroup manaValue = this._manaValue;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_00D8:
							int num = ((!FlandreInstabilityDef.FlandreInstability.\u200D\u206A\u206C\u206F\u200B\u200C\u206D\u206E\u206C\u200B\u206F\u206A\u200C\u200B\u202D\u206B\u206C\u202B\u202A\u202B\u202C\u206F\u200D\u206C\u200B\u200B\u202B\u206B\u206B\u202D\u202A\u206B\u206D\u206B\u206F\u200B\u202C\u206D\u206C\u206E\u202E(enumerator)) ? 1218677421 : (-1313811368));
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)((num2 - (~(1013287925 * -1990340071) - 1959226141 * (768430588 - 2009802352)) + (-1574987839 ^ 1799609871)) ^ (-1293391785 * -1230513057))) % 6U)
								{
								case 0U:
								{
									ManaColor manaColor;
									num = (int)(((manaValue.GetValue(manaColor) <= 0) ? 2528893018U : 1628342754U) ^ (num3 * 20460434U));
									continue;
								}
								case 1U:
								{
									ManaColor manaColor;
									manaValue.SetValue(manaColor, base.FlandreModifier(manaValue.GetValue(manaColor), false));
									num = (int)((num3 * 3878584624U) ^ 221892078U);
									continue;
								}
								case 2U:
									num = -1313811368;
									continue;
								case 3U:
									goto IL_00D8;
								case 5U:
								{
									ManaColor manaColor = enumerator.Current;
									num = 1568341267;
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
								IL_00F9:
								int num4 = 1930560097;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)((num2 - (~(1013287925 * -1990340071) - 1959226141 * (768430588 - 2009802352)) + (-1574987839 ^ 1799609871)) ^ (-1293391785 * -1230513057))) % 3U)
									{
									case 0U:
										goto IL_00F9;
									case 2U:
										FlandreInstabilityDef.FlandreInstability.\u202A\u200F\u206F\u206C\u202D\u200E\u200D\u200D\u202E\u206F\u206E\u206D\u206E\u200D\u200B\u206E\u200B\u206E\u202D\u200F\u206A\u206B\u206D\u206C\u202A\u206B\u206A\u200B\u200C\u206D\u202B\u200B\u206D\u200E\u200E\u202A\u206E\u206B\u200E\u202A\u202E(enumerator);
										num4 = (int)((num3 * 251220135U) ^ 337168867U);
										continue;
									}
									goto Block_7;
								}
							}
							Block_7:;
						}
					}
					return manaValue;
				}
				set
				{
					this._manaValue = value;
				}
			}

			public ScryInfo ScryValue
			{
				get
				{
					return new ScryInfo(base.FlandreModifier(this._scryValue.Count, false));
				}
				set
				{
					this._scryValue = value;
				}
			}

			public override float AmountF
			{
				get
				{
					return 2f + (float)FlandreInstabilityDef.FlandreInstability.\u200F\u206B\u200E\u202E\u202B\u200C\u200F\u206F\u206E\u202B\u202D\u206F\u206B\u200E\u206E\u200D\u202D\u202D\u200D\u202B\u202C\u206E\u202A\u200C\u206D\u206C\u200D\u202D\u206C\u206D\u200B\u200C\u206E\u200E\u206D\u206E\u200C\u200B\u202A\u202D\u202E(this).GetValueOrDefault() / 2f;
				}
			}

			public int DreamValue
			{
				get
				{
					return base.FlandreModifier(this._dreamValue, false);
				}
				set
				{
					this._dreamValue = value;
				}
			}

			public int HealValue
			{
				get
				{
					return base.FlandreModifier(this._healValue, false);
				}
				set
				{
					this._healValue = value;
				}
			}

			public int GoldValue
			{
				get
				{
					return base.FlandreModifier(this._goldValue, false);
				}
				set
				{
					this._goldValue = value;
				}
			}

			public int PowerValue
			{
				get
				{
					return base.FlandreModifier(this._powerValue, false);
				}
				set
				{
					this._powerValue = value;
				}
			}

			public int DamageValue
			{
				get
				{
					return base.FlandreModifier(this._damageValue, false);
				}
				set
				{
					this._damageValue = value;
				}
			}

			public int AddValue1
			{
				get
				{
					return base.FlandreModifier(this._addValue1, false);
				}
				set
				{
					this._addValue1 = value;
				}
			}

			public string Add { get; set; }

			public Type AddCard { get; set; }

			public ManaGroup AddManaValue { get; set; }

			public int AddValue2
			{
				get
				{
					return base.FlandreModifier(this._addValue2, false);
				}
				set
				{
					this._addValue2 = value;
				}
			}

			public int DrawValue
			{
				get
				{
					return base.FlandreModifier(this._drawValue, false);
				}
				set
				{
					this._drawValue = value;
				}
			}

			public int DiscardValue
			{
				get
				{
					return base.FlandreModifier(this._discardValue, false);
				}
				set
				{
					this._discardValue = value;
				}
			}

			public int ExileValue
			{
				get
				{
					return base.FlandreModifier(this._exileValue, false);
				}
				set
				{
					this._exileValue = value;
				}
			}

			public int MoveValue
			{
				get
				{
					return base.FlandreModifier(this._moveValue, false);
				}
				set
				{
					this._moveValue = value;
				}
			}

			public int RetainValue
			{
				get
				{
					return base.FlandreModifier(this._retainValue, false);
				}
				set
				{
					this._retainValue = value;
				}
			}

			public int BuffValue1
			{
				get
				{
					return base.FlandreModifier(this._buffValue1, false);
				}
				set
				{
					this._buffValue1 = value;
				}
			}

			public string Buff1 { get; set; }

			public Type Buff1StatusEffect { get; set; }

			public int BuffValue2
			{
				get
				{
					return base.FlandreModifier(this._buffValue2, false);
				}
				set
				{
					this._buffValue2 = value;
				}
			}

			public string Buff2 { get; set; }

			public Type Buff2StatusEffect { get; set; }

			public int DebuffValue
			{
				get
				{
					return base.FlandreModifier(this._debuffValue, false);
				}
				set
				{
					this._debuffValue = value;
				}
			}

			public string Debuff { get; set; }

			public Type DebuffStatusEffect { get; set; }

			private int EffectCount { get; set; }

			private int DamageEffectType { get; set; }

			private int AddEffectType { get; set; }

			private int DrawEffectType { get; set; }

			private int DiscardEffectType { get; set; }

			private int ExileEffectType { get; set; }

			private int MoveEffectType { get; set; }

			private int RetainEffectType { get; set; }

			private int BuffEffectType { get; set; }

			private int DebuffEffectType { get; set; }

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<GameEventArgs>(FlandreInstabilityDef.FlandreInstability.\u206E\u202C\u206E\u202C\u206B\u206D\u202D\u200C\u200B\u206E\u206D\u206C\u206D\u202C\u200D\u206E\u202E\u202C\u206A\u206A\u200D\u202C\u206F\u200B\u206D\u202B\u206E\u200E\u206F\u200C\u206B\u202C\u206A\u206A\u206C\u202A\u200C\u206F\u202A\u206B\u202E(FlandreInstabilityDef.FlandreInstability.\u200C\u200B\u200F\u200F\u200E\u200B\u202C\u206E\u200B\u202C\u206D\u200F\u200D\u206A\u206C\u202D\u202C\u200E\u206C\u200D\u200B\u200C\u202E\u206D\u206A\u206B\u200E\u202E\u206B\u206A\u206B\u200C\u200B\u206F\u200F\u206E\u200B\u200B\u200E\u202D\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnRoundStarted));
			}

			private IEnumerable<BattleAction> OnRoundStarted(GameEventArgs args)
			{
				FlandreInstabilityDef.FlandreInstability.<OnRoundStarted>d__262 <OnRoundStarted>d__ = new FlandreInstabilityDef.FlandreInstability.<OnRoundStarted>d__262(-2);
				<OnRoundStarted>d__.<>4__this = this;
				return <OnRoundStarted>d__;
			}

			public override void Initialize()
			{
				base.Initialize();
				for (;;)
				{
					IL_0006:
					int num = 575441293;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(uint)((num2 - 2048767893 * 1190974639 - 602103595 * (1872737081 * 1239614514)) ^ (-1667547020 * -187128229)))) % 3U)
						{
						case 1U:
							base.IsRandom = true;
							num = (int)((num3 * 2849739566U) ^ 624811376U);
							continue;
						case 2U:
							goto IL_0006;
						}
						return;
					}
				}
			}

			public override Interaction Precondition()
			{
				return base.Precondition();
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreInstabilityDef.FlandreInstability.<Actions>d__265 <Actions>d__ = new FlandreInstabilityDef.FlandreInstability.<Actions>d__265(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static CardConfig \u206F\u202C\u206B\u202A\u206F\u202A\u206D\u206A\u200F\u202A\u206E\u206B\u202D\u202D\u200D\u200F\u202E\u206F\u200D\u200C\u200D\u206B\u206C\u206E\u202C\u206B\u206D\u206B\u202B\u206C\u206A\u206E\u202E\u206F\u206F\u202E\u202B\u202A\u206A\u202B\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u206C\u206C\u206D\u200E\u202A\u202B\u200E\u200D\u202B\u206A\u200B\u206B\u200D\u200D\u200F\u206B\u200C\u202B\u206C\u200B\u202B\u202C\u206A\u200C\u206A\u202E\u202E\u206D\u206A\u202B\u200F\u206C\u202B\u202A\u200F\u206E\u200E\u202C\u206C\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u202E\u200E\u206D\u206E\u206E\u202D\u206C\u206A\u202D\u206F\u206B\u202E\u202B\u200E\u206D\u206E\u206D\u200C\u202B\u200F\u202E\u206E\u206F\u200C\u200C\u202E\u206A\u206A\u202B\u206B\u202B\u206F\u206E\u200F\u202A\u200F\u206F\u200E\u206E\u206B\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u202C\u200F\u200B\u200B\u200E\u202E\u202E\u200B\u206E\u200E\u200D\u202A\u200C\u200F\u202A\u200E\u200C\u206F\u206B\u206F\u206C\u200F\u202D\u202A\u202D\u202D\u200B\u200B\u206D\u200D\u202E\u202E\u206B\u200C\u202A\u202B\u202E\u202C\u206A\u200E\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static bool \u202A\u206B\u206A\u200B\u202C\u206E\u206E\u202A\u202C\u206E\u202E\u200E\u206D\u206E\u200C\u200C\u200F\u206C\u206D\u206D\u200E\u202E\u206A\u200F\u202E\u202A\u200D\u200B\u200D\u206F\u202A\u206F\u206F\u202D\u206A\u206A\u206D\u206F\u206F\u206B\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u206F\u202A\u206E\u202E\u202E\u200D\u200D\u206A\u200B\u202B\u206E\u202C\u206A\u200F\u200D\u202A\u200B\u202B\u206D\u206C\u206F\u200B\u202D\u206B\u200F\u206C\u202D\u200B\u200E\u200B\u200E\u206A\u206E\u202D\u206F\u200E\u206A\u202C\u200C\u202E\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u200D\u202C\u206D\u202B\u206C\u206E\u206F\u202B\u200D\u202D\u206D\u202B\u206D\u206E\u202E\u200B\u202A\u200F\u206B\u200C\u200B\u202B\u200F\u202A\u206D\u200C\u200C\u200D\u206F\u206F\u206B\u202A\u206C\u202A\u202D\u202C\u202E\u200F\u206C\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200D\u206A\u206D\u200B\u202A\u200F\u206A\u206C\u200C\u206B\u200C\u206B\u200F\u206B\u202B\u206E\u200E\u202E\u200B\u206F\u200B\u202C\u200D\u200F\u202D\u202B\u206A\u206F\u200E\u200F\u200E\u200C\u202C\u206B\u200B\u206D\u202A\u206C\u206A\u202B\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static BattleController \u200C\u200B\u200F\u200F\u200E\u200B\u202C\u206E\u200B\u202C\u206D\u200F\u200D\u206A\u206C\u202D\u202C\u200E\u206C\u200D\u200B\u200C\u202E\u206D\u206A\u206B\u200E\u202E\u206B\u206A\u206B\u200C\u200B\u206F\u200F\u206E\u200B\u200B\u200E\u202D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u206C\u200C\u202B\u200F\u202A\u200D\u202A\u202E\u202B\u202D\u200E\u206D\u202A\u206F\u200E\u200B\u202A\u206C\u202E\u202D\u200D\u200F\u202E\u202B\u200B\u200C\u200E\u202A\u202B\u202D\u206A\u202D\u202E\u202E\u202E\u202A\u202B\u200E\u206A\u206D\u202E(string A_0)
			{
				return A_0.IsNullOrEmpty();
			}

			static bool \u200E\u206F\u206D\u202E\u202E\u200F\u202D\u206F\u200F\u206C\u202E\u200D\u202D\u206A\u200D\u202B\u206B\u202E\u202E\u200D\u200D\u200B\u206B\u206D\u200C\u200F\u200F\u200B\u202A\u206C\u200F\u206A\u206C\u200C\u202A\u206E\u200D\u200D\u202A\u206D\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static Keyword \u206D\u200D\u206A\u202A\u200F\u202D\u206A\u206B\u202A\u202A\u200C\u206D\u200B\u202A\u200F\u206A\u200D\u206B\u206F\u206A\u206F\u206C\u202E\u206F\u206E\u202E\u206D\u202C\u206C\u202B\u200E\u200D\u206E\u202A\u206D\u200E\u206C\u200E\u206D\u202E\u202E(CardConfig A_0)
			{
				return A_0.RelativeKeyword;
			}

			static bool \u206C\u206D\u206D\u202C\u200D\u202A\u206F\u200C\u206A\u206E\u200D\u206B\u206D\u206B\u200F\u200F\u200D\u206A\u206D\u206D\u206F\u206B\u200C\u206E\u200C\u200E\u206E\u200E\u202A\u202C\u206B\u202A\u200E\u206E\u200D\u206C\u200E\u202C\u202E\u200F\u202E(Enum A_0, Enum A_1)
			{
				return A_0.HasFlag(A_1);
			}

			static Keyword \u202A\u206D\u202A\u206E\u200D\u200B\u206B\u202C\u200F\u206B\u206C\u202B\u206D\u206E\u206D\u200F\u202B\u200B\u202D\u202A\u202A\u202D\u202E\u202B\u206C\u200B\u200B\u202A\u200C\u202E\u200D\u206B\u202B\u206D\u202B\u206A\u202A\u202E\u206F\u200E\u202E(CardConfig A_0)
			{
				return A_0.UpgradedRelativeKeyword;
			}

			static IReadOnlyList<string> \u206F\u200E\u202E\u202B\u206F\u200F\u206C\u206A\u202A\u200B\u200F\u206A\u200F\u202C\u200B\u200E\u206A\u202B\u206B\u200E\u206A\u202C\u200E\u200E\u206D\u202C\u200F\u200C\u206A\u200E\u206C\u202C\u202A\u202B\u206F\u202E\u206A\u206F\u202E\u200E\u202E(CardConfig A_0)
			{
				return A_0.RelativeCards;
			}

			static IReadOnlyList<string> \u202C\u200F\u200B\u200B\u200E\u200B\u206F\u206D\u206C\u206D\u202C\u202B\u202C\u206E\u200B\u202A\u206F\u206D\u202D\u200F\u206D\u202A\u200C\u202A\u206D\u206D\u200E\u202A\u206B\u200C\u206B\u206A\u202C\u206C\u206D\u200B\u200F\u200E\u202B\u202A\u202E(CardConfig A_0)
			{
				return A_0.UpgradedRelativeCards;
			}

			static IReadOnlyList<string> \u200C\u200B\u202B\u206E\u202C\u206D\u206D\u200D\u202B\u200B\u206D\u206B\u206C\u206A\u206A\u200B\u206B\u202E\u202D\u200E\u206D\u200E\u206D\u206A\u202E\u202C\u200B\u206B\u200B\u202E\u206A\u202E\u206D\u206D\u202E\u206B\u206C\u206E\u206C\u206A\u202E(CardConfig A_0)
			{
				return A_0.RelativeEffects;
			}

			static IReadOnlyList<string> \u202E\u200B\u200C\u202B\u200E\u206A\u200B\u200E\u202C\u206D\u200E\u202A\u206D\u200E\u206D\u200D\u200D\u200E\u206C\u206D\u206C\u206E\u206F\u202D\u200E\u202D\u200D\u206D\u202D\u202D\u200B\u200D\u206A\u200B\u200C\u200E\u200F\u206E\u200B\u206A\u202E(CardConfig A_0)
			{
				return A_0.UpgradedRelativeEffects;
			}

			static string \u200B\u206E\u200B\u206E\u202E\u200B\u206D\u200E\u202A\u200F\u206B\u200F\u202D\u200C\u206C\u200F\u202B\u206B\u200B\u206B\u206A\u202E\u206C\u206F\u206D\u202D\u202E\u202D\u200D\u206A\u200B\u200E\u200C\u202B\u206D\u202E\u202C\u206B\u200D\u200F\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static bool \u200D\u206A\u206C\u206F\u200B\u200C\u206D\u206E\u206C\u200B\u206F\u206A\u200C\u200B\u202D\u206B\u206C\u202B\u202A\u202B\u202C\u206F\u200D\u206C\u200B\u200B\u202B\u206B\u206B\u202D\u202A\u206B\u206D\u206B\u206F\u200B\u202C\u206D\u206C\u206E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202A\u200F\u206F\u206C\u202D\u200E\u200D\u200D\u202E\u206F\u206E\u206D\u206E\u200D\u200B\u206E\u200B\u206E\u202D\u200F\u206A\u206B\u206D\u206C\u202A\u206B\u206A\u200B\u200C\u206D\u202B\u200B\u206D\u200E\u200E\u202A\u206E\u206B\u200E\u202A\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static int? \u200F\u206B\u200E\u202E\u202B\u200C\u200F\u206F\u206E\u202B\u202D\u206F\u206B\u200E\u206E\u200D\u202D\u202D\u200D\u202B\u202C\u206E\u202A\u200C\u206D\u206C\u200D\u202D\u206C\u206D\u200B\u200C\u206E\u200E\u206D\u206E\u200C\u200B\u202A\u202D\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static GameEvent<GameEventArgs> \u206E\u202C\u206E\u202C\u206B\u206D\u202D\u200C\u200B\u206E\u206D\u206C\u206D\u202C\u200D\u206E\u202E\u202C\u206A\u206A\u200D\u202C\u206F\u200B\u206D\u202B\u206E\u200E\u206F\u200C\u206B\u202C\u206A\u206A\u206C\u202A\u200C\u206F\u202A\u206B\u202E(BattleController A_0)
			{
				return A_0.RoundStarted;
			}

			static Type \u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			private BlockInfo _blockValue;

			private ShieldInfo _shieldValue;

			private ManaGroup _manaValue;

			private ScryInfo _scryValue;

			private int _dreamValue;

			private int _healValue;

			private int _goldValue;

			private int _powerValue;

			private int _damageValue;

			private int _addValue1;

			private int _addValue2;

			private int _drawValue;

			private int _discardValue;

			private int _exileValue;

			private int _moveValue;

			private int _retainValue;

			private int _buffValue1;

			private int _buffValue2;

			private int _debuffValue;

			private readonly List<FlandreInstabilityDef.FlandreInstability.EffectType> SelectedEffects = new List<FlandreInstabilityDef.FlandreInstability.EffectType>();

			private readonly RepeatableRandomPool<int> BuffEffectPool = new RepeatableRandomPool<int>
			{
				{ 1, 1f },
				{ 2, 0.85f },
				{ 3, 0.7f },
				{ 4, 0.55f }
			};

			private readonly RepeatableRandomPool<Type> BuffEffectPool1 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(FreeFlySe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MomentPowerSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TaijiLiangyiSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(BoliPhantomSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(DanceAroundLakeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(LearnAstrologySe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(PotionJungleSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MasterOfCollectionSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(GainKnifeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SilverBladeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SpecialClockSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(FrozenThroneSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MoreFriendsSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(WhiteWorldSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(KoishiUltimateSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(GainInspirationSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(KoishiDnaSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ButterflyDreamSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(KoishiPhoneSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MoreDraw).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(YonglinCardSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(YouxiangMoonSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(CommonFireSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MoonWorldSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(RainbowMarketSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(RinDrawSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(YonglinUpgradeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(BlackPoisonSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TodayYesterdaySe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(WindGirl).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(JinziDoppelgangerSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ZhenmiaowanAbilitySe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SuperExtraTurn).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(BailianFireSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(EvilTuiZhiSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(EvilMaidDoubleAttack).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(BailianMagicSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Invincible).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ExtraTurn).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Weak).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Fragil).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Vulnerable).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SpiritNegative).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(FirepowerNegative).TypeHandle),
					2f
				}
			};

			private readonly RepeatableRandomPool<Type> BuffEffectPool2 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ReimuFestivalSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ReverseJiejieSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ReimuShrineSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(HuanxiangBlockSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ReimuGraceSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ReimuEvilTerminatorSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SolarSystemSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MihuanJackSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SakuyaKillerSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(DeepFreezeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ShannvAbilitySe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(DreamExpressSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MeihongPowerSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(HuiyeManaSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TianziRockSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(SeeFengshuiSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(HekaHellRainSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(YachieDefendSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Spirit).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Firepower).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Graze).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(AmuletForCard).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Amulet).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempSpiritNegative).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempFirepowerNegative).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Poison).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(LockedOn).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(NextTurnGainGraze).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TurnStartPurify).TypeHandle),
					2f
				}
			};

			private readonly RepeatableRandomPool<Type> BuffEffectPool3 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(DoubleLianhuadieSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ScryBlockSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(StopTimeSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(MeihongFireSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(ModuoluoFireSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempFirepower).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempSpirit).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Grace).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Charging).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(NextTurnLoseHp).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempElectric).TypeHandle),
					2f
				}
			};

			private readonly RepeatableRandomPool<Type> BuffEffectPool4 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(RangziFanshuSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(KokoroDanceSe).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TimeAuraSe).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(YukariFlyObjectSe).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(NextTurnGainBlock).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(NextTurnGainShield).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(NextAttackUp).TypeHandle),
					2f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Reflect).TypeHandle),
					2f
				}
			};

			private readonly RepeatableRandomPool<int> DebuffEffectPool = new RepeatableRandomPool<int>
			{
				{ 1, 0.25f },
				{ 2, 1f },
				{ 3, 0.75f },
				{ 4, 0.5f }
			};

			private readonly RepeatableRandomPool<Type> DebuffEffectPool1 = new RepeatableRandomPool<Type> { 
			{
				FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(FirepowerNegative).TypeHandle),
				1f
			} };

			private readonly RepeatableRandomPool<Type> DebuffEffectPool2 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Weak).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Vulnerable).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(LockedOn).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TiangouOrderSe).TypeHandle),
					1f
				}
			};

			private readonly RepeatableRandomPool<Type> DebuffEffectPool3 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(LockedOn).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Cold).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(TempFirepowerNegative).TypeHandle),
					1f
				}
			};

			private readonly RepeatableRandomPool<Type> DebuffEffectPool4 = new RepeatableRandomPool<Type>
			{
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Poison).TypeHandle),
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.\u200E\u200B\u206E\u206C\u206B\u200C\u206C\u206A\u200D\u206D\u206F\u202A\u202B\u200C\u206F\u206D\u200E\u202B\u206C\u200B\u202D\u206B\u206E\u202A\u206E\u202C\u202E\u200B\u202D\u206A\u206C\u206D\u202C\u202C\u206D\u206D\u206D\u206D\u202A\u202B\u202E(typeof(Drowning).TypeHandle),
					1f
				}
			};

			private readonly RepeatableRandomPool<int> EffectCounts0 = new RepeatableRandomPool<int>
			{
				{ 1, 1f },
				{ 2, 0.75f },
				{ 3, 0.5f },
				{ 4, 0.25f },
				{ 5, 0f }
			};

			private readonly RepeatableRandomPool<int> EffectCounts1 = new RepeatableRandomPool<int>
			{
				{ 1, 0.75f },
				{ 2, 1f },
				{ 3, 0.75f },
				{ 4, 0.5f },
				{ 5, 0.25f }
			};

			private readonly RepeatableRandomPool<int> EffectCounts2 = new RepeatableRandomPool<int>
			{
				{ 1, 0.5f },
				{ 2, 0.75f },
				{ 3, 1f },
				{ 4, 0.75f },
				{ 5, 0.5f }
			};

			private readonly RepeatableRandomPool<int> EffectCounts3 = new RepeatableRandomPool<int>
			{
				{ 1, 0.25f },
				{ 2, 0.5f },
				{ 3, 0.75f },
				{ 4, 1f },
				{ 5, 0.75f }
			};

			private readonly RepeatableRandomPool<int> EffectCounts4 = new RepeatableRandomPool<int>
			{
				{ 1, 0f },
				{ 2, 0.25f },
				{ 3, 0.5f },
				{ 4, 0.75f },
				{ 5, 1f }
			};

			private readonly RepeatableRandomPool<FlandreInstabilityDef.FlandreInstability.EffectType> EffectPool = new RepeatableRandomPool<FlandreInstabilityDef.FlandreInstability.EffectType>
			{
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Block,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Barrier,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Mana,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Scry,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Dream,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Cleanse,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Heal,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Gold,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Power,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Upgrade,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Damage,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Add,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Draw,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Discard,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Exile,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Move,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Retain,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Buff,
					1f
				},
				{
					FlandreInstabilityDef.FlandreInstability.EffectType.Debuff,
					1f
				}
			};

			private enum EffectType
			{
				Block,
				Barrier,
				Mana,
				Scry,
				Dream,
				Cleanse,
				Heal,
				Gold,
				Power,
				Upgrade,
				Damage,
				Add,
				Draw,
				Discard,
				Exile,
				Move,
				Retain,
				Buff,
				Debuff
			}
		}
	}
}
