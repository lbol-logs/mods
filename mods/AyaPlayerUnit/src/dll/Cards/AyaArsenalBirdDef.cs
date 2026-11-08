using System;
using System.Collections.Generic;
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
	public sealed class AyaArsenalBirdDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(-1766398100);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaArsenalBirdDef.\u200E\u206C\u200F\u206A\u206B\u200E\u200E\u206B\u206F\u206B\u200B\u206B\u202C\u206D\u206D\u200D\u206C\u200D\u200F\u206B\u202A\u202C\u202B\u206D\u206E\u200D\u202A\u206E\u200D\u206E\u200B\u200E\u202A\u202A\u202D\u202E\u202D\u206C\u206D\u200D\u202E(BepinexPlugin.embeddedSource);
			AyaArsenalBirdDef.\u200D\u202A\u206C\u200C\u200E\u202A\u202B\u206C\u200D\u202B\u206F\u200D\u206D\u200C\u206D\u206B\u206B\u206C\u202D\u200E\u206F\u202E\u206A\u202D\u206C\u206B\u202C\u200E\u206A\u206C\u206D\u206D\u206A\u202C\u206B\u202D\u206B\u202B\u202A\u202D\u202E(cardImages, this, <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-402992198), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1283511019), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaArsenalBirdDef.\u200D\u200F\u206E\u206E\u202E\u202C\u200F\u206A\u206E\u206C\u200F\u206B\u202A\u202A\u202E\u202D\u202B\u200E\u202A\u206E\u200B\u206A\u200D\u206F\u200C\u206E\u202A\u202E\u206A\u206D\u206D\u202E\u206B\u206B\u202C\u206B\u206C\u202C\u206F\u206E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaArsenalBirdDef.\u200F\u206F\u202C\u200D\u206B\u200B\u206B\u202B\u202A\u200B\u200E\u200F\u206E\u206D\u206F\u206F\u200C\u206F\u200E\u200E\u206D\u206F\u200F\u206D\u206A\u202C\u206E\u206C\u200F\u206F\u202D\u206D\u202D\u206C\u202A\u200E\u202A\u200C\u206E\u206C\u202E(BepinexPlugin.sequenceTable, AyaArsenalBirdDef.\u206B\u200D\u206C\u200D\u206E\u206E\u200E\u200B\u206F\u206C\u202E\u202E\u202E\u200E\u200B\u206F\u200C\u206E\u202E\u206F\u202D\u206C\u202C\u200E\u200E\u206A\u206F\u206A\u200D\u200F\u206F\u206B\u200F\u206A\u206D\u202C\u202E\u206C\u200D\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(573603206), <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-497217431), 0, false, true, false, false, true, Rarity.Rare, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor>
			{
				ManaColor.Blue,
				ManaColor.Red,
				ManaColor.Green
			}, false, new ManaGroup
			{
				Any = 2,
				Blue = 1,
				Red = 1,
				Green = 1
			}, null, null, null, null, null, null, null, null, null, null, new int?(10), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1733889094) }, new List<string> { <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(-1671317516) }, new List<string> { <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(582848644) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(808178603) }, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1681863136), null, "", "", false, <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1388646766), new List<string>());
		}

		static CardImages \u200E\u206C\u200F\u206A\u206B\u200E\u200E\u206B\u206F\u206B\u200B\u206B\u202C\u206D\u206D\u200D\u206C\u200D\u200F\u206B\u202A\u202C\u202B\u206D\u206E\u200D\u202A\u206E\u200D\u206E\u200B\u200E\u202A\u202A\u202D\u202E\u202D\u206C\u206D\u200D\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u200D\u202A\u206C\u200C\u200E\u202A\u202B\u206C\u200D\u202B\u206F\u200D\u206D\u200C\u206D\u206B\u206B\u206C\u202D\u200E\u206F\u202E\u206A\u202D\u206C\u206B\u202C\u200E\u206A\u206C\u206D\u206D\u206A\u202C\u206B\u202D\u206B\u202B\u202A\u202D\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u200D\u200F\u206E\u206E\u202E\u202C\u200F\u206A\u206E\u206C\u200F\u206B\u202A\u202A\u202E\u202D\u202B\u200E\u202A\u206E\u200B\u206A\u200D\u206F\u200C\u206E\u202A\u202E\u206A\u206D\u206D\u202E\u206B\u206B\u202C\u206B\u206C\u202C\u206F\u206E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u206B\u200D\u206C\u200D\u206E\u206E\u200E\u200B\u206F\u206C\u202E\u202E\u202E\u200E\u200B\u206F\u200C\u206E\u202E\u206F\u202D\u206C\u202C\u200E\u200E\u206A\u206F\u206A\u200D\u200F\u206F\u206B\u200F\u206A\u206D\u202C\u202E\u206C\u200D\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200F\u206F\u202C\u200D\u206B\u200B\u206B\u202B\u202A\u200B\u200E\u200F\u206E\u206D\u206F\u206F\u200C\u206F\u200E\u200E\u206D\u206F\u200F\u206D\u206A\u202C\u206E\u206C\u200F\u206F\u202D\u206D\u202D\u206C\u202A\u200E\u202A\u200C\u206E\u206C\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaArsenalBirdDef))]
		public sealed class AyaArsenalBird : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-1578089449), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(1139567361), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_006F;
				}
				IL_000C:
				int num = 1764330240;
				IL_0011:
				int num2 = num;
				switch ((-(4598745 * -309230817 * -1638570905 - ~(-1263137474) - num2) + -1762044394) * -1336377645 % 5)
				{
				case 1:
					return this.PhantasmModeDescription;
				case 2:
					IL_006F:
					num = ((!AyaArsenalBirdDef.AyaArsenalBird.\u200B\u200B\u200E\u202B\u206D\u202D\u200D\u206C\u200E\u200D\u202E\u206F\u206E\u206D\u206E\u200F\u202B\u202C\u200D\u200B\u200F\u200B\u202D\u202E\u202D\u202A\u202D\u206B\u202C\u200D\u202B\u200C\u200C\u206E\u200E\u206E\u206A\u206D\u202B\u202E(this)) ? 527019927 : (-513497868));
					goto IL_0011;
				case 3:
					return base.GetBaseDescription();
				case 4:
					goto IL_000C;
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaArsenalBirdDef.AyaArsenalBird.<Actions>d__5 <Actions>d__ = new AyaArsenalBirdDef.AyaArsenalBird.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u200B\u200B\u200E\u202B\u206D\u202D\u200D\u206C\u200E\u200D\u202E\u206F\u206E\u206D\u206E\u200F\u202B\u202C\u200D\u200B\u200F\u200B\u202D\u202E\u202D\u202A\u202D\u206B\u202C\u200D\u202B\u200C\u200C\u206E\u200E\u206E\u206A\u206D\u202B\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
