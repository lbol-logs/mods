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
	public sealed class AyaCrossroadsofHeavenDef : CardTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IdContainer GetId()
		{
			return <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(49734040);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardImages LoadCardImages()
		{
			CardImages cardImages = AyaCrossroadsofHeavenDef.\u202D\u200B\u200D\u206B\u206D\u206D\u200B\u206C\u206E\u200E\u206C\u206A\u202B\u206B\u200E\u206F\u202C\u202D\u200B\u202C\u202A\u200D\u202C\u200E\u202E\u200B\u206F\u206D\u206D\u200F\u206F\u206D\u200E\u202B\u200C\u200C\u206A\u200E\u200F\u200C\u202E(BepinexPlugin.embeddedSource);
			AyaCrossroadsofHeavenDef.\u206B\u200D\u202D\u202A\u200E\u206A\u206D\u200C\u206D\u202D\u200C\u202C\u202A\u206F\u200F\u202D\u202E\u200D\u200C\u206B\u200D\u202E\u200B\u202B\u206B\u200E\u200D\u206D\u200F\u200E\u202C\u202D\u202A\u202D\u200C\u202E\u202B\u202D\u202B\u202E(cardImages, this, <Module>.\u202D\u206A\u202E\u202B\u206C\u200E\u206B\u206E\u200F\u206E\u200C\u202E\u206F\u200C\u206D\u200B\u206E\u200F\u200D\u202A\u206F\u202E\u200E\u206D\u206D\u206F\u202D\u200C\u206F\u202A\u200B\u202E\u206C\u206A\u206B\u202A\u206C\u202E\u200D\u202B\u202E<string>(529911995), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-904473020), false);
			return cardImages;
		}

		public override LocalizationOption LoadLocalization()
		{
			return AyaCrossroadsofHeavenDef.\u206C\u202B\u200C\u202E\u206A\u206E\u206C\u206F\u202A\u206C\u200C\u206F\u206B\u206E\u200D\u200D\u200E\u200D\u200C\u206F\u202D\u206E\u206B\u200F\u206C\u206C\u200F\u202B\u206E\u206F\u202B\u206A\u200B\u200D\u200B\u200C\u206D\u200F\u206E\u200E\u202E(BepinexPlugin.cardLoc, this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override CardConfig MakeConfig()
		{
			return new CardConfig(AyaCrossroadsofHeavenDef.\u200B\u200B\u200C\u202E\u202E\u206E\u206C\u200E\u206F\u200E\u206D\u202B\u202A\u202B\u202D\u206B\u202E\u206F\u202E\u200F\u200C\u200B\u206D\u202D\u206D\u206D\u206E\u202E\u202D\u202D\u200B\u202A\u206B\u206C\u200D\u202D\u200E\u206D\u202A\u202D\u202E(BepinexPlugin.sequenceTable, AyaCrossroadsofHeavenDef.\u200E\u206C\u202D\u202D\u202B\u206D\u200B\u200B\u202D\u202C\u202D\u206A\u200B\u200D\u200C\u202B\u200F\u206C\u206C\u200C\u202D\u202A\u202A\u202D\u200C\u206E\u206B\u202C\u200C\u206B\u200E\u206E\u202B\u206B\u202C\u202D\u202E\u202E\u202C\u200E\u202E(typeof(CardConfig).TypeHandle)), "", 10, true, new string[0][], <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(-1307230276), <Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-840054262), 0, false, true, false, true, true, Rarity.Uncommon, CardType.Ability, new TargetType?(TargetType.Self), new List<ManaColor> { ManaColor.White }, false, new ManaGroup
			{
				Any = 3,
				White = 1
			}, new ManaGroup?(new ManaGroup
			{
				Any = 1,
				White = 1
			}), null, null, null, null, null, null, null, null, null, new int?(4), null, new int?(1), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, Keyword.None, Keyword.None, false, Keyword.None, Keyword.None, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-955221521) }, new List<string> { <Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-955221521) }, new List<string>(), new List<string>(), <Module>.\u206A\u202A\u202B\u206E\u202B\u206A\u202E\u206A\u202A\u200D\u202B\u206E\u200B\u202A\u206D\u206E\u200C\u206B\u200D\u206B\u200F\u202A\u206D\u206E\u206E\u200B\u200C\u206D\u206D\u200D\u200E\u202A\u206C\u206A\u202D\u206C\u202B\u200E\u206A\u200F\u202E<string>(1432479242), null, "", "", false, <Module>.\u200F\u206C\u206A\u202D\u200D\u202B\u202B\u206B\u206A\u202C\u206C\u206B\u200B\u200D\u202E\u206F\u206C\u206E\u202E\u200D\u200F\u206D\u202A\u200B\u206D\u200B\u206F\u200D\u206B\u202E\u200F\u206D\u200B\u200F\u206D\u200D\u202C\u206C\u206C\u202E<string>(1006147776), new List<string>());
		}

		static CardImages \u202D\u200B\u200D\u206B\u206D\u206D\u200B\u206C\u206E\u200E\u206C\u206A\u202B\u206B\u200E\u206F\u202C\u202D\u200B\u202C\u202A\u200D\u202C\u200E\u202E\u200B\u206F\u206D\u206D\u200F\u206F\u206D\u200E\u202B\u200C\u200C\u206A\u200E\u200F\u200C\u202E(IResourceSource A_0)
		{
			return new CardImages(A_0);
		}

		static void \u206B\u200D\u202D\u202A\u200E\u206A\u206D\u200C\u206D\u202D\u200C\u202C\u202A\u206F\u200F\u202D\u202E\u200D\u200C\u206B\u200D\u202E\u200B\u202B\u206B\u200E\u200D\u206D\u200F\u200E\u202C\u202D\u202A\u202D\u200C\u202E\u202B\u202D\u202B\u202E(CardImages A_0, CardTemplate A_1, string A_2, string A_3, bool A_4)
		{
			A_0.AutoLoad(A_1, A_2, A_3, A_4);
		}

		static BatchLocalization \u206C\u202B\u200C\u202E\u206A\u206E\u206C\u206F\u202A\u206C\u200C\u206F\u206B\u206E\u200D\u200D\u200E\u200D\u200C\u206F\u202D\u206E\u206B\u200F\u206C\u206C\u200F\u202B\u206E\u206F\u202B\u206A\u200B\u200D\u200B\u200C\u206D\u200F\u206E\u200E\u202E(BatchLocalization A_0, EntityDefinition A_1)
		{
			return A_0.AddEntity(A_1);
		}

		static Type \u200E\u206C\u202D\u202D\u202B\u206D\u200B\u200B\u202D\u202C\u202D\u206A\u200B\u200D\u200C\u202B\u200F\u206C\u206C\u200C\u202D\u202A\u202A\u202D\u200C\u206E\u206B\u202C\u200C\u206B\u200E\u206E\u202B\u206B\u202C\u202D\u202E\u202E\u202C\u200E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		static int \u200B\u200B\u200C\u202E\u202E\u206E\u206C\u200E\u206F\u200E\u206D\u202B\u202A\u202B\u202D\u206B\u202E\u206F\u202E\u200F\u200C\u200B\u206D\u202D\u206D\u206D\u206E\u202E\u202D\u202D\u200B\u202A\u206B\u206C\u200D\u202D\u200E\u206D\u202A\u202D\u202E(TemplateSequenceTable A_0, Type A_1)
		{
			return A_0.Next(A_1);
		}

		[EntityLogic(typeof(AyaCrossroadsofHeavenDef))]
		public sealed class AyaCrossroadsofHeaven : Card
		{
			private string PhantasmModeDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u200C\u200F\u206A\u200D\u202B\u200C\u206F\u206A\u200C\u206D\u206C\u206E\u200C\u202B\u200C\u200C\u202A\u206D\u202E\u200F\u202D\u206C\u206C\u202B\u206A\u202C\u202D\u206C\u202C\u200D\u200F\u200F\u202C\u202C\u202B\u200D\u200E\u206D\u206D\u202E\u202E<string>(-766890246), true, true);
				}
			}

			private string PhantasmModeUpgradedDescription
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					return this.LocalizeProperty(<Module>.\u202D\u200F\u202D\u200B\u206C\u200B\u202B\u206C\u206E\u206E\u200C\u206B\u200D\u206B\u202B\u202A\u206F\u200C\u202E\u200D\u200B\u200B\u206F\u206B\u202C\u206F\u202E\u200B\u200B\u202C\u200C\u200E\u202C\u202C\u202C\u202B\u206D\u200D\u200E\u202A\u202E<string>(-166193966), true, true);
				}
			}

			protected override string GetBaseDescription()
			{
				if (BepinexPlugin.AyaPhantasmMode.Value)
				{
					goto IL_006C;
				}
				IL_000C:
				int num = -2102717951;
				IL_0011:
				int num2 = num;
				switch ((-num2 ^ -(-2119974694 * -643590231)) % 5)
				{
				case 0:
					IL_006C:
					num = ((!AyaCrossroadsofHeavenDef.AyaCrossroadsofHeaven.\u200F\u206C\u200E\u206A\u206D\u200B\u202D\u200C\u202D\u200C\u202D\u202A\u202E\u200E\u202E\u206A\u200F\u200B\u206A\u200C\u202D\u206A\u202A\u200F\u206A\u200F\u202C\u206E\u206B\u206E\u202E\u202B\u206D\u206A\u206D\u206F\u202C\u200E\u206A\u202C\u202E(this)) ? (-157000699) : (-1519200003));
					goto IL_0011;
				case 2:
					goto IL_000C;
				case 3:
					return this.PhantasmModeDescription;
				case 4:
					return base.GetBaseDescription();
				}
				return this.PhantasmModeUpgradedDescription ?? this.PhantasmModeDescription;
			}

			protected override IEnumerable<BattleAction> Actions(UnitSelector selector, ManaGroup consumingMana, Interaction precondition)
			{
				AyaCrossroadsofHeavenDef.AyaCrossroadsofHeaven.<Actions>d__5 <Actions>d__ = new AyaCrossroadsofHeavenDef.AyaCrossroadsofHeaven.<Actions>d__5(-2);
				<Actions>d__.<>4__this = this;
				return <Actions>d__;
			}

			static bool \u200F\u206C\u200E\u206A\u206D\u200B\u202D\u200C\u202D\u200C\u202D\u202A\u202E\u200E\u202E\u206A\u200F\u200B\u206A\u200C\u202D\u206A\u202A\u200F\u206A\u200F\u202C\u206E\u206B\u206E\u202E\u202B\u206D\u206A\u206D\u206F\u202C\u200E\u206A\u202C\u202E(Card A_0)
			{
				return A_0.IsUpgraded;
			}
		}
	}
}
