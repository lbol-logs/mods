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
using LBoL.Core.Battle.BattleActions;
using LBoL.Core.Battle.Interactions;
using LBoL.Core.Cards;
using LBoL.Core.StatusEffects;
using LBoL.Core.Units;
using LBoL.EntityLib.Cards.Enemy;
using LBoLEntitySideloader;
using LBoLEntitySideloader.Attributes;
using LBoLEntitySideloader.Entities;
using LBoLEntitySideloader.Resource;

namespace AyaShameimaru.Cards
{
	public sealed class AyaFriendHatateDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(313736055);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendHatateDef.\u200E\u206C\u202E\u202D\u206C\u206D\u202B\u206A\u200C\u200E\u200C\u206A\u202D\u206D\u206A\u206A\u200C\u200D\u200F\u206B\u200B\u200F\u206B\u200E\u200B\u202A\u200E\u206B\u206A\u202A\u206E\u202B\u202C\u202D\u202A\u202B\u206D\u206D\u206A\u206B\u202E(BepinexPlugin.embeddedSource);
			AyaFriendHatateDef.\u202E\u202A\u206B\u206A\u202A\u206F\u200D\u206C\u202A\u206C\u206C\u200C\u200D\u206C\u202D\u202B\u202D\u200E\u206E\u206F\u206B\u200C\u202E\u206F\u202E\u200E\u206D\u202E\u206A\u202C\u206D\u202C\u206B\u206D\u200B\u206D\u206C\u200F\u206E\u200C\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1773327695), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendHatateDef.\u206A\u206A\u202A\u200D\u200B\u200E\u206D\u206C\u200E\u206B\u200D\u202A\u200B\u206C\u202A\u200E\u206E\u200D\u206C\u200E\u206F\u202B\u202D\u206B\u200D\u200B\u206E\u202C\u202D\u200D\u206A\u200F\u206B\u200E\u202C\u202A\u206D\u200B\u202C\u200F\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendHatateDef.\u206C\u206D\u200E\u202C\u200E\u202E\u206F\u202B\u202D\u202D\u200C\u206D\u206F\u206E\u200E\u206B\u200C\u200E\u200F\u200F\u200E\u202D\u202C\u200E\u202D\u200B\u202E\u206C\u206F\u206D\u206A\u206D\u202D\u206A\u200E\u206D\u202D\u202B\u200B\u206F\u202E(BepinexPlugin.sequenceTable, AyaFriendHatateDef.\u206C\u206F\u202D\u200D\u200D\u200B\u206F\u200B\u202B\u206D\u200E\u206B\u202D\u202C\u200E\u202A\u200B\u206E\u206F\u206F\u202D\u206D\u200F\u202D\u206C\u202B\u202C\u200B\u200C\u202B\u206E\u202C\u206B\u202B\u200E\u200B\u206C\u206A\u200B\u202D\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1308361000), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-454307346), 0, false, true, false, false, true, Rarity.Rare, CardType.Friend, new TargetType?(TargetType.Nobody), new List<ManaColor> { ManaColor.Black }, false, new ManaGroup
			{
				Any = 3,
				Black = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 3,
				Black = 1
			}), null, null, null, new int?(24), null, null, null, null, null, new int?(2), new int?(3), new int?(1), new int?(2), new ManaGroup?(new ManaGroup
			{
				Philosophy = 5
			}), null, null, null, null, new int?(1), null, new int?(0), null, new int?(0), null, new int?(-3), null, new int?(0), null, Keyword.None, Keyword.None, false, Keyword.Accuracy | Keyword.Expel, Keyword.Accuracy | Keyword.Expel, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(447897749) }, new List<string> { <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1982037498) }, new List<string>
			{
				<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-410250804),
				<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(917087903)
			}, new List<string>
			{
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1648413921),
				<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1509329618)
			}, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-2101051445), new List<string>());
		}

		static CardImages \u200E\u206C\u202E\u202D\u206C\u206D\u202B\u206A\u200C\u200E\u200C\u206A\u202D\u206D\u206A\u206A\u200C\u200D\u200F\u206B\u200B\u200F\u206B\u200E\u200B\u202A\u200E\u206B\u206A\u202A\u206E\u202B\u202C\u202D\u202A\u202B\u206D\u206D\u206A\u206B\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202E\u202A\u206B\u206A\u202A\u206F\u200D\u206C\u202A\u206C\u206C\u200C\u200D\u206C\u202D\u202B\u202D\u200E\u206E\u206F\u206B\u200C\u202E\u206F\u202E\u200E\u206D\u202E\u206A\u202C\u206D\u202C\u206B\u206D\u200B\u206D\u206C\u200F\u206E\u200C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206A\u206A\u202A\u200D\u200B\u200E\u206D\u206C\u200E\u206B\u200D\u202A\u200B\u206C\u202A\u200E\u206E\u200D\u206C\u200E\u206F\u202B\u202D\u206B\u200D\u200B\u206E\u202C\u202D\u200D\u206A\u200F\u206B\u200E\u202C\u202A\u206D\u200B\u202C\u200F\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206C\u206F\u202D\u200D\u200D\u200B\u206F\u200B\u202B\u206D\u200E\u206B\u202D\u202C\u200E\u202A\u200B\u206E\u206F\u206F\u202D\u206D\u200F\u202D\u206C\u202B\u202C\u200B\u200C\u202B\u206E\u202C\u206B\u202B\u200E\u200B\u206C\u206A\u200B\u202D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u206C\u206D\u200E\u202C\u200E\u202E\u206F\u202B\u202D\u202D\u200C\u206D\u206F\u206E\u200E\u206B\u200C\u200E\u200F\u200F\u200E\u202D\u202C\u200E\u202D\u200B\u202E\u206C\u206F\u206D\u206A\u206D\u202D\u206A\u200E\u206D\u202D\u202B\u200B\u206F\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendHatateDef))]
		public sealed class AyaFriendHatate : Card
		{
			private AyaFriendHatateDef.AyaFriendHatate.Skills TryGetSkills()
			{
				int? num = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
				for (;;)
				{
					IL_0007:
					int num2 = -453815710;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(num3 * 1978590725 * 1277593047)) % 5U)
						{
						case 1U:
							num = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
							num2 = 919324488;
							continue;
						case 2U:
							num2 = (int)(((num == null) ? 1539244109U : 1745055136U) ^ (num4 * 3808920842U));
							continue;
						case 3U:
							return AyaFriendHatateDef.AyaFriendHatate.Skills.None;
						case 4U:
							goto IL_0007;
						}
						goto Block_1;
					}
				}
				Block_1:
				return (AyaFriendHatateDef.AyaFriendHatate.Skills)num.Value;
			}

			public int Value3
			{
				get
				{
					return 1;
				}
			}

			public int Value4
			{
				get
				{
					return 2;
				}
			}

			public int Value5
			{
				get
				{
					return 4;
				}
			}

			public int Value6
			{
				get
				{
					return 8;
				}
			}

			public int Value7
			{
				get
				{
					return 16;
				}
			}

			public int Value8
			{
				get
				{
					return 32;
				}
			}

			public override DamageInfo Damage
			{
				get
				{
					return DamageInfo.Attack((float)AyaFriendHatateDef.AyaFriendHatate.\u202B\u206C\u200D\u202A\u206B\u202D\u200C\u206E\u202A\u206B\u200B\u206C\u200D\u206F\u202B\u202B\u206A\u206B\u200F\u202A\u202A\u200F\u206D\u202A\u202D\u200C\u200F\u202A\u206C\u206F\u200C\u200C\u206B\u202B\u206E\u206B\u200B\u200C\u206F\u200D\u202E(this), true);
				}
			}

			public int DamageValue
			{
				get
				{
					return AyaFriendHatateDef.AyaFriendHatate.\u206C\u206D\u206D\u202C\u206A\u200F\u206D\u206A\u202B\u200F\u200C\u206B\u206D\u200D\u200F\u206C\u200E\u200F\u200F\u206C\u206A\u206E\u206C\u202B\u202B\u202D\u206B\u200E\u200C\u206B\u202D\u206F\u206C\u200C\u202E\u202B\u200F\u202D\u202E\u202A\u202E(AyaFriendHatateDef.AyaFriendHatate.\u202D\u202D\u202E\u200F\u206B\u206B\u206B\u200B\u200D\u202A\u206D\u202B\u202D\u200C\u200B\u206A\u200E\u202B\u202D\u202A\u206E\u200C\u202D\u202A\u206A\u202D\u200F\u206F\u206F\u202E\u206E\u200E\u202E\u206C\u200C\u206B\u206E\u200D\u200B\u200F\u202E(this).Damage);
				}
			}

			public DamageInfo Damage2
			{
				get
				{
					return DamageInfo.Attack((float)this.Value5, true);
				}
			}

			public int Damage2Value
			{
				get
				{
					return AyaFriendHatateDef.AyaFriendHatate.\u206C\u206D\u206D\u202C\u206A\u200F\u206D\u206A\u202B\u200F\u200C\u206B\u206D\u200D\u200F\u206C\u200E\u200F\u200F\u206C\u206A\u206E\u206C\u202B\u202B\u202D\u206B\u200E\u200C\u206B\u202D\u206F\u206C\u200C\u202E\u202B\u200F\u202D\u202E\u202A\u202E(this.Damage2.Damage);
				}
			}

			public DamageInfo Damage3
			{
				get
				{
					return DamageInfo.Attack((float)this.Value8, true);
				}
			}

			public int Damage3Value
			{
				get
				{
					return AyaFriendHatateDef.AyaFriendHatate.\u206C\u206D\u206D\u202C\u206A\u200F\u206D\u206A\u202B\u200F\u200C\u206B\u206D\u200D\u200F\u206C\u200E\u200F\u200F\u206C\u206A\u206E\u206C\u202B\u202B\u202D\u206B\u200E\u200C\u206B\u202D\u206F\u206C\u200C\u202E\u202B\u200F\u202D\u202E\u202A\u202E(this.Damage3.Damage);
				}
			}

			public FriendCostInfo FriendP2
			{
				get
				{
					return new FriendCostInfo(1, FriendCostType.Passive);
				}
			}

			public FriendCostInfo FriendA3
			{
				get
				{
					return new FriendCostInfo(-6, FriendCostType.Active);
				}
			}

			public FriendCostInfo FriendU2
			{
				get
				{
					return new FriendCostInfo(-3, FriendCostType.Ultimate);
				}
			}

			public FriendCostInfo FriendU3
			{
				get
				{
					return new FriendCostInfo(-6, FriendCostType.Ultimate);
				}
			}

			private string DetailTextKanako
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1017753272), true, true);
				}
			}

			private string DetailTextSuwako
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-2109420830), true, true);
				}
			}

			private string DetailTextSunny
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-535233484), true, true);
				}
			}

			private string DetailTextLuna
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1198205590), true, true);
				}
			}

			private string DetailTextStar
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(135145201), true, true);
				}
			}

			private string DetailTextAya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-132746897), true, true);
				}
			}

			private string DetailTextRin
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1631522555), true, true);
				}
			}

			private string DetailTextNitori
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1915256064), true, true);
				}
			}

			private string DetailTextYoumu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(488905247), true, true);
				}
			}

			private string DetailTextKokoro
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-418878710), true, true);
				}
			}

			private string DetailTextClownpiece
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1103761384), true, true);
				}
			}

			private string DetailTextSiji
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-489425802), true, true);
				}
			}

			private string DetailTextDoremy
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(257338138), true, true);
				}
			}

			private string DetailTextReimu
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-979817912), true, true);
				}
			}

			private string DetailTextMarisa
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1753715492), true, true);
				}
			}

			private string DetailTextSakuya
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1793063127), true, true);
				}
			}

			private string DetailTextCirno
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1367026439), true, true);
				}
			}

			private string DetailTextKoishi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1836658660), true, true);
				}
			}

			private string DetailTextLong
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1138335111), true, true);
				}
			}

			private string DetailTextTianzi
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1967916526), true, true);
				}
			}

			private string DetailTextYuyuko
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-307393076), true, true);
				}
			}

			private string DetailTextSanae
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1116963973), true, true);
				}
			}

			private string DetailTextRemilia
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(145496458), true, true);
				}
			}

			private string DetailTextJunko
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1300756740), true, true);
				}
			}

			private string DetailTextSeija
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(2025956138), true, true);
				}
			}

			private string DetailTextYiji
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(2028656333), true, true);
				}
			}

			private string DetailTextUnknown
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1556985516), true, true);
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string GetBaseDescription()
			{
				if (AyaFriendHatateDef.AyaFriendHatate.\u206A\u200B\u202B\u206A\u202A\u206C\u206C\u206C\u206D\u202B\u206B\u206B\u206E\u202E\u200E\u202A\u200D\u206F\u206C\u206C\u202C\u200E\u206F\u202E\u202B\u200E\u206D\u202A\u206C\u206C\u202E\u202E\u202E\u202B\u202E\u200E\u206A\u202A\u206D\u200C\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200F\u206C\u200E\u202B\u200F\u202E\u206C\u206B\u200C\u206A\u206F\u200E\u206B\u200B\u206D\u202A\u206D\u206E\u200F\u202B\u202A\u206B\u202C\u206B\u202C\u200B\u206D\u200C\u202B\u202E\u202D\u206F\u200F\u200C\u202B\u202C\u206E\u202A\u202C\u202E\u202E(this)))
				{
					goto IL_0010;
				}
				goto IL_044D;
				int num2;
				string text;
				for (;;)
				{
					IL_0015:
					int num = num2;
					uint num3;
					string text2;
					string text4;
					int? num4;
					string text5;
					switch ((num3 = (uint)(-(uint)(~(uint)(num * -839923261)))) % 61U)
					{
					case 0U:
						switch (AyaFriendHatateDef.AyaFriendHatate.\u206A\u202C\u200D\u200E\u200B\u200D\u200D\u200B\u206F\u206B\u206E\u202E\u206E\u202B\u206B\u200E\u200D\u202E\u202A\u200C\u206C\u206D\u202A\u206F\u206C\u206C\u206E\u202B\u202C\u202B\u206B\u202E\u202E\u200C\u200C\u202B\u206B\u206D\u206B\u202B\u202E(this))
						{
						case FriendToken.None:
							goto IL_0639;
						case FriendToken.Active:
							goto IL_01DF;
						case FriendToken.Active2:
							goto IL_02E6;
						case FriendToken.Ultimate:
							goto IL_068D;
						default:
							num2 = (int)((num3 * 3259991293U) ^ 1196012282U);
							continue;
						}
						break;
					case 1U:
						goto IL_0851;
					case 2U:
						num2 = (int)((num3 * 1555881774U) ^ 3148905161U);
						continue;
					case 3U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1607012244));
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, base.GetExtraDescription3);
						num2 = (int)((num3 * 1370240188U) ^ 4282690965U);
						continue;
					case 4U:
						num2 = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this) == null) ? 3441632658U : 235384762U) ^ (num3 * 2308844019U));
						continue;
					case 5U:
						goto IL_0639;
					case 6U:
						text2 = base.ExtraDescription2;
						goto IL_029E;
					case 7U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, base.GetExtraDescription2);
						num2 = (int)((num3 * 3503785095U) ^ 1993883274U);
						continue;
					case 8U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1095981733));
						num2 = (int)((num3 * 611328676U) ^ 3920490228U);
						continue;
					case 9U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, base.GetExtraDescription1);
						num2 = (int)((num3 * 183848669U) ^ 3934914136U);
						continue;
					case 10U:
						goto IL_05B6;
					case 11U:
						goto IL_02E6;
					case 12U:
						goto IL_0010;
					case 13U:
						num2 = (int)((num3 * 909700087U) ^ 1121655989U);
						continue;
					case 14U:
						num2 = (int)((num3 * 275645223U) ^ 199836558U);
						continue;
					case 15U:
					{
						string text3;
						text = text3;
						num2 = 1563638237;
						continue;
					}
					case 16U:
						if (!AyaFriendHatateDef.AyaFriendHatate.\u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(this))
						{
							num2 = 1759285669;
							continue;
						}
						text2 = base.UpgradedExtraDescription2 ?? base.ExtraDescription2;
						goto IL_029E;
					case 17U:
					{
						string text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 1851491783;
						continue;
					}
					case 18U:
						goto IL_0423;
					case 19U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, AyaFriendHatateDef.AyaFriendHatate.\u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(this) ? (base.UpgradedBaseDescription ?? base.BaseDescription) : base.BaseDescription);
						num2 = 681920486;
						continue;
					case 20U:
						num2 = ((!base.HasExtraDescription2) ? 1516849946 : (-867724411));
						continue;
					case 21U:
						num2 = ((!base.HasExtraDescription1) ? 1335572533 : (-1307136632));
						continue;
					case 22U:
						if (!AyaFriendHatateDef.AyaFriendHatate.\u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(this))
						{
							num2 = (int)((num3 * 1681775129U) ^ 498490031U);
							continue;
						}
						text4 = base.UpgradedBaseDescription ?? base.BaseDescription;
						goto IL_0505;
					case 23U:
						num2 = (int)((num3 * 119873893U) ^ 2781911403U);
						continue;
					case 24U:
						num2 = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u200E\u202A\u206B\u206D\u200B\u206D\u206C\u206B\u206E\u206D\u206E\u206C\u206C\u206A\u202E\u200F\u206D\u200B\u206E\u206C\u206A\u200E\u200C\u202B\u202C\u206E\u202C\u200E\u206B\u202D\u200C\u202B\u200E\u200F\u202E\u206C\u200D\u200C\u200E\u202D\u202E(this) == 2) ? 306141763U : 692813586U) ^ (num3 * 3132890564U));
						continue;
					case 25U:
						goto IL_01DF;
					case 26U:
						num2 = (int)((num3 * 4175025733U) ^ 995873260U);
						continue;
					case 27U:
						goto IL_068D;
					case 28U:
						num2 = (int)((num3 * 4091767338U) ^ 3407340701U);
						continue;
					case 29U:
						goto IL_06BA;
					case 30U:
						num2 = (int)((num3 * 1071158656U) ^ 430946525U);
						continue;
					case 31U:
						goto IL_04D6;
					case 32U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1340451793));
						num2 = (int)((num3 * 352698356U) ^ 1522934328U);
						continue;
					case 33U:
						goto IL_026F;
					case 34U:
					{
						string text3 = base.NonbattleBaseDescription ?? base.BaseDescription;
						num2 = 1851491783;
						continue;
					}
					case 35U:
						goto IL_06D1;
					case 36U:
						goto IL_04A6;
					case 37U:
					{
						string text3;
						num2 = (((text3 = base.UpgradedNonbattleBaseDescription ?? base.UpgradedBaseDescription) != null) ? 1851491783 : 1681080050);
						continue;
					}
					case 38U:
						num2 = (int)(((num4 != null) ? 4275217442U : 1495237969U) ^ (num3 * 1332391140U));
						continue;
					case 39U:
						num2 = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u206D\u206E\u200B\u206C\u202E\u206A\u206B\u202E\u202B\u206D\u200D\u202C\u206F\u206E\u202C\u200D\u200F\u206E\u200E\u202B\u206F\u200B\u206B\u202D\u202A\u200B\u206A\u206E\u206B\u202E\u202A\u200C\u206C\u200B\u206B\u202D\u206B\u202D\u206E\u206C\u202E(this) != CardType.Friend) ? 3686735415U : 3116209322U) ^ (num3 * 3147618937U));
						continue;
					case 40U:
						num2 = (int)((num3 * 141401002U) ^ 1939437751U);
						continue;
					case 41U:
						goto IL_044D;
					case 42U:
						text4 = base.BaseDescription;
						goto IL_0505;
					case 43U:
						num2 = (int)((num3 * 1464868395U) ^ 894932438U);
						continue;
					case 44U:
						goto IL_065A;
					case 45U:
						if (!AyaFriendHatateDef.AyaFriendHatate.\u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(this))
						{
							num2 = -1268176266;
							continue;
						}
						text5 = base.UpgradedExtraDescription1 ?? base.ExtraDescription1;
						goto IL_0475;
					case 46U:
						goto IL_0258;
					case 47U:
						num2 = ((AyaFriendHatateDef.AyaFriendHatate.\u200E\u202A\u206B\u206D\u200B\u206D\u206C\u206B\u206E\u206D\u206E\u206C\u206C\u206A\u202E\u200F\u206D\u200B\u206E\u206C\u206A\u200E\u200C\u202B\u202C\u206E\u202C\u200E\u206B\u202D\u200C\u202B\u200E\u200F\u202E\u206C\u200D\u200C\u200E\u202D\u202E(this) == 1) ? (-18725556) : (-1097513341));
						continue;
					case 48U:
						text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-992650938));
						num2 = (int)((num3 * 3797839721U) ^ 3281681333U);
						continue;
					case 49U:
						goto IL_069E;
					case 51U:
						goto IL_02A9;
					case 52U:
						goto IL_0125;
					case 53U:
						goto IL_07A1;
					case 54U:
						text5 = base.ExtraDescription1;
						goto IL_0475;
					case 55U:
						num2 = ((!base.HasExtraDescription3) ? 1563638237 : 819658863);
						continue;
					case 56U:
						goto IL_04BF;
					case 57U:
						num2 = (int)((num3 * 2742730886U) ^ 3543829905U);
						continue;
					case 58U:
						switch (num4.GetValueOrDefault())
						{
						case -1:
						case 0:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 10:
						case 15:
						case 16:
						case 17:
						case 18:
						case 19:
						case 20:
						case 23:
						case 24:
						case 25:
						case 26:
							goto IL_069E;
						case 9:
							goto IL_04D6;
						case 11:
							goto IL_065A;
						case 12:
							goto IL_05B6;
						case 13:
							goto IL_06D1;
						case 14:
							goto IL_0423;
						case 21:
							goto IL_0125;
						case 22:
							goto IL_026F;
						default:
							num2 = (int)((num3 * 2801549139U) ^ 584210978U);
							continue;
						}
						break;
					case 59U:
						switch (num4.GetValueOrDefault())
						{
						case -1:
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 9:
						case 10:
						case 11:
						case 12:
						case 13:
						case 14:
						case 15:
						case 17:
						case 18:
						case 19:
						case 21:
						case 22:
						case 25:
						case 26:
							goto IL_069E;
						case 0:
							goto IL_06BA;
						case 8:
							goto IL_0258;
						case 16:
							goto IL_02A9;
						case 20:
							goto IL_07A1;
						case 23:
							goto IL_04BF;
						case 24:
							goto IL_0851;
						default:
							num2 = (int)((num3 * 2574546721U) ^ 507600724U);
							continue;
						}
						break;
					case 60U:
						num2 = ((!AyaFriendHatateDef.AyaFriendHatate.\u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(this)) ? (-1427838914) : 1107433729);
						continue;
					}
					break;
					IL_0125:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextYuyuko);
					num2 = 1563638237;
					continue;
					IL_01DF:
					num4 = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
					num2 = ((num4 != null) ? 857127052 : 1563638237);
					continue;
					IL_0258:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextNitori);
					num2 = 1196274976;
					continue;
					IL_026F:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextSanae);
					num2 = 1563638237;
					continue;
					IL_029E:
					text = text2;
					num2 = 1563638237;
					continue;
					IL_02A9:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextSakuya);
					num2 = -1055906933;
					continue;
					IL_0423:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextReimu);
					num2 = 1563638237;
					continue;
					IL_0475:
					text = text5;
					num2 = 1563638237;
					continue;
					IL_04BF:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextRemilia);
					num2 = -256352617;
					continue;
					IL_04D6:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextYoumu);
					num2 = 1621076308;
					continue;
					IL_0505:
					text = text4;
					num2 = -1894669707;
					continue;
					IL_05B6:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextSiji);
					num2 = 1563638237;
					continue;
					IL_0639:
					num2 = ((!AyaFriendHatateDef.AyaFriendHatate.\u206A\u200B\u202B\u206A\u202A\u206C\u206C\u206C\u206D\u202B\u206B\u206B\u206E\u202E\u200E\u202A\u200D\u206F\u206C\u206C\u202C\u200E\u206F\u202E\u202B\u200E\u206D\u202A\u206C\u206C\u202E\u202E\u202E\u202B\u202E\u200E\u206A\u202A\u206D\u200C\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200F\u206C\u200E\u202B\u200F\u202E\u206C\u206B\u200C\u206A\u206F\u200E\u206B\u200B\u206D\u202A\u206D\u206E\u200F\u202B\u202A\u206B\u202C\u206B\u202C\u200B\u206D\u200C\u202B\u202E\u202D\u206F\u200F\u200C\u202B\u202C\u206E\u202A\u202C\u202E\u202E(this))) ? (-314902420) : 681920486);
					continue;
					IL_065A:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextClownpiece);
					num2 = 1563638237;
					continue;
					IL_068D:
					num4 = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
					num2 = -1388868546;
					continue;
					IL_069E:
					num2 = ((base.BaseDetailText == null) ? (-1486701372) : 797727822);
					continue;
					IL_06BA:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, base.ExtraDescription3);
					num2 = 786372092;
					continue;
					IL_06D1:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextDoremy);
					num2 = 1563638237;
					continue;
					IL_07A1:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextTianzi);
					num2 = 1563638237;
					continue;
					IL_0851:
					text = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(text, this.DetailTextJunko);
					num2 = 1289993367;
				}
				return text;
				IL_02E6:
				throw AyaFriendHatateDef.AyaFriendHatate.\u206E\u200E\u206B\u206F\u200D\u202B\u206D\u202B\u200C\u200C\u206E\u206F\u202B\u206D\u202A\u206D\u202D\u206C\u200D\u200F\u202A\u202A\u202E\u202B\u202A\u202C\u202E\u200E\u202B\u202B\u200B\u200E\u200D\u206F\u202C\u200D\u206B\u202A\u202E\u206A\u202E();
				IL_04A6:
				return string.Empty;
				IL_0010:
				num2 = -1868038810;
				goto IL_0015;
				IL_044D:
				text = string.Empty;
				num2 = 45722082;
				goto IL_0015;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override string LocalizeProperty(string key, bool decorated = false, bool required = true)
			{
				if (AyaFriendHatateDef.AyaFriendHatate.\u200F\u206E\u202A\u206C\u202C\u202A\u200B\u206B\u202D\u200C\u206E\u206B\u200E\u200D\u206A\u200E\u206B\u200F\u200E\u206E\u202A\u202C\u202B\u202C\u200E\u200C\u202A\u202A\u200D\u206B\u200F\u202B\u202A\u206F\u200E\u200E\u200D\u200F\u202D\u206F\u202E(key, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1029965993)))
				{
					for (;;)
					{
						IL_0017:
						int num = 1657888432;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(1625346186 - (num2 - (~(1911261096 + -1157443065) + -(45394619 - -1547023175))))) % 50U)
							{
							case 0U:
								num = (int)((num3 * 3278071057U) ^ 4152641375U);
								continue;
							case 1U:
								goto IL_0351;
							case 2U:
								goto IL_057B;
							case 3U:
								goto IL_0017;
							case 4U:
								goto IL_0369;
							case 5U:
								goto IL_03F3;
							case 6U:
								num = (int)((num3 * 3020036336U) ^ 1505923967U);
								continue;
							case 7U:
								goto IL_0563;
							case 8U:
								goto IL_0147;
							case 9U:
								goto IL_0339;
							case 10U:
								goto IL_022B;
							case 11U:
								goto IL_02B5;
							case 12U:
								goto IL_03C3;
							case 13U:
								num = (int)((num3 * 2072172762U) ^ 3174186237U);
								continue;
							case 14U:
								num = (int)((num3 * 3484557788U) ^ 1571908311U);
								continue;
							case 15U:
								goto IL_0466;
							case 16U:
								num = (int)((num3 * 2729221617U) ^ 3066590663U);
								continue;
							case 17U:
								num = (int)((num3 * 1126355749U) ^ 3425640950U);
								continue;
							case 18U:
								goto IL_03AB;
							case 19U:
								num = (int)((num3 * 1639343864U) ^ 3108483159U);
								continue;
							case 20U:
								goto IL_015F;
							case 21U:
								goto IL_0520;
							case 22U:
								goto IL_029D;
							case 23U:
								goto IL_02DF;
							case 24U:
							{
								int? num4 = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
								num = (int)((num3 * 900681038U) ^ 1107260597U);
								continue;
							}
							case 25U:
								goto IL_047E;
							case 26U:
								num = (int)((num3 * 221391263U) ^ 1495261483U);
								continue;
							case 28U:
								goto IL_04F6;
							case 29U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 1431667924U : 2241003311U) ^ (num3 * 3325907145U));
								continue;
							}
							case 30U:
								goto IL_02F7;
							case 31U:
								num = (int)((num3 * 559947544U) ^ 3831068455U);
								continue;
							case 32U:
								num = (int)((num3 * 25282312U) ^ 581172415U);
								continue;
							case 33U:
								goto IL_0321;
							case 34U:
							{
								int? num4;
								int valueOrDefault = num4.GetValueOrDefault();
								num = (int)((num3 * 1783741102U) ^ 2023965838U);
								continue;
							}
							case 35U:
								goto IL_025B;
							case 36U:
							{
								int valueOrDefault;
								switch (valueOrDefault)
								{
								case -1:
									goto IL_0201;
								case 0:
									goto IL_04F6;
								case 1:
									goto IL_029D;
								case 2:
									goto IL_057B;
								case 3:
									goto IL_022B;
								case 4:
									goto IL_0520;
								case 5:
									goto IL_012F;
								case 6:
									goto IL_0243;
								case 7:
									goto IL_02DF;
								case 8:
									goto IL_03C3;
								case 9:
									goto IL_0369;
								case 10:
									goto IL_04DE;
								case 11:
									goto IL_0351;
								case 12:
									goto IL_03DB;
								case 13:
									goto IL_03AB;
								case 14:
									goto IL_0381;
								case 15:
									goto IL_015F;
								case 16:
									goto IL_0466;
								case 17:
									goto IL_0285;
								case 18:
									goto IL_0339;
								case 19:
									goto IL_02F7;
								case 20:
									goto IL_02B5;
								case 21:
									goto IL_0147;
								case 22:
									goto IL_025B;
								case 23:
									goto IL_0563;
								case 24:
									goto IL_0321;
								case 25:
									goto IL_03F3;
								case 26:
									goto IL_047E;
								default:
									num = (int)((num3 * 4095076862U) ^ 1877119422U);
									continue;
								}
								break;
							}
							case 37U:
								num = (int)((num3 * 1552838965U) ^ 771016018U);
								continue;
							case 38U:
								goto IL_012F;
							case 39U:
								goto IL_04DE;
							case 40U:
								goto IL_0243;
							case 41U:
								num = (int)((num3 * 2513742725U) ^ 2030322558U);
								continue;
							case 42U:
								goto IL_0201;
							case 43U:
								goto IL_03DB;
							case 44U:
								num = (int)((num3 * 385753033U) ^ 2514546873U);
								continue;
							case 45U:
								goto IL_0285;
							case 46U:
								num = (int)((num3 * 2641031251U) ^ 4170134495U);
								continue;
							case 47U:
								num = (int)((num3 * 4243639713U) ^ 2037264830U);
								continue;
							case 48U:
								goto IL_0381;
							case 49U:
								num = (int)((num3 * 602349680U) ^ 1141752847U);
								continue;
							}
							goto Block_1;
							IL_012F:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(135145201);
							num = 1964782079;
							continue;
							IL_0147:
							key = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-307393076);
							num = 1964782079;
							continue;
							IL_015F:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1764609483);
							num = 1964782079;
							continue;
							IL_0201:
							key = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1235019250);
							num = 1964782079;
							continue;
							IL_022B:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-535233484);
							num = 1964782079;
							continue;
							IL_0243:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-132746897);
							num = -741199316;
							continue;
							IL_025B:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1598898361);
							num = 1964782079;
							continue;
							IL_0285:
							key = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1850360753);
							num = -1820006536;
							continue;
							IL_029D:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1437357789);
							num = 1964782079;
							continue;
							IL_02B5:
							key = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(1967916526);
							num = 1960620739;
							continue;
							IL_02DF:
							key = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-122977164);
							num = 1493728319;
							continue;
							IL_02F7:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(319495092);
							num = 1964782079;
							continue;
							IL_0321:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1174651229);
							num = -873821453;
							continue;
							IL_0339:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-296685773);
							num = 2102536759;
							continue;
							IL_0351:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1107883132);
							num = -1590027054;
							continue;
							IL_0369:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-1167067387);
							num = 2063536175;
							continue;
							IL_0381:
							key = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(579091410);
							num = -1906011381;
							continue;
							IL_03AB:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-672949749);
							num = 1964782079;
							continue;
							IL_03C3:
							key = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-967433055);
							num = 1991239407;
							continue;
							IL_03DB:
							key = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-770915568);
							num = -2009157072;
							continue;
							IL_03F3:
							key = <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-922681513);
							num = -1886623456;
							continue;
							IL_0466:
							key = <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-270463162);
							num = 1964782079;
							continue;
							IL_047E:
							key = <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1753503003);
							num = -2014247059;
							continue;
							IL_04DE:
							key = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-482562268);
							num = 1964782079;
							continue;
							IL_04F6:
							key = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(356651390);
							num = 1863552056;
							continue;
							IL_0520:
							key = <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(550639265);
							num = -1610413696;
							continue;
							IL_0563:
							key = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(145496458);
							num = 1964782079;
							continue;
							IL_057B:
							key = <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1651095124);
							num = 1964782079;
						}
					}
					Block_1:;
				}
				return TypeFactory<Card>.LocalizeProperty(AyaFriendHatateDef.AyaFriendHatate.\u200B\u202C\u206E\u202A\u200C\u200C\u200E\u202C\u202C\u202D\u206F\u202B\u206F\u200D\u200F\u200F\u202D\u200E\u202C\u206E\u206B\u200E\u206F\u202C\u200D\u206B\u206D\u202C\u206E\u202C\u206A\u200D\u200D\u206A\u202B\u202B\u202A\u200E\u200F\u200E\u202E(this), key, decorated, required);
			}

			public override void Initialize()
			{
				this.\u206B\u200C\u202A\u202A\u206D\u206D\u206E\u202E\u206D\u200C\u206F\u202D\u206F\u200D\u200E\u206C\u200F\u206A\u206B\u200B\u206E\u202B\u206B\u206C\u200E\u200E\u206D\u202B\u206D\u206A\u202A\u206C\u206C\u202E\u206C\u206E\u200D\u202D\u206C\u206B\u202E();
				AyaFriendHatateDef.AyaFriendHatate.\u206D\u200D\u206D\u200E\u202C\u202C\u206F\u206A\u206B\u206E\u206B\u200D\u200B\u202B\u200C\u200B\u206F\u206E\u206D\u206C\u202C\u200F\u206A\u206D\u202D\u206C\u202A\u202C\u202D\u200F\u200E\u206F\u200B\u200B\u202D\u206C\u206B\u202C\u202E\u206D\u202E(this, new int?(0));
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				base.ReactBattleEvent<GameEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202D\u206C\u206F\u200F\u202A\u206D\u200B\u202D\u206A\u206E\u202D\u202C\u202C\u202A\u206E\u206E\u206E\u200B\u206C\u206E\u202E\u206F\u202E\u200C\u202C\u200B\u200B\u206B\u200C\u206E\u206B\u200C\u206A\u206A\u202D\u202B\u202C\u202B\u200F\u202E\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<GameEventArgs>(this.OnBattleStarted));
				IEnumerator<EnemyUnit> enumerator = AyaFriendHatateDef.AyaFriendHatate.\u206D\u200D\u202C\u202E\u206B\u200E\u202B\u202D\u206E\u200D\u202D\u202A\u206A\u206C\u202B\u202B\u202C\u200E\u200E\u206C\u202E\u206E\u202A\u200D\u200D\u202D\u202A\u206C\u202C\u206C\u202E\u206A\u206C\u202D\u202B\u206D\u206B\u200F\u206C\u202B\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0098:
						int num = ((!AyaFriendHatateDef.AyaFriendHatate.\u200F\u206B\u202B\u206F\u202E\u206B\u202E\u206C\u200B\u200B\u202E\u200B\u206B\u200C\u202C\u200B\u200E\u206B\u200D\u200B\u200C\u200F\u202B\u206D\u206C\u200E\u206C\u200C\u206E\u200B\u200B\u200F\u202E\u206E\u200F\u200F\u206D\u206E\u202C\u206D\u202E(enumerator)) ? 1790348329 : 1781649976);
						for (;;)
						{
							int num2 = num;
							switch ((~num2 ^ ~(1151603909 * -121890191) ^ (-1078482944 - -615244388)) * 449783625 % 4)
							{
							case 1:
							{
								EnemyUnit enemyUnit = enumerator.Current;
								base.ReactBattleEvent<StatusEffectApplyEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202C\u206E\u206C\u200C\u206E\u200D\u202B\u202D\u200F\u200C\u206A\u200F\u206B\u200F\u206B\u200C\u206A\u202A\u206C\u200D\u206D\u206E\u200E\u206E\u206F\u206C\u206D\u202A\u200E\u200B\u200C\u202E\u200B\u202A\u200B\u206B\u200E\u202E\u206A\u206F\u202E(enemyUnit), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
								num = -1234317961;
								continue;
							}
							case 2:
								goto IL_0098;
							case 3:
								num = 1781649976;
								continue;
							}
							goto Block_4;
						}
					}
					Block_4:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_00B6:
							int num3 = 260791045;
							for (;;)
							{
								int num2 = num3;
								uint num4;
								switch ((num4 = (uint)((~num2 ^ ~(1151603909 * -121890191) ^ (-1078482944 - -615244388)) * 449783625)) % 3U)
								{
								case 0U:
									goto IL_00B6;
								case 2U:
									AyaFriendHatateDef.AyaFriendHatate.\u200E\u200D\u206C\u202B\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200F\u200F\u206B\u206C\u202C\u206F\u202B\u200F\u206C\u202C\u200C\u200B\u206E\u202D\u202B\u200B\u202A\u200C\u206F\u206B\u206B\u206F\u202A\u202D\u200B\u202B\u206F\u202D\u202E(enumerator);
									num3 = (int)((num4 * 1361688331U) ^ 1257453580U);
									continue;
								}
								goto Block_7;
							}
						}
						Block_7:;
					}
				}
				base.HandleBattleEvent<UnitEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202A\u206C\u200C\u206D\u200C\u200B\u202B\u200C\u200F\u200B\u200F\u206A\u200F\u206B\u200B\u206A\u206F\u200B\u202E\u206E\u200B\u200F\u206A\u202A\u206F\u202C\u206C\u206A\u202A\u206F\u200C\u206C\u206C\u202B\u200C\u200B\u200D\u200B\u206B\u206A\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new GameEventHandler<UnitEventArgs>(this.OnEnemySpawned), (GameEventPriority)0);
				base.ReactBattleEvent<UnitEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202A\u200D\u200F\u200C\u200B\u202A\u206F\u200C\u206C\u200F\u200C\u200C\u200D\u202E\u200D\u202D\u200B\u200B\u206D\u200B\u206C\u202B\u206B\u202C\u202E\u206C\u206C\u206A\u202B\u202D\u202B\u206F\u202A\u202E\u206C\u202D\u202D\u206C\u200E\u200F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u202D\u200E\u200E\u200C\u200F\u206C\u200C\u200B\u206A\u202D\u206A\u206A\u200C\u206C\u206D\u200D\u206E\u206A\u200F\u202C\u206B\u206E\u206A\u200B\u200B\u200C\u200C\u202A\u206F\u202B\u206B\u206B\u206E\u200B\u206F\u206F\u206F\u206B\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this))), new EventSequencedReactor<UnitEventArgs>(this.OnPlayerTurnStarting));
				base.HandleBattleEvent<DamageDealingEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202A\u206B\u206A\u202B\u202E\u206E\u206A\u206E\u202D\u206C\u206C\u206B\u206A\u202E\u200D\u202C\u202B\u206D\u206E\u206D\u200F\u206E\u206D\u206D\u200D\u202D\u200E\u206E\u200D\u206C\u202C\u202E\u200C\u200F\u202D\u206D\u200B\u200B\u202A\u202B\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u202D\u200E\u200E\u200C\u200F\u206C\u200C\u200B\u206A\u202D\u206A\u206A\u200C\u206C\u206D\u200D\u206E\u206A\u200F\u202C\u206B\u206E\u206A\u200B\u200B\u200C\u200C\u202A\u206F\u202B\u206B\u206B\u206E\u200B\u206F\u206F\u206F\u206B\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this))), new GameEventHandler<DamageDealingEventArgs>(this.OnPlayerDamageDealing), (GameEventPriority)0);
				base.ReactBattleEvent<CardUsingEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u200E\u200B\u200D\u202B\u206D\u200D\u200E\u206B\u200C\u206F\u206D\u206A\u206A\u206B\u206A\u200F\u206D\u200C\u202C\u206C\u206A\u202C\u200B\u206A\u202C\u200C\u202E\u206F\u206A\u206F\u200C\u200B\u200B\u206A\u200C\u202B\u200B\u200C\u200B\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<CardUsingEventArgs>(this.OnCardUsed));
				base.ReactBattleEvent<CardsEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202C\u206A\u206E\u200F\u206A\u202B\u200D\u200C\u206A\u200B\u202C\u202C\u200F\u202A\u202E\u202C\u200C\u206A\u200C\u200F\u202A\u206D\u206F\u202D\u202C\u200C\u206B\u200F\u200E\u202A\u200C\u200D\u206F\u206F\u206D\u206A\u200E\u202E\u200F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToDiscard));
				base.ReactBattleEvent<CardsEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u206E\u206A\u200B\u200F\u206C\u202C\u206F\u202E\u206F\u200B\u200F\u206E\u202C\u206A\u202D\u200E\u206B\u200D\u200C\u206B\u206A\u206B\u202A\u206C\u200E\u206C\u202B\u202A\u200D\u202C\u206C\u206B\u202B\u206A\u202B\u206F\u206B\u206D\u202C\u206A\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToHand));
				for (;;)
				{
					IL_01C4:
					int num5 = 1412425846;
					for (;;)
					{
						int num2 = num5;
						uint num4;
						switch ((num4 = (uint)((~num2 ^ ~(1151603909 * -121890191) ^ (-1078482944 - -615244388)) * 449783625)) % 3U)
						{
						case 0U:
							goto IL_01C4;
						case 2U:
							base.ReactBattleEvent<CardsEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202C\u202C\u202B\u200E\u200B\u202D\u202A\u202A\u202B\u200B\u200C\u202E\u206B\u202A\u200C\u202A\u200F\u202A\u206A\u206A\u202D\u200E\u202E\u202A\u202E\u202B\u202A\u206A\u200C\u202B\u202E\u202D\u206D\u200D\u206D\u206E\u206E\u206D\u200B\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<CardsEventArgs>(this.OnCardsAddingToExile));
							num5 = (int)((num4 * 2577153608U) ^ 543231097U);
							continue;
						}
						goto Block_2;
					}
				}
				Block_2:
				base.ReactBattleEvent<CardsAddingToDrawZoneEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u200E\u200C\u206A\u206D\u202B\u200C\u200D\u200F\u200D\u200B\u200B\u206E\u200B\u202B\u206D\u202B\u200D\u200D\u206C\u206D\u202A\u202E\u206F\u206F\u202B\u200E\u206E\u206A\u200D\u202E\u202C\u206D\u206C\u202E\u200E\u206D\u206F\u206D\u206F\u202B\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), new EventSequencedReactor<CardsAddingToDrawZoneEventArgs>(this.OnCardsAddingToDrawZone));
			}

			private IEnumerable<BattleAction> OnBattleStarted(GameEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnBattleStarted>d__92 <OnBattleStarted>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnBattleStarted>d__92(-2);
				<OnBattleStarted>d__.<>4__this = this;
				return <OnBattleStarted>d__;
			}

			private IEnumerable<BattleAction> OnEnemyStatusEffectAdded(StatusEffectApplyEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnEnemyStatusEffectAdded>d__93 <OnEnemyStatusEffectAdded>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnEnemyStatusEffectAdded>d__93(-2);
				<OnEnemyStatusEffectAdded>d__.<>4__this = this;
				<OnEnemyStatusEffectAdded>d__.<>3__args = args;
				return <OnEnemyStatusEffectAdded>d__;
			}

			private void OnEnemySpawned(UnitEventArgs args)
			{
				base.ReactBattleEvent<StatusEffectApplyEventArgs>(AyaFriendHatateDef.AyaFriendHatate.\u202C\u206E\u206C\u200C\u206E\u200D\u202B\u202D\u200F\u200C\u206A\u200F\u206B\u200F\u206B\u200C\u206A\u202A\u206C\u200D\u206D\u206E\u200E\u206E\u206F\u206C\u206D\u202A\u200E\u200B\u200C\u202E\u200B\u202A\u200B\u206B\u200E\u202E\u206A\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u206D\u200C\u206C\u202E\u202B\u200C\u206B\u206B\u200C\u200B\u206A\u206E\u200E\u206D\u202C\u200C\u202B\u206D\u200B\u200D\u202D\u206D\u200E\u206A\u200D\u206B\u202D\u200D\u200B\u200C\u200B\u200D\u206F\u202A\u206A\u206C\u206D\u202A\u200F\u202E(args)), new EventSequencedReactor<StatusEffectApplyEventArgs>(this.OnEnemyStatusEffectAdded));
				int? num = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
				for (;;)
				{
					IL_0024:
					int num2 = 1772335194;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(~(uint)(~(num3 ^ (-1766173115 * ~-497912371 + -(~1701270236))) * -1483417955))) % 4U)
						{
						case 1U:
							num2 = (int)(((num.GetValueOrDefault() == 7) ? 2966041320U : 3794298074U) ^ (num4 * 3225328445U));
							continue;
						case 2U:
							this.React(AyaFriendHatateDef.AyaFriendHatate.\u200C\u200F\u206E\u202C\u206E\u200B\u202D\u206A\u206C\u200D\u200E\u200B\u206A\u200E\u206E\u202A\u202B\u206B\u206F\u200C\u202E\u202B\u202E\u206B\u206C\u200B\u206E\u206D\u206B\u202D\u206F\u206D\u202B\u202E\u202C\u202D\u206A\u206B\u200D\u206E\u202E(base.BuffAction<Firepower>(this.Value4, 0, 0, 0, 0f)));
							num2 = (int)((num4 * 3969882300U) ^ 339469987U);
							continue;
						case 3U:
							goto IL_0024;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnPlayerTurnStarting(UnitEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnPlayerTurnStarting>d__95 <OnPlayerTurnStarting>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnPlayerTurnStarting>d__95(-2);
				<OnPlayerTurnStarting>d__.<>4__this = this;
				return <OnPlayerTurnStarting>d__;
			}

			private void OnPlayerDamageDealing(DamageDealingEventArgs args)
			{
				int? num = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
				for (;;)
				{
					IL_0007:
					int num2 = -371410304;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((-num3 * -142151119 - (295319104 ^ -1367180312)) ^ -1889534722)) % 10U)
						{
						case 0U:
							num2 = ((AyaFriendHatateDef.AyaFriendHatate.\u206C\u202E\u206C\u202A\u200D\u202D\u202C\u200D\u200D\u200F\u202D\u200D\u200F\u202C\u206A\u200D\u202A\u202E\u202A\u202C\u200B\u206B\u200F\u200F\u200F\u202B\u206E\u206B\u206C\u202D\u202C\u206C\u202A\u206C\u200C\u206B\u200B\u206F\u206D\u200D\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)).First(delegate(Card c)
							{
								if (c is AyaFriendHatateDef.AyaFriendHatate)
								{
									int? num8;
									for (;;)
									{
										IL_0008:
										int num5 = -80466604;
										for (;;)
										{
											int num6 = num5;
											uint num7;
											switch ((num7 = (uint)(-(~1220582793) - -(uint)num6)) % 4U)
											{
											case 1U:
												goto IL_0049;
											case 2U:
												num8 = AyaFriendHatateDef.AyaFriendHatate.<>c.\u206E\u200D\u206D\u200D\u200D\u206E\u206B\u206C\u200B\u200D\u202A\u202B\u200C\u206E\u202B\u202E\u200E\u200F\u202A\u200B\u202B\u202C\u206E\u200E\u200B\u202E\u206A\u202E\u206B\u206F\u200B\u200C\u206E\u200B\u206A\u200E\u206B\u200C\u200D\u200F\u202E(c);
												num5 = (int)((num7 * 2752501902U) ^ 2185438571U);
												continue;
											case 3U:
												goto IL_0008;
											}
											goto Block_1;
										}
									}
									Block_1:
									return false;
									IL_0049:
									return num8.GetValueOrDefault() == 19;
								}
								return false;
							}) == this) ? (-424489369) : 1610587601);
							continue;
						case 1U:
							AyaFriendHatateDef.AyaFriendHatate.\u200E\u206F\u202C\u202D\u206C\u200B\u200C\u202A\u202D\u206D\u202E\u200C\u206D\u206A\u202E\u202E\u206D\u200C\u202D\u200B\u206F\u202B\u206B\u206B\u200B\u206E\u206D\u200B\u202C\u202B\u200D\u202E\u202D\u206F\u202A\u206E\u202A\u206F\u200B\u206C\u202E(args, AyaFriendHatateDef.AyaFriendHatate.\u206F\u206D\u200B\u200B\u206C\u206D\u202E\u206D\u202D\u200C\u202D\u206A\u202E\u200E\u200E\u206C\u200C\u206D\u206B\u206A\u202C\u202B\u200E\u202E\u206D\u200C\u202D\u202E\u206C\u202E\u200E\u206A\u206E\u202E\u202A\u202E\u206A\u206C\u202D\u202A\u202E(args).MultiplyBy(2));
							num2 = (int)((num4 * 3304500613U) ^ 1946114710U);
							continue;
						case 2U:
							num2 = (int)(((!AyaFriendHatateDef.AyaFriendHatate.\u200E\u202B\u202E\u206F\u206F\u206C\u206C\u202E\u200B\u200C\u200E\u200E\u202C\u202E\u202C\u200D\u200D\u200B\u200E\u206F\u200B\u202C\u202D\u202A\u206C\u200E\u206C\u200F\u202A\u202C\u200E\u206C\u202B\u202A\u200F\u206E\u206D\u202E\u206E\u206B\u202E(this)) ? 2550287249U : 3945531301U) ^ (num4 * 2787718352U));
							continue;
						case 3U:
							AyaFriendHatateDef.AyaFriendHatate.\u200C\u206A\u202A\u200B\u206F\u206C\u206C\u206C\u206A\u206F\u206E\u206A\u200D\u206F\u200E\u206B\u202D\u202D\u202E\u206B\u200B\u206C\u206F\u202A\u200B\u200F\u200E\u202A\u206A\u200E\u206B\u206A\u202A\u202A\u206D\u202D\u206C\u206C\u202B\u202A\u202E(args, this);
							num2 = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u202C\u200E\u202E\u202D\u200F\u202D\u202D\u200D\u200F\u200B\u202E\u206C\u202D\u206A\u206B\u202A\u206F\u200D\u202A\u202B\u206C\u200D\u202E\u202C\u206B\u206B\u206D\u202E\u206B\u202E\u200E\u202E\u200E\u202B\u202A\u202D\u206C\u202C\u206F\u206A\u202E(args) == ActionCause.OnlyCalculate) ? 1698723309U : 523873776U) ^ (num4 * 3673629580U));
							continue;
						case 4U:
							num2 = (int)(((!(AyaFriendHatateDef.AyaFriendHatate.\u200E\u202A\u206D\u200F\u202B\u202B\u206A\u202D\u200D\u202E\u206D\u206F\u200E\u206C\u206D\u202E\u206D\u206C\u206E\u202A\u206E\u206C\u206B\u202B\u206E\u200F\u200E\u206A\u206D\u200D\u206E\u206E\u200B\u202E\u206E\u200E\u206B\u200D\u202A\u206F\u202E(args) is AyaNews)) ? 2907083089U : 1343618232U) ^ (num4 * 3112367984U));
							continue;
						case 5U:
							num2 = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u206F\u202B\u200F\u206D\u206D\u202C\u206B\u206B\u206D\u202D\u200D\u200C\u202A\u206B\u200C\u200B\u206E\u200C\u206D\u206A\u200F\u202D\u200E\u206B\u206F\u206F\u202A\u206D\u202E\u202C\u206C\u202A\u206E\u202A\u202D\u202C\u202B\u206D\u200D\u200C\u202E(this) == CardZone.Hand) ? 827744782U : 88482477U) ^ (num4 * 1253174828U));
							continue;
						case 6U:
							this.\u206A\u206C\u202E\u202A\u202B\u202C\u202A\u202B\u200F\u206B\u206B\u202E\u206E\u202D\u200F\u200D\u200C\u200C\u202B\u206D\u202D\u200F\u202E\u202A\u206A\u206F\u206B\u202A\u202C\u200B\u206D\u206F\u202C\u200F\u206A\u202B\u202E\u206C\u202E\u206D\u202E();
							num2 = (int)((num4 * 3025132948U) ^ 22717753U);
							continue;
						case 8U:
							num2 = (int)(((num.GetValueOrDefault() == 19) ? 3057325480U : 612026839U) ^ (num4 * 2407414737U));
							continue;
						case 9U:
							goto IL_0007;
						}
						return;
					}
				}
			}

			private IEnumerable<BattleAction> OnCardUsed(CardUsingEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnCardUsed>d__97 <OnCardUsed>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnCardUsed>d__97(-2);
				<OnCardUsed>d__.<>4__this = this;
				<OnCardUsed>d__.<>3__args = args;
				return <OnCardUsed>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToDiscard(CardsEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToDiscard>d__98 <OnCardsAddingToDiscard>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToDiscard>d__98(-2);
				<OnCardsAddingToDiscard>d__.<>4__this = this;
				<OnCardsAddingToDiscard>d__.<>3__args = args;
				return <OnCardsAddingToDiscard>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToHand(CardsEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToHand>d__99 <OnCardsAddingToHand>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToHand>d__99(-2);
				<OnCardsAddingToHand>d__.<>4__this = this;
				<OnCardsAddingToHand>d__.<>3__args = args;
				return <OnCardsAddingToHand>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToExile(CardsEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToExile>d__100 <OnCardsAddingToExile>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToExile>d__100(-2);
				<OnCardsAddingToExile>d__.<>4__this = this;
				<OnCardsAddingToExile>d__.<>3__args = args;
				return <OnCardsAddingToExile>d__;
			}

			private IEnumerable<BattleAction> OnCardsAddingToDrawZone(CardsAddingToDrawZoneEventArgs args)
			{
				AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToDrawZone>d__101 <OnCardsAddingToDrawZone>d__ = new AyaFriendHatateDef.AyaFriendHatate.<OnCardsAddingToDrawZone>d__101(-2);
				<OnCardsAddingToDrawZone>d__.<>4__this = this;
				<OnCardsAddingToDrawZone>d__.<>3__args = args;
				return <OnCardsAddingToDrawZone>d__;
			}

			private void OnPlayerStatisticalDamageDealt(StatisticalDamageEventArgs args)
			{
				bool flag = false;
				int num4;
				for (;;)
				{
					IL_0002:
					int num = 311821010;
					for (;;)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 3U)
						{
						case 0U:
							goto IL_0002;
						case 1U:
							num4 = 0;
							num = (int)((num3 * 3593507096U) ^ 2003975948U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				IEnumerator<KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>>> enumerator = AyaFriendHatateDef.AyaFriendHatate.\u206E\u202B\u200E\u200E\u200F\u206E\u206F\u206B\u206E\u206D\u206A\u202A\u206E\u202E\u206C\u202E\u202D\u206B\u202B\u200C\u200C\u200D\u206F\u206F\u206B\u206D\u206B\u206B\u202D\u200B\u206D\u202E\u202D\u206F\u202A\u202C\u202D\u206E\u206C\u202C\u202E(args).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0256:
						Unit unit2;
						if (AyaFriendHatateDef.AyaFriendHatate.\u200F\u206B\u202B\u206F\u202E\u206B\u202E\u206C\u200B\u200B\u202E\u200B\u206B\u200C\u202C\u200B\u200E\u206B\u200D\u200B\u200C\u200F\u202B\u206D\u206C\u200E\u206C\u200C\u206E\u200B\u200B\u200F\u202E\u206E\u200F\u200F\u206D\u206E\u202C\u206D\u202E(enumerator))
						{
							Unit unit;
							IReadOnlyList<DamageEventArgs> readOnlyList;
							for (;;)
							{
								IL_009D:
								KeyValuePair<Unit, IReadOnlyList<DamageEventArgs>> keyValuePair = enumerator.Current;
								int num5 = 1712465894;
								for (;;)
								{
									int num2 = num5;
									uint num3;
									switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 4U)
									{
									case 1U:
										goto IL_009D;
									case 2U:
										keyValuePair.Deconstruct(out unit, out readOnlyList);
										num5 = (int)((num3 * 2123028574U) ^ 2934699948U);
										continue;
									case 3U:
										num5 = 1567217017;
										continue;
									}
									goto Block_4;
								}
							}
							IL_00C6:
							unit2 = unit;
							IEnumerator<DamageEventArgs> enumerator2 = (from ags in readOnlyList
								where AyaFriendHatateDef.AyaFriendHatate.<>c.\u200D\u206A\u200E\u206B\u206D\u200E\u206F\u206A\u202E\u200D\u206B\u202E\u200C\u202D\u206B\u200D\u206A\u206D\u202D\u200E\u206A\u202D\u200C\u206A\u206C\u202C\u202B\u206C\u200B\u202C\u206A\u202B\u200D\u200B\u206A\u206F\u202A\u206E\u200C\u200C\u202E(ags).DamageType == DamageType.Attack
								select ags into amount
								where AyaFriendHatateDef.AyaFriendHatate.<>c.\u200D\u206A\u200E\u206B\u206D\u200E\u206F\u206A\u202E\u200D\u206B\u202E\u200C\u202D\u206B\u200D\u206A\u206D\u202D\u200E\u206A\u202D\u200C\u206A\u206C\u202C\u202B\u206C\u200B\u202C\u206A\u202B\u200D\u200B\u206A\u206F\u202A\u206E\u200C\u200C\u202E(amount).Damage > 0f
								select amount).GetEnumerator();
							try
							{
								for (;;)
								{
									IL_015F:
									int num6 = ((!AyaFriendHatateDef.AyaFriendHatate.\u200F\u206B\u202B\u206F\u202E\u206B\u202E\u206C\u200B\u200B\u202E\u200B\u206B\u200C\u202C\u200B\u200E\u206B\u200D\u200B\u200C\u200F\u202B\u206D\u206C\u200E\u206C\u200C\u206E\u200B\u200B\u200F\u202E\u206E\u200F\u200F\u206D\u206E\u202C\u206D\u202E(enumerator2)) ? 527735484 : (-1928468107));
									for (;;)
									{
										int num2 = num6;
										uint num3;
										switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 5U)
										{
										case 0U:
										{
											DamageEventArgs damageEventArgs;
											num4 += AyaFriendHatateDef.AyaFriendHatate.\u206D\u200F\u206F\u206B\u200F\u202D\u206F\u200E\u200F\u206F\u206F\u200F\u202B\u206C\u202A\u206C\u206C\u200B\u206E\u202B\u202C\u206A\u200F\u202E\u206E\u202B\u206F\u202E\u200E\u206B\u200E\u202D\u206A\u206F\u200E\u206B\u206B\u200C\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u206B\u206B\u200C\u200F\u202D\u200F\u202E\u206A\u206B\u206F\u202C\u200D\u200E\u200E\u202C\u206C\u200D\u202E\u202A\u202A\u200E\u202C\u202B\u202E\u202B\u200D\u200C\u206B\u206D\u202D\u206A\u202C\u200E\u202A\u202E\u206E\u202E\u206E\u206B\u206A\u202E(damageEventArgs).Damage);
											num6 = (int)((num3 * 1938431548U) ^ 63571311U);
											continue;
										}
										case 2U:
											num6 = -1928468107;
											continue;
										case 3U:
										{
											DamageEventArgs damageEventArgs = enumerator2.Current;
											num6 = -1429878584;
											continue;
										}
										case 4U:
											goto IL_015F;
										}
										goto Block_12;
									}
								}
								Block_12:;
							}
							finally
							{
								if (enumerator2 != null)
								{
									for (;;)
									{
										IL_01BA:
										int num7 = -187286429;
										for (;;)
										{
											int num2 = num7;
											uint num3;
											switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 3U)
											{
											case 0U:
												goto IL_01BA;
											case 1U:
												AyaFriendHatateDef.AyaFriendHatate.\u200E\u200D\u206C\u202B\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200F\u200F\u206B\u206C\u202C\u206F\u202B\u200F\u206C\u202C\u200C\u200B\u206E\u202D\u202B\u200B\u202A\u200C\u206F\u206B\u206B\u206F\u202A\u202D\u200B\u202B\u206F\u202D\u202E(enumerator2);
												num7 = (int)((num3 * 112391980U) ^ 1205023874U);
												continue;
											}
											goto Block_15;
										}
									}
									Block_15:;
								}
							}
							if (num4 > 0)
							{
								goto IL_0210;
							}
							continue;
							Block_4:
							goto IL_00C6;
						}
						int num8 = -750838595;
						for (;;)
						{
							IL_0215:
							int num2 = num8;
							uint num3;
							switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 6U)
							{
							case 0U:
								goto IL_0210;
							case 1U:
								this.React(AyaFriendHatateDef.AyaFriendHatate.\u200C\u200F\u206E\u202C\u206E\u200B\u202D\u206A\u206C\u200D\u200E\u200B\u206A\u200E\u206E\u202A\u202B\u206B\u206F\u200C\u202E\u202B\u202E\u206B\u206C\u200B\u206E\u206D\u206B\u202D\u206F\u206D\u202B\u202E\u202C\u202D\u206A\u206B\u200D\u206E\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u206B\u200E\u200B\u206D\u202E\u206A\u202C\u206B\u202D\u200E\u200C\u206D\u206C\u202B\u206F\u200D\u200F\u200E\u202D\u206D\u206A\u206A\u200D\u200E\u200B\u202B\u202D\u202D\u206A\u200C\u206E\u206F\u206B\u200F\u206F\u200D\u200E\u206C\u206B\u202E(unit2, AyaFriendHatateDef.AyaFriendHatate.\u200D\u202D\u200E\u200E\u200C\u200F\u206C\u200C\u200B\u206A\u202D\u206A\u206A\u200C\u206C\u206D\u200D\u206E\u206A\u200F\u202C\u206B\u206E\u206A\u200B\u200B\u200C\u200C\u202A\u206F\u202B\u206B\u206B\u206E\u200B\u206F\u206F\u206F\u206B\u206F\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this)), num4, HealType.Vampire, 0.1f)));
								num8 = (int)((num3 * 3890884812U) ^ 3267688985U);
								continue;
							case 2U:
								flag = true;
								num8 = (int)((num3 * 1206084580U) ^ 2728477907U);
								continue;
							case 4U:
								num8 = (int)(((!flag) ? 3915951504U : 3721581963U) ^ (num3 * 3155320335U));
								continue;
							case 5U:
								goto IL_0256;
							}
							goto Block_8;
						}
						IL_0210:
						num8 = 271341858;
						goto IL_0215;
					}
					Block_8:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_02D6:
							int num9 = -466778404;
							for (;;)
							{
								int num2 = num9;
								uint num3;
								switch ((num3 = (uint)((~(num2 * -916613109) ^ (-915035501 - -2000585692)) * 114785439)) % 3U)
								{
								case 1U:
									AyaFriendHatateDef.AyaFriendHatate.\u200E\u200D\u206C\u202B\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200F\u200F\u206B\u206C\u202C\u206F\u202B\u200F\u206C\u202C\u200C\u200B\u206E\u202D\u202B\u200B\u202A\u200C\u206F\u206B\u206B\u206F\u202A\u202D\u200B\u202B\u206F\u202D\u202E(enumerator);
									num9 = (int)((num3 * 418456234U) ^ 1797796153U);
									continue;
								case 2U:
									goto IL_02D6;
								}
								goto Block_17;
							}
						}
						Block_17:;
					}
				}
			}

			public override IEnumerable<BattleAction> OnTurnEndingInHand()
			{
				int? num = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
				for (;;)
				{
					IL_0007:
					int num2 = -2111294436;
					for (;;)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(~(uint)(~(uint)(~(uint)(num3 ^ (~(-1925454026) + --1657233893 * 1786843795)))))) % 5U)
						{
						case 0U:
							goto IL_0007;
						case 1U:
							if (num.GetValueOrDefault() == 17)
							{
								num2 = (int)((num4 * 556547267U) ^ 3760500599U);
								continue;
							}
							goto IL_019A;
						case 2U:
							if (AyaFriendHatateDef.AyaFriendHatate.\u200E\u202B\u202E\u206F\u206F\u206C\u206C\u202E\u200B\u200C\u200E\u200E\u202C\u202E\u202C\u200D\u200D\u200B\u200E\u206F\u200B\u202C\u202D\u202A\u206C\u200E\u206C\u200F\u202A\u202C\u200E\u206C\u202B\u202A\u200F\u206E\u206D\u202E\u206E\u206B\u202E(this))
							{
								num2 = (int)((num4 * 1623506922U) ^ 3191074131U);
								continue;
							}
							goto IL_019A;
						case 3U:
							if (AyaFriendHatateDef.AyaFriendHatate.\u206F\u202B\u200F\u206D\u206D\u202C\u206B\u206B\u206D\u202D\u200D\u200C\u202A\u206B\u200C\u200B\u206E\u200C\u206D\u206A\u200F\u202D\u200E\u206B\u206F\u206F\u202A\u206D\u202E\u202C\u206C\u202A\u206E\u202A\u202D\u202C\u202B\u206D\u200D\u200C\u202E(this) == CardZone.Hand)
							{
								num2 = (int)((num4 * 1999952231U) ^ 771541305U);
								continue;
							}
							goto IL_019A;
						}
						goto Block_1;
					}
				}
				Block_1:
				IEnumerator<Card> enumerator = (from card in AyaFriendHatateDef.AyaFriendHatate.\u206C\u202E\u206C\u202A\u200D\u202D\u202C\u200D\u200D\u200F\u202D\u200D\u200F\u202C\u206A\u200D\u202A\u202E\u202A\u202C\u200B\u206B\u200F\u200F\u200F\u202B\u206E\u206B\u206C\u202D\u202C\u206C\u202A\u206C\u200C\u206B\u200B\u206F\u206D\u200D\u202E(AyaFriendHatateDef.AyaFriendHatate.\u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(this))
					where AyaFriendHatateDef.AyaFriendHatate.<>c.\u200B\u200C\u202B\u206A\u202B\u206C\u200D\u200B\u200D\u200B\u202A\u200F\u202B\u200B\u200B\u206D\u202A\u200F\u206E\u202D\u200F\u200E\u202E\u206C\u200E\u206E\u202E\u202E\u202D\u206E\u206A\u202E\u200C\u202D\u200D\u200E\u200E\u206F\u206E\u200F\u202E(card) == CardType.Friend
					select card).GetEnumerator();
				try
				{
					for (;;)
					{
						IL_0130:
						int num5 = (AyaFriendHatateDef.AyaFriendHatate.\u200F\u206B\u202B\u206F\u202E\u206B\u202E\u206C\u200B\u200B\u202E\u200B\u206B\u200C\u202C\u200B\u200E\u206B\u200D\u200B\u200C\u200F\u202B\u206D\u206C\u200E\u206C\u200C\u206E\u200B\u200B\u200F\u202E\u206E\u200F\u200F\u206D\u206E\u202C\u206D\u202E(enumerator) ? (-1862899658) : (-926899604));
						for (;;)
						{
							int num3 = num5;
							switch (~(~(~(num3 ^ (~(-1925454026) + --1657233893 * 1786843795)))) % 4)
							{
							case 0:
								goto IL_0130;
							case 1:
							{
								Card card2 = enumerator.Current;
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202D\u206E\u200C\u206E\u206F\u202C\u206B\u206D\u206D\u206F\u200B\u202A\u202A\u202D\u200B\u200F\u200D\u206C\u206F\u200F\u200E\u206D\u202E\u200C\u202B\u200D\u206D\u202C\u202B\u206B\u202D\u202D\u206D\u206A\u202E\u202B\u200B\u206F\u200F\u202E(card2);
								AyaFriendHatateDef.AyaFriendHatate.\u202D\u200B\u206D\u206A\u206C\u206C\u200E\u202E\u202A\u200C\u206C\u206D\u200C\u206D\u200E\u202E\u200D\u206A\u200E\u200F\u206B\u206F\u200D\u206D\u206A\u202E\u200E\u202A\u200C\u200C\u206E\u206D\u202B\u206A\u206E\u206E\u206F\u206F\u206D\u200F\u202E(card2, AyaFriendHatateDef.AyaFriendHatate.\u200C\u202E\u206E\u202D\u200C\u206C\u200E\u200B\u206E\u206D\u200E\u202E\u206B\u200C\u202D\u200D\u206B\u206F\u206D\u206D\u200E\u200D\u206D\u206B\u202A\u202B\u202B\u206D\u202A\u206E\u206A\u206E\u206F\u206B\u206A\u206E\u200D\u202A\u206C\u202E(card2) + this.Value4);
								num5 = -214187633;
								continue;
							}
							case 2:
								num5 = -1862899658;
								continue;
							}
							goto Block_8;
						}
					}
					Block_8:;
				}
				finally
				{
					if (enumerator != null)
					{
						for (;;)
						{
							IL_014E:
							int num6 = -666139024;
							for (;;)
							{
								int num3 = num6;
								uint num4;
								switch ((num4 = (uint)(~(uint)(~(uint)(~(uint)(num3 ^ (~(-1925454026) + --1657233893 * 1786843795)))))) % 3U)
								{
								case 1U:
									AyaFriendHatateDef.AyaFriendHatate.\u200E\u200D\u206C\u202B\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200F\u200F\u206B\u206C\u202C\u206F\u202B\u200F\u206C\u202C\u200C\u200B\u206E\u202D\u202B\u200B\u202A\u200C\u206F\u206B\u206B\u206F\u202A\u202D\u200B\u202B\u206F\u202D\u202E(enumerator);
									num6 = (int)((num4 * 3232525743U) ^ 1740231343U);
									continue;
								case 2U:
									goto IL_014E;
								}
								goto Block_11;
							}
						}
						Block_11:;
					}
				}
				IL_019A:
				return AyaFriendHatateDef.AyaFriendHatate.\u200D\u206B\u206D\u206C\u206A\u200C\u202C\u206E\u200E\u202C\u200D\u202B\u200E\u206C\u206B\u200B\u206D\u202A\u206F\u200F\u202B\u202A\u206A\u202D\u200E\u206B\u206F\u202C\u206D\u206C\u206B\u206A\u206E\u202A\u206D\u202D\u206F\u206A\u206F\u206A\u202E(this);
			}

			public override IEnumerable<BattleAction> GetPassiveActions()
			{
				AyaFriendHatateDef.AyaFriendHatate.<GetPassiveActions>d__104 <GetPassiveActions>d__ = new AyaFriendHatateDef.AyaFriendHatate.<GetPassiveActions>d__104(-2);
				<GetPassiveActions>d__.<>4__this = this;
				return <GetPassiveActions>d__;
			}

			public override Interaction Precondition()
			{
				if (AyaFriendHatateDef.AyaFriendHatate.\u206D\u206E\u200B\u206C\u202E\u206A\u206B\u202E\u202B\u206D\u200D\u202C\u206F\u206E\u202C\u200D\u200F\u206E\u200E\u202B\u206F\u200B\u206B\u202D\u202A\u200B\u206A\u206E\u206B\u202E\u202A\u200C\u206C\u200B\u206B\u202D\u206B\u202D\u206E\u206C\u202E(this) == CardType.Friend)
				{
					List<Card> list;
					for (;;)
					{
						IL_000C:
						int num = 1966196455;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-1254934814 - (-(~num2) ^ (1821274395 - -1938543159)))) % 57U)
							{
							case 0U:
								num = (int)((num3 * 3680369882U) ^ 366652614U);
								continue;
							case 2U:
								goto IL_01EE;
							case 3U:
								goto IL_05CF;
							case 4U:
								num = (int)((num3 * 1267703168U) ^ 3910752484U);
								continue;
							case 5U:
								goto IL_0519;
							case 6U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 2596976762U) ^ 2219353796U);
								continue;
							case 7U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(22));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 3585550522U) ^ 3458842144U);
								continue;
							case 8U:
								num = (int)(((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -this.FriendU3.Cost) ? 3036490923U : 1524972271U) ^ (num3 * 1333084237U));
								continue;
							case 9U:
								num = (int)((num3 * 799481451U) ^ 2414720898U);
								continue;
							case 10U:
								goto IL_05A4;
							case 11U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(21));
								num = (int)((num3 * 4155259801U) ^ 3284458670U);
								continue;
							case 12U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(12));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 30623754U) ^ 2953858259U);
								continue;
							case 13U:
								num = (int)((num3 * 1132917091U) ^ 851983246U);
								continue;
							case 14U:
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 1651901584U) ^ 2581791924U);
								continue;
							case 15U:
							{
								int? num4;
								num = (int)(((num4 == null) ? 3699276584U : 3994348275U) ^ (num3 * 2456669802U));
								continue;
							}
							case 16U:
								num = (int)((num3 * 1901218186U) ^ 3158979898U);
								continue;
							case 17U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 1077157874U) ^ 2722107140U);
								continue;
							case 18U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(14));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 2971350896U) ^ 1774981918U);
								continue;
							case 19U:
								list = new List<Card>();
								num = (int)((num3 * 1946562083U) ^ 637821121U);
								continue;
							case 20U:
								goto IL_000C;
							case 21U:
								num = (int)((num3 * 3000820919U) ^ 3865264259U);
								continue;
							case 22U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(8));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 3264561023U) ^ 3214386436U);
								continue;
							case 23U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(23));
								num = (int)((num3 * 355812322U) ^ 766609769U);
								continue;
							case 24U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(20));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 3616377780U) ^ 3672985774U);
								continue;
							case 25U:
								goto IL_0263;
							case 26U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(13));
								num = (int)((num3 * 2479021383U) ^ 2789512444U);
								continue;
							case 27U:
							{
								int valueOrDefault;
								switch (valueOrDefault)
								{
								case -1:
								case 0:
								case 1:
								case 2:
								case 3:
								case 4:
								case 5:
								case 6:
								case 7:
								case 10:
								case 15:
								case 17:
								case 18:
								case 19:
								case 25:
								case 26:
									goto IL_068F;
								case 8:
									goto IL_086D;
								case 9:
									goto IL_0219;
								case 11:
									goto IL_0263;
								case 12:
									goto IL_0788;
								case 13:
									goto IL_05A4;
								case 14:
									goto IL_03CE;
								case 16:
									goto IL_03A3;
								case 20:
									goto IL_04AA;
								case 21:
									goto IL_01EE;
								case 22:
									goto IL_08C8;
								case 23:
									goto IL_0519;
								case 24:
									goto IL_0706;
								default:
									num = (int)((num3 * 1755992393U) ^ 2243618143U);
									continue;
								}
								break;
							}
							case 28U:
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 270474732U) ^ 4158913612U);
								continue;
							case 29U:
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 1361848927U) ^ 2611567935U);
								continue;
							case 30U:
								num = (int)((num3 * 4177485057U) ^ 4121768523U);
								continue;
							case 31U:
								goto IL_04AA;
							case 32U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(0));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 823058436U) ^ 1266150512U);
								continue;
							case 33U:
								goto IL_0706;
							case 34U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(11));
								num = (int)((num3 * 2080191154U) ^ 559127041U);
								continue;
							case 35U:
								num = (int)((num3 * 3077763190U) ^ 1056476674U);
								continue;
							case 36U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 1648190617U) ^ 1473240386U);
								continue;
							case 37U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 1591693900U) ^ 2440469484U);
								continue;
							case 38U:
								goto IL_03CE;
							case 39U:
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 1247742155U) ^ 77214079U);
								continue;
							case 40U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 939784227U) ^ 3076852573U);
								continue;
							case 41U:
								goto IL_0788;
							case 42U:
								goto IL_068F;
							case 43U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(16));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 3812451634U) ^ 3358051766U);
								continue;
							case 44U:
							{
								int? num4 = AyaFriendHatateDef.AyaFriendHatate.\u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(this);
								num = 1216990149;
								continue;
							}
							case 45U:
								goto IL_086D;
							case 46U:
								goto IL_08C8;
							case 47U:
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(9));
								num = (int)((num3 * 767824915U) ^ 325387555U);
								continue;
							case 48U:
							{
								int? num4;
								int valueOrDefault = num4.GetValueOrDefault();
								num = (int)((num3 * 3253539831U) ^ 343301240U);
								continue;
							}
							case 49U:
								num = (int)((AyaFriendHatateDef.AyaFriendHatate.\u200E\u202B\u202E\u206F\u206F\u206C\u206C\u202E\u200B\u200C\u200E\u200E\u202C\u202E\u202C\u200D\u200D\u200B\u200E\u206F\u200B\u202C\u202D\u202A\u206C\u200E\u206C\u200F\u202A\u202C\u200E\u206C\u202B\u202A\u200F\u206E\u206D\u202E\u206E\u206B\u202E(this) ? 64967004U : 56602850U) ^ (num3 * 982675626U));
								continue;
							case 50U:
								goto IL_03A3;
							case 51U:
								num = (int)((num3 * 3404963223U) ^ 3029807224U);
								continue;
							case 52U:
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Active);
								num = (int)((num3 * 171277991U) ^ 4066981664U);
								continue;
							case 53U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 1531672398U) ^ 1814863142U);
								continue;
							case 54U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								AyaFriendHatateDef.AyaFriendHatate.\u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(list.Last<Card>(), new int?(24));
								AyaFriendHatateDef.AyaFriendHatate.\u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(list.Last<Card>(), FriendToken.Ultimate);
								num = (int)((num3 * 942315250U) ^ 293690406U);
								continue;
							case 55U:
								goto IL_0219;
							case 56U:
								list.AddRange(AyaFriendHatateDef.AyaFriendHatate.\u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(this, 1, false));
								num = (int)((num3 * 1034430879U) ^ 1845777673U);
								continue;
							}
							goto Block_1;
							IL_01EE:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(this).Cost) ? (-1917156681) : (-1209496732));
							continue;
							IL_0219:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) < -AyaFriendHatateDef.AyaFriendHatate.\u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(this).Cost) ? (-1209496732) : (-1531958002));
							continue;
							IL_0263:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u202C\u200C\u206A\u202B\u206A\u202D\u200F\u202D\u206B\u200C\u202D\u206C\u200F\u200F\u200D\u202A\u206F\u202D\u206C\u206C\u206A\u202E\u202E\u206D\u206A\u200D\u206C\u202A\u202A\u202A\u200D\u206B\u202E\u202E\u200F\u202E\u206E\u200D\u202A\u202E\u202E(this).Cost) ? 1318281044 : (-1209496732));
							continue;
							IL_03A3:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -this.FriendU2.Cost) ? (-1632132130) : (-1209496732));
							continue;
							IL_03CE:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u202C\u200C\u206A\u202B\u206A\u202D\u200F\u202D\u206B\u200C\u202D\u206C\u200F\u200F\u200D\u202A\u206F\u202D\u206C\u206C\u206A\u202E\u202E\u206D\u206A\u200D\u206C\u202A\u202A\u202A\u200D\u206B\u202E\u202E\u200F\u202E\u206E\u200D\u202A\u202E\u202E(this).Cost) ? (-2052395492) : (-1209496732));
							continue;
							IL_04AA:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) < -this.FriendU2.Cost) ? (-1209496732) : (-1779444568));
							continue;
							IL_0519:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -this.FriendU3.Cost) ? 2047015169 : (-1209496732));
							continue;
							IL_05A4:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(this).Cost) ? 2092290839 : (-1209496732));
							continue;
							IL_068F:
							num = ((list.Count <= 0) ? (-1204644750) : (-1614398376));
							continue;
							IL_0706:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) < -this.FriendU2.Cost) ? (-1209496732) : 1942815786);
							continue;
							IL_0788:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(this).Cost) ? (-582041782) : (-1209496732));
							continue;
							IL_086D:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u206D\u202B\u206F\u200D\u206A\u202B\u206A\u202B\u200C\u206A\u206A\u202B\u202D\u200E\u206D\u206C\u202A\u206B\u206D\u206B\u200F\u202E\u200D\u206C\u200B\u200E\u202C\u200B\u206E\u202D\u202D\u206B\u200F\u202A\u200C\u200C\u206D\u200B\u206F\u206C\u202E(this).Cost) ? (-1167374796) : (-1209496732));
							continue;
							IL_08C8:
							num = ((AyaFriendHatateDef.AyaFriendHatate.\u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(this) >= -AyaFriendHatateDef.AyaFriendHatate.\u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(this).Cost) ? 1328045396 : (-1209496732));
						}
					}
					Block_1:
					goto IL_096A;
					IL_05CF:
					return AyaFriendHatateDef.AyaFriendHatate.\u202C\u200D\u202B\u206B\u202E\u206A\u200E\u202D\u202B\u206A\u200D\u200D\u200C\u206F\u200D\u206C\u206A\u200D\u206F\u202A\u206C\u202C\u202B\u200E\u202E\u206A\u206D\u202D\u200F\u206C\u200F\u200F\u206A\u206F\u206A\u200D\u200B\u202C\u200F\u202E\u202E(list, false, false, false);
				}
				IL_096A:
				return null;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendHatateDef.AyaFriendHatate.<Actions>d__106 <Actions>d__ = new AyaFriendHatateDef.AyaFriendHatate.<Actions>d__106(-2);
				<Actions>d__.<>4__this = this;
				<Actions>d__.<>3__precondition = precondition;
				return <Actions>d__;
			}

			static int? \u206A\u200E\u202A\u200B\u206A\u206F\u206C\u200B\u206D\u202E\u206D\u206D\u202E\u202C\u206F\u200F\u206D\u200D\u200E\u202C\u200C\u202E\u202A\u206A\u202D\u202A\u202A\u200E\u206C\u206E\u202C\u202C\u206A\u206A\u206D\u200E\u202C\u206A\u206F\u202E\u202E(Card A_0)
			{
				return A_0.DeckCounter;
			}

			static int \u202B\u206C\u200D\u202A\u206B\u202D\u200C\u206E\u202A\u206B\u200B\u206C\u200D\u206F\u202B\u202B\u206A\u206B\u200F\u202A\u202A\u200F\u206D\u202A\u202D\u200C\u200F\u202A\u206C\u206F\u200C\u200C\u206B\u202B\u206E\u206B\u200B\u200C\u206F\u200D\u202E(Card A_0)
			{
				return A_0.RawDamage;
			}

			static DamageInfo \u202D\u202D\u202E\u200F\u206B\u206B\u206B\u200B\u200D\u202A\u206D\u202B\u202D\u200C\u200B\u206A\u200E\u202B\u202D\u202A\u206E\u200C\u202D\u202A\u206A\u202D\u200F\u206F\u206F\u202E\u206E\u200E\u202E\u206C\u200C\u206B\u206E\u200D\u200B\u200F\u202E(Card A_0)
			{
				return A_0.Damage;
			}

			static int \u206C\u206D\u206D\u202C\u206A\u200F\u206D\u206A\u202B\u200F\u200C\u206B\u206D\u200D\u200F\u206C\u200E\u200F\u200F\u206C\u206A\u206E\u206C\u202B\u202B\u202D\u206B\u200E\u200C\u206B\u202D\u206F\u206C\u200C\u202E\u202B\u200F\u202D\u202E\u202A\u202E(float A_0)
			{
				return A_0.RoundToInt();
			}

			static CardConfig \u200F\u206C\u200E\u202B\u200F\u202E\u206C\u206B\u200C\u206A\u206F\u200E\u206B\u200B\u206D\u202A\u206D\u206E\u200F\u202B\u202A\u206B\u202C\u206B\u202C\u200B\u206D\u200C\u202B\u202E\u202D\u206F\u200F\u200C\u202B\u202C\u206E\u202A\u202C\u202E\u202E(Card A_0)
			{
				return A_0.Config;
			}

			static bool \u206A\u200B\u202B\u206A\u202A\u206C\u206C\u206C\u206D\u202B\u206B\u206B\u206E\u202E\u200E\u202A\u200D\u206F\u206C\u206C\u202C\u200E\u206F\u202E\u202B\u200E\u206D\u202A\u206C\u206C\u202E\u202E\u202E\u202B\u202E\u200E\u206A\u202A\u206D\u200C\u202E(CardConfig A_0)
			{
				return A_0.EmptyDescription;
			}

			static CardType \u206D\u206E\u200B\u206C\u202E\u206A\u206B\u202E\u202B\u206D\u200D\u202C\u206F\u206E\u202C\u200D\u200F\u206E\u200E\u202B\u206F\u200B\u206B\u202D\u202A\u200B\u206A\u206E\u206B\u202E\u202A\u200C\u206C\u200B\u206B\u202D\u206B\u202D\u206E\u206C\u202E(Card A_0)
			{
				return A_0.CardType;
			}

			static FriendToken \u206A\u202C\u200D\u200E\u200B\u200D\u200D\u200B\u206F\u206B\u206E\u202E\u206E\u202B\u206B\u200E\u200D\u202E\u202A\u200C\u206C\u206D\u202A\u206F\u206C\u206C\u206E\u202B\u202C\u202B\u206B\u202E\u202E\u200C\u200C\u202B\u206B\u206D\u206B\u202B\u202E(Card A_0)
			{
				return A_0.FriendToken;
			}

			static bool \u200F\u200D\u206A\u202E\u200C\u206F\u200D\u206A\u202E\u206A\u202A\u200B\u200E\u200F\u200C\u206F\u206D\u202A\u200B\u206C\u200F\u202C\u200C\u200E\u200C\u202D\u202E\u206E\u202E\u200E\u202A\u202B\u206D\u202A\u200F\u206D\u206D\u206B\u200D\u206B\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}

			static string \u206E\u202C\u202D\u206B\u200E\u206E\u206F\u200E\u206D\u200F\u200D\u200B\u200E\u206E\u206D\u200B\u200B\u202C\u200D\u200F\u206C\u200C\u200D\u200C\u200B\u202E\u206A\u200D\u202B\u206C\u206C\u202A\u206E\u206B\u200D\u202B\u206F\u200D\u200C\u202E(string A_0, string A_1)
			{
				return A_0 + A_1;
			}

			static ArgumentOutOfRangeException \u206E\u200E\u206B\u206F\u200D\u202B\u206D\u202B\u200C\u200C\u206E\u206F\u202B\u206D\u202A\u206D\u202D\u206C\u200D\u200F\u202A\u202A\u202E\u202B\u202A\u202C\u202E\u200E\u202B\u202B\u200B\u200E\u200D\u206F\u202C\u200D\u206B\u202A\u202E\u206A\u202E()
			{
				return new ArgumentOutOfRangeException();
			}

			static int \u200E\u202A\u206B\u206D\u200B\u206D\u206C\u206B\u206E\u206D\u206E\u206C\u206C\u206A\u202E\u200F\u206D\u200B\u206E\u206C\u206A\u200E\u200C\u202B\u202C\u206E\u202C\u200E\u206B\u202D\u200C\u202B\u200E\u200F\u202E\u206C\u200D\u200C\u200E\u202D\u202E(Card A_0)
			{
				return A_0.ChoiceCardIndicator;
			}

			static BattleController \u200D\u200C\u206A\u200E\u202B\u206B\u206D\u202C\u202B\u200B\u206C\u202C\u202C\u206E\u206C\u200E\u206D\u202E\u202C\u206F\u202C\u200B\u206B\u206F\u206B\u200E\u206C\u200E\u206D\u200C\u200C\u200C\u200C\u200B\u206B\u206D\u202A\u202C\u206C\u202E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static bool \u200F\u206E\u202A\u206C\u202C\u202A\u200B\u206B\u202D\u200C\u206E\u206B\u200E\u200D\u206A\u200E\u206B\u200F\u200E\u206E\u202A\u202C\u202B\u202C\u200E\u200C\u202A\u202A\u200D\u206B\u200F\u202B\u202A\u206F\u200E\u200E\u200D\u200F\u202D\u206F\u202E(string A_0, string A_1)
			{
				return A_0 == A_1;
			}

			static string \u200B\u202C\u206E\u202A\u200C\u200C\u200E\u202C\u202C\u202D\u206F\u202B\u206F\u200D\u200F\u200F\u202D\u200E\u202C\u206E\u206B\u200E\u206F\u202C\u200D\u206B\u206D\u202C\u206E\u202C\u206A\u200D\u200D\u206A\u202B\u202B\u202A\u200E\u200F\u200E\u202E(GameEntity A_0)
			{
				return A_0.Id;
			}

			void \u206B\u200C\u202A\u202A\u206D\u206D\u206E\u202E\u206D\u200C\u206F\u202D\u206F\u200D\u200E\u206C\u200F\u206A\u206B\u200B\u206E\u202B\u206B\u206C\u200E\u200E\u206D\u202B\u206D\u206A\u202A\u206C\u206C\u202E\u206C\u206E\u200D\u202D\u206C\u206B\u202E()
			{
				base.Initialize();
			}

			static void \u206D\u200D\u206D\u200E\u202C\u202C\u206F\u206A\u206B\u206E\u206B\u200D\u200B\u202B\u200C\u200B\u206F\u206E\u206D\u206C\u202C\u200F\u206A\u206D\u202D\u206C\u202A\u202C\u202D\u200F\u200E\u206F\u200B\u200B\u202D\u206C\u206B\u202C\u202E\u206D\u202E(Card A_0, int? A_1)
			{
				A_0.DeckCounter = A_1;
			}

			static GameEvent<GameEventArgs> \u202D\u206C\u206F\u200F\u202A\u206D\u200B\u202D\u206A\u206E\u202D\u202C\u202C\u202A\u206E\u206E\u206E\u200B\u206C\u206E\u202E\u206F\u202E\u200C\u202C\u200B\u200B\u206B\u200C\u206E\u206B\u200C\u206A\u206A\u202D\u202B\u202C\u202B\u200F\u202E\u202E(BattleController A_0)
			{
				return A_0.BattleStarted;
			}

			static IEnumerable<EnemyUnit> \u206D\u200D\u202C\u202E\u206B\u200E\u202B\u202D\u206E\u200D\u202D\u202A\u206A\u206C\u202B\u202B\u202C\u200E\u200E\u206C\u202E\u206E\u202A\u200D\u200D\u202D\u202A\u206C\u202C\u206C\u202E\u206A\u206C\u202D\u202B\u206D\u206B\u200F\u206C\u202B\u202E(BattleController A_0)
			{
				return A_0.AllAliveEnemies;
			}

			static GameEvent<StatusEffectApplyEventArgs> \u202C\u206E\u206C\u200C\u206E\u200D\u202B\u202D\u200F\u200C\u206A\u200F\u206B\u200F\u206B\u200C\u206A\u202A\u206C\u200D\u206D\u206E\u200E\u206E\u206F\u206C\u206D\u202A\u200E\u200B\u200C\u202E\u200B\u202A\u200B\u206B\u200E\u202E\u206A\u206F\u202E(Unit A_0)
			{
				return A_0.StatusEffectAdded;
			}

			static bool \u200F\u206B\u202B\u206F\u202E\u206B\u202E\u206C\u200B\u200B\u202E\u200B\u206B\u200C\u202C\u200B\u200E\u206B\u200D\u200B\u200C\u200F\u202B\u206D\u206C\u200E\u206C\u200C\u206E\u200B\u200B\u200F\u202E\u206E\u200F\u200F\u206D\u206E\u202C\u206D\u202E(IEnumerator A_0)
			{
				return A_0.MoveNext();
			}

			static void \u200E\u200D\u206C\u202B\u200B\u202B\u200F\u206F\u200C\u202B\u200F\u200F\u200F\u206B\u206C\u202C\u206F\u202B\u200F\u206C\u202C\u200C\u200B\u206E\u202D\u202B\u200B\u202A\u200C\u206F\u206B\u206B\u206F\u202A\u202D\u200B\u202B\u206F\u202D\u202E(IDisposable A_0)
			{
				A_0.Dispose();
			}

			static GameEvent<UnitEventArgs> \u202A\u206C\u200C\u206D\u200C\u200B\u202B\u200C\u200F\u200B\u200F\u206A\u200F\u206B\u200B\u206A\u206F\u200B\u202E\u206E\u200B\u200F\u206A\u202A\u206F\u202C\u206C\u206A\u202A\u206F\u200C\u206C\u206C\u202B\u200C\u200B\u200D\u200B\u206B\u206A\u202E(BattleController A_0)
			{
				return A_0.EnemySpawned;
			}

			static PlayerUnit \u200D\u202D\u200E\u200E\u200C\u200F\u206C\u200C\u200B\u206A\u202D\u206A\u206A\u200C\u206C\u206D\u200D\u206E\u206A\u200F\u202C\u206B\u206E\u206A\u200B\u200B\u200C\u200C\u202A\u206F\u202B\u206B\u206B\u206E\u200B\u206F\u206F\u206F\u206B\u206F\u202E(BattleController A_0)
			{
				return A_0.Player;
			}

			static GameEvent<UnitEventArgs> \u202A\u200D\u200F\u200C\u200B\u202A\u206F\u200C\u206C\u200F\u200C\u200C\u200D\u202E\u200D\u202D\u200B\u200B\u206D\u200B\u206C\u202B\u206B\u202C\u202E\u206C\u206C\u206A\u202B\u202D\u202B\u206F\u202A\u202E\u206C\u202D\u202D\u206C\u200E\u200F\u202E(Unit A_0)
			{
				return A_0.TurnStarting;
			}

			static GameEvent<DamageDealingEventArgs> \u202A\u206B\u206A\u202B\u202E\u206E\u206A\u206E\u202D\u206C\u206C\u206B\u206A\u202E\u200D\u202C\u202B\u206D\u206E\u206D\u200F\u206E\u206D\u206D\u200D\u202D\u200E\u206E\u200D\u206C\u202C\u202E\u200C\u200F\u202D\u206D\u200B\u200B\u202A\u202B\u202E(Unit A_0)
			{
				return A_0.DamageDealing;
			}

			static GameEvent<CardUsingEventArgs> \u200E\u200B\u200D\u202B\u206D\u200D\u200E\u206B\u200C\u206F\u206D\u206A\u206A\u206B\u206A\u200F\u206D\u200C\u202C\u206C\u206A\u202C\u200B\u206A\u202C\u200C\u202E\u206F\u206A\u206F\u200C\u200B\u200B\u206A\u200C\u202B\u200B\u200C\u200B\u206F\u202E(BattleController A_0)
			{
				return A_0.CardUsed;
			}

			static GameEvent<CardsEventArgs> \u202C\u206A\u206E\u200F\u206A\u202B\u200D\u200C\u206A\u200B\u202C\u202C\u200F\u202A\u202E\u202C\u200C\u206A\u200C\u200F\u202A\u206D\u206F\u202D\u202C\u200C\u206B\u200F\u200E\u202A\u200C\u200D\u206F\u206F\u206D\u206A\u200E\u202E\u200F\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDiscard;
			}

			static GameEvent<CardsEventArgs> \u206E\u206A\u200B\u200F\u206C\u202C\u206F\u202E\u206F\u200B\u200F\u206E\u202C\u206A\u202D\u200E\u206B\u200D\u200C\u206B\u206A\u206B\u202A\u206C\u200E\u206C\u202B\u202A\u200D\u202C\u206C\u206B\u202B\u206A\u202B\u206F\u206B\u206D\u202C\u206A\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToHand;
			}

			static GameEvent<CardsEventArgs> \u202C\u202C\u202B\u200E\u200B\u202D\u202A\u202A\u202B\u200B\u200C\u202E\u206B\u202A\u200C\u202A\u200F\u202A\u206A\u206A\u202D\u200E\u202E\u202A\u202E\u202B\u202A\u206A\u200C\u202B\u202E\u202D\u206D\u200D\u206D\u206E\u206E\u206D\u200B\u206F\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToExile;
			}

			static GameEvent<CardsAddingToDrawZoneEventArgs> \u200E\u200C\u206A\u206D\u202B\u200C\u200D\u200F\u200D\u200B\u200B\u206E\u200B\u202B\u206D\u202B\u200D\u200D\u206C\u206D\u202A\u202E\u206F\u206F\u202B\u200E\u206E\u206A\u200D\u202E\u202C\u206D\u206C\u202E\u200E\u206D\u206F\u206D\u206F\u202B\u202E(BattleController A_0)
			{
				return A_0.CardsAddingToDrawZone;
			}

			static Unit \u200D\u206D\u200C\u206C\u202E\u202B\u200C\u206B\u206B\u200C\u200B\u206A\u206E\u200E\u206D\u202C\u200C\u202B\u206D\u200B\u200D\u202D\u206D\u200E\u206A\u200D\u206B\u202D\u200D\u200B\u200C\u200B\u200D\u206F\u202A\u206A\u206C\u206D\u202A\u200F\u202E(UnitEventArgs A_0)
			{
				return A_0.Unit;
			}

			static Reactor \u200C\u200F\u206E\u202C\u206E\u200B\u202D\u206A\u206C\u200D\u200E\u200B\u206A\u200E\u206E\u202A\u202B\u206B\u206F\u200C\u202E\u202B\u202E\u206B\u206C\u200B\u206E\u206D\u206B\u202D\u206F\u206D\u202B\u202E\u202C\u202D\u206A\u206B\u200D\u206E\u202E(BattleAction A_0)
			{
				return A_0;
			}

			static bool \u200E\u202B\u202E\u206F\u206F\u206C\u206C\u202E\u200B\u200C\u200E\u200E\u202C\u202E\u202C\u200D\u200D\u200B\u200E\u206F\u200B\u202C\u202D\u202A\u206C\u200E\u206C\u200F\u202A\u202C\u200E\u206C\u202B\u202A\u200F\u206E\u206D\u202E\u206E\u206B\u202E(Card A_0)
			{
				return A_0.Summoned;
			}

			static CardZone \u206F\u202B\u200F\u206D\u206D\u202C\u206B\u206B\u206D\u202D\u200D\u200C\u202A\u206B\u200C\u200B\u206E\u200C\u206D\u206A\u200F\u202D\u200E\u206B\u206F\u206F\u202A\u206D\u202E\u202C\u206C\u202A\u206E\u202A\u202D\u202C\u202B\u206D\u200D\u200C\u202E(Card A_0)
			{
				return A_0.Zone;
			}

			static GameEntity \u200E\u202A\u206D\u200F\u202B\u202B\u206A\u202D\u200D\u202E\u206D\u206F\u200E\u206C\u206D\u202E\u206D\u206C\u206E\u202A\u206E\u206C\u206B\u202B\u206E\u200F\u200E\u206A\u206D\u200D\u206E\u206E\u200B\u202E\u206E\u200E\u206B\u200D\u202A\u206F\u202E(GameEventArgs A_0)
			{
				return A_0.ActionSource;
			}

			static IReadOnlyList<Card> \u206C\u202E\u206C\u202A\u200D\u202D\u202C\u200D\u200D\u200F\u202D\u200D\u200F\u202C\u206A\u200D\u202A\u202E\u202A\u202C\u200B\u206B\u200F\u200F\u200F\u202B\u206E\u206B\u206C\u202D\u202C\u206C\u202A\u206C\u200C\u206B\u200B\u206F\u206D\u200D\u202E(BattleController A_0)
			{
				return A_0.HandZone;
			}

			static DamageInfo \u206F\u206D\u200B\u200B\u206C\u206D\u202E\u206D\u202D\u200C\u202D\u206A\u202E\u200E\u200E\u206C\u200C\u206D\u206B\u206A\u202C\u202B\u200E\u202E\u206D\u200C\u202D\u202E\u206C\u202E\u200E\u206A\u206E\u202E\u202A\u202E\u206A\u206C\u202D\u202A\u202E(DamageDealingEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static void \u200E\u206F\u202C\u202D\u206C\u200B\u200C\u202A\u202D\u206D\u202E\u200C\u206D\u206A\u202E\u202E\u206D\u200C\u202D\u200B\u206F\u202B\u206B\u206B\u200B\u206E\u206D\u200B\u202C\u202B\u200D\u202E\u202D\u206F\u202A\u206E\u202A\u206F\u200B\u206C\u202E(DamageDealingEventArgs A_0, DamageInfo A_1)
			{
				A_0.DamageInfo = A_1;
			}

			static void \u200C\u206A\u202A\u200B\u206F\u206C\u206C\u206C\u206A\u206F\u206E\u206A\u200D\u206F\u200E\u206B\u202D\u202D\u202E\u206B\u200B\u206C\u206F\u202A\u200B\u200F\u200E\u202A\u206A\u200E\u206B\u206A\u202A\u202A\u206D\u202D\u206C\u206C\u202B\u202A\u202E(GameEventArgs A_0, GameEntity A_1)
			{
				A_0.AddModifier(A_1);
			}

			static ActionCause \u202C\u200E\u202E\u202D\u200F\u202D\u202D\u200D\u200F\u200B\u202E\u206C\u202D\u206A\u206B\u202A\u206F\u200D\u202A\u202B\u206C\u200D\u202E\u202C\u206B\u206B\u206D\u202E\u206B\u202E\u200E\u202E\u200E\u202B\u202A\u202D\u206C\u202C\u206F\u206A\u202E(GameEventArgs A_0)
			{
				return A_0.Cause;
			}

			void \u206A\u206C\u202E\u202A\u202B\u202C\u202A\u202B\u200F\u206B\u206B\u202E\u206E\u202D\u200F\u200D\u200C\u200C\u202B\u206D\u202D\u200F\u202E\u202A\u206A\u206F\u206B\u202A\u202C\u200B\u206D\u206F\u202C\u200F\u206A\u202B\u202E\u206C\u202E\u206D\u202E()
			{
				base.NotifyActivating();
			}

			static IReadOnlyDictionary<Unit, IReadOnlyList<DamageEventArgs>> \u206E\u202B\u200E\u200E\u200F\u206E\u206F\u206B\u206E\u206D\u206A\u202A\u206E\u202E\u206C\u202E\u202D\u206B\u202B\u200C\u200C\u200D\u206F\u206F\u206B\u206D\u206B\u206B\u202D\u200B\u206D\u202E\u202D\u206F\u202A\u202C\u202D\u206E\u206C\u202C\u202E(StatisticalDamageEventArgs A_0)
			{
				return A_0.ArgsTable;
			}

			static DamageInfo \u206B\u206B\u200C\u200F\u202D\u200F\u202E\u206A\u206B\u206F\u202C\u200D\u200E\u200E\u202C\u206C\u200D\u202E\u202A\u202A\u200E\u202C\u202B\u202E\u202B\u200D\u200C\u206B\u206D\u202D\u206A\u202C\u200E\u202A\u202E\u206E\u202E\u206E\u206B\u206A\u202E(DamageEventArgs A_0)
			{
				return A_0.DamageInfo;
			}

			static int \u206D\u200F\u206F\u206B\u200F\u202D\u206F\u200E\u200F\u206F\u206F\u200F\u202B\u206C\u202A\u206C\u206C\u200B\u206E\u202B\u202C\u206A\u200F\u202E\u206E\u202B\u206F\u202E\u200E\u206B\u200E\u202D\u206A\u206F\u200E\u206B\u206B\u200C\u206F\u202E(float A_0)
			{
				return A_0.ToInt();
			}

			static HealAction \u200D\u206B\u200E\u200B\u206D\u202E\u206A\u202C\u206B\u202D\u200E\u200C\u206D\u206C\u202B\u206F\u200D\u200F\u200E\u202D\u206D\u206A\u206A\u200D\u200E\u200B\u202B\u202D\u202D\u206A\u200C\u206E\u206F\u206B\u200F\u206F\u200D\u200E\u206C\u206B\u202E(Unit A_0, Unit A_1, int A_2, HealType A_3, float A_4)
			{
				return new HealAction(A_0, A_1, A_2, A_3, A_4);
			}

			static void \u200B\u202D\u206E\u200C\u206E\u206F\u202C\u206B\u206D\u206D\u206F\u200B\u202A\u202A\u202D\u200B\u200F\u200D\u206C\u206F\u200F\u200E\u206D\u202E\u200C\u202B\u200D\u206D\u202C\u202B\u206B\u202D\u202D\u206D\u206A\u202E\u202B\u200B\u206F\u200F\u202E(Card A_0)
			{
				A_0.NotifyActivating();
			}

			static int \u200C\u202E\u206E\u202D\u200C\u206C\u200E\u200B\u206E\u206D\u200E\u202E\u206B\u200C\u202D\u200D\u206B\u206F\u206D\u206D\u200E\u200D\u206D\u206B\u202A\u202B\u202B\u206D\u202A\u206E\u206A\u206E\u206F\u206B\u206A\u206E\u200D\u202A\u206C\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static void \u202D\u200B\u206D\u206A\u206C\u206C\u200E\u202E\u202A\u200C\u206C\u206D\u200C\u206D\u200E\u202E\u200D\u206A\u200E\u200F\u206B\u206F\u200D\u206D\u206A\u202E\u200E\u202A\u200C\u200C\u206E\u206D\u202B\u206A\u206E\u206E\u206F\u206F\u206D\u200F\u202E(Card A_0, int A_1)
			{
				A_0.Loyalty = A_1;
			}

			static IEnumerable<BattleAction> \u200D\u206B\u206D\u206C\u206A\u200C\u202C\u206E\u200E\u202C\u200D\u202B\u200E\u206C\u206B\u200B\u206D\u202A\u206F\u200F\u202B\u202A\u206A\u202D\u200E\u206B\u206F\u202C\u206D\u206C\u206B\u206A\u206E\u202A\u206D\u202D\u206F\u206A\u206F\u206A\u202E(Card A_0)
			{
				return A_0.GetPassiveActions();
			}

			static int \u200C\u206B\u202D\u206A\u202E\u202E\u206E\u206B\u200F\u206C\u202D\u202E\u202B\u200C\u206E\u202E\u206C\u206D\u200C\u200D\u206D\u206C\u202D\u202D\u200D\u206A\u200E\u200D\u200B\u206C\u200C\u200F\u206D\u206A\u202E\u202D\u206B\u202C\u202A\u202B\u202E(Card A_0)
			{
				return A_0.Loyalty;
			}

			static IEnumerable<Card> \u200B\u200B\u202D\u206F\u202D\u206F\u202B\u202A\u202C\u206F\u202E\u206A\u202C\u202A\u206A\u202D\u202C\u206F\u200C\u206D\u200B\u202E\u202C\u200B\u202A\u200C\u200B\u200C\u202D\u202D\u200E\u200E\u200D\u206D\u202A\u206D\u200E\u202D\u200F\u200F\u202E(Card A_0, int A_1, bool A_2)
			{
				return A_0.Clone(A_1, A_2);
			}

			static void \u200B\u202B\u206D\u202B\u206C\u200D\u202B\u202C\u206E\u206E\u206E\u206E\u206B\u206E\u206E\u200C\u200C\u202A\u200E\u200E\u202B\u202D\u202B\u206B\u200F\u206A\u200F\u200F\u206B\u206D\u202E\u202D\u206F\u202A\u206D\u200F\u200C\u200B\u206A\u206E\u202E(Card A_0, int? A_1)
			{
				A_0.DeckCounter = A_1;
			}

			static void \u200C\u200D\u200C\u206C\u200E\u206E\u200E\u202C\u206D\u200F\u202B\u200E\u200D\u206B\u206D\u200D\u202E\u202C\u206B\u200B\u202A\u206C\u200B\u206A\u200F\u206C\u200E\u206E\u206F\u200B\u202B\u206D\u206A\u200B\u202A\u202B\u206A\u200B\u200D\u202E(Card A_0, FriendToken A_1)
			{
				A_0.FriendToken = A_1;
			}

			static FriendCostInfo \u206D\u202B\u206F\u200D\u206A\u202B\u206A\u202B\u200C\u206A\u206A\u202B\u202D\u200E\u206D\u206C\u202A\u206B\u206D\u206B\u200F\u202E\u200D\u206C\u200B\u200E\u202C\u200B\u206E\u202D\u202D\u206B\u200F\u202A\u200C\u200C\u206D\u200B\u206F\u206C\u202E(Card A_0)
			{
				return A_0.FriendU;
			}

			static FriendCostInfo \u206B\u202C\u200C\u200D\u200B\u206B\u206A\u200D\u202E\u206F\u202D\u200D\u200E\u200D\u206B\u200C\u206D\u202B\u202E\u206B\u202C\u206E\u202A\u200B\u206F\u200F\u206B\u202C\u202C\u206D\u202A\u202A\u206A\u202B\u202B\u206A\u206F\u200C\u206A\u200C\u202E(Card A_0)
			{
				return A_0.FriendA2;
			}

			static FriendCostInfo \u202C\u200C\u206A\u202B\u206A\u202D\u200F\u202D\u206B\u200C\u202D\u206C\u200F\u200F\u200D\u202A\u206F\u202D\u206C\u206C\u206A\u202E\u202E\u206D\u206A\u200D\u206C\u202A\u202A\u202A\u200D\u206B\u202E\u202E\u200F\u202E\u206E\u200D\u202A\u202E\u202E(Card A_0)
			{
				return A_0.FriendA;
			}

			static MiniSelectCardInteraction \u202C\u200D\u202B\u206B\u202E\u206A\u200E\u202D\u202B\u206A\u200D\u200D\u200C\u206F\u200D\u206C\u206A\u200D\u206F\u202A\u206C\u202C\u202B\u200E\u202E\u206A\u206D\u202D\u200F\u206C\u200F\u200F\u206A\u206F\u206A\u200D\u200B\u202C\u200F\u202E\u202E(IEnumerable<Card> A_0, bool A_1, bool A_2, bool A_3)
			{
				return new MiniSelectCardInteraction(A_0, A_1, A_2, A_3);
			}

			static bool \u202D\u202B\u206D\u202D\u206F\u206F\u200B\u200D\u206B\u206D\u202B\u206E\u202E\u206D\u206D\u200E\u202C\u206A\u202D\u206D\u206F\u202B\u206D\u202E\u200B\u206C\u202A\u200B\u202C\u200C\u206A\u206A\u206E\u206D\u200E\u202A\u202A\u200D\u202A\u202B\u202E(Card A_0)
			{
				return A_0.CanBeDuplicated;
			}

			[Flags]
			private enum Skills
			{
				None = 0,
				Kanako = 1,
				Suwako = 2,
				Sunny = 4,
				Luna = 8,
				Star = 16,
				Aya = 32,
				Rin = 64,
				Nitori = 128,
				Youmu = 256,
				Kokoro = 512,
				Clownpiece = 1024,
				Siji = 2048,
				Doremy = 4096,
				Reimu = 8192,
				Marisa = 16384,
				Sakuya = 32768,
				Cirno = 65536,
				Koishi = 131072,
				Megumu = 262144,
				Tianzi = 524288,
				Junko = 1048576,
				Seija = 2097152,
				Yiji = 4194304,
				Unknown = 8388608,
				Yukari = 16777216
			}
		}
	}
}
