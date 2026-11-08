using System;
using System.Collections;
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
	public sealed class FlandreFriendOkinaSpringDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1163222130);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreFriendOkinaSpringDef.\u206C\u206A\u206E\u202E\u202A\u206A\u206D\u206A\u206D\u206C\u202A\u200D\u202E\u206C\u200D\u200B\u202A\u200B\u200B\u200D\u206E\u206D\u206A\u202E\u200F\u200D\u200C\u200F\u200B\u202B\u200E\u200B\u206D\u206B\u200E\u202A\u200E\u206F\u202E\u200E\u202E(BepinexPlugin.embeddedSource);
			FlandreFriendOkinaSpringDef.\u206D\u200F\u206A\u200C\u200E\u206D\u206C\u206D\u200F\u200F\u202E\u200E\u202D\u200C\u200B\u202B\u202D\u206E\u202D\u200E\u200C\u202E\u200D\u202B\u200D\u202D\u200C\u202A\u206D\u202C\u202E\u200D\u206B\u206D\u202C\u200E\u202B\u200C\u206B\u206D\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreFriendOkinaSpringDef.\u200D\u202B\u202B\u206B\u206C\u200E\u202D\u202A\u202D\u206A\u202C\u206A\u200C\u206E\u202E\u206D\u202A\u202E\u202E\u206C\u206A\u200B\u206A\u202A\u206C\u206B\u202C\u206A\u200B\u200B\u202D\u200E\u206F\u202A\u200D\u200F\u206C\u206A\u200B\u202E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreFriendOkinaSpringDef.\u206F\u206F\u202B\u202D\u202B\u206B\u200E\u200E\u202B\u200F\u200B\u200D\u206B\u206B\u200F\u200B\u206F\u202B\u202D\u206E\u200B\u200D\u202E\u200E\u202C\u202C\u200D\u206B\u206A\u202B\u202D\u206A\u206F\u202B\u206C\u206D\u206E\u206D\u206B\u202A\u202E(BepinexPlugin.sequenceTable, FlandreFriendOkinaSpringDef.\u206E\u202A\u202D\u206E\u202C\u202E\u200D\u202D\u200B\u202B\u202B\u202D\u206D\u202A\u206F\u202E\u202E\u206A\u202B\u200B\u206B\u202B\u200F\u206A\u202D\u202A\u206F\u202D\u202A\u200D\u202D\u200C\u202C\u202B\u200F\u202C\u202E\u200F\u200D\u202C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, true, false, true, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Blue = 1,
				Black = 1,
				Red = 1,
				Green = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(4), null, null, null, null, null, null, new int?(1), null, new int?(2), null, new int?(-1), null, null, null, new int?(-6), null, Keyword.Replenish, Keyword.Replenish, false, Keyword.Philosophy, Keyword.Philosophy, new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(399385845),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1819099461)
			}, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1252245795),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-604543708)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(418962896),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1969546793),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(836279944),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1293329945),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1042466688),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(183621604),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1595517087),
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1763499156)
			}, new List<string>
			{
				<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-876179279),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1969546793),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1938530611),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368637644),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1042466688),
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(501936272),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1595517087),
				<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1594215515)
			}, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-58151961), null, "", "", false, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(136909071), new List<string>());
		}

		static CardImages \u206C\u206A\u206E\u202E\u202A\u206A\u206D\u206A\u206D\u206C\u202A\u200D\u202E\u206C\u200D\u200B\u202A\u200B\u200B\u200D\u206E\u206D\u206A\u202E\u200F\u200D\u200C\u200F\u200B\u202B\u200E\u200B\u206D\u206B\u200E\u202A\u200E\u206F\u202E\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206D\u200F\u206A\u200C\u200E\u206D\u206C\u206D\u200F\u200F\u202E\u200E\u202D\u200C\u200B\u202B\u202D\u206E\u202D\u200E\u200C\u202E\u200D\u202B\u200D\u202D\u200C\u202A\u206D\u202C\u202E\u200D\u206B\u206D\u202C\u200E\u202B\u200C\u206B\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u202B\u202B\u206B\u206C\u200E\u202D\u202A\u202D\u206A\u202C\u206A\u200C\u206E\u202E\u206D\u202A\u202E\u202E\u206C\u206A\u200B\u206A\u202A\u206C\u206B\u202C\u206A\u200B\u200B\u202D\u200E\u206F\u202A\u200D\u200F\u206C\u206A\u200B\u202E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206E\u202A\u202D\u206E\u202C\u202E\u200D\u202D\u200B\u202B\u202B\u202D\u206D\u202A\u206F\u202E\u202E\u206A\u202B\u200B\u206B\u202B\u200F\u206A\u202D\u202A\u206F\u202D\u202A\u200D\u202D\u200C\u202C\u202B\u200F\u202C\u202E\u200F\u200D\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206F\u206F\u202B\u202D\u202B\u206B\u200E\u200E\u202B\u200F\u200B\u200D\u206B\u206B\u200F\u200B\u206F\u202B\u202D\u206E\u200B\u200D\u202E\u200E\u202C\u202C\u200D\u206B\u206A\u202B\u202D\u206A\u206F\u202B\u206C\u206D\u206E\u206D\u206B\u202A\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreFriendOkinaSpringDef))]
		public sealed class FlandreFriendOkinaSpring : FlandreCard
		{
			public override bool RemoveFromBattleAfterPlay
			{
				get
				{
					return this.ActiveUsed;
				}
			}

			public float Value3
			{
				get
				{
					return (float)FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206B\u202A\u202B\u200D\u206B\u206E\u200B\u202C\u206D\u202A\u202D\u206C\u202C\u206D\u206F\u202A\u200F\u206A\u202B\u200B\u200C\u200B\u200F\u202A\u202B\u206B\u202D\u200E\u200F\u202D\u206B\u206D\u206C\u200F\u202A\u206E\u202D\u206A\u202A\u206E\u202E(this).GetValueOrDefault();
				}
			}

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
					return base.FlandreModifier(3 + FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206B\u202A\u202B\u200D\u206B\u206E\u200B\u202C\u206D\u202A\u202D\u206C\u202C\u206D\u206F\u202A\u200F\u206A\u202B\u200B\u200C\u200B\u200F\u202A\u202B\u206B\u202D\u200E\u200F\u202D\u206B\u206D\u206C\u200F\u202A\u206E\u202D\u206A\u202A\u206E\u202E(this).GetValueOrDefault(), false);
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					ManaGroup manaGroup = default(ManaGroup);
					for (;;)
					{
						IL_0008:
						int num = -511819015;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(uint)(-(uint)(num2 * -1121399975 * -1326273919)))) % 3U)
							{
							case 1U:
								manaGroup.Philosophy = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206F\u200E\u206C\u206F\u202C\u206A\u200C\u200B\u200F\u206E\u202E\u200D\u200D\u200B\u200D\u202B\u202E\u206D\u200C\u206F\u206B\u206E\u200C\u206B\u202D\u206E\u200B\u206C\u202D\u206B\u202A\u202A\u200E\u206B\u202D\u206D\u200D\u206D\u206B\u202E((float)FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206B\u202A\u202B\u200D\u206B\u206E\u200B\u202C\u206D\u202A\u202D\u206C\u202C\u206D\u206F\u202A\u200F\u206A\u202B\u200B\u200C\u200B\u200F\u202A\u202B\u206B\u202D\u200E\u200F\u202D\u206B\u206D\u206C\u200F\u202A\u206E\u202D\u206A\u202A\u206E\u202E(this).GetValueOrDefault() / 2f);
								num = (int)((num3 * 3402469652U) ^ 271927180U);
								continue;
							case 2U:
								goto IL_0008;
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
					ManaGroup manaGroup = ManaGroup.Philosophies(1) + this.AdditionalMana;
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_008A:
							int num = ((!FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206E\u202A\u202C\u202E\u206E\u206C\u202B\u200C\u202E\u206A\u202E\u200E\u202C\u206A\u206E\u202B\u206F\u206B\u200D\u206B\u206F\u200F\u200D\u202D\u200F\u206A\u206F\u200E\u206F\u206A\u206F\u200D\u200C\u202E\u202B\u202E\u206C\u202A\u202E(enumerator)) ? 515950202 : 615287734);
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~num2 ^ (1739084739 ^ 1098923181 ^ -347351724) ^ ~1923853227 ^ -148388273)) % 5U)
								{
								case 0U:
								{
									ManaColor manaColor;
									manaGroup.SetValue(manaColor, base.FlandreModifier(manaGroup.GetValue(manaColor), false));
									num = (int)((num3 * 1817894358U) ^ 136738165U);
									continue;
								}
								case 1U:
								{
									ManaColor manaColor = enumerator.Current;
									num = ((manaGroup.GetValue(manaColor) > 0) ? 1414270885 : 1781616807);
									continue;
								}
								case 2U:
									goto IL_008A;
								case 3U:
									num = 615287734;
									continue;
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
								IL_00D1:
								int num4 = 1858789556;
								for (;;)
								{
									int num2 = num4;
									uint num3;
									switch ((num3 = (uint)(~num2 ^ (1739084739 ^ 1098923181 ^ -347351724) ^ ~1923853227 ^ -148388273)) % 3U)
									{
									case 0U:
										goto IL_00D1;
									case 2U:
										FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u202A\u202C\u206C\u202A\u202D\u200B\u202C\u206C\u200F\u200B\u200E\u206F\u206F\u200F\u206C\u206B\u202C\u202D\u206B\u202A\u206E\u200D\u202B\u200F\u200F\u200B\u200B\u202E\u200E\u200C\u200C\u202B\u206B\u200C\u200F\u206B\u206B\u202E\u202A\u202E(enumerator);
										num4 = (int)((num3 * 931331176U) ^ 1634195565U);
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

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200E\u200B\u200B\u200F\u206A\u206E\u200B\u200B\u200D\u202D\u206C\u200B\u206B\u202E\u200E\u200C\u200F\u202D\u202E\u200D\u200E\u202D\u200F\u202C\u206F\u206B\u206A\u202D\u200E\u202B\u202B\u202B\u206B\u206C\u202C\u202E\u202B\u206F\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_0476;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text2;
					switch ((num3 = (uint)(~(~num) - ~-1973478017 - -1817856213)) % 39U)
					{
					case 0U:
						text = base.RawExtraDescription2;
						num2 = 1623894993;
						continue;
					case 1U:
						num2 = (base.HasExtraDescription2 ? 1313930044 : 1887033440);
						continue;
					case 2U:
						num2 = (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202B\u202B\u206F\u206A\u202A\u206D\u200E\u200B\u200C\u200B\u202C\u202A\u206B\u200D\u202D\u200D\u202B\u206A\u202B\u200E\u200B\u200E\u206E\u206E\u202B\u200E\u200F\u202B\u202D\u200C\u200F\u202C\u202D\u202A\u206C\u202B\u206F\u200B\u202D\u202D\u202E(this) ? 1796042804 : 1857261766);
						continue;
					case 3U:
						num2 = (int)((num3 * 2763664115U) ^ 1261364208U);
						continue;
					case 4U:
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription3);
						num2 = (int)((num3 * 4102462773U) ^ 2717807142U);
						continue;
					case 5U:
						num2 = (int)((num3 * 3735002458U) ^ 3539503866U);
						continue;
					case 6U:
						num2 = ((FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u206B\u202D\u200C\u200C\u200C\u202D\u206A\u202E\u206B\u200F\u206E\u206F\u200E\u206D\u206D\u202A\u200D\u200E\u202E\u202E\u202B\u200F\u206B\u206F\u206A\u200B\u206E\u202E\u206F\u200B\u202E\u206A\u200F\u202B\u206D\u200F\u206D\u202A\u206D\u202E(this) == null) ? 2138351073 : 638046482);
						continue;
					case 7U:
						num2 = ((!base.HasExtraDescription3) ? 1623894993 : 1961052161);
						continue;
					case 8U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -2135790739;
						continue;
					}
					case 9U:
						goto IL_0197;
					case 10U:
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription1);
						num2 = (int)((num3 * 3354088092U) ^ 3924240509U);
						continue;
					case 11U:
						goto IL_02BF;
					case 12U:
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription2);
						num2 = (int)((num3 * 2923034404U) ^ 1889027844U);
						continue;
					case 13U:
						text = base.RawExtraDescription1;
						num2 = 723817771;
						continue;
					case 14U:
					{
						FriendToken friendToken = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u200E\u206D\u206F\u200C\u200E\u202E\u206A\u202E\u206C\u202C\u206C\u200C\u202B\u202C\u202E\u202E\u206B\u206A\u202D\u206B\u200C\u206A\u200C\u200D\u206F\u202D\u202D\u200B\u200F\u200D\u200D\u206B\u202D\u200F\u202D\u202E\u206B\u200C\u202B\u202E(this);
						num2 = (int)((num3 * 1709286890U) ^ 2940855545U);
						continue;
					}
					case 15U:
						num2 = (int)((num3 * 3977862126U) ^ 344783569U);
						continue;
					case 16U:
						goto IL_0176;
					case 17U:
					{
						FriendToken friendToken;
						switch (friendToken)
						{
						case FriendToken.None:
							goto IL_0176;
						case FriendToken.Active:
							goto IL_0349;
						case FriendToken.Active2:
							goto IL_0197;
						case FriendToken.Ultimate:
							goto IL_0444;
						default:
							num2 = (int)((num3 * 331061030U) ^ 849714532U);
							continue;
						}
						break;
					}
					case 18U:
						num2 = (int)((num3 * 1315755131U) ^ 3914781365U);
						continue;
					case 19U:
						num2 = (base.HasExtraDescription1 ? 1598620112 : 1311983309);
						continue;
					case 21U:
						num2 = (int)((num3 * 3473052360U) ^ 1496924793U);
						continue;
					case 22U:
						if (!FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202B\u202B\u206F\u206A\u202A\u206D\u200E\u200B\u200C\u200B\u202C\u202A\u206B\u200D\u202D\u200D\u202B\u206A\u202B\u200E\u200B\u200E\u206E\u206E\u202B\u200E\u200F\u202B\u202D\u200C\u200F\u202C\u202D\u202A\u206C\u202B\u206F\u200B\u202D\u202D\u202E(this))
						{
							num2 = (int)((num3 * 3009292785U) ^ 405038129U);
							continue;
						}
						text2 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_050F;
					case 23U:
						num2 = (int)((num3 * 2705181756U) ^ 1487470377U);
						continue;
					case 24U:
						goto IL_0349;
					case 25U:
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-916099744));
						num2 = (int)((num3 * 1910063223U) ^ 1341092652U);
						continue;
					case 26U:
						goto IL_0444;
					case 27U:
					{
						int num4;
						num2 = (int)(((num4 == 2) ? 3352456085U : 3411289805U) ^ (num3 * 3908974980U));
						continue;
					}
					case 28U:
						goto IL_0476;
					case 29U:
					{
						int num4;
						num2 = (int)(((num4 != 1) ? 804795041U : 147219744U) ^ (num3 * 1910811563U));
						continue;
					}
					case 30U:
						num2 = (int)((num3 * 1233002019U) ^ 2995994652U);
						continue;
					case 31U:
						goto IL_0010;
					case 32U:
					{
						object obj;
						text = (string)obj;
						num2 = 1623894993;
						continue;
					}
					case 33U:
						goto IL_0258;
					case 34U:
					{
						int num4 = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200B\u202D\u206A\u206C\u200F\u206B\u200E\u206A\u202A\u202C\u206C\u206B\u200B\u206D\u200C\u206A\u202B\u206C\u200D\u200D\u202C\u202C\u202C\u200B\u202B\u206D\u200B\u206E\u206F\u202D\u202B\u206B\u206A\u202D\u202C\u202A\u206B\u206A\u202B\u202E\u202E(this);
						num2 = -2066206513;
						continue;
					}
					case 35U:
					{
						string text3 = text;
						string text4;
						if (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u206B\u202D\u200C\u200C\u200C\u202D\u206A\u202E\u206B\u200F\u206E\u206F\u200E\u206D\u206D\u202A\u200D\u200E\u202E\u202E\u202B\u200F\u206B\u206F\u206A\u200B\u206E\u202E\u206F\u200B\u202E\u206A\u200F\u202B\u206D\u200F\u206D\u202A\u206D\u202E(this) == null)
						{
							if (!FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202B\u202B\u206F\u206A\u202A\u206D\u200E\u200B\u200C\u200B\u202C\u202A\u206B\u200D\u202D\u200D\u202B\u206A\u202B\u200E\u200B\u200E\u206E\u206E\u202B\u200E\u200F\u202B\u202D\u200C\u200F\u202C\u202D\u202A\u206C\u202B\u206F\u200B\u202D\u202D\u202E(this))
							{
								text4 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
							else if ((text4 = base.UpgradedNonbattleBaseDescription) == null)
							{
								text4 = base.NonbattleBaseDescription ?? base.BaseDescription;
							}
						}
						else
						{
							text4 = (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202B\u202B\u206F\u206A\u202A\u206D\u200E\u200B\u200C\u200B\u202C\u202A\u206B\u200D\u202D\u200D\u202B\u206A\u202B\u200E\u200B\u200E\u206E\u206E\u202B\u200E\u200F\u202B\u202D\u200C\u200F\u202C\u202D\u202A\u206C\u202B\u206F\u200B\u202D\u202D\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						}
						text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text3, text4);
						num2 = 443500829;
						continue;
					}
					case 36U:
					{
						object obj = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = -2135790739;
						continue;
					}
					case 37U:
					{
						object obj = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription;
						num2 = ((obj == null) ? 1151122473 : (-2135790739));
						continue;
					}
					case 38U:
						text2 = base.BaseDescription;
						goto IL_050F;
					}
					break;
					IL_0176:
					num2 = ((!FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200E\u200B\u200B\u200F\u206A\u206E\u200B\u200B\u200D\u202D\u206C\u200B\u206B\u202E\u200E\u200C\u200F\u202D\u202E\u200D\u200E\u202D\u200F\u202C\u206F\u206B\u206A\u202D\u200E\u202B\u202B\u202B\u206B\u206C\u202C\u202E\u202B\u206F\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(this))) ? 1758175908 : 443500829);
					continue;
					IL_0197:
					text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription2);
					num2 = 1979245207;
					continue;
					IL_0349:
					text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription1);
					num2 = 494268154;
					continue;
					IL_0444:
					text = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(text, base.RawExtraDescription3);
					num2 = 1623894993;
					continue;
					IL_050F:
					text = text2;
					num2 = 1173157702;
				}
				goto IL_051A;
				IL_0258:
				throw FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u202A\u206C\u206F\u206A\u200C\u200C\u206D\u206E\u202A\u202C\u206E\u200E\u200E\u206E\u206E\u202A\u200C\u202D\u202E\u206F\u202A\u206E\u206B\u200E\u202C\u206B\u200F\u200E\u202C\u200E\u200B\u200B\u200B\u202A\u206B\u200B\u206F\u206D\u200F\u202E();
				IL_02BF:
				return string.Empty;
				IL_051A:
				return base.FollowByDetailIcon(text);
				IL_0010:
				num2 = 2059805199;
				goto IL_0015;
				IL_0476:
				text = string.Empty;
				num2 = ((FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200E\u200C\u200B\u206F\u200E\u202A\u206B\u206F\u200E\u206A\u206C\u202E\u202E\u206C\u202E\u202D\u202E\u202C\u206E\u202D\u202A\u200C\u200E\u200F\u206F\u200E\u202E\u200C\u206B\u200E\u200C\u206F\u200B\u206F\u202D\u200B\u206C\u206B\u202E\u202A\u202E(this) == CardType.Friend) ? 2047959186 : (-1997856707));
				goto IL_0015;
			}

			public override IEnumerable<Card> EnumerateRelativeCards()
			{
				FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<EnumerateRelativeCards>d__13 <EnumerateRelativeCards>d__ = new FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<EnumerateRelativeCards>d__13(-2);
				<EnumerateRelativeCards>d__.<>4__this = this;
				return <EnumerateRelativeCards>d__;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				this.Amount = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200F\u206F\u200D\u202A\u200B\u200C\u206C\u206F\u200C\u200F\u206E\u206D\u206A\u200E\u202D\u202E\u200F\u202B\u206F\u202E\u202B\u206E\u200B\u206F\u200F\u200F\u206F\u206C\u202D\u206C\u206D\u202C\u206B\u202A\u200D\u206C\u202A\u206D\u202A\u206E\u202E(this);
				base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u202B\u206E\u206F\u206C\u200D\u200D\u200F\u206D\u202E\u200D\u202C\u206B\u202A\u202C\u206E\u202D\u206E\u200D\u200F\u202A\u202E\u202B\u206B\u202E\u200D\u202D\u206E\u200B\u202D\u200F\u206D\u202E\u202E\u206B\u200D\u202E\u200B\u202E\u202B\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u206B\u202D\u200C\u200C\u200C\u202D\u206A\u202E\u206B\u200F\u206E\u206F\u200E\u206D\u206D\u202A\u200D\u200E\u202E\u202E\u202B\u200F\u206B\u206F\u206A\u200B\u206E\u202E\u206F\u200B\u202E\u206A\u200F\u202B\u206D\u200F\u206D\u202A\u206D\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
				base.ReactBattleEvent<CardUsingEventArgs>(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206A\u202D\u202C\u206D\u202C\u206C\u206F\u202C\u200F\u206A\u206F\u200E\u202C\u206C\u200F\u200D\u202A\u202A\u202A\u202D\u202C\u200E\u206F\u206E\u200E\u200B\u202C\u202E\u206C\u206E\u200E\u206C\u202B\u202B\u202C\u206B\u200E\u200F\u202A\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u206B\u202D\u200C\u200C\u200C\u202D\u206A\u202E\u206B\u200F\u206E\u206F\u200E\u206D\u206D\u202A\u200D\u200E\u202E\u202E\u202B\u200F\u206B\u206F\u206A\u200B\u206E\u202E\u206F\u200B\u202E\u206A\u200F\u202B\u206D\u200F\u206D\u202A\u206D\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<OnCardUsed>d__15 <OnCardUsed>d__ = new FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<OnCardUsed>d__15(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<GetPassiveActions>d__16 <GetPassiveActions>d__ = new FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<GetPassiveActions>d__16(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200E\u200C\u200B\u206F\u200E\u202A\u206B\u206F\u200E\u206A\u206C\u202E\u202E\u206C\u202E\u202D\u202E\u202C\u206E\u202D\u202A\u200C\u200E\u200F\u206F\u200E\u202E\u200C\u206B\u200E\u200C\u206F\u200B\u206F\u202D\u200B\u206C\u206B\u202E\u202A\u202E(this) == CardType.Friend)
				{
					List<FriendToken> list;
					for (;;)
					{
						IL_000C:
						int num = -1315282059;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((num2 ^ ~(357452983 * (953380101 - 969602516)) ^ (1348524467 - -1730281163 + -2007908431 * 345170365)) - (-833474000 - -720487832)) * 432608325)) % 16U)
							{
							case 0U:
								num = (int)(((FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206B\u200E\u206D\u206F\u206C\u200E\u200F\u206E\u206C\u202D\u206E\u200B\u200C\u202C\u202D\u202D\u200D\u200D\u200C\u202C\u206E\u206F\u200E\u200B\u200E\u200F\u202C\u202C\u200F\u202C\u206B\u200C\u202C\u202E\u206D\u200E\u206B\u200F\u206D\u202E(this) < -FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u200C\u206D\u206A\u206E\u206E\u202A\u200D\u200E\u206C\u202E\u202E\u202D\u200B\u206E\u202E\u206C\u200F\u200E\u202E\u200B\u202A\u202D\u200F\u202D\u200F\u206A\u206A\u206E\u206A\u200F\u200C\u200E\u200D\u206C\u206E\u202D\u200C\u206C\u206C\u202E(this)) ? 2398864248U : 1016246356U) ^ (num3 * 137561852U));
								continue;
							case 1U:
							{
								int? num4 = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206F\u206F\u206B\u202A\u200C\u206B\u200F\u200D\u206F\u206C\u200E\u202D\u200F\u200F\u206C\u206F\u206F\u200C\u202A\u206C\u206B\u206D\u206D\u202C\u206D\u202B\u202E\u206E\u202E\u200D\u200E\u202B\u202E\u200F\u206E\u200F\u206B\u206D\u206C\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(this));
								num = (int)((num3 * 1495003062U) ^ 2098092695U);
								continue;
							}
							case 2U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 2221758859U : 2961710248U) ^ (num3 * 107606154U));
								continue;
							}
							case 3U:
								num = (int)(((FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206B\u200E\u206D\u206F\u206C\u200E\u200F\u206E\u206C\u202D\u206E\u200B\u200C\u202C\u202D\u202D\u200D\u200D\u200C\u202C\u206E\u206F\u200E\u200B\u200E\u200F\u202C\u202C\u200F\u202C\u206B\u200C\u202C\u202E\u206D\u200E\u206B\u200F\u206D\u202E(this) < -FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206B\u200E\u206E\u202D\u206D\u206D\u206F\u206F\u206C\u202D\u206B\u202A\u206E\u202D\u206C\u206A\u200B\u202D\u200C\u206C\u206A\u202D\u200C\u200C\u206A\u202E\u200D\u202A\u206E\u200C\u202B\u202E\u202D\u200D\u202A\u202C\u200F\u200E\u202C\u202B\u202E(this)) ? 89073508U : 3924521217U) ^ (num3 * 2612054057U));
								continue;
							case 4U:
							{
								int? num4 = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200B\u206B\u206F\u206F\u206D\u206A\u202C\u202A\u202E\u200F\u206F\u202E\u202A\u206F\u200C\u200B\u206E\u202E\u200D\u202D\u202D\u200C\u200E\u200E\u200D\u202A\u206E\u200C\u206F\u202A\u206F\u200D\u206F\u206E\u200F\u200E\u202D\u200C\u202A\u202B\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(this));
								num = 1525059392;
								continue;
							}
							case 5U:
								list.Add(FriendToken.Active);
								num = (int)((num3 * 1311995690U) ^ 280886253U);
								continue;
							case 6U:
								if (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206E\u206C\u200E\u200C\u202E\u206B\u206D\u206C\u202B\u200C\u200D\u202B\u202A\u206C\u206E\u206F\u200C\u202E\u206E\u206E\u202C\u206B\u206A\u202A\u206A\u206F\u206B\u206F\u202B\u206C\u200D\u202C\u206F\u206C\u206E\u206E\u202A\u202B\u200B\u206F\u202E(this))
								{
									num = (int)((num3 * 3642075602U) ^ 3054213275U);
									continue;
								}
								goto IL_03DF;
							case 7U:
							{
								int? num4;
								num = (int)(((num4 != null) ? 3558515531U : 1350633416U) ^ (num3 * 3186189136U));
								continue;
							}
							case 8U:
								list = new List<FriendToken>();
								num = (int)(((!this.ActiveUsed) ? 1595582230U : 2248087503U) ^ (num3 * 1418385806U));
								continue;
							case 10U:
								list.Add(FriendToken.Ultimate);
								num = (int)((num3 * 3611787736U) ^ 3866883790U);
								continue;
							case 11U:
								list.Add(FriendToken.Active2);
								num = (int)((num3 * 2939007303U) ^ 417071973U);
								continue;
							case 12U:
								if (FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206B\u200E\u206D\u206F\u206C\u200E\u200F\u206E\u206C\u202D\u206E\u200B\u200C\u202C\u202D\u202D\u200D\u200D\u200C\u202C\u206E\u206F\u200E\u200B\u200E\u200F\u202C\u202C\u200F\u202C\u206B\u200C\u202C\u202E\u206D\u200E\u206B\u200F\u206D\u202E(this) >= base.MinLoyaltyToChooseSkill)
								{
									num = (int)((num3 * 2640813920U) ^ 1155958051U);
									continue;
								}
								goto IL_03DF;
							case 13U:
								goto IL_000C;
							case 14U:
								num = (int)(((FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206B\u200E\u206D\u206F\u206C\u200E\u200F\u206E\u206C\u202D\u206E\u200B\u200C\u202C\u202D\u202D\u200D\u200D\u200C\u202C\u206E\u206F\u200E\u200B\u200E\u200F\u202C\u202C\u200F\u202C\u206B\u200C\u202C\u202E\u206D\u200E\u206B\u200F\u206D\u202E(this) < -FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200D\u206A\u202E\u202B\u206A\u200C\u202D\u200E\u202D\u200E\u206D\u202C\u206B\u206D\u206A\u200D\u202D\u202E\u206A\u206D\u206C\u206E\u202C\u206E\u206B\u206D\u200B\u206B\u202B\u206C\u202D\u200F\u206E\u200F\u202B\u206B\u200F\u200E\u202E\u206F\u202E(this)) ? 3435997258U : 1781958429U) ^ (num3 * 2844151126U));
								continue;
							case 15U:
							{
								int? num4 = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u206D\u202D\u206A\u206C\u200C\u206C\u202C\u200C\u200C\u202C\u202D\u200B\u200D\u206F\u206B\u206F\u206A\u206A\u202E\u206D\u202A\u200E\u206F\u200E\u202E\u206A\u200C\u200B\u202A\u206C\u206F\u206D\u202E\u202C\u200E\u200F\u206F\u200E\u202E\u202E(FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(this));
								num = ((num4 != null) ? 30124365 : (-1738236866));
								continue;
							}
							}
							goto Block_1;
						}
					}
					Block_1:
					List<Card> list2 = FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200E\u202C\u206F\u200D\u206E\u206B\u200B\u206E\u200F\u202C\u200C\u206E\u200C\u200E\u206D\u206E\u206E\u202B\u200C\u200B\u200F\u206F\u200E\u202A\u206D\u202B\u202E\u202C\u206E\u200B\u202D\u200D\u206E\u206F\u206C\u206F\u200F\u200F\u206F\u202A\u202E(this, list.Count, false).ToList<Card>();
					IEnumerator<ValueTuple<int, FriendToken>> enumerator = list.WithIndices<FriendToken>().GetEnumerator();
					try
					{
						for (;;)
						{
							IL_033F:
							int num5 = ((!FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202D\u206E\u202A\u202C\u202E\u206E\u206C\u202B\u200C\u202E\u206A\u202E\u200E\u202C\u206A\u206E\u202B\u206F\u206B\u200D\u206B\u206F\u200F\u200D\u202D\u200F\u206A\u206F\u200E\u206F\u206A\u206F\u200D\u200C\u202E\u202B\u202E\u206C\u202A\u202E(enumerator)) ? 208395770 : 1546382549);
							for (;;)
							{
								int num2 = num5;
								switch (((num2 ^ ~(357452983 * (953380101 - 969602516)) ^ (1348524467 - -1730281163 + -2007908431 * 345170365)) - (-833474000 - -720487832)) * 432608325 % 4)
								{
								case 0:
									num5 = 1546382549;
									continue;
								case 2:
								{
									ValueTuple<int, FriendToken> valueTuple = enumerator.Current;
									int item = valueTuple.Item1;
									FriendToken item2 = valueTuple.Item2;
									FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u200F\u202E\u200C\u202B\u200F\u202C\u206A\u200D\u206B\u200F\u202B\u206C\u200D\u202C\u202D\u206F\u202D\u200B\u200B\u200E\u202B\u200D\u202D\u206B\u202D\u206A\u200E\u206E\u206C\u200F\u206E\u200F\u206B\u206B\u202E\u206F\u206F\u200C\u206C\u200D\u202E(list2[item], item2);
									num5 = -536425020;
									continue;
								}
								case 3:
									goto IL_033F;
								}
								goto Block_13;
							}
						}
						Block_13:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0360:
								int num6 = 986442955;
								for (;;)
								{
									int num2 = num6;
									uint num3;
									switch ((num3 = (uint)(((num2 ^ ~(357452983 * (953380101 - 969602516)) ^ (1348524467 - -1730281163 + -2007908431 * 345170365)) - (-833474000 - -720487832)) * 432608325)) % 3U)
									{
									case 1U:
										FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202A\u202A\u202C\u206C\u202A\u202D\u200B\u202C\u206C\u200F\u200B\u200E\u206F\u206F\u200F\u206C\u206B\u202C\u202D\u206B\u202A\u206E\u200D\u202B\u200F\u200F\u200B\u200B\u202E\u200E\u200C\u200C\u202B\u206B\u200C\u200F\u206B\u206B\u202E\u202A\u202E(enumerator);
										num6 = (int)((num3 * 3429384520U) ^ 1441607467U);
										continue;
									case 2U:
										goto IL_0360;
									}
									goto Block_16;
								}
							}
							Block_16:;
						}
					}
					return FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.\u202E\u206E\u206D\u200E\u206B\u202A\u200D\u200D\u206E\u206F\u200D\u206E\u200B\u206A\u206C\u206A\u200D\u202E\u206A\u200B\u202D\u202A\u202C\u206B\u202C\u202A\u200E\u200F\u200B\u206E\u202B\u200C\u200B\u206B\u206B\u202B\u206A\u206F\u202E\u206B\u202E(list2, false, false, false);
				}
				IL_03DF:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<Actions>d__19 <Actions>d__ = new FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<Actions>d__19(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			public override IEnumerable<BattleAction> AfterUseAction()
			{
				FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<AfterUseAction>d__20 <AfterUseAction>d__ = new FlandreFriendOkinaSpringDef.FlandreFriendOkinaSpring.<AfterUseAction>d__20(-2);
				<AfterUseAction>d__.<>4__this = this;
				return <AfterUseAction>d__;
			}

			static int? \u206B\u202A\u202B\u200D\u206B\u206E\u200B\u202C\u206D\u202A\u202D\u206C\u202C\u206D\u206F\u202A\u200F\u206A\u202B\u200B\u200C\u200B\u200F\u202A\u202B\u206B\u202D\u200E\u200F\u202D\u206B\u206D\u206C\u200F\u202A\u206E\u202D\u206A\u202A\u206E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static int \u202D\u206F\u200E\u206C\u206F\u202C\u206A\u200C\u200B\u200F\u206E\u202E\u200D\u200D\u200B\u200D\u202B\u202E\u206D\u200C\u206F\u206B\u206E\u200C\u206B\u202D\u206E\u200B\u206C\u202D\u206B\u202A\u202A\u200E\u206B\u202D\u206D\u200D\u206D\u206B\u202E(float A_0)
			{
				return A_0.FloorToInt();
			}

			static bool \u202D\u206E\u202A\u202C\u202E\u206E\u206C\u202B\u200C\u202E\u206A\u202E\u200E\u202C\u206A\u206E\u202B\u206F\u206B\u200D\u206B\u206F\u200F\u200D\u202D\u200F\u206A\u206F\u200E\u206F\u206A\u206F\u200D\u200C\u202E\u202B\u202E\u206C\u202A\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202A\u202A\u202C\u206C\u202A\u202D\u200B\u202C\u206C\u200F\u200B\u200E\u206F\u206F\u200F\u206C\u206B\u202C\u202D\u206B\u202A\u206E\u200D\u202B\u200F\u200F\u200B\u200B\u202E\u200E\u200C\u200C\u202B\u206B\u200C\u200F\u206B\u206B\u202E\u202A\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static CardConfig \u200C\u200E\u206A\u202B\u206E\u206E\u202B\u206B\u206D\u206A\u200D\u200C\u206C\u206A\u200D\u206B\u202C\u200B\u200E\u206A\u206F\u202E\u206E\u206A\u200C\u202D\u200C\u200F\u200E\u202C\u206E\u200E\u202C\u206C\u206F\u200E\u200E\u202A\u200B\u200C\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u200E\u200B\u200B\u200F\u206A\u206E\u200B\u200B\u200D\u202D\u206C\u200B\u206B\u202E\u200E\u200C\u200F\u202D\u202E\u200D\u200E\u202D\u200F\u202C\u206F\u206B\u206A\u202D\u200E\u202B\u202B\u202B\u206B\u206C\u202C\u202E\u202B\u206F\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u200E\u200C\u200B\u206F\u200E\u202A\u206B\u206F\u200E\u206A\u206C\u202E\u202E\u206C\u202E\u202D\u202E\u202C\u206E\u202D\u202A\u200C\u200E\u200F\u206F\u200E\u202E\u200C\u206B\u200E\u200C\u206F\u200B\u206F\u202D\u200B\u206C\u206B\u202E\u202A\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u202A\u200E\u206D\u206F\u200C\u200E\u202E\u206A\u202E\u206C\u202C\u206C\u200C\u202B\u202C\u202E\u202E\u206B\u206A\u202D\u206B\u200C\u206A\u200C\u200D\u206F\u202D\u202D\u200B\u200F\u200D\u200D\u206B\u202D\u200F\u202D\u202E\u206B\u200C\u202B\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static BattleController \u202A\u206B\u202D\u200C\u200C\u200C\u202D\u206A\u202E\u206B\u200F\u206E\u206F\u200E\u206D\u206D\u202A\u200D\u200E\u202E\u202E\u202B\u200F\u206B\u206F\u206A\u200B\u206E\u202E\u206F\u200B\u202E\u206A\u200F\u202B\u206D\u200F\u206D\u202A\u206D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u202B\u202B\u206F\u206A\u202A\u206D\u200E\u200B\u200C\u200B\u202C\u202A\u206B\u200D\u202D\u200D\u202B\u206A\u202B\u200E\u200B\u200E\u206E\u206E\u202B\u200E\u200F\u202B\u202D\u200C\u200F\u202C\u202D\u202A\u206C\u202B\u206F\u200B\u202D\u202D\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u206C\u206A\u202B\u202A\u206D\u206D\u200D\u202D\u206A\u200C\u202B\u202E\u206B\u202A\u200C\u206C\u202D\u206B\u206D\u206D\u202C\u206E\u200C\u200E\u202E\u202C\u206D\u200C\u200B\u206A\u200F\u202D\u200D\u206B\u202A\u200C\u202A\u206C\u206B\u206B\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u202A\u202A\u206C\u206F\u206A\u200C\u200C\u206D\u206E\u202A\u202C\u206E\u200E\u200E\u206E\u206E\u202A\u200C\u202D\u202E\u206F\u202A\u206E\u206B\u200E\u202C\u206B\u200F\u200E\u202C\u200E\u200B\u200B\u200B\u202A\u206B\u200B\u206F\u206D\u200F\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200B\u202D\u206A\u206C\u200F\u206B\u200E\u206A\u202A\u202C\u206C\u206B\u200B\u206D\u200C\u206A\u202B\u206C\u200D\u200D\u202C\u202C\u202C\u200B\u202B\u206D\u200B\u206E\u206F\u202D\u202B\u206B\u206A\u202D\u202C\u202A\u206B\u206A\u202B\u202E\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static int \u200F\u206F\u200D\u202A\u200B\u200C\u206C\u206F\u200C\u200F\u206E\u206D\u206A\u200E\u202D\u202E\u200F\u202B\u206F\u202E\u202B\u206E\u200B\u206F\u200F\u200F\u206F\u206C\u202D\u206C\u206D\u202C\u206B\u202A\u200D\u206C\u202A\u206D\u202A\u206E\u202E(Card A_0)
			{
				return A_0.Value1;
			}

			static GameEvent<CardUsingEventArgs> \u202D\u202B\u206E\u206F\u206C\u200D\u200D\u200F\u206D\u202E\u200D\u202C\u206B\u202A\u202C\u206E\u202D\u206E\u200D\u200F\u202A\u202E\u202B\u206B\u202E\u200D\u202D\u206E\u200B\u202D\u200F\u206D\u202E\u202E\u206B\u200D\u202E\u200B\u202E\u202B\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardUsingEventArgs> \u202D\u206A\u202D\u202C\u206D\u202C\u206C\u206F\u202C\u200F\u206A\u206F\u200E\u202C\u206C\u200F\u200D\u202A\u202A\u202A\u202D\u202C\u200E\u206F\u206E\u200E\u200B\u202C\u202E\u206C\u206E\u200E\u206C\u202B\u202B\u202C\u206B\u200E\u200F\u202A\u202E(BattleController A_0)
			{
				return A_0.CardPlayed;
			}

			static bool \u206E\u206C\u200E\u200C\u202E\u206B\u206D\u206C\u202B\u200C\u200D\u202B\u202A\u206C\u206E\u206F\u200C\u202E\u206E\u206E\u202C\u206B\u206A\u202A\u206A\u206F\u206B\u206F\u202B\u206C\u200D\u202C\u206F\u206C\u206E\u206E\u202A\u202B\u200B\u206F\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202D\u206B\u200E\u206D\u206F\u206C\u200E\u200F\u206E\u206C\u202D\u206E\u200B\u200C\u202C\u202D\u202D\u200D\u200D\u200C\u202C\u206E\u206F\u200E\u200B\u200E\u200F\u202C\u202C\u200F\u202C\u206B\u200C\u202C\u202E\u206D\u200E\u206B\u200F\u206D\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static int? \u202D\u206F\u206F\u206B\u202A\u200C\u206B\u200F\u200D\u206F\u206C\u200E\u202D\u200F\u200F\u206C\u206F\u206F\u200C\u202A\u206C\u206B\u206D\u206D\u202C\u206D\u202B\u202E\u206E\u202E\u200D\u200E\u202B\u202E\u200F\u206E\u200F\u206B\u206D\u206C\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost;
			}

			static int \u206B\u200E\u206E\u202D\u206D\u206D\u206F\u206F\u206C\u202D\u206B\u202A\u206E\u202D\u206C\u206A\u200B\u202D\u200C\u206C\u206A\u202D\u200C\u200C\u206A\u202E\u200D\u202A\u206E\u200C\u202B\u202E\u202D\u200D\u202A\u202C\u200F\u200E\u202C\u202B\u202E(Card A_0)
			{
				return A_0.ActiveCost;
			}

			static int? \u200B\u206B\u206F\u206F\u206D\u206A\u202C\u202A\u202E\u200F\u206F\u202E\u202A\u206F\u200C\u200B\u206E\u202E\u200D\u202D\u202D\u200C\u200E\u200E\u200D\u202A\u206E\u200C\u206F\u202A\u206F\u200D\u206F\u206E\u200F\u200E\u202D\u200C\u202A\u202B\u202E(CardConfig A_0)
			{
				return A_0.ActiveCost2;
			}

			static int \u202A\u200C\u206D\u206A\u206E\u206E\u202A\u200D\u200E\u206C\u202E\u202E\u202D\u200B\u206E\u202E\u206C\u200F\u200E\u202E\u200B\u202A\u202D\u200F\u202D\u200F\u206A\u206A\u206E\u206A\u200F\u200C\u200E\u200D\u206C\u206E\u202D\u200C\u206C\u206C\u202E(Card A_0)
			{
				return A_0.ActiveCost2;
			}

			static int? \u206D\u202D\u206A\u206C\u200C\u206C\u202C\u200C\u200C\u202C\u202D\u200B\u200D\u206F\u206B\u206F\u206A\u206A\u202E\u206D\u202A\u200E\u206F\u200E\u202E\u206A\u200C\u200B\u202A\u206C\u206F\u206D\u202E\u202C\u200E\u200F\u206F\u200E\u202E\u202E(CardConfig A_0)
			{
				return A_0.UltimateCost;
			}

			static int \u200D\u206A\u202E\u202B\u206A\u200C\u202D\u200E\u202D\u200E\u206D\u202C\u206B\u206D\u206A\u200D\u202D\u202E\u206A\u206D\u206C\u206E\u202C\u206E\u206B\u206D\u200B\u206B\u202B\u206C\u202D\u200F\u206E\u200F\u202B\u206B\u200F\u200E\u202E\u206F\u202E(Card A_0)
			{
				return A_0.UltimateCost;
			}

			static IEnumerable<Card> \u200E\u202C\u206F\u200D\u206E\u206B\u200B\u206E\u200F\u202C\u200C\u206E\u200C\u200E\u206D\u206E\u206E\u202B\u200C\u200B\u200F\u206F\u200E\u202A\u206D\u202B\u202E\u202C\u206E\u200B\u202D\u200D\u206E\u206F\u206C\u206F\u200F\u200F\u206F\u202A\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u200F\u202E\u200C\u202B\u200F\u202C\u206A\u200D\u206B\u200F\u202B\u206C\u200D\u202C\u202D\u206F\u202D\u200B\u200B\u200E\u202B\u200D\u202D\u206B\u202D\u206A\u200E\u206E\u206C\u200F\u206E\u200F\u206B\u206B\u202E\u206F\u206F\u200C\u206C\u200D\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static MiniSelectCardInteraction \u202E\u206E\u206D\u200E\u206B\u202A\u200D\u200D\u206E\u206F\u200D\u206E\u200B\u206A\u206C\u206A\u200D\u202E\u206A\u200B\u202D\u202A\u202C\u206B\u202C\u202A\u200E\u200F\u200B\u206E\u202B\u200C\u200B\u206B\u206B\u202B\u206A\u206F\u202E\u206B\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			public bool ActiveUsed;
		}
	}
}
