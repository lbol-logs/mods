using System;
using System.Collections.Generic;
using System.Linq;
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
	public sealed class AyaFriendHatateNewsSpecialDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-2123724533);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaFriendHatateNewsSpecialDef.\u202B\u206F\u202A\u206F\u200D\u202D\u206A\u202E\u206A\u202C\u202B\u202E\u200F\u200D\u200D\u206D\u206F\u202A\u206F\u202D\u206C\u206E\u206F\u206A\u202A\u200C\u200C\u200D\u200B\u202B\u206B\u200F\u200D\u206C\u200E\u200B\u202E\u200B\u200C\u202E(BepinexPlugin.embeddedSource);
			AyaFriendHatateNewsSpecialDef.\u202A\u200C\u200E\u200B\u200C\u200B\u200B\u206D\u200C\u200C\u202C\u206D\u206B\u202E\u206F\u200D\u200F\u200B\u202D\u206F\u206C\u200D\u200B\u200B\u202C\u200C\u202A\u202A\u202A\u206B\u200C\u200D\u200D\u206F\u200B\u202D\u202B\u206E\u202C\u206C\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1353555862), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaFriendHatateNewsSpecialDef.\u206E\u206A\u202E\u200B\u202C\u206F\u206D\u202E\u200E\u206F\u206F\u200E\u200F\u200C\u206A\u202A\u202C\u202A\u202D\u206F\u206D\u206E\u200F\u206A\u202C\u202E\u200D\u200E\u202B\u202E\u202D\u206A\u200C\u206A\u200F\u200B\u206E\u200B\u206D\u202C\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaFriendHatateNewsSpecialDef.\u200C\u206F\u206D\u206E\u206F\u200E\u200C\u202D\u202A\u206F\u202A\u206C\u202C\u202E\u202D\u206E\u202E\u206A\u202C\u200D\u206E\u200E\u206A\u202D\u202A\u206C\u202C\u202D\u206D\u202C\u200E\u202C\u202D\u206A\u206C\u206A\u202A\u202C\u202C\u202E\u202E(BepinexPlugin.sequenceTable, AyaFriendHatateNewsSpecialDef.\u200D\u200B\u200E\u202E\u202C\u202A\u206A\u200F\u200C\u206B\u206F\u200C\u206F\u206E\u200B\u202A\u200F\u200C\u206E\u202B\u202E\u206A\u206F\u200B\u202C\u206C\u200C\u200D\u206D\u206C\u200E\u206D\u202C\u202E\u206C\u206F\u202A\u200C\u206A\u206A\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), 0, false, false, false, true, false, Rarity.Uncommon, CardType.Status, new TargetType?(TargetType.Nobody), new List<ManaColor>(), false, new ManaGroup
			{
				Any = 1
			}, null, null, null, null, null, null, null, null, new int?(1), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.Exile | Keyword.Replenish, Keyword.Exile | Keyword.Replenish, false, Keyword.Shield, Keyword.Shield, new List<string>(), new List<string>(), new List<string>(), new List<string>(), <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(1346999103), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(507849091), new List<string>());
		}

		static CardImages \u202B\u206F\u202A\u206F\u200D\u202D\u206A\u202E\u206A\u202C\u202B\u202E\u200F\u200D\u200D\u206D\u206F\u202A\u206F\u202D\u206C\u206E\u206F\u206A\u202A\u200C\u200C\u200D\u200B\u202B\u206B\u200F\u200D\u206C\u200E\u200B\u202E\u200B\u200C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u202A\u200C\u200E\u200B\u200C\u200B\u200B\u206D\u200C\u200C\u202C\u206D\u206B\u202E\u206F\u200D\u200F\u200B\u202D\u206F\u206C\u200D\u200B\u200B\u202C\u200C\u202A\u202A\u202A\u206B\u200C\u200D\u200D\u206F\u200B\u202D\u202B\u206E\u202C\u206C\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206E\u206A\u202E\u200B\u202C\u206F\u206D\u202E\u200E\u206F\u206F\u200E\u200F\u200C\u206A\u202A\u202C\u202A\u202D\u206F\u206D\u206E\u200F\u206A\u202C\u202E\u200D\u200E\u202B\u202E\u202D\u206A\u200C\u206A\u200F\u200B\u206E\u200B\u206D\u202C\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200D\u200B\u200E\u202E\u202C\u202A\u206A\u200F\u200C\u206B\u206F\u200C\u206F\u206E\u200B\u202A\u200F\u200C\u206E\u202B\u202E\u206A\u206F\u200B\u202C\u206C\u200C\u200D\u206D\u206C\u200E\u206D\u202C\u202E\u206C\u206F\u202A\u200C\u206A\u206A\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200C\u206F\u206D\u206E\u206F\u200E\u200C\u202D\u202A\u206F\u202A\u206C\u202C\u202E\u202D\u206E\u202E\u206A\u202C\u200D\u206E\u200E\u206A\u202D\u202A\u206C\u202C\u202D\u206D\u202C\u200E\u202C\u202D\u206A\u206C\u206A\u202A\u202C\u202C\u202E\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaFriendHatateNewsSpecialDef))]
		public sealed class AyaFriendHatateNewsSpecial : Card
		{
			public override bool OnDrawVisual
			{
				get
				{
					return false;
				}
			}

			public override bool OnMoveVisual
			{
				get
				{
					return false;
				}
			}

			public override int AdditionalValue1
			{
				get
				{
					if (AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.\u200D\u202C\u206A\u202D\u202C\u206E\u206C\u202A\u202A\u200B\u206C\u206D\u200B\u202B\u206B\u202A\u202D\u200C\u206F\u206F\u206E\u206C\u200C\u200F\u200F\u206F\u206B\u200F\u200C\u202D\u200B\u206F\u200B\u200D\u206F\u206E\u202E\u202D\u206E\u202E\u202E(this) == null)
					{
						for (;;)
						{
							int num = -1598677807;
							switch ((-(~((-1677047461 - 1825418066) * -55179663) - num) * -957214713 - -2030931657) % 3)
							{
							case 0:
								continue;
							case 2:
								return 0;
							}
							break;
						}
					}
					return AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.\u202A\u200D\u200D\u200E\u206B\u206F\u200D\u206C\u206A\u206A\u200D\u202C\u202A\u206A\u200B\u200B\u206A\u206A\u202B\u202C\u200F\u202B\u202B\u200F\u202B\u206E\u206B\u202A\u206F\u206A\u200B\u206F\u200D\u206D\u206E\u206C\u202D\u206A\u200B\u200E\u202E(AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.\u200D\u202C\u206A\u202D\u202C\u206E\u206C\u202A\u202A\u200B\u206C\u206D\u200B\u202B\u206B\u202A\u202D\u200C\u206F\u206F\u206E\u206C\u200C\u200F\u200F\u206F\u206B\u200F\u200C\u202D\u200B\u206F\u200B\u200D\u206F\u206E\u202E\u202D\u206E\u202E\u202E(this)).Count((Card card) => card is AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial);
				}
			}

			public override IEnumerable<BattleAction> OnDraw()
			{
				return this.EnterHandReactor();
			}

			public override IEnumerable<BattleAction> OnMove(CardZone srcZone, CardZone dstZone)
			{
				if (dstZone == CardZone.Hand)
				{
					for (;;)
					{
						int num = 1403980406;
						switch (((~num + ~(~-99553293)) ^ (-435776626 ^ -1846853864) ^ -652207060) % 3)
						{
						case 0:
							continue;
						case 1:
							goto IL_003D;
						}
						break;
					}
					goto IL_0053;
					IL_003D:
					return this.EnterHandReactor();
				}
				IL_0053:
				return null;
			}

			protected override void OnEnterBattle(BattleController battle)
			{
				if (AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.\u202A\u206C\u202D\u200C\u206B\u200F\u202C\u200E\u206B\u206A\u202E\u202A\u206E\u206C\u202D\u202E\u202B\u202D\u200D\u206F\u200C\u206D\u200F\u202A\u202E\u202A\u202E\u206A\u200E\u202A\u202D\u206D\u200B\u200F\u202C\u200C\u200B\u206F\u200E\u200E\u202E(this) == CardZone.Hand)
				{
					for (;;)
					{
						IL_0009:
						int num = 1918248637;
						for (;;)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-(~(num2 ^ (-1503039063 * -813928861))) + 663486772)) % 3U)
							{
							case 0U:
								goto IL_0009;
							case 2U:
								base.React(new LazySequencedReactor(this.AddToHandReactor));
								num = (int)((num3 * 845692497U) ^ 642696311U);
								continue;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			}

			private IEnumerable<BattleAction> AddToHandReactor()
			{
				AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<AddToHandReactor>d__9 <AddToHandReactor>d__ = new AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<AddToHandReactor>d__9(-2);
				<AddToHandReactor>d__.<>4__this = this;
				return <AddToHandReactor>d__;
			}

			private IEnumerable<BattleAction> EnterHandReactor()
			{
				AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<EnterHandReactor>d__10 <EnterHandReactor>d__ = new AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<EnterHandReactor>d__10(-2);
				<EnterHandReactor>d__.<>4__this = this;
				return <EnterHandReactor>d__;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<Actions>d__11 <Actions>d__ = new AyaFriendHatateNewsSpecialDef.AyaFriendHatateNewsSpecial.<Actions>d__11(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static BattleController \u200D\u202C\u206A\u202D\u202C\u206E\u206C\u202A\u202A\u200B\u206C\u206D\u200B\u202B\u206B\u202A\u202D\u200C\u206F\u206F\u206E\u206C\u200C\u200F\u200F\u206F\u206B\u200F\u200C\u202D\u200B\u206F\u200B\u200D\u206F\u206E\u202E\u202D\u206E\u202E\u202E(Card A_0)
			{
				return A_0.Battle;
			}

			static IReadOnlyList<Card> \u202A\u200D\u200D\u200E\u206B\u206F\u200D\u206C\u206A\u206A\u200D\u202C\u202A\u206A\u200B\u200B\u206A\u206A\u202B\u202C\u200F\u202B\u202B\u200F\u202B\u206E\u206B\u202A\u206F\u206A\u200B\u206F\u200D\u206D\u206E\u206C\u202D\u206A\u200B\u200E\u202E(BattleController A_0)
			{
				return A_0.ExileZone;
			}

			static CardZone \u202A\u206C\u202D\u200C\u206B\u200F\u202C\u200E\u206B\u206A\u202E\u202A\u206E\u206C\u202D\u202E\u202B\u202D\u200D\u206F\u200C\u206D\u200F\u202A\u202E\u202A\u202E\u206A\u200E\u202A\u202D\u206D\u200B\u200F\u202C\u200C\u200B\u206F\u200E\u200E\u202E(Card A_0)
			{
				return A_0.Zone;
			}
		}
	}
}
