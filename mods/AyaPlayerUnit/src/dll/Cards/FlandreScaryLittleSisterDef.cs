using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
	public sealed class FlandreScaryLittleSisterDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1642585913);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreScaryLittleSisterDef.\u200D\u202D\u200E\u202C\u206A\u206B\u206A\u206E\u206F\u202A\u200B\u202D\u200B\u206A\u202D\u200B\u200C\u206F\u200E\u200E\u202B\u202B\u206B\u206A\u206A\u206E\u200F\u200B\u200C\u206B\u200F\u200B\u202B\u200D\u202D\u202E\u202D\u200D\u206E\u202D\u202E(BepinexPlugin.embeddedSource);
			FlandreScaryLittleSisterDef.\u206B\u206C\u200B\u202D\u206E\u202D\u206A\u206B\u202A\u202B\u202B\u200E\u206D\u206D\u206A\u202B\u202E\u202D\u202D\u202B\u200F\u200C\u206B\u202A\u206B\u200C\u206E\u200B\u206F\u200F\u202D\u206E\u202C\u206D\u206E\u206E\u200F\u206F\u200B\u206D\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreScaryLittleSisterDef.\u206C\u206B\u202E\u206F\u206E\u206F\u206F\u200D\u202C\u206A\u206A\u202B\u200D\u202C\u200C\u206A\u206E\u206F\u206E\u200F\u200D\u206C\u200E\u206B\u206A\u200C\u202C\u206D\u200C\u206A\u206C\u200E\u200F\u202E\u200F\u202E\u202E\u206E\u200F\u206D\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreScaryLittleSisterDef.\u206D\u202A\u200D\u202D\u200B\u202C\u206D\u200E\u200C\u206F\u202C\u206F\u200D\u200B\u200D\u202D\u206C\u206B\u206D\u206D\u200F\u206F\u206B\u200F\u200B\u206F\u202C\u206D\u206E\u200F\u202C\u200C\u200C\u206B\u200F\u202C\u206E\u206D\u206D\u202E(BepinexPlugin.sequenceTable, FlandreScaryLittleSisterDef.\u206A\u202C\u206A\u206D\u200C\u206E\u200B\u200F\u202B\u206D\u200E\u206A\u206B\u206F\u202A\u200C\u200C\u200E\u202C\u202C\u206F\u200E\u202C\u202C\u200E\u202D\u202A\u202E\u200D\u200C\u202E\u206F\u206F\u206E\u206F\u200B\u206B\u200D\u202E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-699874213), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1179916944), 0, true, true, false, true, true, Rarity.Uncommon, CardType.Defense, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black
			}, false, new ManaGroup
			{
				Any = 3
			}, null, null, null, null, null, null, new int?(27), null, null, null, new int?(2), null, new int?(2), null, new ManaGroup?(new ManaGroup
			{
				Philosophy = 2
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.Block | Keyword.Philosophy | Keyword.Exile, Keyword.Block | Keyword.Philosophy | Keyword.Exile, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(853102821) }, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(27477428) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1168427686), new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(116750073) });
		}

		static CardImages \u200D\u202D\u200E\u202C\u206A\u206B\u206A\u206E\u206F\u202A\u200B\u202D\u200B\u206A\u202D\u200B\u200C\u206F\u200E\u200E\u202B\u202B\u206B\u206A\u206A\u206E\u200F\u200B\u200C\u206B\u200F\u200B\u202B\u200D\u202D\u202E\u202D\u200D\u206E\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u206C\u200B\u202D\u206E\u202D\u206A\u206B\u202A\u202B\u202B\u200E\u206D\u206D\u206A\u202B\u202E\u202D\u202D\u202B\u200F\u200C\u206B\u202A\u206B\u200C\u206E\u200B\u206F\u200F\u202D\u206E\u202C\u206D\u206E\u206E\u200F\u206F\u200B\u206D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u206B\u202E\u206F\u206E\u206F\u206F\u200D\u202C\u206A\u206A\u202B\u200D\u202C\u200C\u206A\u206E\u206F\u206E\u200F\u200D\u206C\u200E\u206B\u206A\u200C\u202C\u206D\u200C\u206A\u206C\u200E\u200F\u202E\u200F\u202E\u202E\u206E\u200F\u206D\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206A\u202C\u206A\u206D\u200C\u206E\u200B\u200F\u202B\u206D\u200E\u206A\u206B\u206F\u202A\u200C\u200C\u200E\u202C\u202C\u206F\u200E\u202C\u202C\u200E\u202D\u202A\u202E\u200D\u200C\u202E\u206F\u206F\u206E\u206F\u200B\u206B\u200D\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206D\u202A\u200D\u202D\u200B\u202C\u206D\u200E\u200C\u206F\u202C\u206F\u200D\u200B\u200D\u202D\u206C\u206B\u206D\u206D\u200F\u206F\u206B\u200F\u200B\u206F\u202C\u206D\u206E\u200F\u202C\u200C\u200C\u206B\u200F\u202C\u206E\u206D\u206D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreScaryLittleSisterDef))]
		public sealed class FlandreScaryLittleSister : FlandreCard
		{
			public override int AdditionalBlock
			{
				get
				{
					return FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202B\u206A\u200E\u200E\u206E\u202B\u200C\u200C\u206D\u202E\u202B\u202E\u202B\u200B\u202A\u202A\u206A\u200C\u206A\u200F\u202E\u206B\u200E\u206E\u200C\u202B\u206C\u206E\u202C\u206D\u202D\u206D\u202E\u202A\u200D\u206A\u206A\u200E\u206E\u200E\u202E(this).GetValueOrDefault() * 9;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202B\u206A\u200E\u200E\u206E\u202B\u200C\u200C\u206D\u202E\u202B\u202E\u202B\u200B\u202A\u202A\u206A\u200C\u206A\u200F\u202E\u206B\u200E\u206E\u200C\u202B\u206C\u206E\u202C\u206D\u202D\u206D\u202E\u202A\u200D\u206A\u206A\u200E\u206E\u200E\u202E(this).GetValueOrDefault();
				}
			}

			public override int AdditionalValue2
			{
				get
				{
					return FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202B\u206A\u200E\u200E\u206E\u202B\u200C\u200C\u206D\u202E\u202B\u202E\u202B\u200B\u202A\u202A\u206A\u200C\u206A\u200F\u202E\u206B\u200E\u206E\u200C\u202B\u206C\u206E\u202C\u206D\u202D\u206D\u202E\u202A\u200D\u206A\u206A\u200E\u206E\u200E\u202E(this).GetValueOrDefault();
				}
			}

			public override ManaGroup FlandreMana
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					if (FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u200C\u206C\u202D\u206F\u200D\u206A\u206D\u202E\u206C\u200C\u200C\u206A\u202B\u202E\u206F\u200B\u200E\u206F\u206D\u200F\u202E\u202C\u202C\u200F\u200D\u206E\u206E\u202D\u200C\u200F\u200D\u200F\u200F\u200D\u202C\u200D\u206D\u206A\u206D\u202B\u202E(this))
					{
						goto IL_000B;
					}
					ManaGroup? manaGroup = FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u200B\u200D\u206E\u200E\u200B\u206A\u202A\u206E\u206F\u206B\u206A\u200D\u202A\u200B\u200E\u206C\u202B\u206F\u200B\u202C\u206C\u206D\u200B\u202B\u200B\u200D\u200F\u200E\u202D\u200F\u202E\u206C\u202A\u200F\u206B\u200F\u206C\u200D\u202A\u206D\u202E(FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u206C\u200D\u206D\u200D\u206A\u200E\u200D\u200F\u200D\u200E\u206C\u200D\u200C\u202E\u200F\u206E\u206B\u200F\u206F\u202E\u206D\u206F\u202B\u206C\u206C\u200E\u200B\u206F\u200E\u202B\u206B\u202D\u202A\u206E\u200F\u202E\u200C\u206C\u200C\u206C\u202E(this));
					goto IL_00ED;
					int num2;
					ManaGroup? manaGroup2;
					ManaGroup manaGroup3;
					ManaGroup? manaGroup4;
					for (;;)
					{
						IL_0010:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(~(uint)(num * -1521978237 * -1011604891 - ~-1451560171))) % 8U)
						{
						case 0U:
							num2 = (int)(((manaGroup2 == null) ? 2706353424U : 3135375410U) ^ (num3 * 1660164444U));
							continue;
						case 1U:
							goto IL_0057;
						case 3U:
							manaGroup3 = manaGroup2.GetValueOrDefault() + this.AdditionalMana;
							num2 = 1198663345;
							continue;
						case 4U:
							goto IL_000B;
						case 5U:
							manaGroup4 = FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202D\u202A\u206E\u200D\u200D\u200F\u200F\u202E\u202E\u202E\u200B\u206F\u202E\u206B\u200B\u200D\u200D\u200B\u200F\u206B\u200E\u200E\u202C\u202E\u206F\u200F\u202C\u202B\u202D\u200E\u202C\u206C\u202E\u200C\u200C\u202A\u202D\u206D\u202A\u206E\u202E(FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u206C\u200D\u206D\u200D\u206A\u200E\u200D\u200F\u200D\u200E\u206C\u200D\u200C\u202E\u200F\u206E\u206B\u200F\u206F\u202E\u206D\u206F\u202B\u206C\u206C\u200E\u200B\u206F\u200E\u202B\u206B\u202D\u202A\u206E\u200F\u202E\u200C\u206C\u200C\u206C\u202E(this));
							num2 = (int)((num3 * 1434726310U) ^ 380067896U);
							continue;
						case 6U:
							goto IL_00D2;
						case 7U:
							if (manaGroup4 == null)
							{
								num2 = (int)((num3 * 3803516839U) ^ 3226405876U);
								continue;
							}
							goto IL_00DF;
						}
						break;
					}
					goto IL_0134;
					IL_0057:
					throw FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u200F\u202A\u200F\u206C\u200E\u200C\u202E\u202A\u206F\u202D\u200E\u206C\u200E\u206D\u202D\u202B\u206D\u200D\u200D\u202A\u202C\u200C\u202B\u200E\u206C\u206C\u200D\u202D\u206F\u200F\u206C\u202B\u200E\u200C\u202A\u202D\u206C\u206C\u202C\u202D\u202E(FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u206B\u206A\u206E\u202A\u202E\u206C\u202D\u202D\u200E\u202C\u200B\u206B\u202D\u202B\u202C\u200C\u202A\u202B\u202B\u200E\u206E\u202D\u206F\u200F\u206B\u202E\u206A\u206E\u200D\u206D\u202A\u200B\u200B\u206F\u200C\u202C\u200D\u206E\u200E\u202E(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-15097737), FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202A\u202E\u206A\u200B\u202C\u202B\u206A\u202C\u206D\u206E\u206F\u200D\u202C\u206A\u202D\u200E\u202E\u202D\u202C\u202E\u206C\u200E\u202D\u202E\u206C\u200C\u202E\u206E\u200E\u202B\u206B\u202D\u206F\u200B\u206D\u206A\u200F\u202D\u202B\u200D\u202E(this), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-325437937)));
					IL_00D2:
					manaGroup = FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u200B\u200D\u206E\u200E\u200B\u206A\u202A\u206E\u206F\u206B\u206A\u200D\u202A\u200B\u200E\u206C\u202B\u206F\u200B\u202C\u206C\u206D\u200B\u202B\u200B\u200D\u200F\u200E\u202D\u200F\u202E\u206C\u202A\u200F\u206B\u200F\u206C\u200D\u202A\u206D\u202E(FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u206C\u200D\u206D\u200D\u206A\u200E\u200D\u200F\u200D\u200E\u206C\u200D\u200C\u202E\u200F\u206E\u206B\u200F\u206F\u202E\u206D\u206F\u202B\u206C\u206C\u200E\u200B\u206F\u200E\u202B\u206B\u202D\u202A\u206E\u200F\u202E\u200C\u206C\u200C\u206C\u202E(this));
					goto IL_00ED;
					IL_00DF:
					manaGroup = manaGroup4;
					goto IL_00ED;
					IL_0134:
					IEnumerator<ManaColor> enumerator = ManaColors.WUBRGCP.GetEnumerator();
					try
					{
						for (;;)
						{
							IL_01D4:
							int num4 = (FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u200C\u202B\u202C\u200D\u206A\u206B\u200C\u202D\u202E\u202A\u200B\u206E\u202C\u202A\u206C\u206A\u206A\u202B\u202C\u202E\u200B\u200D\u206A\u200F\u200B\u206B\u206E\u206A\u206F\u200F\u202B\u202E\u206E\u202A\u206D\u206C\u202B\u200B\u206B\u202E\u202E(enumerator) ? 984790138 : 44121799);
							for (;;)
							{
								int num = num4;
								uint num3;
								switch ((num3 = (uint)(~(uint)(num * -1521978237 * -1011604891 - ~-1451560171))) % 5U)
								{
								case 0U:
									num4 = 984790138;
									continue;
								case 2U:
								{
									ManaColor manaColor;
									manaGroup3.SetValue(manaColor, base.FlandreModifier(manaGroup3.GetValue(manaColor), false));
									num4 = (int)((num3 * 3567126315U) ^ 1291610725U);
									continue;
								}
								case 3U:
								{
									ManaColor manaColor = enumerator.Current;
									num4 = ((manaGroup3.GetValue(manaColor) <= 0) ? (-695938608) : (-328639274));
									continue;
								}
								case 4U:
									goto IL_01D4;
								}
								goto Block_6;
							}
						}
						Block_6:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_01F7:
								int num5 = -1207654707;
								for (;;)
								{
									int num = num5;
									uint num3;
									switch ((num3 = (uint)(~(uint)(num * -1521978237 * -1011604891 - ~-1451560171))) % 3U)
									{
									case 0U:
										goto IL_01F7;
									case 1U:
										FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202B\u206C\u200D\u200C\u200F\u206A\u206D\u202A\u206A\u200C\u206D\u206B\u206C\u202A\u206E\u206E\u202E\u206F\u206F\u200E\u206F\u206B\u200E\u206C\u206B\u206C\u202A\u200D\u206F\u206E\u200D\u206C\u200D\u200C\u206D\u200B\u200C\u206E\u206C\u206F\u202E(enumerator);
										num5 = (int)((num3 * 2578167U) ^ 2156201302U);
										continue;
									}
									goto Block_10;
								}
							}
							Block_10:;
						}
					}
					return manaGroup3;
					IL_000B:
					num2 = 1223378108;
					goto IL_0010;
					IL_00ED:
					manaGroup2 = manaGroup;
					num2 = -1051781001;
					goto IL_0010;
				}
			}

			public override ManaGroup AdditionalMana
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = FlandreScaryLittleSisterDef.FlandreScaryLittleSister.\u202B\u206A\u200E\u200E\u206E\u202B\u200C\u200C\u206D\u202E\u202B\u202E\u202B\u200B\u202A\u202A\u206A\u200C\u206A\u200F\u202E\u206B\u200E\u206E\u200C\u202B\u206C\u206E\u202C\u206D\u202D\u206D\u202E\u202A\u200D\u206A\u206A\u200E\u206E\u200E\u202E(this).GetValueOrDefault()
					};
				}
			}

			public override IEnumerable<BattleAction> OnExile(CardZone srcZone)
			{
				FlandreScaryLittleSisterDef.FlandreScaryLittleSister.<OnExile>d__10 <OnExile>d__ = new FlandreScaryLittleSisterDef.FlandreScaryLittleSister.<OnExile>d__10(-2);
				<OnExile>d__.<>4__this = this;
				return <OnExile>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreScaryLittleSisterDef.FlandreScaryLittleSister.<Actions>d__11 <Actions>d__ = new FlandreScaryLittleSisterDef.FlandreScaryLittleSister.<Actions>d__11(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static int? \u202B\u206A\u200E\u200E\u206E\u202B\u200C\u200C\u206D\u202E\u202B\u202E\u202B\u200B\u202A\u202A\u206A\u200C\u206A\u200F\u202E\u206B\u200E\u206E\u200C\u202B\u206C\u206E\u202C\u206D\u202D\u206D\u202E\u202A\u200D\u206A\u206A\u200E\u206E\u200E\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static bool \u200C\u206C\u202D\u206F\u200D\u206A\u206D\u202E\u206C\u200C\u200C\u206A\u202B\u202E\u206F\u200B\u200E\u206F\u206D\u200F\u202E\u202C\u202C\u200F\u200D\u206E\u206E\u202D\u200C\u200F\u200D\u200F\u200F\u200D\u202C\u200D\u206D\u206A\u206D\u202B\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static CardConfig \u206C\u200D\u206D\u200D\u206A\u200E\u200D\u200F\u200D\u200E\u206C\u200D\u200C\u202E\u200F\u206E\u206B\u200F\u206F\u202E\u206D\u206F\u202B\u206C\u206C\u200E\u200B\u206F\u200E\u202B\u206B\u202D\u202A\u206E\u200F\u202E\u200C\u206C\u200C\u206C\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static ManaGroup? \u202D\u202A\u206E\u200D\u200D\u200F\u200F\u202E\u202E\u202E\u200B\u206F\u202E\u206B\u200B\u200D\u200D\u200B\u200F\u206B\u200E\u200E\u202C\u202E\u206F\u200F\u202C\u202B\u202D\u200E\u202C\u206C\u202E\u200C\u200C\u202A\u202D\u206D\u202A\u206E\u202E(CardConfig A_0)
			{
				return A_0.UpgradedMana;
			}

			static ManaGroup? \u200B\u200D\u206E\u200E\u200B\u206A\u202A\u206E\u206F\u206B\u206A\u200D\u202A\u200B\u200E\u206C\u202B\u206F\u200B\u202C\u206C\u206D\u200B\u202B\u200B\u200D\u200F\u200E\u202D\u200F\u202E\u206C\u202A\u200F\u206B\u200F\u206C\u200D\u202A\u206D\u202E(CardConfig A_0)
			{
				return A_0.Mana;
			}

			static string \u202A\u202E\u206A\u200B\u202C\u202B\u206A\u202C\u206D\u206E\u206F\u200D\u202C\u206A\u202D\u200E\u202E\u202D\u202C\u202E\u206C\u200E\u202D\u202E\u206C\u200C\u202E\u206E\u200E\u202B\u206B\u202D\u206F\u200B\u206D\u206A\u200F\u202D\u202B\u200D\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static string \u206B\u206A\u206E\u202A\u202E\u206C\u202D\u202D\u200E\u202C\u200B\u206B\u202D\u202B\u202C\u200C\u202A\u202B\u202B\u200E\u206E\u202D\u206F\u200F\u206B\u202E\u206A\u206E\u200D\u206D\u202A\u200B\u200B\u206F\u200C\u202C\u200D\u206E\u200E\u202E(string A_0, string A_1, string A_2)
			{
				return A_0 + A_1 + A_2;
			}

			static InvalidDataException \u200F\u202A\u200F\u206C\u200E\u200C\u202E\u202A\u206F\u202D\u200E\u206C\u200E\u206D\u202D\u202B\u206D\u200D\u200D\u202A\u202C\u200C\u202B\u200E\u206C\u206C\u200D\u202D\u206F\u200F\u206C\u202B\u200E\u200C\u202A\u202D\u206C\u206C\u202C\u202D\u202E(string A_0)
			{
				return new InvalidDataException(A_0);
			}

			static bool \u200C\u202B\u202C\u200D\u206A\u206B\u200C\u202D\u202E\u202A\u200B\u206E\u202C\u202A\u206C\u206A\u206A\u202B\u202C\u202E\u200B\u200D\u206A\u200F\u200B\u206B\u206E\u206A\u206F\u200F\u202B\u202E\u206E\u202A\u206D\u206C\u202B\u200B\u206B\u202E\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u202B\u206C\u200D\u200C\u200F\u206A\u206D\u202A\u206A\u200C\u206D\u206B\u206C\u202A\u206E\u206E\u202E\u206F\u206F\u200E\u206F\u206B\u200E\u206C\u206B\u206C\u202A\u200D\u206F\u206E\u200D\u206C\u200D\u200C\u206D\u200B\u200C\u206E\u206C\u206F\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}
		}
	}
}
