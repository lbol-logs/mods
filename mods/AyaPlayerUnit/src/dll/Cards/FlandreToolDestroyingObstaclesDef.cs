using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using LBoL.Base;
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
	public sealed class FlandreToolDestroyingObstaclesDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1562576107);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = FlandreToolDestroyingObstaclesDef.\u200C\u206B\u200E\u206A\u206F\u200E\u206B\u206A\u206F\u206C\u206F\u206A\u200B\u200C\u206F\u200B\u206E\u202B\u206C\u202D\u206C\u202A\u206F\u206F\u206D\u202C\u200E\u202B\u200D\u200E\u202C\u206D\u206B\u206F\u202B\u202C\u206F\u206B\u200E\u206C\u202E(BepinexPlugin.embeddedSource);
			FlandreToolDestroyingObstaclesDef.\u200C\u200D\u206E\u202A\u202E\u200E\u202B\u202A\u206F\u202C\u202B\u202B\u200E\u202A\u200E\u200E\u206A\u206D\u200F\u202B\u206C\u206A\u202B\u202A\u202E\u202E\u206D\u202D\u206B\u202C\u206F\u200D\u200C\u206B\u202C\u200E\u200E\u202A\u200D\u200F\u202E(cardImages, this, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1852481799), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return FlandreToolDestroyingObstaclesDef.\u202B\u200D\u206E\u200C\u206C\u200F\u200B\u206C\u202B\u200C\u202B\u202E\u202D\u202B\u200F\u200E\u200F\u202E\u200C\u200B\u200C\u200D\u202B\u206A\u202E\u206C\u200C\u200E\u202E\u206C\u200B\u206D\u206C\u206D\u206B\u200D\u202C\u202A\u200E\u206F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(FlandreToolDestroyingObstaclesDef.\u200D\u200F\u202A\u202E\u206D\u202D\u200E\u206D\u202D\u200B\u200D\u200B\u206F\u200C\u206A\u206B\u206B\u206D\u206A\u206D\u202B\u206F\u206B\u206C\u200C\u202A\u200D\u202C\u200E\u202D\u202C\u202C\u202E\u200C\u200C\u202D\u202C\u202A\u206C\u202E\u202E(BepinexPlugin.sequenceTable, FlandreToolDestroyingObstaclesDef.\u202C\u202A\u206C\u202C\u206A\u200C\u206E\u206C\u200D\u200D\u200D\u202C\u206D\u202E\u200C\u206C\u206B\u202E\u200D\u206F\u206B\u202D\u206C\u202C\u200D\u202A\u200B\u206B\u200B\u206B\u200F\u200D\u206B\u206B\u202E\u202C\u200D\u200C\u200E\u206B\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, BepinexPlugin.NormalFlandrePlayerUnit, false, false, false, Rarity.Common, CardType.Tool, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 0
			}, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, new int?(1), null, null, null, null, null, null, null, null, null, null, BepinexPlugin.NormalFlandrePlayerUnit ? Keyword.Replenish : Keyword.None, BepinexPlugin.NormalFlandrePlayerUnit ? Keyword.Replenish : Keyword.None, false, Keyword.None, Keyword.None, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1368341733), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1954015121), new List<string>());
		}

		static CardImages \u200C\u206B\u200E\u206A\u206F\u200E\u206B\u206A\u206F\u206C\u206F\u206A\u200B\u200C\u206F\u200B\u206E\u202B\u206C\u202D\u206C\u202A\u206F\u206F\u206D\u202C\u200E\u202B\u200D\u200E\u202C\u206D\u206B\u206F\u202B\u202C\u206F\u206B\u200E\u206C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u200D\u206E\u202A\u202E\u200E\u202B\u202A\u206F\u202C\u202B\u202B\u200E\u202A\u200E\u200E\u206A\u206D\u200F\u202B\u206C\u206A\u202B\u202A\u202E\u202E\u206D\u202D\u206B\u202C\u206F\u200D\u200C\u206B\u202C\u200E\u200E\u202A\u200D\u200F\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u202B\u200D\u206E\u200C\u206C\u200F\u200B\u206C\u202B\u200C\u202B\u202E\u202D\u202B\u200F\u200E\u200F\u202E\u200C\u200B\u200C\u200D\u202B\u206A\u202E\u206C\u200C\u200E\u202E\u206C\u200B\u206D\u206C\u206D\u206B\u200D\u202C\u202A\u200E\u206F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u202C\u202A\u206C\u202C\u206A\u200C\u206E\u206C\u200D\u200D\u200D\u202C\u206D\u202E\u200C\u206C\u206B\u202E\u200D\u206F\u206B\u202D\u206C\u202C\u200D\u202A\u200B\u206B\u200B\u206B\u200F\u200D\u206B\u206B\u202E\u202C\u200D\u200C\u200E\u206B\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u200F\u202A\u202E\u206D\u202D\u200E\u206D\u202D\u200B\u200D\u200B\u206F\u200C\u206A\u206B\u206B\u206D\u206A\u206D\u202B\u206F\u206B\u206C\u200C\u202A\u200D\u202C\u200E\u202D\u202C\u202C\u202E\u200C\u200C\u202D\u202C\u202A\u206C\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(FlandreToolDestroyingObstaclesDef))]
		public sealed class FlandreToolDestroyingObstacles : FlandreCard
		{
			private string LockedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-266623663), true, true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u206C\u206F\u202C\u206E\u202B\u200F\u206D\u200B\u202C\u200F\u206B\u200F\u206A\u206B\u202A\u200C\u202E\u202B\u202C\u202C\u202B\u200B\u206B\u206C\u200D\u200D\u200D\u202A\u202E\u202D\u202E\u202E\u206A\u202E\u200F\u206C\u206F\u200F\u202A\u206F\u202E(key, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-661991630)))
				{
					for (;;)
					{
						IL_0017:
						int num = 2082274294;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(((num2 - -((-1960215391 ^ -670248650) - ~-715253431) + (~947287359 + ~1545113010)) * 1137346147) ^ -1398630826)) % 5U)
							{
							case 0U:
								goto IL_0017;
							case 1U:
								num = (int)(((!BepinexPlugin.NormalFlandrePlayerUnit) ? 3372788746U : 779302255U) ^ (num3 * 4070205035U));
								continue;
							case 3U:
								key = "";
								num = (int)((num3 * 3487821639U) ^ 654064829U);
								continue;
							case 4U:
								required = false;
								num = (int)((num3 * 2904581460U) ^ 2510712925U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
				return TypeFactory<Card>.LocalizeProperty(FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u200C\u202D\u202E\u200B\u202C\u202B\u200C\u202E\u206A\u206C\u202B\u206B\u202D\u206C\u206F\u206A\u202B\u206B\u206F\u200D\u200C\u206D\u206E\u206E\u200B\u206A\u206F\u206E\u202E\u202D\u206A\u200D\u200E\u202A\u200F\u202C\u206A\u202D\u206E\u202E\u202E(this), key, decorated, required);
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.NormalFlandrePlayerUnit)
				{
					for (;;)
					{
						int num = -1289417322;
						switch (~(num * 1176733715 + -(-796615459 * 527016334) + (965786620 - 1283104348)) % 3)
						{
						case 0:
							continue;
						case 2:
							goto IL_0045;
						}
						break;
					}
					goto IL_005B;
					IL_0045:
					return base.GetBaseDescription();
				}
				IL_005B:
				return this.LockedDescription;
			}

			public override Interaction Precondition()
			{
				List<Card> list = FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u202A\u202D\u206B\u206B\u200E\u206A\u206D\u206F\u200C\u202C\u202D\u200C\u200F\u206F\u206C\u202B\u200D\u200B\u206F\u200B\u200D\u206B\u200E\u206B\u200D\u206B\u202E\u200D\u200B\u200D\u200B\u206D\u206B\u202C\u206F\u206B\u200E\u206E\u202E\u202D\u202E(FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u202C\u200E\u206C\u202D\u206E\u206A\u200C\u200C\u206B\u206E\u206C\u206C\u206F\u200C\u202C\u200F\u206F\u206F\u206D\u202B\u200D\u206F\u200C\u202C\u200D\u202E\u206A\u202C\u200C\u200D\u200C\u206F\u200B\u202C\u206B\u206A\u202C\u200C\u206B\u206C\u202E(this)).ToList<Card>();
				Card card = FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u202A\u200B\u200C\u200C\u206C\u206D\u206F\u200E\u206B\u206B\u206E\u206C\u206A\u200D\u206F\u206E\u200D\u202E\u202E\u202E\u200F\u202D\u202E\u206D\u200F\u202A\u200D\u202B\u206B\u200D\u202C\u206C\u206F\u206E\u206A\u202D\u206F\u206F\u206F\u206A\u202E(FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u202C\u200E\u206C\u202D\u206E\u206A\u200C\u200C\u206B\u206E\u206C\u206C\u206F\u200C\u202C\u200F\u206F\u206F\u206D\u202B\u200D\u206F\u200C\u202C\u200D\u202E\u206A\u202C\u200C\u200D\u200C\u206F\u200B\u202C\u206B\u206A\u202C\u200C\u206B\u206C\u202E(this), FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u200C\u200E\u202D\u202B\u206D\u202C\u206B\u206E\u200D\u200C\u200F\u200E\u206E\u202D\u206C\u202A\u206B\u200D\u206E\u200F\u202D\u200E\u200E\u200B\u206C\u200B\u206E\u202E\u202C\u206B\u202C\u206C\u200D\u200C\u206A\u202E\u206D\u202E\u202E\u206C\u202E(this));
				if (card != null)
				{
					goto IL_0026;
				}
				goto IL_006B;
				int num2;
				for (;;)
				{
					IL_002B:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(~(uint)(~(uint)((num * 24744515) ^ 1524941700)))) % 5U)
					{
					case 0U:
						goto IL_0026;
					case 1U:
						goto IL_005A;
					case 2U:
						goto IL_006B;
					case 4U:
						list.Remove(card);
						num2 = (int)((num3 * 54235565U) ^ 262196991U);
						continue;
					}
					break;
				}
				goto IL_009C;
				IL_005A:
				return null;
				IL_009C:
				return FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.\u200D\u200D\u202C\u202A\u202E\u202D\u202A\u206A\u202B\u200E\u202B\u206B\u206F\u202E\u200B\u206D\u200E\u206B\u202E\u202D\u206C\u200E\u202C\u202C\u206D\u200D\u200B\u202C\u206B\u200F\u206F\u200C\u202D\u202C\u206C\u206F\u200C\u202A\u206F\u206B\u202E(1, 1, list, SelectedCardHandling.DoNothing);
				IL_0026:
				num2 = -1777963991;
				goto IL_002B;
				IL_006B:
				num2 = ((list.Count > 0) ? (-1524582708) : (-1339537701));
				goto IL_002B;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.<Actions>d__5 <Actions>d__ = new FlandreToolDestroyingObstaclesDef.FlandreToolDestroyingObstacles.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static bool \u206C\u206F\u202C\u206E\u202B\u200F\u206D\u200B\u202C\u200F\u206B\u200F\u206A\u206B\u202A\u200C\u202E\u202B\u202C\u202C\u202B\u200B\u206B\u206C\u200D\u200D\u200D\u202A\u202E\u202D\u202E\u202E\u206A\u202E\u200F\u206C\u206F\u200F\u202A\u206F\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u200C\u202D\u202E\u200B\u202C\u202B\u200C\u202E\u206A\u206C\u202B\u206B\u202D\u206C\u206F\u206A\u202B\u206B\u206F\u200D\u200C\u206D\u206E\u206E\u200B\u206A\u206F\u206E\u202E\u202D\u206A\u200D\u200E\u202A\u200F\u202C\u206A\u202D\u206E\u202E\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			static GameRunController \u202C\u200E\u206C\u202D\u206E\u206A\u200C\u200C\u206B\u206E\u206C\u206C\u206F\u200C\u202C\u200F\u206F\u206F\u206D\u202B\u200D\u206F\u200C\u202C\u200D\u202E\u206A\u202C\u200C\u200D\u200C\u206F\u200B\u202C\u206B\u206A\u202C\u200C\u206B\u206C\u202E(GameEntity A_0)
			{
				return A_0.GameRun;
			}

			static IEnumerable<Card> \u202A\u202D\u206B\u206B\u200E\u206A\u206D\u206F\u200C\u202C\u202D\u200C\u200F\u206F\u206C\u202B\u200D\u200B\u206F\u200B\u200D\u206B\u200E\u206B\u200D\u206B\u202E\u200D\u200B\u200D\u200B\u206D\u206B\u202C\u206F\u206B\u200E\u206E\u202E\u202D\u202E(GameRunController A_0)
			{
				return A_0.BaseDeckWithoutUnremovable;
			}

			static int \u200C\u200E\u202D\u202B\u206D\u202C\u206B\u206E\u200D\u200C\u200F\u200E\u206E\u202D\u206C\u202A\u206B\u200D\u206E\u200F\u202D\u200E\u200E\u200B\u206C\u200B\u206E\u202E\u202C\u206B\u202C\u206C\u200D\u200C\u206A\u202E\u206D\u202E\u202E\u206C\u202E(Card A_0)
			{
				return A_0.InstanceId;
			}

			static Card \u202A\u200B\u200C\u200C\u206C\u206D\u206F\u200E\u206B\u206B\u206E\u206C\u206A\u200D\u206F\u206E\u200D\u202E\u202E\u202E\u200F\u202D\u202E\u206D\u200F\u202A\u200D\u202B\u206B\u200D\u202C\u206C\u206F\u206E\u206A\u202D\u206F\u206F\u206F\u206A\u202E(GameRunController A_0, int A_1)
			{
				return A_0.GetDeckCardByInstanceId(A_1);
			}

			static SelectCardInteraction \u200D\u200D\u202C\u202A\u202E\u202D\u202A\u206A\u202B\u200E\u202B\u206B\u206F\u202E\u200B\u206D\u200E\u206B\u202E\u202D\u206C\u200E\u202C\u202C\u206D\u200D\u200B\u202C\u206B\u200F\u206F\u200C\u202D\u202C\u206C\u206F\u200C\u202A\u206F\u206B\u202E(int A_0, int A_1, IEnumerable<Card> A_2, SelectedCardHandling A_3)
			{
				return new SelectCardInteraction(A_0, A_1, A_2, A_3);
			}
		}
	}
}
