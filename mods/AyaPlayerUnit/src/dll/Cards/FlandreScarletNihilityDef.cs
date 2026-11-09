using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
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
	public sealed class FlandreScarletNihilityDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1745795740);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreScarletNihilityDef.\u206E\u206B\u206F\u200E\u202B\u206F\u206A\u202E\u206A\u200C\u202E\u206F\u206D\u206E\u202C\u206C\u200B\u200C\u206F\u206C\u206B\u202E\u202D\u202D\u206B\u202C\u206E\u200D\u206F\u206C\u206D\u206E\u202A\u206C\u206B\u202B\u206A\u202A\u206D\u200D\u202E(BepinexPlugin.embeddedSource);
			FlandreScarletNihilityDef.\u206E\u206C\u206D\u206E\u206E\u200E\u200C\u206E\u206F\u202D\u200B\u206C\u206D\u200C\u200C\u200D\u206A\u206A\u202D\u206B\u200C\u200C\u202E\u206D\u206A\u200E\u200C\u206E\u206F\u202E\u206C\u200E\u206D\u200B\u202D\u206C\u206D\u200F\u202E\u202E\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreScarletNihilityDef.\u206B\u200E\u206B\u200E\u206A\u200F\u200E\u200F\u206E\u206C\u200F\u206D\u206D\u202B\u200C\u200B\u200E\u206D\u200C\u206F\u206E\u206A\u200B\u206F\u202D\u206C\u200E\u202A\u206A\u206E\u206B\u202E\u206F\u200F\u200B\u202C\u202B\u202E\u202A\u202B\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreScarletNihilityDef.\u202C\u200B\u200D\u206E\u202E\u200F\u202E\u206D\u200D\u200D\u202C\u200D\u202A\u202D\u206B\u202C\u202B\u206A\u202D\u206B\u200B\u200B\u200E\u206E\u206D\u202A\u200D\u200F\u202B\u200B\u200C\u206E\u202D\u202D\u206B\u206C\u200D\u206A\u206D\u200E\u202E(BepinexPlugin.sequenceTable, FlandreScarletNihilityDef.\u202A\u206B\u206B\u202C\u206B\u206B\u200D\u202E\u200C\u202D\u200E\u202B\u202B\u206A\u202B\u206E\u200F\u206F\u206A\u206F\u202D\u200E\u202C\u206D\u206A\u206B\u206F\u200F\u206C\u206E\u206D\u200E\u202B\u202D\u206B\u202A\u206E\u206A\u206C\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, true, true, false, false, true, Rarity.Rare, CardType.Attack, new TargetType?(TargetType.SingleEnemy), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Black,
				ManaColor.Red
			}, false, new ManaGroup
			{
				Any = 2,
				Blue = 1,
				Black = 1,
				Red = 1
			}, null, null, null, null, new int?(100), null, null, null, null, null, new int?(20), null, new int?(33), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Accuracy | Keyword.Replenish, Keyword.Accuracy | Keyword.Replenish, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-344256836) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-344256836) }, new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(375531588), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-45675087), new List<string>());
		}

		static CardImages \u206E\u206B\u206F\u200E\u202B\u206F\u206A\u202E\u206A\u200C\u202E\u206F\u206D\u206E\u202C\u206C\u200B\u200C\u206F\u206C\u206B\u202E\u202D\u202D\u206B\u202C\u206E\u200D\u206F\u206C\u206D\u206E\u202A\u206C\u206B\u202B\u206A\u202A\u206D\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206E\u206C\u206D\u206E\u206E\u200E\u200C\u206E\u206F\u202D\u200B\u206C\u206D\u200C\u200C\u200D\u206A\u206A\u202D\u206B\u200C\u200C\u202E\u206D\u206A\u200E\u200C\u206E\u206F\u202E\u206C\u200E\u206D\u200B\u202D\u206C\u206D\u200F\u202E\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206B\u200E\u206B\u200E\u206A\u200F\u200E\u200F\u206E\u206C\u200F\u206D\u206D\u202B\u200C\u200B\u200E\u206D\u200C\u206F\u206E\u206A\u200B\u206F\u202D\u206C\u200E\u202A\u206A\u206E\u206B\u202E\u206F\u200F\u200B\u202C\u202B\u202E\u202A\u202B\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202A\u206B\u206B\u202C\u206B\u206B\u200D\u202E\u200C\u202D\u200E\u202B\u202B\u206A\u202B\u206E\u200F\u206F\u206A\u206F\u202D\u200E\u202C\u206D\u206A\u206B\u206F\u200F\u206C\u206E\u206D\u200E\u202B\u202D\u206B\u202A\u206E\u206A\u206C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u202C\u200B\u200D\u206E\u202E\u200F\u202E\u206D\u200D\u200D\u202C\u200D\u202A\u202D\u206B\u202C\u202B\u206A\u202D\u206B\u200B\u200B\u200E\u206E\u206D\u202A\u200D\u200F\u202B\u200B\u200C\u206E\u202D\u202D\u206B\u206C\u200D\u206A\u206D\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreScarletNihilityDef))]
		public sealed class FlandreScarletNihility : FlandreCard
		{
			public override int AdditionalDamage
			{
				get
				{
					return FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u206C\u206E\u206E\u206D\u200B\u206F\u200B\u202E\u206F\u206D\u202D\u200B\u202B\u206D\u200B\u202B\u202B\u206C\u206C\u202E\u200C\u206F\u206F\u200C\u202A\u206F\u206A\u206B\u202B\u206A\u202C\u200C\u200F\u200C\u202A\u200C\u202C\u202C\u206F\u202E(this).GetValueOrDefault() * 100 + this.Amount;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					return FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u206C\u206E\u206E\u206D\u200B\u206F\u200B\u202E\u206F\u206D\u202D\u200B\u202B\u206D\u200B\u202B\u202B\u206C\u206C\u202E\u200C\u206F\u206F\u200C\u202A\u206F\u206A\u206B\u202B\u206A\u202C\u200C\u200F\u200C\u202A\u200C\u202C\u202C\u206F\u202E(this).GetValueOrDefault() * 20;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.HandleBattleEvent<ManaEventArgs>(FlandreScarletNihilityDef.FlandreScarletNihility.\u206F\u206E\u200D\u206B\u206D\u200E\u200E\u206C\u200E\u206C\u202D\u206D\u202A\u200F\u202E\u206E\u206B\u206E\u206F\u206D\u202E\u200C\u206F\u200D\u200F\u200C\u200D\u200B\u200B\u200C\u206E\u206A\u206B\u200E\u200B\u202B\u206E\u200B\u200B\u200D\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(this)), new GameEventHandler<ManaEventArgs>(this.Notify), (GameEventPriority)0);
				base.HandleBattleEvent<ManaEventArgs>(FlandreScarletNihilityDef.FlandreScarletNihility.\u200D\u200F\u206F\u206D\u202C\u206B\u206A\u200D\u206D\u200B\u202E\u200E\u206C\u202B\u200F\u202B\u202D\u200E\u202B\u202A\u200B\u206D\u202A\u206E\u200D\u206C\u206D\u202A\u200E\u202B\u206F\u206C\u202A\u200E\u206E\u206F\u200C\u206F\u202D\u206D\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(this)), new GameEventHandler<ManaEventArgs>(this.Notify), (GameEventPriority)0);
			}

			private void Notify(ManaEventArgs args)
			{
				if (FlandreScarletNihilityDef.FlandreScarletNihility.\u202B\u202A\u206B\u202C\u206D\u206B\u206E\u206F\u206C\u206D\u206A\u206D\u200C\u200F\u202A\u206B\u202B\u202B\u200F\u200E\u202E\u200B\u200F\u206E\u200B\u202B\u200D\u200D\u202E\u200D\u206F\u206C\u202A\u200B\u206E\u200C\u200E\u202A\u200B\u200D\u202E(this) == CardZone.Hand)
				{
					for (;;)
					{
						IL_0009:
						int num = 1020082546;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)(-(uint)(~(uint)(num2 ^ (~1612112250 - -603549475 * 766390833 * 837179191)))))) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 1U:
								FlandreScarletNihilityDef.FlandreScarletNihility.\u200B\u202B\u200D\u206B\u206C\u206D\u202E\u200D\u202C\u202A\u200E\u202D\u206C\u206F\u206F\u206A\u206E\u202B\u200E\u200B\u206A\u202D\u206B\u200D\u206F\u202E\u200E\u200B\u200E\u206D\u202E\u206A\u200E\u200D\u200C\u206A\u200D\u200D\u206F\u202E\u202E(this);
								num = (int)((num3 * 4109460550U) ^ 1755052447U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			public override int Amount
			{
				get
				{
					if (FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(this) == null)
					{
						goto IL_000B;
					}
					goto IL_00C4;
					int num2;
					for (;;)
					{
						IL_0010:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)(((~num - -525605187) * -1101881345) ^ 1466171449)) % 6U)
						{
						case 0U:
							num2 = (int)(((FlandreScarletNihilityDef.FlandreScarletNihility.\u202B\u202A\u206B\u202C\u206D\u206B\u206E\u206F\u206C\u206D\u206A\u206D\u200C\u200F\u202A\u206B\u202B\u202B\u200F\u200E\u202E\u200B\u200F\u206E\u200B\u202B\u200D\u200D\u202E\u200D\u206F\u206C\u202A\u200B\u206E\u200C\u200E\u202A\u200B\u200D\u202E(this) != CardZone.FollowArea) ? 799692716U : 3286948286U) ^ (num3 * 3694694630U));
							continue;
						case 2U:
							goto IL_000B;
						case 3U:
							goto IL_006E;
						case 4U:
							goto IL_00C4;
						case 5U:
							return 0;
						}
						break;
					}
					goto IL_00E1;
					IL_006E:
					return FlandreScarletNihilityDef.FlandreScarletNihility.\u200D\u202D\u200E\u200C\u200C\u206B\u200E\u200D\u200E\u200B\u206C\u202C\u202A\u200F\u202D\u202B\u206C\u206A\u200F\u200B\u202C\u200F\u202A\u202B\u200C\u200F\u200E\u200C\u206F\u206A\u206E\u206E\u206B\u202D\u200E\u202C\u206A\u200E\u200C\u200D\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.\u202C\u202C\u206E\u206F\u200E\u206F\u202E\u202A\u206B\u206E\u200C\u202E\u200B\u202D\u206A\u202E\u200F\u206D\u202D\u206E\u202A\u206C\u206F\u202B\u206E\u206A\u206A\u200B\u200F\u200E\u200B\u202A\u202C\u200E\u200C\u206C\u202B\u206D\u202E\u200F\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(this)).Amount - FlandreScarletNihilityDef.FlandreScarletNihility.\u202A\u202C\u206A\u206C\u206E\u202E\u206D\u200E\u200C\u202A\u206A\u200B\u206C\u206B\u202A\u206B\u206F\u202D\u206D\u206D\u202B\u200D\u206E\u206C\u206A\u202B\u202E\u202E\u206A\u202D\u200F\u206C\u200E\u202C\u200F\u206C\u200C\u200F\u202E\u206C\u202E(this).Amount, 0) * this.FlandreValue1;
					IL_00E1:
					return FlandreScarletNihilityDef.FlandreScarletNihility.\u202C\u202C\u206E\u206F\u200E\u206F\u202E\u202A\u206B\u206E\u200C\u202E\u200B\u202D\u206A\u202E\u200F\u206D\u202D\u206E\u202A\u206C\u206F\u202B\u206E\u206A\u206A\u200B\u200F\u200E\u200B\u202A\u202C\u200E\u200C\u206C\u202B\u206D\u202E\u200F\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.\u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(this)).Amount * this.FlandreValue1;
					IL_000B:
					num2 = -632843696;
					goto IL_0010;
					IL_00C4:
					num2 = ((FlandreScarletNihilityDef.FlandreScarletNihility.\u202B\u202A\u206B\u202C\u206D\u206B\u206E\u206F\u206C\u206D\u206A\u206D\u200C\u200F\u202A\u206B\u202B\u202B\u200F\u200E\u202E\u200B\u200F\u206E\u200B\u202B\u200D\u200D\u202E\u200D\u206F\u206C\u202A\u200B\u206E\u200C\u200E\u202A\u200B\u200D\u202E(this) != CardZone.PlayArea) ? 1668780687 : 1069893510);
					goto IL_0010;
				}
			}

			public int Amount2
			{
				get
				{
					Unit unit = FlandreScarletNihilityDef.FlandreScarletNihility.\u202B\u200B\u202E\u202C\u206B\u202E\u202C\u200D\u206A\u206F\u202D\u206F\u206C\u202C\u200C\u200D\u206F\u206D\u200B\u200E\u200E\u202A\u200F\u206B\u200B\u202D\u202D\u202D\u200D\u202A\u202C\u202E\u202C\u202D\u206C\u206A\u206F\u206B\u202C\u202B\u202E(this);
					int? num = ((unit != null) ? new int?(FlandreScarletNihilityDef.FlandreScarletNihility.\u202D\u206A\u206B\u206A\u202D\u200B\u206C\u202D\u200D\u206B\u200D\u200C\u202D\u200F\u206A\u200C\u206D\u200B\u200B\u200F\u202B\u202E\u206E\u200F\u202A\u200D\u202D\u202C\u202A\u202E\u200F\u200C\u206E\u200F\u206B\u206C\u200D\u202A\u200C\u202E\u202E(unit)) : null);
					float? num6;
					for (;;)
					{
						IL_0020:
						int num2 = -44532717;
						for (;;)
						{
							int num3 = num2;
							uint num4;
							float? num5;
							float? num7;
							float? num8;
							float num9;
							switch ((num4 = (uint)(~((num3 ^ (-(~899271036) - (--1326464747 + --734493737))) * 1346216103) * 1484563937)) % 8U)
							{
							case 0U:
								goto IL_0020;
							case 1U:
								if (num == null)
								{
									num2 = (int)((num4 * 881532833U) ^ 4122552229U);
									continue;
								}
								num5 = new float?((float)num.GetValueOrDefault());
								goto IL_0115;
							case 3U:
								num5 = num6;
								goto IL_0115;
							case 4U:
								num6 = null;
								num2 = (int)((num4 * 3588955981U) ^ 1380063321U);
								continue;
							case 5U:
								num7 = num6;
								goto IL_00DD;
							case 6U:
								if (num8 == null)
								{
									num2 = (int)((num4 * 3474825968U) ^ 870415689U);
									continue;
								}
								num7 = new float?(num8.GetValueOrDefault() * num9);
								goto IL_00DD;
							case 7U:
								num6 = null;
								num2 = (int)((num4 * 3602166311U) ^ 3429436478U);
								continue;
							}
							goto Block_2;
							IL_00DD:
							num6 = num7;
							num2 = 271999674;
							continue;
							IL_0115:
							num8 = num5;
							num9 = (float)FlandreScarletNihilityDef.FlandreScarletNihility.\u206A\u206E\u206F\u202E\u200C\u200D\u200D\u202B\u200F\u202C\u206E\u200F\u202D\u202A\u206E\u206B\u200C\u206B\u206F\u206A\u202C\u206D\u206B\u206A\u206A\u202C\u206C\u200B\u202C\u202E\u200C\u206C\u200C\u200D\u200C\u206F\u200E\u206A\u206D\u206C\u202E(this) / 100f;
							num2 = -1692350250;
						}
					}
					Block_2:
					return FlandreScarletNihilityDef.FlandreScarletNihility.\u200D\u206F\u200B\u206B\u206F\u200B\u200C\u202C\u202E\u200D\u202B\u206F\u206B\u206D\u202C\u202D\u202D\u206D\u206B\u206C\u202C\u202E\u200C\u200F\u206F\u202D\u206D\u200F\u200F\u206E\u206B\u202B\u206F\u206F\u206E\u202C\u202B\u200B\u202D\u200C\u202E(num6.GetValueOrDefault());
				}
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreScarletNihilityDef.FlandreScarletNihility.<Actions>d__11 <Actions>d__ = new FlandreScarletNihilityDef.FlandreScarletNihility.<Actions>d__11(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__selector = selector;
				return <Actions>d__;
			}

			static int? \u202E\u206C\u206E\u206E\u206D\u200B\u206F\u200B\u202E\u206F\u206D\u202D\u200B\u202B\u206D\u200B\u202B\u202B\u206C\u206C\u202E\u200C\u206F\u206F\u200C\u202A\u206F\u206A\u206B\u202B\u206A\u202C\u200C\u200F\u200C\u202A\u200C\u202C\u202C\u206F\u202E(Card A_0)
			{
				return A_0.UpgradeCounter;
			}

			static BattleController \u202E\u202C\u202B\u206F\u200D\u200F\u202A\u200C\u206C\u202A\u200C\u202C\u206B\u202B\u202C\u200F\u206F\u206C\u206D\u202B\u202D\u202D\u202A\u202B\u202E\u206B\u202D\u202A\u200E\u206C\u202C\u202D\u206E\u206F\u200F\u202C\u206A\u202E\u202D\u206D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<ManaEventArgs> \u206F\u206E\u200D\u206B\u206D\u200E\u200E\u206C\u200E\u206C\u202D\u206D\u202A\u200F\u202E\u206E\u206B\u206E\u206F\u206D\u202E\u200C\u206F\u200D\u200F\u200C\u200D\u200B\u200B\u200C\u206E\u206A\u206B\u200E\u200B\u202B\u206E\u200B\u200B\u200D\u202E(BattleController A_0)
			{
				return A_0.ManaGained;
			}

			static GameEvent<ManaEventArgs> \u200D\u200F\u206F\u206D\u202C\u206B\u206A\u200D\u206D\u200B\u202E\u200E\u206C\u202B\u200F\u202B\u202D\u200E\u202B\u202A\u200B\u206D\u202A\u206E\u200D\u206C\u206D\u202A\u200E\u202B\u206F\u206C\u202A\u200E\u206E\u206F\u200C\u206F\u202D\u206D\u202E(BattleController A_0)
			{
				return A_0.ManaLost;
			}

			static CardZone \u202B\u202A\u206B\u202C\u206D\u206B\u206E\u206F\u206C\u206D\u206A\u206D\u200C\u200F\u202A\u206B\u202B\u202B\u200F\u200E\u202E\u200B\u200F\u206E\u200B\u202B\u200D\u200D\u202E\u200D\u206F\u206C\u202A\u200B\u206E\u200C\u200E\u202A\u200B\u200D\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			static void \u200B\u202B\u200D\u206B\u206C\u206D\u202E\u200D\u202C\u202A\u200E\u202D\u206C\u206F\u206F\u206A\u206E\u202B\u200E\u200B\u206A\u202D\u206B\u200D\u206F\u202E\u200E\u200B\u200E\u206D\u202E\u206A\u200E\u200D\u200C\u206A\u200D\u200D\u206F\u202E\u202E(GameEntity A_0)
			{
				A_0.NotifyChanged();
			}

			static ManaGroup \u202C\u202C\u206E\u206F\u200E\u206F\u202E\u202A\u206B\u206E\u200C\u202E\u200B\u202D\u206A\u202E\u200F\u206D\u202D\u206E\u202A\u206C\u206F\u202B\u206E\u206A\u206A\u200B\u200F\u200E\u200B\u202A\u202C\u200E\u200C\u206C\u202B\u206D\u202E\u200F\u202E(BattleController A_0)
			{
				return A_0.BattleMana;
			}

			static ManaGroup \u202A\u202C\u206A\u206C\u206E\u202E\u206D\u200E\u200C\u202A\u206A\u200B\u206C\u206B\u202A\u206B\u206F\u202D\u206D\u206D\u202B\u200D\u206E\u206C\u206A\u202B\u202E\u202E\u206A\u202D\u200F\u206C\u200E\u202C\u200F\u206C\u200C\u200F\u202E\u206C\u202E(Card A_0)
			{
				return A_0.Cost;
			}

			static int \u200D\u202D\u200E\u200C\u200C\u206B\u200E\u200D\u200E\u200B\u206C\u202C\u202A\u200F\u202D\u202B\u206C\u206A\u200F\u200B\u202C\u200F\u202A\u202B\u200C\u200F\u200E\u200C\u206F\u206A\u206E\u206E\u206B\u202D\u200E\u202C\u206A\u200E\u200C\u200D\u202E(int A_0, int A_1)
			{
				return Math.Max(A_0, A_1);
			}

			static Unit \u202B\u200B\u202E\u202C\u206B\u202E\u202C\u200D\u206A\u206F\u202D\u206F\u206C\u202C\u200C\u200D\u206F\u206D\u200B\u200E\u200E\u202A\u200F\u206B\u200B\u202D\u202D\u202D\u200D\u202A\u202C\u202E\u202C\u202D\u206C\u206A\u206F\u206B\u202C\u202B\u202E(Card A_0)
			{
				return A_0.PendingTarget;
			}

			static int \u202D\u206A\u206B\u206A\u202D\u200B\u206C\u202D\u200D\u206B\u200D\u200C\u202D\u200F\u206A\u200C\u206D\u200B\u200B\u200F\u202B\u202E\u206E\u200F\u202A\u200D\u202D\u202C\u202A\u202E\u200F\u200C\u206E\u200F\u206B\u206C\u200D\u202A\u200C\u202E\u202E(Unit A_0)
			{
				return A_0.MaxHp;
			}

			static int \u206A\u206E\u206F\u202E\u200C\u200D\u200D\u202B\u200F\u202C\u206E\u200F\u202D\u202A\u206E\u206B\u200C\u206B\u206F\u206A\u202C\u206D\u206B\u206A\u206A\u202C\u206C\u200B\u202C\u202E\u200C\u206C\u200C\u200D\u200C\u206F\u200E\u206A\u206D\u206C\u202E(Card A_0)
			{
				return A_0.Value2;
			}

			static int \u200D\u206F\u200B\u206B\u206F\u200B\u200C\u202C\u202E\u200D\u202B\u206F\u206B\u206D\u202C\u202D\u202D\u206D\u206B\u206C\u202C\u202E\u200C\u200F\u206F\u202D\u206D\u200F\u200F\u206E\u206B\u202B\u206F\u206F\u206E\u202C\u202B\u200B\u202D\u200C\u202E(float A_0)
			{
				return A_0.CeilingToInt();
			}

			[HarmonyPatch(typeof(GameRunController), "BaseCardWeight")]
			private class GameRunController_BaseCardWeight_Patch
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				private static void Postfix(GameRunController __instance, ref CardConfig config, ref bool applyFactors, ref float __result)
				{
					if (FlandreScarletNihilityDef.FlandreScarletNihility.GameRunController_BaseCardWeight_Patch.\u202D\u206A\u206C\u200F\u206D\u202C\u200C\u202A\u202D\u206B\u200E\u200D\u206F\u200E\u202A\u202C\u202B\u206B\u202D\u200D\u200D\u206C\u202A\u206D\u206C\u206F\u202B\u200E\u206C\u206E\u206E\u206F\u202C\u206C\u202A\u206F\u206A\u206A\u206C\u200C\u202E(FlandreScarletNihilityDef.FlandreScarletNihility.GameRunController_BaseCardWeight_Patch.\u206C\u200B\u200C\u206C\u206F\u200C\u200F\u206C\u200B\u200D\u202C\u206F\u206D\u206B\u200B\u206C\u206D\u206E\u200C\u202B\u206F\u206E\u202D\u206D\u200C\u200E\u202E\u206E\u206B\u202A\u206C\u200F\u206C\u206D\u206B\u206A\u206A\u202A\u202E(config), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(15478059)))
					{
						for (;;)
						{
							IL_001A:
							int num = -1248095275;
							for (;;)
							{
								int num2 = num;
								uint num3;
								switch ((num3 = (uint)(~(uint)((num2 * -2056420113 + 1576707755 * -848953521) ^ --378929055))) % 3U)
								{
								case 1U:
									__result *= 0.25f;
									num = (int)((num3 * 4122171477U) ^ 2288442204U);
									continue;
								case 2U:
									goto IL_001A;
								}
								goto Block_1;
							}
						}
						Block_1:;
					}
				}

				static string \u206C\u200B\u200C\u206C\u206F\u200C\u200F\u206C\u200B\u200D\u202C\u206F\u206D\u206B\u200B\u206C\u206D\u206E\u200C\u202B\u206F\u206E\u202D\u206D\u200C\u200E\u202E\u206E\u206B\u202A\u206C\u200F\u206C\u206D\u206B\u206A\u206A\u202A\u202E(CardConfig A_0)
				{
					return A_0.Id;
				}

				static bool \u202D\u206A\u206C\u200F\u206D\u202C\u200C\u202A\u202D\u206B\u200E\u200D\u206F\u200E\u202A\u202C\u202B\u206B\u202D\u200D\u200D\u206C\u202A\u206D\u206C\u206F\u202B\u200E\u206C\u206E\u206E\u206F\u202C\u206C\u202A\u206F\u206A\u206A\u206C\u200C\u202E(string A_0, string A_1)
				{
					return A_0 == A_1;
				}
			}
		}
	}
}
