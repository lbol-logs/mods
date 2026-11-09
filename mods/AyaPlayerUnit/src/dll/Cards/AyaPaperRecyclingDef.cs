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
	public sealed class AyaPaperRecyclingDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1018865569);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaPaperRecyclingDef.\u200F\u200B\u200B\u202D\u200B\u202B\u206F\u206D\u202C\u200D\u206C\u202A\u200E\u202E\u200E\u206A\u200F\u202D\u200D\u206C\u202C\u202E\u202B\u200B\u206E\u200B\u206F\u200B\u202E\u206F\u206F\u202C\u202E\u206D\u206A\u200C\u202A\u202C\u206C\u200E\u202E(BepinexPlugin.embeddedSource);
			AyaPaperRecyclingDef.\u200C\u206E\u200E\u202A\u200D\u202A\u200F\u206D\u200D\u206A\u200F\u202A\u202A\u200B\u202C\u206E\u202E\u202C\u202E\u200E\u202A\u202A\u202E\u206F\u200D\u202B\u206C\u206A\u200E\u206E\u200F\u200B\u200F\u200F\u206B\u200C\u206F\u206D\u200F\u202B\u202E(cardImages, this, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1738697972), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaPaperRecyclingDef.\u206A\u206A\u206A\u206D\u206E\u206B\u206E\u200C\u206D\u202D\u206A\u202B\u206B\u202D\u200E\u206C\u200F\u206B\u200C\u206B\u200C\u206D\u200E\u202B\u200C\u202C\u206D\u202E\u200B\u200C\u202B\u206E\u202A\u200D\u202A\u200C\u202A\u202C\u206B\u202A\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaPaperRecyclingDef.\u200D\u202D\u206F\u202E\u202A\u202A\u200D\u202D\u200F\u202D\u200D\u202A\u206A\u206F\u206B\u206A\u200F\u202D\u206F\u206A\u200C\u206F\u200C\u206D\u200E\u202D\u206F\u206D\u202B\u202C\u200B\u200C\u206A\u206F\u200F\u200D\u206A\u200F\u202D\u200D\u202E(BepinexPlugin.sequenceTable, AyaPaperRecyclingDef.\u200B\u200C\u206B\u200B\u200F\u202C\u206C\u202C\u202E\u200B\u200C\u206F\u202D\u202B\u202B\u202B\u200F\u206C\u202A\u202A\u206D\u206B\u202A\u200F\u206F\u202C\u206E\u206C\u202B\u200B\u202C\u206C\u200B\u202D\u206A\u206E\u206C\u200F\u202A\u200F\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1341462283), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, true, false, true, true, Rarity.Common, CardType.Skill, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Green }, false, BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Any = 1,
				Green = 1
			} : new ManaGroup
			{
				Green = 1
			}, new ManaGroup?(BepinexPlugin.AyaPhantasmMode.Value ? new ManaGroup
			{
				Any = 2
			} : new ManaGroup
			{
				Any = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, new ManaGroup?(new ManaGroup
			{
				Green = 1
			}), null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.Replenish, false, Keyword.Misfortune | Keyword.Exile, Keyword.Misfortune | Keyword.Exile, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1122525), new List<string>());
		}

		static CardImages \u200F\u200B\u200B\u202D\u200B\u202B\u206F\u206D\u202C\u200D\u206C\u202A\u200E\u202E\u200E\u206A\u200F\u202D\u200D\u206C\u202C\u202E\u202B\u200B\u206E\u200B\u206F\u200B\u202E\u206F\u206F\u202C\u202E\u206D\u206A\u200C\u202A\u202C\u206C\u200E\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200C\u206E\u200E\u202A\u200D\u202A\u200F\u206D\u200D\u206A\u200F\u202A\u202A\u200B\u202C\u206E\u202E\u202C\u202E\u200E\u202A\u202A\u202E\u206F\u200D\u202B\u206C\u206A\u200E\u206E\u200F\u200B\u200F\u200F\u206B\u200C\u206F\u206D\u200F\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u206A\u206A\u206D\u206E\u206B\u206E\u200C\u206D\u202D\u206A\u202B\u206B\u202D\u200E\u206C\u200F\u206B\u200C\u206B\u200C\u206D\u200E\u202B\u200C\u202C\u206D\u202E\u200B\u200C\u202B\u206E\u202A\u200D\u202A\u200C\u202A\u202C\u206B\u202A\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200B\u200C\u206B\u200B\u200F\u202C\u206C\u202C\u202E\u200B\u200C\u206F\u202D\u202B\u202B\u202B\u200F\u206C\u202A\u202A\u206D\u206B\u202A\u200F\u206F\u202C\u206E\u206C\u202B\u200B\u202C\u206C\u200B\u202D\u206A\u206E\u206C\u200F\u202A\u200F\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200D\u202D\u206F\u202E\u202A\u202A\u200D\u202D\u200F\u202D\u200D\u202A\u206A\u206F\u206B\u206A\u200F\u202D\u206F\u206A\u200C\u206F\u200C\u206D\u200E\u202D\u206F\u206D\u202B\u202C\u200B\u200C\u206A\u206F\u200F\u200D\u206A\u200F\u202D\u200D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaPaperRecyclingDef))]
		public sealed class AyaPaperRecycling : Card
		{
			private List<Card> List
			{
				get
				{
					BattleController battleController = AyaPaperRecyclingDef.AyaPaperRecycling.\u206A\u206B\u202B\u206D\u206D\u202C\u206E\u206F\u206A\u206B\u202B\u206D\u202E\u206A\u200C\u200B\u202C\u206F\u206A\u202D\u206D\u206B\u206F\u200B\u202C\u202E\u206D\u200E\u200D\u202D\u206A\u206C\u202A\u202D\u206E\u202B\u202A\u206A\u206A\u206D\u202E(this);
					if (battleController == null)
					{
						return null;
					}
					return AyaPaperRecyclingDef.AyaPaperRecycling.\u206D\u202A\u206D\u206B\u206E\u206A\u202C\u200B\u206C\u206C\u206A\u206F\u200C\u206B\u200E\u206B\u200F\u206E\u206E\u200C\u200C\u202C\u200D\u200E\u200D\u202B\u206D\u206A\u202C\u202E\u202C\u202B\u200E\u206E\u206A\u200F\u202D\u206E\u206E\u202A\u202E(battleController).Where(delegate(Card c)
					{
						if (c != this)
						{
							for (;;)
							{
								IL_0007:
								int num = 1035415593;
								for (;;)
								{
									int num2 = num;
									uint num3;
									switch ((num3 = (uint)(-(num2 + (-(-1343539003 * -792312911) + -(1002144621 * -1481046330))) * 421812433 * 1479532533)) % 5U)
									{
									case 1U:
										return true;
									case 2U:
										num = (int)(((AyaPaperRecyclingDef.AyaPaperRecycling.\u200C\u200D\u202E\u206E\u200D\u200B\u200D\u200C\u206C\u206E\u200E\u202C\u206D\u206D\u202E\u202B\u206E\u202E\u200F\u206B\u200F\u202E\u200B\u206A\u200B\u202A\u200B\u206B\u206B\u206F\u202A\u206F\u202B\u206F\u200E\u206F\u202C\u206F\u202E\u200D\u202E(c) == CardType.Status) ? 1476022589U : 3664331653U) ^ (num3 * 2957431765U));
										continue;
									case 3U:
										goto IL_0076;
									case 4U:
										goto IL_0007;
									}
									goto Block_1;
								}
							}
							Block_1:
							return false;
							IL_0076:
							return AyaPaperRecyclingDef.AyaPaperRecycling.\u200C\u200D\u202E\u206E\u200D\u200B\u200D\u200C\u206C\u206E\u200E\u202C\u206D\u206D\u202E\u202B\u206E\u202E\u200F\u206B\u200F\u202E\u200B\u206A\u200B\u202A\u200B\u206B\u206B\u206F\u202A\u206F\u202B\u206F\u200E\u206F\u202C\u206F\u202E\u200D\u202E(c) == CardType.Misfortune;
						}
						return false;
					}).ToList<Card>();
				}
			}

			public override Interaction Precondition()
			{
				if (this.List.Count == 1)
				{
					goto IL_0011;
				}
				goto IL_00D9;
				int num2;
				for (;;)
				{
					IL_0016:
					int num = num2;
					uint num3;
					switch ((num3 = (uint)(~(uint)((num - (~(-303833603 ^ -2073911101) + -(2136252186 ^ -796208431)) - ((-838224312 ^ -1851941148) + -638822854)) ^ -1703578086))) % 7U)
					{
					case 0U:
						goto IL_00FB;
					case 1U:
						this._oneTargetHand = this.List[0];
						num2 = (int)((num3 * 3887837830U) ^ 819090750U);
						continue;
					case 2U:
						num2 = (int)(((this.List.Count <= 5) ? 2630191615U : 4004625533U) ^ (num3 * 3289015672U));
						continue;
					case 3U:
						goto IL_00D9;
					case 5U:
						goto IL_00C0;
					case 6U:
						goto IL_0011;
					}
					break;
				}
				goto IL_011B;
				IL_00C0:
				return AyaPaperRecyclingDef.AyaPaperRecycling.\u202C\u200E\u200B\u200D\u202E\u200E\u202A\u206F\u206E\u200B\u206E\u202E\u206E\u200F\u206B\u202A\u200C\u200E\u202A\u206C\u206D\u206A\u206F\u200E\u206F\u206B\u200D\u200C\u200B\u200B\u202A\u202D\u206E\u200C\u200F\u200B\u202B\u206D\u200E\u206D\u202E(this.List, false, false, false);
				IL_00FB:
				return AyaPaperRecyclingDef.AyaPaperRecycling.\u200E\u206A\u202C\u200B\u206A\u202D\u202B\u200E\u206B\u202E\u206F\u200B\u200D\u200E\u206C\u206B\u202A\u206B\u202C\u202B\u200F\u202C\u200F\u206F\u200E\u200E\u202C\u206D\u200D\u206E\u202A\u206A\u200F\u206B\u200D\u202B\u202A\u202E\u202D\u200C\u202E(1, 1, this.List);
				IL_011B:
				return null;
				IL_0011:
				num2 = 841130405;
				goto IL_0016;
				IL_00D9:
				num2 = ((this.List.Count <= 1) ? 2119876965 : 2034071078);
				goto IL_0016;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaPaperRecyclingDef.AyaPaperRecycling.<Actions>d__3 <Actions>d__ = new AyaPaperRecyclingDef.AyaPaperRecycling.<Actions>d__3(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static BattleController \u206A\u206B\u202B\u206D\u206D\u202C\u206E\u206F\u206A\u206B\u202B\u206D\u202E\u206A\u200C\u200B\u202C\u206F\u206A\u202D\u206D\u206B\u206F\u200B\u202C\u202E\u206D\u200E\u200D\u202D\u206A\u206C\u202A\u202D\u206E\u202B\u202A\u206A\u206A\u206D\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u206D\u202A\u206D\u206B\u206E\u206A\u202C\u200B\u206C\u206C\u206A\u206F\u200C\u206B\u200E\u206B\u200F\u206E\u206E\u200C\u200C\u202C\u200D\u200E\u200D\u202B\u206D\u206A\u202C\u202E\u202C\u202B\u200E\u206E\u206A\u200F\u202D\u206E\u206E\u202A\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static SelectHandInteraction \u200E\u206A\u202C\u200B\u206A\u202D\u202B\u200E\u206B\u202E\u206F\u200B\u200D\u200E\u206C\u206B\u202A\u206B\u202C\u202B\u200F\u202C\u200F\u206F\u200E\u200E\u202C\u206D\u200D\u206E\u202A\u206A\u200F\u206B\u200D\u202B\u202A\u202E\u202D\u200C\u202E(int A_0, int A_1, IEnumerable<Card> A_2)
			{
				return new SelectHandInteraction(A_0, A_1, A_2);
			}

			static MiniSelectCardInteraction \u202C\u200E\u200B\u200D\u202E\u200E\u202A\u206F\u206E\u200B\u206E\u202E\u206E\u200F\u206B\u202A\u200C\u200E\u202A\u206C\u206D\u206A\u206F\u200E\u206F\u206B\u200D\u200C\u200B\u200B\u202A\u202D\u206E\u200C\u200F\u200B\u202B\u206D\u200E\u206D\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			static CardType \u200C\u200D\u202E\u206E\u200D\u200B\u200D\u200C\u206C\u206E\u200E\u202C\u206D\u206D\u202E\u202B\u206E\u202E\u200F\u206B\u200F\u202E\u200B\u206A\u200B\u202A\u200B\u206B\u206B\u206F\u202A\u206F\u202B\u206F\u200E\u206F\u202C\u206F\u202E\u200D\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			private Card _oneTargetHand;
		}
	}
}
