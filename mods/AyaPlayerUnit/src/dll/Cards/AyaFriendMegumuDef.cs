using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LBoL.Base;
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
	public sealed class AyaFriendMegumuDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1057176709);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendMegumuDef.\u202C\u206E\u206B\u200F\u206C\u206E\u206E\u200C\u206C\u202A\u200E\u200C\u200E\u206F\u200F\u202A\u206F\u206B\u200D\u202A\u206B\u206E\u206E\u202B\u206B\u202B\u202E\u202D\u200D\u206F\u202A\u206A\u200E\u202B\u202E\u202E\u202E\u202B\u206D\u202E(BepinexPlugin.embeddedSource);
			AyaFriendMegumuDef.\u202A\u200D\u202E\u206A\u206C\u206D\u200C\u200D\u206F\u206F\u202B\u206D\u202D\u206F\u206C\u200B\u200E\u206D\u200E\u202C\u200D\u202B\u200D\u200E\u202A\u206A\u200C\u200F\u206A\u202B\u200D\u206C\u206B\u202D\u206E\u202C\u206C\u202D\u202E\u202E\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2088778032), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendMegumuDef.\u206E\u202D\u206F\u200C\u200F\u206A\u206F\u202E\u200F\u206A\u202E\u206F\u206E\u202D\u206A\u202B\u202D\u200C\u202B\u206B\u200F\u200E\u202D\u200E\u202B\u200F\u200D\u206A\u202A\u202D\u202C\u206E\u200D\u202A\u202B\u206D\u202E\u200F\u200B\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendMegumuDef.\u200C\u202C\u200E\u200C\u206F\u200E\u206F\u206B\u200D\u202A\u206C\u206A\u206A\u200F\u200F\u200E\u206D\u206B\u200D\u202D\u200E\u206F\u206C\u202D\u202B\u200D\u206E\u202B\u206B\u206B\u202A\u202B\u202B\u206D\u206D\u206C\u206A\u206D\u206C\u200E\u202E(BepinexPlugin.sequenceTable, AyaFriendMegumuDef.\u206B\u200E\u206A\u200F\u200D\u206C\u200D\u206A\u202C\u206A\u200E\u202C\u206F\u206D\u206F\u200F\u200C\u200E\u202A\u200D\u206D\u202D\u206F\u202C\u202A\u202D\u200F\u200D\u206E\u206A\u202D\u200F\u202C\u206C\u206C\u206B\u202A\u202C\u206B\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1186339381), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1332448159), 0, false, true, false, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Blue }, false, new ManaGroup
			{
				Any = 3,
				Blue = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 3,
				Blue = 1
			}), null, null, null, new int?(32), null, null, null, null, null, new int?(2), null, new int?(1), new int?(2), new ManaGroup?(new ManaGroup
			{
				Colorless = 1
			}), null, null, null, null, new int?(1), null, new int?(1), null, new int?(2), new int?(4), null, null, new int?(-9), null, Keyword.None, Keyword.None, false, Keyword.Misfortune | Keyword.Accuracy | Keyword.Philosophy | Keyword.Exile, Keyword.Misfortune | Keyword.Accuracy | Keyword.Philosophy | Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(125072358), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-645640400), new List<string>());
		}

		static CardImages \u202C\u206E\u206B\u200F\u206C\u206E\u206E\u200C\u206C\u202A\u200E\u200C\u200E\u206F\u200F\u202A\u206F\u206B\u200D\u202A\u206B\u206E\u206E\u202B\u206B\u202B\u202E\u202D\u200D\u206F\u202A\u206A\u200E\u202B\u202E\u202E\u202E\u202B\u206D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202A\u200D\u202E\u206A\u206C\u206D\u200C\u200D\u206F\u206F\u202B\u206D\u202D\u206F\u206C\u200B\u200E\u206D\u200E\u202C\u200D\u202B\u200D\u200E\u202A\u206A\u200C\u200F\u206A\u202B\u200D\u206C\u206B\u202D\u206E\u202C\u206C\u202D\u202E\u202E\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u202D\u206F\u200C\u200F\u206A\u206F\u202E\u200F\u206A\u202E\u206F\u206E\u202D\u206A\u202B\u202D\u200C\u202B\u206B\u200F\u200E\u202D\u200E\u202B\u200F\u200D\u206A\u202A\u202D\u202C\u206E\u200D\u202A\u202B\u206D\u202E\u200F\u200B\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u200E\u206A\u200F\u200D\u206C\u200D\u206A\u202C\u206A\u200E\u202C\u206F\u206D\u206F\u200F\u200C\u200E\u202A\u200D\u206D\u202D\u206F\u202C\u202A\u202D\u200F\u200D\u206E\u206A\u202D\u200F\u202C\u206C\u206C\u206B\u202A\u202C\u206B\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u202C\u200E\u200C\u206F\u200E\u206F\u206B\u200D\u202A\u206C\u206A\u206A\u200F\u200F\u200E\u206D\u206B\u200D\u202D\u200E\u206F\u206C\u202D\u202B\u200D\u206E\u202B\u206B\u206B\u202A\u202B\u202B\u206D\u206D\u206C\u206A\u206D\u206C\u200E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendMegumuDef))]
		public sealed class AyaFriendMegumu : Card
		{
			public DamageInfo Damage2
			{
				get
				{
					return DamageInfo.Attack((float)AyaFriendMegumuDef.AyaFriendMegumu.\u202A\u202E\u202B\u206B\u200E\u200E\u202D\u202B\u206D\u200F\u206D\u206D\u206B\u206C\u206A\u202B\u206E\u206D\u206C\u200E\u202C\u202C\u202C\u206A\u206A\u200E\u202E\u206C\u200B\u202A\u206D\u200C\u200E\u206A\u206F\u202D\u202C\u202E\u206F\u200C\u202E(this), true);
				}
			}

			public ManaGroup Mana2
			{
				get
				{
					if (!AyaFriendMegumuDef.AyaFriendMegumu.\u202A\u200C\u200D\u200E\u206B\u202C\u200C\u206A\u200F\u202D\u202D\u200B\u200C\u200D\u200E\u202C\u202B\u200D\u206E\u202A\u200B\u202C\u206C\u206B\u206E\u202D\u202B\u206E\u202B\u206D\u200F\u202A\u206B\u200F\u206F\u206D\u200B\u200B\u200C\u202A\u202E(this))
					{
						goto IL_0008;
					}
					goto IL_0046;
					int num2;
					ManaGroup manaGroup;
					for (;;)
					{
						IL_000D:
						int num = num2;
						uint num3;
						switch ((num3 = (uint)((~num * -51428827) ^ ~-401810296 ^ -292014350)) % 6U)
						{
						case 0U:
							manaGroup.Colorless = 2;
							num2 = (int)((num3 * 3150401575U) ^ 964378103U);
							continue;
						case 2U:
							goto IL_0046;
						case 3U:
							manaGroup = default(ManaGroup);
							manaGroup.Colorless = 1;
							num2 = (int)((num3 * 996167013U) ^ 3625986028U);
							continue;
						case 4U:
							goto IL_0008;
						case 5U:
							return manaGroup;
						}
						break;
					}
					return manaGroup;
					IL_0008:
					num2 = 2139387861;
					goto IL_000D;
					IL_0046:
					manaGroup = default(ManaGroup);
					num2 = 2013665270;
					goto IL_000D;
				}
			}

			public ManaGroup Mana3
			{
				get
				{
					return new ManaGroup
					{
						Philosophy = 1
					};
				}
			}

			public int Value3
			{
				get
				{
					return 1;
				}
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<CardEventArgs>(AyaFriendMegumuDef.AyaFriendMegumu.\u202A\u202C\u202D\u200C\u206B\u200E\u202B\u200D\u202E\u206A\u206B\u200E\u200F\u202A\u200C\u200E\u200C\u202E\u202A\u200D\u200B\u206D\u206B\u206B\u202C\u200D\u206A\u202C\u202E\u202B\u206E\u202E\u206C\u206E\u206F\u206D\u206F\u202D\u206C\u206F\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u200D\u206F\u206B\u206A\u206B\u202B\u206A\u206D\u200E\u206F\u202E\u206D\u206E\u206F\u202A\u200F\u202B\u200D\u206F\u200D\u202E\u206F\u202D\u206F\u206F\u202B\u206F\u202D\u202D\u202D\u202E\u206F\u200E\u202B\u200E\u200D\u200E\u200F\u202C\u200C\u202E(this)), new EventSequencedReactor<CardEventArgs>(this.OnCardExiled));
				base.ReactBattleEvent<UnitEventArgs>(AyaFriendMegumuDef.AyaFriendMegumu.\u202B\u206F\u202C\u200C\u206F\u202E\u206A\u206C\u206C\u202B\u202E\u202D\u206D\u202D\u206C\u206C\u200D\u202C\u200E\u206E\u200E\u200C\u200B\u206C\u200C\u206A\u206F\u206B\u200F\u200C\u202C\u202D\u206C\u202B\u206D\u206A\u202B\u202A\u200D\u202D\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u206F\u200F\u202B\u206A\u200F\u202B\u200F\u206C\u206B\u206E\u200F\u206C\u202B\u200D\u202B\u206F\u200E\u206F\u202B\u206B\u206E\u200E\u206F\u202D\u200E\u206C\u206E\u206F\u200B\u202C\u206C\u202E\u206A\u202C\u202A\u206E\u200B\u200D\u202A\u202C\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u200D\u206F\u206B\u206A\u206B\u202B\u206A\u206D\u200E\u206F\u202E\u206D\u206E\u206F\u202A\u200F\u202B\u200D\u206F\u200D\u202E\u206F\u202D\u206F\u206F\u202B\u206F\u202D\u202D\u202D\u202E\u206F\u200E\u202B\u200E\u200D\u200E\u200F\u202C\u200C\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarted));
			}

			private IEnumerable<BattleAction> OnCardExiled(CardEventArgs args)
			{
				if (AyaFriendMegumuDef.AyaFriendMegumu.\u200F\u202B\u206A\u206F\u200D\u202E\u202A\u206A\u200B\u206B\u202A\u206A\u200F\u206B\u202B\u202C\u200D\u206B\u200B\u200D\u200E\u200B\u200E\u200E\u206B\u206E\u200D\u206A\u200D\u206F\u206E\u200D\u200D\u202D\u206A\u200E\u206D\u206E\u200E\u202B\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u202B\u206F\u200F\u206D\u202E\u202D\u206C\u206F\u200F\u200D\u202A\u206A\u206F\u206A\u202C\u206C\u206A\u202B\u202E\u202A\u202B\u206E\u200F\u200C\u206E\u200C\u202E\u200D\u200C\u206C\u206F\u206B\u200B\u200D\u206E\u200E\u206D\u200E\u206A\u200E\u202E(args)) != CardType.Status)
				{
					goto IL_0011;
				}
				goto IL_0118;
				int num2;
				for (;;)
				{
					IL_0016:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(-(~num + ((294476746 - 1054678279) ^ (1301312194 ^ 388056757))) ^ 1224781187)) % 8U)
					{
					case 1U:
						num2 = (int)((AyaFriendMegumuDef.AyaFriendMegumu.\u206C\u206D\u200E\u202B\u202A\u202E\u206F\u200B\u200C\u202A\u202A\u206A\u202C\u200B\u206A\u206C\u202B\u206E\u202E\u200C\u202D\u200E\u200D\u200E\u206E\u200D\u202A\u200D\u206D\u206A\u206B\u202E\u200B\u202A\u206B\u202B\u206E\u206B\u200D\u202D\u202E(this) ? 1838222389U : 2984778593U) ^ (num3 * 2503382423U));
						continue;
					case 2U:
						num2 = (int)(((AyaFriendMegumuDef.AyaFriendMegumu.\u200F\u202B\u206A\u206F\u200D\u202E\u202A\u206A\u200B\u206B\u202A\u206A\u200F\u206B\u202B\u202C\u200D\u206B\u200B\u200D\u200E\u200B\u200E\u200E\u206B\u206E\u200D\u206A\u200D\u206F\u206E\u200D\u200D\u202D\u206A\u200E\u206D\u206E\u200E\u202B\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u202B\u206F\u200F\u206D\u202E\u202D\u206C\u206F\u200F\u200D\u202A\u206A\u206F\u206A\u202C\u206C\u206A\u202B\u202E\u202A\u202B\u206E\u200F\u200C\u206E\u200C\u202E\u200D\u200C\u206C\u206F\u206B\u200B\u200D\u206E\u200E\u206D\u200E\u206A\u200E\u202E(args)) == CardType.Misfortune) ? 1406345333U : 2846760018U) ^ (num3 * 2545640946U));
						continue;
					case 3U:
						goto IL_00DB;
					case 4U:
						num2 = (int)(((AyaFriendMegumuDef.AyaFriendMegumu.\u200B\u206D\u202B\u200C\u206D\u200F\u200C\u202C\u202D\u202E\u202A\u200C\u206C\u202C\u202E\u206C\u200B\u206E\u206C\u202B\u200D\u200E\u200D\u200E\u200C\u202C\u206E\u206F\u200F\u200B\u200E\u200B\u206A\u202B\u206A\u200B\u202E\u206F\u202E\u206F\u202E(this) == CardZone.Hand) ? 298157024U : 3511770990U) ^ (num3 * 3806769706U));
						continue;
					case 5U:
						goto IL_0118;
					case 6U:
						num2 = (int)(((!AyaFriendMegumuDef.AyaFriendMegumu.\u200E\u206A\u206D\u202E\u206A\u202D\u206C\u200B\u206E\u206B\u200D\u200B\u200F\u202E\u200E\u206C\u206B\u202B\u202E\u200D\u206B\u206B\u200B\u200E\u206C\u202B\u202C\u206B\u200B\u202D\u200E\u200B\u202C\u200F\u206F\u202D\u202B\u206C\u202B\u202A\u202E(AyaFriendMegumuDef.AyaFriendMegumu.\u200D\u206F\u206B\u206A\u206B\u202B\u206A\u206D\u200E\u206F\u202E\u206D\u206E\u206F\u202A\u200F\u202B\u200D\u206F\u200D\u202E\u206F\u202D\u206F\u206F\u202B\u206F\u202D\u202D\u202D\u202E\u206F\u200E\u202B\u200E\u200D\u200E\u200F\u202C\u200C\u202E(this))) ? 1024336289U : 3533956244U) ^ (num3 * 772887227U));
						continue;
					case 7U:
						goto IL_0011;
					}
					break;
				}
				goto IL_0129;
				IL_00DB:
				return AyaFriendMegumuDef.AyaFriendMegumu.\u200B\u200D\u202A\u202D\u206F\u200B\u206C\u206C\u206A\u200C\u200F\u200E\u202A\u200E\u200B\u206C\u202A\u200E\u202B\u200F\u206C\u202D\u206C\u206B\u200D\u200F\u206F\u200C\u202A\u206C\u202C\u206C\u206A\u200E\u206D\u202D\u202E\u202E\u206F\u200F\u202E(this);
				IL_0129:
				return null;
				IL_0011:
				num2 = -357675100;
				goto IL_0016;
				IL_0118:
				this.Exiled = true;
				num2 = -356720427;
				goto IL_0016;
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarted(UnitEventArgs arg)
			{
				AyaFriendMegumuDef.AyaFriendMegumu.<OnPlayerTurnStarted>d__11 <OnPlayerTurnStarted>d__ = new AyaFriendMegumuDef.AyaFriendMegumu.<OnPlayerTurnStarted>d__11(-2);
				<OnPlayerTurnStarted>d__.<>4__this = this;
				return <OnPlayerTurnStarted>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaFriendMegumuDef.AyaFriendMegumu.<GetPassiveActions>d__12 <GetPassiveActions>d__ = new AyaFriendMegumuDef.AyaFriendMegumu.<GetPassiveActions>d__12(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendMegumuDef.AyaFriendMegumu.<Actions>d__13 <Actions>d__ = new AyaFriendMegumuDef.AyaFriendMegumu.<Actions>d__13(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int \u202A\u202E\u202B\u206B\u200E\u200E\u202D\u202B\u206D\u200F\u206D\u206D\u206B\u206C\u206A\u202B\u206E\u206D\u206C\u200E\u202C\u202C\u202C\u206A\u206A\u200E\u202E\u206C\u200B\u202A\u206D\u200C\u200E\u206A\u206F\u202D\u202C\u202E\u206F\u200C\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static bool \u202A\u200C\u200D\u200E\u206B\u202C\u200C\u206A\u200F\u202D\u202D\u200B\u200C\u200D\u200E\u202C\u202B\u200D\u206E\u202A\u200B\u202C\u206C\u206B\u206E\u202D\u202B\u206E\u202B\u206D\u200F\u202A\u206B\u200F\u206F\u206D\u200B\u200B\u200C\u202A\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static BattleController \u200D\u206F\u206B\u206A\u206B\u202B\u206A\u206D\u200E\u206F\u202E\u206D\u206E\u206F\u202A\u200F\u202B\u200D\u206F\u200D\u202E\u206F\u202D\u206F\u206F\u202B\u206F\u202D\u202D\u202D\u202E\u206F\u200E\u202B\u200E\u200D\u200E\u200F\u202C\u200C\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static GameEvent<CardEventArgs> \u202A\u202C\u202D\u200C\u206B\u200E\u202B\u200D\u202E\u206A\u206B\u200E\u200F\u202A\u200C\u200E\u200C\u202E\u202A\u200D\u200B\u206D\u206B\u206B\u202C\u200D\u206A\u202C\u202E\u202B\u206E\u202E\u206C\u206E\u206F\u206D\u206F\u202D\u206C\u206F\u202E(BattleController A_0)
			{
				return A_0.CardExiled;
			}

			static PlayerUnit \u206F\u200F\u202B\u206A\u200F\u202B\u200F\u206C\u206B\u206E\u200F\u206C\u202B\u200D\u202B\u206F\u200E\u206F\u202B\u206B\u206E\u200E\u206F\u202D\u200E\u206C\u206E\u206F\u200B\u202C\u206C\u202E\u206A\u202C\u202A\u206E\u200B\u200D\u202A\u202C\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202B\u206F\u202C\u200C\u206F\u202E\u206A\u206C\u206C\u202B\u202E\u202D\u206D\u202D\u206C\u206C\u200D\u202C\u200E\u206E\u200E\u200C\u200B\u206C\u200C\u206A\u206F\u206B\u200F\u200C\u202C\u202D\u206C\u202B\u206D\u206A\u202B\u202A\u200D\u202D\u202E(Unit A_0)
			{
				return A_0.TurnStarted;
			}

			static Card \u202B\u206F\u200F\u206D\u202E\u202D\u206C\u206F\u200F\u200D\u202A\u206A\u206F\u206A\u202C\u206C\u206A\u202B\u202E\u202A\u202B\u206E\u200F\u200C\u206E\u200C\u202E\u200D\u200C\u206C\u206F\u206B\u200B\u200D\u206E\u200E\u206D\u200E\u206A\u200E\u202E(CardEventArgs A_0)
			{
				return A_0.Card;
			}

			static CardType \u200F\u202B\u206A\u206F\u200D\u202E\u202A\u206A\u200B\u206B\u202A\u206A\u200F\u206B\u202B\u202C\u200D\u206B\u200B\u200D\u200E\u200B\u200E\u200E\u206B\u206E\u200D\u206A\u200D\u206F\u206E\u200D\u200D\u202D\u206A\u200E\u206D\u206E\u200E\u202B\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static bool \u206C\u206D\u200E\u202B\u202A\u202E\u206F\u200B\u200C\u202A\u202A\u206A\u202C\u200B\u206A\u206C\u202B\u206E\u202E\u200C\u202D\u200E\u200D\u200E\u206E\u200D\u202A\u200D\u206D\u206A\u206B\u202E\u200B\u202A\u206B\u202B\u206E\u206B\u200D\u202D\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static CardZone \u200B\u206D\u202B\u200C\u206D\u200F\u200C\u202C\u202D\u202E\u202A\u200C\u206C\u202C\u202E\u206C\u200B\u206E\u206C\u202B\u200D\u200E\u200D\u200E\u200C\u202C\u206E\u206F\u200F\u200B\u200E\u200B\u206A\u202B\u206A\u200B\u202E\u206F\u202E\u206F\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			static bool \u200E\u206A\u206D\u202E\u206A\u202D\u206C\u200B\u206E\u206B\u200D\u200B\u200F\u202E\u200E\u206C\u206B\u202B\u202E\u200D\u206B\u206B\u200B\u200E\u206C\u202B\u202C\u206B\u200B\u202D\u200E\u200B\u202C\u200F\u206F\u202D\u202B\u206C\u202B\u202A\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static IEnumerable<BattleAction> \u200B\u200D\u202A\u202D\u206F\u200B\u206C\u206C\u206A\u200C\u200F\u200E\u202A\u200E\u200B\u206C\u202A\u200E\u202B\u200F\u206C\u202D\u206C\u206B\u200D\u200F\u206F\u200C\u202A\u206C\u202C\u206C\u206A\u200E\u206D\u202D\u202E\u202E\u206F\u200F\u202E(Card A_0)
			{
				return A_0.GetPassiveActions();
			}

			private bool Exiled;
		}
	}
}
