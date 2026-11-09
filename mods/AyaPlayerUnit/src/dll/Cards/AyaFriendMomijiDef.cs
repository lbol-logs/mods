using System;
using System.Collections;
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
	public sealed class AyaFriendMomijiDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904391731);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendMomijiDef.\u200F\u206A\u202C\u206F\u206F\u202C\u200F\u206F\u206E\u202D\u200C\u206D\u200F\u202D\u200F\u200E\u202C\u206B\u206E\u200D\u200F\u202A\u206C\u202A\u200D\u206A\u206F\u206C\u206E\u206D\u202A\u202C\u202E\u200E\u200C\u202E\u206B\u202D\u202D\u202D\u202E(BepinexPlugin.embeddedSource);
			AyaFriendMomijiDef.\u206A\u200E\u206F\u206F\u200F\u206F\u206C\u206D\u200F\u202E\u202E\u202C\u202E\u206D\u206B\u202C\u206F\u206E\u200B\u206F\u202A\u202E\u202C\u202B\u202E\u200B\u206B\u202C\u202A\u206B\u200F\u202B\u206D\u206B\u206E\u206A\u202B\u206E\u206B\u200F\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendMomijiDef.\u200C\u202C\u206C\u206A\u202D\u206C\u202A\u200E\u202A\u200D\u202E\u200C\u202C\u202E\u200E\u206B\u200C\u206C\u206B\u206F\u200C\u206A\u200E\u206E\u206C\u200D\u206F\u202B\u200F\u200F\u200E\u200E\u202C\u206C\u202D\u200B\u206B\u202B\u200D\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendMomijiDef.\u200E\u200E\u200E\u200C\u202E\u206D\u202A\u206B\u206D\u206F\u206B\u206E\u206A\u202B\u200B\u206D\u200E\u202A\u206E\u200F\u206C\u200B\u200D\u206F\u206A\u200C\u202D\u202C\u200E\u206D\u206F\u200E\u202A\u202E\u202C\u202B\u202C\u200C\u202D\u206C\u202E(BepinexPlugin.sequenceTable, AyaFriendMomijiDef.\u202E\u200F\u206E\u202E\u202A\u200C\u206E\u206B\u200C\u206E\u200D\u200D\u200C\u206C\u206F\u200C\u206B\u202B\u206B\u206B\u202C\u202C\u202A\u202E\u206E\u200C\u202B\u206A\u202C\u200C\u206A\u202E\u206B\u200C\u202C\u202B\u200C\u202C\u200C\u202D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-972314505), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-972314505), 0, false, true, false, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Red }, false, new ManaGroup
			{
				Any = 3,
				Red = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 3,
				Red = 1
			}), null, null, null, new int?(10), null, null, null, new int?(10), null, new int?(10), null, null, null, null, null, new int?(10), null, null, new int?(1), new int?(7), new int?(6), null, null, null, null, null, new int?(-4), null, Keyword.None, Keyword.None, false, Keyword.Accuracy | Keyword.Block | Keyword.Scry | Keyword.Expel, Keyword.Accuracy | Keyword.Block | Keyword.Scry | Keyword.Expel, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1063754745), new List<string>());
		}

		static CardImages \u200F\u206A\u202C\u206F\u206F\u202C\u200F\u206F\u206E\u202D\u200C\u206D\u200F\u202D\u200F\u200E\u202C\u206B\u206E\u200D\u200F\u202A\u206C\u202A\u200D\u206A\u206F\u206C\u206E\u206D\u202A\u202C\u202E\u200E\u200C\u202E\u206B\u202D\u202D\u202D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206A\u200E\u206F\u206F\u200F\u206F\u206C\u206D\u200F\u202E\u202E\u202C\u202E\u206D\u206B\u202C\u206F\u206E\u200B\u206F\u202A\u202E\u202C\u202B\u202E\u200B\u206B\u202C\u202A\u206B\u200F\u202B\u206D\u206B\u206E\u206A\u202B\u206E\u206B\u200F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200C\u202C\u206C\u206A\u202D\u206C\u202A\u200E\u202A\u200D\u202E\u200C\u202C\u202E\u200E\u206B\u200C\u206C\u206B\u206F\u200C\u206A\u200E\u206E\u206C\u200D\u206F\u202B\u200F\u200F\u200E\u200E\u202C\u206C\u202D\u200B\u206B\u202B\u200D\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202E\u200F\u206E\u202E\u202A\u200C\u206E\u206B\u200C\u206E\u200D\u200D\u200C\u206C\u206F\u200C\u206B\u202B\u206B\u206B\u202C\u202C\u202A\u202E\u206E\u200C\u202B\u206A\u202C\u200C\u206A\u202E\u206B\u200C\u202C\u202B\u200C\u202C\u200C\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200E\u200E\u200E\u200C\u202E\u206D\u202A\u206B\u206D\u206F\u206B\u206E\u206A\u202B\u200B\u206D\u200E\u202A\u206E\u200F\u206C\u200B\u200D\u206F\u206A\u200C\u202D\u202C\u200E\u206D\u206F\u200E\u202A\u202E\u202C\u202B\u202C\u200C\u202D\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendMomijiDef))]
		public sealed class AyaFriendMomiji : Card
		{
			public FriendCostInfo FriendP2
			{
				get
				{
					return new FriendCostInfo(-2, FriendCostType.Passive);
				}
			}

			public DamageInfo Damage2
			{
				get
				{
					return DamageInfo.Attack((float)(AyaFriendMomijiDef.AyaFriendMomiji.\u200C\u200F\u206D\u202C\u200D\u200D\u206F\u206A\u202E\u206E\u206B\u206D\u200E\u202A\u206A\u202D\u206B\u200B\u206A\u206F\u206F\u206D\u202D\u206C\u200F\u200B\u200D\u206A\u202D\u206F\u206F\u200C\u200D\u206A\u206E\u202D\u206E\u200D\u202C\u200F\u202E(this) + AyaFriendMomijiDef.AyaFriendMomiji.\u200D\u202B\u202E\u206B\u200B\u200F\u206B\u206E\u202C\u206A\u206E\u202D\u206A\u202A\u202E\u206F\u200D\u206C\u206A\u202D\u200F\u206C\u200D\u200C\u200B\u206E\u200D\u206A\u202B\u202B\u200D\u206E\u202A\u202D\u202A\u206C\u202C\u200B\u200C\u202A\u202E(this)), true);
				}
			}

			public int PassiveBarrier
			{
				get
				{
					return AyaFriendMomijiDef.AyaFriendMomiji.\u206F\u206B\u202A\u202B\u202E\u202C\u200C\u202B\u206A\u200F\u202C\u206F\u200C\u200D\u200D\u206B\u202D\u206E\u202B\u202D\u200D\u202E\u202A\u202E\u206B\u206F\u206D\u202B\u200E\u206F\u200C\u202E\u206D\u202A\u206C\u206E\u202E\u202D\u200F\u206A\u202E(this).Shield;
				}
			}

			public static bool Telegnosis { get; set; }

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<StatisticalDamageEventArgs>(AyaFriendMomijiDef.AyaFriendMomiji.\u202A\u206C\u200F\u202C\u206C\u200C\u202E\u202E\u206C\u200F\u202E\u202D\u200D\u206F\u200B\u206D\u206F\u206B\u206B\u206F\u206F\u200D\u200B\u200D\u202D\u200B\u206C\u202D\u206B\u202C\u206B\u206D\u200C\u206A\u206E\u200D\u206B\u202A\u202A\u200E\u202E(AyaFriendMomijiDef.AyaFriendMomiji.\u202B\u202E\u202E\u206D\u202E\u206C\u200D\u202A\u202B\u206A\u206F\u200E\u206E\u206B\u200E\u202D\u200B\u206C\u200E\u206B\u206F\u202B\u200D\u202A\u202E\u200B\u206D\u206E\u206C\u200B\u206C\u200E\u206B\u200E\u200D\u206E\u206B\u202D\u202E\u206F\u202E(AyaFriendMomijiDef.AyaFriendMomiji.\u206A\u206E\u206D\u200B\u206A\u202B\u206B\u206A\u200B\u200E\u206D\u200B\u206C\u200E\u200C\u202C\u202D\u200E\u206F\u206D\u200B\u200B\u206D\u202B\u202C\u200D\u206E\u200C\u206E\u200B\u202E\u202A\u202A\u202C\u206E\u200C\u206A\u200C\u202B\u202D\u202E(this))), new EventSequencedReactor<StatisticalDamageEventArgs>(this.OnPlayerStatisticalTotalDamageDealt));
				base.HandleBattleEvent<DamageEventArgs>(AyaFriendMomijiDef.AyaFriendMomiji.\u200D\u202A\u200D\u206D\u200E\u202D\u200C\u206A\u206D\u206C\u202A\u200C\u200C\u206C\u200D\u206B\u206F\u200F\u202C\u202E\u206D\u200B\u200B\u206E\u202A\u200B\u206C\u202A\u206A\u202D\u200D\u206E\u200E\u206C\u202E\u202C\u200F\u206E\u200F\u206F\u202E(AyaFriendMomijiDef.AyaFriendMomiji.\u202B\u202E\u202E\u206D\u202E\u206C\u200D\u202A\u202B\u206A\u206F\u200E\u206E\u206B\u200E\u202D\u200B\u206C\u200E\u206B\u206F\u202B\u200D\u202A\u202E\u200B\u206D\u206E\u206C\u200B\u206C\u200E\u206B\u200E\u200D\u206E\u206B\u202D\u202E\u206F\u202E(AyaFriendMomijiDef.AyaFriendMomiji.\u206A\u206E\u206D\u200B\u206A\u202B\u206B\u206A\u200B\u200E\u206D\u200B\u206C\u200E\u200C\u202C\u202D\u200E\u206F\u206D\u200B\u200B\u206D\u202B\u202C\u200D\u206E\u200C\u206E\u200B\u202E\u202A\u202A\u202C\u206E\u200C\u206A\u200C\u202B\u202D\u202E(this))), new GameEventHandler<DamageEventArgs>(this.OnPlayerDamageTaking), (GameEventPriority)45);
			}

			private IEnumerable<BattleAction> AttackPassive(IEnumerable<Unit> targets)
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<AttackPassive>d__11 <AttackPassive>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<AttackPassive>d__11(-2);
				<AttackPassive>d__.<>4__this = this;
				<AttackPassive>d__.<>3__targets = targets;
				return <AttackPassive>d__;
			}

			private IEnumerable<BattleAction> ParryPassive(DamageEventArgs args = null)
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<ParryPassive>d__12 <ParryPassive>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<ParryPassive>d__12(-2);
				<ParryPassive>d__.<>4__this = this;
				<ParryPassive>d__.<>3__args = args;
				return <ParryPassive>d__;
			}

			private IEnumerable<BattleAction> OnPlayerStatisticalTotalDamageDealt(StatisticalDamageEventArgs args)
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<OnPlayerStatisticalTotalDamageDealt>d__13 <OnPlayerStatisticalTotalDamageDealt>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<OnPlayerStatisticalTotalDamageDealt>d__13(-2);
				<OnPlayerStatisticalTotalDamageDealt>d__.<>4__this = this;
				<OnPlayerStatisticalTotalDamageDealt>d__.<>3__args = args;
				return <OnPlayerStatisticalTotalDamageDealt>d__;
			}

			private void OnPlayerDamageTaking(DamageEventArgs args)
			{
				if (AyaFriendMomijiDef.AyaFriendMomiji.\u202D\u202A\u200C\u206E\u200F\u206C\u202C\u202B\u202D\u202B\u200F\u206D\u200C\u200D\u206C\u200B\u202B\u200F\u200E\u200F\u206D\u202E\u202D\u202E\u202C\u202C\u206A\u202B\u200E\u200E\u202B\u200C\u206A\u206D\u202C\u202B\u206F\u206F\u206A\u206B\u202E(args) != ActionCause.OnlyCalculate)
				{
					for (;;)
					{
						IL_000D:
						int num = 246971672;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)((~num2 ^ ((854442552 + -1408488359) ^ (787536208 - 570116468)) ^ 13828859) * 536334033)) % 12U)
							{
							case 0U:
							{
								DamageInfo damageInfo = AyaFriendMomijiDef.AyaFriendMomiji.\u206D\u206E\u200E\u200C\u206E\u206A\u206D\u206E\u200E\u206E\u202B\u200D\u200B\u206A\u202E\u202E\u202D\u206D\u200B\u200D\u200E\u202C\u206A\u202C\u206F\u206C\u202E\u200E\u206C\u206D\u202A\u202D\u202C\u206D\u200F\u206E\u202A\u202E\u202C\u206D\u202E(args);
								num = (int)((num3 * 899116408U) ^ 1917910826U);
								continue;
							}
							case 1U:
								if (AyaFriendMomijiDef.AyaFriendMomiji.\u200F\u200F\u206C\u200E\u200C\u206A\u206E\u200D\u206B\u206E\u206C\u200B\u200C\u200B\u200F\u200E\u206C\u206A\u200F\u206B\u200D\u206B\u202B\u206A\u202C\u206F\u202A\u200F\u200B\u202B\u200D\u200D\u200B\u200E\u200D\u202E\u200E\u202B\u206D\u206E\u202E(this))
								{
									num = (int)((num3 * 953950520U) ^ 3133559011U);
									continue;
								}
								return;
							case 2U:
							{
								DamageInfo damageInfo;
								if (!damageInfo.IsGrazed)
								{
									num = (int)((num3 * 2780338707U) ^ 3956055151U);
									continue;
								}
								return;
							}
							case 3U:
							{
								DamageInfo damageInfo;
								if (damageInfo.Damage > 0f)
								{
									num = (int)((num3 * 3914979258U) ^ 1413592168U);
									continue;
								}
								return;
							}
							case 5U:
								if (!AyaFriendMomijiDef.AyaFriendMomiji.\u206D\u206E\u206F\u200E\u206D\u202B\u206A\u206D\u200E\u206D\u202E\u200D\u206D\u200C\u202E\u206C\u206B\u206C\u202D\u200D\u202D\u206D\u200B\u200E\u200B\u206C\u206E\u200F\u206A\u206E\u206B\u202D\u202E\u200E\u206F\u206F\u206D\u200E\u202B\u202C\u202E(AyaFriendMomijiDef.AyaFriendMomiji.\u206A\u206E\u206D\u200B\u206A\u202B\u206B\u206A\u200B\u200E\u206D\u200B\u206C\u200E\u200C\u202C\u202D\u200E\u206F\u206D\u200B\u200B\u206D\u202B\u202C\u200D\u206E\u200C\u206E\u200B\u202E\u202A\u202A\u202C\u206E\u200C\u206A\u200C\u202B\u202D\u202E(this)))
								{
									num = (int)((num3 * 1749440658U) ^ 1013429148U);
									continue;
								}
								return;
							case 6U:
								if (AyaFriendMomijiDef.AyaFriendMomiji.\u202A\u202A\u206F\u206B\u206E\u202D\u202B\u202C\u206E\u206D\u200D\u206A\u200B\u206B\u206E\u200E\u202B\u202B\u200C\u206C\u206B\u200D\u206B\u200C\u202D\u200C\u206F\u202E\u202B\u200F\u202E\u200B\u202C\u206D\u200F\u206A\u202E\u202B\u206A\u206B\u202E(this) >= -this.FriendP2.Cost)
								{
									num = (int)((num3 * 245645314U) ^ 374353101U);
									continue;
								}
								return;
							case 7U:
							{
								DamageInfo damageInfo = AyaFriendMomijiDef.AyaFriendMomiji.\u206D\u206E\u200E\u200C\u206E\u206A\u206D\u206E\u200E\u206E\u202B\u200D\u200B\u206A\u202E\u202E\u202D\u206D\u200B\u200D\u200E\u202C\u206A\u202C\u206F\u206C\u202E\u200E\u206C\u206D\u202A\u202D\u202C\u206D\u200F\u206E\u202A\u202E\u202C\u206D\u202E(args);
								num = (int)((num3 * 322966256U) ^ 2769493951U);
								continue;
							}
							case 8U:
							{
								DamageInfo damageInfo = AyaFriendMomijiDef.AyaFriendMomiji.\u206D\u206E\u200E\u200C\u206E\u206A\u206D\u206E\u200E\u206E\u202B\u200D\u200B\u206A\u202E\u202E\u202D\u206D\u200B\u200D\u200E\u202C\u206A\u202C\u206F\u206C\u202E\u200E\u206C\u206D\u202A\u202D\u202C\u206D\u200F\u206E\u202A\u202E\u202C\u206D\u202E(args);
								num = (int)((num3 * 1761236992U) ^ 2457343804U);
								continue;
							}
							case 9U:
							{
								DamageInfo damageInfo;
								if (damageInfo.DamageType == DamageType.Attack)
								{
									num = (int)((num3 * 2283329706U) ^ 2914887975U);
									continue;
								}
								return;
							}
							case 10U:
								goto IL_000D;
							case 11U:
								if (AyaFriendMomijiDef.AyaFriendMomiji.\u200B\u206A\u206B\u202E\u206A\u200B\u202E\u200C\u206F\u206A\u202C\u202E\u200D\u202E\u202C\u206E\u200F\u202A\u206D\u200D\u202C\u200E\u206D\u202C\u202A\u200F\u206B\u206C\u206D\u200C\u206E\u200F\u206D\u206D\u206C\u206B\u200B\u206C\u206D\u202C\u202E(this) == CardZone.Hand)
								{
									num = (int)((num3 * 2221864267U) ^ 3516670721U);
									continue;
								}
								return;
							}
							goto Block_1;
						}
					}
					Block_1:
					IEnumerator<BattleAction> enumerator = this.ParryPassive(args).GetEnumerator();
					try
					{
						for (;;)
						{
							IL_0240:
							int num4 = (AyaFriendMomijiDef.AyaFriendMomiji.\u206C\u206A\u202A\u200D\u206C\u206A\u206D\u202A\u200D\u202B\u200D\u202B\u206E\u202A\u202B\u200E\u206B\u202B\u200F\u200E\u200D\u202C\u202B\u206B\u206C\u206B\u206D\u200C\u206C\u206B\u200D\u206D\u200D\u200C\u200E\u202E\u206A\u206C\u200E\u206A\u202E(enumerator) ? (-426684909) : (-1299127472));
							for (;;)
							{
								int num2 = num4;
								uint num3;
								switch ((num3 = (uint)((~num2 ^ ((854442552 + -1408488359) ^ (787536208 - 570116468)) ^ 13828859) * 536334033)) % 5U)
								{
								case 0U:
									goto IL_0240;
								case 1U:
								{
									BattleAction battleAction;
									this.React(AyaFriendMomijiDef.AyaFriendMomiji.\u200E\u200D\u206D\u200E\u206B\u206A\u206F\u206C\u206E\u206B\u206E\u200D\u202D\u206D\u206B\u202D\u206F\u200B\u200B\u200E\u202D\u206C\u202C\u202D\u206D\u202A\u200C\u206A\u200E\u202E\u202B\u202E\u202C\u206D\u200B\u202E\u202C\u206F\u206D\u200E\u202E(battleAction));
									num4 = (int)((num3 * 1896684560U) ^ 2895007113U);
									continue;
								}
								case 3U:
									num4 = -426684909;
									continue;
								case 4U:
								{
									BattleAction battleAction = enumerator.Current;
									num4 = 18550970;
									continue;
								}
								}
								goto Block_11;
							}
						}
						Block_11:;
					}
					finally
					{
						if (enumerator != null)
						{
							for (;;)
							{
								IL_0261:
								int num5 = -1782533414;
								for (;;)
								{
									int num2 = num5;
									uint num3;
									switch ((num3 = (uint)((~num2 ^ ((854442552 + -1408488359) ^ (787536208 - 570116468)) ^ 13828859) * 536334033)) % 3U)
									{
									case 0U:
										goto IL_0261;
									case 2U:
										AyaFriendMomijiDef.AyaFriendMomiji.\u200B\u206F\u202C\u206C\u200F\u206B\u206A\u200B\u200F\u200B\u206A\u202C\u206E\u206D\u200E\u202B\u206D\u206C\u200E\u200C\u206B\u206B\u202A\u206C\u206F\u200D\u206B\u206F\u206C\u206D\u200B\u206D\u202E\u206D\u202C\u202E\u206E\u206A\u200F\u202E(enumerator);
										num5 = (int)((num3 * 3418051234U) ^ 3050765988U);
										continue;
									}
									goto Block_14;
								}
							}
							Block_14:;
						}
					}
				}
			}

			public override IEnumerable<BattleAction> OnTurnStartedInHand()
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<OnTurnStartedInHand>d__15 <OnTurnStartedInHand>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<OnTurnStartedInHand>d__15(-2);
				<OnTurnStartedInHand>d__.<>4__this = this;
				return <OnTurnStartedInHand>d__;
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<GetPassiveActions>d__16 <GetPassiveActions>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<GetPassiveActions>d__16(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override IEnumerable<BattleAction> SummonActions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<SummonActions>d__17 <SummonActions>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<SummonActions>d__17(-2);
				<SummonActions>d__.<>4__this = this;
				<SummonActions>d__.<>3__selector = selector;
				<SummonActions>d__.<>3__consumingMana = consumingMana;
				<SummonActions>d__.<>3__precondition = precondition;
				return <SummonActions>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendMomijiDef.AyaFriendMomiji.<Actions>d__18 <Actions>d__ = new AyaFriendMomijiDef.AyaFriendMomiji.<Actions>d__18(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			protected override void OnLeaveBattle()
			{
				if (AyaFriendMomijiDef.AyaFriendMomiji.Telegnosis)
				{
					for (;;)
					{
						IL_000A:
						int num = 113359297;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(~(uint)((~(~-2124720676) - (--1620487333 + 902268259 * -516078612) - num2) * -261900531 * -982212747))) % 4U)
							{
							case 1U:
								AyaFriendMomijiDef.AyaFriendMomiji.Telegnosis = false;
								num = (int)((num3 * 2520850836U) ^ 1268619455U);
								continue;
							case 2U:
								goto IL_000A;
							case 3U:
							{
								GameRunController gameRunController = AyaFriendMomijiDef.AyaFriendMomiji.\u206C\u200C\u202D\u200B\u206E\u202B\u200C\u202D\u206A\u202C\u200C\u206C\u200E\u200F\u200C\u202E\u202D\u200E\u206F\u206F\u200B\u202B\u206C\u202A\u206B\u202A\u202A\u206D\u200D\u202D\u202D\u206A\u202C\u200E\u200C\u200F\u202B\u200C\u206F\u206E\u202E(this);
								AyaFriendMomijiDef.AyaFriendMomiji.\u206F\u200C\u202B\u200B\u206B\u200E\u202B\u202A\u202E\u206F\u206F\u200D\u206B\u202C\u200C\u202E\u200C\u202C\u206F\u200C\u206E\u200D\u200D\u202A\u202C\u206A\u202C\u202E\u206A\u202E\u206B\u200F\u200E\u206A\u206F\u206D\u202C\u206E\u206D\u200F\u202E(gameRunController, AyaFriendMomijiDef.AyaFriendMomiji.\u206B\u206F\u200B\u202B\u202E\u206A\u202C\u202B\u202D\u200F\u200D\u200F\u200E\u206D\u206D\u200C\u202D\u202E\u202E\u202B\u206E\u206F\u200E\u200F\u200D\u206D\u202B\u200E\u200E\u202B\u202D\u200C\u200F\u200C\u202A\u200B\u206D\u206D\u200B\u206C\u202E(gameRunController) - 1);
								num = (int)((num3 * 3445476512U) ^ 2007528916U);
								continue;
							}
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			static int \u200C\u200F\u206D\u202C\u200D\u200D\u206F\u206A\u202E\u206E\u206B\u206D\u200E\u202A\u206A\u202D\u206B\u200B\u206A\u206F\u206F\u206D\u202D\u206C\u200F\u200B\u200D\u206A\u202D\u206F\u206F\u200C\u200D\u206A\u206E\u202D\u206E\u200D\u202C\u200F\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static int \u200D\u202B\u202E\u206B\u200B\u200F\u206B\u206E\u202C\u206A\u206E\u202D\u206A\u202A\u202E\u206F\u200D\u206C\u206A\u202D\u200F\u206C\u200D\u200C\u200B\u206E\u200D\u206A\u202B\u202B\u200D\u206E\u202A\u202D\u202A\u206C\u202C\u200B\u200C\u202A\u202E(Card A_0)
			{
				return A_0.ConfigDamage;
			}

			static ShieldInfo \u206F\u206B\u202A\u202B\u202E\u202C\u200C\u202B\u206A\u200F\u202C\u206F\u200C\u200D\u200D\u206B\u202D\u206E\u202B\u202D\u200D\u202E\u202A\u202E\u206B\u206F\u206D\u202B\u200E\u206F\u200C\u202E\u206D\u202A\u206C\u206E\u202E\u202D\u200F\u206A\u202E(Card A_0)
			{
				return A_0.Shield;
			}

			static BattleController \u206A\u206E\u206D\u200B\u206A\u202B\u206B\u206A\u200B\u200E\u206D\u200B\u206C\u200E\u200C\u202C\u202D\u200E\u206F\u206D\u200B\u200B\u206D\u202B\u202C\u200D\u206E\u200C\u206E\u200B\u202E\u202A\u202A\u202C\u206E\u200C\u206A\u200C\u202B\u202D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static PlayerUnit \u202B\u202E\u202E\u206D\u202E\u206C\u200D\u202A\u202B\u206A\u206F\u200E\u206E\u206B\u200E\u202D\u200B\u206C\u200E\u206B\u206F\u202B\u200D\u202A\u202E\u200B\u206D\u206E\u206C\u200B\u206C\u200E\u206B\u200E\u200D\u206E\u206B\u202D\u202E\u206F\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<StatisticalDamageEventArgs> \u202A\u206C\u200F\u202C\u206C\u200C\u202E\u202E\u206C\u200F\u202E\u202D\u200D\u206F\u200B\u206D\u206F\u206B\u206B\u206F\u206F\u200D\u200B\u200D\u202D\u200B\u206C\u202D\u206B\u202C\u206B\u206D\u200C\u206A\u206E\u200D\u206B\u202A\u202A\u200E\u202E(Unit A_0)
			{
				return A_0.StatisticalTotalDamageDealt;
			}

			static GameEvent<DamageEventArgs> \u200D\u202A\u200D\u206D\u200E\u202D\u200C\u206A\u206D\u206C\u202A\u200C\u200C\u206C\u200D\u206B\u206F\u200F\u202C\u202E\u206D\u200B\u200B\u206E\u202A\u200B\u206C\u202A\u206A\u202D\u200D\u206E\u200E\u206C\u202E\u202C\u200F\u206E\u200F\u206F\u202E(Unit A_0)
			{
				return A_0.DamageTaking;
			}

			static ActionCause \u202D\u202A\u200C\u206E\u200F\u206C\u202C\u202B\u202D\u202B\u200F\u206D\u200C\u200D\u206C\u200B\u202B\u200F\u200E\u200F\u206D\u202E\u202D\u202E\u202C\u202C\u206A\u202B\u200E\u200E\u202B\u200C\u206A\u206D\u202C\u202B\u206F\u206F\u206A\u206B\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			static bool \u206D\u206E\u206F\u200E\u206D\u202B\u206A\u206D\u200E\u206D\u202E\u200D\u206D\u200C\u202E\u206C\u206B\u206C\u202D\u200D\u202D\u206D\u200B\u200E\u200B\u206C\u206E\u200F\u206A\u206E\u206B\u202D\u202E\u200E\u206F\u206F\u206D\u200E\u202B\u202C\u202E(BattleController A_0)
			{
				return A_0.BattleShouldEnd;
			}

			static CardZone \u200B\u206A\u206B\u202E\u206A\u200B\u202E\u200C\u206F\u206A\u202C\u202E\u200D\u202E\u202C\u206E\u200F\u202A\u206D\u200D\u202C\u200E\u206D\u202C\u202A\u200F\u206B\u206C\u206D\u200C\u206E\u200F\u206D\u206D\u206C\u206B\u200B\u206C\u206D\u202C\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			static bool \u200F\u200F\u206C\u200E\u200C\u206A\u206E\u200D\u206B\u206E\u206C\u200B\u200C\u200B\u200F\u200E\u206C\u206A\u200F\u206B\u200D\u206B\u202B\u206A\u202C\u206F\u202A\u200F\u200B\u202B\u200D\u200D\u200B\u200E\u200D\u202E\u200E\u202B\u206D\u206E\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static int \u202A\u202A\u206F\u206B\u206E\u202D\u202B\u202C\u206E\u206D\u200D\u206A\u200B\u206B\u206E\u200E\u202B\u202B\u200C\u206C\u206B\u200D\u206B\u200C\u202D\u200C\u206F\u202E\u202B\u200F\u202E\u200B\u202C\u206D\u200F\u206A\u202E\u202B\u206A\u206B\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static DamageInfo \u206D\u206E\u200E\u200C\u206E\u206A\u206D\u206E\u200E\u206E\u202B\u200D\u200B\u206A\u202E\u202E\u202D\u206D\u200B\u200D\u200E\u202C\u206A\u202C\u206F\u206C\u202E\u200E\u206C\u206D\u202A\u202D\u202C\u206D\u200F\u206E\u202A\u202E\u202C\u206D\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static Reactor \u200E\u200D\u206D\u200E\u206B\u206A\u206F\u206C\u206E\u206B\u206E\u200D\u202D\u206D\u206B\u202D\u206F\u200B\u200B\u200E\u202D\u206C\u202C\u202D\u206D\u202A\u200C\u206A\u200E\u202E\u202B\u202E\u202C\u206D\u200B\u202E\u202C\u206F\u206D\u200E\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static bool \u206C\u206A\u202A\u200D\u206C\u206A\u206D\u202A\u200D\u202B\u200D\u202B\u206E\u202A\u202B\u200E\u206B\u202B\u200F\u200E\u200D\u202C\u202B\u206B\u206C\u206B\u206D\u200C\u206C\u206B\u200D\u206D\u200D\u200C\u200E\u202E\u206A\u206C\u200E\u206A\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200B\u206F\u202C\u206C\u200F\u206B\u206A\u200B\u200F\u200B\u206A\u202C\u206E\u206D\u200E\u202B\u206D\u206C\u200E\u200C\u206B\u206B\u202A\u206C\u206F\u200D\u206B\u206F\u206C\u206D\u200B\u206D\u202E\u206D\u202C\u202E\u206E\u206A\u200F\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameRunController \u206C\u200C\u202D\u200B\u206E\u202B\u200C\u202D\u206A\u202C\u200C\u206C\u200E\u200F\u200C\u202E\u202D\u200E\u206F\u206F\u200B\u202B\u206C\u202A\u206B\u202A\u202A\u206D\u200D\u202D\u202D\u206A\u202C\u200E\u200C\u200F\u202B\u200C\u206F\u206E\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static int \u206B\u206F\u200B\u202B\u202E\u206A\u202C\u202B\u202D\u200F\u200D\u200F\u200E\u206D\u206D\u200C\u202D\u202E\u202E\u202B\u206E\u206F\u200E\u200F\u200D\u206D\u202B\u200E\u200E\u202B\u202D\u200C\u200F\u200C\u202A\u200B\u206D\u206D\u200B\u206C\u202E(GameRunController A_0)
			{
				return A_0.CanViewDrawZoneActualOrder;
			}

			static void \u206F\u200C\u202B\u200B\u206B\u200E\u202B\u202A\u202E\u206F\u206F\u200D\u206B\u202C\u200C\u202E\u200C\u202C\u206F\u200C\u206E\u200D\u200D\u202A\u202C\u206A\u202C\u202E\u206A\u202E\u206B\u200F\u200E\u206A\u206F\u206D\u202C\u206E\u206D\u200F\u202E(GameRunController A_0, int A_1)
			{
				A_0.CanViewDrawZoneActualOrder = A_1;
			}
		}
	}
}
